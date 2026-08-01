#!/usr/bin/env python3
"""
batch_push.py -- push a huge pile of files to GitHub in size-capped chunks.

GitHub rejects any single push over ~2 GB with an opaque HTTP 500. This script
splits pending work into batches under a configurable size, committing and
pushing each one separately. Each push is its own pack, so each clears the cap.

Usage (from inside the repo):

    python batch_push.py                    # dry run, shows the plan
    python batch_push.py --go               # actually commit and push
    python batch_push.py --go --batch-mb 500

If a push fails partway, just run it again. Already-pushed batches are skipped
and any local commit that never made it up is retried first.
"""

import argparse
import subprocess
import sys
import os

# ---------------------------------------------------------------- git helpers


def git(*args, check=True, capture=True, stdin_data=None):
    """Run a git command. Returns stdout as str (or '' when capture=False)."""
    proc = subprocess.run(
        ["git"] + list(args),
        check=False,
        stdout=subprocess.PIPE if capture else None,
        stderr=subprocess.PIPE if capture else None,
        input=stdin_data.encode() if stdin_data is not None else None,
    )
    if check and proc.returncode != 0:
        err = (proc.stderr or b"").decode(errors="replace").strip()
        out = (proc.stdout or b"").decode(errors="replace").strip()
        raise RuntimeError(
            "git %s failed (exit %d)\n%s" % (" ".join(args), proc.returncode, err or out)
        )
    if not capture:
        return ""
    return (proc.stdout or b"").decode(errors="replace")


def git_ok(*args):
    """Run a git command, return True on success. Used for probing."""
    return subprocess.run(
        ["git"] + list(args),
        stdout=subprocess.DEVNULL,
        stderr=subprocess.DEVNULL,
    ).returncode == 0


def z_split(blob):
    """Split a NUL-delimited git output into a list, dropping the empty tail."""
    return [p for p in blob.split("\0") if p]


def human(n):
    for unit in ("B", "KB", "MB", "GB", "TB"):
        if n < 1024 or unit == "TB":
            return "%.1f %s" % (n, unit)
        n /= 1024.0


# ---------------------------------------------------------------- repo state


def repo_root():
    try:
        return git("rev-parse", "--show-toplevel").strip()
    except RuntimeError:
        sys.exit("Not inside a git repository.")


def current_branch():
    name = git("rev-parse", "--abbrev-ref", "HEAD").strip()
    if name == "HEAD":
        sys.exit("Detached HEAD. Check out a branch first.")
    return name


def unpushed_commits(branch, remote):
    """Commits on the local branch that the remote doesn't have."""
    upstream = "%s/%s" % (remote, branch)
    if not git_ok("rev-parse", "--verify", upstream):
        return []
    out = git("rev-list", "%s..%s" % (upstream, branch))
    return [line for line in out.split("\n") if line.strip()]


def soft_reset_to_remote(branch, remote, go):
    """
    Undo local-only commits without touching the working tree, so their contents
    can be recommitted in batches. Files stay exactly where they are on disk.
    """
    upstream = "%s/%s" % (remote, branch)
    ahead = unpushed_commits(branch, remote)
    if not ahead:
        return False
    print("Local branch is %d commit(s) ahead of %s." % (len(ahead), upstream))
    print("These will be unwound (--soft, files untouched) and rebuilt in batches.")
    if not go:
        print("  [dry run] would run: git reset --soft %s && git reset" % upstream)
        return True
    git("reset", "--soft", upstream, capture=False)
    git("reset", capture=False)  # unstage, leave worktree alone
    print("Unwound. Working tree untouched.\n")
    return True


# ---------------------------------------------------------------- work items


def pending_files(root):
    """
    Everything not yet in the remote's tree, as (path, size_bytes).
    Deleted paths get size 0.
    """
    untracked = z_split(git("ls-files", "--others", "--exclude-standard", "-z"))
    changed = z_split(git("diff", "--name-only", "-z", "HEAD"))

    seen, items = set(), []
    for path in untracked + changed:
        if path in seen:
            continue
        seen.add(path)
        full = os.path.join(root, path)
        try:
            size = os.path.getsize(full)
        except OSError:
            size = 0  # deleted, or a path git knows about but disk doesn't
        items.append((path, size))
    return items


def make_batches(items, limit_bytes):
    """
    Greedy bin-pack, largest first, so one huge file can't drag a batch over.
    A single file bigger than the limit gets a batch to itself.
    """
    items = sorted(items, key=lambda t: -t[1])
    batches, cur, cur_size = [], [], 0

    for path, size in items:
        if size >= limit_bytes:
            batches.append([(path, size)])
            continue
        if cur and cur_size + size > limit_bytes:
            batches.append(cur)
            cur, cur_size = [], 0
        cur.append((path, size))
        cur_size += size

    if cur:
        batches.append(cur)
    return batches


# ---------------------------------------------------------------- the work


def push_with_retry(remote, branch, attempts):
    for attempt in range(1, attempts + 1):
        proc = subprocess.run(["git", "push", remote, branch])
        if proc.returncode == 0:
            return True
        if attempt < attempts:
            print("  push failed, retrying (%d/%d)..." % (attempt + 1, attempts))
    return False


def run(args):
    root = repo_root()
    os.chdir(root)
    branch = args.branch or current_branch()
    remote = args.remote
    limit = args.batch_mb * 1024 * 1024

    print("repo    : %s" % root)
    print("branch  : %s -> %s" % (branch, remote))
    print("batch   : %s max\n" % human(limit))

    # Anything committed locally but never pushed goes up first, before we
    # start making new commits on top of it.
    leftover = unpushed_commits(branch, remote)
    if leftover and not args.rebuild:
        print("%d local commit(s) not on the remote. Pushing those first.\n" % len(leftover))
        if args.go:
            if not push_with_retry(remote, branch, args.retries):
                sys.exit(
                    "\nThat push failed. If it's a 500 after 'Writing objects: 100%',\n"
                    "the commit is too big by itself -- rerun with --rebuild to unwind\n"
                    "and split it."
                )
            print()
        else:
            print("  [dry run] would run: git push %s %s\n" % (remote, branch))

    if args.rebuild:
        soft_reset_to_remote(branch, remote, args.go)

    items = pending_files(root)
    if not items:
        print("Nothing pending. Working tree matches the last commit.")
        return

    total = sum(s for _, s in items)
    batches = make_batches(items, limit)
    print("%d file(s), %s total -> %d batch(es)\n" % (len(items), human(total), len(batches)))

    for i, batch in enumerate(batches, 1):
        size = sum(s for _, s in batch)
        label = "%s [%d/%d]" % (args.message, i, len(batches))
        print("-" * 60)
        print("Batch %d/%d: %d file(s), %s" % (i, len(batches), len(batch), size and human(size) or "0 B"))
        for path, fsize in batch[: args.preview]:
            print("    %s  (%s)" % (path, human(fsize)))
        if len(batch) > args.preview:
            print("    ... and %d more" % (len(batch) - args.preview))

        if not args.go:
            print("  [dry run] would add, commit as %r, and push" % label)
            continue

        # --pathspec-from-file avoids Windows' ~32k command line limit, which
        # a few hundred long DLL paths will blow right past.
        paths = "\0".join(p for p, _ in batch)
        git("add", "--all", "--pathspec-from-file=-", "--pathspec-file-nul", stdin_data=paths)

        if not git("diff", "--cached", "--name-only").strip():
            print("  nothing staged, skipping")
            continue

        git("commit", "-m", label, capture=False)
        print("  committed. pushing...")

        if not push_with_retry(remote, branch, args.retries):
            sys.exit(
                "\nBatch %d failed to push.\n"
                "The commit exists locally, so rerun this script to retry it.\n"
                "If it 500s again after 'Writing objects: 100%%', lower --batch-mb\n"
                "and rerun with --rebuild." % i
            )
        print("  pushed.\n")

    print("-" * 60)
    if args.go:
        print("Done. All batches pushed.")
        packed = git("count-objects", "-vH")
        for line in packed.split("\n"):
            if line.startswith("size-pack"):
                print("Repo pack size: %s" % line.split(":", 1)[1].strip())
    else:
        print("Dry run only. Rerun with --go to actually commit and push.")


def main():
    p = argparse.ArgumentParser(
        description="Commit and push large file sets in size-capped batches.",
        formatter_class=argparse.RawDescriptionHelpFormatter,
        epilog=__doc__,
    )
    p.add_argument("--go", action="store_true",
                   help="actually do it (default is a dry run)")
    p.add_argument("--batch-mb", type=int, default=800,
                   help="max MB per batch (default: 800)")
    p.add_argument("--remote", default="origin")
    p.add_argument("--branch", default=None,
                   help="defaults to the current branch")
    p.add_argument("--message", default="Add DLLs",
                   help="commit message prefix (default: 'Add DLLs')")
    p.add_argument("--rebuild", action="store_true",
                   help="unwind unpushed local commits (--soft) and rebatch "
                        "their contents; files on disk are never touched")
    p.add_argument("--retries", type=int, default=2,
                   help="push attempts per batch (default: 2)")
    p.add_argument("--preview", type=int, default=5,
                   help="files to list per batch (default: 5)")
    args = p.parse_args()

    try:
        run(args)
    except RuntimeError as e:
        sys.exit("\n%s" % e)
    except KeyboardInterrupt:
        sys.exit("\nInterrupted. Rerun to pick up where it left off.")


if __name__ == "__main__":
    main()
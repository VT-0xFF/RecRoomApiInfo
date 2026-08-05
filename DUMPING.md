# RecRoom Dumping Info
What each build era does to stop the metadata being read, and what it takes to get a dump out of it anyway.

# Every build from `14 December 2018 – 19:12:52 UTC` to `12 May 2026 – 18:46:14 UTC` is dumpable. There are four separate protections stacked up over the years, added one on top of another, and each one needs its own answer.

## Nothing here needs the game's servers, an account, or a debugger. The last two stages do need the game to actually run.

# Stage 1 - The obfuscated metadata header
Added shortly after `21 June 2023`, which is where the original dumps stopped.
* A normal `global-metadata.dat` starts with the magic `0xFAB11BAF`, a version int, and then 31 pairs of `{offset, size}` in a fixed order, one per table. These builds shuffle which pair belongs to which table and overwrite the magic and version, so nothing can read it.
* It is recoverable because the 31 tables **exactly tile the file** end to end. Solve for the chain through the header ints where `offset[i] + size[i] == offset[i+1]`, running from `0x100` to the end of the file, and you have the tables back in order. Two header slots are left over -- those are where the sanity and version fields used to be.
* Tiling alone is **not** enough, and this is the single easiest thing to get wrong. More than one assignment can tile the file perfectly and still be wrong, so every table then has to be identified by its actual contents -- fixed entry sizes, count chains that have to agree with each other, and range checks like every `dataIndex` landing inside the blob it points into. A wrong-but-self-consistent tiling silently mis-pairs one table and the dump looks fine until Cpp2IL chokes on it.
* Four metadata versions turn up across the range and each shifts the table layout: `v27`, `v29`, `v31` and `v31.1`.
  * `v27` to `v29` replaces `attributesInfo` (12 bytes an entry) with `attributeData` + `attributeDataRange` (8 bytes an entry, plus one sentinel entry whose `startOffset` is the total size of the blob).
  * `v29` to `v31` grows `Il2CppMethodDefinition` from 32 to 36 bytes, for the added `returnParameterToken`.
  * `v31` to `v31.1` grows `Il2CppCodeRegistration` from 15 to 17 qwords, from Unity `2022.3.33` onward.
* These builds also ship deliberately corrupted `<Module>` type definitions -- the `nameIndex` and `genericContainerIndex` are junk and have to be repaired or Cpp2IL falls over. It is a few hundred of them per build (346, 348 and 418 on the builds tested).

# Stage 2 - The binary side
* `Il2CppCodeRegistration` inside `GameAssembly.dll` gets its fields permuted the same way the metadata header does, and on top of that the `codeGenModules` array is shuffled out of image order.
* Cpp2IL indexes `codeGenModules` **positionally**, so the array has to be put back into image order or every method pointer ends up attached to the wrong assembly. The `12 May 2026 – 18:46:14 UTC` build has 419 modules.
* The rebuilt struct will sometimes overlap the module array it points at, in which case it has to be written somewhere else in free space with the old pointer cleared.
* Cpp2IL itself needs patching for these builds. `BinarySearcher.cs` has hardcoded scan limits (`0xA_0000` and `0x70_000`) and a 400 module cap that modern Rec Room blows straight past, and `FindCodeRegistrationPost2019` has to match the module count exactly instead of backtracking.

# Stage 3 - The dummy metadata and the encrypted binary
Starts at `5 September 2024 – 03:21:53 UTC`.
* `global-metadata.dat` is replaced with a dummy -- one repeated byte (`0x52`, ASCII `R`) for the entire file. On `12 May 2026 – 18:46:14 UTC` that is `52,403,096` bytes of nothing.
* Deleting the dummy does not work. IL2CPP still opens it and the game dies with "Failed to initialize IL2CPP", so the fake file has to stay exactly where it is.
* `GameAssembly.dll`'s `.text` and `il2cpp` sections are encrypted at rest as well -- entropy `8.000` on disk against about `6.3` once decrypted. `.rdata` and `.data` are left alone.
* So there is nothing left on disk to repair and the game has to genuinely run. Both get decrypted during `il2cpp_init`, in the first moments of startup, long before login, VR or networking, so it does not need to get far. It quits itself shortly after starting, so the dump has to win that race and suspend the process once it has a hit.
* Only a fraction of the install is needed to get that far: every root level file, plus `RecRoom_Data`'s `globalgamemanagers`, `boot.config`, `app.info`, the `.json` manifests, and the `Resources`, `UnitySubsystems` and `il2cpp_data` directories. Levels, sharedassets, resources.assets, the asset bundles, Plugins and EasyAntiCheat are all unnecessary. That is what takes the download from about `5.4 GB` down to about `325 MB` a build.
* The metadata **keeps its permuted header in memory too**, so there is no magic to scan for. Find it by its string table instead (`mscorlib.dll` is a reliable anchor) and take the start of the allocation it lives in as the header.
* Get the length by validation, never by guessing from the header. A wrong length can still tile cleanly and only falls apart at table identification, so candidate lengths have to be checked by actually identifying the tables. On the May 2026 build the obvious answer is `52,263,711` and the correct one is `52,403,096` -- `139,385` bytes out, which looks exactly like "the metadata has another encryption layer on it" when it is really just a bad carve.
* For the binary, take **only the code sections from memory** and everything else from the untouched disk file. A straight memory dump is not usable, because `il2cpp_init` rewrites `.data` in place -- type indices become live class pointers, field offsets get resolved -- and a static tool then reads pointers where it expects indices and dies. Base relocations inside the code have to be undone as well, since the module was loaded at an ASLR base, and the runtime only BSS tail grafted back on with its pointers rebased.

# Stage 4 - The Referee anti-cheat
Everything up to `10 November 2025 – 04:35:41 UTC` dumps with stage 3 alone. The builds from `2 December 2025 – 03:58:18 UTC` onward need this as well.
* These builds add `Referee.dll`, Themida packed, about 63 MB. `GameAssembly.dll`, `UnityPlayer.dll` and `baselib.dll` all import from it and from **nothing else** -- every real import is resolved at runtime by the protector.
* Referee is waiting on a global shared memory section named `KjMpQrStUvWxYzAb`, created at exactly `66,060,456` bytes. The consumer walks it as three chunks of `22,020,144` after a small header, so the size has to be right. It builds the name as `\BaseNamedObjects\...`, an absolute path, so it has to be the **global** namespace and not the per session one.
* If that section is not there, the session fails with status `-99903`, the code then reads through the null pointer it was left with, and `GameAssembly`'s DllMain never returns. No `il2cpp_init`, no metadata, nothing to dump. That is the entire wall.
* Creating the section is the whole fix. It can be all zeroes -- nothing verifies the contents, and there is no key or signature anywhere in Referee to forge. Then launch the game normally and it boots all the way through, into VR init, far past the point the metadata is decrypted.
* It has to be the **real game executable**. Loading `GameAssembly.dll` yourself, or swapping `Referee.dll` for a stub that exports its one function (`jjiEVn`), are both rejected before anything useful happens.
* Creating a global section needs `SeCreateGlobalPrivilege`, so this has to be run **elevated**. Without admin you silently get a per session section instead, the game never finds it, and it fails exactly as if there were none.
* From there take a full memory dump of the process once `GameAssembly.dll` is loaded, and carve the metadata and the binary out of it offline exactly as in stage 3.
* The section name and its size are the only build specific values in any of this. If a later build changes either, it will crash before `il2cpp_init` as though there were no section at all -- the name is a wide string inside that build's `Referee.dll` and the size is the maximum size it passes when creating it.

- *Automatically documented MD file, some details might be subtly wrong.*

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HMFAKCDPPEF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PJLPMLENHIL(int ECKHMCGBMKC, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PJLPMLENHIL(TimeSpan HOKDDKLAABJ, CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DCDDCDMPMOL : HMFAKCDPPEF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FED290", Offset = "0x6FEC290", VA = "0x186FED290")]
	[ONAOIKEPAJE(NOFONODCPKJ.Root, IKAJKCKEGIH.GameOnly)]
	private static void HDKCILMBALK(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	[Preserve]
	public DCDDCDMPMOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FED390", Offset = "0x6FEC390", VA = "0x186FED390", Slot = "4")]
	public Task PJLPMLENHIL(int ECKHMCGBMKC, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FED3F0", Offset = "0x6FEC3F0", VA = "0x186FED3F0", Slot = "5")]
	public Task PJLPMLENHIL(TimeSpan HOKDDKLAABJ, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LHPEKFDCAJE<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct FGBFMDECHBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest DKBJKMAMMMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> CLCJCAINMBI;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB852B0", Offset = "0xB842B0", VA = "0x180B852B0")]
		public FGBFMDECHBC(TRequest HHNBCLDGHCL, TaskCompletionSource<TResult> BBGHNPFEHON)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct GIEGGALJFAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public LHPEKFDCAJE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D70640", Offset = "0x3D6F640", VA = "0x183D70640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B980", Offset = "0x3D1A980", VA = "0x183D1B980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct OFAOIOEDMDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public LHPEKFDCAJE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x46E2140", Offset = "0x46E1140", VA = "0x1846E2140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x46E2520", Offset = "0x46E1520", VA = "0x1846E2520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct FFOOOJOILDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public LHPEKFDCAJE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3C2FE40", Offset = "0x3C2EE40", VA = "0x183C2FE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3C302F0", Offset = "0x3C2F2F0", VA = "0x183C302F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct NHLBFLKKBBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public LHPEKFDCAJE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<TRequest> <requests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x45E42E0", Offset = "0x45E32E0", VA = "0x1845E42E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x45E5480", Offset = "0x45E4480", VA = "0x1845E5480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly FFKLNDDHNMK<TRequest, TResult> LCBGGPIMJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float BJALKLIGCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HMFAKCDPPEF FLGCBEMBBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool ANPJLLBCKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<FGBFMDECHBC> CEIKHELJBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<FGBFMDECHBC> PDDHGGCBIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool CIKDLADKNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource DFGBAJLJFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource PHPFBPGBNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task DEMIENJNDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float JOLAJFGGJGG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HALEFOFGOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8517A0", Offset = "0x8507A0", VA = "0x1808517A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x851800", Offset = "0x850800", VA = "0x180851800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x42F4780", Offset = "0x42F3780", VA = "0x1842F4780")]
	public LHPEKFDCAJE(FFKLNDDHNMK<TRequest, TResult> LCBGGPIMJDB, TimeSpan BJALKLIGCBF, bool ANPJLLBCKDE, [Optional] HMFAKCDPPEF FLGCBEMBBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x42F40E0", Offset = "0x42F30E0", VA = "0x1842F40E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x42F3FC0", Offset = "0x42F2FC0", VA = "0x1842F3FC0")]
	[AsyncStateMachine(typeof(LHPEKFDCAJE<, >.GIEGGALJFAM))]
	public Task<TResult> DKGEMJAJOJB(TRequest HHNBCLDGHCL, [Optional] CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x42F3F20", Offset = "0x42F2F20", VA = "0x1842F3F20")]
	private void DKGEMJAJOJB(TRequest HHNBCLDGHCL, TaskCompletionSource<TResult> BBGHNPFEHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x42F3E60", Offset = "0x42F2E60", VA = "0x1842F3E60")]
	public Task CLNNPLFLMPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x42F43F0", Offset = "0x42F33F0", VA = "0x1842F43F0")]
	[AsyncStateMachine(typeof(LHPEKFDCAJE<, >.OFAOIOEDMDA))]
	private Task GPPPBCIIOAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x42F44C0", Offset = "0x42F34C0", VA = "0x1842F44C0")]
	[AsyncStateMachine(typeof(LHPEKFDCAJE<, >.FFOOOJOILDA))]
	private Task MAGCMMFKPOC(CancellationToken HPNOJHIJONG, CancellationToken DFFIFAAPGJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x42F4680", Offset = "0x42F3680", VA = "0x1842F4680")]
	[AsyncStateMachine(typeof(LHPEKFDCAJE<, >.NHLBFLKKBBE))]
	private Task PHLGMLPNGCM(CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x42F4310", Offset = "0x42F3310", VA = "0x1842F4310")]
	private TimeSpan GGCOGFEOMDK()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x42F3D40", Offset = "0x42F2D40", VA = "0x1842F3D40")]
	private Task<List<TResult>> CHFGFBAGHFG(IReadOnlyList<TRequest> BLJNPDNFNLG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x42F45E0", Offset = "0x42F35E0", VA = "0x1842F45E0")]
	private float PFNFDGPIHBC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x42F3CA0", Offset = "0x42F2CA0", VA = "0x1842F3CA0")]
	private void CFMOFJGDIPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PLIINMDDDEP<TItemId, TResult> : FFKLNDDHNMK<HHKFHPBJAEO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> HJFPAECEOHJ(Dictionary<TItemId, int> BLJNPDNFNLG, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PAEIPGLFGIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public PAEIPGLFGIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x478D410", Offset = "0x478C410", VA = "0x18478D410")]
		internal TResult LMKJIGPCEBB(HHKFHPBJAEO<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PCDPKINIMAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<HHKFHPBJAEO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public PLIINMDDDEP<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private PAEIPGLFGIE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4793AF0", Offset = "0x4792AF0", VA = "0x184793AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4794840", Offset = "0x4793840", VA = "0x184794840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HJFPAECEOHJ GCLJLMGGCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> PBGGGGHIKLD;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x41C0E70", Offset = "0x41BFE70", VA = "0x1841C0E70")]
	public PLIINMDDDEP(HJFPAECEOHJ GCLJLMGGCAN, [Optional] IEqualityComparer<TItemId> PBGGGGHIKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x47ACD80", Offset = "0x47ABD80", VA = "0x1847ACD80", Slot = "4")]
	[AsyncStateMachine(typeof(PLIINMDDDEP<, >.PCDPKINIMAK))]
	public Task<List<TResult>> APDKHOKEJIO(IReadOnlyList<HHKFHPBJAEO<TItemId>> BLJNPDNFNLG, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KDEFOJOBIHG<TRequest, TResult> : FFKLNDDHNMK<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> EIEGCPJJMLL(IEnumerable<TRequest> FKIKIMMBJOK, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class COEGNBLEKMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public COEGNBLEKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3C88CB0", Offset = "0x3C87CB0", VA = "0x183C88CB0")]
		internal TResult LMKJIGPCEBB(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct KBOCFIKCIOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IReadOnlyList<TRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public KDEFOJOBIHG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private COEGNBLEKMH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x41BF180", Offset = "0x41BE180", VA = "0x1841BF180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x41BFFD0", Offset = "0x41BEFD0", VA = "0x1841BFFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly EIEGCPJJMLL GCLJLMGGCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> PBGGGGHIKLD;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x41C0E70", Offset = "0x41BFE70", VA = "0x1841C0E70")]
	public KDEFOJOBIHG(EIEGCPJJMLL GCLJLMGGCAN, [Optional] IEqualityComparer<TRequest> PBGGGGHIKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x41C0D30", Offset = "0x41BFD30", VA = "0x1841C0D30", Slot = "4")]
	[AsyncStateMachine(typeof(KDEFOJOBIHG<, >.KBOCFIKCIOC))]
	public Task<List<TResult>> APDKHOKEJIO(IReadOnlyList<TRequest> BLJNPDNFNLG, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FFKLNDDHNMK<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> APDKHOKEJIO(IReadOnlyList<TRequest> BLJNPDNFNLG, CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MCAHEENDLGI<TItemId, TResult> : FFKLNDDHNMK<CJJFPDLGLNO<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task CPLEKHDOABB(IReadOnlyDictionary<TItemId, CJJFPDLGLNO<TItemId>.FNDEIABGNAD> BLJNPDNFNLG, CancellationToken LABHBAHABKB);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct HJLKHNLLCDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public MCAHEENDLGI<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<CJJFPDLGLNO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3DE0AD0", Offset = "0x3DDFAD0", VA = "0x183DE0AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE1020", Offset = "0x3DE0020", VA = "0x183DE1020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly CPLEKHDOABB BINBAMDFHGK;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	public MCAHEENDLGI(CPLEKHDOABB BINBAMDFHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x44D2E90", Offset = "0x44D1E90", VA = "0x1844D2E90", Slot = "4")]
	[AsyncStateMachine(typeof(MCAHEENDLGI<, >.HJLKHNLLCDA))]
	public Task<List<object>> APDKHOKEJIO(IReadOnlyList<CJJFPDLGLNO<TItemId>> BLJNPDNFNLG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x44D2FD0", Offset = "0x44D1FD0", VA = "0x1844D2FD0")]
	private IReadOnlyDictionary<TItemId, CJJFPDLGLNO<TItemId>.FNDEIABGNAD> KCOKPMHGAJG(IReadOnlyList<CJJFPDLGLNO<TItemId>> CGCHIPLGHPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PDEKJGKGLAA<TItemId, TResult> : FFKLNDDHNMK<HHKFHPBJAEO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> NNFOOBDENML(Dictionary<TItemId, int> BLJNPDNFNLG, CancellationToken LABHBAHABKB);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct AOJECPJEHAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<HHKFHPBJAEO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public PDEKJGKGLAA<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3F5AC60", Offset = "0x3F59C60", VA = "0x183F5AC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C580", Offset = "0x3F5B580", VA = "0x183F5C580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly NNFOOBDENML HLFHENKGLAB;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	public PDEKJGKGLAA(NNFOOBDENML GCLJLMGGCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x47A25D0", Offset = "0x47A15D0", VA = "0x1847A25D0", Slot = "4")]
	[AsyncStateMachine(typeof(PDEKJGKGLAA<, >.AOJECPJEHAG))]
	public Task<List<TResult>> APDKHOKEJIO(IReadOnlyList<HHKFHPBJAEO<TItemId>> BLJNPDNFNLG, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DEHHDJOEOIP<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, KDGMAMLGGIL> KFPANFEPGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> KJDHGIJJMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> LNMGHCCNLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> MHNAILBKCON;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, KDGMAMLGGIL> BKLNFIEBEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> MOOMIJEEGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HDHMNJECOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9ABFE0", Offset = "0x9AAFE0", VA = "0x1809ABFE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9ABFA0", Offset = "0x9AAFA0", VA = "0x1809ABFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x582B2F0", Offset = "0x582A2F0", VA = "0x18582B2F0")]
	public DEHHDJOEOIP(Func<IEnumerable<T>> LNMGHCCNLEL, Func<T, string> MHNAILBKCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x582B040", Offset = "0x582A040", VA = "0x18582B040")]
	public void GACAEOGENLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x582AFB0", Offset = "0x5829FB0", VA = "0x18582AFB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LAEHLIHJADB<TItemId, TResult> : LHPEKFDCAJE<HHKFHPBJAEO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x387A920", Offset = "0x3879920", VA = "0x18387A920")]
	public LAEHLIHJADB(FFKLNDDHNMK<HHKFHPBJAEO<TItemId>, TResult> LCBGGPIMJDB, TimeSpan BJALKLIGCBF, bool ANPJLLBCKDE, [Optional] HMFAKCDPPEF FLGCBEMBBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x42D2D70", Offset = "0x42D1D70", VA = "0x1842D2D70")]
	public Task<TResult> DKGEMJAJOJB(TItemId GMFCIHEFPPO, int BHANGKNKGFI, [Optional] CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HHKFHPBJAEO<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId EPLKLFDHBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int NMLPGOACBLB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7180", Offset = "0x3DD6180", VA = "0x183DD7180")]
	public HHKFHPBJAEO(TItemId NOEIAKHGLJH, int BHANGKNKGFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EDIDCJPOKJO<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid NOFPFFHHHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> GBALFINANAD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NPMHGGNAEHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface DKJOLPJMPEB
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int KFIJGJLPLBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool AKLJLBHEGGA<TParam>(TParam JJCEIJMGOAB);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HMMDBONGLGM(Exception KCICFLBDCAB);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool MHPNEPCCJED();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class PJODCAMEMMJ<TResult> : DKJOLPJMPEB, EDIDCJPOKJO<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> BCPBDDPEGFL;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid NOFPFFHHHNL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9A27D0", Offset = "0x9A17D0", VA = "0x1809A27D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int KFIJGJLPLBL
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9ABFE0", Offset = "0x9AAFE0", VA = "0x1809ABFE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> GBALFINANAD
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x45B80B0", Offset = "0x45B70B0", VA = "0x1845B80B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x47AA710", Offset = "0x47A9710", VA = "0x1847AA710")]
		public PJODCAMEMMJ(int CPGNKNHJLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2C05150", Offset = "0x2C04150", VA = "0x182C05150", Slot = "5")]
		public bool AKLJLBHEGGA<TParam>(TParam JJCEIJMGOAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x47AA670", Offset = "0x47A9670", VA = "0x1847AA670", Slot = "6")]
		public bool HMMDBONGLGM(Exception KCICFLBDCAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x47AA6C0", Offset = "0x47A96C0", VA = "0x1847AA6C0", Slot = "7")]
		public bool MHPNEPCCJED()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string JGPLEADPKJH = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, DKJOLPJMPEB> FAOFCMKGAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly BHGJOCABHDB CLCFJACBPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool KNJLCEJJPHC;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDB60", Offset = "0x6FECB60", VA = "0x186FEDB60")]
	public NPMHGGNAEHF([Optional] BHGJOCABHDB CLCFJACBPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6FED650", Offset = "0x6FEC650", VA = "0x186FED650", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2D10830", Offset = "0x2D0F830", VA = "0x182D10830")]
	public EDIDCJPOKJO<TResult> KILBMKGFCKK<TResult>(int JLMCFBBNHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2D104D0", Offset = "0x2D0F4D0", VA = "0x182D104D0")]
	public bool KHPCDDGLCCK<TResult>(Guid PHAMLENOBDP, TResult KNFGDDANCCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6FED760", Offset = "0x6FEC760", VA = "0x186FED760")]
	private void GEMEILJBOOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6FED650", Offset = "0x6FEC650", VA = "0x186FED650")]
	private void CKAEEPFEOJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6FED880", Offset = "0x6FEC880", VA = "0x186FED880")]
	private void NJNMCCEJADP(int CPGNKNHJLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6FED450", Offset = "0x6FEC450", VA = "0x186FED450")]
	private void CJEANKHKCFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum BLLMIBCFBPM
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class CJJFPDLGLNO<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class FNDEIABGNAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int NAGCHNLOCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int KGAOAFIKOMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int AEAPMILLDAA;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public FNDEIABGNAD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId EPLKLFDHBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int NMLPGOACBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public BLLMIBCFBPM BONFOCMGOKH;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x129C1A0", Offset = "0x129B1A0", VA = "0x18129C1A0")]
	public CJJFPDLGLNO(TItemId NOEIAKHGLJH, int BHANGKNKGFI, BLLMIBCFBPM IEJOAHLDAPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class CNIEIBIPJBE<TItemId, TResult> : LHPEKFDCAJE<CJJFPDLGLNO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5541B90", Offset = "0x5540B90", VA = "0x185541B90")]
	public CNIEIBIPJBE(FFKLNDDHNMK<CJJFPDLGLNO<TItemId>, TResult> LCBGGPIMJDB, TimeSpan BJALKLIGCBF, [Optional] HMFAKCDPPEF FLGCBEMBBNI)
	{
	}
}
namespace Cpp2IlInjected;

internal class AddressAttribute : Attribute
{
	public string RVA;

	public string Offset;

	public string VA;

	public string Slot;
}
internal class FieldOffsetAttribute : Attribute
{
	public string Offset;
}
internal class AttributeAttribute : Attribute
{
	public string Name;

	public string RVA;

	public string Offset;
}
internal class MetadataOffsetAttribute : Attribute
{
	public string Offset;
}
internal class TokenAttribute : Attribute
{
	public string Token;
}
internal class AnalysisFailedException : Exception
{
	public AnalysisFailedException(string message)
		: base(message)
	{
	}
}

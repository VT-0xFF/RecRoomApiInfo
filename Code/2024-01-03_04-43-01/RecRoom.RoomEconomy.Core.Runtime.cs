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
public interface PBHENDHOKAF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NDADJIAOEBI(int MGGHHCBGNGE, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NDADJIAOEBI(TimeSpan FIAMELCNGEM, CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PLINBPJPPPC : PBHENDHOKAF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x63C1DC0", Offset = "0x63C09C0", VA = "0x1863C1DC0")]
	[GFMBCOBENIN(MGPIABHDDAF.Root, CDPNEOMLNDL.GameOnly)]
	private static void JDNIOJNCFAB(OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	[Preserve]
	public PLINBPJPPPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x63C1EC0", Offset = "0x63C0AC0", VA = "0x1863C1EC0", Slot = "4")]
	public Task NDADJIAOEBI(int MGGHHCBGNGE, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x63C1F20", Offset = "0x63C0B20", VA = "0x1863C1F20", Slot = "5")]
	public Task NDADJIAOEBI(TimeSpan FIAMELCNGEM, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DENJOCDFOLG<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId IMJGFDPFADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int JCEPFBPMEAE;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E2F960", Offset = "0x4E2E560", VA = "0x184E2F960")]
	public DENJOCDFOLG(TItemId CKLLNKDGGIB, int HECECHIOFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EMGNHMKMAKK<TItemId, TResult> : ODIGCPGJJIM<DENJOCDFOLG<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3181710", Offset = "0x3180310", VA = "0x183181710")]
	public EMGNHMKMAKK(AJAHADDKLCF<DENJOCDFOLG<TItemId>, TResult> IANMCIDCHPA, TimeSpan IIDMKALIPOL, [Optional] PBHENDHOKAF LFIKMDIIECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x31815B0", Offset = "0x31801B0", VA = "0x1831815B0")]
	public Task<TResult> NEMCNFFBACC(TItemId PPNDANAOAMK, int HECECHIOFNI, [Optional] CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ODIGCPGJJIM<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct DLCEAMCLJAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest HIJGEDMINGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> KALLEBEIFGF;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x835CA0", Offset = "0x8348A0", VA = "0x180835CA0")]
		public DLCEAMCLJAF(TRequest NFAAJOAMBMN, TaskCompletionSource<TResult> ENLKJJMCJCI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct POIOBHILANC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public ODIGCPGJJIM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3EB92A0", Offset = "0x3EB7EA0", VA = "0x183EB92A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3EB97E0", Offset = "0x3EB83E0", VA = "0x183EB97E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GFLOJFAHDMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ODIGCPGJJIM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x35B62F0", Offset = "0x35B4EF0", VA = "0x1835B62F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x35B66C0", Offset = "0x35B52C0", VA = "0x1835B66C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct NCLBKPDBGOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ODIGCPGJJIM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3CFDF60", Offset = "0x3CFCB60", VA = "0x183CFDF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3CFE400", Offset = "0x3CFD000", VA = "0x183CFE400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FKLJAHNILJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public ODIGCPGJJIM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private List<TaskCompletionSource<TResult>> <taskCompletionSources>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x34EAEE0", Offset = "0x34E9AE0", VA = "0x1834EAEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x34EBE20", Offset = "0x34EAA20", VA = "0x1834EBE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AJAHADDKLCF<TRequest, TResult> IANMCIDCHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float IIDMKALIPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly PBHENDHOKAF LFIKMDIIECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<DLCEAMCLJAF> EGGNDDPPBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource PMFFLFJDOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource FCGDDKKILNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task BEOKNCJCIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float DFGEOMOKHMH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CBOMGKLCBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA1A600", Offset = "0xA19200", VA = "0x180A1A600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA1A900", Offset = "0xA19500", VA = "0x180A1A900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8870", Offset = "0x3DE7470", VA = "0x183DE8870")]
	public ODIGCPGJJIM(AJAHADDKLCF<TRequest, TResult> IANMCIDCHPA, TimeSpan IIDMKALIPOL, [Optional] PBHENDHOKAF LFIKMDIIECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7E70", Offset = "0x3DE6A70", VA = "0x183DE7E70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3DE85C0", Offset = "0x3DE71C0", VA = "0x183DE85C0")]
	[AsyncStateMachine(typeof(ODIGCPGJJIM<, >.POIOBHILANC))]
	public Task<TResult> NEMCNFFBACC(TRequest NFAAJOAMBMN, [Optional] CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8430", Offset = "0x3DE7030", VA = "0x183DE8430")]
	public Task JMGKFNGKCHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8350", Offset = "0x3DE6F50", VA = "0x183DE8350")]
	[AsyncStateMachine(typeof(ODIGCPGJJIM<, >.GFLOJFAHDMI))]
	private Task IPEMPKEDAMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8120", Offset = "0x3DE6D20", VA = "0x183DE8120")]
	[AsyncStateMachine(typeof(ODIGCPGJJIM<, >.NCLBKPDBGOH))]
	private Task FNLOJGOBMGF(CancellationToken BNLLGODACED, CancellationToken PGHHFFBPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3DE86E0", Offset = "0x3DE72E0", VA = "0x183DE86E0")]
	[AsyncStateMachine(typeof(ODIGCPGJJIM<, >.FKLJAHNILJJ))]
	private Task OGAKGAGOLBA(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3DE84F0", Offset = "0x3DE70F0", VA = "0x183DE84F0")]
	private TimeSpan LIKFICALJOG()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8240", Offset = "0x3DE6E40", VA = "0x183DE8240")]
	private Task<List<TResult>> GNMELNIPHEG(IReadOnlyList<TRequest> ENONDHKJMPC, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8080", Offset = "0x3DE6C80", VA = "0x183DE8080")]
	private float EKFMKFDPBLN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE87E0", Offset = "0x3DE73E0", VA = "0x183DE87E0")]
	private void PHFBCCMHIHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BILJFFNHCLG<TItemId, TResult> : AJAHADDKLCF<DENJOCDFOLG<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> MIIIGBAANME(Dictionary<TItemId, int> ENONDHKJMPC, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class EFFJFGGBJNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public EFFJFGGBJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3160840", Offset = "0x315F440", VA = "0x183160840")]
		internal TResult GLPLFDHFPDM(DENJOCDFOLG<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct NFNPCMKFOAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<DENJOCDFOLG<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public BILJFFNHCLG<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private EFFJFGGBJNI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D150F0", Offset = "0x3D13CF0", VA = "0x183D150F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3D15E40", Offset = "0x3D14A40", VA = "0x183D15E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly MIIIGBAANME BMKHDKCCGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> IAFEMJMABIL;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x398C460", Offset = "0x398B060", VA = "0x18398C460")]
	public BILJFFNHCLG(MIIIGBAANME BMKHDKCCGAO, [Optional] IEqualityComparer<TItemId> IAFEMJMABIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x459D9F0", Offset = "0x459C5F0", VA = "0x18459D9F0", Slot = "4")]
	[AsyncStateMachine(typeof(BILJFFNHCLG<, >.NFNPCMKFOAB))]
	public Task<List<TResult>> DAENNLJOCDI(IReadOnlyList<DENJOCDFOLG<TItemId>> ENONDHKJMPC, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KLKEMLBOKMJ<TRequest, TResult> : AJAHADDKLCF<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> ACEHFHDALMK(IEnumerable<TRequest> NLGFHGBNOGB, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class LDNELJBCJHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public LDNELJBCJHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x34C5C80", Offset = "0x34C4880", VA = "0x1834C5C80")]
		internal TResult GLPLFDHFPDM(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct JMGAAEHOIOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public IReadOnlyList<TRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public KLKEMLBOKMJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private LDNELJBCJHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x391BE50", Offset = "0x391AA50", VA = "0x18391BE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x391CC80", Offset = "0x391B880", VA = "0x18391CC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly ACEHFHDALMK BMKHDKCCGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> IAFEMJMABIL;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x398C460", Offset = "0x398B060", VA = "0x18398C460")]
	public KLKEMLBOKMJ(ACEHFHDALMK BMKHDKCCGAO, [Optional] IEqualityComparer<TRequest> IAFEMJMABIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x398C310", Offset = "0x398AF10", VA = "0x18398C310", Slot = "4")]
	[AsyncStateMachine(typeof(KLKEMLBOKMJ<, >.JMGAAEHOIOE))]
	public Task<List<TResult>> DAENNLJOCDI(IReadOnlyList<TRequest> ENONDHKJMPC, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface AJAHADDKLCF<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> DAENNLJOCDI(IReadOnlyList<TRequest> ENONDHKJMPC, CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EEKAJBKNDPO<TItemId, TResult> : AJAHADDKLCF<NDLEPDMCMPA<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task DDGKDCNJAAF(IReadOnlyDictionary<TItemId, NDLEPDMCMPA<TItemId>.HAMOJKOHLAE> ENONDHKJMPC, CancellationToken BJFJMBIBKLL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct OEIOADBJBPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public EEKAJBKNDPO<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IReadOnlyList<NDLEPDMCMPA<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE630", Offset = "0x3DED230", VA = "0x183DEE630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3DEEB60", Offset = "0x3DED760", VA = "0x183DEEB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly DDGKDCNJAAF LEDGBDLLKFK;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	public EEKAJBKNDPO(DDGKDCNJAAF LEDGBDLLKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x315FD30", Offset = "0x315E930", VA = "0x18315FD30", Slot = "4")]
	[AsyncStateMachine(typeof(EEKAJBKNDPO<, >.OEIOADBJBPM))]
	public Task<List<object>> DAENNLJOCDI(IReadOnlyList<NDLEPDMCMPA<TItemId>> ENONDHKJMPC, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x315FE70", Offset = "0x315EA70", VA = "0x18315FE70")]
	private IReadOnlyDictionary<TItemId, NDLEPDMCMPA<TItemId>.HAMOJKOHLAE> HNPDJIODGHH(IReadOnlyList<NDLEPDMCMPA<TItemId>> IMEFCDBPJJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OHEMMHCFJCJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Dictionary<string, JCCJFAAJOOF> PHEIMGDBGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private List<T> KNECEBEEELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private Func<IEnumerable<T>> NKJHJMKPBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Func<T, string> NBMFNCCOIOH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, JCCJFAAJOOF> JFOAPMMJAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> KLBJHMJLKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JLPAILAKOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x896A30", Offset = "0x895630", VA = "0x180896A30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x896A40", Offset = "0x895640", VA = "0x180896A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3DF8530", Offset = "0x3DF7130", VA = "0x183DF8530")]
	public OHEMMHCFJCJ(Func<IEnumerable<T>> NKJHJMKPBME, Func<T, string> NBMFNCCOIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3DF82B0", Offset = "0x3DF6EB0", VA = "0x183DF82B0")]
	public void OFENLADEDFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NKMEIEMEFJF<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid KIICMPDDCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> NIBCMNMBDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EEBCLJKMGHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private interface EDBOAMLAJOF
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int KEPKGJDABJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HOEDLCGOPGF<TParam>(TParam GCPEEAODAIB);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HMOCMFNKAOO(Exception PFNPJMEIKHD);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KHABHGFBIPN();
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class LLMEOMEPPCE<TResult> : EDBOAMLAJOF, NKMEIEMEFJF<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly TaskCompletionSource<TResult> PNJKDEENCLI;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid KIICMPDDCBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xB2A490", Offset = "0xB29090", VA = "0x180B2A490", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int KEPKGJDABJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x896A30", Offset = "0x895630", VA = "0x180896A30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> NIBCMNMBDCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x35A3B80", Offset = "0x35A2780", VA = "0x1835A3B80", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3A55980", Offset = "0x3A54580", VA = "0x183A55980")]
		public LLMEOMEPPCE(int ANKKHKEBLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x24320C0", Offset = "0x2430CC0", VA = "0x1824320C0", Slot = "5")]
		public bool HOEDLCGOPGF<TParam>(TParam GCPEEAODAIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3A55900", Offset = "0x3A54500", VA = "0x183A55900", Slot = "6")]
		public bool HMOCMFNKAOO(Exception PFNPJMEIKHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3A55940", Offset = "0x3A54540", VA = "0x183A55940", Slot = "7")]
		public bool KHABHGFBIPN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public const string HCLGPDMMCAN = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<Guid, EDBOAMLAJOF> BAECCNEPHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly OBILELMCLEM OGIIPLDMFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool NJICLLHEPDN;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x63C1CF0", Offset = "0x63C08F0", VA = "0x1863C1CF0")]
	public EEBCLJKMGHH([Optional] OBILELMCLEM OGIIPLDMFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x63C15D0", Offset = "0x63C01D0", VA = "0x1863C15D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x23CB400", Offset = "0x23CA000", VA = "0x1823CB400")]
	public NKMEIEMEFJF<TResult> LICFLGIBABK<TResult>(int DDENLCDEIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x23CB0D0", Offset = "0x23C9CD0", VA = "0x1823CB0D0")]
	public bool ILGHPBLCPBM<TResult>(Guid BJCCLJBIHHN, TResult HNCONAMCFGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x63C19D0", Offset = "0x63C05D0", VA = "0x1863C19D0")]
	private void NEELAPPDGLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x63C15D0", Offset = "0x63C01D0", VA = "0x1863C15D0")]
	private void JCIOFFJFDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x63C16E0", Offset = "0x63C02E0", VA = "0x1863C16E0")]
	private void LCLBCCDKOFE(int ANKKHKEBLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x63C1AF0", Offset = "0x63C06F0", VA = "0x1863C1AF0")]
	private void OFOKJOJKNIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum DKMLGKCDDFC
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NDLEPDMCMPA<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class HAMOJKOHLAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int APGCLKHPIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int CPKKACIGGEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int CFCHMLLOOEG;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public HAMOJKOHLAE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId IMJGFDPFADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int JCEPFBPMEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public DKMLGKCDDFC PAHPGGLPHDB;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xE0AAC0", Offset = "0xE096C0", VA = "0x180E0AAC0")]
	public NDLEPDMCMPA(TItemId CKLLNKDGGIB, int HECECHIOFNI, DKMLGKCDDFC NOOIIGLDGHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class AAOMEOJNEBL<TItemId, TResult> : ODIGCPGJJIM<NDLEPDMCMPA<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3181710", Offset = "0x3180310", VA = "0x183181710")]
	public AAOMEOJNEBL(AJAHADDKLCF<NDLEPDMCMPA<TItemId>, TResult> IANMCIDCHPA, TimeSpan IIDMKALIPOL, [Optional] PBHENDHOKAF LFIKMDIIECD)
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

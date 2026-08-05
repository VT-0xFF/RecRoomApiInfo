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
public interface ALJIBKCPHPH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BFHJGDLCICF(TimeSpan BFPKPKCNCFM, CancellationToken OMFABMCIOAC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KPLDJDPJDAC : ALJIBKCPHPH
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x62345D0", Offset = "0x62339D0", VA = "0x1862345D0")]
	[DCEDJGMCFCN(HKDEIDHACLB.Root, IIPPAMCLFBJ.GameOnly)]
	private static void KNIANBDCMAC(BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	[Preserve]
	public KPLDJDPJDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6234570", Offset = "0x6233970", VA = "0x186234570", Slot = "4")]
	public Task BFHJGDLCICF(TimeSpan BFPKPKCNCFM, CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EOGPNANKMJD<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId KAGDDPDJGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int GEOMIAIGACD;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x303D580", Offset = "0x303C980", VA = "0x18303D580")]
	public EOGPNANKMJD(TItemId MGBNLICKKPL, int LIFOPMMNLCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KNAPPOKFMCB<TItemId, TResult> : DEBDMANMPBO<EOGPNANKMJD<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x382A360", Offset = "0x3829760", VA = "0x18382A360")]
	public KNAPPOKFMCB(CBAPBENLCJG<EOGPNANKMJD<TItemId>, TResult> KFFHHEMGEHD, TimeSpan ECHJDAMJPHG, [Optional] ALJIBKCPHPH GFMMAILOGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3829F60", Offset = "0x3829360", VA = "0x183829F60")]
	public Task<TResult> LOBDJCHDIPA(TItemId IHHOPACLNAK, int LIFOPMMNLCI, [Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DEBDMANMPBO<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct HOKAPCBPHGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest DDIAGKIDPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> FMKONHDNBIO;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7CF750", Offset = "0x7CEB50", VA = "0x1807CF750")]
		public HOKAPCBPHGH(TRequest EJJHDDFDLOL, TaskCompletionSource<TResult> PBBFJNMKHCI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JAHCLMOEIBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public DEBDMANMPBO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x376E600", Offset = "0x376DA00", VA = "0x18376E600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x376EB00", Offset = "0x376DF00", VA = "0x18376EB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct MBHNCKABKIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public DEBDMANMPBO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA4E0", Offset = "0x3AE98E0", VA = "0x183AEA4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA8B0", Offset = "0x3AE9CB0", VA = "0x183AEA8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct DNNLPEKCFGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public DEBDMANMPBO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4D1E580", Offset = "0x4D1D980", VA = "0x184D1E580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4D1EA20", Offset = "0x4D1DE20", VA = "0x184D1EA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EILPNOLMCIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public DEBDMANMPBO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private List<TaskCompletionSource<TResult>> <taskCompletionSources>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3029390", Offset = "0x3028790", VA = "0x183029390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x302A2D0", Offset = "0x30296D0", VA = "0x18302A2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CBAPBENLCJG<TRequest, TResult> KFFHHEMGEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float ECHJDAMJPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly ALJIBKCPHPH GFMMAILOGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<HOKAPCBPHGH> DDPFBAJJKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource CBMILIGEANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource OGIOMGBFEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task OGFCOPBOHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float CHIHDMOONFM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DMGAPDBKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x978040", Offset = "0x977440", VA = "0x180978040")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x977FF0", Offset = "0x9773F0", VA = "0x180977FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4CE5970", Offset = "0x4CE4D70", VA = "0x184CE5970")]
	public DEBDMANMPBO(CBAPBENLCJG<TRequest, TResult> KFFHHEMGEHD, TimeSpan ECHJDAMJPHG, [Optional] ALJIBKCPHPH GFMMAILOGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4CE5150", Offset = "0x4CE4550", VA = "0x184CE5150", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4CE5670", Offset = "0x4CE4A70", VA = "0x184CE5670")]
	[AsyncStateMachine(typeof(DEBDMANMPBO<, >.JAHCLMOEIBG))]
	public Task<TResult> LOBDJCHDIPA(TRequest EJJHDDFDLOL, [Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4CE4F70", Offset = "0x4CE4370", VA = "0x184CE4F70")]
	public Task CNGHLPMHCGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4CE5490", Offset = "0x4CE4890", VA = "0x184CE5490")]
	[AsyncStateMachine(typeof(DEBDMANMPBO<, >.MBHNCKABKIP))]
	private Task KNLPEMAAJNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4CE5030", Offset = "0x4CE4430", VA = "0x184CE5030")]
	[AsyncStateMachine(typeof(DEBDMANMPBO<, >.DNNLPEKCFGH))]
	private Task COOPMGNKKMC(CancellationToken POMIHLMDLKH, CancellationToken MOIEBLPALLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4CE5570", Offset = "0x4CE4970", VA = "0x184CE5570")]
	[AsyncStateMachine(typeof(DEBDMANMPBO<, >.EILPNOLMCIN))]
	private Task LFFHNJCLPEA(CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4CE58A0", Offset = "0x4CE4CA0", VA = "0x184CE58A0")]
	private TimeSpan OCOKLLKGOIL()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4CE5790", Offset = "0x4CE4B90", VA = "0x184CE5790")]
	private Task<List<TResult>> NKGADNIIKHN(IReadOnlyList<TRequest> AHCDBFBGANG, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4CE5360", Offset = "0x4CE4760", VA = "0x184CE5360")]
	private float FNECLLFCBCE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4CE5400", Offset = "0x4CE4800", VA = "0x184CE5400")]
	private void HBLAGBGOMIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OLKKEMLHJIJ<TItemId, TResult> : CBAPBENLCJG<EOGPNANKMJD<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> ECBEFHMJJEI(Dictionary<TItemId, int> AHCDBFBGANG, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class OEMBNAJLIBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public OEMBNAJLIBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3CC31C0", Offset = "0x3CC25C0", VA = "0x183CC31C0")]
		internal TResult HNNAOFFPLNL(EOGPNANKMJD<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct EMOOHNJAFGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<EOGPNANKMJD<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public OLKKEMLHJIJ<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private OEMBNAJLIBE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x303B550", Offset = "0x303A950", VA = "0x18303B550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x303C2A0", Offset = "0x303B6A0", VA = "0x18303C2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ECBEFHMJJEI DMANOCDJLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> MMIDKDDGBBD;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38DBE40", Offset = "0x38DB240", VA = "0x1838DBE40")]
	public OLKKEMLHJIJ(ECBEFHMJJEI DMANOCDJLJK, [Optional] IEqualityComparer<TItemId> MMIDKDDGBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3CF2240", Offset = "0x3CF1640", VA = "0x183CF2240", Slot = "4")]
	[AsyncStateMachine(typeof(OLKKEMLHJIJ<, >.EMOOHNJAFGI))]
	public Task<List<TResult>> BGHPNPIJAPM(IReadOnlyList<EOGPNANKMJD<TItemId>> AHCDBFBGANG, CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class LHGMMGCIDOF<TRequest, TResult> : CBAPBENLCJG<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> CCADEJNBDJI(IEnumerable<TRequest> DKCFDFLJAIC, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class EJPGAIINJGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public EJPGAIINJGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x302AEB0", Offset = "0x302A2B0", VA = "0x18302AEB0")]
		internal TResult HNNAOFFPLNL(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct HGHPKENMPFA : IAsyncStateMachine
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
		public LHGMMGCIDOF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private EJPGAIINJGE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x351A4F0", Offset = "0x35198F0", VA = "0x18351A4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x351B320", Offset = "0x351A720", VA = "0x18351B320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CCADEJNBDJI DMANOCDJLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> MMIDKDDGBBD;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x38DBE40", Offset = "0x38DB240", VA = "0x1838DBE40")]
	public LHGMMGCIDOF(CCADEJNBDJI DMANOCDJLJK, [Optional] IEqualityComparer<TRequest> MMIDKDDGBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x38DBCF0", Offset = "0x38DB0F0", VA = "0x1838DBCF0", Slot = "4")]
	[AsyncStateMachine(typeof(LHGMMGCIDOF<, >.HGHPKENMPFA))]
	public Task<List<TResult>> BGHPNPIJAPM(IReadOnlyList<TRequest> AHCDBFBGANG, CancellationToken OMFABMCIOAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CBAPBENLCJG<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> BGHPNPIJAPM(IReadOnlyList<TRequest> AHCDBFBGANG, CancellationToken OMFABMCIOAC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JPLLEDCOACL<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid EHNJNMFMEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Task<TResult> AKFCAPPDBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ONHOONCBLDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private interface NFKJCLGBDBE
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		int FDNLHDFEJMH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool AGOPMIBOJDL(object LPCGJALKADL);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HLJGMMIODMP(Exception BGPAKNDLMFG);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool PNKKPKCPLMH();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class ENNPMNDDOBE<TResult> : NFKJCLGBDBE, JPLLEDCOACL<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly TaskCompletionSource<TResult> BPFHLDFGALC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Guid EHNJNMFMEDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA40000", Offset = "0xA3F400", VA = "0x180A40000", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int FDNLHDFEJMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7EF630", Offset = "0x7EEA30", VA = "0x1807EF630", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Task<TResult> AKFCAPPDBHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x303D120", Offset = "0x303C520", VA = "0x18303D120", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x303D1E0", Offset = "0x303C5E0", VA = "0x18303D1E0")]
		public ENNPMNDDOBE(int OIEAOPNGFAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x303CE30", Offset = "0x303C230", VA = "0x18303CE30", Slot = "5")]
		public bool AGOPMIBOJDL(object LPCGJALKADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x303D160", Offset = "0x303C560", VA = "0x18303D160", Slot = "6")]
		public bool HLJGMMIODMP(Exception BGPAKNDLMFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x303D1A0", Offset = "0x303C5A0", VA = "0x18303D1A0", Slot = "7")]
		public bool PNKKPKCPLMH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public const string HICPMIHEGOG = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly Dictionary<Guid, NFKJCLGBDBE> EKAADOKLJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly AAMMNFMHEOA HEGCMPKFNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private bool ADHFBEAGKHI;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6234F40", Offset = "0x6234340", VA = "0x186234F40")]
	public ONHOONCBLDP([Optional] AAMMNFMHEOA HEGCMPKFNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6234AE0", Offset = "0x6233EE0", VA = "0x186234AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x253B390", Offset = "0x253A790", VA = "0x18253B390")]
	public JPLLEDCOACL<TResult> HGOFLFDMNGD<TResult>(int GPIINMMNFJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6234DF0", Offset = "0x62341F0", VA = "0x186234DF0")]
	public bool LJAAEMLILKA(Guid CEMPKOIGLIO, object BBHPNPGLHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x62349C0", Offset = "0x6233DC0", VA = "0x1862349C0")]
	private void CNLGPGNAJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6234AE0", Offset = "0x6233EE0", VA = "0x186234AE0")]
	private void NBOFJIIIILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x62346D0", Offset = "0x6233AD0", VA = "0x1862346D0")]
	private void BFCOIGAOMHB(int OIEAOPNGFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6234BF0", Offset = "0x6233FF0", VA = "0x186234BF0")]
	private void KCMKLBFJLPJ()
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

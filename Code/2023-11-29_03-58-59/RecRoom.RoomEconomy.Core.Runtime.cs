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
public interface HANGJDNBIMN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ANFKNJJONKN(int MCMCAMBJKOA, CancellationToken EANFAKGANNH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ANFKNJJONKN(TimeSpan GGCCMMPEMEG, CancellationToken EANFAKGANNH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EEDGCICANBA : HANGJDNBIMN
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x63C0F80", Offset = "0x63C0380", VA = "0x1863C0F80")]
	[JMGGEKJCAGA(IHKKALDEJFL.Root, PLCOHLLKCIG.GameOnly)]
	private static void OODFKLIGDLO(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	[Preserve]
	public EEDGCICANBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x63C0F20", Offset = "0x63C0320", VA = "0x1863C0F20", Slot = "4")]
	public Task ANFKNJJONKN(int MCMCAMBJKOA, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x63C0EC0", Offset = "0x63C02C0", VA = "0x1863C0EC0", Slot = "5")]
	public Task ANFKNJJONKN(TimeSpan GGCCMMPEMEG, CancellationToken EANFAKGANNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BOIJOEFCNLK<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId KNBAFFKLPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int CPMOIOJGLCN;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x45870F0", Offset = "0x45864F0", VA = "0x1845870F0")]
	public BOIJOEFCNLK(TItemId JFJDHIBJIMN, int BDILOJCLFKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EFOLCGFEOKF<TItemId, TResult> : LDBBELBAAKO<BOIJOEFCNLK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x30EBC40", Offset = "0x30EB040", VA = "0x1830EBC40")]
	public EFOLCGFEOKF(EKHFNKJGKFB<BOIJOEFCNLK<TItemId>, TResult> POEFCKMDLDD, TimeSpan PHMJAPJEFEB, [Optional] HANGJDNBIMN AJOOMFMLLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x30EBAE0", Offset = "0x30EAEE0", VA = "0x1830EBAE0")]
	public Task<TResult> KDOJBMFHBBP(TItemId MIMFBLPNKOG, int BDILOJCLFKJ, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LDBBELBAAKO<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct FEKNLHEJHIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest NFHFCDODHPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> MEGFAJBBGPH;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82CA80", Offset = "0x82BE80", VA = "0x18082CA80")]
		public FEKNLHEJHIG(TRequest JAFMNEFDFCM, TaskCompletionSource<TResult> DIKGLCLJFIC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct AEGDLHHFLFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public LDBBELBAAKO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3559580", Offset = "0x3558980", VA = "0x183559580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3559AC0", Offset = "0x3558EC0", VA = "0x183559AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DPAHOEHPLKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public LDBBELBAAKO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4DEC810", Offset = "0x4DEBC10", VA = "0x184DEC810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4DECBE0", Offset = "0x4DEBFE0", VA = "0x184DECBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct GNPIBJFNHOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public LDBBELBAAKO<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x357B9B0", Offset = "0x357ADB0", VA = "0x18357B9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x357BE50", Offset = "0x357B250", VA = "0x18357BE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KLNABKLNCBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public LDBBELBAAKO<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x39D3940", Offset = "0x39D2D40", VA = "0x1839D3940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x39D4880", Offset = "0x39D3C80", VA = "0x1839D4880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EKHFNKJGKFB<TRequest, TResult> POEFCKMDLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float PHMJAPJEFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly HANGJDNBIMN AJOOMFMLLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<FEKNLHEJHIG> MDBHNABAEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource JECFHFDNHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource GBGLGMIMMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task AHHAODMPLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float GPPADNCLPKJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HCOCIBGGEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA1AFD0", Offset = "0xA1A3D0", VA = "0x180A1AFD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA1AB90", Offset = "0xA19F90", VA = "0x180A1AB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F520", Offset = "0x3A6E920", VA = "0x183A6F520")]
	public LDBBELBAAKO(EKHFNKJGKFB<TRequest, TResult> POEFCKMDLDD, TimeSpan PHMJAPJEFEB, [Optional] HANGJDNBIMN AJOOMFMLLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3A6EC40", Offset = "0x3A6E040", VA = "0x183A6EC40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F160", Offset = "0x3A6E560", VA = "0x183A6F160")]
	[AsyncStateMachine(typeof(LDBBELBAAKO<, >.AEGDLHHFLFF))]
	public Task<TResult> KDOJBMFHBBP(TRequest JAFMNEFDFCM, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F0A0", Offset = "0x3A6E4A0", VA = "0x183A6F0A0")]
	public Task JMFMIGPEDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A6EF20", Offset = "0x3A6E320", VA = "0x183A6EF20")]
	[AsyncStateMachine(typeof(LDBBELBAAKO<, >.DPAHOEHPLKD))]
	private Task IGDCDBADJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A6EB20", Offset = "0x3A6DF20", VA = "0x183A6EB20")]
	[AsyncStateMachine(typeof(LDBBELBAAKO<, >.GNPIBJFNHOF))]
	private Task DGKKBBHJKPP(CancellationToken EPJCCEJGNKI, CancellationToken FKOMMDMIFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F390", Offset = "0x3A6E790", VA = "0x183A6F390")]
	[AsyncStateMachine(typeof(LDBBELBAAKO<, >.KLNABKLNCBL))]
	private Task OHNFDEJFHOG(CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3A6EE50", Offset = "0x3A6E250", VA = "0x183A6EE50")]
	private TimeSpan FDBPLMNDCAA()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F280", Offset = "0x3A6E680", VA = "0x183A6F280")]
	private Task<List<TResult>> LDBLPCLGJMP(IReadOnlyList<TRequest> LMMCEFMHDDO, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F000", Offset = "0x3A6E400", VA = "0x183A6F000")]
	private float JGHAAEEOOIL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F490", Offset = "0x3A6E890", VA = "0x183A6F490")]
	private void PLGDCMHBEMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EAMLFGLEKLG<TItemId, TResult> : EKHFNKJGKFB<BOIJOEFCNLK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> MLMNKCANJKJ(Dictionary<TItemId, int> LMMCEFMHDDO, CancellationToken EANFAKGANNH);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class GNOGAPBAHCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public GNOGAPBAHCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x357B760", Offset = "0x357AB60", VA = "0x18357B760")]
		internal TResult HOLFCMHOEEA(BOIJOEFCNLK<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GGBDDLDFDNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<BOIJOEFCNLK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public EAMLFGLEKLG<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private GNOGAPBAHCE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x353ADE0", Offset = "0x353A1E0", VA = "0x18353ADE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x353BB30", Offset = "0x353AF30", VA = "0x18353BB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly MLMNKCANJKJ MALPLBHIJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> CIFLAHPMLGH;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x30E3CD0", Offset = "0x30E30D0", VA = "0x1830E3CD0")]
	public EAMLFGLEKLG(MLMNKCANJKJ MALPLBHIJFL, [Optional] IEqualityComparer<TItemId> CIFLAHPMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x30E3A30", Offset = "0x30E2E30", VA = "0x1830E3A30", Slot = "4")]
	[AsyncStateMachine(typeof(EAMLFGLEKLG<, >.GGBDDLDFDNF))]
	public Task<List<TResult>> AFCIKIFILBM(IReadOnlyList<BOIJOEFCNLK<TItemId>> LMMCEFMHDDO, CancellationToken EANFAKGANNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class NDMLCBJEGNA<TRequest, TResult> : EKHFNKJGKFB<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> MJBGBIFEOLK(IEnumerable<TRequest> GGLAHGHFNGH, CancellationToken EANFAKGANNH);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class HMLCDMPKMCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public HMLCDMPKMCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x30F8260", Offset = "0x30F7660", VA = "0x1830F8260")]
		internal TResult HOLFCMHOEEA(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct EAGINNBKPFO : IAsyncStateMachine
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
		public NDMLCBJEGNA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private HMLCDMPKMCK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x30E2A10", Offset = "0x30E1E10", VA = "0x1830E2A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x30E3840", Offset = "0x30E2C40", VA = "0x1830E3840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MJBGBIFEOLK MALPLBHIJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> CIFLAHPMLGH;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x30E3CD0", Offset = "0x30E30D0", VA = "0x1830E3CD0")]
	public NDMLCBJEGNA(MJBGBIFEOLK MALPLBHIJFL, [Optional] IEqualityComparer<TRequest> CIFLAHPMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D20C90", Offset = "0x3D20090", VA = "0x183D20C90", Slot = "4")]
	[AsyncStateMachine(typeof(NDMLCBJEGNA<, >.EAGINNBKPFO))]
	public Task<List<TResult>> AFCIKIFILBM(IReadOnlyList<TRequest> LMMCEFMHDDO, CancellationToken EANFAKGANNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EKHFNKJGKFB<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> AFCIKIFILBM(IReadOnlyList<TRequest> LMMCEFMHDDO, CancellationToken EANFAKGANNH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JONPFHMGJPL<TItemId, TResult> : EKHFNKJGKFB<DOCNCKPFHFI<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task OOHBGHMEOCK(IReadOnlyDictionary<TItemId, DOCNCKPFHFI<TItemId>.INJIGEJCAJM> LMMCEFMHDDO, CancellationToken EANFAKGANNH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct IGPILJCLEND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public JONPFHMGJPL<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IReadOnlyList<DOCNCKPFHFI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x37593C0", Offset = "0x37587C0", VA = "0x1837593C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x37598F0", Offset = "0x3758CF0", VA = "0x1837598F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly OOHBGHMEOCK GMDJPMACLCL;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77C090", VA = "0x18077CC90")]
	public JONPFHMGJPL(OOHBGHMEOCK GMDJPMACLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3915C10", Offset = "0x3915010", VA = "0x183915C10", Slot = "4")]
	[AsyncStateMachine(typeof(JONPFHMGJPL<, >.IGPILJCLEND))]
	public Task<List<object>> AFCIKIFILBM(IReadOnlyList<DOCNCKPFHFI<TItemId>> LMMCEFMHDDO, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3915D50", Offset = "0x3915150", VA = "0x183915D50")]
	private IReadOnlyDictionary<TItemId, DOCNCKPFHFI<TItemId>.INJIGEJCAJM> NJNGJILANIK(IReadOnlyList<DOCNCKPFHFI<TItemId>> IPFFHNGCBKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PIJJGAOONFJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Dictionary<string, JGFJPPAAAPI> BOLCBMEDOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private List<T> ENOOMPIGFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private Func<IEnumerable<T>> DECNFPLEOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Func<T, string> BMEIHLHAGDI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, JGFJPPAAAPI> NNMCDILJCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> EOFBKMMLJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int AGEKNAIPMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x896540", Offset = "0x895940", VA = "0x180896540")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x896550", Offset = "0x895950", VA = "0x180896550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3F1A610", Offset = "0x3F19A10", VA = "0x183F1A610")]
	public PIJJGAOONFJ(Func<IEnumerable<T>> DECNFPLEOPI, Func<T, string> BMEIHLHAGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3F1A390", Offset = "0x3F19790", VA = "0x183F1A390")]
	public void LFKJJNEOHNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface CJJJIAGMILD<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid MBFKGAOJHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> LHEKJPJNNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LAECKIOKPJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private interface HOJJOMCPNJM
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int ONBHNFNKONK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DPHLHJLKFPD<TParam>(TParam NMENOOMOOJP);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool EJPCDFHKBCL(Exception GAFOFJBHEBN);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool LNFPMLEOEOL();
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class PLGPHGELALH<TResult> : HOJJOMCPNJM, CJJJIAGMILD<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly TaskCompletionSource<TResult> KGCILHALMAA;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid MBFKGAOJHCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xB18E90", Offset = "0xB18290", VA = "0x180B18E90", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int ONBHNFNKONK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x896540", Offset = "0x895940", VA = "0x180896540", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> LHEKJPJNNEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x30F90E0", Offset = "0x30F84E0", VA = "0x1830F90E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F440", Offset = "0x3F1E840", VA = "0x183F1F440")]
		public PLGPHGELALH(int HEDJLOACGAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x244BB80", Offset = "0x244AF80", VA = "0x18244BB80", Slot = "5")]
		public bool DPHLHJLKFPD<TParam>(TParam NMENOOMOOJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F3C0", Offset = "0x3F1E7C0", VA = "0x183F1F3C0", Slot = "6")]
		public bool EJPCDFHKBCL(Exception GAFOFJBHEBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F400", Offset = "0x3F1E800", VA = "0x183F1F400", Slot = "7")]
		public bool LNFPMLEOEOL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public const string AAHABFPILLI = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<Guid, HOJJOMCPNJM> JGINGDKFJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly KCJLCLKIEKK HDNGDDHNCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool NEKCHAGONOF;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x63C17A0", Offset = "0x63C0BA0", VA = "0x1863C17A0")]
	public LAECKIOKPJM([Optional] KCJLCLKIEKK HDNGDDHNCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x63C1080", Offset = "0x63C0480", VA = "0x1863C1080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2580BC0", Offset = "0x257FFC0", VA = "0x182580BC0")]
	public CJJJIAGMILD<TResult> DMGNJALKFIC<TResult>(int DDNNBNDMJAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2580890", Offset = "0x257FC90", VA = "0x182580890")]
	public bool BEAAKOMANNI<TResult>(Guid CIIEMGNLEBA, TResult KHFCBCPBAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x63C1390", Offset = "0x63C0790", VA = "0x1863C1390")]
	private void KEJBBNHLPCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x63C1080", Offset = "0x63C0480", VA = "0x1863C1080")]
	private void DGCLABMIKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x63C14B0", Offset = "0x63C08B0", VA = "0x1863C14B0")]
	private void LOAOCPBJLDE(int HEDJLOACGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x63C1190", Offset = "0x63C0590", VA = "0x1863C1190")]
	private void ECBOCHDCHBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum IJKGLLAPBJM
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DOCNCKPFHFI<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class INJIGEJCAJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int NEDAJECIDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int CPFFLGBAKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int DDDHBOEOBHP;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public INJIGEJCAJM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId KNBAFFKLPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int CPMOIOJGLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public IJKGLLAPBJM EHCGCJFAGCN;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xE09320", Offset = "0xE08720", VA = "0x180E09320")]
	public DOCNCKPFHFI(TItemId JFJDHIBJIMN, int BDILOJCLFKJ, IJKGLLAPBJM HFLNDIDMJFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class OHGAKOKLKOA<TItemId, TResult> : LDBBELBAAKO<DOCNCKPFHFI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x30EBC40", Offset = "0x30EB040", VA = "0x1830EBC40")]
	public OHGAKOKLKOA(EKHFNKJGKFB<DOCNCKPFHFI<TItemId>, TResult> POEFCKMDLDD, TimeSpan PHMJAPJEFEB, [Optional] HANGJDNBIMN AJOOMFMLLIF)
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

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
	[Cpp2IlInjected.Address(RVA = "0x63C0EA0", Offset = "0x63C02A0", VA = "0x1863C0EA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x63C0E40", Offset = "0x63C0240", VA = "0x1863C0E40", Slot = "4")]
	public Task ANFKNJJONKN(int MCMCAMBJKOA, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x63C0DE0", Offset = "0x63C01E0", VA = "0x1863C0DE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4588510", Offset = "0x4587910", VA = "0x184588510")]
	public BOIJOEFCNLK(TItemId JFJDHIBJIMN, int BDILOJCLFKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EFOLCGFEOKF<TItemId, TResult> : LDBBELBAAKO<BOIJOEFCNLK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x30EBCD0", Offset = "0x30EB0D0", VA = "0x1830EBCD0")]
	public EFOLCGFEOKF(EKHFNKJGKFB<BOIJOEFCNLK<TItemId>, TResult> POEFCKMDLDD, TimeSpan PHMJAPJEFEB, [Optional] HANGJDNBIMN AJOOMFMLLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x30EBB70", Offset = "0x30EAF70", VA = "0x1830EBB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x82CAC0", Offset = "0x82BEC0", VA = "0x18082CAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3557020", Offset = "0x3556420", VA = "0x183557020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3557560", Offset = "0x3556960", VA = "0x183557560", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DEC6D0", Offset = "0x4DEBAD0", VA = "0x184DEC6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4DECAA0", Offset = "0x4DEBEA0", VA = "0x184DECAA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x357D0A0", Offset = "0x357C4A0", VA = "0x18357D0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x357D540", Offset = "0x357C940", VA = "0x18357D540", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x39D4EA0", Offset = "0x39D42A0", VA = "0x1839D4EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x39D5DE0", Offset = "0x39D51E0", VA = "0x1839D5DE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B080", Offset = "0xA1A480", VA = "0x180A1B080")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA1AC40", Offset = "0xA1A040", VA = "0x180A1AC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3A70990", Offset = "0x3A6FD90", VA = "0x183A70990")]
	public LDBBELBAAKO(EKHFNKJGKFB<TRequest, TResult> POEFCKMDLDD, TimeSpan PHMJAPJEFEB, [Optional] HANGJDNBIMN AJOOMFMLLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3A700B0", Offset = "0x3A6F4B0", VA = "0x183A700B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3A705D0", Offset = "0x3A6F9D0", VA = "0x183A705D0")]
	[AsyncStateMachine(typeof(LDBBELBAAKO<, >.AEGDLHHFLFF))]
	public Task<TResult> KDOJBMFHBBP(TRequest JAFMNEFDFCM, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3A70510", Offset = "0x3A6F910", VA = "0x183A70510")]
	public Task JMFMIGPEDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A70390", Offset = "0x3A6F790", VA = "0x183A70390")]
	[AsyncStateMachine(typeof(LDBBELBAAKO<, >.DPAHOEHPLKD))]
	private Task IGDCDBADJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A6FF90", Offset = "0x3A6F390", VA = "0x183A6FF90")]
	[AsyncStateMachine(typeof(LDBBELBAAKO<, >.GNPIBJFNHOF))]
	private Task DGKKBBHJKPP(CancellationToken EPJCCEJGNKI, CancellationToken FKOMMDMIFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A70800", Offset = "0x3A6FC00", VA = "0x183A70800")]
	[AsyncStateMachine(typeof(LDBBELBAAKO<, >.KLNABKLNCBL))]
	private Task OHNFDEJFHOG(CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3A702C0", Offset = "0x3A6F6C0", VA = "0x183A702C0")]
	private TimeSpan FDBPLMNDCAA()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3A706F0", Offset = "0x3A6FAF0", VA = "0x183A706F0")]
	private Task<List<TResult>> LDBLPCLGJMP(IReadOnlyList<TRequest> LMMCEFMHDDO, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3A70470", Offset = "0x3A6F870", VA = "0x183A70470")]
	private float JGHAAEEOOIL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3A70900", Offset = "0x3A6FD00", VA = "0x183A70900")]
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
		[Cpp2IlInjected.Address(RVA = "0x357CE50", Offset = "0x357C250", VA = "0x18357CE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x353C4D0", Offset = "0x353B8D0", VA = "0x18353C4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x353D220", Offset = "0x353C620", VA = "0x18353D220", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x30E3D60", Offset = "0x30E3160", VA = "0x1830E3D60")]
	public EAMLFGLEKLG(MLMNKCANJKJ MALPLBHIJFL, [Optional] IEqualityComparer<TItemId> CIFLAHPMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x30E3AC0", Offset = "0x30E2EC0", VA = "0x1830E3AC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x30F9850", Offset = "0x30F8C50", VA = "0x1830F9850")]
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
		[Cpp2IlInjected.Address(RVA = "0x30E2AA0", Offset = "0x30E1EA0", VA = "0x1830E2AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x30E38D0", Offset = "0x30E2CD0", VA = "0x1830E38D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x30E3D60", Offset = "0x30E3160", VA = "0x1830E3D60")]
	public NDMLCBJEGNA(MJBGBIFEOLK MALPLBHIJFL, [Optional] IEqualityComparer<TRequest> CIFLAHPMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D220E0", Offset = "0x3D214E0", VA = "0x183D220E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x375A970", Offset = "0x3759D70", VA = "0x18375A970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x375AEA0", Offset = "0x375A2A0", VA = "0x18375AEA0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3917130", Offset = "0x3916530", VA = "0x183917130", Slot = "4")]
	[AsyncStateMachine(typeof(JONPFHMGJPL<, >.IGPILJCLEND))]
	public Task<List<object>> AFCIKIFILBM(IReadOnlyList<DOCNCKPFHFI<TItemId>> LMMCEFMHDDO, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3917270", Offset = "0x3916670", VA = "0x183917270")]
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
		[Cpp2IlInjected.Address(RVA = "0x896580", Offset = "0x895980", VA = "0x180896580")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x896590", Offset = "0x895990", VA = "0x180896590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3F1BA30", Offset = "0x3F1AE30", VA = "0x183F1BA30")]
	public PIJJGAOONFJ(Func<IEnumerable<T>> DECNFPLEOPI, Func<T, string> BMEIHLHAGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3F1B7B0", Offset = "0x3F1ABB0", VA = "0x183F1B7B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xB18F40", Offset = "0xB18340", VA = "0x180B18F40", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x896580", Offset = "0x895980", VA = "0x180896580", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x30FA6D0", Offset = "0x30F9AD0", VA = "0x1830FA6D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3F20860", Offset = "0x3F1FC60", VA = "0x183F20860")]
		public PLGPHGELALH(int HEDJLOACGAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x244BC10", Offset = "0x244B010", VA = "0x18244BC10", Slot = "5")]
		public bool DPHLHJLKFPD<TParam>(TParam NMENOOMOOJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3F207E0", Offset = "0x3F1FBE0", VA = "0x183F207E0", Slot = "6")]
		public bool EJPCDFHKBCL(Exception GAFOFJBHEBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3F20820", Offset = "0x3F1FC20", VA = "0x183F20820", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x63C16C0", Offset = "0x63C0AC0", VA = "0x1863C16C0")]
	public LAECKIOKPJM([Optional] KCJLCLKIEKK HDNGDDHNCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x63C0FA0", Offset = "0x63C03A0", VA = "0x1863C0FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2580C50", Offset = "0x2580050", VA = "0x182580C50")]
	public CJJJIAGMILD<TResult> DMGNJALKFIC<TResult>(int DDNNBNDMJAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2580920", Offset = "0x257FD20", VA = "0x182580920")]
	public bool BEAAKOMANNI<TResult>(Guid CIIEMGNLEBA, TResult KHFCBCPBAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x63C12B0", Offset = "0x63C06B0", VA = "0x1863C12B0")]
	private void KEJBBNHLPCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x63C0FA0", Offset = "0x63C03A0", VA = "0x1863C0FA0")]
	private void DGCLABMIKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x63C13D0", Offset = "0x63C07D0", VA = "0x1863C13D0")]
	private void LOAOCPBJLDE(int HEDJLOACGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x63C10B0", Offset = "0x63C04B0", VA = "0x1863C10B0")]
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
	[Cpp2IlInjected.Address(RVA = "0xE093D0", Offset = "0xE087D0", VA = "0x180E093D0")]
	public DOCNCKPFHFI(TItemId JFJDHIBJIMN, int BDILOJCLFKJ, IJKGLLAPBJM HFLNDIDMJFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class OHGAKOKLKOA<TItemId, TResult> : LDBBELBAAKO<DOCNCKPFHFI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x30EBCD0", Offset = "0x30EB0D0", VA = "0x1830EBCD0")]
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

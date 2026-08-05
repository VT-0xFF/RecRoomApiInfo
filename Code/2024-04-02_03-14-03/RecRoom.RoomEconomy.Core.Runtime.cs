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
public interface LFEGMOABMDL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BAOCMKHHAJB(int EJELKNHNKPA, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BAOCMKHHAJB(TimeSpan NGMMFCAABCL, CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GCFMBBJPAOK : LFEGMOABMDL
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x66EC860", Offset = "0x66EB460", VA = "0x1866EC860")]
	[JDFNDIEGGDI(EEILJHHLCPL.Root, COFBNFOEGIB.GameOnly)]
	private static void KPHMLLKABCG(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	[Preserve]
	public GCFMBBJPAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x66EC7A0", Offset = "0x66EB3A0", VA = "0x1866EC7A0", Slot = "4")]
	public Task BAOCMKHHAJB(int EJELKNHNKPA, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x66EC800", Offset = "0x66EB400", VA = "0x1866EC800", Slot = "5")]
	public Task BAOCMKHHAJB(TimeSpan NGMMFCAABCL, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HEOELJPFAIO<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct FDEINCKOBKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest CHEEEBNKDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> HGMPLOMLBEF;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x902320", Offset = "0x900F20", VA = "0x180902320")]
		public FDEINCKOBKE(TRequest MLHMNLDOBPP, TaskCompletionSource<TResult> CCLGFPLJJNF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct AHCFDIMBLHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public HEOELJPFAIO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x37CAFB0", Offset = "0x37C9BB0", VA = "0x1837CAFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x37CB4F0", Offset = "0x37CA0F0", VA = "0x1837CB4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct MPGOFDMOHNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public HEOELJPFAIO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3EA74B0", Offset = "0x3EA60B0", VA = "0x183EA74B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3EA7880", Offset = "0x3EA6480", VA = "0x183EA7880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct DBFPMKLHADH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HEOELJPFAIO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5031760", Offset = "0x5030360", VA = "0x185031760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5031C00", Offset = "0x5030800", VA = "0x185031C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct IGMPAJAOKEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public HEOELJPFAIO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private List<TaskCompletionSource<TResult>> <taskCompletionSources>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x393D300", Offset = "0x393BF00", VA = "0x18393D300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x393E240", Offset = "0x393CE40", VA = "0x18393E240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HLJOMAFDFHA<TRequest, TResult> HGLHGFIFHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float KMOACJPOBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LFEGMOABMDL DNILIKBCNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<FDEINCKOBKE> IDDEIKHDDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource GMNNJJHFIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource JBHCJCJNNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task KFFJCFPCMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float KLBLAKBJGGP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CPEAOGPNKMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAFD0D0", Offset = "0xAFBCD0", VA = "0x180AFD0D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAFD410", Offset = "0xAFC010", VA = "0x180AFD410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x38698D0", Offset = "0x38684D0", VA = "0x1838698D0")]
	public HEOELJPFAIO(HLJOMAFDFHA<TRequest, TResult> HGLHGFIFHGN, TimeSpan KMOACJPOBPP, [Optional] LFEGMOABMDL DNILIKBCNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3869150", Offset = "0x3867D50", VA = "0x183869150", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x38697B0", Offset = "0x38683B0", VA = "0x1838697B0")]
	[AsyncStateMachine(typeof(HEOELJPFAIO<, >.AHCFDIMBLHD))]
	public Task<TResult> PLCNFHBCIFK(TRequest MLHMNLDOBPP, [Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3869650", Offset = "0x3868250", VA = "0x183869650")]
	public Task NMPPKAHHOGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3869070", Offset = "0x3867C70", VA = "0x183869070")]
	[AsyncStateMachine(typeof(HEOELJPFAIO<, >.MPGOFDMOHNE))]
	private Task DFBHEGKHEON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3869530", Offset = "0x3868130", VA = "0x183869530")]
	[AsyncStateMachine(typeof(HEOELJPFAIO<, >.DBFPMKLHADH))]
	private Task NGGKHIIAEAH(CancellationToken GLMIEEKKGFN, CancellationToken BGIJODFFGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3869360", Offset = "0x3867F60", VA = "0x183869360")]
	[AsyncStateMachine(typeof(HEOELJPFAIO<, >.IGMPAJAOKEK))]
	private Task GEFJPEALEAG(CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3869460", Offset = "0x3868060", VA = "0x183869460")]
	private TimeSpan GHJJGKKILEF()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3868ED0", Offset = "0x3867AD0", VA = "0x183868ED0")]
	private Task<List<TResult>> CCCEJKFEPEP(IReadOnlyList<TRequest> JPLEDHHFGDA, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3869710", Offset = "0x3868310", VA = "0x183869710")]
	private float PDKMKNNPBMA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3868FE0", Offset = "0x3867BE0", VA = "0x183868FE0")]
	private void CIEEMLGPHDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PEKFKJOPLHB<TItemId, TResult> : HLJOMAFDFHA<LNBNGGHDGFG<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> PDKPKMJAABC(Dictionary<TItemId, int> JPLEDHHFGDA, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LDAJJFKNAJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LDAJJFKNAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3BFFD00", Offset = "0x3BFE900", VA = "0x183BFFD00")]
		internal TResult EAPGFPDDJOG(LNBNGGHDGFG<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DGOLJBHCOHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<LNBNGGHDGFG<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public PEKFKJOPLHB<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private LDAJJFKNAJA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x504CBF0", Offset = "0x504B7F0", VA = "0x18504CBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x504D940", Offset = "0x504C540", VA = "0x18504D940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly PDKPKMJAABC FOLJOLICCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> BEKCNBGJCPO;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3E8DD30", Offset = "0x3E8C930", VA = "0x183E8DD30")]
	public PEKFKJOPLHB(PDKPKMJAABC FOLJOLICCFK, [Optional] IEqualityComparer<TItemId> BEKCNBGJCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x40FE790", Offset = "0x40FD390", VA = "0x1840FE790", Slot = "4")]
	[AsyncStateMachine(typeof(PEKFKJOPLHB<, >.DGOLJBHCOHL))]
	public Task<List<TResult>> CLEBFINJEJA(IReadOnlyList<LNBNGGHDGFG<TItemId>> JPLEDHHFGDA, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MMBPHHEGJKD<TRequest, TResult> : HLJOMAFDFHA<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> FOKNCMGLOAH(IEnumerable<TRequest> ILNBNOOMFJE, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class JABHGNMBKNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public JABHGNMBKNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x37367C0", Offset = "0x37353C0", VA = "0x1837367C0")]
		internal TResult EAPGFPDDJOG(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct AFKBOEMMJEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<TRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public MMBPHHEGJKD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private JABHGNMBKNP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x37C86C0", Offset = "0x37C72C0", VA = "0x1837C86C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x37C94F0", Offset = "0x37C80F0", VA = "0x1837C94F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FOKNCMGLOAH FOLJOLICCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> BEKCNBGJCPO;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3E8DD30", Offset = "0x3E8C930", VA = "0x183E8DD30")]
	public MMBPHHEGJKD(FOKNCMGLOAH FOLJOLICCFK, [Optional] IEqualityComparer<TRequest> BEKCNBGJCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3E8DBE0", Offset = "0x3E8C7E0", VA = "0x183E8DBE0", Slot = "4")]
	[AsyncStateMachine(typeof(MMBPHHEGJKD<, >.AFKBOEMMJEJ))]
	public Task<List<TResult>> CLEBFINJEJA(IReadOnlyList<TRequest> JPLEDHHFGDA, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HLJOMAFDFHA<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> CLEBFINJEJA(IReadOnlyList<TRequest> JPLEDHHFGDA, CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NLMPHDHENMN<TItemId, TResult> : HLJOMAFDFHA<HCABGFKHJNA<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task FCMDKANOKCP(IReadOnlyDictionary<TItemId, HCABGFKHJNA<TItemId>.FOPPPLJNPKN> JPLEDHHFGDA, CancellationToken EJGJLLMBDIN);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct DDHKELMKFCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NLMPHDHENMN<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<HCABGFKHJNA<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x503D540", Offset = "0x503C140", VA = "0x18503D540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x503DA70", Offset = "0x503C670", VA = "0x18503DA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly FCMDKANOKCP EFDDCEFACFO;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public NLMPHDHENMN(FCMDKANOKCP EFDDCEFACFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3F36820", Offset = "0x3F35420", VA = "0x183F36820", Slot = "4")]
	[AsyncStateMachine(typeof(NLMPHDHENMN<, >.DDHKELMKFCC))]
	public Task<List<object>> CLEBFINJEJA(IReadOnlyList<HCABGFKHJNA<TItemId>> JPLEDHHFGDA, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3F36960", Offset = "0x3F35560", VA = "0x183F36960")]
	private IReadOnlyDictionary<TItemId, HCABGFKHJNA<TItemId>.FOPPPLJNPKN> DHIHKNFLMGK(IReadOnlyList<HCABGFKHJNA<TItemId>> PBMFIMJCECA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BLHPJFBDFII<TItemId, TResult> : HLJOMAFDFHA<LNBNGGHDGFG<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> PENIIEGLLAF(Dictionary<TItemId, int> JPLEDHHFGDA, CancellationToken EJGJLLMBDIN);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct LNIPHKAAGCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<LNBNGGHDGFG<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public BLHPJFBDFII<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D0E0", Offset = "0x3C3BCE0", VA = "0x183C3D0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3C3E9C0", Offset = "0x3C3D5C0", VA = "0x183C3E9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly PENIIEGLLAF AENPGCOGFPO;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public BLHPJFBDFII(PENIIEGLLAF FOLJOLICCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x47F0F30", Offset = "0x47EFB30", VA = "0x1847F0F30", Slot = "4")]
	[AsyncStateMachine(typeof(BLHPJFBDFII<, >.LNIPHKAAGCJ))]
	public Task<List<TResult>> CLEBFINJEJA(IReadOnlyList<LNBNGGHDGFG<TItemId>> JPLEDHHFGDA, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DGPEOOIMEMK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, IOCOBFNPIHJ> HENPDIPOHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> HNLHEAMHPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> LHJGMLJFBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> BFONAADBFHB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, IOCOBFNPIHJ> EHKJNDLCOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> FLEGNEHOJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int AEGDOKILOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x961750", Offset = "0x960350", VA = "0x180961750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x961700", Offset = "0x960300", VA = "0x180961700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x504DCD0", Offset = "0x504C8D0", VA = "0x18504DCD0")]
	public DGPEOOIMEMK(Func<IEnumerable<T>> LHJGMLJFBLP, Func<T, string> BFONAADBFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x504D9E0", Offset = "0x504C5E0", VA = "0x18504D9E0")]
	public void BBEBOIIGBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x504DC60", Offset = "0x504C860", VA = "0x18504DC60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MJPOAIHJELK<TItemId, TResult> : HEOELJPFAIO<LNBNGGHDGFG<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3346980", Offset = "0x3345580", VA = "0x183346980")]
	public MJPOAIHJELK(HLJOMAFDFHA<LNBNGGHDGFG<TItemId>, TResult> HGLHGFIFHGN, TimeSpan KMOACJPOBPP, [Optional] LFEGMOABMDL DNILIKBCNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3E53E30", Offset = "0x3E52A30", VA = "0x183E53E30")]
	public Task<TResult> PLCNFHBCIFK(TItemId CGGNJKGENIH, int AIMJKOABHLL, [Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LNBNGGHDGFG<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId KHEBGCBAMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int OIBMAEHGOOI;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3C36660", Offset = "0x3C35260", VA = "0x183C36660")]
	public LNBNGGHDGFG(TItemId JICKLLKLEAD, int AIMJKOABHLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NAGBFNFOGNG<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid FCHEOIGLPCN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> LHLBDHDKNNP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OMEMMPNMNNL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface MBEPBCJPNCC
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int CLCMOEAEDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool AOJIAOJJIDP<TParam>(TParam BLKAHBIJBJO);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool EHLAKIEPDNF(Exception PKPFNALFKGI);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool JPAMAIAMIBH();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class HGMDMGIPBPH<TResult> : MBEPBCJPNCC, NAGBFNFOGNG<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> BCAKEJEFJBJ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid FCHEOIGLPCN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x84DD40", Offset = "0x84C940", VA = "0x18084DD40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int CLCMOEAEDAB
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x961750", Offset = "0x960350", VA = "0x180961750", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> LHLBDHDKNNP
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x386AA70", Offset = "0x3869670", VA = "0x18386AA70", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x386AAB0", Offset = "0x38696B0", VA = "0x18386AAB0")]
		public HGMDMGIPBPH(int FKKGFHMEIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x25A1B70", Offset = "0x25A0770", VA = "0x1825A1B70", Slot = "5")]
		public bool AOJIAOJJIDP<TParam>(TParam BLKAHBIJBJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x386A9F0", Offset = "0x38695F0", VA = "0x18386A9F0", Slot = "6")]
		public bool EHLAKIEPDNF(Exception PKPFNALFKGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x386AA30", Offset = "0x3869630", VA = "0x18386AA30", Slot = "7")]
		public bool JPAMAIAMIBH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string BEAPKNBBKIG = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, MBEPBCJPNCC> IBDLBGJBJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly PAEFHCOOMHL BHMIGMAGCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool DLDFGLDJCGM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x66ED080", Offset = "0x66EBC80", VA = "0x1866ED080")]
	public OMEMMPNMNNL([Optional] PAEFHCOOMHL BHMIGMAGCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x66EC960", Offset = "0x66EB560", VA = "0x1866EC960", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2942EC0", Offset = "0x2941AC0", VA = "0x182942EC0")]
	public NAGBFNFOGNG<TResult> PCKOABLFMKL<TResult>(int OCADANCGACD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2942B90", Offset = "0x2941790", VA = "0x182942B90")]
	public bool KOKAADHIBBP<TResult>(Guid BJNGDHCNCJP, TResult MGHLKGJFBCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x66ECA70", Offset = "0x66EB670", VA = "0x1866ECA70")]
	private void FCJEFFCLOPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x66EC960", Offset = "0x66EB560", VA = "0x1866EC960")]
	private void FBMMEDCNJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x66ECD90", Offset = "0x66EB990", VA = "0x1866ECD90")]
	private void LGALEEINJOB(int FKKGFHMEIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x66ECB90", Offset = "0x66EB790", VA = "0x1866ECB90")]
	private void HGBBLOFGKFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum NBGNGMECNIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HCABGFKHJNA<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class FOPPPLJNPKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int MOELLOHIKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int PHEFJOFIAJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int ENLPHFLJAHJ;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public FOPPPLJNPKN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId KHEBGCBAMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int OIBMAEHGOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NBGNGMECNIJ ADHAOAIPBGD;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xEFBA90", Offset = "0xEFA690", VA = "0x180EFBA90")]
	public HCABGFKHJNA(TItemId JICKLLKLEAD, int AIMJKOABHLL, NBGNGMECNIJ KNENCIBJOEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KMKHDCFBFLI<TItemId, TResult> : HEOELJPFAIO<HCABGFKHJNA<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3346980", Offset = "0x3345580", VA = "0x183346980")]
	public KMKHDCFBFLI(HLJOMAFDFHA<HCABGFKHJNA<TItemId>, TResult> HGLHGFIFHGN, TimeSpan KMOACJPOBPP, [Optional] LFEGMOABMDL DNILIKBCNIB)
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

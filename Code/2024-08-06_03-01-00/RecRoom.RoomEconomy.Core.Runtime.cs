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
public interface NHNPIBCIBBI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MPNHHALBOCM(int NEGEGFFEGPA, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MPNHHALBOCM(TimeSpan ADLIOKOKEHO, CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LEFINDCIHGM : NHNPIBCIBBI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x700DB10", Offset = "0x700C110", VA = "0x18700DB10")]
	[CCEDJDOPMOE(GIKFHLNFMKF.Root, CFIDNIINJOK.GameOnly)]
	private static void IPDGANODBNB(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	[Preserve]
	public LEFINDCIHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x700DC60", Offset = "0x700C260", VA = "0x18700DC60", Slot = "4")]
	public Task MPNHHALBOCM(int NEGEGFFEGPA, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x700DC00", Offset = "0x700C200", VA = "0x18700DC00", Slot = "5")]
	public Task MPNHHALBOCM(TimeSpan ADLIOKOKEHO, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IMNHAAOJLLB<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct ACCIMIJILGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest JILAGKIBNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> HGKOAKLCDDP;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB912D0", Offset = "0xB8F8D0", VA = "0x180B912D0")]
		public ACCIMIJILGO(TRequest FALAJMPCHDK, TaskCompletionSource<TResult> LPLEFMNFOII)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct LMIAADJMKPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public IMNHAAOJLLB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x42E2830", Offset = "0x42E0E30", VA = "0x1842E2830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C360", Offset = "0x3C6A960", VA = "0x183C6C360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct KEKECJKILMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public IMNHAAOJLLB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x41D3850", Offset = "0x41D1E50", VA = "0x1841D3850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x41D3C40", Offset = "0x41D2240", VA = "0x1841D3C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct AGDPEDFKAPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public IMNHAAOJLLB<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3C85890", Offset = "0x3C83E90", VA = "0x183C85890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3C85D50", Offset = "0x3C84350", VA = "0x183C85D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct IOEGAMDLIDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public IMNHAAOJLLB<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3E6ED60", Offset = "0x3E6D360", VA = "0x183E6ED60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3E6FF80", Offset = "0x3E6E580", VA = "0x183E6FF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly PMIBDPOEFBB<TRequest, TResult> HFNLGPIPOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float LFNKEKNMMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NHNPIBCIBBI PPINOJAKDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool LOCGBIPABAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<ACCIMIJILGO> MJAMOFFDPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<ACCIMIJILGO> FENGABDHLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool OBCBKADEOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource NBMCJLJLMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource ALJLHINLDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task DOAJPOIJKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float AFEOIJGNBJK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JEDAHGMJAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8654E0", Offset = "0x863AE0", VA = "0x1808654E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8654D0", Offset = "0x863AD0", VA = "0x1808654D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3E50030", Offset = "0x3E4E630", VA = "0x183E50030")]
	public IMNHAAOJLLB(PMIBDPOEFBB<TRequest, TResult> HFNLGPIPOON, TimeSpan LFNKEKNMMME, bool LOCGBIPABAA, [Optional] NHNPIBCIBBI PPINOJAKDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3E4F5F0", Offset = "0x3E4DBF0", VA = "0x183E4F5F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FB00", Offset = "0x3E4E100", VA = "0x183E4FB00")]
	[AsyncStateMachine(typeof(IMNHAAOJLLB<, >.LMIAADJMKPL))]
	public Task<TResult> IJBPHMGFGIH(TRequest FALAJMPCHDK, [Optional] CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FC30", Offset = "0x3E4E230", VA = "0x183E4FC30")]
	private void IJBPHMGFGIH(TRequest FALAJMPCHDK, TaskCompletionSource<TResult> LPLEFMNFOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FF70", Offset = "0x3E4E570", VA = "0x183E4FF70")]
	public Task OFIKFGDLBPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3E4F510", Offset = "0x3E4DB10", VA = "0x183E4F510")]
	[AsyncStateMachine(typeof(IMNHAAOJLLB<, >.KEKECJKILMI))]
	private Task CGMHHKIFGMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3E4F8E0", Offset = "0x3E4DEE0", VA = "0x183E4F8E0")]
	[AsyncStateMachine(typeof(IMNHAAOJLLB<, >.AGDPEDFKAPM))]
	private Task GOALHCDPIDL(CancellationToken FNCIMOOLDPM, CancellationToken GMJCACJEOPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FA00", Offset = "0x3E4E000", VA = "0x183E4FA00")]
	[AsyncStateMachine(typeof(IMNHAAOJLLB<, >.IOEGAMDLIDK))]
	private Task IHBADBAFPAF(CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FD70", Offset = "0x3E4E370", VA = "0x183E4FD70")]
	private TimeSpan MCHPJEHEMFA()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FE50", Offset = "0x3E4E450", VA = "0x183E4FE50")]
	private Task<List<TResult>> NGPBJNPJMHG(IReadOnlyList<TRequest> IOLDDJGJHME, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FCD0", Offset = "0x3E4E2D0", VA = "0x183E4FCD0")]
	private float KFACJADBAHJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3E4F830", Offset = "0x3E4DE30", VA = "0x183E4F830")]
	private void GJMIMCPBJBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DJHPBFHLMJM<TItemId, TResult> : PMIBDPOEFBB<EHABIGDGDBI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> AMJHAEDLBBK(Dictionary<TItemId, int> IOLDDJGJHME, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class IFAMFNLGJNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public IFAMFNLGJNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3E10D60", Offset = "0x3E0F360", VA = "0x183E10D60")]
		internal TResult IJPEIDABPJD(EHABIGDGDBI<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MIOBMEJIEDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<EHABIGDGDBI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public DJHPBFHLMJM<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private IFAMFNLGJNL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4500E80", Offset = "0x44FF480", VA = "0x184500E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4501C70", Offset = "0x4500270", VA = "0x184501C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly AMJHAEDLBBK JAMBMGANELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> JNJFJFBCDJD;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x450B810", Offset = "0x4509E10", VA = "0x18450B810")]
	public DJHPBFHLMJM(AMJHAEDLBBK JAMBMGANELM, [Optional] IEqualityComparer<TItemId> JNJFJFBCDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x586EC90", Offset = "0x586D290", VA = "0x18586EC90", Slot = "4")]
	[AsyncStateMachine(typeof(DJHPBFHLMJM<, >.MIOBMEJIEDH))]
	public Task<List<TResult>> IPANDGKOJNE(IReadOnlyList<EHABIGDGDBI<TItemId>> IOLDDJGJHME, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MLPGHHFKGCP<TRequest, TResult> : PMIBDPOEFBB<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> IFGDPCFLJJF(IEnumerable<TRequest> CPNPMMMEGGG, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class BCEBDGHNIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public BCEBDGHNIEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3B8BBE0", Offset = "0x3B8A1E0", VA = "0x183B8BBE0")]
		internal TResult IJPEIDABPJD(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct FDLKGNKLFBB : IAsyncStateMachine
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
		public MLPGHHFKGCP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private BCEBDGHNIEO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3B86E70", Offset = "0x3B85470", VA = "0x183B86E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3B87D70", Offset = "0x3B86370", VA = "0x183B87D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IFGDPCFLJJF JAMBMGANELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> JNJFJFBCDJD;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x450B810", Offset = "0x4509E10", VA = "0x18450B810")]
	public MLPGHHFKGCP(IFGDPCFLJJF JAMBMGANELM, [Optional] IEqualityComparer<TRequest> JNJFJFBCDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x450B6C0", Offset = "0x4509CC0", VA = "0x18450B6C0", Slot = "4")]
	[AsyncStateMachine(typeof(MLPGHHFKGCP<, >.FDLKGNKLFBB))]
	public Task<List<TResult>> IPANDGKOJNE(IReadOnlyList<TRequest> IOLDDJGJHME, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PMIBDPOEFBB<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> IPANDGKOJNE(IReadOnlyList<TRequest> IOLDDJGJHME, CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JLBJKAADDMC<TItemId, TResult> : PMIBDPOEFBB<PCMGPNFKIAB<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task GCGAHGIGEKA(IReadOnlyDictionary<TItemId, PCMGPNFKIAB<TItemId>.POKNNDEIPDL> IOLDDJGJHME, CancellationToken NNGMAHIDECE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct OGHPHENCKHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public JLBJKAADDMC<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<PCMGPNFKIAB<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x46D8EF0", Offset = "0x46D74F0", VA = "0x1846D8EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x46D9470", Offset = "0x46D7A70", VA = "0x1846D9470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly GCGAHGIGEKA CFCHNCJADPC;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	public JLBJKAADDMC(GCGAHGIGEKA CFCHNCJADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x406CFD0", Offset = "0x406B5D0", VA = "0x18406CFD0", Slot = "4")]
	[AsyncStateMachine(typeof(JLBJKAADDMC<, >.OGHPHENCKHK))]
	public Task<List<object>> IPANDGKOJNE(IReadOnlyList<PCMGPNFKIAB<TItemId>> IOLDDJGJHME, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x406D110", Offset = "0x406B710", VA = "0x18406D110")]
	private IReadOnlyDictionary<TItemId, PCMGPNFKIAB<TItemId>.POKNNDEIPDL> PBIMFIFBFBB(IReadOnlyList<PCMGPNFKIAB<TItemId>> CBIGNHGEGAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AHBLLJHBPBA<TItemId, TResult> : PMIBDPOEFBB<EHABIGDGDBI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> GEJMDBKBOHM(Dictionary<TItemId, int> IOLDDJGJHME, CancellationToken NNGMAHIDECE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct LNNENBPHMDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<EHABIGDGDBI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AHBLLJHBPBA<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x42EBE60", Offset = "0x42EA460", VA = "0x1842EBE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x42ECB70", Offset = "0x42EB170", VA = "0x1842ECB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly GEJMDBKBOHM ODNMBOILFHH;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	public AHBLLJHBPBA(GEJMDBKBOHM JAMBMGANELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3C873E0", Offset = "0x3C859E0", VA = "0x183C873E0", Slot = "4")]
	[AsyncStateMachine(typeof(AHBLLJHBPBA<, >.LNNENBPHMDH))]
	public Task<List<TResult>> IPANDGKOJNE(IReadOnlyList<EHABIGDGDBI<TItemId>> IOLDDJGJHME, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MDDEJIKLACF<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, ODEJHONECGK> DDNCENGHBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> OLKJILPBIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> OOHDNMDJEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> DKGPDMJDOJH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, ODEJHONECGK> EGJHJMAPBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> FNPAOLEKGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IGCFAACLFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x998B00", Offset = "0x997100", VA = "0x180998B00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x998B10", Offset = "0x997110", VA = "0x180998B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x44E40B0", Offset = "0x44E26B0", VA = "0x1844E40B0")]
	public MDDEJIKLACF(Func<IEnumerable<T>> OOHDNMDJEAI, Func<T, string> DKGPDMJDOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x44E3D50", Offset = "0x44E2350", VA = "0x1844E3D50")]
	public void CCBJGFJMACJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x44E4020", Offset = "0x44E2620", VA = "0x1844E4020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OEAOHDOHOIH<TItemId, TResult> : IMNHAAOJLLB<EHABIGDGDBI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3D575B0", Offset = "0x3D55BB0", VA = "0x183D575B0")]
	public OEAOHDOHOIH(PMIBDPOEFBB<EHABIGDGDBI<TItemId>, TResult> HFNLGPIPOON, TimeSpan LFNKEKNMMME, bool LOCGBIPABAA, [Optional] NHNPIBCIBBI PPINOJAKDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x46D6B30", Offset = "0x46D5130", VA = "0x1846D6B30")]
	public Task<TResult> IJBPHMGFGIH(TItemId MNBFPOFIDHA, int JELOEPGHNLC, [Optional] CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EHABIGDGDBI<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId BICLEGPLKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int FEMACHEPKIG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x37EC420", Offset = "0x37EAA20", VA = "0x1837EC420")]
	public EHABIGDGDBI(TItemId JCBMLHHDHKN, int JELOEPGHNLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LIJGEACOIEF<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid CBKPAFEEJIO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> CBEIOJIJJMC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class ABAFHFAEDPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface KBPKKHIIPCM
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int JHDNDCBDNJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OPDGLCJBCBA<TParam>(TParam FEBGGALLBNN);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool DAPPANEPFPL(Exception OOIEOIIANBN);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool NNPJADAHEDA();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class ACHEBNPKHFI<TResult> : KBPKKHIIPCM, LIJGEACOIEF<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> AGJALLMMGDC;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid CBKPAFEEJIO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9B1620", Offset = "0x9AFC20", VA = "0x1809B1620", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int JHDNDCBDNJH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x998B00", Offset = "0x997100", VA = "0x180998B00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> CBEIOJIJJMC
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3C6D2F0", Offset = "0x3C6B8F0", VA = "0x183C6D2F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D410", Offset = "0x3C6BA10", VA = "0x183C6D410")]
		public ACHEBNPKHFI(int EIJAENLBCMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x25C0920", Offset = "0x25BEF20", VA = "0x1825C0920", Slot = "5")]
		public bool OPDGLCJBCBA<TParam>(TParam FEBGGALLBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D350", Offset = "0x3C6B950", VA = "0x183C6D350", Slot = "6")]
		public bool DAPPANEPFPL(Exception OOIEOIIANBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D3B0", Offset = "0x3C6B9B0", VA = "0x183C6D3B0", Slot = "7")]
		public bool NNPJADAHEDA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string LEFAJKIJGJM = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, KBPKKHIIPCM> KNMALPPKOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly FJDDAHIAAOC KFDIJNOEKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool ECIDDJAFELC;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x700DA40", Offset = "0x700C040", VA = "0x18700DA40")]
	public ABAFHFAEDPC([Optional] FJDDAHIAAOC KFDIJNOEKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x700D320", Offset = "0x700B920", VA = "0x18700D320", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x31FA0B0", Offset = "0x31F86B0", VA = "0x1831FA0B0")]
	public LIJGEACOIEF<TResult> KKFJGBJJKLE<TResult>(int HKPBLPNJAHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x31FA3D0", Offset = "0x31F89D0", VA = "0x1831FA3D0")]
	public bool NKNIMMLKGGE<TResult>(Guid MKCPOIIDFLO, TResult JKLHKLABFHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x700D720", Offset = "0x700BD20", VA = "0x18700D720")]
	private void IILFDEOEAFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x700D320", Offset = "0x700B920", VA = "0x18700D320")]
	private void POBDPLNEPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x700D430", Offset = "0x700BA30", VA = "0x18700D430")]
	private void GKFCABPJHJA(int EIJAENLBCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x700D840", Offset = "0x700BE40", VA = "0x18700D840")]
	private void LFGPOLCMJAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum KDBFODKJJCD
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PCMGPNFKIAB<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class POKNNDEIPDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int PDIDFEGFGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int GIBIONKCLOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int GMCCIIGPNIA;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public POKNNDEIPDL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId BICLEGPLKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int FEMACHEPKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public KDBFODKJJCD OFDAICEIOEI;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1290500", Offset = "0x128EB00", VA = "0x181290500")]
	public PCMGPNFKIAB(TItemId JCBMLHHDHKN, int JELOEPGHNLC, KDBFODKJJCD JOCJMGGBHIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class JNFNAODDCEP<TItemId, TResult> : IMNHAAOJLLB<PCMGPNFKIAB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x40F8190", Offset = "0x40F6790", VA = "0x1840F8190")]
	public JNFNAODDCEP(PMIBDPOEFBB<PCMGPNFKIAB<TItemId>, TResult> HFNLGPIPOON, TimeSpan LFNKEKNMMME, [Optional] NHNPIBCIBBI PPINOJAKDIH)
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

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
public interface FDCAAAGFEBI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BHBPHHEHEFF(int NDACBFDKEPP, CancellationToken IOOGCHJMBIE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BHBPHHEHEFF(TimeSpan PJHHGCEMKNG, CancellationToken IOOGCHJMBIE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class OEHBAMPMJJE : FDCAAAGFEBI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6714960", Offset = "0x6713B60", VA = "0x186714960")]
	[BDCLMMIIFOD(AILNDCKFLHJ.Root, CIJFMPALMOO.GameOnly)]
	private static void MAIBGIMLEBL(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	[Preserve]
	public OEHBAMPMJJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6714900", Offset = "0x6713B00", VA = "0x186714900", Slot = "4")]
	public Task BHBPHHEHEFF(int NDACBFDKEPP, CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67148A0", Offset = "0x6713AA0", VA = "0x1867148A0", Slot = "5")]
	public Task BHBPHHEHEFF(TimeSpan PJHHGCEMKNG, CancellationToken IOOGCHJMBIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GMLPIAOBFNC<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct MCGIABJGHGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest COGGDLOLIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> JAHHHCDICBB;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x90BB40", Offset = "0x90AD40", VA = "0x18090BB40")]
		public MCGIABJGHGA(TRequest NOGNLJBIFAF, TaskCompletionSource<TResult> JLBCNFNJHEH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct CFGHHHCMBHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public GMLPIAOBFNC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4A14570", Offset = "0x4A13770", VA = "0x184A14570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4A14A70", Offset = "0x4A13C70", VA = "0x184A14A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GBPOOEGHDNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public GMLPIAOBFNC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3858390", Offset = "0x3857590", VA = "0x183858390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3858750", Offset = "0x3857950", VA = "0x183858750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LLBEMKMEBHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public GMLPIAOBFNC<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3D62EA0", Offset = "0x3D620A0", VA = "0x183D62EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D63330", Offset = "0x3D62530", VA = "0x183D63330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct AAJEOLCPEBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public GMLPIAOBFNC<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x382AFC0", Offset = "0x382A1C0", VA = "0x18382AFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x382BE40", Offset = "0x382B040", VA = "0x18382BE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JJINADBCIIH<TRequest, TResult> CKPCNDAFOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float CIAPHPKOOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FDCAAAGFEBI DLCDPMAHEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<MCGIABJGHGA> HNBJKABKGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource JKMCHAGKNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource MKIIMECMEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task LMPPDFHGJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float KPAEDDEALMB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OIOOJDHLJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAF6D80", Offset = "0xAF5F80", VA = "0x180AF6D80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAF6D70", Offset = "0xAF5F70", VA = "0x180AF6D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3890230", Offset = "0x388F430", VA = "0x183890230")]
	public GMLPIAOBFNC(JJINADBCIIH<TRequest, TResult> CKPCNDAFOBO, TimeSpan CIAPHPKOOKA, [Optional] FDCAAAGFEBI DLCDPMAHEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x388FD40", Offset = "0x388EF40", VA = "0x18388FD40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x388F970", Offset = "0x388EB70", VA = "0x18388F970")]
	[AsyncStateMachine(typeof(GMLPIAOBFNC<, >.CFGHHHCMBHN))]
	public Task<TResult> AKGABKHHFNG(TRequest NOGNLJBIFAF, [Optional] CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3890170", Offset = "0x388F370", VA = "0x183890170")]
	public Task OGEPPKEHJFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x38900A0", Offset = "0x388F2A0", VA = "0x1838900A0")]
	[AsyncStateMachine(typeof(GMLPIAOBFNC<, >.GBPOOEGHDNP))]
	private Task MPFIGMMKGCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x388FC20", Offset = "0x388EE20", VA = "0x18388FC20")]
	[AsyncStateMachine(typeof(GMLPIAOBFNC<, >.LLBEMKMEBHO))]
	private Task DGPBHAFKAJC(CancellationToken GALDHBICBIM, CancellationToken FAJOCCEOPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x388F870", Offset = "0x388EA70", VA = "0x18388F870")]
	[AsyncStateMachine(typeof(GMLPIAOBFNC<, >.AAJEOLCPEBF))]
	private Task AJMAPDINEAO(CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x388FF30", Offset = "0x388F130", VA = "0x18388FF30")]
	private TimeSpan GKODMIFDFEL()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x388FA90", Offset = "0x388EC90", VA = "0x18388FA90")]
	private Task<List<TResult>> BEECANKFODL(IReadOnlyList<TRequest> EGLPPHANCHG, CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3890000", Offset = "0x388F200", VA = "0x183890000")]
	private float IPPDGOAIFKF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x388FB90", Offset = "0x388ED90", VA = "0x18388FB90")]
	private void COOHKNNLLLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class EHHIDFNIADI<TItemId, TResult> : JJINADBCIIH<MGJLMEHAOAD<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> FIGFGGCFNMF(Dictionary<TItemId, int> EGLPPHANCHG, CancellationToken IOOGCHJMBIE);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KLMJCBKOKGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public KLMJCBKOKGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0BC0", Offset = "0x3CBFDC0", VA = "0x183CC0BC0")]
		internal TResult DEIJPOFMDLB(MGJLMEHAOAD<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct IHGIJEAMKHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<MGJLMEHAOAD<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public EHHIDFNIADI<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private KLMJCBKOKGP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3A43E80", Offset = "0x3A43080", VA = "0x183A43E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3A44B00", Offset = "0x3A43D00", VA = "0x183A44B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly FIGFGGCFNMF NLOCPNENLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> CFNACOMKDNJ;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x341F420", Offset = "0x341E620", VA = "0x18341F420")]
	public EHHIDFNIADI(FIGFGGCFNMF NLOCPNENLIG, [Optional] IEqualityComparer<TItemId> CFNACOMKDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x341F1A0", Offset = "0x341E3A0", VA = "0x18341F1A0", Slot = "4")]
	[AsyncStateMachine(typeof(EHHIDFNIADI<, >.IHGIJEAMKHD))]
	public Task<List<TResult>> ALDDBFAGJAC(IReadOnlyList<MGJLMEHAOAD<TItemId>> EGLPPHANCHG, CancellationToken IOOGCHJMBIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DFGKLJKCNJE<TRequest, TResult> : JJINADBCIIH<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> OJDHBBOIHOL(IEnumerable<TRequest> CNAHEPIILLF, CancellationToken IOOGCHJMBIE);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class PLGJPMOBDLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public PLGJPMOBDLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x38BF420", Offset = "0x38BE620", VA = "0x1838BF420")]
		internal TResult DEIJPOFMDLB(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct OFCHFPFNOMM : IAsyncStateMachine
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
		public DFGKLJKCNJE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private PLGJPMOBDLI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x40F3040", Offset = "0x40F2240", VA = "0x1840F3040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x40F3D90", Offset = "0x40F2F90", VA = "0x1840F3D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly OJDHBBOIHOL NLOCPNENLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> CFNACOMKDNJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x341F420", Offset = "0x341E620", VA = "0x18341F420")]
	public DFGKLJKCNJE(OJDHBBOIHOL NLOCPNENLIG, [Optional] IEqualityComparer<TRequest> CFNACOMKDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x508EB60", Offset = "0x508DD60", VA = "0x18508EB60", Slot = "4")]
	[AsyncStateMachine(typeof(DFGKLJKCNJE<, >.OFCHFPFNOMM))]
	public Task<List<TResult>> ALDDBFAGJAC(IReadOnlyList<TRequest> EGLPPHANCHG, CancellationToken IOOGCHJMBIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JJINADBCIIH<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> ALDDBFAGJAC(IReadOnlyList<TRequest> EGLPPHANCHG, CancellationToken IOOGCHJMBIE);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GBCNCCGJELE<TItemId, TResult> : JJINADBCIIH<NDDIHANCNCJ<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task GDLNDLDHIGH(IReadOnlyDictionary<TItemId, NDDIHANCNCJ<TItemId>.OPFADPHOBDI> EGLPPHANCHG, CancellationToken IOOGCHJMBIE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct FHKBFPJBALP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public GBCNCCGJELE<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<NDDIHANCNCJ<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x37807E0", Offset = "0x377F9E0", VA = "0x1837807E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3780CD0", Offset = "0x377FED0", VA = "0x183780CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly GDLNDLDHIGH ODCBKCPNPOF;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	public GBCNCCGJELE(GDLNDLDHIGH ODCBKCPNPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x38525C0", Offset = "0x38517C0", VA = "0x1838525C0", Slot = "4")]
	[AsyncStateMachine(typeof(GBCNCCGJELE<, >.FHKBFPJBALP))]
	public Task<List<object>> ALDDBFAGJAC(IReadOnlyList<NDDIHANCNCJ<TItemId>> EGLPPHANCHG, CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3852700", Offset = "0x3851900", VA = "0x183852700")]
	private IReadOnlyDictionary<TItemId, NDDIHANCNCJ<TItemId>.OPFADPHOBDI> IBKAONEEMMA(IReadOnlyList<NDDIHANCNCJ<TItemId>> OAOFIDJEFHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HAONMEBOOOP<TItemId, TResult> : JJINADBCIIH<MGJLMEHAOAD<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> MJOLIFDFCBL(Dictionary<TItemId, int> EGLPPHANCHG, CancellationToken IOOGCHJMBIE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct BCEPGAHCEKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<MGJLMEHAOAD<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public HAONMEBOOOP<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x47AE420", Offset = "0x47AD620", VA = "0x1847AE420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x47AF030", Offset = "0x47AE230", VA = "0x1847AF030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly MJOLIFDFCBL GBPNMOADPDM;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	public HAONMEBOOOP(MJOLIFDFCBL NLOCPNENLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x393EA60", Offset = "0x393DC60", VA = "0x18393EA60", Slot = "4")]
	[AsyncStateMachine(typeof(HAONMEBOOOP<, >.BCEPGAHCEKF))]
	public Task<List<TResult>> ALDDBFAGJAC(IReadOnlyList<MGJLMEHAOAD<TItemId>> EGLPPHANCHG, CancellationToken IOOGCHJMBIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AGOCCJNCJIO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, EIEGMJHHHDC> KFLPIPEGHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> HPBKGLHPLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> GGBOPOPGPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> NHCFNEHOHMJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, EIEGMJHHHDC> BNCGFKBFPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> FGCHDLKPPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GNPEKHPMEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x95D910", Offset = "0x95CB10", VA = "0x18095D910")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x95D920", Offset = "0x95CB20", VA = "0x18095D920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x38ACD50", Offset = "0x38ABF50", VA = "0x1838ACD50")]
	public AGOCCJNCJIO(Func<IEnumerable<T>> GGBOPOPGPGE, Func<T, string> NHCFNEHOHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x38ACB00", Offset = "0x38ABD00", VA = "0x1838ACB00")]
	public void MOLHGBBEJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x38ACA90", Offset = "0x38ABC90", VA = "0x1838ACA90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EJNLECIKAHL<TItemId, TResult> : GMLPIAOBFNC<MGJLMEHAOAD<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3429660", Offset = "0x3428860", VA = "0x183429660")]
	public EJNLECIKAHL(JJINADBCIIH<MGJLMEHAOAD<TItemId>, TResult> CKPCNDAFOBO, TimeSpan CIAPHPKOOKA, [Optional] FDCAAAGFEBI DLCDPMAHEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x34293D0", Offset = "0x34285D0", VA = "0x1834293D0")]
	public Task<TResult> AKGABKHHFNG(TItemId GHBNLDGJPCB, int PBDMEIFOAHD, [Optional] CancellationToken IOOGCHJMBIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MGJLMEHAOAD<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId FIPKIDEMBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int OAFGDHAEAKH;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3F15290", Offset = "0x3F14490", VA = "0x183F15290")]
	public MGJLMEHAOAD(TItemId DAEBMMJIMJG, int PBDMEIFOAHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DLPIAPCIILL<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid BECNMCBJOMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> BAPJPGKEDJL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class ALHJJAPEBOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface JDGBFEPEBKC
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int HOOBLGHDDAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool FIPMPALAMHI<TParam>(TParam EKDDCPALANJ);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool PBGDBILGABF(Exception OGMFBLJMCMJ);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool AFCOLANDGNI();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class GMHOPPKIFDP<TResult> : JDGBFEPEBKC, DLPIAPCIILL<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> IEGPAPMANBF;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid BECNMCBJOMP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x853EA0", Offset = "0x8530A0", VA = "0x180853EA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int HOOBLGHDDAM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x95D910", Offset = "0x95CB10", VA = "0x18095D910", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> BAPJPGKEDJL
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x388CD20", Offset = "0x388BF20", VA = "0x18388CD20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x388CDA0", Offset = "0x388BFA0", VA = "0x18388CDA0")]
		public GMHOPPKIFDP(int BOGHPNIAMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x278B770", Offset = "0x278A970", VA = "0x18278B770", Slot = "5")]
		public bool FIPMPALAMHI<TParam>(TParam EKDDCPALANJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x388CD60", Offset = "0x388BF60", VA = "0x18388CD60", Slot = "6")]
		public bool PBGDBILGABF(Exception OGMFBLJMCMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x388CCE0", Offset = "0x388BEE0", VA = "0x18388CCE0", Slot = "7")]
		public bool AFCOLANDGNI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string AHDJCMKFJNN = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, JDGBFEPEBKC> OFALEILOGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly KBJDNOCDKFA LPCKGOGJPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool IJKMILEOBCO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x67147D0", Offset = "0x67139D0", VA = "0x1867147D0")]
	public ALHJJAPEBOP([Optional] KBJDNOCDKFA LPCKGOGJPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x67143A0", Offset = "0x67135A0", VA = "0x1867143A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2EAD040", Offset = "0x2EAC240", VA = "0x182EAD040")]
	public DLPIAPCIILL<TResult> ABIFFJMPAJH<TResult>(int CAMEEIBEGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2EAD2E0", Offset = "0x2EAC4E0", VA = "0x182EAD2E0")]
	public bool BPKHIHCKNIB<TResult>(Guid KMMCIKAIDEM, TResult IFJGEIAONPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x67144B0", Offset = "0x67136B0", VA = "0x1867144B0")]
	private void GGHLKDCILIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x67143A0", Offset = "0x67135A0", VA = "0x1867143A0")]
	private void LEFODBNBNEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x67140B0", Offset = "0x67132B0", VA = "0x1867140B0")]
	private void BPNMFNNKDME(int BOGHPNIAMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x67145D0", Offset = "0x67137D0", VA = "0x1867145D0")]
	private void HLNDKKOCFKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum GNLDCOAKJOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NDDIHANCNCJ<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class OPFADPHOBDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int LNGFFALAJLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int NHGMJFFAPJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int FLLKCNHDIHK;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public OPFADPHOBDI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId FIPKIDEMBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int OAFGDHAEAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public GNLDCOAKJOJ BHDIICGNBOL;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xF08DF0", Offset = "0xF07FF0", VA = "0x180F08DF0")]
	public NDDIHANCNCJ(TItemId DAEBMMJIMJG, int PBDMEIFOAHD, GNLDCOAKJOJ HEEIDJMADFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LKBGLKPFKIA<TItemId, TResult> : GMLPIAOBFNC<NDDIHANCNCJ<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3429660", Offset = "0x3428860", VA = "0x183429660")]
	public LKBGLKPFKIA(JJINADBCIIH<NDDIHANCNCJ<TItemId>, TResult> CKPCNDAFOBO, TimeSpan CIAPHPKOOKA, [Optional] FDCAAAGFEBI DLCDPMAHEMK)
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

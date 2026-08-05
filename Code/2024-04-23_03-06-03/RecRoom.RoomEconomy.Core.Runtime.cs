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
public interface KICNHCOOJLN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BKLFAOEFILC(int BHLJJIFLPHN, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BKLFAOEFILC(TimeSpan LAMJHCPABEC, CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NNAHLEDCCKM : KICNHCOOJLN
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68A5100", Offset = "0x68A4100", VA = "0x1868A5100")]
	[ILJDPBHFAFI(ENLFMENACGP.Root, DIDBPCEENMM.GameOnly)]
	private static void CCNJMONBOPD(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	[Preserve]
	public NNAHLEDCCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x68A5040", Offset = "0x68A4040", VA = "0x1868A5040", Slot = "4")]
	public Task BKLFAOEFILC(int BHLJJIFLPHN, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x68A50A0", Offset = "0x68A40A0", VA = "0x1868A50A0", Slot = "5")]
	public Task BKLFAOEFILC(TimeSpan LAMJHCPABEC, CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JDOAEGCMNEJ<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct MBFIIHPGIOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest EIDJFOIGDIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> BLFGDNOGADC;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x948150", Offset = "0x947150", VA = "0x180948150")]
		public MBFIIHPGIOE(TRequest MJJCOLDOFAC, TaskCompletionSource<TResult> JJEONHGCOBI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct GDOMBKEBFFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public JDOAEGCMNEJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x399B140", Offset = "0x399A140", VA = "0x18399B140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x399B680", Offset = "0x399A680", VA = "0x18399B680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct KCGKPFLAPOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public JDOAEGCMNEJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D5BC40", Offset = "0x3D5AC40", VA = "0x183D5BC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D5C010", Offset = "0x3D5B010", VA = "0x183D5C010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct CPIPKHJKOMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JDOAEGCMNEJ<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5045660", Offset = "0x5044660", VA = "0x185045660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5045B00", Offset = "0x5044B00", VA = "0x185045B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct LCKHDMONAHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JDOAEGCMNEJ<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3E1C350", Offset = "0x3E1B350", VA = "0x183E1C350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D290", Offset = "0x3E1C290", VA = "0x183E1D290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly APPHLOLOBHJ<TRequest, TResult> JKJHKPDAGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float JOKOIGKGBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly KICNHCOOJLN EHPCFJFELCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<MBFIIHPGIOE> PNNDKKIMKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource KEFLPGKJDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource JNEEGMFDKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task KOBKNFGJIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float OFIGDJLOEFK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NPKMANILOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB055A0", Offset = "0xB045A0", VA = "0x180B055A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB058C0", Offset = "0xB048C0", VA = "0x180B058C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7D90", Offset = "0x3CC6D90", VA = "0x183CC7D90")]
	public JDOAEGCMNEJ(APPHLOLOBHJ<TRequest, TResult> JKJHKPDAGMN, TimeSpan JOKOIGKGBFF, [Optional] KICNHCOOJLN EHPCFJFELCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7590", Offset = "0x3CC6590", VA = "0x183CC7590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7390", Offset = "0x3CC6390", VA = "0x183CC7390")]
	[AsyncStateMachine(typeof(JDOAEGCMNEJ<, >.GDOMBKEBFFO))]
	public Task<TResult> CKDMKMANAAK(TRequest MJJCOLDOFAC, [Optional] CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3CC77A0", Offset = "0x3CC67A0", VA = "0x183CC77A0")]
	public Task GBNMDAPOICE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3CC74B0", Offset = "0x3CC64B0", VA = "0x183CC74B0")]
	[AsyncStateMachine(typeof(JDOAEGCMNEJ<, >.KCGKPFLAPOO))]
	private Task DBNGDKLIPEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7A40", Offset = "0x3CC6A40", VA = "0x183CC7A40")]
	[AsyncStateMachine(typeof(JDOAEGCMNEJ<, >.CPIPKHJKOMB))]
	private Task MBMPLPPFDBL(CancellationToken NAHEBHAICGD, CancellationToken FGKCGPCNPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7C90", Offset = "0x3CC6C90", VA = "0x183CC7C90")]
	[AsyncStateMachine(typeof(JDOAEGCMNEJ<, >.LCKHDMONAHL))]
	private Task OIMCLNFAECC(CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7970", Offset = "0x3CC6970", VA = "0x183CC7970")]
	private TimeSpan IBBEOFFFMOF()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7860", Offset = "0x3CC6860", VA = "0x183CC7860")]
	private Task<List<TResult>> HKOJLPILPME(IReadOnlyList<TRequest> HKKEJBKELFH, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7BF0", Offset = "0x3CC6BF0", VA = "0x183CC7BF0")]
	private float MNCOKNAKIDH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7B60", Offset = "0x3CC6B60", VA = "0x183CC7B60")]
	private void MDIKBEHFMEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BGAJMFLMMPH<TItemId, TResult> : APPHLOLOBHJ<ICEEELCAIJK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> BKAHLCDKIFA(Dictionary<TItemId, int> HKKEJBKELFH, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MBEACAPKNLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public MBEACAPKNLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4018470", Offset = "0x4017470", VA = "0x184018470")]
		internal TResult BJFEAOFKMCD(ICEEELCAIJK<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MJEPOKGEOOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<ICEEELCAIJK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public BGAJMFLMMPH<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private MBEACAPKNLG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4044810", Offset = "0x4043810", VA = "0x184044810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4045560", Offset = "0x4044560", VA = "0x184045560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly BKAHLCDKIFA KEKIOGNLIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> IGLIHABJIFK;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x48F5A90", Offset = "0x48F4A90", VA = "0x1848F5A90")]
	public BGAJMFLMMPH(BKAHLCDKIFA KEKIOGNLIDO, [Optional] IEqualityComparer<TItemId> IGLIHABJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x48F56A0", Offset = "0x48F46A0", VA = "0x1848F56A0", Slot = "4")]
	[AsyncStateMachine(typeof(BGAJMFLMMPH<, >.MJEPOKGEOOP))]
	public Task<List<TResult>> NIBLKDKOPOE(IReadOnlyList<ICEEELCAIJK<TItemId>> HKKEJBKELFH, CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DKNNKNOIKME<TRequest, TResult> : APPHLOLOBHJ<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> JIGFPNABCDG(IEnumerable<TRequest> EBEJAFBHBKE, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class FOEGDJJBNFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public FOEGDJJBNFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x350F540", Offset = "0x350E540", VA = "0x18350F540")]
		internal TResult BJFEAOFKMCD(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct LPGBCLGFMJP : IAsyncStateMachine
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
		public DKNNKNOIKME<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private FOEGDJJBNFH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3E5B560", Offset = "0x3E5A560", VA = "0x183E5B560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3E5C390", Offset = "0x3E5B390", VA = "0x183E5C390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly JIGFPNABCDG KEKIOGNLIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> IGLIHABJIFK;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x48F5A90", Offset = "0x48F4A90", VA = "0x1848F5A90")]
	public DKNNKNOIKME(JIGFPNABCDG KEKIOGNLIDO, [Optional] IEqualityComparer<TRequest> IGLIHABJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x520A9D0", Offset = "0x52099D0", VA = "0x18520A9D0", Slot = "4")]
	[AsyncStateMachine(typeof(DKNNKNOIKME<, >.LPGBCLGFMJP))]
	public Task<List<TResult>> NIBLKDKOPOE(IReadOnlyList<TRequest> HKKEJBKELFH, CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface APPHLOLOBHJ<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> NIBLKDKOPOE(IReadOnlyList<TRequest> HKKEJBKELFH, CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HLIOBHMIEEN<TItemId, TResult> : APPHLOLOBHJ<BNHJEHACEIL<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task PFIFJGDNPID(IReadOnlyDictionary<TItemId, BNHJEHACEIL<TItemId>.MCDIHNEAHDJ> HKKEJBKELFH, CancellationToken GHLJDIEPICD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct ADJCFOAFNFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public HLIOBHMIEEN<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<BNHJEHACEIL<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x394B2F0", Offset = "0x394A2F0", VA = "0x18394B2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x394B820", Offset = "0x394A820", VA = "0x18394B820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly PFIFJGDNPID CEFOCPMHJAP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	public HLIOBHMIEEN(PFIFJGDNPID CEFOCPMHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3A39C70", Offset = "0x3A38C70", VA = "0x183A39C70", Slot = "4")]
	[AsyncStateMachine(typeof(HLIOBHMIEEN<, >.ADJCFOAFNFA))]
	public Task<List<object>> NIBLKDKOPOE(IReadOnlyList<BNHJEHACEIL<TItemId>> HKKEJBKELFH, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3A39740", Offset = "0x3A38740", VA = "0x183A39740")]
	private IReadOnlyDictionary<TItemId, BNHJEHACEIL<TItemId>.MCDIHNEAHDJ> NIBKHHLHFEB(IReadOnlyList<BNHJEHACEIL<TItemId>> NJDGNMCMJNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AFBNCJBLBPB<TItemId, TResult> : APPHLOLOBHJ<ICEEELCAIJK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> FJIPKIMLABA(Dictionary<TItemId, int> HKKEJBKELFH, CancellationToken GHLJDIEPICD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct DCDJKGKNKMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<ICEEELCAIJK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AFBNCJBLBPB<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x51E4CB0", Offset = "0x51E3CB0", VA = "0x1851E4CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x51E6590", Offset = "0x51E5590", VA = "0x1851E6590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly FJIPKIMLABA CMCDCFJCNNM;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	public AFBNCJBLBPB(FJIPKIMLABA KEKIOGNLIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3951300", Offset = "0x3950300", VA = "0x183951300", Slot = "4")]
	[AsyncStateMachine(typeof(AFBNCJBLBPB<, >.DCDJKGKNKMG))]
	public Task<List<TResult>> NIBLKDKOPOE(IReadOnlyList<ICEEELCAIJK<TItemId>> HKKEJBKELFH, CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LAKLFINHOMN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, LLKBFGNAECE> CIJMACDHEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> PAEIMCPOKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> EHNKFEGHJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> CMEHFFLFBIK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, LLKBFGNAECE> CICPJMCBJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> IHFBAGGKFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NEDDMKIGJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x96ECB0", Offset = "0x96DCB0", VA = "0x18096ECB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x96ECA0", Offset = "0x96DCA0", VA = "0x18096ECA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3E158F0", Offset = "0x3E148F0", VA = "0x183E158F0")]
	public LAKLFINHOMN(Func<IEnumerable<T>> EHNKFEGHJHD, Func<T, string> CMEHFFLFBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3E15600", Offset = "0x3E14600", VA = "0x183E15600")]
	public void ACILEHIEJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3E15880", Offset = "0x3E14880", VA = "0x183E15880", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GOAMEGALBGF<TItemId, TResult> : JDOAEGCMNEJ<ICEEELCAIJK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x39C7910", Offset = "0x39C6910", VA = "0x1839C7910")]
	public GOAMEGALBGF(APPHLOLOBHJ<ICEEELCAIJK<TItemId>, TResult> JKJHKPDAGMN, TimeSpan JOKOIGKGBFF, [Optional] KICNHCOOJLN EHPCFJFELCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x39C77B0", Offset = "0x39C67B0", VA = "0x1839C77B0")]
	public Task<TResult> CKDMKMANAAK(TItemId OHNEPKBBADL, int LFAFBKEKCHP, [Optional] CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ICEEELCAIJK<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId OGDHAEGBGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int HAHBBHAPPID;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6590", Offset = "0x3AE5590", VA = "0x183AE6590")]
	public ICEEELCAIJK(TItemId KFKBFGEGEKN, int LFAFBKEKCHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface ADPABOGFDJL<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid MEOKMLFOCKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> NHOCIMHMHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class HAICLFEHBGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface NELKDECFEKI
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int JALIKKNFGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MCFHKFFAADM<TParam>(TParam LDGMLLMKHLF);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IIPCCAHPNID(Exception BDHJMINHKON);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool CNJCCNFNMCF();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class JHGNFGBEJAG<TResult> : NELKDECFEKI, ADPABOGFDJL<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> JOFPLCMGHII;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid MEOKMLFOCKO
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x85B1E0", Offset = "0x85A1E0", VA = "0x18085B1E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int JALIKKNFGDN
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x96ECB0", Offset = "0x96DCB0", VA = "0x18096ECB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> NHOCIMHMHMG
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3CD11D0", Offset = "0x3CD01D0", VA = "0x183CD11D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1210", Offset = "0x3CD0210", VA = "0x183CD1210")]
		public JHGNFGBEJAG(int OHMHNGNJEMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x27CBAD0", Offset = "0x27CAAD0", VA = "0x1827CBAD0", Slot = "5")]
		public bool MCFHKFFAADM<TParam>(TParam LDGMLLMKHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1190", Offset = "0x3CD0190", VA = "0x183CD1190", Slot = "6")]
		public bool IIPCCAHPNID(Exception BDHJMINHKON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1150", Offset = "0x3CD0150", VA = "0x183CD1150", Slot = "7")]
		public bool CNJCCNFNMCF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string KLALHEKBBBM = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, NELKDECFEKI> CGKELGNGDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly FKIIHDEHBPK DILJPOIADLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool MMFANHOIINB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68A4F70", Offset = "0x68A3F70", VA = "0x1868A4F70")]
	public HAICLFEHBGO([Optional] FKIIHDEHBPK DILJPOIADLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x68A4B40", Offset = "0x68A3B40", VA = "0x1868A4B40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x28CD2F0", Offset = "0x28CC2F0", VA = "0x1828CD2F0")]
	public ADPABOGFDJL<TResult> GGOPOACIHEN<TResult>(int FOABPFLDMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28CD590", Offset = "0x28CC590", VA = "0x1828CD590")]
	public bool KBJKINDEOJH<TResult>(Guid IDKMDFCBEHN, TResult NIKEINPNLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x68A4C50", Offset = "0x68A3C50", VA = "0x1868A4C50")]
	private void LDHFBFOAKLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68A4B40", Offset = "0x68A3B40", VA = "0x1868A4B40")]
	private void ONABFMCCLEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x68A4850", Offset = "0x68A3850", VA = "0x1868A4850")]
	private void BLMDHBLOJEK(int OHMHNGNJEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68A4D70", Offset = "0x68A3D70", VA = "0x1868A4D70")]
	private void NOIFFFADBAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum IFOKDNBOGKG
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BNHJEHACEIL<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class MCDIHNEAHDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int GCJDMGEHCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int MFLNEPKFKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int EJKDOOOGELM;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public MCDIHNEAHDJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId OGDHAEGBGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int HAHBBHAPPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public IFOKDNBOGKG NBCFPHNAEGH;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xEF5520", Offset = "0xEF4520", VA = "0x180EF5520")]
	public BNHJEHACEIL(TItemId KFKBFGEGEKN, int LFAFBKEKCHP, IFOKDNBOGKG KEHDHCINJMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class COONOFDCGLD<TItemId, TResult> : JDOAEGCMNEJ<BNHJEHACEIL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x39C7910", Offset = "0x39C6910", VA = "0x1839C7910")]
	public COONOFDCGLD(APPHLOLOBHJ<BNHJEHACEIL<TItemId>, TResult> JKJHKPDAGMN, TimeSpan JOKOIGKGBFF, [Optional] KICNHCOOJLN EHPCFJFELCO)
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

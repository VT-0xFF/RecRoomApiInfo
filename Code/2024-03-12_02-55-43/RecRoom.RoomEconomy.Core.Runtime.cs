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
public interface LCDOPLPLJLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KFBANLFNKJP(int KJONEMAHFIN, CancellationToken OBNOJDAGGOE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KFBANLFNKJP(TimeSpan JAGPLGLAOFL, CancellationToken OBNOJDAGGOE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AINJAKOIFMG : LCDOPLPLJLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x66D5190", Offset = "0x66D4390", VA = "0x1866D5190")]
	[JKGCDNJCKNE(MDFHPBOGAKL.Root, LIEILBDPEFI.GameOnly)]
	private static void LNEKOBBJHCN(IAIHJGNDPNA DEFANHHPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	[Preserve]
	public AINJAKOIFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x66D50D0", Offset = "0x66D42D0", VA = "0x1866D50D0", Slot = "4")]
	public Task KFBANLFNKJP(int KJONEMAHFIN, CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x66D5130", Offset = "0x66D4330", VA = "0x1866D5130", Slot = "5")]
	public Task KFBANLFNKJP(TimeSpan JAGPLGLAOFL, CancellationToken OBNOJDAGGOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AMKBKAJHJCP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct DGFFKINEAIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest KPFPONPDKAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> IGGIDCHALKI;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x90CFA0", Offset = "0x90C1A0", VA = "0x18090CFA0")]
		public DGFFKINEAIB(TRequest BDKDFPBHDIC, TaskCompletionSource<TResult> EMHLGGPPPMK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DDNNEAPLDAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public AMKBKAJHJCP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5066400", Offset = "0x5065600", VA = "0x185066400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5066940", Offset = "0x5065B40", VA = "0x185066940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct ILCOBFJIKCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AMKBKAJHJCP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x38B1430", Offset = "0x38B0630", VA = "0x1838B1430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x38B1800", Offset = "0x38B0A00", VA = "0x1838B1800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct DHAAOLEDAJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AMKBKAJHJCP<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5070290", Offset = "0x506F490", VA = "0x185070290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5070730", Offset = "0x506F930", VA = "0x185070730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct COBOFBGAPIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AMKBKAJHJCP<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4AC3FA0", Offset = "0x4AC31A0", VA = "0x184AC3FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4AC4EE0", Offset = "0x4AC40E0", VA = "0x184AC4EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly ANEFMDCMDHG<TRequest, TResult> MJJAKPIGOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float PENJBMICMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LCDOPLPLJLJ IFKCNCBCNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<DGFFKINEAIB> AOKBOGGFHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource GLEFAHABLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource MINAJFMDMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task LKOANGIJOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float NJJDJBMOPAF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BINBACMBECC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB00960", Offset = "0xAFFB60", VA = "0x180B00960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB00C30", Offset = "0xAFFE30", VA = "0x180B00C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x37ADE40", Offset = "0x37AD040", VA = "0x1837ADE40")]
	public AMKBKAJHJCP(ANEFMDCMDHG<TRequest, TResult> MJJAKPIGOAN, TimeSpan PENJBMICMHI, [Optional] LCDOPLPLJLJ IFKCNCBCNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x37AD540", Offset = "0x37AC740", VA = "0x1837AD540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x37AD750", Offset = "0x37AC950", VA = "0x1837AD750")]
	[AsyncStateMachine(typeof(AMKBKAJHJCP<, >.DDNNEAPLDAM))]
	public Task<TResult> EMJGPGOEGIJ(TRequest BDKDFPBHDIC, [Optional] CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x37ADAE0", Offset = "0x37ACCE0", VA = "0x1837ADAE0")]
	public Task PHCNAIMLPJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37ADCC0", Offset = "0x37ACEC0", VA = "0x1837ADCC0")]
	[AsyncStateMachine(typeof(AMKBKAJHJCP<, >.ILCOBFJIKCC))]
	private Task PLIEPFEFGMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x37ADBA0", Offset = "0x37ACDA0", VA = "0x1837ADBA0")]
	[AsyncStateMachine(typeof(AMKBKAJHJCP<, >.DHAAOLEDAJJ))]
	private Task PHJNEIOOFGC(CancellationToken FLKKCEHIIIL, CancellationToken CJBBBMNCKIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x37AD440", Offset = "0x37AC640", VA = "0x1837AD440")]
	[AsyncStateMachine(typeof(AMKBKAJHJCP<, >.COBOFBGAPIB))]
	private Task DJKNMNFECHF(CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x37ADA10", Offset = "0x37ACC10", VA = "0x1837ADA10")]
	private TimeSpan OGLNPIHEDKI()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37AD900", Offset = "0x37ACB00", VA = "0x1837AD900")]
	private Task<List<TResult>> IHIPILJNKDD(IReadOnlyList<TRequest> KCGAJHFIDGP, CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x37ADDA0", Offset = "0x37ACFA0", VA = "0x1837ADDA0")]
	private float PNKOJNJFLBG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37AD870", Offset = "0x37ACA70", VA = "0x1837AD870")]
	private void HIPAKMOHCAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class OEEONIEOEHP<TItemId, TResult> : ANEFMDCMDHG<NEAAPGENOAC<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> FOCMIAPJOJK(Dictionary<TItemId, int> KCGAJHFIDGP, CancellationToken OBNOJDAGGOE);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class HCPNGPDCACM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public HCPNGPDCACM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x37BF670", Offset = "0x37BE870", VA = "0x1837BF670")]
		internal TResult IHGNHFKCINJ(NEAAPGENOAC<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GMBMNHBACJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<NEAAPGENOAC<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public OEEONIEOEHP<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private HCPNGPDCACM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x375C780", Offset = "0x375B980", VA = "0x18375C780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x375D4D0", Offset = "0x375C6D0", VA = "0x18375D4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly FOCMIAPJOJK IOCHHONEMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> AFNKGJFOKIJ;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x40649A0", Offset = "0x4063BA0", VA = "0x1840649A0")]
	public OEEONIEOEHP(FOCMIAPJOJK IOCHHONEMOM, [Optional] IEqualityComparer<TItemId> AFNKGJFOKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4064700", Offset = "0x4063900", VA = "0x184064700", Slot = "4")]
	[AsyncStateMachine(typeof(OEEONIEOEHP<, >.GMBMNHBACJH))]
	public Task<List<TResult>> HEFOOAEKAOO(IReadOnlyList<NEAAPGENOAC<TItemId>> KCGAJHFIDGP, CancellationToken OBNOJDAGGOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PCIPFBJENJA<TRequest, TResult> : ANEFMDCMDHG<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> ICAPJMMCFEI(IEnumerable<TRequest> JAKDMDNMGMO, CancellationToken OBNOJDAGGOE);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class OHFCAFPLNHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public OHFCAFPLNHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x375B2F0", Offset = "0x375A4F0", VA = "0x18375B2F0")]
		internal TResult IHGNHFKCINJ(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct IKHDCGFPOGP : IAsyncStateMachine
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
		public PCIPFBJENJA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private OHFCAFPLNHM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x38AE530", Offset = "0x38AD730", VA = "0x1838AE530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x38AF360", Offset = "0x38AE560", VA = "0x1838AF360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly ICAPJMMCFEI IOCHHONEMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> AFNKGJFOKIJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x40649A0", Offset = "0x4063BA0", VA = "0x1840649A0")]
	public PCIPFBJENJA(ICAPJMMCFEI IOCHHONEMOM, [Optional] IEqualityComparer<TRequest> AFNKGJFOKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x412A0D0", Offset = "0x41292D0", VA = "0x18412A0D0", Slot = "4")]
	[AsyncStateMachine(typeof(PCIPFBJENJA<, >.IKHDCGFPOGP))]
	public Task<List<TResult>> HEFOOAEKAOO(IReadOnlyList<TRequest> KCGAJHFIDGP, CancellationToken OBNOJDAGGOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ANEFMDCMDHG<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> HEFOOAEKAOO(IReadOnlyList<TRequest> KCGAJHFIDGP, CancellationToken OBNOJDAGGOE);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class AOAJPFACDGN<TItemId, TResult> : ANEFMDCMDHG<COAFPNCEIBH<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task NOJPBDEGDIE(IReadOnlyDictionary<TItemId, COAFPNCEIBH<TItemId>.PPEKHDPMJMH> KCGAJHFIDGP, CancellationToken OBNOJDAGGOE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct AOEJJPFGEDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AOAJPFACDGN<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<COAFPNCEIBH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x37AF750", Offset = "0x37AE950", VA = "0x1837AF750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x37AFC80", Offset = "0x37AEE80", VA = "0x1837AFC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly NOJPBDEGDIE PBDFFLLGNDD;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	public AOAJPFACDGN(NOJPBDEGDIE PBDFFLLGNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x37AF610", Offset = "0x37AE810", VA = "0x1837AF610", Slot = "4")]
	[AsyncStateMachine(typeof(AOAJPFACDGN<, >.AOEJJPFGEDI))]
	public Task<List<object>> HEFOOAEKAOO(IReadOnlyList<COAFPNCEIBH<TItemId>> KCGAJHFIDGP, CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x37AF1A0", Offset = "0x37AE3A0", VA = "0x1837AF1A0")]
	private IReadOnlyDictionary<TItemId, COAFPNCEIBH<TItemId>.PPEKHDPMJMH> CAFDDPPIPDI(IReadOnlyList<COAFPNCEIBH<TItemId>> MNKEKAEMDCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ELKPIBBGBBF<TItemId, TResult> : ANEFMDCMDHG<NEAAPGENOAC<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> BGLIEMODNPP(Dictionary<TItemId, int> KCGAJHFIDGP, CancellationToken OBNOJDAGGOE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct MLBLFPNLJFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<NEAAPGENOAC<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public ELKPIBBGBBF<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DE70", Offset = "0x3E7D070", VA = "0x183E7DE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EAE0", Offset = "0x3E7DCE0", VA = "0x183E7EAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly BGLIEMODNPP GOELDEHKANG;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	public ELKPIBBGBBF(BGLIEMODNPP IOCHHONEMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x32C86A0", Offset = "0x32C78A0", VA = "0x1832C86A0", Slot = "4")]
	[AsyncStateMachine(typeof(ELKPIBBGBBF<, >.MLBLFPNLJFK))]
	public Task<List<TResult>> HEFOOAEKAOO(IReadOnlyList<NEAAPGENOAC<TItemId>> KCGAJHFIDGP, CancellationToken OBNOJDAGGOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NIPLGPDHAHM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, KGHLGOHBMGA> ANKBCPELBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> BPGMCPJKHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> PDADNOKCEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> PAJDOCOLDHK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, KGHLGOHBMGA> ONDGLLNLPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> IDFLECPBDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NADIPLGBBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x969DC0", Offset = "0x968FC0", VA = "0x180969DC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x969DD0", Offset = "0x968FD0", VA = "0x180969DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3F5AD80", Offset = "0x3F59F80", VA = "0x183F5AD80")]
	public NIPLGPDHAHM(Func<IEnumerable<T>> PDADNOKCEEM, Func<T, string> PAJDOCOLDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3F5AB00", Offset = "0x3F59D00", VA = "0x183F5AB00")]
	public void HIJKAFNAKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3F5AA90", Offset = "0x3F59C90", VA = "0x183F5AA90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CCFIKALNIOD<TItemId, TResult> : AMKBKAJHJCP<NEAAPGENOAC<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x36140A0", Offset = "0x36132A0", VA = "0x1836140A0")]
	public CCFIKALNIOD(ANEFMDCMDHG<NEAAPGENOAC<TItemId>, TResult> MJJAKPIGOAN, TimeSpan PENJBMICMHI, [Optional] LCDOPLPLJLJ IFKCNCBCNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x48E8960", Offset = "0x48E7B60", VA = "0x1848E8960")]
	public Task<TResult> EMJGPGOEGIJ(TItemId HKNPGHOCJDO, int IPCCNPIMMBE, [Optional] CancellationToken OBNOJDAGGOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NEAAPGENOAC<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId DGPDBFMFODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int HOHNGJKGOIC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3F16F60", Offset = "0x3F16160", VA = "0x183F16F60")]
	public NEAAPGENOAC(TItemId MIMFIOFCFOE, int IPCCNPIMMBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MFEOPHGLFID<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid PMIFMGKPCED
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> PFCFJOLDEME
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NCAOHAEFLDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface IMNAGKGNCDE
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int LNOIFOPHADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool NDMNCENFDGN<TParam>(TParam AFCGKMGKPEF);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool FAHLGLFIPGH(Exception ACDJDIDJFCA);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool IMGEPFJNLAP();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class FIPFMEMLKGF<TResult> : IMNAGKGNCDE, MFEOPHGLFID<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> IAIONEHGECN;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid PMIFMGKPCED
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8507D0", Offset = "0x84F9D0", VA = "0x1808507D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int LNOIFOPHADO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x969DC0", Offset = "0x968FC0", VA = "0x180969DC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> PFCFJOLDEME
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x364C9E0", Offset = "0x364BBE0", VA = "0x18364C9E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x364CA20", Offset = "0x364BC20", VA = "0x18364CA20")]
		public FIPFMEMLKGF(int DIDICPMKKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x26A2B30", Offset = "0x26A1D30", VA = "0x1826A2B30", Slot = "5")]
		public bool NDMNCENFDGN<TParam>(TParam AFCGKMGKPEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x364C960", Offset = "0x364BB60", VA = "0x18364C960", Slot = "6")]
		public bool FAHLGLFIPGH(Exception ACDJDIDJFCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x364C9A0", Offset = "0x364BBA0", VA = "0x18364C9A0", Slot = "7")]
		public bool IMGEPFJNLAP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string DKGCOGGFMML = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, IMNAGKGNCDE> KJKDGDGEMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly MCLGFEIBKJK GEADIDEJMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool LPJAGOHGDAE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x66D59B0", Offset = "0x66D4BB0", VA = "0x1866D59B0")]
	public NCAOHAEFLDB([Optional] MCLGFEIBKJK GEADIDEJMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x66D5780", Offset = "0x66D4980", VA = "0x1866D5780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x28A2B00", Offset = "0x28A1D00", VA = "0x1828A2B00")]
	public MFEOPHGLFID<TResult> IMBEFECJHFM<TResult>(int CGBNMEDJAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28A2DA0", Offset = "0x28A1FA0", VA = "0x1828A2DA0")]
	public bool JFCHKJJJPFK<TResult>(Guid HNLNEJGIEGK, TResult JKJJELABMHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x66D5890", Offset = "0x66D4A90", VA = "0x1866D5890")]
	private void NDJGJKLOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x66D5780", Offset = "0x66D4980", VA = "0x1866D5780")]
	private void OJNLJCIIFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x66D5290", Offset = "0x66D4490", VA = "0x1866D5290")]
	private void BHFJFDPEPFD(int DIDICPMKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x66D5580", Offset = "0x66D4780", VA = "0x1866D5580")]
	private void BNCOFOLEIFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum MHHLPLFJGPH
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class COAFPNCEIBH<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PPEKHDPMJMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int FMAOAHGHBDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int OEOEDBPMMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int GJNLHEBBCJE;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public PPEKHDPMJMH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId DGPDBFMFODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int HOHNGJKGOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public MHHLPLFJGPH IEFOIJMEHPA;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xEECFB0", Offset = "0xEEC1B0", VA = "0x180EECFB0")]
	public COAFPNCEIBH(TItemId MIMFIOFCFOE, int IPCCNPIMMBE, MHHLPLFJGPH CGONJAIKCGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class FDEAOBHCOFA<TItemId, TResult> : AMKBKAJHJCP<COAFPNCEIBH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x36140A0", Offset = "0x36132A0", VA = "0x1836140A0")]
	public FDEAOBHCOFA(ANEFMDCMDHG<COAFPNCEIBH<TItemId>, TResult> MJJAKPIGOAN, TimeSpan PENJBMICMHI, [Optional] LCDOPLPLJLJ IFKCNCBCNJN)
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

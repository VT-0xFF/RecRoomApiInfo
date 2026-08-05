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
public interface PMDBKOAKMNP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DHBFCHGBMAH(int ODCAGDKELBJ, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DHBFCHGBMAH(TimeSpan GHJGFBOMOGB, CancellationToken JMJKFNJJBHM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class JFLLEKKJKGN : PMDBKOAKMNP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x674D580", Offset = "0x674C580", VA = "0x18674D580")]
	[KEBGMDILACL(LNECJMDANHH.Root, JMIJNHPDBML.GameOnly)]
	private static void NGBEIAHPFCC(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	[Preserve]
	public JFLLEKKJKGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x674D520", Offset = "0x674C520", VA = "0x18674D520", Slot = "4")]
	public Task DHBFCHGBMAH(int ODCAGDKELBJ, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x674D4C0", Offset = "0x674C4C0", VA = "0x18674D4C0", Slot = "5")]
	public Task DHBFCHGBMAH(TimeSpan GHJGFBOMOGB, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FOPMOJJJNJG<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct DOGBHOGIDMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest NCKGDCAGBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> GHDKPEMLGMH;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x909C10", Offset = "0x908C10", VA = "0x180909C10")]
		public DOGBHOGIDMJ(TRequest LFFEKPPMJHN, TaskCompletionSource<TResult> IFEIDNJIJAO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct MKKJILAJIFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public FOPMOJJJNJG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3C30", Offset = "0x3ED2C30", VA = "0x183ED3C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4170", Offset = "0x3ED3170", VA = "0x183ED4170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct LACFCFHKBKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public FOPMOJJJNJG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB7E0", Offset = "0x3CCA7E0", VA = "0x183CCB7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3CCBBB0", Offset = "0x3CCABB0", VA = "0x183CCBBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LNAAHKFMFHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FOPMOJJJNJG<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3CFABC0", Offset = "0x3CF9BC0", VA = "0x183CFABC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3CFB060", Offset = "0x3CFA060", VA = "0x183CFB060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct MIPBCJCPKJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public FOPMOJJJNJG<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3ECFA20", Offset = "0x3ECEA20", VA = "0x183ECFA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0960", Offset = "0x3ECF960", VA = "0x183ED0960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly CIMLCNJKOKA<TRequest, TResult> PJCDMAKLFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float FMLFJJKCMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PMDBKOAKMNP NJBGKLEFIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<DOGBHOGIDMJ> KNLDJIGFFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource EBILOPCGOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource DKDEKMKNMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task PPKPBIIPLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float FNMDGCPHOJK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CLLGOADBCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB01510", Offset = "0xB00510", VA = "0x180B01510")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB01520", Offset = "0xB00520", VA = "0x180B01520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x369C680", Offset = "0x369B680", VA = "0x18369C680")]
	public FOPMOJJJNJG(CIMLCNJKOKA<TRequest, TResult> PJCDMAKLFLB, TimeSpan FMLFJJKCMIJ, [Optional] PMDBKOAKMNP NJBGKLEFIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x369C000", Offset = "0x369B000", VA = "0x18369C000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x369C440", Offset = "0x369B440", VA = "0x18369C440")]
	[AsyncStateMachine(typeof(FOPMOJJJNJG<, >.MKKJILAJIFA))]
	public Task<TResult> KOPKOEIKBGB(TRequest LFFEKPPMJHN, [Optional] CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x369C210", Offset = "0x369B210", VA = "0x18369C210")]
	public Task FNLEIGHIFCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x369C2D0", Offset = "0x369B2D0", VA = "0x18369C2D0")]
	[AsyncStateMachine(typeof(FOPMOJJJNJG<, >.LACFCFHKBKE))]
	private Task IFEELJLOHHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x369C560", Offset = "0x369B560", VA = "0x18369C560")]
	[AsyncStateMachine(typeof(FOPMOJJJNJG<, >.LNAAHKFMFHA))]
	private Task NBHIALAMGMA(CancellationToken FGCFPPNGFMA, CancellationToken LEAPKHJNNMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x369BC80", Offset = "0x369AC80", VA = "0x18369BC80")]
	[AsyncStateMachine(typeof(FOPMOJJJNJG<, >.MIPBCJCPKJO))]
	private Task AIMHPNKKCGO(CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x369BF30", Offset = "0x369AF30", VA = "0x18369BF30")]
	private TimeSpan DEDJFEBIFAH()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x369BE20", Offset = "0x369AE20", VA = "0x18369BE20")]
	private Task<List<TResult>> BCHMHJLCIBL(IReadOnlyList<TRequest> GPNADCFJFEJ, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x369BD80", Offset = "0x369AD80", VA = "0x18369BD80")]
	private float ANCBKEAHIDI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x369C3B0", Offset = "0x369B3B0", VA = "0x18369C3B0")]
	private void KGDEKAPLMGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CFPKGOGAJED<TItemId, TResult> : CIMLCNJKOKA<MJBKBCHCBGA<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> FLMFGHHAKMA(Dictionary<TItemId, int> GPNADCFJFEJ, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GKDOBMMFIPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public GKDOBMMFIPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x375D020", Offset = "0x375C020", VA = "0x18375D020")]
		internal TResult GDNLKPLFKLK(MJBKBCHCBGA<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PHBAAPELCDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<MJBKBCHCBGA<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public CFPKGOGAJED<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private GKDOBMMFIPG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x41482A0", Offset = "0x41472A0", VA = "0x1841482A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4148FF0", Offset = "0x4147FF0", VA = "0x184148FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly FLMFGHHAKMA LHLIFHHABKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> IKJKCDAEEGG;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DE40", Offset = "0x3B4CE40", VA = "0x183B4DE40")]
	public CFPKGOGAJED(FLMFGHHAKMA LHLIFHHABKG, [Optional] IEqualityComparer<TItemId> IKJKCDAEEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4C8FEF0", Offset = "0x4C8EEF0", VA = "0x184C8FEF0", Slot = "4")]
	[AsyncStateMachine(typeof(CFPKGOGAJED<, >.PHBAAPELCDD))]
	public Task<List<TResult>> CGNKOJAKOFE(IReadOnlyList<MJBKBCHCBGA<TItemId>> GPNADCFJFEJ, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JMJFEGEPKMJ<TRequest, TResult> : CIMLCNJKOKA<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> PNMEELAFFCP(IEnumerable<TRequest> FGEJGNCCEMD, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class AGGMGOIABML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public AGGMGOIABML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x37A1B10", Offset = "0x37A0B10", VA = "0x1837A1B10")]
		internal TResult GDNLKPLFKLK(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct GNMEPCDJLJM : IAsyncStateMachine
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
		public JMJFEGEPKMJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private AGGMGOIABML <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3768CD0", Offset = "0x3767CD0", VA = "0x183768CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3769B00", Offset = "0x3768B00", VA = "0x183769B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly PNMEELAFFCP LHLIFHHABKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> IKJKCDAEEGG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DE40", Offset = "0x3B4CE40", VA = "0x183B4DE40")]
	public JMJFEGEPKMJ(PNMEELAFFCP LHLIFHHABKG, [Optional] IEqualityComparer<TRequest> IKJKCDAEEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DCF0", Offset = "0x3B4CCF0", VA = "0x183B4DCF0", Slot = "4")]
	[AsyncStateMachine(typeof(JMJFEGEPKMJ<, >.GNMEPCDJLJM))]
	public Task<List<TResult>> CGNKOJAKOFE(IReadOnlyList<TRequest> GPNADCFJFEJ, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CIMLCNJKOKA<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> CGNKOJAKOFE(IReadOnlyList<TRequest> GPNADCFJFEJ, CancellationToken JMJKFNJJBHM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JHAFFGGBMNN<TItemId, TResult> : CIMLCNJKOKA<JBCACEMOFKK<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task PLIANEKEIJB(IReadOnlyDictionary<TItemId, JBCACEMOFKK<TItemId>.DPFNJEAHJOB> GPNADCFJFEJ, CancellationToken JMJKFNJJBHM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct MBONHANMHPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public JHAFFGGBMNN<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<JBCACEMOFKK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA7A0", Offset = "0x3EB97A0", VA = "0x183EBA7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3EBACD0", Offset = "0x3EB9CD0", VA = "0x183EBACD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly PLIANEKEIJB PFFDKJDKCLL;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public JHAFFGGBMNN(PLIANEKEIJB PFFDKJDKCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3B3C910", Offset = "0x3B3B910", VA = "0x183B3C910", Slot = "4")]
	[AsyncStateMachine(typeof(JHAFFGGBMNN<, >.MBONHANMHPC))]
	public Task<List<object>> CGNKOJAKOFE(IReadOnlyList<JBCACEMOFKK<TItemId>> GPNADCFJFEJ, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B3C4A0", Offset = "0x3B3B4A0", VA = "0x183B3C4A0")]
	private IReadOnlyDictionary<TItemId, JBCACEMOFKK<TItemId>.DPFNJEAHJOB> AKILOKJFLJG(IReadOnlyList<JBCACEMOFKK<TItemId>> NCBJOJEMOFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HPGNBMOLPLJ<TItemId, TResult> : CIMLCNJKOKA<MJBKBCHCBGA<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> AFMIJKFNKHN(Dictionary<TItemId, int> GPNADCFJFEJ, CancellationToken JMJKFNJJBHM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct PEMADJJFMGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<MJBKBCHCBGA<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public HPGNBMOLPLJ<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x41403B0", Offset = "0x413F3B0", VA = "0x1841403B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4141C90", Offset = "0x4140C90", VA = "0x184141C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly AFMIJKFNKHN ELBNMLEGDPJ;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public HPGNBMOLPLJ(AFMIJKFNKHN LHLIFHHABKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3804D00", Offset = "0x3803D00", VA = "0x183804D00", Slot = "4")]
	[AsyncStateMachine(typeof(HPGNBMOLPLJ<, >.PEMADJJFMGJ))]
	public Task<List<TResult>> CGNKOJAKOFE(IReadOnlyList<MJBKBCHCBGA<TItemId>> GPNADCFJFEJ, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OMIPGDDDBAF<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, JHHJCHFLMID> LIKPEHADLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> AJKHDLLONGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> BKOMONCOEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> BEHPBNBHLAI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, JHHJCHFLMID> KAFIDOACFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> GKCDMGCGOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OFKHIHOFHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x967480", Offset = "0x966480", VA = "0x180967480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9674A0", Offset = "0x9664A0", VA = "0x1809674A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4084E30", Offset = "0x4083E30", VA = "0x184084E30")]
	public OMIPGDDDBAF(Func<IEnumerable<T>> BKOMONCOEIK, Func<T, string> BEHPBNBHLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4084BB0", Offset = "0x4083BB0", VA = "0x184084BB0")]
	public void EKOOOFBJPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4084B40", Offset = "0x4083B40", VA = "0x184084B40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NALPJIJJDGA<TItemId, TResult> : FOPMOJJJNJG<MJBKBCHCBGA<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x365D5D0", Offset = "0x365C5D0", VA = "0x18365D5D0")]
	public NALPJIJJDGA(CIMLCNJKOKA<MJBKBCHCBGA<TItemId>, TResult> PJCDMAKLFLB, TimeSpan FMLFJJKCMIJ, [Optional] PMDBKOAKMNP NJBGKLEFIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3F28AE0", Offset = "0x3F27AE0", VA = "0x183F28AE0")]
	public Task<TResult> KOPKOEIKBGB(TItemId IPAJBJLLPIJ, int IBMLGBPJGGA, [Optional] CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MJBKBCHCBGA<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId IDEINICDFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int DGLMPEPLFHB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3ED0A50", Offset = "0x3ECFA50", VA = "0x183ED0A50")]
	public MJBKBCHCBGA(TItemId FPGCGKLCFOG, int IBMLGBPJGGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BEGFMBGAJEP<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid CPHBLMDNGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> IEDFDIBFHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class PMCIFILJECA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface OFBGHLOKCMP
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int OEGKNJGJGIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool EAGKEPNJOHG<TParam>(TParam CFJDHAGGAJO);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LMIBMKFFLGG(Exception LPBJFENAMEF);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool MMOJEHFJHMB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class JFLPNOOJJAC<TResult> : OFBGHLOKCMP, BEGFMBGAJEP<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> BEBOGKEEMEA;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid CPHBLMDNGAE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x844EC0", Offset = "0x843EC0", VA = "0x180844EC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int OEGKNJGJGIC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x967480", Offset = "0x966480", VA = "0x180967480", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> IEDFDIBFHNK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3B38480", Offset = "0x3B37480", VA = "0x183B38480", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3B38540", Offset = "0x3B37540", VA = "0x183B38540")]
		public JFLPNOOJJAC(int ICDGMDPDMNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x25B52C0", Offset = "0x25B42C0", VA = "0x1825B52C0", Slot = "5")]
		public bool EAGKEPNJOHG<TParam>(TParam CFJDHAGGAJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3B384C0", Offset = "0x3B374C0", VA = "0x183B384C0", Slot = "6")]
		public bool LMIBMKFFLGG(Exception LPBJFENAMEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3B38500", Offset = "0x3B37500", VA = "0x183B38500", Slot = "7")]
		public bool MMOJEHFJHMB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string NLIAFNJEPJM = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, OFBGHLOKCMP> JDLGBILMAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly HEPKIGAEAOE FPEAGAJFDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool GEEMKKEOJJE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x674DDA0", Offset = "0x674CDA0", VA = "0x18674DDA0")]
	public PMCIFILJECA([Optional] HEPKIGAEAOE FPEAGAJFDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x674DC90", Offset = "0x674CC90", VA = "0x18674DC90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2935860", Offset = "0x2934860", VA = "0x182935860")]
	public BEGFMBGAJEP<TResult> MPNBFGGCKHE<TResult>(int PPOKAJMDGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2935530", Offset = "0x2934530", VA = "0x182935530")]
	public bool FKPPHIGNOBK<TResult>(Guid FCBFKEBMKED, TResult HEOGODCLBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x674D680", Offset = "0x674C680", VA = "0x18674D680")]
	private void BIEDLMKNBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x674DC90", Offset = "0x674CC90", VA = "0x18674DC90")]
	private void EEMEMMMKPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x674D7A0", Offset = "0x674C7A0", VA = "0x18674D7A0")]
	private void DBDEOCILLLG(int ICDGMDPDMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x674DA90", Offset = "0x674CA90", VA = "0x18674DA90")]
	private void DFKBHPHAJOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum MDINFLHBNGA
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class JBCACEMOFKK<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class DPFNJEAHJOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int MJEHNMNADIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int HMLPOCBFGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int BIODELEKDEF;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public DPFNJEAHJOB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId IDEINICDFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int DGLMPEPLFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public MDINFLHBNGA AFFCADFGEJF;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xF00340", Offset = "0xEFF340", VA = "0x180F00340")]
	public JBCACEMOFKK(TItemId FPGCGKLCFOG, int IBMLGBPJGGA, MDINFLHBNGA HLPKKPNOMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class FAFJJPKNGCN<TItemId, TResult> : FOPMOJJJNJG<JBCACEMOFKK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x365D5D0", Offset = "0x365C5D0", VA = "0x18365D5D0")]
	public FAFJJPKNGCN(CIMLCNJKOKA<JBCACEMOFKK<TItemId>, TResult> PJCDMAKLFLB, TimeSpan FMLFJJKCMIJ, [Optional] PMDBKOAKMNP NJBGKLEFIAJ)
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

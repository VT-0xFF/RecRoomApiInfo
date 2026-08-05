using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NEKMDFKADJO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IOLKANPENGF(int OCEDDOENDFM, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IOLKANPENGF(TimeSpan LDAMINNCNAI, CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MMKBHKOPANA : NEKMDFKADJO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76D9A10", Offset = "0x76D8E10", VA = "0x1876D9A10")]
	[AGCFNMIICNN.OGAOPBBDHOG.CHABDOHBNJI]
	internal static void MHHLPLPPGCP(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	[RecRoom.NoEngine.Common.Preserve]
	public MMKBHKOPANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x76D9950", Offset = "0x76D8D50", VA = "0x1876D9950", Slot = "4")]
	public Task IOLKANPENGF(int OCEDDOENDFM, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x76D99B0", Offset = "0x76D8DB0", VA = "0x1876D99B0", Slot = "5")]
	public Task IOLKANPENGF(TimeSpan LDAMINNCNAI, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x76D9B00", Offset = "0x76D8F00", VA = "0x1876D9B00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IDLKFBINGDK<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct HJHCHNDKPDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest OGFCOLMHMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> KFOKNAGLHJG;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xE8EEE0", Offset = "0xE8E2E0", VA = "0x180E8EEE0")]
		public HJHCHNDKPDL(TRequest BLIDGDGMCAP, TaskCompletionSource<TResult> LAMCFMALIOO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct MFIMEOMCPEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public IDLKFBINGDK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x49E82C0", Offset = "0x49E76C0", VA = "0x1849E82C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x41E0E80", Offset = "0x41E0280", VA = "0x1841E0E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct KOBMNECBGED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public IDLKFBINGDK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x472DDB0", Offset = "0x472D1B0", VA = "0x18472DDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x472E1A0", Offset = "0x472D5A0", VA = "0x18472E1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct IDOMMGLBCGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public IDLKFBINGDK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4330D00", Offset = "0x4330100", VA = "0x184330D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x43311C0", Offset = "0x43305C0", VA = "0x1843311C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct IKNILICEPBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public IDLKFBINGDK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<TRequest> <requests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4353F90", Offset = "0x4353390", VA = "0x184353F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x43551C0", Offset = "0x43545C0", VA = "0x1843551C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly OPDGHHKHELB<TRequest, TResult> FBJPFAKODCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float HKELKPANOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NEKMDFKADJO AFLJLBFNLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool BNCMEMMKPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<HJHCHNDKPDL> IMCOCCLJBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<HJHCHNDKPDL> ONJBBJLFOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool IKFJEPAHBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource OFCMBIPNCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource OKPGMCBIIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task KHDMKJGKLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float KLHIPDPHFMA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BEICAADJBDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8D0DB0", Offset = "0x8D01B0", VA = "0x1808D0DB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8D0C70", Offset = "0x8D0070", VA = "0x1808D0C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x43309D0", Offset = "0x432FDD0", VA = "0x1843309D0")]
	public IDLKFBINGDK(OPDGHHKHELB<TRequest, TResult> FBJPFAKODCH, TimeSpan HKELKPANOCK, bool BNCMEMMKPHB, [Optional] NEKMDFKADJO AFLJLBFNLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4330060", Offset = "0x432F460", VA = "0x184330060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x43302B0", Offset = "0x432F6B0", VA = "0x1843302B0")]
	[AsyncStateMachine(typeof(IDLKFBINGDK<, >.MFIMEOMCPEG))]
	public Task<TResult> FBLKKENCDJI(TRequest BLIDGDGMCAP, [Optional] CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x43303E0", Offset = "0x432F7E0", VA = "0x1843303E0")]
	private void FBLKKENCDJI(TRequest BLIDGDGMCAP, TaskCompletionSource<TResult> LAMCFMALIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4330810", Offset = "0x432FC10", VA = "0x184330810")]
	public Task MBDPFABHJPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x432FEA0", Offset = "0x432F2A0", VA = "0x18432FEA0")]
	[AsyncStateMachine(typeof(IDLKFBINGDK<, >.KOBMNECBGED))]
	private Task CCIJFJJOAKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4330480", Offset = "0x432F880", VA = "0x184330480")]
	[AsyncStateMachine(typeof(IDLKFBINGDK<, >.IDOMMGLBCGO))]
	private Task HOKFDPMLNCG(CancellationToken OAOHCDMOEGP, CancellationToken DDLHOFAEPNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x43308D0", Offset = "0x432FCD0", VA = "0x1843308D0")]
	[AsyncStateMachine(typeof(IDLKFBINGDK<, >.IKNILICEPBE))]
	private Task NHHAGPNGCDP(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x432FF80", Offset = "0x432F380", VA = "0x18432FF80")]
	private TimeSpan CDEKGMFAPOA()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x43305A0", Offset = "0x432F9A0", VA = "0x1843305A0")]
	private Task<List<TResult>> JPHGAHCAGLA(IReadOnlyList<TRequest> NODNNPCBDHO, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x43306C0", Offset = "0x432FAC0", VA = "0x1843306C0")]
	private float KBLJOLOBIMA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4330760", Offset = "0x432FB60", VA = "0x184330760")]
	private void KCGILCAAMKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LNENIFIGMDF<TItemId, TResult> : OPDGHHKHELB<PAPHDIKDLEF<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> FPGJAJPOBJL(Dictionary<TItemId, int> NODNNPCBDHO, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class AECPGDHIIDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AECPGDHIIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x41C8DC0", Offset = "0x41C81C0", VA = "0x1841C8DC0")]
		internal TResult MOKJDJBGMFA(PAPHDIKDLEF<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LCHCJMOMKNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<PAPHDIKDLEF<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public LNENIFIGMDF<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private AECPGDHIIDL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x47BBA80", Offset = "0x47BAE80", VA = "0x1847BBA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x47BC870", Offset = "0x47BBC70", VA = "0x1847BC870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly FPGJAJPOBJL BNPHAAFFGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> GNOIOLAMEKG;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x47E5790", Offset = "0x47E4B90", VA = "0x1847E5790")]
	public LNENIFIGMDF(FPGJAJPOBJL BNPHAAFFGIO, [Optional] IEqualityComparer<TItemId> GNOIOLAMEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x47E54F0", Offset = "0x47E48F0", VA = "0x1847E54F0", Slot = "4")]
	[AsyncStateMachine(typeof(LNENIFIGMDF<, >.LCHCJMOMKNF))]
	public Task<List<TResult>> HBJLINHEFLM(IReadOnlyList<PAPHDIKDLEF<TItemId>> NODNNPCBDHO, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NMBAEHOCCJF<TRequest, TResult> : OPDGHHKHELB<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> JHPGFMANCAP(IEnumerable<TRequest> JGCCNBHNOIM, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class NPPNMDIAEDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public NPPNMDIAEDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4053A20", Offset = "0x4052E20", VA = "0x184053A20")]
		internal TResult MOKJDJBGMFA(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LFPFHOPMJEI : IAsyncStateMachine
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
		public NMBAEHOCCJF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private NPPNMDIAEDC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x47C6B30", Offset = "0x47C5F30", VA = "0x1847C6B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x47C7A30", Offset = "0x47C6E30", VA = "0x1847C7A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly JHPGFMANCAP BNPHAAFFGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> GNOIOLAMEKG;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x47E5790", Offset = "0x47E4B90", VA = "0x1847E5790")]
	public NMBAEHOCCJF(JHPGFMANCAP BNPHAAFFGIO, [Optional] IEqualityComparer<TRequest> GNOIOLAMEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4A9C0F0", Offset = "0x4A9B4F0", VA = "0x184A9C0F0", Slot = "4")]
	[AsyncStateMachine(typeof(NMBAEHOCCJF<, >.LFPFHOPMJEI))]
	public Task<List<TResult>> HBJLINHEFLM(IReadOnlyList<TRequest> NODNNPCBDHO, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OPDGHHKHELB<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> HBJLINHEFLM(IReadOnlyList<TRequest> NODNNPCBDHO, CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LOHOMFBPONP<TItemId, TResult> : OPDGHHKHELB<FPFECNCKIKN<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task JLJNKFJJHCE(IReadOnlyDictionary<TItemId, FPFECNCKIKN<TItemId>.OANFGEBHABF> NODNNPCBDHO, CancellationToken FHGIOBPPFHG);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct CFDGINAODMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LOHOMFBPONP<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<FPFECNCKIKN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5701DD0", Offset = "0x57011D0", VA = "0x185701DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5702350", Offset = "0x5701750", VA = "0x185702350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly JLJNKFJJHCE JHOJPGCHKDF;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public LOHOMFBPONP(JLJNKFJJHCE JHOJPGCHKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x47EDFB0", Offset = "0x47ED3B0", VA = "0x1847EDFB0", Slot = "4")]
	[AsyncStateMachine(typeof(LOHOMFBPONP<, >.CFDGINAODMF))]
	public Task<List<object>> HBJLINHEFLM(IReadOnlyList<FPFECNCKIKN<TItemId>> NODNNPCBDHO, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x47EDB20", Offset = "0x47ECF20", VA = "0x1847EDB20")]
	private IReadOnlyDictionary<TItemId, FPFECNCKIKN<TItemId>.OANFGEBHABF> GFACHFBFOBK(IReadOnlyList<FPFECNCKIKN<TItemId>> GBMPIDHAJML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JNOLGFDAADE<TItemId, TResult> : OPDGHHKHELB<PAPHDIKDLEF<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> GCHODGFPFIO(Dictionary<TItemId, int> NODNNPCBDHO, CancellationToken FHGIOBPPFHG);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct HGJOPFCACMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<PAPHDIKDLEF<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public JNOLGFDAADE<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4248EB0", Offset = "0x42482B0", VA = "0x184248EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x424A8F0", Offset = "0x4249CF0", VA = "0x18424A8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly GCHODGFPFIO LOHNIGGGLFN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public JNOLGFDAADE(GCHODGFPFIO BNPHAAFFGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x45990B0", Offset = "0x45984B0", VA = "0x1845990B0", Slot = "4")]
	[AsyncStateMachine(typeof(JNOLGFDAADE<, >.HGJOPFCACMG))]
	public Task<List<TResult>> HBJLINHEFLM(IReadOnlyList<PAPHDIKDLEF<TItemId>> NODNNPCBDHO, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OLIEPDDOAIG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, CKGLPPPLONC> LJFKDGEONLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> OIBAHEHHBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> PPEEJJLOJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> AKJBLOPGGCN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, CKGLPPPLONC> JHAFBLFONNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> GOBMDFFKNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PKAOGNOLJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x968260", Offset = "0x967660", VA = "0x180968260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x96FA40", Offset = "0x96EE40", VA = "0x18096FA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4B90F80", Offset = "0x4B90380", VA = "0x184B90F80")]
	public OLIEPDDOAIG(Func<IEnumerable<T>> PPEEJJLOJHP, Func<T, string> AKJBLOPGGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4B90C20", Offset = "0x4B90020", VA = "0x184B90C20")]
	public void BFLBMILJDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4B90EF0", Offset = "0x4B902F0", VA = "0x184B90EF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MABMMFKBDJD<TItemId, TResult> : IDLKFBINGDK<PAPHDIKDLEF<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4269420", Offset = "0x4268820", VA = "0x184269420")]
	public MABMMFKBDJD(OPDGHHKHELB<PAPHDIKDLEF<TItemId>, TResult> FBJPFAKODCH, TimeSpan HKELKPANOCK, bool BNCMEMMKPHB, [Optional] NEKMDFKADJO AFLJLBFNLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x49B4120", Offset = "0x49B3520", VA = "0x1849B4120")]
	public Task<TResult> FBLKKENCDJI(TItemId LDCKBFKFIKC, int LCEJFEIPOIC, [Optional] CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PAPHDIKDLEF<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId CDGFBHLKHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int CJLDHCKEHBP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4C454D0", Offset = "0x4C448D0", VA = "0x184C454D0")]
	public PAPHDIKDLEF(TItemId ELHJOOLDFFH, int LCEJFEIPOIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NKJPGCOKMJN<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid FINDPKDPGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> DKOPFBHADKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class BBBIJJGGBBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface CMFKDLKMKIC
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int PEMCPKCGOGE
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool KDDNONEGANG<TParam>(TParam HCPAOILCJCB);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool FMHCJKLDFHE(Exception EAIPGJCIAMN);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool DEDCGKHKCAM();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class BJOGHLDGAIF<TResult> : CMFKDLKMKIC, NKJPGCOKMJN<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> NOJOJIMAJMM;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid FINDPKDPGJA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB5FC10", Offset = "0xB5F010", VA = "0x180B5FC10", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int PEMCPKCGOGE
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x968260", Offset = "0x967660", VA = "0x180968260", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> DKOPFBHADKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4A501D0", Offset = "0x4A4F5D0", VA = "0x184A501D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x53D85F0", Offset = "0x53D79F0", VA = "0x1853D85F0")]
		public BJOGHLDGAIF(int LMJPFOJBOKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2F64680", Offset = "0x2F63A80", VA = "0x182F64680", Slot = "5")]
		public bool KDDNONEGANG<TParam>(TParam HCPAOILCJCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x53D8590", Offset = "0x53D7990", VA = "0x1853D8590", Slot = "6")]
		public bool FMHCJKLDFHE(Exception EAIPGJCIAMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x53D8530", Offset = "0x53D7930", VA = "0x1853D8530", Slot = "7")]
		public bool DEDCGKHKCAM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string PLLBBGDNLFI = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, CMFKDLKMKIC> ABOMHMNPEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly IHDJIOFBCPO IIKAIBEBFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool AAJAECDKNBF;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x76D9850", Offset = "0x76D8C50", VA = "0x1876D9850")]
	public BBBIJJGGBBI([Optional] IHDJIOFBCPO IIKAIBEBFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x76D9140", Offset = "0x76D8540", VA = "0x1876D9140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2DBC820", Offset = "0x2DBBC20", VA = "0x182DBC820")]
	public NKJPGCOKMJN<TResult> OKLHHPDAKIC<TResult>(int IFBDBIHOCPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2DBC4C0", Offset = "0x2DBB8C0", VA = "0x182DBC4C0")]
	public bool LJAFMDOLAGE<TResult>(Guid NDFJMJHNPGE, TResult CEDDFJCBLGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x76D9250", Offset = "0x76D8650", VA = "0x1876D9250")]
	private void ELCHBMKIENM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x76D9140", Offset = "0x76D8540", VA = "0x1876D9140")]
	private void NLDFFKNONAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x76D9370", Offset = "0x76D8770", VA = "0x1876D9370")]
	private void FNEIGGOEIOG(int LMJPFOJBOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x76D9650", Offset = "0x76D8A50", VA = "0x1876D9650")]
	private void KDFNJKCMOON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum AAPPKJHALBA
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class FPFECNCKIKN<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class OANFGEBHABF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int CBOEIIPACAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int OJNAIJAFNPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int ECLDEONJIBK;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public OANFGEBHABF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId CDGFBHLKHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int CJLDHCKEHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public AAPPKJHALBA JHDJBKJIAHC;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1828F60", Offset = "0x1828360", VA = "0x181828F60")]
	public FPFECNCKIKN(TItemId ELHJOOLDFFH, int LCEJFEIPOIC, AAPPKJHALBA MAPPNBHJLPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ILENILJBCBN<TItemId, TResult> : IDLKFBINGDK<FPFECNCKIKN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4356BF0", Offset = "0x4355FF0", VA = "0x184356BF0")]
	public ILENILJBCBN(OPDGHHKHELB<FPFECNCKIKN<TItemId>, TResult> FBJPFAKODCH, TimeSpan HKELKPANOCK, [Optional] NEKMDFKADJO AFLJLBFNLCH)
	{
	}
}
namespace Cpp2IlInjected
{
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
}

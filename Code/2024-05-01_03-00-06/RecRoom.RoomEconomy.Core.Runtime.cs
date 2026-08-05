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
public interface AOFNCBMIBPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HCPONCIFCLA(int MEGBHEKGAMH, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HCPONCIFCLA(TimeSpan NGHIHNBLMHK, CancellationToken KANPDHELHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FEILCFOIBAP : AOFNCBMIBPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68006D0", Offset = "0x67FF4D0", VA = "0x1868006D0")]
	[DPHBJKOLDBD(FMOBJKPMAGC.Root, OHNOEEJKPCM.GameOnly)]
	private static void NBDEHFOJALI(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	[Preserve]
	public FEILCFOIBAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6800670", Offset = "0x67FF470", VA = "0x186800670", Slot = "4")]
	public Task HCPONCIFCLA(int MEGBHEKGAMH, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6800610", Offset = "0x67FF410", VA = "0x186800610", Slot = "5")]
	public Task HCPONCIFCLA(TimeSpan NGHIHNBLMHK, CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BPBBBCEJIKL<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct CFBEKHLBAEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest NBOINLJJAOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> OPINGIHMNKC;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x93C520", Offset = "0x93B320", VA = "0x18093C520")]
		public CFBEKHLBAEA(TRequest AIAKOJMKOGA, TaskCompletionSource<TResult> KBJNIEAGNFI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct FMBGBLGCKBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public BPBBBCEJIKL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3858D20", Offset = "0x3857B20", VA = "0x183858D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3859220", Offset = "0x3858020", VA = "0x183859220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct ENLCKCPOMDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public BPBBBCEJIKL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x34C3930", Offset = "0x34C2730", VA = "0x1834C3930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x34C3CF0", Offset = "0x34C2AF0", VA = "0x1834C3CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LPPKHBMFNLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public BPBBBCEJIKL<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3DCFDF0", Offset = "0x3DCEBF0", VA = "0x183DCFDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3DD0280", Offset = "0x3DCF080", VA = "0x183DD0280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct PKJEFDCHFCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public BPBBBCEJIKL<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x41D9450", Offset = "0x41D8250", VA = "0x1841D9450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x41DA2D0", Offset = "0x41D90D0", VA = "0x1841DA2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly PCPPEJMGFBE<TRequest, TResult> GMAHHILJNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float PLAPJDKBJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AOFNCBMIBPJ OHJHFJBELFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<CFBEKHLBAEA> JEHIOEKEDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource BKOOIEKAKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource BJILJHIINLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task CKFOKDIMLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float LDECMHHLMKE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BOHPGLCBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAF4FF0", Offset = "0xAF3DF0", VA = "0x180AF4FF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAF4C70", Offset = "0xAF3A70", VA = "0x180AF4C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x49725F0", Offset = "0x49713F0", VA = "0x1849725F0")]
	public BPBBBCEJIKL(PCPPEJMGFBE<TRequest, TResult> GMAHHILJNKC, TimeSpan PLAPJDKBJJI, [Optional] AOFNCBMIBPJ OHJHFJBELFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4971E70", Offset = "0x4970C70", VA = "0x184971E70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4971D50", Offset = "0x4970B50", VA = "0x184971D50")]
	[AsyncStateMachine(typeof(BPBBBCEJIKL<, >.FMBGBLGCKBP))]
	public Task<TResult> DCMLIFLDGPC(TRequest AIAKOJMKOGA, [Optional] CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x49720F0", Offset = "0x4970EF0", VA = "0x1849720F0")]
	public Task HNBMPMANLBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4972520", Offset = "0x4971320", VA = "0x184972520")]
	[AsyncStateMachine(typeof(BPBBBCEJIKL<, >.ENLCKCPOMDH))]
	private Task PFLEHIKGIDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4971C30", Offset = "0x4970A30", VA = "0x184971C30")]
	[AsyncStateMachine(typeof(BPBBBCEJIKL<, >.LPPKHBMFNLJ))]
	private Task DAMJCICBFEP(CancellationToken FHGKOLGALCL, CancellationToken NHBEBGHBEBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4972420", Offset = "0x4971220", VA = "0x184972420")]
	[AsyncStateMachine(typeof(BPBBBCEJIKL<, >.PKJEFDCHFCP))]
	private Task OOKPILBPIND(CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4972350", Offset = "0x4971150", VA = "0x184972350")]
	private TimeSpan OKFCHHPAJEL()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x49721B0", Offset = "0x4970FB0", VA = "0x1849721B0")]
	private Task<List<TResult>> JCCFIFPFNBK(IReadOnlyList<TRequest> KKEKLKFCIAO, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x49722B0", Offset = "0x49710B0", VA = "0x1849722B0")]
	private float LFNBNBBCEIA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4972060", Offset = "0x4970E60", VA = "0x184972060")]
	private void GMCCLHJIGAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NMGONNPNHDA<TItemId, TResult> : PCPPEJMGFBE<JDALCJGAJNO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> LGECLNJDEPF(Dictionary<TItemId, int> KKEKLKFCIAO, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MJJGBFAMGAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public MJJGBFAMGAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3FA58C0", Offset = "0x3FA46C0", VA = "0x183FA58C0")]
		internal TResult NGHCGDGGJOC(JDALCJGAJNO<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PIKEDEOJJFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<JDALCJGAJNO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NMGONNPNHDA<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private MJJGBFAMGAP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x41CDE70", Offset = "0x41CCC70", VA = "0x1841CDE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x41CEAF0", Offset = "0x41CD8F0", VA = "0x1841CEAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly LGECLNJDEPF NAPIKCMNIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> PDBOAJNGLNM;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x39E2490", Offset = "0x39E1290", VA = "0x1839E2490")]
	public NMGONNPNHDA(LGECLNJDEPF NAPIKCMNIIH, [Optional] IEqualityComparer<TItemId> PDBOAJNGLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x40484D0", Offset = "0x40472D0", VA = "0x1840484D0", Slot = "4")]
	[AsyncStateMachine(typeof(NMGONNPNHDA<, >.PIKEDEOJJFC))]
	public Task<List<TResult>> JAAEGBDLCNF(IReadOnlyList<JDALCJGAJNO<TItemId>> KKEKLKFCIAO, CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HPNHOPHEHJB<TRequest, TResult> : PCPPEJMGFBE<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> FIGGGGPINEF(IEnumerable<TRequest> KAPKOHJBFBG, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class DHCMMHBMEBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public DHCMMHBMEBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3852B80", Offset = "0x3851980", VA = "0x183852B80")]
		internal TResult NGHCGDGGJOC(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct HFHNCPIPPCC : IAsyncStateMachine
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
		public HPNHOPHEHJB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private DHCMMHBMEBC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x39BA810", Offset = "0x39B9610", VA = "0x1839BA810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x39BB560", Offset = "0x39BA360", VA = "0x1839BB560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FIGGGGPINEF NAPIKCMNIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> PDBOAJNGLNM;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x39E2490", Offset = "0x39E1290", VA = "0x1839E2490")]
	public HPNHOPHEHJB(FIGGGGPINEF NAPIKCMNIIH, [Optional] IEqualityComparer<TRequest> PDBOAJNGLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x39E2350", Offset = "0x39E1150", VA = "0x1839E2350", Slot = "4")]
	[AsyncStateMachine(typeof(HPNHOPHEHJB<, >.HFHNCPIPPCC))]
	public Task<List<TResult>> JAAEGBDLCNF(IReadOnlyList<TRequest> KKEKLKFCIAO, CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PCPPEJMGFBE<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> JAAEGBDLCNF(IReadOnlyList<TRequest> KKEKLKFCIAO, CancellationToken KANPDHELHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LOFLFCMMPHO<TItemId, TResult> : PCPPEJMGFBE<MLMAHKBJBIP<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task DBLMMHLBKAD(IReadOnlyDictionary<TItemId, MLMAHKBJBIP<TItemId>.GLKDMEHANBH> KKEKLKFCIAO, CancellationToken KANPDHELHMD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct MLGCIMJKLGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public LOFLFCMMPHO<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<MLMAHKBJBIP<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3FA9950", Offset = "0x3FA8750", VA = "0x183FA9950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3FA9E40", Offset = "0x3FA8C40", VA = "0x183FA9E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly DBLMMHLBKAD DMJIDCPCMIP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public LOFLFCMMPHO(DBLMMHLBKAD DMJIDCPCMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3DCCFB0", Offset = "0x3DCBDB0", VA = "0x183DCCFB0", Slot = "4")]
	[AsyncStateMachine(typeof(LOFLFCMMPHO<, >.MLGCIMJKLGK))]
	public Task<List<object>> JAAEGBDLCNF(IReadOnlyList<MLMAHKBJBIP<TItemId>> KKEKLKFCIAO, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD0F0", Offset = "0x3DCBEF0", VA = "0x183DCD0F0")]
	private IReadOnlyDictionary<TItemId, MLMAHKBJBIP<TItemId>.GLKDMEHANBH> MHFIDAKEOLN(IReadOnlyList<MLMAHKBJBIP<TItemId>> CLACHEEPCFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PFLAHBAJBJM<TItemId, TResult> : PCPPEJMGFBE<JDALCJGAJNO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> MMGOAIOEGBL(Dictionary<TItemId, int> KKEKLKFCIAO, CancellationToken KANPDHELHMD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct DGLNEIHCMHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<JDALCJGAJNO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public PFLAHBAJBJM<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5145330", Offset = "0x5144130", VA = "0x185145330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5146B30", Offset = "0x5145930", VA = "0x185146B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly MMGOAIOEGBL DAGAGDKPCNF;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public PFLAHBAJBJM(MMGOAIOEGBL NAPIKCMNIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x41CCC30", Offset = "0x41CBA30", VA = "0x1841CCC30", Slot = "4")]
	[AsyncStateMachine(typeof(PFLAHBAJBJM<, >.DGLNEIHCMHE))]
	public Task<List<TResult>> JAAEGBDLCNF(IReadOnlyList<JDALCJGAJNO<TItemId>> KKEKLKFCIAO, CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ILBOMOMJKHG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, OKBDKGKGGJB> MANFHAMNBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> MJKNPDFEPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> JGLEFMNEHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> COKJEIOHGMO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, OKBDKGKGGJB> DNJHKGJFKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> ODCADDGOHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MPFANLNCAAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9592D0", Offset = "0x9580D0", VA = "0x1809592D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9592C0", Offset = "0x9580C0", VA = "0x1809592C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3A8E8C0", Offset = "0x3A8D6C0", VA = "0x183A8E8C0")]
	public ILBOMOMJKHG(Func<IEnumerable<T>> JGLEFMNEHIA, Func<T, string> COKJEIOHGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A8E670", Offset = "0x3A8D470", VA = "0x183A8E670")]
	public void PHAFDIODDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3A8E600", Offset = "0x3A8D400", VA = "0x183A8E600", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AOCOBFANIPN<TItemId, TResult> : BPBBBCEJIKL<JDALCJGAJNO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x384CDC0", Offset = "0x384BBC0", VA = "0x18384CDC0")]
	public AOCOBFANIPN(PCPPEJMGFBE<JDALCJGAJNO<TItemId>, TResult> GMAHHILJNKC, TimeSpan PLAPJDKBJJI, [Optional] AOFNCBMIBPJ OHJHFJBELFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x39235A0", Offset = "0x39223A0", VA = "0x1839235A0")]
	public Task<TResult> DCMLIFLDGPC(TItemId OBPLDLNDJLE, int KMDAINAHNDF, [Optional] CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JDALCJGAJNO<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId JNBDPJJKHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int MGNNGCJPKCM;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E3E0", Offset = "0x3C1D1E0", VA = "0x183C1E3E0")]
	public JDALCJGAJNO(TItemId BCKNCOPEFEP, int KMDAINAHNDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HPCAFGJCMOA<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid MDALPHBHGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> LNMIECNLLBI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class PAHLMGMBNCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface BDOPHLMGOMH
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int OOBLEHNKEOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool KJNPENMIOCL<TParam>(TParam DIBNBLEEFNN);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool GOEPDDAEENJ(Exception CCDENENMPHG);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool LLFHCFIMCCL();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class GAOILEPJODP<TResult> : BDOPHLMGOMH, HPCAFGJCMOA<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> FFLBEEOPLEK;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid MDALPHBHGGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x83F660", Offset = "0x83E460", VA = "0x18083F660", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int OOBLEHNKEOF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9592D0", Offset = "0x9580D0", VA = "0x1809592D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> LNMIECNLLBI
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x38F7900", Offset = "0x38F6700", VA = "0x1838F7900", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x38F79C0", Offset = "0x38F67C0", VA = "0x1838F79C0")]
		public GAOILEPJODP(int FDNGFGJCHLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x27CEC90", Offset = "0x27CDA90", VA = "0x1827CEC90", Slot = "5")]
		public bool KJNPENMIOCL<TParam>(TParam DIBNBLEEFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x38F7940", Offset = "0x38F6740", VA = "0x1838F7940", Slot = "6")]
		public bool GOEPDDAEENJ(Exception CCDENENMPHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x38F7980", Offset = "0x38F6780", VA = "0x1838F7980", Slot = "7")]
		public bool LLFHCFIMCCL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string KGBEGFIFLJH = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, BDOPHLMGOMH> DCBFELPHCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly DBMGOHMBBIK OOJCDEKMHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool OBNBLBPGOKI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6800ED0", Offset = "0x67FFCD0", VA = "0x186800ED0")]
	public PAHLMGMBNCH([Optional] DBMGOHMBBIK OOJCDEKMHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x68007C0", Offset = "0x67FF5C0", VA = "0x1868007C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2A46030", Offset = "0x2A44E30", VA = "0x182A46030")]
	public HPCAFGJCMOA<TResult> BIHDAADIGCP<TResult>(int OIECFLNMAHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2A462D0", Offset = "0x2A450D0", VA = "0x182A462D0")]
	public bool JMBHKGEDKBJ<TResult>(Guid GJAFHBAGEBC, TResult FJMMLPMLLGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6800DB0", Offset = "0x67FFBB0", VA = "0x186800DB0")]
	private void HKOLAFOBDNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68007C0", Offset = "0x67FF5C0", VA = "0x1868007C0")]
	private void IFLECFDFBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x68008D0", Offset = "0x67FF6D0", VA = "0x1868008D0")]
	private void EMGBJLBNING(int FDNGFGJCHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6800BB0", Offset = "0x67FF9B0", VA = "0x186800BB0")]
	private void HCAOHANBNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum JOBCMCMJGIG
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MLMAHKBJBIP<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class GLKDMEHANBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int AJBJOGILIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int LLHJGIOPKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int MBMFKEDJANO;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public GLKDMEHANBH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId JNBDPJJKHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int MGNNGCJPKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public JOBCMCMJGIG NNOBEFNKPLH;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xEE32E0", Offset = "0xEE20E0", VA = "0x180EE32E0")]
	public MLMAHKBJBIP(TItemId BCKNCOPEFEP, int KMDAINAHNDF, JOBCMCMJGIG PFNKIIMPMKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MGOHCHHFCGJ<TItemId, TResult> : BPBBBCEJIKL<MLMAHKBJBIP<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x384CDC0", Offset = "0x384BBC0", VA = "0x18384CDC0")]
	public MGOHCHHFCGJ(PCPPEJMGFBE<MLMAHKBJBIP<TItemId>, TResult> GMAHHILJNKC, TimeSpan PLAPJDKBJJI, [Optional] AOFNCBMIBPJ OHJHFJBELFD)
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

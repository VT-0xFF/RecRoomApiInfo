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
public interface PKLBFIOCMNH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CHKCDBBGDJA(int PBEMGDFFBID, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CHKCDBBGDJA(TimeSpan DKJBEGPBCGN, CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IIOACGMFAFD : PKLBFIOCMNH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D602C0", Offset = "0x7D5F4C0", VA = "0x187D602C0")]
	[LDKBBAENJDF.JPBGCAANJAC.KOPKNLHMHAB]
	internal static void LMOFFJNLCLN(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IIOACGMFAFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D60260", Offset = "0x7D5F460", VA = "0x187D60260", Slot = "4")]
	public Task CHKCDBBGDJA(int PBEMGDFFBID, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D60200", Offset = "0x7D5F400", VA = "0x187D60200", Slot = "5")]
	public Task CHKCDBBGDJA(TimeSpan DKJBEGPBCGN, CancellationToken KPIINMODKFJ)
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
		[Cpp2IlInjected.Address(RVA = "0x7D603C0", Offset = "0x7D5F5C0", VA = "0x187D603C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EKNNGLPMEOF<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct KBMAIKKGJGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest EKNBGGCCKDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> BCJDIHFDJDL;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9E2EE0", Offset = "0x9E20E0", VA = "0x1809E2EE0")]
		public KBMAIKKGJGJ(TRequest NKJDMJIDCOG, TaskCompletionSource<TResult> LEGMNCHIOIB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct JNMOOMLHMIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EKNNGLPMEOF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x498F470", Offset = "0x498E670", VA = "0x18498F470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x460FA20", Offset = "0x460EC20", VA = "0x18460FA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JKFFILAAIMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public EKNNGLPMEOF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x498B5E0", Offset = "0x498A7E0", VA = "0x18498B5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x498B9C0", Offset = "0x498ABC0", VA = "0x18498B9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct LLGPOEHEPCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EKNNGLPMEOF<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4B89690", Offset = "0x4B88890", VA = "0x184B89690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4B89B40", Offset = "0x4B88D40", VA = "0x184B89B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct CJBICCIAHJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public EKNNGLPMEOF<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5CD8040", Offset = "0x5CD7240", VA = "0x185CD8040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5CD91C0", Offset = "0x5CD83C0", VA = "0x185CD91C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HILEBGGNNOP<TRequest, TResult> NHMEHBABPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float FACBFLNMDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PKLBFIOCMNH JPEFMFKFLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool OMKDMMCGAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<KBMAIKKGJGJ> MCFEBKCAIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<KBMAIKKGJGJ> BMGILAOJANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool MHKOFFHDJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource PENNDCLPPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource LDGJOHGNGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task DOPKACPALDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float BODKDEHGAAL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HMMGIGDCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x96A6F0", Offset = "0x9698F0", VA = "0x18096A6F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x96A6A0", Offset = "0x9698A0", VA = "0x18096A6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4112F70", Offset = "0x4112170", VA = "0x184112F70")]
	public EKNNGLPMEOF(HILEBGGNNOP<TRequest, TResult> NHMEHBABPLG, TimeSpan FACBFLNMDFO, bool OMKDMMCGAEA, [Optional] PKLBFIOCMNH JPEFMFKFLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x41125A0", Offset = "0x41117A0", VA = "0x1841125A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x41129D0", Offset = "0x4111BD0", VA = "0x1841129D0")]
	[AsyncStateMachine(typeof(EKNNGLPMEOF<, >.JNMOOMLHMIM))]
	public Task<TResult> IGGODMHEBDE(TRequest NKJDMJIDCOG, [Optional] CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4112AF0", Offset = "0x4111CF0", VA = "0x184112AF0")]
	private void IGGODMHEBDE(TRequest NKJDMJIDCOG, TaskCompletionSource<TResult> LEGMNCHIOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4112B90", Offset = "0x4111D90", VA = "0x184112B90")]
	public Task LFKBLKPIIFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x41127E0", Offset = "0x41119E0", VA = "0x1841127E0")]
	[AsyncStateMachine(typeof(EKNNGLPMEOF<, >.JKFFILAAIMH))]
	private Task FOMLECFOIFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4112480", Offset = "0x4111680", VA = "0x184112480")]
	[AsyncStateMachine(typeof(EKNNGLPMEOF<, >.LLGPOEHEPCO))]
	private Task CBPECKGLCPL(CancellationToken LNPJPMPMNJA, CancellationToken OGJPDHPBEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4112C50", Offset = "0x4111E50", VA = "0x184112C50")]
	[AsyncStateMachine(typeof(EKNNGLPMEOF<, >.CJBICCIAHJP))]
	private Task MHKKNCDPFMM(CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4112E90", Offset = "0x4112090", VA = "0x184112E90")]
	private TimeSpan PBMDINGMPHM()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x41128B0", Offset = "0x4111AB0", VA = "0x1841128B0")]
	private Task<List<TResult>> HCIIAACNFOM(IReadOnlyList<TRequest> AKOIIABFCJD, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4112D50", Offset = "0x4111F50", VA = "0x184112D50")]
	private float OFFOHMMGIJO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4112DF0", Offset = "0x4111FF0", VA = "0x184112DF0")]
	private void PBKBJCFPGLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FNAAFBHPHGP<TItemId, TResult> : HILEBGGNNOP<PDHHHLMODIM<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> EFLIPADKMLD(Dictionary<TItemId, int> AKOIIABFCJD, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class HJMMHGALPIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HJMMHGALPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x46B2FC0", Offset = "0x46B21C0", VA = "0x1846B2FC0")]
		internal TResult FOLHOPCBKDG(PDHHHLMODIM<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MOCLGBBCENI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<PDHHHLMODIM<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public FNAAFBHPHGP<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private HJMMHGALPIJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4DB5B30", Offset = "0x4DB4D30", VA = "0x184DB5B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4DB6860", Offset = "0x4DB5A60", VA = "0x184DB6860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly EFLIPADKMLD LMLMCHHKIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> DIHIGKEAOAK;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4545BF0", Offset = "0x4544DF0", VA = "0x184545BF0")]
	public FNAAFBHPHGP(EFLIPADKMLD LMLMCHHKIPG, [Optional] IEqualityComparer<TItemId> DIHIGKEAOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4545AA0", Offset = "0x4544CA0", VA = "0x184545AA0", Slot = "4")]
	[AsyncStateMachine(typeof(FNAAFBHPHGP<, >.MOCLGBBCENI))]
	public Task<List<TResult>> HDGLDLGKBGJ(IReadOnlyList<PDHHHLMODIM<TItemId>> AKOIIABFCJD, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DOPBHNBLIHF<TRequest, TResult> : HILEBGGNNOP<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> NECEIKMDPFD(IEnumerable<TRequest> MBFDDBFFCNM, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PJIABFDBHAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public PJIABFDBHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x44A56F0", Offset = "0x44A48F0", VA = "0x1844A56F0")]
		internal TResult FOLHOPCBKDG(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct DINGJCAEGHJ : IAsyncStateMachine
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
		public DOPBHNBLIHF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private PJIABFDBHAJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x63DF9F0", Offset = "0x63DEBF0", VA = "0x1863DF9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x63E0820", Offset = "0x63DFA20", VA = "0x1863E0820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NECEIKMDPFD LMLMCHHKIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> DIHIGKEAOAK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4545BF0", Offset = "0x4544DF0", VA = "0x184545BF0")]
	public DOPBHNBLIHF(NECEIKMDPFD LMLMCHHKIPG, [Optional] IEqualityComparer<TRequest> DIHIGKEAOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x63EED00", Offset = "0x63EDF00", VA = "0x1863EED00", Slot = "4")]
	[AsyncStateMachine(typeof(DOPBHNBLIHF<, >.DINGJCAEGHJ))]
	public Task<List<TResult>> HDGLDLGKBGJ(IReadOnlyList<TRequest> AKOIIABFCJD, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HILEBGGNNOP<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> HDGLDLGKBGJ(IReadOnlyList<TRequest> AKOIIABFCJD, CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LIMHELLIDGG<TItemId, TResult> : HILEBGGNNOP<HNNKONOKNJI<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task DDPAIHHGFFP(IReadOnlyDictionary<TItemId, HNNKONOKNJI<TItemId>.ADJIMPHPKHM> AKOIIABFCJD, CancellationToken KPIINMODKFJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct LJGLCFPDBFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LIMHELLIDGG<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<HNNKONOKNJI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4B82DC0", Offset = "0x4B81FC0", VA = "0x184B82DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4B83300", Offset = "0x4B82500", VA = "0x184B83300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly DDPAIHHGFFP JEGALHNGHHG;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	public LIMHELLIDGG(DDPAIHHGFFP JEGALHNGHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4B81F30", Offset = "0x4B81130", VA = "0x184B81F30", Slot = "4")]
	[AsyncStateMachine(typeof(LIMHELLIDGG<, >.LJGLCFPDBFK))]
	public Task<List<object>> HDGLDLGKBGJ(IReadOnlyList<HNNKONOKNJI<TItemId>> AKOIIABFCJD, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4B81AB0", Offset = "0x4B80CB0", VA = "0x184B81AB0")]
	private IReadOnlyDictionary<TItemId, HNNKONOKNJI<TItemId>.ADJIMPHPKHM> CDDFOPIHCHF(IReadOnlyList<HNNKONOKNJI<TItemId>> PJOMBFICEKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CHBDALNBKLP<TItemId, TResult> : HILEBGGNNOP<PDHHHLMODIM<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> FIKHOGODHNA(Dictionary<TItemId, int> AKOIIABFCJD, CancellationToken KPIINMODKFJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct IDMCNIMEIMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<PDHHHLMODIM<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CHBDALNBKLP<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x476EA20", Offset = "0x476DC20", VA = "0x18476EA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4770360", Offset = "0x476F560", VA = "0x184770360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly FIKHOGODHNA PDJMHCAPMFN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	public CHBDALNBKLP(FIKHOGODHNA LMLMCHHKIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5AE7450", Offset = "0x5AE6650", VA = "0x185AE7450", Slot = "4")]
	[AsyncStateMachine(typeof(CHBDALNBKLP<, >.IDMCNIMEIMP))]
	public Task<List<TResult>> HDGLDLGKBGJ(IReadOnlyList<PDHHHLMODIM<TItemId>> AKOIIABFCJD, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GICMLOJEAHP<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, LGFGNMFJLDG> OPHCGHOADAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> IOHHFDOMNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> HDKHHIOCCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> AJLGEMJLGKG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, LGFGNMFJLDG> FLMEOPNBNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> DBIBKNLCIKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EECAMBDDDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAE2F30", Offset = "0xAE2130", VA = "0x180AE2F30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xB96CB0", Offset = "0xB95EB0", VA = "0x180B96CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x460BB10", Offset = "0x460AD10", VA = "0x18460BB10")]
	public GICMLOJEAHP(Func<IEnumerable<T>> HDKHHIOCCDJ, Func<T, string> AJLGEMJLGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x460B7E0", Offset = "0x460A9E0", VA = "0x18460B7E0")]
	public void DJHAIOPCIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x460BA80", Offset = "0x460AC80", VA = "0x18460BA80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EHADJJALAAA<TItemId, TResult> : EKNNGLPMEOF<PDHHHLMODIM<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x40E7060", Offset = "0x40E6260", VA = "0x1840E7060")]
	public EHADJJALAAA(HILEBGGNNOP<PDHHHLMODIM<TItemId>, TResult> NHMEHBABPLG, TimeSpan FACBFLNMDFO, bool OMKDMMCGAEA, [Optional] PKLBFIOCMNH JPEFMFKFLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x40E6D50", Offset = "0x40E5F50", VA = "0x1840E6D50")]
	public Task<TResult> IGGODMHEBDE(TItemId MBDBONINAPC, int NFLFPJLJGMO, [Optional] CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PDHHHLMODIM<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId EDDBLFJBDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int NIBMMIAOCLI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x50BC800", Offset = "0x50BBA00", VA = "0x1850BC800")]
	public PDHHHLMODIM(TItemId BJDEDKEAADM, int NFLFPJLJGMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NIKFNJIBHDH<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid LGGPFCEDJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> IGAMNIAMKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class CEHEJJIJOPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface LDCJDEJNHFB
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int JGCFDFLGFMN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MLMNIGPLDBL<TParam>(TParam OMFJNFBDJCA);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool BNPNKFNCGEJ(Exception OLLOHIKPLMG);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool CECLFKJILFK();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class ENLHEKDEDGN<TResult> : LDCJDEJNHFB, NIKFNJIBHDH<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> ABHKCMFILHN;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid LGGPFCEDJMG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB45CB0", Offset = "0xB44EB0", VA = "0x180B45CB0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int JGCFDFLGFMN
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAE2F30", Offset = "0xAE2130", VA = "0x180AE2F30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> IGAMNIAMKOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x411E170", Offset = "0x411D370", VA = "0x18411E170", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x411E1C0", Offset = "0x411D3C0", VA = "0x18411E1C0")]
		public ENLHEKDEDGN(int BCJENMAMLPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x36D1D60", Offset = "0x36D0F60", VA = "0x1836D1D60", Slot = "5")]
		public bool MLMNIGPLDBL<TParam>(TParam OMFJNFBDJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x411E0D0", Offset = "0x411D2D0", VA = "0x18411E0D0", Slot = "6")]
		public bool BNPNKFNCGEJ(Exception OLLOHIKPLMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x411E120", Offset = "0x411D320", VA = "0x18411E120", Slot = "7")]
		public bool CECLFKJILFK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string IALLLOBFHOM = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, LDCJDEJNHFB> OGCBDIHHBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly OCEHBNKGHFP PCFBKEENPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool NDFFONELGAL;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7D60100", Offset = "0x7D5F300", VA = "0x187D60100")]
	public CEHEJJIJOPP([Optional] OCEHBNKGHFP PCFBKEENPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7D5FDF0", Offset = "0x7D5EFF0", VA = "0x187D5FDF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3266330", Offset = "0x3265530", VA = "0x183266330")]
	public NIKFNJIBHDH<TResult> BKHANAFBHFC<TResult>(int NGABMNCGOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3266630", Offset = "0x3265830", VA = "0x183266630")]
	public bool FLJPHANAMKA<TResult>(Guid LDHEJEOPGBF, TResult CMLOHOMLNDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7D5FCD0", Offset = "0x7D5EED0", VA = "0x187D5FCD0")]
	private void DNKMOCHOBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7D5FDF0", Offset = "0x7D5EFF0", VA = "0x187D5FDF0")]
	private void NHJIDJIEKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7D5F9F0", Offset = "0x7D5EBF0", VA = "0x187D5F9F0")]
	private void AAOGGPAABCJ(int BCJENMAMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7D5FF00", Offset = "0x7D5F100", VA = "0x187D5FF00")]
	private void GIALHOJKHKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum NPMKFLJAHHN
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HNNKONOKNJI<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ADJIMPHPKHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int KJHJPDIHANG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int MBPLNCLBBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int FMAHPLJHKKJ;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public ADJIMPHPKHM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId EDDBLFJBDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int NIBMMIAOCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NPMKFLJAHHN NIMLJIMFMEG;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1C8BA10", Offset = "0x1C8AC10", VA = "0x181C8BA10")]
	public HNNKONOKNJI(TItemId BJDEDKEAADM, int NFLFPJLJGMO, NPMKFLJAHHN DPCGKOGCCDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class BBANNDJCEMB<TItemId, TResult> : EKNNGLPMEOF<HNNKONOKNJI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5895D30", Offset = "0x5894F30", VA = "0x185895D30")]
	public BBANNDJCEMB(HILEBGGNNOP<HNNKONOKNJI<TItemId>, TResult> NHMEHBABPLG, TimeSpan FACBFLNMDFO, [Optional] PKLBFIOCMNH JPEFMFKFLJI)
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

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
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CDGHNLHMECN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KCGEMKJLCNP(int BDDEENPFHIG, CancellationToken GBOOEEMCFEA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KCGEMKJLCNP(TimeSpan EAIHMAEIJMO, CancellationToken GBOOEEMCFEA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NELELFGPOEB : CDGHNLHMECN
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x73FD900", Offset = "0x73FCD00", VA = "0x1873FD900")]
	[GOEIKLHOLGG.KCHBNNLNADK.IBDMBHIFIDC]
	internal static void DJNFEGBLBOB(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	[RecRoom.NoEngine.Common.Preserve]
	public NELELFGPOEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x73FDA50", Offset = "0x73FCE50", VA = "0x1873FDA50", Slot = "4")]
	public Task KCGEMKJLCNP(int BDDEENPFHIG, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x73FD9F0", Offset = "0x73FCDF0", VA = "0x1873FD9F0", Slot = "5")]
	public Task KCGEMKJLCNP(TimeSpan EAIHMAEIJMO, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x73FDAB0", Offset = "0x73FCEB0", VA = "0x1873FDAB0", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OJDLLHGHHHI<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct KMCGNFBPIIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest DLKAHCIPCOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> KIHDJPEPJFE;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xDEC7B0", Offset = "0xDEBBB0", VA = "0x180DEC7B0")]
		public KMCGNFBPIIC(TRequest OPBNONPHAEF, TaskCompletionSource<TResult> PKEIDCHDBJM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct PFGAPDOLHPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public OJDLLHGHHHI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4B2BA90", Offset = "0x4B2AE90", VA = "0x184B2BA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4213210", Offset = "0x4212610", VA = "0x184213210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct PGGKIPFGNHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public OJDLLHGHHHI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4B2E190", Offset = "0x4B2D590", VA = "0x184B2E190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4B2E570", Offset = "0x4B2D970", VA = "0x184B2E570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct BGKEDGJDODI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public OJDLLHGHHHI<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x52313B0", Offset = "0x52307B0", VA = "0x1852313B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5231860", Offset = "0x5230C60", VA = "0x185231860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct BNBMHKHCPGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public OJDLLHGHHHI<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x526E250", Offset = "0x526D650", VA = "0x18526E250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x526F400", Offset = "0x526E800", VA = "0x18526F400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IOKLEELHCBI<TRequest, TResult> ILBEPFIAAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float GCFPKGADMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CDGHNLHMECN PFPGPFBOMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool MIBPKEEEEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<KMCGNFBPIIC> MDPNGIJKCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<KMCGNFBPIIC> BFKNCNOCMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool IGEFFIAKMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource FIFPKJBFENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource EGFNIPCEIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task PJJDAHANBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float BAIFJPMPNPO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DCPGEINIIPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E50", Offset = "0x8A1250", VA = "0x1808A1E50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F80", Offset = "0x8A1380", VA = "0x1808A1F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4A63630", Offset = "0x4A62A30", VA = "0x184A63630")]
	public OJDLLHGHHHI(IOKLEELHCBI<TRequest, TResult> ILBEPFIAAAF, TimeSpan GCFPKGADMLN, bool MIBPKEEEEDM, [Optional] CDGHNLHMECN PFPGPFBOMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4A62D80", Offset = "0x4A62180", VA = "0x184A62D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4A62FC0", Offset = "0x4A623C0", VA = "0x184A62FC0")]
	[AsyncStateMachine(typeof(OJDLLHGHHHI<, >.PFGAPDOLHPO))]
	public Task<TResult> FHMEDIIMFGH(TRequest OPBNONPHAEF, [Optional] CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4A630E0", Offset = "0x4A624E0", VA = "0x184A630E0")]
	private void FHMEDIIMFGH(TRequest OPBNONPHAEF, TaskCompletionSource<TResult> PKEIDCHDBJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4A63570", Offset = "0x4A62970", VA = "0x184A63570")]
	public Task NECIBCDICKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4A634A0", Offset = "0x4A628A0", VA = "0x184A634A0")]
	[AsyncStateMachine(typeof(OJDLLHGHHHI<, >.PGGKIPFGNHM))]
	private Task KAGCIMGICID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4A63260", Offset = "0x4A62660", VA = "0x184A63260")]
	[AsyncStateMachine(typeof(OJDLLHGHHHI<, >.BGKEDGJDODI))]
	private Task IGBBDDGHGFF(CancellationToken HKIILMAGNBJ, CancellationToken LKCBHMCPCAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4A62B40", Offset = "0x4A61F40", VA = "0x184A62B40")]
	[AsyncStateMachine(typeof(OJDLLHGHHHI<, >.BNBMHKHCPGN))]
	private Task ABCCOHMHGEC(CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4A63180", Offset = "0x4A62580", VA = "0x184A63180")]
	private TimeSpan GPDBLKMCBNI()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4A63380", Offset = "0x4A62780", VA = "0x184A63380")]
	private Task<List<TResult>> JELEHLPLMFJ(IReadOnlyList<TRequest> IACNPJNKCPM, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4A62C40", Offset = "0x4A62040", VA = "0x184A62C40")]
	private float DMFODOJHJGH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4A62CE0", Offset = "0x4A620E0", VA = "0x184A62CE0")]
	private void DNOKGDHAPMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NNIPMPKPPOE<TItemId, TResult> : IOKLEELHCBI<LNEFCHHLEAO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> CONJDAPKKKD(Dictionary<TItemId, int> IACNPJNKCPM, CancellationToken GBOOEEMCFEA);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class MJEEINLHIAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public MJEEINLHIAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x48D0860", Offset = "0x48CFC60", VA = "0x1848D0860")]
		internal TResult OCNMGIMIGGN(LNEFCHHLEAO<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct ABPLOBKICGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<LNEFCHHLEAO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public NNIPMPKPPOE<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private MJEEINLHIAN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3FB7D00", Offset = "0x3FB7100", VA = "0x183FB7D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3FB8A60", Offset = "0x3FB7E60", VA = "0x183FB8A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly CONJDAPKKKD APKFAPAEOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> LFBKIIFECDJ;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4969550", Offset = "0x4968950", VA = "0x184969550")]
	public NNIPMPKPPOE(CONJDAPKKKD APKFAPAEOKJ, [Optional] IEqualityComparer<TItemId> LFBKIIFECDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x49692B0", Offset = "0x49686B0", VA = "0x1849692B0", Slot = "4")]
	[AsyncStateMachine(typeof(NNIPMPKPPOE<, >.ABPLOBKICGG))]
	public Task<List<TResult>> CCKINFPAAMM(IReadOnlyList<LNEFCHHLEAO<TItemId>> IACNPJNKCPM, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DBJJINICLAE<TRequest, TResult> : IOKLEELHCBI<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> CFMNKHOKCDK(IEnumerable<TRequest> NHLJAMAIAEP, CancellationToken GBOOEEMCFEA);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class JDJCLDDMGKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public JDJCLDDMGKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3B66E50", Offset = "0x3B66250", VA = "0x183B66E50")]
		internal TResult OCNMGIMIGGN(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LEHEBLFCHDD : IAsyncStateMachine
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
		public DBJJINICLAE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private JDJCLDDMGKA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x45EA300", Offset = "0x45E9700", VA = "0x1845EA300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x45EB160", Offset = "0x45EA560", VA = "0x1845EB160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CFMNKHOKCDK APKFAPAEOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> LFBKIIFECDJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4969550", Offset = "0x4968950", VA = "0x184969550")]
	public DBJJINICLAE(CFMNKHOKCDK APKFAPAEOKJ, [Optional] IEqualityComparer<TRequest> LFBKIIFECDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5BE1CB0", Offset = "0x5BE10B0", VA = "0x185BE1CB0", Slot = "4")]
	[AsyncStateMachine(typeof(DBJJINICLAE<, >.LEHEBLFCHDD))]
	public Task<List<TResult>> CCKINFPAAMM(IReadOnlyList<TRequest> IACNPJNKCPM, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IOKLEELHCBI<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> CCKINFPAAMM(IReadOnlyList<TRequest> IACNPJNKCPM, CancellationToken GBOOEEMCFEA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BMNOAIBCCHA<TItemId, TResult> : IOKLEELHCBI<KAGAEELOHPN<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task JPMAJLCGMMP(IReadOnlyDictionary<TItemId, KAGAEELOHPN<TItemId>.GAIDMJPEAHD> IACNPJNKCPM, CancellationToken GBOOEEMCFEA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct GDPELGMMLFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public BMNOAIBCCHA<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<KAGAEELOHPN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x40080A0", Offset = "0x40074A0", VA = "0x1840080A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4008600", Offset = "0x4007A00", VA = "0x184008600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly JPMAJLCGMMP CHELBGHPICA;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	public BMNOAIBCCHA(JPMAJLCGMMP CHELBGHPICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x526DBE0", Offset = "0x526CFE0", VA = "0x18526DBE0", Slot = "4")]
	[AsyncStateMachine(typeof(BMNOAIBCCHA<, >.GDPELGMMLFF))]
	public Task<List<object>> CCKINFPAAMM(IReadOnlyList<KAGAEELOHPN<TItemId>> IACNPJNKCPM, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x526DD20", Offset = "0x526D120", VA = "0x18526DD20")]
	private IReadOnlyDictionary<TItemId, KAGAEELOHPN<TItemId>.GAIDMJPEAHD> GCIHAAODPCA(IReadOnlyList<KAGAEELOHPN<TItemId>> GCBMCNLLNBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FBLANCAOADJ<TItemId, TResult> : IOKLEELHCBI<LNEFCHHLEAO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> MLFAAOBOOCL(Dictionary<TItemId, int> IACNPJNKCPM, CancellationToken GBOOEEMCFEA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct KHMDKAMGDEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<LNEFCHHLEAO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public FBLANCAOADJ<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x451EB40", Offset = "0x451DF40", VA = "0x18451EB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x451F800", Offset = "0x451EC00", VA = "0x18451F800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly MLFAAOBOOCL IKMEJEGNAPJ;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	public FBLANCAOADJ(MLFAAOBOOCL APKFAPAEOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3F189B0", Offset = "0x3F17DB0", VA = "0x183F189B0", Slot = "4")]
	[AsyncStateMachine(typeof(FBLANCAOADJ<, >.KHMDKAMGDEC))]
	public Task<List<TResult>> CCKINFPAAMM(IReadOnlyList<LNEFCHHLEAO<TItemId>> IACNPJNKCPM, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GGNBLFEIJFB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, LEGPHPNPHAK> KNEKIDJGNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> HELMKHJLFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> KOMDDBNDGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> PKOCJELLCKO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, LEGPHPNPHAK> CAJCAILPPOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> BKEGDEOJOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NAHNECDEDOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9741A0", Offset = "0x9735A0", VA = "0x1809741A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAA25F0", Offset = "0xAA19F0", VA = "0x180AA25F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4047170", Offset = "0x4046570", VA = "0x184047170")]
	public GGNBLFEIJFB(Func<IEnumerable<T>> KOMDDBNDGKP, Func<T, string> PKOCJELLCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4046E20", Offset = "0x4046220", VA = "0x184046E20")]
	public void DPCLJOJLMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x40470E0", Offset = "0x40464E0", VA = "0x1840470E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HOLFNKAJKOO<TItemId, TResult> : OJDLLHGHHHI<LNEFCHHLEAO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x41679E0", Offset = "0x4166DE0", VA = "0x1841679E0")]
	public HOLFNKAJKOO(IOKLEELHCBI<LNEFCHHLEAO<TItemId>, TResult> ILBEPFIAAAF, TimeSpan GCFPKGADMLN, bool MIBPKEEEEDM, [Optional] CDGHNLHMECN PFPGPFBOMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x41676D0", Offset = "0x4166AD0", VA = "0x1841676D0")]
	public Task<TResult> FHMEDIIMFGH(TItemId PBFBBOFLBNL, int LBJJAOIKGCM, [Optional] CancellationToken GBOOEEMCFEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LNEFCHHLEAO<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId FEBMDCCLMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int LNNINHIMIFO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x467BDC0", Offset = "0x467B1C0", VA = "0x18467BDC0")]
	public LNEFCHHLEAO(TItemId FFKILKBDNHG, int LBJJAOIKGCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IMCIBIPEPOC<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid GBFPNIHODLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> AIFPPEDKBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class MBBKNNEPKDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface MHDJLDHNPJI
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int IPDNMFPCCAD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OCDPJCPOOBF<TParam>(TParam PFKKDHPJFEH);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool EIBAOKIJIAC(Exception DACOLACFJMH);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool COGPFEFEPKG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class LLNGFPDNEGA<TResult> : MHDJLDHNPJI, IMCIBIPEPOC<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> AEJJDMNDMNA;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid GBFPNIHODLA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAE8210", Offset = "0xAE7610", VA = "0x180AE8210", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int IPDNMFPCCAD
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9741A0", Offset = "0x9735A0", VA = "0x1809741A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> AIFPPEDKBGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4677D60", Offset = "0x4677160", VA = "0x184677D60", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4677E50", Offset = "0x4677250", VA = "0x184677E50")]
		public LLNGFPDNEGA(int MGHMBGDCEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3069B90", Offset = "0x3068F90", VA = "0x183069B90", Slot = "5")]
		public bool OCDPJCPOOBF<TParam>(TParam PFKKDHPJFEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4677E00", Offset = "0x4677200", VA = "0x184677E00", Slot = "6")]
		public bool EIBAOKIJIAC(Exception DACOLACFJMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4677DB0", Offset = "0x46771B0", VA = "0x184677DB0", Slot = "7")]
		public bool COGPFEFEPKG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string AIEENLOMJFH = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, MHDJLDHNPJI> MICMOCENECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly AALPGBGGJBI KDIPMLMBOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool HIOGDIBADGC;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x73FD800", Offset = "0x73FCC00", VA = "0x1873FD800")]
	public MBBKNNEPKDN([Optional] AALPGBGGJBI KDIPMLMBOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x73FD200", Offset = "0x73FC600", VA = "0x1873FD200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2FBBA40", Offset = "0x2FBAE40", VA = "0x182FBBA40")]
	public IMCIBIPEPOC<TResult> CHEGJEMPHBA<TResult>(int PEGIIBGHDLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2FBBD60", Offset = "0x2FBB160", VA = "0x182FBBD60")]
	public bool CHMNLHFPING<TResult>(Guid LBOKKGIBGKL, TResult HCMJFDLGOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x73FD0E0", Offset = "0x73FC4E0", VA = "0x1873FD0E0")]
	private void BCLBCLNLLAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x73FD200", Offset = "0x73FC600", VA = "0x1873FD200")]
	private void LJLFAGOKEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x73FD510", Offset = "0x73FC910", VA = "0x1873FD510")]
	private void PBFMLEGLGFA(int MGHMBGDCEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x73FD310", Offset = "0x73FC710", VA = "0x1873FD310")]
	private void MFNNHIHCMBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum POKFHFAOLCI
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KAGAEELOHPN<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class GAIDMJPEAHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int ECNNJJGIHIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int FHGGKOADJON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int AGJBOFBMDIM;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public GAIDMJPEAHD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId FEBMDCCLMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int LNNINHIMIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public POKFHFAOLCI EHPINCLEOAB;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x176AF20", Offset = "0x176A320", VA = "0x18176AF20")]
	public KAGAEELOHPN(TItemId FFKILKBDNHG, int LBJJAOIKGCM, POKFHFAOLCI LHOBDGJGOHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NKBNIPOEOIB<TItemId, TResult> : OJDLLHGHHHI<KAGAEELOHPN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4955270", Offset = "0x4954670", VA = "0x184955270")]
	public NKBNIPOEOIB(IOKLEELHCBI<KAGAEELOHPN<TItemId>, TResult> ILBEPFIAAAF, TimeSpan GCFPKGADMLN, [Optional] CDGHNLHMECN PFPGPFBOMNB)
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

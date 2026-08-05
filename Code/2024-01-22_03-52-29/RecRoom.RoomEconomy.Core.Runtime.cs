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
public interface LJCAHPDIMEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DKNGOKPADIJ(int GAIKHOGKDCP, CancellationToken HHHPDCGPCML);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DKNGOKPADIJ(TimeSpan DIAEAEJGMNK, CancellationToken HHHPDCGPCML);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class INKJBCLDOLC : LJCAHPDIMEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65E0040", Offset = "0x65DF440", VA = "0x1865E0040")]
	[ABIGJEDBLLA(DFKMKBBAPPA.Root, BMBIBJGPNHE.GameOnly)]
	private static void JKLDANPBABA(DFNLNAANFCD MKEGOGNADMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	[Preserve]
	public INKJBCLDOLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x65DFF80", Offset = "0x65DF380", VA = "0x1865DFF80", Slot = "4")]
	public Task DKNGOKPADIJ(int GAIKHOGKDCP, CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x65DFFE0", Offset = "0x65DF3E0", VA = "0x1865DFFE0", Slot = "5")]
	public Task DKNGOKPADIJ(TimeSpan DIAEAEJGMNK, CancellationToken HHHPDCGPCML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BNCJPEENCKB<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId NHDGGHBKBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int COBCJIJMCNI;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x471B990", Offset = "0x471AD90", VA = "0x18471B990")]
	public BNCJPEENCKB(TItemId HPIELIGPHKI, int PAJBMBKMIHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MEBDHEPCPOF<TItemId, TResult> : CILHJEKKHLM<BNCJPEENCKB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x37140B0", Offset = "0x37134B0", VA = "0x1837140B0")]
	public MEBDHEPCPOF(HJENMBNAPPL<BNCJPEENCKB<TItemId>, TResult> PODHODPHBAC, TimeSpan NJCFPEEJMED, [Optional] LJCAHPDIMEJ FBKKFNNIGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3DFEDE0", Offset = "0x3DFE1E0", VA = "0x183DFEDE0")]
	public Task<TResult> NFPCBEFEEPD(TItemId CONEAMPCFEL, int PAJBMBKMIHA, [Optional] CancellationToken HHHPDCGPCML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CILHJEKKHLM<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct KIAPFJPOEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest BJLEFAOBBGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> PCNCLGIFCIC;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x863610", Offset = "0x862A10", VA = "0x180863610")]
		public KIAPFJPOEJL(TRequest MGFKAMLOFJH, TaskCompletionSource<TResult> HKIDIBCINJK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JAABMOJNGDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CILHJEKKHLM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3AA21A0", Offset = "0x3AA15A0", VA = "0x183AA21A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3AA26E0", Offset = "0x3AA1AE0", VA = "0x183AA26E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ECOHHNOKJIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public CILHJEKKHLM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x32A27D0", Offset = "0x32A1BD0", VA = "0x1832A27D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x32A2BA0", Offset = "0x32A1FA0", VA = "0x1832A2BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct OBPPOJOPEEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CILHJEKKHLM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3F7B6C0", Offset = "0x3F7AAC0", VA = "0x183F7B6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3F7BB60", Offset = "0x3F7AF60", VA = "0x183F7BB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EDOHNKIKFPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public CILHJEKKHLM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private List<TaskCompletionSource<TResult>> <taskCompletionSources>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x32AA910", Offset = "0x32A9D10", VA = "0x1832AA910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x32AB850", Offset = "0x32AAC50", VA = "0x1832AB850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HJENMBNAPPL<TRequest, TResult> PODHODPHBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float NJCFPEEJMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly LJCAHPDIMEJ FBKKFNNIGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<KIAPFJPOEJL> HEJDAMHAOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource AIBNKLHLPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource HMAKDHKKPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task GNBGDNNNGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float OPBAENNMDAB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NABJPIJAAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA53390", Offset = "0xA52790", VA = "0x180A53390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA532A0", Offset = "0xA526A0", VA = "0x180A532A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4AAA120", Offset = "0x4AA9520", VA = "0x184AAA120")]
	public CILHJEKKHLM(HJENMBNAPPL<TRequest, TResult> PODHODPHBAC, TimeSpan NJCFPEEJMED, [Optional] LJCAHPDIMEJ FBKKFNNIGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9880", Offset = "0x4AA8C80", VA = "0x184AA9880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9F00", Offset = "0x4AA9300", VA = "0x184AA9F00")]
	[AsyncStateMachine(typeof(CILHJEKKHLM<, >.JAABMOJNGDD))]
	public Task<TResult> NFPCBEFEEPD(TRequest MGFKAMLOFJH, [Optional] CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9720", Offset = "0x4AA8B20", VA = "0x184AA9720")]
	public Task CDNHBBIGLBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9C70", Offset = "0x4AA9070", VA = "0x184AA9C70")]
	[AsyncStateMachine(typeof(CILHJEKKHLM<, >.ECOHHNOKJIL))]
	private Task HMDOBFFDNMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9DE0", Offset = "0x4AA91E0", VA = "0x184AA9DE0")]
	[AsyncStateMachine(typeof(CILHJEKKHLM<, >.OBPPOJOPEEH))]
	private Task JOMKDKEPCJF(CancellationToken JLIKKNIINJE, CancellationToken MFOICAFENGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4AAA020", Offset = "0x4AA9420", VA = "0x184AAA020")]
	[AsyncStateMachine(typeof(CILHJEKKHLM<, >.EDOHNKIKFPN))]
	private Task PFIJFNJNHLL(CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9A90", Offset = "0x4AA8E90", VA = "0x184AA9A90")]
	private TimeSpan EGPEGPPHBIO()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9B60", Offset = "0x4AA8F60", VA = "0x184AA9B60")]
	private Task<List<TResult>> FOHLDJGHGKO(IReadOnlyList<TRequest> KIOFBMLNCEC, CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4AA97E0", Offset = "0x4AA8BE0", VA = "0x184AA97E0")]
	private float CKEHBMACLCF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9D50", Offset = "0x4AA9150", VA = "0x184AA9D50")]
	private void JDGMBJCIJEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EMPGFHHPKDF<TItemId, TResult> : HJENMBNAPPL<BNCJPEENCKB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> LDKPGNLHCFP(Dictionary<TItemId, int> KIOFBMLNCEC, CancellationToken HHHPDCGPCML);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class OFPNEJAKIKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public OFPNEJAKIKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F95C30", Offset = "0x3F95030", VA = "0x183F95C30")]
		internal TResult PAFGNFHDEIO(BNCJPEENCKB<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct LFMLDHPICIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<BNCJPEENCKB<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public EMPGFHHPKDF<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private OFPNEJAKIKH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3C12040", Offset = "0x3C11440", VA = "0x183C12040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3C12D90", Offset = "0x3C12190", VA = "0x183C12D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly LDKPGNLHCFP KMELJAAFAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> FBMPPJGOOGF;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3249530", Offset = "0x3248930", VA = "0x183249530")]
	public EMPGFHHPKDF(LDKPGNLHCFP KMELJAAFAEH, [Optional] IEqualityComparer<TItemId> FBMPPJGOOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x32EFDB0", Offset = "0x32EF1B0", VA = "0x1832EFDB0", Slot = "4")]
	[AsyncStateMachine(typeof(EMPGFHHPKDF<, >.LFMLDHPICIK))]
	public Task<List<TResult>> NMJAHJLCEDN(IReadOnlyList<BNCJPEENCKB<TItemId>> KIOFBMLNCEC, CancellationToken HHHPDCGPCML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EAPIDGMJNIK<TRequest, TResult> : HJENMBNAPPL<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> CGFEFNLHEEE(IEnumerable<TRequest> MECCGMPHHOE, CancellationToken HHHPDCGPCML);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class LALAFKNLBOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public LALAFKNLBOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x32BF080", Offset = "0x32BE480", VA = "0x1832BF080")]
		internal TResult PAFGNFHDEIO(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct IBDGDBBGGIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public IReadOnlyList<TRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public EAPIDGMJNIK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private LALAFKNLBOG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x38C7930", Offset = "0x38C6D30", VA = "0x1838C7930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x38C8760", Offset = "0x38C7B60", VA = "0x1838C8760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CGFEFNLHEEE KMELJAAFAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> FBMPPJGOOGF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3249530", Offset = "0x3248930", VA = "0x183249530")]
	public EAPIDGMJNIK(CGFEFNLHEEE KMELJAAFAEH, [Optional] IEqualityComparer<TRequest> FBMPPJGOOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x32493E0", Offset = "0x32487E0", VA = "0x1832493E0", Slot = "4")]
	[AsyncStateMachine(typeof(EAPIDGMJNIK<, >.IBDGDBBGGIM))]
	public Task<List<TResult>> NMJAHJLCEDN(IReadOnlyList<TRequest> KIOFBMLNCEC, CancellationToken HHHPDCGPCML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HJENMBNAPPL<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> NMJAHJLCEDN(IReadOnlyList<TRequest> KIOFBMLNCEC, CancellationToken HHHPDCGPCML);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OGBPIILCKFO<TItemId, TResult> : HJENMBNAPPL<LNGMLIEMMAN<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task PBCLPNDFBOJ(IReadOnlyDictionary<TItemId, LNGMLIEMMAN<TItemId>.KLJGIPNGIEM> KIOFBMLNCEC, CancellationToken HHHPDCGPCML);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct CPDKOGFNNJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public OGBPIILCKFO<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IReadOnlyList<LNGMLIEMMAN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4C8D2D0", Offset = "0x4C8C6D0", VA = "0x184C8D2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4C8D800", Offset = "0x4C8CC00", VA = "0x184C8D800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly PBCLPNDFBOJ JJGAEHNHMOO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	public OGBPIILCKFO(PBCLPNDFBOJ JJGAEHNHMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3F97000", Offset = "0x3F96400", VA = "0x183F97000", Slot = "4")]
	[AsyncStateMachine(typeof(OGBPIILCKFO<, >.CPDKOGFNNJA))]
	public Task<List<object>> NMJAHJLCEDN(IReadOnlyList<LNGMLIEMMAN<TItemId>> KIOFBMLNCEC, CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3F96B90", Offset = "0x3F95F90", VA = "0x183F96B90")]
	private IReadOnlyDictionary<TItemId, LNGMLIEMMAN<TItemId>.KLJGIPNGIEM> EJJAPNFOOCH(IReadOnlyList<LNGMLIEMMAN<TItemId>> MFDIOMOIHOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PCBHFCOHGLC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Dictionary<string, GHCNICPGDBB> FCIEDLPCBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private List<T> NENCCIHBJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private Func<IEnumerable<T>> JBPDOAFGBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Func<T, string> HEIEDFHENAN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, GHCNICPGDBB> FBIPOAOBBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> JBKFKMAGEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MCCDAPHMACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8C5130", Offset = "0x8C4530", VA = "0x1808C5130")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8C5120", Offset = "0x8C4520", VA = "0x1808C5120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x40474D0", Offset = "0x40468D0", VA = "0x1840474D0")]
	public PCBHFCOHGLC(Func<IEnumerable<T>> JBPDOAFGBID, Func<T, string> HEIEDFHENAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x40471E0", Offset = "0x40465E0", VA = "0x1840471E0")]
	public void AKOCPLJFKLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4047460", Offset = "0x4046860", VA = "0x184047460", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JOBNGEBIOJG<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid NBNCOMPILOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> FMCDCAFGAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OLCOFNDGKKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private interface PLIFGIEAPFM
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int DJBGHELDEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool AOFBKEMJMMN<TParam>(TParam PAHKKNONPEO);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool GKFABEJPGFH(Exception CFJCPBMIHPE);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool FJEDOAFMAIL();
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class CNJLFOKIBFF<TResult> : PLIFGIEAPFM, JOBNGEBIOJG<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly TaskCompletionSource<TResult> DBEOHBPJKIC;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid NBNCOMPILOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xB5FAF0", Offset = "0xB5EEF0", VA = "0x180B5FAF0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int DJBGHELDEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8C5130", Offset = "0x8C4530", VA = "0x1808C5130", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> FMCDCAFGAOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x3E03AC0", Offset = "0x3E02EC0", VA = "0x183E03AC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4C834C0", Offset = "0x4C828C0", VA = "0x184C834C0")]
		public CNJLFOKIBFF(int LEHMKDNPJHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x234DE50", Offset = "0x234D250", VA = "0x18234DE50", Slot = "5")]
		public bool AOFBKEMJMMN<TParam>(TParam PAHKKNONPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4C83480", Offset = "0x4C82880", VA = "0x184C83480", Slot = "6")]
		public bool GKFABEJPGFH(Exception CFJCPBMIHPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4C83440", Offset = "0x4C82840", VA = "0x184C83440", Slot = "7")]
		public bool FJEDOAFMAIL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public const string FILLKOKIHPG = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<Guid, PLIFGIEAPFM> OHHGPNNECCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly BMECDJDJNAE EEJPGAFHKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool EKMDLDFHFOI;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x65E0860", Offset = "0x65DFC60", VA = "0x1865E0860")]
	public OLCOFNDGKKF([Optional] BMECDJDJNAE EEJPGAFHKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x65E0750", Offset = "0x65DFB50", VA = "0x1865E0750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2790040", Offset = "0x278F440", VA = "0x182790040")]
	public JOBNGEBIOJG<TResult> DJJLBKPIIOH<TResult>(int BGLPPBHGFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27902E0", Offset = "0x278F6E0", VA = "0x1827902E0")]
	public bool NFBHMABJINB<TResult>(Guid JABMMLHEJBM, TResult APCONDCGDJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x65E0630", Offset = "0x65DFA30", VA = "0x1865E0630")]
	private void DNOLPBKPDGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x65E0750", Offset = "0x65DFB50", VA = "0x1865E0750")]
	private void GKCHJHOMLBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x65E0140", Offset = "0x65DF540", VA = "0x1865E0140")]
	private void BELCEJIEAGD(int LEHMKDNPJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x65E0430", Offset = "0x65DF830", VA = "0x1865E0430")]
	private void BLEGKKDIEGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum HMIBKNEIKIA
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LNGMLIEMMAN<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class KLJGIPNGIEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int PNOAAKFHHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int FADADADBKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int KIPJBMCGBBM;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public KLJGIPNGIEM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId NHDGGHBKBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int COBCJIJMCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public HMIBKNEIKIA CJINABEMKJK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xE4B600", Offset = "0xE4AA00", VA = "0x180E4B600")]
	public LNGMLIEMMAN(TItemId HPIELIGPHKI, int PAJBMBKMIHA, HMIBKNEIKIA GDMGHBDKKDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class AAJPDKKPFKG<TItemId, TResult> : CILHJEKKHLM<LNGMLIEMMAN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x37140B0", Offset = "0x37134B0", VA = "0x1837140B0")]
	public AAJPDKKPFKG(HJENMBNAPPL<LNGMLIEMMAN<TItemId>, TResult> PODHODPHBAC, TimeSpan NJCFPEEJMED, [Optional] LJCAHPDIMEJ FBKKFNNIGBF)
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

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
public interface HIKJAELFOHM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LBALJAAFNHA(int DPLJBMODCOP, CancellationToken DDNLBFLLCLM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LBALJAAFNHA(TimeSpan HONLMLKGOBM, CancellationToken DDNLBFLLCLM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BFMNEPJOBLD : HIKJAELFOHM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x73049C0", Offset = "0x7303BC0", VA = "0x1873049C0")]
	[NPIOOMADHDK.JLDADBHPDAA.GOAAFNNCHDN]
	internal static void GLGGBEPLOGP(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BFMNEPJOBLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7304AB0", Offset = "0x7303CB0", VA = "0x187304AB0", Slot = "4")]
	public Task LBALJAAFNHA(int DPLJBMODCOP, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7304B10", Offset = "0x7303D10", VA = "0x187304B10", Slot = "5")]
	public Task LBALJAAFNHA(TimeSpan HONLMLKGOBM, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7304B70", Offset = "0x7303D70", VA = "0x187304B70", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DEHAMPIKOLI<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct BBBBNOBBGGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest CLKMGPFIPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> PDFBHLKBOBP;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD62DE0", Offset = "0xD61FE0", VA = "0x180D62DE0")]
		public BBBBNOBBGGA(TRequest LGIKLBJKNEM, TaskCompletionSource<TResult> AMHGEHKPELL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct CEACPDNHKDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public DEHAMPIKOLI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x56C9E90", Offset = "0x56C9090", VA = "0x1856C9E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x454D770", Offset = "0x454C970", VA = "0x18454D770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NOFENMJCCAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public DEHAMPIKOLI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4867A60", Offset = "0x4866C60", VA = "0x184867A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4867E40", Offset = "0x4867040", VA = "0x184867E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KCGGNJKCJCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DEHAMPIKOLI<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4489ED0", Offset = "0x44890D0", VA = "0x184489ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x448A390", Offset = "0x4489590", VA = "0x18448A390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct AGCCJBJCBFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DEHAMPIKOLI<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3F32FF0", Offset = "0x3F321F0", VA = "0x183F32FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3F34180", Offset = "0x3F33380", VA = "0x183F34180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly KGHNCOMAMFE<TRequest, TResult> IPJIPPCAKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float GOJFPMJGPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HIKJAELFOHM GLAKIKFLDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool ABFHOKMEGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<BBBBNOBBGGA> PGLJNBMCLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<BBBBNOBBGGA> KKMLALDNGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool CHGJMMIJJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource AMFEENDGEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource OFGJHJJEBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task FJMOAIBEHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float KMJBCAKDALJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NBBOOJLBJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x894450", Offset = "0x893650", VA = "0x180894450")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x894470", Offset = "0x893670", VA = "0x180894470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5B28BF0", Offset = "0x5B27DF0", VA = "0x185B28BF0")]
	public DEHAMPIKOLI(KGHNCOMAMFE<TRequest, TResult> IPJIPPCAKHP, TimeSpan GOJFPMJGPBN, bool ABFHOKMEGFA, [Optional] HIKJAELFOHM GLAKIKFLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5B28360", Offset = "0x5B27560", VA = "0x185B28360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5B281A0", Offset = "0x5B273A0", VA = "0x185B281A0")]
	[AsyncStateMachine(typeof(DEHAMPIKOLI<, >.CEACPDNHKDM))]
	public Task<TResult> ABEFENFPHGE(TRequest LGIKLBJKNEM, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5B28100", Offset = "0x5B27300", VA = "0x185B28100")]
	private void ABEFENFPHGE(TRequest LGIKLBJKNEM, TaskCompletionSource<TResult> AMHGEHKPELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5B285A0", Offset = "0x5B277A0", VA = "0x185B285A0")]
	public Task HJFKFBAIOGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5B28A20", Offset = "0x5B27C20", VA = "0x185B28A20")]
	[AsyncStateMachine(typeof(DEHAMPIKOLI<, >.NOFENMJCCAA))]
	private Task NEMBDLMGNEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5B28700", Offset = "0x5B27900", VA = "0x185B28700")]
	[AsyncStateMachine(typeof(DEHAMPIKOLI<, >.KCGGNJKCJCJ))]
	private Task KBLGIOHGKJA(CancellationToken NIKIIADNELI, CancellationToken KFFBKNEDLEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5B28AF0", Offset = "0x5B27CF0", VA = "0x185B28AF0")]
	[AsyncStateMachine(typeof(DEHAMPIKOLI<, >.AGCCJBJCBFG))]
	private Task NNEOPNHKIGM(CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5B28940", Offset = "0x5B27B40", VA = "0x185B28940")]
	private TimeSpan NBNOJEJIJOO()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5B28820", Offset = "0x5B27A20", VA = "0x185B28820")]
	private Task<List<TResult>> MGJJPMLBOHN(IReadOnlyList<TRequest> NCMGMNCNIMB, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5B28660", Offset = "0x5B27860", VA = "0x185B28660")]
	private float JCBBFFONJHJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5B282C0", Offset = "0x5B274C0", VA = "0x185B282C0")]
	private void DPCCDEGOHCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FJAJEAGMBDK<TItemId, TResult> : KGHNCOMAMFE<DJNEDIGGOAJ<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> CPBLPANNNCD(Dictionary<TItemId, int> NCMGMNCNIMB, CancellationToken DDNLBFLLCLM);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class FCELFDDPMNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public FCELFDDPMNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3E77120", Offset = "0x3E76320", VA = "0x183E77120")]
		internal TResult FMMLMLFEPBI(DJNEDIGGOAJ<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct GMHGAPILFJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<DJNEDIGGOAJ<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public FJAJEAGMBDK<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private FCELFDDPMNF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3FC7B50", Offset = "0x3FC6D50", VA = "0x183FC7B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3FC8890", Offset = "0x3FC7A90", VA = "0x183FC8890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly CPBLPANNNCD AINCDJGCOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> BEGOEBAKHOO;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3E9FB80", Offset = "0x3E9ED80", VA = "0x183E9FB80")]
	public FJAJEAGMBDK(CPBLPANNNCD AINCDJGCOPA, [Optional] IEqualityComparer<TItemId> BEGOEBAKHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3E9F790", Offset = "0x3E9E990", VA = "0x183E9F790", Slot = "4")]
	[AsyncStateMachine(typeof(FJAJEAGMBDK<, >.GMHGAPILFJD))]
	public Task<List<TResult>> MBJKAILKLDN(IReadOnlyList<DJNEDIGGOAJ<TItemId>> NCMGMNCNIMB, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PKGMMCHBBGL<TRequest, TResult> : KGHNCOMAMFE<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> IKBLCIIJIDB(IEnumerable<TRequest> EINNDIFLJFM, CancellationToken DDNLBFLLCLM);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class LHAPPGBJLBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public LHAPPGBJLBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3EB0B90", Offset = "0x3EAFD90", VA = "0x183EB0B90")]
		internal TResult FMMLMLFEPBI(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct BFMKPGDCAAD : IAsyncStateMachine
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
		public PKGMMCHBBGL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private LHAPPGBJLBA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x51CAEA0", Offset = "0x51CA0A0", VA = "0x1851CAEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x51CBCE0", Offset = "0x51CAEE0", VA = "0x1851CBCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IKBLCIIJIDB AINCDJGCOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> BEGOEBAKHOO;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E9FB80", Offset = "0x3E9ED80", VA = "0x183E9FB80")]
	public PKGMMCHBBGL(IKBLCIIJIDB AINCDJGCOPA, [Optional] IEqualityComparer<TRequest> BEGOEBAKHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4AAC130", Offset = "0x4AAB330", VA = "0x184AAC130", Slot = "4")]
	[AsyncStateMachine(typeof(PKGMMCHBBGL<, >.BFMKPGDCAAD))]
	public Task<List<TResult>> MBJKAILKLDN(IReadOnlyList<TRequest> NCMGMNCNIMB, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KGHNCOMAMFE<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> MBJKAILKLDN(IReadOnlyList<TRequest> NCMGMNCNIMB, CancellationToken DDNLBFLLCLM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LPLCKGPEMGB<TItemId, TResult> : KGHNCOMAMFE<GCOMOLDEAHM<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task IKHFEAEEBIF(IReadOnlyDictionary<TItemId, GCOMOLDEAHM<TItemId>.BCOGDDCJOLD> NCMGMNCNIMB, CancellationToken DDNLBFLLCLM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct CHEBBBDHBPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LPLCKGPEMGB<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<GCOMOLDEAHM<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x56D26E0", Offset = "0x56D18E0", VA = "0x1856D26E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x56D2C30", Offset = "0x56D1E30", VA = "0x1856D2C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly IKHFEAEEBIF LHMGLNPGNDP;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	public LPLCKGPEMGB(IKHFEAEEBIF LHMGLNPGNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4576D40", Offset = "0x4575F40", VA = "0x184576D40", Slot = "4")]
	[AsyncStateMachine(typeof(LPLCKGPEMGB<, >.CHEBBBDHBPA))]
	public Task<List<object>> MBJKAILKLDN(IReadOnlyList<GCOMOLDEAHM<TItemId>> NCMGMNCNIMB, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x45768D0", Offset = "0x4575AD0", VA = "0x1845768D0")]
	private IReadOnlyDictionary<TItemId, GCOMOLDEAHM<TItemId>.BCOGDDCJOLD> KIHAJCMHNPK(IReadOnlyList<GCOMOLDEAHM<TItemId>> LOKOCKBPJLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ODBPCGMBHBC<TItemId, TResult> : KGHNCOMAMFE<DJNEDIGGOAJ<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> NPNJBGAJINM(Dictionary<TItemId, int> NCMGMNCNIMB, CancellationToken DDNLBFLLCLM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct BOIMNBHIKLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<DJNEDIGGOAJ<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public ODBPCGMBHBC<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x52F8870", Offset = "0x52F7A70", VA = "0x1852F8870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x52F9510", Offset = "0x52F8710", VA = "0x1852F9510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly NPNJBGAJINM DCDFDKEAAOA;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	public ODBPCGMBHBC(NPNJBGAJINM AINCDJGCOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4957AF0", Offset = "0x4956CF0", VA = "0x184957AF0", Slot = "4")]
	[AsyncStateMachine(typeof(ODBPCGMBHBC<, >.BOIMNBHIKLF))]
	public Task<List<TResult>> MBJKAILKLDN(IReadOnlyList<DJNEDIGGOAJ<TItemId>> NCMGMNCNIMB, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EIAGCGCIIGC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, KMMOFIPPECC> CLHFNEGCJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> ADLCKLOMOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> CCNBIFJEFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> KFCJPBFLJJP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, KMMOFIPPECC> NLGHLENMDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> GEEMHJKMLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KCCDOLJHBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD20", Offset = "0x8FAF20", VA = "0x1808FBD20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA22AE0", Offset = "0xA21CE0", VA = "0x180A22AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3AD4060", Offset = "0x3AD3260", VA = "0x183AD4060")]
	public EIAGCGCIIGC(Func<IEnumerable<T>> CCNBIFJEFEP, Func<T, string> KFCJPBFLJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3DA0", Offset = "0x3AD2FA0", VA = "0x183AD3DA0")]
	public void GEGAIMNPNFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3D10", Offset = "0x3AD2F10", VA = "0x183AD3D10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KMEPGHGDEAK<TItemId, TResult> : DEHAMPIKOLI<DJNEDIGGOAJ<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x43453E0", Offset = "0x43445E0", VA = "0x1843453E0")]
	public KMEPGHGDEAK(KGHNCOMAMFE<DJNEDIGGOAJ<TItemId>, TResult> IPJIPPCAKHP, TimeSpan GOJFPMJGPBN, bool ABFHOKMEGFA, [Optional] HIKJAELFOHM GLAKIKFLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x44BD380", Offset = "0x44BC580", VA = "0x1844BD380")]
	public Task<TResult> ABEFENFPHGE(TItemId CPBLLDDDHEE, int LNKBLOMPPCK, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DJNEDIGGOAJ<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId IADJAGFJAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int AGPEOFMALIF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5B33DB0", Offset = "0x5B32FB0", VA = "0x185B33DB0")]
	public DJNEDIGGOAJ(TItemId PLLOFJJFIKG, int LNKBLOMPPCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AEPCAEMDDFG<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid KKMAAAKKEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> NDLPPMDEHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class AHMJJGOBPCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface GAACAJBAJGC
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int KODHMKHAPNP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool GDBLGCOPFDE<TParam>(TParam JECHHBGMFLN);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool NMCJGGKMBFB(Exception DJGHECPCKKM);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool LBJAAPDNPKC();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class OMENJOKKNDI<TResult> : GAACAJBAJGC, AEPCAEMDDFG<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> HNKDADPHGFG;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid KKMAAAKKEEM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA7FAC0", Offset = "0xA7ECC0", VA = "0x180A7FAC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int KODHMKHAPNP
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8FBD20", Offset = "0x8FAF20", VA = "0x1808FBD20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> NDLPPMDEHDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4804FC0", Offset = "0x48041C0", VA = "0x184804FC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x497F1A0", Offset = "0x497E3A0", VA = "0x18497F1A0")]
		public OMENJOKKNDI(int DGEGJLICKLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3198710", Offset = "0x3197910", VA = "0x183198710", Slot = "5")]
		public bool GDBLGCOPFDE<TParam>(TParam JECHHBGMFLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x497F150", Offset = "0x497E350", VA = "0x18497F150", Slot = "6")]
		public bool NMCJGGKMBFB(Exception DJGHECPCKKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x497F100", Offset = "0x497E300", VA = "0x18497F100", Slot = "7")]
		public bool LBJAAPDNPKC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string IALGFACCBJP = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, GAACAJBAJGC> IABOPNODHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly KLGPJCJJPJD POLPLAANGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool JDOHLCKJGGH;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x73048C0", Offset = "0x7303AC0", VA = "0x1873048C0")]
	public AHMJJGOBPCE([Optional] KLGPJCJJPJD POLPLAANGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7304490", Offset = "0x7303690", VA = "0x187304490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3525390", Offset = "0x3524590", VA = "0x183525390")]
	public AEPCAEMDDFG<TResult> FKHPKOAPCOA<TResult>(int LHMOOCLDLDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3525020", Offset = "0x3524220", VA = "0x183525020")]
	public bool BLMJBEPFCEN<TResult>(Guid OGPABPLIHCK, TResult KHPJAGHLNBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x73047A0", Offset = "0x73039A0", VA = "0x1873047A0")]
	private void LCGIKJBCJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7304490", Offset = "0x7303690", VA = "0x187304490")]
	private void LNOFEOPLGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x73041A0", Offset = "0x73033A0", VA = "0x1873041A0")]
	private void CEIHICEFPBG(int DGEGJLICKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x73045A0", Offset = "0x73037A0", VA = "0x1873045A0")]
	private void IGLADLGGNLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum OPAEANDCIIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GCOMOLDEAHM<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class BCOGDDCJOLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int AMNPIAKDEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int DHBIBAONGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int KLEHNLEENBG;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public BCOGDDCJOLD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId IADJAGFJAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int AGPEOFMALIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public OPAEANDCIIJ BIAJMDEELEB;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x177DEB0", Offset = "0x177D0B0", VA = "0x18177DEB0")]
	public GCOMOLDEAHM(TItemId PLLOFJJFIKG, int LNKBLOMPPCK, OPAEANDCIIJ KLCFDAPKGEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JLEPHKGOJHJ<TItemId, TResult> : DEHAMPIKOLI<GCOMOLDEAHM<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x43898F0", Offset = "0x4388AF0", VA = "0x1843898F0")]
	public JLEPHKGOJHJ(KGHNCOMAMFE<GCOMOLDEAHM<TItemId>, TResult> IPJIPPCAKHP, TimeSpan GOJFPMJGPBN, [Optional] HIKJAELFOHM GLAKIKFLDIL)
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

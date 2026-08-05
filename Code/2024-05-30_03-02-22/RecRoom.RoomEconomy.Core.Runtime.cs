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
public interface CKCMOHBGLCB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MKIGLJGIFCL(int CGPLAINCCIF, CancellationToken GILHKFNDIJP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MKIGLJGIFCL(TimeSpan OBNNJKPFHBE, CancellationToken GILHKFNDIJP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IPNHIMMPAEL : CKCMOHBGLCB
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69F81D0", Offset = "0x69F73D0", VA = "0x1869F81D0")]
	[JIMPHGEJKMA(NFKMIHJOIMG.Root, CLDBMEKPFFP.GameOnly)]
	private static void LJKAJEFLMOE(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	[Preserve]
	public IPNHIMMPAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x69F82C0", Offset = "0x69F74C0", VA = "0x1869F82C0", Slot = "4")]
	public Task MKIGLJGIFCL(int CGPLAINCCIF, CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69F8320", Offset = "0x69F7520", VA = "0x1869F8320", Slot = "5")]
	public Task MKIGLJGIFCL(TimeSpan OBNNJKPFHBE, CancellationToken GILHKFNDIJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OEIOGMHMAJH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct IPBKNJPOLMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest FEIBHGHJJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> NKNFNFDBKCP;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9FB690", Offset = "0x9FA890", VA = "0x1809FB690")]
		public IPBKNJPOLMJ(TRequest DAFMLJPHFGN, TaskCompletionSource<TResult> ANAAMEIIOFB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct CGKINBHKOEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public OEIOGMHMAJH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4F88DF0", Offset = "0x4F87FF0", VA = "0x184F88DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4F892F0", Offset = "0x4F884F0", VA = "0x184F892F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct NFKFFCFHEJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public OEIOGMHMAJH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x41A9A20", Offset = "0x41A8C20", VA = "0x1841A9A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x41A9DE0", Offset = "0x41A8FE0", VA = "0x1841A9DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct FEFBODAHPGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public OEIOGMHMAJH<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3903420", Offset = "0x3902620", VA = "0x183903420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x39038B0", Offset = "0x3902AB0", VA = "0x1839038B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct NLFAANFLIDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public OEIOGMHMAJH<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x41BD090", Offset = "0x41BC290", VA = "0x1841BD090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x41BDF30", Offset = "0x41BD130", VA = "0x1841BDF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly KOIAIIIJHCN<TRequest, TResult> OMILCJBFAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float EDJHBONADAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CKCMOHBGLCB FPBCPNEOPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<IPBKNJPOLMJ> JAIMHPGHIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource HOJKEKGHCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource MNNOBECAGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task NIEEBJDLKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float LJGMLFFNDBF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ICKIPDGCPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB9ED60", Offset = "0xB9DF60", VA = "0x180B9ED60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB9ED70", Offset = "0xB9DF70", VA = "0x180B9ED70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x428D1A0", Offset = "0x428C3A0", VA = "0x18428D1A0")]
	public OEIOGMHMAJH(KOIAIIIJHCN<TRequest, TResult> OMILCJBFAND, TimeSpan EDJHBONADAC, [Optional] CKCMOHBGLCB FPBCPNEOPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x428C940", Offset = "0x428BB40", VA = "0x18428C940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x428CF20", Offset = "0x428C120", VA = "0x18428CF20")]
	[AsyncStateMachine(typeof(OEIOGMHMAJH<, >.CGKINBHKOEH))]
	public Task<TResult> HBNMOJNFGFP(TRequest DAFMLJPHFGN, [Optional] CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x428D040", Offset = "0x428C240", VA = "0x18428D040")]
	public Task OGGKDPKCHBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x428CE50", Offset = "0x428C050", VA = "0x18428CE50")]
	[AsyncStateMachine(typeof(OEIOGMHMAJH<, >.NFKFFCFHEJP))]
	private Task FPDKEBOPLFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x428CD30", Offset = "0x428BF30", VA = "0x18428CD30")]
	[AsyncStateMachine(typeof(OEIOGMHMAJH<, >.FEFBODAHPGB))]
	private Task FPBJEEKFAKB(CancellationToken MBNHGCCHFAO, CancellationToken HGMMNICMMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x428CB30", Offset = "0x428BD30", VA = "0x18428CB30")]
	[AsyncStateMachine(typeof(OEIOGMHMAJH<, >.NLFAANFLIDM))]
	private Task EFOGDNBMAMI(CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x428C7E0", Offset = "0x428B9E0", VA = "0x18428C7E0")]
	private TimeSpan AKDJDBIIDJE()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x428CC30", Offset = "0x428BE30", VA = "0x18428CC30")]
	private Task<List<TResult>> FHJKFDKADDP(IReadOnlyList<TRequest> BGGLMHCGIFB, CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x428D100", Offset = "0x428C300", VA = "0x18428D100")]
	private float PEBOJPDBAJI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x428C8B0", Offset = "0x428BAB0", VA = "0x18428C8B0")]
	private void BELDILHECPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NMCLBNOFGHA<TItemId, TResult> : KOIAIIIJHCN<PDCPHJPAFNK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> ODKPFNGEFPB(Dictionary<TItemId, int> BGGLMHCGIFB, CancellationToken GILHKFNDIJP);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PDMCBHAEEJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public PDMCBHAEEJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x43A8CB0", Offset = "0x43A7EB0", VA = "0x1843A8CB0")]
		internal TResult HPLLCBMHLBB(PDCPHJPAFNK<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DBMBGLGEOMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<PDCPHJPAFNK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NMCLBNOFGHA<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private PDMCBHAEEJB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x531E1F0", Offset = "0x531D3F0", VA = "0x18531E1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x531EE90", Offset = "0x531E090", VA = "0x18531EE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly ODKPFNGEFPB IMNDEALBBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> MGOCODLOLKK;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x418D000", Offset = "0x418C200", VA = "0x18418D000")]
	public NMCLBNOFGHA(ODKPFNGEFPB IMNDEALBBAG, [Optional] IEqualityComparer<TItemId> MGOCODLOLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x41CB200", Offset = "0x41CA400", VA = "0x1841CB200", Slot = "4")]
	[AsyncStateMachine(typeof(NMCLBNOFGHA<, >.DBMBGLGEOMO))]
	public Task<List<TResult>> LEFPFNAANOK(IReadOnlyList<PDCPHJPAFNK<TItemId>> BGGLMHCGIFB, CancellationToken GILHKFNDIJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NAPNJEHIOLN<TRequest, TResult> : KOIAIIIJHCN<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> GNFACHLIECH(IEnumerable<TRequest> JLKCLDMBDBK, CancellationToken GILHKFNDIJP);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class AHNIHEDFMIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public AHNIHEDFMIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3927740", Offset = "0x3926940", VA = "0x183927740")]
		internal TResult HPLLCBMHLBB(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct IMBOCMCGCPP : IAsyncStateMachine
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
		public NAPNJEHIOLN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private AHNIHEDFMIL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3B26CC0", Offset = "0x3B25EC0", VA = "0x183B26CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3B27A30", Offset = "0x3B26C30", VA = "0x183B27A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GNFACHLIECH IMNDEALBBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> MGOCODLOLKK;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x418D000", Offset = "0x418C200", VA = "0x18418D000")]
	public NAPNJEHIOLN(GNFACHLIECH IMNDEALBBAG, [Optional] IEqualityComparer<TRequest> MGOCODLOLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x418CEC0", Offset = "0x418C0C0", VA = "0x18418CEC0", Slot = "4")]
	[AsyncStateMachine(typeof(NAPNJEHIOLN<, >.IMBOCMCGCPP))]
	public Task<List<TResult>> LEFPFNAANOK(IReadOnlyList<TRequest> BGGLMHCGIFB, CancellationToken GILHKFNDIJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KOIAIIIJHCN<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> LEFPFNAANOK(IReadOnlyList<TRequest> BGGLMHCGIFB, CancellationToken GILHKFNDIJP);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class IOHDEPIDKIF<TItemId, TResult> : KOIAIIIJHCN<AKHALEJHAPN<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task MMPFFLMIOIE(IReadOnlyDictionary<TItemId, AKHALEJHAPN<TItemId>.ECANHPPLCFD> BGGLMHCGIFB, CancellationToken GILHKFNDIJP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct GMKOIIALMEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IOHDEPIDKIF<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<AKHALEJHAPN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x39DDC70", Offset = "0x39DCE70", VA = "0x1839DDC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x39DE170", Offset = "0x39DD370", VA = "0x1839DE170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly MMPFFLMIOIE JAOLFCGFLDO;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	public IOHDEPIDKIF(MMPFFLMIOIE JAOLFCGFLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3B2BCC0", Offset = "0x3B2AEC0", VA = "0x183B2BCC0", Slot = "4")]
	[AsyncStateMachine(typeof(IOHDEPIDKIF<, >.GMKOIIALMEP))]
	public Task<List<object>> LEFPFNAANOK(IReadOnlyList<AKHALEJHAPN<TItemId>> BGGLMHCGIFB, CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B2B860", Offset = "0x3B2AA60", VA = "0x183B2B860")]
	private IReadOnlyDictionary<TItemId, AKHALEJHAPN<TItemId>.ECANHPPLCFD> FPBJMKHIEFA(IReadOnlyList<AKHALEJHAPN<TItemId>> FDOKMLFHDNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HGMDCCMHBND<TItemId, TResult> : KOIAIIIJHCN<PDCPHJPAFNK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> ECPJKHJKPEC(Dictionary<TItemId, int> BGGLMHCGIFB, CancellationToken GILHKFNDIJP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct KHAPJKHLHKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<PDCPHJPAFNK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public HGMDCCMHBND<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3E9F0A0", Offset = "0x3E9E2A0", VA = "0x183E9F0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3E9FCA0", Offset = "0x3E9EEA0", VA = "0x183E9FCA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly ECPJKHJKPEC GFNPGFIEDEE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	public HGMDCCMHBND(ECPJKHJKPEC IMNDEALBBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3A36F50", Offset = "0x3A36150", VA = "0x183A36F50", Slot = "4")]
	[AsyncStateMachine(typeof(HGMDCCMHBND<, >.KHAPJKHLHKG))]
	public Task<List<TResult>> LEFPFNAANOK(IReadOnlyList<PDCPHJPAFNK<TItemId>> BGGLMHCGIFB, CancellationToken GILHKFNDIJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IPNBGBEEDPH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, CMCAOCKOAAO> NFNCDMPMAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> HFBLGBJKDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> NPFJJPBKFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> BDIJEDCLGLH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, CMCAOCKOAAO> PJBBFNIEKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> NGGABDMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IMJFDDNIIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x831BC0", Offset = "0x830DC0", VA = "0x180831BC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8316E0", Offset = "0x8308E0", VA = "0x1808316E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3B3D9B0", Offset = "0x3B3CBB0", VA = "0x183B3D9B0")]
	public IPNBGBEEDPH(Func<IEnumerable<T>> NPFJJPBKFNI, Func<T, string> BDIJEDCLGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3B3D6F0", Offset = "0x3B3C8F0", VA = "0x183B3D6F0")]
	public void DBKEHPIBNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3B3D940", Offset = "0x3B3CB40", VA = "0x183B3D940", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JHGHMDOHCJE<TItemId, TResult> : OEIOGMHMAJH<PDCPHJPAFNK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3D503D0", Offset = "0x3D4F5D0", VA = "0x183D503D0")]
	public JHGHMDOHCJE(KOIAIIIJHCN<PDCPHJPAFNK<TItemId>, TResult> OMILCJBFAND, TimeSpan EDJHBONADAC, [Optional] CKCMOHBGLCB FPBCPNEOPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3D50140", Offset = "0x3D4F340", VA = "0x183D50140")]
	public Task<TResult> HBNMOJNFGFP(TItemId MNOIAMGNLNL, int JNCACEPFDLL, [Optional] CancellationToken GILHKFNDIJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PDCPHJPAFNK<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId LNPONBMFIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int IKOEFJAIDLG;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x43A8370", Offset = "0x43A7570", VA = "0x1843A8370")]
	public PDCPHJPAFNK(TItemId MKCAGIIPFPJ, int JNCACEPFDLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KLGCHNDIPEG<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid MHLMFEIDMIL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> KHCPEAPPDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class ODJOEIEAPPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface EGPOMCDOCKN
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int IFGIBPAPIBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CCABPNCABCI<TParam>(TParam HLCKBKFCMPI);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool BLEBFJMJGPM(Exception NJNKMHCCCIB);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool OANKGBHAHCC();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class LEICIBCCBHL<TResult> : EGPOMCDOCKN, KLGCHNDIPEG<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> GALFCEPCPEK;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid MHLMFEIDMIL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x83B450", Offset = "0x83A650", VA = "0x18083B450", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int IFGIBPAPIBP
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x831BC0", Offset = "0x830DC0", VA = "0x180831BC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> KHCPEAPPDCA
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3F36B40", Offset = "0x3F35D40", VA = "0x183F36B40", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3F36BC0", Offset = "0x3F35DC0", VA = "0x183F36BC0")]
		public LEICIBCCBHL(int EDBBIIDBAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x288DF50", Offset = "0x288D150", VA = "0x18288DF50", Slot = "5")]
		public bool CCABPNCABCI<TParam>(TParam HLCKBKFCMPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3F36B00", Offset = "0x3F35D00", VA = "0x183F36B00", Slot = "6")]
		public bool BLEBFJMJGPM(Exception NJNKMHCCCIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3F36B80", Offset = "0x3F35D80", VA = "0x183F36B80", Slot = "7")]
		public bool OANKGBHAHCC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string FLNBJGPFJDF = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, EGPOMCDOCKN> GMFJAHHPHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly IBFCBMHAMPL NBLKPGHFFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool NPFAAJBKCKH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69F8A90", Offset = "0x69F7C90", VA = "0x1869F8A90")]
	public ODJOEIEAPPG([Optional] IBFCBMHAMPL NBLKPGHFFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69F8380", Offset = "0x69F7580", VA = "0x1869F8380", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0B20", Offset = "0x2AEFD20", VA = "0x182AF0B20")]
	public KLGCHNDIPEG<TResult> OEIBJAPEOBL<TResult>(int JHLCOAAAHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2AF07F0", Offset = "0x2AEF9F0", VA = "0x182AF07F0")]
	public bool MHMCHIEKCEL<TResult>(Guid DPIDBLNGEML, TResult JBENFHJBMMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x69F8970", Offset = "0x69F7B70", VA = "0x1869F8970")]
	private void NDGGMBLCDLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x69F8380", Offset = "0x69F7580", VA = "0x1869F8380")]
	private void AMLBOFCHEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x69F8490", Offset = "0x69F7690", VA = "0x1869F8490")]
	private void GCCOGFOLDMA(int EDBBIIDBAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x69F8770", Offset = "0x69F7970", VA = "0x1869F8770")]
	private void LLHEFEAGOII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum KCLPFJLJMHD
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class AKHALEJHAPN<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ECANHPPLCFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int PMFPBPCHNIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int KHICPFCCBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int GOHHLLNDFPE;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public ECANHPPLCFD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId LNPONBMFIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int IKOEFJAIDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public KCLPFJLJMHD NGDEJOBNMNC;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1060300", Offset = "0x105F500", VA = "0x181060300")]
	public AKHALEJHAPN(TItemId MKCAGIIPFPJ, int JNCACEPFDLL, KCLPFJLJMHD GNIGPOPNBEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MAFFHGEEGLD<TItemId, TResult> : OEIOGMHMAJH<AKHALEJHAPN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3D503D0", Offset = "0x3D4F5D0", VA = "0x183D503D0")]
	public MAFFHGEEGLD(KOIAIIIJHCN<AKHALEJHAPN<TItemId>, TResult> OMILCJBFAND, TimeSpan EDJHBONADAC, [Optional] CKCMOHBGLCB FPBCPNEOPKO)
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

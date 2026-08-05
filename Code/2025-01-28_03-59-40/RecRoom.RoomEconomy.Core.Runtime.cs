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
public interface NCBJLIBIHFL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KIEBJDAODNC(int ABAAKCPKPOL, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KIEBJDAODNC(TimeSpan MEEGDNDFLJN, CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BDIJGPPIFLB : NCBJLIBIHFL
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7926000", Offset = "0x7925200", VA = "0x187926000")]
	[NAOGKPPNIGE.PBOHCEMILCE.MHACPCJGMLG]
	internal static void EEMNDALIEKO(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	[RecRoom.NoEngine.Common.Preserve]
	public BDIJGPPIFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x79260F0", Offset = "0x79252F0", VA = "0x1879260F0", Slot = "4")]
	public Task KIEBJDAODNC(int ABAAKCPKPOL, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7926150", Offset = "0x7925350", VA = "0x187926150", Slot = "5")]
	public Task KIEBJDAODNC(TimeSpan MEEGDNDFLJN, CancellationToken BGEKICMONBE)
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
		[Cpp2IlInjected.Address(RVA = "0x79261B0", Offset = "0x79253B0", VA = "0x1879261B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KCJPECDKLNK<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct OLNBOCDHBEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest IECLPOHOKAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> LMKFNPGPCEN;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x982390", Offset = "0x981590", VA = "0x180982390")]
		public OLNBOCDHBEE(TRequest JLBJPEIMAMB, TaskCompletionSource<TResult> KMMCBIMAJCM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct AEMFPCFOOON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public KCJPECDKLNK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x441E820", Offset = "0x441DA20", VA = "0x18441E820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x441ED30", Offset = "0x441DF30", VA = "0x18441ED30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct GAJELGHFHOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public KCJPECDKLNK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x43A5B90", Offset = "0x43A4D90", VA = "0x1843A5B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x43A5F70", Offset = "0x43A5170", VA = "0x1843A5F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KGHEKPDBCJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public KCJPECDKLNK<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x49339D0", Offset = "0x4932BD0", VA = "0x1849339D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4933E80", Offset = "0x4933080", VA = "0x184933E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct OGMMLBBILKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public KCJPECDKLNK<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4DB3150", Offset = "0x4DB2350", VA = "0x184DB3150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4DB4300", Offset = "0x4DB3500", VA = "0x184DB4300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JEACFJBDJFL<TRequest, TResult> BPKJNOFECPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float JAGOFCLFBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NCBJLIBIHFL CHFEAEKEACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool KNLFIJGALFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<OLNBOCDHBEE> JNEMHACFNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<OLNBOCDHBEE> BGLLBFHHOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool NJLJNPPGOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource BAOGJFHDACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource OBMOGGIAIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task BHEEBCIBBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float DDCKJMJJIMK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HOKILEEDJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x901980", Offset = "0x900B80", VA = "0x180901980")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x901A70", Offset = "0x900C70", VA = "0x180901A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x491B5C0", Offset = "0x491A7C0", VA = "0x18491B5C0")]
	public KCJPECDKLNK(JEACFJBDJFL<TRequest, TResult> BPKJNOFECPK, TimeSpan JAGOFCLFBPA, bool KNLFIJGALFL, [Optional] NCBJLIBIHFL CHFEAEKEACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x491AB90", Offset = "0x4919D90", VA = "0x18491AB90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x491B2E0", Offset = "0x491A4E0", VA = "0x18491B2E0")]
	[AsyncStateMachine(typeof(KCJPECDKLNK<, >.AEMFPCFOOON))]
	public Task<TResult> OIOGFDBPMNM(TRequest JLBJPEIMAMB, [Optional] CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x491B400", Offset = "0x491A600", VA = "0x18491B400")]
	private void OIOGFDBPMNM(TRequest JLBJPEIMAMB, TaskCompletionSource<TResult> KMMCBIMAJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x491AAD0", Offset = "0x4919CD0", VA = "0x18491AAD0")]
	public Task CHFLHFEFIGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x491AE70", Offset = "0x491A070", VA = "0x18491AE70")]
	[AsyncStateMachine(typeof(KCJPECDKLNK<, >.GAJELGHFHOD))]
	private Task KGEPMAKHNPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x491B4A0", Offset = "0x491A6A0", VA = "0x18491B4A0")]
	[AsyncStateMachine(typeof(KCJPECDKLNK<, >.KGHEKPDBCJK))]
	private Task OJBKELPGBOA(CancellationToken BADODFKBEOK, CancellationToken GLNIHNALHGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x491B020", Offset = "0x491A220", VA = "0x18491B020")]
	[AsyncStateMachine(typeof(KCJPECDKLNK<, >.OGMMLBBILKG))]
	private Task KJPFAKOOFOO(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x491AF40", Offset = "0x491A140", VA = "0x18491AF40")]
	private TimeSpan KHFCAKCPALC()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x491B1C0", Offset = "0x491A3C0", VA = "0x18491B1C0")]
	private Task<List<TResult>> MDDMDDLFGOO(IReadOnlyList<TRequest> JHPJFCHDMIL, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x491B120", Offset = "0x491A320", VA = "0x18491B120")]
	private float KKLFCHNFFPI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x491ADD0", Offset = "0x4919FD0", VA = "0x18491ADD0")]
	private void HILFMFEBMKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OJOENKKOLHG<TItemId, TResult> : JEACFJBDJFL<DPGPJIGOFOK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> JMMJIJACLCP(Dictionary<TItemId, int> JHPJFCHDMIL, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class OAIEDFBMPPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public OAIEDFBMPPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4D839C0", Offset = "0x4D82BC0", VA = "0x184D839C0")]
		internal TResult DLEFPNDBMGA(DPGPJIGOFOK<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MOIPOPBDNBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<DPGPJIGOFOK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public OJOENKKOLHG<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private OAIEDFBMPPN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4C23AE0", Offset = "0x4C22CE0", VA = "0x184C23AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4C24840", Offset = "0x4C23A40", VA = "0x184C24840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly JMMJIJACLCP KFDOLNNLDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> FHMDPOEGNHH;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4830730", Offset = "0x482F930", VA = "0x184830730")]
	public OJOENKKOLHG(JMMJIJACLCP KFDOLNNLDAP, [Optional] IEqualityComparer<TItemId> FHMDPOEGNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2ED0", Offset = "0x4DC20D0", VA = "0x184DC2ED0", Slot = "4")]
	[AsyncStateMachine(typeof(OJOENKKOLHG<, >.MOIPOPBDNBN))]
	public Task<List<TResult>> BPMBMMMOPOG(IReadOnlyList<DPGPJIGOFOK<TItemId>> JHPJFCHDMIL, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JJCADEPBMPG<TRequest, TResult> : JEACFJBDJFL<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> KIIMAINAONP(IEnumerable<TRequest> BPHBMEENFGG, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class FKNLIJNLAPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FKNLIJNLAPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x42F0970", Offset = "0x42EFB70", VA = "0x1842F0970")]
		internal TResult DLEFPNDBMGA(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct DNLPNDLCJBI : IAsyncStateMachine
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
		public JJCADEPBMPG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private FKNLIJNLAPP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6084CA0", Offset = "0x6083EA0", VA = "0x186084CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6085B00", Offset = "0x6084D00", VA = "0x186085B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly KIIMAINAONP KFDOLNNLDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> FHMDPOEGNHH;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4830730", Offset = "0x482F930", VA = "0x184830730")]
	public JJCADEPBMPG(KIIMAINAONP KFDOLNNLDAP, [Optional] IEqualityComparer<TRequest> FHMDPOEGNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x48305F0", Offset = "0x482F7F0", VA = "0x1848305F0", Slot = "4")]
	[AsyncStateMachine(typeof(JJCADEPBMPG<, >.DNLPNDLCJBI))]
	public Task<List<TResult>> BPMBMMMOPOG(IReadOnlyList<TRequest> JHPJFCHDMIL, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JEACFJBDJFL<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> BPMBMMMOPOG(IReadOnlyList<TRequest> JHPJFCHDMIL, CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CIHOAENOPKF<TItemId, TResult> : JEACFJBDJFL<PJAALCKNDGA<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task PJIBNKAEBGE(IReadOnlyDictionary<TItemId, PJAALCKNDGA<TItemId>.KMLEGJGPLAO> JHPJFCHDMIL, CancellationToken BGEKICMONBE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct FDAGKPEOLPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public CIHOAENOPKF<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<PJAALCKNDGA<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x42DDE00", Offset = "0x42DD000", VA = "0x1842DDE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x42DE360", Offset = "0x42DD560", VA = "0x1842DE360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly PJIBNKAEBGE KCLNDFIKFIO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	public CIHOAENOPKF(PJIBNKAEBGE KCLNDFIKFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5797FF0", Offset = "0x57971F0", VA = "0x185797FF0", Slot = "4")]
	[AsyncStateMachine(typeof(CIHOAENOPKF<, >.FDAGKPEOLPA))]
	public Task<List<object>> BPMBMMMOPOG(IReadOnlyList<PJAALCKNDGA<TItemId>> JHPJFCHDMIL, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5798130", Offset = "0x5797330", VA = "0x185798130")]
	private IReadOnlyDictionary<TItemId, PJAALCKNDGA<TItemId>.KMLEGJGPLAO> MCNEKDCIOFH(IReadOnlyList<PJAALCKNDGA<TItemId>> JPLJOEPEJMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LGOENHOEGML<TItemId, TResult> : JEACFJBDJFL<DPGPJIGOFOK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> PLNMPMCAPDO(Dictionary<TItemId, int> JHPJFCHDMIL, CancellationToken BGEKICMONBE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct PDMAIGOLGGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<DPGPJIGOFOK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public LGOENHOEGML<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4F23160", Offset = "0x4F22360", VA = "0x184F23160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4F24AE0", Offset = "0x4F23CE0", VA = "0x184F24AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly PLNMPMCAPDO HMBLPFHJELB;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	public LGOENHOEGML(PLNMPMCAPDO KFDOLNNLDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x49F7030", Offset = "0x49F6230", VA = "0x1849F7030", Slot = "4")]
	[AsyncStateMachine(typeof(LGOENHOEGML<, >.PDMAIGOLGGN))]
	public Task<List<TResult>> BPMBMMMOPOG(IReadOnlyList<DPGPJIGOFOK<TItemId>> JHPJFCHDMIL, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CIJLBLCGGNH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, JHEAKECEBKA> OMECOONAANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> FBHFAGPNJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> HAJAOAOJHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> LGAEGGCIKAB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, JHEAKECEBKA> OLLKLEJCEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> NNEAHIGIDIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IAOBAJFNIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA960C0", Offset = "0xA952C0", VA = "0x180A960C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xB25E10", Offset = "0xB25010", VA = "0x180B25E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x587BCD0", Offset = "0x587AED0", VA = "0x18587BCD0")]
	public CIJLBLCGGNH(Func<IEnumerable<T>> HAJAOAOJHHM, Func<T, string> LGAEGGCIKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x587BA10", Offset = "0x587AC10", VA = "0x18587BA10")]
	public void MEIPIBBEBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x587B980", Offset = "0x587AB80", VA = "0x18587B980", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NEKCAEMCMGC<TItemId, TResult> : KCJPECDKLNK<DPGPJIGOFOK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4C75E00", Offset = "0x4C75000", VA = "0x184C75E00")]
	public NEKCAEMCMGC(JEACFJBDJFL<DPGPJIGOFOK<TItemId>, TResult> BPKJNOFECPK, TimeSpan JAGOFCLFBPA, bool KNLFIJGALFL, [Optional] NCBJLIBIHFL CHFEAEKEACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4C75950", Offset = "0x4C74B50", VA = "0x184C75950")]
	public Task<TResult> OIOGFDBPMNM(TItemId OFPBICPHALF, int OFNKBDKEKAP, [Optional] CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DPGPJIGOFOK<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId PPMIFLKGKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int LLKMHJGPFIN;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x608B080", Offset = "0x608A280", VA = "0x18608B080")]
	public DPGPJIGOFOK(TItemId JLMMKKDGEHI, int OFNKBDKEKAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface EKCBENJINPD<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid PIPBAHFEAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> DFALAIBHBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class ALKJMKFIGEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface BMBDEIMIJGI
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int EHFMPAKCPHH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OOHLNNBEJHM<TParam>(TParam OMEFCJCOLII);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MJNOOFDDEOD(Exception BAFKJPEEDJN);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool CGNMKEHPAGN();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class GKNDKFMOKHD<TResult> : BMBDEIMIJGI, EKCBENJINPD<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> CKCFPDNENEM;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid PIPBAHFEAGH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB00AB0", Offset = "0xAFFCB0", VA = "0x180B00AB0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int EHFMPAKCPHH
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA960C0", Offset = "0xA952C0", VA = "0x180A960C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> DFALAIBHBCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x445BDB0", Offset = "0x445AFB0", VA = "0x18445BDB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x445BE50", Offset = "0x445B050", VA = "0x18445BE50")]
		public GKNDKFMOKHD(int BKGCIDMNMDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x32C9E90", Offset = "0x32C9090", VA = "0x1832C9E90", Slot = "5")]
		public bool OOHLNNBEJHM<TParam>(TParam OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x445BE00", Offset = "0x445B000", VA = "0x18445BE00", Slot = "6")]
		public bool MJNOOFDDEOD(Exception BAFKJPEEDJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x445BD60", Offset = "0x445AF60", VA = "0x18445BD60", Slot = "7")]
		public bool CGNMKEHPAGN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string NKJIBAJCNOD = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, BMBDEIMIJGI> NNPIIDGBOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly GCDBGIBDGCK EDNCCPHLLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool GKLBNDILNAI;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7925F00", Offset = "0x7925100", VA = "0x187925F00")]
	public ALKJMKFIGEB([Optional] GCDBGIBDGCK EDNCCPHLLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7925910", Offset = "0x7924B10", VA = "0x187925910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x39F1950", Offset = "0x39F0B50", VA = "0x1839F1950")]
	public EKCBENJINPD<TResult> FPLOHNEGANA<TResult>(int GHCKICAOACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x39F1C70", Offset = "0x39F0E70", VA = "0x1839F1C70")]
	public bool OOHCOLEKKPH<TResult>(Guid DHNJGGKJENC, TResult NJFLHCEDIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x79257F0", Offset = "0x79249F0", VA = "0x1879257F0")]
	private void CIPBLGEKCGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7925910", Offset = "0x7924B10", VA = "0x187925910")]
	private void KMNAKPIKMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7925A20", Offset = "0x7924C20", VA = "0x187925A20")]
	private void KKJMGKEBBHN(int BKGCIDMNMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7925D00", Offset = "0x7924F00", VA = "0x187925D00")]
	private void OMDBOMILAMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum NAMIMDEOPKM
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PJAALCKNDGA<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KMLEGJGPLAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int APIPNJJEDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int JFMIAHBLJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int DCDGEEAJNOL;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public KMLEGJGPLAO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId PPMIFLKGKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int LLKMHJGPFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NAMIMDEOPKM BELCCOAPOOL;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1BC8AC0", Offset = "0x1BC7CC0", VA = "0x181BC8AC0")]
	public PJAALCKNDGA(TItemId JLMMKKDGEHI, int OFNKBDKEKAP, NAMIMDEOPKM PDEGCFKDOBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OIJDELPKAJL<TItemId, TResult> : KCJPECDKLNK<PJAALCKNDGA<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4DC0070", Offset = "0x4DBF270", VA = "0x184DC0070")]
	public OIJDELPKAJL(JEACFJBDJFL<PJAALCKNDGA<TItemId>, TResult> BPKJNOFECPK, TimeSpan JAGOFCLFBPA, [Optional] NCBJLIBIHFL CHFEAEKEACI)
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

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
public interface MOIDCBPBIEF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MBBBKFEPLHN(int BAJAMGKBKCB, CancellationToken EHAEIHNIHFM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MBBBKFEPLHN(TimeSpan PJJJMOJMGPD, CancellationToken EHAEIHNIHFM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EONPLGMKJCJ : MOIDCBPBIEF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65A25D0", Offset = "0x65A13D0", VA = "0x1865A25D0")]
	[OKINHFAHPEJ(OBFBFIBMGDJ.Root, FNGNILODNLI.GameOnly)]
	private static void JLCIFBCNJPA(LPFNGCMIAEC KDNLDLIFDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	[Preserve]
	public EONPLGMKJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x65A2730", Offset = "0x65A1530", VA = "0x1865A2730", Slot = "4")]
	public Task MBBBKFEPLHN(int BAJAMGKBKCB, CancellationToken EHAEIHNIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x65A26D0", Offset = "0x65A14D0", VA = "0x1865A26D0", Slot = "5")]
	public Task MBBBKFEPLHN(TimeSpan PJJJMOJMGPD, CancellationToken EHAEIHNIHFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FJDCMBCLIHL<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId JAAHOFODONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int HOHPJEKEPDP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x36117B0", Offset = "0x36105B0", VA = "0x1836117B0")]
	public FJDCMBCLIHL(TItemId EICDFNEIANE, int KGANJEKILMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KDOKDMCKGHB<TItemId, TResult> : KMBOIHFKAGE<FJDCMBCLIHL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x36117F0", Offset = "0x36105F0", VA = "0x1836117F0")]
	public KDOKDMCKGHB(MKAOPLNKBBE<FJDCMBCLIHL<TItemId>, TResult> BCAKAGIEHDO, TimeSpan OBNALOJEELG, [Optional] MOIDCBPBIEF MILGEAMJEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3A913E0", Offset = "0x3A901E0", VA = "0x183A913E0")]
	public Task<TResult> JCDOHIHJALN(TItemId IDGIKKEFDCG, int KGANJEKILMM, [Optional] CancellationToken EHAEIHNIHFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KMBOIHFKAGE<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct GJCAGDJCNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest NKFIPHJJMKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> EAGPDPLANKB;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x862170", Offset = "0x860F70", VA = "0x180862170")]
		public GJCAGDJCNEF(TRequest NNOFNOIFPML, TaskCompletionSource<TResult> GIGBONOOALE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct GADMEEMFIFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public KMBOIHFKAGE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x36C7DF0", Offset = "0x36C6BF0", VA = "0x1836C7DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x36C8330", Offset = "0x36C7130", VA = "0x1836C8330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PJDEBMBEAAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public KMBOIHFKAGE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x403AE30", Offset = "0x4039C30", VA = "0x18403AE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x403B200", Offset = "0x403A000", VA = "0x18403B200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct OJFPLJJEBOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KMBOIHFKAGE<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3EF3A20", Offset = "0x3EF2820", VA = "0x183EF3A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3EF3EC0", Offset = "0x3EF2CC0", VA = "0x183EF3EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NPLDBFJCFKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public KMBOIHFKAGE<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3E10120", Offset = "0x3E0EF20", VA = "0x183E10120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3E11060", Offset = "0x3E0FE60", VA = "0x183E11060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MKAOPLNKBBE<TRequest, TResult> BCAKAGIEHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float OBNALOJEELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly MOIDCBPBIEF MILGEAMJEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<GJCAGDJCNEF> IDHJLJHGHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource JLJLHIANCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource KEIEIEFOEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task NDCHNCJCODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float CDBIDIGKGMH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AIJOHIMAHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA512B0", Offset = "0xA500B0", VA = "0x180A512B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA51320", Offset = "0xA50120", VA = "0x180A51320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3AB5630", Offset = "0x3AB4430", VA = "0x183AB5630")]
	public KMBOIHFKAGE(MKAOPLNKBBE<TRequest, TResult> BCAKAGIEHDO, TimeSpan OBNALOJEELG, [Optional] MOIDCBPBIEF MILGEAMJEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3AB4E80", Offset = "0x3AB3C80", VA = "0x183AB4E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3AB5510", Offset = "0x3AB4310", VA = "0x183AB5510")]
	[AsyncStateMachine(typeof(KMBOIHFKAGE<, >.GADMEEMFIFP))]
	public Task<TResult> JCDOHIHJALN(TRequest NNOFNOIFPML, [Optional] CancellationToken EHAEIHNIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3AB4C30", Offset = "0x3AB3A30", VA = "0x183AB4C30")]
	public Task ABJKFIHHNIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3AB5090", Offset = "0x3AB3E90", VA = "0x183AB5090")]
	[AsyncStateMachine(typeof(KMBOIHFKAGE<, >.PJDEBMBEAAJ))]
	private Task EJCFCKKOPJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3AB53F0", Offset = "0x3AB41F0", VA = "0x183AB53F0")]
	[AsyncStateMachine(typeof(KMBOIHFKAGE<, >.OJFPLJJEBOI))]
	private Task HKMPJPIFOGA(CancellationToken EFGFINDLOGH, CancellationToken HABDLDLHJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3AB4CF0", Offset = "0x3AB3AF0", VA = "0x183AB4CF0")]
	[AsyncStateMachine(typeof(KMBOIHFKAGE<, >.NPLDBFJCFKC))]
	private Task BEFGFBDENMC(CancellationToken EHAEIHNIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3AB5320", Offset = "0x3AB4120", VA = "0x183AB5320")]
	private TimeSpan GDGOFNLBMLM()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3AB5210", Offset = "0x3AB4010", VA = "0x183AB5210")]
	private Task<List<TResult>> FFKFJFEOMII(IReadOnlyList<TRequest> FLECHEOJOID, CancellationToken EHAEIHNIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3AB5170", Offset = "0x3AB3F70", VA = "0x183AB5170")]
	private float ELLFBKICKCA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3AB4DF0", Offset = "0x3AB3BF0", VA = "0x183AB4DF0")]
	private void COCIEHFKGPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PHOMNCIBLON<TItemId, TResult> : MKAOPLNKBBE<FJDCMBCLIHL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> MBEJOPDNNCB(Dictionary<TItemId, int> FLECHEOJOID, CancellationToken EHAEIHNIHFM);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MJDCNOAOECL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public MJDCNOAOECL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3D71350", Offset = "0x3D70150", VA = "0x183D71350")]
		internal TResult CGIPCNIABHJ(FJDCMBCLIHL<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct JBBGEANPFAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<FJDCMBCLIHL<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public PHOMNCIBLON<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private MJDCNOAOECL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x399F4D0", Offset = "0x399E2D0", VA = "0x18399F4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x39A0220", Offset = "0x399F020", VA = "0x1839A0220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly MBEJOPDNNCB ELELFIAFFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> FIJEPNBNICC;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3621EA0", Offset = "0x3620CA0", VA = "0x183621EA0")]
	public PHOMNCIBLON(MBEJOPDNNCB ELELFIAFFKC, [Optional] IEqualityComparer<TItemId> FIJEPNBNICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4022180", Offset = "0x4020F80", VA = "0x184022180", Slot = "4")]
	[AsyncStateMachine(typeof(PHOMNCIBLON<, >.JBBGEANPFAD))]
	public Task<List<TResult>> NLPLHLIAGIN(IReadOnlyList<FJDCMBCLIHL<TItemId>> FLECHEOJOID, CancellationToken EHAEIHNIHFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FMCPFPAENPP<TRequest, TResult> : MKAOPLNKBBE<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> GGJLCHEACFP(IEnumerable<TRequest> AFOBCMCDEPI, CancellationToken EHAEIHNIHFM);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class CICNJKIAKFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public CICNJKIAKFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3813410", Offset = "0x3812210", VA = "0x183813410")]
		internal TResult CGIPCNIABHJ(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct NACKNLPONDP : IAsyncStateMachine
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
		public FMCPFPAENPP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private CICNJKIAKFB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3DE40C0", Offset = "0x3DE2EC0", VA = "0x183DE40C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4EF0", Offset = "0x3DE3CF0", VA = "0x183DE4EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly GGJLCHEACFP ELELFIAFFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> FIJEPNBNICC;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3621EA0", Offset = "0x3620CA0", VA = "0x183621EA0")]
	public FMCPFPAENPP(GGJLCHEACFP ELELFIAFFKC, [Optional] IEqualityComparer<TRequest> FIJEPNBNICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3621D50", Offset = "0x3620B50", VA = "0x183621D50", Slot = "4")]
	[AsyncStateMachine(typeof(FMCPFPAENPP<, >.NACKNLPONDP))]
	public Task<List<TResult>> NLPLHLIAGIN(IReadOnlyList<TRequest> FLECHEOJOID, CancellationToken EHAEIHNIHFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MKAOPLNKBBE<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> NLPLHLIAGIN(IReadOnlyList<TRequest> FLECHEOJOID, CancellationToken EHAEIHNIHFM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IMDBHOEMFID<TItemId, TResult> : MKAOPLNKBBE<COMIOPDOOOG<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task HBGGBIKEGBL(IReadOnlyDictionary<TItemId, COMIOPDOOOG<TItemId>.PCJIGBJIEEK> FLECHEOJOID, CancellationToken EHAEIHNIHFM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct KJHFONOPGDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IMDBHOEMFID<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IReadOnlyList<COMIOPDOOOG<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3AA97C0", Offset = "0x3AA85C0", VA = "0x183AA97C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9CF0", Offset = "0x3AA8AF0", VA = "0x183AA9CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly HBGGBIKEGBL MCKNFGMLGLD;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x791D40", Offset = "0x790B40", VA = "0x180791D40")]
	public IMDBHOEMFID(HBGGBIKEGBL MCKNFGMLGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3814500", Offset = "0x3813300", VA = "0x183814500", Slot = "4")]
	[AsyncStateMachine(typeof(IMDBHOEMFID<, >.KJHFONOPGDN))]
	public Task<List<object>> NLPLHLIAGIN(IReadOnlyList<COMIOPDOOOG<TItemId>> FLECHEOJOID, CancellationToken EHAEIHNIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3814090", Offset = "0x3812E90", VA = "0x183814090")]
	private IReadOnlyDictionary<TItemId, COMIOPDOOOG<TItemId>.PCJIGBJIEEK> HJLGJDNNOME(IReadOnlyList<COMIOPDOOOG<TItemId>> BILOMKOALPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IEPCCBEPNLN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Dictionary<string, OHODIPFGKMP> NAJAICAJOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private List<T> ECOBNPAKAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private Func<IEnumerable<T>> FOCBPLNIAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Func<T, string> JCDKPGMBGDF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, OHODIPFGKMP> LILADGOIMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> KGJEIDCKBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GMLLBOKBGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFC0", Offset = "0x8BDDC0", VA = "0x1808BEFC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFA0", Offset = "0x8BDDA0", VA = "0x1808BEFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3800D40", Offset = "0x37FFB40", VA = "0x183800D40")]
	public IEPCCBEPNLN(Func<IEnumerable<T>> FOCBPLNIAMM, Func<T, string> JCDKPGMBGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3800AC0", Offset = "0x37FF8C0", VA = "0x183800AC0")]
	public void KBHDIJCCCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3800A50", Offset = "0x37FF850", VA = "0x183800A50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KMAHDNPDIAE<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid NHPGCGJFGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> OOCHCPLCFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JAFDGLPNKNO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private interface LDPKIPMCPGI
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int MGIBEKDHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool AEKHPCFKJIO<TParam>(TParam MBDKMNBCLGF);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ADLDOANJGCC(Exception PNLFFEACIKO);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool PAOJIMJNOBC();
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class KMIPKMFJEIP<TResult> : LDPKIPMCPGI, KMAHDNPDIAE<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly TaskCompletionSource<TResult> GMPCAFNHKHF;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid NHPGCGJFGPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xB5EDE0", Offset = "0xB5DBE0", VA = "0x180B5EDE0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int MGIBEKDHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8BEFC0", Offset = "0x8BDDC0", VA = "0x1808BEFC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> OOCHCPLCFIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x38096B0", Offset = "0x38084B0", VA = "0x1838096B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5930", Offset = "0x3AB4730", VA = "0x183AB5930")]
		public KMIPKMFJEIP(int IAIPOFKKJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x23025B0", Offset = "0x23013B0", VA = "0x1823025B0", Slot = "5")]
		public bool AEKHPCFKJIO<TParam>(TParam MBDKMNBCLGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3AB58B0", Offset = "0x3AB46B0", VA = "0x183AB58B0", Slot = "6")]
		public bool ADLDOANJGCC(Exception PNLFFEACIKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3AB58F0", Offset = "0x3AB46F0", VA = "0x183AB58F0", Slot = "7")]
		public bool PAOJIMJNOBC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public const string BBKLDIJHBPA = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<Guid, LDPKIPMCPGI> JIEMAHOJONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly OLJBNEPEJHF KOBGFNILBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool JJELJPKIGBA;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x65A2EB0", Offset = "0x65A1CB0", VA = "0x1865A2EB0")]
	public JAFDGLPNKNO([Optional] OLJBNEPEJHF KOBGFNILBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x65A28B0", Offset = "0x65A16B0", VA = "0x1865A28B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x25FD0B0", Offset = "0x25FBEB0", VA = "0x1825FD0B0")]
	public KMAHDNPDIAE<TResult> IOJJBLCABGB<TResult>(int KHMDCHJLOGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x25FCD80", Offset = "0x25FBB80", VA = "0x1825FCD80")]
	public bool HCJPOONHDHB<TResult>(Guid PBIEFOHLMOM, TResult ADPBDOHMAGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x65A2790", Offset = "0x65A1590", VA = "0x1865A2790")]
	private void AEEECFBODIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x65A28B0", Offset = "0x65A16B0", VA = "0x1865A28B0")]
	private void PBLBKGONHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x65A2BC0", Offset = "0x65A19C0", VA = "0x1865A2BC0")]
	private void IMHPIPPGAFN(int IAIPOFKKJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x65A29C0", Offset = "0x65A17C0", VA = "0x1865A29C0")]
	private void HLPPLOABPBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum CILOMOJCEJM
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class COMIOPDOOOG<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class PCJIGBJIEEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int MDANGMLEFBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int HAMACAICHHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int ENAFNAGCJPM;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public PCJIGBJIEEK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId JAAHOFODONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int HOHPJEKEPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public CILOMOJCEJM AGMINODLDDF;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xE49110", Offset = "0xE47F10", VA = "0x180E49110")]
	public COMIOPDOOOG(TItemId EICDFNEIANE, int KGANJEKILMM, CILOMOJCEJM LGDFGELLOEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class FJEDJIDGJJC<TItemId, TResult> : KMBOIHFKAGE<COMIOPDOOOG<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x36117F0", Offset = "0x36105F0", VA = "0x1836117F0")]
	public FJEDJIDGJJC(MKAOPLNKBBE<COMIOPDOOOG<TItemId>, TResult> BCAKAGIEHDO, TimeSpan OBNALOJEELG, [Optional] MOIDCBPBIEF MILGEAMJEEF)
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

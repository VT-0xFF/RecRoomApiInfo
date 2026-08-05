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
public interface EDHFFAGGJHA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MBNIJONADHI(TimeSpan GNBIJHNLJEI, CancellationToken ELGJALILGJE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GJLGHGGEOMH : EDHFFAGGJHA
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x61EF260", Offset = "0x61EE660", VA = "0x1861EF260")]
	[JMHDKPKEECF(POEFLILDONI.Root, OPIGPDFNEON.GameOnly)]
	private static void GOPHCAAEPOM(HLDKHDLHDPB KBPJCNHNBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	[Preserve]
	public GJLGHGGEOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61EF360", Offset = "0x61EE760", VA = "0x1861EF360", Slot = "4")]
	public Task MBNIJONADHI(TimeSpan GNBIJHNLJEI, CancellationToken ELGJALILGJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NDAEKDMHHLH<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId JLEPBBFCEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int FFCBELJLGFB;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3BFCC40", Offset = "0x3BFC040", VA = "0x183BFCC40")]
	public NDAEKDMHHLH(TItemId KDMGAMDJICD, int FLGDHEOGACH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IMJNJLLGHOP<TItemId, TResult> : HAKANADNINP<NDAEKDMHHLH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3687E30", Offset = "0x3687230", VA = "0x183687E30")]
	public IMJNJLLGHOP(CKNMJGIMEGH<NDAEKDMHHLH<TItemId>, TResult> JDDMKMOFIGN, TimeSpan PNBIMMGGMBO, [Optional] EDHFFAGGJHA ODJFJBBDDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3687A30", Offset = "0x3686E30", VA = "0x183687A30")]
	public Task<TResult> DJEHPFOBKMM(TItemId DGCJCBHPPBD, int FLGDHEOGACH, [Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HAKANADNINP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct BFPOAMOHAOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest MHGIGOLBFGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> BJIHKCLCODK;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC80", Offset = "0x7EF080", VA = "0x1807EFC80")]
		public BFPOAMOHAOB(TRequest PLGCCHMKBMF, TaskCompletionSource<TResult> EGFDEDAHBLI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct KAKPCMIJBFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public HAKANADNINP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x38A81F0", Offset = "0x38A75F0", VA = "0x1838A81F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x38A86F0", Offset = "0x38A7AF0", VA = "0x1838A86F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PEAJJMAELEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public HAKANADNINP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0A70", Offset = "0x3DBFE70", VA = "0x183DC0A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0E40", Offset = "0x3DC0240", VA = "0x183DC0E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct MJENHCBABNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public HAKANADNINP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0940", Offset = "0x3BAFD40", VA = "0x183BB0940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0DE0", Offset = "0x3BB01E0", VA = "0x183BB0DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BHKPPHIEPKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public HAKANADNINP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private List<TaskCompletionSource<TResult>> <taskCompletionSources>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x483F000", Offset = "0x483E400", VA = "0x18483F000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x483FF40", Offset = "0x483F340", VA = "0x18483FF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CKNMJGIMEGH<TRequest, TResult> JDDMKMOFIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float PNBIMMGGMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly EDHFFAGGJHA ODJFJBBDDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<BFPOAMOHAOB> PNELFOMKGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource FFJMBDKAEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource PFCMIDHKJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task MEAHOACKBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float HNHOANILPFB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GHLFCACBCML
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x998610", Offset = "0x997A10", VA = "0x180998610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x998AA0", Offset = "0x997EA0", VA = "0x180998AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x35298F0", Offset = "0x3528CF0", VA = "0x1835298F0")]
	public HAKANADNINP(CKNMJGIMEGH<TRequest, TResult> JDDMKMOFIGN, TimeSpan PNBIMMGGMBO, [Optional] EDHFFAGGJHA ODJFJBBDDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3529280", Offset = "0x3528680", VA = "0x183529280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3529080", Offset = "0x3528480", VA = "0x183529080")]
	[AsyncStateMachine(typeof(HAKANADNINP<, >.KAKPCMIJBFG))]
	public Task<TResult> DJEHPFOBKMM(TRequest PLGCCHMKBMF, [Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3528EF0", Offset = "0x35282F0", VA = "0x183528EF0")]
	public Task AIILHHNOGBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x35291A0", Offset = "0x35285A0", VA = "0x1835291A0")]
	[AsyncStateMachine(typeof(HAKANADNINP<, >.PEAJJMAELEP))]
	private Task DMCAMABKOOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x35296D0", Offset = "0x3528AD0", VA = "0x1835296D0")]
	[AsyncStateMachine(typeof(HAKANADNINP<, >.MJENHCBABNK))]
	private Task IJBPJILEABI(CancellationToken MFKCOPHOOJJ, CancellationToken IJNPOAMCMEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x35297F0", Offset = "0x3528BF0", VA = "0x1835297F0")]
	[AsyncStateMachine(typeof(HAKANADNINP<, >.BHKPPHIEPKD))]
	private Task NEDEABBJHAJ(CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3528FB0", Offset = "0x35283B0", VA = "0x183528FB0")]
	private TimeSpan DGBIEPINLGD()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3529520", Offset = "0x3528920", VA = "0x183529520")]
	private Task<List<TResult>> HIGJOKGEACK(IReadOnlyList<TRequest> JJAIIAGNJLG, CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3529630", Offset = "0x3528A30", VA = "0x183529630")]
	private float IBNEEODHGJG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3529490", Offset = "0x3528890", VA = "0x183529490")]
	private void EBPILBKJMOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JNILKAFLOPK<TItemId, TResult> : CKNMJGIMEGH<NDAEKDMHHLH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> FJMHJIFIMCK(Dictionary<TItemId, int> JJAIIAGNJLG, CancellationToken ELGJALILGJE);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class OMBIMJPEFHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public OMBIMJPEFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7380", Offset = "0x3CF6780", VA = "0x183CF7380")]
		internal TResult MHPAABDJGKK(NDAEKDMHHLH<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CLKLFMMLFOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<NDAEKDMHHLH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public JNILKAFLOPK<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private OMBIMJPEFHF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4AE44E0", Offset = "0x4AE38E0", VA = "0x184AE44E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4AE5230", Offset = "0x4AE4630", VA = "0x184AE5230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly FJMHJIFIMCK DJOKPIJCPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> KHGJGLGLGJN;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x385FC80", Offset = "0x385F080", VA = "0x18385FC80")]
	public JNILKAFLOPK(FJMHJIFIMCK DJOKPIJCPLK, [Optional] IEqualityComparer<TItemId> KHGJGLGLGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x385FB30", Offset = "0x385EF30", VA = "0x18385FB30", Slot = "4")]
	[AsyncStateMachine(typeof(JNILKAFLOPK<, >.CLKLFMMLFOJ))]
	public Task<List<TResult>> NHDEEGBGICE(IReadOnlyList<NDAEKDMHHLH<TItemId>> JJAIIAGNJLG, CancellationToken ELGJALILGJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MPMJHOLAEFE<TRequest, TResult> : CKNMJGIMEGH<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> LMJKLFFGPNL(IEnumerable<TRequest> OIDAPODBKJP, CancellationToken ELGJALILGJE);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class IEMDBBBFKJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public IEMDBBBFKJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x36325A0", Offset = "0x36319A0", VA = "0x1836325A0")]
		internal TResult MHPAABDJGKK(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct PMKCAMOENEO : IAsyncStateMachine
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
		public MPMJHOLAEFE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private IEMDBBBFKJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3E08040", Offset = "0x3E07440", VA = "0x183E08040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3E08E70", Offset = "0x3E08270", VA = "0x183E08E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly LMJKLFFGPNL DJOKPIJCPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> KHGJGLGLGJN;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x385FC80", Offset = "0x385F080", VA = "0x18385FC80")]
	public MPMJHOLAEFE(LMJKLFFGPNL DJOKPIJCPLK, [Optional] IEqualityComparer<TRequest> KHGJGLGLGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3BC1F80", Offset = "0x3BC1380", VA = "0x183BC1F80", Slot = "4")]
	[AsyncStateMachine(typeof(MPMJHOLAEFE<, >.PMKCAMOENEO))]
	public Task<List<TResult>> NHDEEGBGICE(IReadOnlyList<TRequest> JJAIIAGNJLG, CancellationToken ELGJALILGJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JNOFLCNMCNL<TItemId, TResult> : CKNMJGIMEGH<NDAEKDMHHLH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task FNGKDKGCJJG(Dictionary<TItemId, int> JJAIIAGNJLG, CancellationToken ELGJALILGJE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct EOKMMNIFBHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<NDAEKDMHHLH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public JNOFLCNMCNL<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x308E820", Offset = "0x308DC20", VA = "0x18308E820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x308F550", Offset = "0x308E950", VA = "0x18308F550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly FNGKDKGCJJG DJOKPIJCPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly IEqualityComparer<TItemId> KHGJGLGLGJN;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x385FC80", Offset = "0x385F080", VA = "0x18385FC80")]
	public JNOFLCNMCNL(FNGKDKGCJJG DJOKPIJCPLK, [Optional] IEqualityComparer<TItemId> KHGJGLGLGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3860E60", Offset = "0x3860260", VA = "0x183860E60", Slot = "4")]
	[AsyncStateMachine(typeof(JNOFLCNMCNL<, >.EOKMMNIFBHN))]
	public Task<List<TResult>> NHDEEGBGICE(IReadOnlyList<NDAEKDMHHLH<TItemId>> JJAIIAGNJLG, CancellationToken ELGJALILGJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface CKNMJGIMEGH<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> NHDEEGBGICE(IReadOnlyList<TRequest> JJAIIAGNJLG, CancellationToken ELGJALILGJE);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BNEEDNPCFJJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, AHAKEKBAMMH> GDCJBCNLHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> CHJHCEONMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> FMKHMHJOLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> HFCOLCFMMDA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, AHAKEKBAMMH> NAOPGMCAEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> GALFNPFGLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HBMAKGCMPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8124E0", Offset = "0x8118E0", VA = "0x1808124E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8124A0", Offset = "0x8118A0", VA = "0x1808124A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x484FE70", Offset = "0x484F270", VA = "0x18484FE70")]
	public BNEEDNPCFJJ(Func<IEnumerable<T>> FMKHMHJOLMD, Func<T, string> HFCOLCFMMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x484FBF0", Offset = "0x484EFF0", VA = "0x18484FBF0")]
	public void GFEAHGHFDLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DBOCCOENOHE<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid CFKKPMNBGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> DMBOPJMLFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CAFKGMAFMEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private interface GEHIPGOOHED
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int PFCHFPHONJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OPDGCOIICCK<TParam>(TParam EOHMJBFGDPD);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MLLPDILJNJH(Exception LCLIHGHPJEH);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool HHNIJKHLBPF();
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class OCONIMKLHDB<TResult> : GEHIPGOOHED, DBOCCOENOHE<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly TaskCompletionSource<TResult> OAONCJDELIC;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid CFKKPMNBGKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA9D400", Offset = "0xA9C800", VA = "0x180A9D400", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int PFCHFPHONJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8124E0", Offset = "0x8118E0", VA = "0x1808124E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> DMBOPJMLFKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x38401D0", Offset = "0x383F5D0", VA = "0x1838401D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3CE23D0", Offset = "0x3CE17D0", VA = "0x183CE23D0")]
		public OCONIMKLHDB(int BHMHEKAMBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x22D73C0", Offset = "0x22D67C0", VA = "0x1822D73C0", Slot = "5")]
		public bool OPDGCOIICCK<TParam>(TParam EOHMJBFGDPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2390", Offset = "0x3CE1790", VA = "0x183CE2390", Slot = "6")]
		public bool MLLPDILJNJH(Exception LCLIHGHPJEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2350", Offset = "0x3CE1750", VA = "0x183CE2350", Slot = "7")]
		public bool HHNIJKHLBPF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const string KJEFLLLOIGI = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<Guid, GEHIPGOOHED> GLGDAPHHFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly CHKAHLNNFHO GICKFBCPJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool JPBBMGJLNEL;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x61EF190", Offset = "0x61EE590", VA = "0x1861EF190")]
	public CAFKGMAFMEL([Optional] CHKAHLNNFHO GICKFBCPJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x61EEA70", Offset = "0x61EDE70", VA = "0x1861EEA70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x21FE390", Offset = "0x21FD790", VA = "0x1821FE390")]
	public DBOCCOENOHE<TResult> AFDNFLNEAAD<TResult>(int DHKMPOLCDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x21FE630", Offset = "0x21FDA30", VA = "0x1821FE630")]
	public bool GOPJOFBKOPG<TResult>(Guid MFOHKMLGLNE, TResult KNLODAPAGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61EEB80", Offset = "0x61EDF80", VA = "0x1861EEB80")]
	private void FMJMBKMHCLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61EEA70", Offset = "0x61EDE70", VA = "0x1861EEA70")]
	private void FMLDEMLHGAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x61EEEA0", Offset = "0x61EE2A0", VA = "0x1861EEEA0")]
	private void PMCJJNLKEHK(int BHMHEKAMBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x61EECA0", Offset = "0x61EE0A0", VA = "0x1861EECA0")]
	private void HOGMFAKMLLP()
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

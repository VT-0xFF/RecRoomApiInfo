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
public interface PLPMDBBAADF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MGGPBNNDKKD(int EJCNBMEMBLN, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MGGPBNNDKKD(TimeSpan ADBIDGJLDBM, CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GLHKEOJMPBO : PLPMDBBAADF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FA60", Offset = "0x6F5EC60", VA = "0x186F5FA60")]
	[GDGALFJPCGE(JAFPILLCEJB.Root, JMIPDAHBNNG.GameOnly)]
	private static void HDHCDDINGJC(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	[Preserve]
	public GLHKEOJMPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FB60", Offset = "0x6F5ED60", VA = "0x186F5FB60", Slot = "4")]
	public Task MGGPBNNDKKD(int EJCNBMEMBLN, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FBC0", Offset = "0x6F5EDC0", VA = "0x186F5FBC0", Slot = "5")]
	public Task MGGPBNNDKKD(TimeSpan ADBIDGJLDBM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EAJIDNAHJOM<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct BPFHBJGJKPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest JNJEJJKKDEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> ECHABOGBHJB;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAB26B0", Offset = "0xAB18B0", VA = "0x180AB26B0")]
		public BPFHBJGJKPO(TRequest GPCNCGBOPJG, TaskCompletionSource<TResult> KLCFJBFNJKE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct ENGKKMGFNHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EAJIDNAHJOM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3819240", Offset = "0x3818440", VA = "0x183819240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3819740", Offset = "0x3818940", VA = "0x183819740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct JOMLPCPMKJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public EAJIDNAHJOM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x40C87C0", Offset = "0x40C79C0", VA = "0x1840C87C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x40C8BA0", Offset = "0x40C7DA0", VA = "0x1840C8BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct GFLCBMNGFEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EAJIDNAHJOM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7850", Offset = "0x3CC6A50", VA = "0x183CC7850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7D00", Offset = "0x3CC6F00", VA = "0x183CC7D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct EMELBPCJCIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public EAJIDNAHJOM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<TRequest> <requests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x38135E0", Offset = "0x38127E0", VA = "0x1838135E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3814780", Offset = "0x3813980", VA = "0x183814780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly NADHGGNJAIA<TRequest, TResult> ONPDMEDNFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float OKBAOEFNGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PLPMDBBAADF NMDGOANCBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool IEBOBGEAFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<BPFHBJGJKPO> PIHGDJCOIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<BPFHBJGJKPO> HFJKIKCHDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool FKGLGDAFAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource PLEAFOALLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource IEBNLAIAPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task GNPONKHNIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float JNKDCIBDNOO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OJBMAONCMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x856910", Offset = "0x855B10", VA = "0x180856910")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x856B90", Offset = "0x855D90", VA = "0x180856B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x37E4570", Offset = "0x37E3770", VA = "0x1837E4570")]
	public EAJIDNAHJOM(NADHGGNJAIA<TRequest, TResult> ONPDMEDNFFL, TimeSpan OKBAOEFNGDO, bool IEBOBGEAFLJ, [Optional] PLPMDBBAADF NMDGOANCBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x37E3C00", Offset = "0x37E2E00", VA = "0x1837E3C00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x37E3FB0", Offset = "0x37E31B0", VA = "0x1837E3FB0")]
	[AsyncStateMachine(typeof(EAJIDNAHJOM<, >.ENGKKMGFNHC))]
	public Task<TResult> MLEEPEDOGEN(TRequest GPCNCGBOPJG, [Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x37E40D0", Offset = "0x37E32D0", VA = "0x1837E40D0")]
	private void MLEEPEDOGEN(TRequest GPCNCGBOPJG, TaskCompletionSource<TResult> KLCFJBFNJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37E44B0", Offset = "0x37E36B0", VA = "0x1837E44B0")]
	public Task PBPELJPLCKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x37E3A90", Offset = "0x37E2C90", VA = "0x1837E3A90")]
	[AsyncStateMachine(typeof(EAJIDNAHJOM<, >.JOMLPCPMKJH))]
	private Task AGBNDCMJNNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x37E4290", Offset = "0x37E3490", VA = "0x1837E4290")]
	[AsyncStateMachine(typeof(EAJIDNAHJOM<, >.GFLCBMNGFEK))]
	private Task OCJOCMLKFPI(CancellationToken PGFAHLHBLPO, CancellationToken EEHBBENFIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x37E43B0", Offset = "0x37E35B0", VA = "0x1837E43B0")]
	[AsyncStateMachine(typeof(EAJIDNAHJOM<, >.EMELBPCJCIL))]
	private Task OFGGNGOMDOL(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37E3ED0", Offset = "0x37E30D0", VA = "0x1837E3ED0")]
	private TimeSpan JKLPIHJDFOA()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x37E4170", Offset = "0x37E3370", VA = "0x1837E4170")]
	private Task<List<TResult>> NGJEMDMIFGG(IReadOnlyList<TRequest> AEJHJMIIJFA, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37E3E30", Offset = "0x37E3030", VA = "0x1837E3E30")]
	private float GNBANFJBIOP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x37E3B60", Offset = "0x37E2D60", VA = "0x1837E3B60")]
	private void AOPOGPNBBLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HNGDNCJEKII<TItemId, TResult> : NADHGGNJAIA<FPGMBCNNBOH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> OGLMILJFIIC(Dictionary<TItemId, int> AEJHJMIIJFA, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JEJMMKFPJMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public JEJMMKFPJMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x40A82D0", Offset = "0x40A74D0", VA = "0x1840A82D0")]
		internal TResult MGHCGKAKMNM(FPGMBCNNBOH<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct ODODGECFFIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<FPGMBCNNBOH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public HNGDNCJEKII<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private JEJMMKFPJMO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4637C60", Offset = "0x4636E60", VA = "0x184637C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x46389B0", Offset = "0x4637BB0", VA = "0x1846389B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly OGLMILJFIIC JHGDMEFOECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> BPPCHPJNELP;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D43890", Offset = "0x3D42A90", VA = "0x183D43890")]
	public HNGDNCJEKII(OGLMILJFIIC JHGDMEFOECC, [Optional] IEqualityComparer<TItemId> BPPCHPJNELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D435F0", Offset = "0x3D427F0", VA = "0x183D435F0", Slot = "4")]
	[AsyncStateMachine(typeof(HNGDNCJEKII<, >.ODODGECFFIE))]
	public Task<List<TResult>> KHADIFILCEL(IReadOnlyList<FPGMBCNNBOH<TItemId>> AEJHJMIIJFA, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NFBONFNJBKP<TRequest, TResult> : NADHGGNJAIA<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> LMECIEMMLKC(IEnumerable<TRequest> EHKCFCCLPGK, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class MINPGDPOOLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public MINPGDPOOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3B81AA0", Offset = "0x3B80CA0", VA = "0x183B81AA0")]
		internal TResult MGHCGKAKMNM(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct GFHJMJMPDDA : IAsyncStateMachine
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
		public NFBONFNJBKP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private MINPGDPOOLI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6250", Offset = "0x3CC5450", VA = "0x183CC6250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3CC70A0", Offset = "0x3CC62A0", VA = "0x183CC70A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly LMECIEMMLKC JHGDMEFOECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> BPPCHPJNELP;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D43890", Offset = "0x3D42A90", VA = "0x183D43890")]
	public NFBONFNJBKP(LMECIEMMLKC JHGDMEFOECC, [Optional] IEqualityComparer<TRequest> BPPCHPJNELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x451DC30", Offset = "0x451CE30", VA = "0x18451DC30", Slot = "4")]
	[AsyncStateMachine(typeof(NFBONFNJBKP<, >.GFHJMJMPDDA))]
	public Task<List<TResult>> KHADIFILCEL(IReadOnlyList<TRequest> AEJHJMIIJFA, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NADHGGNJAIA<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> KHADIFILCEL(IReadOnlyList<TRequest> AEJHJMIIJFA, CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LKDBCEDBNPD<TItemId, TResult> : NADHGGNJAIA<KGPNOJODBMJ<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task LLLJLOMFHIM(IReadOnlyDictionary<TItemId, KGPNOJODBMJ<TItemId>.GOPHDLKCAAP> AEJHJMIIJFA, CancellationToken MPLGBOFHPLM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct JKMGMDOJJCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LKDBCEDBNPD<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<KGPNOJODBMJ<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x40B9A10", Offset = "0x40B8C10", VA = "0x1840B9A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x40B9F60", Offset = "0x40B9160", VA = "0x1840B9F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly LLLJLOMFHIM BNCNPEBDGEM;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8523E0", VA = "0x1808531E0")]
	public LKDBCEDBNPD(LLLJLOMFHIM BNCNPEBDGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x427CA70", Offset = "0x427BC70", VA = "0x18427CA70", Slot = "4")]
	[AsyncStateMachine(typeof(LKDBCEDBNPD<, >.JKMGMDOJJCO))]
	public Task<List<object>> KHADIFILCEL(IReadOnlyList<KGPNOJODBMJ<TItemId>> AEJHJMIIJFA, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x427C600", Offset = "0x427B800", VA = "0x18427C600")]
	private IReadOnlyDictionary<TItemId, KGPNOJODBMJ<TItemId>.GOPHDLKCAAP> DHEFFEICFAM(IReadOnlyList<KGPNOJODBMJ<TItemId>> MOBGNIKCDIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FKAFIJOAPIH<TItemId, TResult> : NADHGGNJAIA<FPGMBCNNBOH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> HGNPJKAOPPH(Dictionary<TItemId, int> AEJHJMIIJFA, CancellationToken MPLGBOFHPLM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct HHKJGPBKMGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<FPGMBCNNBOH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public FKAFIJOAPIH<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C1A0", Offset = "0x3D2B3A0", VA = "0x183D2C1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3D2DAC0", Offset = "0x3D2CCC0", VA = "0x183D2DAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly HGNPJKAOPPH NBDBPHIFNCD;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8523E0", VA = "0x1808531E0")]
	public FKAFIJOAPIH(HGNPJKAOPPH JHGDMEFOECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3BF66B0", Offset = "0x3BF58B0", VA = "0x183BF66B0", Slot = "4")]
	[AsyncStateMachine(typeof(FKAFIJOAPIH<, >.HHKJGPBKMGI))]
	public Task<List<TResult>> KHADIFILCEL(IReadOnlyList<FPGMBCNNBOH<TItemId>> AEJHJMIIJFA, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class INBKIDNLHKA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, OALIALIPGJK> GBPHBFGAJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> BEODFEMIKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> NEHFDEEPPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> NJHLGBMMEFD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, OALIALIPGJK> DODEALJCMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> NMEJNNBGIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NMDEMIKKBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9B0", Offset = "0x8CCBB0", VA = "0x1808CD9B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8CD840", Offset = "0x8CCA40", VA = "0x1808CD840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5640", Offset = "0x3EE4840", VA = "0x183EE5640")]
	public INBKIDNLHKA(Func<IEnumerable<T>> NEHFDEEPPCE, Func<T, string> NJHLGBMMEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5390", Offset = "0x3EE4590", VA = "0x183EE5390")]
	public void LHGGKPHIKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5300", Offset = "0x3EE4500", VA = "0x183EE5300", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BNFKLKLAMOE<TItemId, TResult> : EAJIDNAHJOM<FPGMBCNNBOH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4492200", Offset = "0x4491400", VA = "0x184492200")]
	public BNFKLKLAMOE(NADHGGNJAIA<FPGMBCNNBOH<TItemId>, TResult> ONPDMEDNFFL, TimeSpan OKBAOEFNGDO, bool IEBOBGEAFLJ, [Optional] PLPMDBBAADF NMDGOANCBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4E878A0", Offset = "0x4E86AA0", VA = "0x184E878A0")]
	public Task<TResult> MLEEPEDOGEN(TItemId NDDCLPHCEEO, int KOIONGLECCC, [Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FPGMBCNNBOH<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId MDPBNJOFNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int OPGNICBMDIN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3C1B820", Offset = "0x3C1AA20", VA = "0x183C1B820")]
	public FPGMBCNNBOH(TItemId MBMAMAGGEJL, int KOIONGLECCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HEOPIKMMDOC<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid BCGKIOLOHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> BFILLPLPPPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MKBILIICJCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface PLGIJJCDBGE
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int IHDNFEIBGPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IPMKHCBJKLK<TParam>(TParam JMDCGOKJIDA);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool FDKKINDOJEC(Exception HBEPHPNHPNB);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool MAJPIBDFKFG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class EIIAIFJIBKA<TResult> : PLGIJJCDBGE, HEOPIKMMDOC<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> HGLIGDFKLOI;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid BCGKIOLOHAM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8C9BF0", Offset = "0x8C8DF0", VA = "0x1808C9BF0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int IHDNFEIBGPP
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8CD9B0", Offset = "0x8CCBB0", VA = "0x1808CD9B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> BFILLPLPPPF
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x37F4040", Offset = "0x37F3240", VA = "0x1837F4040", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x37F4130", Offset = "0x37F3330", VA = "0x1837F4130")]
		public EIIAIFJIBKA(int BGAEOEEPOOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x29DB3F0", Offset = "0x29DA5F0", VA = "0x1829DB3F0", Slot = "5")]
		public bool IPMKHCBJKLK<TParam>(TParam JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x37F4090", Offset = "0x37F3290", VA = "0x1837F4090", Slot = "6")]
		public bool FDKKINDOJEC(Exception HBEPHPNHPNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x37F40E0", Offset = "0x37F32E0", VA = "0x1837F40E0", Slot = "7")]
		public bool MAJPIBDFKFG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string AOOKDDPOBKL = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, PLGIJJCDBGE> MGANGFBAOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly LEOIMLDMMEB BNGOHIBLGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool MGDEHOJNEIO;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F60330", Offset = "0x6F5F530", VA = "0x186F60330")]
	public MKBILIICJCI([Optional] LEOIMLDMMEB BNGOHIBLGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FC20", Offset = "0x6F5EE20", VA = "0x186F5FC20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2C39130", Offset = "0x2C38330", VA = "0x182C39130")]
	public HEOPIKMMDOC<TResult> OCBLEGKNHHO<TResult>(int AJDOJBNJPNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2C38DD0", Offset = "0x2C37FD0", VA = "0x182C38DD0")]
	public bool CLEFINOLCOA<TResult>(Guid KPMGFINBLBG, TResult ADPMAHMCGNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FF30", Offset = "0x6F5F130", VA = "0x186F5FF30")]
	private void LOIAAOJFFID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FC20", Offset = "0x6F5EE20", VA = "0x186F5FC20")]
	private void NIJMANPAPKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F60050", Offset = "0x6F5F250", VA = "0x186F60050")]
	private void PNOBNMOMHBE(int BGAEOEEPOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FD30", Offset = "0x6F5EF30", VA = "0x186F5FD30")]
	private void FHPCFCGCHCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum AEFMEJPDNOE
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KGPNOJODBMJ<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class GOPHDLKCAAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int OMEOFIFEDFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int KHOBNNCBKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int PFFBENGGJII;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public GOPHDLKCAAP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId MDPBNJOFNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int OPGNICBMDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public AEFMEJPDNOE BKLODLGGFPE;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x10E0130", Offset = "0x10DF330", VA = "0x1810E0130")]
	public KGPNOJODBMJ(TItemId MBMAMAGGEJL, int KOIONGLECCC, AEFMEJPDNOE LDPKCIGIIMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MAEIEPMOOAP<TItemId, TResult> : EAJIDNAHJOM<KGPNOJODBMJ<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x447B050", Offset = "0x447A250", VA = "0x18447B050")]
	public MAEIEPMOOAP(NADHGGNJAIA<KGPNOJODBMJ<TItemId>, TResult> ONPDMEDNFFL, TimeSpan OKBAOEFNGDO, [Optional] PLPMDBBAADF NMDGOANCBEB)
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

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
public interface ONKOGFMBJJK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CLBKNDHKIJG(int CKCOJFJBMED, CancellationToken EAPNOLMLMHM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CLBKNDHKIJG(TimeSpan BHNBOGBELCJ, CancellationToken EAPNOLMLMHM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FHDIBBCMJOK : ONKOGFMBJJK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65A08E0", Offset = "0x659F2E0", VA = "0x1865A08E0")]
	[BBBFDPEBAMC(JFAJKKONDHJ.Root, HLEKCCEDPHP.GameOnly)]
	private static void CJBKIPIOHMK(AFDLAPABCDH DFLLKHNKNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	[Preserve]
	public FHDIBBCMJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x65A09E0", Offset = "0x659F3E0", VA = "0x1865A09E0", Slot = "4")]
	public Task CLBKNDHKIJG(int CKCOJFJBMED, CancellationToken EAPNOLMLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x65A0A40", Offset = "0x659F440", VA = "0x1865A0A40", Slot = "5")]
	public Task CLBKNDHKIJG(TimeSpan BHNBOGBELCJ, CancellationToken EAPNOLMLMHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DNGIEEMNEJC<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId ILMNKLBCMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int GAOPBCPPKDB;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4F75140", Offset = "0x4F73B40", VA = "0x184F75140")]
	public DNGIEEMNEJC(TItemId ICJIFJJJIEE, int MIOOHAFKDAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NJNMDOMJPOO<TItemId, TResult> : FAGHKJNEBBH<DNGIEEMNEJC<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x35B3050", Offset = "0x35B1A50", VA = "0x1835B3050")]
	public NJNMDOMJPOO(LECHGFJFCBJ<DNGIEEMNEJC<TItemId>, TResult> GIFILGECOFH, TimeSpan MPAGGKILFGA, [Optional] ONKOGFMBJJK LJCDODHABAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3E7A720", Offset = "0x3E79120", VA = "0x183E7A720")]
	public Task<TResult> MGNPDGBDKBD(TItemId FHLJKJHFEEK, int MIOOHAFKDAG, [Optional] CancellationToken EAPNOLMLMHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FAGHKJNEBBH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct LLIOHPDOHKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest KIDEEJCIBOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> EFBDLPFJFAF;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85EBA0", Offset = "0x85D5A0", VA = "0x18085EBA0")]
		public LLIOHPDOHKH(TRequest GOAJPHFIKLF, TaskCompletionSource<TResult> FFEDDICINOC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JMKBNLICFJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FAGHKJNEBBH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3A55EF0", Offset = "0x3A548F0", VA = "0x183A55EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3A56430", Offset = "0x3A54E30", VA = "0x183A56430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GEKIBJODMOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public FAGHKJNEBBH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x369CC20", Offset = "0x369B620", VA = "0x18369CC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x369CFF0", Offset = "0x369B9F0", VA = "0x18369CFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct CACNJNFDDMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public FAGHKJNEBBH<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4AF3710", Offset = "0x4AF2110", VA = "0x184AF3710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4AF3BB0", Offset = "0x4AF25B0", VA = "0x184AF3BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CGKJDOHONAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public FAGHKJNEBBH<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4BC71B0", Offset = "0x4BC5BB0", VA = "0x184BC71B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4BC80F0", Offset = "0x4BC6AF0", VA = "0x184BC80F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LECHGFJFCBJ<TRequest, TResult> GIFILGECOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float MPAGGKILFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly ONKOGFMBJJK LJCDODHABAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<LLIOHPDOHKH> IHBECGLFHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource CLOIGMNLOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource NGCANFEHOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task HJININDCOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float OAOBIFILFAF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KHGKOOPGFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA52490", Offset = "0xA50E90", VA = "0x180A52490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA52540", Offset = "0xA50F40", VA = "0x180A52540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x35A6B80", Offset = "0x35A5580", VA = "0x1835A6B80")]
	public FAGHKJNEBBH(LECHGFJFCBJ<TRequest, TResult> GIFILGECOFH, TimeSpan MPAGGKILFGA, [Optional] ONKOGFMBJJK LJCDODHABAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x35A62B0", Offset = "0x35A4CB0", VA = "0x1835A62B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x35A6990", Offset = "0x35A5390", VA = "0x1835A6990")]
	[AsyncStateMachine(typeof(FAGHKJNEBBH<, >.JMKBNLICFJH))]
	public Task<TResult> MGNPDGBDKBD(TRequest GOAJPHFIKLF, [Optional] CancellationToken EAPNOLMLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x35A64C0", Offset = "0x35A4EC0", VA = "0x1835A64C0")]
	public Task FPIBCAPBHOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x35A6580", Offset = "0x35A4F80", VA = "0x1835A6580")]
	[AsyncStateMachine(typeof(FAGHKJNEBBH<, >.GEKIBJODMOJ))]
	private Task GBADBABHCDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x35A6770", Offset = "0x35A5170", VA = "0x1835A6770")]
	[AsyncStateMachine(typeof(FAGHKJNEBBH<, >.CACNJNFDDMI))]
	private Task IFLIANMBFIK(CancellationToken KCJFKMBAEKN, CancellationToken JCBHCHKPOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x35A6890", Offset = "0x35A5290", VA = "0x1835A6890")]
	[AsyncStateMachine(typeof(FAGHKJNEBBH<, >.CGKJDOHONAF))]
	private Task JMOEMMDKCNB(CancellationToken EAPNOLMLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x35A6AB0", Offset = "0x35A54B0", VA = "0x1835A6AB0")]
	private TimeSpan PDJKIONICPF()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x35A6660", Offset = "0x35A5060", VA = "0x1835A6660")]
	private Task<List<TResult>> HOMOHDNOKFK(IReadOnlyList<TRequest> GCIIMKLAFFI, CancellationToken EAPNOLMLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x35A6180", Offset = "0x35A4B80", VA = "0x1835A6180")]
	private float ABEPMPMCHMH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x35A6220", Offset = "0x35A4C20", VA = "0x1835A6220")]
	private void BLOFCBHOEOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BLHBCMEMOBB<TItemId, TResult> : LECHGFJFCBJ<DNGIEEMNEJC<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> CJDOHFIMEBO(Dictionary<TItemId, int> GCIIMKLAFFI, CancellationToken EAPNOLMLMHM);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class IKLHDDDHGHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public IKLHDDDHGHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3845C00", Offset = "0x3844600", VA = "0x183845C00")]
		internal TResult DPJPHAHIHAL(DNGIEEMNEJC<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct ILGGGCLBOPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<DNGIEEMNEJC<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public BLHBCMEMOBB<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IKLHDDDHGHP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x38460A0", Offset = "0x3844AA0", VA = "0x1838460A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3846DF0", Offset = "0x38457F0", VA = "0x183846DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly CJDOHFIMEBO BKLIFLDBFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> JOIKBJDLPPP;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x378D7F0", Offset = "0x378C1F0", VA = "0x18378D7F0")]
	public BLHBCMEMOBB(CJDOHFIMEBO BKLIFLDBFKK, [Optional] IEqualityComparer<TItemId> JOIKBJDLPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4811880", Offset = "0x4810280", VA = "0x184811880", Slot = "4")]
	[AsyncStateMachine(typeof(BLHBCMEMOBB<, >.ILGGGCLBOPJ))]
	public Task<List<TResult>> JPNGMECENGC(IReadOnlyList<DNGIEEMNEJC<TItemId>> GCIIMKLAFFI, CancellationToken EAPNOLMLMHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HMHGJJKKDKO<TRequest, TResult> : LECHGFJFCBJ<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> OJCAIACKOCL(IEnumerable<TRequest> CILJIOLHCAG, CancellationToken EAPNOLMLMHM);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class FGEHIBBFPKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public FGEHIBBFPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x35A6E00", Offset = "0x35A5800", VA = "0x1835A6E00")]
		internal TResult DPJPHAHIHAL(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct GIBFPDCPJMO : IAsyncStateMachine
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
		public HMHGJJKKDKO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private FGEHIBBFPKN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x36AD4B0", Offset = "0x36ABEB0", VA = "0x1836AD4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x36AE2E0", Offset = "0x36ACCE0", VA = "0x1836AE2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly OJCAIACKOCL BKLIFLDBFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> JOIKBJDLPPP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x378D7F0", Offset = "0x378C1F0", VA = "0x18378D7F0")]
	public HMHGJJKKDKO(OJCAIACKOCL BKLIFLDBFKK, [Optional] IEqualityComparer<TRequest> JOIKBJDLPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x378D6A0", Offset = "0x378C0A0", VA = "0x18378D6A0", Slot = "4")]
	[AsyncStateMachine(typeof(HMHGJJKKDKO<, >.GIBFPDCPJMO))]
	public Task<List<TResult>> JPNGMECENGC(IReadOnlyList<TRequest> GCIIMKLAFFI, CancellationToken EAPNOLMLMHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LECHGFJFCBJ<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> JPNGMECENGC(IReadOnlyList<TRequest> GCIIMKLAFFI, CancellationToken EAPNOLMLMHM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IDHJCMPKDNM<TItemId, TResult> : LECHGFJFCBJ<DBLLCDEBLOG<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task HBKODBJHCCH(IReadOnlyDictionary<TItemId, DBLLCDEBLOG<TItemId>.PCMIINNLBGL> GCIIMKLAFFI, CancellationToken EAPNOLMLMHM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct FFAACAJAGDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IDHJCMPKDNM<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IReadOnlyList<DBLLCDEBLOG<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x35BD4C0", Offset = "0x35BBEC0", VA = "0x1835BD4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x35BD9F0", Offset = "0x35BC3F0", VA = "0x1835BD9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly HBKODBJHCCH ILOIHGCHIFM;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
	public IDHJCMPKDNM(HBKODBJHCCH ILOIHGCHIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x381E6A0", Offset = "0x381D0A0", VA = "0x18381E6A0", Slot = "4")]
	[AsyncStateMachine(typeof(IDHJCMPKDNM<, >.FFAACAJAGDC))]
	public Task<List<object>> JPNGMECENGC(IReadOnlyList<DBLLCDEBLOG<TItemId>> GCIIMKLAFFI, CancellationToken EAPNOLMLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x381E7E0", Offset = "0x381D1E0", VA = "0x18381E7E0")]
	private IReadOnlyDictionary<TItemId, DBLLCDEBLOG<TItemId>.PCMIINNLBGL> PFMOKKBEING(IReadOnlyList<DBLLCDEBLOG<TItemId>> GOBIMLPLPED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OFHBLJDCJAP<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Dictionary<string, MKDPDOBCPKB> OPMGCDMNFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private List<T> DKJPMBHKPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private Func<IEnumerable<T>> KKJOPEJLLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Func<T, string> MLLJPKAKJKP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, MKDPDOBCPKB> GMDENHDHPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> FJILBADOKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CBEEMLCFDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8C1570", Offset = "0x8BFF70", VA = "0x1808C1570")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8C15A0", Offset = "0x8BFFA0", VA = "0x1808C15A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3F7BCF0", Offset = "0x3F7A6F0", VA = "0x183F7BCF0")]
	public OFHBLJDCJAP(Func<IEnumerable<T>> KKJOPEJLLKL, Func<T, string> MLLJPKAKJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3F7BA00", Offset = "0x3F7A400", VA = "0x183F7BA00")]
	public void ADFCFFECPNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3F7BC80", Offset = "0x3F7A680", VA = "0x183F7BC80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface IJLEHNEEANL<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid HOEBIKPLAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> JOLLIIILPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JIEOOEKAKBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private interface ADBCCEJINAE
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int OGGKCDAPEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool JDKLLGDDBDO<TParam>(TParam BEEGCHJLJFC);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool EJOOPMOICGO(Exception IMCCCAHFJAM);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool IFLFEOBJCEG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class JCDDLJLGHIH<TResult> : ADBCCEJINAE, IJLEHNEEANL<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly TaskCompletionSource<TResult> FMHAMHEBBNI;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid HOEBIKPLAOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xB51900", Offset = "0xB50300", VA = "0x180B51900", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int OGGKCDAPEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8C1570", Offset = "0x8BFF70", VA = "0x1808C1570", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> JOLLIIILPFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x39F0E00", Offset = "0x39EF800", VA = "0x1839F0E00", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x39F0E40", Offset = "0x39EF840", VA = "0x1839F0E40")]
		public JCDDLJLGHIH(int FDANOEOJMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x21B89F0", Offset = "0x21B73F0", VA = "0x1821B89F0", Slot = "5")]
		public bool JDKLLGDDBDO<TParam>(TParam BEEGCHJLJFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x39F0D80", Offset = "0x39EF780", VA = "0x1839F0D80", Slot = "6")]
		public bool EJOOPMOICGO(Exception IMCCCAHFJAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x39F0DC0", Offset = "0x39EF7C0", VA = "0x1839F0DC0", Slot = "7")]
		public bool IFLFEOBJCEG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public const string FJKGGFKMELE = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<Guid, ADBCCEJINAE> ENDICJKDPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly BOLBDDKHKMD IOPOHIGPDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool ENPCHDHMKOD;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x65A11C0", Offset = "0x659FBC0", VA = "0x1865A11C0")]
	public JIEOOEKAKBE([Optional] BOLBDDKHKMD IOPOHIGPDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x65A0AA0", Offset = "0x659F4A0", VA = "0x1865A0AA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x267A170", Offset = "0x2678B70", VA = "0x18267A170")]
	public IJLEHNEEANL<TResult> NNANMHHCCNB<TResult>(int MEPNECECPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2679E40", Offset = "0x2678840", VA = "0x182679E40")]
	public bool HAIOLPDBFIP<TResult>(Guid DOHIAACOOFD, TResult JHJJOGFODKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x65A0DB0", Offset = "0x659F7B0", VA = "0x1865A0DB0")]
	private void LDLICDCHBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x65A0AA0", Offset = "0x659F4A0", VA = "0x1865A0AA0")]
	private void ANACLIFFKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x65A0ED0", Offset = "0x659F8D0", VA = "0x1865A0ED0")]
	private void PIKKADMIMNH(int FDANOEOJMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x65A0BB0", Offset = "0x659F5B0", VA = "0x1865A0BB0")]
	private void GNCOKBCKHIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum IKINEAOEAKA
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DBLLCDEBLOG<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class PCMIINNLBGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int FCJFEENCLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int LIMBFFFPNCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int BLBCNKDBDFG;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public PCMIINNLBGL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId ILMNKLBCMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int GAOPBCPPKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public IKINEAOEAKA GGGOHGELALE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xE47DD0", Offset = "0xE467D0", VA = "0x180E47DD0")]
	public DBLLCDEBLOG(TItemId ICJIFJJJIEE, int MIOOHAFKDAG, IKINEAOEAKA DMOGDONOGKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class FEHGCNIFAHE<TItemId, TResult> : FAGHKJNEBBH<DBLLCDEBLOG<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x35B3050", Offset = "0x35B1A50", VA = "0x1835B3050")]
	public FEHGCNIFAHE(LECHGFJFCBJ<DBLLCDEBLOG<TItemId>, TResult> GIFILGECOFH, TimeSpan MPAGGKILFGA, [Optional] ONKOGFMBJJK LJCDODHABAC)
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

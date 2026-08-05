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
public interface LPNDOFBKEPA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AIHPJFMDKCK(TimeSpan HAAFLCNEPHB, CancellationToken NCEIDHNHODH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PAHGMCIKDEB : LPNDOFBKEPA
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x61FFC60", Offset = "0x61FE460", VA = "0x1861FFC60")]
	[OPPPCFMOGOO(CODKNAAEMCD.Root, OIAOEFLOJIJ.GameOnly)]
	private static void HMIMLLFNGCM(MPCHBJGCNBP DJDFFLPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	[Preserve]
	public PAHGMCIKDEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61FFC00", Offset = "0x61FE400", VA = "0x1861FFC00", Slot = "4")]
	public Task AIHPJFMDKCK(TimeSpan HAAFLCNEPHB, CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PFPOBGDCNBL<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId AILJCAPLINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int POIFFPGJLBH;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3E7D960", Offset = "0x3E7C160", VA = "0x183E7D960")]
	public PFPOBGDCNBL(TItemId ABNCJPFEFNI, int AEAFBBMJPKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KDAEPDCDMBI<TItemId, TResult> : GAEFIPFLHNF<PFPOBGDCNBL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x35A1170", Offset = "0x359F970", VA = "0x1835A1170")]
	public KDAEPDCDMBI(IPJFKFIHAOK<PFPOBGDCNBL<TItemId>, TResult> DEDOIPOJCFJ, TimeSpan DNBEFOFNFPJ, [Optional] LPNDOFBKEPA PBLPFNLHBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x388D790", Offset = "0x388BF90", VA = "0x18388D790")]
	public Task<TResult> EJPCGLKKDKH(TItemId EBICOEDOGKC, int AEAFBBMJPKI, [Optional] CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GAEFIPFLHNF<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct EKJOECFLOOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest NNAEHGBDOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> MIJPAPLFCAK;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F41F0", Offset = "0x7F29F0", VA = "0x1807F41F0")]
		public EKJOECFLOOB(TRequest FDOGBBKMGKO, TaskCompletionSource<TResult> NNCNDINJHAB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LMLBHGGIBBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public GAEFIPFLHNF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x39BFF70", Offset = "0x39BE770", VA = "0x1839BFF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x39C0470", Offset = "0x39BEC70", VA = "0x1839C0470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct FGLDPJFDJGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public GAEFIPFLHNF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3388FB0", Offset = "0x33877B0", VA = "0x183388FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3389380", Offset = "0x3387B80", VA = "0x183389380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct LEEEHGFGBPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public GAEFIPFLHNF<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x39960D0", Offset = "0x39948D0", VA = "0x1839960D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3996570", Offset = "0x3994D70", VA = "0x183996570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NDDPHMOEDAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public GAEFIPFLHNF<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3C8F530", Offset = "0x3C8DD30", VA = "0x183C8F530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3C90470", Offset = "0x3C8EC70", VA = "0x183C90470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IPJFKFIHAOK<TRequest, TResult> DEDOIPOJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float DNBEFOFNFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly LPNDOFBKEPA PBLPFNLHBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<EKJOECFLOOB> AIJLCEBPLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource JFMOPADDEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource ELGJONNDGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task MOKAPMJHJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float AAMDDEPMJBN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PLFIBBCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x98F7C0", Offset = "0x98DFC0", VA = "0x18098F7C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x98F4C0", Offset = "0x98DCC0", VA = "0x18098F4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3447780", Offset = "0x3445F80", VA = "0x183447780")]
	public GAEFIPFLHNF(IPJFKFIHAOK<TRequest, TResult> DEDOIPOJCFJ, TimeSpan DNBEFOFNFPJ, [Optional] LPNDOFBKEPA PBLPFNLHBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3446EE0", Offset = "0x34456E0", VA = "0x183446EE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3447180", Offset = "0x3445980", VA = "0x183447180")]
	[AsyncStateMachine(typeof(GAEFIPFLHNF<, >.LMLBHGGIBBA))]
	public Task<TResult> EJPCGLKKDKH(TRequest FDOGBBKMGKO, [Optional] CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3446D80", Offset = "0x3445580", VA = "0x183446D80")]
	public Task AIAJFKNEPJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x34475D0", Offset = "0x3445DD0", VA = "0x1834475D0")]
	[AsyncStateMachine(typeof(GAEFIPFLHNF<, >.FGLDPJFDJGC))]
	private Task OENKDCMJMOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x34474B0", Offset = "0x3445CB0", VA = "0x1834474B0")]
	[AsyncStateMachine(typeof(GAEFIPFLHNF<, >.LEEEHGFGBPH))]
	private Task LJNAKNOKMPN(CancellationToken IMLPHHJCCJM, CancellationToken NONHIHLBBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x34472A0", Offset = "0x3445AA0", VA = "0x1834472A0")]
	[AsyncStateMachine(typeof(GAEFIPFLHNF<, >.NDDPHMOEDAJ))]
	private Task IKGHABPKNLE(CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x34476B0", Offset = "0x3445EB0", VA = "0x1834476B0")]
	private TimeSpan PHMICEJMFGE()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x34473A0", Offset = "0x3445BA0", VA = "0x1834473A0")]
	private Task<List<TResult>> INPKHNKNJPL(IReadOnlyList<TRequest> HPFBMIPPKKG, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3446E40", Offset = "0x3445640", VA = "0x183446E40")]
	private float DFGPEJGFCNE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x34470F0", Offset = "0x34458F0", VA = "0x1834470F0")]
	private void EFACPCIGNAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NAFKNNLJMME<TItemId, TResult> : IPJFKFIHAOK<PFPOBGDCNBL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> POLDMIKMMEP(Dictionary<TItemId, int> HPFBMIPPKKG, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class GPHMFFOIBMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public GPHMFFOIBMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x34DFA80", Offset = "0x34DE280", VA = "0x1834DFA80")]
		internal TResult MPIOJJGOECG(PFPOBGDCNBL<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct LAPKLGEPDOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<PFPOBGDCNBL<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NAFKNNLJMME<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private GPHMFFOIBMA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x397A260", Offset = "0x3978A60", VA = "0x18397A260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x397AFB0", Offset = "0x39797B0", VA = "0x18397AFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly POLDMIKMMEP OADKIGLEPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> MBCBBAOFINH;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3C8C990", Offset = "0x3C8B190", VA = "0x183C8C990")]
	public NAFKNNLJMME(POLDMIKMMEP OADKIGLEPDP, [Optional] IEqualityComparer<TItemId> MBCBBAOFINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C8C6F0", Offset = "0x3C8AEF0", VA = "0x183C8C6F0", Slot = "4")]
	[AsyncStateMachine(typeof(NAFKNNLJMME<, >.LAPKLGEPDOP))]
	public Task<List<TResult>> OFHIPAAPMOD(IReadOnlyList<PFPOBGDCNBL<TItemId>> HPFBMIPPKKG, CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DEAFIIHCIGE<TRequest, TResult> : IPJFKFIHAOK<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> OCEDHMOBPFC(IEnumerable<TRequest> HCIIAINGBMK, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class BBCLJLDAMOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public BBCLJLDAMOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3015F40", Offset = "0x3014740", VA = "0x183015F40")]
		internal TResult MPIOJJGOECG(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct KBILOLHGBAH : IAsyncStateMachine
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
		public DEAFIIHCIGE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private BBCLJLDAMOE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x388A620", Offset = "0x3888E20", VA = "0x18388A620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x388B450", Offset = "0x3889C50", VA = "0x18388B450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly OCEDHMOBPFC OADKIGLEPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> MBCBBAOFINH;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3C8C990", Offset = "0x3C8B190", VA = "0x183C8C990")]
	public DEAFIIHCIGE(OCEDHMOBPFC OADKIGLEPDP, [Optional] IEqualityComparer<TRequest> MBCBBAOFINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4CC9F20", Offset = "0x4CC8720", VA = "0x184CC9F20", Slot = "4")]
	[AsyncStateMachine(typeof(DEAFIIHCIGE<, >.KBILOLHGBAH))]
	public Task<List<TResult>> OFHIPAAPMOD(IReadOnlyList<TRequest> HPFBMIPPKKG, CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IPJFKFIHAOK<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> OFHIPAAPMOD(IReadOnlyList<TRequest> HPFBMIPPKKG, CancellationToken NCEIDHNHODH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HDKLLBMCHMM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private Dictionary<string, IJIOFCOGOFL> FANPENIFMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private List<T> DCFODGBNELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Func<IEnumerable<T>> CBKJHIEHOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private Func<T, string> GOOHJBHNMCI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, IJIOFCOGOFL> JKEPLICNPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> IPIDGKLBMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IJKFPALCFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x807520", Offset = "0x805D20", VA = "0x180807520")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x807500", Offset = "0x805D00", VA = "0x180807500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x35178E0", Offset = "0x35160E0", VA = "0x1835178E0")]
	public HDKLLBMCHMM(Func<IEnumerable<T>> CBKJHIEHOBL, Func<T, string> GOOHJBHNMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3517660", Offset = "0x3515E60", VA = "0x183517660")]
	public void HFBGFFHILGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface JGCNNPLGIAO<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid BNMFAJPLHIH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> PNJPPPKPPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DBIOOFICGHL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private interface DDAOIHHDDLE
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int PPBDBGCILFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PGHNIMDLLHP(object IFKKLLBODIE);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool JOAKJHDEMKA(Exception EIIICLNDLPC);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool DBOMMLJLCOD();
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class KPDPDALKKAN<TResult> : DDAOIHHDDLE, JGCNNPLGIAO<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly TaskCompletionSource<TResult> NAACIMLIADP;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid BNMFAJPLHIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA70070", Offset = "0xA6E870", VA = "0x180A70070", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int PPBDBGCILFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x807520", Offset = "0x805D20", VA = "0x180807520", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> PNJPPPKPPCH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x337C440", Offset = "0x337AC40", VA = "0x18337C440", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x390F5E0", Offset = "0x390DDE0", VA = "0x18390F5E0")]
		public KPDPDALKKAN(int BLIKFKGJKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x390F470", Offset = "0x390DC70", VA = "0x18390F470", Slot = "5")]
		public bool PGHNIMDLLHP(object IFKKLLBODIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x390F140", Offset = "0x390D940", VA = "0x18390F140", Slot = "6")]
		public bool JOAKJHDEMKA(Exception EIIICLNDLPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x390F100", Offset = "0x390D900", VA = "0x18390F100", Slot = "7")]
		public bool DBOMMLJLCOD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public const string FPPLCEECHAB = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly Dictionary<Guid, DDAOIHHDDLE> DENKCICFMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly LMOINEPNPAO DDNKDBHMAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private bool BIMANDGIFAJ;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61FFB30", Offset = "0x61FE330", VA = "0x1861FFB30")]
	public DBIOOFICGHL([Optional] LMOINEPNPAO DDNKDBHMAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x61FF5B0", Offset = "0x61FDDB0", VA = "0x1861FF5B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2228810", Offset = "0x2227010", VA = "0x182228810")]
	public JGCNNPLGIAO<TResult> PGPOKCPMMDC<TResult>(int OBEGIAMINPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61FF6C0", Offset = "0x61FDEC0", VA = "0x1861FF6C0")]
	public bool HCHAINGGLKF(Guid CGNOLEKHOBB, object PGNGICAKGGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x61FF810", Offset = "0x61FE010", VA = "0x1861FF810")]
	private void NIHDDPGJBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x61FF5B0", Offset = "0x61FDDB0", VA = "0x1861FF5B0")]
	private void FHFAHGMMKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x61FF2C0", Offset = "0x61FDAC0", VA = "0x1861FF2C0")]
	private void AGOGNJACJLD(int BLIKFKGJKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x61FF930", Offset = "0x61FE130", VA = "0x1861FF930")]
	private void PCLOGLOBCAG()
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

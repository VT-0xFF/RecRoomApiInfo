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
public interface BKDAEJIBJAK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EBKAIJGKEOA(int EPKKDDHNNOK, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EBKAIJGKEOA(TimeSpan KDEHCIBKPEH, CancellationToken HHBHDBLGMFA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AMINEJFHEDG : BKDAEJIBJAK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6579A90", Offset = "0x6578890", VA = "0x186579A90")]
	[NAAAALLPNIA(KMIEHGCCHON.Root, PBKIGNPNCFO.GameOnly)]
	private static void PMDBOALDHOL(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	[Preserve]
	public AMINEJFHEDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x65799D0", Offset = "0x65787D0", VA = "0x1865799D0", Slot = "4")]
	public Task EBKAIJGKEOA(int EPKKDDHNNOK, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6579A30", Offset = "0x6578830", VA = "0x186579A30", Slot = "5")]
	public Task EBKAIJGKEOA(TimeSpan KDEHCIBKPEH, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BJPDDJNBPHM<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct NHGPCECHJND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest DBCMFELJODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> JIJBEEAGCNM;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x89F0F0", Offset = "0x89DEF0", VA = "0x18089F0F0")]
		public NHGPCECHJND(TRequest MIMLCIHLPAB, TaskCompletionSource<TResult> HNGGKIBECFD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct KEICCMMMCIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public BJPDDJNBPHM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3AA1AF0", Offset = "0x3AA08F0", VA = "0x183AA1AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3AA2030", Offset = "0x3AA0E30", VA = "0x183AA2030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct BDCNIBMLJDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public BJPDDJNBPHM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4663570", Offset = "0x4662370", VA = "0x184663570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4663940", Offset = "0x4662740", VA = "0x184663940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct EDABMKLFBBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public BJPDDJNBPHM<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3229F90", Offset = "0x3228D90", VA = "0x183229F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x322A430", Offset = "0x3229230", VA = "0x18322A430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct LLLDFNFEJBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public BJPDDJNBPHM<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3C12600", Offset = "0x3C11400", VA = "0x183C12600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3C13540", Offset = "0x3C12340", VA = "0x183C13540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly LKBHIOHNENA<TRequest, TResult> KCEKHFGPNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float JHFLPGEFJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BKDAEJIBJAK NBKILBHMBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<NHGPCECHJND> AEEIODJBBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource OBGPLIJOKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource ILEKPKPCFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task PBAEMLJBCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float HHMHEKHLDDL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NJDBJPCDOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA6F310", Offset = "0xA6E110", VA = "0x180A6F310")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA6F040", Offset = "0xA6DE40", VA = "0x180A6F040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x46A85A0", Offset = "0x46A73A0", VA = "0x1846A85A0")]
	public BJPDDJNBPHM(LKBHIOHNENA<TRequest, TResult> KCEKHFGPNGI, TimeSpan JHFLPGEFJFI, [Optional] BKDAEJIBJAK NBKILBHMBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x46A7D70", Offset = "0x46A6B70", VA = "0x1846A7D70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x46A82D0", Offset = "0x46A70D0", VA = "0x1846A82D0")]
	[AsyncStateMachine(typeof(BJPDDJNBPHM<, >.KEICCMMMCIN))]
	public Task<TResult> JGIJDEIBNDK(TRequest MIMLCIHLPAB, [Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x46A7CB0", Offset = "0x46A6AB0", VA = "0x1846A7CB0")]
	public Task DBPIPIGHADE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x46A84C0", Offset = "0x46A72C0", VA = "0x1846A84C0")]
	[AsyncStateMachine(typeof(BJPDDJNBPHM<, >.BDCNIBMLJDA))]
	private Task NIAPHKFAMCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x46A7F80", Offset = "0x46A6D80", VA = "0x1846A7F80")]
	[AsyncStateMachine(typeof(BJPDDJNBPHM<, >.EDABMKLFBBK))]
	private Task EKNMGPALOOK(CancellationToken BLPGPCNEDHB, CancellationToken BCIKPCDBCFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x46A80A0", Offset = "0x46A6EA0", VA = "0x1846A80A0")]
	[AsyncStateMachine(typeof(BJPDDJNBPHM<, >.LLLDFNFEJBC))]
	private Task FIFONKKLIPA(CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x46A83F0", Offset = "0x46A71F0", VA = "0x1846A83F0")]
	private TimeSpan NAFOGFKFEMB()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x46A7BA0", Offset = "0x46A69A0", VA = "0x1846A7BA0")]
	private Task<List<TResult>> BBNGJAKLBBO(IReadOnlyList<TRequest> CMCBMKAJBPJ, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x46A81A0", Offset = "0x46A6FA0", VA = "0x1846A81A0")]
	private float FPPDBEPNKGO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x46A8240", Offset = "0x46A7040", VA = "0x1846A8240")]
	private void HIMKOLIDFML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IMNDCLBLAMO<TItemId, TResult> : LKBHIOHNENA<AFNGIOJHJEF<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> CIGPPPBEFNI(Dictionary<TItemId, int> CMCBMKAJBPJ, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KKMKLGLABPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public KKMKLGLABPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6D50", Offset = "0x3AD5B50", VA = "0x183AD6D50")]
		internal TResult GNMOAJHIFIO(AFNGIOJHJEF<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct IPJPINFGNKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<AFNGIOJHJEF<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public IMNDCLBLAMO<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private KKMKLGLABPF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x387F840", Offset = "0x387E640", VA = "0x18387F840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3880590", Offset = "0x387F390", VA = "0x183880590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly CIGPPPBEFNI BMLMIPOBMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> JGAKNKKHJBJ;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3875A90", Offset = "0x3874890", VA = "0x183875A90")]
	public IMNDCLBLAMO(CIGPPPBEFNI BMLMIPOBMGL, [Optional] IEqualityComparer<TItemId> JGAKNKKHJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38756A0", Offset = "0x38744A0", VA = "0x1838756A0", Slot = "4")]
	[AsyncStateMachine(typeof(IMNDCLBLAMO<, >.IPJPINFGNKF))]
	public Task<List<TResult>> FPPPHMNIJFI(IReadOnlyList<AFNGIOJHJEF<TItemId>> CMCBMKAJBPJ, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JLBFCGFFMGG<TRequest, TResult> : LKBHIOHNENA<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> OAFBHLDDMJH(IEnumerable<TRequest> BALAIOLAJGB, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class NPJHBBKKANP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public NPJHBBKKANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x37069E0", Offset = "0x37057E0", VA = "0x1837069E0")]
		internal TResult GNMOAJHIFIO(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct BFJGGDLKHCC : IAsyncStateMachine
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
		public JLBFCGFFMGG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private NPJHBBKKANP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4675970", Offset = "0x4674770", VA = "0x184675970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x46767A0", Offset = "0x46755A0", VA = "0x1846767A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly OAFBHLDDMJH BMLMIPOBMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> JGAKNKKHJBJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3875A90", Offset = "0x3874890", VA = "0x183875A90")]
	public JLBFCGFFMGG(OAFBHLDDMJH BMLMIPOBMGL, [Optional] IEqualityComparer<TRequest> JGAKNKKHJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3A5BE30", Offset = "0x3A5AC30", VA = "0x183A5BE30", Slot = "4")]
	[AsyncStateMachine(typeof(JLBFCGFFMGG<, >.BFJGGDLKHCC))]
	public Task<List<TResult>> FPPPHMNIJFI(IReadOnlyList<TRequest> CMCBMKAJBPJ, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LKBHIOHNENA<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> FPPPHMNIJFI(IReadOnlyList<TRequest> CMCBMKAJBPJ, CancellationToken HHBHDBLGMFA);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FIPHMKOKBFB<TItemId, TResult> : LKBHIOHNENA<LPGGNLKDAOF<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task GLDECNKKBMA(IReadOnlyDictionary<TItemId, LPGGNLKDAOF<TItemId>.LHEDMMFKFFM> CMCBMKAJBPJ, CancellationToken HHBHDBLGMFA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct LPLHCMNFPHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public FIPHMKOKBFB<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<LPGGNLKDAOF<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3C2C7D0", Offset = "0x3C2B5D0", VA = "0x183C2C7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3C2CD00", Offset = "0x3C2BB00", VA = "0x183C2CD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly GLDECNKKBMA EAMBNEPMMMK;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public FIPHMKOKBFB(GLDECNKKBMA EAMBNEPMMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x35D0D40", Offset = "0x35CFB40", VA = "0x1835D0D40", Slot = "4")]
	[AsyncStateMachine(typeof(FIPHMKOKBFB<, >.LPLHCMNFPHK))]
	public Task<List<object>> FPPPHMNIJFI(IReadOnlyList<LPGGNLKDAOF<TItemId>> CMCBMKAJBPJ, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x35D0E80", Offset = "0x35CFC80", VA = "0x1835D0E80")]
	private IReadOnlyDictionary<TItemId, LPGGNLKDAOF<TItemId>.LHEDMMFKFFM> NPJFDAGKELG(IReadOnlyList<LPGGNLKDAOF<TItemId>> IHFHLALDMIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PGAONLOGMJA<TItemId, TResult> : LKBHIOHNENA<AFNGIOJHJEF<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> COIEHNFHLIG(Dictionary<TItemId, int> CMCBMKAJBPJ, CancellationToken HHBHDBLGMFA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct GKHACLKMHKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<AFNGIOJHJEF<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public PGAONLOGMJA<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x36CB9F0", Offset = "0x36CA7F0", VA = "0x1836CB9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x36CC660", Offset = "0x36CB460", VA = "0x1836CC660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly COIEHNFHLIG KNALIBOHJOF;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public PGAONLOGMJA(COIEHNFHLIG BMLMIPOBMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4042F40", Offset = "0x4041D40", VA = "0x184042F40", Slot = "4")]
	[AsyncStateMachine(typeof(PGAONLOGMJA<, >.GKHACLKMHKI))]
	public Task<List<TResult>> FPPPHMNIJFI(IReadOnlyList<AFNGIOJHJEF<TItemId>> CMCBMKAJBPJ, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class EFAFFCACBOK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, IKAGPFCJJND> BILNBKCMOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> ICMCGENJBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> KGKLGGMJDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> NHDFIHJAIJL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, IKAGPFCJJND> ONJAMNLOIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> HNGFBCIJDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PMCEMDHMDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDA0", Offset = "0x8CABA0", VA = "0x1808CBDA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDC0", Offset = "0x8CABC0", VA = "0x1808CBDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3237FF0", Offset = "0x3236DF0", VA = "0x183237FF0")]
	public EFAFFCACBOK(Func<IEnumerable<T>> KGKLGGMJDKF, Func<T, string> NHDFIHJAIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3237D70", Offset = "0x3236B70", VA = "0x183237D70")]
	public void LLIADGIKINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3237D00", Offset = "0x3236B00", VA = "0x183237D00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AONCABGFHOD<TItemId, TResult> : BJPDDJNBPHM<AFNGIOJHJEF<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x373A860", Offset = "0x3739660", VA = "0x18373A860")]
	public AONCABGFHOD(LKBHIOHNENA<AFNGIOJHJEF<TItemId>, TResult> KCEKHFGPNGI, TimeSpan JHFLPGEFJFI, [Optional] BKDAEJIBJAK NBKILBHMBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x373A700", Offset = "0x3739500", VA = "0x18373A700")]
	public Task<TResult> JGIJDEIBNDK(TItemId JCMGBFKGKLO, int LBCEMAMCEGO, [Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AFNGIOJHJEF<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId BDOGCGGLPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int ACMFCMIODLI;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x36776D0", Offset = "0x36764D0", VA = "0x1836776D0")]
	public AFNGIOJHJEF(TItemId HHJBGBHDCMB, int LBCEMAMCEGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EECNFOEDOCE<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid JJECAHGHHKG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> BEIPKFNIHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BLABNGBIGFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface PPBGOJGHIOD
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int PMALILMNGBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool KAAFLLMKLMB<TParam>(TParam NKKIECLCEML);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ALOJAFEBNFB(Exception IHEECNGJNNF);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool AEIHMLAMGHG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class GOGLCFACAEF<TResult> : PPBGOJGHIOD, EECNFOEDOCE<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> NEJMAEGMNEO;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid JJECAHGHHKG
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB6E440", Offset = "0xB6D240", VA = "0x180B6E440", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int PMALILMNGBG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8CBDA0", Offset = "0x8CABA0", VA = "0x1808CBDA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> BEIPKFNIHPH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x36D6810", Offset = "0x36D5610", VA = "0x1836D6810", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x36D6850", Offset = "0x36D5650", VA = "0x1836D6850")]
		public GOGLCFACAEF(int FOICAEJMAAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x24139C0", Offset = "0x24127C0", VA = "0x1824139C0", Slot = "5")]
		public bool KAAFLLMKLMB<TParam>(TParam NKKIECLCEML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x36D67D0", Offset = "0x36D55D0", VA = "0x1836D67D0", Slot = "6")]
		public bool ALOJAFEBNFB(Exception IHEECNGJNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x36D6790", Offset = "0x36D5590", VA = "0x1836D6790", Slot = "7")]
		public bool AEIHMLAMGHG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string JOANBHKPFMK = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, PPBGOJGHIOD> AADPJIPPEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly OGGLGNECAHK EBBKJHLHIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool NMDNLOENNPG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x657A2B0", Offset = "0x65790B0", VA = "0x18657A2B0")]
	public BLABNGBIGFB([Optional] OGGLGNECAHK EBBKJHLHIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6579D90", Offset = "0x6578B90", VA = "0x186579D90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x24E9B40", Offset = "0x24E8940", VA = "0x1824E9B40")]
	public EECNFOEDOCE<TResult> BCMOOIAENPI<TResult>(int BCMAPCNDEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x24E9DE0", Offset = "0x24E8BE0", VA = "0x1824E9DE0")]
	public bool FFCAOCBCAJK<TResult>(Guid MBCGHBNLJEN, TResult BGCCPJGDEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x657A190", Offset = "0x6578F90", VA = "0x18657A190")]
	private void HHDCNDNAABB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6579D90", Offset = "0x6578B90", VA = "0x186579D90")]
	private void BNEGGPPDKMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6579EA0", Offset = "0x6578CA0", VA = "0x186579EA0")]
	private void CMHHLKJGPPK(int FOICAEJMAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6579B90", Offset = "0x6578990", VA = "0x186579B90")]
	private void ANGJCMDILLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum GDDGNBKMJBP
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LPGGNLKDAOF<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class LHEDMMFKFFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int FKNMFHFOFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int PJGGDJMHOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int JEEEAFJHFDO;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public LHEDMMFKFFM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId BDOGCGGLPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int ACMFCMIODLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public GDDGNBKMJBP BBLDIKMAHBP;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xD7CBD0", Offset = "0xD7B9D0", VA = "0x180D7CBD0")]
	public LPGGNLKDAOF(TItemId HHJBGBHDCMB, int LBCEMAMCEGO, GDDGNBKMJBP DIIPJIMFFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class BLPPGPICCJP<TItemId, TResult> : BJPDDJNBPHM<LPGGNLKDAOF<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x373A860", Offset = "0x3739660", VA = "0x18373A860")]
	public BLPPGPICCJP(LKBHIOHNENA<LPGGNLKDAOF<TItemId>, TResult> KCEKHFGPNGI, TimeSpan JHFLPGEFJFI, [Optional] BKDAEJIBJAK NBKILBHMBFG)
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

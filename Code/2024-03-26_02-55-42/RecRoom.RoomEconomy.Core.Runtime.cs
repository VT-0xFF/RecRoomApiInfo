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
public interface OMJAGPMMLAL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LJKLBPACBFJ(int DHGAGCFNJIL, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LJKLBPACBFJ(TimeSpan FELHDDAIPEP, CancellationToken KNKAEBKAEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IHBMLPEJMBK : OMJAGPMMLAL
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x677D030", Offset = "0x677C430", VA = "0x18677D030")]
	[AMCIKKJLCIB(FDMHFCDINAO.Root, HENHDGEOMOC.GameOnly)]
	private static void EPIAPJMNNFJ(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	[Preserve]
	public IHBMLPEJMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x677D130", Offset = "0x677C530", VA = "0x18677D130", Slot = "4")]
	public Task LJKLBPACBFJ(int DHGAGCFNJIL, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x677D190", Offset = "0x677C590", VA = "0x18677D190", Slot = "5")]
	public Task LJKLBPACBFJ(TimeSpan FELHDDAIPEP, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NMGJKICFAED<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct FBEIJCAMLMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest CJLFMOLDIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> DILKAEOHNBA;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x90E910", Offset = "0x90DD10", VA = "0x18090E910")]
		public FBEIJCAMLMA(TRequest BDAAOBFBLIB, TaskCompletionSource<TResult> IMAIIHOELNA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct GCHCMHPMFNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public NMGJKICFAED<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x37B8130", Offset = "0x37B7530", VA = "0x1837B8130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x37B8670", Offset = "0x37B7A70", VA = "0x1837B8670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GPCBPMKIBOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NMGJKICFAED<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x37F3CC0", Offset = "0x37F30C0", VA = "0x1837F3CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x37F4090", Offset = "0x37F3490", VA = "0x1837F4090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct OAMHOMFGGPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NMGJKICFAED<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x40C2530", Offset = "0x40C1930", VA = "0x1840C2530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x40C29D0", Offset = "0x40C1DD0", VA = "0x1840C29D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct DBHKCEOLNFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public NMGJKICFAED<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x50E4A10", Offset = "0x50E3E10", VA = "0x1850E4A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x50E5950", Offset = "0x50E4D50", VA = "0x1850E5950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly PDENALIHLCL<TRequest, TResult> MEPGKJCHFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float PGGCMCGMJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OMJAGPMMLAL JAMCMNGBIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<FBEIJCAMLMA> EPODIEHPGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource CABFNMGIOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource PJOECHIEJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task LLOHNMFFGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float JOFCIFIEEAM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ILIOJLEOEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB00960", Offset = "0xAFFD60", VA = "0x180B00960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB00540", Offset = "0xAFF940", VA = "0x180B00540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3FDBA00", Offset = "0x3FDAE00", VA = "0x183FDBA00")]
	public NMGJKICFAED(PDENALIHLCL<TRequest, TResult> MEPGKJCHFGP, TimeSpan PGGCMCGMJOC, [Optional] OMJAGPMMLAL JAMCMNGBIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB000", Offset = "0x3FDA400", VA = "0x183FDB000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB4B0", Offset = "0x3FDA8B0", VA = "0x183FDB4B0")]
	[AsyncStateMachine(typeof(NMGJKICFAED<, >.GCHCMHPMFNJ))]
	public Task<TResult> IODIMOPANOG(TRequest BDAAOBFBLIB, [Optional] CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB940", Offset = "0x3FDAD40", VA = "0x183FDB940")]
	public Task OAENFOLFPBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB3D0", Offset = "0x3FDA7D0", VA = "0x183FDB3D0")]
	[AsyncStateMachine(typeof(NMGJKICFAED<, >.GPCBPMKIBOH))]
	private Task GPCOKFNJPKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB2B0", Offset = "0x3FDA6B0", VA = "0x183FDB2B0")]
	[AsyncStateMachine(typeof(NMGJKICFAED<, >.OAMHOMFGGPP))]
	private Task FFJEBGFIFEH(CancellationToken JANAINDHFGD, CancellationToken NLLOEOGJBLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB840", Offset = "0x3FDAC40", VA = "0x183FDB840")]
	[AsyncStateMachine(typeof(NMGJKICFAED<, >.DBHKCEOLNFE))]
	private Task NGOJFHDJHCB(CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB770", Offset = "0x3FDAB70", VA = "0x183FDB770")]
	private TimeSpan MFIKGMOLBNC()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB660", Offset = "0x3FDAA60", VA = "0x183FDB660")]
	private Task<List<TResult>> MBDFGMEFAHF(IReadOnlyList<TRequest> EMIDBDKCONM, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB210", Offset = "0x3FDA610", VA = "0x183FDB210")]
	private float FBNBAMPNMAA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB5D0", Offset = "0x3FDA9D0", VA = "0x183FDB5D0")]
	private void JFICIBKKKAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JOEPHHKMIPK<TItemId, TResult> : PDENALIHLCL<OAOFLDMIJGE<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> HLFEEMOJCPB(Dictionary<TItemId, int> EMIDBDKCONM, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DPCKEKPOAMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public DPCKEKPOAMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x51005C0", Offset = "0x50FF9C0", VA = "0x1851005C0")]
		internal TResult BPPJICKNMDF(OAOFLDMIJGE<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HBIKLJGPGJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<OAOFLDMIJGE<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public JOEPHHKMIPK<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private DPCKEKPOAMB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x383F7E0", Offset = "0x383EBE0", VA = "0x18383F7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3840530", Offset = "0x383F930", VA = "0x183840530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly HLFEEMOJCPB GMOCKNIBHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> BBCPKHJJCDG;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3BAF710", Offset = "0x3BAEB10", VA = "0x183BAF710")]
	public JOEPHHKMIPK(HLFEEMOJCPB GMOCKNIBHHH, [Optional] IEqualityComparer<TItemId> BBCPKHJJCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3BAF5C0", Offset = "0x3BAE9C0", VA = "0x183BAF5C0", Slot = "4")]
	[AsyncStateMachine(typeof(JOEPHHKMIPK<, >.HBIKLJGPGJO))]
	public Task<List<TResult>> ECKBHFLNEDP(IReadOnlyList<OAOFLDMIJGE<TItemId>> EMIDBDKCONM, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KBMMIBCBCAC<TRequest, TResult> : PDENALIHLCL<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> ILOGAEDEGFC(IEnumerable<TRequest> CJMPECHLICD, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class LNHAJBMLNBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public LNHAJBMLNBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3846F80", Offset = "0x3846380", VA = "0x183846F80")]
		internal TResult BPPJICKNMDF(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct IFFFCOBBDEL : IAsyncStateMachine
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
		public KBMMIBCBCAC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private LNHAJBMLNBO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x39A8EC0", Offset = "0x39A82C0", VA = "0x1839A8EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x39A9CF0", Offset = "0x39A90F0", VA = "0x1839A9CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly ILOGAEDEGFC GMOCKNIBHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> BBCPKHJJCDG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3BAF710", Offset = "0x3BAEB10", VA = "0x183BAF710")]
	public KBMMIBCBCAC(ILOGAEDEGFC GMOCKNIBHHH, [Optional] IEqualityComparer<TRequest> BBCPKHJJCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3C65250", Offset = "0x3C64650", VA = "0x183C65250", Slot = "4")]
	[AsyncStateMachine(typeof(KBMMIBCBCAC<, >.IFFFCOBBDEL))]
	public Task<List<TResult>> ECKBHFLNEDP(IReadOnlyList<TRequest> EMIDBDKCONM, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PDENALIHLCL<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> ECKBHFLNEDP(IReadOnlyList<TRequest> EMIDBDKCONM, CancellationToken KNKAEBKAEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FHIEAHMBMOC<TItemId, TResult> : PDENALIHLCL<FMEMEGFCANH<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task OBDFMPKFBEA(IReadOnlyDictionary<TItemId, FMEMEGFCANH<TItemId>.LABECBIBOOE> EMIDBDKCONM, CancellationToken KNKAEBKAEBM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct ICFNKNHKOJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public FHIEAHMBMOC<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<FMEMEGFCANH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3997690", Offset = "0x3996A90", VA = "0x183997690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3997BC0", Offset = "0x3996FC0", VA = "0x183997BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly OBDFMPKFBEA NFAPABHBOKG;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public FHIEAHMBMOC(OBDFMPKFBEA NFAPABHBOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x36DB480", Offset = "0x36DA880", VA = "0x1836DB480", Slot = "4")]
	[AsyncStateMachine(typeof(FHIEAHMBMOC<, >.ICFNKNHKOJL))]
	public Task<List<object>> ECKBHFLNEDP(IReadOnlyList<FMEMEGFCANH<TItemId>> EMIDBDKCONM, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x36DB5C0", Offset = "0x36DA9C0", VA = "0x1836DB5C0")]
	private IReadOnlyDictionary<TItemId, FMEMEGFCANH<TItemId>.LABECBIBOOE> KGHKNELGNED(IReadOnlyList<FMEMEGFCANH<TItemId>> NOLIGOIAGLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OAHCJKDKPOD<TItemId, TResult> : PDENALIHLCL<OAOFLDMIJGE<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> IMLLHNLMGOP(Dictionary<TItemId, int> EMIDBDKCONM, CancellationToken KNKAEBKAEBM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct IAMELCPDLMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<OAOFLDMIJGE<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public OAHCJKDKPOD<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x398DEA0", Offset = "0x398D2A0", VA = "0x18398DEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x398F780", Offset = "0x398EB80", VA = "0x18398F780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IMLLHNLMGOP MCLMMNGNNGI;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public OAHCJKDKPOD(IMLLHNLMGOP GMOCKNIBHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x40C1090", Offset = "0x40C0490", VA = "0x1840C1090", Slot = "4")]
	[AsyncStateMachine(typeof(OAHCJKDKPOD<, >.IAMELCPDLMD))]
	public Task<List<TResult>> ECKBHFLNEDP(IReadOnlyList<OAOFLDMIJGE<TItemId>> EMIDBDKCONM, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DEOPGIJNIBF<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, OKLHFKFOADE> DLMBNDBEFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> FPIILDBEJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> MDIIPJLDAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> BDKHGPDGPAM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, OKLHFKFOADE> HAHLJJIBEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> KMEGBOPOEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LKPBNLLBELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x968FB0", Offset = "0x9683B0", VA = "0x180968FB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x968FD0", Offset = "0x9683D0", VA = "0x180968FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x50EEB40", Offset = "0x50EDF40", VA = "0x1850EEB40")]
	public DEOPGIJNIBF(Func<IEnumerable<T>> MDIIPJLDAJA, Func<T, string> BDKHGPDGPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x50EE8C0", Offset = "0x50EDCC0", VA = "0x1850EE8C0")]
	public void LLBOFPOPBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x50EE850", Offset = "0x50EDC50", VA = "0x1850EE850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MDKFDGHLHKE<TItemId, TResult> : NMGJKICFAED<OAOFLDMIJGE<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0A00", Offset = "0x3EEFE00", VA = "0x183EF0A00")]
	public MDKFDGHLHKE(PDENALIHLCL<OAOFLDMIJGE<TItemId>, TResult> MEPGKJCHFGP, TimeSpan PGGCMCGMJOC, [Optional] OMJAGPMMLAL JAMCMNGBIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF08A0", Offset = "0x3EEFCA0", VA = "0x183EF08A0")]
	public Task<TResult> IODIMOPANOG(TItemId NIOPCMHKLMB, int GEHEIIBAMPL, [Optional] CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OAOFLDMIJGE<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId FJBFINHFEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int ACOOMJODMHG;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x40C2A30", Offset = "0x40C1E30", VA = "0x1840C2A30")]
	public OAOFLDMIJGE(TItemId ONMBMGDMFJD, int GEHEIIBAMPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KBEGNFGDDHI<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid CHLMCJEOFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> IAKHHEALCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class LPHBPIKBHEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface ILEPJMICGPF
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int MNGMOJMLJAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool GAPANAJDDAK<TParam>(TParam PCGOHCLJAPN);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MHJPHGCCOJL(Exception KDFDGCCFNMI);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool COKKAFGJFIB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class EDGEPHDEKGJ<TResult> : ILEPJMICGPF, KBEGNFGDDHI<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> IHMOPGFBBGH;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid CHLMCJEOFAM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8516A0", Offset = "0x850AA0", VA = "0x1808516A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int MNGMOJMLJAF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x968FB0", Offset = "0x9683B0", VA = "0x180968FB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> IAKHHEALCJO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x331E1A0", Offset = "0x331D5A0", VA = "0x18331E1A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x331E220", Offset = "0x331D620", VA = "0x18331E220")]
		public EDGEPHDEKGJ(int GGKEBGCELJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x24AA2C0", Offset = "0x24A96C0", VA = "0x1824AA2C0", Slot = "5")]
		public bool GAPANAJDDAK<TParam>(TParam PCGOHCLJAPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x331E1E0", Offset = "0x331D5E0", VA = "0x18331E1E0", Slot = "6")]
		public bool MHJPHGCCOJL(Exception KDFDGCCFNMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x331E160", Offset = "0x331D560", VA = "0x18331E160", Slot = "7")]
		public bool COKKAFGJFIB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string DJLGILPOEIL = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, ILEPJMICGPF> PLPOGMHJAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly ILNPKPIFBGL MHKOBEBCEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool OFFAALEOJLL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x677D910", Offset = "0x677CD10", VA = "0x18677D910")]
	public LPHBPIKBHEL([Optional] ILNPKPIFBGL MHKOBEBCEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x677D1F0", Offset = "0x677C5F0", VA = "0x18677D1F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2895630", Offset = "0x2894A30", VA = "0x182895630")]
	public KBEGNFGDDHI<TResult> GABJEIIEFGP<TResult>(int LPFCBENMAPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28958D0", Offset = "0x2894CD0", VA = "0x1828958D0")]
	public bool OHCANMPPMBK<TResult>(Guid FHLPBMFOONK, TResult FEADNEEPDLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x677D7F0", Offset = "0x677CBF0", VA = "0x18677D7F0")]
	private void NAOAFBEPFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x677D1F0", Offset = "0x677C5F0", VA = "0x18677D1F0")]
	private void PMOMFLNCNFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x677D300", Offset = "0x677C700", VA = "0x18677D300")]
	private void HOGPMDKAECD(int GGKEBGCELJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x677D5F0", Offset = "0x677C9F0", VA = "0x18677D5F0")]
	private void JODBNDNLNOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum MANLKLEPENF
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FMEMEGFCANH<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class LABECBIBOOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int OFACCFMDIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int IDMIKGLJEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int ELEMLLDCGCD;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public LABECBIBOOE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId FJBFINHFEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int ACOOMJODMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public MANLKLEPENF LGAJCLGDHDJ;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xF076B0", Offset = "0xF06AB0", VA = "0x180F076B0")]
	public FMEMEGFCANH(TItemId ONMBMGDMFJD, int GEHEIIBAMPL, MANLKLEPENF CNGBAHCAJJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class NFGGMOHEKKO<TItemId, TResult> : NMGJKICFAED<FMEMEGFCANH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0A00", Offset = "0x3EEFE00", VA = "0x183EF0A00")]
	public NFGGMOHEKKO(PDENALIHLCL<FMEMEGFCANH<TItemId>, TResult> MEPGKJCHFGP, TimeSpan PGGCMCGMJOC, [Optional] OMJAGPMMLAL JAMCMNGBIEK)
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

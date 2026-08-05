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
public interface PELLCJFABCL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GOHEGIGDMCF(int LHALDIABJIC, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GOHEGIGDMCF(TimeSpan KPJKMABJJFB, CancellationToken AOLOJHLCMLE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class OKGEBEHPDHK : PELLCJFABCL
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E6D0", Offset = "0x6F2D0D0", VA = "0x186F2E6D0")]
	[MHFEIEAPENL(ABEEEPGJOJM.Root, CMFCLNIIIKO.GameOnly)]
	private static void ACIIPLOJHPA(GPECMKAJNMD FOPICBKBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	[Preserve]
	public OKGEBEHPDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E820", Offset = "0x6F2D220", VA = "0x186F2E820", Slot = "4")]
	public Task GOHEGIGDMCF(int LHALDIABJIC, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E7C0", Offset = "0x6F2D1C0", VA = "0x186F2E7C0", Slot = "5")]
	public Task GOHEGIGDMCF(TimeSpan KPJKMABJJFB, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DIFDICAIADL<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct PKEEIPCDMBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest DEEEMHJFILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> PCDILEGHNCH;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6F80", Offset = "0xAA5980", VA = "0x180AA6F80")]
		public PKEEIPCDMBL(TRequest BJLMEIJMPBN, TaskCompletionSource<TResult> CPKLFCGBIPC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct EGPKHLGMAHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public DIFDICAIADL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3848A30", Offset = "0x3847430", VA = "0x183848A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3848F90", Offset = "0x3847990", VA = "0x183848F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct LEIDBOHMFPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public DIFDICAIADL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x426B840", Offset = "0x426A240", VA = "0x18426B840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x426BC20", Offset = "0x426A620", VA = "0x18426BC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct FCIFEFILAAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public DIFDICAIADL<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3BEFA70", Offset = "0x3BEE470", VA = "0x183BEFA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3BEFF20", Offset = "0x3BEE920", VA = "0x183BEFF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct EMJEAPLGLKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DIFDICAIADL<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x386A490", Offset = "0x3868E90", VA = "0x18386A490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x386B4A0", Offset = "0x3869EA0", VA = "0x18386B4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HHBOGEHBJIE<TRequest, TResult> GJMDGEGKHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float FNPGFABPAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PELLCJFABCL JIMEHBJFLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<PKEEIPCDMBL> LDIEALKHGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource ECLMNLCFKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource BCLJCNBKOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task AJKLKCOOKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float IDIJNGGAOGP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FIGHPIBDBNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC49560", Offset = "0xC47F60", VA = "0x180C49560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC49980", Offset = "0xC48380", VA = "0x180C49980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x57C1120", Offset = "0x57BFB20", VA = "0x1857C1120")]
	public DIFDICAIADL(HHBOGEHBJIE<TRequest, TResult> GJMDGEGKHNM, TimeSpan FNPGFABPAPA, [Optional] PELLCJFABCL JIMEHBJFLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x57C0A70", Offset = "0x57BF470", VA = "0x1857C0A70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x57C07B0", Offset = "0x57BF1B0", VA = "0x1857C07B0")]
	[AsyncStateMachine(typeof(DIFDICAIADL<, >.EGPKHLGMAHI))]
	public Task<TResult> CNOPKGEMEMO(TRequest BJLMEIJMPBN, [Optional] CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x57C06F0", Offset = "0x57BF0F0", VA = "0x1857C06F0")]
	public Task AMPPBDBAPKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x57C0E50", Offset = "0x57BF850", VA = "0x1857C0E50")]
	[AsyncStateMachine(typeof(DIFDICAIADL<, >.LEIDBOHMFPN))]
	private Task JNNEOOCOABP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x57C0C90", Offset = "0x57BF690", VA = "0x1857C0C90")]
	[AsyncStateMachine(typeof(DIFDICAIADL<, >.FCIFEFILAAH))]
	private Task EGIPLBIGAIE(CancellationToken DMEBALIKPPL, CancellationToken DHPOMAJNEIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x57C0970", Offset = "0x57BF370", VA = "0x1857C0970")]
	[AsyncStateMachine(typeof(DIFDICAIADL<, >.EMJEAPLGLKH))]
	private Task DMLIPJLCHJP(CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x57C0F20", Offset = "0x57BF920", VA = "0x1857C0F20")]
	private TimeSpan KBCEKJDLJBB()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x57C1000", Offset = "0x57BFA00", VA = "0x1857C1000")]
	private Task<List<TResult>> PGABMLDOFOA(IReadOnlyList<TRequest> KFKIKNHIHCL, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x57C0DB0", Offset = "0x57BF7B0", VA = "0x1857C0DB0")]
	private float GLOADPJEAOJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x57C08D0", Offset = "0x57BF2D0", VA = "0x1857C08D0")]
	private void DCLHPNCAFIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HJJLHPMBMPJ<TItemId, TResult> : HHBOGEHBJIE<KDAFENFLJDJ<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> DEEJBKGBNDC(Dictionary<TItemId, int> KFKIKNHIHCL, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FLGGGGNKFFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public FLGGGGNKFFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3C269C0", Offset = "0x3C253C0", VA = "0x183C269C0")]
		internal TResult LJDHHCGEAGI(KDAFENFLJDJ<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MBGKKMLFFFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<KDAFENFLJDJ<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public HJJLHPMBMPJ<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private FLGGGGNKFFC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x445B910", Offset = "0x445A310", VA = "0x18445B910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x445C670", Offset = "0x445B070", VA = "0x18445C670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly DEEJBKGBNDC LOBGOJIJALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> ABDOJJAJOND;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3DDDD30", Offset = "0x3DDC730", VA = "0x183DDDD30")]
	public HJJLHPMBMPJ(DEEJBKGBNDC LOBGOJIJALM, [Optional] IEqualityComparer<TItemId> ABDOJJAJOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3DDDBE0", Offset = "0x3DDC5E0", VA = "0x183DDDBE0", Slot = "4")]
	[AsyncStateMachine(typeof(HJJLHPMBMPJ<, >.MBGKKMLFFFB))]
	public Task<List<TResult>> KPHPBJGBOOJ(IReadOnlyList<KDAFENFLJDJ<TItemId>> KFKIKNHIHCL, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HNOEBCJDELF<TRequest, TResult> : HHBOGEHBJIE<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> PLDJIGJBKDP(IEnumerable<TRequest> ENIEPHBIEFG, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class EEIKFDJOPJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public EEIKFDJOPJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x383F3A0", Offset = "0x383DDA0", VA = "0x18383F3A0")]
		internal TResult LJDHHCGEAGI(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct GBODEFHLJEN : IAsyncStateMachine
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
		public HNOEBCJDELF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private EEIKFDJOPJF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7C50", Offset = "0x3CF6650", VA = "0x183CF7C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8AB0", Offset = "0x3CF74B0", VA = "0x183CF8AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly PLDJIGJBKDP LOBGOJIJALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> ABDOJJAJOND;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3DDDD30", Offset = "0x3DDC730", VA = "0x183DDDD30")]
	public HNOEBCJDELF(PLDJIGJBKDP LOBGOJIJALM, [Optional] IEqualityComparer<TRequest> ABDOJJAJOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5670", Offset = "0x3DE4070", VA = "0x183DE5670", Slot = "4")]
	[AsyncStateMachine(typeof(HNOEBCJDELF<, >.GBODEFHLJEN))]
	public Task<List<TResult>> KPHPBJGBOOJ(IReadOnlyList<TRequest> KFKIKNHIHCL, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HHBOGEHBJIE<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> KPHPBJGBOOJ(IReadOnlyList<TRequest> KFKIKNHIHCL, CancellationToken AOLOJHLCMLE);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NFNOPDOFAOM<TItemId, TResult> : HHBOGEHBJIE<NLEAOILDNGB<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task GNMIMELHNFD(IReadOnlyDictionary<TItemId, NLEAOILDNGB<TItemId>.MOMIKMBCCIK> KFKIKNHIHCL, CancellationToken AOLOJHLCMLE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct NKMGKNNNJOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NFNOPDOFAOM<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<NLEAOILDNGB<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x44E5E10", Offset = "0x44E4810", VA = "0x1844E5E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x44E6370", Offset = "0x44E4D70", VA = "0x1844E6370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly GNMIMELHNFD JGMLKNKIBDA;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	public NFNOPDOFAOM(GNMIMELHNFD JGMLKNKIBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x44E1CB0", Offset = "0x44E06B0", VA = "0x1844E1CB0", Slot = "4")]
	[AsyncStateMachine(typeof(NFNOPDOFAOM<, >.NKMGKNNNJOP))]
	public Task<List<object>> KPHPBJGBOOJ(IReadOnlyList<NLEAOILDNGB<TItemId>> KFKIKNHIHCL, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x44E1840", Offset = "0x44E0240", VA = "0x1844E1840")]
	private IReadOnlyDictionary<TItemId, NLEAOILDNGB<TItemId>.MOMIKMBCCIK> HNOMECCHGGP(IReadOnlyList<NLEAOILDNGB<TItemId>> FPEALKDDNPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EPCNNKPLOEG<TItemId, TResult> : HHBOGEHBJIE<KDAFENFLJDJ<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> IGIKGPBPAIJ(Dictionary<TItemId, int> KFKIKNHIHCL, CancellationToken AOLOJHLCMLE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct OACKPIOGMGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<KDAFENFLJDJ<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public EPCNNKPLOEG<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x45BF9D0", Offset = "0x45BE3D0", VA = "0x1845BF9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x45C0680", Offset = "0x45BF080", VA = "0x1845C0680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IGIKGPBPAIJ BKAHPBDKCKP;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	public EPCNNKPLOEG(IGIKGPBPAIJ LOBGOJIJALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x387D180", Offset = "0x387BB80", VA = "0x18387D180", Slot = "4")]
	[AsyncStateMachine(typeof(EPCNNKPLOEG<, >.OACKPIOGMGJ))]
	public Task<List<TResult>> KPHPBJGBOOJ(IReadOnlyList<KDAFENFLJDJ<TItemId>> KFKIKNHIHCL, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LIPCIDAJLFA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, JOFDKDIOOGF> MOOJBJGFHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> JEBLDHLFMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> IMFJHEHLLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> BOHKKKAFDAI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, JOFDKDIOOGF> AMNCOMAKBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> IAPGAFFKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LODDLFFIMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3B0", Offset = "0x8B8DB0", VA = "0x1808BA3B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8BA990", Offset = "0x8B9390", VA = "0x1808BA990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x42879F0", Offset = "0x42863F0", VA = "0x1842879F0")]
	public LIPCIDAJLFA(Func<IEnumerable<T>> IMFJHEHLLEM, Func<T, string> BOHKKKAFDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x42876A0", Offset = "0x42860A0", VA = "0x1842876A0")]
	public void AIFEINMMINP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4287960", Offset = "0x4286360", VA = "0x184287960", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OHGBIMOBLGG<TItemId, TResult> : DIFDICAIADL<KDAFENFLJDJ<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x38530C0", Offset = "0x3851AC0", VA = "0x1838530C0")]
	public OHGBIMOBLGG(HHBOGEHBJIE<KDAFENFLJDJ<TItemId>, TResult> GJMDGEGKHNM, TimeSpan FNPGFABPAPA, [Optional] PELLCJFABCL JIMEHBJFLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4601F00", Offset = "0x4600900", VA = "0x184601F00")]
	public Task<TResult> CNOPKGEMEMO(TItemId LDDEKIBHION, int BCKPHDPNMKL, [Optional] CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KDAFENFLJDJ<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId OFNIBLIDOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int JCBKNNKNICI;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x41B9040", Offset = "0x41B7A40", VA = "0x1841B9040")]
	public KDAFENFLJDJ(TItemId MDFNFNNJIOA, int BCKPHDPNMKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface ELAECFJCJOL<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid HCPELCNJBHM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> GKKIOFPGLJA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class KCOOAHLCIFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface KAICINMOLCH
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int NIMEGJCMBMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MEECHBNCJAI<TParam>(TParam DBOBEHLEAAE);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CNKOECMKHOB(Exception PCNDFGCCCEA);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KHPOFAKKFCN();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class NCKMOIIMBEA<TResult> : KAICINMOLCH, ELAECFJCJOL<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> PHLJDCJAGMF;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid HCPELCNJBHM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8C0BB0", Offset = "0x8BF5B0", VA = "0x1808C0BB0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int NIMEGJCMBMA
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8BA3B0", Offset = "0x8B8DB0", VA = "0x1808BA3B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> GKKIOFPGLJA
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x44BD760", Offset = "0x44BC160", VA = "0x1844BD760", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x44D0710", Offset = "0x44CF110", VA = "0x1844D0710")]
		public NCKMOIIMBEA(int GFFJNCEGEON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2A77E30", Offset = "0x2A76830", VA = "0x182A77E30", Slot = "5")]
		public bool MEECHBNCJAI<TParam>(TParam DBOBEHLEAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x44D0670", Offset = "0x44CF070", VA = "0x1844D0670", Slot = "6")]
		public bool CNKOECMKHOB(Exception PCNDFGCCCEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x44D06C0", Offset = "0x44CF0C0", VA = "0x1844D06C0", Slot = "7")]
		public bool KHPOFAKKFCN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string GMGFLANPBLB = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, KAICINMOLCH> NBEKAINBNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly LEBMLKCJFOL KGHAAFJBMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool KBLMENPOHOP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E600", Offset = "0x6F2D000", VA = "0x186F2E600")]
	public KCOOAHLCIFP([Optional] LEBMLKCJFOL KGHAAFJBMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E0F0", Offset = "0x6F2CAF0", VA = "0x186F2E0F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6F80", Offset = "0x2BB5980", VA = "0x182BB6F80")]
	public ELAECFJCJOL<TResult> GDGFNAFFCLA<TResult>(int BKDDCJDCIGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6C10", Offset = "0x2BB5610", VA = "0x182BB6C10")]
	public bool DDDGAAFOAJO<TResult>(Guid ANGIPKEDDGP, TResult EBPHIJANMPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E4E0", Offset = "0x6F2CEE0", VA = "0x186F2E4E0")]
	private void OAAAJGKEDFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E0F0", Offset = "0x6F2CAF0", VA = "0x186F2E0F0")]
	private void MCGAKEKCJDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E200", Offset = "0x6F2CC00", VA = "0x186F2E200")]
	private void MALHGIIFANP(int GFFJNCEGEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DEF0", Offset = "0x6F2C8F0", VA = "0x186F2DEF0")]
	private void CCFABIAEMMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum GNLKEJGCJNL
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NLEAOILDNGB<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class MOMIKMBCCIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int FDNAJHIOEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int EHOADNOPJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int DAIMCLKAICN;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public MOMIKMBCCIK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId OFNIBLIDOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int JCBKNNKNICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public GNLKEJGCJNL KMAKAKJPENG;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x10CB580", Offset = "0x10C9F80", VA = "0x1810CB580")]
	public NLEAOILDNGB(TItemId MDFNFNNJIOA, int BCKPHDPNMKL, GNLKEJGCJNL LBIKMBJEOGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DIJOMGLPPDN<TItemId, TResult> : DIFDICAIADL<NLEAOILDNGB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x38530C0", Offset = "0x3851AC0", VA = "0x1838530C0")]
	public DIJOMGLPPDN(HHBOGEHBJIE<NLEAOILDNGB<TItemId>, TResult> GJMDGEGKHNM, TimeSpan FNPGFABPAPA, [Optional] PELLCJFABCL JIMEHBJFLOD)
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

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
public interface ENGMFGGHBLO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MPLLPKOKACJ(int PCCGHKMEINH, CancellationToken MBHHHCCHBAO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MPLLPKOKACJ(TimeSpan MJNBDIIEJAM, CancellationToken MBHHHCCHBAO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KJDDHEDKBKA : ENGMFGGHBLO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6664CC0", Offset = "0x6663AC0", VA = "0x186664CC0")]
	[HBAMLEIOGOF(EOCHJKOJDMN.Root, BHCECOANHAK.GameOnly)]
	private static void PBOKBLGPDEP(CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	[Preserve]
	public KJDDHEDKBKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6664C60", Offset = "0x6663A60", VA = "0x186664C60", Slot = "4")]
	public Task MPLLPKOKACJ(int PCCGHKMEINH, CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6664C00", Offset = "0x6663A00", VA = "0x186664C00", Slot = "5")]
	public Task MPLLPKOKACJ(TimeSpan MJNBDIIEJAM, CancellationToken MBHHHCCHBAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OBBAKGKNFCI<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct ICBBFKLIGJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest HABJODGOIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> EDEBPNJHKDF;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8F0EC0", Offset = "0x8EFCC0", VA = "0x1808F0EC0")]
		public ICBBFKLIGJE(TRequest GFBEKCAHNCH, TaskCompletionSource<TResult> FANDFCCFKMH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct NOJADEPIBPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public OBBAKGKNFCI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3F00580", Offset = "0x3EFF380", VA = "0x183F00580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3F00AC0", Offset = "0x3EFF8C0", VA = "0x183F00AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct DMEOKEFHOBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public OBBAKGKNFCI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x504C390", Offset = "0x504B190", VA = "0x18504C390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x504C760", Offset = "0x504B560", VA = "0x18504C760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct KLJAAEJAPBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public OBBAKGKNFCI<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3B2B2F0", Offset = "0x3B2A0F0", VA = "0x183B2B2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3B2B790", Offset = "0x3B2A590", VA = "0x183B2B790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct JFEBMEAIPHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public OBBAKGKNFCI<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3A58140", Offset = "0x3A56F40", VA = "0x183A58140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3A59080", Offset = "0x3A57E80", VA = "0x183A59080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly POKABOKLDAL<TRequest, TResult> MKKLEGPJDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float NLDGCCAEOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly ENGMFGGHBLO DJLJIDNFJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<ICBBFKLIGJE> AGCGEHFHLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource OIDLKEGCNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource JIFOPBLBHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task HKEFDPHAAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float JCPAAEFLOBO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KMJOLKOJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAE2060", Offset = "0xAE0E60", VA = "0x180AE2060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAE24F0", Offset = "0xAE12F0", VA = "0x180AE24F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3FB4360", Offset = "0x3FB3160", VA = "0x183FB4360")]
	public OBBAKGKNFCI(POKABOKLDAL<TRequest, TResult> MKKLEGPJDCI, TimeSpan NLDGCCAEOHO, [Optional] ENGMFGGHBLO DJLJIDNFJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3FB3C50", Offset = "0x3FB2A50", VA = "0x183FB3C50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3FB3A30", Offset = "0x3FB2830", VA = "0x183FB3A30")]
	[AsyncStateMachine(typeof(OBBAKGKNFCI<, >.NOJADEPIBPC))]
	public Task<TResult> CGPBKPPAEAA(TRequest GFBEKCAHNCH, [Optional] CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3FB3F40", Offset = "0x3FB2D40", VA = "0x183FB3F40")]
	public Task FPOFFPAGOIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3FB3E60", Offset = "0x3FB2C60", VA = "0x183FB3E60")]
	[AsyncStateMachine(typeof(OBBAKGKNFCI<, >.DMEOKEFHOBP))]
	private Task EIBEFDIALJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3FB4000", Offset = "0x3FB2E00", VA = "0x183FB4000")]
	[AsyncStateMachine(typeof(OBBAKGKNFCI<, >.KLJAAEJAPBD))]
	private Task GLNACIIOLMK(CancellationToken LJAAGPCFADD, CancellationToken APFLJNBEICB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3FB3B50", Offset = "0x3FB2950", VA = "0x183FB3B50")]
	[AsyncStateMachine(typeof(OBBAKGKNFCI<, >.JFEBMEAIPHD))]
	private Task DBGBANOLNLP(CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3FB3960", Offset = "0x3FB2760", VA = "0x183FB3960")]
	private TimeSpan BPAMFNIILJH()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3FB4120", Offset = "0x3FB2F20", VA = "0x183FB4120")]
	private Task<List<TResult>> HOOEBNIAHOM(IReadOnlyList<TRequest> OLMKAOHHLBL, CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3FB4230", Offset = "0x3FB3030", VA = "0x183FB4230")]
	private float IJKFEEABAEE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3FB42D0", Offset = "0x3FB30D0", VA = "0x183FB42D0")]
	private void NDJHOJNLLAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JHKPBBBFMPO<TItemId, TResult> : POKABOKLDAL<LIEKFJFJFPB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> ACJHJGHAFHM(Dictionary<TItemId, int> OLMKAOHHLBL, CancellationToken MBHHHCCHBAO);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class AOAPOLPLPAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public AOAPOLPLPAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x39AA1A0", Offset = "0x39A8FA0", VA = "0x1839AA1A0")]
		internal TResult LLNDIFPKLLB(LIEKFJFJFPB<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HGOLCNOIHMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<LIEKFJFJFPB<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public JHKPBBBFMPO<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private AOAPOLPLPAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x37B9CC0", Offset = "0x37B8AC0", VA = "0x1837B9CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37BAA10", Offset = "0x37B9810", VA = "0x1837BAA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly ACJHJGHAFHM JBPKJKAJDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> JIEAIILGOFG;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3A69ED0", Offset = "0x3A68CD0", VA = "0x183A69ED0")]
	public JHKPBBBFMPO(ACJHJGHAFHM JBPKJKAJDNJ, [Optional] IEqualityComparer<TItemId> JIEAIILGOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3A69C30", Offset = "0x3A68A30", VA = "0x183A69C30", Slot = "4")]
	[AsyncStateMachine(typeof(JHKPBBBFMPO<, >.HGOLCNOIHMC))]
	public Task<List<TResult>> NAIOGFLJCCC(IReadOnlyList<LIEKFJFJFPB<TItemId>> OLMKAOHHLBL, CancellationToken MBHHHCCHBAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DIANAGIKMKK<TRequest, TResult> : POKABOKLDAL<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> IPLHODBPKCL(IEnumerable<TRequest> MONGILHCPGN, CancellationToken MBHHHCCHBAO);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class BGFPNBKGIEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public BGFPNBKGIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3637C20", Offset = "0x3636A20", VA = "0x183637C20")]
		internal TResult LLNDIFPKLLB(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct AJKCHGCGFEG : IAsyncStateMachine
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
		public DIANAGIKMKK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private BGFPNBKGIEL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x38C5D80", Offset = "0x38C4B80", VA = "0x1838C5D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x38C6BB0", Offset = "0x38C59B0", VA = "0x1838C6BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly IPLHODBPKCL JBPKJKAJDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> JIEAIILGOFG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3A69ED0", Offset = "0x3A68CD0", VA = "0x183A69ED0")]
	public DIANAGIKMKK(IPLHODBPKCL JBPKJKAJDNJ, [Optional] IEqualityComparer<TRequest> JIEAIILGOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5040E90", Offset = "0x503FC90", VA = "0x185040E90", Slot = "4")]
	[AsyncStateMachine(typeof(DIANAGIKMKK<, >.AJKCHGCGFEG))]
	public Task<List<TResult>> NAIOGFLJCCC(IReadOnlyList<TRequest> OLMKAOHHLBL, CancellationToken MBHHHCCHBAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface POKABOKLDAL<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> NAIOGFLJCCC(IReadOnlyList<TRequest> OLMKAOHHLBL, CancellationToken MBHHHCCHBAO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class CCNOCOMPIPF<TItemId, TResult> : POKABOKLDAL<CPOJNAKOEPL<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task BCBEHBCDLIP(IReadOnlyDictionary<TItemId, CPOJNAKOEPL<TItemId>.ICCMILIKCLA> OLMKAOHHLBL, CancellationToken MBHHHCCHBAO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct DNOPNEHJGIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CCNOCOMPIPF<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<CPOJNAKOEPL<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x504EBB0", Offset = "0x504D9B0", VA = "0x18504EBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x504F0E0", Offset = "0x504DEE0", VA = "0x18504F0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly BCBEHBCDLIP AMACENCOCJH;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	public CCNOCOMPIPF(BCBEHBCDLIP AMACENCOCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4B86A60", Offset = "0x4B85860", VA = "0x184B86A60", Slot = "4")]
	[AsyncStateMachine(typeof(CCNOCOMPIPF<, >.DNOPNEHJGIG))]
	public Task<List<object>> NAIOGFLJCCC(IReadOnlyList<CPOJNAKOEPL<TItemId>> OLMKAOHHLBL, CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4B865F0", Offset = "0x4B853F0", VA = "0x184B865F0")]
	private IReadOnlyDictionary<TItemId, CPOJNAKOEPL<TItemId>.ICCMILIKCLA> JNIEENDGEHH(IReadOnlyList<CPOJNAKOEPL<TItemId>> INPICMCNLMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JIGOPJJAOIH<TItemId, TResult> : POKABOKLDAL<LIEKFJFJFPB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> IEFFALEGMDM(Dictionary<TItemId, int> OLMKAOHHLBL, CancellationToken MBHHHCCHBAO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct MGOLBGCDAND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<LIEKFJFJFPB<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public JIGOPJJAOIH<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3E12990", Offset = "0x3E11790", VA = "0x183E12990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3E13600", Offset = "0x3E12400", VA = "0x183E13600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IEFFALEGMDM BFGJINKCDAA;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	public JIGOPJJAOIH(IEFFALEGMDM JBPKJKAJDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B6D0", Offset = "0x3A6A4D0", VA = "0x183A6B6D0", Slot = "4")]
	[AsyncStateMachine(typeof(JIGOPJJAOIH<, >.MGOLBGCDAND))]
	public Task<List<TResult>> NAIOGFLJCCC(IReadOnlyList<LIEKFJFJFPB<TItemId>> OLMKAOHHLBL, CancellationToken MBHHHCCHBAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JPDEDFELBFJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, HPAOIMDDOHC> FBDCMONPGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> GJGLBJJKEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> OHDGOOKAKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> KPDPBEGOMJJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, HPAOIMDDOHC> GGCDAJFLJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> KBPJBLHDIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IPJHPMMMJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x91FAD0", Offset = "0x91E8D0", VA = "0x18091FAD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x91FAE0", Offset = "0x91E8E0", VA = "0x18091FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3A87AB0", Offset = "0x3A868B0", VA = "0x183A87AB0")]
	public JPDEDFELBFJ(Func<IEnumerable<T>> OHDGOOKAKLM, Func<T, string> KPDPBEGOMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A87830", Offset = "0x3A86630", VA = "0x183A87830")]
	public void LAGHJNJIPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3A877C0", Offset = "0x3A865C0", VA = "0x183A877C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GGJMMNHLFHD<TItemId, TResult> : OBBAKGKNFCI<LIEKFJFJFPB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3700090", Offset = "0x36FEE90", VA = "0x183700090")]
	public GGJMMNHLFHD(POKABOKLDAL<LIEKFJFJFPB<TItemId>, TResult> MKKLEGPJDCI, TimeSpan NLDGCCAEOHO, [Optional] ENGMFGGHBLO DJLJIDNFJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x36FFF30", Offset = "0x36FED30", VA = "0x1836FFF30")]
	public Task<TResult> CGPBKPPAEAA(TItemId ONOECNHBCDA, int EJIKHJDMNAB, [Optional] CancellationToken MBHHHCCHBAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LIEKFJFJFPB<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId GDAHOKILKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int EIFPMGGNCGN;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3C1C290", Offset = "0x3C1B090", VA = "0x183C1C290")]
	public LIEKFJFJFPB(TItemId HBECLCOPAKL, int EJIKHJDMNAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NBNODPDLFGP<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid BIJIIMILHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> PEOEONIEJBP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FCMKDFMFEML : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface JGMLMJDKMMI
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int ICOAMHHLFOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool GPOBBNJGDDB<TParam>(TParam MAEBFBHFPDE);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool EPMLKJNPOAH(Exception IOKJIKNDOFL);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool NIEBKPILJKC();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class CEGLLIKEAIP<TResult> : JGMLMJDKMMI, NBNODPDLFGP<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> KKPEIDAJNKJ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid BIJIIMILHCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x825D70", Offset = "0x824B70", VA = "0x180825D70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int ICOAMHHLFOO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x91FAD0", Offset = "0x91E8D0", VA = "0x18091FAD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> PEOEONIEJBP
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3E72770", Offset = "0x3E71570", VA = "0x183E72770", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4C548C0", Offset = "0x4C536C0", VA = "0x184C548C0")]
		public CEGLLIKEAIP(int HKIMMIPBJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x22A0E80", Offset = "0x229FC80", VA = "0x1822A0E80", Slot = "5")]
		public bool GPOBBNJGDDB<TParam>(TParam MAEBFBHFPDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4C54840", Offset = "0x4C53640", VA = "0x184C54840", Slot = "6")]
		public bool EPMLKJNPOAH(Exception IOKJIKNDOFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4C54880", Offset = "0x4C53680", VA = "0x184C54880", Slot = "7")]
		public bool NIEBKPILJKC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string NNBPAGIAPAP = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, JGMLMJDKMMI> OOGGLNGNGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly ILMGMEKFNMF CNAOADBJNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool IABNDOHLBGO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6664B30", Offset = "0x6663930", VA = "0x186664B30")]
	public FCMKDFMFEML([Optional] ILMGMEKFNMF CNAOADBJNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6664820", Offset = "0x6663620", VA = "0x186664820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2730100", Offset = "0x272EF00", VA = "0x182730100")]
	public NBNODPDLFGP<TResult> DGCAFHAIPEB<TResult>(int EBGHMMKKLGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x27303A0", Offset = "0x272F1A0", VA = "0x1827303A0")]
	public bool JIODKOOCOEO<TResult>(Guid IPCMOCPDLDC, TResult ELGNBNFKLLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6664700", Offset = "0x6663500", VA = "0x186664700")]
	private void BIDMIEOEPCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6664820", Offset = "0x6663620", VA = "0x186664820")]
	private void NFEPDCPALGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6664410", Offset = "0x6663210", VA = "0x186664410")]
	private void ACDLPNCINMP(int HKIMMIPBJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6664930", Offset = "0x6663730", VA = "0x186664930")]
	private void OIPPECCBALP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum LMAKNGIAFLG
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class CPOJNAKOEPL<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ICCMILIKCLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int PJJLFBHCICA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int BGPNENAJGEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int KJBEDBCBLFK;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public ICCMILIKCLA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId GDAHOKILKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int EIFPMGGNCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public LMAKNGIAFLG BGDINNAICLM;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xED0870", Offset = "0xECF670", VA = "0x180ED0870")]
	public CPOJNAKOEPL(TItemId HBECLCOPAKL, int EJIKHJDMNAB, LMAKNGIAFLG CCBBNNMCBIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class NGPJEPDABOG<TItemId, TResult> : OBBAKGKNFCI<CPOJNAKOEPL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3700090", Offset = "0x36FEE90", VA = "0x183700090")]
	public NGPJEPDABOG(POKABOKLDAL<CPOJNAKOEPL<TItemId>, TResult> MKKLEGPJDCI, TimeSpan NLDGCCAEOHO, [Optional] ENGMFGGHBLO DJLJIDNFJCD)
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

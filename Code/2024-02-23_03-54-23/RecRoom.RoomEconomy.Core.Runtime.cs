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
public interface OPIGGONPMOL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BDHGCGGNHFE(int HNIGHFEEIPN, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BDHGCGGNHFE(TimeSpan PHOINNMCHFD, CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class HEDLBONCFKI : OPIGGONPMOL
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6549480", Offset = "0x6547E80", VA = "0x186549480")]
	[NEHHKLCIMGL(DIKIGLGFNNP.Root, OJLOCLENGNC.GameOnly)]
	private static void JAMHGAPJMJA(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	[Preserve]
	public HEDLBONCFKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6549420", Offset = "0x6547E20", VA = "0x186549420", Slot = "4")]
	public Task BDHGCGGNHFE(int HNIGHFEEIPN, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x65493C0", Offset = "0x6547DC0", VA = "0x1865493C0", Slot = "5")]
	public Task BDHGCGGNHFE(TimeSpan PHOINNMCHFD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ILFOPEOOOML<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct DJGMBJNLNFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest AOPGGACNBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> IPNIEDCLALC;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88E8A0", Offset = "0x88D2A0", VA = "0x18088E8A0")]
		public DJGMBJNLNFB(TRequest NCCHHGAPAOP, TaskCompletionSource<TResult> EEDJEJGKNFJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct JACNHEBBCBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public ILFOPEOOOML<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3989AA0", Offset = "0x39884A0", VA = "0x183989AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3989FE0", Offset = "0x39889E0", VA = "0x183989FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GGGHHHCNCPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public ILFOPEOOOML<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x36B00D0", Offset = "0x36AEAD0", VA = "0x1836B00D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x36B04A0", Offset = "0x36AEEA0", VA = "0x1836B04A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BAFCNNLBNLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ILFOPEOOOML<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4611260", Offset = "0x460FC60", VA = "0x184611260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4611700", Offset = "0x4610100", VA = "0x184611700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct BLMJFFLIPNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public ILFOPEOOOML<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4665E60", Offset = "0x4664860", VA = "0x184665E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4666DA0", Offset = "0x46657A0", VA = "0x184666DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JJDPKNCPALN<TRequest, TResult> HJPKJJKFEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float IGGDPAGBKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OPIGGONPMOL CLOAKOIDGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<DJGMBJNLNFB> APCFMHOFDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource HPODDGILCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource GNILLDDLPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task PNJGIDBGDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float OIMJKCCMHPC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CAHFEKLEAFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA63D80", Offset = "0xA62780", VA = "0x180A63D80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA63DF0", Offset = "0xA627F0", VA = "0x180A63DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x37FD820", Offset = "0x37FC220", VA = "0x1837FD820")]
	public ILFOPEOOOML(JJDPKNCPALN<TRequest, TResult> HJPKJJKFEOO, TimeSpan IGGDPAGBKPB, [Optional] OPIGGONPMOL CLOAKOIDGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x37FCF30", Offset = "0x37FB930", VA = "0x1837FCF30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x37FD2B0", Offset = "0x37FBCB0", VA = "0x1837FD2B0")]
	[AsyncStateMachine(typeof(ILFOPEOOOML<, >.JACNHEBBCBE))]
	public Task<TResult> HJEGDLDFDPE(TRequest NCCHHGAPAOP, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x37FD3D0", Offset = "0x37FBDD0", VA = "0x1837FD3D0")]
	public Task IBLLKBBPONG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37FD1D0", Offset = "0x37FBBD0", VA = "0x1837FD1D0")]
	[AsyncStateMachine(typeof(ILFOPEOOOML<, >.GGGHHHCNCPL))]
	private Task EPKCLIMNDPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x37FD490", Offset = "0x37FBE90", VA = "0x1837FD490")]
	[AsyncStateMachine(typeof(ILFOPEOOOML<, >.BAFCNNLBNLO))]
	private Task LKHPCEJOIJO(CancellationToken HLDAKJPPPNN, CancellationToken CPPOCNFHAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x37FD5B0", Offset = "0x37FBFB0", VA = "0x1837FD5B0")]
	[AsyncStateMachine(typeof(ILFOPEOOOML<, >.BLMJFFLIPNK))]
	private Task LOPHJABDKIF(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x37FD750", Offset = "0x37FC150", VA = "0x1837FD750")]
	private TimeSpan PDBLFLIBHDP()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37FCE20", Offset = "0x37FB820", VA = "0x1837FCE20")]
	private Task<List<TResult>> DBCCNLEKMAO(IReadOnlyList<TRequest> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x37FD6B0", Offset = "0x37FC0B0", VA = "0x1837FD6B0")]
	private float NGLMNBJDMEB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37FD140", Offset = "0x37FBB40", VA = "0x1837FD140")]
	private void EFABNOIOPKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BCDPJOKBICJ<TItemId, TResult> : JJDPKNCPALN<CBBMMBIKKOA<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> ODIEFIIOPPM(Dictionary<TItemId, int> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MHFHLABIOGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public MHFHLABIOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3D9B6B0", Offset = "0x3D9A0B0", VA = "0x183D9B6B0")]
		internal TResult JALPLGBAKCA(CBBMMBIKKOA<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NINBFKILGOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<CBBMMBIKKOA<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public BCDPJOKBICJ<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private MHFHLABIOGL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3E367F0", Offset = "0x3E351F0", VA = "0x183E367F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3E37540", Offset = "0x3E35F40", VA = "0x183E37540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly ODIEFIIOPPM GJGJGCAKNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> GHLKMAKNHEH;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3F22840", Offset = "0x3F21240", VA = "0x183F22840")]
	public BCDPJOKBICJ(ODIEFIIOPPM GJGJGCAKNHA, [Optional] IEqualityComparer<TItemId> GHLKMAKNHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x461A4A0", Offset = "0x4618EA0", VA = "0x18461A4A0", Slot = "4")]
	[AsyncStateMachine(typeof(BCDPJOKBICJ<, >.NINBFKILGOC))]
	public Task<List<TResult>> AIOEPKFDNKO(IReadOnlyList<CBBMMBIKKOA<TItemId>> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OGHHKFCAEPG<TRequest, TResult> : JJDPKNCPALN<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> IPEAMMCJLKL(IEnumerable<TRequest> OMNLBBGKGGE, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class GBMJICLPCLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public GBMJICLPCLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x32232D0", Offset = "0x3221CD0", VA = "0x1832232D0")]
		internal TResult JALPLGBAKCA(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct OGPFJNGBCCD : IAsyncStateMachine
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
		public OGHHKFCAEPG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private GBMJICLPCLJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3F22D50", Offset = "0x3F21750", VA = "0x183F22D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3F23B80", Offset = "0x3F22580", VA = "0x183F23B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly IPEAMMCJLKL GJGJGCAKNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> GHLKMAKNHEH;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3F22840", Offset = "0x3F21240", VA = "0x183F22840")]
	public OGHHKFCAEPG(IPEAMMCJLKL GJGJGCAKNHA, [Optional] IEqualityComparer<TRequest> GHLKMAKNHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3F226F0", Offset = "0x3F210F0", VA = "0x183F226F0", Slot = "4")]
	[AsyncStateMachine(typeof(OGHHKFCAEPG<, >.OGPFJNGBCCD))]
	public Task<List<TResult>> AIOEPKFDNKO(IReadOnlyList<TRequest> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JJDPKNCPALN<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> AIOEPKFDNKO(IReadOnlyList<TRequest> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NFJFOIJOEEG<TItemId, TResult> : JJDPKNCPALN<LNFEPBNPLEE<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task DDAIJPHOGNB(IReadOnlyDictionary<TItemId, LNFEPBNPLEE<TItemId>.GFMDIJBGAMM> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct JKNKIOLAJPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NFJFOIJOEEG<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<LNFEPBNPLEE<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3A2DC40", Offset = "0x3A2C640", VA = "0x183A2DC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E170", Offset = "0x3A2CB70", VA = "0x183A2E170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly DDAIJPHOGNB NGLFNJAPNMK;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	public NFJFOIJOEEG(DDAIJPHOGNB NGLFNJAPNMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3E32930", Offset = "0x3E31330", VA = "0x183E32930", Slot = "4")]
	[AsyncStateMachine(typeof(NFJFOIJOEEG<, >.JKNKIOLAJPC))]
	public Task<List<object>> AIOEPKFDNKO(IReadOnlyList<LNFEPBNPLEE<TItemId>> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3E32A70", Offset = "0x3E31470", VA = "0x183E32A70")]
	private IReadOnlyDictionary<TItemId, LNFEPBNPLEE<TItemId>.GFMDIJBGAMM> DLMKCEBMPBF(IReadOnlyList<LNFEPBNPLEE<TItemId>> DNEFAFOIELK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HLPBAJGOLBO<TItemId, TResult> : JJDPKNCPALN<CBBMMBIKKOA<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> JKGFHJCNJLN(Dictionary<TItemId, int> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct FKJDGNGAKDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<CBBMMBIKKOA<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public HLPBAJGOLBO<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x35BA420", Offset = "0x35B8E20", VA = "0x1835BA420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x35BBD00", Offset = "0x35BA700", VA = "0x1835BBD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly JKGFHJCNJLN PEEFJLAMCJM;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	public HLPBAJGOLBO(JKGFHJCNJLN GJGJGCAKNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3733A70", Offset = "0x3732470", VA = "0x183733A70", Slot = "4")]
	[AsyncStateMachine(typeof(HLPBAJGOLBO<, >.FKJDGNGAKDC))]
	public Task<List<TResult>> AIOEPKFDNKO(IReadOnlyList<CBBMMBIKKOA<TItemId>> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ADAPMDNCIDM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, NJECMKJCHLN> JIEPNJMIPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> LJDGOICGHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> CHGODOCMDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> NIJALFMGNHA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, NJECMKJCHLN> COPNJBMIIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> MGHDOKBOMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DFIDLAMJFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8C30C0", Offset = "0x8C1AC0", VA = "0x1808C30C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8C30D0", Offset = "0x8C1AD0", VA = "0x1808C30D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3674DE0", Offset = "0x36737E0", VA = "0x183674DE0")]
	public ADAPMDNCIDM(Func<IEnumerable<T>> CHGODOCMDFD, Func<T, string> NIJALFMGNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3674B60", Offset = "0x3673560", VA = "0x183674B60")]
	public void JPBFJKJIHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3674AF0", Offset = "0x36734F0", VA = "0x183674AF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KHBJBMDMPFA<TItemId, TResult> : ILFOPEOOOML<CBBMMBIKKOA<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3700110", Offset = "0x36FEB10", VA = "0x183700110")]
	public KHBJBMDMPFA(JJDPKNCPALN<CBBMMBIKKOA<TItemId>, TResult> HJPKJJKFEOO, TimeSpan IGGDPAGBKPB, [Optional] OPIGGONPMOL CLOAKOIDGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3A97CB0", Offset = "0x3A966B0", VA = "0x183A97CB0")]
	public Task<TResult> HJEGDLDFDPE(TItemId KCGLPAPOILB, int OGKNDCGCKLO, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CBBMMBIKKOA<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId FECGEAOBCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int BJDKLCEOKPB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4855480", Offset = "0x4853E80", VA = "0x184855480")]
	public CBBMMBIKKOA(TItemId PEOPGGKHFEK, int OGKNDCGCKLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JPHCKOJLPKA<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid DKNPKOBNLGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> BMDBBMOAMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class JJOCBCLHEGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface EGJBKBLBODO
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int EKBGBFHPLKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IFJGIHAADFD<TParam>(TParam FDFHGIHHGHO);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KHOGHBDAHAN(Exception KMJIPKGNLDF);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool PIDNDLKOHMH();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class OMLEPPJIJNE<TResult> : EGJBKBLBODO, JPHCKOJLPKA<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> NMFGNBBCHDA;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid DKNPKOBNLGL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB644E0", Offset = "0xB62EE0", VA = "0x180B644E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int EKBGBFHPLKP
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8C30C0", Offset = "0x8C1AC0", VA = "0x1808C30C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> BMDBBMOAMGD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3E0AF00", Offset = "0x3E09900", VA = "0x183E0AF00", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3F31A30", Offset = "0x3F30430", VA = "0x183F31A30")]
		public OMLEPPJIJNE(int ADANFKPCFAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x25C6D80", Offset = "0x25C5780", VA = "0x1825C6D80", Slot = "5")]
		public bool IFJGIHAADFD<TParam>(TParam FDFHGIHHGHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3F319B0", Offset = "0x3F303B0", VA = "0x183F319B0", Slot = "6")]
		public bool KHOGHBDAHAN(Exception KMJIPKGNLDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3F319F0", Offset = "0x3F303F0", VA = "0x183F319F0", Slot = "7")]
		public bool PIDNDLKOHMH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string GFPKOHJIGJK = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, EGJBKBLBODO> DBLLHCGFBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly MALBHNJOIFD PAPEFDFDIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool OHINFEEPPFE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6549CA0", Offset = "0x65486A0", VA = "0x186549CA0")]
	public JJOCBCLHEGP([Optional] MALBHNJOIFD PAPEFDFDIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x65496A0", Offset = "0x65480A0", VA = "0x1865496A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2707B80", Offset = "0x2706580", VA = "0x182707B80")]
	public JPHCKOJLPKA<TResult> OAHJCCFJGOP<TResult>(int BPFNFCAJELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2707850", Offset = "0x2706250", VA = "0x182707850")]
	public bool GOAPGKFIFEN<TResult>(Guid BMPBDIBKAJJ, TResult MNKBHKEBOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6549580", Offset = "0x6547F80", VA = "0x186549580")]
	private void CJIHIEGHFLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x65496A0", Offset = "0x65480A0", VA = "0x1865496A0")]
	private void HEKAADHIDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x65497B0", Offset = "0x65481B0", VA = "0x1865497B0")]
	private void EHDIGJHFLEG(int ADANFKPCFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6549AA0", Offset = "0x65484A0", VA = "0x186549AA0")]
	private void IJMIOJOHHBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum DHAGLPKEIDO
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LNFEPBNPLEE<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class GFMDIJBGAMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int OBPPGJNCIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int JFINGOFABOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int OPFENEBMLIO;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public GFMDIJBGAMM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId FECGEAOBCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int BJDKLCEOKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public DHAGLPKEIDO MMGEJCLJHDM;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xD75350", Offset = "0xD73D50", VA = "0x180D75350")]
	public LNFEPBNPLEE(TItemId PEOPGGKHFEK, int OGKNDCGCKLO, DHAGLPKEIDO JIBNFGIMNPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class OFMEBKEFILN<TItemId, TResult> : ILFOPEOOOML<LNFEPBNPLEE<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3700110", Offset = "0x36FEB10", VA = "0x183700110")]
	public OFMEBKEFILN(JJDPKNCPALN<LNFEPBNPLEE<TItemId>, TResult> HJPKJJKFEOO, TimeSpan IGGDPAGBKPB, [Optional] OPIGGONPMOL CLOAKOIDGPO)
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

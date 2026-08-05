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
	[Cpp2IlInjected.Address(RVA = "0x64CF260", Offset = "0x64CE660", VA = "0x1864CF260")]
	[NEHHKLCIMGL(DIKIGLGFNNP.Root, OJLOCLENGNC.GameOnly)]
	private static void JAMHGAPJMJA(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	[Preserve]
	public HEDLBONCFKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64CF200", Offset = "0x64CE600", VA = "0x1864CF200", Slot = "4")]
	public Task BDHGCGGNHFE(int HNIGHFEEIPN, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x64CF1A0", Offset = "0x64CE5A0", VA = "0x1864CF1A0", Slot = "5")]
	public Task BDHGCGGNHFE(TimeSpan PHOINNMCHFD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DFACBOJFINA<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId FECGEAOBCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int BJDKLCEOKPB;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E8AA40", Offset = "0x4E89E40", VA = "0x184E8AA40")]
	public DFACBOJFINA(TItemId PEOPGGKHFEK, int OGKNDCGCKLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JBKCJOFDFEH<TItemId, TResult> : ILFOPEOOOML<DFACBOJFINA<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x36E2040", Offset = "0x36E1440", VA = "0x1836E2040")]
	public JBKCJOFDFEH(JJDPKNCPALN<DFACBOJFINA<TItemId>, TResult> HJPKJJKFEOO, TimeSpan IGGDPAGBKPB, [Optional] OPIGGONPMOL CLOAKOIDGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x395E450", Offset = "0x395D850", VA = "0x18395E450")]
	public Task<TResult> HJEGDLDFDPE(TItemId KCGLPAPOILB, int OGKNDCGCKLO, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ILFOPEOOOML<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct DJGMBJNLNFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest AOPGGACNBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> IPNIEDCLALC;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8833F0", Offset = "0x8827F0", VA = "0x1808833F0")]
		public DJGMBJNLNFB(TRequest NCCHHGAPAOP, TaskCompletionSource<TResult> EEDJEJGKNFJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JACNHEBBCBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public ILFOPEOOOML<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3958560", Offset = "0x3957960", VA = "0x183958560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3958AA0", Offset = "0x3957EA0", VA = "0x183958AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GGGHHHCNCPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ILFOPEOOOML<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3691EB0", Offset = "0x36912B0", VA = "0x183691EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3692280", Offset = "0x3691680", VA = "0x183692280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct BAFCNNLBNLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ILFOPEOOOML<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x45C7730", Offset = "0x45C6B30", VA = "0x1845C7730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x45C7BD0", Offset = "0x45C6FD0", VA = "0x1845C7BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BLMJFFLIPNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public ILFOPEOOOML<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x461B1C0", Offset = "0x461A5C0", VA = "0x18461B1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x461C100", Offset = "0x461B500", VA = "0x18461C100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly JJDPKNCPALN<TRequest, TResult> HJPKJJKFEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float IGGDPAGBKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly OPIGGONPMOL CLOAKOIDGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<DJGMBJNLNFB> APCFMHOFDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource HPODDGILCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource GNILLDDLPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task PNJGIDBGDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float OIMJKCCMHPC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CAHFEKLEAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA58380", Offset = "0xA57780", VA = "0x180A58380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA583F0", Offset = "0xA577F0", VA = "0x180A583F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x37C44F0", Offset = "0x37C38F0", VA = "0x1837C44F0")]
	public ILFOPEOOOML(JJDPKNCPALN<TRequest, TResult> HJPKJJKFEOO, TimeSpan IGGDPAGBKPB, [Optional] OPIGGONPMOL CLOAKOIDGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37C3C00", Offset = "0x37C3000", VA = "0x1837C3C00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x37C3F80", Offset = "0x37C3380", VA = "0x1837C3F80")]
	[AsyncStateMachine(typeof(ILFOPEOOOML<, >.JACNHEBBCBE))]
	public Task<TResult> HJEGDLDFDPE(TRequest NCCHHGAPAOP, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x37C40A0", Offset = "0x37C34A0", VA = "0x1837C40A0")]
	public Task IBLLKBBPONG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x37C3EA0", Offset = "0x37C32A0", VA = "0x1837C3EA0")]
	[AsyncStateMachine(typeof(ILFOPEOOOML<, >.GGGHHHCNCPL))]
	private Task EPKCLIMNDPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37C4160", Offset = "0x37C3560", VA = "0x1837C4160")]
	[AsyncStateMachine(typeof(ILFOPEOOOML<, >.BAFCNNLBNLO))]
	private Task LKHPCEJOIJO(CancellationToken HLDAKJPPPNN, CancellationToken CPPOCNFHAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x37C4280", Offset = "0x37C3680", VA = "0x1837C4280")]
	[AsyncStateMachine(typeof(ILFOPEOOOML<, >.BLMJFFLIPNK))]
	private Task LOPHJABDKIF(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37C4420", Offset = "0x37C3820", VA = "0x1837C4420")]
	private TimeSpan PDBLFLIBHDP()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x37C3AF0", Offset = "0x37C2EF0", VA = "0x1837C3AF0")]
	private Task<List<TResult>> DBCCNLEKMAO(IReadOnlyList<TRequest> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x37C4380", Offset = "0x37C3780", VA = "0x1837C4380")]
	private float NGLMNBJDMEB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x37C3E10", Offset = "0x37C3210", VA = "0x1837C3E10")]
	private void EFABNOIOPKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BCDPJOKBICJ<TItemId, TResult> : JJDPKNCPALN<DFACBOJFINA<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> ODIEFIIOPPM(Dictionary<TItemId, int> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MHFHLABIOGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public MHFHLABIOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3D55230", Offset = "0x3D54630", VA = "0x183D55230")]
		internal TResult JALPLGBAKCA(DFACBOJFINA<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct NINBFKILGOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<DFACBOJFINA<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public BCDPJOKBICJ<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private MHFHLABIOGL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3E002F0", Offset = "0x3DFF6F0", VA = "0x183E002F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3E01040", Offset = "0x3E00440", VA = "0x183E01040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ODIEFIIOPPM GJGJGCAKNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> GHLKMAKNHEH;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3EEDB30", Offset = "0x3EECF30", VA = "0x183EEDB30")]
	public BCDPJOKBICJ(ODIEFIIOPPM GJGJGCAKNHA, [Optional] IEqualityComparer<TItemId> GHLKMAKNHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x45E09C0", Offset = "0x45DFDC0", VA = "0x1845E09C0", Slot = "4")]
	[AsyncStateMachine(typeof(BCDPJOKBICJ<, >.NINBFKILGOC))]
	public Task<List<TResult>> AIOEPKFDNKO(IReadOnlyList<DFACBOJFINA<TItemId>> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OGHHKFCAEPG<TRequest, TResult> : JJDPKNCPALN<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> IPEAMMCJLKL(IEnumerable<TRequest> OMNLBBGKGGE, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class GBMJICLPCLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public GBMJICLPCLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x31F3A70", Offset = "0x31F2E70", VA = "0x1831F3A70")]
		internal TResult JALPLGBAKCA(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct OGPFJNGBCCD : IAsyncStateMachine
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
		public OGHHKFCAEPG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private GBMJICLPCLJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3EEE040", Offset = "0x3EED440", VA = "0x183EEE040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3EEEE70", Offset = "0x3EEE270", VA = "0x183EEEE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly IPEAMMCJLKL GJGJGCAKNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> GHLKMAKNHEH;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3EEDB30", Offset = "0x3EECF30", VA = "0x183EEDB30")]
	public OGHHKFCAEPG(IPEAMMCJLKL GJGJGCAKNHA, [Optional] IEqualityComparer<TRequest> GHLKMAKNHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3EED9E0", Offset = "0x3EECDE0", VA = "0x183EED9E0", Slot = "4")]
	[AsyncStateMachine(typeof(OGHHKFCAEPG<, >.OGPFJNGBCCD))]
	public Task<List<TResult>> AIOEPKFDNKO(IReadOnlyList<TRequest> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JJDPKNCPALN<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> AIOEPKFDNKO(IReadOnlyList<TRequest> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NFJFOIJOEEG<TItemId, TResult> : JJDPKNCPALN<LNFEPBNPLEE<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task DDAIJPHOGNB(IReadOnlyDictionary<TItemId, LNFEPBNPLEE<TItemId>.GFMDIJBGAMM> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct JKNKIOLAJPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NFJFOIJOEEG<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IReadOnlyList<LNFEPBNPLEE<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x39E4D00", Offset = "0x39E4100", VA = "0x1839E4D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x39E5230", Offset = "0x39E4630", VA = "0x1839E5230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly DDAIJPHOGNB NGLFNJAPNMK;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	public NFJFOIJOEEG(DDAIJPHOGNB NGLFNJAPNMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC320", Offset = "0x3DFB720", VA = "0x183DFC320", Slot = "4")]
	[AsyncStateMachine(typeof(NFJFOIJOEEG<, >.JKNKIOLAJPC))]
	public Task<List<object>> AIOEPKFDNKO(IReadOnlyList<LNFEPBNPLEE<TItemId>> LNMGIEOJGOO, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC460", Offset = "0x3DFB860", VA = "0x183DFC460")]
	private IReadOnlyDictionary<TItemId, LNFEPBNPLEE<TItemId>.GFMDIJBGAMM> DLMKCEBMPBF(IReadOnlyList<LNFEPBNPLEE<TItemId>> DNEFAFOIELK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ADAPMDNCIDM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Dictionary<string, NJECMKJCHLN> JIEPNJMIPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private List<T> LJDGOICGHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private Func<IEnumerable<T>> CHGODOCMDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Func<T, string> NIJALFMGNHA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, NJECMKJCHLN> COPNJBMIIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> MGHDOKBOMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DFIDLAMJFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B8500", Offset = "0x8B7900", VA = "0x1808B8500")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8B8510", Offset = "0x8B7910", VA = "0x1808B8510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x36305C0", Offset = "0x362F9C0", VA = "0x1836305C0")]
	public ADAPMDNCIDM(Func<IEnumerable<T>> CHGODOCMDFD, Func<T, string> NIJALFMGNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3630340", Offset = "0x362F740", VA = "0x183630340")]
	public void JPBFJKJIHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x36302D0", Offset = "0x362F6D0", VA = "0x1836302D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JPHCKOJLPKA<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid DKNPKOBNLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> BMDBBMOAMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JJOCBCLHEGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private interface EGJBKBLBODO
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int EKBGBFHPLKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IFJGIHAADFD<TParam>(TParam FDFHGIHHGHO);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KHOGHBDAHAN(Exception KMJIPKGNLDF);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool PIDNDLKOHMH();
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class OMLEPPJIJNE<TResult> : EGJBKBLBODO, JPHCKOJLPKA<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly TaskCompletionSource<TResult> NMFGNBBCHDA;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid DKNPKOBNLGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xB58670", Offset = "0xB57A70", VA = "0x180B58670", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int EKBGBFHPLKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8B8500", Offset = "0x8B7900", VA = "0x1808B8500", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> BMDBBMOAMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x379CF40", Offset = "0x379C340", VA = "0x18379CF40", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3EFCC60", Offset = "0x3EFC060", VA = "0x183EFCC60")]
		public OMLEPPJIJNE(int ADANFKPCFAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x256FAF0", Offset = "0x256EEF0", VA = "0x18256FAF0", Slot = "5")]
		public bool IFJGIHAADFD<TParam>(TParam FDFHGIHHGHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3EFCBE0", Offset = "0x3EFBFE0", VA = "0x183EFCBE0", Slot = "6")]
		public bool KHOGHBDAHAN(Exception KMJIPKGNLDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3EFCC20", Offset = "0x3EFC020", VA = "0x183EFCC20", Slot = "7")]
		public bool PIDNDLKOHMH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public const string GFPKOHJIGJK = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<Guid, EGJBKBLBODO> DBLLHCGFBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly MALBHNJOIFD PAPEFDFDIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool OHINFEEPPFE;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x64CFA80", Offset = "0x64CEE80", VA = "0x1864CFA80")]
	public JJOCBCLHEGP([Optional] MALBHNJOIFD PAPEFDFDIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x64CF480", Offset = "0x64CE880", VA = "0x1864CF480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26A0DE0", Offset = "0x26A01E0", VA = "0x1826A0DE0")]
	public JPHCKOJLPKA<TResult> OAHJCCFJGOP<TResult>(int BPFNFCAJELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x26A0AB0", Offset = "0x269FEB0", VA = "0x1826A0AB0")]
	public bool GOAPGKFIFEN<TResult>(Guid BMPBDIBKAJJ, TResult MNKBHKEBOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x64CF360", Offset = "0x64CE760", VA = "0x1864CF360")]
	private void CJIHIEGHFLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x64CF480", Offset = "0x64CE880", VA = "0x1864CF480")]
	private void HEKAADHIDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x64CF590", Offset = "0x64CE990", VA = "0x1864CF590")]
	private void EHDIGJHFLEG(int ADANFKPCFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x64CF880", Offset = "0x64CEC80", VA = "0x1864CF880")]
	private void IJMIOJOHHBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum DHAGLPKEIDO
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LNFEPBNPLEE<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class GFMDIJBGAMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int OBPPGJNCIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int JFINGOFABOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int OPFENEBMLIO;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public GFMDIJBGAMM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId FECGEAOBCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int BJDKLCEOKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public DHAGLPKEIDO MMGEJCLJHDM;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xD64FD0", Offset = "0xD643D0", VA = "0x180D64FD0")]
	public LNFEPBNPLEE(TItemId PEOPGGKHFEK, int OGKNDCGCKLO, DHAGLPKEIDO JIBNFGIMNPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class OFMEBKEFILN<TItemId, TResult> : ILFOPEOOOML<LNFEPBNPLEE<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x36E2040", Offset = "0x36E1440", VA = "0x1836E2040")]
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

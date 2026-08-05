using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GJJDONCPPAE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BFDLNMJLLMD(int LLAJBLAPPFH, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BFDLNMJLLMD(TimeSpan JIMLMGKADIA, CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class OLKLNGGPEMK : GJJDONCPPAE
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7641200", Offset = "0x763FA00", VA = "0x187641200")]
	[PDAMAKFHAHC.GNFCFDNPMLH.BGLEOICIJCF]
	internal static void ANCFBKBPAGI(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	[RecRoom.NoEngine.Common.Preserve]
	public OLKLNGGPEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x76412F0", Offset = "0x763FAF0", VA = "0x1876412F0", Slot = "4")]
	public Task BFDLNMJLLMD(int LLAJBLAPPFH, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7641350", Offset = "0x763FB50", VA = "0x187641350", Slot = "5")]
	public Task BFDLNMJLLMD(TimeSpan JIMLMGKADIA, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x76413B0", Offset = "0x763FBB0", VA = "0x1876413B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CFLHHBLJHPC<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct AONNGELICOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest BPOCLEJAMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> OBLKLADHHJB;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xE64E60", Offset = "0xE63660", VA = "0x180E64E60")]
		public AONNGELICOI(TRequest BPCGMGBPPCA, TaskCompletionSource<TResult> PIEKLBNIMOE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct DHJPFJFHNPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CFLHHBLJHPC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4150", Offset = "0x5DE2950", VA = "0x185DE4150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4209FB0", Offset = "0x42087B0", VA = "0x184209FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LAFBFOJAHPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public CFLHHBLJHPC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x46F1D40", Offset = "0x46F0540", VA = "0x1846F1D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x46F2120", Offset = "0x46F0920", VA = "0x1846F2120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PLNGOLKCJBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CFLHHBLJHPC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4C74480", Offset = "0x4C72C80", VA = "0x184C74480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4C74930", Offset = "0x4C73130", VA = "0x184C74930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct IHNJHEFCCNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CFLHHBLJHPC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<TRequest> <requests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4312660", Offset = "0x4310E60", VA = "0x184312660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4313810", Offset = "0x4312010", VA = "0x184313810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly AKNGNPBJAKK<TRequest, TResult> DIMJIACDGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float HIMAJPIKKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly GJJDONCPPAE NHIOFEPMPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool KDIMMKJKHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<AONNGELICOI> NGHDPLGAFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<AONNGELICOI> JOOAGFBLEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool MLPNHFKKKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource DGJHGLNBJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource IAAPLICNNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task HKEDNNDIODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float MNBHMPFPLAD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LJDEGIELPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1E0", Offset = "0x8BB9E0", VA = "0x1808BD1E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1C0", Offset = "0x8BB9C0", VA = "0x1808BD1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5843F10", Offset = "0x5842710", VA = "0x185843F10")]
	public CFLHHBLJHPC(AKNGNPBJAKK<TRequest, TResult> DIMJIACDGKO, TimeSpan HIMAJPIKKNH, bool KDIMMKJKHOM, [Optional] GJJDONCPPAE NHIOFEPMPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5843680", Offset = "0x5841E80", VA = "0x185843680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x58434C0", Offset = "0x5841CC0", VA = "0x1858434C0")]
	[AsyncStateMachine(typeof(CFLHHBLJHPC<, >.DHJPFJFHNPA))]
	public Task<TResult> COGPHDGAHDJ(TRequest BPCGMGBPPCA, [Optional] CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x58435E0", Offset = "0x5841DE0", VA = "0x1858435E0")]
	private void COGPHDGAHDJ(TRequest BPCGMGBPPCA, TaskCompletionSource<TResult> PIEKLBNIMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5843DB0", Offset = "0x58425B0", VA = "0x185843DB0")]
	public Task LFDFELHGIKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5843CE0", Offset = "0x58424E0", VA = "0x185843CE0")]
	[AsyncStateMachine(typeof(CFLHHBLJHPC<, >.LAFBFOJAHPD))]
	private Task GIFINDEGFPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x58438C0", Offset = "0x58420C0", VA = "0x1858438C0")]
	[AsyncStateMachine(typeof(CFLHHBLJHPC<, >.PLNGOLKCJBL))]
	private Task EFNMLNBJOOE(CancellationToken FBOKPPJABFB, CancellationToken DJPHNJLBBMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x58439E0", Offset = "0x58421E0", VA = "0x1858439E0")]
	[AsyncStateMachine(typeof(CFLHHBLJHPC<, >.IHNJHEFCCNN))]
	private Task EHFKBDJEAAL(CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5843AE0", Offset = "0x58422E0", VA = "0x185843AE0")]
	private TimeSpan FNGNOMIECGM()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5843BC0", Offset = "0x58423C0", VA = "0x185843BC0")]
	private Task<List<TResult>> GHMJPOBBJJC(IReadOnlyList<TRequest> OGGNALBGGIL, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5843E70", Offset = "0x5842670", VA = "0x185843E70")]
	private float MEGFKMCOPIE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5843420", Offset = "0x5841C20", VA = "0x185843420")]
	private void CHMNPAAOEIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GANEAGBBDKH<TItemId, TResult> : AKNGNPBJAKK<DKFAPBLNION<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> PHPBBMKPDAH(Dictionary<TItemId, int> OGGNALBGGIL, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class AJOHCAPAHGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public AJOHCAPAHGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x43A2BA0", Offset = "0x43A13A0", VA = "0x1843A2BA0")]
		internal TResult LAOENLHIHBF(DKFAPBLNION<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct INCHNJLFMPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<DKFAPBLNION<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GANEAGBBDKH<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private AJOHCAPAHGI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4331EB0", Offset = "0x43306B0", VA = "0x184331EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4332C10", Offset = "0x4331410", VA = "0x184332C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly PHPBBMKPDAH MNMDFOKBEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> HADPFNKGDNF;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x411C2B0", Offset = "0x411AAB0", VA = "0x18411C2B0")]
	public GANEAGBBDKH(PHPBBMKPDAH MNMDFOKBEOL, [Optional] IEqualityComparer<TItemId> HADPFNKGDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x411C010", Offset = "0x411A810", VA = "0x18411C010", Slot = "4")]
	[AsyncStateMachine(typeof(GANEAGBBDKH<, >.INCHNJLFMPC))]
	public Task<List<TResult>> CFDNOAHKKEG(IReadOnlyList<DKFAPBLNION<TItemId>> OGGNALBGGIL, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KNMOKHDBEHP<TRequest, TResult> : AKNGNPBJAKK<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> ABFDNPEHJCO(IEnumerable<TRequest> BGNOGOGONLL, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class NDCIPEEELEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NDCIPEEELEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x40F6EF0", Offset = "0x40F56F0", VA = "0x1840F6EF0")]
		internal TResult LAOENLHIHBF(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct JEAEIMMNLCE : IAsyncStateMachine
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
		public KNMOKHDBEHP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private NDCIPEEELEF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4526320", Offset = "0x4524B20", VA = "0x184526320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4527180", Offset = "0x4525980", VA = "0x184527180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly ABFDNPEHJCO MNMDFOKBEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> HADPFNKGDNF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x411C2B0", Offset = "0x411AAB0", VA = "0x18411C2B0")]
	public KNMOKHDBEHP(ABFDNPEHJCO MNMDFOKBEOL, [Optional] IEqualityComparer<TRequest> HADPFNKGDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4674EE0", Offset = "0x46736E0", VA = "0x184674EE0", Slot = "4")]
	[AsyncStateMachine(typeof(KNMOKHDBEHP<, >.JEAEIMMNLCE))]
	public Task<List<TResult>> CFDNOAHKKEG(IReadOnlyList<TRequest> OGGNALBGGIL, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AKNGNPBJAKK<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> CFDNOAHKKEG(IReadOnlyList<TRequest> OGGNALBGGIL, CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GEIGCJINFNJ<TItemId, TResult> : AKNGNPBJAKK<DCPCAJOPCAI<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task PJGJMIEIJOE(IReadOnlyDictionary<TItemId, DCPCAJOPCAI<TItemId>.JPMGNBNNHDC> OGGNALBGGIL, CancellationToken ALKEMFHOMCA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct MLHKIPAAFOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public GEIGCJINFNJ<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<DCPCAJOPCAI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x49E46B0", Offset = "0x49E2EB0", VA = "0x1849E46B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x49E4C10", Offset = "0x49E3410", VA = "0x1849E4C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly PJGJMIEIJOE ANKJKMPONLB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	public GEIGCJINFNJ(PJGJMIEIJOE ANKJKMPONLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4125950", Offset = "0x4124150", VA = "0x184125950", Slot = "4")]
	[AsyncStateMachine(typeof(GEIGCJINFNJ<, >.MLHKIPAAFOM))]
	public Task<List<object>> CFDNOAHKKEG(IReadOnlyList<DCPCAJOPCAI<TItemId>> OGGNALBGGIL, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4125A90", Offset = "0x4124290", VA = "0x184125A90")]
	private IReadOnlyDictionary<TItemId, DCPCAJOPCAI<TItemId>.JPMGNBNNHDC> JMDOMLJFBFE(IReadOnlyList<DCPCAJOPCAI<TItemId>> KKAOINHAEEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GOPJEMPPKDH<TItemId, TResult> : AKNGNPBJAKK<DKFAPBLNION<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> LPDBICLHCLA(Dictionary<TItemId, int> OGGNALBGGIL, CancellationToken ALKEMFHOMCA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct CKMFBHCLLIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<DKFAPBLNION<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public GOPJEMPPKDH<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5931530", Offset = "0x592FD30", VA = "0x185931530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x59321F0", Offset = "0x59309F0", VA = "0x1859321F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly LPDBICLHCLA GBJLAIHOEAI;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	public GOPJEMPPKDH(LPDBICLHCLA MNMDFOKBEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x41D3740", Offset = "0x41D1F40", VA = "0x1841D3740", Slot = "4")]
	[AsyncStateMachine(typeof(GOPJEMPPKDH<, >.CKMFBHCLLIN))]
	public Task<List<TResult>> CFDNOAHKKEG(IReadOnlyList<DKFAPBLNION<TItemId>> OGGNALBGGIL, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LILNAMENHBD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, GMEKKAAMOLN> CMJKNKGDEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> GCOCDEGMOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> PGEPFFGCLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> NOEKPGONGBC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, GMEKKAAMOLN> NMKJMDKJAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> DJNNLCAOBAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IMIPDEHPLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x958980", Offset = "0x957180", VA = "0x180958980")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x95C4E0", Offset = "0x95ACE0", VA = "0x18095C4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x473C080", Offset = "0x473A880", VA = "0x18473C080")]
	public LILNAMENHBD(Func<IEnumerable<T>> PGEPFFGCLAO, Func<T, string> NOEKPGONGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x473BDC0", Offset = "0x473A5C0", VA = "0x18473BDC0")]
	public void LHNLPLKLOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x473BD30", Offset = "0x473A530", VA = "0x18473BD30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FAMNCALBPCD<TItemId, TResult> : CFLHHBLJHPC<DKFAPBLNION<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4050CE0", Offset = "0x404F4E0", VA = "0x184050CE0")]
	public FAMNCALBPCD(AKNGNPBJAKK<DKFAPBLNION<TItemId>, TResult> DIMJIACDGKO, TimeSpan HIMAJPIKKNH, bool KDIMMKJKHOM, [Optional] GJJDONCPPAE NHIOFEPMPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x40506B0", Offset = "0x404EEB0", VA = "0x1840506B0")]
	public Task<TResult> COGPHDGAHDJ(TItemId KCGKBDGKIOP, int CEHMFIFBHOE, [Optional] CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DKFAPBLNION<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId JKLPFAPGAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int ALPFLGHKMHH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE460", Offset = "0x5DECC60", VA = "0x185DEE460")]
	public DKFAPBLNION(TItemId FGAKIHGJJAJ, int CEHMFIFBHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KODPCNKLPIM<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid PBIELHOLMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> KHGLFFELCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NJFKCDEIMBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface HNBHEIEDNPP
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int LMIFOPIGJID
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool JBIEGFOABEA<TParam>(TParam INDENPJBLHO);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool JACAONFKOIP(Exception MDGFDHAJGLD);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool OIFDJJAAPNG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class JNNFCDLCBNF<TResult> : HNBHEIEDNPP, KODPCNKLPIM<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> BOBBGFPNGHE;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid PBIELHOLMJH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB2DD30", Offset = "0xB2C530", VA = "0x180B2DD30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int LMIFOPIGJID
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x958980", Offset = "0x957180", VA = "0x180958980", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> KHGLFFELCCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4563FD0", Offset = "0x45627D0", VA = "0x184563FD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4564070", Offset = "0x4562870", VA = "0x184564070")]
		public JNNFCDLCBNF(int LFFPBBMHEHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3144D60", Offset = "0x3143560", VA = "0x183144D60", Slot = "5")]
		public bool JBIEGFOABEA<TParam>(TParam INDENPJBLHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4563F80", Offset = "0x4562780", VA = "0x184563F80", Slot = "6")]
		public bool JACAONFKOIP(Exception MDGFDHAJGLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4564020", Offset = "0x4562820", VA = "0x184564020", Slot = "7")]
		public bool OIFDJJAAPNG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string GNNNFGJNKGF = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, HNBHEIEDNPP> DPCHEPLHBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly MEJCKJGIGIH MMMJHOMEFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool FPNDPLNOKBL;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7641100", Offset = "0x763F900", VA = "0x187641100")]
	public NJFKCDEIMBN([Optional] MEJCKJGIGIH MMMJHOMEFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x76409F0", Offset = "0x763F1F0", VA = "0x1876409F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x31D34D0", Offset = "0x31D1CD0", VA = "0x1831D34D0")]
	public KODPCNKLPIM<TResult> KJCHGDGKCHF<TResult>(int BBDBJLKKFGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x31D37F0", Offset = "0x31D1FF0", VA = "0x1831D37F0")]
	public bool OKMJKMDALMN<TResult>(Guid PHACDDBECOP, TResult HANDIANDCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7640FE0", Offset = "0x763F7E0", VA = "0x187640FE0")]
	private void GBOLELNLKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x76409F0", Offset = "0x763F1F0", VA = "0x1876409F0")]
	private void DJNLPOMDCBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7640B00", Offset = "0x763F300", VA = "0x187640B00")]
	private void DKABLLCOIAH(int LFFPBBMHEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7640DE0", Offset = "0x763F5E0", VA = "0x187640DE0")]
	private void EONCBNCPHIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum OLACIJAOOPI
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DCPCAJOPCAI<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class JPMGNBNNHDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int EDHFHOJHEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int PHNDNJGLEEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int IPCNCKDFKDM;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public JPMGNBNNHDC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId JKLPFAPGAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int ALPFLGHKMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public OLACIJAOOPI NGPLNFABDBP;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x181CE00", Offset = "0x181B600", VA = "0x18181CE00")]
	public DCPCAJOPCAI(TItemId FGAKIHGJJAJ, int CEHMFIFBHOE, OLACIJAOOPI IHDNMHOODCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class BCLHNPHAKFE<TItemId, TResult> : CFLHHBLJHPC<DCPCAJOPCAI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x539AB40", Offset = "0x5399340", VA = "0x18539AB40")]
	public BCLHNPHAKFE(AKNGNPBJAKK<DCPCAJOPCAI<TItemId>, TResult> DIMJIACDGKO, TimeSpan HIMAJPIKKNH, [Optional] GJJDONCPPAE NHIOFEPMPGJ)
	{
	}
}
namespace Cpp2IlInjected
{
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
}

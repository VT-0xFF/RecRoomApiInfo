using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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
public interface BHBKAOHPBKK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FJONLFNADPO(int CBACAFKJEOM, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FJONLFNADPO(TimeSpan BKAJDACBOFH, CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IPGAGEOFECB : BHBKAOHPBKK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x85D7940", Offset = "0x85D6540", VA = "0x1885D7940")]
	[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
	internal static void OMKCNNEBHOD(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IPGAGEOFECB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85D78E0", Offset = "0x85D64E0", VA = "0x1885D78E0", Slot = "4")]
	public Task FJONLFNADPO(int CBACAFKJEOM, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x85D7880", Offset = "0x85D6480", VA = "0x1885D7880", Slot = "5")]
	public Task FJONLFNADPO(TimeSpan BKAJDACBOFH, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85D7BB0", Offset = "0x85D67B0", VA = "0x1885D7BB0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KKNBFFDDNKP : PDMELFKLMED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private JBLDADGINPM DFIOBOBCGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NBDOEJMAKOF<bool> LCGDCDKCILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NBDOEJMAKOF<bool> BGEOIJIDPGO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CBHNNIGGJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x85D7A00", Offset = "0x85D6600", VA = "0x1885D7A00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MDEHCIBKMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85D79B0", Offset = "0x85D65B0", VA = "0x1885D79B0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x85D7A50", Offset = "0x85D6650", VA = "0x1885D7A50")]
	[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
	internal static void OMKCNNEBHOD(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x85D7AC0", Offset = "0x85D66C0", VA = "0x1885D7AC0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KKNBFFDDNKP([GFNPNOLPMKK(null)][NotNull] JBLDADGINPM DFIOBOBCGMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GHBDDGIMPLI<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct DHJGIKOOLPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public TRequest GBEEPPGAEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TaskCompletionSource<TResult> MNHCFONCGGP;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB5F450", Offset = "0xB5E050", VA = "0x180B5F450")]
		public DHJGIKOOLPL(TRequest BJAGJMJPKHA, TaskCompletionSource<TResult> GDDLEADELHG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct GGILNHBBPLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public GHBDDGIMPLI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4D0F400", Offset = "0x4D0E000", VA = "0x184D0F400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x472D160", Offset = "0x472BD60", VA = "0x18472D160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DFMHIONHLHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public GHBDDGIMPLI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x429D990", Offset = "0x429C590", VA = "0x18429D990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x429DD50", Offset = "0x429C950", VA = "0x18429DD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct OCEOCDLIFEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public GHBDDGIMPLI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5657940", Offset = "0x5656540", VA = "0x185657940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5657DD0", Offset = "0x56569D0", VA = "0x185657DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HELOGBAKBAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public GHBDDGIMPLI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private List<TRequest> <requests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4D8CFD0", Offset = "0x4D8BBD0", VA = "0x184D8CFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E040", Offset = "0x4D8CC40", VA = "0x184D8E040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly FGMJHNFDDKO<TRequest, TResult> PPGJDPFLPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly float MJFJLBAHHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly BHBKAOHPBKK AHGAKCIMJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly bool HKJMAHBLAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly List<DHJGIKOOLPL> PGKOEHHDICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly List<DHJGIKOOLPL> LHALMFMFCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool GANLDJOINED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource DBINMCLOPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CancellationTokenSource DGFLNDDMGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Task IELPCKEMNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private float LFLMLMEFAHB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PHEIOPHLIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23230", VA = "0x180A24630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA248B0", Offset = "0xA234B0", VA = "0x180A248B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D10A10", Offset = "0x4D0F610", VA = "0x184D10A10")]
	public GHBDDGIMPLI(FGMJHNFDDKO<TRequest, TResult> PPGJDPFLPMA, TimeSpan MJFJLBAHHLO, bool HKJMAHBLAIA, [Optional] BHBKAOHPBKK AHGAKCIMJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4D10180", Offset = "0x4D0ED80", VA = "0x184D10180", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4D10870", Offset = "0x4D0F470", VA = "0x184D10870")]
	[AsyncStateMachine(typeof(GHBDDGIMPLI<, >.GGILNHBBPLO))]
	public Task<TResult> MBEAHHBGAMM(TRequest BJAGJMJPKHA, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4D10990", Offset = "0x4D0F590", VA = "0x184D10990")]
	private void MBEAHHBGAMM(TRequest BJAGJMJPKHA, TaskCompletionSource<TResult> GDDLEADELHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D0FFC0", Offset = "0x4D0EBC0", VA = "0x184D0FFC0")]
	public Task CEIONOAHBIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4D10450", Offset = "0x4D0F050", VA = "0x184D10450")]
	[AsyncStateMachine(typeof(GHBDDGIMPLI<, >.DFMHIONHLHA))]
	private Task LDBHAJPDNAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4D10520", Offset = "0x4D0F120", VA = "0x184D10520")]
	[AsyncStateMachine(typeof(GHBDDGIMPLI<, >.OCEOCDLIFEM))]
	private Task LHHBJGCPAPA(CancellationToken APAGBOLGEFE, CancellationToken CJJFEDMOMLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4D10080", Offset = "0x4D0EC80", VA = "0x184D10080")]
	[AsyncStateMachine(typeof(GHBDDGIMPLI<, >.HELOGBAKBAM))]
	private Task DENLEMDEIPJ(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4D10380", Offset = "0x4D0EF80", VA = "0x184D10380")]
	private TimeSpan HNKJBEJMNBH()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4D10640", Offset = "0x4D0F240", VA = "0x184D10640")]
	private Task<List<TResult>> LIFEEACBCFM(IReadOnlyList<TRequest> MEDKCOHHKEH, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4D10740", Offset = "0x4D0F340", VA = "0x184D10740")]
	private float LKMFDBFFBKP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4D107E0", Offset = "0x4D0F3E0", VA = "0x184D107E0")]
	private void LMNELMMKDDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LLOJAGGMMDD<TItemId, TResult> : FGMJHNFDDKO<GIEJIPLDDOO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> IKHIJKIBBPK(Dictionary<TItemId, int> MEDKCOHHKEH, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class JPJIFKMAJKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JPJIFKMAJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5118AA0", Offset = "0x51176A0", VA = "0x185118AA0")]
		internal TResult EENGEFDPNKA(GIEJIPLDDOO<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GKAMGOLMHGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public IReadOnlyList<GIEJIPLDDOO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public LLOJAGGMMDD<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private JPJIFKMAJKG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4D18A60", Offset = "0x4D17660", VA = "0x184D18A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4D196E0", Offset = "0x4D182E0", VA = "0x184D196E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly IKHIJKIBBPK LMBPBJLGLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly IEqualityComparer<TItemId> DIMPLJBNCJB;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D85AA0", Offset = "0x4D846A0", VA = "0x184D85AA0")]
	public LLOJAGGMMDD(IKHIJKIBBPK LMBPBJLGLFC, [Optional] IEqualityComparer<TItemId> DIMPLJBNCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x52C3D90", Offset = "0x52C2990", VA = "0x1852C3D90", Slot = "4")]
	[AsyncStateMachine(typeof(LLOJAGGMMDD<, >.GKAMGOLMHGG))]
	public Task<List<TResult>> ABDOPKDKIIB(IReadOnlyList<GIEJIPLDDOO<TItemId>> MEDKCOHHKEH, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HBBBGEDOIBE<TRequest, TResult> : FGMJHNFDDKO<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> BGHEBFMLOBA(IEnumerable<TRequest> KPNJGDJFCEM, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class EJDBAALGKOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EJDBAALGKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x42DCC80", Offset = "0x42DB880", VA = "0x1842DCC80")]
		internal TResult EENGEFDPNKA(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct LPCLLPGEHIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public IReadOnlyList<TRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public HBBBGEDOIBE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private EJDBAALGKOE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x52D33A0", Offset = "0x52D1FA0", VA = "0x1852D33A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x52D40F0", Offset = "0x52D2CF0", VA = "0x1852D40F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly BGHEBFMLOBA LMBPBJLGLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly IEqualityComparer<TRequest> DIMPLJBNCJB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4D85AA0", Offset = "0x4D846A0", VA = "0x184D85AA0")]
	public HBBBGEDOIBE(BGHEBFMLOBA LMBPBJLGLFC, [Optional] IEqualityComparer<TRequest> DIMPLJBNCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4D85960", Offset = "0x4D84560", VA = "0x184D85960", Slot = "4")]
	[AsyncStateMachine(typeof(HBBBGEDOIBE<, >.LPCLLPGEHIC))]
	public Task<List<TResult>> ABDOPKDKIIB(IReadOnlyList<TRequest> MEDKCOHHKEH, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FGMJHNFDDKO<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> ABDOPKDKIIB(IReadOnlyList<TRequest> MEDKCOHHKEH, CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HPMMEKNEBCO<TItemId, TResult> : FGMJHNFDDKO<MNCAGDLOPMK<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task FIGIGMHPPKG(IReadOnlyDictionary<TItemId, MNCAGDLOPMK<TItemId>.HNEPDJCCLBD> MEDKCOHHKEH, CancellationToken DKKNFNCKCEB);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct LLNFGCFJLCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public HPMMEKNEBCO<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<MNCAGDLOPMK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x52C36F0", Offset = "0x52C22F0", VA = "0x1852C36F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x52C3BE0", Offset = "0x52C27E0", VA = "0x1852C3BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly FIGIGMHPPKG APCLIPEPLJE;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public HPMMEKNEBCO(FIGIGMHPPKG APCLIPEPLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4DC1030", Offset = "0x4DBFC30", VA = "0x184DC1030", Slot = "4")]
	[AsyncStateMachine(typeof(HPMMEKNEBCO<, >.LLNFGCFJLCK))]
	public Task<List<object>> ABDOPKDKIIB(IReadOnlyList<MNCAGDLOPMK<TItemId>> MEDKCOHHKEH, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4DC1170", Offset = "0x4DBFD70", VA = "0x184DC1170")]
	private IReadOnlyDictionary<TItemId, MNCAGDLOPMK<TItemId>.HNEPDJCCLBD> LKAMCMFBHDL(IReadOnlyList<MNCAGDLOPMK<TItemId>> NPOOKNGBCLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GHEGMKFMIJC<TItemId, TResult> : FGMJHNFDDKO<GIEJIPLDDOO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate Task<Dictionary<TItemId, TResult>> MCEFFODAJEK(Dictionary<TItemId, int> MEDKCOHHKEH, CancellationToken DKKNFNCKCEB);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct JNHGAALJJCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IReadOnlyList<GIEJIPLDDOO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public GHEGMKFMIJC<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5110440", Offset = "0x510F040", VA = "0x185110440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5111040", Offset = "0x510FC40", VA = "0x185111040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly MCEFFODAJEK LKPBLGPGICB;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public GHEGMKFMIJC(MCEFFODAJEK LMBPBJLGLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4D10E80", Offset = "0x4D0FA80", VA = "0x184D10E80", Slot = "4")]
	[AsyncStateMachine(typeof(GHEGMKFMIJC<, >.JNHGAALJJCI))]
	public Task<List<TResult>> ABDOPKDKIIB(IReadOnlyList<GIEJIPLDDOO<TItemId>> MEDKCOHHKEH, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ANHMILFLNEI<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Dictionary<string, PDAOBOECEPN> EPLMEIEFIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<T> JIOOMJNLHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private Func<IEnumerable<T>> IFCFPJEEGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Func<T, string> HOPLJBJBGKF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<string, PDAOBOECEPN> EJKKCFHKILI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<T> FKJPBPNPABP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KHKCNLKOGNE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA768B0", Offset = "0xA754B0", VA = "0x180A768B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA76890", Offset = "0xA75490", VA = "0x180A76890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x506C6B0", Offset = "0x506B2B0", VA = "0x18506C6B0")]
	public ANHMILFLNEI(Func<IEnumerable<T>> IFCFPJEEGHI, Func<T, string> HOPLJBJBGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x506C460", Offset = "0x506B060", VA = "0x18506C460")]
	public void NJCBLGMIGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x506C3F0", Offset = "0x506AFF0", VA = "0x18506C3F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DLFKKEEKONA<TItemId, TResult> : GHBDDGIMPLI<GIEJIPLDDOO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x42C4B90", Offset = "0x42C3790", VA = "0x1842C4B90")]
	public DLFKKEEKONA(FGMJHNFDDKO<GIEJIPLDDOO<TItemId>, TResult> PPGJDPFLPMA, TimeSpan MJFJLBAHHLO, bool HKJMAHBLAIA, [Optional] BHBKAOHPBKK AHGAKCIMJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x42C47A0", Offset = "0x42C33A0", VA = "0x1842C47A0")]
	public Task<TResult> MBEAHHBGAMM(TItemId MEPFFFGIFGB, int KCCIFDBLGOI, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class GIEJIPLDDOO<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId DCCKFOJOPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int AGFKBDKEALP;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4D13680", Offset = "0x4D12280", VA = "0x184D13680")]
	public GIEJIPLDDOO(TItemId DGLGMEAJHHO, int KCCIFDBLGOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface COBNGIFONNE<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Guid GHDCEEHHGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Task<TResult> BBPNJKBPHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class AOPFHIJAPGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private interface DJHMCJAIBBE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int EKLGPMBMMMG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OLOCKDLKIKL<TParam>(TParam OOHGFGHCOAJ);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool EGPJENPBPDH(Exception FCEJBDLGOKN);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool JFMAHGAJIGM();
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private class BLIEHLHCCGG<TResult> : DJHMCJAIBBE, COBNGIFONNE<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly TaskCompletionSource<TResult> GGCMENFMEPO;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Guid GHDCEEHHGPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xDDC970", Offset = "0xDDB570", VA = "0x180DDC970", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int EKLGPMBMMMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA768B0", Offset = "0xA754B0", VA = "0x180A768B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Task<TResult> BBPNJKBPHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x550C070", Offset = "0x550AC70", VA = "0x18550C070", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6480890", Offset = "0x647F490", VA = "0x186480890")]
		public BLIEHLHCCGG(int KBLOFCODEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B6B0", Offset = "0x3C1A2B0", VA = "0x183C1B6B0", Slot = "5")]
		public bool OLOCKDLKIKL<TParam>(TParam OOHGFGHCOAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6480810", Offset = "0x647F410", VA = "0x186480810", Slot = "6")]
		public bool EGPJENPBPDH(Exception FCEJBDLGOKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6480850", Offset = "0x647F450", VA = "0x186480850", Slot = "7")]
		public bool JFMAHGAJIGM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public const string JJDNDBHEHLF = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<Guid, DJHMCJAIBBE> ADEPCLEMMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly KDFCOCHKBIK DIIMNAKLFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool JAFNGBHMGEJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x85D7780", Offset = "0x85D6380", VA = "0x1885D7780")]
	public AOPFHIJAPGH([Optional] KDFCOCHKBIK DIIMNAKLFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x85D7070", Offset = "0x85D5C70", VA = "0x1885D7070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x304CE40", Offset = "0x304BA40", VA = "0x18304CE40")]
	public COBNGIFONNE<TResult> HKFOOECINDH<TResult>(int KBFGEEBHBOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x304D0E0", Offset = "0x304BCE0", VA = "0x18304D0E0")]
	public bool JAOBBCGELIM<TResult>(Guid DIPCJMNHKDB, TResult DBJBIPJCIKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x85D7180", Offset = "0x85D5D80", VA = "0x1885D7180")]
	private void BNLFEEBAPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x85D7070", Offset = "0x85D5C70", VA = "0x1885D7070")]
	private void AOKNLGJKJNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x85D72A0", Offset = "0x85D5EA0", VA = "0x1885D72A0")]
	private void CFPBDBILHNH(int KBLOFCODEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x85D7580", Offset = "0x85D6180", VA = "0x1885D7580")]
	private void FCCIEJKODPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum KMHLPJHPEPK
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MNCAGDLOPMK<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class HNEPDJCCLBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int IDEMFFAGFMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int MOGFHIHFBKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int OMJHNDEDJCF;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public HNEPDJCCLBD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public TItemId DCCKFOJOPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int AGFKBDKEALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public KMHLPJHPEPK NEFPLGCMEMF;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC8B0", Offset = "0x1FFB4B0", VA = "0x181FFC8B0")]
	public MNCAGDLOPMK(TItemId DGLGMEAJHHO, int KCCIFDBLGOI, KMHLPJHPEPK GBEGHJIHKEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class GEMHLHAGCPD<TItemId, TResult> : GHBDDGIMPLI<MNCAGDLOPMK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4D09550", Offset = "0x4D08150", VA = "0x184D09550")]
	public GEMHLHAGCPD(FGMJHNFDDKO<MNCAGDLOPMK<TItemId>, TResult> PPGJDPFLPMA, TimeSpan MJFJLBAHHLO, [Optional] BHBKAOHPBKK AHGAKCIMJPD)
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

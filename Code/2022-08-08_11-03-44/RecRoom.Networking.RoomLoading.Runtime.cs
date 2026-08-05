using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class FOHFMBFBNIP : global::IGKKAHEDLOC<IHOKGNKGKNH>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class FOAIPFIIFEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public FOAIPFIIFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5723DB0", Offset = "0x5722DB0", VA = "0x185723DB0")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] OIHLPAFEDKE;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly FOHFMBFBNIP CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5723E50", Offset = "0x5722E50", VA = "0x185723E50", Slot = "5")]
	protected override void DNKFHLIGJND(IHOKGNKGKNH LPDLECBMBMG, IDictionary<object, object> JEJGBICCBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5724240", Offset = "0x5723240", VA = "0x185724240", Slot = "6")]
	public override IHOKGNKGKNH HIDKAFCIGIB(IDictionary<object, object> JEJGBICCBLN)
	{
		return default(IHOKGNKGKNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5724D10", Offset = "0x5723D10", VA = "0x185724D10")]
	public FOHFMBFBNIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class OHNBBLGLCIB
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string HNIAGMCEBLA([NotNull] byte[] PHHFPJMDJAF);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum NDNJMHHNEAG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Operation = 1,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		RoomLoad = 2,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		MasterBlock = 4
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct GFAAKBNLDOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly NDNJMHHNEAG ABHCBLEKNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Guid NIEOFOFPAIG;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x46EBBE0", Offset = "0x46EABE0", VA = "0x1846EBBE0")]
		public GFAAKBNLDOD(NDNJMHHNEAG IHIKLCBNCMF, Guid AJGFNANMPNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5724E40", Offset = "0x5723E40", VA = "0x185724E40")]
		public bool MHJPJGBBFJN(GFAAKBNLDOD IJDAJAEAAKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5724D50", Offset = "0x5723D50", VA = "0x185724D50", Slot = "0")]
		public override bool Equals(object MDAEAKFNGDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5724E10", Offset = "0x5723E10", VA = "0x185724E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct ELKFHENBDHA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly bool OIFPMHODDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly NDNJMHHNEAG ABHCBLEKNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Guid[] LECCIFDKPLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly T IEAOCELNECM;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x26C87B0", Offset = "0x26C77B0", VA = "0x1826C87B0")]
		public static ELKFHENBDHA<T> DOHOGKKADEB(IHOKGNKGKNH LMECBLOHLKM, Func<byte[], T> JIIHEOMANDG)
		{
			return default(ELKFHENBDHA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x26C8BC0", Offset = "0x26C7BC0", VA = "0x1826C8BC0")]
		public ELKFHENBDHA(NDNJMHHNEAG IHIKLCBNCMF, Guid[] AICDGLOJJFB, T PHHFPJMDJAF, bool KAABOLMNIEM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x26C8AA0", Offset = "0x26C7AA0", VA = "0x1826C8AA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class JEHAGBGJEIG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class NGADDEBKKFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public TaskCompletionSource<IHOKGNKGKNH> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public JEHAGBGJEIG <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			public NGADDEBKKFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5727DC0", Offset = "0x5726DC0", VA = "0x185727DC0")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5727E10", Offset = "0x5726E10", VA = "0x185727E10")]
			internal HGOPFMNEGMP <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class KHMOPFENFNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public BFEBPFNDEKA.BGNBHNKLJAC itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			public KHMOPFENFNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5726220", Offset = "0x5725220", VA = "0x185726220")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct LCEDJEHEKNL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<IHOKGNKGKNH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public JEHAGBGJEIG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private NGADDEBKKFO <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private TaskAwaiter<IHOKGNKGKNH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5726590", Offset = "0x5725590", VA = "0x185726590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5726C40", Offset = "0x5725C40", VA = "0x185726C40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IMGMEGEFBLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public NDNJMHHNEAG sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			public IMGMEGEFBLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5725590", Offset = "0x5724590", VA = "0x185725590")]
			internal bool <ClearSlice>b__0(IHOKGNKGKNH bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GDEGAOBMPOI ICGIMGKLCPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly string EPHCOMAABHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly List<IHOKGNKGKNH> KBCHDAFNEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private List<(BFEBPFNDEKA.BGNBHNKLJAC itemType, long totalStopwatchTicks)> OMCOMOABMHB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MCLJKEFMOHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5725AB0", Offset = "0x5724AB0", VA = "0x185725AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<IHOKGNKGKNH> ILIHCBJCFPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5725790", Offset = "0x5724790", VA = "0x185725790")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5725BA0", Offset = "0x5724BA0", VA = "0x185725BA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5725C40", Offset = "0x5724C40", VA = "0x185725C40")]
		public JEHAGBGJEIG(GDEGAOBMPOI ICGIMGKLCPI, string EPHCOMAABHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5725970", Offset = "0x5724970", VA = "0x185725970")]
		[AsyncStateMachine(typeof(LCEDJEHEKNL))]
		public Task<IHOKGNKGKNH> JJJAMECPGDN(CancellationToken JNDOKGNDNMO, TimeSpan HPLFELDFDJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5725AF0", Offset = "0x5724AF0", VA = "0x185725AF0")]
		public void LPGAPHIFFMC(IHOKGNKGKNH LPDLECBMBMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5725830", Offset = "0x5724830", VA = "0x185725830", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5725880", Offset = "0x5724880", VA = "0x185725880")]
		public void FAFDKJEBPGK(NDNJMHHNEAG IHIKLCBNCMF, Guid LGBAJKGIPMA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct CGLEMJLJAEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IHOKGNKGKNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public CHFLJCNHJAL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public OHNBBLGLCIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CHFLJCNHJAL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<IHOKGNKGKNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5722FB0", Offset = "0x5721FB0", VA = "0x185722FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5723790", Offset = "0x5722790", VA = "0x185723790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FIHNKLAFDOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public OHNBBLGLCIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CHFLJCNHJAL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CHFLJCNHJAL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<ELKFHENBDHA<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5723A40", Offset = "0x5722A40", VA = "0x185723A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5723D60", Offset = "0x5722D60", VA = "0x185723D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct OBGCIOHCKBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<IHOKGNKGKNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public OHNBBLGLCIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public CHFLJCNHJAL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CHFLJCNHJAL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Stopwatch <sw>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <frameStart>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<IHOKGNKGKNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x57284B0", Offset = "0x57274B0", VA = "0x1857284B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5728C00", Offset = "0x5727C00", VA = "0x185728C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class NAPNAOOOCFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public OHNBBLGLCIB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public NAPNAOOOCFK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct MBPMKNAAIBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AsyncTaskMethodBuilder<IHOKGNKGKNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public OHNBBLGLCIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private NAPNAOOOCFK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CHFLJCNHJAL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public CHFLJCNHJAL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private OLKNGAGOLDF <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<IHOKGNKGKNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x57273A0", Offset = "0x57263A0", VA = "0x1857273A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5727C10", Offset = "0x5726C10", VA = "0x185727C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct NOCIDIOGAON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<IHOKGNKGKNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public OHNBBLGLCIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CHFLJCNHJAL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CHFLJCNHJAL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<IHOKGNKGKNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5728130", Offset = "0x5727130", VA = "0x185728130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5728460", Offset = "0x5727460", VA = "0x185728460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BOKJIGJFEGC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct <<MasterLockedBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public BOKJIGJFEGC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x572D2A0", Offset = "0x572C2A0", VA = "0x18572D2A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x572D400", Offset = "0x572C400", VA = "0x18572D400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public BOKJIGJFEGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5722E10", Offset = "0x5721E10", VA = "0x185722E10")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct DFDODLMKGCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public OHNBBLGLCIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CHFLJCNHJAL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CHFLJCNHJAL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x57237E0", Offset = "0x57227E0", VA = "0x1857237E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JPAKDEICGKI : IEnumerable<(NDNJMHHNEAG, Guid)>, IEnumerable, IEnumerator<(NDNJMHHNEAG, Guid)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private (NDNJMHHNEAG sliceType, Guid sliceId) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private NDNJMHHNEAG sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public NDNJMHHNEAG <>3__sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Guid[] sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Guid[] <>3__sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private NDNJMHHNEAG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (NDNJMHHNEAG, Guid) System.Collections.Generic.IEnumerator<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2B76E90", Offset = "0x2B75E90", VA = "0x182B76E90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((NDNJMHHNEAG, Guid));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x57260B0", Offset = "0x57250B0", VA = "0x1857260B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7D0", Offset = "0xA0D7D0", VA = "0x180A0E7D0")]
		[DebuggerHidden]
		public JPAKDEICGKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5725D90", Offset = "0x5724D90", VA = "0x185725D90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5726060", Offset = "0x5725060", VA = "0x185726060", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5725FB0", Offset = "0x5724FB0", VA = "0x185725FB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(NDNJMHHNEAG, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5725FB0", Offset = "0x5724FB0", VA = "0x185725FB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LHLAANMHBIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public LHLAANMHBIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5726C90", Offset = "0x5725C90", VA = "0x185726C90")]
		internal object <OnEvent>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5726CD0", Offset = "0x5725CD0", VA = "0x185726CD0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5726D20", Offset = "0x5725D20", VA = "0x185726D20")]
		internal object <OnEvent>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class EKDIHPLPMKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public NDNJMHHNEAG sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public EKDIHPLPMKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x57239C0", Offset = "0x57229C0", VA = "0x1857239C0")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CDMLOACOLIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public NDNJMHHNEAG sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public CDMLOACOLIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5722F30", Offset = "0x5721F30", VA = "0x185722F30")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class LOKBCKCGCBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public LOKBCKCGCBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5726DF0", Offset = "0x5725DF0", VA = "0x185726DF0")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KDMCMKGHCFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public KDMCMKGHCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5726100", Offset = "0x5725100", VA = "0x185726100")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class IPPKEKAOHHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public IPPKEKAOHHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5725700", Offset = "0x5724700", VA = "0x185725700")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LMFFGJIKCMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public LMFFGJIKCMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5726D60", Offset = "0x5725D60", VA = "0x185726D60")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KDOBAHKLGAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Func<Guid, bool> matchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<Guid, bool> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Func<Guid, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public KDOBAHKLGAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x57261C0", Offset = "0x57251C0", VA = "0x1857261C0")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5726160", Offset = "0x5725160", VA = "0x185726160")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OBKMLJHHMPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public ExitGames.Client.Photon.Hashtable content;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public OBKMLJHHMPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5728C50", Offset = "0x5727C50", VA = "0x185728C50")]
		internal bool <ClearSliceIds>b__3(GFAAKBNLDOD stackSlice)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5728D50", Offset = "0x5727D50", VA = "0x185728D50")]
		internal object <ClearSliceIds>b__5()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5728F90", Offset = "0x5727F90", VA = "0x185728F90")]
		internal object <ClearSliceIds>b__6()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5728CF0", Offset = "0x5727CF0", VA = "0x185728CF0")]
		internal object <ClearSliceIds>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HNIAGMCEBLA AAKAOGMJMFM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable NNFEAHNHHFE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly KGDLICEAKGA OAPONAKAEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly JEHAGBGJEIG AKFIADGILCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly GDEGAOBMPOI ICGIMGKLCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly DMAPDFIAACO GJNDKJLHHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly KOMPOJLHJFL OFNMHBPBPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HNIAGMCEBLA PEHLMEOABLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool JBNHMJHHOJI;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan NDNGAEHBNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan MEKOGLMFDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte CDEDBGFJBEE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal static readonly NDNJMHHNEAG[] DDKPKGNABLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HashSet<Guid>[] FKOEOHDCJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<GFAAKBNLDOD> OJAEPOHOCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private (NDNJMHHNEAG combinedSliceType, Guid[] sliceTypeIds)? BLBPBMLOICL;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<IHOKGNKGKNH> BBEAKBIGKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x57291D0", Offset = "0x57281D0", VA = "0x1857291D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x572A740", Offset = "0x5729740", VA = "0x18572A740")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x572CAE0", Offset = "0x572BAE0", VA = "0x18572CAE0")]
	public OHNBBLGLCIB(GDEGAOBMPOI ICGIMGKLCPI, DMAPDFIAACO GJNDKJLHHFF, KOMPOJLHJFL OFNMHBPBPPL, [Optional] TimeSpan? DKIMFCJBBCE, [Optional] HNIAGMCEBLA CICEHMGNIEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2DE41C0", Offset = "0x2DE31C0", VA = "0x182DE41C0")]
	public static OHNBBLGLCIB JNBNOGLKHPH<TNetworking>(TNetworking LGPIIFOCLPE, [Optional] TimeSpan? DKIMFCJBBCE, [Optional] HNIAGMCEBLA CICEHMGNIEM) where TNetworking : GDEGAOBMPOI, DMAPDFIAACO, KOMPOJLHJFL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5729790", Offset = "0x5728790", VA = "0x185729790")]
	public void BPKDLHEEJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x572ACB0", Offset = "0x5729CB0", VA = "0x18572ACB0")]
	private byte NIHIDDEEBKM()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x572ACC0", Offset = "0x5729CC0", VA = "0x18572ACC0")]
	private TimeSpan NLJNFDOCDMM(TimeSpan? DKIMFCJBBCE, int ADNPCCICGGI = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x24EC720", Offset = "0x24EB720", VA = "0x1824EC720")]
	public bool BHHPGFKPOPH<T>(T AOFLHIPMBCL, Func<T, byte[]> HAPPCNOAFNK, bool KAABOLMNIEM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5729270", Offset = "0x5728270", VA = "0x185729270")]
	public bool BHHPGFKPOPH(byte[] AOFLHIPMBCL, int HOBFLGOJAGD, bool KAABOLMNIEM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69AF60", Offset = "0x699F60", VA = "0x18069AF60")]
	private static string BIHHMDDFIFE(string LPDLECBMBMG, string IJIJEAAHDCH = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5729BA0", Offset = "0x5728BA0", VA = "0x185729BA0")]
	[AsyncStateMachine(typeof(CGLEMJLJAEA))]
	public Task<IHOKGNKGKNH> CNPOOCAMMBG(CancellationToken JNDOKGNDNMO, [Optional] CHFLJCNHJAL AJKJLNKBCNE, [Optional] CHFLJCNHJAL JNFJIEJBFEL, [Optional] TimeSpan? DKIMFCJBBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5729D00", Offset = "0x5728D00", VA = "0x185729D00")]
	[AsyncStateMachine(typeof(FIHNKLAFDOB))]
	public Task<Guid> CPILKOMHODD(Guid BIMGELOENIJ, CancellationToken JNDOKGNDNMO, [Optional] CHFLJCNHJAL AJKJLNKBCNE, [Optional] CHFLJCNHJAL JNFJIEJBFEL, [Optional] TimeSpan? HPLFELDFDJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2289630", Offset = "0x2288630", VA = "0x182289630")]
	[AsyncStateMachine(typeof(PMNJPGEPPDI))]
	public Task<ELKFHENBDHA<T>> NPLICCBFDOG<T>(T AOFLHIPMBCL, Func<T, byte[]> HAPPCNOAFNK, Func<byte[], T> JIIHEOMANDG, CancellationToken JNDOKGNDNMO, [Optional] CHFLJCNHJAL AJKJLNKBCNE, [Optional] CHFLJCNHJAL JNFJIEJBFEL, [Optional] TimeSpan? HPLFELDFDJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x572B6E0", Offset = "0x572A6E0", VA = "0x18572B6E0")]
	[AsyncStateMachine(typeof(OBGCIOHCKBC))]
	public Task<IHOKGNKGKNH> NPLICCBFDOG(byte[] AOFLHIPMBCL, CancellationToken JNDOKGNDNMO, [Optional] CHFLJCNHJAL AJKJLNKBCNE, [Optional] CHFLJCNHJAL JNFJIEJBFEL, [Optional] TimeSpan? HPLFELDFDJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x572A3C0", Offset = "0x57293C0", VA = "0x18572A3C0")]
	[AsyncStateMachine(typeof(MBPMKNAAIBC))]
	private Task<IHOKGNKGKNH> IGAONJIAPOI(byte[] AOFLHIPMBCL, CancellationToken JNDOKGNDNMO, CHFLJCNHJAL AJKJLNKBCNE, CHFLJCNHJAL JNFJIEJBFEL, TimeSpan? DKIMFCJBBCE, Stopwatch ODNGGLNLKEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x572A540", Offset = "0x5729540", VA = "0x18572A540")]
	[AsyncStateMachine(typeof(NOCIDIOGAON))]
	private Task<IHOKGNKGKNH> JGFHFOIGEHH(byte[] AOFLHIPMBCL, CancellationToken JNDOKGNDNMO, [Optional] CHFLJCNHJAL AJKJLNKBCNE, [Optional] CHFLJCNHJAL JNFJIEJBFEL, [Optional] TimeSpan? HPLFELDFDJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x572B850", Offset = "0x572A850", VA = "0x18572B850")]
	[AsyncStateMachine(typeof(DFDODLMKGCK))]
	public Task OAJLIOLLGPF(CancellationToken GADEANLIDCE, Func<CancellationToken, Task> FMJJMMKFEPK, [Optional] CHFLJCNHJAL AJKJLNKBCNE, [Optional] CHFLJCNHJAL JNFJIEJBFEL, int FGKMPHGDGNP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x22897F0", Offset = "0x22887F0", VA = "0x1822897F0")]
	[AsyncStateMachine(typeof(AHICOEADIAG))]
	public Task<T> OAJLIOLLGPF<T>(CancellationToken GADEANLIDCE, Func<CancellationToken, Task<T>> FMJJMMKFEPK, [Optional] CHFLJCNHJAL AJKJLNKBCNE, [Optional] CHFLJCNHJAL JNFJIEJBFEL, int FGKMPHGDGNP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2288FC0", Offset = "0x2287FC0", VA = "0x182288FC0")]
	[AsyncStateMachine(typeof(MHGDFDIEEEE))]
	private Task<(bool, T)> IJDJNCJPBOI<T>(Guid AJGFNANMPNB, CancellationToken GADEANLIDCE, Func<CancellationToken, Task<T>> FMJJMMKFEPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x572A7E0", Offset = "0x57297E0", VA = "0x18572A7E0")]
	[IteratorStateMachine(typeof(JPAKDEICGKI))]
	internal static IEnumerable<(NDNJMHHNEAG, Guid)> MCIAANNPHDF(NDNJMHHNEAG GAKIODAENCI, Guid[] DNECLFKEHMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x572BDF0", Offset = "0x572ADF0", VA = "0x18572BDF0")]
	public void PEPAMCANIBD(byte FELCGHNENKD, int OMJDBKGFLEH, object ODMIIMBGOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x572A160", Offset = "0x5729160", VA = "0x18572A160")]
	public Guid GOBNCKJKCMI(Guid NLNHPNMLFEF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x572BD40", Offset = "0x572AD40", VA = "0x18572BD40")]
	internal static int PDANEILCLDE(NDNJMHHNEAG IHIKLCBNCMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x572A860", Offset = "0x5729860", VA = "0x18572A860")]
	public bool NGEJNBOJKMD(NDNJMHHNEAG IHIKLCBNCMF, Guid AJGFNANMPNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5729870", Offset = "0x5728870", VA = "0x185729870")]
	public void CEKLACKKOPN(NDNJMHHNEAG IHIKLCBNCMF, Guid AJGFNANMPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x572A3B0", Offset = "0x57293B0", VA = "0x18572A3B0")]
	private void HGIPEMOPLLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x572C540", Offset = "0x572B540", VA = "0x18572C540")]
	internal (NDNJMHHNEAG, Guid[]) PJHFCELJLEO(bool CAKOKPIFLOL = false)
	{
		return default((NDNJMHHNEAG, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x572B9B0", Offset = "0x572A9B0", VA = "0x18572B9B0")]
	private HashSet<Guid> OJKPKDCKKNJ(NDNJMHHNEAG IHIKLCBNCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5729FE0", Offset = "0x5728FE0", VA = "0x185729FE0")]
	private void GHKDBPBGAJK(NDNJMHHNEAG IHIKLCBNCMF, Guid LGBAJKGIPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x572BAF0", Offset = "0x572AAF0", VA = "0x18572BAF0")]
	private void PANGMNBKODD(NDNJMHHNEAG IHIKLCBNCMF, Guid LGBAJKGIPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5729F50", Offset = "0x5728F50", VA = "0x185729F50")]
	public static Func<Guid, bool> FIGOBBIBCMJ(Guid LGBAJKGIPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x572A6B0", Offset = "0x57296B0", VA = "0x18572A6B0")]
	public static Func<Guid, bool> JPGBJJAJELH(Guid LGBAJKGIPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5729E60", Offset = "0x5728E60", VA = "0x185729E60")]
	public void FAFDKJEBPGK(NDNJMHHNEAG IHIKLCBNCMF, Guid GMPPIODFDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x572AEA0", Offset = "0x5729EA0", VA = "0x18572AEA0")]
	public void NMOAEKDEOIL(NDNJMHHNEAG IHIKLCBNCMF, Func<Guid, bool> KKPFLNIFKAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class HGOPFMNEGMP : CCJEDLIPDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private List<(BFEBPFNDEKA.BGNBHNKLJAC itemType, long totalStopwatchTicks)> MODHKBCJOBH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<(BFEBPFNDEKA.BGNBHNKLJAC itemType, long totalStopwatchTicks)> JOANCJIFPFB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x638140", Offset = "0x637140", VA = "0x180638140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5724EA0", Offset = "0x5723EA0", VA = "0x185724EA0")]
	public HGOPFMNEGMP(TimeSpan HPLFELDFDJB, List<(BFEBPFNDEKA.BGNBHNKLJAC itemType, long totalStopwatchTicks)> MODHKBCJOBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MBLKDEEILCK : OLKNGAGOLDF
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct KNEDHEHBOIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly Guid LOEDFGNOGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly int IKCGMBCPEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly int MLEFJCCBCOA;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5726580", Offset = "0x5725580", VA = "0x185726580")]
		public KNEDHEHBOIE(Guid ALOEKDFLODC, int FEMIELMFINJ, int HLDLJGBMBAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x57264B0", Offset = "0x57254B0", VA = "0x1857264B0")]
		public static byte[] NJADPKHDAEC(KNEDHEHBOIE LPDLECBMBMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x57262D0", Offset = "0x57252D0", VA = "0x1857262D0")]
		public static KNEDHEHBOIE HIDKAFCIGIB(byte[] FCLFFFPNPCK)
		{
			return default(KNEDHEHBOIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5726380", Offset = "0x5725380", VA = "0x185726380")]
		private static byte[] JGOOMGDCHEK(int BJNKEHJJEBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5726400", Offset = "0x5725400", VA = "0x185726400")]
		private static int JKAFOMDCIEH(byte[] AKMLGIOGGAF, int IIHEDPBOLFE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Guid ALOEKDFLODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly OHNBBLGLCIB BAOFBJHOMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private bool CMDDAEFIIBG;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5727340", Offset = "0x5726340", VA = "0x185727340")]
	public MBLKDEEILCK(Guid ALOEKDFLODC, OHNBBLGLCIB BAOFBJHOMGK, KOMPOJLHJFL LGPIIFOCLPE, CancellationToken GADEANLIDCE, [Optional] JLDLJGIHPGC FOKANKHMOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x57271C0", Offset = "0x57261C0", VA = "0x1857271C0", Slot = "5")]
	protected override void HONONDNHJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5727030", Offset = "0x5726030", VA = "0x185727030", Slot = "6")]
	protected override void FPEBKOKCFEJ(int HAMEIFEMNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5726E50", Offset = "0x5725E50", VA = "0x185726E50")]
	private void BBEAKBIGKEB(IHOKGNKGKNH KKFEOKKMDPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct IHOKGNKGKNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly byte DLGNDAFCONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly byte CEMDAACHIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly bool OIFPMHODDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly OHNBBLGLCIB.NDNJMHHNEAG ABHCBLEKNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly Guid[] LECCIFDKPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly byte[] IEAOCELNECM;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5725530", Offset = "0x5724530", VA = "0x185725530")]
	public IHOKGNKGKNH(OHNBBLGLCIB.NDNJMHHNEAG IHIKLCBNCMF, [NotNull] Guid[] AICDGLOJJFB, byte[] PHHFPJMDJAF, bool KAABOLMNIEM, byte PGEKBFCGPJH, byte PNLKKFOGJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x57250C0", Offset = "0x57240C0", VA = "0x1857250C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5724F20", Offset = "0x5723F20", VA = "0x185724F20")]
	private static void APMDELEMFDP(byte[] PHHFPJMDJAF, StringBuilder ILMCDOLEKBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class IGKKAHEDLOC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2518E50", Offset = "0x2517E50", VA = "0x182518E50", Slot = "4")]
	public void OKOLOFACDKO(T LPDLECBMBMG, IDictionary<object, object> JEJGBICCBLN, bool MFEHAOKJNMG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void DNKFHLIGJND(T LPDLECBMBMG, IDictionary<object, object> JEJGBICCBLN);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T HIDKAFCIGIB(IDictionary<object, object> JEJGBICCBLN);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2518FB0", Offset = "0x2517FB0", VA = "0x182518FB0", Slot = "7")]
	public bool OLLDADEBHBO(IDictionary<object, object> JEJGBICCBLN, out T HBLMLHNLEKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
	protected IGKKAHEDLOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class OLKNGAGOLDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate bool JLDLJGIHPGC(int JNHLPNGDPGP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool NJLKFAFJNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	protected readonly KOMPOJLHJFL NBDKCEOHLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationToken GADEANLIDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationToken JNDOJGIKFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly JLDLJGIHPGC FOKANKHMOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly CancellationTokenSource JBJJJAGOALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly CancellationTokenSource BGGOBGMMGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly int PJJHNBOIJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool IAHDNEJOHIJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken HDCMFFCHELM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x572D070", Offset = "0x572C070", VA = "0x18572D070")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LDIBMDEJKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x572D020", Offset = "0x572C020", VA = "0x18572D020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x572D120", Offset = "0x572C120", VA = "0x18572D120")]
	public OLKNGAGOLDF(KOMPOJLHJFL LGPIIFOCLPE, CancellationToken GADEANLIDCE, [Optional] JLDLJGIHPGC FOKANKHMOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x572CF30", Offset = "0x572BF30", VA = "0x18572CF30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x572CF70", Offset = "0x572BF70", VA = "0x18572CF70", Slot = "5")]
	protected virtual void HONONDNHJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x572D090", Offset = "0x572C090", VA = "0x18572D090")]
	private void POEDIHNPACH(CFKJNANNAIG BDKCJKCPHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x572CED0", Offset = "0x572BED0", VA = "0x18572CED0")]
	protected void DCAODDNBLFE(int HAMEIFEMNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x572CF50", Offset = "0x572BF50", VA = "0x18572CF50", Slot = "6")]
	protected virtual void FPEBKOKCFEJ(int HAMEIFEMNOC)
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

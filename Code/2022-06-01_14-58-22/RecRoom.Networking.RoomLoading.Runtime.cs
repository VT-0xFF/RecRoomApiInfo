using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class KEPEMBNHMDG : global::OACMAPKGOGI<FFFCPGMKGFD>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class AFDBIDOJMHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public AFDBIDOJMHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E31EC0", Offset = "0x4E308C0", VA = "0x184E31EC0")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] OIBLFDMELCK;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly KEPEMBNHMDG JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4E35340", Offset = "0x4E33D40", VA = "0x184E35340", Slot = "5")]
	protected override void KNJJECHGHEG(FFFCPGMKGFD OLLHPIFFHKE, IDictionary<object, object> CIBAGEDPOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E34C50", Offset = "0x4E33650", VA = "0x184E34C50", Slot = "6")]
	public override FFFCPGMKGFD FIPMLAIPHOG(IDictionary<object, object> CIBAGEDPOOH)
	{
		return default(FFFCPGMKGFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E35860", Offset = "0x4E34260", VA = "0x184E35860")]
	public KEPEMBNHMDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LCPNDJJAJIP
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string DLAOFGCNNCN([NotNull] byte[] KJNOHPBJPCK);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum JLLGIPDAIFG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Operation = 1,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		RoomLoad = 2,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		MasterBlock = 4
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct LEMJFAIBAIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly JLLGIPDAIFG MMOBNNKJIIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly Guid GPDMKOGMLNM;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4279750", Offset = "0x4278150", VA = "0x184279750")]
		public LEMJFAIBAIB(JLLGIPDAIFG INHMKIMBPNA, Guid FEMFELHFPGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4E39970", Offset = "0x4E38370", VA = "0x184E39970")]
		public bool IAMAEONCFGH(LEMJFAIBAIB KKPJJILPNAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4E39880", Offset = "0x4E38280", VA = "0x184E39880", Slot = "0")]
		public override bool Equals(object FBOGCDJOCBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4E39940", Offset = "0x4E38340", VA = "0x184E39940", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class CBKOFGOOJHE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public delegate bool LDHDDIKMCAJ(AOLOIKMEGKC LIIIKAIOJCL);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool KIHCNAMPEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly CCFEEODIKGE PLCGLJPJKBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly CancellationToken ADDHBCOAOKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly CancellationToken OKFGALKCFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly LDHDDIKMCAJ EEAHLCNGBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly CancellationTokenSource JLOONGIBALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly CancellationTokenSource IHDONEDMKME;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public CancellationToken HPKLNBNEFBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4E32A80", Offset = "0x4E31480", VA = "0x184E32A80")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool FHAMBDBCCIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x4E32A30", Offset = "0x4E31430", VA = "0x184E32A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4E32AE0", Offset = "0x4E314E0", VA = "0x184E32AE0")]
		public CBKOFGOOJHE(CCFEEODIKGE PLCGLJPJKBH, CancellationToken ADDHBCOAOKN, [Optional] LDHDDIKMCAJ EEAHLCNGBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4E32AA0", Offset = "0x4E314A0", VA = "0x184E32AA0")]
		private void MCBCCBLNANM(AOLOIKMEGKC FABCJLMMGEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4E32970", Offset = "0x4E31370", VA = "0x184E32970", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct FOIDBCHNNCK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly JLLGIPDAIFG MMOBNNKJIIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Guid[] CDCGBGAJHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public readonly T DAEPDEOBJND;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3B61420", Offset = "0x3B5FE20", VA = "0x183B61420")]
		public static FOIDBCHNNCK<T> ONOMAJADJMB(FFFCPGMKGFD CPMIPJOAFKP, Func<byte[], T> NHMPBHFGEKB)
		{
			return default(FOIDBCHNNCK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3B61690", Offset = "0x3B60090", VA = "0x183B61690")]
		public FOIDBCHNNCK(JLLGIPDAIFG INHMKIMBPNA, Guid[] MABGLPPHJGA, T KJNOHPBJPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3B61550", Offset = "0x3B5FF50", VA = "0x183B61550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class DPMNIILKPLL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class EPPBDDGKKDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public TaskCompletionSource<FFFCPGMKGFD> newMessageTaskCompletionSource;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
			public EPPBDDGKKDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4E33500", Offset = "0x4E31F00", VA = "0x184E33500")]
			internal void <AwaitNextMessage>b__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct BOGJBKFKPAD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AsyncTaskMethodBuilder<FFFCPGMKGFD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public DPMNIILKPLL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private EPPBDDGKKDF <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<FFFCPGMKGFD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4E322E0", Offset = "0x4E30CE0", VA = "0x184E322E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4E32920", Offset = "0x4E31320", VA = "0x184E32920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class MFOHFIGCHHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public JLLGIPDAIFG sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
			public MFOHFIGCHHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4E39AA0", Offset = "0x4E384A0", VA = "0x184E39AA0")]
			internal bool <ClearSlice>b__0(FFFCPGMKGFD bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly string EEHOLHJBAMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly List<FFFCPGMKGFD> LPGJJPJKKCD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool JKBNPFOBPJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4E33390", Offset = "0x4E31D90", VA = "0x184E33390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		private event Action<FFFCPGMKGFD> PHOIOGIKAGF
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4E33240", Offset = "0x4E31C40", VA = "0x184E33240")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4E333D0", Offset = "0x4E31DD0", VA = "0x184E333D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4E33470", Offset = "0x4E31E70", VA = "0x184E33470")]
		public DPMNIILKPLL(string EEHOLHJBAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4E32FC0", Offset = "0x4E319C0", VA = "0x184E32FC0")]
		[AsyncStateMachine(typeof(BOGJBKFKPAD))]
		public Task<FFFCPGMKGFD> CDGLFPJBIMH(CancellationToken PKFOPLIPJOL, TimeSpan BMNHOPLJPGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4E332E0", Offset = "0x4E31CE0", VA = "0x184E332E0")]
		public void HDLOCNLCIIL(FFFCPGMKGFD OLLHPIFFHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4E33100", Offset = "0x4E31B00", VA = "0x184E33100", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4E33150", Offset = "0x4E31B50", VA = "0x184E33150")]
		public void ENNAIAPOEJC(JLLGIPDAIFG INHMKIMBPNA, Guid AKGOJHKMAIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class HLALAGNLAIO : IEnumerable<(JLLGIPDAIFG, Guid)>, IEnumerable, IEnumerator<(JLLGIPDAIFG, Guid)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private (JLLGIPDAIFG, Guid) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private JLLGIPDAIFG sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public JLLGIPDAIFG <>3__sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Guid[] sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid[] <>3__sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private JLLGIPDAIFG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private (JLLGIPDAIFG, Guid) System.Collections.Generic.IEnumerator<(RecRoom.Networking.Events.BufferedEventHelper.SliceType,System.Guid)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x178FA60", Offset = "0x178E460", VA = "0x18178FA60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((JLLGIPDAIFG, Guid));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4E344B0", Offset = "0x4E32EB0", VA = "0x184E344B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xB91C50", Offset = "0xB90650", VA = "0x180B91C50")]
		[DebuggerHidden]
		public HLALAGNLAIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4E34190", Offset = "0x4E32B90", VA = "0x184E34190", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4E34460", Offset = "0x4E32E60", VA = "0x184E34460", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4E343B0", Offset = "0x4E32DB0", VA = "0x184E343B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(JLLGIPDAIFG, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceType,System.Guid)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4E343B0", Offset = "0x4E32DB0", VA = "0x184E343B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FDAHLCOOBGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<FFFCPGMKGFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public KKFCNNLFPAP unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public LCPNDJJAJIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public KKFCNNLFPAP pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<FFFCPGMKGFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4E335C0", Offset = "0x4E31FC0", VA = "0x184E335C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4E33DE0", Offset = "0x4E327E0", VA = "0x184E33DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct CHDJDHEKNHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LCPNDJJAJIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public KKFCNNLFPAP unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public KKFCNNLFPAP pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<FOIDBCHNNCK<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4E32C50", Offset = "0x4E31650", VA = "0x184E32C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4E32F70", Offset = "0x4E31970", VA = "0x184E32F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct OECKJCMIADH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<FFFCPGMKGFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public LCPNDJJAJIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public KKFCNNLFPAP unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public KKFCNNLFPAP pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private Stopwatch <sw>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int <frameStart>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private TaskAwaiter<FFFCPGMKGFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4E3A650", Offset = "0x4E39050", VA = "0x184E3A650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4E3ADA0", Offset = "0x4E397A0", VA = "0x184E3ADA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct OCLCMFLHKLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder<FFFCPGMKGFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public LCPNDJJAJIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public KKFCNNLFPAP unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public KKFCNNLFPAP pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private CBKOFGOOJHE <masterSwitchScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter<FFFCPGMKGFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4E39DE0", Offset = "0x4E387E0", VA = "0x184E39DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4E3A600", Offset = "0x4E39000", VA = "0x184E3A600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct BACCOHIOHAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder<FFFCPGMKGFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public LCPNDJJAJIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KKFCNNLFPAP unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public KKFCNNLFPAP pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<FFFCPGMKGFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4E31F60", Offset = "0x4E30960", VA = "0x184E31F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4E32290", Offset = "0x4E30C90", VA = "0x184E32290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class PLKFOOHIBIF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private struct <<MasterLockedBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public PLKFOOHIBIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4E3AF10", Offset = "0x4E39910", VA = "0x184E3AF10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4E3B070", Offset = "0x4E39A70", VA = "0x184E3B070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public PLKFOOHIBIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4E3ADF0", Offset = "0x4E397F0", VA = "0x184E3ADF0")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct MMBFIDHPKJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LCPNDJJAJIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public KKFCNNLFPAP unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public KKFCNNLFPAP pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4E39C00", Offset = "0x4E38600", VA = "0x184E39C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class MDGLCKBDEHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public MDGLCKBDEHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4E399D0", Offset = "0x4E383D0", VA = "0x184E399D0")]
		internal object <OnEvent>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4E39A10", Offset = "0x4E38410", VA = "0x184E39A10")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4E39A60", Offset = "0x4E38460", VA = "0x184E39A60")]
		internal object <OnEvent>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GKLPLFKHIGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public JLLGIPDAIFG sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public GKLPLFKHIGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4E34080", Offset = "0x4E32A80", VA = "0x184E34080")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class JNIKAAHNGNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public JLLGIPDAIFG sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public JNIKAAHNGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4E34BD0", Offset = "0x4E335D0", VA = "0x184E34BD0")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class ICMKBHPFHCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public ICMKBHPFHCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4E34560", Offset = "0x4E32F60", VA = "0x184E34560")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HLGDACMCFLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public HLGDACMCFLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4E34500", Offset = "0x4E32F00", VA = "0x184E34500")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class IIFCBBFOLHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public IIFCBBFOLHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4E345C0", Offset = "0x4E32FC0", VA = "0x184E345C0")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class HHJPEEMECAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public HHJPEEMECAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4E34100", Offset = "0x4E32B00", VA = "0x184E34100")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class FMPPGAIAHLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Func<Guid, bool> matchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Func<Guid, bool> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Func<Guid, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public FMPPGAIAHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4E34020", Offset = "0x4E32A20", VA = "0x184E34020")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4E33FC0", Offset = "0x4E329C0", VA = "0x184E33FC0")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class IMFFNKICHKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public ExitGames.Client.Photon.Hashtable content;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public IMFFNKICHKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4E34650", Offset = "0x4E33050", VA = "0x184E34650")]
		internal bool <ClearSliceIds>b__3(LEMJFAIBAIB stackSlice)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4E34750", Offset = "0x4E33150", VA = "0x184E34750")]
		internal object <ClearSliceIds>b__5()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4E34990", Offset = "0x4E33390", VA = "0x184E34990")]
		internal object <ClearSliceIds>b__6()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4E346F0", Offset = "0x4E330F0", VA = "0x184E346F0")]
		internal object <ClearSliceIds>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly DLAOFGCNNCN JMAPKFJJKPG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable GFHPBGABJFE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly FCJNKFJKFGK OICMCFOJPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly DPMNIILKPLL KFJCCAEINGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FPFJDCLOBAL HFPCEICIHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly MDAIOIDMGBH CBMOPJFPHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CCFEEODIKGE DONNFDAIJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DLAOFGCNNCN OCLJKPJOAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool NPBJPMMAPDK;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal static readonly JLLGIPDAIFG[] FIPFGLONLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HashSet<Guid>[] FMDBHAMHNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<LEMJFAIBAIB> ELKABOOCDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private (JLLGIPDAIFG combinedSliceType, Guid[] sliceTypeIds)? APHPAIOEDKB;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4E39510", Offset = "0x4E37F10", VA = "0x184E39510")]
	public LCPNDJJAJIP(FPFJDCLOBAL HFPCEICIHLO, MDAIOIDMGBH CBMOPJFPHJN, CCFEEODIKGE DONNFDAIJIE, [Optional] DLAOFGCNNCN LJMCALLPJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x29A6FE0", Offset = "0x29A59E0", VA = "0x1829A6FE0")]
	public static LCPNDJJAJIP JMJALFFHJIF<TNetworking>(TNetworking PLCGLJPJKBH, [Optional] DLAOFGCNNCN LJMCALLPJEO) where TNetworking : FPFJDCLOBAL, MDAIOIDMGBH, CCFEEODIKGE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4E38E30", Offset = "0x4E37830", VA = "0x184E38E30")]
	public void OHNGCEIGACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C8C0", Offset = "0x2D0B2C0", VA = "0x182D0C8C0")]
	public bool BEMOHKIAMNO<T>(T BKDIDADPELO, Func<T, byte[]> NPPKEPGDMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4E360F0", Offset = "0x4E34AF0", VA = "0x184E360F0")]
	public bool BEMOHKIAMNO(byte[] BKDIDADPELO, int MPFDJLJKCDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4E38CE0", Offset = "0x4E376E0", VA = "0x184E38CE0")]
	private static string NGEMKJFKLPM(JLLGIPDAIFG INHMKIMBPNA, Guid[] NIOLBNHHLAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E38160", Offset = "0x4E36B60", VA = "0x184E38160")]
	[IteratorStateMachine(typeof(HLALAGNLAIO))]
	private static IEnumerable<(JLLGIPDAIFG, Guid)> LGOACNKJHJE(JLLGIPDAIFG FCDOBGEPEEA, Guid[] NIOLBNHHLAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4E37D80", Offset = "0x4E36780", VA = "0x184E37D80")]
	[AsyncStateMachine(typeof(FDAHLCOOBGP))]
	public Task<FFFCPGMKGFD> IMPPAFIGECA(CancellationToken PKFOPLIPJOL, [Optional] KKFCNNLFPAP JPOHLLFKOCI, [Optional] KKFCNNLFPAP BHJLFHCMGLP, [Optional] TimeSpan? BMNHOPLJPGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4E39240", Offset = "0x4E37C40", VA = "0x184E39240")]
	[AsyncStateMachine(typeof(CHDJDHEKNHH))]
	public Task<Guid> OPAHOBOGFGI(Guid ECGOMHOEPFF, CancellationToken PKFOPLIPJOL, [Optional] KKFCNNLFPAP JPOHLLFKOCI, [Optional] KKFCNNLFPAP BHJLFHCMGLP, [Optional] TimeSpan? BMNHOPLJPGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x30817A0", Offset = "0x30801A0", VA = "0x1830817A0")]
	[AsyncStateMachine(typeof(FPFCNCFCJMD))]
	public Task<FOIDBCHNNCK<T>> KJNJJFJMOFK<T>(T BKDIDADPELO, Func<T, byte[]> NPPKEPGDMKM, Func<byte[], T> NHMPBHFGEKB, CancellationToken PKFOPLIPJOL, [Optional] KKFCNNLFPAP JPOHLLFKOCI, [Optional] KKFCNNLFPAP BHJLFHCMGLP, [Optional] TimeSpan? BMNHOPLJPGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4E37F70", Offset = "0x4E36970", VA = "0x184E37F70")]
	[AsyncStateMachine(typeof(OECKJCMIADH))]
	public Task<FFFCPGMKGFD> KJNJJFJMOFK(byte[] BKDIDADPELO, CancellationToken PKFOPLIPJOL, [Optional] KKFCNNLFPAP JPOHLLFKOCI, [Optional] KKFCNNLFPAP BHJLFHCMGLP, [Optional] TimeSpan? BMNHOPLJPGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4E373B0", Offset = "0x4E35DB0", VA = "0x184E373B0")]
	[AsyncStateMachine(typeof(OCLCMFLHKLO))]
	private Task<FFFCPGMKGFD> FEJDHOEBIBH(byte[] BKDIDADPELO, CancellationToken PKFOPLIPJOL, KKFCNNLFPAP JPOHLLFKOCI, KKFCNNLFPAP BHJLFHCMGLP, TimeSpan? BMNHOPLJPGO, Stopwatch MLKLKIBHHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4E36D00", Offset = "0x4E35700", VA = "0x184E36D00")]
	[AsyncStateMachine(typeof(BACCOHIOHAK))]
	private Task<FFFCPGMKGFD> CLPPNBADBIA(byte[] BKDIDADPELO, CancellationToken PKFOPLIPJOL, [Optional] KKFCNNLFPAP JPOHLLFKOCI, [Optional] KKFCNNLFPAP BHJLFHCMGLP, [Optional] TimeSpan? BMNHOPLJPGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4E35C90", Offset = "0x4E34690", VA = "0x184E35C90")]
	[AsyncStateMachine(typeof(MMBFIDHPKJG))]
	public Task ANPMEOMNKNM(CancellationToken ADDHBCOAOKN, Func<CancellationToken, Task> HJLODIICIGH, [Optional] KKFCNNLFPAP JPOHLLFKOCI, [Optional] KKFCNNLFPAP BHJLFHCMGLP, int FILNCCKMPFC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3080C50", Offset = "0x307F650", VA = "0x183080C50")]
	[AsyncStateMachine(typeof(KDJOACGCFIE))]
	public Task<T> ANPMEOMNKNM<T>(CancellationToken ADDHBCOAOKN, Func<CancellationToken, Task<T>> HJLODIICIGH, [Optional] KKFCNNLFPAP JPOHLLFKOCI, [Optional] KKFCNNLFPAP BHJLFHCMGLP, int FILNCCKMPFC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3081130", Offset = "0x307FB30", VA = "0x183081130")]
	[AsyncStateMachine(typeof(OLBFEFALIEA))]
	private Task<(bool, T)> DELDIDIPKDJ<T>(Guid FEMFELHFPGL, CancellationToken ADDHBCOAOKN, Func<CancellationToken, Task<T>> HJLODIICIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4E365D0", Offset = "0x4E34FD0", VA = "0x184E365D0")]
	public void CLMBLDKEMKK(byte IKCPPMJMAML, int GIECOBENCKK, object DIHNIJDPILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4E35DF0", Offset = "0x4E347F0", VA = "0x184E35DF0")]
	public Guid APFLDJEKPHC(Guid DHEBAMALOLN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4E36040", Offset = "0x4E34A40", VA = "0x184E36040")]
	internal static int BCAELOMMGFP(JLLGIPDAIFG INHMKIMBPNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4E36E70", Offset = "0x4E35870", VA = "0x184E36E70")]
	public bool EJNHGKPINMM(JLLGIPDAIFG INHMKIMBPNA, Guid FEMFELHFPGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4E38F10", Offset = "0x4E37910", VA = "0x184E38F10")]
	public void ONOFNDLMHII(JLLGIPDAIFG INHMKIMBPNA, Guid FEMFELHFPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4E381E0", Offset = "0x4E36BE0", VA = "0x184E381E0")]
	private void LKDNJGJCENO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4E358A0", Offset = "0x4E342A0", VA = "0x184E358A0")]
	internal (JLLGIPDAIFG, Guid[]) ANOLMINMIGC(bool AIPKHNBDEIO = false)
	{
		return default((JLLGIPDAIFG, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4E37960", Offset = "0x4E36360", VA = "0x184E37960")]
	private HashSet<Guid> GNCPABMCOKH(JLLGIPDAIFG INHMKIMBPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4E377E0", Offset = "0x4E361E0", VA = "0x184E377E0")]
	private void GMDDCKHANDM(JLLGIPDAIFG INHMKIMBPNA, Guid AKGOJHKMAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4E37B30", Offset = "0x4E36530", VA = "0x184E37B30")]
	private void IDMEKOFDILL(JLLGIPDAIFG INHMKIMBPNA, Guid AKGOJHKMAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4E37EE0", Offset = "0x4E368E0", VA = "0x184E37EE0")]
	public static Func<Guid, bool> JOPKFIGGKIN(Guid AKGOJHKMAIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4E37AA0", Offset = "0x4E364A0", VA = "0x184E37AA0")]
	public static Func<Guid, bool> HIMBHFIHNEN(Guid AKGOJHKMAIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4E372C0", Offset = "0x4E35CC0", VA = "0x184E372C0")]
	public void ENNAIAPOEJC(JLLGIPDAIFG INHMKIMBPNA, Guid CGPELKGLDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4E381F0", Offset = "0x4E36BF0", VA = "0x184E381F0")]
	public void MAPFIILFCNF(JLLGIPDAIFG INHMKIMBPNA, Func<Guid, bool> GMDDEOPHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4E364C0", Offset = "0x4E34EC0", VA = "0x184E364C0")]
	private string CDMLPJLJKGB(byte[] KJNOHPBJPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4E37530", Offset = "0x4E35F30", VA = "0x184E37530")]
	[CompilerGenerated]
	private object FPDKEHKDBHN(in (JLLGIPDAIFG st, Guid[] ids, byte[] mts) MDAKEHNEFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4E38A30", Offset = "0x4E37430", VA = "0x184E38A30")]
	[CompilerGenerated]
	private object MMOLFNIOPAP(in (JLLGIPDAIFG rst, Guid[] ssids, byte[] pl) MDAKEHNEFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4E380E0", Offset = "0x4E36AE0", VA = "0x184E380E0")]
	[CompilerGenerated]
	private bool KLCCMHCLPLJ(AOLOIKMEGKC FABCJLMMGEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct FFFCPGMKGFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly LCPNDJJAJIP.JLLGIPDAIFG MMOBNNKJIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Guid[] CDCGBGAJHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly byte[] DAEPDEOBJND;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3B616D0", Offset = "0x3B600D0", VA = "0x183B616D0")]
	public FFFCPGMKGFD(LCPNDJJAJIP.JLLGIPDAIFG INHMKIMBPNA, [NotNull] Guid[] MABGLPPHJGA, byte[] KJNOHPBJPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4E33E30", Offset = "0x4E32830", VA = "0x184E33E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class OACMAPKGOGI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x28EA710", Offset = "0x28E9110", VA = "0x1828EA710", Slot = "4")]
	public void EOHOGNBDEEG(T OLLHPIFFHKE, IDictionary<object, object> CIBAGEDPOOH, bool FFOFGNMJLPC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void KNJJECHGHEG(T OLLHPIFFHKE, IDictionary<object, object> CIBAGEDPOOH);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T FIPMLAIPHOG(IDictionary<object, object> CIBAGEDPOOH);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x28EA910", Offset = "0x28E9310", VA = "0x1828EA910", Slot = "7")]
	public bool FOCEBLMOEBO(IDictionary<object, object> CIBAGEDPOOH, out T BOCONCGJLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
	protected OACMAPKGOGI()
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

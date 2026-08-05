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
internal class EMFHMAEBLDG : global::LMPKOJFHKBP<JBNKHPMBOHH>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class ABCEJGEDCMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public ABCEJGEDCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x51033D0", Offset = "0x51023D0", VA = "0x1851033D0")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] KBGPBEOLNEJ;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly EMFHMAEBLDG LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x51085D0", Offset = "0x51075D0", VA = "0x1851085D0", Slot = "5")]
	protected override void PHMFEBFNGMG(JBNKHPMBOHH EOGLFEOLNBK, IDictionary<object, object> GPELMIMHNGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5107DD0", Offset = "0x5106DD0", VA = "0x185107DD0", Slot = "6")]
	public override JBNKHPMBOHH EKIAPEHGMJJ(IDictionary<object, object> GPELMIMHNGI)
	{
		return default(JBNKHPMBOHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5108B40", Offset = "0x5107B40", VA = "0x185108B40")]
	public EMFHMAEBLDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DHMEJIBAPAG
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string GJOOODAOFJK([NotNull] byte[] KBOOFLMIFHM);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum GADKDGANEEE : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Operation = 1,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		RoomLoad = 2,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		MasterBlock = 4
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct OFMCGBJJLCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly GADKDGANEEE PLHHHDHHHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly Guid CIFGLLDBIPH;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4497AB0", Offset = "0x4496AB0", VA = "0x184497AB0")]
		public OFMCGBJJLCB(GADKDGANEEE FBIILNMCHDD, Guid ANEBPHEMKIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x510CDC0", Offset = "0x510BDC0", VA = "0x18510CDC0")]
		public bool LBIHKFOCCFJ(OFMCGBJJLCB INIEAOGGCLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x510CCD0", Offset = "0x510BCD0", VA = "0x18510CCD0", Slot = "0")]
		public override bool Equals(object OOJKHPLJJMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x510CD90", Offset = "0x510BD90", VA = "0x18510CD90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct HFJKKICEOLG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly bool BHOBCADKJND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly GADKDGANEEE PLHHHDHHHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly Guid[] NLIIAFIHKKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly T BJPKEDBOAHD;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3B25750", Offset = "0x3B24750", VA = "0x183B25750")]
		public static HFJKKICEOLG<T> KKDHNHOLAPM(JBNKHPMBOHH ANBBELMMMGG, Func<byte[], T> BHGHHDMMDBA)
		{
			return default(HFJKKICEOLG<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3B259E0", Offset = "0x3B249E0", VA = "0x183B259E0")]
		public HFJKKICEOLG(GADKDGANEEE FBIILNMCHDD, Guid[] HOPBGOAMNKN, T KBOOFLMIFHM, bool EOOALNJDKMO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3B258A0", Offset = "0x3B248A0", VA = "0x183B258A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class KPHNKGGBBHD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class OPGOPKJJBFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public TaskCompletionSource<JBNKHPMBOHH> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public KPHNKGGBBHD <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
			public OPGOPKJJBFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x510CEA0", Offset = "0x510BEA0", VA = "0x18510CEA0")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x510CEF0", Offset = "0x510BEF0", VA = "0x18510CEF0")]
			internal JJOMBECOFCL <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class FMDJFGGPCFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HGLEPJPPBJD.EKICCJBILEE itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
			public FMDJFGGPCFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5109440", Offset = "0x5108440", VA = "0x185109440")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct HGODPMKGMKG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AsyncTaskMethodBuilder<JBNKHPMBOHH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public KPHNKGGBBHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private OPGOPKJJBFF <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<JBNKHPMBOHH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x510A570", Offset = "0x5109570", VA = "0x18510A570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x510AC20", Offset = "0x5109C20", VA = "0x18510AC20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KLLLNOKMAEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public GADKDGANEEE sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
			public KLLLNOKMAEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x510B940", Offset = "0x510A940", VA = "0x18510B940")]
			internal bool <ClearSlice>b__0(JBNKHPMBOHH bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly HBMKFBHFMKC FHCHAGPLIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly string NDBDFJMEIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly List<JBNKHPMBOHH> IFDDBPALFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private List<(HGLEPJPPBJD.EKICCJBILEE itemType, long totalStopwatchTicks)> MHGFHKABCIF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OFDJBJLNJDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x510BBA0", Offset = "0x510ABA0", VA = "0x18510BBA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		private event Action<JBNKHPMBOHH> OAEPIKGPECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x510BBE0", Offset = "0x510ABE0", VA = "0x18510BBE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x510BB00", Offset = "0x510AB00", VA = "0x18510BB00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x510BF60", Offset = "0x510AF60", VA = "0x18510BF60")]
		public KPHNKGGBBHD(HBMKFBHFMKC FHCHAGPLIJN, string NDBDFJMEIPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x510BE20", Offset = "0x510AE20", VA = "0x18510BE20")]
		[AsyncStateMachine(typeof(HGODPMKGMKG))]
		public Task<JBNKHPMBOHH> OBOJBLCNKCE(CancellationToken DBKPHPKFAOL, TimeSpan KKNJDBDMIKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x510BD70", Offset = "0x510AD70", VA = "0x18510BD70")]
		public void NLLNDDFKCIH(JBNKHPMBOHH EOGLFEOLNBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x510BAB0", Offset = "0x510AAB0", VA = "0x18510BAB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x510BC80", Offset = "0x510AC80", VA = "0x18510BC80")]
		public void LMDOPAFOAND(GADKDGANEEE FBIILNMCHDD, Guid MDOMNGAAEFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class EGBIEEMKECE : IEnumerable<(GADKDGANEEE, Guid)>, IEnumerable, IEnumerator<(GADKDGANEEE, Guid)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private (GADKDGANEEE, Guid) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private GADKDGANEEE sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public GADKDGANEEE <>3__sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Guid[] sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid[] <>3__sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private GADKDGANEEE[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (GADKDGANEEE, Guid) System.Collections.Generic.IEnumerator<(RecRoom.Networking.Events.BufferedEventHelper.SliceType,System.Guid)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x29F7570", Offset = "0x29F6570", VA = "0x1829F7570", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((GADKDGANEEE, Guid));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5107D80", Offset = "0x5106D80", VA = "0x185107D80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9B54D0", Offset = "0x9B44D0", VA = "0x1809B54D0")]
		[DebuggerHidden]
		public EGBIEEMKECE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5107A60", Offset = "0x5106A60", VA = "0x185107A60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5107D30", Offset = "0x5106D30", VA = "0x185107D30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5107C80", Offset = "0x5106C80", VA = "0x185107C80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(GADKDGANEEE, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceType,System.Guid)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5107C80", Offset = "0x5106C80", VA = "0x185107C80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct OEAMCOCHCLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<JBNKHPMBOHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public ICIEEPGDOPO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public DHMEJIBAPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public ICIEEPGDOPO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<JBNKHPMBOHH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x510C4A0", Offset = "0x510B4A0", VA = "0x18510C4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x510CC80", Offset = "0x510BC80", VA = "0x18510CC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct HFFOCLFIFLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public DHMEJIBAPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public ICIEEPGDOPO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public ICIEEPGDOPO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<HFJKKICEOLG<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5109EF0", Offset = "0x5108EF0", VA = "0x185109EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x510A210", Offset = "0x5109210", VA = "0x18510A210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct GFEMPDDCGAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<JBNKHPMBOHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public DHMEJIBAPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public ICIEEPGDOPO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public ICIEEPGDOPO pauseAfterListeningToken;

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
		private TaskAwaiter<JBNKHPMBOHH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x51096D0", Offset = "0x51086D0", VA = "0x1851096D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5109E20", Offset = "0x5108E20", VA = "0x185109E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DAELPCDJBIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public DHMEJIBAPAG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public DAELPCDJBIE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct FHEHAGJCMHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<JBNKHPMBOHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public DHMEJIBAPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private DAELPCDJBIE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public ICIEEPGDOPO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public ICIEEPGDOPO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private INCHNNODFIF <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<JBNKHPMBOHH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5108B80", Offset = "0x5107B80", VA = "0x185108B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x51093F0", Offset = "0x51083F0", VA = "0x1851093F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LLLKLPAFCLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<JBNKHPMBOHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public DHMEJIBAPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public ICIEEPGDOPO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public ICIEEPGDOPO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<JBNKHPMBOHH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x510C030", Offset = "0x510B030", VA = "0x18510C030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x510C360", Offset = "0x510B360", VA = "0x18510C360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HFHDMOFFFBH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private struct <<MasterLockedBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public HFHDMOFFFBH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x510D270", Offset = "0x510C270", VA = "0x18510D270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x510D3D0", Offset = "0x510C3D0", VA = "0x18510D3D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public HFHDMOFFFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x510A260", Offset = "0x5109260", VA = "0x18510A260")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct GDPLLLJIFAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public DHMEJIBAPAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public ICIEEPGDOPO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public ICIEEPGDOPO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x51094F0", Offset = "0x51084F0", VA = "0x1851094F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7EDFE0", Offset = "0x7ECFE0", VA = "0x1807EDFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class JDHMMJADNDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public JDHMMJADNDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x510B770", Offset = "0x510A770", VA = "0x18510B770")]
		internal object <OnEvent>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x510B7B0", Offset = "0x510A7B0", VA = "0x18510B7B0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x510B800", Offset = "0x510A800", VA = "0x18510B800")]
		internal object <OnEvent>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class OOJDFLCKGNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public GADKDGANEEE sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public OOJDFLCKGNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x510CE20", Offset = "0x510BE20", VA = "0x18510CE20")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KHKENOOKELD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GADKDGANEEE sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public KHKENOOKELD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x510B8C0", Offset = "0x510A8C0", VA = "0x18510B8C0")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class NIFLNGDEJDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public NIFLNGDEJDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x510C440", Offset = "0x510B440", VA = "0x18510C440")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PIJLJEPKHGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public PIJLJEPKHGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x510D210", Offset = "0x510C210", VA = "0x18510D210")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class IADKIJFGFLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public IADKIJFGFLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x510AC70", Offset = "0x5109C70", VA = "0x18510AC70")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MOHGFCHNPMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public MOHGFCHNPMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x510C3B0", Offset = "0x510B3B0", VA = "0x18510C3B0")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class ECDBIECHMBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Func<Guid, bool> matchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Func<Guid, bool> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Func<Guid, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public ECDBIECHMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5107A00", Offset = "0x5106A00", VA = "0x185107A00")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x51079A0", Offset = "0x51069A0", VA = "0x1851079A0")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JAILPPEAJLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public ExitGames.Client.Photon.Hashtable content;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public JAILPPEAJLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x510B060", Offset = "0x510A060", VA = "0x18510B060")]
		internal bool <ClearSliceIds>b__3(OFMCGBJJLCB stackSlice)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x510B160", Offset = "0x510A160", VA = "0x18510B160")]
		internal object <ClearSliceIds>b__5()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x510B3A0", Offset = "0x510A3A0", VA = "0x18510B3A0")]
		internal object <ClearSliceIds>b__6()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x510B100", Offset = "0x510A100", VA = "0x18510B100")]
		internal object <ClearSliceIds>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly GJOOODAOFJK OLCBMMHKLGN;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable JNFFGFPNHHO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly MKIPHPEHNBE CKKAFDLDDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KPHNKGGBBHD MKDFEFFFGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HBMKFBHFMKC FHCHAGPLIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly LAEKIIIALDE LDLGNGJPNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly EHPGEFACFMG GIEODOONCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GJOOODAOFJK FAGIMGDLGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool KMDCHDFHKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[CompilerGenerated]
	private Action<JBNKHPMBOHH> GFODPAEJPKN;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan JLDAKKFHMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan HHNDENMMGNK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal static readonly GADKDGANEEE[] FLEIBJDMPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] OGIMBNBNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<OFMCGBJJLCB> NPCNGDOJGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private (GADKDGANEEE combinedSliceType, Guid[] sliceTypeIds)? MGBLFOJMHLK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x51075B0", Offset = "0x51065B0", VA = "0x1851075B0")]
	public DHMEJIBAPAG(HBMKFBHFMKC FHCHAGPLIJN, LAEKIIIALDE LDLGNGJPNCJ, EHPGEFACFMG GIEODOONCNI, [Optional] TimeSpan? AECIOMIMKJF, [Optional] GJOOODAOFJK JBCHFNOGNHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x25FEAC0", Offset = "0x25FDAC0", VA = "0x1825FEAC0")]
	public static DHMEJIBAPAG HLAKHBGOOKB<TNetworking>(TNetworking CHFAHPDAJBK, [Optional] TimeSpan? AECIOMIMKJF, [Optional] GJOOODAOFJK JBCHFNOGNHL) where TNetworking : HBMKFBHFMKC, LAEKIIIALDE, EHPGEFACFMG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5107320", Offset = "0x5106320", VA = "0x185107320")]
	public void PKDHKFNAFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x51059C0", Offset = "0x51049C0", VA = "0x1851059C0")]
	private TimeSpan IIHLFPDACNN(TimeSpan? AECIOMIMKJF, int NCCNLMGFCCF = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x25D6650", Offset = "0x25D5650", VA = "0x1825D6650")]
	public bool PCMIANIFMJL<T>(T PAAIHLKEHCB, Func<T, byte[]> PMDNLHEELBE, bool EOOALNJDKMO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5106DA0", Offset = "0x5105DA0", VA = "0x185106DA0")]
	public bool PCMIANIFMJL(byte[] PAAIHLKEHCB, int GPDDFMKEEOF, bool EOOALNJDKMO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5105D00", Offset = "0x5104D00", VA = "0x185105D00")]
	private static string KKOAEBHBAOL(GADKDGANEEE FBIILNMCHDD, Guid[] DHCOMDPAFKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x51065D0", Offset = "0x51055D0", VA = "0x1851065D0")]
	[IteratorStateMachine(typeof(EGBIEEMKECE))]
	private static IEnumerable<(GADKDGANEEE, Guid)> OFHNLKPJFOH(GADKDGANEEE JIJHANECGEC, Guid[] DHCOMDPAFKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5104E00", Offset = "0x5103E00", VA = "0x185104E00")]
	[AsyncStateMachine(typeof(OEAMCOCHCLI))]
	public Task<JBNKHPMBOHH> HCNMPCMHBEL(CancellationToken DBKPHPKFAOL, [Optional] ICIEEPGDOPO HDDGNILFMOI, [Optional] ICIEEPGDOPO GOACIHOJBNG, [Optional] TimeSpan? AECIOMIMKJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5105BA0", Offset = "0x5104BA0", VA = "0x185105BA0")]
	[AsyncStateMachine(typeof(HFFOCLFIFLP))]
	public Task<Guid> JFICPCGFHEE(Guid FENCHDBEBNF, CancellationToken DBKPHPKFAOL, [Optional] ICIEEPGDOPO HDDGNILFMOI, [Optional] ICIEEPGDOPO GOACIHOJBNG, [Optional] TimeSpan? KKNJDBDMIKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FBBB50", Offset = "0x1FBAB50", VA = "0x181FBBB50")]
	[AsyncStateMachine(typeof(AAEEFOMCBKD))]
	public Task<HFJKKICEOLG<T>> EGBJNKODFOH<T>(T PAAIHLKEHCB, Func<T, byte[]> PMDNLHEELBE, Func<byte[], T> BHGHHDMMDBA, CancellationToken DBKPHPKFAOL, [Optional] ICIEEPGDOPO HDDGNILFMOI, [Optional] ICIEEPGDOPO GOACIHOJBNG, [Optional] TimeSpan? KKNJDBDMIKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x51043F0", Offset = "0x51033F0", VA = "0x1851043F0")]
	[AsyncStateMachine(typeof(GFEMPDDCGAO))]
	public Task<JBNKHPMBOHH> EGBJNKODFOH(byte[] PAAIHLKEHCB, CancellationToken DBKPHPKFAOL, [Optional] ICIEEPGDOPO HDDGNILFMOI, [Optional] ICIEEPGDOPO GOACIHOJBNG, [Optional] TimeSpan? KKNJDBDMIKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5106440", Offset = "0x5105440", VA = "0x185106440")]
	[AsyncStateMachine(typeof(FHEHAGJCMHI))]
	private Task<JBNKHPMBOHH> MFHJCPMHPBF(byte[] PAAIHLKEHCB, CancellationToken DBKPHPKFAOL, ICIEEPGDOPO HDDGNILFMOI, ICIEEPGDOPO GOACIHOJBNG, TimeSpan? AECIOMIMKJF, Stopwatch DBFFGLODGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5104C90", Offset = "0x5103C90", VA = "0x185104C90")]
	[AsyncStateMachine(typeof(LLLKLPAFCLL))]
	private Task<JBNKHPMBOHH> HAFMKBMDHMA(byte[] PAAIHLKEHCB, CancellationToken DBKPHPKFAOL, [Optional] ICIEEPGDOPO HDDGNILFMOI, [Optional] ICIEEPGDOPO GOACIHOJBNG, [Optional] TimeSpan? KKNJDBDMIKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x51071C0", Offset = "0x51061C0", VA = "0x1851071C0")]
	[AsyncStateMachine(typeof(GDPLLLJIFAO))]
	public Task PDDBPLJDENH(CancellationToken PJNALPBJAIG, Func<CancellationToken, Task> GEKBPMAECFO, [Optional] ICIEEPGDOPO HDDGNILFMOI, [Optional] ICIEEPGDOPO GOACIHOJBNG, int KDIOPKHMACC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC1C0", Offset = "0x1FBB1C0", VA = "0x181FBC1C0")]
	[AsyncStateMachine(typeof(JGOLCOGINLD))]
	public Task<T> PDDBPLJDENH<T>(CancellationToken PJNALPBJAIG, Func<CancellationToken, Task<T>> GEKBPMAECFO, [Optional] ICIEEPGDOPO HDDGNILFMOI, [Optional] ICIEEPGDOPO GOACIHOJBNG, int KDIOPKHMACC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FBBD10", Offset = "0x1FBAD10", VA = "0x181FBBD10")]
	[AsyncStateMachine(typeof(LPBLEJBGCIE))]
	private Task<(bool, T)> MJLPPEJCNCJ<T>(Guid ANEBPHEMKIC, CancellationToken PJNALPBJAIG, Func<CancellationToken, Task<T>> GEKBPMAECFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5106650", Offset = "0x5105650", VA = "0x185106650")]
	public void OLBIHNACAMB(byte EBLGDKGINDK, int AMBPGPMKBIB, object EEOJOPFBAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5104560", Offset = "0x5103560", VA = "0x185104560")]
	public Guid EICKDGBKCBH(Guid NOKPHBAFGIM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x51040F0", Offset = "0x51030F0", VA = "0x1851040F0")]
	internal static int DLAHPKJJBKL(GADKDGANEEE FBIILNMCHDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x51047B0", Offset = "0x51037B0", VA = "0x1851047B0")]
	public bool EIOLHFOMIPN(GADKDGANEEE FBIILNMCHDD, Guid ANEBPHEMKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5106110", Offset = "0x5105110", VA = "0x185106110")]
	public void MEDMAHFPONI(GADKDGANEEE FBIILNMCHDD, Guid ANEBPHEMKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x51065C0", Offset = "0x51055C0", VA = "0x1851065C0")]
	private void MNGEGHMCGPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5105320", Offset = "0x5104320", VA = "0x185105320")]
	internal (GADKDGANEEE, Guid[]) HGBCHGFLAHL(bool GNKJCEHBCFM = false)
	{
		return default((GADKDGANEEE, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5105E50", Offset = "0x5104E50", VA = "0x185105E50")]
	private HashSet<Guid> KLFLNINJBLG(GADKDGANEEE FBIILNMCHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5103F70", Offset = "0x5102F70", VA = "0x185103F70")]
	private void DECEFPPLBKH(GADKDGANEEE FBIILNMCHDD, Guid MDOMNGAAEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x51041A0", Offset = "0x51031A0", VA = "0x1851041A0")]
	private void EFEJIIBENLG(GADKDGANEEE FBIILNMCHDD, Guid MDOMNGAAEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5104C00", Offset = "0x5103C00", VA = "0x185104C00")]
	public static Func<Guid, bool> EPBECKKIBLL(Guid MDOMNGAAEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5106080", Offset = "0x5105080", VA = "0x185106080")]
	public static Func<Guid, bool> MBKCJBLDNMA(Guid MDOMNGAAEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5105F90", Offset = "0x5104F90", VA = "0x185105F90")]
	public void LMDOPAFOAND(GADKDGANEEE FBIILNMCHDD, Guid MDMGEIKDFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5103730", Offset = "0x5102730", VA = "0x185103730")]
	public void BNFHDPBOLAK(GADKDGANEEE FBIILNMCHDD, Func<Guid, bool> ONDKOHLCKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5105210", Offset = "0x5104210", VA = "0x185105210")]
	private string HGAJOAJLKDH(byte[] KBOOFLMIFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5105710", Offset = "0x5104710", VA = "0x185105710")]
	[CompilerGenerated]
	private object IEJAIGOJIKM(in (GADKDGANEEE st, Guid[] ids, byte[] mts) AIAEIEGFNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5104F60", Offset = "0x5103F60", VA = "0x185104F60")]
	[CompilerGenerated]
	private object HFLDHAAFEIK(in (GADKDGANEEE rst, Guid[] ssids, byte[] pl) AIAEIEGFNFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class JJOMBECOFCL : OAHCCBPPJNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private List<(HGLEPJPPBJD.EKICCJBILEE itemType, long totalStopwatchTicks)> NKEIIGBBEMI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<(HGLEPJPPBJD.EKICCJBILEE itemType, long totalStopwatchTicks)> CKBAJJJIDII
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5DF140", Offset = "0x5DE140", VA = "0x1805DF140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x510B840", Offset = "0x510A840", VA = "0x18510B840")]
	public JJOMBECOFCL(TimeSpan KKNJDBDMIKF, List<(HGLEPJPPBJD.EKICCJBILEE itemType, long totalStopwatchTicks)> NKEIIGBBEMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HFIDMJIFIJH : INCHNNODFIF
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct BPPLDKIJOJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly Guid AJOHBHKDAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly int PHFMAKKGHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly int BHCMHDOPCCH;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x51035C0", Offset = "0x51025C0", VA = "0x1851035C0")]
		public BPPLDKIJOJJ(Guid MEFIPOLCBKA, int BKEKPBBICKP, int GICGNLAGPAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5103470", Offset = "0x5102470", VA = "0x185103470")]
		public static byte[] DBCHIDLCGFP(BPPLDKIJOJJ EOGLFEOLNBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5103540", Offset = "0x5102540", VA = "0x185103540")]
		private static byte[] NJFOKHNLMHG(int BHFIJCEBIFE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Guid MEFIPOLCBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly DHMEJIBAPAG AJBJMDONAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private bool FALKBAICFEH;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x510A510", Offset = "0x5109510", VA = "0x18510A510")]
	public HFIDMJIFIJH(Guid MEFIPOLCBKA, DHMEJIBAPAG AJBJMDONAHD, EHPGEFACFMG CHFAHPDAJBK, CancellationToken PJNALPBJAIG, [Optional] HCDBIPLPHLH HPLPECBOJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x510A380", Offset = "0x5109380", VA = "0x18510A380", Slot = "5")]
	protected override void DHALODNPDBN(int AKOHBNPOCDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct JBNKHPMBOHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool BHOBCADKJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly DHMEJIBAPAG.GADKDGANEEE PLHHHDHHHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Guid[] NLIIAFIHKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly byte[] BJPKEDBOAHD;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3B25A20", Offset = "0x3B24A20", VA = "0x183B25A20")]
	public JBNKHPMBOHH(DHMEJIBAPAG.GADKDGANEEE FBIILNMCHDD, [NotNull] Guid[] HOPBGOAMNKN, byte[] KBOOFLMIFHM, bool EOOALNJDKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x510B5E0", Offset = "0x510A5E0", VA = "0x18510B5E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class LMPKOJFHKBP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x27F1DB0", Offset = "0x27F0DB0", VA = "0x1827F1DB0", Slot = "4")]
	public void EGAAIDCKGEG(T EOGLFEOLNBK, IDictionary<object, object> GPELMIMHNGI, bool OKLHMCIDFLE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void PHMFEBFNGMG(T EOGLFEOLNBK, IDictionary<object, object> GPELMIMHNGI);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T EKIAPEHGMJJ(IDictionary<object, object> GPELMIMHNGI);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x27F1E60", Offset = "0x27F0E60", VA = "0x1827F1E60", Slot = "7")]
	public bool LGJNDOLHJOB(IDictionary<object, object> GPELMIMHNGI, out T BNDBFNPJCNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
	protected LMPKOJFHKBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class INCHNNODFIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool HCDBIPLPHLH(int JEJPMAGCDMF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool FFEBDMPJINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly EHPGEFACFMG EJDFNPMMDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken PJNALPBJAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken MKCLEAJKFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly HCDBIPLPHLH HPLPECBOJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource PCIHEEBLNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource LLBKDKDIPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int AGLCDINIJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool CAIAEOIPJCP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken PGELLCKNJFA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x510AE10", Offset = "0x5109E10", VA = "0x18510AE10")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CFIKOIBEBDD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x510AE30", Offset = "0x5109E30", VA = "0x18510AE30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x510AE80", Offset = "0x5109E80", VA = "0x18510AE80")]
	public INCHNNODFIF(EHPGEFACFMG CHFAHPDAJBK, CancellationToken PJNALPBJAIG, [Optional] HCDBIPLPHLH HPLPECBOJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2E88EE0", Offset = "0x2E87EE0", VA = "0x182E88EE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x510AD20", Offset = "0x5109D20", VA = "0x18510AD20")]
	private void FKCEFILPALI(PFKPMMNPKFG ACKNLJBNOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x510ADB0", Offset = "0x5109DB0", VA = "0x18510ADB0")]
	protected void GAJCLNBNDIE(int AKOHBNPOCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x510AD00", Offset = "0x5109D00", VA = "0x18510AD00", Slot = "5")]
	protected virtual void DHALODNPDBN(int AKOHBNPOCDL)
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

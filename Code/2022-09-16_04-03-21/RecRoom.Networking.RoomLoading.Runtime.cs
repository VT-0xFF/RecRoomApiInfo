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
internal class PKPFDJEBHCP : global::KGPLAFODKFO<HALEFFKAIIH>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class DLBNHMMCBCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public DLBNHMMCBCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x403ABB0", Offset = "0x40393B0", VA = "0x18403ABB0")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] OPKGEALJGIH;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly PKPFDJEBHCP AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x403FB60", Offset = "0x403E360", VA = "0x18403FB60", Slot = "5")]
	protected override void MDBECNOKKBH(HALEFFKAIIH MEKFJFMIPGK, IDictionary<object, object> DMDONNOOOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x403F280", Offset = "0x403DA80", VA = "0x18403F280", Slot = "6")]
	public override HALEFFKAIIH JDKEMADGCJE(IDictionary<object, object> DMDONNOOOJK)
	{
		return default(HALEFFKAIIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4040140", Offset = "0x403E940", VA = "0x184040140")]
	public PKPFDJEBHCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DJBLMANHFBO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string KFNAEONEEOF([NotNull] byte[] KDGHFFBPFDE);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum HGNEPELMAMH : byte
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
	private readonly struct CDPMLGLPOCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly HGNEPELMAMH NDBFCPOMIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Guid EIMFIFGBFJG;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2FA53E0", Offset = "0x2FA3BE0", VA = "0x182FA53E0")]
		public CDPMLGLPOCF(HGNEPELMAMH EJLJJLKMIEL, Guid BCGPNMMPFAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x40366B0", Offset = "0x4034EB0", VA = "0x1840366B0")]
		public bool OIFFJDEDINI(CDPMLGLPOCF ALBOAABJIJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x40365C0", Offset = "0x4034DC0", VA = "0x1840365C0", Slot = "0")]
		public override bool Equals(object DEGGOOGCHFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4036680", Offset = "0x4034E80", VA = "0x184036680", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct HJINFOPEKHA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly bool HDEKKOMDAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly HGNEPELMAMH NDBFCPOMIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Guid[] MJNPGEDEPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly T MDIAFFAPDLP;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x52DF8C0", Offset = "0x52DE0C0", VA = "0x1852DF8C0")]
		public static HJINFOPEKHA<T> PNCNAOOPFBL(HALEFFKAIIH IEGGBBKPGMF, Func<byte[], T> BEIMGIMFDGI)
		{
			return default(HJINFOPEKHA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x52DFCD0", Offset = "0x52DE4D0", VA = "0x1852DFCD0")]
		public HJINFOPEKHA(HGNEPELMAMH EJLJJLKMIEL, Guid[] BILFKMHEJIA, T KDGHFFBPFDE, bool FHIONPDACPF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x52DFBB0", Offset = "0x52DE3B0", VA = "0x1852DFBB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class ADFPAAMHOGL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class HDOKGIMAGGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public TaskCompletionSource<HALEFFKAIIH> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public ADFPAAMHOGL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public HDOKGIMAGGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x403C2C0", Offset = "0x403AAC0", VA = "0x18403C2C0")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x403C310", Offset = "0x403AB10", VA = "0x18403C310")]
			internal FBJGEMLKEII <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class MJJEHEKJAGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public JGHLFIIIHAB.OODECHLDJDH itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public MJJEHEKJAGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x403DFB0", Offset = "0x403C7B0", VA = "0x18403DFB0")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct LPNOAFACPLN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<HALEFFKAIIH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ADFPAAMHOGL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private HDOKGIMAGGF <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private TaskAwaiter<HALEFFKAIIH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x403D8B0", Offset = "0x403C0B0", VA = "0x18403D8B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x403DF60", Offset = "0x403C760", VA = "0x18403DF60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class POPHPNGNEKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public HGNEPELMAMH sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public POPHPNGNEKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4040180", Offset = "0x403E980", VA = "0x184040180")]
			internal bool <ClearSlice>b__0(HALEFFKAIIH bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly BDHGIDIPLCG AGJGNAFFJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly string DKCLLDANEDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly List<HALEFFKAIIH> JBJBFMOMNHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private List<(JGHLFIIIHAB.OODECHLDJDH itemType, long totalStopwatchTicks)> LKJOHILLCHM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool ODCLFEJAOLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x4036060", Offset = "0x4034860", VA = "0x184036060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<HALEFFKAIIH> ABJCDJCKKLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x40360A0", Offset = "0x40348A0", VA = "0x1840360A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x4036280", Offset = "0x4034A80", VA = "0x184036280")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4036410", Offset = "0x4034C10", VA = "0x184036410")]
		public ADFPAAMHOGL(BDHGIDIPLCG AGJGNAFFJCM, string DKCLLDANEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4036140", Offset = "0x4034940", VA = "0x184036140")]
		[AsyncStateMachine(typeof(LPNOAFACPLN))]
		public Task<HALEFFKAIIH> NHIMGMPILKN(CancellationToken NFKHAKHIBIO, TimeSpan GDFNPCLFOHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4035FB0", Offset = "0x40347B0", VA = "0x184035FB0")]
		public void GANHENFBOIJ(HALEFFKAIIH MEKFJFMIPGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4035F60", Offset = "0x4034760", VA = "0x184035F60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4036320", Offset = "0x4034B20", VA = "0x184036320")]
		public void PNGJLMIJIHC(HGNEPELMAMH EJLJJLKMIEL, Guid OCNCOBFEOBE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HFJJBILKJCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<HALEFFKAIIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public ICLKJDCDBDB unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DJBLMANHFBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public ICLKJDCDBDB pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<HALEFFKAIIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x403C630", Offset = "0x403AE30", VA = "0x18403C630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x403CE10", Offset = "0x403B610", VA = "0x18403CE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LBALINIGCJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public DJBLMANHFBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public ICLKJDCDBDB unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public ICLKJDCDBDB pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<HJINFOPEKHA<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x403D540", Offset = "0x403BD40", VA = "0x18403D540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x403D860", Offset = "0x403C060", VA = "0x18403D860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CKFHDIHGCGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<HALEFFKAIIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public DJBLMANHFBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ICLKJDCDBDB unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public ICLKJDCDBDB pauseAfterListeningToken;

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
		private TaskAwaiter<HALEFFKAIIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4036710", Offset = "0x4034F10", VA = "0x184036710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4036E60", Offset = "0x4035660", VA = "0x184036E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class KBMKJDEDJPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public DJBLMANHFBO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public KBMKJDEDJPE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct GFNMBCJCILF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AsyncTaskMethodBuilder<HALEFFKAIIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public DJBLMANHFBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private KBMKJDEDJPE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ICLKJDCDBDB unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public ICLKJDCDBDB pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private JLIDBHLNGHJ <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<HALEFFKAIIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x403B390", Offset = "0x4039B90", VA = "0x18403B390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x403BC00", Offset = "0x403A400", VA = "0x18403BC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct OHOBDJDIBHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<HALEFFKAIIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public DJBLMANHFBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public ICLKJDCDBDB unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public ICLKJDCDBDB pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<HALEFFKAIIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x403E2A0", Offset = "0x403CAA0", VA = "0x18403E2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x403E5D0", Offset = "0x403CDD0", VA = "0x18403E5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IMCNHHECAJH
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
			public IMCNHHECAJH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4040370", Offset = "0x403EB70", VA = "0x184040370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x40404D0", Offset = "0x403ECD0", VA = "0x1840404D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public IMCNHHECAJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x403CEF0", Offset = "0x403B6F0", VA = "0x18403CEF0")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct NHMHNMKIFMD : IAsyncStateMachine
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
		public DJBLMANHFBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public ICLKJDCDBDB unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public ICLKJDCDBDB pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x403E0C0", Offset = "0x403C8C0", VA = "0x18403E0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class EMMJBKKAHHH : IEnumerable<(HGNEPELMAMH, Guid)>, IEnumerable, IEnumerator<(HGNEPELMAMH, Guid)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private (HGNEPELMAMH sliceType, Guid sliceId) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private HGNEPELMAMH sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public HGNEPELMAMH <>3__sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Guid[] sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Guid[] <>3__sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private HGNEPELMAMH[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (HGNEPELMAMH, Guid) System.Collections.Generic.IEnumerator<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x1208F80", Offset = "0x1207780", VA = "0x181208F80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((HGNEPELMAMH, Guid));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x403AF70", Offset = "0x4039770", VA = "0x18403AF70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xE4C760", Offset = "0xE4AF60", VA = "0x180E4C760")]
		[DebuggerHidden]
		public EMMJBKKAHHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x403AC50", Offset = "0x4039450", VA = "0x18403AC50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x403AF20", Offset = "0x4039720", VA = "0x18403AF20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x403AE70", Offset = "0x4039670", VA = "0x18403AE70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(HGNEPELMAMH, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x403AE70", Offset = "0x4039670", VA = "0x18403AE70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class PEBMELFPNLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public PEBMELFPNLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x403EC60", Offset = "0x403D460", VA = "0x18403EC60")]
		internal object <OnEvent>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x403ECA0", Offset = "0x403D4A0", VA = "0x18403ECA0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x403ECF0", Offset = "0x403D4F0", VA = "0x18403ECF0")]
		internal object <OnEvent>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class PPLJAPGPCLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public HGNEPELMAMH sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public PPLJAPGPCLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x40402F0", Offset = "0x403EAF0", VA = "0x1840402F0")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ADBLOEEHJGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public HGNEPELMAMH sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ADBLOEEHJGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4035EE0", Offset = "0x40346E0", VA = "0x184035EE0")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class BADPCANNJNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public BADPCANNJNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x40364E0", Offset = "0x4034CE0", VA = "0x1840364E0")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NGOBPJDDGIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public NGOBPJDDGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x403E060", Offset = "0x403C860", VA = "0x18403E060")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class IKGCCNKGKPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public IKGCCNKGKPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x403CE60", Offset = "0x403B660", VA = "0x18403CE60")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class FFLGLMBMAHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public FFLGLMBMAHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x403B040", Offset = "0x4039840", VA = "0x18403B040")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class PDHGAIKEJKB
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
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public PDHGAIKEJKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x403EC00", Offset = "0x403D400", VA = "0x18403EC00")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x403EBA0", Offset = "0x403D3A0", VA = "0x18403EBA0")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OJFADGMHIIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public ExitGames.Client.Photon.Hashtable content;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public OJFADGMHIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x403E620", Offset = "0x403CE20", VA = "0x18403E620")]
		internal bool <ClearSliceIds>b__3(CDPMLGLPOCF stackSlice)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x403E720", Offset = "0x403CF20", VA = "0x18403E720")]
		internal object <ClearSliceIds>b__5()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x403E960", Offset = "0x403D160", VA = "0x18403E960")]
		internal object <ClearSliceIds>b__6()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x403E6C0", Offset = "0x403CEC0", VA = "0x18403E6C0")]
		internal object <ClearSliceIds>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly KFNAEONEEOF LMAHLOPAPBN;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable MGELBFGHLAD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly DICHEIDPIBF FLLKMEKEHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly ADFPAAMHOGL ADEGHDAOIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly BDHGIDIPLCG AGJGNAFFJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly MOLINOFIHPI GLNHGCBDFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly FHANKEDBHBD NPDGALKGHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly KFNAEONEEOF KOOGMFNMLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool FNFCOIPJPFP;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan GNPMNKOLKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan KJKLAKHJPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte HPDJPKJIDIH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal static readonly HGNEPELMAMH[] GFCPPEGCDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HashSet<Guid>[] HDKGCEEKBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<CDPMLGLPOCF> BBCCNGPGOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private (HGNEPELMAMH combinedSliceType, Guid[] sliceTypeIds)? HOBKLDMNFMB;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<HALEFFKAIIH> FPOHODJOCCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4038EC0", Offset = "0x40376C0", VA = "0x184038EC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4039140", Offset = "0x4037940", VA = "0x184039140")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x403A7C0", Offset = "0x4038FC0", VA = "0x18403A7C0")]
	public DJBLMANHFBO(BDHGIDIPLCG AGJGNAFFJCM, MOLINOFIHPI GLNHGCBDFNN, FHANKEDBHBD NPDGALKGHBC, [Optional] TimeSpan? PFKAPCCHEHN, [Optional] KFNAEONEEOF LIINMGLIIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1182E80", Offset = "0x1181680", VA = "0x181182E80")]
	public static DJBLMANHFBO DOCFBGCJPNJ<TNetworking>(TNetworking GFGNDDMLFJA, [Optional] TimeSpan? PFKAPCCHEHN, [Optional] KFNAEONEEOF LIINMGLIIGL) where TNetworking : BDHGIDIPLCG, MOLINOFIHPI, FHANKEDBHBD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x40382D0", Offset = "0x4036AD0", VA = "0x1840382D0")]
	public void KFAGLIPHBHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x40377B0", Offset = "0x4035FB0", VA = "0x1840377B0")]
	private byte EHAIBOCAKPM()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4037B80", Offset = "0x4036380", VA = "0x184037B80")]
	private TimeSpan IEOMJPPKIFE(TimeSpan? PFKAPCCHEHN, int MKEMNCKEBMN = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1787FB0", Offset = "0x17867B0", VA = "0x181787FB0")]
	public bool MHELJKDNGDO<T>(T HDOJINBFOGP, Func<T, byte[]> MEBJIKNMLPK, bool FHIONPDACPF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x40389A0", Offset = "0x40371A0", VA = "0x1840389A0")]
	public bool MHELJKDNGDO(byte[] HDOJINBFOGP, int FECBPKFEGMD, bool FHIONPDACPF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x86BBC0", Offset = "0x86A3C0", VA = "0x18086BBC0")]
	private static string AEGOHFHBCEE(string MEKFJFMIPGK, string NDEHEJIJFDM = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4039B80", Offset = "0x4038380", VA = "0x184039B80")]
	[AsyncStateMachine(typeof(HFJJBILKJCK))]
	public Task<HALEFFKAIIH> PHCKAPGBDDN(CancellationToken NFKHAKHIBIO, [Optional] ICLKJDCDBDB HBNIINIHMJE, [Optional] ICLKJDCDBDB CPNDHKDODLI, [Optional] TimeSpan? PFKAPCCHEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4037A20", Offset = "0x4036220", VA = "0x184037A20")]
	[AsyncStateMachine(typeof(LBALINIGCJN))]
	public Task<Guid> GPJBDJKBPJB(Guid GLPFLCFDJOO, CancellationToken NFKHAKHIBIO, [Optional] ICLKJDCDBDB HBNIINIHMJE, [Optional] ICLKJDCDBDB CPNDHKDODLI, [Optional] TimeSpan? GDFNPCLFOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4F52700", Offset = "0x4F50F00", VA = "0x184F52700")]
	[AsyncStateMachine(typeof(NKAIDABDLDP))]
	public Task<HJINFOPEKHA<T>> CBCPJOIACDI<T>(T HDOJINBFOGP, Func<T, byte[]> MEBJIKNMLPK, Func<byte[], T> BEIMGIMFDGI, CancellationToken NFKHAKHIBIO, [Optional] ICLKJDCDBDB HBNIINIHMJE, [Optional] ICLKJDCDBDB CPNDHKDODLI, [Optional] TimeSpan? GDFNPCLFOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4037420", Offset = "0x4035C20", VA = "0x184037420")]
	[AsyncStateMachine(typeof(CKFHDIHGCGK))]
	public Task<HALEFFKAIIH> CBCPJOIACDI(byte[] HDOJINBFOGP, CancellationToken NFKHAKHIBIO, [Optional] ICLKJDCDBDB HBNIINIHMJE, [Optional] ICLKJDCDBDB CPNDHKDODLI, [Optional] TimeSpan? GDFNPCLFOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x40372A0", Offset = "0x4035AA0", VA = "0x1840372A0")]
	[AsyncStateMachine(typeof(GFNMBCJCILF))]
	private Task<HALEFFKAIIH> BHOIFONLKID(byte[] HDOJINBFOGP, CancellationToken NFKHAKHIBIO, ICLKJDCDBDB HBNIINIHMJE, ICLKJDCDBDB CPNDHKDODLI, TimeSpan? PFKAPCCHEHN, Stopwatch PJHLHJMNDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4037640", Offset = "0x4035E40", VA = "0x184037640")]
	[AsyncStateMachine(typeof(OHOBDJDIBHG))]
	private Task<HALEFFKAIIH> DDPDNKENNDK(byte[] HDOJINBFOGP, CancellationToken NFKHAKHIBIO, [Optional] ICLKJDCDBDB HBNIINIHMJE, [Optional] ICLKJDCDBDB CPNDHKDODLI, [Optional] TimeSpan? GDFNPCLFOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4038FE0", Offset = "0x40377E0", VA = "0x184038FE0")]
	[AsyncStateMachine(typeof(NHMHNMKIFMD))]
	public Task NLJOPEIDEGA(CancellationToken LAOFPANACHA, Func<CancellationToken, Task> BICOAAOLKFL, [Optional] ICLKJDCDBDB HBNIINIHMJE, [Optional] ICLKJDCDBDB CPNDHKDODLI, int DNBIHEOGKOA = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4F528C0", Offset = "0x4F510C0", VA = "0x184F528C0")]
	[AsyncStateMachine(typeof(KLMJJLOODNP))]
	public Task<T> NLJOPEIDEGA<T>(CancellationToken LAOFPANACHA, Func<CancellationToken, Task<T>> BICOAAOLKFL, [Optional] ICLKJDCDBDB HBNIINIHMJE, [Optional] ICLKJDCDBDB CPNDHKDODLI, int DNBIHEOGKOA = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4F52DA0", Offset = "0x4F515A0", VA = "0x184F52DA0")]
	[AsyncStateMachine(typeof(AFDMJLFHBBC))]
	private Task<(bool, T)> OKDGMLMOPDD<T>(Guid BCGPNMMPFAE, CancellationToken LAOFPANACHA, Func<CancellationToken, Task<T>> BICOAAOLKFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4038F60", Offset = "0x4037760", VA = "0x184038F60")]
	[IteratorStateMachine(typeof(EMMJBKKAHHH))]
	internal static IEnumerable<(HGNEPELMAMH, Guid)> NDADIFPAOMJ(HGNEPELMAMH CGBEADNGPJM, Guid[] DJLCMBCJBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4039430", Offset = "0x4037C30", VA = "0x184039430")]
	public void PAKOAJPGOPN(byte NFCNJIFDDME, int OBONDCDABKM, object DHCKFDBNGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x40391E0", Offset = "0x40379E0", VA = "0x1840391E0")]
	public Guid OOOAPAOKJFL(Guid CMLHKBKDCCL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4037590", Offset = "0x4035D90", VA = "0x184037590")]
	internal static int DANMFPLGNEC(HGNEPELMAMH EJLJJLKMIEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4037D60", Offset = "0x4036560", VA = "0x184037D60")]
	public bool IJMKDHJOPFF(HGNEPELMAMH EJLJJLKMIEL, Guid BCGPNMMPFAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4038670", Offset = "0x4036E70", VA = "0x184038670")]
	public void LJLNFMCNPPJ(HGNEPELMAMH EJLJJLKMIEL, Guid BCGPNMMPFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4037A10", Offset = "0x4036210", VA = "0x184037A10")]
	private void GNKNIKGNGGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4036EB0", Offset = "0x40356B0", VA = "0x184036EB0")]
	internal (HGNEPELMAMH, Guid[]) BDKPHPKHIPO(bool IHHKDPGCEOC = false)
	{
		return default((HGNEPELMAMH, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4038530", Offset = "0x4036D30", VA = "0x184038530")]
	private HashSet<Guid> LFIBJCBMIPG(HGNEPELMAMH EJLJJLKMIEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x40383B0", Offset = "0x4036BB0", VA = "0x1840383B0")]
	private void KNCBIHMPKPI(HGNEPELMAMH EJLJJLKMIEL, Guid OCNCOBFEOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x40377C0", Offset = "0x4035FC0", VA = "0x1840377C0")]
	private void GIHKILLIHAD(HGNEPELMAMH EJLJJLKMIEL, Guid OCNCOBFEOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4038240", Offset = "0x4036A40", VA = "0x184038240")]
	public static Func<Guid, bool> KEMPHCMFPGD(Guid OCNCOBFEOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x40381B0", Offset = "0x40369B0", VA = "0x1840381B0")]
	public static Func<Guid, bool> IMAMMMELCDL(Guid OCNCOBFEOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x403A520", Offset = "0x4038D20", VA = "0x18403A520")]
	public void PNGJLMIJIHC(HGNEPELMAMH EJLJJLKMIEL, Guid KCGBAGCENOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4039CE0", Offset = "0x40384E0", VA = "0x184039CE0")]
	public void PNCIDJFMDFG(HGNEPELMAMH EJLJJLKMIEL, Func<Guid, bool> EANFEILOCNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class FBJGEMLKEII : DJBFEDEFFNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private List<(JGHLFIIIHAB.OODECHLDJDH itemType, long totalStopwatchTicks)> IOBJINJLECO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<(JGHLFIIIHAB.OODECHLDJDH itemType, long totalStopwatchTicks)> BHEECBMBBDK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x606E20", Offset = "0x605620", VA = "0x180606E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x403AFC0", Offset = "0x40397C0", VA = "0x18403AFC0")]
	public FBJGEMLKEII(TimeSpan GDFNPCLFOHL, List<(JGHLFIIIHAB.OODECHLDJDH itemType, long totalStopwatchTicks)> IOBJINJLECO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PKHHGOBBIMK : JLIDBHLNGHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct GEABFDOKEAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly Guid FDJOECCCBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly int LINOCPNBIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly int AENKIAKHOGM;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x403B380", Offset = "0x4039B80", VA = "0x18403B380")]
		public GEABFDOKEAB(Guid COEIKBGNCEC, int MNAPBBHNKAK, int FKLHINKPNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x403B150", Offset = "0x4039950", VA = "0x18403B150")]
		public static byte[] BAGHAKDDGPK(GEABFDOKEAB MEKFJFMIPGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x403B2D0", Offset = "0x4039AD0", VA = "0x18403B2D0")]
		public static GEABFDOKEAB JDKEMADGCJE(byte[] FCDIIMLAMIO)
		{
			return default(GEABFDOKEAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x403B0D0", Offset = "0x40398D0", VA = "0x18403B0D0")]
		private static byte[] ACLAAGNKBIO(int GDBELOJNNFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x403B220", Offset = "0x4039A20", VA = "0x18403B220")]
		private static int FDJNKOKDAGF(byte[] MGHDEKNJMOF, int AKLHCIJHJKB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Guid COEIKBGNCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly DJBLMANHFBO KNLKEAKJLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private bool KMOCPIGIGED;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x403F220", Offset = "0x403DA20", VA = "0x18403F220")]
	public PKHHGOBBIMK(Guid COEIKBGNCEC, DJBLMANHFBO KNLKEAKJLIN, FHANKEDBHBD GFGNDDMLFJA, CancellationToken LAOFPANACHA, [Optional] BCBPCHMJLPK CLEGHJGBJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x403EF10", Offset = "0x403D710", VA = "0x18403EF10", Slot = "5")]
	protected override void JHCIFLFKFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x403F090", Offset = "0x403D890", VA = "0x18403F090", Slot = "6")]
	protected override void PFHGKHDGJDO(int AANFMKCDLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x403ED30", Offset = "0x403D530", VA = "0x18403ED30")]
	private void FPOHODJOCCN(HALEFFKAIIH EKHIHPABMPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct HALEFFKAIIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly byte HGACPNCMOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly byte HNMCLHMDNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly bool HDEKKOMDAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly DJBLMANHFBO.HGNEPELMAMH NDBFCPOMIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly Guid[] MJNPGEDEPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly byte[] MDIAFFAPDLP;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x403C260", Offset = "0x403AA60", VA = "0x18403C260")]
	public HALEFFKAIIH(DJBLMANHFBO.HGNEPELMAMH EJLJJLKMIEL, [NotNull] Guid[] BILFKMHEJIA, byte[] KDGHFFBPFDE, bool FHIONPDACPF, byte LCPCKJDBNCF, byte AKNCLIDCCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x403BDF0", Offset = "0x403A5F0", VA = "0x18403BDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x403BC50", Offset = "0x403A450", VA = "0x18403BC50")]
	private static void HEFBKBHIPHP(byte[] KDGHFFBPFDE, StringBuilder FPIABMPEEMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class KGPLAFODKFO<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x55E1A20", Offset = "0x55E0220", VA = "0x1855E1A20", Slot = "4")]
	public void MKKLKGGAAIE(T MEKFJFMIPGK, IDictionary<object, object> DMDONNOOOJK, bool FEDLIEIIHNC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void MDBECNOKKBH(T MEKFJFMIPGK, IDictionary<object, object> DMDONNOOOJK);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T JDKEMADGCJE(IDictionary<object, object> DMDONNOOOJK);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x55E18C0", Offset = "0x55E00C0", VA = "0x1855E18C0", Slot = "7")]
	public bool ALCJEFCIPMP(IDictionary<object, object> DMDONNOOOJK, out T GICLLKCEEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
	protected KGPLAFODKFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class JLIDBHLNGHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate bool BCBPCHMJLPK(int HKJJOENNMGD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool NMANPNFCCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	protected readonly FHANKEDBHBD KAIODKBOJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationToken LAOFPANACHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationToken OFANMEIIHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly BCBPCHMJLPK CLEGHJGBJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly CancellationTokenSource HCGBKCABKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly CancellationTokenSource LDFBGBJLOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly int HEBNBEENHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool HKOGADIOPMN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken KEOOEKDPMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x403D130", Offset = "0x403B930", VA = "0x18403D130")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LOFBOGLHHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x403D030", Offset = "0x403B830", VA = "0x18403D030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x403D260", Offset = "0x403BA60", VA = "0x18403D260")]
	public JLIDBHLNGHJ(FHANKEDBHBD GFGNDDMLFJA, CancellationToken LAOFPANACHA, [Optional] BCBPCHMJLPK CLEGHJGBJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x403D010", Offset = "0x403B810", VA = "0x18403D010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x403D080", Offset = "0x403B880", VA = "0x18403D080", Slot = "5")]
	protected virtual void JHCIFLFKFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x403D150", Offset = "0x403B950", VA = "0x18403D150")]
	private void LMIEMPIOMAG(PAEDDAMNHLM MDFHLJAIIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x403D200", Offset = "0x403BA00", VA = "0x18403D200")]
	protected void PKJOEMIPMFN(int AANFMKCDLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x403D1E0", Offset = "0x403B9E0", VA = "0x18403D1E0", Slot = "6")]
	protected virtual void PFHGKHDGJDO(int AANFMKCDLEJ)
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

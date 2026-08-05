using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.Core;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BPGLFKPKJHF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OKNNKFGFODL IBDOIDOPMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OKNNKFGFODL KBNBPACDJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	OKNNKFGFODL DFJHLLFGFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GNELPILGIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BFBKBMDPDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private delegate List<PlayerLoopSystem> AHJIPNEIGPG(List<PlayerLoopSystem> CADJHOIAPEJ, int JPIJKGBJKCM);

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct NAJBKNCPEBG
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct PKPCBHEDFKK
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static OKNNKFGFODL NGHDMBGBMLG;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x2F10730", Offset = "0x2F0FB30", VA = "0x182F10730")]
				public static PlayerLoopSystem IIKMGODBLFL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct FFGGJJHBKJN
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static OKNNKFGFODL EBCGNHAEELK;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2F055E0", Offset = "0x2F049E0", VA = "0x182F055E0")]
				public static PlayerLoopSystem IIKMGODBLFL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct DGGCMMBKKAH
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static OKNNKFGFODL GJJOOOJIAAL;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x2F040E0", Offset = "0x2F034E0", VA = "0x182F040E0")]
				public static PlayerLoopSystem IIKMGODBLFL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			internal struct FEPFCCDNOPN
			{
				[Cpp2IlInjected.Token(Token = "0x200000D")]
				[CompilerGenerated]
				private sealed class DNCKJNJBGIE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000B")]
					public ELGIGKJCDID.PEEOJJCEFPE key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
					public DNCKJNJBGIE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x2F04280", Offset = "0x2F03680", VA = "0x182F04280")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2F04F00", Offset = "0x2F04300", VA = "0x182F04F00")]
				public static PlayerLoopSystem GBOFDKJOGIA(ELGIGKJCDID.PEEOJJCEFPE DNGKIAJLLHG)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			internal struct DGCLMKPIEMA
			{
				[Cpp2IlInjected.Token(Token = "0x200000F")]
				[CompilerGenerated]
				private sealed class FGHMPJKFPEE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000C")]
					public ELGIGKJCDID.PEEOJJCEFPE key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
					public FGHMPJKFPEE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x2F05780", Offset = "0x2F04B80", VA = "0x182F05780")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2F03FE0", Offset = "0x2F033E0", VA = "0x182F03FE0")]
				public static PlayerLoopSystem GBOFDKJOGIA(ELGIGKJCDID.PEEOJJCEFPE DNGKIAJLLHG)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class MEHOILAECLF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
			public MEHOILAECLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2F0E490", Offset = "0x2F0D890", VA = "0x182F0E490")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool MBCCKJGADLN;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool AHKOFGDIFAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2F03620", Offset = "0x2F02A20", VA = "0x182F03620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2F03280", Offset = "0x2F02680", VA = "0x182F03280")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2F02430", Offset = "0x2F01830", VA = "0x182F02430")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2F032C0", Offset = "0x2F026C0", VA = "0x182F032C0")]
		private static void KHFAOCKFOMG(ELGIGKJCDID.PEEOJJCEFPE DNGKIAJLLHG, ref PlayerLoopSystem INJAGKJAPKC, Type IAFJLDHNNAG, Type MCNLGODIENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2F03660", Offset = "0x2F02A60", VA = "0x182F03660")]
		private static void PIDOJLLLMLO(ref PlayerLoopSystem INJAGKJAPKC, Type IAFJLDHNNAG, Type MCNLGODIENM, AHJIPNEIGPG BNLLHBCJFOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2F03520", Offset = "0x2F02920", VA = "0x182F03520")]
		private static void KKPNOLPGNAJ(ref PlayerLoopSystem INJAGKJAPKC, Type IAFJLDHNNAG, Type MCNLGODIENM, PlayerLoopSystem? IOIGCOBLOPL, PlayerLoopSystem? CBPMAILKJCF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ELGIGKJCDID
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum PEEOJJCEFPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		FullPlayerLoop
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class FDGHJJOBMOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public readonly PEEOJJCEFPE OOAPJCKEHFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Stopwatch HAOJCNCFIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly FIFNHIILPEL CMJEENBAHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long LHCDPFLFNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long NMPEEAEJLBB;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2F04E00", Offset = "0x2F04200", VA = "0x182F04E00")]
		public FDGHJJOBMOD(PEEOJJCEFPE wrapperKey, int bufferSize = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2F04BE0", Offset = "0x2F03FE0", VA = "0x182F04BE0")]
		public void BLFLBLDMBBK(int AAEANOFBLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2F04C00", Offset = "0x2F04000", VA = "0x182F04C00")]
		public void HFJPBHFKHPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2F04BB0", Offset = "0x2F03FB0", VA = "0x182F04BB0")]
		public void BAPLIBPCJLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2F04CC0", Offset = "0x2F040C0", VA = "0x182F04CC0")]
		public void MFBBBPPGENE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int PLKAJGEEBFC = 90;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static PEEOJJCEFPE[] GKEFALOIEHH;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static FDGHJJOBMOD[] FNGELILMAFH;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2F045D0", Offset = "0x2F039D0", VA = "0x182F045D0")]
	public static FDGHJJOBMOD AKFOAKIHIBH(PEEOJJCEFPE DNGKIAJLLHG, int NMIMOBMHDAF = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2F04790", Offset = "0x2F03B90", VA = "0x182F04790")]
	public static FDGHJJOBMOD CCOLPLDBPEN(PEEOJJCEFPE DNGKIAJLLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2F04820", Offset = "0x2F03C20", VA = "0x182F04820")]
	public static void KHCEGBPDENP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DECOBNDCNFA : HOMBMCGGPOD
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class CLKPFIJHGLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public DECOBNDCNFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
		public CLKPFIJHGLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2F01CA0", Offset = "0x2F010A0", VA = "0x182F01CA0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class OGBHHMOKMFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public DECOBNDCNFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
		public OGBHHMOKMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2F01CA0", Offset = "0x2F010A0", VA = "0x182F01CA0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly float IFDHHDIIAAG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2F01C50", Offset = "0x2F01050", VA = "0x182F01C50")]
	public DECOBNDCNFA(Behaviour context, float cooldownSeconds, [Optional] Action defaultAction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2F03B10", Offset = "0x2F02F10", VA = "0x182F03B10", Slot = "9")]
	protected override bool EEJEOHAODHB(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2F03BE0", Offset = "0x2F02FE0", VA = "0x182F03BE0", Slot = "10")]
	protected override bool KLJHDBCCABK(Action JJGHIEJCCDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JFGJBBGINMH
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool MDJNBGPICPC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action OGODIKKKAFA;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PFFOFIHGOEA(bool CDFHDACBFKN = false);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PFFOFIHGOEA(Action JJGHIEJCCDA, bool CDFHDACBFKN = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class HOMBMCGGPOD : JFGJBBGINMH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MHJIDBHBMGM : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
		[DebuggerHidden]
		public MHJIDBHBMGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E590", Offset = "0x2F0D990", VA = "0x182F0E590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E630", Offset = "0x2F0DA30", VA = "0x182F0E630", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Behaviour LHOMKMINCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Action EJAIEDPNOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CDJFFFCFLMF ACGPOGCNMBA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MDJNBGPICPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x59EF10", Offset = "0x59E310", VA = "0x18059EF10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OGODIKKKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2F08240", Offset = "0x2F07640", VA = "0x182F08240", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2F081A0", Offset = "0x2F075A0", VA = "0x182F081A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x13E5080", Offset = "0x13E4480", VA = "0x1813E5080")]
	protected HOMBMCGGPOD(Behaviour context, [Optional] Action defaultAction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2F085C0", Offset = "0x2F079C0", VA = "0x182F085C0", Slot = "7")]
	public bool PFFOFIHGOEA(bool CDFHDACBFKN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2F08620", Offset = "0x2F07A20", VA = "0x182F08620", Slot = "8")]
	public bool PFFOFIHGOEA(Action JJGHIEJCCDA, bool CDFHDACBFKN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool EEJEOHAODHB(Action JJGHIEJCCDA);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool KLJHDBCCABK(Action JJGHIEJCCDA);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2F082E0", Offset = "0x2F076E0", VA = "0x182F082E0")]
	protected void HLOEPMHHGKE(Action JJGHIEJCCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2F083F0", Offset = "0x2F077F0", VA = "0x182F083F0")]
	protected DABKFAIHBBP PAAAGNNFMLG(float BJJEDIGOMGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2F08380", Offset = "0x2F07780", VA = "0x182F08380")]
	private void KDPCHEJAGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2F08300", Offset = "0x2F07700", VA = "0x182F08300")]
	[IteratorStateMachine(typeof(MHJIDBHBMGM))]
	private static IEnumerator<KENFJGFMIPM> HOPCEMPGALM(float BJJEDIGOMGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2F08360", Offset = "0x2F07760", VA = "0x182F08360")]
	[CompilerGenerated]
	private void JJADPNNAEJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PHJNILKEAAI : HOMBMCGGPOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly float KPDOKHHMHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly int OFOIBLJPHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly float DNHGIAAFCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly float[] DOBNOLHKEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int EMMJIDFJNFC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FNPGPAPOHAN MACMLJJGBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x401420", Offset = "0x400820", VA = "0x180401420")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x400F00", Offset = "0x400300", VA = "0x180400F00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2F10620", Offset = "0x2F0FA20", VA = "0x182F10620")]
	public PHJNILKEAAI(Behaviour context, float windowDurationSeconds, int maxInvocations, [Optional] Action defaultAction, float minCooldownSeconds = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3EA7B0", Offset = "0x3E9BB0", VA = "0x1803EA7B0", Slot = "9")]
	protected override bool EEJEOHAODHB(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2F10370", Offset = "0x2F0F770", VA = "0x182F10370", Slot = "10")]
	protected override bool KLJHDBCCABK(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2F10590", Offset = "0x2F0F990", VA = "0x182F10590")]
	private void OACHLILDIHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CKNNCLNMAPG : HOMBMCGGPOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly float IFDHHDIIAAG;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2F01C50", Offset = "0x2F01050", VA = "0x182F01C50")]
	public CKNNCLNMAPG(Behaviour context, float cooldownSeconds, [Optional] Action defaultAction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3EA7B0", Offset = "0x3E9BB0", VA = "0x1803EA7B0", Slot = "9")]
	protected override bool EEJEOHAODHB(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2F01C10", Offset = "0x2F01010", VA = "0x182F01C10", Slot = "10")]
	protected override bool KLJHDBCCABK(Action JJGHIEJCCDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface NGHLNGJDGGH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int AKGEGLEMFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KFBABPAPIMB : CDJFFFCFLMF, DABKFAIHBBP, IEnumerator, KENFJGFMIPM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GHMCDEEFOLC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly GHMCDEEFOLC JMIGKJPPFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly Action NGEMKGIAPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool KGACOELMNLL;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x40D770", Offset = "0x40CB70", VA = "0x18040D770")]
	public GHMCDEEFOLC(Action onDispose)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2F062B0", Offset = "0x2F056B0", VA = "0x182F062B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CKPBHOBEDBH<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	T DMLIOOCLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable JAHAHHAFAPC(Action<T> CCHCBCLCFIM);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable JAHAHHAFAPC(UnityEngine.Object LHOMKMINCHH, Action<T> CCHCBCLCFIM);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MEJBIMNJHII<T> : global::CKPBHOBEDBH<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	new T DMLIOOCLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class KAGJDGDAADK<T> : global::MEJBIMNJHII<T>, global::CKPBHOBEDBH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class GCFGNJEEJPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public global::KAGJDGDAADK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public global::DHKPBIAHMHG<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xF9EDD0", Offset = "0xF9E1D0", VA = "0x180F9EDD0")]
		public GCFGNJEEJPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1DB56D0", Offset = "0x1DB4AD0", VA = "0x181DB56D0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static GameObject IIEPDHALHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<global::DHKPBIAHMHG<UnityEngine.Object, Action<T>>> CENLFEFBECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T PBELLDKBCOE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private static UnityEngine.Object CBMCEODPHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1DC22E0", Offset = "0x1DC16E0", VA = "0x181DC22E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T DMLIOOCLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4006D0", Offset = "0x3FFAD0", VA = "0x1804006D0", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1B40", Offset = "0x1DC0F40", VA = "0x181DC1B40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1DC1C30", Offset = "0x1DC1030", VA = "0x181DC1C30")]
	private static bool LPHFKINGMHN(T IPHIIJNAEON, T FOJLJNMAJLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1DC2740", Offset = "0x1DC1B40", VA = "0x181DC2740")]
	public KAGJDGDAADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1DC2800", Offset = "0x1DC1C00", VA = "0x181DC2800")]
	public KAGJDGDAADK(T initialValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1DC2720", Offset = "0x1DC1B20", VA = "0x181DC2720")]
	public void MOCMFLAMJHA(T BCEFAKDFEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1DC1990", Offset = "0x1DC0D90", VA = "0x181DC1990", Slot = "7")]
	public IDisposable JAHAHHAFAPC(Action<T> CCHCBCLCFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1DC1A00", Offset = "0x1DC0E00", VA = "0x181DC1A00", Slot = "8")]
	public IDisposable JAHAHHAFAPC(UnityEngine.Object LHOMKMINCHH, Action<T> CCHCBCLCFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1DC1FC0", Offset = "0x1DC13C0", VA = "0x181DC1FC0")]
	private void LPKBPIMHHOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class LCNLICMJMPA
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KAAIDJDOPMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public DABKFAIHBBP promise;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
		public KAAIDJDOPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C6D0", Offset = "0x2F0BAD0", VA = "0x182F0C6D0")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class EJFPDNFNJPH : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
		[DebuggerHidden]
		public EJFPDNFNJPH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2F04490", Offset = "0x2F03890", VA = "0x182F04490", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2F04580", Offset = "0x2F03980", VA = "0x182F04580", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly KENFJGFMIPM MEOLIHPOHLL;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly KENFJGFMIPM FPHNJEAGAPM;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly KENFJGFMIPM EMOILKMBCEP;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly KENFJGFMIPM LCLLAMKJJLA;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly KENFJGFMIPM PBJHMFKPMHN;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2F0D940", Offset = "0x2F0CD40", VA = "0x182F0D940")]
	public static KENFJGFMIPM LEIMHFLNIKB(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2F0DA20", Offset = "0x2F0CE20", VA = "0x182F0DA20")]
	public static KENFJGFMIPM LINOLLIBDCO(Func<bool> LKMLNOJIFHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2F0DA80", Offset = "0x2F0CE80", VA = "0x182F0DA80")]
	public static KENFJGFMIPM OPDGBNPLNHG(DABKFAIHBBP NKLGAGCHGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2F0D8F0", Offset = "0x2F0CCF0", VA = "0x182F0D8F0")]
	[IteratorStateMachine(typeof(EJFPDNFNJPH))]
	public static IEnumerator<KENFJGFMIPM> EPAMOHIGFDO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface KENFJGFMIPM
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GAPNCPOLFEI();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class CPHEMJCNNDB : KENFJGFMIPM
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class KBIEPEFBMPJ : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private CPHEMJCNNDB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
		[DebuggerHidden]
		public KBIEPEFBMPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C720", Offset = "0x2F0BB20", VA = "0x182F0C720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C7F0", Offset = "0x2F0BBF0", VA = "0x182F0C7F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class DDPJLKFDDNM : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private CPHEMJCNNDB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
		[DebuggerHidden]
		public DDPJLKFDDNM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2F039D0", Offset = "0x2F02DD0", VA = "0x182F039D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2F03AC0", Offset = "0x2F02EC0", VA = "0x182F03AC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3F72D0", Offset = "0x3F66D0", VA = "0x1803F72D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x46CC50", Offset = "0x46C050", VA = "0x18046CC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6BD980", Offset = "0x6BCD80", VA = "0x1806BD980", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
	public CPHEMJCNNDB(Scheduler.NEIJEKIKDOG queue = Scheduler.NEIJEKIKDOG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x402F60", Offset = "0x402360", VA = "0x180402F60", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2F02040", Offset = "0x2F01440", VA = "0x182F02040")]
	public static KFBABPAPIMB GIEOOLAGCKA(Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2F01F50", Offset = "0x2F01350", VA = "0x182F01F50")]
	public static KFBABPAPIMB GIEOOLAGCKA(Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2F02240", Offset = "0x2F01640", VA = "0x182F02240")]
	public static KFBABPAPIMB GIEOOLAGCKA(Behaviour LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2F02130", Offset = "0x2F01530", VA = "0x182F02130")]
	public static KFBABPAPIMB GIEOOLAGCKA(Behaviour LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2F01E40", Offset = "0x2F01240", VA = "0x182F01E40")]
	public static KFBABPAPIMB DJJOEODIBEE(BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2F01D30", Offset = "0x2F01130", VA = "0x182F01D30")]
	public static KFBABPAPIMB DJJOEODIBEE(BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2F023C0", Offset = "0x2F017C0", VA = "0x182F023C0")]
	[IteratorStateMachine(typeof(KBIEPEFBMPJ))]
	private static IEnumerator<KENFJGFMIPM> OKAOGDPNEKD(Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2F02350", Offset = "0x2F01750", VA = "0x182F02350")]
	[IteratorStateMachine(typeof(DDPJLKFDDNM))]
	private static IEnumerator<KENFJGFMIPM> OKAOGDPNEKD(Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class BECNBPANOEI : KENFJGFMIPM
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NIOKFBABMOC : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private BECNBPANOEI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
		[DebuggerHidden]
		public NIOKFBABMOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E9B0", Offset = "0x2F0DDB0", VA = "0x182F0E9B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2F0EB50", Offset = "0x2F0DF50", VA = "0x182F0EB50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly float IMKDOHNAMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int EECPLAEACEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly float LJINEKMJNJB;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public float MMEAJDPNJHF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4C6C70", Offset = "0x4C6070", VA = "0x1804C6C70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4C69D0", Offset = "0x4C5DD0", VA = "0x1804C69D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x401210", Offset = "0x400610", VA = "0x180401210", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4013F0", Offset = "0x4007F0", VA = "0x1804013F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4ED2F0", Offset = "0x4EC6F0", VA = "0x1804ED2F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4ED300", Offset = "0x4EC700", VA = "0x1804ED300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float FFPPABMIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4ED2E0", Offset = "0x4EC6E0", VA = "0x1804ED2E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4ED330", Offset = "0x4EC730", VA = "0x1804ED330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2F01650", Offset = "0x2F00A50", VA = "0x182F01650")]
	public BECNBPANOEI(float targetRateHz, Scheduler.NEIJEKIKDOG queue = Scheduler.NEIJEKIKDOG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2F012F0", Offset = "0x2F006F0", VA = "0x182F012F0", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2F015C0", Offset = "0x2F009C0", VA = "0x182F015C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2F01310", Offset = "0x2F00710", VA = "0x182F01310")]
	public static KFBABPAPIMB GIEOOLAGCKA(float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2F013C0", Offset = "0x2F007C0", VA = "0x182F013C0")]
	public static KFBABPAPIMB GIEOOLAGCKA(MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2F01480", Offset = "0x2F00880", VA = "0x182F01480")]
	public static KFBABPAPIMB HFKCNODKFKG(BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2F01540", Offset = "0x2F00940", VA = "0x182F01540")]
	[IteratorStateMachine(typeof(NIOKFBABMOC))]
	private static IEnumerator<KENFJGFMIPM> OKAOGDPNEKD(float JCAEDLLGMHA, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ENKGACHBJCJ : KENFJGFMIPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Func<bool> LKMLNOJIFHH;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x40D7A0", Offset = "0x40CBA0", VA = "0x18040D7A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x40D7E0", Offset = "0x40CBE0", VA = "0x18040D7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4C6C70", Offset = "0x4C6070", VA = "0x1804C6C70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4C69D0", Offset = "0x4C5DD0", VA = "0x1804C69D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2F04A30", Offset = "0x2F03E30", VA = "0x182F04A30")]
	public ENKGACHBJCJ(Func<bool> condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2F04A60", Offset = "0x2F03E60", VA = "0x182F04A60")]
	public ENKGACHBJCJ(Scheduler.NEIJEKIKDOG queueType, Func<bool> condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2F049E0", Offset = "0x2F03DE0", VA = "0x182F049E0", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class OCBENJPNGLC
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NONJFBJHGEM : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Scheduler.NEIJEKIKDOG queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
		[DebuggerHidden]
		public NONJFBJHGEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2F0EBA0", Offset = "0x2F0DFA0", VA = "0x182F0EBA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2F0EC40", Offset = "0x2F0E040", VA = "0x182F0EC40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2F0EC90", Offset = "0x2F0E090", VA = "0x182F0EC90")]
	[IteratorStateMachine(typeof(NONJFBJHGEM))]
	private static IEnumerator<KENFJGFMIPM> AGGNPLMDKGE(Scheduler.NEIJEKIKDOG CKFELIAJKCP, Func<bool> LKMLNOJIFHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2F0ED00", Offset = "0x2F0E100", VA = "0x182F0ED00")]
	public static KFBABPAPIMB EGIAAFEOAGP(this MonoBehaviour BKGIHIBDAPA, Func<bool> LKMLNOJIFHH, Scheduler.NEIJEKIKDOG CKFELIAJKCP = Scheduler.NEIJEKIKDOG.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class JMOPCCPBNMB : KENFJGFMIPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly float MKOEJJBMPIN;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x46C940", Offset = "0x46BD40", VA = "0x18046C940", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x491F20", Offset = "0x491320", VA = "0x180491F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4ED340", Offset = "0x4EC740", VA = "0x1804ED340", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4ED310", Offset = "0x4EC710", VA = "0x1804ED310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C620", Offset = "0x2F0BA20", VA = "0x182F0C620")]
	public JMOPCCPBNMB(float seconds, Scheduler.NEIJEKIKDOG queue = Scheduler.NEIJEKIKDOG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C590", Offset = "0x2F0B990", VA = "0x182F0C590", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IPFBKNOHEGB
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class CHFAJCJLJLB : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
		[DebuggerHidden]
		public CHFAJCJLJLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2F01B10", Offset = "0x2F00F10", VA = "0x182F01B10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2F01BC0", Offset = "0x2F00FC0", VA = "0x182F01BC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class EOMJHPHEMLH : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private KENFJGFMIPM <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
		[DebuggerHidden]
		public EOMJHPHEMLH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2F04AA0", Offset = "0x2F03EA0", VA = "0x182F04AA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2F04B60", Offset = "0x2F03F60", VA = "0x182F04B60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2F0BA70", Offset = "0x2F0AE70", VA = "0x182F0BA70")]
	[IteratorStateMachine(typeof(CHFAJCJLJLB))]
	private static IEnumerator<KENFJGFMIPM> HEBGBPGEFPK(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B4F0", Offset = "0x2F0A8F0", VA = "0x182F0B4F0")]
	[IteratorStateMachine(typeof(EOMJHPHEMLH))]
	private static IEnumerator<KENFJGFMIPM> DBNBNAILAFO(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C2C0", Offset = "0x2F0B6C0", VA = "0x182F0C2C0")]
	public static IDisposable PBPKBANPKJP(this MonoBehaviour BKGIHIBDAPA, float HABFNPMBADP, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B6B0", Offset = "0x2F0AAB0", VA = "0x182F0B6B0")]
	public static KFBABPAPIMB ENFHDIBGOEO(this MonoBehaviour BKGIHIBDAPA, float HABFNPMBADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C400", Offset = "0x2F0B800", VA = "0x182F0C400")]
	public static KFBABPAPIMB PBPKBANPKJP(this MonoBehaviour BKGIHIBDAPA, float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B7F0", Offset = "0x2F0ABF0", VA = "0x182F0B7F0")]
	public static KFBABPAPIMB FHKNPABNEEM(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B570", Offset = "0x2F0A970", VA = "0x182F0B570")]
	public static KFBABPAPIMB EGOJDKEBMNH(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2F0BAF0", Offset = "0x2F0AEF0", VA = "0x182F0BAF0")]
	public static KFBABPAPIMB HECMPBHFOEA(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F0BD40", Offset = "0x2F0B140", VA = "0x182F0BD40")]
	public static KFBABPAPIMB JGIPMJPPCBM(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B930", Offset = "0x2F0AD30", VA = "0x182F0B930")]
	public static KFBABPAPIMB GGGCLEIGKCE(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C0A0", Offset = "0x2F0B4A0", VA = "0x182F0C0A0")]
	public static KFBABPAPIMB NLBLFPBOCLD(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C1B0", Offset = "0x2F0B5B0", VA = "0x182F0C1B0")]
	public static KFBABPAPIMB PAKNHKEKDAF(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2F0BC30", Offset = "0x2F0B030", VA = "0x182F0BC30")]
	public static KFBABPAPIMB INLJFAKDKAD(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2F0BF90", Offset = "0x2F0B390", VA = "0x182F0BF90")]
	public static KFBABPAPIMB LBLNPIDACFM(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2F0BE80", Offset = "0x2F0B280", VA = "0x182F0BE80")]
	public static KFBABPAPIMB JOOHIGCAKNF(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class ICMKAJELBGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class ILPPIMNIHBJ : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
		[DebuggerHidden]
		public ILPPIMNIHBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B3F0", Offset = "0x2F0A7F0", VA = "0x182F0B3F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B4A0", Offset = "0x2F0A8A0", VA = "0x182F0B4A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private KFBABPAPIMB KHPFGANHBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private MonoBehaviour BKGIHIBDAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private Action JFKDDPJDCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private Action<float> HBMODGLEAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Scheduler.NEIJEKIKDOG CKFELIAJKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private float FJKINHFIBJA;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B260", Offset = "0x2F0A660", VA = "0x182F0B260")]
	public ICMKAJELBGE(MonoBehaviour behaviour, Action update, Scheduler.NEIJEKIKDOG queueType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2F0AF80", Offset = "0x2F0A380", VA = "0x182F0AF80")]
	public ICMKAJELBGE(MonoBehaviour behaviour, Action<float> update, Scheduler.NEIJEKIKDOG queueType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B110", Offset = "0x2F0A510", VA = "0x182F0B110")]
	public ICMKAJELBGE(MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.NEIJEKIKDOG queueType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2F0ABB0", Offset = "0x2F09FB0", VA = "0x182F0ABB0")]
	private void GIEOOLAGCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2F0A9B0", Offset = "0x2F09DB0", VA = "0x182F0A9B0")]
	private void EBPHAECHJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2F0AD30", Offset = "0x2F0A130", VA = "0x182F0AD30")]
	private void HCMLBCFDNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2F0AE60", Offset = "0x2F0A260", VA = "0x182F0AE60")]
	private void KEECGEIFLEN(string MOPOMPHBHKF, Action HGGDFJNNBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2F0A900", Offset = "0x2F09D00", VA = "0x182F0A900")]
	[IteratorStateMachine(typeof(ILPPIMNIHBJ))]
	private IEnumerator<KENFJGFMIPM> DEJICBOKAJH(Action HGGDFJNNBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2F0A960", Offset = "0x2F09D60", VA = "0x182F0A960", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2F0A880", Offset = "0x2F09C80", VA = "0x182F0A880")]
	[CompilerGenerated]
	private void CKHMLHHHCLN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2F0A800", Offset = "0x2F09C00", VA = "0x182F0A800")]
	[CompilerGenerated]
	private void CBBGHNELPMN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2F0AB30", Offset = "0x2F09F30", VA = "0x182F0AB30")]
	[CompilerGenerated]
	private void GGEOKDFDCNK(string CHKKEHOKPJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class ADIFCODGAML
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2F00C80", Offset = "0x2F00080", VA = "0x182F00C80")]
	public static IDisposable GIEOOLAGCKA(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2F00AC0", Offset = "0x2EFFEC0", VA = "0x182F00AC0")]
	public static IDisposable GIEOOLAGCKA(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2F010F0", Offset = "0x2F004F0", VA = "0x182F010F0")]
	public static IDisposable OPEMIFENIJM(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2F00F80", Offset = "0x2F00380", VA = "0x182F00F80")]
	public static IDisposable MOJAICCOOMH(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2F00FF0", Offset = "0x2F003F0", VA = "0x182F00FF0")]
	public static IDisposable OEMBBKDJFCB(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2F008D0", Offset = "0x2EFFCD0", VA = "0x182F008D0")]
	public static IDisposable FHBCIFNCNMN(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2F00D80", Offset = "0x2F00180", VA = "0x182F00D80")]
	public static IDisposable JEEMKGCKHKD(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2F00DF0", Offset = "0x2F001F0", VA = "0x182F00DF0")]
	public static IDisposable LAHBIDHMCKF(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2F00940", Offset = "0x2EFFD40", VA = "0x182F00940")]
	public static IDisposable FLMKKKHMJBN(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2F00540", Offset = "0x2EFF940", VA = "0x182F00540")]
	public static IDisposable AMNODMIDNHO(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2F00D00", Offset = "0x2F00100", VA = "0x182F00D00")]
	public static IDisposable ICPMHNDIIFK(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2F007C0", Offset = "0x2EFFBC0", VA = "0x182F007C0")]
	public static IDisposable ENLMJBCKILF(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2F00A40", Offset = "0x2EFFE40", VA = "0x182F00A40")]
	public static IDisposable FOFJADGKNJF(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2F00E80", Offset = "0x2F00280", VA = "0x182F00E80")]
	public static IDisposable LFJPCEKGMIA(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2F004C0", Offset = "0x2EFF8C0", VA = "0x182F004C0")]
	public static IDisposable ADIDJGEIJOH(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2F01060", Offset = "0x2F00460", VA = "0x182F01060")]
	public static IDisposable OIJBBPIBIJP(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2F00640", Offset = "0x2EFFA40", VA = "0x182F00640")]
	public static IDisposable AOPHLNHDOKN(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2F006C0", Offset = "0x2EFFAC0", VA = "0x182F006C0")]
	public static IDisposable BOHBPECGHLI(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2F009C0", Offset = "0x2EFFDC0", VA = "0x182F009C0")]
	public static IDisposable FNFEBJPKPEA(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2F00840", Offset = "0x2EFFC40", VA = "0x182F00840")]
	public static IDisposable FGFJPAFFKIN(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2F00740", Offset = "0x2EFFB40", VA = "0x182F00740")]
	public static IDisposable CHFECAOLPEO(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2F00F00", Offset = "0x2F00300", VA = "0x182F00F00")]
	public static IDisposable LGJLMMIHFON(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2F005C0", Offset = "0x2EFF9C0", VA = "0x182F005C0")]
	public static IDisposable AOPEPIBPFMP(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class OLKNGLHPDJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class FNFBHFJCFAI : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
		[DebuggerHidden]
		public FNFBHFJCFAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2F05B60", Offset = "0x2F04F60", VA = "0x182F05B60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2F05C10", Offset = "0x2F05010", VA = "0x182F05C10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private KFBABPAPIMB KHPFGANHBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private BPGLFKPKJHF LHOMKMINCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private Action JFKDDPJDCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private Action<float> HBMODGLEAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Scheduler.NEIJEKIKDOG CKFELIAJKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private float FJKINHFIBJA;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2F0FE90", Offset = "0x2F0F290", VA = "0x182F0FE90")]
	public OLKNGLHPDJE(BPGLFKPKJHF context, Action update, Scheduler.NEIJEKIKDOG queueType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2F10170", Offset = "0x2F0F570", VA = "0x182F10170")]
	public OLKNGLHPDJE(BPGLFKPKJHF context, Action<float> update, Scheduler.NEIJEKIKDOG queueType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2F10020", Offset = "0x2F0F420", VA = "0x182F10020")]
	public OLKNGLHPDJE(BPGLFKPKJHF context, float hz, Action<float> update, Scheduler.NEIJEKIKDOG queueType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2F0FAC0", Offset = "0x2F0EEC0", VA = "0x182F0FAC0")]
	private void GIEOOLAGCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F8C0", Offset = "0x2F0ECC0", VA = "0x182F0F8C0")]
	private void EBPHAECHJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2F0FC40", Offset = "0x2F0F040", VA = "0x182F0FC40")]
	private void HCMLBCFDNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2F0FD70", Offset = "0x2F0F170", VA = "0x182F0FD70")]
	private void KEECGEIFLEN(string MOPOMPHBHKF, Action HGGDFJNNBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F810", Offset = "0x2F0EC10", VA = "0x182F0F810")]
	[IteratorStateMachine(typeof(FNFBHFJCFAI))]
	private IEnumerator<KENFJGFMIPM> DEJICBOKAJH(Action HGGDFJNNBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F870", Offset = "0x2F0EC70", VA = "0x182F0F870", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F790", Offset = "0x2F0EB90", VA = "0x182F0F790")]
	[CompilerGenerated]
	private void CKHMLHHHCLN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F710", Offset = "0x2F0EB10", VA = "0x182F0F710")]
	[CompilerGenerated]
	private void CBBGHNELPMN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2F0FA40", Offset = "0x2F0EE40", VA = "0x182F0FA40")]
	[CompilerGenerated]
	private void GGEOKDFDCNK(string CHKKEHOKPJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KCBPNKMEDPI
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2F0CC80", Offset = "0x2F0C080", VA = "0x182F0CC80")]
	public static IDisposable DJJOEODIBEE(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2F0CAC0", Offset = "0x2F0BEC0", VA = "0x182F0CAC0")]
	public static IDisposable DJJOEODIBEE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2F0CD00", Offset = "0x2F0C100", VA = "0x182F0CD00")]
	public static IDisposable EMGJKCCEAJA(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2F0CE70", Offset = "0x2F0C270", VA = "0x182F0CE70")]
	public static IDisposable GJCJNLFFLKP(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2F0CE00", Offset = "0x2F0C200", VA = "0x182F0CE00")]
	public static IDisposable GAPIDOHIBLG(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C960", Offset = "0x2F0BD60", VA = "0x182F0C960")]
	public static IDisposable CAJKNLABPBH(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2F0CA50", Offset = "0x2F0BE50", VA = "0x182F0CA50")]
	public static IDisposable DGFNIKAEGMI(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2F0CD70", Offset = "0x2F0C170", VA = "0x182F0CD70")]
	public static IDisposable EOGNMLDAMCK(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2F0D2E0", Offset = "0x2F0C6E0", VA = "0x182F0D2E0")]
	public static IDisposable PBDKGIJCPCG(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2F0D0E0", Offset = "0x2F0C4E0", VA = "0x182F0D0E0")]
	public static IDisposable MHPNCCEFCID(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2F0CEE0", Offset = "0x2F0C2E0", VA = "0x182F0CEE0")]
	public static IDisposable HNFGDIHEFIO(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2F0D260", Offset = "0x2F0C660", VA = "0x182F0D260")]
	public static IDisposable ONEBONJNMNK(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C8D0", Offset = "0x2F0BCD0", VA = "0x182F0C8D0")]
	public static IDisposable BNJMDNLEDJB(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2F0CF60", Offset = "0x2F0C360", VA = "0x182F0CF60")]
	public static IDisposable IPPHMOEKHMO(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2F0D160", Offset = "0x2F0C560", VA = "0x182F0D160")]
	public static IDisposable NIIGGNNJAGE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2F0D1E0", Offset = "0x2F0C5E0", VA = "0x182F0D1E0")]
	public static IDisposable OBEEJIAEFKM(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C840", Offset = "0x2F0BC40", VA = "0x182F0C840")]
	public static IDisposable AGEPHCFGCMM(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C9D0", Offset = "0x2F0BDD0", VA = "0x182F0C9D0")]
	public static IDisposable CEILCDDBJHP(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2F0D060", Offset = "0x2F0C460", VA = "0x182F0D060")]
	public static IDisposable LJOHGJJMOGE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2F0CFE0", Offset = "0x2F0C3E0", VA = "0x182F0CFE0")]
	public static IDisposable KPDELENMDOE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class Scheduler : SingletonMonoBehaviour<Scheduler>
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private class BMOEEDOECDC : NGHLNGJDGGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public IALKDLLHDII ALLFDCFPHGM;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public int AKGEGLEMFGM
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0x3F72D0", Offset = "0x3F66D0", VA = "0x1803F72D0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0x46CC50", Offset = "0x46C050", VA = "0x18046CC50")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x2F019B0", Offset = "0x2F00DB0", VA = "0x182F019B0")]
			public static KENFJGFMIPM NEPONCICACF(IEnumerator<KENFJGFMIPM> LOIIKGFHHAA, OMNCINDCAAJ NKLGAGCHGPM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x2F018E0", Offset = "0x2F00CE0", VA = "0x182F018E0")]
			public KENFJGFMIPM NEPONCICACF(OMNCINDCAAJ[] LMOONNDFEPE, IEnumerator<KENFJGFMIPM>[] JNMOEFOGKLE, KENFJGFMIPM[] DHGHPJHPPGE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x2F018B0", Offset = "0x2F00CB0", VA = "0x182F018B0")]
			public void HNDCKFDJEKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x2F017F0", Offset = "0x2F00BF0", VA = "0x182F017F0")]
			public void CMDNNKIMLED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x2F01730", Offset = "0x2F00B30", VA = "0x182F01730")]
			public void AKIBJAOAEFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x2F018B0", Offset = "0x2F00CB0", VA = "0x182F018B0")]
			public void KBPKIDJEOFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
			public BMOEEDOECDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private sealed class IALKDLLHDII
		{
			[Cpp2IlInjected.Token(Token = "0x200003F")]
			public struct CFBMJLPBODF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public BMOEEDOECDC EOPDHGPFPNC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public BPGLFKPKJHF ADDDHPLGIKL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public OMNCINDCAAJ BAINEAGHDEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public IEnumerator<KENFJGFMIPM> HCIEHECEDAK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public KENFJGFMIPM JIGIMNNJHGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public KINIDGHKMLM HDECHJHCMDD;
			}

			[Cpp2IlInjected.Token(Token = "0x2000040")]
			public struct GIDICDINLFI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public NEIJEKIKDOG JDIEDFKCIGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public List<CFBMJLPBODF> BKPFCJJFMDB;
			}

			[Cpp2IlInjected.Token(Token = "0x2000041")]
			[CompilerGenerated]
			private sealed class GHLCIHPNOIJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				public BPGLFKPKJHF context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public BMOEEDOECDC routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public KINIDGHKMLM coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public OMNCINDCAAJ promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public KENFJGFMIPM currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public IEnumerator<KENFJGFMIPM> coroutine;

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
				public GHLCIHPNOIJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x2F05C60", Offset = "0x2F05060", VA = "0x182F05C60")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000042")]
			[CompilerGenerated]
			private sealed class JKHIMOPAHLJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public BMOEEDOECDC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
				public JKHIMOPAHLJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x2F0C550", Offset = "0x2F0B950", VA = "0x182F0C550")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class OEJBHOJOLNM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public BMOEEDOECDC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
				public OEJBHOJOLNM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x2F0F6D0", Offset = "0x2F0EAD0", VA = "0x182F0F6D0")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000044")]
			[CompilerGenerated]
			private sealed class MLOIAKOIDDA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public BMOEEDOECDC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
				public MLOIAKOIDDA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0x2F0E780", Offset = "0x2F0DB80", VA = "0x182F0E780")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private readonly NEIJEKIKDOG CKFELIAJKCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private bool[] OHHCKBGGNCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			private NativeArray<KINIDGHKMLM> NGPEDHJDGOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private NativeArray<float> EGPCFKONLDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private NativeArray<int> DIPODGDEDFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private NativeArray<int> ADMMJMECAAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private NativeArray<int> GDENALHIFED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private NativeArray<int> MFFNBPCJDPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private NativeArray<int> LKNDAPBEAHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private BMOEEDOECDC[] EICHIBKNPKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private OMNCINDCAAJ[] LMOONNDFEPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private BPGLFKPKJHF[] AMEFOJLMGID;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private IEnumerator<KENFJGFMIPM>[] JELOAPNCLNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private KENFJGFMIPM[] LDGCCHBDADH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private int IMLAJMIFNPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private int NPKCAEOBEMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private readonly int AEIDKODLGJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private float PPDFBDENFBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private LCKMBKBNBGC OIHBJFCDCOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private JobHandle LMMAIKCFIFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private List<BMOEEDOECDC> DNBEKFHBBOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private bool HABDMPHMEHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private List<Action> KCFLKGHJGIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private List<Action> GAKKPKFANJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private bool AFDHMMIPEIP;

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public GIDICDINLFI[] OAPPOHBJCJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x3F3E40", Offset = "0x3F3240", VA = "0x1803F3E40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public int JJEKKMDIBGI
			{
				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x79D780", Offset = "0x79CB80", VA = "0x18079D780")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x2F0A300", Offset = "0x2F09700", VA = "0x182F0A300")]
			private static int PGPLCLADMOP(NEIJEKIKDOG CKFELIAJKCP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x2F0A330", Offset = "0x2F09730", VA = "0x182F0A330")]
			public IALKDLLHDII(NEIJEKIKDOG queueType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x2F09CF0", Offset = "0x2F090F0", VA = "0x182F09CF0")]
			private void MLAFOKLGIMD(ref int GMJLJINPLLP, int DGKFKECDFGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x2F0A120", Offset = "0x2F09520", VA = "0x182F0A120")]
			public void NPNEHCHIMCM(BPGLFKPKJHF LHOMKMINCHH, KENFJGFMIPM BPGGCEOBFBK, IEnumerator<KENFJGFMIPM> LOIIKGFHHAA, OMNCINDCAAJ NKLGAGCHGPM, [Optional] BMOEEDOECDC NEPMGGPMFOH, KINIDGHKMLM IJBJBPDEKKL = KINIDGHKMLM.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x2F09020", Offset = "0x2F08420", VA = "0x182F09020")]
			public void FLJBJJLIFHM(IEnumerable<CFBMJLPBODF> DMDLKMFKKCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x2F09290", Offset = "0x2F08690", VA = "0x182F09290")]
			private CFBMJLPBODF JAAGBELBKHG(int JGECCDNFAID)
			{
				return default(CFBMJLPBODF);
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x2F08CF0", Offset = "0x2F080F0", VA = "0x182F08CF0")]
			private void FKNNONKOPDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xDDE3C0", Offset = "0xDDD7C0", VA = "0x180DDE3C0")]
			private static void NBHOFBPCJGK<T>(int JGECCDNFAID, T[] IMMIMNIHIEF, int OJJOHDIFMEG, [Optional] T ADHBGHBGDNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xDDE3A0", Offset = "0xDDD7A0", VA = "0x180DDE3A0")]
			private static void NBHOFBPCJGK<T>(int JGECCDNFAID, NativeArray<T> IMMIMNIHIEF, int OJJOHDIFMEG, [Optional] T ADHBGHBGDNC) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x2F089D0", Offset = "0x2F07DD0", VA = "0x182F089D0")]
			private void DIOBAOCAAEI(IEnumerable<CFBMJLPBODF> DMDLKMFKKCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x2F08670", Offset = "0x2F07A70", VA = "0x182F08670")]
			private void BANFNKBEACN(CFBMJLPBODF IHJKAJBJMJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x2F09E80", Offset = "0x2F09280", VA = "0x182F09E80")]
			private FLILCHFLFHI NDHIAFIAEDC(int AHKGGOPCBNK)
			{
				return default(FLILCHFLFHI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x2F087E0", Offset = "0x2F07BE0", VA = "0x182F087E0")]
			public void CMBODEFCFGB(float KGOBMDNKIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x2F09210", Offset = "0x2F08610", VA = "0x182F09210")]
			private void GBONAELFCHI(Action IPHIIJNAEON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2F08C70", Offset = "0x2F08070", VA = "0x182F08C70")]
			private void EAOBOPNPOJE(Action IPHIIJNAEON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x2F096C0", Offset = "0x2F08AC0", VA = "0x182F096C0")]
			public void JGHOHJNCKDH(float KGOBMDNKIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2F09C10", Offset = "0x2F09010", VA = "0x182F09C10")]
			public void MDDAPCCABNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x2F09B60", Offset = "0x2F08F60", VA = "0x182F09B60")]
			public void KBPKIDJEOFB(BMOEEDOECDC KECNNGMBHAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x2F0A250", Offset = "0x2F09650", VA = "0x182F0A250")]
			public void OEJCNOAPCAB(BMOEEDOECDC KECNNGMBHAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x2F08730", Offset = "0x2F07B30", VA = "0x182F08730")]
			public void CIFEAJMAHKI(BMOEEDOECDC KECNNGMBHAK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[BurstCompile]
		public struct LCKMBKBNBGC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public float MKLCOIBIHEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			[ReadOnly]
			public int KGOGPFCJPPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private NativeArray<int> ELFLBECKFEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private NativeArray<int> AKANBKMACGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private NativeArray<int> JBONOFAJNCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			[ReadOnly]
			public NativeArray<KINIDGHKMLM> GJHKCAEJCKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			[ReadOnly]
			public NativeArray<float> EDDPIGKJOHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			[WriteOnly]
			public NativeArray<int> GDENALHIFED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			[WriteOnly]
			public NativeArray<int> DIPODGDEDFB;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x2F0D7B0", Offset = "0x2F0CBB0", VA = "0x182F0D7B0")]
			public static LCKMBKBNBGC NFHADFCEMML(int GONGHDLCGPO, float KGOBMDNKIDJ, NativeArray<KINIDGHKMLM> FKIFNJGLFDF, NativeArray<float> ADCCOCDJMNM, NativeArray<int> EIHKHJBKKPC, NativeArray<int> HEDEJBEKJPH, NativeArray<int> HFOAFEDLEJG, NativeArray<int> AKANBKMACGE, NativeArray<int> JBONOFAJNCL)
			{
				return default(LCKMBKBNBGC);
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x2F0D390", Offset = "0x2F0C790", VA = "0x182F0D390", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x2F0D540", Offset = "0x2F0C940", VA = "0x182F0D540")]
			private bool KHFEFLOCLII(int EFBDCIJMFGD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x2F0D360", Offset = "0x2F0C760", VA = "0x182F0D360")]
			private void CDLEKIKHHCD(NativeArray<int> FJLGONNPKCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x2F0D880", Offset = "0x2F0CC80", VA = "0x182F0D880")]
			private int OEIAGHKPDBB(int ILJJFCIEOOJ, int MMJPCDPKKJE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x2F0D470", Offset = "0x2F0C870", VA = "0x182F0D470")]
			private void JIHBNKEBJDH(NativeArray<int> FJLGONNPKCB, int DLECGJMGFNI, int PBAOMKNFBFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x2F0D580", Offset = "0x2F0C980", VA = "0x182F0D580")]
			private void MNMAEDHAEFJ(NativeArray<int> FJLGONNPKCB, int JNOJAJGDFLF, int AKCJAFLPOKA, int IMMAKAPBGIK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class GMHCEMDMGBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private readonly OMNCINDCAAJ NKLGAGCHGPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private readonly Behaviour LHOMKMINCHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private readonly bool LPCBEEBALNO;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public IEnumerator<KENFJGFMIPM> HCIEHECEDAK
			{
				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x400970", Offset = "0x3FFD70", VA = "0x180400970")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0x3DE0C0", Offset = "0x3DD4C0", VA = "0x1803DE0C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public KENFJGFMIPM JIGIMNNJHGD
			{
				[Cpp2IlInjected.Token(Token = "0x600017D")]
				[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x3FFE70", Offset = "0x3FF270", VA = "0x1803FFE70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool OBADDMFNOMJ
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x2F063A0", Offset = "0x2F057A0", VA = "0x182F063A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public bool JDKJCDNCDAN
			{
				[Cpp2IlInjected.Token(Token = "0x6000180")]
				[Cpp2IlInjected.Address(RVA = "0x5712E0", Offset = "0x5706E0", VA = "0x1805712E0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x79F0C0", Offset = "0x79E4C0", VA = "0x18079F0C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public string FIKEBGGCDFN
			{
				[Cpp2IlInjected.Token(Token = "0x6000182")]
				[Cpp2IlInjected.Address(RVA = "0x4013B0", Offset = "0x4007B0", VA = "0x1804013B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0x4013A0", Offset = "0x4007A0", VA = "0x1804013A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public float LKOAKFDABJP
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0x522260", Offset = "0x521660", VA = "0x180522260")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000185")]
				[Cpp2IlInjected.Address(RVA = "0x522070", Offset = "0x521470", VA = "0x180522070")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x2F067F0", Offset = "0x2F05BF0", VA = "0x182F067F0")]
			public GMHCEMDMGBA(IEnumerator<KENFJGFMIPM> coroutine, Behaviour context, OMNCINDCAAJ promise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x2F06550", Offset = "0x2F05950", VA = "0x182F06550")]
			public KENFJGFMIPM NEPONCICACF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x2F06430", Offset = "0x2F05830", VA = "0x182F06430")]
			public bool GBOOCLEMCKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x2F064C0", Offset = "0x2F058C0", VA = "0x182F064C0")]
			public void KBPKIDJEOFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x2F06760", Offset = "0x2F05B60", VA = "0x182F06760", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x144AE20", Offset = "0x144A220", VA = "0x18144AE20")]
			[CompilerGenerated]
			private void NNFOONHOMIF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class OMNCINDCAAJ : HHKIEEPFDOH, KFBABPAPIMB, CDJFFFCFLMF, DABKFAIHBBP, IEnumerator, KENFJGFMIPM, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private NEIJEKIKDOG FIDOMBIKHPP;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			private NEIJEKIKDOG IIPMBGHMKNO
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x469BD0", Offset = "0x468FD0", VA = "0x180469BD0", Slot = "24")]
				get
				{
					return default(NEIJEKIKDOG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public NEIJEKIKDOG ALLFDCFPHGM
			{
				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0x469BD0", Offset = "0x468FD0", VA = "0x180469BD0")]
				get
				{
					return default(NEIJEKIKDOG);
				}
				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0x4C3950", Offset = "0x4C2D50", VA = "0x1804C3950")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			private float IIEAAEDICEG
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x6BD980", Offset = "0x6BCD80", VA = "0x1806BD980", Slot = "26")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x41C9F0", Offset = "0x41BDF0", VA = "0x18041C9F0", Slot = "25")]
			private bool EEOJLONCPBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x2F10300", Offset = "0x2F0F700", VA = "0x182F10300", Slot = "27")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x2F10310", Offset = "0x2F0F710", VA = "0x182F10310")]
			public OMNCINDCAAJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private enum FLILCHFLFHI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private sealed class GOPOCOOMEIM : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public enum MJKJJAEINKK
			{
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public struct OFOGOHPAFPJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				public NEIJEKIKDOG JDIEDFKCIGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public MJKJJAEINKK BAPFEDOOIFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public List<GMHCEMDMGBA> OECIFDDKEAP;
			}

			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private static readonly MJKJJAEINKK[] GLLEJMPCGJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private readonly NEIJEKIKDOG CKFELIAJKCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private bool JLDJMFNCDPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private readonly GMHCEMDMGBA[] GGEMDOAPACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			private readonly List<GMHCEMDMGBA> PJKLFGMDJLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			private readonly Stack<int> KIMBMABLPNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private readonly List<GMHCEMDMGBA> EADBGNKMBEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private readonly Stack<int> BCKLDDFGIID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private bool AFDHMMIPEIP;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public OFOGOHPAFPJ[,] KENMKBOBOCM
			{
				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x401E00", Offset = "0x401200", VA = "0x180401E00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public int JJEKKMDIBGI
			{
				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x2F07500", Offset = "0x2F06900", VA = "0x182F07500")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x2F07DC0", Offset = "0x2F071C0", VA = "0x182F07DC0")]
			public GOPOCOOMEIM(NEIJEKIKDOG queue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x2F07B10", Offset = "0x2F06F10", VA = "0x182F07B10")]
			public void OFMOGILADOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x2F074F0", Offset = "0x2F068F0", VA = "0x182F074F0")]
			public void HCJANGOBPPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x2F07BD0", Offset = "0x2F06FD0", VA = "0x182F07BD0")]
			private void PFMMBGGICPG(IReadOnlyList<GMHCEMDMGBA> CNNICEPGNGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x2F07A10", Offset = "0x2F06E10", VA = "0x182F07A10")]
			public void ODPKGCAACLJ(GMHCEMDMGBA LOIIKGFHHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x2F07670", Offset = "0x2F06A70", VA = "0x182F07670")]
			public void NJJBDIOAJKH(IList<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x2F07270", Offset = "0x2F06670", VA = "0x182F07270")]
			public void GMBMMGDJFKG(IList<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x2F07000", Offset = "0x2F06400", VA = "0x182F07000")]
			private void EPACAPMNOOB(GMHCEMDMGBA LOIIKGFHHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x2F06B70", Offset = "0x2F05F70", VA = "0x182F06B70")]
			private void BBDFMCDKAKM(IList<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x2F070F0", Offset = "0x2F064F0", VA = "0x182F070F0")]
			private FLILCHFLFHI FODCOGKACKB(GMHCEMDMGBA LOIIKGFHHAA)
			{
				return default(FLILCHFLFHI);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x2F07B20", Offset = "0x2F06F20", VA = "0x182F07B20")]
			public void OPEMIFENIJM(float KGOBMDNKIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x2F06970", Offset = "0x2F05D70", VA = "0x182F06970")]
			public void AAACLIOCAPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x2F06E20", Offset = "0x2F06220", VA = "0x182F06E20")]
			private void EMNPEAHLJHM(List<GMHCEMDMGBA> JNMOEFOGKLE, Stack<int> HEEKJOEHAOC, bool FIOKCLNDGIF, float KENDNPDMLOG = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x2F06CE0", Offset = "0x2F060E0", VA = "0x182F06CE0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x2F078F0", Offset = "0x2F06CF0", VA = "0x182F078F0")]
			private void OAGLBBEDKAL(List<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public enum NEIJEKIKDOG
		{
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			PostUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			RigidbodyExLateUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			PreRender,
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			EndOfFrame
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[Flags]
		public enum KINIDGHKMLM : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			Inactive = 0,
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			Running = 1,
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			Cancelled = 2,
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			Paused = 4
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class FKNPEGFNDBO : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
			[DebuggerHidden]
			public FKNPEGFNDBO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x2F05A90", Offset = "0x2F04E90", VA = "0x182F05A90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2F05B10", Offset = "0x2F04F10", VA = "0x182F05B10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private const KINIDGHKMLM BNMLAFJDKKO = KINIDGHKMLM.Cancelled | KINIDGHKMLM.Paused;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static readonly NEIJEKIKDOG[] JFNODFEODBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private GOPOCOOMEIM[] EFAKFPBPKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private IALKDLLHDII[] CMLNDHMENGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private Coroutine JFLDNFIOIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private WaitForEndOfFrame DIJAOOECJCE;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public FNPGPAPOHAN MACMLJJGBIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x3FFE70", Offset = "0x3FF270", VA = "0x1803FFE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int JJEKKMDIBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x2F12330", Offset = "0x2F11730", VA = "0x182F12330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2F11240", Offset = "0x2F10640", VA = "0x182F11240")]
		public static KFBABPAPIMB GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2F10AC0", Offset = "0x2F0FEC0", VA = "0x182F10AC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2F11420", Offset = "0x2F10820", VA = "0x182F11420", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2F10F50", Offset = "0x2F10350", VA = "0x182F10F50")]
		private GOPOCOOMEIM BMEHNIHAJHK(NEIJEKIKDOG GEDCEIDOKJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2032ED0", Offset = "0x20322D0", VA = "0x182032ED0")]
		private IALKDLLHDII FLPNLDJDNNM(NEIJEKIKDOG GEDCEIDOKJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2F118B0", Offset = "0x2F10CB0", VA = "0x182F118B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2F11880", Offset = "0x2F10C80", VA = "0x182F11880")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2F12130", Offset = "0x2F11530", VA = "0x182F12130")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2F11410", Offset = "0x2F10810", VA = "0x182F11410")]
		private void NGHDMBGBMLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2F11210", Offset = "0x2F10610", VA = "0x182F11210")]
		private void EBCGNHAEELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2F11220", Offset = "0x2F10620", VA = "0x182F11220")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x2F112E0", Offset = "0x2F106E0", VA = "0x182F112E0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2F11230", Offset = "0x2F10630", VA = "0x182F11230")]
		private void GJJOOOJIAAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2F10F90", Offset = "0x2F10390", VA = "0x182F10F90")]
		[IteratorStateMachine(typeof(FKNPEGFNDBO))]
		private IEnumerator CHAAKFJCLIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2F11A50", Offset = "0x2F10E50", VA = "0x182F11A50")]
		public KFBABPAPIMB Run(IEnumerator<KENFJGFMIPM> GAHCJOMJGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2F11A60", Offset = "0x2F10E60", VA = "0x182F11A60")]
		public KFBABPAPIMB Run(Behaviour LHOMKMINCHH, IEnumerator<KENFJGFMIPM> GAHCJOMJGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2F11920", Offset = "0x2F10D20", VA = "0x182F11920")]
		public KFBABPAPIMB RunJobbed(BPGLFKPKJHF LHOMKMINCHH, IEnumerator<KENFJGFMIPM> GAHCJOMJGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2F111B0", Offset = "0x2F105B0", VA = "0x182F111B0")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2F11D80", Offset = "0x2F11180", VA = "0x182F11D80")]
		public void UpdateQueue(NEIJEKIKDOG DKGFKIKFBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2F10FF0", Offset = "0x2F103F0", VA = "0x182F10FF0")]
		private void CLODBMLECIA(GOPOCOOMEIM KAMCDGAHIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2F112F0", Offset = "0x2F106F0", VA = "0x182F112F0")]
		private void MNKNBBMICOI(IALKDLLHDII KAMCDGAHIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2F122B0", Offset = "0x2F116B0", VA = "0x182F122B0")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface FNPGPAPOHAN
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float EDNCMGJJLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float FFPPABMIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float PIBBOFCHMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	int JHNNFDHLJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	double NCBJKCHIKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class CNCOALCNHBC : FNPGPAPOHAN
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public float EDNCMGJJLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2F01D10", Offset = "0x2F01110", VA = "0x182F01D10", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float FFPPABMIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2F01D00", Offset = "0x2F01100", VA = "0x182F01D00", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float PIBBOFCHMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2F01D20", Offset = "0x2F01120", VA = "0x182F01D20", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int JHNNFDHLJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2F01CF0", Offset = "0x2F010F0", VA = "0x182F01CF0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public double NCBJKCHIKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2F01CD0", Offset = "0x2F010D0", VA = "0x182F01CD0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
	public CNCOALCNHBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class FIFNHIILPEL : HAPBACHHIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public int BIOFILJOKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Queue<double> PHEJDGHGEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private double FFOJBDNKMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private double PMCAKBEJBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private double OFDBBHKOJKI;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int LINEHPICCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2F059C0", Offset = "0x2F04DC0", VA = "0x182F059C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public double OOPCGBFJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2F058F0", Offset = "0x2F04CF0", VA = "0x182F058F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public double GMBEJJBNGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xF55F40", Offset = "0xF55340", VA = "0x180F55F40", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public double JIODMOCKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x254E960", Offset = "0x254DD60", VA = "0x18254E960", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2F05A00", Offset = "0x2F04E00", VA = "0x182F05A00")]
	public FIFNHIILPEL(int maxBufferLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2F057F0", Offset = "0x2F04BF0", VA = "0x182F057F0", Slot = "4")]
	public void EHGIOHLBHJN(double MBJCIBHEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2F05950", Offset = "0x2F04D50", VA = "0x182F05950", Slot = "5")]
	public void JBBLIBHHEBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class ABHKLOENLLE : HAPBACHHIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private long MNIJHBJDPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double ILPMEPPIJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private double OMGFKNCEEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private double BHEKBIIIJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private double BEJJCLLNDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private double FFOJBDNKMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private double PMCAKBEJBFN;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public long MEPGPGKFENE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x400970", Offset = "0x3FFD70", VA = "0x180400970")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public double GMBEJJBNGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1EBB8F0", Offset = "0x1EBACF0", VA = "0x181EBB8F0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public double JIODMOCKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x254E9D0", Offset = "0x254DDD0", VA = "0x18254E9D0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public double GGEADKGMGDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x254E960", Offset = "0x254DD60", VA = "0x18254E960")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public double JDPBPFKMGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B182F0", Offset = "0x2B176F0", VA = "0x182B182F0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public double OOPCGBFJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x254E890", Offset = "0x254DC90", VA = "0x18254E890", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2F00330", Offset = "0x2EFF730", VA = "0x182F00330", Slot = "4")]
	public void EHGIOHLBHJN(double MBJCIBHEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2F00450", Offset = "0x2EFF850", VA = "0x182F00450", Slot = "5")]
	public void JBBLIBHHEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2F00490", Offset = "0x2EFF890", VA = "0x182F00490")]
	public ABHKLOENLLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface HAPBACHHIBN
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	double OOPCGBFJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	double GMBEJJBNGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	double JIODMOCKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHGIOHLBHJN(double MBJCIBHEOMM);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBBLIBHHEBC();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class LJLGDKLOFMO
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private interface OJCONDGBEIA
	{
		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool MMICKFMMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OOOIENHGNCA();

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KBPKIDJEOFB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private abstract class JDIOECLPOPK<TPromise, TMainThreadPromise> : OJCONDGBEIA where TPromise : DABKFAIHBBP where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly TPromise GMLHFPFHBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		protected readonly TMainThreadPromise IDAPKKELNMM;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public TPromise DENADOGFMKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x231B560", Offset = "0x231A960", VA = "0x18231B560")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool MMICKFMMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x231B510", Offset = "0x231A910", VA = "0x18231B510", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x14B0100", Offset = "0x14AF500", VA = "0x1814B0100")]
		protected JDIOECLPOPK(TPromise backgroundPromise, TMainThreadPromise mainThreadInternalPromise)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x231B5C0", Offset = "0x231A9C0", VA = "0x18231B5C0", Slot = "5")]
		public void OOOIENHGNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x16FE530", Offset = "0x16FD930", VA = "0x1816FE530", Slot = "6")]
		public void KBPKIDJEOFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void AMPLEOCGJBM(TPromise GMLHFPFHBJD);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void GHCAGDCCIPD();
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class BCAIFPDOAMM<T> : JDIOECLPOPK<global::PMGCJEPKFOF<T>, global::CBLLFJEDOII<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2318350", Offset = "0x2317750", VA = "0x182318350")]
		public BCAIFPDOAMM(global::PMGCJEPKFOF<T> backgroundPromise)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2317EE0", Offset = "0x23172E0", VA = "0x182317EE0", Slot = "7")]
		protected override void AMPLEOCGJBM(global::PMGCJEPKFOF<T> GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x23182B0", Offset = "0x23176B0", VA = "0x1823182B0", Slot = "8")]
		protected override void GHCAGDCCIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2318310", Offset = "0x2317710", VA = "0x182318310")]
		[CompilerGenerated]
		private void NIJANLDDIMP(T GIAOBLMEMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2318220", Offset = "0x2317620", VA = "0x182318220")]
		[CompilerGenerated]
		private void FGCPLDIEGKO(string MOPOMPHBHKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class EHEDHJDLBCH : JDIOECLPOPK<DABKFAIHBBP, JJEKJGALHKO>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2F04420", Offset = "0x2F03820", VA = "0x182F04420")]
		public EHEDHJDLBCH(DABKFAIHBBP backgroundPromise)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2F04300", Offset = "0x2F03700", VA = "0x182F04300", Slot = "7")]
		protected override void AMPLEOCGJBM(DABKFAIHBBP GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2F043D0", Offset = "0x2F037D0", VA = "0x182F043D0", Slot = "8")]
		protected override void GHCAGDCCIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED2300", VA = "0x180ED2F00")]
		[CompilerGenerated]
		private void NIJANLDDIMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xBD5E50", Offset = "0xBD5250", VA = "0x180BD5E50")]
		[CompilerGenerated]
		private void FGCPLDIEGKO(string MOPOMPHBHKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class HLPAFHONKPA : OJCONDGBEIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly Action JJGHIEJCCDA;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool MMICKFMMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x402F60", Offset = "0x402360", VA = "0x180402F60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x40D770", Offset = "0x40CB70", VA = "0x18040D770")]
		public HLPAFHONKPA(Action action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xE3C7C0", Offset = "0xE3BBC0", VA = "0x180E3C7C0", Slot = "5")]
		public void OOOIENHGNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "6")]
		public void KBPKIDJEOFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly List<OJCONDGBEIA> GEONEIIGPNH;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1340", Offset = "0x1CE0740", VA = "0x181CE1340")]
	public static global::PMGCJEPKFOF<T> DNMKIEAJOJH<T>(global::PMGCJEPKFOF<T> GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2F0DFF0", Offset = "0x2F0D3F0", VA = "0x182F0DFF0")]
	public static DABKFAIHBBP DNMKIEAJOJH(DABKFAIHBBP GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2F0DF70", Offset = "0x2F0D370", VA = "0x182F0DF70")]
	public static void DNMKIEAJOJH(Action JJGHIEJCCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E250", Offset = "0x2F0D650", VA = "0x182F0E250")]
	private static void IIGMDIHDNJD(OJCONDGBEIA BKCGDDGIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F0DC50", Offset = "0x2F0D050", VA = "0x182F0DC50")]
	private static void COAPLNGMFKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E0D0", Offset = "0x2F0D4D0", VA = "0x182F0E0D0")]
	private static void EHDOBJFCNEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E1A0", Offset = "0x2F0D5A0", VA = "0x182F0E1A0")]
	private static void HLHALAIDKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class OEGOFBEELGL
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class MNHOCCFDDDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public HHKIEEPFDOH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public int sceneIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public bool async;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
		public MNHOCCFDDDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E7C0", Offset = "0x2F0DBC0", VA = "0x182F0E7C0")]
		internal void <LoadSceneInternal>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class AFMMLANPFJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public JJEKJGALHKO onCompletePromise;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
		public AFMMLANPFJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class DENEDJDDBMK : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public JJEKJGALHKO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private AFMMLANPFJM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public bool async;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int sceneIndex;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
		[DebuggerHidden]
		public DENEDJDDBMK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2F03CB0", Offset = "0x2F030B0", VA = "0x182F03CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2F03F90", Offset = "0x2F03390", VA = "0x182F03F90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class MKJPGPMPHMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public JJEKJGALHKO onCompletePromise;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
		public MKJPGPMPHMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class PNLNHBBNMIJ : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public JJEKJGALHKO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private MKJPGPMPHMJ <>8__1;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
		[DebuggerHidden]
		public PNLNHBBNMIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2F108D0", Offset = "0x2F0FCD0", VA = "0x182F108D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2F10A70", Offset = "0x2F0FE70", VA = "0x182F10A70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static CDJFFFCFLMF HPLJCGDFOOG;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static AsyncOperation NIELPFKCFMF;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static string LLDNCJNLPGL;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static string BMCBAGEGBLI;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static string AFKGHCNJPBB;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static string OPEMHLDGDEA;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static bool CCEJLKMLKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F220", Offset = "0x2F0E620", VA = "0x182F0F220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2F0EF60", Offset = "0x2F0E360", VA = "0x182F0EF60")]
	public static CDJFFFCFLMF BBOHJKKLCKO(string PCBCJKHMBGL, LoadSceneMode GNOCFLPOFIB = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F2D0", Offset = "0x2F0E6D0", VA = "0x182F0F2D0")]
	public static CDJFFFCFLMF ELELHAFLKOJ(int KOIKDOKJCIJ, LoadSceneMode GNOCFLPOFIB = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F5E0", Offset = "0x2F0E9E0", VA = "0x182F0F5E0")]
	public static CDJFFFCFLMF NNGPPPJMJIK(string PCBCJKHMBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F340", Offset = "0x2F0E740", VA = "0x182F0F340")]
	private static CDJFFFCFLMF GLKEINDEIHJ(string PCBCJKHMBGL, int KOIKDOKJCIJ, LoadSceneMode GNOCFLPOFIB, bool ONLCDILFJMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2F0EEC0", Offset = "0x2F0E2C0", VA = "0x182F0EEC0")]
	[IteratorStateMachine(typeof(DENEDJDDBMK))]
	private static IEnumerator<KENFJGFMIPM> AJDIEMKKFGG(string PCBCJKHMBGL, int KOIKDOKJCIJ, LoadSceneMode GNOCFLPOFIB, bool ONLCDILFJMC, JJEKJGALHKO OCHKEPDILKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2F0EFD0", Offset = "0x2F0E3D0", VA = "0x182F0EFD0")]
	private static CDJFFFCFLMF BNGOOIBMADF(string PCBCJKHMBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x2F0EE50", Offset = "0x2F0E250", VA = "0x182F0EE50")]
	[IteratorStateMachine(typeof(PNLNHBBNMIJ))]
	private static IEnumerator<KENFJGFMIPM> AIHIKAFCMAM(string PCBCJKHMBGL, JJEKJGALHKO OCHKEPDILKF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class FFAFDAOBAHN
{
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static byte[] OHCLMBBDJLC;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static int NJPHPOMKGAO;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static int NCHLFMFMLBC;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static BigInteger AEEDJIDCNEO;

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2F05000", Offset = "0x2F04400", VA = "0x182F05000")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x2F05100", Offset = "0x2F04500", VA = "0x182F05100")]
	public static string PAMIGJPGHHB(byte[] MGPDDEMABPB, bool KOILKPGDKMG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class __BB_OBFUSCATOR_VERSION_3_5_3
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

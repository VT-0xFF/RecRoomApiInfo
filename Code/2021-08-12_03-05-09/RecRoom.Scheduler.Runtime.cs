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
				[Cpp2IlInjected.Address(RVA = "0x3549FB0", Offset = "0x3548FB0", VA = "0x183549FB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x353EC20", Offset = "0x353DC20", VA = "0x18353EC20")]
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
				[Cpp2IlInjected.Address(RVA = "0x353D8D0", Offset = "0x353C8D0", VA = "0x18353D8D0")]
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
				private sealed class JNDDNMLJFDO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000C")]
					public ELGIGKJCDID.PEEOJJCEFPE key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
					public JNDDNMLJFDO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x3545F60", Offset = "0x3544F60", VA = "0x183545F60")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDisposable DFHFIANOKID;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x353E540", Offset = "0x353D540", VA = "0x18353E540")]
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
					[Cpp2IlInjected.Token(Token = "0x400000D")]
					public ELGIGKJCDID.PEEOJJCEFPE key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
					public FGHMPJKFPEE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x353EDD0", Offset = "0x353DDD0", VA = "0x18353EDD0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x353D7D0", Offset = "0x353C7D0", VA = "0x18353D7D0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
			public MEHOILAECLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x35482E0", Offset = "0x35472E0", VA = "0x1835482E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x353D140", Offset = "0x353C140", VA = "0x18353D140")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x353CDA0", Offset = "0x353BDA0", VA = "0x18353CDA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x353BF50", Offset = "0x353AF50", VA = "0x18353BF50")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x353CDE0", Offset = "0x353BDE0", VA = "0x18353CDE0")]
		private static void KHFAOCKFOMG(ELGIGKJCDID.PEEOJJCEFPE DNGKIAJLLHG, ref PlayerLoopSystem INJAGKJAPKC, Type IAFJLDHNNAG, Type MCNLGODIENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x353D180", Offset = "0x353C180", VA = "0x18353D180")]
		private static void PIDOJLLLMLO(ref PlayerLoopSystem INJAGKJAPKC, Type IAFJLDHNNAG, Type MCNLGODIENM, AHJIPNEIGPG BNLLHBCJFOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x353D040", Offset = "0x353C040", VA = "0x18353D040")]
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
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		FullPlayerLoop
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class FDGHJJOBMOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly PEEOJJCEFPE OOAPJCKEHFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Stopwatch HAOJCNCFIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly FIFNHIILPEL CMJEENBAHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long LHCDPFLFNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private long NMPEEAEJLBB;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x353E440", Offset = "0x353D440", VA = "0x18353E440")]
		public FDGHJJOBMOD(PEEOJJCEFPE DOOFHEFHHGI, int NMIMOBMHDAF = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x353E220", Offset = "0x353D220", VA = "0x18353E220")]
		public void BLFLBLDMBBK(int AAEANOFBLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x353E240", Offset = "0x353D240", VA = "0x18353E240")]
		public void HFJPBHFKHPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x353E1F0", Offset = "0x353D1F0", VA = "0x18353E1F0")]
		public void BAPLIBPCJLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x353E300", Offset = "0x353D300", VA = "0x18353E300")]
		public void MFBBBPPGENE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int PLKAJGEEBFC = 90;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static PEEOJJCEFPE[] GKEFALOIEHH;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static FDGHJJOBMOD[] FNGELILMAFH;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x353DC10", Offset = "0x353CC10", VA = "0x18353DC10")]
	public static FDGHJJOBMOD AKFOAKIHIBH(PEEOJJCEFPE DNGKIAJLLHG, int NMIMOBMHDAF = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x353DDD0", Offset = "0x353CDD0", VA = "0x18353DDD0")]
	public static FDGHJJOBMOD CCOLPLDBPEN(PEEOJJCEFPE DNGKIAJLLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x353DE60", Offset = "0x353CE60", VA = "0x18353DE60")]
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
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public DECOBNDCNFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
		public CLKPFIJHGLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x353B770", Offset = "0x353A770", VA = "0x18353B770")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class OGBHHMOKMFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public DECOBNDCNFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
		public OGBHHMOKMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x353B770", Offset = "0x353A770", VA = "0x18353B770")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly float IFDHHDIIAAG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x353B720", Offset = "0x353A720", VA = "0x18353B720")]
	public DECOBNDCNFA(Behaviour LHOMKMINCHH, float IFDHHDIIAAG, [Optional] Action EJAIEDPNOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x353D630", Offset = "0x353C630", VA = "0x18353D630", Slot = "9")]
	protected override bool EEJEOHAODHB(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x353D700", Offset = "0x353C700", VA = "0x18353D700", Slot = "10")]
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
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463680", VA = "0x180464680")]
		[DebuggerHidden]
		public MHJIDBHBMGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406640", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x35483E0", Offset = "0x35473E0", VA = "0x1835483E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3548480", Offset = "0x3547480", VA = "0x183548480", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Behaviour LHOMKMINCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Action EJAIEDPNOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private CDJFFFCFLMF ACGPOGCNMBA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MDJNBGPICPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5B09D0", Offset = "0x5AF9D0", VA = "0x1805B09D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OGODIKKKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3541FB0", Offset = "0x3540FB0", VA = "0x183541FB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3541F10", Offset = "0x3540F10", VA = "0x183541F10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1943580", Offset = "0x1942580", VA = "0x181943580")]
	protected HOMBMCGGPOD(Behaviour LHOMKMINCHH, [Optional] Action EJAIEDPNOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3542330", Offset = "0x3541330", VA = "0x183542330", Slot = "7")]
	public bool PFFOFIHGOEA(bool CDFHDACBFKN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3542390", Offset = "0x3541390", VA = "0x183542390", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3542050", Offset = "0x3541050", VA = "0x183542050")]
	protected void HLOEPMHHGKE(Action JJGHIEJCCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3542160", Offset = "0x3541160", VA = "0x183542160")]
	protected DABKFAIHBBP PAAAGNNFMLG(float BJJEDIGOMGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x35420F0", Offset = "0x35410F0", VA = "0x1835420F0")]
	private void KDPCHEJAGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3542070", Offset = "0x3541070", VA = "0x183542070")]
	[IteratorStateMachine(typeof(MHJIDBHBMGM))]
	private static IEnumerator<KENFJGFMIPM> HOPCEMPGALM(float BJJEDIGOMGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x35420D0", Offset = "0x35410D0", VA = "0x1835420D0")]
	[CompilerGenerated]
	private void JJADPNNAEJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PHJNILKEAAI : HOMBMCGGPOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly float KPDOKHHMHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly int OFOIBLJPHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly float DNHGIAAFCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly float[] DOBNOLHKEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int EMMJIDFJNFC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FNPGPAPOHAN MACMLJJGBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4129C0", Offset = "0x4119C0", VA = "0x1804129C0")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4059F0", Offset = "0x4049F0", VA = "0x1804059F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3549EA0", Offset = "0x3548EA0", VA = "0x183549EA0")]
	public PHJNILKEAAI(Behaviour LHOMKMINCHH, float JHPBDEKPCKP, int OFOIBLJPHGE, [Optional] Action EJAIEDPNOIG, float DNHGIAAFCLE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x406060", Offset = "0x405060", VA = "0x180406060", Slot = "9")]
	protected override bool EEJEOHAODHB(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3549BF0", Offset = "0x3548BF0", VA = "0x183549BF0", Slot = "10")]
	protected override bool KLJHDBCCABK(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3549E10", Offset = "0x3548E10", VA = "0x183549E10")]
	private void OACHLILDIHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CKNNCLNMAPG : HOMBMCGGPOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly float IFDHHDIIAAG;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x353B720", Offset = "0x353A720", VA = "0x18353B720")]
	public CKNNCLNMAPG(Behaviour LHOMKMINCHH, float IFDHHDIIAAG, [Optional] Action EJAIEDPNOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x406060", Offset = "0x405060", VA = "0x180406060", Slot = "9")]
	protected override bool EEJEOHAODHB(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x353B6E0", Offset = "0x353A6E0", VA = "0x18353B6E0", Slot = "10")]
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
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly GHMCDEEFOLC JMIGKJPPFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Action NGEMKGIAPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool KGACOELMNLL;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x41E770", Offset = "0x41D770", VA = "0x18041E770")]
	public GHMCDEEFOLC(Action NGEMKGIAPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x353FC10", Offset = "0x353EC10", VA = "0x18353FC10", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public global::KAGJDGDAADK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public global::DHKPBIAHMHG<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x12B5B70", Offset = "0x12B4B70", VA = "0x1812B5B70")]
		public GCFGNJEEJPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x24D6780", Offset = "0x24D5780", VA = "0x1824D6780")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static GameObject IIEPDHALHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<global::DHKPBIAHMHG<UnityEngine.Object, Action<T>>> CENLFEFBECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private T PBELLDKBCOE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private static UnityEngine.Object CBMCEODPHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x24DBA00", Offset = "0x24DAA00", VA = "0x1824DBA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T DMLIOOCLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x44AE00", Offset = "0x449E00", VA = "0x18044AE00", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x24DB260", Offset = "0x24DA260", VA = "0x1824DB260", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x24DB350", Offset = "0x24DA350", VA = "0x1824DB350")]
	private static bool LPHFKINGMHN(T IPHIIJNAEON, T FOJLJNMAJLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x24DBE60", Offset = "0x24DAE60", VA = "0x1824DBE60")]
	public KAGJDGDAADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x24DBF20", Offset = "0x24DAF20", VA = "0x1824DBF20")]
	public KAGJDGDAADK(T KMHEHJCNMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x24DBE40", Offset = "0x24DAE40", VA = "0x1824DBE40")]
	public void MOCMFLAMJHA(T BCEFAKDFEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x24DB0B0", Offset = "0x24DA0B0", VA = "0x1824DB0B0", Slot = "7")]
	public IDisposable JAHAHHAFAPC(Action<T> CCHCBCLCFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x24DB120", Offset = "0x24DA120", VA = "0x1824DB120", Slot = "8")]
	public IDisposable JAHAHHAFAPC(UnityEngine.Object LHOMKMINCHH, Action<T> CCHCBCLCFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x24DB6E0", Offset = "0x24DA6E0", VA = "0x1824DB6E0")]
	private void LPKBPIMHHOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class LCNLICMJMPA
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class LFCPKFJPOEA : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463680", VA = "0x180464680")]
		[DebuggerHidden]
		public LFCPKFJPOEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406640", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3547580", Offset = "0x3546580", VA = "0x183547580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3547620", Offset = "0x3546620", VA = "0x183547620", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class COMHPOBAMNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public DABKFAIHBBP promise;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
		public COMHPOBAMNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x353B800", Offset = "0x353A800", VA = "0x18353B800")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class AGKDIHPOJIA : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463680", VA = "0x180464680")]
		[DebuggerHidden]
		public AGKDIHPOJIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406640", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x353ABF0", Offset = "0x3539BF0", VA = "0x18353ABF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x353ACE0", Offset = "0x3539CE0", VA = "0x18353ACE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly KENFJGFMIPM MEOLIHPOHLL;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly KENFJGFMIPM FPHNJEAGAPM;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly KENFJGFMIPM EMOILKMBCEP;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly KENFJGFMIPM LCLLAMKJJLA;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly KENFJGFMIPM PBJHMFKPMHN;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3547270", Offset = "0x3546270", VA = "0x183547270")]
	public static KENFJGFMIPM LEIMHFLNIKB(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3547200", Offset = "0x3546200", VA = "0x183547200")]
	[IteratorStateMachine(typeof(LFCPKFJPOEA))]
	public static IEnumerator<KENFJGFMIPM> FDHJPDHIMME(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3547350", Offset = "0x3546350", VA = "0x183547350")]
	public static KENFJGFMIPM LINOLLIBDCO(Func<bool> LKMLNOJIFHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x35473B0", Offset = "0x35463B0", VA = "0x1835473B0")]
	public static KENFJGFMIPM OPDGBNPLNHG(DABKFAIHBBP NKLGAGCHGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x35471B0", Offset = "0x35461B0", VA = "0x1835471B0")]
	[IteratorStateMachine(typeof(AGKDIHPOJIA))]
	public static IEnumerator<KENFJGFMIPM> EPAMOHIGFDO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KENFJGFMIPM
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GAPNCPOLFEI();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class CPHEMJCNNDB : KENFJGFMIPM
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class KBIEPEFBMPJ : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
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
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private CPHEMJCNNDB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463680", VA = "0x180464680")]
		[DebuggerHidden]
		public KBIEPEFBMPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406640", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3545FE0", Offset = "0x3544FE0", VA = "0x183545FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x35460B0", Offset = "0x35450B0", VA = "0x1835460B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class DDPJLKFDDNM : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private CPHEMJCNNDB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463680", VA = "0x180464680")]
		[DebuggerHidden]
		public DDPJLKFDDNM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406640", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x353D4F0", Offset = "0x353C4F0", VA = "0x18353D4F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x353D5E0", Offset = "0x353C5E0", VA = "0x18353D5E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x410090", Offset = "0x40F090", VA = "0x180410090", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4059D0", Offset = "0x4049D0", VA = "0x1804059D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8B0980", Offset = "0x8AF980", VA = "0x1808B0980", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463680", VA = "0x180464680")]
	public CPHEMJCNNDB(Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x47F7D0", Offset = "0x47E7D0", VA = "0x18047F7D0", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x353BB60", Offset = "0x353AB60", VA = "0x18353BB60")]
	public static KFBABPAPIMB GIEOOLAGCKA(Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x353BA70", Offset = "0x353AA70", VA = "0x18353BA70")]
	public static KFBABPAPIMB GIEOOLAGCKA(Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x353BD60", Offset = "0x353AD60", VA = "0x18353BD60")]
	public static KFBABPAPIMB GIEOOLAGCKA(Behaviour LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x353BC50", Offset = "0x353AC50", VA = "0x18353BC50")]
	public static KFBABPAPIMB GIEOOLAGCKA(Behaviour LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x353B960", Offset = "0x353A960", VA = "0x18353B960")]
	public static KFBABPAPIMB DJJOEODIBEE(BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x353B850", Offset = "0x353A850", VA = "0x18353B850")]
	public static KFBABPAPIMB DJJOEODIBEE(BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x353BEE0", Offset = "0x353AEE0", VA = "0x18353BEE0")]
	[IteratorStateMachine(typeof(KBIEPEFBMPJ))]
	private static IEnumerator<KENFJGFMIPM> OKAOGDPNEKD(Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x353BE70", Offset = "0x353AE70", VA = "0x18353BE70")]
	[IteratorStateMachine(typeof(DDPJLKFDDNM))]
	private static IEnumerator<KENFJGFMIPM> OKAOGDPNEKD(Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class BECNBPANOEI : KENFJGFMIPM
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class NIOKFBABMOC : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private BECNBPANOEI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463680", VA = "0x180464680")]
		[DebuggerHidden]
		public NIOKFBABMOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406640", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3548510", Offset = "0x3547510", VA = "0x183548510", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x35486B0", Offset = "0x35476B0", VA = "0x1835486B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly float IMKDOHNAMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private int EECPLAEACEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly float LJINEKMJNJB;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public float MMEAJDPNJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8CED40", Offset = "0x8CDD40", VA = "0x1808CED40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x85CDE0", Offset = "0x85BDE0", VA = "0x18085CDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x411DF0", Offset = "0x410DF0", VA = "0x180411DF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x43EEB0", Offset = "0x43DEB0", VA = "0x18043EEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE20", Offset = "0x8CDE20", VA = "0x1808CEE20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFE0", Offset = "0x8CDFE0", VA = "0x1808CEFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float FFPPABMIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8CF000", Offset = "0x8CE000", VA = "0x1808CF000")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8CED50", Offset = "0x8CDD50", VA = "0x1808CED50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x353B120", Offset = "0x353A120", VA = "0x18353B120")]
	public BECNBPANOEI(float CKGGPPMDDBP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x353ADC0", Offset = "0x3539DC0", VA = "0x18353ADC0", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x353B090", Offset = "0x353A090", VA = "0x18353B090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x353ADE0", Offset = "0x3539DE0", VA = "0x18353ADE0")]
	public static KFBABPAPIMB GIEOOLAGCKA(float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x353AE90", Offset = "0x3539E90", VA = "0x18353AE90")]
	public static KFBABPAPIMB GIEOOLAGCKA(MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x353AF50", Offset = "0x3539F50", VA = "0x18353AF50")]
	public static KFBABPAPIMB HFKCNODKFKG(BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x353B010", Offset = "0x353A010", VA = "0x18353B010")]
	[IteratorStateMachine(typeof(NIOKFBABMOC))]
	private static IEnumerator<KENFJGFMIPM> OKAOGDPNEKD(float JCAEDLLGMHA, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class ENKGACHBJCJ : KENFJGFMIPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly Func<bool> LKMLNOJIFHH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3FA4F0", Offset = "0x3F94F0", VA = "0x1803FA4F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x43E290", Offset = "0x43D290", VA = "0x18043E290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8CED40", Offset = "0x8CDD40", VA = "0x1808CED40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x85CDE0", Offset = "0x85BDE0", VA = "0x18085CDE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x353E070", Offset = "0x353D070", VA = "0x18353E070")]
	public ENKGACHBJCJ(Func<bool> LKMLNOJIFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x353E0A0", Offset = "0x353D0A0", VA = "0x18353E0A0")]
	public ENKGACHBJCJ(Scheduler.NEIJEKIKDOG CKFELIAJKCP, Func<bool> LKMLNOJIFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x353E020", Offset = "0x353D020", VA = "0x18353E020", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class OCBENJPNGLC
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class NONJFBJHGEM : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Scheduler.NEIJEKIKDOG queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463680", VA = "0x180464680")]
		[DebuggerHidden]
		public NONJFBJHGEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406640", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3548700", Offset = "0x3547700", VA = "0x183548700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x35487A0", Offset = "0x35477A0", VA = "0x1835487A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x35487F0", Offset = "0x35477F0", VA = "0x1835487F0")]
	[IteratorStateMachine(typeof(NONJFBJHGEM))]
	private static IEnumerator<KENFJGFMIPM> AGGNPLMDKGE(Scheduler.NEIJEKIKDOG CKFELIAJKCP, Func<bool> LKMLNOJIFHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3548860", Offset = "0x3547860", VA = "0x183548860")]
	public static KFBABPAPIMB EGIAAFEOAGP(this MonoBehaviour BKGIHIBDAPA, Func<bool> LKMLNOJIFHH, Scheduler.NEIJEKIKDOG CKFELIAJKCP = Scheduler.NEIJEKIKDOG.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class JMOPCCPBNMB : KENFJGFMIPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly float MKOEJJBMPIN;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4B3600", Offset = "0x4B2600", VA = "0x1804B3600", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x595690", Offset = "0x594690", VA = "0x180595690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFF0", Offset = "0x8CDFF0", VA = "0x1808CEFF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x879A20", Offset = "0x878A20", VA = "0x180879A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3545EB0", Offset = "0x3544EB0", VA = "0x183545EB0")]
	public JMOPCCPBNMB(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3545E20", Offset = "0x3544E20", VA = "0x183545E20", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class IPFBKNOHEGB
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class CHFAJCJLJLB : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
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

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463680", VA = "0x180464680")]
		[DebuggerHidden]
		public CHFAJCJLJLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406640", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x353B5E0", Offset = "0x353A5E0", VA = "0x18353B5E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x353B690", Offset = "0x353A690", VA = "0x18353B690", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class EOMJHPHEMLH : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private KENFJGFMIPM <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463680", VA = "0x180464680")]
		[DebuggerHidden]
		public EOMJHPHEMLH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406640", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x353E0E0", Offset = "0x353D0E0", VA = "0x18353E0E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x353E1A0", Offset = "0x353D1A0", VA = "0x18353E1A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3545560", Offset = "0x3544560", VA = "0x183545560")]
	[IteratorStateMachine(typeof(CHFAJCJLJLB))]
	private static IEnumerator<KENFJGFMIPM> HEBGBPGEFPK(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3545370", Offset = "0x3544370", VA = "0x183545370")]
	[IteratorStateMachine(typeof(EOMJHPHEMLH))]
	private static IEnumerator<KENFJGFMIPM> DBNBNAILAFO(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3545B50", Offset = "0x3544B50", VA = "0x183545B50")]
	public static IDisposable PBPKBANPKJP(this MonoBehaviour BKGIHIBDAPA, float HABFNPMBADP, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3545400", Offset = "0x3544400", VA = "0x183545400")]
	public static KFBABPAPIMB ENFHDIBGOEO(this MonoBehaviour BKGIHIBDAPA, float HABFNPMBADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3545C90", Offset = "0x3544C90", VA = "0x183545C90")]
	public static KFBABPAPIMB PBPKBANPKJP(this MonoBehaviour BKGIHIBDAPA, float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3545540", Offset = "0x3544540", VA = "0x183545540")]
	public static KFBABPAPIMB FHKNPABNEEM(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x35455E0", Offset = "0x35445E0", VA = "0x1835455E0")]
	public static KFBABPAPIMB HECMPBHFOEA(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x35453F0", Offset = "0x35443F0", VA = "0x1835453F0")]
	public static KFBABPAPIMB EGOJDKEBMNH(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3545550", Offset = "0x3544550", VA = "0x183545550")]
	public static KFBABPAPIMB GGGCLEIGKCE(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3545700", Offset = "0x3544700", VA = "0x183545700")]
	public static KFBABPAPIMB JGIPMJPPCBM(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3545260", Offset = "0x3544260", VA = "0x183545260")]
	private static KFBABPAPIMB AKNLAJLAGMB(MonoBehaviour BKGIHIBDAPA, Scheduler.NEIJEKIKDOG CKFELIAJKCP, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3545930", Offset = "0x3544930", VA = "0x183545930")]
	public static KFBABPAPIMB NLBLFPBOCLD(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3545A40", Offset = "0x3544A40", VA = "0x183545A40")]
	public static KFBABPAPIMB PAKNHKEKDAF(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x35455F0", Offset = "0x35445F0", VA = "0x1835455F0")]
	public static KFBABPAPIMB INLJFAKDKAD(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3545820", Offset = "0x3544820", VA = "0x183545820")]
	public static KFBABPAPIMB LBLNPIDACFM(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3545710", Offset = "0x3544710", VA = "0x183545710")]
	public static KFBABPAPIMB JOOHIGCAKNF(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class ICMKAJELBGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class ILPPIMNIHBJ : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463680", VA = "0x180464680")]
		[DebuggerHidden]
		public ILPPIMNIHBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406640", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3545160", Offset = "0x3544160", VA = "0x183545160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3545210", Offset = "0x3544210", VA = "0x183545210", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private KFBABPAPIMB KHPFGANHBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private MonoBehaviour BKGIHIBDAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private Action JFKDDPJDCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Action<float> HBMODGLEAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Scheduler.NEIJEKIKDOG CKFELIAJKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private float FJKINHFIBJA;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3544FD0", Offset = "0x3543FD0", VA = "0x183544FD0")]
	public ICMKAJELBGE(MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3544CF0", Offset = "0x3543CF0", VA = "0x183544CF0")]
	public ICMKAJELBGE(MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3544E80", Offset = "0x3543E80", VA = "0x183544E80")]
	public ICMKAJELBGE(MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3544920", Offset = "0x3543920", VA = "0x183544920")]
	private void GIEOOLAGCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3544720", Offset = "0x3543720", VA = "0x183544720")]
	private void EBPHAECHJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3544AA0", Offset = "0x3543AA0", VA = "0x183544AA0")]
	private void HCMLBCFDNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3544BD0", Offset = "0x3543BD0", VA = "0x183544BD0")]
	private void KEECGEIFLEN(string MOPOMPHBHKF, Action HGGDFJNNBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3544670", Offset = "0x3543670", VA = "0x183544670")]
	[IteratorStateMachine(typeof(ILPPIMNIHBJ))]
	private IEnumerator<KENFJGFMIPM> DEJICBOKAJH(Action HGGDFJNNBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x35446D0", Offset = "0x35436D0", VA = "0x1835446D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x35445F0", Offset = "0x35435F0", VA = "0x1835445F0")]
	[CompilerGenerated]
	private void CKHMLHHHCLN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3544570", Offset = "0x3543570", VA = "0x183544570")]
	[CompilerGenerated]
	private void CBBGHNELPMN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x35448A0", Offset = "0x35438A0", VA = "0x1835448A0")]
	[CompilerGenerated]
	private void GGEOKDFDCNK(string CHKKEHOKPJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class ADIFCODGAML
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x353A710", Offset = "0x3539710", VA = "0x18353A710")]
	public static IDisposable GIEOOLAGCKA(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x353A550", Offset = "0x3539550", VA = "0x18353A550")]
	public static IDisposable GIEOOLAGCKA(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x353AB80", Offset = "0x3539B80", VA = "0x18353AB80")]
	public static IDisposable OPEMIFENIJM(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x353AA10", Offset = "0x3539A10", VA = "0x18353AA10")]
	public static IDisposable MOJAICCOOMH(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x353AA80", Offset = "0x3539A80", VA = "0x18353AA80")]
	public static IDisposable OEMBBKDJFCB(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x353A360", Offset = "0x3539360", VA = "0x18353A360")]
	public static IDisposable FHBCIFNCNMN(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x353A810", Offset = "0x3539810", VA = "0x18353A810")]
	public static IDisposable JEEMKGCKHKD(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x353A880", Offset = "0x3539880", VA = "0x18353A880")]
	public static IDisposable LAHBIDHMCKF(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x353A3D0", Offset = "0x35393D0", VA = "0x18353A3D0")]
	public static IDisposable FLMKKKHMJBN(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3539FD0", Offset = "0x3538FD0", VA = "0x183539FD0")]
	public static IDisposable AMNODMIDNHO(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x353A790", Offset = "0x3539790", VA = "0x18353A790")]
	public static IDisposable ICPMHNDIIFK(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x353A250", Offset = "0x3539250", VA = "0x18353A250")]
	public static IDisposable ENLMJBCKILF(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x353A4D0", Offset = "0x35394D0", VA = "0x18353A4D0")]
	public static IDisposable FOFJADGKNJF(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x353A910", Offset = "0x3539910", VA = "0x18353A910")]
	public static IDisposable LFJPCEKGMIA(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3539F50", Offset = "0x3538F50", VA = "0x183539F50")]
	public static IDisposable ADIDJGEIJOH(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x353AAF0", Offset = "0x3539AF0", VA = "0x18353AAF0")]
	public static IDisposable OIJBBPIBIJP(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x353A0D0", Offset = "0x35390D0", VA = "0x18353A0D0")]
	public static IDisposable AOPHLNHDOKN(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x353A150", Offset = "0x3539150", VA = "0x18353A150")]
	public static IDisposable BOHBPECGHLI(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x353A450", Offset = "0x3539450", VA = "0x18353A450")]
	public static IDisposable FNFEBJPKPEA(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x353A2D0", Offset = "0x35392D0", VA = "0x18353A2D0")]
	public static IDisposable FGFJPAFFKIN(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x353A1D0", Offset = "0x35391D0", VA = "0x18353A1D0")]
	public static IDisposable CHFECAOLPEO(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x353A990", Offset = "0x3539990", VA = "0x18353A990")]
	public static IDisposable LGJLMMIHFON(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x353A050", Offset = "0x3539050", VA = "0x18353A050")]
	public static IDisposable AOPEPIBPFMP(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class OLKNGLHPDJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class FNFBHFJCFAI : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463680", VA = "0x180464680")]
		[DebuggerHidden]
		public FNFBHFJCFAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406640", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x353F200", Offset = "0x353E200", VA = "0x18353F200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x353F2B0", Offset = "0x353E2B0", VA = "0x18353F2B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private KFBABPAPIMB KHPFGANHBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private BPGLFKPKJHF LHOMKMINCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Action JFKDDPJDCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Action<float> HBMODGLEAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Scheduler.NEIJEKIKDOG CKFELIAJKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private float FJKINHFIBJA;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3549710", Offset = "0x3548710", VA = "0x183549710")]
	public OLKNGLHPDJE(BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x35499F0", Offset = "0x35489F0", VA = "0x1835499F0")]
	public OLKNGLHPDJE(BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x35498A0", Offset = "0x35488A0", VA = "0x1835498A0")]
	public OLKNGLHPDJE(BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3549340", Offset = "0x3548340", VA = "0x183549340")]
	private void GIEOOLAGCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3549140", Offset = "0x3548140", VA = "0x183549140")]
	private void EBPHAECHJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x35494C0", Offset = "0x35484C0", VA = "0x1835494C0")]
	private void HCMLBCFDNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x35495F0", Offset = "0x35485F0", VA = "0x1835495F0")]
	private void KEECGEIFLEN(string MOPOMPHBHKF, Action HGGDFJNNBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3549090", Offset = "0x3548090", VA = "0x183549090")]
	[IteratorStateMachine(typeof(FNFBHFJCFAI))]
	private IEnumerator<KENFJGFMIPM> DEJICBOKAJH(Action HGGDFJNNBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x35490F0", Offset = "0x35480F0", VA = "0x1835490F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3549010", Offset = "0x3548010", VA = "0x183549010")]
	[CompilerGenerated]
	private void CKHMLHHHCLN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3548F90", Offset = "0x3547F90", VA = "0x183548F90")]
	[CompilerGenerated]
	private void CBBGHNELPMN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x35492C0", Offset = "0x35482C0", VA = "0x1835492C0")]
	[CompilerGenerated]
	private void GGEOKDFDCNK(string CHKKEHOKPJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class KCBPNKMEDPI
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3546540", Offset = "0x3545540", VA = "0x183546540")]
	public static IDisposable DJJOEODIBEE(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3546380", Offset = "0x3545380", VA = "0x183546380")]
	public static IDisposable DJJOEODIBEE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x35465C0", Offset = "0x35455C0", VA = "0x1835465C0")]
	public static IDisposable EMGJKCCEAJA(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3546730", Offset = "0x3545730", VA = "0x183546730")]
	public static IDisposable GJCJNLFFLKP(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x35466C0", Offset = "0x35456C0", VA = "0x1835466C0")]
	public static IDisposable GAPIDOHIBLG(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3546220", Offset = "0x3545220", VA = "0x183546220")]
	public static IDisposable CAJKNLABPBH(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3546310", Offset = "0x3545310", VA = "0x183546310")]
	public static IDisposable DGFNIKAEGMI(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3546630", Offset = "0x3545630", VA = "0x183546630")]
	public static IDisposable EOGNMLDAMCK(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3546BA0", Offset = "0x3545BA0", VA = "0x183546BA0")]
	public static IDisposable PBDKGIJCPCG(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x35469A0", Offset = "0x35459A0", VA = "0x1835469A0")]
	public static IDisposable MHPNCCEFCID(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x35467A0", Offset = "0x35457A0", VA = "0x1835467A0")]
	public static IDisposable HNFGDIHEFIO(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3546B20", Offset = "0x3545B20", VA = "0x183546B20")]
	public static IDisposable ONEBONJNMNK(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3546190", Offset = "0x3545190", VA = "0x183546190")]
	public static IDisposable BNJMDNLEDJB(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3546820", Offset = "0x3545820", VA = "0x183546820")]
	public static IDisposable IPPHMOEKHMO(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3546A20", Offset = "0x3545A20", VA = "0x183546A20")]
	public static IDisposable NIIGGNNJAGE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3546AA0", Offset = "0x3545AA0", VA = "0x183546AA0")]
	public static IDisposable OBEEJIAEFKM(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3546100", Offset = "0x3545100", VA = "0x183546100")]
	public static IDisposable AGEPHCFGCMM(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3546290", Offset = "0x3545290", VA = "0x183546290")]
	public static IDisposable CEILCDDBJHP(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3546920", Offset = "0x3545920", VA = "0x183546920")]
	public static IDisposable LJOHGJJMOGE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x35468A0", Offset = "0x35458A0", VA = "0x1835468A0")]
	public static IDisposable KPDELENMDOE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class Scheduler : SingletonMonoBehaviour<Scheduler>
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private class BMOEEDOECDC : NGHLNGJDGGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public IALKDLLHDII ALLFDCFPHGM;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public int AKGEGLEMFGM
			{
				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x410090", Offset = "0x40F090", VA = "0x180410090", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x4059D0", Offset = "0x4049D0", VA = "0x1804059D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x353B480", Offset = "0x353A480", VA = "0x18353B480")]
			public static KENFJGFMIPM NEPONCICACF(IEnumerator<KENFJGFMIPM> LOIIKGFHHAA, OMNCINDCAAJ NKLGAGCHGPM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x353B3B0", Offset = "0x353A3B0", VA = "0x18353B3B0")]
			public KENFJGFMIPM NEPONCICACF(OMNCINDCAAJ[] LMOONNDFEPE, IEnumerator<KENFJGFMIPM>[] JNMOEFOGKLE, KENFJGFMIPM[] DHGHPJHPPGE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x353B380", Offset = "0x353A380", VA = "0x18353B380")]
			public void HNDCKFDJEKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x353B2C0", Offset = "0x353A2C0", VA = "0x18353B2C0")]
			public void CMDNNKIMLED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x353B200", Offset = "0x353A200", VA = "0x18353B200")]
			public void AKIBJAOAEFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x353B380", Offset = "0x353A380", VA = "0x18353B380")]
			public void KBPKIDJEOFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
			public BMOEEDOECDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private sealed class IALKDLLHDII
		{
			[Cpp2IlInjected.Token(Token = "0x2000040")]
			public struct CFBMJLPBODF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public BMOEEDOECDC EOPDHGPFPNC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public BPGLFKPKJHF ADDDHPLGIKL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public OMNCINDCAAJ BAINEAGHDEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				public IEnumerator<KENFJGFMIPM> HCIEHECEDAK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public KENFJGFMIPM JIGIMNNJHGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public KINIDGHKMLM HDECHJHCMDD;
			}

			[Cpp2IlInjected.Token(Token = "0x2000041")]
			public struct GIDICDINLFI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public NEIJEKIKDOG JDIEDFKCIGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public List<CFBMJLPBODF> BKPFCJJFMDB;
			}

			[Cpp2IlInjected.Token(Token = "0x2000042")]
			[CompilerGenerated]
			private sealed class GHLCIHPNOIJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public BPGLFKPKJHF context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public BMOEEDOECDC routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public KINIDGHKMLM coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public OMNCINDCAAJ promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public KENFJGFMIPM currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public IEnumerator<KENFJGFMIPM> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
				public GHLCIHPNOIJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x353F5C0", Offset = "0x353E5C0", VA = "0x18353F5C0")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class JKHIMOPAHLJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public BMOEEDOECDC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
				public JKHIMOPAHLJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x3545DE0", Offset = "0x3544DE0", VA = "0x183545DE0")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000044")]
			[CompilerGenerated]
			private sealed class OEJBHOJOLNM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public BMOEEDOECDC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
				public OEJBHOJOLNM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x3548F50", Offset = "0x3547F50", VA = "0x183548F50")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class MLOIAKOIDDA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public BMOEEDOECDC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
				public MLOIAKOIDDA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017D")]
				[Cpp2IlInjected.Address(RVA = "0x35484D0", Offset = "0x35474D0", VA = "0x1835484D0")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private readonly NEIJEKIKDOG CKFELIAJKCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private bool[] OHHCKBGGNCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private NativeArray<KINIDGHKMLM> NGPEDHJDGOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private NativeArray<float> EGPCFKONLDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private NativeArray<int> DIPODGDEDFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private NativeArray<int> ADMMJMECAAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private NativeArray<int> GDENALHIFED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private NativeArray<int> MFFNBPCJDPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private NativeArray<int> LKNDAPBEAHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private BMOEEDOECDC[] EICHIBKNPKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private OMNCINDCAAJ[] LMOONNDFEPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private BPGLFKPKJHF[] AMEFOJLMGID;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private IEnumerator<KENFJGFMIPM>[] JELOAPNCLNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private KENFJGFMIPM[] LDGCCHBDADH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int IMLAJMIFNPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private int NPKCAEOBEMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private readonly int AEIDKODLGJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private float PPDFBDENFBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private LCKMBKBNBGC OIHBJFCDCOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private JobHandle LMMAIKCFIFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private List<BMOEEDOECDC> DNBEKFHBBOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private bool HABDMPHMEHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private List<Action> KCFLKGHJGIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private List<Action> GAKKPKFANJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private bool AFDHMMIPEIP;

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public GIDICDINLFI[] OAPPOHBJCJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0xC27110", Offset = "0xC26110", VA = "0x180C27110")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public int JJEKKMDIBGI
			{
				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0x6590C0", Offset = "0x6580C0", VA = "0x1806590C0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3544070", Offset = "0x3543070", VA = "0x183544070")]
			private static int PGPLCLADMOP(NEIJEKIKDOG CKFELIAJKCP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x35440A0", Offset = "0x35430A0", VA = "0x1835440A0")]
			public IALKDLLHDII(NEIJEKIKDOG CKFELIAJKCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3543A60", Offset = "0x3542A60", VA = "0x183543A60")]
			private void MLAFOKLGIMD(ref int GMJLJINPLLP, int DGKFKECDFGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3543E90", Offset = "0x3542E90", VA = "0x183543E90")]
			public void NPNEHCHIMCM(BPGLFKPKJHF LHOMKMINCHH, KENFJGFMIPM BPGGCEOBFBK, IEnumerator<KENFJGFMIPM> LOIIKGFHHAA, OMNCINDCAAJ NKLGAGCHGPM, [Optional] BMOEEDOECDC NEPMGGPMFOH, KINIDGHKMLM IJBJBPDEKKL = KINIDGHKMLM.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3542D90", Offset = "0x3541D90", VA = "0x183542D90")]
			public void FLJBJJLIFHM(IEnumerable<CFBMJLPBODF> DMDLKMFKKCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x3543000", Offset = "0x3542000", VA = "0x183543000")]
			private CFBMJLPBODF JAAGBELBKHG(int JGECCDNFAID)
			{
				return default(CFBMJLPBODF);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3542A60", Offset = "0x3541A60", VA = "0x183542A60")]
			private void FKNNONKOPDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x14B87D0", Offset = "0x14B77D0", VA = "0x1814B87D0")]
			private static void NBHOFBPCJGK<T>(int JGECCDNFAID, T[] IMMIMNIHIEF, int OJJOHDIFMEG, [Optional] T ADHBGHBGDNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x14B87B0", Offset = "0x14B77B0", VA = "0x1814B87B0")]
			private static void NBHOFBPCJGK<T>(int JGECCDNFAID, NativeArray<T> IMMIMNIHIEF, int OJJOHDIFMEG, [Optional] T ADHBGHBGDNC) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x3542740", Offset = "0x3541740", VA = "0x183542740")]
			private void DIOBAOCAAEI(IEnumerable<CFBMJLPBODF> DMDLKMFKKCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x35423E0", Offset = "0x35413E0", VA = "0x1835423E0")]
			private void BANFNKBEACN(CFBMJLPBODF IHJKAJBJMJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3543BF0", Offset = "0x3542BF0", VA = "0x183543BF0")]
			private FLILCHFLFHI NDHIAFIAEDC(int AHKGGOPCBNK)
			{
				return default(FLILCHFLFHI);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x3542550", Offset = "0x3541550", VA = "0x183542550")]
			public void CMBODEFCFGB(float KGOBMDNKIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x3542F80", Offset = "0x3541F80", VA = "0x183542F80")]
			private void GBONAELFCHI(Action IPHIIJNAEON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x35429E0", Offset = "0x35419E0", VA = "0x1835429E0")]
			private void EAOBOPNPOJE(Action IPHIIJNAEON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x3543430", Offset = "0x3542430", VA = "0x183543430")]
			public void JGHOHJNCKDH(float KGOBMDNKIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3543980", Offset = "0x3542980", VA = "0x183543980")]
			public void MDDAPCCABNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x35438D0", Offset = "0x35428D0", VA = "0x1835438D0")]
			public void KBPKIDJEOFB(BMOEEDOECDC KECNNGMBHAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x3543FC0", Offset = "0x3542FC0", VA = "0x183543FC0")]
			public void OEJCNOAPCAB(BMOEEDOECDC KECNNGMBHAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x35424A0", Offset = "0x35414A0", VA = "0x1835424A0")]
			public void CIFEAJMAHKI(BMOEEDOECDC KECNNGMBHAK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[BurstCompile]
		public struct LCKMBKBNBGC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			[ReadOnly]
			public float MKLCOIBIHEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			[ReadOnly]
			public int KGOGPFCJPPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private NativeArray<int> ELFLBECKFEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private NativeArray<int> AKANBKMACGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private NativeArray<int> JBONOFAJNCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			[ReadOnly]
			public NativeArray<KINIDGHKMLM> GJHKCAEJCKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			[ReadOnly]
			public NativeArray<float> EDDPIGKJOHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			[WriteOnly]
			public NativeArray<int> GDENALHIFED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			[WriteOnly]
			public NativeArray<int> DIPODGDEDFB;

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x3547070", Offset = "0x3546070", VA = "0x183547070")]
			public static LCKMBKBNBGC NFHADFCEMML(int GONGHDLCGPO, float KGOBMDNKIDJ, NativeArray<KINIDGHKMLM> FKIFNJGLFDF, NativeArray<float> ADCCOCDJMNM, NativeArray<int> EIHKHJBKKPC, NativeArray<int> HEDEJBEKJPH, NativeArray<int> HFOAFEDLEJG, NativeArray<int> AKANBKMACGE, NativeArray<int> JBONOFAJNCL)
			{
				return default(LCKMBKBNBGC);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x3546C50", Offset = "0x3545C50", VA = "0x183546C50", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3546E00", Offset = "0x3545E00", VA = "0x183546E00")]
			private bool KHFEFLOCLII(int EFBDCIJMFGD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x3546C20", Offset = "0x3545C20", VA = "0x183546C20")]
			private void CDLEKIKHHCD(NativeArray<int> FJLGONNPKCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3547140", Offset = "0x3546140", VA = "0x183547140")]
			private int OEIAGHKPDBB(int ILJJFCIEOOJ, int MMJPCDPKKJE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x3546D30", Offset = "0x3545D30", VA = "0x183546D30")]
			private void JIHBNKEBJDH(NativeArray<int> FJLGONNPKCB, int DLECGJMGFNI, int PBAOMKNFBFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3546E40", Offset = "0x3545E40", VA = "0x183546E40")]
			private void MNMAEDHAEFJ(NativeArray<int> FJLGONNPKCB, int JNOJAJGDFLF, int AKCJAFLPOKA, int IMMAKAPBGIK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class GMHCEMDMGBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private readonly OMNCINDCAAJ NKLGAGCHGPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private readonly Behaviour LHOMKMINCHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private readonly bool LPCBEEBALNO;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public IEnumerator<KENFJGFMIPM> HCIEHECEDAK
			{
				[Cpp2IlInjected.Token(Token = "0x6000185")]
				[Cpp2IlInjected.Address(RVA = "0x3F6000", Offset = "0x3F5000", VA = "0x1803F6000")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000186")]
				[Cpp2IlInjected.Address(RVA = "0x4055E0", Offset = "0x4045E0", VA = "0x1804055E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public KENFJGFMIPM JIGIMNNJHGD
			{
				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x4055D0", Offset = "0x4045D0", VA = "0x1804055D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public bool OBADDMFNOMJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000189")]
				[Cpp2IlInjected.Address(RVA = "0x353FD00", Offset = "0x353ED00", VA = "0x18353FD00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool JDKJCDNCDAN
			{
				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0x454FE0", Offset = "0x453FE0", VA = "0x180454FE0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600018B")]
				[Cpp2IlInjected.Address(RVA = "0x455280", Offset = "0x454280", VA = "0x180455280")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public string FIKEBGGCDFN
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x415040", Offset = "0x414040", VA = "0x180415040")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0x4059E0", Offset = "0x4049E0", VA = "0x1804059E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public float LKOAKFDABJP
			{
				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0x8F5B30", Offset = "0x8F4B30", VA = "0x1808F5B30")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0x8F5940", Offset = "0x8F4940", VA = "0x1808F5940")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x3540150", Offset = "0x353F150", VA = "0x183540150")]
			public GMHCEMDMGBA(IEnumerator<KENFJGFMIPM> LOIIKGFHHAA, Behaviour LHOMKMINCHH, OMNCINDCAAJ NKLGAGCHGPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x353FEB0", Offset = "0x353EEB0", VA = "0x18353FEB0")]
			public KENFJGFMIPM NEPONCICACF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x353FD90", Offset = "0x353ED90", VA = "0x18353FD90")]
			public bool GBOOCLEMCKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x353FE20", Offset = "0x353EE20", VA = "0x18353FE20")]
			public void KBPKIDJEOFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x35400C0", Offset = "0x353F0C0", VA = "0x1835400C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xE87A60", Offset = "0xE86A60", VA = "0x180E87A60")]
			[CompilerGenerated]
			private void NNFOONHOMIF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class OMNCINDCAAJ : HHKIEEPFDOH, KFBABPAPIMB, CDJFFFCFLMF, DABKFAIHBBP, IEnumerator, KENFJGFMIPM, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private NEIJEKIKDOG FIDOMBIKHPP;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			private NEIJEKIKDOG IIPMBGHMKNO
			{
				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0x44F7E0", Offset = "0x44E7E0", VA = "0x18044F7E0", Slot = "23")]
				get
				{
					return default(NEIJEKIKDOG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public NEIJEKIKDOG ALLFDCFPHGM
			{
				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x44F7E0", Offset = "0x44E7E0", VA = "0x18044F7E0")]
				get
				{
					return default(NEIJEKIKDOG);
				}
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x4226E0", Offset = "0x4216E0", VA = "0x1804226E0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			private float IIEAAEDICEG
			{
				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x8B0980", Offset = "0x8AF980", VA = "0x1808B0980", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x455000", Offset = "0x454000", VA = "0x180455000", Slot = "24")]
			private bool EEOJLONCPBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3549B80", Offset = "0x3548B80", VA = "0x183549B80", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3549B90", Offset = "0x3548B90", VA = "0x183549B90")]
			public OMNCINDCAAJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private enum FLILCHFLFHI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private sealed class GOPOCOOMEIM : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public enum MJKJJAEINKK
			{
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			public struct OFOGOHPAFPJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public NEIJEKIKDOG JDIEDFKCIGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public MJKJJAEINKK BAPFEDOOIFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public List<GMHCEMDMGBA> OECIFDDKEAP;
			}

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private static readonly MJKJJAEINKK[] GLLEJMPCGJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private readonly NEIJEKIKDOG CKFELIAJKCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private bool JLDJMFNCDPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private readonly GMHCEMDMGBA[] GGEMDOAPACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private readonly List<GMHCEMDMGBA> PJKLFGMDJLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private readonly Stack<int> KIMBMABLPNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private readonly List<GMHCEMDMGBA> EADBGNKMBEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private readonly Stack<int> BCKLDDFGIID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private bool AFDHMMIPEIP;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public OFOGOHPAFPJ[,] KENMKBOBOCM
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x427460", Offset = "0x426460", VA = "0x180427460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public int JJEKKMDIBGI
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x3540E60", Offset = "0x353FE60", VA = "0x183540E60")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3541720", Offset = "0x3540720", VA = "0x183541720")]
			public GOPOCOOMEIM(NEIJEKIKDOG MJHMBNIDGCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3541470", Offset = "0x3540470", VA = "0x183541470")]
			public void OFMOGILADOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3540E50", Offset = "0x353FE50", VA = "0x183540E50")]
			public void HCJANGOBPPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3541530", Offset = "0x3540530", VA = "0x183541530")]
			private void PFMMBGGICPG(IReadOnlyList<GMHCEMDMGBA> CNNICEPGNGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x3541370", Offset = "0x3540370", VA = "0x183541370")]
			public void ODPKGCAACLJ(GMHCEMDMGBA LOIIKGFHHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x3540FD0", Offset = "0x353FFD0", VA = "0x183540FD0")]
			public void NJJBDIOAJKH(IList<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3540BD0", Offset = "0x353FBD0", VA = "0x183540BD0")]
			public void GMBMMGDJFKG(IList<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3540960", Offset = "0x353F960", VA = "0x183540960")]
			private void EPACAPMNOOB(GMHCEMDMGBA LOIIKGFHHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x35404D0", Offset = "0x353F4D0", VA = "0x1835404D0")]
			private void BBDFMCDKAKM(IList<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3540A50", Offset = "0x353FA50", VA = "0x183540A50")]
			private FLILCHFLFHI FODCOGKACKB(GMHCEMDMGBA LOIIKGFHHAA)
			{
				return default(FLILCHFLFHI);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x3541480", Offset = "0x3540480", VA = "0x183541480")]
			public void OPEMIFENIJM(float KGOBMDNKIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x35402D0", Offset = "0x353F2D0", VA = "0x1835402D0")]
			public void AAACLIOCAPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3540780", Offset = "0x353F780", VA = "0x183540780")]
			private void EMNPEAHLJHM(List<GMHCEMDMGBA> JNMOEFOGKLE, Stack<int> HEEKJOEHAOC, bool FIOKCLNDGIF, float KENDNPDMLOG = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3540640", Offset = "0x353F640", VA = "0x183540640", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3541250", Offset = "0x3540250", VA = "0x183541250")]
			private void OAGLBBEDKAL(List<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[NJICLEHHOBN]
		public enum NEIJEKIKDOG
		{
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			PostUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			RigidbodyExLateUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			PreRender,
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			EndOfFrame
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[Flags]
		public enum KINIDGHKMLM : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			Inactive = 0,
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			Running = 1,
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			Cancelled = 2,
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			Paused = 4
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class FKPOAPKAOPL : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463680", VA = "0x180464680")]
			[DebuggerHidden]
			public FKPOAPKAOPL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406640", VA = "0x180407640", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x353F130", Offset = "0x353E130", VA = "0x18353F130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x353F1B0", Offset = "0x353E1B0", VA = "0x18353F1B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private const KINIDGHKMLM BNMLAFJDKKO = KINIDGHKMLM.Cancelled | KINIDGHKMLM.Paused;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly NEIJEKIKDOG[] JFNODFEODBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private GOPOCOOMEIM[] EFAKFPBPKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private IALKDLLHDII[] CMLNDHMENGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private Coroutine JFLDNFIOIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private WaitForEndOfFrame DIJAOOECJCE;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public FNPGPAPOHAN MACMLJJGBIM
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x4055D0", Offset = "0x4045D0", VA = "0x1804055D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public NEIJEKIKDOG BIALLDOGHIO
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x411DF0", Offset = "0x410DF0", VA = "0x180411DF0")]
			[CompilerGenerated]
			get
			{
				return default(NEIJEKIKDOG);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x43EEB0", Offset = "0x43DEB0", VA = "0x18043EEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int JJEKKMDIBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x354B9E0", Offset = "0x354A9E0", VA = "0x18354B9E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x354A8E0", Offset = "0x35498E0", VA = "0x18354A8E0")]
		public static KFBABPAPIMB GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x354A160", Offset = "0x3549160", VA = "0x18354A160", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x354AAC0", Offset = "0x3549AC0", VA = "0x18354AAC0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x24FC0B0", Offset = "0x24FB0B0", VA = "0x1824FC0B0")]
		private GOPOCOOMEIM BMEHNIHAJHK(NEIJEKIKDOG GEDCEIDOKJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x354A880", Offset = "0x3549880", VA = "0x18354A880")]
		private IALKDLLHDII FLPNLDJDNNM(NEIJEKIKDOG GEDCEIDOKJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x354AF50", Offset = "0x3549F50", VA = "0x18354AF50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x354AF20", Offset = "0x3549F20", VA = "0x18354AF20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x354B7E0", Offset = "0x354A7E0", VA = "0x18354B7E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x354AAB0", Offset = "0x3549AB0", VA = "0x18354AAB0")]
		private void NGHDMBGBMLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x354A870", Offset = "0x3549870", VA = "0x18354A870")]
		private void EBCGNHAEELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x354A8C0", Offset = "0x35498C0", VA = "0x18354A8C0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x354A980", Offset = "0x3549980", VA = "0x18354A980")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x354A8D0", Offset = "0x35498D0", VA = "0x18354A8D0")]
		private void GJJOOOJIAAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x354A5F0", Offset = "0x35495F0", VA = "0x18354A5F0")]
		[IteratorStateMachine(typeof(FKPOAPKAOPL))]
		private IEnumerator CHAAKFJCLIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x354B0F0", Offset = "0x354A0F0", VA = "0x18354B0F0")]
		public KFBABPAPIMB Run(IEnumerator<KENFJGFMIPM> GAHCJOMJGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x354B100", Offset = "0x354A100", VA = "0x18354B100")]
		public KFBABPAPIMB Run(Behaviour LHOMKMINCHH, IEnumerator<KENFJGFMIPM> GAHCJOMJGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x354AFC0", Offset = "0x3549FC0", VA = "0x18354AFC0")]
		public KFBABPAPIMB RunJobbed(BPGLFKPKJHF LHOMKMINCHH, IEnumerator<KENFJGFMIPM> GAHCJOMJGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x354A810", Offset = "0x3549810", VA = "0x18354A810")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x354B420", Offset = "0x354A420", VA = "0x18354B420")]
		public void UpdateQueue(NEIJEKIKDOG DKGFKIKFBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x354A650", Offset = "0x3549650", VA = "0x18354A650")]
		private void CLODBMLECIA(GOPOCOOMEIM KAMCDGAHIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x354A990", Offset = "0x3549990", VA = "0x18354A990")]
		private void MNKNBBMICOI(IALKDLLHDII KAMCDGAHIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x354B960", Offset = "0x354A960", VA = "0x18354B960")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface FNPGPAPOHAN
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float EDNCMGJJLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	float FFPPABMIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	float PIBBOFCHMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	int JHNNFDHLJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	double NCBJKCHIKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class CNCOALCNHBC : FNPGPAPOHAN
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float EDNCMGJJLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x353B7E0", Offset = "0x353A7E0", VA = "0x18353B7E0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public float FFPPABMIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x353B7D0", Offset = "0x353A7D0", VA = "0x18353B7D0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float PIBBOFCHMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x353B7F0", Offset = "0x353A7F0", VA = "0x18353B7F0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public int JHNNFDHLJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x353B7C0", Offset = "0x353A7C0", VA = "0x18353B7C0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public double NCBJKCHIKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x353B7A0", Offset = "0x353A7A0", VA = "0x18353B7A0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
	public CNCOALCNHBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class FIFNHIILPEL : HAPBACHHIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public int BIOFILJOKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly Queue<double> PHEJDGHGEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private double FFOJBDNKMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private double PMCAKBEJBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private double OFDBBHKOJKI;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int LINEHPICCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x353F060", Offset = "0x353E060", VA = "0x18353F060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public double OOPCGBFJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x353EF90", Offset = "0x353DF90", VA = "0x18353EF90", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public double GMBEJJBNGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x17418A0", Offset = "0x17408A0", VA = "0x1817418A0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public double JIODMOCKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4290", Offset = "0x2AF3290", VA = "0x182AF4290", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x353F0A0", Offset = "0x353E0A0", VA = "0x18353F0A0")]
	public FIFNHIILPEL(int EPHMNMCMOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x353EE90", Offset = "0x353DE90", VA = "0x18353EE90", Slot = "4")]
	public void EHGIOHLBHJN(double MBJCIBHEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x353EFF0", Offset = "0x353DFF0", VA = "0x18353EFF0", Slot = "5")]
	public void JBBLIBHHEBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class ABHKLOENLLE : HAPBACHHIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private long MNIJHBJDPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private double ILPMEPPIJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double OMGFKNCEEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private double BHEKBIIIJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private double BEJJCLLNDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private double FFOJBDNKMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private double PMCAKBEJBFN;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long MEPGPGKFENE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3F6000", Offset = "0x3F5000", VA = "0x1803F6000")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public double GMBEJJBNGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x462170", Offset = "0x461170", VA = "0x180462170", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public double JIODMOCKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4300", Offset = "0x2AF3300", VA = "0x182AF4300", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public double GGEADKGMGDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4290", Offset = "0x2AF3290", VA = "0x182AF4290")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public double JDPBPFKMGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x314B670", Offset = "0x314A670", VA = "0x18314B670")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public double OOPCGBFJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF41C0", Offset = "0x2AF31C0", VA = "0x182AF41C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3539DC0", Offset = "0x3538DC0", VA = "0x183539DC0", Slot = "4")]
	public void EHGIOHLBHJN(double MBJCIBHEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3539EE0", Offset = "0x3538EE0", VA = "0x183539EE0", Slot = "5")]
	public void JBBLIBHHEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3539F20", Offset = "0x3538F20", VA = "0x183539F20")]
	public ABHKLOENLLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface HAPBACHHIBN
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	double OOPCGBFJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	double GMBEJJBNGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	double JIODMOCKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHGIOHLBHJN(double MBJCIBHEOMM);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBBLIBHHEBC();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class LJLGDKLOFMO
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private interface OJCONDGBEIA
	{
		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		bool MMICKFMMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OOOIENHGNCA();

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KBPKIDJEOFB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private abstract class JDIOECLPOPK<TPromise, TMainThreadPromise> : OJCONDGBEIA where TPromise : DABKFAIHBBP where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private readonly TPromise GMLHFPFHBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		protected readonly TMainThreadPromise IDAPKKELNMM;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public TPromise DENADOGFMKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x1FF7DA0", Offset = "0x1FF6DA0", VA = "0x181FF7DA0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool MMICKFMMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1FF7D50", Offset = "0x1FF6D50", VA = "0x181FF7D50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x1A04210", Offset = "0x1A03210", VA = "0x181A04210")]
		protected JDIOECLPOPK(TPromise GMLHFPFHBJD, TMainThreadPromise BLFADPCOALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1FF7E00", Offset = "0x1FF6E00", VA = "0x181FF7E00", Slot = "5")]
		public void OOOIENHGNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1A2AED0", Offset = "0x1A29ED0", VA = "0x181A2AED0", Slot = "6")]
		public void KBPKIDJEOFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void AMPLEOCGJBM(TPromise GMLHFPFHBJD);

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void GHCAGDCCIPD();
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class BCAIFPDOAMM<T> : JDIOECLPOPK<global::PMGCJEPKFOF<T>, global::CBLLFJEDOII<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x1FF5130", Offset = "0x1FF4130", VA = "0x181FF5130")]
		public BCAIFPDOAMM(global::PMGCJEPKFOF<T> GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FF4C90", Offset = "0x1FF3C90", VA = "0x181FF4C90", Slot = "7")]
		protected override void AMPLEOCGJBM(global::PMGCJEPKFOF<T> GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x1FF5060", Offset = "0x1FF4060", VA = "0x181FF5060", Slot = "8")]
		protected override void GHCAGDCCIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1FF50C0", Offset = "0x1FF40C0", VA = "0x181FF50C0")]
		[CompilerGenerated]
		private void NIJANLDDIMP(T GIAOBLMEMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1FF4FD0", Offset = "0x1FF3FD0", VA = "0x181FF4FD0")]
		[CompilerGenerated]
		private void FGCPLDIEGKO(string MOPOMPHBHKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class EHEDHJDLBCH : JDIOECLPOPK<DABKFAIHBBP, JJEKJGALHKO>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x353DBA0", Offset = "0x353CBA0", VA = "0x18353DBA0")]
		public EHEDHJDLBCH(DABKFAIHBBP GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x353DA80", Offset = "0x353CA80", VA = "0x18353DA80", Slot = "7")]
		protected override void AMPLEOCGJBM(DABKFAIHBBP GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x353DB50", Offset = "0x353CB50", VA = "0x18353DB50", Slot = "8")]
		protected override void GHCAGDCCIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xC16B60", Offset = "0xC15B60", VA = "0x180C16B60")]
		[CompilerGenerated]
		private void NIJANLDDIMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x148A220", Offset = "0x1489220", VA = "0x18148A220")]
		[CompilerGenerated]
		private void FGCPLDIEGKO(string MOPOMPHBHKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class HLPAFHONKPA : OJCONDGBEIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly Action JJGHIEJCCDA;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool MMICKFMMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x47F7D0", Offset = "0x47E7D0", VA = "0x18047F7D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x41E770", Offset = "0x41D770", VA = "0x18041E770")]
		public HLPAFHONKPA(Action JJGHIEJCCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x131D7D0", Offset = "0x131C7D0", VA = "0x18131D7D0", Slot = "5")]
		public void OOOIENHGNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406640", VA = "0x180407640", Slot = "6")]
		public void KBPKIDJEOFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly List<OJCONDGBEIA> GEONEIIGPNH;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1EF8A10", Offset = "0x1EF7A10", VA = "0x181EF8A10")]
	public static global::PMGCJEPKFOF<T> DNMKIEAJOJH<T>(this global::PMGCJEPKFOF<T> GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3547C00", Offset = "0x3546C00", VA = "0x183547C00")]
	public static DABKFAIHBBP DNMKIEAJOJH(this DABKFAIHBBP GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3547B80", Offset = "0x3546B80", VA = "0x183547B80")]
	public static void DNMKIEAJOJH(Action JJGHIEJCCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1EF8AF0", Offset = "0x1EF7AF0", VA = "0x181EF8AF0")]
	private static global::PMGCJEPKFOF<T> LINADCCOBCC<T>(global::PMGCJEPKFOF<T> GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3548070", Offset = "0x3547070", VA = "0x183548070")]
	private static DABKFAIHBBP LINADCCOBCC(DABKFAIHBBP GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x3547E90", Offset = "0x3546E90", VA = "0x183547E90")]
	private static void IIGMDIHDNJD(OJCONDGBEIA BKCGDDGIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3547860", Offset = "0x3546860", VA = "0x183547860")]
	private static void COAPLNGMFKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3547D10", Offset = "0x3546D10", VA = "0x183547D10")]
	private static void EHDOBJFCNEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3547DE0", Offset = "0x3546DE0", VA = "0x183547DE0")]
	private static void HLHALAIDKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class OEGOFBEELGL
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class LHAKBAAEPCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JJEKJGALHKO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
		public LHAKBAAEPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3547680", Offset = "0x3546680", VA = "0x183547680")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3547670", Offset = "0x3546670", VA = "0x183547670")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GAILAHGLKML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
		public GAILAHGLKML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x353F300", Offset = "0x353E300", VA = "0x18353F300")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class HGHALIPAJMI : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public JJEKJGALHKO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463680", VA = "0x180464680")]
		[DebuggerHidden]
		public HGHALIPAJMI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3541E10", Offset = "0x3540E10", VA = "0x183541E10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3541B00", Offset = "0x3540B00", VA = "0x183541B00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3541EC0", Offset = "0x3540EC0", VA = "0x183541EC0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3541DC0", Offset = "0x3540DC0", VA = "0x183541DC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class MDIANADNKIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JJEKJGALHKO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
		public MDIANADNKIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class GBMMKEHDBLM : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public JJEKJGALHKO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private MDIANADNKIJ <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4045B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463680", VA = "0x180464680")]
		[DebuggerHidden]
		public GBMMKEHDBLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406640", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x353F330", Offset = "0x353E330", VA = "0x18353F330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x353F570", Offset = "0x353E570", VA = "0x18353F570", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public const string LLDNCJNLPGL = "empty";

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public const string BMCBAGEGBLI = "moderator";

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public const string AFKGHCNJPBB = "main_root";

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public const string PGIAKFDKOEH = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public const string OPEMHLDGDEA = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private const float IIHEIALMGIP = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static DABKFAIHBBP HPLJCGDFOOG;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static AsyncOperation NIELPFKCFMF;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static DABKFAIHBBP KBKDKPGIECD;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static string DBKMPGMOIKP;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static ThreadPriority PPCENOLHKDB;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public static bool CCEJLKMLKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3548BE0", Offset = "0x3547BE0", VA = "0x183548BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private static bool KLFONPCEKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3548E90", Offset = "0x3547E90", VA = "0x183548E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private static bool JMIHDNFOODM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3548EF0", Offset = "0x3547EF0", VA = "0x183548EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3548A30", Offset = "0x3547A30", VA = "0x183548A30")]
	public static DABKFAIHBBP BBOHJKKLCKO(string PCBCJKHMBGL, LoadSceneMode GNOCFLPOFIB = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x3548C80", Offset = "0x3547C80", VA = "0x183548C80")]
	public static DABKFAIHBBP DGIJOCFANHH(string PCBCJKHMBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x3548B70", Offset = "0x3547B70", VA = "0x183548B70")]
	[IteratorStateMachine(typeof(HGHALIPAJMI))]
	private static IEnumerator<KENFJGFMIPM> CKBLIMMFGLM(string PCBCJKHMBGL, JJEKJGALHKO OCHKEPDILKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x35489B0", Offset = "0x35479B0", VA = "0x1835489B0")]
	[IteratorStateMachine(typeof(GBMMKEHDBLM))]
	private static IEnumerator<KENFJGFMIPM> AJDIEMKKFGG(string PCBCJKHMBGL, LoadSceneMode GNOCFLPOFIB, JJEKJGALHKO OCHKEPDILKF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class FFAFDAOBAHN
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static byte[] OHCLMBBDJLC;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static int NJPHPOMKGAO;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static int NCHLFMFMLBC;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static BigInteger AEEDJIDCNEO;

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x353E640", Offset = "0x353D640", VA = "0x18353E640")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x353E740", Offset = "0x353D740", VA = "0x18353E740")]
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

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FD660", VA = "0x1803FE660")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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

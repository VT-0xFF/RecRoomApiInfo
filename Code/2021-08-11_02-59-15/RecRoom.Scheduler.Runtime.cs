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
				[Cpp2IlInjected.Address(RVA = "0x354A160", Offset = "0x3549560", VA = "0x18354A160")]
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
				[Cpp2IlInjected.Address(RVA = "0x353EDD0", Offset = "0x353E1D0", VA = "0x18353EDD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x353DA80", Offset = "0x353CE80", VA = "0x18353DA80")]
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
					[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
					public JNDDNMLJFDO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x3546110", Offset = "0x3545510", VA = "0x183546110")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDisposable DFHFIANOKID;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x353E6F0", Offset = "0x353DAF0", VA = "0x18353E6F0")]
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
					[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
					public FGHMPJKFPEE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x353EF80", Offset = "0x353E380", VA = "0x18353EF80")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x353D980", Offset = "0x353CD80", VA = "0x18353D980")]
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
			[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
			public MEHOILAECLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3548490", Offset = "0x3547890", VA = "0x183548490")]
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
			[Cpp2IlInjected.Address(RVA = "0x353D2F0", Offset = "0x353C6F0", VA = "0x18353D2F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x353CF50", Offset = "0x353C350", VA = "0x18353CF50")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x353C100", Offset = "0x353B500", VA = "0x18353C100")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x353CF90", Offset = "0x353C390", VA = "0x18353CF90")]
		private static void KHFAOCKFOMG(ELGIGKJCDID.PEEOJJCEFPE DNGKIAJLLHG, ref PlayerLoopSystem INJAGKJAPKC, Type IAFJLDHNNAG, Type MCNLGODIENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x353D330", Offset = "0x353C730", VA = "0x18353D330")]
		private static void PIDOJLLLMLO(ref PlayerLoopSystem INJAGKJAPKC, Type IAFJLDHNNAG, Type MCNLGODIENM, AHJIPNEIGPG BNLLHBCJFOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x353D1F0", Offset = "0x353C5F0", VA = "0x18353D1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x353E5F0", Offset = "0x353D9F0", VA = "0x18353E5F0")]
		public FDGHJJOBMOD(PEEOJJCEFPE DOOFHEFHHGI, int NMIMOBMHDAF = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x353E3D0", Offset = "0x353D7D0", VA = "0x18353E3D0")]
		public void BLFLBLDMBBK(int AAEANOFBLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x353E3F0", Offset = "0x353D7F0", VA = "0x18353E3F0")]
		public void HFJPBHFKHPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x353E3A0", Offset = "0x353D7A0", VA = "0x18353E3A0")]
		public void BAPLIBPCJLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x353E4B0", Offset = "0x353D8B0", VA = "0x18353E4B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x353DDC0", Offset = "0x353D1C0", VA = "0x18353DDC0")]
	public static FDGHJJOBMOD AKFOAKIHIBH(PEEOJJCEFPE DNGKIAJLLHG, int NMIMOBMHDAF = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x353DF80", Offset = "0x353D380", VA = "0x18353DF80")]
	public static FDGHJJOBMOD CCOLPLDBPEN(PEEOJJCEFPE DNGKIAJLLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x353E010", Offset = "0x353D410", VA = "0x18353E010")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
		public CLKPFIJHGLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x353B920", Offset = "0x353AD20", VA = "0x18353B920")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
		public OGBHHMOKMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x353B920", Offset = "0x353AD20", VA = "0x18353B920")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly float IFDHHDIIAAG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x353B8D0", Offset = "0x353ACD0", VA = "0x18353B8D0")]
	public DECOBNDCNFA(Behaviour LHOMKMINCHH, float IFDHHDIIAAG, [Optional] Action EJAIEDPNOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x353D7E0", Offset = "0x353CBE0", VA = "0x18353D7E0", Slot = "9")]
	protected override bool EEJEOHAODHB(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x353D8B0", Offset = "0x353CCB0", VA = "0x18353D8B0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
		[DebuggerHidden]
		public MHJIDBHBMGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3548590", Offset = "0x3547990", VA = "0x183548590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3548630", Offset = "0x3547A30", VA = "0x183548630", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B09D0", Offset = "0x5AFDD0", VA = "0x1805B09D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OGODIKKKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3542160", Offset = "0x3541560", VA = "0x183542160", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x35420C0", Offset = "0x35414C0", VA = "0x1835420C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1943730", Offset = "0x1942B30", VA = "0x181943730")]
	protected HOMBMCGGPOD(Behaviour LHOMKMINCHH, [Optional] Action EJAIEDPNOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35424E0", Offset = "0x35418E0", VA = "0x1835424E0", Slot = "7")]
	public bool PFFOFIHGOEA(bool CDFHDACBFKN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3542540", Offset = "0x3541940", VA = "0x183542540", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3542200", Offset = "0x3541600", VA = "0x183542200")]
	protected void HLOEPMHHGKE(Action JJGHIEJCCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3542310", Offset = "0x3541710", VA = "0x183542310")]
	protected DABKFAIHBBP PAAAGNNFMLG(float BJJEDIGOMGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x35422A0", Offset = "0x35416A0", VA = "0x1835422A0")]
	private void KDPCHEJAGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3542220", Offset = "0x3541620", VA = "0x183542220")]
	[IteratorStateMachine(typeof(MHJIDBHBMGM))]
	private static IEnumerator<KENFJGFMIPM> HOPCEMPGALM(float BJJEDIGOMGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3542280", Offset = "0x3541680", VA = "0x183542280")]
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
		[Cpp2IlInjected.Address(RVA = "0x4129C0", Offset = "0x411DC0", VA = "0x1804129C0")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4059F0", Offset = "0x404DF0", VA = "0x1804059F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x354A050", Offset = "0x3549450", VA = "0x18354A050")]
	public PHJNILKEAAI(Behaviour LHOMKMINCHH, float JHPBDEKPCKP, int OFOIBLJPHGE, [Optional] Action EJAIEDPNOIG, float DNHGIAAFCLE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x406060", Offset = "0x405460", VA = "0x180406060", Slot = "9")]
	protected override bool EEJEOHAODHB(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3549DA0", Offset = "0x35491A0", VA = "0x183549DA0", Slot = "10")]
	protected override bool KLJHDBCCABK(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3549FC0", Offset = "0x35493C0", VA = "0x183549FC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x353B8D0", Offset = "0x353ACD0", VA = "0x18353B8D0")]
	public CKNNCLNMAPG(Behaviour LHOMKMINCHH, float IFDHHDIIAAG, [Optional] Action EJAIEDPNOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x406060", Offset = "0x405460", VA = "0x180406060", Slot = "9")]
	protected override bool EEJEOHAODHB(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x353B890", Offset = "0x353AC90", VA = "0x18353B890", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x41E770", Offset = "0x41DB70", VA = "0x18041E770")]
	public GHMCDEEFOLC(Action NGEMKGIAPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x353FDC0", Offset = "0x353F1C0", VA = "0x18353FDC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x12B5D40", Offset = "0x12B5140", VA = "0x1812B5D40")]
		public GCFGNJEEJPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x24D6930", Offset = "0x24D5D30", VA = "0x1824D6930")]
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
		[Cpp2IlInjected.Address(RVA = "0x24DBBB0", Offset = "0x24DAFB0", VA = "0x1824DBBB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T DMLIOOCLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x44AE00", Offset = "0x44A200", VA = "0x18044AE00", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x24DB410", Offset = "0x24DA810", VA = "0x1824DB410", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x24DB500", Offset = "0x24DA900", VA = "0x1824DB500")]
	private static bool LPHFKINGMHN(T IPHIIJNAEON, T FOJLJNMAJLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x24DC010", Offset = "0x24DB410", VA = "0x1824DC010")]
	public KAGJDGDAADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x24DC0D0", Offset = "0x24DB4D0", VA = "0x1824DC0D0")]
	public KAGJDGDAADK(T KMHEHJCNMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x24DBFF0", Offset = "0x24DB3F0", VA = "0x1824DBFF0")]
	public void MOCMFLAMJHA(T BCEFAKDFEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x24DB260", Offset = "0x24DA660", VA = "0x1824DB260", Slot = "7")]
	public IDisposable JAHAHHAFAPC(Action<T> CCHCBCLCFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x24DB2D0", Offset = "0x24DA6D0", VA = "0x1824DB2D0", Slot = "8")]
	public IDisposable JAHAHHAFAPC(UnityEngine.Object LHOMKMINCHH, Action<T> CCHCBCLCFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x24DB890", Offset = "0x24DAC90", VA = "0x1824DB890")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
		[DebuggerHidden]
		public LFCPKFJPOEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3547730", Offset = "0x3546B30", VA = "0x183547730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x35477D0", Offset = "0x3546BD0", VA = "0x1835477D0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
		public COMHPOBAMNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x353B9B0", Offset = "0x353ADB0", VA = "0x18353B9B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
		[DebuggerHidden]
		public AGKDIHPOJIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x353ADA0", Offset = "0x353A1A0", VA = "0x18353ADA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x353AE90", Offset = "0x353A290", VA = "0x18353AE90", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3547420", Offset = "0x3546820", VA = "0x183547420")]
	public static KENFJGFMIPM LEIMHFLNIKB(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x35473B0", Offset = "0x35467B0", VA = "0x1835473B0")]
	[IteratorStateMachine(typeof(LFCPKFJPOEA))]
	public static IEnumerator<KENFJGFMIPM> FDHJPDHIMME(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3547500", Offset = "0x3546900", VA = "0x183547500")]
	public static KENFJGFMIPM LINOLLIBDCO(Func<bool> LKMLNOJIFHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3547560", Offset = "0x3546960", VA = "0x183547560")]
	public static KENFJGFMIPM OPDGBNPLNHG(DABKFAIHBBP NKLGAGCHGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3547360", Offset = "0x3546760", VA = "0x183547360")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
		[DebuggerHidden]
		public KBIEPEFBMPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3546190", Offset = "0x3545590", VA = "0x183546190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3546260", Offset = "0x3545660", VA = "0x183546260", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
		[DebuggerHidden]
		public DDPJLKFDDNM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x353D6A0", Offset = "0x353CAA0", VA = "0x18353D6A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x353D790", Offset = "0x353CB90", VA = "0x18353D790", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x410090", Offset = "0x40F490", VA = "0x180410090", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4059D0", Offset = "0x404DD0", VA = "0x1804059D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8B0980", Offset = "0x8AFD80", VA = "0x1808B0980", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
	public CPHEMJCNNDB(Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x47F7D0", Offset = "0x47EBD0", VA = "0x18047F7D0", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x353BD10", Offset = "0x353B110", VA = "0x18353BD10")]
	public static KFBABPAPIMB GIEOOLAGCKA(Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x353BC20", Offset = "0x353B020", VA = "0x18353BC20")]
	public static KFBABPAPIMB GIEOOLAGCKA(Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x353BF10", Offset = "0x353B310", VA = "0x18353BF10")]
	public static KFBABPAPIMB GIEOOLAGCKA(Behaviour LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x353BE00", Offset = "0x353B200", VA = "0x18353BE00")]
	public static KFBABPAPIMB GIEOOLAGCKA(Behaviour LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x353BB10", Offset = "0x353AF10", VA = "0x18353BB10")]
	public static KFBABPAPIMB DJJOEODIBEE(BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x353BA00", Offset = "0x353AE00", VA = "0x18353BA00")]
	public static KFBABPAPIMB DJJOEODIBEE(BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x353C090", Offset = "0x353B490", VA = "0x18353C090")]
	[IteratorStateMachine(typeof(KBIEPEFBMPJ))]
	private static IEnumerator<KENFJGFMIPM> OKAOGDPNEKD(Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x353C020", Offset = "0x353B420", VA = "0x18353C020")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
		[DebuggerHidden]
		public NIOKFBABMOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x35486C0", Offset = "0x3547AC0", VA = "0x1835486C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3548860", Offset = "0x3547C60", VA = "0x183548860", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CED40", Offset = "0x8CE140", VA = "0x1808CED40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x85CDE0", Offset = "0x85C1E0", VA = "0x18085CDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x411DF0", Offset = "0x4111F0", VA = "0x180411DF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x43EEB0", Offset = "0x43E2B0", VA = "0x18043EEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE20", Offset = "0x8CE220", VA = "0x1808CEE20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFE0", Offset = "0x8CE3E0", VA = "0x1808CEFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float FFPPABMIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8CF000", Offset = "0x8CE400", VA = "0x1808CF000")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8CED50", Offset = "0x8CE150", VA = "0x1808CED50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x353B2D0", Offset = "0x353A6D0", VA = "0x18353B2D0")]
	public BECNBPANOEI(float CKGGPPMDDBP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x353AF70", Offset = "0x353A370", VA = "0x18353AF70", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x353B240", Offset = "0x353A640", VA = "0x18353B240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x353AF90", Offset = "0x353A390", VA = "0x18353AF90")]
	public static KFBABPAPIMB GIEOOLAGCKA(float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x353B040", Offset = "0x353A440", VA = "0x18353B040")]
	public static KFBABPAPIMB GIEOOLAGCKA(MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x353B100", Offset = "0x353A500", VA = "0x18353B100")]
	public static KFBABPAPIMB HFKCNODKFKG(BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x353B1C0", Offset = "0x353A5C0", VA = "0x18353B1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FA4F0", Offset = "0x3F98F0", VA = "0x1803FA4F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x43E290", Offset = "0x43D690", VA = "0x18043E290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8CED40", Offset = "0x8CE140", VA = "0x1808CED40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x85CDE0", Offset = "0x85C1E0", VA = "0x18085CDE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x353E220", Offset = "0x353D620", VA = "0x18353E220")]
	public ENKGACHBJCJ(Func<bool> LKMLNOJIFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x353E250", Offset = "0x353D650", VA = "0x18353E250")]
	public ENKGACHBJCJ(Scheduler.NEIJEKIKDOG CKFELIAJKCP, Func<bool> LKMLNOJIFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x353E1D0", Offset = "0x353D5D0", VA = "0x18353E1D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
		[DebuggerHidden]
		public NONJFBJHGEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x35488B0", Offset = "0x3547CB0", VA = "0x1835488B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3548950", Offset = "0x3547D50", VA = "0x183548950", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x35489A0", Offset = "0x3547DA0", VA = "0x1835489A0")]
	[IteratorStateMachine(typeof(NONJFBJHGEM))]
	private static IEnumerator<KENFJGFMIPM> AGGNPLMDKGE(Scheduler.NEIJEKIKDOG CKFELIAJKCP, Func<bool> LKMLNOJIFHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3548A10", Offset = "0x3547E10", VA = "0x183548A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B3600", Offset = "0x4B2A00", VA = "0x1804B3600", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x595690", Offset = "0x594A90", VA = "0x180595690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFF0", Offset = "0x8CE3F0", VA = "0x1808CEFF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x879A20", Offset = "0x878E20", VA = "0x180879A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3546060", Offset = "0x3545460", VA = "0x183546060")]
	public JMOPCCPBNMB(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3545FD0", Offset = "0x35453D0", VA = "0x183545FD0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
		[DebuggerHidden]
		public CHFAJCJLJLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x353B790", Offset = "0x353AB90", VA = "0x18353B790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x353B840", Offset = "0x353AC40", VA = "0x18353B840", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
		[DebuggerHidden]
		public EOMJHPHEMLH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x353E290", Offset = "0x353D690", VA = "0x18353E290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x353E350", Offset = "0x353D750", VA = "0x18353E350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3545710", Offset = "0x3544B10", VA = "0x183545710")]
	[IteratorStateMachine(typeof(CHFAJCJLJLB))]
	private static IEnumerator<KENFJGFMIPM> HEBGBPGEFPK(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3545520", Offset = "0x3544920", VA = "0x183545520")]
	[IteratorStateMachine(typeof(EOMJHPHEMLH))]
	private static IEnumerator<KENFJGFMIPM> DBNBNAILAFO(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3545D00", Offset = "0x3545100", VA = "0x183545D00")]
	public static IDisposable PBPKBANPKJP(this MonoBehaviour BKGIHIBDAPA, float HABFNPMBADP, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x35455B0", Offset = "0x35449B0", VA = "0x1835455B0")]
	public static KFBABPAPIMB ENFHDIBGOEO(this MonoBehaviour BKGIHIBDAPA, float HABFNPMBADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3545E40", Offset = "0x3545240", VA = "0x183545E40")]
	public static KFBABPAPIMB PBPKBANPKJP(this MonoBehaviour BKGIHIBDAPA, float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x35456F0", Offset = "0x3544AF0", VA = "0x1835456F0")]
	public static KFBABPAPIMB FHKNPABNEEM(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3545790", Offset = "0x3544B90", VA = "0x183545790")]
	public static KFBABPAPIMB HECMPBHFOEA(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x35455A0", Offset = "0x35449A0", VA = "0x1835455A0")]
	public static KFBABPAPIMB EGOJDKEBMNH(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3545700", Offset = "0x3544B00", VA = "0x183545700")]
	public static KFBABPAPIMB GGGCLEIGKCE(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x35458B0", Offset = "0x3544CB0", VA = "0x1835458B0")]
	public static KFBABPAPIMB JGIPMJPPCBM(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3545410", Offset = "0x3544810", VA = "0x183545410")]
	private static KFBABPAPIMB AKNLAJLAGMB(MonoBehaviour BKGIHIBDAPA, Scheduler.NEIJEKIKDOG CKFELIAJKCP, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3545AE0", Offset = "0x3544EE0", VA = "0x183545AE0")]
	public static KFBABPAPIMB NLBLFPBOCLD(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3545BF0", Offset = "0x3544FF0", VA = "0x183545BF0")]
	public static KFBABPAPIMB PAKNHKEKDAF(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x35457A0", Offset = "0x3544BA0", VA = "0x1835457A0")]
	public static KFBABPAPIMB INLJFAKDKAD(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x35459D0", Offset = "0x3544DD0", VA = "0x1835459D0")]
	public static KFBABPAPIMB LBLNPIDACFM(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x35458C0", Offset = "0x3544CC0", VA = "0x1835458C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
		[DebuggerHidden]
		public ILPPIMNIHBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3545310", Offset = "0x3544710", VA = "0x183545310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x35453C0", Offset = "0x35447C0", VA = "0x1835453C0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3545180", Offset = "0x3544580", VA = "0x183545180")]
	public ICMKAJELBGE(MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3544EA0", Offset = "0x35442A0", VA = "0x183544EA0")]
	public ICMKAJELBGE(MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3545030", Offset = "0x3544430", VA = "0x183545030")]
	public ICMKAJELBGE(MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3544AD0", Offset = "0x3543ED0", VA = "0x183544AD0")]
	private void GIEOOLAGCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x35448D0", Offset = "0x3543CD0", VA = "0x1835448D0")]
	private void EBPHAECHJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3544C50", Offset = "0x3544050", VA = "0x183544C50")]
	private void HCMLBCFDNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3544D80", Offset = "0x3544180", VA = "0x183544D80")]
	private void KEECGEIFLEN(string MOPOMPHBHKF, Action HGGDFJNNBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3544820", Offset = "0x3543C20", VA = "0x183544820")]
	[IteratorStateMachine(typeof(ILPPIMNIHBJ))]
	private IEnumerator<KENFJGFMIPM> DEJICBOKAJH(Action HGGDFJNNBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3544880", Offset = "0x3543C80", VA = "0x183544880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x35447A0", Offset = "0x3543BA0", VA = "0x1835447A0")]
	[CompilerGenerated]
	private void CKHMLHHHCLN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3544720", Offset = "0x3543B20", VA = "0x183544720")]
	[CompilerGenerated]
	private void CBBGHNELPMN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3544A50", Offset = "0x3543E50", VA = "0x183544A50")]
	[CompilerGenerated]
	private void GGEOKDFDCNK(string CHKKEHOKPJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class ADIFCODGAML
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x353A8C0", Offset = "0x3539CC0", VA = "0x18353A8C0")]
	public static IDisposable GIEOOLAGCKA(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x353A700", Offset = "0x3539B00", VA = "0x18353A700")]
	public static IDisposable GIEOOLAGCKA(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x353AD30", Offset = "0x353A130", VA = "0x18353AD30")]
	public static IDisposable OPEMIFENIJM(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x353ABC0", Offset = "0x3539FC0", VA = "0x18353ABC0")]
	public static IDisposable MOJAICCOOMH(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x353AC30", Offset = "0x353A030", VA = "0x18353AC30")]
	public static IDisposable OEMBBKDJFCB(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x353A510", Offset = "0x3539910", VA = "0x18353A510")]
	public static IDisposable FHBCIFNCNMN(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x353A9C0", Offset = "0x3539DC0", VA = "0x18353A9C0")]
	public static IDisposable JEEMKGCKHKD(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x353AA30", Offset = "0x3539E30", VA = "0x18353AA30")]
	public static IDisposable LAHBIDHMCKF(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x353A580", Offset = "0x3539980", VA = "0x18353A580")]
	public static IDisposable FLMKKKHMJBN(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x353A180", Offset = "0x3539580", VA = "0x18353A180")]
	public static IDisposable AMNODMIDNHO(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x353A940", Offset = "0x3539D40", VA = "0x18353A940")]
	public static IDisposable ICPMHNDIIFK(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x353A400", Offset = "0x3539800", VA = "0x18353A400")]
	public static IDisposable ENLMJBCKILF(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x353A680", Offset = "0x3539A80", VA = "0x18353A680")]
	public static IDisposable FOFJADGKNJF(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x353AAC0", Offset = "0x3539EC0", VA = "0x18353AAC0")]
	public static IDisposable LFJPCEKGMIA(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x353A100", Offset = "0x3539500", VA = "0x18353A100")]
	public static IDisposable ADIDJGEIJOH(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x353ACA0", Offset = "0x353A0A0", VA = "0x18353ACA0")]
	public static IDisposable OIJBBPIBIJP(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x353A280", Offset = "0x3539680", VA = "0x18353A280")]
	public static IDisposable AOPHLNHDOKN(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x353A300", Offset = "0x3539700", VA = "0x18353A300")]
	public static IDisposable BOHBPECGHLI(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x353A600", Offset = "0x3539A00", VA = "0x18353A600")]
	public static IDisposable FNFEBJPKPEA(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x353A480", Offset = "0x3539880", VA = "0x18353A480")]
	public static IDisposable FGFJPAFFKIN(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x353A380", Offset = "0x3539780", VA = "0x18353A380")]
	public static IDisposable CHFECAOLPEO(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x353AB40", Offset = "0x3539F40", VA = "0x18353AB40")]
	public static IDisposable LGJLMMIHFON(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x353A200", Offset = "0x3539600", VA = "0x18353A200")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
		[DebuggerHidden]
		public FNFBHFJCFAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x353F3B0", Offset = "0x353E7B0", VA = "0x18353F3B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x353F460", Offset = "0x353E860", VA = "0x18353F460", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x35498C0", Offset = "0x3548CC0", VA = "0x1835498C0")]
	public OLKNGLHPDJE(BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3549BA0", Offset = "0x3548FA0", VA = "0x183549BA0")]
	public OLKNGLHPDJE(BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3549A50", Offset = "0x3548E50", VA = "0x183549A50")]
	public OLKNGLHPDJE(BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x35494F0", Offset = "0x35488F0", VA = "0x1835494F0")]
	private void GIEOOLAGCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x35492F0", Offset = "0x35486F0", VA = "0x1835492F0")]
	private void EBPHAECHJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3549670", Offset = "0x3548A70", VA = "0x183549670")]
	private void HCMLBCFDNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x35497A0", Offset = "0x3548BA0", VA = "0x1835497A0")]
	private void KEECGEIFLEN(string MOPOMPHBHKF, Action HGGDFJNNBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3549240", Offset = "0x3548640", VA = "0x183549240")]
	[IteratorStateMachine(typeof(FNFBHFJCFAI))]
	private IEnumerator<KENFJGFMIPM> DEJICBOKAJH(Action HGGDFJNNBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x35492A0", Offset = "0x35486A0", VA = "0x1835492A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x35491C0", Offset = "0x35485C0", VA = "0x1835491C0")]
	[CompilerGenerated]
	private void CKHMLHHHCLN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3549140", Offset = "0x3548540", VA = "0x183549140")]
	[CompilerGenerated]
	private void CBBGHNELPMN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3549470", Offset = "0x3548870", VA = "0x183549470")]
	[CompilerGenerated]
	private void GGEOKDFDCNK(string CHKKEHOKPJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class KCBPNKMEDPI
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x35466F0", Offset = "0x3545AF0", VA = "0x1835466F0")]
	public static IDisposable DJJOEODIBEE(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3546530", Offset = "0x3545930", VA = "0x183546530")]
	public static IDisposable DJJOEODIBEE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3546770", Offset = "0x3545B70", VA = "0x183546770")]
	public static IDisposable EMGJKCCEAJA(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x35468E0", Offset = "0x3545CE0", VA = "0x1835468E0")]
	public static IDisposable GJCJNLFFLKP(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3546870", Offset = "0x3545C70", VA = "0x183546870")]
	public static IDisposable GAPIDOHIBLG(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x35463D0", Offset = "0x35457D0", VA = "0x1835463D0")]
	public static IDisposable CAJKNLABPBH(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x35464C0", Offset = "0x35458C0", VA = "0x1835464C0")]
	public static IDisposable DGFNIKAEGMI(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x35467E0", Offset = "0x3545BE0", VA = "0x1835467E0")]
	public static IDisposable EOGNMLDAMCK(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3546D50", Offset = "0x3546150", VA = "0x183546D50")]
	public static IDisposable PBDKGIJCPCG(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3546B50", Offset = "0x3545F50", VA = "0x183546B50")]
	public static IDisposable MHPNCCEFCID(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3546950", Offset = "0x3545D50", VA = "0x183546950")]
	public static IDisposable HNFGDIHEFIO(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3546CD0", Offset = "0x35460D0", VA = "0x183546CD0")]
	public static IDisposable ONEBONJNMNK(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3546340", Offset = "0x3545740", VA = "0x183546340")]
	public static IDisposable BNJMDNLEDJB(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x35469D0", Offset = "0x3545DD0", VA = "0x1835469D0")]
	public static IDisposable IPPHMOEKHMO(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3546BD0", Offset = "0x3545FD0", VA = "0x183546BD0")]
	public static IDisposable NIIGGNNJAGE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3546C50", Offset = "0x3546050", VA = "0x183546C50")]
	public static IDisposable OBEEJIAEFKM(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x35462B0", Offset = "0x35456B0", VA = "0x1835462B0")]
	public static IDisposable AGEPHCFGCMM(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3546440", Offset = "0x3545840", VA = "0x183546440")]
	public static IDisposable CEILCDDBJHP(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3546AD0", Offset = "0x3545ED0", VA = "0x183546AD0")]
	public static IDisposable LJOHGJJMOGE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3546A50", Offset = "0x3545E50", VA = "0x183546A50")]
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
				[Cpp2IlInjected.Address(RVA = "0x410090", Offset = "0x40F490", VA = "0x180410090", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x4059D0", Offset = "0x404DD0", VA = "0x1804059D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x353B630", Offset = "0x353AA30", VA = "0x18353B630")]
			public static KENFJGFMIPM NEPONCICACF(IEnumerator<KENFJGFMIPM> LOIIKGFHHAA, OMNCINDCAAJ NKLGAGCHGPM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x353B560", Offset = "0x353A960", VA = "0x18353B560")]
			public KENFJGFMIPM NEPONCICACF(OMNCINDCAAJ[] LMOONNDFEPE, IEnumerator<KENFJGFMIPM>[] JNMOEFOGKLE, KENFJGFMIPM[] DHGHPJHPPGE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x353B530", Offset = "0x353A930", VA = "0x18353B530")]
			public void HNDCKFDJEKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x353B470", Offset = "0x353A870", VA = "0x18353B470")]
			public void CMDNNKIMLED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x353B3B0", Offset = "0x353A7B0", VA = "0x18353B3B0")]
			public void AKIBJAOAEFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x353B530", Offset = "0x353A930", VA = "0x18353B530")]
			public void KBPKIDJEOFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
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
				[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
				public GHLCIHPNOIJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x353F770", Offset = "0x353EB70", VA = "0x18353F770")]
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
				[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
				public JKHIMOPAHLJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x3545F90", Offset = "0x3545390", VA = "0x183545F90")]
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
				[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
				public OEJBHOJOLNM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x3549100", Offset = "0x3548500", VA = "0x183549100")]
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
				[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
				public MLOIAKOIDDA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017D")]
				[Cpp2IlInjected.Address(RVA = "0x3548680", Offset = "0x3547A80", VA = "0x183548680")]
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
				[Cpp2IlInjected.Address(RVA = "0xC27250", Offset = "0xC26650", VA = "0x180C27250")]
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
				[Cpp2IlInjected.Address(RVA = "0x6590C0", Offset = "0x6584C0", VA = "0x1806590C0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3544220", Offset = "0x3543620", VA = "0x183544220")]
			private static int PGPLCLADMOP(NEIJEKIKDOG CKFELIAJKCP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3544250", Offset = "0x3543650", VA = "0x183544250")]
			public IALKDLLHDII(NEIJEKIKDOG CKFELIAJKCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3543C10", Offset = "0x3543010", VA = "0x183543C10")]
			private void MLAFOKLGIMD(ref int GMJLJINPLLP, int DGKFKECDFGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3544040", Offset = "0x3543440", VA = "0x183544040")]
			public void NPNEHCHIMCM(BPGLFKPKJHF LHOMKMINCHH, KENFJGFMIPM BPGGCEOBFBK, IEnumerator<KENFJGFMIPM> LOIIKGFHHAA, OMNCINDCAAJ NKLGAGCHGPM, [Optional] BMOEEDOECDC NEPMGGPMFOH, KINIDGHKMLM IJBJBPDEKKL = KINIDGHKMLM.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3542F40", Offset = "0x3542340", VA = "0x183542F40")]
			public void FLJBJJLIFHM(IEnumerable<CFBMJLPBODF> DMDLKMFKKCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x35431B0", Offset = "0x35425B0", VA = "0x1835431B0")]
			private CFBMJLPBODF JAAGBELBKHG(int JGECCDNFAID)
			{
				return default(CFBMJLPBODF);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3542C10", Offset = "0x3542010", VA = "0x183542C10")]
			private void FKNNONKOPDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x14B8980", Offset = "0x14B7D80", VA = "0x1814B8980")]
			private static void NBHOFBPCJGK<T>(int JGECCDNFAID, T[] IMMIMNIHIEF, int OJJOHDIFMEG, [Optional] T ADHBGHBGDNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x14B8960", Offset = "0x14B7D60", VA = "0x1814B8960")]
			private static void NBHOFBPCJGK<T>(int JGECCDNFAID, NativeArray<T> IMMIMNIHIEF, int OJJOHDIFMEG, [Optional] T ADHBGHBGDNC) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x35428F0", Offset = "0x3541CF0", VA = "0x1835428F0")]
			private void DIOBAOCAAEI(IEnumerable<CFBMJLPBODF> DMDLKMFKKCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x3542590", Offset = "0x3541990", VA = "0x183542590")]
			private void BANFNKBEACN(CFBMJLPBODF IHJKAJBJMJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3543DA0", Offset = "0x35431A0", VA = "0x183543DA0")]
			private FLILCHFLFHI NDHIAFIAEDC(int AHKGGOPCBNK)
			{
				return default(FLILCHFLFHI);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x3542700", Offset = "0x3541B00", VA = "0x183542700")]
			public void CMBODEFCFGB(float KGOBMDNKIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x3543130", Offset = "0x3542530", VA = "0x183543130")]
			private void GBONAELFCHI(Action IPHIIJNAEON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x3542B90", Offset = "0x3541F90", VA = "0x183542B90")]
			private void EAOBOPNPOJE(Action IPHIIJNAEON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x35435E0", Offset = "0x35429E0", VA = "0x1835435E0")]
			public void JGHOHJNCKDH(float KGOBMDNKIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3543B30", Offset = "0x3542F30", VA = "0x183543B30")]
			public void MDDAPCCABNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x3543A80", Offset = "0x3542E80", VA = "0x183543A80")]
			public void KBPKIDJEOFB(BMOEEDOECDC KECNNGMBHAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x3544170", Offset = "0x3543570", VA = "0x183544170")]
			public void OEJCNOAPCAB(BMOEEDOECDC KECNNGMBHAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3542650", Offset = "0x3541A50", VA = "0x183542650")]
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
			[Cpp2IlInjected.Address(RVA = "0x3547220", Offset = "0x3546620", VA = "0x183547220")]
			public static LCKMBKBNBGC NFHADFCEMML(int GONGHDLCGPO, float KGOBMDNKIDJ, NativeArray<KINIDGHKMLM> FKIFNJGLFDF, NativeArray<float> ADCCOCDJMNM, NativeArray<int> EIHKHJBKKPC, NativeArray<int> HEDEJBEKJPH, NativeArray<int> HFOAFEDLEJG, NativeArray<int> AKANBKMACGE, NativeArray<int> JBONOFAJNCL)
			{
				return default(LCKMBKBNBGC);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x3546E00", Offset = "0x3546200", VA = "0x183546E00", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3546FB0", Offset = "0x35463B0", VA = "0x183546FB0")]
			private bool KHFEFLOCLII(int EFBDCIJMFGD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x3546DD0", Offset = "0x35461D0", VA = "0x183546DD0")]
			private void CDLEKIKHHCD(NativeArray<int> FJLGONNPKCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x35472F0", Offset = "0x35466F0", VA = "0x1835472F0")]
			private int OEIAGHKPDBB(int ILJJFCIEOOJ, int MMJPCDPKKJE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x3546EE0", Offset = "0x35462E0", VA = "0x183546EE0")]
			private void JIHBNKEBJDH(NativeArray<int> FJLGONNPKCB, int DLECGJMGFNI, int PBAOMKNFBFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3546FF0", Offset = "0x35463F0", VA = "0x183546FF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F6000", Offset = "0x3F5400", VA = "0x1803F6000")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000186")]
				[Cpp2IlInjected.Address(RVA = "0x4055E0", Offset = "0x4049E0", VA = "0x1804055E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public KENFJGFMIPM JIGIMNNJHGD
			{
				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x4055D0", Offset = "0x4049D0", VA = "0x1804055D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public bool OBADDMFNOMJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000189")]
				[Cpp2IlInjected.Address(RVA = "0x353FEB0", Offset = "0x353F2B0", VA = "0x18353FEB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool JDKJCDNCDAN
			{
				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0x454FE0", Offset = "0x4543E0", VA = "0x180454FE0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600018B")]
				[Cpp2IlInjected.Address(RVA = "0x455280", Offset = "0x454680", VA = "0x180455280")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public string FIKEBGGCDFN
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x415040", Offset = "0x414440", VA = "0x180415040")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0x4059E0", Offset = "0x404DE0", VA = "0x1804059E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public float LKOAKFDABJP
			{
				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0x8F5B30", Offset = "0x8F4F30", VA = "0x1808F5B30")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0x8F5940", Offset = "0x8F4D40", VA = "0x1808F5940")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x3540300", Offset = "0x353F700", VA = "0x183540300")]
			public GMHCEMDMGBA(IEnumerator<KENFJGFMIPM> LOIIKGFHHAA, Behaviour LHOMKMINCHH, OMNCINDCAAJ NKLGAGCHGPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x3540060", Offset = "0x353F460", VA = "0x183540060")]
			public KENFJGFMIPM NEPONCICACF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x353FF40", Offset = "0x353F340", VA = "0x18353FF40")]
			public bool GBOOCLEMCKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x353FFD0", Offset = "0x353F3D0", VA = "0x18353FFD0")]
			public void KBPKIDJEOFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x3540270", Offset = "0x353F670", VA = "0x183540270", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xE87B90", Offset = "0xE86F90", VA = "0x180E87B90")]
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
				[Cpp2IlInjected.Address(RVA = "0x44F7E0", Offset = "0x44EBE0", VA = "0x18044F7E0", Slot = "23")]
				get
				{
					return default(NEIJEKIKDOG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public NEIJEKIKDOG ALLFDCFPHGM
			{
				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x44F7E0", Offset = "0x44EBE0", VA = "0x18044F7E0")]
				get
				{
					return default(NEIJEKIKDOG);
				}
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x4226E0", Offset = "0x421AE0", VA = "0x1804226E0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			private float IIEAAEDICEG
			{
				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x8B0980", Offset = "0x8AFD80", VA = "0x1808B0980", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x455000", Offset = "0x454400", VA = "0x180455000", Slot = "24")]
			private bool EEOJLONCPBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3549D30", Offset = "0x3549130", VA = "0x183549D30", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3549D40", Offset = "0x3549140", VA = "0x183549D40")]
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
				[Cpp2IlInjected.Address(RVA = "0x427460", Offset = "0x426860", VA = "0x180427460")]
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
				[Cpp2IlInjected.Address(RVA = "0x3541010", Offset = "0x3540410", VA = "0x183541010")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x35418D0", Offset = "0x3540CD0", VA = "0x1835418D0")]
			public GOPOCOOMEIM(NEIJEKIKDOG MJHMBNIDGCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3541620", Offset = "0x3540A20", VA = "0x183541620")]
			public void OFMOGILADOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3541000", Offset = "0x3540400", VA = "0x183541000")]
			public void HCJANGOBPPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x35416E0", Offset = "0x3540AE0", VA = "0x1835416E0")]
			private void PFMMBGGICPG(IReadOnlyList<GMHCEMDMGBA> CNNICEPGNGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x3541520", Offset = "0x3540920", VA = "0x183541520")]
			public void ODPKGCAACLJ(GMHCEMDMGBA LOIIKGFHHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x3541180", Offset = "0x3540580", VA = "0x183541180")]
			public void NJJBDIOAJKH(IList<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3540D80", Offset = "0x3540180", VA = "0x183540D80")]
			public void GMBMMGDJFKG(IList<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3540B10", Offset = "0x353FF10", VA = "0x183540B10")]
			private void EPACAPMNOOB(GMHCEMDMGBA LOIIKGFHHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3540680", Offset = "0x353FA80", VA = "0x183540680")]
			private void BBDFMCDKAKM(IList<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3540C00", Offset = "0x3540000", VA = "0x183540C00")]
			private FLILCHFLFHI FODCOGKACKB(GMHCEMDMGBA LOIIKGFHHAA)
			{
				return default(FLILCHFLFHI);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x3541630", Offset = "0x3540A30", VA = "0x183541630")]
			public void OPEMIFENIJM(float KGOBMDNKIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3540480", Offset = "0x353F880", VA = "0x183540480")]
			public void AAACLIOCAPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3540930", Offset = "0x353FD30", VA = "0x183540930")]
			private void EMNPEAHLJHM(List<GMHCEMDMGBA> JNMOEFOGKLE, Stack<int> HEEKJOEHAOC, bool FIOKCLNDGIF, float KENDNPDMLOG = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x35407F0", Offset = "0x353FBF0", VA = "0x1835407F0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3541400", Offset = "0x3540800", VA = "0x183541400")]
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
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
			[DebuggerHidden]
			public FKPOAPKAOPL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x353F2E0", Offset = "0x353E6E0", VA = "0x18353F2E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x353F360", Offset = "0x353E760", VA = "0x18353F360", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x4055D0", Offset = "0x4049D0", VA = "0x1804055D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public NEIJEKIKDOG BIALLDOGHIO
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x411DF0", Offset = "0x4111F0", VA = "0x180411DF0")]
			[CompilerGenerated]
			get
			{
				return default(NEIJEKIKDOG);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x43EEB0", Offset = "0x43E2B0", VA = "0x18043EEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int JJEKKMDIBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x354BB90", Offset = "0x354AF90", VA = "0x18354BB90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x354AA90", Offset = "0x3549E90", VA = "0x18354AA90")]
		public static KFBABPAPIMB GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x354A310", Offset = "0x3549710", VA = "0x18354A310", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x354AC70", Offset = "0x354A070", VA = "0x18354AC70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x24FC260", Offset = "0x24FB660", VA = "0x1824FC260")]
		private GOPOCOOMEIM BMEHNIHAJHK(NEIJEKIKDOG GEDCEIDOKJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x354AA30", Offset = "0x3549E30", VA = "0x18354AA30")]
		private IALKDLLHDII FLPNLDJDNNM(NEIJEKIKDOG GEDCEIDOKJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x354B100", Offset = "0x354A500", VA = "0x18354B100")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x354B0D0", Offset = "0x354A4D0", VA = "0x18354B0D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x354B990", Offset = "0x354AD90", VA = "0x18354B990")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x354AC60", Offset = "0x354A060", VA = "0x18354AC60")]
		private void NGHDMBGBMLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x354AA20", Offset = "0x3549E20", VA = "0x18354AA20")]
		private void EBCGNHAEELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x354AA70", Offset = "0x3549E70", VA = "0x18354AA70")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x354AB30", Offset = "0x3549F30", VA = "0x18354AB30")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x354AA80", Offset = "0x3549E80", VA = "0x18354AA80")]
		private void GJJOOOJIAAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x354A7A0", Offset = "0x3549BA0", VA = "0x18354A7A0")]
		[IteratorStateMachine(typeof(FKPOAPKAOPL))]
		private IEnumerator CHAAKFJCLIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x354B2A0", Offset = "0x354A6A0", VA = "0x18354B2A0")]
		public KFBABPAPIMB Run(IEnumerator<KENFJGFMIPM> GAHCJOMJGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x354B2B0", Offset = "0x354A6B0", VA = "0x18354B2B0")]
		public KFBABPAPIMB Run(Behaviour LHOMKMINCHH, IEnumerator<KENFJGFMIPM> GAHCJOMJGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x354B170", Offset = "0x354A570", VA = "0x18354B170")]
		public KFBABPAPIMB RunJobbed(BPGLFKPKJHF LHOMKMINCHH, IEnumerator<KENFJGFMIPM> GAHCJOMJGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x354A9C0", Offset = "0x3549DC0", VA = "0x18354A9C0")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x354B5D0", Offset = "0x354A9D0", VA = "0x18354B5D0")]
		public void UpdateQueue(NEIJEKIKDOG DKGFKIKFBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x354A800", Offset = "0x3549C00", VA = "0x18354A800")]
		private void CLODBMLECIA(GOPOCOOMEIM KAMCDGAHIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x354AB40", Offset = "0x3549F40", VA = "0x18354AB40")]
		private void MNKNBBMICOI(IALKDLLHDII KAMCDGAHIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x354BB10", Offset = "0x354AF10", VA = "0x18354BB10")]
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
		[Cpp2IlInjected.Address(RVA = "0x353B990", Offset = "0x353AD90", VA = "0x18353B990", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public float FFPPABMIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x353B980", Offset = "0x353AD80", VA = "0x18353B980", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float PIBBOFCHMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x353B9A0", Offset = "0x353ADA0", VA = "0x18353B9A0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public int JHNNFDHLJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x353B970", Offset = "0x353AD70", VA = "0x18353B970", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public double NCBJKCHIKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x353B950", Offset = "0x353AD50", VA = "0x18353B950", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
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
		[Cpp2IlInjected.Address(RVA = "0x353F210", Offset = "0x353E610", VA = "0x18353F210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public double OOPCGBFJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x353F140", Offset = "0x353E540", VA = "0x18353F140", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public double GMBEJJBNGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x1741A50", Offset = "0x1740E50", VA = "0x181741A50", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public double JIODMOCKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4440", Offset = "0x2AF3840", VA = "0x182AF4440", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x353F250", Offset = "0x353E650", VA = "0x18353F250")]
	public FIFNHIILPEL(int EPHMNMCMOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x353F040", Offset = "0x353E440", VA = "0x18353F040", Slot = "4")]
	public void EHGIOHLBHJN(double MBJCIBHEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x353F1A0", Offset = "0x353E5A0", VA = "0x18353F1A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F6000", Offset = "0x3F5400", VA = "0x1803F6000")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public double GMBEJJBNGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x462170", Offset = "0x461570", VA = "0x180462170", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public double JIODMOCKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF44B0", Offset = "0x2AF38B0", VA = "0x182AF44B0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public double GGEADKGMGDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4440", Offset = "0x2AF3840", VA = "0x182AF4440")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public double JDPBPFKMGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x314B820", Offset = "0x314AC20", VA = "0x18314B820")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public double OOPCGBFJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4370", Offset = "0x2AF3770", VA = "0x182AF4370", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3539F70", Offset = "0x3539370", VA = "0x183539F70", Slot = "4")]
	public void EHGIOHLBHJN(double MBJCIBHEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x353A090", Offset = "0x3539490", VA = "0x18353A090", Slot = "5")]
	public void JBBLIBHHEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x353A0D0", Offset = "0x35394D0", VA = "0x18353A0D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FF7F50", Offset = "0x1FF7350", VA = "0x181FF7F50")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool MMICKFMMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1FF7F00", Offset = "0x1FF7300", VA = "0x181FF7F00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x1A043C0", Offset = "0x1A037C0", VA = "0x181A043C0")]
		protected JDIOECLPOPK(TPromise GMLHFPFHBJD, TMainThreadPromise BLFADPCOALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1FF7FB0", Offset = "0x1FF73B0", VA = "0x181FF7FB0", Slot = "5")]
		public void OOOIENHGNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1A2B080", Offset = "0x1A2A480", VA = "0x181A2B080", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FF52E0", Offset = "0x1FF46E0", VA = "0x181FF52E0")]
		public BCAIFPDOAMM(global::PMGCJEPKFOF<T> GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FF4E40", Offset = "0x1FF4240", VA = "0x181FF4E40", Slot = "7")]
		protected override void AMPLEOCGJBM(global::PMGCJEPKFOF<T> GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x1FF5210", Offset = "0x1FF4610", VA = "0x181FF5210", Slot = "8")]
		protected override void GHCAGDCCIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1FF5270", Offset = "0x1FF4670", VA = "0x181FF5270")]
		[CompilerGenerated]
		private void NIJANLDDIMP(T GIAOBLMEMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1FF5180", Offset = "0x1FF4580", VA = "0x181FF5180")]
		[CompilerGenerated]
		private void FGCPLDIEGKO(string MOPOMPHBHKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class EHEDHJDLBCH : JDIOECLPOPK<DABKFAIHBBP, JJEKJGALHKO>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x353DD50", Offset = "0x353D150", VA = "0x18353DD50")]
		public EHEDHJDLBCH(DABKFAIHBBP GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x353DC30", Offset = "0x353D030", VA = "0x18353DC30", Slot = "7")]
		protected override void AMPLEOCGJBM(DABKFAIHBBP GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x353DD00", Offset = "0x353D100", VA = "0x18353DD00", Slot = "8")]
		protected override void GHCAGDCCIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xC16CA0", Offset = "0xC160A0", VA = "0x180C16CA0")]
		[CompilerGenerated]
		private void NIJANLDDIMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x148A3D0", Offset = "0x14897D0", VA = "0x18148A3D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x47F7D0", Offset = "0x47EBD0", VA = "0x18047F7D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x41E770", Offset = "0x41DB70", VA = "0x18041E770")]
		public HLPAFHONKPA(Action JJGHIEJCCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x131D9A0", Offset = "0x131CDA0", VA = "0x18131D9A0", Slot = "5")]
		public void OOOIENHGNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "6")]
		public void KBPKIDJEOFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly List<OJCONDGBEIA> GEONEIIGPNH;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1EF8BC0", Offset = "0x1EF7FC0", VA = "0x181EF8BC0")]
	public static global::PMGCJEPKFOF<T> DNMKIEAJOJH<T>(this global::PMGCJEPKFOF<T> GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3547DB0", Offset = "0x35471B0", VA = "0x183547DB0")]
	public static DABKFAIHBBP DNMKIEAJOJH(this DABKFAIHBBP GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3547D30", Offset = "0x3547130", VA = "0x183547D30")]
	public static void DNMKIEAJOJH(Action JJGHIEJCCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1EF8CA0", Offset = "0x1EF80A0", VA = "0x181EF8CA0")]
	private static global::PMGCJEPKFOF<T> LINADCCOBCC<T>(global::PMGCJEPKFOF<T> GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3548220", Offset = "0x3547620", VA = "0x183548220")]
	private static DABKFAIHBBP LINADCCOBCC(DABKFAIHBBP GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x3548040", Offset = "0x3547440", VA = "0x183548040")]
	private static void IIGMDIHDNJD(OJCONDGBEIA BKCGDDGIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3547A10", Offset = "0x3546E10", VA = "0x183547A10")]
	private static void COAPLNGMFKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3547EC0", Offset = "0x35472C0", VA = "0x183547EC0")]
	private static void EHDOBJFCNEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3547F90", Offset = "0x3547390", VA = "0x183547F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
		public LHAKBAAEPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3547830", Offset = "0x3546C30", VA = "0x183547830")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3547820", Offset = "0x3546C20", VA = "0x183547820")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
		public GAILAHGLKML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x353F4B0", Offset = "0x353E8B0", VA = "0x18353F4B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
		[DebuggerHidden]
		public HGHALIPAJMI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3541FC0", Offset = "0x35413C0", VA = "0x183541FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3541CB0", Offset = "0x35410B0", VA = "0x183541CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3542070", Offset = "0x3541470", VA = "0x183542070")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3541F70", Offset = "0x3541370", VA = "0x183541F70", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
		[DebuggerHidden]
		public GBMMKEHDBLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x353F4E0", Offset = "0x353E8E0", VA = "0x18353F4E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x353F720", Offset = "0x353EB20", VA = "0x18353F720", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x3548D90", Offset = "0x3548190", VA = "0x183548D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private static bool KLFONPCEKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3549040", Offset = "0x3548440", VA = "0x183549040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private static bool JMIHDNFOODM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x35490A0", Offset = "0x35484A0", VA = "0x1835490A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3548BE0", Offset = "0x3547FE0", VA = "0x183548BE0")]
	public static DABKFAIHBBP BBOHJKKLCKO(string PCBCJKHMBGL, LoadSceneMode GNOCFLPOFIB = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x3548E30", Offset = "0x3548230", VA = "0x183548E30")]
	public static DABKFAIHBBP DGIJOCFANHH(string PCBCJKHMBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x3548D20", Offset = "0x3548120", VA = "0x183548D20")]
	[IteratorStateMachine(typeof(HGHALIPAJMI))]
	private static IEnumerator<KENFJGFMIPM> CKBLIMMFGLM(string PCBCJKHMBGL, JJEKJGALHKO OCHKEPDILKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3548B60", Offset = "0x3547F60", VA = "0x183548B60")]
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
	[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x353E7F0", Offset = "0x353DBF0", VA = "0x18353E7F0")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x353E8F0", Offset = "0x353DCF0", VA = "0x18353E8F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
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

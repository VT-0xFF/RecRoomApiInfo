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
				[Cpp2IlInjected.Address(RVA = "0x3459670", Offset = "0x3458870", VA = "0x183459670")]
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
				[Cpp2IlInjected.Address(RVA = "0x344E1C0", Offset = "0x344D3C0", VA = "0x18344E1C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x344CDF0", Offset = "0x344BFF0", VA = "0x18344CDF0")]
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
					[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
					public DNCKJNJBGIE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x344CFA0", Offset = "0x344C1A0", VA = "0x18344CFA0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x344DAE0", Offset = "0x344CCE0", VA = "0x18344DAE0")]
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
					[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
					public FGHMPJKFPEE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x344E370", Offset = "0x344D570", VA = "0x18344E370")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x344CCF0", Offset = "0x344BEF0", VA = "0x18344CCF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
			public MEHOILAECLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3457690", Offset = "0x3456890", VA = "0x183457690")]
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
			[Cpp2IlInjected.Address(RVA = "0x344C660", Offset = "0x344B860", VA = "0x18344C660")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x344C2C0", Offset = "0x344B4C0", VA = "0x18344C2C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x344B470", Offset = "0x344A670", VA = "0x18344B470")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x344C300", Offset = "0x344B500", VA = "0x18344C300")]
		private static void KHFAOCKFOMG(ELGIGKJCDID.PEEOJJCEFPE DNGKIAJLLHG, ref PlayerLoopSystem INJAGKJAPKC, Type IAFJLDHNNAG, Type MCNLGODIENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x344C6A0", Offset = "0x344B8A0", VA = "0x18344C6A0")]
		private static void PIDOJLLLMLO(ref PlayerLoopSystem INJAGKJAPKC, Type IAFJLDHNNAG, Type MCNLGODIENM, AHJIPNEIGPG BNLLHBCJFOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x344C560", Offset = "0x344B760", VA = "0x18344C560")]
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
		[Cpp2IlInjected.Address(RVA = "0x344D9E0", Offset = "0x344CBE0", VA = "0x18344D9E0")]
		public FDGHJJOBMOD(PEEOJJCEFPE DOOFHEFHHGI, int NMIMOBMHDAF = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x344D7C0", Offset = "0x344C9C0", VA = "0x18344D7C0")]
		public void BLFLBLDMBBK(int AAEANOFBLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x344D7E0", Offset = "0x344C9E0", VA = "0x18344D7E0")]
		public void HFJPBHFKHPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x344D790", Offset = "0x344C990", VA = "0x18344D790")]
		public void BAPLIBPCJLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x344D8A0", Offset = "0x344CAA0", VA = "0x18344D8A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x344D1B0", Offset = "0x344C3B0", VA = "0x18344D1B0")]
	public static FDGHJJOBMOD AKFOAKIHIBH(PEEOJJCEFPE DNGKIAJLLHG, int NMIMOBMHDAF = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x344D370", Offset = "0x344C570", VA = "0x18344D370")]
	public static FDGHJJOBMOD CCOLPLDBPEN(PEEOJJCEFPE DNGKIAJLLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x344D400", Offset = "0x344C600", VA = "0x18344D400")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public CLKPFIJHGLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x344AC90", Offset = "0x3449E90", VA = "0x18344AC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public OGBHHMOKMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x344AC90", Offset = "0x3449E90", VA = "0x18344AC90")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly float IFDHHDIIAAG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x344AC40", Offset = "0x3449E40", VA = "0x18344AC40")]
	public DECOBNDCNFA(Behaviour LHOMKMINCHH, float IFDHHDIIAAG, [Optional] Action EJAIEDPNOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x344CB50", Offset = "0x344BD50", VA = "0x18344CB50", Slot = "9")]
	protected override bool EEJEOHAODHB(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x344CC20", Offset = "0x344BE20", VA = "0x18344CC20", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
		[DebuggerHidden]
		public MHJIDBHBMGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3457790", Offset = "0x3456990", VA = "0x183457790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3457830", Offset = "0x3456A30", VA = "0x183457830", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x65C070", Offset = "0x65B270", VA = "0x18065C070", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OGODIKKKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3451140", Offset = "0x3450340", VA = "0x183451140", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x34510A0", Offset = "0x34502A0", VA = "0x1834510A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1A01350", Offset = "0x1A00550", VA = "0x181A01350")]
	protected HOMBMCGGPOD(Behaviour LHOMKMINCHH, [Optional] Action EJAIEDPNOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x34514C0", Offset = "0x34506C0", VA = "0x1834514C0", Slot = "7")]
	public bool PFFOFIHGOEA(bool CDFHDACBFKN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3451520", Offset = "0x3450720", VA = "0x183451520", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x34511E0", Offset = "0x34503E0", VA = "0x1834511E0")]
	protected void HLOEPMHHGKE(Action JJGHIEJCCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x34512F0", Offset = "0x34504F0", VA = "0x1834512F0")]
	protected DABKFAIHBBP PAAAGNNFMLG(float BJJEDIGOMGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3451280", Offset = "0x3450480", VA = "0x183451280")]
	private void KDPCHEJAGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3451200", Offset = "0x3450400", VA = "0x183451200")]
	[IteratorStateMachine(typeof(MHJIDBHBMGM))]
	private static IEnumerator<KENFJGFMIPM> HOPCEMPGALM(float BJJEDIGOMGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3451260", Offset = "0x3450460", VA = "0x183451260")]
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
		[Cpp2IlInjected.Address(RVA = "0x42EA00", Offset = "0x42DC00", VA = "0x18042EA00")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x421A50", Offset = "0x420C50", VA = "0x180421A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3459560", Offset = "0x3458760", VA = "0x183459560")]
	public PHJNILKEAAI(Behaviour LHOMKMINCHH, float JHPBDEKPCKP, int OFOIBLJPHGE, [Optional] Action EJAIEDPNOIG, float DNHGIAAFCLE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3F5D40", Offset = "0x3F4F40", VA = "0x1803F5D40", Slot = "9")]
	protected override bool EEJEOHAODHB(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x34592B0", Offset = "0x34584B0", VA = "0x1834592B0", Slot = "10")]
	protected override bool KLJHDBCCABK(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x34594D0", Offset = "0x34586D0", VA = "0x1834594D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x344AC40", Offset = "0x3449E40", VA = "0x18344AC40")]
	public CKNNCLNMAPG(Behaviour LHOMKMINCHH, float IFDHHDIIAAG, [Optional] Action EJAIEDPNOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3F5D40", Offset = "0x3F4F40", VA = "0x1803F5D40", Slot = "9")]
	protected override bool EEJEOHAODHB(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x344AC00", Offset = "0x3449E00", VA = "0x18344AC00", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F1200", Offset = "0x3F0400", VA = "0x1803F1200")]
	public GHMCDEEFOLC(Action NGEMKGIAPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x344F1B0", Offset = "0x344E3B0", VA = "0x18344F1B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x15568E0", Offset = "0x1555AE0", VA = "0x1815568E0")]
		public GCFGNJEEJPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2623320", Offset = "0x2622520", VA = "0x182623320")]
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
		[Cpp2IlInjected.Address(RVA = "0x2625630", Offset = "0x2624830", VA = "0x182625630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T DMLIOOCLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x466C00", Offset = "0x465E00", VA = "0x180466C00", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2624E90", Offset = "0x2624090", VA = "0x182624E90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2624F80", Offset = "0x2624180", VA = "0x182624F80")]
	private static bool LPHFKINGMHN(T IPHIIJNAEON, T FOJLJNMAJLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2625A90", Offset = "0x2624C90", VA = "0x182625A90")]
	public KAGJDGDAADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2625B50", Offset = "0x2624D50", VA = "0x182625B50")]
	public KAGJDGDAADK(T KMHEHJCNMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2625A70", Offset = "0x2624C70", VA = "0x182625A70")]
	public void MOCMFLAMJHA(T BCEFAKDFEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2624CE0", Offset = "0x2623EE0", VA = "0x182624CE0", Slot = "7")]
	public IDisposable JAHAHHAFAPC(Action<T> CCHCBCLCFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2624D50", Offset = "0x2623F50", VA = "0x182624D50", Slot = "8")]
	public IDisposable JAHAHHAFAPC(UnityEngine.Object LHOMKMINCHH, Action<T> CCHCBCLCFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2625310", Offset = "0x2624510", VA = "0x182625310")]
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
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
		[DebuggerHidden]
		public LFCPKFJPOEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3456C50", Offset = "0x3455E50", VA = "0x183456C50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3456CF0", Offset = "0x3455EF0", VA = "0x183456CF0", Slot = "8")]
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
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public DABKFAIHBBP promise;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public COMHPOBAMNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x344AD20", Offset = "0x3449F20", VA = "0x18344AD20")]
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
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
		[DebuggerHidden]
		public AGKDIHPOJIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x344A110", Offset = "0x3449310", VA = "0x18344A110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x344A200", Offset = "0x3449400", VA = "0x18344A200", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3456940", Offset = "0x3455B40", VA = "0x183456940")]
	public static KENFJGFMIPM LEIMHFLNIKB(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x34568D0", Offset = "0x3455AD0", VA = "0x1834568D0")]
	[IteratorStateMachine(typeof(LFCPKFJPOEA))]
	public static IEnumerator<KENFJGFMIPM> FDHJPDHIMME(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3456A20", Offset = "0x3455C20", VA = "0x183456A20")]
	public static KENFJGFMIPM LINOLLIBDCO(Func<bool> LKMLNOJIFHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3456A80", Offset = "0x3455C80", VA = "0x183456A80")]
	public static KENFJGFMIPM OPDGBNPLNHG(DABKFAIHBBP NKLGAGCHGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3456880", Offset = "0x3455A80", VA = "0x183456880")]
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
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private CPHEMJCNNDB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
		[DebuggerHidden]
		public KBIEPEFBMPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x34555D0", Offset = "0x34547D0", VA = "0x1834555D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x34556A0", Offset = "0x34548A0", VA = "0x1834556A0", Slot = "8")]
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
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private CPHEMJCNNDB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
		[DebuggerHidden]
		public DDPJLKFDDNM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x344CA10", Offset = "0x344BC10", VA = "0x18344CA10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x344CB00", Offset = "0x344BD00", VA = "0x18344CB00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3F3040", Offset = "0x3F2240", VA = "0x1803F3040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x421A30", Offset = "0x420C30", VA = "0x180421A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x95DFC0", Offset = "0x95D1C0", VA = "0x18095DFC0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
	public CPHEMJCNNDB(Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3F2CA0", Offset = "0x3F1EA0", VA = "0x1803F2CA0", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x344B080", Offset = "0x344A280", VA = "0x18344B080")]
	public static KFBABPAPIMB GIEOOLAGCKA(Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x344AF90", Offset = "0x344A190", VA = "0x18344AF90")]
	public static KFBABPAPIMB GIEOOLAGCKA(Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x344B280", Offset = "0x344A480", VA = "0x18344B280")]
	public static KFBABPAPIMB GIEOOLAGCKA(Behaviour LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x344B170", Offset = "0x344A370", VA = "0x18344B170")]
	public static KFBABPAPIMB GIEOOLAGCKA(Behaviour LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x344AE80", Offset = "0x344A080", VA = "0x18344AE80")]
	public static KFBABPAPIMB DJJOEODIBEE(BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x344AD70", Offset = "0x3449F70", VA = "0x18344AD70")]
	public static KFBABPAPIMB DJJOEODIBEE(BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x344B400", Offset = "0x344A600", VA = "0x18344B400")]
	[IteratorStateMachine(typeof(KBIEPEFBMPJ))]
	private static IEnumerator<KENFJGFMIPM> OKAOGDPNEKD(Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x344B390", Offset = "0x344A590", VA = "0x18344B390")]
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
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private BECNBPANOEI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
		[DebuggerHidden]
		public NIOKFBABMOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x34579A0", Offset = "0x3456BA0", VA = "0x1834579A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3457B40", Offset = "0x3456D40", VA = "0x183457B40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly float IMKDOHNAMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private int EECPLAEACEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly float LJINEKMJNJB;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public float MMEAJDPNJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x921B10", Offset = "0x920D10", VA = "0x180921B10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x876950", Offset = "0x875B50", VA = "0x180876950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x42DE30", Offset = "0x42D030", VA = "0x18042DE30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3F0C30", Offset = "0x3EFE30", VA = "0x1803F0C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x921BF0", Offset = "0x920DF0", VA = "0x180921BF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x921DB0", Offset = "0x920FB0", VA = "0x180921DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float FFPPABMIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x921DD0", Offset = "0x920FD0", VA = "0x180921DD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920D20", VA = "0x180921B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x344A640", Offset = "0x3449840", VA = "0x18344A640")]
	public BECNBPANOEI(float CKGGPPMDDBP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x344A2E0", Offset = "0x34494E0", VA = "0x18344A2E0", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x344A5B0", Offset = "0x34497B0", VA = "0x18344A5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x344A300", Offset = "0x3449500", VA = "0x18344A300")]
	public static KFBABPAPIMB GIEOOLAGCKA(float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x344A3B0", Offset = "0x34495B0", VA = "0x18344A3B0")]
	public static KFBABPAPIMB GIEOOLAGCKA(MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x344A470", Offset = "0x3449670", VA = "0x18344A470")]
	public static KFBABPAPIMB HFKCNODKFKG(BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x344A530", Offset = "0x3449730", VA = "0x18344A530")]
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
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Func<bool> LKMLNOJIFHH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F1470", Offset = "0x3F0670", VA = "0x1803F1470", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x45A0B0", Offset = "0x4592B0", VA = "0x18045A0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x921B10", Offset = "0x920D10", VA = "0x180921B10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x876950", Offset = "0x875B50", VA = "0x180876950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x344D610", Offset = "0x344C810", VA = "0x18344D610")]
	public ENKGACHBJCJ(Func<bool> LKMLNOJIFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x344D640", Offset = "0x344C840", VA = "0x18344D640")]
	public ENKGACHBJCJ(Scheduler.NEIJEKIKDOG CKFELIAJKCP, Func<bool> LKMLNOJIFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x344D5C0", Offset = "0x344C7C0", VA = "0x18344D5C0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Scheduler.NEIJEKIKDOG queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
		[DebuggerHidden]
		public NONJFBJHGEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3457B90", Offset = "0x3456D90", VA = "0x183457B90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3457C30", Offset = "0x3456E30", VA = "0x183457C30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3457E40", Offset = "0x3457040", VA = "0x183457E40")]
	[IteratorStateMachine(typeof(NONJFBJHGEM))]
	private static IEnumerator<KENFJGFMIPM> AGGNPLMDKGE(Scheduler.NEIJEKIKDOG CKFELIAJKCP, Func<bool> LKMLNOJIFHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3457EB0", Offset = "0x34570B0", VA = "0x183457EB0")]
	public static KFBABPAPIMB EGIAAFEOAGP(this MonoBehaviour BKGIHIBDAPA, Func<bool> LKMLNOJIFHH, Scheduler.NEIJEKIKDOG CKFELIAJKCP = Scheduler.NEIJEKIKDOG.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class JMOPCCPBNMB : KENFJGFMIPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly float MKOEJJBMPIN;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x505ED0", Offset = "0x5050D0", VA = "0x180505ED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5B8F10", Offset = "0x5B8110", VA = "0x1805B8F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x921DC0", Offset = "0x920FC0", VA = "0x180921DC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x893560", Offset = "0x892760", VA = "0x180893560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3455520", Offset = "0x3454720", VA = "0x183455520")]
	public JMOPCCPBNMB(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3455490", Offset = "0x3454690", VA = "0x183455490", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
		[DebuggerHidden]
		public CHFAJCJLJLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x344AB00", Offset = "0x3449D00", VA = "0x18344AB00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x344ABB0", Offset = "0x3449DB0", VA = "0x18344ABB0", Slot = "8")]
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
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private KENFJGFMIPM <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
		[DebuggerHidden]
		public EOMJHPHEMLH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x344D680", Offset = "0x344C880", VA = "0x18344D680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x344D740", Offset = "0x344C940", VA = "0x18344D740", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3454970", Offset = "0x3453B70", VA = "0x183454970")]
	[IteratorStateMachine(typeof(CHFAJCJLJLB))]
	private static IEnumerator<KENFJGFMIPM> HEBGBPGEFPK(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x34543F0", Offset = "0x34535F0", VA = "0x1834543F0")]
	[IteratorStateMachine(typeof(EOMJHPHEMLH))]
	private static IEnumerator<KENFJGFMIPM> DBNBNAILAFO(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x34551C0", Offset = "0x34543C0", VA = "0x1834551C0")]
	public static IDisposable PBPKBANPKJP(this MonoBehaviour BKGIHIBDAPA, float HABFNPMBADP, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x34545B0", Offset = "0x34537B0", VA = "0x1834545B0")]
	public static KFBABPAPIMB ENFHDIBGOEO(this MonoBehaviour BKGIHIBDAPA, float HABFNPMBADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3455300", Offset = "0x3454500", VA = "0x183455300")]
	public static KFBABPAPIMB PBPKBANPKJP(this MonoBehaviour BKGIHIBDAPA, float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x34546F0", Offset = "0x34538F0", VA = "0x1834546F0")]
	public static KFBABPAPIMB FHKNPABNEEM(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3454470", Offset = "0x3453670", VA = "0x183454470")]
	public static KFBABPAPIMB EGOJDKEBMNH(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x34549F0", Offset = "0x3453BF0", VA = "0x1834549F0")]
	public static KFBABPAPIMB HECMPBHFOEA(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3454C40", Offset = "0x3453E40", VA = "0x183454C40")]
	public static KFBABPAPIMB JGIPMJPPCBM(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3454830", Offset = "0x3453A30", VA = "0x183454830")]
	public static KFBABPAPIMB GGGCLEIGKCE(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3454FA0", Offset = "0x34541A0", VA = "0x183454FA0")]
	public static KFBABPAPIMB NLBLFPBOCLD(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x34550B0", Offset = "0x34542B0", VA = "0x1834550B0")]
	public static KFBABPAPIMB PAKNHKEKDAF(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3454B30", Offset = "0x3453D30", VA = "0x183454B30")]
	public static KFBABPAPIMB INLJFAKDKAD(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3454E90", Offset = "0x3454090", VA = "0x183454E90")]
	public static KFBABPAPIMB LBLNPIDACFM(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3454D80", Offset = "0x3453F80", VA = "0x183454D80")]
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
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
		[DebuggerHidden]
		public ILPPIMNIHBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x34542F0", Offset = "0x34534F0", VA = "0x1834542F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x34543A0", Offset = "0x34535A0", VA = "0x1834543A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private KFBABPAPIMB KHPFGANHBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private MonoBehaviour BKGIHIBDAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private Action JFKDDPJDCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private Action<float> HBMODGLEAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Scheduler.NEIJEKIKDOG CKFELIAJKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private float FJKINHFIBJA;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3454160", Offset = "0x3453360", VA = "0x183454160")]
	public ICMKAJELBGE(MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3453E80", Offset = "0x3453080", VA = "0x183453E80")]
	public ICMKAJELBGE(MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3454010", Offset = "0x3453210", VA = "0x183454010")]
	public ICMKAJELBGE(MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3453AB0", Offset = "0x3452CB0", VA = "0x183453AB0")]
	private void GIEOOLAGCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x34538B0", Offset = "0x3452AB0", VA = "0x1834538B0")]
	private void EBPHAECHJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3453C30", Offset = "0x3452E30", VA = "0x183453C30")]
	private void HCMLBCFDNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3453D60", Offset = "0x3452F60", VA = "0x183453D60")]
	private void KEECGEIFLEN(string MOPOMPHBHKF, Action HGGDFJNNBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3453800", Offset = "0x3452A00", VA = "0x183453800")]
	[IteratorStateMachine(typeof(ILPPIMNIHBJ))]
	private IEnumerator<KENFJGFMIPM> DEJICBOKAJH(Action HGGDFJNNBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3453860", Offset = "0x3452A60", VA = "0x183453860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3453780", Offset = "0x3452980", VA = "0x183453780")]
	[CompilerGenerated]
	private void CKHMLHHHCLN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3453700", Offset = "0x3452900", VA = "0x183453700")]
	[CompilerGenerated]
	private void CBBGHNELPMN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3453A30", Offset = "0x3452C30", VA = "0x183453A30")]
	[CompilerGenerated]
	private void GGEOKDFDCNK(string CHKKEHOKPJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class ADIFCODGAML
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3449A60", Offset = "0x3448C60", VA = "0x183449A60")]
	public static IDisposable GIEOOLAGCKA(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x34498A0", Offset = "0x3448AA0", VA = "0x1834498A0")]
	public static IDisposable GIEOOLAGCKA(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3449ED0", Offset = "0x34490D0", VA = "0x183449ED0")]
	public static IDisposable OPEMIFENIJM(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3449D60", Offset = "0x3448F60", VA = "0x183449D60")]
	public static IDisposable MOJAICCOOMH(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3449DD0", Offset = "0x3448FD0", VA = "0x183449DD0")]
	public static IDisposable OEMBBKDJFCB(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x34496B0", Offset = "0x34488B0", VA = "0x1834496B0")]
	public static IDisposable FHBCIFNCNMN(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3449B60", Offset = "0x3448D60", VA = "0x183449B60")]
	public static IDisposable JEEMKGCKHKD(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3449BD0", Offset = "0x3448DD0", VA = "0x183449BD0")]
	public static IDisposable LAHBIDHMCKF(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3449720", Offset = "0x3448920", VA = "0x183449720")]
	public static IDisposable FLMKKKHMJBN(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3449320", Offset = "0x3448520", VA = "0x183449320")]
	public static IDisposable AMNODMIDNHO(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3449AE0", Offset = "0x3448CE0", VA = "0x183449AE0")]
	public static IDisposable ICPMHNDIIFK(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x34495A0", Offset = "0x34487A0", VA = "0x1834495A0")]
	public static IDisposable ENLMJBCKILF(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3449820", Offset = "0x3448A20", VA = "0x183449820")]
	public static IDisposable FOFJADGKNJF(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3449C60", Offset = "0x3448E60", VA = "0x183449C60")]
	public static IDisposable LFJPCEKGMIA(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x34492A0", Offset = "0x34484A0", VA = "0x1834492A0")]
	public static IDisposable ADIDJGEIJOH(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3449E40", Offset = "0x3449040", VA = "0x183449E40")]
	public static IDisposable OIJBBPIBIJP(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3449420", Offset = "0x3448620", VA = "0x183449420")]
	public static IDisposable AOPHLNHDOKN(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x34494A0", Offset = "0x34486A0", VA = "0x1834494A0")]
	public static IDisposable BOHBPECGHLI(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x34497A0", Offset = "0x34489A0", VA = "0x1834497A0")]
	public static IDisposable FNFEBJPKPEA(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3449620", Offset = "0x3448820", VA = "0x183449620")]
	public static IDisposable FGFJPAFFKIN(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3449520", Offset = "0x3448720", VA = "0x183449520")]
	public static IDisposable CHFECAOLPEO(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3449CE0", Offset = "0x3448EE0", VA = "0x183449CE0")]
	public static IDisposable LGJLMMIHFON(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x34493A0", Offset = "0x34485A0", VA = "0x1834493A0")]
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
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
		[DebuggerHidden]
		public FNFBHFJCFAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x344E750", Offset = "0x344D950", VA = "0x18344E750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x344E800", Offset = "0x344DA00", VA = "0x18344E800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private KFBABPAPIMB KHPFGANHBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private BPGLFKPKJHF LHOMKMINCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Action JFKDDPJDCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Action<float> HBMODGLEAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Scheduler.NEIJEKIKDOG CKFELIAJKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private float FJKINHFIBJA;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3458DD0", Offset = "0x3457FD0", VA = "0x183458DD0")]
	public OLKNGLHPDJE(BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x34590B0", Offset = "0x34582B0", VA = "0x1834590B0")]
	public OLKNGLHPDJE(BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3458F60", Offset = "0x3458160", VA = "0x183458F60")]
	public OLKNGLHPDJE(BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3458A00", Offset = "0x3457C00", VA = "0x183458A00")]
	private void GIEOOLAGCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3458800", Offset = "0x3457A00", VA = "0x183458800")]
	private void EBPHAECHJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3458B80", Offset = "0x3457D80", VA = "0x183458B80")]
	private void HCMLBCFDNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3458CB0", Offset = "0x3457EB0", VA = "0x183458CB0")]
	private void KEECGEIFLEN(string MOPOMPHBHKF, Action HGGDFJNNBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3458750", Offset = "0x3457950", VA = "0x183458750")]
	[IteratorStateMachine(typeof(FNFBHFJCFAI))]
	private IEnumerator<KENFJGFMIPM> DEJICBOKAJH(Action HGGDFJNNBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x34587B0", Offset = "0x34579B0", VA = "0x1834587B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x34586D0", Offset = "0x34578D0", VA = "0x1834586D0")]
	[CompilerGenerated]
	private void CKHMLHHHCLN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3458650", Offset = "0x3457850", VA = "0x183458650")]
	[CompilerGenerated]
	private void CBBGHNELPMN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3458980", Offset = "0x3457B80", VA = "0x183458980")]
	[CompilerGenerated]
	private void GGEOKDFDCNK(string CHKKEHOKPJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class KCBPNKMEDPI
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3455B30", Offset = "0x3454D30", VA = "0x183455B30")]
	public static IDisposable DJJOEODIBEE(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3455970", Offset = "0x3454B70", VA = "0x183455970")]
	public static IDisposable DJJOEODIBEE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3455BB0", Offset = "0x3454DB0", VA = "0x183455BB0")]
	public static IDisposable EMGJKCCEAJA(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3455D20", Offset = "0x3454F20", VA = "0x183455D20")]
	public static IDisposable GJCJNLFFLKP(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3455CB0", Offset = "0x3454EB0", VA = "0x183455CB0")]
	public static IDisposable GAPIDOHIBLG(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3455810", Offset = "0x3454A10", VA = "0x183455810")]
	public static IDisposable CAJKNLABPBH(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3455900", Offset = "0x3454B00", VA = "0x183455900")]
	public static IDisposable DGFNIKAEGMI(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3455C20", Offset = "0x3454E20", VA = "0x183455C20")]
	public static IDisposable EOGNMLDAMCK(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3456190", Offset = "0x3455390", VA = "0x183456190")]
	public static IDisposable PBDKGIJCPCG(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3455F90", Offset = "0x3455190", VA = "0x183455F90")]
	public static IDisposable MHPNCCEFCID(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3455D90", Offset = "0x3454F90", VA = "0x183455D90")]
	public static IDisposable HNFGDIHEFIO(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3456110", Offset = "0x3455310", VA = "0x183456110")]
	public static IDisposable ONEBONJNMNK(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3455780", Offset = "0x3454980", VA = "0x183455780")]
	public static IDisposable BNJMDNLEDJB(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3455E10", Offset = "0x3455010", VA = "0x183455E10")]
	public static IDisposable IPPHMOEKHMO(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3456010", Offset = "0x3455210", VA = "0x183456010")]
	public static IDisposable NIIGGNNJAGE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3456090", Offset = "0x3455290", VA = "0x183456090")]
	public static IDisposable OBEEJIAEFKM(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x34556F0", Offset = "0x34548F0", VA = "0x1834556F0")]
	public static IDisposable AGEPHCFGCMM(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3455880", Offset = "0x3454A80", VA = "0x183455880")]
	public static IDisposable CEILCDDBJHP(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3455F10", Offset = "0x3455110", VA = "0x183455F10")]
	public static IDisposable LJOHGJJMOGE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3455E90", Offset = "0x3455090", VA = "0x183455E90")]
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
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public IALKDLLHDII ALLFDCFPHGM;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public int AKGEGLEMFGM
			{
				[Cpp2IlInjected.Token(Token = "0x6000154")]
				[Cpp2IlInjected.Address(RVA = "0x3F3040", Offset = "0x3F2240", VA = "0x1803F3040", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000155")]
				[Cpp2IlInjected.Address(RVA = "0x421A30", Offset = "0x420C30", VA = "0x180421A30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x344A9A0", Offset = "0x3449BA0", VA = "0x18344A9A0")]
			public static KENFJGFMIPM NEPONCICACF(IEnumerator<KENFJGFMIPM> LOIIKGFHHAA, OMNCINDCAAJ NKLGAGCHGPM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x344A8D0", Offset = "0x3449AD0", VA = "0x18344A8D0")]
			public KENFJGFMIPM NEPONCICACF(OMNCINDCAAJ[] LMOONNDFEPE, IEnumerator<KENFJGFMIPM>[] JNMOEFOGKLE, KENFJGFMIPM[] DHGHPJHPPGE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x344A8A0", Offset = "0x3449AA0", VA = "0x18344A8A0")]
			public void HNDCKFDJEKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x344A7E0", Offset = "0x34499E0", VA = "0x18344A7E0")]
			public void CMDNNKIMLED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x344A720", Offset = "0x3449920", VA = "0x18344A720")]
			public void AKIBJAOAEFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x344A8A0", Offset = "0x3449AA0", VA = "0x18344A8A0")]
			public void KBPKIDJEOFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
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
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public BMOEEDOECDC EOPDHGPFPNC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public BPGLFKPKJHF ADDDHPLGIKL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public OMNCINDCAAJ BAINEAGHDEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public IEnumerator<KENFJGFMIPM> HCIEHECEDAK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public KENFJGFMIPM JIGIMNNJHGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				public KINIDGHKMLM HDECHJHCMDD;
			}

			[Cpp2IlInjected.Token(Token = "0x2000041")]
			public struct GIDICDINLFI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public NEIJEKIKDOG JDIEDFKCIGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public List<CFBMJLPBODF> BKPFCJJFMDB;
			}

			[Cpp2IlInjected.Token(Token = "0x2000042")]
			[CompilerGenerated]
			private sealed class GHLCIHPNOIJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public BPGLFKPKJHF context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public BMOEEDOECDC routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public KINIDGHKMLM coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public OMNCINDCAAJ promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public KENFJGFMIPM currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public IEnumerator<KENFJGFMIPM> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
				public GHLCIHPNOIJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x344EB60", Offset = "0x344DD60", VA = "0x18344EB60")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class JKHIMOPAHLJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public BMOEEDOECDC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
				public JKHIMOPAHLJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x3455450", Offset = "0x3454650", VA = "0x183455450")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000044")]
			[CompilerGenerated]
			private sealed class OEJBHOJOLNM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public BMOEEDOECDC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
				public OEJBHOJOLNM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x3458610", Offset = "0x3457810", VA = "0x183458610")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class MLOIAKOIDDA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public BMOEEDOECDC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
				public MLOIAKOIDDA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x3457960", Offset = "0x3456B60", VA = "0x183457960")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private readonly NEIJEKIKDOG CKFELIAJKCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private bool[] OHHCKBGGNCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private NativeArray<KINIDGHKMLM> NGPEDHJDGOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private NativeArray<float> EGPCFKONLDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private NativeArray<int> DIPODGDEDFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private NativeArray<int> ADMMJMECAAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private NativeArray<int> GDENALHIFED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private NativeArray<int> MFFNBPCJDPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private NativeArray<int> LKNDAPBEAHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private BMOEEDOECDC[] EICHIBKNPKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private OMNCINDCAAJ[] LMOONNDFEPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private BPGLFKPKJHF[] AMEFOJLMGID;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private IEnumerator<KENFJGFMIPM>[] JELOAPNCLNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private KENFJGFMIPM[] LDGCCHBDADH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private int IMLAJMIFNPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private int NPKCAEOBEMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private readonly int AEIDKODLGJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private float PPDFBDENFBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private LCKMBKBNBGC OIHBJFCDCOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private JobHandle LMMAIKCFIFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private List<BMOEEDOECDC> DNBEKFHBBOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private bool HABDMPHMEHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private List<Action> KCFLKGHJGIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private List<Action> GAKKPKFANJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private bool AFDHMMIPEIP;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public GIDICDINLFI[] OAPPOHBJCJH
			{
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xCAE8E0", Offset = "0xCADAE0", VA = "0x180CAE8E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public int JJEKKMDIBGI
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0x59B7F0", Offset = "0x59A9F0", VA = "0x18059B7F0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3453200", Offset = "0x3452400", VA = "0x183453200")]
			private static int PGPLCLADMOP(NEIJEKIKDOG CKFELIAJKCP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3453230", Offset = "0x3452430", VA = "0x183453230")]
			public IALKDLLHDII(NEIJEKIKDOG CKFELIAJKCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3452BF0", Offset = "0x3451DF0", VA = "0x183452BF0")]
			private void MLAFOKLGIMD(ref int GMJLJINPLLP, int DGKFKECDFGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3453020", Offset = "0x3452220", VA = "0x183453020")]
			public void NPNEHCHIMCM(BPGLFKPKJHF LHOMKMINCHH, KENFJGFMIPM BPGGCEOBFBK, IEnumerator<KENFJGFMIPM> LOIIKGFHHAA, OMNCINDCAAJ NKLGAGCHGPM, [Optional] BMOEEDOECDC NEPMGGPMFOH, KINIDGHKMLM IJBJBPDEKKL = KINIDGHKMLM.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3451F20", Offset = "0x3451120", VA = "0x183451F20")]
			public void FLJBJJLIFHM(IEnumerable<CFBMJLPBODF> DMDLKMFKKCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3452190", Offset = "0x3451390", VA = "0x183452190")]
			private CFBMJLPBODF JAAGBELBKHG(int JGECCDNFAID)
			{
				return default(CFBMJLPBODF);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3451BF0", Offset = "0x3450DF0", VA = "0x183451BF0")]
			private void FKNNONKOPDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x156E750", Offset = "0x156D950", VA = "0x18156E750")]
			private static void NBHOFBPCJGK<T>(int JGECCDNFAID, T[] IMMIMNIHIEF, int OJJOHDIFMEG, [Optional] T ADHBGHBGDNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x156E730", Offset = "0x156D930", VA = "0x18156E730")]
			private static void NBHOFBPCJGK<T>(int JGECCDNFAID, NativeArray<T> IMMIMNIHIEF, int OJJOHDIFMEG, [Optional] T ADHBGHBGDNC) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x34518D0", Offset = "0x3450AD0", VA = "0x1834518D0")]
			private void DIOBAOCAAEI(IEnumerable<CFBMJLPBODF> DMDLKMFKKCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3451570", Offset = "0x3450770", VA = "0x183451570")]
			private void BANFNKBEACN(CFBMJLPBODF IHJKAJBJMJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3452D80", Offset = "0x3451F80", VA = "0x183452D80")]
			private FLILCHFLFHI NDHIAFIAEDC(int AHKGGOPCBNK)
			{
				return default(FLILCHFLFHI);
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x34516E0", Offset = "0x34508E0", VA = "0x1834516E0")]
			public void CMBODEFCFGB(float KGOBMDNKIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x3452110", Offset = "0x3451310", VA = "0x183452110")]
			private void GBONAELFCHI(Action IPHIIJNAEON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3451B70", Offset = "0x3450D70", VA = "0x183451B70")]
			private void EAOBOPNPOJE(Action IPHIIJNAEON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x34525C0", Offset = "0x34517C0", VA = "0x1834525C0")]
			public void JGHOHJNCKDH(float KGOBMDNKIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x3452B10", Offset = "0x3451D10", VA = "0x183452B10")]
			public void MDDAPCCABNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x3452A60", Offset = "0x3451C60", VA = "0x183452A60")]
			public void KBPKIDJEOFB(BMOEEDOECDC KECNNGMBHAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x3453150", Offset = "0x3452350", VA = "0x183453150")]
			public void OEJCNOAPCAB(BMOEEDOECDC KECNNGMBHAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3451630", Offset = "0x3450830", VA = "0x183451630")]
			public void CIFEAJMAHKI(BMOEEDOECDC KECNNGMBHAK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[BurstCompile]
		public struct LCKMBKBNBGC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			[ReadOnly]
			public float MKLCOIBIHEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			[ReadOnly]
			public int KGOGPFCJPPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private NativeArray<int> ELFLBECKFEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private NativeArray<int> AKANBKMACGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private NativeArray<int> JBONOFAJNCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			[ReadOnly]
			public NativeArray<KINIDGHKMLM> GJHKCAEJCKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			[ReadOnly]
			public NativeArray<float> EDDPIGKJOHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			[WriteOnly]
			public NativeArray<int> GDENALHIFED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			[WriteOnly]
			public NativeArray<int> DIPODGDEDFB;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3456740", Offset = "0x3455940", VA = "0x183456740")]
			public static LCKMBKBNBGC NFHADFCEMML(int GONGHDLCGPO, float KGOBMDNKIDJ, NativeArray<KINIDGHKMLM> FKIFNJGLFDF, NativeArray<float> ADCCOCDJMNM, NativeArray<int> EIHKHJBKKPC, NativeArray<int> HEDEJBEKJPH, NativeArray<int> HFOAFEDLEJG, NativeArray<int> AKANBKMACGE, NativeArray<int> JBONOFAJNCL)
			{
				return default(LCKMBKBNBGC);
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3456320", Offset = "0x3455520", VA = "0x183456320", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x34564D0", Offset = "0x34556D0", VA = "0x1834564D0")]
			private bool KHFEFLOCLII(int EFBDCIJMFGD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x34562F0", Offset = "0x34554F0", VA = "0x1834562F0")]
			private void CDLEKIKHHCD(NativeArray<int> FJLGONNPKCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x3456810", Offset = "0x3455A10", VA = "0x183456810")]
			private int OEIAGHKPDBB(int ILJJFCIEOOJ, int MMJPCDPKKJE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3456400", Offset = "0x3455600", VA = "0x183456400")]
			private void JIHBNKEBJDH(NativeArray<int> FJLGONNPKCB, int DLECGJMGFNI, int PBAOMKNFBFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x3456510", Offset = "0x3455710", VA = "0x183456510")]
			private void MNMAEDHAEFJ(NativeArray<int> FJLGONNPKCB, int JNOJAJGDFLF, int AKCJAFLPOKA, int IMMAKAPBGIK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class GMHCEMDMGBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private readonly OMNCINDCAAJ NKLGAGCHGPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			private readonly Behaviour LHOMKMINCHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private readonly bool LPCBEEBALNO;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public IEnumerator<KENFJGFMIPM> HCIEHECEDAK
			{
				[Cpp2IlInjected.Token(Token = "0x6000182")]
				[Cpp2IlInjected.Address(RVA = "0x40DED0", Offset = "0x40D0D0", VA = "0x18040DED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0x421640", Offset = "0x420840", VA = "0x180421640")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public KENFJGFMIPM JIGIMNNJHGD
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000185")]
				[Cpp2IlInjected.Address(RVA = "0x421630", Offset = "0x420830", VA = "0x180421630")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public bool OBADDMFNOMJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000186")]
				[Cpp2IlInjected.Address(RVA = "0x344F2A0", Offset = "0x344E4A0", VA = "0x18344F2A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public bool JDKJCDNCDAN
			{
				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x470DD0", Offset = "0x46FFD0", VA = "0x180470DD0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x471070", Offset = "0x470270", VA = "0x180471070")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public string FIKEBGGCDFN
			{
				[Cpp2IlInjected.Token(Token = "0x6000189")]
				[Cpp2IlInjected.Address(RVA = "0x431080", Offset = "0x430280", VA = "0x180431080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0x421A40", Offset = "0x420C40", VA = "0x180421A40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public float LKOAKFDABJP
			{
				[Cpp2IlInjected.Token(Token = "0x600018B")]
				[Cpp2IlInjected.Address(RVA = "0x98F520", Offset = "0x98E720", VA = "0x18098F520")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x98F330", Offset = "0x98E530", VA = "0x18098F330")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x344F6F0", Offset = "0x344E8F0", VA = "0x18344F6F0")]
			public GMHCEMDMGBA(IEnumerator<KENFJGFMIPM> LOIIKGFHHAA, Behaviour LHOMKMINCHH, OMNCINDCAAJ NKLGAGCHGPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x344F450", Offset = "0x344E650", VA = "0x18344F450")]
			public KENFJGFMIPM NEPONCICACF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x344F330", Offset = "0x344E530", VA = "0x18344F330")]
			public bool GBOOCLEMCKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x344F3C0", Offset = "0x344E5C0", VA = "0x18344F3C0")]
			public void KBPKIDJEOFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x344F660", Offset = "0x344E860", VA = "0x18344F660", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x12A5000", Offset = "0x12A4200", VA = "0x1812A5000")]
			[CompilerGenerated]
			private void NNFOONHOMIF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class OMNCINDCAAJ : HHKIEEPFDOH, KFBABPAPIMB, CDJFFFCFLMF, DABKFAIHBBP, IEnumerator, KENFJGFMIPM, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private NEIJEKIKDOG FIDOMBIKHPP;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			private NEIJEKIKDOG IIPMBGHMKNO
			{
				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x46B5E0", Offset = "0x46A7E0", VA = "0x18046B5E0", Slot = "23")]
				get
				{
					return default(NEIJEKIKDOG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public NEIJEKIKDOG ALLFDCFPHGM
			{
				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x46B5E0", Offset = "0x46A7E0", VA = "0x18046B5E0")]
				get
				{
					return default(NEIJEKIKDOG);
				}
				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0x43E680", Offset = "0x43D880", VA = "0x18043E680")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			private float IIEAAEDICEG
			{
				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x95DFC0", Offset = "0x95D1C0", VA = "0x18095DFC0", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x470DF0", Offset = "0x46FFF0", VA = "0x180470DF0", Slot = "24")]
			private bool EEOJLONCPBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x3459240", Offset = "0x3458440", VA = "0x183459240", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x3459250", Offset = "0x3458450", VA = "0x183459250")]
			public OMNCINDCAAJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private enum FLILCHFLFHI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private sealed class GOPOCOOMEIM : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public enum MJKJJAEINKK
			{
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			public struct OFOGOHPAFPJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public NEIJEKIKDOG JDIEDFKCIGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public MJKJJAEINKK BAPFEDOOIFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public List<GMHCEMDMGBA> OECIFDDKEAP;
			}

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			private static readonly MJKJJAEINKK[] GLLEJMPCGJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			private readonly NEIJEKIKDOG CKFELIAJKCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private bool JLDJMFNCDPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private readonly GMHCEMDMGBA[] GGEMDOAPACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private readonly List<GMHCEMDMGBA> PJKLFGMDJLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private readonly Stack<int> KIMBMABLPNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private readonly List<GMHCEMDMGBA> EADBGNKMBEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private readonly Stack<int> BCKLDDFGIID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private bool AFDHMMIPEIP;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public OFOGOHPAFPJ[,] KENMKBOBOCM
			{
				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x401A60", Offset = "0x400C60", VA = "0x180401A60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public int JJEKKMDIBGI
			{
				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x3450400", Offset = "0x344F600", VA = "0x183450400")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3450CC0", Offset = "0x344FEC0", VA = "0x183450CC0")]
			public GOPOCOOMEIM(NEIJEKIKDOG MJHMBNIDGCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3450A10", Offset = "0x344FC10", VA = "0x183450A10")]
			public void OFMOGILADOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x34503F0", Offset = "0x344F5F0", VA = "0x1834503F0")]
			public void HCJANGOBPPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3450AD0", Offset = "0x344FCD0", VA = "0x183450AD0")]
			private void PFMMBGGICPG(IReadOnlyList<GMHCEMDMGBA> CNNICEPGNGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3450910", Offset = "0x344FB10", VA = "0x183450910")]
			public void ODPKGCAACLJ(GMHCEMDMGBA LOIIKGFHHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3450570", Offset = "0x344F770", VA = "0x183450570")]
			public void NJJBDIOAJKH(IList<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3450170", Offset = "0x344F370", VA = "0x183450170")]
			public void GMBMMGDJFKG(IList<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x344FF00", Offset = "0x344F100", VA = "0x18344FF00")]
			private void EPACAPMNOOB(GMHCEMDMGBA LOIIKGFHHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x344FA70", Offset = "0x344EC70", VA = "0x18344FA70")]
			private void BBDFMCDKAKM(IList<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x344FFF0", Offset = "0x344F1F0", VA = "0x18344FFF0")]
			private FLILCHFLFHI FODCOGKACKB(GMHCEMDMGBA LOIIKGFHHAA)
			{
				return default(FLILCHFLFHI);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3450A20", Offset = "0x344FC20", VA = "0x183450A20")]
			public void OPEMIFENIJM(float KGOBMDNKIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x344F870", Offset = "0x344EA70", VA = "0x18344F870")]
			public void AAACLIOCAPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x344FD20", Offset = "0x344EF20", VA = "0x18344FD20")]
			private void EMNPEAHLJHM(List<GMHCEMDMGBA> JNMOEFOGKLE, Stack<int> HEEKJOEHAOC, bool FIOKCLNDGIF, float KENDNPDMLOG = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x344FBE0", Offset = "0x344EDE0", VA = "0x18344FBE0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x34507F0", Offset = "0x344F9F0", VA = "0x1834507F0")]
			private void OAGLBBEDKAL(List<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public enum NEIJEKIKDOG
		{
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			PostUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			RigidbodyExLateUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			PreRender,
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			EndOfFrame
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[Flags]
		public enum KINIDGHKMLM : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			Inactive = 0,
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			Running = 1,
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			Cancelled = 2,
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			Paused = 4
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class FKNPEGFNDBO : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
			[DebuggerHidden]
			public FKNPEGFNDBO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x344E680", Offset = "0x344D880", VA = "0x18344E680", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x344E700", Offset = "0x344D900", VA = "0x18344E700", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const KINIDGHKMLM BNMLAFJDKKO = KINIDGHKMLM.Cancelled | KINIDGHKMLM.Paused;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static readonly NEIJEKIKDOG[] JFNODFEODBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private GOPOCOOMEIM[] EFAKFPBPKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private IALKDLLHDII[] CMLNDHMENGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private Coroutine JFLDNFIOIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private WaitForEndOfFrame DIJAOOECJCE;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public FNPGPAPOHAN MACMLJJGBIM
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x421630", Offset = "0x420830", VA = "0x180421630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int JJEKKMDIBGI
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x345B090", Offset = "0x345A290", VA = "0x18345B090")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3459FA0", Offset = "0x34591A0", VA = "0x183459FA0")]
		public static KFBABPAPIMB GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3459820", Offset = "0x3458A20", VA = "0x183459820", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x345A180", Offset = "0x3459380", VA = "0x18345A180", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3459CB0", Offset = "0x3458EB0", VA = "0x183459CB0")]
		private GOPOCOOMEIM BMEHNIHAJHK(NEIJEKIKDOG GEDCEIDOKJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x4D39D0", Offset = "0x4D2BD0", VA = "0x1804D39D0")]
		private IALKDLLHDII FLPNLDJDNNM(NEIJEKIKDOG GEDCEIDOKJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x345A610", Offset = "0x3459810", VA = "0x18345A610")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x345A5E0", Offset = "0x34597E0", VA = "0x18345A5E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x345AE90", Offset = "0x345A090", VA = "0x18345AE90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x345A170", Offset = "0x3459370", VA = "0x18345A170")]
		private void NGHDMBGBMLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3459F70", Offset = "0x3459170", VA = "0x183459F70")]
		private void EBCGNHAEELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3459F80", Offset = "0x3459180", VA = "0x183459F80")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x345A040", Offset = "0x3459240", VA = "0x18345A040")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3459F90", Offset = "0x3459190", VA = "0x183459F90")]
		private void GJJOOOJIAAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3459CF0", Offset = "0x3458EF0", VA = "0x183459CF0")]
		[IteratorStateMachine(typeof(FKNPEGFNDBO))]
		private IEnumerator CHAAKFJCLIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x345A7B0", Offset = "0x34599B0", VA = "0x18345A7B0")]
		public KFBABPAPIMB Run(IEnumerator<KENFJGFMIPM> GAHCJOMJGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x345A7C0", Offset = "0x34599C0", VA = "0x18345A7C0")]
		public KFBABPAPIMB Run(Behaviour LHOMKMINCHH, IEnumerator<KENFJGFMIPM> GAHCJOMJGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x345A680", Offset = "0x3459880", VA = "0x18345A680")]
		public KFBABPAPIMB RunJobbed(BPGLFKPKJHF LHOMKMINCHH, IEnumerator<KENFJGFMIPM> GAHCJOMJGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3459F10", Offset = "0x3459110", VA = "0x183459F10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x345AAE0", Offset = "0x3459CE0", VA = "0x18345AAE0")]
		public void UpdateQueue(NEIJEKIKDOG DKGFKIKFBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3459D50", Offset = "0x3458F50", VA = "0x183459D50")]
		private void CLODBMLECIA(GOPOCOOMEIM KAMCDGAHIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x345A050", Offset = "0x3459250", VA = "0x18345A050")]
		private void MNKNBBMICOI(IALKDLLHDII KAMCDGAHIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x345B010", Offset = "0x345A210", VA = "0x18345B010")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface FNPGPAPOHAN
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float EDNCMGJJLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float FFPPABMIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	float PIBBOFCHMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int JHNNFDHLJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	double NCBJKCHIKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class CNCOALCNHBC : FNPGPAPOHAN
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float EDNCMGJJLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x344AD00", Offset = "0x3449F00", VA = "0x18344AD00", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float FFPPABMIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x344ACF0", Offset = "0x3449EF0", VA = "0x18344ACF0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public float PIBBOFCHMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x344AD10", Offset = "0x3449F10", VA = "0x18344AD10", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int JHNNFDHLJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x344ACE0", Offset = "0x3449EE0", VA = "0x18344ACE0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public double NCBJKCHIKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x344ACC0", Offset = "0x3449EC0", VA = "0x18344ACC0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
	public CNCOALCNHBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class FIFNHIILPEL : HAPBACHHIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public int BIOFILJOKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly Queue<double> PHEJDGHGEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double FFOJBDNKMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private double PMCAKBEJBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private double OFDBBHKOJKI;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int LINEHPICCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x344E5B0", Offset = "0x344D7B0", VA = "0x18344E5B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public double OOPCGBFJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x344E4E0", Offset = "0x344D6E0", VA = "0x18344E4E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public double GMBEJJBNGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x165C290", Offset = "0x165B490", VA = "0x18165C290", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public double JIODMOCKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2A83280", Offset = "0x2A82480", VA = "0x182A83280", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x344E5F0", Offset = "0x344D7F0", VA = "0x18344E5F0")]
	public FIFNHIILPEL(int EPHMNMCMOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x344E3E0", Offset = "0x344D5E0", VA = "0x18344E3E0", Slot = "4")]
	public void EHGIOHLBHJN(double MBJCIBHEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x344E540", Offset = "0x344D740", VA = "0x18344E540", Slot = "5")]
	public void JBBLIBHHEBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class ABHKLOENLLE : HAPBACHHIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private long MNIJHBJDPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private double ILPMEPPIJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private double OMGFKNCEEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private double BHEKBIIIJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double BEJJCLLNDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private double FFOJBDNKMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private double PMCAKBEJBFN;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public long MEPGPGKFENE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x40DED0", Offset = "0x40D0D0", VA = "0x18040DED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public double GMBEJJBNGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x47DF60", Offset = "0x47D160", VA = "0x18047DF60", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public double JIODMOCKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A832F0", Offset = "0x2A824F0", VA = "0x182A832F0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public double GGEADKGMGDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2A83280", Offset = "0x2A82480", VA = "0x182A83280")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public double JDPBPFKMGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3104400", Offset = "0x3103600", VA = "0x183104400")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public double OOPCGBFJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A831B0", Offset = "0x2A823B0", VA = "0x182A831B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3449110", Offset = "0x3448310", VA = "0x183449110", Slot = "4")]
	public void EHGIOHLBHJN(double MBJCIBHEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3449230", Offset = "0x3448430", VA = "0x183449230", Slot = "5")]
	public void JBBLIBHHEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3449270", Offset = "0x3448470", VA = "0x183449270")]
	public ABHKLOENLLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface HAPBACHHIBN
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	double OOPCGBFJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	double GMBEJJBNGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	double JIODMOCKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHGIOHLBHJN(double MBJCIBHEOMM);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBBLIBHHEBC();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class LJLGDKLOFMO
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private interface OJCONDGBEIA
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		bool MMICKFMMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OOOIENHGNCA();

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KBPKIDJEOFB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private abstract class JDIOECLPOPK<TPromise, TMainThreadPromise> : OJCONDGBEIA where TPromise : DABKFAIHBBP where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly TPromise GMLHFPFHBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		protected readonly TMainThreadPromise IDAPKKELNMM;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public TPromise DENADOGFMKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EA50", Offset = "0x1E7DC50", VA = "0x181E7EA50")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool MMICKFMMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x1E7EA00", Offset = "0x1E7DC00", VA = "0x181E7EA00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x16FD480", Offset = "0x16FC680", VA = "0x1816FD480")]
		protected JDIOECLPOPK(TPromise GMLHFPFHBJD, TMainThreadPromise BLFADPCOALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x1E7EAB0", Offset = "0x1E7DCB0", VA = "0x181E7EAB0", Slot = "5")]
		public void OOOIENHGNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x19F1930", Offset = "0x19F0B30", VA = "0x1819F1930", Slot = "6")]
		public void KBPKIDJEOFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void AMPLEOCGJBM(TPromise GMLHFPFHBJD);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void GHCAGDCCIPD();
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class BCAIFPDOAMM<T> : JDIOECLPOPK<global::PMGCJEPKFOF<T>, global::CBLLFJEDOII<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1E7BDE0", Offset = "0x1E7AFE0", VA = "0x181E7BDE0")]
		public BCAIFPDOAMM(global::PMGCJEPKFOF<T> GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B940", Offset = "0x1E7AB40", VA = "0x181E7B940", Slot = "7")]
		protected override void AMPLEOCGJBM(global::PMGCJEPKFOF<T> GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x1E7BD10", Offset = "0x1E7AF10", VA = "0x181E7BD10", Slot = "8")]
		protected override void GHCAGDCCIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x1E7BD70", Offset = "0x1E7AF70", VA = "0x181E7BD70")]
		[CompilerGenerated]
		private void NIJANLDDIMP(T GIAOBLMEMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x1E7BC80", Offset = "0x1E7AE80", VA = "0x181E7BC80")]
		[CompilerGenerated]
		private void FGCPLDIEGKO(string MOPOMPHBHKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class EHEDHJDLBCH : JDIOECLPOPK<DABKFAIHBBP, JJEKJGALHKO>
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x344D140", Offset = "0x344C340", VA = "0x18344D140")]
		public EHEDHJDLBCH(DABKFAIHBBP GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x344D020", Offset = "0x344C220", VA = "0x18344D020", Slot = "7")]
		protected override void AMPLEOCGJBM(DABKFAIHBBP GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x344D0F0", Offset = "0x344C2F0", VA = "0x18344D0F0", Slot = "8")]
		protected override void GHCAGDCCIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xBCDD60", Offset = "0xBCCF60", VA = "0x180BCDD60")]
		[CompilerGenerated]
		private void NIJANLDDIMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1348CE0", Offset = "0x1347EE0", VA = "0x181348CE0")]
		[CompilerGenerated]
		private void FGCPLDIEGKO(string MOPOMPHBHKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class HLPAFHONKPA : OJCONDGBEIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private readonly Action JJGHIEJCCDA;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool MMICKFMMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CA0", Offset = "0x3F1EA0", VA = "0x1803F2CA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3F1200", Offset = "0x3F0400", VA = "0x1803F1200")]
		public HLPAFHONKPA(Action JJGHIEJCCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x13486D0", Offset = "0x13478D0", VA = "0x1813486D0", Slot = "5")]
		public void OOOIENHGNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "6")]
		public void KBPKIDJEOFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly List<OJCONDGBEIA> GEONEIIGPNH;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x1E01DD0", Offset = "0x1E00FD0", VA = "0x181E01DD0")]
	public static global::PMGCJEPKFOF<T> DNMKIEAJOJH<T>(this global::PMGCJEPKFOF<T> GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x34570E0", Offset = "0x34562E0", VA = "0x1834570E0")]
	public static DABKFAIHBBP DNMKIEAJOJH(this DABKFAIHBBP GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3457060", Offset = "0x3456260", VA = "0x183457060")]
	public static void DNMKIEAJOJH(Action JJGHIEJCCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1E01EB0", Offset = "0x1E010B0", VA = "0x181E01EB0")]
	private static global::PMGCJEPKFOF<T> LINADCCOBCC<T>(global::PMGCJEPKFOF<T> GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3457550", Offset = "0x3456750", VA = "0x183457550")]
	private static DABKFAIHBBP LINADCCOBCC(DABKFAIHBBP GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3457370", Offset = "0x3456570", VA = "0x183457370")]
	private static void IIGMDIHDNJD(OJCONDGBEIA BKCGDDGIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3456D40", Offset = "0x3455F40", VA = "0x183456D40")]
	private static void COAPLNGMFKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x34571F0", Offset = "0x34563F0", VA = "0x1834571F0")]
	private static void EHDOBJFCNEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x34572C0", Offset = "0x34564C0", VA = "0x1834572C0")]
	private static void HLHALAIDKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class OEGOFBEELGL
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class AFMMLANPFJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public HHKIEEPFDOH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int sceneIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public bool async;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public AFMMLANPFJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3449F40", Offset = "0x3449140", VA = "0x183449F40")]
		internal void <LoadSceneInternal>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class KOMABPOMOIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public JJEKJGALHKO onCompletePromise;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public KOMABPOMOIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class GCGHCJFIFJD : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
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
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private KOMABPOMOIG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public bool async;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public int sceneIndex;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
		[DebuggerHidden]
		public GCGHCJFIFJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x344E850", Offset = "0x344DA50", VA = "0x18344E850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x344EB10", Offset = "0x344DD10", VA = "0x18344EB10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class MLKCPGBEIBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public JJEKJGALHKO onCompletePromise;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public MLKCPGBEIBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class OAAJDGLCAHN : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public JJEKJGALHKO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private MLKCPGBEIBM <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
		[DebuggerHidden]
		public OAAJDGLCAHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3457C80", Offset = "0x3456E80", VA = "0x183457C80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3457DF0", Offset = "0x3456FF0", VA = "0x183457DF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public const string LLDNCJNLPGL = "empty";

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public const string BMCBAGEGBLI = "moderator";

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public const string AFKGHCNJPBB = "main_root";

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public const string PGIAKFDKOEH = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public const string OPEMHLDGDEA = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static CDJFFFCFLMF HPLJCGDFOOG;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static AsyncOperation NIELPFKCFMF;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool CCEJLKMLKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3458370", Offset = "0x3457570", VA = "0x183458370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3458110", Offset = "0x3457310", VA = "0x183458110")]
	public static CDJFFFCFLMF BBOHJKKLCKO(string PCBCJKHMBGL, LoadSceneMode GNOCFLPOFIB = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x34583D0", Offset = "0x34575D0", VA = "0x1834583D0")]
	public static CDJFFFCFLMF ELELHAFLKOJ(int KOIKDOKJCIJ, LoadSceneMode GNOCFLPOFIB = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x3458600", Offset = "0x3457800", VA = "0x183458600")]
	public static CDJFFFCFLMF NNGPPPJMJIK(string PCBCJKHMBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x3458400", Offset = "0x3457600", VA = "0x183458400")]
	private static CDJFFFCFLMF GLKEINDEIHJ(string PCBCJKHMBGL, int KOIKDOKJCIJ, LoadSceneMode GNOCFLPOFIB, bool ONLCDILFJMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3458070", Offset = "0x3457270", VA = "0x183458070")]
	[IteratorStateMachine(typeof(GCGHCJFIFJD))]
	private static IEnumerator<KENFJGFMIPM> AJDIEMKKFGG(string PCBCJKHMBGL, int KOIKDOKJCIJ, LoadSceneMode GNOCFLPOFIB, bool ONLCDILFJMC, JJEKJGALHKO OCHKEPDILKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3458140", Offset = "0x3457340", VA = "0x183458140")]
	private static CDJFFFCFLMF BNGOOIBMADF(string PCBCJKHMBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x3458000", Offset = "0x3457200", VA = "0x183458000")]
	[IteratorStateMachine(typeof(OAAJDGLCAHN))]
	private static IEnumerator<KENFJGFMIPM> AIHIKAFCMAM(string PCBCJKHMBGL, JJEKJGALHKO OCHKEPDILKF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class FFAFDAOBAHN
{
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static byte[] OHCLMBBDJLC;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static int NJPHPOMKGAO;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static int NCHLFMFMLBC;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static BigInteger AEEDJIDCNEO;

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x344DBE0", Offset = "0x344CDE0", VA = "0x18344DBE0")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x344DCE0", Offset = "0x344CEE0", VA = "0x18344DCE0")]
	public static string PAMIGJPGHHB(byte[] MGPDDEMABPB, bool KOILKPGDKMG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
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

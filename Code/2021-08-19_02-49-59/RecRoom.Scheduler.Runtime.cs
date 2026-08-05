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
				[Cpp2IlInjected.Address(RVA = "0x341F820", Offset = "0x341EC20", VA = "0x18341F820")]
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
				[Cpp2IlInjected.Address(RVA = "0x34142D0", Offset = "0x34136D0", VA = "0x1834142D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3412F80", Offset = "0x3412380", VA = "0x183412F80")]
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
					[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
					public JNDDNMLJFDO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x341B700", Offset = "0x341AB00", VA = "0x18341B700")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDisposable DFHFIANOKID;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x3413BF0", Offset = "0x3412FF0", VA = "0x183413BF0")]
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
					[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
					public FGHMPJKFPEE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x3414480", Offset = "0x3413880", VA = "0x183414480")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x3412E80", Offset = "0x3412280", VA = "0x183412E80")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
			public MEHOILAECLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x341D9F0", Offset = "0x341CDF0", VA = "0x18341D9F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x34127F0", Offset = "0x3411BF0", VA = "0x1834127F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3412450", Offset = "0x3411850", VA = "0x183412450")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3411600", Offset = "0x3410A00", VA = "0x183411600")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3412490", Offset = "0x3411890", VA = "0x183412490")]
		private static void KHFAOCKFOMG(ELGIGKJCDID.PEEOJJCEFPE DNGKIAJLLHG, ref PlayerLoopSystem INJAGKJAPKC, Type IAFJLDHNNAG, Type MCNLGODIENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3412830", Offset = "0x3411C30", VA = "0x183412830")]
		private static void PIDOJLLLMLO(ref PlayerLoopSystem INJAGKJAPKC, Type IAFJLDHNNAG, Type MCNLGODIENM, AHJIPNEIGPG BNLLHBCJFOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x34126F0", Offset = "0x3411AF0", VA = "0x1834126F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3413AF0", Offset = "0x3412EF0", VA = "0x183413AF0")]
		public FDGHJJOBMOD(PEEOJJCEFPE DOOFHEFHHGI, int NMIMOBMHDAF = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x34138D0", Offset = "0x3412CD0", VA = "0x1834138D0")]
		public void BLFLBLDMBBK(int AAEANOFBLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x34138F0", Offset = "0x3412CF0", VA = "0x1834138F0")]
		public void HFJPBHFKHPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x34138A0", Offset = "0x3412CA0", VA = "0x1834138A0")]
		public void BAPLIBPCJLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x34139B0", Offset = "0x3412DB0", VA = "0x1834139B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x34132C0", Offset = "0x34126C0", VA = "0x1834132C0")]
	public static FDGHJJOBMOD AKFOAKIHIBH(PEEOJJCEFPE DNGKIAJLLHG, int NMIMOBMHDAF = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3413480", Offset = "0x3412880", VA = "0x183413480")]
	public static FDGHJJOBMOD CCOLPLDBPEN(PEEOJJCEFPE DNGKIAJLLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3413510", Offset = "0x3412910", VA = "0x183413510")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
		public CLKPFIJHGLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3410E70", Offset = "0x3410270", VA = "0x183410E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
		public OGBHHMOKMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3410E70", Offset = "0x3410270", VA = "0x183410E70")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly float IFDHHDIIAAG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3410E20", Offset = "0x3410220", VA = "0x183410E20")]
	public DECOBNDCNFA(Behaviour LHOMKMINCHH, float IFDHHDIIAAG, [Optional] Action EJAIEDPNOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3412CE0", Offset = "0x34120E0", VA = "0x183412CE0", Slot = "9")]
	protected override bool EEJEOHAODHB(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3412DB0", Offset = "0x34121B0", VA = "0x183412DB0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3F8210", Offset = "0x3F7610", VA = "0x1803F8210")]
		[DebuggerHidden]
		public MHJIDBHBMGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3F8200", Offset = "0x3F7600", VA = "0x1803F8200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x341DAF0", Offset = "0x341CEF0", VA = "0x18341DAF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x341DB90", Offset = "0x341CF90", VA = "0x18341DB90", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x54C040", Offset = "0x54B440", VA = "0x18054C040", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OGODIKKKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3417750", Offset = "0x3416B50", VA = "0x183417750", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x34176B0", Offset = "0x3416AB0", VA = "0x1834176B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x155F0D0", Offset = "0x155E4D0", VA = "0x18155F0D0")]
	protected HOMBMCGGPOD(Behaviour LHOMKMINCHH, [Optional] Action EJAIEDPNOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3417AD0", Offset = "0x3416ED0", VA = "0x183417AD0", Slot = "7")]
	public bool PFFOFIHGOEA(bool CDFHDACBFKN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3417B30", Offset = "0x3416F30", VA = "0x183417B30", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x34177F0", Offset = "0x3416BF0", VA = "0x1834177F0")]
	protected void HLOEPMHHGKE(Action JJGHIEJCCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3417900", Offset = "0x3416D00", VA = "0x183417900")]
	protected DABKFAIHBBP PAAAGNNFMLG(float BJJEDIGOMGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3417890", Offset = "0x3416C90", VA = "0x183417890")]
	private void KDPCHEJAGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3417810", Offset = "0x3416C10", VA = "0x183417810")]
	[IteratorStateMachine(typeof(MHJIDBHBMGM))]
	private static IEnumerator<KENFJGFMIPM> HOPCEMPGALM(float BJJEDIGOMGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3417870", Offset = "0x3416C70", VA = "0x183417870")]
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
		[Cpp2IlInjected.Address(RVA = "0x41A4A0", Offset = "0x4198A0", VA = "0x18041A4A0")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x41A4B0", Offset = "0x4198B0", VA = "0x18041A4B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x341F710", Offset = "0x341EB10", VA = "0x18341F710")]
	public PHJNILKEAAI(Behaviour LHOMKMINCHH, float JHPBDEKPCKP, int OFOIBLJPHGE, [Optional] Action EJAIEDPNOIG, float DNHGIAAFCLE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x41D9B0", Offset = "0x41CDB0", VA = "0x18041D9B0", Slot = "9")]
	protected override bool EEJEOHAODHB(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x341F460", Offset = "0x341E860", VA = "0x18341F460", Slot = "10")]
	protected override bool KLJHDBCCABK(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x341F680", Offset = "0x341EA80", VA = "0x18341F680")]
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
	[Cpp2IlInjected.Address(RVA = "0x3410E20", Offset = "0x3410220", VA = "0x183410E20")]
	public CKNNCLNMAPG(Behaviour LHOMKMINCHH, float IFDHHDIIAAG, [Optional] Action EJAIEDPNOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x41D9B0", Offset = "0x41CDB0", VA = "0x18041D9B0", Slot = "9")]
	protected override bool EEJEOHAODHB(Action JJGHIEJCCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3410DE0", Offset = "0x34101E0", VA = "0x183410DE0", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x5A4AD0", Offset = "0x5A3ED0", VA = "0x1805A4AD0")]
	public GHMCDEEFOLC(Action NGEMKGIAPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x34152C0", Offset = "0x34146C0", VA = "0x1834152C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1001010", Offset = "0x1000410", VA = "0x181001010")]
		public GCFGNJEEJPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x248FBF0", Offset = "0x248EFF0", VA = "0x18248FBF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x249A1A0", Offset = "0x24995A0", VA = "0x18249A1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T DMLIOOCLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4454F0", Offset = "0x4448F0", VA = "0x1804454F0", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2499A00", Offset = "0x2498E00", VA = "0x182499A00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2499AF0", Offset = "0x2498EF0", VA = "0x182499AF0")]
	private static bool LPHFKINGMHN(T IPHIIJNAEON, T FOJLJNMAJLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x249A600", Offset = "0x2499A00", VA = "0x18249A600")]
	public KAGJDGDAADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x249A6C0", Offset = "0x2499AC0", VA = "0x18249A6C0")]
	public KAGJDGDAADK(T KMHEHJCNMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x249A5E0", Offset = "0x24999E0", VA = "0x18249A5E0")]
	public void MOCMFLAMJHA(T BCEFAKDFEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2499850", Offset = "0x2498C50", VA = "0x182499850", Slot = "7")]
	public IDisposable JAHAHHAFAPC(Action<T> CCHCBCLCFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x24998C0", Offset = "0x2498CC0", VA = "0x1824998C0", Slot = "8")]
	public IDisposable JAHAHHAFAPC(UnityEngine.Object LHOMKMINCHH, Action<T> CCHCBCLCFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2499E80", Offset = "0x2499280", VA = "0x182499E80")]
	private void LPKBPIMHHOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class LCNLICMJMPA
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class HGMFKHBJOGH : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3F8210", Offset = "0x3F7610", VA = "0x1803F8210")]
		[DebuggerHidden]
		public HGMFKHBJOGH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3F8200", Offset = "0x3F7600", VA = "0x1803F8200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x34175C0", Offset = "0x34169C0", VA = "0x1834175C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3417660", Offset = "0x3416A60", VA = "0x183417660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class CCDPFNOHGPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public DABKFAIHBBP promise;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
		public CCDPFNOHGPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3410C90", Offset = "0x3410090", VA = "0x183410C90")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class OKJBALMPINJ : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3F8210", Offset = "0x3F7610", VA = "0x1803F8210")]
		[DebuggerHidden]
		public OKJBALMPINJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3F8200", Offset = "0x3F7600", VA = "0x1803F8200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x341E6A0", Offset = "0x341DAA0", VA = "0x18341E6A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x341E790", Offset = "0x341DB90", VA = "0x18341E790", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x341CA70", Offset = "0x341BE70", VA = "0x18341CA70")]
	public static KENFJGFMIPM LEIMHFLNIKB(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x341C950", Offset = "0x341BD50", VA = "0x18341C950")]
	public static KENFJGFMIPM DBOLCCOJBOI(float HABFNPMBADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x341CA00", Offset = "0x341BE00", VA = "0x18341CA00")]
	[IteratorStateMachine(typeof(HGMFKHBJOGH))]
	public static IEnumerator<KENFJGFMIPM> FDHJPDHIMME(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x341CB50", Offset = "0x341BF50", VA = "0x18341CB50")]
	public static KENFJGFMIPM LINOLLIBDCO(Func<bool> LKMLNOJIFHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x341CBB0", Offset = "0x341BFB0", VA = "0x18341CBB0")]
	public static KENFJGFMIPM OPDGBNPLNHG(DABKFAIHBBP NKLGAGCHGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x341C9B0", Offset = "0x341BDB0", VA = "0x18341C9B0")]
	[IteratorStateMachine(typeof(OKJBALMPINJ))]
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
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
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
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3F8210", Offset = "0x3F7610", VA = "0x1803F8210")]
		[DebuggerHidden]
		public KBIEPEFBMPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3F8200", Offset = "0x3F7600", VA = "0x1803F8200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x341B780", Offset = "0x341AB80", VA = "0x18341B780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x341B850", Offset = "0x341AC50", VA = "0x18341B850", Slot = "8")]
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
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3F8210", Offset = "0x3F7610", VA = "0x1803F8210")]
		[DebuggerHidden]
		public DDPJLKFDDNM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3F8200", Offset = "0x3F7600", VA = "0x1803F8200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3412BA0", Offset = "0x3411FA0", VA = "0x183412BA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3412C90", Offset = "0x3412090", VA = "0x183412C90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x410F20", Offset = "0x410320", VA = "0x180410F20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x465280", Offset = "0x464680", VA = "0x180465280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6C8320", Offset = "0x6C7720", VA = "0x1806C8320", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3F8210", Offset = "0x3F7610", VA = "0x1803F8210")]
	public CPHEMJCNNDB(Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x40F420", Offset = "0x40E820", VA = "0x18040F420", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3411210", Offset = "0x3410610", VA = "0x183411210")]
	public static KFBABPAPIMB GIEOOLAGCKA(Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3411120", Offset = "0x3410520", VA = "0x183411120")]
	public static KFBABPAPIMB GIEOOLAGCKA(Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3411410", Offset = "0x3410810", VA = "0x183411410")]
	public static KFBABPAPIMB GIEOOLAGCKA(Behaviour LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3411300", Offset = "0x3410700", VA = "0x183411300")]
	public static KFBABPAPIMB GIEOOLAGCKA(Behaviour LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3411010", Offset = "0x3410410", VA = "0x183411010")]
	public static KFBABPAPIMB DJJOEODIBEE(BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3410F00", Offset = "0x3410300", VA = "0x183410F00")]
	public static KFBABPAPIMB DJJOEODIBEE(BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3411590", Offset = "0x3410990", VA = "0x183411590")]
	[IteratorStateMachine(typeof(KBIEPEFBMPJ))]
	private static IEnumerator<KENFJGFMIPM> OKAOGDPNEKD(Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3411520", Offset = "0x3410920", VA = "0x183411520")]
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
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3F8210", Offset = "0x3F7610", VA = "0x1803F8210")]
		[DebuggerHidden]
		public NIOKFBABMOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3F8200", Offset = "0x3F7600", VA = "0x1803F8200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x341DC20", Offset = "0x341D020", VA = "0x18341DC20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x341DDC0", Offset = "0x341D1C0", VA = "0x18341DDC0", Slot = "8")]
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
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x41EDA0", Offset = "0x41E1A0", VA = "0x18041EDA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x466030", Offset = "0x465430", VA = "0x180466030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x446040", Offset = "0x445440", VA = "0x180446040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x446210", Offset = "0x445610", VA = "0x180446210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x466590", Offset = "0x465990", VA = "0x180466590", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x466760", Offset = "0x465B60", VA = "0x180466760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float FFPPABMIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x466770", Offset = "0x465B70", VA = "0x180466770")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4664B0", Offset = "0x4658B0", VA = "0x1804664B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3410730", Offset = "0x340FB30", VA = "0x183410730")]
	public BECNBPANOEI(float CKGGPPMDDBP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x34103D0", Offset = "0x340F7D0", VA = "0x1834103D0", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x34106A0", Offset = "0x340FAA0", VA = "0x1834106A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x34103F0", Offset = "0x340F7F0", VA = "0x1834103F0")]
	public static KFBABPAPIMB GIEOOLAGCKA(float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x34104A0", Offset = "0x340F8A0", VA = "0x1834104A0")]
	public static KFBABPAPIMB GIEOOLAGCKA(MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3410560", Offset = "0x340F960", VA = "0x183410560")]
	public static KFBABPAPIMB HFKCNODKFKG(BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3410620", Offset = "0x340FA20", VA = "0x183410620")]
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
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x463380", Offset = "0x462780", VA = "0x180463380", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5621F0", Offset = "0x5615F0", VA = "0x1805621F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x41EDA0", Offset = "0x41E1A0", VA = "0x18041EDA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x466030", Offset = "0x465430", VA = "0x180466030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3413720", Offset = "0x3412B20", VA = "0x183413720")]
	public ENKGACHBJCJ(Func<bool> LKMLNOJIFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3413750", Offset = "0x3412B50", VA = "0x183413750")]
	public ENKGACHBJCJ(Scheduler.NEIJEKIKDOG CKFELIAJKCP, Func<bool> LKMLNOJIFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x34136D0", Offset = "0x3412AD0", VA = "0x1834136D0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F8210", Offset = "0x3F7610", VA = "0x1803F8210")]
		[DebuggerHidden]
		public NONJFBJHGEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3F8200", Offset = "0x3F7600", VA = "0x1803F8200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x341DE10", Offset = "0x341D210", VA = "0x18341DE10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x341DEB0", Offset = "0x341D2B0", VA = "0x18341DEB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x341DF00", Offset = "0x341D300", VA = "0x18341DF00")]
	[IteratorStateMachine(typeof(NONJFBJHGEM))]
	private static IEnumerator<KENFJGFMIPM> AGGNPLMDKGE(Scheduler.NEIJEKIKDOG CKFELIAJKCP, Func<bool> LKMLNOJIFHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x341DF70", Offset = "0x341D370", VA = "0x18341DF70")]
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
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4592B0", Offset = "0x4586B0", VA = "0x1804592B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x459170", Offset = "0x458570", VA = "0x180459170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x41ED90", Offset = "0x41E190", VA = "0x18041ED90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4664A0", Offset = "0x4658A0", VA = "0x1804664A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x341B650", Offset = "0x341AA50", VA = "0x18341B650")]
	public JMOPCCPBNMB(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA = Scheduler.NEIJEKIKDOG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x341B5C0", Offset = "0x341A9C0", VA = "0x18341B5C0", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class CBJBEIEKLBB : KENFJGFMIPM
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private const float NPJBNADMBDH = 0.1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly float FNNJGLMMINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private float CMKOPHJFKIK;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Scheduler.NEIJEKIKDOG ALLFDCFPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4625B0", Offset = "0x4619B0", VA = "0x1804625B0", Slot = "4")]
		get
		{
			return default(Scheduler.NEIJEKIKDOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float OGNHNKIKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6C8320", Offset = "0x6C7720", VA = "0x1806C8320", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F9F430", Offset = "0x2F9E830", VA = "0x182F9F430")]
	public CBJBEIEKLBB(float HABFNPMBADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3410BF0", Offset = "0x340FFF0", VA = "0x183410BF0", Slot = "5")]
	public bool GAPNCPOLFEI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class IPFBKNOHEGB
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class CHFAJCJLJLB : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3F8210", Offset = "0x3F7610", VA = "0x1803F8210")]
		[DebuggerHidden]
		public CHFAJCJLJLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3F8200", Offset = "0x3F7600", VA = "0x1803F8200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3410CE0", Offset = "0x34100E0", VA = "0x183410CE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3410D90", Offset = "0x3410190", VA = "0x183410D90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class EOMJHPHEMLH : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Scheduler.NEIJEKIKDOG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private KENFJGFMIPM <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3F8210", Offset = "0x3F7610", VA = "0x1803F8210")]
		[DebuggerHidden]
		public EOMJHPHEMLH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F8200", Offset = "0x3F7600", VA = "0x1803F8200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3413790", Offset = "0x3412B90", VA = "0x183413790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3413850", Offset = "0x3412C50", VA = "0x183413850", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x341AD00", Offset = "0x341A100", VA = "0x18341AD00")]
	[IteratorStateMachine(typeof(CHFAJCJLJLB))]
	private static IEnumerator<KENFJGFMIPM> HEBGBPGEFPK(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x341AB10", Offset = "0x3419F10", VA = "0x18341AB10")]
	[IteratorStateMachine(typeof(EOMJHPHEMLH))]
	private static IEnumerator<KENFJGFMIPM> DBNBNAILAFO(float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x341B2F0", Offset = "0x341A6F0", VA = "0x18341B2F0")]
	public static IDisposable PBPKBANPKJP(this MonoBehaviour BKGIHIBDAPA, float HABFNPMBADP, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x341ABA0", Offset = "0x3419FA0", VA = "0x18341ABA0")]
	public static KFBABPAPIMB ENFHDIBGOEO(this MonoBehaviour BKGIHIBDAPA, float HABFNPMBADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x341B430", Offset = "0x341A830", VA = "0x18341B430")]
	public static KFBABPAPIMB PBPKBANPKJP(this MonoBehaviour BKGIHIBDAPA, float HABFNPMBADP, Scheduler.NEIJEKIKDOG MJHMBNIDGCA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x341ACE0", Offset = "0x341A0E0", VA = "0x18341ACE0")]
	public static KFBABPAPIMB FHKNPABNEEM(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x341AD80", Offset = "0x341A180", VA = "0x18341AD80")]
	public static KFBABPAPIMB HECMPBHFOEA(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x341AB90", Offset = "0x3419F90", VA = "0x18341AB90")]
	public static KFBABPAPIMB EGOJDKEBMNH(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x341ACF0", Offset = "0x341A0F0", VA = "0x18341ACF0")]
	public static KFBABPAPIMB GGGCLEIGKCE(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x341AEA0", Offset = "0x341A2A0", VA = "0x18341AEA0")]
	public static KFBABPAPIMB JGIPMJPPCBM(this MonoBehaviour BKGIHIBDAPA, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x341AA00", Offset = "0x3419E00", VA = "0x18341AA00")]
	private static KFBABPAPIMB AKNLAJLAGMB(MonoBehaviour BKGIHIBDAPA, Scheduler.NEIJEKIKDOG CKFELIAJKCP, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x341B0D0", Offset = "0x341A4D0", VA = "0x18341B0D0")]
	public static KFBABPAPIMB NLBLFPBOCLD(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x341B1E0", Offset = "0x341A5E0", VA = "0x18341B1E0")]
	public static KFBABPAPIMB PAKNHKEKDAF(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x341AD90", Offset = "0x341A190", VA = "0x18341AD90")]
	public static KFBABPAPIMB INLJFAKDKAD(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x341AFC0", Offset = "0x341A3C0", VA = "0x18341AFC0")]
	public static KFBABPAPIMB LBLNPIDACFM(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x341AEB0", Offset = "0x341A2B0", VA = "0x18341AEB0")]
	public static KFBABPAPIMB JOOHIGCAKNF(this MonoBehaviour BKGIHIBDAPA, float GMJDLIAHKAK, Action HEGICCDLHIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class ICMKAJELBGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class ILPPIMNIHBJ : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3F8210", Offset = "0x3F7610", VA = "0x1803F8210")]
		[DebuggerHidden]
		public ILPPIMNIHBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3F8200", Offset = "0x3F7600", VA = "0x1803F8200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x341A900", Offset = "0x3419D00", VA = "0x18341A900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x341A9B0", Offset = "0x3419DB0", VA = "0x18341A9B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private KFBABPAPIMB KHPFGANHBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private MonoBehaviour BKGIHIBDAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private Action JFKDDPJDCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private Action<float> HBMODGLEAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private Scheduler.NEIJEKIKDOG CKFELIAJKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private float FJKINHFIBJA;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x341A770", Offset = "0x3419B70", VA = "0x18341A770")]
	public ICMKAJELBGE(MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x341A490", Offset = "0x3419890", VA = "0x18341A490")]
	public ICMKAJELBGE(MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x341A620", Offset = "0x3419A20", VA = "0x18341A620")]
	public ICMKAJELBGE(MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x341A0C0", Offset = "0x34194C0", VA = "0x18341A0C0")]
	private void GIEOOLAGCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3419EC0", Offset = "0x34192C0", VA = "0x183419EC0")]
	private void EBPHAECHJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x341A240", Offset = "0x3419640", VA = "0x18341A240")]
	private void HCMLBCFDNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x341A370", Offset = "0x3419770", VA = "0x18341A370")]
	private void KEECGEIFLEN(string MOPOMPHBHKF, Action HGGDFJNNBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3419E10", Offset = "0x3419210", VA = "0x183419E10")]
	[IteratorStateMachine(typeof(ILPPIMNIHBJ))]
	private IEnumerator<KENFJGFMIPM> DEJICBOKAJH(Action HGGDFJNNBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3419E70", Offset = "0x3419270", VA = "0x183419E70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3419D90", Offset = "0x3419190", VA = "0x183419D90")]
	[CompilerGenerated]
	private void CKHMLHHHCLN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3419D10", Offset = "0x3419110", VA = "0x183419D10")]
	[CompilerGenerated]
	private void CBBGHNELPMN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x341A040", Offset = "0x3419440", VA = "0x18341A040")]
	[CompilerGenerated]
	private void GGEOKDFDCNK(string CHKKEHOKPJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class ADIFCODGAML
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x340FE60", Offset = "0x340F260", VA = "0x18340FE60")]
	public static IDisposable GIEOOLAGCKA(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x340FCA0", Offset = "0x340F0A0", VA = "0x18340FCA0")]
	public static IDisposable GIEOOLAGCKA(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x34102D0", Offset = "0x340F6D0", VA = "0x1834102D0")]
	public static IDisposable OPEMIFENIJM(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3410160", Offset = "0x340F560", VA = "0x183410160")]
	public static IDisposable MOJAICCOOMH(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x34101D0", Offset = "0x340F5D0", VA = "0x1834101D0")]
	public static IDisposable OEMBBKDJFCB(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x340FAB0", Offset = "0x340EEB0", VA = "0x18340FAB0")]
	public static IDisposable FHBCIFNCNMN(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x340FF60", Offset = "0x340F360", VA = "0x18340FF60")]
	public static IDisposable JEEMKGCKHKD(this MonoBehaviour BKGIHIBDAPA, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x340FFD0", Offset = "0x340F3D0", VA = "0x18340FFD0")]
	public static IDisposable LAHBIDHMCKF(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x340FB20", Offset = "0x340EF20", VA = "0x18340FB20")]
	public static IDisposable FLMKKKHMJBN(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x340F720", Offset = "0x340EB20", VA = "0x18340F720")]
	public static IDisposable AMNODMIDNHO(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x340FEE0", Offset = "0x340F2E0", VA = "0x18340FEE0")]
	public static IDisposable ICPMHNDIIFK(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x340F9A0", Offset = "0x340EDA0", VA = "0x18340F9A0")]
	public static IDisposable ENLMJBCKILF(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x340FC20", Offset = "0x340F020", VA = "0x18340FC20")]
	public static IDisposable FOFJADGKNJF(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3410060", Offset = "0x340F460", VA = "0x183410060")]
	public static IDisposable LFJPCEKGMIA(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x340F6A0", Offset = "0x340EAA0", VA = "0x18340F6A0")]
	public static IDisposable ADIDJGEIJOH(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3410240", Offset = "0x340F640", VA = "0x183410240")]
	public static IDisposable OIJBBPIBIJP(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x340F820", Offset = "0x340EC20", VA = "0x18340F820")]
	public static IDisposable AOPHLNHDOKN(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x340F8A0", Offset = "0x340ECA0", VA = "0x18340F8A0")]
	public static IDisposable BOHBPECGHLI(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x340FBA0", Offset = "0x340EFA0", VA = "0x18340FBA0")]
	public static IDisposable FNFEBJPKPEA(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x340FA20", Offset = "0x340EE20", VA = "0x18340FA20")]
	public static IDisposable FGFJPAFFKIN(this MonoBehaviour BKGIHIBDAPA, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x340F920", Offset = "0x340ED20", VA = "0x18340F920")]
	public static IDisposable CHFECAOLPEO(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x34100E0", Offset = "0x340F4E0", VA = "0x1834100E0")]
	public static IDisposable LGJLMMIHFON(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x340F7A0", Offset = "0x340EBA0", VA = "0x18340F7A0")]
	public static IDisposable AOPEPIBPFMP(this MonoBehaviour BKGIHIBDAPA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class OLKNGLHPDJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class FNFBHFJCFAI : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3F8210", Offset = "0x3F7610", VA = "0x1803F8210")]
		[DebuggerHidden]
		public FNFBHFJCFAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3F8200", Offset = "0x3F7600", VA = "0x1803F8200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x34148B0", Offset = "0x3413CB0", VA = "0x1834148B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3414960", Offset = "0x3413D60", VA = "0x183414960", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private KFBABPAPIMB KHPFGANHBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private BPGLFKPKJHF LHOMKMINCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Action JFKDDPJDCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Action<float> HBMODGLEAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Scheduler.NEIJEKIKDOG CKFELIAJKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private float FJKINHFIBJA;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x341EF60", Offset = "0x341E360", VA = "0x18341EF60")]
	public OLKNGLHPDJE(BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x341F240", Offset = "0x341E640", VA = "0x18341F240")]
	public OLKNGLHPDJE(BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x341F0F0", Offset = "0x341E4F0", VA = "0x18341F0F0")]
	public OLKNGLHPDJE(BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x341EB90", Offset = "0x341DF90", VA = "0x18341EB90")]
	private void GIEOOLAGCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x341E990", Offset = "0x341DD90", VA = "0x18341E990")]
	private void EBPHAECHJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x341ED10", Offset = "0x341E110", VA = "0x18341ED10")]
	private void HCMLBCFDNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x341EE40", Offset = "0x341E240", VA = "0x18341EE40")]
	private void KEECGEIFLEN(string MOPOMPHBHKF, Action HGGDFJNNBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x341E8E0", Offset = "0x341DCE0", VA = "0x18341E8E0")]
	[IteratorStateMachine(typeof(FNFBHFJCFAI))]
	private IEnumerator<KENFJGFMIPM> DEJICBOKAJH(Action HGGDFJNNBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x341E940", Offset = "0x341DD40", VA = "0x18341E940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x341E860", Offset = "0x341DC60", VA = "0x18341E860")]
	[CompilerGenerated]
	private void CKHMLHHHCLN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x341E7E0", Offset = "0x341DBE0", VA = "0x18341E7E0")]
	[CompilerGenerated]
	private void CBBGHNELPMN(string CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x341EB10", Offset = "0x341DF10", VA = "0x18341EB10")]
	[CompilerGenerated]
	private void GGEOKDFDCNK(string CHKKEHOKPJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KCBPNKMEDPI
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x341BCE0", Offset = "0x341B0E0", VA = "0x18341BCE0")]
	public static IDisposable DJJOEODIBEE(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x341BB20", Offset = "0x341AF20", VA = "0x18341BB20")]
	public static IDisposable DJJOEODIBEE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x341BD60", Offset = "0x341B160", VA = "0x18341BD60")]
	public static IDisposable EMGJKCCEAJA(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x341BED0", Offset = "0x341B2D0", VA = "0x18341BED0")]
	public static IDisposable GJCJNLFFLKP(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x341BE60", Offset = "0x341B260", VA = "0x18341BE60")]
	public static IDisposable GAPIDOHIBLG(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x341B9C0", Offset = "0x341ADC0", VA = "0x18341B9C0")]
	public static IDisposable CAJKNLABPBH(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x341BAB0", Offset = "0x341AEB0", VA = "0x18341BAB0")]
	public static IDisposable DGFNIKAEGMI(this BPGLFKPKJHF LHOMKMINCHH, Action JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x341BDD0", Offset = "0x341B1D0", VA = "0x18341BDD0")]
	public static IDisposable EOGNMLDAMCK(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC, Scheduler.NEIJEKIKDOG CKFELIAJKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x341C340", Offset = "0x341B740", VA = "0x18341C340")]
	public static IDisposable PBDKGIJCPCG(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x341C140", Offset = "0x341B540", VA = "0x18341C140")]
	public static IDisposable MHPNCCEFCID(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x341BF40", Offset = "0x341B340", VA = "0x18341BF40")]
	public static IDisposable HNFGDIHEFIO(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x341C2C0", Offset = "0x341B6C0", VA = "0x18341C2C0")]
	public static IDisposable ONEBONJNMNK(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x341B930", Offset = "0x341AD30", VA = "0x18341B930")]
	public static IDisposable BNJMDNLEDJB(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x341BFC0", Offset = "0x341B3C0", VA = "0x18341BFC0")]
	public static IDisposable IPPHMOEKHMO(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x341C1C0", Offset = "0x341B5C0", VA = "0x18341C1C0")]
	public static IDisposable NIIGGNNJAGE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x341C240", Offset = "0x341B640", VA = "0x18341C240")]
	public static IDisposable OBEEJIAEFKM(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x341B8A0", Offset = "0x341ACA0", VA = "0x18341B8A0")]
	public static IDisposable AGEPHCFGCMM(this BPGLFKPKJHF LHOMKMINCHH, float JCAEDLLGMHA, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x341BA30", Offset = "0x341AE30", VA = "0x18341BA30")]
	public static IDisposable CEILCDDBJHP(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x341C0C0", Offset = "0x341B4C0", VA = "0x18341C0C0")]
	public static IDisposable LJOHGJJMOGE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x341C040", Offset = "0x341B440", VA = "0x18341C040")]
	public static IDisposable KPDELENMDOE(this BPGLFKPKJHF LHOMKMINCHH, Action<float> JFKDDPJDCDC)
	{
		return null;
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class Scheduler : SingletonMonoBehaviour<Scheduler>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private class BMOEEDOECDC : NGHLNGJDGGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public IALKDLLHDII ALLFDCFPHGM;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public int AKGEGLEMFGM
			{
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x410F20", Offset = "0x410320", VA = "0x180410F20", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x465280", Offset = "0x464680", VA = "0x180465280")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x3410A90", Offset = "0x340FE90", VA = "0x183410A90")]
			public static KENFJGFMIPM NEPONCICACF(IEnumerator<KENFJGFMIPM> LOIIKGFHHAA, OMNCINDCAAJ NKLGAGCHGPM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x34109C0", Offset = "0x340FDC0", VA = "0x1834109C0")]
			public KENFJGFMIPM NEPONCICACF(OMNCINDCAAJ[] LMOONNDFEPE, IEnumerator<KENFJGFMIPM>[] JNMOEFOGKLE, KENFJGFMIPM[] DHGHPJHPPGE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3410990", Offset = "0x340FD90", VA = "0x183410990")]
			public void HNDCKFDJEKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x34108D0", Offset = "0x340FCD0", VA = "0x1834108D0")]
			public void CMDNNKIMLED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3410810", Offset = "0x340FC10", VA = "0x183410810")]
			public void AKIBJAOAEFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3410990", Offset = "0x340FD90", VA = "0x183410990")]
			public void KBPKIDJEOFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
			public BMOEEDOECDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class IALKDLLHDII
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			public struct CFBMJLPBODF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				public BMOEEDOECDC EOPDHGPFPNC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public BPGLFKPKJHF ADDDHPLGIKL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public OMNCINDCAAJ BAINEAGHDEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public IEnumerator<KENFJGFMIPM> HCIEHECEDAK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public KENFJGFMIPM JIGIMNNJHGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public KINIDGHKMLM HDECHJHCMDD;
			}

			[Cpp2IlInjected.Token(Token = "0x2000042")]
			public struct GIDICDINLFI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public NEIJEKIKDOG JDIEDFKCIGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public List<CFBMJLPBODF> BKPFCJJFMDB;
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class GHLCIHPNOIJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public BPGLFKPKJHF context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public BMOEEDOECDC routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public KINIDGHKMLM coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public OMNCINDCAAJ promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public KENFJGFMIPM currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public IEnumerator<KENFJGFMIPM> coroutine;

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
				public GHLCIHPNOIJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0x3414C70", Offset = "0x3414070", VA = "0x183414C70")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000044")]
			[CompilerGenerated]
			private sealed class JKHIMOPAHLJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public BMOEEDOECDC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600017D")]
				[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
				public JKHIMOPAHLJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x341B580", Offset = "0x341A980", VA = "0x18341B580")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class OEJBHOJOLNM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public BMOEEDOECDC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
				public OEJBHOJOLNM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000180")]
				[Cpp2IlInjected.Address(RVA = "0x341E660", Offset = "0x341DA60", VA = "0x18341E660")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000046")]
			[CompilerGenerated]
			private sealed class MLOIAKOIDDA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public BMOEEDOECDC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public IALKDLLHDII <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
				public MLOIAKOIDDA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000182")]
				[Cpp2IlInjected.Address(RVA = "0x341DBE0", Offset = "0x341CFE0", VA = "0x18341DBE0")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private readonly NEIJEKIKDOG CKFELIAJKCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private bool[] OHHCKBGGNCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private NativeArray<KINIDGHKMLM> NGPEDHJDGOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private NativeArray<float> EGPCFKONLDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private NativeArray<int> DIPODGDEDFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private NativeArray<int> ADMMJMECAAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private NativeArray<int> GDENALHIFED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private NativeArray<int> MFFNBPCJDPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private NativeArray<int> LKNDAPBEAHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private BMOEEDOECDC[] EICHIBKNPKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private OMNCINDCAAJ[] LMOONNDFEPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private BPGLFKPKJHF[] AMEFOJLMGID;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private IEnumerator<KENFJGFMIPM>[] JELOAPNCLNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private KENFJGFMIPM[] LDGCCHBDADH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private int IMLAJMIFNPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private int NPKCAEOBEMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private readonly int AEIDKODLGJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private float PPDFBDENFBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private LCKMBKBNBGC OIHBJFCDCOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private JobHandle LMMAIKCFIFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private List<BMOEEDOECDC> DNBEKFHBBOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private bool HABDMPHMEHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private List<Action> KCFLKGHJGIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private List<Action> GAKKPKFANJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private bool AFDHMMIPEIP;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public GIDICDINLFI[] OAPPOHBJCJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000166")]
				[Cpp2IlInjected.Address(RVA = "0x58ADA0", Offset = "0x58A1A0", VA = "0x18058ADA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public int JJEKKMDIBGI
			{
				[Cpp2IlInjected.Token(Token = "0x6000167")]
				[Cpp2IlInjected.Address(RVA = "0x65E900", Offset = "0x65DD00", VA = "0x18065E900")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3419810", Offset = "0x3418C10", VA = "0x183419810")]
			private static int PGPLCLADMOP(NEIJEKIKDOG CKFELIAJKCP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3419840", Offset = "0x3418C40", VA = "0x183419840")]
			public IALKDLLHDII(NEIJEKIKDOG CKFELIAJKCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3419200", Offset = "0x3418600", VA = "0x183419200")]
			private void MLAFOKLGIMD(ref int GMJLJINPLLP, int DGKFKECDFGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3419630", Offset = "0x3418A30", VA = "0x183419630")]
			public void NPNEHCHIMCM(BPGLFKPKJHF LHOMKMINCHH, KENFJGFMIPM BPGGCEOBFBK, IEnumerator<KENFJGFMIPM> LOIIKGFHHAA, OMNCINDCAAJ NKLGAGCHGPM, [Optional] BMOEEDOECDC NEPMGGPMFOH, KINIDGHKMLM IJBJBPDEKKL = KINIDGHKMLM.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x3418530", Offset = "0x3417930", VA = "0x183418530")]
			public void FLJBJJLIFHM(IEnumerable<CFBMJLPBODF> DMDLKMFKKCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x34187A0", Offset = "0x3417BA0", VA = "0x1834187A0")]
			private CFBMJLPBODF JAAGBELBKHG(int JGECCDNFAID)
			{
				return default(CFBMJLPBODF);
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3418200", Offset = "0x3417600", VA = "0x183418200")]
			private void FKNNONKOPDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x15700D0", Offset = "0x156F4D0", VA = "0x1815700D0")]
			private static void NBHOFBPCJGK<T>(int JGECCDNFAID, T[] IMMIMNIHIEF, int OJJOHDIFMEG, [Optional] T ADHBGHBGDNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x15700B0", Offset = "0x156F4B0", VA = "0x1815700B0")]
			private static void NBHOFBPCJGK<T>(int JGECCDNFAID, NativeArray<T> IMMIMNIHIEF, int OJJOHDIFMEG, [Optional] T ADHBGHBGDNC) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x3417EE0", Offset = "0x34172E0", VA = "0x183417EE0")]
			private void DIOBAOCAAEI(IEnumerable<CFBMJLPBODF> DMDLKMFKKCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x3417B80", Offset = "0x3416F80", VA = "0x183417B80")]
			private void BANFNKBEACN(CFBMJLPBODF IHJKAJBJMJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3419390", Offset = "0x3418790", VA = "0x183419390")]
			private FLILCHFLFHI NDHIAFIAEDC(int AHKGGOPCBNK)
			{
				return default(FLILCHFLFHI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x3417CF0", Offset = "0x34170F0", VA = "0x183417CF0")]
			public void CMBODEFCFGB(float KGOBMDNKIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x3418720", Offset = "0x3417B20", VA = "0x183418720")]
			private void GBONAELFCHI(Action IPHIIJNAEON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3418180", Offset = "0x3417580", VA = "0x183418180")]
			private void EAOBOPNPOJE(Action IPHIIJNAEON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x3418BD0", Offset = "0x3417FD0", VA = "0x183418BD0")]
			public void JGHOHJNCKDH(float KGOBMDNKIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x3419120", Offset = "0x3418520", VA = "0x183419120")]
			public void MDDAPCCABNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x3419070", Offset = "0x3418470", VA = "0x183419070")]
			public void KBPKIDJEOFB(BMOEEDOECDC KECNNGMBHAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3419760", Offset = "0x3418B60", VA = "0x183419760")]
			public void OEJCNOAPCAB(BMOEEDOECDC KECNNGMBHAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3417C40", Offset = "0x3417040", VA = "0x183417C40")]
			public void CIFEAJMAHKI(BMOEEDOECDC KECNNGMBHAK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[BurstCompile]
		public struct LCKMBKBNBGC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			[ReadOnly]
			public float MKLCOIBIHEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			[ReadOnly]
			public int KGOGPFCJPPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private NativeArray<int> ELFLBECKFEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private NativeArray<int> AKANBKMACGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private NativeArray<int> JBONOFAJNCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			[ReadOnly]
			public NativeArray<KINIDGHKMLM> GJHKCAEJCKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			[ReadOnly]
			public NativeArray<float> EDDPIGKJOHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			[WriteOnly]
			public NativeArray<int> GDENALHIFED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			[WriteOnly]
			public NativeArray<int> DIPODGDEDFB;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x341C810", Offset = "0x341BC10", VA = "0x18341C810")]
			public static LCKMBKBNBGC NFHADFCEMML(int GONGHDLCGPO, float KGOBMDNKIDJ, NativeArray<KINIDGHKMLM> FKIFNJGLFDF, NativeArray<float> ADCCOCDJMNM, NativeArray<int> EIHKHJBKKPC, NativeArray<int> HEDEJBEKJPH, NativeArray<int> HFOAFEDLEJG, NativeArray<int> AKANBKMACGE, NativeArray<int> JBONOFAJNCL)
			{
				return default(LCKMBKBNBGC);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x341C3F0", Offset = "0x341B7F0", VA = "0x18341C3F0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x341C5A0", Offset = "0x341B9A0", VA = "0x18341C5A0")]
			private bool KHFEFLOCLII(int EFBDCIJMFGD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x341C3C0", Offset = "0x341B7C0", VA = "0x18341C3C0")]
			private void CDLEKIKHHCD(NativeArray<int> FJLGONNPKCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x341C8E0", Offset = "0x341BCE0", VA = "0x18341C8E0")]
			private int OEIAGHKPDBB(int ILJJFCIEOOJ, int MMJPCDPKKJE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x341C4D0", Offset = "0x341B8D0", VA = "0x18341C4D0")]
			private void JIHBNKEBJDH(NativeArray<int> FJLGONNPKCB, int DLECGJMGFNI, int PBAOMKNFBFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x341C5E0", Offset = "0x341B9E0", VA = "0x18341C5E0")]
			private void MNMAEDHAEFJ(NativeArray<int> FJLGONNPKCB, int JNOJAJGDFLF, int AKCJAFLPOKA, int IMMAKAPBGIK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class GMHCEMDMGBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly OMNCINDCAAJ NKLGAGCHGPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly Behaviour LHOMKMINCHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly bool LPCBEEBALNO;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public IEnumerator<KENFJGFMIPM> HCIEHECEDAK
			{
				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0x4457A0", Offset = "0x444BA0", VA = "0x1804457A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018B")]
				[Cpp2IlInjected.Address(RVA = "0x445790", Offset = "0x444B90", VA = "0x180445790")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public KENFJGFMIPM JIGIMNNJHGD
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0x444C90", Offset = "0x444090", VA = "0x180444C90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool OBADDMFNOMJ
			{
				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0x34153B0", Offset = "0x34147B0", VA = "0x1834153B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool JDKJCDNCDAN
			{
				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0x5CFA90", Offset = "0x5CEE90", VA = "0x1805CFA90")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0xA38660", Offset = "0xA37A60", VA = "0x180A38660")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public string FIKEBGGCDFN
			{
				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0x41A490", Offset = "0x419890", VA = "0x18041A490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x4461C0", Offset = "0x4455C0", VA = "0x1804461C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public float LKOAKFDABJP
			{
				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x62EFE0", Offset = "0x62E3E0", VA = "0x18062EFE0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x6841A0", Offset = "0x6835A0", VA = "0x1806841A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3415800", Offset = "0x3414C00", VA = "0x183415800")]
			public GMHCEMDMGBA(IEnumerator<KENFJGFMIPM> LOIIKGFHHAA, Behaviour LHOMKMINCHH, OMNCINDCAAJ NKLGAGCHGPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x3415560", Offset = "0x3414960", VA = "0x183415560")]
			public KENFJGFMIPM NEPONCICACF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x3415440", Offset = "0x3414840", VA = "0x183415440")]
			public bool GBOOCLEMCKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x34154D0", Offset = "0x34148D0", VA = "0x1834154D0")]
			public void KBPKIDJEOFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x3415770", Offset = "0x3414B70", VA = "0x183415770", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A40", Offset = "0x99FE40", VA = "0x1809A0A40")]
			[CompilerGenerated]
			private void NNFOONHOMIF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private sealed class OMNCINDCAAJ : HHKIEEPFDOH, KFBABPAPIMB, CDJFFFCFLMF, DABKFAIHBBP, IEnumerator, KENFJGFMIPM, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private NEIJEKIKDOG FIDOMBIKHPP;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			private NEIJEKIKDOG IIPMBGHMKNO
			{
				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x40CC30", Offset = "0x40C030", VA = "0x18040CC30", Slot = "23")]
				get
				{
					return default(NEIJEKIKDOG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public NEIJEKIKDOG ALLFDCFPHGM
			{
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x40CC30", Offset = "0x40C030", VA = "0x18040CC30")]
				get
				{
					return default(NEIJEKIKDOG);
				}
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x4641B0", Offset = "0x4635B0", VA = "0x1804641B0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			private float IIEAAEDICEG
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x6C8320", Offset = "0x6C7720", VA = "0x1806C8320", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x341F3E0", Offset = "0x341E7E0", VA = "0x18341F3E0", Slot = "24")]
			private bool EEOJLONCPBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x341F3D0", Offset = "0x341E7D0", VA = "0x18341F3D0", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x341F400", Offset = "0x341E800", VA = "0x18341F400")]
			public OMNCINDCAAJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private enum FLILCHFLFHI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private sealed class GOPOCOOMEIM : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200004C")]
			public enum MJKJJAEINKK
			{
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			public struct OFOGOHPAFPJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public NEIJEKIKDOG JDIEDFKCIGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				public MJKJJAEINKK BAPFEDOOIFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public List<GMHCEMDMGBA> OECIFDDKEAP;
			}

			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private static readonly MJKJJAEINKK[] GLLEJMPCGJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private readonly NEIJEKIKDOG CKFELIAJKCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private bool JLDJMFNCDPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private readonly GMHCEMDMGBA[] GGEMDOAPACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private readonly List<GMHCEMDMGBA> PJKLFGMDJLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private readonly Stack<int> KIMBMABLPNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly List<GMHCEMDMGBA> EADBGNKMBEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly Stack<int> BCKLDDFGIID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private bool AFDHMMIPEIP;

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public OFOGOHPAFPJ[,] KENMKBOBOCM
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x4155E0", Offset = "0x4149E0", VA = "0x1804155E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public int JJEKKMDIBGI
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x3416510", Offset = "0x3415910", VA = "0x183416510")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x3416DD0", Offset = "0x34161D0", VA = "0x183416DD0")]
			public GOPOCOOMEIM(NEIJEKIKDOG MJHMBNIDGCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3416B20", Offset = "0x3415F20", VA = "0x183416B20")]
			public void OFMOGILADOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3416500", Offset = "0x3415900", VA = "0x183416500")]
			public void HCJANGOBPPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3416BE0", Offset = "0x3415FE0", VA = "0x183416BE0")]
			private void PFMMBGGICPG(IReadOnlyList<GMHCEMDMGBA> CNNICEPGNGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3416A20", Offset = "0x3415E20", VA = "0x183416A20")]
			public void ODPKGCAACLJ(GMHCEMDMGBA LOIIKGFHHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x3416680", Offset = "0x3415A80", VA = "0x183416680")]
			public void NJJBDIOAJKH(IList<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3416280", Offset = "0x3415680", VA = "0x183416280")]
			public void GMBMMGDJFKG(IList<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3416010", Offset = "0x3415410", VA = "0x183416010")]
			private void EPACAPMNOOB(GMHCEMDMGBA LOIIKGFHHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3415B80", Offset = "0x3414F80", VA = "0x183415B80")]
			private void BBDFMCDKAKM(IList<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3416100", Offset = "0x3415500", VA = "0x183416100")]
			private FLILCHFLFHI FODCOGKACKB(GMHCEMDMGBA LOIIKGFHHAA)
			{
				return default(FLILCHFLFHI);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x3416B30", Offset = "0x3415F30", VA = "0x183416B30")]
			public void OPEMIFENIJM(float KGOBMDNKIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x3415980", Offset = "0x3414D80", VA = "0x183415980")]
			public void AAACLIOCAPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3415E30", Offset = "0x3415230", VA = "0x183415E30")]
			private void EMNPEAHLJHM(List<GMHCEMDMGBA> JNMOEFOGKLE, Stack<int> HEEKJOEHAOC, bool FIOKCLNDGIF, float KENDNPDMLOG = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3415CF0", Offset = "0x34150F0", VA = "0x183415CF0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x3416900", Offset = "0x3415D00", VA = "0x183416900")]
			private void OAGLBBEDKAL(List<GMHCEMDMGBA> JNMOEFOGKLE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[NJICLEHHOBN]
		public enum NEIJEKIKDOG
		{
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			PostUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			RigidbodyExLateUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			PreRender,
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			EndOfFrame
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[Flags]
		public enum KINIDGHKMLM : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			Inactive = 0,
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			Running = 1,
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			Cancelled = 2,
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			Paused = 4
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class FKPOAPKAOPL : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x3F8210", Offset = "0x3F7610", VA = "0x1803F8210")]
			[DebuggerHidden]
			public FKPOAPKAOPL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x3F8200", Offset = "0x3F7600", VA = "0x1803F8200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x34147E0", Offset = "0x3413BE0", VA = "0x1834147E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x3414860", Offset = "0x3413C60", VA = "0x183414860", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private const KINIDGHKMLM BNMLAFJDKKO = KINIDGHKMLM.Cancelled | KINIDGHKMLM.Paused;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private static readonly NEIJEKIKDOG[] JFNODFEODBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private GOPOCOOMEIM[] EFAKFPBPKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private IALKDLLHDII[] CMLNDHMENGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private Coroutine JFLDNFIOIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private WaitForEndOfFrame DIJAOOECJCE;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public FNPGPAPOHAN MACMLJJGBIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x444C90", Offset = "0x444090", VA = "0x180444C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public NEIJEKIKDOG BIALLDOGHIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x446040", Offset = "0x445440", VA = "0x180446040")]
			[CompilerGenerated]
			get
			{
				return default(NEIJEKIKDOG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x446210", Offset = "0x445610", VA = "0x180446210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int JJEKKMDIBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x3421250", Offset = "0x3420650", VA = "0x183421250")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3420150", Offset = "0x341F550", VA = "0x183420150")]
		public static KFBABPAPIMB GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x341F9D0", Offset = "0x341EDD0", VA = "0x18341F9D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3420330", Offset = "0x341F730", VA = "0x183420330", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x21209B0", Offset = "0x211FDB0", VA = "0x1821209B0")]
		private GOPOCOOMEIM BMEHNIHAJHK(NEIJEKIKDOG GEDCEIDOKJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x34200F0", Offset = "0x341F4F0", VA = "0x1834200F0")]
		private IALKDLLHDII FLPNLDJDNNM(NEIJEKIKDOG GEDCEIDOKJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x34207C0", Offset = "0x341FBC0", VA = "0x1834207C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3420790", Offset = "0x341FB90", VA = "0x183420790")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3421050", Offset = "0x3420450", VA = "0x183421050")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3420320", Offset = "0x341F720", VA = "0x183420320")]
		private void NGHDMBGBMLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x34200E0", Offset = "0x341F4E0", VA = "0x1834200E0")]
		private void EBCGNHAEELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3420130", Offset = "0x341F530", VA = "0x183420130")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x34201F0", Offset = "0x341F5F0", VA = "0x1834201F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3420140", Offset = "0x341F540", VA = "0x183420140")]
		private void GJJOOOJIAAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x341FE60", Offset = "0x341F260", VA = "0x18341FE60")]
		[IteratorStateMachine(typeof(FKPOAPKAOPL))]
		private IEnumerator CHAAKFJCLIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3420960", Offset = "0x341FD60", VA = "0x183420960")]
		public KFBABPAPIMB Run(IEnumerator<KENFJGFMIPM> GAHCJOMJGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3420970", Offset = "0x341FD70", VA = "0x183420970")]
		public KFBABPAPIMB Run(Behaviour LHOMKMINCHH, IEnumerator<KENFJGFMIPM> GAHCJOMJGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3420830", Offset = "0x341FC30", VA = "0x183420830")]
		public KFBABPAPIMB RunJobbed(BPGLFKPKJHF LHOMKMINCHH, IEnumerator<KENFJGFMIPM> GAHCJOMJGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3420080", Offset = "0x341F480", VA = "0x183420080")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3420C90", Offset = "0x3420090", VA = "0x183420C90")]
		public void UpdateQueue(NEIJEKIKDOG DKGFKIKFBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x341FEC0", Offset = "0x341F2C0", VA = "0x18341FEC0")]
		private void CLODBMLECIA(GOPOCOOMEIM KAMCDGAHIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3420200", Offset = "0x341F600", VA = "0x183420200")]
		private void MNKNBBMICOI(IALKDLLHDII KAMCDGAHIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x34211D0", Offset = "0x34205D0", VA = "0x1834211D0")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface FNPGPAPOHAN
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	float EDNCMGJJLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	float FFPPABMIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	float PIBBOFCHMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	int JHNNFDHLJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	double NCBJKCHIKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class CNCOALCNHBC : FNPGPAPOHAN
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float EDNCMGJJLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3410EE0", Offset = "0x34102E0", VA = "0x183410EE0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float FFPPABMIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3410ED0", Offset = "0x34102D0", VA = "0x183410ED0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public float PIBBOFCHMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3410EF0", Offset = "0x34102F0", VA = "0x183410EF0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int JHNNFDHLJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3410EC0", Offset = "0x34102C0", VA = "0x183410EC0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public double NCBJKCHIKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3410EA0", Offset = "0x34102A0", VA = "0x183410EA0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
	public CNCOALCNHBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class FIFNHIILPEL : HAPBACHHIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public int BIOFILJOKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Queue<double> PHEJDGHGEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private double FFOJBDNKMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private double PMCAKBEJBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double OFDBBHKOJKI;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int LINEHPICCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3414710", Offset = "0x3413B10", VA = "0x183414710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public double OOPCGBFJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3414640", Offset = "0x3413A40", VA = "0x183414640", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public double GMBEJJBNGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x13964E0", Offset = "0x13958E0", VA = "0x1813964E0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public double JIODMOCKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x28D9540", Offset = "0x28D8940", VA = "0x1828D9540", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3414750", Offset = "0x3413B50", VA = "0x183414750")]
	public FIFNHIILPEL(int EPHMNMCMOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3414540", Offset = "0x3413940", VA = "0x183414540", Slot = "4")]
	public void EHGIOHLBHJN(double MBJCIBHEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x34146A0", Offset = "0x3413AA0", VA = "0x1834146A0", Slot = "5")]
	public void JBBLIBHHEBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class ABHKLOENLLE : HAPBACHHIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private long MNIJHBJDPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private double ILPMEPPIJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private double OMGFKNCEEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private double BHEKBIIIJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private double BEJJCLLNDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private double FFOJBDNKMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private double PMCAKBEJBFN;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long MEPGPGKFENE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4457A0", Offset = "0x444BA0", VA = "0x1804457A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public double GMBEJJBNGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x200A910", Offset = "0x2009D10", VA = "0x18200A910", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public double JIODMOCKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x28D95B0", Offset = "0x28D89B0", VA = "0x1828D95B0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public double GGEADKGMGDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x28D9540", Offset = "0x28D8940", VA = "0x1828D9540")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public double JDPBPFKMGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3047400", Offset = "0x3046800", VA = "0x183047400")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public double OOPCGBFJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x28D9470", Offset = "0x28D8870", VA = "0x1828D9470", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x340F510", Offset = "0x340E910", VA = "0x18340F510", Slot = "4")]
	public void EHGIOHLBHJN(double MBJCIBHEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x340F630", Offset = "0x340EA30", VA = "0x18340F630", Slot = "5")]
	public void JBBLIBHHEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x340F670", Offset = "0x340EA70", VA = "0x18340F670")]
	public ABHKLOENLLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface HAPBACHHIBN
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	double OOPCGBFJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	double GMBEJJBNGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	double JIODMOCKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHGIOHLBHJN(double MBJCIBHEOMM);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBBLIBHHEBC();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class LJLGDKLOFMO
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private interface OJCONDGBEIA
	{
		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		bool MMICKFMMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OOOIENHGNCA();

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KBPKIDJEOFB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class JDIOECLPOPK<TPromise, TMainThreadPromise> : OJCONDGBEIA where TPromise : DABKFAIHBBP where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly TPromise GMLHFPFHBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		protected readonly TMainThreadPromise IDAPKKELNMM;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public TPromise DENADOGFMKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2286E60", Offset = "0x2286260", VA = "0x182286E60")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool MMICKFMMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2286E10", Offset = "0x2286210", VA = "0x182286E10", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x15C52D0", Offset = "0x15C46D0", VA = "0x1815C52D0")]
		protected JDIOECLPOPK(TPromise GMLHFPFHBJD, TMainThreadPromise BLFADPCOALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2286EC0", Offset = "0x22862C0", VA = "0x182286EC0", Slot = "5")]
		public void OOOIENHGNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x15EC020", Offset = "0x15EB420", VA = "0x1815EC020", Slot = "6")]
		public void KBPKIDJEOFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void AMPLEOCGJBM(TPromise GMLHFPFHBJD);

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void GHCAGDCCIPD();
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class BCAIFPDOAMM<T> : JDIOECLPOPK<global::PMGCJEPKFOF<T>, global::CBLLFJEDOII<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x2284620", Offset = "0x2283A20", VA = "0x182284620")]
		public BCAIFPDOAMM(global::PMGCJEPKFOF<T> GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2284200", Offset = "0x2283600", VA = "0x182284200", Slot = "7")]
		protected override void AMPLEOCGJBM(global::PMGCJEPKFOF<T> GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2284580", Offset = "0x2283980", VA = "0x182284580", Slot = "8")]
		protected override void GHCAGDCCIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x22845E0", Offset = "0x22839E0", VA = "0x1822845E0")]
		[CompilerGenerated]
		private void NIJANLDDIMP(T GIAOBLMEMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x22844F0", Offset = "0x22838F0", VA = "0x1822844F0")]
		[CompilerGenerated]
		private void FGCPLDIEGKO(string MOPOMPHBHKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class EHEDHJDLBCH : JDIOECLPOPK<DABKFAIHBBP, JJEKJGALHKO>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3413250", Offset = "0x3412650", VA = "0x183413250")]
		public EHEDHJDLBCH(DABKFAIHBBP GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3413130", Offset = "0x3412530", VA = "0x183413130", Slot = "7")]
		protected override void AMPLEOCGJBM(DABKFAIHBBP GMLHFPFHBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3413200", Offset = "0x3412600", VA = "0x183413200", Slot = "8")]
		protected override void GHCAGDCCIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x823860", Offset = "0x822C60", VA = "0x180823860")]
		[CompilerGenerated]
		private void NIJANLDDIMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x632800", Offset = "0x631C00", VA = "0x180632800")]
		[CompilerGenerated]
		private void FGCPLDIEGKO(string MOPOMPHBHKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private class HLPAFHONKPA : OJCONDGBEIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly Action JJGHIEJCCDA;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool MMICKFMMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x40F420", Offset = "0x40E820", VA = "0x18040F420", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5A4AD0", Offset = "0x5A3ED0", VA = "0x1805A4AD0")]
		public HLPAFHONKPA(Action JJGHIEJCCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xE8C6B0", Offset = "0xE8BAB0", VA = "0x180E8C6B0", Slot = "5")]
		public void OOOIENHGNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3F8200", Offset = "0x3F7600", VA = "0x1803F8200", Slot = "6")]
		public void KBPKIDJEOFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly List<OJCONDGBEIA> GEONEIIGPNH;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x1A4EA00", Offset = "0x1A4DE00", VA = "0x181A4EA00")]
	public static global::PMGCJEPKFOF<T> DNMKIEAJOJH<T>(this global::PMGCJEPKFOF<T> GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x341D310", Offset = "0x341C710", VA = "0x18341D310")]
	public static DABKFAIHBBP DNMKIEAJOJH(this DABKFAIHBBP GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x341D290", Offset = "0x341C690", VA = "0x18341D290")]
	public static void DNMKIEAJOJH(Action JJGHIEJCCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1A4EAE0", Offset = "0x1A4DEE0", VA = "0x181A4EAE0")]
	private static global::PMGCJEPKFOF<T> LINADCCOBCC<T>(global::PMGCJEPKFOF<T> GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x341D780", Offset = "0x341CB80", VA = "0x18341D780")]
	private static DABKFAIHBBP LINADCCOBCC(DABKFAIHBBP GMLHFPFHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x341D5A0", Offset = "0x341C9A0", VA = "0x18341D5A0")]
	private static void IIGMDIHDNJD(OJCONDGBEIA BKCGDDGIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x341CF70", Offset = "0x341C370", VA = "0x18341CF70")]
	private static void COAPLNGMFKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x341D420", Offset = "0x341C820", VA = "0x18341D420")]
	private static void EHDOBJFCNEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x341D4F0", Offset = "0x341C8F0", VA = "0x18341D4F0")]
	private static void HLHALAIDKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class OEGOFBEELGL
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class LHAKBAAEPCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public JJEKJGALHKO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
		public LHAKBAAEPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x341CD90", Offset = "0x341C190", VA = "0x18341CD90")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x341CD80", Offset = "0x341C180", VA = "0x18341CD80")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class GAILAHGLKML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
		public GAILAHGLKML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x34149B0", Offset = "0x3413DB0", VA = "0x1834149B0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class HGHALIPAJMI : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JJEKJGALHKO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3F8210", Offset = "0x3F7610", VA = "0x1803F8210")]
		[DebuggerHidden]
		public HGHALIPAJMI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x34174C0", Offset = "0x34168C0", VA = "0x1834174C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x34171B0", Offset = "0x34165B0", VA = "0x1834171B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3417570", Offset = "0x3416970", VA = "0x183417570")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3417470", Offset = "0x3416870", VA = "0x183417470", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class MDIANADNKIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public JJEKJGALHKO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
		public MDIANADNKIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class GBMMKEHDBLM : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private KENFJGFMIPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public JJEKJGALHKO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private MDIANADNKIJ <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x3F81A0", Offset = "0x3F75A0", VA = "0x1803F81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3F8210", Offset = "0x3F7610", VA = "0x1803F8210")]
		[DebuggerHidden]
		public GBMMKEHDBLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3F8200", Offset = "0x3F7600", VA = "0x1803F8200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x34149E0", Offset = "0x3413DE0", VA = "0x1834149E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3414C20", Offset = "0x3414020", VA = "0x183414C20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public const string LLDNCJNLPGL = "empty";

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public const string BMCBAGEGBLI = "moderator";

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public const string AFKGHCNJPBB = "main_root";

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public const string PGIAKFDKOEH = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public const string OPEMHLDGDEA = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private const float IIHEIALMGIP = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static DABKFAIHBBP HPLJCGDFOOG;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static AsyncOperation NIELPFKCFMF;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static DABKFAIHBBP KBKDKPGIECD;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static string DBKMPGMOIKP;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static ThreadPriority PPCENOLHKDB;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public static bool CCEJLKMLKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x341E2F0", Offset = "0x341D6F0", VA = "0x18341E2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private static bool KLFONPCEKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x341E5A0", Offset = "0x341D9A0", VA = "0x18341E5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private static bool JMIHDNFOODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x341E600", Offset = "0x341DA00", VA = "0x18341E600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x341E140", Offset = "0x341D540", VA = "0x18341E140")]
	public static DABKFAIHBBP BBOHJKKLCKO(string PCBCJKHMBGL, LoadSceneMode GNOCFLPOFIB = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x341E390", Offset = "0x341D790", VA = "0x18341E390")]
	public static DABKFAIHBBP DGIJOCFANHH(string PCBCJKHMBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x341E280", Offset = "0x341D680", VA = "0x18341E280")]
	[IteratorStateMachine(typeof(HGHALIPAJMI))]
	private static IEnumerator<KENFJGFMIPM> CKBLIMMFGLM(string PCBCJKHMBGL, JJEKJGALHKO OCHKEPDILKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x341E0C0", Offset = "0x341D4C0", VA = "0x18341E0C0")]
	[IteratorStateMachine(typeof(GBMMKEHDBLM))]
	private static IEnumerator<KENFJGFMIPM> AJDIEMKKFGG(string PCBCJKHMBGL, LoadSceneMode GNOCFLPOFIB, JJEKJGALHKO OCHKEPDILKF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class FFAFDAOBAHN
{
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static byte[] OHCLMBBDJLC;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static int NJPHPOMKGAO;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static int NCHLFMFMLBC;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static BigInteger AEEDJIDCNEO;

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3413CF0", Offset = "0x34130F0", VA = "0x183413CF0")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3413DF0", Offset = "0x34131F0", VA = "0x183413DF0")]
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

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3F8050", Offset = "0x3F7450", VA = "0x1803F8050")]
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private delegate List<PlayerLoopSystem> KEJIOGKILIJ(List<PlayerLoopSystem> GGFHHBAKBPN, int HLDPDDIKKPN);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct KJMAPOOGBGH
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct IHCGMHCODAM
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static CEOJNOHEPFJ NIFLFBHEJCJ;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x40C7190", Offset = "0x40C6590", VA = "0x1840C7190")]
				public static PlayerLoopSystem MENKAMOFGGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct FAALBFDLMNH
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static CEOJNOHEPFJ OHGOECGMCCP;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x40C2D90", Offset = "0x40C2190", VA = "0x1840C2D90")]
				public static PlayerLoopSystem MENKAMOFGGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct MGIGGDOPPDL
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static CEOJNOHEPFJ EOONADAPGDL;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x40CA4D0", Offset = "0x40C98D0", VA = "0x1840CA4D0")]
				public static PlayerLoopSystem MENKAMOFGGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			internal struct OBPCDDGNHFI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				[CompilerGenerated]
				private sealed class MCLNABCNACI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000C")]
					public DFBOHONBODA.PBPEANBHHBJ key;

					[Cpp2IlInjected.Token(Token = "0x600001B")]
					[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
					public MCLNABCNACI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600001C")]
					[Cpp2IlInjected.Address(RVA = "0x40CA320", Offset = "0x40C9720", VA = "0x1840CA320")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDisposable BMOELOHFJPE;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x40CAB40", Offset = "0x40C9F40", VA = "0x1840CAB40")]
				public static PlayerLoopSystem HCIAJIPINDJ(DFBOHONBODA.PBPEANBHHBJ NDLDFCGGHEC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct CGKEHKOHBKI
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class EGODBNIHLLD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000D")]
					public DFBOHONBODA.PBPEANBHHBJ key;

					[Cpp2IlInjected.Token(Token = "0x600001E")]
					[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
					public EGODBNIHLLD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600001F")]
					[Cpp2IlInjected.Address(RVA = "0x40C1F00", Offset = "0x40C1300", VA = "0x1840C1F00")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x40BF3F0", Offset = "0x40BE7F0", VA = "0x1840BF3F0")]
				public static PlayerLoopSystem HCIAJIPINDJ(DFBOHONBODA.PBPEANBHHBJ NDLDFCGGHEC)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class MHNCFCMIIEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
			public MHNCFCMIIEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x40CA670", Offset = "0x40C9A70", VA = "0x1840CA670")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool APCJDILMGLK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool HPJGNAEPAKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x40C1990", Offset = "0x40C0D90", VA = "0x1840C1990")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x40C16F0", Offset = "0x40C0AF0", VA = "0x1840C16F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x40C0430", Offset = "0x40BF830", VA = "0x1840C0430")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x40C1730", Offset = "0x40C0B30", VA = "0x1840C1730")]
		private static void IBBCNLPHEEK(DFBOHONBODA.PBPEANBHHBJ NDLDFCGGHEC, ref PlayerLoopSystem LKIMBIMJLAC, Type HOAECAPCEFM, Type JJCBKBFHLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x40C1280", Offset = "0x40C0680", VA = "0x1840C1280")]
		private static void EDOOEINFCBA(ref PlayerLoopSystem LKIMBIMJLAC, Type HOAECAPCEFM, Type JJCBKBFHLGJ, KEJIOGKILIJ FOEKAFCBJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x40C15F0", Offset = "0x40C09F0", VA = "0x1840C15F0")]
		private static void FKACGNCLFAB(ref PlayerLoopSystem LKIMBIMJLAC, Type HOAECAPCEFM, Type JJCBKBFHLGJ, PlayerLoopSystem? KNOFBFNPIFJ, PlayerLoopSystem? ENDHFEECHFF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DFBOHONBODA
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum PBPEANBHHBJ
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

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class PNMFAEBMOOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly PBPEANBHHBJ CDDDDHHHBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly HCNIOBDPPNH OJGNOPGAALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long FGLKOJBKALO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long FHJCGFLLGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public long OMGEAECAFGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int EDHPGFBIIDP;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x40CBC70", Offset = "0x40CB070", VA = "0x1840CBC70")]
		public PNMFAEBMOOH(PBPEANBHHBJ JHHMHMFCCAI, int HBJAPCILIKD = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x40CBBF0", Offset = "0x40CAFF0", VA = "0x1840CBBF0")]
		public void GNGPDLAMBJB(int HPIMINLDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x40CBAE0", Offset = "0x40CAEE0", VA = "0x1840CBAE0")]
		public void BDLMNEKMKGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x40CBC10", Offset = "0x40CB010", VA = "0x1840CBC10")]
		public void IAMHDKNHCCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x40CB910", Offset = "0x40CAD10", VA = "0x1840CB910")]
		public void BCCGLAHOGOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x40CBB50", Offset = "0x40CAF50", VA = "0x1840CBB50")]
		public double BNNPGCNFMJM(int NFDAMCEOJIB)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int AHGBGGJPJIK = 90;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static PBPEANBHHBJ[] MCDPOGGBDOF;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static PNMFAEBMOOH[] MAGPOGHLOIK;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x40C1A60", Offset = "0x40C0E60", VA = "0x1840C1A60")]
	public static PNMFAEBMOOH APCJNDJPNKI(PBPEANBHHBJ NDLDFCGGHEC, int HBJAPCILIKD = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x40C1BF0", Offset = "0x40C0FF0", VA = "0x1840C1BF0")]
	public static PNMFAEBMOOH DJMEPKOEBIG(PBPEANBHHBJ NDLDFCGGHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x40C1C80", Offset = "0x40C1080", VA = "0x1840C1C80")]
	public static void MGPEFJBIKLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HCNIOBDPPNH : DBLGELCFMIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int DPIPKCDIHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Queue<double> FACKEEPMEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private double KKEBOOKEGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private double AJDNGFNOOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private double PIDPNIBFNBG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int AFOBGPIPPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x40C6060", Offset = "0x40C5460", VA = "0x1840C6060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double HPPAABBLENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x40C5F90", Offset = "0x40C5390", VA = "0x1840C5F90", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double HHMJPDOEMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xF843A0", Offset = "0xF837A0", VA = "0x180F843A0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double DOOBAFNGGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A340", Offset = "0x2E39740", VA = "0x182E3A340", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x40C61A0", Offset = "0x40C55A0", VA = "0x1840C61A0")]
	public HCNIOBDPPNH(int JILAJBBMBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x40C60A0", Offset = "0x40C54A0", VA = "0x1840C60A0", Slot = "4")]
	public void PKNENBMMFJH(double LFCLBPPOOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x40C5FF0", Offset = "0x40C53F0", VA = "0x1840C5FF0", Slot = "5")]
	public void FCDIMBHDFIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BMMCCIJCMGN : DBLGELCFMIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private long FAJAFOGAIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double MHABFDABKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double HJDNONKPBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double DGIIFBPLCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double LAHFMMJCLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double KKEBOOKEGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double AJDNGFNOOCC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long NMPIDIMNOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BF5A0", VA = "0x1804C01A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double HHMJPDOEMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x31CDAD0", Offset = "0x31CCED0", VA = "0x1831CDAD0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double DOOBAFNGGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84DC00", Offset = "0x84D000", VA = "0x18084DC00", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double IJIGGAIJKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A340", Offset = "0x2E39740", VA = "0x182E3A340")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double GNFLDFIAKCF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A330", Offset = "0x2E39730", VA = "0x182E3A330")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double HPPAABBLENI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x31CDA00", Offset = "0x31CCE00", VA = "0x1831CDA00", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x40BF1B0", Offset = "0x40BE5B0", VA = "0x1840BF1B0", Slot = "4")]
	public void PKNENBMMFJH(double LFCLBPPOOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x40BF170", Offset = "0x40BE570", VA = "0x1840BF170", Slot = "5")]
	public void FCDIMBHDFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x40BF2D0", Offset = "0x40BE6D0", VA = "0x1840BF2D0")]
	public BMMCCIJCMGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DBLGELCFMIK
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double HPPAABBLENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double HHMJPDOEMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double DOOBAFNGGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKNENBMMFJH(double LFCLBPPOOKO);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCDIMBHDFIE();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JMBCLPDIDAP
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private interface DEPIEMLCPED
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool DKKMDMBGIFN
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ALPMLALBLFA();

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DLLGEGLILFM();
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class OLBBACEOCOJ<TPromise, TMainThreadPromise> : DEPIEMLCPED where TPromise : IDJKGJMBBAG where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly TPromise LNFNGELHECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		protected readonly TMainThreadPromise HGFAMMLLLJD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise BEPAHFGEOIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x26F8590", Offset = "0x26F7990", VA = "0x1826F8590")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool DKKMDMBGIFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x26F85F0", Offset = "0x26F79F0", VA = "0x1826F85F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x26F8640", Offset = "0x26F7A40", VA = "0x1826F8640")]
		protected OLBBACEOCOJ(TPromise LNFNGELHECN, TMainThreadPromise KNKILBKDNJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x26F8560", Offset = "0x26F7960", VA = "0x1826F8560", Slot = "5")]
		public void ALPMLALBLFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2121220", Offset = "0x2120620", VA = "0x182121220", Slot = "6")]
		public void DLLGEGLILFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void LGGIPMJDBFN(TPromise LNFNGELHECN);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void FDKABOJPCBN();
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class GEDNCEBCECA<T> : OLBBACEOCOJ<global::PMGAAIBIJNM<T>, global::BNCFDPPLNOJ<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x26EC6B0", Offset = "0x26EBAB0", VA = "0x1826EC6B0")]
		public GEDNCEBCECA(global::PMGAAIBIJNM<T> LNFNGELHECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x26EC480", Offset = "0x26EB880", VA = "0x1826EC480", Slot = "7")]
		protected override void LGGIPMJDBFN(global::PMGAAIBIJNM<T> LNFNGELHECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x26EC420", Offset = "0x26EB820", VA = "0x1826EC420", Slot = "8")]
		protected override void FDKABOJPCBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x26EC3F0", Offset = "0x26EB7F0", VA = "0x1826EC3F0")]
		[CompilerGenerated]
		private void CKKHMCMFBDO(T HPFDPCFKNJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x26EC680", Offset = "0x26EBA80", VA = "0x1826EC680")]
		[CompilerGenerated]
		private void MJOPFEDGMLO(string EOFGEJBPEDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class LIDPAMAHFFG : OLBBACEOCOJ<IDJKGJMBBAG, HHHMAENMOAP>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x40CA2B0", Offset = "0x40C96B0", VA = "0x1840CA2B0")]
		public LIDPAMAHFFG(IDJKGJMBBAG LNFNGELHECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x40CA1E0", Offset = "0x40C95E0", VA = "0x1840CA1E0", Slot = "7")]
		protected override void LGGIPMJDBFN(IDJKGJMBBAG LNFNGELHECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x40CA190", Offset = "0x40C9590", VA = "0x1840CA190", Slot = "8")]
		protected override void FDKABOJPCBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x151F700", Offset = "0x151EB00", VA = "0x18151F700")]
		[CompilerGenerated]
		private void CKKHMCMFBDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1754230", Offset = "0x1753630", VA = "0x181754230")]
		[CompilerGenerated]
		private void MJOPFEDGMLO(string EOFGEJBPEDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class BGIGOAPEAFM : DEPIEMLCPED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Action LJDENNCKKFN;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DKKMDMBGIFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4C0F60", Offset = "0x4C0360", VA = "0x1804C0F60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x59C930", Offset = "0x59BD30", VA = "0x18059C930")]
		public BGIGOAPEAFM(Action LJDENNCKKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x142E200", Offset = "0x142D600", VA = "0x18142E200", Slot = "5")]
		public void ALPMLALBLFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "6")]
		public void DLLGEGLILFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly List<DEPIEMLCPED> AFNBDKBJBAC;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x22C4060", Offset = "0x22C3460", VA = "0x1822C4060")]
	public static global::PMGAAIBIJNM<T> INMFODEPNKO<T>(this global::PMGAAIBIJNM<T> LNFNGELHECN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x40C7A20", Offset = "0x40C6E20", VA = "0x1840C7A20")]
	public static IDJKGJMBBAG INMFODEPNKO(this IDJKGJMBBAG LNFNGELHECN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x40C79A0", Offset = "0x40C6DA0", VA = "0x1840C79A0")]
	public static void INMFODEPNKO(Action LJDENNCKKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x22C3FA0", Offset = "0x22C33A0", VA = "0x1822C3FA0")]
	private static global::PMGAAIBIJNM<T> ADHEINIGMHK<T>(global::PMGAAIBIJNM<T> LNFNGELHECN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x40C7560", Offset = "0x40C6960", VA = "0x1840C7560")]
	private static IDJKGJMBBAG ADHEINIGMHK(IDJKGJMBBAG LNFNGELHECN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x40C7640", Offset = "0x40C6A40", VA = "0x1840C7640")]
	private static void CINMDDGGJMI(DEPIEMLCPED CMPNCIFNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x40C7B30", Offset = "0x40C6F30", VA = "0x1840C7B30")]
	private static void PGKOHHKOGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x40C78D0", Offset = "0x40C6CD0", VA = "0x1840C78D0")]
	private static void HAIOLGHPDLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x40C7820", Offset = "0x40C6C20", VA = "0x1840C7820")]
	private static void GHOJFGMKPBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class HGEFDOIJFMK
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KBONOCCFONN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public HHHMAENMOAP onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
		public KBONOCCFONN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x40C7F00", Offset = "0x40C7300", VA = "0x1840C7F00")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x40C7EF0", Offset = "0x40C72F0", VA = "0x1840C7EF0")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class KOFFNGADDAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
		public KOFFNGADDAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x40C9420", Offset = "0x40C8820", VA = "0x1840C9420")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NDDPEDIGLAD : IEnumerator<LEPJMEIDDOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private LEPJMEIDDOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public HHHMAENMOAP onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private LEPJMEIDDOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
		[DebuggerHidden]
		public NDDPEDIGLAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x40CAA40", Offset = "0x40C9E40", VA = "0x1840CAA40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x40CA770", Offset = "0x40C9B70", VA = "0x1840CA770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x40CAAF0", Offset = "0x40C9EF0", VA = "0x1840CAAF0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x40CA9F0", Offset = "0x40C9DF0", VA = "0x1840CA9F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GMCAHAJFALE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public HHHMAENMOAP onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
		public GMCAHAJFALE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GLDJBJJCPDD : IEnumerator<LEPJMEIDDOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private LEPJMEIDDOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public HHHMAENMOAP onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private GMCAHAJFALE <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private LEPJMEIDDOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
		[DebuggerHidden]
		public GLDJBJJCPDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x40C5470", Offset = "0x40C4870", VA = "0x1840C5470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x40C57C0", Offset = "0x40C4BC0", VA = "0x1840C57C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const string NAIBJCCJFKD = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const string GNLKILDPCNG = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public const string FDMGFPCJNMN = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string JKLKFAOBMME = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string IPODIEAMCKN = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float PFIEPEGBIPI = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static IDJKGJMBBAG OLELGHEDOBO;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static AsyncOperation MNBCDFFGJAN;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static IDJKGJMBBAG FOCPAOANHOH;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static string MBGHNHJCEPI;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static ThreadPriority IDJCMOBJDKC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool ACOFLHLDFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x40C6230", Offset = "0x40C5630", VA = "0x1840C6230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool ECFNHBJLKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x40C6520", Offset = "0x40C5920", VA = "0x1840C6520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool MBDNBCAHJII
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x40C6410", Offset = "0x40C5810", VA = "0x1840C6410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> BJGNINPPAIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x40C6470", Offset = "0x40C5870", VA = "0x1840C6470")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x40C6600", Offset = "0x40C5A00", VA = "0x1840C6600")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x40C62D0", Offset = "0x40C56D0", VA = "0x1840C62D0")]
	public static IDJKGJMBBAG DNLPKOJKEBE(string JECHPODALPJ, LoadSceneMode GBGFOBIKEEH = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x40C66B0", Offset = "0x40C5AB0", VA = "0x1840C66B0")]
	public static IDJKGJMBBAG MPIDNDHNNMG(string JECHPODALPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x40C68C0", Offset = "0x40C5CC0", VA = "0x1840C68C0")]
	[IteratorStateMachine(typeof(NDDPEDIGLAD))]
	private static IEnumerator<LEPJMEIDDOC> PBDFONGDHID(string JECHPODALPJ, HHHMAENMOAP PKGLANFMJGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x40C6580", Offset = "0x40C5980", VA = "0x1840C6580")]
	[IteratorStateMachine(typeof(GLDJBJJCPDD))]
	private static IEnumerator<LEPJMEIDDOC> KHBFCMGHILE(string JECHPODALPJ, LoadSceneMode GBGFOBIKEEH, HHHMAENMOAP PKGLANFMJGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KCMHKNGFMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x40C87B0", Offset = "0x40C7BB0", VA = "0x1840C87B0")]
	public static IDisposable FOGFDGPNPJP(this AINBJHDGDII HKKAAOILAFH, Action BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x40C85F0", Offset = "0x40C79F0", VA = "0x1840C85F0")]
	public static IDisposable FOGFDGPNPJP(this AINBJHDGDII HKKAAOILAFH, Action<float> BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x40C8AB0", Offset = "0x40C7EB0", VA = "0x1840C8AB0")]
	public static IDisposable PGJDCLPGCDE(this AINBJHDGDII HKKAAOILAFH, Action BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x40C8B90", Offset = "0x40C7F90", VA = "0x1840C8B90")]
	public static IDisposable PLNKFGBMFLH(this AINBJHDGDII HKKAAOILAFH, Action BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x40C89B0", Offset = "0x40C7DB0", VA = "0x1840C89B0")]
	public static IDisposable NMPODDCJBCD(this AINBJHDGDII HKKAAOILAFH, Action BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x40C8B20", Offset = "0x40C7F20", VA = "0x1840C8B20")]
	public static IDisposable PIEMFOCJFAB(this AINBJHDGDII HKKAAOILAFH, Action BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x40C8580", Offset = "0x40C7980", VA = "0x1840C8580")]
	public static IDisposable EFJJIOAEKEE(this AINBJHDGDII HKKAAOILAFH, Action BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x40C84F0", Offset = "0x40C78F0", VA = "0x1840C84F0")]
	public static IDisposable EDCHGJHKELP(this AINBJHDGDII HKKAAOILAFH, float CJDCDDAKICB, Action<float> BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x40C82F0", Offset = "0x40C76F0", VA = "0x1840C82F0")]
	public static IDisposable CMJBLGOMNGO(this AINBJHDGDII HKKAAOILAFH, float CJDCDDAKICB, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x40C81F0", Offset = "0x40C75F0", VA = "0x1840C81F0")]
	public static IDisposable BBCIOGBIFEM(this AINBJHDGDII HKKAAOILAFH, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x40C8930", Offset = "0x40C7D30", VA = "0x1840C8930")]
	public static IDisposable NHMJPMACEFP(this AINBJHDGDII HKKAAOILAFH, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x40C8370", Offset = "0x40C7770", VA = "0x1840C8370")]
	public static IDisposable CNEHKMGPOCJ(this AINBJHDGDII HKKAAOILAFH, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x40C8A20", Offset = "0x40C7E20", VA = "0x1840C8A20")]
	public static IDisposable ONKNOADCPKE(this AINBJHDGDII HKKAAOILAFH, float CJDCDDAKICB, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x40C88B0", Offset = "0x40C7CB0", VA = "0x1840C88B0")]
	public static IDisposable MAJAKLAOIKJ(this AINBJHDGDII HKKAAOILAFH, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x40C8170", Offset = "0x40C7570", VA = "0x1840C8170")]
	public static IDisposable AMOOAGEBGAA(this AINBJHDGDII HKKAAOILAFH, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x40C8270", Offset = "0x40C7670", VA = "0x1840C8270")]
	public static IDisposable BJOBNGFBJFC(this AINBJHDGDII HKKAAOILAFH, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x40C80E0", Offset = "0x40C74E0", VA = "0x1840C80E0")]
	public static IDisposable AFKCJIGMAHK(this AINBJHDGDII HKKAAOILAFH, float CJDCDDAKICB, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x40C83F0", Offset = "0x40C77F0", VA = "0x1840C83F0")]
	public static IDisposable DHFILBEIJNF(this AINBJHDGDII HKKAAOILAFH, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x40C8470", Offset = "0x40C7870", VA = "0x1840C8470")]
	public static IDisposable DPJIJKBKNPM(this AINBJHDGDII HKKAAOILAFH, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x40C8830", Offset = "0x40C7C30", VA = "0x1840C8830")]
	public static IDisposable MAGHMLNHKLE(this AINBJHDGDII HKKAAOILAFH, Action<float> BFCCINGLGGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class ABNOEPKOFGD
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x40BC910", Offset = "0x40BBD10", VA = "0x1840BC910")]
	public static IDisposable HIAPGEIFCLG(this MonoBehaviour HDEHPBADHMN, Action BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x40BC750", Offset = "0x40BBB50", VA = "0x1840BC750")]
	public static IDisposable HIAPGEIFCLG(this MonoBehaviour HDEHPBADHMN, Action<float> BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x40BC310", Offset = "0x40BB710", VA = "0x1840BC310")]
	public static IDisposable CPCFLAIEIOH(this MonoBehaviour HDEHPBADHMN, Action BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x40BC380", Offset = "0x40BB780", VA = "0x1840BC380")]
	public static IDisposable DGBPEOJCOGC(this MonoBehaviour HDEHPBADHMN, Action BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x40BC470", Offset = "0x40BB870", VA = "0x1840BC470")]
	public static IDisposable EADHPMFPEIK(this MonoBehaviour HDEHPBADHMN, Action BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x40BCC30", Offset = "0x40BC030", VA = "0x1840BCC30")]
	public static IDisposable NFNOGOCFAFB(this MonoBehaviour HDEHPBADHMN, Action BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x40BC560", Offset = "0x40BB960", VA = "0x1840BC560")]
	public static IDisposable EHDDGDGLOKC(this MonoBehaviour HDEHPBADHMN, Action BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x40BC200", Offset = "0x40BB600", VA = "0x1840BC200")]
	public static IDisposable CKKMAFCIOFA(this MonoBehaviour HDEHPBADHMN, float CJDCDDAKICB, Action<float> BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x40BC4E0", Offset = "0x40BB8E0", VA = "0x1840BC4E0")]
	public static IDisposable EGKPAEGKOCG(this MonoBehaviour HDEHPBADHMN, float CJDCDDAKICB, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x40BC080", Offset = "0x40BB480", VA = "0x1840BC080")]
	public static IDisposable BIHIJAGCOCC(this MonoBehaviour HDEHPBADHMN, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x40BC650", Offset = "0x40BBA50", VA = "0x1840BC650")]
	public static IDisposable GGEFEMGAAKH(this MonoBehaviour HDEHPBADHMN, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x40BC290", Offset = "0x40BB690", VA = "0x1840BC290")]
	public static IDisposable COGIABBCPDI(this MonoBehaviour HDEHPBADHMN, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x40BCAA0", Offset = "0x40BBEA0", VA = "0x1840BCAA0")]
	public static IDisposable KHJJLABBPCN(this MonoBehaviour HDEHPBADHMN, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x40BCA20", Offset = "0x40BBE20", VA = "0x1840BCA20")]
	public static IDisposable ILIFNENCFMI(this MonoBehaviour HDEHPBADHMN, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x40BC100", Offset = "0x40BB500", VA = "0x1840BC100")]
	public static IDisposable BLPKDDBDBCO(this MonoBehaviour HDEHPBADHMN, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x40BCB20", Offset = "0x40BBF20", VA = "0x1840BCB20")]
	public static IDisposable MIFNNGJCOHO(this MonoBehaviour HDEHPBADHMN, float CJDCDDAKICB, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x40BC6D0", Offset = "0x40BBAD0", VA = "0x1840BC6D0")]
	public static IDisposable HCNEBAOOLHA(this MonoBehaviour HDEHPBADHMN, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x40BC180", Offset = "0x40BB580", VA = "0x1840BC180")]
	public static IDisposable CAABKJPFPEA(this MonoBehaviour HDEHPBADHMN, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x40BC3F0", Offset = "0x40BB7F0", VA = "0x1840BC3F0")]
	public static IDisposable DGJJMDGDGGE(this MonoBehaviour HDEHPBADHMN, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x40BC990", Offset = "0x40BBD90", VA = "0x1840BC990")]
	public static IDisposable IFLJJDNAFIC(this MonoBehaviour HDEHPBADHMN, float CJDCDDAKICB, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x40BCCA0", Offset = "0x40BC0A0", VA = "0x1840BCCA0")]
	public static IDisposable OPPKIHPNIOO(this MonoBehaviour HDEHPBADHMN, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x40BC5D0", Offset = "0x40BB9D0", VA = "0x1840BC5D0")]
	public static IDisposable FHOBNCBGKIC(this MonoBehaviour HDEHPBADHMN, Action<float> BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x40BCBB0", Offset = "0x40BBFB0", VA = "0x1840BCBB0")]
	public static IDisposable NBCFPDBIICI(this MonoBehaviour HDEHPBADHMN, Action<float> BFCCINGLGGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class PHGEACMEFAP
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class GKBOPFGAMJA : IEnumerator<LEPJMEIDDOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private LEPJMEIDDOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public HNMINGFKGHL.GNBOPFKGIKH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private PAOCCIHDHAG <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private LEPJMEIDDOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
		[DebuggerHidden]
		public GKBOPFGAMJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x40C5350", Offset = "0x40C4750", VA = "0x1840C5350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x40C5420", Offset = "0x40C4820", VA = "0x1840C5420", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class HLLMMAJCFJK : IEnumerator<LEPJMEIDDOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private LEPJMEIDDOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public HNMINGFKGHL.GNBOPFKGIKH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private PAOCCIHDHAG <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private LEPJMEIDDOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
		[DebuggerHidden]
		public HLLMMAJCFJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x40C6A40", Offset = "0x40C5E40", VA = "0x1840C6A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x40C6B30", Offset = "0x40C5F30", VA = "0x1840C6B30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x40CB730", Offset = "0x40CAB30", VA = "0x1840CB730")]
	public static AAEMKIFCBKD HIAPGEIFCLG(Action BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x40CB820", Offset = "0x40CAC20", VA = "0x1840CB820")]
	public static AAEMKIFCBKD HIAPGEIFCLG(Action<float> BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x40CB620", Offset = "0x40CAA20", VA = "0x1840CB620")]
	public static AAEMKIFCBKD HIAPGEIFCLG(Behaviour HKKAAOILAFH, Action BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x40CB510", Offset = "0x40CA910", VA = "0x1840CB510")]
	public static AAEMKIFCBKD HIAPGEIFCLG(Behaviour HKKAAOILAFH, Action<float> BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x40CB400", Offset = "0x40CA800", VA = "0x1840CB400")]
	public static AAEMKIFCBKD FOGFDGPNPJP(AINBJHDGDII HKKAAOILAFH, Action BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x40CB2F0", Offset = "0x40CA6F0", VA = "0x1840CB2F0")]
	public static AAEMKIFCBKD FOGFDGPNPJP(AINBJHDGDII HKKAAOILAFH, Action<float> BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x40CB280", Offset = "0x40CA680", VA = "0x1840CB280")]
	[IteratorStateMachine(typeof(GKBOPFGAMJA))]
	private static IEnumerator<LEPJMEIDDOC> DIAKBPOALCF(HNMINGFKGHL.GNBOPFKGIKH INAEGPHOHJP, Action BFCCINGLGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x40CB210", Offset = "0x40CA610", VA = "0x1840CB210")]
	[IteratorStateMachine(typeof(HLLMMAJCFJK))]
	private static IEnumerator<LEPJMEIDDOC> DIAKBPOALCF(HNMINGFKGHL.GNBOPFKGIKH INAEGPHOHJP, Action<float> BFCCINGLGGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class LBKMGBFCNPB
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class BMINDDLDGDE : IEnumerator<LEPJMEIDDOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private LEPJMEIDDOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public HNMINGFKGHL.GNBOPFKGIKH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private AGPGLNDEFKA <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private LEPJMEIDDOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
		[DebuggerHidden]
		public BMINDDLDGDE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x40BF030", Offset = "0x40BE430", VA = "0x1840BF030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x40BF120", Offset = "0x40BE520", VA = "0x1840BF120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x40C94D0", Offset = "0x40C88D0", VA = "0x1840C94D0")]
	public static AAEMKIFCBKD HIAPGEIFCLG(float CJDCDDAKICB, Action<float> BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x40C9580", Offset = "0x40C8980", VA = "0x1840C9580")]
	public static AAEMKIFCBKD HIAPGEIFCLG(MonoBehaviour HDEHPBADHMN, float CJDCDDAKICB, Action<float> BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x40C9640", Offset = "0x40C8A40", VA = "0x1840C9640")]
	public static AAEMKIFCBKD NBIOIGNEDEK(AINBJHDGDII HKKAAOILAFH, float CJDCDDAKICB, Action<float> BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x40C9450", Offset = "0x40C8850", VA = "0x1840C9450")]
	[IteratorStateMachine(typeof(BMINDDLDGDE))]
	private static IEnumerator<LEPJMEIDDOC> DIAKBPOALCF(float CJDCDDAKICB, HNMINGFKGHL.GNBOPFKGIKH INAEGPHOHJP, Action<float> BFCCINGLGGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class KFNPNAFKELB
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class JGGMGAKFOJF : IEnumerator<LEPJMEIDDOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private LEPJMEIDDOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public HNMINGFKGHL.GNBOPFKGIKH queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private LEPJMEIDDOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
		[DebuggerHidden]
		public JGGMGAKFOJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x40C7470", Offset = "0x40C6870", VA = "0x1840C7470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x40C7510", Offset = "0x40C6910", VA = "0x1840C7510", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x40C8C90", Offset = "0x40C8090", VA = "0x1840C8C90")]
	[IteratorStateMachine(typeof(JGGMGAKFOJF))]
	private static IEnumerator<LEPJMEIDDOC> CDEEFHHEIOH(HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP, Func<bool> EMNPDECDGKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x40C8D00", Offset = "0x40C8100", VA = "0x1840C8D00")]
	public static AAEMKIFCBKD PJDGBENLCMI(this MonoBehaviour HDEHPBADHMN, Func<bool> EMNPDECDGKJ, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP = HNMINGFKGHL.GNBOPFKGIKH.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class CKKANEFHEAP
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class MDOANLHKACI : IEnumerator<LEPJMEIDDOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private LEPJMEIDDOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public HNMINGFKGHL.GNBOPFKGIKH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private LEPJMEIDDOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
		[DebuggerHidden]
		public MDOANLHKACI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x40CA3D0", Offset = "0x40C97D0", VA = "0x1840CA3D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x40CA480", Offset = "0x40C9880", VA = "0x1840CA480", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HGICDCLHHKD : IEnumerator<LEPJMEIDDOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private LEPJMEIDDOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public HNMINGFKGHL.GNBOPFKGIKH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private LEPJMEIDDOC <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private LEPJMEIDDOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
		[DebuggerHidden]
		public HGICDCLHHKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x40C6930", Offset = "0x40C5D30", VA = "0x1840C6930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x40C69F0", Offset = "0x40C5DF0", VA = "0x1840C69F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x40C02A0", Offset = "0x40BF6A0", VA = "0x1840C02A0")]
	[IteratorStateMachine(typeof(MDOANLHKACI))]
	private static IEnumerator<LEPJMEIDDOC> NLLOBNOHGBK(float EOIMJPDIPBB, HNMINGFKGHL.GNBOPFKGIKH INAEGPHOHJP, Action OPCLLKAKEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x40C00F0", Offset = "0x40BF4F0", VA = "0x1840C00F0")]
	[IteratorStateMachine(typeof(HGICDCLHHKD))]
	private static IEnumerator<LEPJMEIDDOC> KMJIHAMNLNM(float EOIMJPDIPBB, HNMINGFKGHL.GNBOPFKGIKH INAEGPHOHJP, Action OPCLLKAKEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x40BFBE0", Offset = "0x40BEFE0", VA = "0x1840BFBE0")]
	public static IDisposable DJAJFAPLBDC(this MonoBehaviour HDEHPBADHMN, float EOIMJPDIPBB, Action OPCLLKAKEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x40BFE80", Offset = "0x40BF280", VA = "0x1840BFE80")]
	public static AAEMKIFCBKD EALDEMFENDC(this MonoBehaviour HDEHPBADHMN, float EOIMJPDIPBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x40BFD20", Offset = "0x40BF120", VA = "0x1840BFD20")]
	public static AAEMKIFCBKD DJAJFAPLBDC(this MonoBehaviour HDEHPBADHMN, float EOIMJPDIPBB, HNMINGFKGHL.GNBOPFKGIKH INAEGPHOHJP, Action OPCLLKAKEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x40C0290", Offset = "0x40BF690", VA = "0x1840C0290")]
	public static AAEMKIFCBKD NKPALFJAHCG(this MonoBehaviour HDEHPBADHMN, Action OPCLLKAKEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x40BFFD0", Offset = "0x40BF3D0", VA = "0x1840BFFD0")]
	public static AAEMKIFCBKD HELNOKJDDPA(this MonoBehaviour HDEHPBADHMN, Action OPCLLKAKEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x40BFFC0", Offset = "0x40BF3C0", VA = "0x1840BFFC0")]
	public static AAEMKIFCBKD GBLFAOPLGFJ(this MonoBehaviour HDEHPBADHMN, Action OPCLLKAKEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x40BFE70", Offset = "0x40BF270", VA = "0x1840BFE70")]
	public static AAEMKIFCBKD DJGLPLGJPPN(this MonoBehaviour HDEHPBADHMN, Action OPCLLKAKEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x40C0280", Offset = "0x40BF680", VA = "0x1840C0280")]
	public static AAEMKIFCBKD NHHKCELPKLC(this MonoBehaviour HDEHPBADHMN, Action OPCLLKAKEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x40BFFE0", Offset = "0x40BF3E0", VA = "0x1840BFFE0")]
	private static AAEMKIFCBKD HIEJIGPGJPC(MonoBehaviour HDEHPBADHMN, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP, Action OPCLLKAKEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x40BFAD0", Offset = "0x40BEED0", VA = "0x1840BFAD0")]
	public static AAEMKIFCBKD CNKBKOMHAHM(this MonoBehaviour HDEHPBADHMN, float MFGNNDCHBDJ, Action OPCLLKAKEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x40C0170", Offset = "0x40BF570", VA = "0x1840C0170")]
	public static AAEMKIFCBKD NDDGBACMAOC(this MonoBehaviour HDEHPBADHMN, float MFGNNDCHBDJ, Action OPCLLKAKEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x40BF8B0", Offset = "0x40BECB0", VA = "0x1840BF8B0")]
	public static AAEMKIFCBKD ADBJKONNIHG(this MonoBehaviour HDEHPBADHMN, float MFGNNDCHBDJ, Action OPCLLKAKEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x40C0320", Offset = "0x40BF720", VA = "0x1840C0320")]
	public static AAEMKIFCBKD OFCCHDENEAI(this MonoBehaviour HDEHPBADHMN, float MFGNNDCHBDJ, Action OPCLLKAKEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x40BF9C0", Offset = "0x40BEDC0", VA = "0x1840BF9C0")]
	public static AAEMKIFCBKD BJHGCJNDKHD(this MonoBehaviour HDEHPBADHMN, float MFGNNDCHBDJ, Action OPCLLKAKEIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ELLNJEELBCI : IFLDMFBLFBN
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class DIBGMKCPNDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public ELLNJEELBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
		public DIBGMKCPNDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x40C1E40", Offset = "0x40C1240", VA = "0x1840C1E40")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HCCFOKNMCBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public ELLNJEELBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
		public HCCFOKNMCBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x40C1E40", Offset = "0x40C1240", VA = "0x1840C1E40")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly float BCFDOKNKPDG;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x40C1A10", Offset = "0x40C0E10", VA = "0x1840C1A10")]
	public ELLNJEELBCI(Behaviour HKKAAOILAFH, float BCFDOKNKPDG, [Optional] Action ENMJNDNGCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x40C20D0", Offset = "0x40C14D0", VA = "0x1840C20D0", Slot = "9")]
	protected override bool LLCFOKILHNL(Action LJDENNCKKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x40C2000", Offset = "0x40C1400", VA = "0x1840C2000", Slot = "10")]
	protected override bool KPDCJKEEAOD(Action LJDENNCKKFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface FBNJNFPFBIM
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool BGPBEFCJJND
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action BCKFCBDOGDD;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MLBBFFIFGHJ(bool DIIGMENOHCB = false);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MLBBFFIFGHJ(Action LJDENNCKKFN, bool DIIGMENOHCB = false);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class IFLDMFBLFBN : FBNJNFPFBIM
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class CBMCPBLNFHN : IEnumerator<LEPJMEIDDOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private LEPJMEIDDOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private LEPJMEIDDOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
		[DebuggerHidden]
		public CBMCPBLNFHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x40BF300", Offset = "0x40BE700", VA = "0x1840BF300", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x40BF3A0", Offset = "0x40BE7A0", VA = "0x1840BF3A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly Behaviour HKKAAOILAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly Action ENMJNDNGCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private DLIEPAHNDMA NGAMLIHNHKO;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool BGPBEFCJJND
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x671EE0", Offset = "0x6712E0", VA = "0x180671EE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action BCKFCBDOGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x40C6E80", Offset = "0x40C6280", VA = "0x1840C6E80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x40C6D50", Offset = "0x40C6150", VA = "0x1840C6D50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x230B350", Offset = "0x230A750", VA = "0x18230B350")]
	protected IFLDMFBLFBN(Behaviour HKKAAOILAFH, [Optional] Action ENMJNDNGCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x40C6F90", Offset = "0x40C6390", VA = "0x1840C6F90", Slot = "7")]
	public bool MLBBFFIFGHJ(bool DIIGMENOHCB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x40C6F40", Offset = "0x40C6340", VA = "0x1840C6F40", Slot = "8")]
	public bool MLBBFFIFGHJ(Action LJDENNCKKFN, bool DIIGMENOHCB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool LLCFOKILHNL(Action LJDENNCKKFN);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool KPDCJKEEAOD(Action LJDENNCKKFN);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x40C6DF0", Offset = "0x40C61F0", VA = "0x1840C6DF0")]
	protected void HDBODGHOPON(Action LJDENNCKKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x40C6B80", Offset = "0x40C5F80", VA = "0x1840C6B80")]
	protected IDJKGJMBBAG AOEKIKGFCMA(float NIGMEAALDLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x40C6E10", Offset = "0x40C6210", VA = "0x1840C6E10")]
	private void HDMIKIOMCJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x40C6FF0", Offset = "0x40C63F0", VA = "0x1840C6FF0")]
	[IteratorStateMachine(typeof(CBMCPBLNFHN))]
	private static IEnumerator<LEPJMEIDDOC> OJBMJFOHIHN(float NIGMEAALDLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x40C6F20", Offset = "0x40C6320", VA = "0x1840C6F20")]
	[CompilerGenerated]
	private void LHBKOAAAAAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class CGLCFEHJJGN : IFLDMFBLFBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly float DBGJBEJDLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly int INGHDJBIHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly float HFNIBFBJBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly float[] NBDGAEDJMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int KHNGPNBBMII;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NAAFMHPAOPI OJDBLGDGBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4E7670", Offset = "0x4E6A70", VA = "0x1804E7670")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x59F9E0", Offset = "0x59EDE0", VA = "0x18059F9E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x40BF7A0", Offset = "0x40BEBA0", VA = "0x1840BF7A0")]
	public CGLCFEHJJGN(Behaviour HKKAAOILAFH, float GDKHFDNACIE, int INGHDJBIHHN, [Optional] Action ENMJNDNGCLE, float HFNIBFBJBNE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E40", Offset = "0x4C0240", VA = "0x1804C0E40", Slot = "9")]
	protected override bool LLCFOKILHNL(Action LJDENNCKKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x40BF4F0", Offset = "0x40BE8F0", VA = "0x1840BF4F0", Slot = "10")]
	protected override bool KPDCJKEEAOD(Action LJDENNCKKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x40BF710", Offset = "0x40BEB10", VA = "0x1840BF710")]
	private void NKBNPEHJJID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class DDEGFAIMLPO : IFLDMFBLFBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly float BCFDOKNKPDG;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x40C1A10", Offset = "0x40C0E10", VA = "0x1840C1A10")]
	public DDEGFAIMLPO(Behaviour HKKAAOILAFH, float BCFDOKNKPDG, [Optional] Action ENMJNDNGCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E40", Offset = "0x4C0240", VA = "0x1804C0E40", Slot = "9")]
	protected override bool LLCFOKILHNL(Action LJDENNCKKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x40C19D0", Offset = "0x40C0DD0", VA = "0x1840C19D0", Slot = "10")]
	protected override bool KPDCJKEEAOD(Action LJDENNCKKFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class EOAJDOGHCDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class IIFBGKEDAHE : IEnumerator<LEPJMEIDDOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private LEPJMEIDDOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private LEPJMEIDDOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
		[DebuggerHidden]
		public IIFBGKEDAHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x40C7330", Offset = "0x40C6730", VA = "0x1840C7330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x40C7420", Offset = "0x40C6820", VA = "0x1840C7420", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private AAEMKIFCBKD KKNKBOKBMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private AINBJHDGDII HKKAAOILAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Action BFCCINGLGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Action<float> NJBJMFPJLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private float ENPFDFOIDIL;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x40C2AB0", Offset = "0x40C1EB0", VA = "0x1840C2AB0")]
	public EOAJDOGHCDH(AINBJHDGDII HKKAAOILAFH, Action BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x40C2920", Offset = "0x40C1D20", VA = "0x1840C2920")]
	public EOAJDOGHCDH(AINBJHDGDII HKKAAOILAFH, Action<float> BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x40C2C40", Offset = "0x40C2040", VA = "0x1840C2C40")]
	public EOAJDOGHCDH(AINBJHDGDII HKKAAOILAFH, float CJDCDDAKICB, Action<float> BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x40C2400", Offset = "0x40C1800", VA = "0x1840C2400")]
	private void HIAPGEIFCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x40C2580", Offset = "0x40C1980", VA = "0x1840C2580")]
	private void HOOOPJEGKAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x40C2280", Offset = "0x40C1680", VA = "0x1840C2280")]
	private void DCIKFKKONGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x40C2700", Offset = "0x40C1B00", VA = "0x1840C2700")]
	private void MJLJPIDPNMJ(string EOFGEJBPEDB, Action MOMEDKIJBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x40C2220", Offset = "0x40C1620", VA = "0x1840C2220")]
	[IteratorStateMachine(typeof(IIFBGKEDAHE))]
	private IEnumerator<LEPJMEIDDOC> BLBPAADDLKP(Action MOMEDKIJBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x40C23B0", Offset = "0x40C17B0", VA = "0x1840C23B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x40C2820", Offset = "0x40C1C20", VA = "0x1840C2820")]
	[CompilerGenerated]
	private void NHNPILDAOFJ(string LKGDCBMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x40C28A0", Offset = "0x40C1CA0", VA = "0x1840C28A0")]
	[CompilerGenerated]
	private void PNBHLMFLEHF(string LKGDCBMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x40C21A0", Offset = "0x40C15A0", VA = "0x1840C21A0")]
	[CompilerGenerated]
	private void AJCFKILFFJG(string LKGDCBMCJOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class GEKLJIKMGNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class IGPDNCIDECB : IEnumerator<LEPJMEIDDOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private LEPJMEIDDOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private LEPJMEIDDOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
		[DebuggerHidden]
		public IGPDNCIDECB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x40C7050", Offset = "0x40C6450", VA = "0x1840C7050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x40C7140", Offset = "0x40C6540", VA = "0x1840C7140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private AAEMKIFCBKD KKNKBOKBMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private MonoBehaviour HDEHPBADHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Action BFCCINGLGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Action<float> NJBJMFPJLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float ENPFDFOIDIL;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x40C5030", Offset = "0x40C4430", VA = "0x1840C5030")]
	public GEKLJIKMGNP(MonoBehaviour HDEHPBADHMN, Action BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x40C51C0", Offset = "0x40C45C0", VA = "0x1840C51C0")]
	public GEKLJIKMGNP(MonoBehaviour HDEHPBADHMN, Action<float> BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x40C4EE0", Offset = "0x40C42E0", VA = "0x1840C4EE0")]
	public GEKLJIKMGNP(MonoBehaviour HDEHPBADHMN, float CJDCDDAKICB, Action<float> BFCCINGLGGI, HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x40C49C0", Offset = "0x40C3DC0", VA = "0x1840C49C0")]
	private void HIAPGEIFCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x40C4B40", Offset = "0x40C3F40", VA = "0x1840C4B40")]
	private void HOOOPJEGKAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x40C4840", Offset = "0x40C3C40", VA = "0x1840C4840")]
	private void DCIKFKKONGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x40C4CC0", Offset = "0x40C40C0", VA = "0x1840C4CC0")]
	private void MJLJPIDPNMJ(string EOFGEJBPEDB, Action MOMEDKIJBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x40C47E0", Offset = "0x40C3BE0", VA = "0x1840C47E0")]
	[IteratorStateMachine(typeof(IGPDNCIDECB))]
	private IEnumerator<LEPJMEIDDOC> BLBPAADDLKP(Action MOMEDKIJBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x40C4970", Offset = "0x40C3D70", VA = "0x1840C4970", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x40C4DE0", Offset = "0x40C41E0", VA = "0x1840C4DE0")]
	[CompilerGenerated]
	private void NHNPILDAOFJ(string LKGDCBMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x40C4E60", Offset = "0x40C4260", VA = "0x1840C4E60")]
	[CompilerGenerated]
	private void PNBHLMFLEHF(string LKGDCBMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x40C4760", Offset = "0x40C3B60", VA = "0x1840C4760")]
	[CompilerGenerated]
	private void AJCFKILFFJG(string LKGDCBMCJOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface JKANBOCGMLK
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int MCDJEGADHDD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class ANDCEKJGNAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly ANDCEKJGNAB OEHOPKENIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly Action ABFCJCJCJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool MLHANBCAPNP;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x59C930", Offset = "0x59BD30", VA = "0x18059C930")]
	public ANDCEKJGNAB(Action ABFCJCJCJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x40BCD20", Offset = "0x40BC120", VA = "0x1840BCD20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface JODGFMJCFPO<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T JLGPLOCBIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable GCIAONCELMP(Action<T> DCBAHJBPDNO);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable GCIAONCELMP(UnityEngine.Object HKKAAOILAFH, Action<T> DCBAHJBPDNO);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface PBLCODLKFNF<T> : global::JODGFMJCFPO<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T JLGPLOCBIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class CKMPMFKPJIP<T> : global::PBLCODLKFNF<T>, global::JODGFMJCFPO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class LNPOBGFPIKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public global::CKMPMFKPJIP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public global::HPBHBCOLGDM<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1612F10", Offset = "0x1612310", VA = "0x181612F10")]
		public LNPOBGFPIKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3770CE0", Offset = "0x37700E0", VA = "0x183770CE0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static GameObject NIBDKIPOHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<global::HPBHBCOLGDM<UnityEngine.Object, Action<T>>> HECJBOEKKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private T LGJCKEHEGCM;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object JKHFABLCBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x37693D0", Offset = "0x37687D0", VA = "0x1837693D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T JLGPLOCBIGO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x63CB90", Offset = "0x63BF90", VA = "0x18063CB90", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3769890", Offset = "0x3768C90", VA = "0x183769890", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3769820", Offset = "0x3768C20", VA = "0x183769820")]
	private static bool OHBGFCLFNEP(T PMCCKINNHFA, T IHCAKNPGPJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3299CE0", Offset = "0x32990E0", VA = "0x183299CE0")]
	public CKMPMFKPJIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3769A20", Offset = "0x3768E20", VA = "0x183769A20")]
	public CKMPMFKPJIP(T KCFFPGGGOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3769950", Offset = "0x3768D50", VA = "0x183769950")]
	public void PHJHHOGPDGA(T DGCMBAFCDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3769220", Offset = "0x3768620", VA = "0x183769220", Slot = "7")]
	public IDisposable GCIAONCELMP(Action<T> DCBAHJBPDNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3769290", Offset = "0x3768690", VA = "0x183769290", Slot = "8")]
	public IDisposable GCIAONCELMP(UnityEngine.Object HKKAAOILAFH, Action<T> DCBAHJBPDNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3768DC0", Offset = "0x37681C0", VA = "0x183768DC0")]
	private void CDONIPKBNKA()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<KPLDIAICJNB, Scheduler>, KPLDIAICJNB
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private class LCKLGDMIIOA : JKANBOCGMLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public BGKGJAKNCII EEOFIHPNJON;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int MCDJEGADHDD
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x4C0E50", Offset = "0x4C0250", VA = "0x1804C0E50", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x4C0E60", Offset = "0x4C0260", VA = "0x1804C0E60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x40C97F0", Offset = "0x40C8BF0", VA = "0x1840C97F0")]
			public static LEPJMEIDDOC NCGOAEJOABO(IEnumerator<LEPJMEIDDOC> NNHFANOCNOO, ECIACJKKKNK JDMAEGNPLGI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x40C9950", Offset = "0x40C8D50", VA = "0x1840C9950")]
			public LEPJMEIDDOC NCGOAEJOABO(ECIACJKKKNK[] HHBENPCKMHC, IEnumerator<LEPJMEIDDOC>[] OCPBLPGLPHE, LEPJMEIDDOC[] OJOOKPBPNIG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x40C9700", Offset = "0x40C8B00", VA = "0x1840C9700")]
			public void FAKLEHBJIDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x40C9730", Offset = "0x40C8B30", VA = "0x1840C9730")]
			public void MKONOECJAPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x40C9A20", Offset = "0x40C8E20", VA = "0x1840C9A20")]
			public void OGENHMJNCKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x40C9700", Offset = "0x40C8B00", VA = "0x1840C9700")]
			public void DLLGEGLILFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
			public LCKLGDMIIOA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class BGKGJAKNCII
		{
			[Cpp2IlInjected.Token(Token = "0x2000046")]
			public struct OOMFEHDFAJN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public LCKLGDMIIOA IIHBJJMKFFC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public AINBJHDGDII LEEMJGOOAAK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public ECIACJKKKNK FPFCCFPNOHD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public IEnumerator<LEPJMEIDDOC> OJAJDLNAMPH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public LEPJMEIDDOC HIJLHAEDOGJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public BDPJDIPNPGH NBCHCAEJDFD;
			}

			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public struct GGIPICCPPLL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public HNMINGFKGHL.GNBOPFKGIKH PLEKDMBFMIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public List<OOMFEHDFAJN> PBKPELCMDEA;
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			[CompilerGenerated]
			private sealed class GLMOHJEPPMM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public BGKGJAKNCII <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public AINBJHDGDII context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public LCKLGDMIIOA routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public BDPJDIPNPGH coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public ECIACJKKKNK promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public LEPJMEIDDOC currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public IEnumerator<LEPJMEIDDOC> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
				public GLMOHJEPPMM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x40C5810", Offset = "0x40C4C10", VA = "0x1840C5810")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private sealed class EHLEABCNMJJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public LCKLGDMIIOA schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public BGKGJAKNCII <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
				public EHLEABCNMJJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0x40C1FC0", Offset = "0x40C13C0", VA = "0x1840C1FC0")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class JOFPMAFCOFN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public LCKLGDMIIOA schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public BGKGJAKNCII <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
				public JOFPMAFCOFN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x40C7EB0", Offset = "0x40C72B0", VA = "0x1840C7EB0")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class KKFEGCDJIKO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public LCKLGDMIIOA schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public BGKGJAKNCII <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
				public KKFEGCDJIKO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x40C8E50", Offset = "0x40C8250", VA = "0x1840C8E50")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private readonly HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private bool[] KLOMCPNFOLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<BDPJDIPNPGH> LJDJNCIFKPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<float> FCHGDEDGNFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private NativeArray<int> CBAGFJGFNIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private NativeArray<int> IBIHGNFGNMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private NativeArray<int> BHMEMHPLEPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<int> APOKLKPACOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<int> MIPFFFKEJON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private LCKLGDMIIOA[] MJCPBINKKCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private ECIACJKKKNK[] HHBENPCKMHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private AINBJHDGDII[] LEMFMMGFAPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private IEnumerator<LEPJMEIDDOC>[] DMPOMLDFADF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private LEPJMEIDDOC[] DCHGJAMPGGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private int KPAIKAJPGNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private int GODBNEEDLBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private readonly int LJHCJICEKEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private float PEDHNDHEHLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private KNIBDAIHNIE GJNAHDLJHGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private JobHandle BOCGJKLDMLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private List<LCKLGDMIIOA> AJAGHGKALAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private bool KDJNOIJGFMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private List<Action> ABOOMMHGJJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private List<Action> KLHKBGKNFBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private bool KPFMMANOLDL;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public GGIPICCPPLL[] NFOEHNEOING
			{
				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x7B0C10", Offset = "0x7B0010", VA = "0x1807B0C10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int AIPAOKDEEIF
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x9FAD60", Offset = "0x9FA160", VA = "0x1809FAD60")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x40BD980", Offset = "0x40BCD80", VA = "0x1840BD980")]
			private static int FFFGLKPGLGI(HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x40BEB60", Offset = "0x40BDF60", VA = "0x1840BEB60")]
			public BGKGJAKNCII(HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x40BD9B0", Offset = "0x40BCDB0", VA = "0x1840BD9B0")]
			private void FKNIEMEKDPI(ref int GHCJNFOKBFO, int NIPCLFONDEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x40BD530", Offset = "0x40BC930", VA = "0x1840BD530")]
			public void CPKGFBPNCKM(AINBJHDGDII HKKAAOILAFH, LEPJMEIDDOC BIJNHBEIKAB, IEnumerator<LEPJMEIDDOC> NNHFANOCNOO, ECIACJKKKNK JDMAEGNPLGI, [Optional] LCKLGDMIIOA HOIIPFBNFNO, BDPJDIPNPGH CIPCBHEMNKP = BDPJDIPNPGH.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x40BD340", Offset = "0x40BC740", VA = "0x1840BD340")]
			public void COEKEGGNGBD(IEnumerable<OOMFEHDFAJN> LDKJEBKINOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x40BE730", Offset = "0x40BDB30", VA = "0x1840BE730")]
			private OOMFEHDFAJN NJDFAKHCBDH(int PIDGNNBGBGE)
			{
				return default(OOMFEHDFAJN);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x40BDCD0", Offset = "0x40BD0D0", VA = "0x1840BDCD0")]
			private void HHNFFONBJOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x1C84D90", Offset = "0x1C84190", VA = "0x181C84D90")]
			private static void NKJMIDKEJGH<T>(int PIDGNNBGBGE, T[] IDBMOPMNFMM, int IANKEMBPHFD, [Optional] T OEOPKJAOKHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x1C84D70", Offset = "0x1C84170", VA = "0x181C84D70")]
			private static void NKJMIDKEJGH<T>(int PIDGNNBGBGE, NativeArray<T> IDBMOPMNFMM, int IANKEMBPHFD, [Optional] T OEOPKJAOKHL) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x40BE140", Offset = "0x40BD540", VA = "0x1840BE140")]
			private void JJAFHCOMLPC(IEnumerable<OOMFEHDFAJN> LDKJEBKINOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x40BE000", Offset = "0x40BD400", VA = "0x1840BE000")]
			private void HJPKOCKHONO(OOMFEHDFAJN OIGBBOGFJHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x40BE490", Offset = "0x40BD890", VA = "0x1840BE490")]
			private LOAAACIFOGJ NALLBDPNABD(int MHGDIEKEFOC)
			{
				return default(LOAAACIFOGJ);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x40BD710", Offset = "0x40BCB10", VA = "0x1840BD710")]
			public void FAKOBKFBGFA(float BCCGHECNMML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x40BE0C0", Offset = "0x40BD4C0", VA = "0x1840BE0C0")]
			private void JGLJBFEJDCK(Action PMCCKINNHFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x40BD900", Offset = "0x40BCD00", VA = "0x1840BD900")]
			private void FAOIIDLPGEA(Action PMCCKINNHFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x40BCEA0", Offset = "0x40BC2A0", VA = "0x1840BCEA0")]
			public void ANLEOANNGPJ(float BCCGHECNMML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x40BDB40", Offset = "0x40BCF40", VA = "0x1840BDB40")]
			public void GANOHKODJBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x40BD660", Offset = "0x40BCA60", VA = "0x1840BD660")]
			public void DLLGEGLILFM(LCKLGDMIIOA FOOPFNFBNII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x40BE3E0", Offset = "0x40BD7E0", VA = "0x1840BE3E0")]
			public void JJGODHNHMHG(LCKLGDMIIOA FOOPFNFBNII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x40BDC20", Offset = "0x40BD020", VA = "0x1840BDC20")]
			public void GKFDIMKLNEA(LCKLGDMIIOA FOOPFNFBNII)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[BurstCompile]
		public struct KNIBDAIHNIE : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			[ReadOnly]
			public float AADNPLHNJCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			[ReadOnly]
			public int AGAAAMGIPDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private NativeArray<int> PIHBMHFECEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private NativeArray<int> EGJNDGOCBFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private NativeArray<int> NJPBDNDNOCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public NativeArray<BDPJDIPNPGH> PFNMMCAKAMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public NativeArray<float> PCHOIFALJBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			[WriteOnly]
			public NativeArray<int> BHMEMHPLEPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			[WriteOnly]
			public NativeArray<int> CBAGFJGFNIH;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x40C9270", Offset = "0x40C8670", VA = "0x1840C9270")]
			public static KNIBDAIHNIE IDOEMBPAOBJ(int PDMBPEINNDL, float BCCGHECNMML, NativeArray<BDPJDIPNPGH> JAKLIMIKFKN, NativeArray<float> FGDBADNDCDM, NativeArray<int> BEAOOJBBBON, NativeArray<int> JOHBEKFILLG, NativeArray<int> MDGOHHNHEEF, NativeArray<int> EGJNDGOCBFO, NativeArray<int> NJPBDNDNOCC)
			{
				return default(KNIBDAIHNIE);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x40C8E90", Offset = "0x40C8290", VA = "0x1840C8E90", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x40C93E0", Offset = "0x40C87E0", VA = "0x1840C93E0")]
			private bool PDOPPKILECF(int PJNLMJGFOGO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x40C9340", Offset = "0x40C8740", VA = "0x1840C9340")]
			private void IMMENFMFMLA(NativeArray<int> LLHBAKAHLLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x40C9370", Offset = "0x40C8770", VA = "0x1840C9370")]
			private int ODKAJPEBAKM(int ABDCAGOFKNI, int GOKLHBGIMMJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x40C91A0", Offset = "0x40C85A0", VA = "0x1840C91A0")]
			private void HAHKJLPILMA(NativeArray<int> LLHBAKAHLLG, int MCKEMGJBMPO, int PBIGGPCCIPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x40C8F70", Offset = "0x40C8370", VA = "0x1840C8F70")]
			private void FPOFPEHPMML(NativeArray<int> LLHBAKAHLLG, int JBBCEFCNDNN, int PBIEOPHBAOG, int BDDLKJNCJOJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private sealed class OJBCPDLLLKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly ECIACJKKKNK JDMAEGNPLGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly Behaviour HKKAAOILAFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private readonly bool PHEGLGAFBNN;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<LEPJMEIDDOC> OJAJDLNAMPH
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BF5A0", VA = "0x1804C01A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x4C0440", Offset = "0x4BF840", VA = "0x1804C0440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public LEPJMEIDDOC HIJLHAEDOGJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0x4C0450", Offset = "0x4BF850", VA = "0x1804C0450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool HBKBGGKDLKA
			{
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x40CAC40", Offset = "0x40CA040", VA = "0x1840CAC40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool OPHCAMJGPEN
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x6FA930", Offset = "0x6F9D30", VA = "0x1806FA930")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x1FB0DE0", Offset = "0x1FB01E0", VA = "0x181FB0DE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string OPMLDJHPFMG
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x4C0F90", Offset = "0x4C0390", VA = "0x1804C0F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x4C0FA0", Offset = "0x4C03A0", VA = "0x1804C0FA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float IBBLIHLDGEO
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0xFD5AB0", Offset = "0xFD4EB0", VA = "0x180FD5AB0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0xFD6080", Offset = "0xFD5480", VA = "0x180FD6080")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x40CB090", Offset = "0x40CA490", VA = "0x1840CB090")]
			public OJBCPDLLLKN(IEnumerator<LEPJMEIDDOC> NNHFANOCNOO, Behaviour HKKAAOILAFH, ECIACJKKKNK JDMAEGNPLGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x40CADF0", Offset = "0x40CA1F0", VA = "0x1840CADF0")]
			public LEPJMEIDDOC NCGOAEJOABO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x40CAD60", Offset = "0x40CA160", VA = "0x1840CAD60")]
			public bool JPGANFNPCCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x40CACD0", Offset = "0x40CA0D0", VA = "0x1840CACD0")]
			public void DLLGEGLILFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x40CB000", Offset = "0x40CA400", VA = "0x1840CB000", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x1247A40", Offset = "0x1246E40", VA = "0x181247A40")]
			[CompilerGenerated]
			private void FBNFDLOHKOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private sealed class ECIACJKKKNK : GKFOBBFOLHI, AAEMKIFCBKD, DLIEPAHNDMA, IDJKGJMBBAG, IEnumerator, LEPJMEIDDOC, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private HNMINGFKGHL.GNBOPFKGIKH JNEOIDGMJCN;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private HNMINGFKGHL.GNBOPFKGIKH ICKPLGILBMG
			{
				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x4E4290", Offset = "0x4E3690", VA = "0x1804E4290", Slot = "23")]
				get
				{
					return default(HNMINGFKGHL.GNBOPFKGIKH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public HNMINGFKGHL.GNBOPFKGIKH EEOFIHPNJON
			{
				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x4E4290", Offset = "0x4E3690", VA = "0x1804E4290")]
				get
				{
					return default(HNMINGFKGHL.GNBOPFKGIKH);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x695060", Offset = "0x694460", VA = "0x180695060")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float JNOKAJCBNAM
			{
				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0xD28760", Offset = "0xD27B60", VA = "0x180D28760", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x40C1E80", Offset = "0x40C1280", VA = "0x1840C1E80", Slot = "24")]
			private bool EGJHJPLNOIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x40C1E70", Offset = "0x40C1270", VA = "0x1840C1E70", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x40C1EA0", Offset = "0x40C12A0", VA = "0x1840C1EA0")]
			public ECIACJKKKNK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private enum LOAAACIFOGJ : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class FODBADGEBMA : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			public enum CIGDLKPBOAJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000052")]
			public struct BMENPINOJBF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				public HNMINGFKGHL.GNBOPFKGIKH PLEKDMBFMIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public CIGDLKPBOAJ DKDNPCALOHM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public List<OJBCPDLLLKN> PBGFPAACGDD;
			}

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private static readonly CIGDLKPBOAJ[] FHOFDCKNOLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private bool MJENJHABEFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly OJBCPDLLLKN[] HGODBCGOPBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly List<OJBCPDLLLKN> CCPHCLHDBNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private readonly Stack<int> DEJCJGELLBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly List<OJBCPDLLLKN> HJOPEACIAAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly Stack<int> NFNLDGLJCCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private bool KPFMMANOLDL;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public BMENPINOJBF[,] LMJAJEEHOKC
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x4D3470", Offset = "0x4D2870", VA = "0x1804D3470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int AIPAOKDEEIF
			{
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x40C37F0", Offset = "0x40C2BF0", VA = "0x1840C37F0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x40C4380", Offset = "0x40C3780", VA = "0x1840C4380")]
			public FODBADGEBMA(HNMINGFKGHL.GNBOPFKGIKH INAEGPHOHJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x40C2F30", Offset = "0x40C2330", VA = "0x1840C2F30")]
			public void AIDHLJALGMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x40C36E0", Offset = "0x40C2AE0", VA = "0x1840C36E0")]
			public void GHIANLPPFNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x40C3270", Offset = "0x40C2670", VA = "0x1840C3270")]
			private void DEFADAKAHAL(IReadOnlyList<OJBCPDLLLKN> EJLMNIBMHPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x40C36F0", Offset = "0x40C2AF0", VA = "0x1840C36F0")]
			public void HJIHCEAFGFM(OJBCPDLLLKN NNHFANOCNOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x40C2F40", Offset = "0x40C2340", VA = "0x1840C2F40")]
			public void BIAEMBLNCFO(IList<OJBCPDLLLKN> OCPBLPGLPHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x40C3CB0", Offset = "0x40C30B0", VA = "0x1840C3CB0")]
			public void KLGCHMMNHDO(IList<OJBCPDLLLKN> OCPBLPGLPHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x40C35F0", Offset = "0x40C29F0", VA = "0x1840C35F0")]
			private void GEDNDMDIEKC(OJBCPDLLLKN NNHFANOCNOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x40C3B40", Offset = "0x40C2F40", VA = "0x1840C3B40")]
			private void KJIFIMCLOKK(IList<OJBCPDLLLKN> OCPBLPGLPHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x40C4130", Offset = "0x40C3530", VA = "0x1840C4130")]
			private LOAAACIFOGJ PPCHJEBJJFP(OJBCPDLLLKN NNHFANOCNOO)
			{
				return default(LOAAACIFOGJ);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x40C31C0", Offset = "0x40C25C0", VA = "0x1840C31C0")]
			public void CPCFLAIEIOH(float BCCGHECNMML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x40C3F30", Offset = "0x40C3330", VA = "0x1840C3F30")]
			public void NDPBLPJFFIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x40C3960", Offset = "0x40C2D60", VA = "0x1840C3960")]
			private void IJOHHCBPKLG(List<OJBCPDLLLKN> OCPBLPGLPHE, Stack<int> EGHCAEFEOPN, bool HIAMHPOCFEI, float MLDOIIPFFBL = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x40C3390", Offset = "0x40C2790", VA = "0x1840C3390", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x40C34D0", Offset = "0x40C28D0", VA = "0x1840C34D0")]
			private void EBJOKLAJLAO(List<OJBCPDLLLKN> OCPBLPGLPHE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[Flags]
		public enum BDPJDIPNPGH : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			Inactive = 0,
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			Running = 1,
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			Cancelled = 2,
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			Paused = 4
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class LFPCLBOCICO : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D4")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
			[DebuggerHidden]
			public LFPCLBOCICO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x40CA0C0", Offset = "0x40C94C0", VA = "0x1840CA0C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x40CA140", Offset = "0x40C9540", VA = "0x1840CA140", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private const BDPJDIPNPGH POLGKPPIJLJ = BDPJDIPNPGH.Cancelled | BDPJDIPNPGH.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static readonly HNMINGFKGHL.GNBOPFKGIKH[] ICNNMPBFDDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private FODBADGEBMA[] OMEFILDEOMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private BGKGJAKNCII[] KBKKLDBIKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private Coroutine DIDDKDKIIKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private WaitForEndOfFrame ONJLNPCGHFO;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public HNMINGFKGHL.GNBOPFKGIKH OOKNFNBAFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x5440A0", Offset = "0x5434A0", VA = "0x1805440A0")]
			[CompilerGenerated]
			get
			{
				return default(HNMINGFKGHL.GNBOPFKGIKH);
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x5B93C0", Offset = "0x5B87C0", VA = "0x1805B93C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool LEJMCBJJBGF
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x6FA630", Offset = "0x6F9A30", VA = "0x1806FA630", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x161BE70", Offset = "0x161B270", VA = "0x18161BE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int AIPAOKDEEIF
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x40CD700", Offset = "0x40CCB00", VA = "0x1840CD700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x40CC590", Offset = "0x40CB990", VA = "0x1840CC590")]
		public static AAEMKIFCBKD GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x40CBED0", Offset = "0x40CB2D0", VA = "0x1840CBED0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x40CC660", Offset = "0x40CBA60", VA = "0x1840CC660", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x40CC4D0", Offset = "0x40CB8D0", VA = "0x1840CC4D0")]
		private FODBADGEBMA BPBIIGDMGAH(HNMINGFKGHL.GNBOPFKGIKH ALJDBKKAGKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E7F0", Offset = "0x2B9DBF0", VA = "0x182B9E7F0")]
		private BGKGJAKNCII GOIHMOPCJGC(HNMINGFKGHL.GNBOPFKGIKH ALJDBKKAGKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x40CCAF0", Offset = "0x40CBEF0", VA = "0x1840CCAF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x40CCAC0", Offset = "0x40CBEC0", VA = "0x1840CCAC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x40CD4F0", Offset = "0x40CC8F0", VA = "0x1840CD4F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x40CC640", Offset = "0x40CBA40", VA = "0x1840CC640")]
		private void NIFLFBHEJCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x40CC650", Offset = "0x40CBA50", VA = "0x1840CC650")]
		private void OHGOECGMCCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x40CC580", Offset = "0x40CB980", VA = "0x1840CC580")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x40CC630", Offset = "0x40CBA30", VA = "0x1840CC630")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x40CC570", Offset = "0x40CB970", VA = "0x1840CC570")]
		private void EOONADAPGDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x40CCB60", Offset = "0x40CBF60", VA = "0x1840CCB60")]
		[IteratorStateMachine(typeof(LFPCLBOCICO))]
		private IEnumerator POHFJFEGLPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x40CCCF0", Offset = "0x40CC0F0", VA = "0x1840CCCF0", Slot = "7")]
		public AAEMKIFCBKD Run(IEnumerator<LEPJMEIDDOC> HLGCHGGHPIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x40CCD00", Offset = "0x40CC100", VA = "0x1840CCD00", Slot = "8")]
		public AAEMKIFCBKD Run(Behaviour HKKAAOILAFH, IEnumerator<LEPJMEIDDOC> HLGCHGGHPIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x40CCBC0", Offset = "0x40CBFC0", VA = "0x1840CCBC0", Slot = "9")]
		public AAEMKIFCBKD RunJobbed(AINBJHDGDII HKKAAOILAFH, IEnumerator<LEPJMEIDDOC> HLGCHGGHPIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x40CC510", Offset = "0x40CB910", VA = "0x1840CC510", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x40CD020", Offset = "0x40CC420", VA = "0x1840CD020")]
		public void UpdateQueue(HNMINGFKGHL.GNBOPFKGIKH MCCENIJLPBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x40CC310", Offset = "0x40CB710", VA = "0x1840CC310")]
		private void BILACJMHGFN(FODBADGEBMA MKLDCGPCBLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x40CBDB0", Offset = "0x40CB1B0", VA = "0x1840CBDB0")]
		private void AMHCPHJENOK(BGKGJAKNCII MKLDCGPCBLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x40CD6A0", Offset = "0x40CCAA0", VA = "0x1840CD6A0")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class BBIGAAPBDMM
{
	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x40BCE10", Offset = "0x40BC210", VA = "0x1840BCE10")]
	[FIFCHBEBPMJ]
	private static void ADKKKKDPMGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class POEEFCGHDJL : NAAFMHPAOPI
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float BJKNACBJPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x40CBDA0", Offset = "0x40CB1A0", VA = "0x1840CBDA0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float JJFGJALCBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x40CBD50", Offset = "0x40CB150", VA = "0x1840CBD50", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float GJNFDJEIHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x40CBD90", Offset = "0x40CB190", VA = "0x1840CBD90", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int DGFJEFADLON
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x40CBD60", Offset = "0x40CB160", VA = "0x1840CBD60", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double GPPLABLILMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x40CBD70", Offset = "0x40CB170", VA = "0x1840CBD70", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
	public POEEFCGHDJL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class LFKMCGFPHOI
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static byte[] OOHBEGEHNOI;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static int BNIOKLHNMMG;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static int CGJHMHBADGI;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static BigInteger ADAGEDNPLLD;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
	public LFKMCGFPHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x40C9E10", Offset = "0x40C9210", VA = "0x1840C9E10")]
	private static string KKMKMKDJDIC(byte[] IHCAKNPGPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x40C9AE0", Offset = "0x40C8EE0", VA = "0x1840C9AE0")]
	public static string CIJBPMJKAHN(byte[] CBCDDOHAMCB, bool PPCELFHNGKH)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
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

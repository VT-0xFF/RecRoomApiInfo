using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MNNEECKMIGD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority IAOKCPEKBGM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x216CE30", Offset = "0x216C030", VA = "0x18216CE30")]
	public MNNEECKMIGD(ThreadPriority JCGPLODBMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x216CE20", Offset = "0x216C020", VA = "0x18216CE20", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private delegate List<PlayerLoopSystem> DDJPIHIILFD(List<PlayerLoopSystem> HLDJHDFNBJL, int AJICCELGEFO);

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct JPOAGCCBFKJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct GLPIJKIKFGF
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static EOAHAKPACKC PJHBLHPIFIE;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x2169F90", Offset = "0x2169190", VA = "0x182169F90")]
				public static PlayerLoopSystem LLLPIOLNIJF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct DBJEAJGKEMI
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static EOAHAKPACKC JHHKCCNIGKD;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2162330", Offset = "0x2161530", VA = "0x182162330")]
				public static PlayerLoopSystem LLLPIOLNIJF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct NLLDONPPFOE
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static EOAHAKPACKC ILBENMNBGKD;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x216E830", Offset = "0x216DA30", VA = "0x18216E830")]
				public static PlayerLoopSystem LLLPIOLNIJF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct FLJNILPMHCO
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static EOAHAKPACKC COFLJNINPPC;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static EOAHAKPACKC LMAKNNENCHG;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static EOAHAKPACKC FOEMEMDPCAI;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static EOAHAKPACKC MKDOBEFEMIA;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2169270", Offset = "0x2168470", VA = "0x182169270")]
				public static PlayerLoopSystem LLLPIOLNIJF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct LLAEICBCIAD
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static EOAHAKPACKC KCILNLMNBOC;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x216C350", Offset = "0x216B550", VA = "0x18216C350")]
				public static PlayerLoopSystem LLLPIOLNIJF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct OCBOPIJDKEC
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static EOAHAKPACKC COFLJNINPPC;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static EOAHAKPACKC LMAKNNENCHG;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static EOAHAKPACKC FOEMEMDPCAI;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static EOAHAKPACKC MKDOBEFEMIA;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x216F5C0", Offset = "0x216E7C0", VA = "0x18216F5C0")]
				public static PlayerLoopSystem LLLPIOLNIJF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct OMGODGHGIEI
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static EOAHAKPACKC ELCFDECDLCO;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x216FD10", Offset = "0x216EF10", VA = "0x18216FD10")]
				public static PlayerLoopSystem LLLPIOLNIJF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct PJCPGOIJIEE
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static EOAHAKPACKC OCHNBLKCBEA;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2170870", Offset = "0x216FA70", VA = "0x182170870")]
				public static PlayerLoopSystem LLLPIOLNIJF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct GHGMDEDHLKJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static EOAHAKPACKC NEGLGCEMLIB;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2169DC0", Offset = "0x2168FC0", VA = "0x182169DC0")]
				public static PlayerLoopSystem LLLPIOLNIJF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct GBCHGJGMHKN
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static EOAHAKPACKC NDFBCOHKEHJ;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2169640", Offset = "0x2168840", VA = "0x182169640")]
				public static PlayerLoopSystem LLLPIOLNIJF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct BIJLICJNGJE
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static EOAHAKPACKC BBNMPFEKBNH;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x215E540", Offset = "0x215D740", VA = "0x18215E540")]
				public static PlayerLoopSystem LLLPIOLNIJF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001C")]
			internal struct KDFBADEPEHC
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				[CompilerGenerated]
				private sealed class NPLBBHBMGMM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002B")]
					public DDIBIEGFMGB.IDALFBAGLMC key;

					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
					public NPLBBHBMGMM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x216F510", Offset = "0x216E710", VA = "0x18216F510")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable GLPGIIHPLLJ;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x216B200", Offset = "0x216A400", VA = "0x18216B200")]
				public static PlayerLoopSystem LFIEJPJLHKB(DDIBIEGFMGB.IDALFBAGLMC JCNAPFOCJDI)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			internal struct IDBJLGANPLH
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				[CompilerGenerated]
				private sealed class ECNCNEKAODL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002C")]
					public DDIBIEGFMGB.IDALFBAGLMC key;

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
					public ECNCNEKAODL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x2166940", Offset = "0x2165B40", VA = "0x182166940")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x216A480", Offset = "0x2169680", VA = "0x18216A480")]
				public static PlayerLoopSystem LFIEJPJLHKB(DDIBIEGFMGB.IDALFBAGLMC JCNAPFOCJDI)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class NPBDEKNKFHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public NPBDEKNKFHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x216F410", Offset = "0x216E610", VA = "0x18216F410")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool CMFLLLIBNOC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool BJNPADBILDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x21605E0", Offset = "0x215F7E0", VA = "0x1821605E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x21605A0", Offset = "0x215F7A0", VA = "0x1821605A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2160620", Offset = "0x215F820", VA = "0x182160620")]
		private static void OFCLGAHLMDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x215FCE0", Offset = "0x215EEE0", VA = "0x18215FCE0")]
		private static void GOHGFPJILJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x215FA10", Offset = "0x215EC10", VA = "0x18215FA10")]
		private static void GMCHENOIAKJ(string KFPJBFAENEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x215F820", Offset = "0x215EA20", VA = "0x18215F820")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x215F650", Offset = "0x215E850", VA = "0x18215F650")]
		private static void ALJIMILECAP(DDIBIEGFMGB.IDALFBAGLMC JCNAPFOCJDI, ref PlayerLoopSystem GCJHGKKMEBE, Type DCNNLFGOBCO, Type KCDKCMPMJEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x215F2D0", Offset = "0x215E4D0", VA = "0x18215F2D0")]
		private static void AJDKLALBJGO(ref PlayerLoopSystem GCJHGKKMEBE, Type DCNNLFGOBCO, Type KCDKCMPMJEO, DDJPIHIILFD JJDEGCOAAAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2160480", Offset = "0x215F680", VA = "0x182160480")]
		private static void HFDKCMDACDA(ref PlayerLoopSystem GCJHGKKMEBE, Type DCNNLFGOBCO, Type KCDKCMPMJEO, PlayerLoopSystem? IKPGMEMLNGF, PlayerLoopSystem? MFJLLBBBLJK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class DDIBIEGFMGB
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum IDALFBAGLMC
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class NLPMJBIMILO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly IDALFBAGLMC ODIPIJLLHGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly ANMGEOJIFKL PJLAGCDHFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long FDDAKBIEHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private long LBPHJHJHOEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public long OCNGBJIKNAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int APDMKNGJLOK;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x216ECA0", Offset = "0x216DEA0", VA = "0x18216ECA0")]
		public NLPMJBIMILO(IDALFBAGLMC NKMFKDGDFFM, int GFBGJOLBPNI = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x216EC30", Offset = "0x216DE30", VA = "0x18216EC30")]
		public void MEDKEKNJAGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x216EA00", Offset = "0x216DC00", VA = "0x18216EA00")]
		public void CEKHLOCIBNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x216EA60", Offset = "0x216DC60", VA = "0x18216EA60")]
		public void MBDCICGBLDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static IDALFBAGLMC[] PAKHMLLCJDE;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static NLPMJBIMILO[] GBOBMIFHNLN;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x21626A0", Offset = "0x21618A0", VA = "0x1821626A0")]
	public static NLPMJBIMILO JMNJDBKLHMO(IDALFBAGLMC JCNAPFOCJDI, int GFBGJOLBPNI = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2162610", Offset = "0x2161810", VA = "0x182162610")]
	public static NLPMJBIMILO FCLPLMAGGMC(IDALFBAGLMC JCNAPFOCJDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2162850", Offset = "0x2161A50", VA = "0x182162850")]
	public static void PHHKDOBHODO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class ANMGEOJIFKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public int FBOICFNHDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Queue<double> EGALOEMPNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private double CKOAFJABJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private double ONDKPLDODAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private double BBJIBKPPMFG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double AJEFBCCDEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x215D1E0", Offset = "0x215C3E0", VA = "0x18215D1E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x215D3B0", Offset = "0x215C5B0", VA = "0x18215D3B0")]
	public ANMGEOJIFKL(int DNBMIAMFJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x215D240", Offset = "0x215C440", VA = "0x18215D240", Slot = "4")]
	public void LJNMBFPADNO(double AKJAPNHANKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x215D340", Offset = "0x215C540", VA = "0x18215D340", Slot = "5")]
	public void MJIFHFDNIAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KPEJHAEKJKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private long AEKEPEKODMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private double DNGGOCGMDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private double KCLLOABCICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private double AINPCPBNMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private double FOGBKNDDCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private double CKOAFJABJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private double ONDKPLDODAP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double AGNINMAJDGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1B702F0", Offset = "0x1B6F4F0", VA = "0x181B702F0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double LMHEKLFDLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x15E49B0", Offset = "0x15E3BB0", VA = "0x1815E49B0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double FMBIJOCAGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x17DB580", Offset = "0x17DA780", VA = "0x1817DB580")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double AJEFBCCDEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1B70220", Offset = "0x1B6F420", VA = "0x181B70220", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x216BE70", Offset = "0x216B070", VA = "0x18216BE70", Slot = "7")]
	public void LJNMBFPADNO(double AKJAPNHANKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x216BF90", Offset = "0x216B190", VA = "0x18216BF90", Slot = "8")]
	public void MJIFHFDNIAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x216BFD0", Offset = "0x216B1D0", VA = "0x18216BFD0")]
	public KPEJHAEKJKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class EBDJDHONHKK
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private interface KDCFGCMFGOM
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool ELLOHAEAEPB
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EBIMOMABEEF();
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private abstract class KCNJOLCIPLC<TPromise, TMainThreadPromise> : KDCFGCMFGOM where TPromise : NOJPGNEJCEO where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly TPromise CAANMBJGHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		protected readonly TMainThreadPromise NHLLOGJKFEP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise EMCEMLJMHKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4669E10", Offset = "0x4669010", VA = "0x184669E10")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ELLOHAEAEPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4669EA0", Offset = "0x46690A0", VA = "0x184669EA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1E06500", Offset = "0x1E05700", VA = "0x181E06500")]
		protected KCNJOLCIPLC(TPromise CAANMBJGHHM, TMainThreadPromise IHKAABNPKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4669E70", Offset = "0x4669070", VA = "0x184669E70", Slot = "5")]
		public void EBIMOMABEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void ICBMIIFPMLP(TPromise CAANMBJGHHM);
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private class FBLABCJPIKP<T> : KCNJOLCIPLC<global::GDKGOJJDLGI<T>, global::OKHIKHGPKEJ<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4663950", Offset = "0x4662B50", VA = "0x184663950")]
		public FBLABCJPIKP(global::GDKGOJJDLGI<T> CAANMBJGHHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4663720", Offset = "0x4662920", VA = "0x184663720", Slot = "6")]
		protected override void ICBMIIFPMLP(global::GDKGOJJDLGI<T> CAANMBJGHHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x46636F0", Offset = "0x46628F0", VA = "0x1846636F0")]
		[CompilerGenerated]
		private void DBFGALLFJBF(T LHPJBAGJLHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4663920", Offset = "0x4662B20", VA = "0x184663920")]
		[CompilerGenerated]
		private void NGIKCIODCHE(string IEPGAFBBMGK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private class GLNNGJBCPAD : KDCFGCMFGOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly Action GHCLFMPOHGP;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ELLOHAEAEPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x601070", Offset = "0x600270", VA = "0x180601070", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6270A0", Offset = "0x6262A0", VA = "0x1806270A0")]
		public GLNNGJBCPAD(Action GHCLFMPOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8833C0", VA = "0x1808841C0", Slot = "5")]
		public void EBIMOMABEEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static readonly List<KDCFGCMFGOM> JHLHGCHLBKP;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3835770", Offset = "0x3834970", VA = "0x183835770")]
	public static global::GDKGOJJDLGI<T> HIPBBICOMAB<T>(this global::GDKGOJJDLGI<T> CAANMBJGHHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2166850", Offset = "0x2165A50", VA = "0x182166850")]
	public static void HIPBBICOMAB(Action GHCLFMPOHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x38357E0", Offset = "0x38349E0", VA = "0x1838357E0")]
	private static global::GDKGOJJDLGI<T> IMEHMCCKFAE<T>(global::GDKGOJJDLGI<T> CAANMBJGHHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x21665B0", Offset = "0x21657B0", VA = "0x1821665B0")]
	private static void CGBHIDFMBIH(KDCFGCMFGOM JFCLCLBNHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x21661C0", Offset = "0x21653C0", VA = "0x1821661C0")]
	private static void ANEKGCNNDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x21664E0", Offset = "0x21656E0", VA = "0x1821664E0")]
	private static void CCFJPIPNBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x21667A0", Offset = "0x21659A0", VA = "0x1821667A0")]
	private static void CGOBBJIMDIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class ACOENGLMBIC
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct OLICJOBKIIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public TaskCompletionSource<Scene> HBKFLEBFDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly string KKBNOPPEJCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly LoadSceneMode PGEMEHCMADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly bool JLINIOELJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly CIHEPFKAKNH EFJKGFIDBLG;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x216FC60", Offset = "0x216EE60", VA = "0x18216FC60")]
		public OLICJOBKIIC(TaskCompletionSource<Scene> AOJFIHKLIBC, string KKBNOPPEJCL, LoadSceneMode PGEMEHCMADN, bool JLINIOELJKI, CIHEPFKAKNH EFJKGFIDBLG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct GCKAALAGOAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public CIHEPFKAKNH stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private global::AHNHODFKKCG<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2169810", Offset = "0x2168A10", VA = "0x182169810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2169D70", Offset = "0x2168F70", VA = "0x182169D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct BFIHLEBPGOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x215D660", Offset = "0x215C860", VA = "0x18215D660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct LKDCAABFNBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private OLICJOBKIIC <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x216C040", Offset = "0x216B240", VA = "0x18216C040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class OMBKENNABCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public global::OKHIKHGPKEJ<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public OMBKENNABCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x216FCC0", Offset = "0x216EEC0", VA = "0x18216FCC0")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct KIEPDJOPIFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private OMBKENNABCL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private CIHEPFKAKNH <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private CIHEPFKAKNH <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x216B4B0", Offset = "0x216A6B0", VA = "0x18216B4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x216BCA0", Offset = "0x216AEA0", VA = "0x18216BCA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct BHOLOGAILBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private CIHEPFKAKNH <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private CIHEPFKAKNH <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x215DDB0", Offset = "0x215CFB0", VA = "0x18215DDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x215E4F0", Offset = "0x215D6F0", VA = "0x18215E4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class FMBDFGJFDIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public FMBDFGJFDIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2169500", Offset = "0x2168700", VA = "0x182169500")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class CMOGGGGEBDI : IEnumerator<NABEINJFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NABEINJFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public GGMBIJOCENK onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private NABEINJFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5FF480", Offset = "0x5FE680", VA = "0x1805FF480")]
		[DebuggerHidden]
		public CMOGGGGEBDI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x215F130", Offset = "0x215E330", VA = "0x18215F130", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x215EDF0", Offset = "0x215DFF0", VA = "0x18215EDF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x215F1E0", Offset = "0x215E3E0", VA = "0x18215F1E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x215F0E0", Offset = "0x215E2E0", VA = "0x18215F0E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class MPONEFLCOLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public global::OKHIKHGPKEJ<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public MPONEFLCOLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class BGILNDCPPDH : IEnumerator<NABEINJFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private NABEINJFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public global::OKHIKHGPKEJ<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private MPONEFLCOLD <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private NABEINJFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5FF480", Offset = "0x5FE680", VA = "0x1805FF480")]
		[DebuggerHidden]
		public BGILNDCPPDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x215D950", Offset = "0x215CB50", VA = "0x18215D950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x215DD60", Offset = "0x215CF60", VA = "0x18215DD60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static NOJPGNEJCEO GHNHLNPPKDL;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static AsyncOperation JLKBBCAGBFH;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static NOJPGNEJCEO OJNAIDNBMID;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static string MHFGIGENMBJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static ThreadPriority OJBPEPHCMPF;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static Task FDAPIHOFLAC;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly Queue<OLICJOBKIIC> FNHKNOIBGEM;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Task LEAGBAGBAGP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool HHKPBEPANJN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x215BEF0", Offset = "0x215B0F0", VA = "0x18215BEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool PEKADLFCLJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x215C450", Offset = "0x215B650", VA = "0x18215C450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool EOJEAPHLKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x215CEF0", Offset = "0x215C0F0", VA = "0x18215CEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> FCJIMGBFJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x215D030", Offset = "0x215C230", VA = "0x18215D030")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x215BDF0", Offset = "0x215AFF0", VA = "0x18215BDF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x215CA90", Offset = "0x215BC90", VA = "0x18215CA90")]
	[FJGCJGIINCP(DMLMBCGCBMP.EnteredEditModeNextFrame, 0)]
	private static void FGBMGJOPIPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x215CD20", Offset = "0x215BF20", VA = "0x18215CD20")]
	[AsyncStateMachine(typeof(GCKAALAGOAB))]
	public static Task<Scene> KKHANBLMMLL(string KKBNOPPEJCL, LoadSceneMode PGEMEHCMADN = LoadSceneMode.Single, bool JLINIOELJKI = false, [Optional] CIHEPFKAKNH JKEDDGGOPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x215CC40", Offset = "0x215BE40", VA = "0x18215CC40")]
	[AsyncStateMachine(typeof(BFIHLEBPGOK))]
	private static Task HFBBGKDDNJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x215CB60", Offset = "0x215BD60", VA = "0x18215CB60")]
	[AsyncStateMachine(typeof(LKDCAABFNBO))]
	private static Task GCLBEDJANAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x215C1C0", Offset = "0x215B3C0", VA = "0x18215C1C0")]
	[AsyncStateMachine(typeof(KIEPDJOPIFJ))]
	private static Task<Scene> BMKPAFCOPOJ(string KKBNOPPEJCL, LoadSceneMode PGEMEHCMADN, bool JLINIOELJKI, CIHEPFKAKNH EFJKGFIDBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x215C0A0", Offset = "0x215B2A0", VA = "0x18215C0A0")]
	[AsyncStateMachine(typeof(BHOLOGAILBM))]
	private static Task<Scene> APHKHCNEOOA(CIHEPFKAKNH EFJKGFIDBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x215C920", Offset = "0x215BB20", VA = "0x18215C920")]
	public static global::GDKGOJJDLGI<Scene> FDEBHCKILIB(string KKBNOPPEJCL, LoadSceneMode PGEMEHCMADN = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x215C500", Offset = "0x215B700", VA = "0x18215C500")]
	public static NOJPGNEJCEO EMCLPALJCLE(string KKBNOPPEJCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x215CFA0", Offset = "0x215C1A0", VA = "0x18215CFA0")]
	[IteratorStateMachine(typeof(CMOGGGGEBDI))]
	private static IEnumerator<NABEINJFOOA> MFEHNJFHHKA(string KKBNOPPEJCL, GGMBIJOCENK GADMGJIPLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x215CE60", Offset = "0x215C060", VA = "0x18215CE60")]
	[IteratorStateMachine(typeof(BGILNDCPPDH))]
	private static IEnumerator<NABEINJFOOA> LENNDNGELLG(string KKBNOPPEJCL, LoadSceneMode PGEMEHCMADN, global::OKHIKHGPKEJ<Scene> GADMGJIPLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x215C300", Offset = "0x215B500", VA = "0x18215C300")]
	public static bool BOLDIGKAPDM(out string DPADBPCOLNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class KNACOPBKDBN
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x216BCF0", Offset = "0x216AEF0", VA = "0x18216BCF0")]
	public static IDisposable EKCPBBGFMAG(this EGHAAFLIMGB JAEDJGBMHAP, float KEJOEBMBGND, Action<float> JGHKHHEDNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x216BDF0", Offset = "0x216AFF0", VA = "0x18216BDF0")]
	public static IDisposable OEANOFPOOOK(this EGHAAFLIMGB JAEDJGBMHAP, Action<float> JGHKHHEDNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x216BD70", Offset = "0x216AF70", VA = "0x18216BD70")]
	public static IDisposable HAPDKFFKNOB(this EGHAAFLIMGB JAEDJGBMHAP, Action<float> JGHKHHEDNNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class PBKBPKBKAJE
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x21701A0", Offset = "0x216F3A0", VA = "0x1821701A0")]
	public static IDisposable DELMKMDNGEL(this MonoBehaviour OHLDDLIMNHB, Action JGHKHHEDNNH, BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2170120", Offset = "0x216F320", VA = "0x182170120")]
	public static IDisposable DELMKMDNGEL(this MonoBehaviour OHLDDLIMNHB, Action<float> JGHKHHEDNNH, BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2170440", Offset = "0x216F640", VA = "0x182170440")]
	public static IDisposable HGBIKKNOCLO(this MonoBehaviour OHLDDLIMNHB, Action JGHKHHEDNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x21704B0", Offset = "0x216F6B0", VA = "0x1821704B0")]
	public static IDisposable HHDAFANMJKG(this MonoBehaviour OHLDDLIMNHB, Action JGHKHHEDNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2170220", Offset = "0x216F420", VA = "0x182170220")]
	public static IDisposable DLPAEGMPPEP(this MonoBehaviour OHLDDLIMNHB, Action JGHKHHEDNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x216FEE0", Offset = "0x216F0E0", VA = "0x18216FEE0")]
	public static IDisposable AFPAPMEINNO(this MonoBehaviour OHLDDLIMNHB, Action JGHKHHEDNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2170520", Offset = "0x216F720", VA = "0x182170520")]
	public static IDisposable JBCNABGOKBC(this MonoBehaviour OHLDDLIMNHB, Action JGHKHHEDNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x21707D0", Offset = "0x216F9D0", VA = "0x1821707D0")]
	public static IDisposable PFGEJGGPFIP(this MonoBehaviour OHLDDLIMNHB, float KEJOEBMBGND, Action<float> JGHKHHEDNNH, BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH, bool LPBJDNDNGOF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x216FFE0", Offset = "0x216F1E0", VA = "0x18216FFE0")]
	public static IDisposable CFHMIFGANNJ(this MonoBehaviour OHLDDLIMNHB, float KEJOEBMBGND, Action<float> JGHKHHEDNNH, bool LPBJDNDNGOF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2170740", Offset = "0x216F940", VA = "0x182170740")]
	public static IDisposable PBKJMAHDCCF(this MonoBehaviour OHLDDLIMNHB, Action<float> JGHKHHEDNNH, bool LPBJDNDNGOF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x21706B0", Offset = "0x216F8B0", VA = "0x1821706B0")]
	public static IDisposable MLPFIOIIEEA(this MonoBehaviour OHLDDLIMNHB, Action<float> JGHKHHEDNNH, bool LPBJDNDNGOF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x21703B0", Offset = "0x216F5B0", VA = "0x1821703B0")]
	public static IDisposable GFADOJDPKJF(this MonoBehaviour OHLDDLIMNHB, Action<float> JGHKHHEDNNH, bool LPBJDNDNGOF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2170290", Offset = "0x216F490", VA = "0x182170290")]
	public static IDisposable EPBIMMMDMMC(this MonoBehaviour OHLDDLIMNHB, Action<float> JGHKHHEDNNH, bool LPBJDNDNGOF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x216FF50", Offset = "0x216F150", VA = "0x18216FF50")]
	public static IDisposable CAGEPOPIKOM(this MonoBehaviour OHLDDLIMNHB, Action<float> JGHKHHEDNNH, bool LPBJDNDNGOF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2170590", Offset = "0x216F790", VA = "0x182170590")]
	public static IDisposable LBAADPPIDOJ(this MonoBehaviour OHLDDLIMNHB, Action<float> JGHKHHEDNNH, bool LPBJDNDNGOF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2170320", Offset = "0x216F520", VA = "0x182170320")]
	public static IDisposable FBGOLCGJDDG(this MonoBehaviour OHLDDLIMNHB, Action<float> JGHKHHEDNNH, bool LPBJDNDNGOF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2170080", Offset = "0x216F280", VA = "0x182170080")]
	public static IDisposable CKHBFBEPGFN(this MonoBehaviour OHLDDLIMNHB, float KEJOEBMBGND, Action<float> JGHKHHEDNNH, bool LPBJDNDNGOF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2170620", Offset = "0x216F820", VA = "0x182170620")]
	public static IDisposable LHNLMBCEGHI(this MonoBehaviour OHLDDLIMNHB, Action<float> JGHKHHEDNNH, bool LPBJDNDNGOF = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class MCMGKPOIHPJ
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class EIOHDNINMAE : IEnumerator<NABEINJFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private NABEINJFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public BKLGPMMCHAJ.MDHDNHBJCBN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private OPMIJNHMOIE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private NABEINJFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5FF480", Offset = "0x5FE680", VA = "0x1805FF480")]
		[DebuggerHidden]
		public EIOHDNINMAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2167A80", Offset = "0x2166C80", VA = "0x182167A80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2167B40", Offset = "0x2166D40", VA = "0x182167B40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class HMOCPBIHEBO : IEnumerator<NABEINJFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private NABEINJFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public BKLGPMMCHAJ.MDHDNHBJCBN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private OPMIJNHMOIE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private NABEINJFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5FF480", Offset = "0x5FE680", VA = "0x1805FF480")]
		[DebuggerHidden]
		public HMOCPBIHEBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x216A350", Offset = "0x2169550", VA = "0x18216A350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x216A430", Offset = "0x2169630", VA = "0x18216A430", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x216CAC0", Offset = "0x216BCC0", VA = "0x18216CAC0")]
	public static NNDKFCLIIOJ DELMKMDNGEL(Action JGHKHHEDNNH, BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x216CA00", Offset = "0x216BC00", VA = "0x18216CA00")]
	public static NNDKFCLIIOJ DELMKMDNGEL(Behaviour JAEDJGBMHAP, Action JGHKHHEDNNH, BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x216C8F0", Offset = "0x216BAF0", VA = "0x18216C8F0")]
	public static NNDKFCLIIOJ DELMKMDNGEL(Behaviour JAEDJGBMHAP, Action<float> JGHKHHEDNNH, BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x216CC60", Offset = "0x216BE60", VA = "0x18216CC60")]
	[IteratorStateMachine(typeof(EIOHDNINMAE))]
	private static IEnumerator<NABEINJFOOA> FMCAFFMMDMB(BKLGPMMCHAJ.MDHDNHBJCBN ILAADJAKLMF, Action JGHKHHEDNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x216CBE0", Offset = "0x216BDE0", VA = "0x18216CBE0")]
	[IteratorStateMachine(typeof(HMOCPBIHEBO))]
	private static IEnumerator<NABEINJFOOA> FMCAFFMMDMB(BKLGPMMCHAJ.MDHDNHBJCBN ILAADJAKLMF, Action<float> JGHKHHEDNNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LOGEJOEIHMN
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class IPODBINKNEE : IEnumerator<NABEINJFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private NABEINJFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public NDCOHBNKKFJ schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public BKLGPMMCHAJ.MDHDNHBJCBN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private KJDOGAEJDAL <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private NABEINJFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5FF480", Offset = "0x5FE680", VA = "0x1805FF480")]
		[DebuggerHidden]
		public IPODBINKNEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x216ABA0", Offset = "0x2169DA0", VA = "0x18216ABA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x216ACD0", Offset = "0x2169ED0", VA = "0x18216ACD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x216C620", Offset = "0x216B820", VA = "0x18216C620")]
	public static NNDKFCLIIOJ DELMKMDNGEL(MonoBehaviour OHLDDLIMNHB, float KEJOEBMBGND, Action<float> JGHKHHEDNNH, BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH, bool LPBJDNDNGOF = true, [Optional] ABBNIDCAHHA MKMDIENHFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x216C7E0", Offset = "0x216B9E0", VA = "0x18216C7E0")]
	public static NNDKFCLIIOJ MAJBACNEMEJ(EGHAAFLIMGB JAEDJGBMHAP, float KEJOEBMBGND, Action<float> JGHKHHEDNNH, BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH, bool LPBJDNDNGOF = true, [Optional] ABBNIDCAHHA MKMDIENHFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x216C730", Offset = "0x216B930", VA = "0x18216C730")]
	[IteratorStateMachine(typeof(IPODBINKNEE))]
	private static IEnumerator<NABEINJFOOA> FMCAFFMMDMB(NDCOHBNKKFJ PMOHEFLOOJB, float KEJOEBMBGND, BKLGPMMCHAJ.MDHDNHBJCBN ILAADJAKLMF, Action<float> JGHKHHEDNNH, bool LPBJDNDNGOF = true, [Optional] ABBNIDCAHHA MKMDIENHFFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class KDFKLHDFGGG
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class LLGABMDKBGE : IEnumerator<NABEINJFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private NABEINJFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public BKLGPMMCHAJ.MDHDNHBJCBN queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private NABEINJFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FF480", Offset = "0x5FE680", VA = "0x1805FF480")]
		[DebuggerHidden]
		public LLGABMDKBGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x216C520", Offset = "0x216B720", VA = "0x18216C520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x216C5D0", Offset = "0x216B7D0", VA = "0x18216C5D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x216B320", Offset = "0x216A520", VA = "0x18216B320")]
	[IteratorStateMachine(typeof(LLGABMDKBGE))]
	private static IEnumerator<NABEINJFOOA> DJLPJLIJGIC(BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH, Func<bool> GJGNCBMODHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x216B3A0", Offset = "0x216A5A0", VA = "0x18216B3A0")]
	public static NNDKFCLIIOJ HPEIHIHHHDK(this MonoBehaviour OHLDDLIMNHB, Func<bool> GJGNCBMODHD, BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH = BKLGPMMCHAJ.MDHDNHBJCBN.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class ABLMBDGLIDM
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class DCDGAIHBDGE : IEnumerator<NABEINJFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private NABEINJFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public BKLGPMMCHAJ.MDHDNHBJCBN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private NABEINJFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5FF480", Offset = "0x5FE680", VA = "0x1805FF480")]
		[DebuggerHidden]
		public DCDGAIHBDGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2162500", Offset = "0x2161700", VA = "0x182162500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x21625C0", Offset = "0x21617C0", VA = "0x1821625C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x215B930", Offset = "0x215AB30", VA = "0x18215B930")]
	[IteratorStateMachine(typeof(DCDGAIHBDGE))]
	private static IEnumerator<NABEINJFOOA> CKBIKBJNLFF(float PKLDFKJJOHL, BKLGPMMCHAJ.MDHDNHBJCBN ILAADJAKLMF, Action EMDDKFAAHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x215BAF0", Offset = "0x215ACF0", VA = "0x18215BAF0")]
	public static NNDKFCLIIOJ GNEBLFFLNCF(this MonoBehaviour OHLDDLIMNHB, float PKLDFKJJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x215BBB0", Offset = "0x215ADB0", VA = "0x18215BBB0")]
	public static NNDKFCLIIOJ KJMOMOBAMDF(this MonoBehaviour OHLDDLIMNHB, Action EMDDKFAAHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x215BD90", Offset = "0x215AF90", VA = "0x18215BD90")]
	public static NNDKFCLIIOJ OCINOAOOLJH(this MonoBehaviour OHLDDLIMNHB, Action EMDDKFAAHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x215BDC0", Offset = "0x215AFC0", VA = "0x18215BDC0")]
	public static NNDKFCLIIOJ OHJHLPIFKOA(this MonoBehaviour OHLDDLIMNHB, Action EMDDKFAAHLO, [Optional] ABBNIDCAHHA MKMDIENHFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x215B9F0", Offset = "0x215ABF0", VA = "0x18215B9F0")]
	public static NNDKFCLIIOJ FDMOJOFNKEN(this MonoBehaviour OHLDDLIMNHB, Action EMDDKFAAHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x215BD60", Offset = "0x215AF60", VA = "0x18215BD60")]
	public static NNDKFCLIIOJ NJGDOMOEGGN(this MonoBehaviour OHLDDLIMNHB, Action EMDDKFAAHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x215B9C0", Offset = "0x215ABC0", VA = "0x18215B9C0")]
	public static NNDKFCLIIOJ ELEGCPNNALK(this MonoBehaviour OHLDDLIMNHB, Action EMDDKFAAHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x215B790", Offset = "0x215A990", VA = "0x18215B790")]
	private static NNDKFCLIIOJ AEOMGHKDMPI(MonoBehaviour OHLDDLIMNHB, BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH, Action EMDDKFAAHLO, [Optional] ABBNIDCAHHA MKMDIENHFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x215BBD0", Offset = "0x215ADD0", VA = "0x18215BBD0")]
	public static NNDKFCLIIOJ LEKHACKHBIG(this MonoBehaviour OHLDDLIMNHB, float DFOOIHAIPAN, Action EMDDKFAAHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x215BA20", Offset = "0x215AC20", VA = "0x18215BA20")]
	public static NNDKFCLIIOJ GMDNLJMHJHL(this MonoBehaviour OHLDDLIMNHB, float DFOOIHAIPAN, Action EMDDKFAAHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x215BC90", Offset = "0x215AE90", VA = "0x18215BC90")]
	public static NNDKFCLIIOJ MLCPOFDKNPI(this MonoBehaviour OHLDDLIMNHB, float DFOOIHAIPAN, Action EMDDKFAAHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x215B860", Offset = "0x215AA60", VA = "0x18215B860")]
	public static NNDKFCLIIOJ BHHAEMLOKLK(this MonoBehaviour OHLDDLIMNHB, float DFOOIHAIPAN, Action EMDDKFAAHLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class BBIEEECJILF : ILCDKGHECFI
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class BLJHOLHPFDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public BBIEEECJILF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public BLJHOLHPFDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x215E710", Offset = "0x215D910", VA = "0x18215E710")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class GPKCAKOIJJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public BBIEEECJILF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public GPKCAKOIJJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x215E710", Offset = "0x215D910", VA = "0x18215E710")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly float GALBCPKGAGF;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x215D610", Offset = "0x215C810", VA = "0x18215D610")]
	public BBIEEECJILF(Behaviour JAEDJGBMHAP, float GALBCPKGAGF, [Optional] Action FHKKOGMHOFL, [Optional] ABBNIDCAHHA MKMDIENHFFM, [Optional] NDCOHBNKKFJ PMOHEFLOOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x215D530", Offset = "0x215C730", VA = "0x18215D530", Slot = "9")]
	protected override bool NCKMNNDBFDG(Action GHCLFMPOHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x215D450", Offset = "0x215C650", VA = "0x18215D450", Slot = "10")]
	protected override bool CMIOFBALDII(Action GHCLFMPOHGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface HOHGCFILEKK
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool BGGFPOPMCOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JGHHCIHBLIE;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FGGGAMPEBMI(bool JCMDBKNCKJK = false);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FGGGAMPEBMI(Action GHCLFMPOHGP, bool JCMDBKNCKJK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public abstract class ILCDKGHECFI : HOHGCFILEKK
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class JEFMBFKPJGB : IEnumerator<NABEINJFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private NABEINJFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public ILCDKGHECFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private NABEINJFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5FF480", Offset = "0x5FE680", VA = "0x1805FF480")]
		[DebuggerHidden]
		public JEFMBFKPJGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x216AD20", Offset = "0x2169F20", VA = "0x18216AD20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x216ADF0", Offset = "0x2169FF0", VA = "0x18216ADF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Behaviour JAEDJGBMHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Action FHKKOGMHOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private HDKDEMHKIGC OIEBFGMHKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly ABBNIDCAHHA MKMDIENHFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	protected readonly NDCOHBNKKFJ PMOHEFLOOJB;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BGGFPOPMCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xFA7DC0", Offset = "0xFA6FC0", VA = "0x180FA7DC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JGHHCIHBLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x216A940", Offset = "0x2169B40", VA = "0x18216A940", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x216A5A0", Offset = "0x21697A0", VA = "0x18216A5A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x216AAB0", Offset = "0x2169CB0", VA = "0x18216AAB0")]
	protected ILCDKGHECFI(Behaviour JAEDJGBMHAP, [Optional] Action FHKKOGMHOFL, [Optional] ABBNIDCAHHA MKMDIENHFFM, [Optional] NDCOHBNKKFJ PMOHEFLOOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x216A8E0", Offset = "0x2169AE0", VA = "0x18216A8E0", Slot = "7")]
	public bool FGGGAMPEBMI(bool JCMDBKNCKJK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x216A890", Offset = "0x2169A90", VA = "0x18216A890", Slot = "8")]
	public bool FGGGAMPEBMI(Action GHCLFMPOHGP, bool JCMDBKNCKJK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool NCKMNNDBFDG(Action GHCLFMPOHGP);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool CMIOFBALDII(Action GHCLFMPOHGP);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x216A9E0", Offset = "0x2169BE0", VA = "0x18216A9E0")]
	protected void GNAHAEBDCPF(Action GHCLFMPOHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x216A640", Offset = "0x2169840", VA = "0x18216A640")]
	protected NOJPGNEJCEO BCOECINFPGC(float ELNGDGGHACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x216AA00", Offset = "0x2169C00", VA = "0x18216AA00")]
	private void NOELAJOHPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x216A810", Offset = "0x2169A10", VA = "0x18216A810")]
	[IteratorStateMachine(typeof(JEFMBFKPJGB))]
	private IEnumerator<NABEINJFOOA> EMOOGBAFDDE(float ELNGDGGHACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x216AA70", Offset = "0x2169C70", VA = "0x18216AA70")]
	[CompilerGenerated]
	private void OHBMOLMNDPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class KDCDGIEIJHP : ILCDKGHECFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly float NHOJFKHMNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly int LBPFDBMNJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly float ABEFNNOMKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly float[] PBKMMOGPAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int OIEJGAAIPCF;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x216B0F0", Offset = "0x216A2F0", VA = "0x18216B0F0")]
	public KDCDGIEIJHP(Behaviour JAEDJGBMHAP, float ADKDKHCANLK, int LBPFDBMNJJN, [Optional] Action FHKKOGMHOFL, float ABEFNNOMKJL = 0f, [Optional] ABBNIDCAHHA MKMDIENHFFM, [Optional] NDCOHBNKKFJ PMOHEFLOOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "9")]
	protected override bool NCKMNNDBFDG(Action GHCLFMPOHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x216AE40", Offset = "0x216A040", VA = "0x18216AE40", Slot = "10")]
	protected override bool CMIOFBALDII(Action GHCLFMPOHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x216B060", Offset = "0x216A260", VA = "0x18216B060")]
	private void MDABFMDCJMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class NAMBEKIDKIO : ILCDKGHECFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly float GALBCPKGAGF;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x215D610", Offset = "0x215C810", VA = "0x18215D610")]
	public NAMBEKIDKIO(Behaviour JAEDJGBMHAP, float GALBCPKGAGF, [Optional] Action FHKKOGMHOFL, [Optional] ABBNIDCAHHA MKMDIENHFFM, [Optional] NDCOHBNKKFJ PMOHEFLOOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "9")]
	protected override bool NCKMNNDBFDG(Action GHCLFMPOHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x216D100", Offset = "0x216C300", VA = "0x18216D100", Slot = "10")]
	protected override bool CMIOFBALDII(Action GHCLFMPOHGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class NJAJDIGLLGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class DOFOINGNOAC : IEnumerator<NABEINJFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private NABEINJFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private NABEINJFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5FF480", Offset = "0x5FE680", VA = "0x1805FF480")]
		[DebuggerHidden]
		public DOFOINGNOAC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x21660D0", Offset = "0x21652D0", VA = "0x1821660D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2166170", Offset = "0x2165370", VA = "0x182166170", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NNDKFCLIIOJ PLNDHILCMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private EGHAAFLIMGB JAEDJGBMHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Action<float> NHKENLPGAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private float PJBNCFMFKNP;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x216D660", Offset = "0x216C860", VA = "0x18216D660")]
	public NJAJDIGLLGJ(EGHAAFLIMGB JAEDJGBMHAP, float KEJOEBMBGND, Action<float> JGHKHHEDNNH, BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x216D360", Offset = "0x216C560", VA = "0x18216D360")]
	private void MDGHNIPAAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x216D1B0", Offset = "0x216C3B0", VA = "0x18216D1B0")]
	private void CHPOHFBFAHP(string IEPGAFBBMGK, Action NMMBCMKACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x216D140", Offset = "0x216C340", VA = "0x18216D140")]
	[IteratorStateMachine(typeof(DOFOINGNOAC))]
	private IEnumerator<NABEINJFOOA> ACKOBEEKGNF(Action NMMBCMKACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x216D300", Offset = "0x216C500", VA = "0x18216D300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x216D4E0", Offset = "0x216C6E0", VA = "0x18216D4E0")]
	[CompilerGenerated]
	private void OAJMKHJPHCG(string MAMHFFLAIIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class DECJHCOCIIK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class HGBNPDJKEKH : IEnumerator<NABEINJFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private NABEINJFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private NABEINJFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5FF480", Offset = "0x5FE680", VA = "0x1805FF480")]
		[DebuggerHidden]
		public HGBNPDJKEKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x216A260", Offset = "0x2169460", VA = "0x18216A260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x216A300", Offset = "0x2169500", VA = "0x18216A300", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NNDKFCLIIOJ PLNDHILCMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private MonoBehaviour OHLDDLIMNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Action JGHKHHEDNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private Action<float> NHKENLPGAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private float PJBNCFMFKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool LPBJDNDNGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly ABBNIDCAHHA MKMDIENHFFM;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2163BD0", Offset = "0x2162DD0", VA = "0x182163BD0")]
	public DECJHCOCIIK(MonoBehaviour OHLDDLIMNHB, Action JGHKHHEDNNH, BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH, [Optional] ABBNIDCAHHA MKMDIENHFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x21639C0", Offset = "0x2162BC0", VA = "0x1821639C0")]
	public DECJHCOCIIK(MonoBehaviour OHLDDLIMNHB, Action<float> JGHKHHEDNNH, BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH, [Optional] ABBNIDCAHHA MKMDIENHFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2163790", Offset = "0x2162990", VA = "0x182163790")]
	public DECJHCOCIIK(MonoBehaviour OHLDDLIMNHB, float KEJOEBMBGND, Action<float> JGHKHHEDNNH, BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH, bool LPBJDNDNGOF = true, [Optional] ABBNIDCAHHA MKMDIENHFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x21631C0", Offset = "0x21623C0", VA = "0x1821631C0")]
	private void DELMKMDNGEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2163600", Offset = "0x2162800", VA = "0x182163600")]
	private void PCCHCEFBAHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2163470", Offset = "0x2162670", VA = "0x182163470")]
	private void MDGHNIPAAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x21630B0", Offset = "0x21622B0", VA = "0x1821630B0")]
	private void CHPOHFBFAHP(string IEPGAFBBMGK, Action NMMBCMKACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2162FC0", Offset = "0x21621C0", VA = "0x182162FC0")]
	[IteratorStateMachine(typeof(HGBNPDJKEKH))]
	private IEnumerator<NABEINJFOOA> ACKOBEEKGNF(Action NMMBCMKACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2163310", Offset = "0x2162510", VA = "0x182163310", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2163370", Offset = "0x2162570", VA = "0x182163370")]
	[CompilerGenerated]
	private void LPKELNFICIK(string MAMHFFLAIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2163030", Offset = "0x2162230", VA = "0x182163030")]
	[CompilerGenerated]
	private void AODHGBEEFNM(string MAMHFFLAIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x21633F0", Offset = "0x21625F0", VA = "0x1821633F0")]
	[CompilerGenerated]
	private void MDGDBOEBHPD(string MAMHFFLAIIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[Flags]
internal enum AOMMINGCBNJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class COEGGAGKJPH : NDCOHBNKKFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public float NJHGGKLNANI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x215F2C0", Offset = "0x215E4C0", VA = "0x18215F2C0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float BJMJMDDCALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x215F230", Offset = "0x215E430", VA = "0x18215F230", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public double CNEPENFJODI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x215F2A0", Offset = "0x215E4A0", VA = "0x18215F2A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x215F240", Offset = "0x215E440", VA = "0x18215F240")]
	[EEPNDFMGFKJ(CPDKPFACMJL.None)]
	private static void HLFDIDCONPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	[Preserve]
	internal COEGGAGKJPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal interface COHBBIPPACH
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMLNNFEKABH(string JFLKGPEABBP);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPLFDOIGKED();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal interface BEGCDPJOECL
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	string JPGOKIEGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool LOGLDKKHDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool DOLGHDEKIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal class OIGEPPOPDIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public DEKNJOMIBAL FBCEHMMMHAK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int CCIFACONDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x62D550", Offset = "0x62C750", VA = "0x18062D550", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6EDC00", Offset = "0x6ECE00", VA = "0x1806EDC00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x216F930", Offset = "0x216EB30", VA = "0x18216F930")]
	public static NABEINJFOOA HMAABJFIDCG(IEnumerator<NABEINJFOOA> NAGKGIFJHDE, ABGKJOHBONH JFKKPGJCCBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x216F850", Offset = "0x216EA50", VA = "0x18216F850")]
	public NABEINJFOOA HMAABJFIDCG(ABGKJOHBONH[] LHIHANACGCI, IEnumerator<NABEINJFOOA>[] PHHECPPCOIG, NABEINJFOOA[] IILBDPHPNID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x216FA90", Offset = "0x216EC90", VA = "0x18216FA90")]
	public void JFHOBFHHGFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x216FB90", Offset = "0x216ED90", VA = "0x18216FB90")]
	public void LGOIFBDOKEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x216FAC0", Offset = "0x216ECC0", VA = "0x18216FAC0")]
	public void LDHIAAMCPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x216FA90", Offset = "0x216EC90", VA = "0x18216FA90")]
	public void OHLJMIHNBPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public OIGEPPOPDIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class DEKNJOMIBAL
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct HMGHMGBIPMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public OIGEPPOPDIG EBHPEMGJNMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public EGHAAFLIMGB JDPIBAJKPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public ABGKJOHBONH HHHDEAAGGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public IEnumerator<NABEINJFOOA> LKOOBHINICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public NABEINJFOOA GEIGHOCMKHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public AOMMINGCBNJ BLEBCBMPEGB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct OJCGLPELEJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public BKLGPMMCHAJ.MDHDNHBJCBN JDGAPMGCPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public List<HMGHMGBIPMA> HKGIKACOFOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class CEAPJEFEDKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public DEKNJOMIBAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public EGHAAFLIMGB context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public OIGEPPOPDIG routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public AOMMINGCBNJ coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public ABGKJOHBONH promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public NABEINJFOOA currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public IEnumerator<NABEINJFOOA> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public CEAPJEFEDKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x215E740", Offset = "0x215D940", VA = "0x18215E740")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class EHHPMJFLFNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public OIGEPPOPDIG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public DEKNJOMIBAL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public EHHPMJFLFNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2166F90", Offset = "0x2166190", VA = "0x182166F90")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class MFNFLEBGGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public OIGEPPOPDIG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public DEKNJOMIBAL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public MFNFLEBGGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x216CCE0", Offset = "0x216BEE0", VA = "0x18216CCE0")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class LCHEPOGLKIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public OIGEPPOPDIG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public DEKNJOMIBAL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public LCHEPOGLKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x216C000", Offset = "0x216B200", VA = "0x18216C000")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const AOMMINGCBNJ EBGPEBPFMBG = AOMMINGCBNJ.Cancelled | AOMMINGCBNJ.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool[] MMKIBCPKABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<AOMMINGCBNJ> INJBMBBKFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float> GNBCEOFKEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<int> KODPNCMABKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> AFBBALOGHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private NativeArray<int> PGLCNODALID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private NativeArray<int> GPLCHMPEIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private NativeArray<int> FCDNEKLLMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private OIGEPPOPDIG[] INJCKLBCOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private ABGKJOHBONH[] LHIHANACGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private EGHAAFLIMGB[] GMOFIGKHGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private IEnumerator<NABEINJFOOA>[] LBLBOPPDBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NABEINJFOOA[] BNHNMAHGLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int JJHNBIKPDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int GOCCOAPEHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly int LJJGEKPHHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private float GKGCFCMIGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private EHBPJLBMLCF FCCEMEBPNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private JobHandle BGGHFPMKEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private List<OIGEPPOPDIG> FCPPLILEGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private bool LKPBIGBEHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private List<Action> NIJLOPFKEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private List<Action> IALPEFJGAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private bool GPNCGIEDDKK;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public OJCGLPELEJF[] MJGBEGKMHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7E4630", Offset = "0x7E3830", VA = "0x1807E4630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2165060", Offset = "0x2164260", VA = "0x182165060")]
	private static int DIOBJIEFFFP(BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2165B70", Offset = "0x2164D70", VA = "0x182165B70")]
	public DEKNJOMIBAL(BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x21645C0", Offset = "0x21637C0", VA = "0x1821645C0")]
	private void BMICAPCOJBJ(ref int FDHCPNEGBJH, int MNNBHHNGDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x21656A0", Offset = "0x21648A0", VA = "0x1821656A0")]
	public void MKHLANNFONB(EGHAAFLIMGB JAEDJGBMHAP, NABEINJFOOA ODLCBAHNDAG, IEnumerator<NABEINJFOOA> NAGKGIFJHDE, ABGKJOHBONH JFKKPGJCCBD, [Optional] OIGEPPOPDIG GMDIALAECDC, AOMMINGCBNJ CKNBBJINOIL = AOMMINGCBNJ.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x21658C0", Offset = "0x2164AC0", VA = "0x1821658C0")]
	public void OANFOENKONO(IEnumerable<HMGHMGBIPMA> ICBFEAPIHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x21649F0", Offset = "0x2163BF0", VA = "0x1821649F0")]
	private HMGHMGBIPMA CHDDDMMDOOK(int GDGBOBMLIOE)
	{
		return default(HMGHMGBIPMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x21651F0", Offset = "0x21643F0", VA = "0x1821651F0")]
	private void FHPOLICNOBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x45506C0", Offset = "0x454F8C0", VA = "0x1845506C0")]
	private static void KCHKBJMDLFF<T>(int GDGBOBMLIOE, T[] MPMIFBBPNME, int DFCIFDODMGE, [Optional] T DKBPNPCPOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x45506A0", Offset = "0x454F8A0", VA = "0x1845506A0")]
	private static void KCHKBJMDLFF<T>(int GDGBOBMLIOE, NativeArray<T> MPMIFBBPNME, int DFCIFDODMGE, [Optional] T DKBPNPCPOIN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2164750", Offset = "0x2163950", VA = "0x182164750")]
	private void CBIDOOAEPEG(IEnumerable<HMGHMGBIPMA> ICBFEAPIHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2164240", Offset = "0x2163440", VA = "0x182164240")]
	private void AOELHLKOCIJ(HMGHMGBIPMA PCBBJDMDJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2164300", Offset = "0x2163500", VA = "0x182164300")]
	private LDEIIDPPFEI BFFBFFAJBJP(int COHLKEIAFCD)
	{
		return default(LDEIIDPPFEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2164E70", Offset = "0x2164070", VA = "0x182164E70")]
	public void CIMOHPEOBLN(float DPNNMDMALCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2165170", Offset = "0x2164370", VA = "0x182165170")]
	private void FAHDLBGEOMF(Action PJIOBOBOEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2165620", Offset = "0x2164820", VA = "0x182165620")]
	private void IGOPMELFFKH(Action PJIOBOBOEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2163DA0", Offset = "0x2162FA0", VA = "0x182163DA0")]
	public void AKJDEMKMHCE(float DPNNMDMALCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2165090", Offset = "0x2164290", VA = "0x182165090")]
	public void DIPAICNNLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2165AB0", Offset = "0x2164CB0", VA = "0x182165AB0")]
	public void OHLJMIHNBPN(OIGEPPOPDIG DACNIDOBJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2165560", Offset = "0x2164760", VA = "0x182165560")]
	public void HDINKKPFLJF(OIGEPPOPDIG DACNIDOBJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2165800", Offset = "0x2164A00", VA = "0x182165800")]
	public void NDGPMKFMJNL(OIGEPPOPDIG DACNIDOBJEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class HDBILIHANLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static readonly HDBILIHANLA NPKBEJHDJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly Action LODABMOCHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool ODHDMLLLNOE;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6270A0", Offset = "0x6262A0", VA = "0x1806270A0")]
	public HDBILIHANLA(Action LODABMOCHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x216A160", Offset = "0x2169360", VA = "0x18216A160", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface CGMMPOCCPNB<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	T MDDADGNJOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable HHJFELCHFOC(UnityEngine.Object JAEDJGBMHAP, Action<T> FPMNNIEIKNO);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface DLENCDFOBAL<T> : global::CGMMPOCCPNB<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	new T MDDADGNJOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class JCFKNGJDMLA<T> : global::DLENCDFOBAL<T>, global::CGMMPOCCPNB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class EMPLKGFGACJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public global::JCFKNGJDMLA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public global::PJLKDAAMBAL<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public EMPLKGFGACJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x46AA6F0", Offset = "0x46A98F0", VA = "0x1846AA6F0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static GameObject DOMPLCHEAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly List<global::PJLKDAAMBAL<UnityEngine.Object, Action<T>>> MEOHDKEGFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private T PCHJAOGLPAP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public T MDDADGNJOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D50", Offset = "0x7D0F50", VA = "0x1807D1D50", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x46B0680", Offset = "0x46AF880", VA = "0x1846B0680", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x46B02B0", Offset = "0x46AF4B0", VA = "0x1846B02B0")]
	private static bool EFNPOOOEDBO(T PJIOBOBOEGF, T KLGGEDCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x46B0DC0", Offset = "0x46AFFC0", VA = "0x1846B0DC0")]
	public JCFKNGJDMLA(T FONCBBOGJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x46B0340", Offset = "0x46AF540", VA = "0x1846B0340", Slot = "6")]
	public IDisposable HHJFELCHFOC(UnityEngine.Object JAEDJGBMHAP, Action<T> FPMNNIEIKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x46B06E0", Offset = "0x46AF8E0", VA = "0x1846B06E0")]
	private void NFBKEKKHCED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class MJJGEFNELEI : OAFKFCPHEAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly ABBNIDCAHHA MKMDIENHFFM;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x216CDC0", Offset = "0x216BFC0", VA = "0x18216CDC0")]
	[EEPNDFMGFKJ(CPDKPFACMJL.None)]
	private static void HLFDIDCONPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6270A0", Offset = "0x6262A0", VA = "0x1806270A0")]
	[Preserve]
	internal MJJGEFNELEI([AHKDIAMPNOO(null)] ABBNIDCAHHA MKMDIENHFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x216CD20", Offset = "0x216BF20", VA = "0x18216CD20", Slot = "4")]
	public IDisposable CFHMIFGANNJ(float KEJOEBMBGND, Action<float> ELMGCHGCEJD, bool LPBJDNDNGOF = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[BurstCompile]
internal struct EHBPJLBMLCF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	[ReadOnly]
	public float MACNLAHHNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	[ReadOnly]
	public int AGFJPFKKILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NativeArray<int> FDPBINEFLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private NativeArray<int> ICGAJKBFOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private NativeArray<int> LGOJKHPHDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	[ReadOnly]
	public NativeArray<AOMMINGCBNJ> DABLPFIOABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	[ReadOnly]
	public NativeArray<float> FGIINNBMDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	[WriteOnly]
	public NativeArray<int> PGLCNODALID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	[WriteOnly]
	public NativeArray<int> KODPNCMABKP;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2166A00", Offset = "0x2165C00", VA = "0x182166A00")]
	public static EHBPJLBMLCF CNOGLGNGFED(int KPCJNFHKGDP, float DPNNMDMALCH, NativeArray<AOMMINGCBNJ> PAIFDBABKDA, NativeArray<float> DONPLOMODIG, NativeArray<int> BHAGPCOBHGI, NativeArray<int> FBBJGKKMLKO, NativeArray<int> INNJNFALCKO, NativeArray<int> ICGAJKBFOIA, NativeArray<int> LGOJKHPHDBG)
	{
		return default(EHBPJLBMLCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2166AD0", Offset = "0x2165CD0", VA = "0x182166AD0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2166F50", Offset = "0x2166150", VA = "0x182166F50")]
	private bool NIOJFBGINHI(int MJNAIOAAGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2166C20", Offset = "0x2165E20", VA = "0x182166C20")]
	private void KGHEEOAMDGN(NativeArray<int> BKFKBDEBILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2166BB0", Offset = "0x2165DB0", VA = "0x182166BB0")]
	private int JDFOHJEJBHD(int NMCMJHDGJNH, int NGGINHJAHMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2166C50", Offset = "0x2165E50", VA = "0x182166C50")]
	private void MECNJCPFPGK(NativeArray<int> BKFKBDEBILB, int CKJEMFLBEEF, int AANJMHACHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2166D20", Offset = "0x2165F20", VA = "0x182166D20")]
	private void MNEBNPMAPCO(NativeArray<int> BKFKBDEBILB, int HLBNNKDJNFD, int DJNOFFBCCDM, int PKJIKANGBCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class EICPAEHMMED : NKOGIHIOAHK, ABBNIDCAHHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private DEKNJOMIBAL[] OIKFMFPEKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private COHBBIPPACH GNBEJDEPNDB;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2167420", Offset = "0x2166620", VA = "0x182167420")]
	[EEPNDFMGFKJ(CPDKPFACMJL.None)]
	private static void HLFDIDCONPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x21679C0", Offset = "0x2166BC0", VA = "0x1821679C0")]
	[Preserve]
	public EICPAEHMMED([AHKDIAMPNOO(null)] GOOIHJDEJFJ LBPAHHIKEMB, [AHKDIAMPNOO(null)] NDCOHBNKKFJ PMOHEFLOOJB, [AHKDIAMPNOO(null)] FHNGAHOLLEK IPFAPLGLDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2167210", Offset = "0x2166410", VA = "0x182167210", Slot = "12")]
	public override NNDKFCLIIOJ ECIONNJCNEG(EGHAAFLIMGB JAEDJGBMHAP, IEnumerator<NABEINJFOOA> CCDPOFCJCFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2167650", Offset = "0x2166850", VA = "0x182167650", Slot = "13")]
	public override void MJIFHFDNIAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2167480", Offset = "0x2166680", VA = "0x182167480", Slot = "15")]
	public override void JPNKMAOADNL(BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2167340", Offset = "0x2166540", VA = "0x182167340", Slot = "14")]
	protected override void HGBIKKNOCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2167160", Offset = "0x2166360", VA = "0x182167160")]
	private DEKNJOMIBAL COGGKIPHECF(BKLGPMMCHAJ.MDHDNHBJCBN BGMCKNGNOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2167910", Offset = "0x2166B10", VA = "0x182167910", Slot = "16")]
	internal override NPADPDDJCGG MKJMCGIJGEI(IEnumerator<NABEINJFOOA> CCDPOFCJCFH, Behaviour JAEDJGBMHAP, ABGKJOHBONH JFKKPGJCCBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2166FD0", Offset = "0x21661D0", VA = "0x182166FD0", Slot = "17")]
	internal override FFDMBGPMKCI CFDFMDLPDIO(BKLGPMMCHAJ.MDHDNHBJCBN ILAADJAKLMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2167040", Offset = "0x2166240", VA = "0x182167040")]
	private void CNBBEANILDI(DEKNJOMIBAL EGMJMAFOAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x21671A0", Offset = "0x21663A0", VA = "0x1821671A0", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class NKOGIHIOAHK : ABBNIDCAHHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly GOOIHJDEJFJ LBPAHHIKEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	protected readonly NDCOHBNKKFJ PMOHEFLOOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly FHNGAHOLLEK IPFAPLGLDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private FFDMBGPMKCI[] DFOBAJBIJLG;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ABBNIDCAHHA HBKBBJLFPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x216D840", Offset = "0x216CA40", VA = "0x18216D840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static bool HBDGLOLIBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x601070", Offset = "0x600270", VA = "0x180601070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public BKLGPMMCHAJ.MDHDNHBJCBN PHCNPNFPJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x62D550", Offset = "0x62C750", VA = "0x18062D550", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BKLGPMMCHAJ.MDHDNHBJCBN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6EDC00", Offset = "0x6ECE00", VA = "0x1806EDC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public NDCOHBNKKFJ HJNMGGFGILH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD10", Offset = "0x5FCF10", VA = "0x1805FDD10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x216DE00", Offset = "0x216D000", VA = "0x18216DE00")]
	public static NNDKFCLIIOJ HMNMGGIPAIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x216E540", Offset = "0x216D740", VA = "0x18216E540")]
	[Preserve]
	protected NKOGIHIOAHK([AHKDIAMPNOO(null)] GOOIHJDEJFJ LBPAHHIKEMB, [AHKDIAMPNOO(null)] NDCOHBNKKFJ PMOHEFLOOJB, [AHKDIAMPNOO(null)] FHNGAHOLLEK IPFAPLGLDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x216E100", Offset = "0x216D300", VA = "0x18216E100", Slot = "6")]
	public NNDKFCLIIOJ JMOHDGKJGBJ(IEnumerator<NABEINJFOOA> CCDPOFCJCFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x216DEE0", Offset = "0x216D0E0", VA = "0x18216DEE0", Slot = "7")]
	public NNDKFCLIIOJ JMOHDGKJGBJ(Behaviour JAEDJGBMHAP, IEnumerator<NABEINJFOOA> CCDPOFCJCFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract NNDKFCLIIOJ ECIONNJCNEG(EGHAAFLIMGB JAEDJGBMHAP, IEnumerator<NABEINJFOOA> CCDPOFCJCFH);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x216E340", Offset = "0x216D540", VA = "0x18216E340", Slot = "13")]
	public virtual void MJIFHFDNIAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x216DD60", Offset = "0x216CF60", VA = "0x18216DD60", Slot = "9")]
	public void FIHICOKAKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x216DDC0", Offset = "0x216CFC0", VA = "0x18216DDC0", Slot = "14")]
	protected virtual void HGBIKKNOCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x216DEC0", Offset = "0x216D0C0", VA = "0x18216DEC0")]
	private void JHHKCCNIGKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x216DEA0", Offset = "0x216D0A0", VA = "0x18216DEA0")]
	private void ILBENMNBGKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x216DDE0", Offset = "0x216CFE0", VA = "0x18216DDE0")]
	private void HHDAFANMJKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x216D890", Offset = "0x216CA90", VA = "0x18216D890")]
	private void DLPAEGMPPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x216DD40", Offset = "0x216CF40", VA = "0x18216DD40")]
	private void ELCFDECDLCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x216E520", Offset = "0x216D720", VA = "0x18216E520")]
	private void OCHNBLKCBEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x216D820", Offset = "0x216CA20", VA = "0x18216D820")]
	private void BBNLADHBHFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x216E110", Offset = "0x216D310", VA = "0x18216E110", Slot = "15")]
	public virtual void JPNKMAOADNL(BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x216DB80", Offset = "0x216CD80", VA = "0x18216DB80")]
	private void EEMGODEDBBM(FFDMBGPMKCI EGMJMAFOAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x105C3A0", Offset = "0x105B5A0", VA = "0x18105C3A0")]
	private FFDMBGPMKCI CLFIJKDEEFL(BKLGPMMCHAJ.MDHDNHBJCBN BGMCKNGNOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract NPADPDDJCGG MKJMCGIJGEI(IEnumerator<NABEINJFOOA> CCDPOFCJCFH, Behaviour OHLDDLIMNHB, ABGKJOHBONH FCGFDIMKCBK);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract FFDMBGPMKCI CFDFMDLPDIO(BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x216D8B0", Offset = "0x216CAB0", VA = "0x18216D8B0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class NPADPDDJCGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly ABGKJOHBONH JFKKPGJCCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly BEGCDPJOECL JAEDJGBMHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly bool AJGPFLGAJLN;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IEnumerator<NABEINJFOOA> LKOOBHINICI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6EE480", Offset = "0x6ED680", VA = "0x1806EE480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public NABEINJFOOA GEIGHOCMKHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x623BB0", Offset = "0x622DB0", VA = "0x180623BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool BKKJGKOFPGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x216ED90", Offset = "0x216DF90", VA = "0x18216ED90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool FJLGJDKIAIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x94F2F0", Offset = "0x94E4F0", VA = "0x18094F2F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x94F940", Offset = "0x94EB40", VA = "0x18094F940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string JPGOKIEGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6FCDA0", Offset = "0x6FBFA0", VA = "0x1806FCDA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6FD080", Offset = "0x6FC280", VA = "0x1806FD080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float NNJEEKNNCJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xE2F550", Offset = "0xE2E750", VA = "0x180E2F550")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x112BAF0", Offset = "0x112ACF0", VA = "0x18112BAF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x216F220", Offset = "0x216E420", VA = "0x18216F220")]
	public NPADPDDJCGG(IEnumerator<NABEINJFOOA> NAGKGIFJHDE, BEGCDPJOECL JAEDJGBMHAP, ABGKJOHBONH JFKKPGJCCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x216EE80", Offset = "0x216E080", VA = "0x18216EE80")]
	public NABEINJFOOA HMAABJFIDCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x216EE10", Offset = "0x216E010", VA = "0x18216EE10")]
	public bool ENILPCGGGCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x216F100", Offset = "0x216E300", VA = "0x18216F100")]
	public void OHLJMIHNBPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x216F190", Offset = "0x216E390", VA = "0x18216F190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x216F0F0", Offset = "0x216E2F0", VA = "0x18216F0F0")]
	[CompilerGenerated]
	private void KMALMMOBJPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class ABGKJOHBONH : GNMMKDLGGLL, NNDKFCLIIOJ, HDKDEMHKIGC, NOJPGNEJCEO, IEnumerator, NABEINJFOOA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private BKLGPMMCHAJ.MDHDNHBJCBN LLIMHPCIFJH;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private BKLGPMMCHAJ.MDHDNHBJCBN LDIHALBKFON
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x825BF0", Offset = "0x824DF0", VA = "0x180825BF0", Slot = "23")]
		get
		{
			return default(BKLGPMMCHAJ.MDHDNHBJCBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public BKLGPMMCHAJ.MDHDNHBJCBN FBCEHMMMHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x965180", Offset = "0x964380", VA = "0x180965180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private float JILGOIABJGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xE21500", Offset = "0xE20700", VA = "0x180E21500", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x215B710", Offset = "0x215A910", VA = "0x18215B710", Slot = "24")]
	private bool LEHCAPGLFEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x215B700", Offset = "0x215A900", VA = "0x18215B700", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x215B730", Offset = "0x215A930", VA = "0x18215B730")]
	public ABGKJOHBONH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal enum LDEIIDPPFEI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class FFDMBGPMKCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum OBBLFANOOMD
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct PDHMHAGAGMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public BKLGPMMCHAJ.MDHDNHBJCBN JDGAPMGCPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public OBBLFANOOMD CGGMLIIPCPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public List<NPADPDDJCGG> MOAPGALNLKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly OBBLFANOOMD[] EILKHKHICCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly BKLGPMMCHAJ.MDHDNHBJCBN CNABBNJEPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private bool PIEHNNMJNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly NPADPDDJCGG[] EIJIGOEPPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<NPADPDDJCGG> PIOHAFBGLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Stack<int> NMKOKMFMBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<NPADPDDJCGG> LPNLGJFCIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly Stack<int> PIOJDPPCBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly COHBBIPPACH PPBAGJNOBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private bool GPNCGIEDDKK;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public PDHMHAGAGMC[,] BFKNBNLNPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5F8940", Offset = "0x5F7B40", VA = "0x1805F8940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2168E00", Offset = "0x2168000", VA = "0x182168E00")]
	public FFDMBGPMKCI(BKLGPMMCHAJ.MDHDNHBJCBN ILAADJAKLMF, COHBBIPPACH PPBAGJNOBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2167CD0", Offset = "0x2166ED0", VA = "0x182167CD0")]
	public void EEKBMNAIGHD(NPADPDDJCGG NAGKGIFJHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2168AA0", Offset = "0x2167CA0", VA = "0x182168AA0")]
	public void PONOMAEPCOK(IList<NPADPDDJCGG> PHHECPPCOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2167DF0", Offset = "0x2166FF0", VA = "0x182167DF0")]
	public void FGFCHNEKPHM(IList<NPADPDDJCGG> PHHECPPCOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x21689B0", Offset = "0x2167BB0", VA = "0x1821689B0")]
	private void OMIPPOECMHJ(NPADPDDJCGG NAGKGIFJHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x21684E0", Offset = "0x21676E0", VA = "0x1821684E0")]
	private void JPFBNEMEMOC(IList<NPADPDDJCGG> PHHECPPCOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2168830", Offset = "0x2167A30", VA = "0x182168830")]
	private LDEIIDPPFEI NOAGLDODABI(NPADPDDJCGG NAGKGIFJHDE)
	{
		return default(LDEIIDPPFEI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2168390", Offset = "0x2167590", VA = "0x182168390")]
	public void HGBIKKNOCLO(float DPNNMDMALCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2168070", Offset = "0x2167270", VA = "0x182168070")]
	public void FIHICOKAKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2168650", Offset = "0x2167850", VA = "0x182168650")]
	private void NFPOKJFNJBL(List<NPADPDDJCGG> PHHECPPCOIG, Stack<int> ONIHAKNGDPL, bool AFMOJIJPGGL, float LFDOLMMBHJN = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2167B90", Offset = "0x2166D90", VA = "0x182167B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2168270", Offset = "0x2167470", VA = "0x182168270")]
	private void HBHBBBDNLAG(List<NPADPDDJCGG> PHHECPPCOIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class KCOCIHPLCBL : COHBBIPPACH
{
	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "4")]
	public void GMLNNFEKABH(string JFLKGPEABBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
	public void NPLFDOIGKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public KCOCIHPLCBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal class GACOMAOKCFE : BEGCDPJOECL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly Behaviour OHLDDLIMNHB;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string JPGOKIEGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2169530", Offset = "0x2168730", VA = "0x182169530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool LOGLDKKHDGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x21695C0", Offset = "0x21687C0", VA = "0x1821695C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DOLGHDEKIIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2169620", Offset = "0x2168820", VA = "0x182169620", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6270A0", Offset = "0x6262A0", VA = "0x1806270A0")]
	public GACOMAOKCFE(Behaviour OHLDDLIMNHB)
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

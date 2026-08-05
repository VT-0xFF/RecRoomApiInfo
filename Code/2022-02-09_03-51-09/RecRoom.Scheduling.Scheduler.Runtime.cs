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
		private delegate List<PlayerLoopSystem> FKJPOOBDFMO(List<PlayerLoopSystem> NBDIAFAGMDG, int LNODEGDKKAN);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct GFOLGAAGHNO
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct ABGLIIIGNAP
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static MHDMOBBLODF FNCMFANOFMP;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x42C3B40", Offset = "0x42C2940", VA = "0x1842C3B40")]
				public static PlayerLoopSystem OALMKFMNBJO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct CBKDOKFBIOK
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static MHDMOBBLODF NLMPEBLPKBC;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x42C6580", Offset = "0x42C5380", VA = "0x1842C6580")]
				public static PlayerLoopSystem OALMKFMNBJO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct KOFNDONBBEB
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static MHDMOBBLODF DMBMDHPGFNM;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x42CF620", Offset = "0x42CE420", VA = "0x1842CF620")]
				public static PlayerLoopSystem OALMKFMNBJO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct DGLPFFFBGFO
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static MHDMOBBLODF DHGKCKEJDFK;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x42C8BF0", Offset = "0x42C79F0", VA = "0x1842C8BF0")]
				public static PlayerLoopSystem OALMKFMNBJO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct DFBAGCBFPPH
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class FCHHAILCPMG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000F")]
					public IGBKHJAEPNO.HNMJAHLNEMI key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
					public FCHHAILCPMG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x42CA170", Offset = "0x42C8F70", VA = "0x1842CA170")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IDisposable CDILMDELLGA;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x42C8820", Offset = "0x42C7620", VA = "0x1842C8820")]
				public static PlayerLoopSystem LBJOLHPJKKN(IGBKHJAEPNO.HNMJAHLNEMI MLBLCDKAFED)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct NAMPKCMDOAD
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class MGFLHBLLHBE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000010")]
					public IGBKHJAEPNO.HNMJAHLNEMI key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
					public MGFLHBLLHBE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x42D00A0", Offset = "0x42CEEA0", VA = "0x1842D00A0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x42D0380", Offset = "0x42CF180", VA = "0x1842D0380")]
				public static PlayerLoopSystem LBJOLHPJKKN(IGBKHJAEPNO.HNMJAHLNEMI MLBLCDKAFED)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class AKFMLLEPPFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
			public AKFMLLEPPFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x42C49B0", Offset = "0x42C37B0", VA = "0x1842C49B0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool NJIFMLIGDCI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool HGIIMENAIHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x42C8130", Offset = "0x42C6F30", VA = "0x1842C8130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x42C8340", Offset = "0x42C7140", VA = "0x1842C8340")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x42C6EB0", Offset = "0x42C5CB0", VA = "0x1842C6EB0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x42C8170", Offset = "0x42C6F70", VA = "0x1842C8170")]
		private static void ENBEPFGIKPC(IGBKHJAEPNO.HNMJAHLNEMI MLBLCDKAFED, ref PlayerLoopSystem KCKCIEMMKDE, Type CEJCJPPBJHJ, Type OFLEJBAAOEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x42C84A0", Offset = "0x42C72A0", VA = "0x1842C84A0")]
		private static void KEAOGAADNLF(ref PlayerLoopSystem KCKCIEMMKDE, Type CEJCJPPBJHJ, Type OFLEJBAAOEE, FKJPOOBDFMO APJONPKELCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x42C8380", Offset = "0x42C7180", VA = "0x1842C8380")]
		private static void HDCIEENFOEI(ref PlayerLoopSystem KCKCIEMMKDE, Type CEJCJPPBJHJ, Type OFLEJBAAOEE, PlayerLoopSystem? JLJIJHCGCJM, PlayerLoopSystem? DAJOPFBALDC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IGBKHJAEPNO
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum HNMJAHLNEMI
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		FullPlayerLoop
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class FKODEJAEOHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly HNMJAHLNEMI FHDGIMNALBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly DGEJFCNNONM AOKNIIMMHGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long MCJBIKJLOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long OCCLPHHODAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long NNNCHGBJLEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int EPFJPJOCHEC;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x42CAF40", Offset = "0x42C9D40", VA = "0x1842CAF40")]
		public FKODEJAEOHD(HNMJAHLNEMI MGFFFPOGHJJ, int JCHBMLHDNEL = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x42CAC40", Offset = "0x42C9A40", VA = "0x1842CAC40")]
		public void CMCLJPLKJAP(int KABAEOOFPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x42CAED0", Offset = "0x42C9CD0", VA = "0x1842CAED0")]
		public void OPPCMADIBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x42CABE0", Offset = "0x42C99E0", VA = "0x1842CABE0")]
		public void AMEENKGPPKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x42CAC60", Offset = "0x42C9A60", VA = "0x1842CAC60")]
		public void DJEPHHJBPGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x42CAE30", Offset = "0x42C9C30", VA = "0x1842CAE30")]
		public double MKKJICICINL(int HPPJMGPANGB)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const int CENICGIKMDO = 90;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static HNMJAHLNEMI[] DMCLBPBFCDI;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static FKODEJAEOHD[] MGPBBMPFDEN;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x42CEA10", Offset = "0x42CD810", VA = "0x1842CEA10")]
	public static FKODEJAEOHD LDMKMBHIBJE(HNMJAHLNEMI MLBLCDKAFED, int JCHBMLHDNEL = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x42CE8D0", Offset = "0x42CD6D0", VA = "0x1842CE8D0")]
	public static FKODEJAEOHD AFALHOAMGIE(HNMJAHLNEMI MLBLCDKAFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x42CE960", Offset = "0x42CD760", VA = "0x1842CE960")]
	public static void HOIHFFFHDHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DGEJFCNNONM : FFKJFDLJOGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int LCHGMJOGIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Queue<double> EOGPBJFPBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private double KPELLGFACNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double GGDDBFGMJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double GINHNAHPIDN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FFJIGHMMENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x42C89B0", Offset = "0x42C77B0", VA = "0x1842C89B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double KEHLNNCCMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x42C8AF0", Offset = "0x42C78F0", VA = "0x1842C8AF0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double OGMKHGELDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1147AD0", Offset = "0x11468D0", VA = "0x181147AD0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double FKCCAPPBMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE590", Offset = "0x2FDD390", VA = "0x182FDE590", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x42C8B50", Offset = "0x42C7950", VA = "0x1842C8B50")]
	public DGEJFCNNONM(int PMGMFONINGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x42C89F0", Offset = "0x42C77F0", VA = "0x1842C89F0", Slot = "4")]
	public void NCPNFIGOHNA(double GKDBLEANOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x42C8940", Offset = "0x42C7740", VA = "0x1842C8940", Slot = "5")]
	public void JAOKAFBBLJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MCGJIEONLFF : FFKJFDLJOGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private long NJNIKNLNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double FOGINFIKAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double GPCIIKOMAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double JBAMJGDONCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double MLBAOOEAEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double KPELLGFACNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double GGDDBFGMJPA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long KBMMNCEALDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4E91D0", Offset = "0x4E7FD0", VA = "0x1804E91D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double OGMKHGELDFF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3347A30", Offset = "0x3346830", VA = "0x183347A30", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double FKCCAPPBMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x86DCA0", Offset = "0x86CAA0", VA = "0x18086DCA0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double MHOHDPDALOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE590", Offset = "0x2FDD390", VA = "0x182FDE590")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double DBLKDDDNKOC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE580", Offset = "0x2FDD380", VA = "0x182FDE580")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double KEHLNNCCMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x321AAD0", Offset = "0x32198D0", VA = "0x18321AAD0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x42CFF50", Offset = "0x42CED50", VA = "0x1842CFF50", Slot = "4")]
	public void NCPNFIGOHNA(double GKDBLEANOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x42CFF10", Offset = "0x42CED10", VA = "0x1842CFF10", Slot = "5")]
	public void JAOKAFBBLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x42D0070", Offset = "0x42CEE70", VA = "0x1842D0070")]
	public MCGJIEONLFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FFKJFDLJOGL
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double KEHLNNCCMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double OGMKHGELDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double FKCCAPPBMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCPNFIGOHNA(double GKDBLEANOLG);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JAOKAFBBLJO();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class ENHFELOMJOF
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private interface DGDOHOCICNG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool IDPEAEIEIAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IGGCAGCIHAO();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JJBLBCOKMKD();
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private abstract class PFNOOGPGDEF<TPromise, TMainThreadPromise> : DGDOHOCICNG where TPromise : CFGFLPOGNPH where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly TPromise LCHIFANBNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected readonly TMainThreadPromise JJIOGMEHFHB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise NPCEPPNDKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x38F7690", Offset = "0x38F6490", VA = "0x1838F7690")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IDPEAEIEIAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x38F76F0", Offset = "0x38F64F0", VA = "0x1838F76F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x250F620", Offset = "0x250E420", VA = "0x18250F620")]
		protected PFNOOGPGDEF(TPromise LCHIFANBNOP, TMainThreadPromise PDCPMGHIAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x38F7740", Offset = "0x38F6540", VA = "0x1838F7740", Slot = "5")]
		public void IGGCAGCIHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x25ABDA0", Offset = "0x25AABA0", VA = "0x1825ABDA0", Slot = "6")]
		public void JJBLBCOKMKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void EEKNEGLOOJL(TPromise LCHIFANBNOP);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void KLKICKDGELO();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class PMHJKPCBKNB<T> : PFNOOGPGDEF<global::DIPKCKEGDMM<T>, global::PHMCHJKELPF<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x38F7A00", Offset = "0x38F6800", VA = "0x1838F7A00")]
		public PMHJKPCBKNB(global::DIPKCKEGDMM<T> LCHIFANBNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x38F7770", Offset = "0x38F6570", VA = "0x1838F7770", Slot = "7")]
		protected override void EEKNEGLOOJL(global::DIPKCKEGDMM<T> LCHIFANBNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x38F79A0", Offset = "0x38F67A0", VA = "0x1838F79A0", Slot = "8")]
		protected override void KLKICKDGELO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x343BE80", Offset = "0x343AC80", VA = "0x18343BE80")]
		[CompilerGenerated]
		private void PEEMFGINFOL(T NCEOJLFBEHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x38F7970", Offset = "0x38F6770", VA = "0x1838F7970")]
		[CompilerGenerated]
		private void GKPFDOOBFBE(string DKOKBNBNGCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class LHKEBHPFOPK : PFNOOGPGDEF<CFGFLPOGNPH, CMJIAFMNIEL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x42CF970", Offset = "0x42CE770", VA = "0x1842CF970")]
		public LHKEBHPFOPK(CFGFLPOGNPH LCHIFANBNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x42CF850", Offset = "0x42CE650", VA = "0x1842CF850", Slot = "7")]
		protected override void EEKNEGLOOJL(CFGFLPOGNPH LCHIFANBNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x42CF920", Offset = "0x42CE720", VA = "0x1842CF920", Slot = "8")]
		protected override void KLKICKDGELO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x153B8E0", Offset = "0x153A6E0", VA = "0x18153B8E0")]
		[CompilerGenerated]
		private void PEEMFGINFOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1866030", Offset = "0x1864E30", VA = "0x181866030")]
		[CompilerGenerated]
		private void GKPFDOOBFBE(string DKOKBNBNGCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class OKECDFBBENF : DGDOHOCICNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Action ILFANDGNKPL;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IDPEAEIEIAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x4E9FE0", Offset = "0x4E8DE0", VA = "0x1804E9FE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5AB430", Offset = "0x5AA230", VA = "0x1805AB430")]
		public OKECDFBBENF(Action ILFANDGNKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1399680", Offset = "0x1398480", VA = "0x181399680", Slot = "5")]
		public void IGGCAGCIHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "6")]
		public void JJBLBCOKMKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly List<DGDOHOCICNG> KEPEPDEOPEG;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1CBE690", Offset = "0x1CBD490", VA = "0x181CBE690")]
	public static global::DIPKCKEGDMM<T> LLBKGOGCGDB<T>(this global::DIPKCKEGDMM<T> LCHIFANBNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x42C9E80", Offset = "0x42C8C80", VA = "0x1842C9E80")]
	public static CFGFLPOGNPH LLBKGOGCGDB(this CFGFLPOGNPH LCHIFANBNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x42C9DF0", Offset = "0x42C8BF0", VA = "0x1842C9DF0")]
	public static void LLBKGOGCGDB(Action ILFANDGNKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1CBE5D0", Offset = "0x1CBD3D0", VA = "0x181CBE5D0")]
	private static global::DIPKCKEGDMM<T> DHGPDIEMBLI<T>(global::DIPKCKEGDMM<T> LCHIFANBNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x42C9B20", Offset = "0x42C8920", VA = "0x1842C9B20")]
	private static CFGFLPOGNPH DHGPDIEMBLI(CFGFLPOGNPH LCHIFANBNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x42C9C00", Offset = "0x42C8A00", VA = "0x1842C9C00")]
	private static void IGJKPAFMDDA(DGDOHOCICNG HNJEACAIPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x42C9800", Offset = "0x42C8600", VA = "0x1842C9800")]
	private static void DGLDCMFALGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x42C9F90", Offset = "0x42C8D90", VA = "0x1842C9F90")]
	private static void MDPHOIHNMCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x42CA060", Offset = "0x42C8E60", VA = "0x1842CA060")]
	private static void NKGBMHDMMGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class NMADBKDKGAP
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class CGIDOGJEBLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CMJIAFMNIEL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
		public CGIDOGJEBLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x42C6CB0", Offset = "0x42C5AB0", VA = "0x1842C6CB0")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x42C6CA0", Offset = "0x42C5AA0", VA = "0x1842C6CA0")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JCIONADFCJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
		public JCIONADFCJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x42CEDB0", Offset = "0x42CDBB0", VA = "0x1842CEDB0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class FKFKCHLCMCI : IEnumerator<CNLGKCMJFDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private CNLGKCMJFDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CMJIAFMNIEL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private CNLGKCMJFDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
		[DebuggerHidden]
		public FKFKCHLCMCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x42CA920", Offset = "0x42C9720", VA = "0x1842CA920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x42CA600", Offset = "0x42C9400", VA = "0x1842CA600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x42CA9D0", Offset = "0x42C97D0", VA = "0x1842CA9D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x42CA8D0", Offset = "0x42C96D0", VA = "0x1842CA8D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class LPPKKFJGCON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CMJIAFMNIEL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
		public LPPKKFJGCON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LOKHILAOKEG : IEnumerator<CNLGKCMJFDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private CNLGKCMJFDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CMJIAFMNIEL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private LPPKKFJGCON <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private CNLGKCMJFDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
		[DebuggerHidden]
		public LOKHILAOKEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x42CF9E0", Offset = "0x42CE7E0", VA = "0x1842CF9E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x42CFD70", Offset = "0x42CEB70", VA = "0x1842CFD70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string PJGPJEBFMCA = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string LBKAIEFIHOA = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const string OOAGCANABLF = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const string IIBAPKGHIBH = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public const string GFCGNBDFEAO = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private const float DDEPPHGDDIF = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static CFGFLPOGNPH KEGDLPJBHAP;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static AsyncOperation KCPGCGDJHBA;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static CFGFLPOGNPH CJANCPJCEIP;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static string LCIIMJKKFNA;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ThreadPriority KNDCAHLFHPF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool JKONBJLIIEM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x42D1A50", Offset = "0x42D0850", VA = "0x1842D1A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool PJEJOPOALGG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x42D1960", Offset = "0x42D0760", VA = "0x1842D1960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool NPODJKLEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x42D1900", Offset = "0x42D0700", VA = "0x1842D1900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> IMDHNKOCLGB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x42D1850", Offset = "0x42D0650", VA = "0x1842D1850")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x42D1AF0", Offset = "0x42D08F0", VA = "0x1842D1AF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x42D1DD0", Offset = "0x42D0BD0", VA = "0x1842D1DD0")]
	public static CFGFLPOGNPH PCLBMIIPICN(string JDBOGHMLGFB, LoadSceneMode GFKFJNKHDDA = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x42D1BA0", Offset = "0x42D09A0", VA = "0x1842D1BA0")]
	public static CFGFLPOGNPH LNKOJLDNFBP(string JDBOGHMLGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x42D19C0", Offset = "0x42D07C0", VA = "0x1842D19C0")]
	[IteratorStateMachine(typeof(FKFKCHLCMCI))]
	private static IEnumerator<CNLGKCMJFDJ> DCMMAGHDDAK(string JDBOGHMLGFB, CMJIAFMNIEL IEIMMOKKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x42D1F30", Offset = "0x42D0D30", VA = "0x1842D1F30")]
	[IteratorStateMachine(typeof(LOKHILAOKEG))]
	private static IEnumerator<CNLGKCMJFDJ> PFKLCKIKOCM(string JDBOGHMLGFB, LoadSceneMode GFKFJNKHDDA, CMJIAFMNIEL IEIMMOKKMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class BDMNDALIBPB
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x42C5300", Offset = "0x42C4100", VA = "0x1842C5300")]
	public static IDisposable MDNOFLNODAH(this JHJJCGPNGCI HIKLIFLDMDD, Action PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x42C5280", Offset = "0x42C4080", VA = "0x1842C5280")]
	public static IDisposable MDNOFLNODAH(this JHJJCGPNGCI HIKLIFLDMDD, Action<float> PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x42C4E30", Offset = "0x42C3C30", VA = "0x1842C4E30")]
	public static IDisposable FGHPHDECHCD(this JHJJCGPNGCI HIKLIFLDMDD, Action PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x42C5210", Offset = "0x42C4010", VA = "0x1842C5210")]
	public static IDisposable LLPPOKNLPLH(this JHJJCGPNGCI HIKLIFLDMDD, Action PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x42C5010", Offset = "0x42C3E10", VA = "0x1842C5010")]
	public static IDisposable GHNCBMEJIKH(this JHJJCGPNGCI HIKLIFLDMDD, Action PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x42C4EA0", Offset = "0x42C3CA0", VA = "0x1842C4EA0")]
	public static IDisposable FJPHICBEBHI(this JHJJCGPNGCI HIKLIFLDMDD, Action PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x42C4D40", Offset = "0x42C3B40", VA = "0x1842C4D40")]
	public static IDisposable EFBKAJCGJGF(this JHJJCGPNGCI HIKLIFLDMDD, Action PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x42C5180", Offset = "0x42C3F80", VA = "0x1842C5180")]
	public static IDisposable JFPPICBLODA(this JHJJCGPNGCI HIKLIFLDMDD, float KJBKODPGFKF, Action<float> PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x42C5410", Offset = "0x42C4210", VA = "0x1842C5410")]
	public static IDisposable OHCCHFMOOAF(this JHJJCGPNGCI HIKLIFLDMDD, float KJBKODPGFKF, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x42C4F90", Offset = "0x42C3D90", VA = "0x1842C4F90")]
	public static IDisposable GDKKLGMOGEM(this JHJJCGPNGCI HIKLIFLDMDD, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x42C4B30", Offset = "0x42C3930", VA = "0x1842C4B30")]
	public static IDisposable BCIDAPMLNAG(this JHJJCGPNGCI HIKLIFLDMDD, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x42C4DB0", Offset = "0x42C3BB0", VA = "0x1842C4DB0")]
	public static IDisposable EIOOHOOFEBK(this JHJJCGPNGCI HIKLIFLDMDD, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x42C5380", Offset = "0x42C4180", VA = "0x1842C5380")]
	public static IDisposable NJLNMOFCMHD(this JHJJCGPNGCI HIKLIFLDMDD, float KJBKODPGFKF, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x42C4AB0", Offset = "0x42C38B0", VA = "0x1842C4AB0")]
	public static IDisposable ANPIIENJJJF(this JHJJCGPNGCI HIKLIFLDMDD, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x42C4C30", Offset = "0x42C3A30", VA = "0x1842C4C30")]
	public static IDisposable DDALONCCEIE(this JHJJCGPNGCI HIKLIFLDMDD, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x42C4BB0", Offset = "0x42C39B0", VA = "0x1842C4BB0")]
	public static IDisposable BEDBHIPGDPE(this JHJJCGPNGCI HIKLIFLDMDD, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x42C4CB0", Offset = "0x42C3AB0", VA = "0x1842C4CB0")]
	public static IDisposable EDKNMLGNPJD(this JHJJCGPNGCI HIKLIFLDMDD, float KJBKODPGFKF, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x42C4F10", Offset = "0x42C3D10", VA = "0x1842C4F10")]
	public static IDisposable GCLMGEOHJBA(this JHJJCGPNGCI HIKLIFLDMDD, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x42C5080", Offset = "0x42C3E80", VA = "0x1842C5080")]
	public static IDisposable GLFKHOMKHNM(this JHJJCGPNGCI HIKLIFLDMDD, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x42C5100", Offset = "0x42C3F00", VA = "0x1842C5100")]
	public static IDisposable GOEFIEGEPKF(this JHJJCGPNGCI HIKLIFLDMDD, Action<float> PJLECLKEBMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class AFIFAABJGEC
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x42C4670", Offset = "0x42C3470", VA = "0x1842C4670")]
	public static IDisposable MCHKEDIBOHF(this MonoBehaviour HHILAMLCMPL, Action PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x42C46F0", Offset = "0x42C34F0", VA = "0x1842C46F0")]
	public static IDisposable MCHKEDIBOHF(this MonoBehaviour HHILAMLCMPL, Action<float> PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x42C3E10", Offset = "0x42C2C10", VA = "0x1842C3E10")]
	public static IDisposable CNIMBBBDAOM(this MonoBehaviour HHILAMLCMPL, Action PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x42C41A0", Offset = "0x42C2FA0", VA = "0x1842C41A0")]
	public static IDisposable IENEEOCEDKI(this MonoBehaviour HHILAMLCMPL, Action PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x42C4600", Offset = "0x42C3400", VA = "0x1842C4600")]
	public static IDisposable MBOHIKBCGFD(this MonoBehaviour HHILAMLCMPL, Action PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x42C4510", Offset = "0x42C3310", VA = "0x1842C4510")]
	public static IDisposable LOONDJLLMKO(this MonoBehaviour HHILAMLCMPL, Action PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x42C3F00", Offset = "0x42C2D00", VA = "0x1842C3F00")]
	public static IDisposable EAOKAJKBCLN(this MonoBehaviour HHILAMLCMPL, Action PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x42C3F70", Offset = "0x42C2D70", VA = "0x1842C3F70")]
	public static IDisposable EAPFEAGNEML(this MonoBehaviour HHILAMLCMPL, float KJBKODPGFKF, Action<float> PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x42C3E80", Offset = "0x42C2C80", VA = "0x1842C3E80")]
	public static IDisposable DBJDKCEPADE(this MonoBehaviour HHILAMLCMPL, float KJBKODPGFKF, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x42C3D90", Offset = "0x42C2B90", VA = "0x1842C3D90")]
	public static IDisposable AHNFFJDAPPB(this MonoBehaviour HHILAMLCMPL, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x42C4410", Offset = "0x42C3210", VA = "0x1842C4410")]
	public static IDisposable KEECBFNPMOK(this MonoBehaviour HHILAMLCMPL, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x42C47F0", Offset = "0x42C35F0", VA = "0x1842C47F0")]
	public static IDisposable OPPCKLJNOLP(this MonoBehaviour HHILAMLCMPL, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x42C4490", Offset = "0x42C3290", VA = "0x1842C4490")]
	public static IDisposable KGDOJIECKKJ(this MonoBehaviour HHILAMLCMPL, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x42C4770", Offset = "0x42C3570", VA = "0x1842C4770")]
	public static IDisposable MOHFOHOIMFP(this MonoBehaviour HHILAMLCMPL, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x42C4390", Offset = "0x42C3190", VA = "0x1842C4390")]
	public static IDisposable KDPJDLCFPIL(this MonoBehaviour HHILAMLCMPL, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x42C4000", Offset = "0x42C2E00", VA = "0x1842C4000")]
	public static IDisposable GCBIFCOOKCE(this MonoBehaviour HHILAMLCMPL, float KJBKODPGFKF, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x42C4290", Offset = "0x42C3090", VA = "0x1842C4290")]
	public static IDisposable IKINFDMPHND(this MonoBehaviour HHILAMLCMPL, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x42C4210", Offset = "0x42C3010", VA = "0x1842C4210")]
	public static IDisposable IEODELLPGLO(this MonoBehaviour HHILAMLCMPL, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x42C4580", Offset = "0x42C3380", VA = "0x1842C4580")]
	public static IDisposable MBBAOPNNHOO(this MonoBehaviour HHILAMLCMPL, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x42C4110", Offset = "0x42C2F10", VA = "0x1842C4110")]
	public static IDisposable HMHAMCGNAJM(this MonoBehaviour HHILAMLCMPL, float KJBKODPGFKF, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x42C4090", Offset = "0x42C2E90", VA = "0x1842C4090")]
	public static IDisposable GPDKDIBAEPB(this MonoBehaviour HHILAMLCMPL, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x42C3D10", Offset = "0x42C2B10", VA = "0x1842C3D10")]
	public static IDisposable AFIHCBKLOKE(this MonoBehaviour HHILAMLCMPL, Action<float> PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x42C4310", Offset = "0x42C3110", VA = "0x1842C4310")]
	public static IDisposable KBJNBPPMLMP(this MonoBehaviour HHILAMLCMPL, Action<float> PJLECLKEBMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class NDPBFJBBFNL
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class EJBLDNPKKFN : IEnumerator<CNLGKCMJFDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private CNLGKCMJFDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public IFDJCGPOIOM.MEJCFHGJGNC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private OCKIPMMFJMM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private CNLGKCMJFDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
		[DebuggerHidden]
		public EJBLDNPKKFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x42C9010", Offset = "0x42C7E10", VA = "0x1842C9010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x42C90D0", Offset = "0x42C7ED0", VA = "0x1842C90D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class FKGMGNPFGBC : IEnumerator<CNLGKCMJFDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private CNLGKCMJFDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public IFDJCGPOIOM.MEJCFHGJGNC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private OCKIPMMFJMM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private CNLGKCMJFDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
		[DebuggerHidden]
		public FKGMGNPFGBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x42CAA20", Offset = "0x42C9820", VA = "0x1842CAA20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x42CAB00", Offset = "0x42C9900", VA = "0x1842CAB00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x42D04A0", Offset = "0x42CF2A0", VA = "0x1842D04A0")]
	public static LKIEAODIPPJ MCHKEDIBOHF(Action PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x42D07B0", Offset = "0x42CF5B0", VA = "0x1842D07B0")]
	public static LKIEAODIPPJ MCHKEDIBOHF(Action<float> PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x42D06A0", Offset = "0x42CF4A0", VA = "0x1842D06A0")]
	public static LKIEAODIPPJ MCHKEDIBOHF(Behaviour HIKLIFLDMDD, Action PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x42D0590", Offset = "0x42CF390", VA = "0x1842D0590")]
	public static LKIEAODIPPJ MCHKEDIBOHF(Behaviour HIKLIFLDMDD, Action<float> PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x42D09B0", Offset = "0x42CF7B0", VA = "0x1842D09B0")]
	public static LKIEAODIPPJ MDNOFLNODAH(JHJJCGPNGCI HIKLIFLDMDD, Action PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x42D08A0", Offset = "0x42CF6A0", VA = "0x1842D08A0")]
	public static LKIEAODIPPJ MDNOFLNODAH(JHJJCGPNGCI HIKLIFLDMDD, Action<float> PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x42D0AC0", Offset = "0x42CF8C0", VA = "0x1842D0AC0")]
	[IteratorStateMachine(typeof(EJBLDNPKKFN))]
	private static IEnumerator<CNLGKCMJFDJ> OILKENPAJAL(IFDJCGPOIOM.MEJCFHGJGNC GHCBHCFOBHL, Action PJLECLKEBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x42D0B40", Offset = "0x42CF940", VA = "0x1842D0B40")]
	[IteratorStateMachine(typeof(FKGMGNPFGBC))]
	private static IEnumerator<CNLGKCMJFDJ> OILKENPAJAL(IFDJCGPOIOM.MEJCFHGJGNC GHCBHCFOBHL, Action<float> PJLECLKEBMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class HPKNDGGMENC
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class AIHNOJHINEP : IEnumerator<CNLGKCMJFDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private CNLGKCMJFDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public IFDJCGPOIOM.MEJCFHGJGNC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private BKIHIMNDOOD <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private CNLGKCMJFDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
		[DebuggerHidden]
		public AIHNOJHINEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x42C4870", Offset = "0x42C3670", VA = "0x1842C4870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x42C4960", Offset = "0x42C3760", VA = "0x1842C4960", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x42CE6D0", Offset = "0x42CD4D0", VA = "0x1842CE6D0")]
	public static LKIEAODIPPJ MCHKEDIBOHF(float KJBKODPGFKF, Action<float> PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x42CE780", Offset = "0x42CD580", VA = "0x1842CE780")]
	public static LKIEAODIPPJ MCHKEDIBOHF(MonoBehaviour HHILAMLCMPL, float KJBKODPGFKF, Action<float> PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x42CE610", Offset = "0x42CD410", VA = "0x1842CE610")]
	public static LKIEAODIPPJ KKJDHCFCAPK(JHJJCGPNGCI HIKLIFLDMDD, float KJBKODPGFKF, Action<float> PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x42CE840", Offset = "0x42CD640", VA = "0x1842CE840")]
	[IteratorStateMachine(typeof(AIHNOJHINEP))]
	private static IEnumerator<CNLGKCMJFDJ> OILKENPAJAL(float KJBKODPGFKF, IFDJCGPOIOM.MEJCFHGJGNC GHCBHCFOBHL, Action<float> PJLECLKEBMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class MHBMDJCEKAL
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class DLMNCJCAOLC : IEnumerator<CNLGKCMJFDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private CNLGKCMJFDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public IFDJCGPOIOM.MEJCFHGJGNC queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private CNLGKCMJFDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
		[DebuggerHidden]
		public DLMNCJCAOLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x42C8DC0", Offset = "0x42C7BC0", VA = "0x1842C8DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x42C8E70", Offset = "0x42C7C70", VA = "0x1842C8E70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x42D0160", Offset = "0x42CEF60", VA = "0x1842D0160")]
	[IteratorStateMachine(typeof(DLMNCJCAOLC))]
	private static IEnumerator<CNLGKCMJFDJ> ALEBBDABEJL(IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF, Func<bool> GNAGAPJFADK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x42D01E0", Offset = "0x42CEFE0", VA = "0x1842D01E0")]
	public static LKIEAODIPPJ CIDOKBLBMMH(this MonoBehaviour HHILAMLCMPL, Func<bool> GNAGAPJFADK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF = IFDJCGPOIOM.MEJCFHGJGNC.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class NLDMPKEJNEC
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class NFNGHBHLLLN : IEnumerator<CNLGKCMJFDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private CNLGKCMJFDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public IFDJCGPOIOM.MEJCFHGJGNC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private CNLGKCMJFDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
		[DebuggerHidden]
		public NFNGHBHLLLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x42D0BC0", Offset = "0x42CF9C0", VA = "0x1842D0BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x42D0C80", Offset = "0x42CFA80", VA = "0x1842D0C80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class GGHEFFFEMOD : IEnumerator<CNLGKCMJFDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private CNLGKCMJFDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public IFDJCGPOIOM.MEJCFHGJGNC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private CNLGKCMJFDJ <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private CNLGKCMJFDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
		[DebuggerHidden]
		public GGHEFFFEMOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x42CC910", Offset = "0x42CB710", VA = "0x1842CC910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x42CC9E0", Offset = "0x42CB7E0", VA = "0x1842CC9E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x42D1100", Offset = "0x42CFF00", VA = "0x1842D1100")]
	[IteratorStateMachine(typeof(NFNGHBHLLLN))]
	private static IEnumerator<CNLGKCMJFDJ> JLCPIIPPNOF(float JMDONKAEBNO, IFDJCGPOIOM.MEJCFHGJGNC GHCBHCFOBHL, Action NECHNJGDBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x42D11A0", Offset = "0x42CFFA0", VA = "0x1842D11A0")]
	[IteratorStateMachine(typeof(GGHEFFFEMOD))]
	private static IEnumerator<CNLGKCMJFDJ> KIBOGMMLBPI(float JMDONKAEBNO, IFDJCGPOIOM.MEJCFHGJGNC GHCBHCFOBHL, Action NECHNJGDBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x42D1240", Offset = "0x42D0040", VA = "0x1842D1240")]
	public static IDisposable LMDHDHBKNOI(this MonoBehaviour HHILAMLCMPL, float JMDONKAEBNO, Action NECHNJGDBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x42D0DE0", Offset = "0x42CFBE0", VA = "0x1842D0DE0")]
	public static LKIEAODIPPJ GGCDCINKOBK(this MonoBehaviour HHILAMLCMPL, float JMDONKAEBNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x42D1390", Offset = "0x42D0190", VA = "0x1842D1390")]
	public static LKIEAODIPPJ LMDHDHBKNOI(this MonoBehaviour HHILAMLCMPL, float JMDONKAEBNO, IFDJCGPOIOM.MEJCFHGJGNC GHCBHCFOBHL, Action NECHNJGDBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x42D1840", Offset = "0x42D0640", VA = "0x1842D1840")]
	public static LKIEAODIPPJ PPNKHBEMHBL(this MonoBehaviour HHILAMLCMPL, Action NECHNJGDBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x42D14F0", Offset = "0x42D02F0", VA = "0x1842D14F0")]
	public static LKIEAODIPPJ MFLMNGGEFDB(this MonoBehaviour HHILAMLCMPL, Action NECHNJGDBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x42D1190", Offset = "0x42CFF90", VA = "0x1842D1190")]
	public static LKIEAODIPPJ KEHLCCCABDL(this MonoBehaviour HHILAMLCMPL, Action NECHNJGDBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x42D1230", Offset = "0x42D0030", VA = "0x1842D1230")]
	public static LKIEAODIPPJ LBEBGEAHMBN(this MonoBehaviour HHILAMLCMPL, Action NECHNJGDBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x42D1500", Offset = "0x42D0300", VA = "0x1842D1500")]
	public static LKIEAODIPPJ NEPLPCHLAMP(this MonoBehaviour HHILAMLCMPL, Action NECHNJGDBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x42D1730", Offset = "0x42D0530", VA = "0x1842D1730")]
	private static LKIEAODIPPJ PJAKGBMLKJJ(MonoBehaviour HHILAMLCMPL, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF, Action NECHNJGDBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x42D0EE0", Offset = "0x42CFCE0", VA = "0x1842D0EE0")]
	public static LKIEAODIPPJ HLGHAGNBNAA(this MonoBehaviour HHILAMLCMPL, float ILLFICGCEEH, Action NECHNJGDBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x42D1510", Offset = "0x42D0310", VA = "0x1842D1510")]
	public static LKIEAODIPPJ OJCMBHLIEDJ(this MonoBehaviour HHILAMLCMPL, float ILLFICGCEEH, Action NECHNJGDBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x42D0CD0", Offset = "0x42CFAD0", VA = "0x1842D0CD0")]
	public static LKIEAODIPPJ ENEFJAOOECD(this MonoBehaviour HHILAMLCMPL, float ILLFICGCEEH, Action NECHNJGDBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x42D1620", Offset = "0x42D0420", VA = "0x1842D1620")]
	public static LKIEAODIPPJ OKICOHONLIB(this MonoBehaviour HHILAMLCMPL, float ILLFICGCEEH, Action NECHNJGDBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x42D0FF0", Offset = "0x42CFDF0", VA = "0x1842D0FF0")]
	public static LKIEAODIPPJ IKIDAMMBJAL(this MonoBehaviour HHILAMLCMPL, float ILLFICGCEEH, Action NECHNJGDBML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class HLNBNCDPIPG : CDFELPHDNPA
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class LBAHHBHHEKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public HLNBNCDPIPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
		public LBAHHBHHEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x42CB030", Offset = "0x42C9E30", VA = "0x1842CB030")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class FPAGNONHLBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public HLNBNCDPIPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
		public FPAGNONHLBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x42CB030", Offset = "0x42C9E30", VA = "0x1842CB030")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly float IBNFCHLCEIN;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x42CE5B0", Offset = "0x42CD3B0", VA = "0x1842CE5B0")]
	public HLNBNCDPIPG(Behaviour HIKLIFLDMDD, float IBNFCHLCEIN, [Optional] Action KAPLKPOHHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x42CE3F0", Offset = "0x42CD1F0", VA = "0x1842CE3F0", Slot = "9")]
	protected override bool BJDGJPCMHII(Action ILFANDGNKPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x42CE4D0", Offset = "0x42CD2D0", VA = "0x1842CE4D0", Slot = "10")]
	protected override bool GBCFOCJGOCF(Action ILFANDGNKPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JMEHKHCGEOF
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool BGKPDGMDFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action DEBBMOIAMLE;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HGMMMCKMPGH(bool DCDMHGCJNKM = false);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HGMMMCKMPGH(Action ILFANDGNKPL, bool DCDMHGCJNKM = false);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class CDFELPHDNPA : JMEHKHCGEOF
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class JHHMKPDKELJ : IEnumerator<CNLGKCMJFDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private CNLGKCMJFDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private CNLGKCMJFDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
		[DebuggerHidden]
		public JHHMKPDKELJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x42CEE70", Offset = "0x42CDC70", VA = "0x1842CEE70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x42CEF10", Offset = "0x42CDD10", VA = "0x1842CEF10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly Behaviour HIKLIFLDMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Action KAPLKPOHHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private GOOMHOMPGHO EBGLCHMEJDL;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool BGKPDGMDFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D90", Offset = "0x6A0B90", VA = "0x1806A1D90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action DEBBMOIAMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x42C69D0", Offset = "0x42C57D0", VA = "0x1842C69D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x42C6750", Offset = "0x42C5550", VA = "0x1842C6750", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x42C6C50", Offset = "0x42C5A50", VA = "0x1842C6C50")]
	protected CDFELPHDNPA(Behaviour HIKLIFLDMDD, [Optional] Action KAPLKPOHHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x42C6B40", Offset = "0x42C5940", VA = "0x1842C6B40", Slot = "7")]
	public bool HGMMMCKMPGH(bool DCDMHGCJNKM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x42C6AF0", Offset = "0x42C58F0", VA = "0x1842C6AF0", Slot = "8")]
	public bool HGMMMCKMPGH(Action ILFANDGNKPL, bool DCDMHGCJNKM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool BJDGJPCMHII(Action ILFANDGNKPL);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool GBCFOCJGOCF(Action ILFANDGNKPL);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x42C6A70", Offset = "0x42C5870", VA = "0x1842C6A70")]
	protected void FKDKLNNGJCE(Action ILFANDGNKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x42C67F0", Offset = "0x42C55F0", VA = "0x1842C67F0")]
	protected CFGFLPOGNPH BNJFOJFMPMO(float CCGLHJBNEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x42C6BE0", Offset = "0x42C59E0", VA = "0x1842C6BE0")]
	private void JFAGGAMMPHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x42C6A90", Offset = "0x42C5890", VA = "0x1842C6A90")]
	[IteratorStateMachine(typeof(JHHMKPDKELJ))]
	private static IEnumerator<CNLGKCMJFDJ> FKIJPNHBIFK(float CCGLHJBNEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x42C6BA0", Offset = "0x42C59A0", VA = "0x1842C6BA0")]
	[CompilerGenerated]
	private void HPKNNCIFDJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class FIEAALCLABD : CDFELPHDNPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly float HIJIIHOFJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int HJCDJCKJAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly float BMJMBAOCCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly float[] DCEKNINNOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private int JCFGFDHENLM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public LFMHCPJIPGL GBLDHLOAGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x511A30", Offset = "0x510830", VA = "0x180511A30")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5AE660", Offset = "0x5AD460", VA = "0x1805AE660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x42CA4D0", Offset = "0x42C92D0", VA = "0x1842CA4D0")]
	public FIEAALCLABD(Behaviour HIKLIFLDMDD, float BPGHAAPJNLM, int HJCDJCKJAPG, [Optional] Action KAPLKPOHHIH, float BMJMBAOCCGG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EC0", Offset = "0x4E8CC0", VA = "0x1804E9EC0", Slot = "9")]
	protected override bool BJDGJPCMHII(Action ILFANDGNKPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x42CA220", Offset = "0x42C9020", VA = "0x1842CA220", Slot = "10")]
	protected override bool GBCFOCJGOCF(Action ILFANDGNKPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x42CA440", Offset = "0x42C9240", VA = "0x1842CA440")]
	private void GMANKKMLIAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class IPAHFPIJFML : CDFELPHDNPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly float IBNFCHLCEIN;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x42CE5B0", Offset = "0x42CD3B0", VA = "0x1842CE5B0")]
	public IPAHFPIJFML(Behaviour HIKLIFLDMDD, float IBNFCHLCEIN, [Optional] Action KAPLKPOHHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EC0", Offset = "0x4E8CC0", VA = "0x1804E9EC0", Slot = "9")]
	protected override bool BJDGJPCMHII(Action ILFANDGNKPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x42CED70", Offset = "0x42CDB70", VA = "0x1842CED70", Slot = "10")]
	protected override bool GBCFOCJGOCF(Action ILFANDGNKPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class BLGNDGPKNBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class DOKPHNIDKJB : IEnumerator<CNLGKCMJFDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private CNLGKCMJFDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private CNLGKCMJFDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
		[DebuggerHidden]
		public DOKPHNIDKJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x42C8EC0", Offset = "0x42C7CC0", VA = "0x1842C8EC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x42C8FC0", Offset = "0x42C7DC0", VA = "0x1842C8FC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private LKIEAODIPPJ FLIEHHKBGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private JHJJCGPNGCI HIKLIFLDMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Action PJLECLKEBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action<float> NNHFHHJBMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float NOJLCHJOHMG;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x42C6080", Offset = "0x42C4E80", VA = "0x1842C6080")]
	public BLGNDGPKNBE(JHJJCGPNGCI HIKLIFLDMDD, Action PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x42C6240", Offset = "0x42C5040", VA = "0x1842C6240")]
	public BLGNDGPKNBE(JHJJCGPNGCI HIKLIFLDMDD, Action<float> PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x42C6400", Offset = "0x42C5200", VA = "0x1842C6400")]
	public BLGNDGPKNBE(JHJJCGPNGCI HIKLIFLDMDD, float KJBKODPGFKF, Action<float> PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x42C5CE0", Offset = "0x42C4AE0", VA = "0x1842C5CE0")]
	private void MCHKEDIBOHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x42C5E70", Offset = "0x42C4C70", VA = "0x1842C5E70")]
	private void MEDEKOIONBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x42C5A40", Offset = "0x42C4840", VA = "0x1842C5A40")]
	private void CNJNCANBMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x42C5910", Offset = "0x42C4710", VA = "0x1842C5910")]
	private void BFEMCAOJJML(string DKOKBNBNGCD, Action OALHENKFFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x42C58A0", Offset = "0x42C46A0", VA = "0x1842C58A0")]
	[IteratorStateMachine(typeof(DOKPHNIDKJB))]
	private IEnumerator<CNLGKCMJFDJ> AMCHBIEMMOO(Action OALHENKFFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x42C5B80", Offset = "0x42C4980", VA = "0x1842C5B80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x42C6000", Offset = "0x42C4E00", VA = "0x1842C6000")]
	[CompilerGenerated]
	private void NAAPAOAIIAA(string KCOCMOEHLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x42C5C60", Offset = "0x42C4A60", VA = "0x1842C5C60")]
	[CompilerGenerated]
	private void KBKNJBJCMHE(string KCOCMOEHLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x42C5BE0", Offset = "0x42C49E0", VA = "0x1842C5BE0")]
	[CompilerGenerated]
	private void KAKFDJGIEMH(string KCOCMOEHLHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class HHCMGFFHPDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class EKLJBKEPDIE : IEnumerator<CNLGKCMJFDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private CNLGKCMJFDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private CNLGKCMJFDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
		[DebuggerHidden]
		public EKLJBKEPDIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x42C96B0", Offset = "0x42C84B0", VA = "0x1842C96B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x42C97B0", Offset = "0x42C85B0", VA = "0x1842C97B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private LKIEAODIPPJ FLIEHHKBGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private MonoBehaviour HHILAMLCMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Action PJLECLKEBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Action<float> NNHFHHJBMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private float NOJLCHJOHMG;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x42CDEB0", Offset = "0x42CCCB0", VA = "0x1842CDEB0")]
	public HHCMGFFHPDI(MonoBehaviour HHILAMLCMPL, Action PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x42CE070", Offset = "0x42CCE70", VA = "0x1842CE070")]
	public HHCMGFFHPDI(MonoBehaviour HHILAMLCMPL, Action<float> PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x42CE230", Offset = "0x42CD030", VA = "0x1842CE230")]
	public HHCMGFFHPDI(MonoBehaviour HHILAMLCMPL, float KJBKODPGFKF, Action<float> PJLECLKEBMK, IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x42CDB10", Offset = "0x42CC910", VA = "0x1842CDB10")]
	private void MCHKEDIBOHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x42CDCA0", Offset = "0x42CCAA0", VA = "0x1842CDCA0")]
	private void MEDEKOIONBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x42CD870", Offset = "0x42CC670", VA = "0x1842CD870")]
	private void CNJNCANBMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x42CD740", Offset = "0x42CC540", VA = "0x1842CD740")]
	private void BFEMCAOJJML(string DKOKBNBNGCD, Action OALHENKFFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x42CD6D0", Offset = "0x42CC4D0", VA = "0x1842CD6D0")]
	[IteratorStateMachine(typeof(EKLJBKEPDIE))]
	private IEnumerator<CNLGKCMJFDJ> AMCHBIEMMOO(Action OALHENKFFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x42CD9B0", Offset = "0x42CC7B0", VA = "0x1842CD9B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x42CDE30", Offset = "0x42CCC30", VA = "0x1842CDE30")]
	[CompilerGenerated]
	private void NAAPAOAIIAA(string KCOCMOEHLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x42CDA90", Offset = "0x42CC890", VA = "0x1842CDA90")]
	[CompilerGenerated]
	private void KBKNJBJCMHE(string KCOCMOEHLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x42CDA10", Offset = "0x42CC810", VA = "0x1842CDA10")]
	[CompilerGenerated]
	private void KAKFDJGIEMH(string KCOCMOEHLHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FNGKDGDHGHN
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int HMMFJFJGEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class PINMEEOOLEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public static readonly PINMEEOOLEM ELDLOEJKCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Action ONOGCPKNBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool HNGENBNLPJL;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5AB430", Offset = "0x5AA230", VA = "0x1805AB430")]
	public PINMEEOOLEM(Action ONOGCPKNBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x42D4320", Offset = "0x42D3120", VA = "0x1842D4320", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface OCBECKBAJHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T KIKNELACDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable HFOJMNJJDKP(Action<T> ILGDFEECKHB);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable HFOJMNJJDKP(UnityEngine.Object HIKLIFLDMDD, Action<T> ILGDFEECKHB);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GANPNEBIGHE<T> : global::OCBECKBAJHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T KIKNELACDKF
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class HFGPPIOADFL<T> : global::GANPNEBIGHE<T>, global::OCBECKBAJHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class GCOJNGFKEDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public global::HFGPPIOADFL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public global::HCFKNBPBOCD<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x1819380", Offset = "0x1818180", VA = "0x181819380")]
		public GCOJNGFKEDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x32FB9D0", Offset = "0x32FA7D0", VA = "0x1832FB9D0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static GameObject FFIILBELMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly List<global::HCFKNBPBOCD<UnityEngine.Object, Action<T>>> ENMJECCLHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private T AKHDOLFAGID;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object HDBMFBEHAPF
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3304920", Offset = "0x3303720", VA = "0x183304920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T KIKNELACDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x60B5E0", Offset = "0x60A3E0", VA = "0x18060B5E0", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3304B30", Offset = "0x3303930", VA = "0x183304B30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3304340", Offset = "0x3303140", VA = "0x183304340")]
	private static bool CCCAOLAFLIK(T DLIIJNBGOGA, T DPEJHFONKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3305370", Offset = "0x3304170", VA = "0x183305370")]
	public HFGPPIOADFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x33052D0", Offset = "0x33040D0", VA = "0x1833052D0")]
	public HFGPPIOADFL(T MBCACELDKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x3304C50", Offset = "0x3303A50", VA = "0x183304C50")]
	public void KMDOMMMIKAL(T CODKHPDCHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3304540", Offset = "0x3303340", VA = "0x183304540", Slot = "7")]
	public IDisposable HFOJMNJJDKP(Action<T> ILGDFEECKHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x33045B0", Offset = "0x33033B0", VA = "0x1833045B0", Slot = "8")]
	public IDisposable HFOJMNJJDKP(UnityEngine.Object HIKLIFLDMDD, Action<T> ILGDFEECKHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3304C70", Offset = "0x3303A70", VA = "0x183304C70")]
	private void MBFKIPHIEKM()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<JJGCHLNGGNF, Scheduler>, JJGCHLNGGNF
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class BJCKCIDPBAF : FNGKDGDHGHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public ODHHIIIIPLM KLIOKPLMDHM;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int HMMFJFJGEGG
			{
				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x4E9ED0", Offset = "0x4E8CD0", VA = "0x1804E9ED0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x4E9EE0", Offset = "0x4E8CE0", VA = "0x1804E9EE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x42C5660", Offset = "0x42C4460", VA = "0x1842C5660")]
			public static CNLGKCMJFDJ PAIMNFEGFBP(IEnumerator<CNLGKCMJFDJ> PPKEAFKGODK, JDBDOILJEFE JHMDHJLPMED)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x42C57C0", Offset = "0x42C45C0", VA = "0x1842C57C0")]
			public CNLGKCMJFDJ PAIMNFEGFBP(JDBDOILJEFE[] KKFBJNBLDHB, IEnumerator<CNLGKCMJFDJ>[] HAKBNDAIMFF, CNLGKCMJFDJ[] KLEFMPBHPKN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x42C5490", Offset = "0x42C4290", VA = "0x1842C5490")]
			public void BPJEFPHDCEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x42C5590", Offset = "0x42C4390", VA = "0x1842C5590")]
			public void OKADEMHHPKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x42C54C0", Offset = "0x42C42C0", VA = "0x1842C54C0")]
			public void DGGCCHHHLGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x42C5490", Offset = "0x42C4290", VA = "0x1842C5490")]
			public void JJBLBCOKMKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
			public BJCKCIDPBAF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class ODHHIIIIPLM
		{
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct JLKEJDMNGAM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public BJCKCIDPBAF EHHMCJPMPKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public JHJJCGPNGCI JFGLNFMLNDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public JDBDOILJEFE IFJLINHCBPD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public IEnumerator<CNLGKCMJFDJ> COLMIEFLKOI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public CNLGKCMJFDJ BDOFHIDINOH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public LOLOPPMMLCA OCBJEPECDEK;
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			public struct MLDMLFEBODC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public IFDJCGPOIOM.MEJCFHGJGNC HJJLENEGOEP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public List<JLKEJDMNGAM> OJMFGMGKFCB;
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class HFNHKGMCFCE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public ODHHIIIIPLM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public JHJJCGPNGCI context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public BJCKCIDPBAF routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public LOLOPPMMLCA coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public JDBDOILJEFE promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public CNLGKCMJFDJ currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public IEnumerator<CNLGKCMJFDJ> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
				public HFNHKGMCFCE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x42CD020", Offset = "0x42CBE20", VA = "0x1842CD020")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class MHPHPPOOGCN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public BJCKCIDPBAF schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public ODHHIIIIPLM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
				public MHPHPPOOGCN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x42D0340", Offset = "0x42CF140", VA = "0x1842D0340")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private sealed class PBGBJPBKCBJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public BJCKCIDPBAF schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				public ODHHIIIIPLM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
				public PBGBJPBKCBJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x42D42E0", Offset = "0x42D30E0", VA = "0x1842D42E0")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			[CompilerGenerated]
			private sealed class HLCBNGLNCCK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public BJCKCIDPBAF schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public ODHHIIIIPLM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
				public HLCBNGLNCCK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x42CE3B0", Offset = "0x42CD1B0", VA = "0x1842CE3B0")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private readonly IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private bool[] JDEJDPNPKFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private NativeArray<LOLOPPMMLCA> CGNGHDCKLFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private NativeArray<float> PHIDGINCPMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<int> BANAAKLMGCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<int> BMEMIAPGPAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private NativeArray<int> IAKKJEMNFFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NativeArray<int> MIBHFCPJICA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private NativeArray<int> MKLBNCHKEFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private BJCKCIDPBAF[] HINNBCGEPGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private JDBDOILJEFE[] KKFBJNBLDHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private JHJJCGPNGCI[] DBCIBKPIBBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private IEnumerator<CNLGKCMJFDJ>[] PDDMLFICKFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private CNLGKCMJFDJ[] AHJINCOOEIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int AJNJEJFLNHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private int IFGNJEPLBPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private readonly int LLMOALPEJJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private float MBGGMPOGDAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private EJMDGNILCHD HGIJLEBNNNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private JobHandle EKDIBPHOGIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private List<BJCKCIDPBAF> CBIJGEGJNFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private bool FOMPENOHOHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private List<Action> NMIDOFKHCEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private List<Action> ENLJABCBNKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private bool GFHMKOLFNFL;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public MLDMLFEBODC[] MLDFGCJBPPF
			{
				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0x7E88C0", Offset = "0x7E76C0", VA = "0x1807E88C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int PLNIGPNMIGO
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0xA0AB60", Offset = "0xA09960", VA = "0x180A0AB60")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x42D23D0", Offset = "0x42D11D0", VA = "0x1842D23D0")]
			private static int EMDAOIPGCAG(IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x42D3D90", Offset = "0x42D2B90", VA = "0x1842D3D90")]
			public ODHHIIIIPLM(IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x42D2DC0", Offset = "0x42D1BC0", VA = "0x1842D2DC0")]
			private void KEBCIGFFMFA(ref int BMENGBJJONJ, int PFNBHCNLJPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x42D2400", Offset = "0x42D1200", VA = "0x1842D2400")]
			public void FIOEFDDHGGG(JHJJCGPNGCI HIKLIFLDMDD, CNLGKCMJFDJ IHIINMFHJHD, IEnumerator<CNLGKCMJFDJ> PPKEAFKGODK, JDBDOILJEFE JHMDHJLPMED, [Optional] BJCKCIDPBAF PNDNBNDCDNN, LOLOPPMMLCA AENAOAFALFA = LOLOPPMMLCA.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x42D3BA0", Offset = "0x42D29A0", VA = "0x1842D3BA0")]
			public void OJBNFIAKPMK(IEnumerable<JLKEJDMNGAM> EGIEPELHEKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x42D2880", Offset = "0x42D1680", VA = "0x1842D2880")]
			private JLKEJDMNGAM IKJFMBMIDGA(int FOCFFLJIJEM)
			{
				return default(JLKEJDMNGAM);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x42D2F50", Offset = "0x42D1D50", VA = "0x1842D2F50")]
			private void KGHDDKMFOAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x1E9E9A0", Offset = "0x1E9D7A0", VA = "0x181E9E9A0")]
			private static void BGCLOCKFMKO<T>(int FOCFFLJIJEM, T[] GGOOFCDKHDA, int AHCNLPEMKEN, [Optional] T BFMNDAHNPGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x1E9E980", Offset = "0x1E9D780", VA = "0x181E9E980")]
			private static void BGCLOCKFMKO<T>(int FOCFFLJIJEM, NativeArray<T> GGOOFCDKHDA, int AHCNLPEMKEN, [Optional] T BFMNDAHNPGH) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x42D25E0", Offset = "0x42D13E0", VA = "0x1842D25E0")]
			private void IAELCLLGHAM(IEnumerable<JLKEJDMNGAM> EGIEPELHEKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x42D3AE0", Offset = "0x42D28E0", VA = "0x1842D3AE0")]
			private void OBPKBBHMLNE(JLKEJDMNGAM FELFGJODGNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x42D3820", Offset = "0x42D2620", VA = "0x1842D3820")]
			private CBLJBGOCICB MEOACMKCAEO(int JAAINFLNEFL)
			{
				return default(CBLJBGOCICB);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x42D2100", Offset = "0x42D0F00", VA = "0x1842D2100")]
			public void DBFCBBHHFEC(float JPEGAFPDLAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x42D1FC0", Offset = "0x42D0DC0", VA = "0x1842D1FC0")]
			private void AGBPBGHPDDM(Action DLIIJNBGOGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x42D2560", Offset = "0x42D1360", VA = "0x1842D2560")]
			private void FJPEIKMEGGO(Action DLIIJNBGOGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x42D32C0", Offset = "0x42D20C0", VA = "0x1842D32C0")]
			public void LHGNJPFAHNL(float JPEGAFPDLAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x42D22F0", Offset = "0x42D10F0", VA = "0x1842D22F0")]
			public void DGIEOJPLMLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x42D2D00", Offset = "0x42D1B00", VA = "0x1842D2D00")]
			public void JJBLBCOKMKD(BJCKCIDPBAF FHIMBLPCIGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x42D3760", Offset = "0x42D2560", VA = "0x1842D3760")]
			public void LJIKNNJADPP(BJCKCIDPBAF FHIMBLPCIGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x42D2040", Offset = "0x42D0E40", VA = "0x1842D2040")]
			public void AKMHDCLFFAH(BJCKCIDPBAF FHIMBLPCIGF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile]
		public struct EJMDGNILCHD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			[ReadOnly]
			public float NBBPHFAMLEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			[ReadOnly]
			public int IKIPFPPDJFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private NativeArray<int> FKBHPAEPAJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private NativeArray<int> FFGCPDJAIOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private NativeArray<int> CKOFPLBDKKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			[ReadOnly]
			public NativeArray<LOLOPPMMLCA> BJBBGMBILAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			[ReadOnly]
			public NativeArray<float> BEODLGJIECG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[WriteOnly]
			public NativeArray<int> IAKKJEMNFFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[WriteOnly]
			public NativeArray<int> BANAAKLMGCH;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x42C9380", Offset = "0x42C8180", VA = "0x1842C9380")]
			public static EJMDGNILCHD MEJCIEELJNL(int LMGKECIFJLL, float JPEGAFPDLAN, NativeArray<LOLOPPMMLCA> PCOOAGFDNFP, NativeArray<float> JHEFJCGIAPE, NativeArray<int> FHKAMDFPDCK, NativeArray<int> BIIPALOGNPP, NativeArray<int> LEEGDKPCLBF, NativeArray<int> FFGCPDJAIOE, NativeArray<int> CKOFPLBDKKD)
			{
				return default(EJMDGNILCHD);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x42C92A0", Offset = "0x42C80A0", VA = "0x1842C92A0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x42C91F0", Offset = "0x42C7FF0", VA = "0x1842C91F0")]
			private bool CPFLBICPDIN(int NCKDNOGOLME)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x42C9680", Offset = "0x42C8480", VA = "0x1842C9680")]
			private void OOFKLJHBMPH(NativeArray<int> IODBEAJHMHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x42C9230", Offset = "0x42C8030", VA = "0x1842C9230")]
			private int DELDBHDJMOL(int LLHJEAGGMDM, int GNJAGKPIGCI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x42C9120", Offset = "0x42C7F20", VA = "0x1842C9120")]
			private void BLAPOLLBNPA(NativeArray<int> IODBEAJHMHP, int OKIJEJOMGAF, int INPFABHKGIL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x42C9450", Offset = "0x42C8250", VA = "0x1842C9450")]
			private void MKGCFHMGAFF(NativeArray<int> IODBEAJHMHP, int JDCFLCIODPL, int OFGHNKJLHNK, int HFCBPJDMAFM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private sealed class GOPLDIKNJNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private readonly JDBDOILJEFE JHMDHJLPMED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private readonly Behaviour HIKLIFLDMDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private readonly bool NEHOCILKPPK;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<CNLGKCMJFDJ> COLMIEFLKOI
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x4E91D0", Offset = "0x4E7FD0", VA = "0x1804E91D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x4E9490", Offset = "0x4E8290", VA = "0x1804E9490")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public CNLGKCMJFDJ BDOFHIDINOH
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x4E94A0", Offset = "0x4E82A0", VA = "0x1804E94A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool FKNKAEGOOCP
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x42CCA30", Offset = "0x42CB830", VA = "0x1842CCA30")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool BLKBPECKLJM
			{
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x713930", Offset = "0x712730", VA = "0x180713930")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x2015530", Offset = "0x2014330", VA = "0x182015530")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string EPJAPACKECE
			{
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x4EA010", Offset = "0x4E8E10", VA = "0x1804EA010")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x4EA020", Offset = "0x4E8E20", VA = "0x1804EA020")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float AGIENOLHFLL
			{
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0xF7EDC0", Offset = "0xF7DBC0", VA = "0x180F7EDC0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0xF85620", Offset = "0xF84420", VA = "0x180F85620")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x42CCE80", Offset = "0x42CBC80", VA = "0x1842CCE80")]
			public GOPLDIKNJNI(IEnumerator<CNLGKCMJFDJ> PPKEAFKGODK, Behaviour HIKLIFLDMDD, JDBDOILJEFE JHMDHJLPMED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x42CCBE0", Offset = "0x42CB9E0", VA = "0x1842CCBE0")]
			public CNLGKCMJFDJ PAIMNFEGFBP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x42CCAC0", Offset = "0x42CB8C0", VA = "0x1842CCAC0")]
			public bool IPEJPDCABNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x42CCB50", Offset = "0x42CB950", VA = "0x1842CCB50")]
			public void JJBLBCOKMKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x42CCDF0", Offset = "0x42CBBF0", VA = "0x1842CCDF0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1589260", Offset = "0x1588060", VA = "0x181589260")]
			[CompilerGenerated]
			private void BBNFNONJOOA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class JDBDOILJEFE : ODBLLELBHBJ, LKIEAODIPPJ, GOOMHOMPGHO, CFGFLPOGNPH, IEnumerator, CNLGKCMJFDJ, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private IFDJCGPOIOM.MEJCFHGJGNC CPOMMLNPLJD;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private IFDJCGPOIOM.MEJCFHGJGNC COGOHHFMCMI
			{
				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x50E180", Offset = "0x50CF80", VA = "0x18050E180", Slot = "23")]
				get
				{
					return default(IFDJCGPOIOM.MEJCFHGJGNC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public IFDJCGPOIOM.MEJCFHGJGNC KLIOKPLMDHM
			{
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0x50E180", Offset = "0x50CF80", VA = "0x18050E180")]
				get
				{
					return default(IFDJCGPOIOM.MEJCFHGJGNC);
				}
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x611420", Offset = "0x610220", VA = "0x180611420")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float PPCFMNDGBBD
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(RVA = "0xF55D70", Offset = "0xF54B70", VA = "0x180F55D70", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x42CEDF0", Offset = "0x42CDBF0", VA = "0x1842CEDF0", Slot = "24")]
			private bool JNFBMAEMJHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x42CEDE0", Offset = "0x42CDBE0", VA = "0x1842CEDE0", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x42CEE10", Offset = "0x42CDC10", VA = "0x1842CEE10")]
			public JDBDOILJEFE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private enum CBLJBGOCICB : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private sealed class GFJDMKHGELO : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			public enum DKMJDELPIIO
			{
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			public struct MOFLLHLLAEC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public IFDJCGPOIOM.MEJCFHGJGNC HJJLENEGOEP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				public DKMJDELPIIO CGLHIHHNNAG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public List<GOPLDIKNJNI> DAOHNGKGDNH;
			}

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private static readonly DKMJDELPIIO[] BPJIIPGNEEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private bool FHKHMMMCDED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly GOPLDIKNJNI[] FDPNEKELIIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly List<GOPLDIKNJNI> KCPPDCFKOCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private readonly Stack<int> CIDAHGMHLDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly List<GOPLDIKNJNI> JEMNGODNENE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly Stack<int> ILAKIAALBOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private bool GFHMKOLFNFL;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public MOFLLHLLAEC[,] DHLHIGJIFCF
			{
				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0x4FCD70", Offset = "0x4FBB70", VA = "0x1804FCD70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int PLNIGPNMIGO
			{
				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x42CBFF0", Offset = "0x42CADF0", VA = "0x1842CBFF0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x42CC4C0", Offset = "0x42CB2C0", VA = "0x1842CC4C0")]
			public GFJDMKHGELO(IFDJCGPOIOM.MEJCFHGJGNC GHCBHCFOBHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x42CB5A0", Offset = "0x42CA3A0", VA = "0x1842CB5A0")]
			public void DNOAALGJDAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x42CB6F0", Offset = "0x42CA4F0", VA = "0x1842CB6F0")]
			public void EBGGAEJCPNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x42CBBF0", Offset = "0x42CA9F0", VA = "0x1842CBBF0")]
			private void IPODFJILDMC(IReadOnlyList<GOPLDIKNJNI> LDALDDALEEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x42CB1D0", Offset = "0x42C9FD0", VA = "0x1842CB1D0")]
			public void CMMBJKDGFLA(GOPLDIKNJNI PPKEAFKGODK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x42CC160", Offset = "0x42CAF60", VA = "0x1842CC160")]
			public void PBOECJPLAPL(IList<GOPLDIKNJNI> HAKBNDAIMFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x42CB700", Offset = "0x42CA500", VA = "0x1842CB700")]
			public void GHFFLFEDFGC(IList<GOPLDIKNJNI> HAKBNDAIMFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x42CBD20", Offset = "0x42CAB20", VA = "0x1842CBD20")]
			private void KDABCOKMNOA(GOPLDIKNJNI PPKEAFKGODK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x42CB060", Offset = "0x42C9E60", VA = "0x1842CB060")]
			private void BDCIAPIFMBF(IList<GOPLDIKNJNI> HAKBNDAIMFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x42CB980", Offset = "0x42CA780", VA = "0x1842CB980")]
			private CBLJBGOCICB HIGOKGAIBLD(GOPLDIKNJNI PPKEAFKGODK)
			{
				return default(CBLJBGOCICB);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x42CB2F0", Offset = "0x42CA0F0", VA = "0x1842CB2F0")]
			public void CNIMBBBDAOM(float JPEGAFPDLAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x42CB3A0", Offset = "0x42CA1A0", VA = "0x1842CB3A0")]
			public void DCFLCKIBCPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x42CBE10", Offset = "0x42CAC10", VA = "0x1842CBE10")]
			private void KFHEJPKLMHM(List<GOPLDIKNJNI> HAKBNDAIMFF, Stack<int> JKEBAKAKLGK, bool MJLHMAJDCOF, float EMBNIONADMF = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x42CB5B0", Offset = "0x42CA3B0", VA = "0x1842CB5B0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x42CBAD0", Offset = "0x42CA8D0", VA = "0x1842CBAD0")]
			private void IMCMGDFAKAP(List<GOPLDIKNJNI> HAKBNDAIMFF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[Flags]
		public enum LOLOPPMMLCA : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			Inactive = 0,
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			Running = 1,
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			Cancelled = 2,
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			Paused = 4
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class JLDPHJDBGLB : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
			[DebuggerHidden]
			public JLDPHJDBGLB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x42CEF60", Offset = "0x42CDD60", VA = "0x1842CEF60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x42CEFE0", Offset = "0x42CDDE0", VA = "0x1842CEFE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private const LOLOPPMMLCA HPDPELLJHDI = LOLOPPMMLCA.Cancelled | LOLOPPMMLCA.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly IFDJCGPOIOM.MEJCFHGJGNC[] KNPCCFJPGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private GFJDMKHGELO[] MAGAHMOLOCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private ODHHIIIIPLM[] AAGDCKCFLLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private Coroutine JHFEBILNCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private WaitForEndOfFrame FALADJJNNEJ;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public IFDJCGPOIOM.MEJCFHGJGNC KOIIPCLAGMM
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x570BE0", Offset = "0x56F9E0", VA = "0x180570BE0")]
			[CompilerGenerated]
			get
			{
				return default(IFDJCGPOIOM.MEJCFHGJGNC);
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x5C8790", Offset = "0x5C7590", VA = "0x1805C8790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool KJCPKAFNBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x713630", Offset = "0x712430", VA = "0x180713630", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x18209B0", Offset = "0x181F7B0", VA = "0x1818209B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int PLNIGPNMIGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x42D5D50", Offset = "0x42D4B50", VA = "0x1842D5D50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x42D4B10", Offset = "0x42D3910", VA = "0x1842D4B10")]
		public static LKIEAODIPPJ GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x42D45E0", Offset = "0x42D33E0", VA = "0x1842D45E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x42D4DA0", Offset = "0x42D3BA0", VA = "0x1842D4DA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x42D4BB0", Offset = "0x42D39B0", VA = "0x1842D4BB0")]
		private GFJDMKHGELO HEKALAGAEFO(IFDJCGPOIOM.MEJCFHGJGNC FKELJAJFEHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E410", Offset = "0x2D6D210", VA = "0x182D6E410")]
		private ODHHIIIIPLM HEGEHBJICPC(IFDJCGPOIOM.MEJCFHGJGNC FKELJAJFEHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x42D5260", Offset = "0x42D4060", VA = "0x1842D5260")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x42D5220", Offset = "0x42D4020", VA = "0x1842D5220")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x42D5B20", Offset = "0x42D4920", VA = "0x1842D5B20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x42D4AF0", Offset = "0x42D38F0", VA = "0x1842D4AF0")]
		private void FNCMFANOFMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x42D4D90", Offset = "0x42D3B90", VA = "0x1842D4D90")]
		private void NLMPEBLPKBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x42D4B00", Offset = "0x42D3900", VA = "0x1842D4B00")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x42D4D80", Offset = "0x42D3B80", VA = "0x1842D4D80")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x42D4AE0", Offset = "0x42D38E0", VA = "0x1842D4AE0")]
		private void DMBMDHPGFNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x42D4BF0", Offset = "0x42D39F0", VA = "0x1842D4BF0")]
		[IteratorStateMachine(typeof(JLDPHJDBGLB))]
		private IEnumerator KHMHBBMDGPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x42D5410", Offset = "0x42D4210", VA = "0x1842D5410", Slot = "7")]
		public LKIEAODIPPJ Run(IEnumerator<CNLGKCMJFDJ> NINOFJHCELI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x42D5420", Offset = "0x42D4220", VA = "0x1842D5420", Slot = "8")]
		public LKIEAODIPPJ Run(Behaviour HIKLIFLDMDD, IEnumerator<CNLGKCMJFDJ> NINOFJHCELI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x42D52E0", Offset = "0x42D40E0", VA = "0x1842D52E0", Slot = "9")]
		public LKIEAODIPPJ RunJobbed(JHJJCGPNGCI HIKLIFLDMDD, IEnumerator<CNLGKCMJFDJ> NINOFJHCELI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x42D4A80", Offset = "0x42D3880", VA = "0x1842D4A80", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x42D5650", Offset = "0x42D4450", VA = "0x1842D5650")]
		public void UpdateQueue(IFDJCGPOIOM.MEJCFHGJGNC KLKMFMNPJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x42D4420", Offset = "0x42D3220", VA = "0x1842D4420")]
		private void AKIPFKMIFME(GFJDMKHGELO PJMDINHKJNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x42D4C60", Offset = "0x42D3A60", VA = "0x1842D4C60")]
		private void LGIGHNCKIAE(ODHHIIIIPLM PJMDINHKJNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x42D5CE0", Offset = "0x42D4AE0", VA = "0x1842D5CE0")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class IHDAOHAAJCL
{
	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x42CECE0", Offset = "0x42CDAE0", VA = "0x1842CECE0")]
	[BFHGDHHFNJL]
	private static void BDHCIKJGEKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class LFAGENEOGML : LFMHCPJIPGL
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float BJBNDHIJMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x42CF830", Offset = "0x42CE630", VA = "0x1842CF830", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float LIPPLGAKIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x42CF840", Offset = "0x42CE640", VA = "0x1842CF840", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float CFLNCHFMGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x42CF800", Offset = "0x42CE600", VA = "0x1842CF800", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int MANIGEKHBCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x42CF7F0", Offset = "0x42CE5F0", VA = "0x1842CF7F0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double LCICEIMHMGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x42CF810", Offset = "0x42CE610", VA = "0x1842CF810", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
	public LFAGENEOGML()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class KBKCNEEIGLD
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static byte[] HKOBKFJLJAG;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static int ADAIBBEDLAL;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static int PDJAKEHAIFF;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static BigInteger NCCPNIBEFHO;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
	public KBKCNEEIGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x42CF360", Offset = "0x42CE160", VA = "0x1842CF360")]
	private static string PLNBGBJHHON(byte[] DPEJHFONKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x42CF030", Offset = "0x42CDE30", VA = "0x1842CF030")]
	public static string GFPOJAMMFIA(byte[] EMAHDMOPMEP, bool FCMNFAHODMM)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
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

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
		private delegate List<PlayerLoopSystem> IFKJLDKJGKH(List<PlayerLoopSystem> COAJNDPBMPC, int BDBIHLOIBIH);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct CLLFKJEIAED
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct HLFAGECCNCN
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static CMKPDMCLCCC MDPGKOFHNPH;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x4080110", Offset = "0x407ED10", VA = "0x184080110")]
				public static PlayerLoopSystem MBMHPEKNCPH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct OBLENOFMDFO
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static CMKPDMCLCCC EOKHLHFDNKI;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x4088C70", Offset = "0x4087870", VA = "0x184088C70")]
				public static PlayerLoopSystem MBMHPEKNCPH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct HJMKAGKGIOL
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static CMKPDMCLCCC EOPMNKDFBKN;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x407FE80", Offset = "0x407EA80", VA = "0x18407FE80")]
				public static PlayerLoopSystem MBMHPEKNCPH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			internal struct BLBOLLJFFHO
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				[CompilerGenerated]
				private sealed class OIFBDKGGEDK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000C")]
					public LEENKBNDBCJ.PEMBADFHFKI key;

					[Cpp2IlInjected.Token(Token = "0x600001B")]
					[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
					public OIFBDKGGEDK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600001C")]
					[Cpp2IlInjected.Address(RVA = "0x4088F00", Offset = "0x4087B00", VA = "0x184088F00")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDisposable CINLKAKEEPH;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x407BCB0", Offset = "0x407A8B0", VA = "0x18407BCB0")]
				public static PlayerLoopSystem PJKOIBJFBAE(LEENKBNDBCJ.PEMBADFHFKI FHJAGMPOINB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct LMCJLDNOAAL
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class IDBBMLHKONH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000D")]
					public LEENKBNDBCJ.PEMBADFHFKI key;

					[Cpp2IlInjected.Token(Token = "0x600001E")]
					[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
					public IDBBMLHKONH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600001F")]
					[Cpp2IlInjected.Address(RVA = "0x4080920", Offset = "0x407F520", VA = "0x184080920")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x4084540", Offset = "0x4083140", VA = "0x184084540")]
				public static PlayerLoopSystem PJKOIBJFBAE(LEENKBNDBCJ.PEMBADFHFKI FHJAGMPOINB)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JLHAIBJGOIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
			public JLHAIBJGOIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x40825E0", Offset = "0x40811E0", VA = "0x1840825E0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool EGPILOLIIEJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool GICOAFDCAMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x407CD00", Offset = "0x407B900", VA = "0x18407CD00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x407D310", Offset = "0x407BF10", VA = "0x18407D310")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x407BDB0", Offset = "0x407A9B0", VA = "0x18407BDB0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x407D0B0", Offset = "0x407BCB0", VA = "0x18407D0B0")]
		private static void NFAJJENHJCL(LEENKBNDBCJ.PEMBADFHFKI FHJAGMPOINB, ref PlayerLoopSystem PDCOMKENHFL, Type MJGBNKJHBPJ, Type EPGJCCMMNIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x407CD40", Offset = "0x407B940", VA = "0x18407CD40")]
		private static void KDDEAIHHCBL(ref PlayerLoopSystem PDCOMKENHFL, Type MJGBNKJHBPJ, Type EPGJCCMMNIN, IFKJLDKJGKH CBCBPNEFOFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x407CC00", Offset = "0x407B800", VA = "0x18407CC00")]
		private static void BKBHNGOHLEA(ref PlayerLoopSystem PDCOMKENHFL, Type MJGBNKJHBPJ, Type EPGJCCMMNIN, PlayerLoopSystem? PADLOOJPKOO, PlayerLoopSystem? ELNMCPDDPEJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LEENKBNDBCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum PEMBADFHFKI
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
	public class MDCKLDKGMMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly PEMBADFHFKI FDGBKPDFPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly HNKOBHKBBKH BJOBMHHPBEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long ADGAIKNJMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long JILABNNGHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public long CKMMPKIDGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int PBBIJMFPFMM;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4084B40", Offset = "0x4083740", VA = "0x184084B40")]
		public MDCKLDKGMMF(PEMBADFHFKI BCHEAEPANLA, int AMEMOCLDJEH = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4084B20", Offset = "0x4083720", VA = "0x184084B20")]
		public void MDILKBCEJNO(int HBIAMOGLKHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4084AB0", Offset = "0x40836B0", VA = "0x184084AB0")]
		public void MCGIKJJNGFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4084A50", Offset = "0x4083650", VA = "0x184084A50")]
		public void IICKBFFEGNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x40847E0", Offset = "0x40833E0", VA = "0x1840847E0")]
		public void FGFJEBBDCCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x40849B0", Offset = "0x40835B0", VA = "0x1840849B0")]
		public double FIPIFPIDFKE(int JAGBKOICDIK)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int ELAFOELCGMB = 90;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static PEMBADFHFKI[] PBPCHLGJKJP;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static MDCKLDKGMMF[] LKIECDOHHGP;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x40836F0", Offset = "0x40822F0", VA = "0x1840836F0")]
	public static MDCKLDKGMMF BHAMPCDJLLK(PEMBADFHFKI FHJAGMPOINB, int AMEMOCLDJEH = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4083880", Offset = "0x4082480", VA = "0x184083880")]
	public static MDCKLDKGMMF OHEMOHCPCOB(PEMBADFHFKI FHJAGMPOINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4083640", Offset = "0x4082240", VA = "0x184083640")]
	public static void BAIBNNPHMAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HNKOBHKBBKH : KIDAAFICDCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int PCLNAIPNMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Queue<double> KEHHFEPMICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private double AKJFHADOMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private double FFOMHBMMIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private double HMPGCFGDNBE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int PINGLAKHECO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4080380", Offset = "0x407EF80", VA = "0x184080380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double GHEGLFKJNEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4080320", Offset = "0x407EF20", VA = "0x184080320", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double HPHGENGFHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xCF3960", Offset = "0xCF2560", VA = "0x180CF3960", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double KEAOAGAPHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2DD55C0", Offset = "0x2DD41C0", VA = "0x182DD55C0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x40804C0", Offset = "0x407F0C0", VA = "0x1840804C0")]
	public HNKOBHKBBKH(int EEJCFKPIADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x40803C0", Offset = "0x407EFC0", VA = "0x1840803C0", Slot = "4")]
	public void POOMEPBEFOP(double JBIHNBPKHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x40802B0", Offset = "0x407EEB0", VA = "0x1840802B0", Slot = "5")]
	public void GEHNIDOEIAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OPANJMNFBIM : KIDAAFICDCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private long JKLNJDDKIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double HOEMIKLPEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double KGEKKCAHALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double IPLDLBBCBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double HDOPMMBOLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double AKJFHADOMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double FFOMHBMMIGK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long EIKCLJIDIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BEDA0", VA = "0x1804C01A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double HPHGENGFHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x314C9B0", Offset = "0x314B5B0", VA = "0x18314C9B0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double KEAOAGAPHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84DC00", Offset = "0x84C800", VA = "0x18084DC00", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double HJAADNMHOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2DD55C0", Offset = "0x2DD41C0", VA = "0x182DD55C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double GEIGFACGMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2DD55B0", Offset = "0x2DD41B0", VA = "0x182DD55B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double GHEGLFKJNEE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x314C8E0", Offset = "0x314B4E0", VA = "0x18314C8E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4089130", Offset = "0x4087D30", VA = "0x184089130", Slot = "4")]
	public void POOMEPBEFOP(double JBIHNBPKHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x40890F0", Offset = "0x4087CF0", VA = "0x1840890F0", Slot = "5")]
	public void GEHNIDOEIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4089250", Offset = "0x4087E50", VA = "0x184089250")]
	public OPANJMNFBIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KIDAAFICDCI
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double GHEGLFKJNEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double HPHGENGFHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double KEAOAGAPHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POOMEPBEFOP(double JBIHNBPKHCE);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEHNIDOEIAA();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class BDJMMGMLAAA
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private interface DBMCKAGFMCK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool KNEILCIDEOF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AIEGELIBFMG();

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GLPJGPDFKPO();
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class GJEDLNFNCHP<TPromise, TMainThreadPromise> : DBMCKAGFMCK where TPromise : DPJKDCDGPPB where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly TPromise MDKJDNGMIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		protected readonly TMainThreadPromise AFNFGCNCJHE;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise KGPDOOLBFLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x1D73530", Offset = "0x1D72130", VA = "0x181D73530")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool KNEILCIDEOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x1D73590", Offset = "0x1D72190", VA = "0x181D73590", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1D73640", Offset = "0x1D72240", VA = "0x181D73640")]
		protected GJEDLNFNCHP(TPromise MDKJDNGMIAL, TMainThreadPromise HGNDCOGFMOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1D734D0", Offset = "0x1D720D0", VA = "0x181D734D0", Slot = "5")]
		public void AIEGELIBFMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1D73500", Offset = "0x1D72100", VA = "0x181D73500", Slot = "6")]
		public void GLPJGPDFKPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void FAABBDOIOGO(TPromise MDKJDNGMIAL);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void IONODEGIDEA();
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class HOHPFAAFNHO<T> : GJEDLNFNCHP<global::JLPBMLKOEIK<T>, global::LPMDECKDEDF<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1D755A0", Offset = "0x1D741A0", VA = "0x181D755A0")]
		public HOHPFAAFNHO(global::JLPBMLKOEIK<T> MDKJDNGMIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1D75390", Offset = "0x1D73F90", VA = "0x181D75390", Slot = "7")]
		protected override void FAABBDOIOGO(global::JLPBMLKOEIK<T> MDKJDNGMIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1D75510", Offset = "0x1D74110", VA = "0x181D75510", Slot = "8")]
		protected override void IONODEGIDEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1D75570", Offset = "0x1D74170", VA = "0x181D75570")]
		[CompilerGenerated]
		private void KCMOHMBACNA(T PKOHMGJOJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1D754E0", Offset = "0x1D740E0", VA = "0x181D754E0")]
		[CompilerGenerated]
		private void GACAMIBNKAH(string FPODCKNNJGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class DBLFKHDMENF : GJEDLNFNCHP<DPJKDCDGPPB, PPHLALBGLJF>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x407D470", Offset = "0x407C070", VA = "0x18407D470")]
		public DBLFKHDMENF(DPJKDCDGPPB MDKJDNGMIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x407D350", Offset = "0x407BF50", VA = "0x18407D350", Slot = "7")]
		protected override void FAABBDOIOGO(DPJKDCDGPPB MDKJDNGMIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x407D420", Offset = "0x407C020", VA = "0x18407D420", Slot = "8")]
		protected override void IONODEGIDEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x18407C0", Offset = "0x183F3C0", VA = "0x1818407C0")]
		[CompilerGenerated]
		private void KCMOHMBACNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x169B310", Offset = "0x1699F10", VA = "0x18169B310")]
		[CompilerGenerated]
		private void GACAMIBNKAH(string FPODCKNNJGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class KPBBMEOLDFM : DBMCKAGFMCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Action EPGIBOENJMJ;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool KNEILCIDEOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4C0F60", Offset = "0x4BFB60", VA = "0x1804C0F60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x59C930", Offset = "0x59B530", VA = "0x18059C930")]
		public KPBBMEOLDFM(Action EPGIBOENJMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x14DFCB0", Offset = "0x14DE8B0", VA = "0x1814DFCB0", Slot = "5")]
		public void AIEGELIBFMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "6")]
		public void GLPJGPDFKPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly List<DBMCKAGFMCK> JAMHNHBALBO;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x20E80F0", Offset = "0x20E6CF0", VA = "0x1820E80F0")]
	public static global::JLPBMLKOEIK<T> AMLJLCKECNK<T>(this global::JLPBMLKOEIK<T> MDKJDNGMIAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x407A340", Offset = "0x4078F40", VA = "0x18407A340")]
	public static DPJKDCDGPPB AMLJLCKECNK(this DPJKDCDGPPB MDKJDNGMIAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x407A450", Offset = "0x4079050", VA = "0x18407A450")]
	public static void AMLJLCKECNK(Action EPGIBOENJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x20E8160", Offset = "0x20E6D60", VA = "0x1820E8160")]
	private static global::JLPBMLKOEIK<T> DDDKPAKKFGP<T>(global::JLPBMLKOEIK<T> MDKJDNGMIAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x407A970", Offset = "0x4079570", VA = "0x18407A970")]
	private static DPJKDCDGPPB DDDKPAKKFGP(DPJKDCDGPPB MDKJDNGMIAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x407AA50", Offset = "0x4079650", VA = "0x18407AA50")]
	private static void LLGBGMDFMIC(DBMCKAGFMCK CFCLHKBDGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x407A650", Offset = "0x4079250", VA = "0x18407A650")]
	private static void CIOPJICIJND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x407A580", Offset = "0x4079180", VA = "0x18407A580")]
	private static void BHKPNJDEHBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x407A4D0", Offset = "0x40790D0", VA = "0x18407A4D0")]
	private static void BCLOADHKHHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class ECEPLEFNPIC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PDHHODPDIEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public PPHLALBGLJF onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
		public PDHHODPDIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4089290", Offset = "0x4087E90", VA = "0x184089290")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4089280", Offset = "0x4087E80", VA = "0x184089280")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class BJFEMOCCFCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
		public BJFEMOCCFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x407BC80", Offset = "0x407A880", VA = "0x18407BC80")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PLPNNJJLMLL : IEnumerator<MDIGCEIKMFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private MDIGCEIKMFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PPHLALBGLJF onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private MDIGCEIKMFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
		[DebuggerHidden]
		public PLPNNJJLMLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4089870", Offset = "0x4088470", VA = "0x184089870", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x40895A0", Offset = "0x40881A0", VA = "0x1840895A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4089920", Offset = "0x4088520", VA = "0x184089920")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4089820", Offset = "0x4088420", VA = "0x184089820", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PFPIEBBPNEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public PPHLALBGLJF onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
		public PFPIEBBPNEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LBKOGHHLMMM : IEnumerator<MDIGCEIKMFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private MDIGCEIKMFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public PPHLALBGLJF onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private PFPIEBBPNEG <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private MDIGCEIKMFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
		[DebuggerHidden]
		public LBKOGHHLMMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x40832A0", Offset = "0x4081EA0", VA = "0x1840832A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x40835F0", Offset = "0x40821F0", VA = "0x1840835F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const string DPFMMKBEJCG = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const string BIPLMFGKGKN = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public const string EIHLDIMIHAI = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string AFCPOAIFJKN = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string DCIHLEKPAHM = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float DNNCEIFDKDK = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static DPJKDCDGPPB GGFNKPEBGGP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static AsyncOperation LDJDEGGEDAA;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static DPJKDCDGPPB PJELLJDMBDB;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static string FGBLOMBHFHL;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static ThreadPriority AIKPIGCEBOD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool CHDFGEJLMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x407F430", Offset = "0x407E030", VA = "0x18407F430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool CHMKHIBBGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x407F6D0", Offset = "0x407E2D0", VA = "0x18407F6D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool ELNLBAECPNF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x407F670", Offset = "0x407E270", VA = "0x18407F670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> LLDJPIPDHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x407F5C0", Offset = "0x407E1C0", VA = "0x18407F5C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x407FA80", Offset = "0x407E680", VA = "0x18407FA80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x407F940", Offset = "0x407E540", VA = "0x18407F940")]
	public static DPJKDCDGPPB NMENOOGFBPM(string DLHFCONFFBG, LoadSceneMode NIHJNPAEBKB = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x407F730", Offset = "0x407E330", VA = "0x18407F730")]
	public static DPJKDCDGPPB LFCECJLBACL(string DLHFCONFFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x407F550", Offset = "0x407E150", VA = "0x18407F550")]
	[IteratorStateMachine(typeof(PLPNNJJLMLL))]
	private static IEnumerator<MDIGCEIKMFK> DKNOFNPBNHJ(string DLHFCONFFBG, PPHLALBGLJF EPMPMADLHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x407F4D0", Offset = "0x407E0D0", VA = "0x18407F4D0")]
	[IteratorStateMachine(typeof(LBKOGHHLMMM))]
	private static IEnumerator<MDIGCEIKMFK> BNAECNFFPGB(string DLHFCONFFBG, LoadSceneMode NIHJNPAEBKB, PPHLALBGLJF EPMPMADLHFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LIAPBGMOFAD
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4083DC0", Offset = "0x40829C0", VA = "0x184083DC0")]
	public static IDisposable CNKGJDGMOIN(this IBNJGIOKIDC GHILNBJMAHO, Action MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4083C00", Offset = "0x4082800", VA = "0x184083C00")]
	public static IDisposable CNKGJDGMOIN(this IBNJGIOKIDC GHILNBJMAHO, Action<float> MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4084130", Offset = "0x4082D30", VA = "0x184084130")]
	public static IDisposable HILJGAPHIHO(this IBNJGIOKIDC GHILNBJMAHO, Action MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4083F50", Offset = "0x4082B50", VA = "0x184083F50")]
	public static IDisposable EIJAAGFEOLL(this IBNJGIOKIDC GHILNBJMAHO, Action MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4084040", Offset = "0x4082C40", VA = "0x184084040")]
	public static IDisposable GMOAOHPMJOL(this IBNJGIOKIDC GHILNBJMAHO, Action MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4083A90", Offset = "0x4082690", VA = "0x184083A90")]
	public static IDisposable BANIAIJPCJI(this IBNJGIOKIDC GHILNBJMAHO, Action MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4083A20", Offset = "0x4082620", VA = "0x184083A20")]
	public static IDisposable APEAFDOMFJH(this IBNJGIOKIDC GHILNBJMAHO, Action MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4084220", Offset = "0x4082E20", VA = "0x184084220")]
	public static IDisposable JMNCMOACDPP(this IBNJGIOKIDC GHILNBJMAHO, float HGGFBFMNMBF, Action<float> MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4084430", Offset = "0x4083030", VA = "0x184084430")]
	public static IDisposable LHGFAFNJLKD(this IBNJGIOKIDC GHILNBJMAHO, float HGGFBFMNMBF, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x40841A0", Offset = "0x4082DA0", VA = "0x1840841A0")]
	public static IDisposable IJHCGGLGMKC(this IBNJGIOKIDC GHILNBJMAHO, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4083B00", Offset = "0x4082700", VA = "0x184083B00")]
	public static IDisposable BGMNKBFPGIB(this IBNJGIOKIDC GHILNBJMAHO, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4083B80", Offset = "0x4082780", VA = "0x184083B80")]
	public static IDisposable BNJHJKLMMFB(this IBNJGIOKIDC GHILNBJMAHO, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4083E40", Offset = "0x4082A40", VA = "0x184083E40")]
	public static IDisposable DGGGPPHONKI(this IBNJGIOKIDC GHILNBJMAHO, float HGGFBFMNMBF, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4084330", Offset = "0x4082F30", VA = "0x184084330")]
	public static IDisposable KPNIEEBCLFF(this IBNJGIOKIDC GHILNBJMAHO, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4083ED0", Offset = "0x4082AD0", VA = "0x184083ED0")]
	public static IDisposable DIIEPJFJDLI(this IBNJGIOKIDC GHILNBJMAHO, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x40840B0", Offset = "0x4082CB0", VA = "0x1840840B0")]
	public static IDisposable HAADNPIFFCI(this IBNJGIOKIDC GHILNBJMAHO, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x40844B0", Offset = "0x40830B0", VA = "0x1840844B0")]
	public static IDisposable OHBKOAFBPJH(this IBNJGIOKIDC GHILNBJMAHO, float HGGFBFMNMBF, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x40842B0", Offset = "0x4082EB0", VA = "0x1840842B0")]
	public static IDisposable KMOHLMFGCHC(this IBNJGIOKIDC GHILNBJMAHO, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x40843B0", Offset = "0x4082FB0", VA = "0x1840843B0")]
	public static IDisposable LAAFBFAMCHG(this IBNJGIOKIDC GHILNBJMAHO, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4083FC0", Offset = "0x4082BC0", VA = "0x184083FC0")]
	public static IDisposable FMLFAFIMLMC(this IBNJGIOKIDC GHILNBJMAHO, Action<float> MIMNBPGJKDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class NIIFOOGHMKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4088280", Offset = "0x4086E80", VA = "0x184088280")]
	public static IDisposable CLKIABHGINA(this MonoBehaviour BMMIGOCLNOL, Action MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x40880C0", Offset = "0x4086CC0", VA = "0x1840880C0")]
	public static IDisposable CLKIABHGINA(this MonoBehaviour BMMIGOCLNOL, Action<float> MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4088490", Offset = "0x4087090", VA = "0x184088490")]
	public static IDisposable HHPAPHECEHL(this MonoBehaviour BMMIGOCLNOL, Action MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4088B70", Offset = "0x4087770", VA = "0x184088B70")]
	public static IDisposable PNFBALIMCJD(this MonoBehaviour BMMIGOCLNOL, Action MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4088A70", Offset = "0x4087670", VA = "0x184088A70")]
	public static IDisposable OOKOGNDFOAN(this MonoBehaviour BMMIGOCLNOL, Action MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4088910", Offset = "0x4087510", VA = "0x184088910")]
	public static IDisposable LEPLAMGFFNF(this MonoBehaviour BMMIGOCLNOL, Action MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4088980", Offset = "0x4087580", VA = "0x184088980")]
	public static IDisposable LOKMHDNPEOG(this MonoBehaviour BMMIGOCLNOL, Action MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4088600", Offset = "0x4087200", VA = "0x184088600")]
	public static IDisposable KANMDCOMLDC(this MonoBehaviour BMMIGOCLNOL, float HGGFBFMNMBF, Action<float> MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4088300", Offset = "0x4086F00", VA = "0x184088300")]
	public static IDisposable EBFIKEJHFDK(this MonoBehaviour BMMIGOCLNOL, float HGGFBFMNMBF, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4088380", Offset = "0x4086F80", VA = "0x184088380")]
	public static IDisposable FJLHDEBELNB(this MonoBehaviour BMMIGOCLNOL, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4087FC0", Offset = "0x4086BC0", VA = "0x184087FC0")]
	public static IDisposable BEONCILFOAP(this MonoBehaviour BMMIGOCLNOL, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x40889F0", Offset = "0x40875F0", VA = "0x1840889F0")]
	public static IDisposable MBJBKHJHNOI(this MonoBehaviour BMMIGOCLNOL, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4088890", Offset = "0x4087490", VA = "0x184088890")]
	public static IDisposable LBNEJMFJLLB(this MonoBehaviour BMMIGOCLNOL, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4088500", Offset = "0x4087100", VA = "0x184088500")]
	public static IDisposable IDGBAGEEGLL(this MonoBehaviour BMMIGOCLNOL, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4088810", Offset = "0x4087410", VA = "0x184088810")]
	public static IDisposable LAIDOHKKLEG(this MonoBehaviour BMMIGOCLNOL, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4088400", Offset = "0x4087000", VA = "0x184088400")]
	public static IDisposable GDGIHGAJEDJ(this MonoBehaviour BMMIGOCLNOL, float HGGFBFMNMBF, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4088580", Offset = "0x4087180", VA = "0x184088580")]
	public static IDisposable JGPCPEPJIEB(this MonoBehaviour BMMIGOCLNOL, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4088040", Offset = "0x4086C40", VA = "0x184088040")]
	public static IDisposable CHHBJHJLNKG(this MonoBehaviour BMMIGOCLNOL, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4088790", Offset = "0x4087390", VA = "0x184088790")]
	public static IDisposable KHNEALIMACK(this MonoBehaviour BMMIGOCLNOL, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4088AE0", Offset = "0x40876E0", VA = "0x184088AE0")]
	public static IDisposable PMMIDHCHEAK(this MonoBehaviour BMMIGOCLNOL, float HGGFBFMNMBF, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4087F40", Offset = "0x4086B40", VA = "0x184087F40")]
	public static IDisposable ADICICNDGKI(this MonoBehaviour BMMIGOCLNOL, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4088690", Offset = "0x4087290", VA = "0x184088690")]
	public static IDisposable KBMDGFHHEGM(this MonoBehaviour BMMIGOCLNOL, Action<float> MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4088710", Offset = "0x4087310", VA = "0x184088710")]
	public static IDisposable KGAPKGILJCP(this MonoBehaviour BMMIGOCLNOL, Action<float> MIMNBPGJKDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class ABKEKPJHPHG
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class ICKMALJDOBI : IEnumerator<MDIGCEIKMFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private MDIGCEIKMFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public LLJFHNCPJIB.CNGEIHNEJPD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private MNKBPHMOOEI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private MDIGCEIKMFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
		[DebuggerHidden]
		public ICKMALJDOBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4080800", Offset = "0x407F400", VA = "0x184080800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x40808D0", Offset = "0x407F4D0", VA = "0x1840808D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class OIHHAKHCGEK : IEnumerator<MDIGCEIKMFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private MDIGCEIKMFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public LLJFHNCPJIB.CNGEIHNEJPD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private MNKBPHMOOEI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private MDIGCEIKMFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
		[DebuggerHidden]
		public OIHHAKHCGEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4088FB0", Offset = "0x4087BB0", VA = "0x184088FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x40890A0", Offset = "0x4087CA0", VA = "0x1840890A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4079E40", Offset = "0x4078A40", VA = "0x184079E40")]
	public static CLMDINKCDBN CLKIABHGINA(Action MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4079C40", Offset = "0x4078840", VA = "0x184079C40")]
	public static CLMDINKCDBN CLKIABHGINA(Action<float> MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4079F30", Offset = "0x4078B30", VA = "0x184079F30")]
	public static CLMDINKCDBN CLKIABHGINA(Behaviour GHILNBJMAHO, Action MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4079D30", Offset = "0x4078930", VA = "0x184079D30")]
	public static CLMDINKCDBN CLKIABHGINA(Behaviour GHILNBJMAHO, Action<float> MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x407A150", Offset = "0x4078D50", VA = "0x18407A150")]
	public static CLMDINKCDBN CNKGJDGMOIN(IBNJGIOKIDC GHILNBJMAHO, Action MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x407A040", Offset = "0x4078C40", VA = "0x18407A040")]
	public static CLMDINKCDBN CNKGJDGMOIN(IBNJGIOKIDC GHILNBJMAHO, Action<float> MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x407A260", Offset = "0x4078E60", VA = "0x18407A260")]
	[IteratorStateMachine(typeof(ICKMALJDOBI))]
	private static IEnumerator<MDIGCEIKMFK> KPFOMPFHEAB(LLJFHNCPJIB.CNGEIHNEJPD NBDHFAHBBPO, Action MIMNBPGJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x407A2D0", Offset = "0x4078ED0", VA = "0x18407A2D0")]
	[IteratorStateMachine(typeof(OIHHAKHCGEK))]
	private static IEnumerator<MDIGCEIKMFK> KPFOMPFHEAB(LLJFHNCPJIB.CNGEIHNEJPD NBDHFAHBBPO, Action<float> MIMNBPGJKDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class HNMDKDHNOML
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class GBPHPOJIHEA : IEnumerator<MDIGCEIKMFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private MDIGCEIKMFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public LLJFHNCPJIB.CNGEIHNEJPD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private GEMDGAJJOBD <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private MDIGCEIKMFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
		[DebuggerHidden]
		public GBPHPOJIHEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x407FC80", Offset = "0x407E880", VA = "0x18407FC80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x407FD70", Offset = "0x407E970", VA = "0x18407FD70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4080610", Offset = "0x407F210", VA = "0x184080610")]
	public static CLMDINKCDBN CLKIABHGINA(float HGGFBFMNMBF, Action<float> MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4080550", Offset = "0x407F150", VA = "0x184080550")]
	public static CLMDINKCDBN CLKIABHGINA(MonoBehaviour BMMIGOCLNOL, float HGGFBFMNMBF, Action<float> MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x40806C0", Offset = "0x407F2C0", VA = "0x1840806C0")]
	public static CLMDINKCDBN DKHNJPGFLHH(IBNJGIOKIDC GHILNBJMAHO, float HGGFBFMNMBF, Action<float> MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4080780", Offset = "0x407F380", VA = "0x184080780")]
	[IteratorStateMachine(typeof(GBPHPOJIHEA))]
	private static IEnumerator<MDIGCEIKMFK> KPFOMPFHEAB(float HGGFBFMNMBF, LLJFHNCPJIB.CNGEIHNEJPD NBDHFAHBBPO, Action<float> MIMNBPGJKDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class IKMJLNCFEGB
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class NHKGIMEKFMM : IEnumerator<MDIGCEIKMFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private MDIGCEIKMFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public LLJFHNCPJIB.CNGEIHNEJPD queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private MDIGCEIKMFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
		[DebuggerHidden]
		public NHKGIMEKFMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4087E50", Offset = "0x4086A50", VA = "0x184087E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4087EF0", Offset = "0x4086AF0", VA = "0x184087EF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4080C20", Offset = "0x407F820", VA = "0x184080C20")]
	[IteratorStateMachine(typeof(NHKGIMEKFMM))]
	private static IEnumerator<MDIGCEIKMFK> PGCFIIKHBLP(LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA, Func<bool> OLILCMHGKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4080AD0", Offset = "0x407F6D0", VA = "0x184080AD0")]
	public static CLMDINKCDBN LJMJJDPFGMG(this MonoBehaviour BMMIGOCLNOL, Func<bool> OLILCMHGKEF, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA = LLJFHNCPJIB.CNGEIHNEJPD.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class MKKIBFFJLEG
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class MJAJBGBJFDD : IEnumerator<MDIGCEIKMFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private MDIGCEIKMFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public LLJFHNCPJIB.CNGEIHNEJPD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private MDIGCEIKMFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
		[DebuggerHidden]
		public MJAJBGBJFDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4084C60", Offset = "0x4083860", VA = "0x184084C60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4084D10", Offset = "0x4083910", VA = "0x184084D10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GBHGLBIFGMC : IEnumerator<MDIGCEIKMFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private MDIGCEIKMFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public LLJFHNCPJIB.CNGEIHNEJPD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private MDIGCEIKMFK <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private MDIGCEIKMFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
		[DebuggerHidden]
		public GBHGLBIFGMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x407FB70", Offset = "0x407E770", VA = "0x18407FB70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x407FC30", Offset = "0x407E830", VA = "0x18407FC30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4086EF0", Offset = "0x4085AF0", VA = "0x184086EF0")]
	[IteratorStateMachine(typeof(MJAJBGBJFDD))]
	private static IEnumerator<MDIGCEIKMFK> ABEGGMGDEKF(float MGGKFHFIBDI, LLJFHNCPJIB.CNGEIHNEJPD NBDHFAHBBPO, Action DLCGPBCLIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4087080", Offset = "0x4085C80", VA = "0x184087080")]
	[IteratorStateMachine(typeof(GBHGLBIFGMC))]
	private static IEnumerator<MDIGCEIKMFK> FOACGKJJCJA(float MGGKFHFIBDI, LLJFHNCPJIB.CNGEIHNEJPD NBDHFAHBBPO, Action DLCGPBCLIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x40876C0", Offset = "0x40862C0", VA = "0x1840876C0")]
	public static IDisposable NCHGJEFNICH(this MonoBehaviour BMMIGOCLNOL, float MGGKFHFIBDI, Action DLCGPBCLIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4087240", Offset = "0x4085E40", VA = "0x184087240")]
	public static CLMDINKCDBN IGFOCJCLPBD(this MonoBehaviour BMMIGOCLNOL, float MGGKFHFIBDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4087800", Offset = "0x4086400", VA = "0x184087800")]
	public static CLMDINKCDBN NCHGJEFNICH(this MonoBehaviour BMMIGOCLNOL, float MGGKFHFIBDI, LLJFHNCPJIB.CNGEIHNEJPD NBDHFAHBBPO, Action DLCGPBCLIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4087220", Offset = "0x4085E20", VA = "0x184087220")]
	public static CLMDINKCDBN HGFBLHDIKDJ(this MonoBehaviour BMMIGOCLNOL, Action DLCGPBCLIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4087A60", Offset = "0x4086660", VA = "0x184087A60")]
	public static CLMDINKCDBN PDJBFEGEIFG(this MonoBehaviour BMMIGOCLNOL, Action DLCGPBCLIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4087380", Offset = "0x4085F80", VA = "0x184087380")]
	public static CLMDINKCDBN IGNENJIEIMB(this MonoBehaviour BMMIGOCLNOL, Action DLCGPBCLIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4087100", Offset = "0x4085D00", VA = "0x184087100")]
	public static CLMDINKCDBN GBCFOBNOIPK(this MonoBehaviour BMMIGOCLNOL, Action DLCGPBCLIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4087230", Offset = "0x4085E30", VA = "0x184087230")]
	public static CLMDINKCDBN HKLPAEGKIOK(this MonoBehaviour BMMIGOCLNOL, Action DLCGPBCLIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x40874A0", Offset = "0x40860A0", VA = "0x1840874A0")]
	private static CLMDINKCDBN JJIHANIIDEG(MonoBehaviour BMMIGOCLNOL, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA, Action DLCGPBCLIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x40875B0", Offset = "0x40861B0", VA = "0x1840875B0")]
	public static CLMDINKCDBN JNJMNNNNFJP(this MonoBehaviour BMMIGOCLNOL, float DDHDOLCEFMB, Action DLCGPBCLIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4087110", Offset = "0x4085D10", VA = "0x184087110")]
	public static CLMDINKCDBN HDPHEGFCKMK(this MonoBehaviour BMMIGOCLNOL, float DDHDOLCEFMB, Action DLCGPBCLIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4086F70", Offset = "0x4085B70", VA = "0x184086F70")]
	public static CLMDINKCDBN FEEEMMIHGGA(this MonoBehaviour BMMIGOCLNOL, float DDHDOLCEFMB, Action DLCGPBCLIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4087950", Offset = "0x4086550", VA = "0x184087950")]
	public static CLMDINKCDBN PBEPAINNOIE(this MonoBehaviour BMMIGOCLNOL, float DDHDOLCEFMB, Action DLCGPBCLIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4087390", Offset = "0x4085F90", VA = "0x184087390")]
	public static CLMDINKCDBN IKDKCCLBKBA(this MonoBehaviour BMMIGOCLNOL, float DDHDOLCEFMB, Action DLCGPBCLIFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class LNGKLJPOKAJ : KOLGHBLNDBP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class GDABNDCHGCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public LNGKLJPOKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
		public GDABNDCHGCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x407FDC0", Offset = "0x407E9C0", VA = "0x18407FDC0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HMCMDANAAFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LNGKLJPOKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
		public HMCMDANAAFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x407FDC0", Offset = "0x407E9C0", VA = "0x18407FDC0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly float PDCJGHPGFHM;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x407FE30", Offset = "0x407EA30", VA = "0x18407FE30")]
	public LNGKLJPOKAJ(Behaviour GHILNBJMAHO, float PDCJGHPGFHM, [Optional] Action KGABCAIEBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4084710", Offset = "0x4083310", VA = "0x184084710", Slot = "9")]
	protected override bool KCKKKLAPCDI(Action EPGIBOENJMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4084640", Offset = "0x4083240", VA = "0x184084640", Slot = "10")]
	protected override bool KABGKBLFKOO(Action EPGIBOENJMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface ACBAHIJNOGE
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool PAFELOLMEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action ACHGGCFFONI;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PIKMDHECHJM(bool CMDGPEHHGHG = false);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PIKMDHECHJM(Action EPGIBOENJMJ, bool CMDGPEHHGHG = false);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class KOLGHBLNDBP : ACBAHIJNOGE
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class HJMMGGCHFCD : IEnumerator<MDIGCEIKMFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private MDIGCEIKMFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private MDIGCEIKMFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
		[DebuggerHidden]
		public HJMMGGCHFCD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4080020", Offset = "0x407EC20", VA = "0x184080020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x40800C0", Offset = "0x407ECC0", VA = "0x1840800C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly Behaviour GHILNBJMAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly Action KGABCAIEBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private EALELCKGONO MEEDFNJOFBO;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool PAFELOLMEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x671EE0", Offset = "0x670AE0", VA = "0x180671EE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action ACHGGCFFONI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4083020", Offset = "0x4081C20", VA = "0x184083020", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x40830C0", Offset = "0x4081CC0", VA = "0x1840830C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2421550", Offset = "0x2420150", VA = "0x182421550")]
	protected KOLGHBLNDBP(Behaviour GHILNBJMAHO, [Optional] Action KGABCAIEBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x40831F0", Offset = "0x4081DF0", VA = "0x1840831F0", Slot = "7")]
	public bool PIKMDHECHJM(bool CMDGPEHHGHG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4083250", Offset = "0x4081E50", VA = "0x184083250", Slot = "8")]
	public bool PIKMDHECHJM(Action EPGIBOENJMJ, bool CMDGPEHHGHG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool KCKKKLAPCDI(Action EPGIBOENJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool KABGKBLFKOO(Action EPGIBOENJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4083160", Offset = "0x4081D60", VA = "0x184083160")]
	protected void JJMMKALOJID(Action EPGIBOENJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4082DD0", Offset = "0x40819D0", VA = "0x184082DD0")]
	protected DPJKDCDGPPB AKHJLOCEAPC(float CLGLGKKHACK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4083180", Offset = "0x4081D80", VA = "0x184083180")]
	private void KOMEDILOKMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4082FA0", Offset = "0x4081BA0", VA = "0x184082FA0")]
	[IteratorStateMachine(typeof(HJMMGGCHFCD))]
	private static IEnumerator<MDIGCEIKMFK> BGLFMNNOEPN(float CLGLGKKHACK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4083000", Offset = "0x4081C00", VA = "0x184083000")]
	[CompilerGenerated]
	private void DKGNBKLLDHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class BELEBMHOLNO : KOLGHBLNDBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly float HPEPNIOOAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly int NIFANPPLEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly float EFJGLNPJNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly float[] PFADMMIFAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int GIECLHNDEDA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public EKBFHIEFDBB GBCPKAIJHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4E7670", Offset = "0x4E6270", VA = "0x1804E7670")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x59F9E0", Offset = "0x59E5E0", VA = "0x18059F9E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x407AF40", Offset = "0x4079B40", VA = "0x18407AF40")]
	public BELEBMHOLNO(Behaviour GHILNBJMAHO, float AHMOJGELGMI, int NIFANPPLEGC, [Optional] Action KGABCAIEBED, float EFJGLNPJNHB = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E40", Offset = "0x4BFA40", VA = "0x1804C0E40", Slot = "9")]
	protected override bool KCKKKLAPCDI(Action EPGIBOENJMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x407AC90", Offset = "0x4079890", VA = "0x18407AC90", Slot = "10")]
	protected override bool KABGKBLFKOO(Action EPGIBOENJMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x407AEB0", Offset = "0x4079AB0", VA = "0x18407AEB0")]
	private void LKPKNOPONIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class HDJHCPAJJEB : KOLGHBLNDBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly float PDCJGHPGFHM;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x407FE30", Offset = "0x407EA30", VA = "0x18407FE30")]
	public HDJHCPAJJEB(Behaviour GHILNBJMAHO, float PDCJGHPGFHM, [Optional] Action KGABCAIEBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E40", Offset = "0x4BFA40", VA = "0x1804C0E40", Slot = "9")]
	protected override bool KCKKKLAPCDI(Action EPGIBOENJMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x407FDF0", Offset = "0x407E9F0", VA = "0x18407FDF0", Slot = "10")]
	protected override bool KABGKBLFKOO(Action EPGIBOENJMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class ILANJLBBOIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class INFHLBHDOIM : IEnumerator<MDIGCEIKMFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private MDIGCEIKMFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private MDIGCEIKMFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
		[DebuggerHidden]
		public INFHLBHDOIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4081880", Offset = "0x4080480", VA = "0x184081880", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4081970", Offset = "0x4080570", VA = "0x184081970", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private CLMDINKCDBN FHDPHPPNHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private IBNJGIOKIDC GHILNBJMAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Action MIMNBPGJKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Action<float> JAMHGJFFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private float JBKDHMCIDHC;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4081560", Offset = "0x4080160", VA = "0x184081560")]
	public ILANJLBBOIM(IBNJGIOKIDC GHILNBJMAHO, Action MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x40816F0", Offset = "0x40802F0", VA = "0x1840816F0")]
	public ILANJLBBOIM(IBNJGIOKIDC GHILNBJMAHO, Action<float> MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4081410", Offset = "0x4080010", VA = "0x184081410")]
	public ILANJLBBOIM(IBNJGIOKIDC GHILNBJMAHO, float HGGFBFMNMBF, Action<float> MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4080C90", Offset = "0x407F890", VA = "0x184080C90")]
	private void CLKIABHGINA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4081230", Offset = "0x407FE30", VA = "0x184081230")]
	private void KIBNHMDEDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4080EE0", Offset = "0x407FAE0", VA = "0x184080EE0")]
	private void GPEFFHGJHLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4081090", Offset = "0x407FC90", VA = "0x184081090")]
	private void HFCCFDHIDJL(string FPODCKNNJGL, Action BOCDMPPBCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x40813B0", Offset = "0x407FFB0", VA = "0x1840813B0")]
	[IteratorStateMachine(typeof(INFHLBHDOIM))]
	private IEnumerator<MDIGCEIKMFK> ONFILOGLFDJ(Action BOCDMPPBCAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4080E10", Offset = "0x407FA10", VA = "0x184080E10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4081010", Offset = "0x407FC10", VA = "0x184081010")]
	[CompilerGenerated]
	private void HAAHAJJHPJA(string EMFHNCOFDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x40811B0", Offset = "0x407FDB0", VA = "0x1840811B0")]
	[CompilerGenerated]
	private void IBHEENGKNKM(string EMFHNCOFDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4080E60", Offset = "0x407FA60", VA = "0x184080E60")]
	[CompilerGenerated]
	private void FPDMANDBEDB(string EMFHNCOFDKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class BIDCNHKELGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class ECEFDPNJKBE : IEnumerator<MDIGCEIKMFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private MDIGCEIKMFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private MDIGCEIKMFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
		[DebuggerHidden]
		public ECEFDPNJKBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x407F2F0", Offset = "0x407DEF0", VA = "0x18407F2F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x407F3E0", Offset = "0x407DFE0", VA = "0x18407F3E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private CLMDINKCDBN FHDPHPPNHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private MonoBehaviour BMMIGOCLNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Action MIMNBPGJKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Action<float> JAMHGJFFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float JBKDHMCIDHC;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x407BAF0", Offset = "0x407A6F0", VA = "0x18407BAF0")]
	public BIDCNHKELGI(MonoBehaviour BMMIGOCLNOL, Action MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x407B960", Offset = "0x407A560", VA = "0x18407B960")]
	public BIDCNHKELGI(MonoBehaviour BMMIGOCLNOL, Action<float> MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x407B810", Offset = "0x407A410", VA = "0x18407B810")]
	public BIDCNHKELGI(MonoBehaviour BMMIGOCLNOL, float HGGFBFMNMBF, Action<float> MIMNBPGJKDG, LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x407B090", Offset = "0x4079C90", VA = "0x18407B090")]
	private void CLKIABHGINA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x407B630", Offset = "0x407A230", VA = "0x18407B630")]
	private void KIBNHMDEDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x407B2E0", Offset = "0x4079EE0", VA = "0x18407B2E0")]
	private void GPEFFHGJHLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x407B490", Offset = "0x407A090", VA = "0x18407B490")]
	private void HFCCFDHIDJL(string FPODCKNNJGL, Action BOCDMPPBCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x407B7B0", Offset = "0x407A3B0", VA = "0x18407B7B0")]
	[IteratorStateMachine(typeof(ECEFDPNJKBE))]
	private IEnumerator<MDIGCEIKMFK> ONFILOGLFDJ(Action BOCDMPPBCAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x407B210", Offset = "0x4079E10", VA = "0x18407B210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x407B410", Offset = "0x407A010", VA = "0x18407B410")]
	[CompilerGenerated]
	private void HAAHAJJHPJA(string EMFHNCOFDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x407B5B0", Offset = "0x407A1B0", VA = "0x18407B5B0")]
	[CompilerGenerated]
	private void IBHEENGKNKM(string EMFHNCOFDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x407B260", Offset = "0x4079E60", VA = "0x18407B260")]
	[CompilerGenerated]
	private void FPDMANDBEDB(string EMFHNCOFDKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MKBLKLHMNME
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int ODHKDJODHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class OCILLIFFDOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly OCILLIFFDOE GKPGIBIMEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly Action CEBFFMMFOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool FPMIKEKHGEF;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x59C930", Offset = "0x59B530", VA = "0x18059C930")]
	public OCILLIFFDOE(Action CEBFFMMFOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4088E10", Offset = "0x4087A10", VA = "0x184088E10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface HIMEENJDNKM<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T PDHGPELKFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable BEAJBIJDJCI(Action<T> FJFHNPEPPGA);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable BEAJBIJDJCI(UnityEngine.Object GHILNBJMAHO, Action<T> FJFHNPEPPGA);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface EPJDIIDHPIE<T> : global::HIMEENJDNKM<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T PDHGPELKFGL
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
public class EAAMNEKNMOB<T> : global::EPJDIIDHPIE<T>, global::HIMEENJDNKM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class NGEBFEGLJJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public global::EAAMNEKNMOB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public global::KPEBOKMCEKJ<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x185CA00", Offset = "0x185B600", VA = "0x18185CA00")]
		public NGEBFEGLJJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1B20", Offset = "0x2BB0720", VA = "0x182BB1B20")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static GameObject GJEJLNPNNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<global::KPEBOKMCEKJ<UnityEngine.Object, Action<T>>> GNIIEEPBAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private T BFPPIGEHJEO;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object OFLDBFPIOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6450", Offset = "0x2BA5050", VA = "0x182BA6450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T PDHGPELKFGL
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x63CB90", Offset = "0x63B790", VA = "0x18063CB90", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6140", Offset = "0x2BA4D40", VA = "0x182BA6140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA61D0", Offset = "0x2BA4DD0", VA = "0x182BA61D0")]
	private static bool HICOIEJEGID(T GCJKCBJPHMJ, T HDBDBNKFPIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6D70", Offset = "0x2BA5970", VA = "0x182BA6D70")]
	public EAAMNEKNMOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6DA0", Offset = "0x2BA59A0", VA = "0x182BA6DA0")]
	public EAAMNEKNMOB(T HOMBCBJKOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6CC0", Offset = "0x2BA58C0", VA = "0x182BA6CC0")]
	public void OAELAMEOIKD(T BDMINDPHCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5DF0", Offset = "0x2BA49F0", VA = "0x182BA5DF0", Slot = "7")]
	public IDisposable BEAJBIJDJCI(Action<T> FJFHNPEPPGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5FA0", Offset = "0x2BA4BA0", VA = "0x182BA5FA0", Slot = "8")]
	public IDisposable BEAJBIJDJCI(UnityEngine.Object GHILNBJMAHO, Action<T> FJFHNPEPPGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6980", Offset = "0x2BA5580", VA = "0x182BA6980")]
	private void LNDJLIIEHOC()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<AEHPLGAMHJF, Scheduler>, AEHPLGAMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private class NGNGMPKNEMO : MKBLKLHMNME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public MJCCEKOFEDO IMKLKCGMHNG;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int ODHKDJODHAN
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x4C0E50", Offset = "0x4BFA50", VA = "0x1804C0E50", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x4C0E60", Offset = "0x4BFA60", VA = "0x1804C0E60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x4087C00", Offset = "0x4086800", VA = "0x184087C00")]
			public static MDIGCEIKMFK CJKFDGLHNIE(IEnumerator<MDIGCEIKMFK> OOCHEHIIPLG, NKOFCAEMOBJ MCNCEECLNLB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x4087B30", Offset = "0x4086730", VA = "0x184087B30")]
			public MDIGCEIKMFK CJKFDGLHNIE(NKOFCAEMOBJ[] OBEGIOPAHJC, IEnumerator<MDIGCEIKMFK>[] JJMFDKHJMKJ, MDIGCEIKMFK[] JCPINMGMBHP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x4087D60", Offset = "0x4086960", VA = "0x184087D60")]
			public void PLJGJKFPGKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x4087D90", Offset = "0x4086990", VA = "0x184087D90")]
			public void MNHPNLFNFDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x4087A70", Offset = "0x4086670", VA = "0x184087A70")]
			public void AHHILNKEJII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x4087D60", Offset = "0x4086960", VA = "0x184087D60")]
			public void GLPJGPDFKPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
			public NGNGMPKNEMO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class MJCCEKOFEDO
		{
			[Cpp2IlInjected.Token(Token = "0x2000046")]
			public struct PIBBIIEPMKE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public NGNGMPKNEMO IDGOMAKANHF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public IBNJGIOKIDC EHNBLEMLKCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public NKOFCAEMOBJ DKEGFLFIAAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public IEnumerator<MDIGCEIKMFK> ABONIGLCBNP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public MDIGCEIKMFK KLIMIEHFJLG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public NDANHJLILDP AKEEOLGDHKP;
			}

			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public struct PPOFDFHCDPO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public LLJFHNCPJIB.CNGEIHNEJPD AMFJOOOMLMK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public List<PIBBIIEPMKE> DHEILBGPMNO;
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			[CompilerGenerated]
			private sealed class JLAPHODBGFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public MJCCEKOFEDO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public IBNJGIOKIDC context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public NGNGMPKNEMO routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public NDANHJLILDP coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public NKOFCAEMOBJ promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public MDIGCEIKMFK currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public IEnumerator<MDIGCEIKMFK> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
				public JLAPHODBGFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x4081F90", Offset = "0x4080B90", VA = "0x184081F90")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private sealed class MIAINPCEGCO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public NGNGMPKNEMO schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public MJCCEKOFEDO <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
				public MIAINPCEGCO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0x4084C20", Offset = "0x4083820", VA = "0x184084C20")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class BEOAIKHNKOK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public NGNGMPKNEMO schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public MJCCEKOFEDO <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
				public BEOAIKHNKOK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x407B050", Offset = "0x4079C50", VA = "0x18407B050")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class EGFIDNIHAGE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public NGNGMPKNEMO schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public MJCCEKOFEDO <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
				public EGFIDNIHAGE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x407FB30", Offset = "0x407E730", VA = "0x18407FB30")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private readonly LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private bool[] ADDCPOHFNEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<NDANHJLILDP> DHDFAMLAJHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<float> OKCCDJADKLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private NativeArray<int> DFDIKCGNJCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private NativeArray<int> DKGOPOHJDIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private NativeArray<int> GGAEIDKMJEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<int> JCNCEOHGPNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<int> MLKIKOBFHDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private NGNGMPKNEMO[] ONCKJPFJFED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NKOFCAEMOBJ[] OBEGIOPAHJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private IBNJGIOKIDC[] LCKKPKEDLIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private IEnumerator<MDIGCEIKMFK>[] ECOHOLMOKOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private MDIGCEIKMFK[] NDMEHJBEOHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private int HCDLPGNINKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private int FNDGLMJFLAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private readonly int IFHOIDKAPKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private float IMAMIIDKPDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private KIIDJEKDIPD OEAKOHOOFHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private JobHandle MEKMMOILLOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private List<NGNGMPKNEMO> LHCLAAKOPBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private bool MAFKJOLFLGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private List<Action> CPMGKIHBGEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private List<Action> PACFLNKNEOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private bool IILJIPCIPCG;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public PPOFDFHCDPO[] GBEHLNIGODK
			{
				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x7B0C10", Offset = "0x7AF810", VA = "0x1807B0C10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int JDBLBGIBLDM
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x9E2D40", Offset = "0x9E1940", VA = "0x1809E2D40")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4084D60", Offset = "0x4083960", VA = "0x184084D60")]
			private static int DGDGMMMGEOE(LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4086A20", Offset = "0x4085620", VA = "0x184086A20")]
			public MJCCEKOFEDO(LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x4085AC0", Offset = "0x40846C0", VA = "0x184085AC0")]
			private void KLCHIMJIJDI(ref int IGKHCBMLAKD, int MABNHAFAHJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4085640", Offset = "0x4084240", VA = "0x184085640")]
			public void HINKBGONNIG(IBNJGIOKIDC GHILNBJMAHO, MDIGCEIKMFK LINIBLMGGFN, IEnumerator<MDIGCEIKMFK> OOCHEHIIPLG, NKOFCAEMOBJ MCNCEECLNLB, [Optional] NGNGMPKNEMO PLOLDKEDFIA, NDANHJLILDP KACNJLBOJJB = NDANHJLILDP.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x4085770", Offset = "0x4084370", VA = "0x184085770")]
			public void IADGCKJAOIA(IEnumerable<PIBBIIEPMKE> LLAGHGBBOAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x4085C50", Offset = "0x4084850", VA = "0x184085C50")]
			private PIBBIIEPMKE KOBJKFKMEEK(int JAEFADJNLOP)
			{
				return default(PIBBIIEPMKE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x4086320", Offset = "0x4084F20", VA = "0x184086320")]
			private void ONFNCLOOMHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x1C6E920", Offset = "0x1C6D520", VA = "0x181C6E920")]
			private static void AANKBNAENHH<T>(int JAEFADJNLOP, T[] IDPCNPFIIDG, int JAOGIBPIKCP, [Optional] T NHHLHJKAIOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x1C6E900", Offset = "0x1C6D500", VA = "0x181C6E900")]
			private static void AANKBNAENHH<T>(int JAEFADJNLOP, NativeArray<T> IDPCNPFIIDG, int JAOGIBPIKCP, [Optional] T NHHLHJKAIOH) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x4086780", Offset = "0x4085380", VA = "0x184086780")]
			private void PLKEMKNLLBK(IEnumerable<PIBBIIEPMKE> LLAGHGBBOAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x4084D90", Offset = "0x4083990", VA = "0x184084D90")]
			private void DPFJNEPNPDK(PIBBIIEPMKE FLNGLCENHHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x40852F0", Offset = "0x4083EF0", VA = "0x1840852F0")]
			private IBJCMCBPCEP GEBJJDHLJLM(int GMNCKOOFFBP)
			{
				return default(IBJCMCBPCEP);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4086130", Offset = "0x4084D30", VA = "0x184086130")]
			public void NHEKOLKBJHE(float OBGDJGONOEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x4085960", Offset = "0x4084560", VA = "0x184085960")]
			private void IBNDKJMMHAK(Action GCJKCBJPHMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x4086700", Offset = "0x4085300", VA = "0x184086700")]
			private void PLINJAPKJEB(Action GCJKCBJPHMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x4084E50", Offset = "0x4083A50", VA = "0x184084E50")]
			public void EOIHAFCKKMO(float OBGDJGONOEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x40859E0", Offset = "0x40845E0", VA = "0x1840859E0")]
			public void IGOHHICEBGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x4085590", Offset = "0x4084190", VA = "0x184085590")]
			public void GLPJGPDFKPO(NGNGMPKNEMO EELIEDNICPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x4086080", Offset = "0x4084C80", VA = "0x184086080")]
			public void LCMFCGPPJJC(NGNGMPKNEMO EELIEDNICPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x4086650", Offset = "0x4085250", VA = "0x184086650")]
			public void PFJABAOGPHP(NGNGMPKNEMO EELIEDNICPP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[BurstCompile]
		public struct KIIDJEKDIPD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			[ReadOnly]
			public float LFHPPBMPNKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			[ReadOnly]
			public int DADLDHEDHAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private NativeArray<int> FGJICBCMPHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private NativeArray<int> LJBPLAMAOJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private NativeArray<int> EBBIDIJMNBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public NativeArray<NDANHJLILDP> HCICHMJMKHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public NativeArray<float> KLHPFLHOPKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			[WriteOnly]
			public NativeArray<int> GGAEIDKMJEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			[WriteOnly]
			public NativeArray<int> DFDIKCGNJCB;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x4082770", Offset = "0x4081370", VA = "0x184082770")]
			public static KIIDJEKDIPD EOHCEIKEHFP(int ONEGLHIACMF, float OBGDJGONOEO, NativeArray<NDANHJLILDP> MBOBFECNPOB, NativeArray<float> KPOIGBIINDC, NativeArray<int> EELFDBCEDMB, NativeArray<int> NIPMOBBMKNM, NativeArray<int> BGLNDMBEGIA, NativeArray<int> LJBPLAMAOJI, NativeArray<int> EBBIDIJMNBK)
			{
				return default(KIIDJEKDIPD);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x4082840", Offset = "0x4081440", VA = "0x184082840", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x4082990", Offset = "0x4081590", VA = "0x184082990")]
			private bool IAGICAPIEFL(int AOPIKBGIANA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x4082CD0", Offset = "0x40818D0", VA = "0x184082CD0")]
			private void LBAEIKJPHBJ(NativeArray<int> MHJKANNLLLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x4082920", Offset = "0x4081520", VA = "0x184082920")]
			private int HFOMIGHLMDO(int DOBJJDHBDCN, int LBLGDGHLHBL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x40829D0", Offset = "0x40815D0", VA = "0x1840829D0")]
			private void JCKBOPOGOGN(NativeArray<int> MHJKANNLLLA, int GCFAHGIJLGM, int OMIFAGIICPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x4082AA0", Offset = "0x40816A0", VA = "0x184082AA0")]
			private void JHDOIANGJAB(NativeArray<int> MHJKANNLLLA, int GNDDKIDJLCE, int IDHDGILNKFJ, int DKKJJGPPDOG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private sealed class JBFFJIIGCGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly NKOFCAEMOBJ MCNCEECLNLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly Behaviour GHILNBJMAHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private readonly bool LNKMAAMELKB;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<MDIGCEIKMFK> ABONIGLCBNP
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BEDA0", VA = "0x1804C01A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x4C0440", Offset = "0x4BF040", VA = "0x1804C0440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public MDIGCEIKMFK KLIMIEHFJLG
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0x4C0450", Offset = "0x4BF050", VA = "0x1804C0450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool ONDHELEHJFG
			{
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x40819C0", Offset = "0x40805C0", VA = "0x1840819C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool KBAMBJNAHIB
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x6FA930", Offset = "0x6F9530", VA = "0x1806FA930")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x1AF1470", Offset = "0x1AF0070", VA = "0x181AF1470")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string NJMEBCJJJMB
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x4C0F90", Offset = "0x4BFB90", VA = "0x1804C0F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x4C0FA0", Offset = "0x4BFBA0", VA = "0x1804C0FA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float GFEHLBDGOFM
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0xF37540", Offset = "0xF36140", VA = "0x180F37540")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0xF375C0", Offset = "0xF361C0", VA = "0x180F375C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x4081E10", Offset = "0x4080A10", VA = "0x184081E10")]
			public JBFFJIIGCGN(IEnumerator<MDIGCEIKMFK> OOCHEHIIPLG, Behaviour GHILNBJMAHO, NKOFCAEMOBJ MCNCEECLNLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x4081A50", Offset = "0x4080650", VA = "0x184081A50")]
			public MDIGCEIKMFK CJKFDGLHNIE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x4081CF0", Offset = "0x40808F0", VA = "0x184081CF0")]
			public bool OHDCFNJLOGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x4081C60", Offset = "0x4080860", VA = "0x184081C60")]
			public void GLPJGPDFKPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x4081D80", Offset = "0x4080980", VA = "0x184081D80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x11CF690", Offset = "0x11CE290", VA = "0x1811CF690")]
			[CompilerGenerated]
			private void NMIIILIPNED()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private sealed class NKOFCAEMOBJ : NLGNCLLDFAA, CLMDINKCDBN, EALELCKGONO, DPJKDCDGPPB, IEnumerator, MDIGCEIKMFK, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private LLJFHNCPJIB.CNGEIHNEJPD BDKKEAFOGNE;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private LLJFHNCPJIB.CNGEIHNEJPD IIAPHLFFNDG
			{
				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x4E4290", Offset = "0x4E2E90", VA = "0x1804E4290", Slot = "23")]
				get
				{
					return default(LLJFHNCPJIB.CNGEIHNEJPD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public LLJFHNCPJIB.CNGEIHNEJPD IMKLKCGMHNG
			{
				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x4E4290", Offset = "0x4E2E90", VA = "0x1804E4290")]
				get
				{
					return default(LLJFHNCPJIB.CNGEIHNEJPD);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x695060", Offset = "0x693C60", VA = "0x180695060")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float LHLPOCDGEJF
			{
				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0xD6C350", Offset = "0xD6AF50", VA = "0x180D6C350", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x4088BF0", Offset = "0x40877F0", VA = "0x184088BF0", Slot = "24")]
			private bool EPBKIGIJFJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x4088BE0", Offset = "0x40877E0", VA = "0x184088BE0", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x4088C10", Offset = "0x4087810", VA = "0x184088C10")]
			public NKOFCAEMOBJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private enum IBJCMCBPCEP : byte
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
		private sealed class DFMPCCMFIBJ : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			public enum MMFPOAPLJOP
			{
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000052")]
			public struct HLNBFPPCIPD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				public LLJFHNCPJIB.CNGEIHNEJPD AMFJOOOMLMK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public MMFPOAPLJOP KFHFFPHPNCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public List<JBFFJIIGCGN> ALDOBIFOLPD;
			}

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private static readonly MMFPOAPLJOP[] BNCMAKGLBNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private bool LMEJIPEOEEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly JBFFJIIGCGN[] INCNHIMHJEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly List<JBFFJIIGCGN> HOGLBBDMNGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private readonly Stack<int> BOAEBAGINLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly List<JBFFJIIGCGN> MCDOBNLBEFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly Stack<int> MJIGOIAPCBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private bool IILJIPCIPCG;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public HLNBFPPCIPD[,] CCNJGOFEAAJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x4D3470", Offset = "0x4D2070", VA = "0x1804D3470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int JDBLBGIBLDM
			{
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x407E600", Offset = "0x407D200", VA = "0x18407E600")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x407E930", Offset = "0x407D530", VA = "0x18407E930")]
			public DFMPCCMFIBJ(LLJFHNCPJIB.CNGEIHNEJPD NBDHFAHBBPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x407E470", Offset = "0x407D070", VA = "0x18407E470")]
			public void MHCBJPKKMCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x407E240", Offset = "0x407CE40", VA = "0x18407E240")]
			public void KAAOCPMEMKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x407E350", Offset = "0x407CF50", VA = "0x18407E350")]
			private void KMOBGOPGHLE(IReadOnlyList<JBFFJIIGCGN> PAHPCLJFDIF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x407E250", Offset = "0x407CE50", VA = "0x18407E250")]
			public void KGMBGMCFPCJ(JBFFJIIGCGN OOCHEHIIPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x407DD40", Offset = "0x407C940", VA = "0x18407DD40")]
			public void JLCMKFIDJDO(IList<JBFFJIIGCGN> JJMFDKHJMKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x407DFC0", Offset = "0x407CBC0", VA = "0x18407DFC0")]
			public void JPMLJCBCKMO(IList<JBFFJIIGCGN> JJMFDKHJMKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x407E770", Offset = "0x407D370", VA = "0x18407E770")]
			private void OFLLOAGOFDA(JBFFJIIGCGN OOCHEHIIPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x407DBD0", Offset = "0x407C7D0", VA = "0x18407DBD0")]
			private void JHLCGPJBLEG(IList<JBFFJIIGCGN> JJMFDKHJMKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x407E480", Offset = "0x407D080", VA = "0x18407E480")]
			private IBJCMCBPCEP MKAJNODDAMJ(JBFFJIIGCGN OOCHEHIIPLG)
			{
				return default(IBJCMCBPCEP);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x407D820", Offset = "0x407C420", VA = "0x18407D820")]
			public void HHPAPHECEHL(float OBGDJGONOEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x407D4E0", Offset = "0x407C0E0", VA = "0x18407D4E0")]
			public void CPCICMEHGGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x407D9F0", Offset = "0x407C5F0", VA = "0x18407D9F0")]
			private void ILGBPEPLKHH(List<JBFFJIIGCGN> JJMFDKHJMKJ, Stack<int> AMGAKPNFENL, bool GOPAKBFFNMG, float NMMLGEOAALF = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x407D6E0", Offset = "0x407C2E0", VA = "0x18407D6E0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x407D8D0", Offset = "0x407C4D0", VA = "0x18407D8D0")]
			private void HNNDKIDCKNK(List<JBFFJIIGCGN> JJMFDKHJMKJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[Flags]
		public enum NDANHJLILDP : byte
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
		private sealed class KKOCKDIOOOC : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
			[DebuggerHidden]
			public KKOCKDIOOOC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x4082D00", Offset = "0x4081900", VA = "0x184082D00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x4082D80", Offset = "0x4081980", VA = "0x184082D80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private const NDANHJLILDP GCFIGFIKHKH = NDANHJLILDP.Cancelled | NDANHJLILDP.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static readonly LLJFHNCPJIB.CNGEIHNEJPD[] FCGAHLNNEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private DFMPCCMFIBJ[] LEFFCBMENIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private MJCCEKOFEDO[] JACKMIICHEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private Coroutine BHILCFBCPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private WaitForEndOfFrame JNEKFDMNCMN;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public LLJFHNCPJIB.CNGEIHNEJPD JJLMOLDPNFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x5440A0", Offset = "0x542CA0", VA = "0x1805440A0")]
			[CompilerGenerated]
			get
			{
				return default(LLJFHNCPJIB.CNGEIHNEJPD);
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x5B93C0", Offset = "0x5B7FC0", VA = "0x1805B93C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GKDLBEAHEEI
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x6FA630", Offset = "0x6F9230", VA = "0x1806FA630", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x1964A50", Offset = "0x1963650", VA = "0x181964A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int JDBLBGIBLDM
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x408B2C0", Offset = "0x4089EC0", VA = "0x18408B2C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x408A1C0", Offset = "0x4088DC0", VA = "0x18408A1C0")]
		public static CLMDINKCDBN GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x40899B0", Offset = "0x40885B0", VA = "0x1840899B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x408A280", Offset = "0x4088E80", VA = "0x18408A280", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4089970", Offset = "0x4088570", VA = "0x184089970")]
		private DFMPCCMFIBJ AFMKEFOIPBK(LLJFHNCPJIB.CNGEIHNEJPD KJIFPOAFBKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2B96930", Offset = "0x2B95530", VA = "0x182B96930")]
		private MJCCEKOFEDO MLDOEECDJMI(LLJFHNCPJIB.CNGEIHNEJPD KJIFPOAFBKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x408A710", Offset = "0x4089310", VA = "0x18408A710")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x408A6E0", Offset = "0x40892E0", VA = "0x18408A6E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x408B0B0", Offset = "0x4089CB0", VA = "0x18408B0B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x408A270", Offset = "0x4088E70", VA = "0x18408A270")]
		private void MDPGKOFHNPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4089EB0", Offset = "0x4088AB0", VA = "0x184089EB0")]
		private void EOKHLHFDNKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4089FF0", Offset = "0x4088BF0", VA = "0x184089FF0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x408A260", Offset = "0x4088E60", VA = "0x18408A260")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4089EC0", Offset = "0x4088AC0", VA = "0x184089EC0")]
		private void EOPMNKDFBKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4089DF0", Offset = "0x40889F0", VA = "0x184089DF0")]
		[IteratorStateMachine(typeof(KKOCKDIOOOC))]
		private IEnumerator CAKPAMMKCBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x408ABD0", Offset = "0x40897D0", VA = "0x18408ABD0", Slot = "7")]
		public CLMDINKCDBN Run(IEnumerator<MDIGCEIKMFK> IFMLGMPBAAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x408A8B0", Offset = "0x40894B0", VA = "0x18408A8B0", Slot = "8")]
		public CLMDINKCDBN Run(Behaviour GHILNBJMAHO, IEnumerator<MDIGCEIKMFK> IFMLGMPBAAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x408A780", Offset = "0x4089380", VA = "0x18408A780", Slot = "9")]
		public CLMDINKCDBN RunJobbed(IBNJGIOKIDC GHILNBJMAHO, IEnumerator<MDIGCEIKMFK> IFMLGMPBAAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x4089E50", Offset = "0x4088A50", VA = "0x184089E50", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x408ABE0", Offset = "0x40897E0", VA = "0x18408ABE0")]
		public void UpdateQueue(LLJFHNCPJIB.CNGEIHNEJPD HFFLAMGMCIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x408A000", Offset = "0x4088C00", VA = "0x18408A000")]
		private void GJEEGMFAINO(DFMPCCMFIBJ DCAGICONGFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4089ED0", Offset = "0x4088AD0", VA = "0x184089ED0")]
		private void FBLCEPEKGNI(MJCCEKOFEDO DCAGICONGFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x408B260", Offset = "0x4089E60", VA = "0x18408B260")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class KGFHDCEIIHA
{
	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x40826E0", Offset = "0x40812E0", VA = "0x1840826E0")]
	[NAIOBDLNNIP]
	private static void BCIINOHGNDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class IIHOKFDILNA : EKBFHIEFDBB
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float OJOOFPKNAPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4080A90", Offset = "0x407F690", VA = "0x184080A90", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float NBOCLONKJGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4080A70", Offset = "0x407F670", VA = "0x184080A70", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float BLDEGFEONOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4080A80", Offset = "0x407F680", VA = "0x184080A80", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int MKOGPFOGDNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4080AA0", Offset = "0x407F6A0", VA = "0x184080AA0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double AFJFJBLNOHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4080AB0", Offset = "0x407F6B0", VA = "0x184080AB0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
	public IIHOKFDILNA()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class DNLKDMBGAII
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static byte[] LPPEPCLGPFA;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static int ALNIJEPLOPN;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static int BOCMDGEBMMF;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static BigInteger AOEPCALDGLN;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
	public DNLKDMBGAII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x407ED10", Offset = "0x407D910", VA = "0x18407ED10")]
	private static string ENAHEOFOPLE(byte[] HDBDBNKFPIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x407EE10", Offset = "0x407DA10", VA = "0x18407EE10")]
	public static string JNOEGFCEOHO(byte[] LGMOCOBILLJ, bool NNFMBLOFMHM)
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
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
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

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
		private delegate List<PlayerLoopSystem> OIFPLNIDHHJ(List<PlayerLoopSystem> DAGEOCNEKAB, int KNLGPFHLMNB);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct LHIPIKNEGNL
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct BCGGCCHDDJN
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static GGJPBMMBEKM JCKJONJFEEH;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x49B0430", Offset = "0x49AF030", VA = "0x1849B0430")]
				public static PlayerLoopSystem BEFBGGGOFNO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct PMPDHJGCCHJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static GGJPBMMBEKM PMKKIEPNGNJ;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x49BFAA0", Offset = "0x49BE6A0", VA = "0x1849BFAA0")]
				public static PlayerLoopSystem BEFBGGGOFNO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct LBNJFKDAGPI
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static GGJPBMMBEKM HHAJIONMNDF;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x49BD750", Offset = "0x49BC350", VA = "0x1849BD750")]
				public static PlayerLoopSystem BEFBGGGOFNO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct EFFDKHDEBLO
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static GGJPBMMBEKM MIEJBGDBOCD;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x49B6E60", Offset = "0x49B5A60", VA = "0x1849B6E60")]
				public static PlayerLoopSystem BEFBGGGOFNO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct MJMFONPKCBK
			{
				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static GGJPBMMBEKM OLLBDCGLODC;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x49BD920", Offset = "0x49BC520", VA = "0x1849BD920")]
				public static PlayerLoopSystem BEFBGGGOFNO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct HKANBCFLJEN
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class DPMMAPAAHPK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000012")]
					public HLKKDLACJCB.JAMLHNHJBMN key;

					[Cpp2IlInjected.Token(Token = "0x6000025")]
					[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
					public DPMMAPAAHPK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000026")]
					[Cpp2IlInjected.Address(RVA = "0x49B6DB0", Offset = "0x49B59B0", VA = "0x1849B6DB0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static IDisposable LFAKDLFMHHP;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x49B9FE0", Offset = "0x49B8BE0", VA = "0x1849B9FE0")]
				public static PlayerLoopSystem BILFIKAJCOC(HLKKDLACJCB.JAMLHNHJBMN GMCMHIFODNN)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			internal struct BJLEMGEALJL
			{
				[Cpp2IlInjected.Token(Token = "0x2000012")]
				[CompilerGenerated]
				private sealed class CLGGPFGABFL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000013")]
					public HLKKDLACJCB.JAMLHNHJBMN key;

					[Cpp2IlInjected.Token(Token = "0x6000028")]
					[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
					public CLGGPFGABFL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000029")]
					[Cpp2IlInjected.Address(RVA = "0x49B2210", Offset = "0x49B0E10", VA = "0x1849B2210")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x49B1880", Offset = "0x49B0480", VA = "0x1849B1880")]
				public static PlayerLoopSystem BILFIKAJCOC(HLKKDLACJCB.JAMLHNHJBMN GMCMHIFODNN)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class OGAILPFIBAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
			public OGAILPFIBAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x49BE4D0", Offset = "0x49BD0D0", VA = "0x1849BE4D0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool MECAIDIHAPO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool CLGNMDCGCCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x49B3A90", Offset = "0x49B2690", VA = "0x1849B3A90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x49B3A50", Offset = "0x49B2650", VA = "0x1849B3A50")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x49B2310", Offset = "0x49B0F10", VA = "0x1849B2310")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x49B3880", Offset = "0x49B2480", VA = "0x1849B3880")]
		private static void GAGGBNLOHCE(HLKKDLACJCB.JAMLHNHJBMN GMCMHIFODNN, ref PlayerLoopSystem MAPNMMHGEHO, Type PKCHCDMDCJN, Type HFFEAKBLGEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x49B3AD0", Offset = "0x49B26D0", VA = "0x1849B3AD0")]
		private static void NFCLCONAHCM(ref PlayerLoopSystem MAPNMMHGEHO, Type PKCHCDMDCJN, Type HFFEAKBLGEN, OIFPLNIDHHJ LKILGKADIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x49B3760", Offset = "0x49B2360", VA = "0x1849B3760")]
		private static void BEGKODOLMNO(ref PlayerLoopSystem MAPNMMHGEHO, Type PKCHCDMDCJN, Type HFFEAKBLGEN, PlayerLoopSystem? KCMDNHOFGHL, PlayerLoopSystem? HHEEOPGHFDP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class HLKKDLACJCB
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum JAMLHNHJBMN
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		FullPlayerLoop
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class HKHOGKDHEFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly JAMLHNHJBMN HNNNKPNKEPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly OKNMNGGEKOK PLLHPDOLJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long OLJEPJACHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long KHPDCKGEKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public long OAKHEJJANEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int AIMPNNGFJFP;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x49BA460", Offset = "0x49B9060", VA = "0x1849BA460")]
		public HKHOGKDHEFK(JAMLHNHJBMN EKJGALDOKGI, int JLMBNCGNPDH = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x49BA1A0", Offset = "0x49B8DA0", VA = "0x1849BA1A0")]
		public void CIMJHGEIHDJ(int FPNIAMEHIFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x49BA1C0", Offset = "0x49B8DC0", VA = "0x1849BA1C0")]
		public void CKFFLDDJLAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x49BA230", Offset = "0x49B8E30", VA = "0x1849BA230")]
		public void HBAFPIBGMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x49BA290", Offset = "0x49B8E90", VA = "0x1849BA290")]
		public void JPPBLJOPHPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x49BA100", Offset = "0x49B8D00", VA = "0x1849BA100")]
		public double AFNKOEKPHMG(int EKHJBIBIDKC)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const int HOONMFENDKL = 90;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static JAMLHNHJBMN[] EGOFDOKGHDH;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static HKHOGKDHEFK[] HJLIPBIFHPC;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x49BA550", Offset = "0x49B9150", VA = "0x1849BA550")]
	public static HKHOGKDHEFK HMPIOLFPDMI(JAMLHNHJBMN GMCMHIFODNN, int JLMBNCGNPDH = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x49BA700", Offset = "0x49B9300", VA = "0x1849BA700")]
	public static HKHOGKDHEFK JPBDFBJCPCN(JAMLHNHJBMN GMCMHIFODNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x49BA790", Offset = "0x49B9390", VA = "0x1849BA790")]
	public static void NAJPGCALEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OKNMNGGEKOK : NLEHEGMMBAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int PBEKHMOIHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Queue<double> OLAPGOAMEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double CDKHOMPCPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double HHNPPNHMFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double LMNCBENNEDK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CDADDFLLMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x49BF440", Offset = "0x49BE040", VA = "0x1849BF440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double PDGHJNCFCMG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x49BF370", Offset = "0x49BDF70", VA = "0x1849BF370", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double HMBAIJMEMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x10E7B90", Offset = "0x10E6790", VA = "0x1810E7B90", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double KGADKJMFJKL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xE67030", Offset = "0xE65C30", VA = "0x180E67030", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x49BF580", Offset = "0x49BE180", VA = "0x1849BF580")]
	public OKNMNGGEKOK(int OBJPADBGLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x49BF480", Offset = "0x49BE080", VA = "0x1849BF480", Slot = "4")]
	public void KHBEJEBGGKJ(double LEJMLBJOPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x49BF3D0", Offset = "0x49BDFD0", VA = "0x1849BF3D0", Slot = "5")]
	public void CLICKJANIPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GNJCNPBAMCB : NLEHEGMMBAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private long PMKGCDLMBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double JEIGNJMJNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double DDBKLIOLCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double FLNKGFHBANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private double DMKEKHFJGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private double CDKHOMPCPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private double HHNPPNHMFNH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long IAPBBGBICKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double HMBAIJMEMPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x10E7B80", Offset = "0x10E6780", VA = "0x1810E7B80", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double KGADKJMFJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xDA8290", Offset = "0xDA6E90", VA = "0x180DA8290", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FGAPIKDDMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE67030", Offset = "0xE65C30", VA = "0x180E67030")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double CBAJOFLFPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xE67020", Offset = "0xE65C20", VA = "0x180E67020")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double PDGHJNCFCMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x10E7AB0", Offset = "0x10E66B0", VA = "0x1810E7AB0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x49B96F0", Offset = "0x49B82F0", VA = "0x1849B96F0", Slot = "4")]
	public void KHBEJEBGGKJ(double LEJMLBJOPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x49B96B0", Offset = "0x49B82B0", VA = "0x1849B96B0", Slot = "5")]
	public void CLICKJANIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x49B9810", Offset = "0x49B8410", VA = "0x1849B9810")]
	public GNJCNPBAMCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NLEHEGMMBAK
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double PDGHJNCFCMG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double HMBAIJMEMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double KGADKJMFJKL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHBEJEBGGKJ(double LEJMLBJOPAG);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CLICKJANIPL();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FKLFIADMFKO
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private interface LJBIBLIGMMF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool NLEIDANJBBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OMAIJKDLOLK();

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OJLBLKNICMO();
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private abstract class HDGJDAFHJDM<TPromise, TMainThreadPromise> : LJBIBLIGMMF where TPromise : EPHEJFPBCIA where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly TPromise BHOJOHHIDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		protected readonly TMainThreadPromise GKIDJLKECIF;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise IAPCAFLMGAA
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x11EE8F0", Offset = "0x11ED4F0", VA = "0x1811EE8F0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NLEIDANJBBO
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x11EE950", Offset = "0x11ED550", VA = "0x1811EE950", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x100A1B0", Offset = "0x1008DB0", VA = "0x18100A1B0")]
		protected HDGJDAFHJDM(TPromise BHOJOHHIDFM, TMainThreadPromise KMJJFFHGNIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x11EE9A0", Offset = "0x11ED5A0", VA = "0x1811EE9A0", Slot = "5")]
		public void OMAIJKDLOLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x76E880", Offset = "0x76D480", VA = "0x18076E880", Slot = "6")]
		public void OJLBLKNICMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void NDHABFBHHLL(TPromise BHOJOHHIDFM);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void HAIAJAOBGOL();
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class EKJPOEFAGDC<T> : HDGJDAFHJDM<global::NHGODCKFGMA<T>, global::MPFMAEPNJMA<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x11D3C70", Offset = "0x11D2870", VA = "0x1811D3C70")]
		public EKJPOEFAGDC(global::NHGODCKFGMA<T> BHOJOHHIDFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x11D3A40", Offset = "0x11D2640", VA = "0x1811D3A40", Slot = "7")]
		protected override void NDHABFBHHLL(global::NHGODCKFGMA<T> BHOJOHHIDFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x11D39B0", Offset = "0x11D25B0", VA = "0x1811D39B0", Slot = "8")]
		protected override void HAIAJAOBGOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x11D3C40", Offset = "0x11D2840", VA = "0x1811D3C40")]
		[CompilerGenerated]
		private void OGOLMPJIEGH(T JAGEKFPDBNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x11D3A10", Offset = "0x11D2610", VA = "0x1811D3A10")]
		[CompilerGenerated]
		private void JIBDLDIBFEM(string JFBFEFFLMHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class CKPKJEBGEIK : HDGJDAFHJDM<EPHEJFPBCIA, MCMONDMICNG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x49B1C10", Offset = "0x49B0810", VA = "0x1849B1C10")]
		public CKPKJEBGEIK(EPHEJFPBCIA BHOJOHHIDFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x49B1B40", Offset = "0x49B0740", VA = "0x1849B1B40", Slot = "7")]
		protected override void NDHABFBHHLL(EPHEJFPBCIA BHOJOHHIDFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x49B1AF0", Offset = "0x49B06F0", VA = "0x1849B1AF0", Slot = "8")]
		protected override void HAIAJAOBGOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x18FD500", Offset = "0x18FC100", VA = "0x1818FD500")]
		[CompilerGenerated]
		private void OGOLMPJIEGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2506230", Offset = "0x2504E30", VA = "0x182506230")]
		[CompilerGenerated]
		private void JIBDLDIBFEM(string JFBFEFFLMHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class FDLHPIANICK : LJBIBLIGMMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Action LKFICPAOGAF;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool NLEIDANJBBO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x577CA0", Offset = "0x5768A0", VA = "0x180577CA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5B97A0", Offset = "0x5B83A0", VA = "0x1805B97A0")]
		public FDLHPIANICK(Action LKFICPAOGAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x10F7AF0", Offset = "0x10F66F0", VA = "0x1810F7AF0", Slot = "5")]
		public void OMAIJKDLOLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "6")]
		public void OJLBLKNICMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly List<LJBIBLIGMMF> BFIDGDMNPJE;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x27601D0", Offset = "0x275EDD0", VA = "0x1827601D0")]
	public static global::NHGODCKFGMA<T> LPGMICBIONC<T>(this global::NHGODCKFGMA<T> BHOJOHHIDFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x49B8330", Offset = "0x49B6F30", VA = "0x1849B8330")]
	public static EPHEJFPBCIA LPGMICBIONC(this EPHEJFPBCIA BHOJOHHIDFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x49B8440", Offset = "0x49B7040", VA = "0x1849B8440")]
	public static void LPGMICBIONC(Action LKFICPAOGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2760240", Offset = "0x275EE40", VA = "0x182760240")]
	private static global::NHGODCKFGMA<T> NIHFCMKOLKH<T>(global::NHGODCKFGMA<T> BHOJOHHIDFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x49B84D0", Offset = "0x49B70D0", VA = "0x1849B84D0")]
	private static EPHEJFPBCIA NIHFCMKOLKH(EPHEJFPBCIA BHOJOHHIDFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x49B85B0", Offset = "0x49B71B0", VA = "0x1849B85B0")]
	private static void OBEDODFMBJJ(LJBIBLIGMMF CMHGAHOOKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x49B7F40", Offset = "0x49B6B40", VA = "0x1849B7F40")]
	private static void BMIAIPPBCNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x49B8260", Offset = "0x49B6E60", VA = "0x1849B8260")]
	private static void DEEOKAFNBOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x49B7E90", Offset = "0x49B6A90", VA = "0x1849B7E90")]
	private static void AMPFJBKJHFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class KJAIEJDFFJO
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GPODENDPCDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public MCMONDMICNG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public GPODENDPCDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x49B9850", Offset = "0x49B8450", VA = "0x1849B9850")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x49B9840", Offset = "0x49B8440", VA = "0x1849B9840")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class INAKCEJMIMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public INAKCEJMIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x49BC960", Offset = "0x49BB560", VA = "0x1849BC960")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BDDCPAIKAEK : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private IGHAECBNBLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public MCMONDMICNG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
		[DebuggerHidden]
		public BDDCPAIKAEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x49B0920", Offset = "0x49AF520", VA = "0x1849B0920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x49B0600", Offset = "0x49AF200", VA = "0x1849B0600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x49B09D0", Offset = "0x49AF5D0", VA = "0x1849B09D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x49B08D0", Offset = "0x49AF4D0", VA = "0x1849B08D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class CAOAGDGOILK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public MCMONDMICNG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public CAOAGDGOILK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class AGKECLBGNFJ : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private IGHAECBNBLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public MCMONDMICNG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private CAOAGDGOILK <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
		[DebuggerHidden]
		public AGKECLBGNFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x49AF4E0", Offset = "0x49AE0E0", VA = "0x1849AF4E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x49AF870", Offset = "0x49AE470", VA = "0x1849AF870", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const string FDMINEFJJNL = "empty";

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public const string IHIAHFAMEJJ = "moderator";

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public const string GJAMBIEBFHO = "main_root";

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public const string AMMHMHJHFMI = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public const string LEOFILDMOGJ = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private const float DCFGIGCEJCL = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static EPHEJFPBCIA DHACGOLPMKG;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static AsyncOperation NAPHMHLLICN;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static EPHEJFPBCIA GHGINIAPDGM;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static string NAFIHCFJBNE;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static ThreadPriority KJNOBOGBKNM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool IIEPNKFBENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x49BCF30", Offset = "0x49BBB30", VA = "0x1849BCF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool CPAIMCMHCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x49BD5E0", Offset = "0x49BC1E0", VA = "0x1849BD5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool BKKMDAPEOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x49BD6F0", Offset = "0x49BC2F0", VA = "0x1849BD6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> KMOJMPDAAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x49BCFD0", Offset = "0x49BBBD0", VA = "0x1849BCFD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x49BD640", Offset = "0x49BC240", VA = "0x1849BD640")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x49BD300", Offset = "0x49BBF00", VA = "0x1849BD300")]
	[BIEDHDEFKGL(LOMHOCOLDLE.EnteredEditModeNextFrame, 0)]
	private static void HKEHGNFOKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x49BD110", Offset = "0x49BBD10", VA = "0x1849BD110")]
	public static EPHEJFPBCIA GEFEBCOMEDP(string PIJPNLBMELB, LoadSceneMode KIBIODHEGIN = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x49BD3B0", Offset = "0x49BBFB0", VA = "0x1849BD3B0")]
	public static EPHEJFPBCIA JCKEEBKNICK(string PIJPNLBMELB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x49BD080", Offset = "0x49BBC80", VA = "0x1849BD080")]
	[IteratorStateMachine(typeof(BDDCPAIKAEK))]
	private static IEnumerator<IGHAECBNBLN> DGFGECPMAAF(string PIJPNLBMELB, MCMONDMICNG JPKGPBAIOIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x49BD270", Offset = "0x49BBE70", VA = "0x1849BD270")]
	[IteratorStateMachine(typeof(AGKECLBGNFJ))]
	private static IEnumerator<IGHAECBNBLN> GNJKKPNDEOG(string PIJPNLBMELB, LoadSceneMode KIBIODHEGIN, MCMONDMICNG JPKGPBAIOIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class ALHFODFCCOM
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x49AFD50", Offset = "0x49AE950", VA = "0x1849AFD50")]
	public static IDisposable GFPIPJABLCN(this KPONONJDOFL EEBJJBKMCLF, Action EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x49AFCD0", Offset = "0x49AE8D0", VA = "0x1849AFCD0")]
	public static IDisposable GFPIPJABLCN(this KPONONJDOFL EEBJJBKMCLF, Action<float> EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x49B02C0", Offset = "0x49AEEC0", VA = "0x1849B02C0")]
	public static IDisposable PAFDILDNGHE(this KPONONJDOFL EEBJJBKMCLF, Action EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x49AFF50", Offset = "0x49AEB50", VA = "0x1849AFF50")]
	public static IDisposable JMPFIENKJEC(this KPONONJDOFL EEBJJBKMCLF, Action EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x49B0150", Offset = "0x49AED50", VA = "0x1849B0150")]
	public static IDisposable NDKCPJLKCFP(this KPONONJDOFL EEBJJBKMCLF, Action EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x49AFB50", Offset = "0x49AE750", VA = "0x1849AFB50")]
	public static IDisposable FCJBBJJJIFH(this KPONONJDOFL EEBJJBKMCLF, Action EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x49B01C0", Offset = "0x49AEDC0", VA = "0x1849B01C0")]
	public static IDisposable NPFOICDGEFB(this KPONONJDOFL EEBJJBKMCLF, Action EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x49B0230", Offset = "0x49AEE30", VA = "0x1849B0230")]
	public static IDisposable OGGEMNAFCBD(this KPONONJDOFL EEBJJBKMCLF, float KDCFEFOFHBO, Action<float> EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x49AF9D0", Offset = "0x49AE5D0", VA = "0x1849AF9D0")]
	public static IDisposable CGNOHCPACBC(this KPONONJDOFL EEBJJBKMCLF, float KDCFEFOFHBO, Action<float> EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x49AFE50", Offset = "0x49AEA50", VA = "0x1849AFE50")]
	public static IDisposable HNCDPPICLIH(this KPONONJDOFL EEBJJBKMCLF, Action<float> EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x49AFED0", Offset = "0x49AEAD0", VA = "0x1849AFED0")]
	public static IDisposable JGJANGJMLPE(this KPONONJDOFL EEBJJBKMCLF, Action<float> EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x49AFFC0", Offset = "0x49AEBC0", VA = "0x1849AFFC0")]
	public static IDisposable JOFABAPKKDE(this KPONONJDOFL EEBJJBKMCLF, Action<float> EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x49B0040", Offset = "0x49AEC40", VA = "0x1849B0040")]
	public static IDisposable LAPBHPECLPL(this KPONONJDOFL EEBJJBKMCLF, float KDCFEFOFHBO, Action<float> EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x49AF950", Offset = "0x49AE550", VA = "0x1849AF950")]
	public static IDisposable ALCJFDLCDBF(this KPONONJDOFL EEBJJBKMCLF, Action<float> EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x49AFDD0", Offset = "0x49AE9D0", VA = "0x1849AFDD0")]
	public static IDisposable GLNMFIEBFGA(this KPONONJDOFL EEBJJBKMCLF, Action<float> EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x49B00D0", Offset = "0x49AECD0", VA = "0x1849B00D0")]
	public static IDisposable LNAFFNAAKNK(this KPONONJDOFL EEBJJBKMCLF, Action<float> EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x49AFBC0", Offset = "0x49AE7C0", VA = "0x1849AFBC0")]
	public static IDisposable GBHCBAOHBDC(this KPONONJDOFL EEBJJBKMCLF, float KDCFEFOFHBO, Action<float> EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x49AFC50", Offset = "0x49AE850", VA = "0x1849AFC50")]
	public static IDisposable GFEDEODHJKD(this KPONONJDOFL EEBJJBKMCLF, Action<float> EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x49AFA50", Offset = "0x49AE650", VA = "0x1849AFA50")]
	public static IDisposable EIONDOMABFP(this KPONONJDOFL EEBJJBKMCLF, Action<float> EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x49AFAD0", Offset = "0x49AE6D0", VA = "0x1849AFAD0")]
	public static IDisposable FBFHKCJFDLK(this KPONONJDOFL EEBJJBKMCLF, Action<float> EJEAGJGGKHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class ELJBLHNHAHO
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x49B7360", Offset = "0x49B5F60", VA = "0x1849B7360")]
	public static IDisposable EFBGECHFKOD(this MonoBehaviour CJLDHNALMEK, Action EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x49B72E0", Offset = "0x49B5EE0", VA = "0x1849B72E0")]
	public static IDisposable EFBGECHFKOD(this MonoBehaviour CJLDHNALMEK, Action<float> EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x49B7A60", Offset = "0x49B6660", VA = "0x1849B7A60")]
	public static IDisposable NOJNEJFMGMD(this MonoBehaviour CJLDHNALMEK, Action EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x49B7720", Offset = "0x49B6320", VA = "0x1849B7720")]
	public static IDisposable LBOEFKBBLPD(this MonoBehaviour CJLDHNALMEK, Action EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x49B7200", Offset = "0x49B5E00", VA = "0x1849B7200")]
	public static IDisposable CPNBFKJIHGD(this MonoBehaviour CJLDHNALMEK, Action EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x49B7270", Offset = "0x49B5E70", VA = "0x1849B7270")]
	public static IDisposable EAGKKJMINED(this MonoBehaviour CJLDHNALMEK, Action EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x49B7500", Offset = "0x49B6100", VA = "0x1849B7500")]
	public static IDisposable IFHMNEEPEJI(this MonoBehaviour CJLDHNALMEK, Action EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x49B7B60", Offset = "0x49B6760", VA = "0x1849B7B60")]
	public static IDisposable OBIHDFEEGLL(this MonoBehaviour CJLDHNALMEK, float KDCFEFOFHBO, Action<float> EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x49B70D0", Offset = "0x49B5CD0", VA = "0x1849B70D0")]
	public static IDisposable BGOCKAFLKEH(this MonoBehaviour CJLDHNALMEK, float KDCFEFOFHBO, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x49B7570", Offset = "0x49B6170", VA = "0x1849B7570")]
	public static IDisposable IHOGPIPMMMJ(this MonoBehaviour CJLDHNALMEK, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x49B7690", Offset = "0x49B6290", VA = "0x1849B7690")]
	public static IDisposable KANFFMHIKHO(this MonoBehaviour CJLDHNALMEK, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x49B79D0", Offset = "0x49B65D0", VA = "0x1849B79D0")]
	public static IDisposable MODCJBBPFOB(this MonoBehaviour CJLDHNALMEK, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x49B73E0", Offset = "0x49B5FE0", VA = "0x1849B73E0")]
	public static IDisposable GOADDGPBCNF(this MonoBehaviour CJLDHNALMEK, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x49B7470", Offset = "0x49B6070", VA = "0x1849B7470")]
	public static IDisposable GOKDGLHIGGO(this MonoBehaviour CJLDHNALMEK, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x49B7AD0", Offset = "0x49B66D0", VA = "0x1849B7AD0")]
	public static IDisposable NPIJNBBDBHC(this MonoBehaviour CJLDHNALMEK, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x49B7030", Offset = "0x49B5C30", VA = "0x1849B7030")]
	public static IDisposable BANIBBNEPMD(this MonoBehaviour CJLDHNALMEK, float KDCFEFOFHBO, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x49B7C00", Offset = "0x49B6800", VA = "0x1849B7C00")]
	public static IDisposable OKBOJIPKLMK(this MonoBehaviour CJLDHNALMEK, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x49B7600", Offset = "0x49B6200", VA = "0x1849B7600")]
	public static IDisposable JDNMPFGLABJ(this MonoBehaviour CJLDHNALMEK, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x49B7790", Offset = "0x49B6390", VA = "0x1849B7790")]
	public static IDisposable LJMIMELGKDN(this MonoBehaviour CJLDHNALMEK, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x49B7160", Offset = "0x49B5D60", VA = "0x1849B7160")]
	public static IDisposable CBJMEJJHCED(this MonoBehaviour CJLDHNALMEK, float KDCFEFOFHBO, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x49B78B0", Offset = "0x49B64B0", VA = "0x1849B78B0")]
	public static IDisposable LNKPEONJCKO(this MonoBehaviour CJLDHNALMEK, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x49B7820", Offset = "0x49B6420", VA = "0x1849B7820")]
	public static IDisposable LKMEHJPDNKK(this MonoBehaviour CJLDHNALMEK, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x49B7940", Offset = "0x49B6540", VA = "0x1849B7940")]
	public static IDisposable MIAODKMHKCD(this MonoBehaviour CJLDHNALMEK, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class ADJAFDPNBPN
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class NKIKLPAPEGH : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private IGHAECBNBLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public OMLFHOPGHOI.MGFJHNGHPDM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private ENJALCJLDNN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
		[DebuggerHidden]
		public NKIKLPAPEGH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x49BE160", Offset = "0x49BCD60", VA = "0x1849BE160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x49BE220", Offset = "0x49BCE20", VA = "0x1849BE220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class FNLPHDOCAOO : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private IGHAECBNBLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public OMLFHOPGHOI.MGFJHNGHPDM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private ENJALCJLDNN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
		[DebuggerHidden]
		public FNLPHDOCAOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x49B8800", Offset = "0x49B7400", VA = "0x1849B8800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x49B88E0", Offset = "0x49B74E0", VA = "0x1849B88E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x49AF0D0", Offset = "0x49ADCD0", VA = "0x1849AF0D0")]
	public static OLAOJJPOAKP EFBGECHFKOD(Action EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x49AEED0", Offset = "0x49ADAD0", VA = "0x1849AEED0")]
	public static OLAOJJPOAKP EFBGECHFKOD(Action<float> EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x49AEDC0", Offset = "0x49AD9C0", VA = "0x1849AEDC0")]
	public static OLAOJJPOAKP EFBGECHFKOD(Behaviour EEBJJBKMCLF, Action EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x49AEFC0", Offset = "0x49ADBC0", VA = "0x1849AEFC0")]
	public static OLAOJJPOAKP EFBGECHFKOD(Behaviour EEBJJBKMCLF, Action<float> EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x49AF1C0", Offset = "0x49ADDC0", VA = "0x1849AF1C0")]
	public static OLAOJJPOAKP GFPIPJABLCN(KPONONJDOFL EEBJJBKMCLF, Action EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x49AF2D0", Offset = "0x49ADED0", VA = "0x1849AF2D0")]
	public static OLAOJJPOAKP GFPIPJABLCN(KPONONJDOFL EEBJJBKMCLF, Action<float> EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x49AF3E0", Offset = "0x49ADFE0", VA = "0x1849AF3E0")]
	[IteratorStateMachine(typeof(NKIKLPAPEGH))]
	private static IEnumerator<IGHAECBNBLN> MNFCMCNEHHE(OMLFHOPGHOI.MGFJHNGHPDM CAKLIIJIGJK, Action EJEAGJGGKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x49AF460", Offset = "0x49AE060", VA = "0x1849AF460")]
	[IteratorStateMachine(typeof(FNLPHDOCAOO))]
	private static IEnumerator<IGHAECBNBLN> MNFCMCNEHHE(OMLFHOPGHOI.MGFJHNGHPDM CAKLIIJIGJK, Action<float> EJEAGJGGKHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BHMEABGMBDE
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class NOBAFFMDKBA : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private IGHAECBNBLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public OMLFHOPGHOI.MGFJHNGHPDM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private HHBNDLLHHJE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
		[DebuggerHidden]
		public NOBAFFMDKBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x49BE370", Offset = "0x49BCF70", VA = "0x1849BE370", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x49BE480", Offset = "0x49BD080", VA = "0x1849BE480", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x49B1660", Offset = "0x49B0260", VA = "0x1849B1660")]
	public static OLAOJJPOAKP EFBGECHFKOD(float KDCFEFOFHBO, Action<float> EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x49B15A0", Offset = "0x49B01A0", VA = "0x1849B15A0")]
	public static OLAOJJPOAKP EFBGECHFKOD(MonoBehaviour CJLDHNALMEK, float KDCFEFOFHBO, Action<float> EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x49B1720", Offset = "0x49B0320", VA = "0x1849B1720")]
	public static OLAOJJPOAKP MEBDGIKMFAO(KPONONJDOFL EEBJJBKMCLF, float KDCFEFOFHBO, Action<float> EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC, bool JFIAMJNOCGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x49B17E0", Offset = "0x49B03E0", VA = "0x1849B17E0")]
	[IteratorStateMachine(typeof(NOBAFFMDKBA))]
	private static IEnumerator<IGHAECBNBLN> MNFCMCNEHHE(float KDCFEFOFHBO, OMLFHOPGHOI.MGFJHNGHPDM CAKLIIJIGJK, Action<float> EJEAGJGGKHJ, bool JFIAMJNOCGA = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class PDILKFALMCK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class NNLAJNCLPIL : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private IGHAECBNBLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public OMLFHOPGHOI.MGFJHNGHPDM queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
		[DebuggerHidden]
		public NNLAJNCLPIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x49BE270", Offset = "0x49BCE70", VA = "0x1849BE270", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x49BE320", Offset = "0x49BCF20", VA = "0x1849BE320", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x49BF620", Offset = "0x49BE220", VA = "0x1849BF620")]
	[IteratorStateMachine(typeof(NNLAJNCLPIL))]
	private static IEnumerator<IGHAECBNBLN> FGHHOPPAKJM(OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC, Func<bool> CAFGJLIIDEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x49BF6A0", Offset = "0x49BE2A0", VA = "0x1849BF6A0")]
	public static OLAOJJPOAKP FPIIKNHCEFI(this MonoBehaviour CJLDHNALMEK, Func<bool> CAFGJLIIDEM, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC = OMLFHOPGHOI.MGFJHNGHPDM.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class BEMNCKMAOHM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class PHJCBCAPLAP : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private IGHAECBNBLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public OMLFHOPGHOI.MGFJHNGHPDM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
		[DebuggerHidden]
		public PHJCBCAPLAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x49BF840", Offset = "0x49BE440", VA = "0x1849BF840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x49BF900", Offset = "0x49BE500", VA = "0x1849BF900", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class MOMDAOOILFJ : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private IGHAECBNBLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public OMLFHOPGHOI.MGFJHNGHPDM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private IGHAECBNBLN <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
		[DebuggerHidden]
		public MOMDAOOILFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x49BDAF0", Offset = "0x49BC6F0", VA = "0x1849BDAF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x49BDBC0", Offset = "0x49BC7C0", VA = "0x1849BDBC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x49B10A0", Offset = "0x49AFCA0", VA = "0x1849B10A0")]
	[IteratorStateMachine(typeof(PHJCBCAPLAP))]
	private static IEnumerator<IGHAECBNBLN> LEFEMEFCCMB(float JIPJBFMHOOP, OMLFHOPGHOI.MGFJHNGHPDM CAKLIIJIGJK, Action HIIACAGLKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x49B0F00", Offset = "0x49AFB00", VA = "0x1849B0F00")]
	[IteratorStateMachine(typeof(MOMDAOOILFJ))]
	private static IEnumerator<IGHAECBNBLN> GPGIAPBPPIN(float JIPJBFMHOOP, OMLFHOPGHOI.MGFJHNGHPDM CAKLIIJIGJK, Action HIIACAGLKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x49B0B30", Offset = "0x49AF730", VA = "0x1849B0B30")]
	public static IDisposable ECGKIIMMMKK(this MonoBehaviour CJLDHNALMEK, float JIPJBFMHOOP, Action HIIACAGLKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x49B0A30", Offset = "0x49AF630", VA = "0x1849B0A30")]
	public static OLAOJJPOAKP DHLOMFAJMJC(this MonoBehaviour CJLDHNALMEK, float JIPJBFMHOOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x49B0C80", Offset = "0x49AF880", VA = "0x1849B0C80")]
	public static OLAOJJPOAKP ECGKIIMMMKK(this MonoBehaviour CJLDHNALMEK, float JIPJBFMHOOP, OMLFHOPGHOI.MGFJHNGHPDM CAKLIIJIGJK, Action HIIACAGLKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x49B1130", Offset = "0x49AFD30", VA = "0x1849B1130")]
	public static OLAOJJPOAKP LHPHDFPEJAM(this MonoBehaviour CJLDHNALMEK, Action HIIACAGLKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x49B0DE0", Offset = "0x49AF9E0", VA = "0x1849B0DE0")]
	public static OLAOJJPOAKP FLLECGAIEBE(this MonoBehaviour CJLDHNALMEK, Action HIIACAGLKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x49B0A20", Offset = "0x49AF620", VA = "0x1849B0A20")]
	public static OLAOJJPOAKP CKDFDPGINCL(this MonoBehaviour CJLDHNALMEK, Action HIIACAGLKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x49B1140", Offset = "0x49AFD40", VA = "0x1849B1140")]
	public static OLAOJJPOAKP NPEMCENPLFP(this MonoBehaviour CJLDHNALMEK, Action HIIACAGLKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x49B1480", Offset = "0x49B0080", VA = "0x1849B1480")]
	public static OLAOJJPOAKP OKBAOIDBBBN(this MonoBehaviour CJLDHNALMEK, Action HIIACAGLKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x49B0DF0", Offset = "0x49AF9F0", VA = "0x1849B0DF0")]
	private static OLAOJJPOAKP GBKJKHCGHJH(MonoBehaviour CJLDHNALMEK, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC, Action HIIACAGLKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x49B1260", Offset = "0x49AFE60", VA = "0x1849B1260")]
	public static OLAOJJPOAKP ODKGLMFAMON(this MonoBehaviour CJLDHNALMEK, float EJBDPBLMKMN, Action HIIACAGLKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x49B1370", Offset = "0x49AFF70", VA = "0x1849B1370")]
	public static OLAOJJPOAKP OIOJHJNIGJI(this MonoBehaviour CJLDHNALMEK, float EJBDPBLMKMN, Action HIIACAGLKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x49B1490", Offset = "0x49B0090", VA = "0x1849B1490")]
	public static OLAOJJPOAKP OPELGCLHPHM(this MonoBehaviour CJLDHNALMEK, float EJBDPBLMKMN, Action HIIACAGLKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x49B1150", Offset = "0x49AFD50", VA = "0x1849B1150")]
	public static OLAOJJPOAKP OADBCHEIOBN(this MonoBehaviour CJLDHNALMEK, float EJBDPBLMKMN, Action HIIACAGLKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x49B0F90", Offset = "0x49AFB90", VA = "0x1849B0F90")]
	public static OLAOJJPOAKP JLHFJKLNLDA(this MonoBehaviour CJLDHNALMEK, float EJBDPBLMKMN, Action HIIACAGLKNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class JADBEDBIPPE : NCLEEPBLKCI
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class MPHIKNIFAFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public JADBEDBIPPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public MPHIKNIFAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x49B9A50", Offset = "0x49B8650", VA = "0x1849B9A50")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class HBEFCDMDOMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public JADBEDBIPPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public HBEFCDMDOMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x49B9A50", Offset = "0x49B8650", VA = "0x1849B9A50")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly float ICCJBBIBJHP;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x49BA9A0", Offset = "0x49B95A0", VA = "0x1849BA9A0")]
	public JADBEDBIPPE(Behaviour EEBJJBKMCLF, float ICCJBBIBJHP, [Optional] Action HMBLIGCCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x49BCA70", Offset = "0x49BB670", VA = "0x1849BCA70", Slot = "9")]
	protected override bool JFPKEEPMNKA(Action LKFICPAOGAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x49BC990", Offset = "0x49BB590", VA = "0x1849BC990", Slot = "10")]
	protected override bool DOGNKCMDFAO(Action LKFICPAOGAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface POIOCEOACCL
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool NKONCEAAHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GCEJPNLKHDD;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AJDAKPODNEB(bool LBMPEPOBNEM = false);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AJDAKPODNEB(Action LKFICPAOGAF, bool LBMPEPOBNEM = false);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public abstract class NCLEEPBLKCI : POIOCEOACCL
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class ENHDAKMJNGN : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IGHAECBNBLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
		[DebuggerHidden]
		public ENHDAKMJNGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x49B7C90", Offset = "0x49B6890", VA = "0x1849B7C90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x49B7D30", Offset = "0x49B6930", VA = "0x1849B7D30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly Behaviour EEBJJBKMCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Action HMBLIGCCCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private HJBEFNPPGPM MECGGILGJFI;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool NKONCEAAHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x903910", Offset = "0x902510", VA = "0x180903910", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GCEJPNLKHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x49BDD60", Offset = "0x49BC960", VA = "0x1849BDD60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x49BDCC0", Offset = "0x49BC8C0", VA = "0x1849BDCC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x49BE110", Offset = "0x49BCD10", VA = "0x1849BE110")]
	protected NCLEEPBLKCI(Behaviour EEBJJBKMCLF, [Optional] Action HMBLIGCCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x49BDC60", Offset = "0x49BC860", VA = "0x1849BDC60", Slot = "7")]
	public bool AJDAKPODNEB(bool LBMPEPOBNEM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x49BDC10", Offset = "0x49BC810", VA = "0x1849BDC10", Slot = "8")]
	public bool AJDAKPODNEB(Action LKFICPAOGAF, bool LBMPEPOBNEM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool JFPKEEPMNKA(Action LKFICPAOGAF);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool DOGNKCMDFAO(Action LKFICPAOGAF);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x49BDE00", Offset = "0x49BCA00", VA = "0x1849BDE00")]
	protected void GAPIDKINDIO(Action LKFICPAOGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x49BDE20", Offset = "0x49BCA20", VA = "0x1849BDE20")]
	protected EPHEJFPBCIA HLJHJINMIFC(float HLHKOKPGKKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x49BE0A0", Offset = "0x49BCCA0", VA = "0x1849BE0A0")]
	private void OGLAPFFPLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x49BE000", Offset = "0x49BCC00", VA = "0x1849BE000")]
	[IteratorStateMachine(typeof(ENHDAKMJNGN))]
	private static IEnumerator<IGHAECBNBLN> JKOIONGJHFL(float HLHKOKPGKKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x49BE060", Offset = "0x49BCC60", VA = "0x1849BE060")]
	[CompilerGenerated]
	private void LGLIPHMOOAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class KAEKIKCJCFG : NCLEEPBLKCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly float PLIHDDFIBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly int JLICIGLPGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly float OBHHKOLFFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly float[] KFBGFJMLOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private int MNBDKNENEHD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public APJDOFDJNEM LAEDIJLDDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551610", VA = "0x180552A10")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6131E0", Offset = "0x611DE0", VA = "0x1806131E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x49BCE00", Offset = "0x49BBA00", VA = "0x1849BCE00")]
	public KAEKIKCJCFG(Behaviour EEBJJBKMCLF, float IBJMHJHCMLA, int JLICIGLPGCM, [Optional] Action HMBLIGCCCBJ, float OBHHKOLFFAE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x577B90", Offset = "0x576790", VA = "0x180577B90", Slot = "9")]
	protected override bool JFPKEEPMNKA(Action LKFICPAOGAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x49BCB50", Offset = "0x49BB750", VA = "0x1849BCB50", Slot = "10")]
	protected override bool DOGNKCMDFAO(Action LKFICPAOGAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x49BCD70", Offset = "0x49BB970", VA = "0x1849BCD70")]
	private void POEAKIDLPED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class HMPKFCBICND : NCLEEPBLKCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly float ICCJBBIBJHP;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x49BA9A0", Offset = "0x49B95A0", VA = "0x1849BA9A0")]
	public HMPKFCBICND(Behaviour EEBJJBKMCLF, float ICCJBBIBJHP, [Optional] Action HMBLIGCCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x577B90", Offset = "0x576790", VA = "0x180577B90", Slot = "9")]
	protected override bool JFPKEEPMNKA(Action LKFICPAOGAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x49BA960", Offset = "0x49B9560", VA = "0x1849BA960", Slot = "10")]
	protected override bool DOGNKCMDFAO(Action LKFICPAOGAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class GKPCHOMEBCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class HCIPJNPNMFF : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private IGHAECBNBLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
		[DebuggerHidden]
		public HCIPJNPNMFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x49B9A80", Offset = "0x49B8680", VA = "0x1849B9A80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x49B9B80", Offset = "0x49B8780", VA = "0x1849B9B80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private OLAOJJPOAKP BPIHHMHHHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private KPONONJDOFL EEBJJBKMCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Action EJEAGJGGKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Action<float> PKIHAJHDDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float HHBJFCMDKHO;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x49B9330", Offset = "0x49B7F30", VA = "0x1849B9330")]
	public GKPCHOMEBCI(KPONONJDOFL EEBJJBKMCLF, Action EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x49B94F0", Offset = "0x49B80F0", VA = "0x1849B94F0")]
	public GKPCHOMEBCI(KPONONJDOFL EEBJJBKMCLF, Action<float> EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x49B91B0", Offset = "0x49B7DB0", VA = "0x1849B91B0")]
	public GKPCHOMEBCI(KPONONJDOFL EEBJJBKMCLF, float KDCFEFOFHBO, Action<float> EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x49B8D20", Offset = "0x49B7920", VA = "0x1849B8D20")]
	private void EFBGECHFKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x49B9020", Offset = "0x49B7C20", VA = "0x1849B9020")]
	private void PGJMIDEAPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x49B8BD0", Offset = "0x49B77D0", VA = "0x1849B8BD0")]
	private void EANDBOAHCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x49B8A40", Offset = "0x49B7640", VA = "0x1849B8A40")]
	private void DPNLPJLELBO(string JFBFEFFLMHK, Action KGMDPPPMBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x49B8FB0", Offset = "0x49B7BB0", VA = "0x1849B8FB0")]
	[IteratorStateMachine(typeof(HCIPJNPNMFF))]
	private IEnumerator<IGHAECBNBLN> OODPPMOIOMN(Action KGMDPPPMBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x49B8B70", Offset = "0x49B7770", VA = "0x1849B8B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x49B8F30", Offset = "0x49B7B30", VA = "0x1849B8F30")]
	[CompilerGenerated]
	private void NLEGPLNKMKO(string AADNPGFOACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x49B8EB0", Offset = "0x49B7AB0", VA = "0x1849B8EB0")]
	[CompilerGenerated]
	private void GEMGICFBBBB(string AADNPGFOACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x49B89C0", Offset = "0x49B75C0", VA = "0x1849B89C0")]
	[CompilerGenerated]
	private void BBJNNOONNLA(string AADNPGFOACH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class OJJMENPHCGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class PIILFDFICID : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private IGHAECBNBLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
		[DebuggerHidden]
		public PIILFDFICID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x49BF950", Offset = "0x49BE550", VA = "0x1849BF950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x49BFA50", Offset = "0x49BE650", VA = "0x1849BFA50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private OLAOJJPOAKP BPIHHMHHHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private MonoBehaviour CJLDHNALMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Action EJEAGJGGKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Action<float> PKIHAJHDDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private float HHBJFCMDKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool JFIAMJNOCGA;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x49BEE50", Offset = "0x49BDA50", VA = "0x1849BEE50")]
	public OJJMENPHCGA(MonoBehaviour CJLDHNALMEK, Action EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x49BF010", Offset = "0x49BDC10", VA = "0x1849BF010")]
	public OJJMENPHCGA(MonoBehaviour CJLDHNALMEK, Action<float> EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x49BF1D0", Offset = "0x49BDDD0", VA = "0x1849BF1D0")]
	public OJJMENPHCGA(MonoBehaviour CJLDHNALMEK, float KDCFEFOFHBO, Action<float> EJEAGJGGKHJ, OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC, bool JFIAMJNOCGA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x49BE9C0", Offset = "0x49BD5C0", VA = "0x1849BE9C0")]
	private void EFBGECHFKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x49BECC0", Offset = "0x49BD8C0", VA = "0x1849BECC0")]
	private void PGJMIDEAPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x49BE870", Offset = "0x49BD470", VA = "0x1849BE870")]
	private void EANDBOAHCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x49BE6E0", Offset = "0x49BD2E0", VA = "0x1849BE6E0")]
	private void DPNLPJLELBO(string JFBFEFFLMHK, Action KGMDPPPMBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x49BEC50", Offset = "0x49BD850", VA = "0x1849BEC50")]
	[IteratorStateMachine(typeof(PIILFDFICID))]
	private IEnumerator<IGHAECBNBLN> OODPPMOIOMN(Action KGMDPPPMBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x49BE810", Offset = "0x49BD410", VA = "0x1849BE810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x49BE660", Offset = "0x49BD260", VA = "0x1849BE660")]
	[CompilerGenerated]
	private void CJCCJIDBGDE(string AADNPGFOACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x49BEBD0", Offset = "0x49BD7D0", VA = "0x1849BEBD0")]
	[CompilerGenerated]
	private void LFIILNMLAGG(string AADNPGFOACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x49BEB50", Offset = "0x49BD750", VA = "0x1849BEB50")]
	[CompilerGenerated]
	private void LFGBKICFJNB(string AADNPGFOACH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface PHFJHCGKLCI
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int BPILIAKMPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class BALKJANDMCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static readonly BALKJANDMCB FGJDMGNDHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly Action HKFNEGBLLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool KNMBINEJEHO;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5B97A0", Offset = "0x5B83A0", VA = "0x1805B97A0")]
	public BALKJANDMCB(Action HKFNEGBLLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x49B0330", Offset = "0x49AEF30", VA = "0x1849B0330", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface BKGIDLBHNLC<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T EFFCIDNMALB
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable EJLNKOGMODM(Action<T> BEIADDFBGMG);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable EJLNKOGMODM(UnityEngine.Object EEBJJBKMCLF, Action<T> BEIADDFBGMG);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface LFJNDFPFCOL<T> : global::BKGIDLBHNLC<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T EFFCIDNMALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class DIOICLGDMKG<T> : global::LFJNDFPFCOL<T>, global::BKGIDLBHNLC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class HLEGMBPACKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::DIOICLGDMKG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public global::KBCNBDEOLGE<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public HLEGMBPACKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3D7F980", Offset = "0x3D7E580", VA = "0x183D7F980")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static GameObject GIJNAPLKFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly List<global::KBCNBDEOLGE<UnityEngine.Object, Action<T>>> JGCLACAEBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private T DKKGFLGGONP;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object NIAMHMCFIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3D7EA90", Offset = "0x3D7D690", VA = "0x183D7EA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T EFFCIDNMALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x811B10", Offset = "0x810710", VA = "0x180811B10", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3D7E660", Offset = "0x3D7D260", VA = "0x183D7E660", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3D7EA20", Offset = "0x3D7D620", VA = "0x183D7EA20")]
	private static bool HPBIDGBLGEJ(T FIJKOPICOJA, T JCHDICMDCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3CCF860", Offset = "0x3CCE460", VA = "0x183CCF860")]
	public DIOICLGDMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3D7EF50", Offset = "0x3D7DB50", VA = "0x183D7EF50")]
	public DIOICLGDMKG(T AKGJNKPNNNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3D7E5C0", Offset = "0x3D7D1C0", VA = "0x183D7E5C0")]
	public void CADPDILIDAB(T GLDMLGOHMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3D7E6C0", Offset = "0x3D7D2C0", VA = "0x183D7E6C0", Slot = "7")]
	public IDisposable EJLNKOGMODM(Action<T> BEIADDFBGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3D7E890", Offset = "0x3D7D490", VA = "0x183D7E890", Slot = "8")]
	public IDisposable EJLNKOGMODM(UnityEngine.Object EEBJJBKMCLF, Action<T> BEIADDFBGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3D7DF20", Offset = "0x3D7CB20", VA = "0x183D7DF20")]
	private void AIPALMFJJPA()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<DCEMIECLGDM, Scheduler>, DCEMIECLGDM
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private class HHLDIKBEPOB : PHFJHCGKLCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public DNPLIHGJEGC DOMBNAAAIPN;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int BPILIAKMPMN
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x54F010", Offset = "0x54DC10", VA = "0x18054F010", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000180")]
				[Cpp2IlInjected.Address(RVA = "0x577BA0", Offset = "0x5767A0", VA = "0x180577BA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x49B9CB0", Offset = "0x49B88B0", VA = "0x1849B9CB0")]
			public static IGHAECBNBLN ILCJEPMPFIM(IEnumerator<IGHAECBNBLN> FNPAELAEPKK, AHPJAEAKKME BBGFFDMJNNM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x49B9BD0", Offset = "0x49B87D0", VA = "0x1849B9BD0")]
			public IGHAECBNBLN ILCJEPMPFIM(AHPJAEAKKME[] EPBNNOEBEPM, IEnumerator<IGHAECBNBLN>[] MBOGIHDIDGB, IGHAECBNBLN[] FCFBGGHMOJP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x49B9EE0", Offset = "0x49B8AE0", VA = "0x1849B9EE0")]
			public void OGJBFEELDNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x49B9F10", Offset = "0x49B8B10", VA = "0x1849B9F10")]
			public void PMOCDHDNJBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x49B9E10", Offset = "0x49B8A10", VA = "0x1849B9E10")]
			public void MEFOABDLKME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x49B9EE0", Offset = "0x49B8AE0", VA = "0x1849B9EE0")]
			public void OJLBLKNICMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
			public HHLDIKBEPOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private sealed class DNPLIHGJEGC
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public struct NMODDDCOPJB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public HHLDIKBEPOB GBPLMGJCFMJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public KPONONJDOFL DNOGOLPDCJC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public AHPJAEAKKME KNCNJHMLOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public IEnumerator<IGHAECBNBLN> EBDHOMIHODE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public IGHAECBNBLN HBIEJJBPOIO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public DNEEBNIABLN MLPCMKPIPBH;
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public struct DFMMFCMOJHO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public OMLFHOPGHOI.MGFJHNGHPDM JLCLHLHPLPK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public List<NMODDDCOPJB> FDBMECHAKIM;
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private sealed class IDKEPHHPMAK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public DNPLIHGJEGC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public KPONONJDOFL context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public HHLDIKBEPOB routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public DNEEBNIABLN coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public AHPJAEAKKME promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				public IGHAECBNBLN currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public IEnumerator<IGHAECBNBLN> coroutine;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
				public IDKEPHHPMAK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x49BAA00", Offset = "0x49B9600", VA = "0x1849BAA00")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			[CompilerGenerated]
			private sealed class PDMOAEAGNJN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public HHLDIKBEPOB schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public DNPLIHGJEGC <>4__this;

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
				public PDMOAEAGNJN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x49BF800", Offset = "0x49BE400", VA = "0x1849BF800")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004E")]
			[CompilerGenerated]
			private sealed class EPDOHLOCBGA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public HHLDIKBEPOB schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public DNPLIHGJEGC <>4__this;

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
				public EPDOHLOCBGA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x49B7D80", Offset = "0x49B6980", VA = "0x1849B7D80")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004F")]
			[CompilerGenerated]
			private sealed class CMFIJLBHLDF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public HHLDIKBEPOB schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public DNPLIHGJEGC <>4__this;

				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
				public CMFIJLBHLDF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0x49B22D0", Offset = "0x49B0ED0", VA = "0x1849B22D0")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private readonly OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private bool[] BFPFNLIPMAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NativeArray<DNEEBNIABLN> EPOEBMJDBFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private NativeArray<float> DMFNEOIEALD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private NativeArray<int> NOBIEDHFNFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private NativeArray<int> MLJBDINJCNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private NativeArray<int> FPIMFPDLJCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private NativeArray<int> LMECLANNCPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private NativeArray<int> EGDDFPIOEKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private HHLDIKBEPOB[] IDBPBDBCBPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private AHPJAEAKKME[] EPBNNOEBEPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private KPONONJDOFL[] AAFPOJJCCPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private IEnumerator<IGHAECBNBLN>[] OMLGDCJEBCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private IGHAECBNBLN[] PHENEBMICEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private int MGPLCAOCMCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private int EAAJKPJKHNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private readonly int LIHINPBMMKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private float HPLOMDDKFDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private CLFADNPCMBH HCFOCMOBIJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private JobHandle FPBOOBONDAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private List<HHLDIKBEPOB> MCEMDKHOPKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private bool AGDCCHIIJMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private List<Action> GEPKGKKACBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private List<Action> IPNIEMKODMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private bool KOGHHJPLNHF;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public DFMMFCMOJHO[] CONOBKIAJHD
			{
				[Cpp2IlInjected.Token(Token = "0x6000189")]
				[Cpp2IlInjected.Address(RVA = "0x612300", Offset = "0x610F00", VA = "0x180612300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int MCNKDLFKMIN
			{
				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0xA461D0", Offset = "0xA44DD0", VA = "0x180A461D0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x49B5870", Offset = "0x49B4470", VA = "0x1849B5870")]
			private static int MNODAHOBPLG(OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x49B6270", Offset = "0x49B4E70", VA = "0x1849B6270")]
			public DNPLIHGJEGC(OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x49B56E0", Offset = "0x49B42E0", VA = "0x1849B56E0")]
			private void LNLNLMKDNOB(ref int JGMNKFGGJII, int FKHBMKKHEFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x49B4A00", Offset = "0x49B3600", VA = "0x1849B4A00")]
			public void BPBOMOHBIPI(KPONONJDOFL EEBJJBKMCLF, IGHAECBNBLN LNOPADOBAEG, IEnumerator<IGHAECBNBLN> FNPAELAEPKK, AHPJAEAKKME BBGFFDMJNNM, [Optional] HHLDIKBEPOB BFIFEBHFBLA, DNEEBNIABLN BKLAFEECJPH = DNEEBNIABLN.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x49B5180", Offset = "0x49B3D80", VA = "0x1849B5180")]
			public void JOJHIMPHFOB(IEnumerable<NMODDDCOPJB> IOOAOGHPPFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x49B5DF0", Offset = "0x49B49F0", VA = "0x1849B5DF0")]
			private NMODDDCOPJB PAIJILNHEOB(int GECJLNJKMEP)
			{
				return default(NMODDDCOPJB);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x49B5370", Offset = "0x49B3F70", VA = "0x1849B5370")]
			private void LFOHABDHMAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x2B85CA0", Offset = "0x2B848A0", VA = "0x182B85CA0")]
			private static void DIMHNOBNMND<T>(int GECJLNJKMEP, T[] BBPCBBKLKHM, int CFIGNJHENGP, [Optional] T BHDLPFKEKLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x2B85C80", Offset = "0x2B84880", VA = "0x182B85C80")]
			private static void DIMHNOBNMND<T>(int GECJLNJKMEP, NativeArray<T> BBPCBBKLKHM, int CFIGNJHENGP, [Optional] T BHDLPFKEKLE) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x49B58A0", Offset = "0x49B44A0", VA = "0x1849B58A0")]
			private void MPEKPBJBIDE(IEnumerable<NMODDDCOPJB> IOOAOGHPPFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x49B4D80", Offset = "0x49B3980", VA = "0x1849B4D80")]
			private void ICIPJJBEEEM(NMODDDCOPJB CIMOIPJCGOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x49B4E40", Offset = "0x49B3A40", VA = "0x1849B4E40")]
			private FMFNHKBKNMJ IOABHCODKIA(int AKFBCDJLCAH)
			{
				return default(FMFNHKBKNMJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x49B5B40", Offset = "0x49B4740", VA = "0x1849B5B40")]
			public void OILLEJLKOPD(float HBJHDDLMOFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x49B4C40", Offset = "0x49B3840", VA = "0x1849B4C40")]
			private void CMCFHOAENHO(Action FIJKOPICOJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x49B5100", Offset = "0x49B3D00", VA = "0x1849B5100")]
			private void JAGCDFMNCHO(Action FIJKOPICOJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x49B4560", Offset = "0x49B3160", VA = "0x1849B4560")]
			public void BODMPMHIMPC(float HBJHDDLMOFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x49B4B60", Offset = "0x49B3760", VA = "0x1849B4B60")]
			public void CCNPHFEIOJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x49B5D30", Offset = "0x49B4930", VA = "0x1849B5D30")]
			public void OJLBLKNICMO(HHLDIKBEPOB KPMIKJPBGCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x49B4CC0", Offset = "0x49B38C0", VA = "0x1849B4CC0")]
			public void DFPAAPINKFO(HHLDIKBEPOB KPMIKJPBGCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x49B44A0", Offset = "0x49B30A0", VA = "0x1849B44A0")]
			public void AFOGOKKMFFD(HHLDIKBEPOB KPMIKJPBGCB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[BurstCompile]
		public struct CLFADNPCMBH : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			[ReadOnly]
			public float NFFNBIKDALF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			[ReadOnly]
			public int JEAOALFHGJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private NativeArray<int> OBMAEEIEDNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private NativeArray<int> EEODPBHBNFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private NativeArray<int> GMJIOJPCLHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[ReadOnly]
			public NativeArray<DNEEBNIABLN> OCHBCALICLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			[ReadOnly]
			public NativeArray<float> EOGNOBGAONO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			[WriteOnly]
			public NativeArray<int> FPIMFPDLJCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			[WriteOnly]
			public NativeArray<int> NOBIEDHFNFN;

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x49B2000", Offset = "0x49B0C00", VA = "0x1849B2000")]
			public static CLFADNPCMBH JFONNKANKPC(int LFEHFHGEANA, float HBJHDDLMOFF, NativeArray<DNEEBNIABLN> KFCIEAFOJHE, NativeArray<float> NHFKCEFEBDM, NativeArray<int> BNMMIAPONDL, NativeArray<int> BOHGAGJOFJK, NativeArray<int> GMBKIKBGJMA, NativeArray<int> EEODPBHBNFJ, NativeArray<int> GMJIOJPCLHL)
			{
				return default(CLFADNPCMBH);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x49B1CB0", Offset = "0x49B08B0", VA = "0x1849B1CB0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x49B1D90", Offset = "0x49B0990", VA = "0x1849B1D90")]
			private bool GEFNEPMCDMN(int KMCFICBBFCD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x49B1C80", Offset = "0x49B0880", VA = "0x1849B1C80")]
			private void DBKJGADFDOP(NativeArray<int> HGBGCJFDPKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x49B21A0", Offset = "0x49B0DA0", VA = "0x1849B21A0")]
			private int PPKBIGPFEDJ(int BIKKGLFKOGD, int JNLDLLOGDGH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x49B20D0", Offset = "0x49B0CD0", VA = "0x1849B20D0")]
			private void PBMJHJOLKMG(NativeArray<int> HGBGCJFDPKJ, int GKMPLOHOCIO, int HKIBOOMPCGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x49B1DD0", Offset = "0x49B09D0", VA = "0x1849B1DD0")]
			private void ILOJBNIAJJI(NativeArray<int> HGBGCJFDPKJ, int KILNLOKMKLB, int BKKOMINOONO, int OACPKMOMFNO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private sealed class DPIBGGDBLCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private readonly AHPJAEAKKME BBGFFDMJNNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private readonly Behaviour EEBJJBKMCLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private readonly bool AJFKEIPJOCB;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<IGHAECBNBLN> EBDHOMIHODE
			{
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575D80", VA = "0x180577180")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public IGHAECBNBLN HBIEJJBPOIO
			{
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x555060", VA = "0x180556460")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool NAIJBOGJJAE
			{
				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x49B67C0", Offset = "0x49B53C0", VA = "0x1849B67C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool PIAEHEACDEE
			{
				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x695C70", Offset = "0x694870", VA = "0x180695C70")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x695C90", Offset = "0x694890", VA = "0x180695C90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string HDFENLJJFDG
			{
				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x5534A0", Offset = "0x5520A0", VA = "0x1805534A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x577CD0", Offset = "0x5768D0", VA = "0x180577CD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float LJBCIIBFJLG
			{
				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x8D8660", Offset = "0x8D7260", VA = "0x1808D8660")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0x9E52D0", Offset = "0x9E3ED0", VA = "0x1809E52D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x49B6C10", Offset = "0x49B5810", VA = "0x1849B6C10")]
			public DPIBGGDBLCP(IEnumerator<IGHAECBNBLN> FNPAELAEPKK, Behaviour EEBJJBKMCLF, AHPJAEAKKME BBGFFDMJNNM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x49B68E0", Offset = "0x49B54E0", VA = "0x1849B68E0")]
			public IGHAECBNBLN ILCJEPMPFIM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x49B6850", Offset = "0x49B5450", VA = "0x1849B6850")]
			public bool HPKFCNCNKCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x49B6AF0", Offset = "0x49B56F0", VA = "0x1849B6AF0")]
			public void OJLBLKNICMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x49B6B80", Offset = "0x49B5780", VA = "0x1849B6B80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x1E5FEE0", Offset = "0x1E5EAE0", VA = "0x181E5FEE0")]
			[CompilerGenerated]
			private void IDBBJEFEJID()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private sealed class AHPJAEAKKME : FFFMDOBFDHL, OLAOJJPOAKP, HJBEFNPPGPM, EPHEJFPBCIA, IEnumerator, IGHAECBNBLN, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private OMLFHOPGHOI.MGFJHNGHPDM FFGOODJPELG;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private OMLFHOPGHOI.MGFJHNGHPDM NMCKMEFEIAL
			{
				[Cpp2IlInjected.Token(Token = "0x60001BE")]
				[Cpp2IlInjected.Address(RVA = "0x712310", Offset = "0x710F10", VA = "0x180712310", Slot = "23")]
				get
				{
					return default(OMLFHOPGHOI.MGFJHNGHPDM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public OMLFHOPGHOI.MGFJHNGHPDM DOMBNAAAIPN
			{
				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0x712310", Offset = "0x710F10", VA = "0x180712310")]
				get
				{
					return default(OMLFHOPGHOI.MGFJHNGHPDM);
				}
				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x712550", Offset = "0x711150", VA = "0x180712550")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float HKEGAHJHHCP
			{
				[Cpp2IlInjected.Token(Token = "0x60001C2")]
				[Cpp2IlInjected.Address(RVA = "0x6F4230", Offset = "0x6F2E30", VA = "0x1806F4230", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x49AF8C0", Offset = "0x49AE4C0", VA = "0x1849AF8C0", Slot = "24")]
			private bool ACCNHLPBLCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x49AF8E0", Offset = "0x49AE4E0", VA = "0x1849AF8E0", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x49AF8F0", Offset = "0x49AE4F0", VA = "0x1849AF8F0")]
			public AHPJAEAKKME()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private enum FMFNHKBKNMJ : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class IHDACBKAFFP : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			public enum JLKIBLBHJEJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000056")]
			public struct FALFEDEPCHD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public OMLFHOPGHOI.MGFJHNGHPDM JLCLHLHPLPK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				public JLKIBLBHJEJ AILJHODNLDG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public List<DPIBGGDBLCP> PLHPKGPPJLG;
			}

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private static readonly JLKIBLBHJEJ[] FBPKOJDDGJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private bool GIOADOGPJEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly DPIBGGDBLCP[] JKLCNFNBCCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly List<DPIBGGDBLCP> GOFMICFNOCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private readonly Stack<int> FMBBOGKHGLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private readonly List<DPIBGGDBLCP> PPIFPLDEOPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private readonly Stack<int> BDIKPKDEAGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private bool KOGHHJPLNHF;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public FALFEDEPCHD[,] OEMKHPJLDPM
			{
				[Cpp2IlInjected.Token(Token = "0x60001C5")]
				[Cpp2IlInjected.Address(RVA = "0x552800", Offset = "0x551400", VA = "0x180552800")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int MCNKDLFKMIN
			{
				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0x49BC1D0", Offset = "0x49BADD0", VA = "0x1849BC1D0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x49BC510", Offset = "0x49BB110", VA = "0x1849BC510")]
			public IHDACBKAFFP(OMLFHOPGHOI.MGFJHNGHPDM CAKLIIJIGJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x49BC1C0", Offset = "0x49BADC0", VA = "0x1849BC1C0")]
			public void OEDGPNOMOGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x49BB790", Offset = "0x49BA390", VA = "0x1849BB790")]
			public void EPCGNPCKNBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x49BB200", Offset = "0x49B9E00", VA = "0x1849BB200")]
			private void BDECABJLEME(IReadOnlyList<DPIBGGDBLCP> JHFFLFGGLIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x49BBB90", Offset = "0x49BA790", VA = "0x1849BBB90")]
			public void KFJBOOBAKKG(DPIBGGDBLCP FNPAELAEPKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x49BB7A0", Offset = "0x49BA3A0", VA = "0x1849BB7A0")]
			public void FEFNCMDGDAL(IList<DPIBGGDBLCP> MBOGIHDIDGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x49BBE90", Offset = "0x49BAA90", VA = "0x1849BBE90")]
			public void NLFJEPECDNN(IList<DPIBGGDBLCP> MBOGIHDIDGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x49BC340", Offset = "0x49BAF40", VA = "0x1849BC340")]
			private void PODPLEBPOCJ(DPIBGGDBLCP FNPAELAEPKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x49BBA20", Offset = "0x49BA620", VA = "0x1849BBA20")]
			private void FONEEKPHPDD(IList<DPIBGGDBLCP> MBOGIHDIDGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x49BB0B0", Offset = "0x49B9CB0", VA = "0x1849BB0B0")]
			private FMFNHKBKNMJ BCGGNIKKFPB(DPIBGGDBLCP FNPAELAEPKK)
			{
				return default(FMFNHKBKNMJ);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x49BC110", Offset = "0x49BAD10", VA = "0x1849BC110")]
			public void NOJNEJFMGMD(float HBJHDDLMOFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x49BB590", Offset = "0x49BA190", VA = "0x1849BB590")]
			public void EOFAFMAHOON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x49BBCB0", Offset = "0x49BA8B0", VA = "0x1849BBCB0")]
			private void NFEBDNMEOCN(List<DPIBGGDBLCP> MBOGIHDIDGB, Stack<int> CJCAJDBMLGB, bool MICCKKFNJFP, float DJJJNPONHKN = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x49BB450", Offset = "0x49BA050", VA = "0x1849BB450", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x49BB330", Offset = "0x49B9F30", VA = "0x1849BB330")]
			private void CLMEJEPAMCO(List<DPIBGGDBLCP> MBOGIHDIDGB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[Flags]
		public enum DNEEBNIABLN : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			Inactive = 0,
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			Running = 1,
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			Cancelled = 2,
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			Paused = 4
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class FHHLBOJKLKD : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
			[DebuggerHidden]
			public FHHLBOJKLKD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x49B7DC0", Offset = "0x49B69C0", VA = "0x1849B7DC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x49B7E40", Offset = "0x49B6A40", VA = "0x1849B7E40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private const DNEEBNIABLN FPBNJLOICLG = DNEEBNIABLN.Cancelled | DNEEBNIABLN.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly OMLFHOPGHOI.MGFJHNGHPDM[] OODJIKNEEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private IHDACBKAFFP[] FLPPEEPNMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private DNPLIHGJEGC[] KADACADIOIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private Coroutine EIAHNALEOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private WaitForEndOfFrame KFPODABENHK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public OMLFHOPGHOI.MGFJHNGHPDM IDNNGKMOKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x553470", Offset = "0x552070", VA = "0x180553470")]
			[CompilerGenerated]
			get
			{
				return default(OMLFHOPGHOI.MGFJHNGHPDM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x5C9950", Offset = "0x5C8550", VA = "0x1805C9950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool DELIABLELFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x87F330", Offset = "0x87DF30", VA = "0x18087F330", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x5C9980", Offset = "0x5C8580", VA = "0x1805C9980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int MCNKDLFKMIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x49C15A0", Offset = "0x49C01A0", VA = "0x1849C15A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x49C0230", Offset = "0x49BEE30", VA = "0x1849C0230")]
		public static OLAOJJPOAKP GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x49BFD20", Offset = "0x49BE920", VA = "0x1849BFD20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x49C05E0", Offset = "0x49BF1E0", VA = "0x1849C05E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x49BFCE0", Offset = "0x49BE8E0", VA = "0x1849BFCE0")]
		private IHDACBKAFFP AKBEBBABJGC(OMLFHOPGHOI.MGFJHNGHPDM IONHFMDGLFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xCC72F0", Offset = "0xCC5EF0", VA = "0x180CC72F0")]
		private DNPLIHGJEGC LIHCPHKIJDA(OMLFHOPGHOI.MGFJHNGHPDM IONHFMDGLFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x49C0AA0", Offset = "0x49BF6A0", VA = "0x1849C0AA0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x49C0A60", Offset = "0x49BF660", VA = "0x1849C0A60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x49C1370", Offset = "0x49BFF70", VA = "0x1849C1370")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x49C04A0", Offset = "0x49BF0A0", VA = "0x1849C04A0")]
		private void JCKJONJFEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x49C0B20", Offset = "0x49BF720", VA = "0x1849C0B20")]
		private void PMKKIEPNGNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x49C0220", Offset = "0x49BEE20", VA = "0x1849C0220")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x49C05D0", Offset = "0x49BF1D0", VA = "0x1849C05D0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x49C02D0", Offset = "0x49BEED0", VA = "0x1849C02D0")]
		private void HHAJIONMNDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x49BFC70", Offset = "0x49BE870", VA = "0x1849BFC70")]
		[IteratorStateMachine(typeof(FHHLBOJKLKD))]
		private IEnumerator AKAJNLIDONG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x49C0E90", Offset = "0x49BFA90", VA = "0x1849C0E90", Slot = "7")]
		public OLAOJJPOAKP Run(IEnumerator<IGHAECBNBLN> PMKONFGGHMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x49C0C60", Offset = "0x49BF860", VA = "0x1849C0C60", Slot = "8")]
		public OLAOJJPOAKP Run(Behaviour EEBJJBKMCLF, IEnumerator<IGHAECBNBLN> PMKONFGGHMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x49C0B30", Offset = "0x49BF730", VA = "0x1849C0B30", Slot = "9")]
		public OLAOJJPOAKP RunJobbed(KPONONJDOFL EEBJJBKMCLF, IEnumerator<IGHAECBNBLN> PMKONFGGHMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x49C01C0", Offset = "0x49BEDC0", VA = "0x1849C01C0", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x49C0EA0", Offset = "0x49BFAA0", VA = "0x1849C0EA0")]
		public void UpdateQueue(OMLFHOPGHOI.MGFJHNGHPDM NHOCONNCCOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x49C02E0", Offset = "0x49BEEE0", VA = "0x1849C02E0")]
		private void HIJMGPDHAIE(IHDACBKAFFP FKAMNEHKNGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x49C04B0", Offset = "0x49BF0B0", VA = "0x1849C04B0")]
		private void JLMHMLMLNKP(DNPLIHGJEGC FKAMNEHKNGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x49C1530", Offset = "0x49C0130", VA = "0x1849C1530")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal static class FOEKJCBLFKA
{
	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x49B8930", Offset = "0x49B7530", VA = "0x1849B8930")]
	[AOGEBGNMPFC]
	private static void NFHIBICHHJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class DKGCCGPEHCP : APJDOFDJNEM
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float LFPJGHIFPKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x49B4470", Offset = "0x49B3070", VA = "0x1849B4470", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float OAKCJENAMBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x49B4440", Offset = "0x49B3040", VA = "0x1849B4440", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float NMDNIEMJKHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x49B4480", Offset = "0x49B3080", VA = "0x1849B4480", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int FJHMKJBEBFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x49B4490", Offset = "0x49B3090", VA = "0x1849B4490", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double PMPLIFGBCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x49B4450", Offset = "0x49B3050", VA = "0x1849B4450", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DKGCCGPEHCP()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class DFHLNHOECAE
{
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static byte[] BPCJOEHDNHL;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static int JGOMGPKCOBP;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static int EJPBFKNOMCK;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static BigInteger DKHAKAEJLPK;

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DFHLNHOECAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x49B3E50", Offset = "0x49B2A50", VA = "0x1849B3E50")]
	private static string ALAJABKKJNA(byte[] JCHDICMDCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x49B3F50", Offset = "0x49B2B50", VA = "0x1849B3F50")]
	public static string NBAPPGOEMPA(byte[] GLAICJAMEED, bool NFOOKAPIMMN)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
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

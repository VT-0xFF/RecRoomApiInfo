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
public class KFJNDDPBPPO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority BLFIKCIBGEL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x56C0940", Offset = "0x56BF740", VA = "0x1856C0940")]
	public KFJNDDPBPPO(ThreadPriority PHLJBLOJFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x56C0930", Offset = "0x56BF730", VA = "0x1856C0930", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> OLJGPLLNBKP(List<PlayerLoopSystem> GINNLCCNCAC, int AGIIDLHCAGI);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct FHMAEGLJJKO
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct ODGHDAFLEDI
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static CPHLPGCHIIP HHEBPIBIOOK;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x56C4F40", Offset = "0x56C3D40", VA = "0x1856C4F40")]
				public static PlayerLoopSystem CNHIDIGNPKI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct AJKFMAPGGJA
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static CPHLPGCHIIP NMLLGCLAMAA;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x56B0630", Offset = "0x56AF430", VA = "0x1856B0630")]
				public static PlayerLoopSystem CNHIDIGNPKI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct GAHLJMKINGA
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static CPHLPGCHIIP LOKEPOLJCOH;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x56B8430", Offset = "0x56B7230", VA = "0x1856B8430")]
				public static PlayerLoopSystem CNHIDIGNPKI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct ELAIHCGKHIE
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static CPHLPGCHIIP PGEGANCCDIL;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static CPHLPGCHIIP MFOAMPHHFBC;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static CPHLPGCHIIP OFFLKHAMDMG;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static CPHLPGCHIIP DKOKIDCGBBN;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x56B6810", Offset = "0x56B5610", VA = "0x1856B6810")]
				public static PlayerLoopSystem CNHIDIGNPKI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct HNKKKKIBHKB
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static CPHLPGCHIIP ODMFBFOGBBD;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x56B9810", Offset = "0x56B8610", VA = "0x1856B9810")]
				public static PlayerLoopSystem CNHIDIGNPKI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct OAOPLOPALCL
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static CPHLPGCHIIP PGEGANCCDIL;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static CPHLPGCHIIP MFOAMPHHFBC;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static CPHLPGCHIIP OFFLKHAMDMG;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static CPHLPGCHIIP DKOKIDCGBBN;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x56C4680", Offset = "0x56C3480", VA = "0x1856C4680")]
				public static PlayerLoopSystem CNHIDIGNPKI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct CMDNDKMNKNG
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static CPHLPGCHIIP OBBEMGIKDKE;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x56B1CC0", Offset = "0x56B0AC0", VA = "0x1856B1CC0")]
				public static PlayerLoopSystem CNHIDIGNPKI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct CMAKBIKNGNB
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static CPHLPGCHIIP HEHGAMLJHJA;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x56B1AE0", Offset = "0x56B08E0", VA = "0x1856B1AE0")]
				public static PlayerLoopSystem CNHIDIGNPKI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct NJHDCMAJFIF
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static CPHLPGCHIIP BMECIEAJDIJ;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x56C4300", Offset = "0x56C3100", VA = "0x1856C4300")]
				public static PlayerLoopSystem CNHIDIGNPKI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct BOBACCCKCGM
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static CPHLPGCHIIP OLGDKBBMFNA;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x56B1160", Offset = "0x56AFF60", VA = "0x1856B1160")]
				public static PlayerLoopSystem CNHIDIGNPKI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct PBIEPDALMOJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static CPHLPGCHIIP JNODICLMBEB;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x56C53B0", Offset = "0x56C41B0", VA = "0x1856C53B0")]
				public static PlayerLoopSystem CNHIDIGNPKI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			internal struct PFEOJCBIDIJ
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				[CompilerGenerated]
				private sealed class MBJCOAMCOLA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002B")]
					public MBCGJEPLHDB.DBJDDPHHDGP key;

					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
					public MBJCOAMCOLA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x56C2B40", Offset = "0x56C1940", VA = "0x1856C2B40")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable IGPCLNHNCCD;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x56C5E20", Offset = "0x56C4C20", VA = "0x1856C5E20")]
				public static PlayerLoopSystem KDCNAFDNAOA(MBCGJEPLHDB.DBJDDPHHDGP ANFHHLAHMJD)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct MEBCHKPDNMP
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class ICPIAFKBGEO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002E")]
					public MBCGJEPLHDB.DBJDDPHHDGP key;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
					public ICPIAFKBGEO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x56B9AF0", Offset = "0x56B88F0", VA = "0x1856B9AF0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x56C2DB0", Offset = "0x56C1BB0", VA = "0x1856C2DB0")]
				public static PlayerLoopSystem KDCNAFDNAOA(MBCGJEPLHDB.DBJDDPHHDGP ANFHHLAHMJD)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class FMKKIBDOLGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public FMKKIBDOLGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x56B7F50", Offset = "0x56B6D50", VA = "0x1856B7F50")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool KGAPHAJPPHG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool LHJNNJGHGLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x56B20D0", Offset = "0x56B0ED0", VA = "0x1856B20D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x56B33F0", Offset = "0x56B21F0", VA = "0x1856B33F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x56B3430", Offset = "0x56B2230", VA = "0x1856B3430")]
		private static void PLEGKJOHDHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x56B2110", Offset = "0x56B0F10", VA = "0x1856B2110")]
		private static void CDMFPFDDDAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x56B2F90", Offset = "0x56B1D90", VA = "0x1856B2F90")]
		private static void HEMNOGLMKJG(string PAJCKOFPNDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x56B1EA0", Offset = "0x56B0CA0", VA = "0x1856B1EA0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x56B2DD0", Offset = "0x56B1BD0", VA = "0x1856B2DD0")]
		private static void HCMOOKMKAOP(MBCGJEPLHDB.DBJDDPHHDGP ANFHHLAHMJD, ref PlayerLoopSystem NFABIGKHFHB, Type BADJAFEKNAC, Type PNIHIDDMFCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x56B29E0", Offset = "0x56B17E0", VA = "0x1856B29E0")]
		private static void FGAEAKHIFFL(ref PlayerLoopSystem NFABIGKHFHB, Type BADJAFEKNAC, Type PNIHIDDMFCL, OLJGPLLNBKP IBDPHBFHEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x56B32C0", Offset = "0x56B20C0", VA = "0x1856B32C0")]
		private static void LEHJMNIPLEK(ref PlayerLoopSystem NFABIGKHFHB, Type BADJAFEKNAC, Type PNIHIDDMFCL, PlayerLoopSystem? HOEELJBKKNG, PlayerLoopSystem? HKEILGAKCLP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class MBCGJEPLHDB
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum DBJDDPHHDGP
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class HLPEDIEEOJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly DBJDDPHHDGP FNGGLACIPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly FDBOJGPFMEC HMCKPDDFBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private long ACCOHBNKMAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private long PHMBJFMJDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long OHNJKCGFHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int GFMHCEAONCC;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x56B9710", Offset = "0x56B8510", VA = "0x1856B9710")]
		public HLPEDIEEOJG(DBJDDPHHDGP CMEIFLNMFGC, int BJPAMLOGMMM = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x56B9440", Offset = "0x56B8240", VA = "0x1856B9440")]
		public void BOCKPLBOJGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x56B94B0", Offset = "0x56B82B0", VA = "0x1856B94B0")]
		public void EMKBBAAPKCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x56B9510", Offset = "0x56B8310", VA = "0x1856B9510")]
		public void MNMCPEKGPDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static DBJDDPHHDGP[] LGGNAEHAFFL;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static HLPEDIEEOJG[] LBBKJKCFILJ;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x56C26D0", Offset = "0x56C14D0", VA = "0x1856C26D0")]
	public static HLPEDIEEOJG ACENIJJKAMB(DBJDDPHHDGP ANFHHLAHMJD, int BJPAMLOGMMM = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x56C2950", Offset = "0x56C1750", VA = "0x1856C2950")]
	public static HLPEDIEEOJG KPABNFNDBJE(DBJDDPHHDGP ANFHHLAHMJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x56C28A0", Offset = "0x56C16A0", VA = "0x1856C28A0")]
	public static void FCCOPMKGFDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class FDBOJGPFMEC : JKHEDGFHNPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int IGIPIIIPPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Queue<double> IPLMHNCDOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private double FEFPPFDPNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private double PEEJGOJECJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private double OMGADOBJDLM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double JBNNBFFEKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x56B70B0", Offset = "0x56B5EB0", VA = "0x1856B70B0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double PJABELFPFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x87DBD0", Offset = "0x87C9D0", VA = "0x18087DBD0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double MAKBJKPKOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7B3F90", Offset = "0x7B2D90", VA = "0x1807B3F90", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x56B7110", Offset = "0x56B5F10", VA = "0x1856B7110")]
	public FDBOJGPFMEC(int PFHLGELLCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x56B6F10", Offset = "0x56B5D10", VA = "0x1856B6F10", Slot = "7")]
	public void AODOAIJMMFG(double JMFDIAPBCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x56B7040", Offset = "0x56B5E40", VA = "0x1856B7040", Slot = "8")]
	public void CELKGMNMMPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MFANGJBBGKL : JKHEDGFHNPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private long PHHDFCFDFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private double DLOCOMBGJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private double OBJCCDCHFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private double MFIGHCNICLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private double OIBGHMMAOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private double FEFPPFDPNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private double PEEJGOJECJH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double PJABELFPFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x87DBC0", Offset = "0x87C9C0", VA = "0x18087DBC0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double MAKBJKPKOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x87DC40", Offset = "0x87CA40", VA = "0x18087DC40", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double HCIFPNFDCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7B3F80", Offset = "0x7B2D80", VA = "0x1807B3F80")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double JBNNBFFEKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x87DAD0", Offset = "0x87C8D0", VA = "0x18087DAD0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x56C2EE0", Offset = "0x56C1CE0", VA = "0x1856C2EE0", Slot = "7")]
	public virtual void AODOAIJMMFG(double JMFDIAPBCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x56C3010", Offset = "0x56C1E10", VA = "0x1856C3010", Slot = "8")]
	public virtual void CELKGMNMMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x56C3050", Offset = "0x56C1E50", VA = "0x1856C3050")]
	public MFANGJBBGKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ODGBBBIIHFA : MFANGJBBGKL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double PLMHFNAMFOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x56C4F30", Offset = "0x56C3D30", VA = "0x1856C4F30")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x56C4F20", Offset = "0x56C3D20", VA = "0x1856C4F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x56C4DA0", Offset = "0x56C3BA0", VA = "0x1856C4DA0", Slot = "7")]
	public override void AODOAIJMMFG(double JMFDIAPBCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x56C4EE0", Offset = "0x56C3CE0", VA = "0x1856C4EE0", Slot = "8")]
	public override void CELKGMNMMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x56C3050", Offset = "0x56C1E50", VA = "0x1856C3050")]
	public ODGBBBIIHFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface JKHEDGFHNPP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double JBNNBFFEKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double PJABELFPFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double MAKBJKPKOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class MAANPDGNHLL
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private interface KLKDKNKGJED
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool JOGDPPPMKCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EMMGNHCOPMF();
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private abstract class MCFPMKLIENF<TPromise, TMainThreadPromise> : KLKDKNKGJED where TPromise : LMAPELGHNPL where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly TPromise NIKFMHPCGEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected readonly TMainThreadPromise MINNNEINNLC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise DMHNNGPOGGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x35E32D0", Offset = "0x35E20D0", VA = "0x1835E32D0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool JOGDPPPMKCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x35E3330", Offset = "0x35E2130", VA = "0x1835E3330", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B11300", Offset = "0x2B10100", VA = "0x182B11300")]
		protected MCFPMKLIENF(TPromise NIKFMHPCGEK, TMainThreadPromise MACGLKENJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x35E32A0", Offset = "0x35E20A0", VA = "0x1835E32A0", Slot = "5")]
		public void EMMGNHCOPMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void CANJLMDBJAF(TPromise NIKFMHPCGEK);
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class HHLNOLOFEFC<T> : MCFPMKLIENF<global::ONJEHKCKOLK<T>, global::NGNFCAOIKLE<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3A8CB00", Offset = "0x3A8B900", VA = "0x183A8CB00")]
		public HHLNOLOFEFC(global::ONJEHKCKOLK<T> NIKFMHPCGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3A8C920", Offset = "0x3A8B720", VA = "0x183A8C920", Slot = "6")]
		protected override void CANJLMDBJAF(global::ONJEHKCKOLK<T> NIKFMHPCGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3A8CAD0", Offset = "0x3A8B8D0", VA = "0x183A8CAD0")]
		[CompilerGenerated]
		private void IABILJDKJNL(T DGEANHLCFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1FED250", Offset = "0x1FEC050", VA = "0x181FED250")]
		[CompilerGenerated]
		private void KBPFGDJLAJO(string EDMHEICKIIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class KAMDBPLDPDE : KLKDKNKGJED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Action KKJDJCJOLIF;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JOGDPPPMKCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x70F850", Offset = "0x70E650", VA = "0x18070F850", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x76B3B0", Offset = "0x76A1B0", VA = "0x18076B3B0")]
		public KAMDBPLDPDE(Action KKJDJCJOLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1272B50", Offset = "0x1271950", VA = "0x181272B50", Slot = "5")]
		public void EMMGNHCOPMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly List<KLKDKNKGJED> GOCNAAFABIE;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2E61770", Offset = "0x2E60570", VA = "0x182E61770")]
	public static global::ONJEHKCKOLK<T> ANMAHALGEAB<T>(this global::ONJEHKCKOLK<T> NIKFMHPCGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x56C1F00", Offset = "0x56C0D00", VA = "0x1856C1F00")]
	public static void ANMAHALGEAB(Action KKJDJCJOLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2E617E0", Offset = "0x2E605E0", VA = "0x182E617E0")]
	private static global::ONJEHKCKOLK<T> ONABAPBHLLK<T>(global::ONJEHKCKOLK<T> NIKFMHPCGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x56C2350", Offset = "0x56C1150", VA = "0x1856C2350")]
	private static void GDKIMCNMCPC(KLKDKNKGJED BFEKGGFHBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x56C1F90", Offset = "0x56C0D90", VA = "0x1856C1F90")]
	private static void CABOBEOEKCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x56C2550", Offset = "0x56C1350", VA = "0x1856C2550")]
	private static void IOIAGEFCCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x56C2280", Offset = "0x56C1080", VA = "0x1856C2280")]
	private static void EPCMOPAIJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class PJHJDDHEFNC
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private struct DGBKLNLFEAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public TaskCompletionSource<Scene> ABFAPMFKECG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly string DDFGJPPGHLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly LoadSceneMode KPINONPDFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly bool APDKOPAPPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly KHFLMDIKDOP BFCGDDALELD;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x56B6480", Offset = "0x56B5280", VA = "0x1856B6480")]
		public DGBKLNLFEAK(TaskCompletionSource<Scene> BDFHNDBMPGJ, string DDFGJPPGHLO, LoadSceneMode KPINONPDFCE, bool APDKOPAPPIL, KHFLMDIKDOP BFCGDDALELD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct LIKFGMAAOAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public KHFLMDIKDOP stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private global::GKOFEHKMFNM<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x56C12C0", Offset = "0x56C00C0", VA = "0x1856C12C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x56C1930", Offset = "0x56C0730", VA = "0x1856C1930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct GBMJPHFJPMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x56B8610", Offset = "0x56B7410", VA = "0x1856B8610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x14868C0", Offset = "0x14856C0", VA = "0x1814868C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct FLHGIDPPNAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private DGBKLNLFEAK <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x56B7BC0", Offset = "0x56B69C0", VA = "0x1856B7BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x14868C0", Offset = "0x14856C0", VA = "0x1814868C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class LICKFOFMDEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public global::NGNFCAOIKLE<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public LICKFOFMDEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x56C1260", Offset = "0x56C0060", VA = "0x1856C1260")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct HJOOJPMCPPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public KHFLMDIKDOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private LICKFOFMDEL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private KHFLMDIKDOP <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private KHFLMDIKDOP <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x56B8A70", Offset = "0x56B7870", VA = "0x1856B8A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x56B93F0", Offset = "0x56B81F0", VA = "0x1856B93F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct PCMALKJLBHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KHFLMDIKDOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private KHFLMDIKDOP <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private KHFLMDIKDOP <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x56C5590", Offset = "0x56C4390", VA = "0x1856C5590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x56C5DD0", Offset = "0x56C4BD0", VA = "0x1856C5DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class BPKGLDMMDIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public BPKGLDMMDIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x56B1AB0", Offset = "0x56B08B0", VA = "0x1856B1AB0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class NCCLKBINHPG : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private FFIMBIIMMMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NGNPLNHEGFI onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
		[DebuggerHidden]
		public NCCLKBINHPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x56C38F0", Offset = "0x56C26F0", VA = "0x1856C38F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x56C3590", Offset = "0x56C2390", VA = "0x1856C3590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x56C3980", Offset = "0x56C2780", VA = "0x1856C3980")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x56C38B0", Offset = "0x56C26B0", VA = "0x1856C38B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class FPBLJPCIGEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public global::NGNFCAOIKLE<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public FPBLJPCIGEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class ODFHDHOLIFL : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private FFIMBIIMMMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public global::NGNFCAOIKLE<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private FPBLJPCIGEH <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
		[DebuggerHidden]
		public ODFHDHOLIFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x56C4910", Offset = "0x56C3710", VA = "0x1856C4910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x56C4D60", Offset = "0x56C3B60", VA = "0x1856C4D60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static LMAPELGHNPL NDHCJLJNEGP;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AsyncOperation MLGHOGDDAFG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static LMAPELGHNPL PEMJMOBINMC;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static string AGNMODNFLLD;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static ThreadPriority GOKKMDOPDDO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Task JNIINFDGAHE;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly Queue<DGBKLNLFEAK> IDIBMAJFOJA;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static Task BFJGGNKBLKC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool MDDMGOCGHEO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x56C75B0", Offset = "0x56C63B0", VA = "0x1856C75B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool EBHJLJJEFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x56C6F60", Offset = "0x56C5D60", VA = "0x1856C6F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool IBCHHLHEALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x56C70B0", Offset = "0x56C5EB0", VA = "0x1856C70B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> OKFDGFFAFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x56C66F0", Offset = "0x56C54F0", VA = "0x1856C66F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x56C67F0", Offset = "0x56C55F0", VA = "0x1856C67F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x56C6BD0", Offset = "0x56C59D0", VA = "0x1856C6BD0")]
	[PONPKGMPDGG(ELCDPILLABI.EnteredEditModeNextFrame, 0)]
	private static void FDLHAKGGFNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x56C7450", Offset = "0x56C6250", VA = "0x1856C7450")]
	[AsyncStateMachine(typeof(LIKFGMAAOAE))]
	public static Task<Scene> MJOJKOKKDCE(string DDFGJPPGHLO, LoadSceneMode KPINONPDFCE = LoadSceneMode.Single, bool APDKOPAPPIL = false, [Optional] KHFLMDIKDOP NLJFCAENIBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x56C7770", Offset = "0x56C6570", VA = "0x1856C7770")]
	[AsyncStateMachine(typeof(GBMJPHFJPMA))]
	private static Task OCFGKBLNHDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x56C7840", Offset = "0x56C6640", VA = "0x1856C7840")]
	[AsyncStateMachine(typeof(FLHGIDPPNAM))]
	private static Task OKFLHGGOKHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x56C6CA0", Offset = "0x56C5AA0", VA = "0x1856C6CA0")]
	[AsyncStateMachine(typeof(HJOOJPMCPPJ))]
	private static Task<Scene> GDNLAKJPLHB(string DDFGJPPGHLO, LoadSceneMode KPINONPDFCE, bool APDKOPAPPIL, KHFLMDIKDOP BFCGDDALELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x56C7170", Offset = "0x56C5F70", VA = "0x1856C7170")]
	[AsyncStateMachine(typeof(PCMALKJLBHH))]
	private static Task<Scene> KNGJGDFDHKC(KHFLMDIKDOP BFCGDDALELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x56C72B0", Offset = "0x56C60B0", VA = "0x1856C72B0")]
	public static global::ONJEHKCKOLK<Scene> MDNBPKGGCMF(string DDFGJPPGHLO, LoadSceneMode KPINONPDFCE = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x56C68F0", Offset = "0x56C56F0", VA = "0x1856C68F0")]
	public static LMAPELGHNPL ELEFFBPABLJ(string DDFGJPPGHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x56C6660", Offset = "0x56C5460", VA = "0x1856C6660")]
	[IteratorStateMachine(typeof(NCCLKBINHPG))]
	private static IEnumerator<FFIMBIIMMMD> BLNHBBJCMMH(string DDFGJPPGHLO, NGNPLNHEGFI NNANKMJPOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x56C7010", Offset = "0x56C5E10", VA = "0x1856C7010")]
	[IteratorStateMachine(typeof(ODFHDHOLIFL))]
	private static IEnumerator<FFIMBIIMMMD> JCLMJCPCPMO(string DDFGJPPGHLO, LoadSceneMode KPINONPDFCE, global::NGNFCAOIKLE<Scene> NNANKMJPOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x56C6E00", Offset = "0x56C5C00", VA = "0x1856C6E00")]
	public static bool HMMIJHILMIE(out string MLJIKGABFGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class LBEAGEDFIBO
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x56C11E0", Offset = "0x56BFFE0", VA = "0x1856C11E0")]
	public static IDisposable NGNDCIODFIP(this LCPJFIPJNDD KPEPJOHCOMD, float OBGBOJHKCAO, Action<float> OHNIAEDHHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x56C1160", Offset = "0x56BFF60", VA = "0x1856C1160")]
	public static IDisposable HJMCHJKBHDJ(this LCPJFIPJNDD KPEPJOHCOMD, Action<float> OHNIAEDHHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x56C10E0", Offset = "0x56BFEE0", VA = "0x1856C10E0")]
	public static IDisposable FALNBMGIDGM(this LCPJFIPJNDD KPEPJOHCOMD, Action<float> OHNIAEDHHJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class FGKABKKCPNK
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x56B74D0", Offset = "0x56B62D0", VA = "0x1856B74D0")]
	public static IDisposable CMDHHHPFDLN(this MonoBehaviour NOMJAEPALLK, Action OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x56B7450", Offset = "0x56B6250", VA = "0x1856B7450")]
	public static IDisposable CMDHHHPFDLN(this MonoBehaviour NOMJAEPALLK, Action<float> OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x56B72D0", Offset = "0x56B60D0", VA = "0x1856B72D0")]
	public static IDisposable CAMMFFCGHBK(this MonoBehaviour NOMJAEPALLK, Action OHNIAEDHHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x56B76B0", Offset = "0x56B64B0", VA = "0x1856B76B0")]
	public static IDisposable GMONNENGCBC(this MonoBehaviour NOMJAEPALLK, Action OHNIAEDHHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x56B7250", Offset = "0x56B6050", VA = "0x1856B7250")]
	public static IDisposable BNGONBJLHDO(this MonoBehaviour NOMJAEPALLK, Action OHNIAEDHHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x56B7B40", Offset = "0x56B6940", VA = "0x1856B7B40")]
	public static IDisposable OBPCHHCDEED(this MonoBehaviour NOMJAEPALLK, Action OHNIAEDHHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x56B73D0", Offset = "0x56B61D0", VA = "0x1856B73D0")]
	public static IDisposable CLHMOHNGMBP(this MonoBehaviour NOMJAEPALLK, Action OHNIAEDHHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x56B77C0", Offset = "0x56B65C0", VA = "0x1856B77C0")]
	public static IDisposable JPDJEEIAKAP(this MonoBehaviour NOMJAEPALLK, float OBGBOJHKCAO, Action<float> OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO, bool LGKFKCOIKAH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x56B7680", Offset = "0x56B6480", VA = "0x1856B7680")]
	public static IDisposable FJNMAFEKJCH(this MonoBehaviour NOMJAEPALLK, float OBGBOJHKCAO, Action<float> OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO, bool LGKFKCOIKAH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x56B78F0", Offset = "0x56B66F0", VA = "0x1856B78F0")]
	public static IDisposable KKIAAGEEJJL(this MonoBehaviour NOMJAEPALLK, float OBGBOJHKCAO, Action<float> OHNIAEDHHJI, bool LGKFKCOIKAH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x56B7550", Offset = "0x56B6350", VA = "0x1856B7550")]
	public static IDisposable DNEJBDPOPOL(this MonoBehaviour NOMJAEPALLK, Action<float> OHNIAEDHHJI, bool LGKFKCOIKAH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x56B7860", Offset = "0x56B6660", VA = "0x1856B7860")]
	public static IDisposable KBNCHEIOPIE(this MonoBehaviour NOMJAEPALLK, Action<float> OHNIAEDHHJI, bool LGKFKCOIKAH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x56B7AB0", Offset = "0x56B68B0", VA = "0x1856B7AB0")]
	public static IDisposable MEGHLLEMLFE(this MonoBehaviour NOMJAEPALLK, Action<float> OHNIAEDHHJI, bool LGKFKCOIKAH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x56B71C0", Offset = "0x56B5FC0", VA = "0x1856B71C0")]
	public static IDisposable ALLHDNHGMHH(this MonoBehaviour NOMJAEPALLK, Action<float> OHNIAEDHHJI, bool LGKFKCOIKAH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x56B7730", Offset = "0x56B6530", VA = "0x1856B7730")]
	public static IDisposable IILKPHLIKDF(this MonoBehaviour NOMJAEPALLK, Action<float> OHNIAEDHHJI, bool LGKFKCOIKAH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x56B7340", Offset = "0x56B6140", VA = "0x1856B7340")]
	public static IDisposable CFDKDPDKCCH(this MonoBehaviour NOMJAEPALLK, Action<float> OHNIAEDHHJI, bool LGKFKCOIKAH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x56B7990", Offset = "0x56B6790", VA = "0x1856B7990")]
	public static IDisposable LDKEJJCMJIK(this MonoBehaviour NOMJAEPALLK, Action<float> OHNIAEDHHJI, bool LGKFKCOIKAH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x56B75E0", Offset = "0x56B63E0", VA = "0x1856B75E0")]
	public static IDisposable FEAFKFIPNFM(this MonoBehaviour NOMJAEPALLK, float OBGBOJHKCAO, Action<float> OHNIAEDHHJI, bool LGKFKCOIKAH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x56B7A20", Offset = "0x56B6820", VA = "0x1856B7A20")]
	public static IDisposable LLCEOAOFCOP(this MonoBehaviour NOMJAEPALLK, Action<float> OHNIAEDHHJI, bool LGKFKCOIKAH = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class IHOMDCJHIEN
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class BNCCNJBIHCO : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private FFIMBIIMMMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public FNNACPPACGP.KCEPDILKHND queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private IKDKMIMBGJL <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
		[DebuggerHidden]
		public BNCCNJBIHCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x56B1060", Offset = "0x56AFE60", VA = "0x1856B1060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x56B1120", Offset = "0x56AFF20", VA = "0x1856B1120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class JFGJDDBHHPE : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private FFIMBIIMMMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public FNNACPPACGP.KCEPDILKHND queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private IKDKMIMBGJL <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
		[DebuggerHidden]
		public JFGJDDBHHPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x56BC3B0", Offset = "0x56BB1B0", VA = "0x1856BC3B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x56BC4A0", Offset = "0x56BB2A0", VA = "0x1856BC4A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x56B9F50", Offset = "0x56B8D50", VA = "0x1856B9F50")]
	public static OMJDCAMIDEI CMDHHHPFDLN(Action OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x56B9E90", Offset = "0x56B8C90", VA = "0x1856B9E90")]
	public static OMJDCAMIDEI CMDHHHPFDLN(Behaviour KPEPJOHCOMD, Action OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x56B9D80", Offset = "0x56B8B80", VA = "0x1856B9D80")]
	public static OMJDCAMIDEI CMDHHHPFDLN(Behaviour KPEPJOHCOMD, Action<float> OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x56BA080", Offset = "0x56B8E80", VA = "0x1856BA080")]
	[IteratorStateMachine(typeof(BNCCNJBIHCO))]
	private static IEnumerator<FFIMBIIMMMD> HFONEPNJKMC(FNNACPPACGP.KCEPDILKHND BAPHNFLMDKN, Action OHNIAEDHHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x56BA000", Offset = "0x56B8E00", VA = "0x1856BA000")]
	[IteratorStateMachine(typeof(JFGJDDBHHPE))]
	private static IEnumerator<FFIMBIIMMMD> HFONEPNJKMC(FNNACPPACGP.KCEPDILKHND BAPHNFLMDKN, Action<float> OHNIAEDHHJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class BGOAHMPEOIE
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class JBAGGCDHHHE : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private FFIMBIIMMMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public JILJPDHCDCB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
		[DebuggerHidden]
		public JBAGGCDHHHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x56BC2D0", Offset = "0x56BB0D0", VA = "0x1856BC2D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x56BC370", Offset = "0x56BB170", VA = "0x1856BC370", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x56B0AE0", Offset = "0x56AF8E0", VA = "0x1856B0AE0")]
	public static OMJDCAMIDEI CMDHHHPFDLN(float OBGBOJHKCAO, Action<float> OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO, bool LGKFKCOIKAH = true, [Optional] PPENLAHPKHK FILPBFCPPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x56B09D0", Offset = "0x56AF7D0", VA = "0x1856B09D0")]
	public static OMJDCAMIDEI CMDHHHPFDLN(MonoBehaviour NOMJAEPALLK, float OBGBOJHKCAO, Action<float> OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO, bool LGKFKCOIKAH = true, [Optional] PPENLAHPKHK FILPBFCPPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x56B0DE0", Offset = "0x56AFBE0", VA = "0x1856B0DE0")]
	public static OMJDCAMIDEI HEMDGGLAJCM(MonoBehaviour NOMJAEPALLK, float OBGBOJHKCAO, Action<float> OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO, bool LGKFKCOIKAH = true, [Optional] PPENLAHPKHK FILPBFCPPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x56B0C40", Offset = "0x56AFA40", VA = "0x1856B0C40")]
	public static OMJDCAMIDEI FGJLFPOAAMB(LCPJFIPJNDD KPEPJOHCOMD, float OBGBOJHKCAO, Action<float> OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO, bool LGKFKCOIKAH = true, [Optional] PPENLAHPKHK FILPBFCPPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x56B0F00", Offset = "0x56AFD00", VA = "0x1856B0F00")]
	private static IEnumerator<FFIMBIIMMMD> HFONEPNJKMC(IONPAFOCMFL OBOCKAFNNCL, float OBGBOJHKCAO, FNNACPPACGP.KCEPDILKHND BAPHNFLMDKN, Action<float> OHNIAEDHHJI, bool LGKFKCOIKAH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x56B0BE0", Offset = "0x56AF9E0", VA = "0x1856B0BE0")]
	private static IEnumerator<FFIMBIIMMMD> DFJLLBPHNOP(IONPAFOCMFL OBOCKAFNNCL, float OBGBOJHKCAO, FNNACPPACGP.KCEPDILKHND BAPHNFLMDKN, Action<float> OHNIAEDHHJI, bool LGKFKCOIKAH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x56B0D50", Offset = "0x56AFB50", VA = "0x1856B0D50")]
	[IteratorStateMachine(typeof(JBAGGCDHHHE))]
	private static IEnumerator<FFIMBIIMMMD> GEPFLFKELPF(JILJPDHCDCB PKACOHPHMLL, float OBGBOJHKCAO, FNNACPPACGP.KCEPDILKHND BAPHNFLMDKN, Action<float> OHNIAEDHHJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BBFJAGBNBKH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class FONOJJHJAKG : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private FFIMBIIMMMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public FNNACPPACGP.KCEPDILKHND queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
		[DebuggerHidden]
		public FONOJJHJAKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x56B8070", Offset = "0x56B6E70", VA = "0x1856B8070", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x56B8120", Offset = "0x56B6F20", VA = "0x1856B8120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x56B0840", Offset = "0x56AF640", VA = "0x1856B0840")]
	[IteratorStateMachine(typeof(FONOJJHJAKG))]
	private static IEnumerator<FFIMBIIMMMD> BJMICDCNIMA(FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO, Func<bool> JBMKOCDICIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x56B08C0", Offset = "0x56AF6C0", VA = "0x1856B08C0")]
	public static OMJDCAMIDEI PPEFJMNFBGO(this MonoBehaviour NOMJAEPALLK, Func<bool> JBMKOCDICIN, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO = FNNACPPACGP.KCEPDILKHND.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class JODOCEIDMEN
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class IBHPBCJGCLE : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private FFIMBIIMMMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public FNNACPPACGP.KCEPDILKHND queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
		[DebuggerHidden]
		public IBHPBCJGCLE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x56B99F0", Offset = "0x56B87F0", VA = "0x1856B99F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x56B9AB0", Offset = "0x56B88B0", VA = "0x1856B9AB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x56BF490", Offset = "0x56BE290", VA = "0x1856BF490")]
	[IteratorStateMachine(typeof(IBHPBCJGCLE))]
	private static IEnumerator<FFIMBIIMMMD> OJBAAEKEBEA(float IHNJKOANCPJ, FNNACPPACGP.KCEPDILKHND BAPHNFLMDKN, Action HHJDMJPABNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x56BEE00", Offset = "0x56BDC00", VA = "0x1856BEE00")]
	public static OMJDCAMIDEI AJAPCKMAFAI(this MonoBehaviour NOMJAEPALLK, float IHNJKOANCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x56BF340", Offset = "0x56BE140", VA = "0x1856BF340")]
	public static OMJDCAMIDEI KFIPMIHDEFC(this MonoBehaviour NOMJAEPALLK, Action HHJDMJPABNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x56BEEC0", Offset = "0x56BDCC0", VA = "0x1856BEEC0")]
	public static OMJDCAMIDEI BDKOFNFEANF(this MonoBehaviour NOMJAEPALLK, Action HHJDMJPABNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x56BF190", Offset = "0x56BDF90", VA = "0x1856BF190")]
	public static OMJDCAMIDEI GBBFJENFLML(this MonoBehaviour NOMJAEPALLK, Action HHJDMJPABNC, [Optional] PPENLAHPKHK FILPBFCPPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x56BEFC0", Offset = "0x56BDDC0", VA = "0x1856BEFC0")]
	public static OMJDCAMIDEI DACGJMEIABB(this MonoBehaviour NOMJAEPALLK, Action HHJDMJPABNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x56BF360", Offset = "0x56BE160", VA = "0x1856BF360")]
	public static OMJDCAMIDEI MCEDPFCJEID(this MonoBehaviour NOMJAEPALLK, Action HHJDMJPABNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x56BF460", Offset = "0x56BE260", VA = "0x1856BF460")]
	public static OMJDCAMIDEI OHFOJNPOOCI(this MonoBehaviour NOMJAEPALLK, Action HHJDMJPABNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x56BEEF0", Offset = "0x56BDCF0", VA = "0x1856BEEF0")]
	private static OMJDCAMIDEI CLIFPEMHKLM(MonoBehaviour NOMJAEPALLK, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO, Action HHJDMJPABNC, [Optional] PPENLAHPKHK FILPBFCPPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x56BF390", Offset = "0x56BE190", VA = "0x1856BF390")]
	public static OMJDCAMIDEI NOOMABPCPKJ(this MonoBehaviour NOMJAEPALLK, float PHHOGMDEFFL, Action HHJDMJPABNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x56BF270", Offset = "0x56BE070", VA = "0x1856BF270")]
	public static OMJDCAMIDEI JINCPHIHNKE(this MonoBehaviour NOMJAEPALLK, float PHHOGMDEFFL, Action HHJDMJPABNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x56BF0C0", Offset = "0x56BDEC0", VA = "0x1856BF0C0")]
	public static OMJDCAMIDEI FGJMNEMIMDL(this MonoBehaviour NOMJAEPALLK, float PHHOGMDEFFL, Action HHJDMJPABNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x56BEFF0", Offset = "0x56BDDF0", VA = "0x1856BEFF0")]
	public static OMJDCAMIDEI EMFEOHFFEDA(this MonoBehaviour NOMJAEPALLK, float PHHOGMDEFFL, Action HHJDMJPABNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NGCGFNODJEE : PHMDMGNFJIJ, IEnumerable<PHMDMGNFJIJ>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly List<PHMDMGNFJIJ> AEDLLDCLEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool JBFEGPGHHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action LDOGKNCAKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool BOCIMNOLHIE;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool HMELFNJHJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x56C3C20", Offset = "0x56C2A20", VA = "0x1856C3C20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DNACKLMHEIP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x56C41C0", Offset = "0x56C2FC0", VA = "0x1856C41C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x56C3B00", Offset = "0x56C2900", VA = "0x1856C3B00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x56C4260", Offset = "0x56C3060", VA = "0x1856C4260")]
	public NGCGFNODJEE([Optional] Action LDOGKNCAKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x56C39D0", Offset = "0x56C27D0", VA = "0x1856C39D0")]
	public void AHKNMMEAEHA(PHMDMGNFJIJ DBAGPIAPGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x56C4050", Offset = "0x56C2E50", VA = "0x1856C4050")]
	private void MMBIPKFFADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x56C3D60", Offset = "0x56C2B60", VA = "0x1856C3D60", Slot = "7")]
	public bool JHONFNIMIEF(bool AJKJHFCHOAK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x56C3D70", Offset = "0x56C2B70", VA = "0x1856C3D70", Slot = "8")]
	public bool JHONFNIMIEF(Action KKJDJCJOLIF, bool AJKJHFCHOAK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x56C3BA0", Offset = "0x56C29A0", VA = "0x1856C3BA0", Slot = "9")]
	public IEnumerator<PHMDMGNFJIJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x56C3BA0", Offset = "0x56C29A0", VA = "0x1856C3BA0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class OGEGPLIMOPB : KIKOOGENMMP
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class OGNPFNDMNKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public OGEGPLIMOPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public OGNPFNDMNKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x56B0810", Offset = "0x56AF610", VA = "0x1856B0810")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class AKFEPMGIPCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public OGEGPLIMOPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public AKFEPMGIPCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x56B0810", Offset = "0x56AF610", VA = "0x1856B0810")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly float FNFKOCNEAOK;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x56B6630", Offset = "0x56B5430", VA = "0x1856B6630")]
	public OGEGPLIMOPB(Behaviour KPEPJOHCOMD, float FNFKOCNEAOK, [Optional] Action LDOGKNCAKDE, [Optional] PPENLAHPKHK FILPBFCPPBN, [Optional] IONPAFOCMFL OBOCKAFNNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x56C5120", Offset = "0x56C3F20", VA = "0x1856C5120", Slot = "9")]
	protected override bool BKKODJMHGAC(Action KKJDJCJOLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x56C5220", Offset = "0x56C4020", VA = "0x1856C5220", Slot = "10")]
	protected override bool CBJNIFLNOIJ(Action KKJDJCJOLIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface PHMDMGNFJIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool HMELFNJHJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action DNACKLMHEIP;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JHONFNIMIEF(bool AJKJHFCHOAK = false);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JHONFNIMIEF(Action KKJDJCJOLIF, bool AJKJHFCHOAK = false);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class KIKOOGENMMP : PHMDMGNFJIJ
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class KNDDAMADFEI : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private FFIMBIIMMMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public KIKOOGENMMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
		[DebuggerHidden]
		public KNDDAMADFEI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x56C0FD0", Offset = "0x56BFDD0", VA = "0x1856C0FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x56C10A0", Offset = "0x56BFEA0", VA = "0x1856C10A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly Behaviour KPEPJOHCOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly Action LDOGKNCAKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private ILDCKENHFOE KKNEPDMOEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly PPENLAHPKHK FILPBFCPPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	protected readonly IONPAFOCMFL OBOCKAFNNCL;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool HMELFNJHJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x84A790", Offset = "0x849590", VA = "0x18084A790", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action DNACKLMHEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x56C0DB0", Offset = "0x56BFBB0", VA = "0x1856C0DB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x56C09E0", Offset = "0x56BF7E0", VA = "0x1856C09E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x56C0ED0", Offset = "0x56BFCD0", VA = "0x1856C0ED0")]
	protected KIKOOGENMMP(Behaviour KPEPJOHCOMD, [Optional] Action LDOGKNCAKDE, [Optional] PPENLAHPKHK FILPBFCPPBN, [Optional] IONPAFOCMFL OBOCKAFNNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x56C0B50", Offset = "0x56BF950", VA = "0x1856C0B50", Slot = "7")]
	public bool JHONFNIMIEF(bool AJKJHFCHOAK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x56C0B00", Offset = "0x56BF900", VA = "0x1856C0B00", Slot = "8")]
	public bool JHONFNIMIEF(Action KKJDJCJOLIF, bool AJKJHFCHOAK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool BKKODJMHGAC(Action KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool CBJNIFLNOIJ(Action KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x56C0980", Offset = "0x56BF780", VA = "0x1856C0980")]
	protected void AKEBBDLBECL(Action KKJDJCJOLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x56C0BB0", Offset = "0x56BF9B0", VA = "0x1856C0BB0")]
	protected LMAPELGHNPL KAIFIFOJMKI(float IPCGMIBLPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x56C0A80", Offset = "0x56BF880", VA = "0x1856C0A80")]
	private void GINHHKBDNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x56C0E50", Offset = "0x56BFC50", VA = "0x1856C0E50")]
	[IteratorStateMachine(typeof(KNDDAMADFEI))]
	private IEnumerator<FFIMBIIMMMD> OLEFCHLHFMI(float IPCGMIBLPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x56C09A0", Offset = "0x56BF7A0", VA = "0x1856C09A0")]
	[CompilerGenerated]
	private void BDEMPOICLOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class ELDEMHOBDII : KIKOOGENMMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly float ELMFPMEBEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly int JECJEKDCOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly float FIBCGEHNDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly float[] LABHAILFOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private int HAJNAKJDKGD;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x56B6D60", Offset = "0x56B5B60", VA = "0x1856B6D60")]
	public ELDEMHOBDII(Behaviour KPEPJOHCOMD, float AMFHAILBGCL, int JECJEKDCOEN, [Optional] Action LDOGKNCAKDE, float FIBCGEHNDFI = 0f, [Optional] PPENLAHPKHK FILPBFCPPBN, [Optional] IONPAFOCMFL OBOCKAFNNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "9")]
	protected override bool BKKODJMHGAC(Action KKJDJCJOLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x56B6AA0", Offset = "0x56B58A0", VA = "0x1856B6AA0", Slot = "10")]
	protected override bool CBJNIFLNOIJ(Action KKJDJCJOLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x56B6CD0", Offset = "0x56B5AD0", VA = "0x1856B6CD0")]
	private void MLOGJLCLEFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class EALEFPNOHCO : KIKOOGENMMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly float FNFKOCNEAOK;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x56B6630", Offset = "0x56B5430", VA = "0x1856B6630")]
	public EALEFPNOHCO(Behaviour KPEPJOHCOMD, float FNFKOCNEAOK, [Optional] Action LDOGKNCAKDE, [Optional] PPENLAHPKHK FILPBFCPPBN, [Optional] IONPAFOCMFL OBOCKAFNNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "9")]
	protected override bool BKKODJMHGAC(Action KKJDJCJOLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x56B65F0", Offset = "0x56B53F0", VA = "0x1856B65F0", Slot = "10")]
	protected override bool CBJNIFLNOIJ(Action KKJDJCJOLIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class BOHPILHAGMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class AFKCGMCMCAJ : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private FFIMBIIMMMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
		[DebuggerHidden]
		public AFKCGMCMCAJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x56B0550", Offset = "0x56AF350", VA = "0x1856B0550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x56B05F0", Offset = "0x56AF3F0", VA = "0x1856B05F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private OMJDCAMIDEI IGLCOPHOECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private LCPJFIPJNDD KPEPJOHCOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private Action<float> KLHCKKJBDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private float MFNIBHPKNCH;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x56B18D0", Offset = "0x56B06D0", VA = "0x1856B18D0")]
	public BOHPILHAGMD(LCPJFIPJNDD KPEPJOHCOMD, float OBGBOJHKCAO, Action<float> OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x56B1500", Offset = "0x56B0300", VA = "0x1856B1500")]
	private void EKOHFHCBHEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x56B1340", Offset = "0x56B0140", VA = "0x1856B1340")]
	private void BJADPJEIEPJ(string EDMHEICKIIC, Action MIJAOJBDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x56B1860", Offset = "0x56B0660", VA = "0x1856B1860")]
	[IteratorStateMachine(typeof(AFKCGMCMCAJ))]
	private IEnumerator<FFIMBIIMMMD> OJIBIIOPHBK(Action MIJAOJBDLGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x56B14A0", Offset = "0x56B02A0", VA = "0x1856B14A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x56B16B0", Offset = "0x56B04B0", VA = "0x1856B16B0")]
	[CompilerGenerated]
	private void GACBKJDIHCH(string ABJFFBJEJDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class KALLOIOOPKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class ECCIANGNODJ : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private FFIMBIIMMMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
		[DebuggerHidden]
		public ECCIANGNODJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x56B6730", Offset = "0x56B5530", VA = "0x1856B6730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x56B67D0", Offset = "0x56B55D0", VA = "0x1856B67D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private OMJDCAMIDEI IGLCOPHOECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private MonoBehaviour NOMJAEPALLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Action OHNIAEDHHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Action<float> KLHCKKJBDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private float MFNIBHPKNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private bool LGKFKCOIKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly PPENLAHPKHK FILPBFCPPBN;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x56C02A0", Offset = "0x56BF0A0", VA = "0x1856C02A0")]
	public KALLOIOOPKB(MonoBehaviour NOMJAEPALLK, Action OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO, [Optional] PPENLAHPKHK FILPBFCPPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x56C06F0", Offset = "0x56BF4F0", VA = "0x1856C06F0")]
	public KALLOIOOPKB(MonoBehaviour NOMJAEPALLK, Action<float> OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO, [Optional] PPENLAHPKHK FILPBFCPPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x56C04A0", Offset = "0x56BF2A0", VA = "0x1856C04A0")]
	public KALLOIOOPKB(MonoBehaviour NOMJAEPALLK, float OBGBOJHKCAO, Action<float> OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO, bool LGKFKCOIKAH = true, [Optional] PPENLAHPKHK FILPBFCPPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x43EC260", Offset = "0x43EB060", VA = "0x1843EC260")]
	private KALLOIOOPKB(PPENLAHPKHK FILPBFCPPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x56BF520", Offset = "0x56BE320", VA = "0x1856BF520")]
	internal static KALLOIOOPKB AKJJOLIFOAA(MonoBehaviour NOMJAEPALLK, float OBGBOJHKCAO, Action<float> OHNIAEDHHJI, FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO, bool LGKFKCOIKAH = true, [Optional] PPENLAHPKHK FILPBFCPPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x56BF8F0", Offset = "0x56BE6F0", VA = "0x1856BF8F0")]
	private void CMDHHHPFDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x56C0080", Offset = "0x56BEE80", VA = "0x1856C0080")]
	private void LMPFJELDALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x56BFD20", Offset = "0x56BEB20", VA = "0x1856BFD20")]
	private void EKOHFHCBHEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x56BFAC0", Offset = "0x56BE8C0", VA = "0x1856BFAC0")]
	private void EBPNGOOHKGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x56BF7C0", Offset = "0x56BE5C0", VA = "0x1856BF7C0")]
	private void BJADPJEIEPJ(string EDMHEICKIIC, Action MIJAOJBDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x56C0230", Offset = "0x56BF030", VA = "0x1856C0230")]
	[IteratorStateMachine(typeof(ECCIANGNODJ))]
	private IEnumerator<FFIMBIIMMMD> OJIBIIOPHBK(Action MIJAOJBDLGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x56BFA60", Offset = "0x56BE860", VA = "0x1856BFA60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x56BFED0", Offset = "0x56BECD0", VA = "0x1856BFED0")]
	[CompilerGenerated]
	private void FIFENLEMBFJ(string ABJFFBJEJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x56BFC90", Offset = "0x56BEA90", VA = "0x1856BFC90")]
	[CompilerGenerated]
	private void ECOFOEIBDLL(string ABJFFBJEJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x56BFF60", Offset = "0x56BED60", VA = "0x1856BFF60")]
	[CompilerGenerated]
	private void FPLAEEEFKNO(string ABJFFBJEJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x56BFFF0", Offset = "0x56BEDF0", VA = "0x1856BFFF0")]
	[CompilerGenerated]
	private void KAEMHEIAHIO(string ABJFFBJEJDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Flags]
internal enum GNJLHOFEAOJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class BKBJOFMNCOE : IONPAFOCMFL
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public float EOILNLNFDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x56B1050", Offset = "0x56AFE50", VA = "0x1856B1050", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float GAOACEMGAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x56B1040", Offset = "0x56AFE40", VA = "0x1856B1040", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public double DOIAMEFHOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x56B0FB0", Offset = "0x56AFDB0", VA = "0x1856B0FB0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x56B0FD0", Offset = "0x56AFDD0", VA = "0x1856B0FD0")]
	[NPBDMCLHPNM(AIJEIIPHIJH.None)]
	private static void GLHKHMBBLAI(HKDBAIGILEN DHPFLPHCDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	[Preserve]
	internal BKBJOFMNCOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal interface ICLLFBHIKAE
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNFPFAJDMBB(string EOPECGOILOC);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNAEMLFNGOE();
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal interface KDECMLOLFOE
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string LMPHGOGJNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool LELALLAJPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool JDKKPKNDJHN
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class LJKNEAPHNFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public JJLMPCPNJHK JFONCKCJHHN;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int HGGIJKLHICO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6DA060", Offset = "0x6D8E60", VA = "0x1806DA060", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x768440", Offset = "0x767240", VA = "0x180768440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x56C1BD0", Offset = "0x56C09D0", VA = "0x1856C1BD0")]
	public static FFIMBIIMMMD IICFDKNEEIK(IEnumerator<FFIMBIIMMMD> LEAEKLAOLEL, NMMDFACIKMB DFJCJFEOFBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x56C1AF0", Offset = "0x56C08F0", VA = "0x1856C1AF0")]
	public FFIMBIIMMMD IICFDKNEEIK(NMMDFACIKMB[] JKJPJMENAFJ, IEnumerator<FFIMBIIMMMD>[] FDOHHOBADMF, FFIMBIIMMMD[] GKALMOHKJCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x56C1AC0", Offset = "0x56C08C0", VA = "0x1856C1AC0")]
	public void FOGJJGKCAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x56C1980", Offset = "0x56C0780", VA = "0x1856C1980")]
	public void FBKGGJANIDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x56C1D80", Offset = "0x56C0B80", VA = "0x1856C1D80")]
	public void OMBHCHHFPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x56C1AC0", Offset = "0x56C08C0", VA = "0x1856C1AC0")]
	public void NAIDAFGCHCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public LJKNEAPHNFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class JJLMPCPNJHK
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct OMIENGMPLOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public LJKNEAPHNFC ECLJILCDFHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public LCPJFIPJNDD EJOEEJJHNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public NMMDFACIKMB PHLPFKDGNNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public IEnumerator<FFIMBIIMMMD> MNKCDAICOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public FFIMBIIMMMD HCAKFOIPLDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public GNJLHOFEAOJ HBNIKHBBDIO;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct BOCPLAGFNIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public FNNACPPACGP.KCEPDILKHND NAHKBJNOJJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public List<OMIENGMPLOP> OBJBKAJHAKI;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class IMMANLFKFGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public NMMDFACIKMB promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public JJLMPCPNJHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public LCPJFIPJNDD context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public LJKNEAPHNFC routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GNJLHOFEAOJ coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public FFIMBIIMMMD currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public IEnumerator<FFIMBIIMMMD> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public IMMANLFKFGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x56BA140", Offset = "0x56B8F40", VA = "0x1856BA140")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class LOIJCJCBLLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public LJKNEAPHNFC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public JJLMPCPNJHK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public LOIJCJCBLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x56C1EC0", Offset = "0x56C0CC0", VA = "0x1856C1EC0")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class HFGILFNEAME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public LJKNEAPHNFC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public JJLMPCPNJHK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public HFGILFNEAME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x56B8A30", Offset = "0x56B7830", VA = "0x1856B8A30")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class IMKFONLECHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public LJKNEAPHNFC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public JJLMPCPNJHK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public IMKFONLECHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x56BA100", Offset = "0x56B8F00", VA = "0x1856BA100")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private const GNJLHOFEAOJ HMEJPMHFJIO = GNJLHOFEAOJ.Cancelled | GNJLHOFEAOJ.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private bool[] ANNBGPGDMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private NativeArray<GNJLHOFEAOJ> NJJOPCOJMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NativeArray<float> LKPFPCNHAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeArray<int> LMKNMMCCLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<int> JONDDIADEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeArray<int> JPLOBCNOLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<int> DOHFDDKFBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<int> ALNOEHJPPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private LJKNEAPHNFC[] IDACANGKNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NMMDFACIKMB[] JKJPJMENAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private LCPJFIPJNDD[] KJIMECLCNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private IEnumerator<FFIMBIIMMMD>[] JPGPIJGNHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private FFIMBIIMMMD[] BAPAIIODKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private int KEEMKIHJNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int FPMMBKCOHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly int GCCDCLBLDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private float HMNAOMEJKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private MPLLFMCKHFB HMDPHJMNCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private JobHandle BDMMJFPEOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private List<LJKNEAPHNFC> HAPHGIMKJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool DNBHOGIDDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private List<Action> OMBBMGMIOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private List<Action> JMPPDIDHILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool HHPDMFNJMDL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public BOCPLAGFNIH[] HLFAFJGJECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x73F2D0", Offset = "0x73E0D0", VA = "0x18073F2D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x56BD5A0", Offset = "0x56BC3A0", VA = "0x1856BD5A0")]
	private static int FDGOEFGIFCO(FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x56BE800", Offset = "0x56BD600", VA = "0x1856BE800")]
	public JJLMPCPNJHK(FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x56BCF40", Offset = "0x56BBD40", VA = "0x1856BCF40")]
	private void EKJPGGJJPHG(ref int GKNADLGELLF, int FLCMMAANLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x56BC4E0", Offset = "0x56BB2E0", VA = "0x1856BC4E0")]
	public void ACFCAAKCJIH(LCPJFIPJNDD KPEPJOHCOMD, FFIMBIIMMMD IFAOKDCGAMD, IEnumerator<FFIMBIIMMMD> LEAEKLAOLEL, NMMDFACIKMB DFJCJFEOFBE, [Optional] LJKNEAPHNFC GJNOIPLAEHC, GNJLHOFEAOJ DIENAHFOGBG = GNJLHOFEAOJ.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x56BE610", Offset = "0x56BD410", VA = "0x1856BE610")]
	public void OKMFLBBLACE(IEnumerable<OMIENGMPLOP> HFHIHBHFNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x56BE100", Offset = "0x56BCF00", VA = "0x1856BE100")]
	private OMIENGMPLOP NNFLLOPMHBP(int IGONJJEOGPA)
	{
		return default(OMIENGMPLOP);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x56BD200", Offset = "0x56BC000", VA = "0x1856BD200")]
	private void EPKJHIENDME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2D4CDF0", Offset = "0x2D4BBF0", VA = "0x182D4CDF0")]
	private static void GMEMPKEMJNM<T>(int IGONJJEOGPA, T[] CACBENFGHPF, int MBCLCCPKDLG, [Optional] T DGAELFLOIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2D4CDD0", Offset = "0x2D4BBD0", VA = "0x182D4CDD0")]
	private static void GMEMPKEMJNM<T>(int IGONJJEOGPA, NativeArray<T> CACBENFGHPF, int MBCLCCPKDLG, [Optional] T DGAELFLOIGK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x56BDAC0", Offset = "0x56BC8C0", VA = "0x1856BDAC0")]
	private void IELGCCNCICM(IEnumerable<OMIENGMPLOP> HFHIHBHFNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x56BD130", Offset = "0x56BBF30", VA = "0x1856BD130")]
	private void EMCBPEOFONL(OMIENGMPLOP IOKCINFMGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x56BD700", Offset = "0x56BC500", VA = "0x1856BD700")]
	private DNNDABGACAL GLJKLNAJCGC(int NKLHGJCLIEA)
	{
		return default(DNNDABGACAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x56BDD70", Offset = "0x56BCB70", VA = "0x1856BDD70")]
	public void JBNLDLGANLD(float LKHKCGOCDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x56BCD90", Offset = "0x56BBB90", VA = "0x1856BCD90")]
	private void CKKIAEMAMPM(Action FEIPFLDEPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x56BDF50", Offset = "0x56BCD50", VA = "0x1856BDF50")]
	private void LCOCEOJMCJJ(Action FEIPFLDEPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x56BC660", Offset = "0x56BB460", VA = "0x1856BC660")]
	public void AOHJPFLHNGJ(float LKHKCGOCDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x56BD9C0", Offset = "0x56BC7C0", VA = "0x1856BD9C0")]
	public void HNJHICBJAJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x56BDFD0", Offset = "0x56BCDD0", VA = "0x1856BDFD0")]
	public void NAIDAFGCHCA(LJKNEAPHNFC PKACOHPHMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x56BD5D0", Offset = "0x56BC3D0", VA = "0x1856BD5D0")]
	public void GFOFGMLJAPH(LJKNEAPHNFC PKACOHPHMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x56BCE10", Offset = "0x56BBC10", VA = "0x1856BCE10")]
	public void DNPLDGLAEOP(LJKNEAPHNFC PKACOHPHMLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class HDIBONMLKLK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly HDIBONMLKLK BHEOFCJHCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Action CCCMBJGECCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private bool JFHKLPCKLKK;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x76B3B0", Offset = "0x76A1B0", VA = "0x18076B3B0")]
	public HDIBONMLKLK(Action CCCMBJGECCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x56B8910", Offset = "0x56B7710", VA = "0x1856B8910", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface MIJJFFEDIOB<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	T DKPIGGFDHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable DPGPEMKLFHI(UnityEngine.Object KPEPJOHCOMD, Action<T> IPIEFMHAMPB);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface AFJFMLPDHFF<T> : global::MIJJFFEDIOB<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	new T DKPIGGFDHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class BKILCGFBPEB<T> : global::AFJFMLPDHFF<T>, global::MIJJFFEDIOB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class JGPBFDMIBBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public global::BKILCGFBPEB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public global::EOABNEGFADA<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public JGPBFDMIBBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2F4B3F0", Offset = "0x2F4A1F0", VA = "0x182F4B3F0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static GameObject JIOCNAGIAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly List<global::EOABNEGFADA<UnityEngine.Object, Action<T>>> IAHBIKGPCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private T JIBDEBNDKMO;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public T DKPIGGFDHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A230", VA = "0x18076B430", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2984740", Offset = "0x2983540", VA = "0x182984740", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x29846E0", Offset = "0x29834E0", VA = "0x1829846E0")]
	private static bool HAFALKOAFNH(T FEIPFLDEPBD, T MIECAKFJHNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2984820", Offset = "0x2983620", VA = "0x182984820")]
	public BKILCGFBPEB(T NKMGHBOEDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x29843D0", Offset = "0x29831D0", VA = "0x1829843D0", Slot = "6")]
	public IDisposable DPGPEMKLFHI(UnityEngine.Object KPEPJOHCOMD, Action<T> IPIEFMHAMPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2983D10", Offset = "0x2982B10", VA = "0x182983D10")]
	private void DAEGMADNOKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal class DHLEMBIIBFJ : HBNIHCBKEFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly PPENLAHPKHK FILPBFCPPBN;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x56B64E0", Offset = "0x56B52E0", VA = "0x1856B64E0")]
	[NPBDMCLHPNM(AIJEIIPHIJH.None)]
	private static void GLHKHMBBLAI(HKDBAIGILEN DHPFLPHCDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x76B3B0", Offset = "0x76A1B0", VA = "0x18076B3B0")]
	[Preserve]
	internal DHLEMBIIBFJ([KIJADEHPJBH(null)] PPENLAHPKHK FILPBFCPPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x56B6550", Offset = "0x56B5350", VA = "0x1856B6550", Slot = "4")]
	public IDisposable KKIAAGEEJJL(float OBGBOJHKCAO, Action<float> JDLJMIHPPKE, bool LGKFKCOIKAH = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[BurstCompile]
internal struct MPLLFMCKHFB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	[ReadOnly]
	public float IEGJMNALHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	[ReadOnly]
	public int PFCOKACFDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private NativeArray<int> HOPELLFNLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private NativeArray<int> GGKAKKBKKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private NativeArray<int> PKLNCHJCPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	[ReadOnly]
	public NativeArray<GNJLHOFEAOJ> KIIOFOGBFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	[ReadOnly]
	public NativeArray<float> EDDAMKBFDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	[WriteOnly]
	public NativeArray<int> JPLOBCNOLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[WriteOnly]
	public NativeArray<int> LMKNMMCCLOH;

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x56C33C0", Offset = "0x56C21C0", VA = "0x1856C33C0")]
	public static MPLLFMCKHFB FBMANFCLCAO(int GBEGMDJKKGM, float LKHKCGOCDLO, NativeArray<GNJLHOFEAOJ> KKBMCANKLIG, NativeArray<float> IMKHMBPMFJM, NativeArray<int> JNECCONLAIP, NativeArray<int> JOODBENCEDH, NativeArray<int> EDJFJLHOGAG, NativeArray<int> GGKAKKBKKCC, NativeArray<int> PKLNCHJCPAM)
	{
		return default(MPLLFMCKHFB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x56C32E0", Offset = "0x56C20E0", VA = "0x1856C32E0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x56C3550", Offset = "0x56C2350", VA = "0x1856C3550")]
	private bool ONFDLOFCFDP(int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x56C3080", Offset = "0x56C1E80", VA = "0x1856C3080")]
	private void BOOBOCGAHLF(NativeArray<int> AIPIPFLGGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x56C34F0", Offset = "0x56C22F0", VA = "0x1856C34F0")]
	private int IADHFMBBLBL(int HGEHJEKAHAA, int GFDCMCBLOEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x56C3420", Offset = "0x56C2220", VA = "0x1856C3420")]
	private void GIOILDKLMDK(NativeArray<int> AIPIPFLGGGF, int AEEDIGMAOBI, int HHMAGOGHHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x56C30B0", Offset = "0x56C1EB0", VA = "0x1856C30B0")]
	private void DGJEGHAICHG(NativeArray<int> AIPIPFLGGGF, int IGKEGHONLHL, int NPPHFGLBJIA, int MLFCLOKAOBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class AFHBFJENEOD : DABBGBECGMI, PPENLAHPKHK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private JJLMPCPNJHK[] HOKACGHEAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private ICLLFBHIKAE IFFKHFJGIAH;

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x56B0040", Offset = "0x56AEE40", VA = "0x1856B0040")]
	[NPBDMCLHPNM(AIJEIIPHIJH.None)]
	private static void GLHKHMBBLAI(HKDBAIGILEN DHPFLPHCDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x56B0480", Offset = "0x56AF280", VA = "0x1856B0480")]
	[Preserve]
	public AFHBFJENEOD([KIJADEHPJBH(null)] IBIACOJGOBC EFLLFGGBMJL, [KIJADEHPJBH(null)] IONPAFOCMFL OBOCKAFNNCL, [KIJADEHPJBH(null)] MOBMIKGCGNL IKAKKCPAAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x56B0290", Offset = "0x56AF090", VA = "0x1856B0290", Slot = "12")]
	public override OMJDCAMIDEI JGKDNALJFLP(LCPJFIPJNDD KPEPJOHCOMD, IEnumerator<FFIMBIIMMMD> LAPJPKJGLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x56AFB50", Offset = "0x56AE950", VA = "0x1856AFB50", Slot = "13")]
	public override void CELKGMNMMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x56B00B0", Offset = "0x56AEEB0", VA = "0x1856B00B0", Slot = "15")]
	public override void GODKPLIDGAK(FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x56AFA70", Offset = "0x56AE870", VA = "0x1856AFA70", Slot = "14")]
	protected override void CAMMFFCGHBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x56AFA30", Offset = "0x56AE830", VA = "0x1856AFA30")]
	private JJLMPCPNJHK BGPEHHPJIKA(FNNACPPACGP.KCEPDILKHND MAIOHDHBGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x56B03D0", Offset = "0x56AF1D0", VA = "0x1856B03D0", Slot = "16")]
	internal override PFHPOBOMNPI PEECPECKBIE(IEnumerator<FFIMBIIMMMD> LAPJPKJGLKL, Behaviour KPEPJOHCOMD, NMMDFACIKMB DFJCJFEOFBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x56AFE30", Offset = "0x56AEC30", VA = "0x1856AFE30", Slot = "17")]
	internal override INACOGOOHIL CLAGGBKADFI(FNNACPPACGP.KCEPDILKHND BAPHNFLMDKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x56AFEA0", Offset = "0x56AECA0", VA = "0x1856AFEA0")]
	private void CLINODNHFBH(JJLMPCPNJHK CIBHNMOFJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x56AFFD0", Offset = "0x56AEDD0", VA = "0x1856AFFD0", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class DABBGBECGMI : PPENLAHPKHK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly IBIACOJGOBC EFLLFGGBMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	protected readonly IONPAFOCMFL OBOCKAFNNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly MOBMIKGCGNL IKAKKCPAAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private INACOGOOHIL[] GEDJCMKMJCB;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static PPENLAHPKHK PDNDNIMAPDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x56B5350", Offset = "0x56B4150", VA = "0x1856B5350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static bool CKBGNMHNINE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x70F850", Offset = "0x70E650", VA = "0x18070F850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public FNNACPPACGP.KCEPDILKHND HMHMGPEGLLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6DA060", Offset = "0x6D8E60", VA = "0x1806DA060", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FNNACPPACGP.KCEPDILKHND);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x768440", Offset = "0x767240", VA = "0x180768440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IONPAFOCMFL PHALNIELKED
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x56B5800", Offset = "0x56B4600", VA = "0x1856B5800")]
	public static OMJDCAMIDEI CJAOKEIFAPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x56B60D0", Offset = "0x56B4ED0", VA = "0x1856B60D0")]
	[Preserve]
	protected DABBGBECGMI([KIJADEHPJBH(null)] IBIACOJGOBC EFLLFGGBMJL, [KIJADEHPJBH(null)] IONPAFOCMFL OBOCKAFNNCL, [KIJADEHPJBH(null)] MOBMIKGCGNL IKAKKCPAAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x56B53A0", Offset = "0x56B41A0", VA = "0x1856B53A0", Slot = "6")]
	public OMJDCAMIDEI BEHKAEOBGKH(IEnumerator<FFIMBIIMMMD> LAPJPKJGLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x56B53B0", Offset = "0x56B41B0", VA = "0x1856B53B0", Slot = "7")]
	public OMJDCAMIDEI BEHKAEOBGKH(Behaviour KPEPJOHCOMD, IEnumerator<FFIMBIIMMMD> LAPJPKJGLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract OMJDCAMIDEI JGKDNALJFLP(LCPJFIPJNDD KPEPJOHCOMD, IEnumerator<FFIMBIIMMMD> LAPJPKJGLKL);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x56B5620", Offset = "0x56B4420", VA = "0x1856B5620", Slot = "13")]
	public virtual void CELKGMNMMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x56B52F0", Offset = "0x56B40F0", VA = "0x1856B52F0", Slot = "9")]
	public void BALBDFFIPKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x56B5600", Offset = "0x56B4400", VA = "0x1856B5600", Slot = "14")]
	protected virtual void CAMMFFCGHBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x56B6090", Offset = "0x56B4E90", VA = "0x1856B6090")]
	private void NMLLGCLAMAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x56B6070", Offset = "0x56B4E70", VA = "0x1856B6070")]
	private void LOKEPOLJCOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x56B5C20", Offset = "0x56B4A20", VA = "0x1856B5C20")]
	private void GMONNENGCBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x56B55E0", Offset = "0x56B43E0", VA = "0x1856B55E0")]
	private void BNGONBJLHDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x56B60B0", Offset = "0x56B4EB0", VA = "0x1856B60B0")]
	private void OBBEMGIKDKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x56B5E80", Offset = "0x56B4C80", VA = "0x1856B5E80")]
	private void HEHGAMLJHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x56B52D0", Offset = "0x56B40D0", VA = "0x1856B52D0")]
	private void AIIKBLKPAOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x56B5C40", Offset = "0x56B4A40", VA = "0x1856B5C40", Slot = "15")]
	public virtual void GODKPLIDGAK(FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x56B5EA0", Offset = "0x56B4CA0", VA = "0x1856B5EA0")]
	private void JCILMOMDAKO(INACOGOOHIL CIBHNMOFJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x530DF80", Offset = "0x530CD80", VA = "0x18530DF80")]
	private INACOGOOHIL FPCONCMIFJE(FNNACPPACGP.KCEPDILKHND MAIOHDHBGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract PFHPOBOMNPI PEECPECKBIE(IEnumerator<FFIMBIIMMMD> LAPJPKJGLKL, Behaviour NOMJAEPALLK, NMMDFACIKMB KCMEGBILAHE);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract INACOGOOHIL CLAGGBKADFI(FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x56B58A0", Offset = "0x56B46A0", VA = "0x1856B58A0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class PFHPOBOMNPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly NMMDFACIKMB DFJCJFEOFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly KDECMLOLFOE KPEPJOHCOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly bool OHFIPLJFHAK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public IEnumerator<FFIMBIIMMMD> MNKCDAICOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F10", Offset = "0x6F6D10", VA = "0x1806F7F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public FFIMBIIMMMD HCAKFOIPLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x701A00", Offset = "0x700800", VA = "0x180701A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool CGPDGKAMKNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x56C5F50", Offset = "0x56C4D50", VA = "0x1856C5F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool IADDPKHHFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x95C0C0", Offset = "0x95AEC0", VA = "0x18095C0C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x95C120", Offset = "0x95AF20", VA = "0x18095C120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string LMPHGOGJNDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E70", Offset = "0x6F5C70", VA = "0x1806F6E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F7830", Offset = "0x6F6630", VA = "0x1806F7830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public float GBFLECMOPAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B5770", Offset = "0x7B4570", VA = "0x1807B5770")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xBD7140", Offset = "0xBD5F40", VA = "0x180BD7140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x56C6440", Offset = "0x56C5240", VA = "0x1856C6440")]
	public PFHPOBOMNPI(IEnumerator<FFIMBIIMMMD> LEAEKLAOLEL, KDECMLOLFOE KPEPJOHCOMD, NMMDFACIKMB DFJCJFEOFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x56C6040", Offset = "0x56C4E40", VA = "0x1856C6040")]
	public FFIMBIIMMMD IICFDKNEEIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x56C5FD0", Offset = "0x56C4DD0", VA = "0x1856C5FD0")]
	public bool IAFFOECCGOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x56C6300", Offset = "0x56C5100", VA = "0x1856C6300")]
	public void NAIDAFGCHCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x56C6380", Offset = "0x56C5180", VA = "0x1856C6380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1766B80", Offset = "0x1765980", VA = "0x181766B80")]
	[CompilerGenerated]
	private void NEOKABCIMCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class NMMDFACIKMB : CNGCDCEDPLF, OMJDCAMIDEI, ILDCKENHFOE, LMAPELGHNPL, IEnumerator, FFIMBIIMMMD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private FNNACPPACGP.KCEPDILKHND BMJFDHDACBF;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private FNNACPPACGP.KCEPDILKHND LMKPHFNDIDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x77F240", Offset = "0x77E040", VA = "0x18077F240", Slot = "23")]
		get
		{
			return default(FNNACPPACGP.KCEPDILKHND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public FNNACPPACGP.KCEPDILKHND JFONCKCJHHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x77F300", Offset = "0x77E100", VA = "0x18077F300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private float GHMCEEOLKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x87DB00", Offset = "0x87C900", VA = "0x18087DB00", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool DNICNMEBCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x56C4600", Offset = "0x56C3400", VA = "0x1856C4600", Slot = "24")]
	private bool LHLGHELIPEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x56C45F0", Offset = "0x56C33F0", VA = "0x1856C45F0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x56C4620", Offset = "0x56C3420", VA = "0x1856C4620")]
	public NMMDFACIKMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal enum DNNDABGACAL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class INACOGOOHIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public enum EBNBAGCBNEC
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct IJBMCGKLPFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public FNNACPPACGP.KCEPDILKHND NAHKBJNOJJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public EBNBAGCBNEC NKPLOGPOAOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public List<PFHPOBOMNPI> PDOFKMEFOOC;
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly EBNBAGCBNEC[] EBPJDMEMKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly FNNACPPACGP.KCEPDILKHND CCCLPKMAAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool EBOMEELGGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly PFHPOBOMNPI[] DBJLFEBAHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly List<PFHPOBOMNPI> HGBFLJFJICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly Stack<int> PKCJJAPCBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly List<PFHPOBOMNPI> KCMLMBEDIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly Stack<int> FFAGMPBGFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly ICLLFBHIKAE BKGJJCHGINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool HHPDMFNJMDL;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public IJBMCGKLPFM[,] IBABIKJAGAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9C0", Offset = "0x6FC7C0", VA = "0x1806FD9C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x56BBE00", Offset = "0x56BAC00", VA = "0x1856BBE00")]
	public INACOGOOHIL(FNNACPPACGP.KCEPDILKHND BAPHNFLMDKN, ICLLFBHIKAE BKGJJCHGINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x56BB540", Offset = "0x56BA340", VA = "0x1856BB540")]
	public void INPBMKIGPGI(PFHPOBOMNPI LEAEKLAOLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x56BB660", Offset = "0x56BA460", VA = "0x1856BB660")]
	public void JFDAFMFFJPL(IList<PFHPOBOMNPI> FDOHHOBADMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x56BAB50", Offset = "0x56B9950", VA = "0x1856BAB50")]
	public void BIAMPFMPIII(IList<PFHPOBOMNPI> FDOHHOBADMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x56BBBF0", Offset = "0x56BA9F0", VA = "0x1856BBBF0")]
	private void PLFFLPFDLEN(PFHPOBOMNPI LEAEKLAOLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x56BB3C0", Offset = "0x56BA1C0", VA = "0x1856BB3C0")]
	private void IMMKGKONFFO(IList<PFHPOBOMNPI> FDOHHOBADMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x56BBA50", Offset = "0x56BA850", VA = "0x1856BBA50")]
	private DNNDABGACAL NHEGHHJOJPM(PFHPOBOMNPI LEAEKLAOLEL)
	{
		return default(DNNDABGACAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x56BAE20", Offset = "0x56B9C20", VA = "0x1856BAE20")]
	public void CAMMFFCGHBK(float LKHKCGOCDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x56BA940", Offset = "0x56B9740", VA = "0x1856BA940")]
	public void BALBDFFIPKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x56BB0A0", Offset = "0x56B9EA0", VA = "0x1856BB0A0")]
	private void IHAHKIHBBNO(List<PFHPOBOMNPI> FDOHHOBADMF, Stack<int> CIGOGIGFPIN, bool HJCPIGKGMLL, float BADHDHIEDNG = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x56BAF60", Offset = "0x56B9D60", VA = "0x1856BAF60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x56BB930", Offset = "0x56BA730", VA = "0x1856BB930")]
	private void KDAOKNOLAGK(List<PFHPOBOMNPI> FDOHHOBADMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class EKPGBNAEOGB : ICLLFBHIKAE
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "4")]
	public void MNFPFAJDMBB(string EOPECGOILOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
	public void JNAEMLFNGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public EKPGBNAEOGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class NJMHEOLCGPL : KDECMLOLFOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly Behaviour NOMJAEPALLK;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string LMPHGOGJNDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x56C4560", Offset = "0x56C3360", VA = "0x1856C4560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool LELALLAJPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x56C4500", Offset = "0x56C3300", VA = "0x1856C4500", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool JDKKPKNDJHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x56C44E0", Offset = "0x56C32E0", VA = "0x1856C44E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x76B3B0", Offset = "0x76A1B0", VA = "0x18076B3B0")]
	public NJMHEOLCGPL(Behaviour NOMJAEPALLK)
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

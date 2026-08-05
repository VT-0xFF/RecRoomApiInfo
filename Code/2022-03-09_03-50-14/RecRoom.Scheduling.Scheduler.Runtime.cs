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
		private delegate List<PlayerLoopSystem> OCHLMPFCNGM(List<PlayerLoopSystem> JNHPBPFBMKC, int LJCNPAPKHHI);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct FNDJENANFME
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct COBEDODKECC
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static EDOMFAGNPKP FOPGKDFLEOH;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x4766AE0", Offset = "0x47650E0", VA = "0x184766AE0")]
				public static PlayerLoopSystem BPPAAEGHNIO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct LAIIBEALPLF
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static EDOMFAGNPKP FOPIMNPBNIB;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x47729A0", Offset = "0x4770FA0", VA = "0x1847729A0")]
				public static PlayerLoopSystem BPPAAEGHNIO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct MCOCBPCOGNA
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static EDOMFAGNPKP NKBLLINOEMC;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x4773260", Offset = "0x4771860", VA = "0x184773260")]
				public static PlayerLoopSystem BPPAAEGHNIO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct OKEGDOHGEPI
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static EDOMFAGNPKP DAGGHIDFBKJ;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x4773840", Offset = "0x4771E40", VA = "0x184773840")]
				public static PlayerLoopSystem BPPAAEGHNIO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct DICFHJHOEBH
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class ECPIFBDNPMA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000F")]
					public HFMHJMNHIAC.KIHIEILNNHE key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
					public ECPIFBDNPMA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x476B450", Offset = "0x4769A50", VA = "0x18476B450")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IDisposable HPDNCGFJHKB;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x47687A0", Offset = "0x4766DA0", VA = "0x1847687A0")]
				public static PlayerLoopSystem ENCMFGDIEPH(HFMHJMNHIAC.KIHIEILNNHE DOICKNFOJNK)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct OAIHEIANPPC
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class BKAHGPJMNAJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000010")]
					public HFMHJMNHIAC.KIHIEILNNHE key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
					public BKAHGPJMNAJ()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x47653D0", Offset = "0x47639D0", VA = "0x1847653D0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x4773690", Offset = "0x4771C90", VA = "0x184773690")]
				public static PlayerLoopSystem ENCMFGDIEPH(HFMHJMNHIAC.KIHIEILNNHE DOICKNFOJNK)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class NMKOAPILOGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
			public NMKOAPILOGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x4773590", Offset = "0x4771B90", VA = "0x184773590")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool IHGCDIEAJCM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool MCBNNLMLCMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x47685E0", Offset = "0x4766BE0", VA = "0x1847685E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x47682B0", Offset = "0x47668B0", VA = "0x1847682B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4766CB0", Offset = "0x47652B0", VA = "0x184766CB0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x47682F0", Offset = "0x47668F0", VA = "0x1847682F0")]
		private static void KNIJBAGCGJP(HFMHJMNHIAC.KIHIEILNNHE DOICKNFOJNK, ref PlayerLoopSystem AEBPGMMJLPB, Type KHBBGHHAMJD, Type FBFMIALGEEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4767F30", Offset = "0x4766530", VA = "0x184767F30")]
		private static void CCPMBICCBOB(ref PlayerLoopSystem AEBPGMMJLPB, Type KHBBGHHAMJD, Type FBFMIALGEEL, OCHLMPFCNGM PKMDADLJKIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x47684C0", Offset = "0x4766AC0", VA = "0x1847684C0")]
		private static void MABOIMAGBIH(ref PlayerLoopSystem AEBPGMMJLPB, Type KHBBGHHAMJD, Type FBFMIALGEEL, PlayerLoopSystem? OPMLGFBBLFI, PlayerLoopSystem? IFBHPJEGMOL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HFMHJMNHIAC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum KIHIEILNNHE
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
	public class GFBONINIGLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly KIHIEILNNHE EEFNAMBOJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly KNFAJJEJOJA HCPKOFFEKBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long FBPIKFMEPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long EOBFJKIKMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long GODKPNIOKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int CANJOCMNFEH;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x476E410", Offset = "0x476CA10", VA = "0x18476E410")]
		public GFBONINIGLL(KIHIEILNNHE ELDFDAFHNKI, int MJFNEHKDAMP = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x476E120", Offset = "0x476C720", VA = "0x18476E120")]
		public void EDJMMEMEACN(int CEMIDLFEJMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x476E0B0", Offset = "0x476C6B0", VA = "0x18476E0B0")]
		public void DEBLKCKBJLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x476E3B0", Offset = "0x476C9B0", VA = "0x18476E3B0")]
		public void NDIABEPEOHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x476E1E0", Offset = "0x476C7E0", VA = "0x18476E1E0")]
		public void LMPEDBIMOEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x476E140", Offset = "0x476C740", VA = "0x18476E140")]
		public double GANCCNHHGLB(int HHNGBNJJOBB)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const int NDGPJCFNEPI = 90;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static KIHIEILNNHE[] BDBHKJFJFNI;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static GFBONINIGLL[] EGIDAMCEEIO;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x476F110", Offset = "0x476D710", VA = "0x18476F110")]
	public static GFBONINIGLL NEAIBBCCIHP(KIHIEILNNHE DOICKNFOJNK, int MJFNEHKDAMP = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x476F080", Offset = "0x476D680", VA = "0x18476F080")]
	public static GFBONINIGLL GONICDJEIEP(KIHIEILNNHE DOICKNFOJNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x476EFD0", Offset = "0x476D5D0", VA = "0x18476EFD0")]
	public static void FHIOBNKJKBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KNFAJJEJOJA : GPCNFOHKGDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int IIGKHKCFHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Queue<double> HFOEMFBJIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private double GMDMMMLINFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double FNEMCMIGGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double AFFNBDIONGE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int APPEMEJBDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4772730", Offset = "0x4770D30", VA = "0x184772730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double JBMOFOLJKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4772660", Offset = "0x4770C60", VA = "0x184772660", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double KDBLAOLPFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x17A2620", Offset = "0x17A0C20", VA = "0x1817A2620", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double DLKGLNHGJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x14CDDA0", Offset = "0x14CC3A0", VA = "0x1814CDDA0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4772770", Offset = "0x4770D70", VA = "0x184772770")]
	public KNFAJJEJOJA(int LFDGNIBNNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4772560", Offset = "0x4770B60", VA = "0x184772560", Slot = "4")]
	public void DFGGKJLGHLE(double FNFKPHHGMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x47726C0", Offset = "0x4770CC0", VA = "0x1847726C0", Slot = "5")]
	public void LKFNMONLKBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KDNPHHEKILD : GPCNFOHKGDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private long FDHHIMCPBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double GGODLPJBHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double KNOMOLCFPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double DNNIBHFKFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double OMBCJJKDHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double GMDMMMLINFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double FNEMCMIGGIA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long PKIGJFDDAAN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5734D0", Offset = "0x571AD0", VA = "0x1805734D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double KDBLAOLPFHA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x17A2610", Offset = "0x17A0C10", VA = "0x1817A2610", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double DLKGLNHGJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x138DD60", Offset = "0x138C360", VA = "0x18138DD60", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FCKDAIEAEKM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x14CDDA0", Offset = "0x14CC3A0", VA = "0x1814CDDA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double HBFGPEJGMBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x14CDD90", Offset = "0x14CC390", VA = "0x1814CDD90")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double JBMOFOLJKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x17A2540", Offset = "0x17A0B40", VA = "0x1817A2540", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x47719C0", Offset = "0x476FFC0", VA = "0x1847719C0", Slot = "4")]
	public void DFGGKJLGHLE(double FNFKPHHGMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4771AE0", Offset = "0x47700E0", VA = "0x184771AE0", Slot = "5")]
	public void LKFNMONLKBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4771B20", Offset = "0x4770120", VA = "0x184771B20")]
	public KDNPHHEKILD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GPCNFOHKGDH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double JBMOFOLJKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double KDBLAOLPFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double DLKGLNHGJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFGGKJLGHLE(double FNFKPHHGMNL);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKFNMONLKBC();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class FFLGIFFFBPO
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private interface KHKDILCMFGB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool CFKBPLGJCBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FHDFGHEFBIH();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FBLIGHBAIOM();
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private abstract class FFBGAELJING<TPromise, TMainThreadPromise> : KHKDILCMFGB where TPromise : FDFGBMEHONB where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly TPromise LKOHEHEEPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected readonly TMainThreadPromise BHJCLLIOOOD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise BOKMOMKBCPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1067EE0", Offset = "0x10664E0", VA = "0x181067EE0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool CFKBPLGJCBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1067E90", Offset = "0x1066490", VA = "0x181067E90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1067F70", Offset = "0x1066570", VA = "0x181067F70")]
		protected FFBGAELJING(TPromise LKOHEHEEPOM, TMainThreadPromise FMKMFNIAPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1067F40", Offset = "0x1066540", VA = "0x181067F40", Slot = "5")]
		public void FHDFGHEFBIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xD72BF0", Offset = "0xD711F0", VA = "0x180D72BF0", Slot = "6")]
		public void FBLIGHBAIOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void FLINDHGMALJ(TPromise LKOHEHEEPOM);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void IEAHHGJPADD();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class EDDJGPLEGDO<T> : FFBGAELJING<global::ANHHADAADKH<T>, global::FKLAHNHEJJK<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1067DF0", Offset = "0x10663F0", VA = "0x181067DF0")]
		public EDDJGPLEGDO(global::ANHHADAADKH<T> LKOHEHEEPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1067C40", Offset = "0x1066240", VA = "0x181067C40", Slot = "7")]
		protected override void FLINDHGMALJ(global::ANHHADAADKH<T> LKOHEHEEPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1067D90", Offset = "0x1066390", VA = "0x181067D90", Slot = "8")]
		protected override void IEAHHGJPADD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xF19EA0", Offset = "0xF184A0", VA = "0x180F19EA0")]
		[CompilerGenerated]
		private void DHJHOIJAFCK(T FGCHJFNJCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1067C10", Offset = "0x1066210", VA = "0x181067C10")]
		[CompilerGenerated]
		private void AAMFAFJNDOE(string HJAJAOPFGBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class KPNLNKMFNKH : FFBGAELJING<FDFGBMEHONB, IABAIOOKIMF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4772930", Offset = "0x4770F30", VA = "0x184772930")]
		public KPNLNKMFNKH(FDFGBMEHONB LKOHEHEEPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4772810", Offset = "0x4770E10", VA = "0x184772810", Slot = "7")]
		protected override void FLINDHGMALJ(FDFGBMEHONB LKOHEHEEPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x47728E0", Offset = "0x4770EE0", VA = "0x1847728E0", Slot = "8")]
		protected override void IEAHHGJPADD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1061E10", Offset = "0x1060410", VA = "0x181061E10")]
		[CompilerGenerated]
		private void DHJHOIJAFCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1061DF0", Offset = "0x10603F0", VA = "0x181061DF0")]
		[CompilerGenerated]
		private void AAMFAFJNDOE(string HJAJAOPFGBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class BKOALFHHAPE : KHKDILCMFGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Action EMFPEPGCJKF;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool CFKBPLGJCBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x514340", Offset = "0x512940", VA = "0x180514340", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x57A1E0", Offset = "0x5787E0", VA = "0x18057A1E0")]
		public BKOALFHHAPE(Action EMFPEPGCJKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xB67770", Offset = "0xB65D70", VA = "0x180B67770", Slot = "5")]
		public void FHDFGHEFBIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "6")]
		public void FBLIGHBAIOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly List<KHKDILCMFGB> ILJPILGLEBK;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2F87B00", Offset = "0x2F86100", VA = "0x182F87B00")]
	public static global::ANHHADAADKH<T> NHPNMOMJEPG<T>(this global::ANHHADAADKH<T> LKOHEHEEPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x476D4F0", Offset = "0x476BAF0", VA = "0x18476D4F0")]
	public static FDFGBMEHONB NHPNMOMJEPG(this FDFGBMEHONB LKOHEHEEPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x476D460", Offset = "0x476BA60", VA = "0x18476D460")]
	public static void NHPNMOMJEPG(Action EMFPEPGCJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2F87B70", Offset = "0x2F86170", VA = "0x182F87B70")]
	private static global::ANHHADAADKH<T> PNGDMKAPJHA<T>(global::ANHHADAADKH<T> LKOHEHEEPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x476D6B0", Offset = "0x476BCB0", VA = "0x18476D6B0")]
	private static FDFGBMEHONB PNGDMKAPJHA(FDFGBMEHONB LKOHEHEEPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x476CE80", Offset = "0x476B480", VA = "0x18476CE80")]
	private static void BJJEABHPMHF(KHKDILCMFGB KALMJJFHICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x476D140", Offset = "0x476B740", VA = "0x18476D140")]
	private static void KHEBAEHAIAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x476D070", Offset = "0x476B670", VA = "0x18476D070")]
	private static void DMCEEBABOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x476D600", Offset = "0x476BC00", VA = "0x18476D600")]
	private static void OLOKCFECPMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class FLNIPIIOICG
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HDKHHOFPOCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public IABAIOOKIMF onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
		public HDKHHOFPOCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x476EC80", Offset = "0x476D280", VA = "0x18476EC80")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x476EC70", Offset = "0x476D270", VA = "0x18476EC70")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class IHBOBJOMONM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
		public IHBOBJOMONM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x47701E0", Offset = "0x476E7E0", VA = "0x1847701E0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KILHHAPCEIF : IEnumerator<MNMANPNLMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private MNMANPNLMCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IABAIOOKIMF onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private MNMANPNLMCB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
		[DebuggerHidden]
		public KILHHAPCEIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4771E70", Offset = "0x4770470", VA = "0x184771E70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4771B50", Offset = "0x4770150", VA = "0x184771B50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4771F20", Offset = "0x4770520", VA = "0x184771F20")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4771E20", Offset = "0x4770420", VA = "0x184771E20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class GFPAPEDBPGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public IABAIOOKIMF onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
		public GFPAPEDBPGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CFBEACAENMC : IEnumerator<MNMANPNLMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private MNMANPNLMCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public IABAIOOKIMF onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private GFPAPEDBPGK <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private MNMANPNLMCB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
		[DebuggerHidden]
		public CFBEACAENMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x47661B0", Offset = "0x47647B0", VA = "0x1847661B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4766540", Offset = "0x4764B40", VA = "0x184766540", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string CAPGFHLCGPN = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string OACDNEEEOOK = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const string HBIOIICJOJO = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const string MGHLFKACCLD = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public const string KHHDJCPJPDK = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private const float NJAJNBBDEKC = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static FDFGBMEHONB LPHPBFCBJIH;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static AsyncOperation OINDOKPCIOM;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static FDFGBMEHONB GJONFFGGFND;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static string CMHIIMOIMMH;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ThreadPriority MIEFBFPOAIJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool LCIPEFIJLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x476DD80", Offset = "0x476C380", VA = "0x18476DD80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool KOFJNMDMOAM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x476DC90", Offset = "0x476C290", VA = "0x18476DC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool BCDPHKNGKIO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x476DA00", Offset = "0x476C000", VA = "0x18476DA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> OLMNJGAIPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x476D7F0", Offset = "0x476BDF0", VA = "0x18476D7F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x476DE20", Offset = "0x476C420", VA = "0x18476DE20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x476D8A0", Offset = "0x476BEA0", VA = "0x18476D8A0")]
	public static FDFGBMEHONB BDDPFDPBJHC(string FDBGKLNDMGI, LoadSceneMode KPNMNEMPDJL = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x476DA60", Offset = "0x476C060", VA = "0x18476DA60")]
	public static FDFGBMEHONB EGDOBGKGLLI(string FDBGKLNDMGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x476DED0", Offset = "0x476C4D0", VA = "0x18476DED0")]
	[IteratorStateMachine(typeof(KILHHAPCEIF))]
	private static IEnumerator<MNMANPNLMCB> PHNMCPGPMFC(string FDBGKLNDMGI, IABAIOOKIMF PIJGFGHFMBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x476DCF0", Offset = "0x476C2F0", VA = "0x18476DCF0")]
	[IteratorStateMachine(typeof(CFBEACAENMC))]
	private static IEnumerator<MNMANPNLMCB> IJKGEAALDHH(string FDBGKLNDMGI, LoadSceneMode KPNMNEMPDJL, IABAIOOKIMF PIJGFGHFMBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class OPFMJEFABGP
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4773F90", Offset = "0x4772590", VA = "0x184773F90")]
	public static IDisposable MEKCOOLFAHL(this HNHDBGKAENI FBKBDIMBGGH, Action JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4773F10", Offset = "0x4772510", VA = "0x184773F10")]
	public static IDisposable MEKCOOLFAHL(this HNHDBGKAENI FBKBDIMBGGH, Action<float> JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4773D90", Offset = "0x4772390", VA = "0x184773D90")]
	public static IDisposable JCLMFJIGOHA(this HNHDBGKAENI FBKBDIMBGGH, Action JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4774200", Offset = "0x4772800", VA = "0x184774200")]
	public static IDisposable OPNCANOBHFH(this HNHDBGKAENI FBKBDIMBGGH, Action JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4774090", Offset = "0x4772690", VA = "0x184774090")]
	public static IDisposable NKFCFHHDGGK(this HNHDBGKAENI FBKBDIMBGGH, Action JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4773D20", Offset = "0x4772320", VA = "0x184773D20")]
	public static IDisposable HGFEDOHIOHC(this HNHDBGKAENI FBKBDIMBGGH, Action JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4774100", Offset = "0x4772700", VA = "0x184774100")]
	public static IDisposable NLPHAPEOCIF(this HNHDBGKAENI FBKBDIMBGGH, Action JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4773E80", Offset = "0x4772480", VA = "0x184773E80")]
	public static IDisposable MAKOILJAPOA(this HNHDBGKAENI FBKBDIMBGGH, float GOIODHMKCHI, Action<float> JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4774370", Offset = "0x4772970", VA = "0x184774370")]
	public static IDisposable PNNHMDAIBPO(this HNHDBGKAENI FBKBDIMBGGH, float GOIODHMKCHI, Action<float> JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4773A10", Offset = "0x4772010", VA = "0x184773A10")]
	public static IDisposable AAHJNAJJMLE(this HNHDBGKAENI FBKBDIMBGGH, Action<float> JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4773C20", Offset = "0x4772220", VA = "0x184773C20")]
	public static IDisposable BFNHMFKHOBF(this HNHDBGKAENI FBKBDIMBGGH, Action<float> JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4773B10", Offset = "0x4772110", VA = "0x184773B10")]
	public static IDisposable ADIMPLMKHMJ(this HNHDBGKAENI FBKBDIMBGGH, Action<float> JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4773B90", Offset = "0x4772190", VA = "0x184773B90")]
	public static IDisposable AJJOJAJHOJG(this HNHDBGKAENI FBKBDIMBGGH, float GOIODHMKCHI, Action<float> JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4774270", Offset = "0x4772870", VA = "0x184774270")]
	public static IDisposable PCEDILFACPE(this HNHDBGKAENI FBKBDIMBGGH, Action<float> JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x47742F0", Offset = "0x47728F0", VA = "0x1847742F0")]
	public static IDisposable PNFAFFBFIKB(this HNHDBGKAENI FBKBDIMBGGH, Action<float> JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4774010", Offset = "0x4772610", VA = "0x184774010")]
	public static IDisposable MKFKLICPCPH(this HNHDBGKAENI FBKBDIMBGGH, Action<float> JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4774170", Offset = "0x4772770", VA = "0x184774170")]
	public static IDisposable OFBLGJKEHLJ(this HNHDBGKAENI FBKBDIMBGGH, float GOIODHMKCHI, Action<float> JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4773E00", Offset = "0x4772400", VA = "0x184773E00")]
	public static IDisposable KODFCJGDJLB(this HNHDBGKAENI FBKBDIMBGGH, Action<float> JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4773A90", Offset = "0x4772090", VA = "0x184773A90")]
	public static IDisposable ADGCEKPBNMC(this HNHDBGKAENI FBKBDIMBGGH, Action<float> JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4773CA0", Offset = "0x47722A0", VA = "0x184773CA0")]
	public static IDisposable DAGJFGDGIOE(this HNHDBGKAENI FBKBDIMBGGH, Action<float> JMGBKMCKCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class JFHGIBLGDBI
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4770C00", Offset = "0x476F200", VA = "0x184770C00")]
	public static IDisposable FNBBPFPOOHF(this MonoBehaviour LKOMHMGDDNC, Action JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4770C80", Offset = "0x476F280", VA = "0x184770C80")]
	public static IDisposable FNBBPFPOOHF(this MonoBehaviour LKOMHMGDDNC, Action<float> JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4770FC0", Offset = "0x476F5C0", VA = "0x184770FC0")]
	public static IDisposable LHCLGJALOHN(this MonoBehaviour LKOMHMGDDNC, Action JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x47711E0", Offset = "0x476F7E0", VA = "0x1847711E0")]
	public static IDisposable NLIGGHGMGAG(this MonoBehaviour LKOMHMGDDNC, Action JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4770A70", Offset = "0x476F070", VA = "0x184770A70")]
	public static IDisposable EJKBODHILKC(this MonoBehaviour LKOMHMGDDNC, Action JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4770970", Offset = "0x476EF70", VA = "0x184770970")]
	public static IDisposable DNNGCHEKDEN(this MonoBehaviour LKOMHMGDDNC, Action JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4770D00", Offset = "0x476F300", VA = "0x184770D00")]
	public static IDisposable GHNMKBLBCEO(this MonoBehaviour LKOMHMGDDNC, Action JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4770710", Offset = "0x476ED10", VA = "0x184770710")]
	public static IDisposable BBMKODOCDIG(this MonoBehaviour LKOMHMGDDNC, float GOIODHMKCHI, Action<float> JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x47707B0", Offset = "0x476EDB0", VA = "0x1847707B0")]
	public static IDisposable CONGLGFEJOC(this MonoBehaviour LKOMHMGDDNC, float GOIODHMKCHI, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4770F30", Offset = "0x476F530", VA = "0x184770F30")]
	public static IDisposable KOMCAPODKCO(this MonoBehaviour LKOMHMGDDNC, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4770B70", Offset = "0x476F170", VA = "0x184770B70")]
	public static IDisposable EPDIHKBAKBB(this MonoBehaviour LKOMHMGDDNC, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4770680", Offset = "0x476EC80", VA = "0x184770680")]
	public static IDisposable ALIEECLJOJJ(this MonoBehaviour LKOMHMGDDNC, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x47710C0", Offset = "0x476F6C0", VA = "0x1847710C0")]
	public static IDisposable MNEJIBDCJJC(this MonoBehaviour LKOMHMGDDNC, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4770E10", Offset = "0x476F410", VA = "0x184770E10")]
	public static IDisposable IOKJPOKJNOL(this MonoBehaviour LKOMHMGDDNC, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4770EA0", Offset = "0x476F4A0", VA = "0x184770EA0")]
	public static IDisposable KEAACLHFPNA(this MonoBehaviour LKOMHMGDDNC, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x47708D0", Offset = "0x476EED0", VA = "0x1847708D0")]
	public static IDisposable DBLCPJHLMGO(this MonoBehaviour LKOMHMGDDNC, float GOIODHMKCHI, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4771030", Offset = "0x476F630", VA = "0x184771030")]
	public static IDisposable LPLHOENENDF(this MonoBehaviour LKOMHMGDDNC, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4771250", Offset = "0x476F850", VA = "0x184771250")]
	public static IDisposable OPGLLALEAKF(this MonoBehaviour LKOMHMGDDNC, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4770840", Offset = "0x476EE40", VA = "0x184770840")]
	public static IDisposable DBDPFIKAHBM(this MonoBehaviour LKOMHMGDDNC, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4770D70", Offset = "0x476F370", VA = "0x184770D70")]
	public static IDisposable GMAOOGAHBAF(this MonoBehaviour LKOMHMGDDNC, float GOIODHMKCHI, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4771150", Offset = "0x476F750", VA = "0x184771150")]
	public static IDisposable NBNHMPGBKLI(this MonoBehaviour LKOMHMGDDNC, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4770AE0", Offset = "0x476F0E0", VA = "0x184770AE0")]
	public static IDisposable ELHIAPCDCKH(this MonoBehaviour LKOMHMGDDNC, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x47709E0", Offset = "0x476EFE0", VA = "0x1847709E0")]
	public static IDisposable EFOHHBCEDLM(this MonoBehaviour LKOMHMGDDNC, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class DKHLPDHIAFM
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class DMMLNEMEKMF : IEnumerator<MNMANPNLMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private MNMANPNLMCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public LAJDCKMGDCG.OBEBMILFKKJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private HBABGICOFKN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private MNMANPNLMCB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
		[DebuggerHidden]
		public DMMLNEMEKMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4768FE0", Offset = "0x47675E0", VA = "0x184768FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x47690A0", Offset = "0x47676A0", VA = "0x1847690A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KDEKIJBPHBG : IEnumerator<MNMANPNLMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private MNMANPNLMCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public LAJDCKMGDCG.OBEBMILFKKJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private HBABGICOFKN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private MNMANPNLMCB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
		[DebuggerHidden]
		public KDEKIJBPHBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4771890", Offset = "0x476FE90", VA = "0x184771890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4771970", Offset = "0x476FF70", VA = "0x184771970", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4768AD0", Offset = "0x47670D0", VA = "0x184768AD0")]
	public static NIKIHPIPFGJ FNBBPFPOOHF(Action JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4768CD0", Offset = "0x47672D0", VA = "0x184768CD0")]
	public static NIKIHPIPFGJ FNBBPFPOOHF(Action<float> JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4768BC0", Offset = "0x47671C0", VA = "0x184768BC0")]
	public static NIKIHPIPFGJ FNBBPFPOOHF(Behaviour FBKBDIMBGGH, Action JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x47689C0", Offset = "0x4766FC0", VA = "0x1847689C0")]
	public static NIKIHPIPFGJ FNBBPFPOOHF(Behaviour FBKBDIMBGGH, Action<float> JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4768DC0", Offset = "0x47673C0", VA = "0x184768DC0")]
	public static NIKIHPIPFGJ MEKCOOLFAHL(HNHDBGKAENI FBKBDIMBGGH, Action JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4768ED0", Offset = "0x47674D0", VA = "0x184768ED0")]
	public static NIKIHPIPFGJ MEKCOOLFAHL(HNHDBGKAENI FBKBDIMBGGH, Action<float> JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4768940", Offset = "0x4766F40", VA = "0x184768940")]
	[IteratorStateMachine(typeof(DMMLNEMEKMF))]
	private static IEnumerator<MNMANPNLMCB> ADPMHAFFHMB(LAJDCKMGDCG.OBEBMILFKKJ IHPJBOJOCHF, Action JMGBKMCKCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x47688C0", Offset = "0x4766EC0", VA = "0x1847688C0")]
	[IteratorStateMachine(typeof(KDEKIJBPHBG))]
	private static IEnumerator<MNMANPNLMCB> ADPMHAFFHMB(LAJDCKMGDCG.OBEBMILFKKJ IHPJBOJOCHF, Action<float> JMGBKMCKCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class JOGJKDNLEIP
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class NDJMKBKDDAM : IEnumerator<MNMANPNLMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private MNMANPNLMCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public LAJDCKMGDCG.OBEBMILFKKJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private FBGCAFOIMLP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private MNMANPNLMCB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
		[DebuggerHidden]
		public NDJMKBKDDAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4773430", Offset = "0x4771A30", VA = "0x184773430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4773540", Offset = "0x4771B40", VA = "0x184773540", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4771440", Offset = "0x476FA40", VA = "0x184771440")]
	public static NIKIHPIPFGJ FNBBPFPOOHF(float GOIODHMKCHI, Action<float> JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4771500", Offset = "0x476FB00", VA = "0x184771500")]
	public static NIKIHPIPFGJ FNBBPFPOOHF(MonoBehaviour LKOMHMGDDNC, float GOIODHMKCHI, Action<float> JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4771380", Offset = "0x476F980", VA = "0x184771380")]
	public static NIKIHPIPFGJ AOLFLNPLHEI(HNHDBGKAENI FBKBDIMBGGH, float GOIODHMKCHI, Action<float> JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG, bool JMLIMIGCMJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x47712E0", Offset = "0x476F8E0", VA = "0x1847712E0")]
	[IteratorStateMachine(typeof(NDJMKBKDDAM))]
	private static IEnumerator<MNMANPNLMCB> ADPMHAFFHMB(float GOIODHMKCHI, LAJDCKMGDCG.OBEBMILFKKJ IHPJBOJOCHF, Action<float> JMGBKMCKCBL, bool JMLIMIGCMJP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BLCHBBLPNDO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class OPKMCBKBPIK : IEnumerator<MNMANPNLMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private MNMANPNLMCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public LAJDCKMGDCG.OBEBMILFKKJ queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private MNMANPNLMCB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
		[DebuggerHidden]
		public OPKMCBKBPIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x47743F0", Offset = "0x47729F0", VA = "0x1847743F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x47744A0", Offset = "0x4772AA0", VA = "0x1847744A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4765490", Offset = "0x4763A90", VA = "0x184765490")]
	[IteratorStateMachine(typeof(OPKMCBKBPIK))]
	private static IEnumerator<MNMANPNLMCB> LDBAGHOMMGG(LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG, Func<bool> LPMGCAFFAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4765510", Offset = "0x4763B10", VA = "0x184765510")]
	public static NIKIHPIPFGJ MIEDBCBBPID(this MonoBehaviour LKOMHMGDDNC, Func<bool> LPMGCAFFAMA, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG = LAJDCKMGDCG.OBEBMILFKKJ.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class PJBNHNLKEMK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class KBHKLHJDKDL : IEnumerator<MNMANPNLMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private MNMANPNLMCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public LAJDCKMGDCG.OBEBMILFKKJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private MNMANPNLMCB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
		[DebuggerHidden]
		public KBHKLHJDKDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4771780", Offset = "0x476FD80", VA = "0x184771780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4771840", Offset = "0x476FE40", VA = "0x184771840", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class DDCDCEGGEGM : IEnumerator<MNMANPNLMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private MNMANPNLMCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public LAJDCKMGDCG.OBEBMILFKKJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private MNMANPNLMCB <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private MNMANPNLMCB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
		[DebuggerHidden]
		public DDCDCEGGEGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4768680", Offset = "0x4766C80", VA = "0x184768680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4768750", Offset = "0x4766D50", VA = "0x184768750", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4774F60", Offset = "0x4773560", VA = "0x184774F60")]
	[IteratorStateMachine(typeof(KBHKLHJDKDL))]
	private static IEnumerator<MNMANPNLMCB> NMNHJIBEGFM(float CPANMKLOGPE, LAJDCKMGDCG.OBEBMILFKKJ IHPJBOJOCHF, Action NPFKIDPECAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x47746A0", Offset = "0x4772CA0", VA = "0x1847746A0")]
	[IteratorStateMachine(typeof(DDCDCEGGEGM))]
	private static IEnumerator<MNMANPNLMCB> BAFAEADLCNF(float CPANMKLOGPE, LAJDCKMGDCG.OBEBMILFKKJ IHPJBOJOCHF, Action NPFKIDPECAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4774A60", Offset = "0x4773060", VA = "0x184774A60")]
	public static IDisposable GEBFFMIFFLB(this MonoBehaviour LKOMHMGDDNC, float CPANMKLOGPE, Action NPFKIDPECAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4774730", Offset = "0x4772D30", VA = "0x184774730")]
	public static NIKIHPIPFGJ BLHNHAECGKH(this MonoBehaviour LKOMHMGDDNC, float CPANMKLOGPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4774BB0", Offset = "0x47731B0", VA = "0x184774BB0")]
	public static NIKIHPIPFGJ GEBFFMIFFLB(this MonoBehaviour LKOMHMGDDNC, float CPANMKLOGPE, LAJDCKMGDCG.OBEBMILFKKJ IHPJBOJOCHF, Action NPFKIDPECAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4774830", Offset = "0x4772E30", VA = "0x184774830")]
	public static NIKIHPIPFGJ BLOBHMOPGIJ(this MonoBehaviour LKOMHMGDDNC, Action NPFKIDPECAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4774690", Offset = "0x4772C90", VA = "0x184774690")]
	public static NIKIHPIPFGJ APPPGPINPLH(this MonoBehaviour LKOMHMGDDNC, Action NPFKIDPECAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4774D20", Offset = "0x4773320", VA = "0x184774D20")]
	public static NIKIHPIPFGJ IAELFDEIBPN(this MonoBehaviour LKOMHMGDDNC, Action NPFKIDPECAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4774D30", Offset = "0x4773330", VA = "0x184774D30")]
	public static NIKIHPIPFGJ IGJOBPOGPJN(this MonoBehaviour LKOMHMGDDNC, Action NPFKIDPECAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4774D10", Offset = "0x4773310", VA = "0x184774D10")]
	public static NIKIHPIPFGJ HKIEKMPDBIC(this MonoBehaviour LKOMHMGDDNC, Action NPFKIDPECAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4774E50", Offset = "0x4773450", VA = "0x184774E50")]
	private static NIKIHPIPFGJ MGAENMEEHNA(MonoBehaviour LKOMHMGDDNC, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG, Action NPFKIDPECAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4774950", Offset = "0x4772F50", VA = "0x184774950")]
	public static NIKIHPIPFGJ EHMDJFFHBNA(this MonoBehaviour LKOMHMGDDNC, float GPNFMPJMFFL, Action NPFKIDPECAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4774FF0", Offset = "0x47735F0", VA = "0x184774FF0")]
	public static NIKIHPIPFGJ PKDGOEEDAKF(this MonoBehaviour LKOMHMGDDNC, float GPNFMPJMFFL, Action NPFKIDPECAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4774D40", Offset = "0x4773340", VA = "0x184774D40")]
	public static NIKIHPIPFGJ JDLBDCDDDCL(this MonoBehaviour LKOMHMGDDNC, float GPNFMPJMFFL, Action NPFKIDPECAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4774580", Offset = "0x4772B80", VA = "0x184774580")]
	public static NIKIHPIPFGJ AOCGGNIFKBF(this MonoBehaviour LKOMHMGDDNC, float GPNFMPJMFFL, Action NPFKIDPECAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4774840", Offset = "0x4772E40", VA = "0x184774840")]
	public static NIKIHPIPFGJ BNFABFMALCC(this MonoBehaviour LKOMHMGDDNC, float GPNFMPJMFFL, Action NPFKIDPECAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class KBCADAOFEED : CKLCMHLPHHK
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class HBFNPJMGONM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KBCADAOFEED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
		public HBFNPJMGONM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x476EC40", Offset = "0x476D240", VA = "0x18476EC40")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class JBNKGIOBNJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public KBCADAOFEED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
		public JBNKGIOBNJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x476EC40", Offset = "0x476D240", VA = "0x18476EC40")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly float PMCLLGAKLGB;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x47656B0", Offset = "0x4763CB0", VA = "0x1847656B0")]
	public KBCADAOFEED(Behaviour FBKBDIMBGGH, float PMCLLGAKLGB, [Optional] Action FCGHLFOKCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x47715C0", Offset = "0x476FBC0", VA = "0x1847715C0", Slot = "9")]
	protected override bool DGDHFMMPJAD(Action EMFPEPGCJKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x47716A0", Offset = "0x476FCA0", VA = "0x1847716A0", Slot = "10")]
	protected override bool LHEDEPEFPDC(Action EMFPEPGCJKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface APCLCJBPOHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool PHBGHLNINAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GGJGDNPBKHO;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DJPNMNNKLMM(bool AMNGIMHJGMG = false);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DJPNMNNKLMM(Action EMFPEPGCJKF, bool AMNGIMHJGMG = false);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class CKLCMHLPHHK : APCLCJBPOHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class HICDLEJDJHJ : IEnumerator<MNMANPNLMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private MNMANPNLMCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private MNMANPNLMCB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
		[DebuggerHidden]
		public HICDLEJDJHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x476F3E0", Offset = "0x476D9E0", VA = "0x18476F3E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x476F480", Offset = "0x476DA80", VA = "0x18476F480", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Behaviour FBKBDIMBGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Action FCGHLFOKCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private EEPOMOFHPMH PHEAHNNIAIP;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool PHBGHLNINAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xD80300", Offset = "0xD7E900", VA = "0x180D80300", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GGJGDNPBKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4766590", Offset = "0x4764B90", VA = "0x184766590", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x47666E0", Offset = "0x4764CE0", VA = "0x1847666E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4766A90", Offset = "0x4765090", VA = "0x184766A90")]
	protected CKLCMHLPHHK(Behaviour FBKBDIMBGGH, [Optional] Action FCGHLFOKCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4766680", Offset = "0x4764C80", VA = "0x184766680", Slot = "7")]
	public bool DJPNMNNKLMM(bool AMNGIMHJGMG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4766630", Offset = "0x4764C30", VA = "0x184766630", Slot = "8")]
	public bool DJPNMNNKLMM(Action EMFPEPGCJKF, bool AMNGIMHJGMG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool DGDHFMMPJAD(Action EMFPEPGCJKF);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool LHEDEPEFPDC(Action EMFPEPGCJKF);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4766A00", Offset = "0x4765000", VA = "0x184766A00")]
	protected void LFNGGKLOHJJ(Action EMFPEPGCJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4766780", Offset = "0x4764D80", VA = "0x184766780")]
	protected FDFGBMEHONB GGBCPFIIAGJ(float COGFINDEIJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4766A20", Offset = "0x4765020", VA = "0x184766A20")]
	private void PCPPPHPDMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x47669A0", Offset = "0x4764FA0", VA = "0x1847669A0")]
	[IteratorStateMachine(typeof(HICDLEJDJHJ))]
	private static IEnumerator<MNMANPNLMCB> KIKEOAFBMIK(float COGFINDEIJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4766960", Offset = "0x4764F60", VA = "0x184766960")]
	[CompilerGenerated]
	private void KFHMGDOPNMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class JAPNJFPGLHO : CKLCMHLPHHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly float BOPMEJDCNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly int GGHONILLDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly float HHEIPFKNILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly float[] HNCBIGFFNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int DNHJKAGMCOK;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public FBCJAPFJCLA BAECMNCFOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x534830", Offset = "0x532E30", VA = "0x180534830")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x534510", Offset = "0x532B10", VA = "0x180534510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4770550", Offset = "0x476EB50", VA = "0x184770550")]
	public JAPNJFPGLHO(Behaviour FBKBDIMBGGH, float CPKIKOANELD, int GGHONILLDHK, [Optional] Action FCGHLFOKCIB, float HHEIPFKNILE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x570FF0", Offset = "0x56F5F0", VA = "0x180570FF0", Slot = "9")]
	protected override bool DGDHFMMPJAD(Action EMFPEPGCJKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x47702A0", Offset = "0x476E8A0", VA = "0x1847702A0", Slot = "10")]
	protected override bool LHEDEPEFPDC(Action EMFPEPGCJKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x47704C0", Offset = "0x476EAC0", VA = "0x1847704C0")]
	private void PCMBJCHFAHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class BMBHFEHKBIH : CKLCMHLPHHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly float PMCLLGAKLGB;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x47656B0", Offset = "0x4763CB0", VA = "0x1847656B0")]
	public BMBHFEHKBIH(Behaviour FBKBDIMBGGH, float PMCLLGAKLGB, [Optional] Action FCGHLFOKCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x570FF0", Offset = "0x56F5F0", VA = "0x180570FF0", Slot = "9")]
	protected override bool DGDHFMMPJAD(Action EMFPEPGCJKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4765670", Offset = "0x4763C70", VA = "0x184765670", Slot = "10")]
	protected override bool LHEDEPEFPDC(Action EMFPEPGCJKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class PMDEJJKADAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class HFFFJKLCNCM : IEnumerator<MNMANPNLMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private MNMANPNLMCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private MNMANPNLMCB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
		[DebuggerHidden]
		public HFFFJKLCNCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x476EE80", Offset = "0x476D480", VA = "0x18476EE80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x476EF80", Offset = "0x476D580", VA = "0x18476EF80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private NIKIHPIPFGJ HIPOJPPBMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private HNHDBGKAENI FBKBDIMBGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action JMGBKMCKCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Action<float> HIHDLHOMIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private float GCDOAKMEDDM;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4775AB0", Offset = "0x47740B0", VA = "0x184775AB0")]
	public PMDEJJKADAN(HNHDBGKAENI FBKBDIMBGGH, Action JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x47758F0", Offset = "0x4773EF0", VA = "0x1847758F0")]
	public PMDEJJKADAN(HNHDBGKAENI FBKBDIMBGGH, Action<float> JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4775C70", Offset = "0x4774270", VA = "0x184775C70")]
	public PMDEJJKADAN(HNHDBGKAENI FBKBDIMBGGH, float GOIODHMKCHI, Action<float> JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4775360", Offset = "0x4773960", VA = "0x184775360")]
	private void FNBBPFPOOHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x47751D0", Offset = "0x47737D0", VA = "0x1847751D0")]
	private void FHKAEKHFEJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x47757A0", Offset = "0x4773DA0", VA = "0x1847757A0")]
	private void KOFPMFCMFFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x47755F0", Offset = "0x4773BF0", VA = "0x1847755F0")]
	private void IEHMHFENAML(string HJAJAOPFGBJ, Action PDDJFLIGBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4775100", Offset = "0x4773700", VA = "0x184775100")]
	[IteratorStateMachine(typeof(HFFFJKLCNCM))]
	private IEnumerator<MNMANPNLMCB> DLBLBBCKLMG(Action PDDJFLIGBKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4775170", Offset = "0x4773770", VA = "0x184775170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4775720", Offset = "0x4773D20", VA = "0x184775720")]
	[CompilerGenerated]
	private void JJAEMONNGIO(string OBBHILLKPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x47754F0", Offset = "0x4773AF0", VA = "0x1847754F0")]
	[CompilerGenerated]
	private void GJNFEJNKJMG(string OBBHILLKPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4775570", Offset = "0x4773B70", VA = "0x184775570")]
	[CompilerGenerated]
	private void GNANBOIPDCP(string OBBHILLKPGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class HIPPOPLBFOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class GACANBIJKEJ : IEnumerator<MNMANPNLMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private MNMANPNLMCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private MNMANPNLMCB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
		[DebuggerHidden]
		public GACANBIJKEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x476DF60", Offset = "0x476C560", VA = "0x18476DF60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x476E060", Offset = "0x476C660", VA = "0x18476E060", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private NIKIHPIPFGJ HIPOJPPBMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private MonoBehaviour LKOMHMGDDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Action JMGBKMCKCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Action<float> HIHDLHOMIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float GCDOAKMEDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool JMLIMIGCMJP;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x476FE60", Offset = "0x476E460", VA = "0x18476FE60")]
	public HIPPOPLBFOI(MonoBehaviour LKOMHMGDDNC, Action JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4770020", Offset = "0x476E620", VA = "0x184770020")]
	public HIPPOPLBFOI(MonoBehaviour LKOMHMGDDNC, Action<float> JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x476FCC0", Offset = "0x476E2C0", VA = "0x18476FCC0")]
	public HIPPOPLBFOI(MonoBehaviour LKOMHMGDDNC, float GOIODHMKCHI, Action<float> JMGBKMCKCBL, LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG, bool JMLIMIGCMJP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x476F7B0", Offset = "0x476DDB0", VA = "0x18476F7B0")]
	private void FNBBPFPOOHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x476F620", Offset = "0x476DC20", VA = "0x18476F620")]
	private void FHKAEKHFEJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x476FB70", Offset = "0x476E170", VA = "0x18476FB70")]
	private void KOFPMFCMFFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x476F9C0", Offset = "0x476DFC0", VA = "0x18476F9C0")]
	private void IEHMHFENAML(string HJAJAOPFGBJ, Action PDDJFLIGBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x476F4D0", Offset = "0x476DAD0", VA = "0x18476F4D0")]
	[IteratorStateMachine(typeof(GACANBIJKEJ))]
	private IEnumerator<MNMANPNLMCB> DLBLBBCKLMG(Action PDDJFLIGBKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x476F540", Offset = "0x476DB40", VA = "0x18476F540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x476FAF0", Offset = "0x476E0F0", VA = "0x18476FAF0")]
	[CompilerGenerated]
	private void KLEDIONLONF(string OBBHILLKPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x476F5A0", Offset = "0x476DBA0", VA = "0x18476F5A0")]
	[CompilerGenerated]
	private void FAIFPOMJBFH(string OBBHILLKPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x476F940", Offset = "0x476DF40", VA = "0x18476F940")]
	[CompilerGenerated]
	private void IDHAGLLJBAN(string OBBHILLKPGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface DCBLDIEMGGB
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int MCDDHJJAENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class CDBDKBEDLJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly CDBDKBEDLJC APPKFLLLNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Action HBKKCAIILOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool PEDKFHFJMMH;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x57A1E0", Offset = "0x5787E0", VA = "0x18057A1E0")]
	public CDBDKBEDLJC(Action HBKKCAIILOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x47660B0", Offset = "0x47646B0", VA = "0x1847660B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface DHHCBNICIJI<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T OMBLCGHBLCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable NIBPKOBFEKC(Action<T> JKHDHDKODOL);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable NIBPKOBFEKC(UnityEngine.Object FBKBDIMBGGH, Action<T> JKHDHDKODOL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GHLFDIFNLJA<T> : global::DHHCBNICIJI<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T OMBLCGHBLCN
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
public class NFDCJGNCLCG<T> : global::GHLFDIFNLJA<T>, global::DHHCBNICIJI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class CNOHGFGHLCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public global::NFDCJGNCLCG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::FKLMNOIBJGA<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9587B0", Offset = "0x956DB0", VA = "0x1809587B0")]
		public CNOHGFGHLCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DDD0", Offset = "0x3C2C3D0", VA = "0x183C2DDD0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static GameObject NJEDAOPAOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<global::FKLMNOIBJGA<UnityEngine.Object, Action<T>>> LNMHGONFMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private T AOEOHCIKPOC;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object JMFBADLBLCO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3C365D0", Offset = "0x3C34BD0", VA = "0x183C365D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T OMBLCGHBLCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7438E0", Offset = "0x741EE0", VA = "0x1807438E0", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3C362E0", Offset = "0x3C348E0", VA = "0x183C362E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3C37200", Offset = "0x3C35800", VA = "0x183C37200")]
	private static bool PPNMMPCCBHH(T AIOBBLAENLL, T CGENIFKMPBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3C373B0", Offset = "0x3C359B0", VA = "0x183C373B0")]
	public NFDCJGNCLCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3C37270", Offset = "0x3C35870", VA = "0x183C37270")]
	public NFDCJGNCLCG(T BBCDCBNNIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x3C36820", Offset = "0x3C34E20", VA = "0x183C36820")]
	public void BOFACNJHICI(T JJFPPONFFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3C36EA0", Offset = "0x3C354A0", VA = "0x183C36EA0", Slot = "7")]
	public IDisposable NIBPKOBFEKC(Action<T> JKHDHDKODOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3C37070", Offset = "0x3C35670", VA = "0x183C37070", Slot = "8")]
	public IDisposable NIBPKOBFEKC(UnityEngine.Object FBKBDIMBGGH, Action<T> JKHDHDKODOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3C36B70", Offset = "0x3C35170", VA = "0x183C36B70")]
	private void CBGFCJGHCJN()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<EGIJNDAILGG, Scheduler>, EGIJNDAILGG
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class BMNPCPCDAPM : DCBLDIEMGGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public EBJLNAFHPGM LHPKAOFBKFN;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int MCDDHJJAENE
			{
				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x52EF70", Offset = "0x52D570", VA = "0x18052EF70", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x5898C0", Offset = "0x587EC0", VA = "0x1805898C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x47657F0", Offset = "0x4763DF0", VA = "0x1847657F0")]
			public static MNMANPNLMCB AGNKOMCOPHM(IEnumerator<MNMANPNLMCB> FAMLNKIKMGG, PCACOLIMFAE OOLNGCNGGEE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4765710", Offset = "0x4763D10", VA = "0x184765710")]
			public MNMANPNLMCB AGNKOMCOPHM(PCACOLIMFAE[] JOMALGMEIEM, IEnumerator<MNMANPNLMCB>[] GLFMMBMEEFN, MNMANPNLMCB[] PCCKMGOHNAL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4765950", Offset = "0x4763F50", VA = "0x184765950")]
			public void DFKMDEAOKEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4765980", Offset = "0x4763F80", VA = "0x184765980")]
			public void OJFLBLPMGJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x4765A50", Offset = "0x4764050", VA = "0x184765A50")]
			public void PKEDPLBACOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4765950", Offset = "0x4763F50", VA = "0x184765950")]
			public void FBLIGHBAIOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
			public BMNPCPCDAPM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class EBJLNAFHPGM
		{
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct HINIEPEFAEH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public BMNPCPCDAPM OPNHHFJEKIK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public HNHDBGKAENI KCLNIDMLKDL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public PCACOLIMFAE DFOHOMMNCNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public IEnumerator<MNMANPNLMCB> AFBAMIMNEIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public MNMANPNLMCB AAOPLCHHKBK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public HHGEAHJKBGH EOCGGACMKME;
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			public struct ECBDBAMANBE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public LAJDCKMGDCG.OBEBMILFKKJ FLMLGJGBBDP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public List<HINIEPEFAEH> GCPHNFPFOEN;
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class LKAEJABDIDM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public EBJLNAFHPGM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public HNHDBGKAENI context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public BMNPCPCDAPM routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public HHGEAHJKBGH coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public PCACOLIMFAE promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public MNMANPNLMCB currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public IEnumerator<MNMANPNLMCB> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
				public LKAEJABDIDM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x4772B70", Offset = "0x4771170", VA = "0x184772B70")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class BGGJDKPMPFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public BMNPCPCDAPM schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				public EBJLNAFHPGM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
				public BGGJDKPMPFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x4765390", Offset = "0x4763990", VA = "0x184765390")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private sealed class LKGKJLHHGAD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public BMNPCPCDAPM schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public EBJLNAFHPGM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
				public LKGKJLHHGAD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x4773220", Offset = "0x4771820", VA = "0x184773220")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			[CompilerGenerated]
			private sealed class ECDKIMNPIHJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public BMNPCPCDAPM schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public EBJLNAFHPGM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
				public ECDKIMNPIHJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x476B410", Offset = "0x4769A10", VA = "0x18476B410")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private readonly LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private bool[] OBKDAEGLBMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<HHGEAHJKBGH> FGGNFDHDNPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<float> EMLBKANKNGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private NativeArray<int> NHNPKBHHGBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NativeArray<int> JIFOJKEIPJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private NativeArray<int> JPDNOBOJEBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private NativeArray<int> LPHFOIKGFOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private NativeArray<int> CLPKHOCPBKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private BMNPCPCDAPM[] GACGDILPELB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private PCACOLIMFAE[] JOMALGMEIEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private HNHDBGKAENI[] LLFMOHAKKKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private IEnumerator<MNMANPNLMCB>[] IFCAIBDCIID;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private MNMANPNLMCB[] CNBOOGGEBNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int INBHHBMBHDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private int MLFIIPFKFNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private readonly int HBKEDECBFMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private float KILMIKOBBHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private BNGPEOBKBNB MGHGLMCMCLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private JobHandle BECCFGGAJBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private List<BMNPCPCDAPM> PJBELFMELBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private bool LEDCLDDDIPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private List<Action> FMPMFAFPEJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private List<Action> BKFPHGNJJEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private bool ELEMDEHANEL;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public ECBDBAMANBE[] DENEBLGBMHD
			{
				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0x72E380", Offset = "0x72C980", VA = "0x18072E380")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int EAJFPJEDNNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0x5407B0", Offset = "0x53EDB0", VA = "0x1805407B0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x47699B0", Offset = "0x4767FB0", VA = "0x1847699B0")]
			private static int IFLFGIFHNHC(LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x476AEC0", Offset = "0x47694C0", VA = "0x18476AEC0")]
			public EBJLNAFHPGM(LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x4769360", Offset = "0x4767960", VA = "0x184769360")]
			private void EHLFGCNNMEH(ref int HGMFOKNHLAH, int MLKAOIMIHMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x476A9D0", Offset = "0x4768FD0", VA = "0x18476A9D0")]
			public void OAACHONNLAF(HNHDBGKAENI FBKBDIMBGGH, MNMANPNLMCB GJLOEHDBPAB, IEnumerator<MNMANPNLMCB> FAMLNKIKMGG, PCACOLIMFAE OOLNGCNGGEE, [Optional] BMNPCPCDAPM BOMHAOLBLKF, HHGEAHJKBGH MIGHKPDFODI = HHGEAHJKBGH.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x4769170", Offset = "0x4767770", VA = "0x184769170")]
			public void DEDLPNKKPNO(IEnumerable<HINIEPEFAEH> OBCMCFIGCAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x47699E0", Offset = "0x4767FE0", VA = "0x1847699E0")]
			private HINIEPEFAEH IIGGNGGLACE(int PENGILFEKKL)
			{
				return default(HINIEPEFAEH);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x4769E60", Offset = "0x4768460", VA = "0x184769E60")]
			private void JMEHACACCGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x31AA3A0", Offset = "0x31A89A0", VA = "0x1831AA3A0")]
			private static void HLIPCLIDLFO<T>(int PENGILFEKKL, T[] PNFLFOFGJMG, int MMFNMECEIOB, [Optional] T KNMFDOIBIGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x31AA380", Offset = "0x31A8980", VA = "0x1831AA380")]
			private static void HLIPCLIDLFO<T>(int PENGILFEKKL, NativeArray<T> PNFLFOFGJMG, int MMFNMECEIOB, [Optional] T KNMFDOIBIGI) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x476A670", Offset = "0x4768C70", VA = "0x18476A670")]
			private void NAGOGKIIMNM(IEnumerable<HINIEPEFAEH> OBCMCFIGCAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x47698F0", Offset = "0x4767EF0", VA = "0x1847698F0")]
			private void HMGJKJDDGAE(HINIEPEFAEH HDHFAIIFGAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x47695B0", Offset = "0x4767BB0", VA = "0x1847695B0")]
			private JBLKJCONKNJ GLFDIDMONKE(int IPDEBLGCLJH)
			{
				return default(JBLKJCONKNJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x476AC10", Offset = "0x4769210", VA = "0x18476AC10")]
			public void PLCFIOCOJHH(float MEJKCNGGGKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x47690F0", Offset = "0x47676F0", VA = "0x1847690F0")]
			private void CFKAKAHIMHA(Action AIOBBLAENLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x4769870", Offset = "0x4767E70", VA = "0x184769870")]
			private void HDAMJEKBFEB(Action AIOBBLAENLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x476A1D0", Offset = "0x47687D0", VA = "0x18476A1D0")]
			public void KJAIMOJLJDD(float MEJKCNGGGKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x476AB30", Offset = "0x4769130", VA = "0x18476AB30")]
			public void OJJBINEMABO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x47694F0", Offset = "0x4767AF0", VA = "0x1847694F0")]
			public void FBLIGHBAIOM(BMNPCPCDAPM LALJHOJFJIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x476AE00", Offset = "0x4769400", VA = "0x18476AE00")]
			public void PNKDACBLBJJ(BMNPCPCDAPM LALJHOJFJIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x476A910", Offset = "0x4768F10", VA = "0x18476A910")]
			public void NFIFOFALNAC(BMNPCPCDAPM LALJHOJFJIC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile]
		public struct BNGPEOBKBNB : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public float OOKMEOKMFGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public int JNAGJMEIAGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private NativeArray<int> DLHOJBAFAIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private NativeArray<int> NKPJANNDHOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private NativeArray<int> MNCIKELJKMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[ReadOnly]
			public NativeArray<HHGEAHJKBGH> GEFKDMIEAPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[ReadOnly]
			public NativeArray<float> EGNOAJHCOFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			[WriteOnly]
			public NativeArray<int> JPDNOBOJEBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[WriteOnly]
			public NativeArray<int> NHNPKBHHGBL;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x4765C70", Offset = "0x4764270", VA = "0x184765C70")]
			public static BNGPEOBKBNB GMAHEMAIIFF(int OLHFECJHMID, float MEJKCNGGGKP, NativeArray<HHGEAHJKBGH> MANMOOOOBNN, NativeArray<float> EAADMFOBIOC, NativeArray<int> PCFAAFFIOEK, NativeArray<int> HJGPOMDBNPF, NativeArray<int> KMAIHLLIGDE, NativeArray<int> NKPJANNDHOG, NativeArray<int> MNCIKELJKMI)
			{
				return default(BNGPEOBKBNB);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x4765B50", Offset = "0x4764150", VA = "0x184765B50", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x4765C30", Offset = "0x4764230", VA = "0x184765C30")]
			private bool GFDNGFLJJMP(int JGJLGOCHIGF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4765B20", Offset = "0x4764120", VA = "0x184765B20")]
			private void BAOMHPBBPKE(NativeArray<int> CHFLOLIBPDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x4765D40", Offset = "0x4764340", VA = "0x184765D40")]
			private int HHEMOLCGFKH(int KJGOFDAFEGF, int NJAEBCPFLMJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x4765DB0", Offset = "0x47643B0", VA = "0x184765DB0")]
			private void JOILBHLNFAK(NativeArray<int> CHFLOLIBPDG, int IDMJKCNIJLL, int CANALJKBHHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x4765E80", Offset = "0x4764480", VA = "0x184765E80")]
			private void MGGLCHDJBMJ(NativeArray<int> CHFLOLIBPDG, int GCALMEMCEPD, int DIPGEGCDPIN, int NMHBJAJLAJM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private sealed class GKEMLFPCHKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private readonly PCACOLIMFAE OOLNGCNGGEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private readonly Behaviour FBKBDIMBGGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private readonly bool BEIMDBFDJIK;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<MNMANPNLMCB> AFBAMIMNEIG
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x5734D0", Offset = "0x571AD0", VA = "0x1805734D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x513000", Offset = "0x511600", VA = "0x180513000")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public MNMANPNLMCB AAOPLCHHKBK
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x5898D0", Offset = "0x587ED0", VA = "0x1805898D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool NEOBMOLHKCK
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x476E980", Offset = "0x476CF80", VA = "0x18476E980")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool IJNOJLNGCGO
			{
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x756680", Offset = "0x754C80", VA = "0x180756680")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x7553C0", Offset = "0x7539C0", VA = "0x1807553C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string GHPHAKNHGNN
			{
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x5718F0", Offset = "0x56FEF0", VA = "0x1805718F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x572850", Offset = "0x570E50", VA = "0x180572850")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float IOFNHIFNEJL
			{
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0xC40CD0", Offset = "0xC3F2D0", VA = "0x180C40CD0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x1DA0890", Offset = "0x1D9EE90", VA = "0x181DA0890")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x476EAA0", Offset = "0x476D0A0", VA = "0x18476EAA0")]
			public GKEMLFPCHKD(IEnumerator<MNMANPNLMCB> FAMLNKIKMGG, Behaviour FBKBDIMBGGH, PCACOLIMFAE OOLNGCNGGEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x476E650", Offset = "0x476CC50", VA = "0x18476E650")]
			public MNMANPNLMCB AGNKOMCOPHM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x476E8F0", Offset = "0x476CEF0", VA = "0x18476E8F0")]
			public bool MLHDEHGMNKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x476E860", Offset = "0x476CE60", VA = "0x18476E860")]
			public void FBLIGHBAIOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x476EA10", Offset = "0x476D010", VA = "0x18476EA10", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x261AEA0", Offset = "0x26194A0", VA = "0x18261AEA0")]
			[CompilerGenerated]
			private void LCLOHKELKNA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class PCACOLIMFAE : BIKEPBMMJPK, NIKIHPIPFGJ, EEPOMOFHPMH, FDFGBMEHONB, IEnumerator, MNMANPNLMCB, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private LAJDCKMGDCG.OBEBMILFKKJ KEJPBEIGGNA;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private LAJDCKMGDCG.OBEBMILFKKJ ONJKJLMIGMJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x674490", Offset = "0x672A90", VA = "0x180674490", Slot = "23")]
				get
				{
					return default(LAJDCKMGDCG.OBEBMILFKKJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public LAJDCKMGDCG.OBEBMILFKKJ LHPKAOFBKFN
			{
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0x674490", Offset = "0x672A90", VA = "0x180674490")]
				get
				{
					return default(LAJDCKMGDCG.OBEBMILFKKJ);
				}
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x9251B0", Offset = "0x9237B0", VA = "0x1809251B0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float IBCPNBMHKPO
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(RVA = "0x906FB0", Offset = "0x9055B0", VA = "0x180906FB0", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x4774500", Offset = "0x4772B00", VA = "0x184774500", Slot = "24")]
			private bool EDADJLHAHDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x47744F0", Offset = "0x4772AF0", VA = "0x1847744F0", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x4774520", Offset = "0x4772B20", VA = "0x184774520")]
			public PCACOLIMFAE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private enum JBLKJCONKNJ : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private sealed class EMOAJNADMBL : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			public enum PBCLMFDNILI
			{
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			public struct IHMPKKMBHNF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public LAJDCKMGDCG.OBEBMILFKKJ FLMLGJGBBDP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public PBCLMFDNILI AIHGGCOHLMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public List<GKEMLFPCHKD> AIEEKMKENNI;
			}

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private static readonly PBCLMFDNILI[] MCNDJFCLFPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private bool INFDKKMCFPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private readonly GKEMLFPCHKD[] GNGKOLCHAMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly List<GKEMLFPCHKD> JOKNGCLPPMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly Stack<int> LEKLJADNAIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly List<GKEMLFPCHKD> BNOJBNEGHMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly Stack<int> HIIHBDMFCDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool ELEMDEHANEL;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public IHMPKKMBHNF[,] PLEANBHGLNG
			{
				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0x55A410", Offset = "0x558A10", VA = "0x18055A410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int EAJFPJEDNNA
			{
				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x476B850", Offset = "0x4769E50", VA = "0x18476B850")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x476C960", Offset = "0x476AF60", VA = "0x18476C960")]
			public EMOAJNADMBL(LAJDCKMGDCG.OBEBMILFKKJ IHPJBOJOCHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x476C870", Offset = "0x476AE70", VA = "0x18476C870")]
			public void PNIDHFDALKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x476C540", Offset = "0x476AB40", VA = "0x18476C540")]
			public void KDAAKMNOLEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x476C0F0", Offset = "0x476A6F0", VA = "0x18476C0F0")]
			private void HMKAOFLHFII(IReadOnlyList<GKEMLFPCHKD> MGBHBKGDLMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x476C220", Offset = "0x476A820", VA = "0x18476C220")]
			public void IKDNGDOGNHO(GKEMLFPCHKD FAMLNKIKMGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x476BD80", Offset = "0x476A380", VA = "0x18476BD80")]
			public void EMOAMKIMAGA(IList<GKEMLFPCHKD> GLFMMBMEEFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x476BB00", Offset = "0x476A100", VA = "0x18476BB00")]
			public void EACEFICIDJE(IList<GKEMLFPCHKD> GLFMMBMEEFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x476C000", Offset = "0x476A600", VA = "0x18476C000")]
			private void ENIGBEEIJJM(GKEMLFPCHKD FAMLNKIKMGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x476B500", Offset = "0x4769B00", VA = "0x18476B500")]
			private void BLHMPHCMPJE(IList<GKEMLFPCHKD> GLFMMBMEEFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x476C600", Offset = "0x476AC00", VA = "0x18476C600")]
			private JBLKJCONKNJ OHIKEDHGLOM(GKEMLFPCHKD FAMLNKIKMGG)
			{
				return default(JBLKJCONKNJ);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x476C550", Offset = "0x476AB50", VA = "0x18476C550")]
			public void LHCLGJALOHN(float MEJKCNGGGKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x476C340", Offset = "0x476A940", VA = "0x18476C340")]
			public void KCKMPCMADAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x476B670", Offset = "0x4769C70", VA = "0x18476B670")]
			private void BNEBONJLCPA(List<GKEMLFPCHKD> GLFMMBMEEFN, Stack<int> CFFGGDPIPIG, bool EPDECABNAPG, float LBKJADCEKNN = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x476B9C0", Offset = "0x4769FC0", VA = "0x18476B9C0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x476C750", Offset = "0x476AD50", VA = "0x18476C750")]
			private void PAOBICOJFJN(List<GKEMLFPCHKD> GLFMMBMEEFN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[Flags]
		public enum HHGEAHJKBGH : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			Inactive = 0,
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			Running = 1,
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			Cancelled = 2,
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			Paused = 4
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class FAEMHONJKMA : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
			[DebuggerHidden]
			public FAEMHONJKMA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x476CDB0", Offset = "0x476B3B0", VA = "0x18476CDB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x476CE30", Offset = "0x476B430", VA = "0x18476CE30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private const HHGEAHJKBGH CDFNOCBGEAL = HHGEAHJKBGH.Cancelled | HHGEAHJKBGH.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly LAJDCKMGDCG.OBEBMILFKKJ[] LKBECBFNLJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private EMOAJNADMBL[] CPCAHJAOGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private EBJLNAFHPGM[] KPHFJGJGFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Coroutine GJBMLCMHALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private WaitForEndOfFrame NPADDFLPLLO;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public LAJDCKMGDCG.OBEBMILFKKJ DDFMGFOBNLP
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x535300", Offset = "0x533900", VA = "0x180535300")]
			[CompilerGenerated]
			get
			{
				return default(LAJDCKMGDCG.OBEBMILFKKJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x58E110", Offset = "0x58C710", VA = "0x18058E110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GJHJIPGLHDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x742FA0", Offset = "0x7415A0", VA = "0x180742FA0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x742E00", Offset = "0x741400", VA = "0x180742E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int EAJFPJEDNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4777720", Offset = "0x4775D20", VA = "0x184777720")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4776520", Offset = "0x4774B20", VA = "0x184776520")]
		public static NIKIHPIPFGJ GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4775E30", Offset = "0x4774430", VA = "0x184775E30", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4776650", Offset = "0x4774C50", VA = "0x184776650", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4775DF0", Offset = "0x47743F0", VA = "0x184775DF0")]
		private EMOAJNADMBL ADNALNJDKKG(LAJDCKMGDCG.OBEBMILFKKJ FFNKIDPAEGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1249780", Offset = "0x1247D80", VA = "0x181249780")]
		private EBJLNAFHPGM POAFEDNCIDJ(LAJDCKMGDCG.OBEBMILFKKJ FFNKIDPAEGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4776B10", Offset = "0x4775110", VA = "0x184776B10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4776AD0", Offset = "0x47750D0", VA = "0x184776AD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x47774F0", Offset = "0x4775AF0", VA = "0x1847774F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x47764F0", Offset = "0x4774AF0", VA = "0x1847764F0")]
		private void FOPGKDFLEOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4776500", Offset = "0x4774B00", VA = "0x184776500")]
		private void FOPIMNPBNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4776510", Offset = "0x4774B10", VA = "0x184776510")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x4776630", Offset = "0x4774C30", VA = "0x184776630")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x4776640", Offset = "0x4774C40", VA = "0x184776640")]
		private void NKBLLINOEMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x47765C0", Offset = "0x4774BC0", VA = "0x1847765C0")]
		[IteratorStateMachine(typeof(FAEMHONJKMA))]
		private IEnumerator IJAEGMFOEDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4776DE0", Offset = "0x47753E0", VA = "0x184776DE0", Slot = "7")]
		public NIKIHPIPFGJ Run(IEnumerator<MNMANPNLMCB> IIHPGCLPKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4776DF0", Offset = "0x47753F0", VA = "0x184776DF0", Slot = "8")]
		public NIKIHPIPFGJ Run(Behaviour FBKBDIMBGGH, IEnumerator<MNMANPNLMCB> IIHPGCLPKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4776CB0", Offset = "0x47752B0", VA = "0x184776CB0", Slot = "9")]
		public NIKIHPIPFGJ RunJobbed(HNHDBGKAENI FBKBDIMBGGH, IEnumerator<MNMANPNLMCB> IIHPGCLPKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4776490", Offset = "0x4774A90", VA = "0x184776490", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4777020", Offset = "0x4775620", VA = "0x184777020")]
		public void UpdateQueue(LAJDCKMGDCG.OBEBMILFKKJ NPFOPFJFLDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x47762D0", Offset = "0x47748D0", VA = "0x1847762D0")]
		private void BCOHNBMMHDE(EMOAJNADMBL JCMAAKCBKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x4776B90", Offset = "0x4775190", VA = "0x184776B90")]
		private void PHGFOHFPDND(EBJLNAFHPGM JCMAAKCBKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x47776B0", Offset = "0x4775CB0", VA = "0x1847776B0")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class IKMIHOKKIFA
{
	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4770210", Offset = "0x476E810", VA = "0x184770210")]
	[DOKCMCFCJJB]
	private static void BAAHEFDHEPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class DAHOJAANPNC : FBCJAPFJCLA
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float HCEJFIHMFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4768620", Offset = "0x4766C20", VA = "0x184768620", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float MHGOLOGBIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4768630", Offset = "0x4766C30", VA = "0x184768630", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float DPECDCPFGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4768640", Offset = "0x4766C40", VA = "0x184768640", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int GAPPDKECNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x4768650", Offset = "0x4766C50", VA = "0x184768650", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double MELCFPPCJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4768660", Offset = "0x4766C60", VA = "0x184768660", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
	public DAHOJAANPNC()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class KKINEKHOKMG
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] DOJNIBDEPHD;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int KFPMCEOFNHF;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int FPHJGLDCBHD;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger HMCNEAFPECA;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
	public KKINEKHOKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x47722A0", Offset = "0x47708A0", VA = "0x1847722A0")]
	private static string IOLHAJOLOLL(byte[] CGENIFKMPBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4771F70", Offset = "0x4770570", VA = "0x184771F70")]
	public static string FFHDEGOGLMA(byte[] LDGCJAPEANM, bool ONIHJAEONNB)
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

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
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

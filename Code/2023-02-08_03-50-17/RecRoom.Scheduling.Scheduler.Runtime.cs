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
public class PNCODGJILMK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority KMHOHPBMDPP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x594B260", Offset = "0x594A060", VA = "0x18594B260")]
	public PNCODGJILMK(ThreadPriority BIOJBMNOIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x594B250", Offset = "0x594A050", VA = "0x18594B250", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> NAJEMDAPFFL(List<PlayerLoopSystem> LHNNPMPCLEE, int AMHNOBMFFCJ);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct EGCDPFFLDDN
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct HFGIEHIPBBJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static EEDHONDEDDI NBMJFCBMKGJ;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x593E260", Offset = "0x593D060", VA = "0x18593E260")]
				public static PlayerLoopSystem PFGMLCLHDBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct OHCLGBDJMFK
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static EEDHONDEDDI EGPPPIMNCLG;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x5949BE0", Offset = "0x59489E0", VA = "0x185949BE0")]
				public static PlayerLoopSystem PFGMLCLHDBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct BGCKPIIMCLH
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static EEDHONDEDDI ECKAOPPGFBJ;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x5934E80", Offset = "0x5933C80", VA = "0x185934E80")]
				public static PlayerLoopSystem PFGMLCLHDBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct LGEHMABJGEE
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static EEDHONDEDDI BMHHMNILNKO;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static EEDHONDEDDI IHFIFMGDNDK;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static EEDHONDEDDI HEGMIAMPGJB;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static EEDHONDEDDI ILBHKBABNOD;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x5944D80", Offset = "0x5943B80", VA = "0x185944D80")]
				public static PlayerLoopSystem PFGMLCLHDBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct GAJLOFNPMJO
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static EEDHONDEDDI DALNJGNHAJB;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x593CF70", Offset = "0x593BD70", VA = "0x18593CF70")]
				public static PlayerLoopSystem PFGMLCLHDBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct CBLDEBENKMO
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static EEDHONDEDDI BMHHMNILNKO;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static EEDHONDEDDI IHFIFMGDNDK;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static EEDHONDEDDI HEGMIAMPGJB;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static EEDHONDEDDI ILBHKBABNOD;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x5935190", Offset = "0x5933F90", VA = "0x185935190")]
				public static PlayerLoopSystem PFGMLCLHDBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct FOIJEJCACNM
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static EEDHONDEDDI IOJMHAAELEB;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x593CD90", Offset = "0x593BB90", VA = "0x18593CD90")]
				public static PlayerLoopSystem PFGMLCLHDBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct HNDLKHOHGEE
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static EEDHONDEDDI DIDCNPDKOJD;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x593F310", Offset = "0x593E110", VA = "0x18593F310")]
				public static PlayerLoopSystem PFGMLCLHDBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct OFPNLABKKBK
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static EEDHONDEDDI BKKHBNDMCIN;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x5949A00", Offset = "0x5948800", VA = "0x185949A00")]
				public static PlayerLoopSystem PFGMLCLHDBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct HJDMAKPLOPF
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static EEDHONDEDDI OLENPJMJPBK;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x593E440", Offset = "0x593D240", VA = "0x18593E440")]
				public static PlayerLoopSystem PFGMLCLHDBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct MNPHKNHMGFD
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static EEDHONDEDDI ALDINBHONKP;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x5945F70", Offset = "0x5944D70", VA = "0x185945F70")]
				public static PlayerLoopSystem PFGMLCLHDBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			internal struct MFLKJLBIJHP
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				[CompilerGenerated]
				private sealed class CPBCMNIFIOF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002B")]
					public OFMELPPEKLI.HMHEMIMCHLC key;

					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
					public CPBCMNIFIOF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x5937130", Offset = "0x5935F30", VA = "0x185937130")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable FCNBEKMKDNH;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5945E00", Offset = "0x5944C00", VA = "0x185945E00")]
				public static PlayerLoopSystem PCNFJDLGKFH(OFMELPPEKLI.HMHEMIMCHLC CKMEBFKEHMO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct AIFNGFGNANM
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class MDKMAKNAMOD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002E")]
					public OFMELPPEKLI.HMHEMIMCHLC key;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
					public MDKMAKNAMOD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x5945B70", Offset = "0x5944970", VA = "0x185945B70")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x5933C10", Offset = "0x5932A10", VA = "0x185933C10")]
				public static PlayerLoopSystem PCNFJDLGKFH(OFMELPPEKLI.HMHEMIMCHLC CKMEBFKEHMO)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class LOFMNJMMMLF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public LOFMNJMMMLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5945330", Offset = "0x5944130", VA = "0x185945330")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool HKHALPGKONO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool LOLEFEFAPPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5939670", Offset = "0x5938470", VA = "0x185939670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x59373A0", Offset = "0x59361A0", VA = "0x1859373A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5937610", Offset = "0x5936410", VA = "0x185937610")]
		private static void BPAGDHGJBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5939BD0", Offset = "0x59389D0", VA = "0x185939BD0")]
		private static void MGKHOANJNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x593A4A0", Offset = "0x59392A0", VA = "0x18593A4A0")]
		private static void OAGGBOAJGNI(string PEDPPAJFIBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x59373E0", Offset = "0x59361E0", VA = "0x1859373E0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x59394B0", Offset = "0x59382B0", VA = "0x1859394B0")]
		private static void DGNFBLIJEJH(OFMELPPEKLI.HMHEMIMCHLC CKMEBFKEHMO, ref PlayerLoopSystem GBJFJDBHJPJ, Type FHAABPMBBJP, Type HAKLBGNHAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x59396B0", Offset = "0x59384B0", VA = "0x1859396B0")]
		private static void INIBAHLKACA(ref PlayerLoopSystem GBJFJDBHJPJ, Type FHAABPMBBJP, Type HAKLBGNHAFH, NAJEMDAPFFL ICLEOLEMOOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5939AA0", Offset = "0x59388A0", VA = "0x185939AA0")]
		private static void KLCOFOCHPEJ(ref PlayerLoopSystem GBJFJDBHJPJ, Type FHAABPMBBJP, Type HAKLBGNHAFH, PlayerLoopSystem? BDOLJCLDCKE, PlayerLoopSystem? OLHOPBNPIDJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class OFMELPPEKLI
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum HMHEMIMCHLC
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
	public class GALCBNICEFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly HMHEMIMCHLC AJIKPPGELDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly EBBDPEIGAOG IODDDJMHECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private long NLAOCFOCLMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private long MFKLDKHJNGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long EFENGGLJBEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int MGLFEPEBMMF;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x593D420", Offset = "0x593C220", VA = "0x18593D420")]
		public GALCBNICEFH(HMHEMIMCHLC CKHJMHCHGMP, int NFGADDMEEIO = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x593D3B0", Offset = "0x593C1B0", VA = "0x18593D3B0")]
		public void HDCJNCFEDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x593D150", Offset = "0x593BF50", VA = "0x18593D150")]
		public void EKBBBPGFEHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x593D1B0", Offset = "0x593BFB0", VA = "0x18593D1B0")]
		public void FHHPDLELJLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static HMHEMIMCHLC[] OMNFDEIBKBO;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static GALCBNICEFH[] DBKGBFCOGJM;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5949590", Offset = "0x5948390", VA = "0x185949590")]
	public static GALCBNICEFH AGPDDJANPHM(HMHEMIMCHLC CKMEBFKEHMO, int NFGADDMEEIO = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5949760", Offset = "0x5948560", VA = "0x185949760")]
	public static GALCBNICEFH IMEFFHMNMKO(HMHEMIMCHLC CKMEBFKEHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x59497F0", Offset = "0x59485F0", VA = "0x1859497F0")]
	public static void LMJNEOPBGHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class EBBDPEIGAOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int NOEDLJPHFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Queue<double> JEIHOGCOBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private double CDJGLGILJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private double KIDJEKPKJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private double JBNLIODKLLC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double DPHIMCDLFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x593B990", Offset = "0x593A790", VA = "0x18593B990", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x593BB90", Offset = "0x593A990", VA = "0x18593BB90")]
	public EBBDPEIGAOG(int MAEOLONMLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x593B9F0", Offset = "0x593A7F0", VA = "0x18593B9F0", Slot = "4")]
	public void EJJMLKHDNCN(double OAFEANCCICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x593BB20", Offset = "0x593A920", VA = "0x18593BB20", Slot = "5")]
	public void FLOLCMPEDIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HLEOFPMDALJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private long KNPCAAMBLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private double JBKANAFEKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private double DFNMNHBEOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private double MKJEDBAOGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private double CJBCCAGMCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private double CDJGLGILJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private double KIDJEKPKJJM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double FFNHKCOIBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xBCC230", Offset = "0xBCB030", VA = "0x180BCC230", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double DGJBMFOFJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xBCC2B0", Offset = "0xBCB0B0", VA = "0x180BCC2B0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double EHGONLKPAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA822A0", Offset = "0xA810A0", VA = "0x180A822A0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double DPHIMCDLFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xBCC150", Offset = "0xBCAF50", VA = "0x180BCC150", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x593E650", Offset = "0x593D450", VA = "0x18593E650", Slot = "7")]
	public void EJJMLKHDNCN(double OAFEANCCICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x593E780", Offset = "0x593D580", VA = "0x18593E780", Slot = "8")]
	public void FLOLCMPEDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x593E7C0", Offset = "0x593D5C0", VA = "0x18593E7C0")]
	public HLEOFPMDALJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class BBBPAHHNFOE
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private interface DJFKHJHBGJF
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool BEFOHNLCENE
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LAJHMBEEEDJ();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private abstract class EHCPBEJDHFC<TPromise, TMainThreadPromise> : DJFKHJHBGJF where TPromise : FFFHIGBANBM where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly TPromise IFKBJIEDCJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected readonly TMainThreadPromise LGANCNGDIOB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise AIEOAINDGEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x36D1C50", Offset = "0x36D0A50", VA = "0x1836D1C50")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BEFOHNLCENE
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x36D1CB0", Offset = "0x36D0AB0", VA = "0x1836D1CB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x35C0940", Offset = "0x35BF740", VA = "0x1835C0940")]
		protected EHCPBEJDHFC(TPromise IFKBJIEDCJC, TMainThreadPromise GFLEHKPMPGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x36D1D00", Offset = "0x36D0B00", VA = "0x1836D1D00", Slot = "5")]
		public void LAJHMBEEEDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void HBNFJNBPKIK(TPromise IFKBJIEDCJC);
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private class HFEKCHIGNGO<T> : EHCPBEJDHFC<global::KOILDJEEFJD<T>, global::NBNDPFFHLHN<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x40EF220", Offset = "0x40EE020", VA = "0x1840EF220")]
		public HFEKCHIGNGO(global::KOILDJEEFJD<T> IFKBJIEDCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x40EF070", Offset = "0x40EDE70", VA = "0x1840EF070", Slot = "6")]
		protected override void HBNFJNBPKIK(global::KOILDJEEFJD<T> IFKBJIEDCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x40EF040", Offset = "0x40EDE40", VA = "0x1840EF040")]
		[CompilerGenerated]
		private void EIFGFCEJLIE(T LILKGIPDCFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x22E9080", Offset = "0x22E7E80", VA = "0x1822E9080")]
		[CompilerGenerated]
		private void BPDLEAGGNAF(string KDIFPAMDOPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class BLHEIEMCBMB : DJFKHJHBGJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly Action CIAILAMJPDB;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BEFOHNLCENE
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6C8080", Offset = "0x6C6E80", VA = "0x1806C8080", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA10", Offset = "0x8AE810", VA = "0x1808AFA10")]
		public BLHEIEMCBMB(Action CIAILAMJPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x90E690", Offset = "0x90D490", VA = "0x18090E690", Slot = "5")]
		public void LAJHMBEEEDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<DJFKHJHBGJF> MCOGFOHIGBH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x332CFB0", Offset = "0x332BDB0", VA = "0x18332CFB0")]
	public static global::KOILDJEEFJD<T> PKEPBFPIDFL<T>(this global::KOILDJEEFJD<T> IFKBJIEDCJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5934D40", Offset = "0x5933B40", VA = "0x185934D40")]
	public static void PKEPBFPIDFL(Action CIAILAMJPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x332CEF0", Offset = "0x332BCF0", VA = "0x18332CEF0")]
	private static global::KOILDJEEFJD<T> JHMMCNCDNKG<T>(global::KOILDJEEFJD<T> IFKBJIEDCJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5934750", Offset = "0x5933550", VA = "0x185934750")]
	private static void FHBJKEPAINF(DJFKHJHBGJF LMDMPJMFGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5934A50", Offset = "0x5933850", VA = "0x185934A50")]
	private static void JNHLKMNMNJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5934950", Offset = "0x5933750", VA = "0x185934950")]
	private static void HLGAIAHIGDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5934680", Offset = "0x5933480", VA = "0x185934680")]
	private static void CJHGDAEKIBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class ONMFFPAGGLC
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private struct IFNJPFDCMFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public TaskCompletionSource<Scene> JFFEOOODHOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly string ILGLKJPMBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly LoadSceneMode DOGBDPEEDJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool PODAFGJJOJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly LDNBHEGFOMH FONHNFMDGGB;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x593F7F0", Offset = "0x593E5F0", VA = "0x18593F7F0")]
		public IFNJPFDCMFI(TaskCompletionSource<Scene> MMKGHENBCEH, string ILGLKJPMBJF, LoadSceneMode DOGBDPEEDJD, bool PODAFGJJOJJ, LDNBHEGFOMH FONHNFMDGGB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct OBOAPKPKCDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LDNBHEGFOMH stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private global::GFFHDAJEBGF<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5947640", Offset = "0x5946440", VA = "0x185947640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5947CB0", Offset = "0x5946AB0", VA = "0x185947CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct HPOLKBMDHOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x593F4F0", Offset = "0x593E2F0", VA = "0x18593F4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA73C20", Offset = "0xA72A20", VA = "0x180A73C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct ILFAOKHDCBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private IFNJPFDCMFI <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x593F850", Offset = "0x593E650", VA = "0x18593F850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA73C20", Offset = "0xA72A20", VA = "0x180A73C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class HBDFHHLJLBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public global::NBNDPFFHLHN<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public HBDFHHLJLBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x593E1C0", Offset = "0x593CFC0", VA = "0x18593E1C0")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NJDHMNFELBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public LDNBHEGFOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private HBDFHHLJLBP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private LDNBHEGFOMH <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private LDNBHEGFOMH <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5946620", Offset = "0x5945420", VA = "0x185946620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5946FA0", Offset = "0x5945DA0", VA = "0x185946FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct JJEMCOBHOGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public LDNBHEGFOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private LDNBHEGFOMH <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private LDNBHEGFOMH <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x593FE90", Offset = "0x593EC90", VA = "0x18593FE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x59406D0", Offset = "0x593F4D0", VA = "0x1859406D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class BDDBFGDPMHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public BDDBFGDPMHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5934E50", Offset = "0x5933C50", VA = "0x185934E50")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class NGDFGGEPNHP : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private KDNIAKIKLPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public HNONHEFEGPD onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
		[DebuggerHidden]
		public NGDFGGEPNHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5946540", Offset = "0x5945340", VA = "0x185946540", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x59461E0", Offset = "0x5944FE0", VA = "0x1859461E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x59465D0", Offset = "0x59453D0", VA = "0x1859465D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5946500", Offset = "0x5945300", VA = "0x185946500", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class FMDMCGPJAGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public global::NBNDPFFHLHN<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public FMDMCGPJAGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class ANNDHEOFJKF : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private KDNIAKIKLPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public global::NBNDPFFHLHN<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private FMDMCGPJAGC <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
		[DebuggerHidden]
		public ANNDHEOFJKF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x59341F0", Offset = "0x5932FF0", VA = "0x1859341F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5934640", Offset = "0x5933440", VA = "0x185934640", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static FFFHIGBANBM OONMAHGNCHH;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static AsyncOperation IEENMGICCDO;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static FFFHIGBANBM HAGLAGNCDPB;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static string HELGLHEBFEO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ThreadPriority KNFIKELBGNM;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Task FFOGMBODIFN;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Queue<IFNJPFDCMFI> JDKEOLGDMKE;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Task HEPHPGFIOIG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool DCINJAAINDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x594A2C0", Offset = "0x59490C0", VA = "0x18594A2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool OGMOEOMHLEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x594AE70", Offset = "0x5949C70", VA = "0x18594AE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool MPDFKJOOLFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x594AAF0", Offset = "0x59498F0", VA = "0x18594AAF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> JEDCIBEGFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x594AC80", Offset = "0x5949A80", VA = "0x18594AC80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5949F20", Offset = "0x5948D20", VA = "0x185949F20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x594ABB0", Offset = "0x59499B0", VA = "0x18594ABB0")]
	[PHHAPANKJKM(AJLNLJAJGIO.EnteredEditModeNextFrame, 0)]
	private static void IJACEDIGDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5949DC0", Offset = "0x5948BC0", VA = "0x185949DC0")]
	[AsyncStateMachine(typeof(OBOAPKPKCDC))]
	public static Task<Scene> AEAHECGHKAC(string ILGLKJPMBJF, LoadSceneMode DOGBDPEEDJD = LoadSceneMode.Single, bool PODAFGJJOJJ = false, [Optional] LDNBHEGFOMH HCDDLMLKAJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x594AFC0", Offset = "0x5949DC0", VA = "0x18594AFC0")]
	[AsyncStateMachine(typeof(HPOLKBMDHOH))]
	private static Task PNFHJPNPPEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x594AD80", Offset = "0x5949B80", VA = "0x18594AD80")]
	[AsyncStateMachine(typeof(ILFAOKHDCBM))]
	private static Task MMOJFPJBBPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x594A160", Offset = "0x5948F60", VA = "0x18594A160")]
	[AsyncStateMachine(typeof(NJDHMNFELBP))]
	private static Task<Scene> GAFKBNPPCDM(string ILGLKJPMBJF, LoadSceneMode DOGBDPEEDJD, bool PODAFGJJOJJ, LDNBHEGFOMH FONHNFMDGGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x594A020", Offset = "0x5948E20", VA = "0x18594A020")]
	[AsyncStateMachine(typeof(JJEMCOBHOGN))]
	private static Task<Scene> EEECNLLDNOG(LDNBHEGFOMH FONHNFMDGGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x594A950", Offset = "0x5949750", VA = "0x18594A950")]
	public static global::KOILDJEEFJD<Scene> HFALGICPEMH(string ILGLKJPMBJF, LoadSceneMode DOGBDPEEDJD = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x594A510", Offset = "0x5949310", VA = "0x18594A510")]
	public static FFFHIGBANBM GPHMHFIAHBI(string ILGLKJPMBJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x594A480", Offset = "0x5949280", VA = "0x18594A480")]
	[IteratorStateMachine(typeof(NGDFGGEPNHP))]
	private static IEnumerator<KDNIAKIKLPJ> GHGEJEJLPAO(string ILGLKJPMBJF, HNONHEFEGPD LJIDLGNDFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x594AF20", Offset = "0x5949D20", VA = "0x18594AF20")]
	[IteratorStateMachine(typeof(ANNDHEOFJKF))]
	private static IEnumerator<KDNIAKIKLPJ> OPKEJJODPMO(string ILGLKJPMBJF, LoadSceneMode DOGBDPEEDJD, global::NBNDPFFHLHN<Scene> LJIDLGNDFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x594A7F0", Offset = "0x59495F0", VA = "0x18594A7F0")]
	public static bool HCLPMJBPNJL(out string CMNFKKLKCCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GHNEPPAFKAC
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x593DFB0", Offset = "0x593CDB0", VA = "0x18593DFB0")]
	public static IDisposable DONKBAHJFMA(this JDCOGGPNAAC IEGGGFEMEIG, float LFDLPHEMJOH, Action<float> JCMJBHPHNGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x593DF30", Offset = "0x593CD30", VA = "0x18593DF30")]
	public static IDisposable DILOABMGPLK(this JDCOGGPNAAC IEGGGFEMEIG, Action<float> JCMJBHPHNGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x593E030", Offset = "0x593CE30", VA = "0x18593E030")]
	public static IDisposable FOMIGEGCDLC(this JDCOGGPNAAC IEGGGFEMEIG, Action<float> JCMJBHPHNGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class GHFFPDCEOKI
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x593D5E0", Offset = "0x593C3E0", VA = "0x18593D5E0")]
	public static IDisposable CBLFJHALAEG(this MonoBehaviour CIAKDOCBOKB, Action JCMJBHPHNGA, MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x593D560", Offset = "0x593C360", VA = "0x18593D560")]
	public static IDisposable CBLFJHALAEG(this MonoBehaviour CIAKDOCBOKB, Action<float> JCMJBHPHNGA, MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x593DB70", Offset = "0x593C970", VA = "0x18593DB70")]
	public static IDisposable KMEGEMCDFBL(this MonoBehaviour CIAKDOCBOKB, Action JCMJBHPHNGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x593DEB0", Offset = "0x593CCB0", VA = "0x18593DEB0")]
	public static IDisposable POAAEFMFHGJ(this MonoBehaviour CIAKDOCBOKB, Action JCMJBHPHNGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x593DAF0", Offset = "0x593C8F0", VA = "0x18593DAF0")]
	public static IDisposable GMLIAEJOGGP(this MonoBehaviour CIAKDOCBOKB, Action JCMJBHPHNGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x593DD00", Offset = "0x593CB00", VA = "0x18593DD00")]
	public static IDisposable MAAJOEGOKHC(this MonoBehaviour CIAKDOCBOKB, Action JCMJBHPHNGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x593D660", Offset = "0x593C460", VA = "0x18593D660")]
	public static IDisposable CCEJPEDFOJM(this MonoBehaviour CIAKDOCBOKB, Action JCMJBHPHNGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x593D930", Offset = "0x593C730", VA = "0x18593D930")]
	public static IDisposable FDKOEEMCKCK(this MonoBehaviour CIAKDOCBOKB, float LFDLPHEMJOH, Action<float> JCMJBHPHNGA, MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK, bool CNBOAFLBMPD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x593DD80", Offset = "0x593CB80", VA = "0x18593DD80")]
	public static IDisposable NCMKKFGDMKN(this MonoBehaviour CIAKDOCBOKB, float LFDLPHEMJOH, Action<float> JCMJBHPHNGA, bool CNBOAFLBMPD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x593DBE0", Offset = "0x593C9E0", VA = "0x18593DBE0")]
	public static IDisposable KMFMONLJGDL(this MonoBehaviour CIAKDOCBOKB, Action<float> JCMJBHPHNGA, bool CNBOAFLBMPD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x593D780", Offset = "0x593C580", VA = "0x18593D780")]
	public static IDisposable DDMBKIPLBEL(this MonoBehaviour CIAKDOCBOKB, Action<float> JCMJBHPHNGA, bool CNBOAFLBMPD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x593D8A0", Offset = "0x593C6A0", VA = "0x18593D8A0")]
	public static IDisposable ENHFOIEBIJF(this MonoBehaviour CIAKDOCBOKB, Action<float> JCMJBHPHNGA, bool CNBOAFLBMPD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x593D810", Offset = "0x593C610", VA = "0x18593D810")]
	public static IDisposable EIHFKOHFIPH(this MonoBehaviour CIAKDOCBOKB, Action<float> JCMJBHPHNGA, bool CNBOAFLBMPD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x593D9D0", Offset = "0x593C7D0", VA = "0x18593D9D0")]
	public static IDisposable FLFIGPKBKOF(this MonoBehaviour CIAKDOCBOKB, Action<float> JCMJBHPHNGA, bool CNBOAFLBMPD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x593DE20", Offset = "0x593CC20", VA = "0x18593DE20")]
	public static IDisposable OJDGKKAFPFG(this MonoBehaviour CIAKDOCBOKB, Action<float> JCMJBHPHNGA, bool CNBOAFLBMPD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x593DA60", Offset = "0x593C860", VA = "0x18593DA60")]
	public static IDisposable GFOKAIEJLLF(this MonoBehaviour CIAKDOCBOKB, Action<float> JCMJBHPHNGA, bool CNBOAFLBMPD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x593D6E0", Offset = "0x593C4E0", VA = "0x18593D6E0")]
	public static IDisposable CHMKFECFBEF(this MonoBehaviour CIAKDOCBOKB, float LFDLPHEMJOH, Action<float> JCMJBHPHNGA, bool CNBOAFLBMPD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x593DC70", Offset = "0x593CA70", VA = "0x18593DC70")]
	public static IDisposable KNHKGGGJNDF(this MonoBehaviour CIAKDOCBOKB, Action<float> JCMJBHPHNGA, bool CNBOAFLBMPD = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CLDGHHMKFJM
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class ILNNPBCNKGD : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private KDNIAKIKLPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public MKNJAMNBNFB.CBGOGPCLFKM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private JMHDGMKJKHF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
		[DebuggerHidden]
		public ILNNPBCNKGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x593FBE0", Offset = "0x593E9E0", VA = "0x18593FBE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x593FCA0", Offset = "0x593EAA0", VA = "0x18593FCA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class BNGAALOKMME : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private KDNIAKIKLPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public MKNJAMNBNFB.CBGOGPCLFKM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private JMHDGMKJKHF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
		[DebuggerHidden]
		public BNGAALOKMME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5935060", Offset = "0x5933E60", VA = "0x185935060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5935150", Offset = "0x5933F50", VA = "0x185935150", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x59365D0", Offset = "0x59353D0", VA = "0x1859365D0")]
	public static HDOELFFLJBF CBLFJHALAEG(Action JCMJBHPHNGA, MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5936790", Offset = "0x5935590", VA = "0x185936790")]
	public static HDOELFFLJBF CBLFJHALAEG(Behaviour IEGGGFEMEIG, Action JCMJBHPHNGA, MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5936680", Offset = "0x5935480", VA = "0x185936680")]
	public static HDOELFFLJBF CBLFJHALAEG(Behaviour IEGGGFEMEIG, Action<float> JCMJBHPHNGA, MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5936850", Offset = "0x5935650", VA = "0x185936850")]
	[IteratorStateMachine(typeof(ILNNPBCNKGD))]
	private static IEnumerator<KDNIAKIKLPJ> GHMEAOJCPFI(MKNJAMNBNFB.CBGOGPCLFKM OGKLNJLJJHC, Action JCMJBHPHNGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x59368D0", Offset = "0x59356D0", VA = "0x1859368D0")]
	[IteratorStateMachine(typeof(BNGAALOKMME))]
	private static IEnumerator<KDNIAKIKLPJ> GHMEAOJCPFI(MKNJAMNBNFB.CBGOGPCLFKM OGKLNJLJJHC, Action<float> JCMJBHPHNGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class JMDCADAEIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class DKJKBPAABPJ : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private KDNIAKIKLPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public JPHGDKKIPML schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public MKNJAMNBNFB.CBGOGPCLFKM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private GHIMKDCMICM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
		[DebuggerHidden]
		public DKJKBPAABPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x593A7D0", Offset = "0x59395D0", VA = "0x18593A7D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x593A910", Offset = "0x5939710", VA = "0x18593A910", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5941870", Offset = "0x5940670", VA = "0x185941870")]
	public static HDOELFFLJBF CBLFJHALAEG(float LFDLPHEMJOH, Action<float> JCMJBHPHNGA, MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK, bool CNBOAFLBMPD = true, [Optional] PPHLHEPALAJ PALJEBCKPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5941760", Offset = "0x5940560", VA = "0x185941760")]
	public static HDOELFFLJBF CBLFJHALAEG(MonoBehaviour CIAKDOCBOKB, float LFDLPHEMJOH, Action<float> JCMJBHPHNGA, MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK, bool CNBOAFLBMPD = true, [Optional] PPHLHEPALAJ PALJEBCKPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5941A20", Offset = "0x5940820", VA = "0x185941A20")]
	public static HDOELFFLJBF JCKJNEOEIBE(JDCOGGPNAAC IEGGGFEMEIG, float LFDLPHEMJOH, Action<float> JCMJBHPHNGA, MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK, bool CNBOAFLBMPD = true, [Optional] PPHLHEPALAJ PALJEBCKPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5941970", Offset = "0x5940770", VA = "0x185941970")]
	[IteratorStateMachine(typeof(DKJKBPAABPJ))]
	private static IEnumerator<KDNIAKIKLPJ> GHMEAOJCPFI(JPHGDKKIPML OIHCNNEKHJN, float LFDLPHEMJOH, MKNJAMNBNFB.CBGOGPCLFKM OGKLNJLJJHC, Action<float> JCMJBHPHNGA, bool CNBOAFLBMPD = true, [Optional] PPHLHEPALAJ PALJEBCKPNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class LJMBIKGGBNF
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class KCFNGEDCKIF : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private KDNIAKIKLPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public MKNJAMNBNFB.CBGOGPCLFKM queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
		[DebuggerHidden]
		public KCFNGEDCKIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5941E30", Offset = "0x5940C30", VA = "0x185941E30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5941EE0", Offset = "0x5940CE0", VA = "0x185941EE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x59451D0", Offset = "0x5943FD0", VA = "0x1859451D0")]
	[IteratorStateMachine(typeof(KCFNGEDCKIF))]
	private static IEnumerator<KDNIAKIKLPJ> MICCPBCNMKG(MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK, Func<bool> IDFFICGGMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x59450C0", Offset = "0x5943EC0", VA = "0x1859450C0")]
	public static HDOELFFLJBF ANGINDGFMGK(this MonoBehaviour CIAKDOCBOKB, Func<bool> IDFFICGGMDC, MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK = MKNJAMNBNFB.CBGOGPCLFKM.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class LPGNGFOBEMI
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class PMKOOGMEHOI : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private KDNIAKIKLPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public MKNJAMNBNFB.CBGOGPCLFKM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
		[DebuggerHidden]
		public PMKOOGMEHOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x594B150", Offset = "0x5949F50", VA = "0x18594B150", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x594B210", Offset = "0x594A010", VA = "0x18594B210", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5945450", Offset = "0x5944250", VA = "0x185945450")]
	[IteratorStateMachine(typeof(PMKOOGMEHOI))]
	private static IEnumerator<KDNIAKIKLPJ> AHBNIAKGKFH(float JNFELLBIBAM, MKNJAMNBNFB.CBGOGPCLFKM OGKLNJLJJHC, Action NICNKBALKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x59459B0", Offset = "0x59447B0", VA = "0x1859459B0")]
	public static HDOELFFLJBF MCFEIMMMBEK(this MonoBehaviour CIAKDOCBOKB, float JNFELLBIBAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x59456C0", Offset = "0x59444C0", VA = "0x1859456C0")]
	public static HDOELFFLJBF GDHDPCAKLCB(this MonoBehaviour CIAKDOCBOKB, Action NICNKBALKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5945710", Offset = "0x5944510", VA = "0x185945710")]
	public static HDOELFFLJBF JCNBLPLGODF(this MonoBehaviour CIAKDOCBOKB, Action NICNKBALKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x59455E0", Offset = "0x59443E0", VA = "0x1859455E0")]
	public static HDOELFFLJBF GAHLOCBBOPC(this MonoBehaviour CIAKDOCBOKB, Action NICNKBALKJN, [Optional] PPHLHEPALAJ PALJEBCKPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x59454E0", Offset = "0x59442E0", VA = "0x1859454E0")]
	public static HDOELFFLJBF AOKNDDAFGEF(this MonoBehaviour CIAKDOCBOKB, Action NICNKBALKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x59456E0", Offset = "0x59444E0", VA = "0x1859456E0")]
	public static HDOELFFLJBF JCCOBIEGJEA(this MonoBehaviour CIAKDOCBOKB, Action NICNKBALKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5945A70", Offset = "0x5944870", VA = "0x185945A70")]
	public static HDOELFFLJBF NKBIDGLHGNG(this MonoBehaviour CIAKDOCBOKB, Action NICNKBALKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x59458E0", Offset = "0x59446E0", VA = "0x1859458E0")]
	private static HDOELFFLJBF LEJPKLHJJMD(MonoBehaviour CIAKDOCBOKB, MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK, Action NICNKBALKJN, [Optional] PPHLHEPALAJ PALJEBCKPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5945510", Offset = "0x5944310", VA = "0x185945510")]
	public static HDOELFFLJBF CEFDCKFLCLF(this MonoBehaviour CIAKDOCBOKB, float EMEHBHHBBME, Action NICNKBALKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5945AA0", Offset = "0x59448A0", VA = "0x185945AA0")]
	public static HDOELFFLJBF OBNNBLPNLKA(this MonoBehaviour CIAKDOCBOKB, float EMEHBHHBBME, Action NICNKBALKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5945740", Offset = "0x5944540", VA = "0x185945740")]
	public static HDOELFFLJBF KHNOIBJDNOM(this MonoBehaviour CIAKDOCBOKB, float EMEHBHHBBME, Action NICNKBALKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5945810", Offset = "0x5944610", VA = "0x185945810")]
	public static HDOELFFLJBF KLJEIBOHPEE(this MonoBehaviour CIAKDOCBOKB, float EMEHBHHBBME, Action NICNKBALKJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class DPMKHLKAIII : AIPGJHAFOKD, IEnumerable<AIPGJHAFOKD>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly List<AIPGJHAFOKD> IBDCFIGKAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool CNFFMIEBBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Action KCLKLFEHLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool ODFOPMFDBAI;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool KOIHKFIBLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x593B5F0", Offset = "0x593A3F0", VA = "0x18593B5F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HDEFHAJFCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x593B7B0", Offset = "0x593A5B0", VA = "0x18593B7B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x593B850", Offset = "0x593A650", VA = "0x18593B850", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x593B8F0", Offset = "0x593A6F0", VA = "0x18593B8F0")]
	public DPMKHLKAIII([Optional] Action KCLKLFEHLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x593B4C0", Offset = "0x593A2C0", VA = "0x18593B4C0")]
	public void EKGLGHAFJEH(AIPGJHAFOKD IFGALNGIIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x593B060", Offset = "0x5939E60", VA = "0x18593B060")]
	private void ANLPKADLDBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x593B4B0", Offset = "0x593A2B0", VA = "0x18593B4B0", Slot = "7")]
	public bool EDGCPFEKDDM(bool JBCHDAAKNKO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x593B1D0", Offset = "0x5939FD0", VA = "0x18593B1D0", Slot = "8")]
	public bool EDGCPFEKDDM(Action CIAILAMJPDB, bool JBCHDAAKNKO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x593B730", Offset = "0x593A530", VA = "0x18593B730", Slot = "9")]
	public IEnumerator<AIPGJHAFOKD> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x593B730", Offset = "0x593A530", VA = "0x18593B730", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class JNIEOICFMOO : NJHFKBOKEHB
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class HKIKNIMFPNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public JNIEOICFMOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public HKIKNIMFPNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x593E620", Offset = "0x593D420", VA = "0x18593E620")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class LHKLHCHDPLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public JNIEOICFMOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public LHKLHCHDPLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x593E620", Offset = "0x593D420", VA = "0x18593E620")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly float MBGDFIFJDEM;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5941D30", Offset = "0x5940B30", VA = "0x185941D30")]
	public JNIEOICFMOO(Behaviour IEGGGFEMEIG, float MBGDFIFJDEM, [Optional] Action KCLKLFEHLBF, [Optional] PPHLHEPALAJ PALJEBCKPNG, [Optional] JPHGDKKIPML OIHCNNEKHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5941B30", Offset = "0x5940930", VA = "0x185941B30", Slot = "9")]
	protected override bool LEEAJPIKKOD(Action CIAILAMJPDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5941C30", Offset = "0x5940A30", VA = "0x185941C30", Slot = "10")]
	protected override bool MEIBIGJFEAB(Action CIAILAMJPDB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface AIPGJHAFOKD
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool KOIHKFIBLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action HDEFHAJFCKO;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EDGCPFEKDDM(bool JBCHDAAKNKO = false);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EDGCPFEKDDM(Action CIAILAMJPDB, bool JBCHDAAKNKO = false);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class NJHFKBOKEHB : AIPGJHAFOKD
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class FOAMHKABONH : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private KDNIAKIKLPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public NJHFKBOKEHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
		[DebuggerHidden]
		public FOAMHKABONH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x593CC80", Offset = "0x593BA80", VA = "0x18593CC80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x593CD50", Offset = "0x593BB50", VA = "0x18593CD50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Behaviour IEGGGFEMEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Action KCLKLFEHLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private BDICOFJGLHK NBFAKFOPGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly PPHLHEPALAJ PALJEBCKPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	protected readonly JPHGDKKIPML OIHCNNEKHJN;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KOIHKFIBLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xB34840", Offset = "0xB33640", VA = "0x180B34840", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action HDEFHAJFCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x59470C0", Offset = "0x5945EC0", VA = "0x1859470C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x59474A0", Offset = "0x59462A0", VA = "0x1859474A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5947540", Offset = "0x5946340", VA = "0x185947540")]
	protected NJHFKBOKEHB(Behaviour IEGGGFEMEIG, [Optional] Action KCLKLFEHLBF, [Optional] PPHLHEPALAJ PALJEBCKPNG, [Optional] JPHGDKKIPML OIHCNNEKHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5947060", Offset = "0x5945E60", VA = "0x185947060", Slot = "7")]
	public bool EDGCPFEKDDM(bool JBCHDAAKNKO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5947010", Offset = "0x5945E10", VA = "0x185947010", Slot = "8")]
	public bool EDGCPFEKDDM(Action CIAILAMJPDB, bool JBCHDAAKNKO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool LEEAJPIKKOD(Action CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool MEIBIGJFEAB(Action CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5946FF0", Offset = "0x5945DF0", VA = "0x185946FF0")]
	protected void ECIBJDPCEPM(Action CIAILAMJPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5947160", Offset = "0x5945F60", VA = "0x185947160")]
	protected FFFHIGBANBM IJECPBCAEMC(float OPOALHMBGOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5947420", Offset = "0x5946220", VA = "0x185947420")]
	private void NEKDAOPGCCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5947360", Offset = "0x5946160", VA = "0x185947360")]
	[IteratorStateMachine(typeof(FOAMHKABONH))]
	private IEnumerator<KDNIAKIKLPJ> KNIABOKGNJI(float OPOALHMBGOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x59473E0", Offset = "0x59461E0", VA = "0x1859473E0")]
	[CompilerGenerated]
	private void LKHIKGMGCHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class AKAAKFLHEJJ : NJHFKBOKEHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly float PLPJJBDMPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly int LIFNBFNOGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly float KDKDACMMJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly float[] DMJIFDIJOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int NFFNOHKOODE;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5934000", Offset = "0x5932E00", VA = "0x185934000")]
	public AKAAKFLHEJJ(Behaviour IEGGGFEMEIG, float LOGMMPOLKHA, int LIFNBFNOGDJ, [Optional] Action KCLKLFEHLBF, float KDKDACMMJBF = 0f, [Optional] PPHLHEPALAJ PALJEBCKPNG, [Optional] JPHGDKKIPML OIHCNNEKHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6E5BE0", Offset = "0x6E49E0", VA = "0x1806E5BE0", Slot = "9")]
	protected override bool LEEAJPIKKOD(Action CIAILAMJPDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5933DD0", Offset = "0x5932BD0", VA = "0x185933DD0", Slot = "10")]
	protected override bool MEIBIGJFEAB(Action CIAILAMJPDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5933D40", Offset = "0x5932B40", VA = "0x185933D40")]
	private void IAOPNOKPCJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class MKBKEMMJBOG : NJHFKBOKEHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly float MBGDFIFJDEM;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5941D30", Offset = "0x5940B30", VA = "0x185941D30")]
	public MKBKEMMJBOG(Behaviour IEGGGFEMEIG, float MBGDFIFJDEM, [Optional] Action KCLKLFEHLBF, [Optional] PPHLHEPALAJ PALJEBCKPNG, [Optional] JPHGDKKIPML OIHCNNEKHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6E5BE0", Offset = "0x6E49E0", VA = "0x1806E5BE0", Slot = "9")]
	protected override bool LEEAJPIKKOD(Action CIAILAMJPDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5945F30", Offset = "0x5944D30", VA = "0x185945F30", Slot = "10")]
	protected override bool MEIBIGJFEAB(Action CIAILAMJPDB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class EKFAINOCILF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class EOIJNIFGLBJ : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private KDNIAKIKLPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
		[DebuggerHidden]
		public EOIJNIFGLBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x593C8D0", Offset = "0x593B6D0", VA = "0x18593C8D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x593C970", Offset = "0x593B770", VA = "0x18593C970", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private HDOELFFLJBF HPNJCCCLPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private JDCOGGPNAAC IEGGGFEMEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action<float> OEGOEKKDGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private float KNLHFKDOHFF;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x593C6E0", Offset = "0x593B4E0", VA = "0x18593C6E0")]
	public EKFAINOCILF(JDCOGGPNAAC IEGGGFEMEIG, float LFDLPHEMJOH, Action<float> JCMJBHPHNGA, MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x593C2B0", Offset = "0x593B0B0", VA = "0x18593C2B0")]
	private void DNJBEIOOFFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x593C150", Offset = "0x593AF50", VA = "0x18593C150")]
	private void BKOOLDBIGPF(string KDIFPAMDOPI, Action EAFLJEBENHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x593C670", Offset = "0x593B470", VA = "0x18593C670")]
	[IteratorStateMachine(typeof(EOIJNIFGLBJ))]
	private IEnumerator<KDNIAKIKLPJ> KEKOANHKCEN(Action EAFLJEBENHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x593C460", Offset = "0x593B260", VA = "0x18593C460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x593C4C0", Offset = "0x593B2C0", VA = "0x18593C4C0")]
	[CompilerGenerated]
	private void ENGBCFCJKEJ(string HOJKPDKANGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class JJPMMNDLOCM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class LMKOLIKJEPP : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private KDNIAKIKLPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
		[DebuggerHidden]
		public LMKOLIKJEPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5945250", Offset = "0x5944050", VA = "0x185945250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x59452F0", Offset = "0x59440F0", VA = "0x1859452F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private HDOELFFLJBF HPNJCCCLPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private MonoBehaviour CIAKDOCBOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private Action JCMJBHPHNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private Action<float> OEGOEKKDGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private float KNLHFKDOHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool CNBOAFLBMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly PPHLHEPALAJ PALJEBCKPNG;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x59410C0", Offset = "0x593FEC0", VA = "0x1859410C0")]
	public JJPMMNDLOCM(MonoBehaviour CIAKDOCBOKB, Action JCMJBHPHNGA, MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK, [Optional] PPHLHEPALAJ PALJEBCKPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x59412C0", Offset = "0x59400C0", VA = "0x1859412C0")]
	public JJPMMNDLOCM(MonoBehaviour CIAKDOCBOKB, Action<float> JCMJBHPHNGA, MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK, [Optional] PPHLHEPALAJ PALJEBCKPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5941500", Offset = "0x5940300", VA = "0x185941500")]
	public JJPMMNDLOCM(MonoBehaviour CIAKDOCBOKB, float LFDLPHEMJOH, Action<float> JCMJBHPHNGA, MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK, bool CNBOAFLBMPD = true, [Optional] PPHLHEPALAJ PALJEBCKPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5940960", Offset = "0x593F760", VA = "0x185940960")]
	private void CBLFJHALAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5940F10", Offset = "0x593FD10", VA = "0x185940F10")]
	private void MGIGHDNENGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5940B60", Offset = "0x593F960", VA = "0x185940B60")]
	private void DNJBEIOOFFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5940830", Offset = "0x593F630", VA = "0x185940830")]
	private void BKOOLDBIGPF(string KDIFPAMDOPI, Action EAFLJEBENHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5940EA0", Offset = "0x593FCA0", VA = "0x185940EA0")]
	[IteratorStateMachine(typeof(LMKOLIKJEPP))]
	private IEnumerator<KDNIAKIKLPJ> KEKOANHKCEN(Action EAFLJEBENHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5940D20", Offset = "0x593FB20", VA = "0x185940D20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5940E10", Offset = "0x593FC10", VA = "0x185940E10")]
	[CompilerGenerated]
	private void HDJEJGGAPGD(string HOJKPDKANGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5940D80", Offset = "0x593FB80", VA = "0x185940D80")]
	[CompilerGenerated]
	private void GIMLMJCFEPA(string HOJKPDKANGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5940AD0", Offset = "0x593F8D0", VA = "0x185940AD0")]
	[CompilerGenerated]
	private void DGIMNGCFPFH(string HOJKPDKANGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Flags]
internal enum NAKENNCDJGC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class LINAGEJIDCC : JPHGDKKIPML
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float KPBHKCILMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x59450B0", Offset = "0x5943EB0", VA = "0x1859450B0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float ICMIKBBPAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x59450A0", Offset = "0x5943EA0", VA = "0x1859450A0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public double EBFLDGHFPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5945010", Offset = "0x5943E10", VA = "0x185945010", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5945030", Offset = "0x5943E30", VA = "0x185945030")]
	[HPAMKJCLFIM(BFFNGLOENLB.None)]
	private static void HPAANPOMCFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	[Preserve]
	internal LINAGEJIDCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal interface HAHOBGKNKBF
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBIOCNAPAIO(string CCEKFDNIAPD);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPHFNNNKJBO();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface HBGOAPPJCCL
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string JBOBPFKLKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool HDPFLLBOJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool CDIILINIEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class KCMFHEJAGLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public KIFGAGJDDKN OMAOBFILPDC;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int NCHPHHOHCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6BF380", Offset = "0x6BE180", VA = "0x1806BF380", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x85DB50", Offset = "0x85C950", VA = "0x18085DB50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5942000", Offset = "0x5940E00", VA = "0x185942000")]
	public static KDNIAKIKLPJ DDBOBBCKLDL(IEnumerator<KDNIAKIKLPJ> MAFKDKHHJKH, JGOOIFAMKND HOJMPPKDDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5941F20", Offset = "0x5940D20", VA = "0x185941F20")]
	public KDNIAKIKLPJ DDBOBBCKLDL(JGOOIFAMKND[] FNMIBDIHLKH, IEnumerator<KDNIAKIKLPJ>[] LBOODEOHPDO, KDNIAKIKLPJ[] GPJDLMJHMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5942430", Offset = "0x5941230", VA = "0x185942430")]
	public void PMFNHCPKHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x59421B0", Offset = "0x5940FB0", VA = "0x1859421B0")]
	public void HPFEDIPJBOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x59422F0", Offset = "0x59410F0", VA = "0x1859422F0")]
	public void JJALBAFBLFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5942430", Offset = "0x5941230", VA = "0x185942430")]
	public void NBBCPPMJDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public KCMFHEJAGLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class KIFGAGJDDKN
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct GPAJIHBPCED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public KCMFHEJAGLJ GNKNFFKPNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public JDCOGGPNAAC FNFFGILJPDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public JGOOIFAMKND EEIIEAAHNBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public IEnumerator<KDNIAKIKLPJ> IDNJMCPNPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public KDNIAKIKLPJ HNOBGPONNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public NAKENNCDJGC JFCDIGNLKKK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct MNBEJILIOGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public MKNJAMNBNFB.CBGOGPCLFKM GFBPNKAFIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public List<GPAJIHBPCED> GJFEAKNMEED;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class CNDBMAPMFEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public JGOOIFAMKND promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public KIFGAGJDDKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public JDCOGGPNAAC context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public KCMFHEJAGLJ routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public NAKENNCDJGC coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public KDNIAKIKLPJ currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public IEnumerator<KDNIAKIKLPJ> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public CNDBMAPMFEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x5936950", Offset = "0x5935750", VA = "0x185936950")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class HFGCCNIEDJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public KCMFHEJAGLJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public KIFGAGJDDKN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public HFGCCNIEDJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x593E220", Offset = "0x593D020", VA = "0x18593E220")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class AKHMBEFNCEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public KCMFHEJAGLJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public KIFGAGJDDKN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public AKHMBEFNCEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x59341B0", Offset = "0x5932FB0", VA = "0x1859341B0")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GCJBBENNDAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public KCMFHEJAGLJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public KIFGAGJDDKN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public GCJBBENNDAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x593D520", Offset = "0x593C320", VA = "0x18593D520")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private const NAKENNCDJGC AHMEPJELHLB = NAKENNCDJGC.Cancelled | NAKENNCDJGC.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool[] HCFKPAJBAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<NAKENNCDJGC> NCHKDOMBCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeArray<float> ILNEDPGNLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<int> MLOBCKADDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<int> AJHJPANPFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<int> JPFCFBIPBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<int> FIDELLDOGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<int> HHDHBPKKOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private KCMFHEJAGLJ[] OGDGNOBCPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private JGOOIFAMKND[] FNMIBDIHLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private JDCOGGPNAAC[] LAEPHICCOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private IEnumerator<KDNIAKIKLPJ>[] LJLEPKEENNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private KDNIAKIKLPJ[] BECMNDCCMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int JMGADDBEFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int DOOAOHCDEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly int JKNNMEEOCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float MBHFKPDHDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private EHNOBPOLKED FFAEBCDPLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private JobHandle GNKCOPFBFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private List<KCMFHEJAGLJ> PPJJCDAJPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool IGFECGPCOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private List<Action> FLIFDHNAFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private List<Action> DCKKHJBCDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private bool ECLCGNBGPCP;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public MNBEJILIOGL[] PDGACFNBKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x82A0F0", Offset = "0x828EF0", VA = "0x18082A0F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5944020", Offset = "0x5942E20", VA = "0x185944020")]
	private static int PALHKCCLGOB(MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5944780", Offset = "0x5943580", VA = "0x185944780")]
	public KIFGAGJDDKN(MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5943E30", Offset = "0x5942C30", VA = "0x185943E30")]
	private void NBIJOOPHFKO(ref int PLFNKBOKPHH, int NCIKBPMGODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5942D30", Offset = "0x5941B30", VA = "0x185942D30")]
	public void GANANJHMOMB(JDCOGGPNAAC IEGGGFEMEIG, KDNIAKIKLPJ NIKKIGONELE, IEnumerator<KDNIAKIKLPJ> MAFKDKHHJKH, JGOOIFAMKND HOJMPPKDDNK, [Optional] KCMFHEJAGLJ ILBPAKNEJPA, NAKENNCDJGC KOPHIOCPAOK = NAKENNCDJGC.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5942AC0", Offset = "0x59418C0", VA = "0x185942AC0")]
	public void ECGADGBFHDM(IEnumerable<GPAJIHBPCED> AODFOJFADED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5942530", Offset = "0x5941330", VA = "0x185942530")]
	private GPAJIHBPCED CHBBBLLGKLK(int KNEAKOENKIP)
	{
		return default(GPAJIHBPCED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5942FE0", Offset = "0x5941DE0", VA = "0x185942FE0")]
	private void KMAECAFCIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F3A0", Offset = "0x3C5E1A0", VA = "0x183C5F3A0")]
	private static void GPBKGNPOBGO<T>(int KNEAKOENKIP, T[] BGFPCKOBOEE, int LCJMNMLOPCJ, [Optional] T FCKJGGNJNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F380", Offset = "0x3C5E180", VA = "0x183C5F380")]
	private static void GPBKGNPOBGO<T>(int KNEAKOENKIP, NativeArray<T> BGFPCKOBOEE, int LCJMNMLOPCJ, [Optional] T FCKJGGNJNIG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5943560", Offset = "0x5942360", VA = "0x185943560")]
	private void LDELJKFAGEF(IEnumerable<GPAJIHBPCED> AODFOJFADED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5942460", Offset = "0x5941260", VA = "0x185942460")]
	private void BOJNKPDGPEB(GPAJIHBPCED ECOMCPFMJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5943A40", Offset = "0x5942840", VA = "0x185943A40")]
	private MEIFJHPNHPB LPEPCANLDIB(int HAHIJKPJJJG)
	{
		return default(MEIFJHPNHPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5943380", Offset = "0x5942180", VA = "0x185943380")]
	public void LCKENHMBKPK(float OEFHHCFBFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5942A40", Offset = "0x5941840", VA = "0x185942A40")]
	private void CNKLEDKFHAA(Action EFBCPNIKEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5942CB0", Offset = "0x5941AB0", VA = "0x185942CB0")]
	private void FLICHHLJDLA(Action EFBCPNIKEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5944050", Offset = "0x5942E50", VA = "0x185944050")]
	public void PONKFEBJGNL(float OEFHHCFBFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5943810", Offset = "0x5942610", VA = "0x185943810")]
	public void LFLAMKKDLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5943D00", Offset = "0x5942B00", VA = "0x185943D00")]
	public void NBBCPPMJDEE(KCMFHEJAGLJ ALKDFEOGGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5943910", Offset = "0x5942710", VA = "0x185943910")]
	public void LGGMHAHLAND(KCMFHEJAGLJ ALKDFEOGGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5942EB0", Offset = "0x5941CB0", VA = "0x185942EB0")]
	public void HHBAMGLKOMC(KCMFHEJAGLJ ALKDFEOGGAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class IOKHKDINAJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static readonly IOKHKDINAJJ BHJINDJNMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly Action JFJGJPFAMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private bool CGEHGMDPJKB;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8AFA10", Offset = "0x8AE810", VA = "0x1808AFA10")]
	public IOKHKDINAJJ(Action JFJGJPFAMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x593FCE0", Offset = "0x593EAE0", VA = "0x18593FCE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface JAMJGFBEHKK<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T MHMGLCIOEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable GOCGAFJDJHA(UnityEngine.Object IEGGGFEMEIG, Action<T> KDDFCOKHOMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface AFOAJJJABGI<T> : global::JAMJGFBEHKK<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T MHMGLCIOEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class FKJBGPFPGMN<T> : global::AFOAJJJABGI<T>, global::JAMJGFBEHKK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class IBJHEDONFDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public global::FKJBGPFPGMN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public global::OHHCNGJEHGJ<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public IBJHEDONFDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2C00290", Offset = "0x2BFF090", VA = "0x182C00290")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static GameObject GPODHHOFEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly List<global::OHHCNGJEHGJ<UnityEngine.Object, Action<T>>> OIAEALIGNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private T IAMLOPCMBFG;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T MHMGLCIOEKC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x84C980", Offset = "0x84B780", VA = "0x18084C980", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x37984F0", Offset = "0x37972F0", VA = "0x1837984F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x37988E0", Offset = "0x37976E0", VA = "0x1837988E0")]
	private static bool NDEHMMHGHFF(T EFBCPNIKEHB, T BFLEMGIJKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3798940", Offset = "0x3797740", VA = "0x183798940")]
	public FKJBGPFPGMN(T DHMGCKDBAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3798740", Offset = "0x3797540", VA = "0x183798740", Slot = "6")]
	public IDisposable GOCGAFJDJHA(UnityEngine.Object IEGGGFEMEIG, Action<T> KDDFCOKHOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3797E30", Offset = "0x3796C30", VA = "0x183797E30")]
	private void CMBKANBHPHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class GOANNOCGNCL : PKECJNDPGMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly PPHLHEPALAJ PALJEBCKPNG;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x593E0B0", Offset = "0x593CEB0", VA = "0x18593E0B0")]
	[HPAMKJCLFIM(BFFNGLOENLB.None)]
	private static void HPAANPOMCFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8AFA10", Offset = "0x8AE810", VA = "0x1808AFA10")]
	[Preserve]
	internal GOANNOCGNCL([NOAEAKEJBMN(null)] PPHLHEPALAJ PALJEBCKPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x593E120", Offset = "0x593CF20", VA = "0x18593E120", Slot = "4")]
	public IDisposable NCMKKFGDMKN(float LFDLPHEMJOH, Action<float> JAKHBAJPHJL, bool CNBOAFLBMPD = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct EHNOBPOLKED : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	[ReadOnly]
	public float NACBEIBJIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	[ReadOnly]
	public int OCJOGDNPFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private NativeArray<int> OLFDBMFHENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private NativeArray<int> GEBCBPEINHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private NativeArray<int> JEIGAKHEKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[ReadOnly]
	public NativeArray<NAKENNCDJGC> GBLFJONBCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	[ReadOnly]
	public NativeArray<float> LEGGGOLGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	[WriteOnly]
	public NativeArray<int> JPFCFBIPBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	[WriteOnly]
	public NativeArray<int> MLOBCKADDAH;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x593BEB0", Offset = "0x593ACB0", VA = "0x18593BEB0")]
	public static EHNOBPOLKED DIMOBFAICBM(int FAEBPGBPCEL, float OEFHHCFBFHE, NativeArray<NAKENNCDJGC> GAHHLJEKPFH, NativeArray<float> CBNIEEFJKCL, NativeArray<int> BKGKLCEHLCO, NativeArray<int> KCEKDDBNPJN, NativeArray<int> MLNJFJPENJD, NativeArray<int> GEBCBPEINHL, NativeArray<int> JEIGAKHEKOG)
	{
		return default(EHNOBPOLKED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x593BF10", Offset = "0x593AD10", VA = "0x18593BF10", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x593BE70", Offset = "0x593AC70", VA = "0x18593BE70")]
	private bool CNIBHOJFLBO(int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x593C050", Offset = "0x593AE50", VA = "0x18593C050")]
	private void JFMICGKAMIO(NativeArray<int> HFCFLMJKGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x593BFF0", Offset = "0x593ADF0", VA = "0x18593BFF0")]
	private int GMEPDKHEKDC(int ICPENDIDDGD, int DOLHMADILPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x593C080", Offset = "0x593AE80", VA = "0x18593C080")]
	private void NAOMKPFMDAA(NativeArray<int> HFCFLMJKGHF, int BJILMBMBBPO, int JFGHLENNNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x593BC40", Offset = "0x593AA40", VA = "0x18593BC40")]
	private void AEBKDHKPMDH(NativeArray<int> HFCFLMJKGHF, int ACEMBECFBIB, int PACBNCAODMG, int PHBPGDBLMJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class HLNDFADLIMG : CFGFEJKPPCJ, PPHLHEPALAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private KIFGAGJDDKN[] NBICEPAJBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private HAHOBGKNKBF JIBHECIMNDB;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x593EBB0", Offset = "0x593D9B0", VA = "0x18593EBB0")]
	[HPAMKJCLFIM(BFFNGLOENLB.None)]
	private static void HPAANPOMCFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x593F240", Offset = "0x593E040", VA = "0x18593F240")]
	[Preserve]
	public HLNDFADLIMG([NOAEAKEJBMN(null)] IGKLJHPOMFH IFCPIEFMHIN, [NOAEAKEJBMN(null)] JPHGDKKIPML OIHCNNEKHJN, [NOAEAKEJBMN(null)] EMJJOACFNGE EGEPLJMHCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x593EE30", Offset = "0x593DC30", VA = "0x18593EE30", Slot = "12")]
	public override HDOELFFLJBF LNPNJMDPIKI(JDCOGGPNAAC IEGGGFEMEIG, IEnumerator<KDNIAKIKLPJ> EAHFGJJMEHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x593E8D0", Offset = "0x593D6D0", VA = "0x18593E8D0", Slot = "13")]
	public override void FLOLCMPEDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x593EF70", Offset = "0x593DD70", VA = "0x18593EF70", Slot = "15")]
	public override void LPFLNPBOLIB(MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x593ED50", Offset = "0x593DB50", VA = "0x18593ED50", Slot = "14")]
	protected override void KMEGEMCDFBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x593F150", Offset = "0x593DF50", VA = "0x18593F150")]
	private KIFGAGJDDKN MNELEDDDCFK(MKNJAMNBNFB.CBGOGPCLFKM LAKBKKJKBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x593F190", Offset = "0x593DF90", VA = "0x18593F190", Slot = "16")]
	internal override DLPKOHNABAN PKALDDJHKFD(IEnumerator<KDNIAKIKLPJ> EAHFGJJMEHP, Behaviour IEGGGFEMEIG, JGOOIFAMKND HOJMPPKDDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x593E860", Offset = "0x593D660", VA = "0x18593E860", Slot = "17")]
	internal override ODHDINIBJNK EPKCHENOHKL(MKNJAMNBNFB.CBGOGPCLFKM OGKLNJLJJHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x593EC20", Offset = "0x593DA20", VA = "0x18593EC20")]
	private void KJLKJJMPMMI(KIFGAGJDDKN KHJDJPIPOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x593E7F0", Offset = "0x593D5F0", VA = "0x18593E7F0", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class CFGFEJKPPCJ : PPHLHEPALAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly IGKLJHPOMFH IFCPIEFMHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	protected readonly JPHGDKKIPML OIHCNNEKHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly EMJJOACFNGE EGEPLJMHCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private ODHDINIBJNK[] GNKJHGPPBKL;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static PPHLHEPALAJ GEHLGJGIEOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5935660", Offset = "0x5934460", VA = "0x185935660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static bool NBPFEPIMLLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C8080", Offset = "0x6C6E80", VA = "0x1806C8080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MKNJAMNBNFB.CBGOGPCLFKM GPBMLMNFDFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6BF380", Offset = "0x6BE180", VA = "0x1806BF380", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MKNJAMNBNFB.CBGOGPCLFKM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x85DB50", Offset = "0x85C950", VA = "0x18085DB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public JPHGDKKIPML EGODLLNHLHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5935E60", Offset = "0x5934C60", VA = "0x185935E60")]
	public static HDOELFFLJBF HFLFDJMNJMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5936220", Offset = "0x5935020", VA = "0x185936220")]
	[Preserve]
	protected CFGFEJKPPCJ([NOAEAKEJBMN(null)] IGKLJHPOMFH IFCPIEFMHIN, [NOAEAKEJBMN(null)] JPHGDKKIPML OIHCNNEKHJN, [NOAEAKEJBMN(null)] EMJJOACFNGE EGEPLJMHCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5935650", Offset = "0x5934450", VA = "0x185935650", Slot = "6")]
	public HDOELFFLJBF ADBECLOOPNC(IEnumerator<KDNIAKIKLPJ> EAHFGJJMEHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x5935420", Offset = "0x5934220", VA = "0x185935420", Slot = "7")]
	public HDOELFFLJBF ADBECLOOPNC(Behaviour IEGGGFEMEIG, IEnumerator<KDNIAKIKLPJ> EAHFGJJMEHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract HDOELFFLJBF LNPNJMDPIKI(JDCOGGPNAAC IEGGGFEMEIG, IEnumerator<KDNIAKIKLPJ> EAHFGJJMEHP);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x5935C60", Offset = "0x5934A60", VA = "0x185935C60", Slot = "13")]
	public virtual void FLOLCMPEDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x59361A0", Offset = "0x5934FA0", VA = "0x1859361A0", Slot = "9")]
	public void NPIHOBNNCBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5935F40", Offset = "0x5934D40", VA = "0x185935F40", Slot = "14")]
	protected virtual void KMEGEMCDFBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5935C40", Offset = "0x5934A40", VA = "0x185935C40")]
	private void EGPPPIMNCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5935C20", Offset = "0x5934A20", VA = "0x185935C20")]
	private void ECKAOPPGFBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5936200", Offset = "0x5935000", VA = "0x185936200")]
	private void POAAEFMFHGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5935E40", Offset = "0x5934C40", VA = "0x185935E40")]
	private void GMLIAEJOGGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5935F00", Offset = "0x5934D00", VA = "0x185935F00")]
	private void IOJMHAAELEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5935880", Offset = "0x5934680", VA = "0x185935880")]
	private void DIDCNPDKOJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5935F20", Offset = "0x5934D20", VA = "0x185935F20")]
	private void JLGMNMEKGNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5935F60", Offset = "0x5934D60", VA = "0x185935F60", Slot = "15")]
	public virtual void LPFLNPBOLIB(MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x59356B0", Offset = "0x59344B0", VA = "0x1859356B0")]
	private void CNOIAMKCBLE(ODHDINIBJNK KHJDJPIPOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x19AAA40", Offset = "0x19A9840", VA = "0x1819AAA40")]
	private ODHDINIBJNK OKOJCBFIBLB(MKNJAMNBNFB.CBGOGPCLFKM LAKBKKJKBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract DLPKOHNABAN PKALDDJHKFD(IEnumerator<KDNIAKIKLPJ> EAHFGJJMEHP, Behaviour CIAKDOCBOKB, JGOOIFAMKND LLGHHGIHEGD);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract ODHDINIBJNK EPKCHENOHKL(MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x59358A0", Offset = "0x59346A0", VA = "0x1859358A0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal sealed class DLPKOHNABAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly JGOOIFAMKND HOJMPPKDDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly HBGOAPPJCCL IEGGGFEMEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly bool IIBNCOMLHPH;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<KDNIAKIKLPJ> IDNJMCPNPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F00", Offset = "0x6E5D00", VA = "0x1806E6F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KDNIAKIKLPJ HNOBGPONNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7011D0", Offset = "0x6FFFD0", VA = "0x1807011D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JJMALODPEPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x593AC10", Offset = "0x5939A10", VA = "0x18593AC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool BHHIPOLAAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xD03890", Offset = "0xD02690", VA = "0x180D03890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xD038E0", Offset = "0xD026E0", VA = "0x180D038E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string JBOBPFKLKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D4450", Offset = "0x6D3250", VA = "0x1806D4450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6D4470", Offset = "0x6D3270", VA = "0x1806D4470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float FKEIBKHALKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6C5CD0", Offset = "0x6C4AD0", VA = "0x1806C5CD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1191F90", Offset = "0x1190D90", VA = "0x181191F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x593AE40", Offset = "0x5939C40", VA = "0x18593AE40")]
	public DLPKOHNABAN(IEnumerator<KDNIAKIKLPJ> MAFKDKHHJKH, HBGOAPPJCCL IEGGGFEMEIG, JGOOIFAMKND HOJMPPKDDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x593A950", Offset = "0x5939750", VA = "0x18593A950")]
	public KDNIAKIKLPJ DDBOBBCKLDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x593AC90", Offset = "0x5939A90", VA = "0x18593AC90")]
	public bool KIFENCPGJFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x593AD00", Offset = "0x5939B00", VA = "0x18593AD00")]
	public void NBBCPPMJDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x593AD80", Offset = "0x5939B80", VA = "0x18593AD80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A5A900", Offset = "0x2A59700", VA = "0x182A5A900")]
	[CompilerGenerated]
	private void LLDLEOOLFFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class JGOOIFAMKND : IBLDJKPGHLJ, HDOELFFLJBF, BDICOFJGLHK, FFFHIGBANBM, IEnumerator, KDNIAKIKLPJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private MKNJAMNBNFB.CBGOGPCLFKM ELDFFLHMJIO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private MKNJAMNBNFB.CBGOGPCLFKM NPNGMBIAJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x785580", Offset = "0x784380", VA = "0x180785580", Slot = "23")]
		get
		{
			return default(MKNJAMNBNFB.CBGOGPCLFKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MKNJAMNBNFB.CBGOGPCLFKM OMAOBFILPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xAD2FC0", Offset = "0xAD1DC0", VA = "0x180AD2FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float EHONCEIPPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xBCC170", Offset = "0xBCAF70", VA = "0x180BCC170", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x593FE10", Offset = "0x593EC10", VA = "0x18593FE10", Slot = "24")]
	private bool OBMIEMODNBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x593FE00", Offset = "0x593EC00", VA = "0x18593FE00", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x593FE30", Offset = "0x593EC30", VA = "0x18593FE30")]
	public JGOOIFAMKND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal enum MEIFJHPNHPB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class ODHDINIBJNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum CBBNHJFGBOO
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct PKHAGBFHFIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public MKNJAMNBNFB.CBGOGPCLFKM GFBPNKAFIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public CBBNHJFGBOO CPIBAIEFHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public List<DLPKOHNABAN> AKINNLGEKLI;
	}

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly CBBNHJFGBOO[] MPOIADAGKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly MKNJAMNBNFB.CBGOGPCLFKM NJMGMOFKHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool FGPDHAEHFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly DLPKOHNABAN[] NDKFCAFLADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly List<DLPKOHNABAN> JIGOHKOFNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly Stack<int> DJOMPBHEMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly List<DLPKOHNABAN> MOPPPJEEBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly Stack<int> KBDLKMCILCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly HAHOBGKNKBF ACJPNGMAKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private bool ECLCGNBGPCP;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public PKHAGBFHFIN[,] CGFMPKFLNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7A0", Offset = "0x6CA5A0", VA = "0x1806CB7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x59490C0", Offset = "0x5947EC0", VA = "0x1859490C0")]
	public ODHDINIBJNK(MKNJAMNBNFB.CBGOGPCLFKM OGKLNJLJJHC, HAHOBGKNKBF ACJPNGMAKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5947D00", Offset = "0x5946B00", VA = "0x185947D00")]
	public void BBKOJLAAFAH(DLPKOHNABAN MAFKDKHHJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5948870", Offset = "0x5947670", VA = "0x185948870")]
	public void OMMPBFOAAOD(IList<DLPKOHNABAN> LBOODEOHPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5948CE0", Offset = "0x5947AE0", VA = "0x185948CE0")]
	public void POFKKBJJNKP(IList<DLPKOHNABAN> LBOODEOHPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5947E20", Offset = "0x5946C20", VA = "0x185947E20")]
	private void BEFIOANMFOA(DLPKOHNABAN MAFKDKHHJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x59484E0", Offset = "0x59472E0", VA = "0x1859484E0")]
	private void NLBNMBFLKNA(IList<DLPKOHNABAN> LBOODEOHPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5948B40", Offset = "0x5947940", VA = "0x185948B40")]
	private MEIFJHPNHPB PIJDHPHHBKE(DLPKOHNABAN MAFKDKHHJKH)
	{
		return default(MEIFJHPNHPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5948280", Offset = "0x5947080", VA = "0x185948280")]
	public void KMEGEMCDFBL(float OEFHHCFBFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5948660", Offset = "0x5947460", VA = "0x185948660")]
	public void NPIHOBNNCBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5948060", Offset = "0x5946E60", VA = "0x185948060")]
	private void HFNIJDGFKJB(List<DLPKOHNABAN> LBOODEOHPDO, Stack<int> ADJEOEHLIDG, bool LBOFMKKLDKH, float KIJLMIEIBBH = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5947F20", Offset = "0x5946D20", VA = "0x185947F20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x59483C0", Offset = "0x59471C0", VA = "0x1859483C0")]
	private void MDGNGGNMKBK(List<DLPKOHNABAN> LBOODEOHPDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal class COJLACKJOMJ : HAHOBGKNKBF
{
	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "4")]
	public void IBIOCNAPAIO(string CCEKFDNIAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
	public void KPHFNNNKJBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public COJLACKJOMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal class JJMPEMNKHIN : HBGOAPPJCCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly Behaviour CIAKDOCBOKB;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string JBOBPFKLKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x59407A0", Offset = "0x593F5A0", VA = "0x1859407A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool HDPFLLBOJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5940740", Offset = "0x593F540", VA = "0x185940740", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CDIILINIEHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5940720", Offset = "0x593F520", VA = "0x185940720", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8AFA10", Offset = "0x8AE810", VA = "0x1808AFA10")]
	public JJMPEMNKHIN(Behaviour CIAKDOCBOKB)
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

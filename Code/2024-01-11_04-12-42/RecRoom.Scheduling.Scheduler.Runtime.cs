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
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class EHGCCFDKMBC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority MONJBBAODCB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66E0560", Offset = "0x66DEF60", VA = "0x1866E0560")]
	public EHGCCFDKMBC(ThreadPriority JPBJHLEAMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66E0550", Offset = "0x66DEF50", VA = "0x1866E0550", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> KKHEDLIFJFA(List<PlayerLoopSystem> AKNFAFBFMJO, int MMLCFOHDCLB);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct ALJICGMKMNF
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct OFCKLMOGJCL
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static BCNLEBGHOIF KCFGCBMPPPN;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x66EEE60", Offset = "0x66ED860", VA = "0x1866EEE60")]
				public static PlayerLoopSystem IEEOOCGKCDM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct JHMMNNPFCJE
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static BCNLEBGHOIF PCFGDIAMKDP;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x66E7C50", Offset = "0x66E6650", VA = "0x1866E7C50")]
				public static PlayerLoopSystem IEEOOCGKCDM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct KLMJNMAOLAF
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static BCNLEBGHOIF KIMGIANNLJE;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x66EAEA0", Offset = "0x66E98A0", VA = "0x1866EAEA0")]
				public static PlayerLoopSystem IEEOOCGKCDM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct FHMINIDIKNB
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static BCNLEBGHOIF ONOEMHDMKPE;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static BCNLEBGHOIF LDDOMODLDMK;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static BCNLEBGHOIF PEIFJMPEANA;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static BCNLEBGHOIF GBLDBPEPNDF;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x66E1410", Offset = "0x66DFE10", VA = "0x1866E1410")]
				public static PlayerLoopSystem IEEOOCGKCDM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct HNOHNHMKDHD
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static BCNLEBGHOIF NCDMPDPFKFB;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x66E4740", Offset = "0x66E3140", VA = "0x1866E4740")]
				public static PlayerLoopSystem IEEOOCGKCDM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct JNDFFOGJFLA
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static BCNLEBGHOIF ONOEMHDMKPE;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static BCNLEBGHOIF LDDOMODLDMK;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static BCNLEBGHOIF PEIFJMPEANA;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static BCNLEBGHOIF GBLDBPEPNDF;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x66E9760", Offset = "0x66E8160", VA = "0x1866E9760")]
				public static PlayerLoopSystem IEEOOCGKCDM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct AIPFMMBONKB
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static BCNLEBGHOIF KPIGKGGHJMD;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x66D5CF0", Offset = "0x66D46F0", VA = "0x1866D5CF0")]
				public static PlayerLoopSystem IEEOOCGKCDM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct MHLKOIEBHHE
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static BCNLEBGHOIF EHEMHNMEABE;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x66EC330", Offset = "0x66EAD30", VA = "0x1866EC330")]
				public static PlayerLoopSystem IEEOOCGKCDM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct KGMGBGIADKO
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static BCNLEBGHOIF JBINFBLCMDJ;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x66EA410", Offset = "0x66E8E10", VA = "0x1866EA410")]
				public static PlayerLoopSystem IEEOOCGKCDM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct NIJHGHNLCOF
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static BCNLEBGHOIF GFLOOICELFJ;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x66ED800", Offset = "0x66EC200", VA = "0x1866ED800")]
				public static PlayerLoopSystem IEEOOCGKCDM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct MGJLNOLCHMH
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static BCNLEBGHOIF FKJEKPPKHHE;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x66EC130", Offset = "0x66EAB30", VA = "0x1866EC130")]
				public static PlayerLoopSystem IEEOOCGKCDM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct IGAOIOPBLBM
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static BCNLEBGHOIF IBNBBGDPDPB;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x66E4C60", Offset = "0x66E3660", VA = "0x1866E4C60")]
				public static PlayerLoopSystem IEEOOCGKCDM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum ICGINPLAKEA : byte
			{
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct BCIGGMBFJED
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class CLEBOGEICNG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public ICGINPLAKEA updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
					public CLEBOGEICNG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x66D8F00", Offset = "0x66D7900", VA = "0x1866D8F00")]
					internal void CFDAKMDFODK()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static BFONFBJGKIG<ICGINPLAKEA> FPHLNNBLPCO;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x66D8730", Offset = "0x66D7130", VA = "0x1866D8730")]
				public static PlayerLoopSystem IEEOOCGKCDM(ICGINPLAKEA HJIDDNKNHBF)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct BPKHLONGEFE
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class EMLAPBJOOMJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public BAPCHIBJPCE.FFCIHBPKLLO key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
					public EMLAPBJOOMJ()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x66E08E0", Offset = "0x66DF2E0", VA = "0x1866E08E0")]
					internal void HOMAAIJEHHE()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable PIGFHCCJDDF;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x66D8BE0", Offset = "0x66D75E0", VA = "0x1866D8BE0")]
				public static PlayerLoopSystem HGJFJOMGLFA(BAPCHIBJPCE.FFCIHBPKLLO FHLJKJHFEEK)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct BLEIJGDFNFI
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class GOPGEDOPGAH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public BAPCHIBJPCE.FFCIHBPKLLO key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
					public GOPGEDOPGAH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x66E2630", Offset = "0x66E1030", VA = "0x1866E2630")]
					internal void HOMAAIJEHHE()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x66D8AB0", Offset = "0x66D74B0", VA = "0x1866D8AB0")]
				public static PlayerLoopSystem HGJFJOMGLFA(BAPCHIBJPCE.FFCIHBPKLLO FHLJKJHFEEK)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class GCPKHLOHCEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public GCPKHLOHCEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x66E23D0", Offset = "0x66E0DD0", VA = "0x1866E23D0")]
			internal List<PlayerLoopSystem> NCMBJOIMJLB(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool BDKINELDGLD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool DIONGBECDGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x66DC080", Offset = "0x66DAA80", VA = "0x1866DC080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x66D8F80", Offset = "0x66D7980", VA = "0x1866D8F80")]
		private static void ALBNEFJIICC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x66DC0C0", Offset = "0x66DAAC0", VA = "0x1866DC0C0")]
		private static void MEMBHOALHKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x66DB8B0", Offset = "0x66DA2B0", VA = "0x1866DB8B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66DBAE0", Offset = "0x66DA4E0", VA = "0x1866DBAE0")]
		private static void CBGDMDMDCCL(BAPCHIBJPCE.FFCIHBPKLLO FHLJKJHFEEK, PlayerLoopSystem ONAFGHOHCFB, Type AEMICFOMFIA, Type FKDEIGEHHGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x66DBCA0", Offset = "0x66DA6A0", VA = "0x1866DBCA0")]
		private static void GMHFJOPBPDE(PlayerLoopSystem ONAFGHOHCFB, Type AEMICFOMFIA, Type FKDEIGEHHGB, KKHEDLIFJFA KJKINFCIHPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66DC990", Offset = "0x66DB390", VA = "0x1866DC990")]
		private static void NNMKGFFHGJL(PlayerLoopSystem ONAFGHOHCFB, Type AEMICFOMFIA, Type FKDEIGEHHGB, PlayerLoopSystem? EKLKOCMNOFB, PlayerLoopSystem? HFPNMCLFDMJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class BAPCHIBJPCE
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum FFCIHBPKLLO
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AFCDODOLPFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly FFCIHBPKLLO PJLBONLGOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly KILAMIJHKIJ GBBBJKAAJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long DBPLMKMMHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long JPDBMFBALFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long BJLPALCLKOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int DDANLMJBCGN;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x66D5BE0", Offset = "0x66D45E0", VA = "0x1866D5BE0")]
		public AFCDODOLPFF(FFCIHBPKLLO HGGJCKGNHAK, int IDFCDPALMFO = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x66D5B70", Offset = "0x66D4570", VA = "0x1866D5B70")]
		public void KHOACBLMAEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x66D5940", Offset = "0x66D4340", VA = "0x1866D5940")]
		public void ALLILMIGDHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x66D5990", Offset = "0x66D4390", VA = "0x1866D5990")]
		public void GIAHPOEMKPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static FFCIHBPKLLO[] MNHFEOFEKBJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static AFCDODOLPFF[] MHMDAMMDFCC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x66D6DB0", Offset = "0x66D57B0", VA = "0x1866D6DB0")]
	public static AFCDODOLPFF KEGFLMFCMLK(FFCIHBPKLLO FHLJKJHFEEK, int IDFCDPALMFO = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x66D6F90", Offset = "0x66D5990", VA = "0x1866D6F90")]
	public static AFCDODOLPFF LNBFDANBMFO(FFCIHBPKLLO FHLJKJHFEEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x66D6D10", Offset = "0x66D5710", VA = "0x1866D6D10")]
	public static void JEFBBOEECAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class KILAMIJHKIJ : KKMFNFNBDPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int OIKBFOAHLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> CFJHDFLHAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double NHJJBILLIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double GPOGCNJCGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double HKOICPLMFFF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double OMECKNFKPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x66EAD90", Offset = "0x66E9790", VA = "0x1866EAD90", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double LMJGAOPIBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1743DA0", Offset = "0x17427A0", VA = "0x181743DA0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double LHAJMIGOFKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1CDD5D0", Offset = "0x1CDBFD0", VA = "0x181CDD5D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x66EADF0", Offset = "0x66E97F0", VA = "0x1866EADF0")]
	public KILAMIJHKIJ(int GMHICIAIKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x66EAC00", Offset = "0x66E9600", VA = "0x1866EAC00", Slot = "7")]
	public void HDLGNIPCFAB(double FJNMPOJLNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x66EAD20", Offset = "0x66E9720", VA = "0x1866EAD20", Slot = "8")]
	public void JGPBMMKLMDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class ELJAPNOHADD : KKMFNFNBDPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long MPNHPMPEEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double JNIHPHNHMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double PGNJPDJBBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double JIGKPENNPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double KKNDBHDKOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double NHJJBILLIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double GPOGCNJCGJN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double LMJGAOPIBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5606810", Offset = "0x5605210", VA = "0x185606810", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double LHAJMIGOFKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5606890", Offset = "0x5605290", VA = "0x185606890", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double JAGFGAIKEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x56067E0", Offset = "0x56051E0", VA = "0x1856067E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double OMECKNFKPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x21486A0", Offset = "0x21470A0", VA = "0x1821486A0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x66E0750", Offset = "0x66DF150", VA = "0x1866E0750", Slot = "7")]
	public virtual void HDLGNIPCFAB(double FJNMPOJLNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x66E0870", Offset = "0x66DF270", VA = "0x1866E0870", Slot = "8")]
	public virtual void JGPBMMKLMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x66E08B0", Offset = "0x66DF2B0", VA = "0x1866E08B0")]
	public ELJAPNOHADD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class MPGGFKJJEGF : ELJAPNOHADD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double DEEELEOMBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5606CD0", Offset = "0x56056D0", VA = "0x185606CD0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5606CE0", Offset = "0x56056E0", VA = "0x185606CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x66EC5F0", Offset = "0x66EAFF0", VA = "0x1866EC5F0", Slot = "7")]
	public override void HDLGNIPCFAB(double FJNMPOJLNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x66EC720", Offset = "0x66EB120", VA = "0x1866EC720", Slot = "8")]
	public override void JGPBMMKLMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x66E08B0", Offset = "0x66DF2B0", VA = "0x1866E08B0")]
	public MPGGFKJJEGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KKMFNFNBDPH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double OMECKNFKPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double LMJGAOPIBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double LHAJMIGOFKH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class PKFNEEGJADL
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface LGKNPHBNHJI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool MMIGNIGLLPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DAFDMKIFLPG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class DFOLPOAKCBJ<TPromise, TMainThreadPromise> : LGKNPHBNHJI where TPromise : GOACJHIODHI where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise FDAIDKPGOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise APEGHJLENMJ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise FAOKBBBLGBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x4F5D040", Offset = "0x4F5BA40", VA = "0x184F5D040")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool MMIGNIGLLPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x4F5CFF0", Offset = "0x4F5B9F0", VA = "0x184F5CFF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x797640", Offset = "0x796040", VA = "0x180797640")]
		protected DFOLPOAKCBJ(TPromise FDAIDKPGOFF, TMainThreadPromise MCDMPBECGOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4F5CFD0", Offset = "0x4F5B9D0", VA = "0x184F5CFD0", Slot = "5")]
		public void DAFDMKIFLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void BNBCBJIHCAO(TPromise FDAIDKPGOFF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class FMALAFGBDNK<T> : DFOLPOAKCBJ<HECHONBOMGO<T>, OKOIJGIEAFP<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x35CCC50", Offset = "0x35CB650", VA = "0x1835CCC50")]
		public FMALAFGBDNK(HECHONBOMGO<T> FDAIDKPGOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x35CCAA0", Offset = "0x35CB4A0", VA = "0x1835CCAA0", Slot = "6")]
		protected override void BNBCBJIHCAO(HECHONBOMGO<T> FDAIDKPGOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x35CCC20", Offset = "0x35CB620", VA = "0x1835CCC20")]
		[CompilerGenerated]
		private void LGGEPPPLILH(T JHJJOGFODKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x35CCBF0", Offset = "0x35CB5F0", VA = "0x1835CCBF0")]
		[CompilerGenerated]
		private void IFFAKMNNPPD(string BNFACNGELAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class MFCIGEAKGMG : LGKNPHBNHJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action GMHPLHJININ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool MMIGNIGLLPH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7AA930", Offset = "0x7A9330", VA = "0x1807AA930", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
		public MFCIGEAKGMG(Action GMHPLHJININ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB967E0", Offset = "0xB951E0", VA = "0x180B967E0", Slot = "5")]
		public void DAFDMKIFLPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<LGKNPHBNHJI> EMGPKDNJEMF;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2779AB0", Offset = "0x27784B0", VA = "0x182779AB0")]
	public static HECHONBOMGO<T> BCAIPPMJJOB<T>(this HECHONBOMGO<T> FDAIDKPGOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x66EFE40", Offset = "0x66EE840", VA = "0x1866EFE40")]
	public static void BCAIPPMJJOB(Action GMHPLHJININ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2779B10", Offset = "0x2778510", VA = "0x182779B10")]
	private static HECHONBOMGO<T> JBJALBDCEKC<T>(HECHONBOMGO<T> FDAIDKPGOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x66EFFC0", Offset = "0x66EE9C0", VA = "0x1866EFFC0")]
	private static void GNAJAIPHBDC(LGKNPHBNHJI EOJDMPLANGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x66F01D0", Offset = "0x66EEBD0", VA = "0x1866F01D0")]
	private static void MOKEIBCPJCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x66F04B0", Offset = "0x66EEEB0", VA = "0x1866F04B0")]
	private static void OBPFECBLAAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x66EFEE0", Offset = "0x66EE8E0", VA = "0x1866EFEE0")]
	private static void GAJOOMBINEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class JLJADGCFMJH
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct NFBCMNPLOJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> EFBDLPFJFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string EPLGIOOEIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode CICBDCFBNJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool MFBAIECFDDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly MBGNCDNKJOE<string>.GOJEFEHEBEO LEBBICOAJAC;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x66EC760", Offset = "0x66EB160", VA = "0x1866EC760")]
		public NFBCMNPLOJH(TaskCompletionSource<Scene> FFEDDICINOC, string EPLGIOOEIOG, LoadSceneMode CICBDCFBNJP, bool MFBAIECFDDN, MBGNCDNKJOE<string>.GOJEFEHEBEO LEBBICOAJAC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct ECNFAIFNFCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public MBGNCDNKJOE<string>.GOJEFEHEBEO stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private MBGNCDNKJOE<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x66DFC40", Offset = "0x66DE640", VA = "0x1866DFC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x66E04E0", Offset = "0x66DEEE0", VA = "0x1866E04E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct ONNHIBFLDFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x66EF0A0", Offset = "0x66EDAA0", VA = "0x1866EF0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x66EF3C0", Offset = "0x66EDDC0", VA = "0x1866EF3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct HLJFBCLFBAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private NFBCMNPLOJH <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x66E4300", Offset = "0x66E2D00", VA = "0x1866E4300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x66E46B0", Offset = "0x66E30B0", VA = "0x1866E46B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class HFCEHHMKODN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public OKOIJGIEAFP<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public HFCEHHMKODN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x66E28E0", Offset = "0x66E12E0", VA = "0x1866E28E0")]
		internal void PBOJLFHDOIF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct KLNEOHMJMKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public MBGNCDNKJOE<string>.GOJEFEHEBEO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private HFCEHHMKODN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private MBGNCDNKJOE<string>.GOJEFEHEBEO <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private MBGNCDNKJOE<string>.GOJEFEHEBEO <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x66EB0A0", Offset = "0x66E9AA0", VA = "0x1866EB0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x66EBC40", Offset = "0x66EA640", VA = "0x1866EBC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct AMNFHIBLCEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x66D5EF0", Offset = "0x66D48F0", VA = "0x1866D5EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x66D6400", Offset = "0x66D4E00", VA = "0x1866D6400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct GCBEEAKMNPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public MBGNCDNKJOE<string>.GOJEFEHEBEO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private MBGNCDNKJOE<string>.GOJEFEHEBEO <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private MBGNCDNKJOE<string>.GOJEFEHEBEO <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x66E1810", Offset = "0x66E0210", VA = "0x1866E1810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x66E2360", Offset = "0x66E0D60", VA = "0x1866E2360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class HMBHDIHCACO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public HMBHDIHCACO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x66E4710", Offset = "0x66E3110", VA = "0x1866E4710")]
		internal bool IJOBHGDOFNK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class POOCMDKDKLM : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private KMDFFEOBLOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public JGJGMCLOHKB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public POOCMDKDKLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x66F0A20", Offset = "0x66EF420", VA = "0x1866F0A20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x66F0640", Offset = "0x66EF040", VA = "0x1866F0640", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x66F0980", Offset = "0x66EF380", VA = "0x1866F0980")]
		private void OEKMCAOJCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x66F09D0", Offset = "0x66EF3D0", VA = "0x1866F09D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class BBAPFHBJPFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public OKOIJGIEAFP<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public BBAPFHBJPFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x66D71A0", Offset = "0x66D5BA0", VA = "0x1866D71A0")]
		internal bool FPJLJPJLIJG(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x66D7220", Offset = "0x66D5C20", VA = "0x1866D7220")]
		internal void MBJEFHGLDLF(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class FAJEJAGALCG : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private KMDFFEOBLOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public OKOIJGIEAFP<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private BBAPFHBJPFB <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public FAJEJAGALCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x66E0CB0", Offset = "0x66DF6B0", VA = "0x1866E0CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x66E13C0", Offset = "0x66DFDC0", VA = "0x1866E13C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> PMHFGHDKDHD;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static GOACJHIODHI DFFBIBACBLK;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation GOCLLNLCCKN;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static GOACJHIODHI KNGAJEDCMJD;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string LPMHCIINEDO;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority HCCLNELFJAI;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task IEDHHMIGDNG;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> CHODEJGBHMA;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<NFBCMNPLOJH> LNLCBKPPBKH;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task AHIMLNCKNFM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool IINIFHHFLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x66E8410", Offset = "0x66E6E10", VA = "0x1866E8410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool BPDMMFKCEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x66E8630", Offset = "0x66E7030", VA = "0x1866E8630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool AACIIBCMGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x66E92C0", Offset = "0x66E7CC0", VA = "0x1866E92C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool JBOPGLHMBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x66E88E0", Offset = "0x66E72E0", VA = "0x1866E88E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> OAMNGNCNDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x66E8120", Offset = "0x66E6B20", VA = "0x1866E8120")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x66E8ED0", Offset = "0x66E78D0", VA = "0x1866E8ED0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x66E8C20", Offset = "0x66E7620", VA = "0x1866E8C20")]
	[NHDGMMNNJIB(ANBGDHPPCHK.EnteredEditModeNextFrame, 0)]
	private static void MKNGEAHPELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x66E82C0", Offset = "0x66E6CC0", VA = "0x1866E82C0")]
	[AsyncStateMachine(typeof(ECNFAIFNFCH))]
	public static Task<Scene> EBMDAIFKBNC(string EPLGIOOEIOG, LoadSceneMode CICBDCFBNJP = LoadSceneMode.Single, bool MFBAIECFDDN = false, [Optional] MBGNCDNKJOE<string>.GOJEFEHEBEO AENHAAJJIII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x66E8B70", Offset = "0x66E7570", VA = "0x1866E8B70")]
	[AsyncStateMachine(typeof(ONNHIBFLDFG))]
	private static Task MFBJBMAOFHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x66E8AA0", Offset = "0x66E74A0", VA = "0x1866E8AA0")]
	[AsyncStateMachine(typeof(HLJFBCLFBAE))]
	private static Task LLEJJLDEOPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x66E8790", Offset = "0x66E7190", VA = "0x1866E8790")]
	[AsyncStateMachine(typeof(KLNEOHMJMKO))]
	private static Task<Scene> GPCNBEAGOBM(string EPLGIOOEIOG, LoadSceneMode CICBDCFBNJP, bool MFBAIECFDDN, MBGNCDNKJOE<string>.GOJEFEHEBEO LEBBICOAJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x66E9160", Offset = "0x66E7B60", VA = "0x1866E9160")]
	private static void OKLMDPPHBMB(SceneInstance BDFKMGIHPBP, LoadSceneMode CICBDCFBNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x66E86D0", Offset = "0x66E70D0", VA = "0x1866E86D0")]
	private static void GNAINPOHLFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x66E9450", Offset = "0x66E7E50", VA = "0x1866E9450")]
	[AsyncStateMachine(typeof(AMNFHIBLCEB))]
	private static Task<Scene> PPJMAOLKIPK(string EPLGIOOEIOG, LoadSceneMode CICBDCFBNJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x66E9360", Offset = "0x66E7D60", VA = "0x1866E9360")]
	private static bool PCJJGOCPPLM(string EPLGIOOEIOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x66E8DC0", Offset = "0x66E77C0", VA = "0x1866E8DC0")]
	[AsyncStateMachine(typeof(GCBEEAKMNPO))]
	private static Task<Scene> OABDJJIBKGJ(MBGNCDNKJOE<string>.GOJEFEHEBEO LEBBICOAJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x66E8FE0", Offset = "0x66E79E0", VA = "0x1866E8FE0")]
	public static HECHONBOMGO<Scene> OJJLCKLEKMD(string EPLGIOOEIOG, LoadSceneMode CICBDCFBNJP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x66E7E50", Offset = "0x66E6850", VA = "0x1866E7E50")]
	public static GOACJHIODHI ACBIBPGPJKJ(string EPLGIOOEIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x66E8230", Offset = "0x66E6C30", VA = "0x1866E8230")]
	[IteratorStateMachine(typeof(POOCMDKDKLM))]
	private static IEnumerator<KMDFFEOBLOI> EBKDDCNDCEP(string EPLGIOOEIOG, JGJGMCLOHKB PHEEDGAJEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x66E8D20", Offset = "0x66E7720", VA = "0x1866E8D20")]
	[IteratorStateMachine(typeof(FAJEJAGALCG))]
	private static IEnumerator<KMDFFEOBLOI> NOCEKPLGBHK(string EPLGIOOEIOG, LoadSceneMode CICBDCFBNJP, OKOIJGIEAFP<Scene> PHEEDGAJEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x66E8970", Offset = "0x66E7370", VA = "0x1866E8970")]
	public static bool KPEKBPDEJJI([Out] string IJMAOPIJAEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class ENOLLPGCEHD
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x66E0B20", Offset = "0x66DF520", VA = "0x1866E0B20")]
	public static IDisposable BDEEIHJGCCE(this PKCMENKCIKM AGHGCGMHDAO, float PFHMMFEKIFN, Action<float> ICMMCMPKPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x66E0C30", Offset = "0x66DF630", VA = "0x1866E0C30")]
	public static IDisposable MFEMFOEAJLO(this PKCMENKCIKM AGHGCGMHDAO, Action<float> ICMMCMPKPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x66E0BB0", Offset = "0x66DF5B0", VA = "0x1866E0BB0")]
	public static IDisposable KEEOIJNCMKI(this PKCMENKCIKM AGHGCGMHDAO, Action<float> ICMMCMPKPNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class JAIOKDHCIPI
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x66E73D0", Offset = "0x66E5DD0", VA = "0x1866E73D0")]
	public static IDisposable IPACCBKPBCP(this MonoBehaviour LMILGIDOLIF, Action ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x66E7460", Offset = "0x66E5E60", VA = "0x1866E7460")]
	public static IDisposable IPACCBKPBCP(this MonoBehaviour LMILGIDOLIF, Action<float> ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x66E6BE0", Offset = "0x66E55E0", VA = "0x1866E6BE0")]
	public static IDisposable ADFCFFECPNL(this MonoBehaviour LMILGIDOLIF, Action ICMMCMPKPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x66E6D60", Offset = "0x66E5760", VA = "0x1866E6D60")]
	public static IDisposable AOAHONMAAIN(this MonoBehaviour LMILGIDOLIF, Action ICMMCMPKPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x66E6CE0", Offset = "0x66E56E0", VA = "0x1866E6CE0")]
	public static IDisposable AOAHONMAAIN(this MonoBehaviour LMILGIDOLIF, Action<float> ICMMCMPKPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x66E6F30", Offset = "0x66E5930", VA = "0x1866E6F30")]
	public static IDisposable CBMAMNPMDLD(this MonoBehaviour LMILGIDOLIF, Action ICMMCMPKPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x66E6C60", Offset = "0x66E5660", VA = "0x1866E6C60")]
	public static IDisposable AKBGMEDBPEI(this MonoBehaviour LMILGIDOLIF, Action ICMMCMPKPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x66E72B0", Offset = "0x66E5CB0", VA = "0x1866E72B0")]
	public static IDisposable IEJCEJFPCCK(this MonoBehaviour LMILGIDOLIF, Action ICMMCMPKPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x66E74F0", Offset = "0x66E5EF0", VA = "0x1866E74F0")]
	public static IDisposable LKJCLDJFOCM(this MonoBehaviour LMILGIDOLIF, float PFHMMFEKIFN, Action<float> ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH, bool LOJEHJAHEFE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x66E7050", Offset = "0x66E5A50", VA = "0x1866E7050")]
	public static IDisposable GOLGDDPJBGJ(this MonoBehaviour LMILGIDOLIF, float PFHMMFEKIFN, Action<float> ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH, bool LOJEHJAHEFE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x66E76E0", Offset = "0x66E60E0", VA = "0x1866E76E0")]
	public static IDisposable PBKKOIBJJAM(this MonoBehaviour LMILGIDOLIF, float PFHMMFEKIFN, Action<float> ICMMCMPKPNB, bool LOJEHJAHEFE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x66E7170", Offset = "0x66E5B70", VA = "0x1866E7170")]
	public static IDisposable HCBDHHNMONE(this MonoBehaviour LMILGIDOLIF, Action<float> ICMMCMPKPNB, bool LOJEHJAHEFE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x66E7330", Offset = "0x66E5D30", VA = "0x1866E7330")]
	public static IDisposable IHMBAINGKDL(this MonoBehaviour LMILGIDOLIF, Action<float> ICMMCMPKPNB, bool LOJEHJAHEFE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x66E75A0", Offset = "0x66E5FA0", VA = "0x1866E75A0")]
	public static IDisposable NCPKBJLGDNN(this MonoBehaviour LMILGIDOLIF, Action<float> ICMMCMPKPNB, bool LOJEHJAHEFE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x66E7210", Offset = "0x66E5C10", VA = "0x1866E7210")]
	public static IDisposable HCIPHKCDAGB(this MonoBehaviour LMILGIDOLIF, Action<float> ICMMCMPKPNB, bool LOJEHJAHEFE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x66E6E90", Offset = "0x66E5890", VA = "0x1866E6E90")]
	public static IDisposable BMMMDAOFOLP(this MonoBehaviour LMILGIDOLIF, Action<float> ICMMCMPKPNB, bool LOJEHJAHEFE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x66E7640", Offset = "0x66E6040", VA = "0x1866E7640")]
	public static IDisposable NGIOCHCOONJ(this MonoBehaviour LMILGIDOLIF, Action<float> ICMMCMPKPNB, bool LOJEHJAHEFE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x66E6FB0", Offset = "0x66E59B0", VA = "0x1866E6FB0")]
	public static IDisposable GJFEPFHPALB(this MonoBehaviour LMILGIDOLIF, Action<float> ICMMCMPKPNB, bool LOJEHJAHEFE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x66E6DE0", Offset = "0x66E57E0", VA = "0x1866E6DE0")]
	public static IDisposable BFGBBBDGBMO(this MonoBehaviour LMILGIDOLIF, float PFHMMFEKIFN, Action<float> ICMMCMPKPNB, bool LOJEHJAHEFE = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class DLCECEDEGNM
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class BKOKHNKIJCM : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private KMDFFEOBLOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public ELKCHGKMAGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private KBOBBCONPDJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public BKOKHNKIJCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x66D8980", Offset = "0x66D7380", VA = "0x1866D8980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x66D8A60", Offset = "0x66D7460", VA = "0x1866D8A60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class LKFDKOFHFOJ : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private KMDFFEOBLOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public ELKCHGKMAGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private KBOBBCONPDJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public LKFDKOFHFOJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x66EBE50", Offset = "0x66EA850", VA = "0x1866EBE50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x66EBF40", Offset = "0x66EA940", VA = "0x1866EBF40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x66DCAC0", Offset = "0x66DB4C0", VA = "0x1866DCAC0")]
	public static NEMGCHFJFIH IPACCBKPBCP(Action ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x66DCC90", Offset = "0x66DB690", VA = "0x1866DCC90")]
	public static NEMGCHFJFIH IPACCBKPBCP(Behaviour AGHGCGMHDAO, Action ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x66DCB70", Offset = "0x66DB570", VA = "0x1866DCB70")]
	public static NEMGCHFJFIH IPACCBKPBCP(Behaviour AGHGCGMHDAO, Action<float> ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x66DCDE0", Offset = "0x66DB7E0", VA = "0x1866DCDE0")]
	[IteratorStateMachine(typeof(BKOKHNKIJCM))]
	private static IEnumerator<KMDFFEOBLOI> PDNMODOKNLI(ELKCHGKMAGP CJABBIEJLGE, Action ICMMCMPKPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x66DCD50", Offset = "0x66DB750", VA = "0x1866DCD50")]
	[IteratorStateMachine(typeof(LKFDKOFHFOJ))]
	private static IEnumerator<KMDFFEOBLOI> PDNMODOKNLI(ELKCHGKMAGP CJABBIEJLGE, Action<float> ICMMCMPKPNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class IHIEPNMNIKI : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class IIALACIFMPO : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private KMDFFEOBLOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public IHIEPNMNIKI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public IIALACIFMPO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x66E5090", Offset = "0x66E3A90", VA = "0x1866E5090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x66E5120", Offset = "0x66E3B20", VA = "0x1866E5120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly ELKCHGKMAGP IACBJAAGGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action OGKAGMAJBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool IDDCGPDLMNP;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PFJBHGNAPPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x799120", Offset = "0x797B20", VA = "0x180799120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x66E4F80", Offset = "0x66E3980", VA = "0x1866E4F80")]
	public IHIEPNMNIKI(ELKCHGKMAGP IACBJAAGGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x66E4E60", Offset = "0x66E3860", VA = "0x1866E4E60")]
	[IteratorStateMachine(typeof(IIALACIFMPO))]
	private IEnumerator<KMDFFEOBLOI> CIICBCLMHHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x66E4EE0", Offset = "0x66E38E0", VA = "0x1866E4EE0", Slot = "4")]
	public void OnCompleted(Action PGAEKOGCNNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210")]
	public void CCNFEGBGCOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class GHCNDDKIPEN
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x66E24F0", Offset = "0x66E0EF0", VA = "0x1866E24F0")]
	public static IHIEPNMNIKI INLKKMKJDKM(this ELKCHGKMAGP IACBJAAGGMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class KHKNPANDDNE
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class CGOBDIHEFGK : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private KMDFFEOBLOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public EDMIODKFLLG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public CGOBDIHEFGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x66D8E30", Offset = "0x66D7830", VA = "0x1866D8E30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x66D8EB0", Offset = "0x66D78B0", VA = "0x1866D8EB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x66EA890", Offset = "0x66E9290", VA = "0x1866EA890")]
	public static NEMGCHFJFIH IPACCBKPBCP(float PFHMMFEKIFN, Action<float> ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH, bool LOJEHJAHEFE = true, [Optional] CIHNGDBCKDA AEKGMGNPGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x66EA780", Offset = "0x66E9180", VA = "0x1866EA780")]
	public static NEMGCHFJFIH IPACCBKPBCP(MonoBehaviour LMILGIDOLIF, float PFHMMFEKIFN, Action<float> ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH, bool LOJEHJAHEFE = true, [Optional] CIHNGDBCKDA AEKGMGNPGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x66EA990", Offset = "0x66E9390", VA = "0x1866EA990")]
	public static NEMGCHFJFIH MLIIHOHOJDI(MonoBehaviour LMILGIDOLIF, float PFHMMFEKIFN, Action<float> ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH, bool LOJEHJAHEFE = true, [Optional] CIHNGDBCKDA AEKGMGNPGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x66EA670", Offset = "0x66E9070", VA = "0x1866EA670")]
	public static NEMGCHFJFIH HNOIPHOEJPK(PKCMENKCIKM AGHGCGMHDAO, float PFHMMFEKIFN, Action<float> ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH, bool LOJEHJAHEFE = true, [Optional] CIHNGDBCKDA AEKGMGNPGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x66EAB40", Offset = "0x66E9540", VA = "0x1866EAB40")]
	private static IEnumerator<KMDFFEOBLOI> PDNMODOKNLI(BBOGEICDEPP PAJMNNADJDB, float PFHMMFEKIFN, ELKCHGKMAGP CJABBIEJLGE, Action<float> ICMMCMPKPNB, bool LOJEHJAHEFE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x66EA610", Offset = "0x66E9010", VA = "0x1866EA610")]
	private static IEnumerator<KMDFFEOBLOI> AKLKBFCJOMG(BBOGEICDEPP PAJMNNADJDB, float PFHMMFEKIFN, ELKCHGKMAGP CJABBIEJLGE, Action<float> ICMMCMPKPNB, bool LOJEHJAHEFE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x66EAAB0", Offset = "0x66E94B0", VA = "0x1866EAAB0")]
	[IteratorStateMachine(typeof(CGOBDIHEFGK))]
	private static IEnumerator<KMDFFEOBLOI> ODMPGEHHILP(EDMIODKFLLG GCDNCDPBLFH, float PFHMMFEKIFN, ELKCHGKMAGP CJABBIEJLGE, Action<float> ICMMCMPKPNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class EJNHDOOKGNK
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class LMHPMJLLELF : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private KMDFFEOBLOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public ELKCHGKMAGP queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public LMHPMJLLELF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x66EBF90", Offset = "0x66EA990", VA = "0x1866EBF90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x66EC050", Offset = "0x66EAA50", VA = "0x1866EC050", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x66E06C0", Offset = "0x66DF0C0", VA = "0x1866E06C0")]
	[IteratorStateMachine(typeof(LMHPMJLLELF))]
	private static IEnumerator<KMDFFEOBLOI> PDKMLLHOECI(ELKCHGKMAGP IACBJAAGGMH, Func<bool> EMNHMEGCDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x66E05A0", Offset = "0x66DEFA0", VA = "0x1866E05A0")]
	public static NEMGCHFJFIH BIMJHGEJMJA(this MonoBehaviour LMILGIDOLIF, Func<bool> EMNHMEGCDBJ, ELKCHGKMAGP IACBJAAGGMH = ELKCHGKMAGP.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class PBODPJAFEHM
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class MNAEOJHJAKC : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private KMDFFEOBLOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public ELKCHGKMAGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public MNAEOJHJAKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x66EC530", Offset = "0x66EAF30", VA = "0x1866EC530", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x66EC5A0", Offset = "0x66EAFA0", VA = "0x1866EC5A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class LCLKHIJCDDK : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private KMDFFEOBLOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public ELKCHGKMAGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private KMDFFEOBLOI <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public LCLKHIJCDDK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x66EBCB0", Offset = "0x66EA6B0", VA = "0x1866EBCB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x66EBD40", Offset = "0x66EA740", VA = "0x1866EBD40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x66EF5E0", Offset = "0x66EDFE0", VA = "0x1866EF5E0")]
	[IteratorStateMachine(typeof(MNAEOJHJAKC))]
	private static IEnumerator<KMDFFEOBLOI> CIICBCLMHHK(float GPIPKOHJNJJ, ELKCHGKMAGP CJABBIEJLGE, Action NBNCFKKHMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x66EF450", Offset = "0x66EDE50", VA = "0x1866EF450")]
	[IteratorStateMachine(typeof(LCLKHIJCDDK))]
	private static IEnumerator<KMDFFEOBLOI> BCBEEGLKJJL(float GPIPKOHJNJJ, ELKCHGKMAGP CJABBIEJLGE, Action NBNCFKKHMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x66EF820", Offset = "0x66EE220", VA = "0x1866EF820")]
	public static IDisposable HMIDBNKLOFN(this MonoBehaviour LMILGIDOLIF, float GPIPKOHJNJJ, Action NBNCFKKHMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x66EFB50", Offset = "0x66EE550", VA = "0x1866EFB50")]
	public static NEMGCHFJFIH LLKDEKJDPDG(this MonoBehaviour LMILGIDOLIF, float GPIPKOHJNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x66EF940", Offset = "0x66EE340", VA = "0x1866EF940")]
	public static NEMGCHFJFIH HMIDBNKLOFN(this MonoBehaviour LMILGIDOLIF, float GPIPKOHJNJJ, ELKCHGKMAGP CJABBIEJLGE, Action NBNCFKKHMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x66EF4F0", Offset = "0x66EDEF0", VA = "0x1866EF4F0")]
	public static NEMGCHFJFIH BDHLEEIDDOM(this MonoBehaviour LMILGIDOLIF, Action NBNCFKKHMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x66EF420", Offset = "0x66EDE20", VA = "0x1866EF420")]
	public static NEMGCHFJFIH BAEKEJCMFGF(this MonoBehaviour LMILGIDOLIF, Action NBNCFKKHMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x66EFA70", Offset = "0x66EE470", VA = "0x1866EFA70")]
	public static NEMGCHFJFIH KLFOBPDJOCJ(this MonoBehaviour LMILGIDOLIF, Action NBNCFKKHMMA, [Optional] CIHNGDBCKDA AEKGMGNPGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x66EFC10", Offset = "0x66EE610", VA = "0x1866EFC10")]
	public static NEMGCHFJFIH LMLMBADFPJM(this MonoBehaviour LMILGIDOLIF, Action NBNCFKKHMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x66EFD10", Offset = "0x66EE710", VA = "0x1866EFD10")]
	public static NEMGCHFJFIH NJNCLBHGCLC(this MonoBehaviour LMILGIDOLIF, Action NBNCFKKHMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x66EFE10", Offset = "0x66EE810", VA = "0x1866EFE10")]
	public static NEMGCHFJFIH ONCHAPIPINI(this MonoBehaviour LMILGIDOLIF, Action NBNCFKKHMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x66EFD40", Offset = "0x66EE740", VA = "0x1866EFD40")]
	private static NEMGCHFJFIH OLCOKAFBPNO(MonoBehaviour LMILGIDOLIF, ELKCHGKMAGP IACBJAAGGMH, Action NBNCFKKHMMA, [Optional] CIHNGDBCKDA AEKGMGNPGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x66EF680", Offset = "0x66EE080", VA = "0x1866EF680")]
	public static NEMGCHFJFIH EKEOPJHGJPE(this MonoBehaviour LMILGIDOLIF, float BHAGADMBJGH, Action NBNCFKKHMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x66EF750", Offset = "0x66EE150", VA = "0x1866EF750")]
	public static NEMGCHFJFIH FLBHBBHIPLD(this MonoBehaviour LMILGIDOLIF, float BHAGADMBJGH, Action NBNCFKKHMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x66EF510", Offset = "0x66EDF10", VA = "0x1866EF510")]
	public static NEMGCHFJFIH BEJBAAEINMH(this MonoBehaviour LMILGIDOLIF, float BHAGADMBJGH, Action NBNCFKKHMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x66EFC40", Offset = "0x66EE640", VA = "0x1866EFC40")]
	public static NEMGCHFJFIH NGKGAHNBELO(this MonoBehaviour LMILGIDOLIF, float BHAGADMBJGH, Action NBNCFKKHMMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class NHNJNPIANKD : LLGLDBIBNGB, IEnumerable<LLGLDBIBNGB>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<LLGLDBIBNGB> JKKLJMMMABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool LGHKGMCNGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action IOJEJOGJDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool CCBFOBPCNAL;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NAKLEKDFCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x66ED3E0", Offset = "0x66EBDE0", VA = "0x1866ED3E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BMBHPIADJIE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x66ED340", Offset = "0x66EBD40", VA = "0x1866ED340", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x66ED680", Offset = "0x66EC080", VA = "0x1866ED680", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x66ED720", Offset = "0x66EC120", VA = "0x1866ED720")]
	public NHNJNPIANKD([Optional] Action IOJEJOGJDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x66ECE70", Offset = "0x66EB870", VA = "0x1866ECE70")]
	public void DGLLAPEBOKO(LLGLDBIBNGB OPHLMPEICAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x66ED520", Offset = "0x66EBF20", VA = "0x1866ED520")]
	private void LOEEABFMHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x66ED330", Offset = "0x66EBD30", VA = "0x1866ED330", Slot = "7")]
	public bool HHAFJDABNPC(bool JAAMGDODLLF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x66ED020", Offset = "0x66EBA20", VA = "0x1866ED020", Slot = "8")]
	public bool HHAFJDABNPC(Action GMHPLHJININ, bool JAAMGDODLLF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x66ECFA0", Offset = "0x66EB9A0", VA = "0x1866ECFA0", Slot = "9")]
	public IEnumerator<LLGLDBIBNGB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x66ECFA0", Offset = "0x66EB9A0", VA = "0x1866ECFA0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class ICCBAEKEBHH : NGFNLCIAPJO
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class HHFHJPOOICD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public ICCBAEKEBHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public HHFHJPOOICD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x66E2940", Offset = "0x66E1340", VA = "0x1866E2940")]
		internal void DIFOJMGEHNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class PJCKHJOEIAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public ICCBAEKEBHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public PJCKHJOEIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x66E2940", Offset = "0x66E1340", VA = "0x1866E2940")]
		internal void KOIKKLCGGIK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float NMILCGOCFEP;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x66E4B60", Offset = "0x66E3560", VA = "0x1866E4B60")]
	public ICCBAEKEBHH(Behaviour AGHGCGMHDAO, float NMILCGOCFEP, [Optional] Action IOJEJOGJDDA, [Optional] CIHNGDBCKDA AEKGMGNPGAM, [Optional] BBOGEICDEPP PAJMNNADJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x66E4A50", Offset = "0x66E3450", VA = "0x1866E4A50", Slot = "9")]
	protected override bool KAOGEHFNIML(Action GMHPLHJININ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x66E4940", Offset = "0x66E3340", VA = "0x1866E4940", Slot = "10")]
	protected override bool HPBAHLEOBOH(Action GMHPLHJININ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface LLGLDBIBNGB
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool NAKLEKDFCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action BMBHPIADJIE;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HHAFJDABNPC(bool JAAMGDODLLF = false);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HHAFJDABNPC(Action GMHPLHJININ, bool JAAMGDODLLF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class NGFNLCIAPJO : LLGLDBIBNGB
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KAGDKLDLLBJ : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private KMDFFEOBLOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public NGFNLCIAPJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public KAGDKLDLLBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x66E9A50", Offset = "0x66E8450", VA = "0x1866E9A50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x66E9B20", Offset = "0x66E8520", VA = "0x1866E9B20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour AGHGCGMHDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action IOJEJOGJDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private MDCIDBDKHAG HMFHNGNGIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly CIHNGDBCKDA AEKGMGNPGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly BBOGEICDEPP PAJMNNADJDB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool NAKLEKDFCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xEE77B0", Offset = "0xEE61B0", VA = "0x180EE77B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BMBHPIADJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x66ECC10", Offset = "0x66EB610", VA = "0x1866ECC10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x66ECCD0", Offset = "0x66EB6D0", VA = "0x1866ECCD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x66ECD70", Offset = "0x66EB770", VA = "0x1866ECD70")]
	protected NGFNLCIAPJO(Behaviour AGHGCGMHDAO, [Optional] Action IOJEJOGJDDA, [Optional] CIHNGDBCKDA AEKGMGNPGAM, [Optional] BBOGEICDEPP PAJMNNADJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x66ECB50", Offset = "0x66EB550", VA = "0x1866ECB50", Slot = "7")]
	public bool HHAFJDABNPC(bool JAAMGDODLLF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x66ECBB0", Offset = "0x66EB5B0", VA = "0x1866ECBB0", Slot = "8")]
	public bool HHAFJDABNPC(Action GMHPLHJININ, bool JAAMGDODLLF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool KAOGEHFNIML(Action GMHPLHJININ);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool HPBAHLEOBOH(Action GMHPLHJININ);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x66ECCB0", Offset = "0x66EB6B0", VA = "0x1866ECCB0")]
	protected void MHGCCNHLJAA(Action GMHPLHJININ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x66EC880", Offset = "0x66EB280", VA = "0x1866EC880")]
	protected GOACJHIODHI EFFLBKOPEAB(float IIALIFABDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x66EC800", Offset = "0x66EB200", VA = "0x1866EC800")]
	private void CHMBBLEMCLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x66ECAC0", Offset = "0x66EB4C0", VA = "0x1866ECAC0")]
	[IteratorStateMachine(typeof(KAGDKLDLLBJ))]
	private IEnumerator<KMDFFEOBLOI> GFGHMFCHIMM(float IIALIFABDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x66EC7C0", Offset = "0x66EB1C0", VA = "0x1866EC7C0")]
	[CompilerGenerated]
	private void AIEAGPEMKOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class DNJHBPMKNJJ : NGFNLCIAPJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float DKOAEILFGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int CDAMBKIDKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float NOJIDFPNMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] MJKDCBKHBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int FLIKFHHODHK;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x66DD0F0", Offset = "0x66DBAF0", VA = "0x1866DD0F0")]
	public DNJHBPMKNJJ(Behaviour AGHGCGMHDAO, float DKAFNPHONCP, int CDAMBKIDKFJ, [Optional] Action IOJEJOGJDDA, float NOJIDFPNMJM = 0f, [Optional] CIHNGDBCKDA AEKGMGNPGAM, [Optional] BBOGEICDEPP PAJMNNADJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "9")]
	protected override bool KAOGEHFNIML(Action GMHPLHJININ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x66DCE70", Offset = "0x66DB870", VA = "0x1866DCE70", Slot = "10")]
	protected override bool HPBAHLEOBOH(Action GMHPLHJININ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x66DD070", Offset = "0x66DBA70", VA = "0x1866DD070")]
	private void KJMHKHENECO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LOMOGJDEEBN : NGFNLCIAPJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float NMILCGOCFEP;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x66E4B60", Offset = "0x66E3560", VA = "0x1866E4B60")]
	public LOMOGJDEEBN(Behaviour AGHGCGMHDAO, float NMILCGOCFEP, [Optional] Action IOJEJOGJDDA, [Optional] CIHNGDBCKDA AEKGMGNPGAM, [Optional] BBOGEICDEPP PAJMNNADJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "9")]
	protected override bool KAOGEHFNIML(Action GMHPLHJININ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x66EC0F0", Offset = "0x66EAAF0", VA = "0x1866EC0F0", Slot = "10")]
	protected override bool HPBAHLEOBOH(Action GMHPLHJININ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class NMODCBPLMIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class LOAPNOFPMDK : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private KMDFFEOBLOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public LOAPNOFPMDK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x66EBD90", Offset = "0x66EA790", VA = "0x1866EBD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x66EC0A0", Offset = "0x66EAAA0", VA = "0x1866EC0A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NEMGCHFJFIH JOHFOONLLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private PKCMENKCIKM AGHGCGMHDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> EGMOKMEJFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private ELKCHGKMAGP IACBJAAGGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float HEAHMGKFEAL;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x66EDF90", Offset = "0x66EC990", VA = "0x1866EDF90")]
	public NMODCBPLMIG(PKCMENKCIKM AGHGCGMHDAO, float PFHMMFEKIFN, Action<float> ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x66EDC40", Offset = "0x66EC640", VA = "0x1866EDC40")]
	private void IBCDLEBEODI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x66EDA60", Offset = "0x66EC460", VA = "0x1866EDA60")]
	private void EECKEFMHCKL(string BNFACNGELAB, Action LOCNPEGBGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x66EDBC0", Offset = "0x66EC5C0", VA = "0x1866EDBC0")]
	[IteratorStateMachine(typeof(LOAPNOFPMDK))]
	private IEnumerator<KMDFFEOBLOI> GOADEGPEIHB(Action LOCNPEGBGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x66EDA00", Offset = "0x66EC400", VA = "0x1866EDA00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x66EDDE0", Offset = "0x66EC7E0", VA = "0x1866EDDE0")]
	[CompilerGenerated]
	private void PAOALCJIMDH(string IMCCCAHFJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class BCGPFOKMAID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class LGGJHCNFFJF : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private KMDFFEOBLOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public LGGJHCNFFJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x66EBD90", Offset = "0x66EA790", VA = "0x1866EBD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x66EBE00", Offset = "0x66EA800", VA = "0x1866EBE00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private NEMGCHFJFIH JOHFOONLLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour LMILGIDOLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action ICMMCMPKPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> EGMOKMEJFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private ELKCHGKMAGP IACBJAAGGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float HEAHMGKFEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool LOJEHJAHEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly CIHNGDBCKDA AEKGMGNPGAM;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x66D8540", Offset = "0x66D6F40", VA = "0x1866D8540")]
	public BCGPFOKMAID(MonoBehaviour LMILGIDOLIF, Action ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH, [Optional] CIHNGDBCKDA AEKGMGNPGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x66D8300", Offset = "0x66D6D00", VA = "0x1866D8300")]
	public BCGPFOKMAID(MonoBehaviour LMILGIDOLIF, Action<float> ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH, [Optional] CIHNGDBCKDA AEKGMGNPGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x66D80B0", Offset = "0x66D6AB0", VA = "0x1866D80B0")]
	public BCGPFOKMAID(MonoBehaviour LMILGIDOLIF, float PFHMMFEKIFN, Action<float> ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH, bool LOJEHJAHEFE = true, [Optional] CIHNGDBCKDA AEKGMGNPGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x18E3930", Offset = "0x18E2330", VA = "0x1818E3930")]
	private BCGPFOKMAID(CIHNGDBCKDA AEKGMGNPGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x66D7F80", Offset = "0x66D6980", VA = "0x1866D7F80")]
	internal static BCGPFOKMAID NJJEBOIFAOG(MonoBehaviour LMILGIDOLIF, float PFHMMFEKIFN, Action<float> ICMMCMPKPNB, ELKCHGKMAGP IACBJAAGGMH, bool LOJEHJAHEFE = true, [Optional] CIHNGDBCKDA AEKGMGNPGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x66D7BC0", Offset = "0x66D65C0", VA = "0x1866D7BC0")]
	private void IPACCBKPBCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x66D74A0", Offset = "0x66D5EA0", VA = "0x1866D74A0")]
	private void BFIFPBEEGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x66D7980", Offset = "0x66D6380", VA = "0x1866D7980")]
	private void IBCDLEBEODI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x66D7D30", Offset = "0x66D6730", VA = "0x1866D7D30")]
	private void MECLOOADHAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x66D7740", Offset = "0x66D6140", VA = "0x1866D7740")]
	private void EECKEFMHCKL(string BNFACNGELAB, Action LOCNPEGBGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x66D7900", Offset = "0x66D6300", VA = "0x1866D7900")]
	[IteratorStateMachine(typeof(LGGJHCNFFJF))]
	private IEnumerator<KMDFFEOBLOI> GOADEGPEIHB(Action LOCNPEGBGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x66D76E0", Offset = "0x66D60E0", VA = "0x1866D76E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x66D7650", Offset = "0x66D6050", VA = "0x1866D7650")]
	[CompilerGenerated]
	private void DFKFEMBKKII(string IMCCCAHFJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x66D7870", Offset = "0x66D6270", VA = "0x1866D7870")]
	[CompilerGenerated]
	private void FKIPJNLLOKI(string IMCCCAHFJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x66D7EF0", Offset = "0x66D68F0", VA = "0x1866D7EF0")]
	[CompilerGenerated]
	private void MMCBBFEFDAJ(string IMCCCAHFJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x66D7B30", Offset = "0x66D6530", VA = "0x1866D7B30")]
	[CompilerGenerated]
	private void IIJOGCPAPGF(string IMCCCAHFJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum CFGGHHFIHEJ : byte
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
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal sealed class IONPPIDHDFJ : BBOGEICDEPP
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float FICDAJEHFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x66E6B30", Offset = "0x66E5530", VA = "0x1866E6B30", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float CALMNLMMBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x66E6BD0", Offset = "0x66E55D0", VA = "0x1866E6BD0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double HLJPFHIOKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x66E6BB0", Offset = "0x66E55B0", VA = "0x1866E6BB0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x66E6B40", Offset = "0x66E5540", VA = "0x1866E6B40")]
	[BBBFDPEBAMC(HLEKCCEDPHP.None)]
	private static void EBIMMENNAAG(AFDLAPABCDH DFLLKHNKNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	[Preserve]
	internal IONPPIDHDFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface KOEJHECFPKF
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMDCFMHIPLO(string CDHDOGOGPME);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNCDNADANPN();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface MLAOLHPHHBE
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string JHMJHFOLNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool ILFJJNBKGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool CIPDMMGBJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class JDDMLLKMAEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public ECLBPLNGOJL PCGIIEJIDCF;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int AMPNEGOJBEN
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x78E180", Offset = "0x78CB80", VA = "0x18078E180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7965B0", Offset = "0x794FB0", VA = "0x1807965B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x66E7840", Offset = "0x66E6240", VA = "0x1866E7840")]
	public static KMDFFEOBLOI GCOLDNAEKAK(IEnumerator<KMDFFEOBLOI> OBGGLDNAIJA, BECMADGKCFC FGDCNGGOLDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x66E7780", Offset = "0x66E6180", VA = "0x1866E7780")]
	public KMDFFEOBLOI GCOLDNAEKAK(BECMADGKCFC[] EHDNPCPKAIJ, IEnumerator<KMDFFEOBLOI>[] JENPLOBHHII, KMDFFEOBLOI[] MOJLAMCKPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x66E79A0", Offset = "0x66E63A0", VA = "0x1866E79A0")]
	public void KKIFDLKKKDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x66E7B10", Offset = "0x66E6510", VA = "0x1866E7B10")]
	public void OADFBFOJODO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x66E79D0", Offset = "0x66E63D0", VA = "0x1866E79D0")]
	public void KINEPCNNMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x66E79A0", Offset = "0x66E63A0", VA = "0x1866E79A0")]
	public void HMDKBDOMAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public JDDMLLKMAEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class ECLBPLNGOJL
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct HDMGPGJBGEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public JDDMLLKMAEP FHACEFOGPEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public PKCMENKCIKM MPEFAFCBBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public BECMADGKCFC MOIOOGKCPPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<KMDFFEOBLOI> LHGGMCOLLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public KMDFFEOBLOI LIEAJEJBCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public CFGGHHFIHEJ NFOPJODEFPF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct NBKELPANCLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public ELKCHGKMAGP CPDKJKJBMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<HDMGPGJBGEK> HCMBLMLJHOA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class KCJNADCCEKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public BECMADGKCFC promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public ECLBPLNGOJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public PKCMENKCIKM context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public JDDMLLKMAEP routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CFGGHHFIHEJ coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public KMDFFEOBLOI currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<KMDFFEOBLOI> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public KCJNADCCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x66E9B70", Offset = "0x66E8570", VA = "0x1866E9B70")]
		internal void DJHEMJAMMOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class NIEHGJILALK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public JDDMLLKMAEP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public ECLBPLNGOJL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public NIEHGJILALK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x66ED7C0", Offset = "0x66EC1C0", VA = "0x1866ED7C0")]
		internal void MLGBBCAMJJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class ONCOJOHFJOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public JDDMLLKMAEP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public ECLBPLNGOJL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public ONCOJOHFJOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x66EF060", Offset = "0x66EDA60", VA = "0x1866EF060")]
		internal void FCIAJNIPNAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class HCDLFNPBOHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public JDDMLLKMAEP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public ECLBPLNGOJL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public HCDLFNPBOHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x66E28A0", Offset = "0x66E12A0", VA = "0x1866E28A0")]
		internal void JNGKGNCMCAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const CFGGHHFIHEJ LIMJPBCFBBL = CFGGHHFIHEJ.Cancelled | CFGGHHFIHEJ.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly ELKCHGKMAGP IACBJAAGGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] NIMHPLLKOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<CFGGHHFIHEJ> GAEAFLEIEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> FMCEEHAPNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> NMNHEGPJDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> FFPHEGNJEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> GGACEKPKNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> DDIJJAMLMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> KBPMJIHELNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private JDDMLLKMAEP[] JDIKKAPKENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private BECMADGKCFC[] EHDNPCPKAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private PKCMENKCIKM[] NGDCAEJHFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<KMDFFEOBLOI>[] PFIENALLPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private KMDFFEOBLOI[] KLEEOFOHJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int FGDIABPODFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int HCAPAJGPPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int DKJNPDECMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float IKEKGLGGKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private HHONDLAGFLA NNCCDJLEEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle CMABMBFCEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<JDDMLLKMAEP> PGJPNHLAAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool JFNLOJBEOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> HALCBKIDBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> ACEIDHKHNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool JIPDFPGDIFP;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public NBKELPANCLC[] AFAHBHPGMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x995F80", Offset = "0x994980", VA = "0x180995F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x66DDC60", Offset = "0x66DC660", VA = "0x1866DDC60")]
	private static int GOJIKIMCCOC(ELKCHGKMAGP IACBJAAGGMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x66DF5F0", Offset = "0x66DDFF0", VA = "0x1866DF5F0")]
	public ECLBPLNGOJL(ELKCHGKMAGP IACBJAAGGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x66DF0A0", Offset = "0x66DDAA0", VA = "0x1866DF0A0")]
	private void OPEEEONEJKA(int LPGGLBIDCMC, int FCBJAEPFPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x66DD740", Offset = "0x66DC140", VA = "0x1866DD740")]
	public void EKNODFICEDD(PKCMENKCIKM AGHGCGMHDAO, KMDFFEOBLOI OMNALIPHFJL, IEnumerator<KMDFFEOBLOI> OBGGLDNAIJA, BECMADGKCFC FGDCNGGOLDM, [Optional] JDDMLLKMAEP HPCHAPNACGM, CFGGHHFIHEJ GPEGOBJJLKK = CFGGHHFIHEJ.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x66DDC90", Offset = "0x66DC690", VA = "0x1866DDC90")]
	public void HCCAAAAGJHH(IEnumerable<HDMGPGJBGEK> GEICKIFCIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x66DE8B0", Offset = "0x66DD2B0", VA = "0x1866DE8B0")]
	private HDMGPGJBGEK NEENAMCLKKL(int FPNDIGPMIHH)
	{
		return default(HDMGPGJBGEK);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x66DF280", Offset = "0x66DDC80", VA = "0x1866DF280")]
	private void PHMDHGLALLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x249FDE0", Offset = "0x249E7E0", VA = "0x18249FDE0")]
	private static void HNPJNBDPICF<T>(int FPNDIGPMIHH, T[] LONCKIJIJBH, int DDIMFHFNGHG, [Optional] T PELCLPAACAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x249FE30", Offset = "0x249E830", VA = "0x18249FE30")]
	private static void HNPJNBDPICF<T>(int FPNDIGPMIHH, NativeArray<T> LONCKIJIJBH, int DDIMFHFNGHG, [Optional] T PELCLPAACAB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x66DD8C0", Offset = "0x66DC2C0", VA = "0x1866DD8C0")]
	private void FBMBJLNDLPN(IEnumerable<HDMGPGJBGEK> GEICKIFCIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x66DED80", Offset = "0x66DD780", VA = "0x1866DED80")]
	private void NKOJNGMHOKI(HDMGPGJBGEK HMKGLKCGNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x66DEE40", Offset = "0x66DD840", VA = "0x1866DEE40")]
	private EGKJMPFCCAJ OLLNFJHOFOA(int DEAMMCIEFEC)
	{
		return default(EGKJMPFCCAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x66DD290", Offset = "0x66DBC90", VA = "0x1866DD290")]
	public void AAMEEPMLNBK(float OAHMJLCAOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x66DD5C0", Offset = "0x66DBFC0", VA = "0x1866DD5C0")]
	private void BLDPIFPHOAG(Action PJHMDOOMOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x66DE830", Offset = "0x66DD230", VA = "0x1866DE830")]
	private void MAOECHOFAOG(Action PJHMDOOMOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x66DE130", Offset = "0x66DCB30", VA = "0x1866DE130")]
	public void LNDJJMOEGIF(float OAHMJLCAOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x66DD640", Offset = "0x66DC040", VA = "0x1866DD640")]
	public void BODCNAJIBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x66DE000", Offset = "0x66DCA00", VA = "0x1866DE000")]
	public void HMDKBDOMAAE(JDDMLLKMAEP GCDNCDPBLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x66DDED0", Offset = "0x66DC8D0", VA = "0x1866DDED0")]
	public void HEDLMAAPLGL(JDDMLLKMAEP GCDNCDPBLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x66DD490", Offset = "0x66DBE90", VA = "0x1866DD490")]
	public void BFLLMOPPCNH(JDDMLLKMAEP GCDNCDPBLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GBBINECOCPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly GBBINECOCPA DPEMCFFPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action NLIMNMBLDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool KFPLPOJFILA;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
	public GBBINECOCPA(Action NLIMNMBLDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x605A610", Offset = "0x6059010", VA = "0x18605A610", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface ELOMKJENNGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T BMLGNHJJEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable LOEMBNKENCK(UnityEngine.Object AGHGCGMHDAO, Action<T> KLNIPGMMPMO);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface AHCAAFADLJG<T> : ELOMKJENNGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T BMLGNHJJEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class IHGFIMIEKFE<T> : AHCAAFADLJG<T>, ELOMKJENNGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class CDMBDELKEJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public IHGFIMIEKFE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public NOOLFONLJNE<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public CDMBDELKEJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4AF9D70", Offset = "0x4AF8770", VA = "0x184AF9D70")]
		internal void ICMFJBFLKDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject IAJKEFDADFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<NOOLFONLJNE<UnityEngine.Object, Action<T>>> IBAJPINLNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T NBFFKFCDMNA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T BMLGNHJJEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8113D0", Offset = "0x80FDD0", VA = "0x1808113D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x382F610", Offset = "0x382E010", VA = "0x18382F610", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3830040", Offset = "0x382EA40", VA = "0x183830040")]
	private static bool ONGNPFDFOAO(T PJHMDOOMOBI, T OIKFNBPLIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3830110", Offset = "0x382EB10", VA = "0x183830110")]
	public IHGFIMIEKFE(T BEJAAJOBKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x382F820", Offset = "0x382E220", VA = "0x18382F820", Slot = "6")]
	public IDisposable LOEMBNKENCK(UnityEngine.Object AGHGCGMHDAO, Action<T> KLNIPGMMPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x382FCE0", Offset = "0x382E6E0", VA = "0x18382FCE0")]
	private void OJLINLAJIMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class CGGLCCAEPAP : JMHGKJBLMPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly CIHNGDBCKDA AEKGMGNPGAM;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x66D8D10", Offset = "0x66D7710", VA = "0x1866D8D10")]
	[BBBFDPEBAMC(HLEKCCEDPHP.None)]
	private static void EBIMMENNAAG(AFDLAPABCDH DFLLKHNKNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
	[Preserve]
	internal CGGLCCAEPAP([KNBPONIPMPA(null)] CIHNGDBCKDA AEKGMGNPGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x66D8D80", Offset = "0x66D7780", VA = "0x1866D8D80", Slot = "4")]
	public IDisposable PBKKOIBJJAM(float PFHMMFEKIFN, Action<float> MKEOIOPNPIL, bool LOJEHJAHEFE = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class NPCPKLCMFNG : HKIFGCMGAMP, CIHNGDBCKDA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private ECLBPLNGOJL[] HMICJDGPPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private KOEJHECFPKF KOPDCKHEDEN;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x66EE8C0", Offset = "0x66ED2C0", VA = "0x1866EE8C0")]
	[BBBFDPEBAMC(HLEKCCEDPHP.None)]
	private static void EBIMMENNAAG(AFDLAPABCDH DFLLKHNKNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x66EEDA0", Offset = "0x66ED7A0", VA = "0x1866EEDA0")]
	[Preserve]
	public NPCPKLCMFNG([KNBPONIPMPA(null)] GOIIOKPNLBM JNLCFKPACJG, [KNBPONIPMPA(null)] BBOGEICDEPP PAJMNNADJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x66EEC70", Offset = "0x66ED670", VA = "0x1866EEC70", Slot = "16")]
	public override NEMGCHFJFIH KPLHOPGBALN(PKCMENKCIKM AGHGCGMHDAO, IEnumerator<KMDFFEOBLOI> CFNMAEBIJCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x66EE9E0", Offset = "0x66ED3E0", VA = "0x1866EE9E0", Slot = "17")]
	public override void JGPBMMKLMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x66EE690", Offset = "0x66ED090", VA = "0x1866EE690", Slot = "19")]
	public override void EACJPNODJOF(ELKCHGKMAGP IACBJAAGGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x66EE170", Offset = "0x66ECB70", VA = "0x1866EE170", Slot = "18")]
	protected override void ADFCFFECPNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x66EE930", Offset = "0x66ED330", VA = "0x1866EE930")]
	private ECLBPLNGOJL EMAOJPPHBHJ(ELKCHGKMAGP AKDFFJNHJJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x66EE400", Offset = "0x66ECE00", VA = "0x1866EE400", Slot = "20")]
	internal override BAAODKLIPNE DIEIFOCDLNA(IEnumerator<KMDFFEOBLOI> CFNMAEBIJCK, Behaviour AGHGCGMHDAO, BECMADGKCFC FGDCNGGOLDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x66EE960", Offset = "0x66ED360", VA = "0x1866EE960", Slot = "21")]
	internal override IIECOBACFOA FIEEBJAHHKJ(ELKCHGKMAGP CJABBIEJLGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x66EE2E0", Offset = "0x66ECCE0", VA = "0x1866EE2E0")]
	private void CAACDIOHMOA(ECLBPLNGOJL POMMFBCHECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x66EE630", Offset = "0x66ED030", VA = "0x1866EE630", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct HHONDLAGFLA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float BKDJEEPJBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int JENNDOOFCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> IAIAFKKEPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> AOJOGHEDODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> KJFFEOKNLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<CFGGHHFIHEJ> JMNJMPIEDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> PKBODKKFHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> GGACEKPKNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> NMNHEGPJDLB;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x66E2C80", Offset = "0x66E1680", VA = "0x1866E2C80")]
	public static HHONDLAGFLA CMMJGECCMDN(int EBOEOJNAEOF, float OAHMJLCAOEG, NativeArray<CFGGHHFIHEJ> MIKGJMCCNOL, NativeArray<float> BAJEHCJMNBA, NativeArray<int> PHCKAFJLLNF, NativeArray<int> DAOHHECNBBO, NativeArray<int> NPEIJPNHJOO, NativeArray<int> AOJOGHEDODG, NativeArray<int> KJFFEOKNLAP)
	{
		return default(HHONDLAGFLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x66E2D10", Offset = "0x66E1710", VA = "0x1866E2D10", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x66E2DF0", Offset = "0x66E17F0", VA = "0x1866E2DF0")]
	private bool FFNOBOJPLJK(int BNALCEABILL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x66E2CE0", Offset = "0x66E16E0", VA = "0x1866E2CE0")]
	private void EPOOKOCMDCC(NativeArray<int> PDKNOJBNIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x66E2E30", Offset = "0x66E1830", VA = "0x1866E2E30")]
	private int HOBOOACBIGH(int MGMIOJEMPJA, int IBCIEDCIHGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x66E2970", Offset = "0x66E1370", VA = "0x1866E2970")]
	private void AOMFEPILGJG(NativeArray<int> PDKNOJBNIFO, int DCGHDPIGGMM, int HJICGNIAELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x66E2A40", Offset = "0x66E1440", VA = "0x1866E2A40")]
	private void CICBMCFFHHL(NativeArray<int> PDKNOJBNIFO, int AMCHLBNBMGH, int EPIJPIEELIL, int BEJIDFPCPOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class HKIFGCMGAMP : CIHNGDBCKDA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly GOIIOKPNLBM JNLCFKPACJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly BBOGEICDEPP PAJMNNADJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private IIECOBACFOA[] ANAJHKDKMHF;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static CIHNGDBCKDA KHPIFBDMEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x66E3D40", Offset = "0x66E2740", VA = "0x1866E3D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool NDGHBLBODDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7AA930", Offset = "0x7A9330", VA = "0x1807AA930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ELKCHGKMAGP NFDNPBEPKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x78E180", Offset = "0x78CB80", VA = "0x18078E180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(ELKCHGKMAGP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7965B0", Offset = "0x794FB0", VA = "0x1807965B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public BBOGEICDEPP IHKGFAGPABF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public KMDFFEOBLOI GFAMABKLOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x66E31B0", Offset = "0x66E1BB0", VA = "0x1866E31B0")]
	public static NEMGCHFJFIH DLMGFCNMFCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x66E3E10", Offset = "0x66E2810", VA = "0x1866E3E10")]
	[Preserve]
	protected HKIFGCMGAMP([KNBPONIPMPA(null)] GOIIOKPNLBM JNLCFKPACJG, [KNBPONIPMPA(null)] BBOGEICDEPP PAJMNNADJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x66E3890", Offset = "0x66E2290", VA = "0x1866E3890", Slot = "6")]
	public NEMGCHFJFIH EELKFHOIADO(IEnumerator<KMDFFEOBLOI> CFNMAEBIJCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x66E3690", Offset = "0x66E2090", VA = "0x1866E3690", Slot = "7")]
	public NEMGCHFJFIH EELKFHOIADO(Behaviour AGHGCGMHDAO, IEnumerator<KMDFFEOBLOI> CFNMAEBIJCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract NEMGCHFJFIH KPLHOPGBALN(PKCMENKCIKM AGHGCGMHDAO, IEnumerator<KMDFFEOBLOI> CFNMAEBIJCK);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x66E3B00", Offset = "0x66E2500", VA = "0x1866E3B00", Slot = "17")]
	public virtual void JGPBMMKLMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x66E38C0", Offset = "0x66E22C0", VA = "0x1866E38C0", Slot = "9")]
	public void HDEHEOEJKJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x66E30A0", Offset = "0x66E1AA0", VA = "0x1866E30A0", Slot = "18")]
	protected virtual void ADFCFFECPNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x66E3DF0", Offset = "0x66E27F0", VA = "0x1866E3DF0")]
	private void PCFGDIAMKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x66E3CA0", Offset = "0x66E26A0", VA = "0x1866E3CA0")]
	private void KIMGIANNLJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x66E30C0", Offset = "0x66E1AC0", VA = "0x1866E30C0")]
	private void AOAHONMAAIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x66E30E0", Offset = "0x66E1AE0", VA = "0x1866E30E0")]
	private void CBMAMNPMDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x66E3CC0", Offset = "0x66E26C0", VA = "0x1866E3CC0")]
	private void KPIGKGGHJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x66E38A0", Offset = "0x66E22A0", VA = "0x1866E38A0")]
	private void EHEMHNMEABE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x66E3190", Offset = "0x66E1B90", VA = "0x1866E3190")]
	private void DHCDBCMFJGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x66E3600", Offset = "0x66E2000", VA = "0x1866E3600", Slot = "19")]
	public virtual void EACJPNODJOF(ELKCHGKMAGP IACBJAAGGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x66E2ED0", Offset = "0x66E18D0", VA = "0x1866E2ED0")]
	private void AAFDNGIFEPJ(IIECOBACFOA POMMFBCHECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1C3CC40", Offset = "0x1C3B640", VA = "0x181C3CC40")]
	private IIECOBACFOA FNLKDMCEOAJ(ELKCHGKMAGP AKDFFJNHJJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract BAAODKLIPNE DIEIFOCDLNA(IEnumerator<KMDFFEOBLOI> CFNMAEBIJCK, Behaviour LMILGIDOLIF, BECMADGKCFC GLEIJNPNKLJ);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract IIECOBACFOA FIEEBJAHHKJ(ELKCHGKMAGP IACBJAAGGMH);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x66E3240", Offset = "0x66E1C40", VA = "0x1866E3240", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x66E3D90", Offset = "0x66E2790", VA = "0x1866E3D90", Slot = "12")]
	public KMDFFEOBLOI NBOPBJOIPCO(ELKCHGKMAGP CJABBIEJLGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x66E3100", Offset = "0x66E1B00", VA = "0x1866E3100", Slot = "13")]
	public KMDFFEOBLOI CLBCJEJDGDC(float GPIPKOHJNJJ, ELKCHGKMAGP CJABBIEJLGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x66E3CE0", Offset = "0x66E26E0", VA = "0x1866E3CE0", Slot = "14")]
	public KMDFFEOBLOI LBDCBJAMPGO(Func<bool> EMNHMEGCDBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class BAAODKLIPNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly BECMADGKCFC FGDCNGGOLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly MLAOLHPHHBE AGHGCGMHDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool BKGBNLEIAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string CDHDOGOGPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private StackTrace JBMCAKEBHFN;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<KMDFFEOBLOI> LHGGMCOLLEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x790420", Offset = "0x78EE20", VA = "0x180790420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public KMDFFEOBLOI LIEAJEJBCJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x790C90", Offset = "0x78F690", VA = "0x180790C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool KPFCELNIAMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x66D6840", Offset = "0x66D5240", VA = "0x1866D6840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool BCHNLNFLIGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8060A0", Offset = "0x804AA0", VA = "0x1808060A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8060B0", Offset = "0x804AB0", VA = "0x1808060B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string JHMJHFOLNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x66D68C0", Offset = "0x66D52C0", VA = "0x1866D68C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float NKGBGHHKBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x1066E80", Offset = "0x1065880", VA = "0x181066E80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x55FEC10", Offset = "0x55FD610", VA = "0x1855FEC10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x66D6B50", Offset = "0x66D5550", VA = "0x1866D6B50")]
	public BAAODKLIPNE(IEnumerator<KMDFFEOBLOI> OBGGLDNAIJA, MLAOLHPHHBE AGHGCGMHDAO, BECMADGKCFC FGDCNGGOLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x66D6470", Offset = "0x66D4E70", VA = "0x1866D6470")]
	public KMDFFEOBLOI GCOLDNAEKAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x66D6780", Offset = "0x66D5180", VA = "0x1866D6780")]
	public bool HIKJBCMNHPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x66D67F0", Offset = "0x66D51F0", VA = "0x1866D67F0")]
	public void HMDKBDOMAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x66D6A70", Offset = "0x66D5470", VA = "0x1866D6A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x87D4B0", Offset = "0x87BEB0", VA = "0x18087D4B0")]
	[CompilerGenerated]
	private void GPNDJNICJKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class BECMADGKCFC : IHBLHONKOGF, NEMGCHFJFIH, MDCIDBDKHAG, GOACJHIODHI, IEnumerator, KMDFFEOBLOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private ELKCHGKMAGP IDGJFFGEJKG;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private ELKCHGKMAGP EIGEFPKJJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xDE4060", Offset = "0xDE2A60", VA = "0x180DE4060", Slot = "23")]
		get
		{
			return default(ELKCHGKMAGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public ELKCHGKMAGP PCGIIEJIDCF
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x12E4C40", Offset = "0x12E3640", VA = "0x1812E4C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float ENAHBNHFENI
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D40", Offset = "0x7E0740", VA = "0x1807E1D40", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool AGJLMFGKNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x66D8910", Offset = "0x66D7310", VA = "0x1866D8910", Slot = "24")]
	private bool EDGCFEGIBJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x66D8900", Offset = "0x66D7300", VA = "0x1866D8900", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x66D8930", Offset = "0x66D7330", VA = "0x1866D8930")]
	public BECMADGKCFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum EGKJMPFCCAJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class IIECOBACFOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum BBFPBDJNJHA
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct DAICIJGFMGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public ELKCHGKMAGP CPDKJKJBMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public BBFPBDJNJHA OMEHGFCGBPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public List<BAAODKLIPNE> DAIGIGGMEJE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly BBFPBDJNJHA[] DCCEMLLHHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly ELKCHGKMAGP IACBJAAGGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private bool FBPIPIGCAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly BAAODKLIPNE[] EJDGIGPNGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<BAAODKLIPNE> EKLILFAPCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> EFIBOKKMBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<BAAODKLIPNE> EPCLLGAAKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<int> BAFGMEMDMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly KOEJHECFPKF AGFBILKEGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private bool JIPDFPGDIFP;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public DAICIJGFMGD[,] FGFBCFPJCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7976F0", Offset = "0x7960F0", VA = "0x1807976F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x66E6690", Offset = "0x66E5090", VA = "0x1866E6690")]
	public IIECOBACFOA(ELKCHGKMAGP CJABBIEJLGE, KOEJHECFPKF AGFBILKEGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x66E55A0", Offset = "0x66E3FA0", VA = "0x1866E55A0")]
	public void DJGAILLBDAE(BAAODKLIPNE OBGGLDNAIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x66E5BB0", Offset = "0x66E45B0", VA = "0x1866E5BB0")]
	public void FHJFFCALPGC(IList<BAAODKLIPNE> JENPLOBHHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x66E60B0", Offset = "0x66E4AB0", VA = "0x1866E60B0")]
	public void PIFBHKBIPOD(IList<BAAODKLIPNE> JENPLOBHHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x66E56A0", Offset = "0x66E40A0", VA = "0x1866E56A0")]
	private void DLKKFOCMOKH(BAAODKLIPNE OBGGLDNAIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x66E63C0", Offset = "0x66E4DC0", VA = "0x1866E63C0")]
	private void PNOCACDJAMH(IList<BAAODKLIPNE> JENPLOBHHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x66E52E0", Offset = "0x66E3CE0", VA = "0x1866E52E0")]
	private EGKJMPFCCAJ CFCHBBKJCAJ(BAAODKLIPNE OBGGLDNAIJA)
	{
		return default(EGKJMPFCCAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x66E5170", Offset = "0x66E3B70", VA = "0x1866E5170")]
	public void ADFCFFECPNL(float OAHMJLCAOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x66E5EC0", Offset = "0x66E48C0", VA = "0x1866E5EC0")]
	public void HDEHEOEJKJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x66E58B0", Offset = "0x66E42B0", VA = "0x1866E58B0")]
	private void EPECAGKBGDL(List<BAAODKLIPNE> JENPLOBHHII, Stack<int> GOLLLMBPMKN, bool NADCMBNNGNP, float MJHICODMCKD = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x66E5790", Offset = "0x66E4190", VA = "0x1866E5790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x66E5460", Offset = "0x66E3E60", VA = "0x1866E5460")]
	private void DEJHADGKFNK(List<BAAODKLIPNE> JENPLOBHHII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class KBLNGKCPBGK : KOEJHECFPKF
{
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "4")]
	public void NMDCFMHIPLO(string CDHDOGOGPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
	public void CNCDNADANPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public KBLNGKCPBGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class KEOKIBPKPCA : MLAOLHPHHBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Behaviour LMILGIDOLIF;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string JHMJHFOLNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x66EA340", Offset = "0x66E8D40", VA = "0x1866EA340", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool ILFJJNBKGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x66EA3C0", Offset = "0x66E8DC0", VA = "0x1866EA3C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool CIPDMMGBJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x66EA320", Offset = "0x66E8D20", VA = "0x1866EA320", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
	public KEOKIBPKPCA(Behaviour LMILGIDOLIF)
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
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
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7823FF0", Offset = "0x7822FF0", VA = "0x187823FF0", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private delegate List<PlayerLoopSystem> CEPAJIEKOOG(List<PlayerLoopSystem> CDALDJLEACG, int IALIHGGNEDN);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct FKOKBNGKAIO
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct FLAKIBGGIAG
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static GDBINPMHEFP HMAGEEPEFGM;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x7814690", Offset = "0x7813690", VA = "0x187814690")]
				public static PlayerLoopSystem ONHMCPLHOLC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct IFDGGFBDPJG
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static GDBINPMHEFP IKKLONEKFON;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x7818E40", Offset = "0x7817E40", VA = "0x187818E40")]
				public static PlayerLoopSystem ONHMCPLHOLC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct AKMJKBBIHLA
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static GDBINPMHEFP DPFPJCAJPJJ;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x7808380", Offset = "0x7807380", VA = "0x187808380")]
				public static PlayerLoopSystem ONHMCPLHOLC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct GHOLKLPGAJM
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static GDBINPMHEFP DKCEIABBJFF;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static GDBINPMHEFP EBLKOGMMLHA;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static GDBINPMHEFP LJPGFPCBGOB;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static GDBINPMHEFP PDLEFGALHLH;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x78164B0", Offset = "0x78154B0", VA = "0x1878164B0")]
				public static PlayerLoopSystem ONHMCPLHOLC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct DAJLCEECPAC
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static GDBINPMHEFP LMKPPLEAHJP;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x78107E0", Offset = "0x780F7E0", VA = "0x1878107E0")]
				public static PlayerLoopSystem ONHMCPLHOLC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct DEKGECEKKNA
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static GDBINPMHEFP DKCEIABBJFF;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static GDBINPMHEFP EBLKOGMMLHA;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static GDBINPMHEFP LJPGFPCBGOB;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static GDBINPMHEFP PDLEFGALHLH;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x7810BA0", Offset = "0x780FBA0", VA = "0x187810BA0")]
				public static PlayerLoopSystem ONHMCPLHOLC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct DEPDEIFOEBB
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static GDBINPMHEFP BBGCODGNGCO;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x7810E70", Offset = "0x780FE70", VA = "0x187810E70")]
				public static PlayerLoopSystem ONHMCPLHOLC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct DBEEJDCEFNA
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static GDBINPMHEFP BFBFDFBNCJG;

				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x78109C0", Offset = "0x780F9C0", VA = "0x1878109C0")]
				public static PlayerLoopSystem ONHMCPLHOLC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct BCHKKMHBCPL
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static GDBINPMHEFP IOPGCFJINID;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x78091B0", Offset = "0x78081B0", VA = "0x1878091B0")]
				public static PlayerLoopSystem ONHMCPLHOLC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct GLHGCFDCKOK
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static GDBINPMHEFP BOCKECANJBL;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x7816780", Offset = "0x7815780", VA = "0x187816780")]
				public static PlayerLoopSystem ONHMCPLHOLC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct LLGNMACDDEP
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static GDBINPMHEFP NPIPFABCLGB;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x781B680", Offset = "0x781A680", VA = "0x18781B680")]
				public static PlayerLoopSystem ONHMCPLHOLC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct IBINAFADEHN
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static GDBINPMHEFP MKMKAAEOMEL;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x7817570", Offset = "0x7816570", VA = "0x187817570")]
				public static PlayerLoopSystem ONHMCPLHOLC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct FCGIADOGFJM
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static GDBINPMHEFP BOFJBLKIGGB;

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x7813DF0", Offset = "0x7812DF0", VA = "0x187813DF0")]
				public static PlayerLoopSystem ONHMCPLHOLC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum NPGBAKANKCN : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct HLFHILHGHLF
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class KJPHLOCMBMA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public NPGBAKANKCN updateStage;

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
					public KJPHLOCMBMA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x781B0C0", Offset = "0x781A0C0", VA = "0x18781B0C0")]
					internal void BJJPGEALCPF()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static JFMBBHOLPOC<NPGBAKANKCN> CNMOHLMLOMA;

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x7816EB0", Offset = "0x7815EB0", VA = "0x187816EB0")]
				public static PlayerLoopSystem ONHMCPLHOLC(NPGBAKANKCN NOBDIFDEIED)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			internal struct PJIADMGDAHL
			{
				[Cpp2IlInjected.Token(Token = "0x2000024")]
				[CompilerGenerated]
				private sealed class LPKCIADBHMB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public APLFFFBKPON.MLFFHDINGKI key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
					public LPKCIADBHMB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x781B860", Offset = "0x781A860", VA = "0x18781B860")]
					internal void FMIFAHGHFCL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable LHNJEPEELFB;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x7821D20", Offset = "0x7820D20", VA = "0x187821D20")]
				public static PlayerLoopSystem ANLALALHHHA(APLFFFBKPON.MLFFHDINGKI MLAECOMLIEC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			internal struct OIPCOPPLLGF
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class PIDFHEHCDKO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public APLFFFBKPON.MLFFHDINGKI key;

					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
					public PIDFHEHCDKO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0x7821A70", Offset = "0x7820A70", VA = "0x187821A70")]
					internal void FMIFAHGHFCL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x7821940", Offset = "0x7820940", VA = "0x187821940")]
				public static PlayerLoopSystem ANLALALHHHA(APLFFFBKPON.MLFFHDINGKI MLAECOMLIEC)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class ANKKBCHGJBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public ANKKBCHGJBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7808560", Offset = "0x7807560", VA = "0x187808560")]
			internal List<PlayerLoopSystem> JMDGOOHDMOE(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool HABOAFBGGAH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool FJLPFFHIOCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x78107A0", Offset = "0x780F7A0", VA = "0x1878107A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x780CB60", Offset = "0x780BB60", VA = "0x18780CB60")]
		private static void BHIAIIFHOFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x780F6B0", Offset = "0x780E6B0", VA = "0x18780F6B0")]
		private static void DNMEPLKNMLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x780CB20", Offset = "0x780BB20", VA = "0x18780CB20")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x780FFC0", Offset = "0x780EFC0", VA = "0x18780FFC0")]
		private static void GIIHNONBKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7810200", Offset = "0x780F200", VA = "0x187810200")]
		private static void IHNAHJKLOEL(APLFFFBKPON.MLFFHDINGKI MLAECOMLIEC, PlayerLoopSystem DFNAPLNCENB, Type KGBNOMAIBEL, Type EJODHLOLFND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x78103C0", Offset = "0x780F3C0", VA = "0x1878103C0")]
		private static void JBCFMJKFEBH(PlayerLoopSystem DFNAPLNCENB, Type KGBNOMAIBEL, Type EJODHLOLFND, CEPAJIEKOOG BFKOOKDCCAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x780C9F0", Offset = "0x780B9F0", VA = "0x18780C9F0")]
		private static void ADAOPBGAEHM(PlayerLoopSystem DFNAPLNCENB, Type KGBNOMAIBEL, Type EJODHLOLFND, PlayerLoopSystem? OIPDNBGMPLA, PlayerLoopSystem? OFAABLHDLAN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class APLFFFBKPON
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum MLFFHDINGKI
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		OMPrePhysicsFixedUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class ECCJALDOIEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly MLFFHDINGKI IBAAIHAMPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly FNFAJLDONCJ HEKNJFLKANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private long JJJEHGJPLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long INDFCAPBEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long KHAFKFOJPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int JBHLNMOKIHD;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7812CA0", Offset = "0x7811CA0", VA = "0x187812CA0")]
		public ECCJALDOIEJ(MLFFHDINGKI JGMOJGOIAAL, int HOGIFBNJCNE = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7812C30", Offset = "0x7811C30", VA = "0x187812C30")]
		public void NIOCGFCMOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7812A00", Offset = "0x7811A00", VA = "0x187812A00")]
		public void IAKCKKFMPGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7812A50", Offset = "0x7811A50", VA = "0x187812A50")]
		public void IGLPGEIHIOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static MLFFHDINGKI[] NPAOHIALNKA;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ECCJALDOIEJ[] LLFMMPPCEOI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7808DA0", Offset = "0x7807DA0", VA = "0x187808DA0")]
	public static ECCJALDOIEJ EMDOJNGPKFN(MLFFHDINGKI MLAECOMLIEC, int HOGIFBNJCNE = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7808D30", Offset = "0x7807D30", VA = "0x187808D30")]
	public static ECCJALDOIEJ BPGPHHOHKGG(MLFFHDINGKI MLAECOMLIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7808F80", Offset = "0x7807F80", VA = "0x187808F80")]
	public static void KHNKJBAFHGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FNFAJLDONCJ : PCPGILFPKCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int AOKKMBEFAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Queue<double> BMKLLNOAAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double JCGGLMFLBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double PLFLOPDIPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double KBALBMHCMPI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double IHGHDGMKMNF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7814A00", Offset = "0x7813A00", VA = "0x187814A00", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double EPPOOIMGDDB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x41DD250", Offset = "0x41DC250", VA = "0x1841DD250", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double HKFNJNFDDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x229A620", Offset = "0x2299620", VA = "0x18229A620", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7814A60", Offset = "0x7813A60", VA = "0x187814A60")]
	public FNFAJLDONCJ(int GFMALFDLIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x78148E0", Offset = "0x78138E0", VA = "0x1878148E0", Slot = "7")]
	public void HMBNOEENKEH(double ADMAMDKLPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7814870", Offset = "0x7813870", VA = "0x187814870", Slot = "8")]
	public void CMJEOBEPHJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class HOECCDNEAAF : PCPGILFPKCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private long DCEOMHJEBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double EHNDHKGLDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double BCCNGKIIEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double HILMLHMDBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double AMFAODFBEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double JCGGLMFLBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double PLFLOPDIPGH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double EPPOOIMGDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x640B6E0", Offset = "0x640A6E0", VA = "0x18640B6E0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double HKFNJNFDDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9E4290", Offset = "0x9E3290", VA = "0x1809E4290", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double AGGJLGNBCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x640B640", Offset = "0x640A640", VA = "0x18640B640")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double IHGHDGMKMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28AFBF0", Offset = "0x28AEBF0", VA = "0x1828AFBF0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x78170B0", Offset = "0x78160B0", VA = "0x1878170B0", Slot = "7")]
	public virtual void HMBNOEENKEH(double ADMAMDKLPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7817070", Offset = "0x7816070", VA = "0x187817070", Slot = "8")]
	public virtual void CMJEOBEPHJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x78171D0", Offset = "0x78161D0", VA = "0x1878171D0")]
	public HOECCDNEAAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LDHMNBGGIEK : HOECCDNEAAF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double MONHHFAAGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x640B660", Offset = "0x640A660", VA = "0x18640B660")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x640B6C0", Offset = "0x640A6C0", VA = "0x18640B6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x781B2A0", Offset = "0x781A2A0", VA = "0x18781B2A0", Slot = "7")]
	public override void HMBNOEENKEH(double ADMAMDKLPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x781B260", Offset = "0x781A260", VA = "0x18781B260", Slot = "8")]
	public override void CMJEOBEPHJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x78171D0", Offset = "0x78161D0", VA = "0x1878171D0")]
	public LDHMNBGGIEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface PCPGILFPKCO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double IHGHDGMKMNF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double EPPOOIMGDDB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double HKFNJNFDDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class GGKCBKPEBOA
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface OKDFDBFADOF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool JIPCBFDOBAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AMDEFDIILDI();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class NKBNADIPNBH : OKDFDBFADOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly Action NDLMGANFCBJ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool JIPCBFDOBAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
		public NKBNADIPNBH(Action NDLMGANFCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xCFE210", Offset = "0xCFD210", VA = "0x180CFE210", Slot = "5")]
		public void AMDEFDIILDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<OKDFDBFADOF> ELFELENFJLE;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7815FD0", Offset = "0x7814FD0", VA = "0x187815FD0")]
	public static void KOOMAHDLFLA(Action NDLMGANFCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7815DC0", Offset = "0x7814DC0", VA = "0x187815DC0")]
	private static void JKLNAFBMEIG(OKDFDBFADOF FLHDIPFJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7816070", Offset = "0x7815070", VA = "0x187816070")]
	private static void LIHCOJJLNJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7815CC0", Offset = "0x7814CC0", VA = "0x187815CC0")]
	private static void HJGJNGOPBCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7816350", Offset = "0x7815350", VA = "0x187816350")]
	private static void MDHAOHMCFKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class DFHMALIJLPM
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct JIHKNOJNAFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public TaskCompletionSource<Scene> FJLEAPAAHKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly string DEJGJBPGHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly LoadSceneMode CBBBLFFEMBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly bool NNIIFEPANPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7819B80", Offset = "0x7818B80", VA = "0x187819B80")]
		public JIHKNOJNAFP(TaskCompletionSource<Scene> GOBKHGGOFJJ, string DEJGJBPGHEM, LoadSceneMode CBBBLFFEMBA, bool NNIIFEPANPE, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct KGODNNGMBAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private NPOAFBCOAIB<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x781A670", Offset = "0x7819670", VA = "0x18781A670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x781AF10", Offset = "0x7819F10", VA = "0x18781AF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct IAFBEJJHJED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7817200", Offset = "0x7816200", VA = "0x187817200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7817510", Offset = "0x7816510", VA = "0x187817510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GDHNMDEIJKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private JIHKNOJNAFP <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7815090", Offset = "0x7814090", VA = "0x187815090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7815450", Offset = "0x7814450", VA = "0x187815450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class GAJNGNJNFKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public DIGLOOLIBBM<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GAJNGNJNFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7814E70", Offset = "0x7813E70", VA = "0x187814E70")]
		internal void KAIBKLEICMK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct BIACCICLJKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private GAJNGNJNFKK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x78097E0", Offset = "0x78087E0", VA = "0x1878097E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x780A340", Offset = "0x7809340", VA = "0x18780A340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct NOLCGAJAIGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7821400", Offset = "0x7820400", VA = "0x187821400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x78218D0", Offset = "0x78208D0", VA = "0x1878218D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct PPLKCONBDAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x78224F0", Offset = "0x78214F0", VA = "0x1878224F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7823010", Offset = "0x7822010", VA = "0x187823010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class MCCKPPJFJCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public MCCKPPJFJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x781BBF0", Offset = "0x781ABF0", VA = "0x18781BBF0")]
		internal bool LBBDNFJJGJJ()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class EFIENOBMHHC : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public IIAHDMFNNHP onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public EFIENOBMHHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7813190", Offset = "0x7812190", VA = "0x187813190", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7812E00", Offset = "0x7811E00", VA = "0x187812E00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7812DB0", Offset = "0x7811DB0", VA = "0x187812DB0")]
		private void CLDKBJALKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7813140", Offset = "0x7812140", VA = "0x187813140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class HGJACNKALAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public DIGLOOLIBBM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public HGJACNKALAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7816BC0", Offset = "0x7815BC0", VA = "0x187816BC0")]
		internal bool NLCMAECJBMO(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7816960", Offset = "0x7815960", VA = "0x187816960")]
		internal void FGCEJGOGHJE(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class AOAPPLCIFFB : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public DIGLOOLIBBM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private HGJACNKALAP <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public AOAPPLCIFFB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7808680", Offset = "0x7807680", VA = "0x187808680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7808CE0", Offset = "0x7807CE0", VA = "0x187808CE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly ICollection<string> FCBBKDKHHNE;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static KKJPAEAJCIM KIEFHPNPBJN;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static AsyncOperation IFHGOMJJKJM;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static KKJPAEAJCIM LFECHNBNLJA;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static string AMHFLKMKAGE;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static ThreadPriority NBPJGHGLAFP;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static Task JNFJBFLLBCO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static List<SceneInstance> NEBGODCGEJM;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly Queue<JIHKNOJNAFP> KPDPIDFJMNJ;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static Task GGBFDBDPDMP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool EBNANMGEENG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7811050", Offset = "0x7810050", VA = "0x187811050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private static bool JINNAEPOKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x78121D0", Offset = "0x78111D0", VA = "0x1878121D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private static bool GAHABOHGOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7811260", Offset = "0x7810260", VA = "0x187811260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool BIHACOOCIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7811C50", Offset = "0x7810C50", VA = "0x187811C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> DMKANCANBJM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7811B40", Offset = "0x7810B40", VA = "0x187811B40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7812720", Offset = "0x7811720", VA = "0x187812720")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7812630", Offset = "0x7811630", VA = "0x187812630")]
	[OJEDBLJEHPG(DODBMCGLPPE.EnteredEditModeNextFrame, 0)]
	private static void PDCNJLONGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x78124E0", Offset = "0x78114E0", VA = "0x1878124E0")]
	[AsyncStateMachine(typeof(KGODNNGMBAB))]
	public static Task<Scene> PBOPDEAEKMM(string DEJGJBPGHEM, LoadSceneMode CBBBLFFEMBA = LoadSceneMode.Single, bool NNIIFEPANPE = false, [Optional] NPOAFBCOAIB<string>.HFMLKGGDOCE DKMPGKEACGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7811A00", Offset = "0x7810A00", VA = "0x187811A00")]
	[AsyncStateMachine(typeof(IAFBEJJHJED))]
	private static Task EPOKDOBCBEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x78113A0", Offset = "0x78103A0", VA = "0x1878113A0")]
	[AsyncStateMachine(typeof(GDHNMDEIJKF))]
	private static Task BDEAOEPCCNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7811470", Offset = "0x7810470", VA = "0x187811470")]
	[AsyncStateMachine(typeof(BIACCICLJKE))]
	private static Task<Scene> CMMKGFBLOJM(string DEJGJBPGHEM, LoadSceneMode CBBBLFFEMBA, bool NNIIFEPANPE, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x78116F0", Offset = "0x78106F0", VA = "0x1878116F0")]
	private static void EICFLMHLKFP(SceneInstance DKOIJBOMAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7811800", Offset = "0x7810800", VA = "0x187811800")]
	private static void EOJGKJMBINO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x78120B0", Offset = "0x78110B0", VA = "0x1878120B0")]
	[AsyncStateMachine(typeof(NOLCGAJAIGI))]
	private static Task<Scene> JGGMOCGJMIJ(string DEJGJBPGHEM, LoadSceneMode CBBBLFFEMBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7812270", Offset = "0x7811270", VA = "0x187812270")]
	private static bool OFGBONJFHEL(string DEJGJBPGHEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7811FA0", Offset = "0x7810FA0", VA = "0x187811FA0")]
	[AsyncStateMachine(typeof(PPLKCONBDAD))]
	private static Task<Scene> IMHHDIAIPKF(NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7812360", Offset = "0x7811360", VA = "0x187812360")]
	public static OBJFFICJNII<Scene> PBCDDODMAPA(string DEJGJBPGHEM, LoadSceneMode CBBBLFFEMBA = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7811CE0", Offset = "0x7810CE0", VA = "0x187811CE0")]
	public static KKJPAEAJCIM IHBLCJMHKKE(string DEJGJBPGHEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7811AB0", Offset = "0x7810AB0", VA = "0x187811AB0")]
	[IteratorStateMachine(typeof(EFIENOBMHHC))]
	private static IEnumerator<MIAEKAOKMEH> GKHMBJBNKGN(string DEJGJBPGHEM, IIAHDMFNNHP BJENGPBNFCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7811300", Offset = "0x7810300", VA = "0x187811300")]
	[IteratorStateMachine(typeof(AOAPPLCIFFB))]
	private static IEnumerator<MIAEKAOKMEH> BBPEBAFFFKN(string DEJGJBPGHEM, LoadSceneMode CBBBLFFEMBA, DIGLOOLIBBM<Scene> BJENGPBNFCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x78115C0", Offset = "0x78105C0", VA = "0x1878115C0")]
	public static bool DMHNJOFOCJF([Out] string GFHEJOPFGNI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class GBGCHNPNKGF
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7814ED0", Offset = "0x7813ED0", VA = "0x187814ED0")]
	public static IDisposable BEPMAPCBPNB(this BGLICCIOOAL NDMMIOJEOEB, float EICHKAJPLFO, Action<float> AFPBGKGFCMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7814FE0", Offset = "0x7813FE0", VA = "0x187814FE0")]
	public static IDisposable IGIEOBDIPCN(this BGLICCIOOAL NDMMIOJEOEB, Action<float> AFPBGKGFCMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7814F60", Offset = "0x7813F60", VA = "0x187814F60")]
	public static IDisposable HMDIEBPAJLA(this BGLICCIOOAL NDMMIOJEOEB, Action<float> AFPBGKGFCMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BOGPFIAEAGE
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x780A760", Offset = "0x7809760", VA = "0x18780A760")]
	public static IDisposable HCFOCBKJMKC(this MonoBehaviour NDEOLIKHBMH, Action AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x780A6D0", Offset = "0x78096D0", VA = "0x18780A6D0")]
	public static IDisposable HCFOCBKJMKC(this MonoBehaviour NDEOLIKHBMH, Action<float> AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x780A5D0", Offset = "0x78095D0", VA = "0x18780A5D0")]
	public static IDisposable ECKIEDCBBJB(this MonoBehaviour NDEOLIKHBMH, Action AFPBGKGFCMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x780A450", Offset = "0x7809450", VA = "0x18780A450")]
	public static IDisposable CEKFMPIEFID(this MonoBehaviour NDEOLIKHBMH, Action AFPBGKGFCMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x780A4D0", Offset = "0x78094D0", VA = "0x18780A4D0")]
	public static IDisposable CEKFMPIEFID(this MonoBehaviour NDEOLIKHBMH, Action<float> AFPBGKGFCMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x780A650", Offset = "0x7809650", VA = "0x18780A650")]
	public static IDisposable FPMBLCIMKKP(this MonoBehaviour NDEOLIKHBMH, Action AFPBGKGFCMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x780A550", Offset = "0x7809550", VA = "0x18780A550")]
	public static IDisposable DHDEMNEONOK(this MonoBehaviour NDEOLIKHBMH, Action AFPBGKGFCMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x780A9D0", Offset = "0x78099D0", VA = "0x18780A9D0")]
	public static IDisposable MJDOHCIKFAL(this MonoBehaviour NDEOLIKHBMH, Action AFPBGKGFCMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x780ABC0", Offset = "0x7809BC0", VA = "0x18780ABC0")]
	public static IDisposable OKPFIJEHMFP(this MonoBehaviour NDEOLIKHBMH, float EICHKAJPLFO, Action<float> AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH, bool AMDHAOKCPDL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x780AA50", Offset = "0x7809A50", VA = "0x18780AA50")]
	public static IDisposable MKBPOLIIOGE(this MonoBehaviour NDEOLIKHBMH, float EICHKAJPLFO, Action<float> AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH, bool AMDHAOKCPDL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x780AC70", Offset = "0x7809C70", VA = "0x18780AC70")]
	public static IDisposable OONPJNNPNEO(this MonoBehaviour NDEOLIKHBMH, float EICHKAJPLFO, Action<float> AFPBGKGFCMI, bool AMDHAOKCPDL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x780A890", Offset = "0x7809890", VA = "0x18780A890")]
	public static IDisposable IICJICAOKEJ(this MonoBehaviour NDEOLIKHBMH, Action<float> AFPBGKGFCMI, bool AMDHAOKCPDL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x780AD10", Offset = "0x7809D10", VA = "0x18780AD10")]
	public static IDisposable PJMNAEFHFLI(this MonoBehaviour NDEOLIKHBMH, Action<float> AFPBGKGFCMI, bool AMDHAOKCPDL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x780AA80", Offset = "0x7809A80", VA = "0x18780AA80")]
	public static IDisposable OEPPIADAMKE(this MonoBehaviour NDEOLIKHBMH, Action<float> AFPBGKGFCMI, bool AMDHAOKCPDL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x780AB20", Offset = "0x7809B20", VA = "0x18780AB20")]
	public static IDisposable OIFCBLJBFON(this MonoBehaviour NDEOLIKHBMH, Action<float> AFPBGKGFCMI, bool AMDHAOKCPDL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x780A930", Offset = "0x7809930", VA = "0x18780A930")]
	public static IDisposable LHEBCKJFJGF(this MonoBehaviour NDEOLIKHBMH, Action<float> AFPBGKGFCMI, bool AMDHAOKCPDL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x780A7F0", Offset = "0x78097F0", VA = "0x18780A7F0")]
	public static IDisposable HOPLGBHEIBD(this MonoBehaviour NDEOLIKHBMH, Action<float> AFPBGKGFCMI, bool AMDHAOKCPDL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x780A3B0", Offset = "0x78093B0", VA = "0x18780A3B0")]
	public static IDisposable BHLMBKAFJOK(this MonoBehaviour NDEOLIKHBMH, Action<float> AFPBGKGFCMI, bool AMDHAOKCPDL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x780ADB0", Offset = "0x7809DB0", VA = "0x18780ADB0")]
	public static IDisposable PJNEJINPHOJ(this MonoBehaviour NDEOLIKHBMH, float EICHKAJPLFO, Action<float> AFPBGKGFCMI, bool AMDHAOKCPDL = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class EHHDPAIBDMM
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class AFKIGMDLFFF : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public IGLJHPDFCLG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private BJJKJIANKJF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public AFKIGMDLFFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7808250", Offset = "0x7807250", VA = "0x187808250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7808330", Offset = "0x7807330", VA = "0x187808330", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class LGCOLKEPOFM : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public IGLJHPDFCLG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private BJJKJIANKJF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public LGCOLKEPOFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x781B3D0", Offset = "0x781A3D0", VA = "0x18781B3D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x781B4C0", Offset = "0x781A4C0", VA = "0x18781B4C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x78134A0", Offset = "0x78124A0", VA = "0x1878134A0")]
	public static DDGDFMBPLHP HCFOCBKJMKC(Action AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7813410", Offset = "0x7812410", VA = "0x187813410")]
	public static DDGDFMBPLHP HCFOCBKJMKC(Behaviour NDMMIOJEOEB, Action AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7813520", Offset = "0x7812520", VA = "0x187813520")]
	public static DDGDFMBPLHP HCFOCBKJMKC(Behaviour NDMMIOJEOEB, Action<float> AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7813380", Offset = "0x7812380", VA = "0x187813380")]
	[IteratorStateMachine(typeof(AFKIGMDLFFF))]
	private static IEnumerator<MIAEKAOKMEH> BPJLFLOFALP(IGLJHPDFCLG EDFAINEAOAB, Action AFPBGKGFCMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x78132F0", Offset = "0x78122F0", VA = "0x1878132F0")]
	[IteratorStateMachine(typeof(LGCOLKEPOFM))]
	private static IEnumerator<MIAEKAOKMEH> BPJLFLOFALP(IGLJHPDFCLG EDFAINEAOAB, Action<float> AFPBGKGFCMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class IJPLNNPIFMD : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class HHIEEGJBCCB : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public IJPLNNPIFMD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public HHIEEGJBCCB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7816C40", Offset = "0x7815C40", VA = "0x187816C40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7816CD0", Offset = "0x7815CD0", VA = "0x187816CD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly IGLJHPDFCLG CBDFNHFGFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Action GNLDEDCPJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private bool PANAOGDGELB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool HICNMIFIMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E50", Offset = "0x8B8E50", VA = "0x1808B9E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x78199F0", Offset = "0x78189F0", VA = "0x1878199F0")]
	public IJPLNNPIFMD(IGLJHPDFCLG CBDFNHFGFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x78198D0", Offset = "0x78188D0", VA = "0x1878198D0")]
	[IteratorStateMachine(typeof(HHIEEGJBCCB))]
	private IEnumerator<MIAEKAOKMEH> DEKENGDMONK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7819950", Offset = "0x7818950", VA = "0x187819950", Slot = "4")]
	public void OnCompleted(Action JGDPHJOPKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	public void DIDAPJDBCDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class MBBNCKJPEDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x781BAE0", Offset = "0x781AAE0", VA = "0x18781BAE0")]
	public static IJPLNNPIFMD ALMCJCFOGEI(this IGLJHPDFCLG CBDFNHFGFAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class CILLLPAANKL
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class EGFCDEIHEAK : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public MPMPMGOPHOH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public EGFCDEIHEAK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7813220", Offset = "0x7812220", VA = "0x187813220", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x78132A0", Offset = "0x78122A0", VA = "0x1878132A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x780B590", Offset = "0x780A590", VA = "0x18780B590")]
	public static DDGDFMBPLHP HCFOCBKJMKC(float EICHKAJPLFO, Action<float> AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH, bool AMDHAOKCPDL = true, [Optional] ADNJPBFMOOO CPMPOEHDNGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x780B660", Offset = "0x780A660", VA = "0x18780B660")]
	public static DDGDFMBPLHP HCFOCBKJMKC(MonoBehaviour NDEOLIKHBMH, float EICHKAJPLFO, Action<float> AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH, bool AMDHAOKCPDL = true, [Optional] ADNJPBFMOOO CPMPOEHDNGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x780B730", Offset = "0x780A730", VA = "0x18780B730")]
	public static DDGDFMBPLHP JEMHMLKIBIM(MonoBehaviour NDEOLIKHBMH, float EICHKAJPLFO, Action<float> AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH, bool AMDHAOKCPDL = true, [Optional] ADNJPBFMOOO CPMPOEHDNGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x780B4C0", Offset = "0x780A4C0", VA = "0x18780B4C0")]
	public static DDGDFMBPLHP EKHHOCEKNIE(BGLICCIOOAL NDMMIOJEOEB, float EICHKAJPLFO, Action<float> AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH, bool AMDHAOKCPDL = true, [Optional] ADNJPBFMOOO CPMPOEHDNGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x780B370", Offset = "0x780A370", VA = "0x18780B370")]
	private static IEnumerator<MIAEKAOKMEH> BPJLFLOFALP(GFBGLICDLGK IEHLGGJLHBC, float EICHKAJPLFO, IGLJHPDFCLG EDFAINEAOAB, Action<float> AFPBGKGFCMI, bool AMDHAOKCPDL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x780B820", Offset = "0x780A820", VA = "0x18780B820")]
	private static IEnumerator<MIAEKAOKMEH> LOFEMEJEPDF(GFBGLICDLGK IEHLGGJLHBC, float EICHKAJPLFO, IGLJHPDFCLG EDFAINEAOAB, Action<float> AFPBGKGFCMI, bool AMDHAOKCPDL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x780B430", Offset = "0x780A430", VA = "0x18780B430")]
	[IteratorStateMachine(typeof(EGFCDEIHEAK))]
	private static IEnumerator<MIAEKAOKMEH> DJCDBDFCKMM(MPMPMGOPHOH KGNNHNBLGBI, float EICHKAJPLFO, IGLJHPDFCLG EDFAINEAOAB, Action<float> AFPBGKGFCMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class LGMCCEOFPDM
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class HHJNMAHMGON : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public IGLJHPDFCLG queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public HHJNMAHMGON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7816D20", Offset = "0x7815D20", VA = "0x187816D20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7816DE0", Offset = "0x7815DE0", VA = "0x187816DE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x781B5F0", Offset = "0x781A5F0", VA = "0x18781B5F0")]
	[IteratorStateMachine(typeof(HHJNMAHMGON))]
	private static IEnumerator<MIAEKAOKMEH> NMGLDPGEAKM(IGLJHPDFCLG CBDFNHFGFAH, Func<bool> PAHLJNPBBFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x781B510", Offset = "0x781A510", VA = "0x18781B510")]
	public static DDGDFMBPLHP IOEHHLOCAIN(this MonoBehaviour NDEOLIKHBMH, Func<bool> PAHLJNPBBFN, IGLJHPDFCLG CBDFNHFGFAH = IGLJHPDFCLG.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class IBNKIJOGJHM
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class IMGBKIOHEJM : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public IGLJHPDFCLG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public IMGBKIOHEJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7819AC0", Offset = "0x7818AC0", VA = "0x187819AC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7819B30", Offset = "0x7818B30", VA = "0x187819B30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class AEBKBFGOGLK : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public IGLJHPDFCLG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private MIAEKAOKMEH <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public AEBKBFGOGLK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7808170", Offset = "0x7807170", VA = "0x187808170", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7808200", Offset = "0x7807200", VA = "0x187808200", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7817890", Offset = "0x7816890", VA = "0x187817890")]
	[IteratorStateMachine(typeof(IMGBKIOHEJM))]
	private static IEnumerator<MIAEKAOKMEH> DEKENGDMONK(float OPFDDHFIGGD, IGLJHPDFCLG EDFAINEAOAB, Action LILCNNNEFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7818080", Offset = "0x7817080", VA = "0x187818080")]
	[IteratorStateMachine(typeof(AEBKBFGOGLK))]
	private static IEnumerator<MIAEKAOKMEH> PGBLJGLJIAK(float OPFDDHFIGGD, IGLJHPDFCLG EDFAINEAOAB, Action LILCNNNEFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7817EB0", Offset = "0x7816EB0", VA = "0x187817EB0")]
	public static IDisposable OJMBMDOIMCO(this MonoBehaviour NDEOLIKHBMH, float OPFDDHFIGGD, Action LILCNNNEFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7817A60", Offset = "0x7816A60", VA = "0x187817A60")]
	public static DDGDFMBPLHP ELANDEDAAMF(this MonoBehaviour NDEOLIKHBMH, float OPFDDHFIGGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7817F90", Offset = "0x7816F90", VA = "0x187817F90")]
	public static DDGDFMBPLHP OJMBMDOIMCO(this MonoBehaviour NDEOLIKHBMH, float OPFDDHFIGGD, IGLJHPDFCLG EDFAINEAOAB, Action LILCNNNEFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7817C30", Offset = "0x7816C30", VA = "0x187817C30")]
	public static DDGDFMBPLHP GPFHLDKEKAA(this MonoBehaviour NDEOLIKHBMH, Action LILCNNNEFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7817750", Offset = "0x7816750", VA = "0x187817750")]
	public static DDGDFMBPLHP BCABOBJAJNG(this MonoBehaviour NDEOLIKHBMH, Action LILCNNNEFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7817930", Offset = "0x7816930", VA = "0x187817930")]
	public static DDGDFMBPLHP DOEIDIHNOPN(this MonoBehaviour NDEOLIKHBMH, Action LILCNNNEFGE, [Optional] ADNJPBFMOOO CPMPOEHDNGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7817D70", Offset = "0x7816D70", VA = "0x187817D70")]
	public static DDGDFMBPLHP KOMJKDJKFKK(this MonoBehaviour NDEOLIKHBMH, Action LILCNNNEFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7817B90", Offset = "0x7816B90", VA = "0x187817B90")]
	public static DDGDFMBPLHP GFAGABACLPP(this MonoBehaviour NDEOLIKHBMH, Action LILCNNNEFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x78177F0", Offset = "0x78167F0", VA = "0x1878177F0")]
	private static DDGDFMBPLHP BFOJEILINFC(MonoBehaviour NDEOLIKHBMH, IGLJHPDFCLG CBDFNHFGFAH, Action LILCNNNEFGE, [Optional] ADNJPBFMOOO CPMPOEHDNGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x78179D0", Offset = "0x78169D0", VA = "0x1878179D0")]
	public static DDGDFMBPLHP EHFADBPBMDE(this MonoBehaviour NDEOLIKHBMH, float FNHMAOGCJMO, Action LILCNNNEFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7817E10", Offset = "0x7816E10", VA = "0x187817E10")]
	public static DDGDFMBPLHP OJLLNNFLEPL(this MonoBehaviour NDEOLIKHBMH, float FNHMAOGCJMO, Action LILCNNNEFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7817AF0", Offset = "0x7816AF0", VA = "0x187817AF0")]
	public static DDGDFMBPLHP EOGFGFLHNGD(this MonoBehaviour NDEOLIKHBMH, float FNHMAOGCJMO, Action LILCNNNEFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7817CD0", Offset = "0x7816CD0", VA = "0x187817CD0")]
	public static DDGDFMBPLHP JCPLGFDICPG(this MonoBehaviour NDEOLIKHBMH, float FNHMAOGCJMO, Action LILCNNNEFGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class KEDDKFIABJE : JDAEJJGAGNP, IEnumerable<JDAEJJGAGNP>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly List<JDAEJJGAGNP> LHLOKMIMJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool GHGANHCLNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Action FPEOLMDAFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool CKPGDHCLNHH;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool LKMMDKBGBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x781A2D0", Offset = "0x78192D0", VA = "0x18781A2D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OPFKBDNIDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x781A230", Offset = "0x7819230", VA = "0x18781A230", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x781A530", Offset = "0x7819530", VA = "0x18781A530", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x781A5D0", Offset = "0x78195D0", VA = "0x18781A5D0")]
	public KEDDKFIABJE([Optional] Action FPEOLMDAFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x781A400", Offset = "0x7819400", VA = "0x18781A400")]
	public void OPFOFHIGBEE(JDAEJJGAGNP IDCBBOOBJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x781A060", Offset = "0x7819060", VA = "0x18781A060")]
	private void FMDFPEIFLPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x781A050", Offset = "0x7819050", VA = "0x18781A050", Slot = "7")]
	public bool BNKOGFGLEIO(bool OCPABOGIINL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7819D50", Offset = "0x7818D50", VA = "0x187819D50", Slot = "8")]
	public bool BNKOGFGLEIO(Action NDLMGANFCBJ, bool OCPABOGIINL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x781A1B0", Offset = "0x78191B0", VA = "0x18781A1B0", Slot = "9")]
	public IEnumerator<JDAEJJGAGNP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x781A1B0", Offset = "0x78191B0", VA = "0x18781A1B0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GAEDHDDHIDG : EOCPOJJFMOH
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class GBLDPJJIAJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public GAEDHDDHIDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GBLDPJJIAJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7815060", Offset = "0x7814060", VA = "0x187815060")]
		internal void OJANKNKDNNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class NKBGIOPOKDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public GAEDHDDHIDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public NKBGIOPOKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7815060", Offset = "0x7814060", VA = "0x187815060")]
		internal void HJHNDLEILNM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly float NFMEKGLEOHJ;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7814D30", Offset = "0x7813D30", VA = "0x187814D30")]
	public GAEDHDDHIDG(Behaviour NDMMIOJEOEB, float NFMEKGLEOHJ, [Optional] Action FPEOLMDAFCB, [Optional] ADNJPBFMOOO CPMPOEHDNGG, [Optional] GFBGLICDLGK IEHLGGJLHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7814C20", Offset = "0x7813C20", VA = "0x187814C20", Slot = "9")]
	protected override bool CHPNMOOFDCI(Action NDLMGANFCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7814B10", Offset = "0x7813B10", VA = "0x187814B10", Slot = "10")]
	protected override bool BMGEKNLNCCN(Action NDLMGANFCBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface JDAEJJGAGNP
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool LKMMDKBGBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OPFKBDNIDFJ;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BNKOGFGLEIO(bool OCPABOGIINL = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BNKOGFGLEIO(Action NDLMGANFCBJ, bool OCPABOGIINL = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class EOCPOJJFMOH : JDAEJJGAGNP
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class FFPIPFOBAKP : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public EOCPOJJFMOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public FFPIPFOBAKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7814570", Offset = "0x7813570", VA = "0x187814570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7814640", Offset = "0x7813640", VA = "0x187814640", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Behaviour NDMMIOJEOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action FPEOLMDAFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private EDMIDDLGGJL COFGHDCKGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly ADNJPBFMOOO CPMPOEHDNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	protected readonly GFBGLICDLGK IEHLGGJLHBC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LKMMDKBGBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1295590", Offset = "0x1294590", VA = "0x181295590", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OPFKBDNIDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7813830", Offset = "0x7812830", VA = "0x187813830", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7813B20", Offset = "0x7812B20", VA = "0x187813B20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7813BC0", Offset = "0x7812BC0", VA = "0x187813BC0")]
	protected EOCPOJJFMOH(Behaviour NDMMIOJEOEB, [Optional] Action FPEOLMDAFCB, [Optional] ADNJPBFMOOO CPMPOEHDNGG, [Optional] GFBGLICDLGK IEHLGGJLHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7813600", Offset = "0x7812600", VA = "0x187813600", Slot = "7")]
	public bool BNKOGFGLEIO(bool OCPABOGIINL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7813660", Offset = "0x7812660", VA = "0x187813660", Slot = "8")]
	public bool BNKOGFGLEIO(Action NDLMGANFCBJ, bool OCPABOGIINL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool CHPNMOOFDCI(Action NDLMGANFCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool BMGEKNLNCCN(Action NDLMGANFCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7813780", Offset = "0x7812780", VA = "0x187813780")]
	protected void IIOECLDJJIA(Action NDLMGANFCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x78138D0", Offset = "0x78128D0", VA = "0x1878138D0")]
	protected KKJPAEAJCIM NBDFBFLLOFJ(float DHLFCHNFAOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7813700", Offset = "0x7812700", VA = "0x187813700")]
	private void FIJOPMHHNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x78137A0", Offset = "0x78127A0", VA = "0x1878137A0")]
	[IteratorStateMachine(typeof(FFPIPFOBAKP))]
	private IEnumerator<MIAEKAOKMEH> KIFGNHDPOFI(float DHLFCHNFAOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x78136C0", Offset = "0x78126C0", VA = "0x1878136C0")]
	[CompilerGenerated]
	private void EOLDECOAGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class BHPFCNKMCFF : EOCPOJJFMOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float KLIDABJPJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int PHDPCEEGKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float GOOCNPAJBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float[] LNJCDDIJANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int HLOEAGABELF;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7809610", Offset = "0x7808610", VA = "0x187809610")]
	public BHPFCNKMCFF(Behaviour NDMMIOJEOEB, float IAEBHNALFJN, int PHDPCEEGKMG, [Optional] Action FPEOLMDAFCB, float GOOCNPAJBPI = 0f, [Optional] ADNJPBFMOOO CPMPOEHDNGG, [Optional] GFBGLICDLGK IEHLGGJLHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "9")]
	protected override bool CHPNMOOFDCI(Action NDLMGANFCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7809390", Offset = "0x7808390", VA = "0x187809390", Slot = "10")]
	protected override bool BMGEKNLNCCN(Action NDLMGANFCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7809590", Offset = "0x7808590", VA = "0x187809590")]
	private void NFPJBBJLLGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GGJMJHOCKBB : EOCPOJJFMOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float NFMEKGLEOHJ;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7814D30", Offset = "0x7813D30", VA = "0x187814D30")]
	public GGJMJHOCKBB(Behaviour NDMMIOJEOEB, float NFMEKGLEOHJ, [Optional] Action FPEOLMDAFCB, [Optional] ADNJPBFMOOO CPMPOEHDNGG, [Optional] GFBGLICDLGK IEHLGGJLHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "9")]
	protected override bool CHPNMOOFDCI(Action NDLMGANFCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7815C80", Offset = "0x7814C80", VA = "0x187815C80", Slot = "10")]
	protected override bool BMGEKNLNCCN(Action NDLMGANFCBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class PKMGMEKEMCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class KIBKPEAKANH : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public KIBKPEAKANH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7819C90", Offset = "0x7818C90", VA = "0x187819C90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x781AF80", Offset = "0x7819F80", VA = "0x18781AF80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private DDGDFMBPLHP BOIDMICENKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private BGLICCIOOAL NDMMIOJEOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Action<float> DGGEDNFOEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private IGLJHPDFCLG CBDFNHFGFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private float DFEKHAEBEIF;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7822350", Offset = "0x7821350", VA = "0x187822350")]
	public PKMGMEKEMCD(BGLICCIOOAL NDMMIOJEOEB, float EICHKAJPLFO, Action<float> AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x78221E0", Offset = "0x78211E0", VA = "0x1878221E0")]
	private void LEBPDODFGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7822030", Offset = "0x7821030", VA = "0x187822030")]
	private void HPMNFGBBJEI(string IPLILPPMPOG, Action LKBOBAMPDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7822160", Offset = "0x7821160", VA = "0x187822160")]
	[IteratorStateMachine(typeof(KIBKPEAKANH))]
	private IEnumerator<MIAEKAOKMEH> JCJFNMFCEJD(Action LKBOBAMPDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7821E50", Offset = "0x7820E50", VA = "0x187821E50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7821EB0", Offset = "0x7820EB0", VA = "0x187821EB0")]
	[CompilerGenerated]
	private void GJJPBCJKLLD(string ONPDAAPKDCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class CPDMLJEMOLK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JKOFBMHAILD : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public JKOFBMHAILD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7819C90", Offset = "0x7818C90", VA = "0x187819C90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7819D00", Offset = "0x7818D00", VA = "0x187819D00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private DDGDFMBPLHP BOIDMICENKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private MonoBehaviour NDEOLIKHBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action AFPBGKGFCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Action<float> DGGEDNFOEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private IGLJHPDFCLG CBDFNHFGFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float DFEKHAEBEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private bool AMDHAOKCPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly ADNJPBFMOOO CPMPOEHDNGG;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x780C680", Offset = "0x780B680", VA = "0x18780C680")]
	public CPDMLJEMOLK(MonoBehaviour NDEOLIKHBMH, Action AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH, [Optional] ADNJPBFMOOO CPMPOEHDNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x780C4B0", Offset = "0x780B4B0", VA = "0x18780C4B0")]
	public CPDMLJEMOLK(MonoBehaviour NDEOLIKHBMH, Action<float> AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH, [Optional] ADNJPBFMOOO CPMPOEHDNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x780C810", Offset = "0x780B810", VA = "0x18780C810")]
	public CPDMLJEMOLK(MonoBehaviour NDEOLIKHBMH, float EICHKAJPLFO, Action<float> AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH, bool AMDHAOKCPDL = true, [Optional] ADNJPBFMOOO CPMPOEHDNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x9DA7C0", Offset = "0x9D97C0", VA = "0x1809DA7C0")]
	private CPDMLJEMOLK(ADNJPBFMOOO CPMPOEHDNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x780BE40", Offset = "0x780AE40", VA = "0x18780BE40")]
	internal static CPDMLJEMOLK HGGJDILMNFI(MonoBehaviour NDEOLIKHBMH, float EICHKAJPLFO, Action<float> AFPBGKGFCMI, IGLJHPDFCLG CBDFNHFGFAH, bool AMDHAOKCPDL = true, [Optional] ADNJPBFMOOO CPMPOEHDNGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x780BD10", Offset = "0x780AD10", VA = "0x18780BD10")]
	private void HCFOCBKJMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x780BB90", Offset = "0x780AB90", VA = "0x18780BB90")]
	private void GIJLGDIKEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x780C220", Offset = "0x780B220", VA = "0x18780C220")]
	private void LEBPDODFGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x780BA00", Offset = "0x780AA00", VA = "0x18780BA00")]
	private void EDDIGKPCLBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x780C070", Offset = "0x780B070", VA = "0x18780C070")]
	private void HPMNFGBBJEI(string IPLILPPMPOG, Action LKBOBAMPDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x780C1A0", Offset = "0x780B1A0", VA = "0x18780C1A0")]
	[IteratorStateMachine(typeof(JKOFBMHAILD))]
	private IEnumerator<MIAEKAOKMEH> JCJFNMFCEJD(Action LKBOBAMPDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x780B9A0", Offset = "0x780A9A0", VA = "0x18780B9A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x780B880", Offset = "0x780A880", VA = "0x18780B880")]
	[CompilerGenerated]
	private void DGBJPFFABIO(string ONPDAAPKDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x780C420", Offset = "0x780B420", VA = "0x18780C420")]
	[CompilerGenerated]
	private void PNHNBHFGNNG(string ONPDAAPKDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x780C390", Offset = "0x780B390", VA = "0x18780C390")]
	[CompilerGenerated]
	private void PANHACNOECD(string ONPDAAPKDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x780B910", Offset = "0x780A910", VA = "0x18780B910")]
	[CompilerGenerated]
	private void DMADDMJONIL(string ONPDAAPKDCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum DGIKGDCFNLJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal sealed class JKCPPEJHOAD : GFBGLICDLGK
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float BHDLGEDHHBL
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7819BE0", Offset = "0x7818BE0", VA = "0x187819BE0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float EOELMMMOANH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7819BF0", Offset = "0x7818BF0", VA = "0x187819BF0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public double KAFNJMECABP
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7819C70", Offset = "0x7818C70", VA = "0x187819C70", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7819C00", Offset = "0x7818C00", VA = "0x187819C00")]
	[AEDCCIMPEFD.GIGKNHONDJE]
	internal static void LPMGDCHBOCO(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	[UnityEngine.Scripting.Preserve]
	internal JKCPPEJHOAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface NAFCPIPKIAF
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IDMCHDOBIMH(string DMCFPOLFNCF);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CLLGHEPOFID();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface DLBJHOMBLGA
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string KKNEIOOKBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool DPEGCPBDAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool AOFJBINLLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class CCGIPGDGCBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public MGFAKLECHAA GMIHJBGDFMO;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int HOLNAIGPNGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8B41A0", Offset = "0x8B31A0", VA = "0x1808B41A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8B6600", Offset = "0x8B5600", VA = "0x1808B6600")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x780AE60", Offset = "0x7809E60", VA = "0x18780AE60")]
	public static MIAEKAOKMEH ENFADGHCBGM(IEnumerator<MIAEKAOKMEH> KIDOMMFFGFF, HICLOEAMIID CKPIAGAFCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x780AFC0", Offset = "0x7809FC0", VA = "0x18780AFC0")]
	public MIAEKAOKMEH ENFADGHCBGM(HICLOEAMIID[] NGJIKJDBEBC, IEnumerator<MIAEKAOKMEH>[] JMJIKPOKAHG, MIAEKAOKMEH[] KAEENNOOFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x780B080", Offset = "0x780A080", VA = "0x18780B080")]
	public void PBPJPHHANAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x780B1F0", Offset = "0x780A1F0", VA = "0x18780B1F0")]
	public void OEGBEGIOJIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x780B0B0", Offset = "0x780A0B0", VA = "0x18780B0B0")]
	public void KFCHDKGGDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x780B080", Offset = "0x780A080", VA = "0x18780B080")]
	public void GENFIPMJGEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public CCGIPGDGCBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class MGFAKLECHAA
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct EMDFEFOHLJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public CCGIPGDGCBM FIIGLOKGCFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public BGLICCIOOAL ALFCFJMDLMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public HICLOEAMIID BENGLBBECJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public IEnumerator<MIAEKAOKMEH> MPPKJIAIKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public MIAEKAOKMEH PDKMNAFLEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public DGIKGDCFNLJ PMHKNGAECEP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct ENNIDFDMHEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IGLJHPDFCLG BPDHEIAMADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public List<EMDFEFOHLJC> LBNEDILIPPF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GEBIBABHDOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public HICLOEAMIID promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public MGFAKLECHAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public BGLICCIOOAL context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CCGIPGDGCBM routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public DGIKGDCFNLJ coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public MIAEKAOKMEH currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public IEnumerator<MIAEKAOKMEH> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GEBIBABHDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x78154B0", Offset = "0x78144B0", VA = "0x1878154B0")]
		internal void PMOCCHLENBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class CICNLADEBNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public CCGIPGDGCBM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public MGFAKLECHAA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public CICNLADEBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x780B330", Offset = "0x780A330", VA = "0x18780B330")]
		internal void OCLGHMLHFAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class FEMKPMBIMBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public CCGIPGDGCBM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public MGFAKLECHAA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public FEMKPMBIMBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7814530", Offset = "0x7813530", VA = "0x187814530")]
		internal void DILJFPKFDAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class MOHBHGIMOFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public CCGIPGDGCBM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public MGFAKLECHAA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public MOHBHGIMOFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x781FF70", Offset = "0x781EF70", VA = "0x18781FF70")]
		internal void PJNEJPELFJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private const DGIKGDCFNLJ LKFAKFDJFNP = DGIKGDCFNLJ.Cancelled | DGIKGDCFNLJ.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly IGLJHPDFCLG CBDFNHFGFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool[] KKLFNCPBJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<DGIKGDCFNLJ> PIKADLMNOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<float> CJEJEIJDLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> CEDJPEJBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> CKAMNFKKINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> GLEGFCBDDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> ONCEFINDBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> NEFFCFMIHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private CCGIPGDGCBM[] EEFMMMCEMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private HICLOEAMIID[] NGJIKJDBEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private BGLICCIOOAL[] GFNMKOKEAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IEnumerator<MIAEKAOKMEH>[] GEAMOAKJJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private MIAEKAOKMEH[] NCAPGAFNNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int NBPAEOJOMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int BHNNGJABFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly int GBJJLLONKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float FGDBBOEEGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private FEGLPJPLNMB OIJLIDKMMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private JobHandle GFACCFKNNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<CCGIPGDGCBM> KOIJBJENAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool ELBKFNFJIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> MFJIPLKADKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<Action> MCKLIGGIALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool MJBLHBIFEPP;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ENNIDFDMHEN[] LHKAHNDFDGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xC97B80", Offset = "0xC96B80", VA = "0x180C97B80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x781D1D0", Offset = "0x781C1D0", VA = "0x18781D1D0")]
	private static int JFDDIJALANC(IGLJHPDFCLG CBDFNHFGFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x781DFB0", Offset = "0x781CFB0", VA = "0x18781DFB0")]
	public MGFAKLECHAA(IGLJHPDFCLG CBDFNHFGFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x781DA70", Offset = "0x781CA70", VA = "0x18781DA70")]
	private void KOBBPELHJNF(int PEHAHFFBOML, int IFLOCEBFOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x781BE80", Offset = "0x781AE80", VA = "0x18781BE80")]
	public void EANIDIAOGDD(BGLICCIOOAL NDMMIOJEOEB, MIAEKAOKMEH AOHJMHLCBDE, IEnumerator<MIAEKAOKMEH> KIDOMMFFGFF, HICLOEAMIID CKPIAGAFCGI, [Optional] CCGIPGDGCBM ODIMCGIODEC, DGIKGDCFNLJ FDMKJABOANO = DGIKGDCFNLJ.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x781C2D0", Offset = "0x781B2D0", VA = "0x18781C2D0")]
	public void GEKDMODFHPM(IEnumerable<EMDFEFOHLJC> NPGHDNDNEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x781D200", Offset = "0x781C200", VA = "0x18781D200")]
	private EMDFEFOHLJC JIFBKPJBMBH(int CEACDKAJNAG)
	{
		return default(EMDFEFOHLJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x781CE60", Offset = "0x781BE60", VA = "0x18781CE60")]
	private void IGENDGONDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3084980", Offset = "0x3083980", VA = "0x183084980")]
	private static void GIAKMNHMILF<T>(int CEACDKAJNAG, T[] MLCCKOFPLLA, int MLDINGBBEHA, [Optional] T DDLCDMDACEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x30849D0", Offset = "0x30839D0", VA = "0x1830849D0")]
	private static void GIAKMNHMILF<T>(int CEACDKAJNAG, NativeArray<T> MLCCKOFPLLA, int MLDINGBBEHA, [Optional] T DDLCDMDACEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x781D6D0", Offset = "0x781C6D0", VA = "0x18781D6D0")]
	private void KLBLCLGEPKN(IEnumerable<EMDFEFOHLJC> NPGHDNDNEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x781C200", Offset = "0x781B200", VA = "0x18781C200")]
	private void GAGAFJEMFII(EMDFEFOHLJC NPEKDLBEANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x781BC20", Offset = "0x781AC20", VA = "0x18781BC20")]
	private GEKGFAOMDNK CDCHOGDIIJP(int AILLAODFDIL)
	{
		return default(GEKGFAOMDNK);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x781C000", Offset = "0x781B000", VA = "0x18781C000")]
	public void EHCFPDKBGFA(float IPKDBCAIOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x781DE00", Offset = "0x781CE00", VA = "0x18781DE00")]
	private void LNPNEEDGMNC(Action LGLGFADDDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x781DD80", Offset = "0x781CD80", VA = "0x18781DD80")]
	private void LJHEJCBKFDF(Action LGLGFADDDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x781C640", Offset = "0x781B640", VA = "0x18781C640")]
	public void GPEKFPCLOHF(float IPKDBCAIOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x781CD60", Offset = "0x781BD60", VA = "0x18781CD60")]
	public void HHBFEMLFOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x781C510", Offset = "0x781B510", VA = "0x18781C510")]
	public void GENFIPMJGEH(CCGIPGDGCBM KGNNHNBLGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x781DC50", Offset = "0x781CC50", VA = "0x18781DC50")]
	public void LIICCBCEKKG(CCGIPGDGCBM KGNNHNBLGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x781DE80", Offset = "0x781CE80", VA = "0x18781DE80")]
	public void PIKOKGIDJFE(CCGIPGDGCBM KGNNHNBLGBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class FBLBAFCFEHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly FBLBAFCFEHP BOAMOHHEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly Action PKDGHKHNOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private bool GNHIBNEGODJ;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	public FBLBAFCFEHP(Action PKDGHKHNOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F861E0", Offset = "0x6F851E0", VA = "0x186F861E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface LAAKFGCIICO<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T DMNEEJMINJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable GMJCEFHIBHF(UnityEngine.Object NDMMIOJEOEB, Action<T> BNLEFKCKDAF);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface EHDHLOIDNMB<T> : LAAKFGCIICO<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	new T DMNEEJMINJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class CLJJMMNGAEB<T> : EHDHLOIDNMB<T>, LAAKFGCIICO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class PMNOEANFCHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public CLJJMMNGAEB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public MDNNOAHFLIH<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public PMNOEANFCHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4BE9FA0", Offset = "0x4BE8FA0", VA = "0x184BE9FA0")]
		internal void JEPPPLBPJPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static GameObject LCENNFCAGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly List<MDNNOAHFLIH<UnityEngine.Object, Action<T>>> HMDIKEDCEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private T FBBEFPJLMMN;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public T DMNEEJMINJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9A7620", Offset = "0x9A6620", VA = "0x1809A7620", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x58FF4A0", Offset = "0x58FE4A0", VA = "0x1858FF4A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x58FF020", Offset = "0x58FE020", VA = "0x1858FF020")]
	private static bool GAOIPKMDLJL(T LGLGFADDDNK, T GMGEKOBCPAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x58FFCB0", Offset = "0x58FECB0", VA = "0x1858FFCB0")]
	public CLJJMMNGAEB(T CLMNAAIMBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x58FF2E0", Offset = "0x58FE2E0", VA = "0x1858FF2E0", Slot = "6")]
	public IDisposable GMJCEFHIBHF(UnityEngine.Object NDMMIOJEOEB, Action<T> BNLEFKCKDAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x58FF610", Offset = "0x58FE610", VA = "0x1858FF610")]
	private void LBGMLKHMOGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class KNNLBPHEBHM : JALHDHKMMPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly ADNJPBFMOOO CPMPOEHDNGG;

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x781B140", Offset = "0x781A140", VA = "0x18781B140")]
	[AEDCCIMPEFD.GIGKNHONDJE]
	internal static void JGCLGABJKFK(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	[UnityEngine.Scripting.Preserve]
	internal KNNLBPHEBHM([GAHPILLNNBL(null)] ADNJPBFMOOO CPMPOEHDNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x781B1B0", Offset = "0x781A1B0", VA = "0x18781B1B0", Slot = "4")]
	public IDisposable OONPJNNPNEO(float EICHKAJPLFO, Action<float> BLNJHEMNIGB, bool AMDHAOKCPDL = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class IEMAJKDJLDM : MPGFLDEGFHK, ADNJPBFMOOO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private MGFAKLECHAA[] LGBAPPMJPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private NAFCPIPKIAF HENBDMDBNAH;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7818AB0", Offset = "0x7817AB0", VA = "0x187818AB0")]
	[AEDCCIMPEFD.GIGKNHONDJE]
	internal static void LPMGDCHBOCO(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7818D80", Offset = "0x7817D80", VA = "0x187818D80")]
	[UnityEngine.Scripting.Preserve]
	public IEMAJKDJLDM([GAHPILLNNBL(null)] OFOFAHLMHDE FLLCMJCBMPF, [GAHPILLNNBL(null)] GFBGLICDLGK IEHLGGJLHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x78181E0", Offset = "0x78171E0", VA = "0x1878181E0", Slot = "19")]
	public override DDGDFMBPLHP CLKBGKFMLFD(BGLICCIOOAL NDMMIOJEOEB, IEnumerator<MIAEKAOKMEH> BIDAGNMNKAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7818310", Offset = "0x7817310", VA = "0x187818310", Slot = "20")]
	public override void CMJEOBEPHJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7818B50", Offset = "0x7817B50", VA = "0x187818B50", Slot = "22")]
	public override void OPAPNDFOLGC(IGLJHPDFCLG CBDFNHFGFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7818600", Offset = "0x7817600", VA = "0x187818600", Slot = "21")]
	protected override void ECKIEDCBBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7818B20", Offset = "0x7817B20", VA = "0x187818B20")]
	private MGFAKLECHAA MJFDJNOEFNN(IGLJHPDFCLG PFCMGBLCCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7818770", Offset = "0x7817770", VA = "0x187818770", Slot = "23")]
	internal override IIOEIJDPENO EDJABLANDKA(IEnumerator<MIAEKAOKMEH> BIDAGNMNKAA, Behaviour NDMMIOJEOEB, HICLOEAMIID CKPIAGAFCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7818120", Offset = "0x7817120", VA = "0x187818120", Slot = "24")]
	internal override MOGIKLKIKMB AFLIJLODEGO(IGLJHPDFCLG EDFAINEAOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7818990", Offset = "0x7817990", VA = "0x187818990")]
	private void HNFJBFCMDBG(MGFAKLECHAA CNLPKELBGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x78185A0", Offset = "0x78175A0", VA = "0x1878185A0", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct FEGLPJPLNMB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public float KNINNJJOJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	public int LDNMKMEEPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> ONFLEMEPGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> PCDLBDJNPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NativeArray<int> DDFIKDCACDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<DGIKGDCFNLJ> ABKPBFBEPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	public NativeArray<float> JMGIKAAJJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> GLEGFCBDDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[WriteOnly]
	public NativeArray<int> CEDJPEJBFHJ;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7814250", Offset = "0x7813250", VA = "0x187814250")]
	public static FEGLPJPLNMB AIOPMLNOOEO(int BPMHAOJOEBM, float IPKDBCAIOEA, NativeArray<DGIKGDCFNLJ> MMKGOMLBHAA, NativeArray<float> DMNGIDKKCOF, NativeArray<int> GJBGEAMMFJP, NativeArray<int> ILGNLDNIDPO, NativeArray<int> FMFNIMIJCJP, NativeArray<int> PCDLBDJNPIM, NativeArray<int> DDFIKDCACDN)
	{
		return default(FEGLPJPLNMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x78142B0", Offset = "0x78132B0", VA = "0x1878142B0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7814210", Offset = "0x7813210", VA = "0x187814210")]
	private bool AHMFDOPPJFG(int KHAIDMGPIED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7814390", Offset = "0x7813390", VA = "0x187814390")]
	private void HFGKNFHHCCI(NativeArray<int> MKNDJGDIGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7814490", Offset = "0x7813490", VA = "0x187814490")]
	private int NLODIBMDMPN(int PEBBGDKODAI, int BEMKBAAKJMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x78143C0", Offset = "0x78133C0", VA = "0x1878143C0")]
	private void MMDJCJBJDHP(NativeArray<int> MKNDJGDIGHE, int LJJCADPKKCJ, int AAGDOBFBLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7813FD0", Offset = "0x7812FD0", VA = "0x187813FD0")]
	private void ABHOFGFGJKM(NativeArray<int> MKNDJGDIGHE, int GEELGDJEKGL, int DHMMONKENHH, int CHMOAKNHLMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class MPGFLDEGFHK : ADNJPBFMOOO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly OFOFAHLMHDE FLLCMJCBMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected readonly GFBGLICDLGK IEHLGGJLHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private MOGIKLKIKMB[] IFBAAEBEKCN;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static ADNJPBFMOOO LONLOOPDCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7820230", Offset = "0x781F230", VA = "0x187820230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static bool GIKNMPKMNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IGLJHPDFCLG FPACFAECOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B41A0", Offset = "0x8B31A0", VA = "0x1808B41A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(IGLJHPDFCLG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B6600", Offset = "0x8B5600", VA = "0x1808B6600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public GFBGLICDLGK DADAHCOOHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MIAEKAOKMEH NHMJFMONEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MIAEKAOKMEH EAIDBDHDLPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public MIAEKAOKMEH HAHHEKKNCGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MIAEKAOKMEH LLAJIAEHOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B42A0", Offset = "0x8B32A0", VA = "0x1808B42A0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x78209D0", Offset = "0x781F9D0", VA = "0x1878209D0")]
	public static DDGDFMBPLHP GBLOLBCAEIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7820F10", Offset = "0x781FF10", VA = "0x187820F10")]
	[UnityEngine.Scripting.Preserve]
	protected MPGFLDEGFHK([GAHPILLNNBL(null)] OFOFAHLMHDE FLLCMJCBMPF, [GAHPILLNNBL(null)] GFBGLICDLGK IEHLGGJLHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7820AA0", Offset = "0x781FAA0", VA = "0x187820AA0", Slot = "6")]
	public DDGDFMBPLHP LAHPNPBPBKK(IEnumerator<MIAEKAOKMEH> BIDAGNMNKAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7820AB0", Offset = "0x781FAB0", VA = "0x187820AB0", Slot = "7")]
	public DDGDFMBPLHP LAHPNPBPBKK(Behaviour NDMMIOJEOEB, IEnumerator<MIAEKAOKMEH> BIDAGNMNKAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract DDGDFMBPLHP CLKBGKFMLFD(BGLICCIOOAL NDMMIOJEOEB, IEnumerator<MIAEKAOKMEH> BIDAGNMNKAA);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7820410", Offset = "0x781F410", VA = "0x187820410", Slot = "20")]
	public virtual void CMJEOBEPHJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x781FFB0", Offset = "0x781EFB0", VA = "0x18781FFB0", Slot = "9")]
	public void ACIHPHLOIAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7820990", Offset = "0x781F990", VA = "0x187820990", Slot = "21")]
	protected virtual void ECKIEDCBBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7820A80", Offset = "0x781FA80", VA = "0x187820A80")]
	private void IKKLONEKFON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x78205B0", Offset = "0x781F5B0", VA = "0x1878205B0")]
	private void DPFPJCAJPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x78203F0", Offset = "0x781F3F0", VA = "0x1878203F0")]
	private void CEKFMPIEFID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x78209B0", Offset = "0x781F9B0", VA = "0x1878209B0")]
	private void FPMBLCIMKKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x78201F0", Offset = "0x781F1F0", VA = "0x1878201F0")]
	private void BBGCODGNGCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7820210", Offset = "0x781F210", VA = "0x187820210")]
	private void BFBFDFBNCJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7820A60", Offset = "0x781FA60", VA = "0x187820A60")]
	private void GHIKDAILLII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7820E80", Offset = "0x781FE80", VA = "0x187820E80", Slot = "22")]
	public virtual void OPAPNDFOLGC(IGLJHPDFCLG CBDFNHFGFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7820CB0", Offset = "0x781FCB0", VA = "0x187820CB0")]
	private void ODGBILLKAOB(MOGIKLKIKMB CNLPKELBGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x21FA4E0", Offset = "0x21F94E0", VA = "0x1821FA4E0")]
	private MOGIKLKIKMB MFBBIHIEMJO(IGLJHPDFCLG PFCMGBLCCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract IIOEIJDPENO EDJABLANDKA(IEnumerator<MIAEKAOKMEH> BIDAGNMNKAA, Behaviour NDEOLIKHBMH, HICLOEAMIID JJMEHFPDJNA);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract MOGIKLKIKMB AFLIJLODEGO(IGLJHPDFCLG CBDFNHFGFAH);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x78205D0", Offset = "0x781F5D0", VA = "0x1878205D0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x78202A0", Offset = "0x781F2A0", VA = "0x1878202A0", Slot = "15")]
	public MIAEKAOKMEH BNFLAEGNFGM(IGLJHPDFCLG EDFAINEAOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7820360", Offset = "0x781F360", VA = "0x187820360", Slot = "16")]
	public MIAEKAOKMEH CCLNFDMFKCE(float OPFDDHFIGGD, IGLJHPDFCLG EDFAINEAOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7820300", Offset = "0x781F300", VA = "0x187820300", Slot = "17")]
	public MIAEKAOKMEH BNOIONIIGPA(Func<bool> PAHLJNPBBFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class IIOEIJDPENO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly HICLOEAMIID CKPIAGAFCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly DLBJHOMBLGA NDMMIOJEOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool PIGFKCECLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private string DMCFPOLFNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private StackTrace GNAEJJMANHG;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerator<MIAEKAOKMEH> MPPKJIAIKNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BD0", Offset = "0x8B8BD0", VA = "0x1808B9BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public MIAEKAOKMEH PDKMNAFLEFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5690", VA = "0x1808B6690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool BPLEAMFECLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7819020", Offset = "0x7818020", VA = "0x187819020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool GGDPLOOHDIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9CFA20", Offset = "0x9CEA20", VA = "0x1809CFA20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9E97A0", Offset = "0x9E87A0", VA = "0x1809E97A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string KKNEIOOKBDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7819480", Offset = "0x7818480", VA = "0x187819480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float ICFKNMAHAAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xC5F190", Offset = "0xC5E190", VA = "0x180C5F190")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xE8E3F0", Offset = "0xE8D3F0", VA = "0x180E8E3F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7819710", Offset = "0x7818710", VA = "0x187819710")]
	public IIOEIJDPENO(IEnumerator<MIAEKAOKMEH> KIDOMMFFGFF, DLBJHOMBLGA NDMMIOJEOEB, HICLOEAMIID CKPIAGAFCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x78190A0", Offset = "0x78180A0", VA = "0x1878190A0")]
	public MIAEKAOKMEH ENFADGHCBGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7819410", Offset = "0x7818410", VA = "0x187819410")]
	public bool LDKFIPIDLIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x78193C0", Offset = "0x78183C0", VA = "0x1878193C0")]
	public void GENFIPMJGEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7819630", Offset = "0x7818630", VA = "0x187819630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x9E9E50", Offset = "0x9E8E50", VA = "0x1809E9E50")]
	[CompilerGenerated]
	private void KEGGNLPPGCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class HICLOEAMIID : LALJJBCFLND, DDGDFMBPLHP, EDMIDDLGGJL, KKJPAEAJCIM, IEnumerator, MIAEKAOKMEH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private IGLJHPDFCLG JPBEKNALIPF;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private IGLJHPDFCLG ACANBOFCDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9CF360", Offset = "0x9CE360", VA = "0x1809CF360", Slot = "23")]
		get
		{
			return default(IGLJHPDFCLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public IGLJHPDFCLG GMIHJBGDFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xB469A0", Offset = "0xB459A0", VA = "0x180B469A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private float CKBIDJBDPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xADD3B0", Offset = "0xADC3B0", VA = "0x180ADD3B0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool HIFNDEBDJED
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7816E30", Offset = "0x7815E30", VA = "0x187816E30", Slot = "24")]
	private bool AIFMINPMMME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7816E50", Offset = "0x7815E50", VA = "0x187816E50", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7816E60", Offset = "0x7815E60", VA = "0x187816E60")]
	public HICLOEAMIID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum GEKGFAOMDNK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class MOGIKLKIKMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum GAFIBLILAKE
	{
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct EJBGPNOBNEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public IGLJHPDFCLG BPDHEIAMADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GAFIBLILAKE NJPIMPOFELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public List<IIOEIJDPENO> AHIHEKJMFBL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly GAFIBLILAKE[] PFECDMDCKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly IGLJHPDFCLG CBDFNHFGFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool LOCHIPGFEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly IIOEIJDPENO[] PDCGAGBBKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly List<IIOEIJDPENO> GJJFGEHOOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<int> FILNHLOEJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<IIOEIJDPENO> PNLADAEIGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<int> HHGLICMDIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly NAFCPIPKIAF AFEIPLDJILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private bool MJBLHBIFEPP;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public EJBGPNOBNEC[,] EKEFNJAEABF
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x781FAF0", Offset = "0x781EAF0", VA = "0x18781FAF0")]
	public MOGIKLKIKMB(IGLJHPDFCLG EDFAINEAOAB, NAFCPIPKIAF AFEIPLDJILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x781F7D0", Offset = "0x781E7D0", VA = "0x18781F7D0")]
	public void LLKCOJLMJFO(IIOEIJDPENO KIDOMMFFGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x781F050", Offset = "0x781E050", VA = "0x18781F050")]
	public void GNGFJIHLCNH(IList<IIOEIJDPENO> JMJIKPOKAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x781ED50", Offset = "0x781DD50", VA = "0x18781ED50")]
	public void FEFPJMAABME(IList<IIOEIJDPENO> JMJIKPOKAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x781F8D0", Offset = "0x781E8D0", VA = "0x18781F8D0")]
	private void OAHNLOJOJLH(IIOEIJDPENO KIDOMMFFGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x781EBC0", Offset = "0x781DBC0", VA = "0x18781EBC0")]
	private void FDBJAHIFAGE(IList<IIOEIJDPENO> JMJIKPOKAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x781F350", Offset = "0x781E350", VA = "0x18781F350")]
	private GEKGFAOMDNK IPMBCEPEEBL(IIOEIJDPENO KIDOMMFFGFF)
	{
		return default(GEKGFAOMDNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x781EA50", Offset = "0x781DA50", VA = "0x18781EA50")]
	public void ECKIEDCBBJB(float IPKDBCAIOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x781E600", Offset = "0x781D600", VA = "0x18781E600")]
	public void ACIHPHLOIAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x781F4D0", Offset = "0x781E4D0", VA = "0x18781F4D0")]
	private void LABBIMGNCKB(List<IIOEIJDPENO> JMJIKPOKAHG, Stack<int> DLMMIDGCDPP, bool BOHNFAEGKEG, float LKFBCFLHGBH = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x781E930", Offset = "0x781D930", VA = "0x18781E930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x781E7F0", Offset = "0x781D7F0", VA = "0x18781E7F0")]
	private void BEJMADLONKK(List<IIOEIJDPENO> JMJIKPOKAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class OGMAHBAMNOE : NAFCPIPKIAF
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "4")]
	public void IDMCHDOBIMH(string DMCFPOLFNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
	public void CLLGHEPOFID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public OGMAHBAMNOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class KJHBNOCAGAM : DLBJHOMBLGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly Behaviour NDEOLIKHBMH;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string KKNEIOOKBDG
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x781B040", Offset = "0x781A040", VA = "0x18781B040", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool DPEGCPBDAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x781AFF0", Offset = "0x7819FF0", VA = "0x18781AFF0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool AOFJBINLLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x781AFD0", Offset = "0x7819FD0", VA = "0x18781AFD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	public KJHBNOCAGAM(Behaviour NDEOLIKHBMH)
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

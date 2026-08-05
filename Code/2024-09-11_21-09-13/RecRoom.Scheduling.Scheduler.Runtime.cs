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
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x74C5030", Offset = "0x74C3630", VA = "0x1874C5030", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x624B890", Offset = "0x6249E90", VA = "0x18624B890")]
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
		private delegate List<PlayerLoopSystem> GPGMJABACDM(List<PlayerLoopSystem> ABGGKOLFGED, int HNJDNFHAMDO);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct ADMOIICJCCG
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct HAPNDPBIGBP
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static GHNLMGKLHKE GANEIOMHLJK;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x74BD670", Offset = "0x74BBC70", VA = "0x1874BD670")]
				public static PlayerLoopSystem DKMLAMKGFOE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct MJMOOMPIHIM
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static GHNLMGKLHKE PDAHJDEMECK;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x74C1460", Offset = "0x74BFA60", VA = "0x1874C1460")]
				public static PlayerLoopSystem DKMLAMKGFOE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct BLDHMAGEHAO
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static GHNLMGKLHKE OMNEEMBCFMM;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x74AD060", Offset = "0x74AB660", VA = "0x1874AD060")]
				public static PlayerLoopSystem DKMLAMKGFOE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct COMICMJADPO
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static GHNLMGKLHKE JMMJHPOMOEM;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static GHNLMGKLHKE PDGDHFEDJLB;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static GHNLMGKLHKE DGOFFNOFNEP;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static GHNLMGKLHKE AKGJIBOOPMP;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x74B0F10", Offset = "0x74AF510", VA = "0x1874B0F10")]
				public static PlayerLoopSystem DKMLAMKGFOE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct NEIAHONJHNB
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static GHNLMGKLHKE MGPNIHNDHEI;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x74C1A50", Offset = "0x74C0050", VA = "0x1874C1A50")]
				public static PlayerLoopSystem DKMLAMKGFOE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct PKOKJMFFIBL
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static GHNLMGKLHKE JMMJHPOMOEM;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static GHNLMGKLHKE PDGDHFEDJLB;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static GHNLMGKLHKE DGOFFNOFNEP;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static GHNLMGKLHKE AKGJIBOOPMP;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x74C3D70", Offset = "0x74C2370", VA = "0x1874C3D70")]
				public static PlayerLoopSystem DKMLAMKGFOE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct PDPNFNJBBMJ
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static GHNLMGKLHKE CHMDLIONIBJ;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x74C3A60", Offset = "0x74C2060", VA = "0x1874C3A60")]
				public static PlayerLoopSystem DKMLAMKGFOE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct ONGOLOIFEBO
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static GHNLMGKLHKE KFKNEFBHBGF;

				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x74C2DC0", Offset = "0x74C13C0", VA = "0x1874C2DC0")]
				public static PlayerLoopSystem DKMLAMKGFOE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct MIGJKNHMMAD
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static GHNLMGKLHKE LHMMGOGPNCP;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x74C1280", Offset = "0x74BF880", VA = "0x1874C1280")]
				public static PlayerLoopSystem DKMLAMKGFOE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct BMMOOOADLLJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static GHNLMGKLHKE OCPOHOBGNAI;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x74ADF20", Offset = "0x74AC520", VA = "0x1874ADF20")]
				public static PlayerLoopSystem DKMLAMKGFOE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct DDIAGBJKJGH
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static GHNLMGKLHKE ABIGKDNFMDM;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x74B5170", Offset = "0x74B3770", VA = "0x1874B5170")]
				public static PlayerLoopSystem DKMLAMKGFOE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct NNLACGGPLJF
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static GHNLMGKLHKE GNBOPNJOCHJ;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x74C1DA0", Offset = "0x74C03A0", VA = "0x1874C1DA0")]
				public static PlayerLoopSystem DKMLAMKGFOE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct FKGEGIDFMIA
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static GHNLMGKLHKE DAMINELDNJI;

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x74BB350", Offset = "0x74B9950", VA = "0x1874BB350")]
				public static PlayerLoopSystem DKMLAMKGFOE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum JMEFOCODLNC : byte
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
			public struct DFHEACKHKIB
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class PNIECFEGKAD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public JMEFOCODLNC updateStage;

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
					public PNIECFEGKAD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x74C4040", Offset = "0x74C2640", VA = "0x1874C4040")]
					internal void PHEAIAMHHHK()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static KHECJJJIFBB<JMEFOCODLNC> FFMPNODLKOB;

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x74B59A0", Offset = "0x74B3FA0", VA = "0x1874B59A0")]
				public static PlayerLoopSystem DKMLAMKGFOE(JMEFOCODLNC HJEBPEFNBMD)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			internal struct IGLNJAOLNAJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000024")]
				[CompilerGenerated]
				private sealed class NONBIBAIDKC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public CBGNDEMDNDJ.GKMKCILLAMH key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
					public NONBIBAIDKC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x74C1F80", Offset = "0x74C0580", VA = "0x1874C1F80")]
					internal void GJANJHDOOHP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable GPEONDAJKLH;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x74BF340", Offset = "0x74BD940", VA = "0x1874BF340")]
				public static PlayerLoopSystem KGDGDGGEEGH(CBGNDEMDNDJ.GKMKCILLAMH LFOBGDLOPID)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			internal struct LDLGNNFDEDD
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class MLNIPNGFNKI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public CBGNDEMDNDJ.GKMKCILLAMH key;

					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
					public MLNIPNGFNKI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0x74C1750", Offset = "0x74BFD50", VA = "0x1874C1750")]
					internal void GJANJHDOOHP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x74C0290", Offset = "0x74BE890", VA = "0x1874C0290")]
				public static PlayerLoopSystem KGDGDGGEEGH(CBGNDEMDNDJ.GKMKCILLAMH LFOBGDLOPID)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class EONDMBKLNNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public EONDMBKLNNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x74B66D0", Offset = "0x74B4CD0", VA = "0x1874B66D0")]
			internal List<PlayerLoopSystem> PKNBIDBICLN(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool EOPAONACAJC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool CJNIKOBDNAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x74B4690", Offset = "0x74B2C90", VA = "0x1874B4690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x74B11E0", Offset = "0x74AF7E0", VA = "0x1874B11E0")]
		private static void APNEBHKDANJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74B3D80", Offset = "0x74B2380", VA = "0x1874B3D80")]
		private static void CJOHAGAAFAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x74B3D40", Offset = "0x74B2340", VA = "0x1874B3D40")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74B4DA0", Offset = "0x74B33A0", VA = "0x1874B4DA0")]
		private static void OPPAEBFDMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74B4BE0", Offset = "0x74B31E0", VA = "0x1874B4BE0")]
		private static void JNEGMLAHKHE(CBGNDEMDNDJ.GKMKCILLAMH LFOBGDLOPID, PlayerLoopSystem CEJOBLADOBF, Type JLJJHMNGFIM, Type DGACEGALLPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x74B4800", Offset = "0x74B2E00", VA = "0x1874B4800")]
		private static void GCMEDABHCPI(PlayerLoopSystem CEJOBLADOBF, Type JLJJHMNGFIM, Type DGACEGALLPF, GPGMJABACDM DKGHMCLJGAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x74B46D0", Offset = "0x74B2CD0", VA = "0x1874B46D0")]
		private static void FKKEIBOPLHB(PlayerLoopSystem CEJOBLADOBF, Type JLJJHMNGFIM, Type DGACEGALLPF, PlayerLoopSystem? BJJJOFBIDIE, PlayerLoopSystem? NCICIIMNBDC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class CBGNDEMDNDJ
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum GKMKCILLAMH
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
	public class JLKGMAIMCFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly GKMKCILLAMH ADBJJDBMBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly GPBNICDFFGJ FIOOMABLDJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private long IILEEIMAJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long BDKEMEBAINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long BNPKFGBHLDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int IBLBJGMOMLI;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x74BFCE0", Offset = "0x74BE2E0", VA = "0x1874BFCE0")]
		public JLKGMAIMCFI(GKMKCILLAMH HBOHFLKJOLC, int MDLNMJNNBLE = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x74BFA40", Offset = "0x74BE040", VA = "0x1874BFA40")]
		public void BOFKIAKADKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x74BFC90", Offset = "0x74BE290", VA = "0x1874BFC90")]
		public void MBJMAOOLHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x74BFAB0", Offset = "0x74BE0B0", VA = "0x1874BFAB0")]
		public void EANAKFDAEEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static GKMKCILLAMH[] CKMHNGEEHOF;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static JLKGMAIMCFI[] NHOCHABKEHH;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x74AE100", Offset = "0x74AC700", VA = "0x1874AE100")]
	public static JLKGMAIMCFI HMPGPBLJEPM(GKMKCILLAMH LFOBGDLOPID, int MDLNMJNNBLE = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x74AE380", Offset = "0x74AC980", VA = "0x1874AE380")]
	public static JLKGMAIMCFI JMJPKGILGCG(GKMKCILLAMH LFOBGDLOPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74AE2E0", Offset = "0x74AC8E0", VA = "0x1874AE2E0")]
	public static void HPMEJPBLMMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class GPBNICDFFGJ : FMCECJDHLGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int MFLDCMKNBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Queue<double> GEAMCCIMGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double GDAPDOPOOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double EMFANHEMBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double EOPJCNKBBDN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double MKGDIDCEJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x74BD4F0", Offset = "0x74BBAF0", VA = "0x1874BD4F0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double GDJOPNOBMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1C9D430", Offset = "0x1C9BA30", VA = "0x181C9D430", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double BPBADMEJAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2055970", Offset = "0x2053F70", VA = "0x182055970", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x74BD5C0", Offset = "0x74BBBC0", VA = "0x1874BD5C0")]
	public GPBNICDFFGJ(int PBHHFNHJLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x74BD3D0", Offset = "0x74BB9D0", VA = "0x1874BD3D0", Slot = "7")]
	public void AAGMNKOFDNI(double AAJFAHDADNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x74BD550", Offset = "0x74BBB50", VA = "0x1874BD550", Slot = "8")]
	public void LFBMALNLGLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class DADECPBJICO : FMCECJDHLGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private long FIGHABPEBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double MGPKONEGIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double FJDLKNOANCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double ODAOLNAGHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double MHEMPKKCFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double GDAPDOPOOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double EMFANHEMBJM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double GDJOPNOBMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6100530", Offset = "0x60FEB30", VA = "0x186100530", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double BPBADMEJAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6100540", Offset = "0x60FEB40", VA = "0x186100540", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double OBGBGBEOFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6100550", Offset = "0x60FEB50", VA = "0x186100550")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double MKGDIDCEJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2658270", Offset = "0x2656870", VA = "0x182658270", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x74B4FE0", Offset = "0x74B35E0", VA = "0x1874B4FE0", Slot = "7")]
	public virtual void AAGMNKOFDNI(double AAJFAHDADNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74B5100", Offset = "0x74B3700", VA = "0x1874B5100", Slot = "8")]
	public virtual void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x74B5140", Offset = "0x74B3740", VA = "0x1874B5140")]
	public DADECPBJICO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NLCMMPFGIIB : DADECPBJICO
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double BEMPEMEPJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6100580", Offset = "0x60FEB80", VA = "0x186100580")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x61009D0", Offset = "0x60FEFD0", VA = "0x1861009D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x74C1C30", Offset = "0x74C0230", VA = "0x1874C1C30", Slot = "7")]
	public override void AAGMNKOFDNI(double AAJFAHDADNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x74C1D60", Offset = "0x74C0360", VA = "0x1874C1D60", Slot = "8")]
	public override void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x74B5140", Offset = "0x74B3740", VA = "0x1874B5140")]
	public NLCMMPFGIIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface FMCECJDHLGB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double MKGDIDCEJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double GDJOPNOBMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double BPBADMEJAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class GAJCBAHHPAP
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface MNHDDPBJLEO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool MJDPFGPPMMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IKFNBHIKIAK();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class COPGJIPADJE : MNHDDPBJLEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly Action PMCMEAHOBEF;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool MJDPFGPPMMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
		public COPGJIPADJE(Action PMCMEAHOBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xACF9C0", Offset = "0xACDFC0", VA = "0x180ACF9C0", Slot = "5")]
		public void IKFNBHIKIAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<MNHDDPBJLEO> DNMHJBPIJLK;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x74BBF90", Offset = "0x74BA590", VA = "0x1874BBF90")]
	public static void GPGACKLOACK(Action PMCMEAHOBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x74BBC90", Offset = "0x74BA290", VA = "0x1874BBC90")]
	private static void CABLBNGKBBE(MNHDDPBJLEO MMCKDJBHIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x74BC030", Offset = "0x74BA630", VA = "0x1874BC030")]
	private static void MPCAHIPGCLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x74BBE90", Offset = "0x74BA490", VA = "0x1874BBE90")]
	private static void GABIHHHPPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x74BBBC0", Offset = "0x74BA1C0", VA = "0x1874BBBC0")]
	private static void BEEONIFJPKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class FHGBHJIFOGF
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct LGNOPBFNIJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public TaskCompletionSource<Scene> PEEFPIPMMGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly string BFMPCJDOKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly LoadSceneMode HPAOIPFPPJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly bool NGJHJADFEEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x74C03C0", Offset = "0x74BE9C0", VA = "0x1874C03C0")]
		public LGNOPBFNIJE(TaskCompletionSource<Scene> CFGILIGCGBD, string BFMPCJDOKPD, LoadSceneMode HPAOIPFPPJO, bool NGJHJADFEEB, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct LIODHLMONBA : IAsyncStateMachine
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
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private APPPBJLIGLH<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x74C0420", Offset = "0x74BEA20", VA = "0x1874C0420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x74C0CC0", Offset = "0x74BF2C0", VA = "0x1874C0CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct GMNFNHFINBP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x74BD060", Offset = "0x74BB660", VA = "0x1874BD060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x74BD370", Offset = "0x74BB970", VA = "0x1874BD370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct LLLPJAIDECK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private LGNOPBFNIJE <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x74C0D30", Offset = "0x74BF330", VA = "0x1874C0D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x74C10E0", Offset = "0x74BF6E0", VA = "0x1874C10E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class HNIDMOJOFLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IFJDAICJPOM<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public HNIDMOJOFLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x74BE9C0", Offset = "0x74BCFC0", VA = "0x1874BE9C0")]
		internal void AMPOKLKLGNB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct BEGOBPJMKED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

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
		private HNIDMOJOFLM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private APPPBJLIGLH<string>.LANPOEPHMID <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private APPPBJLIGLH<string>.LANPOEPHMID <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x74AC490", Offset = "0x74AAA90", VA = "0x1874AC490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x74ACFF0", Offset = "0x74AB5F0", VA = "0x1874ACFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct EOJDJJFJGDL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x74B6190", Offset = "0x74B4790", VA = "0x1874B6190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x74B6660", Offset = "0x74B4C60", VA = "0x1874B6660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct EOPHFEBGNGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private APPPBJLIGLH<string>.LANPOEPHMID <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private APPPBJLIGLH<string>.LANPOEPHMID <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x74B67F0", Offset = "0x74B4DF0", VA = "0x1874B67F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x74B7310", Offset = "0x74B5910", VA = "0x1874B7310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class KFGAJPLAFEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public KFGAJPLAFEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x74C00D0", Offset = "0x74BE6D0", VA = "0x1874C00D0")]
		internal bool PPALBNAPMCH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class DENKAONOCLD : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public IKMBNOHICPK onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public DENKAONOCLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x74B5910", Offset = "0x74B3F10", VA = "0x1874B5910", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x74B5590", Offset = "0x74B3B90", VA = "0x1874B5590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x74B5540", Offset = "0x74B3B40", VA = "0x1874B5540")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x74B58C0", Offset = "0x74B3EC0", VA = "0x1874B58C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class GJIOPMODNKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IFJDAICJPOM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public GJIOPMODNKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x74BCD80", Offset = "0x74BB380", VA = "0x1874BCD80")]
		internal bool GHLKOJMFJFL(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x74BCE00", Offset = "0x74BB400", VA = "0x1874BCE00")]
		internal void NHJGAPBOENM(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class ODIFPJKILAI : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public IFJDAICJPOM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private GJIOPMODNKK <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public ODIFPJKILAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x74C26D0", Offset = "0x74C0CD0", VA = "0x1874C26D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x74C2D30", Offset = "0x74C1330", VA = "0x1874C2D30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly ICollection<string> EMCFGNNGFAA;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static EOHNLEPDLDE AMLCBCIMCID;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static AsyncOperation AAFMMGLFFFO;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static EOHNLEPDLDE PHJCEHEHOML;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static string MLJBLGAJDID;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static ThreadPriority KHLLCJJNMID;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static Task HIIPOBEGDOF;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static List<SceneInstance> JOIDMBOPMPG;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly Queue<LGNOPBFNIJE> NPLDGGIBAFL;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static Task EMNNIHBPIAE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool NCEKBODJEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x74B85C0", Offset = "0x74B6BC0", VA = "0x1874B85C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private static bool FPLEOCKNHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x74B8250", Offset = "0x74B6850", VA = "0x1874B8250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private static bool HKFLBEKNKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x74B8980", Offset = "0x74B6F80", VA = "0x1874B8980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool LOBNCKMNGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x74B7B90", Offset = "0x74B6190", VA = "0x1874B7B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> NPHKFNOAMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x74B75C0", Offset = "0x74B5BC0", VA = "0x1874B75C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x74B8870", Offset = "0x74B6E70", VA = "0x1874B8870")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x74B76D0", Offset = "0x74B5CD0", VA = "0x1874B76D0")]
	[MGLPINNJGGC(CLPKIHJHCPA.EnteredEditModeNextFrame, 0)]
	private static void CKNKEMLDEPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x74B7A40", Offset = "0x74B6040", VA = "0x1874B7A40")]
	[AsyncStateMachine(typeof(LIODHLMONBA))]
	public static Task<Scene> EFFLHAHGBON(string BFMPCJDOKPD, LoadSceneMode HPAOIPFPPJO = LoadSceneMode.Single, bool NGJHJADFEEB = false, [Optional] APPPBJLIGLH<string>.LANPOEPHMID CCLNIPIBCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x74B8400", Offset = "0x74B6A00", VA = "0x1874B8400")]
	[AsyncStateMachine(typeof(GMNFNHFINBP))]
	private static Task KKABPOIJIDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x74B7C20", Offset = "0x74B6220", VA = "0x1874B7C20")]
	[AsyncStateMachine(typeof(LLLPJAIDECK))]
	private static Task FKLJLIPEDKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x74B77C0", Offset = "0x74B5DC0", VA = "0x1874B77C0")]
	[AsyncStateMachine(typeof(BEGOBPJMKED))]
	private static Task<Scene> DNIHKPHKNHM(string BFMPCJDOKPD, LoadSceneMode HPAOIPFPPJO, bool NGJHJADFEEB, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x74B84B0", Offset = "0x74B6AB0", VA = "0x1874B84B0")]
	private static void LKFJNHCJIGK(SceneInstance NFEPGHCPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x74B8A20", Offset = "0x74B7020", VA = "0x1874B8A20")]
	private static void PFPPCMBKOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x74B8130", Offset = "0x74B6730", VA = "0x1874B8130")]
	[AsyncStateMachine(typeof(EOJDJJFJGDL))]
	private static Task<Scene> GPAIAMOGBKO(string BFMPCJDOKPD, LoadSceneMode HPAOIPFPPJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x74B7440", Offset = "0x74B5A40", VA = "0x1874B7440")]
	private static bool BFBBBBLLBFE(string BFMPCJDOKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x74B82F0", Offset = "0x74B68F0", VA = "0x1874B82F0")]
	[AsyncStateMachine(typeof(EOPHFEBGNGK))]
	private static Task<Scene> JCJOKPEOJHI(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x74B7FB0", Offset = "0x74B65B0", VA = "0x1874B7FB0")]
	public static JAGIEECCCMP<Scene> GOODNODINFA(string BFMPCJDOKPD, LoadSceneMode HPAOIPFPPJO = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x74B7CF0", Offset = "0x74B62F0", VA = "0x1874B7CF0")]
	public static EOHNLEPDLDE GACOHBJLMDI(string BFMPCJDOKPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x74B7530", Offset = "0x74B5B30", VA = "0x1874B7530")]
	[IteratorStateMachine(typeof(DENKAONOCLD))]
	private static IEnumerator<GJDHNIMFMOA> BNMHJPLLDGD(string BFMPCJDOKPD, IKMBNOHICPK HAHPDDFPPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x74B87D0", Offset = "0x74B6DD0", VA = "0x1874B87D0")]
	[IteratorStateMachine(typeof(ODIFPJKILAI))]
	private static IEnumerator<GJDHNIMFMOA> NJNLIEOEFIB(string BFMPCJDOKPD, LoadSceneMode HPAOIPFPPJO, IFJDAICJPOM<Scene> HAHPDDFPPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x74B7910", Offset = "0x74B5F10", VA = "0x1874B7910")]
	public static bool EFCKAHPEKGN([Out] string AKDAPAGHIDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class GHGCDJMJJLC
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x74BC610", Offset = "0x74BAC10", VA = "0x1874BC610")]
	public static IDisposable JIJDMPNGMAI(this KOBKNGEGEGD EIGKPCONJCB, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x74BC510", Offset = "0x74BAB10", VA = "0x1874BC510")]
	public static IDisposable DFFJIKGLMID(this KOBKNGEGEGD EIGKPCONJCB, Action<float> NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x74BC590", Offset = "0x74BAB90", VA = "0x1874BC590")]
	public static IDisposable HPEPADJIOJK(this KOBKNGEGEGD EIGKPCONJCB, Action<float> NMJDKOJJLOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class FHNBOJOPPGB
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x74BA930", Offset = "0x74B8F30", VA = "0x1874BA930")]
	public static IDisposable AFOBJNMKGGH(this MonoBehaviour FJNDKHIIOLD, Action NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x74BA8A0", Offset = "0x74B8EA0", VA = "0x1874BA8A0")]
	public static IDisposable AFOBJNMKGGH(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x74BB070", Offset = "0x74B9670", VA = "0x1874BB070")]
	public static IDisposable KOLHFLEMELG(this MonoBehaviour FJNDKHIIOLD, Action NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x74BABC0", Offset = "0x74B91C0", VA = "0x1874BABC0")]
	public static IDisposable FDNCIOBOPBG(this MonoBehaviour FJNDKHIIOLD, Action NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x74BAC40", Offset = "0x74B9240", VA = "0x1874BAC40")]
	public static IDisposable FDNCIOBOPBG(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x74BB190", Offset = "0x74B9790", VA = "0x1874BB190")]
	public static IDisposable MELEPMCBAPM(this MonoBehaviour FJNDKHIIOLD, Action NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x74BAFF0", Offset = "0x74B95F0", VA = "0x1874BAFF0")]
	public static IDisposable KNFNNCKDPCB(this MonoBehaviour FJNDKHIIOLD, Action NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x74BA9C0", Offset = "0x74B8FC0", VA = "0x1874BA9C0")]
	public static IDisposable AHLDADMHBBI(this MonoBehaviour FJNDKHIIOLD, Action NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x74BAA70", Offset = "0x74B9070", VA = "0x1874BAA70")]
	public static IDisposable CMBEEAMPJCA(this MonoBehaviour FJNDKHIIOLD, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x74BAA40", Offset = "0x74B9040", VA = "0x1874BAA40")]
	public static IDisposable AJBBFPCFMOA(this MonoBehaviour FJNDKHIIOLD, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x74BB0F0", Offset = "0x74B96F0", VA = "0x1874BB0F0")]
	public static IDisposable LOKEDNDMDML(this MonoBehaviour FJNDKHIIOLD, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x74BAEB0", Offset = "0x74B94B0", VA = "0x1874BAEB0")]
	public static IDisposable JLGOBELHNJF(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x74BAD60", Offset = "0x74B9360", VA = "0x1874BAD60")]
	public static IDisposable GHBBONDCIHF(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x74BAF50", Offset = "0x74B9550", VA = "0x1874BAF50")]
	public static IDisposable KJOFCCJCPFA(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x74BAB20", Offset = "0x74B9120", VA = "0x1874BAB20")]
	public static IDisposable DFDPLPEHGGN(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x74BB2B0", Offset = "0x74B98B0", VA = "0x1874BB2B0")]
	public static IDisposable NPAOMCHJCIA(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x74BB210", Offset = "0x74B9810", VA = "0x1874BB210")]
	public static IDisposable MJEPAJNLIAJ(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x74BACC0", Offset = "0x74B92C0", VA = "0x1874BACC0")]
	public static IDisposable GGJEAMIMLDM(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x74BAE00", Offset = "0x74B9400", VA = "0x1874BAE00")]
	public static IDisposable IOFEPLEGMDN(this MonoBehaviour FJNDKHIIOLD, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class EJEDIBHLKFM
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class PIKAMNBJIEL : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AGFOBJNEDPO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private FPIFHBCDGFK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public PIKAMNBJIEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x74C3C40", Offset = "0x74C2240", VA = "0x1874C3C40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x74C3D20", Offset = "0x74C2320", VA = "0x1874C3D20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class MCPNKBGIDKC : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public AGFOBJNEDPO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private FPIFHBCDGFK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public MCPNKBGIDKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x74C1140", Offset = "0x74BF740", VA = "0x1874C1140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x74C1230", Offset = "0x74BF830", VA = "0x1874C1230", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x74B5E00", Offset = "0x74B4400", VA = "0x1874B5E00")]
	public static EPGCCCKMEBG AFOBJNMKGGH(Action NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x74B5C90", Offset = "0x74B4290", VA = "0x1874B5C90")]
	public static EPGCCCKMEBG AFOBJNMKGGH(Behaviour EIGKPCONJCB, Action NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x74B5D20", Offset = "0x74B4320", VA = "0x1874B5D20")]
	public static EPGCCCKMEBG AFOBJNMKGGH(Behaviour EIGKPCONJCB, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x74B5F10", Offset = "0x74B4510", VA = "0x1874B5F10")]
	[IteratorStateMachine(typeof(PIKAMNBJIEL))]
	private static IEnumerator<GJDHNIMFMOA> EFMPOBDHNGC(AGFOBJNEDPO FNMJLANICAA, Action NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x74B5E80", Offset = "0x74B4480", VA = "0x1874B5E80")]
	[IteratorStateMachine(typeof(MCPNKBGIDKC))]
	private static IEnumerator<GJDHNIMFMOA> EFMPOBDHNGC(AGFOBJNEDPO FNMJLANICAA, Action<float> NMJDKOJJLOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class EKFICGPFPKB : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class KPKJFMJFFFO : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public EKFICGPFPKB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public KPKJFMJFFFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x74C01B0", Offset = "0x74BE7B0", VA = "0x1874C01B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x74C0240", Offset = "0x74BE840", VA = "0x1874C0240", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly AGFOBJNEDPO FILNFIJCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Action JACKDBAOHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private bool AFOKBDJPNKJ;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool EPAOBLINODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x887870", Offset = "0x885E70", VA = "0x180887870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x74B60C0", Offset = "0x74B46C0", VA = "0x1874B60C0")]
	public EKFICGPFPKB(AGFOBJNEDPO FILNFIJCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x74B5FA0", Offset = "0x74B45A0", VA = "0x1874B5FA0")]
	[IteratorStateMachine(typeof(KPKJFMJFFFO))]
	private IEnumerator<GJDHNIMFMOA> NMKKFOJMJNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x74B6020", Offset = "0x74B4620", VA = "0x1874B6020", Slot = "4")]
	public void OnCompleted(Action FHCABKEHDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	public void OOOBGLGFFBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class KBJFJCKFOJK
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x74BFDF0", Offset = "0x74BE3F0", VA = "0x1874BFDF0")]
	public static EKFICGPFPKB GPOPJKKIDGI(this AGFOBJNEDPO FILNFIJCNCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class FOCMHJFFEOA
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class DDKDHILPOBI : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public JKNGPPLIKKK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public DDKDHILPOBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x74B5350", Offset = "0x74B3950", VA = "0x1874B5350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x74B53D0", Offset = "0x74B39D0", VA = "0x1874B53D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x74BB600", Offset = "0x74B9C00", VA = "0x1874BB600")]
	public static EPGCCCKMEBG AFOBJNMKGGH(float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x74BB530", Offset = "0x74B9B30", VA = "0x1874BB530")]
	public static EPGCCCKMEBG AFOBJNMKGGH(MonoBehaviour FJNDKHIIOLD, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x74BB820", Offset = "0x74B9E20", VA = "0x1874BB820")]
	public static EPGCCCKMEBG FNCINGIPGKE(MonoBehaviour FJNDKHIIOLD, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x74BB970", Offset = "0x74B9F70", VA = "0x1874BB970")]
	public static EPGCCCKMEBG ODDKFBBFHEL(KOBKNGEGEGD EIGKPCONJCB, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x74BB760", Offset = "0x74B9D60", VA = "0x1874BB760")]
	private static IEnumerator<GJDHNIMFMOA> EFMPOBDHNGC(MNIICNDGLBN AELHONDGPEG, float JOLEMMJKBFI, AGFOBJNEDPO FNMJLANICAA, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x74BB910", Offset = "0x74B9F10", VA = "0x1874BB910")]
	private static IEnumerator<GJDHNIMFMOA> GAGCJKIDAOC(MNIICNDGLBN AELHONDGPEG, float JOLEMMJKBFI, AGFOBJNEDPO FNMJLANICAA, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x74BB6D0", Offset = "0x74B9CD0", VA = "0x1874BB6D0")]
	[IteratorStateMachine(typeof(DDKDHILPOBI))]
	private static IEnumerator<GJDHNIMFMOA> EDDLBBGEAOP(JKNGPPLIKKK BCAMOIBPPPN, float JOLEMMJKBFI, AGFOBJNEDPO FNMJLANICAA, Action<float> NMJDKOJJLOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class GBEGFGODEEO
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class MLECNGEAMEJ : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public AGFOBJNEDPO queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public MLECNGEAMEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x74C1640", Offset = "0x74BFC40", VA = "0x1874C1640", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x74C1700", Offset = "0x74BFD00", VA = "0x1874C1700", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x74BC480", Offset = "0x74BAA80", VA = "0x1874BC480")]
	[IteratorStateMachine(typeof(MLECNGEAMEJ))]
	private static IEnumerator<GJDHNIMFMOA> IIAFKNGCGMI(AGFOBJNEDPO FILNFIJCNCC, Func<bool> ACJMHFFHANF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x74BC3A0", Offset = "0x74BA9A0", VA = "0x1874BC3A0")]
	public static EPGCCCKMEBG DEKFINALIKA(this MonoBehaviour FJNDKHIIOLD, Func<bool> ACJMHFFHANF, AGFOBJNEDPO FILNFIJCNCC = AGFOBJNEDPO.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class ACCNLIAFHCM
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class JFICAEEIBKL : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public AGFOBJNEDPO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public JFICAEEIBKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x74BF4B0", Offset = "0x74BDAB0", VA = "0x1874BF4B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x74BF520", Offset = "0x74BDB20", VA = "0x1874BF520", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class KCHPKHBAMME : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public AGFOBJNEDPO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private GJDHNIMFMOA <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public KCHPKHBAMME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x74BFF00", Offset = "0x74BE500", VA = "0x1874BFF00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x74BFF90", Offset = "0x74BE590", VA = "0x1874BFF90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x74A99D0", Offset = "0x74A7FD0", VA = "0x1874A99D0")]
	[IteratorStateMachine(typeof(JFICAEEIBKL))]
	private static IEnumerator<GJDHNIMFMOA> NMKKFOJMJNL(float GMOGAEOJHDH, AGFOBJNEDPO FNMJLANICAA, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x74A9450", Offset = "0x74A7A50", VA = "0x1874A9450")]
	[IteratorStateMachine(typeof(KCHPKHBAMME))]
	private static IEnumerator<GJDHNIMFMOA> CIILFMMBPBE(float GMOGAEOJHDH, AGFOBJNEDPO FNMJLANICAA, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x74A9280", Offset = "0x74A7880", VA = "0x1874A9280")]
	public static IDisposable CBCFHNBJGLN(this MonoBehaviour FJNDKHIIOLD, float GMOGAEOJHDH, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x74A96D0", Offset = "0x74A7CD0", VA = "0x1874A96D0")]
	public static EPGCCCKMEBG HDLGPAIEMJH(this MonoBehaviour FJNDKHIIOLD, float GMOGAEOJHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x74A9360", Offset = "0x74A7960", VA = "0x1874A9360")]
	public static EPGCCCKMEBG CBCFHNBJGLN(this MonoBehaviour FJNDKHIIOLD, float GMOGAEOJHDH, AGFOBJNEDPO FNMJLANICAA, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x74A9B10", Offset = "0x74A8110", VA = "0x1874A9B10")]
	public static EPGCCCKMEBG OMLNGIOJNGL(this MonoBehaviour FJNDKHIIOLD, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x74A9A70", Offset = "0x74A8070", VA = "0x1874A9A70")]
	public static EPGCCCKMEBG OMAPOIIFLIN(this MonoBehaviour FJNDKHIIOLD, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x74A9890", Offset = "0x74A7E90", VA = "0x1874A9890")]
	public static EPGCCCKMEBG MANHDCFFFEL(this MonoBehaviour FJNDKHIIOLD, Action OADEFMMDNAN, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x74A9590", Offset = "0x74A7B90", VA = "0x1874A9590")]
	public static EPGCCCKMEBG ELKLDKFDDII(this MonoBehaviour FJNDKHIIOLD, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x74A94F0", Offset = "0x74A7AF0", VA = "0x1874A94F0")]
	public static EPGCCCKMEBG DDAFKCMCHKG(this MonoBehaviour FJNDKHIIOLD, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x74A9BB0", Offset = "0x74A81B0", VA = "0x1874A9BB0")]
	private static EPGCCCKMEBG PGDGDDCKKIC(MonoBehaviour FJNDKHIIOLD, AGFOBJNEDPO FILNFIJCNCC, Action OADEFMMDNAN, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x74A9800", Offset = "0x74A7E00", VA = "0x1874A9800")]
	public static EPGCCCKMEBG KMHMALFHKAC(this MonoBehaviour FJNDKHIIOLD, float KOOGHGFOFPC, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x74A9760", Offset = "0x74A7D60", VA = "0x1874A9760")]
	public static EPGCCCKMEBG JJNNMBBFKGJ(this MonoBehaviour FJNDKHIIOLD, float KOOGHGFOFPC, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x74A9630", Offset = "0x74A7C30", VA = "0x1874A9630")]
	public static EPGCCCKMEBG FNLMJPHEIBF(this MonoBehaviour FJNDKHIIOLD, float KOOGHGFOFPC, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x74A9930", Offset = "0x74A7F30", VA = "0x1874A9930")]
	public static EPGCCCKMEBG MNAJACMMANB(this MonoBehaviour FJNDKHIIOLD, float KOOGHGFOFPC, Action OADEFMMDNAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class HPPCCGECNGE : HELBBFLMJNL, IEnumerable<HELBBFLMJNL>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly List<HELBBFLMJNL> EKHFLMFBPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool HCPAFAFFFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Action LDINEIPBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool MIEEMFBELOJ;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FOBCDJCMFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x74BF170", Offset = "0x74BD770", VA = "0x1874BF170", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MCEKEKPPPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x74BEA20", Offset = "0x74BD020", VA = "0x1874BEA20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x74BF0D0", Offset = "0x74BD6D0", VA = "0x1874BF0D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x74BF2A0", Offset = "0x74BD8A0", VA = "0x1874BF2A0")]
	public HPPCCGECNGE([Optional] Action LDINEIPBFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x74BEAC0", Offset = "0x74BD0C0", VA = "0x1874BEAC0")]
	public void FABNFHGMHGJ(HELBBFLMJNL AFDPMBKKJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x74BEBF0", Offset = "0x74BD1F0", VA = "0x1874BEBF0")]
	private void FLMKFCGALDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x74BED40", Offset = "0x74BD340", VA = "0x1874BED40", Slot = "7")]
	public bool GAFIKJLGLJN(bool LENLJCDCMCG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x74BED50", Offset = "0x74BD350", VA = "0x1874BED50", Slot = "8")]
	public bool GAFIKJLGLJN(Action PMCMEAHOBEF, bool LENLJCDCMCG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x74BF050", Offset = "0x74BD650", VA = "0x1874BF050", Slot = "9")]
	public IEnumerator<HELBBFLMJNL> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x74BF050", Offset = "0x74BD650", VA = "0x1874BF050", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PAEECFIKHGA : GIOMOFABJMP
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class EAMFBFDLOPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public PAEECFIKHGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public EAMFBFDLOPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x74B5C60", Offset = "0x74B4260", VA = "0x1874B5C60")]
		internal void BAILLPIKJNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class HKHFJNBKEGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public PAEECFIKHGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public HKHFJNBKEGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x74B5C60", Offset = "0x74B4260", VA = "0x1874B5C60")]
		internal void KCJHKNOAIPP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly float EEDNJMDKFOB;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x74BBA80", Offset = "0x74BA080", VA = "0x1874BBA80")]
	public PAEECFIKHGA(Behaviour EIGKPCONJCB, float EEDNJMDKFOB, [Optional] Action LDINEIPBFHJ, [Optional] EAPONALPEAD BCMLELHGFJA, [Optional] MNIICNDGLBN AELHONDGPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x74C30B0", Offset = "0x74C16B0", VA = "0x1874C30B0", Slot = "9")]
	protected override bool MOPEOFNBKMM(Action PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x74C2FA0", Offset = "0x74C15A0", VA = "0x1874C2FA0", Slot = "10")]
	protected override bool EPGGFLOIINM(Action PMCMEAHOBEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface HELBBFLMJNL
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool FOBCDJCMFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MCEKEKPPPON;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GAFIKJLGLJN(bool LENLJCDCMCG = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GAFIKJLGLJN(Action PMCMEAHOBEF, bool LENLJCDCMCG = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class GIOMOFABJMP : HELBBFLMJNL
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class DDLFPBPIFFN : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public GIOMOFABJMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public DDLFPBPIFFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x74B5420", Offset = "0x74B3A20", VA = "0x1874B5420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x74B54F0", Offset = "0x74B3AF0", VA = "0x1874B54F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Behaviour EIGKPCONJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action LDINEIPBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private IBILKJCONGN GGGGPHJOIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly EAPONALPEAD BCMLELHGFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	protected readonly MNIICNDGLBN AELHONDGPEG;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool FOBCDJCMFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x10475A0", Offset = "0x1045BA0", VA = "0x1810475A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action MCEKEKPPPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x74BC6C0", Offset = "0x74BACC0", VA = "0x1874BC6C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x74BCB20", Offset = "0x74BB120", VA = "0x1874BCB20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x74BCC50", Offset = "0x74BB250", VA = "0x1874BCC50")]
	protected GIOMOFABJMP(Behaviour EIGKPCONJCB, [Optional] Action LDINEIPBFHJ, [Optional] EAPONALPEAD BCMLELHGFJA, [Optional] MNIICNDGLBN AELHONDGPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x74BC9E0", Offset = "0x74BAFE0", VA = "0x1874BC9E0", Slot = "7")]
	public bool GAFIKJLGLJN(bool LENLJCDCMCG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x74BCA40", Offset = "0x74BB040", VA = "0x1874BCA40", Slot = "8")]
	public bool GAFIKJLGLJN(Action PMCMEAHOBEF, bool LENLJCDCMCG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool MOPEOFNBKMM(Action PMCMEAHOBEF);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool EPGGFLOIINM(Action PMCMEAHOBEF);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x74BC6A0", Offset = "0x74BACA0", VA = "0x1874BC6A0")]
	protected void ANIKPFOKPPH(Action PMCMEAHOBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x74BC760", Offset = "0x74BAD60", VA = "0x1874BC760")]
	protected EOHNLEPDLDE DCFDAOPBPPK(float MCPPIEMELEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x74BCAA0", Offset = "0x74BB0A0", VA = "0x1874BCAA0")]
	private void GHDFHEAEKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x74BCBC0", Offset = "0x74BB1C0", VA = "0x1874BCBC0")]
	[IteratorStateMachine(typeof(DDLFPBPIFFN))]
	private IEnumerator<GJDHNIMFMOA> MEAOPOKCFAI(float MCPPIEMELEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x74BC9A0", Offset = "0x74BAFA0", VA = "0x1874BC9A0")]
	[CompilerGenerated]
	private void FNBNPNBCNFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class OCJBDBEJBIA : GIOMOFABJMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float OFFCCJFLOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int EBAHJGIKKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float KPPIDBOIAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float[] OGAHIEADCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int LMCDLKBOPLN;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x74C2500", Offset = "0x74C0B00", VA = "0x1874C2500")]
	public OCJBDBEJBIA(Behaviour EIGKPCONJCB, float KLJPNDFHLNK, int EBAHJGIKKME, [Optional] Action LDINEIPBFHJ, float KPPIDBOIAFM = 0f, [Optional] EAPONALPEAD BCMLELHGFJA, [Optional] MNIICNDGLBN AELHONDGPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "9")]
	protected override bool MOPEOFNBKMM(Action PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x74C2300", Offset = "0x74C0900", VA = "0x1874C2300", Slot = "10")]
	protected override bool EPGGFLOIINM(Action PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x74C2280", Offset = "0x74C0880", VA = "0x1874C2280")]
	private void ADEOPNOPHDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class FPCKHJBLHCF : GIOMOFABJMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float EEDNJMDKFOB;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x74BBA80", Offset = "0x74BA080", VA = "0x1874BBA80")]
	public FPCKHJBLHCF(Behaviour EIGKPCONJCB, float EEDNJMDKFOB, [Optional] Action LDINEIPBFHJ, [Optional] EAPONALPEAD BCMLELHGFJA, [Optional] MNIICNDGLBN AELHONDGPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "9")]
	protected override bool MOPEOFNBKMM(Action PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x74BBA40", Offset = "0x74BA040", VA = "0x1874BBA40", Slot = "10")]
	protected override bool EPGGFLOIINM(Action PMCMEAHOBEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class AJPEKBJOAJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class MMNOJHDDIOG : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public MMNOJHDDIOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x74B7380", Offset = "0x74B5980", VA = "0x1874B7380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x74C1A00", Offset = "0x74C0000", VA = "0x1874C1A00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private EPGCCCKMEBG IBNIJAMCCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private KOBKNGEGEGD EIGKPCONJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Action<float> MHKGBAFILEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private AGFOBJNEDPO FILNFIJCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private float IINOEENDGFD;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x74AB5A0", Offset = "0x74A9BA0", VA = "0x1874AB5A0")]
	public AJPEKBJOAJH(KOBKNGEGEGD EIGKPCONJCB, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x74AB300", Offset = "0x74A9900", VA = "0x1874AB300")]
	private void MPGCFJFHLNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x74AB470", Offset = "0x74A9A70", VA = "0x1874AB470")]
	private void NCMKNICLOIP(string ENDMINEHNJK, Action ECFGGCCHKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x74AB280", Offset = "0x74A9880", VA = "0x1874AB280")]
	[IteratorStateMachine(typeof(MMNOJHDDIOG))]
	private IEnumerator<GJDHNIMFMOA> LDPDNEEGCFP(Action ECFGGCCHKNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x74AB220", Offset = "0x74A9820", VA = "0x1874AB220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x74AB0A0", Offset = "0x74A96A0", VA = "0x1874AB0A0")]
	[CompilerGenerated]
	private void ACMACIAKNFI(string FKDHFMCKMKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class HEJBKGDOEIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class FAMKHLLECIL : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public FAMKHLLECIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x74B7380", Offset = "0x74B5980", VA = "0x1874B7380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x74B73F0", Offset = "0x74B59F0", VA = "0x1874B73F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private EPGCCCKMEBG IBNIJAMCCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private MonoBehaviour FJNDKHIIOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action NMJDKOJJLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Action<float> MHKGBAFILEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private AGFOBJNEDPO FILNFIJCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float IINOEENDGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private bool PACAHANGGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly EAPONALPEAD BCMLELHGFJA;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x74BE480", Offset = "0x74BCA80", VA = "0x1874BE480")]
	public HEJBKGDOEIB(MonoBehaviour FJNDKHIIOLD, Action NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x74BE610", Offset = "0x74BCC10", VA = "0x1874BE610")]
	public HEJBKGDOEIB(MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x74BE7E0", Offset = "0x74BCDE0", VA = "0x1874BE7E0")]
	public HEJBKGDOEIB(MonoBehaviour FJNDKHIIOLD, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3EC7B40", Offset = "0x3EC6140", VA = "0x183EC7B40")]
	private HEJBKGDOEIB(EAPONALPEAD BCMLELHGFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x74BDDA0", Offset = "0x74BC3A0", VA = "0x1874BDDA0")]
	internal static HEJBKGDOEIB MFNHNOPKEOC(MonoBehaviour FJNDKHIIOLD, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x74BD850", Offset = "0x74BBE50", VA = "0x1874BD850")]
	private void AFOBJNMKGGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x74BE300", Offset = "0x74BC900", VA = "0x1874BE300")]
	private void PDIFBAJMMBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x74BDFD0", Offset = "0x74BC5D0", VA = "0x1874BDFD0")]
	private void MPGCFJFHLNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x74BDA70", Offset = "0x74BC070", VA = "0x1874BDA70")]
	private void EJIHILILIFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x74BE140", Offset = "0x74BC740", VA = "0x1874BE140")]
	private void NCMKNICLOIP(string ENDMINEHNJK, Action ECFGGCCHKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x74BDC90", Offset = "0x74BC290", VA = "0x1874BDC90")]
	[IteratorStateMachine(typeof(FAMKHLLECIL))]
	private IEnumerator<GJDHNIMFMOA> LDPDNEEGCFP(Action ECFGGCCHKNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x74BDA10", Offset = "0x74BC010", VA = "0x1874BDA10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x74BD980", Offset = "0x74BBF80", VA = "0x1874BD980")]
	[CompilerGenerated]
	private void BBMBJLBMJGG(string FKDHFMCKMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x74BDC00", Offset = "0x74BC200", VA = "0x1874BDC00")]
	[CompilerGenerated]
	private void FFEHNGGEHJL(string FKDHFMCKMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x74BE270", Offset = "0x74BC870", VA = "0x1874BE270")]
	[CompilerGenerated]
	private void ONONHMEOMHD(string FKDHFMCKMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x74BDD10", Offset = "0x74BC310", VA = "0x1874BDD10")]
	[CompilerGenerated]
	private void LKEPPLJGGHB(string FKDHFMCKMKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum HEAFDHCLALH : byte
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
internal sealed class KGIDICDELKC : MNIICNDGLBN
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float LADJOJMEALC
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x74C0190", Offset = "0x74BE790", VA = "0x1874C0190", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float DCANMCJKGKH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x74C01A0", Offset = "0x74BE7A0", VA = "0x1874C01A0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public double KPFLMKGJHIL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x74C0100", Offset = "0x74BE700", VA = "0x1874C0100", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x74C0120", Offset = "0x74BE720", VA = "0x1874C0120")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	internal static void MNJJOBMFJLK(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	[UnityEngine.Scripting.Preserve]
	internal KGIDICDELKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface DGOAJBEMGHD
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMJKCGEGKHB(string KJPHMNNIMDP);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOFMHGBADGK();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface LFEAOCHFPEN
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool OKKHPAEKBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool NKEDCLEGNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class JLFGMDFJNME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public CDGONIFMNAC IFKHOHEMJML;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int OAGDGHBELJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8841A0", Offset = "0x8827A0", VA = "0x1808841A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x887070", Offset = "0x885670", VA = "0x180887070")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x74BF7A0", Offset = "0x74BDDA0", VA = "0x1874BF7A0")]
	public static GJDHNIMFMOA DFCAGCFDJLI(IEnumerator<GJDHNIMFMOA> FDIEFIIIOIE, NOPMABIBALJ LCHMOEJABHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x74BF6E0", Offset = "0x74BDCE0", VA = "0x1874BF6E0")]
	public GJDHNIMFMOA DFCAGCFDJLI(NOPMABIBALJ[] NKEPIFICNLK, IEnumerator<GJDHNIMFMOA>[] LNLMPHMFEFA, GJDHNIMFMOA[] KBGJIIABPMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x74BF6B0", Offset = "0x74BDCB0", VA = "0x1874BF6B0")]
	public void BGFKMPMGPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x74BF900", Offset = "0x74BDF00", VA = "0x1874BF900")]
	public void HHHCLFMGNEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x74BF570", Offset = "0x74BDB70", VA = "0x1874BF570")]
	public void AMLKGEFJDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x74BF6B0", Offset = "0x74BDCB0", VA = "0x1874BF6B0")]
	public void FFPCHLDHDDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public JLFGMDFJNME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class CDGONIFMNAC
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct HPHAKDLOBLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public JLFGMDFJNME AGDHEEINEFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public KOBKNGEGEGD PBHDHDJFPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public NOPMABIBALJ IBKOJJAOPHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public IEnumerator<GJDHNIMFMOA> GPALELMEMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public GJDHNIMFMOA MCNKHAHCMFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public HEAFDHCLALH DHDEBKEKIDL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct PKLHIKGBHKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public AGFOBJNEDPO JIDCDBGIMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public List<HPHAKDLOBLL> PCFIHAJCMFE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class AMPOAILCEGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public NOPMABIBALJ promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public CDGONIFMNAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public KOBKNGEGEGD context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public JLFGMDFJNME routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public HEAFDHCLALH coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public GJDHNIMFMOA currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public IEnumerator<GJDHNIMFMOA> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public AMPOAILCEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x74ABCE0", Offset = "0x74AA2E0", VA = "0x1874ABCE0")]
		internal void DFFPFKNJCAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class OGDHMIJPJPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public JLFGMDFJNME schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public CDGONIFMNAC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public OGDHMIJPJPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x74C2D80", Offset = "0x74C1380", VA = "0x1874C2D80")]
		internal void OFPDNMLOICK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class ALIPMCKEPKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public JLFGMDFJNME schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public CDGONIFMNAC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public ALIPMCKEPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x74AB740", Offset = "0x74A9D40", VA = "0x1874AB740")]
		internal void LFAPCEGJPIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class JFHEGIHLGIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public JLFGMDFJNME schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public CDGONIFMNAC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public JFHEGIHLGIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x74BF470", Offset = "0x74BDA70", VA = "0x1874BF470")]
		internal void LLPNLFBOOFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private const HEAFDHCLALH DFDCBMHMLEG = HEAFDHCLALH.Cancelled | HEAFDHCLALH.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly AGFOBJNEDPO FILNFIJCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool[] CIDINDGHPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<HEAFDHCLALH> MJINJICNPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<float> DOLFNBAPODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> AAEEMEDIKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> JIHLCPCMBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> PHCIAMDEMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> PELDOBBPKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> GDGGJHJDEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private JLFGMDFJNME[] ACLKMIDJAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NOPMABIBALJ[] NKEPIFICNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private KOBKNGEGEGD[] EDCHKHCHCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IEnumerator<GJDHNIMFMOA>[] ECGAMKHHIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private GJDHNIMFMOA[] ACDHPLKOBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int PGKLIJCMPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int HCAOLDLEJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly int PNEOLMDLHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float BOHDMFCCFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private AMGHCPPBABL BEGGBCHAOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private JobHandle PJAGADPCFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<JLFGMDFJNME> OENNFGHNIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool GHNDHKNKCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> DNBLJPIHMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<Action> ABFEMODJLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool BPFKLNPOHOM;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public PKLHIKGBHKE[] KIMJLLAPNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8D4140", Offset = "0x8D2740", VA = "0x1808D4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x74AE580", Offset = "0x74ACB80", VA = "0x1874AE580")]
	private static int ABNPMMDAFNI(AGFOBJNEDPO FILNFIJCNCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x74B08E0", Offset = "0x74AEEE0", VA = "0x1874B08E0")]
	public CDGONIFMNAC(AGFOBJNEDPO FILNFIJCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x74AFD90", Offset = "0x74AE390", VA = "0x1874AFD90")]
	private void NOFIOMBMEPH(int HKDIPCGIIJF, int MAADLOAEABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x74AF500", Offset = "0x74ADB00", VA = "0x1874AF500")]
	public void MDAECMAGFMH(KOBKNGEGEGD EIGKPCONJCB, GJDHNIMFMOA FPLEFKBJKEN, IEnumerator<GJDHNIMFMOA> FDIEFIIIOIE, NOPMABIBALJ LCHMOEJABHG, [Optional] JLFGMDFJNME PMGPLKPJPAF, HEAFDHCLALH NFJAMJCGOBO = HEAFDHCLALH.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x74AFB50", Offset = "0x74AE150", VA = "0x1874AFB50")]
	public void NNNCAKMJNPB(IEnumerable<HPHAKDLOBLL> CAFCHIHIIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x74AF680", Offset = "0x74ADC80", VA = "0x1874AF680")]
	private HPHAKDLOBLL NFGIDCIKGJJ(int BBFHKIJJBJL)
	{
		return default(HPHAKDLOBLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x74AEA00", Offset = "0x74AD000", VA = "0x1874AEA00")]
	private void IIDCEBHCCAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2AA90D0", Offset = "0x2AA76D0", VA = "0x182AA90D0")]
	private static void JCDDLONOGGM<T>(int BBFHKIJJBJL, T[] PBGCIPMEIAB, int BHEAFIOEIAD, [Optional] T DGNFFFNLCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9120", Offset = "0x2AA7720", VA = "0x182AA9120")]
	private static void JCDDLONOGGM<T>(int BBFHKIJJBJL, NativeArray<T> PBGCIPMEIAB, int BHEAFIOEIAD, [Optional] T DGNFFFNLCPP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x74AEDF0", Offset = "0x74AD3F0", VA = "0x1874AEDF0")]
	private void JFJOAFJIAFE(IEnumerable<HPHAKDLOBLL> CAFCHIHIIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x74AE5B0", Offset = "0x74ACBB0", VA = "0x1874AE5B0")]
	private void CHNGHHGDECB(HPHAKDLOBLL NNKKCBILPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x74AF1A0", Offset = "0x74AD7A0", VA = "0x1874AF1A0")]
	private NIDJKHLAJOA LHFDECJHHFD(int CMBGGIIMMIG)
	{
		return default(NIDJKHLAJOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x74B06E0", Offset = "0x74AECE0", VA = "0x1874B06E0")]
	public void PLLDFEAAMJM(float AINNCKMHEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x74B0660", Offset = "0x74AEC60", VA = "0x1874B0660")]
	private void PDFEOIEMCJB(Action MOKDKAEJAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x74AED70", Offset = "0x74AD370", VA = "0x1874AED70")]
	private void JDJMAIHFGME(Action MOKDKAEJAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x74AFF70", Offset = "0x74AE570", VA = "0x1874AFF70")]
	public void PAKPGHCKHHH(float AINNCKMHEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x74AF400", Offset = "0x74ADA00", VA = "0x1874AF400")]
	public void LKJDFILLICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x74AE670", Offset = "0x74ACC70", VA = "0x1874AE670")]
	public void FFPCHLDHDDI(JLFGMDFJNME BCAMOIBPPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x74AE7A0", Offset = "0x74ACDA0", VA = "0x1874AE7A0")]
	public void FNNGFCEAGLL(JLFGMDFJNME BCAMOIBPPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x74AE8D0", Offset = "0x74ACED0", VA = "0x1874AE8D0")]
	public void IEEBFGNOOJM(JLFGMDFJNME BCAMOIBPPPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class DGHEJJHCOCG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly DGHEJJHCOCG PGEMABEMKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly Action OMALCONAAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private bool HHCLANPDDNK;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	public DGHEJJHCOCG(Action OMALCONAAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E480", Offset = "0x6C3CA80", VA = "0x186C3E480", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface JMCOLLPHMHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T PGPGCBGPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable AHDFJHLNLGK(UnityEngine.Object EIGKPCONJCB, Action<T> GHADBBIBJBE);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface GCGCJEJGLHK<T> : JMCOLLPHMHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	new T PGPGCBGPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class OBDDNADBGBJ<T> : GCGCJEJGLHK<T>, JMCOLLPHMHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class HGLJDLMPCOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public OBDDNADBGBJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public NLOJMGFBPKG<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public HGLJDLMPCOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E715B0", Offset = "0x3E6FBB0", VA = "0x183E715B0")]
		internal void KPHDKJOJKOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static GameObject MMKEIONNFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly List<NLOJMGFBPKG<UnityEngine.Object, Action<T>>> KPLLIABNALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private T EKHKGFMJCHF;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public T PGPGCBGPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F2D20", Offset = "0x9F1320", VA = "0x1809F2D20", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x480AA80", Offset = "0x4809080", VA = "0x18480AA80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x480A8C0", Offset = "0x4808EC0", VA = "0x18480A8C0")]
	private static bool KKBILJAAMLP(T MOKDKAEJAPP, T MKGNFMMEFHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x480AC00", Offset = "0x4809200", VA = "0x18480AC00")]
	public OBDDNADBGBJ(T AOPOAFMMANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x480A060", Offset = "0x4808660", VA = "0x18480A060", Slot = "6")]
	public IDisposable AHDFJHLNLGK(UnityEngine.Object EIGKPCONJCB, Action<T> GHADBBIBJBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x480A220", Offset = "0x4808820", VA = "0x18480A220")]
	private void KHEKKLLOENL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class FHJKHLKMLPL : IGBFJIBAGMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly EAPONALPEAD BCMLELHGFJA;

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x74B8DF0", Offset = "0x74B73F0", VA = "0x1874B8DF0")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	internal static void GLOIIIDMGBC(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	[UnityEngine.Scripting.Preserve]
	internal FHJKHLKMLPL([OLJNBPOCBCJ(null)] EAPONALPEAD BCMLELHGFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x74B8E60", Offset = "0x74B7460", VA = "0x1874B8E60", Slot = "4")]
	public IDisposable LOKEDNDMDML(float JOLEMMJKBFI, Action<float> JMKAJHCEDCI, bool PACAHANGGHJ = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class BLNALHAOEHI : AHACCJNJPHI, EAPONALPEAD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private CDGONIFMNAC[] EBBMJDHJPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private DGOAJBEMGHD IALLJDEBNHL;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x74AD9A0", Offset = "0x74ABFA0", VA = "0x1874AD9A0")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	internal static void MNJJOBMFJLK(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x74ADE60", Offset = "0x74AC460", VA = "0x1874ADE60")]
	[UnityEngine.Scripting.Preserve]
	public BLNALHAOEHI([OLJNBPOCBCJ(null)] LFCFJGDBKCD ANNFHHILFNE, [OLJNBPOCBCJ(null)] MNIICNDGLBN AELHONDGPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x74AD3F0", Offset = "0x74AB9F0", VA = "0x1874AD3F0", Slot = "18")]
	public override EPGCCCKMEBG GHFELCNHOHG(KOBKNGEGEGD EIGKPCONJCB, IEnumerator<GJDHNIMFMOA> NNKBPOEMAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x74AD710", Offset = "0x74ABD10", VA = "0x1874AD710", Slot = "19")]
	public override void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x74ADC30", Offset = "0x74AC230", VA = "0x1874ADC30", Slot = "21")]
	public override void OODJNIBCIJH(AGFOBJNEDPO FILNFIJCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x74AD5A0", Offset = "0x74ABBA0", VA = "0x1874AD5A0", Slot = "20")]
	protected override void KOLHFLEMELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x74AD240", Offset = "0x74AB840", VA = "0x1874AD240")]
	private CDGONIFMNAC BOJPDEMNANM(AGFOBJNEDPO JLAAKHANEHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x74ADA10", Offset = "0x74AC010", VA = "0x1874ADA10", Slot = "22")]
	internal override PBPJLNLHFEF OBMONFLCOGO(IEnumerator<GJDHNIMFMOA> NNKBPOEMAKB, Behaviour EIGKPCONJCB, NOPMABIBALJ LCHMOEJABHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x74AD520", Offset = "0x74ABB20", VA = "0x1874AD520", Slot = "23")]
	internal override FHMHHMLEKDA JMPPCIHPLGD(AGFOBJNEDPO FNMJLANICAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x74AD270", Offset = "0x74AB870", VA = "0x1874AD270")]
	private void CHOMMILNPFK(CDGONIFMNAC CPBKHAFFNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x74AD390", Offset = "0x74AB990", VA = "0x1874AD390", Slot = "24")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct AMGHCPPBABL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public float LAIHDJJDNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	public int DEMGPOODKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> KOJFAOFOLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> NJIPKADCGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NativeArray<int> GCCHJDLDIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<HEAFDHCLALH> KBCNDCEMLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	public NativeArray<float> PBILHOKJPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> PHCIAMDEMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[WriteOnly]
	public NativeArray<int> AAEEMEDIKFN;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x74AB940", Offset = "0x74A9F40", VA = "0x1874AB940")]
	public static AMGHCPPBABL GMDNOGMNFLF(int GDALIEGDNKL, float AINNCKMHEPN, NativeArray<HEAFDHCLALH> APJPKPLLJDJ, NativeArray<float> INFGPHFEJIC, NativeArray<int> FNGHCJJIBDB, NativeArray<int> OKHEGJGLODC, NativeArray<int> PHIBHJHGJCC, NativeArray<int> NJIPKADCGKN, NativeArray<int> GCCHJDLDIAM)
	{
		return default(AMGHCPPBABL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x74AB860", Offset = "0x74A9E60", VA = "0x1874AB860", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x74AB780", Offset = "0x74A9D80", VA = "0x1874AB780")]
	private bool EHOMGBLMEDF(int HGFDMIDEFHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x74ABBE0", Offset = "0x74AA1E0", VA = "0x1874ABBE0")]
	private void OLMAELAKKLA(NativeArray<int> OLFJJNHNEOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x74AB7C0", Offset = "0x74A9DC0", VA = "0x1874AB7C0")]
	private int EIMDHIAENIM(int HNFCHLCOANK, int GHJHJGCGJIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x74ABC10", Offset = "0x74AA210", VA = "0x1874ABC10")]
	private void PPDGEFKGPAK(NativeArray<int> OLFJJNHNEOC, int BNMONOECCAD, int CGJIPKMEOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x74AB9A0", Offset = "0x74A9FA0", VA = "0x1874AB9A0")]
	private void MDALGGKKPMB(NativeArray<int> OLFJJNHNEOC, int NAHMABFPGKH, int LBIMLHKHFJO, int BADGDINBIMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class AHACCJNJPHI : EAPONALPEAD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly LFCFJGDBKCD ANNFHHILFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected readonly MNIICNDGLBN AELHONDGPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private FHMHHMLEKDA[] OABDHENBEFL;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static EAPONALPEAD DFEEMNKDOMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x74AA340", Offset = "0x74A8940", VA = "0x1874AA340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static bool CMFCJHGPMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public AGFOBJNEDPO FJHAPLLHLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8841A0", Offset = "0x8827A0", VA = "0x1808841A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(AGFOBJNEDPO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x887070", Offset = "0x885670", VA = "0x180887070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public MNIICNDGLBN OKKNMAFMNLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GJDHNIMFMOA EMOIECJJKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public GJDHNIMFMOA NIMCMDLBFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x887AA0", Offset = "0x8860A0", VA = "0x180887AA0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public GJDHNIMFMOA PDLBEABHILH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x887850", Offset = "0x885E50", VA = "0x180887850", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x74AA3B0", Offset = "0x74A89B0", VA = "0x1874AA3B0")]
	public static EPGCCCKMEBG IMOCHKAEIGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x74AABB0", Offset = "0x74A91B0", VA = "0x1874AABB0")]
	[UnityEngine.Scripting.Preserve]
	protected AHACCJNJPHI([OLJNBPOCBCJ(null)] LFCFJGDBKCD ANNFHHILFNE, [OLJNBPOCBCJ(null)] MNIICNDGLBN AELHONDGPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x74A9EF0", Offset = "0x74A84F0", VA = "0x1874A9EF0", Slot = "6")]
	public EPGCCCKMEBG CKOMBPKHALD(IEnumerator<GJDHNIMFMOA> NNKBPOEMAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x74A9CF0", Offset = "0x74A82F0", VA = "0x1874A9CF0", Slot = "7")]
	public EPGCCCKMEBG CKOMBPKHALD(Behaviour EIGKPCONJCB, IEnumerator<GJDHNIMFMOA> NNKBPOEMAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract EPGCCCKMEBG GHFELCNHOHG(KOBKNGEGEGD EIGKPCONJCB, IEnumerator<GJDHNIMFMOA> NNKBPOEMAKB);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x74AA890", Offset = "0x74A8E90", VA = "0x1874AA890", Slot = "19")]
	public virtual void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x74AA610", Offset = "0x74A8C10", VA = "0x1874AA610", Slot = "9")]
	public void KEOMJLGANNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x74AA870", Offset = "0x74A8E70", VA = "0x1874AA870", Slot = "20")]
	protected virtual void KOLHFLEMELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x74AAB90", Offset = "0x74A9190", VA = "0x1874AAB90")]
	private void PDAHJDEMECK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x74AAAE0", Offset = "0x74A90E0", VA = "0x1874AAAE0")]
	private void OMNEEMBCFMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x74AA2C0", Offset = "0x74A88C0", VA = "0x1874AA2C0")]
	private void FDNCIOBOPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x74AAAC0", Offset = "0x74A90C0", VA = "0x1874AAAC0")]
	private void MELEPMCBAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x74A9CD0", Offset = "0x74A82D0", VA = "0x1874A9CD0")]
	private void CHMDLIONIBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x74AA850", Offset = "0x74A8E50", VA = "0x1874AA850")]
	private void KFKNEFBHBGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x74A9CB0", Offset = "0x74A82B0", VA = "0x1874A9CB0")]
	private void BPFPAEFNEBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x74AAB00", Offset = "0x74A9100", VA = "0x1874AAB00", Slot = "21")]
	public virtual void OODJNIBCIJH(AGFOBJNEDPO FILNFIJCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x74AA440", Offset = "0x74A8A40", VA = "0x1874AA440")]
	private void KEAFMJCDCFE(FHMHHMLEKDA CPBKHAFFNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5320", Offset = "0x1FB3920", VA = "0x181FB5320")]
	private FHMHHMLEKDA FIOEBBACFPO(AGFOBJNEDPO JLAAKHANEHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract PBPJLNLHFEF OBMONFLCOGO(IEnumerator<GJDHNIMFMOA> NNKBPOEMAKB, Behaviour FJNDKHIIOLD, NOPMABIBALJ KNEBKGBEOII);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract FHMHHMLEKDA JMPPCIHPLGD(AGFOBJNEDPO FILNFIJCNCC);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x74A9F00", Offset = "0x74A8500", VA = "0x1874A9F00", Slot = "24")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x74A9C50", Offset = "0x74A8250", VA = "0x1874A9C50", Slot = "14")]
	public GJDHNIMFMOA BOHBGOOCHKD(AGFOBJNEDPO FNMJLANICAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x74AAA30", Offset = "0x74A9030", VA = "0x1874AAA30", Slot = "15")]
	public GJDHNIMFMOA LJGBBEMLEDC(float GMOGAEOJHDH, AGFOBJNEDPO FNMJLANICAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x74AA2E0", Offset = "0x74A88E0", VA = "0x1874AA2E0", Slot = "16")]
	public GJDHNIMFMOA GMEIKEKILMM(Func<bool> ACJMHFFHANF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class PBPJLNLHFEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly NOPMABIBALJ LCHMOEJABHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly LFEAOCHFPEN EIGKPCONJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool KHFGJDGNGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private string KJPHMNNIMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private StackTrace FEOHFNPGOIM;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<GJDHNIMFMOA> GPALELMEMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8827C0", VA = "0x1808841C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public GJDHNIMFMOA MCNKHAHCMFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x887030", Offset = "0x885630", VA = "0x180887030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool JGPMFACAIJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x74C3740", Offset = "0x74C1D40", VA = "0x1874C3740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool GDMIGOCPJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x9237A0", Offset = "0x921DA0", VA = "0x1809237A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x923DE0", Offset = "0x9223E0", VA = "0x180923DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x74C3590", Offset = "0x74C1B90", VA = "0x1874C3590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float KKPJLGBJOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x9F2C90", Offset = "0x9F1290", VA = "0x1809F2C90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x60F3C60", Offset = "0x60F2260", VA = "0x1860F3C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x74C38A0", Offset = "0x74C1EA0", VA = "0x1874C38A0")]
	public PBPJLNLHFEF(IEnumerator<GJDHNIMFMOA> FDIEFIIIOIE, LFEAOCHFPEN EIGKPCONJCB, NOPMABIBALJ LCHMOEJABHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x74C31C0", Offset = "0x74C17C0", VA = "0x1874C31C0")]
	public GJDHNIMFMOA DFCAGCFDJLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x74C34D0", Offset = "0x74C1AD0", VA = "0x1874C34D0")]
	public bool ENEBOBPLGKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x74C3540", Offset = "0x74C1B40", VA = "0x1874C3540")]
	public void FFPCHLDHDDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x74C37C0", Offset = "0x74C1DC0", VA = "0x1874C37C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xC1B8C0", Offset = "0xC19EC0", VA = "0x180C1B8C0")]
	[CompilerGenerated]
	private void GELODBAIJMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class NOPMABIBALJ : FNDBFEALHLE, EPGCCCKMEBG, IBILKJCONGN, EOHNLEPDLDE, IEnumerator, GJDHNIMFMOA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private AGFOBJNEDPO FOBILAKFDAK;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private AGFOBJNEDPO GKOJCKNAMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x92D660", Offset = "0x92BC60", VA = "0x18092D660", Slot = "23")]
		get
		{
			return default(AGFOBJNEDPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public AGFOBJNEDPO IFKHOHEMJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x92E5D0", Offset = "0x92CBD0", VA = "0x18092E5D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float CBIPHHPAOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x929A80", Offset = "0x928080", VA = "0x180929A80", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool GMJFKNJEEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x74C2210", Offset = "0x74C0810", VA = "0x1874C2210", Slot = "24")]
	private bool NBKEJPMPHAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x74C2200", Offset = "0x74C0800", VA = "0x1874C2200", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x74C2230", Offset = "0x74C0830", VA = "0x1874C2230")]
	public NOPMABIBALJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum NIDJKHLAJOA : byte
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
internal sealed class FHMHHMLEKDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum LIPAHJGDIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct BEBKCOCBBBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public AGFOBJNEDPO JIDCDBGIMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public LIPAHJGDIAD DKPALJAOCEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public List<PBPJLNLHFEF> EGMAJELGAFD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly LIPAHJGDIAD[] LHKNKHJJMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly AGFOBJNEDPO FILNFIJCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool EAOJOKPLHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly PBPJLNLHFEF[] OODNNPCICPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly List<PBPJLNLHFEF> NKBKNDGEIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<int> GFFJGALFHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<PBPJLNLHFEF> BLNCAGFFKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<int> LLNCPGIAPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly DGOAJBEMGHD HHCMABBJDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private bool BPFKLNPOHOM;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public BEBKCOCBBBP[,] IIBENNNJHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x887850", Offset = "0x885E50", VA = "0x180887850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x74BA420", Offset = "0x74B8A20", VA = "0x1874BA420")]
	public FHMHHMLEKDA(AGFOBJNEDPO FNMJLANICAA, DGOAJBEMGHD HHCMABBJDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x74BA060", Offset = "0x74B8660", VA = "0x1874BA060")]
	public void OPGCPDJOKIK(PBPJLNLHFEF FDIEFIIIOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x74B99F0", Offset = "0x74B7FF0", VA = "0x1874B99F0")]
	public void IKIDAINPPCO(IList<PBPJLNLHFEF> LNLMPHMFEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x74B9180", Offset = "0x74B7780", VA = "0x1874B9180")]
	public void CEMKIBHAMMA(IList<PBPJLNLHFEF> LNLMPHMFEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x74B8F10", Offset = "0x74B7510", VA = "0x1874B8F10")]
	private void BDABMKHEPHL(PBPJLNLHFEF FDIEFIIIOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x74BA160", Offset = "0x74B8760", VA = "0x1874BA160")]
	private void PLHKKMGCKLJ(IList<PBPJLNLHFEF> LNLMPHMFEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x74B9000", Offset = "0x74B7600", VA = "0x1874B9000")]
	private NIDJKHLAJOA CCJGFOLFPLH(PBPJLNLHFEF FDIEFIIIOIE)
	{
		return default(NIDJKHLAJOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x74B9EF0", Offset = "0x74B84F0", VA = "0x1874B9EF0")]
	public void KOLHFLEMELG(float AINNCKMHEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x74B9D00", Offset = "0x74B8300", VA = "0x1874B9D00")]
	public void KEOMJLGANNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x74B96F0", Offset = "0x74B7CF0", VA = "0x1874B96F0")]
	private void FPKGPOLLMIG(List<PBPJLNLHFEF> LNLMPHMFEFA, Stack<int> CPKBEOMOBCO, bool MDGBPHKDOHJ, float IDHENHIBONN = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x74B9490", Offset = "0x74B7A90", VA = "0x1874B9490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x74B95B0", Offset = "0x74B7BB0", VA = "0x1874B95B0")]
	private void EAPCIOIDHID(List<PBPJLNLHFEF> LNLMPHMFEFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class MGGPMINGIAL : DGOAJBEMGHD
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "4")]
	public void GMJKCGEGKHB(string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
	public void AOFMHGBADGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public MGGPMINGIAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class KDDGNLHAELK : LFEAOCHFPEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly Behaviour FJNDKHIIOLD;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x74C0030", Offset = "0x74BE630", VA = "0x1874C0030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool OKKHPAEKBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x74BFFE0", Offset = "0x74BE5E0", VA = "0x1874BFFE0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool NKEDCLEGNEH
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x74C00B0", Offset = "0x74BE6B0", VA = "0x1874C00B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	public KDDGNLHAELK(Behaviour FJNDKHIIOLD)
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

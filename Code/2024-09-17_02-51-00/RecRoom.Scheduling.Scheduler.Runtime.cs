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
		[Cpp2IlInjected.Address(RVA = "0x75B0C40", Offset = "0x75AF640", VA = "0x1875B0C40", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
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
				[Cpp2IlInjected.Address(RVA = "0x75A9280", Offset = "0x75A7C80", VA = "0x1875A9280")]
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
				[Cpp2IlInjected.Address(RVA = "0x75AD070", Offset = "0x75ABA70", VA = "0x1875AD070")]
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
				[Cpp2IlInjected.Address(RVA = "0x7598C70", Offset = "0x7597670", VA = "0x187598C70")]
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
				[Cpp2IlInjected.Address(RVA = "0x759CB20", Offset = "0x759B520", VA = "0x18759CB20")]
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
				[Cpp2IlInjected.Address(RVA = "0x75AD660", Offset = "0x75AC060", VA = "0x1875AD660")]
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
				[Cpp2IlInjected.Address(RVA = "0x75AF980", Offset = "0x75AE380", VA = "0x1875AF980")]
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
				[Cpp2IlInjected.Address(RVA = "0x75AF670", Offset = "0x75AE070", VA = "0x1875AF670")]
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
				[Cpp2IlInjected.Address(RVA = "0x75AE9D0", Offset = "0x75AD3D0", VA = "0x1875AE9D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x75ACE90", Offset = "0x75AB890", VA = "0x1875ACE90")]
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
				[Cpp2IlInjected.Address(RVA = "0x7599B30", Offset = "0x7598530", VA = "0x187599B30")]
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
				[Cpp2IlInjected.Address(RVA = "0x75A0D80", Offset = "0x759F780", VA = "0x1875A0D80")]
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
				[Cpp2IlInjected.Address(RVA = "0x75AD9B0", Offset = "0x75AC3B0", VA = "0x1875AD9B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x75A6F60", Offset = "0x75A5960", VA = "0x1875A6F60")]
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
					[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
					public PNIECFEGKAD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x75AFC50", Offset = "0x75AE650", VA = "0x1875AFC50")]
					internal void PHEAIAMHHHK()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static KHECJJJIFBB<JMEFOCODLNC> FFMPNODLKOB;

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x75A15B0", Offset = "0x759FFB0", VA = "0x1875A15B0")]
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
					[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
					public NONBIBAIDKC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x75ADB90", Offset = "0x75AC590", VA = "0x1875ADB90")]
					internal void GJANJHDOOHP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable GPEONDAJKLH;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x75AAF50", Offset = "0x75A9950", VA = "0x1875AAF50")]
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
					[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
					public MLNIPNGFNKI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0x75AD360", Offset = "0x75ABD60", VA = "0x1875AD360")]
					internal void GJANJHDOOHP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x75ABEA0", Offset = "0x75AA8A0", VA = "0x1875ABEA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public EONDMBKLNNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x75A22E0", Offset = "0x75A0CE0", VA = "0x1875A22E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x75A02A0", Offset = "0x759ECA0", VA = "0x1875A02A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x759CDF0", Offset = "0x759B7F0", VA = "0x18759CDF0")]
		private static void APNEBHKDANJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x759F990", Offset = "0x759E390", VA = "0x18759F990")]
		private static void CJOHAGAAFAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x759F950", Offset = "0x759E350", VA = "0x18759F950")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75A09B0", Offset = "0x759F3B0", VA = "0x1875A09B0")]
		private static void OPPAEBFDMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75A07F0", Offset = "0x759F1F0", VA = "0x1875A07F0")]
		private static void JNEGMLAHKHE(CBGNDEMDNDJ.GKMKCILLAMH LFOBGDLOPID, PlayerLoopSystem CEJOBLADOBF, Type JLJJHMNGFIM, Type DGACEGALLPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x75A0410", Offset = "0x759EE10", VA = "0x1875A0410")]
		private static void GCMEDABHCPI(PlayerLoopSystem CEJOBLADOBF, Type JLJJHMNGFIM, Type DGACEGALLPF, GPGMJABACDM DKGHMCLJGAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x75A02E0", Offset = "0x759ECE0", VA = "0x1875A02E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75AB8F0", Offset = "0x75AA2F0", VA = "0x1875AB8F0")]
		public JLKGMAIMCFI(GKMKCILLAMH HBOHFLKJOLC, int MDLNMJNNBLE = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x75AB650", Offset = "0x75AA050", VA = "0x1875AB650")]
		public void BOFKIAKADKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x75AB8A0", Offset = "0x75AA2A0", VA = "0x1875AB8A0")]
		public void MBJMAOOLHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x75AB6C0", Offset = "0x75AA0C0", VA = "0x1875AB6C0")]
		public void EANAKFDAEEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static GKMKCILLAMH[] CKMHNGEEHOF;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static JLKGMAIMCFI[] NHOCHABKEHH;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7599D10", Offset = "0x7598710", VA = "0x187599D10")]
	public static JLKGMAIMCFI HMPGPBLJEPM(GKMKCILLAMH LFOBGDLOPID, int MDLNMJNNBLE = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7599F90", Offset = "0x7598990", VA = "0x187599F90")]
	public static JLKGMAIMCFI JMJPKGILGCG(GKMKCILLAMH LFOBGDLOPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7599EF0", Offset = "0x75988F0", VA = "0x187599EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75A9100", Offset = "0x75A7B00", VA = "0x1875A9100", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double GDJOPNOBMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF23E0", Offset = "0x1DF0DE0", VA = "0x181DF23E0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double BPBADMEJAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x20F6860", Offset = "0x20F5260", VA = "0x1820F6860", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x75A91D0", Offset = "0x75A7BD0", VA = "0x1875A91D0")]
	public GPBNICDFFGJ(int PBHHFNHJLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x75A8FE0", Offset = "0x75A79E0", VA = "0x1875A8FE0", Slot = "7")]
	public void AAGMNKOFDNI(double AAJFAHDADNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x75A9160", Offset = "0x75A7B60", VA = "0x1875A9160", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double GDJOPNOBMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x61E3CB0", Offset = "0x61E26B0", VA = "0x1861E3CB0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double BPBADMEJAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x61E3CC0", Offset = "0x61E26C0", VA = "0x1861E3CC0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double OBGBGBEOFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x61E3CD0", Offset = "0x61E26D0", VA = "0x1861E3CD0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double MKGDIDCEJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x26FF650", Offset = "0x26FE050", VA = "0x1826FF650", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x75A0BF0", Offset = "0x759F5F0", VA = "0x1875A0BF0", Slot = "7")]
	public virtual void AAGMNKOFDNI(double AAJFAHDADNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x75A0D10", Offset = "0x759F710", VA = "0x1875A0D10", Slot = "8")]
	public virtual void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x75A0D50", Offset = "0x759F750", VA = "0x1875A0D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x61E3D00", Offset = "0x61E2700", VA = "0x1861E3D00")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x61E4150", Offset = "0x61E2B50", VA = "0x1861E4150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x75AD840", Offset = "0x75AC240", VA = "0x1875AD840", Slot = "7")]
	public override void AAGMNKOFDNI(double AAJFAHDADNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x75AD970", Offset = "0x75AC370", VA = "0x1875AD970", Slot = "8")]
	public override void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x75A0D50", Offset = "0x759F750", VA = "0x1875A0D50")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
		public COPGJIPADJE(Action PMCMEAHOBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xB83530", Offset = "0xB81F30", VA = "0x180B83530", Slot = "5")]
		public void IKFNBHIKIAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<MNHDDPBJLEO> DNMHJBPIJLK;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x75A7BA0", Offset = "0x75A65A0", VA = "0x1875A7BA0")]
	public static void GPGACKLOACK(Action PMCMEAHOBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x75A78A0", Offset = "0x75A62A0", VA = "0x1875A78A0")]
	private static void CABLBNGKBBE(MNHDDPBJLEO MMCKDJBHIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x75A7C40", Offset = "0x75A6640", VA = "0x1875A7C40")]
	private static void MPCAHIPGCLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x75A7AA0", Offset = "0x75A64A0", VA = "0x1875A7AA0")]
	private static void GABIHHHPPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x75A77D0", Offset = "0x75A61D0", VA = "0x1875A77D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75ABFD0", Offset = "0x75AA9D0", VA = "0x1875ABFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75AC030", Offset = "0x75AAA30", VA = "0x1875AC030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x75AC8D0", Offset = "0x75AB2D0", VA = "0x1875AC8D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x75A8C70", Offset = "0x75A7670", VA = "0x1875A8C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x75A8F80", Offset = "0x75A7980", VA = "0x1875A8F80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x75AC940", Offset = "0x75AB340", VA = "0x1875AC940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x75ACCF0", Offset = "0x75AB6F0", VA = "0x1875ACCF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public HNIDMOJOFLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x75AA5D0", Offset = "0x75A8FD0", VA = "0x1875AA5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75980A0", Offset = "0x7596AA0", VA = "0x1875980A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7598C00", Offset = "0x7597600", VA = "0x187598C00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x75A1DA0", Offset = "0x75A07A0", VA = "0x1875A1DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x75A2270", Offset = "0x75A0C70", VA = "0x1875A2270", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x75A2400", Offset = "0x75A0E00", VA = "0x1875A2400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x75A2F20", Offset = "0x75A1920", VA = "0x1875A2F20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public KFGAJPLAFEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x75ABCE0", Offset = "0x75AA6E0", VA = "0x1875ABCE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public DENKAONOCLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x75A1520", Offset = "0x759FF20", VA = "0x1875A1520", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x75A11A0", Offset = "0x759FBA0", VA = "0x1875A11A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x75A1150", Offset = "0x759FB50", VA = "0x1875A1150")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x75A14D0", Offset = "0x759FED0", VA = "0x1875A14D0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GJIOPMODNKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x75A8990", Offset = "0x75A7390", VA = "0x1875A8990")]
		internal bool GHLKOJMFJFL(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x75A8A10", Offset = "0x75A7410", VA = "0x1875A8A10")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public ODIFPJKILAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x75AE2E0", Offset = "0x75ACCE0", VA = "0x1875AE2E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x75AE940", Offset = "0x75AD340", VA = "0x1875AE940", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x75A41D0", Offset = "0x75A2BD0", VA = "0x1875A41D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private static bool FPLEOCKNHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x75A3E60", Offset = "0x75A2860", VA = "0x1875A3E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private static bool HKFLBEKNKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x75A4590", Offset = "0x75A2F90", VA = "0x1875A4590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool LOBNCKMNGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x75A37A0", Offset = "0x75A21A0", VA = "0x1875A37A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> NPHKFNOAMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x75A31D0", Offset = "0x75A1BD0", VA = "0x1875A31D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x75A4480", Offset = "0x75A2E80", VA = "0x1875A4480")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x75A32E0", Offset = "0x75A1CE0", VA = "0x1875A32E0")]
	[MGLPINNJGGC(CLPKIHJHCPA.EnteredEditModeNextFrame, 0)]
	private static void CKNKEMLDEPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x75A3650", Offset = "0x75A2050", VA = "0x1875A3650")]
	[AsyncStateMachine(typeof(LIODHLMONBA))]
	public static Task<Scene> EFFLHAHGBON(string BFMPCJDOKPD, LoadSceneMode HPAOIPFPPJO = LoadSceneMode.Single, bool NGJHJADFEEB = false, [Optional] APPPBJLIGLH<string>.LANPOEPHMID CCLNIPIBCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x75A4010", Offset = "0x75A2A10", VA = "0x1875A4010")]
	[AsyncStateMachine(typeof(GMNFNHFINBP))]
	private static Task KKABPOIJIDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x75A3830", Offset = "0x75A2230", VA = "0x1875A3830")]
	[AsyncStateMachine(typeof(LLLPJAIDECK))]
	private static Task FKLJLIPEDKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x75A33D0", Offset = "0x75A1DD0", VA = "0x1875A33D0")]
	[AsyncStateMachine(typeof(BEGOBPJMKED))]
	private static Task<Scene> DNIHKPHKNHM(string BFMPCJDOKPD, LoadSceneMode HPAOIPFPPJO, bool NGJHJADFEEB, APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x75A40C0", Offset = "0x75A2AC0", VA = "0x1875A40C0")]
	private static void LKFJNHCJIGK(SceneInstance NFEPGHCPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x75A4630", Offset = "0x75A3030", VA = "0x1875A4630")]
	private static void PFPPCMBKOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x75A3D40", Offset = "0x75A2740", VA = "0x1875A3D40")]
	[AsyncStateMachine(typeof(EOJDJJFJGDL))]
	private static Task<Scene> GPAIAMOGBKO(string BFMPCJDOKPD, LoadSceneMode HPAOIPFPPJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x75A3050", Offset = "0x75A1A50", VA = "0x1875A3050")]
	private static bool BFBBBBLLBFE(string BFMPCJDOKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x75A3F00", Offset = "0x75A2900", VA = "0x1875A3F00")]
	[AsyncStateMachine(typeof(EOPHFEBGNGK))]
	private static Task<Scene> JCJOKPEOJHI(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x75A3BC0", Offset = "0x75A25C0", VA = "0x1875A3BC0")]
	public static JAGIEECCCMP<Scene> GOODNODINFA(string BFMPCJDOKPD, LoadSceneMode HPAOIPFPPJO = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x75A3900", Offset = "0x75A2300", VA = "0x1875A3900")]
	public static EOHNLEPDLDE GACOHBJLMDI(string BFMPCJDOKPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x75A3140", Offset = "0x75A1B40", VA = "0x1875A3140")]
	[IteratorStateMachine(typeof(DENKAONOCLD))]
	private static IEnumerator<GJDHNIMFMOA> BNMHJPLLDGD(string BFMPCJDOKPD, IKMBNOHICPK HAHPDDFPPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x75A43E0", Offset = "0x75A2DE0", VA = "0x1875A43E0")]
	[IteratorStateMachine(typeof(ODIFPJKILAI))]
	private static IEnumerator<GJDHNIMFMOA> NJNLIEOEFIB(string BFMPCJDOKPD, LoadSceneMode HPAOIPFPPJO, IFJDAICJPOM<Scene> HAHPDDFPPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x75A3520", Offset = "0x75A1F20", VA = "0x1875A3520")]
	public static bool EFCKAHPEKGN([Out] string AKDAPAGHIDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class GHGCDJMJJLC
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x75A8220", Offset = "0x75A6C20", VA = "0x1875A8220")]
	public static IDisposable JIJDMPNGMAI(this KOBKNGEGEGD EIGKPCONJCB, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x75A8120", Offset = "0x75A6B20", VA = "0x1875A8120")]
	public static IDisposable DFFJIKGLMID(this KOBKNGEGEGD EIGKPCONJCB, Action<float> NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x75A81A0", Offset = "0x75A6BA0", VA = "0x1875A81A0")]
	public static IDisposable HPEPADJIOJK(this KOBKNGEGEGD EIGKPCONJCB, Action<float> NMJDKOJJLOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class FHNBOJOPPGB
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x75A6540", Offset = "0x75A4F40", VA = "0x1875A6540")]
	public static IDisposable AFOBJNMKGGH(this MonoBehaviour FJNDKHIIOLD, Action NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x75A64B0", Offset = "0x75A4EB0", VA = "0x1875A64B0")]
	public static IDisposable AFOBJNMKGGH(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x75A6C80", Offset = "0x75A5680", VA = "0x1875A6C80")]
	public static IDisposable KOLHFLEMELG(this MonoBehaviour FJNDKHIIOLD, Action NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x75A67D0", Offset = "0x75A51D0", VA = "0x1875A67D0")]
	public static IDisposable FDNCIOBOPBG(this MonoBehaviour FJNDKHIIOLD, Action NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x75A6850", Offset = "0x75A5250", VA = "0x1875A6850")]
	public static IDisposable FDNCIOBOPBG(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x75A6DA0", Offset = "0x75A57A0", VA = "0x1875A6DA0")]
	public static IDisposable MELEPMCBAPM(this MonoBehaviour FJNDKHIIOLD, Action NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x75A6C00", Offset = "0x75A5600", VA = "0x1875A6C00")]
	public static IDisposable KNFNNCKDPCB(this MonoBehaviour FJNDKHIIOLD, Action NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x75A65D0", Offset = "0x75A4FD0", VA = "0x1875A65D0")]
	public static IDisposable AHLDADMHBBI(this MonoBehaviour FJNDKHIIOLD, Action NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x75A6680", Offset = "0x75A5080", VA = "0x1875A6680")]
	public static IDisposable CMBEEAMPJCA(this MonoBehaviour FJNDKHIIOLD, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x75A6650", Offset = "0x75A5050", VA = "0x1875A6650")]
	public static IDisposable AJBBFPCFMOA(this MonoBehaviour FJNDKHIIOLD, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x75A6D00", Offset = "0x75A5700", VA = "0x1875A6D00")]
	public static IDisposable LOKEDNDMDML(this MonoBehaviour FJNDKHIIOLD, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x75A6AC0", Offset = "0x75A54C0", VA = "0x1875A6AC0")]
	public static IDisposable JLGOBELHNJF(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x75A6970", Offset = "0x75A5370", VA = "0x1875A6970")]
	public static IDisposable GHBBONDCIHF(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x75A6B60", Offset = "0x75A5560", VA = "0x1875A6B60")]
	public static IDisposable KJOFCCJCPFA(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x75A6730", Offset = "0x75A5130", VA = "0x1875A6730")]
	public static IDisposable DFDPLPEHGGN(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x75A6EC0", Offset = "0x75A58C0", VA = "0x1875A6EC0")]
	public static IDisposable NPAOMCHJCIA(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x75A6E20", Offset = "0x75A5820", VA = "0x1875A6E20")]
	public static IDisposable MJEPAJNLIAJ(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x75A68D0", Offset = "0x75A52D0", VA = "0x1875A68D0")]
	public static IDisposable GGJEAMIMLDM(this MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x75A6A10", Offset = "0x75A5410", VA = "0x1875A6A10")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public PIKAMNBJIEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x75AF850", Offset = "0x75AE250", VA = "0x1875AF850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x75AF930", Offset = "0x75AE330", VA = "0x1875AF930", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public MCPNKBGIDKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x75ACD50", Offset = "0x75AB750", VA = "0x1875ACD50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x75ACE40", Offset = "0x75AB840", VA = "0x1875ACE40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x75A1A10", Offset = "0x75A0410", VA = "0x1875A1A10")]
	public static EPGCCCKMEBG AFOBJNMKGGH(Action NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x75A18A0", Offset = "0x75A02A0", VA = "0x1875A18A0")]
	public static EPGCCCKMEBG AFOBJNMKGGH(Behaviour EIGKPCONJCB, Action NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x75A1930", Offset = "0x75A0330", VA = "0x1875A1930")]
	public static EPGCCCKMEBG AFOBJNMKGGH(Behaviour EIGKPCONJCB, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x75A1B20", Offset = "0x75A0520", VA = "0x1875A1B20")]
	[IteratorStateMachine(typeof(PIKAMNBJIEL))]
	private static IEnumerator<GJDHNIMFMOA> EFMPOBDHNGC(AGFOBJNEDPO FNMJLANICAA, Action NMJDKOJJLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x75A1A90", Offset = "0x75A0490", VA = "0x1875A1A90")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public KPKJFMJFFFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x75ABDC0", Offset = "0x75AA7C0", VA = "0x1875ABDC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x75ABE50", Offset = "0x75AA850", VA = "0x1875ABE50", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x899870", Offset = "0x898270", VA = "0x180899870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x75A1CD0", Offset = "0x75A06D0", VA = "0x1875A1CD0")]
	public EKFICGPFPKB(AGFOBJNEDPO FILNFIJCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x75A1BB0", Offset = "0x75A05B0", VA = "0x1875A1BB0")]
	[IteratorStateMachine(typeof(KPKJFMJFFFO))]
	private IEnumerator<GJDHNIMFMOA> NMKKFOJMJNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x75A1C30", Offset = "0x75A0630", VA = "0x1875A1C30", Slot = "4")]
	public void OnCompleted(Action FHCABKEHDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	public void OOOBGLGFFBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class KBJFJCKFOJK
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x75ABA00", Offset = "0x75AA400", VA = "0x1875ABA00")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public DDKDHILPOBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x75A0F60", Offset = "0x759F960", VA = "0x1875A0F60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x75A0FE0", Offset = "0x759F9E0", VA = "0x1875A0FE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x75A7210", Offset = "0x75A5C10", VA = "0x1875A7210")]
	public static EPGCCCKMEBG AFOBJNMKGGH(float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x75A7140", Offset = "0x75A5B40", VA = "0x1875A7140")]
	public static EPGCCCKMEBG AFOBJNMKGGH(MonoBehaviour FJNDKHIIOLD, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x75A7430", Offset = "0x75A5E30", VA = "0x1875A7430")]
	public static EPGCCCKMEBG FNCINGIPGKE(MonoBehaviour FJNDKHIIOLD, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x75A7580", Offset = "0x75A5F80", VA = "0x1875A7580")]
	public static EPGCCCKMEBG ODDKFBBFHEL(KOBKNGEGEGD EIGKPCONJCB, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x75A7370", Offset = "0x75A5D70", VA = "0x1875A7370")]
	private static IEnumerator<GJDHNIMFMOA> EFMPOBDHNGC(MNIICNDGLBN AELHONDGPEG, float JOLEMMJKBFI, AGFOBJNEDPO FNMJLANICAA, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x75A7520", Offset = "0x75A5F20", VA = "0x1875A7520")]
	private static IEnumerator<GJDHNIMFMOA> GAGCJKIDAOC(MNIICNDGLBN AELHONDGPEG, float JOLEMMJKBFI, AGFOBJNEDPO FNMJLANICAA, Action<float> NMJDKOJJLOE, bool PACAHANGGHJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x75A72E0", Offset = "0x75A5CE0", VA = "0x1875A72E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public MLECNGEAMEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x75AD250", Offset = "0x75ABC50", VA = "0x1875AD250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x75AD310", Offset = "0x75ABD10", VA = "0x1875AD310", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x75A8090", Offset = "0x75A6A90", VA = "0x1875A8090")]
	[IteratorStateMachine(typeof(MLECNGEAMEJ))]
	private static IEnumerator<GJDHNIMFMOA> IIAFKNGCGMI(AGFOBJNEDPO FILNFIJCNCC, Func<bool> ACJMHFFHANF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x75A7FB0", Offset = "0x75A69B0", VA = "0x1875A7FB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public JFICAEEIBKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x75AB0C0", Offset = "0x75A9AC0", VA = "0x1875AB0C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x75AB130", Offset = "0x75A9B30", VA = "0x1875AB130", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public KCHPKHBAMME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x75ABB10", Offset = "0x75AA510", VA = "0x1875ABB10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x75ABBA0", Offset = "0x75AA5A0", VA = "0x1875ABBA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x75955E0", Offset = "0x7593FE0", VA = "0x1875955E0")]
	[IteratorStateMachine(typeof(JFICAEEIBKL))]
	private static IEnumerator<GJDHNIMFMOA> NMKKFOJMJNL(float GMOGAEOJHDH, AGFOBJNEDPO FNMJLANICAA, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7595060", Offset = "0x7593A60", VA = "0x187595060")]
	[IteratorStateMachine(typeof(KCHPKHBAMME))]
	private static IEnumerator<GJDHNIMFMOA> CIILFMMBPBE(float GMOGAEOJHDH, AGFOBJNEDPO FNMJLANICAA, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7594E90", Offset = "0x7593890", VA = "0x187594E90")]
	public static IDisposable CBCFHNBJGLN(this MonoBehaviour FJNDKHIIOLD, float GMOGAEOJHDH, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x75952E0", Offset = "0x7593CE0", VA = "0x1875952E0")]
	public static EPGCCCKMEBG HDLGPAIEMJH(this MonoBehaviour FJNDKHIIOLD, float GMOGAEOJHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7594F70", Offset = "0x7593970", VA = "0x187594F70")]
	public static EPGCCCKMEBG CBCFHNBJGLN(this MonoBehaviour FJNDKHIIOLD, float GMOGAEOJHDH, AGFOBJNEDPO FNMJLANICAA, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7595720", Offset = "0x7594120", VA = "0x187595720")]
	public static EPGCCCKMEBG OMLNGIOJNGL(this MonoBehaviour FJNDKHIIOLD, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7595680", Offset = "0x7594080", VA = "0x187595680")]
	public static EPGCCCKMEBG OMAPOIIFLIN(this MonoBehaviour FJNDKHIIOLD, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x75954A0", Offset = "0x7593EA0", VA = "0x1875954A0")]
	public static EPGCCCKMEBG MANHDCFFFEL(this MonoBehaviour FJNDKHIIOLD, Action OADEFMMDNAN, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x75951A0", Offset = "0x7593BA0", VA = "0x1875951A0")]
	public static EPGCCCKMEBG ELKLDKFDDII(this MonoBehaviour FJNDKHIIOLD, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7595100", Offset = "0x7593B00", VA = "0x187595100")]
	public static EPGCCCKMEBG DDAFKCMCHKG(this MonoBehaviour FJNDKHIIOLD, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x75957C0", Offset = "0x75941C0", VA = "0x1875957C0")]
	private static EPGCCCKMEBG PGDGDDCKKIC(MonoBehaviour FJNDKHIIOLD, AGFOBJNEDPO FILNFIJCNCC, Action OADEFMMDNAN, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7595410", Offset = "0x7593E10", VA = "0x187595410")]
	public static EPGCCCKMEBG KMHMALFHKAC(this MonoBehaviour FJNDKHIIOLD, float KOOGHGFOFPC, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7595370", Offset = "0x7593D70", VA = "0x187595370")]
	public static EPGCCCKMEBG JJNNMBBFKGJ(this MonoBehaviour FJNDKHIIOLD, float KOOGHGFOFPC, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7595240", Offset = "0x7593C40", VA = "0x187595240")]
	public static EPGCCCKMEBG FNLMJPHEIBF(this MonoBehaviour FJNDKHIIOLD, float KOOGHGFOFPC, Action OADEFMMDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7595540", Offset = "0x7593F40", VA = "0x187595540")]
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
		[Cpp2IlInjected.Address(RVA = "0x75AAD80", Offset = "0x75A9780", VA = "0x1875AAD80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MCEKEKPPPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x75AA630", Offset = "0x75A9030", VA = "0x1875AA630", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x75AACE0", Offset = "0x75A96E0", VA = "0x1875AACE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x75AAEB0", Offset = "0x75A98B0", VA = "0x1875AAEB0")]
	public HPPCCGECNGE([Optional] Action LDINEIPBFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x75AA6D0", Offset = "0x75A90D0", VA = "0x1875AA6D0")]
	public void FABNFHGMHGJ(HELBBFLMJNL AFDPMBKKJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x75AA800", Offset = "0x75A9200", VA = "0x1875AA800")]
	private void FLMKFCGALDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x75AA950", Offset = "0x75A9350", VA = "0x1875AA950", Slot = "7")]
	public bool GAFIKJLGLJN(bool LENLJCDCMCG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x75AA960", Offset = "0x75A9360", VA = "0x1875AA960", Slot = "8")]
	public bool GAFIKJLGLJN(Action PMCMEAHOBEF, bool LENLJCDCMCG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x75AAC60", Offset = "0x75A9660", VA = "0x1875AAC60", Slot = "9")]
	public IEnumerator<HELBBFLMJNL> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x75AAC60", Offset = "0x75A9660", VA = "0x1875AAC60", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EAMFBFDLOPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x75A1870", Offset = "0x75A0270", VA = "0x1875A1870")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public HKHFJNBKEGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x75A1870", Offset = "0x75A0270", VA = "0x1875A1870")]
		internal void KCJHKNOAIPP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly float EEDNJMDKFOB;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x75A7690", Offset = "0x75A6090", VA = "0x1875A7690")]
	public PAEECFIKHGA(Behaviour EIGKPCONJCB, float EEDNJMDKFOB, [Optional] Action LDINEIPBFHJ, [Optional] EAPONALPEAD BCMLELHGFJA, [Optional] MNIICNDGLBN AELHONDGPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x75AECC0", Offset = "0x75AD6C0", VA = "0x1875AECC0", Slot = "9")]
	protected override bool MOPEOFNBKMM(Action PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x75AEBB0", Offset = "0x75AD5B0", VA = "0x1875AEBB0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public DDLFPBPIFFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x75A1030", Offset = "0x759FA30", VA = "0x1875A1030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x75A1100", Offset = "0x759FB00", VA = "0x1875A1100", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x10FC2D0", Offset = "0x10FACD0", VA = "0x1810FC2D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action MCEKEKPPPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x75A82D0", Offset = "0x75A6CD0", VA = "0x1875A82D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x75A8730", Offset = "0x75A7130", VA = "0x1875A8730", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x75A8860", Offset = "0x75A7260", VA = "0x1875A8860")]
	protected GIOMOFABJMP(Behaviour EIGKPCONJCB, [Optional] Action LDINEIPBFHJ, [Optional] EAPONALPEAD BCMLELHGFJA, [Optional] MNIICNDGLBN AELHONDGPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x75A85F0", Offset = "0x75A6FF0", VA = "0x1875A85F0", Slot = "7")]
	public bool GAFIKJLGLJN(bool LENLJCDCMCG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x75A8650", Offset = "0x75A7050", VA = "0x1875A8650", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x75A82B0", Offset = "0x75A6CB0", VA = "0x1875A82B0")]
	protected void ANIKPFOKPPH(Action PMCMEAHOBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x75A8370", Offset = "0x75A6D70", VA = "0x1875A8370")]
	protected EOHNLEPDLDE DCFDAOPBPPK(float MCPPIEMELEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x75A86B0", Offset = "0x75A70B0", VA = "0x1875A86B0")]
	private void GHDFHEAEKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x75A87D0", Offset = "0x75A71D0", VA = "0x1875A87D0")]
	[IteratorStateMachine(typeof(DDLFPBPIFFN))]
	private IEnumerator<GJDHNIMFMOA> MEAOPOKCFAI(float MCPPIEMELEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x75A85B0", Offset = "0x75A6FB0", VA = "0x1875A85B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x75AE110", Offset = "0x75ACB10", VA = "0x1875AE110")]
	public OCJBDBEJBIA(Behaviour EIGKPCONJCB, float KLJPNDFHLNK, int EBAHJGIKKME, [Optional] Action LDINEIPBFHJ, float KPPIDBOIAFM = 0f, [Optional] EAPONALPEAD BCMLELHGFJA, [Optional] MNIICNDGLBN AELHONDGPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "9")]
	protected override bool MOPEOFNBKMM(Action PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x75ADF10", Offset = "0x75AC910", VA = "0x1875ADF10", Slot = "10")]
	protected override bool EPGGFLOIINM(Action PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x75ADE90", Offset = "0x75AC890", VA = "0x1875ADE90")]
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
	[Cpp2IlInjected.Address(RVA = "0x75A7690", Offset = "0x75A6090", VA = "0x1875A7690")]
	public FPCKHJBLHCF(Behaviour EIGKPCONJCB, float EEDNJMDKFOB, [Optional] Action LDINEIPBFHJ, [Optional] EAPONALPEAD BCMLELHGFJA, [Optional] MNIICNDGLBN AELHONDGPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "9")]
	protected override bool MOPEOFNBKMM(Action PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x75A7650", Offset = "0x75A6050", VA = "0x1875A7650", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public MMNOJHDDIOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x75A2F90", Offset = "0x75A1990", VA = "0x1875A2F90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x75AD610", Offset = "0x75AC010", VA = "0x1875AD610", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x75971B0", Offset = "0x7595BB0", VA = "0x1875971B0")]
	public AJPEKBJOAJH(KOBKNGEGEGD EIGKPCONJCB, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7596F10", Offset = "0x7595910", VA = "0x187596F10")]
	private void MPGCFJFHLNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7597080", Offset = "0x7595A80", VA = "0x187597080")]
	private void NCMKNICLOIP(string ENDMINEHNJK, Action ECFGGCCHKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7596E90", Offset = "0x7595890", VA = "0x187596E90")]
	[IteratorStateMachine(typeof(MMNOJHDDIOG))]
	private IEnumerator<GJDHNIMFMOA> LDPDNEEGCFP(Action ECFGGCCHKNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7596E30", Offset = "0x7595830", VA = "0x187596E30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7596CB0", Offset = "0x75956B0", VA = "0x187596CB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public FAMKHLLECIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x75A2F90", Offset = "0x75A1990", VA = "0x1875A2F90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x75A3000", Offset = "0x75A1A00", VA = "0x1875A3000", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x75AA090", Offset = "0x75A8A90", VA = "0x1875AA090")]
	public HEJBKGDOEIB(MonoBehaviour FJNDKHIIOLD, Action NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x75AA220", Offset = "0x75A8C20", VA = "0x1875AA220")]
	public HEJBKGDOEIB(MonoBehaviour FJNDKHIIOLD, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x75AA3F0", Offset = "0x75A8DF0", VA = "0x1875AA3F0")]
	public HEJBKGDOEIB(MonoBehaviour FJNDKHIIOLD, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C560", Offset = "0x3F8AF60", VA = "0x183F8C560")]
	private HEJBKGDOEIB(EAPONALPEAD BCMLELHGFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x75A99B0", Offset = "0x75A83B0", VA = "0x1875A99B0")]
	internal static HEJBKGDOEIB MFNHNOPKEOC(MonoBehaviour FJNDKHIIOLD, float JOLEMMJKBFI, Action<float> NMJDKOJJLOE, AGFOBJNEDPO FILNFIJCNCC, bool PACAHANGGHJ = true, [Optional] EAPONALPEAD BCMLELHGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x75A9460", Offset = "0x75A7E60", VA = "0x1875A9460")]
	private void AFOBJNMKGGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x75A9F10", Offset = "0x75A8910", VA = "0x1875A9F10")]
	private void PDIFBAJMMBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x75A9BE0", Offset = "0x75A85E0", VA = "0x1875A9BE0")]
	private void MPGCFJFHLNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x75A9680", Offset = "0x75A8080", VA = "0x1875A9680")]
	private void EJIHILILIFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x75A9D50", Offset = "0x75A8750", VA = "0x1875A9D50")]
	private void NCMKNICLOIP(string ENDMINEHNJK, Action ECFGGCCHKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x75A98A0", Offset = "0x75A82A0", VA = "0x1875A98A0")]
	[IteratorStateMachine(typeof(FAMKHLLECIL))]
	private IEnumerator<GJDHNIMFMOA> LDPDNEEGCFP(Action ECFGGCCHKNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x75A9620", Offset = "0x75A8020", VA = "0x1875A9620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x75A9590", Offset = "0x75A7F90", VA = "0x1875A9590")]
	[CompilerGenerated]
	private void BBMBJLBMJGG(string FKDHFMCKMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x75A9810", Offset = "0x75A8210", VA = "0x1875A9810")]
	[CompilerGenerated]
	private void FFEHNGGEHJL(string FKDHFMCKMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x75A9E80", Offset = "0x75A8880", VA = "0x1875A9E80")]
	[CompilerGenerated]
	private void ONONHMEOMHD(string FKDHFMCKMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x75A9920", Offset = "0x75A8320", VA = "0x1875A9920")]
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
		[Cpp2IlInjected.Address(RVA = "0x75ABDA0", Offset = "0x75AA7A0", VA = "0x1875ABDA0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float DCANMCJKGKH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x75ABDB0", Offset = "0x75AA7B0", VA = "0x1875ABDB0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public double KPFLMKGJHIL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x75ABD10", Offset = "0x75AA710", VA = "0x1875ABD10", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x75ABD30", Offset = "0x75AA730", VA = "0x1875ABD30")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	internal static void MNJJOBMFJLK(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8961A0", Offset = "0x894BA0", VA = "0x1808961A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x899070", Offset = "0x897A70", VA = "0x180899070")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x75AB3B0", Offset = "0x75A9DB0", VA = "0x1875AB3B0")]
	public static GJDHNIMFMOA DFCAGCFDJLI(IEnumerator<GJDHNIMFMOA> FDIEFIIIOIE, NOPMABIBALJ LCHMOEJABHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x75AB2F0", Offset = "0x75A9CF0", VA = "0x1875AB2F0")]
	public GJDHNIMFMOA DFCAGCFDJLI(NOPMABIBALJ[] NKEPIFICNLK, IEnumerator<GJDHNIMFMOA>[] LNLMPHMFEFA, GJDHNIMFMOA[] KBGJIIABPMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x75AB2C0", Offset = "0x75A9CC0", VA = "0x1875AB2C0")]
	public void BGFKMPMGPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x75AB510", Offset = "0x75A9F10", VA = "0x1875AB510")]
	public void HHHCLFMGNEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x75AB180", Offset = "0x75A9B80", VA = "0x1875AB180")]
	public void AMLKGEFJDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x75AB2C0", Offset = "0x75A9CC0", VA = "0x1875AB2C0")]
	public void FFPCHLDHDDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public AMPOAILCEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x75978F0", Offset = "0x75962F0", VA = "0x1875978F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public OGDHMIJPJPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x75AE990", Offset = "0x75AD390", VA = "0x1875AE990")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public ALIPMCKEPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7597350", Offset = "0x7595D50", VA = "0x187597350")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public JFHEGIHLGIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x75AB080", Offset = "0x75A9A80", VA = "0x1875AB080")]
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
		[Cpp2IlInjected.Address(RVA = "0xA92E30", Offset = "0xA91830", VA = "0x180A92E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x759A190", Offset = "0x7598B90", VA = "0x18759A190")]
	private static int ABNPMMDAFNI(AGFOBJNEDPO FILNFIJCNCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x759C4F0", Offset = "0x759AEF0", VA = "0x18759C4F0")]
	public CDGONIFMNAC(AGFOBJNEDPO FILNFIJCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x759B9A0", Offset = "0x759A3A0", VA = "0x18759B9A0")]
	private void NOFIOMBMEPH(int HKDIPCGIIJF, int MAADLOAEABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x759B110", Offset = "0x7599B10", VA = "0x18759B110")]
	public void MDAECMAGFMH(KOBKNGEGEGD EIGKPCONJCB, GJDHNIMFMOA FPLEFKBJKEN, IEnumerator<GJDHNIMFMOA> FDIEFIIIOIE, NOPMABIBALJ LCHMOEJABHG, [Optional] JLFGMDFJNME PMGPLKPJPAF, HEAFDHCLALH NFJAMJCGOBO = HEAFDHCLALH.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x759B760", Offset = "0x759A160", VA = "0x18759B760")]
	public void NNNCAKMJNPB(IEnumerable<HPHAKDLOBLL> CAFCHIHIIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x759B290", Offset = "0x7599C90", VA = "0x18759B290")]
	private HPHAKDLOBLL NFGIDCIKGJJ(int BBFHKIJJBJL)
	{
		return default(HPHAKDLOBLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x759A610", Offset = "0x7599010", VA = "0x18759A610")]
	private void IIDCEBHCCAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2B62DF0", Offset = "0x2B617F0", VA = "0x182B62DF0")]
	private static void JCDDLONOGGM<T>(int BBFHKIJJBJL, T[] PBGCIPMEIAB, int BHEAFIOEIAD, [Optional] T DGNFFFNLCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2B62E40", Offset = "0x2B61840", VA = "0x182B62E40")]
	private static void JCDDLONOGGM<T>(int BBFHKIJJBJL, NativeArray<T> PBGCIPMEIAB, int BHEAFIOEIAD, [Optional] T DGNFFFNLCPP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x759AA00", Offset = "0x7599400", VA = "0x18759AA00")]
	private void JFJOAFJIAFE(IEnumerable<HPHAKDLOBLL> CAFCHIHIIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x759A1C0", Offset = "0x7598BC0", VA = "0x18759A1C0")]
	private void CHNGHHGDECB(HPHAKDLOBLL NNKKCBILPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x759ADB0", Offset = "0x75997B0", VA = "0x18759ADB0")]
	private NIDJKHLAJOA LHFDECJHHFD(int CMBGGIIMMIG)
	{
		return default(NIDJKHLAJOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x759C2F0", Offset = "0x759ACF0", VA = "0x18759C2F0")]
	public void PLLDFEAAMJM(float AINNCKMHEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x759C270", Offset = "0x759AC70", VA = "0x18759C270")]
	private void PDFEOIEMCJB(Action MOKDKAEJAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x759A980", Offset = "0x7599380", VA = "0x18759A980")]
	private void JDJMAIHFGME(Action MOKDKAEJAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x759BB80", Offset = "0x759A580", VA = "0x18759BB80")]
	public void PAKPGHCKHHH(float AINNCKMHEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x759B010", Offset = "0x7599A10", VA = "0x18759B010")]
	public void LKJDFILLICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x759A280", Offset = "0x7598C80", VA = "0x18759A280")]
	public void FFPCHLDHDDI(JLFGMDFJNME BCAMOIBPPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x759A3B0", Offset = "0x7598DB0", VA = "0x18759A3B0")]
	public void FNNGFCEAGLL(JLFGMDFJNME BCAMOIBPPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x759A4E0", Offset = "0x7598EE0", VA = "0x18759A4E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	public DGHEJJHCOCG(Action OMALCONAAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D25680", Offset = "0x6D24080", VA = "0x186D25680", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public HGLJDLMPCOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3F3A2B0", Offset = "0x3F38CB0", VA = "0x183F3A2B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0390", Offset = "0xABED90", VA = "0x180AC0390", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x48DEA10", Offset = "0x48DD410", VA = "0x1848DEA10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x48DE850", Offset = "0x48DD250", VA = "0x1848DE850")]
	private static bool KKBILJAAMLP(T MOKDKAEJAPP, T MKGNFMMEFHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x48DEB90", Offset = "0x48DD590", VA = "0x1848DEB90")]
	public OBDDNADBGBJ(T AOPOAFMMANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x48DDFF0", Offset = "0x48DC9F0", VA = "0x1848DDFF0", Slot = "6")]
	public IDisposable AHDFJHLNLGK(UnityEngine.Object EIGKPCONJCB, Action<T> GHADBBIBJBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x48DE1B0", Offset = "0x48DCBB0", VA = "0x1848DE1B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x75A4A00", Offset = "0x75A3400", VA = "0x1875A4A00")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	internal static void GLOIIIDMGBC(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	[UnityEngine.Scripting.Preserve]
	internal FHJKHLKMLPL([OLJNBPOCBCJ(null)] EAPONALPEAD BCMLELHGFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x75A4A70", Offset = "0x75A3470", VA = "0x1875A4A70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x75995B0", Offset = "0x7597FB0", VA = "0x1875995B0")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	internal static void MNJJOBMFJLK(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7599A70", Offset = "0x7598470", VA = "0x187599A70")]
	[UnityEngine.Scripting.Preserve]
	public BLNALHAOEHI([OLJNBPOCBCJ(null)] LFCFJGDBKCD ANNFHHILFNE, [OLJNBPOCBCJ(null)] MNIICNDGLBN AELHONDGPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7599000", Offset = "0x7597A00", VA = "0x187599000", Slot = "18")]
	public override EPGCCCKMEBG GHFELCNHOHG(KOBKNGEGEGD EIGKPCONJCB, IEnumerator<GJDHNIMFMOA> NNKBPOEMAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7599320", Offset = "0x7597D20", VA = "0x187599320", Slot = "19")]
	public override void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7599840", Offset = "0x7598240", VA = "0x187599840", Slot = "21")]
	public override void OODJNIBCIJH(AGFOBJNEDPO FILNFIJCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x75991B0", Offset = "0x7597BB0", VA = "0x1875991B0", Slot = "20")]
	protected override void KOLHFLEMELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7598E50", Offset = "0x7597850", VA = "0x187598E50")]
	private CDGONIFMNAC BOJPDEMNANM(AGFOBJNEDPO JLAAKHANEHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7599620", Offset = "0x7598020", VA = "0x187599620", Slot = "22")]
	internal override PBPJLNLHFEF OBMONFLCOGO(IEnumerator<GJDHNIMFMOA> NNKBPOEMAKB, Behaviour EIGKPCONJCB, NOPMABIBALJ LCHMOEJABHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7599130", Offset = "0x7597B30", VA = "0x187599130", Slot = "23")]
	internal override FHMHHMLEKDA JMPPCIHPLGD(AGFOBJNEDPO FNMJLANICAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7598E80", Offset = "0x7597880", VA = "0x187598E80")]
	private void CHOMMILNPFK(CDGONIFMNAC CPBKHAFFNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7598FA0", Offset = "0x75979A0", VA = "0x187598FA0", Slot = "24")]
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
	[Cpp2IlInjected.Address(RVA = "0x7597550", Offset = "0x7595F50", VA = "0x187597550")]
	public static AMGHCPPBABL GMDNOGMNFLF(int GDALIEGDNKL, float AINNCKMHEPN, NativeArray<HEAFDHCLALH> APJPKPLLJDJ, NativeArray<float> INFGPHFEJIC, NativeArray<int> FNGHCJJIBDB, NativeArray<int> OKHEGJGLODC, NativeArray<int> PHIBHJHGJCC, NativeArray<int> NJIPKADCGKN, NativeArray<int> GCCHJDLDIAM)
	{
		return default(AMGHCPPBABL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7597470", Offset = "0x7595E70", VA = "0x187597470", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7597390", Offset = "0x7595D90", VA = "0x187597390")]
	private bool EHOMGBLMEDF(int HGFDMIDEFHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x75977F0", Offset = "0x75961F0", VA = "0x1875977F0")]
	private void OLMAELAKKLA(NativeArray<int> OLFJJNHNEOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x75973D0", Offset = "0x7595DD0", VA = "0x1875973D0")]
	private int EIMDHIAENIM(int HNFCHLCOANK, int GHJHJGCGJIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7597820", Offset = "0x7596220", VA = "0x187597820")]
	private void PPDGEFKGPAK(NativeArray<int> OLFJJNHNEOC, int BNMONOECCAD, int CGJIPKMEOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x75975B0", Offset = "0x7595FB0", VA = "0x1875975B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7595F50", Offset = "0x7594950", VA = "0x187595F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static bool CMFCJHGPMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public AGFOBJNEDPO FJHAPLLHLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8961A0", Offset = "0x894BA0", VA = "0x1808961A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(AGFOBJNEDPO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x899070", Offset = "0x897A70", VA = "0x180899070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public MNIICNDGLBN OKKNMAFMNLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GJDHNIMFMOA EMOIECJJKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x899AA0", Offset = "0x8984A0", VA = "0x180899AA0", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x899850", Offset = "0x898250", VA = "0x180899850", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7595FC0", Offset = "0x75949C0", VA = "0x187595FC0")]
	public static EPGCCCKMEBG IMOCHKAEIGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x75967C0", Offset = "0x75951C0", VA = "0x1875967C0")]
	[UnityEngine.Scripting.Preserve]
	protected AHACCJNJPHI([OLJNBPOCBCJ(null)] LFCFJGDBKCD ANNFHHILFNE, [OLJNBPOCBCJ(null)] MNIICNDGLBN AELHONDGPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7595B00", Offset = "0x7594500", VA = "0x187595B00", Slot = "6")]
	public EPGCCCKMEBG CKOMBPKHALD(IEnumerator<GJDHNIMFMOA> NNKBPOEMAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7595900", Offset = "0x7594300", VA = "0x187595900", Slot = "7")]
	public EPGCCCKMEBG CKOMBPKHALD(Behaviour EIGKPCONJCB, IEnumerator<GJDHNIMFMOA> NNKBPOEMAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract EPGCCCKMEBG GHFELCNHOHG(KOBKNGEGEGD EIGKPCONJCB, IEnumerator<GJDHNIMFMOA> NNKBPOEMAKB);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x75964A0", Offset = "0x7594EA0", VA = "0x1875964A0", Slot = "19")]
	public virtual void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7596220", Offset = "0x7594C20", VA = "0x187596220", Slot = "9")]
	public void KEOMJLGANNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7596480", Offset = "0x7594E80", VA = "0x187596480", Slot = "20")]
	protected virtual void KOLHFLEMELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x75967A0", Offset = "0x75951A0", VA = "0x1875967A0")]
	private void PDAHJDEMECK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x75966F0", Offset = "0x75950F0", VA = "0x1875966F0")]
	private void OMNEEMBCFMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7595ED0", Offset = "0x75948D0", VA = "0x187595ED0")]
	private void FDNCIOBOPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x75966D0", Offset = "0x75950D0", VA = "0x1875966D0")]
	private void MELEPMCBAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x75958E0", Offset = "0x75942E0", VA = "0x1875958E0")]
	private void CHMDLIONIBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7596460", Offset = "0x7594E60", VA = "0x187596460")]
	private void KFKNEFBHBGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x75958C0", Offset = "0x75942C0", VA = "0x1875958C0")]
	private void BPFPAEFNEBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7596710", Offset = "0x7595110", VA = "0x187596710", Slot = "21")]
	public virtual void OODJNIBCIJH(AGFOBJNEDPO FILNFIJCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7596050", Offset = "0x7594A50", VA = "0x187596050")]
	private void KEAFMJCDCFE(FHMHHMLEKDA CPBKHAFFNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x20561F0", Offset = "0x2054BF0", VA = "0x1820561F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7595B10", Offset = "0x7594510", VA = "0x187595B10", Slot = "24")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7595860", Offset = "0x7594260", VA = "0x187595860", Slot = "14")]
	public GJDHNIMFMOA BOHBGOOCHKD(AGFOBJNEDPO FNMJLANICAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7596640", Offset = "0x7595040", VA = "0x187596640", Slot = "15")]
	public GJDHNIMFMOA LJGBBEMLEDC(float GMOGAEOJHDH, AGFOBJNEDPO FNMJLANICAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7595EF0", Offset = "0x75948F0", VA = "0x187595EF0", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public GJDHNIMFMOA MCNKHAHCMFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool JGPMFACAIJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x75AF350", Offset = "0x75ADD50", VA = "0x1875AF350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool GDMIGOCPJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xAC0340", Offset = "0xABED40", VA = "0x180AC0340")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xC6A3C0", Offset = "0xC68DC0", VA = "0x180C6A3C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x75AF1A0", Offset = "0x75ADBA0", VA = "0x1875AF1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float KKPJLGBJOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAC0300", Offset = "0xABED00", VA = "0x180AC0300")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x61D73E0", Offset = "0x61D5DE0", VA = "0x1861D73E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x75AF4B0", Offset = "0x75ADEB0", VA = "0x1875AF4B0")]
	public PBPJLNLHFEF(IEnumerator<GJDHNIMFMOA> FDIEFIIIOIE, LFEAOCHFPEN EIGKPCONJCB, NOPMABIBALJ LCHMOEJABHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x75AEDD0", Offset = "0x75AD7D0", VA = "0x1875AEDD0")]
	public GJDHNIMFMOA DFCAGCFDJLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x75AF0E0", Offset = "0x75ADAE0", VA = "0x1875AF0E0")]
	public bool ENEBOBPLGKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x75AF150", Offset = "0x75ADB50", VA = "0x1875AF150")]
	public void FFPCHLDHDDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x75AF3D0", Offset = "0x75ADDD0", VA = "0x1875AF3D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xCD3E00", Offset = "0xCD2800", VA = "0x180CD3E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D0DA0", Offset = "0x9CF7A0", VA = "0x1809D0DA0", Slot = "23")]
		get
		{
			return default(AGFOBJNEDPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public AGFOBJNEDPO IFKHOHEMJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9D1D00", Offset = "0x9D0700", VA = "0x1809D1D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float CBIPHHPAOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x966060", Offset = "0x964A60", VA = "0x180966060", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool GMJFKNJEEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x75ADE20", Offset = "0x75AC820", VA = "0x1875ADE20", Slot = "24")]
	private bool NBKEJPMPHAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x75ADE10", Offset = "0x75AC810", VA = "0x1875ADE10", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x75ADE40", Offset = "0x75AC840", VA = "0x1875ADE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x899850", Offset = "0x898250", VA = "0x180899850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x75A6030", Offset = "0x75A4A30", VA = "0x1875A6030")]
	public FHMHHMLEKDA(AGFOBJNEDPO FNMJLANICAA, DGOAJBEMGHD HHCMABBJDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x75A5C70", Offset = "0x75A4670", VA = "0x1875A5C70")]
	public void OPGCPDJOKIK(PBPJLNLHFEF FDIEFIIIOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x75A5600", Offset = "0x75A4000", VA = "0x1875A5600")]
	public void IKIDAINPPCO(IList<PBPJLNLHFEF> LNLMPHMFEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x75A4D90", Offset = "0x75A3790", VA = "0x1875A4D90")]
	public void CEMKIBHAMMA(IList<PBPJLNLHFEF> LNLMPHMFEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x75A4B20", Offset = "0x75A3520", VA = "0x1875A4B20")]
	private void BDABMKHEPHL(PBPJLNLHFEF FDIEFIIIOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x75A5D70", Offset = "0x75A4770", VA = "0x1875A5D70")]
	private void PLHKKMGCKLJ(IList<PBPJLNLHFEF> LNLMPHMFEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x75A4C10", Offset = "0x75A3610", VA = "0x1875A4C10")]
	private NIDJKHLAJOA CCJGFOLFPLH(PBPJLNLHFEF FDIEFIIIOIE)
	{
		return default(NIDJKHLAJOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x75A5B00", Offset = "0x75A4500", VA = "0x1875A5B00")]
	public void KOLHFLEMELG(float AINNCKMHEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x75A5910", Offset = "0x75A4310", VA = "0x1875A5910")]
	public void KEOMJLGANNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x75A5300", Offset = "0x75A3D00", VA = "0x1875A5300")]
	private void FPKGPOLLMIG(List<PBPJLNLHFEF> LNLMPHMFEFA, Stack<int> CPKBEOMOBCO, bool MDGBPHKDOHJ, float IDHENHIBONN = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x75A50A0", Offset = "0x75A3AA0", VA = "0x1875A50A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x75A51C0", Offset = "0x75A3BC0", VA = "0x1875A51C0")]
	private void EAPCIOIDHID(List<PBPJLNLHFEF> LNLMPHMFEFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class MGGPMINGIAL : DGOAJBEMGHD
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "4")]
	public void GMJKCGEGKHB(string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
	public void AOFMHGBADGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75ABC40", Offset = "0x75AA640", VA = "0x1875ABC40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool OKKHPAEKBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x75ABBF0", Offset = "0x75AA5F0", VA = "0x1875ABBF0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool NKEDCLEGNEH
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x75ABCC0", Offset = "0x75AA6C0", VA = "0x1875ABCC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
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

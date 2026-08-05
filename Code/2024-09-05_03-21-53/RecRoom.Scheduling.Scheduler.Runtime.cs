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
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7508950", Offset = "0x7507350", VA = "0x187508950", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
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
		private delegate List<PlayerLoopSystem> OHGNFJLFFFD(List<PlayerLoopSystem> HFOFDACDEOK, int MMEPLMKDMKA);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct IHJLEBBDHML
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct LOGJJJPBMLJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static PLAJPLAPENK MKFILNPGKKL;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x74FE9E0", Offset = "0x74FD3E0", VA = "0x1874FE9E0")]
				public static PlayerLoopSystem KFNCMPCLDNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct NGKIKPDKJNL
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static PLAJPLAPENK CBGDCLLAPCC;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x7504BC0", Offset = "0x75035C0", VA = "0x187504BC0")]
				public static PlayerLoopSystem KFNCMPCLDNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct NOEHDBJHAMP
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static PLAJPLAPENK HJKCFCOEIAB;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x7505440", Offset = "0x7503E40", VA = "0x187505440")]
				public static PlayerLoopSystem KFNCMPCLDNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct EIJLFAIGHHH
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static PLAJPLAPENK IKEOCKANECG;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static PLAJPLAPENK OJGHNJBMOPC;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static PLAJPLAPENK AJPGMOOAOLM;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static PLAJPLAPENK EIKHDAOKIEH;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x74F83F0", Offset = "0x74F6DF0", VA = "0x1874F83F0")]
				public static PlayerLoopSystem KFNCMPCLDNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct KAEAFCCHAJG
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static PLAJPLAPENK OIKKBBJBDKB;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x74FA6B0", Offset = "0x74F90B0", VA = "0x1874FA6B0")]
				public static PlayerLoopSystem KFNCMPCLDNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct PDGLPLDDCEL
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static PLAJPLAPENK IKEOCKANECG;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static PLAJPLAPENK OJGHNJBMOPC;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static PLAJPLAPENK AJPGMOOAOLM;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static PLAJPLAPENK EIKHDAOKIEH;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x7506FD0", Offset = "0x75059D0", VA = "0x187506FD0")]
				public static PlayerLoopSystem KFNCMPCLDNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct MFJFBNKNLAE
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static PLAJPLAPENK DIABJBHMFJG;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x75016D0", Offset = "0x75000D0", VA = "0x1875016D0")]
				public static PlayerLoopSystem KFNCMPCLDNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct FNGIPOGBIBK
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static PLAJPLAPENK POGEBBBGCEI;

				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x74F8A80", Offset = "0x74F7480", VA = "0x1874F8A80")]
				public static PlayerLoopSystem KFNCMPCLDNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct GGAGNEICNEP
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static PLAJPLAPENK KFPGCBLAOPE;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x74F9A30", Offset = "0x74F8430", VA = "0x1874F9A30")]
				public static PlayerLoopSystem KFNCMPCLDNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct BOGLIFIMION
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static PLAJPLAPENK NFFNAANAHFM;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x74EF6C0", Offset = "0x74EE0C0", VA = "0x1874EF6C0")]
				public static PlayerLoopSystem KFNCMPCLDNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct PJIJKILCCAO
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static PLAJPLAPENK JEFHLHKNKBD;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x75075E0", Offset = "0x7505FE0", VA = "0x1875075E0")]
				public static PlayerLoopSystem KFNCMPCLDNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct IEJNBJMFMEJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static PLAJPLAPENK LMEFKDJMFFH;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x74F9DF0", Offset = "0x74F87F0", VA = "0x1874F9DF0")]
				public static PlayerLoopSystem KFNCMPCLDNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct PFODFHPCCHC
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static PLAJPLAPENK LBOEADHCJKF;

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x75072F0", Offset = "0x7505CF0", VA = "0x1875072F0")]
				public static PlayerLoopSystem KFNCMPCLDNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum GPDBFBEBOPB : byte
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
			public struct LINLHOKJIBI
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class IOCJEJJGKBC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public GPDBFBEBOPB updateStage;

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
					public IOCJEJJGKBC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x74F9FD0", Offset = "0x74F89D0", VA = "0x1874F9FD0")]
					internal void COHEKADODAG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static HLIGJNPKABP<GPDBFBEBOPB> OIABMGLHNLP;

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x74FD600", Offset = "0x74FC000", VA = "0x1874FD600")]
				public static PlayerLoopSystem KFNCMPCLDNI(GPDBFBEBOPB NHBOBLFEPPF)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			internal struct MDLNOGJBFEE
			{
				[Cpp2IlInjected.Token(Token = "0x2000024")]
				[CompilerGenerated]
				private sealed class JBMMFKCPAEJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public MFIFCOHFBMM.OMFCECJNGMD key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
					public JBMMFKCPAEJ()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x74FA110", Offset = "0x74F8B10", VA = "0x1874FA110")]
					internal void LCFMFAOMABO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable CKKPKEPLABO;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x74FF790", Offset = "0x74FE190", VA = "0x1874FF790")]
				public static PlayerLoopSystem KAKIBOMBAFO(MFIFCOHFBMM.OMFCECJNGMD JODEIIFHAPK)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			internal struct PCHBEDODEGB
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class BLJGGAGKDDM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public MFIFCOHFBMM.OMFCECJNGMD key;

					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
					public BLJGGAGKDDM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0x74EF320", Offset = "0x74EDD20", VA = "0x1874EF320")]
					internal void LCFMFAOMABO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x7506EA0", Offset = "0x75058A0", VA = "0x187506EA0")]
				public static PlayerLoopSystem KAKIBOMBAFO(MFIFCOHFBMM.OMFCECJNGMD JODEIIFHAPK)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class HHDNLALGHIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public HHDNLALGHIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x74F9C10", Offset = "0x74F8610", VA = "0x1874F9C10")]
			internal List<PlayerLoopSystem> IFMGJNDHLPL(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool MPJJAOOGEJL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool BFPJNGHNHLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x74F6E30", Offset = "0x74F5830", VA = "0x1874F6E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x74F41A0", Offset = "0x74F2BA0", VA = "0x1874F41A0")]
		private static void EFFBBFFDEMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74F34B0", Offset = "0x74F1EB0", VA = "0x1874F34B0")]
		private static void CLEPMDKDKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x74F3470", Offset = "0x74F1E70", VA = "0x1874F3470")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74F6E70", Offset = "0x74F5870", VA = "0x1874F6E70")]
		private static void OEBECLACGJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74F70B0", Offset = "0x74F5AB0", VA = "0x1874F70B0")]
		private static void OMJNGEJCJDH(MFIFCOHFBMM.OMFCECJNGMD JODEIIFHAPK, PlayerLoopSystem LPBIBHKCICJ, Type CLIOFHPBBKI, Type KNICENMKKIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x74F3DC0", Offset = "0x74F27C0", VA = "0x1874F3DC0")]
		private static void DLFKDGBCGNL(PlayerLoopSystem LPBIBHKCICJ, Type CLIOFHPBBKI, Type KNICENMKKIO, OHGNFJLFFFD GOMEDNDOBGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x74F6D00", Offset = "0x74F5700", VA = "0x1874F6D00")]
		private static void GLHALLLFCAH(PlayerLoopSystem LPBIBHKCICJ, Type CLIOFHPBBKI, Type KNICENMKKIO, PlayerLoopSystem? KHEAMJCFPOO, PlayerLoopSystem? OBJOBGEKIBH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class MFIFCOHFBMM
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum OMFCECJNGMD
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
	public class LLJBMMNIGNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly OMFCECJNGMD LHKMFDGOHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly CPPHPKGFFAG CHOJKGBEAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private long FFCKOJBGKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long KPGGGGPFDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long NJFEMHEIGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int ALGBMBAEDNM;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x74FE8D0", Offset = "0x74FD2D0", VA = "0x1874FE8D0")]
		public LLJBMMNIGNM(OMFCECJNGMD FCHCAKGNMAF, int ALEHNPANMBF = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x74FE860", Offset = "0x74FD260", VA = "0x1874FE860")]
		public void HJMODLIIDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x74FE810", Offset = "0x74FD210", VA = "0x1874FE810")]
		public void HFNLHLFGLAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x74FE630", Offset = "0x74FD030", VA = "0x1874FE630")]
		public void FBPCCPFOGJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static OMFCECJNGMD[] EHIHCHBLDFP;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static LLJBMMNIGNM[] FJNPNPLFMHP;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7501250", Offset = "0x74FFC50", VA = "0x187501250")]
	public static LLJBMMNIGNM LCHAIBFNLJN(OMFCECJNGMD JODEIIFHAPK, int ALEHNPANMBF = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7501430", Offset = "0x74FFE30", VA = "0x187501430")]
	public static LLJBMMNIGNM MJGHAGENAKL(OMFCECJNGMD JODEIIFHAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x75014A0", Offset = "0x74FFEA0", VA = "0x1875014A0")]
	public static void OLOHCJLAGBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class CPPHPKGFFAG : KIBKCNNAKFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int GFNKCIFJDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Queue<double> PKMDICCHNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double NLBIFNGGFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double AAGMKEOFFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double HMMHFDNMHKF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double OOGFNFJKGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x74F3360", Offset = "0x74F1D60", VA = "0x1874F3360", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double MAFMEPCPIBK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1C9E990", Offset = "0x1C9D390", VA = "0x181C9E990", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double BNLDEALEKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x204F780", Offset = "0x204E180", VA = "0x18204F780", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x74F33C0", Offset = "0x74F1DC0", VA = "0x1874F33C0")]
	public CPPHPKGFFAG(int LOEHOJEMCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x74F3240", Offset = "0x74F1C40", VA = "0x1874F3240", Slot = "7")]
	public void CHGBIJCNMBH(double APKMEEHDCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x74F31D0", Offset = "0x74F1BD0", VA = "0x1874F31D0", Slot = "8")]
	public void CGBFLDMMJFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class BINFPIBCMKA : KIBKCNNAKFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private long KFBJHPBJLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double ECPAJJGHCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double GKBPFKPPDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double EAAGGJKCNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double AGMEDKGOJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double NLBIFNGGFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double AAGMKEOFFOB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double MAFMEPCPIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6131C40", Offset = "0x6130640", VA = "0x186131C40", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double BNLDEALEKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x61317C0", Offset = "0x61301C0", VA = "0x1861317C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double KCIEHMELOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6131C00", Offset = "0x6130600", VA = "0x186131C00")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double OOGFNFJKGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2662B30", Offset = "0x2661530", VA = "0x182662B30", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x74EF1D0", Offset = "0x74EDBD0", VA = "0x1874EF1D0", Slot = "7")]
	public virtual void CHGBIJCNMBH(double APKMEEHDCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74EF190", Offset = "0x74EDB90", VA = "0x1874EF190", Slot = "8")]
	public virtual void CGBFLDMMJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x74EF2F0", Offset = "0x74EDCF0", VA = "0x1874EF2F0")]
	public BINFPIBCMKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class EPBGCHDNFJK : BINFPIBCMKA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double JGBOIKKOIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6131790", Offset = "0x6130190", VA = "0x186131790")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6131C20", Offset = "0x6130620", VA = "0x186131C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x74F8910", Offset = "0x74F7310", VA = "0x1874F8910", Slot = "7")]
	public override void CHGBIJCNMBH(double APKMEEHDCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x74F88D0", Offset = "0x74F72D0", VA = "0x1874F88D0", Slot = "8")]
	public override void CGBFLDMMJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x74EF2F0", Offset = "0x74EDCF0", VA = "0x1874EF2F0")]
	public EPBGCHDNFJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface KIBKCNNAKFH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double OOGFNFJKGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double MAFMEPCPIBK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double BNLDEALEKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class OHIGJEMGPFG
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface KEOOIPCBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool EPLIHDLEPOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IEGBLMMEELB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class CCGICCGEFAO : KEOOIPCBCFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly Action ENNGIICFMFD;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool EPLIHDLEPOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
		public CCGICCGEFAO(Action ENNGIICFMFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0", Slot = "5")]
		public void IEGBLMMEELB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<KEOOIPCBCFO> LHOLMCIFIMK;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7505900", Offset = "0x7504300", VA = "0x187505900")]
	public static void APKFHCFMIHA(Action ENNGIICFMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7505E50", Offset = "0x7504850", VA = "0x187505E50")]
	private static void KGNPAFLIIIH(KEOOIPCBCFO BNEKOPCADLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7505AA0", Offset = "0x75044A0", VA = "0x187505AA0")]
	private static void IJGMDLAACGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x75059A0", Offset = "0x75043A0", VA = "0x1875059A0")]
	private static void BKKOEEHBBNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7505D80", Offset = "0x7504780", VA = "0x187505D80")]
	private static void JNJCOFKENNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class CPMNHKEPMGO
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct HJIPEBJEIEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public TaskCompletionSource<Scene> JKCAFBCNIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly string MENDEBCFHFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly LoadSceneMode LFOMFFNLOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly bool ALIMGAFDDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly PFEDKLFBPJA<string>.BEABGGDOFCM BPFOFDNLKCD;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x74F9D30", Offset = "0x74F8730", VA = "0x1874F9D30")]
		public HJIPEBJEIEP(TaskCompletionSource<Scene> MGJCJEDJLDK, string MENDEBCFHFI, LoadSceneMode LFOMFFNLOEN, bool ALIMGAFDDLH, PFEDKLFBPJA<string>.BEABGGDOFCM BPFOFDNLKCD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct KEAJOLAJNAO : IAsyncStateMachine
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
		public PFEDKLFBPJA<string>.BEABGGDOFCM stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private PFEDKLFBPJA<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x74FA890", Offset = "0x74F9290", VA = "0x1874FA890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x74FB130", Offset = "0x74F9B30", VA = "0x1874FB130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct OMDKAKEBFGH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75068A0", Offset = "0x75052A0", VA = "0x1875068A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7506BB0", Offset = "0x75055B0", VA = "0x187506BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct EBFNOAEELJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private HJIPEBJEIEP <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x74F7FE0", Offset = "0x74F69E0", VA = "0x1874F7FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x74F8390", Offset = "0x74F6D90", VA = "0x1874F8390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class IDKDOKDBLLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public BHIPCNJCDJM<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public IDKDOKDBLLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x74F9D90", Offset = "0x74F8790", VA = "0x1874F9D90")]
		internal void IDPDKFKPNJF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct MBANILPPIHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public PFEDKLFBPJA<string>.BEABGGDOFCM stackTimer;

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
		private IDKDOKDBLLH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private PFEDKLFBPJA<string>.BEABGGDOFCM <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private PFEDKLFBPJA<string>.BEABGGDOFCM <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x74FEBC0", Offset = "0x74FD5C0", VA = "0x1874FEBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x74FF720", Offset = "0x74FE120", VA = "0x1874FF720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct GDBMBCLKLCG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x74F91E0", Offset = "0x74F7BE0", VA = "0x1874F91E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x74F96B0", Offset = "0x74F80B0", VA = "0x1874F96B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct DNHCFBBMFJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public PFEDKLFBPJA<string>.BEABGGDOFCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private PFEDKLFBPJA<string>.BEABGGDOFCM <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private PFEDKLFBPJA<string>.BEABGGDOFCM <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x74F7450", Offset = "0x74F5E50", VA = "0x1874F7450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x74F7F70", Offset = "0x74F6970", VA = "0x1874F7F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class LHJGDNFIOIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public LHJGDNFIOIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x74FCAF0", Offset = "0x74FB4F0", VA = "0x1874FCAF0")]
		internal bool KADIFLBLAGE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CPGDJNELPFL : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public EOBCPEOLCKN onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public CPGDJNELPFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x74F1790", Offset = "0x74F0190", VA = "0x1874F1790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x74F1410", Offset = "0x74EFE10", VA = "0x1874F1410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x74F13C0", Offset = "0x74EFDC0", VA = "0x1874F13C0")]
		private void GPKDFCKBEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x74F1740", Offset = "0x74F0140", VA = "0x1874F1740", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class ODHMODOECJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public BHIPCNJCDJM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public ODHMODOECJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7505620", Offset = "0x7504020", VA = "0x187505620")]
		internal bool OGDHNNKGGFP(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x75056A0", Offset = "0x75040A0", VA = "0x1875056A0")]
		internal void PFKMNIIAKFK(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class LBOCJLPPCBE : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public BHIPCNJCDJM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private ODHMODOECJE <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public LBOCJLPPCBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x74FBC40", Offset = "0x74FA640", VA = "0x1874FBC40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x74FC2A0", Offset = "0x74FACA0", VA = "0x1874FC2A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly ICollection<string> LKLDMLLEPGE;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static MFAPHLCBHHA NGFCBIFOJEH;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static AsyncOperation OOHFCEIMJBM;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static MFAPHLCBHHA JBJGBLEOMHM;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static string EKJKFIDFLMM;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static ThreadPriority JBFBNDHJOFK;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static Task FMLNNCBKJPG;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static List<SceneInstance> EJKGNBPLCEJ;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly Queue<HJIPEBJEIEP> GLNIGGICKHP;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static Task GFDHJKHJNJC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool BFCGFBIJKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x74F1CD0", Offset = "0x74F06D0", VA = "0x1874F1CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private static bool NGOAPJELNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x74F29C0", Offset = "0x74F13C0", VA = "0x1874F29C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private static bool CFOBIMCKLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x74F1B80", Offset = "0x74F0580", VA = "0x1874F1B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool HNABCJPKNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x74F1AF0", Offset = "0x74F04F0", VA = "0x1874F1AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> NCLABOLKIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x74F2340", Offset = "0x74F0D40", VA = "0x1874F2340")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x74F2CD0", Offset = "0x74F16D0", VA = "0x1874F2CD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x74F2760", Offset = "0x74F1160", VA = "0x1874F2760")]
	[ALOHFLAKNNE(OOMJJAJIPFF.EnteredEditModeNextFrame, 0)]
	private static void HLECIPOPFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x74F19A0", Offset = "0x74F03A0", VA = "0x1874F19A0")]
	[AsyncStateMachine(typeof(KEAJOLAJNAO))]
	public static Task<Scene> CHPJNPDHMME(string MENDEBCFHFI, LoadSceneMode LFOMFFNLOEN = LoadSceneMode.Single, bool ALIMGAFDDLH = false, [Optional] PFEDKLFBPJA<string>.BEABGGDOFCM LNEGOCPANHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x74F1C20", Offset = "0x74F0620", VA = "0x1874F1C20")]
	[AsyncStateMachine(typeof(OMDKAKEBFGH))]
	private static Task DIPMLPJAGLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x74F28F0", Offset = "0x74F12F0", VA = "0x1874F28F0")]
	[AsyncStateMachine(typeof(EBFNOAEELJC))]
	private static Task JCJMJANFAGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x74F2A60", Offset = "0x74F1460", VA = "0x1874F2A60")]
	[AsyncStateMachine(typeof(MBANILPPIHB))]
	private static Task<Scene> LCFLCJALLHK(string MENDEBCFHFI, LoadSceneMode LFOMFFNLOEN, bool ALIMGAFDDLH, PFEDKLFBPJA<string>.BEABGGDOFCM BPFOFDNLKCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x74F2450", Offset = "0x74F0E50", VA = "0x1874F2450")]
	private static void FOIMGGGFMKD(SceneInstance NKEOLIFBNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x74F2560", Offset = "0x74F0F60", VA = "0x1874F2560")]
	private static void HCNGPBBIMLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x74F2BB0", Offset = "0x74F15B0", VA = "0x1874F2BB0")]
	[AsyncStateMachine(typeof(GDBMBCLKLCG))]
	private static Task<Scene> LHNOLFNCADO(string MENDEBCFHFI, LoadSceneMode LFOMFFNLOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x74F2DE0", Offset = "0x74F17E0", VA = "0x1874F2DE0")]
	private static bool OHPNNAEDIJA(string MENDEBCFHFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x74F2230", Offset = "0x74F0C30", VA = "0x1874F2230")]
	[AsyncStateMachine(typeof(DNHCFBBMFJB))]
	private static Task<Scene> FHGPHNPDMKP(PFEDKLFBPJA<string>.BEABGGDOFCM BPFOFDNLKCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x74F1820", Offset = "0x74F0220", VA = "0x1874F1820")]
	public static CAPIMDIPLHM<Scene> ABLBDLBHNNC(string MENDEBCFHFI, LoadSceneMode LFOMFFNLOEN = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x74F1F70", Offset = "0x74F0970", VA = "0x1874F1F70")]
	public static MFAPHLCBHHA EOFBCHCPEON(string MENDEBCFHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x74F1EE0", Offset = "0x74F08E0", VA = "0x1874F1EE0")]
	[IteratorStateMachine(typeof(CPGDJNELPFL))]
	private static IEnumerator<IHLHBLBKNMF> EBLJBLAFAAJ(string MENDEBCFHFI, EOBCPEOLCKN MEEEOJLHLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x74F2850", Offset = "0x74F1250", VA = "0x1874F2850")]
	[IteratorStateMachine(typeof(LBOCJLPPCBE))]
	private static IEnumerator<IHLHBLBKNMF> IDFEOBHNGAJ(string MENDEBCFHFI, LoadSceneMode LFOMFFNLOEN, BHIPCNJCDJM<Scene> MEEEOJLHLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x74F2ED0", Offset = "0x74F18D0", VA = "0x1874F2ED0")]
	public static bool OKOGFHMGLHD([Out] string KGNGKGCDPND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class LJJNIHEPBCC
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x74FD7C0", Offset = "0x74FC1C0", VA = "0x1874FD7C0")]
	public static IDisposable AEOEAPGLFHN(this KFMPKLNJPKH GJGBLLHIOAC, float IONMCPNCJEO, Action<float> BLCAHGBMEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x74FD8D0", Offset = "0x74FC2D0", VA = "0x1874FD8D0")]
	public static IDisposable JHAACHFIBJH(this KFMPKLNJPKH GJGBLLHIOAC, Action<float> BLCAHGBMEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x74FD850", Offset = "0x74FC250", VA = "0x1874FD850")]
	public static IDisposable AIJAFKCCDCH(this KFMPKLNJPKH GJGBLLHIOAC, Action<float> BLCAHGBMEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BCCGGKDCJHA
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x74ED6A0", Offset = "0x74EC0A0", VA = "0x1874ED6A0")]
	public static IDisposable BAGGDNOMPFK(this MonoBehaviour EOBJGBKPDGF, Action BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x74ED610", Offset = "0x74EC010", VA = "0x1874ED610")]
	public static IDisposable BAGGDNOMPFK(this MonoBehaviour EOBJGBKPDGF, Action<float> BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x74ED8B0", Offset = "0x74EC2B0", VA = "0x1874ED8B0")]
	public static IDisposable DBMELBLEALE(this MonoBehaviour EOBJGBKPDGF, Action BLCAHGBMEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x74EDAF0", Offset = "0x74EC4F0", VA = "0x1874EDAF0")]
	public static IDisposable JFBBDMFFMMB(this MonoBehaviour EOBJGBKPDGF, Action BLCAHGBMEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x74EDB70", Offset = "0x74EC570", VA = "0x1874EDB70")]
	public static IDisposable JFBBDMFFMMB(this MonoBehaviour EOBJGBKPDGF, Action<float> BLCAHGBMEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x74EDDB0", Offset = "0x74EC7B0", VA = "0x1874EDDB0")]
	public static IDisposable NFAEOFAFOEC(this MonoBehaviour EOBJGBKPDGF, Action BLCAHGBMEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x74ED930", Offset = "0x74EC330", VA = "0x1874ED930")]
	public static IDisposable EJPCLEAJBLL(this MonoBehaviour EOBJGBKPDGF, Action BLCAHGBMEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x74EDC90", Offset = "0x74EC690", VA = "0x1874EDC90")]
	public static IDisposable KDHLFMNIMCD(this MonoBehaviour EOBJGBKPDGF, Action BLCAHGBMEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x74ED760", Offset = "0x74EC160", VA = "0x1874ED760")]
	public static IDisposable DAOBHNDDNNF(this MonoBehaviour EOBJGBKPDGF, float IONMCPNCJEO, Action<float> BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL, bool JHFPJGEBAJG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x74ED730", Offset = "0x74EC130", VA = "0x1874ED730")]
	public static IDisposable CBFEOKGDMLM(this MonoBehaviour EOBJGBKPDGF, float IONMCPNCJEO, Action<float> BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL, bool JHFPJGEBAJG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x74ED9B0", Offset = "0x74EC3B0", VA = "0x1874ED9B0")]
	public static IDisposable FADICOBMLEN(this MonoBehaviour EOBJGBKPDGF, float IONMCPNCJEO, Action<float> BLCAHGBMEEE, bool JHFPJGEBAJG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x74EDA50", Offset = "0x74EC450", VA = "0x1874EDA50")]
	public static IDisposable HGGICEKJGHO(this MonoBehaviour EOBJGBKPDGF, Action<float> BLCAHGBMEEE, bool JHFPJGEBAJG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x74ED810", Offset = "0x74EC210", VA = "0x1874ED810")]
	public static IDisposable DBHAPPHKPOM(this MonoBehaviour EOBJGBKPDGF, Action<float> BLCAHGBMEEE, bool JHFPJGEBAJG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x74EDBF0", Offset = "0x74EC5F0", VA = "0x1874EDBF0")]
	public static IDisposable JFCPEBAMEDK(this MonoBehaviour EOBJGBKPDGF, Action<float> BLCAHGBMEEE, bool JHFPJGEBAJG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x74EDED0", Offset = "0x74EC8D0", VA = "0x1874EDED0")]
	public static IDisposable PCEPBNAPBLE(this MonoBehaviour EOBJGBKPDGF, Action<float> BLCAHGBMEEE, bool JHFPJGEBAJG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x74EDE30", Offset = "0x74EC830", VA = "0x1874EDE30")]
	public static IDisposable NOGMGENFLPL(this MonoBehaviour EOBJGBKPDGF, Action<float> BLCAHGBMEEE, bool JHFPJGEBAJG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x74ED570", Offset = "0x74EBF70", VA = "0x1874ED570")]
	public static IDisposable AELJMPPLNIC(this MonoBehaviour EOBJGBKPDGF, Action<float> BLCAHGBMEEE, bool JHFPJGEBAJG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x74EDD10", Offset = "0x74EC710", VA = "0x1874EDD10")]
	public static IDisposable LFHAFGBHCFN(this MonoBehaviour EOBJGBKPDGF, Action<float> BLCAHGBMEEE, bool JHFPJGEBAJG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x74EDF70", Offset = "0x74EC970", VA = "0x1874EDF70")]
	public static IDisposable PJOMJFKAMEC(this MonoBehaviour EOBJGBKPDGF, float IONMCPNCJEO, Action<float> BLCAHGBMEEE, bool JHFPJGEBAJG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class GFILEJKJKJN
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class FOCKGFCLIIG : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public BFMEILOFOGD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private OPIAADFLNMN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public FOCKGFCLIIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x74F8C60", Offset = "0x74F7660", VA = "0x1874F8C60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x74F8D40", Offset = "0x74F7740", VA = "0x1874F8D40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class EMDLOEOLKBA : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public BFMEILOFOGD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private OPIAADFLNMN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public EMDLOEOLKBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x74F8790", Offset = "0x74F7190", VA = "0x1874F8790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x74F8880", Offset = "0x74F7280", VA = "0x1874F8880", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x74F9890", Offset = "0x74F8290", VA = "0x1874F9890")]
	public static DABMKCAGAIA BAGGDNOMPFK(Action BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x74F9800", Offset = "0x74F8200", VA = "0x1874F9800")]
	public static DABMKCAGAIA BAGGDNOMPFK(Behaviour GJGBLLHIOAC, Action BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x74F9720", Offset = "0x74F8120", VA = "0x1874F9720")]
	public static DABMKCAGAIA BAGGDNOMPFK(Behaviour GJGBLLHIOAC, Action<float> BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x74F99A0", Offset = "0x74F83A0", VA = "0x1874F99A0")]
	[IteratorStateMachine(typeof(FOCKGFCLIIG))]
	private static IEnumerator<IHLHBLBKNMF> PGACBJDEHHA(BFMEILOFOGD FDGDJNFBJAH, Action BLCAHGBMEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x74F9910", Offset = "0x74F8310", VA = "0x1874F9910")]
	[IteratorStateMachine(typeof(EMDLOEOLKBA))]
	private static IEnumerator<IHLHBLBKNMF> PGACBJDEHHA(BFMEILOFOGD FDGDJNFBJAH, Action<float> BLCAHGBMEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class JLBOOPOMKAO : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class OJMDGMGDALI : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public JLBOOPOMKAO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public OJMDGMGDALI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x75067C0", Offset = "0x75051C0", VA = "0x1875067C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7506850", Offset = "0x7505250", VA = "0x187506850", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly BFMEILOFOGD CEODDBLCABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Action DNMOHHLKAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private bool JJHHEADDICG;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool BDNJHNKEMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x891450", Offset = "0x88FE50", VA = "0x180891450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x74FA5B0", Offset = "0x74F8FB0", VA = "0x1874FA5B0")]
	public JLBOOPOMKAO(BFMEILOFOGD CEODDBLCABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x74FA490", Offset = "0x74F8E90", VA = "0x1874FA490")]
	[IteratorStateMachine(typeof(OJMDGMGDALI))]
	private IEnumerator<IHLHBLBKNMF> JFAMFNLBAKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x74FA510", Offset = "0x74F8F10", VA = "0x1874FA510", Slot = "4")]
	public void OnCompleted(Action KHCEAHCMJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public void HKCAIFDBLLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class LIBHIHPCKOL
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x74FCB20", Offset = "0x74FB520", VA = "0x1874FCB20")]
	public static JLBOOPOMKAO FOLONLOKBBG(this BFMEILOFOGD CEODDBLCABL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class BBLLJLJHMBL
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class EJIFBPKEJLI : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public NHKBGODDEND schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public EJIFBPKEJLI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x74F86C0", Offset = "0x74F70C0", VA = "0x1874F86C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x74F8740", Offset = "0x74F7140", VA = "0x1874F8740", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x74ED130", Offset = "0x74EBB30", VA = "0x1874ED130")]
	public static DABMKCAGAIA BAGGDNOMPFK(float IONMCPNCJEO, Action<float> BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL, bool JHFPJGEBAJG = true, [Optional] ODNBBNNHMNO MFPPIELLFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x74ED060", Offset = "0x74EBA60", VA = "0x1874ED060")]
	public static DABMKCAGAIA BAGGDNOMPFK(MonoBehaviour EOBJGBKPDGF, float IONMCPNCJEO, Action<float> BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL, bool JHFPJGEBAJG = true, [Optional] ODNBBNNHMNO MFPPIELLFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x74ED200", Offset = "0x74EBC00", VA = "0x1874ED200")]
	public static DABMKCAGAIA EBDLDAOKGDA(MonoBehaviour EOBJGBKPDGF, float IONMCPNCJEO, Action<float> BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL, bool JHFPJGEBAJG = true, [Optional] ODNBBNNHMNO MFPPIELLFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x74ED3E0", Offset = "0x74EBDE0", VA = "0x1874ED3E0")]
	public static DABMKCAGAIA PFDKMNOFAGK(KFMPKLNJPKH GJGBLLHIOAC, float IONMCPNCJEO, Action<float> BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL, bool JHFPJGEBAJG = true, [Optional] ODNBBNNHMNO MFPPIELLFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x74ED4B0", Offset = "0x74EBEB0", VA = "0x1874ED4B0")]
	private static IEnumerator<IHLHBLBKNMF> PGACBJDEHHA(ELFIGCGNHMA CLCFEDDKKMA, float IONMCPNCJEO, BFMEILOFOGD FDGDJNFBJAH, Action<float> BLCAHGBMEEE, bool JHFPJGEBAJG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x74ED2F0", Offset = "0x74EBCF0", VA = "0x1874ED2F0")]
	private static IEnumerator<IHLHBLBKNMF> EIMLCEDCNON(ELFIGCGNHMA CLCFEDDKKMA, float IONMCPNCJEO, BFMEILOFOGD FDGDJNFBJAH, Action<float> BLCAHGBMEEE, bool JHFPJGEBAJG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x74ED350", Offset = "0x74EBD50", VA = "0x1874ED350")]
	[IteratorStateMachine(typeof(EJIFBPKEJLI))]
	private static IEnumerator<IHLHBLBKNMF> LELPABBCMPD(NHKBGODDEND NAKKLMDMDCC, float IONMCPNCJEO, BFMEILOFOGD FDGDJNFBJAH, Action<float> BLCAHGBMEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class PANAFAIHKBA
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class PJHLMFLCFGP : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public BFMEILOFOGD queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public PJHLMFLCFGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x75074D0", Offset = "0x7505ED0", VA = "0x1875074D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7507590", Offset = "0x7505F90", VA = "0x187507590", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7506D30", Offset = "0x7505730", VA = "0x187506D30")]
	[IteratorStateMachine(typeof(PJHLMFLCFGP))]
	private static IEnumerator<IHLHBLBKNMF> IBCDAFNPFEC(BFMEILOFOGD CEODDBLCABL, Func<bool> PIIAKCKHONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7506DC0", Offset = "0x75057C0", VA = "0x187506DC0")]
	public static DABMKCAGAIA MCHJJBMIGHA(this MonoBehaviour EOBJGBKPDGF, Func<bool> PIIAKCKHONG, BFMEILOFOGD CEODDBLCABL = BFMEILOFOGD.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class LIENHKKJMHC
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class DBCAPDMHHFF : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public BFMEILOFOGD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public DBCAPDMHHFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x74F7270", Offset = "0x74F5C70", VA = "0x1874F7270", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x74F72E0", Offset = "0x74F5CE0", VA = "0x1874F72E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class MJPCIODPMCN : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public BFMEILOFOGD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private IHLHBLBKNMF <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public MJPCIODPMCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7504AE0", Offset = "0x75034E0", VA = "0x187504AE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7504B70", Offset = "0x7503570", VA = "0x187504B70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x74FD2E0", Offset = "0x74FBCE0", VA = "0x1874FD2E0")]
	[IteratorStateMachine(typeof(DBCAPDMHHFF))]
	private static IEnumerator<IHLHBLBKNMF> JFAMFNLBAKP(float CCMOFMGPDOB, BFMEILOFOGD FDGDJNFBJAH, Action MIDOKEPAEFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x74FCF40", Offset = "0x74FB940", VA = "0x1874FCF40")]
	[IteratorStateMachine(typeof(MJPCIODPMCN))]
	private static IEnumerator<IHLHBLBKNMF> FPMHPJJHDMJ(float CCMOFMGPDOB, BFMEILOFOGD FDGDJNFBJAH, Action MIDOKEPAEFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x74FCD20", Offset = "0x74FB720", VA = "0x1874FCD20")]
	public static IDisposable CNMOEEKHNFA(this MonoBehaviour EOBJGBKPDGF, float CCMOFMGPDOB, Action MIDOKEPAEFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x74FD080", Offset = "0x74FBA80", VA = "0x1874FD080")]
	public static DABMKCAGAIA GENLCOKMKFL(this MonoBehaviour EOBJGBKPDGF, float CCMOFMGPDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x74FCC30", Offset = "0x74FB630", VA = "0x1874FCC30")]
	public static DABMKCAGAIA CNMOEEKHNFA(this MonoBehaviour EOBJGBKPDGF, float CCMOFMGPDOB, BFMEILOFOGD FDGDJNFBJAH, Action MIDOKEPAEFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x74FCE00", Offset = "0x74FB800", VA = "0x1874FCE00")]
	public static DABMKCAGAIA DFBIJKEFKDC(this MonoBehaviour EOBJGBKPDGF, Action MIDOKEPAEFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x74FD420", Offset = "0x74FBE20", VA = "0x1874FD420")]
	public static DABMKCAGAIA MFODBGIEJCE(this MonoBehaviour EOBJGBKPDGF, Action MIDOKEPAEFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x74FD1B0", Offset = "0x74FBBB0", VA = "0x1874FD1B0")]
	public static DABMKCAGAIA IAKKFNKDHEN(this MonoBehaviour EOBJGBKPDGF, Action MIDOKEPAEFF, [Optional] ODNBBNNHMNO MFPPIELLFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x74FD110", Offset = "0x74FBB10", VA = "0x1874FD110")]
	public static DABMKCAGAIA GHCLEONFJOM(this MonoBehaviour EOBJGBKPDGF, Action MIDOKEPAEFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x74FD560", Offset = "0x74FBF60", VA = "0x1874FD560")]
	public static DABMKCAGAIA OMOFECIOMFM(this MonoBehaviour EOBJGBKPDGF, Action MIDOKEPAEFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x74FCFE0", Offset = "0x74FB9E0", VA = "0x1874FCFE0")]
	private static DABMKCAGAIA GDBFIEMJNPB(MonoBehaviour EOBJGBKPDGF, BFMEILOFOGD CEODDBLCABL, Action MIDOKEPAEFF, [Optional] ODNBBNNHMNO MFPPIELLFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x74FD250", Offset = "0x74FBC50", VA = "0x1874FD250")]
	public static DABMKCAGAIA IBGHKJELEMM(this MonoBehaviour EOBJGBKPDGF, float PBJFOOJAKJB, Action MIDOKEPAEFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x74FD380", Offset = "0x74FBD80", VA = "0x1874FD380")]
	public static DABMKCAGAIA JGKLIFLLDHI(this MonoBehaviour EOBJGBKPDGF, float PBJFOOJAKJB, Action MIDOKEPAEFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x74FD4C0", Offset = "0x74FBEC0", VA = "0x1874FD4C0")]
	public static DABMKCAGAIA MMBKDHLBBEO(this MonoBehaviour EOBJGBKPDGF, float PBJFOOJAKJB, Action MIDOKEPAEFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x74FCEA0", Offset = "0x74FB8A0", VA = "0x1874FCEA0")]
	public static DABMKCAGAIA DHHLCLBHEMP(this MonoBehaviour EOBJGBKPDGF, float PBJFOOJAKJB, Action MIDOKEPAEFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class KOIFBMLHGEL : CNCGMILALCP, IEnumerable<CNCGMILALCP>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly List<CNCGMILALCP> IHKIGACOBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool MNMOBEBABBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Action CMHMBOBBFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool NHFODPMBMAI;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GILGLEFFPJO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x74FB320", Offset = "0x74F9D20", VA = "0x1874FB320", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AHEDMGALHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x74FB910", Offset = "0x74FA310", VA = "0x1874FB910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x74FBB00", Offset = "0x74FA500", VA = "0x1874FBB00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x74FBBA0", Offset = "0x74FA5A0", VA = "0x1874FBBA0")]
	public KOIFBMLHGEL([Optional] Action CMHMBOBBFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x74FB450", Offset = "0x74F9E50", VA = "0x1874FB450")]
	public void EGHPKMGPEOO(CNCGMILALCP DECNBNNMNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x74FB9B0", Offset = "0x74FA3B0", VA = "0x1874FB9B0")]
	private void LIAODCFOCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x74FB900", Offset = "0x74FA300", VA = "0x1874FB900", Slot = "7")]
	public bool HCJOPMMFELJ(bool MOFNDFHCJJC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x74FB600", Offset = "0x74FA000", VA = "0x1874FB600", Slot = "8")]
	public bool HCJOPMMFELJ(Action ENNGIICFMFD, bool MOFNDFHCJJC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x74FB580", Offset = "0x74F9F80", VA = "0x1874FB580", Slot = "9")]
	public IEnumerator<CNCGMILALCP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x74FB580", Offset = "0x74F9F80", VA = "0x1874FB580", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PKHGOAJILJI : OJHPJDACPNI
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class PCBALHFNCPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public PKHGOAJILJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public PCBALHFNCPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x74FA680", Offset = "0x74F9080", VA = "0x1874FA680")]
		internal void JFFFDEJDPJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class JLNFENNADHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public PKHGOAJILJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public JLNFENNADHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x74FA680", Offset = "0x74F9080", VA = "0x1874FA680")]
		internal void AEKDCBHGKCE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly float OHOKOAJBCDI;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x74FB1E0", Offset = "0x74F9BE0", VA = "0x1874FB1E0")]
	public PKHGOAJILJI(Behaviour GJGBLLHIOAC, float OHOKOAJBCDI, [Optional] Action CMHMBOBBFBA, [Optional] ODNBBNNHMNO MFPPIELLFAG, [Optional] ELFIGCGNHMA CLCFEDDKKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x75077C0", Offset = "0x75061C0", VA = "0x1875077C0", Slot = "9")]
	protected override bool GEAKNCNLKBG(Action ENNGIICFMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x75078D0", Offset = "0x75062D0", VA = "0x1875078D0", Slot = "10")]
	protected override bool KBJCPOHACIJ(Action ENNGIICFMFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface CNCGMILALCP
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool GILGLEFFPJO
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action AHEDMGALHID;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HCJOPMMFELJ(bool MOFNDFHCJJC = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HCJOPMMFELJ(Action ENNGIICFMFD, bool MOFNDFHCJJC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class OJHPJDACPNI : CNCGMILALCP
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class DDDJJMPEEDD : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public OJHPJDACPNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public DDDJJMPEEDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x74F7330", Offset = "0x74F5D30", VA = "0x1874F7330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x74F7400", Offset = "0x74F5E00", VA = "0x1874F7400", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Behaviour GJGBLLHIOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action CMHMBOBBFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private EOKLDMPJAPL HNLOJPHDHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly ODNBBNNHMNO MFPPIELLFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	protected readonly ELFIGCGNHMA CLCFEDDKKMA;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool GILGLEFFPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x103CA40", Offset = "0x103B440", VA = "0x18103CA40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action AHEDMGALHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7506550", Offset = "0x7504F50", VA = "0x187506550", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x75065F0", Offset = "0x7504FF0", VA = "0x1875065F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7506690", Offset = "0x7505090", VA = "0x187506690")]
	protected OJHPJDACPNI(Behaviour GJGBLLHIOAC, [Optional] Action CMHMBOBBFBA, [Optional] ODNBBNNHMNO MFPPIELLFAG, [Optional] ELFIGCGNHMA CLCFEDDKKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7506490", Offset = "0x7504E90", VA = "0x187506490", Slot = "7")]
	public bool HCJOPMMFELJ(bool MOFNDFHCJJC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x75064F0", Offset = "0x7504EF0", VA = "0x1875064F0", Slot = "8")]
	public bool HCJOPMMFELJ(Action ENNGIICFMFD, bool MOFNDFHCJJC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool GEAKNCNLKBG(Action ENNGIICFMFD);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool KBJCPOHACIJ(Action ENNGIICFMFD);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x75063F0", Offset = "0x7504DF0", VA = "0x1875063F0")]
	protected void DNCHEAEAFEL(Action ENNGIICFMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7506170", Offset = "0x7504B70", VA = "0x187506170")]
	protected MFAPHLCBHHA CKBFLLEDOBF(float PCILJOIJLLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7506410", Offset = "0x7504E10", VA = "0x187506410")]
	private void FFCDDLODCAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x75060E0", Offset = "0x7504AE0", VA = "0x1875060E0")]
	[IteratorStateMachine(typeof(DDDJJMPEEDD))]
	private IEnumerator<IHLHBLBKNMF> BJFHKCMIFDL(float PCILJOIJLLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x75063B0", Offset = "0x7504DB0", VA = "0x1875063B0")]
	[CompilerGenerated]
	private void DGJLLFGIGJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class GAEOHGABGOP : OJHPJDACPNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float PBBEKJDCHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int MCDBODPGMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float OGKAFJIMJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float[] EIHMBCBBLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int AMADEHBACNB;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x74F9010", Offset = "0x74F7A10", VA = "0x1874F9010")]
	public GAEOHGABGOP(Behaviour GJGBLLHIOAC, float PGAEMIGHONE, int MCDBODPGMKB, [Optional] Action CMHMBOBBFBA, float OGKAFJIMJKL = 0f, [Optional] ODNBBNNHMNO MFPPIELLFAG, [Optional] ELFIGCGNHMA CLCFEDDKKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "9")]
	protected override bool GEAKNCNLKBG(Action ENNGIICFMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x74F8E10", Offset = "0x74F7810", VA = "0x1874F8E10", Slot = "10")]
	protected override bool KBJCPOHACIJ(Action ENNGIICFMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x74F8D90", Offset = "0x74F7790", VA = "0x1874F8D90")]
	private void ENEKJNDFDOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class KECLKAIPILH : OJHPJDACPNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float OHOKOAJBCDI;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x74FB1E0", Offset = "0x74F9BE0", VA = "0x1874FB1E0")]
	public KECLKAIPILH(Behaviour GJGBLLHIOAC, float OHOKOAJBCDI, [Optional] Action CMHMBOBBFBA, [Optional] ODNBBNNHMNO MFPPIELLFAG, [Optional] ELFIGCGNHMA CLCFEDDKKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "9")]
	protected override bool GEAKNCNLKBG(Action ENNGIICFMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x74FB1A0", Offset = "0x74F9BA0", VA = "0x1874FB1A0", Slot = "10")]
	protected override bool KBJCPOHACIJ(Action ENNGIICFMFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class NMEEIKCBHDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IPIDKDNOGLH : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public IPIDKDNOGLH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x74FA050", Offset = "0x74F8A50", VA = "0x1874FA050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x74FA0C0", Offset = "0x74F8AC0", VA = "0x1874FA0C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private DABMKCAGAIA MEHABPKOMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private KFMPKLNJPKH GJGBLLHIOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Action<float> CANABIEBIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private BFMEILOFOGD CEODDBLCABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private float ECFKAKHMMHP;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x75052A0", Offset = "0x7503CA0", VA = "0x1875052A0")]
	public NMEEIKCBHDN(KFMPKLNJPKH GJGBLLHIOAC, float IONMCPNCJEO, Action<float> BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7504E00", Offset = "0x7503800", VA = "0x187504E00")]
	private void GAMHABMJHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7504F70", Offset = "0x7503970", VA = "0x187504F70")]
	private void IPHNAKHOOPG(string DMBOCOKFCJF, Action DFDKCGBKKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7505220", Offset = "0x7503C20", VA = "0x187505220")]
	[IteratorStateMachine(typeof(IPIDKDNOGLH))]
	private IEnumerator<IHLHBLBKNMF> NFMIEFDMPNP(Action DFDKCGBKKDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7504DA0", Offset = "0x75037A0", VA = "0x187504DA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x75050A0", Offset = "0x7503AA0", VA = "0x1875050A0")]
	[CompilerGenerated]
	private void JBKLJEJEDIH(string DCGMDLPABHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class BDEJHGJEELO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class PDNCHBOHNMP : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public PDNCHBOHNMP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x74FA050", Offset = "0x74F8A50", VA = "0x1874FA050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x75072A0", Offset = "0x7505CA0", VA = "0x1875072A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private DABMKCAGAIA MEHABPKOMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private MonoBehaviour EOBJGBKPDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action BLCAHGBMEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Action<float> CANABIEBIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private BFMEILOFOGD CEODDBLCABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float ECFKAKHMMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private bool JHFPJGEBAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly ODNBBNNHMNO MFPPIELLFAG;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x74EF000", Offset = "0x74EDA00", VA = "0x1874EF000")]
	public BDEJHGJEELO(MonoBehaviour EOBJGBKPDGF, Action BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL, [Optional] ODNBBNNHMNO MFPPIELLFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x74EEC50", Offset = "0x74ED650", VA = "0x1874EEC50")]
	public BDEJHGJEELO(MonoBehaviour EOBJGBKPDGF, Action<float> BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL, [Optional] ODNBBNNHMNO MFPPIELLFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x74EEE20", Offset = "0x74ED820", VA = "0x1874EEE20")]
	public BDEJHGJEELO(MonoBehaviour EOBJGBKPDGF, float IONMCPNCJEO, Action<float> BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL, bool JHFPJGEBAJG = true, [Optional] ODNBBNNHMNO MFPPIELLFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3F25E70", Offset = "0x3F24870", VA = "0x183F25E70")]
	private BDEJHGJEELO(ODNBBNNHMNO MFPPIELLFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x74EEA20", Offset = "0x74ED420", VA = "0x1874EEA20")]
	internal static BDEJHGJEELO PHGOKCLHAJL(MonoBehaviour EOBJGBKPDGF, float IONMCPNCJEO, Action<float> BLCAHGBMEEE, BFMEILOFOGD CEODDBLCABL, bool JHFPJGEBAJG = true, [Optional] ODNBBNNHMNO MFPPIELLFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x74EE020", Offset = "0x74ECA20", VA = "0x1874EE020")]
	private void BAGGDNOMPFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x74EE8A0", Offset = "0x74ED2A0", VA = "0x1874EE8A0")]
	private void OCOHKOEGAMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x74EE2D0", Offset = "0x74ECCD0", VA = "0x1874EE2D0")]
	private void GAMHABMJHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x74EE690", Offset = "0x74ED090", VA = "0x1874EE690")]
	private void MFNLGCNJICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x74EE560", Offset = "0x74ECF60", VA = "0x1874EE560")]
	private void IPHNAKHOOPG(string DMBOCOKFCJF, Action DFDKCGBKKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x74EE820", Offset = "0x74ED220", VA = "0x1874EE820")]
	[IteratorStateMachine(typeof(PDNCHBOHNMP))]
	private IEnumerator<IHLHBLBKNMF> NFMIEFDMPNP(Action DFDKCGBKKDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x74EE1E0", Offset = "0x74ECBE0", VA = "0x1874EE1E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x74EE150", Offset = "0x74ECB50", VA = "0x1874EE150")]
	[CompilerGenerated]
	private void DOEBLNIDIAL(string DCGMDLPABHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x74EE440", Offset = "0x74ECE40", VA = "0x1874EE440")]
	[CompilerGenerated]
	private void HIELDIGHFPH(string DCGMDLPABHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x74EE240", Offset = "0x74ECC40", VA = "0x1874EE240")]
	[CompilerGenerated]
	private void EAMCEDGFKCG(string DCGMDLPABHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x74EE4D0", Offset = "0x74ECED0", VA = "0x1874EE4D0")]
	[CompilerGenerated]
	private void HIPOAIBIHKL(string DCGMDLPABHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum EDIEHOPNCFE : byte
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
internal sealed class CJGAAMBLJEM : ELFIGCGNHMA
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float OFBIGCCMOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x74F13B0", Offset = "0x74EFDB0", VA = "0x1874F13B0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float KBNLMHFLJEB
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x74F1310", Offset = "0x74EFD10", VA = "0x1874F1310", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public double LPGOPCEMIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x74F1320", Offset = "0x74EFD20", VA = "0x1874F1320", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x74F1340", Offset = "0x74EFD40", VA = "0x1874F1340")]
	[POCMGODEOKB.GGOFPJDKHFE]
	internal static void JIHNHODNBNJ(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	[UnityEngine.Scripting.Preserve]
	internal CJGAAMBLJEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface HMLGFFKJJMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PONBEJKJJFG(string HBOONHFLONJ);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLAFAHPLKEN();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface OHKPKNCCKMF
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string IAIAEPAKLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool LKCOBPNALCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool FOLNLIGIDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class ANFJPCCILFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public MJIKAFNHHNO PHLKGCBJPGB;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int MOMFAOPBBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x88E020", Offset = "0x88CA20", VA = "0x18088E020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x74ECF00", Offset = "0x74EB900", VA = "0x1874ECF00")]
	public static IHLHBLBKNMF JIKHGLKGJIB(IEnumerator<IHLHBLBKNMF> MFLBBMPBHOH, BOJFNBKOLGF ICGLPDPDDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x74ECE40", Offset = "0x74EB840", VA = "0x1874ECE40")]
	public IHLHBLBKNMF JIKHGLKGJIB(BOJFNBKOLGF[] PANCCNBCIGO, IEnumerator<IHLHBLBKNMF>[] AFCANLJBNKA, IHLHBLBKNMF[] BMHHONLIKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x74ECCD0", Offset = "0x74EB6D0", VA = "0x1874ECCD0")]
	public void GCNAENAOPMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x74ECD00", Offset = "0x74EB700", VA = "0x1874ECD00")]
	public void HMNEJKGEFFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x74ECB90", Offset = "0x74EB590", VA = "0x1874ECB90")]
	public void CMMKPDCHCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x74ECCD0", Offset = "0x74EB6D0", VA = "0x1874ECCD0")]
	public void KPDILAAFEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public ANFJPCCILFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class MJIKAFNHHNO
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct KLLLOKEIADM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public ANFJPCCILFL FHNMMNFAIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public KFMPKLNJPKH EFOALAMNFGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public BOJFNBKOLGF EIBMDIEMJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public IEnumerator<IHLHBLBKNMF> FBBMPNMJKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public IHLHBLBKNMF EIOBPOLFHID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public EDIEHOPNCFE AGHHPHCOEID;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct GJCDDJKLFNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public BFMEILOFOGD CPNIAHENDPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public List<KLLLOKEIADM> DPEHOBJMHOC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class LCEOAEHOFDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public BOJFNBKOLGF promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public MJIKAFNHHNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public KFMPKLNJPKH context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public ANFJPCCILFL routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public EDIEHOPNCFE coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IHLHBLBKNMF currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public IEnumerator<IHLHBLBKNMF> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public LCEOAEHOFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x74FC2F0", Offset = "0x74FACF0", VA = "0x1874FC2F0")]
		internal void GJDLACKIFGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class BPBIKLPKLHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public ANFJPCCILFL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public MJIKAFNHHNO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public BPBIKLPKLHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x74EF920", Offset = "0x74EE320", VA = "0x1874EF920")]
		internal void IGKOIKEALGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class LGLFLOPGNJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public ANFJPCCILFL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public MJIKAFNHHNO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public LGLFLOPGNJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x74FCAB0", Offset = "0x74FB4B0", VA = "0x1874FCAB0")]
		internal void IDMLGLBNCKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class EPOEODFNCKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public ANFJPCCILFL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public MJIKAFNHHNO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public EPOEODFNCKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x74F8A40", Offset = "0x74F7440", VA = "0x1874F8A40")]
		internal void ELMMCJKMPJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private const EDIEHOPNCFE PEMBCGHEJNF = EDIEHOPNCFE.Cancelled | EDIEHOPNCFE.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly BFMEILOFOGD CEODDBLCABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool[] GJDKOCBHNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<EDIEHOPNCFE> PFNCAFHDNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<float> BAHOBACDPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> IBEKBMHMLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> BNNEKEFPOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> PLOMNKLHLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> EJMDGKHHLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> GNIJNLBJCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private ANFJPCCILFL[] AJEFDMFCEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private BOJFNBKOLGF[] PANCCNBCIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private KFMPKLNJPKH[] PPFMGNGKGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IEnumerator<IHLHBLBKNMF>[] GHOIBMOCGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private IHLHBLBKNMF[] EEGGDJAMLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int PAFCCPCOCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int HBMOJAPOCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly int GPFHCNENELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float BNCGPLLPINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private CABDPEDEFBP ICJMPPLGDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private JobHandle OBDLGCHBPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<ANFJPCCILFL> NFHANABPIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool OADBLIIGFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> OHNPKBGBDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<Action> NJHAGJFIMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool EAKAIPNKFLC;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GJCDDJKLFNC[] EKOBEAGGIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8DF610", Offset = "0x8DE010", VA = "0x1808DF610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7502E00", Offset = "0x7501800", VA = "0x187502E00")]
	private static int IFNCOOICLIC(BFMEILOFOGD CEODDBLCABL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x75044A0", Offset = "0x7502EA0", VA = "0x1875044A0")]
	public MJIKAFNHHNO(BFMEILOFOGD CEODDBLCABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7502150", Offset = "0x7500B50", VA = "0x187502150")]
	private void BFHFEBOMACO(int BFMNGHLCFGF, int NDEPEFEHKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7503EE0", Offset = "0x75028E0", VA = "0x187503EE0")]
	public void MOKAGMKHCFO(KFMPKLNJPKH GJGBLLHIOAC, IHLHBLBKNMF GLMPNIBBBCE, IEnumerator<IHLHBLBKNMF> MFLBBMPBHOH, BOJFNBKOLGF ICGLPDPDDBB, [Optional] ANFJPCCILFL ICIGIHBPHJK, EDIEHOPNCFE HGDFBHGNFIF = EDIEHOPNCFE.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7504260", Offset = "0x7502C60", VA = "0x187504260")]
	public void PBIBDHLCBJE(IEnumerable<KLLLOKEIADM> LDOKLJPMDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7502930", Offset = "0x7501330", VA = "0x187502930")]
	private KLLLOKEIADM GPOJPAFOPPI(int DAEJHEAMCDI)
	{
		return default(KLLLOKEIADM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7503400", Offset = "0x7501E00", VA = "0x187503400")]
	private void LGJHMBJLAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2D66300", Offset = "0x2D64D00", VA = "0x182D66300")]
	private static void GPDOGDNHNPK<T>(int DAEJHEAMCDI, T[] EDNBMDLJOBG, int MPLHLKNKHIM, [Optional] T FPGNOAKJBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2D66350", Offset = "0x2D64D50", VA = "0x182D66350")]
	private static void GPDOGDNHNPK<T>(int DAEJHEAMCDI, NativeArray<T> EDNBMDLJOBG, int MPLHLKNKHIM, [Optional] T FPGNOAKJBMO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7502590", Offset = "0x7500F90", VA = "0x187502590")]
	private void CBMPHMEEGNN(IEnumerable<KLLLOKEIADM> LDOKLJPMDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7502E30", Offset = "0x7501830", VA = "0x187502E30")]
	private void KBBEGPOPJHF(KLLLOKEIADM HEPPDLAFNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7502330", Offset = "0x7500D30", VA = "0x187502330")]
	private EBFBFCOGBJJ CBHJGINCCMI(int KOOEBGCMMFF)
	{
		return default(EBFBFCOGBJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7504060", Offset = "0x7502A60", VA = "0x187504060")]
	public void OKMNCLFIPKK(float LAHCFAEJOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7503150", Offset = "0x7501B50", VA = "0x187503150")]
	private void KMGLOGDHPAI(Action GPKBBMJKBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7503770", Offset = "0x7502170", VA = "0x187503770")]
	private void LNBAKMKCCEA(Action GPKBBMJKBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x75037F0", Offset = "0x75021F0", VA = "0x1875037F0")]
	public void MKPHLAIFLNO(float LAHCFAEJOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7503300", Offset = "0x7501D00", VA = "0x187503300")]
	public void LCECLFEFOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x75031D0", Offset = "0x7501BD0", VA = "0x1875031D0")]
	public void KPDILAAFEKD(ANFJPCCILFL NAKKLMDMDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7502EF0", Offset = "0x75018F0", VA = "0x187502EF0")]
	public void KDNOPLDEGLB(ANFJPCCILFL NAKKLMDMDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7503020", Offset = "0x7501A20", VA = "0x187503020")]
	public void KEDDBIKDOND(ANFJPCCILFL NAKKLMDMDCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class JDOEBPNEHII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly JDOEBPNEHII MANEDJLMOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly Action EHDJACLPKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private bool PJOLCHEBHAJ;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	public JDOEBPNEHII(Action EHDJACLPKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C7ABB0", Offset = "0x6C795B0", VA = "0x186C7ABB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface JLIEOEHJPIB<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T GJBIHCLEEHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable GODCODAGJKK(UnityEngine.Object GJGBLLHIOAC, Action<T> PJNCGPJLEJE);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface EOBEGLAEKCO<T> : JLIEOEHJPIB<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	new T GJBIHCLEEHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class DFHEMDOACDF<T> : EOBEGLAEKCO<T>, JLIEOEHJPIB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class ICNADGKCENB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public DFHEMDOACDF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public PBBHKEHOECG<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public ICNADGKCENB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3F98680", Offset = "0x3F97080", VA = "0x183F98680")]
		internal void LBLDONOELDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static GameObject CHPHJBHMIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly List<PBBHKEHOECG<UnityEngine.Object, Action<T>>> NGIKBEPKNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private T KDMALIGKHEJ;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public T GJBIHCLEEHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9ECD20", Offset = "0x9EB720", VA = "0x1809ECD20", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F410", Offset = "0x5A5DE10", VA = "0x185A5F410", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5A5F5B0", Offset = "0x5A5DFB0", VA = "0x185A5F5B0")]
	private static bool PIKCMBDFJPI(T GPKBBMJKBAE, T AAMOGMLMOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5A5F680", Offset = "0x5A5E080", VA = "0x185A5F680")]
	public DFHEMDOACDF(T NOOJOCEJDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5A5EBB0", Offset = "0x5A5D5B0", VA = "0x185A5EBB0", Slot = "6")]
	public IDisposable GODCODAGJKK(UnityEngine.Object GJGBLLHIOAC, Action<T> PJNCGPJLEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5A5ED70", Offset = "0x5A5D770", VA = "0x185A5ED70")]
	private void IIJFJBHNALE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class ONCIGDCFBFA : EJLANOIIGIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly ODNBBNNHMNO MFPPIELLFAG;

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7506CC0", Offset = "0x75056C0", VA = "0x187506CC0")]
	[POCMGODEOKB.GGOFPJDKHFE]
	internal static void ILMACKEOOAI(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	[UnityEngine.Scripting.Preserve]
	internal ONCIGDCFBFA([CNNDHKODGDP(null)] ODNBBNNHMNO MFPPIELLFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7506C10", Offset = "0x7505610", VA = "0x187506C10", Slot = "4")]
	public IDisposable FADICOBMLEN(float IONMCPNCJEO, Action<float> DKOPNCNMOIF, bool JHFPJGEBAJG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class LKIIJMPMNFD : CAABPHEONNB, ODNBBNNHMNO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private MJIKAFNHHNO[] DGPMKIKAHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private HMLGFFKJJMJ CJNEHBPGFBJ;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x74FE500", Offset = "0x74FCF00", VA = "0x1874FE500")]
	[POCMGODEOKB.GGOFPJDKHFE]
	internal static void JIHNHODNBNJ(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x74FE570", Offset = "0x74FCF70", VA = "0x1874FE570")]
	[UnityEngine.Scripting.Preserve]
	public LKIIJMPMNFD([CNNDHKODGDP(null)] GNLKEEMGHGG GKBMKNABNFF, [CNNDHKODGDP(null)] ELFIGCGNHMA CLCFEDDKKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x74FD980", Offset = "0x74FC380", VA = "0x1874FD980", Slot = "18")]
	public override DABMKCAGAIA AIIOIHKGKCJ(KFMPKLNJPKH GJGBLLHIOAC, IEnumerator<IHLHBLBKNMF> EIAKABIECGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x74FDAB0", Offset = "0x74FC4B0", VA = "0x1874FDAB0", Slot = "19")]
	public override void CGBFLDMMJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x74FDEB0", Offset = "0x74FC8B0", VA = "0x1874FDEB0", Slot = "21")]
	public override void DHONAAGIMPN(BFMEILOFOGD CEODDBLCABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x74FDD40", Offset = "0x74FC740", VA = "0x1874FDD40", Slot = "20")]
	protected override void DBMELBLEALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x74FD950", Offset = "0x74FC350", VA = "0x1874FD950")]
	private MJIKAFNHHNO AAANGKCHNCD(BFMEILOFOGD NNCMOPPBEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x74FE1C0", Offset = "0x74FCBC0", VA = "0x1874FE1C0", Slot = "22")]
	internal override MIEOAHNEKFE IBFPGHOLIEO(IEnumerator<IHLHBLBKNMF> EIAKABIECGJ, Behaviour GJGBLLHIOAC, BOJFNBKOLGF ICGLPDPDDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x74FE140", Offset = "0x74FCB40", VA = "0x1874FE140", Slot = "23")]
	internal override MENJLEAFBEM GEILGKJKMJO(BFMEILOFOGD FDGDJNFBJAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x74FE3E0", Offset = "0x74FCDE0", VA = "0x1874FE3E0")]
	private void JECKIIBKEEI(MJIKAFNHHNO FFIEPBMMDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x74FE0E0", Offset = "0x74FCAE0", VA = "0x1874FE0E0", Slot = "24")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct CABDPEDEFBP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public float IHIOFJMGOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	public int BOMOFLLNHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> CJJKKOBBKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> FOBKIKIKION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NativeArray<int> BGLGHIALLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<EDIEHOPNCFE> GJPBCJFIGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	public NativeArray<float> OOFMCJDIMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> PLOMNKLHLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[WriteOnly]
	public NativeArray<int> IBEKBMHMLCF;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x74F0F00", Offset = "0x74EF900", VA = "0x1874F0F00")]
	public static CABDPEDEFBP IFAFEFDLIPC(int PBGFBGJIHFK, float LAHCFAEJOJB, NativeArray<EDIEHOPNCFE> EGGFAKKIJLL, NativeArray<float> IOCACMCLDBG, NativeArray<int> ALGLIAOLIME, NativeArray<int> FEFFDMPGGAA, NativeArray<int> PPPIMNHLPMK, NativeArray<int> FOBKIKIKION, NativeArray<int> BGLGHIALLCA)
	{
		return default(CABDPEDEFBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x74F0DF0", Offset = "0x74EF7F0", VA = "0x1874F0DF0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x74F0DB0", Offset = "0x74EF7B0", VA = "0x1874F0DB0")]
	private bool BFFDNNNKGBC(int EBDDHAPIAHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x74F0ED0", Offset = "0x74EF8D0", VA = "0x1874F0ED0")]
	private void HAFLEDMLHLJ(NativeArray<int> MKJFHCKPCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x74F0F60", Offset = "0x74EF960", VA = "0x1874F0F60")]
	private int KHKBEIOPJLL(int MIOFHPBEEBA, int FIEPJMJAABH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x74F1000", Offset = "0x74EFA00", VA = "0x1874F1000")]
	private void LHLOHJCHGIB(NativeArray<int> MKJFHCKPCFP, int OCCLLFMDOKL, int FJIOIPCNGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x74F10D0", Offset = "0x74EFAD0", VA = "0x1874F10D0")]
	private void NLAEHMIKMGH(NativeArray<int> MKJFHCKPCFP, int LJJEIEDCNOO, int AJGAAOAODEI, int EGCKBDEGMBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class CAABPHEONNB : ODNBBNNHMNO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly GNLKEEMGHGG GKBMKNABNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected readonly ELFIGCGNHMA CLCFEDDKKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private MENJLEAFBEM[] ALFKAHMBMOH;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static ODNBBNNHMNO LPENGNKGBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x74F0010", Offset = "0x74EEA10", VA = "0x1874F0010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static bool PAJCHKNMDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public BFMEILOFOGD KAHLIMEHFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BFMEILOFOGD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x88E020", Offset = "0x88CA20", VA = "0x18088E020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ELFIGCGNHMA JPMCMJDKPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IHLHBLBKNMF FMOEHJPLHPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IHLHBLBKNMF LEFDBGKGHMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8869B0", Offset = "0x8853B0", VA = "0x1808869B0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IHLHBLBKNMF GDBJKBJGBFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x88C8B0", Offset = "0x88B2B0", VA = "0x18088C8B0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x74F0510", Offset = "0x74EEF10", VA = "0x1874F0510")]
	public static DABMKCAGAIA IEPFFJFIAFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x74F08C0", Offset = "0x74EF2C0", VA = "0x1874F08C0")]
	[UnityEngine.Scripting.Preserve]
	protected CAABPHEONNB([CNNDHKODGDP(null)] GNLKEEMGHGG GKBMKNABNFF, [CNNDHKODGDP(null)] ELFIGCGNHMA CLCFEDDKKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x74F05A0", Offset = "0x74EEFA0", VA = "0x1874F05A0", Slot = "6")]
	public DABMKCAGAIA IIGKFMPFNHH(IEnumerator<IHLHBLBKNMF> EIAKABIECGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x74F05B0", Offset = "0x74EEFB0", VA = "0x1874F05B0", Slot = "7")]
	public DABMKCAGAIA IIGKFMPFNHH(Behaviour GJGBLLHIOAC, IEnumerator<IHLHBLBKNMF> EIAKABIECGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract DABMKCAGAIA AIIOIHKGKCJ(KFMPKLNJPKH GJGBLLHIOAC, IEnumerator<IHLHBLBKNMF> EIAKABIECGJ);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x74EF9E0", Offset = "0x74EE3E0", VA = "0x1874EF9E0", Slot = "19")]
	public virtual void CGBFLDMMJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x74F0080", Offset = "0x74EEA80", VA = "0x1874F0080", Slot = "9")]
	public void GGKNLMEDNAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x74EFB80", Offset = "0x74EE580", VA = "0x1874EFB80", Slot = "20")]
	protected virtual void DBMELBLEALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x74EF9C0", Offset = "0x74EE3C0", VA = "0x1874EF9C0")]
	private void CBGDCLLAPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x74F0320", Offset = "0x74EED20", VA = "0x1874F0320")]
	private void HJKCFCOEIAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x74F0840", Offset = "0x74EF240", VA = "0x1874F0840")]
	private void JFBBDMFFMMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x74F0860", Offset = "0x74EF260", VA = "0x1874F0860")]
	private void NFAEOFAFOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x74EFC30", Offset = "0x74EE630", VA = "0x1874EFC30")]
	private void DIABJBHMFJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x74F08A0", Offset = "0x74EF2A0", VA = "0x1874F08A0")]
	private void POGEBBBGCEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x74F0880", Offset = "0x74EF280", VA = "0x1874F0880")]
	private void PAPCKDHIIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x74EFBA0", Offset = "0x74EE5A0", VA = "0x1874EFBA0", Slot = "21")]
	public virtual void DHONAAGIMPN(BFMEILOFOGD CEODDBLCABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x74F0340", Offset = "0x74EED40", VA = "0x1874F0340")]
	private void HKFJBNIEPBE(MENJLEAFBEM FFIEPBMMDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEFA0", Offset = "0x1FAD9A0", VA = "0x181FAEFA0")]
	private MENJLEAFBEM JOBGGJIPBJN(BFMEILOFOGD NNCMOPPBEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract MIEOAHNEKFE IBFPGHOLIEO(IEnumerator<IHLHBLBKNMF> EIAKABIECGJ, Behaviour EOBJGBKPDGF, BOJFNBKOLGF ELLBFNHIPLB);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract MENJLEAFBEM GEILGKJKMJO(BFMEILOFOGD CEODDBLCABL);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x74EFC50", Offset = "0x74EE650", VA = "0x1874EFC50", Slot = "24")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x74F02C0", Offset = "0x74EECC0", VA = "0x1874F02C0", Slot = "14")]
	public IHLHBLBKNMF HDJCEIDCPEE(BFMEILOFOGD FDGDJNFBJAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x74F07B0", Offset = "0x74EF1B0", VA = "0x1874F07B0", Slot = "15")]
	public IHLHBLBKNMF IMKPIPPGMAG(float CCMOFMGPDOB, BFMEILOFOGD FDGDJNFBJAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x74EF960", Offset = "0x74EE360", VA = "0x1874EF960", Slot = "16")]
	public IHLHBLBKNMF CAOJOLCHEDA(Func<bool> PIIAKCKHONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class MIEOAHNEKFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly BOJFNBKOLGF ICGLPDPDDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly OHKPKNCCKMF GJGBLLHIOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool FMKDEPIHDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private string HBOONHFLONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private StackTrace AKCPKACDMGP;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<IHLHBLBKNMF> FBBMPNMJKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x882790", Offset = "0x881190", VA = "0x180882790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IHLHBLBKNMF EIOBPOLFHID
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x885AE0", Offset = "0x8844E0", VA = "0x180885AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool JJKAHPPDLKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7501DC0", Offset = "0x75007C0", VA = "0x187501DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool JBCPEOHICAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x921350", Offset = "0x91FD50", VA = "0x180921350")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x920D40", Offset = "0x91F740", VA = "0x180920D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string IAIAEPAKLMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7501C10", Offset = "0x7500610", VA = "0x187501C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float OACKIJGACML
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x9ECC90", Offset = "0x9EB690", VA = "0x1809ECC90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x612AD50", Offset = "0x6129750", VA = "0x18612AD50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7501F90", Offset = "0x7500990", VA = "0x187501F90")]
	public MIEOAHNEKFE(IEnumerator<IHLHBLBKNMF> MFLBBMPBHOH, OHKPKNCCKMF GJGBLLHIOAC, BOJFNBKOLGF ICGLPDPDDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x75018B0", Offset = "0x75002B0", VA = "0x1875018B0")]
	public IHLHBLBKNMF JIKHGLKGJIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7501E40", Offset = "0x7500840", VA = "0x187501E40")]
	public bool PKEGBNAOANG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7501BC0", Offset = "0x75005C0", VA = "0x187501BC0")]
	public void KPDILAAFEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7501EB0", Offset = "0x75008B0", VA = "0x187501EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xC11010", Offset = "0xC0FA10", VA = "0x180C11010")]
	[CompilerGenerated]
	private void KLAHHBEDJIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class BOJFNBKOLGF : HAEJEBPAKIA, DABMKCAGAIA, EOKLDMPJAPL, MFAPHLCBHHA, IEnumerator, IHLHBLBKNMF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private BFMEILOFOGD ECCEKHNKHAE;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private BFMEILOFOGD NNMPAMGJFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x929CA0", Offset = "0x9286A0", VA = "0x180929CA0", Slot = "23")]
		get
		{
			return default(BFMEILOFOGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public BFMEILOFOGD PHLKGCBJPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x92AA00", Offset = "0x929400", VA = "0x18092AA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float HOCOCEHIMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool IKJHOFPAGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x74EF8B0", Offset = "0x74EE2B0", VA = "0x1874EF8B0", Slot = "24")]
	private bool GAJAGDGNIFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x74EF8A0", Offset = "0x74EE2A0", VA = "0x1874EF8A0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x74EF8D0", Offset = "0x74EE2D0", VA = "0x1874EF8D0")]
	public BOJFNBKOLGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum EBFBFCOGBJJ : byte
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
internal sealed class MENJLEAFBEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum LKINLEENIAF
	{
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct GFCGGFNCJFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public BFMEILOFOGD CPNIAHENDPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public LKINLEENIAF DIOHLNHIGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public List<MIEOAHNEKFE> LJLOIDKBJHJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly LKINLEENIAF[] KNBEFMFIJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly BFMEILOFOGD CEODDBLCABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool PHBDLBKCGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly MIEOAHNEKFE[] DILGOJDDIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly List<MIEOAHNEKFE> HKEBPNKPONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<int> KIINEIADEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<MIEOAHNEKFE> AMJPAGGADEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<int> MOKHHBEFACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly HMLGFFKJJMJ JIEHPCGDEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private bool EAKAIPNKFLC;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public GFCGGFNCJFF[,] GFGKLPCPGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x88C8B0", Offset = "0x88B2B0", VA = "0x18088C8B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7500DC0", Offset = "0x74FF7C0", VA = "0x187500DC0")]
	public MENJLEAFBEM(BFMEILOFOGD FDGDJNFBJAH, HMLGFFKJJMJ JIEHPCGDEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7500310", Offset = "0x74FED10", VA = "0x187500310")]
	public void HFBBCODBCIH(MIEOAHNEKFE MFLBBMPBHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x75008A0", Offset = "0x74FF2A0", VA = "0x1875008A0")]
	public void OPNAAMLBIKN(IList<MIEOAHNEKFE> AFCANLJBNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7500010", Offset = "0x74FEA10", VA = "0x187500010")]
	public void GGPNKMMDJKN(IList<MIEOAHNEKFE> AFCANLJBNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7500BA0", Offset = "0x74FF5A0", VA = "0x187500BA0")]
	private void PCKBIGBLNOC(MIEOAHNEKFE MFLBBMPBHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x74FFC90", Offset = "0x74FE690", VA = "0x1874FFC90")]
	private void GEJHIBNIAGF(IList<MIEOAHNEKFE> AFCANLJBNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7500720", Offset = "0x74FF120", VA = "0x187500720")]
	private EBFBFCOGBJJ MKKPEIIHBHB(MIEOAHNEKFE MFLBBMPBHOH)
	{
		return default(EBFBFCOGBJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x74FF8C0", Offset = "0x74FE2C0", VA = "0x1874FF8C0")]
	public void DBMELBLEALE(float LAHCFAEJOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x74FFE20", Offset = "0x74FE820", VA = "0x1874FFE20")]
	public void GGKNLMEDNAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7500420", Offset = "0x74FEE20", VA = "0x187500420")]
	private void IAFGCMGCLLF(List<MIEOAHNEKFE> AFCANLJBNKA, Stack<int> EDCCCHAHFHG, bool ADOEGHJFBFI, float FJIAAJCEABD = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x74FFB70", Offset = "0x74FE570", VA = "0x1874FFB70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x74FFA30", Offset = "0x74FE430", VA = "0x1874FFA30")]
	private void DMCLBCHHAAF(List<MIEOAHNEKFE> AFCANLJBNKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class FAFBINJKDHN : HMLGFFKJJMJ
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
	public void PONBEJKJJFG(string HBOONHFLONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
	public void HLAFAHPLKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public FAFBINJKDHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class BOFMACIBHGI : OHKPKNCCKMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly Behaviour EOBJGBKPDGF;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string IAIAEPAKLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x74EF5D0", Offset = "0x74EDFD0", VA = "0x1874EF5D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool LKCOBPNALCI
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x74EF670", Offset = "0x74EE070", VA = "0x1874EF670", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool FOLNLIGIDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x74EF650", Offset = "0x74EE050", VA = "0x1874EF650", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	public BOFMACIBHGI(Behaviour EOBJGBKPDGF)
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

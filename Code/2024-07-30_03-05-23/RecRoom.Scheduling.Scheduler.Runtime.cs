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
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private delegate List<PlayerLoopSystem> KHBGJKPMGDM(List<PlayerLoopSystem> GFPJHAPFMHP, int JDJAELGFJDG);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct PMIKKBLCBDO
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct AMJECOMIANA
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static AOBPFOPEJNG APKLCIDLBEI;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x732EF40", Offset = "0x732D540", VA = "0x18732EF40")]
				public static PlayerLoopSystem KAFIGLIJAKJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct DNKGIMLEFMB
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static AOBPFOPEJNG PGMLNKHJICF;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x73348A0", Offset = "0x7332EA0", VA = "0x1873348A0")]
				public static PlayerLoopSystem KAFIGLIJAKJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct FJAJFMJAKFC
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static AOBPFOPEJNG ICOLBOBEPLB;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x7336F70", Offset = "0x7335570", VA = "0x187336F70")]
				public static PlayerLoopSystem KAFIGLIJAKJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct KGLOHGFJKFC
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static AOBPFOPEJNG ACDPNKCOEFL;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static AOBPFOPEJNG BKCOKANAHKO;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static AOBPFOPEJNG MPKGLEAHDLL;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static AOBPFOPEJNG BIOCKNCNNKO;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x733C940", Offset = "0x733AF40", VA = "0x18733C940")]
				public static PlayerLoopSystem KAFIGLIJAKJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct PFEOMFEDCJP
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static AOBPFOPEJNG CEFAPAOEJHI;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x7349750", Offset = "0x7347D50", VA = "0x187349750")]
				public static PlayerLoopSystem KAFIGLIJAKJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct HMPMFMEFKID
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static AOBPFOPEJNG ACDPNKCOEFL;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static AOBPFOPEJNG BKCOKANAHKO;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static AOBPFOPEJNG MPKGLEAHDLL;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static AOBPFOPEJNG BIOCKNCNNKO;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x7338560", Offset = "0x7336B60", VA = "0x187338560")]
				public static PlayerLoopSystem KAFIGLIJAKJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct PPCFEANNKJL
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static AOBPFOPEJNG MGEKOOCIJBF;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x7349C60", Offset = "0x7348260", VA = "0x187349C60")]
				public static PlayerLoopSystem KAFIGLIJAKJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct JHHLOEGGFFF
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static AOBPFOPEJNG AEBHAKGJKLM;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x733AC10", Offset = "0x7339210", VA = "0x18733AC10")]
				public static PlayerLoopSystem KAFIGLIJAKJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct HBHNANLFHPE
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static AOBPFOPEJNG JJIBIOMEKDM;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x7338360", Offset = "0x7336960", VA = "0x187338360")]
				public static PlayerLoopSystem KAFIGLIJAKJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct BDNOJPJEDHL
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static AOBPFOPEJNG KACDEHBOFJC;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x732F340", Offset = "0x732D940", VA = "0x18732F340")]
				public static PlayerLoopSystem KAFIGLIJAKJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct KMLJDEPCFND
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static AOBPFOPEJNG CJKEAFIAJDN;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x733F400", Offset = "0x733DA00", VA = "0x18733F400")]
				public static PlayerLoopSystem KAFIGLIJAKJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct BDEHCHDNKNI
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static AOBPFOPEJNG AFBJIEPALLI;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x732F140", Offset = "0x732D740", VA = "0x18732F140")]
				public static PlayerLoopSystem KAFIGLIJAKJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct OLDPGCONIAB
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static AOBPFOPEJNG PFLHBEGFLFP;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x7348130", Offset = "0x7346730", VA = "0x187348130")]
				public static PlayerLoopSystem KAFIGLIJAKJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public enum FELBLNKIIKF : byte
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
			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public struct PJAHEPAHAJC
			{
				[Cpp2IlInjected.Token(Token = "0x2000021")]
				[CompilerGenerated]
				private sealed class BIDJGONBKGB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public FELBLNKIIKF updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
					public BIDJGONBKGB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x732F540", Offset = "0x732DB40", VA = "0x18732F540")]
					internal void GDFHLJBFMAN()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static OIPILJJBCKA<FELBLNKIIKF> HMOIKKPIJLK;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x7349950", Offset = "0x7347F50", VA = "0x187349950")]
				public static PlayerLoopSystem KAFIGLIJAKJ(FELBLNKIIKF JCHFGNHNNJD)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			internal struct NELIOFIBJJI
			{
				[Cpp2IlInjected.Token(Token = "0x2000023")]
				[CompilerGenerated]
				private sealed class MAGHIAOLPFF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public MHDGBGKHLIA.IJLJMAKPIEK key;

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
					public MAGHIAOLPFF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x7342110", Offset = "0x7340710", VA = "0x187342110")]
					internal void HOCBCJCBJBB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable KPHHDCEKKAO;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x7344C70", Offset = "0x7343270", VA = "0x187344C70")]
				public static PlayerLoopSystem AHHONCEMBEI(MHDGBGKHLIA.IJLJMAKPIEK IBBDLGCDELM)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000025")]
			internal struct IPJAMGFGGIC
			{
				[Cpp2IlInjected.Token(Token = "0x2000026")]
				[CompilerGenerated]
				private sealed class BOPEGANMFOG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public MHDGBGKHLIA.IJLJMAKPIEK key;

					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
					public BOPEGANMFOG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x732FFB0", Offset = "0x732E5B0", VA = "0x18732FFB0")]
					internal void HOCBCJCBJBB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x733A770", Offset = "0x7338D70", VA = "0x18733A770")]
				public static PlayerLoopSystem AHHONCEMBEI(MHDGBGKHLIA.IJLJMAKPIEK IBBDLGCDELM)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class ECHLAAJCNIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public ECHLAAJCNIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x73356B0", Offset = "0x7333CB0", VA = "0x1873356B0")]
			internal List<PlayerLoopSystem> CAMBLODLKED(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool OKIKPILKBNP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool OCCEOCILMBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7334560", Offset = "0x7332B60", VA = "0x187334560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x73306F0", Offset = "0x732ECF0", VA = "0x1873306F0")]
		private static void AAEKJIIMOGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x73336B0", Offset = "0x7331CB0", VA = "0x1873336B0")]
		private static void FBJGLGMEGPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7333420", Offset = "0x7331A20", VA = "0x187333420")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7333460", Offset = "0x7331A60", VA = "0x187333460")]
		private static void DCEGOOPAHJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7333FC0", Offset = "0x73325C0", VA = "0x187333FC0")]
		private static void GHJDIGJGACP(MHDGBGKHLIA.IJLJMAKPIEK IBBDLGCDELM, PlayerLoopSystem PFJHODCELEC, Type IMNMHPHGOKF, Type CGIOIPLOPCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7334180", Offset = "0x7332780", VA = "0x187334180")]
		private static void JDPLAMBOJOP(PlayerLoopSystem PFJHODCELEC, Type IMNMHPHGOKF, Type CGIOIPLOPCC, KHBGJKPMGDM ACDFPEHNNLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x73332F0", Offset = "0x73318F0", VA = "0x1873332F0")]
		private static void ALLHBCGOJBD(PlayerLoopSystem PFJHODCELEC, Type IMNMHPHGOKF, Type CGIOIPLOPCC, PlayerLoopSystem? AJHDEMLHKJG, PlayerLoopSystem? PJPALPPBNBH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class MHDGBGKHLIA
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum IJLJMAKPIEK
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

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class MMBAILCGIAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly IJLJMAKPIEK MBODGMIHENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly JBLKJLMJIEJ APIGPBOGKGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private long JAAOMGONMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long DJMDJIFHKOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long LELEILLJCMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int EJKGJHKHDLJ;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7343E30", Offset = "0x7342430", VA = "0x187343E30")]
		public MMBAILCGIAH(IJLJMAKPIEK GBCAPKDCFGE, int FMEBDLJMAED = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7343D70", Offset = "0x7342370", VA = "0x187343D70")]
		public void IOFCMCEKIBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7343DE0", Offset = "0x73423E0", VA = "0x187343DE0")]
		public void OHPDDMNLCBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7343B90", Offset = "0x7342190", VA = "0x187343B90")]
		public void AEKMLGAFJJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static IJLJMAKPIEK[] DNIPDEKNADG;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static MMBAILCGIAH[] JAIDCFKIMBE;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7343600", Offset = "0x7341C00", VA = "0x187343600")]
	public static MMBAILCGIAH LMJPLHNJPON(IJLJMAKPIEK IBBDLGCDELM, int FMEBDLJMAED = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7343590", Offset = "0x7341B90", VA = "0x187343590")]
	public static MMBAILCGIAH ACLDPNIOOEP(IJLJMAKPIEK IBBDLGCDELM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x73437E0", Offset = "0x7341DE0", VA = "0x1873437E0")]
	public static void MBPPMJBNIJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class JBLKJLMJIEJ : KNLJPKMELCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int HALBPPLJLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Queue<double> KONCGJCEMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double KNJOHLDIOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double JEAHIMKCJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double BGHBHODFFBK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double JHNJGHCBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x733AA30", Offset = "0x7339030", VA = "0x18733AA30", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double HCEMCINHDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8A90", Offset = "0x1AB7090", VA = "0x181AB8A90", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double HNAPOCOPFEM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1F994F0", Offset = "0x1F97AF0", VA = "0x181F994F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x733AA90", Offset = "0x7339090", VA = "0x18733AA90")]
	public JBLKJLMJIEJ(int FLCFHJBCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x733A8A0", Offset = "0x7338EA0", VA = "0x18733A8A0", Slot = "7")]
	public void CFBGBMNDGON(double KPJDKHEOHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x733A9C0", Offset = "0x7338FC0", VA = "0x18733A9C0", Slot = "8")]
	public void LJOBMJGJKLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JPPHKBHOOOA : KNLJPKMELCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private long BMKFLHFENBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double BFAFHNIGODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double JCAIEIKFBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double BEPIPHLILBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double ADJDFEEFBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double KNJOHLDIOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double JEAHIMKCJFK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double HCEMCINHDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EBC0", Offset = "0x5F8D1C0", VA = "0x185F8EBC0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double HNAPOCOPFEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EBD0", Offset = "0x5F8D1D0", VA = "0x185F8EBD0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double EFAHLKIKEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EB80", Offset = "0x5F8D180", VA = "0x185F8EB80")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double JHNJGHCBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2590490", Offset = "0x258EA90", VA = "0x182590490", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x733C7B0", Offset = "0x733ADB0", VA = "0x18733C7B0", Slot = "7")]
	public virtual void CFBGBMNDGON(double KPJDKHEOHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x733C8D0", Offset = "0x733AED0", VA = "0x18733C8D0", Slot = "8")]
	public virtual void LJOBMJGJKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x733C910", Offset = "0x733AF10", VA = "0x18733C910")]
	public JPPHKBHOOOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class MLGOEOPMDHL : JPPHKBHOOOA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double MDKNEDCCKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EBA0", Offset = "0x5F8D1A0", VA = "0x185F8EBA0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5F8E700", Offset = "0x5F8CD00", VA = "0x185F8E700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7343A20", Offset = "0x7342020", VA = "0x187343A20", Slot = "7")]
	public override void CFBGBMNDGON(double KPJDKHEOHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7343B50", Offset = "0x7342150", VA = "0x187343B50", Slot = "8")]
	public override void LJOBMJGJKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x733C910", Offset = "0x733AF10", VA = "0x18733C910")]
	public MLGOEOPMDHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KNLJPKMELCC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double JHNJGHCBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double HCEMCINHDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double HNAPOCOPFEM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class NKPKDCELFJK
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private interface HDOGPLPCMIL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool EEOLGOJMLLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OBILMPBHNMC();
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private abstract class GIJDIFKBCAD<TPromise, TMainThreadPromise> : HDOGPLPCMIL where TPromise : GJFFIMHAENI where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly TPromise GJKGCMKPFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		protected readonly TMainThreadPromise NFOJLJFADLK;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise APMLIBFCNEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3D0DE00", Offset = "0x3D0C400", VA = "0x183D0DE00")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool EEOLGOJMLLK
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3D0DE60", Offset = "0x3D0C460", VA = "0x183D0DE60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x872E80", Offset = "0x871480", VA = "0x180872E80")]
		protected GIJDIFKBCAD(TPromise GJKGCMKPFGG, TMainThreadPromise ODCLMHBPDMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3D0DEB0", Offset = "0x3D0C4B0", VA = "0x183D0DEB0", Slot = "5")]
		public void OBILMPBHNMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void GICBHBDGKBN(TPromise GJKGCMKPFGG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class BCCKPBGPLDM<T> : GIJDIFKBCAD<FGBFKCLKPNC<T>, BHNOEEFMNHG<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0340", Offset = "0x4EBE940", VA = "0x184EC0340")]
		public BCCKPBGPLDM(FGBFKCLKPNC<T> GJKGCMKPFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4EC00B0", Offset = "0x4EBE6B0", VA = "0x184EC00B0", Slot = "6")]
		protected override void GICBHBDGKBN(FGBFKCLKPNC<T> GJKGCMKPFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3C3CA60", Offset = "0x3C3B060", VA = "0x183C3CA60")]
		[CompilerGenerated]
		private void IPGDLCEGLLM(T IAFCFGOKEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4EC02E0", Offset = "0x4EBE8E0", VA = "0x184EC02E0")]
		[CompilerGenerated]
		private void JCGCKCMFNHF(string ENLEFDLBBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class GOLBDJFBGPA : HDOGPLPCMIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Action PEMICEIPPPL;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool EEOLGOJMLLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
		public GOLBDJFBGPA(Action PEMICEIPPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x962640", Offset = "0x960C40", VA = "0x180962640", Slot = "5")]
		public void OBILMPBHNMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<HDOGPLPCMIL> LFBOJEJBHEM;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9AC0", Offset = "0x2CD80C0", VA = "0x182CD9AC0")]
	public static FGBFKCLKPNC<T> CJCFNNCBIOK<T>(this FGBFKCLKPNC<T> GJKGCMKPFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7345450", Offset = "0x7343A50", VA = "0x187345450")]
	public static void CJCFNNCBIOK(Action PEMICEIPPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9B40", Offset = "0x2CD8140", VA = "0x182CD9B40")]
	private static FGBFKCLKPNC<T> NFNDLIJDDBD<T>(FGBFKCLKPNC<T> GJKGCMKPFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x73455F0", Offset = "0x7343BF0", VA = "0x1873455F0")]
	private static void IAJJDKJCFBO(HDOGPLPCMIL MJIPFCFOLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7345800", Offset = "0x7343E00", VA = "0x187345800")]
	private static void OMELFHFGOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x73454F0", Offset = "0x7343AF0", VA = "0x1873454F0")]
	private static void HOCHABLJFJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7345AE0", Offset = "0x73440E0", VA = "0x187345AE0")]
	private static void PAJLGKHJECG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class KKMFFNIPDPG
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct GHFJHIDIMDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public TaskCompletionSource<Scene> JAMGAFMLBPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly string GMDNGOMOOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly LoadSceneMode DAGEACLHLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly bool DAAOJHPPFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly KEFLMHFIOFB<string>.JJGFAMJGLBE KHLICGBOPAL;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7337300", Offset = "0x7335900", VA = "0x187337300")]
		public GHFJHIDIMDG(TaskCompletionSource<Scene> GNOPBNMOHBK, string GMDNGOMOOMJ, LoadSceneMode DAGEACLHLJN, bool DAAOJHPPFHB, KEFLMHFIOFB<string>.JJGFAMJGLBE KHLICGBOPAL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct NAFIOEIHEMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public KEFLMHFIOFB<string>.JJGFAMJGLBE stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private KEFLMHFIOFB<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7343F40", Offset = "0x7342540", VA = "0x187343F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x73447E0", Offset = "0x7342DE0", VA = "0x1873447E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct HAAAFPBNGBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7337FE0", Offset = "0x73365E0", VA = "0x187337FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7338300", Offset = "0x7336900", VA = "0x187338300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct GKEAPBALECK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private GHFJHIDIMDG <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7337BD0", Offset = "0x73361D0", VA = "0x187337BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7337F80", Offset = "0x7336580", VA = "0x187337F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class BPGJCHOLAGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public BHNOEEFMNHG<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public BPGJCHOLAGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7330220", Offset = "0x732E820", VA = "0x187330220")]
		internal void HKAHKCGJHEK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct DOMHMMALLPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public KEFLMHFIOFB<string>.JJGFAMJGLBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private BPGJCHOLAGF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private KEFLMHFIOFB<string>.JJGFAMJGLBE <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private KEFLMHFIOFB<string>.JJGFAMJGLBE <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7334AA0", Offset = "0x73330A0", VA = "0x187334AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7335640", Offset = "0x7333C40", VA = "0x187335640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct GHGCDIFDHOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7337360", Offset = "0x7335960", VA = "0x187337360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7337840", Offset = "0x7335E40", VA = "0x187337840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct MDJNCKANJBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public KEFLMHFIOFB<string>.JJGFAMJGLBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private KEFLMHFIOFB<string>.JJGFAMJGLBE <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private KEFLMHFIOFB<string>.JJGFAMJGLBE <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7342350", Offset = "0x7340950", VA = "0x187342350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7342EA0", Offset = "0x73414A0", VA = "0x187342EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class MADOABGEOEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public MADOABGEOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x73420E0", Offset = "0x73406E0", VA = "0x1873420E0")]
		internal bool IDLOMLNKBCK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FEMHGBPHJDE : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private FEEHCBLGINO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public OGONOIIKGAI onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public FEMHGBPHJDE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7336720", Offset = "0x7334D20", VA = "0x187336720", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7336390", Offset = "0x7334990", VA = "0x187336390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7336340", Offset = "0x7334940", VA = "0x187336340")]
		private void LEGBLNHPDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x73366D0", Offset = "0x7334CD0", VA = "0x1873366D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class DCFHKLJELOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public BHNOEEFMNHG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public DCFHKLJELOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7334820", Offset = "0x7332E20", VA = "0x187334820")]
		internal bool JABBJDFOBOG(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x73345A0", Offset = "0x7332BA0", VA = "0x1873345A0")]
		internal void HIFPALKECBB(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class JLBONDOLEKI : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private FEEHCBLGINO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public BHNOEEFMNHG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private DCFHKLJELOO <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public JLBONDOLEKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x733AE50", Offset = "0x7339450", VA = "0x18733AE50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x733B4D0", Offset = "0x7339AD0", VA = "0x18733B4D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly ICollection<string> ALOILFKHAJK;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static GJFFIMHAENI NGKECCBAFIC;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static AsyncOperation JNKDKPILMCK;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static GJFFIMHAENI HNBENICMAPC;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static string AGJNGHEEMKN;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static ThreadPriority JEIGFKCNKFE;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task BIOCADMGEAD;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static List<SceneInstance> KENAEOCPICJ;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Queue<GHFJHIDIMDG> MHDAOOJEBKA;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Task PMCKEKBPIME;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool LJNICKADPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x733CEF0", Offset = "0x733B4F0", VA = "0x18733CEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool FKEJHIOINGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x733DFD0", Offset = "0x733C5D0", VA = "0x18733DFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool AILNOOCEIIA
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x733CC30", Offset = "0x733B230", VA = "0x18733CC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool HBLJKFBIACI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x733E180", Offset = "0x733C780", VA = "0x18733E180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> AKEPDOOBBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x733DA50", Offset = "0x733C050", VA = "0x18733DA50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x733E070", Offset = "0x733C670", VA = "0x18733E070")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x733E210", Offset = "0x733C810", VA = "0x18733E210")]
	[AKHHACKKOPD(AIIPENBHOND.EnteredEditModeNextFrame, 0)]
	private static void PEPDPPEHKBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x733CCD0", Offset = "0x733B2D0", VA = "0x18733CCD0")]
	[AsyncStateMachine(typeof(NAFIOEIHEMJ))]
	public static Task<Scene> ACOFGGDNPBH(string GMDNGOMOOMJ, LoadSceneMode DAGEACLHLJN = LoadSceneMode.Single, bool DAAOJHPPFHB = false, [Optional] KEFLMHFIOFB<string>.JJGFAMJGLBE DJIKFOBEADG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x733D880", Offset = "0x733BE80", VA = "0x18733D880")]
	[AsyncStateMachine(typeof(HAAAFPBNGBF))]
	private static Task IGBKFHHOIBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x733CE20", Offset = "0x733B420", VA = "0x18733CE20")]
	[AsyncStateMachine(typeof(GKEAPBALECK))]
	private static Task AFAHEAJBLEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x733D380", Offset = "0x733B980", VA = "0x18733D380")]
	[AsyncStateMachine(typeof(DOMHMMALLPK))]
	private static Task<Scene> DBECIMAMIGM(string GMDNGOMOOMJ, LoadSceneMode DAGEACLHLJN, bool DAAOJHPPFHB, KEFLMHFIOFB<string>.JJGFAMJGLBE KHLICGBOPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x733DB60", Offset = "0x733C160", VA = "0x18733DB60")]
	private static void KLFICELHNID(SceneInstance ADJKKNJDKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x733D5E0", Offset = "0x733BBE0", VA = "0x18733D5E0")]
	private static void FEPJDPMFEFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x733D930", Offset = "0x733BF30", VA = "0x18733D930")]
	[AsyncStateMachine(typeof(GHGCDIFDHOC))]
	private static Task<Scene> JGKHPFJFMKE(string GMDNGOMOOMJ, LoadSceneMode DAGEACLHLJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x733D290", Offset = "0x733B890", VA = "0x18733D290")]
	private static bool BOLONKMPAML(string GMDNGOMOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x733D4D0", Offset = "0x733BAD0", VA = "0x18733D4D0")]
	[AsyncStateMachine(typeof(MDJNCKANJBK))]
	private static Task<Scene> ECAPHGJDIMN(KEFLMHFIOFB<string>.JJGFAMJGLBE KHLICGBOPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x733D110", Offset = "0x733B710", VA = "0x18733D110")]
	public static FGBFKCLKPNC<Scene> BKGBOABCPEF(string GMDNGOMOOMJ, LoadSceneMode DAGEACLHLJN = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x733DC70", Offset = "0x733C270", VA = "0x18733DC70")]
	public static GJFFIMHAENI LCOMALHNNEA(string GMDNGOMOOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x733DF40", Offset = "0x733C540", VA = "0x18733DF40")]
	[IteratorStateMachine(typeof(FEMHGBPHJDE))]
	private static IEnumerator<FEEHCBLGINO> LPLLINIDAFO(string GMDNGOMOOMJ, OGONOIIKGAI KGLNKIBDGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x733D7E0", Offset = "0x733BDE0", VA = "0x18733D7E0")]
	[IteratorStateMachine(typeof(JLBONDOLEKI))]
	private static IEnumerator<FEEHCBLGINO> FLIHOKOHGGB(string GMDNGOMOOMJ, LoadSceneMode DAGEACLHLJN, BHNOEEFMNHG<Scene> KGLNKIBDGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x733E310", Offset = "0x733C910", VA = "0x18733E310")]
	public static bool PIOBBIBJDDP([Out] string FIJCGNHCCLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class GDMNAOGDMBP
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7337270", Offset = "0x7335870", VA = "0x187337270")]
	public static IDisposable PLBACFGGGHA(this LFJANMAIOAJ CAMDIODFJJE, float JJPGIKPAHJL, Action<float> MOHOKONAKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7337170", Offset = "0x7335770", VA = "0x187337170")]
	public static IDisposable EFAIKGJIOAH(this LFJANMAIOAJ CAMDIODFJJE, Action<float> MOHOKONAKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x73371F0", Offset = "0x73357F0", VA = "0x1873371F0")]
	public static IDisposable GFCBBLEFAPJ(this LFJANMAIOAJ CAMDIODFJJE, Action<float> MOHOKONAKHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class KLEDEFPOHAP
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x733E910", Offset = "0x733CF10", VA = "0x18733E910")]
	public static IDisposable BJFCICFMGDM(this MonoBehaviour IFGDBEFLMIB, Action MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x733E9A0", Offset = "0x733CFA0", VA = "0x18733E9A0")]
	public static IDisposable BJFCICFMGDM(this MonoBehaviour IFGDBEFLMIB, Action<float> MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x733ED10", Offset = "0x733D310", VA = "0x18733ED10")]
	public static IDisposable JPIODFAGAAF(this MonoBehaviour IFGDBEFLMIB, Action MOHOKONAKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x733EAB0", Offset = "0x733D0B0", VA = "0x18733EAB0")]
	public static IDisposable CPKGOLOAPKI(this MonoBehaviour IFGDBEFLMIB, Action MOHOKONAKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x733EA30", Offset = "0x733D030", VA = "0x18733EA30")]
	public static IDisposable CPKGOLOAPKI(this MonoBehaviour IFGDBEFLMIB, Action<float> MOHOKONAKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x733F0A0", Offset = "0x733D6A0", VA = "0x18733F0A0")]
	public static IDisposable OBELDGMGNMD(this MonoBehaviour IFGDBEFLMIB, Action MOHOKONAKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x733F020", Offset = "0x733D620", VA = "0x18733F020")]
	public static IDisposable MFEIOFPECPH(this MonoBehaviour IFGDBEFLMIB, Action MOHOKONAKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x733E6D0", Offset = "0x733CCD0", VA = "0x18733E6D0")]
	public static IDisposable ADHLIILCICI(this MonoBehaviour IFGDBEFLMIB, Action MOHOKONAKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x733F120", Offset = "0x733D720", VA = "0x18733F120")]
	public static IDisposable OLBNLKMKNAF(this MonoBehaviour IFGDBEFLMIB, float JJPGIKPAHJL, Action<float> MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL, bool BJCGDGNBKFG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x733E750", Offset = "0x733CD50", VA = "0x18733E750")]
	public static IDisposable BCFOGAIEDJI(this MonoBehaviour IFGDBEFLMIB, float JJPGIKPAHJL, Action<float> MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL, bool BJCGDGNBKFG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x733ED90", Offset = "0x733D390", VA = "0x18733ED90")]
	public static IDisposable KIPNNABFPNN(this MonoBehaviour IFGDBEFLMIB, float JJPGIKPAHJL, Action<float> MOHOKONAKHO, bool BJCGDGNBKFG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x733EBD0", Offset = "0x733D1D0", VA = "0x18733EBD0")]
	public static IDisposable GBGJCKEDELB(this MonoBehaviour IFGDBEFLMIB, Action<float> MOHOKONAKHO, bool BJCGDGNBKFG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x733EB30", Offset = "0x733D130", VA = "0x18733EB30")]
	public static IDisposable DILFADFMCNP(this MonoBehaviour IFGDBEFLMIB, Action<float> MOHOKONAKHO, bool BJCGDGNBKFG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x733EE30", Offset = "0x733D430", VA = "0x18733EE30")]
	public static IDisposable KKDAIHMEMCB(this MonoBehaviour IFGDBEFLMIB, Action<float> MOHOKONAKHO, bool BJCGDGNBKFG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x733EED0", Offset = "0x733D4D0", VA = "0x18733EED0")]
	public static IDisposable LGPHPCOKDEI(this MonoBehaviour IFGDBEFLMIB, Action<float> MOHOKONAKHO, bool BJCGDGNBKFG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x733EC70", Offset = "0x733D270", VA = "0x18733EC70")]
	public static IDisposable GHPJNCNFMOP(this MonoBehaviour IFGDBEFLMIB, Action<float> MOHOKONAKHO, bool BJCGDGNBKFG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x733E870", Offset = "0x733CE70", VA = "0x18733E870")]
	public static IDisposable BEPPIJBGJPE(this MonoBehaviour IFGDBEFLMIB, Action<float> MOHOKONAKHO, bool BJCGDGNBKFG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x733E630", Offset = "0x733CC30", VA = "0x18733E630")]
	public static IDisposable ABJGOOJJOAN(this MonoBehaviour IFGDBEFLMIB, Action<float> MOHOKONAKHO, bool BJCGDGNBKFG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x733EF70", Offset = "0x733D570", VA = "0x18733EF70")]
	public static IDisposable MECKKJEHAKP(this MonoBehaviour IFGDBEFLMIB, float JJPGIKPAHJL, Action<float> MOHOKONAKHO, bool BJCGDGNBKFG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class CBBCFEEACFF
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class AIFPKPDDENN : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private FEEHCBLGINO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public JLPIFGMKEPF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private AOCBPGDDHDE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public AIFPKPDDENN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x732EE10", Offset = "0x732D410", VA = "0x18732EE10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x732EEF0", Offset = "0x732D4F0", VA = "0x18732EEF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class OHKCOPPLMKJ : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private FEEHCBLGINO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public JLPIFGMKEPF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private AOCBPGDDHDE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public OHKCOPPLMKJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7347F10", Offset = "0x7346510", VA = "0x187347F10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7348000", Offset = "0x7346600", VA = "0x187348000", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7330280", Offset = "0x732E880", VA = "0x187330280")]
	public static EKNCDBKDOPI BJFCICFMGDM(Action MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7330330", Offset = "0x732E930", VA = "0x187330330")]
	public static EKNCDBKDOPI BJFCICFMGDM(Behaviour CAMDIODFJJE, Action MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x73303F0", Offset = "0x732E9F0", VA = "0x1873303F0")]
	public static EKNCDBKDOPI BJFCICFMGDM(Behaviour CAMDIODFJJE, Action<float> MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x73305A0", Offset = "0x732EBA0", VA = "0x1873305A0")]
	[IteratorStateMachine(typeof(AIFPKPDDENN))]
	private static IEnumerator<FEEHCBLGINO> IKGDGOICPDJ(JLPIFGMKEPF FJIGDOHKAPF, Action MOHOKONAKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7330510", Offset = "0x732EB10", VA = "0x187330510")]
	[IteratorStateMachine(typeof(OHKCOPPLMKJ))]
	private static IEnumerator<FEEHCBLGINO> IKGDGOICPDJ(JLPIFGMKEPF FJIGDOHKAPF, Action<float> MOHOKONAKHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class KLJODPKFLEE : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class ENIABKHDLPN : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private FEEHCBLGINO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public KLJODPKFLEE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public ENIABKHDLPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7335810", Offset = "0x7333E10", VA = "0x187335810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x73358A0", Offset = "0x7333EA0", VA = "0x1873358A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly JLPIFGMKEPF IEIDKHEINJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Action BAEMJBPKKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool ADFFAJJGAPA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool ODICFMPPFHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x868CF0", Offset = "0x8672F0", VA = "0x180868CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x733F2F0", Offset = "0x733D8F0", VA = "0x18733F2F0")]
	public KLJODPKFLEE(JLPIFGMKEPF IEIDKHEINJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x733F1D0", Offset = "0x733D7D0", VA = "0x18733F1D0")]
	[IteratorStateMachine(typeof(ENIABKHDLPN))]
	private IEnumerator<FEEHCBLGINO> KBMFAEJCNOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x733F250", Offset = "0x733D850", VA = "0x18733F250", Slot = "4")]
	public void OnCompleted(Action BICHGGDOAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	public void KPNIAOKIMLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class FIOMKJHIHDF
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x73368D0", Offset = "0x7334ED0", VA = "0x1873368D0")]
	public static KLJODPKFLEE NKGJLAIFHHM(this JLPIFGMKEPF IEIDKHEINJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class ACFFHOBHNOH
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class JDEGDNMCKPP : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private FEEHCBLGINO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public PEOPLJKBOCG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public JDEGDNMCKPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x733AB40", Offset = "0x7339140", VA = "0x18733AB40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x733ABC0", Offset = "0x73391C0", VA = "0x18733ABC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x732E820", Offset = "0x732CE20", VA = "0x18732E820")]
	public static EKNCDBKDOPI BJFCICFMGDM(float JJPGIKPAHJL, Action<float> MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL, bool BJCGDGNBKFG = true, [Optional] FPGOJBMPOIO MEGIAEKKLAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x732E920", Offset = "0x732CF20", VA = "0x18732E920")]
	public static EKNCDBKDOPI BJFCICFMGDM(MonoBehaviour IFGDBEFLMIB, float JJPGIKPAHJL, Action<float> MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL, bool BJCGDGNBKFG = true, [Optional] FPGOJBMPOIO MEGIAEKKLAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x732EC60", Offset = "0x732D260", VA = "0x18732EC60")]
	public static EKNCDBKDOPI NABCMMEHGNE(MonoBehaviour IFGDBEFLMIB, float JJPGIKPAHJL, Action<float> MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL, bool BJCGDGNBKFG = true, [Optional] FPGOJBMPOIO MEGIAEKKLAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x732EA30", Offset = "0x732D030", VA = "0x18732EA30")]
	public static EKNCDBKDOPI FHFOFHEPODB(LFJANMAIOAJ CAMDIODFJJE, float JJPGIKPAHJL, Action<float> MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL, bool BJCGDGNBKFG = true, [Optional] FPGOJBMPOIO MEGIAEKKLAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x732EBA0", Offset = "0x732D1A0", VA = "0x18732EBA0")]
	private static IEnumerator<FEEHCBLGINO> IKGDGOICPDJ(EOPAGDMPGAH EKGFCNBDBIK, float JJPGIKPAHJL, JLPIFGMKEPF FJIGDOHKAPF, Action<float> MOHOKONAKHO, bool BJCGDGNBKFG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x732EB40", Offset = "0x732D140", VA = "0x18732EB40")]
	private static IEnumerator<FEEHCBLGINO> GIMDJBGKCIF(EOPAGDMPGAH EKGFCNBDBIK, float JJPGIKPAHJL, JLPIFGMKEPF FJIGDOHKAPF, Action<float> MOHOKONAKHO, bool BJCGDGNBKFG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x732ED80", Offset = "0x732D380", VA = "0x18732ED80")]
	[IteratorStateMachine(typeof(JDEGDNMCKPP))]
	private static IEnumerator<FEEHCBLGINO> PAEBIDHPNBE(PEOPLJKBOCG FBLNIPIGCAK, float JJPGIKPAHJL, JLPIFGMKEPF FJIGDOHKAPF, Action<float> MOHOKONAKHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class MECEEEFMPGO
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class IFOLHDNBDPB : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private FEEHCBLGINO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public JLPIFGMKEPF queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public IFOLHDNBDPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x73390F0", Offset = "0x73376F0", VA = "0x1873390F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x73391B0", Offset = "0x73377B0", VA = "0x1873391B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7343030", Offset = "0x7341630", VA = "0x187343030")]
	[IteratorStateMachine(typeof(IFOLHDNBDPB))]
	private static IEnumerator<FEEHCBLGINO> FMPHDFAJABC(JLPIFGMKEPF IEIDKHEINJL, Func<bool> ECAAAOIMMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7342F10", Offset = "0x7341510", VA = "0x187342F10")]
	public static EKNCDBKDOPI EPFMJMAAHGE(this MonoBehaviour IFGDBEFLMIB, Func<bool> ECAAAOIMMGP, JLPIFGMKEPF IEIDKHEINJL = JLPIFGMKEPF.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class BONNFMNPJEI
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class EONEGELCDPG : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private FEEHCBLGINO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public JLPIFGMKEPF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public EONEGELCDPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x73358F0", Offset = "0x7333EF0", VA = "0x1873358F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7335960", Offset = "0x7333F60", VA = "0x187335960", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class OIEEHEAOMGD : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private FEEHCBLGINO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public JLPIFGMKEPF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private FEEHCBLGINO <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public OIEEHEAOMGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7348050", Offset = "0x7346650", VA = "0x187348050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x73480E0", Offset = "0x73466E0", VA = "0x1873480E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x732FD10", Offset = "0x732E310", VA = "0x18732FD10")]
	[IteratorStateMachine(typeof(EONEGELCDPG))]
	private static IEnumerator<FEEHCBLGINO> KBMFAEJCNOA(float HAGKGIBCOBL, JLPIFGMKEPF FJIGDOHKAPF, Action ILHEMCJEFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x732F5C0", Offset = "0x732DBC0", VA = "0x18732F5C0")]
	[IteratorStateMachine(typeof(OIEEHEAOMGD))]
	private static IEnumerator<FEEHCBLGINO> DKKLNAOAHOJ(float HAGKGIBCOBL, JLPIFGMKEPF FJIGDOHKAPF, Action ILHEMCJEFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x732F760", Offset = "0x732DD60", VA = "0x18732F760")]
	public static IDisposable FHGHMNEGBOC(this MonoBehaviour IFGDBEFLMIB, float HAGKGIBCOBL, Action ILHEMCJEFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x732FB80", Offset = "0x732E180", VA = "0x18732FB80")]
	public static EKNCDBKDOPI IDBMKEPDKAJ(this MonoBehaviour IFGDBEFLMIB, float HAGKGIBCOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x732F880", Offset = "0x732DE80", VA = "0x18732F880")]
	public static EKNCDBKDOPI FHGHMNEGBOC(this MonoBehaviour IFGDBEFLMIB, float HAGKGIBCOBL, JLPIFGMKEPF FJIGDOHKAPF, Action ILHEMCJEFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x732FDB0", Offset = "0x732E3B0", VA = "0x18732FDB0")]
	public static EKNCDBKDOPI KCJJLLMDEMB(this MonoBehaviour IFGDBEFLMIB, Action ILHEMCJEFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x732F660", Offset = "0x732DC60", VA = "0x18732F660")]
	public static EKNCDBKDOPI DMFPIAPFCLG(this MonoBehaviour IFGDBEFLMIB, Action ILHEMCJEFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x732FED0", Offset = "0x732E4D0", VA = "0x18732FED0")]
	public static EKNCDBKDOPI PNKMACDHLNI(this MonoBehaviour IFGDBEFLMIB, Action ILHEMCJEFIG, [Optional] FPGOJBMPOIO MEGIAEKKLAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x732FEA0", Offset = "0x732E4A0", VA = "0x18732FEA0")]
	public static EKNCDBKDOPI OPMLOPFHKHB(this MonoBehaviour IFGDBEFLMIB, Action ILHEMCJEFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x732FB50", Offset = "0x732E150", VA = "0x18732FB50")]
	public static EKNCDBKDOPI HKDCGFIKBDG(this MonoBehaviour IFGDBEFLMIB, Action ILHEMCJEFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x732FDD0", Offset = "0x732E3D0", VA = "0x18732FDD0")]
	private static EKNCDBKDOPI KEMNCNLLANM(MonoBehaviour IFGDBEFLMIB, JLPIFGMKEPF IEIDKHEINJL, Action ILHEMCJEFIG, [Optional] FPGOJBMPOIO MEGIAEKKLAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x732F9B0", Offset = "0x732DFB0", VA = "0x18732F9B0")]
	public static EKNCDBKDOPI FJKMCPKCFEN(this MonoBehaviour IFGDBEFLMIB, float EKPPHMAIBCH, Action ILHEMCJEFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x732FC40", Offset = "0x732E240", VA = "0x18732FC40")]
	public static EKNCDBKDOPI JDMKDOIJCPD(this MonoBehaviour IFGDBEFLMIB, float EKPPHMAIBCH, Action ILHEMCJEFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x732F690", Offset = "0x732DC90", VA = "0x18732F690")]
	public static EKNCDBKDOPI ECPKIGDEIEK(this MonoBehaviour IFGDBEFLMIB, float EKPPHMAIBCH, Action ILHEMCJEFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x732FA80", Offset = "0x732E080", VA = "0x18732FA80")]
	public static EKNCDBKDOPI HHAHBAMDAEG(this MonoBehaviour IFGDBEFLMIB, float EKPPHMAIBCH, Action ILHEMCJEFIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class FAINKPJINKC : CCAMDGBHFJG, IEnumerable<CCAMDGBHFJG>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly List<CCAMDGBHFJG> OJKHJGBGDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool NJEINONLCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Action BJBKHEPIEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool ECBENPLBCAK;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IJLKBMAPLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7335EB0", Offset = "0x73344B0", VA = "0x187335EB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LKIGKPELOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x73361C0", Offset = "0x73347C0", VA = "0x1873361C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7335FF0", Offset = "0x73345F0", VA = "0x187335FF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7336260", Offset = "0x7334860", VA = "0x187336260")]
	public FAINKPJINKC([Optional] Action BJBKHEPIEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7336090", Offset = "0x7334690", VA = "0x187336090")]
	public void LHEPNGLDBLI(CCAMDGBHFJG BCMFBGEBELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7335CD0", Offset = "0x73342D0", VA = "0x187335CD0")]
	private void DOODIMBGJII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x73359B0", Offset = "0x7333FB0", VA = "0x1873359B0", Slot = "7")]
	public bool CEIFDIKKAPI(bool LCIFANAPNML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x73359C0", Offset = "0x7333FC0", VA = "0x1873359C0", Slot = "8")]
	public bool CEIFDIKKAPI(Action PEMICEIPPPL, bool LCIFANAPNML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7335E30", Offset = "0x7334430", VA = "0x187335E30", Slot = "9")]
	public IEnumerator<CCAMDGBHFJG> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7335E30", Offset = "0x7334430", VA = "0x187335E30", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class GJBNPCHBHAE : NHCLCFDBEBH
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class PNCPNCLJHPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public GJBNPCHBHAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public PNCPNCLJHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x733A740", Offset = "0x7338D40", VA = "0x18733A740")]
		internal void LFFBFDOHBKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class INGLMMGEJCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public GJBNPCHBHAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public INGLMMGEJCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x733A740", Offset = "0x7338D40", VA = "0x18733A740")]
		internal void DECGCPNIPJC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly float EIDCECHJOKP;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7337AD0", Offset = "0x73360D0", VA = "0x187337AD0")]
	public GJBNPCHBHAE(Behaviour CAMDIODFJJE, float EIDCECHJOKP, [Optional] Action BJBKHEPIEFO, [Optional] FPGOJBMPOIO MEGIAEKKLAN, [Optional] EOPAGDMPGAH EKGFCNBDBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x73379C0", Offset = "0x7335FC0", VA = "0x1873379C0", Slot = "9")]
	protected override bool OPDIAIDCMMM(Action PEMICEIPPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x73378B0", Offset = "0x7335EB0", VA = "0x1873378B0", Slot = "10")]
	protected override bool MBJBPGAPLLE(Action PEMICEIPPPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface CCAMDGBHFJG
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool IJLKBMAPLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LKIGKPELOIP;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CEIFDIKKAPI(bool LCIFANAPNML = false);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CEIFDIKKAPI(Action PEMICEIPPPL, bool LCIFANAPNML = false);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public abstract class NHCLCFDBEBH : CCAMDGBHFJG
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class FGOEPFFPGHB : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private FEEHCBLGINO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public NHCLCFDBEBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public FGOEPFFPGHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x73367B0", Offset = "0x7334DB0", VA = "0x1873367B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7336880", Offset = "0x7334E80", VA = "0x187336880", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Behaviour CAMDIODFJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action BJBKHEPIEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private EFOPDINOAPF FANIABHKHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly FPGOJBMPOIO MEGIAEKKLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	protected readonly EOPAGDMPGAH EKGFCNBDBIK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool IJLKBMAPLAE
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xECA650", Offset = "0xEC8C50", VA = "0x180ECA650", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action LKIGKPELOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x73452B0", Offset = "0x73438B0", VA = "0x1873452B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7345180", Offset = "0x7343780", VA = "0x187345180", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7345350", Offset = "0x7343950", VA = "0x187345350")]
	protected NHCLCFDBEBH(Behaviour CAMDIODFJJE, [Optional] Action BJBKHEPIEFO, [Optional] FPGOJBMPOIO MEGIAEKKLAN, [Optional] EOPAGDMPGAH EKGFCNBDBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7344DC0", Offset = "0x73433C0", VA = "0x187344DC0", Slot = "7")]
	public bool CEIFDIKKAPI(bool LCIFANAPNML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7344E20", Offset = "0x7343420", VA = "0x187344E20", Slot = "8")]
	public bool CEIFDIKKAPI(Action PEMICEIPPPL, bool LCIFANAPNML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool OPDIAIDCMMM(Action PEMICEIPPPL);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool MBJBPGAPLLE(Action PEMICEIPPPL);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7344DA0", Offset = "0x73433A0", VA = "0x187344DA0")]
	protected void APHFPFKOBAP(Action PEMICEIPPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7344E80", Offset = "0x7343480", VA = "0x187344E80")]
	protected GJFFIMHAENI EHMFMPFOKLG(float JCFJIBJJHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7345100", Offset = "0x7343700", VA = "0x187345100")]
	private void FEDBIBFBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7345220", Offset = "0x7343820", VA = "0x187345220")]
	[IteratorStateMachine(typeof(FGOEPFFPGHB))]
	private IEnumerator<FEEHCBLGINO> KPCGLKIJJLK(float JCFJIBJJHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x73450C0", Offset = "0x73436C0", VA = "0x1873450C0")]
	[CompilerGenerated]
	private void FAMDAHDHMNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class NBKGBMLKOCE : NHCLCFDBEBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float GLDGKOGCLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly int POFBCFPCFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float KGIOBHMBMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float[] JCDCPCBACHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private int PEHMDAFMOKH;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7344AD0", Offset = "0x73430D0", VA = "0x187344AD0")]
	public NBKGBMLKOCE(Behaviour CAMDIODFJJE, float MDCKOIOIHCC, int POFBCFPCFCB, [Optional] Action BJBKHEPIEFO, float KGIOBHMBMAO = 0f, [Optional] FPGOJBMPOIO MEGIAEKKLAN, [Optional] EOPAGDMPGAH EKGFCNBDBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "9")]
	protected override bool OPDIAIDCMMM(Action PEMICEIPPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7344850", Offset = "0x7342E50", VA = "0x187344850", Slot = "10")]
	protected override bool MBJBPGAPLLE(Action PEMICEIPPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7344A50", Offset = "0x7343050", VA = "0x187344A50")]
	private void MHIPJGNMDFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class NLPKBBLMBPJ : NHCLCFDBEBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly float EIDCECHJOKP;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7337AD0", Offset = "0x73360D0", VA = "0x187337AD0")]
	public NLPKBBLMBPJ(Behaviour CAMDIODFJJE, float EIDCECHJOKP, [Optional] Action BJBKHEPIEFO, [Optional] FPGOJBMPOIO MEGIAEKKLAN, [Optional] EOPAGDMPGAH EKGFCNBDBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "9")]
	protected override bool OPDIAIDCMMM(Action PEMICEIPPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7345D00", Offset = "0x7344300", VA = "0x187345D00", Slot = "10")]
	protected override bool MBJBPGAPLLE(Action PEMICEIPPPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public sealed class OBHICEPHHII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CHDPLPGKGHM : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private FEEHCBLGINO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public CHDPLPGKGHM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7330630", Offset = "0x732EC30", VA = "0x187330630", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x73306A0", Offset = "0x732ECA0", VA = "0x1873306A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private EKNCDBKDOPI ENFAGECCAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private LFJANMAIOAJ CAMDIODFJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Action<float> JAOOBCHPIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private JLPIFGMKEPF IEIDKHEINJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private float NDPCGECDOLH;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x73462D0", Offset = "0x73448D0", VA = "0x1873462D0")]
	public OBHICEPHHII(LFJANMAIOAJ CAMDIODFJJE, float JJPGIKPAHJL, Action<float> MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7345FD0", Offset = "0x73445D0", VA = "0x187345FD0")]
	private void GJGCCDKPFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7346170", Offset = "0x7344770", VA = "0x187346170")]
	private void ONOHJAJNEBM(string ENLEFDLBBGG, Action CHELJEAOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7345EF0", Offset = "0x73444F0", VA = "0x187345EF0")]
	[IteratorStateMachine(typeof(CHDPLPGKGHM))]
	private IEnumerator<FEEHCBLGINO> DAAFEJENNCH(Action CHELJEAOAFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7345F70", Offset = "0x7344570", VA = "0x187345F70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7345D40", Offset = "0x7344340", VA = "0x187345D40")]
	[CompilerGenerated]
	private void BHFFJJHHHPM(string PAPBNEGEKNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class JLELKMDPAGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class PJNOJOABFOB : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private FEEHCBLGINO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public PJNOJOABFOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7330630", Offset = "0x732EC30", VA = "0x187330630", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7349C10", Offset = "0x7348210", VA = "0x187349C10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private EKNCDBKDOPI ENFAGECCAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private MonoBehaviour IFGDBEFLMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Action MOHOKONAKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action<float> JAOOBCHPIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private JLPIFGMKEPF IEIDKHEINJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private float NDPCGECDOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool BJCGDGNBKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly FPGOJBMPOIO MEGIAEKKLAN;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x733C130", Offset = "0x733A730", VA = "0x18733C130")]
	public JLELKMDPAGP(MonoBehaviour IFGDBEFLMIB, Action MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL, [Optional] FPGOJBMPOIO MEGIAEKKLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x733C570", Offset = "0x733AB70", VA = "0x18733C570")]
	public JLELKMDPAGP(MonoBehaviour IFGDBEFLMIB, Action<float> MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL, [Optional] FPGOJBMPOIO MEGIAEKKLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x733C320", Offset = "0x733A920", VA = "0x18733C320")]
	public JLELKMDPAGP(MonoBehaviour IFGDBEFLMIB, float JJPGIKPAHJL, Action<float> MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL, bool BJCGDGNBKFG = true, [Optional] FPGOJBMPOIO MEGIAEKKLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1C445C0", Offset = "0x1C42BC0", VA = "0x181C445C0")]
	private JLELKMDPAGP(FPGOJBMPOIO MEGIAEKKLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x733BE40", Offset = "0x733A440", VA = "0x18733BE40")]
	internal static JLELKMDPAGP NPEBMNPOBBC(MonoBehaviour IFGDBEFLMIB, float JJPGIKPAHJL, Action<float> MOHOKONAKHO, JLPIFGMKEPF IEIDKHEINJL, bool BJCGDGNBKFG = true, [Optional] FPGOJBMPOIO MEGIAEKKLAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x733B520", Offset = "0x7339B20", VA = "0x18733B520")]
	private void BJFCICFMGDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x733BC00", Offset = "0x733A200", VA = "0x18733BC00")]
	private void LJKOGCBJDGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x733B930", Offset = "0x7339F30", VA = "0x18733B930")]
	private void GJGCCDKPFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x733B710", Offset = "0x7339D10", VA = "0x18733B710")]
	private void DAEKMKNBHEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x733BF70", Offset = "0x733A570", VA = "0x18733BF70")]
	private void ONOHJAJNEBM(string ENLEFDLBBGG, Action CHELJEAOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x733B690", Offset = "0x7339C90", VA = "0x18733B690")]
	[IteratorStateMachine(typeof(PJNOJOABFOB))]
	private IEnumerator<FEEHCBLGINO> DAAFEJENNCH(Action CHELJEAOAFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x733B8D0", Offset = "0x7339ED0", VA = "0x18733B8D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x733BDB0", Offset = "0x733A3B0", VA = "0x18733BDB0")]
	[CompilerGenerated]
	private void NJIGHOLPBME(string PAPBNEGEKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x733C0A0", Offset = "0x733A6A0", VA = "0x18733C0A0")]
	[CompilerGenerated]
	private void PJJAEMBFBKD(string PAPBNEGEKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x733BB70", Offset = "0x733A170", VA = "0x18733BB70")]
	[CompilerGenerated]
	private void LIKLNKCCFJM(string PAPBNEGEKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x733BAE0", Offset = "0x733A0E0", VA = "0x18733BAE0")]
	[CompilerGenerated]
	private void JGEOPNFNFPD(string PAPBNEGEKNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[Flags]
internal enum GJLIJBDMDGK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal sealed class NLNHKOMKAGO : EOPAGDMPGAH
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float EKGLKBMMNPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7345CE0", Offset = "0x73442E0", VA = "0x187345CE0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float OJNOBMCHMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7345CF0", Offset = "0x73442F0", VA = "0x187345CF0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double GKCHDFKJCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7345CC0", Offset = "0x73442C0", VA = "0x187345CC0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7345C50", Offset = "0x7344250", VA = "0x187345C50")]
	[ILMJIPMJHLC(IAFNNCJJPGN.None)]
	private static void APAJJDIPHPG(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	[Preserve]
	internal NLNHKOMKAGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface DOECMOPOCPI
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHKHGECKNCB(string GJEDHMJMNJA);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBLNKAKGEGE();
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface FHOALECEGJA
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string OABCLOFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool KEFAIPMPDDE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool CKEDPHEIBHE
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal class MGODKJEDFAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public LONCBCILLEM AMIMNLGNICO;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int MIMJDCDEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x871860", Offset = "0x86FE60", VA = "0x180871860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7343230", Offset = "0x7341830", VA = "0x187343230")]
	public static FEEHCBLGINO JHNOAMEJJEA(IEnumerator<FEEHCBLGINO> FGKBGBIHHDH, OBPOCJPDMON FKOKIPEHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7343390", Offset = "0x7341990", VA = "0x187343390")]
	public FEEHCBLGINO JHNOAMEJJEA(OBPOCJPDMON[] KJICLHOMNEH, IEnumerator<FEEHCBLGINO>[] KFGMNEAHJDA, FEEHCBLGINO[] HOHBCJIMBNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x73430C0", Offset = "0x73416C0", VA = "0x1873430C0")]
	public void BBNDOJMBMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x73430F0", Offset = "0x73416F0", VA = "0x1873430F0")]
	public void EPMMKFIAMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7343450", Offset = "0x7341A50", VA = "0x187343450")]
	public void NLLPOMAOMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x73430C0", Offset = "0x73416C0", VA = "0x1873430C0")]
	public void FAIEPBCECII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public MGODKJEDFAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class LONCBCILLEM
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct KLBLPDEDLKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public MGODKJEDFAD LNGPPCLIJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public LFJANMAIOAJ GEIKFMAHLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public OBPOCJPDMON HFFHHPHPDFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public IEnumerator<FEEHCBLGINO> GNFPKLFFALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public FEEHCBLGINO AODCEMKFHJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public GJLIJBDMDGK EMONIEOKMJG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct BKLFAOJOBPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public JLPIFGMKEPF PAOIKCFDJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public List<KLBLPDEDLKK> LHIBLJJAJJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class PCCIMHGEKBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public OBPOCJPDMON promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public LONCBCILLEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public LFJANMAIOAJ context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public MGODKJEDFAD routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public GJLIJBDMDGK coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public FEEHCBLGINO currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public IEnumerator<FEEHCBLGINO> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public PCCIMHGEKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7348F90", Offset = "0x7347590", VA = "0x187348F90")]
		internal void NKKDNLBBFCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class EFPLAJOGDKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public MGODKJEDFAD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public LONCBCILLEM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public EFPLAJOGDKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x73357D0", Offset = "0x7333DD0", VA = "0x1873357D0")]
		internal void EJHAGJJKLLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class FBKPMMAEEKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public MGODKJEDFAD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public LONCBCILLEM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public FBKPMMAEEKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7336300", Offset = "0x7334900", VA = "0x187336300")]
		internal void DJONBMGFENH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class JHKCOAMKKBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public MGODKJEDFAD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public LONCBCILLEM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public JHKCOAMKKBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x733AE10", Offset = "0x7339410", VA = "0x18733AE10")]
		internal void OBACMNLFHOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const GJLIJBDMDGK FGNMLHPNBNN = GJLIJBDMDGK.Cancelled | GJLIJBDMDGK.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly JLPIFGMKEPF IEIDKHEINJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool[] MAJKDEAHMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<GJLIJBDMDGK> ILFBDPMLACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<float> IPCKIDBDOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> IJCJFMIOFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> KEAICBFPMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> KFIHKKBAJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> LMKPMEAELPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> COKMHGDGEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private MGODKJEDFAD[] FHMBLCBAGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private OBPOCJPDMON[] KJICLHOMNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private LFJANMAIOAJ[] KBHJPNEHCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IEnumerator<FEEHCBLGINO>[] CBLHHJDNLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private FEEHCBLGINO[] IPIGLINNKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int AIBGKCGGOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int PLGOIBDCNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly int BHKHFILLELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float IJHJEGFGEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private FJACLMDLGLN LLPFMAAMBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private JobHandle PIEGHCCBCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<MGODKJEDFAD> FFENLMLFKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool MMBNLKKJDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private List<Action> HAGLPBDHKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> DNCKMLMKFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private bool HMDMCDIHCMB;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public BKLFAOJOBPI[] BFFDBFJHLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8F7BD0", Offset = "0x8F61D0", VA = "0x1808F7BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7340D70", Offset = "0x733F370", VA = "0x187340D70")]
	private static int MHPLDPKEGAK(JLPIFGMKEPF IEIDKHEINJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7341A90", Offset = "0x7340090", VA = "0x187341A90")]
	public LONCBCILLEM(JLPIFGMKEPF IEIDKHEINJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x733FA20", Offset = "0x733E020", VA = "0x18733FA20")]
	private void EICCKFHADFE(int EECDPFMOMDF, int KCEANHECCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7340840", Offset = "0x733EE40", VA = "0x187340840")]
	public void JOJLMDDLJEN(LFJANMAIOAJ CAMDIODFJJE, FEEHCBLGINO ODMAFCLAFHI, IEnumerator<FEEHCBLGINO> FGKBGBIHHDH, OBPOCJPDMON FKOKIPEHFDE, [Optional] MGODKJEDFAD LABPAIJFNPL, GJLIJBDMDGK FELBOLJMJFM = GJLIJBDMDGK.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x733F7E0", Offset = "0x733DDE0", VA = "0x18733F7E0")]
	public void EGGBADNHLGK(IEnumerable<KLBLPDEDLKK> ACBIBGNINJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x733FE30", Offset = "0x733E430", VA = "0x18733FE30")]
	private KLBLPDEDLKK FFHLIMPCKDD(int OMCGIACJLHC)
	{
		return default(KLBLPDEDLKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7340DA0", Offset = "0x733F3A0", VA = "0x187340DA0")]
	private void NJNCOBPFABM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D270", Offset = "0x2C5B870", VA = "0x182C5D270")]
	private static void IMFLMDECEEK<T>(int OMCGIACJLHC, T[] KJEKJPIJBON, int LPKLLJKOBNO, [Optional] T JBMFDABIONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D2C0", Offset = "0x2C5B8C0", VA = "0x182C5D2C0")]
	private static void IMFLMDECEEK<T>(int OMCGIACJLHC, NativeArray<T> KJEKJPIJBON, int LPKLLJKOBNO, [Optional] T JBMFDABIONI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x73409C0", Offset = "0x733EFC0", VA = "0x1873409C0")]
	private void KJLMDKFLCMN(IEnumerable<KLBLPDEDLKK> ACBIBGNINJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x733F720", Offset = "0x733DD20", VA = "0x18733F720")]
	private void ADFNIGHBMLC(KLBLPDEDLKK FBHPHJNABNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x73404B0", Offset = "0x733EAB0", VA = "0x1873404B0")]
	private IFFIFNKEBAE HGADNOEBIBH(int BGIBCAGMKHP)
	{
		return default(IFFIFNKEBAE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7341810", Offset = "0x733FE10", VA = "0x187341810")]
	public void OGNPMPJADBM(float GDHFBKFAMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7340300", Offset = "0x733E900", VA = "0x187340300")]
	private void FGOHNBOFAFK(Action KHKPJFABMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7341A10", Offset = "0x7340010", VA = "0x187341A10")]
	private void PLDBGKKABJA(Action KHKPJFABMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7341110", Offset = "0x733F710", VA = "0x187341110")]
	public void OCPEIGFEBFK(float GDHFBKFAMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x733FC00", Offset = "0x733E200", VA = "0x18733FC00")]
	public void EKANILNIIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x733FD00", Offset = "0x733E300", VA = "0x18733FD00")]
	public void FAIEPBCECII(MGODKJEDFAD FBLNIPIGCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7340380", Offset = "0x733E980", VA = "0x187340380")]
	public void GOOKFADLPLC(MGODKJEDFAD FBLNIPIGCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7340710", Offset = "0x733ED10", VA = "0x187340710")]
	public void HKKJENKMIKN(MGODKJEDFAD FBLNIPIGCAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class ILNLBKFKICJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static readonly ILNLBKFKICJ CHPFPNHMMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Action IIPPFKJLDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool LFHFPMACPBD;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	public ILNLBKFKICJ(Action IIPPFKJLDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEB60", Offset = "0x6ADD160", VA = "0x186ADEB60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface FBNDJOKIPNP<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T FJLALGMPANI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable BGHJECBJGEK(UnityEngine.Object CAMDIODFJJE, Action<T> BJLEECHIHAL);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface OCOEPCNBNCM<T> : FBNDJOKIPNP<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T FJLALGMPANI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class FFAOHBKDBOL<T> : OCOEPCNBNCM<T>, FBNDJOKIPNP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class BJAAIDNJGKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public FFAOHBKDBOL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public DAENNPGKFEM<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public BJAAIDNJGKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4F21570", Offset = "0x4F1FB70", VA = "0x184F21570")]
		internal void EGBNFMPEFIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static GameObject MBCBKPOEMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly List<DAENNPGKFEM<UnityEngine.Object, Action<T>>> JNELCPHGFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private T KEHLKEICKEB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T FJLALGMPANI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8E74D0", Offset = "0x8E5AD0", VA = "0x1808E74D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3C145A0", Offset = "0x3C12BA0", VA = "0x183C145A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3C14410", Offset = "0x3C12A10", VA = "0x183C14410")]
	private static bool LKGGGCCJNCD(T KHKPJFABMKM, T CGBLKAAFCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3C14720", Offset = "0x3C12D20", VA = "0x183C14720")]
	public FFAOHBKDBOL(T KLCHELDBJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3C14060", Offset = "0x3C12660", VA = "0x183C14060", Slot = "6")]
	public IDisposable BGHJECBJGEK(UnityEngine.Object CAMDIODFJJE, Action<T> BJLEECHIHAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3C139C0", Offset = "0x3C11FC0", VA = "0x183C139C0")]
	private void AAOECJLAGKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class LEDFDFEBCFI : OKFJOICMHBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly FPGOJBMPOIO MEGIAEKKLAN;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x733F600", Offset = "0x733DC00", VA = "0x18733F600")]
	[ILMJIPMJHLC(IAFNNCJJPGN.None)]
	private static void APAJJDIPHPG(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	[Preserve]
	internal LEDFDFEBCFI([JAMCDGPOOBO(null)] FPGOJBMPOIO MEGIAEKKLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x733F670", Offset = "0x733DC70", VA = "0x18733F670", Slot = "4")]
	public IDisposable KIPNNABFPNN(float JJPGIKPAHJL, Action<float> JMMEJHGHOEF, bool BJCGDGNBKFG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class OMFCLABNFNN : IMAIEDKPKEF, FPGOJBMPOIO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private LONCBCILLEM[] PFAPFPIJLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private DOECMOPOCPI JCNHAJANIPD;

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7348330", Offset = "0x7346930", VA = "0x187348330")]
	[ILMJIPMJHLC(IAFNNCJJPGN.None)]
	private static void APAJJDIPHPG(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7348ED0", Offset = "0x73474D0", VA = "0x187348ED0")]
	[Preserve]
	public OMFCLABNFNN([JAMCDGPOOBO(null)] JGBDINOJDJH LAJGGKGHIGL, [JAMCDGPOOBO(null)] EOPAGDMPGAH EKGFCNBDBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7348660", Offset = "0x7346C60", VA = "0x187348660", Slot = "18")]
	public override EKNCDBKDOPI GEGIPEDBDPG(LFJANMAIOAJ CAMDIODFJJE, IEnumerator<FEEHCBLGINO> EJOIGBFAMLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x73488E0", Offset = "0x7346EE0", VA = "0x1873488E0", Slot = "19")]
	public override void LJOBMJGJKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7348CA0", Offset = "0x73472A0", VA = "0x187348CA0", Slot = "21")]
	public override void PNBDPMJLGAL(JLPIFGMKEPF IEIDKHEINJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7348790", Offset = "0x7346D90", VA = "0x187348790", Slot = "20")]
	protected override void JPIODFAGAAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x73485D0", Offset = "0x7346BD0", VA = "0x1873485D0")]
	private LONCBCILLEM DEKMHHMAFGN(JLPIFGMKEPF GOAECDHCJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x73483A0", Offset = "0x73469A0", VA = "0x1873483A0", Slot = "22")]
	internal override HOJPKPGNFKK CIPPJONHGIM(IEnumerator<FEEHCBLGINO> EJOIGBFAMLB, Behaviour CAMDIODFJJE, OBPOCJPDMON FKOKIPEHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7348860", Offset = "0x7346E60", VA = "0x187348860", Slot = "23")]
	internal override OGOMMLFKPJK KCJDAIBIJFE(JLPIFGMKEPF FJIGDOHKAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7348B80", Offset = "0x7347180", VA = "0x187348B80")]
	private void MGEMJKCHFAK(LONCBCILLEM FKPGCBPAAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7348600", Offset = "0x7346C00", VA = "0x187348600", Slot = "24")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[BurstCompile]
internal struct FJACLMDLGLN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	public float BDODAEJPALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	public int PDHJEIMGOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NativeArray<int> JMDHNHGDBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private NativeArray<int> IGGJDOIIKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> NGNEFKBABKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	public NativeArray<GJLIJBDMDGK> EOCLAOHLPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	public NativeArray<float> ONFFGBBGAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[WriteOnly]
	public NativeArray<int> KFIHKKBAJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[WriteOnly]
	public NativeArray<int> IJCJFMIOFLM;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7336B80", Offset = "0x7335180", VA = "0x187336B80")]
	public static FJACLMDLGLN BBHPEKFPBBP(int JOLLPMKIIFM, float GDHFBKFAMIC, NativeArray<GJLIJBDMDGK> NDJCKDBAFNJ, NativeArray<float> FBCEFLIKCKB, NativeArray<int> ODMNNPANOJB, NativeArray<int> BCDEAGJFOOK, NativeArray<int> AKEPGHBAHCO, NativeArray<int> IGGJDOIIKHL, NativeArray<int> NGNEFKBABKN)
	{
		return default(FJACLMDLGLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7336C20", Offset = "0x7335220", VA = "0x187336C20", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7336BE0", Offset = "0x73351E0", VA = "0x187336BE0")]
	private bool DNBDMKMPDGM(int PDMMEDBMFPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7336D00", Offset = "0x7335300", VA = "0x187336D00")]
	private void GOJDIALCGLN(NativeArray<int> LGAGNKBKBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7336AE0", Offset = "0x73350E0", VA = "0x187336AE0")]
	private int AGEIBBKEFOH(int EFFGBOOKPGE, int IHGCBHPKGPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7336A10", Offset = "0x7335010", VA = "0x187336A10")]
	private void ACNLMJNONIC(NativeArray<int> LGAGNKBKBAA, int MLJBJOABHIM, int JPKMILJIBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7336D30", Offset = "0x7335330", VA = "0x187336D30")]
	private void MIDKILDNFIJ(NativeArray<int> LGAGNKBKBAA, int JLLNMFJFPOO, int ODADFCMLOFI, int GAPBPHECDIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class IMAIEDKPKEF : FPGOJBMPOIO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly JGBDINOJDJH LAJGGKGHIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	protected readonly EOPAGDMPGAH EKGFCNBDBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private OGOMMLFKPJK[] AABDGEAOKMM;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static FPGOJBMPOIO CFNNMJAMDBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7339CB0", Offset = "0x73382B0", VA = "0x187339CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool BGBBMOLNFII
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public JLPIFGMKEPF AJKIPJFMHAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JLPIFGMKEPF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x871860", Offset = "0x86FE60", VA = "0x180871860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EOPAGDMPGAH AIGFBCMJEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public FEEHCBLGINO LCBKCMNANJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public FEEHCBLGINO LLDNODCILFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8736F0", Offset = "0x871CF0", VA = "0x1808736F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public FEEHCBLGINO DIJGEDIKFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x868CC0", Offset = "0x8672C0", VA = "0x180868CC0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x733A130", Offset = "0x7338730", VA = "0x18733A130")]
	public static EKNCDBKDOPI PIEFHEIKCHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x733A250", Offset = "0x7338850", VA = "0x18733A250")]
	[Preserve]
	protected IMAIEDKPKEF([JAMCDGPOOBO(null)] JGBDINOJDJH LAJGGKGHIGL, [JAMCDGPOOBO(null)] EOPAGDMPGAH EKGFCNBDBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x73394A0", Offset = "0x7337AA0", VA = "0x1873394A0", Slot = "6")]
	public EKNCDBKDOPI DKNNLLCHPCG(IEnumerator<FEEHCBLGINO> EJOIGBFAMLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x73394B0", Offset = "0x7337AB0", VA = "0x1873394B0", Slot = "7")]
	public EKNCDBKDOPI DKNNLLCHPCG(Behaviour CAMDIODFJJE, IEnumerator<FEEHCBLGINO> EJOIGBFAMLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract EKNCDBKDOPI GEGIPEDBDPG(LFJANMAIOAJ CAMDIODFJJE, IEnumerator<FEEHCBLGINO> EJOIGBFAMLB);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7339F30", Offset = "0x7338530", VA = "0x187339F30", Slot = "19")]
	public virtual void LJOBMJGJKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7339A70", Offset = "0x7338070", VA = "0x187339A70", Slot = "9")]
	public void GCIJCEDEHJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7339D40", Offset = "0x7338340", VA = "0x187339D40", Slot = "20")]
	protected virtual void JPIODFAGAAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x733A110", Offset = "0x7338710", VA = "0x18733A110")]
	private void PGMLNKHJICF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7339D00", Offset = "0x7338300", VA = "0x187339D00")]
	private void ICOLBOBEPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7339480", Offset = "0x7337A80", VA = "0x187339480")]
	private void CPKGOLOAPKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x733A0F0", Offset = "0x73386F0", VA = "0x18733A0F0")]
	private void OBELDGMGNMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x733A0D0", Offset = "0x73386D0", VA = "0x18733A0D0")]
	private void MGEKOOCIJBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x73393A0", Offset = "0x73379A0", VA = "0x1873393A0")]
	private void AEBHAKGJKLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7339D20", Offset = "0x7338320", VA = "0x187339D20")]
	private void JLILLAAFBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x733A1C0", Offset = "0x73387C0", VA = "0x18733A1C0", Slot = "21")]
	public virtual void PNBDPMJLGAL(JLPIFGMKEPF IEIDKHEINJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7339D60", Offset = "0x7338360", VA = "0x187339D60")]
	private void LJBBDJPCAKI(OGOMMLFKPJK FKPGCBPAAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1EF82F0", Offset = "0x1EF68F0", VA = "0x181EF82F0")]
	private OGOMMLFKPJK AEELFLNAFNB(JLPIFGMKEPF GOAECDHCJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract HOJPKPGNFKK CIPPJONHGIM(IEnumerator<FEEHCBLGINO> EJOIGBFAMLB, Behaviour IFGDBEFLMIB, OBPOCJPDMON KEAEJIHNNOC);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract OGOMMLFKPJK KCJDAIBIJFE(JLPIFGMKEPF IEIDKHEINJL);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x73396B0", Offset = "0x7337CB0", VA = "0x1873396B0", Slot = "24")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x73393C0", Offset = "0x73379C0", VA = "0x1873393C0", Slot = "14")]
	public FEEHCBLGINO ALBINENHJGJ(JLPIFGMKEPF FJIGDOHKAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7339310", Offset = "0x7337910", VA = "0x187339310", Slot = "15")]
	public FEEHCBLGINO ADPGECDGFPI(float HAGKGIBCOBL, JLPIFGMKEPF FJIGDOHKAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7339420", Offset = "0x7337A20", VA = "0x187339420", Slot = "16")]
	public FEEHCBLGINO BDHIBNFJKHL(Func<bool> ECAAAOIMMGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class HOJPKPGNFKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly OBPOCJPDMON FKOKIPEHFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly FHOALECEGJA CAMDIODFJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly bool ADBDIHFHDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private string GJEDHMJMNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private StackTrace MFJAFALOOJF;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public IEnumerator<FEEHCBLGINO> GNFPKLFFALE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public FEEHCBLGINO AODCEMKFHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x868270", Offset = "0x866870", VA = "0x180868270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool KDPGBEBLDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7338910", Offset = "0x7336F10", VA = "0x187338910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool EBLPBOJMNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA1BD20", Offset = "0xA1A320", VA = "0x180A1BD20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE40", Offset = "0xA1A440", VA = "0x180A1BE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public string OABCLOFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7338CA0", Offset = "0x73372A0", VA = "0x187338CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float MDNCMNLLCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8F7E80", Offset = "0x8F6480", VA = "0x1808F7E80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5F88420", Offset = "0x5F86A20", VA = "0x185F88420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7338F30", Offset = "0x7337530", VA = "0x187338F30")]
	public HOJPKPGNFKK(IEnumerator<FEEHCBLGINO> FGKBGBIHHDH, FHOALECEGJA CAMDIODFJJE, OBPOCJPDMON FKOKIPEHFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7338990", Offset = "0x7336F90", VA = "0x187338990")]
	public FEEHCBLGINO JHNOAMEJJEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7338850", Offset = "0x7336E50", VA = "0x187338850")]
	public bool DAGOALGEEPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x73388C0", Offset = "0x7336EC0", VA = "0x1873388C0")]
	public void FAIEPBCECII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7338E50", Offset = "0x7337450", VA = "0x187338E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xAAF940", Offset = "0xAADF40", VA = "0x180AAF940")]
	[CompilerGenerated]
	private void IEMDOIBAGDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class OBPOCJPDMON : KMDKGGBBLAI, EKNCDBKDOPI, EFOPDINOAPF, GJFFIMHAENI, IEnumerator, FEEHCBLGINO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private JLPIFGMKEPF KNEEGJJBICM;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private JLPIFGMKEPF LOKINFNOAMD
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x105C050", Offset = "0x105A650", VA = "0x18105C050", Slot = "23")]
		get
		{
			return default(JLPIFGMKEPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public JLPIFGMKEPF AMIMNLGNICO
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x15984C0", Offset = "0x1596AC0", VA = "0x1815984C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private float CLLIJOHFCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xA21990", Offset = "0xA1FF90", VA = "0x180A21990", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool PBCAECFGGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x73464C0", Offset = "0x7344AC0", VA = "0x1873464C0", Slot = "24")]
	private bool NAMJMKOFIKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x73464B0", Offset = "0x7344AB0", VA = "0x1873464B0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x73464E0", Offset = "0x7344AE0", VA = "0x1873464E0")]
	public OBPOCJPDMON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal enum IFFIFNKEBAE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal sealed class OGOMMLFKPJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum GJICMNMGPCH
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public struct IPFBLOCEAFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public JLPIFGMKEPF PAOIKCFDJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GJICMNMGPCH CBKMJOBFAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<HOJPKPGNFKK> CPJAMMAGGDA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly GJICMNMGPCH[] HKBCMKLNCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly JLPIFGMKEPF IEIDKHEINJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private bool JMAMDJNPAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly HOJPKPGNFKK[] DMJDCHOIONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<HOJPKPGNFKK> LMADKFNIBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<int> CELGGJOEAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly List<HOJPKPGNFKK> JFOEMAIELAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Stack<int> CDPFPAMODAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly DOECMOPOCPI MPGPDDMDENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private bool HMDMCDIHCMB;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public IPFBLOCEAFB[,] HJDJBIKJOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x868CC0", Offset = "0x8672C0", VA = "0x180868CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7347A60", Offset = "0x7346060", VA = "0x187347A60")]
	public OGOMMLFKPJK(JLPIFGMKEPF FJIGDOHKAPF, DOECMOPOCPI MPGPDDMDENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7347150", Offset = "0x7345750", VA = "0x187347150")]
	public void LDKHJGPHLOF(HOJPKPGNFKK FGKBGBIHHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7346840", Offset = "0x7344E40", VA = "0x187346840")]
	public void DEEPLLCAHOG(IList<HOJPKPGNFKK> KFGMNEAHJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7346530", Offset = "0x7344B30", VA = "0x187346530")]
	public void CLELIGAMLEC(IList<HOJPKPGNFKK> KFGMNEAHJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7347260", Offset = "0x7345860", VA = "0x187347260")]
	private void MADOAFCPGDP(HOJPKPGNFKK FGKBGBIHHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7347350", Offset = "0x7345950", VA = "0x187347350")]
	private void NHALALGLGCJ(IList<HOJPKPGNFKK> KFGMNEAHJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7346FD0", Offset = "0x73455D0", VA = "0x187346FD0")]
	private IFFIFNKEBAE KCIKAPGONCG(HOJPKPGNFKK FGKBGBIHHDH)
	{
		return default(IFFIFNKEBAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7346E60", Offset = "0x7345460", VA = "0x187346E60")]
	public void JPIODFAGAAF(float GDHFBKFAMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7346C70", Offset = "0x7345270", VA = "0x187346C70")]
	public void GCIJCEDEHJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7347620", Offset = "0x7345C20", VA = "0x187347620")]
	private void PBCNMPGGGBD(List<HOJPKPGNFKK> KFGMNEAHJDA, Stack<int> PBGCODBMFCL, bool AEOODPBKIBG, float ACIAHEEGLDO = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7346B50", Offset = "0x7345150", VA = "0x187346B50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x73474E0", Offset = "0x7345AE0", VA = "0x1873474E0")]
	private void OMCOHMFBBDH(List<HOJPKPGNFKK> KFGMNEAHJDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class GDCPLIBDMBL : DOECMOPOCPI
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "4")]
	public void FHKHGECKNCB(string GJEDHMJMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
	public void LBLNKAKGEGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public GDCPLIBDMBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class PJEKNEMEGMD : FHOALECEGJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly Behaviour IFGDBEFLMIB;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string OABCLOFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7349B70", Offset = "0x7348170", VA = "0x187349B70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool KEFAIPMPDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7349B20", Offset = "0x7348120", VA = "0x187349B20", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool CKEDPHEIBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7349BF0", Offset = "0x73481F0", VA = "0x187349BF0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	public PJEKNEMEGMD(Behaviour IFGDBEFLMIB)
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

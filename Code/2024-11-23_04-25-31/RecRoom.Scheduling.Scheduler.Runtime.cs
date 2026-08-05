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
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
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
namespace _LogRegistration.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : IGBHOMLLHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7782110", Offset = "0x7780B10", VA = "0x187782110", Slot = "4")]
		public override void KFMGLABNFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7787020", Offset = "0x7785A20", VA = "0x187787020", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private delegate List<PlayerLoopSystem> OACHBNKEIHD(List<PlayerLoopSystem> AHBLJEMHHPF, int KMKJFFAPECN);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct CHCIBCJDBCF
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct GJPLCAMNCMC
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static APNHDGDPKOI ODHOLJNFDMN;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x7778CD0", Offset = "0x77776D0", VA = "0x187778CD0")]
				public static PlayerLoopSystem HODJHEMDEJL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct FIBBGNDBKEK
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static APNHDGDPKOI JFGHHLLLBIN;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x7775860", Offset = "0x7774260", VA = "0x187775860")]
				public static PlayerLoopSystem HODJHEMDEJL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct GAIGAOBKPHP
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static APNHDGDPKOI LPNAFHLAGJI;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x7778120", Offset = "0x7776B20", VA = "0x187778120")]
				public static PlayerLoopSystem HODJHEMDEJL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct GPJKJKPJNJK
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static APNHDGDPKOI GBFJJGMIDDK;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static APNHDGDPKOI FMFDALJICKB;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static APNHDGDPKOI CHKLCFJPKOF;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static APNHDGDPKOI JGKIBNLAGPH;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x77791B0", Offset = "0x7777BB0", VA = "0x1877791B0")]
				public static PlayerLoopSystem HODJHEMDEJL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct KNJJAAMKCEO
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static APNHDGDPKOI GLFGMKJFOIK;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x7781160", Offset = "0x777FB60", VA = "0x187781160")]
				public static PlayerLoopSystem HODJHEMDEJL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct IIAPKENBEKE
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static APNHDGDPKOI GBFJJGMIDDK;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static APNHDGDPKOI FMFDALJICKB;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static APNHDGDPKOI CHKLCFJPKOF;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static APNHDGDPKOI JGKIBNLAGPH;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x777B0C0", Offset = "0x7779AC0", VA = "0x18777B0C0")]
				public static PlayerLoopSystem HODJHEMDEJL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct MCLADFHBCIL
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static APNHDGDPKOI HOCICICPNBF;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x7782250", Offset = "0x7780C50", VA = "0x187782250")]
				public static PlayerLoopSystem HODJHEMDEJL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct PPLCJHLGADB
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static APNHDGDPKOI CEOFCGPDIGN;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7785D30", Offset = "0x7784730", VA = "0x187785D30")]
				public static PlayerLoopSystem HODJHEMDEJL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct JHBDECLIEJO
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static APNHDGDPKOI KPPAHEGIDHM;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x777BE90", Offset = "0x777A890", VA = "0x18777BE90")]
				public static PlayerLoopSystem HODJHEMDEJL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct EHAIGPAKBIG
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static APNHDGDPKOI PKKLHMAFGEI;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x7774C70", Offset = "0x7773670", VA = "0x187774C70")]
				public static PlayerLoopSystem HODJHEMDEJL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct EMCEOGNDPAL
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static APNHDGDPKOI IPLMNPEEIEF;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x7774E90", Offset = "0x7773890", VA = "0x187774E90")]
				public static PlayerLoopSystem HODJHEMDEJL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct PBGIEGAJNGK
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static APNHDGDPKOI BKEEONECFEJ;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x7785300", Offset = "0x7783D00", VA = "0x187785300")]
				public static PlayerLoopSystem HODJHEMDEJL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct KAIOKAJNFLI
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static APNHDGDPKOI FJCENCCKJBA;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x777FB70", Offset = "0x777E570", VA = "0x18777FB70")]
				public static PlayerLoopSystem HODJHEMDEJL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct LPOKPFOLFJA
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static APNHDGDPKOI HKKNJAAHAJE;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x7781F30", Offset = "0x7780930", VA = "0x187781F30")]
				public static PlayerLoopSystem HODJHEMDEJL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct HPKJCGKMPPA
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static APNHDGDPKOI HNFAFPPCLAG;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x777AC40", Offset = "0x7779640", VA = "0x18777AC40")]
				public static PlayerLoopSystem HODJHEMDEJL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum ANCEJLPACDD : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			public struct IMMJLFLDKMN
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class DAMEFOOOKBN
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public ANCEJLPACDD updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
					public DAMEFOOOKBN()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x7774550", Offset = "0x7772F50", VA = "0x187774550")]
					internal void IEJCNBECELN()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static ABIBNEMCANM<ANCEJLPACDD> PAIKEIENEIA;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x777B390", Offset = "0x7779D90", VA = "0x18777B390")]
				public static PlayerLoopSystem HODJHEMDEJL(ANCEJLPACDD HPLEFIOBNEP)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct KMMGGFLDFDD
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class PLLNCICHMHK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public HOEAKKMBNIL.HCFIJNBKBAK key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
					public PLLNCICHMHK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x7785AB0", Offset = "0x77844B0", VA = "0x187785AB0")]
					internal void IOLOAKMAECG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable MKDEJFEMGII;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7781030", Offset = "0x777FA30", VA = "0x187781030")]
				public static PlayerLoopSystem KJCLAGJLNCI(HOEAKKMBNIL.HCFIJNBKBAK PNABAFEIDND)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct PKNLLMBAMLH
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class PFPIGJHFFJH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public HOEAKKMBNIL.HCFIJNBKBAK key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
					public PFPIGJHFFJH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x77855B0", Offset = "0x7783FB0", VA = "0x1877855B0")]
					internal void IOLOAKMAECG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7785980", Offset = "0x7784380", VA = "0x187785980")]
				public static PlayerLoopSystem KJCLAGJLNCI(HOEAKKMBNIL.HCFIJNBKBAK PNABAFEIDND)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class PJDJKPAHAOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public PJDJKPAHAOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7785860", Offset = "0x7784260", VA = "0x187785860")]
			internal List<PlayerLoopSystem> OBCGGJFDPNH(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool EPNLMPHPCAH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool PEMPDDGJHED
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x77712C0", Offset = "0x776FCC0", VA = "0x1877712C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7771300", Offset = "0x776FD00", VA = "0x187771300")]
		private static void MEBEKAOJBEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x77709B0", Offset = "0x776F3B0", VA = "0x1877709B0")]
		private static void FCFPEEGEMDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7770680", Offset = "0x776F080", VA = "0x187770680")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7774310", Offset = "0x7772D10", VA = "0x187774310")]
		private static void NFOGOFFHDLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x77706C0", Offset = "0x776F0C0", VA = "0x1877706C0")]
		private static void DLONKDKAOPH(HOEAKKMBNIL.HCFIJNBKBAK PNABAFEIDND, PlayerLoopSystem KOHIGAGJODI, Type KDLOOEJBOIJ, Type PFGMNEGHOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x77702A0", Offset = "0x776ECA0", VA = "0x1877702A0")]
		private static void AHPJFJLGHAH(PlayerLoopSystem KOHIGAGJODI, Type KDLOOEJBOIJ, Type PFGMNEGHOKA, OACHBNKEIHD OLGJOLPFGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7770880", Offset = "0x776F280", VA = "0x187770880")]
		private static void EKADCPCHAKC(PlayerLoopSystem KOHIGAGJODI, Type KDLOOEJBOIJ, Type PFGMNEGHOKA, PlayerLoopSystem? CNHIPFHAHAI, PlayerLoopSystem? PAIIJDBLHKD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HOEAKKMBNIL
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum HCFIJNBKBAK
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		OMPrePhysicsFixedUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class CPEPNPJDENH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly HCFIJNBKBAK POJPHOJOHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly IFAJOCDMDMO JKBLCEHNGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long HAJMNDGLBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long DIIFMNKJGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long PBCBJLIDNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int CEJEIDEMHMP;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7770190", Offset = "0x776EB90", VA = "0x187770190")]
		public CPEPNPJDENH(HCFIJNBKBAK KOGHHEFGMHO, int FHCHEODPLFK = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7770120", Offset = "0x776EB20", VA = "0x187770120")]
		public void FGHFOLFGJHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x776FEF0", Offset = "0x776E8F0", VA = "0x18776FEF0")]
		public void DDCAJOMLABA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x776FF40", Offset = "0x776E940", VA = "0x18776FF40")]
		public void DKPALGIPPBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static HCFIJNBKBAK[] IBIKGIJLNGO;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static CPEPNPJDENH[] LFOLDIOJDCB;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x777A8D0", Offset = "0x77792D0", VA = "0x18777A8D0")]
	public static CPEPNPJDENH PJHCCLIMIOF(HCFIJNBKBAK PNABAFEIDND, int FHCHEODPLFK = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x777A860", Offset = "0x7779260", VA = "0x18777A860")]
	public static CPEPNPJDENH EKLNNHEKEFA(HCFIJNBKBAK PNABAFEIDND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x777A7C0", Offset = "0x77791C0", VA = "0x18777A7C0")]
	public static void BJGFDLOKION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class IFAJOCDMDMO : MBPCHOOCNHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int MPOLBHEELEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Queue<double> EJAIELEHLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double LAJFHIPPBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double APMEFBMNAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double KFMKPDJADPC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double FNOBIIMGEGG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x777AE90", Offset = "0x7779890", VA = "0x18777AE90", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double HAEDELAGDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4412CE0", Offset = "0x44116E0", VA = "0x184412CE0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double LAJOPINDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x222BED0", Offset = "0x222A8D0", VA = "0x18222BED0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x777B010", Offset = "0x7779A10", VA = "0x18777B010")]
	public IFAJOCDMDMO(int LFFEILAIOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x777AEF0", Offset = "0x77798F0", VA = "0x18777AEF0", Slot = "7")]
	public void PHMFJILNMCO(double JBKDPHAINMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x777AE20", Offset = "0x7779820", VA = "0x18777AE20", Slot = "8")]
	public void ENPPBKGKMKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class EGDDCMDNGKF : MBPCHOOCNHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private long FPDJICFHLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private double HHDBMFNPHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private double NADCDBMCBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private double NAJEMLMEKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private double BNOILMAPOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private double LAJFHIPPBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private double APMEFBMNAML;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double HAEDELAGDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6330A70", Offset = "0x632F470", VA = "0x186330A70", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double LAJOPINDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9442B0", Offset = "0x942CB0", VA = "0x1809442B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double CMDLJGNENFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6330AA0", Offset = "0x632F4A0", VA = "0x186330AA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FNOBIIMGEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2871E50", Offset = "0x2870850", VA = "0x182871E50", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7774B10", Offset = "0x7773510", VA = "0x187774B10", Slot = "7")]
	public virtual void PHMFJILNMCO(double JBKDPHAINMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7774AD0", Offset = "0x77734D0", VA = "0x187774AD0", Slot = "8")]
	public virtual void ENPPBKGKMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7774740", Offset = "0x7773140", VA = "0x187774740")]
	public EGDDCMDNGKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class DLHGNHCJCNM : EGDDCMDNGKF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double AMAKAFEMKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6330B00", Offset = "0x632F500", VA = "0x186330B00")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6330AC0", Offset = "0x632F4C0", VA = "0x186330AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7774610", Offset = "0x7773010", VA = "0x187774610", Slot = "7")]
	public override void PHMFJILNMCO(double JBKDPHAINMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x77745D0", Offset = "0x7772FD0", VA = "0x1877745D0", Slot = "8")]
	public override void ENPPBKGKMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7774740", Offset = "0x7773140", VA = "0x187774740")]
	public DLHGNHCJCNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface MBPCHOOCNHF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double FNOBIIMGEGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double HAEDELAGDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double LAJOPINDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class FDIGPLHAIOB
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private interface CMLCIFDFKPO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool BHPBOEHBDLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BFPGNFDAILF();
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class BEICAOGIDPM : CMLCIFDFKPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly Action EFFBNJEBEKP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool BHPBOEHBDLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
		public BEICAOGIDPM(Action EFFBNJEBEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xC8F420", Offset = "0xC8DE20", VA = "0x180C8F420", Slot = "5")]
		public void BFPGNFDAILF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly List<CMLCIFDFKPO> ICOCBHBEFEB;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7775280", Offset = "0x7773C80", VA = "0x187775280")]
	public static void JOAHPJLEPAH(Action EFFBNJEBEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7775070", Offset = "0x7773A70", VA = "0x187775070")]
	private static void IJNPCPKNLEL(CMLCIFDFKPO JKAJPHEPPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7775320", Offset = "0x7773D20", VA = "0x187775320")]
	private static void LHPKGKIIFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7775600", Offset = "0x7774000", VA = "0x187775600")]
	private static void OHKDPCHBBHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7775700", Offset = "0x7774100", VA = "0x187775700")]
	private static void PBGBIFBBMCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CMJLDCMILBG
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private struct ABDOENFKEHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public TaskCompletionSource<Scene> JIOIMHCGPJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly string DNDEFCJDLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly LoadSceneMode KENOLHLMGMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly bool JGLGJDPAMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7769FD0", Offset = "0x77689D0", VA = "0x187769FD0")]
		public ABDOENFKEHP(TaskCompletionSource<Scene> CEEEEOELLLH, string DNDEFCJDLEP, LoadSceneMode KENOLHLMGMD, bool JGLGJDPAMFJ, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct KMDHPAAJJBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private FILMNPNNHPJ<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7780720", Offset = "0x777F120", VA = "0x187780720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7780FC0", Offset = "0x777F9C0", VA = "0x187780FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct MKOCMHMAILJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7782B20", Offset = "0x7781520", VA = "0x187782B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7782E30", Offset = "0x7781830", VA = "0x187782E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct BAEKGGKMIMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private ABDOENFKEHP <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x776B0E0", Offset = "0x7769AE0", VA = "0x18776B0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x776B4A0", Offset = "0x7769EA0", VA = "0x18776B4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CFJBJABLCNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public OJMLFMJDPKF<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public CFJBJABLCNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x776BD40", Offset = "0x776A740", VA = "0x18776BD40")]
		internal void FIPFMPFACNH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct COFOOEHLDAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private CFJBJABLCNP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x776F2E0", Offset = "0x776DCE0", VA = "0x18776F2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x776FE80", Offset = "0x776E880", VA = "0x18776FE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct CCDFAACIFPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private HIEPCOOLPHO <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x776B500", Offset = "0x7769F00", VA = "0x18776B500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x776BBC0", Offset = "0x776A5C0", VA = "0x18776BBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct HMLJMCLBINC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7779C30", Offset = "0x7778630", VA = "0x187779C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x777A750", Offset = "0x7779150", VA = "0x18777A750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class NPIGCPNCFDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public NPIGCPNCFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7785040", Offset = "0x7783A40", VA = "0x187785040")]
		internal bool LOPCOEHJHIC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class INFKIMFEOGF : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public EMDNAJFOAMA onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public INFKIMFEOGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x777B930", Offset = "0x777A330", VA = "0x18777B930", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x777B5A0", Offset = "0x7779FA0", VA = "0x18777B5A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x777B550", Offset = "0x7779F50", VA = "0x18777B550")]
		private void BFPHAGOPJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x777B8E0", Offset = "0x777A2E0", VA = "0x18777B8E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class JJFMBKICBKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public OJMLFMJDPKF<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public JJFMBKICBKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x777C070", Offset = "0x777AA70", VA = "0x18777C070")]
		internal bool AKIAIKNEOAG(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x777C0F0", Offset = "0x777AAF0", VA = "0x18777C0F0")]
		internal void LDAJKMKCAJJ(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class KIFGDKINICG : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public OJMLFMJDPKF<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private JJFMBKICBKL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private HIEPCOOLPHO <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public KIFGDKINICG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x77806C0", Offset = "0x777F0C0", VA = "0x1877806C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x777FD70", Offset = "0x777E770", VA = "0x18777FD70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x777FD50", Offset = "0x777E750", VA = "0x18777FD50")]
		private void BFPHAGOPJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7780670", Offset = "0x777F070", VA = "0x187780670", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly ICollection<string> ELIFBHKCOLM;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static HGKKEBPLLAP LMJGOKLPLJO;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static AsyncOperation NCHHJLDBLKE;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static HGKKEBPLLAP DFEFJDFGAPB;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static string NEIEFFEHMAJ;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static string JDDPCNKLPIE;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static ThreadPriority LGPLENDMFAO;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Task JNDGPLKIABP;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static List<SceneInstance> IAOIBAKJCAA;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly Queue<ABDOENFKEHP> OJMBFMMCKAL;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static Task JCNPOHEPEKP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool HBICDANFDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x776E530", Offset = "0x776CF30", VA = "0x18776E530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private static bool JNMCKEFEBKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x776EB90", Offset = "0x776D590", VA = "0x18776EB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private static bool EJJIJKOGJPG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x776F030", Offset = "0x776DA30", VA = "0x18776F030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool GDIEGJELJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x776E2A0", Offset = "0x776CCA0", VA = "0x18776E2A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> LNDNLCKEFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x776EA80", Offset = "0x776D480", VA = "0x18776EA80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x776E740", Offset = "0x776D140", VA = "0x18776E740")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x776DA50", Offset = "0x776C450", VA = "0x18776DA50")]
	[MDNJIPDCAGH(CHEIGNPGAPJ.EnteredEditModeNextFrame, 0)]
	private static void BJOGJAGGGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x776E020", Offset = "0x776CA20", VA = "0x18776E020")]
	[AsyncStateMachine(typeof(KMDHPAAJJBO))]
	public static Task<Scene> CLEHANIPHGF(string DNDEFCJDLEP, LoadSceneMode KENOLHLMGMD = LoadSceneMode.Single, bool JGLGJDPAMFJ = false, [Optional] FILMNPNNHPJ<string>.EEFAEMIIABD AENKPJJJGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x776E9D0", Offset = "0x776D3D0", VA = "0x18776E9D0")]
	[AsyncStateMachine(typeof(MKOCMHMAILJ))]
	private static Task IMAPPDEKGHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x776E330", Offset = "0x776CD30", VA = "0x18776E330")]
	[AsyncStateMachine(typeof(BAEKGGKMIMD))]
	private static Task FBOOGIBPFHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x776EEE0", Offset = "0x776D8E0", VA = "0x18776EEE0")]
	[AsyncStateMachine(typeof(COFOOEHLDAK))]
	private static Task<Scene> MOGDKDABDEF(string DNDEFCJDLEP, LoadSceneMode KENOLHLMGMD, bool JGLGJDPAMFJ, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x776D830", Offset = "0x776C230", VA = "0x18776D830")]
	private static void BGKOKNPOGEB(SceneInstance NGPNBABCJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x776EC30", Offset = "0x776D630", VA = "0x18776EC30")]
	private static void LPKLGENFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x776E400", Offset = "0x776CE00", VA = "0x18776E400")]
	[AsyncStateMachine(typeof(CCDFAACIFPA))]
	private static Task<Scene> GNIMOFBINDH(string DNDEFCJDLEP, LoadSceneMode KENOLHLMGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x776DE00", Offset = "0x776C800", VA = "0x18776DE00")]
	private static bool CAOOBLINLLH(string DNDEFCJDLEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x776D940", Offset = "0x776C340", VA = "0x18776D940")]
	[AsyncStateMachine(typeof(HMLJMCLBINC))]
	private static Task<Scene> BHCGKCFCJPG(FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x776E850", Offset = "0x776D250", VA = "0x18776E850")]
	public static BJOGDIODDMJ<Scene> IGEPKIAFPPL(string DNDEFCJDLEP, LoadSceneMode KENOLHLMGMD = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x776DB40", Offset = "0x776C540", VA = "0x18776DB40")]
	public static HGKKEBPLLAP BLLJHOLNDJP(string DNDEFCJDLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x776E210", Offset = "0x776CC10", VA = "0x18776E210")]
	[IteratorStateMachine(typeof(INFKIMFEOGF))]
	private static IEnumerator<BGFOJNANPKN> ECOCMLIHDOO(string DNDEFCJDLEP, EMDNAJFOAMA JMLIBJOEIAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x776E170", Offset = "0x776CB70", VA = "0x18776E170")]
	[IteratorStateMachine(typeof(KIFGDKINICG))]
	private static IEnumerator<BGFOJNANPKN> ECIHFDNJPBM(string DNDEFCJDLEP, LoadSceneMode KENOLHLMGMD, OJMLFMJDPKF<Scene> JMLIBJOEIAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x776DEF0", Offset = "0x776C8F0", VA = "0x18776DEF0")]
	public static bool CEKLAJMMHEL([Out] string HHJAFEPLBBG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class NIPEGOELOKI
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7783C00", Offset = "0x7782600", VA = "0x187783C00")]
	public static IDisposable BLJAOBIFAGB(this KIADIIPNNBC KMDNOIPDFGB, float HACBMKGLNMP, Action<float> LOHIBOAOLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7783C90", Offset = "0x7782690", VA = "0x187783C90")]
	public static IDisposable GMAKJHIJOFO(this KIADIIPNNBC KMDNOIPDFGB, Action<float> LOHIBOAOLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7783D10", Offset = "0x7782710", VA = "0x187783D10")]
	public static IDisposable MMMBHIBGFEH(this KIADIIPNNBC KMDNOIPDFGB, Action<float> LOHIBOAOLNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class APHFHPGNFGO
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x776AFC0", Offset = "0x77699C0", VA = "0x18776AFC0")]
	public static IDisposable OLEBJFHKEHO(this MonoBehaviour LBAMDLBMFIH, Action LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x776B050", Offset = "0x7769A50", VA = "0x18776B050")]
	public static IDisposable OLEBJFHKEHO(this MonoBehaviour LBAMDLBMFIH, Action<float> LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x776AA90", Offset = "0x7769490", VA = "0x18776AA90")]
	public static IDisposable HIEHKMNLIKI(this MonoBehaviour LBAMDLBMFIH, Action LOHIBOAOLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x776AD70", Offset = "0x7769770", VA = "0x18776AD70")]
	public static IDisposable KDEKFHPGMLG(this MonoBehaviour LBAMDLBMFIH, Action LOHIBOAOLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x776ADF0", Offset = "0x77697F0", VA = "0x18776ADF0")]
	public static IDisposable KDEKFHPGMLG(this MonoBehaviour LBAMDLBMFIH, Action<float> LOHIBOAOLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x776A6E0", Offset = "0x77690E0", VA = "0x18776A6E0")]
	public static IDisposable CFEAHDHNPGA(this MonoBehaviour LBAMDLBMFIH, Action LOHIBOAOLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x776AA10", Offset = "0x7769410", VA = "0x18776AA10")]
	public static IDisposable GCFAJAMLHAF(this MonoBehaviour LBAMDLBMFIH, Action LOHIBOAOLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x776AC50", Offset = "0x7769650", VA = "0x18776AC50")]
	public static IDisposable ILBMHFHEBNB(this MonoBehaviour LBAMDLBMFIH, Action LOHIBOAOLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x776AE70", Offset = "0x7769870", VA = "0x18776AE70")]
	public static IDisposable MAIJKPKBMPP(this MonoBehaviour LBAMDLBMFIH, float HACBMKGLNMP, Action<float> LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA, bool LHBNGGJIJPI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x776A940", Offset = "0x7769340", VA = "0x18776A940")]
	public static IDisposable FEDNHAPAJMI(this MonoBehaviour LBAMDLBMFIH, float HACBMKGLNMP, Action<float> LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA, bool LHBNGGJIJPI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x776AF20", Offset = "0x7769920", VA = "0x18776AF20")]
	public static IDisposable MGHIKFKLOHO(this MonoBehaviour LBAMDLBMFIH, float HACBMKGLNMP, Action<float> LOHIBOAOLNP, bool LHBNGGJIJPI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x776ABB0", Offset = "0x77695B0", VA = "0x18776ABB0")]
	public static IDisposable IHNKNGHJEDD(this MonoBehaviour LBAMDLBMFIH, Action<float> LOHIBOAOLNP, bool LHBNGGJIJPI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x776A970", Offset = "0x7769370", VA = "0x18776A970")]
	public static IDisposable FIFGHHJOPDN(this MonoBehaviour LBAMDLBMFIH, Action<float> LOHIBOAOLNP, bool LHBNGGJIJPI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x776AB10", Offset = "0x7769510", VA = "0x18776AB10")]
	public static IDisposable HJDGBGJOMOC(this MonoBehaviour LBAMDLBMFIH, Action<float> LOHIBOAOLNP, bool LHBNGGJIJPI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x776A760", Offset = "0x7769160", VA = "0x18776A760")]
	public static IDisposable CGHELDKHLLM(this MonoBehaviour LBAMDLBMFIH, Action<float> LOHIBOAOLNP, bool LHBNGGJIJPI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x776A640", Offset = "0x7769040", VA = "0x18776A640")]
	public static IDisposable CBPEDNGNLFE(this MonoBehaviour LBAMDLBMFIH, Action<float> LOHIBOAOLNP, bool LHBNGGJIJPI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x776A8A0", Offset = "0x77692A0", VA = "0x18776A8A0")]
	public static IDisposable EODNGMEJBKD(this MonoBehaviour LBAMDLBMFIH, Action<float> LOHIBOAOLNP, bool LHBNGGJIJPI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x776A800", Offset = "0x7769200", VA = "0x18776A800")]
	public static IDisposable DONEHKEAJOH(this MonoBehaviour LBAMDLBMFIH, Action<float> LOHIBOAOLNP, bool LHBNGGJIJPI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x776A590", Offset = "0x7768F90", VA = "0x18776A590")]
	public static IDisposable ALCHNLBMIFH(this MonoBehaviour LBAMDLBMFIH, float HACBMKGLNMP, Action<float> LOHIBOAOLNP, bool LHBNGGJIJPI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x776ACD0", Offset = "0x77696D0", VA = "0x18776ACD0")]
	public static IDisposable IPFAGEOPFFB(this MonoBehaviour LBAMDLBMFIH, Action<float> LOHIBOAOLNP, bool LHBNGGJIJPI = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class LDDIKGOMKAN
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class FLLFKIOIALI : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public LICPEHAGMGN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private JMHHOOGALDL <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public FLLFKIOIALI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x77762F0", Offset = "0x7774CF0", VA = "0x1877762F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x77763D0", Offset = "0x7774DD0", VA = "0x1877763D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class NLCAHCDOOJF : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public LICPEHAGMGN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private JMHHOOGALDL <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public NLCAHCDOOJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7783D90", Offset = "0x7782790", VA = "0x187783D90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7783E80", Offset = "0x7782880", VA = "0x187783E80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7781640", Offset = "0x7780040", VA = "0x187781640")]
	public static OIMBFIPCENK OLEBJFHKEHO(Action LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x77817A0", Offset = "0x77801A0", VA = "0x1877817A0")]
	public static OIMBFIPCENK OLEBJFHKEHO(Behaviour KMDNOIPDFGB, Action LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x77816C0", Offset = "0x77800C0", VA = "0x1877816C0")]
	public static OIMBFIPCENK OLEBJFHKEHO(Behaviour KMDNOIPDFGB, Action<float> LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x77815B0", Offset = "0x777FFB0", VA = "0x1877815B0")]
	[IteratorStateMachine(typeof(FLLFKIOIALI))]
	private static IEnumerator<BGFOJNANPKN> MNHJIPOJJBM(LICPEHAGMGN LFDHLEDCOLJ, Action LOHIBOAOLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7781520", Offset = "0x777FF20", VA = "0x187781520")]
	[IteratorStateMachine(typeof(NLCAHCDOOJF))]
	private static IEnumerator<BGFOJNANPKN> MNHJIPOJJBM(LICPEHAGMGN LFDHLEDCOLJ, Action<float> LOHIBOAOLNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class GNEBAIAIBCM : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class HBMLIICPEHF : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public GNEBAIAIBCM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public HBMLIICPEHF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7779480", Offset = "0x7777E80", VA = "0x187779480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7779510", Offset = "0x7777F10", VA = "0x187779510", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly LICPEHAGMGN FDFLGBPAPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Action GENELLBDBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool IKKCMMKBNOI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool OEMBJOBGAJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8B0220", Offset = "0x8AEC20", VA = "0x1808B0220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7778FD0", Offset = "0x77779D0", VA = "0x187778FD0")]
	public GNEBAIAIBCM(LICPEHAGMGN FDFLGBPAPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7778EB0", Offset = "0x77778B0", VA = "0x187778EB0")]
	[IteratorStateMachine(typeof(HBMLIICPEHF))]
	private IEnumerator<BGFOJNANPKN> EFOHLFCAINO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7778F30", Offset = "0x7777930", VA = "0x187778F30", Slot = "4")]
	public void OnCompleted(Action LGCHAKDNBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
	public void JGNMEKLNHNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class CCOANMHLJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x776BC30", Offset = "0x776A630", VA = "0x18776BC30")]
	public static GNEBAIAIBCM IFHANBOIBIK(this LICPEHAGMGN FDFLGBPAPAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class LGLDLDPPPEE
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class GPHDCAAMABM : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public EKHAEGJGPEK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public GPHDCAAMABM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x77790E0", Offset = "0x7777AE0", VA = "0x1877790E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7779160", Offset = "0x7777B60", VA = "0x187779160", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7781BA0", Offset = "0x77805A0", VA = "0x187781BA0")]
	public static OIMBFIPCENK OLEBJFHKEHO(float HACBMKGLNMP, Action<float> LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA, bool LHBNGGJIJPI = true, [Optional] MAADJEHCAPM MMJPGOGMMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7781C70", Offset = "0x7780670", VA = "0x187781C70")]
	public static OIMBFIPCENK OLEBJFHKEHO(MonoBehaviour LBAMDLBMFIH, float HACBMKGLNMP, Action<float> LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA, bool LHBNGGJIJPI = true, [Optional] MAADJEHCAPM MMJPGOGMMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7781830", Offset = "0x7780230", VA = "0x187781830")]
	public static OIMBFIPCENK AJAFKPKJFAL(MonoBehaviour LBAMDLBMFIH, float HACBMKGLNMP, Action<float> LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA, bool LHBNGGJIJPI = true, [Optional] MAADJEHCAPM MMJPGOGMMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7781A40", Offset = "0x7780440", VA = "0x187781A40")]
	public static OIMBFIPCENK MPPLFGBJACF(KIADIIPNNBC KMDNOIPDFGB, float HACBMKGLNMP, Action<float> LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA, bool LHBNGGJIJPI = true, [Optional] MAADJEHCAPM MMJPGOGMMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7781980", Offset = "0x7780380", VA = "0x187781980")]
	private static IEnumerator<BGFOJNANPKN> MNHJIPOJJBM(AEGEHFMLOMF CPDHHLHFIEP, float HACBMKGLNMP, LICPEHAGMGN LFDHLEDCOLJ, Action<float> LOHIBOAOLNP, bool LHBNGGJIJPI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7781920", Offset = "0x7780320", VA = "0x187781920")]
	private static IEnumerator<BGFOJNANPKN> IFEMKFEAHLK(AEGEHFMLOMF CPDHHLHFIEP, float HACBMKGLNMP, LICPEHAGMGN LFDHLEDCOLJ, Action<float> LOHIBOAOLNP, bool LHBNGGJIJPI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7781B10", Offset = "0x7780510", VA = "0x187781B10")]
	[IteratorStateMachine(typeof(GPHDCAAMABM))]
	private static IEnumerator<BGFOJNANPKN> NKDDLLJKJAJ(EKHAEGJGPEK BJLHCHJPCDJ, float HACBMKGLNMP, LICPEHAGMGN LFDHLEDCOLJ, Action<float> LOHIBOAOLNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class PALLEKEFOOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class JPELMFIHDLC : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public LICPEHAGMGN queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public JPELMFIHDLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x777FA60", Offset = "0x777E460", VA = "0x18777FA60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x777FB20", Offset = "0x777E520", VA = "0x18777FB20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7785270", Offset = "0x7783C70", VA = "0x187785270")]
	[IteratorStateMachine(typeof(JPELMFIHDLC))]
	private static IEnumerator<BGFOJNANPKN> MPKFBJLHDFA(LICPEHAGMGN FDFLGBPAPAA, Func<bool> KPFOFBGGJLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7785190", Offset = "0x7783B90", VA = "0x187785190")]
	public static OIMBFIPCENK MAFIKOEBGCD(this MonoBehaviour LBAMDLBMFIH, Func<bool> KPFOFBGGJLH, LICPEHAGMGN FDFLGBPAPAA = LICPEHAGMGN.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class GFILFOFDKPH
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class KPFAKAFBMPJ : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public LICPEHAGMGN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public KPFAKAFBMPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7781340", Offset = "0x777FD40", VA = "0x187781340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x77813B0", Offset = "0x777FDB0", VA = "0x1877813B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class FOLDDKACKBO : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public LICPEHAGMGN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private BGFOJNANPKN <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public FOLDDKACKBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7778040", Offset = "0x7776A40", VA = "0x187778040", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x77780D0", Offset = "0x7776AD0", VA = "0x1877780D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7778430", Offset = "0x7776E30", VA = "0x187778430")]
	[IteratorStateMachine(typeof(KPFAKAFBMPJ))]
	private static IEnumerator<BGFOJNANPKN> EFOHLFCAINO(float FPEHIEEJIAO, LICPEHAGMGN LFDHLEDCOLJ, Action KAMLMGFPOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x77786B0", Offset = "0x77770B0", VA = "0x1877786B0")]
	[IteratorStateMachine(typeof(FOLDDKACKBO))]
	private static IEnumerator<BGFOJNANPKN> GIOIAMGGHNI(float FPEHIEEJIAO, LICPEHAGMGN LFDHLEDCOLJ, Action KAMLMGFPOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7778A20", Offset = "0x7777420", VA = "0x187778A20")]
	public static IDisposable LADHFIOALOP(this MonoBehaviour LBAMDLBMFIH, float FPEHIEEJIAO, Action KAMLMGFPOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7778C40", Offset = "0x7777640", VA = "0x187778C40")]
	public static OIMBFIPCENK ONCGPNCJDMC(this MonoBehaviour LBAMDLBMFIH, float FPEHIEEJIAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7778930", Offset = "0x7777330", VA = "0x187778930")]
	public static OIMBFIPCENK LADHFIOALOP(this MonoBehaviour LBAMDLBMFIH, float FPEHIEEJIAO, LICPEHAGMGN LFDHLEDCOLJ, Action KAMLMGFPOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7778750", Offset = "0x7777150", VA = "0x187778750")]
	public static OIMBFIPCENK GKAELAMDHOC(this MonoBehaviour LBAMDLBMFIH, Action KAMLMGFPOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7778610", Offset = "0x7777010", VA = "0x187778610")]
	public static OIMBFIPCENK GILNOIOAKJD(this MonoBehaviour LBAMDLBMFIH, Action KAMLMGFPOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7778B00", Offset = "0x7777500", VA = "0x187778B00")]
	public static OIMBFIPCENK MPHLFACCLKE(this MonoBehaviour LBAMDLBMFIH, Action KAMLMGFPOBL, [Optional] MAADJEHCAPM MMJPGOGMMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x77787F0", Offset = "0x77771F0", VA = "0x1877787F0")]
	public static OIMBFIPCENK IMPCMOHHJGH(this MonoBehaviour LBAMDLBMFIH, Action KAMLMGFPOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7778890", Offset = "0x7777290", VA = "0x187778890")]
	public static OIMBFIPCENK KJKKFJKMALK(this MonoBehaviour LBAMDLBMFIH, Action KAMLMGFPOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7778570", Offset = "0x7776F70", VA = "0x187778570")]
	private static OIMBFIPCENK GCAFNHCHHJF(MonoBehaviour LBAMDLBMFIH, LICPEHAGMGN FDFLGBPAPAA, Action KAMLMGFPOBL, [Optional] MAADJEHCAPM MMJPGOGMMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x77783A0", Offset = "0x7776DA0", VA = "0x1877783A0")]
	public static OIMBFIPCENK EFODPBDDLKD(this MonoBehaviour LBAMDLBMFIH, float JLACKEAKEFP, Action KAMLMGFPOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x77784D0", Offset = "0x7776ED0", VA = "0x1877784D0")]
	public static OIMBFIPCENK FGJHKJKIOIP(this MonoBehaviour LBAMDLBMFIH, float JLACKEAKEFP, Action KAMLMGFPOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7778300", Offset = "0x7776D00", VA = "0x187778300")]
	public static OIMBFIPCENK AMDMCNIGDFD(this MonoBehaviour LBAMDLBMFIH, float JLACKEAKEFP, Action KAMLMGFPOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7778BA0", Offset = "0x77775A0", VA = "0x187778BA0")]
	public static OIMBFIPCENK OKADIKPJBPP(this MonoBehaviour LBAMDLBMFIH, float JLACKEAKEFP, Action KAMLMGFPOBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class NAPKCKOMOOK : GDJPPADHBHH, IEnumerable<GDJPPADHBHH>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly List<GDJPPADHBHH> ECPECPDKODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool FJHALIOGMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Action DKCPEAJGCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private bool NHEOOBGFCEB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FIPCONAHCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7783900", Offset = "0x7782300", VA = "0x187783900", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OKBICJCPGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7783380", Offset = "0x7781D80", VA = "0x187783380", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x77832E0", Offset = "0x7781CE0", VA = "0x1877832E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7783B60", Offset = "0x7782560", VA = "0x187783B60")]
	public NAPKCKOMOOK([Optional] Action DKCPEAJGCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7783A30", Offset = "0x7782430", VA = "0x187783A30")]
	public void NOEGDDICEDP(GDJPPADHBHH MLCCFHJFBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7783730", Offset = "0x7782130", VA = "0x187783730")]
	private void FOEKBKDCFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7783720", Offset = "0x7782120", VA = "0x187783720", Slot = "7")]
	public bool EGAPGNLOPEF(bool DEDPJAGPBOL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7783420", Offset = "0x7781E20", VA = "0x187783420", Slot = "8")]
	public bool EGAPGNLOPEF(Action EFFBNJEBEKP, bool DEDPJAGPBOL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7783880", Offset = "0x7782280", VA = "0x187783880", Slot = "9")]
	public IEnumerator<GDJPPADHBHH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7783880", Offset = "0x7782280", VA = "0x187783880", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class EFILGBIBHPE : MGDAGNDPDCD
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class HFAOEDGKNKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public EFILGBIBHPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public HFAOEDGKNKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7779560", Offset = "0x7777F60", VA = "0x187779560")]
		internal void FINCKBBOBEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class OGEDJPJFKNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public EFILGBIBHPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public OGEDJPJFKNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7779560", Offset = "0x7777F60", VA = "0x187779560")]
		internal void AEINAEHFDJO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly float NKEPKPFLJCB;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7774990", Offset = "0x7773390", VA = "0x187774990")]
	public EFILGBIBHPE(Behaviour KMDNOIPDFGB, float NKEPKPFLJCB, [Optional] Action DKCPEAJGCBB, [Optional] MAADJEHCAPM MMJPGOGMMKD, [Optional] AEGEHFMLOMF CPDHHLHFIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7774880", Offset = "0x7773280", VA = "0x187774880", Slot = "9")]
	protected override bool FFNAPMLDPCC(Action EFFBNJEBEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7774770", Offset = "0x7773170", VA = "0x187774770", Slot = "10")]
	protected override bool EHCEFKMPNFN(Action EFFBNJEBEKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface GDJPPADHBHH
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool FIPCONAHCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OKBICJCPGIA;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EGAPGNLOPEF(bool DEDPJAGPBOL = false);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EGAPGNLOPEF(Action EFFBNJEBEKP, bool DEDPJAGPBOL = false);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class MGDAGNDPDCD : GDJPPADHBHH
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class ODLDPDDLOLF : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public MGDAGNDPDCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public ODLDPDDLOLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7785070", Offset = "0x7783A70", VA = "0x187785070", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7785140", Offset = "0x7783B40", VA = "0x187785140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly Behaviour KMDNOIPDFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly Action DKCPEAJGCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private OLPMMAHKODD NINPCENNBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly MAADJEHCAPM MMJPGOGMMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	protected readonly AEGEHFMLOMF CPDHHLHFIEP;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool FIPCONAHCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x1205D10", Offset = "0x1204710", VA = "0x181205D10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OKBICJCPGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x77824D0", Offset = "0x7780ED0", VA = "0x1877824D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7782430", Offset = "0x7780E30", VA = "0x187782430", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x77829F0", Offset = "0x77813F0", VA = "0x1877829F0")]
	protected MGDAGNDPDCD(Behaviour KMDNOIPDFGB, [Optional] Action DKCPEAJGCBB, [Optional] MAADJEHCAPM MMJPGOGMMKD, [Optional] AEGEHFMLOMF CPDHHLHFIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7782570", Offset = "0x7780F70", VA = "0x187782570", Slot = "7")]
	public bool EGAPGNLOPEF(bool DEDPJAGPBOL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x77825D0", Offset = "0x7780FD0", VA = "0x1877825D0", Slot = "8")]
	public bool EGAPGNLOPEF(Action EFFBNJEBEKP, bool DEDPJAGPBOL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool FFNAPMLDPCC(Action EFFBNJEBEKP);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool EHCEFKMPNFN(Action EFFBNJEBEKP);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7782670", Offset = "0x7781070", VA = "0x187782670")]
	protected void GDPENJCBBCH(Action EFFBNJEBEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7782690", Offset = "0x7781090", VA = "0x187782690")]
	protected HGKKEBPLLAP GICOCEEDKEL(float NOMMEIKOKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7782970", Offset = "0x7781370", VA = "0x187782970")]
	private void OMADEAAGDDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x77828E0", Offset = "0x77812E0", VA = "0x1877828E0")]
	[IteratorStateMachine(typeof(ODLDPDDLOLF))]
	private IEnumerator<BGFOJNANPKN> KADMHLLKLGF(float NOMMEIKOKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7782630", Offset = "0x7781030", VA = "0x187782630")]
	[CompilerGenerated]
	private void GBODDADPDND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class NAMEIIBCIME : MGDAGNDPDCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly float MDLJIEFEPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly int CALJMHMCNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly float ENBKFBDJJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly float[] BFELKCBHOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int HPCHGEPBOAL;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7783110", Offset = "0x7781B10", VA = "0x187783110")]
	public NAMEIIBCIME(Behaviour KMDNOIPDFGB, float BGJIGPNDADN, int CALJMHMCNAM, [Optional] Action DKCPEAJGCBB, float ENBKFBDJJOD = 0f, [Optional] MAADJEHCAPM MMJPGOGMMKD, [Optional] AEGEHFMLOMF CPDHHLHFIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "9")]
	protected override bool FFNAPMLDPCC(Action EFFBNJEBEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7782E90", Offset = "0x7781890", VA = "0x187782E90", Slot = "10")]
	protected override bool EHCEFKMPNFN(Action EFFBNJEBEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7783090", Offset = "0x7781A90", VA = "0x187783090")]
	private void JJDPGEJPCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class EKLDGMLLFAG : MGDAGNDPDCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly float NKEPKPFLJCB;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7774990", Offset = "0x7773390", VA = "0x187774990")]
	public EKLDGMLLFAG(Behaviour KMDNOIPDFGB, float NKEPKPFLJCB, [Optional] Action DKCPEAJGCBB, [Optional] MAADJEHCAPM MMJPGOGMMKD, [Optional] AEGEHFMLOMF CPDHHLHFIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "9")]
	protected override bool FFNAPMLDPCC(Action EFFBNJEBEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7774E50", Offset = "0x7773850", VA = "0x187774E50", Slot = "10")]
	protected override bool EHCEFKMPNFN(Action EFFBNJEBEKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class HKCJKNPEEKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class PBGPFOGNHPG : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public PBGPFOGNHPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7781D40", Offset = "0x7780740", VA = "0x187781D40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x77854E0", Offset = "0x7783EE0", VA = "0x1877854E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private OIMBFIPCENK PHGCAFICALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private KIADIIPNNBC KMDNOIPDFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Action<float> ACKJDJKFGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private LICPEHAGMGN FDFLGBPAPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private float DOECFACBAEP;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7779A90", Offset = "0x7778490", VA = "0x187779A90")]
	public HKCJKNPEEKK(KIADIIPNNBC KMDNOIPDFGB, float HACBMKGLNMP, Action<float> LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7779920", Offset = "0x7778320", VA = "0x187779920")]
	private void HAADFDOHJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7779710", Offset = "0x7778110", VA = "0x187779710")]
	private void DJLKDENAKNG(string BHAOKKINJPA, Action CFILLHOJJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x77798A0", Offset = "0x77782A0", VA = "0x1877798A0")]
	[IteratorStateMachine(typeof(PBGPFOGNHPG))]
	private IEnumerator<BGFOJNANPKN> GHNHMKHAMNB(Action CFILLHOJJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7779840", Offset = "0x7778240", VA = "0x187779840", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7779590", Offset = "0x7777F90", VA = "0x187779590")]
	[CompilerGenerated]
	private void BKBPDJEHLBD(string PGCLCKNIGGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public sealed class NMDPCPLMEIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class LMEIIPGACOO : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public LMEIIPGACOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7781D40", Offset = "0x7780740", VA = "0x187781D40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7781DB0", Offset = "0x77807B0", VA = "0x187781DB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private OIMBFIPCENK PHGCAFICALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private MonoBehaviour LBAMDLBMFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private Action LOHIBOAOLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private Action<float> ACKJDJKFGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private LICPEHAGMGN FDFLGBPAPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private float DOECFACBAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private bool LHBNGGJIJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly MAADJEHCAPM MMJPGOGMMKD;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7784B00", Offset = "0x7783500", VA = "0x187784B00")]
	public NMDPCPLMEIH(MonoBehaviour LBAMDLBMFIH, Action LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA, [Optional] MAADJEHCAPM MMJPGOGMMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7784E70", Offset = "0x7783870", VA = "0x187784E70")]
	public NMDPCPLMEIH(MonoBehaviour LBAMDLBMFIH, Action<float> LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA, [Optional] MAADJEHCAPM MMJPGOGMMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7784C90", Offset = "0x7783690", VA = "0x187784C90")]
	public NMDPCPLMEIH(MonoBehaviour LBAMDLBMFIH, float HACBMKGLNMP, Action<float> LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA, bool LHBNGGJIJPI = true, [Optional] MAADJEHCAPM MMJPGOGMMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x936400", Offset = "0x934E00", VA = "0x180936400")]
	private NMDPCPLMEIH(MAADJEHCAPM MMJPGOGMMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7783ED0", Offset = "0x77828D0", VA = "0x187783ED0")]
	internal static NMDPCPLMEIH AAGADMOKNGL(MonoBehaviour LBAMDLBMFIH, float HACBMKGLNMP, Action<float> LOHIBOAOLNP, LICPEHAGMGN FDFLGBPAPAA, bool LHBNGGJIJPI = true, [Optional] MAADJEHCAPM MMJPGOGMMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x77849D0", Offset = "0x77833D0", VA = "0x1877849D0")]
	private void OLEBJFHKEHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x77846C0", Offset = "0x77830C0", VA = "0x1877846C0")]
	private void LBFOIKDPHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x77843A0", Offset = "0x7782DA0", VA = "0x1877843A0")]
	private void HAADFDOHJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7784840", Offset = "0x7783240", VA = "0x187784840")]
	private void MINLAHJEJOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7784190", Offset = "0x7782B90", VA = "0x187784190")]
	private void DJLKDENAKNG(string BHAOKKINJPA, Action CFILLHOJJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7784320", Offset = "0x7782D20", VA = "0x187784320")]
	[IteratorStateMachine(typeof(LMEIIPGACOO))]
	private IEnumerator<BGFOJNANPKN> GHNHMKHAMNB(Action CFILLHOJJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x77842C0", Offset = "0x7782CC0", VA = "0x1877842C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7784630", Offset = "0x7783030", VA = "0x187784630")]
	[CompilerGenerated]
	private void JMCKKIBGABM(string PGCLCKNIGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7784100", Offset = "0x7782B00", VA = "0x187784100")]
	[CompilerGenerated]
	private void AFLACHFGGAK(string PGCLCKNIGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x77845A0", Offset = "0x7782FA0", VA = "0x1877845A0")]
	[CompilerGenerated]
	private void JDAMNLNBNJD(string PGCLCKNIGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7784510", Offset = "0x7782F10", VA = "0x187784510")]
	[CompilerGenerated]
	private void ICCFEINAIEN(string PGCLCKNIGGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[Flags]
internal enum KDCDEODMEHJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class MABPFNJBCIL : AEGEHFMLOMF
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float NDOBNBIBGNC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x77821A0", Offset = "0x7780BA0", VA = "0x1877821A0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float DEEEDHNHDIB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7782220", Offset = "0x7780C20", VA = "0x187782220", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public double DOEJPNCNEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7782230", Offset = "0x7780C30", VA = "0x187782230", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x77821B0", Offset = "0x7780BB0", VA = "0x1877821B0")]
	[EPFHFFCDLIN.KOJNBNLGEPK]
	internal static void EHEFGOAOAHF(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	[UnityEngine.Scripting.Preserve]
	internal MABPFNJBCIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal interface LPMNLPCINJL
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PGOMMJCDMEF(string JHJFHDOAMLG);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNNPIGCBCHH();
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal interface AHGBKLCBNPA
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string OENPDLODONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool HBBOBABEAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool ECNBLMBBGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal class JEJPGALFNKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public JNCCIJDPDOJ OCIODLKBEBA;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int BPKEJBPHLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1A0", Offset = "0x8A9BA0", VA = "0x1808AB1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8AF750", Offset = "0x8AE150", VA = "0x1808AF750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x777BC70", Offset = "0x777A670", VA = "0x18777BC70")]
	public static BGFOJNANPKN KGDKBEIGAEG(IEnumerator<BGFOJNANPKN> FEMILPGBABI, PFEKFPBOPFE KCELHEPBJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x777BDD0", Offset = "0x777A7D0", VA = "0x18777BDD0")]
	public BGFOJNANPKN KGDKBEIGAEG(PFEKFPBOPFE[] MJDPLMIOFDA, IEnumerator<BGFOJNANPKN>[] IFLEKIMHHJK, BGFOJNANPKN[] ABJEABFMJBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x777B9C0", Offset = "0x777A3C0", VA = "0x18777B9C0")]
	public void CFGLIKHNNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x777BB30", Offset = "0x777A530", VA = "0x18777BB30")]
	public void HBNCNLDPEDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x777B9F0", Offset = "0x777A3F0", VA = "0x18777B9F0")]
	public void GJFAPPLLHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x777B9C0", Offset = "0x777A3C0", VA = "0x18777B9C0")]
	public void JACDBNOBCLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public JEJPGALFNKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class JNCCIJDPDOJ
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public struct KIBOIMKFCBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public JEJPGALFNKH NPMLPGNGIJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public KIADIIPNNBC AAECKAINFLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public PFEKFPBOPFE FDDJBPCGKEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<BGFOJNANPKN> OBJDKPBLMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public BGFOJNANPKN CMIFMHFBPBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public KDCDEODMEHJ KOEOJNIFMOB;
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct POHGEJGNAOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public LICPEHAGMGN AHOKNMLGOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public List<KIBOIMKFCBP> HLHHGLBMJFE;
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class FODOJPMMOOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public PFEKFPBOPFE promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public JNCCIJDPDOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public KIADIIPNNBC context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public JEJPGALFNKH routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public KDCDEODMEHJ coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public BGFOJNANPKN currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public IEnumerator<BGFOJNANPKN> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public FODOJPMMOOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7777870", Offset = "0x7776270", VA = "0x187777870")]
		internal void MLGGJBOKACG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class EGPCFJIJKAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public JEJPGALFNKH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public JNCCIJDPDOJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EGPCFJIJKAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7774C30", Offset = "0x7773630", VA = "0x187774C30")]
		internal void EDIBIEPCAFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class GPFBMEBEPJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public JEJPGALFNKH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public JNCCIJDPDOJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public GPFBMEBEPJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x77790A0", Offset = "0x7777AA0", VA = "0x1877790A0")]
		internal void EFKKAHFLOHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class LPJOLKPAGEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public JEJPGALFNKH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public JNCCIJDPDOJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public LPJOLKPAGEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7781EF0", Offset = "0x77808F0", VA = "0x187781EF0")]
		internal void CILKPEKJHPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const KDCDEODMEHJ BHCJKPBKAAC = KDCDEODMEHJ.Cancelled | KDCDEODMEHJ.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly LICPEHAGMGN FDFLGBPAPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private bool[] AFEABJGJBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private NativeArray<KDCDEODMEHJ> CKEEPCEFHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private NativeArray<float> PDOCKHBFCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private NativeArray<int> LHMEAHEIBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NativeArray<int> CBLKLBCJCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private NativeArray<int> MJCGNDKHLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NativeArray<int> FMNKEDHHKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private NativeArray<int> OLAPHBMEKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private JEJPGALFNKH[] MLKJEBNKBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private PFEKFPBOPFE[] MJDPLMIOFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private KIADIIPNNBC[] DHLHPDOPGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private IEnumerator<BGFOJNANPKN>[] DEDMEHGJDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private BGFOJNANPKN[] KCPDHIOFKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private int MKLOGKBIGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int LFENHKJMLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly int JGMFCNKHDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private float AFBPINFFJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private ALCCAOEPGBL JMMAIFIMHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private JobHandle MCOLLECLCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private List<JEJPGALFNKH> JDBILIJCKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private bool GABIFKJCJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private List<Action> BDAHIEFIEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private List<Action> JKDAPCCEMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private bool NGFDONLINAA;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public POHGEJGNAOF[] NBPPGNCLBMP
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xBF0780", Offset = "0xBEF180", VA = "0x180BF0780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x777D910", Offset = "0x777C310", VA = "0x18777D910")]
	private static int CFINGPGGFNH(LICPEHAGMGN FDFLGBPAPAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x777F410", Offset = "0x777DE10", VA = "0x18777F410")]
	public JNCCIJDPDOJ(LICPEHAGMGN FDFLGBPAPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x777F080", Offset = "0x777DA80", VA = "0x18777F080")]
	private void NICNAPKKPGC(int NMAOGDIIOOB, int ANPFDOEBNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x777D790", Offset = "0x777C190", VA = "0x18777D790")]
	public void BOKBICILFHN(KIADIIPNNBC KMDNOIPDFGB, BGFOJNANPKN JOHMNGFAOND, IEnumerator<BGFOJNANPKN> FEMILPGBABI, PFEKFPBOPFE KCELHEPBJBF, [Optional] JEJPGALFNKH EEDPFOODAJG, KDCDEODMEHJ DKIDLJEFKLP = KDCDEODMEHJ.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x777E130", Offset = "0x777CB30", VA = "0x18777E130")]
	public void EDJHOBCGFJF(IEnumerable<KIBOIMKFCBP> LGFKGIMCDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x777E5A0", Offset = "0x777CFA0", VA = "0x18777E5A0")]
	private KIBOIMKFCBP JHPKOHCJDIA(int JMBHDIHMDCD)
	{
		return default(KIBOIMKFCBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x777DDC0", Offset = "0x777C7C0", VA = "0x18777DDC0")]
	private void DDBPAKAILBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D100", Offset = "0x2F4BB00", VA = "0x182F4D100")]
	private static void MHHCEPDPPJD<T>(int JMBHDIHMDCD, T[] IMALBGGPIMP, int LEGDMNLNDAK, [Optional] T BMOFJKBGKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D150", Offset = "0x2F4BB50", VA = "0x182F4D150")]
	private static void MHHCEPDPPJD<T>(int JMBHDIHMDCD, NativeArray<T> IMALBGGPIMP, int LEGDMNLNDAK, [Optional] T BMOFJKBGKOB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x777D940", Offset = "0x777C340", VA = "0x18777D940")]
	private void CJJDCOMCIIH(IEnumerable<KIBOIMKFCBP> LGFKGIMCDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x777DCF0", Offset = "0x777C6F0", VA = "0x18777DCF0")]
	private void COHMNGCOMPP(KIBOIMKFCBP DHIMNOIAFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x777EDA0", Offset = "0x777D7A0", VA = "0x18777EDA0")]
	private KJBAHNAMKLA MIKDEABMEGK(int OIJGFPEPLMM)
	{
		return default(KJBAHNAMKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x777EA70", Offset = "0x777D470", VA = "0x18777EA70")]
	public void LIIMEKKGJIC(float LGHDLACJOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x777F260", Offset = "0x777DC60", VA = "0x18777F260")]
	private void OBDOMIBGLJM(Action PEMPEACEHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x777F000", Offset = "0x777DA00", VA = "0x18777F000")]
	private void MMKPICNCJNH(Action PEMPEACEHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x777D070", Offset = "0x777BA70", VA = "0x18777D070")]
	public void AIHGPKFMLKK(float LGHDLACJOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x777E4A0", Offset = "0x777CEA0", VA = "0x18777E4A0")]
	public void JFMJGMNFMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x777E370", Offset = "0x777CD70", VA = "0x18777E370")]
	public void JACDBNOBCLB(JEJPGALFNKH BJLHCHJPCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x777F2E0", Offset = "0x777DCE0", VA = "0x18777F2E0")]
	public void PKFGEOCHKIL(JEJPGALFNKH BJLHCHJPCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x777EC70", Offset = "0x777D670", VA = "0x18777EC70")]
	public void MCMDBGLPDNK(JEJPGALFNKH BJLHCHJPCDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class CFPMOIOCLBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static readonly CFPMOIOCLBN BDDJBNJILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly Action FKEFGHMOLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool IFCFLPBDAAE;

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	public CFPMOIOCLBN(Action FKEFGHMOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6EE71E0", Offset = "0x6EE5BE0", VA = "0x186EE71E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface OEKMKNIGAHI<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T IPHIEALFCML
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable NGKOLLJAPEI(UnityEngine.Object KMDNOIPDFGB, Action<T> NPFLOHBGBCM);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface NFFEADMIOPK<T> : OEKMKNIGAHI<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	new T IPHIEALFCML
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class DCJPJHHCKEK<T> : NFFEADMIOPK<T>, OEKMKNIGAHI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class LMHJKBKJDMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public DCJPJHHCKEK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public HKJFMLEDOGG<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public LMHJKBKJDMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4680250", Offset = "0x467EC50", VA = "0x184680250")]
		internal void MBCNIPONJPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static GameObject MFFICLODHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly List<HKJFMLEDOGG<UnityEngine.Object, Action<T>>> FPKHOFPOGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private T IIBBMNFFMKP;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public T IPHIEALFCML
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xBB0080", Offset = "0xBAEA80", VA = "0x180BB0080", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5C760F0", Offset = "0x5C74AF0", VA = "0x185C760F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5C75F30", Offset = "0x5C74930", VA = "0x185C75F30")]
	private static bool ADHPHENPKOM(T PEMPEACEHBG, T FDDPOELCNDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5C76BC0", Offset = "0x5C755C0", VA = "0x185C76BC0")]
	public DCJPJHHCKEK(T MBILGEPMGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5C76A00", Offset = "0x5C75400", VA = "0x185C76A00", Slot = "6")]
	public IDisposable NGKOLLJAPEI(UnityEngine.Object KMDNOIPDFGB, Action<T> NPFLOHBGBCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5C761A0", Offset = "0x5C74BA0", VA = "0x185C761A0")]
	private void FNKFJNCODJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal class LCFAIMJOALN : GBAFANLCLGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly MAADJEHCAPM MMJPGOGMMKD;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7781400", Offset = "0x777FE00", VA = "0x187781400")]
	[EPFHFFCDLIN.KOJNBNLGEPK]
	internal static void HFONMHBGKMF(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	[UnityEngine.Scripting.Preserve]
	internal LCFAIMJOALN([CCLEDEMDDDH(null)] MAADJEHCAPM MMJPGOGMMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7781470", Offset = "0x777FE70", VA = "0x187781470", Slot = "4")]
	public IDisposable MGHIKFKLOHO(float HACBMKGLNMP, Action<float> HFJNADOBPEL, bool LHBNGGJIJPI = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class JKLIJPIEKIF : FNDJHHHBJON, MAADJEHCAPM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private JNCCIJDPDOJ[] DECKJEDIPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private LPMNLPCINJL KLFFLEMHCEL;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x777C5E0", Offset = "0x777AFE0", VA = "0x18777C5E0")]
	[EPFHFFCDLIN.KOJNBNLGEPK]
	internal static void EHEFGOAOAHF(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x777CFB0", Offset = "0x777B9B0", VA = "0x18777CFB0")]
	[UnityEngine.Scripting.Preserve]
	public JKLIJPIEKIF([CCLEDEMDDDH(null)] PMJEJLOIEGK GDADOOAOBJF, [CCLEDEMDDDH(null)] AEGEHFMLOMF CPDHHLHFIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x777CDC0", Offset = "0x777B7C0", VA = "0x18777CDC0", Slot = "19")]
	public override OIMBFIPCENK KAMDAFFCIFB(KIADIIPNNBC KMDNOIPDFGB, IEnumerator<BGFOJNANPKN> KGOBDMNGCEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x777C650", Offset = "0x777B050", VA = "0x18777C650", Slot = "20")]
	public override void ENPPBKGKMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x777C350", Offset = "0x777AD50", VA = "0x18777C350", Slot = "22")]
	public override void ANJCPEOAECM(LICPEHAGMGN FDFLGBPAPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x777CA30", Offset = "0x777B430", VA = "0x18777CA30", Slot = "21")]
	protected override void HIEHKMNLIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x777CA00", Offset = "0x777B400", VA = "0x18777CA00")]
	private JNCCIJDPDOJ GLMAJIFEOPN(LICPEHAGMGN BKKHBFLPOHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x777CBA0", Offset = "0x777B5A0", VA = "0x18777CBA0", Slot = "23")]
	internal override FKGBDLMGNIC JOOHHKKDCDB(IEnumerator<BGFOJNANPKN> KGOBDMNGCEE, Behaviour KMDNOIPDFGB, PFEKFPBOPFE KCELHEPBJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x777CEF0", Offset = "0x777B8F0", VA = "0x18777CEF0", Slot = "24")]
	internal override CINOOIKBBIL PIPHMGGPIKD(LICPEHAGMGN LFDHLEDCOLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x777C8E0", Offset = "0x777B2E0", VA = "0x18777C8E0")]
	private void FFPKLFLJIOP(JNCCIJDPDOJ HBGNCNFLPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x777C580", Offset = "0x777AF80", VA = "0x18777C580", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[BurstCompile]
internal struct ALCCAOEPGBL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[ReadOnly]
	public float JLOJCBAOJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[ReadOnly]
	public int DCHGNJDKIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private NativeArray<int> DDCBJBGNCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private NativeArray<int> ODBDCBCGOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private NativeArray<int> BMIOOFGNLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[ReadOnly]
	public NativeArray<KDCDEODMEHJ> KOAEDFOFKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[ReadOnly]
	public NativeArray<float> LCJIEAFKENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[WriteOnly]
	public NativeArray<int> MJCGNDKHLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[WriteOnly]
	public NativeArray<int> LHMEAHEIBBH;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x776A530", Offset = "0x7768F30", VA = "0x18776A530")]
	public static ALCCAOEPGBL LNCAGMGJJFK(int LPKPDNNFLHC, float LGHDLACJOLK, NativeArray<KDCDEODMEHJ> IKLKNHHEHBN, NativeArray<float> EGKEBLFBMDI, NativeArray<int> PBGOBONHJPH, NativeArray<int> CGANMJNEFCG, NativeArray<int> BIGJJFJMHMC, NativeArray<int> ODBDCBCGOKO, NativeArray<int> BMIOOFGNLBI)
	{
		return default(ALCCAOEPGBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x776A380", Offset = "0x7768D80", VA = "0x18776A380", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x776A030", Offset = "0x7768A30", VA = "0x18776A030")]
	private bool AHMMBPAFIDH(int GCBONJOGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x776A500", Offset = "0x7768F00", VA = "0x18776A500")]
	private void GKFOAAIILIL(NativeArray<int> NHDPJAPCEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x776A460", Offset = "0x7768E60", VA = "0x18776A460")]
	private int FGEJDEMGOLN(int LLDMELGJIPJ, int BFDFINKGLGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x776A070", Offset = "0x7768A70", VA = "0x18776A070")]
	private void BLGDDJNKHIJ(NativeArray<int> NHDPJAPCEID, int NICANIBGBDP, int ECOIDHGKBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x776A140", Offset = "0x7768B40", VA = "0x18776A140")]
	private void EFBDKIKHGOL(NativeArray<int> NHDPJAPCEID, int LOMGOENMALN, int CLJAIFDBBMF, int BFFDKBDFAMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public abstract class FNDJHHHBJON : MAADJEHCAPM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly PMJEJLOIEGK GDADOOAOBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	protected readonly AEGEHFMLOMF CPDHHLHFIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private CINOOIKBBIL[] BLKBEMEMJCL;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static MAADJEHCAPM JOLICDCBKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x77764F0", Offset = "0x7774EF0", VA = "0x1877764F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static bool NPNEBPFKOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public LICPEHAGMGN BAMOMNAHKJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1A0", Offset = "0x8A9BA0", VA = "0x1808AB1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LICPEHAGMGN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF750", Offset = "0x8AE150", VA = "0x1808AF750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public AEGEHFMLOMF KBLCPOIEBGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BGFOJNANPKN BNJAHHFDDLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public BGFOJNANPKN LJPENDIOMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8AD960", Offset = "0x8AC360", VA = "0x1808AD960", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public BGFOJNANPKN HAFEFEHBILK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8B0160", Offset = "0x8AEB60", VA = "0x1808B0160", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public BGFOJNANPKN MBKMDFAMAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1D0", Offset = "0x8A9BD0", VA = "0x1808AB1D0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7776560", Offset = "0x7774F60", VA = "0x187776560")]
	public static OIMBFIPCENK DBKGGLEHBHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7777380", Offset = "0x7775D80", VA = "0x187777380")]
	[UnityEngine.Scripting.Preserve]
	protected FNDJHHHBJON([CCLEDEMDDDH(null)] PMJEJLOIEGK GDADOOAOBJF, [CCLEDEMDDDH(null)] AEGEHFMLOMF CPDHHLHFIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7777060", Offset = "0x7775A60", VA = "0x187777060", Slot = "6")]
	public OIMBFIPCENK LDLLGDHEPIB(IEnumerator<BGFOJNANPKN> KGOBDMNGCEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7777070", Offset = "0x7775A70", VA = "0x187777070", Slot = "7")]
	public OIMBFIPCENK LDLLGDHEPIB(Behaviour KMDNOIPDFGB, IEnumerator<BGFOJNANPKN> KGOBDMNGCEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract OIMBFIPCENK KAMDAFFCIFB(KIADIIPNNBC KMDNOIPDFGB, IEnumerator<BGFOJNANPKN> KGOBDMNGCEE);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x77769D0", Offset = "0x77753D0", VA = "0x1877769D0", Slot = "20")]
	public virtual void ENPPBKGKMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7776B70", Offset = "0x7775570", VA = "0x187776B70", Slot = "9")]
	public void GIDGGAMCFFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7776F80", Offset = "0x7775980", VA = "0x187776F80", Slot = "21")]
	protected virtual void HIEHKMNLIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7777020", Offset = "0x7775A20", VA = "0x187777020")]
	private void JFGHHLLLBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7777270", Offset = "0x7775C70", VA = "0x187777270")]
	private void LPNAFHLAGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7777040", Offset = "0x7775A40", VA = "0x187777040")]
	private void KDEKFHPGMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x77764D0", Offset = "0x7774ED0", VA = "0x1877764D0")]
	private void CFEAHDHNPGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7776FA0", Offset = "0x77759A0", VA = "0x187776FA0")]
	private void HOCICICPNBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x77764B0", Offset = "0x7774EB0", VA = "0x1877764B0")]
	private void CEOFCGPDIGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x77765F0", Offset = "0x7774FF0", VA = "0x1877765F0")]
	private void DMBABLGNDPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7776420", Offset = "0x7774E20", VA = "0x187776420", Slot = "22")]
	public virtual void ANJCPEOAECM(LICPEHAGMGN FDFLGBPAPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7776DB0", Offset = "0x77757B0", VA = "0x187776DB0")]
	private void HCPAFLDNMDK(CINOOIKBBIL HBGNCNFLPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x218BCB0", Offset = "0x218A6B0", VA = "0x18218BCB0")]
	private CINOOIKBBIL IJMOLEDGLNJ(LICPEHAGMGN BKKHBFLPOHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract FKGBDLMGNIC JOOHHKKDCDB(IEnumerator<BGFOJNANPKN> KGOBDMNGCEE, Behaviour LBAMDLBMFIH, PFEKFPBOPFE NPKDKDFCADD);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract CINOOIKBBIL PIPHMGGPIKD(LICPEHAGMGN FDFLGBPAPAA);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7776610", Offset = "0x7775010", VA = "0x187776610", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7777320", Offset = "0x7775D20", VA = "0x187777320", Slot = "15")]
	public BGFOJNANPKN MLNCMGFEJLA(LICPEHAGMGN LFDHLEDCOLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7777290", Offset = "0x7775C90", VA = "0x187777290", Slot = "16")]
	public BGFOJNANPKN MAFDNAMGKIN(float FPEHIEEJIAO, LICPEHAGMGN LFDHLEDCOLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7776FC0", Offset = "0x77759C0", VA = "0x187776FC0", Slot = "17")]
	public BGFOJNANPKN IPDILMIJMOA(Func<bool> KPFOFBGGJLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class FKGBDLMGNIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly PFEKFPBOPFE KCELHEPBJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly AHGBKLCBNPA KMDNOIPDFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly bool IADLMOHEEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private string JHJFHDOAMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private StackTrace FDONKAGHFMO;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerator<BGFOJNANPKN> OBJDKPBLMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public BGFOJNANPKN CMIFMHFBPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB10", Offset = "0x8AC510", VA = "0x1808ADB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool ILJOAPDICOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7775FD0", Offset = "0x77749D0", VA = "0x187775FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool INLIOJLOCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x9349D0", Offset = "0x9333D0", VA = "0x1809349D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x93E990", Offset = "0x93D390", VA = "0x18093E990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string OENPDLODONH
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7775A40", Offset = "0x7774440", VA = "0x187775A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float LHMMHJHINKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xBB0000", Offset = "0xBAEA00", VA = "0x180BB0000")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xDE67B0", Offset = "0xDE51B0", VA = "0x180DE67B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7776130", Offset = "0x7774B30", VA = "0x187776130")]
	public FKGBDLMGNIC(IEnumerator<BGFOJNANPKN> FEMILPGBABI, AHGBKLCBNPA KMDNOIPDFGB, PFEKFPBOPFE KCELHEPBJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7775C40", Offset = "0x7774640", VA = "0x187775C40")]
	public BGFOJNANPKN KGDKBEIGAEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7775F60", Offset = "0x7774960", VA = "0x187775F60")]
	public bool NDICELHPCNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7775BF0", Offset = "0x77745F0", VA = "0x187775BF0")]
	public void JACDBNOBCLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7776050", Offset = "0x7774A50", VA = "0x187776050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x93E840", Offset = "0x93D240", VA = "0x18093E840")]
	[CompilerGenerated]
	private void NLDINGNMJEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class PFEKFPBOPFE : JLMDJGDHNPI, OIMBFIPCENK, OLPMMAHKODD, HGKKEBPLLAP, IEnumerator, BGFOJNANPKN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private LICPEHAGMGN KJKFLGFEDDL;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private LICPEHAGMGN PKGKIAOMBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x934300", Offset = "0x932D00", VA = "0x180934300", Slot = "23")]
		get
		{
			return default(LICPEHAGMGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public LICPEHAGMGN OCIODLKBEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xAAD3E0", Offset = "0xAABDE0", VA = "0x180AAD3E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private float EPEKGOAGGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xAC93E0", Offset = "0xAC7DE0", VA = "0x180AC93E0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool EAIDKCDAJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7785530", Offset = "0x7783F30", VA = "0x187785530", Slot = "24")]
	private bool CDDNNCLFCLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7785550", Offset = "0x7783F50", VA = "0x187785550", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7785560", Offset = "0x7783F60", VA = "0x187785560")]
	public PFEKFPBOPFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal enum KJBAHNAMKLA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal sealed class CINOOIKBBIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public enum FALECFBHOMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct HAMJILJNLBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public LICPEHAGMGN AHOKNMLGOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public FALECFBHOMG LDKIGCGONBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public List<FKGBDLMGNIC> EDBOJLJJFOI;
	}

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static readonly FALECFBHOMG[] DMAIFMNGBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly LICPEHAGMGN FDFLGBPAPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private bool EOMCEJEKBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private readonly FKGBDLMGNIC[] GOOJDFMLKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly List<FKGBDLMGNIC> BGOECDFFPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Stack<int> PAHECMIHFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly List<FKGBDLMGNIC> MCDJJKEFKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly Stack<int> JFINNEKOHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly LPMNLPCINJL CKILLCAADHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private bool NGFDONLINAA;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public HAMJILJNLBF[,] KJONDPKJIMF
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8B0160", Offset = "0x8AEB60", VA = "0x1808B0160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x776D3B0", Offset = "0x776BDB0", VA = "0x18776D3B0")]
	public CINOOIKBBIL(LICPEHAGMGN LFDHLEDCOLJ, LPMNLPCINJL CKILLCAADHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x776D040", Offset = "0x776BA40", VA = "0x18776D040")]
	public void LEFMILPBFAK(FKGBDLMGNIC FEMILPGBABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x776BEA0", Offset = "0x776A8A0", VA = "0x18776BEA0")]
	public void ACKCFNOOJEL(IList<FKGBDLMGNIC> IFLEKIMHHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x776C640", Offset = "0x776B040", VA = "0x18776C640")]
	public void DOKJNBMIIBM(IList<FKGBDLMGNIC> IFLEKIMHHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x776CF50", Offset = "0x776B950", VA = "0x18776CF50")]
	private void JHBIFPFHCGF(FKGBDLMGNIC FEMILPGBABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x776C1B0", Offset = "0x776ABB0", VA = "0x18776C1B0")]
	private void AHAOMHOMLIG(IList<FKGBDLMGNIC> IFLEKIMHHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x776CA70", Offset = "0x776B470", VA = "0x18776CA70")]
	private KJBAHNAMKLA FHCOOIJBEBG(FKGBDLMGNIC FEMILPGBABI)
	{
		return default(KJBAHNAMKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x776CDE0", Offset = "0x776B7E0", VA = "0x18776CDE0")]
	public void HIEHKMNLIKI(float LGHDLACJOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x776CBF0", Offset = "0x776B5F0", VA = "0x18776CBF0")]
	public void GIDGGAMCFFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x776C340", Offset = "0x776AD40", VA = "0x18776C340")]
	private void BNEFLFJBAIJ(List<FKGBDLMGNIC> IFLEKIMHHJK, Stack<int> LEEJNDCKPDK, bool GFGLHLBJKNE, float PPEPNCAINFD = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x776C950", Offset = "0x776B350", VA = "0x18776C950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x776D140", Offset = "0x776BB40", VA = "0x18776D140")]
	private void LIPKODNHKOA(List<FKGBDLMGNIC> IFLEKIMHHJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal class JDICGJGMIPP : LPMNLPCINJL
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "4")]
	public void PGOMMJCDMEF(string JHJFHDOAMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
	public void KNNPIGCBCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public JDICGJGMIPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class LONBLHLPCBF : AHGBKLCBNPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly Behaviour LBAMDLBMFIH;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string OENPDLODONH
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7781E70", Offset = "0x7780870", VA = "0x187781E70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool HBBOBABEAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7781E00", Offset = "0x7780800", VA = "0x187781E00", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool ECNBLMBBGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7781E50", Offset = "0x7780850", VA = "0x187781E50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	public LONBLHLPCBF(Behaviour LBAMDLBMFIH)
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

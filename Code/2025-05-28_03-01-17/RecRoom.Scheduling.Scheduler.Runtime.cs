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
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x888F810", Offset = "0x888E610", VA = "0x18888F810", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8893A50", Offset = "0x8892850", VA = "0x188893A50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
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
		private delegate List<PlayerLoopSystem> CNIBKFOKBBI(List<PlayerLoopSystem> MCFEPKEEPPG, int MJCPPOINDEA);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct HFBMLPEGLIN
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct KGMHCKKKJND
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static LLEAAEBCCKF CFCEJBFDJDF;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x888A670", Offset = "0x8889470", VA = "0x18888A670")]
				public static PlayerLoopSystem BBMPNLNPGEO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct KNLIMCGNJOH
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static LLEAAEBCCKF HOBOFMOJDCN;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x888BD20", Offset = "0x888AB20", VA = "0x18888BD20")]
				public static PlayerLoopSystem BBMPNLNPGEO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct FFKCLCHPBHK
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static LLEAAEBCCKF KILKEHDAEDP;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x887F1C0", Offset = "0x887DFC0", VA = "0x18887F1C0")]
				public static PlayerLoopSystem BBMPNLNPGEO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct IDABACMJBGA
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static LLEAAEBCCKF ECMEMJAFENP;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static LLEAAEBCCKF BAHECGGJEJL;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static LLEAAEBCCKF NHAHOFNLCJG;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static LLEAAEBCCKF FGIKDBIDKDE;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x8885760", Offset = "0x8884560", VA = "0x188885760")]
				public static PlayerLoopSystem BBMPNLNPGEO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct JONMFHMPHNM
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static LLEAAEBCCKF GEFJOJEPGBO;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x888A270", Offset = "0x8889070", VA = "0x18888A270")]
				public static PlayerLoopSystem BBMPNLNPGEO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct JFBIBLFOBHA
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static LLEAAEBCCKF ECMEMJAFENP;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static LLEAAEBCCKF BAHECGGJEJL;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static LLEAAEBCCKF NHAHOFNLCJG;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static LLEAAEBCCKF FGIKDBIDKDE;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x8888760", Offset = "0x8887560", VA = "0x188888760")]
				public static PlayerLoopSystem BBMPNLNPGEO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct BJFGNMJKFFE
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static LLEAAEBCCKF PHIAFBFEFKB;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x8877980", Offset = "0x8876780", VA = "0x188877980")]
				public static PlayerLoopSystem BBMPNLNPGEO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct CCEKFEEDFIH
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static LLEAAEBCCKF GIKGMCKMFFB;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x8877CF0", Offset = "0x8876AF0", VA = "0x188877CF0")]
				public static PlayerLoopSystem BBMPNLNPGEO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct GPCJNAHIDCE
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static LLEAAEBCCKF OGCONNBHHEC;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x88810A0", Offset = "0x887FEA0", VA = "0x1888810A0")]
				public static PlayerLoopSystem BBMPNLNPGEO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct FHMOJCGLFPH
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static LLEAAEBCCKF DECMBFILJCF;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x887F600", Offset = "0x887E400", VA = "0x18887F600")]
				public static PlayerLoopSystem BBMPNLNPGEO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct FHMMHLCDEFF
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static LLEAAEBCCKF HHJHIKPCMAO;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x887F400", Offset = "0x887E200", VA = "0x18887F400")]
				public static PlayerLoopSystem BBMPNLNPGEO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct JKKJAHLKJJL
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static LLEAAEBCCKF AFJJHMILAIL;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x8889EE0", Offset = "0x8888CE0", VA = "0x188889EE0")]
				public static PlayerLoopSystem BBMPNLNPGEO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct MIHGHCOCOHJ
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static LLEAAEBCCKF GFDNKLEANAC;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x8890540", Offset = "0x888F340", VA = "0x188890540")]
				public static PlayerLoopSystem BBMPNLNPGEO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct GODJJKLAEFJ
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static LLEAAEBCCKF DMEGFPBAJJF;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x8880EA0", Offset = "0x887FCA0", VA = "0x188880EA0")]
				public static PlayerLoopSystem BBMPNLNPGEO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct GPMPAABCNMI
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static LLEAAEBCCKF KPJPOJJPMJA;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x88812A0", Offset = "0x88800A0", VA = "0x1888812A0")]
				public static PlayerLoopSystem BBMPNLNPGEO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum IBIEGDMJPGJ : byte
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
			public struct HKCACINCJHF
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class MHKFMIIKBIJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public IBIEGDMJPGJ updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
					public MHKFMIIKBIJ()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x88904C0", Offset = "0x888F2C0", VA = "0x1888904C0")]
					internal void EGPOEJOBPOI()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static IMAAKJGDPMH<IBIEGDMJPGJ> FFLBNIDHCME;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x8884D70", Offset = "0x8883B70", VA = "0x188884D70")]
				public static PlayerLoopSystem BBMPNLNPGEO(IBIEGDMJPGJ NGJHOJNHJKC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct FAOFMCPMPGC
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class KOPCDEJODHI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public ILIAAHGOKMP.MEBHIFNADOJ key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
					public KOPCDEJODHI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x888C480", Offset = "0x888B280", VA = "0x18888C480")]
					internal void ILGLNJOAFGE()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable NAJIOPBNALM;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x887E4F0", Offset = "0x887D2F0", VA = "0x18887E4F0")]
				public static PlayerLoopSystem CMMHLBGEFAF(ILIAAHGOKMP.MEBHIFNADOJ MAKJJJECHHB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct IHALLCLAHKE
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class NCAHMOILCIC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public ILIAAHGOKMP.MEBHIFNADOJ key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
					public NCAHMOILCIC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x8891560", Offset = "0x8890360", VA = "0x188891560")]
					internal void ILGLNJOAFGE()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x8886470", Offset = "0x8885270", VA = "0x188886470")]
				public static PlayerLoopSystem CMMHLBGEFAF(ILIAAHGOKMP.MEBHIFNADOJ MAKJJJECHHB)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class LCFKJGIFJHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public LCFKJGIFJHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x888C790", Offset = "0x888B590", VA = "0x18888C790")]
			internal List<PlayerLoopSystem> JIDOJMKOPHC(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool DMIHOIJPLCF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool PIMNJFEDFGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x887C4B0", Offset = "0x887B2B0", VA = "0x18887C4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8879010", Offset = "0x8877E10", VA = "0x188879010")]
		private static void DPCNEBGKCJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88784B0", Offset = "0x88772B0", VA = "0x1888784B0")]
		private static void BMMCEFOEBDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8878470", Offset = "0x8877270", VA = "0x188878470")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8878DC0", Offset = "0x8877BC0", VA = "0x188878DC0")]
		private static void DAEBIHFNBEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88782B0", Offset = "0x88770B0", VA = "0x1888782B0")]
		private static void AFMHGPLLDKA(ILIAAHGOKMP.MEBHIFNADOJ MAKJJJECHHB, PlayerLoopSystem CJDNPHDADHA, Type ALFDGHALMFP, Type AALCDDACLKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x887C0D0", Offset = "0x887AED0", VA = "0x18887C0D0")]
		private static void FMJKBOPPIJA(PlayerLoopSystem CJDNPHDADHA, Type ALFDGHALMFP, Type AALCDDACLKE, CNIBKFOKBBI PCIHOFBDLLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x887C4F0", Offset = "0x887B2F0", VA = "0x18887C4F0")]
		private static void LMIKGFBNFEH(PlayerLoopSystem CJDNPHDADHA, Type ALFDGHALMFP, Type AALCDDACLKE, PlayerLoopSystem? EPGELMEBKPB, PlayerLoopSystem? PANOGIGCFBN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class ILIAAHGOKMP
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum MEBHIFNADOJ
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
	public class MJPLGLMEPKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly MEBHIFNADOJ MABGEKICHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly BNECLNEGCCB PCBCEIBCHFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long DLBAONGCIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long KNHMHBGINNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long LMMPDJENIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int NDJCPBAOKJC;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8890890", Offset = "0x888F690", VA = "0x188890890")]
		public MJPLGLMEPKC(MEBHIFNADOJ LHINMAOHHFF, int JCNIFNPPGLC = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8890740", Offset = "0x888F540", VA = "0x188890740")]
		public void KMDMAHEJGAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8890760", Offset = "0x888F560", VA = "0x188890760")]
		public void KOGMCNNFEAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x88907B0", Offset = "0x888F5B0", VA = "0x1888907B0")]
		public void NHEIJGMFDEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static MEBHIFNADOJ[] MBGCEKLLBJA;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static MJPLGLMEPKC[] NDCCIIAECHH;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8886610", Offset = "0x8885410", VA = "0x188886610")]
	public static MJPLGLMEPKC ENKCKEJMNBC(MEBHIFNADOJ MAKJJJECHHB, int JCNIFNPPGLC = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x88865A0", Offset = "0x88853A0", VA = "0x1888865A0")]
	public static MJPLGLMEPKC EHONAGFOMEP(MEBHIFNADOJ MAKJJJECHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8886760", Offset = "0x8885560", VA = "0x188886760")]
	public static void HLHKNHFPPJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class AMGDBCIGMKN
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private interface CGCIOKBOFEH
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool JIMCLEIHHFL
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LJHGHGHDHHP();
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class MFMEADFNDPC : CGCIOKBOFEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action CFDGGKIIHOI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool JIMCLEIHHFL
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
		public MFMEADFNDPC(Action CFDGGKIIHOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1183490", Offset = "0x1182290", VA = "0x181183490", Slot = "5")]
		public void LJHGHGHDHHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<CGCIOKBOFEH> LEMLPGKGOMF;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8877120", Offset = "0x8875F20", VA = "0x188877120")]
	public static void ELHMIFOOOFI(Action CFDGGKIIHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x88772C0", Offset = "0x88760C0", VA = "0x1888772C0")]
	private static void HKOHMDPKLMI(CGCIOKBOFEH OBAJEGECNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x88775C0", Offset = "0x88763C0", VA = "0x1888775C0")]
	private static void OFAMFAHJKFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x88771C0", Offset = "0x8875FC0", VA = "0x1888771C0")]
	private static void FKIDBAPIBNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x88774E0", Offset = "0x88762E0", VA = "0x1888774E0")]
	private static void LHMHHFOACLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class INAAJJAOGNL
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct KNAKPIKJMEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TaskCompletionSource<Scene> AKOBDLGKHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly string HNANIJLJDBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly LoadSceneMode JLBICBCILAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly bool KMLMFPECCJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x888BCC0", Offset = "0x888AAC0", VA = "0x18888BCC0")]
		public KNAKPIKJMEC(TaskCompletionSource<Scene> BOKOJFIAMEK, string HNANIJLJDBI, LoadSceneMode JLBICBCILAK, bool KMLMFPECCJP, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct IDNLDMHJBGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private HBCKFDINPOH<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8885B60", Offset = "0x8884960", VA = "0x188885B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8886400", Offset = "0x8885200", VA = "0x188886400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GENPKNDGBGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8880420", Offset = "0x887F220", VA = "0x188880420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8880740", Offset = "0x887F540", VA = "0x188880740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct ALGNKFEAEAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private KNAKPIKJMEC <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8876D00", Offset = "0x8875B00", VA = "0x188876D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x88770C0", Offset = "0x8875EC0", VA = "0x1888770C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class JHAKKACFBEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public PBDIAIKLBKL<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JHAKKACFBEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8888A50", Offset = "0x8887850", VA = "0x188888A50")]
		internal void JAABLHCGDGO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MGLAGFDPLJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private JHAKKACFBEH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x888F8A0", Offset = "0x888E6A0", VA = "0x18888F8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8890450", Offset = "0x888F250", VA = "0x188890450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct HFIJELMMLNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private OGIJLBDGAHB <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8884640", Offset = "0x8883440", VA = "0x188884640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8884D00", Offset = "0x8883B00", VA = "0x188884D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct NBDDNBJPDJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8890920", Offset = "0x888F720", VA = "0x188890920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8891440", Offset = "0x8890240", VA = "0x188891440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CLPJLOOJALO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public PBDIAIKLBKL<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CLPJLOOJALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8878230", Offset = "0x8877030", VA = "0x188878230")]
		internal bool MMIDJIKHMMA(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8877FB0", Offset = "0x8876DB0", VA = "0x188877FB0")]
		internal void AEKBBDGHGNH(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FEIHPLPGPIM : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public PBDIAIKLBKL<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private CLPJLOOJALO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private OGIJLBDGAHB <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public FEIHPLPGPIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x887F160", Offset = "0x887DF60", VA = "0x18887F160", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x887E850", Offset = "0x887D650", VA = "0x18887E850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x887F0F0", Offset = "0x887DEF0", VA = "0x18887F0F0")]
		private void PPMJPANAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x887F110", Offset = "0x887DF10", VA = "0x18887F110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ICollection<string> NGKIBGBBNJH;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static AAFDGGPNGMA CFAMCBMFFKO;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AsyncOperation OELBCDFIEBJ;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static AAFDGGPNGMA HEBCELPILAK;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static string DLKOPMNEOCI;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string GPPNEPFAKFF;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority ENBDLDGDALI;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task LIMAICCAPBF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static List<SceneInstance> ENFLOEIIIBD;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly Queue<KNAKPIKJMEC> GPCAIIMGDPK;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static Task EDLJJFGJKBO;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> HEKFAOFPOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8887B50", Offset = "0x8886950", VA = "0x188887B50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8887A40", Offset = "0x8886840", VA = "0x188887A40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8886C80", Offset = "0x8885A80", VA = "0x188886C80")]
	[OHEKCAPHOOO(LHBMPOBGEAI.EnteredEditModeNextFrame, 0)]
	private static void FCEMDMIMGMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8887340", Offset = "0x8886140", VA = "0x188887340")]
	[AsyncStateMachine(typeof(IDNLDMHJBGE))]
	public static Task<Scene> LBGLBIDCPBF(string HNANIJLJDBI, LoadSceneMode JLBICBCILAK = LoadSceneMode.Single, bool KMLMFPECCJP = false, [Optional] HBCKFDINPOH<string>.DLKHFLDLCIN CFPHKMKKEAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x88875C0", Offset = "0x88863C0", VA = "0x1888875C0")]
	[AsyncStateMachine(typeof(GENPKNDGBGF))]
	private static Task LLBLLAHDNLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8887710", Offset = "0x8886510", VA = "0x188887710")]
	[AsyncStateMachine(typeof(ALGNKFEAEAG))]
	private static Task OANMGFNFADM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x88877E0", Offset = "0x88865E0", VA = "0x1888877E0")]
	[AsyncStateMachine(typeof(MGLAGFDPLJA))]
	private static Task<Scene> OIKIGPAHEFJ(string HNANIJLJDBI, LoadSceneMode JLBICBCILAK, bool KMLMFPECCJP, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8886EB0", Offset = "0x8885CB0", VA = "0x188886EB0")]
	private static void IGCFCIPGKCL(SceneInstance BNOFOIBJLLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8886FC0", Offset = "0x8885DC0", VA = "0x188886FC0")]
	private static void IJLLFEEIMLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8886D80", Offset = "0x8885B80", VA = "0x188886D80")]
	[AsyncStateMachine(typeof(HFIJELMMLNC))]
	private static Task<Scene> FGGFKFGCIMC(string HNANIJLJDBI, LoadSceneMode JLBICBCILAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8886A10", Offset = "0x8885810", VA = "0x188886A10")]
	private static bool DFDCDGOHJEL(string HNANIJLJDBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8887930", Offset = "0x8886730", VA = "0x188887930")]
	[AsyncStateMachine(typeof(NBDDNBJPDJE))]
	private static Task<Scene> PHCHALDJLNI(HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8886B00", Offset = "0x8885900", VA = "0x188886B00")]
	public static HMBEFKLHMDK<Scene> DPCLKEMDGGK(string HNANIJLJDBI, LoadSceneMode JLBICBCILAK = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8887670", Offset = "0x8886470", VA = "0x188887670")]
	[IteratorStateMachine(typeof(FEIHPLPGPIM))]
	private static IEnumerator<GCOFLMDGPIM> MHBFKHMBFDK(string HNANIJLJDBI, LoadSceneMode JLBICBCILAK, PBDIAIKLBKL<Scene> APIBNMIAMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x88869B0", Offset = "0x88857B0", VA = "0x1888869B0")]
	public static void BOMEHKPPHDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8887280", Offset = "0x8886080", VA = "0x188887280")]
	private static void JGCLJMNFBBJ(string HNANIJLJDBI, LoadSceneMode JLBICBCILAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8887490", Offset = "0x8886290", VA = "0x188887490")]
	public static bool LDBGGHFNEMG([Out] string ODLHFMIPAAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JOHEAIKACMD
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x888A1E0", Offset = "0x8888FE0", VA = "0x18888A1E0")]
	public static IDisposable PGAPIENJLBM(this DCPGGKBOJAN JAPGNGDBBIF, float AHIPGGGAAHP, Action<float> HCPGLDHCBKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x888A160", Offset = "0x8888F60", VA = "0x18888A160")]
	public static IDisposable NIJBMLOEIJE(this DCPGGKBOJAN JAPGNGDBBIF, Action<float> HCPGLDHCBKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x888A0E0", Offset = "0x8888EE0", VA = "0x18888A0E0")]
	public static IDisposable BHEAIBPLMGE(this DCPGGKBOJAN JAPGNGDBBIF, Action<float> HCPGLDHCBKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class INBLDBFJAJI
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x39547A0", Offset = "0x39535A0", VA = "0x1839547A0")]
	[LMKBODNDMCL]
	public static IDisposable HJMFFPECPLA<T>(this T KHBFFGPDGLH, Action HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3954950", Offset = "0x3953750", VA = "0x183954950")]
	[LMKBODNDMCL]
	public static IDisposable HJMFFPECPLA<T>(this T KHBFFGPDGLH, Action<float> HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3954E60", Offset = "0x3953C60", VA = "0x183954E60")]
	[LMKBODNDMCL]
	public static IDisposable JPEBABACHJL<T>(this T KHBFFGPDGLH, Action HCPGLDHCBKP, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3954750", Offset = "0x3953550", VA = "0x183954750")]
	[LMKBODNDMCL]
	public static IDisposable HHADLNHCEEL<T>(this T KHBFFGPDGLH, Action HCPGLDHCBKP, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3954750", Offset = "0x3953550", VA = "0x183954750")]
	[LMKBODNDMCL]
	public static IDisposable HHADLNHCEEL<T>(this T KHBFFGPDGLH, Action<float> HCPGLDHCBKP, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3954B00", Offset = "0x3953900", VA = "0x183954B00")]
	[LMKBODNDMCL]
	public static IDisposable HLEJCONPKDK<T>(this T KHBFFGPDGLH, Action HCPGLDHCBKP, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3954F00", Offset = "0x3953D00", VA = "0x183954F00")]
	[LMKBODNDMCL]
	public static IDisposable LHMCCNIGKJP<T>(this T KHBFFGPDGLH, Action HCPGLDHCBKP, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3954DB0", Offset = "0x3953BB0", VA = "0x183954DB0")]
	[LMKBODNDMCL]
	public static IDisposable JNJNGFBIOAJ<T>(this T KHBFFGPDGLH, Action HCPGLDHCBKP, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3954F50", Offset = "0x3953D50", VA = "0x183954F50")]
	[LMKBODNDMCL]
	public static IDisposable MFABOIHBCAO<T>(this T KHBFFGPDGLH, float AHIPGGGAAHP, Action<float> HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8887E90", Offset = "0x8886C90", VA = "0x188887E90")]
	[LMKBODNDMCL]
	public static IDisposable MFABOIHBCAO(this MonoBehaviour KHBFFGPDGLH, GCNHNEMJEGC JAPGNGDBBIF, float AHIPGGGAAHP, Action<float> HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3954B50", Offset = "0x3953950", VA = "0x183954B50")]
	[LMKBODNDMCL]
	public static IDisposable HMPFPIOIEOI<T>(this T KHBFFGPDGLH, float AHIPGGGAAHP, Action<float> HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3954D60", Offset = "0x3953B60", VA = "0x183954D60")]
	[LMKBODNDMCL]
	public static IDisposable JBNCCLFHNCG<T>(this T KHBFFGPDGLH, float AHIPGGGAAHP, Action<float> HCPGLDHCBKP, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x39545E0", Offset = "0x39533E0", VA = "0x1839545E0")]
	[LMKBODNDMCL]
	public static IDisposable AJFFNDEBHJP<T>(this T KHBFFGPDGLH, Action<float> HCPGLDHCBKP, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3954E00", Offset = "0x3953C00", VA = "0x183954E00")]
	[LMKBODNDMCL]
	public static IDisposable JNPNOOEILIJ<T>(this T KHBFFGPDGLH, Action<float> HCPGLDHCBKP, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3955050", Offset = "0x3953E50", VA = "0x183955050")]
	[LMKBODNDMCL]
	public static IDisposable OPABDIMMIBA<T>(this T KHBFFGPDGLH, Action<float> HCPGLDHCBKP, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3954690", Offset = "0x3953490", VA = "0x183954690")]
	[LMKBODNDMCL]
	public static IDisposable CIGPAOIJPMJ<T>(this T KHBFFGPDGLH, Action<float> HCPGLDHCBKP, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x39546F0", Offset = "0x39534F0", VA = "0x1839546F0")]
	[LMKBODNDMCL]
	public static IDisposable EILEGMLBEEH<T>(this T KHBFFGPDGLH, Action<float> HCPGLDHCBKP, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3954EA0", Offset = "0x3953CA0", VA = "0x183954EA0")]
	[LMKBODNDMCL]
	public static IDisposable KLEDOIBMAFM<T>(this T KHBFFGPDGLH, Action<float> HCPGLDHCBKP, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3954FF0", Offset = "0x3953DF0", VA = "0x183954FF0")]
	[LMKBODNDMCL]
	public static IDisposable OOCECNLABCH<T>(this T KHBFFGPDGLH, Action<float> HCPGLDHCBKP, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3954640", Offset = "0x3953440", VA = "0x183954640")]
	[LMKBODNDMCL]
	public static IDisposable BICLPFIIPHF<T>(this T KHBFFGPDGLH, float AHIPGGGAAHP, Action<float> HCPGLDHCBKP, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3954D00", Offset = "0x3953B00", VA = "0x183954D00")]
	[LMKBODNDMCL]
	public static IDisposable IOPGHGFFNIN<T>(this T KHBFFGPDGLH, Action<float> HCPGLDHCBKP, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3954F90", Offset = "0x3953D90", VA = "0x183954F90")]
	[LMKBODNDMCL]
	public static IDisposable NBJBPCIJAAI<T>(this T KHBFFGPDGLH, Action<float> HCPGLDHCBKP, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true) where T : MonoBehaviour, GCNHNEMJEGC
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class HCDJAPEIGJD
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class IBIKGMDEKOC : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public MIMOCNKNDNH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private CPPCKFIKCEE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public IBIKGMDEKOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8885630", Offset = "0x8884430", VA = "0x188885630", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8885710", Offset = "0x8884510", VA = "0x188885710", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class JKADICICHAG : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public MIMOCNKNDNH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private CPPCKFIKCEE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public JKADICICHAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8889DA0", Offset = "0x8888BA0", VA = "0x188889DA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8889E90", Offset = "0x8888C90", VA = "0x188889E90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8884000", Offset = "0x8882E00", VA = "0x188884000")]
	public static BGLABEGMMJM HJMFFPECPLA(Action HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8883F70", Offset = "0x8882D70", VA = "0x188883F70")]
	public static BGLABEGMMJM HJMFFPECPLA(Behaviour JAPGNGDBBIF, Action HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8883E90", Offset = "0x8882C90", VA = "0x188883E90")]
	public static BGLABEGMMJM HJMFFPECPLA(Behaviour JAPGNGDBBIF, Action<float> HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8884080", Offset = "0x8882E80", VA = "0x188884080")]
	[IteratorStateMachine(typeof(IBIKGMDEKOC))]
	private static IEnumerator<GCOFLMDGPIM> LEENEBPOMFE(MIMOCNKNDNH LGLHOLCLMEN, Action HCPGLDHCBKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8884110", Offset = "0x8882F10", VA = "0x188884110")]
	[IteratorStateMachine(typeof(JKADICICHAG))]
	private static IEnumerator<GCOFLMDGPIM> LEENEBPOMFE(MIMOCNKNDNH LGLHOLCLMEN, Action<float> HCPGLDHCBKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class GMCLKHHFEJC : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class FCHIACGHFDF : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public GMCLKHHFEJC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public FCHIACGHFDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x887E620", Offset = "0x887D420", VA = "0x18887E620", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x887E6B0", Offset = "0x887D4B0", VA = "0x18887E6B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly MIMOCNKNDNH HAIPPAABHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action OBIOLKOIFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool JFBBPNEKCJJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool IGGJDLMDHKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED10", Offset = "0xA0DB10", VA = "0x180A0ED10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8880DD0", Offset = "0x887FBD0", VA = "0x188880DD0")]
	public GMCLKHHFEJC(MIMOCNKNDNH HAIPPAABHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8880CB0", Offset = "0x887FAB0", VA = "0x188880CB0")]
	[IteratorStateMachine(typeof(FCHIACGHFDF))]
	private IEnumerator<GCOFLMDGPIM> BMPIDODLADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8880D30", Offset = "0x887FB30", VA = "0x188880D30", Slot = "4")]
	public void OnCompleted(Action KMLADDINOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	public void HHMPPDCCHNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class AHLOOOJJFFE
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8876BF0", Offset = "0x88759F0", VA = "0x188876BF0")]
	public static GMCLKHHFEJC BCGDNIKCDKC(this MIMOCNKNDNH HAIPPAABHJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class GFCGKCGIBIC
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class LBKPJKBHJLE : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public JBDLGBKHPGM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public LBKPJKBHJLE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x888C6C0", Offset = "0x888B4C0", VA = "0x18888C6C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x888C740", Offset = "0x888B540", VA = "0x18888C740", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8880960", Offset = "0x887F760", VA = "0x188880960")]
	public static BGLABEGMMJM HJMFFPECPLA(float AHIPGGGAAHP, Action<float> HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL, bool HAHAEAFNFKJ = true, [Optional] NODJGDJJMNJ FPNMOHNEPFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8880A30", Offset = "0x887F830", VA = "0x188880A30")]
	public static BGLABEGMMJM HJMFFPECPLA(MonoBehaviour KHBFFGPDGLH, float AHIPGGGAAHP, Action<float> HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL, bool HAHAEAFNFKJ = true, [Optional] NODJGDJJMNJ FPNMOHNEPFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8880870", Offset = "0x887F670", VA = "0x188880870")]
	public static BGLABEGMMJM FIPNPMOCOFB(MonoBehaviour KHBFFGPDGLH, float AHIPGGGAAHP, Action<float> HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL, bool HAHAEAFNFKJ = true, [Optional] NODJGDJJMNJ FPNMOHNEPFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x88807A0", Offset = "0x887F5A0", VA = "0x1888807A0")]
	public static BGLABEGMMJM AGEOBJHJMBB(DCPGGKBOJAN JAPGNGDBBIF, float AHIPGGGAAHP, Action<float> HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL, bool HAHAEAFNFKJ = true, [Optional] NODJGDJJMNJ FPNMOHNEPFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8880B60", Offset = "0x887F960", VA = "0x188880B60")]
	private static IEnumerator<GCOFLMDGPIM> LEENEBPOMFE(LKJIMCMLAJH CIKECEHFCMM, float AHIPGGGAAHP, MIMOCNKNDNH LGLHOLCLMEN, Action<float> HCPGLDHCBKP, bool HAHAEAFNFKJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8880B00", Offset = "0x887F900", VA = "0x188880B00")]
	private static IEnumerator<GCOFLMDGPIM> KABLJCKCLPE(LKJIMCMLAJH CIKECEHFCMM, float AHIPGGGAAHP, MIMOCNKNDNH LGLHOLCLMEN, Action<float> HCPGLDHCBKP, bool HAHAEAFNFKJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8880C20", Offset = "0x887FA20", VA = "0x188880C20")]
	[IteratorStateMachine(typeof(LBKPJKBHJLE))]
	private static IEnumerator<GCOFLMDGPIM> OAGOFMANOFJ(JBDLGBKHPGM DLMLMLJKPCA, float AHIPGGGAAHP, MIMOCNKNDNH LGLHOLCLMEN, Action<float> HCPGLDHCBKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class BJGCHBLANCI
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class IDACKECHJKD : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public MIMOCNKNDNH queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public IDACKECHJKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8885A50", Offset = "0x8884850", VA = "0x188885A50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8885B10", Offset = "0x8884910", VA = "0x188885B10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8877C60", Offset = "0x8876A60", VA = "0x188877C60")]
	[IteratorStateMachine(typeof(IDACKECHJKD))]
	private static IEnumerator<GCOFLMDGPIM> GIOCABMDKMM(MIMOCNKNDNH HAIPPAABHJL, Func<bool> BEHJKDNMPEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8877B80", Offset = "0x8876980", VA = "0x188877B80")]
	public static BGLABEGMMJM GFAHGHDPGLC(this MonoBehaviour KHBFFGPDGLH, Func<bool> BEHJKDNMPEJ, MIMOCNKNDNH HAIPPAABHJL = MIMOCNKNDNH.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class DJCMDIJLMHN
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class NGAPJILFLJG : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public MIMOCNKNDNH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public NGAPJILFLJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x88917E0", Offset = "0x88905E0", VA = "0x1888917E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8891850", Offset = "0x8890650", VA = "0x188891850", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class DFIPHCPOPNA<T> : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public MIMOCNKNDNH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public DFIPHCPOPNA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6B090D0", Offset = "0x6B07ED0", VA = "0x186B090D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6B09170", Offset = "0x6B07F70", VA = "0x186B09170", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class KDCHGBMGDEB : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public MIMOCNKNDNH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private GCOFLMDGPIM <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public KDCHGBMGDEB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x888A590", Offset = "0x8889390", VA = "0x18888A590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x888A620", Offset = "0x8889420", VA = "0x18888A620", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x887CCD0", Offset = "0x887BAD0", VA = "0x18887CCD0")]
	[IteratorStateMachine(typeof(NGAPJILFLJG))]
	private static IEnumerator<GCOFLMDGPIM> BMPIDODLADF(float POHFDNBLLPJ, MIMOCNKNDNH LGLHOLCLMEN, Action HPCIBKDHMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3759F20", Offset = "0x3758D20", VA = "0x183759F20")]
	[IteratorStateMachine(typeof(DFIPHCPOPNA<>))]
	private static IEnumerator<GCOFLMDGPIM> BMPIDODLADF<T>(float POHFDNBLLPJ, MIMOCNKNDNH LGLHOLCLMEN, Action<T> HPCIBKDHMEA, T EMEICEFCBEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x887CD70", Offset = "0x887BB70", VA = "0x18887CD70")]
	[IteratorStateMachine(typeof(KDCHGBMGDEB))]
	private static IEnumerator<GCOFLMDGPIM> DKGFOOBOCGE(float POHFDNBLLPJ, MIMOCNKNDNH LGLHOLCLMEN, Action HPCIBKDHMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x887CF00", Offset = "0x887BD00", VA = "0x18887CF00")]
	public static IDisposable FCDPFPJGNME(this MonoBehaviour KHBFFGPDGLH, float POHFDNBLLPJ, Action HPCIBKDHMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x887D120", Offset = "0x887BF20", VA = "0x18887D120")]
	public static BGLABEGMMJM JLKNPHGHMJN(this MonoBehaviour KHBFFGPDGLH, float POHFDNBLLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x887CE10", Offset = "0x887BC10", VA = "0x18887CE10")]
	public static BGLABEGMMJM FCDPFPJGNME(this MonoBehaviour KHBFFGPDGLH, float POHFDNBLLPJ, MIMOCNKNDNH LGLHOLCLMEN, Action HPCIBKDHMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x887D4D0", Offset = "0x887C2D0", VA = "0x18887D4D0")]
	public static BGLABEGMMJM PJHDJAKFPBP(this MonoBehaviour KHBFFGPDGLH, Action HPCIBKDHMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x375A140", Offset = "0x3758F40", VA = "0x18375A140")]
	public static BGLABEGMMJM PJHDJAKFPBP<T>(this MonoBehaviour KHBFFGPDGLH, Action<T> HPCIBKDHMEA, T EMEICEFCBEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x887D390", Offset = "0x887C190", VA = "0x18887D390")]
	public static BGLABEGMMJM NFKIGDJCIKO(this MonoBehaviour KHBFFGPDGLH, Action HPCIBKDHMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x887D250", Offset = "0x887C050", VA = "0x18887D250")]
	public static BGLABEGMMJM MFGAEGBPKGM(this MonoBehaviour KHBFFGPDGLH, Action HPCIBKDHMEA, [Optional] NODJGDJJMNJ FPNMOHNEPFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x887D1B0", Offset = "0x887BFB0", VA = "0x18887D1B0")]
	public static BGLABEGMMJM LAEKFKLPHPD(this MonoBehaviour KHBFFGPDGLH, Action HPCIBKDHMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x887D2F0", Offset = "0x887C0F0", VA = "0x18887D2F0")]
	public static BGLABEGMMJM MOMMLNAJLHN(this MonoBehaviour KHBFFGPDGLH, Action HPCIBKDHMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x887CFE0", Offset = "0x887BDE0", VA = "0x18887CFE0")]
	public static BGLABEGMMJM GKGDKJJMFGD(MonoBehaviour KHBFFGPDGLH, MIMOCNKNDNH HAIPPAABHJL, Action HPCIBKDHMEA, [Optional] NODJGDJJMNJ FPNMOHNEPFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x375A000", Offset = "0x3758E00", VA = "0x18375A000")]
	public static BGLABEGMMJM GKGDKJJMFGD<T>(MonoBehaviour KHBFFGPDGLH, MIMOCNKNDNH HAIPPAABHJL, Action<T> HPCIBKDHMEA, T EMEICEFCBEP, [Optional] NODJGDJJMNJ FPNMOHNEPFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x887D610", Offset = "0x887C410", VA = "0x18887D610")]
	public static BGLABEGMMJM PKLEKEMMDFK(this MonoBehaviour KHBFFGPDGLH, float EGKFMIHINBD, Action HPCIBKDHMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x887D430", Offset = "0x887C230", VA = "0x18887D430")]
	public static BGLABEGMMJM OFEABIJAMBJ(this MonoBehaviour KHBFFGPDGLH, float EGKFMIHINBD, Action HPCIBKDHMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x887D080", Offset = "0x887BE80", VA = "0x18887D080")]
	public static BGLABEGMMJM JGBMFPJENOO(this MonoBehaviour KHBFFGPDGLH, float EGKFMIHINBD, Action HPCIBKDHMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x887D570", Offset = "0x887C370", VA = "0x18887D570")]
	public static BGLABEGMMJM PJINBOPAFJC(this MonoBehaviour KHBFFGPDGLH, float EGKFMIHINBD, Action HPCIBKDHMEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class EABAEILKCJC : KOOJGNHMNBC, IEnumerable<KOOJGNHMNBC>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly List<KOOJGNHMNBC> GILOGNBOLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool MJDMGFGACNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action LCBACBGFJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool OIKICFHCHGK;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OPMNADDADJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x887D800", Offset = "0x887C600", VA = "0x18887D800", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HAKHLHJJDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x887D9E0", Offset = "0x887C7E0", VA = "0x18887D9E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x887D940", Offset = "0x887C740", VA = "0x18887D940", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x887DF80", Offset = "0x887CD80", VA = "0x18887DF80")]
	public EABAEILKCJC([Optional] Action LCBACBGFJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x887D6D0", Offset = "0x887C4D0", VA = "0x18887D6D0")]
	public void AIKICPLLADB(KOOJGNHMNBC BKMFHHOIPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x887DB00", Offset = "0x887C900", VA = "0x18887DB00")]
	private void MHIJADBACEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x887DF70", Offset = "0x887CD70", VA = "0x18887DF70", Slot = "7")]
	public bool PDDOJPAMLGB(bool PGBCKJJIOAA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x887DC60", Offset = "0x887CA60", VA = "0x18887DC60", Slot = "8")]
	public bool PDDOJPAMLGB(Action CFDGGKIIHOI, bool PGBCKJJIOAA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x887DA80", Offset = "0x887C880", VA = "0x18887DA80", Slot = "9")]
	public IEnumerator<KOOJGNHMNBC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x887DA80", Offset = "0x887C880", VA = "0x18887DA80", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PFBAKDMIBEP : HMGHBFHOCBG
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class EJEDJIDAOIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public PFBAKDMIBEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public EJEDJIDAOIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8877950", Offset = "0x8876750", VA = "0x188877950")]
		internal void BIPHCMKAPCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class BCALEJMIENI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public PFBAKDMIBEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public BCALEJMIENI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8877950", Offset = "0x8876750", VA = "0x188877950")]
		internal void LNIAAJNCBPE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float KCADBOFKDLA;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x8888AF0", Offset = "0x88878F0", VA = "0x188888AF0")]
	public PFBAKDMIBEP(Behaviour JAPGNGDBBIF, float KCADBOFKDLA, [Optional] Action LCBACBGFJJN, [Optional] NODJGDJJMNJ FPNMOHNEPFF, [Optional] LKJIMCMLAJH CIKECEHFCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8891B60", Offset = "0x8890960", VA = "0x188891B60", Slot = "9")]
	protected override bool JMMKMIAELDH(Action CFDGGKIIHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x8891A50", Offset = "0x8890850", VA = "0x188891A50", Slot = "10")]
	protected override bool IECAGECNNBJ(Action CFDGGKIIHOI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface KOOJGNHMNBC
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool OPMNADDADJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action HAKHLHJJDHF;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PDDOJPAMLGB(bool PGBCKJJIOAA = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PDDOJPAMLGB(Action CFDGGKIIHOI, bool PGBCKJJIOAA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class HMGHBFHOCBG : KOOJGNHMNBC
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KBEEAIDIPBD : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public HMGHBFHOCBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public KBEEAIDIPBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x888A470", Offset = "0x8889270", VA = "0x18888A470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x888A540", Offset = "0x8889340", VA = "0x18888A540", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Behaviour JAPGNGDBBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Action LCBACBGFJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private OJJOHCMLHDB BIKLGEODLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly NODJGDJJMNJ FPNMOHNEPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly LKJIMCMLAJH CIKECEHFCMM;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool OPMNADDADJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1AAFAB0", Offset = "0x1AAE8B0", VA = "0x181AAFAB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action HAKHLHJJDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8885340", Offset = "0x8884140", VA = "0x188885340", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8884FC0", Offset = "0x8883DC0", VA = "0x188884FC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8885500", Offset = "0x8884300", VA = "0x188885500")]
	protected HMGHBFHOCBG(Behaviour JAPGNGDBBIF, [Optional] Action LCBACBGFJJN, [Optional] NODJGDJJMNJ FPNMOHNEPFF, [Optional] LKJIMCMLAJH CIKECEHFCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x88854A0", Offset = "0x88842A0", VA = "0x1888854A0", Slot = "7")]
	public bool PDDOJPAMLGB(bool PGBCKJJIOAA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8885440", Offset = "0x8884240", VA = "0x188885440", Slot = "8")]
	public bool PDDOJPAMLGB(Action CFDGGKIIHOI, bool PGBCKJJIOAA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool JMMKMIAELDH(Action CFDGGKIIHOI);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool IECAGECNNBJ(Action CFDGGKIIHOI);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8885420", Offset = "0x8884220", VA = "0x188885420")]
	protected void KNOFFBAODBF(Action CFDGGKIIHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8885060", Offset = "0x8883E60", VA = "0x188885060")]
	protected AAFDGGPNGMA DMNPAPDOKLF(float NFGIPBFMCLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8884F40", Offset = "0x8883D40", VA = "0x188884F40")]
	private void DDMFADNIGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x88852B0", Offset = "0x88840B0", VA = "0x1888852B0")]
	[IteratorStateMachine(typeof(KBEEAIDIPBD))]
	private IEnumerator<GCOFLMDGPIM> EOJBODLPCMK(float NFGIPBFMCLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x88853E0", Offset = "0x88841E0", VA = "0x1888853E0")]
	[CompilerGenerated]
	private void KAEDCMLHJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class FJEOHOEONHC : HMGHBFHOCBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly float CCLFGDEFCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int ELLPGPGMAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float DNNKHBEEJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float[] GCLINBAMGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int GKOJLBGPGGH;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x887FA80", Offset = "0x887E880", VA = "0x18887FA80")]
	public FJEOHOEONHC(Behaviour JAPGNGDBBIF, float ALOGGNCEOOD, int ELLPGPGMAGH, [Optional] Action LCBACBGFJJN, float DNNKHBEEJFJ = 0f, [Optional] NODJGDJJMNJ FPNMOHNEPFF, [Optional] LKJIMCMLAJH CIKECEHFCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "9")]
	protected override bool JMMKMIAELDH(Action CFDGGKIIHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x887F880", Offset = "0x887E680", VA = "0x18887F880", Slot = "10")]
	protected override bool IECAGECNNBJ(Action CFDGGKIIHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x887F800", Offset = "0x887E600", VA = "0x18887F800")]
	private void HNINDHAIHEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class JHMBJIFLEFA : HMGHBFHOCBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float KCADBOFKDLA;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x8888AF0", Offset = "0x88878F0", VA = "0x188888AF0")]
	public JHMBJIFLEFA(Behaviour JAPGNGDBBIF, float KCADBOFKDLA, [Optional] Action LCBACBGFJJN, [Optional] NODJGDJJMNJ FPNMOHNEPFF, [Optional] LKJIMCMLAJH CIKECEHFCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "9")]
	protected override bool JMMKMIAELDH(Action CFDGGKIIHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x8888AB0", Offset = "0x88878B0", VA = "0x188888AB0", Slot = "10")]
	protected override bool IECAGECNNBJ(Action CFDGGKIIHOI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class JCDNIPBEKCO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class JBBFBNCMDBK : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public JBBFBNCMDBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8877EF0", Offset = "0x8876CF0", VA = "0x188877EF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8888070", Offset = "0x8886E70", VA = "0x188888070", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private BGLABEGMMJM FBLGKFOAABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private DCPGGKBOJAN JAPGNGDBBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Action<float> LKIMCNGJBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private MIMOCNKNDNH HAIPPAABHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private float KLIDOKNJEMO;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x88885C0", Offset = "0x88873C0", VA = "0x1888885C0")]
	public JCDNIPBEKCO(DCPGGKBOJAN JAPGNGDBBIF, float AHIPGGGAAHP, Action<float> HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x88880C0", Offset = "0x8886EC0", VA = "0x1888880C0")]
	private void ABOFEIMELHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8888230", Offset = "0x8887030", VA = "0x188888230")]
	private void CKEJNBOHJAA(string NGENEEODOJL, Action DGKMLJGBDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x88883C0", Offset = "0x88871C0", VA = "0x1888883C0")]
	[IteratorStateMachine(typeof(JBBFBNCMDBK))]
	private IEnumerator<GCOFLMDGPIM> FLACJGPMCDJ(Action DGKMLJGBDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8888360", Offset = "0x8887160", VA = "0x188888360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8888440", Offset = "0x8887240", VA = "0x188888440")]
	[CompilerGenerated]
	private void FNDMFIEJJIK(string ANMGGEBBMLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class JICGHMOBAFO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class CJDECDCDNLC : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public CJDECDCDNLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8877EF0", Offset = "0x8876CF0", VA = "0x188877EF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8877F60", Offset = "0x8876D60", VA = "0x188877F60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private BGLABEGMMJM FBLGKFOAABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private MonoBehaviour KHBFFGPDGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Action HCPGLDHCBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Action<float> LKIMCNGJBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private MIMOCNKNDNH HAIPPAABHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float KLIDOKNJEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private bool HAHAEAFNFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly NODJGDJJMNJ FPNMOHNEPFF;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8889C10", Offset = "0x8888A10", VA = "0x188889C10")]
	public JICGHMOBAFO(MonoBehaviour KHBFFGPDGLH, Action HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL, [Optional] NODJGDJJMNJ FPNMOHNEPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8889A40", Offset = "0x8888840", VA = "0x188889A40")]
	public JICGHMOBAFO(MonoBehaviour KHBFFGPDGLH, Action<float> HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL, [Optional] NODJGDJJMNJ FPNMOHNEPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8889860", Offset = "0x8888660", VA = "0x188889860")]
	public JICGHMOBAFO(MonoBehaviour KHBFFGPDGLH, float AHIPGGGAAHP, Action<float> HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL, bool HAHAEAFNFKJ = true, [Optional] NODJGDJJMNJ FPNMOHNEPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4C8B280", Offset = "0x4C8A080", VA = "0x184C8B280")]
	private JICGHMOBAFO(NODJGDJJMNJ FPNMOHNEPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x88891D0", Offset = "0x8887FD0", VA = "0x1888891D0")]
	internal static JICGHMOBAFO FGLHMEIPMDN(MonoBehaviour KHBFFGPDGLH, float AHIPGGGAAHP, Action<float> HCPGLDHCBKP, MIMOCNKNDNH HAIPPAABHJL, bool HAHAEAFNFKJ = true, [Optional] NODJGDJJMNJ FPNMOHNEPFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8889480", Offset = "0x8888280", VA = "0x188889480")]
	private void HJMFFPECPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8888F60", Offset = "0x8887D60", VA = "0x188888F60")]
	private void COMBDIKEGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8888C30", Offset = "0x8887A30", VA = "0x188888C30")]
	private void ABOFEIMELHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x88896D0", Offset = "0x88884D0", VA = "0x1888896D0")]
	private void OMFEDABEIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8888E30", Offset = "0x8887C30", VA = "0x188888E30")]
	private void CKEJNBOHJAA(string NGENEEODOJL, Action DGKMLJGBDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8889400", Offset = "0x8888200", VA = "0x188889400")]
	[IteratorStateMachine(typeof(CJDECDCDNLC))]
	private IEnumerator<GCOFLMDGPIM> FLACJGPMCDJ(Action DGKMLJGBDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8889170", Offset = "0x8887F70", VA = "0x188889170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x88895B0", Offset = "0x88883B0", VA = "0x1888895B0")]
	[CompilerGenerated]
	private void MAILACPGEKG(string ANMGGEBBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x88890E0", Offset = "0x8887EE0", VA = "0x1888890E0")]
	[CompilerGenerated]
	private void DDHCMKKJEOI(string ANMGGEBBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8888DA0", Offset = "0x8887BA0", VA = "0x188888DA0")]
	[CompilerGenerated]
	private void AGGKCOBKJMG(string ANMGGEBBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8889640", Offset = "0x8888440", VA = "0x188889640")]
	[CompilerGenerated]
	private void OFDCICCCDLK(string ANMGGEBBMLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum GNEMILNNCAD : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal sealed class NBIMBJJCIEJ : LKJIMCMLAJH
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float GJBBGPENBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8891550", Offset = "0x8890350", VA = "0x188891550", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public float BLAEKBBAEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x88914D0", Offset = "0x88902D0", VA = "0x1888914D0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public double KAFLEPPNKIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x88914B0", Offset = "0x88902B0", VA = "0x1888914B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x88914E0", Offset = "0x88902E0", VA = "0x1888914E0")]
	[ENKLKENGHAE.AANPNKKBMFF]
	internal static void KPJOAGLHFJF(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	[UnityEngine.Scripting.Preserve]
	internal NBIMBJJCIEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface BGPAEFDELBA
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEGKFCGHDCG(string IHGFMOMOADA);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJKJEOEKMDG();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface CJHOJOKMINH
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool JOMBMMHEOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool KFJKHIEBINM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class EKOHMOHIEID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public HBHEHHKAOOP EDLEJHEDKDH;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int KBDABDGGLJF
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x887E250", Offset = "0x887D050", VA = "0x18887E250")]
	public static GCOFLMDGPIM HPINADOCNDJ(IEnumerator<GCOFLMDGPIM> OLJDKIPINIM, OBJMLLBLAFA MEHDPIFMILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x887E190", Offset = "0x887CF90", VA = "0x18887E190")]
	public GCOFLMDGPIM HPINADOCNDJ(OBJMLLBLAFA[] KKDCDOBBHJD, IEnumerator<GCOFLMDGPIM>[] HGJJOIPCEJP, GCOFLMDGPIM[] JJNKLBJCCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x887E020", Offset = "0x887CE20", VA = "0x18887E020")]
	public void ANNMHPOCJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x887E3B0", Offset = "0x887D1B0", VA = "0x18887E3B0")]
	public void PDNDBBHPMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x887E050", Offset = "0x887CE50", VA = "0x18887E050")]
	public void GDAGOKEEDOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x887E020", Offset = "0x887CE20", VA = "0x18887E020")]
	public void JMFEKBCNPCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public EKOHMOHIEID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class HBHEHHKAOOP
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct EOPNJKBFCAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public EKOHMOHIEID POCDJEPKKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public DCPGGKBOJAN MPMBGDDFGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public OBJMLLBLAFA JMKHJBFPMNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IEnumerator<GCOFLMDGPIM> IBOKOGENBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public GCOFLMDGPIM JBBOPCAJJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public GNEMILNNCAD PMELIJHCMKA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct MIKMMPCLJFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public MIMOCNKNDNH KPPDFJMLBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public List<EOPNJKBFCAA> IFDBNAOBJGD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class FLKBMCPKMML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public OBJMLLBLAFA promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public HBHEHHKAOOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public DCPGGKBOJAN context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public EKOHMOHIEID routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public GNEMILNNCAD coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public GCOFLMDGPIM currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IEnumerator<GCOFLMDGPIM> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FLKBMCPKMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x887FC50", Offset = "0x887EA50", VA = "0x18887FC50")]
		internal void GGBJOCDFGLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class FHFGOLDHLAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public EKOHMOHIEID schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public HBHEHHKAOOP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FHFGOLDHLAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x887F3C0", Offset = "0x887E1C0", VA = "0x18887F3C0")]
		internal void LELNFMLFNAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class FEBPANKGMED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public EKOHMOHIEID schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public HBHEHHKAOOP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FEBPANKGMED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x887E700", Offset = "0x887D500", VA = "0x18887E700")]
		internal void IANPBPDBOIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class OCAFCAMILFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public EKOHMOHIEID schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public HBHEHHKAOOP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public OCAFCAMILFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8891920", Offset = "0x8890720", VA = "0x188891920")]
		internal void MLMPKPODJLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private const GNEMILNNCAD KFJNJIKJFKG = GNEMILNNCAD.Cancelled | GNEMILNNCAD.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly MIMOCNKNDNH HAIPPAABHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool[] CNNOEBEKPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<GNEMILNNCAD> JCEHLJBGMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeArray<float> KPLLOGDDOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<int> KLCBONEDCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<int> KHDEBDIIAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> MOIEHBOPCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> OILAIFFNNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> GMGBCCBLPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private EKOHMOHIEID[] JLIKAAAECMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private OBJMLLBLAFA[] KKDCDOBBHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private DCPGGKBOJAN[] FMEHBAGBDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private IEnumerator<GCOFLMDGPIM>[] DPPKHJOIILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private GCOFLMDGPIM[] IKGFMKLBFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int GPOLAENCFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int KIOMCEJDGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int NMACKFEHHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float DFCEJHKAJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private KOCKBBIIIJF FNFEPLBIOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JobHandle ALKDPBPLLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<EKOHMOHIEID> BKEHIAIIHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool JFGHHCLFFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<Action> LEFPLFMCDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<Action> OIGGHEGPEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool DLKPKDCCEFD;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public MIKMMPCLJFJ[] NDFIMOGMMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xAC6300", Offset = "0xAC5100", VA = "0x180AC6300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8881AA0", Offset = "0x88808A0", VA = "0x188881AA0")]
	private static int GGCFHDJGAPB(MIMOCNKNDNH HAIPPAABHJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8883830", Offset = "0x8882630", VA = "0x188883830")]
	public HBHEHHKAOOP(MIMOCNKNDNH HAIPPAABHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x8883650", Offset = "0x8882450", VA = "0x188883650")]
	private void POIGGDGILEN(int LBBBCLFHJBC, int MGDEAMEOKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8882F30", Offset = "0x8881D30", VA = "0x188882F30")]
	public void NEAHBCLMLDH(DCPGGKBOJAN JAPGNGDBBIF, GCOFLMDGPIM IKBDEKOBIEE, IEnumerator<GCOFLMDGPIM> OLJDKIPINIM, OBJMLLBLAFA MEHDPIFMILF, [Optional] EKOHMOHIEID MNMIMNBPHPG, GNEMILNNCAD PJPPIMOELCA = GNEMILNNCAD.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x8881AD0", Offset = "0x88808D0", VA = "0x188881AD0")]
	public void GNNCOOPODEO(IEnumerable<EOPNJKBFCAA> APFJJNNAAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x88814A0", Offset = "0x88802A0", VA = "0x1888814A0")]
	private EOPNJKBFCAA AONEJIMGEGC(int ODMAAJOKMGH)
	{
		return default(EOPNJKBFCAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x8881D10", Offset = "0x8880B10", VA = "0x188881D10")]
	private void GPMJFNIPIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x39168C0", Offset = "0x39156C0", VA = "0x1839168C0")]
	private static void LNPILIHALME<T>(int ODMAAJOKMGH, T[] BCPEGHEHILM, int ACINDEOBNPO, [Optional] T KPKKDJNCCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3916910", Offset = "0x3915710", VA = "0x183916910")]
	private static void LNPILIHALME<T>(int ODMAAJOKMGH, NativeArray<T> BCPEGHEHILM, int ACINDEOBNPO, [Optional] T KPKKDJNCCIG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x88832B0", Offset = "0x88820B0", VA = "0x1888832B0")]
	private void PJKIPMCLOKN(IEnumerable<EOPNJKBFCAA> APFJJNNAAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x8882A00", Offset = "0x8881800", VA = "0x188882A00")]
	private void IPJACECFCAL(EOPNJKBFCAA ONKNMBDENKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8882080", Offset = "0x8880E80", VA = "0x188882080")]
	private DOFNDPKDOKG IFMCJBHGNOJ(int FPCJDLILEID)
	{
		return default(DOFNDPKDOKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x88830B0", Offset = "0x8881EB0", VA = "0x1888830B0")]
	public void NPAMKJAOLLC(float KODMODKKFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8882EB0", Offset = "0x8881CB0", VA = "0x188882EB0")]
	private void MPCIFNOGGBB(Action CHIPBNNCPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8882AD0", Offset = "0x88818D0", VA = "0x188882AD0")]
	private void JAMJKDKANGD(Action CHIPBNNCPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x88822E0", Offset = "0x88810E0", VA = "0x1888822E0")]
	public void IMJADMIGHBL(float KODMODKKFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x8882DB0", Offset = "0x8881BB0", VA = "0x188882DB0")]
	public void LNJEMOCDJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8882B50", Offset = "0x8881950", VA = "0x188882B50")]
	public void JMFEKBCNPCJ(EKOHMOHIEID DLMLMLJKPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8882C80", Offset = "0x8881A80", VA = "0x188882C80")]
	public void LADOGLBAAOK(EKOHMOHIEID DLMLMLJKPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8881970", Offset = "0x8880770", VA = "0x188881970")]
	public void EFFABGGBFPN(EKOHMOHIEID DLMLMLJKPCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class FEGDKKGBDLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static readonly FEGDKKGBDLP LJAJAMKHAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Action JDNGNIOHEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool OMPJCPABCDP;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public FEGDKKGBDLP(Action JDNGNIOHEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F05670", Offset = "0x7F04470", VA = "0x187F05670", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface BDNHCEFMNFD<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	T COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable KCLEDNCKPOI(UnityEngine.Object JAPGNGDBBIF, Action<T> HIJHJMJOIJP);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface EBLOICJGBOK<T> : BDNHCEFMNFD<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	new T COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class NMINJADDJLM<T> : EBLOICJGBOK<T>, BDNHCEFMNFD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class CFFKOEIIPOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public NMINJADDJLM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public NMADFLMJKJJ<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CFFKOEIIPOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6558C00", Offset = "0x6557A00", VA = "0x186558C00")]
		internal void DDIDEJHKNPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static GameObject CJJOGLGMKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<NMADFLMJKJJ<UnityEngine.Object, Action<T>>> KHAMHFBOILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private T ENDBCPPONLD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0C50", VA = "0x180AC1E50", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x54FFC30", Offset = "0x54FEA30", VA = "0x1854FFC30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x54FFB70", Offset = "0x54FE970", VA = "0x1854FFB70")]
	private static bool KJMDIHPDENM(T CHIPBNNCPBF, T MDEAIGKHMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x54FFE40", Offset = "0x54FEC40", VA = "0x1854FFE40")]
	public NMINJADDJLM(T OKHFLFNDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x54FF7E0", Offset = "0x54FE5E0", VA = "0x1854FF7E0", Slot = "6")]
	public IDisposable KCLEDNCKPOI(UnityEngine.Object JAPGNGDBBIF, Action<T> HIJHJMJOIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x54FF160", Offset = "0x54FDF60", VA = "0x1854FF160")]
	private void EGABOPCLJMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class PFODAFHIBCC : IPFLAGIKMNP
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class HFFLLGDIIMM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private class DLIFPALBGJG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int FONJFDCCINO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private HFFLLGDIIMM LGLHOLCLMEN;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xEEB9B0", Offset = "0xEEA7B0", VA = "0x180EEB9B0")]
			public DLIFPALBGJG(int FONJFDCCINO, HFFLLGDIIMM LGLHOLCLMEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x887D6A0", Offset = "0x887C4A0", VA = "0x18887D6A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class EBJEPMJFGBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public EBJEPMJFGBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xDE4170", Offset = "0xDE2F70", VA = "0x180DE4170")]
			internal bool FNIENJHKKLJ(DJBLDDMACHD e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class AGENDAHEMKE : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private GCOFLMDGPIM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public HFFLLGDIIMM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public LKJIMCMLAJH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private CPPCKFIKCEE <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private List<DJBLDDMACHD> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
			[DebuggerHidden]
			public AGENDAHEMKE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8876870", Offset = "0x8875670", VA = "0x188876870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8876BA0", Offset = "0x88759A0", VA = "0x188876BA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly MIMOCNKNDNH HAIPPAABHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private BGLABEGMMJM MEHDPIFMILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly List<DJBLDDMACHD> AKAPGMCKHPC;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x88845A0", Offset = "0x88833A0", VA = "0x1888845A0")]
		public HFFLLGDIIMM(MIMOCNKNDNH HAIPPAABHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8884330", Offset = "0x8883130", VA = "0x188884330")]
		public IDisposable DAHEBCLIILM(DJBLDDMACHD FANKIAOKAOO, NODJGDJJMNJ FPNMOHNEPFF, LKJIMCMLAJH HMLAIBMJFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x88841A0", Offset = "0x8882FA0", VA = "0x1888841A0")]
		private void BPFAAKMBBKK(int FONJFDCCINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8884510", Offset = "0x8883310", VA = "0x188884510")]
		[IteratorStateMachine(typeof(AGENDAHEMKE))]
		private IEnumerator<GCOFLMDGPIM> LEENEBPOMFE(LKJIMCMLAJH HMLAIBMJFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x88844C0", Offset = "0x88832C0", VA = "0x1888844C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class DJBLDDMACHD
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public enum KBDGFPIIONP : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static int FGANGKJLOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public readonly int OCNPBLDHFMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public readonly GCNHNEMJEGC MPMBGDDFGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly MonoBehaviour GICJBJIJJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public readonly Action JPEBABACHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public readonly Action<float> CBDDMJGMLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public readonly float KFHCKFDENNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float KPLLOGDDOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public readonly string KHKODDKNOBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public readonly bool OIILBGBEBCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public readonly KBDGFPIIONP FIHHOLPIBDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool OALDHCBAEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public bool BIKDFFLLOKK;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x887CB50", Offset = "0x887B950", VA = "0x18887CB50")]
		public DJBLDDMACHD(GCNHNEMJEGC JAPGNGDBBIF, Action HCPGLDHCBKP, bool LKBKEILDFGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x887C7F0", Offset = "0x887B5F0", VA = "0x18887C7F0")]
		public DJBLDDMACHD(GCNHNEMJEGC JAPGNGDBBIF, Action<float> HCPGLDHCBKP, bool LKBKEILDFGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x887C970", Offset = "0x887B770", VA = "0x18887C970")]
		public DJBLDDMACHD(GCNHNEMJEGC JAPGNGDBBIF, float AHIPGGGAAHP, Action<float> HCPGLDHCBKP, LKJIMCMLAJH HMLAIBMJFEO, KBDGFPIIONP FOPLGOEHMFG, bool HAHAEAFNFKJ, bool LKBKEILDFGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x887C620", Offset = "0x887B420", VA = "0x18887C620")]
		public bool PPCHICOIACF(float CKLBNPGGJHL, float DHOICJONLBJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly NODJGDJJMNJ FPNMOHNEPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly LKJIMCMLAJH CIKECEHFCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Dictionary<MIMOCNKNDNH, HFFLLGDIIMM> OFFIHFLMDBJ;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8891F30", Offset = "0x8890D30", VA = "0x188891F30")]
	[ENKLKENGHAE.AANPNKKBMFF]
	internal static void IEMCBIPOMEG(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8892740", Offset = "0x8891540", VA = "0x188892740")]
	[UnityEngine.Scripting.Preserve]
	internal PFODAFHIBCC([LCNEJNNIOGA(null)] NODJGDJJMNJ FPNMOHNEPFF, [LCNEJNNIOGA(null)] LKJIMCMLAJH CIKECEHFCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8892220", Offset = "0x8891020", VA = "0x188892220", Slot = "4")]
	public IDisposable JPEBABACHJL(GCNHNEMJEGC JAPGNGDBBIF, Action LDLIMOGOGBF, MIMOCNKNDNH HAIPPAABHJL, bool LKBKEILDFGB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x8892410", Offset = "0x8891210", VA = "0x188892410", Slot = "5")]
	public IDisposable JPEBABACHJL(GCNHNEMJEGC JAPGNGDBBIF, Action<float> LDLIMOGOGBF, MIMOCNKNDNH HAIPPAABHJL, bool LKBKEILDFGB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x8892120", Offset = "0x8890F20", VA = "0x188892120", Slot = "7")]
	public IDisposable JBNCCLFHNCG(GCNHNEMJEGC JAPGNGDBBIF, float AHIPGGGAAHP, Action<float> LDLIMOGOGBF, MIMOCNKNDNH HAIPPAABHJL, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x8891C70", Offset = "0x8890A70", VA = "0x188891C70", Slot = "8")]
	public IDisposable AGDLADFNEKI(GCNHNEMJEGC JAPGNGDBBIF, float AHIPGGGAAHP, Action<float> LDLIMOGOGBF, MIMOCNKNDNH HAIPPAABHJL, bool HAHAEAFNFKJ = true, bool LKBKEILDFGB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8891FA0", Offset = "0x8890DA0", VA = "0x188891FA0", Slot = "6")]
	public IDisposable JBNCCLFHNCG(float AHIPGGGAAHP, Action<float> LDLIMOGOGBF, bool HAHAEAFNFKJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8891D70", Offset = "0x8890B70", VA = "0x188891D70", Slot = "9")]
	public void ANBMJCFGCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8892600", Offset = "0x8891400", VA = "0x188892600")]
	private HFFLLGDIIMM LLIEOODAIJI(MIMOCNKNDNH HAIPPAABHJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class LHPAHOPGKOM : KLBPABCOBBH, NODJGDJJMNJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private HBHEHHKAOOP[] DEDPPFMAAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private BGPAEFDELBA KBAMOLICFHM;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x888D2F0", Offset = "0x888C0F0", VA = "0x18888D2F0")]
	[ENKLKENGHAE.AANPNKKBMFF]
	internal static void KPJOAGLHFJF(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x888D480", Offset = "0x888C280", VA = "0x18888D480")]
	[UnityEngine.Scripting.Preserve]
	public LHPAHOPGKOM([LCNEJNNIOGA(null)] EOKEKLKJKMO GBKLGJPNNEN, [LCNEJNNIOGA(null)] LKJIMCMLAJH CIKECEHFCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x888CD70", Offset = "0x888BB70", VA = "0x18888CD70", Slot = "19")]
	public override BGLABEGMMJM BOCKOGPJEEF(DCPGGKBOJAN JAPGNGDBBIF, IEnumerator<GCOFLMDGPIM> HGIOCHLCMHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x888CAE0", Offset = "0x888B8E0", VA = "0x18888CAE0", Slot = "20")]
	public override void ANBMJCFGCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x888C8B0", Offset = "0x888B6B0", VA = "0x18888C8B0", Slot = "22")]
	public override void AGPMFDDHNMC(MIMOCNKNDNH HAIPPAABHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x888D220", Offset = "0x888C020", VA = "0x18888D220", Slot = "21")]
	protected override void JPEBABACHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x888CEA0", Offset = "0x888BCA0", VA = "0x18888CEA0")]
	private HBHEHHKAOOP CICGJFNCONH(MIMOCNKNDNH AAFMBEEMJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x888CFF0", Offset = "0x888BDF0", VA = "0x18888CFF0", Slot = "23")]
	internal override LJDOKPIHMPF GDKAFJMIGDK(IEnumerator<GCOFLMDGPIM> HGIOCHLCMHG, Behaviour JAPGNGDBBIF, OBJMLLBLAFA MEHDPIFMILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x888CF30", Offset = "0x888BD30", VA = "0x18888CF30", Slot = "24")]
	internal override LJECCBDOIDE EHGBPKEFCLB(MIMOCNKNDNH LGLHOLCLMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x888D360", Offset = "0x888C160", VA = "0x18888D360")]
	private void MBIHCFEJBJH(HBHEHHKAOOP EBCFGJINBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x888CED0", Offset = "0x888BCD0", VA = "0x18888CED0", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[BurstCompile]
internal struct KOCKBBIIIJF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ReadOnly]
	public float OFNEFKLMKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ReadOnly]
	public int GOMNBNPHIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<int> EOGOOIEPPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> JOCCMCMCGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<int> GEMIMHNGFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ReadOnly]
	public NativeArray<GNEMILNNCAD> ENJCBJIGNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	public NativeArray<float> LMPEJHGIGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[WriteOnly]
	public NativeArray<int> MOIEHBOPCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[WriteOnly]
	public NativeArray<int> KLCBONEDCNE;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x888BF20", Offset = "0x888AD20", VA = "0x18888BF20")]
	public static KOCKBBIIIJF BHEMCOAOOEF(int BFCKNAIEOBF, float KODMODKKFAD, NativeArray<GNEMILNNCAD> IBACOHAOFLM, NativeArray<float> JFMGMCCELAC, NativeArray<int> KNNKGBOGEKC, NativeArray<int> EGBNIPBEAFN, NativeArray<int> HDEBPPEIOCG, NativeArray<int> JOCCMCMCGCH, NativeArray<int> GEMIMHNGFAM)
	{
		return default(KOCKBBIIIJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x888C200", Offset = "0x888B000", VA = "0x18888C200", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x888C1C0", Offset = "0x888AFC0", VA = "0x18888C1C0")]
	private bool EMJIBPHDLIK(int GLAOLHCPLLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x888C3B0", Offset = "0x888B1B0", VA = "0x18888C3B0")]
	private void MEJODLFDKJF(NativeArray<int> OJFFBOCDIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x888C3E0", Offset = "0x888B1E0", VA = "0x18888C3E0")]
	private int NFEMEBBHDDE(int KGNKFPBDPOL, int HFHMBCPFDAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x888C2E0", Offset = "0x888B0E0", VA = "0x18888C2E0")]
	private void KFHGIDHILNB(NativeArray<int> OJFFBOCDIFN, int DIANDNKMENP, int JGFHGJBECJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x888BF80", Offset = "0x888AD80", VA = "0x18888BF80")]
	private void BLDFBFMJLDE(NativeArray<int> OJFFBOCDIFN, int CGDOLPHJBHJ, int KLKHHDDLCED, int OAFKJIMBOBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public abstract class KLBPABCOBBH : NODJGDJJMNJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly EOKEKLKJKMO GBKLGJPNNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected readonly LKJIMCMLAJH CIKECEHFCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private LJECCBDOIDE[] IHADBHKOKMF;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static NODJGDJJMNJ ICOFMPPJNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x888A870", Offset = "0x8889670", VA = "0x18888A870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool KNAODMGEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public MIMOCNKNDNH AFOIDIIGBBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MIMOCNKNDNH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public LKJIMCMLAJH HJAHEHLLNCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public GCOFLMDGPIM BAKKLKBFHNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public GCOFLMDGPIM ENMKHDLAPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public GCOFLMDGPIM PDJGHELAPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public GCOFLMDGPIM BPLAGANILHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x888B1B0", Offset = "0x8889FB0", VA = "0x18888B1B0")]
	public static BGLABEGMMJM FIBMKINGMMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x888B7D0", Offset = "0x888A5D0", VA = "0x18888B7D0")]
	[UnityEngine.Scripting.Preserve]
	protected KLBPABCOBBH([LCNEJNNIOGA(null)] EOKEKLKJKMO GBKLGJPNNEN, [LCNEJNNIOGA(null)] LKJIMCMLAJH CIKECEHFCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x888B500", Offset = "0x888A300", VA = "0x18888B500", Slot = "6")]
	public BGLABEGMMJM LECHDFIDIED(IEnumerator<GCOFLMDGPIM> HGIOCHLCMHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x888B300", Offset = "0x888A100", VA = "0x18888B300", Slot = "7")]
	public BGLABEGMMJM LECHDFIDIED(Behaviour JAPGNGDBBIF, IEnumerator<GCOFLMDGPIM> HGIOCHLCMHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract BGLABEGMMJM BOCKOGPJEEF(DCPGGKBOJAN JAPGNGDBBIF, IEnumerator<GCOFLMDGPIM> HGIOCHLCMHG);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x888A970", Offset = "0x8889770", VA = "0x18888A970", Slot = "20")]
	public virtual void ANBMJCFGCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x888B510", Offset = "0x888A310", VA = "0x18888B510", Slot = "9")]
	public void LLKPDPEKLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x888B2C0", Offset = "0x888A0C0", VA = "0x18888B2C0", Slot = "21")]
	protected virtual void JPEBABACHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x888B2A0", Offset = "0x888A0A0", VA = "0x18888B2A0")]
	private void HOBOFMOJDCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x888B2E0", Offset = "0x888A0E0", VA = "0x18888B2E0")]
	private void KILKEHDAEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x888B260", Offset = "0x888A060", VA = "0x18888B260")]
	private void HHADLNHCEEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x888B280", Offset = "0x888A080", VA = "0x18888B280")]
	private void HLEJCONPKDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x888B7B0", Offset = "0x888A5B0", VA = "0x18888B7B0")]
	private void PHIAFBFEFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x888B240", Offset = "0x888A040", VA = "0x18888B240")]
	private void GIKGMCKMFFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x888ADD0", Offset = "0x8889BD0", VA = "0x18888ADD0")]
	private void DNNJPJPIJMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x888A8E0", Offset = "0x88896E0", VA = "0x18888A8E0", Slot = "22")]
	public virtual void AGPMFDDHNMC(MIMOCNKNDNH HAIPPAABHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x888ABA0", Offset = "0x88899A0", VA = "0x18888ABA0")]
	private void CIPFFILFHBG(LJECCBDOIDE EBCFGJINBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x26FC680", Offset = "0x26FB480", VA = "0x1826FC680")]
	private LJECCBDOIDE BKBGCFNJBGC(MIMOCNKNDNH AAFMBEEMJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract LJDOKPIHMPF GDKAFJMIGDK(IEnumerator<GCOFLMDGPIM> HGIOCHLCMHG, Behaviour KHBFFGPDGLH, OBJMLLBLAFA CEJFMCAPJBB);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract LJECCBDOIDE EHGBPKEFCLB(MIMOCNKNDNH HAIPPAABHJL);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x888ADF0", Offset = "0x8889BF0", VA = "0x18888ADF0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x888B750", Offset = "0x888A550", VA = "0x18888B750", Slot = "15")]
	public GCOFLMDGPIM NGEHEFBLNDA(MIMOCNKNDNH LGLHOLCLMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x888AB10", Offset = "0x8889910", VA = "0x18888AB10", Slot = "16")]
	public GCOFLMDGPIM BBPBPINCHBB(float POHFDNBLLPJ, MIMOCNKNDNH LGLHOLCLMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x888AD70", Offset = "0x8889B70", VA = "0x18888AD70", Slot = "17")]
	public GCOFLMDGPIM DDDKNMBFACM(Func<bool> BEHJKDNMPEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class LJDOKPIHMPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly OBJMLLBLAFA MEHDPIFMILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly CJHOJOKMINH JAPGNGDBBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly bool LMEKOGIGHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private string IHGFMOMOADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private StackTrace LAJHALLNIPG;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<GCOFLMDGPIM> IBOKOGENBCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public GCOFLMDGPIM JBBOPCAJJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool MHMNFBDFGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x888D540", Offset = "0x888C340", VA = "0x18888D540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool EKFJKNDBKII
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xC3A4C0", Offset = "0xC392C0", VA = "0x180C3A4C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xC6F4E0", Offset = "0xC6E2E0", VA = "0x180C6F4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x888D5C0", Offset = "0x888C3C0", VA = "0x18888D5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float GNCJLCKKNPM
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x10B8AF0", Offset = "0x10B78F0", VA = "0x1810B8AF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7157140", Offset = "0x7155F40", VA = "0x187157140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x888DC30", Offset = "0x888CA30", VA = "0x18888DC30")]
	public LJDOKPIHMPF(IEnumerator<GCOFLMDGPIM> OLJDKIPINIM, CJHOJOKMINH JAPGNGDBBIF, OBJMLLBLAFA MEHDPIFMILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x888D770", Offset = "0x888C570", VA = "0x18888D770")]
	public GCOFLMDGPIM HPINADOCNDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x888DA90", Offset = "0x888C890", VA = "0x18888DA90")]
	public bool JDFMPDOOCIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x888DB00", Offset = "0x888C900", VA = "0x18888DB00")]
	public void JMFEKBCNPCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x888DB50", Offset = "0x888C950", VA = "0x18888DB50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xCB89A0", Offset = "0xCB77A0", VA = "0x180CB89A0")]
	[CompilerGenerated]
	private void PJGBFDFLEHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class OBJMLLBLAFA : HAPIPDPKHDI, BGLABEGMMJM, OJJOHCMLHDB, AAFDGGPNGMA, IEnumerator, GCOFLMDGPIM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private MIMOCNKNDNH OFKNPCBCJMI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private MIMOCNKNDNH KOLFBJFHODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xD92C10", Offset = "0xD91A10", VA = "0x180D92C10", Slot = "23")]
		get
		{
			return default(MIMOCNKNDNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MIMOCNKNDNH EDLEJHEDKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xF872E0", Offset = "0xF860E0", VA = "0x180F872E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float FKKAGHHGPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xC04280", Offset = "0xC03080", VA = "0x180C04280", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool GDCBGDOMHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x88918B0", Offset = "0x88906B0", VA = "0x1888918B0", Slot = "24")]
	private bool HAANNOMGHHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x88918A0", Offset = "0x88906A0", VA = "0x1888918A0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x88918D0", Offset = "0x88906D0", VA = "0x1888918D0")]
	public OBJMLLBLAFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal enum DOFNDPKDOKG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class LJECCBDOIDE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum KOPLKGMDHIF
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct GCBBBELGJCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public MIMOCNKNDNH KPPDFJMLBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public KOPLKGMDHIF AAMBLGCHPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public List<LJDOKPIHMPF> AEABNNAHOOE;
	}

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly KOPLKGMDHIF[] DBNMMOLOBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly MIMOCNKNDNH HAIPPAABHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool PDBGIDLABDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly LJDOKPIHMPF[] OMKPJIIMFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly List<LJDOKPIHMPF> JDPOCHHDOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Stack<int> HAPDNBOBHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly List<LJDOKPIHMPF> DLBDNAKNJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Stack<int> DHLINGDDFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly BGPAEFDELBA JONDPMPKJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool DLKPKDCCEFD;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GCBBBELGJCP[,] IGINFMEJNOC
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x888F370", Offset = "0x888E170", VA = "0x18888F370")]
	public LJECCBDOIDE(MIMOCNKNDNH LGLHOLCLMEN, BGPAEFDELBA JONDPMPKJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x888E800", Offset = "0x888D600", VA = "0x18888E800")]
	public void FCDIDDLJIMF(LJDOKPIHMPF OLJDKIPINIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x888E070", Offset = "0x888CE70", VA = "0x18888E070")]
	public void DPFLKILIALI(IList<LJDOKPIHMPF> HGJJOIPCEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x888EF20", Offset = "0x888DD20", VA = "0x18888EF20")]
	public void PCBFGGHDHLC(IList<LJDOKPIHMPF> HGJJOIPCEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x888DDF0", Offset = "0x888CBF0", VA = "0x18888DDF0")]
	private void ABMHKHBFHNO(LJDOKPIHMPF OLJDKIPINIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x888DEE0", Offset = "0x888CCE0", VA = "0x18888DEE0")]
	private void DGPGCGAEAFF(IList<LJDOKPIHMPF> HGJJOIPCEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x888EA40", Offset = "0x888D840", VA = "0x18888EA40")]
	private DOFNDPKDOKG JHBFDFHBILL(LJDOKPIHMPF OLJDKIPINIM)
	{
		return default(DOFNDPKDOKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x888EBC0", Offset = "0x888D9C0", VA = "0x18888EBC0")]
	public void JPEBABACHJL(float KODMODKKFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x888ED30", Offset = "0x888DB30", VA = "0x18888ED30")]
	public void LLKPDPEKLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x888E4A0", Offset = "0x888D2A0", VA = "0x18888E4A0")]
	private void EIALJNELACH(List<LJDOKPIHMPF> HGJJOIPCEJP, Stack<int> OGBAOJNOLOP, bool GNBGKGDDKBP, float EKJNJICPNBJ = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x888E380", Offset = "0x888D180", VA = "0x18888E380", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x888E900", Offset = "0x888D700", VA = "0x18888E900")]
	private void FFFNHMLOKPF(List<LJDOKPIHMPF> HGJJOIPCEJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class BJKGNHLABMB : BGPAEFDELBA
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void GEGKFCGHDCG(string IHGFMOMOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
	public void PJKJEOEKMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public BJKGNHLABMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal class OMAIPONBFNB : CJHOJOKMINH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Behaviour KHBFFGPDGLH;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8891980", Offset = "0x8890780", VA = "0x188891980", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool JOMBMMHEOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8891A00", Offset = "0x8890800", VA = "0x188891A00", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool KFJKHIEBINM
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8891960", Offset = "0x8890760", VA = "0x188891960", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public OMAIPONBFNB(Behaviour KHBFFGPDGLH)
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

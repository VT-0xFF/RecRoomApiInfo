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
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85A5EF0", Offset = "0x85A46F0", VA = "0x1885A5EF0", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AE320", Offset = "0x85ACB20", VA = "0x1885AE320", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
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
		private delegate List<PlayerLoopSystem> BDNINCBGFJM(List<PlayerLoopSystem> BPEADFHBAEL, int LILNMPGABCO);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct MFDJPNHGMFN
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct HKGGCIKJIEB
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static FIEKIAHLEMJ GELPMCLNJDL;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x85A3FD0", Offset = "0x85A27D0", VA = "0x1885A3FD0")]
				public static PlayerLoopSystem LHKJJMPMLDA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct OFDBKIKBKOC
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static FIEKIAHLEMJ LBJNAFGCNLG;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x85ABD70", Offset = "0x85AA570", VA = "0x1885ABD70")]
				public static PlayerLoopSystem LHKJJMPMLDA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct NNDLJFAFPKO
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static FIEKIAHLEMJ NFOJLPEIMJJ;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x85AB0A0", Offset = "0x85A98A0", VA = "0x1885AB0A0")]
				public static PlayerLoopSystem LHKJJMPMLDA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct LLIDMKLLIKP
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static FIEKIAHLEMJ JMLBODCDJMK;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static FIEKIAHLEMJ DJHKDFNNMAL;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static FIEKIAHLEMJ OCIFIGIIIPD;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static FIEKIAHLEMJ PHOPANOIKPB;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x85A5800", Offset = "0x85A4000", VA = "0x1885A5800")]
				public static PlayerLoopSystem LHKJJMPMLDA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct MGJPDABABFI
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static FIEKIAHLEMJ BFPFBNNHKLB;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x85A61A0", Offset = "0x85A49A0", VA = "0x1885A61A0")]
				public static PlayerLoopSystem LHKJJMPMLDA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct ICGADKCDDEP
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static FIEKIAHLEMJ JMLBODCDJMK;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static FIEKIAHLEMJ DJHKDFNNMAL;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static FIEKIAHLEMJ OCIFIGIIIPD;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static FIEKIAHLEMJ PHOPANOIKPB;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x85A41B0", Offset = "0x85A29B0", VA = "0x1885A41B0")]
				public static PlayerLoopSystem LHKJJMPMLDA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct PBOEAPILFJH
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static FIEKIAHLEMJ PFAFCCKFCDB;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x85AC130", Offset = "0x85AA930", VA = "0x1885AC130")]
				public static PlayerLoopSystem LHKJJMPMLDA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct DFGCGOILMHG
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static FIEKIAHLEMJ GCABKPCNCHD;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x85992C0", Offset = "0x8597AC0", VA = "0x1885992C0")]
				public static PlayerLoopSystem LHKJJMPMLDA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct AKNECKAICFK
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static FIEKIAHLEMJ ANLLMBIIMAH;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x85917F0", Offset = "0x858FFF0", VA = "0x1885917F0")]
				public static PlayerLoopSystem LHKJJMPMLDA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct ONFJDLAMLFJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static FIEKIAHLEMJ NIEAMNKDJGK;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x85ABF50", Offset = "0x85AA750", VA = "0x1885ABF50")]
				public static PlayerLoopSystem LHKJJMPMLDA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct NIPMLODLFIM
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static FIEKIAHLEMJ BJFGMHHMLGD;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x85AAEC0", Offset = "0x85A96C0", VA = "0x1885AAEC0")]
				public static PlayerLoopSystem LHKJJMPMLDA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct OEMCKDFANPE
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static FIEKIAHLEMJ HINFEPAENII;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x85ABB90", Offset = "0x85AA390", VA = "0x1885ABB90")]
				public static PlayerLoopSystem LHKJJMPMLDA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct AIBHFGDMDCG
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static FIEKIAHLEMJ HOEMDOPAEBL;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x8591610", Offset = "0x858FE10", VA = "0x188591610")]
				public static PlayerLoopSystem LHKJJMPMLDA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct CLBIPJOLFKC
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static FIEKIAHLEMJ AHKJKLOEDOO;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x8594D50", Offset = "0x8593550", VA = "0x188594D50")]
				public static PlayerLoopSystem LHKJJMPMLDA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct LNNFKACMGME
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static FIEKIAHLEMJ NNPCCOCBGFL;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x85A5D10", Offset = "0x85A4510", VA = "0x1885A5D10")]
				public static PlayerLoopSystem LHKJJMPMLDA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum KEHJLJCINIP : byte
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
			public struct KKJCOCLGAAF
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class DLKNODCDHGP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public KEHJLJCINIP updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
					public DLKNODCDHGP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x859A1E0", Offset = "0x85989E0", VA = "0x18859A1E0")]
					internal void FDOGMFCBALJ()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static HOPADDCECBJ<KEHJLJCINIP> CODEBBFCKMC;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x85A5270", Offset = "0x85A3A70", VA = "0x1885A5270")]
				public static PlayerLoopSystem LHKJJMPMLDA(KEHJLJCINIP AONMMEPPLMK)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct GDDCHNCDNCM
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class MOCDGFIEPHL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public DOKEJMDLHHA.KIKPKAMKMDK key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
					public MOCDGFIEPHL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x85A7080", Offset = "0x85A5880", VA = "0x1885A7080")]
					internal void OKMKACGFCDM()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable FHPEMLNIDKJ;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x85A0300", Offset = "0x859EB00", VA = "0x1885A0300")]
				public static PlayerLoopSystem NFGJMHACKAC(DOKEJMDLHHA.KIKPKAMKMDK BELIEAFHDAH)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct LLKIKIEPLKK
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class EBPAKAAJPLG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public DOKEJMDLHHA.KIKPKAMKMDK key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
					public EBPAKAAJPLG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x859A650", Offset = "0x8598E50", VA = "0x18859A650")]
					internal void OKMKACGFCDM()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x85A5AD0", Offset = "0x85A42D0", VA = "0x1885A5AD0")]
				public static PlayerLoopSystem NFGJMHACKAC(DOKEJMDLHHA.KIKPKAMKMDK BELIEAFHDAH)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class MBACAIHJBKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public MBACAIHJBKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x85A5F80", Offset = "0x85A4780", VA = "0x1885A5F80")]
			internal List<PlayerLoopSystem> LPJCOMPKDLG(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool GHFMCOGFOFK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool GLKJHHKHLGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8598890", Offset = "0x8597090", VA = "0x188598890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85951B0", Offset = "0x85939B0", VA = "0x1885951B0")]
		private static void ELGGICJBGHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85988D0", Offset = "0x85970D0", VA = "0x1885988D0")]
		private static void PFNPICKDLAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8594F30", Offset = "0x8593730", VA = "0x188594F30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8594F70", Offset = "0x8593770", VA = "0x188594F70")]
		private static void BCNKPGGMDGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85986D0", Offset = "0x8596ED0", VA = "0x1885986D0")]
		private static void NDLLDFELHFK(DOKEJMDLHHA.KIKPKAMKMDK BELIEAFHDAH, PlayerLoopSystem GLBOBCAJMFI, Type IBBKPBONMGJ, Type FBBMJNPIJNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85981C0", Offset = "0x85969C0", VA = "0x1885981C0")]
		private static void LHPCPAKNMNN(PlayerLoopSystem GLBOBCAJMFI, Type IBBKPBONMGJ, Type FBBMJNPIJNE, BDNINCBGFJM BCDMBLIPIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85985A0", Offset = "0x8596DA0", VA = "0x1885985A0")]
		private static void NAHKMPJBDCN(PlayerLoopSystem GLBOBCAJMFI, Type IBBKPBONMGJ, Type FBBMJNPIJNE, PlayerLoopSystem? GABCKPFBCHE, PlayerLoopSystem? ALJFMCDOLHI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class DOKEJMDLHHA
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum KIKPKAMKMDK
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
	public class FKPPDHEGBMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly KIKPKAMKMDK DGKOELNNEJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly BIHCKBFLDIM KIEJBNDIEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long GMBILEKINLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long EDJFMLKMJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long IGIHDHBFMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int EEFCOCMGAOG;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x859EA60", Offset = "0x859D260", VA = "0x18859EA60")]
		public FKPPDHEGBMA(KIKPKAMKMDK AIOFKIJMLFC, int PNJMNOGGAON = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x859E910", Offset = "0x859D110", VA = "0x18859E910")]
		public void CBMOPFCKEJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x859E930", Offset = "0x859D130", VA = "0x18859E930")]
		public void ENCMIDLIDPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x859E980", Offset = "0x859D180", VA = "0x18859E980")]
		public void MLIDDNDGEMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static KIKPKAMKMDK[] HBNHJFHDHEA;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static FKPPDHEGBMA[] EGJANJHFEPG;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x859A2D0", Offset = "0x8598AD0", VA = "0x18859A2D0")]
	public static FKPPDHEGBMA FHHCNDDMBMH(KIKPKAMKMDK BELIEAFHDAH, int PNJMNOGGAON = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x859A260", Offset = "0x8598A60", VA = "0x18859A260")]
	public static FKPPDHEGBMA EIBDKCOLCNK(KIKPKAMKMDK BELIEAFHDAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x859A420", Offset = "0x8598C20", VA = "0x18859A420")]
	public static void JBBNNEBOMNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EIDJIIHBGMF
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private interface DCDKFIJLCAH
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool JPEJJOMEFOG
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OOJHFJBDPKE();
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class NIEJANHJIEN : DCDKFIJLCAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action GFMBHCHPLDH;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool JPEJJOMEFOG
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
		public NIEJANHJIEN(Action GFMBHCHPLDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1107FE0", Offset = "0x11067E0", VA = "0x181107FE0", Slot = "5")]
		public void OOJHFJBDPKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<DCDKFIJLCAH> DLKJCNKDIGG;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x859C6B0", Offset = "0x859AEB0", VA = "0x18859C6B0")]
	public static void NKCADJJKIBD(Action GFMBHCHPLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x859C4A0", Offset = "0x859ACA0", VA = "0x18859C4A0")]
	private static void NIGKBIHBDIH(DCDKFIJLCAH DMPDDLKOHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x859C750", Offset = "0x859AF50", VA = "0x18859C750")]
	private static void PMDOBOLDPBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x859C3A0", Offset = "0x859ABA0", VA = "0x18859C3A0")]
	private static void DCGPEFAFCNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x859C2D0", Offset = "0x859AAD0", VA = "0x18859C2D0")]
	private static void BGFLJNJDIHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class FPAAHPNKLFM
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct LGKHHDCCBFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TaskCompletionSource<Scene> BFDFGNBMIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly string HOAJLCLGOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly LoadSceneMode CJFLPIEMDJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly bool DHAFJMEDOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x85A57A0", Offset = "0x85A3FA0", VA = "0x1885A57A0")]
		public LGKHHDCCBFC(TaskCompletionSource<Scene> MGDEAOFNAAC, string HOAJLCLGOHE, LoadSceneMode CJFLPIEMDJA, bool DHAFJMEDOCD, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct OCPFABHNMEK : IAsyncStateMachine
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
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private BGHFCMFIENI<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x85AB280", Offset = "0x85A9A80", VA = "0x1885AB280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x85ABB20", Offset = "0x85AA320", VA = "0x1885ABB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct PLDPBAGNFOG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85ACEA0", Offset = "0x85AB6A0", VA = "0x1885ACEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x85AD1B0", Offset = "0x85AB9B0", VA = "0x1885AD1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct HCKPDDAJBBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private LGKHHDCCBFC <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x85A2BA0", Offset = "0x85A13A0", VA = "0x1885A2BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x85A2F60", Offset = "0x85A1760", VA = "0x1885A2F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class JGANNJNJEAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NIBMKOGNDNO<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public JGANNJNJEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x85A4660", Offset = "0x85A2E60", VA = "0x1885A4660")]
		internal void PODPNNOCJJL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct DIFHPDELHIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

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
		private JGANNJNJEAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x85994A0", Offset = "0x8597CA0", VA = "0x1885994A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x859A040", Offset = "0x8598840", VA = "0x18859A040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct BJPDFEEFGJI : IAsyncStateMachine
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
		private LGBPIAHJJBO <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x85929E0", Offset = "0x85911E0", VA = "0x1885929E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x85930A0", Offset = "0x85918A0", VA = "0x1885930A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct PGBLEILMJFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x85AC310", Offset = "0x85AAB10", VA = "0x1885AC310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x85ACE30", Offset = "0x85AB630", VA = "0x1885ACE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class HEJNAOCNAKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public NIBMKOGNDNO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HEJNAOCNAKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x85A3220", Offset = "0x85A1A20", VA = "0x1885A3220")]
		internal bool PNHIJKADACO(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x85A2FC0", Offset = "0x85A17C0", VA = "0x1885A2FC0")]
		internal void NEJLOECDNJA(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class BKLBEAKBEGP : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IGCELENFGND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public NIBMKOGNDNO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private HEJNAOCNAKD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private LGBPIAHJJBO <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public BKLBEAKBEGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8593A80", Offset = "0x8592280", VA = "0x188593A80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x85931B0", Offset = "0x85919B0", VA = "0x1885931B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8593190", Offset = "0x8591990", VA = "0x188593190")]
		private void JCGGFCDKBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8593A30", Offset = "0x8592230", VA = "0x188593A30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ICollection<string> KOGAJBCHPGM;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static ELBPMMKABPA FCMBIDNEMOM;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AsyncOperation LBHDMEEBBCN;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static ELBPMMKABPA GHBIADCNOKK;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static string OPCBDBIFEID;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string MBAPCGEDLBA;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority OHNHGMKEBAB;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task ELOBGLNMKNF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static List<SceneInstance> NDMMILAOPHH;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly Queue<LGKHHDCCBFC> OKLEAJBNFOI;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static Task PMBMBJFPOPC;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> CKCACLKIINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x859F510", Offset = "0x859DD10", VA = "0x18859F510")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x859F620", Offset = "0x859DE20", VA = "0x18859F620")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x859F970", Offset = "0x859E170", VA = "0x18859F970")]
	[BOGLAMPKNMP(EGMDMPGLLBP.EnteredEditModeNextFrame, 0)]
	private static void IGKNIGNPJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x859FDA0", Offset = "0x859E5A0", VA = "0x18859FDA0")]
	[AsyncStateMachine(typeof(OCPFABHNMEK))]
	public static Task<Scene> MGJFIIKAIBL(string HOAJLCLGOHE, LoadSceneMode CJFLPIEMDJA = LoadSceneMode.Single, bool DHAFJMEDOCD = false, [Optional] BGHFCMFIENI<string>.KHCJHMNAJKC LOIBHONLBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x859FEF0", Offset = "0x859E6F0", VA = "0x18859FEF0")]
	[AsyncStateMachine(typeof(PLDPBAGNFOG))]
	private static Task OMCNLMMGNPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x859F440", Offset = "0x859DC40", VA = "0x18859F440")]
	[AsyncStateMachine(typeof(HCKPDDAJBBF))]
	private static Task EJCOPHNBDOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x859FFA0", Offset = "0x859E7A0", VA = "0x18859FFA0")]
	[AsyncStateMachine(typeof(DIFHPDELHIH))]
	private static Task<Scene> PBEOCHEPFCA(string HOAJLCLGOHE, LoadSceneMode CJFLPIEMDJA, bool DHAFJMEDOCD, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x859F1C0", Offset = "0x859D9C0", VA = "0x18859F1C0")]
	private static void CAPCHAEPHIL(SceneInstance CHKHGNKGCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x859EF10", Offset = "0x859D710", VA = "0x18859EF10")]
	private static void BLNJBFOFCOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x859F730", Offset = "0x859DF30", VA = "0x18859F730")]
	[AsyncStateMachine(typeof(BJPDFEEFGJI))]
	private static Task<Scene> HDJOCFJLMKE(string HOAJLCLGOHE, LoadSceneMode CJFLPIEMDJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x859FBF0", Offset = "0x859E3F0", VA = "0x18859FBF0")]
	private static bool LCJILBFLNHH(string HOAJLCLGOHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x859F860", Offset = "0x859E060", VA = "0x18859F860")]
	[AsyncStateMachine(typeof(PGBLEILMJFM))]
	private static Task<Scene> IGDABFGEGPB(BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x859F2C0", Offset = "0x859DAC0", VA = "0x18859F2C0")]
	public static KJPDFMLMKLI<Scene> DADCNIPPMOF(string HOAJLCLGOHE, LoadSceneMode CJFLPIEMDJA = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x859EE70", Offset = "0x859D670", VA = "0x18859EE70")]
	[IteratorStateMachine(typeof(BKLBEAKBEGP))]
	private static IEnumerator<IGCELENFGND> BHMMDDGLOMI(string HOAJLCLGOHE, LoadSceneMode CJFLPIEMDJA, NIBMKOGNDNO<Scene> FKLAEGPNDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x859FA60", Offset = "0x859E260", VA = "0x18859FA60")]
	public static void KGAMEEICHHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x859FCE0", Offset = "0x859E4E0", VA = "0x18859FCE0")]
	private static void LLLBGHGCPEH(string HOAJLCLGOHE, LoadSceneMode CJFLPIEMDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x859FAC0", Offset = "0x859E2C0", VA = "0x18859FAC0")]
	public static bool KJPNLOJFPIO([Out] string HBKKOBDNFIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EJLOLGJOGBA
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x859CBC0", Offset = "0x859B3C0", VA = "0x18859CBC0")]
	public static IDisposable MOAPIFHAINP(this OGNGNKLAHIB KLNHOILIBHH, float AOKCJBNEOJH, Action<float> FNLOEDFOJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x859CB40", Offset = "0x859B340", VA = "0x18859CB40")]
	public static IDisposable IKGHIPNLAKF(this OGNGNKLAHIB KLNHOILIBHH, Action<float> FNLOEDFOJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x859CAC0", Offset = "0x859B2C0", VA = "0x18859CAC0")]
	public static IDisposable BIEFMOKKDAE(this OGNGNKLAHIB KLNHOILIBHH, Action<float> FNLOEDFOJND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class IJBLKLCHMPB
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x37ECA20", Offset = "0x37EB220", VA = "0x1837ECA20")]
	[JGOEKBEIPHI]
	public static IDisposable CODFALJLFPG<T>(this T OLFMBCENCHB, Action FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x37EC870", Offset = "0x37EB070", VA = "0x1837EC870")]
	[JGOEKBEIPHI]
	public static IDisposable CODFALJLFPG<T>(this T OLFMBCENCHB, Action<float> FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x37ECE30", Offset = "0x37EB630", VA = "0x1837ECE30")]
	[JGOEKBEIPHI]
	public static IDisposable MAEEPMKIKNH<T>(this T OLFMBCENCHB, Action FNLOEDFOJND, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x37EC7C0", Offset = "0x37EAFC0", VA = "0x1837EC7C0")]
	[JGOEKBEIPHI]
	public static IDisposable CHCKPCCDOHI<T>(this T OLFMBCENCHB, Action FNLOEDFOJND, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x37EC7C0", Offset = "0x37EAFC0", VA = "0x1837EC7C0")]
	[JGOEKBEIPHI]
	public static IDisposable CHCKPCCDOHI<T>(this T OLFMBCENCHB, Action<float> FNLOEDFOJND, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x37EC720", Offset = "0x37EAF20", VA = "0x1837EC720")]
	[JGOEKBEIPHI]
	public static IDisposable AJFAHFPHICA<T>(this T OLFMBCENCHB, Action FNLOEDFOJND, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x37ECCF0", Offset = "0x37EB4F0", VA = "0x1837ECCF0")]
	[JGOEKBEIPHI]
	public static IDisposable IBIDLMFMMLE<T>(this T OLFMBCENCHB, Action FNLOEDFOJND, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x37ECED0", Offset = "0x37EB6D0", VA = "0x1837ECED0")]
	[JGOEKBEIPHI]
	public static IDisposable MOHPMGOOOKL<T>(this T OLFMBCENCHB, Action FNLOEDFOJND, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x37ECDF0", Offset = "0x37EB5F0", VA = "0x1837ECDF0")]
	[JGOEKBEIPHI]
	public static IDisposable JLGKLOPBPBE<T>(this T OLFMBCENCHB, float AOKCJBNEOJH, Action<float> FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x85A4480", Offset = "0x85A2C80", VA = "0x1885A4480")]
	[JGOEKBEIPHI]
	public static IDisposable JLGKLOPBPBE(this MonoBehaviour OLFMBCENCHB, BBHLBLBMBEP KLNHOILIBHH, float AOKCJBNEOJH, Action<float> FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x37ECFE0", Offset = "0x37EB7E0", VA = "0x1837ECFE0")]
	[JGOEKBEIPHI]
	public static IDisposable PKHJBNJGDOL<T>(this T OLFMBCENCHB, float AOKCJBNEOJH, Action<float> FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x37EC770", Offset = "0x37EAF70", VA = "0x1837EC770")]
	[JGOEKBEIPHI]
	public static IDisposable CDOEDHDLIJG<T>(this T OLFMBCENCHB, float AOKCJBNEOJH, Action<float> FNLOEDFOJND, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x37EC810", Offset = "0x37EB010", VA = "0x1837EC810")]
	[JGOEKBEIPHI]
	public static IDisposable CMJNHKFJGEB<T>(this T OLFMBCENCHB, Action<float> FNLOEDFOJND, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x37EC6C0", Offset = "0x37EAEC0", VA = "0x1837EC6C0")]
	[JGOEKBEIPHI]
	public static IDisposable ACOGJJHIJEN<T>(this T OLFMBCENCHB, Action<float> FNLOEDFOJND, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x37ECC30", Offset = "0x37EB430", VA = "0x1837ECC30")]
	[JGOEKBEIPHI]
	public static IDisposable FAKFJJBPECK<T>(this T OLFMBCENCHB, Action<float> FNLOEDFOJND, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x37ECF20", Offset = "0x37EB720", VA = "0x1837ECF20")]
	[JGOEKBEIPHI]
	public static IDisposable OAIHMCLJNCD<T>(this T OLFMBCENCHB, Action<float> FNLOEDFOJND, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x37ECD90", Offset = "0x37EB590", VA = "0x1837ECD90")]
	[JGOEKBEIPHI]
	public static IDisposable JILCGJPABOM<T>(this T OLFMBCENCHB, Action<float> FNLOEDFOJND, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x37ECE70", Offset = "0x37EB670", VA = "0x1837ECE70")]
	[JGOEKBEIPHI]
	public static IDisposable MFEKKJIAFJD<T>(this T OLFMBCENCHB, Action<float> FNLOEDFOJND, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x37ECC90", Offset = "0x37EB490", VA = "0x1837ECC90")]
	[JGOEKBEIPHI]
	public static IDisposable FLGNLMLLLDE<T>(this T OLFMBCENCHB, Action<float> FNLOEDFOJND, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x37ECD40", Offset = "0x37EB540", VA = "0x1837ECD40")]
	[JGOEKBEIPHI]
	public static IDisposable JHFLBHOBLFI<T>(this T OLFMBCENCHB, float AOKCJBNEOJH, Action<float> FNLOEDFOJND, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x37ECF80", Offset = "0x37EB780", VA = "0x1837ECF80")]
	[JGOEKBEIPHI]
	public static IDisposable OLALFBJOKIC<T>(this T OLFMBCENCHB, Action<float> FNLOEDFOJND, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x37ECBD0", Offset = "0x37EB3D0", VA = "0x1837ECBD0")]
	[JGOEKBEIPHI]
	public static IDisposable ELKNHJJHFOI<T>(this T OLFMBCENCHB, Action<float> FNLOEDFOJND, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true) where T : MonoBehaviour, BBHLBLBMBEP
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class KGELMDGFCNK
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class KCGFDJLOJBG : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private IGCELENFGND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public KGLNHBBGFEM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private JMLPOBLILLC <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public KCGFDJLOJBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x85A4E30", Offset = "0x85A3630", VA = "0x1885A4E30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x85A4F10", Offset = "0x85A3710", VA = "0x1885A4F10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class KNCBPHEDHHD : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private IGCELENFGND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public KGLNHBBGFEM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private JMLPOBLILLC <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public KNCBPHEDHHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x85A54E0", Offset = "0x85A3CE0", VA = "0x1885A54E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x85A55D0", Offset = "0x85A3DD0", VA = "0x1885A55D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x85A50D0", Offset = "0x85A38D0", VA = "0x1885A50D0")]
	public static KIJPFMOACHH CODFALJLFPG(Action FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x85A5040", Offset = "0x85A3840", VA = "0x1885A5040")]
	public static KIJPFMOACHH CODFALJLFPG(Behaviour KLNHOILIBHH, Action FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x85A4F60", Offset = "0x85A3760", VA = "0x1885A4F60")]
	public static KIJPFMOACHH CODFALJLFPG(Behaviour KLNHOILIBHH, Action<float> FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x85A5150", Offset = "0x85A3950", VA = "0x1885A5150")]
	[IteratorStateMachine(typeof(KCGFDJLOJBG))]
	private static IEnumerator<IGCELENFGND> NKDFIJPFKAA(KGLNHBBGFEM ICEHGIIKNAN, Action FNLOEDFOJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x85A51E0", Offset = "0x85A39E0", VA = "0x1885A51E0")]
	[IteratorStateMachine(typeof(KNCBPHEDHHD))]
	private static IEnumerator<IGCELENFGND> NKDFIJPFKAA(KGLNHBBGFEM ICEHGIIKNAN, Action<float> FNLOEDFOJND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class CCFILEHIOIJ : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class DDDEAMIFOJC : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private IGCELENFGND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public CCFILEHIOIJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public DDDEAMIFOJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x85991E0", Offset = "0x85979E0", VA = "0x1885991E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8599270", Offset = "0x8597A70", VA = "0x188599270", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly KGLNHBBGFEM POIJIBKDCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action BEILNJFCINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool OKNBBLANIJN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool PKJNPIMLPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9E0E00", Offset = "0x9DF600", VA = "0x1809E0E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8594770", Offset = "0x8592F70", VA = "0x188594770")]
	public CCFILEHIOIJ(KGLNHBBGFEM POIJIBKDCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8594650", Offset = "0x8592E50", VA = "0x188594650")]
	[IteratorStateMachine(typeof(DDDEAMIFOJC))]
	private IEnumerator<IGCELENFGND> DEBDEHMIDNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x85946D0", Offset = "0x8592ED0", VA = "0x1885946D0", Slot = "4")]
	public void OnCompleted(Action BNCGMGHGIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	public void KOCGJDHOMAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class NAPDFNIHKMF
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x85A7520", Offset = "0x85A5D20", VA = "0x1885A7520")]
	public static CCFILEHIOIJ HJMFLLMLOGL(this KGLNHBBGFEM POIJIBKDCMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class CDAKOJLJACG
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class MBDKNAHMAHG : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private IGCELENFGND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public DIFHELFEAAC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public MBDKNAHMAHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x85A60A0", Offset = "0x85A48A0", VA = "0x1885A60A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x85A6120", Offset = "0x85A4920", VA = "0x1885A6120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x85949A0", Offset = "0x85931A0", VA = "0x1885949A0")]
	public static KIJPFMOACHH CODFALJLFPG(float AOKCJBNEOJH, Action<float> FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM, bool BLPMHEOLDAG = true, [Optional] LENJBFGPOCH BLMLNNNFAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x85948D0", Offset = "0x85930D0", VA = "0x1885948D0")]
	public static KIJPFMOACHH CODFALJLFPG(MonoBehaviour OLFMBCENCHB, float AOKCJBNEOJH, Action<float> FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM, bool BLPMHEOLDAG = true, [Optional] LENJBFGPOCH BLMLNNNFAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8594A70", Offset = "0x8593270", VA = "0x188594A70")]
	public static KIJPFMOACHH HCABMKKAPIO(MonoBehaviour OLFMBCENCHB, float AOKCJBNEOJH, Action<float> FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM, bool BLPMHEOLDAG = true, [Optional] LENJBFGPOCH BLMLNNNFAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8594BC0", Offset = "0x85933C0", VA = "0x188594BC0")]
	public static KIJPFMOACHH LGLAOODPOLK(OGNGNKLAHIB KLNHOILIBHH, float AOKCJBNEOJH, Action<float> FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM, bool BLPMHEOLDAG = true, [Optional] LENJBFGPOCH BLMLNNNFAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8594C90", Offset = "0x8593490", VA = "0x188594C90")]
	private static IEnumerator<IGCELENFGND> NKDFIJPFKAA(BODBGCFFJAF NEAIAEDGNMO, float AOKCJBNEOJH, KGLNHBBGFEM ICEHGIIKNAN, Action<float> FNLOEDFOJND, bool BLPMHEOLDAG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8594B60", Offset = "0x8593360", VA = "0x188594B60")]
	private static IEnumerator<IGCELENFGND> HIPFHCHLJKH(BODBGCFFJAF NEAIAEDGNMO, float AOKCJBNEOJH, KGLNHBBGFEM ICEHGIIKNAN, Action<float> FNLOEDFOJND, bool BLPMHEOLDAG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8594840", Offset = "0x8593040", VA = "0x188594840")]
	[IteratorStateMachine(typeof(MBDKNAHMAHG))]
	private static IEnumerator<IGCELENFGND> AJFHJCPGIMJ(DIFHELFEAAC FCLNMODOEPJ, float AOKCJBNEOJH, KGLNHBBGFEM ICEHGIIKNAN, Action<float> FNLOEDFOJND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class MJAFKNKMADP
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class LMBCGNBBPBH : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private IGCELENFGND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public KGLNHBBGFEM queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public LMBCGNBBPBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x85A5C00", Offset = "0x85A4400", VA = "0x1885A5C00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x85A5CC0", Offset = "0x85A44C0", VA = "0x1885A5CC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x85A6460", Offset = "0x85A4C60", VA = "0x1885A6460")]
	[IteratorStateMachine(typeof(LMBCGNBBPBH))]
	private static IEnumerator<IGCELENFGND> KHHCAAHFDDA(KGLNHBBGFEM POIJIBKDCMM, Func<bool> JEKEJINPKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x85A6380", Offset = "0x85A4B80", VA = "0x1885A6380")]
	public static KIJPFMOACHH IHEKOEILDFL(this MonoBehaviour OLFMBCENCHB, Func<bool> JEKEJINPKGE, KGLNHBBGFEM POIJIBKDCMM = KGLNHBBGFEM.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class NDGLIPGABKH
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class JMOBGCEFICN : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private IGCELENFGND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public KGLNHBBGFEM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public JMOBGCEFICN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x85A4D70", Offset = "0x85A3570", VA = "0x1885A4D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x85A4DE0", Offset = "0x85A35E0", VA = "0x1885A4DE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class AJPEKBGFJHI<T> : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private IGCELENFGND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public KGLNHBBGFEM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public AJPEKBGFJHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x49ECBB0", Offset = "0x49EB3B0", VA = "0x1849ECBB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x49ECC50", Offset = "0x49EB450", VA = "0x1849ECC50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class FHPDHDENCHC : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private IGCELENFGND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public KGLNHBBGFEM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private IGCELENFGND <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public FHPDHDENCHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x859D0A0", Offset = "0x859B8A0", VA = "0x18859D0A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x859D130", Offset = "0x859B930", VA = "0x18859D130", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x85A7C50", Offset = "0x85A6450", VA = "0x1885A7C50")]
	[IteratorStateMachine(typeof(JMOBGCEFICN))]
	private static IEnumerator<IGCELENFGND> DEBDEHMIDNG(float FOLPOAMFDOE, KGLNHBBGFEM ICEHGIIKNAN, Action JPLDGHHMNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x39256F0", Offset = "0x3923EF0", VA = "0x1839256F0")]
	[IteratorStateMachine(typeof(AJPEKBGFJHI<>))]
	private static IEnumerator<IGCELENFGND> DEBDEHMIDNG<T>(float FOLPOAMFDOE, KGLNHBBGFEM ICEHGIIKNAN, Action<T> JPLDGHHMNAI, T MJAILKMLAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x85A7CF0", Offset = "0x85A64F0", VA = "0x1885A7CF0")]
	[IteratorStateMachine(typeof(FHPDHDENCHC))]
	private static IEnumerator<IGCELENFGND> EKJEHFHHEKD(float FOLPOAMFDOE, KGLNHBBGFEM ICEHGIIKNAN, Action JPLDGHHMNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x85A7D90", Offset = "0x85A6590", VA = "0x1885A7D90")]
	public static IDisposable FAGBLCAEKAE(this MonoBehaviour OLFMBCENCHB, float FOLPOAMFDOE, Action JPLDGHHMNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x85A83B0", Offset = "0x85A6BB0", VA = "0x1885A83B0")]
	public static KIJPFMOACHH NKIDEEGJDOH(this MonoBehaviour OLFMBCENCHB, float FOLPOAMFDOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x85A7E70", Offset = "0x85A6670", VA = "0x1885A7E70")]
	public static KIJPFMOACHH FAGBLCAEKAE(this MonoBehaviour OLFMBCENCHB, float FOLPOAMFDOE, KGLNHBBGFEM ICEHGIIKNAN, Action JPLDGHHMNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x85A8270", Offset = "0x85A6A70", VA = "0x1885A8270")]
	public static KIJPFMOACHH MJINAEGEAPD(this MonoBehaviour OLFMBCENCHB, Action JPLDGHHMNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x39257D0", Offset = "0x3923FD0", VA = "0x1839257D0")]
	public static KIJPFMOACHH MJINAEGEAPD<T>(this MonoBehaviour OLFMBCENCHB, Action<T> JPLDGHHMNAI, T MJAILKMLAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x85A8310", Offset = "0x85A6B10", VA = "0x1885A8310")]
	public static KIJPFMOACHH NKHOILDEBCK(this MonoBehaviour OLFMBCENCHB, Action JPLDGHHMNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x85A80A0", Offset = "0x85A68A0", VA = "0x1885A80A0")]
	public static KIJPFMOACHH GJDMDMKGIPO(this MonoBehaviour OLFMBCENCHB, Action JPLDGHHMNAI, [Optional] LENJBFGPOCH BLMLNNNFAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x85A7F60", Offset = "0x85A6760", VA = "0x1885A7F60")]
	public static KIJPFMOACHH FEJBCLIABPB(this MonoBehaviour OLFMBCENCHB, Action JPLDGHHMNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x85A7BB0", Offset = "0x85A63B0", VA = "0x1885A7BB0")]
	public static KIJPFMOACHH AMGGHHLGDGN(this MonoBehaviour OLFMBCENCHB, Action JPLDGHHMNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x85A7B10", Offset = "0x85A6310", VA = "0x1885A7B10")]
	public static KIJPFMOACHH ABBIDNOBBCL(MonoBehaviour OLFMBCENCHB, KGLNHBBGFEM POIJIBKDCMM, Action JPLDGHHMNAI, [Optional] LENJBFGPOCH BLMLNNNFAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x39255B0", Offset = "0x3923DB0", VA = "0x1839255B0")]
	public static KIJPFMOACHH ABBIDNOBBCL<T>(MonoBehaviour OLFMBCENCHB, KGLNHBBGFEM POIJIBKDCMM, Action<T> JPLDGHHMNAI, T MJAILKMLAHP, [Optional] LENJBFGPOCH BLMLNNNFAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x85A81E0", Offset = "0x85A69E0", VA = "0x1885A81E0")]
	public static KIJPFMOACHH ILKGMNLIHHD(this MonoBehaviour OLFMBCENCHB, float BDADEHFDGME, Action JPLDGHHMNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x85A8140", Offset = "0x85A6940", VA = "0x1885A8140")]
	public static KIJPFMOACHH IBNEPKHIJBA(this MonoBehaviour OLFMBCENCHB, float BDADEHFDGME, Action JPLDGHHMNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x85A8440", Offset = "0x85A6C40", VA = "0x1885A8440")]
	public static KIJPFMOACHH OECNFHDDHOF(this MonoBehaviour OLFMBCENCHB, float BDADEHFDGME, Action JPLDGHHMNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x85A8000", Offset = "0x85A6800", VA = "0x1885A8000")]
	public static KIJPFMOACHH FMKNEPGLHAP(this MonoBehaviour OLFMBCENCHB, float BDADEHFDGME, Action JPLDGHHMNAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class BJDJHHEDBNB : KHLPMELLNOA, IEnumerable<KHLPMELLNOA>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly List<KHLPMELLNOA> GFCHBIGPFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool GFCGHGHBHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action IGMECBFJFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool COADEIEOBFC;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JABMLBGGCOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8592290", Offset = "0x8590A90", VA = "0x188592290", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DLNKJGMDMNK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8592460", Offset = "0x8590C60", VA = "0x188592460", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x85923C0", Offset = "0x8590BC0", VA = "0x1885923C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8592940", Offset = "0x8591140", VA = "0x188592940")]
	public BJDJHHEDBNB([Optional] Action IGMECBFJFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8592500", Offset = "0x8590D00", VA = "0x188592500")]
	public void OIHLAKEIFNH(KHLPMELLNOA JCAKNGCBOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x85920C0", Offset = "0x85908C0", VA = "0x1885920C0")]
	private void BENAIGGPMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8592930", Offset = "0x8591130", VA = "0x188592930", Slot = "7")]
	public bool PGEDPHNJBNO(bool IOHDICMKADP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8592630", Offset = "0x8590E30", VA = "0x188592630", Slot = "8")]
	public bool PGEDPHNJBNO(Action GFMBHCHPLDH, bool IOHDICMKADP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8592210", Offset = "0x8590A10", VA = "0x188592210", Slot = "9")]
	public IEnumerator<KHLPMELLNOA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8592210", Offset = "0x8590A10", VA = "0x188592210", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class MPDFNGNBPOB : APDCMFEMNPA
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class EJKGFGHOLBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public MPDFNGNBPOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EJKGFGHOLBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x859A0B0", Offset = "0x85988B0", VA = "0x18859A0B0")]
		internal void GPCOEJGOAMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class DKBJAMHOKIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public MPDFNGNBPOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public DKBJAMHOKIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x859A0B0", Offset = "0x85988B0", VA = "0x18859A0B0")]
		internal void PBJHBBKPPHM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float BMDCHCBKFNB;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x85A5660", Offset = "0x85A3E60", VA = "0x1885A5660")]
	public MPDFNGNBPOB(Behaviour KLNHOILIBHH, float BMDCHCBKFNB, [Optional] Action IGMECBFJFBM, [Optional] LENJBFGPOCH BLMLNNNFAOE, [Optional] BODBGCFFJAF NEAIAEDGNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x85A7300", Offset = "0x85A5B00", VA = "0x1885A7300", Slot = "9")]
	protected override bool LNADMJMFABM(Action GFMBHCHPLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x85A7410", Offset = "0x85A5C10", VA = "0x1885A7410", Slot = "10")]
	protected override bool MFKFFGNJOLN(Action GFMBHCHPLDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface KHLPMELLNOA
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JABMLBGGCOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action DLNKJGMDMNK;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PGEDPHNJBNO(bool IOHDICMKADP = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PGEDPHNJBNO(Action GFMBHCHPLDH, bool IOHDICMKADP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class APDCMFEMNPA : KHLPMELLNOA
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class GEGCKPOEPGC : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private IGCELENFGND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public APDCMFEMNPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public GEGCKPOEPGC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x85A0CE0", Offset = "0x859F4E0", VA = "0x1885A0CE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x85A0DB0", Offset = "0x859F5B0", VA = "0x1885A0DB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Behaviour KLNHOILIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Action IGMECBFJFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private LLDEFGHLBOH PHGPBENPMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly LENJBFGPOCH BLMLNNNFAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly BODBGCFFJAF NEAIAEDGNMO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JABMLBGGCOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1A09B40", Offset = "0x1A08340", VA = "0x181A09B40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action DLNKJGMDMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8591E30", Offset = "0x8590630", VA = "0x188591E30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8591D90", Offset = "0x8590590", VA = "0x188591D90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8591F90", Offset = "0x8590790", VA = "0x188591F90")]
	protected APDCMFEMNPA(Behaviour KLNHOILIBHH, [Optional] Action IGMECBFJFBM, [Optional] LENJBFGPOCH BLMLNNNFAOE, [Optional] BODBGCFFJAF NEAIAEDGNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8591F30", Offset = "0x8590730", VA = "0x188591F30", Slot = "7")]
	public bool PGEDPHNJBNO(bool IOHDICMKADP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8591ED0", Offset = "0x85906D0", VA = "0x188591ED0", Slot = "8")]
	public bool PGEDPHNJBNO(Action GFMBHCHPLDH, bool IOHDICMKADP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool LNADMJMFABM(Action GFMBHCHPLDH);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool MFKFFGNJOLN(Action GFMBHCHPLDH);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8591A50", Offset = "0x8590250", VA = "0x188591A50")]
	protected void BDPIGJBPKEP(Action GFMBHCHPLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8591B40", Offset = "0x8590340", VA = "0x188591B40")]
	protected ELBPMMKABPA HENGLDNJNDG(float DJFBMECKBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x85919D0", Offset = "0x85901D0", VA = "0x1885919D0")]
	private void APBCJJKEGFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8591A70", Offset = "0x8590270", VA = "0x188591A70")]
	[IteratorStateMachine(typeof(GEGCKPOEPGC))]
	private IEnumerator<IGCELENFGND> CDOJOCNPHIG(float DJFBMECKBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8591B00", Offset = "0x8590300", VA = "0x188591B00")]
	[CompilerGenerated]
	private void FDPIAFELICO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class EKGDKCAHNLG : APDCMFEMNPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly float OKGEDKIMCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int KBKODGBBBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float APJPOOGGAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float[] MHHKAPCPIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int LOBGGOPGEGN;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x859CED0", Offset = "0x859B6D0", VA = "0x18859CED0")]
	public EKGDKCAHNLG(Behaviour KLNHOILIBHH, float OLLKEONCAMJ, int KBKODGBBBEE, [Optional] Action IGMECBFJFBM, float APJPOOGGAOC = 0f, [Optional] LENJBFGPOCH BLMLNNNFAOE, [Optional] BODBGCFFJAF NEAIAEDGNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "9")]
	protected override bool LNADMJMFABM(Action GFMBHCHPLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x859CCD0", Offset = "0x859B4D0", VA = "0x18859CCD0", Slot = "10")]
	protected override bool MFKFFGNJOLN(Action GFMBHCHPLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x859CC50", Offset = "0x859B450", VA = "0x18859CC50")]
	private void HOBLJNFEBLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LEIAOMDJBHL : APDCMFEMNPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float BMDCHCBKFNB;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x85A5660", Offset = "0x85A3E60", VA = "0x1885A5660")]
	public LEIAOMDJBHL(Behaviour KLNHOILIBHH, float BMDCHCBKFNB, [Optional] Action IGMECBFJFBM, [Optional] LENJBFGPOCH BLMLNNNFAOE, [Optional] BODBGCFFJAF NEAIAEDGNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "9")]
	protected override bool LNADMJMFABM(Action GFMBHCHPLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x85A5620", Offset = "0x85A3E20", VA = "0x1885A5620", Slot = "10")]
	protected override bool MFKFFGNJOLN(Action GFMBHCHPLDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class BNEFAIKOMBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class FJDLMJOHOKP : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private IGCELENFGND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public FJDLMJOHOKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x859D180", Offset = "0x859B980", VA = "0x18859D180", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x859D1F0", Offset = "0x859B9F0", VA = "0x18859D1F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private KIJPFMOACHH KOAKHACADDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private OGNGNKLAHIB KLNHOILIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Action<float> NNKGBFAAIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private KGLNHBBGFEM POIJIBKDCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private float JNDPBBNDFDI;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x85944B0", Offset = "0x8592CB0", VA = "0x1885944B0")]
	public BNEFAIKOMBE(OGNGNKLAHIB KLNHOILIBHH, float AOKCJBNEOJH, Action<float> FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x8594090", Offset = "0x8592890", VA = "0x188594090")]
	private void FFNOHDIJFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8594380", Offset = "0x8592B80", VA = "0x188594380")]
	private void JLCIHLDGHNO(string LKNKJJBHDKO, Action DFMIMFPIPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8593FB0", Offset = "0x85927B0", VA = "0x188593FB0")]
	[IteratorStateMachine(typeof(FJDLMJOHOKP))]
	private IEnumerator<IGCELENFGND> AABKGBDMKLC(Action DFMIMFPIPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8594030", Offset = "0x8592830", VA = "0x188594030", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8594200", Offset = "0x8592A00", VA = "0x188594200")]
	[CompilerGenerated]
	private void GACCPNIGHFO(string HNILHIIFGAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class FKICKJIDNIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GEMCMJLDPAO : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private IGCELENFGND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public GEMCMJLDPAO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x859D180", Offset = "0x859B980", VA = "0x18859D180", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x85A0E00", Offset = "0x859F600", VA = "0x1885A0E00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private KIJPFMOACHH KOAKHACADDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private MonoBehaviour OLFMBCENCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Action FNLOEDFOJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Action<float> NNKGBFAAIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private KGLNHBBGFEM POIJIBKDCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float JNDPBBNDFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private bool BLPMHEOLDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly LENJBFGPOCH BLMLNNNFAOE;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x859DE70", Offset = "0x859C670", VA = "0x18859DE70")]
	public FKICKJIDNIO(MonoBehaviour OLFMBCENCHB, Action FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM, [Optional] LENJBFGPOCH BLMLNNNFAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x859E1E0", Offset = "0x859C9E0", VA = "0x18859E1E0")]
	public FKICKJIDNIO(MonoBehaviour OLFMBCENCHB, Action<float> FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM, [Optional] LENJBFGPOCH BLMLNNNFAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x859E000", Offset = "0x859C800", VA = "0x18859E000")]
	public FKICKJIDNIO(MonoBehaviour OLFMBCENCHB, float AOKCJBNEOJH, Action<float> FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM, bool BLPMHEOLDAG = true, [Optional] LENJBFGPOCH BLMLNNNFAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4AD0290", Offset = "0x4ACEA90", VA = "0x184AD0290")]
	private FKICKJIDNIO(LENJBFGPOCH BLMLNNNFAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x859D750", Offset = "0x859BF50", VA = "0x18859D750")]
	internal static FKICKJIDNIO GBKJPJPAJOF(MonoBehaviour OLFMBCENCHB, float AOKCJBNEOJH, Action<float> FNLOEDFOJND, KGLNHBBGFEM POIJIBKDCMM, bool BLPMHEOLDAG = true, [Optional] LENJBFGPOCH BLMLNNNFAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x859D2C0", Offset = "0x859BAC0", VA = "0x18859D2C0")]
	private void CODFALJLFPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x859DBD0", Offset = "0x859C3D0", VA = "0x18859DBD0")]
	private void LPDKENKIHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x859D5E0", Offset = "0x859BDE0", VA = "0x18859D5E0")]
	private void FFNOHDIJFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x859D3F0", Offset = "0x859BBF0", VA = "0x18859D3F0")]
	private void DELILBPKMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x859DA10", Offset = "0x859C210", VA = "0x18859DA10")]
	private void JLCIHLDGHNO(string LKNKJJBHDKO, Action DFMIMFPIPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x859D240", Offset = "0x859BA40", VA = "0x18859D240")]
	[IteratorStateMachine(typeof(GEMCMJLDPAO))]
	private IEnumerator<IGCELENFGND> AABKGBDMKLC(Action DFMIMFPIPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x859D580", Offset = "0x859BD80", VA = "0x18859D580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x859DB40", Offset = "0x859C340", VA = "0x18859DB40")]
	[CompilerGenerated]
	private void LJLHINAJBKM(string HNILHIIFGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x859D980", Offset = "0x859C180", VA = "0x18859D980")]
	[CompilerGenerated]
	private void JFGKAPBPBFM(string HNILHIIFGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x859DD50", Offset = "0x859C550", VA = "0x18859DD50")]
	[CompilerGenerated]
	private void NFIPPNAJOAF(string HNILHIIFGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x859DDE0", Offset = "0x859C5E0", VA = "0x18859DDE0")]
	[CompilerGenerated]
	private void ONIDIGKMCBA(string HNILHIIFGAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum AIDMFOJFHMI : byte
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
internal sealed class KLCNJILMEHC : BODBGCFFJAF
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float CEMOBPGGHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x85A5450", Offset = "0x85A3C50", VA = "0x1885A5450", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public float MGPPDDKOFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x85A54D0", Offset = "0x85A3CD0", VA = "0x1885A54D0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public double FPDKKNJNAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x85A5430", Offset = "0x85A3C30", VA = "0x1885A5430", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x85A5460", Offset = "0x85A3C60", VA = "0x1885A5460")]
	[PJMOOJOMMCC.OJAOBFKEEAO]
	internal static void JMICLABLGOM(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	[UnityEngine.Scripting.Preserve]
	internal KLCNJILMEHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface NEFBIOJKDBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NAGLEICMEEJ(string GLGOHIJMLFB);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHHENNFLJG();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface HIPNKNHJHGN
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool DJIPACMCJML
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool ILBDECIMLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class BMBHDGPLEFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public NHCKHLMHDML HNHANEKFLOP;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int NHCKMLOFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8593CE0", Offset = "0x85924E0", VA = "0x188593CE0")]
	public static IGCELENFGND GBCNHAJGFNC(IEnumerator<IGCELENFGND> KCILCILPIJL, BKDKBHEGGJK HPMIHANAIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8593C20", Offset = "0x8592420", VA = "0x188593C20")]
	public IGCELENFGND GBCNHAJGFNC(BKDKBHEGGJK[] DHBPCLJPLKO, IEnumerator<IGCELENFGND>[] DOPDLCHFOJD, IGCELENFGND[] HIEBIMDCFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8593E40", Offset = "0x8592640", VA = "0x188593E40")]
	public void OFIHBAKIFCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x8593AE0", Offset = "0x85922E0", VA = "0x188593AE0")]
	public void FFDHGDFLJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x8593E70", Offset = "0x8592670", VA = "0x188593E70")]
	public void NCODJOCFNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8593E40", Offset = "0x8592640", VA = "0x188593E40")]
	public void MMGGKEIOFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public BMBHDGPLEFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class NHCKHLMHDML
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct BJJDEGHBIFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public BMBHDGPLEFI LMCNBLKOMEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public OGNGNKLAHIB KDJKGIPIFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public BKDKBHEGGJK FLMFKGOEEAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IEnumerator<IGCELENFGND> INLEHODIDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public IGCELENFGND OGCPDLBCFNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public AIDMFOJFHMI OBOOHCEENPC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct HBPFMAEABMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public KGLNHBBGFEM BJJFCGHIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public List<BJJDEGHBIFM> DLHCOPDGIHI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GFIGDJJHPJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public BKDKBHEGGJK promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public NHCKHLMHDML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public OGNGNKLAHIB context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public BMBHDGPLEFI routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AIDMFOJFHMI coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public IGCELENFGND currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IEnumerator<IGCELENFGND> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public GFIGDJJHPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x85A0E50", Offset = "0x859F650", VA = "0x1885A0E50")]
		internal void NOFFFOFJJKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class AEOGMOIFDGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public BMBHDGPLEFI schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public NHCKHLMHDML <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public AEOGMOIFDGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x85915D0", Offset = "0x858FDD0", VA = "0x1885915D0")]
		internal void HAMPPGFFDKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class GJNHLGMFFHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public BMBHDGPLEFI schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public NHCKHLMHDML <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public GJNHLGMFFHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x85A1710", Offset = "0x859FF10", VA = "0x1885A1710")]
		internal void LOGJKJBODBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class NDGGIMLECIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public BMBHDGPLEFI schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public NHCKHLMHDML <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public NDGGIMLECIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x85A7AD0", Offset = "0x85A62D0", VA = "0x1885A7AD0")]
		internal void ODIOPDHKOKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private const AIDMFOJFHMI ENEBEMFACDL = AIDMFOJFHMI.Cancelled | AIDMFOJFHMI.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly KGLNHBBGFEM POIJIBKDCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool[] MHPFEHEPOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<AIDMFOJFHMI> NLPEHEAEGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeArray<float> IJIFJPOAACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<int> BFAFMLOCNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<int> FLCNPGKLOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> INBJCLHPFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> KLJAGKJFLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> JEDFEAIEKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private BMBHDGPLEFI[] MEPFOADFDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private BKDKBHEGGJK[] DHBPCLJPLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private OGNGNKLAHIB[] JPECCBDLKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private IEnumerator<IGCELENFGND>[] NKGKCOKBGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IGCELENFGND[] OKEJOLDJEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int IPGGMEBADEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int CFHPBCCHEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int GCLDKHIFCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float NKMJEACAAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private FKPLCPOPEHC JCEEFBHGELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JobHandle DAKOBKJDLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<BMBHDGPLEFI> FIJCFHIEOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool BAMHMDCGIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<Action> KAGDBGLBIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<Action> OGGEJHFEKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool EFEJMKDGODB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HBPFMAEABMI[] LOENFANLJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA89910", Offset = "0xA88110", VA = "0x180A89910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x85A9C60", Offset = "0x85A8460", VA = "0x1885A9C60")]
	private static int HLJPKGFEBGC(KGLNHBBGFEM POIJIBKDCMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x85AA870", Offset = "0x85A9070", VA = "0x1885AA870")]
	public NHCKHLMHDML(KGLNHBBGFEM POIJIBKDCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x85A9C90", Offset = "0x85A8490", VA = "0x1885A9C90")]
	private void LMPHJFHDIDN(int EHBCLDCPELE, int LAHDMNFPGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x85A9AE0", Offset = "0x85A82E0", VA = "0x1885A9AE0")]
	public void FKFAJLMMJBO(OGNGNKLAHIB KLNHOILIBHH, IGCELENFGND PAKJFPHGFAN, IEnumerator<IGCELENFGND> KCILCILPIJL, BKDKBHEGGJK HPMIHANAIEC, [Optional] BMBHDGPLEFI MGMCCMLNGOD, AIDMFOJFHMI BGLMGICPDLA = AIDMFOJFHMI.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x85A9770", Offset = "0x85A7F70", VA = "0x1885A9770")]
	public void DIKHLCLGBEB(IEnumerable<BJJDEGHBIFM> AHIJECMNPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x85A90A0", Offset = "0x85A78A0", VA = "0x1885A90A0")]
	private BJJDEGHBIFM CHLNLCCFJDN(int EFJBOCIFIDA)
	{
		return default(BJJDEGHBIFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x85A84E0", Offset = "0x85A6CE0", VA = "0x1885A84E0")]
	private void AMPBJKFPBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3928AF0", Offset = "0x39272F0", VA = "0x183928AF0")]
	private static void HOBGGEEKKOH<T>(int EFJBOCIFIDA, T[] LOIIGMONBDL, int LBLAFDELPAC, [Optional] T HGKDPLKMLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3928B40", Offset = "0x3927340", VA = "0x183928B40")]
	private static void HOBGGEEKKOH<T>(int EFJBOCIFIDA, NativeArray<T> LOIIGMONBDL, int LBLAFDELPAC, [Optional] T HGKDPLKMLFL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x85AA270", Offset = "0x85A8A70", VA = "0x1885AA270")]
	private void OGGNJDMEJBJ(IEnumerable<BJJDEGHBIFM> AHIJECMNPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x85AA0A0", Offset = "0x85A88A0", VA = "0x1885AA0A0")]
	private void OBFNCAEDJFK(BJJDEGHBIFM KKNPJAMFMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x85AA610", Offset = "0x85A8E10", VA = "0x1885AA610")]
	private APFDLHEFNLG PEONEOJEHPK(int KOFFPIDAKHI)
	{
		return default(APFDLHEFNLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x85A9570", Offset = "0x85A7D70", VA = "0x1885A9570")]
	public void CLCCBLHIJEM(float NAOOGCLJBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x85A9E70", Offset = "0x85A8670", VA = "0x1885A9E70")]
	private void MAEENHLIGJI(Action BINANFFLHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x85AA020", Offset = "0x85A8820", VA = "0x1885AA020")]
	private void NOLMDAACNJI(Action BINANFFLHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x85A8980", Offset = "0x85A7180", VA = "0x1885A8980")]
	public void BCPNONNICOL(float NAOOGCLJBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x85AA170", Offset = "0x85A8970", VA = "0x1885AA170")]
	public void OCOBEACFBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x85A9EF0", Offset = "0x85A86F0", VA = "0x1885A9EF0")]
	public void MMGGKEIOFEE(BMBHDGPLEFI FCLNMODOEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x85A8850", Offset = "0x85A7050", VA = "0x1885A8850")]
	public void BCEEEFFFBIP(BMBHDGPLEFI FCLNMODOEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x85A99B0", Offset = "0x85A81B0", VA = "0x1885A99B0")]
	public void EDMCOHBPPLF(BMBHDGPLEFI FCLNMODOEPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class DLGNPINHJLK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static readonly DLGNPINHJLK HMAILHHHNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Action HPFEMIAMAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool HGKGNONOPPK;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public DLGNPINHJLK(Action HPFEMIAMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BD60", Offset = "0x7C4A560", VA = "0x187C4BD60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface MGABNLFFMIH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	T GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable KBLPOPCNPHK(UnityEngine.Object KLNHOILIBHH, Action<T> NMJEOJFLELF);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface GEINJBIPFJK<T> : MGABNLFFMIH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	new T GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class KPBGBMFBOKH<T> : GEINJBIPFJK<T>, MGABNLFFMIH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class NPBJDDGAHBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public KPBGBMFBOKH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public AEMMGPOOLPH<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public NPBJDDGAHBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5359810", Offset = "0x5358010", VA = "0x185359810")]
		internal void PCKPDHDBIJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static GameObject EBBNHPGMAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<AEMMGPOOLPH<UnityEngine.Object, Action<T>>> IMPPLLADJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private T JJOGNLCLDEJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA85410", Offset = "0xA83C10", VA = "0x180A85410", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4F43E40", Offset = "0x4F42640", VA = "0x184F43E40", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4F43D80", Offset = "0x4F42580", VA = "0x184F43D80")]
	private static bool DGABOBHMEMP(T BINANFFLHIK, T NOAPPAEGHOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4F44950", Offset = "0x4F43150", VA = "0x184F44950")]
	public KPBGBMFBOKH(T MHJADMKHMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4F447A0", Offset = "0x4F42FA0", VA = "0x184F447A0", Slot = "6")]
	public IDisposable KBLPOPCNPHK(UnityEngine.Object KLNHOILIBHH, Action<T> NMJEOJFLELF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4F43F90", Offset = "0x4F42790", VA = "0x184F43F90")]
	private void JICPDDOFIAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class MMFIDMGMAPL : HBFAJGNBGJB
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class NBPDFFIJDFI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private class MBKNCFDJHOF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int MLBCMOLHELH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private NBPDFFIJDFI ICEHGIIKNAN;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xEA3BB0", Offset = "0xEA23B0", VA = "0x180EA3BB0")]
			public MBKNCFDJHOF(int MLBCMOLHELH, NBPDFFIJDFI ICEHGIIKNAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x85A6170", Offset = "0x85A4970", VA = "0x1885A6170", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class ECBEHLHLGFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public ECBEHLHLGFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xD91830", Offset = "0xD90030", VA = "0x180D91830")]
			internal bool DJMDKBKPPGB(JLOJJOFABBF e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class FOGKAPPLMDD : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private IGCELENFGND <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public NBPDFFIJDFI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public BODBGCFFJAF timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private JMLPOBLILLC <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private List<JLOJJOFABBF> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
			[DebuggerHidden]
			public FOGKAPPLMDD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x859EAF0", Offset = "0x859D2F0", VA = "0x18859EAF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x859EE20", Offset = "0x859D620", VA = "0x18859EE20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly KGLNHBBGFEM POIJIBKDCMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private KIJPFMOACHH HPMIHANAIEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly List<JLOJJOFABBF> MLOHNMJPFLK;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x85A7A30", Offset = "0x85A6230", VA = "0x1885A7A30")]
		public NBPDFFIJDFI(KGLNHBBGFEM POIJIBKDCMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x85A7810", Offset = "0x85A6010", VA = "0x1885A7810")]
		public IDisposable KJCOMLKJNPP(JLOJJOFABBF JHEBMEFKMCG, LENJBFGPOCH BLMLNNNFAOE, BODBGCFFJAF NIBJMJJGOBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x85A7630", Offset = "0x85A5E30", VA = "0x1885A7630")]
		private void BIOAOAPOIAO(int MLBCMOLHELH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x85A79A0", Offset = "0x85A61A0", VA = "0x1885A79A0")]
		[IteratorStateMachine(typeof(FOGKAPPLMDD))]
		private IEnumerator<IGCELENFGND> NKDFIJPFKAA(BODBGCFFJAF NIBJMJJGOBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x85A77C0", Offset = "0x85A5FC0", VA = "0x1885A77C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class JLOJJOFABBF
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public enum BFDEHBNNENI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static int CAPIGKBIILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public readonly int NGHJMEDCGPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public readonly BBHLBLBMBEP KDJKGIPIFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly MonoBehaviour MCDCFCPABGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public readonly Action MAEEPMKIKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public readonly Action<float> LCBPJAAILHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public readonly float OPKEOPECABO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float IJIFJPOAACI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public readonly string ACOJEEABMOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public readonly bool HFEKBFFODOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public readonly BFDEHBNNENI CJNMBOIPFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool PDDLDDBDGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public bool ANPFFPMLJKJ;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x85A4890", Offset = "0x85A3090", VA = "0x1885A4890")]
		public JLOJJOFABBF(BBHLBLBMBEP KLNHOILIBHH, Action FNLOEDFOJND, bool KKECEKIONOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x85A4BF0", Offset = "0x85A33F0", VA = "0x1885A4BF0")]
		public JLOJJOFABBF(BBHLBLBMBEP KLNHOILIBHH, Action<float> FNLOEDFOJND, bool KKECEKIONOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x85A4A10", Offset = "0x85A3210", VA = "0x1885A4A10")]
		public JLOJJOFABBF(BBHLBLBMBEP KLNHOILIBHH, float AOKCJBNEOJH, Action<float> FNLOEDFOJND, BODBGCFFJAF NIBJMJJGOBF, BFDEHBNNENI NLIIPNOMPOL, bool BLPMHEOLDAG, bool KKECEKIONOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x85A46C0", Offset = "0x85A2EC0", VA = "0x1885A46C0")]
		public bool DKBLPGCEFDC(float OIKKJHNFKFP, float HAGKKHCGGDF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly LENJBFGPOCH BLMLNNNFAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly BODBGCFFJAF NEAIAEDGNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Dictionary<KGLNHBBGFEM, NBPDFFIJDFI> AFANGHLLHDI;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x85A6D90", Offset = "0x85A5590", VA = "0x1885A6D90")]
	[PJMOOJOMMCC.OJAOBFKEEAO]
	internal static void NFHFHFEPKHF(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x85A6FC0", Offset = "0x85A57C0", VA = "0x1885A6FC0")]
	[UnityEngine.Scripting.Preserve]
	internal MMFIDMGMAPL([LDAFGEHKDJK(null)] LENJBFGPOCH BLMLNNNFAOE, [LDAFGEHKDJK(null)] BODBGCFFJAF NEAIAEDGNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x85A69B0", Offset = "0x85A51B0", VA = "0x1885A69B0", Slot = "4")]
	public IDisposable MAEEPMKIKNH(BBHLBLBMBEP KLNHOILIBHH, Action NELMOECDPJP, KGLNHBBGFEM POIJIBKDCMM, bool KKECEKIONOF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x85A6BA0", Offset = "0x85A53A0", VA = "0x1885A6BA0", Slot = "5")]
	public IDisposable MAEEPMKIKNH(BBHLBLBMBEP KLNHOILIBHH, Action<float> NELMOECDPJP, KGLNHBBGFEM POIJIBKDCMM, bool KKECEKIONOF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x85A65F0", Offset = "0x85A4DF0", VA = "0x1885A65F0", Slot = "7")]
	public IDisposable CDOEDHDLIJG(BBHLBLBMBEP KLNHOILIBHH, float AOKCJBNEOJH, Action<float> NELMOECDPJP, KGLNHBBGFEM POIJIBKDCMM, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x85A64F0", Offset = "0x85A4CF0", VA = "0x1885A64F0", Slot = "8")]
	public IDisposable AJHHHIIOOJH(BBHLBLBMBEP KLNHOILIBHH, float AOKCJBNEOJH, Action<float> NELMOECDPJP, KGLNHBBGFEM POIJIBKDCMM, bool BLPMHEOLDAG = true, bool KKECEKIONOF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x85A66F0", Offset = "0x85A4EF0", VA = "0x1885A66F0", Slot = "6")]
	public IDisposable CDOEDHDLIJG(float AOKCJBNEOJH, Action<float> NELMOECDPJP, bool BLPMHEOLDAG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x85A6E00", Offset = "0x85A5600", VA = "0x1885A6E00", Slot = "9")]
	public void OMPDHJNPJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x85A6870", Offset = "0x85A5070", VA = "0x1885A6870")]
	private NBPDFFIJDFI HDANJIJFIMJ(KGLNHBBGFEM POIJIBKDCMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class HFEJFFCGOJH : HACBJHKEDGN, LENJBFGPOCH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NHCKHLMHDML[] JKPLBGKAIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NEFBIOJKDBJ FJKJAKKPDDO;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x85A3850", Offset = "0x85A2050", VA = "0x1885A3850")]
	[PJMOOJOMMCC.OJAOBFKEEAO]
	internal static void JMICLABLGOM(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x85A3F10", Offset = "0x85A2710", VA = "0x1885A3F10")]
	[UnityEngine.Scripting.Preserve]
	public HFEJFFCGOJH([LDAFGEHKDJK(null)] JPDKEMFAPJN MLLPCACDKIJ, [LDAFGEHKDJK(null)] BODBGCFFJAF NEAIAEDGNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x85A38C0", Offset = "0x85A20C0", VA = "0x1885A38C0", Slot = "19")]
	public override KIJPFMOACHH KDEKJCKIGGD(OGNGNKLAHIB KLNHOILIBHH, IEnumerator<IGCELENFGND> FHCHEADAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x85A3B60", Offset = "0x85A2360", VA = "0x1885A3B60", Slot = "20")]
	public override void OMPDHJNPJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x85A3330", Offset = "0x85A1B30", VA = "0x1885A3330", Slot = "22")]
	public override void EDMIDOPDNNH(KGLNHBBGFEM POIJIBKDCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x85A39F0", Offset = "0x85A21F0", VA = "0x1885A39F0", Slot = "21")]
	protected override void MAEEPMKIKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x85A32A0", Offset = "0x85A1AA0", VA = "0x1885A32A0")]
	private NHCKHLMHDML BNNMFINHKBJ(KGLNHBBGFEM PIJHKCJDAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x85A3620", Offset = "0x85A1E20", VA = "0x1885A3620", Slot = "23")]
	internal override GEABLACAOAC IBKIMGKINEJ(IEnumerator<IGCELENFGND> FHCHEADAGCO, Behaviour KLNHOILIBHH, BKDKBHEGGJK HPMIHANAIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x85A3560", Offset = "0x85A1D60", VA = "0x1885A3560", Slot = "24")]
	internal override ECIADOFOIEA HGNDBKLAKEH(KGLNHBBGFEM ICEHGIIKNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x85A3DF0", Offset = "0x85A25F0", VA = "0x1885A3DF0")]
	private void PCLHINDANPB(NHCKHLMHDML BEKMGNFMNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x85A32D0", Offset = "0x85A1AD0", VA = "0x1885A32D0", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[BurstCompile]
internal struct FKPLCPOPEHC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ReadOnly]
	public float JEJDHEPPNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ReadOnly]
	public int CKBNGKAFDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<int> COCKEFNFHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> CDJAPNMFNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<int> FCFGMLHKPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ReadOnly]
	public NativeArray<AIDMFOJFHMI> FCPLFPMEKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	public NativeArray<float> NLDJDHFNGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[WriteOnly]
	public NativeArray<int> INBJCLHPFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[WriteOnly]
	public NativeArray<int> BFAFMLOCNGA;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x859E8B0", Offset = "0x859D0B0", VA = "0x18859E8B0")]
	public static FKPLCPOPEHC NKIHIDGHACP(int ENMCFHGMCJC, float NAOOGCLJBCC, NativeArray<AIDMFOJFHMI> FNAFBKGKPMD, NativeArray<float> HAKCIAJCPBI, NativeArray<int> PNKKHPPIGKC, NativeArray<int> NKBGGAKGGHP, NativeArray<int> MODINCEHCLE, NativeArray<int> CDJAPNMFNKI, NativeArray<int> FCFGMLHKPKJ)
	{
		return default(FKPLCPOPEHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x859E4C0", Offset = "0x859CCC0", VA = "0x18859E4C0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x859E480", Offset = "0x859CC80", VA = "0x18859E480")]
	private bool EMKCIDEPGBJ(int FPEOONOJHML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x859E450", Offset = "0x859CC50", VA = "0x18859E450")]
	private void BNJDPDOCODF(NativeArray<int> IOKIAEJLJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x859E3B0", Offset = "0x859CBB0", VA = "0x18859E3B0")]
	private int BDLOPHCLDHL(int DAIOOLAPDNA, int FEPMNIMMOAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x859E7E0", Offset = "0x859CFE0", VA = "0x18859E7E0")]
	private void LGKNIEFLFED(NativeArray<int> IOKIAEJLJPI, int JDBKIENDGDG, int GGILEDABHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x859E5A0", Offset = "0x859CDA0", VA = "0x18859E5A0")]
	private void GENMEDDBOEP(NativeArray<int> IOKIAEJLJPI, int JANIIPLGDPB, int IIBJJFPPEEO, int LMNLLCPOPKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public abstract class HACBJHKEDGN : LENJBFGPOCH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly JPDKEMFAPJN MLLPCACDKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected readonly BODBGCFFJAF NEAIAEDGNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private ECIADOFOIEA[] MIPFFAFMING;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static LENJBFGPOCH DJLOIKDDKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x85A2640", Offset = "0x85A0E40", VA = "0x1885A2640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool ABPKKBNEOIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public KGLNHBBGFEM FOJJCIGLIPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(KGLNHBBGFEM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public BODBGCFFJAF PLFAMBGJAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public IGCELENFGND BCIBGCAFOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IGCELENFGND IACHFBHFKCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IGCELENFGND DCENOBLFLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IGCELENFGND JGNBBMHBPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x85A1F20", Offset = "0x85A0720", VA = "0x1885A1F20")]
	public static KIJPFMOACHH JGMLLAIAKOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x85A26B0", Offset = "0x85A0EB0", VA = "0x1885A26B0")]
	[UnityEngine.Scripting.Preserve]
	protected HACBJHKEDGN([LDAFGEHKDJK(null)] JPDKEMFAPJN MLLPCACDKIJ, [LDAFGEHKDJK(null)] BODBGCFFJAF NEAIAEDGNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x85A2470", Offset = "0x85A0C70", VA = "0x1885A2470", Slot = "6")]
	public KIJPFMOACHH OEANMMBFPHG(IEnumerator<IGCELENFGND> FHCHEADAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x85A2270", Offset = "0x85A0A70", VA = "0x1885A2270", Slot = "7")]
	public KIJPFMOACHH OEANMMBFPHG(Behaviour KLNHOILIBHH, IEnumerator<IGCELENFGND> FHCHEADAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract KIJPFMOACHH KDEKJCKIGGD(OGNGNKLAHIB KLNHOILIBHH, IEnumerator<IGCELENFGND> FHCHEADAGCO);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x85A2480", Offset = "0x85A0C80", VA = "0x1885A2480", Slot = "20")]
	public virtual void OMPDHJNPJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x85A1CE0", Offset = "0x85A04E0", VA = "0x1885A1CE0", Slot = "9")]
	public void HEPICEACHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x85A2230", Offset = "0x85A0A30", VA = "0x1885A2230", Slot = "21")]
	protected virtual void MAEEPMKIKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x85A2180", Offset = "0x85A0980", VA = "0x1885A2180")]
	private void LBJNAFGCNLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x85A2250", Offset = "0x85A0A50", VA = "0x1885A2250")]
	private void NFOJLPEIMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x85A1770", Offset = "0x859FF70", VA = "0x1885A1770")]
	private void CHCKPCCDOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x85A1750", Offset = "0x859FF50", VA = "0x1885A1750")]
	private void AJFAHFPHICA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x85A2620", Offset = "0x85A0E20", VA = "0x1885A2620")]
	private void PFAFCCKFCDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x85A1CC0", Offset = "0x85A04C0", VA = "0x1885A1CC0")]
	private void GCABKPCNCHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x85A1790", Offset = "0x859FF90", VA = "0x1885A1790")]
	private void DNNHLEPGIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x85A1B70", Offset = "0x85A0370", VA = "0x1885A1B70", Slot = "22")]
	public virtual void EDMIDOPDNNH(KGLNHBBGFEM POIJIBKDCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x85A1FB0", Offset = "0x85A07B0", VA = "0x1885A1FB0")]
	private void KCKALADOBJJ(ECIADOFOIEA BEKMGNFMNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x263A310", Offset = "0x2638B10", VA = "0x18263A310")]
	private ECIADOFOIEA GEJAOEMKHCI(KGLNHBBGFEM PIJHKCJDAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract GEABLACAOAC IBKIMGKINEJ(IEnumerator<IGCELENFGND> FHCHEADAGCO, Behaviour OLFMBCENCHB, BKDKBHEGGJK ENLJELICPLC);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract ECIADOFOIEA HGNDBKLAKEH(KGLNHBBGFEM POIJIBKDCMM);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x85A17B0", Offset = "0x859FFB0", VA = "0x1885A17B0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x85A1C60", Offset = "0x85A0460", VA = "0x1885A1C60", Slot = "15")]
	public IGCELENFGND FPKEBJHNDON(KGLNHBBGFEM ICEHGIIKNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x85A21A0", Offset = "0x85A09A0", VA = "0x1885A21A0", Slot = "16")]
	public IGCELENFGND LOPNAJIDBBO(float FOLPOAMFDOE, KGLNHBBGFEM ICEHGIIKNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x85A1C00", Offset = "0x85A0400", VA = "0x1885A1C00", Slot = "17")]
	public IGCELENFGND FMGDIAPFJEI(Func<bool> JEKEJINPKGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class GEABLACAOAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly BKDKBHEGGJK HPMIHANAIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly HIPNKNHJHGN KLNHOILIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly bool IHMBCPJLKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private string GLGOHIJMLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private StackTrace HGIGEAILJKP;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<IGCELENFGND> INLEHODIDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IGCELENFGND OGCPDLBCFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool IGABNIIHLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x85A0810", Offset = "0x859F010", VA = "0x1885A0810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool HAGNLKAJCAD
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xBFD9E0", Offset = "0xBFC1E0", VA = "0x180BFD9E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xC03A50", Offset = "0xC02250", VA = "0x180C03A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x85A0890", Offset = "0x859F090", VA = "0x1885A0890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float MJMECDKGEED
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1048640", Offset = "0x1046E40", VA = "0x181048640")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6F0D3D0", Offset = "0x6F0BBD0", VA = "0x186F0D3D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x85A0B20", Offset = "0x859F320", VA = "0x1885A0B20")]
	public GEABLACAOAC(IEnumerator<IGCELENFGND> KCILCILPIJL, HIPNKNHJHGN KLNHOILIBHH, BKDKBHEGGJK HPMIHANAIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x85A0430", Offset = "0x859EC30", VA = "0x1885A0430")]
	public IGCELENFGND GBCNHAJGFNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x85A0750", Offset = "0x859EF50", VA = "0x1885A0750")]
	public bool MFEPKBPGELE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x85A07C0", Offset = "0x859EFC0", VA = "0x1885A07C0")]
	public void MMGGKEIOFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x85A0A40", Offset = "0x859F240", VA = "0x1885A0A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xC59E20", Offset = "0xC58620", VA = "0x180C59E20")]
	[CompilerGenerated]
	private void ALPIFBLMFMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class BKDKBHEGGJK : EAALJLDPGGJ, KIJPFMOACHH, LLDEFGHLBOH, ELBPMMKABPA, IEnumerator, IGCELENFGND, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private KGLNHBBGFEM AJLCGIJMALE;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private KGLNHBBGFEM HNBBJDCKIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xD451A0", Offset = "0xD439A0", VA = "0x180D451A0", Slot = "23")]
		get
		{
			return default(KGLNHBBGFEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public KGLNHBBGFEM HNHANEKFLOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xF1DC10", Offset = "0xF1C410", VA = "0x180F1DC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float LNNJEIOBGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xB7D290", Offset = "0xB7BA90", VA = "0x180B7D290", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool OEJGLLLIMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8593110", Offset = "0x8591910", VA = "0x188593110", Slot = "24")]
	private bool AJBEMLFMLJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8593130", Offset = "0x8591930", VA = "0x188593130", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8593140", Offset = "0x8591940", VA = "0x188593140")]
	public BKDKBHEGGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal enum APFDLHEFNLG : byte
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
internal sealed class ECIADOFOIEA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum HNPHHEGCIAG
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct HEKPPIJBCMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public KGLNHBBGFEM BJJFCGHIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public HNPHHEGCIAG KGMBEEOOIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public List<GEABLACAOAC> JCKJLNLDFIC;
	}

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly HNPHHEGCIAG[] CGCLCEMHACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly KGLNHBBGFEM POIJIBKDCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool DANHHGDPBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly GEABLACAOAC[] GEGNFLCJPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly List<GEABLACAOAC> HDBBDBKKPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Stack<int> BNDIBNPOGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly List<GEABLACAOAC> MBIMODLCGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Stack<int> HHNLOOJFNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly NEFBIOJKDBJ DBCGMDKPDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool EFEJMKDGODB;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public HEKPPIJBCMD[,] AOODPPMJEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x859BE50", Offset = "0x859A650", VA = "0x18859BE50")]
	public ECIADOFOIEA(KGLNHBBGFEM ICEHGIIKNAN, NEFBIOJKDBJ DBCGMDKPDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x859BC20", Offset = "0x859A420", VA = "0x18859BC20")]
	public void OEFOMDIPHAC(GEABLACAOAC KCILCILPIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x859B050", Offset = "0x8599850", VA = "0x18859B050")]
	public void EONAODFPCGL(IList<GEABLACAOAC> DOPDLCHFOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x859B920", Offset = "0x859A120", VA = "0x18859B920")]
	public void NKOLIFCLMFE(IList<GEABLACAOAC> DOPDLCHFOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x859B6C0", Offset = "0x8599EC0", VA = "0x18859B6C0")]
	private void INOEOMIAKKA(GEABLACAOAC KCILCILPIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x859AA40", Offset = "0x8599240", VA = "0x18859AA40")]
	private void DEMPPGEFBAJ(IList<GEABLACAOAC> DOPDLCHFOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x859B350", Offset = "0x8599B50", VA = "0x18859B350")]
	private APFDLHEFNLG GBMNLMPKNHK(GEABLACAOAC KCILCILPIJL)
	{
		return default(APFDLHEFNLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x859B7B0", Offset = "0x8599FB0", VA = "0x18859B7B0")]
	public void MAEEPMKIKNH(float NAOOGCLJBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x859B4D0", Offset = "0x8599CD0", VA = "0x18859B4D0")]
	public void HEPICEACHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x859ACF0", Offset = "0x85994F0", VA = "0x18859ACF0")]
	private void EKJOANHFOHH(List<GEABLACAOAC> DOPDLCHFOJD, Stack<int> EBOPJMBCIJH, bool FJFHHJLKLBB, float CBNEEMPOOFL = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x859ABD0", Offset = "0x85993D0", VA = "0x18859ABD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x859A900", Offset = "0x8599100", VA = "0x18859A900")]
	private void BFHNBHKIIBF(List<GEABLACAOAC> DOPDLCHFOJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class FOHILAHOFIH : NEFBIOJKDBJ
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void NAGLEICMEEJ(string GLGOHIJMLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
	public void FAHHENNFLJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FOHILAHOFIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal class GHCOLKBHOMJ : HIPNKNHJHGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Behaviour OLFMBCENCHB;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x85A1690", Offset = "0x859FE90", VA = "0x1885A1690", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool DJIPACMCJML
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x85A1620", Offset = "0x859FE20", VA = "0x1885A1620", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool ILBDECIMLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x85A1670", Offset = "0x859FE70", VA = "0x1885A1670", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public GHCOLKBHOMJ(Behaviour OLFMBCENCHB)
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

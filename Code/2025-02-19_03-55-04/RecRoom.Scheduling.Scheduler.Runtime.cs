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
	public class LogRegistrationIndex : NELPCBNCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0980", Offset = "0x7EDF580", VA = "0x187EE0980", Slot = "4")]
		public override void CHOGICNNBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EE8940", Offset = "0x7EE7540", VA = "0x187EE8940", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
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
		private delegate List<PlayerLoopSystem> EAGLDLJOACK(List<PlayerLoopSystem> IDBDLMFCNMN, int NHMOIJGGMKI);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct ANHMDKEOOJC
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct FMIFANHECCO
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static NCEKLMPIJLO KHOECOMAKEE;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x7ED8280", Offset = "0x7ED6E80", VA = "0x187ED8280")]
				public static PlayerLoopSystem BKEJHDEMDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct PICFHMFOOHK
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static NCEKLMPIJLO DHEEDAEKEEC;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x7EE7460", Offset = "0x7EE6060", VA = "0x187EE7460")]
				public static PlayerLoopSystem BKEJHDEMDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct LBDEBMGEJJI
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static NCEKLMPIJLO GFLGIPEKIOF;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x7EDEBB0", Offset = "0x7EDD7B0", VA = "0x187EDEBB0")]
				public static PlayerLoopSystem BKEJHDEMDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct CDJNOONHBBO
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static NCEKLMPIJLO NFKLNNHICLN;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static NCEKLMPIJLO GOHBPBIIOBC;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static NCEKLMPIJLO GKJDGLNOOLN;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static NCEKLMPIJLO FONPJEBOGCF;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x7ECDBF0", Offset = "0x7ECC7F0", VA = "0x187ECDBF0")]
				public static PlayerLoopSystem BKEJHDEMDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct HHONIDFAMAN
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static NCEKLMPIJLO FJDPCGKCOPO;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x7ED8D30", Offset = "0x7ED7930", VA = "0x187ED8D30")]
				public static PlayerLoopSystem BKEJHDEMDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct MKKAOEEHNFG
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static NCEKLMPIJLO NFKLNNHICLN;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static NCEKLMPIJLO GOHBPBIIOBC;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static NCEKLMPIJLO GKJDGLNOOLN;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static NCEKLMPIJLO FONPJEBOGCF;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x7EE1EE0", Offset = "0x7EE0AE0", VA = "0x187EE1EE0")]
				public static PlayerLoopSystem BKEJHDEMDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct OBEFOMCIDBO
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static NCEKLMPIJLO IAJNPMKNBJK;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x7EE50F0", Offset = "0x7EE3CF0", VA = "0x187EE50F0")]
				public static PlayerLoopSystem BKEJHDEMDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct DMIMKCEOJIK
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static NCEKLMPIJLO LOKMFCBHBCJ;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7ED56D0", Offset = "0x7ED42D0", VA = "0x187ED56D0")]
				public static PlayerLoopSystem BKEJHDEMDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct BPFBMPDPIGD
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static NCEKLMPIJLO FDLALLOEIJC;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x7ECD690", Offset = "0x7ECC290", VA = "0x187ECD690")]
				public static PlayerLoopSystem BKEJHDEMDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct MLKDOKLMPKO
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static NCEKLMPIJLO HDLCPMPEBHK;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x7EE2A60", Offset = "0x7EE1660", VA = "0x187EE2A60")]
				public static PlayerLoopSystem BKEJHDEMDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct HLEBAGEPNON
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static NCEKLMPIJLO EEMINBDLHPC;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x7ED8F90", Offset = "0x7ED7B90", VA = "0x187ED8F90")]
				public static PlayerLoopSystem BKEJHDEMDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct AFODADPFAOJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static NCEKLMPIJLO JCEFIOFMEPF;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x7ECBC40", Offset = "0x7ECA840", VA = "0x187ECBC40")]
				public static PlayerLoopSystem BKEJHDEMDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct MHJCJNPEBDF
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static NCEKLMPIJLO KIJNADDHCLI;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x7EE1360", Offset = "0x7EDFF60", VA = "0x187EE1360")]
				public static PlayerLoopSystem BKEJHDEMDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct JFEBCNONKDM
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static NCEKLMPIJLO NDNNEGLJAFJ;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x7EDDB10", Offset = "0x7EDC710", VA = "0x187EDDB10")]
				public static PlayerLoopSystem BKEJHDEMDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct DKGBMFCEBII
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static NCEKLMPIJLO CGPDIPACNCJ;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x7ED54F0", Offset = "0x7ED40F0", VA = "0x187ED54F0")]
				public static PlayerLoopSystem BKEJHDEMDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum MCCCILJADGJ : byte
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
			public struct KFAJKJAMHKG
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class HHPPHNBABCL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public MCCCILJADGJ updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
					public HHPPHNBABCL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x7ED8F10", Offset = "0x7ED7B10", VA = "0x187ED8F10")]
					internal void CPPHIAAMGAI()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static ONIGKBMFFEH<MCCCILJADGJ> AECKOPDNOGD;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x7EDDE60", Offset = "0x7EDCA60", VA = "0x187EDDE60")]
				public static PlayerLoopSystem BKEJHDEMDJA(MCCCILJADGJ DJBLJKJOFIF)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct PPCDDOGDHMF
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class FFKOOFHOPMN
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public OOOBFOEOAGM.BCKDIBBEAFE key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
					public FFKOOFHOPMN()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x7ED7DD0", Offset = "0x7ED69D0", VA = "0x187ED7DD0")]
					internal void HLCEADJGGMM()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable BOPLLPCIHDB;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7EE76A0", Offset = "0x7EE62A0", VA = "0x187EE76A0")]
				public static PlayerLoopSystem JKHMEAFAIHK(OOOBFOEOAGM.BCKDIBBEAFE NKANGPLHEGE)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct EPOFBCOLENM
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class DBJOFIHJELP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public OOOBFOEOAGM.BCKDIBBEAFE key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
					public DBJOFIHJELP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x7ED4FE0", Offset = "0x7ED3BE0", VA = "0x187ED4FE0")]
					internal void HLCEADJGGMM()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7ED74F0", Offset = "0x7ED60F0", VA = "0x187ED74F0")]
				public static PlayerLoopSystem JKHMEAFAIHK(OOOBFOEOAGM.BCKDIBBEAFE NKANGPLHEGE)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class NEFPFMHELCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public NEFPFMHELCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7EE3DB0", Offset = "0x7EE29B0", VA = "0x187EE3DB0")]
			internal List<PlayerLoopSystem> AEHDBCPGABC(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool OCLOLALIHAA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool MPNHMJJKFHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7ED1150", Offset = "0x7ECFD50", VA = "0x187ED1150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1D90", Offset = "0x7ED0990", VA = "0x187ED1D90")]
		private static void NKEJNANIALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1480", Offset = "0x7ED0080", VA = "0x187ED1480")]
		private static void NHIBOODNDAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7ED0D30", Offset = "0x7ECF930", VA = "0x187ED0D30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7ED4DA0", Offset = "0x7ED39A0", VA = "0x187ED4DA0")]
		private static void OHEBMLBOPBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1190", Offset = "0x7ECFD90", VA = "0x187ED1190")]
		private static void KEEKCIMIFEP(OOOBFOEOAGM.BCKDIBBEAFE NKANGPLHEGE, PlayerLoopSystem APANCFJINHP, Type JOIKIAPBGBB, Type GFOJFONFPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED0D70", Offset = "0x7ECF970", VA = "0x187ED0D70")]
		private static void DAEHHOKLHBO(PlayerLoopSystem APANCFJINHP, Type JOIKIAPBGBB, Type GFOJFONFPJJ, EAGLDLJOACK KLMDOGCEGAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1350", Offset = "0x7ECFF50", VA = "0x187ED1350")]
		private static void NCJBFLFEDEC(PlayerLoopSystem APANCFJINHP, Type JOIKIAPBGBB, Type GFOJFONFPJJ, PlayerLoopSystem? JFJPGEIOEIH, PlayerLoopSystem? BBOMCNJJEJM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class OOOBFOEOAGM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum BCKDIBBEAFE
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
	public class GPBOPKFALDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly BCKDIBBEAFE EPKCNFMKCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly CPKJANIAKFI ONJOKEDMILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long CDDKDAMPKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long OJLBIGFOMNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long ELFBAMMHKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int HPNKLKNFGGC;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7ED8CA0", Offset = "0x7ED78A0", VA = "0x187ED8CA0")]
		public GPBOPKFALDK(BCKDIBBEAFE KHPEAEOIFHE, int KAHFKALNPEN = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7ED8C80", Offset = "0x7ED7880", VA = "0x187ED8C80")]
		public void LOBJMJELEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7ED8B50", Offset = "0x7ED7750", VA = "0x187ED8B50")]
		public void FILBIFLDICK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7ED8BA0", Offset = "0x7ED77A0", VA = "0x187ED8BA0")]
		public void LNGFFFMEFAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static BCKDIBBEAFE[] DAOPEAKGANC;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static GPBOPKFALDK[] KFOEECKGBGI;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7EE6770", Offset = "0x7EE5370", VA = "0x187EE6770")]
	public static GPBOPKFALDK JDIEEMGFFJB(BCKDIBBEAFE NKANGPLHEGE, int KAHFKALNPEN = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7EE68C0", Offset = "0x7EE54C0", VA = "0x187EE68C0")]
	public static GPBOPKFALDK JGMGNKEAGBM(BCKDIBBEAFE NKANGPLHEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7EE6930", Offset = "0x7EE5530", VA = "0x187EE6930")]
	public static void NMNNJAOGBFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EFGAODMIFGF
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private interface NHIIFMAHCAK
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool MDPEBFELBCM
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BAHMIJKKLIG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class GCHKGJDMHAC : NHIIFMAHCAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action OAGMINHECCA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool MDPEBFELBCM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
		public GCHKGJDMHAC(Action OAGMINHECCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xF44100", Offset = "0xF42D00", VA = "0x180F44100", Slot = "5")]
		public void BAHMIJKKLIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<NHIIFMAHCAK> ICMCFAKBLGJ;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5FB0", Offset = "0x7ED4BB0", VA = "0x187ED5FB0")]
	public static void JOEONGFNBOP(Action OAGMINHECCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6050", Offset = "0x7ED4C50", VA = "0x187ED6050")]
	private static void PNEGFJCILHL(NHIIFMAHCAK KHBCIBOKIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5CD0", Offset = "0x7ED48D0", VA = "0x187ED5CD0")]
	private static void IHOBENAMFCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5B00", Offset = "0x7ED4700", VA = "0x187ED5B00")]
	private static void ACHKGPLEBBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5C00", Offset = "0x7ED4800", VA = "0x187ED5C00")]
	private static void APBDPAHJABL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class LFLPDHAJBCE
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct PPPIFEKPMCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TaskCompletionSource<Scene> CDICICOJJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly string JMDBEOGKEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly LoadSceneMode AAICANKLIEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly bool BJEPJNHFKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7EE77D0", Offset = "0x7EE63D0", VA = "0x187EE77D0")]
		public PPPIFEKPMCH(TaskCompletionSource<Scene> LEFMCEKDBEO, string JMDBEOGKEMG, LoadSceneMode AAICANKLIEP, bool BJEPJNHFKNK, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct OCOCGFJNLIK : IAsyncStateMachine
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
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private FNEANCIAOBI<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x7EE5320", Offset = "0x7EE3F20", VA = "0x187EE5320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7EE5BC0", Offset = "0x7EE47C0", VA = "0x187EE5BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct FPMBBCDICOA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7ED8460", Offset = "0x7ED7060", VA = "0x187ED8460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7ED8770", Offset = "0x7ED7370", VA = "0x187ED8770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct EKICIHCHCAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private PPPIFEKPMCH <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6EB0", Offset = "0x7ED5AB0", VA = "0x187ED6EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED7270", Offset = "0x7ED5E70", VA = "0x187ED7270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class PILHEGCIKFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NJNAONPKMIH<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public PILHEGCIKFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7640", Offset = "0x7EE6240", VA = "0x187EE7640")]
		internal void DOCFDOCBCNC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct AIHPGMNJLKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

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
		private PILHEGCIKFA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7ECBE20", Offset = "0x7ECAA20", VA = "0x187ECBE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7ECC9C0", Offset = "0x7ECB5C0", VA = "0x187ECC9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct JCIOAHCHBPN : IAsyncStateMachine
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
		private GINHMPCLHHC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7EDD3E0", Offset = "0x7EDBFE0", VA = "0x187EDD3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7EDDAA0", Offset = "0x7EDC6A0", VA = "0x187EDDAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct KOJCBKOIBAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE020", Offset = "0x7EDCC20", VA = "0x187EDE020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7EDEB40", Offset = "0x7EDD740", VA = "0x187EDEB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class FCHMDELGBAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public NJNAONPKMIH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public FCHMDELGBAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7ED7D50", Offset = "0x7ED6950", VA = "0x187ED7D50")]
		internal bool NNHLJPKCEGD(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED7AF0", Offset = "0x7ED66F0", VA = "0x187ED7AF0")]
		internal void KNJCFDPJCIA(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class MGKIOBPMAIK : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public NJNAONPKMIH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private FCHMDELGBAA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private GINHMPCLHHC <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public MGKIOBPMAIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE1300", Offset = "0x7EDFF00", VA = "0x187EE1300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0A30", Offset = "0x7EDF630", VA = "0x187EE0A30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0A10", Offset = "0x7EDF610", VA = "0x187EE0A10")]
		private void AOMOFJGADBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7EE12B0", Offset = "0x7EDFEB0", VA = "0x187EE12B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ICollection<string> PDMLAGCJPPN;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static HAGJNGKFIOK EHDMCOIPIKF;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AsyncOperation KDOIAEPPMOI;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static HAGJNGKFIOK ANJOPAOECMO;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static string FCPBEKIEOND;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string CLHLJPBPGPP;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority BNNKFMHDPDF;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task NFHHNDDPJEK;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static List<SceneInstance> ABBGOFHAGNI;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly Queue<PPPIFEKPMCH> DKFGEOJKPMI;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static Task MODPEHGFLBJ;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> DIHBGGLOPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7EDED90", Offset = "0x7EDD990", VA = "0x187EDED90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7EDFA90", Offset = "0x7EDE690", VA = "0x187EDFA90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7EDF890", Offset = "0x7EDE490", VA = "0x187EDF890")]
	[CBLJHIHADGM(HEJIADEAGNL.EnteredEditModeNextFrame, 0)]
	private static void MOPHLKMEKHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7EDF5F0", Offset = "0x7EDE1F0", VA = "0x187EDF5F0")]
	[AsyncStateMachine(typeof(OCOCGFJNLIK))]
	public static Task<Scene> MBDCBPDLHIM(string JMDBEOGKEMG, LoadSceneMode AAICANKLIEP = LoadSceneMode.Single, bool BJEPJNHFKNK = false, [Optional] FNEANCIAOBI<string>.IDKBCAKILKJ PAKBEAIOLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7EDF320", Offset = "0x7EDDF20", VA = "0x187EDF320")]
	[AsyncStateMachine(typeof(FPMBBCDICOA))]
	private static Task HAPBNKODDBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7EDF250", Offset = "0x7EDDE50", VA = "0x187EDF250")]
	[AsyncStateMachine(typeof(EKICIHCHCAN))]
	private static Task GBLNPCPNPPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7EDF740", Offset = "0x7EDE340", VA = "0x187EDF740")]
	[AsyncStateMachine(typeof(AIHPGMNJLKP))]
	private static Task<Scene> MGBKHLAMJAG(string JMDBEOGKEMG, LoadSceneMode AAICANKLIEP, bool BJEPJNHFKNK, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7EDFD90", Offset = "0x7EDE990", VA = "0x187EDFD90")]
	private static void PDNIBAKBPLD(SceneInstance ONEEJFNLBJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7EDEFA0", Offset = "0x7EDDBA0", VA = "0x187EDEFA0")]
	private static void FODABJHNBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7EDFBA0", Offset = "0x7EDE7A0", VA = "0x187EDFBA0")]
	[AsyncStateMachine(typeof(JCIOAHCHBPN))]
	private static Task<Scene> OGIILPDLNHG(string JMDBEOGKEMG, LoadSceneMode AAICANKLIEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7EDF500", Offset = "0x7EDE100", VA = "0x187EDF500")]
	private static bool JBFBAIGBNAP(string JMDBEOGKEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7EDF980", Offset = "0x7EDE580", VA = "0x187EDF980")]
	[AsyncStateMachine(typeof(KOJCBKOIBAO))]
	private static Task<Scene> NDEDMMLELAA(FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7EDFEA0", Offset = "0x7EDEAA0", VA = "0x187EDFEA0")]
	public static JOIICJDLMNO<Scene> PLIJIOCNDCN(string JMDBEOGKEMG, LoadSceneMode AAICANKLIEP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7EDEF00", Offset = "0x7EDDB00", VA = "0x187EDEF00")]
	[IteratorStateMachine(typeof(MGKIOBPMAIK))]
	private static IEnumerator<LNKBBFODFEI> EMFDOONCGKH(string JMDBEOGKEMG, LoadSceneMode AAICANKLIEP, NJNAONPKMIH<Scene> KJHIMOCEDKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7EDEEA0", Offset = "0x7EDDAA0", VA = "0x187EDEEA0")]
	public static void EIKJMGAIDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7EDFCD0", Offset = "0x7EDE8D0", VA = "0x187EDFCD0")]
	private static void OLDKELOMOIF(string JMDBEOGKEMG, LoadSceneMode AAICANKLIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7EDF3D0", Offset = "0x7EDDFD0", VA = "0x187EDF3D0")]
	public static bool HEPFGEJDNFE([Out] string MMIOPJEMABA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class IALBOMBCJPC
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7EDBB60", Offset = "0x7EDA760", VA = "0x187EDBB60")]
	public static IDisposable AFAEOMHNIKE(this LINGKPHABBI HJIAOGEIAJO, float ENCKGJBJKPE, Action<float> LPPMMOCPCCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7EDBBF0", Offset = "0x7EDA7F0", VA = "0x187EDBBF0")]
	public static IDisposable CJEBJBPHGPK(this LINGKPHABBI HJIAOGEIAJO, Action<float> LPPMMOCPCCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7EDBC70", Offset = "0x7EDA870", VA = "0x187EDBC70")]
	public static IDisposable KPGFCEHFLLN(this LINGKPHABBI HJIAOGEIAJO, Action<float> LPPMMOCPCCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class LHOOBPDKMBG
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3451720", Offset = "0x3450320", VA = "0x183451720")]
	[FGBJJOHEICE]
	public static IDisposable IJMJCFFELGK<T>(this T DIFAGCOONAH, Action LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3451570", Offset = "0x3450170", VA = "0x183451570")]
	[FGBJJOHEICE]
	public static IDisposable IJMJCFFELGK<T>(this T DIFAGCOONAH, Action<float> LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x34518D0", Offset = "0x34504D0", VA = "0x1834518D0")]
	[FGBJJOHEICE]
	public static IDisposable KAFGFLAKMPI<T>(this T DIFAGCOONAH, Action LPPMMOCPCCM, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3451A20", Offset = "0x3450620", VA = "0x183451A20")]
	[FGBJJOHEICE]
	public static IDisposable PBGANMHGDPP<T>(this T DIFAGCOONAH, Action LPPMMOCPCCM, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3451A20", Offset = "0x3450620", VA = "0x183451A20")]
	[FGBJJOHEICE]
	public static IDisposable PBGANMHGDPP<T>(this T DIFAGCOONAH, Action<float> LPPMMOCPCCM, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x34511D0", Offset = "0x344FDD0", VA = "0x1834511D0")]
	[FGBJJOHEICE]
	public static IDisposable FAFCBHKAHMF<T>(this T DIFAGCOONAH, Action LPPMMOCPCCM, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x34519D0", Offset = "0x34505D0", VA = "0x1834519D0")]
	[FGBJJOHEICE]
	public static IDisposable OGPFCPFOJLG<T>(this T DIFAGCOONAH, Action LPPMMOCPCCM, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x34514C0", Offset = "0x34500C0", VA = "0x1834514C0")]
	[FGBJJOHEICE]
	public static IDisposable HBOAFAMPAMK<T>(this T DIFAGCOONAH, Action LPPMMOCPCCM, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x34513D0", Offset = "0x344FFD0", VA = "0x1834513D0")]
	[FGBJJOHEICE]
	public static IDisposable FFANMNJADBB<T>(this T DIFAGCOONAH, float ENCKGJBJKPE, Action<float> LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0540", Offset = "0x7EDF140", VA = "0x187EE0540")]
	[FGBJJOHEICE]
	public static IDisposable FFANMNJADBB(this MonoBehaviour DIFAGCOONAH, PMHAEKLGAHN HJIAOGEIAJO, float ENCKGJBJKPE, Action<float> LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3451220", Offset = "0x344FE20", VA = "0x183451220")]
	[FGBJJOHEICE]
	public static IDisposable FAODEHBCOKD<T>(this T DIFAGCOONAH, float ENCKGJBJKPE, Action<float> LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x34510C0", Offset = "0x344FCC0", VA = "0x1834510C0")]
	[FGBJJOHEICE]
	public static IDisposable CBMFIOGPHGP<T>(this T DIFAGCOONAH, float ENCKGJBJKPE, Action<float> LPPMMOCPCCM, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3451910", Offset = "0x3450510", VA = "0x183451910")]
	[FGBJJOHEICE]
	public static IDisposable KLGMOLKCDAF<T>(this T DIFAGCOONAH, Action<float> LPPMMOCPCCM, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3451060", Offset = "0x344FC60", VA = "0x183451060")]
	[FGBJJOHEICE]
	public static IDisposable BDKLHPPOGHL<T>(this T DIFAGCOONAH, Action<float> LPPMMOCPCCM, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3451970", Offset = "0x3450570", VA = "0x183451970")]
	[FGBJJOHEICE]
	public static IDisposable LHIKMMMEAAN<T>(this T DIFAGCOONAH, Action<float> LPPMMOCPCCM, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3451170", Offset = "0x344FD70", VA = "0x183451170")]
	[FGBJJOHEICE]
	public static IDisposable EFMEKLIAGBP<T>(this T DIFAGCOONAH, Action<float> LPPMMOCPCCM, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3451410", Offset = "0x3450010", VA = "0x183451410")]
	[FGBJJOHEICE]
	public static IDisposable FKGCBJJJAOI<T>(this T DIFAGCOONAH, Action<float> LPPMMOCPCCM, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3451510", Offset = "0x3450110", VA = "0x183451510")]
	[FGBJJOHEICE]
	public static IDisposable HKAHFGNDPOL<T>(this T DIFAGCOONAH, Action<float> LPPMMOCPCCM, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3451000", Offset = "0x344FC00", VA = "0x183451000")]
	[FGBJJOHEICE]
	public static IDisposable AIOICFGOBIE<T>(this T DIFAGCOONAH, Action<float> LPPMMOCPCCM, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3451470", Offset = "0x3450070", VA = "0x183451470")]
	[FGBJJOHEICE]
	public static IDisposable GJOPPNGEBOE<T>(this T DIFAGCOONAH, float ENCKGJBJKPE, Action<float> LPPMMOCPCCM, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3451110", Offset = "0x344FD10", VA = "0x183451110")]
	[FGBJJOHEICE]
	public static IDisposable ECPBGCNCOCE<T>(this T DIFAGCOONAH, Action<float> LPPMMOCPCCM, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3451A70", Offset = "0x3450670", VA = "0x183451A70")]
	[FGBJJOHEICE]
	public static IDisposable PFKMNIPNNGL<T>(this T DIFAGCOONAH, Action<float> LPPMMOCPCCM, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true) where T : MonoBehaviour, PMHAEKLGAHN
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class LFOLPAENEHI
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class JMJAJEDOECA : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public NJCENJCNKPK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private EOEMGKAAFEM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public JMJAJEDOECA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7EDDCF0", Offset = "0x7EDC8F0", VA = "0x187EDDCF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7EDDDD0", Offset = "0x7EDC9D0", VA = "0x187EDDDD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class PBOOFHMIPAC : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public NJCENJCNKPK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private EOEMGKAAFEM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public PBOOFHMIPAC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7EE6B60", Offset = "0x7EE5760", VA = "0x187EE6B60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7EE6C50", Offset = "0x7EE5850", VA = "0x187EE6C50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7EE03A0", Offset = "0x7EDEFA0", VA = "0x187EE03A0")]
	public static NAEMDCMJKFJ IJMJCFFELGK(Action LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0230", Offset = "0x7EDEE30", VA = "0x187EE0230")]
	public static NAEMDCMJKFJ IJMJCFFELGK(Behaviour HJIAOGEIAJO, Action LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7EE02C0", Offset = "0x7EDEEC0", VA = "0x187EE02C0")]
	public static NAEMDCMJKFJ IJMJCFFELGK(Behaviour HJIAOGEIAJO, Action<float> LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0420", Offset = "0x7EDF020", VA = "0x187EE0420")]
	[IteratorStateMachine(typeof(JMJAJEDOECA))]
	private static IEnumerator<LNKBBFODFEI> OGAKLAHFHNK(NJCENJCNKPK EAMKEHDGGKG, Action LPPMMOCPCCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7EE04B0", Offset = "0x7EDF0B0", VA = "0x187EE04B0")]
	[IteratorStateMachine(typeof(PBOOFHMIPAC))]
	private static IEnumerator<LNKBBFODFEI> OGAKLAHFHNK(NJCENJCNKPK EAMKEHDGGKG, Action<float> LPPMMOCPCCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class FJJEJGMKHID : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class DEEBIJMAGNB : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public FJJEJGMKHID <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public DEEBIJMAGNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED5290", Offset = "0x7ED3E90", VA = "0x187ED5290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7ED5320", Offset = "0x7ED3F20", VA = "0x187ED5320", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly NJCENJCNKPK DHEAPPNIOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action PDPJFOLKGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool LDJEOBFPGKN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool MCDJDPMKNFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x95D150", Offset = "0x95BD50", VA = "0x18095D150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8170", Offset = "0x7ED6D70", VA = "0x187ED8170")]
	public FJJEJGMKHID(NJCENJCNKPK DHEAPPNIOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8050", Offset = "0x7ED6C50", VA = "0x187ED8050")]
	[IteratorStateMachine(typeof(DEEBIJMAGNB))]
	private IEnumerator<LNKBBFODFEI> FLNABAKKGJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7ED80D0", Offset = "0x7ED6CD0", VA = "0x187ED80D0", Slot = "4")]
	public void OnCompleted(Action AKAIBCLAGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
	public void HEFBJMINLAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class AEIIODEJBKG
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7ECBB30", Offset = "0x7ECA730", VA = "0x187ECBB30")]
	public static FJJEJGMKHID MADAPDACNGL(this NJCENJCNKPK DHEAPPNIOKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class BAPGPMGADJC
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class ADOAIEOOLLH : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public FGKMMPINMIA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public ADOAIEOOLLH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7ECBA60", Offset = "0x7ECA660", VA = "0x187ECBA60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7ECBAE0", Offset = "0x7ECA6E0", VA = "0x187ECBAE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCCE0", Offset = "0x7ECB8E0", VA = "0x187ECCCE0")]
	public static NAEMDCMJKFJ IJMJCFFELGK(float ENCKGJBJKPE, Action<float> LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK, bool COMNLLOBBMJ = true, [Optional] NBAJMNEFPBH LFHGHCGKEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCC10", Offset = "0x7ECB810", VA = "0x187ECCC10")]
	public static NAEMDCMJKFJ IJMJCFFELGK(MonoBehaviour DIFAGCOONAH, float ENCKGJBJKPE, Action<float> LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK, bool COMNLLOBBMJ = true, [Optional] NBAJMNEFPBH LFHGHCGKEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCDB0", Offset = "0x7ECB9B0", VA = "0x187ECCDB0")]
	public static NAEMDCMJKFJ JFDAKLIOAPJ(MonoBehaviour DIFAGCOONAH, float ENCKGJBJKPE, Action<float> LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK, bool COMNLLOBBMJ = true, [Optional] NBAJMNEFPBH LFHGHCGKEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCAE0", Offset = "0x7ECB6E0", VA = "0x187ECCAE0")]
	public static NAEMDCMJKFJ DOCFPJNALDC(LINGKPHABBI HJIAOGEIAJO, float ENCKGJBJKPE, Action<float> LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK, bool COMNLLOBBMJ = true, [Optional] NBAJMNEFPBH LFHGHCGKEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCF30", Offset = "0x7ECBB30", VA = "0x187ECCF30")]
	private static IEnumerator<LNKBBFODFEI> OGAKLAHFHNK(DPEOLCNPLPB JIHGCOKLHGG, float ENCKGJBJKPE, NJCENJCNKPK EAMKEHDGGKG, Action<float> LPPMMOCPCCM, bool COMNLLOBBMJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCBB0", Offset = "0x7ECB7B0", VA = "0x187ECCBB0")]
	private static IEnumerator<LNKBBFODFEI> HFMAOBBPBCC(DPEOLCNPLPB JIHGCOKLHGG, float ENCKGJBJKPE, NJCENJCNKPK EAMKEHDGGKG, Action<float> LPPMMOCPCCM, bool COMNLLOBBMJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCEA0", Offset = "0x7ECBAA0", VA = "0x187ECCEA0")]
	[IteratorStateMachine(typeof(ADOAIEOOLLH))]
	private static IEnumerator<LNKBBFODFEI> JPPAPMKJAML(FGKMMPINMIA GANPIEOJIOE, float ENCKGJBJKPE, NJCENJCNKPK EAMKEHDGGKG, Action<float> LPPMMOCPCCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class CBDHFFDAPHC
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class PEFICMBMLDI : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public NJCENJCNKPK queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public PEFICMBMLDI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7350", Offset = "0x7EE5F50", VA = "0x187EE7350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7410", Offset = "0x7EE6010", VA = "0x187EE7410", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7ECDA70", Offset = "0x7ECC670", VA = "0x187ECDA70")]
	[IteratorStateMachine(typeof(PEFICMBMLDI))]
	private static IEnumerator<LNKBBFODFEI> HIMIKMLFOOH(NJCENJCNKPK DHEAPPNIOKK, Func<bool> IKHACMHNJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD990", Offset = "0x7ECC590", VA = "0x187ECD990")]
	public static NAEMDCMJKFJ EGCKMNBBEMM(this MonoBehaviour DIFAGCOONAH, Func<bool> IKHACMHNJDM, NJCENJCNKPK DHEAPPNIOKK = NJCENJCNKPK.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class IBLCJMLEFLN
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class LODKLLDKAIF : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public NJCENJCNKPK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public LODKLLDKAIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE07E0", Offset = "0x7EDF3E0", VA = "0x187EE07E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0850", Offset = "0x7EDF450", VA = "0x187EE0850", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class DJDGLKJAGKD<T> : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public NJCENJCNKPK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public DJDGLKJAGKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x631CA20", Offset = "0x631B620", VA = "0x18631CA20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x631CAC0", Offset = "0x631B6C0", VA = "0x18631CAC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class LOONJMIAGHK : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public NJCENJCNKPK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private LNKBBFODFEI <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public LOONJMIAGHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7EE08A0", Offset = "0x7EDF4A0", VA = "0x187EE08A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0930", Offset = "0x7EDF530", VA = "0x187EE0930", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7EDBE20", Offset = "0x7EDAA20", VA = "0x187EDBE20")]
	[IteratorStateMachine(typeof(LODKLLDKAIF))]
	private static IEnumerator<LNKBBFODFEI> FLNABAKKGJN(float NOCMKPDPIPA, NJCENJCNKPK EAMKEHDGGKG, Action ONHFNCNDFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x33AFE90", Offset = "0x33AEA90", VA = "0x1833AFE90")]
	[IteratorStateMachine(typeof(DJDGLKJAGKD<>))]
	private static IEnumerator<LNKBBFODFEI> FLNABAKKGJN<T>(float NOCMKPDPIPA, NJCENJCNKPK EAMKEHDGGKG, Action<T> ONHFNCNDFHG, T GJPLANLJOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7EDBD80", Offset = "0x7EDA980", VA = "0x187EDBD80")]
	[IteratorStateMachine(typeof(LOONJMIAGHK))]
	private static IEnumerator<LNKBBFODFEI> DGPAEDEPLKF(float NOCMKPDPIPA, NJCENJCNKPK EAMKEHDGGKG, Action ONHFNCNDFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7EDC450", Offset = "0x7EDB050", VA = "0x187EDC450")]
	public static IDisposable NNGDPBLLAFL(this MonoBehaviour DIFAGCOONAH, float NOCMKPDPIPA, Action ONHFNCNDFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7EDC140", Offset = "0x7EDAD40", VA = "0x187EDC140")]
	public static NAEMDCMJKFJ IGOAODJPENL(this MonoBehaviour DIFAGCOONAH, float NOCMKPDPIPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7EDC530", Offset = "0x7EDB130", VA = "0x187EDC530")]
	public static NAEMDCMJKFJ NNGDPBLLAFL(this MonoBehaviour DIFAGCOONAH, float NOCMKPDPIPA, NJCENJCNKPK EAMKEHDGGKG, Action ONHFNCNDFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7EDBF60", Offset = "0x7EDAB60", VA = "0x187EDBF60")]
	public static NAEMDCMJKFJ GEEDLFKJGBA(this MonoBehaviour DIFAGCOONAH, Action ONHFNCNDFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x33AFF70", Offset = "0x33AEB70", VA = "0x1833AFF70")]
	public static NAEMDCMJKFJ GEEDLFKJGBA<T>(this MonoBehaviour DIFAGCOONAH, Action<T> ONHFNCNDFHG, T GJPLANLJOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7EDBEC0", Offset = "0x7EDAAC0", VA = "0x187EDBEC0")]
	public static NAEMDCMJKFJ FOBGBOKFHCK(this MonoBehaviour DIFAGCOONAH, Action ONHFNCNDFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7EDC310", Offset = "0x7EDAF10", VA = "0x187EDC310")]
	public static NAEMDCMJKFJ JPJPKJPCEJP(this MonoBehaviour DIFAGCOONAH, Action ONHFNCNDFHG, [Optional] NBAJMNEFPBH LFHGHCGKEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7EDC000", Offset = "0x7EDAC00", VA = "0x187EDC000")]
	public static NAEMDCMJKFJ GJNDOFICEPJ(this MonoBehaviour DIFAGCOONAH, Action ONHFNCNDFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7EDC0A0", Offset = "0x7EDACA0", VA = "0x187EDC0A0")]
	public static NAEMDCMJKFJ HELPEAKKJFD(this MonoBehaviour DIFAGCOONAH, Action ONHFNCNDFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7EDC270", Offset = "0x7EDAE70", VA = "0x187EDC270")]
	public static NAEMDCMJKFJ JJCMBGNIODK(MonoBehaviour DIFAGCOONAH, NJCENJCNKPK DHEAPPNIOKK, Action ONHFNCNDFHG, [Optional] NBAJMNEFPBH LFHGHCGKEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x33AFFC0", Offset = "0x33AEBC0", VA = "0x1833AFFC0")]
	public static NAEMDCMJKFJ JJCMBGNIODK<T>(MonoBehaviour DIFAGCOONAH, NJCENJCNKPK DHEAPPNIOKK, Action<T> ONHFNCNDFHG, T GJPLANLJOMM, [Optional] NBAJMNEFPBH LFHGHCGKEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7EDBCF0", Offset = "0x7EDA8F0", VA = "0x187EDBCF0")]
	public static NAEMDCMJKFJ COELLFBEHJK(this MonoBehaviour DIFAGCOONAH, float NMELPGBJCBJ, Action ONHFNCNDFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7EDC620", Offset = "0x7EDB220", VA = "0x187EDC620")]
	public static NAEMDCMJKFJ OLJGCKFKCIL(this MonoBehaviour DIFAGCOONAH, float NMELPGBJCBJ, Action ONHFNCNDFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7EDC1D0", Offset = "0x7EDADD0", VA = "0x187EDC1D0")]
	public static NAEMDCMJKFJ IMPENKMCPIN(this MonoBehaviour DIFAGCOONAH, float NMELPGBJCBJ, Action ONHFNCNDFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7EDC3B0", Offset = "0x7EDAFB0", VA = "0x187EDC3B0")]
	public static NAEMDCMJKFJ MOINFHLHIJK(this MonoBehaviour DIFAGCOONAH, float NMELPGBJCBJ, Action ONHFNCNDFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class MIBBIGMMMMN : MHFAMGHACND, IEnumerable<MHFAMGHACND>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly List<MHFAMGHACND> JGBDMCHIIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool PIFODIDMJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action LHJNKNENFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool HPELJJDHMOE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DCHAJGKABKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7EE1AA0", Offset = "0x7EE06A0", VA = "0x187EE1AA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NEDNPDKNLDL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE1850", Offset = "0x7EE0450", VA = "0x187EE1850", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7EE1D20", Offset = "0x7EE0920", VA = "0x187EE1D20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7EE1DC0", Offset = "0x7EE09C0", VA = "0x187EE1DC0")]
	public MIBBIGMMMMN([Optional] Action LHJNKNENFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE18F0", Offset = "0x7EE04F0", VA = "0x187EE18F0")]
	public void GFCJDEIJPEO(MHFAMGHACND IIPFMICLPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE1BD0", Offset = "0x7EE07D0", VA = "0x187EE1BD0")]
	private void IJLPHDHEOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7EE1540", Offset = "0x7EE0140", VA = "0x187EE1540", Slot = "7")]
	public bool DAHBHIDABDP(bool NBNIPGNLIMD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7EE1550", Offset = "0x7EE0150", VA = "0x187EE1550", Slot = "8")]
	public bool DAHBHIDABDP(Action OAGMINHECCA, bool NBNIPGNLIMD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7EE1A20", Offset = "0x7EE0620", VA = "0x187EE1A20", Slot = "9")]
	public IEnumerator<MHFAMGHACND> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7EE1A20", Offset = "0x7EE0620", VA = "0x187EE1A20", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class EODBKOFHBFG : OLMHJPOICAF
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class CHCKJMPBLOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public EODBKOFHBFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public CHCKJMPBLOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7ECF8B0", Offset = "0x7ECE4B0", VA = "0x187ECF8B0")]
		internal void DFBMJEOOABI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class LEHLIBGAHLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public EODBKOFHBFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public LEHLIBGAHLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7ECF8B0", Offset = "0x7ECE4B0", VA = "0x187ECF8B0")]
		internal void AEONCCOGIKI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float FJDGIMPFOBP;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED53B0", Offset = "0x7ED3FB0", VA = "0x187ED53B0")]
	public EODBKOFHBFG(Behaviour HJIAOGEIAJO, float FJDGIMPFOBP, [Optional] Action LHJNKNENFPN, [Optional] NBAJMNEFPBH LFHGHCGKEJE, [Optional] DPEOLCNPLPB JIHGCOKLHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED72D0", Offset = "0x7ED5ED0", VA = "0x187ED72D0", Slot = "9")]
	protected override bool GILIMJNCHHC(Action OAGMINHECCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED73E0", Offset = "0x7ED5FE0", VA = "0x187ED73E0", Slot = "10")]
	protected override bool OMAANMMPAKA(Action OAGMINHECCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface MHFAMGHACND
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool DCHAJGKABKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NEDNPDKNLDL;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DAHBHIDABDP(bool NBNIPGNLIMD = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DAHBHIDABDP(Action OAGMINHECCA, bool NBNIPGNLIMD = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class OLMHJPOICAF : MHFAMGHACND
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class BPJKPKICKOB : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public OLMHJPOICAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public BPJKPKICKOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD870", Offset = "0x7ECC470", VA = "0x187ECD870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD940", Offset = "0x7ECC540", VA = "0x187ECD940", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Behaviour HJIAOGEIAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Action LHJNKNENFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private FIJFJANJAHF KJFCAHEIAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly NBAJMNEFPBH LFHGHCGKEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly DPEOLCNPLPB JIHGCOKLHGG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DCHAJGKABKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1800CC0", Offset = "0x17FF8C0", VA = "0x181800CC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NEDNPDKNLDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7EE6230", Offset = "0x7EE4E30", VA = "0x187EE6230", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7EE65A0", Offset = "0x7EE51A0", VA = "0x187EE65A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7EE6640", Offset = "0x7EE5240", VA = "0x187EE6640")]
	protected OLMHJPOICAF(Behaviour HJIAOGEIAJO, [Optional] Action LHJNKNENFPN, [Optional] NBAJMNEFPBH LFHGHCGKEJE, [Optional] DPEOLCNPLPB JIHGCOKLHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7EE6130", Offset = "0x7EE4D30", VA = "0x187EE6130", Slot = "7")]
	public bool DAHBHIDABDP(bool NBNIPGNLIMD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE6190", Offset = "0x7EE4D90", VA = "0x187EE6190", Slot = "8")]
	public bool DAHBHIDABDP(Action OAGMINHECCA, bool NBNIPGNLIMD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool GILIMJNCHHC(Action OAGMINHECCA);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool OMAANMMPAKA(Action OAGMINHECCA);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE6110", Offset = "0x7EE4D10", VA = "0x187EE6110")]
	protected void CMPOGEINEEO(Action OAGMINHECCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7EE62D0", Offset = "0x7EE4ED0", VA = "0x187EE62D0")]
	protected HAGJNGKFIOK FFKMCILJPNP(float ALPIBOHIFKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7EE6520", Offset = "0x7EE5120", VA = "0x187EE6520")]
	private void HCDLDEEIJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7EE6080", Offset = "0x7EE4C80", VA = "0x187EE6080")]
	[IteratorStateMachine(typeof(BPJKPKICKOB))]
	private IEnumerator<LNKBBFODFEI> ALJPHGOFEPD(float ALPIBOHIFKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7EE61F0", Offset = "0x7EE4DF0", VA = "0x187EE61F0")]
	[CompilerGenerated]
	private void DMOKFJMAKKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class OGCNGHKLBFE : OLMHJPOICAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly float DMHFMCKNNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int KGEBKLFBEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float EPBKFCCIDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float[] AKIFBLPMGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int HJEFBHDIDEM;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7EE5EB0", Offset = "0x7EE4AB0", VA = "0x187EE5EB0")]
	public OGCNGHKLBFE(Behaviour HJIAOGEIAJO, float PJNPJAGAHMN, int KGEBKLFBEOK, [Optional] Action LHJNKNENFPN, float EPBKFCCIDCI = 0f, [Optional] NBAJMNEFPBH LFHGHCGKEJE, [Optional] DPEOLCNPLPB JIHGCOKLHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "9")]
	protected override bool GILIMJNCHHC(Action OAGMINHECCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE5CB0", Offset = "0x7EE48B0", VA = "0x187EE5CB0", Slot = "10")]
	protected override bool OMAANMMPAKA(Action OAGMINHECCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7EE5C30", Offset = "0x7EE4830", VA = "0x187EE5C30")]
	private void JPHCDAJOEMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DEEDGAMFOHI : OLMHJPOICAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float FJDGIMPFOBP;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED53B0", Offset = "0x7ED3FB0", VA = "0x187ED53B0")]
	public DEEDGAMFOHI(Behaviour HJIAOGEIAJO, float FJDGIMPFOBP, [Optional] Action LHJNKNENFPN, [Optional] NBAJMNEFPBH LFHGHCGKEJE, [Optional] DPEOLCNPLPB JIHGCOKLHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "9")]
	protected override bool GILIMJNCHHC(Action OAGMINHECCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5370", Offset = "0x7ED3F70", VA = "0x187ED5370", Slot = "10")]
	protected override bool OMAANMMPAKA(Action OAGMINHECCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class BMFLPGMBIGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class LJLHJDDNOHO : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public LJLHJDDNOHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0720", Offset = "0x7EDF320", VA = "0x187EE0720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0790", Offset = "0x7EDF390", VA = "0x187EE0790", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NAEMDCMJKFJ NKMGGGJJMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private LINGKPHABBI HJIAOGEIAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Action<float> HONKDLIELKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NJCENJCNKPK DHEAPPNIOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private float IFJMDDCEDOI;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD4F0", Offset = "0x7ECC0F0", VA = "0x187ECD4F0")]
	public BMFLPGMBIGE(LINGKPHABBI HJIAOGEIAJO, float ENCKGJBJKPE, Action<float> LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD380", Offset = "0x7ECBF80", VA = "0x187ECD380")]
	private void OPKCGJBKALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD070", Offset = "0x7ECBC70", VA = "0x187ECD070")]
	private void BDFABNAOKCN(string AHPAHIHOBBE, Action NDJPAIIIENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCFF0", Offset = "0x7ECBBF0", VA = "0x187ECCFF0")]
	[IteratorStateMachine(typeof(LJLHJDDNOHO))]
	private IEnumerator<LNKBBFODFEI> AEMKIIDHBBH(Action NDJPAIIIENB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD1A0", Offset = "0x7ECBDA0", VA = "0x187ECD1A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD200", Offset = "0x7ECBE00", VA = "0x187ECD200")]
	[CompilerGenerated]
	private void FBHOKBLAIHB(string MKDAJBJBGPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class NBFJLKPKKIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class OCCALGJJDPB : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public OCCALGJJDPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0720", Offset = "0x7EDF320", VA = "0x187EE0720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7EE52D0", Offset = "0x7EE3ED0", VA = "0x187EE52D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private NAEMDCMJKFJ NKMGGGJJMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private MonoBehaviour DIFAGCOONAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Action LPPMMOCPCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Action<float> HONKDLIELKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private NJCENJCNKPK DHEAPPNIOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float IFJMDDCEDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private bool COMNLLOBBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly NBAJMNEFPBH LFHGHCGKEJE;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7EE3A40", Offset = "0x7EE2640", VA = "0x187EE3A40")]
	public NBFJLKPKKIO(MonoBehaviour DIFAGCOONAH, Action LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK, [Optional] NBAJMNEFPBH LFHGHCGKEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE3870", Offset = "0x7EE2470", VA = "0x187EE3870")]
	public NBFJLKPKKIO(MonoBehaviour DIFAGCOONAH, Action<float> LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK, [Optional] NBAJMNEFPBH LFHGHCGKEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE3BD0", Offset = "0x7EE27D0", VA = "0x187EE3BD0")]
	public NBFJLKPKKIO(MonoBehaviour DIFAGCOONAH, float ENCKGJBJKPE, Action<float> LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK, bool COMNLLOBBMJ = true, [Optional] NBAJMNEFPBH LFHGHCGKEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC20280", VA = "0x180C21680")]
	private NBFJLKPKKIO(NBAJMNEFPBH LFHGHCGKEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7EE3350", Offset = "0x7EE1F50", VA = "0x187EE3350")]
	internal static NBFJLKPKKIO MJDNBDJKAGN(MonoBehaviour DIFAGCOONAH, float ENCKGJBJKPE, Action<float> LPPMMOCPCCM, NJCENJCNKPK DHEAPPNIOKK, bool COMNLLOBBMJ = true, [Optional] NBAJMNEFPBH LFHGHCGKEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7EE3190", Offset = "0x7EE1D90", VA = "0x187EE3190")]
	private void IJMJCFFELGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7EE36F0", Offset = "0x7EE22F0", VA = "0x187EE36F0")]
	private void PHJJMPMPION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7EE3580", Offset = "0x7EE2180", VA = "0x187EE3580")]
	private void OPKCGJBKALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7EE2EE0", Offset = "0x7EE1AE0", VA = "0x187EE2EE0")]
	private void EKEIPPKJMIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7EE2CC0", Offset = "0x7EE18C0", VA = "0x187EE2CC0")]
	private void BDFABNAOKCN(string AHPAHIHOBBE, Action NDJPAIIIENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7EE2C40", Offset = "0x7EE1840", VA = "0x187EE2C40")]
	[IteratorStateMachine(typeof(OCCALGJJDPB))]
	private IEnumerator<LNKBBFODFEI> AEMKIIDHBBH(Action NDJPAIIIENB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7EE2E80", Offset = "0x7EE1A80", VA = "0x187EE2E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7EE2DF0", Offset = "0x7EE19F0", VA = "0x187EE2DF0")]
	[CompilerGenerated]
	private void CALEDLMLLPG(string MKDAJBJBGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7EE32C0", Offset = "0x7EE1EC0", VA = "0x187EE32C0")]
	[CompilerGenerated]
	private void JEJLMOFOINE(string MKDAJBJBGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7EE3070", Offset = "0x7EE1C70", VA = "0x187EE3070")]
	[CompilerGenerated]
	private void GEEIDIAKJIM(string MKDAJBJBGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE3100", Offset = "0x7EE1D00", VA = "0x187EE3100")]
	[CompilerGenerated]
	private void IBNKPPAHEBJ(string MKDAJBJBGPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum BLNNMFKAJGB : byte
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
internal sealed class AJIBNAEFELK : DPEOLCNPLPB
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float FOKJPOOOCBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7ECCAA0", Offset = "0x7ECB6A0", VA = "0x187ECCAA0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public float DCDAGOLHDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7ECCAB0", Offset = "0x7ECB6B0", VA = "0x187ECCAB0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public double EHKPMPGMBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7ECCAC0", Offset = "0x7ECB6C0", VA = "0x187ECCAC0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCA30", Offset = "0x7ECB630", VA = "0x187ECCA30")]
	[DMDJPIBKEJJ.OHIIEKNFAKB]
	internal static void EKJPAICHAMI(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	[UnityEngine.Scripting.Preserve]
	internal AJIBNAEFELK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface FKJLOEODNCO
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DANLDOLAKEG(string BGKKCEGMOKH);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPIONGAPBDL();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface CIALCKNCBJA
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string NMFKAOGOELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool ALCMCMGHEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool LLNLEDEKFGB
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class FAONKMPDEOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public HLMDADPHOEJ MJEICOLLOCA;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int AHDPANGFLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9571A0", Offset = "0x955DA0", VA = "0x1809571A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x95DED0", Offset = "0x95CAD0", VA = "0x18095DED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7710", Offset = "0x7ED6310", VA = "0x187ED7710")]
	public static LNKBBFODFEI FKPFOMFMPCD(IEnumerator<LNKBBFODFEI> DCALLBBPNML, MKADMMENLEK BBLICLEDEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7650", Offset = "0x7ED6250", VA = "0x187ED7650")]
	public LNKBBFODFEI FKPFOMFMPCD(MKADMMENLEK[] CNAOIDFPOEA, IEnumerator<LNKBBFODFEI>[] OOJLKDIBJMC, LNKBBFODFEI[] ANBDCDEKMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7620", Offset = "0x7ED6220", VA = "0x187ED7620")]
	public void CLPIOMJPOBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7870", Offset = "0x7ED6470", VA = "0x187ED7870")]
	public void JFJDCFDNPJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7ED79B0", Offset = "0x7ED65B0", VA = "0x187ED79B0")]
	public void ODEDICJKNBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7620", Offset = "0x7ED6220", VA = "0x187ED7620")]
	public void GHAJACFBFNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public FAONKMPDEOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class HLMDADPHOEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct APGEJKHJLHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public FAONKMPDEOF GELNEDKNMPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public LINGKPHABBI HBOKLLPLOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public MKADMMENLEK GPJIFHDLNMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IEnumerator<LNKBBFODFEI> LBJMLEMELJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public LNKBBFODFEI LHEILNIGAOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public BLNNMFKAJGB DDPNBDGCFDO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct APAOHFFPOHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public NJCENJCNKPK CIKLFGMFFCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public List<APGEJKHJLHP> JMMPDBJEJKG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class NKLIJJOLJBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public MKADMMENLEK promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public HLMDADPHOEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public LINGKPHABBI context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public FAONKMPDEOF routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public BLNNMFKAJGB coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public LNKBBFODFEI currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IEnumerator<LNKBBFODFEI> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public NKLIJJOLJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7EE43B0", Offset = "0x7EE2FB0", VA = "0x187EE43B0")]
		internal void HEJJPFEDDEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class FKEBDGHFBFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public FAONKMPDEOF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public HLMDADPHOEJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public FKEBDGHFBFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED8240", Offset = "0x7ED6E40", VA = "0x187ED8240")]
		internal void BNNMJADHNDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class NELAJBDHGCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public FAONKMPDEOF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public HLMDADPHOEJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public NELAJBDHGCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE3ED0", Offset = "0x7EE2AD0", VA = "0x187EE3ED0")]
		internal void HGHELJPBLNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class JPBGJLNCMIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public FAONKMPDEOF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public HLMDADPHOEJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JPBGJLNCMIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7EDDE20", Offset = "0x7EDCA20", VA = "0x187EDDE20")]
		internal void KJAPDLKHBHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private const BLNNMFKAJGB CKCDNGMIBPP = BLNNMFKAJGB.Cancelled | BLNNMFKAJGB.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly NJCENJCNKPK DHEAPPNIOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool[] FCGKKDHBOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<BLNNMFKAJGB> IEPGGMFJAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeArray<float> DKJPGMMPIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<int> EJPAIPFLDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<int> NEJJMGPGPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> CCEAKAGGDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> LKEJBLMECJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> HPAGKALCMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private FAONKMPDEOF[] BEPFKPAKENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private MKADMMENLEK[] CNAOIDFPOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private LINGKPHABBI[] MDHCCAFHEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private IEnumerator<LNKBBFODFEI>[] FJLFOGBAPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private LNKBBFODFEI[] BFDPGPMOHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int LCHLNOOLMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int MFFEHHIHGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int OKJDDIBBPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float FAFFLNPBAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private OALDKJIPEIN DJDJGOGAMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JobHandle CKCNAEDGNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<FAONKMPDEOF> MDAJBDNLNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool APCPFHLJKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<Action> EAMNNNJFBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<Action> JFPIAHMJNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool LHMDIBMGEPK;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public APAOHFFPOHM[] GCPECNDDIMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA340D0", Offset = "0xA32CD0", VA = "0x180A340D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9170", Offset = "0x7ED7D70", VA = "0x187ED9170")]
	private static int DDFBDOLPFHG(NJCENJCNKPK DHEAPPNIOKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7EDB500", Offset = "0x7EDA100", VA = "0x187EDB500")]
	public HLMDADPHOEJ(NJCENJCNKPK DHEAPPNIOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7ED94D0", Offset = "0x7ED80D0", VA = "0x187ED94D0")]
	private void JEDEDKMIGGH(int KJONNLGFFNG, int NPJHHCLMPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7EDAFE0", Offset = "0x7ED9BE0", VA = "0x187EDAFE0")]
	public void PHDMLBJCEDO(LINGKPHABBI HJIAOGEIAJO, LNKBBFODFEI NIAAPFHNJPP, IEnumerator<LNKBBFODFEI> DCALLBBPNML, MKADMMENLEK BBLICLEDEDA, [Optional] FAONKMPDEOF BBILGPGANAF, BLNNMFKAJGB HBLPPGHJKAD = BLNNMFKAJGB.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7EDA340", Offset = "0x7ED8F40", VA = "0x187EDA340")]
	public void NFGFOODEHEA(IEnumerable<APGEJKHJLHP> MPCJPCEPAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7EDA580", Offset = "0x7ED9180", VA = "0x187EDA580")]
	private APGEJKHJLHP OEPJIJDDMEC(int GMFOBFBKADL)
	{
		return default(APGEJKHJLHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9E50", Offset = "0x7ED8A50", VA = "0x187ED9E50")]
	private void LBDFOGPEIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x338FDE0", Offset = "0x338E9E0", VA = "0x18338FDE0")]
	private static void KHOLLKADKEO<T>(int GMFOBFBKADL, T[] HFOHHDHLDPP, int FJJGAGKDECJ, [Optional] T IEHPLKNHMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x338FE30", Offset = "0x338EA30", VA = "0x18338FE30")]
	private static void KHOLLKADKEO<T>(int GMFOBFBKADL, NativeArray<T> HFOHHDHLDPP, int FJJGAGKDECJ, [Optional] T IEHPLKNHMOH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7EDB160", Offset = "0x7ED9D60", VA = "0x187EDB160")]
	private void PHIPPGAEJOE(IEnumerable<APGEJKHJLHP> MPCJPCEPAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7EDAF10", Offset = "0x7ED9B10", VA = "0x187EDAF10")]
	private void PCLKFKOPBAL(APGEJKHJLHP DDNPGKLGNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7EDAA50", Offset = "0x7ED9650", VA = "0x187EDAA50")]
	private JHGKCGCJLPM OILILPHPCAM(int DHFILMFGHNC)
	{
		return default(JHGKCGCJLPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7ED91A0", Offset = "0x7ED7DA0", VA = "0x187ED91A0")]
	public void ENDKFKCPDLE(float IIHDKBNFNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7EDA2C0", Offset = "0x7ED8EC0", VA = "0x187EDA2C0")]
	private void MPLLGCEAGIC(Action CEDOOEEEDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7ED96B0", Offset = "0x7ED82B0", VA = "0x187ED96B0")]
	private void JFADBKMACEA(Action CEDOOEEEDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9730", Offset = "0x7ED8330", VA = "0x187ED9730")]
	public void KOKOFHIGIBJ(float IIHDKBNFNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7EDA1C0", Offset = "0x7ED8DC0", VA = "0x187EDA1C0")]
	public void MPDBLNIHPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7ED93A0", Offset = "0x7ED7FA0", VA = "0x187ED93A0")]
	public void GHAJACFBFNK(FAONKMPDEOF GANPIEOJIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7EDADE0", Offset = "0x7ED99E0", VA = "0x187EDADE0")]
	public void PBKILAAJDHJ(FAONKMPDEOF GANPIEOJIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7EDACB0", Offset = "0x7ED98B0", VA = "0x187EDACB0")]
	public void OLBHEDJPOEM(FAONKMPDEOF GANPIEOJIOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class EBPLNFAHMKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static readonly EBPLNFAHMKP PCKMBPNMICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Action IMIFPEHACLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool BPEPOBJKFCM;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	public EBPLNFAHMKP(Action IMIFPEHACLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x75BF990", Offset = "0x75BE590", VA = "0x1875BF990", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface DDFFJLGBBLD<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	T GNLOKINMAMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable OFKPIBNKLDL(UnityEngine.Object HJIAOGEIAJO, Action<T> FMFGADBAADN);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface IBOBFONEJNP<T> : DDFFJLGBBLD<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	new T GNLOKINMAMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class LDMCIEMHHGC<T> : IBOBFONEJNP<T>, DDFFJLGBBLD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class EPNEMDFGMJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public LDMCIEMHHGC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public BPKHKDGAAFG<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public EPNEMDFGMJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x400C8B0", Offset = "0x400B4B0", VA = "0x18400C8B0")]
		internal void FDFLJOJGFPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static GameObject GBIJOKCCDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<BPKHKDGAAFG<UnityEngine.Object, Action<T>>> OGEKJLCHBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private T IEHLPCCPKPK;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T GNLOKINMAMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xBB8D00", Offset = "0xBB7900", VA = "0x180BB8D00", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4B24290", Offset = "0x4B22E90", VA = "0x184B24290", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4B24340", Offset = "0x4B22F40", VA = "0x184B24340")]
	private static bool EELFJOAMANM(T CEDOOEEEDCO, T LJEHMGANCNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4B24E60", Offset = "0x4B23A60", VA = "0x184B24E60")]
	public LDMCIEMHHGC(T CNHMJHABMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4B24600", Offset = "0x4B23200", VA = "0x184B24600", Slot = "6")]
	public IDisposable OFKPIBNKLDL(UnityEngine.Object HJIAOGEIAJO, Action<T> FMFGADBAADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4B247C0", Offset = "0x4B233C0", VA = "0x184B247C0")]
	private void PMNGBEJACIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class EKGOCALCDPJ : INHOJDEMPKM
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class NJMIBHPJKFH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private class EJGOOFKANON : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int HGEMPDBGGBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private NJMIBHPJKFH EAMKEHDGGKG;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xD4DE80", Offset = "0xD4CA80", VA = "0x180D4DE80")]
			public EJGOOFKANON(int HGEMPDBGGBJ, NJMIBHPJKFH EAMKEHDGGKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x7ED62F0", Offset = "0x7ED4EF0", VA = "0x187ED62F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class JCEFGHJJCOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public JCEFGHJJCOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1C500F0", Offset = "0x1C4ECF0", VA = "0x181C500F0")]
			internal bool AICJNOEGDHN(PDKJGMIEBLA e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class GGDDFJPHNBC : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private LNKBBFODFEI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public NJMIBHPJKFH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public DPEOLCNPLPB timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private EOEMGKAAFEM <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private List<PDKJGMIEBLA> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public GGDDFJPHNBC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x7ED87D0", Offset = "0x7ED73D0", VA = "0x187ED87D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x7ED8B00", Offset = "0x7ED7700", VA = "0x187ED8B00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly NJCENJCNKPK DHEAPPNIOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private NAEMDCMJKFJ BBLICLEDEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly List<PDKJGMIEBLA> JABLPMBIKAP;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7EE4310", Offset = "0x7EE2F10", VA = "0x187EE4310")]
		public NJMIBHPJKFH(NJCENJCNKPK DHEAPPNIOKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7EE40F0", Offset = "0x7EE2CF0", VA = "0x187EE40F0")]
		public IDisposable JKMOLIIOIAL(PDKJGMIEBLA AMDPFEJKBFB, NBAJMNEFPBH LFHGHCGKEJE, DPEOLCNPLPB IFHLDBMAMPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7EE3F10", Offset = "0x7EE2B10", VA = "0x187EE3F10")]
		private void DEKJACNNBGB(int HGEMPDBGGBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7EE4280", Offset = "0x7EE2E80", VA = "0x187EE4280")]
		[IteratorStateMachine(typeof(GGDDFJPHNBC))]
		private IEnumerator<LNKBBFODFEI> OGAKLAHFHNK(DPEOLCNPLPB IFHLDBMAMPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7EE40A0", Offset = "0x7EE2CA0", VA = "0x187EE40A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class PDKJGMIEBLA
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public enum JABJBGAMCKG : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static int KHHNJILBKDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public readonly int BJDOFIJCIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public readonly PMHAEKLGAHN HBOKLLPLOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly MonoBehaviour FBPLCOFANBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public readonly Action KAFGFLAKMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public readonly Action<float> JMBBJHHDAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public readonly float CDCMDFFAHLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float DKJPGMMPIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public readonly string NMFKAOGOELC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public readonly bool NFBLHLBBHEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public readonly JABJBGAMCKG FAHCEJLCEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool KHMPLENGGKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public bool IHGMOEFOHGA;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7EE71D0", Offset = "0x7EE5DD0", VA = "0x187EE71D0")]
		public PDKJGMIEBLA(PMHAEKLGAHN HJIAOGEIAJO, Action LPPMMOCPCCM, bool NKPIIKCANCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7050", Offset = "0x7EE5C50", VA = "0x187EE7050")]
		public PDKJGMIEBLA(PMHAEKLGAHN HJIAOGEIAJO, Action<float> LPPMMOCPCCM, bool NKPIIKCANCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7EE6E70", Offset = "0x7EE5A70", VA = "0x187EE6E70")]
		public PDKJGMIEBLA(PMHAEKLGAHN HJIAOGEIAJO, float ENCKGJBJKPE, Action<float> LPPMMOCPCCM, DPEOLCNPLPB IFHLDBMAMPN, JABJBGAMCKG JOMGNNNPDBJ, bool COMNLLOBBMJ, bool NKPIIKCANCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7EE6CA0", Offset = "0x7EE58A0", VA = "0x187EE6CA0")]
		public bool FIIEDGIOJMD(float MKKLKGKOEPB, float GCCEPHIJEAO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly NBAJMNEFPBH LFHGHCGKEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly DPEOLCNPLPB JIHGCOKLHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Dictionary<NJCENJCNKPK, NJMIBHPJKFH> LKENLICIMKF;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7ED69A0", Offset = "0x7ED55A0", VA = "0x187ED69A0")]
	[DMDJPIBKEJJ.OHIIEKNFAKB]
	internal static void JONBCEOCELE(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6DF0", Offset = "0x7ED59F0", VA = "0x187ED6DF0")]
	[UnityEngine.Scripting.Preserve]
	internal EKGOCALCDPJ([GJMNBPKNJPO(null)] NBAJMNEFPBH LFHGHCGKEJE, [GJMNBPKNJPO(null)] DPEOLCNPLPB JIHGCOKLHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6A10", Offset = "0x7ED5610", VA = "0x187ED6A10", Slot = "4")]
	public IDisposable KAFGFLAKMPI(PMHAEKLGAHN HJIAOGEIAJO, Action DKDPAFJDNNF, NJCENJCNKPK DHEAPPNIOKK, bool NKPIIKCANCK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6C00", Offset = "0x7ED5800", VA = "0x187ED6C00", Slot = "5")]
	public IDisposable KAFGFLAKMPI(PMHAEKLGAHN HJIAOGEIAJO, Action<float> DKDPAFJDNNF, NJCENJCNKPK DHEAPPNIOKK, bool NKPIIKCANCK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7ED64A0", Offset = "0x7ED50A0", VA = "0x187ED64A0", Slot = "7")]
	public IDisposable CBMFIOGPHGP(PMHAEKLGAHN HJIAOGEIAJO, float ENCKGJBJKPE, Action<float> DKDPAFJDNNF, NJCENJCNKPK DHEAPPNIOKK, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6760", Offset = "0x7ED5360", VA = "0x187ED6760", Slot = "8")]
	public IDisposable EPHLEDCGDFC(PMHAEKLGAHN HJIAOGEIAJO, float ENCKGJBJKPE, Action<float> DKDPAFJDNNF, NJCENJCNKPK DHEAPPNIOKK, bool COMNLLOBBMJ = true, bool NKPIIKCANCK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6320", Offset = "0x7ED4F20", VA = "0x187ED6320", Slot = "6")]
	public IDisposable CBMFIOGPHGP(float ENCKGJBJKPE, Action<float> DKDPAFJDNNF, bool COMNLLOBBMJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7ED65A0", Offset = "0x7ED51A0", VA = "0x187ED65A0", Slot = "9")]
	public void EDPJFJHBEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6860", Offset = "0x7ED5460", VA = "0x187ED6860")]
	private NJMIBHPJKFH FPAJNFAHOAL(NJCENJCNKPK DHEAPPNIOKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class IDDMHCEEKLJ : COLFOOCNNCA, NBAJMNEFPBH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private HLMDADPHOEJ[] LDGLNEAOAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private FKJLOEODNCO CDNPNNKPCEM;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7EDCDC0", Offset = "0x7EDB9C0", VA = "0x187EDCDC0")]
	[DMDJPIBKEJJ.OHIIEKNFAKB]
	internal static void EKJPAICHAMI(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7EDD320", Offset = "0x7EDBF20", VA = "0x187EDD320")]
	[UnityEngine.Scripting.Preserve]
	public IDDMHCEEKLJ([GJMNBPKNJPO(null)] PNFLBJJENGI NMDPHGPGOMH, [GJMNBPKNJPO(null)] DPEOLCNPLPB JIHGCOKLHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7EDCE60", Offset = "0x7EDBA60", VA = "0x187EDCE60", Slot = "19")]
	public override NAEMDCMJKFJ IAEBJBPKFOM(LINGKPHABBI HJIAOGEIAJO, IEnumerator<LNKBBFODFEI> MCKCBMOFKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7EDCA10", Offset = "0x7EDB610", VA = "0x187EDCA10", Slot = "20")]
	public override void EDPJFJHBEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7EDC6C0", Offset = "0x7EDB2C0", VA = "0x187EDC6C0", Slot = "22")]
	public override void ANMKBOEFJJO(NJCENJCNKPK DHEAPPNIOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7EDCF90", Offset = "0x7EDBB90", VA = "0x187EDCF90", Slot = "21")]
	protected override void KAFGFLAKMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7EDCE30", Offset = "0x7EDBA30", VA = "0x187EDCE30")]
	private HLMDADPHOEJ GKFKCKOKPEB(NJCENJCNKPK ADFFEBFOCBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7EDD100", Offset = "0x7EDBD00", VA = "0x187EDD100", Slot = "23")]
	internal override MKOEACODCBG KGCLFLHGNGC(IEnumerator<LNKBBFODFEI> MCKCBMOFKPG, Behaviour HJIAOGEIAJO, MKADMMENLEK BBLICLEDEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7EDC950", Offset = "0x7EDB550", VA = "0x187EDC950", Slot = "24")]
	internal override CEMJAPKLKJM EAFFIEDGBFL(NJCENJCNKPK EAMKEHDGGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7EDCCA0", Offset = "0x7EDB8A0", VA = "0x187EDCCA0")]
	private void EEJKCPEJADG(HLMDADPHOEJ BDIAAFPHAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7EDC8F0", Offset = "0x7EDB4F0", VA = "0x187EDC8F0", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[BurstCompile]
internal struct OALDKJIPEIN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ReadOnly]
	public float GOKKOHNKAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ReadOnly]
	public int AMHHHDEKHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<int> GICMADNDFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> KBPPJEBOAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<int> GBGPGDOOFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ReadOnly]
	public NativeArray<BLNNMFKAJGB> MHGDHOPBKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	public NativeArray<float> PFJACOAGMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[WriteOnly]
	public NativeArray<int> CCEAKAGGDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[WriteOnly]
	public NativeArray<int> EJPAIPFLDNF;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7EE4BC0", Offset = "0x7EE37C0", VA = "0x187EE4BC0")]
	public static OALDKJIPEIN EPPBBCFCJMI(int CNDNINOCCFH, float IIHDKBNFNGO, NativeArray<BLNNMFKAJGB> NJKFGOHGMHJ, NativeArray<float> FNCBLCJADPJ, NativeArray<int> NCAPCMDLCCD, NativeArray<int> CHNDPJOMHBL, NativeArray<int> GANCLOOHDNL, NativeArray<int> KBPPJEBOAGP, NativeArray<int> GBGPGDOOFIP)
	{
		return default(OALDKJIPEIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7EE4C20", Offset = "0x7EE3820", VA = "0x187EE4C20", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7EE4DA0", Offset = "0x7EE39A0", VA = "0x187EE4DA0")]
	private bool LJCMJJNIEPC(int BIEEMEKMINN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7EE4B90", Offset = "0x7EE3790", VA = "0x187EE4B90")]
	private void BGLCNMDGCPK(NativeArray<int> PKLIEALEDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7EE4D00", Offset = "0x7EE3900", VA = "0x187EE4D00")]
	private int GEPEIFEPFFN(int JEJGNLKKFCO, int ONLIECBAFMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7EE5020", Offset = "0x7EE3C20", VA = "0x187EE5020")]
	private void OFNIBOCPNIE(NativeArray<int> PKLIEALEDAO, int AHPPNHEFBCD, int JLCBCLJGOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7EE4DE0", Offset = "0x7EE39E0", VA = "0x187EE4DE0")]
	private void MDOLMEFEJJH(NativeArray<int> PKLIEALEDAO, int AGKLKHADDKF, int CEEBPFNJPJG, int ABMAHIIEAHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public abstract class COLFOOCNNCA : NBAJMNEFPBH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly PNFLBJJENGI NMDPHGPGOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected readonly DPEOLCNPLPB JIHGCOKLHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private CEMJAPKLKJM[] FNIBDHDDKFJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static NBAJMNEFPBH FFLNCJPMHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7ED06D0", Offset = "0x7ECF2D0", VA = "0x187ED06D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool DFIMOLGJAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public NJCENJCNKPK EGDJBMCCNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9571A0", Offset = "0x955DA0", VA = "0x1809571A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(NJCENJCNKPK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x95DED0", Offset = "0x95CAD0", VA = "0x18095DED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public DPEOLCNPLPB PKANCLJENJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public LNKBBFODFEI HMEHOIMPLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public LNKBBFODFEI CMPABKGEBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x961640", Offset = "0x960240", VA = "0x180961640", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LNKBBFODFEI JOFHALFIABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x95D120", Offset = "0x95BD20", VA = "0x18095D120", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LNKBBFODFEI DGNIEPGMJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x95F000", Offset = "0x95DC00", VA = "0x18095F000", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0620", Offset = "0x7ECF220", VA = "0x187ED0620")]
	public static NAEMDCMJKFJ KGFJKJHPGKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0840", Offset = "0x7ECF440", VA = "0x187ED0840")]
	[UnityEngine.Scripting.Preserve]
	protected COLFOOCNNCA([GJMNBPKNJPO(null)] PNFLBJJENGI NMDPHGPGOMH, [GJMNBPKNJPO(null)] DPEOLCNPLPB JIHGCOKLHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF970", Offset = "0x7ECE570", VA = "0x187ECF970", Slot = "6")]
	public NAEMDCMJKFJ BDNCCGGPJGH(IEnumerator<LNKBBFODFEI> MCKCBMOFKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF980", Offset = "0x7ECE580", VA = "0x187ECF980", Slot = "7")]
	public NAEMDCMJKFJ BDNCCGGPJGH(Behaviour HJIAOGEIAJO, IEnumerator<LNKBBFODFEI> MCKCBMOFKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract NAEMDCMJKFJ IAEBJBPKFOM(LINGKPHABBI HJIAOGEIAJO, IEnumerator<LNKBBFODFEI> MCKCBMOFKPG);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0370", Offset = "0x7ECEF70", VA = "0x187ED0370", Slot = "20")]
	public virtual void EDPJFJHBEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFBA0", Offset = "0x7ECE7A0", VA = "0x187ECFBA0", Slot = "9")]
	public void DHPHHGBEOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0600", Offset = "0x7ECF200", VA = "0x187ED0600", Slot = "21")]
	protected virtual void KAFGFLAKMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFB80", Offset = "0x7ECE780", VA = "0x187ECFB80")]
	private void DHEEDAEKEEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7ED05C0", Offset = "0x7ECF1C0", VA = "0x187ED05C0")]
	private void GFLGIPEKIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7ED07C0", Offset = "0x7ECF3C0", VA = "0x187ED07C0")]
	private void PBGANMHGDPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0510", Offset = "0x7ECF110", VA = "0x187ED0510")]
	private void FAFCBHKAHMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7ED05E0", Offset = "0x7ECF1E0", VA = "0x187ED05E0")]
	private void IAJNPMKNBJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7ED06B0", Offset = "0x7ECF2B0", VA = "0x187ED06B0")]
	private void LOKMFCBHBCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7ED07A0", Offset = "0x7ECF3A0", VA = "0x187ED07A0")]
	private void PAHHOHIBACD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF8E0", Offset = "0x7ECE4E0", VA = "0x187ECF8E0", Slot = "22")]
	public virtual void ANMKBOEFJJO(NJCENJCNKPK DHEAPPNIOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFDE0", Offset = "0x7ECE9E0", VA = "0x187ECFDE0")]
	private void DMBDMHNLGFA(CEMJAPKLKJM BDIAAFPHAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x24362D0", Offset = "0x2434ED0", VA = "0x1824362D0")]
	private CEMJAPKLKJM OKJNEMOBHLO(NJCENJCNKPK ADFFEBFOCBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract MKOEACODCBG KGCLFLHGNGC(IEnumerator<LNKBBFODFEI> MCKCBMOFKPG, Behaviour DIFAGCOONAH, MKADMMENLEK GFNMOIMAPMC);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract CEMJAPKLKJM EAFFIEDGBFL(NJCENJCNKPK DHEAPPNIOKK);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFFB0", Offset = "0x7ECEBB0", VA = "0x187ECFFB0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7ED07E0", Offset = "0x7ECF3E0", VA = "0x187ED07E0", Slot = "15")]
	public LNKBBFODFEI PJEMEAOHAFE(NJCENJCNKPK EAMKEHDGGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0530", Offset = "0x7ECF130", VA = "0x187ED0530", Slot = "16")]
	public LNKBBFODFEI GAHPLJKNECN(float NOCMKPDPIPA, NJCENJCNKPK EAMKEHDGGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0740", Offset = "0x7ECF340", VA = "0x187ED0740", Slot = "17")]
	public LNKBBFODFEI NMKJLABOHCA(Func<bool> IKHACMHNJDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class MKOEACODCBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly MKADMMENLEK BBLICLEDEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly CIALCKNCBJA HJIAOGEIAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly bool HPLCHGKELDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private string BGKKCEGMOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private StackTrace LDIJDCKFNLH;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<LNKBBFODFEI> LBJMLEMELJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public LNKBBFODFEI LHEILNIGAOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool CNKKONIEKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2520", Offset = "0x7EE1120", VA = "0x187EE2520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool BDBKCCJCLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAB3FB0", Offset = "0xAB2BB0", VA = "0x180AB3FB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAE9AC0", Offset = "0xAE86C0", VA = "0x180AE9AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string NMFKAOGOELC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2610", Offset = "0x7EE1210", VA = "0x187EE2610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float BONPKBKKMAD
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xE95CC0", Offset = "0xE948C0", VA = "0x180E95CC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6991AC0", Offset = "0x69906C0", VA = "0x186991AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7EE28A0", Offset = "0x7EE14A0", VA = "0x187EE28A0")]
	public MKOEACODCBG(IEnumerator<LNKBBFODFEI> DCALLBBPNML, CIALCKNCBJA HJIAOGEIAJO, MKADMMENLEK BBLICLEDEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7EE21B0", Offset = "0x7EE0DB0", VA = "0x187EE21B0")]
	public LNKBBFODFEI FKPFOMFMPCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7EE25A0", Offset = "0x7EE11A0", VA = "0x187EE25A0")]
	public bool MPLEPICOFBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7EE24D0", Offset = "0x7EE10D0", VA = "0x187EE24D0")]
	public void GHAJACFBFNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7EE27C0", Offset = "0x7EE13C0", VA = "0x187EE27C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xB4FC20", Offset = "0xB4E820", VA = "0x180B4FC20")]
	[CompilerGenerated]
	private void OEOJKHEFFJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class MKADMMENLEK : GMJMLPOPHPE, NAEMDCMJKFJ, FIJFJANJAHF, HAGJNGKFIOK, IEnumerator, LNKBBFODFEI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private NJCENJCNKPK NEBLCBHIJAO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private NJCENJCNKPK PKAOACMCJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xBEA520", Offset = "0xBE9120", VA = "0x180BEA520", Slot = "23")]
		get
		{
			return default(NJCENJCNKPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NJCENJCNKPK MJEICOLLOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xD75330", Offset = "0xD73F30", VA = "0x180D75330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float PGBMCEAFHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA88D80", Offset = "0xA87980", VA = "0x180A88D80", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool KBFFFLKNPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7EE1E70", Offset = "0x7EE0A70", VA = "0x187EE1E70", Slot = "24")]
	private bool ONFHPECLEFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7EE1E60", Offset = "0x7EE0A60", VA = "0x187EE1E60", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE1E90", Offset = "0x7EE0A90", VA = "0x187EE1E90")]
	public MKADMMENLEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal enum JHGKCGCJLPM : byte
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
internal sealed class CEMJAPKLKJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum HJFPABNAFDO
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct MGLGDCEAEIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public NJCENJCNKPK CIKLFGMFFCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public HJFPABNAFDO LPAADCADFMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public List<MKOEACODCBG> AHEPGAOOIOD;
	}

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly HJFPABNAFDO[] HIIGCGFHMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly NJCENJCNKPK DHEAPPNIOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool OCDCDMMKKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly MKOEACODCBG[] PHFDPJALCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly List<MKOEACODCBG> CMNOGPLCCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Stack<int> EKEFFLOEBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly List<MKOEACODCBG> HNKGLOLEHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Stack<int> IJEHANJGNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly FKJLOEODNCO PBJHPBHJPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool LHMDIBMGEPK;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MGLGDCEAEIE[,] IAHLGJNAMMO
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x95D120", Offset = "0x95BD20", VA = "0x18095D120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF420", Offset = "0x7ECE020", VA = "0x187ECF420")]
	public CEMJAPKLKJM(NJCENJCNKPK EAMKEHDGGKG, FKJLOEODNCO PBJHPBHJPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE050", Offset = "0x7ECCC50", VA = "0x187ECE050")]
	public void DDGOELONMEM(MKOEACODCBG DCALLBBPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE4D0", Offset = "0x7ECD0D0", VA = "0x187ECE4D0")]
	public void DMCFGOBPFLC(IList<MKOEACODCBG> OOJLKDIBJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE8F0", Offset = "0x7ECD4F0", VA = "0x187ECE8F0")]
	public void ILAJNKFKJAK(IList<MKOEACODCBG> OOJLKDIBJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF200", Offset = "0x7ECDE00", VA = "0x187ECF200")]
	private void LHFBPJNGPKK(MKOEACODCBG DCALLBBPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7ECDEC0", Offset = "0x7ECCAC0", VA = "0x187ECDEC0")]
	private void CICMGFDOBPP(IList<MKOEACODCBG> OOJLKDIBJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE160", Offset = "0x7ECCD60", VA = "0x187ECE160")]
	private JHGKCGCJLPM DEBEAHILPIA(MKOEACODCBG DCALLBBPNML)
	{
		return default(JHGKCGCJLPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF090", Offset = "0x7ECDC90", VA = "0x187ECF090")]
	public void KAFGFLAKMPI(float IIHDKBNFNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE2E0", Offset = "0x7ECCEE0", VA = "0x187ECE2E0")]
	public void DHPHHGBEOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7ECED30", Offset = "0x7ECD930", VA = "0x187ECED30")]
	private void JJAMOGGMGED(List<MKOEACODCBG> OOJLKDIBJMC, Stack<int> GAONBLHMCFL, bool LNOHBAIGJJD, float NCLJLCDGAEK = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE7D0", Offset = "0x7ECD3D0", VA = "0x187ECE7D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7ECEBF0", Offset = "0x7ECD7F0", VA = "0x187ECEBF0")]
	private void JBIFINMDMGI(List<MKOEACODCBG> OOJLKDIBJMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class JODENMOAFDC : FKJLOEODNCO
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "4")]
	public void DANLDOLAKEG(string BGKKCEGMOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
	public void IPIONGAPBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public JODENMOAFDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal class CCILLLEMDML : CIALCKNCBJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Behaviour DIFAGCOONAH;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string NMFKAOGOELC
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDB70", Offset = "0x7ECC770", VA = "0x187ECDB70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool ALCMCMGHEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDB20", Offset = "0x7ECC720", VA = "0x187ECDB20", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool LLNLEDEKFGB
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDB00", Offset = "0x7ECC700", VA = "0x187ECDB00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	public CCILLLEMDML(Behaviour DIFAGCOONAH)
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

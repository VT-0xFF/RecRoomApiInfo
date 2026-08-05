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
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C07090", Offset = "0x7C06290", VA = "0x187C07090", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C0FD20", Offset = "0x7C0EF20", VA = "0x187C0FD20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
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
		private delegate List<PlayerLoopSystem> FMBGICPKPJA(List<PlayerLoopSystem> LFPPFNBGENP, int ENADLONPONP);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct EMACGCHLPPP
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct JHOPMLGNJKD
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static AEJLNDNFINA OEDGFIFOEDI;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x7C01AA0", Offset = "0x7C00CA0", VA = "0x187C01AA0")]
				public static PlayerLoopSystem GPMICMLMGCG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct HLGBKGCOFPA
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static AEJLNDNFINA MPLEBNEOBDH;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x7BFFEE0", Offset = "0x7BFF0E0", VA = "0x187BFFEE0")]
				public static PlayerLoopSystem GPMICMLMGCG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct PGOJBIKBCCI
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static AEJLNDNFINA EPNFMOGLCIM;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x7C0E430", Offset = "0x7C0D630", VA = "0x187C0E430")]
				public static PlayerLoopSystem GPMICMLMGCG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct DEJDGMOCIPF
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static AEJLNDNFINA BJNNBAAOJOO;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static AEJLNDNFINA PFGMLCIHPEN;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static AEJLNDNFINA GIDEBKHGGBO;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static AEJLNDNFINA JGEDMFNDHFA;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x7BFA0B0", Offset = "0x7BF92B0", VA = "0x187BFA0B0")]
				public static PlayerLoopSystem GPMICMLMGCG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct JCPPDOJKKEJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static AEJLNDNFINA BMNPNLPLJHM;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x7C018A0", Offset = "0x7C00AA0", VA = "0x187C018A0")]
				public static PlayerLoopSystem GPMICMLMGCG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct FGOPOKOBMDD
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static AEJLNDNFINA BJNNBAAOJOO;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static AEJLNDNFINA PFGMLCIHPEN;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static AEJLNDNFINA GIDEBKHGGBO;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static AEJLNDNFINA JGEDMFNDHFA;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x7BFCB30", Offset = "0x7BFBD30", VA = "0x187BFCB30")]
				public static PlayerLoopSystem GPMICMLMGCG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct LNFCHHHEAGB
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static AEJLNDNFINA FPDAFGHBNFK;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x7C06E90", Offset = "0x7C06090", VA = "0x187C06E90")]
				public static PlayerLoopSystem GPMICMLMGCG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct KKAMBAJIMAG
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static AEJLNDNFINA JKHJOCCMMGG;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7C06340", Offset = "0x7C05540", VA = "0x187C06340")]
				public static PlayerLoopSystem GPMICMLMGCG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct DGLCHNKOCKN
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static AEJLNDNFINA NNDLGIFIJLK;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x7BFA3A0", Offset = "0x7BF95A0", VA = "0x187BFA3A0")]
				public static PlayerLoopSystem GPMICMLMGCG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct KJCKCOPKIMM
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static AEJLNDNFINA PEMGIGMEHKM;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x7C06140", Offset = "0x7C05340", VA = "0x187C06140")]
				public static PlayerLoopSystem GPMICMLMGCG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct AKPNGNGBJDD
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static AEJLNDNFINA OOGAOADIJBP;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x7BF2D10", Offset = "0x7BF1F10", VA = "0x187BF2D10")]
				public static PlayerLoopSystem GPMICMLMGCG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct AKFFOAJAOCI
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static AEJLNDNFINA HEGHNIOLAEA;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x7BF2B10", Offset = "0x7BF1D10", VA = "0x187BF2B10")]
				public static PlayerLoopSystem GPMICMLMGCG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct HMOOHFHCOLE
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static AEJLNDNFINA LDFGPJPINGH;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x7C000E0", Offset = "0x7BFF2E0", VA = "0x187C000E0")]
				public static PlayerLoopSystem GPMICMLMGCG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct IMKJBJBGONC
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static AEJLNDNFINA PJFAFNMFEPC;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x7C012C0", Offset = "0x7C004C0", VA = "0x187C012C0")]
				public static PlayerLoopSystem GPMICMLMGCG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct JICIMPKAIMK
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static AEJLNDNFINA IHOPPJFFPNO;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x7C01CA0", Offset = "0x7C00EA0", VA = "0x187C01CA0")]
				public static PlayerLoopSystem GPMICMLMGCG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum IDMKEHCMGJI : byte
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
			public struct DMIMLABEBGN
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class HKMOLHLIHHG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public IDMKEHCMGJI updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
					public HKMOLHLIHHG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x7BFFDA0", Offset = "0x7BFEFA0", VA = "0x187BFFDA0")]
					internal void HKADDBALOIP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static DBOBDIFJBBN<IDMKEHCMGJI> HGHNMCEBCAP;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x7BFA5A0", Offset = "0x7BF97A0", VA = "0x187BFA5A0")]
				public static PlayerLoopSystem GPMICMLMGCG(IDMKEHCMGJI ACDLNODICIB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct OHBCDFBCNFB
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class CNPCFNJJPCF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public BFLILIJMPDC.AAEPJIGEHAE key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
					public CNPCFNJJPCF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x7BF5920", Offset = "0x7BF4B20", VA = "0x187BF5920")]
					internal void GAKDNMEBGLL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable JDABANPKEIE;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A3E0", Offset = "0x7C095E0", VA = "0x187C0A3E0")]
				public static PlayerLoopSystem FANEFONEKCM(BFLILIJMPDC.AAEPJIGEHAE OFPBICPHALF)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct OMMCBIJOPKM
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class NAADGMIHAKG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public BFLILIJMPDC.AAEPJIGEHAE key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
					public NAADGMIHAKG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x7C07E80", Offset = "0x7C07080", VA = "0x187C07E80")]
					internal void GAKDNMEBGLL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7C0B590", Offset = "0x7C0A790", VA = "0x187C0B590")]
				public static PlayerLoopSystem FANEFONEKCM(BFLILIJMPDC.AAEPJIGEHAE OFPBICPHALF)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class EBCNFMKGOIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public EBCNFMKGOIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7BFAC00", Offset = "0x7BF9E00", VA = "0x187BFAC00")]
			internal List<PlayerLoopSystem> OGFLAONNHPD(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool ECLBKLFCOHO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool KLIGFGFCIBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7BF9E90", Offset = "0x7BF9090", VA = "0x187BF9E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5BA0", Offset = "0x7BF4DA0", VA = "0x187BF5BA0")]
		private static void CFBEOMKBHCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9290", Offset = "0x7BF8490", VA = "0x187BF9290")]
		private static void JBFCNCMIFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5B60", Offset = "0x7BF4D60", VA = "0x187BF5B60")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9040", Offset = "0x7BF8240", VA = "0x187BF9040")]
		private static void JABANHDDMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9CD0", Offset = "0x7BF8ED0", VA = "0x187BF9CD0")]
		private static void NGGMNBNMMIG(BFLILIJMPDC.AAEPJIGEHAE OFPBICPHALF, PlayerLoopSystem AFIKAAKAHNG, Type HLNEKJGHHLB, Type DAKHKGEMGLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8C60", Offset = "0x7BF7E60", VA = "0x187BF8C60")]
		private static void DLMIIDJELEI(PlayerLoopSystem AFIKAAKAHNG, Type HLNEKJGHHLB, Type DAKHKGEMGLO, FMBGICPKPJA NNAFBNFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9BA0", Offset = "0x7BF8DA0", VA = "0x187BF9BA0")]
		private static void JMJJHLACHAB(PlayerLoopSystem AFIKAAKAHNG, Type HLNEKJGHHLB, Type DAKHKGEMGLO, PlayerLoopSystem? ECJPNHBLFME, PlayerLoopSystem? GBBKCKNKHMD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class BFLILIJMPDC
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum AAEPJIGEHAE
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
	public class GKINFAMCPDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly AAEPJIGEHAE JPNHMPCINHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly HIHBEPMAKMI GCFIKLGHMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long EEBAFEHMMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long PALFOKOCMKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long ODNOGOECLMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int NADIBDEGIFK;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEE80", Offset = "0x7BFE080", VA = "0x187BFEE80")]
		public GKINFAMCPDM(AAEPJIGEHAE AEPLOKAIECK, int IKCCAGJNJOL = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7BFED80", Offset = "0x7BFDF80", VA = "0x187BFED80")]
		public void DOFDOCOGABD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7BFED30", Offset = "0x7BFDF30", VA = "0x187BFED30")]
		public void BNIGIPHMNDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEDA0", Offset = "0x7BFDFA0", VA = "0x187BFEDA0")]
		public void GGGACMCHCFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static AAEPJIGEHAE[] DHHCBGAAPMH;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static GKINFAMCPDM[] CNPNGNOIKKD;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4480", Offset = "0x7BF3680", VA = "0x187BF4480")]
	public static GKINFAMCPDM OINBMNEDIGD(AAEPJIGEHAE OFPBICPHALF, int IKCCAGJNJOL = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4410", Offset = "0x7BF3610", VA = "0x187BF4410")]
	public static GKINFAMCPDM MMNPBILNAFJ(AAEPJIGEHAE OFPBICPHALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4360", Offset = "0x7BF3560", VA = "0x187BF4360")]
	public static void ELLFOIABPCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KGKLFNDGDJN
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private interface OGOJIGANEOK
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool NEDAFEGACKC
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DDGALHILICL();
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class DMCLMGLIOEK : OGOJIGANEOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action KOMGLJOLBFC;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool NEDAFEGACKC
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
		public DMCLMGLIOEK(Action KOMGLJOLBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xF43330", Offset = "0xF42530", VA = "0x180F43330", Slot = "5")]
		public void DDGALHILICL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<OGOJIGANEOK> MFLDBELHAGN;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C03620", Offset = "0x7C02820", VA = "0x187C03620")]
	public static void LOHLBDMHGPP(Action KOMGLJOLBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C03400", Offset = "0x7C02600", VA = "0x187C03400")]
	private static void LOCHPDCDHHF(OGOJIGANEOK NBLKPLAAJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C03100", Offset = "0x7C02300", VA = "0x187C03100")]
	private static void JMBGMPGIGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C02F20", Offset = "0x7C02120", VA = "0x187C02F20")]
	private static void ELIPOODNBCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C03020", Offset = "0x7C02220", VA = "0x187C03020")]
	private static void JHPBAIOKPNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class NFACGIOMIDH
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct AMDEOMEDPAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TaskCompletionSource<Scene> LMKFNPGPCEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly string OIECDHAKEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly LoadSceneMode DCCBBNHNFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly bool DAFCHLLMHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2F10", Offset = "0x7BF2110", VA = "0x187BF2F10")]
		public AMDEOMEDPAL(TaskCompletionSource<Scene> KMMCBIMAJCM, string OIECDHAKEME, LoadSceneMode DCCBBNHNFBN, bool DAFCHLLMHEM, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct IGFJOOBBJPJ : IAsyncStateMachine
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
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private EKKGOIIBGNN<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7C00450", Offset = "0x7BFF650", VA = "0x187C00450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7C00CF0", Offset = "0x7BFFEF0", VA = "0x187C00CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct APCIJHLGNCJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF30F0", Offset = "0x7BF22F0", VA = "0x187BF30F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3410", Offset = "0x7BF2610", VA = "0x187BF3410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct JPECPPFJGGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private AMDEOMEDPAL <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7C022C0", Offset = "0x7C014C0", VA = "0x187C022C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7C02680", Offset = "0x7C01880", VA = "0x187C02680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class CEEIIJIKJIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public ONKLLOPAHFE<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CEEIIJIKJIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5190", Offset = "0x7BF4390", VA = "0x187BF5190")]
		internal void KEANKLMJPOL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MAGJNMDLPAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

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
		private CEEIIJIKJIO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C07120", Offset = "0x7C06320", VA = "0x187C07120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C07CD0", Offset = "0x7C06ED0", VA = "0x187C07CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct KGBPJNOGDCB : IAsyncStateMachine
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
		private OODALMMDODD <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C027F0", Offset = "0x7C019F0", VA = "0x187C027F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C02EB0", Offset = "0x7C020B0", VA = "0x187C02EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct AHGFFKANFCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1F80", Offset = "0x7BF1180", VA = "0x187BF1F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2AA0", Offset = "0x7BF1CA0", VA = "0x187BF2AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class FEGNCGHHHDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FEGNCGHHHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCB00", Offset = "0x7BFBD00", VA = "0x187BFCB00")]
		internal bool NIJPMGIJPMP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class KPIODIELIBM : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public LIKAJDLHHFB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public KPIODIELIBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C06920", Offset = "0x7C05B20", VA = "0x187C06920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C06590", Offset = "0x7C05790", VA = "0x187C06590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C06540", Offset = "0x7C05740", VA = "0x187C06540")]
		private void MHLANDJELDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C068D0", Offset = "0x7C05AD0", VA = "0x187C068D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class DOOMCELDODF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public ONKLLOPAHFE<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public DOOMCELDODF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA900", Offset = "0x7BF9B00", VA = "0x187BFA900")]
		internal bool AABKPINNOAE(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA980", Offset = "0x7BF9B80", VA = "0x187BFA980")]
		internal void PNOGBEBMIAL(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class OKFBBIEDOCF : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public ONKLLOPAHFE<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private DOOMCELDODF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private OODALMMDODD <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public OKFBBIEDOCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C0AE90", Offset = "0x7C0A090", VA = "0x187C0AE90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A530", Offset = "0x7C09730", VA = "0x187C0A530", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A510", Offset = "0x7C09710", VA = "0x187C0A510")]
		private void MHLANDJELDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C0AE40", Offset = "0x7C0A040", VA = "0x187C0AE40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ICollection<string> JBJGKKGOAOG;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static JABNAOPJDOK LCBAAEJDMKA;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AsyncOperation HGDIMPGCPIJ;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static JABNAOPJDOK GCBJCGDBMOM;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static string JGBHKPBMMBD;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string AFFDCGLOMEO;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority MBMDNEHHMDC;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task PINNGFJANKL;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static List<SceneInstance> LDFNNFMHIFF;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly Queue<AMDEOMEDPAL> DNCMMEGLLIC;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static Task JNHBEHGIBBL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool OGIJOHNHHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7C08570", Offset = "0x7C07770", VA = "0x187C08570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private static bool LDIFMAGMJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C094C0", Offset = "0x7C086C0", VA = "0x187C094C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private static bool FDDAFAGAIAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C08C50", Offset = "0x7C07E50", VA = "0x187C08C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private static bool HBFAIEECFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C08B30", Offset = "0x7C07D30", VA = "0x187C08B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> CCJLCIMKKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7C09280", Offset = "0x7C08480", VA = "0x187C09280")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7C09560", Offset = "0x7C08760", VA = "0x187C09560")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C08790", Offset = "0x7C07990", VA = "0x187C08790")]
	[LOLMJPDMJLG(PGKACFNAKFK.EnteredEditModeNextFrame, 0)]
	private static void GGADFLELCHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7C09940", Offset = "0x7C08B40", VA = "0x187C09940")]
	[AsyncStateMachine(typeof(IGFJOOBBJPJ))]
	public static Task<Scene> PMGAMBLKAJK(string OIECDHAKEME, LoadSceneMode DCCBBNHNFBN = LoadSceneMode.Single, bool DAFCHLLMHEM = false, [Optional] EKKGOIIBGNN<string>.KJLMKGNBAOG AINOLMOHIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7C081B0", Offset = "0x7C073B0", VA = "0x187C081B0")]
	[AsyncStateMachine(typeof(APCIJHLGNCJ))]
	private static Task ANPLJHBJCOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7C08390", Offset = "0x7C07590", VA = "0x187C08390")]
	[AsyncStateMachine(typeof(JPECPPFJGGF))]
	private static Task EKBJOEAOGHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7C08FB0", Offset = "0x7C081B0", VA = "0x187C08FB0")]
	[AsyncStateMachine(typeof(MAGJNMDLPAI))]
	private static Task<Scene> KOLENLBGIMN(string OIECDHAKEME, LoadSceneMode DCCBBNHNFBN, bool DAFCHLLMHEM, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7C08980", Offset = "0x7C07B80", VA = "0x187C08980")]
	private static void GOMMHDLDKDF(SceneInstance IEFGENALBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7C08CF0", Offset = "0x7C07EF0", VA = "0x187C08CF0")]
	private static void KIAKAGLAOOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7C08260", Offset = "0x7C07460", VA = "0x187C08260")]
	[AsyncStateMachine(typeof(KGBPJNOGDCB))]
	private static Task<Scene> CAAGIJIFJDM(string OIECDHAKEME, LoadSceneMode DCCBBNHNFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7C08890", Offset = "0x7C07A90", VA = "0x187C08890")]
	private static bool GNABAIBDJBI(string OIECDHAKEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7C08460", Offset = "0x7C07660", VA = "0x187C08460")]
	[AsyncStateMachine(typeof(AHGFFKANFCE))]
	private static Task<Scene> ENJLLLBCLAP(EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7C09100", Offset = "0x7C08300", VA = "0x187C09100")]
	public static OABBPFFKNOC<Scene> LDBMMKDIMGC(string OIECDHAKEME, LoadSceneMode DCCBBNHNFBN = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7C09670", Offset = "0x7C08870", VA = "0x187C09670")]
	public static JABNAOPJDOK PLKONICGPAM(string OIECDHAKEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7C08BC0", Offset = "0x7C07DC0", VA = "0x187C08BC0")]
	[IteratorStateMachine(typeof(KPIODIELIBM))]
	private static IEnumerator<IOBGCLDPPJE> JKIAGKOONKB(string OIECDHAKEME, LIKAJDLHHFB NKHLPHFDDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7C08A90", Offset = "0x7C07C90", VA = "0x187C08A90")]
	[IteratorStateMachine(typeof(OKFBBIEDOCF))]
	private static IEnumerator<IOBGCLDPPJE> JDPCBNDDNND(string OIECDHAKEME, LoadSceneMode DCCBBNHNFBN, ONKLLOPAHFE<Scene> NKHLPHFDDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7C09390", Offset = "0x7C08590", VA = "0x187C09390")]
	public static bool ODPOMPJFJAN([Out] string NNPKAFBOCGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DNGGOMDBDPC
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7BFA770", Offset = "0x7BF9970", VA = "0x187BFA770")]
	public static IDisposable EBIBEOEFCHP(this ANFPAPNNIFP GCGNIOHLIKK, float BJFHMPICGDF, Action<float> KFAFFMDDJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7BFA880", Offset = "0x7BF9A80", VA = "0x187BFA880")]
	public static IDisposable FFFKJBDMNBD(this ANFPAPNNIFP GCGNIOHLIKK, Action<float> KFAFFMDDJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7BFA800", Offset = "0x7BF9A00", VA = "0x187BFA800")]
	public static IDisposable EPDLELKNPBB(this ANFPAPNNIFP GCGNIOHLIKK, Action<float> KFAFFMDDJPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class DAPJHKPJCCA
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x30EB7B0", Offset = "0x30EA9B0", VA = "0x1830EB7B0")]
	[HBDNNHBMFPN]
	public static IDisposable KJDLDGGDIPA<T>(this T GMGJNFEBMOH, Action KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x30EB950", Offset = "0x30EAB50", VA = "0x1830EB950")]
	[HBDNNHBMFPN]
	public static IDisposable KJDLDGGDIPA<T>(this T GMGJNFEBMOH, Action<float> KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x30EBC10", Offset = "0x30EAE10", VA = "0x1830EBC10")]
	[HBDNNHBMFPN]
	public static IDisposable MEIPIBBEBLB<T>(this T GMGJNFEBMOH, Action KFAFFMDDJPL, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x30EB660", Offset = "0x30EA860", VA = "0x1830EB660")]
	[HBDNNHBMFPN]
	public static IDisposable GPHEIMLMIKC<T>(this T GMGJNFEBMOH, Action KFAFFMDDJPL, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x30EB660", Offset = "0x30EA860", VA = "0x1830EB660")]
	[HBDNNHBMFPN]
	public static IDisposable GPHEIMLMIKC<T>(this T GMGJNFEBMOH, Action<float> KFAFFMDDJPL, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x30EBB60", Offset = "0x30EAD60", VA = "0x1830EBB60")]
	[HBDNNHBMFPN]
	public static IDisposable LIKKBGEPPDC<T>(this T GMGJNFEBMOH, Action KFAFFMDDJPL, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x30EB710", Offset = "0x30EA910", VA = "0x1830EB710")]
	[HBDNNHBMFPN]
	public static IDisposable JCBCIPINGNB<T>(this T GMGJNFEBMOH, Action KFAFFMDDJPL, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x30EB760", Offset = "0x30EA960", VA = "0x1830EB760")]
	[HBDNNHBMFPN]
	public static IDisposable JEEGGILNHJE<T>(this T GMGJNFEBMOH, Action KFAFFMDDJPL, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x30EBC50", Offset = "0x30EAE50", VA = "0x1830EBC50")]
	[HBDNNHBMFPN]
	public static IDisposable MLAHOOCOJDO<T>(this T GMGJNFEBMOH, float BJFHMPICGDF, Action<float> KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7BF9ED0", Offset = "0x7BF90D0", VA = "0x187BF9ED0")]
	[HBDNNHBMFPN]
	public static IDisposable MLAHOOCOJDO(this MonoBehaviour GMGJNFEBMOH, ONOIHDMEOKA GCGNIOHLIKK, float BJFHMPICGDF, Action<float> KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x30EB3F0", Offset = "0x30EA5F0", VA = "0x1830EB3F0")]
	[HBDNNHBMFPN]
	public static IDisposable EAPDKPNAKJI<T>(this T GMGJNFEBMOH, float BJFHMPICGDF, Action<float> KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x30EBD50", Offset = "0x30EAF50", VA = "0x1830EBD50")]
	[HBDNNHBMFPN]
	public static IDisposable PDLIAPCHCHJ<T>(this T GMGJNFEBMOH, float BJFHMPICGDF, Action<float> KFAFFMDDJPL, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x30EBB00", Offset = "0x30EAD00", VA = "0x1830EBB00")]
	[HBDNNHBMFPN]
	public static IDisposable LHBNDACEHAF<T>(this T GMGJNFEBMOH, Action<float> KFAFFMDDJPL, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x30EB6B0", Offset = "0x30EA8B0", VA = "0x1830EB6B0")]
	[HBDNNHBMFPN]
	public static IDisposable INFBMKECDDM<T>(this T GMGJNFEBMOH, Action<float> KFAFFMDDJPL, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x30EBBB0", Offset = "0x30EADB0", VA = "0x1830EBBB0")]
	[HBDNNHBMFPN]
	public static IDisposable LMDOMAOAIIE<T>(this T GMGJNFEBMOH, Action<float> KFAFFMDDJPL, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x30EBDA0", Offset = "0x30EAFA0", VA = "0x1830EBDA0")]
	[HBDNNHBMFPN]
	public static IDisposable PFGLNLGOHGF<T>(this T GMGJNFEBMOH, Action<float> KFAFFMDDJPL, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x30EBCF0", Offset = "0x30EAEF0", VA = "0x1830EBCF0")]
	[HBDNNHBMFPN]
	public static IDisposable OJOOEDOKNHI<T>(this T GMGJNFEBMOH, Action<float> KFAFFMDDJPL, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x30EB600", Offset = "0x30EA800", VA = "0x1830EB600")]
	[HBDNNHBMFPN]
	public static IDisposable FNJPMGAOFBP<T>(this T GMGJNFEBMOH, Action<float> KFAFFMDDJPL, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x30EB5A0", Offset = "0x30EA7A0", VA = "0x1830EB5A0")]
	[HBDNNHBMFPN]
	public static IDisposable EBJKDLANKON<T>(this T GMGJNFEBMOH, Action<float> KFAFFMDDJPL, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x30EB340", Offset = "0x30EA540", VA = "0x1830EB340")]
	[HBDNNHBMFPN]
	public static IDisposable CJMMHLCHBIH<T>(this T GMGJNFEBMOH, float BJFHMPICGDF, Action<float> KFAFFMDDJPL, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x30EB390", Offset = "0x30EA590", VA = "0x1830EB390")]
	[HBDNNHBMFPN]
	public static IDisposable DOBEGADCCMG<T>(this T GMGJNFEBMOH, Action<float> KFAFFMDDJPL, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x30EBC90", Offset = "0x30EAE90", VA = "0x1830EBC90")]
	[HBDNNHBMFPN]
	public static IDisposable NONMOGIEOME<T>(this T GMGJNFEBMOH, Action<float> KFAFFMDDJPL, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true) where T : MonoBehaviour, ONOIHDMEOKA
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class JPBMGLIJHGG
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class OFIDKKNFIDC : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public MPFOEBMPEMA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private JBAPJHIPMOK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public OFIDKKNFIDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A2B0", Offset = "0x7C094B0", VA = "0x187C0A2B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A390", Offset = "0x7C09590", VA = "0x187C0A390", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class MGBLIELPPAL : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public MPFOEBMPEMA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private JBAPJHIPMOK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public MGBLIELPPAL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C07D40", Offset = "0x7C06F40", VA = "0x187C07D40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C07E30", Offset = "0x7C07030", VA = "0x187C07E30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7C02120", Offset = "0x7C01320", VA = "0x187C02120")]
	public static GFDHFLBBFKF KJDLDGGDIPA(Action KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7C01FB0", Offset = "0x7C011B0", VA = "0x187C01FB0")]
	public static GFDHFLBBFKF KJDLDGGDIPA(Behaviour GCGNIOHLIKK, Action KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7C02040", Offset = "0x7C01240", VA = "0x187C02040")]
	public static GFDHFLBBFKF KJDLDGGDIPA(Behaviour GCGNIOHLIKK, Action<float> KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7C02230", Offset = "0x7C01430", VA = "0x187C02230")]
	[IteratorStateMachine(typeof(OFIDKKNFIDC))]
	private static IEnumerator<IOBGCLDPPJE> OBCHOFKIIMJ(MPFOEBMPEMA EALKLACMEDA, Action KFAFFMDDJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C021A0", Offset = "0x7C013A0", VA = "0x187C021A0")]
	[IteratorStateMachine(typeof(MGBLIELPPAL))]
	private static IEnumerator<IOBGCLDPPJE> OBCHOFKIIMJ(MPFOEBMPEMA EALKLACMEDA, Action<float> KFAFFMDDJPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class HGAAJDOBLAF : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class FJKCACOIJAM : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public HGAAJDOBLAF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public FJKCACOIJAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCE20", Offset = "0x7BFC020", VA = "0x187BFCE20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCEB0", Offset = "0x7BFC0B0", VA = "0x187BFCEB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly MPFOEBMPEMA JFMEEDLHBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Action BNHNODFOCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool JMBNFCHPDPB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LIOPPBMFEAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0D0", Offset = "0x8FA2D0", VA = "0x1808FB0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFC10", Offset = "0x7BFEE10", VA = "0x187BFFC10")]
	public HGAAJDOBLAF(MPFOEBMPEMA JFMEEDLHBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFAF0", Offset = "0x7BFECF0", VA = "0x187BFFAF0")]
	[IteratorStateMachine(typeof(FJKCACOIJAM))]
	private IEnumerator<IOBGCLDPPJE> MIFHMMNLALC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFB70", Offset = "0x7BFED70", VA = "0x187BFFB70", Slot = "4")]
	public void OnCompleted(Action MDMNEIJBAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
	public void EMCHGKBAACI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class JLBPJCDHGFL
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7C01EA0", Offset = "0x7C010A0", VA = "0x187C01EA0")]
	public static HGAAJDOBLAF LGLANLJPMBI(this MPFOEBMPEMA JFMEEDLHBFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class CKFMBBAHLNM
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class CGCDMGEBPNH : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public MNHFCLLIAOE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public CGCDMGEBPNH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5300", Offset = "0x7BF4500", VA = "0x187BF5300", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5380", Offset = "0x7BF4580", VA = "0x187BF5380", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5530", Offset = "0x7BF4730", VA = "0x187BF5530")]
	public static GFDHFLBBFKF KJDLDGGDIPA(float BJFHMPICGDF, Action<float> KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN, bool HNHBNOBCCFI = true, [Optional] FJHAIGEICMN CHHAFMMADAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5460", Offset = "0x7BF4660", VA = "0x187BF5460")]
	public static GFDHFLBBFKF KJDLDGGDIPA(MonoBehaviour GMGJNFEBMOH, float BJFHMPICGDF, Action<float> KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN, bool HNHBNOBCCFI = true, [Optional] FJHAIGEICMN CHHAFMMADAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5730", Offset = "0x7BF4930", VA = "0x187BF5730")]
	public static GFDHFLBBFKF NPNPLBDPAIM(MonoBehaviour GMGJNFEBMOH, float BJFHMPICGDF, Action<float> KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN, bool HNHBNOBCCFI = true, [Optional] FJHAIGEICMN CHHAFMMADAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5660", Offset = "0x7BF4860", VA = "0x187BF5660")]
	public static GFDHFLBBFKF NHKKABHNGLJ(ANFPAPNNIFP GCGNIOHLIKK, float BJFHMPICGDF, Action<float> KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN, bool HNHBNOBCCFI = true, [Optional] FJHAIGEICMN CHHAFMMADAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5820", Offset = "0x7BF4A20", VA = "0x187BF5820")]
	private static IEnumerator<IOBGCLDPPJE> OBCHOFKIIMJ(PFOEODMEJLH HALDMJNCLIM, float BJFHMPICGDF, MPFOEBMPEMA EALKLACMEDA, Action<float> KFAFFMDDJPL, bool HNHBNOBCCFI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5600", Offset = "0x7BF4800", VA = "0x187BF5600")]
	private static IEnumerator<IOBGCLDPPJE> MJKDJALDKHI(PFOEODMEJLH HALDMJNCLIM, float BJFHMPICGDF, MPFOEBMPEMA EALKLACMEDA, Action<float> KFAFFMDDJPL, bool HNHBNOBCCFI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7BF53D0", Offset = "0x7BF45D0", VA = "0x187BF53D0")]
	[IteratorStateMachine(typeof(CGCDMGEBPNH))]
	private static IEnumerator<IOBGCLDPPJE> INKGABFFCBL(MNHFCLLIAOE MLDPMLDLIEN, float BJFHMPICGDF, MPFOEBMPEMA EALKLACMEDA, Action<float> KFAFFMDDJPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class IBIGAFDNKHN
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class CFNHLFFPNBD : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public MPFOEBMPEMA queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public CFNHLFFPNBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7BF51F0", Offset = "0x7BF43F0", VA = "0x187BF51F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7BF52B0", Offset = "0x7BF44B0", VA = "0x187BF52B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C002E0", Offset = "0x7BFF4E0", VA = "0x187C002E0")]
	[IteratorStateMachine(typeof(CFNHLFFPNBD))]
	private static IEnumerator<IOBGCLDPPJE> GFIEHOFPJJB(MPFOEBMPEMA JFMEEDLHBFN, Func<bool> PBMHCOIDBNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C00370", Offset = "0x7BFF570", VA = "0x187C00370")]
	public static GFDHFLBBFKF KEFDDEBJGEK(this MonoBehaviour GMGJNFEBMOH, Func<bool> PBMHCOIDBNB, MPFOEBMPEMA JFMEEDLHBFN = MPFOEBMPEMA.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class PFMHLJGDKJD
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class HLCKGEMOJMH : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public MPFOEBMPEMA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public HLCKGEMOJMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7BFFE20", Offset = "0x7BFF020", VA = "0x187BFFE20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7BFFE90", Offset = "0x7BFF090", VA = "0x187BFFE90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class DIGFNOFKKFL<T> : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public MPFOEBMPEMA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public DIGFNOFKKFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6077700", Offset = "0x6076900", VA = "0x186077700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x60777A0", Offset = "0x60769A0", VA = "0x1860777A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class NLOMJKBMNMC : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public MPFOEBMPEMA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private IOBGCLDPPJE <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public NLOMJKBMNMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A190", Offset = "0x7C09390", VA = "0x187C0A190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A220", Offset = "0x7C09420", VA = "0x187C0A220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E2F0", Offset = "0x7C0D4F0", VA = "0x187C0E2F0")]
	[IteratorStateMachine(typeof(HLCKGEMOJMH))]
	private static IEnumerator<IOBGCLDPPJE> MIFHMMNLALC(float KIPBHBAMJHE, MPFOEBMPEMA EALKLACMEDA, Action LGBMMKDPNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3469930", Offset = "0x3468B30", VA = "0x183469930")]
	[IteratorStateMachine(typeof(DIGFNOFKKFL<>))]
	private static IEnumerator<IOBGCLDPPJE> MIFHMMNLALC<T>(float KIPBHBAMJHE, MPFOEBMPEMA EALKLACMEDA, Action<T> LGBMMKDPNBN, T CJJMPIPLCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DA60", Offset = "0x7C0CC60", VA = "0x187C0DA60")]
	[IteratorStateMachine(typeof(NLOMJKBMNMC))]
	private static IEnumerator<IOBGCLDPPJE> AIDEBNINNCN(float KIPBHBAMJHE, MPFOEBMPEMA EALKLACMEDA, Action LGBMMKDPNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DC90", Offset = "0x7C0CE90", VA = "0x187C0DC90")]
	public static IDisposable FBEGEGGFJIO(this MonoBehaviour GMGJNFEBMOH, float KIPBHBAMJHE, Action LGBMMKDPNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DD70", Offset = "0x7C0CF70", VA = "0x187C0DD70")]
	public static GFDHFLBBFKF FLIMCLNJNJK(this MonoBehaviour GMGJNFEBMOH, float KIPBHBAMJHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DBA0", Offset = "0x7C0CDA0", VA = "0x187C0DBA0")]
	public static GFDHFLBBFKF FBEGEGGFJIO(this MonoBehaviour GMGJNFEBMOH, float KIPBHBAMJHE, MPFOEBMPEMA EALKLACMEDA, Action LGBMMKDPNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DE00", Offset = "0x7C0D000", VA = "0x187C0DE00")]
	public static GFDHFLBBFKF FNDLJLNDBOM(this MonoBehaviour GMGJNFEBMOH, Action LGBMMKDPNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x34697A0", Offset = "0x34689A0", VA = "0x1834697A0")]
	public static GFDHFLBBFKF FNDLJLNDBOM<T>(this MonoBehaviour GMGJNFEBMOH, Action<T> LGBMMKDPNBN, T CJJMPIPLCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E1C0", Offset = "0x7C0D3C0", VA = "0x187C0E1C0")]
	public static GFDHFLBBFKF LBNFOJIKCBO(this MonoBehaviour GMGJNFEBMOH, Action LGBMMKDPNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DEA0", Offset = "0x7C0D0A0", VA = "0x187C0DEA0")]
	public static GFDHFLBBFKF HFMPHEBHAOK(this MonoBehaviour GMGJNFEBMOH, Action LGBMMKDPNBN, [Optional] FJHAIGEICMN CHHAFMMADAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DB00", Offset = "0x7C0CD00", VA = "0x187C0DB00")]
	public static GFDHFLBBFKF DDCLLIBJNIB(this MonoBehaviour GMGJNFEBMOH, Action LGBMMKDPNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DFE0", Offset = "0x7C0D1E0", VA = "0x187C0DFE0")]
	public static GFDHFLBBFKF IPGNDDPIOPP(this MonoBehaviour GMGJNFEBMOH, Action LGBMMKDPNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E080", Offset = "0x7C0D280", VA = "0x187C0E080")]
	public static GFDHFLBBFKF KILACDOBKFI(MonoBehaviour GMGJNFEBMOH, MPFOEBMPEMA JFMEEDLHBFN, Action LGBMMKDPNBN, [Optional] FJHAIGEICMN CHHAFMMADAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x34697F0", Offset = "0x34689F0", VA = "0x1834697F0")]
	public static GFDHFLBBFKF KILACDOBKFI<T>(MonoBehaviour GMGJNFEBMOH, MPFOEBMPEMA JFMEEDLHBFN, Action<T> LGBMMKDPNBN, T CJJMPIPLCIJ, [Optional] FJHAIGEICMN CHHAFMMADAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E260", Offset = "0x7C0D460", VA = "0x187C0E260")]
	public static GFDHFLBBFKF LOFNGKKJJJI(this MonoBehaviour GMGJNFEBMOH, float CDAKACDALJH, Action LGBMMKDPNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DF40", Offset = "0x7C0D140", VA = "0x187C0DF40")]
	public static GFDHFLBBFKF IAPDAABGJFM(this MonoBehaviour GMGJNFEBMOH, float CDAKACDALJH, Action LGBMMKDPNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E120", Offset = "0x7C0D320", VA = "0x187C0E120")]
	public static GFDHFLBBFKF KLGFDJGGNNP(this MonoBehaviour GMGJNFEBMOH, float CDAKACDALJH, Action LGBMMKDPNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E390", Offset = "0x7C0D590", VA = "0x187C0E390")]
	public static GFDHFLBBFKF OFIPOJHOCOO(this MonoBehaviour GMGJNFEBMOH, float CDAKACDALJH, Action LGBMMKDPNBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class EFALEIKJMCN : PNCMHJOGIEA, IEnumerable<PNCMHJOGIEA>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly List<PNCMHJOGIEA> JPEHNMFNFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool AKLJHPAEBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Action FAJEDJEHJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool MHDBOIAOBBD;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool GMINEHEEGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB170", Offset = "0x7BFA370", VA = "0x187BFB170", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NAEJNEEMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB050", Offset = "0x7BFA250", VA = "0x187BFB050", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7BFAFB0", Offset = "0x7BFA1B0", VA = "0x187BFAFB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB5D0", Offset = "0x7BFA7D0", VA = "0x187BFB5D0")]
	public EFALEIKJMCN([Optional] Action FAJEDJEHJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7BFAE80", Offset = "0x7BFA080", VA = "0x187BFAE80")]
	public void CKLHJOINNOK(PNCMHJOGIEA IKGANNCJCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7BFAD20", Offset = "0x7BF9F20", VA = "0x187BFAD20")]
	private void AMGGIOOKLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB5C0", Offset = "0x7BFA7C0", VA = "0x187BFB5C0", Slot = "7")]
	public bool MLDDGFMJJLN(bool DCOODACAFGM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB2B0", Offset = "0x7BFA4B0", VA = "0x187BFB2B0", Slot = "8")]
	public bool MLDDGFMJJLN(Action KOMGLJOLBFC, bool DCOODACAFGM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB0F0", Offset = "0x7BFA2F0", VA = "0x187BFB0F0", Slot = "9")]
	public IEnumerator<PNCMHJOGIEA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB0F0", Offset = "0x7BFA2F0", VA = "0x187BFB0F0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class ONMFPFOCEKC : BCCBJGKHKBG
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class FIGMPKPLLLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public ONMFPFOCEKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FIGMPKPLLLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4330", Offset = "0x7BF3530", VA = "0x187BF4330")]
		internal void KMBLHBMCGDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class BFJABMNMCLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public ONMFPFOCEKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BFJABMNMCLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4330", Offset = "0x7BF3530", VA = "0x187BF4330")]
		internal void CLHBNAIPKKP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly float MKAODHMDHFA;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7BF2FB0", Offset = "0x7BF21B0", VA = "0x187BF2FB0")]
	public ONMFPFOCEKC(Behaviour GCGNIOHLIKK, float MKAODHMDHFA, [Optional] Action FAJEDJEHJMC, [Optional] FJHAIGEICMN CHHAFMMADAN, [Optional] PFOEODMEJLH HALDMJNCLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7C0B6C0", Offset = "0x7C0A8C0", VA = "0x187C0B6C0", Slot = "9")]
	protected override bool GODCBJGPADD(Action KOMGLJOLBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7C0B7D0", Offset = "0x7C0A9D0", VA = "0x187C0B7D0", Slot = "10")]
	protected override bool IPOJCGEJKFI(Action KOMGLJOLBFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface PNCMHJOGIEA
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool GMINEHEEGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NAEJNEEMMFO;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MLDDGFMJJLN(bool DCOODACAFGM = false);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MLDDGFMJJLN(Action KOMGLJOLBFC, bool DCOODACAFGM = false);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class BCCBJGKHKBG : PNCMHJOGIEA
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class OPCMCIMPDDJ : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public BCCBJGKHKBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public OPCMCIMPDDJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B8E0", Offset = "0x7C0AAE0", VA = "0x187C0B8E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B9B0", Offset = "0x7C0ABB0", VA = "0x187C0B9B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Behaviour GCGNIOHLIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Action FAJEDJEHJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private FMIMELHPEBJ AHIJOHLFHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly FJHAIGEICMN CHHAFMMADAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	protected readonly PFOEODMEJLH HALDMJNCLIM;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GMINEHEEGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1507340", Offset = "0x1506540", VA = "0x181507340", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NAEJNEEMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3D20", Offset = "0x7BF2F20", VA = "0x187BF3D20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3C80", Offset = "0x7BF2E80", VA = "0x187BF3C80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4200", Offset = "0x7BF3400", VA = "0x187BF4200")]
	protected BCCBJGKHKBG(Behaviour GCGNIOHLIKK, [Optional] Action FAJEDJEHJMC, [Optional] FJHAIGEICMN CHHAFMMADAN, [Optional] PFOEODMEJLH HALDMJNCLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3F50", Offset = "0x7BF3150", VA = "0x187BF3F50", Slot = "7")]
	public bool MLDDGFMJJLN(bool DCOODACAFGM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3EF0", Offset = "0x7BF30F0", VA = "0x187BF3EF0", Slot = "8")]
	public bool MLDDGFMJJLN(Action KOMGLJOLBFC, bool DCOODACAFGM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool GODCBJGPADD(Action KOMGLJOLBFC);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool IPOJCGEJKFI(Action KOMGLJOLBFC);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3E40", Offset = "0x7BF3040", VA = "0x187BF3E40")]
	protected void FLEGJIOMHNG(Action KOMGLJOLBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3FB0", Offset = "0x7BF31B0", VA = "0x187BF3FB0")]
	protected JABNAOPJDOK PMFGPDDHHMB(float NHFPPHNGOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3DC0", Offset = "0x7BF2FC0", VA = "0x187BF3DC0")]
	private void FJKKGLIAEGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3E60", Offset = "0x7BF3060", VA = "0x187BF3E60")]
	[IteratorStateMachine(typeof(OPCMCIMPDDJ))]
	private IEnumerator<IOBGCLDPPJE> LNNMKEIJEND(float NHFPPHNGOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3C40", Offset = "0x7BF2E40", VA = "0x187BF3C40")]
	[CompilerGenerated]
	private void BHLFPDAHBFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class PODMEBHOLAB : BCCBJGKHKBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float FBNEFHDHIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly int IIIDGLMKDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float KBEFOECNEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly float[] FBICJNJNIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private int HFNCBFMMBME;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E8B0", Offset = "0x7C0DAB0", VA = "0x187C0E8B0")]
	public PODMEBHOLAB(Behaviour GCGNIOHLIKK, float HDJOKOANOPP, int IIIDGLMKDMK, [Optional] Action FAJEDJEHJMC, float KBEFOECNEAC = 0f, [Optional] FJHAIGEICMN CHHAFMMADAN, [Optional] PFOEODMEJLH HALDMJNCLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "9")]
	protected override bool GODCBJGPADD(Action KOMGLJOLBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E6B0", Offset = "0x7C0D8B0", VA = "0x187C0E6B0", Slot = "10")]
	protected override bool IPOJCGEJKFI(Action KOMGLJOLBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E630", Offset = "0x7C0D830", VA = "0x187C0E630")]
	private void DCDHDIGCELP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class AMPEGLOHAJA : BCCBJGKHKBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly float MKAODHMDHFA;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF2FB0", Offset = "0x7BF21B0", VA = "0x187BF2FB0")]
	public AMPEGLOHAJA(Behaviour GCGNIOHLIKK, float MKAODHMDHFA, [Optional] Action FAJEDJEHJMC, [Optional] FJHAIGEICMN CHHAFMMADAN, [Optional] PFOEODMEJLH HALDMJNCLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "9")]
	protected override bool GODCBJGPADD(Action KOMGLJOLBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF2F70", Offset = "0x7BF2170", VA = "0x187BF2F70", Slot = "10")]
	protected override bool IPOJCGEJKFI(Action KOMGLJOLBFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class OKIEFPNGBPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class HIEIFCBIPPM : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public HIEIFCBIPPM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7BFFCE0", Offset = "0x7BFEEE0", VA = "0x187BFFCE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7BFFD50", Offset = "0x7BFEF50", VA = "0x187BFFD50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private GFDHFLBBFKF JICCMKODPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private ANFPAPNNIFP GCGNIOHLIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Action<float> BBBPDABOCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private MPFOEBMPEMA JFMEEDLHBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private float LNIEHPMMBGB;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0B3F0", Offset = "0x7C0A5F0", VA = "0x187C0B3F0")]
	public OKIEFPNGBPI(ANFPAPNNIFP GCGNIOHLIKK, float BJFHMPICGDF, Action<float> KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7C0B100", Offset = "0x7C0A300", VA = "0x187C0B100")]
	private void KFGJGPFADMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7C0AFD0", Offset = "0x7C0A1D0", VA = "0x187C0AFD0")]
	private void EMCEJAFOGGE(string GILNIHGCEJO, Action JLCEDHMBKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7C0AEF0", Offset = "0x7C0A0F0", VA = "0x187C0AEF0")]
	[IteratorStateMachine(typeof(HIEIFCBIPPM))]
	private IEnumerator<IOBGCLDPPJE> BDCBOEBHPPJ(Action JLCEDHMBKJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7C0AF70", Offset = "0x7C0A170", VA = "0x187C0AF70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7C0B270", Offset = "0x7C0A470", VA = "0x187C0B270")]
	[CompilerGenerated]
	private void MPIHJNPMBDI(string BAFKJPEEDJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class FKCPKJBAICJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class POMFDOCPHMJ : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public POMFDOCPHMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7BFFCE0", Offset = "0x7BFEEE0", VA = "0x187BFFCE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0EA80", Offset = "0x7C0DC80", VA = "0x187C0EA80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private GFDHFLBBFKF JICCMKODPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private MonoBehaviour GMGJNFEBMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action KFAFFMDDJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private Action<float> BBBPDABOCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private MPFOEBMPEMA JFMEEDLHBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float LNIEHPMMBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool HNHBNOBCCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly FJHAIGEICMN CHHAFMMADAN;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7BFDEE0", Offset = "0x7BFD0E0", VA = "0x187BFDEE0")]
	public FKCPKJBAICJ(MonoBehaviour GMGJNFEBMOH, Action KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN, [Optional] FJHAIGEICMN CHHAFMMADAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7BFDB30", Offset = "0x7BFCD30", VA = "0x187BFDB30")]
	public FKCPKJBAICJ(MonoBehaviour GMGJNFEBMOH, Action<float> KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN, [Optional] FJHAIGEICMN CHHAFMMADAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7BFDD00", Offset = "0x7BFCF00", VA = "0x187BFDD00")]
	public FKCPKJBAICJ(MonoBehaviour GMGJNFEBMOH, float BJFHMPICGDF, Action<float> KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN, bool HNHBNOBCCFI = true, [Optional] FJHAIGEICMN CHHAFMMADAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4526B10", Offset = "0x4525D10", VA = "0x184526B10")]
	private FKCPKJBAICJ(FJHAIGEICMN CHHAFMMADAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD6F0", Offset = "0x7BFC8F0", VA = "0x187BFD6F0")]
	internal static FKCPKJBAICJ NIDFNLHGBCL(MonoBehaviour GMGJNFEBMOH, float BJFHMPICGDF, Action<float> KFAFFMDDJPL, MPFOEBMPEMA JFMEEDLHBFN, bool HNHBNOBCCFI = true, [Optional] FJHAIGEICMN CHHAFMMADAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD4A0", Offset = "0x7BFC6A0", VA = "0x187BFD4A0")]
	private void KJDLDGGDIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD9B0", Offset = "0x7BFCBB0", VA = "0x187BFD9B0")]
	private void OMKGBCKLGOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD330", Offset = "0x7BFC530", VA = "0x187BFD330")]
	private void KFGJGPFADMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7BFCF80", Offset = "0x7BFC180", VA = "0x187BFCF80")]
	private void CGGNAIMMOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD170", Offset = "0x7BFC370", VA = "0x187BFD170")]
	private void EMCEJAFOGGE(string GILNIHGCEJO, Action JLCEDHMBKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7BFCF00", Offset = "0x7BFC100", VA = "0x187BFCF00")]
	[IteratorStateMachine(typeof(POMFDOCPHMJ))]
	private IEnumerator<IOBGCLDPPJE> BDCBOEBHPPJ(Action JLCEDHMBKJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD110", Offset = "0x7BFC310", VA = "0x187BFD110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD920", Offset = "0x7BFCB20", VA = "0x187BFD920")]
	[CompilerGenerated]
	private void OFLNBMMICDL(string BAFKJPEEDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD2A0", Offset = "0x7BFC4A0", VA = "0x187BFD2A0")]
	[CompilerGenerated]
	private void JLJEDHMKHIL(string BAFKJPEEDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD5D0", Offset = "0x7BFC7D0", VA = "0x187BFD5D0")]
	[CompilerGenerated]
	private void NBOKJLNEMIM(string BAFKJPEEDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD660", Offset = "0x7BFC860", VA = "0x187BFD660")]
	[CompilerGenerated]
	private void NCCLKLNNKHL(string BAFKJPEEDJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Flags]
internal enum PDAIOHPPPOF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal sealed class NEAPEHHENHP : PFOEODMEJLH
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float OJKGGFPJAGB
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7C08170", Offset = "0x7C07370", VA = "0x187C08170", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float PPNBKFCKDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7C08180", Offset = "0x7C07380", VA = "0x187C08180", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public double JJNPDNNCLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7C08190", Offset = "0x7C07390", VA = "0x187C08190", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7C08100", Offset = "0x7C07300", VA = "0x187C08100")]
	[NAOGKPPNIGE.PBOHCEMILCE]
	internal static void EMFHCKBHCPB(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	[UnityEngine.Scripting.Preserve]
	internal NEAPEHHENHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface EBLBMEFBNLA
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNGNJMNFLCF(string LMOANCJLHKC);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHDJPGLDMBD();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal interface NLOJEGMHIHD
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string PCMLNMEPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool CCBACAJLKLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool ONMKEEDCDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal class NLNDJLMNFJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public KHNOGLPPENN PNMPCAOOLLP;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int JDABKJNJMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8F21A0", Offset = "0x8F13A0", VA = "0x1808F21A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8FEBC0", Offset = "0x8FDDC0", VA = "0x1808FEBC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7C09F70", Offset = "0x7C09170", VA = "0x187C09F70")]
	public static IOBGCLDPPJE MOCLOBMAFCP(IEnumerator<IOBGCLDPPJE> CBNJHGHNHMN, BJAAGMDGKEG DDDDJFLMDFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A0D0", Offset = "0x7C092D0", VA = "0x187C0A0D0")]
	public IOBGCLDPPJE MOCLOBMAFCP(BJAAGMDGKEG[] FJIEGCBKOKE, IEnumerator<IOBGCLDPPJE>[] MILOADDIFIN, IOBGCLDPPJE[] OKGLIOLMLMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7C09CC0", Offset = "0x7C08EC0", VA = "0x187C09CC0")]
	public void BGLODPHMABA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7C09E30", Offset = "0x7C09030", VA = "0x187C09E30")]
	public void HEDGMGJDOJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7C09CF0", Offset = "0x7C08EF0", VA = "0x187C09CF0")]
	public void CEPNIEFJPFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7C09CC0", Offset = "0x7C08EC0", VA = "0x187C09CC0")]
	public void BCMBOJBHPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public NLNDJLMNFJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class KHNOGLPPENN
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct JHFMBDGPJOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public NLNDJLMNFJD HBEOCPIDDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public ANFPAPNNIFP NPHCNIEGAPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public BJAAGMDGKEG OCNCNAKDJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IEnumerator<IOBGCLDPPJE> GOMAGOMCCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public IOBGCLDPPJE JDNFHPCAPHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public PDAIOHPPPOF DGMILCKCOCO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct IEEHFBHKHFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public MPFOEBMPEMA CBGEHLANECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public List<JHFMBDGPJOE> EKNHNKENPFP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class BABCDLHODNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public BJAAGMDGKEG promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public KHNOGLPPENN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public ANFPAPNNIFP context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public NLNDJLMNFJD routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public PDAIOHPPPOF coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public IOBGCLDPPJE currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public IEnumerator<IOBGCLDPPJE> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BABCDLHODNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3470", Offset = "0x7BF2670", VA = "0x187BF3470")]
		internal void AMKLAECEJBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class CKIACPKMMGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public NLNDJLMNFJD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public KHNOGLPPENN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CKIACPKMMGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BF58E0", Offset = "0x7BF4AE0", VA = "0x187BF58E0")]
		internal void MEALAJAABNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class NPEKJAEELOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public NLNDJLMNFJD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public KHNOGLPPENN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public NPEKJAEELOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A270", Offset = "0x7C09470", VA = "0x187C0A270")]
		internal void FGDCIGGBIIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class EHDLPALIAKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public NLNDJLMNFJD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public KHNOGLPPENN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public EHDLPALIAKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB670", Offset = "0x7BFA870", VA = "0x187BFB670")]
		internal void LOOEGKJFJKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const PDAIOHPPPOF GPAPOAEEABH = PDAIOHPPPOF.Cancelled | PDAIOHPPPOF.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly MPFOEBMPEMA JFMEEDLHBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private bool[] HHHMGGABPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<PDAIOHPPPOF> DEGLOEDKEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<float> NPJLNHIKHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> BJDBECHAMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> MBNMDFPGECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> JBLENJMJHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> KHAAMPNHBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> OCGOCBCKKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private NLNDJLMNFJD[] GNAICCLAENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private BJAAGMDGKEG[] FJIEGCBKOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private ANFPAPNNIFP[] BMPGEACMIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private IEnumerator<IOBGCLDPPJE>[] EPHGDKAMCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private IOBGCLDPPJE[] HHIOCFAGCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int HKIPLONLMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int EKPEFEBPGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly int AOACOFFBGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float HPMBAJLFEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private IHGBBNHAHMJ AOLPJFOCMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JobHandle HPOMOKKKAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<NLNDJLMNFJD> CEGNEBLHKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool MEBFNCOOILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> CBOMNAJGBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private List<Action> BMJCKCFEMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private bool GFLDMJPDEED;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IEEHFBHKHFN[] JAIDDOANFEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9592C0", Offset = "0x9584C0", VA = "0x1809592C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7C04990", Offset = "0x7C03B90", VA = "0x187C04990")]
	private static int HDAFDCFOBIA(MPFOEBMPEMA JFMEEDLHBFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7C05AE0", Offset = "0x7C04CE0", VA = "0x187C05AE0")]
	public KHNOGLPPENN(MPFOEBMPEMA JFMEEDLHBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7C05550", Offset = "0x7C04750", VA = "0x187C05550")]
	private void MAMFABMCBDH(int EDCCDDBIPOH, int GFLDHPCEABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7C05830", Offset = "0x7C04A30", VA = "0x187C05830")]
	public void NDCKANFFBED(ANFPAPNNIFP GCGNIOHLIKK, IOBGCLDPPJE EIOOKELKMPD, IEnumerator<IOBGCLDPPJE> CBNJHGHNHMN, BJAAGMDGKEG DDDDJFLMDFH, [Optional] NLNDJLMNFJD CICMNPLMCOB, PDAIOHPPPOF HCHKCOGKECB = PDAIOHPPPOF.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7C039B0", Offset = "0x7C02BB0", VA = "0x187C039B0")]
	public void DBGANPBEGJO(IEnumerable<JHFMBDGPJOE> DFMIKDEOJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7C05080", Offset = "0x7C04280", VA = "0x187C05080")]
	private JHFMBDGPJOE LNCMICODLBK(int APMDHPIFFLL)
	{
		return default(JHFMBDGPJOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7C04C90", Offset = "0x7C03E90", VA = "0x187C04C90")]
	private void LEKDHMPOBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x332ACB0", Offset = "0x3329EB0", VA = "0x18332ACB0")]
	private static void NODKKPADBCK<T>(int APMDHPIFFLL, T[] MALOKOPCION, int AFLMMFDMNOE, [Optional] T BBCGKOJFFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x332AD00", Offset = "0x3329F00", VA = "0x18332AD00")]
	private static void NODKKPADBCK<T>(int APMDHPIFFLL, NativeArray<T> MALOKOPCION, int AFLMMFDMNOE, [Optional] T BBCGKOJFFCF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7C03E50", Offset = "0x7C03050", VA = "0x187C03E50")]
	private void EODFMELOLMA(IEnumerable<JHFMBDGPJOE> DFMIKDEOJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7C049C0", Offset = "0x7C03BC0", VA = "0x187C049C0")]
	private void KENENNGAMBL(JHFMBDGPJOE CFAMJGFFGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7C03BF0", Offset = "0x7C02DF0", VA = "0x187C03BF0")]
	private NFIHHFNOLHN DJAMGAIKJOP(int NPBLCBAABDC)
	{
		return default(NFIHHFNOLHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7C04A90", Offset = "0x7C03C90", VA = "0x187C04A90")]
	public void KKJEKLGGMOF(float MFMMOJAJAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C05000", Offset = "0x7C04200", VA = "0x187C05000")]
	private void LLFEGEAOLPP(Action KKLLOEEDINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C041F0", Offset = "0x7C033F0", VA = "0x187C041F0")]
	private void FDBLCHCJGPE(Action KKLLOEEDINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C04270", Offset = "0x7C03470", VA = "0x187C04270")]
	public void GJJGOPHJKBD(float MFMMOJAJAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C05730", Offset = "0x7C04930", VA = "0x187C05730")]
	public void MFBFDNDBONL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C03750", Offset = "0x7C02950", VA = "0x187C03750")]
	public void BCMBOJBHPMP(NLNDJLMNFJD MLDPMLDLIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C059B0", Offset = "0x7C04BB0", VA = "0x187C059B0")]
	public void OPKIAEMALAH(NLNDJLMNFJD MLDPMLDLIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C03880", Offset = "0x7C02A80", VA = "0x187C03880")]
	public void BHAAFGECMOM(NLNDJLMNFJD MLDPMLDLIEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class KFKHMMFHKDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly KFKHMMFHKDB GNFCEACADKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Action CNNPIFMDOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private bool CLAMDNBMMAC;

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	public KFKHMMFHKDB(Action CNNPIFMDOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x732AF80", Offset = "0x732A180", VA = "0x18732AF80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface FMPDMNACOEP<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T ELOFPHHKCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable NBKGIEFPNIK(UnityEngine.Object GCGNIOHLIKK, Action<T> DBGNBLGGDNG);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface EINKHJIPGEP<T> : FMPDMNACOEP<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T ELOFPHHKCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class DPBCCELMLEJ<T> : EINKHJIPGEP<T>, FMPDMNACOEP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class EFLBNJLGCFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public DPBCCELMLEJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public OLFIBPOGDEP<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public EFLBNJLGCFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA0C0", Offset = "0x3EF92C0", VA = "0x183EFA0C0")]
		internal void KFNDJFMFEOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static GameObject DNBPOMDGEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<OLFIBPOGDEP<UnityEngine.Object, Action<T>>> DAFLIPKDDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private T DBLCOAJMKJH;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T ELOFPHHKCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xBB5FE0", Offset = "0xBB51E0", VA = "0x180BB5FE0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6088330", Offset = "0x6087530", VA = "0x186088330", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6088DE0", Offset = "0x6087FE0", VA = "0x186088DE0")]
	private static bool PLJBPBEEOKP(T KKLLOEEDINO, T NHCGDJCFKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6088F60", Offset = "0x6088160", VA = "0x186088F60")]
	public DPBCCELMLEJ(T COODBHBAAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6088580", Offset = "0x6087780", VA = "0x186088580", Slot = "6")]
	public IDisposable NBKGIEFPNIK(UnityEngine.Object GCGNIOHLIKK, Action<T> DBGNBLGGDNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6088A70", Offset = "0x6087C70", VA = "0x186088A70")]
	private void PEOPGPDEPDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal class GLHBNMIOGKJ : PHNNBMOFPME
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private class LDKPJPBGKAH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		private class FOJOBBCDMNA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int BEHEHKFONGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private LDKPJPBGKAH EALKLACMEDA;

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xD40C40", Offset = "0xD3FE40", VA = "0x180D40C40")]
			public FOJOBBCDMNA(int BEHEHKFONGA, LDKPJPBGKAH EALKLACMEDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x7BFE070", Offset = "0x7BFD270", VA = "0x187BFE070", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class GIIHFIPFDAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public GIIHFIPFDAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xCC6250", Offset = "0xCC5450", VA = "0x180CC6250")]
			internal bool FLDCIJOIHAB(PDEKGPMHAPO e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class JAAOJAKDCKB : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private IOBGCLDPPJE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public LDKPJPBGKAH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public PFOEODMEJLH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			private JBAPJHIPMOK <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			private List<PDEKGPMHAPO> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
			[DebuggerHidden]
			public JAAOJAKDCKB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x7C014C0", Offset = "0x7C006C0", VA = "0x187C014C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x7C01850", Offset = "0x7C00A50", VA = "0x187C01850", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly MPFOEBMPEMA JFMEEDLHBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private GFDHFLBBFKF DDDDJFLMDFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private bool PIJDOBIPEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly List<PDEKGPMHAPO> ACLAAGJGPHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly HashSet<int> JABJHNJAFKB;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7C06DB0", Offset = "0x7C05FB0", VA = "0x187C06DB0")]
		public LDKPJPBGKAH(MPFOEBMPEMA JFMEEDLHBFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7C06A00", Offset = "0x7C05C00", VA = "0x187C06A00")]
		public IDisposable EBNIBNAPACF(PDEKGPMHAPO HMJGNHGFHFP, FJHAIGEICMN CHHAFMMADAN, PFOEODMEJLH FBHOIGDCPGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B90", Offset = "0x7C05D90", VA = "0x187C06B90")]
		private void LAJCJPLCIIL(int BEHEHKFONGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C06D20", Offset = "0x7C05F20", VA = "0x187C06D20")]
		[IteratorStateMachine(typeof(JAAOJAKDCKB))]
		private IEnumerator<IOBGCLDPPJE> OBCHOFKIIMJ(PFOEODMEJLH FBHOIGDCPGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C069B0", Offset = "0x7C05BB0", VA = "0x187C069B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private class PDEKGPMHAPO
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		public enum PMCEMKFKAMI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static int NPPFFEEMGNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public readonly int JFJOAOHHOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public readonly ONOIHDMEOKA NPHCNIEGAPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private readonly MonoBehaviour MAOEBMELBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public readonly Action MEIPIBBEBLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public readonly Action<float> FAAPGOFIFAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public readonly float EIJGOMECBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public float NPJLNHIKHPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public readonly string PCMLNMEPCBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public readonly bool EOFHMFBHKNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public readonly PMCEMKFKAMI NPJNDJAAHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public bool AJLMHEFNEOP;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D700", Offset = "0x7C0C900", VA = "0x187C0D700")]
		public PDEKGPMHAPO(ONOIHDMEOKA GCGNIOHLIKK, Action KFAFFMDDJPL, bool GPPLPOMMPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D580", Offset = "0x7C0C780", VA = "0x187C0D580")]
		public PDEKGPMHAPO(ONOIHDMEOKA GCGNIOHLIKK, Action<float> KFAFFMDDJPL, bool GPPLPOMMPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D880", Offset = "0x7C0CA80", VA = "0x187C0D880")]
		public PDEKGPMHAPO(ONOIHDMEOKA GCGNIOHLIKK, float BJFHMPICGDF, Action<float> KFAFFMDDJPL, PFOEODMEJLH FBHOIGDCPGK, PMCEMKFKAMI GPLFMMFMHJH, bool HNHBNOBCCFI, bool GPPLPOMMPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D3B0", Offset = "0x7C0C5B0", VA = "0x187C0D3B0")]
		public bool JIFILOGOJLF(float EFKOIGNGJGD, float JDOEILPOGPJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly FJHAIGEICMN CHHAFMMADAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly PFOEODMEJLH HALDMJNCLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly Dictionary<MPFOEBMPEMA, LDKPJPBGKAH> FEAEGEHNMFA;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF3F0", Offset = "0x7BFE5F0", VA = "0x187BFF3F0")]
	[NAOGKPPNIGE.PBOHCEMILCE]
	internal static void NJNKCHBBEFB(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFA30", Offset = "0x7BFEC30", VA = "0x187BFFA30")]
	[UnityEngine.Scripting.Preserve]
	internal GLHBNMIOGKJ([FMJHJHHALCB(null)] FJHAIGEICMN CHHAFMMADAN, [FMJHJHHALCB(null)] PFOEODMEJLH HALDMJNCLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF200", Offset = "0x7BFE400", VA = "0x187BFF200", Slot = "4")]
	public IDisposable MEIPIBBEBLB(ONOIHDMEOKA GCGNIOHLIKK, Action FOCHKIPOIOG, MPFOEBMPEMA JFMEEDLHBFN, bool GPPLPOMMPCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF010", Offset = "0x7BFE210", VA = "0x187BFF010", Slot = "5")]
	public IDisposable MEIPIBBEBLB(ONOIHDMEOKA GCGNIOHLIKK, Action<float> FOCHKIPOIOG, MPFOEBMPEMA JFMEEDLHBFN, bool GPPLPOMMPCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF7B0", Offset = "0x7BFE9B0", VA = "0x187BFF7B0", Slot = "7")]
	public IDisposable PDLIAPCHCHJ(ONOIHDMEOKA GCGNIOHLIKK, float BJFHMPICGDF, Action<float> FOCHKIPOIOG, MPFOEBMPEMA JFMEEDLHBFN, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEF10", Offset = "0x7BFE110", VA = "0x187BFEF10", Slot = "8")]
	public IDisposable CBNCADANHFM(ONOIHDMEOKA GCGNIOHLIKK, float BJFHMPICGDF, Action<float> FOCHKIPOIOG, MPFOEBMPEMA JFMEEDLHBFN, bool HNHBNOBCCFI = true, bool GPPLPOMMPCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF8B0", Offset = "0x7BFEAB0", VA = "0x187BFF8B0", Slot = "6")]
	public IDisposable PDLIAPCHCHJ(float BJFHMPICGDF, Action<float> FOCHKIPOIOG, bool HNHBNOBCCFI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF5F0", Offset = "0x7BFE7F0", VA = "0x187BFF5F0", Slot = "9")]
	public void OKECIINHNOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF460", Offset = "0x7BFE660", VA = "0x187BFF460")]
	private LDKPJPBGKAH NOKFFAMKPLL(MPFOEBMPEMA JFMEEDLHBFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class GHFGAAELOKN : EJKKBFLDEGE, FJHAIGEICMN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private KHNOGLPPENN[] BNBPMHJFANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private EBLBMEFBNLA KGIDJLGHNEO;

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE460", Offset = "0x7BFD660", VA = "0x187BFE460")]
	[NAOGKPPNIGE.PBOHCEMILCE]
	internal static void EMFHCKBHCPB(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEC70", Offset = "0x7BFDE70", VA = "0x187BFEC70")]
	[UnityEngine.Scripting.Preserve]
	public GHFGAAELOKN([FMJHJHHALCB(null)] DCGLPMAPACA LNGOGBELDAD, [FMJHJHHALCB(null)] PFOEODMEJLH HALDMJNCLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE0A0", Offset = "0x7BFD2A0", VA = "0x187BFE0A0", Slot = "19")]
	public override GFDHFLBBFKF CNIGAMCOHIN(ANFPAPNNIFP GCGNIOHLIKK, IEnumerator<IOBGCLDPPJE> ACCPDEPKGIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE9E0", Offset = "0x7BFDBE0", VA = "0x187BFE9E0", Slot = "20")]
	public override void OKECIINHNOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE1D0", Offset = "0x7BFD3D0", VA = "0x187BFE1D0", Slot = "22")]
	public override void DGMJINFGAMG(MPFOEBMPEMA JFMEEDLHBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE7F0", Offset = "0x7BFD9F0", VA = "0x187BFE7F0", Slot = "21")]
	protected override void MEIPIBBEBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE7C0", Offset = "0x7BFD9C0", VA = "0x187BFE7C0")]
	private KHNOGLPPENN LLGOFKHMPNB(MPFOEBMPEMA MDOOANEGCAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE590", Offset = "0x7BFD790", VA = "0x187BFE590", Slot = "23")]
	internal override BNMAGIIEGPO KLFGICDMGBI(IEnumerator<IOBGCLDPPJE> ACCPDEPKGIN, Behaviour GCGNIOHLIKK, BJAAGMDGKEG DDDDJFLMDFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE4D0", Offset = "0x7BFD6D0", VA = "0x187BFE4D0", Slot = "24")]
	internal override PACGOPMDPNC GMHCMJOIIPI(MPFOEBMPEMA EALKLACMEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE8C0", Offset = "0x7BFDAC0", VA = "0x187BFE8C0")]
	private void OBCOCIELCDF(KHNOGLPPENN CJEPLEFJFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE400", Offset = "0x7BFD600", VA = "0x187BFE400", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[BurstCompile]
internal struct IHGBBNHAHMJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ReadOnly]
	public float KAFLLJIHEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ReadOnly]
	public int APJAKKIDHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<int> EKAMDBEHCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private NativeArray<int> IANOBMHBGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private NativeArray<int> HLEFHFOKJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[ReadOnly]
	public NativeArray<PDAIOHPPPOF> PHHKECNMIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ReadOnly]
	public NativeArray<float> MHCGFIPMPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[WriteOnly]
	public NativeArray<int> JBLENJMJHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[WriteOnly]
	public NativeArray<int> BJDBECHAMML;

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C00FB0", Offset = "0x7C001B0", VA = "0x187C00FB0")]
	public static IHGBBNHAHMJ LHPCDDMHIBB(int AMAEMCFNMCE, float MFMMOJAJAID, NativeArray<PDAIOHPPPOF> DLNPHFHKOAE, NativeArray<float> GLEINLNEBMA, NativeArray<int> DCIANOCNLJO, NativeArray<int> CCEKIPLJOLG, NativeArray<int> EFIGOCELJPG, NativeArray<int> IANOBMHBGFM, NativeArray<int> HLEFHFOKJCD)
	{
		return default(IHGBBNHAHMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C00E30", Offset = "0x7C00030", VA = "0x187C00E30", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C01010", Offset = "0x7C00210", VA = "0x187C01010")]
	private bool MIPIAGPMANJ(int CPLNODNGKGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C01290", Offset = "0x7C00490", VA = "0x187C01290")]
	private void PIGJDLGNDJC(NativeArray<int> GPBEAHFLAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C00F10", Offset = "0x7C00110", VA = "0x187C00F10")]
	private int IGJGIIFHBAH(int DEEFKKJCENN, int KLGKLFAOEEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7C00D60", Offset = "0x7BFFF60", VA = "0x187C00D60")]
	private void EBLOIDOHOKF(NativeArray<int> GPBEAHFLAKH, int LBBEPPOONAL, int KBNPICMCGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7C01050", Offset = "0x7C00250", VA = "0x187C01050")]
	private void OKPCJENLGJP(NativeArray<int> GPBEAHFLAKH, int PNLDPMNHKAM, int CPFHLIOHHOF, int GNJIJNDJKBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class EJKKBFLDEGE : FJHAIGEICMN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly DCGLPMAPACA LNGOGBELDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	protected readonly PFOEODMEJLH HALDMJNCLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private PACGOPMDPNC[] JLOACEFBFKF;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static FJHAIGEICMN CLACNPDFIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB9B0", Offset = "0x7BFABB0", VA = "0x187BFB9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static bool EHPNJBGMJGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public MPFOEBMPEMA NALOHGEOMFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8F21A0", Offset = "0x8F13A0", VA = "0x1808F21A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MPFOEBMPEMA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8FEBC0", Offset = "0x8FDDC0", VA = "0x1808FEBC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PFOEODMEJLH IEKIPMECDOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public IOBGCLDPPJE MKPDEHMDIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IOBGCLDPPJE MNMANJHODGN
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8FD8F0", Offset = "0x8FCAF0", VA = "0x1808FD8F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IOBGCLDPPJE LGDLPFPEHED
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8F9330", Offset = "0x8F8530", VA = "0x1808F9330", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IOBGCLDPPJE EGKGDHOECGO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8F21D0", Offset = "0x8F13D0", VA = "0x1808F21D0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC3E0", Offset = "0x7BFB5E0", VA = "0x187BFC3E0")]
	public static GFDHFLBBFKF OGCKLAMFPOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC610", Offset = "0x7BFB810", VA = "0x187BFC610")]
	[UnityEngine.Scripting.Preserve]
	protected EJKKBFLDEGE([FMJHJHHALCB(null)] DCGLPMAPACA LNGOGBELDAD, [FMJHJHHALCB(null)] PFOEODMEJLH HALDMJNCLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB7A0", Offset = "0x7BFA9A0", VA = "0x187BFB7A0", Slot = "6")]
	public GFDHFLBBFKF BOIJOOGLJMA(IEnumerator<IOBGCLDPPJE> ACCPDEPKGIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB7B0", Offset = "0x7BFA9B0", VA = "0x187BFB7B0", Slot = "7")]
	public GFDHFLBBFKF BOIJOOGLJMA(Behaviour GCGNIOHLIKK, IEnumerator<IOBGCLDPPJE> ACCPDEPKGIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract GFDHFLBBFKF CNIGAMCOHIN(ANFPAPNNIFP GCGNIOHLIKK, IEnumerator<IOBGCLDPPJE> ACCPDEPKGIN);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC470", Offset = "0x7BFB670", VA = "0x187BFC470", Slot = "20")]
	public virtual void OKECIINHNOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC140", Offset = "0x7BFB340", VA = "0x187BFC140", Slot = "9")]
	public void MDONHNEMFEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC380", Offset = "0x7BFB580", VA = "0x187BFC380", Slot = "21")]
	protected virtual void MEIPIBBEBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC3A0", Offset = "0x7BFB5A0", VA = "0x187BFC3A0")]
	private void MPLEBNEOBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7BFBED0", Offset = "0x7BFB0D0", VA = "0x187BFBED0")]
	private void EPNFMOGLCIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7BFBF10", Offset = "0x7BFB110", VA = "0x187BFBF10")]
	private void GPHEIMLMIKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC120", Offset = "0x7BFB320", VA = "0x187BFC120")]
	private void LIKKBGEPPDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7BFBEF0", Offset = "0x7BFB0F0", VA = "0x187BFBEF0")]
	private void FPDAFGHBNFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7BFBF30", Offset = "0x7BFB130", VA = "0x187BFBF30")]
	private void JKHJOCCMMGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC3C0", Offset = "0x7BFB5C0", VA = "0x187BFC3C0")]
	private void NHEEICJCDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7BFBA20", Offset = "0x7BFAC20", VA = "0x187BFBA20", Slot = "22")]
	public virtual void DGMJINFGAMG(MPFOEBMPEMA JFMEEDLHBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7BFBF50", Offset = "0x7BFB150", VA = "0x187BFBF50")]
	private void JMDLPKFCAIO(PACGOPMDPNC CJEPLEFJFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x24121F0", Offset = "0x24113F0", VA = "0x1824121F0")]
	private PACGOPMDPNC LADENAGAKIF(MPFOEBMPEMA MDOOANEGCAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract BNMAGIIEGPO KLFGICDMGBI(IEnumerator<IOBGCLDPPJE> ACCPDEPKGIN, Behaviour GMGJNFEBMOH, BJAAGMDGKEG AKEFPHNHBIE);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract PACGOPMDPNC GMHCMJOIIPI(MPFOEBMPEMA JFMEEDLHBFN);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7BFBAB0", Offset = "0x7BFACB0", VA = "0x187BFBAB0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFBE70", Offset = "0x7BFB070", VA = "0x187BFBE70", Slot = "15")]
	public IOBGCLDPPJE EKBPHJEMGHP(MPFOEBMPEMA EALKLACMEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB710", Offset = "0x7BFA910", VA = "0x187BFB710", Slot = "16")]
	public IOBGCLDPPJE BMCLHDDGBAD(float KIPBHBAMJHE, MPFOEBMPEMA EALKLACMEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB6B0", Offset = "0x7BFA8B0", VA = "0x187BFB6B0", Slot = "17")]
	public IOBGCLDPPJE AHFLPAACENI(Func<bool> PBMHCOIDBNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal sealed class BNMAGIIEGPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly BJAAGMDGKEG DDDDJFLMDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly NLOJEGMHIHD GCGNIOHLIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly bool PECFHAOOMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private string LMOANCJLHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private StackTrace ECBJGACOFAM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public IEnumerator<IOBGCLDPPJE> GOMAGOMCCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public IOBGCLDPPJE JDNFHPCAPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool CLIDOGACLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4AE0", Offset = "0x7BF3CE0", VA = "0x187BF4AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool MIEGHMPHPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xABD790", Offset = "0xABC990", VA = "0x180ABD790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xAC3940", Offset = "0xAC2B40", VA = "0x180AC3940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string PCMLNMEPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7BF48E0", Offset = "0x7BF3AE0", VA = "0x187BF48E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public float NCOGHNEHDJG
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xE8C7D0", Offset = "0xE8B9D0", VA = "0x180E8C7D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x10EAFF0", Offset = "0x10EA1F0", VA = "0x1810EAFF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4FD0", Offset = "0x7BF41D0", VA = "0x187BF4FD0")]
	public BNMAGIIEGPO(IEnumerator<IOBGCLDPPJE> CBNJHGHNHMN, NLOJEGMHIHD GCGNIOHLIKK, BJAAGMDGKEG DDDDJFLMDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4BD0", Offset = "0x7BF3DD0", VA = "0x187BF4BD0")]
	public IOBGCLDPPJE MOCLOBMAFCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4B60", Offset = "0x7BF3D60", VA = "0x187BF4B60")]
	public bool LCCGJEFHCAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4A90", Offset = "0x7BF3C90", VA = "0x187BF4A90")]
	public void BCMBOJBHPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4EF0", Offset = "0x7BF40F0", VA = "0x187BF4EF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xC24CD0", Offset = "0xC23ED0", VA = "0x180C24CD0")]
	[CompilerGenerated]
	private void JPFHIEKAAAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class BJAAGMDGKEG : PKEMMIALFGC, GFDHFLBBFKF, FMIMELHPEBJ, JABNAOPJDOK, IEnumerator, IOBGCLDPPJE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private MPFOEBMPEMA OFODEKJNGAE;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private MPFOEBMPEMA LIEIGHHPIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xBF6C00", Offset = "0xBF5E00", VA = "0x180BF6C00", Slot = "23")]
		get
		{
			return default(MPFOEBMPEMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MPFOEBMPEMA PNMPCAOOLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD6D580", Offset = "0xD6C780", VA = "0x180D6D580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private float LCIPAOPGFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA67A90", Offset = "0xA66C90", VA = "0x180A67A90", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool HDDMJIHDOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4870", Offset = "0x7BF3A70", VA = "0x187BF4870", Slot = "24")]
	private bool MHKEPHGDNON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4860", Offset = "0x7BF3A60", VA = "0x187BF4860", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4890", Offset = "0x7BF3A90", VA = "0x187BF4890")]
	public BJAAGMDGKEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal enum NFIHHFNOLHN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal sealed class PACGOPMDPNC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public enum AFHOCMKDKPA
	{
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public struct KIAMMADLPGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public MPFOEBMPEMA CBGEHLANECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AFHOCMKDKPA HJJDCGFGHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public List<BNMAGIIEGPO> HFAJCLOJMAP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly AFHOCMKDKPA[] OEJEACEOANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly MPFOEBMPEMA JFMEEDLHBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private bool MPHLOJDODLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly BNMAGIIEGPO[] MBBLEOOLOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly List<BNMAGIIEGPO> DKHDIHKEGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Stack<int> PKENCCBFLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly List<BNMAGIIEGPO> DCMKCLFCEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly Stack<int> GHDFDHHNJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly EBLBMEFBNLA MFODLOBJGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private bool GFLDMJPDEED;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public KIAMMADLPGO[,] KNCHIPKACLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8F9330", Offset = "0x8F8530", VA = "0x1808F9330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0CF10", Offset = "0x7C0C110", VA = "0x187C0CF10")]
	public PACGOPMDPNC(MPFOEBMPEMA EALKLACMEDA, EBLBMEFBNLA MFODLOBJGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0C690", Offset = "0x7C0B890", VA = "0x187C0C690")]
	public void KIFCFEKMBLB(BNMAGIIEGPO CBNJHGHNHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0C790", Offset = "0x7C0B990", VA = "0x187C0C790")]
	public void LOODKEGEAGP(IList<BNMAGIIEGPO> MILOADDIFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0C290", Offset = "0x7C0B490", VA = "0x187C0C290")]
	public void DPGNIAJIOEJ(IList<BNMAGIIEGPO> MILOADDIFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7C0BEE0", Offset = "0x7C0B0E0", VA = "0x187C0BEE0")]
	private void BFIOMNBJHEO(BNMAGIIEGPO CBNJHGHNHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7C0BD60", Offset = "0x7C0AF60", VA = "0x187C0BD60")]
	private void AKIGKDEEAJM(IList<BNMAGIIEGPO> MILOADDIFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7C0BFD0", Offset = "0x7C0B1D0", VA = "0x187C0BFD0")]
	private NFIHHFNOLHN CGJNNNGEDMC(BNMAGIIEGPO CBNJHGHNHMN)
	{
		return default(NFIHHFNOLHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7C0CC60", Offset = "0x7C0BE60", VA = "0x187C0CC60")]
	public void MEIPIBBEBLB(float MFMMOJAJAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7C0CA70", Offset = "0x7C0BC70", VA = "0x187C0CA70")]
	public void MDONHNEMFEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7C0BA00", Offset = "0x7C0AC00", VA = "0x187C0BA00")]
	private void AAHJPKFJCON(List<BNMAGIIEGPO> MILOADDIFIN, Stack<int> AGHMLDGODMG, bool CHELBHHMAIL, float JIILNELNDDI = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7C0C570", Offset = "0x7C0B770", VA = "0x187C0C570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7C0C150", Offset = "0x7C0B350", VA = "0x187C0C150")]
	private void DGFNPIMFPON(List<BNMAGIIEGPO> MILOADDIFIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal class OIGAOFPPMCO : EBLBMEFBNLA
{
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "4")]
	public void PNGNJMNFLCF(string LMOANCJLHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
	public void MHDJPGLDMBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public OIGAOFPPMCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal class BGJOKIOPKMN : NLOJEGMHIHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly Behaviour GMGJNFEBMOH;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string PCMLNMEPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4770", Offset = "0x7BF3970", VA = "0x187BF4770", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool CCBACAJLKLA
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4810", Offset = "0x7BF3A10", VA = "0x187BF4810", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool ONMKEEDCDJK
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF47F0", Offset = "0x7BF39F0", VA = "0x187BF47F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	public BGJOKIOPKMN(Behaviour GMGJNFEBMOH)
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

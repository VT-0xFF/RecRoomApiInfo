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
	public class LogRegistrationIndex : IMPGLFODBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x79B9E40", Offset = "0x79B9240", VA = "0x1879B9E40", Slot = "4")]
		public override void EMOBGIHOLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79C2DC0", Offset = "0x79C21C0", VA = "0x1879C2DC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
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
		private delegate List<PlayerLoopSystem> GABNAPGPBCF(List<PlayerLoopSystem> ECELBDFPDIE, int KFMIINEDGPF);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct CLOEFHJKLNF
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct AHEPLKKLGGK
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static MIPKPFFHABJ JIMJLGHCDCN;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x79A6140", Offset = "0x79A5540", VA = "0x1879A6140")]
				public static PlayerLoopSystem NDDNOOGALGH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct JABOOHBCPPK
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static MIPKPFFHABJ KCIDHGGCFJO;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x79B7340", Offset = "0x79B6740", VA = "0x1879B7340")]
				public static PlayerLoopSystem NDDNOOGALGH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct MLNGHAAMCFD
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static MIPKPFFHABJ BMGIDOIOJAC;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x79BCBB0", Offset = "0x79BBFB0", VA = "0x1879BCBB0")]
				public static PlayerLoopSystem NDDNOOGALGH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct KPIMMAKFOEC
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static MIPKPFFHABJ NPCHENONGKP;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static MIPKPFFHABJ EMMABMBHCBD;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static MIPKPFFHABJ MPAFMHABFFJ;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static MIPKPFFHABJ AMLEBIBMMOP;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x79B94C0", Offset = "0x79B88C0", VA = "0x1879B94C0")]
				public static PlayerLoopSystem NDDNOOGALGH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct DFAONCPPMDO
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static MIPKPFFHABJ EJCABGMGDIA;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x79AECD0", Offset = "0x79AE0D0", VA = "0x1879AECD0")]
				public static PlayerLoopSystem NDDNOOGALGH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct FCDJDFGDKOA
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static MIPKPFFHABJ NPCHENONGKP;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static MIPKPFFHABJ EMMABMBHCBD;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static MIPKPFFHABJ MPAFMHABFFJ;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static MIPKPFFHABJ AMLEBIBMMOP;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x79AF800", Offset = "0x79AEC00", VA = "0x1879AF800")]
				public static PlayerLoopSystem NDDNOOGALGH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct EAKDOFLLCCI
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static MIPKPFFHABJ MELIKNADIKA;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x79AF160", Offset = "0x79AE560", VA = "0x1879AF160")]
				public static PlayerLoopSystem NDDNOOGALGH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct ECMEMJIOJDN
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static MIPKPFFHABJ KMICNBKJJMA;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x79AF4B0", Offset = "0x79AE8B0", VA = "0x1879AF4B0")]
				public static PlayerLoopSystem NDDNOOGALGH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct HAFFJBOHGNI
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static MIPKPFFHABJ AAKDLHHPBNG;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x79B4960", Offset = "0x79B3D60", VA = "0x1879B4960")]
				public static PlayerLoopSystem NDDNOOGALGH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct MPIJFLKEMHC
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static MIPKPFFHABJ KONFPCHIFME;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x79BD2F0", Offset = "0x79BC6F0", VA = "0x1879BD2F0")]
				public static PlayerLoopSystem NDDNOOGALGH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct PMOHKCIOOJN
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static MIPKPFFHABJ GEMANNOBAPJ;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x79C1910", Offset = "0x79C0D10", VA = "0x1879C1910")]
				public static PlayerLoopSystem NDDNOOGALGH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct GDDIFFDGNHF
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static MIPKPFFHABJ BNHMKGJFGHD;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x79B37E0", Offset = "0x79B2BE0", VA = "0x1879B37E0")]
				public static PlayerLoopSystem NDDNOOGALGH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct MFJBNIGAINJ
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static MIPKPFFHABJ BLJGDOIGIOD;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x79BC8B0", Offset = "0x79BBCB0", VA = "0x1879BC8B0")]
				public static PlayerLoopSystem NDDNOOGALGH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct JMFMCENKKCK
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static MIPKPFFHABJ GDEMNMPLCOA;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x79B79F0", Offset = "0x79B6DF0", VA = "0x1879B79F0")]
				public static PlayerLoopSystem NDDNOOGALGH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct BKIJPCFMLJE
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static MIPKPFFHABJ CALGBAJOPLH;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x79A78D0", Offset = "0x79A6CD0", VA = "0x1879A78D0")]
				public static PlayerLoopSystem NDDNOOGALGH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum AMDKHEDIDHA : byte
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
			public struct PNPPDPLEFGC
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class IACPONNIPBK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public AMDKHEDIDHA updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
					public IACPONNIPBK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x79B5BA0", Offset = "0x79B4FA0", VA = "0x1879B5BA0")]
					internal void JGKJNIGHDFK()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static FABEAAEBPBG<AMDKHEDIDHA> LNPAGAKLEKA;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x79C1AF0", Offset = "0x79C0EF0", VA = "0x1879C1AF0")]
				public static PlayerLoopSystem NDDNOOGALGH(AMDKHEDIDHA IFECGPMAOOP)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct BBMKDAHFNIM
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class PIACCGHIIEB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public GPFNMKFFNBG.AIIJCECGAIC key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
					public PIACCGHIIEB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x79C0BD0", Offset = "0x79BFFD0", VA = "0x1879C0BD0")]
					internal void AJFOHOFIEHL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable DAJBJFNBCAJ;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x79A6320", Offset = "0x79A5720", VA = "0x1879A6320")]
				public static PlayerLoopSystem NNFAPHJHMAM(GPFNMKFFNBG.AIIJCECGAIC LDCKBFKFIKC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct OFPIJOHIJBN
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class DOPFJDDGGJP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public GPFNMKFFNBG.AIIJCECGAIC key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
					public DOPFJDDGGJP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x79AEEB0", Offset = "0x79AE2B0", VA = "0x1879AEEB0")]
					internal void AJFOHOFIEHL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x79BF830", Offset = "0x79BEC30", VA = "0x1879BF830")]
				public static PlayerLoopSystem NNFAPHJHMAM(GPFNMKFFNBG.AIIJCECGAIC LDCKBFKFIKC)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class KHDKPHBKOOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public KHDKPHBKOOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x79B8190", Offset = "0x79B7590", VA = "0x1879B8190")]
			internal List<PlayerLoopSystem> MNFEIEAFEAP(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool OPKKGEGMHCJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool AMADDJEHPHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x79AA950", Offset = "0x79A9D50", VA = "0x1879AA950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x79AAC80", Offset = "0x79AA080", VA = "0x1879AAC80")]
		private static void KIGABFAAOGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x79ADC90", Offset = "0x79AD090", VA = "0x1879ADC90")]
		private static void PKPGODOLHOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x79AA6D0", Offset = "0x79A9AD0", VA = "0x1879AA6D0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x79AA710", Offset = "0x79A9B10", VA = "0x1879AA710")]
		private static void BDCGJNKNFIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x79AA990", Offset = "0x79A9D90", VA = "0x1879AA990")]
		private static void GCFCDIEFDOA(GPFNMKFFNBG.AIIJCECGAIC LDCKBFKFIKC, PlayerLoopSystem CCLGGMOMOOL, Type KKCAEKFFHMP, Type DNMAHFEDCEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x79AA2F0", Offset = "0x79A96F0", VA = "0x1879AA2F0")]
		private static void ACGJKNLOONK(PlayerLoopSystem CCLGGMOMOOL, Type KKCAEKFFHMP, Type DNMAHFEDCEG, GABNAPGPBCF OKEICHOIHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x79AAB50", Offset = "0x79A9F50", VA = "0x1879AAB50")]
		private static void HJCCGHPDEJM(PlayerLoopSystem CCLGGMOMOOL, Type KKCAEKFFHMP, Type DNMAHFEDCEG, PlayerLoopSystem? PMINBJCLOCK, PlayerLoopSystem? HOOOCOOHLLL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class GPFNMKFFNBG
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum AIIJCECGAIC
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
	public class BKDGDIGBBHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly AIIJCECGAIC GJHEAGNLHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly KLFFCNKCLPH ICNANMHGFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long MPIOPHIEJON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long NNKELKLIGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long AONANDJOFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int OAFBHACKFFK;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x79A77B0", Offset = "0x79A6BB0", VA = "0x1879A77B0")]
		public BKDGDIGBBHC(AIIJCECGAIC NKBMBBJCJED, int ELBGODOJIFP = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x79A7530", Offset = "0x79A6930", VA = "0x1879A7530")]
		public void MHCMGLDAIAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x79A74E0", Offset = "0x79A68E0", VA = "0x1879A74E0")]
		public void KNJODIKMJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x79A75B0", Offset = "0x79A69B0", VA = "0x1879A75B0")]
		public void OBDHFJLJCAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static AIIJCECGAIC[] AIADADIAMCO;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static BKDGDIGBBHC[] HIINMNBFJEH;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x79B45F0", Offset = "0x79B39F0", VA = "0x1879B45F0")]
	public static BKDGDIGBBHC NHPOHHILCLG(AIIJCECGAIC LDCKBFKFIKC, int ELBGODOJIFP = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x79B4580", Offset = "0x79B3980", VA = "0x1879B4580")]
	public static BKDGDIGBBHC IPNHHFAKADN(AIIJCECGAIC LDCKBFKFIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x79B44E0", Offset = "0x79B38E0", VA = "0x1879B44E0")]
	public static void AHCBGEFJACF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class KLFFCNKCLPH : INHNBFJLKDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int PLNKELLEKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Queue<double> DKMCFNMCJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double OHMCJFFPFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double CDDAELCNAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double KKDLNBABJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int NDDJPCAAKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private double KKHPAOMIHAG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NAECBIJLDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8E4C50", Offset = "0x8E4050", VA = "0x1808E4C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double LGGOGNJEBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x79B8510", Offset = "0x79B7910", VA = "0x1879B8510", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double MPDLMELCOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5704200", Offset = "0x5703600", VA = "0x185704200", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double INKDMGBLEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x22C88D0", Offset = "0x22C7CD0", VA = "0x1822C88D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x79B8570", Offset = "0x79B7970", VA = "0x1879B8570")]
	public KLFFCNKCLPH(int EHAACDMBAPA, double KKHPAOMIHAG = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x79B83E0", Offset = "0x79B77E0", VA = "0x1879B83E0", Slot = "7")]
	public void CKIIDGMFCMG(double BBFFJMPBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x79B8370", Offset = "0x79B7770", VA = "0x1879B8370", Slot = "8")]
	public void CALNFFOLFJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class LINBJNODKKM : INHNBFJLKDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private long ABPDJOGPHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private double NMPOPDMCMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private double BOJEDEMLGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private double NGNMOLLJPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private double KENKJIPDPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private double OHMCJFFPFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private double CDDAELCNAGM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double MPDLMELCOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6508EF0", Offset = "0x65082F0", VA = "0x186508EF0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double INKDMGBLEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9B21E0", Offset = "0x9B15E0", VA = "0x1809B21E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double LOMOKEJDNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6508F00", Offset = "0x6508300", VA = "0x186508F00")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double LGGOGNJEBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x292E400", Offset = "0x292D800", VA = "0x18292E400", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x79B9D20", Offset = "0x79B9120", VA = "0x1879B9D20", Slot = "7")]
	public virtual void CKIIDGMFCMG(double BBFFJMPBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x79B9CE0", Offset = "0x79B90E0", VA = "0x1879B9CE0", Slot = "8")]
	public virtual void CALNFFOLFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x79B5720", Offset = "0x79B4B20", VA = "0x1879B5720")]
	public LINBJNODKKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class HNJOBMEBHBL : LINBJNODKKM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double CFIHMLLMPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6508A30", Offset = "0x6507E30", VA = "0x186508A30")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6508ED0", Offset = "0x65082D0", VA = "0x186508ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x79B55F0", Offset = "0x79B49F0", VA = "0x1879B55F0", Slot = "7")]
	public override void CKIIDGMFCMG(double BBFFJMPBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x79B55B0", Offset = "0x79B49B0", VA = "0x1879B55B0", Slot = "8")]
	public override void CALNFFOLFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x79B5720", Offset = "0x79B4B20", VA = "0x1879B5720")]
	public HNJOBMEBHBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface INHNBFJLKDB
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double LGGOGNJEBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double MPDLMELCOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double INKDMGBLEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class FJBKNNMGKKD
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private interface DCPDOEOMLCP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool DGECENFKPCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FHKCAKCKHMF();
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class CEHNMGJDPEO : DCPDOEOMLCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly Action OLHFOBIBHCJ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool DGECENFKPCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
		public CEHNMGJDPEO(Action OLHFOBIBHCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCE8380", Offset = "0xCE7780", VA = "0x180CE8380", Slot = "5")]
		public void FHKCAKCKHMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly List<DCPDOEOMLCP> GHDAHHCEGDG;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x79B0870", Offset = "0x79AFC70", VA = "0x1879B0870")]
	public static void LEGONBHCPLB(Action OLHFOBIBHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x79B0910", Offset = "0x79AFD10", VA = "0x1879B0910")]
	private static void OKHEJDEANKC(DCPDOEOMLCP GNELENMKLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x79B04C0", Offset = "0x79AF8C0", VA = "0x1879B04C0")]
	private static void AAANNHOECBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x79B0B20", Offset = "0x79AFF20", VA = "0x1879B0B20")]
	private static void PPMPNBAEBGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x79B07A0", Offset = "0x79AFBA0", VA = "0x1879B07A0")]
	private static void GGGNICADFML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class NOFALANLNNC
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private struct PFFOGHICGOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public TaskCompletionSource<Scene> KFOKNAGLHJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly string KAJDLHPACAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly LoadSceneMode EILFKFKMPFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly bool OIBFECHFNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x79C0B70", Offset = "0x79BFF70", VA = "0x1879C0B70")]
		public PFFOGHICGOM(TaskCompletionSource<Scene> LAMCFMALIOO, string KAJDLHPACAD, LoadSceneMode EILFKFKMPFC, bool OIBFECHFNCC, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct FEKEPCMKFPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private LOALKKNJJLG<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x79AFAD0", Offset = "0x79AEED0", VA = "0x1879AFAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x79B0370", Offset = "0x79AF770", VA = "0x1879B0370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct OMGAAAODIGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x79C0320", Offset = "0x79BF720", VA = "0x1879C0320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x79C0630", Offset = "0x79BFA30", VA = "0x1879C0630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct PIAOKPJGMHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private PFFOGHICGOM <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x79C0E50", Offset = "0x79C0250", VA = "0x1879C0E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x79C1210", Offset = "0x79C0610", VA = "0x1879C1210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class JAIPEJPPJNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public ECGKMFIAIBN<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JAIPEJPPJNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x79B7520", Offset = "0x79B6920", VA = "0x1879B7520")]
		internal void MIMLAAOAFKN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct INBBPBMENJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private JAIPEJPPJNG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x79B66F0", Offset = "0x79B5AF0", VA = "0x1879B66F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x79B7290", Offset = "0x79B6690", VA = "0x1879B7290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct DBJEJIPIHJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private CIICFINBKJN <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x79AE5A0", Offset = "0x79AD9A0", VA = "0x1879AE5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x79AEC60", Offset = "0x79AE060", VA = "0x1879AEC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct FLPEKJHNBIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x79B0DE0", Offset = "0x79B01E0", VA = "0x1879B0DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x79B1900", Offset = "0x79B0D00", VA = "0x1879B1900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class CAMGHPBJEJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public CAMGHPBJEJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x79A7AE0", Offset = "0x79A6EE0", VA = "0x1879A7AE0")]
		internal bool FMGOBOOCCDI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class JHHIGLNLOPE : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public FPFCPNKOFAP onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public JHHIGLNLOPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x79B7960", Offset = "0x79B6D60", VA = "0x1879B7960", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x79B7580", Offset = "0x79B6980", VA = "0x1879B7580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x79B78C0", Offset = "0x79B6CC0", VA = "0x1879B78C0")]
		private void NOLPLDAPGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x79B7910", Offset = "0x79B6D10", VA = "0x1879B7910", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class GACHKEBOCEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public ECGKMFIAIBN<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GACHKEBOCEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x79B3400", Offset = "0x79B2800", VA = "0x1879B3400")]
		internal bool EPKKDDMHCCO(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x79B3480", Offset = "0x79B2880", VA = "0x1879B3480")]
		internal void GIEGMCGKBIO(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class COEGNGDHBNC : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public ECGKMFIAIBN<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private GACHKEBOCEA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private CIICFINBKJN <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public COEGNGDHBNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x79AA290", Offset = "0x79A9690", VA = "0x1879AA290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x79A9920", Offset = "0x79A8D20", VA = "0x1879A9920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x79AA220", Offset = "0x79A9620", VA = "0x1879AA220")]
		private void NOLPLDAPGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x79AA240", Offset = "0x79A9640", VA = "0x1879AA240", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly ICollection<string> CNFBFOCDDOF;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static CLHPIMOBJFN HMALDNILPOJ;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static AsyncOperation CENNKHBDMMM;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static CLHPIMOBJFN EOKMPNEAHBM;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static string AHNLNBMBFOO;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static string COODNPOCMJI;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static ThreadPriority JKHIFHPOBNN;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static Task DJOECBDEDKC;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static List<SceneInstance> AMNEOCBDOKP;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly Queue<PFFOGHICGOM> KOPPBGGJBGF;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static Task OJJCGJFDMIE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static bool DAJPFFAMKGO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x79BE3B0", Offset = "0x79BD7B0", VA = "0x1879BE3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private static bool PABPPOCLFNG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x79BEAA0", Offset = "0x79BDEA0", VA = "0x1879BEAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool FDDLFPLJLGK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x79BDF10", Offset = "0x79BD310", VA = "0x1879BDF10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool KIIDIIBNKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x79BEB40", Offset = "0x79BDF40", VA = "0x1879BEB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> BJIBOGJMOME
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x79BE770", Offset = "0x79BDB70", VA = "0x1879BE770")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x79BD790", Offset = "0x79BCB90", VA = "0x1879BD790")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x79BDCD0", Offset = "0x79BD0D0", VA = "0x1879BDCD0")]
	[PHMBPKHGHNB(APLPLLCKGJN.EnteredEditModeNextFrame, 0)]
	private static void FPBCNLGKPKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x79BE260", Offset = "0x79BD660", VA = "0x1879BE260")]
	[AsyncStateMachine(typeof(FEKEPCMKFPB))]
	public static Task<Scene> GHBELNGKBJL(string KAJDLHPACAD, LoadSceneMode EILFKFKMPFC = LoadSceneMode.Single, bool OIBFECHFNCC = false, [Optional] LOALKKNJJLG<string>.HAPJMIAELKE JEKEIGFBODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x79BD970", Offset = "0x79BCD70", VA = "0x1879BD970")]
	[AsyncStateMachine(typeof(OMGAAAODIGM))]
	private static Task EMMLCAFMNOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x79BD8A0", Offset = "0x79BCCA0", VA = "0x1879BD8A0")]
	[AsyncStateMachine(typeof(PIAOKPJGMHC))]
	private static Task DLLMNCDAPFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x79BDDC0", Offset = "0x79BD1C0", VA = "0x1879BDDC0")]
	[AsyncStateMachine(typeof(INBBPBMENJG))]
	private static Task<Scene> GBJPLMPFNNL(string KAJDLHPACAD, LoadSceneMode EILFKFKMPFC, bool OIBFECHFNCC, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x79BEC60", Offset = "0x79BE060", VA = "0x1879BEC60")]
	private static void PNAMOLLJJJB(SceneInstance JHHLONNMNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x79BDA20", Offset = "0x79BCE20", VA = "0x1879BDA20")]
	private static void FAIGNAOPGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x79BE130", Offset = "0x79BD530", VA = "0x1879BE130")]
	[AsyncStateMachine(typeof(DBJEJIPIHJB))]
	private static Task<Scene> GFMABCDFAJO(string KAJDLHPACAD, LoadSceneMode EILFKFKMPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x79BE880", Offset = "0x79BDC80", VA = "0x1879BE880")]
	private static bool JPNGPAGCHNM(string KAJDLHPACAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x79BE660", Offset = "0x79BDA60", VA = "0x1879BE660")]
	[AsyncStateMachine(typeof(FLPEKJHNBIH))]
	private static Task<Scene> JDGDCPHLPCD(LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x79BDFB0", Offset = "0x79BD3B0", VA = "0x1879BDFB0")]
	public static AMMGOODCICE<Scene> GDLHGGLMHMF(string KAJDLHPACAD, LoadSceneMode EILFKFKMPFC = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x79BD4D0", Offset = "0x79BC8D0", VA = "0x1879BD4D0")]
	public static CLHPIMOBJFN CIHICHEAFJN(string KAJDLHPACAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x79BEBD0", Offset = "0x79BDFD0", VA = "0x1879BEBD0")]
	[IteratorStateMachine(typeof(JHHIGLNLOPE))]
	private static IEnumerator<ONHNFKGBFKG> PKJLCAEBPPG(string KAJDLHPACAD, FPFCPNKOFAP BPALDLBIAEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x79BE5C0", Offset = "0x79BD9C0", VA = "0x1879BE5C0")]
	[IteratorStateMachine(typeof(COEGNGDHBNC))]
	private static IEnumerator<ONHNFKGBFKG> IHMKMDNHGJM(string KAJDLHPACAD, LoadSceneMode EILFKFKMPFC, ECGKMFIAIBN<Scene> BPALDLBIAEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x79BE970", Offset = "0x79BDD70", VA = "0x1879BE970")]
	public static bool KNLFMJLGPGA([Out] string CCFMJJLLCGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class BICKEABGKPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x79A73D0", Offset = "0x79A67D0", VA = "0x1879A73D0")]
	public static IDisposable ECECAPMPKNB(this BHKHEGBAOJA NOIHGGNEIML, float PHNOLJCBKCA, Action<float> JDCAHNFKMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x79A7350", Offset = "0x79A6750", VA = "0x1879A7350")]
	public static IDisposable CBICKLPOAPM(this BHKHEGBAOJA NOIHGGNEIML, Action<float> JDCAHNFKMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x79A7460", Offset = "0x79A6860", VA = "0x1879A7460")]
	public static IDisposable HKIPLFNJNKM(this BHKHEGBAOJA NOIHGGNEIML, Action<float> JDCAHNFKMED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class BCEMAECMEEB
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2DBED70", Offset = "0x2DBE170", VA = "0x182DBED70")]
	[FOBDFEPIDIE]
	public static IDisposable GDGCDIOKFLF<T>(this T KJJAJBPPHOF, Action JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2DBEF20", Offset = "0x2DBE320", VA = "0x182DBEF20")]
	[FOBDFEPIDIE]
	public static IDisposable GDGCDIOKFLF<T>(this T KJJAJBPPHOF, Action<float> JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2DBEB20", Offset = "0x2DBDF20", VA = "0x182DBEB20")]
	[FOBDFEPIDIE]
	public static IDisposable BFLBMILJDBK<T>(this T KJJAJBPPHOF, Action JDCAHNFKMED, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2DBEBC0", Offset = "0x2DBDFC0", VA = "0x182DBEBC0")]
	[FOBDFEPIDIE]
	public static IDisposable DKFJJNBLCMC<T>(this T KJJAJBPPHOF, Action JDCAHNFKMED, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2DBEBC0", Offset = "0x2DBDFC0", VA = "0x182DBEBC0")]
	[FOBDFEPIDIE]
	public static IDisposable DKFJJNBLCMC<T>(this T KJJAJBPPHOF, Action<float> JDCAHNFKMED, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2DBF3F0", Offset = "0x2DBE7F0", VA = "0x182DBF3F0")]
	[FOBDFEPIDIE]
	public static IDisposable LFALGCPAJAK<T>(this T KJJAJBPPHOF, Action JDCAHNFKMED, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2DBEC70", Offset = "0x2DBE070", VA = "0x182DBEC70")]
	[FOBDFEPIDIE]
	public static IDisposable EJNAGNCDACA<T>(this T KJJAJBPPHOF, Action JDCAHNFKMED, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2DBEAD0", Offset = "0x2DBDED0", VA = "0x182DBEAD0")]
	[FOBDFEPIDIE]
	public static IDisposable ALJAKFGHPLB<T>(this T KJJAJBPPHOF, Action JDCAHNFKMED, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2DBF550", Offset = "0x2DBE950", VA = "0x182DBF550")]
	[FOBDFEPIDIE]
	public static IDisposable OBJIKOJKNIJ<T>(this T KJJAJBPPHOF, float PHNOLJCBKCA, Action<float> JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x79A6450", Offset = "0x79A5850", VA = "0x1879A6450")]
	[FOBDFEPIDIE]
	public static IDisposable OBJIKOJKNIJ(this MonoBehaviour KJJAJBPPHOF, FAMNLLOHBEJ NOIHGGNEIML, float PHNOLJCBKCA, Action<float> JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2DBF250", Offset = "0x2DBE650", VA = "0x182DBF250")]
	[FOBDFEPIDIE]
	public static IDisposable KOJFFLAIPGE<T>(this T KJJAJBPPHOF, float PHNOLJCBKCA, Action<float> JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2DBF440", Offset = "0x2DBE840", VA = "0x182DBF440")]
	[FOBDFEPIDIE]
	public static IDisposable LKHBKIGOINJ<T>(this T KJJAJBPPHOF, float PHNOLJCBKCA, Action<float> JDCAHNFKMED, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2DBEB60", Offset = "0x2DBDF60", VA = "0x182DBEB60")]
	[FOBDFEPIDIE]
	public static IDisposable CEFBGJBKJLL<T>(this T KJJAJBPPHOF, Action<float> JDCAHNFKMED, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2DBF190", Offset = "0x2DBE590", VA = "0x182DBF190")]
	[FOBDFEPIDIE]
	public static IDisposable JGLALMDCNPH<T>(this T KJJAJBPPHOF, Action<float> JDCAHNFKMED, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2DBF130", Offset = "0x2DBE530", VA = "0x182DBF130")]
	[FOBDFEPIDIE]
	public static IDisposable ILKOKAOCJPM<T>(this T KJJAJBPPHOF, Action<float> JDCAHNFKMED, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2DBF0D0", Offset = "0x2DBE4D0", VA = "0x182DBF0D0")]
	[FOBDFEPIDIE]
	public static IDisposable HGNEPEMIDCI<T>(this T KJJAJBPPHOF, Action<float> JDCAHNFKMED, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2DBF4F0", Offset = "0x2DBE8F0", VA = "0x182DBF4F0")]
	[FOBDFEPIDIE]
	public static IDisposable MKMCONEBNNI<T>(this T KJJAJBPPHOF, Action<float> JDCAHNFKMED, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2DBEC10", Offset = "0x2DBE010", VA = "0x182DBEC10")]
	[FOBDFEPIDIE]
	public static IDisposable EAEEMFCBEIG<T>(this T KJJAJBPPHOF, Action<float> JDCAHNFKMED, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2DBF1F0", Offset = "0x2DBE5F0", VA = "0x182DBF1F0")]
	[FOBDFEPIDIE]
	public static IDisposable JLLPBPGNJGL<T>(this T KJJAJBPPHOF, Action<float> JDCAHNFKMED, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2DBED20", Offset = "0x2DBE120", VA = "0x182DBED20")]
	[FOBDFEPIDIE]
	public static IDisposable GBPMEOEHHGK<T>(this T KJJAJBPPHOF, float PHNOLJCBKCA, Action<float> JDCAHNFKMED, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2DBF490", Offset = "0x2DBE890", VA = "0x182DBF490")]
	[FOBDFEPIDIE]
	public static IDisposable LLNLPHLJCJO<T>(this T KJJAJBPPHOF, Action<float> JDCAHNFKMED, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2DBECC0", Offset = "0x2DBE0C0", VA = "0x182DBECC0")]
	[FOBDFEPIDIE]
	public static IDisposable FBBAAIDAEAN<T>(this T KJJAJBPPHOF, Action<float> JDCAHNFKMED, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true) where T : MonoBehaviour, FAMNLLOHBEJ
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class HFECNMAEKPH
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class FLHELFNJDOC : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public JOFMHFKJPEL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private LNNOFDEDDNG <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public FLHELFNJDOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x79B0CB0", Offset = "0x79B00B0", VA = "0x1879B0CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x79B0D90", Offset = "0x79B0190", VA = "0x1879B0D90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class EIELHNIKOCE : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public JOFMHFKJPEL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private LNNOFDEDDNG <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public EIELHNIKOCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x79AF690", Offset = "0x79AEA90", VA = "0x1879AF690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x79AF780", Offset = "0x79AEB80", VA = "0x1879AF780", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x79B4B40", Offset = "0x79B3F40", VA = "0x1879B4B40")]
	public static GLHJGEGNDCM GDGCDIOKFLF(Action JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x79B4BC0", Offset = "0x79B3FC0", VA = "0x1879B4BC0")]
	public static GLHJGEGNDCM GDGCDIOKFLF(Behaviour NOIHGGNEIML, Action JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x79B4C50", Offset = "0x79B4050", VA = "0x1879B4C50")]
	public static GLHJGEGNDCM GDGCDIOKFLF(Behaviour NOIHGGNEIML, Action<float> JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x79B4DC0", Offset = "0x79B41C0", VA = "0x1879B4DC0")]
	[IteratorStateMachine(typeof(FLHELFNJDOC))]
	private static IEnumerator<ONHNFKGBFKG> OODHODMAKFB(JOFMHFKJPEL HPNGDCNNMDL, Action JDCAHNFKMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x79B4D30", Offset = "0x79B4130", VA = "0x1879B4D30")]
	[IteratorStateMachine(typeof(EIELHNIKOCE))]
	private static IEnumerator<ONHNFKGBFKG> OODHODMAKFB(JOFMHFKJPEL HPNGDCNNMDL, Action<float> JDCAHNFKMED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class LFDJFDMAIMK : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class FIDFGJMAJDD : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public LFDJFDMAIMK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public FIDFGJMAJDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x79B03E0", Offset = "0x79AF7E0", VA = "0x1879B03E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x79B0470", Offset = "0x79AF870", VA = "0x1879B0470", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly JOFMHFKJPEL DEMMIJCLNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private Action NBICCJJJCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool OJNGAFLENBE;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool FAEOCLAAIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8D0DA0", Offset = "0x8D01A0", VA = "0x1808D0DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x79B98B0", Offset = "0x79B8CB0", VA = "0x1879B98B0")]
	public LFDJFDMAIMK(JOFMHFKJPEL DEMMIJCLNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x79B9790", Offset = "0x79B8B90", VA = "0x1879B9790")]
	[IteratorStateMachine(typeof(FIDFGJMAJDD))]
	private IEnumerator<ONHNFKGBFKG> MJOIFCHDOAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x79B9810", Offset = "0x79B8C10", VA = "0x1879B9810", Slot = "4")]
	public void OnCompleted(Action NEJOBNCNOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
	public void EIHPDKCBJJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class GLLOPFJOGAM
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x79B3A00", Offset = "0x79B2E00", VA = "0x1879B3A00")]
	public static LFDJFDMAIMK PFIDLIKIIJL(this JOFMHFKJPEL DEMMIJCLNKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class KPAFNFGJIFG
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class OGGOOMNFLLD : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public DDBLHKMFNPO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public OGGOOMNFLLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x79BF960", Offset = "0x79BED60", VA = "0x1879BF960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x79BF9E0", Offset = "0x79BEDE0", VA = "0x1879BF9E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x79B91D0", Offset = "0x79B85D0", VA = "0x1879B91D0")]
	public static GLHJGEGNDCM GDGCDIOKFLF(float PHNOLJCBKCA, Action<float> JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO, bool LONOOJFMJMM = true, [Optional] OKKMFOFDAFG PGOFEEGHHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x79B9100", Offset = "0x79B8500", VA = "0x1879B9100")]
	public static GLHJGEGNDCM GDGCDIOKFLF(MonoBehaviour KJJAJBPPHOF, float PHNOLJCBKCA, Action<float> JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO, bool LONOOJFMJMM = true, [Optional] OKKMFOFDAFG PGOFEEGHHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x79B9010", Offset = "0x79B8410", VA = "0x1879B9010")]
	public static GLHJGEGNDCM EDKFIFHJGLE(MonoBehaviour KJJAJBPPHOF, float PHNOLJCBKCA, Action<float> JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO, bool LONOOJFMJMM = true, [Optional] OKKMFOFDAFG PGOFEEGHHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x79B9330", Offset = "0x79B8730", VA = "0x1879B9330")]
	public static GLHJGEGNDCM HPOBILDKPBA(BHKHEGBAOJA NOIHGGNEIML, float PHNOLJCBKCA, Action<float> JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO, bool LONOOJFMJMM = true, [Optional] OKKMFOFDAFG PGOFEEGHHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x79B9400", Offset = "0x79B8800", VA = "0x1879B9400")]
	private static IEnumerator<ONHNFKGBFKG> OODHODMAKFB(ELFEPMKPDPN NOMOCDCCOCA, float PHNOLJCBKCA, JOFMHFKJPEL HPNGDCNNMDL, Action<float> JDCAHNFKMED, bool LONOOJFMJMM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x79B8FB0", Offset = "0x79B83B0", VA = "0x1879B8FB0")]
	private static IEnumerator<ONHNFKGBFKG> CHLFHBBIJDO(ELFEPMKPDPN NOMOCDCCOCA, float PHNOLJCBKCA, JOFMHFKJPEL HPNGDCNNMDL, Action<float> JDCAHNFKMED, bool LONOOJFMJMM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x79B92A0", Offset = "0x79B86A0", VA = "0x1879B92A0")]
	[IteratorStateMachine(typeof(OGGOOMNFLLD))]
	private static IEnumerator<ONHNFKGBFKG> HILPOENHNJC(DDBLHKMFNPO HDEMMKLHFKC, float PHNOLJCBKCA, JOFMHFKJPEL HPNGDCNNMDL, Action<float> JDCAHNFKMED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class EBKDELILJHA
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class FOOCPEAMKOI : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public JOFMHFKJPEL queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public FOOCPEAMKOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x79B32F0", Offset = "0x79B26F0", VA = "0x1879B32F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x79B33B0", Offset = "0x79B27B0", VA = "0x1879B33B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x79AF420", Offset = "0x79AE820", VA = "0x1879AF420")]
	[IteratorStateMachine(typeof(FOOCPEAMKOI))]
	private static IEnumerator<ONHNFKGBFKG> LAFCAGOAIIP(JOFMHFKJPEL DEMMIJCLNKO, Func<bool> CBJBNBNFEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x79AF340", Offset = "0x79AE740", VA = "0x1879AF340")]
	public static GLHJGEGNDCM APONANMMDCN(this MonoBehaviour KJJAJBPPHOF, Func<bool> CBJBNBNFEJE, JOFMHFKJPEL DEMMIJCLNKO = JOFMHFKJPEL.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class GNDEGALHMOK
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class CJCHBJBOBOD : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public JOFMHFKJPEL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public CJCHBJBOBOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x79A7B10", Offset = "0x79A6F10", VA = "0x1879A7B10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x79A7B80", Offset = "0x79A6F80", VA = "0x1879A7B80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class CPLKFGFFNHI<T> : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public JOFMHFKJPEL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public CPLKFGFFNHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x59FBBB0", Offset = "0x59FAFB0", VA = "0x1859FBBB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x59FBC50", Offset = "0x59FB050", VA = "0x1859FBC50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class OEMJGHDLLGO : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public JOFMHFKJPEL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private ONHNFKGBFKG <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public OEMJGHDLLGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x79BF750", Offset = "0x79BEB50", VA = "0x1879BF750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x79BF7E0", Offset = "0x79BEBE0", VA = "0x1879BF7E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x79B43A0", Offset = "0x79B37A0", VA = "0x1879B43A0")]
	[IteratorStateMachine(typeof(CJCHBJBOBOD))]
	private static IEnumerator<ONHNFKGBFKG> MJOIFCHDOAJ(float CHFBMMDLDCL, JOFMHFKJPEL HPNGDCNNMDL, Action BDEDHGPGIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x306EC90", Offset = "0x306E090", VA = "0x18306EC90")]
	[IteratorStateMachine(typeof(CPLKFGFFNHI<>))]
	private static IEnumerator<ONHNFKGBFKG> MJOIFCHDOAJ<T>(float CHFBMMDLDCL, JOFMHFKJPEL HPNGDCNNMDL, Action<T> BDEDHGPGIGH, T FJIKACGIPBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x79B3E10", Offset = "0x79B3210", VA = "0x1879B3E10")]
	[IteratorStateMachine(typeof(OEMJGHDLLGO))]
	private static IEnumerator<ONHNFKGBFKG> FHOCOCPLBKB(float CHFBMMDLDCL, JOFMHFKJPEL HPNGDCNNMDL, Action BDEDHGPGIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x79B3BA0", Offset = "0x79B2FA0", VA = "0x1879B3BA0")]
	public static IDisposable EPDPCFLGHIP(this MonoBehaviour KJJAJBPPHOF, float CHFBMMDLDCL, Action BDEDHGPGIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x79B3B10", Offset = "0x79B2F10", VA = "0x1879B3B10")]
	public static GLHJGEGNDCM DKFOLODKBHL(this MonoBehaviour KJJAJBPPHOF, float CHFBMMDLDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x79B3C80", Offset = "0x79B3080", VA = "0x1879B3C80")]
	public static GLHJGEGNDCM EPDPCFLGHIP(this MonoBehaviour KJJAJBPPHOF, float CHFBMMDLDCL, JOFMHFKJPEL HPNGDCNNMDL, Action BDEDHGPGIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x79B4300", Offset = "0x79B3700", VA = "0x1879B4300")]
	public static GLHJGEGNDCM MCPBPOOHGJG(this MonoBehaviour KJJAJBPPHOF, Action BDEDHGPGIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x306EC40", Offset = "0x306E040", VA = "0x18306EC40")]
	public static GLHJGEGNDCM MCPBPOOHGJG<T>(this MonoBehaviour KJJAJBPPHOF, Action<T> BDEDHGPGIGH, T FJIKACGIPBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x79B4440", Offset = "0x79B3840", VA = "0x1879B4440")]
	public static GLHJGEGNDCM OABMDJPLDMO(this MonoBehaviour KJJAJBPPHOF, Action BDEDHGPGIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x79B3D70", Offset = "0x79B3170", VA = "0x1879B3D70")]
	public static GLHJGEGNDCM FGGGAFAEGNC(this MonoBehaviour KJJAJBPPHOF, Action BDEDHGPGIGH, [Optional] OKKMFOFDAFG PGOFEEGHHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x79B3F50", Offset = "0x79B3350", VA = "0x1879B3F50")]
	public static GLHJGEGNDCM GEFHCNEKHBD(this MonoBehaviour KJJAJBPPHOF, Action BDEDHGPGIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x79B3EB0", Offset = "0x79B32B0", VA = "0x1879B3EB0")]
	public static GLHJGEGNDCM FIPFEIPGHJB(this MonoBehaviour KJJAJBPPHOF, Action BDEDHGPGIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x79B3FF0", Offset = "0x79B33F0", VA = "0x1879B3FF0")]
	public static GLHJGEGNDCM HMLCBCLDLKP(MonoBehaviour KJJAJBPPHOF, JOFMHFKJPEL DEMMIJCLNKO, Action BDEDHGPGIGH, [Optional] OKKMFOFDAFG PGOFEEGHHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x306EB00", Offset = "0x306DF00", VA = "0x18306EB00")]
	public static GLHJGEGNDCM HMLCBCLDLKP<T>(MonoBehaviour KJJAJBPPHOF, JOFMHFKJPEL DEMMIJCLNKO, Action<T> BDEDHGPGIGH, T FJIKACGIPBH, [Optional] OKKMFOFDAFG PGOFEEGHHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x79B41D0", Offset = "0x79B35D0", VA = "0x1879B41D0")]
	public static GLHJGEGNDCM JIMPKAJEBJK(this MonoBehaviour KJJAJBPPHOF, float PIFJGPJCKAL, Action BDEDHGPGIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x79B4090", Offset = "0x79B3490", VA = "0x1879B4090")]
	public static GLHJGEGNDCM IBLAPGDEAJI(this MonoBehaviour KJJAJBPPHOF, float PIFJGPJCKAL, Action BDEDHGPGIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x79B4260", Offset = "0x79B3660", VA = "0x1879B4260")]
	public static GLHJGEGNDCM KDEKKMBGHML(this MonoBehaviour KJJAJBPPHOF, float PIFJGPJCKAL, Action BDEDHGPGIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x79B4130", Offset = "0x79B3530", VA = "0x1879B4130")]
	public static GLHJGEGNDCM IIHLIOCEIHJ(this MonoBehaviour KJJAJBPPHOF, float PIFJGPJCKAL, Action BDEDHGPGIGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class KLPKBNEHMLB : JNBOKINFKNI, IEnumerable<JNBOKINFKNI>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly List<JNBOKINFKNI> OFHFNFJBKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private bool EPGLPLGMHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Action NJIACCJHFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private bool AGEKPHBICLK;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool MECFPBAIGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x79B8A80", Offset = "0x79B7E80", VA = "0x1879B8A80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PINFOKLMFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x79B89E0", Offset = "0x79B7DE0", VA = "0x1879B89E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x79B8640", Offset = "0x79B7A40", VA = "0x1879B8640", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x79B8EC0", Offset = "0x79B82C0", VA = "0x1879B8EC0")]
	public KLPKBNEHMLB([Optional] Action NJIACCJHFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x79B86E0", Offset = "0x79B7AE0", VA = "0x1879B86E0")]
	public void EBDKDKCDLND(JNBOKINFKNI KHAFEADMMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x79B8810", Offset = "0x79B7C10", VA = "0x1879B8810")]
	private void EKOJHFPIGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x79B8EB0", Offset = "0x79B82B0", VA = "0x1879B8EB0", Slot = "7")]
	public bool OPEAAHCIBON(bool MKNFMGNFODH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x79B8BB0", Offset = "0x79B7FB0", VA = "0x1879B8BB0", Slot = "8")]
	public bool OPEAAHCIBON(Action OLHFOBIBHCJ, bool MKNFMGNFODH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x79B8960", Offset = "0x79B7D60", VA = "0x1879B8960", Slot = "9")]
	public IEnumerator<JNBOKINFKNI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x79B8960", Offset = "0x79B7D60", VA = "0x1879B8960", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class LIHMBKOKKJG : IBONGKKFIPN
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class JOCGANGOIMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public LIHMBKOKKJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JOCGANGOIMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x79A7AB0", Offset = "0x79A6EB0", VA = "0x1879A7AB0")]
		internal void CNDMCKIOLDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class BPPAMIBKKGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public LIHMBKOKKJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public BPPAMIBKKGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x79A7AB0", Offset = "0x79A6EB0", VA = "0x1879A7AB0")]
		internal void CHGHGHKNCHM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float ADNLBBNFOHA;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x79B9BA0", Offset = "0x79B8FA0", VA = "0x1879B9BA0")]
	public LIHMBKOKKJG(Behaviour NOIHGGNEIML, float ADNLBBNFOHA, [Optional] Action NJIACCJHFAL, [Optional] OKKMFOFDAFG PGOFEEGHHLF, [Optional] ELFEPMKPDPN NOMOCDCCOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x79B9980", Offset = "0x79B8D80", VA = "0x1879B9980", Slot = "9")]
	protected override bool BIBDKGLMKAC(Action OLHFOBIBHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x79B9A90", Offset = "0x79B8E90", VA = "0x1879B9A90", Slot = "10")]
	protected override bool DLNHHINELPP(Action OLHFOBIBHCJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface JNBOKINFKNI
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool MECFPBAIGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PINFOKLMFMJ;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OPEAAHCIBON(bool MKNFMGNFODH = false);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OPEAAHCIBON(Action OLHFOBIBHCJ, bool MKNFMGNFODH = false);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class IBONGKKFIPN : JNBOKINFKNI
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class MLKDCKPHNPA : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public IBONGKKFIPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public MLKDCKPHNPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x79BCA90", Offset = "0x79BBE90", VA = "0x1879BCA90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x79BCB60", Offset = "0x79BBF60", VA = "0x1879BCB60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly Behaviour NOIHGGNEIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly Action NJIACCJHFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private JNDAODDCIHF JDNGBDKMGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly OKKMFOFDAFG PGOFEEGHHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	protected readonly ELFEPMKPDPN NOMOCDCCOCA;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool MECFPBAIGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x127BFE0", Offset = "0x127B3E0", VA = "0x18127BFE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action PINFOKLMFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x79B6080", Offset = "0x79B5480", VA = "0x1879B6080", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x79B5CB0", Offset = "0x79B50B0", VA = "0x1879B5CB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x79B61E0", Offset = "0x79B55E0", VA = "0x1879B61E0")]
	protected IBONGKKFIPN(Behaviour NOIHGGNEIML, [Optional] Action NJIACCJHFAL, [Optional] OKKMFOFDAFG PGOFEEGHHLF, [Optional] ELFEPMKPDPN NOMOCDCCOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x79B6180", Offset = "0x79B5580", VA = "0x1879B6180", Slot = "7")]
	public bool OPEAAHCIBON(bool MKNFMGNFODH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x79B6120", Offset = "0x79B5520", VA = "0x1879B6120", Slot = "8")]
	public bool OPEAAHCIBON(Action OLHFOBIBHCJ, bool MKNFMGNFODH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool BIBDKGLMKAC(Action OLHFOBIBHCJ);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool DLNHHINELPP(Action OLHFOBIBHCJ);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x79B5DD0", Offset = "0x79B51D0", VA = "0x1879B5DD0")]
	protected void EPLFLNIKDPH(Action OLHFOBIBHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x79B5DF0", Offset = "0x79B51F0", VA = "0x1879B5DF0")]
	protected CLHPIMOBJFN GJIKGGAGBGC(float BOHBFCKDKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x79B5D50", Offset = "0x79B5150", VA = "0x1879B5D50")]
	private void BIKJPCLEHMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x79B5C20", Offset = "0x79B5020", VA = "0x1879B5C20")]
	[IteratorStateMachine(typeof(MLKDCKPHNPA))]
	private IEnumerator<ONHNFKGBFKG> AGLHEMGKALF(float BOHBFCKDKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x79B6040", Offset = "0x79B5440", VA = "0x1879B6040")]
	[CompilerGenerated]
	private void HCEAJBFLABB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class HOOLAKPNGCK : IBONGKKFIPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly float MDGMJJPMDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly int CJMNFMDINNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly float HJMICMNGEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly float[] FPNDBBHDDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int KFAFIFHDKOH;

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x79B59D0", Offset = "0x79B4DD0", VA = "0x1879B59D0")]
	public HOOLAKPNGCK(Behaviour NOIHGGNEIML, float KJFKGLAHINJ, int CJMNFMDINNC, [Optional] Action NJIACCJHFAL, float HJMICMNGEPB = 0f, [Optional] OKKMFOFDAFG PGOFEEGHHLF, [Optional] ELFEPMKPDPN NOMOCDCCOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "9")]
	protected override bool BIBDKGLMKAC(Action OLHFOBIBHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x79B5750", Offset = "0x79B4B50", VA = "0x1879B5750", Slot = "10")]
	protected override bool DLNHHINELPP(Action OLHFOBIBHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x79B5950", Offset = "0x79B4D50", VA = "0x1879B5950")]
	private void ONHPBDKAMFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class OHAPABNCIAO : IBONGKKFIPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly float ADNLBBNFOHA;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x79B9BA0", Offset = "0x79B8FA0", VA = "0x1879B9BA0")]
	public OHAPABNCIAO(Behaviour NOIHGGNEIML, float ADNLBBNFOHA, [Optional] Action NJIACCJHFAL, [Optional] OKKMFOFDAFG PGOFEEGHHLF, [Optional] ELFEPMKPDPN NOMOCDCCOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "9")]
	protected override bool BIBDKGLMKAC(Action OLHFOBIBHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x79BFA30", Offset = "0x79BEE30", VA = "0x1879BFA30", Slot = "10")]
	protected override bool DLNHHINELPP(Action OLHFOBIBHCJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class PMOHBBKOFAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class KMMNNOOHJMF : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public KMMNNOOHJMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x79B82B0", Offset = "0x79B76B0", VA = "0x1879B82B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x79B8F60", Offset = "0x79B8360", VA = "0x1879B8F60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private GLHJGEGNDCM KCBMKCEMGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private BHKHEGBAOJA NOIHGGNEIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private Action<float> OCFPLLKHMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private JOFMHFKJPEL DEMMIJCLNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private float ADCBLDEKDLK;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x79C1770", Offset = "0x79C0B70", VA = "0x1879C1770")]
	public PMOHBBKOFAB(BHKHEGBAOJA NOIHGGNEIML, float PHNOLJCBKCA, Action<float> JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x79C1450", Offset = "0x79C0850", VA = "0x1879C1450")]
	private void IEKCBGEODMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x79C1640", Offset = "0x79C0A40", VA = "0x1879C1640")]
	private void KFCPKKLFMCD(string PLAICKAFAFJ, Action AMHAHPKCBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x79C15C0", Offset = "0x79C09C0", VA = "0x1879C15C0")]
	[IteratorStateMachine(typeof(KMMNNOOHJMF))]
	private IEnumerator<ONHNFKGBFKG> IIFPCNFGDMJ(Action AMHAHPKCBFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x79C1270", Offset = "0x79C0670", VA = "0x1879C1270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x79C12D0", Offset = "0x79C06D0", VA = "0x1879C12D0")]
	[CompilerGenerated]
	private void ENFPCEAOCEM(string EAIPGJCIAMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public sealed class CLAHDBDOINL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class KKGHHINAMMC : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public KKGHHINAMMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x79B82B0", Offset = "0x79B76B0", VA = "0x1879B82B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x79B8320", Offset = "0x79B7720", VA = "0x1879B8320", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private GLHJGEGNDCM KCBMKCEMGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private MonoBehaviour KJJAJBPPHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Action JDCAHNFKMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private Action<float> OCFPLLKHMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private JOFMHFKJPEL DEMMIJCLNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private float ADCBLDEKDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool LONOOJFMJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly OKKMFOFDAFG PGOFEEGHHLF;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x79A89D0", Offset = "0x79A7DD0", VA = "0x1879A89D0")]
	public CLAHDBDOINL(MonoBehaviour KJJAJBPPHOF, Action JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO, [Optional] OKKMFOFDAFG PGOFEEGHHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x79A8800", Offset = "0x79A7C00", VA = "0x1879A8800")]
	public CLAHDBDOINL(MonoBehaviour KJJAJBPPHOF, Action<float> JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO, [Optional] OKKMFOFDAFG PGOFEEGHHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x79A8B60", Offset = "0x79A7F60", VA = "0x1879A8B60")]
	public CLAHDBDOINL(MonoBehaviour KJJAJBPPHOF, float PHNOLJCBKCA, Action<float> JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO, bool LONOOJFMJMM = true, [Optional] OKKMFOFDAFG PGOFEEGHHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x9ADC90", Offset = "0x9AD090", VA = "0x1809ADC90")]
	private CLAHDBDOINL(OKKMFOFDAFG PGOFEEGHHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x79A7BD0", Offset = "0x79A6FD0", VA = "0x1879A7BD0")]
	internal static CLAHDBDOINL ACMOPPEBEIH(MonoBehaviour KJJAJBPPHOF, float PHNOLJCBKCA, Action<float> JDCAHNFKMED, JOFMHFKJPEL DEMMIJCLNKO, bool LONOOJFMJMM = true, [Optional] OKKMFOFDAFG PGOFEEGHHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x79A7FE0", Offset = "0x79A73E0", VA = "0x1879A7FE0")]
	private void GDGCDIOKFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x79A7E60", Offset = "0x79A7260", VA = "0x1879A7E60")]
	private void GCLAEFBANNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x79A8110", Offset = "0x79A7510", VA = "0x1879A8110")]
	private void IEKCBGEODMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x79A8670", Offset = "0x79A7A70", VA = "0x1879A8670")]
	private void PCPDEHOFGOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x79A8300", Offset = "0x79A7700", VA = "0x1879A8300")]
	private void KFCPKKLFMCD(string PLAICKAFAFJ, Action AMHAHPKCBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x79A8280", Offset = "0x79A7680", VA = "0x1879A8280")]
	[IteratorStateMachine(typeof(KKGHHINAMMC))]
	private IEnumerator<ONHNFKGBFKG> IIFPCNFGDMJ(Action AMHAHPKCBFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x79A7E00", Offset = "0x79A7200", VA = "0x1879A7E00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x79A8550", Offset = "0x79A7950", VA = "0x1879A8550")]
	[CompilerGenerated]
	private void NFDIJGBBPBK(string EAIPGJCIAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x79A8430", Offset = "0x79A7830", VA = "0x1879A8430")]
	[CompilerGenerated]
	private void LGLBOJAGNDE(string EAIPGJCIAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x79A84C0", Offset = "0x79A78C0", VA = "0x1879A84C0")]
	[CompilerGenerated]
	private void MKKCIHOKKDL(string EAIPGJCIAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x79A85E0", Offset = "0x79A79E0", VA = "0x1879A85E0")]
	[CompilerGenerated]
	private void OOJJOGINCEL(string EAIPGJCIAMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[Flags]
internal enum MNCHJILGKKK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class HMGGMKNFOLM : ELFEPMKPDPN
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float LANPKEHMLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x79B5590", Offset = "0x79B4990", VA = "0x1879B5590", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public float GIMKNHOHEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x79B55A0", Offset = "0x79B49A0", VA = "0x1879B55A0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public double MIHEGMEDMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x79B5570", Offset = "0x79B4970", VA = "0x1879B5570", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x79B5500", Offset = "0x79B4900", VA = "0x1879B5500")]
	[AGCFNMIICNN.OGAOPBBDHOG]
	internal static void BMOABOOGHNH(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	[UnityEngine.Scripting.Preserve]
	internal HMGGMKNFOLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal interface EKJHNNKOBAL
{
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCPLPHJBIOD(string LJAGHAHCFHJ);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAGFCCAAPII();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal interface OCLNBPPAODP
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string DKCJKHANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool LEGHPMGIPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool DOFEHGDOEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal class KBAPLAPADJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public MAIHAKFGDJP MDNFGCPHPCM;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int MCCLHKLCIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D2190", VA = "0x1808D2D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x79B7E80", Offset = "0x79B7280", VA = "0x1879B7E80")]
	public static ONHNFKGBFKG LLDLEJBBJMJ(IEnumerator<ONHNFKGBFKG> JKOPAHPKBDN, AGKKANCOKDA JLLOAJKMIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x79B7FE0", Offset = "0x79B73E0", VA = "0x1879B7FE0")]
	public ONHNFKGBFKG LLDLEJBBJMJ(AGKKANCOKDA[] HGEBNBIJEGO, IEnumerator<ONHNFKGBFKG>[] IIIFHALAMFO, ONHNFKGBFKG[] LPILMPGCMOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x79B7D10", Offset = "0x79B7110", VA = "0x1879B7D10")]
	public void DHNHPILDLDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x79B7D40", Offset = "0x79B7140", VA = "0x1879B7D40")]
	public void HHAAPJOJLMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x79B7BD0", Offset = "0x79B6FD0", VA = "0x1879B7BD0")]
	public void BFFDNKAEDKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x79B7D10", Offset = "0x79B7110", VA = "0x1879B7D10")]
	public void MCJPJJDIODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public KBAPLAPADJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal sealed class MAIHAKFGDJP
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct PMMHINJOLLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public KBAPLAPADJK OFDBIDPCJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public BHKHEGBAOJA NLOFPLJHNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public AGKKANCOKDA BPGDDNEJNGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public IEnumerator<ONHNFKGBFKG> EPMANJICKLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public ONHNFKGBFKG GHGLGHEIEAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public MNCHJILGKKK BJCJEBCEMPA;
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct FFDLCFFEPJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public JOFMHFKJPEL KGJDDLJAIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public List<PMMHINJOLLK> OFCJNPDDDKB;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class OCOGGGIMPEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public AGKKANCOKDA promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public MAIHAKFGDJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public BHKHEGBAOJA context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public KBAPLAPADJK routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public MNCHJILGKKK coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public ONHNFKGBFKG currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public IEnumerator<ONHNFKGBFKG> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public OCOGGGIMPEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x79BEF80", Offset = "0x79BE380", VA = "0x1879BEF80")]
		internal void DGHMLJAOCFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class GHCMAPEHMMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public KBAPLAPADJK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public MAIHAKFGDJP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GHCMAPEHMMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x79B39C0", Offset = "0x79B2DC0", VA = "0x1879B39C0")]
		internal void ICJNMKJBKPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class IOCFMMEEMDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public KBAPLAPADJK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public MAIHAKFGDJP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public IOCFMMEEMDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x79B7300", Offset = "0x79B6700", VA = "0x1879B7300")]
		internal void LMBOPJBJMKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class ADKKGDCBMDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public KBAPLAPADJK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public MAIHAKFGDJP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public ADKKGDCBMDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x79A6080", Offset = "0x79A5480", VA = "0x1879A6080")]
		internal void EDMGIHDDMDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const MNCHJILGKKK PCEIJHMCJAD = MNCHJILGKKK.Cancelled | MNCHJILGKKK.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly JOFMHFKJPEL DEMMIJCLNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private bool[] DHNHJNGFIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private NativeArray<MNCHJILGKKK> IFHBHAEIIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private NativeArray<float> NKDOEPNGBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private NativeArray<int> CGDHPIDOKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private NativeArray<int> OLJIAOLCCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private NativeArray<int> JIFFEMPIIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private NativeArray<int> PDEGDJLKMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private NativeArray<int> IHBOMNELOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private KBAPLAPADJK[] LLEBEOHBFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private AGKKANCOKDA[] HGEBNBIJEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private BHKHEGBAOJA[] JMKDBFEBEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private IEnumerator<ONHNFKGBFKG>[] EDPAAGCICJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private ONHNFKGBFKG[] HDOPEGBJKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private int NKFNAAOOFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private int GNOHMAFCFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly int FDBBIFPCBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private float DJIMOLBNOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private MOLHNEBLNFM AONICLCKANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private JobHandle JOGIEJKLJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private List<KBAPLAPADJK> DELDIPPLCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private bool MGHHNIFPFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private List<Action> PHKMMMFDOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private List<Action> PGFKOGGIEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private bool MLOFBNBBKBK;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public FFDLCFFEPJP[] COIEDFFHCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xADF7C0", Offset = "0xADEBC0", VA = "0x180ADF7C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x79BB820", Offset = "0x79BAC20", VA = "0x1879BB820")]
	private static int JOCCHGJKABH(JOFMHFKJPEL DEMMIJCLNKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x79BC260", Offset = "0x79BB660", VA = "0x1879BC260")]
	public MAIHAKFGDJP(JOFMHFKJPEL DEMMIJCLNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x79BC080", Offset = "0x79BB480", VA = "0x1879BC080")]
	private void PMLKPLDMGCE(int NBDGNKGNOCH, int ANJOCGBBLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x79B9ED0", Offset = "0x79B92D0", VA = "0x1879B9ED0")]
	public void AHDHJKLJDPO(BHKHEGBAOJA NOIHGGNEIML, ONHNFKGBFKG IJHLFDPMKOB, IEnumerator<ONHNFKGBFKG> JKOPAHPKBDN, AGKKANCOKDA JLLOAJKMIBO, [Optional] KBAPLAPADJK LIEEBBBGGMM, MNCHJILGKKK CAPPNIEGAMI = MNCHJILGKKK.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x79BABC0", Offset = "0x79B9FC0", VA = "0x1879BABC0")]
	public void FOCPHFOBPNF(IEnumerable<PMMHINJOLLK> HPEBOHKKGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x79BBA00", Offset = "0x79BAE00", VA = "0x1879BBA00")]
	private PMMHINJOLLK NMIKONIGDEK(int BKGEKKDPMAF)
	{
		return default(PMMHINJOLLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x79BA2B0", Offset = "0x79B96B0", VA = "0x1879BA2B0")]
	private void CKFHHFKNGNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x312E370", Offset = "0x312D770", VA = "0x18312E370")]
	private static void PJNHICNBMDD<T>(int BKGEKKDPMAF, T[] LDJACACIIDC, int BGDDCGNLDBK, [Optional] T LHGCLGJBKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x312E3C0", Offset = "0x312D7C0", VA = "0x18312E3C0")]
	private static void PJNHICNBMDD<T>(int BKGEKKDPMAF, NativeArray<T> LDJACACIIDC, int BGDDCGNLDBK, [Optional] T LHGCLGJBKHD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x79BA820", Offset = "0x79B9C20", VA = "0x1879BA820")]
	private void DONPELMGAOJ(IEnumerable<PMMHINJOLLK> HPEBOHKKGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x79BA750", Offset = "0x79B9B50", VA = "0x1879BA750")]
	private void DHECFAGJEJN(PMMHINJOLLK JKADHGIMENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x79BA050", Offset = "0x79B9450", VA = "0x1879BA050")]
	private IMNHOEOOMMI CGHMPEJHLAC(int NLMABPGFNIP)
	{
		return default(IMNHOEOOMMI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x79BAF00", Offset = "0x79BA300", VA = "0x1879BAF00")]
	public void GNOFEPMMANN(float EKLCEMNAMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x79BB980", Offset = "0x79BAD80", VA = "0x1879BB980")]
	private void NGBGPHPKPIF(Action DDIIBBHFODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x79BC000", Offset = "0x79BB400", VA = "0x1879BC000")]
	private void PFCBHGGKCOH(Action DDIIBBHFODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x79BB100", Offset = "0x79BA500", VA = "0x1879BB100")]
	public void HDFOFOFKCIH(float EKLCEMNAMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x79BAE00", Offset = "0x79BA200", VA = "0x1879BAE00")]
	public void GMPAFBLCGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x79BB850", Offset = "0x79BAC50", VA = "0x1879BB850")]
	public void MCJPJJDIODB(KBAPLAPADJK HDEMMKLHFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x79BA620", Offset = "0x79B9A20", VA = "0x1879BA620")]
	public void DAGFCEHLGGD(KBAPLAPADJK HDEMMKLHFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x79BBED0", Offset = "0x79BB2D0", VA = "0x1879BBED0")]
	public void PDOCBLLAFDD(KBAPLAPADJK HDEMMKLHFKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class GAFGJBIPDGL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static readonly GAFGJBIPDGL MGEHKGIFIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly Action EHPPLAMIOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private bool NDHHFMKHGIO;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public GAFGJBIPDGL(Action EHPPLAMIOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x70F7B90", Offset = "0x70F6F90", VA = "0x1870F7B90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface FBABKCKDAMN<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	T GFHLLJBPNAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable EADOMNLEEHL(UnityEngine.Object NOIHGGNEIML, Action<T> MOGHHEIEGNN);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface AFEAIAGCKPK<T> : FBABKCKDAMN<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	new T GFHLLJBPNAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class ENOGBBNNGHM<T> : AFEAIAGCKPK<T>, FBABKCKDAMN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class LPKBGJHLFJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ENOGBBNNGHM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public LHJFFEAKJBK<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public LPKBGJHLFJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x47EF9B0", Offset = "0x47EEDB0", VA = "0x1847EF9B0")]
		internal void KGHMLKCELHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private static GameObject JLKBHOGCNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly List<LHJFFEAKJBK<UnityEngine.Object, Action<T>>> LOJBDEKCMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private T FLDIFBEDGFP;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public T GFHLLJBPNAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x96F330", Offset = "0x96E730", VA = "0x18096F330", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3CE14A0", Offset = "0x3CE08A0", VA = "0x183CE14A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3CE13D0", Offset = "0x3CE07D0", VA = "0x183CE13D0")]
	private static bool AOENCINKFDF(T DDIIBBHFODJ, T BCCGANGEINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3CE2100", Offset = "0x3CE1500", VA = "0x183CE2100")]
	public ENOGBBNNGHM(T AJCHDCGIEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1610", Offset = "0x3CE0A10", VA = "0x183CE1610", Slot = "6")]
	public IDisposable EADOMNLEEHL(UnityEngine.Object NOIHGGNEIML, Action<T> MOGHHEIEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1990", Offset = "0x3CE0D90", VA = "0x183CE1990")]
	private void KLHJGCEHJKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal class CMHOFBNJIIE : ACBNJEPHHPC
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private class PDICNJKCPIH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		private class ELGBFMFFDDJ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			private int LPMIIFILJPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			private PDICNJKCPIH HPNGDCNNMDL;

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xAE6D30", Offset = "0xAE6130", VA = "0x180AE6D30")]
			public ELGBFMFFDDJ(int LPMIIFILJPI, PDICNJKCPIH HPNGDCNNMDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x79AF7D0", Offset = "0x79AEBD0", VA = "0x1879AF7D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class HMJNFPAPENE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public HMJNFPAPENE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7E0", Offset = "0xA4CBE0", VA = "0x180A4D7E0")]
			internal bool MBNHMPLKBLF(HGMDFBFDNAC e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class ICJEKKOMIKL : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			private ONHNFKGBFKG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public PDICNJKCPIH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public ELFEPMKPDPN timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			private LNNOFDEDDNG <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			private List<HGMDFBFDNAC> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EF")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F1")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
			[DebuggerHidden]
			public ICJEKKOMIKL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x79B6310", Offset = "0x79B5710", VA = "0x1879B6310", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x79B66A0", Offset = "0x79B5AA0", VA = "0x1879B66A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private readonly JOFMHFKJPEL DEMMIJCLNKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private GLHJGEGNDCM JLLOAJKMIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private bool BFNEBHLGHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private readonly List<HGMDFBFDNAC> LBOKCPIBOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private readonly HashSet<int> BCALEALCPHA;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x79C0A90", Offset = "0x79BFE90", VA = "0x1879C0A90")]
		public PDICNJKCPIH(JOFMHFKJPEL DEMMIJCLNKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x79C06E0", Offset = "0x79BFAE0", VA = "0x1879C06E0")]
		public IDisposable GOCOKFLHHNL(HGMDFBFDNAC MJJHFJIJMFP, OKKMFOFDAFG PGOFEEGHHLF, ELFEPMKPDPN HIKLLEDALJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x79C0870", Offset = "0x79BFC70", VA = "0x1879C0870")]
		private void OLNMDDIMELK(int LPMIIFILJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x79C0A00", Offset = "0x79BFE00", VA = "0x1879C0A00")]
		[IteratorStateMachine(typeof(ICJEKKOMIKL))]
		private IEnumerator<ONHNFKGBFKG> OODHODMAKFB(ELFEPMKPDPN HIKLLEDALJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x79C0690", Offset = "0x79BFA90", VA = "0x1879C0690", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private class HGMDFBFDNAC
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public enum IPEGEDGOFEK : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static int DKKPKGLFLBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public readonly int ODDAFMAOMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public readonly FAMNLLOHBEJ NLOFPLJHNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly MonoBehaviour FKFHGKIPPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public readonly Action BFLBMILJDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public readonly Action<float> DKNBONMANKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public readonly float CDFDINKNIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public float NKDOEPNGBBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public readonly string DKCJKHANLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public readonly bool FMKJCFEDIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public readonly IPEGEDGOFEK AGMIIFKDNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public bool CBKJJDNOBFP;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x79B5020", Offset = "0x79B4420", VA = "0x1879B5020")]
		public HGMDFBFDNAC(FAMNLLOHBEJ NOIHGGNEIML, Action JDCAHNFKMED, bool IPFKHBEELDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x79B5380", Offset = "0x79B4780", VA = "0x1879B5380")]
		public HGMDFBFDNAC(FAMNLLOHBEJ NOIHGGNEIML, Action<float> JDCAHNFKMED, bool IPFKHBEELDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x79B51A0", Offset = "0x79B45A0", VA = "0x1879B51A0")]
		public HGMDFBFDNAC(FAMNLLOHBEJ NOIHGGNEIML, float PHNOLJCBKCA, Action<float> JDCAHNFKMED, ELFEPMKPDPN HIKLLEDALJM, IPEGEDGOFEK NNEONIAJBJH, bool LONOOJFMJMM, bool IPFKHBEELDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x79B4E50", Offset = "0x79B4250", VA = "0x1879B4E50")]
		public bool IPOBPOGGKAD(float HCHBEBADBKN, float LDKAJOKKAHP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly OKKMFOFDAFG PGOFEEGHHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly ELFEPMKPDPN NOMOCDCCOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly Dictionary<JOFMHFKJPEL, PDICNJKCPIH> KNKDHIBFJNI;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x79A93E0", Offset = "0x79A87E0", VA = "0x1879A93E0")]
	[AGCFNMIICNN.OGAOPBBDHOG]
	internal static void IFEFEJGOPHK(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x79A9860", Offset = "0x79A8C60", VA = "0x1879A9860")]
	[UnityEngine.Scripting.Preserve]
	internal CMHOFBNJIIE([CNGCCDLPGOD(null)] OKKMFOFDAFG PGOFEEGHHLF, [CNGCCDLPGOD(null)] ELFEPMKPDPN NOMOCDCCOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x79A8F30", Offset = "0x79A8330", VA = "0x1879A8F30", Slot = "4")]
	public IDisposable BFLBMILJDBK(FAMNLLOHBEJ NOIHGGNEIML, Action CPIKECCHPBJ, JOFMHFKJPEL DEMMIJCLNKO, bool IPFKHBEELDN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x79A8D40", Offset = "0x79A8140", VA = "0x1879A8D40", Slot = "5")]
	public IDisposable BFLBMILJDBK(FAMNLLOHBEJ NOIHGGNEIML, Action<float> CPIKECCHPBJ, JOFMHFKJPEL DEMMIJCLNKO, bool IPFKHBEELDN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x79A9450", Offset = "0x79A8850", VA = "0x1879A9450", Slot = "7")]
	public IDisposable LKHBKIGOINJ(FAMNLLOHBEJ NOIHGGNEIML, float PHNOLJCBKCA, Action<float> CPIKECCHPBJ, JOFMHFKJPEL DEMMIJCLNKO, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x79A92E0", Offset = "0x79A86E0", VA = "0x1879A92E0", Slot = "8")]
	public IDisposable HMCJIEKAAJO(FAMNLLOHBEJ NOIHGGNEIML, float PHNOLJCBKCA, Action<float> CPIKECCHPBJ, JOFMHFKJPEL DEMMIJCLNKO, bool LONOOJFMJMM = true, bool IPFKHBEELDN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x79A9550", Offset = "0x79A8950", VA = "0x1879A9550", Slot = "6")]
	public IDisposable LKHBKIGOINJ(float PHNOLJCBKCA, Action<float> CPIKECCHPBJ, bool LONOOJFMJMM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x79A9120", Offset = "0x79A8520", VA = "0x1879A9120", Slot = "9")]
	public void CALNFFOLFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x79A96D0", Offset = "0x79A8AD0", VA = "0x1879A96D0")]
	private PDICNJKCPIH OIHKEOOHCGA(JOFMHFKJPEL DEMMIJCLNKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class BEIGBMHAGOA : ACHJEIJOLPH, OKKMFOFDAFG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private MAIHAKFGDJP[] IOAIOMPJIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private EKJHNNKOBAL CAFFODKDJOO;

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x79A67A0", Offset = "0x79A5BA0", VA = "0x1879A67A0")]
	[AGCFNMIICNN.OGAOPBBDHOG]
	internal static void BMOABOOGHNH(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x79A7290", Offset = "0x79A6690", VA = "0x1879A7290")]
	[UnityEngine.Scripting.Preserve]
	public BEIGBMHAGOA([CNGCCDLPGOD(null)] MJDFBCKNNCA PLAIOLKGLDB, [CNGCCDLPGOD(null)] ELFEPMKPDPN NOMOCDCCOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x79A6F50", Offset = "0x79A6350", VA = "0x1879A6F50", Slot = "19")]
	public override GLHJGEGNDCM FHFEEAEMAAE(BHKHEGBAOJA NOIHGGNEIML, IEnumerator<ONHNFKGBFKG> NIAIFENAOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x79A6810", Offset = "0x79A5C10", VA = "0x1879A6810", Slot = "20")]
	public override void CALNFFOLFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x79A6AA0", Offset = "0x79A5EA0", VA = "0x1879A6AA0", Slot = "22")]
	public override void DDCAEPCMPCI(JOFMHFKJPEL DEMMIJCLNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x79A6630", Offset = "0x79A5A30", VA = "0x1879A6630", Slot = "21")]
	protected override void BFLBMILJDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x79A7140", Offset = "0x79A6540", VA = "0x1879A7140")]
	private MAIHAKFGDJP PAOKKNKFHBI(JOFMHFKJPEL IFBDJLKPHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x79A6CD0", Offset = "0x79A60D0", VA = "0x1879A6CD0", Slot = "23")]
	internal override OHFLOGIGMDB DEBFHIMKFBC(IEnumerator<ONHNFKGBFKG> NIAIFENAOND, Behaviour NOIHGGNEIML, AGKKANCOKDA JLLOAJKMIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x79A7080", Offset = "0x79A6480", VA = "0x1879A7080", Slot = "24")]
	internal override FMJPGOGIBAJ GBMPHAENMAG(JOFMHFKJPEL HPNGDCNNMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x79A7170", Offset = "0x79A6570", VA = "0x1879A7170")]
	private void PCHFMIIPKDM(MAIHAKFGDJP OMGMAGKCODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x79A6EF0", Offset = "0x79A62F0", VA = "0x1879A6EF0", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[BurstCompile]
internal struct MOLHNEBLNFM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[ReadOnly]
	public float ELAFGIPGLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	[ReadOnly]
	public int FDGCAJCKEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private NativeArray<int> CEGCKCPONEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private NativeArray<int> IMEJADDHIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private NativeArray<int> HBEBDMMEGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[ReadOnly]
	public NativeArray<MNCHJILGKKK> GOLBJDBBIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[ReadOnly]
	public NativeArray<float> AMEMGCCDJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	[WriteOnly]
	public NativeArray<int> JIFFEMPIIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	[WriteOnly]
	public NativeArray<int> CGDHPIDOKLE;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x79BCF80", Offset = "0x79BC380", VA = "0x1879BCF80")]
	public static MOLHNEBLNFM KOPOAAAOIOD(int LJLBLBBBPPG, float EKLCEMNAMKD, NativeArray<MNCHJILGKKK> DIBONLNOHDJ, NativeArray<float> GDCMLFJEPND, NativeArray<int> LBCJDFPODKM, NativeArray<int> CBJKIDCIBAP, NativeArray<int> BKJPNCMDEOC, NativeArray<int> IMEJADDHIBN, NativeArray<int> HBEBDMMEGPJ)
	{
		return default(MOLHNEBLNFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x79BCE60", Offset = "0x79BC260", VA = "0x1879BCE60", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x79BCF40", Offset = "0x79BC340", VA = "0x1879BCF40")]
	private bool IKNIINDNPGG(int IIACLAMOIEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x79BCFE0", Offset = "0x79BC3E0", VA = "0x1879BCFE0")]
	private void PCGOGDLKOGJ(NativeArray<int> GNNFCDHIMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x79BD250", Offset = "0x79BC650", VA = "0x1879BD250")]
	private int PPKMDPFLNOA(int HMPBICKBKMM, int AHAINNIEENO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x79BCD90", Offset = "0x79BC190", VA = "0x1879BCD90")]
	private void CKKFOEGIINJ(NativeArray<int> GNNFCDHIMHF, int DDEEKPOHLFO, int NOMFBHAJODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x79BD010", Offset = "0x79BC410", VA = "0x1879BD010")]
	private void PKEJJINCLBA(NativeArray<int> GNNFCDHIMHF, int ANFENCJPNKI, int BDFKPPCHIGP, int POAPPIFFHKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public abstract class ACHJEIJOLPH : OKKMFOFDAFG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly MJDFBCKNNCA PLAIOLKGLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	protected readonly ELFEPMKPDPN NOMOCDCCOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private FMJPGOGIBAJ[] HANMPBAJKPO;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static OKKMFOFDAFG ELEBKANKHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x79A5790", Offset = "0x79A4B90", VA = "0x1879A5790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static bool MAIEPNIBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public JOFMHFKJPEL PMDFIBPJLPK
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JOFMHFKJPEL);
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D2190", VA = "0x1808D2D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public ELFEPMKPDPN HMMDEEGOOOF
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public ONHNFKGBFKG EONOEGJPENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public ONHNFKGBFKG HJOGAIBNHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DA0", Offset = "0x8C71A0", VA = "0x1808C7DA0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public ONHNFKGBFKG LGMNJDNGJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA80", Offset = "0x8CEE80", VA = "0x1808CFA80", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public ONHNFKGBFKG EMKFLCABLPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8CAEF0", Offset = "0x8CA2F0", VA = "0x1808CAEF0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x79A5800", Offset = "0x79A4C00", VA = "0x1879A5800")]
	public static GLHJGEGNDCM OJLEIKLJCBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x79A5B90", Offset = "0x79A4F90", VA = "0x1879A5B90")]
	[UnityEngine.Scripting.Preserve]
	protected ACHJEIJOLPH([CNGCCDLPGOD(null)] MJDFBCKNNCA PLAIOLKGLDB, [CNGCCDLPGOD(null)] ELFEPMKPDPN NOMOCDCCOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x79A5B20", Offset = "0x79A4F20", VA = "0x1879A5B20", Slot = "6")]
	public GLHJGEGNDCM PKMNDLFOFHF(IEnumerator<ONHNFKGBFKG> NIAIFENAOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x79A5920", Offset = "0x79A4D20", VA = "0x1879A5920", Slot = "7")]
	public GLHJGEGNDCM PKMNDLFOFHF(Behaviour NOIHGGNEIML, IEnumerator<ONHNFKGBFKG> NIAIFENAOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract GLHJGEGNDCM FHFEEAEMAAE(BHKHEGBAOJA NOIHGGNEIML, IEnumerator<ONHNFKGBFKG> NIAIFENAOND);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x79A4C70", Offset = "0x79A4070", VA = "0x1879A4C70", Slot = "20")]
	public virtual void CALNFFOLFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x79A5490", Offset = "0x79A4890", VA = "0x1879A5490", Slot = "9")]
	public void KKIDLPBKPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x79A4C30", Offset = "0x79A4030", VA = "0x1879A4C30", Slot = "21")]
	protected virtual void BFLBMILJDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x79A5470", Offset = "0x79A4870", VA = "0x1879A5470")]
	private void KCIDHGGCFJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x79A4C50", Offset = "0x79A4050", VA = "0x1879A4C50")]
	private void BMGIDOIOJAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x79A4EC0", Offset = "0x79A42C0", VA = "0x1879A4EC0")]
	private void DKFJJNBLCMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x79A56F0", Offset = "0x79A4AF0", VA = "0x1879A56F0")]
	private void LFALGCPAJAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x79A5710", Offset = "0x79A4B10", VA = "0x1879A5710")]
	private void MELIKNADIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x79A56D0", Offset = "0x79A4AD0", VA = "0x1879A56D0")]
	private void KMICNBKJJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x79A4E10", Offset = "0x79A4210", VA = "0x1879A4E10")]
	private void CEPNNGOLHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x79A4E30", Offset = "0x79A4230", VA = "0x1879A4E30", Slot = "22")]
	public virtual void DDCAEPCMPCI(JOFMHFKJPEL DEMMIJCLNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x79A52A0", Offset = "0x79A46A0", VA = "0x1879A52A0")]
	private void GJKMGFLEBKB(FMJPGOGIBAJ OMGMAGKCODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2227EE0", Offset = "0x22272E0", VA = "0x182227EE0")]
	private FMJPGOGIBAJ CEHBGKJFAGB(JOFMHFKJPEL IFBDJLKPHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract OHFLOGIGMDB DEBFHIMKFBC(IEnumerator<ONHNFKGBFKG> NIAIFENAOND, Behaviour KJJAJBPPHOF, AGKKANCOKDA EJMAPDIGNLN);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract FMJPGOGIBAJ GBMPHAENMAG(JOFMHFKJPEL DEMMIJCLNKO);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x79A4EE0", Offset = "0x79A42E0", VA = "0x1879A4EE0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x79A5B30", Offset = "0x79A4F30", VA = "0x1879A5B30", Slot = "15")]
	public ONHNFKGBFKG PPMJEHOPBKH(JOFMHFKJPEL HPNGDCNNMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x79A5890", Offset = "0x79A4C90", VA = "0x1879A5890", Slot = "16")]
	public ONHNFKGBFKG PBMNCHNPAJP(float CHFBMMDLDCL, JOFMHFKJPEL HPNGDCNNMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x79A5730", Offset = "0x79A4B30", VA = "0x1879A5730", Slot = "17")]
	public ONHNFKGBFKG NAKJBLHMELI(Func<bool> CBJBNBNFEJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal sealed class OHFLOGIGMDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly AGKKANCOKDA JLLOAJKMIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly OCLNBPPAODP NOIHGGNEIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly bool EGLHEPDPNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private string LJAGHAHCFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private StackTrace HHOPFEANIBA;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public IEnumerator<ONHNFKGBFKG> EPMANJICKLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public ONHNFKGBFKG GHGLGHEIEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C71C0", VA = "0x1808C7DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool EHMGCEHJAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x79BFA70", Offset = "0x79BEE70", VA = "0x1879BFA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool IFJNBFJHCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9A2F80", Offset = "0x9A2380", VA = "0x1809A2F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9A3BD0", Offset = "0x9A2FD0", VA = "0x1809A3BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string DKCJKHANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x79BFB60", Offset = "0x79BEF60", VA = "0x1879BFB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public float PHKAINICMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xC1C790", Offset = "0xC1BB90", VA = "0x180C1C790")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xE75380", Offset = "0xE74780", VA = "0x180E75380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x79C0160", Offset = "0x79BF560", VA = "0x1879C0160")]
	public OHFLOGIGMDB(IEnumerator<ONHNFKGBFKG> JKOPAHPKBDN, OCLNBPPAODP NOIHGGNEIML, AGKKANCOKDA JLLOAJKMIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x79BFD10", Offset = "0x79BF110", VA = "0x1879BFD10")]
	public ONHNFKGBFKG LLDLEJBBJMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x79BFAF0", Offset = "0x79BEEF0", VA = "0x1879BFAF0")]
	public bool HJADFALIFFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x79C0030", Offset = "0x79BF430", VA = "0x1879C0030")]
	public void MCJPJJDIODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x79C0080", Offset = "0x79BF480", VA = "0x1879C0080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x9A3D30", Offset = "0x9A3130", VA = "0x1809A3D30")]
	[CompilerGenerated]
	private void GKBLPHIPBCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal sealed class AGKKANCOKDA : GJOGJLGKKGK, GLHJGEGNDCM, JNDAODDCIHF, CLHPIMOBJFN, IEnumerator, ONHNFKGBFKG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private JOFMHFKJPEL MBFMOGCOFHC;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private JOFMHFKJPEL EIABELDBJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x9A49F0", Offset = "0x9A3DF0", VA = "0x1809A49F0", Slot = "23")]
		get
		{
			return default(JOFMHFKJPEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public JOFMHFKJPEL MDNFGCPHPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB1C930", Offset = "0xB1BD30", VA = "0x180B1C930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private float MKAEHBIHAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xB38AE0", Offset = "0xB37EE0", VA = "0x180B38AE0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool PNIGBLPMJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x79A60D0", Offset = "0x79A54D0", VA = "0x1879A60D0", Slot = "24")]
	private bool MLHMHKGPLJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x79A60C0", Offset = "0x79A54C0", VA = "0x1879A60C0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x79A60F0", Offset = "0x79A54F0", VA = "0x1879A60F0")]
	public AGKKANCOKDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal enum IMNHOEOOMMI : byte
{
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal sealed class FMJPGOGIBAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public enum KHPBBBKBMNK
	{
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public struct MCPLEJMKGBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public JOFMHFKJPEL KGJDDLJAIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public KHPBBBKBMNK AFFBICKPHIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public List<OHFLOGIGMDB> LPABMLGKPBC;
	}

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly KHPBBBKBMNK[] GJEACEOPKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly JOFMHFKJPEL DEMMIJCLNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private bool GIGOFCNDFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly OHFLOGIGMDB[] GLGEKPOJFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly List<OHFLOGIGMDB> PMKDAACFICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly Stack<int> FMLOFAHHOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly List<OHFLOGIGMDB> NLCCIEDNIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly Stack<int> AOAMPCGHCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly EKJHNNKOBAL NIJBGHLAMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private bool MLOFBNBBKBK;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public MCPLEJMKGBC[,] MAJCMOOFGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA80", Offset = "0x8CEE80", VA = "0x1808CFA80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x79B2E70", Offset = "0x79B2270", VA = "0x1879B2E70")]
	public FMJPGOGIBAJ(JOFMHFKJPEL HPNGDCNNMDL, EKJHNNKOBAL NIJBGHLAMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x79B2C40", Offset = "0x79B2040", VA = "0x1879B2C40")]
	public void OACKCMMNMAM(OHFLOGIGMDB JKOPAHPKBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x79B2350", Offset = "0x79B1750", VA = "0x1879B2350")]
	public void JNNLCKMGEGD(IList<OHFLOGIGMDB> IIIFHALAMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x79B2820", Offset = "0x79B1C20", VA = "0x1879B2820")]
	public void LBODELGMFBF(IList<OHFLOGIGMDB> IIIFHALAMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x79B1AE0", Offset = "0x79B0EE0", VA = "0x1879B1AE0")]
	private void BIJJDPAMDKM(OHFLOGIGMDB JKOPAHPKBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x79B1BD0", Offset = "0x79B0FD0", VA = "0x1879B1BD0")]
	private void DBJCOENECPJ(IList<OHFLOGIGMDB> IIIFHALAMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x79B1E70", Offset = "0x79B1270", VA = "0x1879B1E70")]
	private IMNHOEOOMMI GFJHHAAFFOM(OHFLOGIGMDB JKOPAHPKBDN)
	{
		return default(IMNHOEOOMMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x79B1970", Offset = "0x79B0D70", VA = "0x1879B1970")]
	public void BFLBMILJDBK(float EKLCEMNAMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x79B2630", Offset = "0x79B1A30", VA = "0x1879B2630")]
	public void KKIDLPBKPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x79B1FF0", Offset = "0x79B13F0", VA = "0x1879B1FF0")]
	private void JKOHHCLAFIH(List<OHFLOGIGMDB> IIIFHALAMFO, Stack<int> NIBPMMFMFHG, bool DPKAIPIPNNB, float JEGHGFJCOKO = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x79B1D50", Offset = "0x79B1150", VA = "0x1879B1D50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x79B2B00", Offset = "0x79B1F00", VA = "0x1879B2B00")]
	private void NKBFBBLDMNJ(List<OHFLOGIGMDB> IIIFHALAMFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal class AABGBCDOLGB : EKJHNNKOBAL
{
	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "4")]
	public void CCPLPHJBIOD(string LJAGHAHCFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
	public void FAGFCCAAPII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public AABGBCDOLGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal class KGKJFFEFBNI : OCLNBPPAODP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private readonly Behaviour KJJAJBPPHOF;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public string DKCJKHANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x79B80F0", Offset = "0x79B74F0", VA = "0x1879B80F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool LEGHPMGIPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x79B80A0", Offset = "0x79B74A0", VA = "0x1879B80A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool DOFEHGDOEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x79B8170", Offset = "0x79B7570", VA = "0x1879B8170", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public KGKJFFEFBNI(Behaviour KJJAJBPPHOF)
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

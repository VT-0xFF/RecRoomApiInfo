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
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82F3C80", Offset = "0x82F3080", VA = "0x1882F3C80", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x82FA8C0", Offset = "0x82F9CC0", VA = "0x1882FA8C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x254E750", Offset = "0x254DB50", VA = "0x18254E750")]
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
		private delegate List<PlayerLoopSystem> POJLLPLNCLF(List<PlayerLoopSystem> DABPOBHMOMM, int MBDAJDHEAME);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct LOODLFCNGNC
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct BPAPNLJNGHI
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static OPNNLJDPBAB EIPEEDPLOMN;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x82DF500", Offset = "0x82DE900", VA = "0x1882DF500")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct JIMJLNMCNLJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static OPNNLJDPBAB PAALEGAGDNC;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x82EF680", Offset = "0x82EEA80", VA = "0x1882EF680")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct AHECLPCBGMB
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static OPNNLJDPBAB BGLIKCCEPAK;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x82DD8C0", Offset = "0x82DCCC0", VA = "0x1882DD8C0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct LLAONEJMCEB
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static OPNNLJDPBAB AAJPBANMDKE;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static OPNNLJDPBAB OCIPEHJKBPE;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static OPNNLJDPBAB BLDHJCHHNHF;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static OPNNLJDPBAB FLMGIPBFNGB;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x82F3650", Offset = "0x82F2A50", VA = "0x1882F3650")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct FGNIPELAHLF
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static OPNNLJDPBAB ICEDNICHMJI;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x82E9DE0", Offset = "0x82E91E0", VA = "0x1882E9DE0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct APFNIDMHBOL
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static OPNNLJDPBAB AAJPBANMDKE;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static OPNNLJDPBAB OCIPEHJKBPE;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static OPNNLJDPBAB BLDHJCHHNHF;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static OPNNLJDPBAB FLMGIPBFNGB;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x82DED70", Offset = "0x82DE170", VA = "0x1882DED70")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct FGOIHILPGJA
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static OPNNLJDPBAB CIFABKMFNNF;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x82E9FE0", Offset = "0x82E93E0", VA = "0x1882E9FE0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct ENPJFECMMLF
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static OPNNLJDPBAB DNHAOKGOAMJ;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x82E7E70", Offset = "0x82E7270", VA = "0x1882E7E70")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct MHMINHMPFFE
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static OPNNLJDPBAB AEMLNJMNPNB;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x82F3DD0", Offset = "0x82F31D0", VA = "0x1882F3DD0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct FEEKOMMJOLN
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static OPNNLJDPBAB KOPKGBGIJHM;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x82E99E0", Offset = "0x82E8DE0", VA = "0x1882E99E0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct CCJIBFJGEJG
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static OPNNLJDPBAB EJKNKFPPJLF;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x82DF700", Offset = "0x82DEB00", VA = "0x1882DF700")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct JDONPODOEEK
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static OPNNLJDPBAB GBFDOPHAGFE;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x82EE5D0", Offset = "0x82ED9D0", VA = "0x1882EE5D0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct GNBGGDJNMJG
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static OPNNLJDPBAB HKGLNMMMEMC;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x82ED610", Offset = "0x82ECA10", VA = "0x1882ED610")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct FFOLEFGALON
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static OPNNLJDPBAB KOMFKLEMMAI;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x82E9BE0", Offset = "0x82E8FE0", VA = "0x1882E9BE0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct LLPDEOBMMNJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static OPNNLJDPBAB OPKAECHPAIG;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x82F3940", Offset = "0x82F2D40", VA = "0x1882F3940")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum AFLHKPBDODE : byte
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
			public struct NDJOLEHGECN
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class EMPGAKAKDKG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public AFLHKPBDODE updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
					public EMPGAKAKDKG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x82E7C80", Offset = "0x82E7080", VA = "0x1882E7C80")]
					internal void LLBLGHIEJBD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static GLDBGNIANKN<AFLHKPBDODE> CIICAGDOHAC;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x82F51E0", Offset = "0x82F45E0", VA = "0x1882F51E0")]
				public static PlayerLoopSystem EJMOPNOOINH(AFLHKPBDODE NBNBCAEGFEF)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct FAPMJOHNOFA
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class OOECBLMIBBE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public DKJAJKLNEKO.DMPJPMFLEOB key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
					public OOECBLMIBBE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x82F8340", Offset = "0x82F7740", VA = "0x1882F8340")]
					internal void EHMOFKHAMMF()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable NNGHCLKINKJ;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x82E98B0", Offset = "0x82E8CB0", VA = "0x1882E98B0")]
				public static PlayerLoopSystem NMNGPGFAEJH(DKJAJKLNEKO.DMPJPMFLEOB DJBLFBEBKGO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct GEGHJKIIOJE
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class ICIFMKPHJLI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public DKJAJKLNEKO.DMPJPMFLEOB key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
					public ICIFMKPHJLI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x82EDC50", Offset = "0x82ED050", VA = "0x1882EDC50")]
					internal void EHMOFKHAMMF()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x82EB540", Offset = "0x82EA940", VA = "0x1882EB540")]
				public static PlayerLoopSystem NMNGPGFAEJH(DKJAJKLNEKO.DMPJPMFLEOB DJBLFBEBKGO)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class HLHLHMGJMND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public HLHLHMGJMND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x82EDA70", Offset = "0x82ECE70", VA = "0x1882EDA70")]
			internal List<PlayerLoopSystem> FELPOGCDDOA(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool FJKNIAKLADK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool HMPOAHOJMBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x82E0630", Offset = "0x82DFA30", VA = "0x1882E0630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82E1650", Offset = "0x82E0A50", VA = "0x1882E1650")]
		private static void OKHOLNDAMAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82E0D40", Offset = "0x82E0140", VA = "0x1882E0D40")]
		private static void NFMAIOOGLNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82E03A0", Offset = "0x82DF7A0", VA = "0x1882E03A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82E03E0", Offset = "0x82DF7E0", VA = "0x1882E03E0")]
		private static void FCGNDMOEADH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82E07A0", Offset = "0x82DFBA0", VA = "0x1882E07A0")]
		private static void KOHPOIHLDKJ(DKJAJKLNEKO.DMPJPMFLEOB DJBLFBEBKGO, PlayerLoopSystem FNNKLHPGPFG, Type NMEINAFKKIB, Type OALIOHACPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82E0960", Offset = "0x82DFD60", VA = "0x1882E0960")]
		private static void MFKMJJGHONF(PlayerLoopSystem FNNKLHPGPFG, Type NMEINAFKKIB, Type OALIOHACPFH, POJLLPLNCLF HGJICNDEDDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82E0670", Offset = "0x82DFA70", VA = "0x1882E0670")]
		private static void KNJEDINBLIF(PlayerLoopSystem FNNKLHPGPFG, Type NMEINAFKKIB, Type OALIOHACPFH, PlayerLoopSystem? BGPCHIEGBPH, PlayerLoopSystem? JOPCPDEAGCF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class DKJAJKLNEKO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum DMPJPMFLEOB
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
	public class AGCNAKAMPHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly DMPJPMFLEOB CGCIGODIKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly PKKHFAKCKEL AFILOCMPHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long HGBCBCFFBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long HNOGAPJKIEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long IAFFJGLCOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int GBCFFLKDLJN;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x82DD830", Offset = "0x82DCC30", VA = "0x1882DD830")]
		public AGCNAKAMPHN(DMPJPMFLEOB MAAMJFMLDHP, int EOOALEJKLOJ = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x82DD810", Offset = "0x82DCC10", VA = "0x1882DD810")]
		public void MCCPNKDNHBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x82DD7C0", Offset = "0x82DCBC0", VA = "0x1882DD7C0")]
		public void ECJOEIFJHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x82DD6E0", Offset = "0x82DCAE0", VA = "0x1882DD6E0")]
		public void ALBABCDFLAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static DMPJPMFLEOB[] BALLACBGBEH;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static AGCNAKAMPHN[] MCJNJCLHJEP;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x82E5360", Offset = "0x82E4760", VA = "0x1882E5360")]
	public static AGCNAKAMPHN IIHGGHDMJNI(DMPJPMFLEOB DJBLFBEBKGO, int EOOALEJKLOJ = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x82E5560", Offset = "0x82E4960", VA = "0x1882E5560")]
	public static AGCNAKAMPHN JBIJMMGICCI(DMPJPMFLEOB DJBLFBEBKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x82E54B0", Offset = "0x82E48B0", VA = "0x1882E54B0")]
	public static void IJOMMGGBNML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DJPCADFFCLO
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private interface KDFHCGOPDDL
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool DLICIJADICJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CKDFENAGPAE();
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class KEAECOOGHLO : KDFHCGOPDDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action IOPCFKOHPBF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DLICIJADICJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
		public KEAECOOGHLO(Action IOPCFKOHPBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x103EC90", Offset = "0x103E090", VA = "0x18103EC90", Slot = "5")]
		public void CKDFENAGPAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<KDFHCGOPDDL> HAFFFBJGEAC;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x82E4E50", Offset = "0x82E4250", VA = "0x1882E4E50")]
	public static void IDGIODEBEJP(Action IOPCFKOHPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x82E4C30", Offset = "0x82E4030", VA = "0x1882E4C30")]
	private static void HJPIJFMDDCP(KDFHCGOPDDL CIBJOMJAJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x82E4EF0", Offset = "0x82E42F0", VA = "0x1882E4EF0")]
	private static void JMFGOIJCOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x82E4B30", Offset = "0x82E3F30", VA = "0x1882E4B30")]
	private static void CPPKCHFGCJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x82E51F0", Offset = "0x82E45F0", VA = "0x1882E51F0")]
	private static void LKEAGGCFIEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class EOFIIKGAEJA
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct JHKFALMFLIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TaskCompletionSource<Scene> KGEFPEAALJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly string DFCMKAEHLAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly LoadSceneMode IACJAKJLJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly bool FCCJDBBOCBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x82EE990", Offset = "0x82EDD90", VA = "0x1882EE990")]
		public JHKFALMFLIK(TaskCompletionSource<Scene> LNFGEEIEIAH, string DFCMKAEHLAO, LoadSceneMode IACJAKJLJPN, bool FCCJDBBOCBI, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct ANPKJCADJEK : IAsyncStateMachine
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
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private APGKENHKANG<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x82DE270", Offset = "0x82DD670", VA = "0x1882DE270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x82DEB10", Offset = "0x82DDF10", VA = "0x1882DEB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GJLPEJLLINN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82ED170", Offset = "0x82EC570", VA = "0x1882ED170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x82ED490", Offset = "0x82EC890", VA = "0x1882ED490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct DBLLPEMEJKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private JHKFALMFLIK <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x82E4710", Offset = "0x82E3B10", VA = "0x1882E4710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x82E4AD0", Offset = "0x82E3ED0", VA = "0x1882E4AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class NCAGNFIDMBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public COOALICOFAM<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public NCAGNFIDMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x82F5180", Offset = "0x82F4580", VA = "0x1882F5180")]
		internal void AAEHNKHAAMD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct DMNKFFFNGEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

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
		private NCAGNFIDMBP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private APGKENHKANG<string>.EEEKGBDKLHP <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x82E5770", Offset = "0x82E4B70", VA = "0x1882E5770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x82E6320", Offset = "0x82E5720", VA = "0x1882E6320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct EDDAEMGOIKI : IAsyncStateMachine
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
		private IFKKDICMKCC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x82E7370", Offset = "0x82E6770", VA = "0x1882E7370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x82E7A30", Offset = "0x82E6E30", VA = "0x1882E7A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct DMOFAINGIOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private APGKENHKANG<string>.EEEKGBDKLHP <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private APGKENHKANG<string>.EEEKGBDKLHP <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x82E6390", Offset = "0x82E5790", VA = "0x1882E6390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x82E6EB0", Offset = "0x82E62B0", VA = "0x1882E6EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class GCOHLHGOHOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public COOALICOFAM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public GCOHLHGOHOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x82EB4C0", Offset = "0x82EA8C0", VA = "0x1882EB4C0")]
		internal bool MMIFJAJNHJK(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x82EB240", Offset = "0x82EA640", VA = "0x1882EB240")]
		internal void FLNHBPFCDBI(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class KCBCDEMHMLG : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public COOALICOFAM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private GCOHLHGOHOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IFKKDICMKCC <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public KCBCDEMHMLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x82F0DF0", Offset = "0x82F01F0", VA = "0x1882F0DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x82F04E0", Offset = "0x82EF8E0", VA = "0x1882F04E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x82F0D80", Offset = "0x82F0180", VA = "0x1882F0D80")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x82F0DA0", Offset = "0x82F01A0", VA = "0x1882F0DA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ICollection<string> FHKINJGNMAD;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static DJNFHDJGNJD HMPIINNBLAL;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AsyncOperation HHPHHFIKGKF;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static DJNFHDJGNJD FICLOIKKDFF;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static string KBDANBOIENL;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string FDCKOLAAFIG;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority LPCFLLJIGEO;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task CJPBAIGHKCL;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static List<SceneInstance> IGHPOCLMLED;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly Queue<JHKFALMFLIK> DKJCCAHEPMB;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static Task JHGCOJBBJBC;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> EKFFNOHKFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x82E85B0", Offset = "0x82E79B0", VA = "0x1882E85B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x82E8E60", Offset = "0x82E8260", VA = "0x1882E8E60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x82E9080", Offset = "0x82E8480", VA = "0x1882E9080")]
	[IDEKGKHHECE(MPEIPIAKFID.EnteredEditModeNextFrame, 0)]
	private static void GKLFGMOGBHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x82E9530", Offset = "0x82E8930", VA = "0x1882E9530")]
	[AsyncStateMachine(typeof(ANPKJCADJEK))]
	public static Task<Scene> NJHDCKIDFAO(string DFCMKAEHLAO, LoadSceneMode IACJAKJLJPN = LoadSceneMode.Single, bool FCCJDBBOCBI = false, [Optional] APGKENHKANG<string>.EEEKGBDKLHP MEIEBOHMIGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x82E8500", Offset = "0x82E7900", VA = "0x1882E8500")]
	[AsyncStateMachine(typeof(GJLPEJLLINN))]
	private static Task BEIJLFCJBEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x82E9180", Offset = "0x82E8580", VA = "0x1882E9180")]
	[AsyncStateMachine(typeof(DBLLPEMEJKA))]
	private static Task JDBLACMEIOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x82E9250", Offset = "0x82E8650", VA = "0x1882E9250")]
	[AsyncStateMachine(typeof(DMNKFFFNGEC))]
	private static Task<Scene> JKDENDHLBHL(string DFCMKAEHLAO, LoadSceneMode IACJAKJLJPN, bool FCCJDBBOCBI, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x82E8C60", Offset = "0x82E8060", VA = "0x1882E8C60")]
	private static void DEHKDAIDOHD(SceneInstance JJKLCHMKBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x82E8900", Offset = "0x82E7D00", VA = "0x1882E8900")]
	private static void DBJOPJAJCCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x82E83D0", Offset = "0x82E77D0", VA = "0x1882E83D0")]
	[AsyncStateMachine(typeof(EDDAEMGOIKI))]
	private static Task<Scene> AEPOOPHFBBN(string DFCMKAEHLAO, LoadSceneMode IACJAKJLJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x82E8D70", Offset = "0x82E8170", VA = "0x1882E8D70")]
	private static bool DOMPFKKMEHK(string DFCMKAEHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x82E8F70", Offset = "0x82E8370", VA = "0x1882E8F70")]
	[AsyncStateMachine(typeof(DMOFAINGIOO))]
	private static Task<Scene> GGENPDJMBBE(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x82E8780", Offset = "0x82E7B80", VA = "0x1882E8780")]
	public static GOBMEFCJDOP<Scene> CGEKHHMCGJL(string DFCMKAEHLAO, LoadSceneMode IACJAKJLJPN = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x82E8BC0", Offset = "0x82E7FC0", VA = "0x1882E8BC0")]
	[IteratorStateMachine(typeof(KCBCDEMHMLG))]
	private static IEnumerator<CIKDDGFOAFI> DDDBNMHDPPG(string DFCMKAEHLAO, LoadSceneMode IACJAKJLJPN, COOALICOFAM<Scene> IDBGCMHEFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x82E94D0", Offset = "0x82E88D0", VA = "0x1882E94D0")]
	public static void MBLBIEIKNII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x82E86C0", Offset = "0x82E7AC0", VA = "0x1882E86C0")]
	private static void CDHMELKPNLG(string DFCMKAEHLAO, LoadSceneMode IACJAKJLJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x82E93A0", Offset = "0x82E87A0", VA = "0x1882E93A0")]
	public static bool LLHKONIKENE([Out] string ILDPHFIAOCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class KCPCCIIADLA
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x82F0F50", Offset = "0x82F0350", VA = "0x1882F0F50")]
	public static IDisposable NDHOFFKOAIL(this IGCLHBDADKK PCJJKLDOJMD, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x82F0ED0", Offset = "0x82F02D0", VA = "0x1882F0ED0")]
	public static IDisposable JLCENEHPPLD(this IGCLHBDADKK PCJJKLDOJMD, Action<float> MMFCHLFFDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x82F0E50", Offset = "0x82F0250", VA = "0x1882F0E50")]
	public static IDisposable FAPOFGALNMP(this IGCLHBDADKK PCJJKLDOJMD, Action<float> MMFCHLFFDDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class EHMKKIDGPCB
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x346CE80", Offset = "0x346C280", VA = "0x18346CE80")]
	[KOHECBFFINE]
	public static IDisposable MFDBAPBBBBP<T>(this T NAECADIONFH, Action MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x346D030", Offset = "0x346C430", VA = "0x18346D030")]
	[KOHECBFFINE]
	public static IDisposable MFDBAPBBBBP<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x346D2E0", Offset = "0x346C6E0", VA = "0x18346D2E0")]
	[KOHECBFFINE]
	public static IDisposable ODNOMLGNGJI<T>(this T NAECADIONFH, Action MMFCHLFFDDH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x346D290", Offset = "0x346C690", VA = "0x18346D290")]
	[KOHECBFFINE]
	public static IDisposable NACCOEPNHGB<T>(this T NAECADIONFH, Action MMFCHLFFDDH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x346D290", Offset = "0x346C690", VA = "0x18346D290")]
	[KOHECBFFINE]
	public static IDisposable NACCOEPNHGB<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x346CC00", Offset = "0x346C000", VA = "0x18346CC00")]
	[KOHECBFFINE]
	public static IDisposable GLMKDEJNHNL<T>(this T NAECADIONFH, Action MMFCHLFFDDH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x346CBB0", Offset = "0x346BFB0", VA = "0x18346CBB0")]
	[KOHECBFFINE]
	public static IDisposable GFJDOFLDMJC<T>(this T NAECADIONFH, Action MMFCHLFFDDH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x346CB00", Offset = "0x346BF00", VA = "0x18346CB00")]
	[KOHECBFFINE]
	public static IDisposable FJLGICJPLCI<T>(this T NAECADIONFH, Action MMFCHLFFDDH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x346CAC0", Offset = "0x346BEC0", VA = "0x18346CAC0")]
	[KOHECBFFINE]
	public static IDisposable CHFDLCMLMJP<T>(this T NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x82E7AA0", Offset = "0x82E6EA0", VA = "0x1882E7AA0")]
	[KOHECBFFINE]
	public static IDisposable CHFDLCMLMJP(this MonoBehaviour NAECADIONFH, LEGAGIOCBAL PCJJKLDOJMD, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x346D380", Offset = "0x346C780", VA = "0x18346D380")]
	[KOHECBFFINE]
	public static IDisposable PJBLOJKNAPC<T>(this T NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x346D240", Offset = "0x346C640", VA = "0x18346D240")]
	[KOHECBFFINE]
	public static IDisposable MOFODJDOAFP<T>(this T NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x346CCA0", Offset = "0x346C0A0", VA = "0x18346CCA0")]
	[KOHECBFFINE]
	public static IDisposable KAJOOFEJLMP<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x346CA60", Offset = "0x346BE60", VA = "0x18346CA60")]
	[KOHECBFFINE]
	public static IDisposable BBFPLLFJBDH<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x346CD60", Offset = "0x346C160", VA = "0x18346CD60")]
	[KOHECBFFINE]
	public static IDisposable KGEGCKMGMHJ<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x346CB50", Offset = "0x346BF50", VA = "0x18346CB50")]
	[KOHECBFFINE]
	public static IDisposable GCEPOGIMECB<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x346CD00", Offset = "0x346C100", VA = "0x18346CD00")]
	[KOHECBFFINE]
	public static IDisposable KCJEJIDIIJL<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x346CE20", Offset = "0x346C220", VA = "0x18346CE20")]
	[KOHECBFFINE]
	public static IDisposable MDCDJENNJDC<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x346CDC0", Offset = "0x346C1C0", VA = "0x18346CDC0")]
	[KOHECBFFINE]
	public static IDisposable LPJEHOODCOO<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x346CC50", Offset = "0x346C050", VA = "0x18346CC50")]
	[KOHECBFFINE]
	public static IDisposable HKGNFPCBPON<T>(this T NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x346D1E0", Offset = "0x346C5E0", VA = "0x18346D1E0")]
	[KOHECBFFINE]
	public static IDisposable MHGPMKLOCBF<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x346D320", Offset = "0x346C720", VA = "0x18346D320")]
	[KOHECBFFINE]
	public static IDisposable PDMDOFMFIKF<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class JOEOLEOPBHA
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class POEFKKIDFJI : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public GAMKDKPALGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private PHPFGDACENL <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public POEFKKIDFJI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x82F9540", Offset = "0x82F8940", VA = "0x1882F9540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x82F9620", Offset = "0x82F8A20", VA = "0x1882F9620", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class LMLOAKKFOLD : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public GAMKDKPALGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private PHPFGDACENL <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public LMLOAKKFOLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x82F3B40", Offset = "0x82F2F40", VA = "0x1882F3B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x82F3C30", Offset = "0x82F3030", VA = "0x1882F3C30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x82EFA30", Offset = "0x82EEE30", VA = "0x1882EFA30")]
	public static LBKCJDEOHAA MFDBAPBBBBP(Action MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x82EF9A0", Offset = "0x82EEDA0", VA = "0x1882EF9A0")]
	public static LBKCJDEOHAA MFDBAPBBBBP(Behaviour PCJJKLDOJMD, Action MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x82EFAB0", Offset = "0x82EEEB0", VA = "0x1882EFAB0")]
	public static LBKCJDEOHAA MFDBAPBBBBP(Behaviour PCJJKLDOJMD, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x82EF880", Offset = "0x82EEC80", VA = "0x1882EF880")]
	[IteratorStateMachine(typeof(POEFKKIDFJI))]
	private static IEnumerator<CIKDDGFOAFI> EDDLKNGFLFE(GAMKDKPALGP HKOJAHCOOEL, Action MMFCHLFFDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x82EF910", Offset = "0x82EED10", VA = "0x1882EF910")]
	[IteratorStateMachine(typeof(LMLOAKKFOLD))]
	private static IEnumerator<CIKDDGFOAFI> EDDLKNGFLFE(GAMKDKPALGP HKOJAHCOOEL, Action<float> MMFCHLFFDDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class AOEEJPMPCOL : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class LCPCKOPGLMA : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AOEEJPMPCOL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public LCPCKOPGLMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x82F2CC0", Offset = "0x82F20C0", VA = "0x1882F2CC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x82F2D50", Offset = "0x82F2150", VA = "0x1882F2D50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly GAMKDKPALGP BIENFMKKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action APAODHLMHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool GALNDCKLIHA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool IAEHNHFNHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9943A0", Offset = "0x9937A0", VA = "0x1809943A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x82DECA0", Offset = "0x82DE0A0", VA = "0x1882DECA0")]
	public AOEEJPMPCOL(GAMKDKPALGP BIENFMKKIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x82DEB80", Offset = "0x82DDF80", VA = "0x1882DEB80")]
	[IteratorStateMachine(typeof(LCPCKOPGLMA))]
	private IEnumerator<CIKDDGFOAFI> EPDHEMLABFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC00", Offset = "0x82DE000", VA = "0x1882DEC00", Slot = "4")]
	public void OnCompleted(Action KLINOMADKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	public void OFKHKGDALIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class ALMDKHKPDBN
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x82DE160", Offset = "0x82DD560", VA = "0x1882DE160")]
	public static AOEEJPMPCOL LKDLBOJCELA(this GAMKDKPALGP BIENFMKKIBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class KJJEMIOMHLM
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class CCPKICPOIMG : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public MJDGPJLMNKH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public CCPKICPOIMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x82DF900", Offset = "0x82DED00", VA = "0x1882DF900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x82DF980", Offset = "0x82DED80", VA = "0x1882DF980", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x82F1200", Offset = "0x82F0600", VA = "0x1882F1200")]
	public static LBKCJDEOHAA MFDBAPBBBBP(float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x82F12D0", Offset = "0x82F06D0", VA = "0x1882F12D0")]
	public static LBKCJDEOHAA MFDBAPBBBBP(MonoBehaviour NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x82F13A0", Offset = "0x82F07A0", VA = "0x1882F13A0")]
	public static LBKCJDEOHAA MGNIBBGJJEL(MonoBehaviour NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x82F10A0", Offset = "0x82F04A0", VA = "0x1882F10A0")]
	public static LBKCJDEOHAA JCDBIDMKALL(IGCLHBDADKK PCJJKLDOJMD, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x82F0FE0", Offset = "0x82F03E0", VA = "0x1882F0FE0")]
	private static IEnumerator<CIKDDGFOAFI> EDDLKNGFLFE(FDGCEIPODAG HNJDEELBCLI, float MIFCKAIMGDB, GAMKDKPALGP HKOJAHCOOEL, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x82F1490", Offset = "0x82F0890", VA = "0x1882F1490")]
	private static IEnumerator<CIKDDGFOAFI> NDOLNCAAIGM(FDGCEIPODAG HNJDEELBCLI, float MIFCKAIMGDB, GAMKDKPALGP HKOJAHCOOEL, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x82F1170", Offset = "0x82F0570", VA = "0x1882F1170")]
	[IteratorStateMachine(typeof(CCPKICPOIMG))]
	private static IEnumerator<CIKDDGFOAFI> KEJMAKAFPOJ(MJDGPJLMNKH FLNEKKEJNHD, float MIFCKAIMGDB, GAMKDKPALGP HKOJAHCOOEL, Action<float> MMFCHLFFDDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class ENKNOHPAPPA
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class JGPHEANHNJF : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public GAMKDKPALGP queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public JGPHEANHNJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x82EE880", Offset = "0x82EDC80", VA = "0x1882EE880", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x82EE940", Offset = "0x82EDD40", VA = "0x1882EE940", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x82E7DE0", Offset = "0x82E71E0", VA = "0x1882E7DE0")]
	[IteratorStateMachine(typeof(JGPHEANHNJF))]
	private static IEnumerator<CIKDDGFOAFI> FFEFFHIPKPN(GAMKDKPALGP BIENFMKKIBH, Func<bool> LNDKBMLMEBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x82E7D00", Offset = "0x82E7100", VA = "0x1882E7D00")]
	public static LBKCJDEOHAA AELPGJNECCF(this MonoBehaviour NAECADIONFH, Func<bool> LNDKBMLMEBB, GAMKDKPALGP BIENFMKKIBH = GAMKDKPALGP.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class CLFAPLMCOGH
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class OPOMPGOHDKC : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public GAMKDKPALGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public OPOMPGOHDKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x82F8580", Offset = "0x82F7980", VA = "0x1882F8580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x82F85F0", Offset = "0x82F79F0", VA = "0x1882F85F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class GKDAJGNAPKG<T> : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public GAMKDKPALGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public GKDAJGNAPKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x484A010", Offset = "0x4849410", VA = "0x18484A010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x484A0B0", Offset = "0x48494B0", VA = "0x18484A0B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class GFGLPJCPOLM : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public GAMKDKPALGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private CIKDDGFOAFI <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public GFGLPJCPOLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x82EB670", Offset = "0x82EAA70", VA = "0x1882EB670", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x82EB700", Offset = "0x82EAB00", VA = "0x1882EB700", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x82DFBB0", Offset = "0x82DEFB0", VA = "0x1882DFBB0")]
	[IteratorStateMachine(typeof(OPOMPGOHDKC))]
	private static IEnumerator<CIKDDGFOAFI> EPDHEMLABFD(float PCFGHPNONAI, GAMKDKPALGP HKOJAHCOOEL, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x33F2DA0", Offset = "0x33F21A0", VA = "0x1833F2DA0")]
	[IteratorStateMachine(typeof(GKDAJGNAPKG<>))]
	private static IEnumerator<CIKDDGFOAFI> EPDHEMLABFD<T>(float PCFGHPNONAI, GAMKDKPALGP HKOJAHCOOEL, Action<T> MOIIPMBKBLO, T HBNMBAEKPFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x82E0090", Offset = "0x82DF490", VA = "0x1882E0090")]
	[IteratorStateMachine(typeof(GFGLPJCPOLM))]
	private static IEnumerator<CIKDDGFOAFI> LLLCJPJMNMM(float PCFGHPNONAI, GAMKDKPALGP HKOJAHCOOEL, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x82DFE20", Offset = "0x82DF220", VA = "0x1882DFE20")]
	public static IDisposable KLKBCPJGAEN(this MonoBehaviour NAECADIONFH, float PCFGHPNONAI, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x82E0130", Offset = "0x82DF530", VA = "0x1882E0130")]
	public static LBKCJDEOHAA MCLPMOKEJOI(this MonoBehaviour NAECADIONFH, float PCFGHPNONAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x82DFF00", Offset = "0x82DF300", VA = "0x1882DFF00")]
	public static LBKCJDEOHAA KLKBCPJGAEN(this MonoBehaviour NAECADIONFH, float PCFGHPNONAI, GAMKDKPALGP HKOJAHCOOEL, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x82DFB10", Offset = "0x82DEF10", VA = "0x1882DFB10")]
	public static LBKCJDEOHAA ENCGMEHJGKB(this MonoBehaviour NAECADIONFH, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x33F2D50", Offset = "0x33F2150", VA = "0x1833F2D50")]
	public static LBKCJDEOHAA ENCGMEHJGKB<T>(this MonoBehaviour NAECADIONFH, Action<T> MOIIPMBKBLO, T HBNMBAEKPFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x82DFA70", Offset = "0x82DEE70", VA = "0x1882DFA70")]
	public static LBKCJDEOHAA CBLDEGFLMPP(this MonoBehaviour NAECADIONFH, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x82E0300", Offset = "0x82DF700", VA = "0x1882E0300")]
	public static LBKCJDEOHAA PPJCOANLDPA(this MonoBehaviour NAECADIONFH, Action MOIIPMBKBLO, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x82DFCF0", Offset = "0x82DF0F0", VA = "0x1882DFCF0")]
	public static LBKCJDEOHAA ICBJDAKCGDI(this MonoBehaviour NAECADIONFH, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x82E01C0", Offset = "0x82DF5C0", VA = "0x1882E01C0")]
	public static LBKCJDEOHAA NHMOJGDLCDG(this MonoBehaviour NAECADIONFH, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x82E0260", Offset = "0x82DF660", VA = "0x1882E0260")]
	public static LBKCJDEOHAA PAPKEPHIAEJ(MonoBehaviour NAECADIONFH, GAMKDKPALGP BIENFMKKIBH, Action MOIIPMBKBLO, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x33F2E80", Offset = "0x33F2280", VA = "0x1833F2E80")]
	public static LBKCJDEOHAA PAPKEPHIAEJ<T>(MonoBehaviour NAECADIONFH, GAMKDKPALGP BIENFMKKIBH, Action<T> MOIIPMBKBLO, T HBNMBAEKPFF, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x82DFD90", Offset = "0x82DF190", VA = "0x1882DFD90")]
	public static LBKCJDEOHAA JPJAHFNFHEE(this MonoBehaviour NAECADIONFH, float LDNIDDBEFHG, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x82DFC50", Offset = "0x82DF050", VA = "0x1882DFC50")]
	public static LBKCJDEOHAA HCAKKDHIPJH(this MonoBehaviour NAECADIONFH, float LDNIDDBEFHG, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x82DFFF0", Offset = "0x82DF3F0", VA = "0x1882DFFF0")]
	public static LBKCJDEOHAA LJJEJMAIIMF(this MonoBehaviour NAECADIONFH, float LDNIDDBEFHG, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x82DF9D0", Offset = "0x82DEDD0", VA = "0x1882DF9D0")]
	public static LBKCJDEOHAA BOHDLFFADAI(this MonoBehaviour NAECADIONFH, float LDNIDDBEFHG, Action MOIIPMBKBLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class KAGADOACIFP : DJEHKBEDOAJ, IEnumerable<DJEHKBEDOAJ>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly List<DJEHKBEDOAJ> PPKFLPGADFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool GLNMJBGEPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action MDAFFLLJPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool IHMPICIMKLE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JJAMIFJHILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x82EFC30", Offset = "0x82EF030", VA = "0x1882EFC30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FHAMINJBFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x82EFB90", Offset = "0x82EEF90", VA = "0x1882EFB90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x82F03A0", Offset = "0x82EF7A0", VA = "0x1882F03A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x82F0440", Offset = "0x82EF840", VA = "0x1882F0440")]
	public KAGADOACIFP([Optional] Action MDAFFLLJPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x82F0270", Offset = "0x82EF670", VA = "0x1882F0270")]
	public void JJBKLNLGAIJ(DJEHKBEDOAJ MEHIBDIGAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x82EFD70", Offset = "0x82EF170", VA = "0x1882EFD70")]
	private void EBFHHHFLGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x82EFF50", Offset = "0x82EF350", VA = "0x1882EFF50", Slot = "7")]
	public bool HBCFHNCJIDJ(bool HLPBIKLHEBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x82EFF60", Offset = "0x82EF360", VA = "0x1882EFF60", Slot = "8")]
	public bool HBCFHNCJIDJ(Action IOPCFKOHPBF, bool HLPBIKLHEBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x82EFED0", Offset = "0x82EF2D0", VA = "0x1882EFED0", Slot = "9")]
	public IEnumerator<DJEHKBEDOAJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x82EFED0", Offset = "0x82EF2D0", VA = "0x1882EFED0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class EOABDIBPEHI : PNBKHDLGNEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class HGMMECKMOHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public EOABDIBPEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public HGMMECKMOHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x82EDA40", Offset = "0x82ECE40", VA = "0x1882EDA40")]
		internal void MNCDBBPFBPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class KCOKDOBKAAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public EOABDIBPEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public KCOKDOBKAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x82EDA40", Offset = "0x82ECE40", VA = "0x1882EDA40")]
		internal void LKKLAOFFFJO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float AIJBPJBEONK;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x82E8290", Offset = "0x82E7690", VA = "0x1882E8290")]
	public EOABDIBPEHI(Behaviour PCJJKLDOJMD, float AIJBPJBEONK, [Optional] Action MDAFFLLJPAL, [Optional] OKJPOJGEILK AAECGIEPKCK, [Optional] FDGCEIPODAG HNJDEELBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x82E8070", Offset = "0x82E7470", VA = "0x1882E8070", Slot = "9")]
	protected override bool CFDCDBJNLDN(Action IOPCFKOHPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x82E8180", Offset = "0x82E7580", VA = "0x1882E8180", Slot = "10")]
	protected override bool KNINGLDHADG(Action IOPCFKOHPBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface DJEHKBEDOAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JJAMIFJHILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action FHAMINJBFEO;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HBCFHNCJIDJ(bool HLPBIKLHEBD = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HBCFHNCJIDJ(Action IOPCFKOHPBF, bool HLPBIKLHEBD = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class PNBKHDLGNEJ : DJEHKBEDOAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class GLCMCEICOGN : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public PNBKHDLGNEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public GLCMCEICOGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x82ED4F0", Offset = "0x82EC8F0", VA = "0x1882ED4F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x82ED5C0", Offset = "0x82EC9C0", VA = "0x1882ED5C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Behaviour PCJJKLDOJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Action MDAFFLLJPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NAHOFKDLLJE JACIHFOFPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly OKJPOJGEILK AAECGIEPKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly FDGCEIPODAG HNJDEELBCLI;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JJAMIFJHILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x18FEC60", Offset = "0x18FE060", VA = "0x1818FEC60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action FHAMINJBFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x82F8710", Offset = "0x82F7B10", VA = "0x1882F8710", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x82F8B80", Offset = "0x82F7F80", VA = "0x1882F8B80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x82F8C40", Offset = "0x82F8040", VA = "0x1882F8C40")]
	protected PNBKHDLGNEJ(Behaviour PCJJKLDOJMD, [Optional] Action MDAFFLLJPAL, [Optional] OKJPOJGEILK AAECGIEPKCK, [Optional] FDGCEIPODAG HNJDEELBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x82F8830", Offset = "0x82F7C30", VA = "0x1882F8830", Slot = "7")]
	public bool HBCFHNCJIDJ(bool HLPBIKLHEBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x82F8890", Offset = "0x82F7C90", VA = "0x1882F8890", Slot = "8")]
	public bool HBCFHNCJIDJ(Action IOPCFKOHPBF, bool HLPBIKLHEBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool CFDCDBJNLDN(Action IOPCFKOHPBF);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool KNINGLDHADG(Action IOPCFKOHPBF);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x82F8C20", Offset = "0x82F8020", VA = "0x1882F8C20")]
	protected void PIADILGJJEM(Action IOPCFKOHPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x82F88F0", Offset = "0x82F7CF0", VA = "0x1882F88F0")]
	protected DJNFHDJGNJD HGOENGHLNJN(float HLOBKBPABIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x82F87B0", Offset = "0x82F7BB0", VA = "0x1882F87B0")]
	private void GCFJIDMKDDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x82F8680", Offset = "0x82F7A80", VA = "0x1882F8680")]
	[IteratorStateMachine(typeof(GLCMCEICOGN))]
	private IEnumerator<CIKDDGFOAFI> AJHCGPCJBJF(float HLOBKBPABIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x82F8B40", Offset = "0x82F7F40", VA = "0x1882F8B40")]
	[CompilerGenerated]
	private void ILKENLLDHAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class ECIFCJKGEGP : PNBKHDLGNEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly float BEFOJHNAJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int IDNGCCJFKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float ODNKAOCCDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float[] NIEFOJLJBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int NGNMNAMFDFC;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x82E71A0", Offset = "0x82E65A0", VA = "0x1882E71A0")]
	public ECIFCJKGEGP(Behaviour PCJJKLDOJMD, float KHAKPFDJJKN, int IDNGCCJFKFP, [Optional] Action MDAFFLLJPAL, float ODNKAOCCDPJ = 0f, [Optional] OKJPOJGEILK AAECGIEPKCK, [Optional] FDGCEIPODAG HNJDEELBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "9")]
	protected override bool CFDCDBJNLDN(Action IOPCFKOHPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x82E6F20", Offset = "0x82E6320", VA = "0x1882E6F20", Slot = "10")]
	protected override bool KNINGLDHADG(Action IOPCFKOHPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x82E7120", Offset = "0x82E6520", VA = "0x1882E7120")]
	private void OILFMMHCNCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class NOEGKFAECBB : PNBKHDLGNEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float AIJBPJBEONK;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x82E8290", Offset = "0x82E7690", VA = "0x1882E8290")]
	public NOEGKFAECBB(Behaviour PCJJKLDOJMD, float AIJBPJBEONK, [Optional] Action MDAFFLLJPAL, [Optional] OKJPOJGEILK AAECGIEPKCK, [Optional] FDGCEIPODAG HNJDEELBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "9")]
	protected override bool CFDCDBJNLDN(Action IOPCFKOHPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x82F8300", Offset = "0x82F7700", VA = "0x1882F8300", Slot = "10")]
	protected override bool KNINGLDHADG(Action IOPCFKOHPBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class AJDMEBAFFAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IGFJBIIDEMM : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public IGFJBIIDEMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x82EDB90", Offset = "0x82ECF90", VA = "0x1882EDB90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x82EDED0", Offset = "0x82ED2D0", VA = "0x1882EDED0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private LBKCJDEOHAA MLOFDBNNNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private IGCLHBDADKK PCJJKLDOJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Action<float> FEGHKFKPHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private GAMKDKPALGP BIENFMKKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private float JNCHGHHILLH;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x82DDFC0", Offset = "0x82DD3C0", VA = "0x1882DDFC0")]
	public AJDMEBAFFAP(IGCLHBDADKK PCJJKLDOJMD, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x82DDCA0", Offset = "0x82DD0A0", VA = "0x1882DDCA0")]
	private void GBINAKHHHDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x82DDE90", Offset = "0x82DD290", VA = "0x1882DDE90")]
	private void ONOALJGAMCL(string AFHGIBDEPMG, Action IFINDMOOMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x82DDE10", Offset = "0x82DD210", VA = "0x1882DDE10")]
	[IteratorStateMachine(typeof(IGFJBIIDEMM))]
	private IEnumerator<CIKDDGFOAFI> IGLOPBEHCPA(Action IFINDMOOMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x82DDAC0", Offset = "0x82DCEC0", VA = "0x1882DDAC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x82DDB20", Offset = "0x82DCF20", VA = "0x1882DDB20")]
	[CompilerGenerated]
	private void EOKGGLHEJMC(string DLAPGFGBDMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class NBCOOEPKKED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class HMIGOLOONNL : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public HMIGOLOONNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x82EDB90", Offset = "0x82ECF90", VA = "0x1882EDB90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x82EDC00", Offset = "0x82ED000", VA = "0x1882EDC00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private LBKCJDEOHAA MLOFDBNNNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private MonoBehaviour NAECADIONFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Action MMFCHLFFDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Action<float> FEGHKFKPHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private GAMKDKPALGP BIENFMKKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float JNCHGHHILLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private bool DFODLBNPDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly OKJPOJGEILK AAECGIEPKCK;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x82F4E20", Offset = "0x82F4220", VA = "0x1882F4E20")]
	public NBCOOEPKKED(MonoBehaviour NAECADIONFH, Action MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x82F4FB0", Offset = "0x82F43B0", VA = "0x1882F4FB0")]
	public NBCOOEPKKED(MonoBehaviour NAECADIONFH, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x82F4C40", Offset = "0x82F4040", VA = "0x1882F4C40")]
	public NBCOOEPKKED(MonoBehaviour NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4953C10", Offset = "0x4953010", VA = "0x184953C10")]
	private NBCOOEPKKED(OKJPOJGEILK AAECGIEPKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x82F4010", Offset = "0x82F3410", VA = "0x1882F4010")]
	internal static NBCOOEPKKED AAAHBMLBMKN(MonoBehaviour NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x82F46B0", Offset = "0x82F3AB0", VA = "0x1882F46B0")]
	private void MFDBAPBBBBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x82F47E0", Offset = "0x82F3BE0", VA = "0x1882F47E0")]
	private void NFIAFHAGNDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x82F42A0", Offset = "0x82F36A0", VA = "0x1882F42A0")]
	private void GBINAKHHHDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x82F4520", Offset = "0x82F3920", VA = "0x1882F4520")]
	private void IPNDPPOKLHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x82F4B10", Offset = "0x82F3F10", VA = "0x1882F4B10")]
	private void ONOALJGAMCL(string AFHGIBDEPMG, Action IFINDMOOMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x82F44A0", Offset = "0x82F38A0", VA = "0x1882F44A0")]
	[IteratorStateMachine(typeof(HMIGOLOONNL))]
	private IEnumerator<CIKDDGFOAFI> IGLOPBEHCPA(Action IFINDMOOMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x82F4240", Offset = "0x82F3640", VA = "0x1882F4240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x82F4960", Offset = "0x82F3D60", VA = "0x1882F4960")]
	[CompilerGenerated]
	private void NNLJKFMJEPN(string DLAPGFGBDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x82F4410", Offset = "0x82F3810", VA = "0x1882F4410")]
	[CompilerGenerated]
	private void HAFLBBMFJLL(string DLAPGFGBDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x82F4A80", Offset = "0x82F3E80", VA = "0x1882F4A80")]
	[CompilerGenerated]
	private void OCKKCFENNAK(string DLAPGFGBDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x82F49F0", Offset = "0x82F3DF0", VA = "0x1882F49F0")]
	[CompilerGenerated]
	private void OCIKAJHNOLA(string DLAPGFGBDMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum OACGLJJDPGH : byte
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
internal sealed class JFDFEFGGJOL : FDGCEIPODAG
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float OKGGONCOGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x82EE860", Offset = "0x82EDC60", VA = "0x1882EE860", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public float JEHINFIHNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x82EE870", Offset = "0x82EDC70", VA = "0x1882EE870", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public double KFDEODFGGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x82EE840", Offset = "0x82EDC40", VA = "0x1882EE840", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x82EE7D0", Offset = "0x82EDBD0", VA = "0x1882EE7D0")]
	[NOCPMGCIOME.CBODKAAMPCM]
	internal static void BBLAOBGDHMG(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	[UnityEngine.Scripting.Preserve]
	internal JFDFEFGGJOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface CAKEIPBDAHI
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLFDMDAFOJA(string IGEPDAOOLBO);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBMBHPJMPMC();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface HEOACCKMHOL
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool ECMLJIKMDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool FDBBOLDOOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class GBNOEHEDBEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public NHMLKJIGJMP JHHDOLAHEDJ;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int FBMJOLKHIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9931A0", Offset = "0x9925A0", VA = "0x1809931A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x993250", Offset = "0x992650", VA = "0x180993250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x82EB0E0", Offset = "0x82EA4E0", VA = "0x1882EB0E0")]
	public static CIKDDGFOAFI LGHLLEGIGPB(IEnumerator<CIKDDGFOAFI> GBBPIGBGDCL, MBBBLOJIOMF MCOJNHGAONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x82EB020", Offset = "0x82EA420", VA = "0x1882EB020")]
	public CIKDDGFOAFI LGHLLEGIGPB(MBBBLOJIOMF[] CBBKNJBDLJL, IEnumerator<CIKDDGFOAFI>[] LGMPNMHCPPB, CIKDDGFOAFI[] EBKDHPDJIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x82EAD70", Offset = "0x82EA170", VA = "0x1882EAD70")]
	public void ADLELANCLKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x82EAEE0", Offset = "0x82EA2E0", VA = "0x1882EAEE0")]
	public void CMPHFJMAPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x82EADA0", Offset = "0x82EA1A0", VA = "0x1882EADA0")]
	public void ANLMKPPOALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x82EAD70", Offset = "0x82EA170", VA = "0x1882EAD70")]
	public void OAALHNMPGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public GBNOEHEDBEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class NHMLKJIGJMP
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct KGNFAKIEGDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public GBNOEHEDBEN GDIJDLEPGPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public IGCLHBDADKK CLJDABMONFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public MBBBLOJIOMF AOPIMFKAFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IEnumerator<CIKDDGFOAFI> LMDAPDGOMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public CIKDDGFOAFI LJNAJLFNOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public OACGLJJDPGH BEEFDAEONPE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct DECHIOKAOLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public GAMKDKPALGP EFCNOOGOMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public List<KGNFAKIEGDN> OMNKEHEBJGG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class PNDPNNEMGOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public MBBBLOJIOMF promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public NHMLKJIGJMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public IGCLHBDADKK context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public GBNOEHEDBEN routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public OACGLJJDPGH coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public CIKDDGFOAFI currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IEnumerator<CIKDDGFOAFI> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public PNDPNNEMGOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x82F8D70", Offset = "0x82F8170", VA = "0x1882F8D70")]
		internal void BCNABLCHONL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class PGGBEIALLLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public GBNOEHEDBEN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public NHMLKJIGJMP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public PGGBEIALLLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x82F8640", Offset = "0x82F7A40", VA = "0x1882F8640")]
		internal void BLKCPEFOIJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class MMGOEHIIGHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public GBNOEHEDBEN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public NHMLKJIGJMP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public MMGOEHIIGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x82F3FD0", Offset = "0x82F33D0", VA = "0x1882F3FD0")]
		internal void MGIPHIGEHED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class MBNBIDAAJGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public GBNOEHEDBEN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public NHMLKJIGJMP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public MBNBIDAAJGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x82F3D90", Offset = "0x82F3190", VA = "0x1882F3D90")]
		internal void PABOHAMPAJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private const OACGLJJDPGH NJMGPHKOEKD = OACGLJJDPGH.Cancelled | OACGLJJDPGH.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly GAMKDKPALGP BIENFMKKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool[] KOFBPPDBHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<OACGLJJDPGH> PNENGCBEBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeArray<float> LHANKFAALEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<int> OBMNFBMILGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<int> LBGALJMFHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> MFLMHNPBIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> PGMHMIIGAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> MJJIJAALFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private GBNOEHEDBEN[] KJBPDJHOPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private MBBBLOJIOMF[] CBBKNJBDLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private IGCLHBDADKK[] OIGAFJAHKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private IEnumerator<CIKDDGFOAFI>[] DCNOBCCMECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private CIKDDGFOAFI[] ABIPCLGNNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int ALCKNAMILAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int HDAIOJEADNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int OPFOLNCOPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float OLKGNKAPBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NDLFNEMCILE HGGAOPDPLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JobHandle HIEFNCHKCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<GBNOEHEDBEN> GHIGPMGACCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool LMGCCHBOBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<Action> EMJJAHADJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<Action> ILODFOJAJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool BPBLJHNDPBA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public DECHIOKAOLK[] BOPNDGKMOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA025D0", Offset = "0xA019D0", VA = "0x180A025D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x82F6330", Offset = "0x82F5730", VA = "0x1882F6330")]
	private static int CJNNGIMGOKC(GAMKDKPALGP BIENFMKKIBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x82F7CA0", Offset = "0x82F70A0", VA = "0x1882F7CA0")]
	public NHMLKJIGJMP(GAMKDKPALGP BIENFMKKIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x82F5910", Offset = "0x82F4D10", VA = "0x1882F5910")]
	private void ALEJIPPDALK(int PODLDNMBBNM, int MJHFBPPAICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x82F7B20", Offset = "0x82F6F20", VA = "0x1882F7B20")]
	public void OCCCLCPPHME(IGCLHBDADKK PCJJKLDOJMD, CIKDDGFOAFI KPAKACAAIJC, IEnumerator<CIKDDGFOAFI> GBBPIGBGDCL, MBBBLOJIOMF MCOJNHGAONG, [Optional] GBNOEHEDBEN AABJHAPOCNF, OACGLJJDPGH OLFHIKKHACA = OACGLJJDPGH.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x82F6F60", Offset = "0x82F6360", VA = "0x1882F6F60")]
	public void IHGDPCFIMLB(IEnumerable<KGNFAKIEGDN> GIMCMPMHEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x82F7520", Offset = "0x82F6920", VA = "0x1882F7520")]
	private KGNFAKIEGDN MELJDDGCDHI(int OHKKOKEAPLK)
	{
		return default(KGNFAKIEGDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x82F5E90", Offset = "0x82F5290", VA = "0x1882F5E90")]
	private void CEMEAOJCNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x37BEAE0", Offset = "0x37BDEE0", VA = "0x1837BEAE0")]
	private static void PPKJIJBAAPL<T>(int OHKKOKEAPLK, T[] BOMDALFHOCL, int MNDMOIHIBEI, [Optional] T LIIPLKNMBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x37BEB30", Offset = "0x37BDF30", VA = "0x1837BEB30")]
	private static void PPKJIJBAAPL<T>(int OHKKOKEAPLK, NativeArray<T> BOMDALFHOCL, int MNDMOIHIBEI, [Optional] T LIIPLKNMBHL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x82F5AF0", Offset = "0x82F4EF0", VA = "0x1882F5AF0")]
	private void BONHCFEHAFB(IEnumerable<KGNFAKIEGDN> GIMCMPMHEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x82F72D0", Offset = "0x82F66D0", VA = "0x1882F72D0")]
	private void KCAMFNEKCPM(KGNFAKIEGDN FKMNMHEKICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x82F65E0", Offset = "0x82F59E0", VA = "0x1882F65E0")]
	private FOFLFGDMFGB EKGJOLGNAON(int KBEEJILCKBE)
	{
		return default(FOFLFGDMFGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x82F63E0", Offset = "0x82F57E0", VA = "0x1882F63E0")]
	public void EHJIKHCFNEK(float BKAEDIDGDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x82F73A0", Offset = "0x82F67A0", VA = "0x1882F73A0")]
	private void LIOLJOMFEMN(Action PCMHLCLONGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x82F6360", Offset = "0x82F5760", VA = "0x1882F6360")]
	private void DCJBLPLNJMK(Action PCMHLCLONGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x82F6840", Offset = "0x82F5C40", VA = "0x1882F6840")]
	public void IHALPLMJDGH(float BKAEDIDGDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x82F7420", Offset = "0x82F6820", VA = "0x1882F7420")]
	public void LIPICMLEJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x82F79F0", Offset = "0x82F6DF0", VA = "0x1882F79F0")]
	public void OAALHNMPGBB(GBNOEHEDBEN FLNEKKEJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x82F6200", Offset = "0x82F5600", VA = "0x1882F6200")]
	public void CFLFBJOCAIG(GBNOEHEDBEN FLNEKKEJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x82F71A0", Offset = "0x82F65A0", VA = "0x1882F71A0")]
	public void ILAJGDCMNKH(GBNOEHEDBEN FLNEKKEJNHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class HEIJPMDAFBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static readonly HEIJPMDAFBL GBADJOAJCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Action JECALFIKEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool ACJJLPFCEAB;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	public HEIJPMDAFBL(Action JECALFIKEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x79A13F0", Offset = "0x79A07F0", VA = "0x1879A13F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface IAMKHIAIKCA<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	T HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable MLEPBBKMOOK(UnityEngine.Object PCJJKLDOJMD, Action<T> NCAMGLOANBB);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface GKIPKGMAALG<T> : IAMKHIAIKCA<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	new T HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class KHJCMBHAHKL<T> : GKIPKGMAALG<T>, IAMKHIAIKCA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class AMAABNLJHPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public KHJCMBHAHKL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public FFBPAJLKGII<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public AMAABNLJHPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x48E9730", Offset = "0x48E8B30", VA = "0x1848E9730")]
		internal void GPBKKNDHDMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static GameObject FHFFINAENIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<FFBPAJLKGII<UnityEngine.Object, Action<T>>> EKKPACHKBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private T LLLNOEOKELG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x9FB880", Offset = "0x9FAC80", VA = "0x1809FB880", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4D713C0", Offset = "0x4D707C0", VA = "0x184D713C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4D71B10", Offset = "0x4D70F10", VA = "0x184D71B10")]
	private static bool LPPBFOOCKEG(T PCMHLCLONGN, T IAJJOLNCJOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4D71F30", Offset = "0x4D71330", VA = "0x184D71F30")]
	public KHJCMBHAHKL(T EKGCIKACHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4D71D80", Offset = "0x4D71180", VA = "0x184D71D80", Slot = "6")]
	public IDisposable MLEPBBKMOOK(UnityEngine.Object PCJJKLDOJMD, Action<T> NCAMGLOANBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4D717A0", Offset = "0x4D70BA0", VA = "0x184D717A0")]
	private void GDDNOKOHBKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class FPCJJHPDKMI : KEOINNCCKOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class BOEPCIBHJBB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private class GNGMLHKJNEC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int NCJKGMLAKGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private BOEPCIBHJBB HKOJAHCOOEL;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xE12B60", Offset = "0xE11F60", VA = "0x180E12B60")]
			public GNGMLHKJNEC(int NCJKGMLAKGH, BOEPCIBHJBB HKOJAHCOOEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x82ED810", Offset = "0x82ECC10", VA = "0x1882ED810", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class NGEKEHHPLIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public NGEKEHHPLIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xD18D40", Offset = "0xD18140", VA = "0x180D18D40")]
			internal bool NGFGJPIFGOC(JALALGGPCLJ e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class KKKMADCKLGK : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private CIKDDGFOAFI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public BOEPCIBHJBB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public FDGCEIPODAG timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private PHPFGDACENL <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private List<JALALGGPCLJ> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
			[DebuggerHidden]
			public KKKMADCKLGK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x82F14F0", Offset = "0x82F08F0", VA = "0x1882F14F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x82F1820", Offset = "0x82F0C20", VA = "0x1882F1820", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly GAMKDKPALGP BIENFMKKIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private LBKCJDEOHAA MCOJNHGAONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly List<JALALGGPCLJ> HHOLFJLOEJL;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x82DF460", Offset = "0x82DE860", VA = "0x1882DF460")]
		public BOEPCIBHJBB(GAMKDKPALGP BIENFMKKIBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x82DF060", Offset = "0x82DE460", VA = "0x1882DF060")]
		public IDisposable ANEJECHBGKN(JALALGGPCLJ BKLJHDMJNEA, OKJPOJGEILK AAECGIEPKCK, FDGCEIPODAG KINEPAABOFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x82DF2D0", Offset = "0x82DE6D0", VA = "0x1882DF2D0")]
		private void OJAIDPJMDOF(int NCJKGMLAKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x82DF240", Offset = "0x82DE640", VA = "0x1882DF240")]
		[IteratorStateMachine(typeof(KKKMADCKLGK))]
		private IEnumerator<CIKDDGFOAFI> EDDLKNGFLFE(FDGCEIPODAG KINEPAABOFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x82DF1F0", Offset = "0x82DE5F0", VA = "0x1882DF1F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class JALALGGPCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public enum FODDNBJJPBE : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static int APGOMNDIOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public readonly int GEEBDAOOGGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public readonly LEGAGIOCBAL CLJDABMONFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly MonoBehaviour DHHDFDMMIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public readonly Action ODNOMLGNGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public readonly Action<float> BFBKADHEJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public readonly float PHKFCIELCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float LHANKFAALEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public readonly string KAFLMFCDNKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public readonly bool FPFKHADGAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public readonly FODDNBJJPBE AMNBOGOIAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool KMBKKINPIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public bool KCCNHOPHFAK;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x82EE450", Offset = "0x82ED850", VA = "0x1882EE450")]
		public JALALGGPCLJ(LEGAGIOCBAL PCJJKLDOJMD, Action MMFCHLFFDDH, bool LHBMPBEGJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x82EE2D0", Offset = "0x82ED6D0", VA = "0x1882EE2D0")]
		public JALALGGPCLJ(LEGAGIOCBAL PCJJKLDOJMD, Action<float> MMFCHLFFDDH, bool LHBMPBEGJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x82EE0F0", Offset = "0x82ED4F0", VA = "0x1882EE0F0")]
		public JALALGGPCLJ(LEGAGIOCBAL PCJJKLDOJMD, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, FDGCEIPODAG KINEPAABOFB, FODDNBJJPBE AJPEELGFJOG, bool DFODLBNPDAD, bool LHBMPBEGJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x82EDF20", Offset = "0x82ED320", VA = "0x1882EDF20")]
		public bool FBEKCKILPGH(float GLBFMHKMALN, float ENOGEACDIOG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly OKJPOJGEILK AAECGIEPKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly FDGCEIPODAG HNJDEELBCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Dictionary<GAMKDKPALGP, BOEPCIBHJBB> HNMAOHCOFKH;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x82EA4A0", Offset = "0x82E98A0", VA = "0x1882EA4A0")]
	[NOCPMGCIOME.CBODKAAMPCM]
	internal static void IINEJNNLFDN(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x82EACB0", Offset = "0x82EA0B0", VA = "0x1882EACB0")]
	[UnityEngine.Scripting.Preserve]
	internal FPCJJHPDKMI([CMKKAFOAFJE(null)] OKJPOJGEILK AAECGIEPKCK, [CMKKAFOAFJE(null)] FDGCEIPODAG HNJDEELBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x82EA8D0", Offset = "0x82E9CD0", VA = "0x1882EA8D0", Slot = "4")]
	public IDisposable ODNOMLGNGJI(LEGAGIOCBAL PCJJKLDOJMD, Action ADLKPPBLCIG, GAMKDKPALGP BIENFMKKIBH, bool LHBMPBEGJFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x82EAAC0", Offset = "0x82E9EC0", VA = "0x1882EAAC0", Slot = "5")]
	public IDisposable ODNOMLGNGJI(LEGAGIOCBAL PCJJKLDOJMD, Action<float> ADLKPPBLCIG, GAMKDKPALGP BIENFMKKIBH, bool LHBMPBEGJFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x82EA7D0", Offset = "0x82E9BD0", VA = "0x1882EA7D0", Slot = "7")]
	public IDisposable MOFODJDOAFP(LEGAGIOCBAL PCJJKLDOJMD, float MIFCKAIMGDB, Action<float> ADLKPPBLCIG, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x82EA3A0", Offset = "0x82E97A0", VA = "0x1882EA3A0", Slot = "8")]
	public IDisposable GFABCJJHMFB(LEGAGIOCBAL PCJJKLDOJMD, float MIFCKAIMGDB, Action<float> ADLKPPBLCIG, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x82EA650", Offset = "0x82E9A50", VA = "0x1882EA650", Slot = "6")]
	public IDisposable MOFODJDOAFP(float MIFCKAIMGDB, Action<float> ADLKPPBLCIG, bool DFODLBNPDAD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x82EA1E0", Offset = "0x82E95E0", VA = "0x1882EA1E0", Slot = "9")]
	public void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x82EA510", Offset = "0x82E9910", VA = "0x1882EA510")]
	private BOEPCIBHJBB LMOIAMKNKEF(GAMKDKPALGP BIENFMKKIBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class JHLMMGOJCLI : KOGHDGHAPHO, OKJPOJGEILK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NHMLKJIGJMP[] MCKGFDEEMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private CAKEIPBDAHI DGCPLMAGHEN;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x82EED50", Offset = "0x82EE150", VA = "0x1882EED50")]
	[NOCPMGCIOME.CBODKAAMPCM]
	internal static void BBLAOBGDHMG(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x82EF5C0", Offset = "0x82EE9C0", VA = "0x1882EF5C0")]
	[UnityEngine.Scripting.Preserve]
	public JHLMMGOJCLI([CMKKAFOAFJE(null)] JDPMNOBGDAH CFDLKFAJMNB, [CMKKAFOAFJE(null)] FDGCEIPODAG HNJDEELBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x82EE9F0", Offset = "0x82EDDF0", VA = "0x1882EE9F0", Slot = "19")]
	public override LBKCJDEOHAA AMFPCJCMAHN(IGCLHBDADKK PCJJKLDOJMD, IEnumerator<CIKDDGFOAFI> EIOOPEFHLCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x82EF170", Offset = "0x82EE570", VA = "0x1882EF170", Slot = "20")]
	public override void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x82EEB20", Offset = "0x82EDF20", VA = "0x1882EEB20", Slot = "22")]
	public override void ANANINHHPGB(GAMKDKPALGP BIENFMKKIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x82EF4F0", Offset = "0x82EE8F0", VA = "0x1882EF4F0", Slot = "21")]
	protected override void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x82EF4C0", Offset = "0x82EE8C0", VA = "0x1882EF4C0")]
	private NHMLKJIGJMP JKFHIMOPLMJ(GAMKDKPALGP HAFNBBNOLPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x82EEDC0", Offset = "0x82EE1C0", VA = "0x1882EEDC0", Slot = "23")]
	internal override LGHBHHAOOJF DICGJIJOJDD(IEnumerator<CIKDDGFOAFI> EIOOPEFHLCK, Behaviour PCJJKLDOJMD, MBBBLOJIOMF MCOJNHGAONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x82EF400", Offset = "0x82EE800", VA = "0x1882EF400", Slot = "24")]
	internal override GIPJODCKMLH JGHCOBFMLLP(GAMKDKPALGP HKOJAHCOOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x82EF050", Offset = "0x82EE450", VA = "0x1882EF050")]
	private void EIIKJGDNGOB(NHMLKJIGJMP CCMBCEALLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x82EEFF0", Offset = "0x82EE3F0", VA = "0x1882EEFF0", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[BurstCompile]
internal struct NDLFNEMCILE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ReadOnly]
	public float HEJIEJPJLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ReadOnly]
	public int LIGBLGELFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<int> ONANBCEJINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> AHNKEMICNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<int> PBKOPOLGIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ReadOnly]
	public NativeArray<OACGLJJDPGH> HKMHONJLOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	public NativeArray<float> CKFFPCGLIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[WriteOnly]
	public NativeArray<int> MFLMHNPBIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[WriteOnly]
	public NativeArray<int> OBMNFBMILGF;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x82F55A0", Offset = "0x82F49A0", VA = "0x1882F55A0")]
	public static NDLFNEMCILE GNHEPACBJCH(int JNPEAKNMDLH, float BKAEDIDGDFB, NativeArray<OACGLJJDPGH> KDEMDDLPBGP, NativeArray<float> CKEHLEAKIFC, NativeArray<int> AEOBJHJIIDB, NativeArray<int> EMBDFAJANLH, NativeArray<int> JLOMNDADBOC, NativeArray<int> AHNKEMICNBI, NativeArray<int> PBKOPOLGIBJ)
	{
		return default(NDLFNEMCILE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x82F53F0", Offset = "0x82F47F0", VA = "0x1882F53F0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x82F53B0", Offset = "0x82F47B0", VA = "0x1882F53B0")]
	private bool AOIEGAKOAIJ(int CJFNAFNJJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x82F56A0", Offset = "0x82F4AA0", VA = "0x1882F56A0")]
	private void NDLEAIEGFGE(NativeArray<int> MIMDNIFNNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x82F5600", Offset = "0x82F4A00", VA = "0x1882F5600")]
	private int LMNBLCGLNLI(int DIAFJLNIJNO, int GLBDMKECJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x82F54D0", Offset = "0x82F48D0", VA = "0x1882F54D0")]
	private void FGOJDLFLDKG(NativeArray<int> MIMDNIFNNPJ, int BBBBOBBEJCK, int IEDBNFIMLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x82F56D0", Offset = "0x82F4AD0", VA = "0x1882F56D0")]
	private void PMPGEOIIDNN(NativeArray<int> MIMDNIFNNPJ, int POOBILCHBAO, int JLCDNJBBDIA, int AFAPDNGLGGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public abstract class KOGHDGHAPHO : OKJPOJGEILK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly JDPMNOBGDAH CFDLKFAJMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected readonly FDGCEIPODAG HNJDEELBCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private GIPJODCKMLH[] LPLICKAICEI;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static OKJPOJGEILK DNEPPKLGBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x82F2700", Offset = "0x82F1B00", VA = "0x1882F2700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool LCONPCPHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public GAMKDKPALGP HOANBAIMLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9931A0", Offset = "0x9925A0", VA = "0x1809931A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(GAMKDKPALGP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x993250", Offset = "0x992650", VA = "0x180993250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public FDGCEIPODAG GEIBEFEOHFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public CIKDDGFOAFI HPODLCAMKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x9944C0", Offset = "0x9938C0", VA = "0x1809944C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public CIKDDGFOAFI HOMHMNKLFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x994360", Offset = "0x993760", VA = "0x180994360", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public CIKDDGFOAFI OLBBJOEJENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9943C0", Offset = "0x9937C0", VA = "0x1809943C0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CIKDDGFOAFI EDPFJFAACDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x993A70", Offset = "0x992E70", VA = "0x180993A70", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x82F2180", Offset = "0x82F1580", VA = "0x1882F2180")]
	public static LBKCJDEOHAA EGCLGLCIAAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x82F27D0", Offset = "0x82F1BD0", VA = "0x1882F27D0")]
	[UnityEngine.Scripting.Preserve]
	protected KOGHDGHAPHO([CMKKAFOAFJE(null)] JDPMNOBGDAH CFDLKFAJMNB, [CMKKAFOAFJE(null)] FDGCEIPODAG HNJDEELBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x82F1A40", Offset = "0x82F0E40", VA = "0x1882F1A40", Slot = "6")]
	public LBKCJDEOHAA AMNMBKBGPIL(IEnumerator<CIKDDGFOAFI> EIOOPEFHLCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x82F1A50", Offset = "0x82F0E50", VA = "0x1882F1A50", Slot = "7")]
	public LBKCJDEOHAA AMNMBKBGPIL(Behaviour PCJJKLDOJMD, IEnumerator<CIKDDGFOAFI> EIOOPEFHLCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract LBKCJDEOHAA AMFPCJCMAHN(IGCLHBDADKK PCJJKLDOJMD, IEnumerator<CIKDDGFOAFI> EIOOPEFHLCK);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x82F2450", Offset = "0x82F1850", VA = "0x1882F2450", Slot = "20")]
	public virtual void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x82F2210", Offset = "0x82F1610", VA = "0x1882F2210", Slot = "9")]
	public void FGADMBDMOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x82F2790", Offset = "0x82F1B90", VA = "0x1882F2790", Slot = "21")]
	protected virtual void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x82F27B0", Offset = "0x82F1BB0", VA = "0x1882F27B0")]
	private void PAALEGAGDNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x82F1CE0", Offset = "0x82F10E0", VA = "0x1882F1CE0")]
	private void BGLIKCCEPAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x82F2770", Offset = "0x82F1B70", VA = "0x1882F2770")]
	private void NACCOEPNHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x82F25F0", Offset = "0x82F19F0", VA = "0x1882F25F0")]
	private void GLMKDEJNHNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x82F1D00", Offset = "0x82F1100", VA = "0x1882F1D00")]
	private void CIFABKMFNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x82F1D80", Offset = "0x82F1180", VA = "0x1882F1D80")]
	private void DNHAOKGOAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x82F2160", Offset = "0x82F1560", VA = "0x1882F2160")]
	private void EFJAELFFHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x82F1C50", Offset = "0x82F1050", VA = "0x1882F1C50", Slot = "22")]
	public virtual void ANANINHHPGB(GAMKDKPALGP BIENFMKKIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x82F1870", Offset = "0x82F0C70", VA = "0x1882F1870")]
	private void ADJHAALFDEO(GIPJODCKMLH CCMBCEALLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2576010", Offset = "0x2575410", VA = "0x182576010")]
	private GIPJODCKMLH AHODPDGPPHF(GAMKDKPALGP HAFNBBNOLPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract LGHBHHAOOJF DICGJIJOJDD(IEnumerator<CIKDDGFOAFI> EIOOPEFHLCK, Behaviour NAECADIONFH, MBBBLOJIOMF CNMNNNBIJND);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract GIPJODCKMLH JGHCOBFMLLP(GAMKDKPALGP BIENFMKKIBH);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x82F1DA0", Offset = "0x82F11A0", VA = "0x1882F1DA0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x82F1D20", Offset = "0x82F1120", VA = "0x1882F1D20", Slot = "15")]
	public CIKDDGFOAFI DEOODLAONOC(GAMKDKPALGP HKOJAHCOOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x82F2670", Offset = "0x82F1A70", VA = "0x1882F2670", Slot = "16")]
	public CIKDDGFOAFI LJKOBIKBPKF(float PCFGHPNONAI, GAMKDKPALGP HKOJAHCOOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x82F2610", Offset = "0x82F1A10", VA = "0x1882F2610", Slot = "17")]
	public CIKDDGFOAFI LBJLBEDDCFL(Func<bool> LNDKBMLMEBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class LGHBHHAOOJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly MBBBLOJIOMF MCOJNHGAONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly HEOACCKMHOL PCJJKLDOJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly bool IAEHCJGCJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private string IGEPDAOOLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private StackTrace GFBGIIKFMLP;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<CIKDDGFOAFI> LMDAPDGOMBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x994500", Offset = "0x993900", VA = "0x180994500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public CIKDDGFOAFI LJNAJLFNOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x993210", Offset = "0x992610", VA = "0x180993210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool AFHDMDMGJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x82F2DA0", Offset = "0x82F21A0", VA = "0x1882F2DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool HNLIDJCMAPI
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xB583D0", Offset = "0xB577D0", VA = "0x180B583D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xBA5330", Offset = "0xBA4730", VA = "0x180BA5330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x82F31B0", Offset = "0x82F25B0", VA = "0x1882F31B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float AGGDCAALGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xF6EB50", Offset = "0xF6DF50", VA = "0x180F6EB50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6C98BF0", Offset = "0x6C97FF0", VA = "0x186C98BF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x82F3490", Offset = "0x82F2890", VA = "0x1882F3490")]
	public LGHBHHAOOJF(IEnumerator<CIKDDGFOAFI> GBBPIGBGDCL, HEOACCKMHOL PCJJKLDOJMD, MBBBLOJIOMF MCOJNHGAONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x82F2E90", Offset = "0x82F2290", VA = "0x1882F2E90")]
	public CIKDDGFOAFI LGHLLEGIGPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x82F2E20", Offset = "0x82F2220", VA = "0x1882F2E20")]
	public bool KIDKHJMECCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x82F3360", Offset = "0x82F2760", VA = "0x1882F3360")]
	public void OAALHNMPGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x82F33B0", Offset = "0x82F27B0", VA = "0x1882F33B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xBEC140", Offset = "0xBEB540", VA = "0x180BEC140")]
	[CompilerGenerated]
	private void IOPJLLHCAPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class MBBBLOJIOMF : MHGNMOLLGMD, LBKCJDEOHAA, NAHOFKDLLJE, DJNFHDJGNJD, IEnumerator, CIKDDGFOAFI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private GAMKDKPALGP LPPMLJFIMDI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private GAMKDKPALGP GAPMHBKJMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xCC8400", Offset = "0xCC7800", VA = "0x180CC8400", Slot = "23")]
		get
		{
			return default(GAMKDKPALGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GAMKDKPALGP JHHDOLAHEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xE5D060", Offset = "0xE5C460", VA = "0x180E5D060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float OCNLPNGCDJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xB1EA40", Offset = "0xB1DE40", VA = "0x180B1EA40", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool IAHLOPJBGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x82F3D10", Offset = "0x82F3110", VA = "0x1882F3D10", Slot = "24")]
	private bool BKIOAHNMIKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x82F3D30", Offset = "0x82F3130", VA = "0x1882F3D30", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x82F3D40", Offset = "0x82F3140", VA = "0x1882F3D40")]
	public MBBBLOJIOMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal enum FOFLFGDMFGB : byte
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
internal sealed class GIPJODCKMLH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum FFOBHIMNPDL
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct BAEAKMMJCOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public GAMKDKPALGP EFCNOOGOMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public FFOBHIMNPDL HAGENLFMPPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public List<LGHBHHAOOJF> EJBMPNFFCIG;
	}

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly FFOBHIMNPDL[] PAFLBKGNHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly GAMKDKPALGP BIENFMKKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool KPNOJIOOMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly LGHBHHAOOJF[] KOGADAOGAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly List<LGHBHHAOOJF> NLPBDJPGHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Stack<int> INLOAMEADOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly List<LGHBHHAOOJF> LLOCGFDLHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Stack<int> PDBIPDDAFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly CAKEIPBDAHI AOOELDLLOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool BPBLJHNDPBA;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BAEAKMMJCOP[,] LDBKAKHMJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9943C0", Offset = "0x9937C0", VA = "0x1809943C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x82ECCD0", Offset = "0x82EC0D0", VA = "0x1882ECCD0")]
	public GIPJODCKMLH(GAMKDKPALGP HKOJAHCOOEL, CAKEIPBDAHI AOOELDLLOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x82EC3E0", Offset = "0x82EB7E0", VA = "0x1882EC3E0")]
	public void FJGPAOHPFPP(LGHBHHAOOJF GBBPIGBGDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x82EBAB0", Offset = "0x82EAEB0", VA = "0x1882EBAB0")]
	public void CAICJJKCDCD(IList<LGHBHHAOOJF> LGMPNMHCPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x82EBDC0", Offset = "0x82EB1C0", VA = "0x1882EBDC0")]
	public void DGHDCIAICNO(IList<LGHBHHAOOJF> LGMPNMHCPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x82EC660", Offset = "0x82EBA60", VA = "0x1882EC660")]
	private void HGHJMFKMDLI(LGHBHHAOOJF GBBPIGBGDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x82EC750", Offset = "0x82EBB50", VA = "0x1882EC750")]
	private void NDMJBFCABGN(IList<LGHBHHAOOJF> LGMPNMHCPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x82EC4E0", Offset = "0x82EB8E0", VA = "0x1882EC4E0")]
	private FOFLFGDMFGB GNMAJKFPJBL(LGHBHHAOOJF GBBPIGBGDCL)
	{
		return default(FOFLFGDMFGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x82EC8E0", Offset = "0x82EBCE0", VA = "0x1882EC8E0")]
	public void ODNOMLGNGJI(float BKAEDIDGDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x82EC1F0", Offset = "0x82EB5F0", VA = "0x1882EC1F0")]
	public void FGADMBDMOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x82EB750", Offset = "0x82EAB50", VA = "0x1882EB750")]
	private void AEPFOKAKIBJ(List<LGHBHHAOOJF> LGMPNMHCPPB, Stack<int> FKDODBOKOOK, bool PFOBALJIODA, float AIPDKLKBJCH = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x82EC0D0", Offset = "0x82EB4D0", VA = "0x1882EC0D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x82ECA50", Offset = "0x82EBE50", VA = "0x1882ECA50")]
	private void OECBFFKDFAC(List<LGHBHHAOOJF> LGMPNMHCPPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class FMIKGMDDAOA : CAKEIPBDAHI
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "4")]
	public void LLFDMDAFOJA(string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
	public void IBMBHPJMPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public FMIKGMDDAOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal class HBLOPBLACOC : HEOACCKMHOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Behaviour NAECADIONFH;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x82ED860", Offset = "0x82ECC60", VA = "0x1882ED860", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool ECMLJIKMDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x82ED8E0", Offset = "0x82ECCE0", VA = "0x1882ED8E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool FDBBOLDOOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x82ED840", Offset = "0x82ECC40", VA = "0x1882ED840", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	public HBLOPBLACOC(Behaviour NAECADIONFH)
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

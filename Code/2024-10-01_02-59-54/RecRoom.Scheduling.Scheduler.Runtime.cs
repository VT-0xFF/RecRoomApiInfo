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
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7761C80", Offset = "0x7761080", VA = "0x187761C80", Slot = "8")]
		public override void NALDPPFDOAA(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
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
		private delegate List<PlayerLoopSystem> DEILNKMOECC(List<PlayerLoopSystem> CJGJKEAFPHP, int EGOPMOBHHBI);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct MDMHBIFKIPM
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct LLJJHFDDOJM
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static LKILNMKOKHH FBCDCHFLBEA;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x7759850", Offset = "0x7758C50", VA = "0x187759850")]
				public static PlayerLoopSystem KBIAPPCPOOM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct EFDNCAHJEKL
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static LKILNMKOKHH KMJAMDBGBEG;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x774E690", Offset = "0x774DA90", VA = "0x18774E690")]
				public static PlayerLoopSystem KBIAPPCPOOM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct ENGNNJCDDDM
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static LKILNMKOKHH IIFKEBMIOLM;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x774ED40", Offset = "0x774E140", VA = "0x18774ED40")]
				public static PlayerLoopSystem KBIAPPCPOOM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct JBCLJHHEKNP
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static LKILNMKOKHH MAMHMPGGGIA;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static LKILNMKOKHH AEAGJJCEEOK;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static LKILNMKOKHH GKELKAHGGEP;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static LKILNMKOKHH HGJENKNIAPA;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x7754960", Offset = "0x7753D60", VA = "0x187754960")]
				public static PlayerLoopSystem KBIAPPCPOOM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct PBCFGFBPGNL
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static LKILNMKOKHH OOJMLIABEHF;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x775FF00", Offset = "0x775F300", VA = "0x18775FF00")]
				public static PlayerLoopSystem KBIAPPCPOOM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct CDPLMNMENBO
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static LKILNMKOKHH MAMHMPGGGIA;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static LKILNMKOKHH AEAGJJCEEOK;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static LKILNMKOKHH GKELKAHGGEP;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static LKILNMKOKHH HGJENKNIAPA;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x77494E0", Offset = "0x77488E0", VA = "0x1877494E0")]
				public static PlayerLoopSystem KBIAPPCPOOM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct PGHJKAEBBIH
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static LKILNMKOKHH BNJFKMKIJCM;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x7760900", Offset = "0x775FD00", VA = "0x187760900")]
				public static PlayerLoopSystem KBIAPPCPOOM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct JNMFNJBBHCL
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static LKILNMKOKHH ODLGJICGMAM;

				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x77582B0", Offset = "0x77576B0", VA = "0x1877582B0")]
				public static PlayerLoopSystem KBIAPPCPOOM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct NIKIMCHAFNF
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static LKILNMKOKHH JBMFMMKNHEM;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x775DFF0", Offset = "0x775D3F0", VA = "0x18775DFF0")]
				public static PlayerLoopSystem KBIAPPCPOOM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct EPFOHHBHAIH
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static LKILNMKOKHH OCDHJGFDIBD;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x7750090", Offset = "0x774F490", VA = "0x187750090")]
				public static PlayerLoopSystem KBIAPPCPOOM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct HKKAOEKELAL
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static LKILNMKOKHH AAOBLOOCHLO;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x7752F90", Offset = "0x7752390", VA = "0x187752F90")]
				public static PlayerLoopSystem KBIAPPCPOOM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct MJCCAMJDBBP
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static LKILNMKOKHH FBPEEEGOBCF;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x7759C50", Offset = "0x7759050", VA = "0x187759C50")]
				public static PlayerLoopSystem KBIAPPCPOOM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct EEBMDKHDGAK
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static LKILNMKOKHH JAJKJBLHAHH;

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x774E4B0", Offset = "0x774D8B0", VA = "0x18774E4B0")]
				public static PlayerLoopSystem KBIAPPCPOOM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum BJJJODMBNEK : byte
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
			public struct DNBBKLIDJNJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class DCFJBGCLEFI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public BJJJODMBNEK updateStage;

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
					public DCFJBGCLEFI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x774E050", Offset = "0x774D450", VA = "0x18774E050")]
					internal void GNGKOPOJJME()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static JEIAMONHOFF<BJJJODMBNEK> PEIAMOHJKJJ;

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x774E1D0", Offset = "0x774D5D0", VA = "0x18774E1D0")]
				public static PlayerLoopSystem KBIAPPCPOOM(BJJJODMBNEK PFIMEGOCKAG)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			internal struct ALCOFGFEGGA
			{
				[Cpp2IlInjected.Token(Token = "0x2000024")]
				[CompilerGenerated]
				private sealed class HIEDIBJAGKH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public AODGHLBAHBP.GOBLNKGLOJP key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
					public HIEDIBJAGKH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x7752D10", Offset = "0x7752110", VA = "0x187752D10")]
					internal void PEFLNCLLCMG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable LHINPBHIFPP;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x7745F50", Offset = "0x7745350", VA = "0x187745F50")]
				public static PlayerLoopSystem EINPCCLLEHK(AODGHLBAHBP.GOBLNKGLOJP GMJINMLEEAC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			internal struct PFEBGDBLACB
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class GFCBDHPNIKE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public AODGHLBAHBP.GOBLNKGLOJP key;

					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
					public GFCBDHPNIKE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0x7752230", Offset = "0x7751630", VA = "0x187752230")]
					internal void PEFLNCLLCMG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x77607D0", Offset = "0x775FBD0", VA = "0x1877607D0")]
				public static PlayerLoopSystem EINPCCLLEHK(AODGHLBAHBP.GOBLNKGLOJP GMJINMLEEAC)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class GIPILCMBJDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public GIPILCMBJDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7752550", Offset = "0x7751950", VA = "0x187752550")]
			internal List<PlayerLoopSystem> LIFDCLCGNFL(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool JBCCLFOIEIF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool FGJFECGKAIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x774A260", Offset = "0x7749660", VA = "0x18774A260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x774AD20", Offset = "0x774A120", VA = "0x18774AD20")]
		private static void EGNNGEIMOAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x774A2A0", Offset = "0x77496A0", VA = "0x18774A2A0")]
		private static void AEPEHGMAFCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x774ACE0", Offset = "0x774A0E0", VA = "0x18774ACE0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x774DE10", Offset = "0x774D210", VA = "0x18774DE10")]
		private static void JNODPEAGJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x774DC50", Offset = "0x774D050", VA = "0x18774DC50")]
		private static void JLOCFPFDKFI(AODGHLBAHBP.GOBLNKGLOJP GMJINMLEEAC, PlayerLoopSystem EBNMBAMECNO, Type MCDGDLNGGIE, Type MNPAMINJKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x774D870", Offset = "0x774CC70", VA = "0x18774D870")]
		private static void HCMBGEHOMPP(PlayerLoopSystem EBNMBAMECNO, Type MCDGDLNGGIE, Type MNPAMINJKEC, DEILNKMOECC JGOBBMKLENB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x774ABB0", Offset = "0x7749FB0", VA = "0x18774ABB0")]
		private static void ANPFIBKCFJI(PlayerLoopSystem EBNMBAMECNO, Type MCDGDLNGGIE, Type MNPAMINJKEC, PlayerLoopSystem? KPPPLLFIJDO, PlayerLoopSystem? GNOHNDAKPCO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class AODGHLBAHBP
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum GOBLNKGLOJP
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
	public class OFFMAKHJALI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly GOBLNKGLOJP HKPGEBHAIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly IBJAOINPMMO EOLKOGLEGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private long KAKFEHLDJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long PEPGAIICPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long AFGGNIHJAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int KIJKAOJAJAI;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x775E470", Offset = "0x775D870", VA = "0x18775E470")]
		public OFFMAKHJALI(GOBLNKGLOJP CONLGHPMLBO, int HACMFJOBBMB = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x775E220", Offset = "0x775D620", VA = "0x18775E220")]
		public void JLKHHLMIHII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x775E1D0", Offset = "0x775D5D0", VA = "0x18775E1D0")]
		public void FEEDKHEKNPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x775E290", Offset = "0x775D690", VA = "0x18775E290")]
		public void KHEGDNDJJNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static GOBLNKGLOJP[] NMBCHIOJLHB;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static OFFMAKHJALI[] MJFODHGOODB;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x77466D0", Offset = "0x7745AD0", VA = "0x1877466D0")]
	public static OFFMAKHJALI PIKJLIIMBEP(GOBLNKGLOJP GMJINMLEEAC, int HACMFJOBBMB = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x77465C0", Offset = "0x77459C0", VA = "0x1877465C0")]
	public static OFFMAKHJALI HJPJKDEOENA(GOBLNKGLOJP GMJINMLEEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7746630", Offset = "0x7745A30", VA = "0x187746630")]
	public static void KCOJCHMNION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IBJAOINPMMO : NFNDFNKNDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int ACJCICMFMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Queue<double> OIJCPDHGFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double GOCGGGCOOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double GGBNJANNJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double IDPICBPMDNF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double OPOJAGJCFNP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7753300", Offset = "0x7752700", VA = "0x187753300", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double HELPNFFADBK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1F66850", Offset = "0x1F65C50", VA = "0x181F66850", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double OOFPMMLKEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x21CD0E0", Offset = "0x21CC4E0", VA = "0x1821CD0E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7753360", Offset = "0x7752760", VA = "0x187753360")]
	public IBJAOINPMMO(int GMJAKNADMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x77531E0", Offset = "0x77525E0", VA = "0x1877531E0", Slot = "7")]
	public void DKEGMODEBAO(double HMBPNLCBEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7753170", Offset = "0x7752570", VA = "0x187753170", Slot = "8")]
	public void AEAEDDMNDLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class PBBEBECMCJF : NFNDFNKNDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private long MGEMHICLKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double PCDIAKDCGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double KOFGJNEHKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double KOLMPANKPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double NIHCKAMHDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double GOCGGGCOOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double GGBNJANNJDO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double HELPNFFADBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x634FB20", Offset = "0x634EF20", VA = "0x18634FB20", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double OOFPMMLKEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x92A350", Offset = "0x929750", VA = "0x18092A350", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double OKMFFANIFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x634FFB0", Offset = "0x634F3B0", VA = "0x18634FFB0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double OPOJAGJCFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x27F2B30", Offset = "0x27F1F30", VA = "0x1827F2B30", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x775FDE0", Offset = "0x775F1E0", VA = "0x18775FDE0", Slot = "7")]
	public virtual void DKEGMODEBAO(double HMBPNLCBEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x775FDA0", Offset = "0x775F1A0", VA = "0x18775FDA0", Slot = "8")]
	public virtual void AEAEDDMNDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7759FA0", Offset = "0x77593A0", VA = "0x187759FA0")]
	public PBBEBECMCJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class MLOPMONCLFB : PBBEBECMCJF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double FHHHFDLMDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x634FB50", Offset = "0x634EF50", VA = "0x18634FB50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x634FF80", Offset = "0x634F380", VA = "0x18634FF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7759E70", Offset = "0x7759270", VA = "0x187759E70", Slot = "7")]
	public override void DKEGMODEBAO(double HMBPNLCBEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7759E30", Offset = "0x7759230", VA = "0x187759E30", Slot = "8")]
	public override void AEAEDDMNDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7759FA0", Offset = "0x77593A0", VA = "0x187759FA0")]
	public MLOPMONCLFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface NFNDFNKNDEF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double OPOJAGJCFNP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double HELPNFFADBK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double OOFPMMLKEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class IMEOHIBHKHA
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface IHLDFPGMCAC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool LBGGMPCFFKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ONAFBBOMACN();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class MMFIAHFJMKP : IHLDFPGMCAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly Action MDOOJHKFGMP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool LBGGMPCFFKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
		public MMFIAHFJMKP(Action MDOOJHKFGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xC3FA60", Offset = "0xC3EE60", VA = "0x180C3FA60", Slot = "5")]
		public void ONAFBBOMACN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<IHLDFPGMCAC> KCEAMKNGKBJ;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7754130", Offset = "0x7753530", VA = "0x187754130")]
	public static void EHJMBIBOPFI(Action MDOOJHKFGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x77542D0", Offset = "0x77536D0", VA = "0x1877542D0")]
	private static void MHOHLEFDNCL(IHLDFPGMCAC FNJGNHCEIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x77544E0", Offset = "0x77538E0", VA = "0x1877544E0")]
	private static void NEAMLLMJBKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x77541D0", Offset = "0x77535D0", VA = "0x1877541D0")]
	private static void KJBOIEEMGBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x77547C0", Offset = "0x7753BC0", VA = "0x1877547C0")]
	private static void OHJBAEADEAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class JFECJCBPBBM
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct EHCPNOPPPFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public TaskCompletionSource<Scene> JHNNDDHMCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly string KLBNILGILEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly LoadSceneMode FMBCIMAFGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly bool GAPNJMHJJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x774ECE0", Offset = "0x774E0E0", VA = "0x18774ECE0")]
		public EHCPNOPPPFC(TaskCompletionSource<Scene> ONBCLJCPOHM, string KLBNILGILEM, LoadSceneMode FMBCIMAFGOA, bool GAPNJMHJJDP, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct JIMALDAOGDH : IAsyncStateMachine
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
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private PMKGFNIFFEC<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x7756F50", Offset = "0x7756350", VA = "0x187756F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x77577F0", Offset = "0x7756BF0", VA = "0x1877577F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct JILALEBHIKK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7756BE0", Offset = "0x7755FE0", VA = "0x187756BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7756EF0", Offset = "0x77562F0", VA = "0x187756EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct JCKGFOPBMJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private EHCPNOPPPFC <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7754CF0", Offset = "0x77540F0", VA = "0x187754CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x77550B0", Offset = "0x77544B0", VA = "0x1877550B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class ACBPIKBCNME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public DNAIJKLAJHB<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public ACBPIKBCNME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7745EF0", Offset = "0x77452F0", VA = "0x187745EF0")]
		internal void PCFOABLEIMI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct BJEMDDCEAAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

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
		private ACBPIKBCNME <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private PMKGFNIFFEC<string>.INNANANOCLO <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x77483D0", Offset = "0x77477D0", VA = "0x1877483D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7748F30", Offset = "0x7748330", VA = "0x187748F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct BNGBFIEKEHD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7748FA0", Offset = "0x77483A0", VA = "0x187748FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7749470", Offset = "0x7748870", VA = "0x187749470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct NGIIILNELGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private PMKGFNIFFEC<string>.INNANANOCLO <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private PMKGFNIFFEC<string>.INNANANOCLO <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x775D330", Offset = "0x775C730", VA = "0x18775D330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x775DE50", Offset = "0x775D250", VA = "0x18775DE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class ALOMNPAAEFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public ALOMNPAAEFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7746080", Offset = "0x7745480", VA = "0x187746080")]
		internal bool BLEIJCFHADP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class EGDMPACLPDF : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public PMBKNNIBFAH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public EGDMPACLPDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x774EC50", Offset = "0x774E050", VA = "0x18774EC50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x774E870", Offset = "0x774DC70", VA = "0x18774E870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x774EBB0", Offset = "0x774DFB0", VA = "0x18774EBB0")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x774EC00", Offset = "0x774E000", VA = "0x18774EC00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class KEFMFEAIDOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public DNAIJKLAJHB<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public KEFMFEAIDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x77588E0", Offset = "0x7757CE0", VA = "0x1877588E0")]
		internal bool CIBEBJAAIOG(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7758960", Offset = "0x7757D60", VA = "0x187758960")]
		internal void NKIGOENHCJP(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class JINFHKABCBK : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public DNAIJKLAJHB<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private KEFMFEAIDOM <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public JINFHKABCBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7757860", Offset = "0x7756C60", VA = "0x187757860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7757EC0", Offset = "0x77572C0", VA = "0x187757EC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly ICollection<string> CHCNFNFKBNN;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AOFGCNMIPIP NEPEHBBLDBN;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static AsyncOperation NHHABHJFIDA;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static AOFGCNMIPIP KJFOCEGGKPN;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static string MFLAHGOMHAI;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static ThreadPriority HLPDMCMCJIL;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static Task POPDLGJCDKE;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static List<SceneInstance> DHCCOPFIIIL;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly Queue<EHCPNOPPPFC> GGICPPKOLFC;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static Task EMNHMNFHEEA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool EMIOFELIIIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x77566E0", Offset = "0x7755AE0", VA = "0x1877566E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private static bool HFPLPFDCDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7755A10", Offset = "0x7754E10", VA = "0x187755A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private static bool FGICGIFNEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7756370", Offset = "0x7755770", VA = "0x187756370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool ACCLLIHKBPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7755870", Offset = "0x7754C70", VA = "0x187755870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> NCPJCGABJAM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7755DF0", Offset = "0x77551F0", VA = "0x187755DF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7756260", Offset = "0x7755660", VA = "0x187756260")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7756560", Offset = "0x7755960", VA = "0x187756560")]
	[PNBDIHKPGLO(BDADFFMLEGJ.EnteredEditModeNextFrame, 0)]
	private static void MDEHNDOCHDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7756410", Offset = "0x7755810", VA = "0x187756410")]
	[AsyncStateMachine(typeof(JIMALDAOGDH))]
	public static Task<Scene> MCGDKCCMJPJ(string KLBNILGILEM, LoadSceneMode FMBCIMAFGOA = LoadSceneMode.Single, bool GAPNJMHJJDP = false, [Optional] PMKGFNIFFEC<string>.INNANANOCLO EKMIPGEEPAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x77557C0", Offset = "0x7754BC0", VA = "0x1877557C0")]
	[AsyncStateMachine(typeof(JILALEBHIKK))]
	private static Task DJPGFCAMKLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7755C00", Offset = "0x7755000", VA = "0x187755C00")]
	[AsyncStateMachine(typeof(JCKGFOPBMJG))]
	private static Task GFFBIIFOOPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7755AB0", Offset = "0x7754EB0", VA = "0x187755AB0")]
	[AsyncStateMachine(typeof(BJEMDDCEAAM))]
	private static Task<Scene> GBNPAMBBDDA(string KLBNILGILEM, LoadSceneMode FMBCIMAFGOA, bool GAPNJMHJJDP, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x77556B0", Offset = "0x7754AB0", VA = "0x1877556B0")]
	private static void CNAIHLICOOD(SceneInstance FECLIDFMLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x77554B0", Offset = "0x77548B0", VA = "0x1877554B0")]
	private static void CJEPHJONBLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7755CD0", Offset = "0x77550D0", VA = "0x187755CD0")]
	[AsyncStateMachine(typeof(BNGBFIEKEHD))]
	private static Task<Scene> IGAJNNDLFLH(string KLBNILGILEM, LoadSceneMode FMBCIMAFGOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7755240", Offset = "0x7754640", VA = "0x187755240")]
	private static bool BENEDDHDDGL(string KLBNILGILEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7755900", Offset = "0x7754D00", VA = "0x187755900")]
	[AsyncStateMachine(typeof(NGIIILNELGC))]
	private static Task<Scene> EIHIGEOODMF(PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7755330", Offset = "0x7754730", VA = "0x187755330")]
	public static MIJNEIJMPHL<Scene> BIODGLIFFNF(string KLBNILGILEM, LoadSceneMode FMBCIMAFGOA = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7755F00", Offset = "0x7755300", VA = "0x187755F00")]
	public static AOFGCNMIPIP IPFHHJABLOD(string KLBNILGILEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7756650", Offset = "0x7755A50", VA = "0x187756650")]
	[IteratorStateMachine(typeof(EGDMPACLPDF))]
	private static IEnumerator<BGFGBHFIDBJ> NECLGJBJECP(string KLBNILGILEM, PMBKNNIBFAH GKFJPBHADKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x77561C0", Offset = "0x77555C0", VA = "0x1877561C0")]
	[IteratorStateMachine(typeof(JINFHKABCBK))]
	private static IEnumerator<BGFGBHFIDBJ> JACBLFCHIHK(string KLBNILGILEM, LoadSceneMode FMBCIMAFGOA, DNAIJKLAJHB<Scene> GKFJPBHADKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7755110", Offset = "0x7754510", VA = "0x187755110")]
	public static bool BEEABGHEFCP([Out] string HCAHGOFHJGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class KKNONFJCDNM
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7758DA0", Offset = "0x77581A0", VA = "0x187758DA0")]
	public static IDisposable PGCFONMGCNO(this PALDPPFGJJL JCPOMHNJOIE, float HMOCOKIPLGG, Action<float> LLIBDNOHPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7758D20", Offset = "0x7758120", VA = "0x187758D20")]
	public static IDisposable MGMHJCLCFHI(this PALDPPFGJJL JCPOMHNJOIE, Action<float> LLIBDNOHPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7758CA0", Offset = "0x77580A0", VA = "0x187758CA0")]
	public static IDisposable CJOFNLOKPDF(this PALDPPFGJJL JCPOMHNJOIE, Action<float> LLIBDNOHPIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class OOMLKBKOPPL
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x775F910", Offset = "0x775ED10", VA = "0x18775F910")]
	public static IDisposable JHHLAMJICMA(this MonoBehaviour DLBIKABGMBD, Action LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x775F9A0", Offset = "0x775EDA0", VA = "0x18775F9A0")]
	public static IDisposable JHHLAMJICMA(this MonoBehaviour DLBIKABGMBD, Action<float> LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x775F560", Offset = "0x775E960", VA = "0x18775F560")]
	public static IDisposable BNOGHBKOPKE(this MonoBehaviour DLBIKABGMBD, Action LLIBDNOHPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x775FA30", Offset = "0x775EE30", VA = "0x18775FA30")]
	public static IDisposable KAHPMMMCNAP(this MonoBehaviour DLBIKABGMBD, Action LLIBDNOHPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x775FAB0", Offset = "0x775EEB0", VA = "0x18775FAB0")]
	public static IDisposable KAHPMMMCNAP(this MonoBehaviour DLBIKABGMBD, Action<float> LLIBDNOHPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x775F2F0", Offset = "0x775E6F0", VA = "0x18775F2F0")]
	public static IDisposable AHGKCABLPAP(this MonoBehaviour DLBIKABGMBD, Action LLIBDNOHPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x775F720", Offset = "0x775EB20", VA = "0x18775F720")]
	public static IDisposable FMPFMMBGBIL(this MonoBehaviour DLBIKABGMBD, Action LLIBDNOHPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x775FC80", Offset = "0x775F080", VA = "0x18775FC80")]
	public static IDisposable ONFCOABCFPL(this MonoBehaviour DLBIKABGMBD, Action LLIBDNOHPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x775FBD0", Offset = "0x775EFD0", VA = "0x18775FBD0")]
	public static IDisposable OJIELGCOGOM(this MonoBehaviour DLBIKABGMBD, float HMOCOKIPLGG, Action<float> LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO, bool PEBIHMGODLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x775F840", Offset = "0x775EC40", VA = "0x18775F840")]
	public static IDisposable HBMDPFAPNPI(this MonoBehaviour DLBIKABGMBD, float HMOCOKIPLGG, Action<float> LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO, bool PEBIHMGODLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x775F870", Offset = "0x775EC70", VA = "0x18775F870")]
	public static IDisposable IOEBJKLGCML(this MonoBehaviour DLBIKABGMBD, float HMOCOKIPLGG, Action<float> LLIBDNOHPIL, bool PEBIHMGODLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x775F5E0", Offset = "0x775E9E0", VA = "0x18775F5E0")]
	public static IDisposable CAKIBPCFGGF(this MonoBehaviour DLBIKABGMBD, Action<float> LLIBDNOHPIL, bool PEBIHMGODLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x775F4C0", Offset = "0x775E8C0", VA = "0x18775F4C0")]
	public static IDisposable BIGOAPEMKKP(this MonoBehaviour DLBIKABGMBD, Action<float> LLIBDNOHPIL, bool PEBIHMGODLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x775F680", Offset = "0x775EA80", VA = "0x18775F680")]
	public static IDisposable EBFNJGCIOAN(this MonoBehaviour DLBIKABGMBD, Action<float> LLIBDNOHPIL, bool PEBIHMGODLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x775FB30", Offset = "0x775EF30", VA = "0x18775FB30")]
	public static IDisposable MPAAEOABPHG(this MonoBehaviour DLBIKABGMBD, Action<float> LLIBDNOHPIL, bool PEBIHMGODLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x775F420", Offset = "0x775E820", VA = "0x18775F420")]
	public static IDisposable AMOGDBEEFFC(this MonoBehaviour DLBIKABGMBD, Action<float> LLIBDNOHPIL, bool PEBIHMGODLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x775FD00", Offset = "0x775F100", VA = "0x18775FD00")]
	public static IDisposable PKNGGLHBPGD(this MonoBehaviour DLBIKABGMBD, Action<float> LLIBDNOHPIL, bool PEBIHMGODLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x775F7A0", Offset = "0x775EBA0", VA = "0x18775F7A0")]
	public static IDisposable GPFLIKCFLEE(this MonoBehaviour DLBIKABGMBD, Action<float> LLIBDNOHPIL, bool PEBIHMGODLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x775F370", Offset = "0x775E770", VA = "0x18775F370")]
	public static IDisposable AJKGBDGGJDN(this MonoBehaviour DLBIKABGMBD, float HMOCOKIPLGG, Action<float> LLIBDNOHPIL, bool PEBIHMGODLB = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class OFPCHMEJAPN
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class NHAMHEALJMB : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public BEGIGAMJKID queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private HICNBMJIOOP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public NHAMHEALJMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x775DEC0", Offset = "0x775D2C0", VA = "0x18775DEC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x775DFA0", Offset = "0x775D3A0", VA = "0x18775DFA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class EPKNLKPLCBN : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public BEGIGAMJKID queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private HICNBMJIOOP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public EPKNLKPLCBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7750270", Offset = "0x774F670", VA = "0x187750270", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7750360", Offset = "0x774F760", VA = "0x187750360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x775E6A0", Offset = "0x775DAA0", VA = "0x18775E6A0")]
	public static GJOIDBBGEPO JHHLAMJICMA(Action LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x775E720", Offset = "0x775DB20", VA = "0x18775E720")]
	public static GJOIDBBGEPO JHHLAMJICMA(Behaviour JCPOMHNJOIE, Action LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x775E7B0", Offset = "0x775DBB0", VA = "0x18775E7B0")]
	public static GJOIDBBGEPO JHHLAMJICMA(Behaviour JCPOMHNJOIE, Action<float> LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x775E580", Offset = "0x775D980", VA = "0x18775E580")]
	[IteratorStateMachine(typeof(NHAMHEALJMB))]
	private static IEnumerator<BGFGBHFIDBJ> BEENBLNMGEE(BEGIGAMJKID KOHLIHJCJJO, Action LLIBDNOHPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x775E610", Offset = "0x775DA10", VA = "0x18775E610")]
	[IteratorStateMachine(typeof(EPKNLKPLCBN))]
	private static IEnumerator<BGFGBHFIDBJ> BEENBLNMGEE(BEGIGAMJKID KOHLIHJCJJO, Action<float> LLIBDNOHPIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class PMONKAMGIHA : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class KKLPBAKCLFH : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public PMONKAMGIHA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public KKLPBAKCLFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7758BC0", Offset = "0x7757FC0", VA = "0x187758BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7758C50", Offset = "0x7758050", VA = "0x187758C50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly BEGIGAMJKID IKCILLPFALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Action DJKLHBJOEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private bool NDEGEJKEGFA;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool EAOCHOMFNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B80B0", Offset = "0x8B74B0", VA = "0x1808B80B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7760C40", Offset = "0x7760040", VA = "0x187760C40")]
	public PMONKAMGIHA(BEGIGAMJKID IKCILLPFALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7760B20", Offset = "0x775FF20", VA = "0x187760B20")]
	[IteratorStateMachine(typeof(KKLPBAKCLFH))]
	private IEnumerator<BGFGBHFIDBJ> MJGKCFBOEJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7760BA0", Offset = "0x775FFA0", VA = "0x187760BA0", Slot = "4")]
	public void OnCompleted(Action DOFOBGNCCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	public void JFLFAPJJJOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class MALLNIBAJKB
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7759B40", Offset = "0x7758F40", VA = "0x187759B40")]
	public static PMONKAMGIHA LFNEGOGFAAD(this BEGIGAMJKID IKCILLPFALO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class AMJHNGCDPCN
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class MNLKCFCCJOI : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public MPKMPPEAJCL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public MNLKCFCCJOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7759FD0", Offset = "0x77593D0", VA = "0x187759FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x775A050", Offset = "0x7759450", VA = "0x18775A050", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7746390", Offset = "0x7745790", VA = "0x187746390")]
	public static GJOIDBBGEPO JHHLAMJICMA(float HMOCOKIPLGG, Action<float> LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO, bool PEBIHMGODLB = true, [Optional] NCDAGLAIKFO NOKFECGCJOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7746460", Offset = "0x7745860", VA = "0x187746460")]
	public static GJOIDBBGEPO JHHLAMJICMA(MonoBehaviour DLBIKABGMBD, float HMOCOKIPLGG, Action<float> LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO, bool PEBIHMGODLB = true, [Optional] NCDAGLAIKFO NOKFECGCJOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7746170", Offset = "0x7745570", VA = "0x187746170")]
	public static GJOIDBBGEPO DKFPLAJBJJG(MonoBehaviour DLBIKABGMBD, float HMOCOKIPLGG, Action<float> LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO, bool PEBIHMGODLB = true, [Optional] NCDAGLAIKFO NOKFECGCJOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7746260", Offset = "0x7745660", VA = "0x187746260")]
	public static GJOIDBBGEPO EPEOEFLKKHF(PALDPPFGJJL JCPOMHNJOIE, float HMOCOKIPLGG, Action<float> LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO, bool PEBIHMGODLB = true, [Optional] NCDAGLAIKFO NOKFECGCJOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x77460B0", Offset = "0x77454B0", VA = "0x1877460B0")]
	private static IEnumerator<BGFGBHFIDBJ> BEENBLNMGEE(HGIHGICNEFC MOMPKBCFJII, float HMOCOKIPLGG, BEGIGAMJKID KOHLIHJCJJO, Action<float> LLIBDNOHPIL, bool PEBIHMGODLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7746330", Offset = "0x7745730", VA = "0x187746330")]
	private static IEnumerator<BGFGBHFIDBJ> HPAHGMHPMIF(HGIHGICNEFC MOMPKBCFJII, float HMOCOKIPLGG, BEGIGAMJKID KOHLIHJCJJO, Action<float> LLIBDNOHPIL, bool PEBIHMGODLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7746530", Offset = "0x7745930", VA = "0x187746530")]
	[IteratorStateMachine(typeof(MNLKCFCCJOI))]
	private static IEnumerator<BGFGBHFIDBJ> NHDECPGGJGM(MPKMPPEAJCL KFIKBMEECKD, float HMOCOKIPLGG, BEGIGAMJKID KOHLIHJCJJO, Action<float> LLIBDNOHPIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class LIDCCGODCMN
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class LPLEAGNHFKN : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public BEGIGAMJKID queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public LPLEAGNHFKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7759A30", Offset = "0x7758E30", VA = "0x187759A30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7759AF0", Offset = "0x7758EF0", VA = "0x187759AF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x77596E0", Offset = "0x7758AE0", VA = "0x1877596E0")]
	[IteratorStateMachine(typeof(LPLEAGNHFKN))]
	private static IEnumerator<BGFGBHFIDBJ> HIGOGMPGKAL(BEGIGAMJKID IKCILLPFALO, Func<bool> HKAOLGPCJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7759770", Offset = "0x7758B70", VA = "0x187759770")]
	public static GJOIDBBGEPO PJNOBJALLHA(this MonoBehaviour DLBIKABGMBD, Func<bool> HKAOLGPCJKN, BEGIGAMJKID IKCILLPFALO = BEGIGAMJKID.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class CLBJGEAFNBA
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class ONNAKKMFIPD : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public BEGIGAMJKID queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public ONNAKKMFIPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x775F230", Offset = "0x775E630", VA = "0x18775F230", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x775F2A0", Offset = "0x775E6A0", VA = "0x18775F2A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class CKHCFLLGFJE : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public BEGIGAMJKID queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private BGFGBHFIDBJ <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public CKHCFLLGFJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x77497B0", Offset = "0x7748BB0", VA = "0x1877497B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7749840", Offset = "0x7748C40", VA = "0x187749840", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7749EA0", Offset = "0x77492A0", VA = "0x187749EA0")]
	[IteratorStateMachine(typeof(ONNAKKMFIPD))]
	private static IEnumerator<BGFGBHFIDBJ> MJGKCFBOEJK(float HEJMBOHMFMN, BEGIGAMJKID KOHLIHJCJJO, Action HGNEAAOPDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7749FE0", Offset = "0x77493E0", VA = "0x187749FE0")]
	[IteratorStateMachine(typeof(CKHCFLLGFJE))]
	private static IEnumerator<BGFGBHFIDBJ> NILOONLHLAF(float HEJMBOHMFMN, BEGIGAMJKID KOHLIHJCJJO, Action HGNEAAOPDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7749C30", Offset = "0x7749030", VA = "0x187749C30")]
	public static IDisposable MHAOCBHENLL(this MonoBehaviour DLBIKABGMBD, float HEJMBOHMFMN, Action HGNEAAOPDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x77499D0", Offset = "0x7748DD0", VA = "0x1877499D0")]
	public static GJOIDBBGEPO HBPLIACCPOH(this MonoBehaviour DLBIKABGMBD, float HEJMBOHMFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7749D10", Offset = "0x7749110", VA = "0x187749D10")]
	public static GJOIDBBGEPO MHAOCBHENLL(this MonoBehaviour DLBIKABGMBD, float HEJMBOHMFMN, BEGIGAMJKID KOHLIHJCJJO, Action HGNEAAOPDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7749B90", Offset = "0x7748F90", VA = "0x187749B90")]
	public static GJOIDBBGEPO LAEPIGEGAKC(this MonoBehaviour DLBIKABGMBD, Action HGNEAAOPDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x774A080", Offset = "0x7749480", VA = "0x18774A080")]
	public static GJOIDBBGEPO OMDOCJNFNCB(this MonoBehaviour DLBIKABGMBD, Action HGNEAAOPDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7749930", Offset = "0x7748D30", VA = "0x187749930")]
	public static GJOIDBBGEPO GEAPGCAGCOH(this MonoBehaviour DLBIKABGMBD, Action HGNEAAOPDDM, [Optional] NCDAGLAIKFO NOKFECGCJOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7749890", Offset = "0x7748C90", VA = "0x187749890")]
	public static GJOIDBBGEPO FNGLNCCNEBO(this MonoBehaviour DLBIKABGMBD, Action HGNEAAOPDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x774A1C0", Offset = "0x77495C0", VA = "0x18774A1C0")]
	public static GJOIDBBGEPO PDHPCOLACDE(this MonoBehaviour DLBIKABGMBD, Action HGNEAAOPDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7749AF0", Offset = "0x7748EF0", VA = "0x187749AF0")]
	private static GJOIDBBGEPO JMAEJJDAKGJ(MonoBehaviour DLBIKABGMBD, BEGIGAMJKID IKCILLPFALO, Action HGNEAAOPDDM, [Optional] NCDAGLAIKFO NOKFECGCJOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7749A60", Offset = "0x7748E60", VA = "0x187749A60")]
	public static GJOIDBBGEPO JBJMIIOIDKI(this MonoBehaviour DLBIKABGMBD, float AFDGHEHCEBG, Action HGNEAAOPDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x774A120", Offset = "0x7749520", VA = "0x18774A120")]
	public static GJOIDBBGEPO OPIDMGDGCDK(this MonoBehaviour DLBIKABGMBD, float AFDGHEHCEBG, Action HGNEAAOPDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7749E00", Offset = "0x7749200", VA = "0x187749E00")]
	public static GJOIDBBGEPO MJCINDIBDAC(this MonoBehaviour DLBIKABGMBD, float AFDGHEHCEBG, Action HGNEAAOPDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7749F40", Offset = "0x7749340", VA = "0x187749F40")]
	public static GJOIDBBGEPO MOCJBJPMIHA(this MonoBehaviour DLBIKABGMBD, float AFDGHEHCEBG, Action HGNEAAOPDDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class OIIMCHMAEIG : BOOODDMAAJJ, IEnumerable<BOOODDMAAJJ>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly List<BOOODDMAAJJ> PLNCIANBBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool HBEEPMPNGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Action BELGLGDNKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool LLPGLMDLJNB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool LBKOLCEHNBN
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x775EE10", Offset = "0x775E210", VA = "0x18775EE10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LNBJCNHLKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x775EA60", Offset = "0x775DE60", VA = "0x18775EA60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x775EF40", Offset = "0x775E340", VA = "0x18775EF40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x775F190", Offset = "0x775E590", VA = "0x18775F190")]
	public OIIMCHMAEIG([Optional] Action BELGLGDNKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x775F060", Offset = "0x775E460", VA = "0x18775F060")]
	public void PJLPMKJIOFF(BOOODDMAAJJ EFEBOKCIEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x775E910", Offset = "0x775DD10", VA = "0x18775E910")]
	private void CAHIMNPDFAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x775EE00", Offset = "0x775E200", VA = "0x18775EE00", Slot = "7")]
	public bool CHKMNPKJOPB(bool DPEDJCGKFCE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x775EB00", Offset = "0x775DF00", VA = "0x18775EB00", Slot = "8")]
	public bool CHKMNPKJOPB(Action MDOOJHKFGMP, bool DPEDJCGKFCE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x775EFE0", Offset = "0x775E3E0", VA = "0x18775EFE0", Slot = "9")]
	public IEnumerator<BOOODDMAAJJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x775EFE0", Offset = "0x775E3E0", VA = "0x18775EFE0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class JNFCCJHCFHJ : PDBGLIDJFDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class GIDBGCDEPPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public JNFCCJHCFHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public GIDBGCDEPPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7752520", Offset = "0x7751920", VA = "0x187752520")]
		internal void HGIGCFPLCLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class OIGPLCJMKBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public JNFCCJHCFHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public OIGPLCJMKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7752520", Offset = "0x7751920", VA = "0x187752520")]
		internal void KCFHDKBFLCF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly float OMPHBNKKGFP;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7757F50", Offset = "0x7757350", VA = "0x187757F50")]
	public JNFCCJHCFHJ(Behaviour JCPOMHNJOIE, float OMPHBNKKGFP, [Optional] Action BELGLGDNKNC, [Optional] NCDAGLAIKFO NOKFECGCJOI, [Optional] HGIHGICNEFC MOMPKBCFJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7758090", Offset = "0x7757490", VA = "0x187758090", Slot = "9")]
	protected override bool BIMFIIPJJOP(Action MDOOJHKFGMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x77581A0", Offset = "0x77575A0", VA = "0x1877581A0", Slot = "10")]
	protected override bool IDLDHCACCDL(Action MDOOJHKFGMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface BOOODDMAAJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool LBKOLCEHNBN
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LNBJCNHLKNK;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CHKMNPKJOPB(bool DPEDJCGKFCE = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CHKMNPKJOPB(Action MDOOJHKFGMP, bool DPEDJCGKFCE = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class PDBGLIDJFDJ : BOOODDMAAJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class EDKDHOHEBOC : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public PDBGLIDJFDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public EDKDHOHEBOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x774E390", Offset = "0x774D790", VA = "0x18774E390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x774E460", Offset = "0x774D860", VA = "0x18774E460", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Behaviour JCPOMHNJOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action BELGLGDNKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private LMEMMAHKEDK CPIJBOHJPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly NCDAGLAIKFO NOKFECGCJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	protected readonly HGIHGICNEFC MOMPKBCFJII;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LBKOLCEHNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x11CC900", Offset = "0x11CBD00", VA = "0x1811CC900", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action LNBJCNHLKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x77600E0", Offset = "0x775F4E0", VA = "0x1877600E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7760350", Offset = "0x775F750", VA = "0x187760350", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x77606A0", Offset = "0x775FAA0", VA = "0x1877606A0")]
	protected PDBGLIDJFDJ(Behaviour JCPOMHNJOIE, [Optional] Action BELGLGDNKNC, [Optional] NCDAGLAIKFO NOKFECGCJOI, [Optional] HGIHGICNEFC MOMPKBCFJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x77601E0", Offset = "0x775F5E0", VA = "0x1877601E0", Slot = "7")]
	public bool CHKMNPKJOPB(bool DPEDJCGKFCE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7760180", Offset = "0x775F580", VA = "0x187760180", Slot = "8")]
	public bool CHKMNPKJOPB(Action MDOOJHKFGMP, bool DPEDJCGKFCE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool BIMFIIPJJOP(Action MDOOJHKFGMP);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool IDLDHCACCDL(Action MDOOJHKFGMP);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7760680", Offset = "0x775FA80", VA = "0x187760680")]
	protected void PJOFPBMHHLE(Action MDOOJHKFGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7760430", Offset = "0x775F830", VA = "0x187760430")]
	protected AOFGCNMIPIP JBBIINHINMN(float HBCBOLHLONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7760240", Offset = "0x775F640", VA = "0x187760240")]
	private void CJCDFGDJDMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x77602C0", Offset = "0x775F6C0", VA = "0x1877602C0")]
	[IteratorStateMachine(typeof(EDKDHOHEBOC))]
	private IEnumerator<BGFGBHFIDBJ> DFLDNJEOIDJ(float HBCBOLHLONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x77603F0", Offset = "0x775F7F0", VA = "0x1877603F0")]
	[CompilerGenerated]
	private void EEHBAAOPNEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class KADFIKKCGMI : PDBGLIDJFDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float FIJOKLECCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int BEPPMLPCEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float GAKMCKEPECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float[] OPFCPEJGJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int PPMFPNIAJCF;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7758710", Offset = "0x7757B10", VA = "0x187758710")]
	public KADFIKKCGMI(Behaviour JCPOMHNJOIE, float LAOFNJIJBMC, int BEPPMLPCEAL, [Optional] Action BELGLGDNKNC, float GAKMCKEPECI = 0f, [Optional] NCDAGLAIKFO NOKFECGCJOI, [Optional] HGIHGICNEFC MOMPKBCFJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "9")]
	protected override bool BIMFIIPJJOP(Action MDOOJHKFGMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7758510", Offset = "0x7757910", VA = "0x187758510", Slot = "10")]
	protected override bool IDLDHCACCDL(Action MDOOJHKFGMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7758490", Offset = "0x7757890", VA = "0x187758490")]
	private void FLFLLBBBDJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class JKECIDJNBDN : PDBGLIDJFDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float OMPHBNKKGFP;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7757F50", Offset = "0x7757350", VA = "0x187757F50")]
	public JKECIDJNBDN(Behaviour JCPOMHNJOIE, float OMPHBNKKGFP, [Optional] Action BELGLGDNKNC, [Optional] NCDAGLAIKFO NOKFECGCJOI, [Optional] HGIHGICNEFC MOMPKBCFJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "9")]
	protected override bool BIMFIIPJJOP(Action MDOOJHKFGMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7757F10", Offset = "0x7757310", VA = "0x187757F10", Slot = "10")]
	protected override bool IDLDHCACCDL(Action MDOOJHKFGMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class GKIOBBIHBFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class MOEOOOILNCH : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public MOEOOOILNCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7754C30", Offset = "0x7754030", VA = "0x187754C30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x775A0A0", Offset = "0x77594A0", VA = "0x18775A0A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private GJOIDBBGEPO ELENAKNLJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private PALDPPFGJJL JCPOMHNJOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Action<float> ADEONHMECJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private BEGIGAMJKID IKCILLPFALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private float BPKOCPCMCNL;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7752B70", Offset = "0x7751F70", VA = "0x187752B70")]
	public GKIOBBIHBFC(PALDPPFGJJL JCPOMHNJOIE, float HMOCOKIPLGG, Action<float> LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7752980", Offset = "0x7751D80", VA = "0x187752980")]
	private void HOGNMDLLIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7752850", Offset = "0x7751C50", VA = "0x187752850")]
	private void EFKICNCDMEI(string GJAHCEMFFMA, Action EEMGNHGKNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7752AF0", Offset = "0x7751EF0", VA = "0x187752AF0")]
	[IteratorStateMachine(typeof(MOEOOOILNCH))]
	private IEnumerator<BGFGBHFIDBJ> NNFJHIIIBPB(Action EEMGNHGKNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x77527F0", Offset = "0x7751BF0", VA = "0x1877527F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7752670", Offset = "0x7751A70", VA = "0x187752670")]
	[CompilerGenerated]
	private void ADKOLNJEOFH(string PBLCLNMOIGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class EPELLOAJLGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JBLOMAIHNIP : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public JBLOMAIHNIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7754C30", Offset = "0x7754030", VA = "0x187754C30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7754CA0", Offset = "0x77540A0", VA = "0x187754CA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private GJOIDBBGEPO ELENAKNLJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private MonoBehaviour DLBIKABGMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action LLIBDNOHPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Action<float> ADEONHMECJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private BEGIGAMJKID IKCILLPFALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float BPKOCPCMCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private bool PEBIHMGODLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly NCDAGLAIKFO NOKFECGCJOI;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x774FD20", Offset = "0x774F120", VA = "0x18774FD20")]
	public EPELLOAJLGC(MonoBehaviour DLBIKABGMBD, Action LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO, [Optional] NCDAGLAIKFO NOKFECGCJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x774FB50", Offset = "0x774EF50", VA = "0x18774FB50")]
	public EPELLOAJLGC(MonoBehaviour DLBIKABGMBD, Action<float> LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO, [Optional] NCDAGLAIKFO NOKFECGCJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x774FEB0", Offset = "0x774F2B0", VA = "0x18774FEB0")]
	public EPELLOAJLGC(MonoBehaviour DLBIKABGMBD, float HMOCOKIPLGG, Action<float> LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO, bool PEBIHMGODLB = true, [Optional] NCDAGLAIKFO NOKFECGCJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x9178B0", Offset = "0x916CB0", VA = "0x1809178B0")]
	private EPELLOAJLGC(NCDAGLAIKFO NOKFECGCJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x774F230", Offset = "0x774E630", VA = "0x18774F230")]
	internal static EPELLOAJLGC ELKMIMBHGJE(MonoBehaviour DLBIKABGMBD, float HMOCOKIPLGG, Action<float> LLIBDNOHPIL, BEGIGAMJKID IKCILLPFALO, bool PEBIHMGODLB = true, [Optional] NCDAGLAIKFO NOKFECGCJOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x774F880", Offset = "0x774EC80", VA = "0x18774F880")]
	private void JHHLAMJICMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x774EF20", Offset = "0x774E320", VA = "0x18774EF20")]
	private void AMJIONJODPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x774F4F0", Offset = "0x774E8F0", VA = "0x18774F4F0")]
	private void HOGNMDLLIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x774F660", Offset = "0x774EA60", VA = "0x18774F660")]
	private void IPIMHGBCIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x774F100", Offset = "0x774E500", VA = "0x18774F100")]
	private void EFKICNCDMEI(string GJAHCEMFFMA, Action EEMGNHGKNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x774FAD0", Offset = "0x774EED0", VA = "0x18774FAD0")]
	[IteratorStateMachine(typeof(JBLOMAIHNIP))]
	private IEnumerator<BGFGBHFIDBJ> NNFJHIIIBPB(Action EEMGNHGKNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x774F0A0", Offset = "0x774E4A0", VA = "0x18774F0A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x774F9B0", Offset = "0x774EDB0", VA = "0x18774F9B0")]
	[CompilerGenerated]
	private void LAEIKBOPNKK(string PBLCLNMOIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x774FA40", Offset = "0x774EE40", VA = "0x18774FA40")]
	[CompilerGenerated]
	private void MKAFOEBLADF(string PBLCLNMOIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x774F460", Offset = "0x774E860", VA = "0x18774F460")]
	[CompilerGenerated]
	private void FLCFOGPMEIK(string PBLCLNMOIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x774F7F0", Offset = "0x774EBF0", VA = "0x18774F7F0")]
	[CompilerGenerated]
	private void JBJLIMGFNCG(string PBLCLNMOIGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum GMJNJJNPDDI : byte
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
internal sealed class NDJGPLOANNA : HGIHGICNEFC
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float HINPJDOKCPL
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x775CB50", Offset = "0x775BF50", VA = "0x18775CB50", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float KIEOLBEMBPL
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x775CB60", Offset = "0x775BF60", VA = "0x18775CB60", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public double GANICAJBNBD
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x775CB30", Offset = "0x775BF30", VA = "0x18775CB30", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x775CAC0", Offset = "0x775BEC0", VA = "0x18775CAC0")]
	[FHFMOACGLML.PCGBCKINAAE]
	internal static void EJGLCCJGHFF(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	[UnityEngine.Scripting.Preserve]
	internal NDJGPLOANNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface IHPHIFGHFKL
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAPENCJCICO(string ADANIHOIEKJ);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIOHOMCOJIK();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface OHAINNHNFFP
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string BKJCNMKILGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool CPCHKPINGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool PDFHDIIEBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class GDANPPMBJDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public NDAEHFJINFO PMLOIOEFBCN;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int LGPOLAJNCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8A91A0", Offset = "0x8A85A0", VA = "0x1808A91A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8B5800", Offset = "0x8B4C00", VA = "0x1808B5800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7751E20", Offset = "0x7751220", VA = "0x187751E20")]
	public static BGFGBHFIDBJ ELNJHDBFMGB(IEnumerator<BGFGBHFIDBJ> JOEMJLCINEL, OHKCEIGBCGC COBENJPHIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7751D60", Offset = "0x7751160", VA = "0x187751D60")]
	public BGFGBHFIDBJ ELNJHDBFMGB(OHKCEIGBCGC[] LDDNNHHMCCP, IEnumerator<BGFGBHFIDBJ>[] CMIOOOCOBGP, BGFGBHFIDBJ[] PKFFJPKHDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7751F80", Offset = "0x7751380", VA = "0x187751F80")]
	public void FAJELKNAEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7751FB0", Offset = "0x77513B0", VA = "0x187751FB0")]
	public void IPJAFDCIAHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x77520F0", Offset = "0x77514F0", VA = "0x1877520F0")]
	public void NOFEBIPIMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7751F80", Offset = "0x7751380", VA = "0x187751F80")]
	public void KCKAFHOGONG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public GDANPPMBJDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class NDAEHFJINFO
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct PFFGBHDDBCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public GDANPPMBJDP FPBEJBEIKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public PALDPPFGJJL PKLKHEINCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public OHKCEIGBCGC DHGLJHJPHNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public IEnumerator<BGFGBHFIDBJ> AGJEOPOBFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public BGFGBHFIDBJ DACIJHNJIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public GMJNJJNPDDI KKBGPIIKCKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct BBGBOHBEPJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public BEGIGAMJKID BNLNPJCPNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public List<PFFGBHDDBCD> GBADPEOKFNE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class NFDBFAIAKDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public OHKCEIGBCGC promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public NDAEHFJINFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public PALDPPFGJJL context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public GDANPPMBJDP routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public GMJNJJNPDDI coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public BGFGBHFIDBJ currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public IEnumerator<BGFGBHFIDBJ> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public NFDBFAIAKDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x775CB70", Offset = "0x775BF70", VA = "0x18775CB70")]
		internal void GELFCHHOAMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class IPHBNHLGDDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public GDANPPMBJDP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public NDAEHFJINFO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public IPHBNHLGDDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7754920", Offset = "0x7753D20", VA = "0x187754920")]
		internal void OLKOLNJBGJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class GHOCDOODAOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public GDANPPMBJDP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public NDAEHFJINFO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public GHOCDOODAOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x77524E0", Offset = "0x77518E0", VA = "0x1877524E0")]
		internal void AJIPDPIBICL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class PMNOFFNHALO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public GDANPPMBJDP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public NDAEHFJINFO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PMNOFFNHALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7760AE0", Offset = "0x775FEE0", VA = "0x187760AE0")]
		internal void MDJHFNOKHLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private const GMJNJJNPDDI DPANDIAGGOP = GMJNJJNPDDI.Cancelled | GMJNJJNPDDI.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly BEGIGAMJKID IKCILLPFALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool[] EJEDMIKBIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<GMJNJJNPDDI> OMAPAAHLPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<float> DPBFOFFENKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> NNGNHDOJOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> FOAANIFNGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> ENDEGLIBOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> DIAHJHEBBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> GJBHJLMIEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private GDANPPMBJDP[] NMHBCCFAFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private OHKCEIGBCGC[] LDDNNHHMCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private PALDPPFGJJL[] BOAMOFIDKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IEnumerator<BGFGBHFIDBJ>[] JDLMOPHAMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private BGFGBHFIDBJ[] DGFIPIDLLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int JCAIINMNHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int MLLKNBDHHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly int NBBKLECJEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float BBAIHAKMKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private EPPKANFMOGJ MPKKGHLJEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private JobHandle GLIHACIFGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<GDANPPMBJDP> HAKEIDCAJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool FPGGKENDEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> KFLKLCAEGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<Action> KDAOADLPGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool PHOLBOHJECE;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public BBGBOHBEPJJ[] CPIFBFECLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x900E60", Offset = "0x900260", VA = "0x180900E60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x775C430", Offset = "0x775B830", VA = "0x18775C430")]
	private static int PIPFNLPBAAF(BEGIGAMJKID IKCILLPFALO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x775C460", Offset = "0x775B860", VA = "0x18775C460")]
	public NDAEHFJINFO(BEGIGAMJKID IKCILLPFALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x775A0F0", Offset = "0x77594F0", VA = "0x18775A0F0")]
	private void AJNHFEJHINO(int PFKAOBJBKGN, int LPEHPDLLCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x775AE90", Offset = "0x775A290", VA = "0x18775AE90")]
	public void ICJELCJEEEK(PALDPPFGJJL JCPOMHNJOIE, BGFGBHFIDBJ EDABOCGHLDJ, IEnumerator<BGFGBHFIDBJ> JOEMJLCINEL, OHKCEIGBCGC COBENJPHIFN, [Optional] GDANPPMBJDP CKDNFCKODAK, GMJNJJNPDDI PMKEDJLHPKA = GMJNJJNPDDI.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x775C1F0", Offset = "0x775B5F0", VA = "0x18775C1F0")]
	public void PCBOFLACPOO(IEnumerable<PFFGBHDDBCD> PEJCPHKGIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x775A2D0", Offset = "0x77596D0", VA = "0x18775A2D0")]
	private PFFGBHDDBCD BDLCPDJHALL(int DPBBKIJKMMD)
	{
		return default(PFFGBHDDBCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x775B270", Offset = "0x775A670", VA = "0x18775B270")]
	private void JEMHOCJDMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4480", Offset = "0x2FC3880", VA = "0x182FC4480")]
	private static void NGCJFEGCCPE<T>(int DPBBKIJKMMD, T[] KJPEBHJFMFC, int MFKKELONDCC, [Optional] T FNCAFHHENEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2FC44D0", Offset = "0x2FC38D0", VA = "0x182FC44D0")]
	private static void NGCJFEGCCPE<T>(int DPBBKIJKMMD, NativeArray<T> KJPEBHJFMFC, int MFKKELONDCC, [Optional] T FNCAFHHENEK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x775AAF0", Offset = "0x7759EF0", VA = "0x18775AAF0")]
	private void HDCLPEGIJEB(IEnumerable<PFFGBHDDBCD> PEJCPHKGIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x775AA20", Offset = "0x7759E20", VA = "0x18775AA20")]
	private void GLCEKIGPNFG(PFFGBHDDBCD KOMJLFNFMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x775B010", Offset = "0x775A410", VA = "0x18775B010")]
	private KCGPKABJEGL IILBLLHDEOB(int ADCFBAPPFLF)
	{
		return default(KCGPKABJEGL);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x775A7A0", Offset = "0x7759BA0", VA = "0x18775A7A0")]
	public void BJAGNFCIJKC(float EJNPHOJBHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x775B940", Offset = "0x775AD40", VA = "0x18775B940")]
	private void LMGCKLPMDOD(Action NOPDIJFELMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x775A9A0", Offset = "0x7759DA0", VA = "0x18775A9A0")]
	private void EIDBBEGIMOH(Action NOPDIJFELMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x775B9C0", Offset = "0x775ADC0", VA = "0x18775B9C0")]
	public void ONIHADDCGKB(float EJNPHOJBHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x775B840", Offset = "0x775AC40", VA = "0x18775B840")]
	public void KMANLEPJEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x775B710", Offset = "0x775AB10", VA = "0x18775B710")]
	public void KCKAFHOGONG(GDANPPMBJDP KFIKBMEECKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x775B5E0", Offset = "0x775A9E0", VA = "0x18775B5E0")]
	public void JJCBINHBPPE(GDANPPMBJDP KFIKBMEECKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x775C0C0", Offset = "0x775B4C0", VA = "0x18775C0C0")]
	public void OOGNEAEFBEB(GDANPPMBJDP KFIKBMEECKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class DMJDCIENEEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly DMJDCIENEEJ NHLFLGLAPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly Action FEMGHJNBLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private bool LNIMNIKGCDA;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	public DMJDCIENEEJ(Action FEMGHJNBLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1490", Offset = "0x6EC0890", VA = "0x186EC1490", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface IEKMKMFDBCK<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T JKEIFELLNME
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable NODEEOCOGKB(UnityEngine.Object JCPOMHNJOIE, Action<T> DMKKFIDIOJE);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface LPDINLLKHFG<T> : IEKMKMFDBCK<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	new T JKEIFELLNME
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class JKAPPNEIOMP<T> : LPDINLLKHFG<T>, IEKMKMFDBCK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class AKFOFGJIDFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public JKAPPNEIOMP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public PCIAHMECFFE<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public AKFOFGJIDFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x402C860", Offset = "0x402BC60", VA = "0x18402C860")]
		internal void BLIBABKMBMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static GameObject BAOBMJDKJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly List<PCIAHMECFFE<UnityEngine.Object, Action<T>>> LDOMFIHIGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private T KIBEGAAJFCL;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public T JKEIFELLNME
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xB81E30", Offset = "0xB81230", VA = "0x180B81E30", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x44399B0", Offset = "0x4438DB0", VA = "0x1844399B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x4438E90", Offset = "0x4438290", VA = "0x184438E90")]
	private static bool BAAAKILEBPL(T NOPDIJFELMF, T PMGMHFIMGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4439B20", Offset = "0x4438F20", VA = "0x184439B20")]
	public JKAPPNEIOMP(T GDJCFKLNNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x44397F0", Offset = "0x4438BF0", VA = "0x1844397F0", Slot = "6")]
	public IDisposable NODEEOCOGKB(UnityEngine.Object JCPOMHNJOIE, Action<T> DMKKFIDIOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x44392E0", Offset = "0x44386E0", VA = "0x1844392E0")]
	private void HGKIJGGBLHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class JFELLLODLDC : LFIFBGNKKNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly NCDAGLAIKFO NOKFECGCJOI;

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7756AC0", Offset = "0x7755EC0", VA = "0x187756AC0")]
	[FHFMOACGLML.PCGBCKINAAE]
	internal static void EPNNMDOPHJL(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	[UnityEngine.Scripting.Preserve]
	internal JFELLLODLDC([ACGOIOBGIEE(null)] NCDAGLAIKFO NOKFECGCJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7756B30", Offset = "0x7755F30", VA = "0x187756B30", Slot = "4")]
	public IDisposable IOEBJKLGCML(float HMOCOKIPLGG, Action<float> BNNBDLHMCLC, bool PEBIHMGODLB = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class IHGHAHPCPLP : FDINAABKNGC, NCDAGLAIKFO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private NDAEHFJINFO[] FJBAINDPKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private IHPHIFGHFKL KNKFBFBDLOD;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7753BF0", Offset = "0x7752FF0", VA = "0x187753BF0")]
	[FHFMOACGLML.PCGBCKINAAE]
	internal static void EJGLCCJGHFF(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7754070", Offset = "0x7753470", VA = "0x187754070")]
	[UnityEngine.Scripting.Preserve]
	public IHGHAHPCPLP([ACGOIOBGIEE(null)] IMNEDACDNEO JFIFLJBDNAL, [ACGOIOBGIEE(null)] HGIHGICNEFC MOMPKBCFJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7753410", Offset = "0x7752810", VA = "0x187753410", Slot = "18")]
	public override GJOIDBBGEPO ACHFIOJGNNE(PALDPPFGJJL JCPOMHNJOIE, IEnumerator<BGFGBHFIDBJ> BOBLIFBDGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7753540", Offset = "0x7752940", VA = "0x187753540", Slot = "19")]
	public override void AEAEDDMNDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7753D20", Offset = "0x7753120", VA = "0x187753D20", Slot = "21")]
	public override void HIBJEFFEMAK(BEGIGAMJKID IKCILLPFALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7753A20", Offset = "0x7752E20", VA = "0x187753A20", Slot = "20")]
	protected override void BNOGHBKOPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x77539F0", Offset = "0x7752DF0", VA = "0x1877539F0")]
	private NDAEHFJINFO BFLBGDPJCLP(BEGIGAMJKID LGJDMOCCBDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x77537D0", Offset = "0x7752BD0", VA = "0x1877537D0", Slot = "22")]
	internal override LAOEDDHPBAE BBEFMEPMBKA(IEnumerator<BGFGBHFIDBJ> BOBLIFBDGHO, Behaviour JCPOMHNJOIE, OHKCEIGBCGC COBENJPHIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7753C60", Offset = "0x7753060", VA = "0x187753C60", Slot = "23")]
	internal override BBJPHJEHPIK FCPFDCFNFGL(BEGIGAMJKID KOHLIHJCJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7753F50", Offset = "0x7753350", VA = "0x187753F50")]
	private void PBAEPBALLFD(NDAEHFJINFO AHJNJHPDNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7753B90", Offset = "0x7752F90", VA = "0x187753B90", Slot = "24")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct EPPKANFMOGJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public float ICAAHINOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	public int JHDCPNPFLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> FIJADABDIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> CKHIEKGKIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NativeArray<int> NBIHONPIEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<GMJNJJNPDDI> BFDFAOFNIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	public NativeArray<float> BNBCOIJFKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> ENDEGLIBOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[WriteOnly]
	public NativeArray<int> NNGNHDOJOJN;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x77507A0", Offset = "0x774FBA0", VA = "0x1877507A0")]
	public static EPPKANFMOGJ LIDOGEGODKP(int OLABCOIMPNI, float EJNPHOJBHAC, NativeArray<GMJNJJNPDDI> MJIIAGDIGMK, NativeArray<float> DICFAHIBGLK, NativeArray<int> LGCABCJGJGK, NativeArray<int> JFLEDFMBOOI, NativeArray<int> DFAFKKPDIBB, NativeArray<int> CKHIEKGKIHB, NativeArray<int> NBIHONPIEGL)
	{
		return default(EPPKANFMOGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7750450", Offset = "0x774F850", VA = "0x187750450", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x77508D0", Offset = "0x774FCD0", VA = "0x1877508D0")]
	private bool PANDIGLJCKM(int AEAHMAMPNLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7750770", Offset = "0x774FB70", VA = "0x187750770")]
	private void LDOEPHCGGFK(NativeArray<int> DJCEIGBFBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x77503B0", Offset = "0x774F7B0", VA = "0x1877503B0")]
	private int BLOEGGFJFPF(int NAMJHMIGEPD, int LAMBDENNAML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7750800", Offset = "0x774FC00", VA = "0x187750800")]
	private void OCNHANBAAAL(NativeArray<int> DJCEIGBFBPG, int GHKJJJMKIJP, int CMEHKBHKHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7750530", Offset = "0x774F930", VA = "0x187750530")]
	private void IBNCDCIGNLP(NativeArray<int> DJCEIGBFBPG, int KOANBJBNBPB, int DMKDCFBHMFI, int BAILJNMIICN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class FDINAABKNGC : NCDAGLAIKFO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly IMNEDACDNEO JFIFLJBDNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected readonly HGIHGICNEFC MOMPKBCFJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private BBJPHJEHPIK[] BFNLELFKPOJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static NCDAGLAIKFO FKMJLLKHOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7751100", Offset = "0x7750500", VA = "0x187751100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static bool NMBIACJCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public BEGIGAMJKID BEHOEDBAFCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8A91A0", Offset = "0x8A85A0", VA = "0x1808A91A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BEGIGAMJKID);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B5800", Offset = "0x8B4C00", VA = "0x1808B5800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public HGIHGICNEFC ANIGKJNMLNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BGFGBHFIDBJ HKJOIOJPAPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public BGFGBHFIDBJ MCFIAOKKHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D20", Offset = "0x8A9120", VA = "0x1808A9D20", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public BGFGBHFIDBJ IPMLNDOLGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB10", Offset = "0x8AEF10", VA = "0x1808AFB10", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x77512B0", Offset = "0x77506B0", VA = "0x1877512B0")]
	public static GJOIDBBGEPO ILOLNHMIBOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7751870", Offset = "0x7750C70", VA = "0x187751870")]
	[UnityEngine.Scripting.Preserve]
	protected FDINAABKNGC([ACGOIOBGIEE(null)] IMNEDACDNEO JFIFLJBDNAL, [ACGOIOBGIEE(null)] HGIHGICNEFC MOMPKBCFJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7750EF0", Offset = "0x77502F0", VA = "0x187750EF0", Slot = "6")]
	public GJOIDBBGEPO EHNFAJDFHCN(IEnumerator<BGFGBHFIDBJ> BOBLIFBDGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7750F00", Offset = "0x7750300", VA = "0x187750F00", Slot = "7")]
	public GJOIDBBGEPO EHNFAJDFHCN(Behaviour JCPOMHNJOIE, IEnumerator<BGFGBHFIDBJ> BOBLIFBDGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract GJOIDBBGEPO ACHFIOJGNNE(PALDPPFGJJL JCPOMHNJOIE, IEnumerator<BGFGBHFIDBJ> BOBLIFBDGHO);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7750930", Offset = "0x774FD30", VA = "0x187750930", Slot = "19")]
	public virtual void AEAEDDMNDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7751440", Offset = "0x7750840", VA = "0x187751440", Slot = "9")]
	public void MMEJKHDAKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7750B10", Offset = "0x774FF10", VA = "0x187750B10", Slot = "20")]
	protected virtual void BNOGHBKOPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x77513C0", Offset = "0x77507C0", VA = "0x1877513C0")]
	private void KMJAMDBGBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7751290", Offset = "0x7750690", VA = "0x187751290")]
	private void IIFKEBMIOLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x77513A0", Offset = "0x77507A0", VA = "0x1877513A0")]
	private void KAHPMMMCNAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7750AD0", Offset = "0x774FED0", VA = "0x187750AD0")]
	private void AHGKCABLPAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7750AF0", Offset = "0x774FEF0", VA = "0x187750AF0")]
	private void BNJFKMKIJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7751850", Offset = "0x7750C50", VA = "0x187751850")]
	private void ODLGJICGMAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7750910", Offset = "0x774FD10", VA = "0x187750910")]
	private void ABLGNNHPOKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7751200", Offset = "0x7750600", VA = "0x187751200", Slot = "21")]
	public virtual void HIBJEFFEMAK(BEGIGAMJKID IKCILLPFALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7751680", Offset = "0x7750A80", VA = "0x187751680")]
	private void NDGLNCPDGFP(BBJPHJEHPIK AHJNJHPDNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x212CD50", Offset = "0x212C150", VA = "0x18212CD50")]
	private BBJPHJEHPIK GIPOGCJKLFI(BEGIGAMJKID LGJDMOCCBDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract LAOEDDHPBAE BBEFMEPMBKA(IEnumerator<BGFGBHFIDBJ> BOBLIFBDGHO, Behaviour DLBIKABGMBD, OHKCEIGBCGC HHOBEJAOALC);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract BBJPHJEHPIK FCPFDCFNFGL(BEGIGAMJKID IKCILLPFALO);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7750B30", Offset = "0x774FF30", VA = "0x187750B30", Slot = "24")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7751340", Offset = "0x7750740", VA = "0x187751340", Slot = "14")]
	public BGFGBHFIDBJ JFPJANFHOGB(BEGIGAMJKID KOHLIHJCJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7751170", Offset = "0x7750570", VA = "0x187751170", Slot = "15")]
	public BGFGBHFIDBJ HCCKILJBGCP(float HEJMBOHMFMN, BEGIGAMJKID KOHLIHJCJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x77513E0", Offset = "0x77507E0", VA = "0x1877513E0", Slot = "16")]
	public BGFGBHFIDBJ LGIMCGGMEHG(Func<bool> HKAOLGPCJKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class LAOEDDHPBAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly OHKCEIGBCGC COBENJPHIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly OHAINNHNFFP JCPOMHNJOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool LONKGIBFHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private string ADANIHOIEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private StackTrace FOILPLMNAFF;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<BGFGBHFIDBJ> AGJEOPOBFKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F20", Offset = "0x8A9320", VA = "0x1808A9F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public BGFGBHFIDBJ DACIJHNJIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F40", Offset = "0x8A9340", VA = "0x1808A9F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool CGLPOJPOMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7759370", Offset = "0x7758770", VA = "0x187759370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool GLJOILEDLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x91A180", Offset = "0x919580", VA = "0x18091A180")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x91F860", Offset = "0x91EC60", VA = "0x18091F860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string BKJCNMKILGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7758E30", Offset = "0x7758230", VA = "0x187758E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float NNKENCEHKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xB81DB0", Offset = "0xB811B0", VA = "0x180B81DB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6348100", Offset = "0x6347500", VA = "0x186348100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7759520", Offset = "0x7758920", VA = "0x187759520")]
	public LAOEDDHPBAE(IEnumerator<BGFGBHFIDBJ> JOEMJLCINEL, OHAINNHNFFP JCPOMHNJOIE, OHKCEIGBCGC COBENJPHIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7758FE0", Offset = "0x77583E0", VA = "0x187758FE0")]
	public BGFGBHFIDBJ ELNJHDBFMGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7759300", Offset = "0x7758700", VA = "0x187759300")]
	public bool GOAGFIDGLFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x77593F0", Offset = "0x77587F0", VA = "0x1877593F0")]
	public void KCKAFHOGONG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7759440", Offset = "0x7758840", VA = "0x187759440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x91F2C0", Offset = "0x91E6C0", VA = "0x18091F2C0")]
	[CompilerGenerated]
	private void MOKGHEHDHLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class OHKCEIGBCGC : BEKPIOKEOJH, GJOIDBBGEPO, LMEMMAHKEDK, AOFGCNMIPIP, IEnumerator, BGFGBHFIDBJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private BEGIGAMJKID ADKCFJKNBIM;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private BEGIGAMJKID IAINPLAIKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x919AB0", Offset = "0x918EB0", VA = "0x180919AB0", Slot = "23")]
		get
		{
			return default(BEGIGAMJKID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public BEGIGAMJKID PMLOIOEFBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA8C4B0", Offset = "0xA8B8B0", VA = "0x180A8C4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float HHEOONHGHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9FF360", Offset = "0x9FE760", VA = "0x1809FF360", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool KHIHBDGBKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x775E890", Offset = "0x775DC90", VA = "0x18775E890", Slot = "24")]
	private bool CMMOGNKKCBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x775E8B0", Offset = "0x775DCB0", VA = "0x18775E8B0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x775E8C0", Offset = "0x775DCC0", VA = "0x18775E8C0")]
	public OHKCEIGBCGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum KCGPKABJEGL : byte
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
internal sealed class BBJPHJEHPIK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum APNCCPLFBFP
	{
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct FANIGFDCPIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public BEGIGAMJKID BNLNPJCPNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public APNCCPLFBFP GMFIOMACHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public List<LAOEDDHPBAE> ANPNOHHBCLK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly APNCCPLFBFP[] NIFCGEOKNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly BEGIGAMJKID IKCILLPFALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool JNCBGGFFDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly LAOEDDHPBAE[] JKPCDEJCLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly List<LAOEDDHPBAE> DJMLPLFIBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<int> LEFJDPGFIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<LAOEDDHPBAE> LBOAJEMNFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<int> GGCGIKDLEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly IHPHIFGHFKL MHKBGAPANMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private bool PHOLBOHJECE;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public FANIGFDCPIG[,] MKBKMEENJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB10", Offset = "0x8AEF10", VA = "0x1808AFB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7747F40", Offset = "0x7747340", VA = "0x187747F40")]
	public BBJPHJEHPIK(BEGIGAMJKID KOHLIHJCJJO, IHPHIFGHFKL MHKBGAPANMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x77470C0", Offset = "0x77464C0", VA = "0x1877470C0")]
	public void FLEPALPIAJL(LAOEDDHPBAE JOEMJLCINEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7747B10", Offset = "0x7746F10", VA = "0x187747B10")]
	public void NEOIPPJKDGM(IList<LAOEDDHPBAE> CMIOOOCOBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7747490", Offset = "0x7746890", VA = "0x187747490")]
	public void MLCCHJCLJFE(IList<LAOEDDHPBAE> CMIOOOCOBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7746BB0", Offset = "0x7745FB0", VA = "0x187746BB0")]
	private void DGFLDGJHNAK(LAOEDDHPBAE JOEMJLCINEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7747790", Offset = "0x7746B90", VA = "0x187747790")]
	private void MLIINEFCMJC(IList<LAOEDDHPBAE> CMIOOOCOBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7747310", Offset = "0x7746710", VA = "0x187747310")]
	private KCGPKABJEGL MDDHCBIPLNI(LAOEDDHPBAE JOEMJLCINEL)
	{
		return default(KCGPKABJEGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7746A40", Offset = "0x7745E40", VA = "0x187746A40")]
	public void BNOGHBKOPKE(float EJNPHOJBHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7747920", Offset = "0x7746D20", VA = "0x187747920")]
	public void MMEJKHDAKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7746DC0", Offset = "0x77461C0", VA = "0x187746DC0")]
	private void EMCIMNCICJP(List<LAOEDDHPBAE> CMIOOOCOBGP, Stack<int> GDMEFHPANHK, bool DCFCGIPFECK, float FHCMNDNGNPE = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7746CA0", Offset = "0x77460A0", VA = "0x187746CA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x77471D0", Offset = "0x77465D0", VA = "0x1877471D0")]
	private void FMMOMPKGHPK(List<LAOEDDHPBAE> CMIOOOCOBGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class GPJFDLKLPME : IHPHIFGHFKL
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "4")]
	public void AAPENCJCICO(string ADANIHOIEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
	public void GIOHOMCOJIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public GPJFDLKLPME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class AAAODCNJBDN : OHAINNHNFFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly Behaviour DLBIKABGMBD;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string BKJCNMKILGO
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7745E00", Offset = "0x7745200", VA = "0x187745E00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool CPCHKPINGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x7745EA0", Offset = "0x77452A0", VA = "0x187745EA0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool PDFHDIIEBEF
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7745E80", Offset = "0x7745280", VA = "0x187745E80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	public AAAODCNJBDN(Behaviour DLBIKABGMBD)
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

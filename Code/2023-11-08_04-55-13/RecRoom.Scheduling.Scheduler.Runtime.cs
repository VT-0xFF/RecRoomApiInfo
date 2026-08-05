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
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class PKKNNGCOAMO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority GCELHMJHHAC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64E5190", Offset = "0x64E3F90", VA = "0x1864E5190")]
	public PKKNNGCOAMO(ThreadPriority JPEHOGNCPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64E5180", Offset = "0x64E3F80", VA = "0x1864E5180", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private delegate List<PlayerLoopSystem> BNPIAGIBOED(List<PlayerLoopSystem> GPMKBOCPMMA, int AFMGMEHINAP);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct IJABMMBOLNA
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct CBNIFCDMNKK
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static INNFNKFCEKE DBGHFCFMBAK;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x64CE360", Offset = "0x64CD160", VA = "0x1864CE360")]
				public static PlayerLoopSystem JKBHHGKMCKC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct LJECJKKPANN
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static INNFNKFCEKE ELIHGCHEEGF;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x64E08A0", Offset = "0x64DF6A0", VA = "0x1864E08A0")]
				public static PlayerLoopSystem JKBHHGKMCKC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct LKFNOFOLNLA
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static INNFNKFCEKE CKFDOIPHPNN;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x64E0AA0", Offset = "0x64DF8A0", VA = "0x1864E0AA0")]
				public static PlayerLoopSystem JKBHHGKMCKC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct JCNGDDLMCGJ
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static INNFNKFCEKE IELBJDAFHOF;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static INNFNKFCEKE AMPBNFBEHNO;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static INNFNKFCEKE LGDNFGKNIPD;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static INNFNKFCEKE DODCNBGNCNO;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x64DEC60", Offset = "0x64DDA60", VA = "0x1864DEC60")]
				public static PlayerLoopSystem JKBHHGKMCKC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct CAGDCNNMMAP
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static INNFNKFCEKE MNDFCAFHJCA;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x64CE160", Offset = "0x64CCF60", VA = "0x1864CE160")]
				public static PlayerLoopSystem JKBHHGKMCKC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct NMHLIOMBJKO
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static INNFNKFCEKE IELBJDAFHOF;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static INNFNKFCEKE AMPBNFBEHNO;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static INNFNKFCEKE LGDNFGKNIPD;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static INNFNKFCEKE DODCNBGNCNO;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x64E2B70", Offset = "0x64E1970", VA = "0x1864E2B70")]
				public static PlayerLoopSystem JKBHHGKMCKC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct JFNOBFCLAEC
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static INNFNKFCEKE FJDIMHEFPPL;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x64DF0E0", Offset = "0x64DDEE0", VA = "0x1864DF0E0")]
				public static PlayerLoopSystem JKBHHGKMCKC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct EANJIJMBJHO
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static INNFNKFCEKE OEIEAKGNDLL;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x64D5040", Offset = "0x64D3E40", VA = "0x1864D5040")]
				public static PlayerLoopSystem JKBHHGKMCKC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct CEJFAKABEHI
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static INNFNKFCEKE OMIJHNGKAAA;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x64CE680", Offset = "0x64CD480", VA = "0x1864CE680")]
				public static PlayerLoopSystem JKBHHGKMCKC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct KGGKLMJLJGH
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static INNFNKFCEKE EDAFMNJNKKG;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x64E0110", Offset = "0x64DEF10", VA = "0x1864E0110")]
				public static PlayerLoopSystem JKBHHGKMCKC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct BOECBHLPCHE
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static INNFNKFCEKE KOLBCPEHIFO;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x64CDF60", Offset = "0x64CCD60", VA = "0x1864CDF60")]
				public static PlayerLoopSystem JKBHHGKMCKC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct LLDFDBNLOHK
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static INNFNKFCEKE CELPEFGKOHP;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x64E0CA0", Offset = "0x64DFAA0", VA = "0x1864E0CA0")]
				public static PlayerLoopSystem JKBHHGKMCKC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum APEBHDHGAIL : byte
			{
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct CJHPADJKFEB
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class HLICJNNBCOG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public APEBHDHGAIL updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
					public HLICJNNBCOG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x64DC8F0", Offset = "0x64DB6F0", VA = "0x1864DC8F0")]
					internal void JPKONODPPMG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static BJPKLEOBMLD<APEBHDHGAIL> FDNABMJMINO;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x64CF580", Offset = "0x64CE380", VA = "0x1864CF580")]
				public static PlayerLoopSystem JKBHHGKMCKC(APEBHDHGAIL POBJJKJLIKJ)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct HJDPAGOIOKO
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class EJIFFDJEDPA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public BHFDMDHAOPK.BJCKCFGDHNB key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
					public EJIFFDJEDPA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x64D6190", Offset = "0x64D4F90", VA = "0x1864D6190")]
					internal void LOIKLPICPHJ()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable LLLGFMIPNHG;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x64DC7C0", Offset = "0x64DB5C0", VA = "0x1864DC7C0")]
				public static PlayerLoopSystem BCMDGHIMCHM(BHFDMDHAOPK.BJCKCFGDHNB GAMCILOFBAF)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct LIBHOJFDPED
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class ECLNPNIKMNP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public BHFDMDHAOPK.BJCKCFGDHNB key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
					public ECLNPNIKMNP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x64D53E0", Offset = "0x64D41E0", VA = "0x1864D53E0")]
					internal void LOIKLPICPHJ()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x64E0770", Offset = "0x64DF570", VA = "0x1864E0770")]
				public static PlayerLoopSystem BCMDGHIMCHM(BHFDMDHAOPK.BJCKCFGDHNB GAMCILOFBAF)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class CCAFGJABLNM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
			public CCAFGJABLNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x64CE560", Offset = "0x64CD360", VA = "0x1864CE560")]
			internal List<PlayerLoopSystem> IMBFMGPKDEE(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool ILAAAGEPDLO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool FCMPIEMBJDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x64D06C0", Offset = "0x64CF4C0", VA = "0x1864D06C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64D0700", Offset = "0x64CF500", VA = "0x1864D0700")]
		private static void GFHFOFMFFFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64D3410", Offset = "0x64D2210", VA = "0x1864D3410")]
		private static void KPCFNOPFMGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64D02D0", Offset = "0x64CF0D0", VA = "0x1864D02D0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64D0500", Offset = "0x64CF300", VA = "0x1864D0500")]
		private static void BCMFMMHCGKA(BHFDMDHAOPK.BJCKCFGDHNB GAMCILOFBAF, PlayerLoopSystem KFBPBOIFCKE, Type NEFIJPCIFGO, Type BPBKLAPHCLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64D3030", Offset = "0x64D1E30", VA = "0x1864D3030")]
		private static void INLBGBNOONF(PlayerLoopSystem KFBPBOIFCKE, Type NEFIJPCIFGO, Type BPBKLAPHCLK, BNPIAGIBOED FDCMGDGONJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64D3CE0", Offset = "0x64D2AE0", VA = "0x1864D3CE0")]
		private static void MLLBDPFDCIB(PlayerLoopSystem KFBPBOIFCKE, Type NEFIJPCIFGO, Type BPBKLAPHCLK, PlayerLoopSystem? FIEMAMEKCEP, PlayerLoopSystem? MEIGGEILCBE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class BHFDMDHAOPK
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum BJCKCFGDHNB
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class EFOHACFNLEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly BJCKCFGDHNB HDOKNIJFODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly OHNBPKFFFFO MJJCIGFMEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long FICIFIIKHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long PIKDMOIMIFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long MFAEBILGHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int ENHHMOOMBKL;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x64D59D0", Offset = "0x64D47D0", VA = "0x1864D59D0")]
		public EFOHACFNLEF(BJCKCFGDHNB HBMLJGBGNPD, int NALJLOKDPEH = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64D5780", Offset = "0x64D4580", VA = "0x1864D5780")]
		public void DPOIEFKALPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64D5730", Offset = "0x64D4530", VA = "0x1864D5730")]
		public void BMOFJOHNHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x64D57F0", Offset = "0x64D45F0", VA = "0x1864D57F0")]
		public void LEGOGOOBMBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static BJCKCFGDHNB[] FEFBBPEGEHJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static EFOHACFNLEF[] JJKIMBKCGMM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x64CDB40", Offset = "0x64CC940", VA = "0x1864CDB40")]
	public static EFOHACFNLEF BOPBCHPELEN(BJCKCFGDHNB GAMCILOFBAF, int NALJLOKDPEH = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x64CDAD0", Offset = "0x64CC8D0", VA = "0x1864CDAD0")]
	public static EFOHACFNLEF ALGPLHAEBEC(BJCKCFGDHNB GAMCILOFBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x64CDD20", Offset = "0x64CCB20", VA = "0x1864CDD20")]
	public static void NAMLIFMAJBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OHNBPKFFFFO : LGDBIJCEKLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int KEPHGPCKFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> EPAOEJDHICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double JKEMBJGJJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double LLLCDDJJCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double GKKELIKBHPL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double KBFBLIEMPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x64E30B0", Offset = "0x64E1EB0", VA = "0x1864E30B0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double KLOEFEAPBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x16C7380", Offset = "0x16C6180", VA = "0x1816C7380", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double OIJGKHGCHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1C83D90", Offset = "0x1C82B90", VA = "0x181C83D90", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x64E3180", Offset = "0x64E1F80", VA = "0x1864E3180")]
	public OHNBPKFFFFO(int NBDGBALCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x64E2F90", Offset = "0x64E1D90", VA = "0x1864E2F90", Slot = "7")]
	public void BDBHJKFNNLI(double DEEINHGIBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x64E3110", Offset = "0x64E1F10", VA = "0x1864E3110", Slot = "8")]
	public void KICOEKABIEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KHNMLHOLDGN : LGDBIJCEKLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long PDNIMDHODLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double FKAKHAACDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double OHEBCKFFAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double ADEHHMMKBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double HENAGNBCDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double JKEMBJGJJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double LLLCDDJJCLJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double KLOEFEAPBHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x548E510", Offset = "0x548D310", VA = "0x18548E510", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double OIJGKHGCHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x548E950", Offset = "0x548D750", VA = "0x18548E950", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double KNLJCAGHDND
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x548E9B0", Offset = "0x548D7B0", VA = "0x18548E9B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double KBFBLIEMPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2092EB0", Offset = "0x2091CB0", VA = "0x182092EB0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x64E0310", Offset = "0x64DF110", VA = "0x1864E0310", Slot = "7")]
	public virtual void BDBHJKFNNLI(double DEEINHGIBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x64E0430", Offset = "0x64DF230", VA = "0x1864E0430", Slot = "8")]
	public virtual void KICOEKABIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x64D53B0", Offset = "0x64D41B0", VA = "0x1864D53B0")]
	public KHNMLHOLDGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class EANMDHDKPKF : KHNMLHOLDGN
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double NJIHDKAAFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x548E9F0", Offset = "0x548D7F0", VA = "0x18548E9F0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x548E9C0", Offset = "0x548D7C0", VA = "0x18548E9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x64D5240", Offset = "0x64D4040", VA = "0x1864D5240", Slot = "7")]
	public override void BDBHJKFNNLI(double DEEINHGIBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x64D5370", Offset = "0x64D4170", VA = "0x1864D5370", Slot = "8")]
	public override void KICOEKABIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x64D53B0", Offset = "0x64D41B0", VA = "0x1864D53B0")]
	public EANMDHDKPKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface LGDBIJCEKLN
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double KBFBLIEMPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double KLOEFEAPBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double OIJGKHGCHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class GDHKNPINCLN
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface JGOPDFGFNJH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool FLDPDBINHJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OOBGEKLFCIL();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class PHMHPGHKEHN<TPromise, TMainThreadPromise> : JGOPDFGFNJH where TPromise : NEJLEODJDGB where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise OIKOFGEDHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise PNNGMFPBCMH;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise KAEHMMBEHCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x3EF4A80", Offset = "0x3EF3880", VA = "0x183EF4A80")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FLDPDBINHJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3EF4AE0", Offset = "0x3EF38E0", VA = "0x183EF4AE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x77D1D0", Offset = "0x77BFD0", VA = "0x18077D1D0")]
		protected PHMHPGHKEHN(TPromise OIKOFGEDHJA, TMainThreadPromise MNIPNOHBENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3EF4B30", Offset = "0x3EF3930", VA = "0x183EF4B30", Slot = "5")]
		public void OOBGEKLFCIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void GHCOCFNCKKF(TPromise OIKOFGEDHJA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class ANNDJHOAECI<T> : PHMHPGHKEHN<HIIDJBNNIDE<T>, GDNGGNIHMMB<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x37B8460", Offset = "0x37B7260", VA = "0x1837B8460")]
		public ANNDJHOAECI(HIIDJBNNIDE<T> OIKOFGEDHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x37B8250", Offset = "0x37B7050", VA = "0x1837B8250", Slot = "6")]
		protected override void GHCOCFNCKKF(HIIDJBNNIDE<T> OIKOFGEDHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3698D60", Offset = "0x3697B60", VA = "0x183698D60")]
		[CompilerGenerated]
		private void MGLFHJHLDPH(T OKONIBAEEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x37B8220", Offset = "0x37B7020", VA = "0x1837B8220")]
		[CompilerGenerated]
		private void CPIOPONHEIO(string LMJIIJBFLBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class LDEDNLAEFLK : JGOPDFGFNJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action CBNAIFNPGEI;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool FLDPDBINHJH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x78A100", Offset = "0x788F00", VA = "0x18078A100", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76FDF0", VA = "0x180770FF0")]
		public LDEDNLAEFLK(Action CBNAIFNPGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB2C710", Offset = "0xB2B510", VA = "0x180B2C710", Slot = "5")]
		public void OOBGEKLFCIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<JGOPDFGFNJH> OPHJKIAEKGL;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x24F2270", Offset = "0x24F1070", VA = "0x1824F2270")]
	public static HIIDJBNNIDE<T> LICFHEJPDHJ<T>(this HIIDJBNNIDE<T> OIKOFGEDHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x64DAD60", Offset = "0x64D9B60", VA = "0x1864DAD60")]
	public static void LICFHEJPDHJ(Action CBNAIFNPGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x24F21B0", Offset = "0x24F0FB0", VA = "0x1824F21B0")]
	private static HIIDJBNNIDE<T> EPIFOKNANGP<T>(HIIDJBNNIDE<T> OIKOFGEDHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x64DAB50", Offset = "0x64D9950", VA = "0x1864DAB50")]
	private static void LEOMPHLCMGC(JGOPDFGFNJH GFGEOLLKEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x64DAE00", Offset = "0x64D9C00", VA = "0x1864DAE00")]
	private static void MPDEGAHBLNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x64DA970", Offset = "0x64D9770", VA = "0x1864DA970")]
	private static void FAFCPDOKIOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x64DAA70", Offset = "0x64D9870", VA = "0x1864DAA70")]
	private static void HOPHONLCPNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class AHDHGJCPCPN
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct FELANHMIELO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> LJPGLNNFNLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string FAMOKOHDHFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode IPEKMNLFGPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool KFPKCEPDLGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly EFBOHLFDEBA<string>.IPACEPEMCAN KNNHPFGJHGF;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x64D6690", Offset = "0x64D5490", VA = "0x1864D6690")]
		public FELANHMIELO(TaskCompletionSource<Scene> MJMIBDGKDFM, string FAMOKOHDHFN, LoadSceneMode IPEKMNLFGPC, bool KFPKCEPDLGE, EFBOHLFDEBA<string>.IPACEPEMCAN KNNHPFGJHGF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct KFAGPBAKGEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public EFBOHLFDEBA<string>.IPACEPEMCAN stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private EFBOHLFDEBA<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x64DF800", Offset = "0x64DE600", VA = "0x1864DF800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x64E00A0", Offset = "0x64DEEA0", VA = "0x1864E00A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct HOGECMFGPBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x64DC970", Offset = "0x64DB770", VA = "0x1864DC970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x64DCC90", Offset = "0x64DBA90", VA = "0x1864DCC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct CMLMAFJEFPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private FELANHMIELO <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x64CF750", Offset = "0x64CE550", VA = "0x1864CF750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x64CFB00", Offset = "0x64CE900", VA = "0x1864CFB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class FNEJIDONCGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public GDNGGNIHMMB<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public FNEJIDONCGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x64DA910", Offset = "0x64D9710", VA = "0x1864DA910")]
		internal void EKJLALCICGH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct DPDLDMBCONB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public EFBOHLFDEBA<string>.IPACEPEMCAN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private FNEJIDONCGL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EFBOHLFDEBA<string>.IPACEPEMCAN <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private EFBOHLFDEBA<string>.IPACEPEMCAN <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x64D4430", Offset = "0x64D3230", VA = "0x1864D4430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x64D4FD0", Offset = "0x64D3DD0", VA = "0x1864D4FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MGEPJBBOKBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x64E1350", Offset = "0x64E0150", VA = "0x1864E1350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x64E1860", Offset = "0x64E0660", VA = "0x1864E1860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct HOPPIJIBDAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public EFBOHLFDEBA<string>.IPACEPEMCAN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private EFBOHLFDEBA<string>.IPACEPEMCAN <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private EFBOHLFDEBA<string>.IPACEPEMCAN <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x64DCCF0", Offset = "0x64DBAF0", VA = "0x1864DCCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x64DD840", Offset = "0x64DC640", VA = "0x1864DD840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class MHEOHOELNNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public MHEOHOELNNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x64E18D0", Offset = "0x64E06D0", VA = "0x1864E18D0")]
		internal bool NBNABFGONPM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class MBNLMDDHIJI : IEnumerator<MCCNEPCEOKC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private MCCNEPCEOKC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public FPFMKNGKADD onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private MCCNEPCEOKC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public MBNLMDDHIJI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x64E1280", Offset = "0x64E0080", VA = "0x1864E1280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x64E0EF0", Offset = "0x64DFCF0", VA = "0x1864E0EF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x64E0EA0", Offset = "0x64DFCA0", VA = "0x1864E0EA0")]
		private void FKICEAEIDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x64E1230", Offset = "0x64E0030", VA = "0x1864E1230", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class KNKCLOAJMIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public GDNGGNIHMMB<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public KNKCLOAJMIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x64E0470", Offset = "0x64DF270", VA = "0x1864E0470")]
		internal bool AIFKJBMBDJG(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x64E04F0", Offset = "0x64DF2F0", VA = "0x1864E04F0")]
		internal void CJHMHKCKEBL(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class IEABNHHNJLO : IEnumerator<MCCNEPCEOKC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private MCCNEPCEOKC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public GDNGGNIHMMB<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private KNKCLOAJMIJ <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private MCCNEPCEOKC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public IEABNHHNJLO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x64DE2D0", Offset = "0x64DD0D0", VA = "0x1864DE2D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x64DE9E0", Offset = "0x64DD7E0", VA = "0x1864DE9E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> EPMKPEDKFPI;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static NEJLEODJDGB LFEJOFGGKMN;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation BDBBIAHBBHP;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static NEJLEODJDGB KIALMJOIFBN;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string KGDFBAGAJNL;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority FMCLEIJDMAD;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task GGDDGONDKGE;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> NEJNKMILMLB;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<FELANHMIELO> FOCDEDPEFNM;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task EHCKNAMKEDH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool PDIGNKGDNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x64CA8E0", Offset = "0x64C96E0", VA = "0x1864CA8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool OANJPIAEIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x64CAF00", Offset = "0x64C9D00", VA = "0x1864CAF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool BNNEMHOMCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x64CA7B0", Offset = "0x64C95B0", VA = "0x1864CA7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool OLKPILFPAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x64CB4F0", Offset = "0x64CA2F0", VA = "0x1864CB4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> GFIDCFPNKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x64CA430", Offset = "0x64C9230", VA = "0x1864CA430")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x64CADF0", Offset = "0x64C9BF0", VA = "0x1864CADF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x64CB6B0", Offset = "0x64CA4B0", VA = "0x1864CB6B0")]
	[EDDPDGHNFKG(CDPKAALAKDJ.EnteredEditModeNextFrame, 0)]
	private static void OILIJOPNFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x64CAFA0", Offset = "0x64C9DA0", VA = "0x1864CAFA0")]
	[AsyncStateMachine(typeof(KFAGPBAKGEE))]
	public static Task<Scene> MMIDOLPNAFN(string FAMOKOHDHFN, LoadSceneMode IPEKMNLFGPC = LoadSceneMode.Single, bool KFPKCEPDLGE = false, [Optional] EFBOHLFDEBA<string>.IPACEPEMCAN JEJANNBKBNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x64CAB00", Offset = "0x64C9900", VA = "0x1864CAB00")]
	[AsyncStateMachine(typeof(HOGECMFGPBG))]
	private static Task IMECFDBLAKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x64CB7B0", Offset = "0x64CA5B0", VA = "0x1864CB7B0")]
	[AsyncStateMachine(typeof(CMLMAFJEFPN))]
	private static Task OJAOOKEBGIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x64CB0F0", Offset = "0x64C9EF0", VA = "0x1864CB0F0")]
	[AsyncStateMachine(typeof(DPDLDMBCONB))]
	private static Task<Scene> NFICLAEEACB(string FAMOKOHDHFN, LoadSceneMode IPEKMNLFGPC, bool KFPKCEPDLGE, EFBOHLFDEBA<string>.IPACEPEMCAN KNNHPFGJHGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x64CA540", Offset = "0x64C9340", VA = "0x1864CA540")]
	private static void BDOGGBMPPBN(SceneInstance PCALNAMFDCK, LoadSceneMode IPEKMNLFGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x64CAD30", Offset = "0x64C9B30", VA = "0x1864CAD30")]
	private static void JAFJDIELHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x64CB3D0", Offset = "0x64CA1D0", VA = "0x1864CB3D0")]
	[AsyncStateMachine(typeof(MGEPJBBOKBC))]
	private static Task<Scene> NPGJNGNDOML(string FAMOKOHDHFN, LoadSceneMode IPEKMNLFGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x64CB240", Offset = "0x64CA040", VA = "0x1864CB240")]
	private static bool NIBOAEHDFOD(string FAMOKOHDHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x64CA6A0", Offset = "0x64C94A0", VA = "0x1864CA6A0")]
	[AsyncStateMachine(typeof(HOPPIJIBDAO))]
	private static Task<Scene> DALDIHPBMAB(EFBOHLFDEBA<string>.IPACEPEMCAN KNNHPFGJHGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x64CABB0", Offset = "0x64C99B0", VA = "0x1864CABB0")]
	public static HIIDJBNNIDE<Scene> IPOJHAMJEKB(string FAMOKOHDHFN, LoadSceneMode IPEKMNLFGPC = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x64CA160", Offset = "0x64C8F60", VA = "0x1864CA160")]
	public static NEJLEODJDGB ADAFPADFGLI(string FAMOKOHDHFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x64CA850", Offset = "0x64C9650", VA = "0x1864CA850")]
	[IteratorStateMachine(typeof(MBNLMDDHIJI))]
	private static IEnumerator<MCCNEPCEOKC> GCHKDGMDHNI(string FAMOKOHDHFN, FPFMKNGKADD OPCOKCLMDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x64CB330", Offset = "0x64CA130", VA = "0x1864CB330")]
	[IteratorStateMachine(typeof(IEABNHHNJLO))]
	private static IEnumerator<MCCNEPCEOKC> NIGNCLOFOIG(string FAMOKOHDHFN, LoadSceneMode IPEKMNLFGPC, GDNGGNIHMMB<Scene> OPCOKCLMDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x64CB580", Offset = "0x64CA380", VA = "0x1864CB580")]
	public static bool OFLBHAPPCPD([Out] string FGPLOABOICC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class JECFGGIJOJF
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x64DEF50", Offset = "0x64DDD50", VA = "0x1864DEF50")]
	public static IDisposable CIMMJPMKKMK(this MBIAOLNAIOO GMIADHJEACD, float LIBFDEMCADE, Action<float> OJKHNMNFHMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x64DF060", Offset = "0x64DDE60", VA = "0x1864DF060")]
	public static IDisposable KDHKJFJCBMB(this MBIAOLNAIOO GMIADHJEACD, Action<float> OJKHNMNFHMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x64DEFE0", Offset = "0x64DDDE0", VA = "0x1864DEFE0")]
	public static IDisposable EGBKNLLEGOM(this MBIAOLNAIOO GMIADHJEACD, Action<float> OJKHNMNFHMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class OMELAGDMABE
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x64E3C10", Offset = "0x64E2A10", VA = "0x1864E3C10")]
	public static IDisposable ODJPAOHKHOP(this MonoBehaviour JHPNJPCNPCF, Action OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x64E3CA0", Offset = "0x64E2AA0", VA = "0x1864E3CA0")]
	public static IDisposable ODJPAOHKHOP(this MonoBehaviour JHPNJPCNPCF, Action<float> OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x64E39B0", Offset = "0x64E27B0", VA = "0x1864E39B0")]
	public static IDisposable KHHFOFCHJNL(this MonoBehaviour JHPNJPCNPCF, Action OJKHNMNFHMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x64E36E0", Offset = "0x64E24E0", VA = "0x1864E36E0")]
	public static IDisposable FAFFAHJOFAG(this MonoBehaviour JHPNJPCNPCF, Action OJKHNMNFHMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x64E3660", Offset = "0x64E2460", VA = "0x1864E3660")]
	public static IDisposable FAFFAHJOFAG(this MonoBehaviour JHPNJPCNPCF, Action<float> OJKHNMNFHMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x64E38B0", Offset = "0x64E26B0", VA = "0x1864E38B0")]
	public static IDisposable ICIHCIIMIHL(this MonoBehaviour JHPNJPCNPCF, Action OJKHNMNFHMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x64E3230", Offset = "0x64E2030", VA = "0x1864E3230")]
	public static IDisposable ACIDECPIPEA(this MonoBehaviour JHPNJPCNPCF, Action OJKHNMNFHMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x64E3930", Offset = "0x64E2730", VA = "0x1864E3930")]
	public static IDisposable JKKFPLLIKAK(this MonoBehaviour JHPNJPCNPCF, Action OJKHNMNFHMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x64E3760", Offset = "0x64E2560", VA = "0x1864E3760")]
	public static IDisposable FNAGDKBDCPN(this MonoBehaviour JHPNJPCNPCF, float LIBFDEMCADE, Action<float> OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH, bool NMJPEGKICAO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x64E32B0", Offset = "0x64E20B0", VA = "0x1864E32B0")]
	public static IDisposable AHPFANIHKEM(this MonoBehaviour JHPNJPCNPCF, float LIBFDEMCADE, Action<float> OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH, bool NMJPEGKICAO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x64E33D0", Offset = "0x64E21D0", VA = "0x1864E33D0")]
	public static IDisposable BACBLBKKGJP(this MonoBehaviour JHPNJPCNPCF, float LIBFDEMCADE, Action<float> OJKHNMNFHMG, bool NMJPEGKICAO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x64E3520", Offset = "0x64E2320", VA = "0x1864E3520")]
	public static IDisposable COJDFCKGBFF(this MonoBehaviour JHPNJPCNPCF, Action<float> OJKHNMNFHMG, bool NMJPEGKICAO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x64E3A30", Offset = "0x64E2830", VA = "0x1864E3A30")]
	public static IDisposable MBEEOKLINIF(this MonoBehaviour JHPNJPCNPCF, Action<float> OJKHNMNFHMG, bool NMJPEGKICAO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x64E3B70", Offset = "0x64E2970", VA = "0x1864E3B70")]
	public static IDisposable NABJCEKNIEF(this MonoBehaviour JHPNJPCNPCF, Action<float> OJKHNMNFHMG, bool NMJPEGKICAO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x64E3AD0", Offset = "0x64E28D0", VA = "0x1864E3AD0")]
	public static IDisposable MIDOKKHACED(this MonoBehaviour JHPNJPCNPCF, Action<float> OJKHNMNFHMG, bool NMJPEGKICAO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x64E3810", Offset = "0x64E2610", VA = "0x1864E3810")]
	public static IDisposable GEALCCBADHF(this MonoBehaviour JHPNJPCNPCF, Action<float> OJKHNMNFHMG, bool NMJPEGKICAO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x64E3D30", Offset = "0x64E2B30", VA = "0x1864E3D30")]
	public static IDisposable PGPBGBKNLEH(this MonoBehaviour JHPNJPCNPCF, Action<float> OJKHNMNFHMG, bool NMJPEGKICAO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x64E35C0", Offset = "0x64E23C0", VA = "0x1864E35C0")]
	public static IDisposable CPPFIHGMBOK(this MonoBehaviour JHPNJPCNPCF, Action<float> OJKHNMNFHMG, bool NMJPEGKICAO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x64E3470", Offset = "0x64E2270", VA = "0x1864E3470")]
	public static IDisposable BGNDGDIFLED(this MonoBehaviour JHPNJPCNPCF, float LIBFDEMCADE, Action<float> OJKHNMNFHMG, bool NMJPEGKICAO = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class NDJIOONCGMI
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class EPKHOANBOEF : IEnumerator<MCCNEPCEOKC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private MCCNEPCEOKC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public JBFBPDELDKF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private NOKAJLIBNMJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private MCCNEPCEOKC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public EPKHOANBOEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x64D6410", Offset = "0x64D5210", VA = "0x1864D6410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x64D64F0", Offset = "0x64D52F0", VA = "0x1864D64F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class AGMKNOOOLHH : IEnumerator<MCCNEPCEOKC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private MCCNEPCEOKC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public JBFBPDELDKF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private NOKAJLIBNMJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private MCCNEPCEOKC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public AGMKNOOOLHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x64CA020", Offset = "0x64C8E20", VA = "0x1864CA020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x64CA110", Offset = "0x64C8F10", VA = "0x1864CA110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x64E27F0", Offset = "0x64E15F0", VA = "0x1864E27F0")]
	public static BOFKFADGKMI ODJPAOHKHOP(Action OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x64E2730", Offset = "0x64E1530", VA = "0x1864E2730")]
	public static BOFKFADGKMI ODJPAOHKHOP(Behaviour GMIADHJEACD, Action OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x64E28A0", Offset = "0x64E16A0", VA = "0x1864E28A0")]
	public static BOFKFADGKMI ODJPAOHKHOP(Behaviour GMIADHJEACD, Action<float> OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x64E2610", Offset = "0x64E1410", VA = "0x1864E2610")]
	[IteratorStateMachine(typeof(EPKHOANBOEF))]
	private static IEnumerator<MCCNEPCEOKC> BNEACDEKKCD(JBFBPDELDKF GAOHHAOODAP, Action OJKHNMNFHMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x64E26A0", Offset = "0x64E14A0", VA = "0x1864E26A0")]
	[IteratorStateMachine(typeof(AGMKNOOOLHH))]
	private static IEnumerator<MCCNEPCEOKC> BNEACDEKKCD(JBFBPDELDKF GAOHHAOODAP, Action<float> OJKHNMNFHMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class IEHBNKOGMBJ : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class EEAODPHPMKJ : IEnumerator<MCCNEPCEOKC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private MCCNEPCEOKC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public IEHBNKOGMBJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private MCCNEPCEOKC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public EEAODPHPMKJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x64D5650", Offset = "0x64D4450", VA = "0x1864D5650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x64D56E0", Offset = "0x64D44E0", VA = "0x1864D56E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly JBFBPDELDKF BDFEDOFBNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action EECKMFMLCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool HMMAKHMOJDN;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool GGHFBALOGGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7729A0", Offset = "0x7717A0", VA = "0x1807729A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x64DEB50", Offset = "0x64DD950", VA = "0x1864DEB50")]
	public IEHBNKOGMBJ(JBFBPDELDKF BDFEDOFBNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x64DEA30", Offset = "0x64DD830", VA = "0x1864DEA30")]
	[IteratorStateMachine(typeof(EEAODPHPMKJ))]
	private IEnumerator<MCCNEPCEOKC> LDGFMHFGKDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x64DEAB0", Offset = "0x64DD8B0", VA = "0x1864DEAB0", Slot = "4")]
	public void OnCompleted(Action CCEHCDHAOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200")]
	public void ALDPMIFBMCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class CFOKHEANFEB
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x64CE880", Offset = "0x64CD680", VA = "0x1864CE880")]
	public static IEHBNKOGMBJ ONGCPBCDKDC(this JBFBPDELDKF BDFEDOFBNJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class BDPBJFHNHJB
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class FANDAEKEFKI : IEnumerator<MCCNEPCEOKC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private MCCNEPCEOKC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public GBBLIJFFILI schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private MCCNEPCEOKC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public FANDAEKEFKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x64D6540", Offset = "0x64D5340", VA = "0x1864D6540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x64D65C0", Offset = "0x64D53C0", VA = "0x1864D65C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x64CD9D0", Offset = "0x64CC7D0", VA = "0x1864CD9D0")]
	public static BOFKFADGKMI ODJPAOHKHOP(float LIBFDEMCADE, Action<float> OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH, bool NMJPEGKICAO = true, [Optional] JIEEFHHJCEI HPOBMOHOFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x64CD8C0", Offset = "0x64CC6C0", VA = "0x1864CD8C0")]
	public static BOFKFADGKMI ODJPAOHKHOP(MonoBehaviour JHPNJPCNPCF, float LIBFDEMCADE, Action<float> OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH, bool NMJPEGKICAO = true, [Optional] JIEEFHHJCEI HPOBMOHOFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x64CD600", Offset = "0x64CC400", VA = "0x1864CD600")]
	public static BOFKFADGKMI FGKMCNDCFMI(MonoBehaviour JHPNJPCNPCF, float LIBFDEMCADE, Action<float> OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH, bool NMJPEGKICAO = true, [Optional] JIEEFHHJCEI HPOBMOHOFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x64CD7B0", Offset = "0x64CC5B0", VA = "0x1864CD7B0")]
	public static BOFKFADGKMI NDBEKKKHNGI(MBIAOLNAIOO GMIADHJEACD, float LIBFDEMCADE, Action<float> OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH, bool NMJPEGKICAO = true, [Optional] JIEEFHHJCEI HPOBMOHOFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x64CD4E0", Offset = "0x64CC2E0", VA = "0x1864CD4E0")]
	private static IEnumerator<MCCNEPCEOKC> BNEACDEKKCD(AJLBGLDLBFM LIPONNBJEKF, float LIBFDEMCADE, JBFBPDELDKF GAOHHAOODAP, Action<float> OJKHNMNFHMG, bool NMJPEGKICAO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x64CD5A0", Offset = "0x64CC3A0", VA = "0x1864CD5A0")]
	private static IEnumerator<MCCNEPCEOKC> CACCHBEALAF(AJLBGLDLBFM LIPONNBJEKF, float LIBFDEMCADE, JBFBPDELDKF GAOHHAOODAP, Action<float> OJKHNMNFHMG, bool NMJPEGKICAO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x64CD720", Offset = "0x64CC520", VA = "0x1864CD720")]
	[IteratorStateMachine(typeof(FANDAEKEFKI))]
	private static IEnumerator<MCCNEPCEOKC> HMCBJPAHMDM(GBBLIJFFILI DADILCAIMKG, float LIBFDEMCADE, JBFBPDELDKF GAOHHAOODAP, Action<float> OJKHNMNFHMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class NHGGBINJDFM
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class FGIKHFIGJDC : IEnumerator<MCCNEPCEOKC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private MCCNEPCEOKC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public JBFBPDELDKF queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private MCCNEPCEOKC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public FGIKHFIGJDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x64D66F0", Offset = "0x64D54F0", VA = "0x1864D66F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x64D67B0", Offset = "0x64D55B0", VA = "0x1864D67B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x64E29C0", Offset = "0x64E17C0", VA = "0x1864E29C0")]
	[IteratorStateMachine(typeof(FGIKHFIGJDC))]
	private static IEnumerator<MCCNEPCEOKC> IHJMODGAIKL(JBFBPDELDKF BDFEDOFBNJH, Func<bool> NACBPFCOKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x64E2A50", Offset = "0x64E1850", VA = "0x1864E2A50")]
	public static BOFKFADGKMI OBIKABOINNE(this MonoBehaviour JHPNJPCNPCF, Func<bool> NACBPFCOKIC, JBFBPDELDKF BDFEDOFBNJH = JBFBPDELDKF.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class IBINECJIBJG
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class GIBDMCPEKFE : IEnumerator<MCCNEPCEOKC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private MCCNEPCEOKC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public JBFBPDELDKF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private MCCNEPCEOKC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public GIBDMCPEKFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x64DB290", Offset = "0x64DA090", VA = "0x1864DB290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x64DB300", Offset = "0x64DA100", VA = "0x1864DB300", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class OBNNHBFAIFG : IEnumerator<MCCNEPCEOKC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private MCCNEPCEOKC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public JBFBPDELDKF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private MCCNEPCEOKC <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private MCCNEPCEOKC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public OBNNHBFAIFG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x64E2E60", Offset = "0x64E1C60", VA = "0x1864E2E60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x64E2EF0", Offset = "0x64E1CF0", VA = "0x1864E2EF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x64DE040", Offset = "0x64DCE40", VA = "0x1864DE040")]
	[IteratorStateMachine(typeof(GIBDMCPEKFE))]
	private static IEnumerator<MCCNEPCEOKC> LDGFMHFGKDA(float IGPHDAEBEMO, JBFBPDELDKF GAOHHAOODAP, Action MGDCGIGLBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x64DDF70", Offset = "0x64DCD70", VA = "0x1864DDF70")]
	[IteratorStateMachine(typeof(OBNNHBFAIFG))]
	private static IEnumerator<MCCNEPCEOKC> HIGEFAGBFED(float IGPHDAEBEMO, JBFBPDELDKF GAOHHAOODAP, Action MGDCGIGLBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x64DDB50", Offset = "0x64DC950", VA = "0x1864DDB50")]
	public static IDisposable FLCOHBJPMJC(this MonoBehaviour JHPNJPCNPCF, float IGPHDAEBEMO, Action MGDCGIGLBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x64DE1E0", Offset = "0x64DCFE0", VA = "0x1864DE1E0")]
	public static BOFKFADGKMI OBGOCFNKJKF(this MonoBehaviour JHPNJPCNPCF, float IGPHDAEBEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x64DDC70", Offset = "0x64DCA70", VA = "0x1864DDC70")]
	public static BOFKFADGKMI FLCOHBJPMJC(this MonoBehaviour JHPNJPCNPCF, float IGPHDAEBEMO, JBFBPDELDKF GAOHHAOODAP, Action MGDCGIGLBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x64DD990", Offset = "0x64DC790", VA = "0x1864DD990")]
	public static BOFKFADGKMI EBMHOGPCJGN(this MonoBehaviour JHPNJPCNPCF, Action MGDCGIGLBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x64DE2A0", Offset = "0x64DD0A0", VA = "0x1864DE2A0")]
	public static BOFKFADGKMI OLMAAAJALAD(this MonoBehaviour JHPNJPCNPCF, Action MGDCGIGLBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x64DD8B0", Offset = "0x64DC6B0", VA = "0x1864DD8B0")]
	public static BOFKFADGKMI AIINGKAEIDD(this MonoBehaviour JHPNJPCNPCF, Action MGDCGIGLBNK, [Optional] JIEEFHHJCEI HPOBMOHOFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x64DE010", Offset = "0x64DCE10", VA = "0x1864DE010")]
	public static BOFKFADGKMI JCAKJHBNKLI(this MonoBehaviour JHPNJPCNPCF, Action MGDCGIGLBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x64DE0E0", Offset = "0x64DCEE0", VA = "0x1864DE0E0")]
	public static BOFKFADGKMI MPCFMLFNGCH(this MonoBehaviour JHPNJPCNPCF, Action MGDCGIGLBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x64DDE70", Offset = "0x64DCC70", VA = "0x1864DDE70")]
	public static BOFKFADGKMI HAFDNNOEMBB(this MonoBehaviour JHPNJPCNPCF, Action MGDCGIGLBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x64DDDA0", Offset = "0x64DCBA0", VA = "0x1864DDDA0")]
	private static BOFKFADGKMI GHEOMPLFGEP(MonoBehaviour JHPNJPCNPCF, JBFBPDELDKF BDFEDOFBNJH, Action MGDCGIGLBNK, [Optional] JIEEFHHJCEI HPOBMOHOFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x64DE110", Offset = "0x64DCF10", VA = "0x1864DE110")]
	public static BOFKFADGKMI NLFEHKMMNMH(this MonoBehaviour JHPNJPCNPCF, float HLKBNOEKCOA, Action MGDCGIGLBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x64DD9B0", Offset = "0x64DC7B0", VA = "0x1864DD9B0")]
	public static BOFKFADGKMI FELJIIJDMJF(this MonoBehaviour JHPNJPCNPCF, float HLKBNOEKCOA, Action MGDCGIGLBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x64DDA80", Offset = "0x64DC880", VA = "0x1864DDA80")]
	public static BOFKFADGKMI FJBLALAADDJ(this MonoBehaviour JHPNJPCNPCF, float HLKBNOEKCOA, Action MGDCGIGLBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x64DDEA0", Offset = "0x64DCCA0", VA = "0x1864DDEA0")]
	public static BOFKFADGKMI HBEFPJKIIGC(this MonoBehaviour JHPNJPCNPCF, float HLKBNOEKCOA, Action MGDCGIGLBNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class FMEHDCCGPPF : AMADCBKPGLH, IEnumerable<AMADCBKPGLH>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<AMADCBKPGLH> JNGHBIHPLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool ICGPBIIMDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action BACHLMCFCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool ECNOFAGJAPP;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool BMBMOHKFMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x64D9FC0", Offset = "0x64D8DC0", VA = "0x1864D9FC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OPOPLKKCLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x64DA670", Offset = "0x64D9470", VA = "0x1864DA670", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x64DA5D0", Offset = "0x64D93D0", VA = "0x1864DA5D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x64DA870", Offset = "0x64D9670", VA = "0x1864DA870")]
	public FMEHDCCGPPF([Optional] Action BACHLMCFCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x64DA4A0", Offset = "0x64D92A0", VA = "0x1864DA4A0")]
	public void JHPNFEHLKNP(AMADCBKPGLH LKLLDGAGFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x64DA710", Offset = "0x64D9510", VA = "0x1864DA710")]
	private void MHJGMJMGCBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x64DA490", Offset = "0x64D9290", VA = "0x1864DA490", Slot = "7")]
	public bool IAMJEADCHOP(bool OOFPOBCGECA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x64DA180", Offset = "0x64D8F80", VA = "0x1864DA180", Slot = "8")]
	public bool IAMJEADCHOP(Action CBNAIFNPGEI, bool OOFPOBCGECA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x64DA100", Offset = "0x64D8F00", VA = "0x1864DA100", Slot = "9")]
	public IEnumerator<AMADCBKPGLH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x64DA100", Offset = "0x64D8F00", VA = "0x1864DA100", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CFPMLGLNDLN : EJCGCEOBAAI
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class GBKJENNOMNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CFPMLGLNDLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public GBKJENNOMNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x64D6800", Offset = "0x64D5600", VA = "0x1864D6800")]
		internal void BCCIAMACGGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class FINOGPOHFOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public CFPMLGLNDLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public FINOGPOHFOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x64D6800", Offset = "0x64D5600", VA = "0x1864D6800")]
		internal void NPLBCIMIECH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float AHBNOODJMIC;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x64CEBE0", Offset = "0x64CD9E0", VA = "0x1864CEBE0")]
	public CFPMLGLNDLN(Behaviour GMIADHJEACD, float AHBNOODJMIC, [Optional] Action BACHLMCFCFH, [Optional] JIEEFHHJCEI HPOBMOHOFFA, [Optional] AJLBGLDLBFM LIPONNBJEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x64CEAD0", Offset = "0x64CD8D0", VA = "0x1864CEAD0", Slot = "9")]
	protected override bool LBLJNIFECJP(Action CBNAIFNPGEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x64CE9C0", Offset = "0x64CD7C0", VA = "0x1864CE9C0", Slot = "10")]
	protected override bool DNIJBAEAFJG(Action CBNAIFNPGEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface AMADCBKPGLH
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool BMBMOHKFMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OPOPLKKCLEJ;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IAMJEADCHOP(bool OOFPOBCGECA = false);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IAMJEADCHOP(Action CBNAIFNPGEI, bool OOFPOBCGECA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class EJCGCEOBAAI : AMADCBKPGLH
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class OMNDMHJJKFH : IEnumerator<MCCNEPCEOKC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private MCCNEPCEOKC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public EJCGCEOBAAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private MCCNEPCEOKC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public OMNDMHJJKFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x64E3DD0", Offset = "0x64E2BD0", VA = "0x1864E3DD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x64E3EA0", Offset = "0x64E2CA0", VA = "0x1864E3EA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour GMIADHJEACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action BACHLMCFCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NADEPMJLGPK GPANHGEHJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly JIEEFHHJCEI HPOBMOHOFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly AJLBGLDLBFM LIPONNBJEKF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool BMBMOHKFMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xE71880", Offset = "0xE70680", VA = "0x180E71880", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OPOPLKKCLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x64D5D70", Offset = "0x64D4B70", VA = "0x1864D5D70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x64D5CD0", Offset = "0x64D4AD0", VA = "0x1864D5CD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x64D6090", Offset = "0x64D4E90", VA = "0x1864D6090")]
	protected EJCGCEOBAAI(Behaviour GMIADHJEACD, [Optional] Action BACHLMCFCFH, [Optional] JIEEFHHJCEI HPOBMOHOFFA, [Optional] AJLBGLDLBFM LIPONNBJEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x64D5C70", Offset = "0x64D4A70", VA = "0x1864D5C70", Slot = "7")]
	public bool IAMJEADCHOP(bool OOFPOBCGECA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x64D5C10", Offset = "0x64D4A10", VA = "0x1864D5C10", Slot = "8")]
	public bool IAMJEADCHOP(Action CBNAIFNPGEI, bool OOFPOBCGECA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool LBLJNIFECJP(Action CBNAIFNPGEI);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool DNIJBAEAFJG(Action CBNAIFNPGEI);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x64D5AE0", Offset = "0x64D48E0", VA = "0x1864D5AE0")]
	protected void AMEANBFGKOL(Action CBNAIFNPGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x64D5E10", Offset = "0x64D4C10", VA = "0x1864D5E10")]
	protected NEJLEODJDGB NABHAKKMPPL(float BIIJIGPINMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x64D5B90", Offset = "0x64D4990", VA = "0x1864D5B90")]
	private void FFENIDEIEAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x64D5B00", Offset = "0x64D4900", VA = "0x1864D5B00")]
	[IteratorStateMachine(typeof(OMNDMHJJKFH))]
	private IEnumerator<MCCNEPCEOKC> BICNLNMMIMP(float BIIJIGPINMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x64D6050", Offset = "0x64D4E50", VA = "0x1864D6050")]
	[CompilerGenerated]
	private void NDLMKHAKIDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class JNOFGHOEKHN : EJCGCEOBAAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float DDJOKADHIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int HEIPDCMLFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float HHFBGFIBDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] DLGGCIEANJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int FPHMEFDEFPI;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x64DF620", Offset = "0x64DE420", VA = "0x1864DF620")]
	public JNOFGHOEKHN(Behaviour GMIADHJEACD, float FHOCEOBKJPB, int HEIPDCMLFGB, [Optional] Action BACHLMCFCFH, float HHFBGFIBDGO = 0f, [Optional] JIEEFHHJCEI HPOBMOHOFFA, [Optional] AJLBGLDLBFM LIPONNBJEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "9")]
	protected override bool LBLJNIFECJP(Action CBNAIFNPGEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x64DF3A0", Offset = "0x64DE1A0", VA = "0x1864DF3A0", Slot = "10")]
	protected override bool DNIJBAEAFJG(Action CBNAIFNPGEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x64DF5A0", Offset = "0x64DE3A0", VA = "0x1864DF5A0")]
	private void GNFLLEFGHKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class KBMKLDBACBF : EJCGCEOBAAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float AHBNOODJMIC;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x64CEBE0", Offset = "0x64CD9E0", VA = "0x1864CEBE0")]
	public KBMKLDBACBF(Behaviour GMIADHJEACD, float AHBNOODJMIC, [Optional] Action BACHLMCFCFH, [Optional] JIEEFHHJCEI HPOBMOHOFFA, [Optional] AJLBGLDLBFM LIPONNBJEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "9")]
	protected override bool LBLJNIFECJP(Action CBNAIFNPGEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x64DF7C0", Offset = "0x64DE5C0", VA = "0x1864DF7C0", Slot = "10")]
	protected override bool DNIJBAEAFJG(Action CBNAIFNPGEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class CPBFBHFFLMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class ODNGJBPLJKE : IEnumerator<MCCNEPCEOKC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private MCCNEPCEOKC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private MCCNEPCEOKC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public ODNGJBPLJKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x64DF2E0", Offset = "0x64DE0E0", VA = "0x1864DF2E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x64E2F40", Offset = "0x64E1D40", VA = "0x1864E2F40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private BOFKFADGKMI AHMMNBHCLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private MBIAOLNAIOO GMIADHJEACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> DKILKLMLNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private JBFBPDELDKF BDFEDOFBNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float BFJGBJFJJLO;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x64D00F0", Offset = "0x64CEEF0", VA = "0x1864D00F0")]
	public CPBFBHFFLMN(MBIAOLNAIOO GMIADHJEACD, float LIBFDEMCADE, Action<float> OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x64CFF50", Offset = "0x64CED50", VA = "0x1864CFF50")]
	private void POLHLOLFHGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x64CFDF0", Offset = "0x64CEBF0", VA = "0x1864CFDF0")]
	private void KELLGOMEGIP(string LMJIIJBFLBD, Action KDDBOFLBOCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x64CFD70", Offset = "0x64CEB70", VA = "0x1864CFD70")]
	[IteratorStateMachine(typeof(ODNGJBPLJKE))]
	private IEnumerator<MCCNEPCEOKC> JAPCFHGICLI(Action KDDBOFLBOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x64CFB60", Offset = "0x64CE960", VA = "0x1864CFB60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x64CFBC0", Offset = "0x64CE9C0", VA = "0x1864CFBC0")]
	[CompilerGenerated]
	private void FCBLHDFKFCA(string HCEKMCLPHGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class PDMLNCILMKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JNNNKMJPEHK : IEnumerator<MCCNEPCEOKC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private MCCNEPCEOKC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private MCCNEPCEOKC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public JNNNKMJPEHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x64DF2E0", Offset = "0x64DE0E0", VA = "0x1864DF2E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x64DF350", Offset = "0x64DE150", VA = "0x1864DF350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private BOFKFADGKMI AHMMNBHCLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour JHPNJPCNPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action OJKHNMNFHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> DKILKLMLNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private JBFBPDELDKF BDFEDOFBNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float BFJGBJFJJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool NMJPEGKICAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly JIEEFHHJCEI HPOBMOHOFFA;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x64E4B00", Offset = "0x64E3900", VA = "0x1864E4B00")]
	public PDMLNCILMKK(MonoBehaviour JHPNJPCNPCF, Action OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH, [Optional] JIEEFHHJCEI HPOBMOHOFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x64E4F40", Offset = "0x64E3D40", VA = "0x1864E4F40")]
	public PDMLNCILMKK(MonoBehaviour JHPNJPCNPCF, Action<float> OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH, [Optional] JIEEFHHJCEI HPOBMOHOFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x64E4CF0", Offset = "0x64E3AF0", VA = "0x1864E4CF0")]
	public PDMLNCILMKK(MonoBehaviour JHPNJPCNPCF, float LIBFDEMCADE, Action<float> OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH, bool NMJPEGKICAO = true, [Optional] JIEEFHHJCEI HPOBMOHOFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1851EF0", Offset = "0x1850CF0", VA = "0x181851EF0")]
	private PDMLNCILMKK(JIEEFHHJCEI HPOBMOHOFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x64E4230", Offset = "0x64E3030", VA = "0x1864E4230")]
	internal static PDMLNCILMKK EMKKJDGJJBD(MonoBehaviour JHPNJPCNPCF, float LIBFDEMCADE, Action<float> OJKHNMNFHMG, JBFBPDELDKF BDFEDOFBNJH, bool NMJPEGKICAO = true, [Optional] JIEEFHHJCEI HPOBMOHOFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x64E47E0", Offset = "0x64E35E0", VA = "0x1864E47E0")]
	private void ODJPAOHKHOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x64E4630", Offset = "0x64E3430", VA = "0x1864E4630")]
	private void NPDNCBIKMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x64E4950", Offset = "0x64E3750", VA = "0x1864E4950")]
	private void POLHLOLFHGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x64E3F80", Offset = "0x64E2D80", VA = "0x1864E3F80")]
	private void CLHKDBHICPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x64E4470", Offset = "0x64E3270", VA = "0x1864E4470")]
	private void KELLGOMEGIP(string LMJIIJBFLBD, Action KDDBOFLBOCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x64E43F0", Offset = "0x64E31F0", VA = "0x1864E43F0")]
	[IteratorStateMachine(typeof(JNNNKMJPEHK))]
	private IEnumerator<MCCNEPCEOKC> JAPCFHGICLI(Action KDDBOFLBOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x64E41D0", Offset = "0x64E2FD0", VA = "0x1864E41D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x64E45A0", Offset = "0x64E33A0", VA = "0x1864E45A0")]
	[CompilerGenerated]
	private void MHABINCBHIF(string HCEKMCLPHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x64E4140", Offset = "0x64E2F40", VA = "0x1864E4140")]
	[CompilerGenerated]
	private void DFKBADFPDEC(string HCEKMCLPHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x64E4360", Offset = "0x64E3160", VA = "0x1864E4360")]
	[CompilerGenerated]
	private void GMECELAMKID(string HCEKMCLPHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x64E3EF0", Offset = "0x64E2CF0", VA = "0x1864E3EF0")]
	[CompilerGenerated]
	private void CALNEIAAEHD(string HCEKMCLPHGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum LOKJDMAAPPK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal sealed class AJBDKFCBNAC : AJLBGLDLBFM
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float DMCJEIGGMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x64CBA90", Offset = "0x64CA890", VA = "0x1864CBA90", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float JKELIMLJBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x64CBB10", Offset = "0x64CA910", VA = "0x1864CBB10", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double DIIGEEDEIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x64CBA70", Offset = "0x64CA870", VA = "0x1864CBA70", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x64CBAA0", Offset = "0x64CA8A0", VA = "0x1864CBAA0")]
	[IBKPEPPEMNJ(MIBJABCBNEH.None)]
	private static void FFKEHMKHALM(KIDCBAFLGEK FEKKHCCBLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	[Preserve]
	internal AJBDKFCBNAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface KKBOOAGNEOI
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IJNABPEGHEK(string NDLLBBKGIJD);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDJPHGNBKEJ();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface KALHAJKFPAM
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string NKCKPGIEOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool AOBMNHPEBOB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool KHGDPAKEMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class DHFBLHICIOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public FJHNIBLHIIC LDLDDNLMCII;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int FNPAHLCJLFK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x76E180", Offset = "0x76CF80", VA = "0x18076E180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x775E30", Offset = "0x774C30", VA = "0x180775E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x64D4020", Offset = "0x64D2E20", VA = "0x1864D4020")]
	public static MCCNEPCEOKC DJCNPNIKGBP(IEnumerator<MCCNEPCEOKC> FNGOBEAEGBO, FDEBEDIKFPG CBJJPLNLOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x64D3F60", Offset = "0x64D2D60", VA = "0x1864D3F60")]
	public MCCNEPCEOKC DJCNPNIKGBP(FDEBEDIKFPG[] LDLFKCOOADL, IEnumerator<MCCNEPCEOKC>[] AIKKEBMKCPA, MCCNEPCEOKC[] CBHFDMHBBNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x64D42C0", Offset = "0x64D30C0", VA = "0x1864D42C0")]
	public void NAAABLKHGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x64D4180", Offset = "0x64D2F80", VA = "0x1864D4180")]
	public void GGENLEGNIOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x64D42F0", Offset = "0x64D30F0", VA = "0x1864D42F0")]
	public void KGLHGKFCIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x64D42C0", Offset = "0x64D30C0", VA = "0x1864D42C0")]
	public void GPMLCIKFNNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public DHFBLHICIOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class FJHNIBLHIIC
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct OEJAEIHIGJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public DHFBLHICIOI BKKLPHINCIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public MBIAOLNAIOO CBCCPANDMGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public FDEBEDIKFPG GPFIADJJCDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<MCCNEPCEOKC> OALKJGNBBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public MCCNEPCEOKC JKJDGOMKNGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public LOKJDMAAPPK BCBCHHKIJID;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct AALNKFMMGKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public JBFBPDELDKF CBBHCABLIFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<OEJAEIHIGJN> FALMIIHFLPO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class MJINIKHOAPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public FDEBEDIKFPG promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public FJHNIBLHIIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public MBIAOLNAIOO context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public DHFBLHICIOI routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public LOKJDMAAPPK coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public MCCNEPCEOKC currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<MCCNEPCEOKC> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public MJINIKHOAPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x64E1900", Offset = "0x64E0700", VA = "0x1864E1900")]
		internal void COHLIALNICO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class HGMDHFAFAHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public DHFBLHICIOI schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public FJHNIBLHIIC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public HGMDHFAFAHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x64DC780", Offset = "0x64DB580", VA = "0x1864DC780")]
		internal void IFHGANKMBNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class EMPDEABBFEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public DHFBLHICIOI schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public FJHNIBLHIIC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public EMPDEABBFEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x64D63D0", Offset = "0x64D51D0", VA = "0x1864D63D0")]
		internal void LHNBAECIAKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class MCMBHICPFDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public DHFBLHICIOI schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public FJHNIBLHIIC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public MCMBHICPFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x64E1310", Offset = "0x64E0110", VA = "0x1864E1310")]
		internal void HELFPPIKDKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const LOKJDMAAPPK JDOIONCEAHB = LOKJDMAAPPK.Cancelled | LOKJDMAAPPK.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly JBFBPDELDKF BDFEDOFBNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] MCBPCMIBLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<LOKJDMAAPPK> LPNANLGGGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> KHCILGHNMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> PHFLCKBALEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> OPGJINCHFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> IBOFFNKCMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> OHEKJFGJODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> HDJOOBDMKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private DHFBLHICIOI[] JFJADLELIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private FDEBEDIKFPG[] LDLFKCOOADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private MBIAOLNAIOO[] GKKAFBODIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<MCCNEPCEOKC>[] KDGEBOBGLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private MCCNEPCEOKC[] LOFJPKOFDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int GEPFGEIKIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int FNJNELBIPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int MJMIPMMGNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float HDKHBHBBPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private MOGJKCOHPEF CKJBHGOHNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle MMBJHGIMCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<DHFBLHICIOI> MKKIFMGEHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool NIDBPIAIIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> IJKBADEJFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> CFDBFOEJAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool FMPKPLALNOG;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public AALNKFMMGKE[] LPONMIFGBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x90AD10", Offset = "0x909B10", VA = "0x18090AD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x64D6C60", Offset = "0x64D5A60", VA = "0x1864D6C60")]
	private static int DNOJALIKDJO(JBFBPDELDKF BDFEDOFBNJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x64D8B90", Offset = "0x64D7990", VA = "0x1864D8B90")]
	public FJHNIBLHIIC(JBFBPDELDKF BDFEDOFBNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x64D77B0", Offset = "0x64D65B0", VA = "0x1864D77B0")]
	private void GGELECDGHFC(int KHBCFBBDKDM, int JNFEMHDCJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x64D7500", Offset = "0x64D6300", VA = "0x1864D7500")]
	public void FHKKLDHMBBK(MBIAOLNAIOO GMIADHJEACD, MCCNEPCEOKC BPIEHBGLJHB, IEnumerator<MCCNEPCEOKC> FNGOBEAEGBO, FDEBEDIKFPG CBJJPLNLOBG, [Optional] DHFBLHICIOI EEHKPCBCLGH, LOKJDMAAPPK GHFHCLIMBGD = LOKJDMAAPPK.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x64D7B40", Offset = "0x64D6940", VA = "0x1864D7B40")]
	public void IIEGJBPLMJK(IEnumerable<OEJAEIHIGJN> MCMBDOLPPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x64D7030", Offset = "0x64D5E30", VA = "0x1864D7030")]
	private OEJAEIHIGJN FHCIMMAAJBE(int JJOLOOABEEG)
	{
		return default(OEJAEIHIGJN);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x64D8820", Offset = "0x64D7620", VA = "0x1864D8820")]
	private void PJECKKCIGKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x24C7020", Offset = "0x24C5E20", VA = "0x1824C7020")]
	private static void ADCJCHHBKFM<T>(int JJOLOOABEEG, T[] GMKKDPDBBGI, int ICPPKLAMHFE, [Optional] T IAFEAIDHOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x24C7070", Offset = "0x24C5E70", VA = "0x1824C7070")]
	private static void ADCJCHHBKFM<T>(int JJOLOOABEEG, NativeArray<T> GMKKDPDBBGI, int ICPPKLAMHFE, [Optional] T IAFEAIDHOFI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x64D6C90", Offset = "0x64D5A90", VA = "0x1864D6C90")]
	private void FDPGCHINOLJ(IEnumerable<OEJAEIHIGJN> MCMBDOLPPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x64D7D80", Offset = "0x64D6B80", VA = "0x1864D7D80")]
	private void MIOGEPDCOCD(OEJAEIHIGJN FEOAMCGAEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x64D8540", Offset = "0x64D7340", VA = "0x1864D8540")]
	private BAJBOEOCPAO NLFMOGNACAD(int BFNCFBNCFIF)
	{
		return default(BAJBOEOCPAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x64D6960", Offset = "0x64D5760", VA = "0x1864D6960")]
	public void COODJFCLMFC(float NPFIEDLBONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x64D7AC0", Offset = "0x64D68C0", VA = "0x1864D7AC0")]
	private void IHPJIGEBKAD(Action ALNGIEPPLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x64D87A0", Offset = "0x64D75A0", VA = "0x1864D87A0")]
	private void OKACAGOFOGC(Action ALNGIEPPLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x64D7E40", Offset = "0x64D6C40", VA = "0x1864D7E40")]
	public void MPFDGKMIANG(float NPFIEDLBONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x64D6B60", Offset = "0x64D5960", VA = "0x1864D6B60")]
	public void DGLMKNHCGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x64D7990", Offset = "0x64D6790", VA = "0x1864D7990")]
	public void GPMLCIKFNNK(DHFBLHICIOI DADILCAIMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x64D7680", Offset = "0x64D6480", VA = "0x1864D7680")]
	public void GFAJHFFBLOG(DHFBLHICIOI DADILCAIMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x64D6830", Offset = "0x64D5630", VA = "0x1864D6830")]
	public void BBPHILPPHOA(DHFBLHICIOI DADILCAIMKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class DEJNOHLKIEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly DEJNOHLKIEO EAKJMFHJPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action HBEBAOEHJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool AOBNNKEMCKA;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76FDF0", VA = "0x180770FF0")]
	public DEJNOHLKIEO(Action HBEBAOEHJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x64D3E10", Offset = "0x64D2C10", VA = "0x1864D3E10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface DJPOACDNLEF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T DHGNDNJJJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable CAIMCFGJNBN(UnityEngine.Object GMIADHJEACD, Action<T> OPBEDDJMHDI);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface LNJDECCOACK<T> : DJPOACDNLEF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T DHGNDNJJJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class GKEFCGOJDNG<T> : LNJDECCOACK<T>, DJPOACDNLEF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class DDMOOHKFHMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public GKEFCGOJDNG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public HLBFOKGCHKJ<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public DDMOOHKFHMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4D7A0D0", Offset = "0x4D78ED0", VA = "0x184D7A0D0")]
		internal void LGNNEJIGMFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject HNCBGAEPDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<HLBFOKGCHKJ<UnityEngine.Object, Action<T>>> PLLEOFBGDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T BFIOMLPDDCJ;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T DHGNDNJJJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x81EC90", Offset = "0x81DA90", VA = "0x18081EC90", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x35E60B0", Offset = "0x35E4EB0", VA = "0x1835E60B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x35E5C10", Offset = "0x35E4A10", VA = "0x1835E5C10")]
	private static bool BPFHPNCJKEH(T ALNGIEPPLJJ, T DCODMCLNKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x35E6840", Offset = "0x35E5640", VA = "0x1835E6840")]
	public GKEFCGOJDNG(T PGHIBAAKJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x35E5D10", Offset = "0x35E4B10", VA = "0x1835E5D10", Slot = "6")]
	public IDisposable CAIMCFGJNBN(UnityEngine.Object GMIADHJEACD, Action<T> OPBEDDJMHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x35E6460", Offset = "0x35E5260", VA = "0x1835E6460")]
	private void JBPEIGGOEPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class GGJHHFIINAD : FOGLOFJPKKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly JIEEFHHJCEI HPOBMOHOFFA;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x64DB220", Offset = "0x64DA020", VA = "0x1864DB220")]
	[IBKPEPPEMNJ(MIBJABCBNEH.None)]
	private static void FFKEHMKHALM(KIDCBAFLGEK FEKKHCCBLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76FDF0", VA = "0x180770FF0")]
	[Preserve]
	internal GGJHHFIINAD([HOHGLGKGFHE(null)] JIEEFHHJCEI HPOBMOHOFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x64DB170", Offset = "0x64D9F70", VA = "0x1864DB170", Slot = "4")]
	public IDisposable BACBLBKKGJP(float LIBFDEMCADE, Action<float> PJJEKPONKPF, bool NMJPEGKICAO = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class FKBCEDFNFKC : GNAMCAAHBMH, JIEEFHHJCEI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private FJHNIBLHIIC[] FIOHJFPGHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private KKBOOAGNEOI HFIOHNFBEKM;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x64D9240", Offset = "0x64D8040", VA = "0x1864D9240")]
	[IBKPEPPEMNJ(MIBJABCBNEH.None)]
	private static void FFKEHMKHALM(KIDCBAFLGEK FEKKHCCBLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x64D9E10", Offset = "0x64D8C10", VA = "0x1864D9E10")]
	[Preserve]
	public FKBCEDFNFKC([HOHGLGKGFHE(null)] OOHPLFGDOBA LHBDPBGIPFE, [HOHGLGKGFHE(null)] AJLBGLDLBFM LIPONNBJEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x64D92B0", Offset = "0x64D80B0", VA = "0x1864D92B0", Slot = "17")]
	public override BOFKFADGKMI GEFMJOPELGG(MBIAOLNAIOO GMIADHJEACD, IEnumerator<MCCNEPCEOKC> IHAJAAMKIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x64D9550", Offset = "0x64D8350", VA = "0x1864D9550", Slot = "18")]
	public override void KICOEKABIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x64D9860", Offset = "0x64D8660", VA = "0x1864D9860", Slot = "20")]
	public override void NDDLJIDLEOL(JBFBPDELDKF BDFEDOFBNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x64D93E0", Offset = "0x64D81E0", VA = "0x1864D93E0", Slot = "19")]
	protected override void KHHFOFCHJNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x64D9DE0", Offset = "0x64D8BE0", VA = "0x1864D9DE0")]
	private FJHNIBLHIIC PKJJMPKHFED(JBFBPDELDKF AOPDMLJGEMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x64D9A90", Offset = "0x64D8890", VA = "0x1864D9A90", Slot = "21")]
	internal override CICKBBLACML NLIBONIFPMC(IEnumerator<MCCNEPCEOKC> IHAJAAMKIIB, Behaviour GMIADHJEACD, FDEBEDIKFPG CBJJPLNLOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x64D97E0", Offset = "0x64D85E0", VA = "0x1864D97E0", Slot = "22")]
	internal override APNAJGAKLAK MKGGCCABAGF(JBFBPDELDKF GAOHHAOODAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x64D9CC0", Offset = "0x64D8AC0", VA = "0x1864D9CC0")]
	private void OGDIMNBEGIC(FJHNIBLHIIC DAJOCGLMBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x64D91E0", Offset = "0x64D7FE0", VA = "0x1864D91E0", Slot = "23")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct MOGJKCOHPEF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float PJFOHIBFKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int EFNFNBEMGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> DEMFKKBPKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> FIGILDPGOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> NNGJOHELNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<LOKJDMAAPPK> LKOMCOLAOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> JMAIGGAAIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> IBOFFNKCMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> PHFLCKBALEN;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x64E20F0", Offset = "0x64E0EF0", VA = "0x1864E20F0")]
	public static MOGJKCOHPEF CBILMLOBPDD(int BHKKKBGDLOB, float NPFIEDLBONG, NativeArray<LOKJDMAAPPK> FCAPKPFMIAF, NativeArray<float> DEBFDGNOBHA, NativeArray<int> CBFIGJAGOKD, NativeArray<int> CALFHNGPCFA, NativeArray<int> OPIBEEMNIGA, NativeArray<int> FIGILDPGOJC, NativeArray<int> NNGJOHELNKL)
	{
		return default(MOGJKCOHPEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x64E2150", Offset = "0x64E0F50", VA = "0x1864E2150", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x64E20B0", Offset = "0x64E0EB0", VA = "0x1864E20B0")]
	private bool BMEEDDNAFNH(int NGIPPLLBEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x64E2300", Offset = "0x64E1100", VA = "0x1864E2300")]
	private void MJHGFBDFCFI(NativeArray<int> OGDGMNJCAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x64E2570", Offset = "0x64E1370", VA = "0x1864E2570")]
	private int OIMEGFLCHMI(int DGJOOHCPOHC, int OBKACGKKDGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x64E2230", Offset = "0x64E1030", VA = "0x1864E2230")]
	private void FHOELGCENEA(NativeArray<int> OGDGMNJCAGC, int LFKMPANNFOG, int OLDPDBPDEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x64E2330", Offset = "0x64E1130", VA = "0x1864E2330")]
	private void NHOIHCLIPLB(NativeArray<int> OGDGMNJCAGC, int KKPAILDHAOE, int ANBADLMJKBN, int NGJMAAIDMBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class GNAMCAAHBMH : JIEEFHHJCEI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly OOHPLFGDOBA LHBDPBGIPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly AJLBGLDLBFM LIPONNBJEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private APNAJGAKLAK[] OHLPNKJIEFG;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static JIEEFHHJCEI ANGIAPALHML
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x64DC020", Offset = "0x64DAE20", VA = "0x1864DC020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool LNODLGKLEOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x78A100", Offset = "0x788F00", VA = "0x18078A100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public JBFBPDELDKF BJOKAPLGOIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x76E180", Offset = "0x76CF80", VA = "0x18076E180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JBFBPDELDKF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x775E30", Offset = "0x774C30", VA = "0x180775E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public AJLBGLDLBFM CAGFJEEEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x775E10", Offset = "0x774C10", VA = "0x180775E10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public MCCNEPCEOKC CHFHODNBKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x772C00", Offset = "0x771A00", VA = "0x180772C00", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MCCNEPCEOKC GOLGKEFGINN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7729D0", Offset = "0x7717D0", VA = "0x1807729D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x64DC090", Offset = "0x64DAE90", VA = "0x1864DC090")]
	public static BOFKFADGKMI MDEMFIBKMBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x64DC290", Offset = "0x64DB090", VA = "0x1864DC290")]
	[Preserve]
	protected GNAMCAAHBMH([HOHGLGKGFHE(null)] OOHPLFGDOBA LHBDPBGIPFE, [HOHGLGKGFHE(null)] AJLBGLDLBFM LIPONNBJEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x64DB5B0", Offset = "0x64DA3B0", VA = "0x1864DB5B0", Slot = "6")]
	public BOFKFADGKMI DJNJBINOIEF(IEnumerator<MCCNEPCEOKC> IHAJAAMKIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x64DB5C0", Offset = "0x64DA3C0", VA = "0x1864DB5C0", Slot = "7")]
	public BOFKFADGKMI DJNJBINOIEF(Behaviour GMIADHJEACD, IEnumerator<MCCNEPCEOKC> IHAJAAMKIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract BOFKFADGKMI GEFMJOPELGG(MBIAOLNAIOO GMIADHJEACD, IEnumerator<MCCNEPCEOKC> IHAJAAMKIIB);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x64DBE80", Offset = "0x64DAC80", VA = "0x1864DBE80", Slot = "18")]
	public virtual void KICOEKABIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x64DB350", Offset = "0x64DA150", VA = "0x1864DB350", Slot = "9")]
	public void ABCOBHFCJGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x64DBE60", Offset = "0x64DAC60", VA = "0x1864DBE60", Slot = "19")]
	protected virtual void KHHFOFCHJNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB80", Offset = "0x64DA980", VA = "0x1864DBB80")]
	private void ELIHGCHEEGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x64DB590", Offset = "0x64DA390", VA = "0x1864DB590")]
	private void CKFDOIPHPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x64DBC30", Offset = "0x64DAA30", VA = "0x1864DBC30")]
	private void FAFFAHJOFAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x64DBC70", Offset = "0x64DAA70", VA = "0x1864DBC70")]
	private void ICIHCIIMIHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x64DBC50", Offset = "0x64DAA50", VA = "0x1864DBC50")]
	private void FJDIMHEFPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x64DC210", Offset = "0x64DB010", VA = "0x1864DC210")]
	private void OEIEAKGNDLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x64DC070", Offset = "0x64DAE70", VA = "0x1864DC070")]
	private void LKKNBAGKFKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x64DC120", Offset = "0x64DAF20", VA = "0x1864DC120", Slot = "20")]
	public virtual void NDDLJIDLEOL(JBFBPDELDKF BDFEDOFBNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x64DBC90", Offset = "0x64DAA90", VA = "0x1864DBC90")]
	private void JILBPHOAICH(APNAJGAKLAK DAJOCGLMBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1BE3410", Offset = "0x1BE2210", VA = "0x181BE3410")]
	private APNAJGAKLAK IEGMFEKBHGM(JBFBPDELDKF AOPDMLJGEMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract CICKBBLACML NLIBONIFPMC(IEnumerator<MCCNEPCEOKC> IHAJAAMKIIB, Behaviour JHPNJPCNPCF, FDEBEDIKFPG HMKGODJGMGN);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract APNAJGAKLAK MKGGCCABAGF(JBFBPDELDKF BDFEDOFBNJH);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x64DB7C0", Offset = "0x64DA5C0", VA = "0x1864DB7C0", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x64DC230", Offset = "0x64DB030", VA = "0x1864DC230", Slot = "13")]
	public MCCNEPCEOKC OKEFGMIEOHO(JBFBPDELDKF GAOHHAOODAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x64DBBA0", Offset = "0x64DA9A0", VA = "0x1864DBBA0", Slot = "14")]
	public MCCNEPCEOKC FACDODAKPLB(float IGPHDAEBEMO, JBFBPDELDKF GAOHHAOODAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x64DC1B0", Offset = "0x64DAFB0", VA = "0x1864DC1B0", Slot = "15")]
	public MCCNEPCEOKC NJLJFANCNOH(Func<bool> NACBPFCOKIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class CICKBBLACML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly FDEBEDIKFPG CBJJPLNLOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly KALHAJKFPAM GMIADHJEACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool MAMGGEOEGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string NDLLBBKGIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private StackTrace DBIBEGNBOCF;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerator<MCCNEPCEOKC> OALKJGNBBLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x770F00", Offset = "0x76FD00", VA = "0x180770F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public MCCNEPCEOKC JKJDGOMKNGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x770C70", Offset = "0x76FA70", VA = "0x180770C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool IBOOIABKFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x64CF0B0", Offset = "0x64CDEB0", VA = "0x1864CF0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool ADBDOGLFKKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7F8FA0", Offset = "0x7F7DA0", VA = "0x1807F8FA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x89A5A0", Offset = "0x8993A0", VA = "0x18089A5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string NKCKPGIEOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x64CF130", Offset = "0x64CDF30", VA = "0x1864CF130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float BKJPACPDFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xFCFB70", Offset = "0xFCE970", VA = "0x180FCFB70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x54896A0", Offset = "0x54884A0", VA = "0x1854896A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x64CF3C0", Offset = "0x64CE1C0", VA = "0x1864CF3C0")]
	public CICKBBLACML(IEnumerator<MCCNEPCEOKC> FNGOBEAEGBO, KALHAJKFPAM GMIADHJEACD, FDEBEDIKFPG CBJJPLNLOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x64CECE0", Offset = "0x64CDAE0", VA = "0x1864CECE0")]
	public MCCNEPCEOKC DJCNPNIKGBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x64CEFF0", Offset = "0x64CDDF0", VA = "0x1864CEFF0")]
	public bool GFGEJHKJIJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x64CF060", Offset = "0x64CDE60", VA = "0x1864CF060")]
	public void GPMLCIKFNNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x64CF2E0", Offset = "0x64CE0E0", VA = "0x1864CF2E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x81DDB0", Offset = "0x81CBB0", VA = "0x18081DDB0")]
	[CompilerGenerated]
	private void HDLIBNKMKFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class FDEBEDIKFPG : GFMMFCNBIAE, BOFKFADGKMI, NADEPMJLGPK, NEJLEODJDGB, IEnumerator, MCCNEPCEOKC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private JBFBPDELDKF OCPFCBDGJNF;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private JBFBPDELDKF KFEICIMFPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xD70BA0", Offset = "0xD6F9A0", VA = "0x180D70BA0", Slot = "23")]
		get
		{
			return default(JBFBPDELDKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public JBFBPDELDKF LDLDDNLMCII
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x1265FB0", Offset = "0x1264DB0", VA = "0x181265FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private float FFDJPGHAJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7C45D0", Offset = "0x7C33D0", VA = "0x1807C45D0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool ICOIHCKANFP
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x64D6620", Offset = "0x64D5420", VA = "0x1864D6620", Slot = "24")]
	private bool LFAMHOHHMNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x64D6610", Offset = "0x64D5410", VA = "0x1864D6610", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x64D6640", Offset = "0x64D5440", VA = "0x1864D6640")]
	public FDEBEDIKFPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum BAJBOEOCPAO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class APNAJGAKLAK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum PGMKLOBKMBO
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct FNPCHDJMKBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public JBFBPDELDKF CBBHCABLIFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public PGMKLOBKMBO OKENJJPDIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public List<CICKBBLACML> ONCICMFDIII;
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly PGMKLOBKMBO[] EPMCFDCBAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly JBFBPDELDKF BDFEDOFBNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private bool OELOBGKIOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly CICKBBLACML[] DOFICJIAKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<CICKBBLACML> PDBNCEOBAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> AHJMIGAJEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<CICKBBLACML> NLACKOOPGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<int> AIFDOHLFGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly KKBOOAGNEOI AGCFOBJIIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private bool FMPKPLALNOG;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public FNPCHDJMKBL[,] KPDKGFLHDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7729D0", Offset = "0x7717D0", VA = "0x1807729D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x64CD040", Offset = "0x64CBE40", VA = "0x1864CD040")]
	public APNAJGAKLAK(JBFBPDELDKF GAOHHAOODAP, KKBOOAGNEOI AGCFOBJIIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x64CCD10", Offset = "0x64CBB10", VA = "0x1864CCD10")]
	public void NJKCAHEPLMC(CICKBBLACML FNGOBEAEGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x64CC590", Offset = "0x64CB390", VA = "0x1864CC590")]
	public void IHBFPHJIKEP(IList<CICKBBLACML> AIKKEBMKCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x64CC280", Offset = "0x64CB080", VA = "0x1864CC280")]
	public void GBIJEJOCGAA(IList<CICKBBLACML> AIKKEBMKCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x64CCE10", Offset = "0x64CBC10", VA = "0x1864CCE10")]
	private void OPDBOLDJHIC(CICKBBLACML FNGOBEAEGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x64CBE90", Offset = "0x64CAC90", VA = "0x1864CBE90")]
	private void DMCLPMPDAKN(IList<CICKBBLACML> AIKKEBMKCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x64CBD10", Offset = "0x64CAB10", VA = "0x1864CBD10")]
	private BAJBOEOCPAO DKKGPBBCNOC(CICKBBLACML FNGOBEAEGBO)
	{
		return default(BAJBOEOCPAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x64CC8A0", Offset = "0x64CB6A0", VA = "0x1864CC8A0")]
	public void KHHFOFCHJNL(float NPFIEDLBONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x64CBB20", Offset = "0x64CA920", VA = "0x1864CBB20")]
	public void ABCOBHFCJGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x64CCA10", Offset = "0x64CB810", VA = "0x1864CCA10")]
	private void MGPFDEFMMMN(List<CICKBBLACML> AIKKEBMKCPA, Stack<int> HPAOGABGKPF, bool PBJNAIEGLGE, float AFLOKLCIFFB = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x64CC020", Offset = "0x64CAE20", VA = "0x1864CC020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x64CC140", Offset = "0x64CAF40", VA = "0x1864CC140")]
	private void ECOMOAHHFGM(List<CICKBBLACML> AIKKEBMKCPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class GGICMANGOGJ : KKBOOAGNEOI
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "4")]
	public void IJNABPEGHEK(string NDLLBBKGIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
	public void KDJPHGNBKEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public GGICMANGOGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class FLEPODACFKL : KALHAJKFPAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Behaviour JHPNJPCNPCF;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string NKCKPGIEOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x64D9F40", Offset = "0x64D8D40", VA = "0x1864D9F40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool AOBMNHPEBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x64D9EF0", Offset = "0x64D8CF0", VA = "0x1864D9EF0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool KHGDPAKEMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x64D9ED0", Offset = "0x64D8CD0", VA = "0x1864D9ED0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76FDF0", VA = "0x180770FF0")]
	public FLEPODACFKL(Behaviour JHPNJPCNPCF)
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

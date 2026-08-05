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
public class ABDEKINDIGA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority HAKODOEOKPJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6996980", Offset = "0x6995580", VA = "0x186996980")]
	public ABDEKINDIGA(ThreadPriority LJJPDCOPOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6996970", Offset = "0x6995570", VA = "0x186996970", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> PHKIJDDIFDL(List<PlayerLoopSystem> DEPIEDPBDGI, int OMNGFFLFIFF);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct NBPNBMCPDAJ
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct GMAJBKOJJIK
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static GPEAFMNAGCL DEEPIOLKBJO;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x699FDD0", Offset = "0x699E9D0", VA = "0x18699FDD0")]
				public static PlayerLoopSystem FJAEIBMBEIE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct CMMJIEOGGFP
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static GPEAFMNAGCL JPLJEIPJMBN;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x69992F0", Offset = "0x6997EF0", VA = "0x1869992F0")]
				public static PlayerLoopSystem FJAEIBMBEIE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct CDIEOKGAAOD
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static GPEAFMNAGCL JFPCIDLDKFN;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x6998650", Offset = "0x6997250", VA = "0x186998650")]
				public static PlayerLoopSystem FJAEIBMBEIE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct BFPAFPDIFEO
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static GPEAFMNAGCL ALFGCAOKIDL;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static GPEAFMNAGCL BGHBHFPCKAM;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static GPEAFMNAGCL KHDGBDJEPDG;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static GPEAFMNAGCL EELJGGANBPM;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x6997FA0", Offset = "0x6996BA0", VA = "0x186997FA0")]
				public static PlayerLoopSystem FJAEIBMBEIE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct FHILCOCLKMM
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static GPEAFMNAGCL KPNKFHADJCL;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x699F1E0", Offset = "0x699DDE0", VA = "0x18699F1E0")]
				public static PlayerLoopSystem FJAEIBMBEIE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct HJHNBCDGAIB
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static GPEAFMNAGCL ALFGCAOKIDL;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static GPEAFMNAGCL BGHBHFPCKAM;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static GPEAFMNAGCL KHDGBDJEPDG;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static GPEAFMNAGCL EELJGGANBPM;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x69A1F00", Offset = "0x69A0B00", VA = "0x1869A1F00")]
				public static PlayerLoopSystem FJAEIBMBEIE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct OMGOMONPIMB
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static GPEAFMNAGCL PCEPAMJEKGH;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x69AD440", Offset = "0x69AC040", VA = "0x1869AD440")]
				public static PlayerLoopSystem FJAEIBMBEIE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct JEPLBBKKOLP
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static GPEAFMNAGCL BHOBADDAIDF;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x69A47A0", Offset = "0x69A33A0", VA = "0x1869A47A0")]
				public static PlayerLoopSystem FJAEIBMBEIE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct CGDBKPEPODG
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static GPEAFMNAGCL LPKGNOCKBLA;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6998850", Offset = "0x6997450", VA = "0x186998850")]
				public static PlayerLoopSystem FJAEIBMBEIE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct OLMLHCIPMFH
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static GPEAFMNAGCL NCCAKELMBKP;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x69AB930", Offset = "0x69AA530", VA = "0x1869AB930")]
				public static PlayerLoopSystem FJAEIBMBEIE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct ACJIALPFNFK
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static GPEAFMNAGCL IFPPGHGBMBB;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x69969C0", Offset = "0x69955C0", VA = "0x1869969C0")]
				public static PlayerLoopSystem FJAEIBMBEIE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct AEMOOEMGPMO
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static GPEAFMNAGCL AAEBDAMNMGC;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x6996BC0", Offset = "0x69957C0", VA = "0x186996BC0")]
				public static PlayerLoopSystem FJAEIBMBEIE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum LLOFHKCBFNH : byte
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
			public struct LOGFCLAANIL
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class FKLFAABLEFA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public LLOFHKCBFNH updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
					public FKLFAABLEFA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x699F3E0", Offset = "0x699DFE0", VA = "0x18699F3E0")]
					internal void EEHDNGBPLOI()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static CGCFLAHJDPK<LLOFHKCBFNH> HHDIMEGAODE;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x69A9310", Offset = "0x69A7F10", VA = "0x1869A9310")]
				public static PlayerLoopSystem FJAEIBMBEIE(LLOFHKCBFNH JADJCEOMKFF)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct JBDDIADOOGC
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class KEOJFHEIDDF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public PLPJEPOEIOK.MLFGCIFPADH key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
					public KEOJFHEIDDF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x69A7030", Offset = "0x69A5C30", VA = "0x1869A7030")]
					internal void KHFCHNDLCCL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable CMHACKLOGMA;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x69A44F0", Offset = "0x69A30F0", VA = "0x1869A44F0")]
				public static PlayerLoopSystem AJPOPNOFOPL(PLPJEPOEIOK.MLFGCIFPADH CGGNJKGENIH)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct JLFIHLBAADA
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class MCCBILMODKD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public PLPJEPOEIOK.MLFGCIFPADH key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
					public MCCBILMODKD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x69A95D0", Offset = "0x69A81D0", VA = "0x1869A95D0")]
					internal void KHFCHNDLCCL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x69A55B0", Offset = "0x69A41B0", VA = "0x1869A55B0")]
				public static PlayerLoopSystem AJPOPNOFOPL(PLPJEPOEIOK.MLFGCIFPADH CGGNJKGENIH)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class BGBONEDFANA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public BGBONEDFANA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6998290", Offset = "0x6996E90", VA = "0x186998290")]
			internal List<PlayerLoopSystem> ACCAJELMOOG(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool IMPFGIKNNLD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool KGNBILKCEHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x699A2E0", Offset = "0x6998EE0", VA = "0x18699A2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x699A700", Offset = "0x6999300", VA = "0x18699A700")]
		private static void PFKPHDFPIBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69998E0", Offset = "0x69984E0", VA = "0x1869998E0")]
		private static void ENMEPJANANC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69996B0", Offset = "0x69982B0", VA = "0x1869996B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69994F0", Offset = "0x69980F0", VA = "0x1869994F0")]
		private static void AGJDDKDMBCC(PLPJEPOEIOK.MLFGCIFPADH CGGNJKGENIH, PlayerLoopSystem JCKHBDAAHGO, Type DGKHOAMKHGI, Type OJLOLEMEBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x699A320", Offset = "0x6998F20", VA = "0x18699A320")]
		private static void PEIIPBEJDKF(PlayerLoopSystem JCKHBDAAHGO, Type DGKHOAMKHGI, Type OJLOLEMEBCA, PHKIJDDIFDL ODDBIDAMMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x699A1B0", Offset = "0x6998DB0", VA = "0x18699A1B0")]
		private static void JKMIFMAPGPC(PlayerLoopSystem JCKHBDAAHGO, Type DGKHOAMKHGI, Type OJLOLEMEBCA, PlayerLoopSystem? EHJKPJBEMDP, PlayerLoopSystem? JJLONHJFKJC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class PLPJEPOEIOK
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum MLFGCIFPADH
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
	public class FKNCOOIJJOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly MLFGCIFPADH OBFBEAKMJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly AALGBICDABC FNFDFMFFIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long KEHDOADHIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long KKGCDJACBCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long MEHCILALBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int INKMLMDCAJE;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x699F700", Offset = "0x699E300", VA = "0x18699F700")]
		public FKNCOOIJJOH(MLFGCIFPADH ODKMGNKEADP, int PHLEGKEJOPD = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x699F460", Offset = "0x699E060", VA = "0x18699F460")]
		public void FAKALKIAOEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x699F6B0", Offset = "0x699E2B0", VA = "0x18699F6B0")]
		public void JKDPJFFLEPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x699F4D0", Offset = "0x699E0D0", VA = "0x18699F4D0")]
		public void HDDOABAIEBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static MLFGCIFPADH[] AILPDGADMDA;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static FKNCOOIJJOH[] LKEKKHJDADH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69B1380", Offset = "0x69AFF80", VA = "0x1869B1380")]
	public static FKNCOOIJJOH BNOHNFJDOGD(MLFGCIFPADH CGGNJKGENIH, int PHLEGKEJOPD = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69B1600", Offset = "0x69B0200", VA = "0x1869B1600")]
	public static FKNCOOIJJOH NEGLDHJNCPE(MLFGCIFPADH CGGNJKGENIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69B1560", Offset = "0x69B0160", VA = "0x1869B1560")]
	public static void MNMKFPNFEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class AALGBICDABC : FMMJFKBOPBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int FIBAFODIJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> ABEHGGMJFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double FJELBKILIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double HBEDOPKLFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double FDALOICKLIL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double JPDGCLAMDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69967F0", Offset = "0x69953F0", VA = "0x1869967F0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double FOMGEOGIOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1868A30", Offset = "0x1867630", VA = "0x181868A30", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double IBHLAECBOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1DB07D0", Offset = "0x1DAF3D0", VA = "0x181DB07D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x69968C0", Offset = "0x69954C0", VA = "0x1869968C0")]
	public AALGBICDABC(int MMNDGHABADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x69966D0", Offset = "0x69952D0", VA = "0x1869966D0", Slot = "7")]
	public void DMOCEIIJLMK(double NOPNOIONIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6996850", Offset = "0x6995450", VA = "0x186996850", Slot = "8")]
	public void KEPEANOIAHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class ILKCDNDPIBD : FMMJFKBOPBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long MAJIECOCCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double CPPEOOELDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double BCDJIMEKHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double LPNPGPAJEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double AHILKABGMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double FJELBKILIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double HBEDOPKLFLD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double FOMGEOGIOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x571AFB0", Offset = "0x5719BB0", VA = "0x18571AFB0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double IBHLAECBOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x571AFA0", Offset = "0x5719BA0", VA = "0x18571AFA0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double BCPHOKLCBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x571AAE0", Offset = "0x57196E0", VA = "0x18571AAE0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double JPDGCLAMDOF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x22B7F10", Offset = "0x22B6B10", VA = "0x1822B7F10", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69A2F60", Offset = "0x69A1B60", VA = "0x1869A2F60", Slot = "7")]
	public virtual void DMOCEIIJLMK(double NOPNOIONIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69A3080", Offset = "0x69A1C80", VA = "0x1869A3080", Slot = "8")]
	public virtual void KEPEANOIAHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6997B00", Offset = "0x6996700", VA = "0x186997B00")]
	public ILKCDNDPIBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class BEFNNMKEMKJ : ILKCDNDPIBD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double APDGIBEOLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x571AF80", Offset = "0x5719B80", VA = "0x18571AF80")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x571AAF0", Offset = "0x57196F0", VA = "0x18571AAF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6997990", Offset = "0x6996590", VA = "0x186997990", Slot = "7")]
	public override void DMOCEIIJLMK(double NOPNOIONIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6997AC0", Offset = "0x69966C0", VA = "0x186997AC0", Slot = "8")]
	public override void KEPEANOIAHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6997B00", Offset = "0x6996700", VA = "0x186997B00")]
	public BEFNNMKEMKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface FMMJFKBOPBP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double JPDGCLAMDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double FOMGEOGIOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double IBHLAECBOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class KCALDCOFJGM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface NGOONFHEEDI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool IIECLCNCOBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OJKNFCBJGIJ();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class JDCJEBBCEFO<TPromise, TMainThreadPromise> : NGOONFHEEDI where TPromise : BMPAGEIJFCN where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise MCDBEFNEFOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise OMPOEEBBNCB;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise PLDCFNKPHNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x3AF0D70", Offset = "0x3AEF970", VA = "0x183AF0D70")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IIECLCNCOBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3AF0DF0", Offset = "0x3AEF9F0", VA = "0x183AF0DF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7BF470", Offset = "0x7BE070", VA = "0x1807BF470")]
		protected JDCJEBBCEFO(TPromise MCDBEFNEFOP, TMainThreadPromise FOECGDMGDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0DD0", Offset = "0x3AEF9D0", VA = "0x183AF0DD0", Slot = "5")]
		public void OJKNFCBJGIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void AAPKBFICJCN(TPromise MCDBEFNEFOP);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class LLKFAMGOGNI<T> : JDCJEBBCEFO<LHJBMADJJFP<T>, MLOENCJLBPD<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3C31A60", Offset = "0x3C30660", VA = "0x183C31A60")]
		public LLKFAMGOGNI(LHJBMADJJFP<T> MCDBEFNEFOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3C31850", Offset = "0x3C30450", VA = "0x183C31850", Slot = "6")]
		protected override void AAPKBFICJCN(LHJBMADJJFP<T> MCDBEFNEFOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x37869D0", Offset = "0x37855D0", VA = "0x1837869D0")]
		[CompilerGenerated]
		private void GKMEBBPECHE(T MGHLKGJFBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3C31820", Offset = "0x3C30420", VA = "0x183C31820")]
		[CompilerGenerated]
		private void AACLKCIPHKE(string JDDBJGCFGMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class HEPMDANHEKG : NGOONFHEEDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action ODKDNEPMNIA;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IIECLCNCOBK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
		public HEPMDANHEKG(Action ODKDNEPMNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xC390F0", Offset = "0xC37CF0", VA = "0x180C390F0", Slot = "5")]
		public void OJKNFCBJGIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<NGOONFHEEDI> PCFABGNDHFM;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2853A50", Offset = "0x2852650", VA = "0x182853A50")]
	public static LHJBMADJJFP<T> AFEHGBIFDAJ<T>(this LHJBMADJJFP<T> MCDBEFNEFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x69A5E40", Offset = "0x69A4A40", VA = "0x1869A5E40")]
	public static void AFEHGBIFDAJ(Action ODKDNEPMNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2853AB0", Offset = "0x28526B0", VA = "0x182853AB0")]
	private static LHJBMADJJFP<T> IHECPJCDDBG<T>(LHJBMADJJFP<T> MCDBEFNEFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x69A60C0", Offset = "0x69A4CC0", VA = "0x1869A60C0")]
	private static void LDKGHAPNFMB(NGOONFHEEDI HNABCNJKLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x69A62D0", Offset = "0x69A4ED0", VA = "0x1869A62D0")]
	private static void OKPIPBGJAHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x69A5EE0", Offset = "0x69A4AE0", VA = "0x1869A5EE0")]
	private static void FCNNEFPBFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x69A5FE0", Offset = "0x69A4BE0", VA = "0x1869A5FE0")]
	private static void JCIKLGPGGLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class OMEKKIEENEO
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct ECHJOGAKEEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> HGMPLOMLBEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string MIKEHJBIAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode MPDCPMAGBJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool KPPDPLFKNAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x699D0F0", Offset = "0x699BCF0", VA = "0x18699D0F0")]
		public ECHJOGAKEEP(TaskCompletionSource<Scene> CCLGFPLJJNF, string MIKEHJBIAOG, LoadSceneMode MPDCPMAGBJA, bool KPPDPLFKNAG, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct LGJLBPGEPLH : IAsyncStateMachine
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
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private DBCLHGHLEMD<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x69A7770", Offset = "0x69A6370", VA = "0x1869A7770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69A8010", Offset = "0x69A6C10", VA = "0x1869A8010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct ILBEIBEKGJF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69A2BE0", Offset = "0x69A17E0", VA = "0x1869A2BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x69A2F00", Offset = "0x69A1B00", VA = "0x1869A2F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct NNDHPEPKDPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ECHJOGAKEEP <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x69AA660", Offset = "0x69A9260", VA = "0x1869AA660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x69AAA10", Offset = "0x69A9610", VA = "0x1869AAA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class IKGPCGKEFCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public MLOENCJLBPD<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public IKGPCGKEFCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x69A2B80", Offset = "0x69A1780", VA = "0x1869A2B80")]
		internal void EMGBLHGDIAD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct JKLKGMEODGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

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
		private IKGPCGKEFCG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x69A49A0", Offset = "0x69A35A0", VA = "0x1869A49A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x69A5540", Offset = "0x69A4140", VA = "0x1869A5540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct GEKCFNOPIHK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x699F850", Offset = "0x699E450", VA = "0x18699F850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x699FD60", Offset = "0x699E960", VA = "0x18699FD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct ECOPJDLCALA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x699D150", Offset = "0x699BD50", VA = "0x18699D150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x699DCA0", Offset = "0x699C8A0", VA = "0x18699DCA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class BBCKNPNEHMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public BBCKNPNEHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6997960", Offset = "0x6996560", VA = "0x186997960")]
		internal bool HEMAHJAKIOE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class BFDLKLINGKI : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private BILDDJDOJHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AIEMBHKGDME onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public BFDLKLINGKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6997F10", Offset = "0x6996B10", VA = "0x186997F10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6997B80", Offset = "0x6996780", VA = "0x186997B80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6997B30", Offset = "0x6996730", VA = "0x186997B30")]
		private void DPHAFEJOOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6997EC0", Offset = "0x6996AC0", VA = "0x186997EC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class OEGGMOKFMBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public MLOENCJLBPD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public OEGGMOKFMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x69AAE60", Offset = "0x69A9A60", VA = "0x1869AAE60")]
		internal bool FHPCGBGGBPL(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x69AAEE0", Offset = "0x69A9AE0", VA = "0x1869AAEE0")]
		internal void JEJAIFBKPEC(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class JLPMJFPKFAH : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private BILDDJDOJHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public MLOENCJLBPD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private OEGGMOKFMBE <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public JLPMJFPKFAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x69A56E0", Offset = "0x69A42E0", VA = "0x1869A56E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x69A5DF0", Offset = "0x69A49F0", VA = "0x1869A5DF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> LIMMJJECFAJ;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static BMPAGEIJFCN PMHOBFEDJGF;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation CFLBPAGEFEO;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BMPAGEIJFCN JLEPAPNKDFM;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string HIJJEBPCGPP;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority JBCPIKELLDI;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task FIMPMAGELNN;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> BDAJMNNLDDP;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<ECHJOGAKEEP> MANLEPOIJHK;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task JFDHEFCLOBD;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool KPMJIBJDLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x69ACA10", Offset = "0x69AB610", VA = "0x1869ACA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool CEMBPKEIJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x69AC850", Offset = "0x69AB450", VA = "0x1869AC850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool PJGAAMIJDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x69ACF50", Offset = "0x69ABB50", VA = "0x1869ACF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool GMINGNGKJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x69AC7C0", Offset = "0x69AB3C0", VA = "0x1869AC7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> PPBLBCEFELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x69ACFF0", Offset = "0x69ABBF0", VA = "0x1869ACFF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x69ABD70", Offset = "0x69AA970", VA = "0x1869ABD70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x69AC3F0", Offset = "0x69AAFF0", VA = "0x1869AC3F0")]
	[EMFKCIBAEDI(ENEGNGGCDCE.EnteredEditModeNextFrame, 0)]
	private static void FGMHCKGBDLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x69AC2A0", Offset = "0x69AAEA0", VA = "0x1869AC2A0")]
	[AsyncStateMachine(typeof(LGJLBPGEPLH))]
	public static Task<Scene> FELAPDICJOI(string MIKEHJBIAOG, LoadSceneMode MPDCPMAGBJA = LoadSceneMode.Single, bool KPPDPLFKNAG = false, [Optional] DBCLHGHLEMD<string>.OGCCDEKKEPE DAHNKFNBLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x69AC070", Offset = "0x69AAC70", VA = "0x1869AC070")]
	[AsyncStateMachine(typeof(ILBEIBEKGJF))]
	private static Task DOOAMGPIJIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x69ACC30", Offset = "0x69AB830", VA = "0x1869ACC30")]
	[AsyncStateMachine(typeof(NNDHPEPKDPP))]
	private static Task MMOPLLJDBLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x69AD100", Offset = "0x69ABD00", VA = "0x1869AD100")]
	[AsyncStateMachine(typeof(JKLKGMEODGB))]
	private static Task<Scene> PEDGHFFHFPA(string MIKEHJBIAOG, LoadSceneMode MPDCPMAGBJA, bool KPPDPLFKNAG, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x69ACD00", Offset = "0x69AB900", VA = "0x1869ACD00")]
	private static void NAENEIPHDGD(SceneInstance MCFGKAKKIKD, LoadSceneMode MPDCPMAGBJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x69ABE80", Offset = "0x69AAA80", VA = "0x1869ABE80")]
	private static void CPICILLNAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x69AC8F0", Offset = "0x69AB4F0", VA = "0x1869AC8F0")]
	[AsyncStateMachine(typeof(GEKCFNOPIHK))]
	private static Task<Scene> IPPACPBAGIE(string MIKEHJBIAOG, LoadSceneMode MPDCPMAGBJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x69ACE60", Offset = "0x69ABA60", VA = "0x1869ACE60")]
	private static bool NKKNMGAJFAA(string MIKEHJBIAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x69ABBC0", Offset = "0x69AA7C0", VA = "0x1869ABBC0")]
	[AsyncStateMachine(typeof(ECOPJDLCALA))]
	private static Task<Scene> CCOOBHJBNIJ(DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69AC120", Offset = "0x69AAD20", VA = "0x1869AC120")]
	public static LHJBMADJJFP<Scene> DPDAPFEDNID(string MIKEHJBIAOG, LoadSceneMode MPDCPMAGBJA = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x69AC4F0", Offset = "0x69AB0F0", VA = "0x1869AC4F0")]
	public static BMPAGEIJFCN GIFEMNOAOKA(string MIKEHJBIAOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x69ABB30", Offset = "0x69AA730", VA = "0x1869ABB30")]
	[IteratorStateMachine(typeof(BFDLKLINGKI))]
	private static IEnumerator<BILDDJDOJHA> AGNPJLIIAFO(string MIKEHJBIAOG, AIEMBHKGDME NBGJKFDOKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x69ABCD0", Offset = "0x69AA8D0", VA = "0x1869ABCD0")]
	[IteratorStateMachine(typeof(JLPMJFPKFAH))]
	private static IEnumerator<BILDDJDOJHA> CHJIPFIAGPG(string MIKEHJBIAOG, LoadSceneMode MPDCPMAGBJA, MLOENCJLBPD<Scene> NBGJKFDOKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x69ABF40", Offset = "0x69AAB40", VA = "0x1869ABF40")]
	public static bool DNLDADBFCPN([Out] string OHAELKJOFDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class HDAGKPACMAH
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x69A0200", Offset = "0x699EE00", VA = "0x1869A0200")]
	public static IDisposable BHBINODCBAA(this CLPNKHJDECL LAMCDJBBCDK, float IFCBAOPPOIK, Action<float> JDMLHEHAJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x69A0290", Offset = "0x699EE90", VA = "0x1869A0290")]
	public static IDisposable IMLHCNHMGAL(this CLPNKHJDECL LAMCDJBBCDK, Action<float> JDMLHEHAJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x69A0310", Offset = "0x699EF10", VA = "0x1869A0310")]
	public static IDisposable OPKIMGELPCP(this CLPNKHJDECL LAMCDJBBCDK, Action<float> JDMLHEHAJPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class AHPJBANFJEI
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6997680", Offset = "0x6996280", VA = "0x186997680")]
	public static IDisposable NBNHMFHJHOJ(this MonoBehaviour JFFMDFEGGAH, Action JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6997710", Offset = "0x6996310", VA = "0x186997710")]
	public static IDisposable NBNHMFHJHOJ(this MonoBehaviour JFFMDFEGGAH, Action<float> JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6996DC0", Offset = "0x69959C0", VA = "0x186996DC0")]
	public static IDisposable BBEBOIIGBMN(this MonoBehaviour JFFMDFEGGAH, Action JDMLHEHAJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6997130", Offset = "0x6995D30", VA = "0x186997130")]
	public static IDisposable FDKIGCMLLNO(this MonoBehaviour JFFMDFEGGAH, Action JDMLHEHAJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x69970B0", Offset = "0x6995CB0", VA = "0x1869970B0")]
	public static IDisposable FDKIGCMLLNO(this MonoBehaviour JFFMDFEGGAH, Action<float> JDMLHEHAJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6996EE0", Offset = "0x6995AE0", VA = "0x186996EE0")]
	public static IDisposable DBLOIDPJBJE(this MonoBehaviour JFFMDFEGGAH, Action JDMLHEHAJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6997440", Offset = "0x6996040", VA = "0x186997440")]
	public static IDisposable INLJLAMADIB(this MonoBehaviour JFFMDFEGGAH, Action JDMLHEHAJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6997560", Offset = "0x6996160", VA = "0x186997560")]
	public static IDisposable KPMODDPHCPL(this MonoBehaviour JFFMDFEGGAH, Action JDMLHEHAJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6997250", Offset = "0x6995E50", VA = "0x186997250")]
	public static IDisposable HHHACGEOLNF(this MonoBehaviour JFFMDFEGGAH, float IFCBAOPPOIK, Action<float> JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH, bool DOHNOMPOJBP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6997840", Offset = "0x6996440", VA = "0x186997840")]
	public static IDisposable PEFKJDHMNPE(this MonoBehaviour JFFMDFEGGAH, float IFCBAOPPOIK, Action<float> JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH, bool DOHNOMPOJBP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x69971B0", Offset = "0x6995DB0", VA = "0x1869971B0")]
	public static IDisposable FJDCDIGLCBK(this MonoBehaviour JFFMDFEGGAH, float IFCBAOPPOIK, Action<float> JDMLHEHAJPC, bool DOHNOMPOJBP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6996E40", Offset = "0x6995A40", VA = "0x186996E40")]
	public static IDisposable CAILIFNCNLH(this MonoBehaviour JFFMDFEGGAH, Action<float> JDMLHEHAJPC, bool DOHNOMPOJBP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x69974C0", Offset = "0x69960C0", VA = "0x1869974C0")]
	public static IDisposable KJJMCBJHCEP(this MonoBehaviour JFFMDFEGGAH, Action<float> JDMLHEHAJPC, bool DOHNOMPOJBP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6997300", Offset = "0x6995F00", VA = "0x186997300")]
	public static IDisposable IBLCOONIHDG(this MonoBehaviour JFFMDFEGGAH, Action<float> JDMLHEHAJPC, bool DOHNOMPOJBP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x69977A0", Offset = "0x69963A0", VA = "0x1869977A0")]
	public static IDisposable ODIBECCPPJH(this MonoBehaviour JFFMDFEGGAH, Action<float> JDMLHEHAJPC, bool DOHNOMPOJBP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6996F60", Offset = "0x6995B60", VA = "0x186996F60")]
	public static IDisposable ECFMCFPGPHG(this MonoBehaviour JFFMDFEGGAH, Action<float> JDMLHEHAJPC, bool DOHNOMPOJBP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x69975E0", Offset = "0x69961E0", VA = "0x1869975E0")]
	public static IDisposable MDDJFOECHOA(this MonoBehaviour JFFMDFEGGAH, Action<float> JDMLHEHAJPC, bool DOHNOMPOJBP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x69973A0", Offset = "0x6995FA0", VA = "0x1869973A0")]
	public static IDisposable IHLODCNHBGC(this MonoBehaviour JFFMDFEGGAH, Action<float> JDMLHEHAJPC, bool DOHNOMPOJBP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6997000", Offset = "0x6995C00", VA = "0x186997000")]
	public static IDisposable EJAJLDKDHFN(this MonoBehaviour JFFMDFEGGAH, float IFCBAOPPOIK, Action<float> JDMLHEHAJPC, bool DOHNOMPOJBP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class OCIEOJMGGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class BMBJMCOLEHJ : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private BILDDJDOJHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public PHLEKLAOHLE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private FKMKNBMOKAN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public BMBJMCOLEHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6998520", Offset = "0x6997120", VA = "0x186998520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6998600", Offset = "0x6997200", VA = "0x186998600", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class JCJOIGLOGIO : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private BILDDJDOJHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public PHLEKLAOHLE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private FKMKNBMOKAN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public JCJOIGLOGIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x69A4660", Offset = "0x69A3260", VA = "0x1869A4660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x69A4750", Offset = "0x69A3350", VA = "0x1869A4750", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x69AABD0", Offset = "0x69A97D0", VA = "0x1869AABD0")]
	public static DIJEKGOINOG NBNHMFHJHOJ(Action JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x69AADA0", Offset = "0x69A99A0", VA = "0x1869AADA0")]
	public static DIJEKGOINOG NBNHMFHJHOJ(Behaviour LAMCDJBBCDK, Action JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x69AAC80", Offset = "0x69A9880", VA = "0x1869AAC80")]
	public static DIJEKGOINOG NBNHMFHJHOJ(Behaviour LAMCDJBBCDK, Action<float> JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x69AAAB0", Offset = "0x69A96B0", VA = "0x1869AAAB0")]
	[IteratorStateMachine(typeof(BMBJMCOLEHJ))]
	private static IEnumerator<BILDDJDOJHA> AIHOONAFFHP(PHLEKLAOHLE ICCDPICDNBP, Action JDMLHEHAJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x69AAB40", Offset = "0x69A9740", VA = "0x1869AAB40")]
	[IteratorStateMachine(typeof(JCJOIGLOGIO))]
	private static IEnumerator<BILDDJDOJHA> AIHOONAFFHP(PHLEKLAOHLE ICCDPICDNBP, Action<float> JDMLHEHAJPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class GOFGKGBDKLE : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class ENMHDNGFDCH : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private BILDDJDOJHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GOFGKGBDKLE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public ENMHDNGFDCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x699EFF0", Offset = "0x699DBF0", VA = "0x18699EFF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x699F080", Offset = "0x699DC80", VA = "0x18699F080", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly PHLEKLAOHLE MGNOOJEPNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action BCDBBBHELPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool PIPDFCCALNO;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool LPKDIEFPNFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F80", Offset = "0x7B8B80", VA = "0x1807B9F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x69A00F0", Offset = "0x699ECF0", VA = "0x1869A00F0")]
	public GOFGKGBDKLE(PHLEKLAOHLE MGNOOJEPNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x699FFD0", Offset = "0x699EBD0", VA = "0x18699FFD0")]
	[IteratorStateMachine(typeof(ENMHDNGFDCH))]
	private IEnumerator<BILDDJDOJHA> MAHOBFMFBLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x69A0050", Offset = "0x699EC50", VA = "0x1869A0050", Slot = "4")]
	public void OnCompleted(Action HHNDKIHPKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200")]
	public void NHKNCEPIEBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class BGFHLOGCLGG
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x69983B0", Offset = "0x6996FB0", VA = "0x1869983B0")]
	public static GOFGKGBDKLE FLKOPGGPIPE(this PHLEKLAOHLE MGNOOJEPNHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class MGCHIPNPDBL
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class PHAAMCNLDED : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private BILDDJDOJHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public KCHIOJOHABO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public PHAAMCNLDED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x69AE900", Offset = "0x69AD500", VA = "0x1869AE900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x69AE980", Offset = "0x69AD580", VA = "0x1869AE980", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x69A9C20", Offset = "0x69A8820", VA = "0x1869A9C20")]
	public static DIJEKGOINOG NBNHMFHJHOJ(float IFCBAOPPOIK, Action<float> JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH, bool DOHNOMPOJBP = true, [Optional] HNODCEEKICB EOPMFJFFBAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x69A9D20", Offset = "0x69A8920", VA = "0x1869A9D20")]
	public static DIJEKGOINOG NBNHMFHJHOJ(MonoBehaviour JFFMDFEGGAH, float IFCBAOPPOIK, Action<float> JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH, bool DOHNOMPOJBP = true, [Optional] HNODCEEKICB EOPMFJFFBAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x69A9900", Offset = "0x69A8500", VA = "0x1869A9900")]
	public static DIJEKGOINOG BDFHEICMKCD(MonoBehaviour JFFMDFEGGAH, float IFCBAOPPOIK, Action<float> JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH, bool DOHNOMPOJBP = true, [Optional] HNODCEEKICB EOPMFJFFBAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x69A9B10", Offset = "0x69A8710", VA = "0x1869A9B10")]
	public static DIJEKGOINOG NAOAJIMGOBJ(CLPNKHJDECL LAMCDJBBCDK, float IFCBAOPPOIK, Action<float> JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH, bool DOHNOMPOJBP = true, [Optional] HNODCEEKICB EOPMFJFFBAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x69A9840", Offset = "0x69A8440", VA = "0x1869A9840")]
	private static IEnumerator<BILDDJDOJHA> AIHOONAFFHP(PIKEFAOPMHF BKDGJJADJAE, float IFCBAOPPOIK, PHLEKLAOHLE ICCDPICDNBP, Action<float> JDMLHEHAJPC, bool DOHNOMPOJBP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x69A9AB0", Offset = "0x69A86B0", VA = "0x1869A9AB0")]
	private static IEnumerator<BILDDJDOJHA> LINKALOGDLM(PIKEFAOPMHF BKDGJJADJAE, float IFCBAOPPOIK, PHLEKLAOHLE ICCDPICDNBP, Action<float> JDMLHEHAJPC, bool DOHNOMPOJBP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x69A9A20", Offset = "0x69A8620", VA = "0x1869A9A20")]
	[IteratorStateMachine(typeof(PHAAMCNLDED))]
	private static IEnumerator<BILDDJDOJHA> HKFALJCEEOD(KCHIOJOHABO HBJIIBIAFLH, float IFCBAOPPOIK, PHLEKLAOHLE ICCDPICDNBP, Action<float> JDMLHEHAJPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class HEEAMMNFGPK
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class IGPFKBAHOLM : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private BILDDJDOJHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public PHLEKLAOHLE queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public IGPFKBAHOLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x69A21F0", Offset = "0x69A0DF0", VA = "0x1869A21F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x69A22B0", Offset = "0x69A0EB0", VA = "0x1869A22B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x69A04B0", Offset = "0x699F0B0", VA = "0x1869A04B0")]
	[IteratorStateMachine(typeof(IGPFKBAHOLM))]
	private static IEnumerator<BILDDJDOJHA> GAOBAKCMCEH(PHLEKLAOHLE MGNOOJEPNHH, Func<bool> HPAFCMIPNAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x69A0390", Offset = "0x699EF90", VA = "0x1869A0390")]
	public static DIJEKGOINOG DNGLCGHBIMG(this MonoBehaviour JFFMDFEGGAH, Func<bool> HPAFCMIPNAM, PHLEKLAOHLE MGNOOJEPNHH = PHLEKLAOHLE.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class KCECGOEPHLN
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class EMHHAAHFFEA : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private BILDDJDOJHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public PHLEKLAOHLE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public EMHHAAHFFEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x699E5E0", Offset = "0x699D1E0", VA = "0x18699E5E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x699E650", Offset = "0x699D250", VA = "0x18699E650", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class KONNDECKHFB : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private BILDDJDOJHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public PHLEKLAOHLE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private BILDDJDOJHA <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public KONNDECKHFB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x69A7270", Offset = "0x69A5E70", VA = "0x1869A7270", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x69A7300", Offset = "0x69A5F00", VA = "0x1869A7300", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x69A6C70", Offset = "0x69A5870", VA = "0x1869A6C70")]
	[IteratorStateMachine(typeof(EMHHAAHFFEA))]
	private static IEnumerator<BILDDJDOJHA> MAHOBFMFBLI(float OPCGAFBMLPL, PHLEKLAOHLE ICCDPICDNBP, Action HMNHGLIGALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x69A6DD0", Offset = "0x69A59D0", VA = "0x1869A6DD0")]
	[IteratorStateMachine(typeof(KONNDECKHFB))]
	private static IEnumerator<BILDDJDOJHA> MMILDPKLFNF(float OPCGAFBMLPL, PHLEKLAOHLE ICCDPICDNBP, Action HMNHGLIGALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x69A6740", Offset = "0x69A5340", VA = "0x1869A6740")]
	public static IDisposable DIPIHLGJHPO(this MonoBehaviour JFFMDFEGGAH, float OPCGAFBMLPL, Action HMNHGLIGALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x69A6D10", Offset = "0x69A5910", VA = "0x1869A6D10")]
	public static DIJEKGOINOG MJNLOCPFGDK(this MonoBehaviour JFFMDFEGGAH, float OPCGAFBMLPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x69A6860", Offset = "0x69A5460", VA = "0x1869A6860")]
	public static DIJEKGOINOG DIPIHLGJHPO(this MonoBehaviour JFFMDFEGGAH, float OPCGAFBMLPL, PHLEKLAOHLE ICCDPICDNBP, Action HMNHGLIGALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x69A7010", Offset = "0x69A5C10", VA = "0x1869A7010")]
	public static DIJEKGOINOG PPABBDKHGOE(this MonoBehaviour JFFMDFEGGAH, Action HMNHGLIGALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x69A6640", Offset = "0x69A5240", VA = "0x1869A6640")]
	public static DIJEKGOINOG BMKADDMHGPP(this MonoBehaviour JFFMDFEGGAH, Action HMNHGLIGALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x69A6B90", Offset = "0x69A5790", VA = "0x1869A6B90")]
	public static DIJEKGOINOG JEPCOLGFDOI(this MonoBehaviour JFFMDFEGGAH, Action HMNHGLIGALO, [Optional] HNODCEEKICB EOPMFJFFBAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x69A6A90", Offset = "0x69A5690", VA = "0x1869A6A90")]
	public static DIJEKGOINOG HOOICLDMNFA(this MonoBehaviour JFFMDFEGGAH, Action HMNHGLIGALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x69A6A60", Offset = "0x69A5660", VA = "0x1869A6A60")]
	public static DIJEKGOINOG FNEILBODEPG(this MonoBehaviour JFFMDFEGGAH, Action HMNHGLIGALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x69A6F40", Offset = "0x69A5B40", VA = "0x1869A6F40")]
	private static DIJEKGOINOG PHGHMHHGILP(MonoBehaviour JFFMDFEGGAH, PHLEKLAOHLE MGNOOJEPNHH, Action HMNHGLIGALO, [Optional] HNODCEEKICB EOPMFJFFBAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x69A6670", Offset = "0x69A5270", VA = "0x1869A6670")]
	public static DIJEKGOINOG DAFIIEJDLFD(this MonoBehaviour JFFMDFEGGAH, float EINLKPDFDAO, Action HMNHGLIGALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x69A6990", Offset = "0x69A5590", VA = "0x1869A6990")]
	public static DIJEKGOINOG EMMEBEKGHPC(this MonoBehaviour JFFMDFEGGAH, float EINLKPDFDAO, Action HMNHGLIGALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x69A6AC0", Offset = "0x69A56C0", VA = "0x1869A6AC0")]
	public static DIJEKGOINOG IIEHIPJFNDE(this MonoBehaviour JFFMDFEGGAH, float EINLKPDFDAO, Action HMNHGLIGALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x69A6E70", Offset = "0x69A5A70", VA = "0x1869A6E70")]
	public static DIJEKGOINOG OOOPENCIEKA(this MonoBehaviour JFFMDFEGGAH, float EINLKPDFDAO, Action HMNHGLIGALO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class EMPKEHKAIIJ : BNBKGEJEFMF, IEnumerable<BNBKGEJEFMF>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<BNBKGEJEFMF> OHEAPCMNHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool BENEILANOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action GKDDPGICGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool AGMMHOHCKGC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CCIABAPGACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x699EA50", Offset = "0x699D650", VA = "0x18699EA50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action CLHGAPIKCNF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x699E6A0", Offset = "0x699D2A0", VA = "0x18699E6A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x699EEB0", Offset = "0x699DAB0", VA = "0x18699EEB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x699EF50", Offset = "0x699DB50", VA = "0x18699EF50")]
	public EMPKEHKAIIJ([Optional] Action GKDDPGICGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x699E740", Offset = "0x699D340", VA = "0x18699E740")]
	public void BGJHDHHBMPP(BNBKGEJEFMF OJMEALMICOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x699E870", Offset = "0x699D470", VA = "0x18699E870")]
	private void BPNHLFPGMOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x699EEA0", Offset = "0x699DAA0", VA = "0x18699EEA0", Slot = "7")]
	public bool MAPAAEPICML(bool FAAGKOCIKOI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x699EB90", Offset = "0x699D790", VA = "0x18699EB90", Slot = "8")]
	public bool MAPAAEPICML(Action ODKDNEPMNIA, bool FAAGKOCIKOI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x699E9D0", Offset = "0x699D5D0", VA = "0x18699E9D0", Slot = "9")]
	public IEnumerator<BNBKGEJEFMF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x699E9D0", Offset = "0x699D5D0", VA = "0x18699E9D0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class IJFAPAKKHBB : OEMCPMLNNLL
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class BLOBCNOGCHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public IJFAPAKKHBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public BLOBCNOGCHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x69984F0", Offset = "0x69970F0", VA = "0x1869984F0")]
		internal void HPBAMDGDHGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class HBFCOFAOKJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public IJFAPAKKHBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public HBFCOFAOKJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x69984F0", Offset = "0x69970F0", VA = "0x1869984F0")]
		internal void OLMLIPIGOCG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float DPGLCPKHBPF;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x69A2A80", Offset = "0x69A1680", VA = "0x1869A2A80")]
	public IJFAPAKKHBB(Behaviour LAMCDJBBCDK, float DPGLCPKHBPF, [Optional] Action GKDDPGICGFF, [Optional] HNODCEEKICB EOPMFJFFBAP, [Optional] PIKEFAOPMHF BKDGJJADJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x69A2860", Offset = "0x69A1460", VA = "0x1869A2860", Slot = "9")]
	protected override bool CLMHLMHHPPC(Action ODKDNEPMNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x69A2970", Offset = "0x69A1570", VA = "0x1869A2970", Slot = "10")]
	protected override bool DPFMGOCFCOB(Action ODKDNEPMNIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface BNBKGEJEFMF
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool CCIABAPGACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CLHGAPIKCNF;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MAPAAEPICML(bool FAAGKOCIKOI = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MAPAAEPICML(Action ODKDNEPMNIA, bool FAAGKOCIKOI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class OEMCPMLNNLL : BNBKGEJEFMF
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class OGCCPAOOHMF : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private BILDDJDOJHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public OEMCPMLNNLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public OGCCPAOOHMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x69AB810", Offset = "0x69AA410", VA = "0x1869AB810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x69AB8E0", Offset = "0x69AA4E0", VA = "0x1869AB8E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour LAMCDJBBCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action GKDDPGICGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private LPNPPPGEAEB JPDAOHPOHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly HNODCEEKICB EOPMFJFFBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly PIKEFAOPMHF BKDGJJADJAE;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool CCIABAPGACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xFA34A0", Offset = "0xFA20A0", VA = "0x180FA34A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action CLHGAPIKCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x69AB160", Offset = "0x69A9D60", VA = "0x1869AB160", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x69AB670", Offset = "0x69AA270", VA = "0x1869AB670", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x69AB710", Offset = "0x69AA310", VA = "0x1869AB710")]
	protected OEMCPMLNNLL(Behaviour LAMCDJBBCDK, [Optional] Action GKDDPGICGFF, [Optional] HNODCEEKICB EOPMFJFFBAP, [Optional] PIKEFAOPMHF BKDGJJADJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x69AB370", Offset = "0x69A9F70", VA = "0x1869AB370", Slot = "7")]
	public bool MAPAAEPICML(bool FAAGKOCIKOI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x69AB3D0", Offset = "0x69A9FD0", VA = "0x1869AB3D0", Slot = "8")]
	public bool MAPAAEPICML(Action ODKDNEPMNIA, bool FAAGKOCIKOI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool CLMHLMHHPPC(Action ODKDNEPMNIA);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool DPFMGOCFCOB(Action ODKDNEPMNIA);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x69AB280", Offset = "0x69A9E80", VA = "0x1869AB280")]
	protected void IGJHGHBHALI(Action ODKDNEPMNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x69AB430", Offset = "0x69AA030", VA = "0x1869AB430")]
	protected BMPAGEIJFCN MGJAGNAIIMD(float FBOJEGKGGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x69AB200", Offset = "0x69A9E00", VA = "0x1869AB200")]
	private void DJBMAMOFMIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x69AB2E0", Offset = "0x69A9EE0", VA = "0x1869AB2E0")]
	[IteratorStateMachine(typeof(OGCCPAOOHMF))]
	private IEnumerator<BILDDJDOJHA> JGPNKFDIKPO(float FBOJEGKGGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x69AB2A0", Offset = "0x69A9EA0", VA = "0x1869AB2A0")]
	[CompilerGenerated]
	private void IHACBEHJFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class LCLFCPBCAKP : OEMCPMLNNLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float LBABNIJDPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int ONGAPPLCKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float MFEKIIGIDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] PAEALBEAKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int FAFDIIGGIMH;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x69A75D0", Offset = "0x69A61D0", VA = "0x1869A75D0")]
	public LCLFCPBCAKP(Behaviour LAMCDJBBCDK, float PJAPOLKNCDK, int ONGAPPLCKOG, [Optional] Action GKDDPGICGFF, float MFEKIIGIDJE = 0f, [Optional] HNODCEEKICB EOPMFJFFBAP, [Optional] PIKEFAOPMHF BKDGJJADJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "9")]
	protected override bool CLMHLMHHPPC(Action ODKDNEPMNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x69A7350", Offset = "0x69A5F50", VA = "0x1869A7350", Slot = "10")]
	protected override bool DPFMGOCFCOB(Action ODKDNEPMNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x69A7550", Offset = "0x69A6150", VA = "0x1869A7550")]
	private void FICDOJBFIEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class MLEAIJOOABF : OEMCPMLNNLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float DPGLCPKHBPF;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x69A2A80", Offset = "0x69A1680", VA = "0x1869A2A80")]
	public MLEAIJOOABF(Behaviour LAMCDJBBCDK, float DPGLCPKHBPF, [Optional] Action GKDDPGICGFF, [Optional] HNODCEEKICB EOPMFJFFBAP, [Optional] PIKEFAOPMHF BKDGJJADJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "9")]
	protected override bool CLMHLMHHPPC(Action ODKDNEPMNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x69AA5A0", Offset = "0x69A91A0", VA = "0x1869AA5A0", Slot = "10")]
	protected override bool DPFMGOCFCOB(Action ODKDNEPMNIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class MKAMINPEHEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class DHIEPNBNOJP : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private BILDDJDOJHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public DHIEPNBNOJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x699D030", Offset = "0x699BC30", VA = "0x18699D030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x699D0A0", Offset = "0x699BCA0", VA = "0x18699D0A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private DIJEKGOINOG JDBBEDDPFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private CLPNKHJDECL LAMCDJBBCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> DDKDCMIJMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private PHLEKLAOHLE MGNOOJEPNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float AEPGDLBKMHG;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x69AA3C0", Offset = "0x69A8FC0", VA = "0x1869AA3C0")]
	public MKAMINPEHEF(CLPNKHJDECL LAMCDJBBCDK, float IFCBAOPPOIK, Action<float> JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x69A9E30", Offset = "0x69A8A30", VA = "0x1869A9E30")]
	private void AKOBFPGPGFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x69A9FD0", Offset = "0x69A8BD0", VA = "0x1869A9FD0")]
	private void ALBOJDAKBHB(string JDDBJGCFGMI, Action ECDCDPFCHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x69AA190", Offset = "0x69A8D90", VA = "0x1869AA190")]
	[IteratorStateMachine(typeof(DHIEPNBNOJP))]
	private IEnumerator<BILDDJDOJHA> KBGFMJEMJPE(Action ECDCDPFCHDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x69AA130", Offset = "0x69A8D30", VA = "0x1869AA130", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x69AA210", Offset = "0x69A8E10", VA = "0x1869AA210")]
	[CompilerGenerated]
	private void OKCAEIKGKAO(string PKPFNALFKGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class LHPGJHLECHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class PBAIADIGFIJ : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private BILDDJDOJHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public PBAIADIGFIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x699D030", Offset = "0x699BC30", VA = "0x18699D030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x69AD640", Offset = "0x69AC240", VA = "0x1869AD640", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private DIJEKGOINOG JDBBEDDPFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour JFFMDFEGGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action JDMLHEHAJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> DDKDCMIJMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private PHLEKLAOHLE MGNOOJEPNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float AEPGDLBKMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool DOHNOMPOJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly HNODCEEKICB EOPMFJFFBAP;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x69A9120", Offset = "0x69A7D20", VA = "0x1869A9120")]
	public LHPGJHLECHC(MonoBehaviour JFFMDFEGGAH, Action JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH, [Optional] HNODCEEKICB EOPMFJFFBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x69A8EE0", Offset = "0x69A7AE0", VA = "0x1869A8EE0")]
	public LHPGJHLECHC(MonoBehaviour JFFMDFEGGAH, Action<float> JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH, [Optional] HNODCEEKICB EOPMFJFFBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x69A8C90", Offset = "0x69A7890", VA = "0x1869A8C90")]
	public LHPGJHLECHC(MonoBehaviour JFFMDFEGGAH, float IFCBAOPPOIK, Action<float> JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH, bool DOHNOMPOJBP = true, [Optional] HNODCEEKICB EOPMFJFFBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x19F3AD0", Offset = "0x19F26D0", VA = "0x1819F3AD0")]
	private LHPGJHLECHC(HNODCEEKICB EOPMFJFFBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x69A8840", Offset = "0x69A7440", VA = "0x1869A8840")]
	internal static LHPGJHLECHC MGAPDLLILNO(MonoBehaviour JFFMDFEGGAH, float IFCBAOPPOIK, Action<float> JDMLHEHAJPC, PHLEKLAOHLE MGNOOJEPNHH, bool DOHNOMPOJBP = true, [Optional] HNODCEEKICB EOPMFJFFBAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x69A8970", Offset = "0x69A7570", VA = "0x1869A8970")]
	private void NBNHMFHJHOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x69A8AE0", Offset = "0x69A76E0", VA = "0x1869A8AE0")]
	private void OIJPMHDMJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x69A8080", Offset = "0x69A6C80", VA = "0x1869A8080")]
	private void AKOBFPGPGFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x69A84E0", Offset = "0x69A70E0", VA = "0x1869A84E0")]
	private void IBFGOHGEELO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x69A8230", Offset = "0x69A6E30", VA = "0x1869A8230")]
	private void ALBOJDAKBHB(string JDDBJGCFGMI, Action ECDCDPFCHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x69A8730", Offset = "0x69A7330", VA = "0x1869A8730")]
	[IteratorStateMachine(typeof(PBAIADIGFIJ))]
	private IEnumerator<BILDDJDOJHA> KBGFMJEMJPE(Action ECDCDPFCHDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x69A8360", Offset = "0x69A6F60", VA = "0x1869A8360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x69A8450", Offset = "0x69A7050", VA = "0x1869A8450")]
	[CompilerGenerated]
	private void HAFCOKGIGGM(string PKPFNALFKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x69A87B0", Offset = "0x69A73B0", VA = "0x1869A87B0")]
	[CompilerGenerated]
	private void LJDKLOJGAGA(string PKPFNALFKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x69A86A0", Offset = "0x69A72A0", VA = "0x1869A86A0")]
	[CompilerGenerated]
	private void IOFEIIKJLOB(string PKPFNALFKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x69A83C0", Offset = "0x69A6FC0", VA = "0x1869A83C0")]
	[CompilerGenerated]
	private void FGPDIFFBNDK(string PKPFNALFKGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum OLFMPFFAIBA : byte
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
internal sealed class PCLAHAPPKDI : PIKEFAOPMHF
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float DCEPCIGDMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x69ADB80", Offset = "0x69AC780", VA = "0x1869ADB80", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float HMEIHLDBNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x69ADC00", Offset = "0x69AC800", VA = "0x1869ADC00", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double LJJLEJELBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x69ADB60", Offset = "0x69AC760", VA = "0x1869ADB60", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x69ADB90", Offset = "0x69AC790", VA = "0x1869ADB90")]
	[JDFNDIEGGDI(COFBNFOEGIB.None)]
	private static void NOGKHDMNIHD(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	[Preserve]
	internal PCLAHAPPKDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface GMHEEOKANHK
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDEIHNGMICA(string MPGNMPAPHDB);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJPPPEBPHFM();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface CGAPKOMEBAD
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string PEJAGGFBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool INFBEJKIOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JAEFJLLMPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class PBKFBGFJJMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public PKMBCMMLIID IKJABLIMFMP;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int KGAKPAMIIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7AF180", Offset = "0x7ADD80", VA = "0x1807AF180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9610", Offset = "0x7B8210", VA = "0x1807B9610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x69ADA00", Offset = "0x69AC600", VA = "0x1869ADA00")]
	public static BILDDJDOJHA PFALAFLJGHG(IEnumerator<BILDDJDOJHA> LFBOMHPGNEN, NFHCOFLDLAI CCAJJKDGJLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x69AD940", Offset = "0x69AC540", VA = "0x1869AD940")]
	public BILDDJDOJHA PFALAFLJGHG(NFHCOFLDLAI[] ONPEKEGNINM, IEnumerator<BILDDJDOJHA>[] MGDCDNIEDLD, BILDDJDOJHA[] MOKKNFHELPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x69AD690", Offset = "0x69AC290", VA = "0x1869AD690")]
	public void ECMMIPIJCLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x69AD800", Offset = "0x69AC400", VA = "0x1869AD800")]
	public void MEKIPKLALIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x69AD6C0", Offset = "0x69AC2C0", VA = "0x1869AD6C0")]
	public void KAKEIBHNFNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x69AD690", Offset = "0x69AC290", VA = "0x1869AD690")]
	public void NBNGJGKDAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public PBKFBGFJJMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class PKMBCMMLIID
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct FCIGMGDPNPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public PBKFBGFJJMP MCEAIEHDCEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public CLPNKHJDECL OMOMHHCDGKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public NFHCOFLDLAI LMEDJOOMECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<BILDDJDOJHA> LFMKDGBONNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public BILDDJDOJHA JOLLIBNPPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public OLFMPFFAIBA CPGNCPMLEFB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct CBPIKNMLLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public PHLEKLAOHLE BGANAGFOABE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<FCIGMGDPNPO> CPJOBLOMEIM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class EENNFODJOFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public NFHCOFLDLAI promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public PKMBCMMLIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public CLPNKHJDECL context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public PBKFBGFJJMP routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public OLFMPFFAIBA coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public BILDDJDOJHA currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<BILDDJDOJHA> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public EENNFODJOFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x699DE30", Offset = "0x699CA30", VA = "0x18699DE30")]
		internal void GPHCHCDDAPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class GEAIFNLNDKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public PBKFBGFJJMP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public PKMBCMMLIID <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public GEAIFNLNDKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x699F810", Offset = "0x699E410", VA = "0x18699F810")]
		internal void JIOAEEKJBBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class JBHBMDOKOKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public PBKFBGFJJMP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public PKMBCMMLIID <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public JBHBMDOKOKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x69A4620", Offset = "0x69A3220", VA = "0x1869A4620")]
		internal void GDIGDBMICIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class NPMGEDACPDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public PBKFBGFJJMP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public PKMBCMMLIID <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public NPMGEDACPDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x69AAA70", Offset = "0x69A9670", VA = "0x1869AAA70")]
		internal void PIAELNCFGKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const OLFMPFFAIBA HOKGEIDPIJL = OLFMPFFAIBA.Cancelled | OLFMPFFAIBA.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly PHLEKLAOHLE MGNOOJEPNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] KLFKKNGICFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<OLFMPFFAIBA> BHPCBEKFMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> JEIPMPNLKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> FJLFKPMMICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> EGCCFGAMMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> JBDCHHHGAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> IPBELODHAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> DBEPIBKKCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private PBKFBGFJJMP[] GHLCBLNNMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NFHCOFLDLAI[] ONPEKEGNINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private CLPNKHJDECL[] BEMOABBECPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<BILDDJDOJHA>[] CCAKDJOAELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private BILDDJDOJHA[] AEDCGPNPIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int LKGIOJLJAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int LLHBDBHCNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int NFKAENFANAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float MPIOHJHDMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IJEECEBBGOE GGEMKIKJEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle NKFCGPDHKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<PBKFBGFJJMP> NJIHLNFOLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool OFFNEGDNFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> JLDIMLKJIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> HKODLLEGNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool PFCPLKCDMOD;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public CBPIKNMLLLO[] HHEJCCLIJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9A75B0", Offset = "0x9A61B0", VA = "0x1809A75B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x69B0A00", Offset = "0x69AF600", VA = "0x1869B0A00")]
	private static int NIMMCHHEEOP(PHLEKLAOHLE MGNOOJEPNHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x69B0D30", Offset = "0x69AF930", VA = "0x1869B0D30")]
	public PKMBCMMLIID(PHLEKLAOHLE MGNOOJEPNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x69AFAA0", Offset = "0x69AE6A0", VA = "0x1869AFAA0")]
	private void EEOHGKFNKHD(int OFMOLAPAEON, int ADKJFKDHEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x69AF860", Offset = "0x69AE460", VA = "0x1869AF860")]
	public void DCDNAFJCFBF(CLPNKHJDECL LAMCDJBBCDK, BILDDJDOJHA KPKNCIKEHKO, IEnumerator<BILDDJDOJHA> LFBOMHPGNEN, NFHCOFLDLAI CCAJJKDGJLD, [Optional] PBKFBGFJJMP GABDNEKMPFJ, OLFMPFFAIBA JKBDGFJFPOP = OLFMPFFAIBA.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x69AFC80", Offset = "0x69AE880", VA = "0x1869AFC80")]
	public void EKPNNHMJOBE(IEnumerable<FCIGMGDPNPO> EHDDACHFLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x69B0380", Offset = "0x69AEF80", VA = "0x1869B0380")]
	private FCIGMGDPNPO JOELOHLJLKG(int FGOIAENNBOL)
	{
		return default(FCIGMGDPNPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x69AF4F0", Offset = "0x69AE0F0", VA = "0x1869AF4F0")]
	private void BJLFFIHAJNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2951BE0", Offset = "0x29507E0", VA = "0x182951BE0")]
	private static void KKDLMIOPJDC<T>(int FGOIAENNBOL, T[] IKEEHJHFHEF, int JKNAAACFMKJ, [Optional] T ENKCHLOPLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2951C30", Offset = "0x2950830", VA = "0x182951C30")]
	private static void KKDLMIOPJDC<T>(int FGOIAENNBOL, NativeArray<T> IKEEHJHFHEF, int JKNAAACFMKJ, [Optional] T ENKCHLOPLJH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x69AE9D0", Offset = "0x69AD5D0", VA = "0x1869AE9D0")]
	private void ACLABDBPMIG(IEnumerable<FCIGMGDPNPO> EHDDACHFLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x69AF9E0", Offset = "0x69AE5E0", VA = "0x1869AF9E0")]
	private void DJKNIIOFPPL(FCIGMGDPNPO BNNDMBICGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x69B0120", Offset = "0x69AED20", VA = "0x1869B0120")]
	private KHDIGJDCEHK JLFDMGIMGNE(int CCPFDMPGPFP)
	{
		return default(KHDIGJDCEHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x69B0B30", Offset = "0x69AF730", VA = "0x1869B0B30")]
	public void PDGHMGPKPNI(float DBFOFDCBJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x69B0850", Offset = "0x69AF450", VA = "0x1869B0850")]
	private void MDDNDBDECCL(Action PKCAMDKHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x69AED70", Offset = "0x69AD970", VA = "0x1869AED70")]
	private void AJOEEHLEKIC(Action PKCAMDKHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x69AEDF0", Offset = "0x69AD9F0", VA = "0x1869AEDF0")]
	public void ALEANIOKNAF(float DBFOFDCBJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x69B0A30", Offset = "0x69AF630", VA = "0x1869B0A30")]
	public void PCCPCKIFLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x69B08D0", Offset = "0x69AF4D0", VA = "0x1869B08D0")]
	public void NBNGJGKDAIJ(PBKFBGFJJMP HBJIIBIAFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x69AFFF0", Offset = "0x69AEBF0", VA = "0x1869AFFF0")]
	public void JGHGKFCBINN(PBKFBGFJJMP HBJIIBIAFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x69AFEC0", Offset = "0x69AEAC0", VA = "0x1869AFEC0")]
	public void HGLFJCPGBGO(PBKFBGFJJMP HBJIIBIAFLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class FDBPEBADAAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly FDBPEBADAAO ONLHDLNPPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action MGMKJDDACCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool DLLGBEPLAAB;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public FDBPEBADAAO(Action MGMKJDDACCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x61CDF60", Offset = "0x61CCB60", VA = "0x1861CDF60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface AOEGAMFLDDA<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T BLAEOCKJGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable KPICCNNGPAH(UnityEngine.Object LAMCDJBBCDK, Action<T> ENFBEFAMPMH);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface HLCHHJGFDOE<T> : AOEGAMFLDDA<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T BLAEOCKJGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class CBAGLAGPIPP<T> : HLCHHJGFDOE<T>, AOEGAMFLDDA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class LDMOJJHLKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public CBAGLAGPIPP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public AMCCBMCJLBI<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LDMOJJHLKNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3C03900", Offset = "0x3C02500", VA = "0x183C03900")]
		internal void BJIELFKKHNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject FDAFAODCIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<AMCCBMCJLBI<UnityEngine.Object, Action<T>>> PMJPEOIFPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T GBFLBDOOAEM;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T BLAEOCKJGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x82E0E0", Offset = "0x82CCE0", VA = "0x18082E0E0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4ADF010", Offset = "0x4ADDC10", VA = "0x184ADF010", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4ADF090", Offset = "0x4ADDC90", VA = "0x184ADF090")]
	private static bool JGOGBABNAMG(T PKCAMDKHNLN, T ECIMPLOCMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4ADFB10", Offset = "0x4ADE710", VA = "0x184ADFB10")]
	public CBAGLAGPIPP(T BAOCEAPKEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4ADF980", Offset = "0x4ADE580", VA = "0x184ADF980", Slot = "6")]
	public IDisposable KPICCNNGPAH(UnityEngine.Object LAMCDJBBCDK, Action<T> ENFBEFAMPMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4ADF190", Offset = "0x4ADDD90", VA = "0x184ADF190")]
	private void KAEBOMPPCGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class EDFLMPNABLK : LIGNONDFJJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly HNODCEEKICB EOPMFJFFBAP;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x699DDC0", Offset = "0x699C9C0", VA = "0x18699DDC0")]
	[JDFNDIEGGDI(COFBNFOEGIB.None)]
	private static void NOGKHDMNIHD(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	[Preserve]
	internal EDFLMPNABLK([NNEMKPMNJAE(null)] HNODCEEKICB EOPMFJFFBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x699DD10", Offset = "0x699C910", VA = "0x18699DD10", Slot = "4")]
	public IDisposable FJDCDIGLCBK(float IFCBAOPPOIK, Action<float> NLOLPKLGIBB, bool DOHNOMPOJBP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class PFBIGNIPMCM : INMKHDLHKNL, HNODCEEKICB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private PKMBCMMLIID[] KOIANEJNKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private GMHEEOKANHK EGDAGEMNKKI;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x69AE7D0", Offset = "0x69AD3D0", VA = "0x1869AE7D0")]
	[JDFNDIEGGDI(COFBNFOEGIB.None)]
	private static void NOGKHDMNIHD(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x69AE840", Offset = "0x69AD440", VA = "0x1869AE840")]
	[Preserve]
	public PFBIGNIPMCM([NNEMKPMNJAE(null)] KMMIEFLPLKO LBIBHLFIPHA, [NNEMKPMNJAE(null)] PIKEFAOPMHF BKDGJJADJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x69AE1B0", Offset = "0x69ACDB0", VA = "0x1869AE1B0", Slot = "16")]
	public override DIJEKGOINOG GADFCGHEMCK(CLPNKHJDECL LAMCDJBBCDK, IEnumerator<BILDDJDOJHA> ECOMPNMMGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x69AE310", Offset = "0x69ACF10", VA = "0x1869AE310", Slot = "17")]
	public override void KEPEANOIAHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x69ADF00", Offset = "0x69ACB00", VA = "0x1869ADF00", Slot = "19")]
	public override void FFBOPKDBKOE(PHLEKLAOHLE MGNOOJEPNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x69ADC10", Offset = "0x69AC810", VA = "0x1869ADC10", Slot = "18")]
	protected override void BBEBOIIGBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x69AE2E0", Offset = "0x69ACEE0", VA = "0x1869AE2E0")]
	private PKMBCMMLIID HJEPHOKGPNB(PHLEKLAOHLE CJEAJMFMNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x69AE5A0", Offset = "0x69AD1A0", VA = "0x1869AE5A0", Slot = "20")]
	internal override CIMDNECOHJL MCIMHELJHMO(IEnumerator<BILDDJDOJHA> ECOMPNMMGND, Behaviour LAMCDJBBCDK, NFHCOFLDLAI CCAJJKDGJLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x69AE130", Offset = "0x69ACD30", VA = "0x1869AE130", Slot = "21")]
	internal override HHGCILDDBKF FLGKKNECLCD(PHLEKLAOHLE ICCDPICDNBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x69ADD80", Offset = "0x69AC980", VA = "0x1869ADD80")]
	private void BDMPOEKECHA(PKMBCMMLIID JMKNKONDBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x69ADEA0", Offset = "0x69ACAA0", VA = "0x1869ADEA0", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct IJEECEBBGOE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float OIBPIFAMGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int NDNCLOHFCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> BOBJAGLHMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> HGDIHFIGHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> CJJNGDGGHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<OLFMPFFAIBA> AFLBPIKDHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> ONLDGPFNCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> JBDCHHHGAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> FJLFKPMMICO;

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x69A24B0", Offset = "0x69A10B0", VA = "0x1869A24B0")]
	public static IJEECEBBGOE JOBBHNKGDPO(int PCLACABHHNF, float DBFOFDCBJON, NativeArray<OLFMPFFAIBA> IGOEPPLEONE, NativeArray<float> KGPDMBKPDBL, NativeArray<int> EIEBLPHEEFK, NativeArray<int> BIIHGAMOCPP, NativeArray<int> ACEJBAEMHMO, NativeArray<int> HGDIHFIGHHK, NativeArray<int> CJJNGDGGHCA)
	{
		return default(IJEECEBBGOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x69A23D0", Offset = "0x69A0FD0", VA = "0x1869A23D0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x69A25E0", Offset = "0x69A11E0", VA = "0x1869A25E0")]
	private bool NMNOINKHKNE(int PMIDLPOCCEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x69A23A0", Offset = "0x69A0FA0", VA = "0x1869A23A0")]
	private void DGKMAPEOGOF(NativeArray<int> DDMGBNCKGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x69A2300", Offset = "0x69A0F00", VA = "0x1869A2300")]
	private int ANENAJPGIAM(int HKKLALPEGHN, int NEMIDLDNIJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x69A2510", Offset = "0x69A1110", VA = "0x1869A2510")]
	private void JPJIMINJHAO(NativeArray<int> DDMGBNCKGKF, int EJJFMFLEPJK, int GOHLFLJBMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x69A2620", Offset = "0x69A1220", VA = "0x1869A2620")]
	private void OCGCLEAPNKG(NativeArray<int> DDMGBNCKGKF, int NBNOKJBKNED, int IOFCNBPBPEG, int AKLPKMMFPNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class INMKHDLHKNL : HNODCEEKICB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly KMMIEFLPLKO LBIBHLFIPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly PIKEFAOPMHF BKDGJJADJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private HHGCILDDBKF[] NJOMPPFKLMD;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static HNODCEEKICB EJGFFMEDDPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x69A3F10", Offset = "0x69A2B10", VA = "0x1869A3F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool OANKOMELEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public PHLEKLAOHLE GHEIPJLGEGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7AF180", Offset = "0x7ADD80", VA = "0x1807AF180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(PHLEKLAOHLE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B9610", Offset = "0x7B8210", VA = "0x1807B9610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public PIKEFAOPMHF BLLGHBHOMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public BILDDJDOJHA DMKJDLDIPCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x69A3CA0", Offset = "0x69A28A0", VA = "0x1869A3CA0")]
	public static DIJEKGOINOG HLAEHKMOANL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x69A4000", Offset = "0x69A2C00", VA = "0x1869A4000")]
	[Preserve]
	protected INMKHDLHKNL([NNEMKPMNJAE(null)] KMMIEFLPLKO LBIBHLFIPHA, [NNEMKPMNJAE(null)] PIKEFAOPMHF BKDGJJADJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x69A3570", Offset = "0x69A2170", VA = "0x1869A3570", Slot = "6")]
	public DIJEKGOINOG EDEDADACBKL(IEnumerator<BILDDJDOJHA> ECOMPNMMGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x69A3580", Offset = "0x69A2180", VA = "0x1869A3580", Slot = "7")]
	public DIJEKGOINOG EDEDADACBKL(Behaviour LAMCDJBBCDK, IEnumerator<BILDDJDOJHA> ECOMPNMMGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract DIJEKGOINOG GADFCGHEMCK(CLPNKHJDECL LAMCDJBBCDK, IEnumerator<BILDDJDOJHA> ECOMPNMMGND);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x69A3D70", Offset = "0x69A2970", VA = "0x1869A3D70", Slot = "17")]
	public virtual void KEPEANOIAHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x69A3A60", Offset = "0x69A2660", VA = "0x1869A3A60", Slot = "9")]
	public void GMPHKHHKFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x69A30C0", Offset = "0x69A1CC0", VA = "0x1869A30C0", Slot = "18")]
	protected virtual void BBEBOIIGBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x69A3D50", Offset = "0x69A2950", VA = "0x1869A3D50")]
	private void JPLJEIPJMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x69A3D30", Offset = "0x69A2930", VA = "0x1869A3D30")]
	private void JFPCIDLDKFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x69A3780", Offset = "0x69A2380", VA = "0x1869A3780")]
	private void FDKIGCMLLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x69A3190", Offset = "0x69A1D90", VA = "0x1869A3190")]
	private void DBLOIDPJBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x69A3FE0", Offset = "0x69A2BE0", VA = "0x1869A3FE0")]
	private void PCEPAMJEKGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x69A30E0", Offset = "0x69A1CE0", VA = "0x1869A30E0")]
	private void BHOBADDAIDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x69A3FC0", Offset = "0x69A2BC0", VA = "0x1869A3FC0")]
	private void NPNHLMDOIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x69A37A0", Offset = "0x69A23A0", VA = "0x1869A37A0", Slot = "19")]
	public virtual void FFBOPKDBKOE(PHLEKLAOHLE MGNOOJEPNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x69A3830", Offset = "0x69A2430", VA = "0x1869A3830")]
	private void GBIDNHDJKHC(HHGCILDDBKF JMKNKONDBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1D0FAF0", Offset = "0x1D0E6F0", VA = "0x181D0FAF0")]
	private HHGCILDDBKF KBPIBAKGPKN(PHLEKLAOHLE CJEAJMFMNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract CIMDNECOHJL MCIMHELJHMO(IEnumerator<BILDDJDOJHA> ECOMPNMMGND, Behaviour JFFMDFEGGAH, NFHCOFLDLAI FFJJNDPCFFG);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract HHGCILDDBKF FLGKKNECLCD(PHLEKLAOHLE MGNOOJEPNHH);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x69A31B0", Offset = "0x69A1DB0", VA = "0x1869A31B0", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x69A3F60", Offset = "0x69A2B60", VA = "0x1869A3F60", Slot = "12")]
	public BILDDJDOJHA LDBEAHDPLLM(PHLEKLAOHLE ICCDPICDNBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x69A3100", Offset = "0x69A1D00", VA = "0x1869A3100", Slot = "13")]
	public BILDDJDOJHA CKGCMINNLNF(float OPCGAFBMLPL, PHLEKLAOHLE ICCDPICDNBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x69A3A00", Offset = "0x69A2600", VA = "0x1869A3A00", Slot = "14")]
	public BILDDJDOJHA GHFCLGIEPJE(Func<bool> HPAFCMIPNAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class CIMDNECOHJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly NFHCOFLDLAI CCAJJKDGJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly CGAPKOMEBAD LAMCDJBBCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool EBJKIAAOHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string MPGNMPAPHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private StackTrace HGAHCPOAFKH;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<BILDDJDOJHA> LFMKDGBONNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public BILDDJDOJHA JOLLIBNPPFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B30", Offset = "0x7B1730", VA = "0x1807B2B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool PAFLEHIMFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6998A50", Offset = "0x6997650", VA = "0x186998A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool NJDJKBEOAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x878320", Offset = "0x876F20", VA = "0x180878320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x878440", Offset = "0x877040", VA = "0x180878440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string PEJAGGFBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6998B90", Offset = "0x6997790", VA = "0x186998B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float JGODLJBIABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x111BDB0", Offset = "0x111A9B0", VA = "0x18111BDB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x571BF40", Offset = "0x571AB40", VA = "0x18571BF40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6999130", Offset = "0x6997D30", VA = "0x186999130")]
	public CIMDNECOHJL(IEnumerator<BILDDJDOJHA> LFBOMHPGNEN, CGAPKOMEBAD LAMCDJBBCDK, NFHCOFLDLAI CCAJJKDGJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6998D40", Offset = "0x6997940", VA = "0x186998D40")]
	public BILDDJDOJHA PFALAFLJGHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6998AD0", Offset = "0x69976D0", VA = "0x186998AD0")]
	public bool IMNGOHNIMFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6998B40", Offset = "0x6997740", VA = "0x186998B40")]
	public void NBNGJGKDAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6999050", Offset = "0x6997C50", VA = "0x186999050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x906CE0", Offset = "0x9058E0", VA = "0x180906CE0")]
	[CompilerGenerated]
	private void DMDEJDOLPGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class NFHCOFLDLAI : NOKAPFKBDDI, DIJEKGOINOG, LPNPPPGEAEB, BMPAGEIJFCN, IEnumerator, BILDDJDOJHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private PHLEKLAOHLE MCNEMFBNDOE;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private PHLEKLAOHLE FFFJNIOEIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xEB3F30", Offset = "0xEB2B30", VA = "0x180EB3F30", Slot = "23")]
		get
		{
			return default(PHLEKLAOHLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public PHLEKLAOHLE IKJABLIMFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x13ADF70", Offset = "0x13ACB70", VA = "0x1813ADF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float AIDJFEPONBL
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D40", Offset = "0x8C5940", VA = "0x1808C6D40", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool JABFDMGKKAK
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x69AA5F0", Offset = "0x69A91F0", VA = "0x1869AA5F0", Slot = "24")]
	private bool KGBIALHIIIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x69AA5E0", Offset = "0x69A91E0", VA = "0x1869AA5E0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x69AA610", Offset = "0x69A9210", VA = "0x1869AA610")]
	public NFHCOFLDLAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum KHDIGJDCEHK : byte
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
internal sealed class HHGCILDDBKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum ABEJJJIFCJG
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct BCJLEHKEBFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public PHLEKLAOHLE BGANAGFOABE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public ABEJJJIFCJG MHLKGJIFPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public List<CIMDNECOHJL> AMLPFDCCEPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly ABEJJJIFCJG[] OBJFHECCHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly PHLEKLAOHLE MGNOOJEPNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private bool LDHDNKJKJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly CIMDNECOHJL[] LFGHBLLOCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<CIMDNECOHJL> PGPIGDHDCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> NOLPNMPACLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<CIMDNECOHJL> NBPMEPGPPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<int> BEPABNGDDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly GMHEEOKANHK DMEEBHHJKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private bool PFCPLKCDMOD;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public BCJLEHKEBFG[,] LMAPHIPNNHM
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7B1640", Offset = "0x7B0240", VA = "0x1807B1640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x69A1A60", Offset = "0x69A0660", VA = "0x1869A1A60")]
	public HHGCILDDBKF(PHLEKLAOHLE ICCDPICDNBP, GMHEEOKANHK DMEEBHHJKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x69A0910", Offset = "0x699F510", VA = "0x1869A0910")]
	public void EEKAOIKOPOD(CIMDNECOHJL LFBOMHPGNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x69A1190", Offset = "0x699FD90", VA = "0x1869A1190")]
	public void MKMLOBLKLFP(IList<CIMDNECOHJL> MGDCDNIEDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x69A0E80", Offset = "0x699FA80", VA = "0x1869A0E80")]
	public void LDPMPNLGNBJ(IList<CIMDNECOHJL> MGDCDNIEDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x69A0A10", Offset = "0x699F610", VA = "0x1869A0A10")]
	private void GKLHNKNEFIB(CIMDNECOHJL LFBOMHPGNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x69A0CF0", Offset = "0x699F8F0", VA = "0x1869A0CF0")]
	private void JHFDBDLEHAA(IList<CIMDNECOHJL> MGDCDNIEDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x69A17A0", Offset = "0x69A03A0", VA = "0x1869A17A0")]
	private KHDIGJDCEHK PPDKEJONLME(CIMDNECOHJL LFBOMHPGNEN)
	{
		return default(KHDIGJDCEHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x69A0540", Offset = "0x699F140", VA = "0x1869A0540")]
	public void BBEBOIIGBMN(float DBFOFDCBJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x69A0B00", Offset = "0x699F700", VA = "0x1869A0B00")]
	public void GMPHKHHKFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x69A14A0", Offset = "0x69A00A0", VA = "0x1869A14A0")]
	private void MNJMJGIDLBF(List<CIMDNECOHJL> MGDCDNIEDLD, Stack<int> MHCJBGPCNNL, bool NLIKANODAPJ, float MDBLAOCNJOA = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x69A07F0", Offset = "0x699F3F0", VA = "0x1869A07F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x69A06B0", Offset = "0x699F2B0", VA = "0x1869A06B0")]
	private void DAENEAMOPOD(List<CIMDNECOHJL> MGDCDNIEDLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class OBGMFPFNKMM : GMHEEOKANHK
{
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "4")]
	public void GDEIHNGMICA(string MPGNMPAPHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
	public void PJPPPEBPHFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public OBGMFPFNKMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class MBIEJBGJLCO : CGAPKOMEBAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Behaviour JFFMDFEGGAH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string PEJAGGFBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x69A9550", Offset = "0x69A8150", VA = "0x1869A9550", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool INFBEJKIOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x69A9500", Offset = "0x69A8100", VA = "0x1869A9500", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool JAEFJLLMPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x69A94E0", Offset = "0x69A80E0", VA = "0x1869A94E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public MBIEJBGJLCO(Behaviour JFFMDFEGGAH)
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

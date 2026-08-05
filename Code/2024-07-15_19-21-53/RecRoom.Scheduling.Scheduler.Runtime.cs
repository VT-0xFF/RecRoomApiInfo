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
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private delegate List<PlayerLoopSystem> NLIFKBEAHKD(List<PlayerLoopSystem> JGCPGLNEMJB, int MMKCOHFKMJH);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct BDIJKJHPOLA
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct EODCAECJFEE
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static EHODCIMNDCH DLOGBHBPOIA;

				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x71FBC10", Offset = "0x71FA410", VA = "0x1871FBC10")]
				public static PlayerLoopSystem KHNPBDKLDLJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct PNJDLILLAFG
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static EHODCIMNDCH PLGKALAENJN;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x720FE70", Offset = "0x720E670", VA = "0x18720FE70")]
				public static PlayerLoopSystem KHNPBDKLDLJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct LFBCBGFIMGJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static EHODCIMNDCH JIKEKNHPFFO;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x720A640", Offset = "0x7208E40", VA = "0x18720A640")]
				public static PlayerLoopSystem KHNPBDKLDLJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct MMDOEMELPIJ
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static EHODCIMNDCH LHGLKIPPJEG;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static EHODCIMNDCH OHONKDHIMHN;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static EHODCIMNDCH IJNPCFPPAIM;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static EHODCIMNDCH MKDPEPCMDBD;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x720ADC0", Offset = "0x72095C0", VA = "0x18720ADC0")]
				public static PlayerLoopSystem KHNPBDKLDLJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct DDEHGALJPEH
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static EHODCIMNDCH CONNGJDOADJ;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x71FAB60", Offset = "0x71F9360", VA = "0x1871FAB60")]
				public static PlayerLoopSystem KHNPBDKLDLJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct OELLJOLCADP
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static EHODCIMNDCH LHGLKIPPJEG;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static EHODCIMNDCH OHONKDHIMHN;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static EHODCIMNDCH IJNPCFPPAIM;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static EHODCIMNDCH MKDPEPCMDBD;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x720D500", Offset = "0x720BD00", VA = "0x18720D500")]
				public static PlayerLoopSystem KHNPBDKLDLJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct JIFPFAMLPGA
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static EHODCIMNDCH BACFBLGCIFI;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x7208EB0", Offset = "0x72076B0", VA = "0x187208EB0")]
				public static PlayerLoopSystem KHNPBDKLDLJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct AEIBHLOBCGK
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static EHODCIMNDCH GHJBHFHJJMF;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x71F56C0", Offset = "0x71F3EC0", VA = "0x1871F56C0")]
				public static PlayerLoopSystem KHNPBDKLDLJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct NIIMBMOHJJK
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static EHODCIMNDCH HLDLOHFKAFK;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x720BE40", Offset = "0x720A640", VA = "0x18720BE40")]
				public static PlayerLoopSystem KHNPBDKLDLJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct HABOEKMAKLJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static EHODCIMNDCH LNJJFINCCGC;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x71FECB0", Offset = "0x71FD4B0", VA = "0x1871FECB0")]
				public static PlayerLoopSystem KHNPBDKLDLJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct MNAODENJMCA
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static EHODCIMNDCH GGKNEDCGHJF;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x720B0B0", Offset = "0x72098B0", VA = "0x18720B0B0")]
				public static PlayerLoopSystem KHNPBDKLDLJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct ELCONGAPJEE
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static EHODCIMNDCH CIBBBNKHLPI;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x71FB340", Offset = "0x71F9B40", VA = "0x1871FB340")]
				public static PlayerLoopSystem KHNPBDKLDLJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct KCBGDMOHDCC
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static EHODCIMNDCH PKIEBJAIINP;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x72091E0", Offset = "0x72079E0", VA = "0x1872091E0")]
				public static PlayerLoopSystem KHNPBDKLDLJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public enum JMAFADCBMHD : byte
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
			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public struct OKLOFCLGNFH
			{
				[Cpp2IlInjected.Token(Token = "0x2000021")]
				[CompilerGenerated]
				private sealed class NEKFGLJFHCO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public JMAFADCBMHD updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
					public NEKFGLJFHCO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x720B490", Offset = "0x7209C90", VA = "0x18720B490")]
					internal void HFBBLIKFFKO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static ODIOBOMGOFD<JMAFADCBMHD> KJAFGPHCMOJ;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x720DC50", Offset = "0x720C450", VA = "0x18720DC50")]
				public static PlayerLoopSystem KHNPBDKLDLJ(JMAFADCBMHD ACIIBBAGHHP)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			internal struct KADEIBCOEIN
			{
				[Cpp2IlInjected.Token(Token = "0x2000023")]
				[CompilerGenerated]
				private sealed class OIKJMFGDKOH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public HBJHILMNFNM.PJCJAABLALM key;

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
					public OIKJMFGDKOH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x720DA10", Offset = "0x720C210", VA = "0x18720DA10")]
					internal void HBHDOLLNKMN()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable LOBIMOBOKNH;

				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x72090B0", Offset = "0x72078B0", VA = "0x1872090B0")]
				public static PlayerLoopSystem HKDFGDGHEDO(HBJHILMNFNM.PJCJAABLALM NDDCLPHCEEO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000025")]
			internal struct ADFMLMPLCKO
			{
				[Cpp2IlInjected.Token(Token = "0x2000026")]
				[CompilerGenerated]
				private sealed class IGNDOKCKIDP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public HBJHILMNFNM.PJCJAABLALM key;

					[Cpp2IlInjected.Token(Token = "0x6000056")]
					[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
					public IGNDOKCKIDP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x72059C0", Offset = "0x72041C0", VA = "0x1872059C0")]
					internal void HBHDOLLNKMN()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x71F5360", Offset = "0x71F3B60", VA = "0x1871F5360")]
				public static PlayerLoopSystem HKDFGDGHEDO(HBJHILMNFNM.PJCJAABLALM NDDCLPHCEEO)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class ILGODGJOGFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public ILGODGJOGFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7206FC0", Offset = "0x72057C0", VA = "0x187206FC0")]
			internal List<PlayerLoopSystem> FKCLFMPLMBN(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool JBOLCFGEODO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool IFLKIOGDEHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x71F6DF0", Offset = "0x71F55F0", VA = "0x1871F6DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71F7970", Offset = "0x71F6170", VA = "0x1871F7970")]
		private static void CMGNAMFCNHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x71F6E30", Offset = "0x71F5630", VA = "0x1871F6E30")]
		private static void AJHMJPGFINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x71F7740", Offset = "0x71F5F40", VA = "0x1871F7740")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71F6C30", Offset = "0x71F5430", VA = "0x1871F6C30")]
		private static void AADEKNNGMIH(HBJHILMNFNM.PJCJAABLALM NDDCLPHCEEO, PlayerLoopSystem FIEPEONNCHO, Type LGHOJPKHNPH, Type CEMPJLJPAJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71FA570", Offset = "0x71F8D70", VA = "0x1871FA570")]
		private static void EJMIPDPCBEK(PlayerLoopSystem FIEPEONNCHO, Type LGHOJPKHNPH, Type CEMPJLJPAJC, NLIFKBEAHKD HMOMBLFCJEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71FA950", Offset = "0x71F9150", VA = "0x1871FA950")]
		private static void FPIOGANLCEG(PlayerLoopSystem FIEPEONNCHO, Type LGHOJPKHNPH, Type CEMPJLJPAJC, PlayerLoopSystem? AEDCPFCDBJP, PlayerLoopSystem? MLPFHHGCEPF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class HBJHILMNFNM
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum PJCJAABLALM
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

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class EINLPOIECMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly PJCJAABLALM BJOAHMKAMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly OBGBLLAPIPM FOLHLCHAOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private long KLAGOPJFMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long HHKEGHFGPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long KGBJFMNPKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int CMHKIIINHAB;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x71FB230", Offset = "0x71F9A30", VA = "0x1871FB230")]
		public EINLPOIECMH(PJCJAABLALM CLJGKKPNDMB, int GOIGGDADOPG = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x71FAFE0", Offset = "0x71F97E0", VA = "0x1871FAFE0")]
		public void FIFEAJLOGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x71FAF90", Offset = "0x71F9790", VA = "0x1871FAF90")]
		public void EANCDEHLLBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x71FB050", Offset = "0x71F9850", VA = "0x1871FB050")]
		public void MOEBIHHDKJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static PJCJAABLALM[] IBBJDCHJGIJ;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static EINLPOIECMH[] FJANKDEPIDM;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x71FFB80", Offset = "0x71FE380", VA = "0x1871FFB80")]
	public static EINLPOIECMH MPMOMMIKNFH(PJCJAABLALM NDDCLPHCEEO, int GOIGGDADOPG = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x71FFA70", Offset = "0x71FE270", VA = "0x1871FFA70")]
	public static EINLPOIECMH DFPLDKFEPEA(PJCJAABLALM NDDCLPHCEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x71FFAE0", Offset = "0x71FE2E0", VA = "0x1871FFAE0")]
	public static void ILFNLMMGBLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class OBGBLLAPIPM : KIEHJLNBCNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int PNGDJMDCDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Queue<double> HNIJCJMIFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double ILMEANFNINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double PLJHMOFCKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double DDEHADKMHIM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double FNDHIEMGBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x720C630", Offset = "0x720AE30", VA = "0x18720C630", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double EFFHEIKNDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1A63900", Offset = "0x1A62100", VA = "0x181A63900", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double JEGNKKKIMIH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1F60500", Offset = "0x1F5ED00", VA = "0x181F60500", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x720C820", Offset = "0x720B020", VA = "0x18720C820")]
	public OBGBLLAPIPM(int AKMPLLNJJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x720C690", Offset = "0x720AE90", VA = "0x18720C690", Slot = "7")]
	public void BFDAFNAMENP(double GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x720C7B0", Offset = "0x720AFB0", VA = "0x18720C7B0", Slot = "8")]
	public void MJPMKPPBJPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class MNPGNBBFNED : KIEHJLNBCNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private long IHGHLPOONHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double NFOJGKOANPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double FCNHBCPOEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double BOFIFGELFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double ACHCHBPCJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double ILMEANFNINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double PLJHMOFCKBP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double EFFHEIKNDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E60790", Offset = "0x5E5EF90", VA = "0x185E60790", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JEGNKKKIMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E60760", Offset = "0x5E5EF60", VA = "0x185E60760", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double GGINOPFDKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E60770", Offset = "0x5E5EF70", VA = "0x185E60770")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FNDHIEMGBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x25531C0", Offset = "0x25519C0", VA = "0x1825531C0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x720B2B0", Offset = "0x7209AB0", VA = "0x18720B2B0", Slot = "7")]
	public virtual void BFDAFNAMENP(double GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x720B3D0", Offset = "0x7209BD0", VA = "0x18720B3D0", Slot = "8")]
	public virtual void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7208E80", Offset = "0x7207680", VA = "0x187208E80")]
	public MNPGNBBFNED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class JEIIMPOLMKF : MNPGNBBFNED
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double GCKOMEIBJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5E607D0", Offset = "0x5E5EFD0", VA = "0x185E607D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5E60C30", Offset = "0x5E5F430", VA = "0x185E60C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7208D10", Offset = "0x7207510", VA = "0x187208D10", Slot = "7")]
	public override void BFDAFNAMENP(double GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7208E40", Offset = "0x7207640", VA = "0x187208E40", Slot = "8")]
	public override void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7208E80", Offset = "0x7207680", VA = "0x187208E80")]
	public JEIIMPOLMKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KIEHJLNBCNM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double FNDHIEMGBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double EFFHEIKNDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double JEGNKKKIMIH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class JAKEPMNIHJK
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private interface HIMKIOBGHBI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool CNBAGEGEKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LCJDPHEAJHF();
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private abstract class LGPEBNOIJDD<TPromise, TMainThreadPromise> : HIMKIOBGHBI where TPromise : OABICBNODGM where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly TPromise ABCAKOKMCGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		protected readonly TMainThreadPromise JBHOPGJCOFL;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise PIOPCKNPOCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x42543C0", Offset = "0x4252BC0", VA = "0x1842543C0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool CNBAGEGEKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x42542E0", Offset = "0x4252AE0", VA = "0x1842542E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85D850", VA = "0x18085F050")]
		protected LGPEBNOIJDD(TPromise ABCAKOKMCGB, TMainThreadPromise IMLNINNKANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x42543A0", Offset = "0x4252BA0", VA = "0x1842543A0", Slot = "5")]
		public void LCJDPHEAJHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void JHNBPHKGJMA(TPromise ABCAKOKMCGB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class FHHOLNIBMCP<T> : LGPEBNOIJDD<MAKKFMNHCEA<T>, DPHELOEKPOL<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3BDA0B0", Offset = "0x3BD88B0", VA = "0x183BDA0B0")]
		public FHHOLNIBMCP(MAKKFMNHCEA<T> ABCAKOKMCGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3BD9F60", Offset = "0x3BD8760", VA = "0x183BD9F60", Slot = "6")]
		protected override void JHNBPHKGJMA(MAKKFMNHCEA<T> ABCAKOKMCGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3B71340", Offset = "0x3B6FB40", VA = "0x183B71340")]
		[CompilerGenerated]
		private void HGFCPENBBFB(T ADPMAHMCGNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3BD9F10", Offset = "0x3BD8710", VA = "0x183BD9F10")]
		[CompilerGenerated]
		private void GJHNPGPNBGE(string GGEHLADLJHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class OGIGKMBFEKL : HIMKIOBGHBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Action ENGMCBPHJGL;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool CNBAGEGEKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BDA0", VA = "0x18086D5A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8519E0", VA = "0x1808531E0")]
		public OGIGKMBFEKL(Action ENGMCBPHJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x92AEA0", Offset = "0x9296A0", VA = "0x18092AEA0", Slot = "5")]
		public void LCJDPHEAJHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<HIMKIOBGHBI> CDCCEEHDIPI;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBCD0", Offset = "0x2BBA4D0", VA = "0x182BBBCD0")]
	public static MAKKFMNHCEA<T> KECGLJMIBIM<T>(this MAKKFMNHCEA<T> ABCAKOKMCGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7208800", Offset = "0x7207000", VA = "0x187208800")]
	public static void KECGLJMIBIM(Action ENGMCBPHJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBBE0", Offset = "0x2BBA3E0", VA = "0x182BBBBE0")]
	private static MAKKFMNHCEA<T> BHPAPPPAAHN<T>(MAKKFMNHCEA<T> ABCAKOKMCGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7208510", Offset = "0x7206D10", VA = "0x187208510")]
	private static void FAOGNJAODOK(HIMKIOBGHBI PLNECBEGJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72088A0", Offset = "0x72070A0", VA = "0x1872088A0")]
	private static void MFBPBNBPLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7208B80", Offset = "0x7207380", VA = "0x187208B80")]
	private static void PCJNDIGNGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7208720", Offset = "0x7206F20", VA = "0x187208720")]
	private static void INKCBNHDAEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class ONDGENPBIHC
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct CEAKGKDJPIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public TaskCompletionSource<Scene> ECHABOGBHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly string OAAJEIOFMBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly LoadSceneMode FNKBKFNBBPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly bool DNHNFCFHHHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x71F67B0", Offset = "0x71F4FB0", VA = "0x1871F67B0")]
		public CEAKGKDJPIH(TaskCompletionSource<Scene> KLCFJBFNJKE, string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN, bool DNHNFCFHHHN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct KKCOBPIJFLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private OADONCMLPJG<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7209D30", Offset = "0x7208530", VA = "0x187209D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x720A5D0", Offset = "0x7208DD0", VA = "0x18720A5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct HMMAHMNDFBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x72012A0", Offset = "0x71FFAA0", VA = "0x1872012A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x72015C0", Offset = "0x71FFDC0", VA = "0x1872015C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct LPGKJKHLIOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private CEAKGKDJPIH <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x720A8A0", Offset = "0x72090A0", VA = "0x18720A8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x720AC50", Offset = "0x7209450", VA = "0x18720AC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class LLDKLMINPJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public DPHELOEKPOL<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public LLDKLMINPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x720A840", Offset = "0x7209040", VA = "0x18720A840")]
		internal void NAHGEFPHAIA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct IEKCBGDNHMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private LLDKLMINPJM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private OADONCMLPJG<string>.HILOONJJDHL <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x72023C0", Offset = "0x7200BC0", VA = "0x1872023C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7202F60", Offset = "0x7201760", VA = "0x187202F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct OOAMJCMEGBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x720F810", Offset = "0x720E010", VA = "0x18720F810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x720FCE0", Offset = "0x720E4E0", VA = "0x18720FCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct HAPAJDHNOPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private OADONCMLPJG<string>.HILOONJJDHL <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private OADONCMLPJG<string>.HILOONJJDHL <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x71FEEB0", Offset = "0x71FD6B0", VA = "0x1871FEEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x71FFA00", Offset = "0x71FE200", VA = "0x1871FFA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class NFFPMNFBOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public NFFPMNFBOMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x720B510", Offset = "0x7209D10", VA = "0x18720B510")]
		internal bool FJJMGKJFFHK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class OCONHDPIMKC : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private JMPDKMJKKGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CNPNGJHMILJ onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public OCONHDPIMKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x720CCB0", Offset = "0x720B4B0", VA = "0x18720CCB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x720C920", Offset = "0x720B120", VA = "0x18720C920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x720C8D0", Offset = "0x720B0D0", VA = "0x18720C8D0")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x720CC60", Offset = "0x720B460", VA = "0x18720CC60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class IHFJEFBOJGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public DPHELOEKPOL<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public IHFJEFBOJGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7205C30", Offset = "0x7204430", VA = "0x187205C30")]
		internal bool EJLKEGDFKNC(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7205CB0", Offset = "0x72044B0", VA = "0x187205CB0")]
		internal void MBDAMKJKLHO(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class EMELHLEAEOF : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private JMPDKMJKKGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public DPHELOEKPOL<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private IHFJEFBOJGK <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public EMELHLEAEOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x71FB540", Offset = "0x71F9D40", VA = "0x1871FB540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x71FBBC0", Offset = "0x71FA3C0", VA = "0x1871FBBC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly ICollection<string> PNLLLKNFHOK;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static OABICBNODGM IIGJIAFNAPE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static AsyncOperation NLPOLICOMJH;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static OABICBNODGM BOOGBFJEPGE;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static string BBJNDFNFFED;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static ThreadPriority IILDJKGBOFP;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task KIPDPCIGPHE;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static List<SceneInstance> MHIAINEINLH;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Queue<CEAKGKDJPIH> OPCMDDPKDIC;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Task CFFHMPDGBMH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool IKMCOKKBFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x720DF20", Offset = "0x720C720", VA = "0x18720DF20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool OGIKOAOMDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x720E250", Offset = "0x720CA50", VA = "0x18720E250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool BCIDPCNFKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x720ECE0", Offset = "0x720D4E0", VA = "0x18720ECE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool LGKCGEDEHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x720E4F0", Offset = "0x720CCF0", VA = "0x18720E4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> BFBAPNGEAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x720E580", Offset = "0x720CD80", VA = "0x18720E580")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x720E140", Offset = "0x720C940", VA = "0x18720E140")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x720EAC0", Offset = "0x720D2C0", VA = "0x18720EAC0")]
	[JIDCLHKIDAF(KJECFEIFJAL.EnteredEditModeNextFrame, 0)]
	private static void HBDKKCKICPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x720ED80", Offset = "0x720D580", VA = "0x18720ED80")]
	[AsyncStateMachine(typeof(KKCOBPIJFLE))]
	public static Task<Scene> JLCDFILIOPA(string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN = LoadSceneMode.Single, bool DNHNFCFHHHN = false, [Optional] OADONCMLPJG<string>.HILOONJJDHL NPJBMNGDLMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x720EED0", Offset = "0x720D6D0", VA = "0x18720EED0")]
	[AsyncStateMachine(typeof(HMMAHMNDFBI))]
	private static Task LAGBELIAIJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x720F100", Offset = "0x720D900", VA = "0x18720F100")]
	[AsyncStateMachine(typeof(LPGKJKHLIOE))]
	private static Task LPGCMPGJHCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x720E860", Offset = "0x720D060", VA = "0x18720E860")]
	[AsyncStateMachine(typeof(IEKCBGDNHMI))]
	private static Task<Scene> GCPPFDOOLPP(string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN, bool DNHNFCFHHHN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x720DE20", Offset = "0x720C620", VA = "0x18720DE20")]
	private static void BEFKDBKNAOF(SceneInstance BOLGDNNEFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x720E2F0", Offset = "0x720CAF0", VA = "0x18720E2F0")]
	private static void DDCDNIOJGEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x720EBC0", Offset = "0x720D3C0", VA = "0x18720EBC0")]
	[AsyncStateMachine(typeof(OOAMJCMEGBF))]
	private static Task<Scene> HGJAOHEILEM(string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x720F1D0", Offset = "0x720D9D0", VA = "0x18720F1D0")]
	private static bool NKOACHODLDP(string OAAJEIOFMBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x720E9B0", Offset = "0x720D1B0", VA = "0x18720E9B0")]
	[AsyncStateMachine(typeof(HAPAJDHNOPI))]
	private static Task<Scene> GDDFCAEIIAE(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x720EF80", Offset = "0x720D780", VA = "0x18720EF80")]
	public static MAKKFMNHCEA<Scene> LFEKPHEGIOA(string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x720F350", Offset = "0x720DB50", VA = "0x18720F350")]
	public static OABICBNODGM ONGOHBNILKI(string OAAJEIOFMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x720F2C0", Offset = "0x720DAC0", VA = "0x18720F2C0")]
	[IteratorStateMachine(typeof(OCONHDPIMKC))]
	private static IEnumerator<JMPDKMJKKGA> NOEJHMIDNMH(string OAAJEIOFMBJ, CNPNGJHMILJ ANNBNNHJHOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x720E690", Offset = "0x720CE90", VA = "0x18720E690")]
	[IteratorStateMachine(typeof(EMELHLEAEOF))]
	private static IEnumerator<JMPDKMJKKGA> FODCLPNBNKF(string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN, DPHELOEKPOL<Scene> ANNBNNHJHOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x720E730", Offset = "0x720CF30", VA = "0x18720E730")]
	public static bool GBCKCKHEOFE([Out] string HFEDNPGALEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NHOILCEDDGM
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x720BCB0", Offset = "0x720A4B0", VA = "0x18720BCB0")]
	public static IDisposable AOIIIKABCIA(this BNDKJFEMLMG CNBJCJOALNK, float NPEJJPOODJL, Action<float> IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x720BDC0", Offset = "0x720A5C0", VA = "0x18720BDC0")]
	public static IDisposable JFKEDNFNABI(this BNDKJFEMLMG CNBJCJOALNK, Action<float> IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x720BD40", Offset = "0x720A540", VA = "0x18720BD40")]
	public static IDisposable FCOIECKGMKL(this BNDKJFEMLMG CNBJCJOALNK, Action<float> IDBCFENKBMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class GCGGEHBOKLK
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x71FC9E0", Offset = "0x71FB1E0", VA = "0x1871FC9E0")]
	public static IDisposable FPLFFAIFCGP(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x71FCA70", Offset = "0x71FB270", VA = "0x1871FCA70")]
	public static IDisposable FPLFFAIFCGP(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x71FCE60", Offset = "0x71FB660", VA = "0x1871FCE60")]
	public static IDisposable LHGGKPHIKGE(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x71FCDE0", Offset = "0x71FB5E0", VA = "0x1871FCDE0")]
	public static IDisposable LFENBOKJKMG(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x71FCD60", Offset = "0x71FB560", VA = "0x1871FCD60")]
	public static IDisposable LFENBOKJKMG(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x71FC8B0", Offset = "0x71FB0B0", VA = "0x1871FC8B0")]
	public static IDisposable ECEIDBDCEGN(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x71FCB00", Offset = "0x71FB300", VA = "0x1871FCB00")]
	public static IDisposable IAADPOODKJK(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x71FD000", Offset = "0x71FB800", VA = "0x1871FD000")]
	public static IDisposable MALPNKLOAFE(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x71FC800", Offset = "0x71FB000", VA = "0x1871FC800")]
	public static IDisposable DELPHDHAJIG(this MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x71FCEE0", Offset = "0x71FB6E0", VA = "0x1871FCEE0")]
	public static IDisposable LKHCOPPEALP(this MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x71FCB80", Offset = "0x71FB380", VA = "0x1871FCB80")]
	public static IDisposable JPJCGNANANK(this MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x71FD080", Offset = "0x71FB880", VA = "0x1871FD080")]
	public static IDisposable NENMGAPHFJG(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x71FCC20", Offset = "0x71FB420", VA = "0x1871FCC20")]
	public static IDisposable KAPEHGAJACK(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x71FD120", Offset = "0x71FB920", VA = "0x1871FD120")]
	public static IDisposable OFDJOLLIENH(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x71FC760", Offset = "0x71FAF60", VA = "0x1871FC760")]
	public static IDisposable DEFIMBJNAIG(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x71FC6C0", Offset = "0x71FAEC0", VA = "0x1871FC6C0")]
	public static IDisposable CKHEGCJHHKE(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x71FCCC0", Offset = "0x71FB4C0", VA = "0x1871FCCC0")]
	public static IDisposable KJMMNEELJAG(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x71FC620", Offset = "0x71FAE20", VA = "0x1871FC620")]
	public static IDisposable BCIIHHLKMEA(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x71FC930", Offset = "0x71FB130", VA = "0x1871FC930")]
	public static IDisposable FHDCIFHFOIJ(this MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class ACDADEMAGHH
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class GENFGEPLDJK : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private JMPDKMJKKGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public NKLOKPDBJDH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private KJMDKCPGDDO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public GENFGEPLDJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x71FD1C0", Offset = "0x71FB9C0", VA = "0x1871FD1C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x71FD2A0", Offset = "0x71FBAA0", VA = "0x1871FD2A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class ICILIKIFCAP : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private JMPDKMJKKGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public NKLOKPDBJDH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private KJMDKCPGDDO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public ICILIKIFCAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7202280", Offset = "0x7200A80", VA = "0x187202280", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7202370", Offset = "0x7200B70", VA = "0x187202370", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x71F5190", Offset = "0x71F3990", VA = "0x1871F5190")]
	public static GOOHGCNPLOF FPLFFAIFCGP(Action IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x71F4FB0", Offset = "0x71F37B0", VA = "0x1871F4FB0")]
	public static GOOHGCNPLOF FPLFFAIFCGP(Behaviour CNBJCJOALNK, Action IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x71F5070", Offset = "0x71F3870", VA = "0x1871F5070")]
	public static GOOHGCNPLOF FPLFFAIFCGP(Behaviour CNBJCJOALNK, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x71F52D0", Offset = "0x71F3AD0", VA = "0x1871F52D0")]
	[IteratorStateMachine(typeof(GENFGEPLDJK))]
	private static IEnumerator<JMPDKMJKKGA> NCIMGCKPDOJ(NKLOKPDBJDH OHHDHLEHJDL, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x71F5240", Offset = "0x71F3A40", VA = "0x1871F5240")]
	[IteratorStateMachine(typeof(ICILIKIFCAP))]
	private static IEnumerator<JMPDKMJKKGA> NCIMGCKPDOJ(NKLOKPDBJDH OHHDHLEHJDL, Action<float> IDBCFENKBMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class ADNFIFODHNE : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class DBNPOENPCAD : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private JMPDKMJKKGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public ADNFIFODHNE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public DBNPOENPCAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x71FAA80", Offset = "0x71F9280", VA = "0x1871FAA80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x71FAB10", Offset = "0x71F9310", VA = "0x1871FAB10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly NKLOKPDBJDH EHKPGKAHKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Action EPOLLNCMLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool GCOHLKAOKEJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool IOIGEPJKPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8569B0", Offset = "0x8551B0", VA = "0x1808569B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x71F55B0", Offset = "0x71F3DB0", VA = "0x1871F55B0")]
	public ADNFIFODHNE(NKLOKPDBJDH EHKPGKAHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x71F5490", Offset = "0x71F3C90", VA = "0x1871F5490")]
	[IteratorStateMachine(typeof(DBNPOENPCAD))]
	private IEnumerator<JMPDKMJKKGA> COCKOFBEEHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x71F5510", Offset = "0x71F3D10", VA = "0x1871F5510", Slot = "4")]
	public void OnCompleted(Action KFANDDBANJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	public void NKCJMOMAIOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class DGBGLLMBLFB
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x71FAD90", Offset = "0x71F9590", VA = "0x1871FAD90")]
	public static ADNFIFODHNE HGMNODJPCNM(this NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class OAGIIEMODBJ
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class MIFKDOJFGAF : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private JMPDKMJKKGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public PFMCNOBHFJK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public MIFKDOJFGAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x720ACF0", Offset = "0x72094F0", VA = "0x18720ACF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x720AD70", Offset = "0x7209570", VA = "0x18720AD70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x720C270", Offset = "0x720AA70", VA = "0x18720C270")]
	public static GOOHGCNPLOF FPLFFAIFCGP(float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x720C160", Offset = "0x720A960", VA = "0x18720C160")]
	public static GOOHGCNPLOF FPLFFAIFCGP(MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x720C040", Offset = "0x720A840", VA = "0x18720C040")]
	public static GOOHGCNPLOF ADJOPOJCNLM(MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x720C490", Offset = "0x720AC90", VA = "0x18720C490")]
	public static GOOHGCNPLOF ONOLLACNKEE(BNDKJFEMLMG CNBJCJOALNK, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x720C3D0", Offset = "0x720ABD0", VA = "0x18720C3D0")]
	private static IEnumerator<JMPDKMJKKGA> NCIMGCKPDOJ(LIIPOKLEFGD GEGBGPONHGL, float NPEJJPOODJL, NKLOKPDBJDH OHHDHLEHJDL, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x720C370", Offset = "0x720AB70", VA = "0x18720C370")]
	private static IEnumerator<JMPDKMJKKGA> IBNDPOOHMKP(LIIPOKLEFGD GEGBGPONHGL, float NPEJJPOODJL, NKLOKPDBJDH OHHDHLEHJDL, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x720C5A0", Offset = "0x720ADA0", VA = "0x18720C5A0")]
	[IteratorStateMachine(typeof(MIFKDOJFGAF))]
	private static IEnumerator<JMPDKMJKKGA> OPBPIPBCIKK(PFMCNOBHFJK DKNNEBCHBMN, float NPEJJPOODJL, NKLOKPDBJDH OHHDHLEHJDL, Action<float> IDBCFENKBMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class BOEEMMDEDLA
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class HHGKEOAKIFP : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private JMPDKMJKKGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public NKLOKPDBJDH queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public HHGKEOAKIFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x71FFF00", Offset = "0x71FE700", VA = "0x1871FFF00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x71FFFC0", Offset = "0x71FE7C0", VA = "0x1871FFFC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x71F6510", Offset = "0x71F4D10", VA = "0x1871F6510")]
	[IteratorStateMachine(typeof(HHGKEOAKIFP))]
	private static IEnumerator<JMPDKMJKKGA> LCLBNJNAEED(NKLOKPDBJDH EHKPGKAHKKL, Func<bool> NGPBJNKHNBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x71F63F0", Offset = "0x71F4BF0", VA = "0x1871F63F0")]
	public static GOOHGCNPLOF AMNGGPOGLCD(this MonoBehaviour EIFNDIABMHD, Func<bool> NGPBJNKHNBB, NKLOKPDBJDH EHKPGKAHKKL = NKLOKPDBJDH.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class IHKAKCCGCGM
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class DNNINHDHNNL : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private JMPDKMJKKGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public NKLOKPDBJDH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public DNNINHDHNNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x71FAED0", Offset = "0x71F96D0", VA = "0x1871FAED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x71FAF40", Offset = "0x71F9740", VA = "0x1871FAF40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class PHGNEHBKNNM : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private JMPDKMJKKGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public NKLOKPDBJDH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private JMPDKMJKKGA <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public PHGNEHBKNNM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x720FD50", Offset = "0x720E550", VA = "0x18720FD50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x720FDE0", Offset = "0x720E5E0", VA = "0x18720FDE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x72060D0", Offset = "0x72048D0", VA = "0x1872060D0")]
	[IteratorStateMachine(typeof(DNNINHDHNNL))]
	private static IEnumerator<JMPDKMJKKGA> COCKOFBEEHB(float IOCCJIJEELD, NKLOKPDBJDH OHHDHLEHJDL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x72065D0", Offset = "0x7204DD0", VA = "0x1872065D0")]
	[IteratorStateMachine(typeof(PHGNEHBKNNM))]
	private static IEnumerator<JMPDKMJKKGA> KHCKBAMNOOD(float IOCCJIJEELD, NKLOKPDBJDH OHHDHLEHJDL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7206670", Offset = "0x7204E70", VA = "0x187206670")]
	public static IDisposable LDECKOPNPII(this MonoBehaviour EIFNDIABMHD, float IOCCJIJEELD, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7206410", Offset = "0x7204C10", VA = "0x187206410")]
	public static GOOHGCNPLOF HEBLAGHGIKD(this MonoBehaviour EIFNDIABMHD, float IOCCJIJEELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7206790", Offset = "0x7204F90", VA = "0x187206790")]
	public static GOOHGCNPLOF LDECKOPNPII(this MonoBehaviour EIFNDIABMHD, float IOCCJIJEELD, NKLOKPDBJDH OHHDHLEHJDL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7206240", Offset = "0x7204A40", VA = "0x187206240")]
	public static GOOHGCNPLOF DOODLMKCNBB(this MonoBehaviour EIFNDIABMHD, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x72065A0", Offset = "0x7204DA0", VA = "0x1872065A0")]
	public static GOOHGCNPLOF JIDBEOCAJGF(this MonoBehaviour EIFNDIABMHD, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7206330", Offset = "0x7204B30", VA = "0x187206330")]
	public static GOOHGCNPLOF EMALFLIODFA(this MonoBehaviour EIFNDIABMHD, Action GPJOKKOGGOF, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x72068C0", Offset = "0x72050C0", VA = "0x1872068C0")]
	public static GOOHGCNPLOF LHNAIPFFJGN(this MonoBehaviour EIFNDIABMHD, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x72068F0", Offset = "0x72050F0", VA = "0x1872068F0")]
	public static GOOHGCNPLOF NHIMEFPNBDP(this MonoBehaviour EIFNDIABMHD, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7206170", Offset = "0x7204970", VA = "0x187206170")]
	private static GOOHGCNPLOF DEIKPKFPGNP(MonoBehaviour EIFNDIABMHD, NKLOKPDBJDH EHKPGKAHKKL, Action GPJOKKOGGOF, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7205F30", Offset = "0x7204730", VA = "0x187205F30")]
	public static GOOHGCNPLOF ADADKGIIPOI(this MonoBehaviour EIFNDIABMHD, float LKDIHAFBCJL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7206260", Offset = "0x7204A60", VA = "0x187206260")]
	public static GOOHGCNPLOF ECGKHPHACJC(this MonoBehaviour EIFNDIABMHD, float LKDIHAFBCJL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x72064D0", Offset = "0x7204CD0", VA = "0x1872064D0")]
	public static GOOHGCNPLOF IKCENKMMNBC(this MonoBehaviour EIFNDIABMHD, float LKDIHAFBCJL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7206000", Offset = "0x7204800", VA = "0x187206000")]
	public static GOOHGCNPLOF BDFNOIPEOJA(this MonoBehaviour EIFNDIABMHD, float LKDIHAFBCJL, Action GPJOKKOGGOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class KCNLJCBDKMI : LLDHOGPGHNI, IEnumerable<LLDHOGPGHNI>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly List<LLDHOGPGHNI> KBHMIFHHJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool FDIHAEDHIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Action IFMJIHFFPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool PMEDDJAGFNA;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IAOKINFFNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7209540", Offset = "0x7207D40", VA = "0x187209540", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NIMFNDMBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7209A20", Offset = "0x7208220", VA = "0x187209A20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7209AC0", Offset = "0x72082C0", VA = "0x187209AC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7209C90", Offset = "0x7208490", VA = "0x187209C90")]
	public KCNLJCBDKMI([Optional] Action IFMJIHFFPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7209B60", Offset = "0x7208360", VA = "0x187209B60")]
	public void PBLNBBGFGAP(LLDHOGPGHNI NOACPCMJNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x72093E0", Offset = "0x7207BE0", VA = "0x1872093E0")]
	private void FGGJKAEJENG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7209A10", Offset = "0x7208210", VA = "0x187209A10", Slot = "7")]
	public bool LLILENKEDLI(bool AMNFMCIBNPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7209700", Offset = "0x7207F00", VA = "0x187209700", Slot = "8")]
	public bool LLILENKEDLI(Action ENGMCBPHJGL, bool AMNFMCIBNPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7209680", Offset = "0x7207E80", VA = "0x187209680", Slot = "9")]
	public IEnumerator<LLDHOGPGHNI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7209680", Offset = "0x7207E80", VA = "0x187209680", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OGBEIILKDNM : FBLILNPFBIB
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class FFPPJFKCEGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public OGBEIILKDNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public FFPPJFKCEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x71FAD60", Offset = "0x71F9560", VA = "0x1871FAD60")]
		internal void EGCGHOPAAOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class DDJFHJNFFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public OGBEIILKDNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public DDJFHJNFFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x71FAD60", Offset = "0x71F9560", VA = "0x1871FAD60")]
		internal void EALHHCEEHPI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly float OMCHILFDFMG;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7206960", Offset = "0x7205160", VA = "0x187206960")]
	public OGBEIILKDNM(Behaviour CNBJCJOALNK, float OMCHILFDFMG, [Optional] Action IFMJIHFFPPI, [Optional] KDPJBHDNKMB EENOGKEJBMD, [Optional] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x720D900", Offset = "0x720C100", VA = "0x18720D900", Slot = "9")]
	protected override bool EKBJPKNFGBL(Action ENGMCBPHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x720D7F0", Offset = "0x720BFF0", VA = "0x18720D7F0", Slot = "10")]
	protected override bool AFPNCJNBFKB(Action ENGMCBPHJGL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface LLDHOGPGHNI
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool IAOKINFFNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NIMFNDMBLGF;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LLILENKEDLI(bool AMNFMCIBNPO = false);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LLILENKEDLI(Action ENGMCBPHJGL, bool AMNFMCIBNPO = false);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public abstract class FBLILNPFBIB : LLDHOGPGHNI
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class BOPOGPGGHBB : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private JMPDKMJKKGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public FBLILNPFBIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public BOPOGPGGHBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x71F65A0", Offset = "0x71F4DA0", VA = "0x1871F65A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x71F6670", Offset = "0x71F4E70", VA = "0x1871F6670", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Behaviour CNBJCJOALNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action IFMJIHFFPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private HBGKBCMOMOE BAFBDOCDLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly KDPJBHDNKMB EENOGKEJBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	protected readonly LIIPOKLEFGD GEGBGPONHGL;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool IAOKINFFNAL
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xE91CD0", Offset = "0xE904D0", VA = "0x180E91CD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NIMFNDMBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x71FC090", Offset = "0x71FA890", VA = "0x1871FC090", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x71FC130", Offset = "0x71FA930", VA = "0x1871FC130", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x71FC410", Offset = "0x71FAC10", VA = "0x1871FC410")]
	protected FBLILNPFBIB(Behaviour CNBJCJOALNK, [Optional] Action IFMJIHFFPPI, [Optional] KDPJBHDNKMB EENOGKEJBMD, [Optional] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x71FBFD0", Offset = "0x71FA7D0", VA = "0x1871FBFD0", Slot = "7")]
	public bool LLILENKEDLI(bool AMNFMCIBNPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x71FC030", Offset = "0x71FA830", VA = "0x1871FC030", Slot = "8")]
	public bool LLILENKEDLI(Action ENGMCBPHJGL, bool AMNFMCIBNPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool EKBJPKNFGBL(Action ENGMCBPHJGL);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool AFPNCJNBFKB(Action ENGMCBPHJGL);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x71FBF70", Offset = "0x71FA770", VA = "0x1871FBF70")]
	protected void FKHPKIDDPCF(Action ENGMCBPHJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x71FC1D0", Offset = "0x71FA9D0", VA = "0x1871FC1D0")]
	protected OABICBNODGM OFGKMIEGPBF(float HIEBMCLPBGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x71FBE60", Offset = "0x71FA660", VA = "0x1871FBE60")]
	private void CGEPDHMIKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x71FBEE0", Offset = "0x71FA6E0", VA = "0x1871FBEE0")]
	[IteratorStateMachine(typeof(BOPOGPGGHBB))]
	private IEnumerator<JMPDKMJKKGA> ECHPKDMMNDJ(float HIEBMCLPBGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x71FBF90", Offset = "0x71FA790", VA = "0x1871FBF90")]
	[CompilerGenerated]
	private void LBENHLBMCNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class CFJLNPENHCE : FBLILNPFBIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float FPJOLABJCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly int IGCNOOKAODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float BFMBJEBPENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float[] ONKFACDJPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private int HHPIIGPPONB;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x71F6A90", Offset = "0x71F5290", VA = "0x1871F6A90")]
	public CFJLNPENHCE(Behaviour CNBJCJOALNK, float KANEHIICLBC, int IGCNOOKAODM, [Optional] Action IFMJIHFFPPI, float BFMBJEBPENO = 0f, [Optional] KDPJBHDNKMB EENOGKEJBMD, [Optional] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0", Slot = "9")]
	protected override bool EKBJPKNFGBL(Action ENGMCBPHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x71F6810", Offset = "0x71F5010", VA = "0x1871F6810", Slot = "10")]
	protected override bool AFPNCJNBFKB(Action ENGMCBPHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x71F6A10", Offset = "0x71F5210", VA = "0x1871F6A10")]
	private void GEGJAAEKGIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class IHNFHPLPIBI : FBLILNPFBIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly float OMCHILFDFMG;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7206960", Offset = "0x7205160", VA = "0x187206960")]
	public IHNFHPLPIBI(Behaviour CNBJCJOALNK, float OMCHILFDFMG, [Optional] Action IFMJIHFFPPI, [Optional] KDPJBHDNKMB EENOGKEJBMD, [Optional] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0", Slot = "9")]
	protected override bool EKBJPKNFGBL(Action ENGMCBPHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7206920", Offset = "0x7205120", VA = "0x187206920", Slot = "10")]
	protected override bool AFPNCJNBFKB(Action ENGMCBPHJGL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public sealed class NFODEPECADG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class FBEPCEKHODG : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private JMPDKMJKKGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public FBEPCEKHODG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x71F59E0", Offset = "0x71F41E0", VA = "0x1871F59E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x71FBE10", Offset = "0x71FA610", VA = "0x1871FBE10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private GOOHGCNPLOF HLKONDMKCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private BNDKJFEMLMG CNBJCJOALNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Action<float> NABJHDEPOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private NKLOKPDBJDH EHKPGKAHKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private float CHLOPLPLAJC;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x720BAD0", Offset = "0x720A2D0", VA = "0x18720BAD0")]
	public NFODEPECADG(BNDKJFEMLMG CNBJCJOALNK, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x720B750", Offset = "0x7209F50", VA = "0x18720B750")]
	private void KMBBNIEKLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x720B970", Offset = "0x720A170", VA = "0x18720B970")]
	private void PAJGNJAEKCG(string GGEHLADLJHF, Action OPJGMCDIFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x720B8F0", Offset = "0x720A0F0", VA = "0x18720B8F0")]
	[IteratorStateMachine(typeof(FBEPCEKHODG))]
	private IEnumerator<JMPDKMJKKGA> MBPCMIOAPKC(Action OPJGMCDIFJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x720B6F0", Offset = "0x7209EF0", VA = "0x18720B6F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x720B540", Offset = "0x7209D40", VA = "0x18720B540")]
	[CompilerGenerated]
	private void CHGCAAHALEB(string HBEPHPNHPNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class HJHAHAOKKNM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class ALIKJFKEMBG : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private JMPDKMJKKGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public ALIKJFKEMBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x71F59E0", Offset = "0x71F41E0", VA = "0x1871F59E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x71F5A50", Offset = "0x71F4250", VA = "0x1871F5A50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private GOOHGCNPLOF HLKONDMKCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private MonoBehaviour EIFNDIABMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Action IDBCFENKBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action<float> NABJHDEPOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private NKLOKPDBJDH EHKPGKAHKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private float CHLOPLPLAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool OKMCKCLHGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly KDPJBHDNKMB EENOGKEJBMD;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7200E70", Offset = "0x71FF670", VA = "0x187200E70")]
	public HJHAHAOKKNM(MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7201060", Offset = "0x71FF860", VA = "0x187201060")]
	public HJHAHAOKKNM(MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7200C20", Offset = "0x71FF420", VA = "0x187200C20")]
	public HJHAHAOKKNM(MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1BFB4F0", Offset = "0x1BF9CF0", VA = "0x181BFB4F0")]
	private HJHAHAOKKNM(KDPJBHDNKMB EENOGKEJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7200430", Offset = "0x71FEC30", VA = "0x187200430")]
	internal static HJHAHAOKKNM GPJLJPBNEGO(MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x72002C0", Offset = "0x71FEAC0", VA = "0x1872002C0")]
	private void FPLFFAIFCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7200560", Offset = "0x71FED60", VA = "0x187200560")]
	private void ICAFKBLEOFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7200830", Offset = "0x71FF030", VA = "0x187200830")]
	private void KMBBNIEKLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7200100", Offset = "0x71FE900", VA = "0x187200100")]
	private void EEEMKHLDHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7200AF0", Offset = "0x71FF2F0", VA = "0x187200AF0")]
	private void PAJGNJAEKCG(string GGEHLADLJHF, Action OPJGMCDIFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7200A70", Offset = "0x71FF270", VA = "0x187200A70")]
	[IteratorStateMachine(typeof(ALIKJFKEMBG))]
	private IEnumerator<JMPDKMJKKGA> MBPCMIOAPKC(Action OPJGMCDIFJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x72000A0", Offset = "0x71FE8A0", VA = "0x1872000A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7200010", Offset = "0x71FE810", VA = "0x187200010")]
	[CompilerGenerated]
	private void DLHOPFCHLFL(string HBEPHPNHPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7200710", Offset = "0x71FEF10", VA = "0x187200710")]
	[CompilerGenerated]
	private void JOFAJPJOLHJ(string HBEPHPNHPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x72007A0", Offset = "0x71FEFA0", VA = "0x1872007A0")]
	[CompilerGenerated]
	private void JPABAPABIIB(string HBEPHPNHPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x72009E0", Offset = "0x71FF1E0", VA = "0x1872009E0")]
	[CompilerGenerated]
	private void LNCCGKIABCI(string HBEPHPNHPNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[Flags]
internal enum OAAJKFGGKEL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal sealed class BAJNEHIKIIC : LIIPOKLEFGD
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float IOIJNMIIHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x71F63C0", Offset = "0x71F4BC0", VA = "0x1871F63C0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float KNOOFIBNBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x71F63B0", Offset = "0x71F4BB0", VA = "0x1871F63B0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double AMJPOMIJLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x71F63D0", Offset = "0x71F4BD0", VA = "0x1871F63D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x71F6340", Offset = "0x71F4B40", VA = "0x1871F6340")]
	[GDGALFJPCGE(JMIPDAHBNNG.None)]
	private static void CEJDNEABNOB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	[Preserve]
	internal BAJNEHIKIIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface MOAJGBJCCIC
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKPOOBMLFGL(string BHFPKCCDEEC);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJCDHLLHHCI();
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface CODIAPFGOPD
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool CKCBOLCFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool EMICDMPMLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal class ABBOJKOJFFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public IFGLAEILLBD OELHCGFHGDG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int LINJEMEJAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x8509A0", VA = "0x1808521A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851110", VA = "0x180852910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x71F4AE0", Offset = "0x71F32E0", VA = "0x1871F4AE0")]
	public static JMPDKMJKKGA CDPNMICCKHN(IEnumerator<JMPDKMJKKGA> EIJLCAJMEGF, NCLBBPBAMHF KEGEDGBLGGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x71F4C40", Offset = "0x71F3440", VA = "0x1871F4C40")]
	public JMPDKMJKKGA CDPNMICCKHN(NCLBBPBAMHF[] DBDNOEOCGDN, IEnumerator<JMPDKMJKKGA>[] OEGKMJGAGAF, JMPDKMJKKGA[] MCBPHILBEPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x71F4D00", Offset = "0x71F3500", VA = "0x1871F4D00")]
	public void GMGHFIFDHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x71F4D30", Offset = "0x71F3530", VA = "0x1871F4D30")]
	public void ODPBCFIFNBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x71F4E70", Offset = "0x71F3670", VA = "0x1871F4E70")]
	public void PODFLMIALEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x71F4D00", Offset = "0x71F3500", VA = "0x1871F4D00")]
	public void GINDKEMMJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public ABBOJKOJFFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class IFGLAEILLBD
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct EKNALJMIAOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public ABBOJKOJFFI KPHFNJMCGIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public BNDKJFEMLMG KGKMKOPPMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public NCLBBPBAMHF HBIKLDFHJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public IEnumerator<JMPDKMJKKGA> FLKPJCHDHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public JMPDKMJKKGA EKNDMFBLNDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public OAAJKFGGKEL HBHONFPLKIA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct MMCHNIODFHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public NKLOKPDBJDH LBANBNBHEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public List<EKNALJMIAOJ> MEDHOKBAMIC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class ODKKPMLFFBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public NCLBBPBAMHF promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IFGLAEILLBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public BNDKJFEMLMG context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public ABBOJKOJFFI routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public OAAJKFGGKEL coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public JMPDKMJKKGA currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public IEnumerator<JMPDKMJKKGA> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public ODKKPMLFFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x720CD40", Offset = "0x720B540", VA = "0x18720CD40")]
		internal void DJHBHHEODLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class PJECEIFBODK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public ABBOJKOJFFI schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public IFGLAEILLBD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public PJECEIFBODK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x720FE30", Offset = "0x720E630", VA = "0x18720FE30")]
		internal void NNJGBBPGBEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class MGJIHEDDDIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public ABBOJKOJFFI schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public IFGLAEILLBD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public MGJIHEDDDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x720ACB0", Offset = "0x72094B0", VA = "0x18720ACB0")]
		internal void LOCKCHNMEGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class IEPOGJACGPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public ABBOJKOJFFI schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public IFGLAEILLBD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public IEPOGJACGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7202FD0", Offset = "0x72017D0", VA = "0x187202FD0")]
		internal void KNBCCLMONKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const OAAJKFGGKEL ACIFKBDDJCL = OAAJKFGGKEL.Cancelled | OAAJKFGGKEL.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly NKLOKPDBJDH EHKPGKAHKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool[] POEPGCKPEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<OAAJKFGGKEL> EGPPCJKANLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<float> DJHIKLDGIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> CDEJEAFHJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> DFDLCELIDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> NOBHFAHHAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> FKAHHGOBGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> JDPOJNHCBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private ABBOJKOJFFI[] FGMFFCFALEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private NCLBBPBAMHF[] DBDNOEOCGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private BNDKJFEMLMG[] KEFMPICNNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IEnumerator<JMPDKMJKKGA>[] BGIJLCLPPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private JMPDKMJKKGA[] FAOBFGKDBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int IAHGJGCOAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int HHGNDILCLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly int AHECCPJHEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float LGIDHPCDCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private IKFCPIOOIDK JHBJNGOLAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private JobHandle AMEOKIBPPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<ABBOJKOJFFI> JBNPFLFMJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool PACDOCAKHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private List<Action> KMKGKGKKBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> LJLDENOKEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private bool KEPMKGNJNOJ;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public MMCHNIODFHE[] GGOEGLIDNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF90", Offset = "0x8BD790", VA = "0x1808BEF90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x72048A0", Offset = "0x72030A0", VA = "0x1872048A0")]
	private static int MKPPMLNGCJG(NKLOKPDBJDH EHKPGKAHKKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7205370", Offset = "0x7203B70", VA = "0x187205370")]
	public IFGLAEILLBD(NKLOKPDBJDH EHKPGKAHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7203AB0", Offset = "0x72022B0", VA = "0x187203AB0")]
	private void HDOAFLAHLPG(int FABKPEEAHMB, int FABKOFGFJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7203C90", Offset = "0x7202490", VA = "0x187203C90")]
	public void JNJINNMJHHP(BNDKJFEMLMG CNBJCJOALNK, JMPDKMJKKGA PBLNBIDNEIN, IEnumerator<JMPDKMJKKGA> EIJLCAJMEGF, NCLBBPBAMHF KEGEDGBLGGL, [Optional] ABBOJKOJFFI GLKOPLCPHJM, OAAJKFGGKEL JANJEJNBMBD = OAAJKFGGKEL.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7203870", Offset = "0x7202070", VA = "0x187203870")]
	public void HDMLFENMIIH(IEnumerable<EKNALJMIAOJ> ODFJEHIJKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7204B00", Offset = "0x7203300", VA = "0x187204B00")]
	private EKNALJMIAOJ ONMCKDLEDBH(int JHHJHBCLCCJ)
	{
		return default(EKNALJMIAOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7203010", Offset = "0x7201810", VA = "0x187203010")]
	private void ECCEHINHHIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BE00", Offset = "0x2B7A600", VA = "0x182B7BE00")]
	private static void LNKKOMPNDOA<T>(int JHHJHBCLCCJ, T[] IHOJEMLHKFM, int ECGAAJFODGN, [Optional] T ELEPHPKCELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BE50", Offset = "0x2B7A650", VA = "0x182B7BE50")]
	private static void LNKKOMPNDOA<T>(int JHHJHBCLCCJ, NativeArray<T> IHOJEMLHKFM, int ECGAAJFODGN, [Optional] T ELEPHPKCELN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7204FD0", Offset = "0x72037D0", VA = "0x187204FD0")]
	private void PHJMOAGLDLI(IEnumerable<EKNALJMIAOJ> ODFJEHIJKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7203680", Offset = "0x7201E80", VA = "0x187203680")]
	private void FBCKHPDMDCE(EKNALJMIAOJ AFIEEBJNELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7204640", Offset = "0x7202E40", VA = "0x187204640")]
	private MOABMEILMEH MABMKGGMFPK(int DHDFALGOKLI)
	{
		return default(MOABMEILMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7203480", Offset = "0x7201C80", VA = "0x187203480")]
	public void EKKBOLGADGM(float KBAMMELOGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7204A80", Offset = "0x7203280", VA = "0x187204A80")]
	private void OBACGHPDCHL(Action MLFGLJKBOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x72048D0", Offset = "0x72030D0", VA = "0x1872048D0")]
	private void MMBHBBCIPND(Action MLFGLJKBOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7203F40", Offset = "0x7202740", VA = "0x187203F40")]
	public void LFAGPFKGJEE(float KBAMMELOGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7203380", Offset = "0x7201B80", VA = "0x187203380")]
	public void EECPCLJADFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7203740", Offset = "0x7201F40", VA = "0x187203740")]
	public void GINDKEMMJIL(ABBOJKOJFFI DKNNEBCHBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7204950", Offset = "0x7203150", VA = "0x187204950")]
	public void NICGIFDENMA(ABBOJKOJFFI DKNNEBCHBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7203E10", Offset = "0x7202610", VA = "0x187203E10")]
	public void KALKHLAAAJF(ABBOJKOJFFI DKNNEBCHBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class FCPGJGEBLCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static readonly FCPGJGEBLCK ENKECPBOOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Action BDILBDIGJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool MAFFMBBADNE;

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8519E0", VA = "0x1808531E0")]
	public FCPGJGEBLCK(Action BDILBDIGJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x69AD350", Offset = "0x69ABB50", VA = "0x1869AD350", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface NLIFGMIPBIB<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T JNHPIMBJPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable HIFMEIAAFOH(UnityEngine.Object CNBJCJOALNK, Action<T> NANKILKEHAL);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface NHEEEANKMEK<T> : NLIFGMIPBIB<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T JNHPIMBJPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class BLJCLDFLDND<T> : NHEEEANKMEK<T>, NLIFGMIPBIB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class DELOAJBDMKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public BLJCLDFLDND<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public KKNLDOICDLK<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public DELOAJBDMKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x57448D0", Offset = "0x57430D0", VA = "0x1857448D0")]
		internal void BIAFMBALCPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static GameObject DKHCCOLEDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly List<KKNLDOICDLK<UnityEngine.Object, Action<T>>> FPCBFONNOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private T AHKLOFMOCNN;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T JNHPIMBJPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x91FDA0", Offset = "0x91E5A0", VA = "0x18091FDA0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4E3BE50", Offset = "0x4E3A650", VA = "0x184E3BE50", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4E3BCB0", Offset = "0x4E3A4B0", VA = "0x184E3BCB0")]
	private static bool JKONKPFGDNM(T MLFGLJKBOIG, T GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4E3BEF0", Offset = "0x4E3A6F0", VA = "0x184E3BEF0")]
	public BLJCLDFLDND(T KLDLAHEBNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B950", Offset = "0x4E3A150", VA = "0x184E3B950", Slot = "6")]
	public IDisposable HIFMEIAAFOH(UnityEngine.Object CNBJCJOALNK, Action<T> NANKILKEHAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B630", Offset = "0x4E39E30", VA = "0x184E3B630")]
	private void DMAAOIIKLAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class AGIBCGMFBLL : BLNDMJDCEPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly KDPJBHDNKMB EENOGKEJBMD;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x71F58C0", Offset = "0x71F40C0", VA = "0x1871F58C0")]
	[GDGALFJPCGE(JMIPDAHBNNG.None)]
	private static void CEJDNEABNOB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8519E0", VA = "0x1808531E0")]
	[Preserve]
	internal AGIBCGMFBLL([OMAPKKAGFIL(null)] KDPJBHDNKMB EENOGKEJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x71F5930", Offset = "0x71F4130", VA = "0x1871F5930", Slot = "4")]
	public IDisposable JPJCGNANANK(float NPEJJPOODJL, Action<float> HBBMMHKOEKK, bool OKMCKCLHGJF = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class ICHGKLBBNIP : IOMCJGKMHHO, KDPJBHDNKMB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private IFGLAEILLBD[] MDPJLPPBPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private MOAJGBJCCIC KAOPHHKHBPO;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x72018A0", Offset = "0x72000A0", VA = "0x1872018A0")]
	[GDGALFJPCGE(JMIPDAHBNNG.None)]
	private static void CEJDNEABNOB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x72021C0", Offset = "0x72009C0", VA = "0x1872021C0")]
	[Preserve]
	public ICHGKLBBNIP([OMAPKKAGFIL(null)] IHCGHJBEAFE CBHFJINNKJG, [OMAPKKAGFIL(null)] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7201620", Offset = "0x71FFE20", VA = "0x187201620", Slot = "17")]
	public override GOOHGCNPLOF AAIGGIEKNJG(BNDKJFEMLMG CNBJCJOALNK, IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7201C70", Offset = "0x7200470", VA = "0x187201C70", Slot = "18")]
	public override void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7201970", Offset = "0x7200170", VA = "0x187201970", Slot = "20")]
	public override void FMEAIHHBFHB(NKLOKPDBJDH EHKPGKAHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7201BA0", Offset = "0x72003A0", VA = "0x187201BA0", Slot = "19")]
	protected override void LHGGKPHIKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7201750", Offset = "0x71FFF50", VA = "0x187201750")]
	private IFGLAEILLBD BJPNJJEGNAC(NKLOKPDBJDH NCMHJNKFAGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7201F10", Offset = "0x7200710", VA = "0x187201F10", Slot = "21")]
	internal override APIAJIDAPLD NMBKKAAPNEO(IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM, Behaviour CNBJCJOALNK, NCLBBPBAMHF KEGEDGBLGGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7202140", Offset = "0x7200940", VA = "0x187202140", Slot = "22")]
	internal override GKEDDHBBPHF OOFEIFMFNLH(NKLOKPDBJDH OHHDHLEHJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7201780", Offset = "0x71FFF80", VA = "0x187201780")]
	private void BNLGAKGCPLD(IFGLAEILLBD LILJLJFDBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7201910", Offset = "0x7200110", VA = "0x187201910", Slot = "23")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[BurstCompile]
internal struct IKFCPIOOIDK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	public float CDBPGJJNNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	public int NKIINBFMECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NativeArray<int> PJJPFCOKHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private NativeArray<int> EDNHBKHPHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> IHLLKDEEELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	public NativeArray<OAAJKFGGKEL> LDJKGEHFNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	public NativeArray<float> EIAOOEEAAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[WriteOnly]
	public NativeArray<int> NOBHFAHHAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[WriteOnly]
	public NativeArray<int> CDEJEAFHJHO;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7206E80", Offset = "0x7205680", VA = "0x187206E80")]
	public static IKFCPIOOIDK JGIIBNEOBDO(int IPINNKDPCLL, float KBAMMELOGGL, NativeArray<OAAJKFGGKEL> BFFKIAEGOLD, NativeArray<float> CMFFPDILCKI, NativeArray<int> FLEPCEHBPAK, NativeArray<int> CCDJPKJIAOM, NativeArray<int> JJFOHCPBBBA, NativeArray<int> EDNHBKHPHEL, NativeArray<int> IHLLKDEEELK)
	{
		return default(IKFCPIOOIDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7206B30", Offset = "0x7205330", VA = "0x187206B30", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7206F80", Offset = "0x7205780", VA = "0x187206F80")]
	private bool LKGOBOJDMIG(int DHNLEFJCEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7206C10", Offset = "0x7205410", VA = "0x187206C10")]
	private void FPGONOMCGMO(NativeArray<int> GHJMPEDKGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7206EE0", Offset = "0x72056E0", VA = "0x187206EE0")]
	private int KNDCNKKKJND(int IGFCIJKKLLO, int CFBPCIPAGLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7206A60", Offset = "0x7205260", VA = "0x187206A60")]
	private void AJAPKNMPFKL(NativeArray<int> GHJMPEDKGHI, int LODIOKPFBJE, int DLFEHJOHIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7206C40", Offset = "0x7205440", VA = "0x187206C40")]
	private void JBEHINGHLPF(NativeArray<int> GHJMPEDKGHI, int LHIFPPJJFEO, int AJCKJNJBBPO, int BBDLOLBHKAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class IOMCJGKMHHO : KDPJBHDNKMB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly IHCGHJBEAFE CBHFJINNKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	protected readonly LIIPOKLEFGD GEGBGPONHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private GKEDDHBBPHF[] FIEPLOPLPJA;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static KDPJBHDNKMB MJFJCBEEADM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7207310", Offset = "0x7205B10", VA = "0x187207310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool HPJBMFGHLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BDA0", VA = "0x18086D5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NKLOKPDBJDH BEABEPCNLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x8509A0", VA = "0x1808521A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(NKLOKPDBJDH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851110", VA = "0x180852910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public LIIPOKLEFGD JBFLLCIBMLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public JMPDKMJKKGA EPEBMPAEFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public JMPDKMJKKGA NBFFMJNHMLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x856AB0", Offset = "0x8552B0", VA = "0x180856AB0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7207CD0", Offset = "0x72064D0", VA = "0x187207CD0")]
	public static GOOHGCNPLOF NAAFBKAMHFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7208020", Offset = "0x7206820", VA = "0x187208020")]
	[Preserve]
	protected IOMCJGKMHHO([OMAPKKAGFIL(null)] IHCGHJBEAFE CBHFJINNKJG, [OMAPKKAGFIL(null)] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x72070E0", Offset = "0x72058E0", VA = "0x1872070E0", Slot = "6")]
	public GOOHGCNPLOF AGALHLJOLPH(IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x72070F0", Offset = "0x72058F0", VA = "0x1872070F0", Slot = "7")]
	public GOOHGCNPLOF AGALHLJOLPH(Behaviour CNBJCJOALNK, IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract GOOHGCNPLOF AAIGGIEKNJG(BNDKJFEMLMG CNBJCJOALNK, IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7207B30", Offset = "0x7206330", VA = "0x187207B30", Slot = "18")]
	public virtual void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7207DC0", Offset = "0x72065C0", VA = "0x187207DC0", Slot = "9")]
	public void OPIEDMMDNAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7207B10", Offset = "0x7206310", VA = "0x187207B10", Slot = "19")]
	protected virtual void LHGGKPHIKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7208000", Offset = "0x7206800", VA = "0x187208000")]
	private void PLGKALAENJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7207AD0", Offset = "0x72062D0", VA = "0x187207AD0")]
	private void JIKEKNHPFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7207AF0", Offset = "0x72062F0", VA = "0x187207AF0")]
	private void LFENBOKJKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7207720", Offset = "0x7205F20", VA = "0x187207720")]
	private void ECEIDBDCEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x72072F0", Offset = "0x7205AF0", VA = "0x1872072F0")]
	private void BACFBLGCIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7207AB0", Offset = "0x72062B0", VA = "0x187207AB0")]
	private void GHJBHFHJJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7207970", Offset = "0x7206170", VA = "0x187207970")]
	private void FBPDICHEEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7207990", Offset = "0x7206190", VA = "0x187207990", Slot = "20")]
	public virtual void FMEAIHHBFHB(NKLOKPDBJDH EHKPGKAHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7207740", Offset = "0x7205F40", VA = "0x187207740")]
	private void EKBIOCDPDCC(GKEDDHBBPHF LILJLJFDBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF940", Offset = "0x1EBE140", VA = "0x181EBF940")]
	private GKEDDHBBPHF GPNJIMJDMLH(NKLOKPDBJDH NCMHJNKFAGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract APIAJIDAPLD NMBKKAAPNEO(IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM, Behaviour EIFNDIABMHD, NCLBBPBAMHF BCFDANNEBLN);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract GKEDDHBBPHF OOFEIFMFNLH(NKLOKPDBJDH EHKPGKAHKKL);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7207360", Offset = "0x7205B60", VA = "0x187207360", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7207D60", Offset = "0x7206560", VA = "0x187207D60", Slot = "13")]
	public JMPDKMJKKGA OENNPNHBBJC(NKLOKPDBJDH OHHDHLEHJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7207A20", Offset = "0x7206220", VA = "0x187207A20", Slot = "14")]
	public JMPDKMJKKGA GEADBELPKFM(float IOCCJIJEELD, NKLOKPDBJDH OHHDHLEHJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7207910", Offset = "0x7206110", VA = "0x187207910", Slot = "15")]
	public JMPDKMJKKGA ELHKCFMPECG(Func<bool> NGPBJNKHNBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class APIAJIDAPLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly NCLBBPBAMHF KEGEDGBLGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly CODIAPFGOPD CNBJCJOALNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly bool MNPHCAAFMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private string BHFPKCCDEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private StackTrace AHDKPNBDPPD;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerator<JMPDKMJKKGA> FLKPJCHDHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x8518F0", VA = "0x1808530F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public JMPDKMJKKGA EKNDMFBLNDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851090", VA = "0x180852890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool JBJPGJHFCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x71F5FB0", Offset = "0x71F47B0", VA = "0x1871F5FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool ONJMHJBJGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9E6690", Offset = "0x9E4E90", VA = "0x1809E6690")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9E67B0", Offset = "0x9E4FB0", VA = "0x1809E67B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x71F5AA0", Offset = "0x71F42A0", VA = "0x1871F5AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float LFOBCGIPDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8BF240", Offset = "0x8BDA40", VA = "0x1808BF240")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B370", Offset = "0x5E59B70", VA = "0x185E5B370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x71F6180", Offset = "0x71F4980", VA = "0x1871F6180")]
	public APIAJIDAPLD(IEnumerator<JMPDKMJKKGA> EIJLCAJMEGF, CODIAPFGOPD CNBJCJOALNK, NCLBBPBAMHF KEGEDGBLGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x71F5C50", Offset = "0x71F4450", VA = "0x1871F5C50")]
	public JMPDKMJKKGA CDPNMICCKHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x71F6030", Offset = "0x71F4830", VA = "0x1871F6030")]
	public bool NGGPFPHINMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x71F5F60", Offset = "0x71F4760", VA = "0x1871F5F60")]
	public void GINDKEMMJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x71F60A0", Offset = "0x71F48A0", VA = "0x1871F60A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA73A50", Offset = "0xA72250", VA = "0x180A73A50")]
	[CompilerGenerated]
	private void MMGLCONHEKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class NCLBBPBAMHF : FKLBBJCBHCC, GOOHGCNPLOF, HBGKBCMOMOE, OABICBNODGM, IEnumerator, JMPDKMJKKGA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private NKLOKPDBJDH AOOAOBILAJD;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private NKLOKPDBJDH PNBJOONMBAM
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x101C890", Offset = "0x101B090", VA = "0x18101C890", Slot = "23")]
		get
		{
			return default(NKLOKPDBJDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NKLOKPDBJDH OELHCGFHGDG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x15514D0", Offset = "0x154FCD0", VA = "0x1815514D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private float ONAEKNIHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA115F0", Offset = "0xA0FDF0", VA = "0x180A115F0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool JIDFDPNJHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x720B420", Offset = "0x7209C20", VA = "0x18720B420", Slot = "24")]
	private bool FEHOLLONLMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x720B410", Offset = "0x7209C10", VA = "0x18720B410", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x720B440", Offset = "0x7209C40", VA = "0x18720B440")]
	public NCLBBPBAMHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal enum MOABMEILMEH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal sealed class GKEDDHBBPHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum BIDGGHOMLOD
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public struct EIPBBNGHMHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public NKLOKPDBJDH LBANBNBHEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public BIDGGHOMLOD EGFNIHOCAAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<APIAJIDAPLD> ABAADMMKBCM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly BIDGGHOMLOD[] CBKGKDIHIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly NKLOKPDBJDH EHKPGKAHKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private bool IOKHIMKLJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly APIAJIDAPLD[] JJPNGCKMOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<APIAJIDAPLD> BAFGHFFAPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<int> NOPJFEIAEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly List<APIAJIDAPLD> EHHDEBEAGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Stack<int> IDBBKFDOIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly MOAJGBJCCIC HIBDLNMCMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private bool KEPMKGNJNOJ;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public EIPBBNGHMHP[,] KEMPACPFDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8569D0", Offset = "0x8551D0", VA = "0x1808569D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x71FE800", Offset = "0x71FD000", VA = "0x1871FE800")]
	public GKEDDHBBPHF(NKLOKPDBJDH OHHDHLEHJDL, MOAJGBJCCIC HIBDLNMCMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x71FD800", Offset = "0x71FC000", VA = "0x1871FD800")]
	public void GNHGIFNNAPC(APIAJIDAPLD EIJLCAJMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x71FD3E0", Offset = "0x71FBBE0", VA = "0x1871FD3E0")]
	public void AFAACFHELFH(IList<APIAJIDAPLD> OEGKMJGAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x71FDF00", Offset = "0x71FC700", VA = "0x1871FDF00")]
	public void MHKICLCBKMA(IList<APIAJIDAPLD> OEGKMJGAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x71FD2F0", Offset = "0x71FBAF0", VA = "0x1871FD2F0")]
	private void AEOHMEFFKEG(APIAJIDAPLD EIJLCAJMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x71FE200", Offset = "0x71FCA00", VA = "0x1871FE200")]
	private void MHLBIFJCCGO(IList<APIAJIDAPLD> OEGKMJGAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x71FD910", Offset = "0x71FC110", VA = "0x1871FD910")]
	private MOABMEILMEH HCKBAMIAOJE(APIAJIDAPLD EIJLCAJMEGF)
	{
		return default(MOABMEILMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x71FDA90", Offset = "0x71FC290", VA = "0x1871FDA90")]
	public void LHGGKPHIKGE(float KBAMMELOGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x71FE4D0", Offset = "0x71FCCD0", VA = "0x1871FE4D0")]
	public void OPIEDMMDNAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x71FDC00", Offset = "0x71FC400", VA = "0x1871FDC00")]
	private void MCAHMGGFHDG(List<APIAJIDAPLD> OEGKMJGAGAF, Stack<int> PANADDMBAOL, bool ADAFGDHBPEA, float FHBFPMOOFPA = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x71FD6E0", Offset = "0x71FBEE0", VA = "0x1871FD6E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x71FE390", Offset = "0x71FCB90", VA = "0x1871FE390")]
	private void NPFNKPKAMHJ(List<APIAJIDAPLD> OEGKMJGAGAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class AEDPFLPPAOP : MOAJGBJCCIC
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "4")]
	public void NKPOOBMLFGL(string BHFPKCCDEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
	public void HJCDHLLHHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public AEDPFLPPAOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class CCPPKDGBFLK : CODIAPFGOPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly Behaviour EIFNDIABMHD;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x71F66C0", Offset = "0x71F4EC0", VA = "0x1871F66C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool CKCBOLCFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x71F6760", Offset = "0x71F4F60", VA = "0x1871F6760", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool EMICDMPMLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x71F6740", Offset = "0x71F4F40", VA = "0x1871F6740", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8519E0", VA = "0x1808531E0")]
	public CCPPKDGBFLK(Behaviour EIFNDIABMHD)
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

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
				[Cpp2IlInjected.Address(RVA = "0x71FC620", Offset = "0x71FB020", VA = "0x1871FC620")]
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
				[Cpp2IlInjected.Address(RVA = "0x7210880", Offset = "0x720F280", VA = "0x187210880")]
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
				[Cpp2IlInjected.Address(RVA = "0x720B050", Offset = "0x7209A50", VA = "0x18720B050")]
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
				[Cpp2IlInjected.Address(RVA = "0x720B7D0", Offset = "0x720A1D0", VA = "0x18720B7D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x71FB570", Offset = "0x71F9F70", VA = "0x1871FB570")]
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
				[Cpp2IlInjected.Address(RVA = "0x720DF10", Offset = "0x720C910", VA = "0x18720DF10")]
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
				[Cpp2IlInjected.Address(RVA = "0x72098C0", Offset = "0x72082C0", VA = "0x1872098C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x71F60D0", Offset = "0x71F4AD0", VA = "0x1871F60D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x720C850", Offset = "0x720B250", VA = "0x18720C850")]
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
				[Cpp2IlInjected.Address(RVA = "0x71FF6C0", Offset = "0x71FE0C0", VA = "0x1871FF6C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x720BAC0", Offset = "0x720A4C0", VA = "0x18720BAC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x71FBD50", Offset = "0x71FA750", VA = "0x1871FBD50")]
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
				[Cpp2IlInjected.Address(RVA = "0x7209BF0", Offset = "0x72085F0", VA = "0x187209BF0")]
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
					[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
					public NEKFGLJFHCO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x720BEA0", Offset = "0x720A8A0", VA = "0x18720BEA0")]
					internal void HFBBLIKFFKO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static ODIOBOMGOFD<JMAFADCBMHD> KJAFGPHCMOJ;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x720E660", Offset = "0x720D060", VA = "0x18720E660")]
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
					[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
					public OIKJMFGDKOH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x720E420", Offset = "0x720CE20", VA = "0x18720E420")]
					internal void HBHDOLLNKMN()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable LOBIMOBOKNH;

				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x7209AC0", Offset = "0x72084C0", VA = "0x187209AC0")]
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
					[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
					public IGNDOKCKIDP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x72063D0", Offset = "0x7204DD0", VA = "0x1872063D0")]
					internal void HBHDOLLNKMN()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x71F5D70", Offset = "0x71F4770", VA = "0x1871F5D70")]
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
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public ILGODGJOGFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x72079D0", Offset = "0x72063D0", VA = "0x1872079D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x71F7800", Offset = "0x71F6200", VA = "0x1871F7800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71F8380", Offset = "0x71F6D80", VA = "0x1871F8380")]
		private static void CMGNAMFCNHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x71F7840", Offset = "0x71F6240", VA = "0x1871F7840")]
		private static void AJHMJPGFINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x71F8150", Offset = "0x71F6B50", VA = "0x1871F8150")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71F7640", Offset = "0x71F6040", VA = "0x1871F7640")]
		private static void AADEKNNGMIH(HBJHILMNFNM.PJCJAABLALM NDDCLPHCEEO, PlayerLoopSystem FIEPEONNCHO, Type LGHOJPKHNPH, Type CEMPJLJPAJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71FAF80", Offset = "0x71F9980", VA = "0x1871FAF80")]
		private static void EJMIPDPCBEK(PlayerLoopSystem FIEPEONNCHO, Type LGHOJPKHNPH, Type CEMPJLJPAJC, NLIFKBEAHKD HMOMBLFCJEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71FB360", Offset = "0x71F9D60", VA = "0x1871FB360")]
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
		[Cpp2IlInjected.Address(RVA = "0x71FBC40", Offset = "0x71FA640", VA = "0x1871FBC40")]
		public EINLPOIECMH(PJCJAABLALM CLJGKKPNDMB, int GOIGGDADOPG = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x71FB9F0", Offset = "0x71FA3F0", VA = "0x1871FB9F0")]
		public void FIFEAJLOGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x71FB9A0", Offset = "0x71FA3A0", VA = "0x1871FB9A0")]
		public void EANCDEHLLBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x71FBA60", Offset = "0x71FA460", VA = "0x1871FBA60")]
		public void MOEBIHHDKJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static PJCJAABLALM[] IBBJDCHJGIJ;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static EINLPOIECMH[] FJANKDEPIDM;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7200590", Offset = "0x71FEF90", VA = "0x187200590")]
	public static EINLPOIECMH MPMOMMIKNFH(PJCJAABLALM NDDCLPHCEEO, int GOIGGDADOPG = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7200480", Offset = "0x71FEE80", VA = "0x187200480")]
	public static EINLPOIECMH DFPLDKFEPEA(PJCJAABLALM NDDCLPHCEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72004F0", Offset = "0x71FEEF0", VA = "0x1872004F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x720D040", Offset = "0x720BA40", VA = "0x18720D040", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double EFFHEIKNDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1A63900", Offset = "0x1A62300", VA = "0x181A63900", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double JEGNKKKIMIH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1F60500", Offset = "0x1F5EF00", VA = "0x181F60500", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x720D230", Offset = "0x720BC30", VA = "0x18720D230")]
	public OBGBLLAPIPM(int AKMPLLNJJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x720D0A0", Offset = "0x720BAA0", VA = "0x18720D0A0", Slot = "7")]
	public void BFDAFNAMENP(double GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x720D1C0", Offset = "0x720BBC0", VA = "0x18720D1C0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double EFFHEIKNDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E60890", Offset = "0x5E5F290", VA = "0x185E60890", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JEGNKKKIMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E60860", Offset = "0x5E5F260", VA = "0x185E60860", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double GGINOPFDKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E60870", Offset = "0x5E5F270", VA = "0x185E60870")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FNDHIEMGBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x25531C0", Offset = "0x2551BC0", VA = "0x1825531C0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x720BCC0", Offset = "0x720A6C0", VA = "0x18720BCC0", Slot = "7")]
	public virtual void BFDAFNAMENP(double GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x720BDE0", Offset = "0x720A7E0", VA = "0x18720BDE0", Slot = "8")]
	public virtual void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7209890", Offset = "0x7208290", VA = "0x187209890")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E608D0", Offset = "0x5E5F2D0", VA = "0x185E608D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5E60D30", Offset = "0x5E5F730", VA = "0x185E60D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7209720", Offset = "0x7208120", VA = "0x187209720", Slot = "7")]
	public override void BFDAFNAMENP(double GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7209850", Offset = "0x7208250", VA = "0x187209850", Slot = "8")]
	public override void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7209890", Offset = "0x7208290", VA = "0x187209890")]
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
			[Cpp2IlInjected.Address(RVA = "0x42544C0", Offset = "0x4252EC0", VA = "0x1842544C0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool CNBAGEGEKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x42543E0", Offset = "0x4252DE0", VA = "0x1842543E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85DA50", VA = "0x18085F050")]
		protected LGPEBNOIJDD(TPromise ABCAKOKMCGB, TMainThreadPromise IMLNINNKANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x42544A0", Offset = "0x4252EA0", VA = "0x1842544A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BDA1B0", Offset = "0x3BD8BB0", VA = "0x183BDA1B0")]
		public FHHOLNIBMCP(MAKKFMNHCEA<T> ABCAKOKMCGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3BDA060", Offset = "0x3BD8A60", VA = "0x183BDA060", Slot = "6")]
		protected override void JHNBPHKGJMA(MAKKFMNHCEA<T> ABCAKOKMCGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3B71440", Offset = "0x3B6FE40", VA = "0x183B71440")]
		[CompilerGenerated]
		private void HGFCPENBBFB(T ADPMAHMCGNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3BDA010", Offset = "0x3BD8A10", VA = "0x183BDA010")]
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
			[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BFA0", VA = "0x18086D5A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
		public OGIGKMBFEKL(Action ENGMCBPHJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x92AEA0", Offset = "0x9298A0", VA = "0x18092AEA0", Slot = "5")]
		public void LCJDPHEAJHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<HIMKIOBGHBI> CDCCEEHDIPI;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBA50", Offset = "0x2BBA450", VA = "0x182BBBA50")]
	public static MAKKFMNHCEA<T> KECGLJMIBIM<T>(this MAKKFMNHCEA<T> ABCAKOKMCGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7209210", Offset = "0x7207C10", VA = "0x187209210")]
	public static void KECGLJMIBIM(Action ENGMCBPHJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB960", Offset = "0x2BBA360", VA = "0x182BBB960")]
	private static MAKKFMNHCEA<T> BHPAPPPAAHN<T>(MAKKFMNHCEA<T> ABCAKOKMCGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7208F20", Offset = "0x7207920", VA = "0x187208F20")]
	private static void FAOGNJAODOK(HIMKIOBGHBI PLNECBEGJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72092B0", Offset = "0x7207CB0", VA = "0x1872092B0")]
	private static void MFBPBNBPLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7209590", Offset = "0x7207F90", VA = "0x187209590")]
	private static void PCJNDIGNGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7209130", Offset = "0x7207B30", VA = "0x187209130")]
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
		[Cpp2IlInjected.Address(RVA = "0x71F71C0", Offset = "0x71F5BC0", VA = "0x1871F71C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x720A740", Offset = "0x7209140", VA = "0x18720A740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x720AFE0", Offset = "0x72099E0", VA = "0x18720AFE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7201CB0", Offset = "0x72006B0", VA = "0x187201CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7201FD0", Offset = "0x72009D0", VA = "0x187201FD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x720B2B0", Offset = "0x7209CB0", VA = "0x18720B2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x720B660", Offset = "0x720A060", VA = "0x18720B660", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public LLDKLMINPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x720B250", Offset = "0x7209C50", VA = "0x18720B250")]
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
		[Cpp2IlInjected.Address(RVA = "0x7202DD0", Offset = "0x72017D0", VA = "0x187202DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7203970", Offset = "0x7202370", VA = "0x187203970", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7210220", Offset = "0x720EC20", VA = "0x187210220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x72106F0", Offset = "0x720F0F0", VA = "0x1872106F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x71FF8C0", Offset = "0x71FE2C0", VA = "0x1871FF8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7200410", Offset = "0x71FEE10", VA = "0x187200410", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public NFFPMNFBOMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x720BF20", Offset = "0x720A920", VA = "0x18720BF20")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public OCONHDPIMKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x720D6C0", Offset = "0x720C0C0", VA = "0x18720D6C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x720D330", Offset = "0x720BD30", VA = "0x18720D330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x720D2E0", Offset = "0x720BCE0", VA = "0x18720D2E0")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x720D670", Offset = "0x720C070", VA = "0x18720D670", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public IHFJEFBOJGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7206640", Offset = "0x7205040", VA = "0x187206640")]
		internal bool EJLKEGDFKNC(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x72066C0", Offset = "0x72050C0", VA = "0x1872066C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public EMELHLEAEOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x71FBF50", Offset = "0x71FA950", VA = "0x1871FBF50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x71FC5D0", Offset = "0x71FAFD0", VA = "0x1871FC5D0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x720E930", Offset = "0x720D330", VA = "0x18720E930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool OGIKOAOMDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x720EC60", Offset = "0x720D660", VA = "0x18720EC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool BCIDPCNFKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x720F6F0", Offset = "0x720E0F0", VA = "0x18720F6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool LGKCGEDEHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x720EF00", Offset = "0x720D900", VA = "0x18720EF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> BFBAPNGEAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x720EF90", Offset = "0x720D990", VA = "0x18720EF90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x720EB50", Offset = "0x720D550", VA = "0x18720EB50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x720F4D0", Offset = "0x720DED0", VA = "0x18720F4D0")]
	[JIDCLHKIDAF(KJECFEIFJAL.EnteredEditModeNextFrame, 0)]
	private static void HBDKKCKICPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x720F790", Offset = "0x720E190", VA = "0x18720F790")]
	[AsyncStateMachine(typeof(KKCOBPIJFLE))]
	public static Task<Scene> JLCDFILIOPA(string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN = LoadSceneMode.Single, bool DNHNFCFHHHN = false, [Optional] OADONCMLPJG<string>.HILOONJJDHL NPJBMNGDLMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x720F8E0", Offset = "0x720E2E0", VA = "0x18720F8E0")]
	[AsyncStateMachine(typeof(HMMAHMNDFBI))]
	private static Task LAGBELIAIJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x720FB10", Offset = "0x720E510", VA = "0x18720FB10")]
	[AsyncStateMachine(typeof(LPGKJKHLIOE))]
	private static Task LPGCMPGJHCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x720F270", Offset = "0x720DC70", VA = "0x18720F270")]
	[AsyncStateMachine(typeof(IEKCBGDNHMI))]
	private static Task<Scene> GCPPFDOOLPP(string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN, bool DNHNFCFHHHN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x720E830", Offset = "0x720D230", VA = "0x18720E830")]
	private static void BEFKDBKNAOF(SceneInstance BOLGDNNEFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x720ED00", Offset = "0x720D700", VA = "0x18720ED00")]
	private static void DDCDNIOJGEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x720F5D0", Offset = "0x720DFD0", VA = "0x18720F5D0")]
	[AsyncStateMachine(typeof(OOAMJCMEGBF))]
	private static Task<Scene> HGJAOHEILEM(string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x720FBE0", Offset = "0x720E5E0", VA = "0x18720FBE0")]
	private static bool NKOACHODLDP(string OAAJEIOFMBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x720F3C0", Offset = "0x720DDC0", VA = "0x18720F3C0")]
	[AsyncStateMachine(typeof(HAPAJDHNOPI))]
	private static Task<Scene> GDDFCAEIIAE(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x720F990", Offset = "0x720E390", VA = "0x18720F990")]
	public static MAKKFMNHCEA<Scene> LFEKPHEGIOA(string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x720FD60", Offset = "0x720E760", VA = "0x18720FD60")]
	public static OABICBNODGM ONGOHBNILKI(string OAAJEIOFMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x720FCD0", Offset = "0x720E6D0", VA = "0x18720FCD0")]
	[IteratorStateMachine(typeof(OCONHDPIMKC))]
	private static IEnumerator<JMPDKMJKKGA> NOEJHMIDNMH(string OAAJEIOFMBJ, CNPNGJHMILJ ANNBNNHJHOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x720F0A0", Offset = "0x720DAA0", VA = "0x18720F0A0")]
	[IteratorStateMachine(typeof(EMELHLEAEOF))]
	private static IEnumerator<JMPDKMJKKGA> FODCLPNBNKF(string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN, DPHELOEKPOL<Scene> ANNBNNHJHOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x720F140", Offset = "0x720DB40", VA = "0x18720F140")]
	public static bool GBCKCKHEOFE([Out] string HFEDNPGALEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NHOILCEDDGM
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x720C6C0", Offset = "0x720B0C0", VA = "0x18720C6C0")]
	public static IDisposable AOIIIKABCIA(this BNDKJFEMLMG CNBJCJOALNK, float NPEJJPOODJL, Action<float> IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x720C7D0", Offset = "0x720B1D0", VA = "0x18720C7D0")]
	public static IDisposable JFKEDNFNABI(this BNDKJFEMLMG CNBJCJOALNK, Action<float> IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x720C750", Offset = "0x720B150", VA = "0x18720C750")]
	public static IDisposable FCOIECKGMKL(this BNDKJFEMLMG CNBJCJOALNK, Action<float> IDBCFENKBMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class GCGGEHBOKLK
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x71FD3F0", Offset = "0x71FBDF0", VA = "0x1871FD3F0")]
	public static IDisposable FPLFFAIFCGP(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x71FD480", Offset = "0x71FBE80", VA = "0x1871FD480")]
	public static IDisposable FPLFFAIFCGP(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x71FD870", Offset = "0x71FC270", VA = "0x1871FD870")]
	public static IDisposable LHGGKPHIKGE(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x71FD7F0", Offset = "0x71FC1F0", VA = "0x1871FD7F0")]
	public static IDisposable LFENBOKJKMG(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x71FD770", Offset = "0x71FC170", VA = "0x1871FD770")]
	public static IDisposable LFENBOKJKMG(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x71FD2C0", Offset = "0x71FBCC0", VA = "0x1871FD2C0")]
	public static IDisposable ECEIDBDCEGN(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x71FD510", Offset = "0x71FBF10", VA = "0x1871FD510")]
	public static IDisposable IAADPOODKJK(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x71FDA10", Offset = "0x71FC410", VA = "0x1871FDA10")]
	public static IDisposable MALPNKLOAFE(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x71FD210", Offset = "0x71FBC10", VA = "0x1871FD210")]
	public static IDisposable DELPHDHAJIG(this MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x71FD8F0", Offset = "0x71FC2F0", VA = "0x1871FD8F0")]
	public static IDisposable LKHCOPPEALP(this MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x71FD590", Offset = "0x71FBF90", VA = "0x1871FD590")]
	public static IDisposable JPJCGNANANK(this MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x71FDA90", Offset = "0x71FC490", VA = "0x1871FDA90")]
	public static IDisposable NENMGAPHFJG(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x71FD630", Offset = "0x71FC030", VA = "0x1871FD630")]
	public static IDisposable KAPEHGAJACK(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x71FDB30", Offset = "0x71FC530", VA = "0x1871FDB30")]
	public static IDisposable OFDJOLLIENH(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x71FD170", Offset = "0x71FBB70", VA = "0x1871FD170")]
	public static IDisposable DEFIMBJNAIG(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x71FD0D0", Offset = "0x71FBAD0", VA = "0x1871FD0D0")]
	public static IDisposable CKHEGCJHHKE(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x71FD6D0", Offset = "0x71FC0D0", VA = "0x1871FD6D0")]
	public static IDisposable KJMMNEELJAG(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x71FD030", Offset = "0x71FBA30", VA = "0x1871FD030")]
	public static IDisposable BCIIHHLKMEA(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x71FD340", Offset = "0x71FBD40", VA = "0x1871FD340")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public GENFGEPLDJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x71FDBD0", Offset = "0x71FC5D0", VA = "0x1871FDBD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x71FDCB0", Offset = "0x71FC6B0", VA = "0x1871FDCB0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public ICILIKIFCAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7202C90", Offset = "0x7201690", VA = "0x187202C90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7202D80", Offset = "0x7201780", VA = "0x187202D80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x71F5BA0", Offset = "0x71F45A0", VA = "0x1871F5BA0")]
	public static GOOHGCNPLOF FPLFFAIFCGP(Action IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x71F59C0", Offset = "0x71F43C0", VA = "0x1871F59C0")]
	public static GOOHGCNPLOF FPLFFAIFCGP(Behaviour CNBJCJOALNK, Action IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x71F5A80", Offset = "0x71F4480", VA = "0x1871F5A80")]
	public static GOOHGCNPLOF FPLFFAIFCGP(Behaviour CNBJCJOALNK, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x71F5CE0", Offset = "0x71F46E0", VA = "0x1871F5CE0")]
	[IteratorStateMachine(typeof(GENFGEPLDJK))]
	private static IEnumerator<JMPDKMJKKGA> NCIMGCKPDOJ(NKLOKPDBJDH OHHDHLEHJDL, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x71F5C50", Offset = "0x71F4650", VA = "0x1871F5C50")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public DBNPOENPCAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x71FB490", Offset = "0x71F9E90", VA = "0x1871FB490", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x71FB520", Offset = "0x71F9F20", VA = "0x1871FB520", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x8569B0", Offset = "0x8553B0", VA = "0x1808569B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x71F5FC0", Offset = "0x71F49C0", VA = "0x1871F5FC0")]
	public ADNFIFODHNE(NKLOKPDBJDH EHKPGKAHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x71F5EA0", Offset = "0x71F48A0", VA = "0x1871F5EA0")]
	[IteratorStateMachine(typeof(DBNPOENPCAD))]
	private IEnumerator<JMPDKMJKKGA> COCKOFBEEHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x71F5F20", Offset = "0x71F4920", VA = "0x1871F5F20", Slot = "4")]
	public void OnCompleted(Action KFANDDBANJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	public void NKCJMOMAIOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class DGBGLLMBLFB
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x71FB7A0", Offset = "0x71FA1A0", VA = "0x1871FB7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public MIFKDOJFGAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x720B700", Offset = "0x720A100", VA = "0x18720B700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x720B780", Offset = "0x720A180", VA = "0x18720B780", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x720CC80", Offset = "0x720B680", VA = "0x18720CC80")]
	public static GOOHGCNPLOF FPLFFAIFCGP(float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x720CB70", Offset = "0x720B570", VA = "0x18720CB70")]
	public static GOOHGCNPLOF FPLFFAIFCGP(MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x720CA50", Offset = "0x720B450", VA = "0x18720CA50")]
	public static GOOHGCNPLOF ADJOPOJCNLM(MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x720CEA0", Offset = "0x720B8A0", VA = "0x18720CEA0")]
	public static GOOHGCNPLOF ONOLLACNKEE(BNDKJFEMLMG CNBJCJOALNK, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x720CDE0", Offset = "0x720B7E0", VA = "0x18720CDE0")]
	private static IEnumerator<JMPDKMJKKGA> NCIMGCKPDOJ(LIIPOKLEFGD GEGBGPONHGL, float NPEJJPOODJL, NKLOKPDBJDH OHHDHLEHJDL, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x720CD80", Offset = "0x720B780", VA = "0x18720CD80")]
	private static IEnumerator<JMPDKMJKKGA> IBNDPOOHMKP(LIIPOKLEFGD GEGBGPONHGL, float NPEJJPOODJL, NKLOKPDBJDH OHHDHLEHJDL, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x720CFB0", Offset = "0x720B9B0", VA = "0x18720CFB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public HHGKEOAKIFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7200910", Offset = "0x71FF310", VA = "0x187200910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x72009D0", Offset = "0x71FF3D0", VA = "0x1872009D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x71F6F20", Offset = "0x71F5920", VA = "0x1871F6F20")]
	[IteratorStateMachine(typeof(HHGKEOAKIFP))]
	private static IEnumerator<JMPDKMJKKGA> LCLBNJNAEED(NKLOKPDBJDH EHKPGKAHKKL, Func<bool> NGPBJNKHNBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x71F6E00", Offset = "0x71F5800", VA = "0x1871F6E00")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public DNNINHDHNNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x71FB8E0", Offset = "0x71FA2E0", VA = "0x1871FB8E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x71FB950", Offset = "0x71FA350", VA = "0x1871FB950", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public PHGNEHBKNNM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7210760", Offset = "0x720F160", VA = "0x187210760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x72107F0", Offset = "0x720F1F0", VA = "0x1872107F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7206AE0", Offset = "0x72054E0", VA = "0x187206AE0")]
	[IteratorStateMachine(typeof(DNNINHDHNNL))]
	private static IEnumerator<JMPDKMJKKGA> COCKOFBEEHB(float IOCCJIJEELD, NKLOKPDBJDH OHHDHLEHJDL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7206FE0", Offset = "0x72059E0", VA = "0x187206FE0")]
	[IteratorStateMachine(typeof(PHGNEHBKNNM))]
	private static IEnumerator<JMPDKMJKKGA> KHCKBAMNOOD(float IOCCJIJEELD, NKLOKPDBJDH OHHDHLEHJDL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7207080", Offset = "0x7205A80", VA = "0x187207080")]
	public static IDisposable LDECKOPNPII(this MonoBehaviour EIFNDIABMHD, float IOCCJIJEELD, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7206E20", Offset = "0x7205820", VA = "0x187206E20")]
	public static GOOHGCNPLOF HEBLAGHGIKD(this MonoBehaviour EIFNDIABMHD, float IOCCJIJEELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x72071A0", Offset = "0x7205BA0", VA = "0x1872071A0")]
	public static GOOHGCNPLOF LDECKOPNPII(this MonoBehaviour EIFNDIABMHD, float IOCCJIJEELD, NKLOKPDBJDH OHHDHLEHJDL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7206C50", Offset = "0x7205650", VA = "0x187206C50")]
	public static GOOHGCNPLOF DOODLMKCNBB(this MonoBehaviour EIFNDIABMHD, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7206FB0", Offset = "0x72059B0", VA = "0x187206FB0")]
	public static GOOHGCNPLOF JIDBEOCAJGF(this MonoBehaviour EIFNDIABMHD, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7206D40", Offset = "0x7205740", VA = "0x187206D40")]
	public static GOOHGCNPLOF EMALFLIODFA(this MonoBehaviour EIFNDIABMHD, Action GPJOKKOGGOF, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x72072D0", Offset = "0x7205CD0", VA = "0x1872072D0")]
	public static GOOHGCNPLOF LHNAIPFFJGN(this MonoBehaviour EIFNDIABMHD, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7207300", Offset = "0x7205D00", VA = "0x187207300")]
	public static GOOHGCNPLOF NHIMEFPNBDP(this MonoBehaviour EIFNDIABMHD, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7206B80", Offset = "0x7205580", VA = "0x187206B80")]
	private static GOOHGCNPLOF DEIKPKFPGNP(MonoBehaviour EIFNDIABMHD, NKLOKPDBJDH EHKPGKAHKKL, Action GPJOKKOGGOF, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7206940", Offset = "0x7205340", VA = "0x187206940")]
	public static GOOHGCNPLOF ADADKGIIPOI(this MonoBehaviour EIFNDIABMHD, float LKDIHAFBCJL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7206C70", Offset = "0x7205670", VA = "0x187206C70")]
	public static GOOHGCNPLOF ECGKHPHACJC(this MonoBehaviour EIFNDIABMHD, float LKDIHAFBCJL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7206EE0", Offset = "0x72058E0", VA = "0x187206EE0")]
	public static GOOHGCNPLOF IKCENKMMNBC(this MonoBehaviour EIFNDIABMHD, float LKDIHAFBCJL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7206A10", Offset = "0x7205410", VA = "0x187206A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7209F50", Offset = "0x7208950", VA = "0x187209F50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NIMFNDMBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x720A430", Offset = "0x7208E30", VA = "0x18720A430", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x720A4D0", Offset = "0x7208ED0", VA = "0x18720A4D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x720A6A0", Offset = "0x72090A0", VA = "0x18720A6A0")]
	public KCNLJCBDKMI([Optional] Action IFMJIHFFPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x720A570", Offset = "0x7208F70", VA = "0x18720A570")]
	public void PBLNBBGFGAP(LLDHOGPGHNI NOACPCMJNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7209DF0", Offset = "0x72087F0", VA = "0x187209DF0")]
	private void FGGJKAEJENG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x720A420", Offset = "0x7208E20", VA = "0x18720A420", Slot = "7")]
	public bool LLILENKEDLI(bool AMNFMCIBNPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x720A110", Offset = "0x7208B10", VA = "0x18720A110", Slot = "8")]
	public bool LLILENKEDLI(Action ENGMCBPHJGL, bool AMNFMCIBNPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x720A090", Offset = "0x7208A90", VA = "0x18720A090", Slot = "9")]
	public IEnumerator<LLDHOGPGHNI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x720A090", Offset = "0x7208A90", VA = "0x18720A090", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public FFPPJFKCEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x71FB770", Offset = "0x71FA170", VA = "0x1871FB770")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public DDJFHJNFFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x71FB770", Offset = "0x71FA170", VA = "0x1871FB770")]
		internal void EALHHCEEHPI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly float OMCHILFDFMG;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7207370", Offset = "0x7205D70", VA = "0x187207370")]
	public OGBEIILKDNM(Behaviour CNBJCJOALNK, float OMCHILFDFMG, [Optional] Action IFMJIHFFPPI, [Optional] KDPJBHDNKMB EENOGKEJBMD, [Optional] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x720E310", Offset = "0x720CD10", VA = "0x18720E310", Slot = "9")]
	protected override bool EKBJPKNFGBL(Action ENGMCBPHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x720E200", Offset = "0x720CC00", VA = "0x18720E200", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public BOPOGPGGHBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x71F6FB0", Offset = "0x71F59B0", VA = "0x1871F6FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x71F7080", Offset = "0x71F5A80", VA = "0x1871F7080", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xE91CD0", Offset = "0xE906D0", VA = "0x180E91CD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NIMFNDMBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x71FCAA0", Offset = "0x71FB4A0", VA = "0x1871FCAA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x71FCB40", Offset = "0x71FB540", VA = "0x1871FCB40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x71FCE20", Offset = "0x71FB820", VA = "0x1871FCE20")]
	protected FBLILNPFBIB(Behaviour CNBJCJOALNK, [Optional] Action IFMJIHFFPPI, [Optional] KDPJBHDNKMB EENOGKEJBMD, [Optional] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x71FC9E0", Offset = "0x71FB3E0", VA = "0x1871FC9E0", Slot = "7")]
	public bool LLILENKEDLI(bool AMNFMCIBNPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x71FCA40", Offset = "0x71FB440", VA = "0x1871FCA40", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x71FC980", Offset = "0x71FB380", VA = "0x1871FC980")]
	protected void FKHPKIDDPCF(Action ENGMCBPHJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x71FCBE0", Offset = "0x71FB5E0", VA = "0x1871FCBE0")]
	protected OABICBNODGM OFGKMIEGPBF(float HIEBMCLPBGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x71FC870", Offset = "0x71FB270", VA = "0x1871FC870")]
	private void CGEPDHMIKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x71FC8F0", Offset = "0x71FB2F0", VA = "0x1871FC8F0")]
	[IteratorStateMachine(typeof(BOPOGPGGHBB))]
	private IEnumerator<JMPDKMJKKGA> ECHPKDMMNDJ(float HIEBMCLPBGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x71FC9A0", Offset = "0x71FB3A0", VA = "0x1871FC9A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x71F74A0", Offset = "0x71F5EA0", VA = "0x1871F74A0")]
	public CFJLNPENHCE(Behaviour CNBJCJOALNK, float KANEHIICLBC, int IGCNOOKAODM, [Optional] Action IFMJIHFFPPI, float BFMBJEBPENO = 0f, [Optional] KDPJBHDNKMB EENOGKEJBMD, [Optional] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "9")]
	protected override bool EKBJPKNFGBL(Action ENGMCBPHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x71F7220", Offset = "0x71F5C20", VA = "0x1871F7220", Slot = "10")]
	protected override bool AFPNCJNBFKB(Action ENGMCBPHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x71F7420", Offset = "0x71F5E20", VA = "0x1871F7420")]
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
	[Cpp2IlInjected.Address(RVA = "0x7207370", Offset = "0x7205D70", VA = "0x187207370")]
	public IHNFHPLPIBI(Behaviour CNBJCJOALNK, float OMCHILFDFMG, [Optional] Action IFMJIHFFPPI, [Optional] KDPJBHDNKMB EENOGKEJBMD, [Optional] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "9")]
	protected override bool EKBJPKNFGBL(Action ENGMCBPHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7207330", Offset = "0x7205D30", VA = "0x187207330", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public FBEPCEKHODG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x71F63F0", Offset = "0x71F4DF0", VA = "0x1871F63F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x71FC820", Offset = "0x71FB220", VA = "0x1871FC820", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x720C4E0", Offset = "0x720AEE0", VA = "0x18720C4E0")]
	public NFODEPECADG(BNDKJFEMLMG CNBJCJOALNK, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x720C160", Offset = "0x720AB60", VA = "0x18720C160")]
	private void KMBBNIEKLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x720C380", Offset = "0x720AD80", VA = "0x18720C380")]
	private void PAJGNJAEKCG(string GGEHLADLJHF, Action OPJGMCDIFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x720C300", Offset = "0x720AD00", VA = "0x18720C300")]
	[IteratorStateMachine(typeof(FBEPCEKHODG))]
	private IEnumerator<JMPDKMJKKGA> MBPCMIOAPKC(Action OPJGMCDIFJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x720C100", Offset = "0x720AB00", VA = "0x18720C100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x720BF50", Offset = "0x720A950", VA = "0x18720BF50")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public ALIKJFKEMBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x71F63F0", Offset = "0x71F4DF0", VA = "0x1871F63F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x71F6460", Offset = "0x71F4E60", VA = "0x1871F6460", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x7201880", Offset = "0x7200280", VA = "0x187201880")]
	public HJHAHAOKKNM(MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7201A70", Offset = "0x7200470", VA = "0x187201A70")]
	public HJHAHAOKKNM(MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7201630", Offset = "0x7200030", VA = "0x187201630")]
	public HJHAHAOKKNM(MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1BFB4F0", Offset = "0x1BF9EF0", VA = "0x181BFB4F0")]
	private HJHAHAOKKNM(KDPJBHDNKMB EENOGKEJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7200E40", Offset = "0x71FF840", VA = "0x187200E40")]
	internal static HJHAHAOKKNM GPJLJPBNEGO(MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7200CD0", Offset = "0x71FF6D0", VA = "0x187200CD0")]
	private void FPLFFAIFCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7200F70", Offset = "0x71FF970", VA = "0x187200F70")]
	private void ICAFKBLEOFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7201240", Offset = "0x71FFC40", VA = "0x187201240")]
	private void KMBBNIEKLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7200B10", Offset = "0x71FF510", VA = "0x187200B10")]
	private void EEEMKHLDHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7201500", Offset = "0x71FFF00", VA = "0x187201500")]
	private void PAJGNJAEKCG(string GGEHLADLJHF, Action OPJGMCDIFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7201480", Offset = "0x71FFE80", VA = "0x187201480")]
	[IteratorStateMachine(typeof(ALIKJFKEMBG))]
	private IEnumerator<JMPDKMJKKGA> MBPCMIOAPKC(Action OPJGMCDIFJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7200AB0", Offset = "0x71FF4B0", VA = "0x187200AB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7200A20", Offset = "0x71FF420", VA = "0x187200A20")]
	[CompilerGenerated]
	private void DLHOPFCHLFL(string HBEPHPNHPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7201120", Offset = "0x71FFB20", VA = "0x187201120")]
	[CompilerGenerated]
	private void JOFAJPJOLHJ(string HBEPHPNHPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x72011B0", Offset = "0x71FFBB0", VA = "0x1872011B0")]
	[CompilerGenerated]
	private void JPABAPABIIB(string HBEPHPNHPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x72013F0", Offset = "0x71FFDF0", VA = "0x1872013F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x71F6DD0", Offset = "0x71F57D0", VA = "0x1871F6DD0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float KNOOFIBNBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x71F6DC0", Offset = "0x71F57C0", VA = "0x1871F6DC0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double AMJPOMIJLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x71F6DE0", Offset = "0x71F57E0", VA = "0x1871F6DE0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x71F6D50", Offset = "0x71F5750", VA = "0x1871F6D50")]
	[GDGALFJPCGE(JMIPDAHBNNG.None)]
	private static void CEJDNEABNOB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x850BA0", VA = "0x1808521A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851310", VA = "0x180852910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x71F54F0", Offset = "0x71F3EF0", VA = "0x1871F54F0")]
	public static JMPDKMJKKGA CDPNMICCKHN(IEnumerator<JMPDKMJKKGA> EIJLCAJMEGF, NCLBBPBAMHF KEGEDGBLGGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x71F5650", Offset = "0x71F4050", VA = "0x1871F5650")]
	public JMPDKMJKKGA CDPNMICCKHN(NCLBBPBAMHF[] DBDNOEOCGDN, IEnumerator<JMPDKMJKKGA>[] OEGKMJGAGAF, JMPDKMJKKGA[] MCBPHILBEPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x71F5710", Offset = "0x71F4110", VA = "0x1871F5710")]
	public void GMGHFIFDHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x71F5740", Offset = "0x71F4140", VA = "0x1871F5740")]
	public void ODPBCFIFNBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x71F5880", Offset = "0x71F4280", VA = "0x1871F5880")]
	public void PODFLMIALEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x71F5710", Offset = "0x71F4110", VA = "0x1871F5710")]
	public void GINDKEMMJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public ODKKPMLFFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x720D750", Offset = "0x720C150", VA = "0x18720D750")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public PJECEIFBODK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7210840", Offset = "0x720F240", VA = "0x187210840")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public MGJIHEDDDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x720B6C0", Offset = "0x720A0C0", VA = "0x18720B6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public IEPOGJACGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x72039E0", Offset = "0x72023E0", VA = "0x1872039E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BEF90", Offset = "0x8BD990", VA = "0x1808BEF90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x72052B0", Offset = "0x7203CB0", VA = "0x1872052B0")]
	private static int MKPPMLNGCJG(NKLOKPDBJDH EHKPGKAHKKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7205D80", Offset = "0x7204780", VA = "0x187205D80")]
	public IFGLAEILLBD(NKLOKPDBJDH EHKPGKAHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x72044C0", Offset = "0x7202EC0", VA = "0x1872044C0")]
	private void HDOAFLAHLPG(int FABKPEEAHMB, int FABKOFGFJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x72046A0", Offset = "0x72030A0", VA = "0x1872046A0")]
	public void JNJINNMJHHP(BNDKJFEMLMG CNBJCJOALNK, JMPDKMJKKGA PBLNBIDNEIN, IEnumerator<JMPDKMJKKGA> EIJLCAJMEGF, NCLBBPBAMHF KEGEDGBLGGL, [Optional] ABBOJKOJFFI GLKOPLCPHJM, OAAJKFGGKEL JANJEJNBMBD = OAAJKFGGKEL.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7204280", Offset = "0x7202C80", VA = "0x187204280")]
	public void HDMLFENMIIH(IEnumerable<EKNALJMIAOJ> ODFJEHIJKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7205510", Offset = "0x7203F10", VA = "0x187205510")]
	private EKNALJMIAOJ ONMCKDLEDBH(int JHHJHBCLCCJ)
	{
		return default(EKNALJMIAOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7203A20", Offset = "0x7202420", VA = "0x187203A20")]
	private void ECCEHINHHIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BB80", Offset = "0x2B7A580", VA = "0x182B7BB80")]
	private static void LNKKOMPNDOA<T>(int JHHJHBCLCCJ, T[] IHOJEMLHKFM, int ECGAAJFODGN, [Optional] T ELEPHPKCELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BBD0", Offset = "0x2B7A5D0", VA = "0x182B7BBD0")]
	private static void LNKKOMPNDOA<T>(int JHHJHBCLCCJ, NativeArray<T> IHOJEMLHKFM, int ECGAAJFODGN, [Optional] T ELEPHPKCELN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x72059E0", Offset = "0x72043E0", VA = "0x1872059E0")]
	private void PHJMOAGLDLI(IEnumerable<EKNALJMIAOJ> ODFJEHIJKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7204090", Offset = "0x7202A90", VA = "0x187204090")]
	private void FBCKHPDMDCE(EKNALJMIAOJ AFIEEBJNELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7205050", Offset = "0x7203A50", VA = "0x187205050")]
	private MOABMEILMEH MABMKGGMFPK(int DHDFALGOKLI)
	{
		return default(MOABMEILMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7203E90", Offset = "0x7202890", VA = "0x187203E90")]
	public void EKKBOLGADGM(float KBAMMELOGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7205490", Offset = "0x7203E90", VA = "0x187205490")]
	private void OBACGHPDCHL(Action MLFGLJKBOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x72052E0", Offset = "0x7203CE0", VA = "0x1872052E0")]
	private void MMBHBBCIPND(Action MLFGLJKBOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7204950", Offset = "0x7203350", VA = "0x187204950")]
	public void LFAGPFKGJEE(float KBAMMELOGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7203D90", Offset = "0x7202790", VA = "0x187203D90")]
	public void EECPCLJADFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7204150", Offset = "0x7202B50", VA = "0x187204150")]
	public void GINDKEMMJIL(ABBOJKOJFFI DKNNEBCHBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7205360", Offset = "0x7203D60", VA = "0x187205360")]
	public void NICGIFDENMA(ABBOJKOJFFI DKNNEBCHBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7204820", Offset = "0x7203220", VA = "0x187204820")]
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
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
	public FCPGJGEBLCK(Action BDILBDIGJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x69AD450", Offset = "0x69ABE50", VA = "0x1869AD450", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public DELOAJBDMKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x57449D0", Offset = "0x57433D0", VA = "0x1857449D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x91FDA0", Offset = "0x91E7A0", VA = "0x18091FDA0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4E3BF50", Offset = "0x4E3A950", VA = "0x184E3BF50", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4E3BDB0", Offset = "0x4E3A7B0", VA = "0x184E3BDB0")]
	private static bool JKONKPFGDNM(T MLFGLJKBOIG, T GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4E3BFF0", Offset = "0x4E3A9F0", VA = "0x184E3BFF0")]
	public BLJCLDFLDND(T KLDLAHEBNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4E3BA50", Offset = "0x4E3A450", VA = "0x184E3BA50", Slot = "6")]
	public IDisposable HIFMEIAAFOH(UnityEngine.Object CNBJCJOALNK, Action<T> NANKILKEHAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B730", Offset = "0x4E3A130", VA = "0x184E3B730")]
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
	[Cpp2IlInjected.Address(RVA = "0x71F62D0", Offset = "0x71F4CD0", VA = "0x1871F62D0")]
	[GDGALFJPCGE(JMIPDAHBNNG.None)]
	private static void CEJDNEABNOB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
	[Preserve]
	internal AGIBCGMFBLL([OMAPKKAGFIL(null)] KDPJBHDNKMB EENOGKEJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x71F6340", Offset = "0x71F4D40", VA = "0x1871F6340", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x72022B0", Offset = "0x7200CB0", VA = "0x1872022B0")]
	[GDGALFJPCGE(JMIPDAHBNNG.None)]
	private static void CEJDNEABNOB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7202BD0", Offset = "0x72015D0", VA = "0x187202BD0")]
	[Preserve]
	public ICHGKLBBNIP([OMAPKKAGFIL(null)] IHCGHJBEAFE CBHFJINNKJG, [OMAPKKAGFIL(null)] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7202030", Offset = "0x7200A30", VA = "0x187202030", Slot = "17")]
	public override GOOHGCNPLOF AAIGGIEKNJG(BNDKJFEMLMG CNBJCJOALNK, IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7202680", Offset = "0x7201080", VA = "0x187202680", Slot = "18")]
	public override void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7202380", Offset = "0x7200D80", VA = "0x187202380", Slot = "20")]
	public override void FMEAIHHBFHB(NKLOKPDBJDH EHKPGKAHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x72025B0", Offset = "0x7200FB0", VA = "0x1872025B0", Slot = "19")]
	protected override void LHGGKPHIKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7202160", Offset = "0x7200B60", VA = "0x187202160")]
	private IFGLAEILLBD BJPNJJEGNAC(NKLOKPDBJDH NCMHJNKFAGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7202920", Offset = "0x7201320", VA = "0x187202920", Slot = "21")]
	internal override APIAJIDAPLD NMBKKAAPNEO(IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM, Behaviour CNBJCJOALNK, NCLBBPBAMHF KEGEDGBLGGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7202B50", Offset = "0x7201550", VA = "0x187202B50", Slot = "22")]
	internal override GKEDDHBBPHF OOFEIFMFNLH(NKLOKPDBJDH OHHDHLEHJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7202190", Offset = "0x7200B90", VA = "0x187202190")]
	private void BNLGAKGCPLD(IFGLAEILLBD LILJLJFDBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7202320", Offset = "0x7200D20", VA = "0x187202320", Slot = "23")]
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
	[Cpp2IlInjected.Address(RVA = "0x7207890", Offset = "0x7206290", VA = "0x187207890")]
	public static IKFCPIOOIDK JGIIBNEOBDO(int IPINNKDPCLL, float KBAMMELOGGL, NativeArray<OAAJKFGGKEL> BFFKIAEGOLD, NativeArray<float> CMFFPDILCKI, NativeArray<int> FLEPCEHBPAK, NativeArray<int> CCDJPKJIAOM, NativeArray<int> JJFOHCPBBBA, NativeArray<int> EDNHBKHPHEL, NativeArray<int> IHLLKDEEELK)
	{
		return default(IKFCPIOOIDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7207540", Offset = "0x7205F40", VA = "0x187207540", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7207990", Offset = "0x7206390", VA = "0x187207990")]
	private bool LKGOBOJDMIG(int DHNLEFJCEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7207620", Offset = "0x7206020", VA = "0x187207620")]
	private void FPGONOMCGMO(NativeArray<int> GHJMPEDKGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x72078F0", Offset = "0x72062F0", VA = "0x1872078F0")]
	private int KNDCNKKKJND(int IGFCIJKKLLO, int CFBPCIPAGLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7207470", Offset = "0x7205E70", VA = "0x187207470")]
	private void AJAPKNMPFKL(NativeArray<int> GHJMPEDKGHI, int LODIOKPFBJE, int DLFEHJOHIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7207650", Offset = "0x7206050", VA = "0x187207650")]
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
		[Cpp2IlInjected.Address(RVA = "0x7207D20", Offset = "0x7206720", VA = "0x187207D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool HPJBMFGHLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BFA0", VA = "0x18086D5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NKLOKPDBJDH BEABEPCNLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x850BA0", VA = "0x1808521A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(NKLOKPDBJDH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851310", VA = "0x180852910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public LIIPOKLEFGD JBFLLCIBMLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public JMPDKMJKKGA EPEBMPAEFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8555C0", VA = "0x180856BC0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x856AB0", Offset = "0x8554B0", VA = "0x180856AB0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x72086E0", Offset = "0x72070E0", VA = "0x1872086E0")]
	public static GOOHGCNPLOF NAAFBKAMHFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7208A30", Offset = "0x7207430", VA = "0x187208A30")]
	[Preserve]
	protected IOMCJGKMHHO([OMAPKKAGFIL(null)] IHCGHJBEAFE CBHFJINNKJG, [OMAPKKAGFIL(null)] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7207AF0", Offset = "0x72064F0", VA = "0x187207AF0", Slot = "6")]
	public GOOHGCNPLOF AGALHLJOLPH(IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7207B00", Offset = "0x7206500", VA = "0x187207B00", Slot = "7")]
	public GOOHGCNPLOF AGALHLJOLPH(Behaviour CNBJCJOALNK, IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract GOOHGCNPLOF AAIGGIEKNJG(BNDKJFEMLMG CNBJCJOALNK, IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7208540", Offset = "0x7206F40", VA = "0x187208540", Slot = "18")]
	public virtual void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x72087D0", Offset = "0x72071D0", VA = "0x1872087D0", Slot = "9")]
	public void OPIEDMMDNAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7208520", Offset = "0x7206F20", VA = "0x187208520", Slot = "19")]
	protected virtual void LHGGKPHIKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7208A10", Offset = "0x7207410", VA = "0x187208A10")]
	private void PLGKALAENJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x72084E0", Offset = "0x7206EE0", VA = "0x1872084E0")]
	private void JIKEKNHPFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7208500", Offset = "0x7206F00", VA = "0x187208500")]
	private void LFENBOKJKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7208130", Offset = "0x7206B30", VA = "0x187208130")]
	private void ECEIDBDCEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7207D00", Offset = "0x7206700", VA = "0x187207D00")]
	private void BACFBLGCIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x72084C0", Offset = "0x7206EC0", VA = "0x1872084C0")]
	private void GHJBHFHJJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7208380", Offset = "0x7206D80", VA = "0x187208380")]
	private void FBPDICHEEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x72083A0", Offset = "0x7206DA0", VA = "0x1872083A0", Slot = "20")]
	public virtual void FMEAIHHBFHB(NKLOKPDBJDH EHKPGKAHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7208150", Offset = "0x7206B50", VA = "0x187208150")]
	private void EKBIOCDPDCC(GKEDDHBBPHF LILJLJFDBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF940", Offset = "0x1EBE340", VA = "0x181EBF940")]
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
	[Cpp2IlInjected.Address(RVA = "0x7207D70", Offset = "0x7206770", VA = "0x187207D70", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7208770", Offset = "0x7207170", VA = "0x187208770", Slot = "13")]
	public JMPDKMJKKGA OENNPNHBBJC(NKLOKPDBJDH OHHDHLEHJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7208430", Offset = "0x7206E30", VA = "0x187208430", Slot = "14")]
	public JMPDKMJKKGA GEADBELPKFM(float IOCCJIJEELD, NKLOKPDBJDH OHHDHLEHJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7208320", Offset = "0x7206D20", VA = "0x187208320", Slot = "15")]
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
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x851AF0", VA = "0x1808530F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public JMPDKMJKKGA EKNDMFBLNDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851290", VA = "0x180852890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool JBJPGJHFCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x71F69C0", Offset = "0x71F53C0", VA = "0x1871F69C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool ONJMHJBJGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9E6690", Offset = "0x9E5090", VA = "0x1809E6690")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9E67B0", Offset = "0x9E51B0", VA = "0x1809E67B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x71F64B0", Offset = "0x71F4EB0", VA = "0x1871F64B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float LFOBCGIPDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8BF240", Offset = "0x8BDC40", VA = "0x1808BF240")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B470", Offset = "0x5E59E70", VA = "0x185E5B470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x71F6B90", Offset = "0x71F5590", VA = "0x1871F6B90")]
	public APIAJIDAPLD(IEnumerator<JMPDKMJKKGA> EIJLCAJMEGF, CODIAPFGOPD CNBJCJOALNK, NCLBBPBAMHF KEGEDGBLGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x71F6660", Offset = "0x71F5060", VA = "0x1871F6660")]
	public JMPDKMJKKGA CDPNMICCKHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x71F6A40", Offset = "0x71F5440", VA = "0x1871F6A40")]
	public bool NGGPFPHINMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x71F6970", Offset = "0x71F5370", VA = "0x1871F6970")]
	public void GINDKEMMJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x71F6AB0", Offset = "0x71F54B0", VA = "0x1871F6AB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA73A50", Offset = "0xA72450", VA = "0x180A73A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x101C890", Offset = "0x101B290", VA = "0x18101C890", Slot = "23")]
		get
		{
			return default(NKLOKPDBJDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NKLOKPDBJDH OELHCGFHGDG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x15514D0", Offset = "0x154FED0", VA = "0x1815514D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private float ONAEKNIHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA115F0", Offset = "0xA0FFF0", VA = "0x180A115F0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool JIDFDPNJHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x720BE30", Offset = "0x720A830", VA = "0x18720BE30", Slot = "24")]
	private bool FEHOLLONLMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x720BE20", Offset = "0x720A820", VA = "0x18720BE20", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x720BE50", Offset = "0x720A850", VA = "0x18720BE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8569D0", Offset = "0x8553D0", VA = "0x1808569D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x71FF210", Offset = "0x71FDC10", VA = "0x1871FF210")]
	public GKEDDHBBPHF(NKLOKPDBJDH OHHDHLEHJDL, MOAJGBJCCIC HIBDLNMCMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x71FE210", Offset = "0x71FCC10", VA = "0x1871FE210")]
	public void GNHGIFNNAPC(APIAJIDAPLD EIJLCAJMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x71FDDF0", Offset = "0x71FC7F0", VA = "0x1871FDDF0")]
	public void AFAACFHELFH(IList<APIAJIDAPLD> OEGKMJGAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x71FE910", Offset = "0x71FD310", VA = "0x1871FE910")]
	public void MHKICLCBKMA(IList<APIAJIDAPLD> OEGKMJGAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x71FDD00", Offset = "0x71FC700", VA = "0x1871FDD00")]
	private void AEOHMEFFKEG(APIAJIDAPLD EIJLCAJMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x71FEC10", Offset = "0x71FD610", VA = "0x1871FEC10")]
	private void MHLBIFJCCGO(IList<APIAJIDAPLD> OEGKMJGAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x71FE320", Offset = "0x71FCD20", VA = "0x1871FE320")]
	private MOABMEILMEH HCKBAMIAOJE(APIAJIDAPLD EIJLCAJMEGF)
	{
		return default(MOABMEILMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x71FE4A0", Offset = "0x71FCEA0", VA = "0x1871FE4A0")]
	public void LHGGKPHIKGE(float KBAMMELOGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x71FEEE0", Offset = "0x71FD8E0", VA = "0x1871FEEE0")]
	public void OPIEDMMDNAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x71FE610", Offset = "0x71FD010", VA = "0x1871FE610")]
	private void MCAHMGGFHDG(List<APIAJIDAPLD> OEGKMJGAGAF, Stack<int> PANADDMBAOL, bool ADAFGDHBPEA, float FHBFPMOOFPA = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x71FE0F0", Offset = "0x71FCAF0", VA = "0x1871FE0F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x71FEDA0", Offset = "0x71FD7A0", VA = "0x1871FEDA0")]
	private void NPFNKPKAMHJ(List<APIAJIDAPLD> OEGKMJGAGAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class AEDPFLPPAOP : MOAJGBJCCIC
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "4")]
	public void NKPOOBMLFGL(string BHFPKCCDEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
	public void HJCDHLLHHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x71F70D0", Offset = "0x71F5AD0", VA = "0x1871F70D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool CKCBOLCFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x71F7170", Offset = "0x71F5B70", VA = "0x1871F7170", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool EMICDMPMLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x71F7150", Offset = "0x71F5B50", VA = "0x1871F7150", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
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

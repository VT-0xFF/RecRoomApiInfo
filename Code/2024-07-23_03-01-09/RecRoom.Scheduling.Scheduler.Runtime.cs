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

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x7221700", Offset = "0x7220900", VA = "0x187221700")]
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

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x7235960", Offset = "0x7234B60", VA = "0x187235960")]
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

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x7230130", Offset = "0x722F330", VA = "0x187230130")]
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

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x72308B0", Offset = "0x722FAB0", VA = "0x1872308B0")]
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

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x7220650", Offset = "0x721F850", VA = "0x187220650")]
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

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x7232FF0", Offset = "0x72321F0", VA = "0x187232FF0")]
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

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x722E9A0", Offset = "0x722DBA0", VA = "0x18722E9A0")]
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

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x721B150", Offset = "0x721A350", VA = "0x18721B150")]
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

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x7231930", Offset = "0x7230B30", VA = "0x187231930")]
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

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x72247A0", Offset = "0x72239A0", VA = "0x1872247A0")]
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

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x7230BA0", Offset = "0x722FDA0", VA = "0x187230BA0")]
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

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x7220E30", Offset = "0x7220030", VA = "0x187220E30")]
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

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x722ECD0", Offset = "0x722DED0", VA = "0x18722ECD0")]
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

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
					public NEKFGLJFHCO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x7230F80", Offset = "0x7230180", VA = "0x187230F80")]
					internal void HFBBLIKFFKO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static ODIOBOMGOFD<JMAFADCBMHD> KJAFGPHCMOJ;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x7233740", Offset = "0x7232940", VA = "0x187233740")]
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

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
					public OIKJMFGDKOH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x7233500", Offset = "0x7232700", VA = "0x187233500")]
					internal void HBHDOLLNKMN()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable LOBIMOBOKNH;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x722EBA0", Offset = "0x722DDA0", VA = "0x18722EBA0")]
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

					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
					public IGNDOKCKIDP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x722B5D0", Offset = "0x722A7D0", VA = "0x18722B5D0")]
					internal void HBHDOLLNKMN()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x721ADF0", Offset = "0x7219FF0", VA = "0x18721ADF0")]
				public static PlayerLoopSystem HKDFGDGHEDO(HBJHILMNFNM.PJCJAABLALM NDDCLPHCEEO)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class IFJNMMIMOCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
			public IFJNMMIMOCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x722B4B0", Offset = "0x722A6B0", VA = "0x18722B4B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x721C880", Offset = "0x721BA80", VA = "0x18721C880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x721D210", Offset = "0x721C410", VA = "0x18721D210")]
		private static void CMGNAMFCNHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x721C8C0", Offset = "0x721BAC0", VA = "0x18721C8C0")]
		private static void AJHMJPGFINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x721D1D0", Offset = "0x721C3D0", VA = "0x18721D1D0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7220320", Offset = "0x721F520", VA = "0x187220320")]
		private static void KMMDLLFLFDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x721C6C0", Offset = "0x721B8C0", VA = "0x18721C6C0")]
		private static void AADEKNNGMIH(HBJHILMNFNM.PJCJAABLALM NDDCLPHCEEO, PlayerLoopSystem FIEPEONNCHO, Type LGHOJPKHNPH, Type CEMPJLJPAJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x721FE10", Offset = "0x721F010", VA = "0x18721FE10")]
		private static void EJMIPDPCBEK(PlayerLoopSystem FIEPEONNCHO, Type LGHOJPKHNPH, Type CEMPJLJPAJC, NLIFKBEAHKD HMOMBLFCJEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72201F0", Offset = "0x721F3F0", VA = "0x1872201F0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7220D20", Offset = "0x721FF20", VA = "0x187220D20")]
		public EINLPOIECMH(PJCJAABLALM CLJGKKPNDMB, int GOIGGDADOPG = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7220AD0", Offset = "0x721FCD0", VA = "0x187220AD0")]
		public void FIFEAJLOGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7220A80", Offset = "0x721FC80", VA = "0x187220A80")]
		public void EANCDEHLLBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7220B40", Offset = "0x721FD40", VA = "0x187220B40")]
		public void MOEBIHHDKJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static PJCJAABLALM[] IBBJDCHJGIJ;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static EINLPOIECMH[] FJANKDEPIDM;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7225670", Offset = "0x7224870", VA = "0x187225670")]
	public static EINLPOIECMH MPMOMMIKNFH(PJCJAABLALM NDDCLPHCEEO, int GOIGGDADOPG = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7225560", Offset = "0x7224760", VA = "0x187225560")]
	public static EINLPOIECMH DFPLDKFEPEA(PJCJAABLALM NDDCLPHCEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x72255D0", Offset = "0x72247D0", VA = "0x1872255D0")]
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
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7232120", Offset = "0x7231320", VA = "0x187232120", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double EFFHEIKNDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1A6D830", Offset = "0x1A6CA30", VA = "0x181A6D830", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double JEGNKKKIMIH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1F6B4C0", Offset = "0x1F6A6C0", VA = "0x181F6B4C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7232310", Offset = "0x7231510", VA = "0x187232310")]
	public OBGBLLAPIPM(int AKMPLLNJJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7232180", Offset = "0x7231380", VA = "0x187232180", Slot = "7")]
	public void BFDAFNAMENP(double GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x72322A0", Offset = "0x72314A0", VA = "0x1872322A0", Slot = "8")]
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
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double EFFHEIKNDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E79FC0", Offset = "0x5E791C0", VA = "0x185E79FC0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JEGNKKKIMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E79F90", Offset = "0x5E79190", VA = "0x185E79F90", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double GGINOPFDKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E79FA0", Offset = "0x5E791A0", VA = "0x185E79FA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FNDHIEMGBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2561F90", Offset = "0x2561190", VA = "0x182561F90", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7230DA0", Offset = "0x722FFA0", VA = "0x187230DA0", Slot = "7")]
	public virtual void BFDAFNAMENP(double GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7230EC0", Offset = "0x72300C0", VA = "0x187230EC0", Slot = "8")]
	public virtual void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x722E970", Offset = "0x722DB70", VA = "0x18722E970")]
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
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A000", Offset = "0x5E79200", VA = "0x185E7A000")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A460", Offset = "0x5E79660", VA = "0x185E7A460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x722E800", Offset = "0x722DA00", VA = "0x18722E800", Slot = "7")]
	public override void BFDAFNAMENP(double GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x722E930", Offset = "0x722DB30", VA = "0x18722E930", Slot = "8")]
	public override void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x722E970", Offset = "0x722DB70", VA = "0x18722E970")]
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
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double EFFHEIKNDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double JEGNKKKIMIH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
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
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
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
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x4269520", Offset = "0x4268720", VA = "0x184269520")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool CNBAGEGEKLE
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x42694B0", Offset = "0x42686B0", VA = "0x1842694B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85E250", VA = "0x18085F050")]
		protected LGPEBNOIJDD(TPromise ABCAKOKMCGB, TMainThreadPromise IMLNINNKANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4269500", Offset = "0x4268700", VA = "0x184269500", Slot = "5")]
		public void LCJDPHEAJHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void JHNBPHKGJMA(TPromise ABCAKOKMCGB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class FHHOLNIBMCP<T> : LGPEBNOIJDD<MAKKFMNHCEA<T>, DPHELOEKPOL<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE860", Offset = "0x3BEDA60", VA = "0x183BEE860")]
		public FHHOLNIBMCP(MAKKFMNHCEA<T> ABCAKOKMCGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE710", Offset = "0x3BED910", VA = "0x183BEE710", Slot = "6")]
		protected override void JHNBPHKGJMA(MAKKFMNHCEA<T> ABCAKOKMCGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3B85B80", Offset = "0x3B84D80", VA = "0x183B85B80")]
		[CompilerGenerated]
		private void HGFCPENBBFB(T ADPMAHMCGNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE6C0", Offset = "0x3BED8C0", VA = "0x183BEE6C0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8523E0", VA = "0x1808531E0")]
		public OGIGKMBFEKL(Action ENGMCBPHJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x92BC50", Offset = "0x92AE50", VA = "0x18092BC50", Slot = "5")]
		public void LCJDPHEAJHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<HIMKIOBGHBI> CDCCEEHDIPI;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2BCA1C0", Offset = "0x2BC93C0", VA = "0x182BCA1C0")]
	public static MAKKFMNHCEA<T> KECGLJMIBIM<T>(this MAKKFMNHCEA<T> ABCAKOKMCGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x722E2F0", Offset = "0x722D4F0", VA = "0x18722E2F0")]
	public static void KECGLJMIBIM(Action ENGMCBPHJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2BCA0D0", Offset = "0x2BC92D0", VA = "0x182BCA0D0")]
	private static MAKKFMNHCEA<T> BHPAPPPAAHN<T>(MAKKFMNHCEA<T> ABCAKOKMCGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x722E000", Offset = "0x722D200", VA = "0x18722E000")]
	private static void FAOGNJAODOK(HIMKIOBGHBI PLNECBEGJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x722E390", Offset = "0x722D590", VA = "0x18722E390")]
	private static void MFBPBNBPLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x722E670", Offset = "0x722D870", VA = "0x18722E670")]
	private static void PCJNDIGNGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x722E210", Offset = "0x722D410", VA = "0x18722E210")]
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

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x721C240", Offset = "0x721B440", VA = "0x18721C240")]
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

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x722F820", Offset = "0x722EA20", VA = "0x18722F820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x72300C0", Offset = "0x722F2C0", VA = "0x1872300C0", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7226D90", Offset = "0x7225F90", VA = "0x187226D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x72270B0", Offset = "0x72262B0", VA = "0x1872270B0", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7230390", Offset = "0x722F590", VA = "0x187230390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7230740", Offset = "0x722F940", VA = "0x187230740", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public LLDKLMINPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7230330", Offset = "0x722F530", VA = "0x187230330")]
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

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7227EB0", Offset = "0x72270B0", VA = "0x187227EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7228A50", Offset = "0x7227C50", VA = "0x187228A50", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7235300", Offset = "0x7234500", VA = "0x187235300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72357D0", Offset = "0x72349D0", VA = "0x1872357D0", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72249A0", Offset = "0x7223BA0", VA = "0x1872249A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x72254F0", Offset = "0x72246F0", VA = "0x1872254F0", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public NFFPMNFBOMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7231000", Offset = "0x7230200", VA = "0x187231000")]
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
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public OCONHDPIMKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x72327A0", Offset = "0x72319A0", VA = "0x1872327A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7232410", Offset = "0x7231610", VA = "0x187232410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x72323C0", Offset = "0x72315C0", VA = "0x1872323C0")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7232750", Offset = "0x7231950", VA = "0x187232750", Slot = "8")]
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

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public IHFJEFBOJGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x722B840", Offset = "0x722AA40", VA = "0x18722B840")]
		internal bool EJLKEGDFKNC(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x722B8C0", Offset = "0x722AAC0", VA = "0x18722B8C0")]
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
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public EMELHLEAEOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7221030", Offset = "0x7220230", VA = "0x187221030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x72216B0", Offset = "0x72208B0", VA = "0x1872216B0", Slot = "8")]
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
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7233A10", Offset = "0x7232C10", VA = "0x187233A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool OGIKOAOMDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7233D40", Offset = "0x7232F40", VA = "0x187233D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool BCIDPCNFKAM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x72347D0", Offset = "0x72339D0", VA = "0x1872347D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool LGKCGEDEHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7233FE0", Offset = "0x72331E0", VA = "0x187233FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> BFBAPNGEAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7234070", Offset = "0x7233270", VA = "0x187234070")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7233C30", Offset = "0x7232E30", VA = "0x187233C30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x72345B0", Offset = "0x72337B0", VA = "0x1872345B0")]
	[JIDCLHKIDAF(KJECFEIFJAL.EnteredEditModeNextFrame, 0)]
	private static void HBDKKCKICPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7234870", Offset = "0x7233A70", VA = "0x187234870")]
	[AsyncStateMachine(typeof(KKCOBPIJFLE))]
	public static Task<Scene> JLCDFILIOPA(string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN = LoadSceneMode.Single, bool DNHNFCFHHHN = false, [Optional] OADONCMLPJG<string>.HILOONJJDHL NPJBMNGDLMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x72349C0", Offset = "0x7233BC0", VA = "0x1872349C0")]
	[AsyncStateMachine(typeof(HMMAHMNDFBI))]
	private static Task LAGBELIAIJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7234BF0", Offset = "0x7233DF0", VA = "0x187234BF0")]
	[AsyncStateMachine(typeof(LPGKJKHLIOE))]
	private static Task LPGCMPGJHCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7234350", Offset = "0x7233550", VA = "0x187234350")]
	[AsyncStateMachine(typeof(IEKCBGDNHMI))]
	private static Task<Scene> GCPPFDOOLPP(string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN, bool DNHNFCFHHHN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7233910", Offset = "0x7232B10", VA = "0x187233910")]
	private static void BEFKDBKNAOF(SceneInstance BOLGDNNEFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7233DE0", Offset = "0x7232FE0", VA = "0x187233DE0")]
	private static void DDCDNIOJGEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x72346B0", Offset = "0x72338B0", VA = "0x1872346B0")]
	[AsyncStateMachine(typeof(OOAMJCMEGBF))]
	private static Task<Scene> HGJAOHEILEM(string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7234CC0", Offset = "0x7233EC0", VA = "0x187234CC0")]
	private static bool NKOACHODLDP(string OAAJEIOFMBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x72344A0", Offset = "0x72336A0", VA = "0x1872344A0")]
	[AsyncStateMachine(typeof(HAPAJDHNOPI))]
	private static Task<Scene> GDDFCAEIIAE(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7234A70", Offset = "0x7233C70", VA = "0x187234A70")]
	public static MAKKFMNHCEA<Scene> LFEKPHEGIOA(string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7234E40", Offset = "0x7234040", VA = "0x187234E40")]
	public static OABICBNODGM ONGOHBNILKI(string OAAJEIOFMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7234DB0", Offset = "0x7233FB0", VA = "0x187234DB0")]
	[IteratorStateMachine(typeof(OCONHDPIMKC))]
	private static IEnumerator<JMPDKMJKKGA> NOEJHMIDNMH(string OAAJEIOFMBJ, CNPNGJHMILJ ANNBNNHJHOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7234180", Offset = "0x7233380", VA = "0x187234180")]
	[IteratorStateMachine(typeof(EMELHLEAEOF))]
	private static IEnumerator<JMPDKMJKKGA> FODCLPNBNKF(string OAAJEIOFMBJ, LoadSceneMode FNKBKFNBBPN, DPHELOEKPOL<Scene> ANNBNNHJHOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7234220", Offset = "0x7233420", VA = "0x187234220")]
	public static bool GBCKCKHEOFE([Out] string HFEDNPGALEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NHOILCEDDGM
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x72317A0", Offset = "0x72309A0", VA = "0x1872317A0")]
	public static IDisposable AOIIIKABCIA(this BNDKJFEMLMG CNBJCJOALNK, float NPEJJPOODJL, Action<float> IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x72318B0", Offset = "0x7230AB0", VA = "0x1872318B0")]
	public static IDisposable JFKEDNFNABI(this BNDKJFEMLMG CNBJCJOALNK, Action<float> IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7231830", Offset = "0x7230A30", VA = "0x187231830")]
	public static IDisposable FCOIECKGMKL(this BNDKJFEMLMG CNBJCJOALNK, Action<float> IDBCFENKBMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class GCGGEHBOKLK
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x72224D0", Offset = "0x72216D0", VA = "0x1872224D0")]
	public static IDisposable FPLFFAIFCGP(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7222560", Offset = "0x7221760", VA = "0x187222560")]
	public static IDisposable FPLFFAIFCGP(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7222950", Offset = "0x7221B50", VA = "0x187222950")]
	public static IDisposable LHGGKPHIKGE(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x72228D0", Offset = "0x7221AD0", VA = "0x1872228D0")]
	public static IDisposable LFENBOKJKMG(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7222850", Offset = "0x7221A50", VA = "0x187222850")]
	public static IDisposable LFENBOKJKMG(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x72223A0", Offset = "0x72215A0", VA = "0x1872223A0")]
	public static IDisposable ECEIDBDCEGN(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x72225F0", Offset = "0x72217F0", VA = "0x1872225F0")]
	public static IDisposable IAADPOODKJK(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7222AF0", Offset = "0x7221CF0", VA = "0x187222AF0")]
	public static IDisposable MALPNKLOAFE(this MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x72222F0", Offset = "0x72214F0", VA = "0x1872222F0")]
	public static IDisposable DELPHDHAJIG(this MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x72229D0", Offset = "0x7221BD0", VA = "0x1872229D0")]
	public static IDisposable LKHCOPPEALP(this MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7222670", Offset = "0x7221870", VA = "0x187222670")]
	public static IDisposable JPJCGNANANK(this MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7222B70", Offset = "0x7221D70", VA = "0x187222B70")]
	public static IDisposable NENMGAPHFJG(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7222710", Offset = "0x7221910", VA = "0x187222710")]
	public static IDisposable KAPEHGAJACK(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7222C10", Offset = "0x7221E10", VA = "0x187222C10")]
	public static IDisposable OFDJOLLIENH(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7222250", Offset = "0x7221450", VA = "0x187222250")]
	public static IDisposable DEFIMBJNAIG(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x72221B0", Offset = "0x72213B0", VA = "0x1872221B0")]
	public static IDisposable CKHEGCJHHKE(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x72227B0", Offset = "0x72219B0", VA = "0x1872227B0")]
	public static IDisposable KJMMNEELJAG(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7222110", Offset = "0x7221310", VA = "0x187222110")]
	public static IDisposable BCIIHHLKMEA(this MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7222420", Offset = "0x7221620", VA = "0x187222420")]
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
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public GENFGEPLDJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7222CB0", Offset = "0x7221EB0", VA = "0x187222CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7222D90", Offset = "0x7221F90", VA = "0x187222D90", Slot = "8")]
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
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public ICILIKIFCAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7227D70", Offset = "0x7226F70", VA = "0x187227D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7227E60", Offset = "0x7227060", VA = "0x187227E60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x721AC20", Offset = "0x7219E20", VA = "0x18721AC20")]
	public static GOOHGCNPLOF FPLFFAIFCGP(Action IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x721AA40", Offset = "0x7219C40", VA = "0x18721AA40")]
	public static GOOHGCNPLOF FPLFFAIFCGP(Behaviour CNBJCJOALNK, Action IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x721AB00", Offset = "0x7219D00", VA = "0x18721AB00")]
	public static GOOHGCNPLOF FPLFFAIFCGP(Behaviour CNBJCJOALNK, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x721AD60", Offset = "0x7219F60", VA = "0x18721AD60")]
	[IteratorStateMachine(typeof(GENFGEPLDJK))]
	private static IEnumerator<JMPDKMJKKGA> NCIMGCKPDOJ(NKLOKPDBJDH OHHDHLEHJDL, Action IDBCFENKBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x721ACD0", Offset = "0x7219ED0", VA = "0x18721ACD0")]
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
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public DBNPOENPCAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7220570", Offset = "0x721F770", VA = "0x187220570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7220600", Offset = "0x721F800", VA = "0x187220600", Slot = "8")]
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
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8569B0", Offset = "0x855BB0", VA = "0x1808569B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x721B040", Offset = "0x721A240", VA = "0x18721B040")]
	public ADNFIFODHNE(NKLOKPDBJDH EHKPGKAHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x721AF20", Offset = "0x721A120", VA = "0x18721AF20")]
	[IteratorStateMachine(typeof(DBNPOENPCAD))]
	private IEnumerator<JMPDKMJKKGA> COCKOFBEEHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x721AFA0", Offset = "0x721A1A0", VA = "0x18721AFA0", Slot = "4")]
	public void OnCompleted(Action KFANDDBANJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	public void NKCJMOMAIOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class DGBGLLMBLFB
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7220880", Offset = "0x721FA80", VA = "0x187220880")]
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
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public MIFKDOJFGAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x72307E0", Offset = "0x722F9E0", VA = "0x1872307E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7230860", Offset = "0x722FA60", VA = "0x187230860", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7231D60", Offset = "0x7230F60", VA = "0x187231D60")]
	public static GOOHGCNPLOF FPLFFAIFCGP(float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7231C50", Offset = "0x7230E50", VA = "0x187231C50")]
	public static GOOHGCNPLOF FPLFFAIFCGP(MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7231B30", Offset = "0x7230D30", VA = "0x187231B30")]
	public static GOOHGCNPLOF ADJOPOJCNLM(MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7231F80", Offset = "0x7231180", VA = "0x187231F80")]
	public static GOOHGCNPLOF ONOLLACNKEE(BNDKJFEMLMG CNBJCJOALNK, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7231EC0", Offset = "0x72310C0", VA = "0x187231EC0")]
	private static IEnumerator<JMPDKMJKKGA> NCIMGCKPDOJ(LIIPOKLEFGD GEGBGPONHGL, float NPEJJPOODJL, NKLOKPDBJDH OHHDHLEHJDL, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7231E60", Offset = "0x7231060", VA = "0x187231E60")]
	private static IEnumerator<JMPDKMJKKGA> IBNDPOOHMKP(LIIPOKLEFGD GEGBGPONHGL, float NPEJJPOODJL, NKLOKPDBJDH OHHDHLEHJDL, Action<float> IDBCFENKBMC, bool OKMCKCLHGJF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7232090", Offset = "0x7231290", VA = "0x187232090")]
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
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public HHGKEOAKIFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x72259F0", Offset = "0x7224BF0", VA = "0x1872259F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7225AB0", Offset = "0x7224CB0", VA = "0x187225AB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x721BFA0", Offset = "0x721B1A0", VA = "0x18721BFA0")]
	[IteratorStateMachine(typeof(HHGKEOAKIFP))]
	private static IEnumerator<JMPDKMJKKGA> LCLBNJNAEED(NKLOKPDBJDH EHKPGKAHKKL, Func<bool> NGPBJNKHNBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x721BE80", Offset = "0x721B080", VA = "0x18721BE80")]
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
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public DNNINHDHNNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x72209C0", Offset = "0x721FBC0", VA = "0x1872209C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7220A30", Offset = "0x721FC30", VA = "0x187220A30", Slot = "8")]
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
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public PHGNEHBKNNM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7235840", Offset = "0x7234A40", VA = "0x187235840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x72358D0", Offset = "0x7234AD0", VA = "0x1872358D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x722BCE0", Offset = "0x722AEE0", VA = "0x18722BCE0")]
	[IteratorStateMachine(typeof(DNNINHDHNNL))]
	private static IEnumerator<JMPDKMJKKGA> COCKOFBEEHB(float IOCCJIJEELD, NKLOKPDBJDH OHHDHLEHJDL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x722C1E0", Offset = "0x722B3E0", VA = "0x18722C1E0")]
	[IteratorStateMachine(typeof(PHGNEHBKNNM))]
	private static IEnumerator<JMPDKMJKKGA> KHCKBAMNOOD(float IOCCJIJEELD, NKLOKPDBJDH OHHDHLEHJDL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x722C280", Offset = "0x722B480", VA = "0x18722C280")]
	public static IDisposable LDECKOPNPII(this MonoBehaviour EIFNDIABMHD, float IOCCJIJEELD, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x722C020", Offset = "0x722B220", VA = "0x18722C020")]
	public static GOOHGCNPLOF HEBLAGHGIKD(this MonoBehaviour EIFNDIABMHD, float IOCCJIJEELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x722C3A0", Offset = "0x722B5A0", VA = "0x18722C3A0")]
	public static GOOHGCNPLOF LDECKOPNPII(this MonoBehaviour EIFNDIABMHD, float IOCCJIJEELD, NKLOKPDBJDH OHHDHLEHJDL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x722BE50", Offset = "0x722B050", VA = "0x18722BE50")]
	public static GOOHGCNPLOF DOODLMKCNBB(this MonoBehaviour EIFNDIABMHD, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x722C1B0", Offset = "0x722B3B0", VA = "0x18722C1B0")]
	public static GOOHGCNPLOF JIDBEOCAJGF(this MonoBehaviour EIFNDIABMHD, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x722BF40", Offset = "0x722B140", VA = "0x18722BF40")]
	public static GOOHGCNPLOF EMALFLIODFA(this MonoBehaviour EIFNDIABMHD, Action GPJOKKOGGOF, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x722C4D0", Offset = "0x722B6D0", VA = "0x18722C4D0")]
	public static GOOHGCNPLOF LHNAIPFFJGN(this MonoBehaviour EIFNDIABMHD, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x722C500", Offset = "0x722B700", VA = "0x18722C500")]
	public static GOOHGCNPLOF NHIMEFPNBDP(this MonoBehaviour EIFNDIABMHD, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x722BD80", Offset = "0x722AF80", VA = "0x18722BD80")]
	private static GOOHGCNPLOF DEIKPKFPGNP(MonoBehaviour EIFNDIABMHD, NKLOKPDBJDH EHKPGKAHKKL, Action GPJOKKOGGOF, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x722BB40", Offset = "0x722AD40", VA = "0x18722BB40")]
	public static GOOHGCNPLOF ADADKGIIPOI(this MonoBehaviour EIFNDIABMHD, float LKDIHAFBCJL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x722BE70", Offset = "0x722B070", VA = "0x18722BE70")]
	public static GOOHGCNPLOF ECGKHPHACJC(this MonoBehaviour EIFNDIABMHD, float LKDIHAFBCJL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x722C0E0", Offset = "0x722B2E0", VA = "0x18722C0E0")]
	public static GOOHGCNPLOF IKCENKMMNBC(this MonoBehaviour EIFNDIABMHD, float LKDIHAFBCJL, Action GPJOKKOGGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x722BC10", Offset = "0x722AE10", VA = "0x18722BC10")]
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
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x722F030", Offset = "0x722E230", VA = "0x18722F030", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NIMFNDMBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x722F510", Offset = "0x722E710", VA = "0x18722F510", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x722F5B0", Offset = "0x722E7B0", VA = "0x18722F5B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x722F780", Offset = "0x722E980", VA = "0x18722F780")]
	public KCNLJCBDKMI([Optional] Action IFMJIHFFPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x722F650", Offset = "0x722E850", VA = "0x18722F650")]
	public void PBLNBBGFGAP(LLDHOGPGHNI NOACPCMJNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x722EED0", Offset = "0x722E0D0", VA = "0x18722EED0")]
	private void FGGJKAEJENG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x722F500", Offset = "0x722E700", VA = "0x18722F500", Slot = "7")]
	public bool LLILENKEDLI(bool AMNFMCIBNPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x722F1F0", Offset = "0x722E3F0", VA = "0x18722F1F0", Slot = "8")]
	public bool LLILENKEDLI(Action ENGMCBPHJGL, bool AMNFMCIBNPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x722F170", Offset = "0x722E370", VA = "0x18722F170", Slot = "9")]
	public IEnumerator<LLDHOGPGHNI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x722F170", Offset = "0x722E370", VA = "0x18722F170", Slot = "10")]
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

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public FFPPJFKCEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7220850", Offset = "0x721FA50", VA = "0x187220850")]
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

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public DDJFHJNFFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7220850", Offset = "0x721FA50", VA = "0x187220850")]
		internal void EALHHCEEHPI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly float OMCHILFDFMG;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x722C570", Offset = "0x722B770", VA = "0x18722C570")]
	public OGBEIILKDNM(Behaviour CNBJCJOALNK, float OMCHILFDFMG, [Optional] Action IFMJIHFFPPI, [Optional] KDPJBHDNKMB EENOGKEJBMD, [Optional] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x72333F0", Offset = "0x72325F0", VA = "0x1872333F0", Slot = "9")]
	protected override bool EKBJPKNFGBL(Action ENGMCBPHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x72332E0", Offset = "0x72324E0", VA = "0x1872332E0", Slot = "10")]
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
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NIMFNDMBLGF;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LLILENKEDLI(bool AMNFMCIBNPO = false);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
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
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public BOPOGPGGHBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x721C030", Offset = "0x721B230", VA = "0x18721C030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x721C100", Offset = "0x721B300", VA = "0x18721C100", Slot = "8")]
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
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xE93160", Offset = "0xE92360", VA = "0x180E93160", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NIMFNDMBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7221B80", Offset = "0x7220D80", VA = "0x187221B80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7221C20", Offset = "0x7220E20", VA = "0x187221C20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7221F00", Offset = "0x7221100", VA = "0x187221F00")]
	protected FBLILNPFBIB(Behaviour CNBJCJOALNK, [Optional] Action IFMJIHFFPPI, [Optional] KDPJBHDNKMB EENOGKEJBMD, [Optional] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7221AC0", Offset = "0x7220CC0", VA = "0x187221AC0", Slot = "7")]
	public bool LLILENKEDLI(bool AMNFMCIBNPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7221B20", Offset = "0x7220D20", VA = "0x187221B20", Slot = "8")]
	public bool LLILENKEDLI(Action ENGMCBPHJGL, bool AMNFMCIBNPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool EKBJPKNFGBL(Action ENGMCBPHJGL);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool AFPNCJNBFKB(Action ENGMCBPHJGL);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7221A60", Offset = "0x7220C60", VA = "0x187221A60")]
	protected void FKHPKIDDPCF(Action ENGMCBPHJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7221CC0", Offset = "0x7220EC0", VA = "0x187221CC0")]
	protected OABICBNODGM OFGKMIEGPBF(float HIEBMCLPBGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7221950", Offset = "0x7220B50", VA = "0x187221950")]
	private void CGEPDHMIKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x72219D0", Offset = "0x7220BD0", VA = "0x1872219D0")]
	[IteratorStateMachine(typeof(BOPOGPGGHBB))]
	private IEnumerator<JMPDKMJKKGA> ECHPKDMMNDJ(float HIEBMCLPBGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7221A80", Offset = "0x7220C80", VA = "0x187221A80")]
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

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x721C520", Offset = "0x721B720", VA = "0x18721C520")]
	public CFJLNPENHCE(Behaviour CNBJCJOALNK, float KANEHIICLBC, int IGCNOOKAODM, [Optional] Action IFMJIHFFPPI, float BFMBJEBPENO = 0f, [Optional] KDPJBHDNKMB EENOGKEJBMD, [Optional] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "9")]
	protected override bool EKBJPKNFGBL(Action ENGMCBPHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x721C2A0", Offset = "0x721B4A0", VA = "0x18721C2A0", Slot = "10")]
	protected override bool AFPNCJNBFKB(Action ENGMCBPHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x721C4A0", Offset = "0x721B6A0", VA = "0x18721C4A0")]
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

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x722C570", Offset = "0x722B770", VA = "0x18722C570")]
	public IHNFHPLPIBI(Behaviour CNBJCJOALNK, float OMCHILFDFMG, [Optional] Action IFMJIHFFPPI, [Optional] KDPJBHDNKMB EENOGKEJBMD, [Optional] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "9")]
	protected override bool EKBJPKNFGBL(Action ENGMCBPHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x722C530", Offset = "0x722B730", VA = "0x18722C530", Slot = "10")]
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
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public FBEPCEKHODG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x721B470", Offset = "0x721A670", VA = "0x18721B470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7221900", Offset = "0x7220B00", VA = "0x187221900", Slot = "8")]
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

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x72315C0", Offset = "0x72307C0", VA = "0x1872315C0")]
	public NFODEPECADG(BNDKJFEMLMG CNBJCJOALNK, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7231240", Offset = "0x7230440", VA = "0x187231240")]
	private void KMBBNIEKLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7231460", Offset = "0x7230660", VA = "0x187231460")]
	private void PAJGNJAEKCG(string GGEHLADLJHF, Action OPJGMCDIFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x72313E0", Offset = "0x72305E0", VA = "0x1872313E0")]
	[IteratorStateMachine(typeof(FBEPCEKHODG))]
	private IEnumerator<JMPDKMJKKGA> MBPCMIOAPKC(Action OPJGMCDIFJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x72311E0", Offset = "0x72303E0", VA = "0x1872311E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7231030", Offset = "0x7230230", VA = "0x187231030")]
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
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public ALIKJFKEMBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x721B470", Offset = "0x721A670", VA = "0x18721B470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x721B4E0", Offset = "0x721A6E0", VA = "0x18721B4E0", Slot = "8")]
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

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7226960", Offset = "0x7225B60", VA = "0x187226960")]
	public HJHAHAOKKNM(MonoBehaviour EIFNDIABMHD, Action IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7226B50", Offset = "0x7225D50", VA = "0x187226B50")]
	public HJHAHAOKKNM(MonoBehaviour EIFNDIABMHD, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7226710", Offset = "0x7225910", VA = "0x187226710")]
	public HJHAHAOKKNM(MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1C05420", Offset = "0x1C04620", VA = "0x181C05420")]
	private HJHAHAOKKNM(KDPJBHDNKMB EENOGKEJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7225F20", Offset = "0x7225120", VA = "0x187225F20")]
	internal static HJHAHAOKKNM GPJLJPBNEGO(MonoBehaviour EIFNDIABMHD, float NPEJJPOODJL, Action<float> IDBCFENKBMC, NKLOKPDBJDH EHKPGKAHKKL, bool OKMCKCLHGJF = true, [Optional] KDPJBHDNKMB EENOGKEJBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7225DB0", Offset = "0x7224FB0", VA = "0x187225DB0")]
	private void FPLFFAIFCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7226050", Offset = "0x7225250", VA = "0x187226050")]
	private void ICAFKBLEOFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7226320", Offset = "0x7225520", VA = "0x187226320")]
	private void KMBBNIEKLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7225BF0", Offset = "0x7224DF0", VA = "0x187225BF0")]
	private void EEEMKHLDHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x72265E0", Offset = "0x72257E0", VA = "0x1872265E0")]
	private void PAJGNJAEKCG(string GGEHLADLJHF, Action OPJGMCDIFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7226560", Offset = "0x7225760", VA = "0x187226560")]
	[IteratorStateMachine(typeof(ALIKJFKEMBG))]
	private IEnumerator<JMPDKMJKKGA> MBPCMIOAPKC(Action OPJGMCDIFJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7225B90", Offset = "0x7224D90", VA = "0x187225B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7225B00", Offset = "0x7224D00", VA = "0x187225B00")]
	[CompilerGenerated]
	private void DLHOPFCHLFL(string HBEPHPNHPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7226200", Offset = "0x7225400", VA = "0x187226200")]
	[CompilerGenerated]
	private void JOFAJPJOLHJ(string HBEPHPNHPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7226290", Offset = "0x7225490", VA = "0x187226290")]
	[CompilerGenerated]
	private void JPABAPABIIB(string HBEPHPNHPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x72264D0", Offset = "0x72256D0", VA = "0x1872264D0")]
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
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x721BE50", Offset = "0x721B050", VA = "0x18721BE50", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float KNOOFIBNBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x721BE40", Offset = "0x721B040", VA = "0x18721BE40", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double AMJPOMIJLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x721BE60", Offset = "0x721B060", VA = "0x18721BE60", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x721BDD0", Offset = "0x721AFD0", VA = "0x18721BDD0")]
	[GDGALFJPCGE(JMIPDAHBNNG.None)]
	private static void CEJDNEABNOB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	[Preserve]
	internal BAJNEHIKIIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface MOAJGBJCCIC
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKPOOBMLFGL(string BHFPKCCDEEC);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJCDHLLHHCI();
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface CODIAPFGOPD
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool CKCBOLCFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool EMICDMPMLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
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
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x8513A0", VA = "0x1808521A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851B10", VA = "0x180852910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x721A570", Offset = "0x7219770", VA = "0x18721A570")]
	public static JMPDKMJKKGA CDPNMICCKHN(IEnumerator<JMPDKMJKKGA> EIJLCAJMEGF, NCLBBPBAMHF KEGEDGBLGGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x721A6D0", Offset = "0x72198D0", VA = "0x18721A6D0")]
	public JMPDKMJKKGA CDPNMICCKHN(NCLBBPBAMHF[] DBDNOEOCGDN, IEnumerator<JMPDKMJKKGA>[] OEGKMJGAGAF, JMPDKMJKKGA[] MCBPHILBEPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x721A790", Offset = "0x7219990", VA = "0x18721A790")]
	public void GMGHFIFDHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x721A7C0", Offset = "0x72199C0", VA = "0x18721A7C0")]
	public void ODPBCFIFNBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x721A900", Offset = "0x7219B00", VA = "0x18721A900")]
	public void PODFLMIALEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x721A790", Offset = "0x7219990", VA = "0x18721A790")]
	public void GINDKEMMJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public ODKKPMLFFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7232830", Offset = "0x7231A30", VA = "0x187232830")]
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

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public PJECEIFBODK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7235920", Offset = "0x7234B20", VA = "0x187235920")]
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

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public MGJIHEDDDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x72307A0", Offset = "0x722F9A0", VA = "0x1872307A0")]
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

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public IEPOGJACGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7228AC0", Offset = "0x7227CC0", VA = "0x187228AC0")]
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
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8BEDD0", Offset = "0x8BDFD0", VA = "0x1808BEDD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x722A390", Offset = "0x7229590", VA = "0x18722A390")]
	private static int MKPPMLNGCJG(NKLOKPDBJDH EHKPGKAHKKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x722AE60", Offset = "0x722A060", VA = "0x18722AE60")]
	public IFGLAEILLBD(NKLOKPDBJDH EHKPGKAHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x72295A0", Offset = "0x72287A0", VA = "0x1872295A0")]
	private void HDOAFLAHLPG(int FABKPEEAHMB, int FABKOFGFJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7229780", Offset = "0x7228980", VA = "0x187229780")]
	public void JNJINNMJHHP(BNDKJFEMLMG CNBJCJOALNK, JMPDKMJKKGA PBLNBIDNEIN, IEnumerator<JMPDKMJKKGA> EIJLCAJMEGF, NCLBBPBAMHF KEGEDGBLGGL, [Optional] ABBOJKOJFFI GLKOPLCPHJM, OAAJKFGGKEL JANJEJNBMBD = OAAJKFGGKEL.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7229360", Offset = "0x7228560", VA = "0x187229360")]
	public void HDMLFENMIIH(IEnumerable<EKNALJMIAOJ> ODFJEHIJKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x722A5F0", Offset = "0x72297F0", VA = "0x18722A5F0")]
	private EKNALJMIAOJ ONMCKDLEDBH(int JHHJHBCLCCJ)
	{
		return default(EKNALJMIAOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7228B00", Offset = "0x7227D00", VA = "0x187228B00")]
	private void ECCEHINHHIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A2F0", Offset = "0x2B894F0", VA = "0x182B8A2F0")]
	private static void LNKKOMPNDOA<T>(int JHHJHBCLCCJ, T[] IHOJEMLHKFM, int ECGAAJFODGN, [Optional] T ELEPHPKCELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A340", Offset = "0x2B89540", VA = "0x182B8A340")]
	private static void LNKKOMPNDOA<T>(int JHHJHBCLCCJ, NativeArray<T> IHOJEMLHKFM, int ECGAAJFODGN, [Optional] T ELEPHPKCELN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x722AAC0", Offset = "0x7229CC0", VA = "0x18722AAC0")]
	private void PHJMOAGLDLI(IEnumerable<EKNALJMIAOJ> ODFJEHIJKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7229170", Offset = "0x7228370", VA = "0x187229170")]
	private void FBCKHPDMDCE(EKNALJMIAOJ AFIEEBJNELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x722A130", Offset = "0x7229330", VA = "0x18722A130")]
	private MOABMEILMEH MABMKGGMFPK(int DHDFALGOKLI)
	{
		return default(MOABMEILMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7228F70", Offset = "0x7228170", VA = "0x187228F70")]
	public void EKKBOLGADGM(float KBAMMELOGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x722A570", Offset = "0x7229770", VA = "0x18722A570")]
	private void OBACGHPDCHL(Action MLFGLJKBOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x722A3C0", Offset = "0x72295C0", VA = "0x18722A3C0")]
	private void MMBHBBCIPND(Action MLFGLJKBOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7229A30", Offset = "0x7228C30", VA = "0x187229A30")]
	public void LFAGPFKGJEE(float KBAMMELOGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7228E70", Offset = "0x7228070", VA = "0x187228E70")]
	public void EECPCLJADFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7229230", Offset = "0x7228430", VA = "0x187229230")]
	public void GINDKEMMJIL(ABBOJKOJFFI DKNNEBCHBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x722A440", Offset = "0x7229640", VA = "0x18722A440")]
	public void NICGIFDENMA(ABBOJKOJFFI DKNNEBCHBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7229900", Offset = "0x7228B00", VA = "0x187229900")]
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

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8523E0", VA = "0x1808531E0")]
	public FCPGJGEBLCK(Action BDILBDIGJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x69C8340", Offset = "0x69C7540", VA = "0x1869C8340", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable HIFMEIAAFOH(UnityEngine.Object CNBJCJOALNK, Action<T> NANKILKEHAL);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface NHEEEANKMEK<T> : NLIFGMIPBIB<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T JNHPIMBJPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
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

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public DELOAJBDMKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x57627D0", Offset = "0x57619D0", VA = "0x1857627D0")]
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
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x920B50", Offset = "0x91FD50", VA = "0x180920B50", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4E50800", Offset = "0x4E4FA00", VA = "0x184E50800", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4E50660", Offset = "0x4E4F860", VA = "0x184E50660")]
	private static bool JKONKPFGDNM(T MLFGLJKBOIG, T GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4E508A0", Offset = "0x4E4FAA0", VA = "0x184E508A0")]
	public BLJCLDFLDND(T KLDLAHEBNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4E50300", Offset = "0x4E4F500", VA = "0x184E50300", Slot = "6")]
	public IDisposable HIFMEIAAFOH(UnityEngine.Object CNBJCJOALNK, Action<T> NANKILKEHAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4E4FFE0", Offset = "0x4E4F1E0", VA = "0x184E4FFE0")]
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

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x721B350", Offset = "0x721A550", VA = "0x18721B350")]
	[GDGALFJPCGE(JMIPDAHBNNG.None)]
	private static void CEJDNEABNOB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8523E0", VA = "0x1808531E0")]
	[Preserve]
	internal AGIBCGMFBLL([OMAPKKAGFIL(null)] KDPJBHDNKMB EENOGKEJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x721B3C0", Offset = "0x721A5C0", VA = "0x18721B3C0", Slot = "4")]
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

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7227390", Offset = "0x7226590", VA = "0x187227390")]
	[GDGALFJPCGE(JMIPDAHBNNG.None)]
	private static void CEJDNEABNOB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7227CB0", Offset = "0x7226EB0", VA = "0x187227CB0")]
	[Preserve]
	public ICHGKLBBNIP([OMAPKKAGFIL(null)] IHCGHJBEAFE CBHFJINNKJG, [OMAPKKAGFIL(null)] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7227110", Offset = "0x7226310", VA = "0x187227110", Slot = "18")]
	public override GOOHGCNPLOF AAIGGIEKNJG(BNDKJFEMLMG CNBJCJOALNK, IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7227760", Offset = "0x7226960", VA = "0x187227760", Slot = "19")]
	public override void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7227460", Offset = "0x7226660", VA = "0x187227460", Slot = "21")]
	public override void FMEAIHHBFHB(NKLOKPDBJDH EHKPGKAHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7227690", Offset = "0x7226890", VA = "0x187227690", Slot = "20")]
	protected override void LHGGKPHIKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7227240", Offset = "0x7226440", VA = "0x187227240")]
	private IFGLAEILLBD BJPNJJEGNAC(NKLOKPDBJDH NCMHJNKFAGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7227A00", Offset = "0x7226C00", VA = "0x187227A00", Slot = "22")]
	internal override APIAJIDAPLD NMBKKAAPNEO(IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM, Behaviour CNBJCJOALNK, NCLBBPBAMHF KEGEDGBLGGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7227C30", Offset = "0x7226E30", VA = "0x187227C30", Slot = "23")]
	internal override GKEDDHBBPHF OOFEIFMFNLH(NKLOKPDBJDH OHHDHLEHJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7227270", Offset = "0x7226470", VA = "0x187227270")]
	private void BNLGAKGCPLD(IFGLAEILLBD LILJLJFDBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7227400", Offset = "0x7226600", VA = "0x187227400", Slot = "24")]
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

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x722CA90", Offset = "0x722BC90", VA = "0x18722CA90")]
	public static IKFCPIOOIDK JGIIBNEOBDO(int IPINNKDPCLL, float KBAMMELOGGL, NativeArray<OAAJKFGGKEL> BFFKIAEGOLD, NativeArray<float> CMFFPDILCKI, NativeArray<int> FLEPCEHBPAK, NativeArray<int> CCDJPKJIAOM, NativeArray<int> JJFOHCPBBBA, NativeArray<int> EDNHBKHPHEL, NativeArray<int> IHLLKDEEELK)
	{
		return default(IKFCPIOOIDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x722C740", Offset = "0x722B940", VA = "0x18722C740", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x722CB90", Offset = "0x722BD90", VA = "0x18722CB90")]
	private bool LKGOBOJDMIG(int DHNLEFJCEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x722C820", Offset = "0x722BA20", VA = "0x18722C820")]
	private void FPGONOMCGMO(NativeArray<int> GHJMPEDKGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x722CAF0", Offset = "0x722BCF0", VA = "0x18722CAF0")]
	private int KNDCNKKKJND(int IGFCIJKKLLO, int CFBPCIPAGLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x722C670", Offset = "0x722B870", VA = "0x18722C670")]
	private void AJAPKNMPFKL(NativeArray<int> GHJMPEDKGHI, int LODIOKPFBJE, int DLFEHJOHIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x722C850", Offset = "0x722BA50", VA = "0x18722C850")]
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
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x722CE00", Offset = "0x722C000", VA = "0x18722CE00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool HPJBMFGHLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NKLOKPDBJDH BEABEPCNLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x8513A0", VA = "0x1808521A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(NKLOKPDBJDH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851B10", VA = "0x180852910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public LIIPOKLEFGD JBFLLCIBMLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public JMPDKMJKKGA EPEBMPAEFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x855DC0", VA = "0x180856BC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public JMPDKMJKKGA NBFFMJNHMLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x856AB0", Offset = "0x855CB0", VA = "0x180856AB0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public JMPDKMJKKGA NBHIPNGDHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8569D0", Offset = "0x855BD0", VA = "0x1808569D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x722D7C0", Offset = "0x722C9C0", VA = "0x18722D7C0")]
	public static GOOHGCNPLOF NAAFBKAMHFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x722DB10", Offset = "0x722CD10", VA = "0x18722DB10")]
	[Preserve]
	protected IOMCJGKMHHO([OMAPKKAGFIL(null)] IHCGHJBEAFE CBHFJINNKJG, [OMAPKKAGFIL(null)] LIIPOKLEFGD GEGBGPONHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x722CBD0", Offset = "0x722BDD0", VA = "0x18722CBD0", Slot = "6")]
	public GOOHGCNPLOF AGALHLJOLPH(IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x722CBE0", Offset = "0x722BDE0", VA = "0x18722CBE0", Slot = "7")]
	public GOOHGCNPLOF AGALHLJOLPH(Behaviour CNBJCJOALNK, IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract GOOHGCNPLOF AAIGGIEKNJG(BNDKJFEMLMG CNBJCJOALNK, IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x722D620", Offset = "0x722C820", VA = "0x18722D620", Slot = "19")]
	public virtual void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x722D8B0", Offset = "0x722CAB0", VA = "0x18722D8B0", Slot = "9")]
	public void OPIEDMMDNAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x722D600", Offset = "0x722C800", VA = "0x18722D600", Slot = "20")]
	protected virtual void LHGGKPHIKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x722DAF0", Offset = "0x722CCF0", VA = "0x18722DAF0")]
	private void PLGKALAENJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x722D5C0", Offset = "0x722C7C0", VA = "0x18722D5C0")]
	private void JIKEKNHPFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x722D5E0", Offset = "0x722C7E0", VA = "0x18722D5E0")]
	private void LFENBOKJKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x722D210", Offset = "0x722C410", VA = "0x18722D210")]
	private void ECEIDBDCEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x722CDE0", Offset = "0x722BFE0", VA = "0x18722CDE0")]
	private void BACFBLGCIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x722D5A0", Offset = "0x722C7A0", VA = "0x18722D5A0")]
	private void GHJBHFHJJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x722D460", Offset = "0x722C660", VA = "0x18722D460")]
	private void FBPDICHEEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x722D480", Offset = "0x722C680", VA = "0x18722D480", Slot = "21")]
	public virtual void FMEAIHHBFHB(NKLOKPDBJDH EHKPGKAHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x722D230", Offset = "0x722C430", VA = "0x18722D230")]
	private void EKBIOCDPDCC(GKEDDHBBPHF LILJLJFDBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1ECA900", Offset = "0x1EC9B00", VA = "0x181ECA900")]
	private GKEDDHBBPHF GPNJIMJDMLH(NKLOKPDBJDH NCMHJNKFAGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract APIAJIDAPLD NMBKKAAPNEO(IEnumerator<JMPDKMJKKGA> EPOHJLFGGJM, Behaviour EIFNDIABMHD, NCLBBPBAMHF BCFDANNEBLN);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract GKEDDHBBPHF OOFEIFMFNLH(NKLOKPDBJDH EHKPGKAHKKL);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x722CE50", Offset = "0x722C050", VA = "0x18722CE50", Slot = "24")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x722D850", Offset = "0x722CA50", VA = "0x18722D850", Slot = "14")]
	public JMPDKMJKKGA OENNPNHBBJC(NKLOKPDBJDH OHHDHLEHJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x722D510", Offset = "0x722C710", VA = "0x18722D510", Slot = "15")]
	public JMPDKMJKKGA GEADBELPKFM(float IOCCJIJEELD, NKLOKPDBJDH OHHDHLEHJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x722D400", Offset = "0x722C600", VA = "0x18722D400", Slot = "16")]
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

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public IEnumerator<JMPDKMJKKGA> FLKPJCHDHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x8522F0", VA = "0x1808530F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public JMPDKMJKKGA EKNDMFBLNDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851A90", VA = "0x180852890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool JBJPGJHFCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x721BA40", Offset = "0x721AC40", VA = "0x18721BA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool ONJMHJBJGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x9E7440", Offset = "0x9E6640", VA = "0x1809E7440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x9E7560", Offset = "0x9E6760", VA = "0x1809E7560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x721B530", Offset = "0x721A730", VA = "0x18721B530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float LFOBCGIPDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8BF080", Offset = "0x8BE280", VA = "0x1808BF080")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5E74BA0", Offset = "0x5E73DA0", VA = "0x185E74BA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x721BC10", Offset = "0x721AE10", VA = "0x18721BC10")]
	public APIAJIDAPLD(IEnumerator<JMPDKMJKKGA> EIJLCAJMEGF, CODIAPFGOPD CNBJCJOALNK, NCLBBPBAMHF KEGEDGBLGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x721B6E0", Offset = "0x721A8E0", VA = "0x18721B6E0")]
	public JMPDKMJKKGA CDPNMICCKHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x721BAC0", Offset = "0x721ACC0", VA = "0x18721BAC0")]
	public bool NGGPFPHINMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x721B9F0", Offset = "0x721ABF0", VA = "0x18721B9F0")]
	public void GINDKEMMJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x721BB30", Offset = "0x721AD30", VA = "0x18721BB30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xA74A30", Offset = "0xA73C30", VA = "0x180A74A30")]
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

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private NKLOKPDBJDH PNBJOONMBAM
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x101F3D0", Offset = "0x101E5D0", VA = "0x18101F3D0", Slot = "23")]
		get
		{
			return default(NKLOKPDBJDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NKLOKPDBJDH OELHCGFHGDG
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1558890", Offset = "0x1557A90", VA = "0x181558890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private float ONAEKNIHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xA12480", Offset = "0xA11680", VA = "0x180A12480", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool JIDFDPNJHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7230F10", Offset = "0x7230110", VA = "0x187230F10", Slot = "24")]
	private bool FEHOLLONLMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7230F00", Offset = "0x7230100", VA = "0x187230F00", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7230F30", Offset = "0x7230130", VA = "0x187230F30")]
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

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public EIPBBNGHMHP[,] KEMPACPFDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8569D0", Offset = "0x855BD0", VA = "0x1808569D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x72242F0", Offset = "0x72234F0", VA = "0x1872242F0")]
	public GKEDDHBBPHF(NKLOKPDBJDH OHHDHLEHJDL, MOAJGBJCCIC HIBDLNMCMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x72232F0", Offset = "0x72224F0", VA = "0x1872232F0")]
	public void GNHGIFNNAPC(APIAJIDAPLD EIJLCAJMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7222ED0", Offset = "0x72220D0", VA = "0x187222ED0")]
	public void AFAACFHELFH(IList<APIAJIDAPLD> OEGKMJGAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x72239F0", Offset = "0x7222BF0", VA = "0x1872239F0")]
	public void MHKICLCBKMA(IList<APIAJIDAPLD> OEGKMJGAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7222DE0", Offset = "0x7221FE0", VA = "0x187222DE0")]
	private void AEOHMEFFKEG(APIAJIDAPLD EIJLCAJMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7223CF0", Offset = "0x7222EF0", VA = "0x187223CF0")]
	private void MHLBIFJCCGO(IList<APIAJIDAPLD> OEGKMJGAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7223400", Offset = "0x7222600", VA = "0x187223400")]
	private MOABMEILMEH HCKBAMIAOJE(APIAJIDAPLD EIJLCAJMEGF)
	{
		return default(MOABMEILMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7223580", Offset = "0x7222780", VA = "0x187223580")]
	public void LHGGKPHIKGE(float KBAMMELOGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7223FC0", Offset = "0x72231C0", VA = "0x187223FC0")]
	public void OPIEDMMDNAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x72236F0", Offset = "0x72228F0", VA = "0x1872236F0")]
	private void MCAHMGGFHDG(List<APIAJIDAPLD> OEGKMJGAGAF, Stack<int> PANADDMBAOL, bool ADAFGDHBPEA, float FHBFPMOOFPA = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x72231D0", Offset = "0x72223D0", VA = "0x1872231D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7223E80", Offset = "0x7223080", VA = "0x187223E80")]
	private void NPFNKPKAMHJ(List<APIAJIDAPLD> OEGKMJGAGAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class AEDPFLPPAOP : MOAJGBJCCIC
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "4")]
	public void NKPOOBMLFGL(string BHFPKCCDEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
	public void HJCDHLLHHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x721C150", Offset = "0x721B350", VA = "0x18721C150", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool CKCBOLCFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x721C1F0", Offset = "0x721B3F0", VA = "0x18721C1F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool EMICDMPMLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x721C1D0", Offset = "0x721B3D0", VA = "0x18721C1D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8523E0", VA = "0x1808531E0")]
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

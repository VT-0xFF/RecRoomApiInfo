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
		private delegate List<PlayerLoopSystem> NNNGGLDFMBN(List<PlayerLoopSystem> CFNFPMOAHPJ, int GDKEEEAPPGM);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct ABCAPHLPEOP
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct KGICHKKCFOL
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static IDDBOOGKPOH NALOKAPDHEL;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x722F1A0", Offset = "0x722E5A0", VA = "0x18722F1A0")]
				public static PlayerLoopSystem DLFHKPCPCPA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct CEMACNEGKEO
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static IDDBOOGKPOH MOFOHCACHLA;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x721D110", Offset = "0x721C510", VA = "0x18721D110")]
				public static PlayerLoopSystem DLFHKPCPCPA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct MHMOBMJEFAD
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static IDDBOOGKPOH LBJICMFLHHF;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x7232240", Offset = "0x7231640", VA = "0x187232240")]
				public static PlayerLoopSystem DLFHKPCPCPA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct NLBHDGMGJEC
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDDBOOGKPOH CBFDNONLJHC;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static IDDBOOGKPOH MGIHDKKBGJP;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static IDDBOOGKPOH DHIGGAFPLJI;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IDDBOOGKPOH HEALPEGOENG;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x7233940", Offset = "0x7232D40", VA = "0x187233940")]
				public static PlayerLoopSystem DLFHKPCPCPA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct PDMLCFMAKEB
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static IDDBOOGKPOH KJMMLIKCNIK;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x7235C90", Offset = "0x7235090", VA = "0x187235C90")]
				public static PlayerLoopSystem DLFHKPCPCPA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct OOBJLNMDOPF
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static IDDBOOGKPOH CBFDNONLJHC;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static IDDBOOGKPOH MGIHDKKBGJP;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static IDDBOOGKPOH DHIGGAFPLJI;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static IDDBOOGKPOH HEALPEGOENG;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x7235870", Offset = "0x7234C70", VA = "0x187235870")]
				public static PlayerLoopSystem DLFHKPCPCPA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct DAFLKPDKPCF
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static IDDBOOGKPOH HPCJNMJIPGJ;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x7222D30", Offset = "0x7222130", VA = "0x187222D30")]
				public static PlayerLoopSystem DLFHKPCPCPA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct DNENDLNALDM
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static IDDBOOGKPOH MJHHALHMBBF;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x7223620", Offset = "0x7222A20", VA = "0x187223620")]
				public static PlayerLoopSystem DLFHKPCPCPA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct HDBDGMCEEIA
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static IDDBOOGKPOH GNPAHELNCKF;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x722C5D0", Offset = "0x722B9D0", VA = "0x18722C5D0")]
				public static PlayerLoopSystem DLFHKPCPCPA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct EPIFJHNCNIB
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static IDDBOOGKPOH HNEODEJMLPC;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x7229AC0", Offset = "0x7228EC0", VA = "0x187229AC0")]
				public static PlayerLoopSystem DLFHKPCPCPA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct EBFCBOJPCBI
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static IDDBOOGKPOH DCKADLGCNAD;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x7224A70", Offset = "0x7223E70", VA = "0x187224A70")]
				public static PlayerLoopSystem DLFHKPCPCPA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct PNJDNBFFOIJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static IDDBOOGKPOH DOOOKKBKNFG;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x7236BB0", Offset = "0x7235FB0", VA = "0x187236BB0")]
				public static PlayerLoopSystem DLFHKPCPCPA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct NOKLNMCAEOG
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static IDDBOOGKPOH PFGHONEEIKN;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x7234260", Offset = "0x7233660", VA = "0x187234260")]
				public static PlayerLoopSystem DLFHKPCPCPA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public enum OCAMHAHMKIG : byte
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
			public struct FGNOMDFOFIH
			{
				[Cpp2IlInjected.Token(Token = "0x2000021")]
				[CompilerGenerated]
				private sealed class FIFONCFJDDO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public OCAMHAHMKIG updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
					public FIFONCFJDDO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x722B750", Offset = "0x722AB50", VA = "0x18722B750")]
					internal void ANLHCNHFELD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static HLCMNEBCMLD<OCAMHAHMKIG> DAEGBFGKLFD;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x722B580", Offset = "0x722A980", VA = "0x18722B580")]
				public static PlayerLoopSystem DLFHKPCPCPA(OCAMHAHMKIG DAJLBHAEDJK)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			internal struct NNEPJAPHDNP
			{
				[Cpp2IlInjected.Token(Token = "0x2000023")]
				[CompilerGenerated]
				private sealed class MMAOMIIKHNM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public DKNICLIGIEK.NIFBDKGLFIM key;

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
					public MMAOMIIKHNM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x7232A30", Offset = "0x7231E30", VA = "0x187232A30")]
					internal void AHIGIMAIOCG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable DEDBMLDJOBF;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x7234050", Offset = "0x7233450", VA = "0x187234050")]
				public static PlayerLoopSystem IIOBFHLNOFL(DKNICLIGIEK.NIFBDKGLFIM PEDCMDADFIN)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000025")]
			internal struct OPJMEABAEGK
			{
				[Cpp2IlInjected.Token(Token = "0x2000026")]
				[CompilerGenerated]
				private sealed class FNOMKADEKML
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public DKNICLIGIEK.NIFBDKGLFIM key;

					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
					public FNOMKADEKML()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x722B880", Offset = "0x722AC80", VA = "0x18722B880")]
					internal void AHIGIMAIOCG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x7235B60", Offset = "0x7234F60", VA = "0x187235B60")]
				public static PlayerLoopSystem IIOBFHLNOFL(DKNICLIGIEK.NIFBDKGLFIM PEDCMDADFIN)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class HOPLBNBAHGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public HOPLBNBAHGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x722C810", Offset = "0x722BC10", VA = "0x18722C810")]
			internal List<PlayerLoopSystem> LPCPFGGHIFH(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool AHBCHLOGOHH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool GIMBJEPOEJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x721F110", Offset = "0x721E510", VA = "0x18721F110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x721F820", Offset = "0x721EC20", VA = "0x18721F820")]
		private static void MMADKNPPNGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7222420", Offset = "0x7221820", VA = "0x187222420")]
		private static void NGFJNBGGFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x721EE80", Offset = "0x721E280", VA = "0x18721EE80")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x721EEC0", Offset = "0x721E2C0", VA = "0x18721EEC0")]
		private static void BHFHJFLBHDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x721F660", Offset = "0x721EA60", VA = "0x18721F660")]
		private static void JLEGCKLKIMJ(DKNICLIGIEK.NIFBDKGLFIM PEDCMDADFIN, PlayerLoopSystem NAEKOPPPPKO, Type AMKGIPFDCKN, Type DNJEACJJMKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x721F150", Offset = "0x721E550", VA = "0x18721F150")]
		private static void ICOBNKCPCEO(PlayerLoopSystem NAEKOPPPPKO, Type AMKGIPFDCKN, Type DNJEACJJMKJ, NNNGGLDFMBN JGCEHICMPEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x721F530", Offset = "0x721E930", VA = "0x18721F530")]
		private static void IMPKEOCNNFA(PlayerLoopSystem NAEKOPPPPKO, Type AMKGIPFDCKN, Type DNJEACJJMKJ, PlayerLoopSystem? EMELKKGDCMA, PlayerLoopSystem? EOGIJLJBHKN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class DKNICLIGIEK
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum NIFBDKGLFIM
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
	public class NHCLEMBPJPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly NIFBDKGLFIM EBJAOLLCNHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly FALNLMIIOKH FCEFKGGLEIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private long HDHKPIDFJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long BHMHEKICELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long PIBACEPPBNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int OPEEHAFDKAO;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7233030", Offset = "0x7232430", VA = "0x187233030")]
		public NHCLEMBPJPC(NIFBDKGLFIM OAIMHPICEJH, int FAFFHBGHKEP = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7232FC0", Offset = "0x72323C0", VA = "0x187232FC0")]
		public void LCFBGDIDBOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7232F70", Offset = "0x7232370", VA = "0x187232F70")]
		public void IPFHKECMNEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7232D90", Offset = "0x7232190", VA = "0x187232D90")]
		public void DDKLJPKBGKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static NIFBDKGLFIM[] BKMPOHGBHPG;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static NHCLEMBPJPC[] EPNGIPHLCGP;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x72231B0", Offset = "0x72225B0", VA = "0x1872231B0")]
	public static NHCLEMBPJPC PPMNHJDFKNN(NIFBDKGLFIM PEDCMDADFIN, int FAFFHBGHKEP = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7223140", Offset = "0x7222540", VA = "0x187223140")]
	public static NHCLEMBPJPC PLGGPNKIOFJ(NIFBDKGLFIM PEDCMDADFIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x72230A0", Offset = "0x72224A0", VA = "0x1872230A0")]
	public static void PAAFIKBLPIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class FALNLMIIOKH : JACDIMCFGGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int NKOMHMOCEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Queue<double> FJJNCNKGJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double DNLNJGFKFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double JDOCBGNCGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double BDAGLBBLHLC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double HLPHFKAGAIE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7229D30", Offset = "0x7229130", VA = "0x187229D30", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double FCGBAALCODM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1B70CE0", Offset = "0x1B700E0", VA = "0x181B70CE0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double GAMMIMBIEHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F7B0", Offset = "0x1F8EBB0", VA = "0x181F8F7B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7229EB0", Offset = "0x72292B0", VA = "0x187229EB0")]
	public FALNLMIIOKH(int GBHAMFHGOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7229D90", Offset = "0x7229190", VA = "0x187229D90", Slot = "7")]
	public void NJDBHLACBHO(double ELOBPEFBAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7229CC0", Offset = "0x72290C0", VA = "0x187229CC0", Slot = "8")]
	public void FCLPPFCBMBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class BJKMMGAKHBO : JACDIMCFGGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private long MLMABEGDEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double CNHNKAGONAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double JDJMNEGKMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double HDNBOMOPFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double BOEJDJNABCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double DNLNJGFKFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double JDOCBGNCGMI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double FCGBAALCODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E75210", Offset = "0x5E74610", VA = "0x185E75210", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double GAMMIMBIEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E75250", Offset = "0x5E74650", VA = "0x185E75250", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double BDHOCBAIPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E75200", Offset = "0x5E74600", VA = "0x185E75200")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double HLPHFKAGAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x258E170", Offset = "0x258D570", VA = "0x18258E170", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x721BC10", Offset = "0x721B010", VA = "0x18721BC10", Slot = "7")]
	public virtual void NJDBHLACBHO(double ELOBPEFBAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x721BBD0", Offset = "0x721AFD0", VA = "0x18721BBD0", Slot = "8")]
	public virtual void FCLPPFCBMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x721BD30", Offset = "0x721B130", VA = "0x18721BD30")]
	public BJKMMGAKHBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class JNMLMIFPBFA : BJKMMGAKHBO
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double JDOELICNBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5E756D0", Offset = "0x5E74AD0", VA = "0x185E756D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E75690", Offset = "0x5E74A90", VA = "0x185E75690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x722EA70", Offset = "0x722DE70", VA = "0x18722EA70", Slot = "7")]
	public override void NJDBHLACBHO(double ELOBPEFBAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x722EA30", Offset = "0x722DE30", VA = "0x18722EA30", Slot = "8")]
	public override void FCLPPFCBMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x721BD30", Offset = "0x721B130", VA = "0x18721BD30")]
	public JNMLMIFPBFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface JACDIMCFGGB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double HLPHFKAGAIE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double FCGBAALCODM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double GAMMIMBIEHL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class NKKMBLEBNLC
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private interface PHGDLOJJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool NDAMEGLLHGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IBMHMHPCIDB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private abstract class IIOOOBECENL<TPromise, TMainThreadPromise> : PHGDLOJJJEF where TPromise : FFCFPAFMHJP where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly TPromise CLIMIEBPEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		protected readonly TMainThreadPromise KIJOIPMOIOK;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise HBGLGOLLNEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3E4E2B0", Offset = "0x3E4D6B0", VA = "0x183E4E2B0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NDAMEGLLHGF
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3E4E310", Offset = "0x3E4D710", VA = "0x183E4E310", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x85AB00", Offset = "0x859F00", VA = "0x18085AB00")]
		protected IIOOOBECENL(TPromise CLIMIEBPEFA, TMainThreadPromise PMJBJPJDOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3E4E360", Offset = "0x3E4D760", VA = "0x183E4E360", Slot = "5")]
		public void IBMHMHPCIDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void EHBLDKFOPAE(TPromise CLIMIEBPEFA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class JFIELJKLNLE<T> : IIOOOBECENL<PDKNJFNMHJF<T>, KCHEAEOBIGK<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x40316C0", Offset = "0x4030AC0", VA = "0x1840316C0")]
		public JFIELJKLNLE(PDKNJFNMHJF<T> CLIMIEBPEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x40314A0", Offset = "0x40308A0", VA = "0x1840314A0", Slot = "6")]
		protected override void EHBLDKFOPAE(PDKNJFNMHJF<T> CLIMIEBPEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3844450", Offset = "0x3843850", VA = "0x183844450")]
		[CompilerGenerated]
		private void APPCALLHODD(T LLANANCGECL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4031450", Offset = "0x4030850", VA = "0x184031450")]
		[CompilerGenerated]
		private void DLCIDKABCLE(string ODIFAFDGMDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class FENPLOPJDPH : PHGDLOJJJEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Action FADGJFNLBLP;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NDAMEGLLHGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
		public FENPLOPJDPH(Action FADGJFNLBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9EDB00", Offset = "0x9ECF00", VA = "0x1809EDB00", Slot = "5")]
		public void IBMHMHPCIDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<PHGDLOJJJEF> PGEGFLKAKMK;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA630", Offset = "0x2CE9A30", VA = "0x182CEA630")]
	public static PDKNJFNMHJF<T> MJADCOKANMF<T>(this PDKNJFNMHJF<T> CLIMIEBPEFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7233600", Offset = "0x7232A00", VA = "0x187233600")]
	public static void MJADCOKANMF(Action FADGJFNLBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA540", Offset = "0x2CE9940", VA = "0x182CEA540")]
	private static PDKNJFNMHJF<T> AACDBPPIMOF<T>(PDKNJFNMHJF<T> CLIMIEBPEFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72336A0", Offset = "0x7232AA0", VA = "0x1872336A0")]
	private static void OEPMBGILIFH(PHGDLOJJJEF OAOIJEHJNHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7233140", Offset = "0x7232540", VA = "0x187233140")]
	private static void JCIMOIHNMAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7233420", Offset = "0x7232820", VA = "0x187233420")]
	private static void JGABMFPOFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7233520", Offset = "0x7232920", VA = "0x187233520")]
	private static void JIECFHGOEBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class EDOLLFOFABM
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct AGCGIFKMONE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public TaskCompletionSource<Scene> LMANALALLFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly string DDCGFPBJMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly LoadSceneMode DKHCAEDBJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly bool PCDNONHFJAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly DALGFCOOFMD<string>.EKHHBLIDCCH PHMGOCENJCD;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x721B7C0", Offset = "0x721ABC0", VA = "0x18721B7C0")]
		public AGCGIFKMONE(TaskCompletionSource<Scene> HJBBEHMCLOD, string DDCGFPBJMKC, LoadSceneMode DKHCAEDBJAJ, bool PCDNONHFJAF, DALGFCOOFMD<string>.EKHHBLIDCCH PHMGOCENJCD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct OHMKPIBLMPH : IAsyncStateMachine
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
		public DALGFCOOFMD<string>.EKHHBLIDCCH stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private DALGFCOOFMD<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x7234F60", Offset = "0x7234360", VA = "0x187234F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7235800", Offset = "0x7234C00", VA = "0x187235800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct KPBFODAOINI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x722F530", Offset = "0x722E930", VA = "0x18722F530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x722F850", Offset = "0x722EC50", VA = "0x18722F850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct MCHBBJICEBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private AGCGIFKMONE <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x72318D0", Offset = "0x7230CD0", VA = "0x1872318D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7231C80", Offset = "0x7231080", VA = "0x187231C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class INFAEGBHBBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KCHEAEOBIGK<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public INFAEGBHBBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x722CCE0", Offset = "0x722C0E0", VA = "0x18722CCE0")]
		internal void HNHLEDKENHK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct JJHDPACHHBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public DALGFCOOFMD<string>.EKHHBLIDCCH stackTimer;

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
		private INFAEGBHBBD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private DALGFCOOFMD<string>.EKHHBLIDCCH <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private DALGFCOOFMD<string>.EKHHBLIDCCH <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x722D950", Offset = "0x722CD50", VA = "0x18722D950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x722E4F0", Offset = "0x722D8F0", VA = "0x18722E4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct KCOALEEHNAJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x722EBA0", Offset = "0x722DFA0", VA = "0x18722EBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x722F070", Offset = "0x722E470", VA = "0x18722F070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct LENIAPBGEJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public DALGFCOOFMD<string>.EKHHBLIDCCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private DALGFCOOFMD<string>.EKHHBLIDCCH <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private DALGFCOOFMD<string>.EKHHBLIDCCH <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x722F8B0", Offset = "0x722ECB0", VA = "0x18722F8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7230400", Offset = "0x722F800", VA = "0x187230400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class JBFKMJNPAOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public JBFKMJNPAOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x722CF70", Offset = "0x722C370", VA = "0x18722CF70")]
		internal bool DMBIHEODDFO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class PHMONGBBFDH : IEnumerator<PKLKPEJFEBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private PKLKPEJFEBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public DOIMBJCMDNM onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private PKLKPEJFEBK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public PHMONGBBFDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x72369E0", Offset = "0x7235DE0", VA = "0x1872369E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7236650", Offset = "0x7235A50", VA = "0x187236650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7236600", Offset = "0x7235A00", VA = "0x187236600")]
		private void HMGBLPCOLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7236990", Offset = "0x7235D90", VA = "0x187236990", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class GHENGFOIHNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public KCHEAEOBIGK<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public GHENGFOIHNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x722BD70", Offset = "0x722B170", VA = "0x18722BD70")]
		internal bool HCDAFPKFDOB(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x722BAF0", Offset = "0x722AEF0", VA = "0x18722BAF0")]
		internal void EDOGANMLKDF(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class GNIJEKGDIKB : IEnumerator<PKLKPEJFEBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private PKLKPEJFEBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public KCHEAEOBIGK<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private GHENGFOIHNH <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private PKLKPEJFEBK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public GNIJEKGDIKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x722BEB0", Offset = "0x722B2B0", VA = "0x18722BEB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x722C530", Offset = "0x722B930", VA = "0x18722C530", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly ICollection<string> OPNEBINAKOP;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static FFCFPAFMHJP KJGNGPOONME;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static AsyncOperation OFFABILHBGH;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static FFCFPAFMHJP DCKCBFOHNBO;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static string DOMFFIPLCNI;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static ThreadPriority MDEPJKBFHBN;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task BBPGPIDFPBF;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static List<SceneInstance> KPKPPODJGJI;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Queue<AGCGIFKMONE> EHFLGKMIPAM;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Task LPKAIFENBLE;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool GJEONBADBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7224C70", Offset = "0x7224070", VA = "0x187224C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool KDGMMAHJDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7226120", Offset = "0x7225520", VA = "0x187226120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool HENNNNMIMBM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7225680", Offset = "0x7224A80", VA = "0x187225680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool DJGBKIIOHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7225090", Offset = "0x7224490", VA = "0x187225090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> EJPPEMIJFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7225870", Offset = "0x7224C70", VA = "0x187225870")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72252A0", Offset = "0x72246A0", VA = "0x1872252A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7225A90", Offset = "0x7224E90", VA = "0x187225A90")]
	[HDKHJAIFDLK(BCKDJIPKKOK.EnteredEditModeNextFrame, 0)]
	private static void KDNOLPHBIGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7225720", Offset = "0x7224B20", VA = "0x187225720")]
	[AsyncStateMachine(typeof(OHMKPIBLMPH))]
	public static Task<Scene> JMFDGHAEBDE(string DDCGFPBJMKC, LoadSceneMode DKHCAEDBJAJ = LoadSceneMode.Single, bool PCDNONHFJAF = false, [Optional] DALGFCOOFMD<string>.EKHHBLIDCCH FOOAIFDKBJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7225D30", Offset = "0x7225130", VA = "0x187225D30")]
	[AsyncStateMachine(typeof(KPBFODAOINI))]
	private static Task LHLOCPNLAAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x72261C0", Offset = "0x72255C0", VA = "0x1872261C0")]
	[AsyncStateMachine(typeof(MCHBBJICEBJ))]
	private static Task OODMHPNBOBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7226290", Offset = "0x7225690", VA = "0x187226290")]
	[AsyncStateMachine(typeof(JJHDPACHHBM))]
	private static Task<Scene> PAGKJHAFJHF(string DDCGFPBJMKC, LoadSceneMode DKHCAEDBJAJ, bool PCDNONHFJAF, DALGFCOOFMD<string>.EKHHBLIDCCH PHMGOCENJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7225C20", Offset = "0x7225020", VA = "0x187225C20")]
	private static void LGAKKEEILJO(SceneInstance GHLPOEBBIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7224E90", Offset = "0x7224290", VA = "0x187224E90")]
	private static void BEOIONJOIBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7226000", Offset = "0x7225400", VA = "0x187226000")]
	[AsyncStateMachine(typeof(KCOALEEHNAJ))]
	private static Task<Scene> OBEOKHGIAAJ(string DDCGFPBJMKC, LoadSceneMode DKHCAEDBJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7225F10", Offset = "0x7225310", VA = "0x187225F10")]
	private static bool NKBGNCBMEOA(string DDCGFPBJMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7225980", Offset = "0x7224D80", VA = "0x187225980")]
	[AsyncStateMachine(typeof(LENIAPBGEJN))]
	private static Task<Scene> KCGEEJIAFDI(DALGFCOOFMD<string>.EKHHBLIDCCH PHMGOCENJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7225120", Offset = "0x7224520", VA = "0x187225120")]
	public static PDKNJFNMHJF<Scene> FLHEGBNLOAL(string DDCGFPBJMKC, LoadSceneMode DKHCAEDBJAJ = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x72253B0", Offset = "0x72247B0", VA = "0x1872253B0")]
	public static FFCFPAFMHJP IIFIKEOLJHJ(string DDCGFPBJMKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7225B90", Offset = "0x7224F90", VA = "0x187225B90")]
	[IteratorStateMachine(typeof(PHMONGBBFDH))]
	private static IEnumerator<PKLKPEJFEBK> KEDLKKDKBJH(string DDCGFPBJMKC, DOIMBJCMDNM GLDCHHIBJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x72263E0", Offset = "0x72257E0", VA = "0x1872263E0")]
	[IteratorStateMachine(typeof(GNIJEKGDIKB))]
	private static IEnumerator<PKLKPEJFEBK> PINNKOGDCBP(string DDCGFPBJMKC, LoadSceneMode DKHCAEDBJAJ, KCHEAEOBIGK<Scene> GLDCHHIBJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7225DE0", Offset = "0x72251E0", VA = "0x187225DE0")]
	public static bool NBBNDJFKPJA([Out] string GDIEJKJFKFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class KLNNADEIBHG
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x722F3A0", Offset = "0x722E7A0", VA = "0x18722F3A0")]
	public static IDisposable AJEPHPGMDCA(this OEKPGCKAHJN NMIKEFKOPMC, float FNJGNGJDJKJ, Action<float> NFBOEMAKLCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x722F4B0", Offset = "0x722E8B0", VA = "0x18722F4B0")]
	public static IDisposable PFOJIIDLIEN(this OEKPGCKAHJN NMIKEFKOPMC, Action<float> NFBOEMAKLCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x722F430", Offset = "0x722E830", VA = "0x18722F430")]
	public static IDisposable CIOOOCNEALF(this OEKPGCKAHJN NMIKEFKOPMC, Action<float> NFBOEMAKLCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class DOIGBDMBEFO
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x72249E0", Offset = "0x7223DE0", VA = "0x1872249E0")]
	public static IDisposable OJGFJOEDKEJ(this MonoBehaviour AIACGFOCMAK, Action NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7224950", Offset = "0x7223D50", VA = "0x187224950")]
	public static IDisposable OJGFJOEDKEJ(this MonoBehaviour AIACGFOCMAK, Action<float> NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7224140", Offset = "0x7223540", VA = "0x187224140")]
	public static IDisposable DKKALNJCGIH(this MonoBehaviour AIACGFOCMAK, Action NFBOEMAKLCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x72242F0", Offset = "0x72236F0", VA = "0x1872242F0")]
	public static IDisposable EGMEIPNOEJH(this MonoBehaviour AIACGFOCMAK, Action NFBOEMAKLCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7224270", Offset = "0x7223670", VA = "0x187224270")]
	public static IDisposable EGMEIPNOEJH(this MonoBehaviour AIACGFOCMAK, Action<float> NFBOEMAKLCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7223ED0", Offset = "0x72232D0", VA = "0x187223ED0")]
	public static IDisposable AIMMALFDAGC(this MonoBehaviour AIACGFOCMAK, Action NFBOEMAKLCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7224370", Offset = "0x7223770", VA = "0x187224370")]
	public static IDisposable FPPDBKGALFB(this MonoBehaviour AIACGFOCMAK, Action NFBOEMAKLCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x72246F0", Offset = "0x7223AF0", VA = "0x1872246F0")]
	public static IDisposable LDKDDDMCOMI(this MonoBehaviour AIACGFOCMAK, Action NFBOEMAKLCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7223F50", Offset = "0x7223350", VA = "0x187223F50")]
	public static IDisposable CELHAHDLFOI(this MonoBehaviour AIACGFOCMAK, float FNJGNGJDJKJ, Action<float> NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE, bool DODEBFICCCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7224490", Offset = "0x7223890", VA = "0x187224490")]
	public static IDisposable HAJEELEMFBM(this MonoBehaviour AIACGFOCMAK, float FNJGNGJDJKJ, Action<float> NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE, bool DODEBFICCCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x72248B0", Offset = "0x7223CB0", VA = "0x1872248B0")]
	public static IDisposable OEHFFMPBEAM(this MonoBehaviour AIACGFOCMAK, float FNJGNGJDJKJ, Action<float> NFBOEMAKLCN, bool DODEBFICCCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7224000", Offset = "0x7223400", VA = "0x187224000")]
	public static IDisposable DCBPCLAAIPE(this MonoBehaviour AIACGFOCMAK, Action<float> NFBOEMAKLCN, bool DODEBFICCCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7224650", Offset = "0x7223A50", VA = "0x187224650")]
	public static IDisposable KGABGFNDEIN(this MonoBehaviour AIACGFOCMAK, Action<float> NFBOEMAKLCN, bool DODEBFICCCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x72245B0", Offset = "0x72239B0", VA = "0x1872245B0")]
	public static IDisposable HFAFFDANMDO(this MonoBehaviour AIACGFOCMAK, Action<float> NFBOEMAKLCN, bool DODEBFICCCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x72243F0", Offset = "0x72237F0", VA = "0x1872243F0")]
	public static IDisposable GGAEHPFHFCG(this MonoBehaviour AIACGFOCMAK, Action<float> NFBOEMAKLCN, bool DODEBFICCCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7224770", Offset = "0x7223B70", VA = "0x187224770")]
	public static IDisposable LIHAGJFOLHN(this MonoBehaviour AIACGFOCMAK, Action<float> NFBOEMAKLCN, bool DODEBFICCCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7224810", Offset = "0x7223C10", VA = "0x187224810")]
	public static IDisposable LLPEAKOMMNB(this MonoBehaviour AIACGFOCMAK, Action<float> NFBOEMAKLCN, bool DODEBFICCCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x72240A0", Offset = "0x72234A0", VA = "0x1872240A0")]
	public static IDisposable DDDONEFANAN(this MonoBehaviour AIACGFOCMAK, Action<float> NFBOEMAKLCN, bool DODEBFICCCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x72241C0", Offset = "0x72235C0", VA = "0x1872241C0")]
	public static IDisposable EDFLCFMEACC(this MonoBehaviour AIACGFOCMAK, float FNJGNGJDJKJ, Action<float> NFBOEMAKLCN, bool DODEBFICCCL = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class ICGGDFNAHAM
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class DDNFCIJPOAF : IEnumerator<PKLKPEJFEBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private PKLKPEJFEBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public FLBNJJOGANK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private IOIHLEDDIGI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private PKLKPEJFEBK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public DDNFCIJPOAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7222F30", Offset = "0x7222330", VA = "0x187222F30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7223010", Offset = "0x7222410", VA = "0x187223010", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class PMFBFMFFMOE : IEnumerator<PKLKPEJFEBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private PKLKPEJFEBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public FLBNJJOGANK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private IOIHLEDDIGI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private PKLKPEJFEBK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public PMFBFMFFMOE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7236A70", Offset = "0x7235E70", VA = "0x187236A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7236B60", Offset = "0x7235F60", VA = "0x187236B60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x722CA50", Offset = "0x722BE50", VA = "0x18722CA50")]
	public static DAODDLKDJDG OJGFJOEDKEJ(Action NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x722CB00", Offset = "0x722BF00", VA = "0x18722CB00")]
	public static DAODDLKDJDG OJGFJOEDKEJ(Behaviour NMIKEFKOPMC, Action NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x722CBC0", Offset = "0x722BFC0", VA = "0x18722CBC0")]
	public static DAODDLKDJDG OJGFJOEDKEJ(Behaviour NMIKEFKOPMC, Action<float> NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x722C9C0", Offset = "0x722BDC0", VA = "0x18722C9C0")]
	[IteratorStateMachine(typeof(DDNFCIJPOAF))]
	private static IEnumerator<PKLKPEJFEBK> KHOEDNBBLKB(FLBNJJOGANK KNKEEMDNDKM, Action NFBOEMAKLCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x722C930", Offset = "0x722BD30", VA = "0x18722C930")]
	[IteratorStateMachine(typeof(PMFBFMFFMOE))]
	private static IEnumerator<PKLKPEJFEBK> KHOEDNBBLKB(FLBNJJOGANK KNKEEMDNDKM, Action<float> NFBOEMAKLCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class JALIIPBEKJE : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class NNLBHFCABCL : IEnumerator<PKLKPEJFEBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private PKLKPEJFEBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public JALIIPBEKJE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private PKLKPEJFEBK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public NNLBHFCABCL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7234180", Offset = "0x7233580", VA = "0x187234180", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7234210", Offset = "0x7233610", VA = "0x187234210", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly FLBNJJOGANK ONEBPNNLLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Action ANHIBEADIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool GHAPEIBPOGP;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool LJPAGGCGBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x854200", Offset = "0x853600", VA = "0x180854200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x722CE60", Offset = "0x722C260", VA = "0x18722CE60")]
	public JALIIPBEKJE(FLBNJJOGANK ONEBPNNLLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x722CD40", Offset = "0x722C140", VA = "0x18722CD40")]
	[IteratorStateMachine(typeof(NNLBHFCABCL))]
	private IEnumerator<PKLKPEJFEBK> CEFFDAKFCMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x722CDC0", Offset = "0x722C1C0", VA = "0x18722CDC0", Slot = "4")]
	public void OnCompleted(Action PCGPMGPOCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	public void ADIKPILFDPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class BGDNODKINJN
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x721BA90", Offset = "0x721AE90", VA = "0x18721BA90")]
	public static JALIIPBEKJE JLFFMNMNBFI(this FLBNJJOGANK ONEBPNNLLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class MIEOODBADMD
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class ANLOBOIFIEK : IEnumerator<PKLKPEJFEBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private PKLKPEJFEBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CFAHLNNMOCD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private PKLKPEJFEBK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public ANLOBOIFIEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x721B9C0", Offset = "0x721ADC0", VA = "0x18721B9C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x721BA40", Offset = "0x721AE40", VA = "0x18721BA40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7232820", Offset = "0x7231C20", VA = "0x187232820")]
	public static DAODDLKDJDG OJGFJOEDKEJ(float FNJGNGJDJKJ, Action<float> NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE, bool DODEBFICCCL = true, [Optional] FFCDFGJFKJB LCHMOHEHFPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7232920", Offset = "0x7231D20", VA = "0x187232920")]
	public static DAODDLKDJDG OJGFJOEDKEJ(MonoBehaviour AIACGFOCMAK, float FNJGNGJDJKJ, Action<float> NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE, bool DODEBFICCCL = true, [Optional] FFCDFGJFKJB LCHMOHEHFPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7232440", Offset = "0x7231840", VA = "0x187232440")]
	public static DAODDLKDJDG CLAFIPGMMMN(MonoBehaviour AIACGFOCMAK, float FNJGNGJDJKJ, Action<float> NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE, bool DODEBFICCCL = true, [Optional] FFCDFGJFKJB LCHMOHEHFPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7232710", Offset = "0x7231B10", VA = "0x187232710")]
	public static DAODDLKDJDG LEPIMNBDMMI(OEKPGCKAHJN NMIKEFKOPMC, float FNJGNGJDJKJ, Action<float> NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE, bool DODEBFICCCL = true, [Optional] FFCDFGJFKJB LCHMOHEHFPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x72325F0", Offset = "0x72319F0", VA = "0x1872325F0")]
	private static IEnumerator<PKLKPEJFEBK> KHOEDNBBLKB(KGHBNCMFNJA KEGLHDAMBIE, float FNJGNGJDJKJ, FLBNJJOGANK KNKEEMDNDKM, Action<float> NFBOEMAKLCN, bool DODEBFICCCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x72326B0", Offset = "0x7231AB0", VA = "0x1872326B0")]
	private static IEnumerator<PKLKPEJFEBK> KKDJJBNHPAB(KGHBNCMFNJA KEGLHDAMBIE, float FNJGNGJDJKJ, FLBNJJOGANK KNKEEMDNDKM, Action<float> NFBOEMAKLCN, bool DODEBFICCCL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7232560", Offset = "0x7231960", VA = "0x187232560")]
	[IteratorStateMachine(typeof(ANLOBOIFIEK))]
	private static IEnumerator<PKLKPEJFEBK> HDGLPGABPEG(CFAHLNNMOCD GELMNABIACH, float FNJGNGJDJKJ, FLBNJJOGANK KNKEEMDNDKM, Action<float> NFBOEMAKLCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class CMAJJHIIKJN
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class OGCLOEEDDMC : IEnumerator<PKLKPEJFEBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private PKLKPEJFEBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public FLBNJJOGANK queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private PKLKPEJFEBK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public OGCLOEEDDMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7234E50", Offset = "0x7234250", VA = "0x187234E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7234F10", Offset = "0x7234310", VA = "0x187234F10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x721D430", Offset = "0x721C830", VA = "0x18721D430")]
	[IteratorStateMachine(typeof(OGCLOEEDDMC))]
	private static IEnumerator<PKLKPEJFEBK> OEAJIOLALAE(FLBNJJOGANK ONEBPNNLLPE, Func<bool> GGBDOLNKFKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x721D310", Offset = "0x721C710", VA = "0x18721D310")]
	public static DAODDLKDJDG NHCCMFBJGPI(this MonoBehaviour AIACGFOCMAK, Func<bool> GGBDOLNKFKN, FLBNJJOGANK ONEBPNNLLPE = FLBNJJOGANK.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class ODIFEJNJLAO
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class KFFHFPFHFBC : IEnumerator<PKLKPEJFEBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private PKLKPEJFEBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public FLBNJJOGANK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private PKLKPEJFEBK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public KFFHFPFHFBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x722F0E0", Offset = "0x722E4E0", VA = "0x18722F0E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x722F150", Offset = "0x722E550", VA = "0x18722F150", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class AJGLIGCDHLB : IEnumerator<PKLKPEJFEBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private PKLKPEJFEBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public FLBNJJOGANK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private PKLKPEJFEBK <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private PKLKPEJFEBK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public AJGLIGCDHLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x721B8E0", Offset = "0x721ACE0", VA = "0x18721B8E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x721B970", Offset = "0x721AD70", VA = "0x18721B970", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7234840", Offset = "0x7233C40", VA = "0x187234840")]
	[IteratorStateMachine(typeof(KFFHFPFHFBC))]
	private static IEnumerator<PKLKPEJFEBK> CEFFDAKFCMK(float NEHLEIDGFCE, FLBNJJOGANK KNKEEMDNDKM, Action IAJCFKFGJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7234A90", Offset = "0x7233E90", VA = "0x187234A90")]
	[IteratorStateMachine(typeof(AJGLIGCDHLB))]
	private static IEnumerator<PKLKPEJFEBK> ECFJPECBAMH(float NEHLEIDGFCE, FLBNJJOGANK KNKEEMDNDKM, Action IAJCFKFGJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7234650", Offset = "0x7233A50", VA = "0x187234650")]
	public static IDisposable AGBFOJBEJKB(this MonoBehaviour AIACGFOCMAK, float NEHLEIDGFCE, Action IAJCFKFGJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7234460", Offset = "0x7233860", VA = "0x187234460")]
	public static DAODDLKDJDG ADNNEJHNEKP(this MonoBehaviour AIACGFOCMAK, float NEHLEIDGFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7234520", Offset = "0x7233920", VA = "0x187234520")]
	public static DAODDLKDJDG AGBFOJBEJKB(this MonoBehaviour AIACGFOCMAK, float NEHLEIDGFCE, FLBNJJOGANK KNKEEMDNDKM, Action IAJCFKFGJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7234C60", Offset = "0x7234060", VA = "0x187234C60")]
	public static DAODDLKDJDG IGKJJIEMJDA(this MonoBehaviour AIACGFOCMAK, Action IAJCFKFGJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7234C30", Offset = "0x7234030", VA = "0x187234C30")]
	public static DAODDLKDJDG GMCEEBPNEJD(this MonoBehaviour AIACGFOCMAK, Action IAJCFKFGJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x72348E0", Offset = "0x7233CE0", VA = "0x1872348E0")]
	public static DAODDLKDJDG DFHHBHMBFJK(this MonoBehaviour AIACGFOCMAK, Action IAJCFKFGJIF, [Optional] FFCDFGJFKJB LCHMOHEHFPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7234C00", Offset = "0x7234000", VA = "0x187234C00")]
	public static DAODDLKDJDG EOPJNMAIGAJ(this MonoBehaviour AIACGFOCMAK, Action IAJCFKFGJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7234C80", Offset = "0x7234080", VA = "0x187234C80")]
	public static DAODDLKDJDG JODADPJPBNC(this MonoBehaviour AIACGFOCMAK, Action IAJCFKFGJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7234B30", Offset = "0x7233F30", VA = "0x187234B30")]
	private static DAODDLKDJDG EDINHOPOKBL(MonoBehaviour AIACGFOCMAK, FLBNJJOGANK ONEBPNNLLPE, Action IAJCFKFGJIF, [Optional] FFCDFGJFKJB LCHMOHEHFPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7234CB0", Offset = "0x72340B0", VA = "0x187234CB0")]
	public static DAODDLKDJDG NMCHJCDCIIM(this MonoBehaviour AIACGFOCMAK, float KAOFHPOCDDK, Action IAJCFKFGJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7234770", Offset = "0x7233B70", VA = "0x187234770")]
	public static DAODDLKDJDG BHMHJAHDALJ(this MonoBehaviour AIACGFOCMAK, float KAOFHPOCDDK, Action IAJCFKFGJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x72349C0", Offset = "0x7233DC0", VA = "0x1872349C0")]
	public static DAODDLKDJDG EBIPDOODJOK(this MonoBehaviour AIACGFOCMAK, float KAOFHPOCDDK, Action IAJCFKFGJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7234D80", Offset = "0x7234180", VA = "0x187234D80")]
	public static DAODDLKDJDG ONGKPFEFIOI(this MonoBehaviour AIACGFOCMAK, float KAOFHPOCDDK, Action IAJCFKFGJIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class EKBPBKEFOFB : CJACFEOJGIC, IEnumerable<CJACFEOJGIC>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly List<CJACFEOJGIC> NDICHNGMPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool ILDDKHEFHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Action GDFJLCMMLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool GJIGJNHIBOD;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CHGDMGADLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7226E80", Offset = "0x7226280", VA = "0x187226E80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JFKKKOLIBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7226FC0", Offset = "0x72263C0", VA = "0x187226FC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7226960", Offset = "0x7225D60", VA = "0x187226960", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7227060", Offset = "0x7226460", VA = "0x187227060")]
	public EKBPBKEFOFB([Optional] Action GDFJLCMMLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7226830", Offset = "0x7225C30", VA = "0x187226830")]
	public void HINMMBAADBG(CJACFEOJGIC PCJKJPOPLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7226A00", Offset = "0x7225E00", VA = "0x187226A00")]
	private void JDKPMPECAPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7226B60", Offset = "0x7225F60", VA = "0x187226B60", Slot = "7")]
	public bool JPFNNAGJCDD(bool MCCPONPGBFK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7226B70", Offset = "0x7225F70", VA = "0x187226B70", Slot = "8")]
	public bool JPFNNAGJCDD(Action FADGJFNLBLP, bool MCCPONPGBFK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x72267B0", Offset = "0x7225BB0", VA = "0x1872267B0", Slot = "9")]
	public IEnumerator<CJACFEOJGIC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x72267B0", Offset = "0x7225BB0", VA = "0x1872267B0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class FFHIKFFEIMP : DNFJGEJHIGK
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class MLCNGPNIACO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public FFHIKFFEIMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public MLCNGPNIACO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x72318A0", Offset = "0x7230CA0", VA = "0x1872318A0")]
		internal void CEIGOCLEBKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class MAFJBJALGHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public FFHIKFFEIMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public MAFJBJALGHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x72318A0", Offset = "0x7230CA0", VA = "0x1872318A0")]
		internal void CJFOEPCDCIM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly float BEEHOBAFEAH;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x72266B0", Offset = "0x7225AB0", VA = "0x1872266B0")]
	public FFHIKFFEIMP(Behaviour NMIKEFKOPMC, float BEEHOBAFEAH, [Optional] Action GDFJLCMMLMB, [Optional] FFCDFGJFKJB LCHMOHEHFPM, [Optional] KGHBNCMFNJA KEGLHDAMBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x722B360", Offset = "0x722A760", VA = "0x18722B360", Slot = "9")]
	protected override bool EPEDLBHHADL(Action FADGJFNLBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x722B470", Offset = "0x722A870", VA = "0x18722B470", Slot = "10")]
	protected override bool NHFGGFHILCO(Action FADGJFNLBLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface CJACFEOJGIC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool CHGDMGADLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action JFKKKOLIBHG;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JPFNNAGJCDD(bool MCCPONPGBFK = false);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JPFNNAGJCDD(Action FADGJFNLBLP, bool MCCPONPGBFK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public abstract class DNFJGEJHIGK : CJACFEOJGIC
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class BOFHEKGICKP : IEnumerator<PKLKPEJFEBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private PKLKPEJFEBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public DNFJGEJHIGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private PKLKPEJFEBK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public BOFHEKGICKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x721BD60", Offset = "0x721B160", VA = "0x18721BD60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x721BE30", Offset = "0x721B230", VA = "0x18721BE30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Behaviour NMIKEFKOPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action GDFJLCMMLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private FCIMHBPMHFO CLKPELENCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly FFCDFGJFKJB LCHMOHEHFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	protected readonly KGHBNCMFNJA KEGLHDAMBIE;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool CHGDMGADLCD
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xF7D930", Offset = "0xF7CD30", VA = "0x180F7D930", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action JFKKKOLIBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7223C60", Offset = "0x7223060", VA = "0x187223C60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7223840", Offset = "0x7222C40", VA = "0x187223840", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7223DD0", Offset = "0x72231D0", VA = "0x187223DD0")]
	protected DNFJGEJHIGK(Behaviour NMIKEFKOPMC, [Optional] Action GDFJLCMMLMB, [Optional] FFCDFGJFKJB LCHMOHEHFPM, [Optional] KGHBNCMFNJA KEGLHDAMBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x72238E0", Offset = "0x7222CE0", VA = "0x1872238E0", Slot = "7")]
	public bool JPFNNAGJCDD(bool MCCPONPGBFK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7223940", Offset = "0x7222D40", VA = "0x187223940", Slot = "8")]
	public bool JPFNNAGJCDD(Action FADGJFNLBLP, bool MCCPONPGBFK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool EPEDLBHHADL(Action FADGJFNLBLP);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool NHFGGFHILCO(Action FADGJFNLBLP);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7223820", Offset = "0x7222C20", VA = "0x187223820")]
	protected void AFEHKKBHKHL(Action FADGJFNLBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7223A20", Offset = "0x7222E20", VA = "0x187223A20")]
	protected FFCFPAFMHJP OCNLKCCMFNH(float PJOOABCONNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x72239A0", Offset = "0x7222DA0", VA = "0x1872239A0")]
	private void MJMFOIOEJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7223D00", Offset = "0x7223100", VA = "0x187223D00")]
	[IteratorStateMachine(typeof(BOFHEKGICKP))]
	private IEnumerator<PKLKPEJFEBK> PBAJEOLIGJA(float PJOOABCONNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7223D90", Offset = "0x7223190", VA = "0x187223D90")]
	[CompilerGenerated]
	private void PDJLFALDOBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class NLCLLJBFBEO : DNFJGEJHIGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float OFKPCFFMIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly int ACIAEGDHEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float OICFBDIHAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float[] JOPOBFPBMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private int CNEGDJNDLCN;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7233EB0", Offset = "0x72332B0", VA = "0x187233EB0")]
	public NLCLLJBFBEO(Behaviour NMIKEFKOPMC, float FCIPNHOPFOM, int ACIAEGDHEJD, [Optional] Action GDFJLCMMLMB, float OICFBDIHAII = 0f, [Optional] FFCDFGJFKJB LCHMOHEHFPM, [Optional] KGHBNCMFNJA KEGLHDAMBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "9")]
	protected override bool EPEDLBHHADL(Action FADGJFNLBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7233CB0", Offset = "0x72330B0", VA = "0x187233CB0", Slot = "10")]
	protected override bool NHFGGFHILCO(Action FADGJFNLBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7233C30", Offset = "0x7233030", VA = "0x187233C30")]
	private void AFNAKJBNBEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class EFBDILJODHJ : DNFJGEJHIGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly float BEEHOBAFEAH;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x72266B0", Offset = "0x7225AB0", VA = "0x1872266B0")]
	public EFBDILJODHJ(Behaviour NMIKEFKOPMC, float BEEHOBAFEAH, [Optional] Action GDFJLCMMLMB, [Optional] FFCDFGJFKJB LCHMOHEHFPM, [Optional] KGHBNCMFNJA KEGLHDAMBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "9")]
	protected override bool EPEDLBHHADL(Action FADGJFNLBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7226670", Offset = "0x7225A70", VA = "0x187226670", Slot = "10")]
	protected override bool NHFGGFHILCO(Action FADGJFNLBLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public sealed class PFOJKOBGDIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class AHAACDPLEPK : IEnumerator<PKLKPEJFEBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private PKLKPEJFEBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private PKLKPEJFEBK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public AHAACDPLEPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x721B820", Offset = "0x721AC20", VA = "0x18721B820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x721B890", Offset = "0x721AC90", VA = "0x18721B890", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private DAODDLKDJDG BKDMIHICILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private OEKPGCKAHJN NMIKEFKOPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Action<float> LMLKFEMELBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private FLBNJJOGANK ONEBPNNLLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private float DLJLJMGNPBG;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7236420", Offset = "0x7235820", VA = "0x187236420")]
	public PFOJKOBGDIB(OEKPGCKAHJN NMIKEFKOPMC, float FNJGNGJDJKJ, Action<float> NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x72360A0", Offset = "0x72354A0", VA = "0x1872360A0")]
	private void FNFGDBPIIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7236240", Offset = "0x7235640", VA = "0x187236240")]
	private void LGCAHPIGFJL(string ODIFAFDGMDE, Action JEAABBHJOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x72363A0", Offset = "0x72357A0", VA = "0x1872363A0")]
	[IteratorStateMachine(typeof(AHAACDPLEPK))]
	private IEnumerator<PKLKPEJFEBK> MHMCOHLCOII(Action JEAABBHJOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7236040", Offset = "0x7235440", VA = "0x187236040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7235E90", Offset = "0x7235290", VA = "0x187235E90")]
	[CompilerGenerated]
	private void BGHNCNHFAHI(string AGGBGAFAKGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class BPIFHJLHLCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class HBLLMFHHFID : IEnumerator<PKLKPEJFEBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private PKLKPEJFEBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private PKLKPEJFEBK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public HBLLMFHHFID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x721B820", Offset = "0x721AC20", VA = "0x18721B820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x722C580", Offset = "0x722B980", VA = "0x18722C580", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private DAODDLKDJDG BKDMIHICILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private MonoBehaviour AIACGFOCMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Action NFBOEMAKLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action<float> LMLKFEMELBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private FLBNJJOGANK ONEBPNNLLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private float DLJLJMGNPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool DODEBFICCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly FFCDFGJFKJB LCHMOHEHFPM;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x721CCD0", Offset = "0x721C0D0", VA = "0x18721CCD0")]
	public BPIFHJLHLCB(MonoBehaviour AIACGFOCMAK, Action NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE, [Optional] FFCDFGJFKJB LCHMOHEHFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x721CA90", Offset = "0x721BE90", VA = "0x18721CA90")]
	public BPIFHJLHLCB(MonoBehaviour AIACGFOCMAK, Action<float> NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE, [Optional] FFCDFGJFKJB LCHMOHEHFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x721CEC0", Offset = "0x721C2C0", VA = "0x18721CEC0")]
	public BPIFHJLHLCB(MonoBehaviour AIACGFOCMAK, float FNJGNGJDJKJ, Action<float> NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE, bool DODEBFICCCL = true, [Optional] FFCDFGJFKJB LCHMOHEHFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1B10", Offset = "0x3DC0F10", VA = "0x183DC1B10")]
	private BPIFHJLHLCB(FFCDFGJFKJB LCHMOHEHFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x721C490", Offset = "0x721B890", VA = "0x18721C490")]
	internal static BPIFHJLHLCB KFOIDLFIBDF(MonoBehaviour AIACGFOCMAK, float FNJGNGJDJKJ, Action<float> NFBOEMAKLCN, FLBNJJOGANK ONEBPNNLLPE, bool DODEBFICCCL = true, [Optional] FFCDFGJFKJB LCHMOHEHFPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x721C920", Offset = "0x721BD20", VA = "0x18721C920")]
	private void OJGFJOEDKEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x721C2E0", Offset = "0x721B6E0", VA = "0x18721C2E0")]
	private void IFGKNCINBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x721BF70", Offset = "0x721B370", VA = "0x18721BF70")]
	private void FNFGDBPIIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x721C120", Offset = "0x721B520", VA = "0x18721C120")]
	private void HFCGDKAGPOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x721C5C0", Offset = "0x721B9C0", VA = "0x18721C5C0")]
	private void LGCAHPIGFJL(string ODIFAFDGMDE, Action JEAABBHJOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x721C6F0", Offset = "0x721BAF0", VA = "0x18721C6F0")]
	[IteratorStateMachine(typeof(HBLLMFHHFID))]
	private IEnumerator<PKLKPEJFEBK> MHMCOHLCOII(Action JEAABBHJOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x721BF10", Offset = "0x721B310", VA = "0x18721BF10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x721BE80", Offset = "0x721B280", VA = "0x18721BE80")]
	[CompilerGenerated]
	private void CHIAGDOCKPB(string AGGBGAFAKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x721C890", Offset = "0x721BC90", VA = "0x18721C890")]
	[CompilerGenerated]
	private void OEBBBMPDFJM(string AGGBGAFAKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x721C800", Offset = "0x721BC00", VA = "0x18721C800")]
	[CompilerGenerated]
	private void ODDCMEALDKG(string AGGBGAFAKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x721C770", Offset = "0x721BB70", VA = "0x18721C770")]
	[CompilerGenerated]
	private void MKGKEEIKOJE(string AGGBGAFAKGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[Flags]
internal enum IDKKKKIDGAI : byte
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
internal sealed class FLDHKJALMJC : KGHBNCMFNJA
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float MBOMMDAEBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x722B870", Offset = "0x722AC70", VA = "0x18722B870", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float OJFDMMNMNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x722B7F0", Offset = "0x722ABF0", VA = "0x18722B7F0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double EOMIFMDAGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x722B7D0", Offset = "0x722ABD0", VA = "0x18722B7D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x722B800", Offset = "0x722AC00", VA = "0x18722B800")]
	[EAMANMFIEOM(NBICBCAKHEI.None)]
	private static void KHJKHFBAEKH(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	[Preserve]
	internal FLDHKJALMJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface PIJGOCCKJDF
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDAFHOIMDCC(string FIKHOKLHCII);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KJEBFDFELFE();
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface FIJFOLEMGFO
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string KHPOGHNODCD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool MGBFPLDKMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool NNPBFLGPGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal class JMMMFDPCCFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public EOGEOBACKMD HIFHOCCMFBG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int KCOEJCJFNCN
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x84B1A0", Offset = "0x84A5A0", VA = "0x18084B1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x84D870", Offset = "0x84CC70", VA = "0x18084D870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x722E810", Offset = "0x722DC10", VA = "0x18722E810")]
	public static PKLKPEJFEBK LLKGGKKHHFI(IEnumerator<PKLKPEJFEBK> ACNIIDMJAAD, GMFOBHMAHOA AJCDJPGFGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x722E970", Offset = "0x722DD70", VA = "0x18722E970")]
	public PKLKPEJFEBK LLKGGKKHHFI(GMFOBHMAHOA[] GHOJMAOIIFJ, IEnumerator<PKLKPEJFEBK>[] ENMNHEDEPBH, PKLKPEJFEBK[] OAKKFAKMNKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x722E7E0", Offset = "0x722DBE0", VA = "0x18722E7E0")]
	public void NDEAKJPDBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x722E560", Offset = "0x722D960", VA = "0x18722E560")]
	public void BNOEHPOMJNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x722E6A0", Offset = "0x722DAA0", VA = "0x18722E6A0")]
	public void KHFKPELPHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x722E7E0", Offset = "0x722DBE0", VA = "0x18722E7E0")]
	public void LCBEKHBDNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public JMMMFDPCCFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class EOGEOBACKMD
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct JAKEDAOPDHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public JMMMFDPCCFH NOLIKANBBJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public OEKPGCKAHJN GEMONIMDLCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public GMFOBHMAHOA FNJNHPEPBEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public IEnumerator<PKLKPEJFEBK> PBGMPGCLNNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public PKLKPEJFEBK PCFLOONJAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public IDKKKKIDGAI KCMJAKALCLP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct EIJNLPEOMHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public FLBNJJOGANK EEFLOJHPCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public List<JAKEDAOPDHK> AFDKIDMLGDM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class FEMAODHOPLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public GMFOBHMAHOA promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public EOGEOBACKMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public OEKPGCKAHJN context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public JMMMFDPCCFH routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public IDKKKKIDGAI coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public PKLKPEJFEBK currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public IEnumerator<PKLKPEJFEBK> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public FEMAODHOPLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x722ABB0", Offset = "0x7229FB0", VA = "0x18722ABB0")]
		internal void ICFAFADFGLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class HGILGMBFBAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public JMMMFDPCCFH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public EOGEOBACKMD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public HGILGMBFBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x722C7D0", Offset = "0x722BBD0", VA = "0x18722C7D0")]
		internal void MAPCPCOGCAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class GKOEKIDMCOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public JMMMFDPCCFH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public EOGEOBACKMD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public GKOEKIDMCOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x722BDF0", Offset = "0x722B1F0", VA = "0x18722BDF0")]
		internal void FCEOFLOFHOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class DJOJFHLKFAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public JMMMFDPCCFH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public EOGEOBACKMD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public DJOJFHLKFAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7223060", Offset = "0x7222460", VA = "0x187223060")]
		internal void GBAMGDMIHDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const IDKKKKIDGAI PHDFIINBEJK = IDKKKKIDGAI.Cancelled | IDKKKKIDGAI.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly FLBNJJOGANK ONEBPNNLLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool[] NHFJMNPBOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<IDKKKKIDGAI> BMCDAOLBCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<float> GBPMFJEANIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> CNCMJHDIKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> KBCNCLKFGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> HFOBHBKEBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> PEODHBNGMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> FNFEMADEJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private JMMMFDPCCFH[] IOIIJBGPGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private GMFOBHMAHOA[] GHOJMAOIIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private OEKPGCKAHJN[] GIBFFCGBLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IEnumerator<PKLKPEJFEBK>[] KDPOKOJLECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private PKLKPEJFEBK[] DGLBJCPCDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int KIPOGOAGCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int HKIABBKKICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly int GELNCKGOOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float LEBCHMGMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private MFFHEBJGLJG CGKOMLJCEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private JobHandle HHNBMOHKDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<JMMMFDPCCFH> KOLAHLGNALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool IIAFNGKJOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private List<Action> IGECMCDACNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> HDDOKGMADCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private bool KIIADHIFHLC;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public EIJNLPEOMHF[] PFMGAIBPLEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9960C0", Offset = "0x9954C0", VA = "0x1809960C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7227A20", Offset = "0x7226E20", VA = "0x187227A20")]
	private static int HGGDBICEIGP(FLBNJJOGANK ONEBPNNLLPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7229470", Offset = "0x7228870", VA = "0x187229470")]
	public EOGEOBACKMD(FLBNJJOGANK ONEBPNNLLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7228B80", Offset = "0x7227F80", VA = "0x187228B80")]
	private void MMHJOEEDHBG(int ONGBEOJFCNO, int MNHIAKOFNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7227100", Offset = "0x7226500", VA = "0x187227100")]
	public void AFDMOHFDAPJ(OEKPGCKAHJN NMIKEFKOPMC, PKLKPEJFEBK NAJLANFJOPE, IEnumerator<PKLKPEJFEBK> ACNIIDMJAAD, GMFOBHMAHOA AJCDJPGFGAI, [Optional] JMMMFDPCCFH KGPJMCLEBFK, IDKKKKIDGAI DAHLPIJJEJA = IDKKKKIDGAI.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7229230", Offset = "0x7228630", VA = "0x187229230")]
	public void OLLDMKOPFNJ(IEnumerable<JAKEDAOPDHK> KFFIKKKGADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7228D60", Offset = "0x7228160", VA = "0x187228D60")]
	private JAKEDAOPDHK MOIBBLIMGLI(int IMMMFMOJNFL)
	{
		return default(JAKEDAOPDHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7228810", Offset = "0x7227C10", VA = "0x187228810")]
	private void MANFBMDPEMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x29EF940", Offset = "0x29EED40", VA = "0x1829EF940")]
	private static void GBBGGMGEDDP<T>(int IMMMFMOJNFL, T[] IKPIGCGADDN, int CGDIEJGGJMK, [Optional] T OHGEFBIPEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x29EF990", Offset = "0x29EED90", VA = "0x1829EF990")]
	private static void GBBGGMGEDDP<T>(int IMMMFMOJNFL, NativeArray<T> IKPIGCGADDN, int CGDIEJGGJMK, [Optional] T OHGEFBIPEDF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7227570", Offset = "0x7226970", VA = "0x187227570")]
	private void EMGHGGMBLAK(IEnumerable<JAKEDAOPDHK> KFFIKKKGADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x72274B0", Offset = "0x72268B0", VA = "0x1872274B0")]
	private void ECBONLNMCDK(JAKEDAOPDHK EMPDBLCKNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x72285B0", Offset = "0x72279B0", VA = "0x1872285B0")]
	private IIMKGEKNDGB LEHNKNLDIDA(int PIMJAGEKBKL)
	{
		return default(IIMKGEKNDGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7228280", Offset = "0x7227680", VA = "0x187228280")]
	public void KCIKMKMLCHC(float AAMNMBGKMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7227280", Offset = "0x7226680", VA = "0x187227280")]
	private void AIGHJJFOBON(Action DKLJHPKNDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7227430", Offset = "0x7226830", VA = "0x187227430")]
	private void CCICJDDPJEB(Action DKLJHPKNDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7227B80", Offset = "0x7226F80", VA = "0x187227B80")]
	public void IOFCIDICAKP(float AAMNMBGKMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7227920", Offset = "0x7226D20", VA = "0x187227920")]
	public void HGGBIMJODNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7228480", Offset = "0x7227880", VA = "0x187228480")]
	public void LCBEKHBDNDK(JMMMFDPCCFH GELMNABIACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7227300", Offset = "0x7226700", VA = "0x187227300")]
	public void BFLJMJNPNFH(JMMMFDPCCFH GELMNABIACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7227A50", Offset = "0x7226E50", VA = "0x187227A50")]
	public void ICOHIFEOHNB(JMMMFDPCCFH GELMNABIACH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JCJNLLBLJGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static readonly JCJNLLBLJGJ ADMHPKLFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Action EKIBOKOLFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool OFBHCPGMGBM;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	public JCJNLLBLJGJ(Action EKIBOKOLFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x69CBEE0", Offset = "0x69CB2E0", VA = "0x1869CBEE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface NKKAIJFMPMC<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T KHLHBLNGCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable MDIIBDDIMKJ(UnityEngine.Object NMIKEFKOPMC, Action<T> NDHIDENOANF);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface EINHDBPBOMD<T> : NKKAIJFMPMC<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T KHLHBLNGCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class EMIDMLLHALK<T> : EINHDBPBOMD<T>, NKKAIJFMPMC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class BODGBKMMHLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public EMIDMLLHALK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public GPPONICEEPM<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public BODGBKMMHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4EAAC80", Offset = "0x4EAA080", VA = "0x184EAAC80")]
		internal void BCBIKDMBAGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static GameObject PDKIIOJKGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly List<GPPONICEEPM<UnityEngine.Object, Action<T>>> IKAMMJHDJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private T NDBCCNEHODP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T KHLHBLNGCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x95D500", Offset = "0x95C900", VA = "0x18095D500", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3836580", Offset = "0x3835980", VA = "0x183836580", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3835AD0", Offset = "0x3834ED0", VA = "0x183835AD0")]
	private static bool CEIJOKFIBNN(T DKLJHPKNDLA, T EALBLGNMNKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x38366D0", Offset = "0x3835AD0", VA = "0x1838366D0")]
	public EMIDMLLHALK(T BCPAILBNDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3836220", Offset = "0x3835620", VA = "0x183836220", Slot = "6")]
	public IDisposable MDIIBDDIMKJ(UnityEngine.Object NMIKEFKOPMC, Action<T> NDHIDENOANF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3835BC0", Offset = "0x3834FC0", VA = "0x183835BC0")]
	private void HGMBBMCICIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class NCMLFKMEGIE : KKICBFNKIPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly FFCDFGJFKJB LCHMOHEHFPM;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7232C70", Offset = "0x7232070", VA = "0x187232C70")]
	[EAMANMFIEOM(NBICBCAKHEI.None)]
	private static void KHJKHFBAEKH(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	[Preserve]
	internal NCMLFKMEGIE([NCPIDBJOPHL(null)] FFCDFGJFKJB LCHMOHEHFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7232CE0", Offset = "0x72320E0", VA = "0x187232CE0", Slot = "4")]
	public IDisposable OEHFFMPBEAM(float FNJGNGJDJKJ, Action<float> PKJIBFLDCKK, bool DODEBFICCCL = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class FCEPEODFEND : LFHMKIPFDKB, FFCDFGJFKJB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private EOGEOBACKMD[] FLPDLIFPHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private PIJGOCCKJDF ALBLPHLEBPP;

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x722A850", Offset = "0x7229C50", VA = "0x18722A850")]
	[EAMANMFIEOM(NBICBCAKHEI.None)]
	private static void KHJKHFBAEKH(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x722AAF0", Offset = "0x7229EF0", VA = "0x18722AAF0")]
	[Preserve]
	public FCEPEODFEND([NCPIDBJOPHL(null)] FEMOAGJKFIL BCDADBIGBNP, [NCPIDBJOPHL(null)] KGHBNCMFNJA KEGLHDAMBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7229F90", Offset = "0x7229390", VA = "0x187229F90", Slot = "18")]
	public override DAODDLKDJDG CAEOLKHFHEJ(OEKPGCKAHJN NMIKEFKOPMC, IEnumerator<PKLKPEJFEBK> DJKFCGHNDGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x722A1F0", Offset = "0x72295F0", VA = "0x18722A1F0", Slot = "19")]
	public override void FCLPPFCBMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x722A620", Offset = "0x7229A20", VA = "0x18722A620", Slot = "21")]
	public override void IPDDINANMKF(FLBNJJOGANK ONEBPNNLLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x722A0C0", Offset = "0x72294C0", VA = "0x18722A0C0", Slot = "20")]
	protected override void DKKALNJCGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7229F60", Offset = "0x7229360", VA = "0x187229F60")]
	private EOGEOBACKMD BDELKIJMMMJ(FLBNJJOGANK EPPKBKJHHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x722A8C0", Offset = "0x7229CC0", VA = "0x18722A8C0", Slot = "22")]
	internal override JENDMFBIJKO MPIPCOBPGJF(IEnumerator<PKLKPEJFEBK> DJKFCGHNDGL, Behaviour NMIKEFKOPMC, GMFOBHMAHOA AJCDJPGFGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x722A480", Offset = "0x7229880", VA = "0x18722A480", Slot = "23")]
	internal override CNAKHAJNLGN GONGPBCDCJH(FLBNJJOGANK KNKEEMDNDKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x722A500", Offset = "0x7229900", VA = "0x18722A500")]
	private void HKELILPHPGB(EOGEOBACKMD NMEMBMDABOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x722A190", Offset = "0x7229590", VA = "0x18722A190", Slot = "24")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[BurstCompile]
internal struct MFFHEBJGLJG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	public float AAMDFBDOBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	public int OPPFEKJDGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NativeArray<int> FKJCOMCBNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private NativeArray<int> LNKFJMLOIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> CLGPBBHBIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	public NativeArray<IDKKKKIDGAI> NBFIKKOIAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	public NativeArray<float> KDDGAAKMOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[WriteOnly]
	public NativeArray<int> HFOBHBKEBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[WriteOnly]
	public NativeArray<int> CNCMJHDIKDC;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x72320D0", Offset = "0x72314D0", VA = "0x1872320D0")]
	public static MFFHEBJGLJG IBMNHJIAJMD(int EOJPMKGKNDK, float AAMNMBGKMBE, NativeArray<IDKKKKIDGAI> DGICOCIJEGA, NativeArray<float> OILHMOJPNBI, NativeArray<int> LJFCGICGBCD, NativeArray<int> OABJPKJPMLM, NativeArray<int> MLJOMGGNINM, NativeArray<int> LNKFJMLOIAB, NativeArray<int> CLGPBBHBIOL)
	{
		return default(MFFHEBJGLJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7231FF0", Offset = "0x72313F0", VA = "0x187231FF0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7232130", Offset = "0x7231530", VA = "0x187232130")]
	private bool KGMCIAEODFK(int AGAGKNBDCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7231F20", Offset = "0x7231320", VA = "0x187231F20")]
	private void BHAJFHFJBBJ(NativeArray<int> FGNPEDBIABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7231F50", Offset = "0x7231350", VA = "0x187231F50")]
	private int EMPJADMPJJL(int PEJDDMJIOKC, int BDDJBGPEFOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7232170", Offset = "0x7231570", VA = "0x187232170")]
	private void OBPACPMOKNC(NativeArray<int> FGNPEDBIABE, int DKNNNPKMPGL, int LONPDOIHFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7231CE0", Offset = "0x72310E0", VA = "0x187231CE0")]
	private void AKDAGCFPEIO(NativeArray<int> FGNPEDBIABE, int CEKBHFHOIED, int HKPEKEBGPDO, int OJBFFJJPMII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class LFHMKIPFDKB : FFCDFGJFKJB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly FEMOAGJKFIL BCDADBIGBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	protected readonly KGHBNCMFNJA KEGLHDAMBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private CNAKHAJNLGN[] EPLMCBDDAID;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static FFCDFGJFKJB CLHFPJDPLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7230D80", Offset = "0x7230180", VA = "0x187230D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool ADBLGJPBPPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public FLBNJJOGANK BEICENKEKPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x84B1A0", Offset = "0x84A5A0", VA = "0x18084B1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FLBNJJOGANK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x84D870", Offset = "0x84CC70", VA = "0x18084D870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public KGHBNCMFNJA DFLHFAHDODM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public PKLKPEJFEBK NINHMAMFDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public PKLKPEJFEBK LPJNDDALICG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x857620", Offset = "0x856A20", VA = "0x180857620", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public PKLKPEJFEBK OAMDCBADJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x854190", Offset = "0x853590", VA = "0x180854190", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7230B30", Offset = "0x722FF30", VA = "0x187230B30")]
	public static DAODDLKDJDG EJMPDOGOBLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x72313B0", Offset = "0x72307B0", VA = "0x1872313B0")]
	[Preserve]
	protected LFHMKIPFDKB([NCPIDBJOPHL(null)] FEMOAGJKFIL BCDADBIGBNP, [NCPIDBJOPHL(null)] KGHBNCMFNJA KEGLHDAMBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7231080", Offset = "0x7230480", VA = "0x187231080", Slot = "6")]
	public DAODDLKDJDG JBMECBCMFCJ(IEnumerator<PKLKPEJFEBK> DJKFCGHNDGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7230E80", Offset = "0x7230280", VA = "0x187230E80", Slot = "7")]
	public DAODDLKDJDG JBMECBCMFCJ(Behaviour NMIKEFKOPMC, IEnumerator<PKLKPEJFEBK> DJKFCGHNDGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract DAODDLKDJDG CAEOLKHFHEJ(OEKPGCKAHJN NMIKEFKOPMC, IEnumerator<PKLKPEJFEBK> DJKFCGHNDGL);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7230BE0", Offset = "0x722FFE0", VA = "0x187230BE0", Slot = "19")]
	public virtual void FCLPPFCBMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x72308D0", Offset = "0x722FCD0", VA = "0x1872308D0", Slot = "9")]
	public void EFPAIBBGJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x72304F0", Offset = "0x722F8F0", VA = "0x1872304F0", Slot = "20")]
	protected virtual void DKKALNJCGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7231300", Offset = "0x7230700", VA = "0x187231300")]
	private void MOFOHCACHLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7231260", Offset = "0x7230660", VA = "0x187231260")]
	private void LBJICMFLHHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7230B10", Offset = "0x722FF10", VA = "0x187230B10")]
	private void EGMEIPNOEJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7230470", Offset = "0x722F870", VA = "0x187230470")]
	private void AIMMALFDAGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7230DD0", Offset = "0x72301D0", VA = "0x187230DD0")]
	private void HPCJNMJIPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x72312E0", Offset = "0x72306E0", VA = "0x1872312E0")]
	private void MJHHALHMBBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7230BC0", Offset = "0x722FFC0", VA = "0x187230BC0")]
	private void EPEPIPACDJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7230DF0", Offset = "0x72301F0", VA = "0x187230DF0", Slot = "21")]
	public virtual void IPDDINANMKF(FLBNJJOGANK ONEBPNNLLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7231090", Offset = "0x7230490", VA = "0x187231090")]
	private void JLPNDJPDOBG(CNAKHAJNLGN NMEMBMDABOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1EEE9C0", Offset = "0x1EEDDC0", VA = "0x181EEE9C0")]
	private CNAKHAJNLGN PPIOIGDDGAB(FLBNJJOGANK EPPKBKJHHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract JENDMFBIJKO MPIPCOBPGJF(IEnumerator<PKLKPEJFEBK> DJKFCGHNDGL, Behaviour AIACGFOCMAK, GMFOBHMAHOA KLBCCLKHJHD);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract CNAKHAJNLGN GONGPBCDCJH(FLBNJJOGANK ONEBPNNLLPE);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7230510", Offset = "0x722F910", VA = "0x187230510", Slot = "24")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7231280", Offset = "0x7230680", VA = "0x187231280", Slot = "14")]
	public PKLKPEJFEBK MBDIACHILBD(FLBNJJOGANK KNKEEMDNDKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7231320", Offset = "0x7230720", VA = "0x187231320", Slot = "15")]
	public PKLKPEJFEBK OGBBEHFEHHG(float NEHLEIDGFCE, FLBNJJOGANK KNKEEMDNDKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7230490", Offset = "0x722F890", VA = "0x187230490", Slot = "16")]
	public PKLKPEJFEBK BDLKJLMOABK(Func<bool> GGBDOLNKFKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class JENDMFBIJKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly GMFOBHMAHOA AJCDJPGFGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly FIJFOLEMGFO NMIKEFKOPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly bool HNIKGEJECEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private string FIKHOKLHCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private StackTrace NFJMEHONODN;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public IEnumerator<PKLKPEJFEBK> PBGMPGCLNNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public PKLKPEJFEBK PCFLOONJAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool MAGDJFIDFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x722D0B0", Offset = "0x722C4B0", VA = "0x18722D0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool DICKEBJCPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x95D480", Offset = "0x95C880", VA = "0x18095D480")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xAD6100", Offset = "0xAD5500", VA = "0x180AD6100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public string KHPOGHNODCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x722D500", Offset = "0x722C900", VA = "0x18722D500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float LNPHCDANIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x95D420", Offset = "0x95C820", VA = "0x18095D420")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5E751B0", Offset = "0x5E745B0", VA = "0x185E751B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x722D790", Offset = "0x722CB90", VA = "0x18722D790")]
	public JENDMFBIJKO(IEnumerator<PKLKPEJFEBK> ACNIIDMJAAD, FIJFOLEMGFO NMIKEFKOPMC, GMFOBHMAHOA AJCDJPGFGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x722D1F0", Offset = "0x722C5F0", VA = "0x18722D1F0")]
	public PKLKPEJFEBK LLKGGKKHHFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x722D130", Offset = "0x722C530", VA = "0x18722D130")]
	public bool JLAJJPKGJKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x722D1A0", Offset = "0x722C5A0", VA = "0x18722D1A0")]
	public void LCBEKHBDNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x722D6B0", Offset = "0x722CAB0", VA = "0x18722D6B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xB47D70", Offset = "0xB47170", VA = "0x180B47D70")]
	[CompilerGenerated]
	private void PGEANCJOKPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class GMFOBHMAHOA : BNLJAFHHJEE, DAODDLKDJDG, FCIMHBPMHFO, FFCFPAFMHJP, IEnumerator, PKLKPEJFEBK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private FLBNJJOGANK MHJONDBMGNH;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private FLBNJJOGANK GNHFKHMMBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x10EC200", Offset = "0x10EB600", VA = "0x1810EC200", Slot = "23")]
		get
		{
			return default(FLBNJJOGANK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public FLBNJJOGANK HIFHOCCMFBG
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1638B00", Offset = "0x1637F00", VA = "0x181638B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private float GMBPBNFCFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x94DDC0", Offset = "0x94D1C0", VA = "0x18094DDC0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool FNCKIEAOGOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x722BE40", Offset = "0x722B240", VA = "0x18722BE40", Slot = "24")]
	private bool ONJBOFEDOAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x722BE30", Offset = "0x722B230", VA = "0x18722BE30", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x722BE60", Offset = "0x722B260", VA = "0x18722BE60")]
	public GMFOBHMAHOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal enum IIMKGEKNDGB : byte
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
internal sealed class CNAKHAJNLGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum NDFMGDLFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public struct ABHJOHEIGLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public FLBNJJOGANK EEFLOJHPCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public NDFMGDLFNKK MNBCHOFNKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<JENDMFBIJKO> GANFFENJMOI;
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly NDFMGDLFNKK[] BIOJBGGCOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly FLBNJJOGANK ONEBPNNLLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private bool BLENBHFFLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly JENDMFBIJKO[] NCCKANLADGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<JENDMFBIJKO> AJJFPBOLOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<int> LAJNOBGPJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly List<JENDMFBIJKO> KJAMNMDLMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Stack<int> KMEFJPNKLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly PIJGOCCKJDF DDJAPLHGCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private bool KIIADHIFHLC;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public ABHJOHEIGLL[,] EABAECKKHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x854190", Offset = "0x853590", VA = "0x180854190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x721E9E0", Offset = "0x721DDE0", VA = "0x18721E9E0")]
	public CNAKHAJNLGN(FLBNJJOGANK KNKEEMDNDKM, PIJGOCCKJDF DDJAPLHGCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x721E490", Offset = "0x721D890", VA = "0x18721E490")]
	public void MJIBEHGMEHG(JENDMFBIJKO ACNIIDMJAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x721E590", Offset = "0x721D990", VA = "0x18721E590")]
	public void NPNLJKJEAJE(IList<JENDMFBIJKO> ENMNHEDEPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x721E180", Offset = "0x721D580", VA = "0x18721E180")]
	public void MHBIMGAONAC(IList<JENDMFBIJKO> ENMNHEDEPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x721DDD0", Offset = "0x721D1D0", VA = "0x18721DDD0")]
	private void GIAPHIPJMAN(JENDMFBIJKO ACNIIDMJAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x721DC40", Offset = "0x721D040", VA = "0x18721DC40")]
	private void FKOEFDGDCDH(IList<JENDMFBIJKO> ENMNHEDEPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x721E000", Offset = "0x721D400", VA = "0x18721E000")]
	private IIMKGEKNDGB KLCJIMMCOID(JENDMFBIJKO ACNIIDMJAAD)
	{
		return default(IIMKGEKNDGB);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x721D7C0", Offset = "0x721CBC0", VA = "0x18721D7C0")]
	public void DKKALNJCGIH(float AAMNMBGKMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x721DA50", Offset = "0x721CE50", VA = "0x18721DA50")]
	public void EFPAIBBGJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x721D4C0", Offset = "0x721C8C0", VA = "0x18721D4C0")]
	private void DCFOHMHMPGG(List<JENDMFBIJKO> ENMNHEDEPBH, Stack<int> MGOFGLDPKMG, bool MBJHMFPOJKF, float OPNOHKNOCEE = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x721D930", Offset = "0x721CD30", VA = "0x18721D930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x721DEC0", Offset = "0x721D2C0", VA = "0x18721DEC0")]
	private void GNGEDHIJJCH(List<JENDMFBIJKO> ENMNHEDEPBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class OOEGNHFECMG : PIJGOCCKJDF
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "4")]
	public void NDAFHOIMDCC(string FIKHOKLHCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
	public void KJEBFDFELFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public OOEGNHFECMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class DNEIKKLCFNA : FIJFOLEMGFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly Behaviour AIACGFOCMAK;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string KHPOGHNODCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x72235A0", Offset = "0x72229A0", VA = "0x1872235A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool MGBFPLDKMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7223550", Offset = "0x7222950", VA = "0x187223550", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool NNPBFLGPGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7223530", Offset = "0x7222930", VA = "0x187223530", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	public DNEIKKLCFNA(Behaviour AIACGFOCMAK)
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

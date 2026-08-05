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
public class AGLLPDPKGAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority DDIIKHAEKDB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64D10E0", Offset = "0x64D00E0", VA = "0x1864D10E0")]
	public AGLLPDPKGAO(ThreadPriority MDICGLDBOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64D10D0", Offset = "0x64D00D0", VA = "0x1864D10D0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> BKNOEFAIFGM(List<PlayerLoopSystem> JOBFEDHABOB, int INMDEBPJPAG);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct PGEIBNEOFJP
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct CEJOKAGLIMJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static DNHICBJBOMM JFEHDJBGKHM;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x64D5070", Offset = "0x64D4070", VA = "0x1864D5070")]
				public static PlayerLoopSystem HENKGGPONJJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct KBNNHJCGLNG
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static DNHICBJBOMM BNHDJIDPKCA;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x64E1290", Offset = "0x64E0290", VA = "0x1864E1290")]
				public static PlayerLoopSystem HENKGGPONJJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct HEPCINABLLJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static DNHICBJBOMM KPMNPGNDMDI;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAB00", VA = "0x1864DBB00")]
				public static PlayerLoopSystem HENKGGPONJJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct ADFPGDEFKBM
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static DNHICBJBOMM CCEIBGOMNKK;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static DNHICBJBOMM CCEIBFPDNJO;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static DNHICBJBOMM NNCMJPLKPKI;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static DNHICBJBOMM NGGNLLHLGHK;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x64D0BE0", Offset = "0x64CFBE0", VA = "0x1864D0BE0")]
				public static PlayerLoopSystem HENKGGPONJJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct DBCJBDKAPGL
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static DNHICBJBOMM HDCMGDMEOPH;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x64D90E0", Offset = "0x64D80E0", VA = "0x1864D90E0")]
				public static PlayerLoopSystem HENKGGPONJJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct CFNKBGNHJOK
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static DNHICBJBOMM CCEIBGOMNKK;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static DNHICBJBOMM CCEIBFPDNJO;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static DNHICBJBOMM NNCMJPLKPKI;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static DNHICBJBOMM NGGNLLHLGHK;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x64D5270", Offset = "0x64D4270", VA = "0x1864D5270")]
				public static PlayerLoopSystem HENKGGPONJJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct FBEDAABBPBG
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static DNHICBJBOMM KBHJNKBCOPB;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x64D9E90", Offset = "0x64D8E90", VA = "0x1864D9E90")]
				public static PlayerLoopSystem HENKGGPONJJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct KDIDKKHJECP
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static DNHICBJBOMM OAECJCLDDAO;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x64E1490", Offset = "0x64E0490", VA = "0x1864E1490")]
				public static PlayerLoopSystem HENKGGPONJJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct GGALHDIMHIF
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static DNHICBJBOMM EFHLBEECGCE;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x64DB290", Offset = "0x64DA290", VA = "0x1864DB290")]
				public static PlayerLoopSystem HENKGGPONJJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct AOODICCPGJF
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static DNHICBJBOMM NCKALPNIIJJ;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x64D1D30", Offset = "0x64D0D30", VA = "0x1864D1D30")]
				public static PlayerLoopSystem HENKGGPONJJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct AELDFDEBAPA
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static DNHICBJBOMM DCGNJDFGLAH;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x64D0ED0", Offset = "0x64CFED0", VA = "0x1864D0ED0")]
				public static PlayerLoopSystem HENKGGPONJJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct MJCLCCPMKDO
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static DNHICBJBOMM IJNFPGJJJBP;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x64E2E80", Offset = "0x64E1E80", VA = "0x1864E2E80")]
				public static PlayerLoopSystem HENKGGPONJJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum LLIKGMLFCIM : byte
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
			public struct BCMNDIDDLDI
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class DPBCLHOANBF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public LLIKGMLFCIM updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
					public DPBCLHOANBF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x64D9890", Offset = "0x64D8890", VA = "0x1864D9890")]
					internal void NJGHJLAMKIH()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static JEHDIEPKPPJ<LLIKGMLFCIM> PJGBNAPEIDB;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x64D1F30", Offset = "0x64D0F30", VA = "0x1864D1F30")]
				public static PlayerLoopSystem HENKGGPONJJ(LLIKGMLFCIM KLKMKPLGKFN)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct OBEMDJDNDGB
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class PLGMBDHKEKO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public BMOLNHENNIG.DGFECCCDDJO key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
					public PLGMBDHKEKO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x64EBB20", Offset = "0x64EAB20", VA = "0x1864EBB20")]
					internal void GPAOHNFKKCP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable JNJGOLONKKP;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x64E6C30", Offset = "0x64E5C30", VA = "0x1864E6C30")]
				public static PlayerLoopSystem DHDLJAIKGCA(BMOLNHENNIG.DGFECCCDDJO BGNGIHJEFLM)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct OGGNPFHAGCN
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class OHNCAODDFOO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public BMOLNHENNIG.DGFECCCDDJO key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
					public OHNCAODDFOO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x64E9840", Offset = "0x64E8840", VA = "0x1864E9840")]
					internal void GPAOHNFKKCP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x64E9710", Offset = "0x64E8710", VA = "0x1864E9710")]
				public static PlayerLoopSystem DHDLJAIKGCA(BMOLNHENNIG.DGFECCCDDJO BGNGIHJEFLM)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class FHMCLPPPELC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public FHMCLPPPELC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x64DA0C0", Offset = "0x64D90C0", VA = "0x1864DA0C0")]
			internal List<PlayerLoopSystem> KFOHLKDEMFI(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool JPJMPKNJPIK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool KBEFNEFKGFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x64D5990", Offset = "0x64D4990", VA = "0x1864D5990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64D5EE0", Offset = "0x64D4EE0", VA = "0x1864D5EE0")]
		private static void LLNDOPALGCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64D8810", Offset = "0x64D7810", VA = "0x1864D8810")]
		private static void NKFFIPMAEFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64D55A0", Offset = "0x64D45A0", VA = "0x1864D55A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64D57D0", Offset = "0x64D47D0", VA = "0x1864D57D0")]
		private static void COFMAKKHLEP(BMOLNHENNIG.DGFECCCDDJO BGNGIHJEFLM, PlayerLoopSystem JEOANINPOMF, Type LDLEENNHOOO, Type FKPGBIKEMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64D59D0", Offset = "0x64D49D0", VA = "0x1864D59D0")]
		private static void GKICFIOLDND(PlayerLoopSystem JEOANINPOMF, Type LDLEENNHOOO, Type FKPGBIKEMPO, BKNOEFAIFGM CPEPKFLHNAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64D5DB0", Offset = "0x64D4DB0", VA = "0x1864D5DB0")]
		private static void IGGOKCBGCGF(PlayerLoopSystem JEOANINPOMF, Type LDLEENNHOOO, Type FKPGBIKEMPO, PlayerLoopSystem? AAMAIALONPH, PlayerLoopSystem? JKECOLFHBLF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class BMOLNHENNIG
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum DGFECCCDDJO
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
	public class JKONKKMOFNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly DGFECCCDDJO CMPDDHKAIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly KAOBBJHJECK MOIDMDLHDAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long DMABEAPGEIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long KPCBPIJLHDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long NNFFGGNFCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int MCFLDGLOMNG;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x64E0340", Offset = "0x64DF340", VA = "0x1864E0340")]
		public JKONKKMOFNM(DGFECCCDDJO FJJDICDJNOH, int NGICDPHMJMH = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64E00F0", Offset = "0x64DF0F0", VA = "0x1864E00F0")]
		public void LLGLCJBIMOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64E00A0", Offset = "0x64DF0A0", VA = "0x1864E00A0")]
		public void GMBCBOBCCNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x64E0160", Offset = "0x64DF160", VA = "0x1864E0160")]
		public void PFKFAGJNLIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static DGFECCCDDJO[] AJHILEGCMLI;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static JKONKKMOFNM[] ILFOPBBDHOB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x64D33E0", Offset = "0x64D23E0", VA = "0x1864D33E0")]
	public static JKONKKMOFNM PMODOLFDCKB(DGFECCCDDJO BGNGIHJEFLM, int NGICDPHMJMH = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x64D32D0", Offset = "0x64D22D0", VA = "0x1864D32D0")]
	public static JKONKKMOFNM KIDAMDGGMDF(DGFECCCDDJO BGNGIHJEFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x64D3340", Offset = "0x64D2340", VA = "0x1864D3340")]
	public static void KOMGAFDHJNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class KAOBBJHJECK : AKJGMHFJICO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int EGABFDIELIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> JNBNLIGECCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double FFLDCCJCEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double IKHANJLEPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double DEPJGIPMCFO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double HPMPFIJEEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x64E0FF0", Offset = "0x64DFFF0", VA = "0x1864E0FF0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double MOBCDMPGGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x16AF760", Offset = "0x16AE760", VA = "0x1816AF760", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double AIKCKHKMAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1C84B40", Offset = "0x1C83B40", VA = "0x181C84B40", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x64E11E0", Offset = "0x64E01E0", VA = "0x1864E11E0")]
	public KAOBBJHJECK(int DEIGAAFMIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x64E1050", Offset = "0x64E0050", VA = "0x1864E1050", Slot = "7")]
	public void CNGPBDIGGEE(double DKCKOABFNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x64E1170", Offset = "0x64E0170", VA = "0x1864E1170", Slot = "8")]
	public void OFPJBAGGFGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class IHMNGPDFJAI : AKJGMHFJICO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long AGLAJIDEGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double BAFIDFDLNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double KJPLDIBJJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double KPNFIJKHPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double EGCAEEJIOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double FFLDCCJCEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double IKHANJLEPJG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double MOBCDMPGGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5495CC0", Offset = "0x5494CC0", VA = "0x185495CC0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double AIKCKHKMAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5495C40", Offset = "0x5494C40", VA = "0x185495C40", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double LBPOCPHHPBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5495BF0", Offset = "0x5494BF0", VA = "0x185495BF0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double HPMPFIJEEEO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2090900", Offset = "0x208F900", VA = "0x182090900", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x64DEAD0", Offset = "0x64DDAD0", VA = "0x1864DEAD0", Slot = "7")]
	public virtual void CNGPBDIGGEE(double DKCKOABFNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x64DEBF0", Offset = "0x64DDBF0", VA = "0x1864DEBF0", Slot = "8")]
	public virtual void OFPJBAGGFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x64DEC30", Offset = "0x64DDC30", VA = "0x1864DEC30")]
	public IHMNGPDFJAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class LKCPICFOJCH : IHMNGPDFJAI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double OEFJBHIFOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5495C50", Offset = "0x5494C50", VA = "0x185495C50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x54957B0", Offset = "0x54947B0", VA = "0x1854957B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x64E2630", Offset = "0x64E1630", VA = "0x1864E2630", Slot = "7")]
	public override void CNGPBDIGGEE(double DKCKOABFNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x64E2760", Offset = "0x64E1760", VA = "0x1864E2760", Slot = "8")]
	public override void OFPJBAGGFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x64DEC30", Offset = "0x64DDC30", VA = "0x1864DEC30")]
	public LKCPICFOJCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface AKJGMHFJICO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double HPMPFIJEEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double MOBCDMPGGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double AIKCKHKMAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class BLKFOJJGIDI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface LIMJDHICKBL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool KMACMDABKEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FAMMDIJKGAD();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class EKIGOFEHMHM<TPromise, TMainThreadPromise> : LIMJDHICKBL where TPromise : LDFABEFGIKK where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise LPGIBLNBHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise OHFNGLDOJMD;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise IDEFPEEENGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x3108350", Offset = "0x3107350", VA = "0x183108350")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KMACMDABKEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x31082E0", Offset = "0x31072E0", VA = "0x1831082E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x77EB20", Offset = "0x77DB20", VA = "0x18077EB20")]
		protected EKIGOFEHMHM(TPromise LPGIBLNBHOA, TMainThreadPromise MNAOBEEFFFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3108330", Offset = "0x3107330", VA = "0x183108330", Slot = "5")]
		public void FAMMDIJKGAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void EGNIMKMFHII(TPromise LPGIBLNBHOA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class CGIALGBCBAE<T> : EKIGOFEHMHM<FFKFAKMNOMC<T>, GJKPNNNIKCG<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x47F8B20", Offset = "0x47F7B20", VA = "0x1847F8B20")]
		public CGIALGBCBAE(FFKFAKMNOMC<T> LPGIBLNBHOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x47F88E0", Offset = "0x47F78E0", VA = "0x1847F88E0", Slot = "6")]
		protected override void EGNIMKMFHII(FFKFAKMNOMC<T> LPGIBLNBHOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x373A700", Offset = "0x3739700", VA = "0x18373A700")]
		[CompilerGenerated]
		private void KOFCAODEANP(T BBMBCGDLBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x47F8AF0", Offset = "0x47F7AF0", VA = "0x1847F8AF0")]
		[CompilerGenerated]
		private void MAKACPOMLAA(string KHEFJOIGNAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class KMCJGLOKLPH : LIMJDHICKBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action NFDFJOBAEPD;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool KMACMDABKEC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x78B130", Offset = "0x78A130", VA = "0x18078B130", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
		public KMCJGLOKLPH(Action NFDFJOBAEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB2F300", Offset = "0xB2E300", VA = "0x180B2F300", Slot = "5")]
		public void FAMMDIJKGAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<LIMJDHICKBL> AGEKJBPDFJJ;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x22C4640", Offset = "0x22C3640", VA = "0x1822C4640")]
	public static FFKFAKMNOMC<T> EFAEGDEINAG<T>(this FFKFAKMNOMC<T> LPGIBLNBHOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x64D21C0", Offset = "0x64D11C0", VA = "0x1864D21C0")]
	public static void EFAEGDEINAG(Action NFDFJOBAEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x22C46A0", Offset = "0x22C36A0", VA = "0x1822C46A0")]
	private static FFKFAKMNOMC<T> PFJFCDJIAMD<T>(FFKFAKMNOMC<T> LPGIBLNBHOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x64D2620", Offset = "0x64D1620", VA = "0x1864D2620")]
	private static void LFJGLCGCBFH(LIMJDHICKBL PMPENLGOBJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x64D2260", Offset = "0x64D1260", VA = "0x1864D2260")]
	private static void LBFOCPCGLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x64D2830", Offset = "0x64D1830", VA = "0x1864D2830")]
	private static void LFPGHBEIOJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x64D2540", Offset = "0x64D1540", VA = "0x1864D2540")]
	private static void LDNDJDFNOBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class CECOCEDDECE
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct FPMKOHIGLPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> MJJBMLKLIEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string PHMJOCAELEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode OEOMCAFDONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool LALBJKCONEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x64DB230", Offset = "0x64DA230", VA = "0x1864DB230")]
		public FPMKOHIGLPN(TaskCompletionSource<Scene> FKPIILDBMBC, string PHMJOCAELEH, LoadSceneMode OEOMCAFDONP, bool LALBJKCONEN, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct IBHCNEAPEOF : IAsyncStateMachine
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
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private PFLLCKOMFGL<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x64DDB10", Offset = "0x64DCB10", VA = "0x1864DDB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x64DE3B0", Offset = "0x64DD3B0", VA = "0x1864DE3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct EBGMAEAKIMO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x64D9910", Offset = "0x64D8910", VA = "0x1864D9910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x64D9C30", Offset = "0x64D8C30", VA = "0x1864D9C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct JEHEHBLNDOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private FPMKOHIGLPN <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x64DF9B0", Offset = "0x64DE9B0", VA = "0x1864DF9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x64DFD60", Offset = "0x64DED60", VA = "0x1864DFD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class INCPDLMODGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public GJKPNNNIKCG<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public INCPDLMODGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x64DF950", Offset = "0x64DE950", VA = "0x1864DF950")]
		internal void FECPHACILCO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct ALJGBPIMEPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

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
		private INCPDLMODGK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x64D1120", Offset = "0x64D0120", VA = "0x1864D1120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x64D1CC0", Offset = "0x64D0CC0", VA = "0x1864D1CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct GNLNFDAIAOI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x64DB490", Offset = "0x64DA490", VA = "0x1864DB490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x64DB9A0", Offset = "0x64DA9A0", VA = "0x1864DB9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct PGNDDHMKHEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public PFLLCKOMFGL<string>.FEFFPGFLENA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private PFLLCKOMFGL<string>.FEFFPGFLENA <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x64EAF60", Offset = "0x64E9F60", VA = "0x1864EAF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x64EBAB0", Offset = "0x64EAAB0", VA = "0x1864EBAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class FGFLMMHDHBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public FGFLMMHDHBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x64DA090", Offset = "0x64D9090", VA = "0x1864DA090")]
		internal bool HOBPDPLJGCH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class DDGGMMDFFKM : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private DNLJHOFEIAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public NLHOOGKAONG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
		[DebuggerHidden]
		public DDGGMMDFFKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x64D96C0", Offset = "0x64D86C0", VA = "0x1864D96C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x64D9330", Offset = "0x64D8330", VA = "0x1864D9330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x64D92E0", Offset = "0x64D82E0", VA = "0x1864D92E0")]
		private void GDOLLNLODDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x64D9670", Offset = "0x64D8670", VA = "0x1864D9670", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class LEPBDBKALHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public GJKPNNNIKCG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public LEPBDBKALHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x64E2250", Offset = "0x64E1250", VA = "0x1864E2250")]
		internal bool AKBJPBBEPNB(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x64E22D0", Offset = "0x64E12D0", VA = "0x1864E22D0")]
		internal void LILAPLIPHLB(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class BMHGACHJJDK : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private DNLJHOFEIAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public GJKPNNNIKCG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private LEPBDBKALHN <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
		[DebuggerHidden]
		public BMHGACHJJDK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x64D2B70", Offset = "0x64D1B70", VA = "0x1864D2B70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x64D3280", Offset = "0x64D2280", VA = "0x1864D3280", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> KJNCLDCDIFC;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static LDFABEFGIKK EPDAOGFNDGN;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation LIKLBAGLCAF;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static LDFABEFGIKK DOKNOHNOABK;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string AGAPGIPIGEA;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority MMAFFKAIJKC;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task JNNFAHMGHLI;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> DOMHBPAFLDP;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<FPMKOHIGLPN> BBFLKHGFHKE;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task KGHIBIIEPKP;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool NPCPOLGIKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x64D4300", Offset = "0x64D3300", VA = "0x1864D4300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool DDLBFMLGGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x64D4520", Offset = "0x64D3520", VA = "0x1864D4520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool HELPKNIGPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x64D40C0", Offset = "0x64D30C0", VA = "0x1864D40C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool LDCJHOGJBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x64D4160", Offset = "0x64D3160", VA = "0x1864D4160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> ENOEIKELIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x64D41F0", Offset = "0x64D31F0", VA = "0x1864D41F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x64D45C0", Offset = "0x64D35C0", VA = "0x1864D45C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x64D4B70", Offset = "0x64D3B70", VA = "0x1864D4B70")]
	[NBFFNNAJFGL(NAPENKJMHBJ.EnteredEditModeNextFrame, 0)]
	private static void OBGAFPMAAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x64D3D70", Offset = "0x64D2D70", VA = "0x1864D3D70")]
	[AsyncStateMachine(typeof(IBHCNEAPEOF))]
	public static Task<Scene> FMHGLOOJJLN(string PHMJOCAELEH, LoadSceneMode OEOMCAFDONP = LoadSceneMode.Single, bool LALBJKCONEN = false, [Optional] PFLLCKOMFGL<string>.FEFFPGFLENA FHGCFILCMFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x64D3EC0", Offset = "0x64D2EC0", VA = "0x1864D3EC0")]
	[AsyncStateMachine(typeof(EBGMAEAKIMO))]
	private static Task FMHPLOMOIPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x64D4AA0", Offset = "0x64D3AA0", VA = "0x1864D4AA0")]
	[AsyncStateMachine(typeof(JEHEHBLNDOL))]
	private static Task NFKMJHPHIBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x64D3F70", Offset = "0x64D2F70", VA = "0x1864D3F70")]
	[AsyncStateMachine(typeof(ALJGBPIMEPM))]
	private static Task<Scene> GFODJOOBCOL(string PHMJOCAELEH, LoadSceneMode OEOMCAFDONP, bool LALBJKCONEN, PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x64D4940", Offset = "0x64D3940", VA = "0x1864D4940")]
	private static void MOKJHDMGJEO(SceneInstance PBJLMCDEAOF, LoadSceneMode OEOMCAFDONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x64D46D0", Offset = "0x64D36D0", VA = "0x1864D46D0")]
	private static void LEBDFMHEICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x64D4C70", Offset = "0x64D3C70", VA = "0x1864D4C70")]
	[AsyncStateMachine(typeof(GNLNFDAIAOI))]
	private static Task<Scene> OEPPCBMJFNF(string PHMJOCAELEH, LoadSceneMode OEOMCAFDONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x64D4D90", Offset = "0x64D3D90", VA = "0x1864D4D90")]
	private static bool PPFLGNHOAAG(string PHMJOCAELEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x64D4790", Offset = "0x64D3790", VA = "0x1864D4790")]
	[AsyncStateMachine(typeof(PGNDDHMKHEE))]
	private static Task<Scene> LNNJHDADHME(PFLLCKOMFGL<string>.FEFFPGFLENA FBDGCHNLJEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x64D37F0", Offset = "0x64D27F0", VA = "0x1864D37F0")]
	public static FFKFAKMNOMC<Scene> AGHDCMKKAJK(string PHMJOCAELEH, LoadSceneMode OEOMCAFDONP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x64D3AA0", Offset = "0x64D2AA0", VA = "0x1864D3AA0")]
	public static LDFABEFGIKK FIFHIEKKFAG(string PHMJOCAELEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x64D3760", Offset = "0x64D2760", VA = "0x1864D3760")]
	[IteratorStateMachine(typeof(DDGGMMDFFKM))]
	private static IEnumerator<DNLJHOFEIAO> AFNCGNILNJF(string PHMJOCAELEH, NLHOOGKAONG MIOGCGCEGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x64D48A0", Offset = "0x64D38A0", VA = "0x1864D48A0")]
	[IteratorStateMachine(typeof(BMHGACHJJDK))]
	private static IEnumerator<DNLJHOFEIAO> MMLNOFEANAP(string PHMJOCAELEH, LoadSceneMode OEOMCAFDONP, GJKPNNNIKCG<Scene> MIOGCGCEGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x64D3970", Offset = "0x64D2970", VA = "0x1864D3970")]
	public static bool BBFFFNACMDC([Out] string DHGJGDILHAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class KGIAOKEBJHH
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x64E1BE0", Offset = "0x64E0BE0", VA = "0x1864E1BE0")]
	public static IDisposable HBMJGOCNAGA(this EFMLGEBBGBC ACJODAOHIHK, float BKPPNADBLPD, Action<float> BPPBEEPMPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x64E1B60", Offset = "0x64E0B60", VA = "0x1864E1B60")]
	public static IDisposable FIJJFBMPCIC(this EFMLGEBBGBC ACJODAOHIHK, Action<float> BPPBEEPMPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x64E1C70", Offset = "0x64E0C70", VA = "0x1864E1C70")]
	public static IDisposable MJDFDMGAONM(this EFMLGEBBGBC ACJODAOHIHK, Action<float> BPPBEEPMPDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class JMLHFALPAPC
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x64E09C0", Offset = "0x64DF9C0", VA = "0x1864E09C0")]
	public static IDisposable GPHGPMINAOE(this MonoBehaviour PDBBGMACAPG, Action BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x64E0A50", Offset = "0x64DFA50", VA = "0x1864E0A50")]
	public static IDisposable GPHGPMINAOE(this MonoBehaviour PDBBGMACAPG, Action<float> BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x64E0AE0", Offset = "0x64DFAE0", VA = "0x1864E0AE0")]
	public static IDisposable HOEJNKLEAPP(this MonoBehaviour PDBBGMACAPG, Action BPPBEEPMPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x64E08A0", Offset = "0x64DF8A0", VA = "0x1864E08A0")]
	public static IDisposable FLBMAAPGJBA(this MonoBehaviour PDBBGMACAPG, Action BPPBEEPMPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x64E0820", Offset = "0x64DF820", VA = "0x1864E0820")]
	public static IDisposable FLBMAAPGJBA(this MonoBehaviour PDBBGMACAPG, Action<float> BPPBEEPMPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x64E0DB0", Offset = "0x64DFDB0", VA = "0x1864E0DB0")]
	public static IDisposable LGDGBDMKDKJ(this MonoBehaviour PDBBGMACAPG, Action BPPBEEPMPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x64E0B60", Offset = "0x64DFB60", VA = "0x1864E0B60")]
	public static IDisposable IPEBMNIPEIP(this MonoBehaviour PDBBGMACAPG, Action BPPBEEPMPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x64E0D30", Offset = "0x64DFD30", VA = "0x1864E0D30")]
	public static IDisposable KMLEPBAHFAC(this MonoBehaviour PDBBGMACAPG, Action BPPBEEPMPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x64E0C80", Offset = "0x64DFC80", VA = "0x1864E0C80")]
	public static IDisposable KDIGHLKFBMC(this MonoBehaviour PDBBGMACAPG, float BKPPNADBLPD, Action<float> BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL, bool GFLJNKOMNMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x64E0E30", Offset = "0x64DFE30", VA = "0x1864E0E30")]
	public static IDisposable MNNCCMNDNBJ(this MonoBehaviour PDBBGMACAPG, float BKPPNADBLPD, Action<float> BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL, bool GFLJNKOMNMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x64E0920", Offset = "0x64DF920", VA = "0x1864E0920")]
	public static IDisposable GNBIDLNCMBO(this MonoBehaviour PDBBGMACAPG, float BKPPNADBLPD, Action<float> BPPBEEPMPDF, bool GFLJNKOMNMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x64E0F50", Offset = "0x64DFF50", VA = "0x1864E0F50")]
	public static IDisposable PIJDCPDKPNB(this MonoBehaviour PDBBGMACAPG, Action<float> BPPBEEPMPDF, bool GFLJNKOMNMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x64E0BE0", Offset = "0x64DFBE0", VA = "0x1864E0BE0")]
	public static IDisposable JKGBOOCNFID(this MonoBehaviour PDBBGMACAPG, Action<float> BPPBEEPMPDF, bool GFLJNKOMNMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x64E0640", Offset = "0x64DF640", VA = "0x1864E0640")]
	public static IDisposable DBBEOMKPKNP(this MonoBehaviour PDBBGMACAPG, Action<float> BPPBEEPMPDF, bool GFLJNKOMNMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x64E0450", Offset = "0x64DF450", VA = "0x1864E0450")]
	public static IDisposable ABNGHCDODCK(this MonoBehaviour PDBBGMACAPG, Action<float> BPPBEEPMPDF, bool GFLJNKOMNMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x64E05A0", Offset = "0x64DF5A0", VA = "0x1864E05A0")]
	public static IDisposable CIANCMOKCDH(this MonoBehaviour PDBBGMACAPG, Action<float> BPPBEEPMPDF, bool GFLJNKOMNMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x64E06E0", Offset = "0x64DF6E0", VA = "0x1864E06E0")]
	public static IDisposable DKPCKICBFLP(this MonoBehaviour PDBBGMACAPG, Action<float> BPPBEEPMPDF, bool GFLJNKOMNMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x64E0780", Offset = "0x64DF780", VA = "0x1864E0780")]
	public static IDisposable EMDNALDJDAN(this MonoBehaviour PDBBGMACAPG, Action<float> BPPBEEPMPDF, bool GFLJNKOMNMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x64E04F0", Offset = "0x64DF4F0", VA = "0x1864E04F0")]
	public static IDisposable ALDJAIBPLCG(this MonoBehaviour PDBBGMACAPG, float BKPPNADBLPD, Action<float> BPPBEEPMPDF, bool GFLJNKOMNMK = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class MAAJKABPLGI
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class LLMIHHONOAN : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private DNLJHOFEIAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public EEDKBGMEMHA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private FLGOOBGPJMK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
		[DebuggerHidden]
		public LLMIHHONOAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x64E27A0", Offset = "0x64E17A0", VA = "0x1864E27A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x64E2880", Offset = "0x64E1880", VA = "0x1864E2880", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class DMAKMIHEALD : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private DNLJHOFEIAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public EEDKBGMEMHA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private FLGOOBGPJMK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
		[DebuggerHidden]
		public DMAKMIHEALD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x64D9750", Offset = "0x64D8750", VA = "0x1864D9750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x64D9840", Offset = "0x64D8840", VA = "0x1864D9840", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x64E2BD0", Offset = "0x64E1BD0", VA = "0x1864E2BD0")]
	public static GPGMPFEJBGM GPHGPMINAOE(Action BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x64E2B10", Offset = "0x64E1B10", VA = "0x1864E2B10")]
	public static GPGMPFEJBGM GPHGPMINAOE(Behaviour ACJODAOHIHK, Action BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x64E2C80", Offset = "0x64E1C80", VA = "0x1864E2C80")]
	public static GPGMPFEJBGM GPHGPMINAOE(Behaviour ACJODAOHIHK, Action<float> BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x64E29F0", Offset = "0x64E19F0", VA = "0x1864E29F0")]
	[IteratorStateMachine(typeof(LLMIHHONOAN))]
	private static IEnumerator<DNLJHOFEIAO> FGDJIBCIFGK(EEDKBGMEMHA LACKAMJJHMC, Action BPPBEEPMPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x64E2A80", Offset = "0x64E1A80", VA = "0x1864E2A80")]
	[IteratorStateMachine(typeof(DMAKMIHEALD))]
	private static IEnumerator<DNLJHOFEIAO> FGDJIBCIFGK(EEDKBGMEMHA LACKAMJJHMC, Action<float> BPPBEEPMPDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class MKEGLAEHKDF : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class LIFGPLHLONO : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private DNLJHOFEIAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public MKEGLAEHKDF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
		[DebuggerHidden]
		public LIFGPLHLONO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x64E2550", Offset = "0x64E1550", VA = "0x1864E2550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x64E25E0", Offset = "0x64E15E0", VA = "0x1864E25E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly EEDKBGMEMHA HHMCMICFMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action KEOIFHGPFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool AHPNHMOIPJN;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BKEJBEDEMML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x774F30", Offset = "0x773F30", VA = "0x180774F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x64E31A0", Offset = "0x64E21A0", VA = "0x1864E31A0")]
	public MKEGLAEHKDF(EEDKBGMEMHA HHMCMICFMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x64E3120", Offset = "0x64E2120", VA = "0x1864E3120")]
	[IteratorStateMachine(typeof(LIFGPLHLONO))]
	private IEnumerator<DNLJHOFEIAO> PLCKFLPAEHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x64E3080", Offset = "0x64E2080", VA = "0x1864E3080", Slot = "4")]
	public void OnCompleted(Action JLGLEDLMDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
	public void CIEIGFPHENP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class HGNJPKKECHN
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x64DC650", Offset = "0x64DB650", VA = "0x1864DC650")]
	public static MKEGLAEHKDF LKIDDMAHHKC(this EEDKBGMEMHA HHMCMICFMDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class OJKJFONIMLE
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class OMPNBBKLALP : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private DNLJHOFEIAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AMNJBHCBNCG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
		[DebuggerHidden]
		public OMPNBBKLALP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x64EA310", Offset = "0x64E9310", VA = "0x1864EA310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x64EA390", Offset = "0x64E9390", VA = "0x1864EA390", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x64E9DA0", Offset = "0x64E8DA0", VA = "0x1864E9DA0")]
	public static GPGMPFEJBGM GPHGPMINAOE(float BKPPNADBLPD, Action<float> BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL, bool GFLJNKOMNMK = true, [Optional] MDGCLNFMPFL DJIGGENDPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x64E9C90", Offset = "0x64E8C90", VA = "0x1864E9C90")]
	public static GPGMPFEJBGM GPHGPMINAOE(MonoBehaviour PDBBGMACAPG, float BKPPNADBLPD, Action<float> BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL, bool GFLJNKOMNMK = true, [Optional] MDGCLNFMPFL DJIGGENDPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x64E9AB0", Offset = "0x64E8AB0", VA = "0x1864E9AB0")]
	public static GPGMPFEJBGM CEJJIJKDPOI(MonoBehaviour PDBBGMACAPG, float BKPPNADBLPD, Action<float> BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL, bool GFLJNKOMNMK = true, [Optional] MDGCLNFMPFL DJIGGENDPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x64E9F00", Offset = "0x64E8F00", VA = "0x1864E9F00")]
	public static GPGMPFEJBGM LOOKEMFPGLL(EFMLGEBBGBC ACJODAOHIHK, float BKPPNADBLPD, Action<float> BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL, bool GFLJNKOMNMK = true, [Optional] MDGCLNFMPFL DJIGGENDPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x64E9BD0", Offset = "0x64E8BD0", VA = "0x1864E9BD0")]
	private static IEnumerator<DNLJHOFEIAO> FGDJIBCIFGK(LOLLHLHJMBC DKFFGPLBMIN, float BKPPNADBLPD, EEDKBGMEMHA LACKAMJJHMC, Action<float> BPPBEEPMPDF, bool GFLJNKOMNMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x64E9EA0", Offset = "0x64E8EA0", VA = "0x1864E9EA0")]
	private static IEnumerator<DNLJHOFEIAO> KEDGDIGGHBI(LOLLHLHJMBC DKFFGPLBMIN, float BKPPNADBLPD, EEDKBGMEMHA LACKAMJJHMC, Action<float> BPPBEEPMPDF, bool GFLJNKOMNMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x64EA010", Offset = "0x64E9010", VA = "0x1864EA010")]
	[IteratorStateMachine(typeof(OMPNBBKLALP))]
	private static IEnumerator<DNLJHOFEIAO> MOKEOEGLMCP(AMNJBHCBNCG BHNNFNLMLCN, float BKPPNADBLPD, EEDKBGMEMHA LACKAMJJHMC, Action<float> BPPBEEPMPDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class BMFOGMELECD
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class JKIBCEKPDHA : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private DNLJHOFEIAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public EEDKBGMEMHA queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
		[DebuggerHidden]
		public JKIBCEKPDHA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x64DFF90", Offset = "0x64DEF90", VA = "0x1864DFF90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x64E0050", Offset = "0x64DF050", VA = "0x1864E0050", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x64D29C0", Offset = "0x64D19C0", VA = "0x1864D29C0")]
	[IteratorStateMachine(typeof(JKIBCEKPDHA))]
	private static IEnumerator<DNLJHOFEIAO> IHDMFODININ(EEDKBGMEMHA HHMCMICFMDL, Func<bool> FJNLKDBBOPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x64D2A50", Offset = "0x64D1A50", VA = "0x1864D2A50")]
	public static GPGMPFEJBGM MOGCKKMHFKF(this MonoBehaviour PDBBGMACAPG, Func<bool> FJNLKDBBOPP, EEDKBGMEMHA HHMCMICFMDL = EEDKBGMEMHA.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class PFDIJJLKILG
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class BDLMELMEHCL : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private DNLJHOFEIAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public EEDKBGMEMHA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
		[DebuggerHidden]
		public BDLMELMEHCL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x64D2100", Offset = "0x64D1100", VA = "0x1864D2100", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x64D2170", Offset = "0x64D1170", VA = "0x1864D2170", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class MGHMPALNPGI : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private DNLJHOFEIAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public EEDKBGMEMHA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private DNLJHOFEIAO <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
		[DebuggerHidden]
		public MGHMPALNPGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x64E2DA0", Offset = "0x64E1DA0", VA = "0x1864E2DA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x64E2E30", Offset = "0x64E1E30", VA = "0x1864E2E30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x64EAD20", Offset = "0x64E9D20", VA = "0x1864EAD20")]
	[IteratorStateMachine(typeof(BDLMELMEHCL))]
	private static IEnumerator<DNLJHOFEIAO> PLCKFLPAEHN(float JPCFJENKEPD, EEDKBGMEMHA LACKAMJJHMC, Action CMDBLPFLCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x64EA7B0", Offset = "0x64E97B0", VA = "0x1864EA7B0")]
	[IteratorStateMachine(typeof(MGHMPALNPGI))]
	private static IEnumerator<DNLJHOFEIAO> FKOPEGONKAE(float JPCFJENKEPD, EEDKBGMEMHA LACKAMJJHMC, Action CMDBLPFLCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x64EA540", Offset = "0x64E9540", VA = "0x1864EA540")]
	public static IDisposable BPNDKLPOGHH(this MonoBehaviour PDBBGMACAPG, float JPCFJENKEPD, Action CMDBLPFLCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x64EA8B0", Offset = "0x64E98B0", VA = "0x1864EA8B0")]
	public static GPGMPFEJBGM GHGPPJFADDE(this MonoBehaviour PDBBGMACAPG, float JPCFJENKEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x64EA660", Offset = "0x64E9660", VA = "0x1864EA660")]
	public static GPGMPFEJBGM BPNDKLPOGHH(this MonoBehaviour PDBBGMACAPG, float JPCFJENKEPD, EEDKBGMEMHA LACKAMJJHMC, Action CMDBLPFLCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x64EA790", Offset = "0x64E9790", VA = "0x1864EA790")]
	public static GPGMPFEJBGM CECEFCLJJAD(this MonoBehaviour PDBBGMACAPG, Action CMDBLPFLCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x64EA970", Offset = "0x64E9970", VA = "0x1864EA970")]
	public static GPGMPFEJBGM GMGGBPOJJGK(this MonoBehaviour PDBBGMACAPG, Action CMDBLPFLCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x64EAA70", Offset = "0x64E9A70", VA = "0x1864EAA70")]
	public static GPGMPFEJBGM LLPDFMBCPPD(this MonoBehaviour PDBBGMACAPG, Action CMDBLPFLCHM, [Optional] MDGCLNFMPFL DJIGGENDPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x64EA880", Offset = "0x64E9880", VA = "0x1864EA880")]
	public static GPGMPFEJBGM GDCIFLOOIEH(this MonoBehaviour PDBBGMACAPG, Action CMDBLPFLCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x64EACF0", Offset = "0x64E9CF0", VA = "0x1864EACF0")]
	public static GPGMPFEJBGM MJNLOHFFAJO(this MonoBehaviour PDBBGMACAPG, Action CMDBLPFLCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x64EA850", Offset = "0x64E9850", VA = "0x1864EA850")]
	public static GPGMPFEJBGM FPMEHMJCCHC(this MonoBehaviour PDBBGMACAPG, Action CMDBLPFLCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x64EAE90", Offset = "0x64E9E90", VA = "0x1864EAE90")]
	private static GPGMPFEJBGM PPMPIIJHOHJ(MonoBehaviour PDBBGMACAPG, EEDKBGMEMHA HHMCMICFMDL, Action CMDBLPFLCHM, [Optional] MDGCLNFMPFL DJIGGENDPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x64EAB50", Offset = "0x64E9B50", VA = "0x1864EAB50")]
	public static GPGMPFEJBGM LODHONAPKHG(this MonoBehaviour PDBBGMACAPG, float DEHFODGPADM, Action CMDBLPFLCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x64EAC20", Offset = "0x64E9C20", VA = "0x1864EAC20")]
	public static GPGMPFEJBGM LODILKHPIHE(this MonoBehaviour PDBBGMACAPG, float DEHFODGPADM, Action CMDBLPFLCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x64EADC0", Offset = "0x64E9DC0", VA = "0x1864EADC0")]
	public static GPGMPFEJBGM PNCKKGJAILB(this MonoBehaviour PDBBGMACAPG, float DEHFODGPADM, Action CMDBLPFLCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x64EA9A0", Offset = "0x64E99A0", VA = "0x1864EA9A0")]
	public static GPGMPFEJBGM JFIAOGBEDIG(this MonoBehaviour PDBBGMACAPG, float DEHFODGPADM, Action CMDBLPFLCHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class HFEMDAAPKCL : KONEPPHLHBI, IEnumerable<KONEPPHLHBI>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<KONEPPHLHBI> JLIKALJAIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool PFCJHNFPEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action CINNANLBJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool EEJJBMCMODO;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool OLKHHEFENIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x64DC150", Offset = "0x64DB150", VA = "0x1864DC150", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JNMMNDLBJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x64DBD00", Offset = "0x64DAD00", VA = "0x1864DBD00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x64DC0B0", Offset = "0x64DB0B0", VA = "0x1864DC0B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x64DC5B0", Offset = "0x64DB5B0", VA = "0x1864DC5B0")]
	public HFEMDAAPKCL([Optional] Action CINNANLBJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x64DBF00", Offset = "0x64DAF00", VA = "0x1864DBF00")]
	public void GPDFOMDKBKK(KONEPPHLHBI PADECPNOCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x64DBDA0", Offset = "0x64DADA0", VA = "0x1864DBDA0")]
	private void DCOKBLLLGLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x64DC5A0", Offset = "0x64DB5A0", VA = "0x1864DC5A0", Slot = "7")]
	public bool OAMJECIAHDB(bool OFOIDDLLFEI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x64DC290", Offset = "0x64DB290", VA = "0x1864DC290", Slot = "8")]
	public bool OAMJECIAHDB(Action NFDFJOBAEPD, bool OFOIDDLLFEI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x64DC030", Offset = "0x64DB030", VA = "0x1864DC030", Slot = "9")]
	public IEnumerator<KONEPPHLHBI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x64DC030", Offset = "0x64DB030", VA = "0x1864DC030", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class OLJIJNCACBG : IHICCMGPOKP
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class NEONENHEONH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public OLJIJNCACBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public NEONENHEONH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x64D0BB0", Offset = "0x64CFBB0", VA = "0x1864D0BB0")]
		internal void HMKNJMJLNAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class AALCFAIFBEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public OLJIJNCACBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public AALCFAIFBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x64D0BB0", Offset = "0x64CFBB0", VA = "0x1864D0BB0")]
		internal void IDEDJHNEGOF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float IMMDMFJNIJP;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x64D9D90", Offset = "0x64D8D90", VA = "0x1864D9D90")]
	public OLJIJNCACBG(Behaviour ACJODAOHIHK, float IMMDMFJNIJP, [Optional] Action CINNANLBJHE, [Optional] MDGCLNFMPFL DJIGGENDPLP, [Optional] LOLLHLHJMBC DKFFGPLBMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x64EA1B0", Offset = "0x64E91B0", VA = "0x1864EA1B0", Slot = "9")]
	protected override bool EHLMKNGHHCG(Action NFDFJOBAEPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x64EA0A0", Offset = "0x64E90A0", VA = "0x1864EA0A0", Slot = "10")]
	protected override bool AOBOCDGMJCI(Action NFDFJOBAEPD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface KONEPPHLHBI
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OLKHHEFENIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action JNMMNDLBJEO;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OAMJECIAHDB(bool OFOIDDLLFEI = false);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OAMJECIAHDB(Action NFDFJOBAEPD, bool OFOIDDLLFEI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class IHICCMGPOKP : KONEPPHLHBI
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class ONNLMKEOICJ : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private DNLJHOFEIAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public IHICCMGPOKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
		[DebuggerHidden]
		public ONNLMKEOICJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x64EA3E0", Offset = "0x64E93E0", VA = "0x1864EA3E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x64EA4B0", Offset = "0x64E94B0", VA = "0x1864EA4B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour ACJODAOHIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action CINNANLBJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private FJLNLHOHLGA LFBCLHOPIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly MDGCLNFMPFL DJIGGENDPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly LOLLHLHJMBC DKFFGPLBMIN;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool OLKHHEFENIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xE59120", Offset = "0xE58120", VA = "0x180E59120", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action JNMMNDLBJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x64DE420", Offset = "0x64DD420", VA = "0x1864DE420", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x64DE7E0", Offset = "0x64DD7E0", VA = "0x1864DE7E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x64DE9D0", Offset = "0x64DD9D0", VA = "0x1864DE9D0")]
	protected IHICCMGPOKP(Behaviour ACJODAOHIHK, [Optional] Action CINNANLBJHE, [Optional] MDGCLNFMPFL DJIGGENDPLP, [Optional] LOLLHLHJMBC DKFFGPLBMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x64DE8E0", Offset = "0x64DD8E0", VA = "0x1864DE8E0", Slot = "7")]
	public bool OAMJECIAHDB(bool OFOIDDLLFEI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x64DE880", Offset = "0x64DD880", VA = "0x1864DE880", Slot = "8")]
	public bool OAMJECIAHDB(Action NFDFJOBAEPD, bool OFOIDDLLFEI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool EHLMKNGHHCG(Action NFDFJOBAEPD);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool AOBOCDGMJCI(Action NFDFJOBAEPD);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x64DE780", Offset = "0x64DD780", VA = "0x1864DE780")]
	protected void KIFMPBHBGNA(Action NFDFJOBAEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x64DE540", Offset = "0x64DD540", VA = "0x1864DE540")]
	protected LDFABEFGIKK IAAPMEFBLEH(float GNOBHKOCPOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x64DE4C0", Offset = "0x64DD4C0", VA = "0x1864DE4C0")]
	private void HNJDCMAGIPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x64DE940", Offset = "0x64DD940", VA = "0x1864DE940")]
	[IteratorStateMachine(typeof(ONNLMKEOICJ))]
	private IEnumerator<DNLJHOFEIAO> ONLHLDFJEOD(float GNOBHKOCPOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x64DE7A0", Offset = "0x64DD7A0", VA = "0x1864DE7A0")]
	[CompilerGenerated]
	private void KLFPLLPBEPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class MKONNJBJINN : IHICCMGPOKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float AODLIAMMLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int KACKMDMDDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float MKFOJMOECDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] NMHNKHPKPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int JNPBDEINKLH;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x64E3530", Offset = "0x64E2530", VA = "0x1864E3530")]
	public MKONNJBJINN(Behaviour ACJODAOHIHK, float GGEEPDAEOKC, int KACKMDMDDAI, [Optional] Action CINNANLBJHE, float MKFOJMOECDH = 0f, [Optional] MDGCLNFMPFL DJIGGENDPLP, [Optional] LOLLHLHJMBC DKFFGPLBMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "9")]
	protected override bool EHLMKNGHHCG(Action NFDFJOBAEPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x64E32B0", Offset = "0x64E22B0", VA = "0x1864E32B0", Slot = "10")]
	protected override bool AOBOCDGMJCI(Action NFDFJOBAEPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x64E34B0", Offset = "0x64E24B0", VA = "0x1864E34B0")]
	private void DCFGGDALGPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class EKLFMBEGFNJ : IHICCMGPOKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float IMMDMFJNIJP;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x64D9D90", Offset = "0x64D8D90", VA = "0x1864D9D90")]
	public EKLFMBEGFNJ(Behaviour ACJODAOHIHK, float IMMDMFJNIJP, [Optional] Action CINNANLBJHE, [Optional] MDGCLNFMPFL DJIGGENDPLP, [Optional] LOLLHLHJMBC DKFFGPLBMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "9")]
	protected override bool EHLMKNGHHCG(Action NFDFJOBAEPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x64D9D50", Offset = "0x64D8D50", VA = "0x1864D9D50", Slot = "10")]
	protected override bool AOBOCDGMJCI(Action NFDFJOBAEPD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class MPPJBPNLOHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class OLKLGBOAKHO : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private DNLJHOFEIAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
		[DebuggerHidden]
		public OLKLGBOAKHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x64D9C90", Offset = "0x64D8C90", VA = "0x1864D9C90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x64EA2C0", Offset = "0x64E92C0", VA = "0x1864EA2C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GPGMPFEJBGM ACOGDIGFOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private EFMLGEBBGBC ACJODAOHIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> CNKOGDBJNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private EEDKBGMEMHA HHMCMICFMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float COPFACLGJHL;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x64E3C60", Offset = "0x64E2C60", VA = "0x1864E3C60")]
	public MPPJBPNLOHF(EFMLGEBBGBC ACJODAOHIHK, float BKPPNADBLPD, Action<float> BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x64E3AC0", Offset = "0x64E2AC0", VA = "0x1864E3AC0")]
	private void KMNPOJEDOJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x64E3960", Offset = "0x64E2960", VA = "0x1864E3960")]
	private void HHBMEEFNGFK(string KHEFJOIGNAL, Action OLBBNLONOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x64E36D0", Offset = "0x64E26D0", VA = "0x1864E36D0")]
	[IteratorStateMachine(typeof(OLKLGBOAKHO))]
	private IEnumerator<DNLJHOFEIAO> BFNBADBHLKI(Action OLBBNLONOMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x64E3900", Offset = "0x64E2900", VA = "0x1864E3900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x64E3750", Offset = "0x64E2750", VA = "0x1864E3750")]
	[CompilerGenerated]
	private void BLEKNAFFEKK(string BALOPCFMODO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class IBEDNDGMBJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class EEGFBCGBJNG : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private DNLJHOFEIAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
		[DebuggerHidden]
		public EEGFBCGBJNG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x64D9C90", Offset = "0x64D8C90", VA = "0x1864D9C90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x64D9D00", Offset = "0x64D8D00", VA = "0x1864D9D00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private GPGMPFEJBGM ACOGDIGFOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour PDBBGMACAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action BPPBEEPMPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> CNKOGDBJNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private EEDKBGMEMHA HHMCMICFMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float COPFACLGJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool GFLJNKOMNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly MDGCLNFMPFL DJIGGENDPLP;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x64DD690", Offset = "0x64DC690", VA = "0x1864DD690")]
	public IBEDNDGMBJB(MonoBehaviour PDBBGMACAPG, Action BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL, [Optional] MDGCLNFMPFL DJIGGENDPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x64DD450", Offset = "0x64DC450", VA = "0x1864DD450")]
	public IBEDNDGMBJB(MonoBehaviour PDBBGMACAPG, Action<float> BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL, [Optional] MDGCLNFMPFL DJIGGENDPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x64DD880", Offset = "0x64DC880", VA = "0x1864DD880")]
	public IBEDNDGMBJB(MonoBehaviour PDBBGMACAPG, float BKPPNADBLPD, Action<float> BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL, bool GFLJNKOMNMK = true, [Optional] MDGCLNFMPFL DJIGGENDPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1850BB0", Offset = "0x184FBB0", VA = "0x181850BB0")]
	private IBEDNDGMBJB(MDGCLNFMPFL DJIGGENDPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x64DC8C0", Offset = "0x64DB8C0", VA = "0x1864DC8C0")]
	internal static IBEDNDGMBJB CNAKGBKPJEN(MonoBehaviour PDBBGMACAPG, float BKPPNADBLPD, Action<float> BPPBEEPMPDF, EEDKBGMEMHA HHMCMICFMDL, bool GFLJNKOMNMK = true, [Optional] MDGCLNFMPFL DJIGGENDPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x64DCC90", Offset = "0x64DBC90", VA = "0x1864DCC90")]
	private void GPHGPMINAOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x64DCAE0", Offset = "0x64DBAE0", VA = "0x1864DCAE0")]
	private void FKGILBHMFPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x64DD0F0", Offset = "0x64DC0F0", VA = "0x1864DD0F0")]
	private void KMNPOJEDOJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x64DCF30", Offset = "0x64DBF30", VA = "0x1864DCF30")]
	private void IBGAHOJPDJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x64DCE00", Offset = "0x64DBE00", VA = "0x1864DCE00")]
	private void HHBMEEFNGFK(string KHEFJOIGNAL, Action OLBBNLONOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x64DC840", Offset = "0x64DB840", VA = "0x1864DC840")]
	[IteratorStateMachine(typeof(EEGFBCGBJNG))]
	private IEnumerator<DNLJHOFEIAO> BFNBADBHLKI(Action OLBBNLONOMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x64DCA80", Offset = "0x64DBA80", VA = "0x1864DCA80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x64DD2A0", Offset = "0x64DC2A0", VA = "0x1864DD2A0")]
	[CompilerGenerated]
	private void LHACLECMJFC(string BALOPCFMODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x64DD3C0", Offset = "0x64DC3C0", VA = "0x1864DD3C0")]
	[CompilerGenerated]
	private void MOHLIEJBPJH(string BALOPCFMODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x64DC9F0", Offset = "0x64DB9F0", VA = "0x1864DC9F0")]
	[CompilerGenerated]
	private void COOOAHOMBIJ(string BALOPCFMODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x64DD330", Offset = "0x64DC330", VA = "0x1864DD330")]
	[CompilerGenerated]
	private void MILFGHIOMDD(string BALOPCFMODO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum OODIEHODIFC : byte
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
internal sealed class IAJAMEJDGKK : LOLLHLHJMBC
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float ALGLOFAENFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x64DC790", Offset = "0x64DB790", VA = "0x1864DC790", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float MDEEKDBOBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x64DC7A0", Offset = "0x64DB7A0", VA = "0x1864DC7A0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double BCEKFKDDLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x64DC820", Offset = "0x64DB820", VA = "0x1864DC820", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x64DC7B0", Offset = "0x64DB7B0", VA = "0x1864DC7B0")]
	[PKDJMILODMH(OMIAJJHDDGO.None)]
	private static void JNGPOGLGKKE(EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	[Preserve]
	internal IAJAMEJDGKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface BOOCFMNGBOF
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEBABOFJAAF(string JNMEJDHMADI);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBAFEBPCONI();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface AAGEPGGFDFH
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string GMOLFEBHJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool JFINHHLMGII
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JLCHMIBMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class KEGPNAJGENB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public OEJIFFPNMPB CGDIPNALHDD;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int KLNGLNIFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x76F180", Offset = "0x76E180", VA = "0x18076F180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x77AFF0", Offset = "0x779FF0", VA = "0x18077AFF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x64E1750", Offset = "0x64E0750", VA = "0x1864E1750")]
	public static DNLJHOFEIAO DLJDBECGDOC(IEnumerator<DNLJHOFEIAO> FEILEGJBIKI, JJPDAMMAIDJ CAMMLDAMHLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x64E1690", Offset = "0x64E0690", VA = "0x1864E1690")]
	public DNLJHOFEIAO DLJDBECGDOC(JJPDAMMAIDJ[] OJPMPKFHBFE, IEnumerator<DNLJHOFEIAO>[] PCPJBCOFCJJ, DNLJHOFEIAO[] KGGFKLJGDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x64E19F0", Offset = "0x64E09F0", VA = "0x1864E19F0")]
	public void MLNCOCCPJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x64E18B0", Offset = "0x64E08B0", VA = "0x1864E18B0")]
	public void DLNHJDOHAGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x64E1A20", Offset = "0x64E0A20", VA = "0x1864E1A20")]
	public void MGFNELMOCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x64E19F0", Offset = "0x64E09F0", VA = "0x1864E19F0")]
	public void ICBCAGAGNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public KEGPNAJGENB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class OEJIFFPNMPB
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct AECDMEDAECH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public KEGPNAJGENB NHDPGBJAEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public EFMLGEBBGBC JEBBNDMGCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public JJPDAMMAIDJ DKNMKJPEKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<DNLJHOFEIAO> KAJDEEPGBAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public DNLJHOFEIAO LEGBOEBOOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public OODIEHODIFC MKKEOMADGNC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct AOONAKJKDBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public EEDKBGMEMHA JEDOJNFJBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<AECDMEDAECH> FNLBDIMGCBG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class FJPAKBJDLFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public JJPDAMMAIDJ promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public OEJIFFPNMPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public EFMLGEBBGBC context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public KEGPNAJGENB routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public OODIEHODIFC coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public DNLJHOFEIAO currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<DNLJHOFEIAO> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public FJPAKBJDLFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x64DAA80", Offset = "0x64D9A80", VA = "0x1864DAA80")]
		internal void JPJLACJGLGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class OPIPILEFDFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public KEGPNAJGENB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public OEJIFFPNMPB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public OPIPILEFDFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x64EA500", Offset = "0x64E9500", VA = "0x1864EA500")]
		internal void BLCAJOEEFPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class IBGFMDEJBNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public KEGPNAJGENB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public OEJIFFPNMPB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public IBGFMDEJBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x64DDAD0", Offset = "0x64DCAD0", VA = "0x1864DDAD0")]
		internal void PGFEMJMFOOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class CJMEMAACCBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public KEGPNAJGENB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public OEJIFFPNMPB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public CJMEMAACCBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x64D5560", Offset = "0x64D4560", VA = "0x1864D5560")]
		internal void MCCLCPNPCLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const OODIEHODIFC PCHOFBFHMIA = OODIEHODIFC.Cancelled | OODIEHODIFC.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly EEDKBGMEMHA HHMCMICFMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] DBINGALENHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<OODIEHODIFC> MDKDJABNEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> DLCONNGCJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> FKIHNMKAAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> KAFMEDKBGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> KHPJOFAPPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> NLOMBGFCOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> GOPODDOBECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private KEGPNAJGENB[] DEFPCKOIGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private JJPDAMMAIDJ[] OJPMPKFHBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private EFMLGEBBGBC[] BFKNPNNJLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<DNLJHOFEIAO>[] PJJNLIGFOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private DNLJHOFEIAO[] JIEHIPGNAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int BLNCKDPLGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int IKHECAIEEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int ADIBGMBDGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float HIHFDEFJLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private LDHBOBDONPD DCCDGKMMPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle FEBOKPBPBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<KEGPNAJGENB> ANODPCJLFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool BOKCLOBCKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> KOJBBOJOBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> APPDKJFNGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool HAKBACNHFDK;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public AOONAKJKDBB[] NGDLCBLDBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x90A3A0", Offset = "0x9093A0", VA = "0x18090A3A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x64E79B0", Offset = "0x64E69B0", VA = "0x1864E79B0")]
	private static int BHOIMOPAOPO(EEDKBGMEMHA HHMCMICFMDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x64E90C0", Offset = "0x64E80C0", VA = "0x1864E90C0")]
	public OEJIFFPNMPB(EEDKBGMEMHA HHMCMICFMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x64E8EE0", Offset = "0x64E7EE0", VA = "0x1864E8EE0")]
	private void OKBLICEIGFL(int JGAELNBBPJE, int GJIOEFAFGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x64E8C60", Offset = "0x64E7C60", VA = "0x1864E8C60")]
	public void MKNDKMCMAHI(EFMLGEBBGBC ACJODAOHIHK, DNLJHOFEIAO AFJKDPDAJKH, IEnumerator<DNLJHOFEIAO> FEILEGJBIKI, JJPDAMMAIDJ CAMMLDAMHLP, [Optional] KEGPNAJGENB BHCKMADKHJF, OODIEHODIFC LIEHLFODGKA = OODIEHODIFC.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x64E8290", Offset = "0x64E7290", VA = "0x1864E8290")]
	public void HIINCELAFFK(IEnumerable<AECDMEDAECH> OPNNOCNIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x64E74E0", Offset = "0x64E64E0", VA = "0x1864E74E0")]
	private AECDMEDAECH BEGKNELKMFG(int OKIJNABPLKJ)
	{
		return default(AECDMEDAECH);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x64E7DF0", Offset = "0x64E6DF0", VA = "0x1864E7DF0")]
	private void GJPBMAMEGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2630790", Offset = "0x262F790", VA = "0x182630790")]
	private static void NBABKAEOJGJ<T>(int OKIJNABPLKJ, T[] KHOGFGBGEEC, int LHAIIFMNPNK, [Optional] T FDJBMBOKCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x26307E0", Offset = "0x262F7E0", VA = "0x1826307E0")]
	private static void NBABKAEOJGJ<T>(int OKIJNABPLKJ, NativeArray<T> KHOGFGBGEEC, int LHAIIFMNPNK, [Optional] T FDJBMBOKCMH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x64E88C0", Offset = "0x64E78C0", VA = "0x1864E88C0")]
	private void LNOCGDPMEKC(IEnumerable<AECDMEDAECH> OPNNOCNIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x64E8600", Offset = "0x64E7600", VA = "0x1864E8600")]
	private void IIJOKJBFKJD(AECDMEDAECH LMMAOBAJMPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x64E79E0", Offset = "0x64E69E0", VA = "0x1864E79E0")]
	private COIKDNCMFJO DMGOAHOMGMD(int HOLIBOMCCNC)
	{
		return default(COIKDNCMFJO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x64E86C0", Offset = "0x64E76C0", VA = "0x1864E86C0")]
	public void IPMPELBPCOI(float NHFJMJEEFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x64E7D70", Offset = "0x64E6D70", VA = "0x1864E7D70")]
	private void FLILNOFJDKB(Action HMDDIJJDAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x64E6D60", Offset = "0x64E5D60", VA = "0x1864E6D60")]
	private void AAMJLDIJLPD(Action HMDDIJJDAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x64E6DE0", Offset = "0x64E5DE0", VA = "0x1864E6DE0")]
	public void ACDACCKMIPL(float NHFJMJEEFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x64E8DE0", Offset = "0x64E7DE0", VA = "0x1864E8DE0")]
	public void NIDAGEDDLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x64E84D0", Offset = "0x64E74D0", VA = "0x1864E84D0")]
	public void ICBCAGAGNJK(KEGPNAJGENB BHNNFNLMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x64E8160", Offset = "0x64E7160", VA = "0x1864E8160")]
	public void HFKJLCILKCL(KEGPNAJGENB BHNNFNLMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x64E7C40", Offset = "0x64E6C40", VA = "0x1864E7C40")]
	public void FGLCJHKCHHN(KEGPNAJGENB BHNNFNLMLCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class JJNNODACAEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly JJNNODACAEE FKNBKDPNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action CENHFKKCLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool EDDFAKMICOP;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
	public JJNNODACAEE(Action CENHFKKCLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x64DFDC0", Offset = "0x64DEDC0", VA = "0x1864DFDC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface AMLIHAOFLJM<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T INAJMIAKCCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable CIIBKNPKELM(UnityEngine.Object ACJODAOHIHK, Action<T> EJCAPNPKFCD);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface MJHPIIHMOMG<T> : AMLIHAOFLJM<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T INAJMIAKCCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class FLGHAIAIPGN<T> : MJHPIIHMOMG<T>, AMLIHAOFLJM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class HLMOODOPKBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public FLGHAIAIPGN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public OOMKCHDLDPO<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public HLMOODOPKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3651330", Offset = "0x3650330", VA = "0x183651330")]
		internal void LNBKJFLENNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject OJANMGNPCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<OOMKCHDLDPO<UnityEngine.Object, Action<T>>> IECAACMKPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T PBNLKAHMMAB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T INAJMIAKCCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x81EBB0", Offset = "0x81DBB0", VA = "0x18081EBB0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3469380", Offset = "0x3468380", VA = "0x183469380", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3469480", Offset = "0x3468480", VA = "0x183469480")]
	private static bool LJKCKCFBJAP(T HMDDIJJDAIK, T NDOJJCKFJID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3469C90", Offset = "0x3468C90", VA = "0x183469C90")]
	public FLGHAIAIPGN(T CDANOMGMNNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x34691F0", Offset = "0x34681F0", VA = "0x1834691F0", Slot = "6")]
	public IDisposable CIIBKNPKELM(UnityEngine.Object ACJODAOHIHK, Action<T> EJCAPNPKFCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3469580", Offset = "0x3468580", VA = "0x183469580")]
	private void NPFIEGPIMLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class LMLGBHOAKJC : HHFCHOIBNNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly MDGCLNFMPFL DJIGGENDPLP;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x64E2980", Offset = "0x64E1980", VA = "0x1864E2980")]
	[PKDJMILODMH(OMIAJJHDDGO.None)]
	private static void JNGPOGLGKKE(EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
	[Preserve]
	internal LMLGBHOAKJC([KHIPNIHHNOH(null)] MDGCLNFMPFL DJIGGENDPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x64E28D0", Offset = "0x64E18D0", VA = "0x1864E28D0", Slot = "4")]
	public IDisposable GNBIDLNCMBO(float BKPPNADBLPD, Action<float> CAEGDBPOJIB, bool GFLJNKOMNMK = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class INBHPONFJFM : NKBEBCFMLJJ, MDGCLNFMPFL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private OEJIFFPNMPB[] PIFGOFPBJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private BOOCFMNGBOF AMPLCCGIIIN;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x64DF3F0", Offset = "0x64DE3F0", VA = "0x1864DF3F0")]
	[PKDJMILODMH(OMIAJJHDDGO.None)]
	private static void JNGPOGLGKKE(EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x64DF890", Offset = "0x64DE890", VA = "0x1864DF890")]
	[Preserve]
	public INBHPONFJFM([KHIPNIHHNOH(null)] PFDKAPMDOON BHIHCKBHIEC, [KHIPNIHHNOH(null)] LOLLHLHJMBC DKFFGPLBMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x64DF150", Offset = "0x64DE150", VA = "0x1864DF150", Slot = "17")]
	public override GPGMPFEJBGM FDDFNLFAOBI(EFMLGEBBGBC ACJODAOHIHK, IEnumerator<DNLJHOFEIAO> DIHEBPGGGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x64DF580", Offset = "0x64DE580", VA = "0x1864DF580", Slot = "18")]
	public override void OFPJBAGGFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x64DEF20", Offset = "0x64DDF20", VA = "0x1864DEF20", Slot = "20")]
	public override void EOLKDLHFENC(EEDKBGMEMHA HHMCMICFMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x64DF280", Offset = "0x64DE280", VA = "0x1864DF280", Slot = "19")]
	protected override void HOEJNKLEAPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x64DEE90", Offset = "0x64DDE90", VA = "0x1864DEE90")]
	private OEJIFFPNMPB BHPCEOGAHPG(EEDKBGMEMHA CFGJPNBLNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x64DEC60", Offset = "0x64DDC60", VA = "0x1864DEC60", Slot = "21")]
	internal override FJOIKBEFGOF APNLNHNNCBN(IEnumerator<DNLJHOFEIAO> DIHEBPGGGBA, Behaviour ACJODAOHIHK, JJPDAMMAIDJ CAMMLDAMHLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x64DF810", Offset = "0x64DE810", VA = "0x1864DF810", Slot = "22")]
	internal override NBHGDGNDOFF ONLJNEIGOIJ(EEDKBGMEMHA LACKAMJJHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x64DF460", Offset = "0x64DE460", VA = "0x1864DF460")]
	private void LLOLBEFFAOH(OEJIFFPNMPB PGFCEPPJOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x64DEEC0", Offset = "0x64DDEC0", VA = "0x1864DEEC0", Slot = "23")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct LDHBOBDONPD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float COEIBLOOOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int LALFJANEOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> PAIDODLPABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> NJFEKCIPNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> DMLFAGGPEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<OODIEHODIFC> NNCENIIHFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> GJGJAFKJHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> KHPJOFAPPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> FKIHNMKAAIC;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x64E20A0", Offset = "0x64E10A0", VA = "0x1864E20A0")]
	public static LDHBOBDONPD BJANKEDJCNP(int JCOEFOCGAKG, float NHFJMJEEFNF, NativeArray<OODIEHODIFC> PHMDHAPPJPN, NativeArray<float> DAKAKNMJAPK, NativeArray<int> KINEGGLBACB, NativeArray<int> PFMHHDGLPLE, NativeArray<int> ELKOAIKODIE, NativeArray<int> NJFEKCIPNAE, NativeArray<int> DMLFAGGPEAK)
	{
		return default(LDHBOBDONPD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x64E2140", Offset = "0x64E1140", VA = "0x1864E2140", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x64E2100", Offset = "0x64E1100", VA = "0x1864E2100")]
	private bool DEJIFBHMBBM(int NFJIPMHILEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x64E2220", Offset = "0x64E1220", VA = "0x1864E2220")]
	private void FBBOLGBDMCN(NativeArray<int> HILNKJGGIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x64E2000", Offset = "0x64E1000", VA = "0x1864E2000")]
	private int BHHOFFAJKEB(int HMECBLHHMNE, int OLOKJILALIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x64E1CF0", Offset = "0x64E0CF0", VA = "0x1864E1CF0")]
	private void BDEBBOEJBEL(NativeArray<int> HILNKJGGIFO, int KEDDCBECFHK, int MGOBBEHMAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x64E1DC0", Offset = "0x64E0DC0", VA = "0x1864E1DC0")]
	private void BFPOPFCGJMN(NativeArray<int> HILNKJGGIFO, int AKNGKBNCGEN, int KECDEDNJALC, int BMMAGLFEMFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class NKBEBCFMLJJ : MDGCLNFMPFL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly PFDKAPMDOON BHIHCKBHIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly LOLLHLHJMBC DKFFGPLBMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private NBHGDGNDOFF[] EEFDHOHCGHN;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static MDGCLNFMPFL NKFKDADGOPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x64E66F0", Offset = "0x64E56F0", VA = "0x1864E66F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool NPPHNPBCGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x78B130", Offset = "0x78A130", VA = "0x18078B130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public EEDKBGMEMHA FIJMPAJALLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x76F180", Offset = "0x76E180", VA = "0x18076F180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(EEDKBGMEMHA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x77AFF0", Offset = "0x779FF0", VA = "0x18077AFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public LOLLHLHJMBC BJNHMLNDGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public DNLJHOFEIAO GHAJHPLEEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x76F1D0", Offset = "0x76E1D0", VA = "0x18076F1D0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public DNLJHOFEIAO EAMGNBAKENI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x774F20", Offset = "0x773F20", VA = "0x180774F20", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x64E5F30", Offset = "0x64E4F30", VA = "0x1864E5F30")]
	public static GPGMPFEJBGM LCKJFDKICNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x64E6740", Offset = "0x64E5740", VA = "0x1864E6740")]
	[Preserve]
	protected NKBEBCFMLJJ([KHIPNIHHNOH(null)] PFDKAPMDOON BHIHCKBHIEC, [KHIPNIHHNOH(null)] LOLLHLHJMBC DKFFGPLBMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x64E6070", Offset = "0x64E5070", VA = "0x1864E6070", Slot = "6")]
	public GPGMPFEJBGM LODICMNCPHB(IEnumerator<DNLJHOFEIAO> DIHEBPGGGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x64E6080", Offset = "0x64E5080", VA = "0x1864E6080", Slot = "7")]
	public GPGMPFEJBGM LODICMNCPHB(Behaviour ACJODAOHIHK, IEnumerator<DNLJHOFEIAO> DIHEBPGGGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract GPGMPFEJBGM FDDFNLFAOBI(EFMLGEBBGBC ACJODAOHIHK, IEnumerator<DNLJHOFEIAO> DIHEBPGGGBA);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x64E64F0", Offset = "0x64E54F0", VA = "0x1864E64F0", Slot = "18")]
	public virtual void OFPJBAGGFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x64E5C90", Offset = "0x64E4C90", VA = "0x1864E5C90", Slot = "9")]
	public void HNOGPGDLFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x64E5ED0", Offset = "0x64E4ED0", VA = "0x1864E5ED0", Slot = "19")]
	protected virtual void HOEJNKLEAPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x64E5800", Offset = "0x64E4800", VA = "0x1864E5800")]
	private void BNHDJIDPKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x64E5F10", Offset = "0x64E4F10", VA = "0x1864E5F10")]
	private void KPMNPGNDMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x64E5C70", Offset = "0x64E4C70", VA = "0x1864E5C70")]
	private void FLBMAAPGJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x64E5FC0", Offset = "0x64E4FC0", VA = "0x1864E5FC0")]
	private void LGDGBDMKDKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x64E5EF0", Offset = "0x64E4EF0", VA = "0x1864E5EF0")]
	private void KBHJNKBCOPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x64E64D0", Offset = "0x64E54D0", VA = "0x1864E64D0")]
	private void OAECJCLDDAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x64E62E0", Offset = "0x64E52E0", VA = "0x1864E62E0")]
	private void NCFJCNLHFGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x64E5BE0", Offset = "0x64E4BE0", VA = "0x1864E5BE0", Slot = "20")]
	public virtual void EOLKDLHFENC(EEDKBGMEMHA HHMCMICFMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x64E6300", Offset = "0x64E5300", VA = "0x1864E6300")]
	private void NDIDCFHHMOI(NBHGDGNDOFF PGFCEPPJOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1BE41C0", Offset = "0x1BE31C0", VA = "0x181BE41C0")]
	private NBHGDGNDOFF IMNPIDIDOHO(EEDKBGMEMHA CFGJPNBLNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract FJOIKBEFGOF APNLNHNNCBN(IEnumerator<DNLJHOFEIAO> DIHEBPGGGBA, Behaviour PDBBGMACAPG, JJPDAMMAIDJ ALBGDFNHLMM);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract NBHGDGNDOFF ONLJNEIGOIJ(EEDKBGMEMHA HHMCMICFMDL);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x64E5820", Offset = "0x64E4820", VA = "0x1864E5820", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x64E6690", Offset = "0x64E5690", VA = "0x1864E6690", Slot = "13")]
	public DNLJHOFEIAO ONMMCCLPGDB(EEDKBGMEMHA LACKAMJJHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x64E5FE0", Offset = "0x64E4FE0", VA = "0x1864E5FE0", Slot = "14")]
	public DNLJHOFEIAO LIKHBLFNKOG(float JPCFJENKEPD, EEDKBGMEMHA LACKAMJJHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x64E6280", Offset = "0x64E5280", VA = "0x1864E6280", Slot = "15")]
	public DNLJHOFEIAO MKMLKEIKAMN(Func<bool> FJNLKDBBOPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class FJOIKBEFGOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly JJPDAMMAIDJ CAMMLDAMHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly AAGEPGGFDFH ACJODAOHIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool GFCFDCBKCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string JNMEJDHMADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private StackTrace ODKKECDGOHF;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerator<DNLJHOFEIAO> KAJDEEPGBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x76F1B0", Offset = "0x76E1B0", VA = "0x18076F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public DNLJHOFEIAO LEGBOEBOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x76F1A0", Offset = "0x76E1A0", VA = "0x18076F1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool AJPNCMNIBDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x64DA710", Offset = "0x64D9710", VA = "0x1864DA710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool DJFLPBAPPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7F9460", Offset = "0x7F8460", VA = "0x1807F9460")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x89AC10", Offset = "0x899C10", VA = "0x18089AC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string GMOLFEBHJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x64DA250", Offset = "0x64D9250", VA = "0x1864DA250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float MOFGEMJLEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xFCF730", Offset = "0xFCE730", VA = "0x180FCF730")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5490330", Offset = "0x548F330", VA = "0x185490330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x64DA8C0", Offset = "0x64D98C0", VA = "0x1864DA8C0")]
	public FJOIKBEFGOF(IEnumerator<DNLJHOFEIAO> FEILEGJBIKI, AAGEPGGFDFH ACJODAOHIHK, JJPDAMMAIDJ CAMMLDAMHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x64DA400", Offset = "0x64D9400", VA = "0x1864DA400")]
	public DNLJHOFEIAO DLJDBECGDOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x64DA1E0", Offset = "0x64D91E0", VA = "0x1864DA1E0")]
	public bool BBDOHBHDDBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x64DA790", Offset = "0x64D9790", VA = "0x1864DA790")]
	public void ICBCAGAGNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x64DA7E0", Offset = "0x64D97E0", VA = "0x1864DA7E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x81FF70", Offset = "0x81EF70", VA = "0x18081FF70")]
	[CompilerGenerated]
	private void CMJEJPLCOAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class JJPDAMMAIDJ : NPEAGLMPEGI, GPGMPFEJBGM, FJLNLHOHLGA, LDFABEFGIKK, IEnumerator, DNLJHOFEIAO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private EEDKBGMEMHA PLLAADLENFK;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private EEDKBGMEMHA OKNHAIAMFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xD70D40", Offset = "0xD6FD40", VA = "0x180D70D40", Slot = "23")]
		get
		{
			return default(EEDKBGMEMHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public EEDKBGMEMHA CGDIPNALHDD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x1266CC0", Offset = "0x1265CC0", VA = "0x181266CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private float GGANMLNGLIC
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FE0", Offset = "0x7C4FE0", VA = "0x1807C5FE0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool HBAOLMKPIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x64DFF20", Offset = "0x64DEF20", VA = "0x1864DFF20", Slot = "24")]
	private bool KMCEHGNNDIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x64DFF10", Offset = "0x64DEF10", VA = "0x1864DFF10", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x64DFF40", Offset = "0x64DEF40", VA = "0x1864DFF40")]
	public JJPDAMMAIDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum COIKDNCMFJO : byte
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
internal sealed class NBHGDGNDOFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum PHCMFIECEGC
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct NDCFDEHHBGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public EEDKBGMEMHA JEDOJNFJBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public PHCMFIECEGC EBBOLAGPOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public List<FJOIKBEFGOF> JGEAIJCBEJO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly PHCMFIECEGC[] JACOGIAEKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly EEDKBGMEMHA HHMCMICFMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private bool ILIKPMEBLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly FJOIKBEFGOF[] LPJMFPADKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<FJOIKBEFGOF> CKGPHGNKJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> EAFMEJNEAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<FJOIKBEFGOF> FEPIAMIIJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<int> NGNAOMKBPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly BOOCFMNGBOF EDBAKIMGNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private bool HAKBACNHFDK;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public NDCFDEHHBGJ[,] HMNKJEKNEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x774F20", Offset = "0x773F20", VA = "0x180774F20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x64E5360", Offset = "0x64E4360", VA = "0x1864E5360")]
	public NBHGDGNDOFF(EEDKBGMEMHA LACKAMJJHMC, BOOCFMNGBOF EDBAKIMGNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x64E4580", Offset = "0x64E3580", VA = "0x1864E4580")]
	public void EBBJEAEMNGI(FJOIKBEFGOF FEILEGJBIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x64E4A70", Offset = "0x64E3A70", VA = "0x1864E4A70")]
	public void HFCDPDJJCEI(IList<FJOIKBEFGOF> PCPJBCOFCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x64E3E40", Offset = "0x64E2E40", VA = "0x1864E3E40")]
	public void CGILGOCGDCC(IList<FJOIKBEFGOF> PCPJBCOFCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x64E4980", Offset = "0x64E3980", VA = "0x1864E4980")]
	private void HDBINHEOOMC(FJOIKBEFGOF FEILEGJBIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x64E4150", Offset = "0x64E3150", VA = "0x1864E4150")]
	private void CMOLGPFEPFJ(IList<FJOIKBEFGOF> PCPJBCOFCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x64E42E0", Offset = "0x64E32E0", VA = "0x1864E42E0")]
	private COIKDNCMFJO COAOFGOLKGK(FJOIKBEFGOF FEILEGJBIKI)
	{
		return default(COIKDNCMFJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x64E4F70", Offset = "0x64E3F70", VA = "0x1864E4F70")]
	public void HOEJNKLEAPP(float NHFJMJEEFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x64E4D80", Offset = "0x64E3D80", VA = "0x1864E4D80")]
	public void HNOGPGDLFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x64E4680", Offset = "0x64E3680", VA = "0x1864E4680")]
	private void EFNJKODEAKG(List<FJOIKBEFGOF> PCPJBCOFCJJ, Stack<int> OHHCJNENOAN, bool ODEJDHNMEJB, float CFOCCAJDPJL = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x64E4460", Offset = "0x64E3460", VA = "0x1864E4460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x64E50E0", Offset = "0x64E40E0", VA = "0x1864E50E0")]
	private void JPDHNODAFNE(List<FJOIKBEFGOF> PCPJBCOFCJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class ABGMEAMHFJO : BOOCFMNGBOF
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "4")]
	public void EEBABOFJAAF(string JNMEJDHMADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
	public void DBAFEBPCONI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public ABGMEAMHFJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class GOIAKJOACMP : AAGEPGGFDFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Behaviour PDBBGMACAPG;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string GMOLFEBHJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x64DBA30", Offset = "0x64DAA30", VA = "0x1864DBA30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool JFINHHLMGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x64DBAB0", Offset = "0x64DAAB0", VA = "0x1864DBAB0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool JLCHMIBMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x64DBA10", Offset = "0x64DAA10", VA = "0x1864DBA10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
	public GOIAKJOACMP(Behaviour PDBBGMACAPG)
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

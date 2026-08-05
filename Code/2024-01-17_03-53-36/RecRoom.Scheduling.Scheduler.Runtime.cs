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
public class FJCGPHOMIIB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority MNKLOFFEBLO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66E20B0", Offset = "0x66E0EB0", VA = "0x1866E20B0")]
	public FJCGPHOMIIB(ThreadPriority DKFGBIFLOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66E20A0", Offset = "0x66E0EA0", VA = "0x1866E20A0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> COOJFMKEPLA(List<PlayerLoopSystem> POHLIFJCECD, int BBOBLAMEHDL);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct PNOOEAKKBKA
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct CEDJNBNLMGG
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static AHOMABILGKI FKHOPGGPIFC;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x66DA4E0", Offset = "0x66D92E0", VA = "0x1866DA4E0")]
				public static PlayerLoopSystem FKEKCPHLBAD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct GMAHHJKLFAL
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static AHOMABILGKI MMEPOOLMFHB;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x66E4070", Offset = "0x66E2E70", VA = "0x1866E4070")]
				public static PlayerLoopSystem FKEKCPHLBAD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct NBBECAEANIL
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static AHOMABILGKI MMOGBEGAFDL;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x66EB740", Offset = "0x66EA540", VA = "0x1866EB740")]
				public static PlayerLoopSystem FKEKCPHLBAD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct CLCOIJEHGLM
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static AHOMABILGKI GAKFIMBPHGK;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static AHOMABILGKI GFJCNCMPAPD;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static AHOMABILGKI LOCNPPFNNKI;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static AHOMABILGKI GILAPILFIFL;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x66DB500", Offset = "0x66DA300", VA = "0x1866DB500")]
				public static PlayerLoopSystem FKEKCPHLBAD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct MPDLGCANAJN
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static AHOMABILGKI POLGAAEGDPL;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x66EB540", Offset = "0x66EA340", VA = "0x1866EB540")]
				public static PlayerLoopSystem FKEKCPHLBAD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct HPHCLGBDJEB
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static AHOMABILGKI GAKFIMBPHGK;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static AHOMABILGKI GFJCNCMPAPD;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static AHOMABILGKI LOCNPPFNNKI;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static AHOMABILGKI GILAPILFIFL;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x66E4990", Offset = "0x66E3790", VA = "0x1866E4990")]
				public static PlayerLoopSystem FKEKCPHLBAD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct NHEENMLKJDM
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static AHOMABILGKI BEPMNONMKHH;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x66EB940", Offset = "0x66EA740", VA = "0x1866EB940")]
				public static PlayerLoopSystem FKEKCPHLBAD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct NLBAMJBCMAG
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static AHOMABILGKI JBKDLCKPJMA;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x66EBD40", Offset = "0x66EAB40", VA = "0x1866EBD40")]
				public static PlayerLoopSystem FKEKCPHLBAD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct CHMJGJFILMA
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static AHOMABILGKI HLFMNIJIIHA;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x66DA9B0", Offset = "0x66D97B0", VA = "0x1866DA9B0")]
				public static PlayerLoopSystem FKEKCPHLBAD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct LDAMHLGBKMN
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static AHOMABILGKI AKAMECGDJGL;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x66EAF70", Offset = "0x66E9D70", VA = "0x1866EAF70")]
				public static PlayerLoopSystem FKEKCPHLBAD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct CMINAKJPOAA
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static AHOMABILGKI BMLADLJCOFI;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x66DB7F0", Offset = "0x66DA5F0", VA = "0x1866DB7F0")]
				public static PlayerLoopSystem FKEKCPHLBAD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct NIJJBPJCGCC
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static AHOMABILGKI LGAPJPGIKOB;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x66EBB40", Offset = "0x66EA940", VA = "0x1866EBB40")]
				public static PlayerLoopSystem FKEKCPHLBAD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum GJGLCJIHAPE : byte
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
			public struct MHPOBBLIAGF
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class PALHOJIMBKB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public GJGLCJIHAPE updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
					public PALHOJIMBKB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x66F0E70", Offset = "0x66EFC70", VA = "0x1866F0E70")]
					internal void GHNGIIGFDFF()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static JBCIPMEOJLB<GJGLCJIHAPE> BADHFHHDCCC;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x66EB370", Offset = "0x66EA170", VA = "0x1866EB370")]
				public static PlayerLoopSystem FKEKCPHLBAD(GJGLCJIHAPE MPGDNCBLMDN)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct LAAMNKHBPGB
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class ILOOKFONEFC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public DLJHEAODFDP.JMIABIEAJPC key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
					public ILOOKFONEFC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x66E4E10", Offset = "0x66E3C10", VA = "0x1866E4E10")]
					internal void ILBGCNAENHL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable BCMKAHIELON;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x66EABC0", Offset = "0x66E99C0", VA = "0x1866EABC0")]
				public static PlayerLoopSystem CGJNAACGAOC(DLJHEAODFDP.JMIABIEAJPC IDGIKKEFDCG)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct JHNAJEPIJCC
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class FLLIOLEKKGE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public DLJHEAODFDP.JMIABIEAJPC key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
					public FLLIOLEKKGE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x66E2210", Offset = "0x66E1010", VA = "0x1866E2210")]
					internal void ILBGCNAENHL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x66E6A70", Offset = "0x66E5870", VA = "0x1866E6A70")]
				public static PlayerLoopSystem CGJNAACGAOC(DLJHEAODFDP.JMIABIEAJPC IDGIKKEFDCG)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class CFJAFHKPDEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public CFJAFHKPDEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x66DA6E0", Offset = "0x66D94E0", VA = "0x1866DA6E0")]
			internal List<PlayerLoopSystem> NBJBNODJADK(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool GNDCDCPKHHE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool EFOHAJPCKOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x66DE820", Offset = "0x66DD620", VA = "0x1866DE820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x66DBD30", Offset = "0x66DAB30", VA = "0x1866DBD30")]
		private static void FELEDDDDDNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x66DE860", Offset = "0x66DD660", VA = "0x1866DE860")]
		private static void MHDOLLBLFHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x66DBB00", Offset = "0x66DA900", VA = "0x1866DBB00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66DE660", Offset = "0x66DD460", VA = "0x1866DE660")]
		private static void GPCLOFNGELC(DLJHEAODFDP.JMIABIEAJPC IDGIKKEFDCG, PlayerLoopSystem JDJOBENEJON, Type FGLBGCMNIEA, Type AIEHLDGPNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x66DF130", Offset = "0x66DDF30", VA = "0x1866DF130")]
		private static void NJBDEBOFMIG(PlayerLoopSystem JDJOBENEJON, Type FGLBGCMNIEA, Type AIEHLDGPNDG, COOJFMKEPLA NFMHADNKDFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66DF510", Offset = "0x66DE310", VA = "0x1866DF510")]
		private static void OHFNDEGIIOP(PlayerLoopSystem JDJOBENEJON, Type FGLBGCMNIEA, Type AIEHLDGPNDG, PlayerLoopSystem? NIEKBKIODPL, PlayerLoopSystem? LKHGNLNNPEO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class DLJHEAODFDP
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum JMIABIEAJPC
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
	public class GABJOIPJJOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly JMIABIEAJPC AIBDMMFHDMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly GFFNPAPCOHF OIOCKMJCPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long KLCOLNMOBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long ECACALFBNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long MICIKDEBOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int LKOBDINELBC;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x66E2F20", Offset = "0x66E1D20", VA = "0x1866E2F20")]
		public GABJOIPJJOE(JMIABIEAJPC NJJGMIHDOEK, int HKEKINEHDHO = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x66E2EB0", Offset = "0x66E1CB0", VA = "0x1866E2EB0")]
		public void PGHOCGHPBAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x66E2C80", Offset = "0x66E1A80", VA = "0x1866E2C80")]
		public void DHLLOGOKHCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x66E2CD0", Offset = "0x66E1AD0", VA = "0x1866E2CD0")]
		public void FDGANHOGGBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static JMIABIEAJPC[] COEGMFJLBJE;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static GABJOIPJJOE[] CKLODGHFBGF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x66DFD90", Offset = "0x66DEB90", VA = "0x1866DFD90")]
	public static GABJOIPJJOE FMEFJACIDOP(JMIABIEAJPC IDGIKKEFDCG, int HKEKINEHDHO = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x66DFD20", Offset = "0x66DEB20", VA = "0x1866DFD20")]
	public static GABJOIPJJOE FJJALNHFCHF(JMIABIEAJPC IDGIKKEFDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x66DFF70", Offset = "0x66DED70", VA = "0x1866DFF70")]
	public static void HFEPCAJCPJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class GFFNPAPCOHF : KGAHFFONDEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int FPFOIMOLDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> EHAOOKHLFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double HKABGMNKJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double HAAKINALKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double OADNOGGOOAD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double HLOOFFDFCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x66E3DD0", Offset = "0x66E2BD0", VA = "0x1866E3DD0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double HCEFCPLAIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x174BCE0", Offset = "0x174AAE0", VA = "0x18174BCE0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double AIBMHPOPIMM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1CDD780", Offset = "0x1CDC580", VA = "0x181CDD780", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x66E3FC0", Offset = "0x66E2DC0", VA = "0x1866E3FC0")]
	public GFFNPAPCOHF(int MPCEIKCPCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x66E3EA0", Offset = "0x66E2CA0", VA = "0x1866E3EA0", Slot = "7")]
	public void NLIDOPGHMOF(double AJHKDPJBHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x66E3E30", Offset = "0x66E2C30", VA = "0x1866E3E30", Slot = "8")]
	public void KGLPDGAIIAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class ILIJIIHBLFM : KGAHFFONDEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long KGLOPMIHJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double OEMPBOGIPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double HKOCFDLPFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double LHLKPKIAHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double MFHMHOFMJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double HKABGMNKJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double HAAKINALKIC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double HCEFCPLAIAL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5603D10", Offset = "0x5602B10", VA = "0x185603D10", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double AIBMHPOPIMM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5603CE0", Offset = "0x5602AE0", VA = "0x185603CE0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double ONIDIPINEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5603CC0", Offset = "0x5602AC0", VA = "0x185603CC0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double HLOOFFDFCKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x21567C0", Offset = "0x21555C0", VA = "0x1821567C0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x66E4CC0", Offset = "0x66E3AC0", VA = "0x1866E4CC0", Slot = "7")]
	public virtual void NLIDOPGHMOF(double AJHKDPJBHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x66E4C80", Offset = "0x66E3A80", VA = "0x1866E4C80", Slot = "8")]
	public virtual void KGLPDGAIIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x66E4DE0", Offset = "0x66E3BE0", VA = "0x1866E4DE0")]
	public ILIJIIHBLFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class LCNBEMBFMJN : ILIJIIHBLFM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double LGLHJKJDHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5604180", Offset = "0x5602F80", VA = "0x185604180")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x56041C0", Offset = "0x5602FC0", VA = "0x1856041C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x66EAE40", Offset = "0x66E9C40", VA = "0x1866EAE40", Slot = "7")]
	public override void NLIDOPGHMOF(double AJHKDPJBHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x66EAE00", Offset = "0x66E9C00", VA = "0x1866EAE00", Slot = "8")]
	public override void KGLPDGAIIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x66E4DE0", Offset = "0x66E3BE0", VA = "0x1866E4DE0")]
	public LCNBEMBFMJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KGAHFFONDEH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double HLOOFFDFCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double HCEFCPLAIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double AIBMHPOPIMM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FNDNNDNMFAC
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface GCJKCACJHMC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool LDEIIBINKLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OCBGKNNKGKG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class FDPMCPMNCBN<TPromise, TMainThreadPromise> : GCJKCACJHMC where TPromise : PCFNKHPOHAG where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise DJJNANPGCHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise OJNNDKBHPHO;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise OFIDDFLOAJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x35E76B0", Offset = "0x35E64B0", VA = "0x1835E76B0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool LDEIIBINKLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x35E7730", Offset = "0x35E6530", VA = "0x1835E7730", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x79B830", Offset = "0x79A630", VA = "0x18079B830")]
		protected FDPMCPMNCBN(TPromise DJJNANPGCHD, TMainThreadPromise ADCBHFLGCPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x35E7710", Offset = "0x35E6510", VA = "0x1835E7710", Slot = "5")]
		public void OCBGKNNKGKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void FPIBOOIGDEI(TPromise DJJNANPGCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class LHKKCLBAADK<T> : FDPMCPMNCBN<FJJBNKADFNG<T>, PGNMDMMNJMF<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3B4A700", Offset = "0x3B49500", VA = "0x183B4A700")]
		public LHKKCLBAADK(FJJBNKADFNG<T> DJJNANPGCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3B4A490", Offset = "0x3B49290", VA = "0x183B4A490", Slot = "6")]
		protected override void FPIBOOIGDEI(FJJBNKADFNG<T> DJJNANPGCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3B4A6D0", Offset = "0x3B494D0", VA = "0x183B4A6D0")]
		[CompilerGenerated]
		private void PJLKPFDECHM(T ADPBDOHMAGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3B4A6A0", Offset = "0x3B494A0", VA = "0x183B4A6A0")]
		[CompilerGenerated]
		private void PHDMNDODFHF(string NGPMDAJFCLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class AOGHPOAHLJG : GCJKCACJHMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action APDAGBKMGMB;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool LDEIIBINKLB
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7A9270", Offset = "0x7A8070", VA = "0x1807A9270", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x791D40", Offset = "0x790B40", VA = "0x180791D40")]
		public AOGHPOAHLJG(Action APDAGBKMGMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB97B40", Offset = "0xB96940", VA = "0x180B97B40", Slot = "5")]
		public void OCBGKNNKGKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<GCJKCACJHMC> ELBBLPFHCFK;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x25B7960", Offset = "0x25B6760", VA = "0x1825B7960")]
	public static FJJBNKADFNG<T> NJGIPCHGEHL<T>(this FJJBNKADFNG<T> DJJNANPGCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x66E2B50", Offset = "0x66E1950", VA = "0x1866E2B50")]
	public static void NJGIPCHGEHL(Action APDAGBKMGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x25B78A0", Offset = "0x25B66A0", VA = "0x1825B78A0")]
	private static FJJBNKADFNG<T> GIGKPAKNFPK<T>(FJJBNKADFNG<T> DJJNANPGCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x66E2480", Offset = "0x66E1280", VA = "0x1866E2480")]
	private static void DFDIKBKNAPH(GCJKCACJHMC EHKCPLNPGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x66E2770", Offset = "0x66E1570", VA = "0x1866E2770")]
	private static void LGGIPKLKPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x66E2A50", Offset = "0x66E1850", VA = "0x1866E2A50")]
	private static void MHLJJIFNPOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x66E2690", Offset = "0x66E1490", VA = "0x1866E2690")]
	private static void KNDKBOBHIFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class IOEPHFDPOHI
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct HOHOHFCNNHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> EAGPDPLANKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string LIMACJJIKHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode LCOENPBGOFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool GJEMNFFHMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly AGDBIEMPPKH<string>.NDDNJDNHBMI HPLLIIDNIBL;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x66E4930", Offset = "0x66E3730", VA = "0x1866E4930")]
		public HOHOHFCNNHF(TaskCompletionSource<Scene> GIGBONOOALE, string LIMACJJIKHO, LoadSceneMode LCOENPBGOFP, bool GJEMNFFHMBL, AGDBIEMPPKH<string>.NDDNJDNHBMI HPLLIIDNIBL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct NLLHKLKKOKK : IAsyncStateMachine
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
		public AGDBIEMPPKH<string>.NDDNJDNHBMI stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private AGDBIEMPPKH<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x66EC0D0", Offset = "0x66EAED0", VA = "0x1866EC0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x66EC970", Offset = "0x66EB770", VA = "0x1866EC970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct GBJHBIEJFNF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x66E3030", Offset = "0x66E1E30", VA = "0x1866E3030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x66E3350", Offset = "0x66E2150", VA = "0x1866E3350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct OGCFLKLLDPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private HOHOHFCNNHF <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x66ED4F0", Offset = "0x66EC2F0", VA = "0x1866ED4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x66ED8A0", Offset = "0x66EC6A0", VA = "0x1866ED8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class JADKBBJJFJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public PGNMDMMNJMF<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public JADKBBJJFJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x66E6960", Offset = "0x66E5760", VA = "0x1866E6960")]
		internal void OJPHODBKFCI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct BPMBKIBKLKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AGDBIEMPPKH<string>.NDDNJDNHBMI stackTimer;

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
		private JADKBBJJFJC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private AGDBIEMPPKH<string>.NDDNJDNHBMI <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private AGDBIEMPPKH<string>.NDDNJDNHBMI <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x66D98A0", Offset = "0x66D86A0", VA = "0x1866D98A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x66DA440", Offset = "0x66D9240", VA = "0x1866DA440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct BOGNIKCANJH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x66D9320", Offset = "0x66D8120", VA = "0x1866D9320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x66D9830", Offset = "0x66D8630", VA = "0x1866D9830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct EHFMOKIMACJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AGDBIEMPPKH<string>.NDDNJDNHBMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private AGDBIEMPPKH<string>.NDDNJDNHBMI <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private AGDBIEMPPKH<string>.NDDNJDNHBMI <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x66E0200", Offset = "0x66DF000", VA = "0x1866E0200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x66E0D50", Offset = "0x66DFB50", VA = "0x1866E0D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class CCODCJBECNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public CCODCJBECNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x66DA4B0", Offset = "0x66D92B0", VA = "0x1866DA4B0")]
		internal bool JPKKOGPKJJO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CJHEFELDHGB : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private EFMJLGFKALI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public EEELEBFPAJE onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
		[DebuggerHidden]
		public CJHEFELDHGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x66DAF90", Offset = "0x66D9D90", VA = "0x1866DAF90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x66DAC00", Offset = "0x66D9A00", VA = "0x1866DAC00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x66DABB0", Offset = "0x66D99B0", VA = "0x1866DABB0")]
		private void BFEOCPBHPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x66DAF40", Offset = "0x66D9D40", VA = "0x1866DAF40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class KDHBPKCJIMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public PGNMDMMNJMF<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public KDHBPKCJIMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x66E8E60", Offset = "0x66E7C60", VA = "0x1866E8E60")]
		internal bool IAPBKJPJDEB(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x66E8BE0", Offset = "0x66E79E0", VA = "0x1866E8BE0")]
		internal void AHINDMGFPML(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class OIDLBIBGCAF : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private EFMJLGFKALI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public PGNMDMMNJMF<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private KDHBPKCJIMA <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
		[DebuggerHidden]
		public OIDLBIBGCAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x66EDD20", Offset = "0x66ECB20", VA = "0x1866EDD20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x66EE430", Offset = "0x66ED230", VA = "0x1866EE430", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> GGHPPKJKKFC;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static PCFNKHPOHAG FIMDMMOKEJF;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation CCKFHMNGNEB;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static PCFNKHPOHAG BODFGFHDCJN;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string MOPLLMHJKDH;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority KCONCAGLBEF;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task BOOEAIJOKBB;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> KMDNBPOPHBF;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<HOHOHFCNNHF> ADCKCMLKGIP;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task FELLIOHLKOE;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool PLKAEGGKDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x66E6440", Offset = "0x66E5240", VA = "0x1866E6440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool DNFNAFLPODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x66E63A0", Offset = "0x66E51A0", VA = "0x1866E63A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool IFOLPJFFPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x66E5AA0", Offset = "0x66E48A0", VA = "0x1866E5AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool HKCILOFDBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x66E6060", Offset = "0x66E4E60", VA = "0x1866E6060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> FHJKBAENBFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x66E55B0", Offset = "0x66E43B0", VA = "0x1866E55B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x66E5330", Offset = "0x66E4130", VA = "0x1866E5330")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x66E5C90", Offset = "0x66E4A90", VA = "0x1866E5C90")]
	[MNLKAMGDLIA(LJCKCCGEALO.EnteredEditModeNextFrame, 0)]
	private static void MCIKDOCJILH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x66E5B40", Offset = "0x66E4940", VA = "0x1866E5B40")]
	[AsyncStateMachine(typeof(NLLHKLKKOKK))]
	public static Task<Scene> LAPIDFGLGPP(string LIMACJJIKHO, LoadSceneMode LCOENPBGOFP = LoadSceneMode.Single, bool GJEMNFFHMBL = false, [Optional] AGDBIEMPPKH<string>.NDDNJDNHBMI BMIFFDDCIPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x66E5440", Offset = "0x66E4240", VA = "0x1866E5440")]
	[AsyncStateMachine(typeof(GBJHBIEJFNF))]
	private static Task FPBJGLEPKJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x66E56C0", Offset = "0x66E44C0", VA = "0x1866E56C0")]
	[AsyncStateMachine(typeof(OGCFLKLLDPD))]
	private static Task GKLBJMJDCDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x66E6250", Offset = "0x66E5050", VA = "0x1866E6250")]
	[AsyncStateMachine(typeof(BPMBKIBKLKG))]
	private static Task<Scene> OAPBBHEKHPD(string LIMACJJIKHO, LoadSceneMode LCOENPBGOFP, bool GJEMNFFHMBL, AGDBIEMPPKH<string>.NDDNJDNHBMI HPLLIIDNIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x66E60F0", Offset = "0x66E4EF0", VA = "0x1866E60F0")]
	private static void NJCANIKLDOL(SceneInstance PICGAENFGAG, LoadSceneMode LCOENPBGOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x66E54F0", Offset = "0x66E42F0", VA = "0x1866E54F0")]
	private static void GDKPKEICAOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x66E5050", Offset = "0x66E3E50", VA = "0x1866E5050")]
	[AsyncStateMachine(typeof(BOGNIKCANJH))]
	private static Task<Scene> AAILFPHEAON(string LIMACJJIKHO, LoadSceneMode LCOENPBGOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x66E5830", Offset = "0x66E4630", VA = "0x1866E5830")]
	private static bool HOFCCOGCGMB(string LIMACJJIKHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x66E6660", Offset = "0x66E5460", VA = "0x1866E6660")]
	[AsyncStateMachine(typeof(EHFMOKIMACJ))]
	private static Task<Scene> PLIPPCAOEML(AGDBIEMPPKH<string>.NDDNJDNHBMI HPLLIIDNIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x66E5920", Offset = "0x66E4720", VA = "0x1866E5920")]
	public static FJJBNKADFNG<Scene> IEIJMBOHGKL(string LIMACJJIKHO, LoadSceneMode LCOENPBGOFP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x66E5D90", Offset = "0x66E4B90", VA = "0x1866E5D90")]
	public static PCFNKHPOHAG NADAJJMAMEJ(string LIMACJJIKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x66E52A0", Offset = "0x66E40A0", VA = "0x1866E52A0")]
	[IteratorStateMachine(typeof(CJHEFELDHGB))]
	private static IEnumerator<EFMJLGFKALI> DLBOBMAKJEN(string LIMACJJIKHO, EEELEBFPAJE CBADABBODNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x66E5790", Offset = "0x66E4590", VA = "0x1866E5790")]
	[IteratorStateMachine(typeof(OIDLBIBGCAF))]
	private static IEnumerator<EFMJLGFKALI> GMGOHNDJKCH(string LIMACJJIKHO, LoadSceneMode LCOENPBGOFP, PGNMDMMNJMF<Scene> CBADABBODNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x66E5170", Offset = "0x66E3F70", VA = "0x1866E5170")]
	public static bool DCCDPGOHPLI([Out] string BBPHIJLFDDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class NLGEAOCMLKP
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x66EC040", Offset = "0x66EAE40", VA = "0x1866EC040")]
	public static IDisposable IPHOKNDPKPE(this JHMNCBGMHEA BCCEHJNGNAL, float MILJELIDHON, Action<float> BCOBPLINNLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x66EBFC0", Offset = "0x66EADC0", VA = "0x1866EBFC0")]
	public static IDisposable IFNCGNBGNEM(this JHMNCBGMHEA BCCEHJNGNAL, Action<float> BCOBPLINNLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x66EBF40", Offset = "0x66EAD40", VA = "0x1866EBF40")]
	public static IDisposable FLLBPKIKOJN(this JHMNCBGMHEA BCCEHJNGNAL, Action<float> BCOBPLINNLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class JJOHOLNCGJI
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x66E7DD0", Offset = "0x66E6BD0", VA = "0x1866E7DD0")]
	public static IDisposable PFFIMIDPIML(this MonoBehaviour ELCNNAHJPKC, Action BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x66E7E60", Offset = "0x66E6C60", VA = "0x1866E7E60")]
	public static IDisposable PFFIMIDPIML(this MonoBehaviour ELCNNAHJPKC, Action<float> BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x66E7960", Offset = "0x66E6760", VA = "0x1866E7960")]
	public static IDisposable KBHDIJCCCPP(this MonoBehaviour ELCNNAHJPKC, Action BCOBPLINNLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x66E7BB0", Offset = "0x66E69B0", VA = "0x1866E7BB0")]
	public static IDisposable ONLBGOJJDEH(this MonoBehaviour ELCNNAHJPKC, Action BCOBPLINNLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x66E7C30", Offset = "0x66E6A30", VA = "0x1866E7C30")]
	public static IDisposable ONLBGOJJDEH(this MonoBehaviour ELCNNAHJPKC, Action<float> BCOBPLINNLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x66E7650", Offset = "0x66E6450", VA = "0x1866E7650")]
	public static IDisposable HLONJMJGPKP(this MonoBehaviour ELCNNAHJPKC, Action BCOBPLINNLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x66E7A80", Offset = "0x66E6880", VA = "0x1866E7A80")]
	public static IDisposable NAJFCBJPEPB(this MonoBehaviour ELCNNAHJPKC, Action BCOBPLINNLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x66E7D50", Offset = "0x66E6B50", VA = "0x1866E7D50")]
	public static IDisposable OOINFGINDKO(this MonoBehaviour ELCNNAHJPKC, Action BCOBPLINNLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x66E7B00", Offset = "0x66E6900", VA = "0x1866E7B00")]
	public static IDisposable OAJLKPIACKB(this MonoBehaviour ELCNNAHJPKC, float MILJELIDHON, Action<float> BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK, bool CDIEDHJKFHG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x66E7530", Offset = "0x66E6330", VA = "0x1866E7530")]
	public static IDisposable FMEEFPHLLDF(this MonoBehaviour ELCNNAHJPKC, float MILJELIDHON, Action<float> BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK, bool CDIEDHJKFHG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x66E78C0", Offset = "0x66E66C0", VA = "0x1866E78C0")]
	public static IDisposable JFPLBGPOMPB(this MonoBehaviour ELCNNAHJPKC, float MILJELIDHON, Action<float> BCOBPLINNLO, bool CDIEDHJKFHG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x66E79E0", Offset = "0x66E67E0", VA = "0x1866E79E0")]
	public static IDisposable MKDODMDDPOH(this MonoBehaviour ELCNNAHJPKC, Action<float> BCOBPLINNLO, bool CDIEDHJKFHG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x66E76D0", Offset = "0x66E64D0", VA = "0x1866E76D0")]
	public static IDisposable HOOBGIJGKLB(this MonoBehaviour ELCNNAHJPKC, Action<float> BCOBPLINNLO, bool CDIEDHJKFHG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x66E7490", Offset = "0x66E6290", VA = "0x1866E7490")]
	public static IDisposable FLHCKGHLIFP(this MonoBehaviour ELCNNAHJPKC, Action<float> BCOBPLINNLO, bool CDIEDHJKFHG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x66E7820", Offset = "0x66E6620", VA = "0x1866E7820")]
	public static IDisposable IMFELKFGNKJ(this MonoBehaviour ELCNNAHJPKC, Action<float> BCOBPLINNLO, bool CDIEDHJKFHG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x66E7CB0", Offset = "0x66E6AB0", VA = "0x1866E7CB0")]
	public static IDisposable OODOKCDPGAB(this MonoBehaviour ELCNNAHJPKC, Action<float> BCOBPLINNLO, bool CDIEDHJKFHG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x66E7350", Offset = "0x66E6150", VA = "0x1866E7350")]
	public static IDisposable BDOGNKHECEM(this MonoBehaviour ELCNNAHJPKC, Action<float> BCOBPLINNLO, bool CDIEDHJKFHG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x66E73F0", Offset = "0x66E61F0", VA = "0x1866E73F0")]
	public static IDisposable CAGNDIAIOJP(this MonoBehaviour ELCNNAHJPKC, Action<float> BCOBPLINNLO, bool CDIEDHJKFHG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x66E7770", Offset = "0x66E6570", VA = "0x1866E7770")]
	public static IDisposable ICNENHEPAIK(this MonoBehaviour ELCNNAHJPKC, float MILJELIDHON, Action<float> BCOBPLINNLO, bool CDIEDHJKFHG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CLABMDKCMHO
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class CKOKAPOEFBI : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private EFMJLGFKALI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public IHOHCHAHKKI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private EBMOPHEHAEO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
		[DebuggerHidden]
		public CKOKAPOEFBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x66DB020", Offset = "0x66D9E20", VA = "0x1866DB020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x66DB100", Offset = "0x66D9F00", VA = "0x1866DB100", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class LFCDBKPGJAP : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private EFMJLGFKALI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IHOHCHAHKKI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private EBMOPHEHAEO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
		[DebuggerHidden]
		public LFCDBKPGJAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x66EB170", Offset = "0x66E9F70", VA = "0x1866EB170", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x66EB260", Offset = "0x66EA060", VA = "0x1866EB260", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x66DB270", Offset = "0x66DA070", VA = "0x1866DB270")]
	public static KPDMKFJCEFL PFFIMIDPIML(Action BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x66DB320", Offset = "0x66DA120", VA = "0x1866DB320")]
	public static KPDMKFJCEFL PFFIMIDPIML(Behaviour BCCEHJNGNAL, Action BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x66DB3E0", Offset = "0x66DA1E0", VA = "0x1866DB3E0")]
	public static KPDMKFJCEFL PFFIMIDPIML(Behaviour BCCEHJNGNAL, Action<float> BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x66DB1E0", Offset = "0x66D9FE0", VA = "0x1866DB1E0")]
	[IteratorStateMachine(typeof(CKOKAPOEFBI))]
	private static IEnumerator<EFMJLGFKALI> KKPMFFCLIBD(IHOHCHAHKKI DKBGJFLJOJP, Action BCOBPLINNLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x66DB150", Offset = "0x66D9F50", VA = "0x1866DB150")]
	[IteratorStateMachine(typeof(LFCDBKPGJAP))]
	private static IEnumerator<EFMJLGFKALI> KKPMFFCLIBD(IHOHCHAHKKI DKBGJFLJOJP, Action<float> BCOBPLINNLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NPCKGBAPLLE : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class ENPDDLHPGLD : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private EFMJLGFKALI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public NPCKGBAPLLE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
		[DebuggerHidden]
		public ENPDDLHPGLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x66E0DC0", Offset = "0x66DFBC0", VA = "0x1866E0DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x66E0E50", Offset = "0x66DFC50", VA = "0x1866E0E50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly IHOHCHAHKKI JLCLFNHGOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action NBDJHEHEBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool KIOLNNKILOJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool MCMOHAOIJHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x78E250", Offset = "0x78D050", VA = "0x18078E250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x66ECB40", Offset = "0x66EB940", VA = "0x1866ECB40")]
	public NPCKGBAPLLE(IHOHCHAHKKI JLCLFNHGOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x66ECAC0", Offset = "0x66EB8C0", VA = "0x1866ECAC0")]
	[IteratorStateMachine(typeof(ENPDDLHPGLD))]
	private IEnumerator<EFMJLGFKALI> PNNMKNPCGAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x66ECA20", Offset = "0x66EB820", VA = "0x1866ECA20", Slot = "4")]
	public void OnCompleted(Action NEOHCILADBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840")]
	public void FOKKNALLMGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class EOCEKOOGJOC
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x66E0EA0", Offset = "0x66DFCA0", VA = "0x1866E0EA0")]
	public static NPCKGBAPLLE JGAOOOJCGAG(this IHOHCHAHKKI JLCLFNHGOAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class PNGLGKMMHDG
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class DDGDPPDDOOO : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private EFMJLGFKALI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public IDOKOPBGMIF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
		[DebuggerHidden]
		public DDGDPPDDOOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x66DF780", Offset = "0x66DE580", VA = "0x1866DF780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x66DF800", Offset = "0x66DE600", VA = "0x1866DF800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x66F2670", Offset = "0x66F1470", VA = "0x1866F2670")]
	public static KPDMKFJCEFL PFFIMIDPIML(float MILJELIDHON, Action<float> BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK, bool CDIEDHJKFHG = true, [Optional] CPDGLAMKFGL PMMBPEAJBAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x66F2560", Offset = "0x66F1360", VA = "0x1866F2560")]
	public static KPDMKFJCEFL PFFIMIDPIML(MonoBehaviour ELCNNAHJPKC, float MILJELIDHON, Action<float> BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK, bool CDIEDHJKFHG = true, [Optional] CPDGLAMKFGL PMMBPEAJBAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x66F22F0", Offset = "0x66F10F0", VA = "0x1866F22F0")]
	public static KPDMKFJCEFL GFLMAAIJNAJ(MonoBehaviour ELCNNAHJPKC, float MILJELIDHON, Action<float> BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK, bool CDIEDHJKFHG = true, [Optional] CPDGLAMKFGL PMMBPEAJBAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x66F21E0", Offset = "0x66F0FE0", VA = "0x1866F21E0")]
	public static KPDMKFJCEFL EECFGCALEGG(JHMNCBGMHEA BCCEHJNGNAL, float MILJELIDHON, Action<float> BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK, bool CDIEDHJKFHG = true, [Optional] CPDGLAMKFGL PMMBPEAJBAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x66F2410", Offset = "0x66F1210", VA = "0x1866F2410")]
	private static IEnumerator<EFMJLGFKALI> KKPMFFCLIBD(FMIGPAOMIEK AGBNJCONBEG, float MILJELIDHON, IHOHCHAHKKI DKBGJFLJOJP, Action<float> BCOBPLINNLO, bool CDIEDHJKFHG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x66F2180", Offset = "0x66F0F80", VA = "0x1866F2180")]
	private static IEnumerator<EFMJLGFKALI> AEOAOBAKOBC(FMIGPAOMIEK AGBNJCONBEG, float MILJELIDHON, IHOHCHAHKKI DKBGJFLJOJP, Action<float> BCOBPLINNLO, bool CDIEDHJKFHG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x66F24D0", Offset = "0x66F12D0", VA = "0x1866F24D0")]
	[IteratorStateMachine(typeof(DDGDPPDDOOO))]
	private static IEnumerator<EFMJLGFKALI> OKAPJEBJLLL(IDOKOPBGMIF DPOLHMMHBFD, float MILJELIDHON, IHOHCHAHKKI DKBGJFLJOJP, Action<float> BCOBPLINNLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class CHBHKFNKILP
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class LBPEHADLDFP : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private EFMJLGFKALI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public IHOHCHAHKKI queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
		[DebuggerHidden]
		public LBPEHADLDFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x66EACF0", Offset = "0x66E9AF0", VA = "0x1866EACF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x66EADB0", Offset = "0x66E9BB0", VA = "0x1866EADB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x66DA920", Offset = "0x66D9720", VA = "0x1866DA920")]
	[IteratorStateMachine(typeof(LBPEHADLDFP))]
	private static IEnumerator<EFMJLGFKALI> MENNNDCKLHD(IHOHCHAHKKI JLCLFNHGOAK, Func<bool> HHNPNNJCGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x66DA800", Offset = "0x66D9600", VA = "0x1866DA800")]
	public static KPDMKFJCEFL LKLNFNCCMGN(this MonoBehaviour ELCNNAHJPKC, Func<bool> HHNPNNJCGFO, IHOHCHAHKKI JLCLFNHGOAK = IHOHCHAHKKI.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class GCJGHLDKKCH
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class LGPLLACBAAK : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private EFMJLGFKALI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public IHOHCHAHKKI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
		[DebuggerHidden]
		public LGPLLACBAAK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x66EB2B0", Offset = "0x66EA0B0", VA = "0x1866EB2B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x66EB320", Offset = "0x66EA120", VA = "0x1866EB320", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class BMAOGJJFFHC : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private EFMJLGFKALI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public IHOHCHAHKKI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private EFMJLGFKALI <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
		[DebuggerHidden]
		public BMAOGJJFFHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x66D9240", Offset = "0x66D8040", VA = "0x1866D9240", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x66D92D0", Offset = "0x66D80D0", VA = "0x1866D92D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x66E3D30", Offset = "0x66E2B30", VA = "0x1866E3D30")]
	[IteratorStateMachine(typeof(LGPLLACBAAK))]
	private static IEnumerator<EFMJLGFKALI> PNNMKNPCGAI(float JILOLFHINNI, IHOHCHAHKKI DKBGJFLJOJP, Action OLKLBJAAOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x66E3920", Offset = "0x66E2720", VA = "0x1866E3920")]
	[IteratorStateMachine(typeof(BMAOGJJFFHC))]
	private static IEnumerator<EFMJLGFKALI> JEKCKEJFNMJ(float JILOLFHINNI, IHOHCHAHKKI DKBGJFLJOJP, Action OLKLBJAAOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x66E3710", Offset = "0x66E2510", VA = "0x1866E3710")]
	public static IDisposable FEGHAKGGJEA(this MonoBehaviour ELCNNAHJPKC, float JILOLFHINNI, Action OLKLBJAAOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x66E3830", Offset = "0x66E2630", VA = "0x1866E3830")]
	public static KPDMKFJCEFL GPILHCAMCPK(this MonoBehaviour ELCNNAHJPKC, float JILOLFHINNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x66E35E0", Offset = "0x66E23E0", VA = "0x1866E35E0")]
	public static KPDMKFJCEFL FEGHAKGGJEA(this MonoBehaviour ELCNNAHJPKC, float JILOLFHINNI, IHOHCHAHKKI DKBGJFLJOJP, Action OLKLBJAAOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x66E3A90", Offset = "0x66E2890", VA = "0x1866E3A90")]
	public static KPDMKFJCEFL MABNJLELNDL(this MonoBehaviour ELCNNAHJPKC, Action OLKLBJAAOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x66E3410", Offset = "0x66E2210", VA = "0x1866E3410")]
	public static KPDMKFJCEFL BKCGDHLPNLB(this MonoBehaviour ELCNNAHJPKC, Action OLKLBJAAOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x66E3C50", Offset = "0x66E2A50", VA = "0x1866E3C50")]
	public static KPDMKFJCEFL OKGDKNELPGD(this MonoBehaviour ELCNNAHJPKC, Action OLKLBJAAOHA, [Optional] CPDGLAMKFGL PMMBPEAJBAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x66E38F0", Offset = "0x66E26F0", VA = "0x1866E38F0")]
	public static KPDMKFJCEFL JAAEGBMJDFK(this MonoBehaviour ELCNNAHJPKC, Action OLKLBJAAOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x66E33E0", Offset = "0x66E21E0", VA = "0x1866E33E0")]
	public static KPDMKFJCEFL BEBFBOJMADK(this MonoBehaviour ELCNNAHJPKC, Action OLKLBJAAOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x66E33B0", Offset = "0x66E21B0", VA = "0x1866E33B0")]
	public static KPDMKFJCEFL ACMNJNHFBKH(this MonoBehaviour ELCNNAHJPKC, Action OLKLBJAAOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x66E3AB0", Offset = "0x66E28B0", VA = "0x1866E3AB0")]
	private static KPDMKFJCEFL NHHGOOLGGED(MonoBehaviour ELCNNAHJPKC, IHOHCHAHKKI JLCLFNHGOAK, Action OLKLBJAAOHA, [Optional] CPDGLAMKFGL PMMBPEAJBAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x66E3440", Offset = "0x66E2240", VA = "0x1866E3440")]
	public static KPDMKFJCEFL CAKKJPBEKAK(this MonoBehaviour ELCNNAHJPKC, float AHDLOPCMLMK, Action OLKLBJAAOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x66E3B80", Offset = "0x66E2980", VA = "0x1866E3B80")]
	public static KPDMKFJCEFL NJMPEOAFOEL(this MonoBehaviour ELCNNAHJPKC, float AHDLOPCMLMK, Action OLKLBJAAOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x66E39C0", Offset = "0x66E27C0", VA = "0x1866E39C0")]
	public static KPDMKFJCEFL KEEJDJHIEMC(this MonoBehaviour ELCNNAHJPKC, float AHDLOPCMLMK, Action OLKLBJAAOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x66E3510", Offset = "0x66E2310", VA = "0x1866E3510")]
	public static KPDMKFJCEFL FAMLHPDONEI(this MonoBehaviour ELCNNAHJPKC, float AHDLOPCMLMK, Action OLKLBJAAOHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class EPLMNHOKBAE : DLIFACNHMCN, IEnumerable<DLIFACNHMCN>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<DLIFACNHMCN> OKHCKNIACHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool BPBOIANMIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action DGDLFGNLMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool NAMCLANEKND;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool DLEPCLABKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x66E1230", Offset = "0x66E0030", VA = "0x1866E1230", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AGLPPOHIDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x66E1110", Offset = "0x66DFF10", VA = "0x1866E1110", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x66E14D0", Offset = "0x66E02D0", VA = "0x1866E14D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x66E1890", Offset = "0x66E0690", VA = "0x1866E1890")]
	public EPLMNHOKBAE([Optional] Action DGDLFGNLMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x66E0FE0", Offset = "0x66DFDE0", VA = "0x1866E0FE0")]
	public void EHPBILHDFGD(DLIFACNHMCN NMBFJKEAOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x66E1370", Offset = "0x66E0170", VA = "0x1866E1370")]
	private void JPKIFCHMPGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x66E1880", Offset = "0x66E0680", VA = "0x1866E1880", Slot = "7")]
	public bool NBIDIHLLOFG(bool OEPPFJFNIGI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x66E1570", Offset = "0x66E0370", VA = "0x1866E1570", Slot = "8")]
	public bool NBIDIHLLOFG(Action APDAGBKMGMB, bool OEPPFJFNIGI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x66E11B0", Offset = "0x66DFFB0", VA = "0x1866E11B0", Slot = "9")]
	public IEnumerator<DLIFACNHMCN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x66E11B0", Offset = "0x66DFFB0", VA = "0x1866E11B0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class KGGJALECAOB : BAEHEAAEJOB
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class AKNGAGHLBGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public KGGJALECAOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public AKNGAGHLBGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x66D7640", Offset = "0x66D6440", VA = "0x1866D7640")]
		internal void OHLFHCCJEOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class NBEPCIGIJKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public KGGJALECAOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public NBEPCIGIJKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x66D7640", Offset = "0x66D6440", VA = "0x1866D7640")]
		internal void PECGOKAAKFE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float LKOOEJGDODO;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x66EAAC0", Offset = "0x66E98C0", VA = "0x1866EAAC0")]
	public KGGJALECAOB(Behaviour BCCEHJNGNAL, float LKOOEJGDODO, [Optional] Action DGDLFGNLMLK, [Optional] CPDGLAMKFGL PMMBPEAJBAM, [Optional] FMIGPAOMIEK AGBNJCONBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x66EA9B0", Offset = "0x66E97B0", VA = "0x1866EA9B0", Slot = "9")]
	protected override bool MKGKJLMKFPN(Action APDAGBKMGMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x66EA8A0", Offset = "0x66E96A0", VA = "0x1866EA8A0", Slot = "10")]
	protected override bool ACPLHAKLIDN(Action APDAGBKMGMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface DLIFACNHMCN
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool DLEPCLABKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action AGLPPOHIDPJ;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NBIDIHLLOFG(bool OEPPFJFNIGI = false);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NBIDIHLLOFG(Action APDAGBKMGMB, bool OEPPFJFNIGI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class BAEHEAAEJOB : DLIFACNHMCN
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class FKPDEIFCALO : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private EFMJLGFKALI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public BAEHEAAEJOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
		[DebuggerHidden]
		public FKPDEIFCALO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x66E20F0", Offset = "0x66E0EF0", VA = "0x1866E20F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x66E21C0", Offset = "0x66E0FC0", VA = "0x1866E21C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour BCCEHJNGNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action DGDLFGNLMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private MJDAGPPLDNE KMONIPEKHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly CPDGLAMKFGL PMMBPEAJBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly FMIGPAOMIEK AGBNJCONBEG;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool DLEPCLABKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xEDB8C0", Offset = "0xEDA6C0", VA = "0x180EDB8C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action AGLPPOHIDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x66D7760", Offset = "0x66D6560", VA = "0x1866D7760", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x66D7B90", Offset = "0x66D6990", VA = "0x1866D7B90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x66D7D10", Offset = "0x66D6B10", VA = "0x1866D7D10")]
	protected BAEHEAAEJOB(Behaviour BCCEHJNGNAL, [Optional] Action DGDLFGNLMLK, [Optional] CPDGLAMKFGL PMMBPEAJBAM, [Optional] FMIGPAOMIEK AGBNJCONBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x66D7CB0", Offset = "0x66D6AB0", VA = "0x1866D7CB0", Slot = "7")]
	public bool NBIDIHLLOFG(bool OEPPFJFNIGI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x66D7C50", Offset = "0x66D6A50", VA = "0x1866D7C50", Slot = "8")]
	public bool NBIDIHLLOFG(Action APDAGBKMGMB, bool OEPPFJFNIGI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool MKGKJLMKFPN(Action APDAGBKMGMB);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool ACPLHAKLIDN(Action APDAGBKMGMB);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x66D7C30", Offset = "0x66D6A30", VA = "0x1866D7C30")]
	protected void NBFINMEBLKJ(Action APDAGBKMGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7800", Offset = "0x66D6600", VA = "0x1866D7800")]
	protected PCFNKHPOHAG JJPCPGHOBKF(float OGMFDJJPFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A40", Offset = "0x66D6840", VA = "0x1866D7A40")]
	private void JNHGGGKIHBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x66D7AC0", Offset = "0x66D68C0", VA = "0x1866D7AC0")]
	[IteratorStateMachine(typeof(FKPDEIFCALO))]
	private IEnumerator<EFMJLGFKALI> KDCMLHKLNPF(float OGMFDJJPFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x66D7B50", Offset = "0x66D6950", VA = "0x1866D7B50")]
	[CompilerGenerated]
	private void KLMOMCFKCGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class OHHLDIIBPIN : BAEHEAAEJOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float BHNOEJCNPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int GDABICONBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float CCGCCPCGDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] EONOOHBLLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int NFHICHGOABO;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x66EDB80", Offset = "0x66EC980", VA = "0x1866EDB80")]
	public OHHLDIIBPIN(Behaviour BCCEHJNGNAL, float BFHFGEHIPBP, int GDABICONBFG, [Optional] Action DGDLFGNLMLK, float CCGCCPCGDCH = 0f, [Optional] CPDGLAMKFGL PMMBPEAJBAM, [Optional] FMIGPAOMIEK AGBNJCONBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "9")]
	protected override bool MKGKJLMKFPN(Action APDAGBKMGMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x66ED900", Offset = "0x66EC700", VA = "0x1866ED900", Slot = "10")]
	protected override bool ACPLHAKLIDN(Action APDAGBKMGMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x66EDB00", Offset = "0x66EC900", VA = "0x1866EDB00")]
	private void PLOBNCGEOPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class NMECCHEMMOH : BAEHEAAEJOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float LKOOEJGDODO;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x66EAAC0", Offset = "0x66E98C0", VA = "0x1866EAAC0")]
	public NMECCHEMMOH(Behaviour BCCEHJNGNAL, float LKOOEJGDODO, [Optional] Action DGDLFGNLMLK, [Optional] CPDGLAMKFGL PMMBPEAJBAM, [Optional] FMIGPAOMIEK AGBNJCONBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "9")]
	protected override bool MKGKJLMKFPN(Action APDAGBKMGMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x66EC9E0", Offset = "0x66EB7E0", VA = "0x1866EC9E0", Slot = "10")]
	protected override bool ACPLHAKLIDN(Action APDAGBKMGMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class FGFJCCAEBBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class EDMNDPAADOA : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private EFMJLGFKALI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
		[DebuggerHidden]
		public EDMNDPAADOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x66DF6C0", Offset = "0x66DE4C0", VA = "0x1866DF6C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x66E01B0", Offset = "0x66DEFB0", VA = "0x1866E01B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private KPDMKFJCEFL HOPKACJFFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private JHMNCBGMHEA BCCEHJNGNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> KOLBGIIGMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private IHOHCHAHKKI JLCLFNHGOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float GECHIBFFLNC;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x66E1EC0", Offset = "0x66E0CC0", VA = "0x1866E1EC0")]
	public FGFJCCAEBBN(JHMNCBGMHEA BCCEHJNGNAL, float MILJELIDHON, Action<float> BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x66E1CA0", Offset = "0x66E0AA0", VA = "0x1866E1CA0")]
	private void FOHBLCCIKJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x66E1AE0", Offset = "0x66E08E0", VA = "0x1866E1AE0")]
	private void CNDJCLHHFMM(string NGPMDAJFCLG, Action BPJNHOPDPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x66E1E40", Offset = "0x66E0C40", VA = "0x1866E1E40")]
	[IteratorStateMachine(typeof(EDMNDPAADOA))]
	private IEnumerator<EFMJLGFKALI> OPKBBDPDOJG(Action BPJNHOPDPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x66E1C40", Offset = "0x66E0A40", VA = "0x1866E1C40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x66E1930", Offset = "0x66E0730", VA = "0x1866E1930")]
	[CompilerGenerated]
	private void CHEKKADAAOF(string PNLFFEACIKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class PINODCOJLGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class DCPCFKLMKPG : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private EFMJLGFKALI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
		[DebuggerHidden]
		public DCPCFKLMKPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x66DF6C0", Offset = "0x66DE4C0", VA = "0x1866DF6C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x66DF730", Offset = "0x66DE530", VA = "0x1866DF730", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private KPDMKFJCEFL HOPKACJFFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour ELCNNAHJPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action BCOBPLINNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> KOLBGIIGMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private IHOHCHAHKKI JLCLFNHGOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float GECHIBFFLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool CDIEDHJKFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly CPDGLAMKFGL PMMBPEAJBAM;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x66F1D50", Offset = "0x66F0B50", VA = "0x1866F1D50")]
	public PINODCOJLGD(MonoBehaviour ELCNNAHJPKC, Action BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK, [Optional] CPDGLAMKFGL PMMBPEAJBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x66F1F40", Offset = "0x66F0D40", VA = "0x1866F1F40")]
	public PINODCOJLGD(MonoBehaviour ELCNNAHJPKC, Action<float> BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK, [Optional] CPDGLAMKFGL PMMBPEAJBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x66F1B00", Offset = "0x66F0900", VA = "0x1866F1B00")]
	public PINODCOJLGD(MonoBehaviour ELCNNAHJPKC, float MILJELIDHON, Action<float> BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK, bool CDIEDHJKFHG = true, [Optional] CPDGLAMKFGL PMMBPEAJBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x18E31C0", Offset = "0x18E1FC0", VA = "0x1818E31C0")]
	private PINODCOJLGD(CPDGLAMKFGL PMMBPEAJBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x66F12C0", Offset = "0x66F00C0", VA = "0x1866F12C0")]
	internal static PINODCOJLGD FLHPAFDBGOM(MonoBehaviour ELCNNAHJPKC, float MILJELIDHON, Action<float> BCOBPLINNLO, IHOHCHAHKKI JLCLFNHGOAK, bool CDIEDHJKFHG = true, [Optional] CPDGLAMKFGL PMMBPEAJBAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x66F1900", Offset = "0x66F0700", VA = "0x1866F1900")]
	private void PFFIMIDPIML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x66F1110", Offset = "0x66EFF10", VA = "0x1866F1110")]
	private void FJPCMLMBGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x66F13F0", Offset = "0x66F01F0", VA = "0x1866F13F0")]
	private void FOHBLCCIKJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x66F1630", Offset = "0x66F0430", VA = "0x1866F1630")]
	private void KPMNGOFJBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x66F0EF0", Offset = "0x66EFCF0", VA = "0x1866F0EF0")]
	private void CNDJCLHHFMM(string NGPMDAJFCLG, Action BPJNHOPDPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x66F17F0", Offset = "0x66F05F0", VA = "0x1866F17F0")]
	[IteratorStateMachine(typeof(DCPCFKLMKPG))]
	private IEnumerator<EFMJLGFKALI> OPKBBDPDOJG(Action BPJNHOPDPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x66F1020", Offset = "0x66EFE20", VA = "0x1866F1020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x66F1A70", Offset = "0x66F0870", VA = "0x1866F1A70")]
	[CompilerGenerated]
	private void PNFLELCHEAE(string PNLFFEACIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x66F1870", Offset = "0x66F0670", VA = "0x1866F1870")]
	[CompilerGenerated]
	private void OPLGEFPHOBJ(string PNLFFEACIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x66F15A0", Offset = "0x66F03A0", VA = "0x1866F15A0")]
	[CompilerGenerated]
	private void GPJEGEKAEMP(string PNLFFEACIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x66F1080", Offset = "0x66EFE80", VA = "0x1866F1080")]
	[CompilerGenerated]
	private void FAFGCKEOKCJ(string PNLFFEACIKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum BPOEDDOJHLL : byte
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
internal sealed class JHGEFPKFKOK : FMIGPAOMIEK
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float HIDFLFIICLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x66E69D0", Offset = "0x66E57D0", VA = "0x1866E69D0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float LNLMNMMPJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x66E69C0", Offset = "0x66E57C0", VA = "0x1866E69C0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double DLEDPFEPPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x66E69E0", Offset = "0x66E57E0", VA = "0x1866E69E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x66E6A00", Offset = "0x66E5800", VA = "0x1866E6A00")]
	[OKINHFAHPEJ(FNGNILODNLI.None)]
	private static void PNHDBAMNBDO(LPFNGCMIAEC KDNLDLIFDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	[Preserve]
	internal JHGEFPKFKOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface KLJLJKFCDAM
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBDNNICIECL(string AOAIBMOPKPE);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHIGCNAFLPH();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface LDGNGCEHPDH
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string BAAGNNPAEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool DABADEKAIJG
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool MINCHLKLAMN
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class DKMCGKONOBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public OJELJNCDBON AGAPMEHJIBF;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int IMILALJBIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x78D180", Offset = "0x78BF80", VA = "0x18078D180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x797AF0", Offset = "0x7968F0", VA = "0x180797AF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x66DFBC0", Offset = "0x66DE9C0", VA = "0x1866DFBC0")]
	public static EFMJLGFKALI IKFNNAOPPFJ(IEnumerator<EFMJLGFKALI> NKNFNCGJODD, DCIBGNIIHOK ENDOBNICGKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x66DFB00", Offset = "0x66DE900", VA = "0x1866DFB00")]
	public EFMJLGFKALI IKFNNAOPPFJ(DCIBGNIIHOK[] FHEIJBNLOJK, IEnumerator<EFMJLGFKALI>[] GPPKCMIOEAO, EFMJLGFKALI[] AOCHCMDGAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x66DF850", Offset = "0x66DE650", VA = "0x1866DF850")]
	public void NKNNMLOHPKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x66DF880", Offset = "0x66DE680", VA = "0x1866DF880")]
	public void GKOAJKENGNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x66DF9C0", Offset = "0x66DE7C0", VA = "0x1866DF9C0")]
	public void HFFIFGKLJKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x66DF850", Offset = "0x66DE650", VA = "0x1866DF850")]
	public void DOGHBEGILBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public DKMCGKONOBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class OJELJNCDBON
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct GKCDLBAFGLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public DKMCGKONOBO CEFMBJDEIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public JHMNCBGMHEA OOKPMHCILIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public DCIBGNIIHOK AOAJFDMKKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<EFMJLGFKALI> LGOMLPNNNHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public EFMJLGFKALI HOPABNMLOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public BPOEDDOJHLL IFEAFNBJOCH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct BFGBKMHOPFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public IHOHCHAHKKI JODJMEHAHEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<GKCDLBAFGLD> PKLGDJFNPOK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class JIIEDLOLLBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public DCIBGNIIHOK promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public OJELJNCDBON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public JHMNCBGMHEA context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public DKMCGKONOBO routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public BPOEDDOJHLL coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public EFMJLGFKALI currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<EFMJLGFKALI> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public JIIEDLOLLBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x66E6BA0", Offset = "0x66E59A0", VA = "0x1866E6BA0")]
		internal void AFNMDECDJHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class GMNLDHPBHLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public DKMCGKONOBO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public OJELJNCDBON <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public GMNLDHPBHLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x66E4270", Offset = "0x66E3070", VA = "0x1866E4270")]
		internal void IJCNBNFMKFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class OPECEOAEFKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public DKMCGKONOBO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public OJELJNCDBON <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public OPECEOAEFKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x66F0E30", Offset = "0x66EFC30", VA = "0x1866F0E30")]
		internal void EDJKDMLIDFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class AGEPPGCJIJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public DKMCGKONOBO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public OJELJNCDBON <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public AGEPPGCJIJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x66D7600", Offset = "0x66D6400", VA = "0x1866D7600")]
		internal void IIAJJJJPKCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const BPOEDDOJHLL KELMNOCKEAK = BPOEDDOJHLL.Cancelled | BPOEDDOJHLL.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly IHOHCHAHKKI JLCLFNHGOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] KKMEEBMKMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<BPOEDDOJHLL> NOBGBBLGFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> LFAKNALHDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> MCMLKPHNGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> NOBGLAANIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> FNLBKNCHNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> JGEPHMPEBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> ADEJIADKDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private DKMCGKONOBO[] KOGMMDGGBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private DCIBGNIIHOK[] FHEIJBNLOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private JHMNCBGMHEA[] NLHAIDBLHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<EFMJLGFKALI>[] OANEOJDCHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private EFMJLGFKALI[] KLNKBMFECFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int CEMMLHPEKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int IBODGIFCPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int OMLLNNICHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float CLNHNEOAJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private HFHAHFHKEPK HEADIMFLOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle AMFOFLDBDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<DKMCGKONOBO> FBIGFKKMEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool BIEKGIIHPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> DKMBAPJHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> MHCKFEACEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool JDHHNBHGPMC;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public BFGBKMHOPFN[] LNPGNBPCGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x995D10", Offset = "0x994B10", VA = "0x180995D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x66EECC0", Offset = "0x66EDAC0", VA = "0x1866EECC0")]
	private static int EJMFAAKHJIF(IHOHCHAHKKI JLCLFNHGOAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x66F07E0", Offset = "0x66EF5E0", VA = "0x1866F07E0")]
	public OJELJNCDBON(IHOHCHAHKKI JLCLFNHGOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x66EEAE0", Offset = "0x66ED8E0", VA = "0x1866EEAE0")]
	private void EGGEDBEPJGL(int MAJCHNEPGOI, int KBCLCFPDNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x66EE680", Offset = "0x66ED480", VA = "0x1866EE680")]
	public void CHAPOGLNCAJ(JHMNCBGMHEA BCCEHJNGNAL, EFMJLGFKALI JGGNBEIJADE, IEnumerator<EFMJLGFKALI> NKNFNCGJODD, DCIBGNIIHOK ENDOBNICGKI, [Optional] DKMCGKONOBO ACHLBLOMEHN, BPOEDDOJHLL JIALLCNJFCG = BPOEDDOJHLL.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x66F05A0", Offset = "0x66EF3A0", VA = "0x1866F05A0")]
	public void OGELPCMCEOG(IEnumerable<GKCDLBAFGLD> GPBPKHNGGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x66F0050", Offset = "0x66EEE50", VA = "0x1866F0050")]
	private GKCDLBAFGLD JKGGPCPNHOP(int FFAJOAIBFEE)
	{
		return default(GKCDLBAFGLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x66EF4B0", Offset = "0x66EE2B0", VA = "0x1866EF4B0")]
	private void GAAPKHOPPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x274E0C0", Offset = "0x274CEC0", VA = "0x18274E0C0")]
	private static void LODFIEOJKJF<T>(int FFAJOAIBFEE, T[] HPKDHFCPIJJ, int GENDLFFGOMM, [Optional] T MKHBMOPABDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x274E110", Offset = "0x274CF10", VA = "0x18274E110")]
	private static void LODFIEOJKJF<T>(int FFAJOAIBFEE, NativeArray<T> HPKDHFCPIJJ, int GENDLFFGOMM, [Optional] T MKHBMOPABDI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x66EFB80", Offset = "0x66EE980", VA = "0x1866EFB80")]
	private void HIADCCCGJGK(IEnumerable<GKCDLBAFGLD> GPBPKHNGGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x66EECF0", Offset = "0x66EDAF0", VA = "0x1866EECF0")]
	private void FLCMIOLHNOE(GKCDLBAFGLD HLCNNABHODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x66EF920", Offset = "0x66EE720", VA = "0x1866EF920")]
	private NGGNJKGNFFM HAPLEBBNMGE(int BAEMMGEAEII)
	{
		return default(NGGNJKGNFFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x66EE480", Offset = "0x66ED280", VA = "0x1866EE480")]
	public void AGBPMPPCGEO(float MJLIPMGCMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x66F0520", Offset = "0x66EF320", VA = "0x1866F0520")]
	private void LBKPIAIEDKA(Action OIPELOMOKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x66EEA60", Offset = "0x66ED860", VA = "0x1866EEA60")]
	private void DPKNPBGPGPP(Action OIPELOMOKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x66EEDB0", Offset = "0x66EDBB0", VA = "0x1866EEDB0")]
	public void FPKCAHNOBJH(float MJLIPMGCMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x66EF820", Offset = "0x66EE620", VA = "0x1866EF820")]
	public void GDLOLPODHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x66EE930", Offset = "0x66ED730", VA = "0x1866EE930")]
	public void DOGHBEGILBC(DKMCGKONOBO DPOLHMMHBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x66EFF20", Offset = "0x66EED20", VA = "0x1866EFF20")]
	public void JHOPHAEGBBL(DKMCGKONOBO DPOLHMMHBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x66EE800", Offset = "0x66ED600", VA = "0x1866EE800")]
	public void CLNKOLBCGEP(DKMCGKONOBO DPOLHMMHBFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class CMOAHKGDFDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly CMOAHKGDFDP CABPEDJKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action FOFIEAHFHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool FHCLJNNFIBK;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x791D40", Offset = "0x790B40", VA = "0x180791D40")]
	public CMOAHKGDFDP(Action FOFIEAHFHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x605D470", Offset = "0x605C270", VA = "0x18605D470", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface OIFNGJDGAFB<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T AOJPLLHPPML
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable GBMBAOPOMAL(UnityEngine.Object BCCEHJNGNAL, Action<T> LMMBDHKNLEJ);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface CLPFFFAOLDP<T> : OIFNGJDGAFB<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T AOJPLLHPPML
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class BLOIJOHJHBD<T> : CLPFFFAOLDP<T>, OIFNGJDGAFB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class FNAPIAMJLPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public BLOIJOHJHBD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public GMBHMAMMDKO<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public FNAPIAMJLPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3622100", Offset = "0x3620F00", VA = "0x183622100")]
		internal void OEKIKJOKNAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject OGJDFEADKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<GMBHMAMMDKO<UnityEngine.Object, Action<T>>> AAICJEOCMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T IJOBNPFKJCA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T AOJPLLHPPML
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x814B60", Offset = "0x813960", VA = "0x180814B60", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x46AD8A0", Offset = "0x46AC6A0", VA = "0x1846AD8A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x46AE320", Offset = "0x46AD120", VA = "0x1846AE320")]
	private static bool LIEHIKMCJDG(T OIPELOMOKGO, T BJNEJGMGENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x46AE420", Offset = "0x46AD220", VA = "0x1846AE420")]
	public BLOIJOHJHBD(T EBEJIJCLFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x46ADB30", Offset = "0x46AC930", VA = "0x1846ADB30", Slot = "6")]
	public IDisposable GBMBAOPOMAL(UnityEngine.Object BCCEHJNGNAL, Action<T> LMMBDHKNLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x46ADFF0", Offset = "0x46ACDF0", VA = "0x1846ADFF0")]
	private void GKPKFOHMMEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class HAPPGNOCNKA : EHNLOIECGKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly CPDGLAMKFGL PMMBPEAJBAM;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x66E4360", Offset = "0x66E3160", VA = "0x1866E4360")]
	[OKINHFAHPEJ(FNGNILODNLI.None)]
	private static void PNHDBAMNBDO(LPFNGCMIAEC KDNLDLIFDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x791D40", Offset = "0x790B40", VA = "0x180791D40")]
	[Preserve]
	internal HAPPGNOCNKA([MCCEMKLKAEE(null)] CPDGLAMKFGL PMMBPEAJBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x66E42B0", Offset = "0x66E30B0", VA = "0x1866E42B0", Slot = "4")]
	public IDisposable JFPLBGPOMPB(float MILJELIDHON, Action<float> EAGOMMNFHFH, bool CDIEDHJKFHG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class JOAGNADEDFC : BEDGJAHOJOI, CPDGLAMKFGL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private OJELJNCDBON[] APDGKFAIJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private KLJLJKFCDAM KJBLIAOJHEL;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x66E8AB0", Offset = "0x66E78B0", VA = "0x1866E8AB0")]
	[OKINHFAHPEJ(FNGNILODNLI.None)]
	private static void PNHDBAMNBDO(LPFNGCMIAEC KDNLDLIFDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x66E8B20", Offset = "0x66E7920", VA = "0x1866E8B20")]
	[Preserve]
	public JOAGNADEDFC([MCCEMKLKAEE(null)] PIPKIFDPMAE MFMKMBGOMBL, [MCCEMKLKAEE(null)] FMIGPAOMIEK AGBNJCONBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x66E8750", Offset = "0x66E7550", VA = "0x1866E8750", Slot = "16")]
	public override KPDMKFJCEFL LLAFDOEPCPB(JHMNCBGMHEA BCCEHJNGNAL, IEnumerator<EFMJLGFKALI> CFKAOIOCAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x66E8370", Offset = "0x66E7170", VA = "0x1866E8370", Slot = "17")]
	public override void KGLPDGAIIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x66E7F50", Offset = "0x66E6D50", VA = "0x1866E7F50", Slot = "19")]
	public override void GIDHBODMCBG(IHOHCHAHKKI JLCLFNHGOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x66E8200", Offset = "0x66E7000", VA = "0x1866E8200", Slot = "18")]
	protected override void KBHDIJCCCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x66E8720", Offset = "0x66E7520", VA = "0x1866E8720")]
	private OJELJNCDBON LELCMMEEEAP(IHOHCHAHKKI HJCFEPLFGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x66E8880", Offset = "0x66E7680", VA = "0x1866E8880", Slot = "20")]
	internal override OEGHAHOECIJ NMCEDEHANIB(IEnumerator<EFMJLGFKALI> CFKAOIOCAJO, Behaviour BCCEHJNGNAL, DCIBGNIIHOK ENDOBNICGKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x66E8180", Offset = "0x66E6F80", VA = "0x1866E8180", Slot = "21")]
	internal override KELKFEKMIOJ HMMCFFLDOHB(IHOHCHAHKKI DKBGJFLJOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x66E8600", Offset = "0x66E7400", VA = "0x1866E8600")]
	private void KLPDBLBCPKD(OJELJNCDBON MBJKFHDONFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x66E7EF0", Offset = "0x66E6CF0", VA = "0x1866E7EF0", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct HFHAHFHKEPK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float GCDDCLIMICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int DOINPIODICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> GCELEDJJNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> KAFLFHHFEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> EPDNAFAAHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<BPOEDDOJHLL> BEABHBEMGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> DNLLHFLNHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> FNLBKNCHNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> MCMLKPHNGIK;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x66E4730", Offset = "0x66E3530", VA = "0x1866E4730")]
	public static HFHAHFHKEPK KCGHAKHJLMB(int MBGMOHFHKBL, float MJLIPMGCMFA, NativeArray<BPOEDDOJHLL> PGIJCLJICJH, NativeArray<float> BLGMOMFGBEA, NativeArray<int> HGCODEIKGHN, NativeArray<int> JIAOBDLPMAB, NativeArray<int> JOKAHKKFLGO, NativeArray<int> KAFLFHHFEPJ, NativeArray<int> EPDNAFAAHCK)
	{
		return default(HFHAHFHKEPK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x66E4650", Offset = "0x66E3450", VA = "0x1866E4650", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x66E4610", Offset = "0x66E3410", VA = "0x1866E4610")]
	private bool ELKMPJFFGFN(int HPLKFBKKIBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x66E4790", Offset = "0x66E3590", VA = "0x1866E4790")]
	private void LHDOJBGOGCG(NativeArray<int> AOLOLCLABDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x66E47C0", Offset = "0x66E35C0", VA = "0x1866E47C0")]
	private int NDIGGJOOPBM(int IKGGOMMIHJH, int FIAEJIIICNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x66E4860", Offset = "0x66E3660", VA = "0x1866E4860")]
	private void NGIBKBEILND(NativeArray<int> AOLOLCLABDH, int BEJGJFIIJND, int CBMBPKNBJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x66E43D0", Offset = "0x66E31D0", VA = "0x1866E43D0")]
	private void CEDBKGMEADL(NativeArray<int> AOLOLCLABDH, int KOEKEABEBOI, int IPPNKABHAPE, int ADLLANCENHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class BEDGJAHOJOI : CPDGLAMKFGL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly PIPKIFDPMAE MFMKMBGOMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly FMIGPAOMIEK AGBNJCONBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private KELKFEKMIOJ[] ACKJKPAMAJB;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static CPDGLAMKFGL CEIKCOHBGGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x66D8540", Offset = "0x66D7340", VA = "0x1866D8540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool GFKJDIILPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7A9270", Offset = "0x7A8070", VA = "0x1807A9270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IHOHCHAHKKI CGDOPCLGANF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x78D180", Offset = "0x78BF80", VA = "0x18078D180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(IHOHCHAHKKI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x797AF0", Offset = "0x7968F0", VA = "0x180797AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public FMIGPAOMIEK KDMCDFOLJED
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public EFMJLGFKALI ACOOCDJFONB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x78E270", Offset = "0x78D070", VA = "0x18078E270", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x66D8AD0", Offset = "0x66D78D0", VA = "0x1866D8AD0")]
	public static KPDMKFJCEFL ONCFAPLJGBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x66D8D50", Offset = "0x66D7B50", VA = "0x1866D8D50")]
	[Preserve]
	protected BEDGJAHOJOI([MCCEMKLKAEE(null)] PIPKIFDPMAE MFMKMBGOMBL, [MCCEMKLKAEE(null)] FMIGPAOMIEK AGBNJCONBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x66D8660", Offset = "0x66D7460", VA = "0x1866D8660", Slot = "6")]
	public KPDMKFJCEFL JFFCJICJDBP(IEnumerator<EFMJLGFKALI> CFKAOIOCAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x66D8670", Offset = "0x66D7470", VA = "0x1866D8670", Slot = "7")]
	public KPDMKFJCEFL JFFCJICJDBP(Behaviour BCCEHJNGNAL, IEnumerator<EFMJLGFKALI> CFKAOIOCAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract KPDMKFJCEFL LLAFDOEPCPB(JHMNCBGMHEA BCCEHJNGNAL, IEnumerator<EFMJLGFKALI> CFKAOIOCAJO);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x66D8890", Offset = "0x66D7690", VA = "0x1866D8890", Slot = "17")]
	public virtual void KGLPDGAIIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x66D7E10", Offset = "0x66D6C10", VA = "0x1866D7E10", Slot = "9")]
	public void BBJMMFCHHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x66D8870", Offset = "0x66D7670", VA = "0x1866D8870", Slot = "18")]
	protected virtual void KBHDIJCCCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x66D8A30", Offset = "0x66D7830", VA = "0x1866D8A30")]
	private void MMEPOOLMFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x66D8A50", Offset = "0x66D7850", VA = "0x1866D8A50")]
	private void MMOGBEGAFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x66D8B60", Offset = "0x66D7960", VA = "0x1866D8B60")]
	private void ONLBGOJJDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x66D8620", Offset = "0x66D7420", VA = "0x1866D8620")]
	private void HLONJMJGPKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x66D8050", Offset = "0x66D6E50", VA = "0x1866D8050")]
	private void BEPMNONMKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x66D8640", Offset = "0x66D7440", VA = "0x1866D8640")]
	private void JBKDLCKPJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x66D80D0", Offset = "0x66D6ED0", VA = "0x1866D80D0")]
	private void DIMNINOODEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x66D8590", Offset = "0x66D7390", VA = "0x1866D8590", Slot = "19")]
	public virtual void GIDHBODMCBG(IHOHCHAHKKI JLCLFNHGOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x66D8B80", Offset = "0x66D7980", VA = "0x1866D8B80")]
	private void PKGBMDKCHJB(KELKFEKMIOJ MBJKFHDONFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1C3CDF0", Offset = "0x1C3BBF0", VA = "0x181C3CDF0")]
	private KELKFEKMIOJ KPOLEBFHEOI(IHOHCHAHKKI HJCFEPLFGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract OEGHAHOECIJ NMCEDEHANIB(IEnumerator<EFMJLGFKALI> CFKAOIOCAJO, Behaviour ELCNNAHJPKC, DCIBGNIIHOK LJFKMAGGJJH);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract KELKFEKMIOJ HMMCFFLDOHB(IHOHCHAHKKI JLCLFNHGOAK);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x66D8180", Offset = "0x66D6F80", VA = "0x1866D8180", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x66D8A70", Offset = "0x66D7870", VA = "0x1866D8A70", Slot = "12")]
	public EFMJLGFKALI NCDMEDCEBPL(IHOHCHAHKKI DKBGJFLJOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x66D80F0", Offset = "0x66D6EF0", VA = "0x1866D80F0", Slot = "13")]
	public EFMJLGFKALI DKIFCAOBCNB(float JILOLFHINNI, IHOHCHAHKKI DKBGJFLJOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x66D8070", Offset = "0x66D6E70", VA = "0x1866D8070", Slot = "14")]
	public EFMJLGFKALI CGPDPBFJOFG(Func<bool> HHNPNNJCGFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class OEGHAHOECIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly DCIBGNIIHOK ENDOBNICGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly LDGNGCEHPDH BCCEHJNGNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool KKAGLPPJIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string AOAIBMOPKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private StackTrace DOPKLCALBNL;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<EFMJLGFKALI> LGOMLPNNNHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x78E1A0", Offset = "0x78CFA0", VA = "0x18078E1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EFMJLGFKALI HOPABNMLOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x78DFC0", Offset = "0x78CDC0", VA = "0x18078DFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool KAJPKMHKBFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x66ECCA0", Offset = "0x66EBAA0", VA = "0x1866ECCA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool HJPAEMPDIJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x804710", Offset = "0x803510", VA = "0x180804710")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x804720", Offset = "0x803520", VA = "0x180804720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string BAAGNNPAEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x66ED0A0", Offset = "0x66EBEA0", VA = "0x1866ED0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float EGCAKIFEIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x1065580", Offset = "0x1064380", VA = "0x181065580")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x56016C0", Offset = "0x56004C0", VA = "0x1856016C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x66ED330", Offset = "0x66EC130", VA = "0x1866ED330")]
	public OEGHAHOECIJ(IEnumerator<EFMJLGFKALI> NKNFNCGJODD, LDGNGCEHPDH BCCEHJNGNAL, DCIBGNIIHOK ENDOBNICGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x66ECD90", Offset = "0x66EBB90", VA = "0x1866ECD90")]
	public EFMJLGFKALI IKFNNAOPPFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x66ECD20", Offset = "0x66EBB20", VA = "0x1866ECD20")]
	public bool IKBPGPGALND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x66ECC50", Offset = "0x66EBA50", VA = "0x1866ECC50")]
	public void DOGHBEGILBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x66ED250", Offset = "0x66EC050", VA = "0x1866ED250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x88C9D0", Offset = "0x88B7D0", VA = "0x18088C9D0")]
	[CompilerGenerated]
	private void IFDHIAMMKJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class DCIBGNIIHOK : KIBLLHKNNIC, KPDMKFJCEFL, MJDAGPPLDNE, PCFNKHPOHAG, IEnumerator, EFMJLGFKALI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private IHOHCHAHKKI KLCNDAHLCOM;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private IHOHCHAHKKI JIDMEAPNFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xDE2D00", Offset = "0xDE1B00", VA = "0x180DE2D00", Slot = "23")]
		get
		{
			return default(IHOHCHAHKKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IHOHCHAHKKI AGAPMEHJIBF
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x12E4090", Offset = "0x12E2E90", VA = "0x1812E4090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float NLCADNKFOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7E0BB0", Offset = "0x7DF9B0", VA = "0x1807E0BB0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool LJKMGOAPMHA
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x66DF650", Offset = "0x66DE450", VA = "0x1866DF650", Slot = "24")]
	private bool NOOMHFFDOPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x66DF640", Offset = "0x66DE440", VA = "0x1866DF640", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x66DF670", Offset = "0x66DE470", VA = "0x1866DF670")]
	public DCIBGNIIHOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum NGGNJKGNFFM : byte
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
internal sealed class KELKFEKMIOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum MKAKIGIMEEN
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct NDPMDJAHGMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public IHOHCHAHKKI JODJMEHAHEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public MKAKIGIMEEN LGEDLBKIFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public List<OEGHAHOECIJ> CPBHMIOGKON;
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly MKAKIGIMEEN[] LOCKJIPDEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly IHOHCHAHKKI JLCLFNHGOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private bool LOHCADIALOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly OEGHAHOECIJ[] EAPDOKIAKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<OEGHAHOECIJ> GGEEKABMPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> CEADHBHEHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<OEGHAHOECIJ> MCGHIFKMJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<int> IFBINIPDBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly KLJLJKFCDAM DMDFMDCIIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private bool JDHHNBHGPMC;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NDPMDJAHGMJ[,] HNLNDLPHFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x78E0D0", Offset = "0x78CED0", VA = "0x18078E0D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x66EA400", Offset = "0x66E9200", VA = "0x1866EA400")]
	public KELKFEKMIOJ(IHOHCHAHKKI DKBGJFLJOJP, KLJLJKFCDAM DMDFMDCIIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x66E9A40", Offset = "0x66E8840", VA = "0x1866E9A40")]
	public void IIFCOGDEBKJ(OEGHAHOECIJ NKNFNCGJODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x66E95F0", Offset = "0x66E83F0", VA = "0x1866E95F0")]
	public void GHOGKGNLMCK(IList<OEGHAHOECIJ> GPPKCMIOEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x66E90D0", Offset = "0x66E7ED0", VA = "0x1866E90D0")]
	public void BMCHFBCLBFB(IList<OEGHAHOECIJ> GPPKCMIOEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x66E93E0", Offset = "0x66E81E0", VA = "0x1866E93E0")]
	private void DGAFDCFMIOF(OEGHAHOECIJ NKNFNCGJODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x66EA130", Offset = "0x66E8F30", VA = "0x1866EA130")]
	private void NBJHFNAAGEN(IList<OEGHAHOECIJ> GPPKCMIOEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x66E9FB0", Offset = "0x66E8DB0", VA = "0x1866E9FB0")]
	private NGGNJKGNFFM MKIAIJMPLML(OEGHAHOECIJ NKNFNCGJODD)
	{
		return default(NGGNJKGNFFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x66E9B40", Offset = "0x66E8940", VA = "0x1866E9B40")]
	public void KBHDIJCCCPP(float MJLIPMGCMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x66E8EE0", Offset = "0x66E7CE0", VA = "0x1866E8EE0")]
	public void BBJMMFCHHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x66E9CB0", Offset = "0x66E8AB0", VA = "0x1866E9CB0")]
	private void LADGKNMINNM(List<OEGHAHOECIJ> GPPKCMIOEAO, Stack<int> HHNGJGBEBLD, bool FHPIDIFIJBL, float AGPEJLEGACN = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x66E94D0", Offset = "0x66E82D0", VA = "0x1866E94D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x66E9900", Offset = "0x66E8700", VA = "0x1866E9900")]
	private void HJENGJCHIAI(List<OEGHAHOECIJ> GPPKCMIOEAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class FONLJBBFPEA : KLJLJKFCDAM
{
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "4")]
	public void NBDNNICIECL(string AOAIBMOPKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
	public void EHIGCNAFLPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public FONLJBBFPEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class APBAENPAPJB : LDGNGCEHPDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Behaviour ELCNNAHJPKC;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string BAAGNNPAEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x66D76E0", Offset = "0x66D64E0", VA = "0x1866D76E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool DABADEKAIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x66D7670", Offset = "0x66D6470", VA = "0x1866D7670", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool MINCHLKLAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x66D76C0", Offset = "0x66D64C0", VA = "0x1866D76C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x791D40", Offset = "0x790B40", VA = "0x180791D40")]
	public APBAENPAPJB(Behaviour ELCNNAHJPKC)
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

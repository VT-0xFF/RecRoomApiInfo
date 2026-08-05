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
public class NBBDKPKLKBH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority GNLIANLCCOM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x650A6E0", Offset = "0x65092E0", VA = "0x18650A6E0")]
	public NBBDKPKLKBH(ThreadPriority KNAODNCOIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x650A6D0", Offset = "0x65092D0", VA = "0x18650A6D0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> OCNCJDLJICA(List<PlayerLoopSystem> BMAEGIJCBDA, int CNMOBCKBFGJ);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct JIDFPINECLK
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct NCCKMCJJAFP
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static NGHNHLLDGBJ OEMIFHFLHOK;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x650A720", Offset = "0x6509320", VA = "0x18650A720")]
				public static PlayerLoopSystem IHMPPENHJND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct ELNHBAKKKCJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static NGHNHLLDGBJ OFPHAKNNMLP;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x64FF120", Offset = "0x64FDD20", VA = "0x1864FF120")]
				public static PlayerLoopSystem IHMPPENHJND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct BLNDJIHIALA
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static NGHNHLLDGBJ INLDOIELEIA;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x64F6E40", Offset = "0x64F5A40", VA = "0x1864F6E40")]
				public static PlayerLoopSystem IHMPPENHJND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct NMMGAGOFHIO
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static NGHNHLLDGBJ LKGJGKGDBJK;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static NGHNHLLDGBJ AKJJHCMBPPF;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static NGHNHLLDGBJ ILDDHIALOCM;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static NGHNHLLDGBJ KFODCOHBJBP;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x650AFF0", Offset = "0x6509BF0", VA = "0x18650AFF0")]
				public static PlayerLoopSystem IHMPPENHJND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct KELLLEJHJFP
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static NGHNHLLDGBJ AHAPFKACKHN;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x65070C0", Offset = "0x6505CC0", VA = "0x1865070C0")]
				public static PlayerLoopSystem IHMPPENHJND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct OJLKOIKJGIL
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static NGHNHLLDGBJ LKGJGKGDBJK;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static NGHNHLLDGBJ AKJJHCMBPPF;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static NGHNHLLDGBJ ILDDHIALOCM;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static NGHNHLLDGBJ KFODCOHBJBP;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x650D880", Offset = "0x650C480", VA = "0x18650D880")]
				public static PlayerLoopSystem IHMPPENHJND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct JBKJNOLGIDN
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static NGHNHLLDGBJ GHKMIALKFOI;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x6506360", Offset = "0x6504F60", VA = "0x186506360")]
				public static PlayerLoopSystem IHMPPENHJND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct JFCEBBHPKIH
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static NGHNHLLDGBJ ONPCEADGMAL;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x65066F0", Offset = "0x65052F0", VA = "0x1865066F0")]
				public static PlayerLoopSystem IHMPPENHJND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct GADDLKEAMGI
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static NGHNHLLDGBJ IEKACCLFKOP;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x65028E0", Offset = "0x65014E0", VA = "0x1865028E0")]
				public static PlayerLoopSystem IHMPPENHJND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct KAOPOKOGDKB
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static NGHNHLLDGBJ LHGILENGMHF;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6506EC0", Offset = "0x6505AC0", VA = "0x186506EC0")]
				public static PlayerLoopSystem IHMPPENHJND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct LJOFKEILNJP
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static NGHNHLLDGBJ HHBCHLCGFEE;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x6509420", Offset = "0x6508020", VA = "0x186509420")]
				public static PlayerLoopSystem IHMPPENHJND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct ONPCNJCFJEN
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static NGHNHLLDGBJ KCJENJCPOED;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x650FC60", Offset = "0x650E860", VA = "0x18650FC60")]
				public static PlayerLoopSystem IHMPPENHJND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum LOLDKBNAHLG : byte
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
			public struct NIMJGANJIBA
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class OMBNFGLJNLA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public LOLDKBNAHLG updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
					public OMBNFGLJNLA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x650FBE0", Offset = "0x650E7E0", VA = "0x18650FBE0")]
					internal void JHBKBPLAAHD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static LBFCDLOMLLJ<LOLDKBNAHLG> DCPNJOOGLJK;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x650A980", Offset = "0x6509580", VA = "0x18650A980")]
				public static PlayerLoopSystem IHMPPENHJND(LOLDKBNAHLG MAKILLDHEKF)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct EFOHCCBINPH
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class JLKPPMLFEIP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public NPFBMADIIPK.LICODONEFDE key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
					public JLKPPMLFEIP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6506A10", Offset = "0x6505610", VA = "0x186506A10")]
					internal void PHKCEPFLLMF()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable LFMEENAPNFO;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x64FE510", Offset = "0x64FD110", VA = "0x1864FE510")]
				public static PlayerLoopSystem BGDKNBMNJJO(NPFBMADIIPK.LICODONEFDE PPNDANAOAMK)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct INHHONGKGAH
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class EHJFOPDPIEG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public NPFBMADIIPK.LICODONEFDE key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
					public EHJFOPDPIEG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x64FE9C0", Offset = "0x64FD5C0", VA = "0x1864FE9C0")]
					internal void PHKCEPFLLMF()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x6506230", Offset = "0x6504E30", VA = "0x186506230")]
				public static PlayerLoopSystem BGDKNBMNJJO(NPFBMADIIPK.LICODONEFDE PPNDANAOAMK)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class JHFPLCLHAIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public JHFPLCLHAIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x65068F0", Offset = "0x65054F0", VA = "0x1865068F0")]
			internal List<PlayerLoopSystem> CMCMDEMKKBJ(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool PMMIMMAFNMN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool HPJGPPDNELM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x64F9540", Offset = "0x64F8140", VA = "0x1864F9540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64F9580", Offset = "0x64F8180", VA = "0x1864F9580")]
		private static void GFCIGKCIMKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64FC1A0", Offset = "0x64FADA0", VA = "0x1864FC1A0")]
		private static void PDLLMBDJPIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64F8F30", Offset = "0x64F7B30", VA = "0x1864F8F30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64FBEB0", Offset = "0x64FAAB0", VA = "0x1864FBEB0")]
		private static void KJBIIGELHJM(NPFBMADIIPK.LICODONEFDE PPNDANAOAMK, PlayerLoopSystem OBHHECFDCBJ, Type JACICKIIBNN, Type NDGLEGCCEIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64F9160", Offset = "0x64F7D60", VA = "0x1864F9160")]
		private static void CGANKCPGCOD(PlayerLoopSystem OBHHECFDCBJ, Type JACICKIIBNN, Type NDGLEGCCEIB, OCNCJDLJICA IHKGBOEDBKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64FC070", Offset = "0x64FAC70", VA = "0x1864FC070")]
		private static void MFJJJGDKDMF(PlayerLoopSystem OBHHECFDCBJ, Type JACICKIIBNN, Type NDGLEGCCEIB, PlayerLoopSystem? PFMLOKHINPK, PlayerLoopSystem? KCDDCCPNIAL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class NPFBMADIIPK
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum LICODONEFDE
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
	public class EIAMDBNJBIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly LICODONEFDE KOILFEPDLLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly COCHONPIIMJ NEJJECJDOOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long AMAMJACJPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long AJDCOEEDAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long EGKKEHBIODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int FLJPBKJOBMK;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x64FEED0", Offset = "0x64FDAD0", VA = "0x1864FEED0")]
		public EIAMDBNJBIM(LICODONEFDE JDJCOLBMMMI, int NAFKPBONEMK = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64FEE60", Offset = "0x64FDA60", VA = "0x1864FEE60")]
		public void FGLOODEMKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64FEE10", Offset = "0x64FDA10", VA = "0x1864FEE10")]
		public void FDFIADLCGPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x64FEC30", Offset = "0x64FD830", VA = "0x1864FEC30")]
		public void COCBHFMLPPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static LICODONEFDE[] FEBILHPNMFG;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static EIAMDBNJBIM[] ELFFNOIHGMP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x650CC60", Offset = "0x650B860", VA = "0x18650CC60")]
	public static EIAMDBNJBIM EDHGPPPOLBJ(LICODONEFDE PPNDANAOAMK, int NAFKPBONEMK = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x650CBF0", Offset = "0x650B7F0", VA = "0x18650CBF0")]
	public static EIAMDBNJBIM AAJFHEONFJF(LICODONEFDE PPNDANAOAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x650CE40", Offset = "0x650BA40", VA = "0x18650CE40")]
	public static void LNDJIOJGJGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class COCHONPIIMJ : CPMLEDDNOJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int DNMMMOGKFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> OHKHGPKNKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double LEGCGEBFEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double NHPFEEAIFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double HAKHGAGHLDF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double HEPNENLNJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x64F8D00", Offset = "0x64F7900", VA = "0x1864F8D00", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double BIHAOLDIKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x16F37C0", Offset = "0x16F23C0", VA = "0x1816F37C0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double PHOJMIEKCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1C96930", Offset = "0x1C95530", VA = "0x181C96930", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x64F8E80", Offset = "0x64F7A80", VA = "0x1864F8E80")]
	public COCHONPIIMJ(int KHAHMFGFOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x64F8D60", Offset = "0x64F7960", VA = "0x1864F8D60", Slot = "7")]
	public void PCMHIIGLNJL(double FEGNLFKFNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x64F8C90", Offset = "0x64F7890", VA = "0x1864F8C90", Slot = "8")]
	public void GPJBDIFOFCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class DJPIHECLLPM : CPMLEDDNOJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long EMHEDPDPEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double PEJJDIDGLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double NLCGIBNNOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double ICPGPAJBLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double PCGLIPBEAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double LEGCGEBFEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double NHPFEEAIFCM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double BIHAOLDIKPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x54AA1D0", Offset = "0x54A8DD0", VA = "0x1854AA1D0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double PHOJMIEKCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x54AA1E0", Offset = "0x54A8DE0", VA = "0x1854AA1E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double CGBIPGPBHLI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x54AA220", Offset = "0x54A8E20", VA = "0x1854AA220")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double HEPNENLNJLB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x20A1840", Offset = "0x20A0440", VA = "0x1820A1840", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x64FDD40", Offset = "0x64FC940", VA = "0x1864FDD40", Slot = "7")]
	public virtual void PCMHIIGLNJL(double FEGNLFKFNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x64FDD00", Offset = "0x64FC900", VA = "0x1864FDD00", Slot = "8")]
	public virtual void GPJBDIFOFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x64FDE60", Offset = "0x64FCA60", VA = "0x1864FDE60")]
	public DJPIHECLLPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class HNCPLDAINLH : DJPIHECLLPM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double HEPMPHFONDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x54AA190", Offset = "0x54A8D90", VA = "0x1854AA190")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x54AA1F0", Offset = "0x54A8DF0", VA = "0x1854AA1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6504020", Offset = "0x6502C20", VA = "0x186504020", Slot = "7")]
	public override void PCMHIIGLNJL(double FEGNLFKFNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6503FE0", Offset = "0x6502BE0", VA = "0x186503FE0", Slot = "8")]
	public override void GPJBDIFOFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x64FDE60", Offset = "0x64FCA60", VA = "0x1864FDE60")]
	public HNCPLDAINLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface CPMLEDDNOJF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double HEPNENLNJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double BIHAOLDIKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double PHOJMIEKCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class OCHFPHCOCOM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface BHJLDIKEGMI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool LGBMKJOOGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ENMBELGAIGO();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class NFKGPCNIFIO<TPromise, TMainThreadPromise> : BHJLDIKEGMI where TPromise : CKPENFELBCE where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise KGEPMDDGDNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise KNHBHMPFHIC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise FOIGNOBPINA
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x3D14050", Offset = "0x3D12C50", VA = "0x183D14050")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool LGBMKJOOGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3D140D0", Offset = "0x3D12CD0", VA = "0x183D140D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x775A60", Offset = "0x774660", VA = "0x180775A60")]
		protected NFKGPCNIFIO(TPromise KGEPMDDGDNL, TMainThreadPromise LLBACJMBBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3D140B0", Offset = "0x3D12CB0", VA = "0x183D140B0", Slot = "5")]
		public void ENMBELGAIGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void BBOLKGLKAND(TPromise KGEPMDDGDNL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class IDCCKJGBENO<T> : NFKGPCNIFIO<HPJLJGHAIKN<T>, KNCNIEDDCNP<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x370FC20", Offset = "0x370E820", VA = "0x18370FC20")]
		public IDCCKJGBENO(HPJLJGHAIKN<T> KGEPMDDGDNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x370FA70", Offset = "0x370E670", VA = "0x18370FA70", Slot = "6")]
		protected override void BBOLKGLKAND(HPJLJGHAIKN<T> KGEPMDDGDNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x370FBF0", Offset = "0x370E7F0", VA = "0x18370FBF0")]
		[CompilerGenerated]
		private void NNIFKJCDNCF(T HNCONAMCFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x370FBC0", Offset = "0x370E7C0", VA = "0x18370FBC0")]
		[CompilerGenerated]
		private void LNMPMGBKEAE(string GNLAGDDNMDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class HGHCOAKCOAP : BHJLDIKEGMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action GAFABDCELFL;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool LGBMKJOOGCG
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x78C390", Offset = "0x78AF90", VA = "0x18078C390", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
		public HGHCOAKCOAP(Action GAFABDCELFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB60E70", Offset = "0xB5FA70", VA = "0x180B60E70", Slot = "5")]
		public void ENMBELGAIGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<BHJLDIKEGMI> NFNJOAPNGII;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x26411C0", Offset = "0x263FDC0", VA = "0x1826411C0")]
	public static HPJLJGHAIKN<T> CHKHEOKMPLI<T>(this HPJLJGHAIKN<T> KGEPMDDGDNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x650D080", Offset = "0x650BC80", VA = "0x18650D080")]
	public static void CHKHEOKMPLI(Action GAFABDCELFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2641220", Offset = "0x263FE20", VA = "0x182641220")]
	private static HPJLJGHAIKN<T> LHKNLIKMGBG<T>(HPJLJGHAIKN<T> KGEPMDDGDNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x650D5E0", Offset = "0x650C1E0", VA = "0x18650D5E0")]
	private static void MOPPJCCGAAC(BHJLDIKEGMI MOIKCCHFFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x650D200", Offset = "0x650BE00", VA = "0x18650D200")]
	private static void CPMDNEHBFMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x650D4E0", Offset = "0x650C0E0", VA = "0x18650D4E0")]
	private static void FJMCNFODABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x650D120", Offset = "0x650BD20", VA = "0x18650D120")]
	private static void CHLJCLMIKAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NNGICCPJAOL
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct DPIBLFCKMMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> KALLEBEIFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string AEGJFANOGND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode KBLMDIMGMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool HJGBGLLLDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x64FE480", Offset = "0x64FD080", VA = "0x1864FE480")]
		public DPIBLFCKMMP(TaskCompletionSource<Scene> ENLKJJMCJCI, string AEGJFANOGND, LoadSceneMode KBLMDIMGMIA, bool HJGBGLLLDNP, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct HLKBBLLMAFI : IAsyncStateMachine
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
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private FIKFBEICCGA<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x65036D0", Offset = "0x65022D0", VA = "0x1865036D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6503F70", Offset = "0x6502B70", VA = "0x186503F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct EGIBDAOIEEF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x64FE640", Offset = "0x64FD240", VA = "0x1864FE640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x64FE960", Offset = "0x64FD560", VA = "0x1864FE960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct NLCOGODJDMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private DPIBLFCKMMP <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x650ABE0", Offset = "0x65097E0", VA = "0x18650ABE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x650AF90", Offset = "0x6509B90", VA = "0x18650AF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class NGCFPHDOODN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KNCNIEDDCNP<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public NGCFPHDOODN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x650A920", Offset = "0x6509520", VA = "0x18650A920")]
		internal void CBPKMCNCCMH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct BOFGNHNPKLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

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
		private NGCFPHDOODN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x64F7040", Offset = "0x64F5C40", VA = "0x1864F7040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x64F7BE0", Offset = "0x64F67E0", VA = "0x1864F7BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MOIMCENJFMI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x650A150", Offset = "0x6508D50", VA = "0x18650A150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x650A660", Offset = "0x6509260", VA = "0x18650A660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct AMFMIDLMELM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public FIKFBEICCGA<string>.DJKJOCCHFDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private FIKFBEICCGA<string>.DJKJOCCHFDH <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x64F6250", Offset = "0x64F4E50", VA = "0x1864F6250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x64F6DA0", Offset = "0x64F59A0", VA = "0x1864F6DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class APJOJNCLGLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public APJOJNCLGLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x64F6E10", Offset = "0x64F5A10", VA = "0x1864F6E10")]
		internal bool ELGHPEEPKLK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class MFNHIJMNMMF : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private MJMKCFLBGFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public EEHJIENCILF onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public MFNHIJMNMMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6509BF0", Offset = "0x65087F0", VA = "0x186509BF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6509860", Offset = "0x6508460", VA = "0x186509860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6509810", Offset = "0x6508410", VA = "0x186509810")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6509BA0", Offset = "0x65087A0", VA = "0x186509BA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class LIPBEMGBBEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public KNCNIEDDCNP<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public LIPBEMGBBEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6509120", Offset = "0x6507D20", VA = "0x186509120")]
		internal bool GFMLALAGLEO(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x65091A0", Offset = "0x6507DA0", VA = "0x1865091A0")]
		internal void JLKDJJMPJLD(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class CBONMGGPMMG : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private MJMKCFLBGFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public KNCNIEDDCNP<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private LIPBEMGBBEG <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public CBONMGGPMMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x64F7D40", Offset = "0x64F6940", VA = "0x1864F7D40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x64F8450", Offset = "0x64F7050", VA = "0x1864F8450", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> PDPNNKKBAIK;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static CKPENFELBCE BHBNIPKOBEF;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation MICOCONKKHE;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static CKPENFELBCE OHADBPCBMMF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string NKJAGPFAJBE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority HMAGFAGDPGL;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task BCCHAOIJPNH;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> CNOHBGDINGC;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<DPIBLFCKMMP> JALNKPKJIKC;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task KCHLCGLGLMB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool PKINGHCEAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x650BDD0", Offset = "0x650A9D0", VA = "0x18650BDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool EBIBGGIOPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x650C8B0", Offset = "0x650B4B0", VA = "0x18650C8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool DPPMICCLCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x650C470", Offset = "0x650B070", VA = "0x18650C470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool PEDMODBBGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x650B4F0", Offset = "0x650A0F0", VA = "0x18650B4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> KEBNKECBEAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x650C6B0", Offset = "0x650B2B0", VA = "0x18650C6B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x650C5A0", Offset = "0x650B1A0", VA = "0x18650C5A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x650BCD0", Offset = "0x650A8D0", VA = "0x18650BCD0")]
	[HOLDLPLBEIB(FCMNCHNNIBN.EnteredEditModeNextFrame, 0)]
	private static void HMCKLOGDGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x650B2E0", Offset = "0x6509EE0", VA = "0x18650B2E0")]
	[AsyncStateMachine(typeof(HLKBBLLMAFI))]
	public static Task<Scene> BDAHJPDIAJF(string AEGJFANOGND, LoadSceneMode KBLMDIMGMIA = LoadSceneMode.Single, bool HJGBGLLLDNP = false, [Optional] FIKFBEICCGA<string>.DJKJOCCHFDH CCDPNGCCOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x650C950", Offset = "0x650B550", VA = "0x18650C950")]
	[AsyncStateMachine(typeof(EGIBDAOIEEF))]
	private static Task PMPDDCPEKHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x650B9B0", Offset = "0x650A5B0", VA = "0x18650B9B0")]
	[AsyncStateMachine(typeof(NLCOGODJDMP))]
	private static Task EBLDMJPGKKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x650C320", Offset = "0x650AF20", VA = "0x18650C320")]
	[AsyncStateMachine(typeof(BOFGNHNPKLM))]
	private static Task<Scene> LFELNJJFCIE(string AEGJFANOGND, LoadSceneMode KBLMDIMGMIA, bool HJGBGLLLDNP, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x650B580", Offset = "0x650A180", VA = "0x18650B580")]
	private static void DKDJOBAFJKM(SceneInstance BJMIJNLECJK, LoadSceneMode KBLMDIMGMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x650B430", Offset = "0x650A030", VA = "0x18650B430")]
	private static void BEAPEOKKEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x650BA80", Offset = "0x650A680", VA = "0x18650BA80")]
	[AsyncStateMachine(typeof(MOIMCENJFMI))]
	private static Task<Scene> EGAHKNCMECF(string AEGJFANOGND, LoadSceneMode KBLMDIMGMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x650C7C0", Offset = "0x650B3C0", VA = "0x18650C7C0")]
	private static bool OEBMLGNPECA(string AEGJFANOGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x650C210", Offset = "0x650AE10", VA = "0x18650C210")]
	[AsyncStateMachine(typeof(AMFMIDLMELM))]
	private static Task<Scene> KHLADLKOPBD(FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x650BFF0", Offset = "0x650ABF0", VA = "0x18650BFF0")]
	public static HPJLJGHAIKN<Scene> INEAAMPCMKB(string AEGJFANOGND, LoadSceneMode KBLMDIMGMIA = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x650B6E0", Offset = "0x650A2E0", VA = "0x18650B6E0")]
	public static CKPENFELBCE DLEFKJKBONF(string AEGJFANOGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x650C510", Offset = "0x650B110", VA = "0x18650C510")]
	[IteratorStateMachine(typeof(MFNHIJMNMMF))]
	private static IEnumerator<MJMKCFLBGFK> NHLBPNDBANF(string AEGJFANOGND, EEHJIENCILF COIDABEHDID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x650C170", Offset = "0x650AD70", VA = "0x18650C170")]
	[IteratorStateMachine(typeof(CBONMGGPMMG))]
	private static IEnumerator<MJMKCFLBGFK> KBKGDJONNIL(string AEGJFANOGND, LoadSceneMode KBLMDIMGMIA, KNCNIEDDCNP<Scene> COIDABEHDID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x650BBA0", Offset = "0x650A7A0", VA = "0x18650BBA0")]
	public static bool GGMHLJNNJJD([Out] string EGHCKDODCMM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class JCNDGDPKLKI
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6506660", Offset = "0x6505260", VA = "0x186506660")]
	public static IDisposable OKBGDIENJGC(this NFOEPLCKIPF BFDLBONPDOA, float OJPLGLBNMAF, Action<float> AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x65065E0", Offset = "0x65051E0", VA = "0x1865065E0")]
	public static IDisposable NLPINCPAEOB(this NFOEPLCKIPF BFDLBONPDOA, Action<float> AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6506560", Offset = "0x6505160", VA = "0x186506560")]
	public static IDisposable CHCCLKANBJN(this NFOEPLCKIPF BFDLBONPDOA, Action<float> AEJECABIACB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class IHKBCNDLDFI
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x65049A0", Offset = "0x65035A0", VA = "0x1865049A0")]
	public static IDisposable DECICPPNPFM(this MonoBehaviour GOOEIIAOGIE, Action AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6504A30", Offset = "0x6503630", VA = "0x186504A30")]
	public static IDisposable DECICPPNPFM(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x65053C0", Offset = "0x6503FC0", VA = "0x1865053C0")]
	public static IDisposable OFENLADEDFE(this MonoBehaviour GOOEIIAOGIE, Action AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6505440", Offset = "0x6504040", VA = "0x186505440")]
	public static IDisposable PDJCDDIBAPG(this MonoBehaviour GOOEIIAOGIE, Action AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x65054C0", Offset = "0x65040C0", VA = "0x1865054C0")]
	public static IDisposable PDJCDDIBAPG(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6504DC0", Offset = "0x65039C0", VA = "0x186504DC0")]
	public static IDisposable IFJOALODFCO(this MonoBehaviour GOOEIIAOGIE, Action AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6505150", Offset = "0x6503D50", VA = "0x186505150")]
	public static IDisposable MOJCDBMDEBF(this MonoBehaviour GOOEIIAOGIE, Action AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6504AC0", Offset = "0x65036C0", VA = "0x186504AC0")]
	public static IDisposable DIACKONLNHN(this MonoBehaviour GOOEIIAOGIE, Action AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x65050A0", Offset = "0x6503CA0", VA = "0x1865050A0")]
	public static IDisposable KEEBIIHCDLM(this MonoBehaviour GOOEIIAOGIE, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6504E40", Offset = "0x6503A40", VA = "0x186504E40")]
	public static IDisposable IJMELMLACMI(this MonoBehaviour GOOEIIAOGIE, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6505000", Offset = "0x6503C00", VA = "0x186505000")]
	public static IDisposable KEDNPIDPABH(this MonoBehaviour GOOEIIAOGIE, float OJPLGLBNMAF, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6504BE0", Offset = "0x65037E0", VA = "0x186504BE0")]
	public static IDisposable FCJPAKILCKJ(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6504B40", Offset = "0x6503740", VA = "0x186504B40")]
	public static IDisposable EIJFLKEGLOH(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6504D20", Offset = "0x6503920", VA = "0x186504D20")]
	public static IDisposable GNBGHEDCINK(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6504C80", Offset = "0x6503880", VA = "0x186504C80")]
	public static IDisposable FGGOLAJHDLI(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6504F60", Offset = "0x6503B60", VA = "0x186504F60")]
	public static IDisposable KEDFFMFBPAO(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6505320", Offset = "0x6503F20", VA = "0x186505320")]
	public static IDisposable OEJMKADPFDM(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6505280", Offset = "0x6503E80", VA = "0x186505280")]
	public static IDisposable NMMEGKDBDNB(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x65051D0", Offset = "0x6503DD0", VA = "0x1865051D0")]
	public static IDisposable NBCBLCABIOE(this MonoBehaviour GOOEIIAOGIE, float OJPLGLBNMAF, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class KPDHCFFMDLI
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class PFLDMEKJHLF : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private MJMKCFLBGFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public JDDMPIEJENJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private FIGHKLGHMAH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public PFLDMEKJHLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x650FE60", Offset = "0x650EA60", VA = "0x18650FE60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x650FF40", Offset = "0x650EB40", VA = "0x18650FF40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class AFFCFPGMINN : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private MJMKCFLBGFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public JDDMPIEJENJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private FIGHKLGHMAH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public AFFCFPGMINN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x64F58A0", Offset = "0x64F44A0", VA = "0x1864F58A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x64F5990", Offset = "0x64F4590", VA = "0x1864F5990", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6507940", Offset = "0x6506540", VA = "0x186507940")]
	public static IHPHLOENKON DECICPPNPFM(Action AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x65079F0", Offset = "0x65065F0", VA = "0x1865079F0")]
	public static IHPHLOENKON DECICPPNPFM(Behaviour BFDLBONPDOA, Action AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6507AB0", Offset = "0x65066B0", VA = "0x186507AB0")]
	public static IHPHLOENKON DECICPPNPFM(Behaviour BFDLBONPDOA, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6507C60", Offset = "0x6506860", VA = "0x186507C60")]
	[IteratorStateMachine(typeof(PFLDMEKJHLF))]
	private static IEnumerator<MJMKCFLBGFK> DNNEKAPPKBN(JDDMPIEJENJ OAOBAEBKDCM, Action AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6507BD0", Offset = "0x65067D0", VA = "0x186507BD0")]
	[IteratorStateMachine(typeof(AFFCFPGMINN))]
	private static IEnumerator<MJMKCFLBGFK> DNNEKAPPKBN(JDDMPIEJENJ OAOBAEBKDCM, Action<float> AEJECABIACB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class CDPAEKKAOFB : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class IBDCFMBHDAH : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private MJMKCFLBGFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public CDPAEKKAOFB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public IBDCFMBHDAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6504150", Offset = "0x6502D50", VA = "0x186504150", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x65041E0", Offset = "0x6502DE0", VA = "0x1865041E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly JDDMPIEJENJ OMGIHEDMDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action AMEIPGHNJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool ONBFIDBIPFP;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HEDOCPHLOHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x776670", Offset = "0x775270", VA = "0x180776670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x64F85C0", Offset = "0x64F71C0", VA = "0x1864F85C0")]
	public CDPAEKKAOFB(JDDMPIEJENJ OMGIHEDMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x64F84A0", Offset = "0x64F70A0", VA = "0x1864F84A0")]
	[IteratorStateMachine(typeof(IBDCFMBHDAH))]
	private IEnumerator<MJMKCFLBGFK> MAMDMFOAODA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x64F8520", Offset = "0x64F7120", VA = "0x1864F8520", Slot = "4")]
	public void OnCompleted(Action AOBOMLLAKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
	public void NCIHJOCCNBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class EJJJGBOIEOK
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x64FEFE0", Offset = "0x64FDBE0", VA = "0x1864FEFE0")]
	public static CDPAEKKAOFB DOMDHLHKKOK(this JDDMPIEJENJ OMGIHEDMDMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class DLCILAELAMN
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class MCNOMHKCPBK : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private MJMKCFLBGFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public MDPDENMOABO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public MCNOMHKCPBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6509740", Offset = "0x6508340", VA = "0x186509740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x65097C0", Offset = "0x65083C0", VA = "0x1865097C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x64FE000", Offset = "0x64FCC00", VA = "0x1864FE000")]
	public static IHPHLOENKON DECICPPNPFM(float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x64FDEF0", Offset = "0x64FCAF0", VA = "0x1864FDEF0")]
	public static IHPHLOENKON DECICPPNPFM(MonoBehaviour GOOEIIAOGIE, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x64FE360", Offset = "0x64FCF60", VA = "0x1864FE360")]
	public static IHPHLOENKON KJCIHLCJLPL(MonoBehaviour GOOEIIAOGIE, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x64FE250", Offset = "0x64FCE50", VA = "0x1864FE250")]
	public static IHPHLOENKON KCFEIIGOOIM(NFOEPLCKIPF BFDLBONPDOA, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x64FE100", Offset = "0x64FCD00", VA = "0x1864FE100")]
	private static IEnumerator<MJMKCFLBGFK> DNNEKAPPKBN(OILOBEMANON HALOMOONKFP, float OJPLGLBNMAF, JDDMPIEJENJ OAOBAEBKDCM, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x64FDE90", Offset = "0x64FCA90", VA = "0x1864FDE90")]
	private static IEnumerator<MJMKCFLBGFK> AFPGBCJDJBF(OILOBEMANON HALOMOONKFP, float OJPLGLBNMAF, JDDMPIEJENJ OAOBAEBKDCM, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x64FE1C0", Offset = "0x64FCDC0", VA = "0x1864FE1C0")]
	[IteratorStateMachine(typeof(MCNOMHKCPBK))]
	private static IEnumerator<MJMKCFLBGFK> FKMIFOCJNMK(MDPDENMOABO BBJOPLNJGHF, float OJPLGLBNMAF, JDDMPIEJENJ OAOBAEBKDCM, Action<float> AEJECABIACB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class JPKGJJIKFOJ
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class HKFCBHAABNB : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private MJMKCFLBGFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public JDDMPIEJENJ queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public HKFCBHAABNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x65035C0", Offset = "0x65021C0", VA = "0x1865035C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6503680", Offset = "0x6502280", VA = "0x186503680", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6506E30", Offset = "0x6505A30", VA = "0x186506E30")]
	[IteratorStateMachine(typeof(HKFCBHAABNB))]
	private static IEnumerator<MJMKCFLBGFK> KNGKELBJOOD(JDDMPIEJENJ OMGIHEDMDMD, Func<bool> LHLJIIDKOKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6506D10", Offset = "0x6505910", VA = "0x186506D10")]
	public static IHPHLOENKON FMKFBKFCICK(this MonoBehaviour GOOEIIAOGIE, Func<bool> LHLJIIDKOKP, JDDMPIEJENJ OMGIHEDMDMD = JDDMPIEJENJ.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class FEJEPCLBLNA
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class AFGNKJMPAPL : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private MJMKCFLBGFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public JDDMPIEJENJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public AFGNKJMPAPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x64F59E0", Offset = "0x64F45E0", VA = "0x1864F59E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x64F5A50", Offset = "0x64F4650", VA = "0x1864F5A50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class LMKKGMFOBMK : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private MJMKCFLBGFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public JDDMPIEJENJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private MJMKCFLBGFK <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public LMKKGMFOBMK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6509660", Offset = "0x6508260", VA = "0x186509660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x65096F0", Offset = "0x65082F0", VA = "0x1865096F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6502680", Offset = "0x6501280", VA = "0x186502680")]
	[IteratorStateMachine(typeof(AFGNKJMPAPL))]
	private static IEnumerator<MJMKCFLBGFK> MAMDMFOAODA(float FOGEGHJNDKP, JDDMPIEJENJ OAOBAEBKDCM, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6501F90", Offset = "0x6500B90", VA = "0x186501F90")]
	[IteratorStateMachine(typeof(LMKKGMFOBMK))]
	private static IEnumerator<MJMKCFLBGFK> AMIPJAGKDMH(float FOGEGHJNDKP, JDDMPIEJENJ OAOBAEBKDCM, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6502360", Offset = "0x6500F60", VA = "0x186502360")]
	public static IDisposable LAIMCGPIGJO(this MonoBehaviour GOOEIIAOGIE, float FOGEGHJNDKP, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6502750", Offset = "0x6501350", VA = "0x186502750")]
	public static IHPHLOENKON NMDPGGAKPFD(this MonoBehaviour GOOEIIAOGIE, float FOGEGHJNDKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6502480", Offset = "0x6501080", VA = "0x186502480")]
	public static IHPHLOENKON LAIMCGPIGJO(this MonoBehaviour GOOEIIAOGIE, float FOGEGHJNDKP, JDDMPIEJENJ OAOBAEBKDCM, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6502060", Offset = "0x6500C60", VA = "0x186502060")]
	public static IHPHLOENKON CFOAMOIJPMG(this MonoBehaviour GOOEIIAOGIE, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6502330", Offset = "0x6500F30", VA = "0x186502330")]
	public static IHPHLOENKON JJIHAMJADEE(this MonoBehaviour GOOEIIAOGIE, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6502080", Offset = "0x6500C80", VA = "0x186502080")]
	public static IHPHLOENKON CPLOFCLJIKD(this MonoBehaviour GOOEIIAOGIE, Action CPCNABCMKCJ, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6502160", Offset = "0x6500D60", VA = "0x186502160")]
	public static IHPHLOENKON DPMHKLPFMCJ(this MonoBehaviour GOOEIIAOGIE, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6502720", Offset = "0x6501320", VA = "0x186502720")]
	public static IHPHLOENKON NJGILGKDBII(this MonoBehaviour GOOEIIAOGIE, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6502030", Offset = "0x6500C30", VA = "0x186502030")]
	public static IHPHLOENKON BDEHPBIALHI(this MonoBehaviour GOOEIIAOGIE, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x65025B0", Offset = "0x65011B0", VA = "0x1865025B0")]
	private static IHPHLOENKON LFAIPGKKFAI(MonoBehaviour GOOEIIAOGIE, JDDMPIEJENJ OMGIHEDMDMD, Action CPCNABCMKCJ, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6502260", Offset = "0x6500E60", VA = "0x186502260")]
	public static IHPHLOENKON INBGJCOFKNO(this MonoBehaviour GOOEIIAOGIE, float NENFHBGKLGL, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6502190", Offset = "0x6500D90", VA = "0x186502190")]
	public static IHPHLOENKON FNEPCFFFEJF(this MonoBehaviour GOOEIIAOGIE, float NENFHBGKLGL, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6502810", Offset = "0x6501410", VA = "0x186502810")]
	public static IHPHLOENKON PCOEOPJFJIM(this MonoBehaviour GOOEIIAOGIE, float NENFHBGKLGL, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6501EC0", Offset = "0x6500AC0", VA = "0x186501EC0")]
	public static IHPHLOENKON AELPHGFAPFD(this MonoBehaviour GOOEIIAOGIE, float NENFHBGKLGL, Action CPCNABCMKCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class GNPKANJPBGK : OLMAHMLPJJG, IEnumerable<OLMAHMLPJJG>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<OLMAHMLPJJG> HCOOJNDPPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool HENGAIHJDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action LGEAFMICBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool MFJMDGAIPPP;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LLBKLLLCDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6502DD0", Offset = "0x65019D0", VA = "0x186502DD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DDDABAMDEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x65033E0", Offset = "0x6501FE0", VA = "0x1865033E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6503480", Offset = "0x6502080", VA = "0x186503480", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6503520", Offset = "0x6502120", VA = "0x186503520")]
	public GNPKANJPBGK([Optional] Action LGEAFMICBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x65032B0", Offset = "0x6501EB0", VA = "0x1865032B0")]
	public void HFMDKEOMMOI(OLMAHMLPJJG IAHFBENMKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6502C70", Offset = "0x6501870", VA = "0x186502C70")]
	private void BEOLKKOEKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6502F10", Offset = "0x6501B10", VA = "0x186502F10", Slot = "7")]
	public bool FNDOHEONCMD(bool JNADMECNEPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6502F20", Offset = "0x6501B20", VA = "0x186502F20", Slot = "8")]
	public bool FNDOHEONCMD(Action GAFABDCELFL, bool JNADMECNEPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6503230", Offset = "0x6501E30", VA = "0x186503230", Slot = "9")]
	public IEnumerator<OLMAHMLPJJG> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6503230", Offset = "0x6501E30", VA = "0x186503230", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PHMNPBEJOIP : OLGADNDNDBE
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class FJANOCJLJEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public PHMNPBEJOIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public FJANOCJLJEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x64FE4E0", Offset = "0x64FD0E0", VA = "0x1864FE4E0")]
		internal void KPEDAFNOKIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class EFBKFAELIMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public PHMNPBEJOIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public EFBKFAELIMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x64FE4E0", Offset = "0x64FD0E0", VA = "0x1864FE4E0")]
		internal void MIABGCMEEIL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float AMEAHBFGIPK;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x64FF410", Offset = "0x64FE010", VA = "0x1864FF410")]
	public PHMNPBEJOIP(Behaviour BFDLBONPDOA, float AMEAHBFGIPK, [Optional] Action LGEAFMICBOB, [Optional] MBGPIBEMOCP GNLNBDCDMHC, [Optional] OILOBEMANON HALOMOONKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x65100A0", Offset = "0x650ECA0", VA = "0x1865100A0", Slot = "9")]
	protected override bool KHNBJFBMAKI(Action GAFABDCELFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x650FF90", Offset = "0x650EB90", VA = "0x18650FF90", Slot = "10")]
	protected override bool BODHOMIGHPA(Action GAFABDCELFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface OLMAHMLPJJG
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool LLBKLLLCDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action DDDABAMDEJK;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FNDOHEONCMD(bool JNADMECNEPO = false);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FNDOHEONCMD(Action GAFABDCELFL, bool JNADMECNEPO = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class OLGADNDNDBE : OLMAHMLPJJG
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class CEHIKJHCEPA : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private MJMKCFLBGFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public OLGADNDNDBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public CEHIKJHCEPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x64F86D0", Offset = "0x64F72D0", VA = "0x1864F86D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x64F87A0", Offset = "0x64F73A0", VA = "0x1864F87A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour BFDLBONPDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action LGEAFMICBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private PABKPJDFADP KDMBFHIALAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly MBGPIBEMOCP GNLNBDCDMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly OILOBEMANON HALOMOONKFP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LLBKLLLCDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xEAA8B0", Offset = "0xEA94B0", VA = "0x180EAA8B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action DDDABAMDEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x650F8D0", Offset = "0x650E4D0", VA = "0x18650F8D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x650FA40", Offset = "0x650E640", VA = "0x18650FA40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x650FAE0", Offset = "0x650E6E0", VA = "0x18650FAE0")]
	protected OLGADNDNDBE(Behaviour BFDLBONPDOA, [Optional] Action LGEAFMICBOB, [Optional] MBGPIBEMOCP GNLNBDCDMHC, [Optional] OILOBEMANON HALOMOONKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x650F5B0", Offset = "0x650E1B0", VA = "0x18650F5B0", Slot = "7")]
	public bool FNDOHEONCMD(bool JNADMECNEPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x650F550", Offset = "0x650E150", VA = "0x18650F550", Slot = "8")]
	public bool FNDOHEONCMD(Action GAFABDCELFL, bool JNADMECNEPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool KHNBJFBMAKI(Action GAFABDCELFL);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool BODHOMIGHPA(Action GAFABDCELFL);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x650F530", Offset = "0x650E130", VA = "0x18650F530")]
	protected void CBHDIKJLAIB(Action GAFABDCELFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x650F610", Offset = "0x650E210", VA = "0x18650F610")]
	protected CKPENFELBCE FOBNFALDBJB(float EJGELOGDBKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x650F850", Offset = "0x650E450", VA = "0x18650F850")]
	private void GGOLCDMFAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x650F9B0", Offset = "0x650E5B0", VA = "0x18650F9B0")]
	[IteratorStateMachine(typeof(CEHIKJHCEPA))]
	private IEnumerator<MJMKCFLBGFK> MAOADPKHKFJ(float EJGELOGDBKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x650F970", Offset = "0x650E570", VA = "0x18650F970")]
	[CompilerGenerated]
	private void IOEMPDCEAHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class CJKINMOCIHC : OLGADNDNDBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float EBBGMDLLCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int LDAECGOOPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float HBNNAGJFBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] JOGNOLJACOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int FMAMJIEBIKD;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x64F8A70", Offset = "0x64F7670", VA = "0x1864F8A70")]
	public CJKINMOCIHC(Behaviour BFDLBONPDOA, float EKCNEFNJGIJ, int LDAECGOOPHL, [Optional] Action LGEAFMICBOB, float HBNNAGJFBPH = 0f, [Optional] MBGPIBEMOCP GNLNBDCDMHC, [Optional] OILOBEMANON HALOMOONKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "9")]
	protected override bool KHNBJFBMAKI(Action GAFABDCELFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x64F87F0", Offset = "0x64F73F0", VA = "0x1864F87F0", Slot = "10")]
	protected override bool BODHOMIGHPA(Action GAFABDCELFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x64F89F0", Offset = "0x64F75F0", VA = "0x1864F89F0")]
	private void PIBAOGLBHFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class ENINDBDOFOM : OLGADNDNDBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float AMEAHBFGIPK;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x64FF410", Offset = "0x64FE010", VA = "0x1864FF410")]
	public ENINDBDOFOM(Behaviour BFDLBONPDOA, float AMEAHBFGIPK, [Optional] Action LGEAFMICBOB, [Optional] MBGPIBEMOCP GNLNBDCDMHC, [Optional] OILOBEMANON HALOMOONKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "9")]
	protected override bool KHNBJFBMAKI(Action GAFABDCELFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x64FF3D0", Offset = "0x64FDFD0", VA = "0x1864FF3D0", Slot = "10")]
	protected override bool BODHOMIGHPA(Action GAFABDCELFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class IGBNDGAMGCO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class NJNEOGFGGJD : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private MJMKCFLBGFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public NJNEOGFGGJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6506C50", Offset = "0x6505850", VA = "0x186506C50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x650AB90", Offset = "0x6509790", VA = "0x18650AB90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private IHPHLOENKON PGBDMAFMDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NFOEPLCKIPF BFDLBONPDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> CFHMNKHNMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private JDDMPIEJENJ OMGIHEDMDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float FKJPKGDHCOI;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x65047C0", Offset = "0x65033C0", VA = "0x1865047C0")]
	public IGBNDGAMGCO(NFOEPLCKIPF BFDLBONPDOA, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6504230", Offset = "0x6502E30", VA = "0x186504230")]
	private void BPFHCGFBGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x65044B0", Offset = "0x65030B0", VA = "0x1865044B0")]
	private void JGHFPENAIHJ(string GNLAGDDNMDN, Action BHBNOLELJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6504430", Offset = "0x6503030", VA = "0x186504430")]
	[IteratorStateMachine(typeof(NJNEOGFGGJD))]
	private IEnumerator<MJMKCFLBGFK> FKPIOGOOJCC(Action BHBNOLELJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x65043D0", Offset = "0x6502FD0", VA = "0x1865043D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6504610", Offset = "0x6503210", VA = "0x186504610")]
	[CompilerGenerated]
	private void NAJPKNIBLDL(string PFNPJMEIKHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class DEIGOLNDPJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JOOEFKILMPB : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private MJMKCFLBGFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public JOOEFKILMPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6506C50", Offset = "0x6505850", VA = "0x186506C50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6506CC0", Offset = "0x65058C0", VA = "0x186506CC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private IHPHLOENKON PGBDMAFMDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour GOOEIIAOGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action AEJECABIACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> CFHMNKHNMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private JDDMPIEJENJ OMGIHEDMDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float FKJPKGDHCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool FNMMHOPNMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly MBGPIBEMOCP GNLNBDCDMHC;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x64FDB10", Offset = "0x64FC710", VA = "0x1864FDB10")]
	public DEIGOLNDPJE(MonoBehaviour GOOEIIAOGIE, Action AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x64FD680", Offset = "0x64FC280", VA = "0x1864FD680")]
	public DEIGOLNDPJE(MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x64FD8C0", Offset = "0x64FC4C0", VA = "0x1864FD8C0")]
	public DEIGOLNDPJE(MonoBehaviour GOOEIIAOGIE, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1891510", Offset = "0x1890110", VA = "0x181891510")]
	private DEIGOLNDPJE(MBGPIBEMOCP GNLNBDCDMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x64FCD90", Offset = "0x64FB990", VA = "0x1864FCD90")]
	internal static DEIGOLNDPJE DENMLCBCLKK(MonoBehaviour GOOEIIAOGIE, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x64FCC20", Offset = "0x64FB820", VA = "0x1864FCC20")]
	private void DECICPPNPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x64FD030", Offset = "0x64FBC30", VA = "0x1864FD030")]
	private void HEOIJEFJMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x64FCA70", Offset = "0x64FB670", VA = "0x1864FCA70")]
	private void BPFHCGFBGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x64FD310", Offset = "0x64FBF10", VA = "0x1864FD310")]
	private void JLMAMGEIAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x64FD1E0", Offset = "0x64FBDE0", VA = "0x1864FD1E0")]
	private void JGHFPENAIHJ(string GNLAGDDNMDN, Action BHBNOLELJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x64FCFB0", Offset = "0x64FBBB0", VA = "0x1864FCFB0")]
	[IteratorStateMachine(typeof(JOOEFKILMPB))]
	private IEnumerator<MJMKCFLBGFK> FKPIOGOOJCC(Action BHBNOLELJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x64FCEC0", Offset = "0x64FBAC0", VA = "0x1864FCEC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x64FD560", Offset = "0x64FC160", VA = "0x1864FD560")]
	[CompilerGenerated]
	private void MHIJIGJNEEF(string PFNPJMEIKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x64FD5F0", Offset = "0x64FC1F0", VA = "0x1864FD5F0")]
	[CompilerGenerated]
	private void PCKPMFCPAKC(string PFNPJMEIKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x64FCF20", Offset = "0x64FBB20", VA = "0x1864FCF20")]
	[CompilerGenerated]
	private void FHBFGFIJPBM(string PFNPJMEIKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x64FD4D0", Offset = "0x64FC0D0", VA = "0x1864FD4D0")]
	[CompilerGenerated]
	private void LAIKAHFKIMO(string PFNPJMEIKHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum CAEIJHAPBLE : byte
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
internal sealed class ELOCCPPOHCP : OILOBEMANON
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float CGACJFFMMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x64FF3C0", Offset = "0x64FDFC0", VA = "0x1864FF3C0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float IIAMMIHNHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x64FF3B0", Offset = "0x64FDFB0", VA = "0x1864FF3B0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double CPBGANIIHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x64FF320", Offset = "0x64FDF20", VA = "0x1864FF320", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x64FF340", Offset = "0x64FDF40", VA = "0x1864FF340")]
	[GFMBCOBENIN(CDPNEOMLNDL.None)]
	private static void FALOLKAJBGJ(OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	[Preserve]
	internal ELOCCPPOHCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface EHCPBNNOJLG
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKAEKNIMHLH(string JEICAPDKHKI);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDDHGNKCPHF();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface PEKILLHDHED
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string ODBDFCEODFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool IBAGIICNAIO
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool IGCJDBMBFHI
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class MMFFNECGAFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public FDALFCGDCLB DJKPFKLNMOK;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int EJAAMOHLDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76ED80", VA = "0x180770180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x77F1E0", Offset = "0x77DDE0", VA = "0x18077F1E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6509F30", Offset = "0x6508B30", VA = "0x186509F30")]
	public static MJMKCFLBGFK LPAHLLPIDIG(IEnumerator<MJMKCFLBGFK> OPIBKMPHBKJ, CMIJLBKPGBH IFLPCIJGAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x650A090", Offset = "0x6508C90", VA = "0x18650A090")]
	public MJMKCFLBGFK LPAHLLPIDIG(CMIJLBKPGBH[] GLJDEEIAFCH, IEnumerator<MJMKCFLBGFK>[] GJNBLJFBPMD, MJMKCFLBGFK[] PNJHPLDGKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6509F00", Offset = "0x6508B00", VA = "0x186509F00")]
	public void FMMHIFOKFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6509C80", Offset = "0x6508880", VA = "0x186509C80")]
	public void DKGGPDKEFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6509DC0", Offset = "0x65089C0", VA = "0x186509DC0")]
	public void DPBCNJHHIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6509F00", Offset = "0x6508B00", VA = "0x186509F00")]
	public void IIEKIHINOBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public MMFFNECGAFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class FDALFCGDCLB
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct JAOPLGMAOED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public MMFFNECGAFJ LODOIJDOJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public NFOEPLCKIPF GOJOPDOENIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public CMIJLBKPGBH BIEOCHKCNBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<MJMKCFLBGFK> CJDEMHEGHJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public MJMKCFLBGFK PINNDHOGGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public CAEIJHAPBLE BFFMKMOIAKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct FDGOIJGMEGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public JDDMPIEJENJ NOJBNMEAEEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<JAOPLGMAOED> HNEABHCGJJF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class AKBLMBAHKFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public CMIJLBKPGBH promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public FDALFCGDCLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public NFOEPLCKIPF context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public MMFFNECGAFJ routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CAEIJHAPBLE coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public MJMKCFLBGFK currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<MJMKCFLBGFK> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public AKBLMBAHKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x64F5AA0", Offset = "0x64F46A0", VA = "0x1864F5AA0")]
		internal void DDPCIIDCCLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class NJHJCFDFEFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public MMFFNECGAFJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public FDALFCGDCLB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public NJHJCFDFEFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x650AB50", Offset = "0x6509750", VA = "0x18650AB50")]
		internal void JFBMOLMDFJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class LKMOLABJMKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public MMFFNECGAFJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public FDALFCGDCLB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public LKMOLABJMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6509620", Offset = "0x6508220", VA = "0x186509620")]
		internal void OCODBLGHPEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class GIMIGGJJKKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public MMFFNECGAFJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public FDALFCGDCLB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public GIMIGGJJKKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6502C30", Offset = "0x6501830", VA = "0x186502C30")]
		internal void LAADFLLNHEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const CAEIJHAPBLE HAALIDCMCMI = CAEIJHAPBLE.Cancelled | CAEIJHAPBLE.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly JDDMPIEJENJ OMGIHEDMDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] LJCAADFCGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<CAEIJHAPBLE> NFLDNPOOKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> CLEDDCGGPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> PJIBKDKCHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> KFPCEKKIPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> OAGPIIFBMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> ECIGDKCOHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> MDIPHODDFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private MMFFNECGAFJ[] PHNJOHCKDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private CMIJLBKPGBH[] GLJDEEIAFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NFOEPLCKIPF[] OJENAANGBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<MJMKCFLBGFK>[] DBLJFIDFPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private MJMKCFLBGFK[] NCKOPBLNLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int GCJPDMDKAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int AAAINGBCLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int DEABFAKKFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float GLEDIPHLOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private KHABNLENALM LIICPAIGIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle PMNJHIFDKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<MMFFNECGAFJ> BALLJJADLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool JMCOMPLIMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> OKMHJLAEHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> HAHJGCJNDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool JHFIBBJAKBG;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public FDGOIJGMEGO[] DLNGENCEDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9644F0", Offset = "0x9630F0", VA = "0x1809644F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x65002E0", Offset = "0x64FEEE0", VA = "0x1865002E0")]
	private static int ECBKBAHKAFJ(JDDMPIEJENJ OMGIHEDMDMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6501870", Offset = "0x6500470", VA = "0x186501870")]
	public FDALFCGDCLB(JDDMPIEJENJ OMGIHEDMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6500B50", Offset = "0x64FF750", VA = "0x186500B50")]
	private void KFBGFGBHEJA(int LJEDKGJMBKF, int JFMAFLEDHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6500E70", Offset = "0x64FFA70", VA = "0x186500E70")]
	public void NIHHMFHDKGJ(NFOEPLCKIPF BFDLBONPDOA, MJMKCFLBGFK ACKBEBLMBFM, IEnumerator<MJMKCFLBGFK> OPIBKMPHBKJ, CMIJLBKPGBH IFLPCIJGAMI, [Optional] MMFFNECGAFJ AJNOGBACFNI, CAEIJHAPBLE NKKNLIOGJKB = CAEIJHAPBLE.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6500910", Offset = "0x64FF510", VA = "0x186500910")]
	public void JNBPJJIDHKJ(IEnumerable<JAOPLGMAOED> NCJGLNDGBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x65013A0", Offset = "0x64FFFA0", VA = "0x1865013A0")]
	private JAOPLGMAOED PJONINEEAHD(int DCFJBMBDMKB)
	{
		return default(JAOPLGMAOED);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x64FFF70", Offset = "0x64FEB70", VA = "0x1864FFF70")]
	private void DHEANCNMCKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x24DB3D0", Offset = "0x24D9FD0", VA = "0x1824DB3D0")]
	private static void LBIAINGFPBA<T>(int DCFJBMBDMKB, T[] CECHCHAPPHM, int JIGGJNDJAAO, [Optional] T CHDGLADFILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x24DB420", Offset = "0x24DA020", VA = "0x1824DB420")]
	private static void LBIAINGFPBA<T>(int DCFJBMBDMKB, NativeArray<T> CECHCHAPPHM, int JIGGJNDJAAO, [Optional] T CHDGLADFILO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6500310", Offset = "0x64FEF10", VA = "0x186500310")]
	private void IFDKDFPJMNK(IEnumerable<JAOPLGMAOED> NCJGLNDGBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6500D30", Offset = "0x64FF930", VA = "0x186500D30")]
	private void KMJKADINPCP(JAOPLGMAOED EABJJONGPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x64FF610", Offset = "0x64FE210", VA = "0x1864FF610")]
	private DMPIALGBEOE BMPJIJFFLOK(int IGDLAJOPPKG)
	{
		return default(DMPIALGBEOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6501120", Offset = "0x64FFD20", VA = "0x186501120")]
	public void PCMAHJOMNPA(float MKJMBIGEENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6501320", Offset = "0x64FFF20", VA = "0x186501320")]
	private void PGIENDHFLMB(Action FLGIINLNNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6500DF0", Offset = "0x64FF9F0", VA = "0x186500DF0")]
	private void NFFOBLHMGJO(Action FLGIINLNNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x64FF870", Offset = "0x64FE470", VA = "0x1864FF870")]
	public void DBCKMPGPGIP(float MKJMBIGEENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x64FF510", Offset = "0x64FE110", VA = "0x1864FF510")]
	public void BAMMMHDNJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x65006B0", Offset = "0x64FF2B0", VA = "0x1865006B0")]
	public void IIEKIHINOBM(MMFFNECGAFJ BBJOPLNJGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x65007E0", Offset = "0x64FF3E0", VA = "0x1865007E0")]
	public void JINCNFKLOJI(MMFFNECGAFJ BBJOPLNJGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6500FF0", Offset = "0x64FFBF0", VA = "0x186500FF0")]
	public void OAEHKPHBFJA(MMFFNECGAFJ BBJOPLNJGHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GBIOLMKILEP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly GBIOLMKILEP MANJPJPLOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action FDDLMNMDJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool OCFIKJIDDDB;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	public GBIOLMKILEP(Action FDDLMNMDJML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6502AE0", Offset = "0x65016E0", VA = "0x186502AE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface ANJOEPKCCMN<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T GMFAJOGMKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable MILIMNCIABD(UnityEngine.Object BFDLBONPDOA, Action<T> KMMIANLGJIE);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface OHFMCOHKBBJ<T> : ANJOEPKCCMN<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T GMFAJOGMKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class OILGONPAKBJ<T> : OHFMCOHKBBJ<T>, ANJOEPKCCMN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class KPOKADJFLCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public OILGONPAKBJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public GJOMMIPKPMO<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public KPOKADJFLCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x39CCA20", Offset = "0x39CB620", VA = "0x1839CCA20")]
		internal void IFBFHKOPLCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject CCNGHDIBJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<GJOMMIPKPMO<UnityEngine.Object, Action<T>>> OCHDNEGIPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T GMJEEILEJML;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T GMFAJOGMKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F49A0", Offset = "0x7F35A0", VA = "0x1807F49A0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3E001F0", Offset = "0x3DFEDF0", VA = "0x183E001F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3E00120", Offset = "0x3DFED20", VA = "0x183E00120")]
	private static bool DNLHGDHNGLE(T FLGIINLNNEM, T KNDAEONALIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3E00C70", Offset = "0x3DFF870", VA = "0x183E00C70")]
	public OILGONPAKBJ(T OLDKAGOIIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3E00AE0", Offset = "0x3DFF6E0", VA = "0x183E00AE0", Slot = "6")]
	public IDisposable MILIMNCIABD(UnityEngine.Object BFDLBONPDOA, Action<T> KMMIANLGJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3E002F0", Offset = "0x3DFEEF0", VA = "0x183E002F0")]
	private void IFBNMFDGGBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class KGFEMNKMGHB : ILGHFNNAFCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly MBGPIBEMOCP GNLNBDCDMHC;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x65072C0", Offset = "0x6505EC0", VA = "0x1865072C0")]
	[GFMBCOBENIN(CDPNEOMLNDL.None)]
	private static void FALOLKAJBGJ(OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	[Preserve]
	internal KGFEMNKMGHB([DLBAGNNJKKK(null)] MBGPIBEMOCP GNLNBDCDMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6507330", Offset = "0x6505F30", VA = "0x186507330", Slot = "4")]
	public IDisposable KEDNPIDPABH(float OJPLGLBNMAF, Action<float> FCFEFDOJHCD, bool FNMMHOPNMDJ = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class IMFNGIKCJPG : LIDLDCAHDEC, MBGPIBEMOCP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private FDALFCGDCLB[] GFBMELGPBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private EHCPBNNOJLG EEAGJCGDLDC;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6505920", Offset = "0x6504520", VA = "0x186505920")]
	[GFMBCOBENIN(CDPNEOMLNDL.None)]
	private static void FALOLKAJBGJ(OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6506170", Offset = "0x6504D70", VA = "0x186506170")]
	[Preserve]
	public IMFNGIKCJPG([DLBAGNNJKKK(null)] EFJOKGEPKPF FPCFIIFFNNF, [DLBAGNNJKKK(null)] OILOBEMANON HALOMOONKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6505E50", Offset = "0x6504A50", VA = "0x186505E50", Slot = "17")]
	public override IHPHLOENKON HMHCFFFNHBD(NFOEPLCKIPF BFDLBONPDOA, IEnumerator<MJMKCFLBGFK> ALLMDMOCJHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6505990", Offset = "0x6504590", VA = "0x186505990", Slot = "18")]
	public override void GPJBDIFOFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6505690", Offset = "0x6504290", VA = "0x186505690", Slot = "20")]
	public override void DLDIOBGOGBC(JDDMPIEJENJ OMGIHEDMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6506000", Offset = "0x6504C00", VA = "0x186506000", Slot = "19")]
	protected override void OFENLADEDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6505660", Offset = "0x6504260", VA = "0x186505660")]
	private FDALFCGDCLB CGAHFJCNEEI(JDDMPIEJENJ OMKEAAPIABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6505C20", Offset = "0x6504820", VA = "0x186505C20", Slot = "21")]
	internal override ABFHHILCHPH HAGMHBAMPBF(IEnumerator<MJMKCFLBGFK> ALLMDMOCJHL, Behaviour BFDLBONPDOA, CMIJLBKPGBH IFLPCIJGAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6505F80", Offset = "0x6504B80", VA = "0x186505F80", Slot = "22")]
	internal override OKKIFMIGJFL IKPDFPJHDFF(JDDMPIEJENJ OAOBAEBKDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6505540", Offset = "0x6504140", VA = "0x186505540")]
	private void AFPDPHLDIAJ(FDALFCGDCLB NKAEJCPLFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x65058C0", Offset = "0x65044C0", VA = "0x1865058C0", Slot = "23")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct KHABNLENALM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float HDMGKLJLNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int FLHABOPLLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> FHODFHJDABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> JAFOJOJGCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> MNGKHAAIDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<CAEIJHAPBLE> JEKNILMNFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> PCKHLDMCGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> OAGPIIFBMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> PJIBKDKCHDF;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x65078E0", Offset = "0x65064E0", VA = "0x1865078E0")]
	public static KHABNLENALM PAKONFKLIMF(int JLDMJPJFPJD, float MKJMBIGEENJ, NativeArray<CAEIJHAPBLE> EABAAHCMLEM, NativeArray<float> KLBABIGOOIP, NativeArray<int> KCFHAOGOAON, NativeArray<int> AMGDKNECDDJ, NativeArray<int> IJGOKEDBELN, NativeArray<int> JAFOJOJGCDE, NativeArray<int> MNGKHAAIDAK)
	{
		return default(KHABNLENALM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6507550", Offset = "0x6506150", VA = "0x186507550", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x65078A0", Offset = "0x65064A0", VA = "0x1865078A0")]
	private bool OILLDAMMIBK(int DCGGFHOCGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6507630", Offset = "0x6506230", VA = "0x186507630")]
	private void JLNNJPGNCHH(NativeArray<int> IOACHNEABNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x65074B0", Offset = "0x65060B0", VA = "0x1865074B0")]
	private int COJCLEANEBB(int ONOGOEEKLCA, int ECDMKNFJMJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x65073E0", Offset = "0x6505FE0", VA = "0x1865073E0")]
	private void BNKIAHEHHLN(NativeArray<int> IOACHNEABNH, int FDOEMDDHIJF, int OIPEAFPNBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6507660", Offset = "0x6506260", VA = "0x186507660")]
	private void OALLOCIOLOJ(NativeArray<int> IOACHNEABNH, int JDOMBAAPPCO, int OPDELEGCFIH, int EBGLICEKHKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class LIDLDCAHDEC : MBGPIBEMOCP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly EFJOKGEPKPF FPCFIIFFNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly OILOBEMANON HALOMOONKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private OKKIFMIGJFL[] FMELLJHHCIG;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static MBGPIBEMOCP IDAIJJLMAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x65087C0", Offset = "0x65073C0", VA = "0x1865087C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool BKIHKFDKCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x78C390", Offset = "0x78AF90", VA = "0x18078C390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public JDDMPIEJENJ NNPEHOABCEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76ED80", VA = "0x180770180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JDDMPIEJENJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x77F1E0", Offset = "0x77DDE0", VA = "0x18077F1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public OILOBEMANON IEACMIBIOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public MJMKCFLBGFK MAGAOADHIAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MJMKCFLBGFK HIGEAECABAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x776710", Offset = "0x775310", VA = "0x180776710", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6507D80", Offset = "0x6506980", VA = "0x186507D80")]
	public static IHPHLOENKON DCDGLFDOKJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6508C30", Offset = "0x6507830", VA = "0x186508C30")]
	[Preserve]
	protected LIDLDCAHDEC([DLBAGNNJKKK(null)] EFJOKGEPKPF FPCFIIFFNNF, [DLBAGNNJKKK(null)] OILOBEMANON HALOMOONKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6508830", Offset = "0x6507430", VA = "0x186508830", Slot = "6")]
	public IHPHLOENKON PELAEOHIFHJ(IEnumerator<MJMKCFLBGFK> ALLMDMOCJHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x6508840", Offset = "0x6507440", VA = "0x186508840", Slot = "7")]
	public IHPHLOENKON PELAEOHIFHJ(Behaviour BFDLBONPDOA, IEnumerator<MJMKCFLBGFK> ALLMDMOCJHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract IHPHLOENKON HMHCFFFNHBD(NFOEPLCKIPF BFDLBONPDOA, IEnumerator<MJMKCFLBGFK> ALLMDMOCJHL);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x65082E0", Offset = "0x6506EE0", VA = "0x1865082E0", Slot = "18")]
	public virtual void GPJBDIFOFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6508520", Offset = "0x6507120", VA = "0x186508520", Slot = "9")]
	public void OEAOOJLOLAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6508760", Offset = "0x6507360", VA = "0x186508760", Slot = "19")]
	protected virtual void OFENLADEDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6508780", Offset = "0x6507380", VA = "0x186508780")]
	private void OFPHAKNNMLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x65084A0", Offset = "0x65070A0", VA = "0x1865084A0")]
	private void INLDOIELEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6508810", Offset = "0x6507410", VA = "0x186508810")]
	private void PDJCDDIBAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6508480", Offset = "0x6507080", VA = "0x186508480")]
	private void IFJOALODFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x65082C0", Offset = "0x6506EC0", VA = "0x1865082C0")]
	private void GHKMIALKFOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x65087A0", Offset = "0x65073A0", VA = "0x1865087A0")]
	private void ONPCEADGMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6508C10", Offset = "0x6507810", VA = "0x186508C10")]
	private void PPPCHPHFHLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6507E10", Offset = "0x6506A10", VA = "0x186507E10", Slot = "20")]
	public virtual void DLDIOBGOGBC(JDDMPIEJENJ OMGIHEDMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6508A40", Offset = "0x6507640", VA = "0x186508A40")]
	private void PMNEFPONKIP(OKKIFMIGJFL NKAEJCPLFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1BF5FB0", Offset = "0x1BF4BB0", VA = "0x181BF5FB0")]
	private OKKIFMIGJFL IKJEBMHENAL(JDDMPIEJENJ OMKEAAPIABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract ABFHHILCHPH HAGMHBAMPBF(IEnumerator<MJMKCFLBGFK> ALLMDMOCJHL, Behaviour GOOEIIAOGIE, CMIJLBKPGBH BMACPLGPGIC);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract OKKIFMIGJFL IKPDFPJHDFF(JDDMPIEJENJ OMGIHEDMDMD);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6507EA0", Offset = "0x6506AA0", VA = "0x186507EA0", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6508260", Offset = "0x6506E60", VA = "0x186508260", Slot = "13")]
	public MJMKCFLBGFK FMPMCIHHCDN(JDDMPIEJENJ OAOBAEBKDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6507CF0", Offset = "0x65068F0", VA = "0x186507CF0", Slot = "14")]
	public MJMKCFLBGFK CINHPPJMCGN(float FOGEGHJNDKP, JDDMPIEJENJ OAOBAEBKDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x65084C0", Offset = "0x65070C0", VA = "0x1865084C0", Slot = "15")]
	public MJMKCFLBGFK JKENLPPFDOE(Func<bool> LHLJIIDKOKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class ABFHHILCHPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly CMIJLBKPGBH IFLPCIJGAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly PEKILLHDHED BFDLBONPDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool MCHBDBKGDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string JEICAPDKHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private StackTrace HAANHPOPICE;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerator<MJMKCFLBGFK> CJDEMHEGHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public MJMKCFLBGFK PINNDHOGGOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7733F0", Offset = "0x771FF0", VA = "0x1807733F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool ICNMFMLFMNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x64F5220", Offset = "0x64F3E20", VA = "0x1864F5220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool DAONOANDCDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6B0", Offset = "0x7DD2B0", VA = "0x1807DE6B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6C0", Offset = "0x7DD2C0", VA = "0x1807DE6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string ODBDFCEODFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x64F5070", Offset = "0x64F3C70", VA = "0x1864F5070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float HLDAKHIABOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1027460", Offset = "0x1026060", VA = "0x181027460")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x54A9650", Offset = "0x54A8250", VA = "0x1854A9650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x64F56E0", Offset = "0x64F42E0", VA = "0x1864F56E0")]
	public ABFHHILCHPH(IEnumerator<MJMKCFLBGFK> OPIBKMPHBKJ, PEKILLHDHED BFDLBONPDOA, CMIJLBKPGBH IFLPCIJGAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x64F52F0", Offset = "0x64F3EF0", VA = "0x1864F52F0")]
	public MJMKCFLBGFK LPAHLLPIDIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x64F5000", Offset = "0x64F3C00", VA = "0x1864F5000")]
	public bool FENFOOAMPOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x64F52A0", Offset = "0x64F3EA0", VA = "0x1864F52A0")]
	public void IIEKIHINOBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x64F5600", Offset = "0x64F4200", VA = "0x1864F5600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x85C210", Offset = "0x85AE10", VA = "0x18085C210")]
	[CompilerGenerated]
	private void JEICFPHAHAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class CMIJLBKPGBH : GMKIJNGCPPC, IHPHLOENKON, PABKPJDFADP, CKPENFELBCE, IEnumerator, MJMKCFLBGFK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private JDDMPIEJENJ KNHKLAEHKCE;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private JDDMPIEJENJ DAPMNMAABOI
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xDA8860", Offset = "0xDA7460", VA = "0x180DA8860", Slot = "23")]
		get
		{
			return default(JDDMPIEJENJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public JDDMPIEJENJ DJKPFKLNMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x129FBE0", Offset = "0x129E7E0", VA = "0x18129FBE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private float MCIFCHCEBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7C58C0", Offset = "0x7C44C0", VA = "0x1807C58C0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool EAHFAJPHIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x64F8C20", Offset = "0x64F7820", VA = "0x1864F8C20", Slot = "24")]
	private bool IODFJAPHOEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x64F8C10", Offset = "0x64F7810", VA = "0x1864F8C10", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x64F8C40", Offset = "0x64F7840", VA = "0x1864F8C40")]
	public CMIJLBKPGBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum DMPIALGBEOE : byte
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
internal sealed class OKKIFMIGJFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum IMGJHDOEBOH
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct IKEFEEJJDHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public JDDMPIEJENJ NOJBNMEAEEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public IMGJHDOEBOH JCIPCJMNHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public List<ABFHHILCHPH> KHCKDODKABG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly IMGJHDOEBOH[] DBBEPJANCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly JDDMPIEJENJ OMGIHEDMDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private bool DIOKICNACHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly ABFHHILCHPH[] JAPJONKPFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<ABFHHILCHPH> NPACMGGMGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> DOELLFOGLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<ABFHHILCHPH> AOCCHLDGLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<int> HMEPGILGKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly EHCPBNNOJLG CADPJLAMILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private bool JHFIBBJAKBG;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public IKEFEEJJDHM[,] FNHDHINHNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x776710", Offset = "0x775310", VA = "0x180776710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x650F090", Offset = "0x650DC90", VA = "0x18650F090")]
	public OKKIFMIGJFL(JDDMPIEJENJ OAOBAEBKDCM, EHCPBNNOJLG CADPJLAMILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x650E830", Offset = "0x650D430", VA = "0x18650E830")]
	public void HBKJKKGNHDJ(ABFHHILCHPH OPIBKMPHBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x650DE20", Offset = "0x650CA20", VA = "0x18650DE20")]
	public void EDLLEANPIJG(IList<ABFHHILCHPH> GJNBLJFBPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x650E130", Offset = "0x650CD30", VA = "0x18650E130")]
	public void ELNMJEMLFJL(IList<ABFHHILCHPH> GJNBLJFBPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x650E740", Offset = "0x650D340", VA = "0x18650E740")]
	private void GBMNNKJCFAJ(ABFHHILCHPH OPIBKMPHBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x650DB70", Offset = "0x650C770", VA = "0x18650DB70")]
	private void DPLCHAJOEJB(IList<ABFHHILCHPH> GJNBLJFBPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x650EA70", Offset = "0x650D670", VA = "0x18650EA70")]
	private DMPIALGBEOE JIKPNPBHKCC(ABFHHILCHPH OPIBKMPHBKJ)
	{
		return default(DMPIALGBEOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x650EDE0", Offset = "0x650D9E0", VA = "0x18650EDE0")]
	public void OFENLADEDFE(float MKJMBIGEENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x650EBF0", Offset = "0x650D7F0", VA = "0x18650EBF0")]
	public void OEAOOJLOLAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x650E440", Offset = "0x650D040", VA = "0x18650E440")]
	private void FAHCBOAEEKC(List<ABFHHILCHPH> GJNBLJFBPMD, Stack<int> BLNJNDPNKPK, bool BEKEBIOPHBK, float JIDJCPKDHLI = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x650DD00", Offset = "0x650C900", VA = "0x18650DD00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x650E930", Offset = "0x650D530", VA = "0x18650E930")]
	private void HKOLKLKBKAF(List<ABFHHILCHPH> GJNBLJFBPMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class CNMJNHJCNCN : EHCPBNNOJLG
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "4")]
	public void CKAEKNIMHLH(string JEICAPDKHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
	public void PDDHGNKCPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public CNMJNHJCNCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class CBFGAMDGHMG : PEKILLHDHED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Behaviour GOOEIIAOGIE;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string ODBDFCEODFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x64F7C50", Offset = "0x64F6850", VA = "0x1864F7C50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool IBAGIICNAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x64F7CD0", Offset = "0x64F68D0", VA = "0x1864F7CD0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool IGCJDBMBFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x64F7D20", Offset = "0x64F6920", VA = "0x1864F7D20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	public CBFGAMDGHMG(Behaviour GOOEIIAOGIE)
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

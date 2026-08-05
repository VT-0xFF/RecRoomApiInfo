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
	[Cpp2IlInjected.Address(RVA = "0x650A650", Offset = "0x6509250", VA = "0x18650A650")]
	public NBBDKPKLKBH(ThreadPriority KNAODNCOIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x650A640", Offset = "0x6509240", VA = "0x18650A640", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x650A690", Offset = "0x6509290", VA = "0x18650A690")]
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
				[Cpp2IlInjected.Address(RVA = "0x64FF090", Offset = "0x64FDC90", VA = "0x1864FF090")]
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
				[Cpp2IlInjected.Address(RVA = "0x64F6DB0", Offset = "0x64F59B0", VA = "0x1864F6DB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x650AF60", Offset = "0x6509B60", VA = "0x18650AF60")]
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
				[Cpp2IlInjected.Address(RVA = "0x6507030", Offset = "0x6505C30", VA = "0x186507030")]
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
				[Cpp2IlInjected.Address(RVA = "0x650D7F0", Offset = "0x650C3F0", VA = "0x18650D7F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x65062D0", Offset = "0x6504ED0", VA = "0x1865062D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6506660", Offset = "0x6505260", VA = "0x186506660")]
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
				[Cpp2IlInjected.Address(RVA = "0x6502850", Offset = "0x6501450", VA = "0x186502850")]
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
				[Cpp2IlInjected.Address(RVA = "0x6506E30", Offset = "0x6505A30", VA = "0x186506E30")]
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
				[Cpp2IlInjected.Address(RVA = "0x6509390", Offset = "0x6507F90", VA = "0x186509390")]
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
				[Cpp2IlInjected.Address(RVA = "0x650FBD0", Offset = "0x650E7D0", VA = "0x18650FBD0")]
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
					[Cpp2IlInjected.Address(RVA = "0x650FB50", Offset = "0x650E750", VA = "0x18650FB50")]
					internal void JHBKBPLAAHD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static LBFCDLOMLLJ<LOLDKBNAHLG> DCPNJOOGLJK;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x650A8F0", Offset = "0x65094F0", VA = "0x18650A8F0")]
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
					[Cpp2IlInjected.Address(RVA = "0x6506980", Offset = "0x6505580", VA = "0x186506980")]
					internal void PHKCEPFLLMF()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable LFMEENAPNFO;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x64FE480", Offset = "0x64FD080", VA = "0x1864FE480")]
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
					[Cpp2IlInjected.Address(RVA = "0x64FE930", Offset = "0x64FD530", VA = "0x1864FE930")]
					internal void PHKCEPFLLMF()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x65061A0", Offset = "0x6504DA0", VA = "0x1865061A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6506860", Offset = "0x6505460", VA = "0x186506860")]
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
			[Cpp2IlInjected.Address(RVA = "0x64F94B0", Offset = "0x64F80B0", VA = "0x1864F94B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64F94F0", Offset = "0x64F80F0", VA = "0x1864F94F0")]
		private static void GFCIGKCIMKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64FC110", Offset = "0x64FAD10", VA = "0x1864FC110")]
		private static void PDLLMBDJPIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64F8EA0", Offset = "0x64F7AA0", VA = "0x1864F8EA0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64FBE20", Offset = "0x64FAA20", VA = "0x1864FBE20")]
		private static void KJBIIGELHJM(NPFBMADIIPK.LICODONEFDE PPNDANAOAMK, PlayerLoopSystem OBHHECFDCBJ, Type JACICKIIBNN, Type NDGLEGCCEIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64F90D0", Offset = "0x64F7CD0", VA = "0x1864F90D0")]
		private static void CGANKCPGCOD(PlayerLoopSystem OBHHECFDCBJ, Type JACICKIIBNN, Type NDGLEGCCEIB, OCNCJDLJICA IHKGBOEDBKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64FBFE0", Offset = "0x64FABE0", VA = "0x1864FBFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64FEE40", Offset = "0x64FDA40", VA = "0x1864FEE40")]
		public EIAMDBNJBIM(LICODONEFDE JDJCOLBMMMI, int NAFKPBONEMK = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64FEDD0", Offset = "0x64FD9D0", VA = "0x1864FEDD0")]
		public void FGLOODEMKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64FED80", Offset = "0x64FD980", VA = "0x1864FED80")]
		public void FDFIADLCGPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x64FEBA0", Offset = "0x64FD7A0", VA = "0x1864FEBA0")]
		public void COCBHFMLPPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static LICODONEFDE[] FEBILHPNMFG;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static EIAMDBNJBIM[] ELFFNOIHGMP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x650CBD0", Offset = "0x650B7D0", VA = "0x18650CBD0")]
	public static EIAMDBNJBIM EDHGPPPOLBJ(LICODONEFDE PPNDANAOAMK, int NAFKPBONEMK = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x650CB60", Offset = "0x650B760", VA = "0x18650CB60")]
	public static EIAMDBNJBIM AAJFHEONFJF(LICODONEFDE PPNDANAOAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x650CDB0", Offset = "0x650B9B0", VA = "0x18650CDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F8C70", Offset = "0x64F7870", VA = "0x1864F8C70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C968A0", Offset = "0x1C954A0", VA = "0x181C968A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x64F8DF0", Offset = "0x64F79F0", VA = "0x1864F8DF0")]
	public COCHONPIIMJ(int KHAHMFGFOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x64F8CD0", Offset = "0x64F78D0", VA = "0x1864F8CD0", Slot = "7")]
	public void PCMHIIGLNJL(double FEGNLFKFNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x64F8C00", Offset = "0x64F7800", VA = "0x1864F8C00", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x54AA140", Offset = "0x54A8D40", VA = "0x1854AA140", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double PHOJMIEKCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x54AA150", Offset = "0x54A8D50", VA = "0x1854AA150", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double CGBIPGPBHLI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x54AA190", Offset = "0x54A8D90", VA = "0x1854AA190")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double HEPNENLNJLB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x20A17B0", Offset = "0x20A03B0", VA = "0x1820A17B0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x64FDCB0", Offset = "0x64FC8B0", VA = "0x1864FDCB0", Slot = "7")]
	public virtual void PCMHIIGLNJL(double FEGNLFKFNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x64FDC70", Offset = "0x64FC870", VA = "0x1864FDC70", Slot = "8")]
	public virtual void GPJBDIFOFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x64FDDD0", Offset = "0x64FC9D0", VA = "0x1864FDDD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x54AA100", Offset = "0x54A8D00", VA = "0x1854AA100")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x54AA160", Offset = "0x54A8D60", VA = "0x1854AA160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6503F90", Offset = "0x6502B90", VA = "0x186503F90", Slot = "7")]
	public override void PCMHIIGLNJL(double FEGNLFKFNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6503F50", Offset = "0x6502B50", VA = "0x186503F50", Slot = "8")]
	public override void GPJBDIFOFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x64FDDD0", Offset = "0x64FC9D0", VA = "0x1864FDDD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D13FC0", Offset = "0x3D12BC0", VA = "0x183D13FC0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool LGBMKJOOGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3D14040", Offset = "0x3D12C40", VA = "0x183D14040", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D14020", Offset = "0x3D12C20", VA = "0x183D14020", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x370FB90", Offset = "0x370E790", VA = "0x18370FB90")]
		public IDCCKJGBENO(HPJLJGHAIKN<T> KGEPMDDGDNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x370F9E0", Offset = "0x370E5E0", VA = "0x18370F9E0", Slot = "6")]
		protected override void BBOLKGLKAND(HPJLJGHAIKN<T> KGEPMDDGDNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x370FB60", Offset = "0x370E760", VA = "0x18370FB60")]
		[CompilerGenerated]
		private void NNIFKJCDNCF(T HNCONAMCFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x370FB30", Offset = "0x370E730", VA = "0x18370FB30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2641130", Offset = "0x263FD30", VA = "0x182641130")]
	public static HPJLJGHAIKN<T> CHKHEOKMPLI<T>(this HPJLJGHAIKN<T> KGEPMDDGDNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x650CFF0", Offset = "0x650BBF0", VA = "0x18650CFF0")]
	public static void CHKHEOKMPLI(Action GAFABDCELFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2641190", Offset = "0x263FD90", VA = "0x182641190")]
	private static HPJLJGHAIKN<T> LHKNLIKMGBG<T>(HPJLJGHAIKN<T> KGEPMDDGDNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x650D550", Offset = "0x650C150", VA = "0x18650D550")]
	private static void MOPPJCCGAAC(BHJLDIKEGMI MOIKCCHFFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x650D170", Offset = "0x650BD70", VA = "0x18650D170")]
	private static void CPMDNEHBFMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x650D450", Offset = "0x650C050", VA = "0x18650D450")]
	private static void FJMCNFODABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x650D090", Offset = "0x650BC90", VA = "0x18650D090")]
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
		[Cpp2IlInjected.Address(RVA = "0x64FE3F0", Offset = "0x64FCFF0", VA = "0x1864FE3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6503640", Offset = "0x6502240", VA = "0x186503640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6503EE0", Offset = "0x6502AE0", VA = "0x186503EE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x64FE5B0", Offset = "0x64FD1B0", VA = "0x1864FE5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x64FE8D0", Offset = "0x64FD4D0", VA = "0x1864FE8D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x650AB50", Offset = "0x6509750", VA = "0x18650AB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x650AF00", Offset = "0x6509B00", VA = "0x18650AF00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x650A890", Offset = "0x6509490", VA = "0x18650A890")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F6FB0", Offset = "0x64F5BB0", VA = "0x1864F6FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x64F7B50", Offset = "0x64F6750", VA = "0x1864F7B50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x650A0C0", Offset = "0x6508CC0", VA = "0x18650A0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x650A5D0", Offset = "0x65091D0", VA = "0x18650A5D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F61C0", Offset = "0x64F4DC0", VA = "0x1864F61C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x64F6D10", Offset = "0x64F5910", VA = "0x1864F6D10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F6D80", Offset = "0x64F5980", VA = "0x1864F6D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6509B60", Offset = "0x6508760", VA = "0x186509B60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x65097D0", Offset = "0x65083D0", VA = "0x1865097D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6509780", Offset = "0x6508380", VA = "0x186509780")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6509B10", Offset = "0x6508710", VA = "0x186509B10", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6509090", Offset = "0x6507C90", VA = "0x186509090")]
		internal bool GFMLALAGLEO(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6509110", Offset = "0x6507D10", VA = "0x186509110")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F7CB0", Offset = "0x64F68B0", VA = "0x1864F7CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x64F83C0", Offset = "0x64F6FC0", VA = "0x1864F83C0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x650BD40", Offset = "0x650A940", VA = "0x18650BD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool EBIBGGIOPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x650C820", Offset = "0x650B420", VA = "0x18650C820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool DPPMICCLCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x650C3E0", Offset = "0x650AFE0", VA = "0x18650C3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool PEDMODBBGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x650B460", Offset = "0x650A060", VA = "0x18650B460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> KEBNKECBEAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x650C620", Offset = "0x650B220", VA = "0x18650C620")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x650C510", Offset = "0x650B110", VA = "0x18650C510")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x650BC40", Offset = "0x650A840", VA = "0x18650BC40")]
	[HOLDLPLBEIB(FCMNCHNNIBN.EnteredEditModeNextFrame, 0)]
	private static void HMCKLOGDGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x650B250", Offset = "0x6509E50", VA = "0x18650B250")]
	[AsyncStateMachine(typeof(HLKBBLLMAFI))]
	public static Task<Scene> BDAHJPDIAJF(string AEGJFANOGND, LoadSceneMode KBLMDIMGMIA = LoadSceneMode.Single, bool HJGBGLLLDNP = false, [Optional] FIKFBEICCGA<string>.DJKJOCCHFDH CCDPNGCCOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x650C8C0", Offset = "0x650B4C0", VA = "0x18650C8C0")]
	[AsyncStateMachine(typeof(EGIBDAOIEEF))]
	private static Task PMPDDCPEKHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x650B920", Offset = "0x650A520", VA = "0x18650B920")]
	[AsyncStateMachine(typeof(NLCOGODJDMP))]
	private static Task EBLDMJPGKKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x650C290", Offset = "0x650AE90", VA = "0x18650C290")]
	[AsyncStateMachine(typeof(BOFGNHNPKLM))]
	private static Task<Scene> LFELNJJFCIE(string AEGJFANOGND, LoadSceneMode KBLMDIMGMIA, bool HJGBGLLLDNP, FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x650B4F0", Offset = "0x650A0F0", VA = "0x18650B4F0")]
	private static void DKDJOBAFJKM(SceneInstance BJMIJNLECJK, LoadSceneMode KBLMDIMGMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x650B3A0", Offset = "0x6509FA0", VA = "0x18650B3A0")]
	private static void BEAPEOKKEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x650B9F0", Offset = "0x650A5F0", VA = "0x18650B9F0")]
	[AsyncStateMachine(typeof(MOIMCENJFMI))]
	private static Task<Scene> EGAHKNCMECF(string AEGJFANOGND, LoadSceneMode KBLMDIMGMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x650C730", Offset = "0x650B330", VA = "0x18650C730")]
	private static bool OEBMLGNPECA(string AEGJFANOGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x650C180", Offset = "0x650AD80", VA = "0x18650C180")]
	[AsyncStateMachine(typeof(AMFMIDLMELM))]
	private static Task<Scene> KHLADLKOPBD(FIKFBEICCGA<string>.DJKJOCCHFDH HPDFPIMFEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x650BF60", Offset = "0x650AB60", VA = "0x18650BF60")]
	public static HPJLJGHAIKN<Scene> INEAAMPCMKB(string AEGJFANOGND, LoadSceneMode KBLMDIMGMIA = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x650B650", Offset = "0x650A250", VA = "0x18650B650")]
	public static CKPENFELBCE DLEFKJKBONF(string AEGJFANOGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x650C480", Offset = "0x650B080", VA = "0x18650C480")]
	[IteratorStateMachine(typeof(MFNHIJMNMMF))]
	private static IEnumerator<MJMKCFLBGFK> NHLBPNDBANF(string AEGJFANOGND, EEHJIENCILF COIDABEHDID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x650C0E0", Offset = "0x650ACE0", VA = "0x18650C0E0")]
	[IteratorStateMachine(typeof(CBONMGGPMMG))]
	private static IEnumerator<MJMKCFLBGFK> KBKGDJONNIL(string AEGJFANOGND, LoadSceneMode KBLMDIMGMIA, KNCNIEDDCNP<Scene> COIDABEHDID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x650BB10", Offset = "0x650A710", VA = "0x18650BB10")]
	public static bool GGMHLJNNJJD([Out] string EGHCKDODCMM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class JCNDGDPKLKI
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x65065D0", Offset = "0x65051D0", VA = "0x1865065D0")]
	public static IDisposable OKBGDIENJGC(this NFOEPLCKIPF BFDLBONPDOA, float OJPLGLBNMAF, Action<float> AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6506550", Offset = "0x6505150", VA = "0x186506550")]
	public static IDisposable NLPINCPAEOB(this NFOEPLCKIPF BFDLBONPDOA, Action<float> AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x65064D0", Offset = "0x65050D0", VA = "0x1865064D0")]
	public static IDisposable CHCCLKANBJN(this NFOEPLCKIPF BFDLBONPDOA, Action<float> AEJECABIACB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class IHKBCNDLDFI
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6504910", Offset = "0x6503510", VA = "0x186504910")]
	public static IDisposable DECICPPNPFM(this MonoBehaviour GOOEIIAOGIE, Action AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x65049A0", Offset = "0x65035A0", VA = "0x1865049A0")]
	public static IDisposable DECICPPNPFM(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6505330", Offset = "0x6503F30", VA = "0x186505330")]
	public static IDisposable OFENLADEDFE(this MonoBehaviour GOOEIIAOGIE, Action AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x65053B0", Offset = "0x6503FB0", VA = "0x1865053B0")]
	public static IDisposable PDJCDDIBAPG(this MonoBehaviour GOOEIIAOGIE, Action AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6505430", Offset = "0x6504030", VA = "0x186505430")]
	public static IDisposable PDJCDDIBAPG(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6504D30", Offset = "0x6503930", VA = "0x186504D30")]
	public static IDisposable IFJOALODFCO(this MonoBehaviour GOOEIIAOGIE, Action AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x65050C0", Offset = "0x6503CC0", VA = "0x1865050C0")]
	public static IDisposable MOJCDBMDEBF(this MonoBehaviour GOOEIIAOGIE, Action AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6504A30", Offset = "0x6503630", VA = "0x186504A30")]
	public static IDisposable DIACKONLNHN(this MonoBehaviour GOOEIIAOGIE, Action AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6505010", Offset = "0x6503C10", VA = "0x186505010")]
	public static IDisposable KEEBIIHCDLM(this MonoBehaviour GOOEIIAOGIE, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6504DB0", Offset = "0x65039B0", VA = "0x186504DB0")]
	public static IDisposable IJMELMLACMI(this MonoBehaviour GOOEIIAOGIE, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6504F70", Offset = "0x6503B70", VA = "0x186504F70")]
	public static IDisposable KEDNPIDPABH(this MonoBehaviour GOOEIIAOGIE, float OJPLGLBNMAF, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6504B50", Offset = "0x6503750", VA = "0x186504B50")]
	public static IDisposable FCJPAKILCKJ(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6504AB0", Offset = "0x65036B0", VA = "0x186504AB0")]
	public static IDisposable EIJFLKEGLOH(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6504C90", Offset = "0x6503890", VA = "0x186504C90")]
	public static IDisposable GNBGHEDCINK(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6504BF0", Offset = "0x65037F0", VA = "0x186504BF0")]
	public static IDisposable FGGOLAJHDLI(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6504ED0", Offset = "0x6503AD0", VA = "0x186504ED0")]
	public static IDisposable KEDFFMFBPAO(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6505290", Offset = "0x6503E90", VA = "0x186505290")]
	public static IDisposable OEJMKADPFDM(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x65051F0", Offset = "0x6503DF0", VA = "0x1865051F0")]
	public static IDisposable NMMEGKDBDNB(this MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6505140", Offset = "0x6503D40", VA = "0x186505140")]
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
		[Cpp2IlInjected.Address(RVA = "0x650FDD0", Offset = "0x650E9D0", VA = "0x18650FDD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x650FEB0", Offset = "0x650EAB0", VA = "0x18650FEB0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F5810", Offset = "0x64F4410", VA = "0x1864F5810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x64F5900", Offset = "0x64F4500", VA = "0x1864F5900", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x65078B0", Offset = "0x65064B0", VA = "0x1865078B0")]
	public static IHPHLOENKON DECICPPNPFM(Action AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6507960", Offset = "0x6506560", VA = "0x186507960")]
	public static IHPHLOENKON DECICPPNPFM(Behaviour BFDLBONPDOA, Action AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6507A20", Offset = "0x6506620", VA = "0x186507A20")]
	public static IHPHLOENKON DECICPPNPFM(Behaviour BFDLBONPDOA, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6507BD0", Offset = "0x65067D0", VA = "0x186507BD0")]
	[IteratorStateMachine(typeof(PFLDMEKJHLF))]
	private static IEnumerator<MJMKCFLBGFK> DNNEKAPPKBN(JDDMPIEJENJ OAOBAEBKDCM, Action AEJECABIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6507B40", Offset = "0x6506740", VA = "0x186507B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x65040C0", Offset = "0x6502CC0", VA = "0x1865040C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6504150", Offset = "0x6502D50", VA = "0x186504150", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x64F8530", Offset = "0x64F7130", VA = "0x1864F8530")]
	public CDPAEKKAOFB(JDDMPIEJENJ OMGIHEDMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x64F8410", Offset = "0x64F7010", VA = "0x1864F8410")]
	[IteratorStateMachine(typeof(IBDCFMBHDAH))]
	private IEnumerator<MJMKCFLBGFK> MAMDMFOAODA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x64F8490", Offset = "0x64F7090", VA = "0x1864F8490", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x64FEF50", Offset = "0x64FDB50", VA = "0x1864FEF50")]
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
		[Cpp2IlInjected.Address(RVA = "0x65096B0", Offset = "0x65082B0", VA = "0x1865096B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6509730", Offset = "0x6508330", VA = "0x186509730", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x64FDF70", Offset = "0x64FCB70", VA = "0x1864FDF70")]
	public static IHPHLOENKON DECICPPNPFM(float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x64FDE60", Offset = "0x64FCA60", VA = "0x1864FDE60")]
	public static IHPHLOENKON DECICPPNPFM(MonoBehaviour GOOEIIAOGIE, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x64FE2D0", Offset = "0x64FCED0", VA = "0x1864FE2D0")]
	public static IHPHLOENKON KJCIHLCJLPL(MonoBehaviour GOOEIIAOGIE, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x64FE1C0", Offset = "0x64FCDC0", VA = "0x1864FE1C0")]
	public static IHPHLOENKON KCFEIIGOOIM(NFOEPLCKIPF BFDLBONPDOA, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x64FE070", Offset = "0x64FCC70", VA = "0x1864FE070")]
	private static IEnumerator<MJMKCFLBGFK> DNNEKAPPKBN(OILOBEMANON HALOMOONKFP, float OJPLGLBNMAF, JDDMPIEJENJ OAOBAEBKDCM, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x64FDE00", Offset = "0x64FCA00", VA = "0x1864FDE00")]
	private static IEnumerator<MJMKCFLBGFK> AFPGBCJDJBF(OILOBEMANON HALOMOONKFP, float OJPLGLBNMAF, JDDMPIEJENJ OAOBAEBKDCM, Action<float> AEJECABIACB, bool FNMMHOPNMDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x64FE130", Offset = "0x64FCD30", VA = "0x1864FE130")]
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
		[Cpp2IlInjected.Address(RVA = "0x6503530", Offset = "0x6502130", VA = "0x186503530", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x65035F0", Offset = "0x65021F0", VA = "0x1865035F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6506DA0", Offset = "0x65059A0", VA = "0x186506DA0")]
	[IteratorStateMachine(typeof(HKFCBHAABNB))]
	private static IEnumerator<MJMKCFLBGFK> KNGKELBJOOD(JDDMPIEJENJ OMGIHEDMDMD, Func<bool> LHLJIIDKOKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6506C80", Offset = "0x6505880", VA = "0x186506C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F5950", Offset = "0x64F4550", VA = "0x1864F5950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x64F59C0", Offset = "0x64F45C0", VA = "0x1864F59C0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x65095D0", Offset = "0x65081D0", VA = "0x1865095D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6509660", Offset = "0x6508260", VA = "0x186509660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x65025F0", Offset = "0x65011F0", VA = "0x1865025F0")]
	[IteratorStateMachine(typeof(AFGNKJMPAPL))]
	private static IEnumerator<MJMKCFLBGFK> MAMDMFOAODA(float FOGEGHJNDKP, JDDMPIEJENJ OAOBAEBKDCM, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6501F00", Offset = "0x6500B00", VA = "0x186501F00")]
	[IteratorStateMachine(typeof(LMKKGMFOBMK))]
	private static IEnumerator<MJMKCFLBGFK> AMIPJAGKDMH(float FOGEGHJNDKP, JDDMPIEJENJ OAOBAEBKDCM, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x65022D0", Offset = "0x6500ED0", VA = "0x1865022D0")]
	public static IDisposable LAIMCGPIGJO(this MonoBehaviour GOOEIIAOGIE, float FOGEGHJNDKP, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x65026C0", Offset = "0x65012C0", VA = "0x1865026C0")]
	public static IHPHLOENKON NMDPGGAKPFD(this MonoBehaviour GOOEIIAOGIE, float FOGEGHJNDKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x65023F0", Offset = "0x6500FF0", VA = "0x1865023F0")]
	public static IHPHLOENKON LAIMCGPIGJO(this MonoBehaviour GOOEIIAOGIE, float FOGEGHJNDKP, JDDMPIEJENJ OAOBAEBKDCM, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6501FD0", Offset = "0x6500BD0", VA = "0x186501FD0")]
	public static IHPHLOENKON CFOAMOIJPMG(this MonoBehaviour GOOEIIAOGIE, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x65022A0", Offset = "0x6500EA0", VA = "0x1865022A0")]
	public static IHPHLOENKON JJIHAMJADEE(this MonoBehaviour GOOEIIAOGIE, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6501FF0", Offset = "0x6500BF0", VA = "0x186501FF0")]
	public static IHPHLOENKON CPLOFCLJIKD(this MonoBehaviour GOOEIIAOGIE, Action CPCNABCMKCJ, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x65020D0", Offset = "0x6500CD0", VA = "0x1865020D0")]
	public static IHPHLOENKON DPMHKLPFMCJ(this MonoBehaviour GOOEIIAOGIE, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6502690", Offset = "0x6501290", VA = "0x186502690")]
	public static IHPHLOENKON NJGILGKDBII(this MonoBehaviour GOOEIIAOGIE, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6501FA0", Offset = "0x6500BA0", VA = "0x186501FA0")]
	public static IHPHLOENKON BDEHPBIALHI(this MonoBehaviour GOOEIIAOGIE, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6502520", Offset = "0x6501120", VA = "0x186502520")]
	private static IHPHLOENKON LFAIPGKKFAI(MonoBehaviour GOOEIIAOGIE, JDDMPIEJENJ OMGIHEDMDMD, Action CPCNABCMKCJ, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x65021D0", Offset = "0x6500DD0", VA = "0x1865021D0")]
	public static IHPHLOENKON INBGJCOFKNO(this MonoBehaviour GOOEIIAOGIE, float NENFHBGKLGL, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6502100", Offset = "0x6500D00", VA = "0x186502100")]
	public static IHPHLOENKON FNEPCFFFEJF(this MonoBehaviour GOOEIIAOGIE, float NENFHBGKLGL, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6502780", Offset = "0x6501380", VA = "0x186502780")]
	public static IHPHLOENKON PCOEOPJFJIM(this MonoBehaviour GOOEIIAOGIE, float NENFHBGKLGL, Action CPCNABCMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6501E30", Offset = "0x6500A30", VA = "0x186501E30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6502D40", Offset = "0x6501940", VA = "0x186502D40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DDDABAMDEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6503350", Offset = "0x6501F50", VA = "0x186503350", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x65033F0", Offset = "0x6501FF0", VA = "0x1865033F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6503490", Offset = "0x6502090", VA = "0x186503490")]
	public GNPKANJPBGK([Optional] Action LGEAFMICBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6503220", Offset = "0x6501E20", VA = "0x186503220")]
	public void HFMDKEOMMOI(OLMAHMLPJJG IAHFBENMKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6502BE0", Offset = "0x65017E0", VA = "0x186502BE0")]
	private void BEOLKKOEKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6502E80", Offset = "0x6501A80", VA = "0x186502E80", Slot = "7")]
	public bool FNDOHEONCMD(bool JNADMECNEPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6502E90", Offset = "0x6501A90", VA = "0x186502E90", Slot = "8")]
	public bool FNDOHEONCMD(Action GAFABDCELFL, bool JNADMECNEPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x65031A0", Offset = "0x6501DA0", VA = "0x1865031A0", Slot = "9")]
	public IEnumerator<OLMAHMLPJJG> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x65031A0", Offset = "0x6501DA0", VA = "0x1865031A0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x64FE450", Offset = "0x64FD050", VA = "0x1864FE450")]
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
		[Cpp2IlInjected.Address(RVA = "0x64FE450", Offset = "0x64FD050", VA = "0x1864FE450")]
		internal void MIABGCMEEIL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float AMEAHBFGIPK;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x64FF380", Offset = "0x64FDF80", VA = "0x1864FF380")]
	public PHMNPBEJOIP(Behaviour BFDLBONPDOA, float AMEAHBFGIPK, [Optional] Action LGEAFMICBOB, [Optional] MBGPIBEMOCP GNLNBDCDMHC, [Optional] OILOBEMANON HALOMOONKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6510010", Offset = "0x650EC10", VA = "0x186510010", Slot = "9")]
	protected override bool KHNBJFBMAKI(Action GAFABDCELFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x650FF00", Offset = "0x650EB00", VA = "0x18650FF00", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F8640", Offset = "0x64F7240", VA = "0x1864F8640", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x64F8710", Offset = "0x64F7310", VA = "0x1864F8710", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x650F840", Offset = "0x650E440", VA = "0x18650F840", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x650F9B0", Offset = "0x650E5B0", VA = "0x18650F9B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x650FA50", Offset = "0x650E650", VA = "0x18650FA50")]
	protected OLGADNDNDBE(Behaviour BFDLBONPDOA, [Optional] Action LGEAFMICBOB, [Optional] MBGPIBEMOCP GNLNBDCDMHC, [Optional] OILOBEMANON HALOMOONKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x650F520", Offset = "0x650E120", VA = "0x18650F520", Slot = "7")]
	public bool FNDOHEONCMD(bool JNADMECNEPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x650F4C0", Offset = "0x650E0C0", VA = "0x18650F4C0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x650F4A0", Offset = "0x650E0A0", VA = "0x18650F4A0")]
	protected void CBHDIKJLAIB(Action GAFABDCELFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x650F580", Offset = "0x650E180", VA = "0x18650F580")]
	protected CKPENFELBCE FOBNFALDBJB(float EJGELOGDBKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x650F7C0", Offset = "0x650E3C0", VA = "0x18650F7C0")]
	private void GGOLCDMFAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x650F920", Offset = "0x650E520", VA = "0x18650F920")]
	[IteratorStateMachine(typeof(CEHIKJHCEPA))]
	private IEnumerator<MJMKCFLBGFK> MAOADPKHKFJ(float EJGELOGDBKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x650F8E0", Offset = "0x650E4E0", VA = "0x18650F8E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x64F89E0", Offset = "0x64F75E0", VA = "0x1864F89E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x64F8760", Offset = "0x64F7360", VA = "0x1864F8760", Slot = "10")]
	protected override bool BODHOMIGHPA(Action GAFABDCELFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x64F8960", Offset = "0x64F7560", VA = "0x1864F8960")]
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
	[Cpp2IlInjected.Address(RVA = "0x64FF380", Offset = "0x64FDF80", VA = "0x1864FF380")]
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
	[Cpp2IlInjected.Address(RVA = "0x64FF340", Offset = "0x64FDF40", VA = "0x1864FF340", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506BC0", Offset = "0x65057C0", VA = "0x186506BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x650AB00", Offset = "0x6509700", VA = "0x18650AB00", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x6504730", Offset = "0x6503330", VA = "0x186504730")]
	public IGBNDGAMGCO(NFOEPLCKIPF BFDLBONPDOA, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x65041A0", Offset = "0x6502DA0", VA = "0x1865041A0")]
	private void BPFHCGFBGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6504420", Offset = "0x6503020", VA = "0x186504420")]
	private void JGHFPENAIHJ(string GNLAGDDNMDN, Action BHBNOLELJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x65043A0", Offset = "0x6502FA0", VA = "0x1865043A0")]
	[IteratorStateMachine(typeof(NJNEOGFGGJD))]
	private IEnumerator<MJMKCFLBGFK> FKPIOGOOJCC(Action BHBNOLELJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6504340", Offset = "0x6502F40", VA = "0x186504340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6504580", Offset = "0x6503180", VA = "0x186504580")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506BC0", Offset = "0x65057C0", VA = "0x186506BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6506C30", Offset = "0x6505830", VA = "0x186506C30", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x64FDA80", Offset = "0x64FC680", VA = "0x1864FDA80")]
	public DEIGOLNDPJE(MonoBehaviour GOOEIIAOGIE, Action AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x64FD5F0", Offset = "0x64FC1F0", VA = "0x1864FD5F0")]
	public DEIGOLNDPJE(MonoBehaviour GOOEIIAOGIE, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x64FD830", Offset = "0x64FC430", VA = "0x1864FD830")]
	public DEIGOLNDPJE(MonoBehaviour GOOEIIAOGIE, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1891510", Offset = "0x1890110", VA = "0x181891510")]
	private DEIGOLNDPJE(MBGPIBEMOCP GNLNBDCDMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x64FCD00", Offset = "0x64FB900", VA = "0x1864FCD00")]
	internal static DEIGOLNDPJE DENMLCBCLKK(MonoBehaviour GOOEIIAOGIE, float OJPLGLBNMAF, Action<float> AEJECABIACB, JDDMPIEJENJ OMGIHEDMDMD, bool FNMMHOPNMDJ = true, [Optional] MBGPIBEMOCP GNLNBDCDMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x64FCB90", Offset = "0x64FB790", VA = "0x1864FCB90")]
	private void DECICPPNPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x64FCFA0", Offset = "0x64FBBA0", VA = "0x1864FCFA0")]
	private void HEOIJEFJMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x64FC9E0", Offset = "0x64FB5E0", VA = "0x1864FC9E0")]
	private void BPFHCGFBGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x64FD280", Offset = "0x64FBE80", VA = "0x1864FD280")]
	private void JLMAMGEIAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x64FD150", Offset = "0x64FBD50", VA = "0x1864FD150")]
	private void JGHFPENAIHJ(string GNLAGDDNMDN, Action BHBNOLELJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x64FCF20", Offset = "0x64FBB20", VA = "0x1864FCF20")]
	[IteratorStateMachine(typeof(JOOEFKILMPB))]
	private IEnumerator<MJMKCFLBGFK> FKPIOGOOJCC(Action BHBNOLELJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x64FCE30", Offset = "0x64FBA30", VA = "0x1864FCE30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x64FD4D0", Offset = "0x64FC0D0", VA = "0x1864FD4D0")]
	[CompilerGenerated]
	private void MHIJIGJNEEF(string PFNPJMEIKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x64FD560", Offset = "0x64FC160", VA = "0x1864FD560")]
	[CompilerGenerated]
	private void PCKPMFCPAKC(string PFNPJMEIKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x64FCE90", Offset = "0x64FBA90", VA = "0x1864FCE90")]
	[CompilerGenerated]
	private void FHBFGFIJPBM(string PFNPJMEIKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x64FD440", Offset = "0x64FC040", VA = "0x1864FD440")]
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
		[Cpp2IlInjected.Address(RVA = "0x64FF330", Offset = "0x64FDF30", VA = "0x1864FF330", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float IIAMMIHNHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x64FF320", Offset = "0x64FDF20", VA = "0x1864FF320", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double CPBGANIIHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x64FF290", Offset = "0x64FDE90", VA = "0x1864FF290", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x64FF2B0", Offset = "0x64FDEB0", VA = "0x1864FF2B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6509EA0", Offset = "0x6508AA0", VA = "0x186509EA0")]
	public static MJMKCFLBGFK LPAHLLPIDIG(IEnumerator<MJMKCFLBGFK> OPIBKMPHBKJ, CMIJLBKPGBH IFLPCIJGAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x650A000", Offset = "0x6508C00", VA = "0x18650A000")]
	public MJMKCFLBGFK LPAHLLPIDIG(CMIJLBKPGBH[] GLJDEEIAFCH, IEnumerator<MJMKCFLBGFK>[] GJNBLJFBPMD, MJMKCFLBGFK[] PNJHPLDGKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6509E70", Offset = "0x6508A70", VA = "0x186509E70")]
	public void FMMHIFOKFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6509BF0", Offset = "0x65087F0", VA = "0x186509BF0")]
	public void DKGGPDKEFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6509D30", Offset = "0x6508930", VA = "0x186509D30")]
	public void DPBCNJHHIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6509E70", Offset = "0x6508A70", VA = "0x186509E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F5A10", Offset = "0x64F4610", VA = "0x1864F5A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x650AAC0", Offset = "0x65096C0", VA = "0x18650AAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6509590", Offset = "0x6508190", VA = "0x186509590")]
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
		[Cpp2IlInjected.Address(RVA = "0x6502BA0", Offset = "0x65017A0", VA = "0x186502BA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6500250", Offset = "0x64FEE50", VA = "0x186500250")]
	private static int ECBKBAHKAFJ(JDDMPIEJENJ OMGIHEDMDMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x65017E0", Offset = "0x65003E0", VA = "0x1865017E0")]
	public FDALFCGDCLB(JDDMPIEJENJ OMGIHEDMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6500AC0", Offset = "0x64FF6C0", VA = "0x186500AC0")]
	private void KFBGFGBHEJA(int LJEDKGJMBKF, int JFMAFLEDHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6500DE0", Offset = "0x64FF9E0", VA = "0x186500DE0")]
	public void NIHHMFHDKGJ(NFOEPLCKIPF BFDLBONPDOA, MJMKCFLBGFK ACKBEBLMBFM, IEnumerator<MJMKCFLBGFK> OPIBKMPHBKJ, CMIJLBKPGBH IFLPCIJGAMI, [Optional] MMFFNECGAFJ AJNOGBACFNI, CAEIJHAPBLE NKKNLIOGJKB = CAEIJHAPBLE.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6500880", Offset = "0x64FF480", VA = "0x186500880")]
	public void JNBPJJIDHKJ(IEnumerable<JAOPLGMAOED> NCJGLNDGBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6501310", Offset = "0x64FFF10", VA = "0x186501310")]
	private JAOPLGMAOED PJONINEEAHD(int DCFJBMBDMKB)
	{
		return default(JAOPLGMAOED);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x64FFEE0", Offset = "0x64FEAE0", VA = "0x1864FFEE0")]
	private void DHEANCNMCKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x24DB340", Offset = "0x24D9F40", VA = "0x1824DB340")]
	private static void LBIAINGFPBA<T>(int DCFJBMBDMKB, T[] CECHCHAPPHM, int JIGGJNDJAAO, [Optional] T CHDGLADFILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x24DB390", Offset = "0x24D9F90", VA = "0x1824DB390")]
	private static void LBIAINGFPBA<T>(int DCFJBMBDMKB, NativeArray<T> CECHCHAPPHM, int JIGGJNDJAAO, [Optional] T CHDGLADFILO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6500280", Offset = "0x64FEE80", VA = "0x186500280")]
	private void IFDKDFPJMNK(IEnumerable<JAOPLGMAOED> NCJGLNDGBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6500CA0", Offset = "0x64FF8A0", VA = "0x186500CA0")]
	private void KMJKADINPCP(JAOPLGMAOED EABJJONGPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x64FF580", Offset = "0x64FE180", VA = "0x1864FF580")]
	private DMPIALGBEOE BMPJIJFFLOK(int IGDLAJOPPKG)
	{
		return default(DMPIALGBEOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6501090", Offset = "0x64FFC90", VA = "0x186501090")]
	public void PCMAHJOMNPA(float MKJMBIGEENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6501290", Offset = "0x64FFE90", VA = "0x186501290")]
	private void PGIENDHFLMB(Action FLGIINLNNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6500D60", Offset = "0x64FF960", VA = "0x186500D60")]
	private void NFFOBLHMGJO(Action FLGIINLNNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x64FF7E0", Offset = "0x64FE3E0", VA = "0x1864FF7E0")]
	public void DBCKMPGPGIP(float MKJMBIGEENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x64FF480", Offset = "0x64FE080", VA = "0x1864FF480")]
	public void BAMMMHDNJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6500620", Offset = "0x64FF220", VA = "0x186500620")]
	public void IIEKIHINOBM(MMFFNECGAFJ BBJOPLNJGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6500750", Offset = "0x64FF350", VA = "0x186500750")]
	public void JINCNFKLOJI(MMFFNECGAFJ BBJOPLNJGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6500F60", Offset = "0x64FFB60", VA = "0x186500F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x6502A50", Offset = "0x6501650", VA = "0x186502A50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x39CC990", Offset = "0x39CB590", VA = "0x1839CC990")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E00160", Offset = "0x3DFED60", VA = "0x183E00160", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3E00090", Offset = "0x3DFEC90", VA = "0x183E00090")]
	private static bool DNLHGDHNGLE(T FLGIINLNNEM, T KNDAEONALIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3E00BE0", Offset = "0x3DFF7E0", VA = "0x183E00BE0")]
	public OILGONPAKBJ(T OLDKAGOIIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3E00A50", Offset = "0x3DFF650", VA = "0x183E00A50", Slot = "6")]
	public IDisposable MILIMNCIABD(UnityEngine.Object BFDLBONPDOA, Action<T> KMMIANLGJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3E00260", Offset = "0x3DFEE60", VA = "0x183E00260")]
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
	[Cpp2IlInjected.Address(RVA = "0x6507230", Offset = "0x6505E30", VA = "0x186507230")]
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
	[Cpp2IlInjected.Address(RVA = "0x65072A0", Offset = "0x6505EA0", VA = "0x1865072A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6505890", Offset = "0x6504490", VA = "0x186505890")]
	[GFMBCOBENIN(CDPNEOMLNDL.None)]
	private static void FALOLKAJBGJ(OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x65060E0", Offset = "0x6504CE0", VA = "0x1865060E0")]
	[Preserve]
	public IMFNGIKCJPG([DLBAGNNJKKK(null)] EFJOKGEPKPF FPCFIIFFNNF, [DLBAGNNJKKK(null)] OILOBEMANON HALOMOONKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6505DC0", Offset = "0x65049C0", VA = "0x186505DC0", Slot = "17")]
	public override IHPHLOENKON HMHCFFFNHBD(NFOEPLCKIPF BFDLBONPDOA, IEnumerator<MJMKCFLBGFK> ALLMDMOCJHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6505900", Offset = "0x6504500", VA = "0x186505900", Slot = "18")]
	public override void GPJBDIFOFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6505600", Offset = "0x6504200", VA = "0x186505600", Slot = "20")]
	public override void DLDIOBGOGBC(JDDMPIEJENJ OMGIHEDMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6505F70", Offset = "0x6504B70", VA = "0x186505F70", Slot = "19")]
	protected override void OFENLADEDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x65055D0", Offset = "0x65041D0", VA = "0x1865055D0")]
	private FDALFCGDCLB CGAHFJCNEEI(JDDMPIEJENJ OMKEAAPIABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6505B90", Offset = "0x6504790", VA = "0x186505B90", Slot = "21")]
	internal override ABFHHILCHPH HAGMHBAMPBF(IEnumerator<MJMKCFLBGFK> ALLMDMOCJHL, Behaviour BFDLBONPDOA, CMIJLBKPGBH IFLPCIJGAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6505EF0", Offset = "0x6504AF0", VA = "0x186505EF0", Slot = "22")]
	internal override OKKIFMIGJFL IKPDFPJHDFF(JDDMPIEJENJ OAOBAEBKDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x65054B0", Offset = "0x65040B0", VA = "0x1865054B0")]
	private void AFPDPHLDIAJ(FDALFCGDCLB NKAEJCPLFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6505830", Offset = "0x6504430", VA = "0x186505830", Slot = "23")]
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
	[Cpp2IlInjected.Address(RVA = "0x6507850", Offset = "0x6506450", VA = "0x186507850")]
	public static KHABNLENALM PAKONFKLIMF(int JLDMJPJFPJD, float MKJMBIGEENJ, NativeArray<CAEIJHAPBLE> EABAAHCMLEM, NativeArray<float> KLBABIGOOIP, NativeArray<int> KCFHAOGOAON, NativeArray<int> AMGDKNECDDJ, NativeArray<int> IJGOKEDBELN, NativeArray<int> JAFOJOJGCDE, NativeArray<int> MNGKHAAIDAK)
	{
		return default(KHABNLENALM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x65074C0", Offset = "0x65060C0", VA = "0x1865074C0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6507810", Offset = "0x6506410", VA = "0x186507810")]
	private bool OILLDAMMIBK(int DCGGFHOCGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x65075A0", Offset = "0x65061A0", VA = "0x1865075A0")]
	private void JLNNJPGNCHH(NativeArray<int> IOACHNEABNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6507420", Offset = "0x6506020", VA = "0x186507420")]
	private int COJCLEANEBB(int ONOGOEEKLCA, int ECDMKNFJMJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6507350", Offset = "0x6505F50", VA = "0x186507350")]
	private void BNKIAHEHHLN(NativeArray<int> IOACHNEABNH, int FDOEMDDHIJF, int OIPEAFPNBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x65075D0", Offset = "0x65061D0", VA = "0x1865075D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6508730", Offset = "0x6507330", VA = "0x186508730")]
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
	[Cpp2IlInjected.Address(RVA = "0x6507CF0", Offset = "0x65068F0", VA = "0x186507CF0")]
	public static IHPHLOENKON DCDGLFDOKJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6508BA0", Offset = "0x65077A0", VA = "0x186508BA0")]
	[Preserve]
	protected LIDLDCAHDEC([DLBAGNNJKKK(null)] EFJOKGEPKPF FPCFIIFFNNF, [DLBAGNNJKKK(null)] OILOBEMANON HALOMOONKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x65087A0", Offset = "0x65073A0", VA = "0x1865087A0", Slot = "6")]
	public IHPHLOENKON PELAEOHIFHJ(IEnumerator<MJMKCFLBGFK> ALLMDMOCJHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x65087B0", Offset = "0x65073B0", VA = "0x1865087B0", Slot = "7")]
	public IHPHLOENKON PELAEOHIFHJ(Behaviour BFDLBONPDOA, IEnumerator<MJMKCFLBGFK> ALLMDMOCJHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract IHPHLOENKON HMHCFFFNHBD(NFOEPLCKIPF BFDLBONPDOA, IEnumerator<MJMKCFLBGFK> ALLMDMOCJHL);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6508250", Offset = "0x6506E50", VA = "0x186508250", Slot = "18")]
	public virtual void GPJBDIFOFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6508490", Offset = "0x6507090", VA = "0x186508490", Slot = "9")]
	public void OEAOOJLOLAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x65086D0", Offset = "0x65072D0", VA = "0x1865086D0", Slot = "19")]
	protected virtual void OFENLADEDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x65086F0", Offset = "0x65072F0", VA = "0x1865086F0")]
	private void OFPHAKNNMLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6508410", Offset = "0x6507010", VA = "0x186508410")]
	private void INLDOIELEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6508780", Offset = "0x6507380", VA = "0x186508780")]
	private void PDJCDDIBAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x65083F0", Offset = "0x6506FF0", VA = "0x1865083F0")]
	private void IFJOALODFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6508230", Offset = "0x6506E30", VA = "0x186508230")]
	private void GHKMIALKFOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6508710", Offset = "0x6507310", VA = "0x186508710")]
	private void ONPCEADGMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6508B80", Offset = "0x6507780", VA = "0x186508B80")]
	private void PPPCHPHFHLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6507D80", Offset = "0x6506980", VA = "0x186507D80", Slot = "20")]
	public virtual void DLDIOBGOGBC(JDDMPIEJENJ OMGIHEDMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x65089B0", Offset = "0x65075B0", VA = "0x1865089B0")]
	private void PMNEFPONKIP(OKKIFMIGJFL NKAEJCPLFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1BF5F20", Offset = "0x1BF4B20", VA = "0x181BF5F20")]
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
	[Cpp2IlInjected.Address(RVA = "0x6507E10", Offset = "0x6506A10", VA = "0x186507E10", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x65081D0", Offset = "0x6506DD0", VA = "0x1865081D0", Slot = "13")]
	public MJMKCFLBGFK FMPMCIHHCDN(JDDMPIEJENJ OAOBAEBKDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6507C60", Offset = "0x6506860", VA = "0x186507C60", Slot = "14")]
	public MJMKCFLBGFK CINHPPJMCGN(float FOGEGHJNDKP, JDDMPIEJENJ OAOBAEBKDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6508430", Offset = "0x6507030", VA = "0x186508430", Slot = "15")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F5190", Offset = "0x64F3D90", VA = "0x1864F5190")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F4FE0", Offset = "0x64F3BE0", VA = "0x1864F4FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x54A95C0", Offset = "0x54A81C0", VA = "0x1854A95C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x64F5650", Offset = "0x64F4250", VA = "0x1864F5650")]
	public ABFHHILCHPH(IEnumerator<MJMKCFLBGFK> OPIBKMPHBKJ, PEKILLHDHED BFDLBONPDOA, CMIJLBKPGBH IFLPCIJGAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x64F5260", Offset = "0x64F3E60", VA = "0x1864F5260")]
	public MJMKCFLBGFK LPAHLLPIDIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x64F4F70", Offset = "0x64F3B70", VA = "0x1864F4F70")]
	public bool FENFOOAMPOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x64F5210", Offset = "0x64F3E10", VA = "0x1864F5210")]
	public void IIEKIHINOBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x64F5570", Offset = "0x64F4170", VA = "0x1864F5570", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x64F8B90", Offset = "0x64F7790", VA = "0x1864F8B90", Slot = "24")]
	private bool IODFJAPHOEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x64F8B80", Offset = "0x64F7780", VA = "0x1864F8B80", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x64F8BB0", Offset = "0x64F77B0", VA = "0x1864F8BB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x650F000", Offset = "0x650DC00", VA = "0x18650F000")]
	public OKKIFMIGJFL(JDDMPIEJENJ OAOBAEBKDCM, EHCPBNNOJLG CADPJLAMILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x650E7A0", Offset = "0x650D3A0", VA = "0x18650E7A0")]
	public void HBKJKKGNHDJ(ABFHHILCHPH OPIBKMPHBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x650DD90", Offset = "0x650C990", VA = "0x18650DD90")]
	public void EDLLEANPIJG(IList<ABFHHILCHPH> GJNBLJFBPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x650E0A0", Offset = "0x650CCA0", VA = "0x18650E0A0")]
	public void ELNMJEMLFJL(IList<ABFHHILCHPH> GJNBLJFBPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x650E6B0", Offset = "0x650D2B0", VA = "0x18650E6B0")]
	private void GBMNNKJCFAJ(ABFHHILCHPH OPIBKMPHBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x650DAE0", Offset = "0x650C6E0", VA = "0x18650DAE0")]
	private void DPLCHAJOEJB(IList<ABFHHILCHPH> GJNBLJFBPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x650E9E0", Offset = "0x650D5E0", VA = "0x18650E9E0")]
	private DMPIALGBEOE JIKPNPBHKCC(ABFHHILCHPH OPIBKMPHBKJ)
	{
		return default(DMPIALGBEOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x650ED50", Offset = "0x650D950", VA = "0x18650ED50")]
	public void OFENLADEDFE(float MKJMBIGEENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x650EB60", Offset = "0x650D760", VA = "0x18650EB60")]
	public void OEAOOJLOLAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x650E3B0", Offset = "0x650CFB0", VA = "0x18650E3B0")]
	private void FAHCBOAEEKC(List<ABFHHILCHPH> GJNBLJFBPMD, Stack<int> BLNJNDPNKPK, bool BEKEBIOPHBK, float JIDJCPKDHLI = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x650DC70", Offset = "0x650C870", VA = "0x18650DC70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x650E8A0", Offset = "0x650D4A0", VA = "0x18650E8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F7BC0", Offset = "0x64F67C0", VA = "0x1864F7BC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool IBAGIICNAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x64F7C40", Offset = "0x64F6840", VA = "0x1864F7C40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool IGCJDBMBFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x64F7C90", Offset = "0x64F6890", VA = "0x1864F7C90", Slot = "6")]
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

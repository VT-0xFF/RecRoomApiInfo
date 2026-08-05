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
public class MANEHNJBDFA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority KICALJOPMGO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5067120", Offset = "0x5066120", VA = "0x185067120")]
	public MANEHNJBDFA(ThreadPriority GBNFKBMDGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5067110", Offset = "0x5066110", VA = "0x185067110", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> JJNAMGGIEAF(List<PlayerLoopSystem> PNLCMCKFGMK, int IBAODNHBKOJ);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct DGJAADOLHAO
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct ECMEGCJHOKI
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static NHBIDAMCDOH APJDDFHDBFG;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x505A680", Offset = "0x5059680", VA = "0x18505A680")]
				public static PlayerLoopSystem BONBNKMFMIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct BLEMMCAOJJF
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static NHBIDAMCDOH IOEBCMMABOK;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x50526E0", Offset = "0x50516E0", VA = "0x1850526E0")]
				public static PlayerLoopSystem BONBNKMFMIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct FKOOCNODLED
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static NHBIDAMCDOH KONPHCJJGIC;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x505BE00", Offset = "0x505AE00", VA = "0x18505BE00")]
				public static PlayerLoopSystem BONBNKMFMIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct CAGBENDKGDJ
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static NHBIDAMCDOH MLBBMJJCLBP;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static NHBIDAMCDOH GMPANMEPGJD;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static NHBIDAMCDOH GLAECMECLJC;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static NHBIDAMCDOH GFDFLAEFKKM;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x5052CC0", Offset = "0x5051CC0", VA = "0x185052CC0")]
				public static PlayerLoopSystem BONBNKMFMIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct MBIKAOONKFE
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static NHBIDAMCDOH AJBJMAEPBME;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x5067160", Offset = "0x5066160", VA = "0x185067160")]
				public static PlayerLoopSystem BONBNKMFMIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct KPBHCCPGGAM
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static NHBIDAMCDOH MLBBMJJCLBP;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static NHBIDAMCDOH GMPANMEPGJD;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static NHBIDAMCDOH GLAECMECLJC;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static NHBIDAMCDOH GFDFLAEFKKM;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x5064970", Offset = "0x5063970", VA = "0x185064970")]
				public static PlayerLoopSystem BONBNKMFMIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct EMILCCLLPOM
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static NHBIDAMCDOH HCCMGOJLJGE;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x505B220", Offset = "0x505A220", VA = "0x18505B220")]
				public static PlayerLoopSystem BONBNKMFMIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct IAACPMMJMIE
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static NHBIDAMCDOH IKFBECAICKH;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5063800", Offset = "0x5062800", VA = "0x185063800")]
				public static PlayerLoopSystem BONBNKMFMIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct HDPJEBHMBLF
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static NHBIDAMCDOH CGGDFIEMPHL;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x50616B0", Offset = "0x50606B0", VA = "0x1850616B0")]
				public static PlayerLoopSystem BONBNKMFMIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct GMGMBAPMKIF
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static NHBIDAMCDOH KHOAAFLPHFG;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x5060910", Offset = "0x505F910", VA = "0x185060910")]
				public static PlayerLoopSystem BONBNKMFMIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct PJPKCBKCHBP
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static NHBIDAMCDOH KMLCBKDCKPF;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x5068F90", Offset = "0x5067F90", VA = "0x185068F90")]
				public static PlayerLoopSystem BONBNKMFMIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct DKLALDIMPGJ
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static NHBIDAMCDOH KBJNMPIBLJH;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5059210", Offset = "0x5058210", VA = "0x185059210")]
				public static PlayerLoopSystem BONBNKMFMIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum HDBJNBDHLEJ : byte
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
			public struct HGMJAPPHCFN
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class DMEHNKHNGKA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public HDBJNBDHLEJ updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
					public DMEHNKHNGKA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x5059960", Offset = "0x5058960", VA = "0x185059960")]
					internal void MPJJJENHMKB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static EAFMEKAHDGH<HDBJNBDHLEJ> PIDCCMIDHNO;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x50618C0", Offset = "0x50608C0", VA = "0x1850618C0")]
				public static PlayerLoopSystem BONBNKMFMIG(HDBJNBDHLEJ OIDLBHNAPCH)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct HMNIDOHIKGF
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class FNALKFOHMAE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public GFJKLIOEOHF.GNEBGEAAOML key;

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
					public FNALKFOHMAE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x505C0F0", Offset = "0x505B0F0", VA = "0x18505C0F0")]
					internal void LPDMPJFIHAJ()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable BMMOBCKLAJC;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x5061BB0", Offset = "0x5060BB0", VA = "0x185061BB0")]
				public static PlayerLoopSystem HPLOIPACJIC(GFJKLIOEOHF.GNEBGEAAOML LOHIKDGDMPP)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct OKGFFOGONII
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class BHALHACHEMD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public GFJKLIOEOHF.GNEBGEAAOML key;

					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
					public BHALHACHEMD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x5050500", Offset = "0x504F500", VA = "0x185050500")]
					internal void LPDMPJFIHAJ()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x50689C0", Offset = "0x50679C0", VA = "0x1850689C0")]
				public static PlayerLoopSystem HPLOIPACJIC(GFJKLIOEOHF.GNEBGEAAOML LOHIKDGDMPP)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class IFANGLJKIKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public IFANGLJKIKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x50641F0", Offset = "0x50631F0", VA = "0x1850641F0")]
			internal List<PlayerLoopSystem> NPEOIAGFEIA(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool GKJJMDHHNKC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool NLMHCLFBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5054B40", Offset = "0x5053B40", VA = "0x185054B40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5054B00", Offset = "0x5053B00", VA = "0x185054B00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5055CD0", Offset = "0x5054CD0", VA = "0x185055CD0")]
		private static void NFAJOGNNCIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5055400", Offset = "0x5054400", VA = "0x185055400")]
		private static void NEIHEBKIFHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5054B80", Offset = "0x5053B80", VA = "0x185054B80")]
		private static void FHEOIAGKPAO(string DHBPEJEFAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x50548D0", Offset = "0x50538D0", VA = "0x1850548D0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5058620", Offset = "0x5057620", VA = "0x185058620")]
		private static void OJLIMEAALPF(GFJKLIOEOHF.GNEBGEAAOML LOHIKDGDMPP, ref PlayerLoopSystem DLOEPDAPLDL, Type FPGBMLHIKBJ, Type AFDAFMPLJHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5054EB0", Offset = "0x5053EB0", VA = "0x185054EB0")]
		private static void HCKFECJIGDN(ref PlayerLoopSystem DLOEPDAPLDL, Type FPGBMLHIKBJ, Type AFDAFMPLJHE, JJNAMGGIEAF GOOBMOHPAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x50552D0", Offset = "0x50542D0", VA = "0x1850552D0")]
		private static void KKNIDMIFIJA(ref PlayerLoopSystem DLOEPDAPLDL, Type FPGBMLHIKBJ, Type AFDAFMPLJHE, PlayerLoopSystem? IMBMICKCOHO, PlayerLoopSystem? OEFJAGMDGMI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class GFJKLIOEOHF
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum GNEBGEAAOML
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
	public class BMNNCDHFBKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly GNEBGEAAOML KEFCNOABMEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly EBHMNCPHKFO MBBBFPLGMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long ONBGLOMMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long NCGFIEKDIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long LNJLOIIODMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int KPDBHMKPAFP;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5052BC0", Offset = "0x5051BC0", VA = "0x185052BC0")]
		public BMNNCDHFBKF(GNEBGEAAOML GPPJLBMHMKH, int CJGKBJBLGDI = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5052B50", Offset = "0x5051B50", VA = "0x185052B50")]
		public void HJLMECCIOBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x50528F0", Offset = "0x50518F0", VA = "0x1850528F0")]
		public void DOIDHLIIIGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5052950", Offset = "0x5051950", VA = "0x185052950")]
		public void EHFOFGMMMOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static GNEBGEAAOML[] PIBJEEDBIBJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static BMNNCDHFBKF[] FBAHOLLFBBB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x505CF00", Offset = "0x505BF00", VA = "0x18505CF00")]
	public static BMNNCDHFBKF KHJFMKFKPEN(GNEBGEAAOML LOHIKDGDMPP, int CJGKBJBLGDI = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x505CE70", Offset = "0x505BE70", VA = "0x18505CE70")]
	public static BMNNCDHFBKF JMGNMFLMHBB(GNEBGEAAOML LOHIKDGDMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x505CDC0", Offset = "0x505BDC0", VA = "0x18505CDC0")]
	public static void AAGALKOENPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class EMKKOBPFEGD
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private interface LADJGNNMEFK
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool GBNLBOFJAPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DGCOAPBJKNO();
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private abstract class LHGFDJILGGE<TPromise, TMainThreadPromise> : LADJGNNMEFK where TPromise : GAEMIFNLIHB where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly TPromise DNOODNNIFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected readonly TMainThreadPromise LHDMIMDIGME;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TPromise EGJOHBLOMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2692480", Offset = "0x2691480", VA = "0x182692480")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool GBNLBOFJAPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2692430", Offset = "0x2691430", VA = "0x182692430", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2051A00", Offset = "0x2050A00", VA = "0x182051A00")]
		protected LHGFDJILGGE(TPromise DNOODNNIFLG, TMainThreadPromise HNCHAFNNBNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2692400", Offset = "0x2691400", VA = "0x182692400", Slot = "5")]
		public void DGCOAPBJKNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void BEBDPBAAHDO(TPromise DNOODNNIFLG);
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class HHBFHLCJNAP<T> : LHGFDJILGGE<IBHBGBJGJHP<T>, FPHCELGDGAI<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28420C0", Offset = "0x28410C0", VA = "0x1828420C0")]
		public HHBFHLCJNAP(IBHBGBJGJHP<T> DNOODNNIFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2841F30", Offset = "0x2840F30", VA = "0x182841F30", Slot = "6")]
		protected override void BEBDPBAAHDO(IBHBGBJGJHP<T> DNOODNNIFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2842090", Offset = "0x2841090", VA = "0x182842090")]
		[CompilerGenerated]
		private void CPBPMCCLGDC(T ALIHEMGMHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xC458D0", Offset = "0xC448D0", VA = "0x180C458D0")]
		[CompilerGenerated]
		private void LHBKMHPEJCB(string AOLOOCNDGPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class AECJKMCCGEO : LADJGNNMEFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Action OKCPFPFJOFL;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GBNLBOFJAPF
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x85F430", Offset = "0x85E430", VA = "0x18085F430", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x919D70", Offset = "0x918D70", VA = "0x180919D70")]
		public AECJKMCCGEO(Action OKCPFPFJOFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x96AE50", Offset = "0x969E50", VA = "0x18096AE50", Slot = "5")]
		public void DGCOAPBJKNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<LADJGNNMEFK> NKMINHEJGNG;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE7C0", Offset = "0x1FFD7C0", VA = "0x181FFE7C0")]
	public static IBHBGBJGJHP<T> HBIEJJLGJGN<T>(this IBHBGBJGJHP<T> DNOODNNIFLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x505B800", Offset = "0x505A800", VA = "0x18505B800")]
	public static void HBIEJJLGJGN(Action OKCPFPFJOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE700", Offset = "0x1FFD700", VA = "0x181FFE700")]
	private static IBHBGBJGJHP<T> BELCECNMKKB<T>(IBHBGBJGJHP<T> DNOODNNIFLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x505B430", Offset = "0x505A430", VA = "0x18505B430")]
	private static void CCEIFKANECG(LADJGNNMEFK PHCLFLGLOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x505B890", Offset = "0x505A890", VA = "0x18505B890")]
	private static void MOHFNPGJILC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x505B630", Offset = "0x505A630", VA = "0x18505B630")]
	private static void ELDLJCEKAMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x505B730", Offset = "0x505A730", VA = "0x18505B730")]
	private static void FKAEEKGIKFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class HPLJABDIDPD
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private struct LOPDAOGHDLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TaskCompletionSource<Scene> BGGOOPDOFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly string GHHMMCBLDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly LoadSceneMode ODDNBMCFFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly bool DJNKLPFFCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5066B70", Offset = "0x5065B70", VA = "0x185066B70")]
		public LOPDAOGHDLB(TaskCompletionSource<Scene> GCHDOHEOJIB, string GHHMMCBLDBH, LoadSceneMode ODDNBMCFFLB, bool DJNKLPFFCKF, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class NIHLGOCMAJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private MNKIABAIHBN<string> <toDispose>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private LILHCJDBOKI <stackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private LOPDAOGHDLB <queuedSceneLoad>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NIHLGOCMAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5067EB0", Offset = "0x5066EB0", VA = "0x185067EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class BKBLCEKMOGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BKBLCEKMOGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5050890", Offset = "0x504F890", VA = "0x185050890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class DMFPMHBHMIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private LOPDAOGHDLB <dequeued>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Scene <scene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Scene <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private Exception <ex>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public DMFPMHBHMIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x50599F0", Offset = "0x50589F0", VA = "0x1850599F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class LBBMIOMDPAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public FPHCELGDGAI<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LBBMIOMDPAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5064C30", Offset = "0x5063C30", VA = "0x185064C30")]
		internal void LHJOCKNHJAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class DJNDADLLLCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <loadSceneTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private LBBMIOMDPAK <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool <shouldLoadEmptyScene>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Scene <emptyScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Scene <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public DJNDADLLLCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5058820", Offset = "0x5057820", VA = "0x185058820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class ACMKMEFOKIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private SceneInstance <instance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ACMKMEFOKIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x504E360", Offset = "0x504D360", VA = "0x18504E360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class MCJGOJCBCML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Scene <emptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <emptySceneRoutineTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <emptySceneTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MCJGOJCBCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5067370", Offset = "0x5066370", VA = "0x185067370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class ABECENIJHGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ABECENIJHGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x504E330", Offset = "0x504D330", VA = "0x18504E330")]
		internal bool DOJBKDBGIAK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class AHLJIMIADLI : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private OJAHJFHMFIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public NHFPGJIFDOB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IDisposable <sample>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private ABECENIJHGN <>8__3;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
		[DebuggerHidden]
		public AHLJIMIADLI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x504F2B0", Offset = "0x504E2B0", VA = "0x18504F2B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x504EEF0", Offset = "0x504DEF0", VA = "0x18504EEF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x504EEA0", Offset = "0x504DEA0", VA = "0x18504EEA0")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x504F270", Offset = "0x504E270", VA = "0x18504F270", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class CKKKJPFDBHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public FPHCELGDGAI<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CKKKJPFDBHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x50531F0", Offset = "0x50521F0", VA = "0x1850531F0")]
		internal bool OCIKJPAAENN(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5052F80", Offset = "0x5051F80", VA = "0x185052F80")]
		internal void NAIFBAEKOPD(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class ELJCAFENNNJ : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private OJAHJFHMFIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public FPHCELGDGAI<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private CKKKJPFDBHB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
		[DebuggerHidden]
		public ELJCAFENNNJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x505A9B0", Offset = "0x50599B0", VA = "0x18505A9B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x505B1E0", Offset = "0x505A1E0", VA = "0x18505B1E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly ICollection<string> IEBJGCFGDAA;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static GAEMIFNLIHB CKMPMAHMAGO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AsyncOperation OAOGMBNCPNF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static GAEMIFNLIHB GPBIAPHJHOA;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static string IHOBCIHCIEH;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static ThreadPriority LGAJGAJIBOF;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static Task HBLEGDGCBFH;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static List<SceneInstance> CBGBNGEOBOI;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Queue<LOPDAOGHDLB> FBGMGBMMMEP;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Task PJJPLDJJMFD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool EOPPOHCIPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5062A80", Offset = "0x5061A80", VA = "0x185062A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private static bool FEDGNOMAOPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5062F60", Offset = "0x5061F60", VA = "0x185062F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private static bool HHPOMMENCKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5061D10", Offset = "0x5060D10", VA = "0x185061D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static bool LPCLEFHGIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5063190", Offset = "0x5062190", VA = "0x185063190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> JBEGHNKBEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5062110", Offset = "0x5061110", VA = "0x185062110")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5061F20", Offset = "0x5060F20", VA = "0x185061F20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5063020", Offset = "0x5062020", VA = "0x185063020")]
	[JOOLBCFGFFN(LLJHODDJBDJ.EnteredEditModeNextFrame, 0)]
	private static void NJEHNLLCPIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5062210", Offset = "0x5061210", VA = "0x185062210")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NIHLGOCMAJC))]
	public static Task<Scene> EJFFLJOEMLI(string GHHMMCBLDBH, LoadSceneMode ODDNBMCFFLB = LoadSceneMode.Single, bool DJNKLPFFCKF = false, [Optional] MNKIABAIHBN<string>.JJAEKMMDGKH NJFJKDJLDAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x50627F0", Offset = "0x50617F0", VA = "0x1850627F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BKBLCEKMOGP))]
	private static Task HEEOGEAEIMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5062E60", Offset = "0x5061E60", VA = "0x185062E60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DMFPMHBHMIC))]
	private static Task MANFCLMMCNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x50625B0", Offset = "0x50615B0", VA = "0x1850625B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DJNDADLLLCB))]
	private static Task<Scene> FMAMEKDDPBA(string GHHMMCBLDBH, LoadSceneMode ODDNBMCFFLB, bool DJNKLPFFCKF, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5062020", Offset = "0x5061020", VA = "0x185062020")]
	private static void BDGGDGADEBF(SceneInstance NHLNFFHEKJH, LoadSceneMode ODDNBMCFFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x50629E0", Offset = "0x50619E0", VA = "0x1850629E0")]
	private static void ICKLPLEGNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5062D00", Offset = "0x5061D00", VA = "0x185062D00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ACMKMEFOKIO))]
	private static Task<Scene> LMJKEFEDJEC(string GHHMMCBLDBH, LoadSceneMode ODDNBMCFFLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x50628F0", Offset = "0x50618F0", VA = "0x1850628F0")]
	private static bool HGBCAMEDIAA(string GHHMMCBLDBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5061DD0", Offset = "0x5060DD0", VA = "0x185061DD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MCJGOJCBCML))]
	private static Task<Scene> BAMPPKHBGOC(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x50623C0", Offset = "0x50613C0", VA = "0x1850623C0")]
	public static IBHBGBJGJHP<Scene> ENJOEIGFGPI(string GHHMMCBLDBH, LoadSceneMode ODDNBMCFFLB = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x50633B0", Offset = "0x50623B0", VA = "0x1850633B0")]
	public static GAEMIFNLIHB PHPONAIJECN(string GHHMMCBLDBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5062760", Offset = "0x5061760", VA = "0x185062760")]
	[IteratorStateMachine(typeof(AHLJIMIADLI))]
	private static IEnumerator<OJAHJFHMFIA> HANPBFDCPAD(string GHHMMCBLDBH, NHFPGJIFDOB BCFLEHCKHGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x50630F0", Offset = "0x50620F0", VA = "0x1850630F0")]
	[IteratorStateMachine(typeof(ELJCAFENNNJ))]
	private static IEnumerator<OJAHJFHMFIA> OAJMDDJCCEE(string GHHMMCBLDBH, LoadSceneMode ODDNBMCFFLB, FPHCELGDGAI<Scene> BCFLEHCKHGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5063240", Offset = "0x5062240", VA = "0x185063240")]
	public static bool PFIAHCPHAKC(out string DPDNKJKHDCB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class EBHMNCPHKFO : LOCJLBBLPKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int GEIJDHAOBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Queue<double> IMBNDNOHMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private double LMBLJACJEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private double KHIOAKAGFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private double BHHHEHPBGKN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public double GEFPJJHDPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x505A3C0", Offset = "0x50593C0", VA = "0x18505A3C0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double FNJAJIDCOME
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1D4AF30", Offset = "0x1D49F30", VA = "0x181D4AF30", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double NNFMDIFOFLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3D9F350", Offset = "0x3D9E350", VA = "0x183D9F350", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x505A5D0", Offset = "0x50595D0", VA = "0x18505A5D0")]
	public EBHMNCPHKFO(int KFLGHFLEIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x505A430", Offset = "0x5059430", VA = "0x18505A430", Slot = "7")]
	public void KPPLIFLCIJG(double HLLJGNGJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x505A560", Offset = "0x5059560", VA = "0x18505A560", Slot = "8")]
	public void NJJHHEGPENJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class FJCMGONCBNL : LOCJLBBLPKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private long LEOAEOJMCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private double KMOCBCAJCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private double ELDHKHECNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private double GNNJBFDGNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private double EDKFMKGMEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private double LMBLJACJEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private double KHIOAKAGFFK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x90AAB0", Offset = "0x909AB0", VA = "0x18090AAB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double FNJAJIDCOME
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x505BC10", Offset = "0x505AC10", VA = "0x18505BC10", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public double NNFMDIFOFLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x505BD60", Offset = "0x505AD60", VA = "0x18505BD60", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public double ECCLJMEOHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x505BD70", Offset = "0x505AD70", VA = "0x18505BD70")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public double GEFPJJHDPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x505BC20", Offset = "0x505AC20", VA = "0x18505BC20", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x505BC30", Offset = "0x505AC30", VA = "0x18505BC30", Slot = "7")]
	public virtual void KPPLIFLCIJG(double HLLJGNGJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x505BD80", Offset = "0x505AD80", VA = "0x18505BD80", Slot = "8")]
	public virtual void NJJHHEGPENJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x505BDC0", Offset = "0x505ADC0", VA = "0x18505BDC0")]
	public FJCMGONCBNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class LMEJKHEMMPG : FJCMGONCBNL
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public double IDFKFDPKCIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4208DF0", Offset = "0x4207DF0", VA = "0x184208DF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4208E10", Offset = "0x4207E10", VA = "0x184208E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x50669F0", Offset = "0x50659F0", VA = "0x1850669F0", Slot = "7")]
	public override void KPPLIFLCIJG(double HLLJGNGJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5066B30", Offset = "0x5065B30", VA = "0x185066B30", Slot = "8")]
	public override void NJJHHEGPENJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x505BDC0", Offset = "0x505ADC0", VA = "0x18505BDC0")]
	public LMEJKHEMMPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface LOCJLBBLPKF
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	double GEFPJJHDPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	double FNJAJIDCOME
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	double NNFMDIFOFLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class MGHJLDGIEDM : LCGHPFLLBAN
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public float NOBBGHKOPDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5067E30", Offset = "0x5066E30", VA = "0x185067E30", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public float GBEDNHIKMAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5067E20", Offset = "0x5066E20", VA = "0x185067E20", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public double NMFGLGEELPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5067E00", Offset = "0x5066E00", VA = "0x185067E00", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5067E40", Offset = "0x5066E40", VA = "0x185067E40")]
	[FBCFLFBFGIL(LAFFCBAHJKM.None)]
	private static void HEBPGFNGBNI(CNALHHIKJDD DBGHBAHCJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	[Preserve]
	internal MGHJLDGIEDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class BKBOCABNFEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class MEILGHFGEDN : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private OJAHJFHMFIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public BKBOCABNFEB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
		[DebuggerHidden]
		public MEILGHFGEDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5067D20", Offset = "0x5066D20", VA = "0x185067D20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5067DC0", Offset = "0x5066DC0", VA = "0x185067DC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private HKMCLDHFALI OFAIICMMHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private MonoBehaviour KNPEDAOHAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Action IEEMKMNHPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Action<float> FPHBDJMPDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float MIIIHGIGKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool OCINHGHPEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly EDKLOBCPLML MNMAOHAMKAN;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5051800", Offset = "0x5050800", VA = "0x185051800")]
	public BKBOCABNFEB(MonoBehaviour KNPEDAOHAGF, Action IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI, [Optional] EDKLOBCPLML MNMAOHAMKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5051C50", Offset = "0x5050C50", VA = "0x185051C50")]
	public BKBOCABNFEB(MonoBehaviour KNPEDAOHAGF, Action<float> IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI, [Optional] EDKLOBCPLML MNMAOHAMKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5051A00", Offset = "0x5050A00", VA = "0x185051A00")]
	public BKBOCABNFEB(MonoBehaviour KNPEDAOHAGF, float KILAFDPOMCI, Action<float> IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI, bool OCINHGHPEFF = true, [Optional] EDKLOBCPLML MNMAOHAMKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x39FDB70", Offset = "0x39FCB70", VA = "0x1839FDB70")]
	private BKBOCABNFEB(EDKLOBCPLML MNMAOHAMKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5051380", Offset = "0x5050380", VA = "0x185051380")]
	internal static BKBOCABNFEB MCJNHNOFEND(MonoBehaviour KNPEDAOHAGF, float KILAFDPOMCI, Action<float> IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI, bool OCINHGHPEFF = true, [Optional] EDKLOBCPLML MNMAOHAMKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5050DA0", Offset = "0x504FDA0", VA = "0x185050DA0")]
	private void CMFLNHKPOEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x50515C0", Offset = "0x50505C0", VA = "0x1850515C0")]
	private void NOFELOOMCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5051140", Offset = "0x5050140", VA = "0x185051140")]
	private void KIKGAMNGMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5050BD0", Offset = "0x504FBD0", VA = "0x185050BD0")]
	private void BGNAHACIKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5051000", Offset = "0x5050000", VA = "0x185051000")]
	private void ILPMCNJFPCI(string AOLOOCNDGPL, Action DEBDOBLOION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x50512F0", Offset = "0x50502F0", VA = "0x1850512F0")]
	[IteratorStateMachine(typeof(MEILGHFGEDN))]
	private IEnumerator<OJAHJFHMFIA> LNCGNCJBIPI(Action DEBDOBLOION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5050F10", Offset = "0x504FF10", VA = "0x185050F10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5051770", Offset = "0x5050770", VA = "0x185051770")]
	[CompilerGenerated]
	private void POOPAIPCKBL(string PJPDEBBCODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5050F70", Offset = "0x504FF70", VA = "0x185050F70")]
	[CompilerGenerated]
	private void EEAJKFIKMCE(string PJPDEBBCODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x50514A0", Offset = "0x50504A0", VA = "0x1850514A0")]
	[CompilerGenerated]
	private void MGABFKBLIFC(string PJPDEBBCODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5051530", Offset = "0x5050530", VA = "0x185051530")]
	[CompilerGenerated]
	private void NEFNMOCJPBI(string PJPDEBBCODN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct LPNGLGAEBGC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[ReadOnly]
	public float LOOCGAFGPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ReadOnly]
	public int EPBLOBICFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private NativeArray<int> BMACDGLLMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NativeArray<int> NAOBELCIBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NativeArray<int> MNANLKHJCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ReadOnly]
	public NativeArray<OFDPOADFAJM> PAGOJBFKIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ReadOnly]
	public NativeArray<float> CDOPBJHJELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[WriteOnly]
	public NativeArray<int> CJIEEBBPBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[WriteOnly]
	public NativeArray<int> IJHMIHIFPMN;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5067020", Offset = "0x5066020", VA = "0x185067020")]
	public static LPNGLGAEBGC HFOCJEBDOBL(int DGBGEFLHINP, float NCNKEPCFEFB, NativeArray<OFDPOADFAJM> HCBMKBMHPIC, NativeArray<float> OFLLLILKEIG, NativeArray<int> MNLHJLDJEBD, NativeArray<int> OEKPPEPJLHE, NativeArray<int> GJBNIHCJEIA, NativeArray<int> NAOBELCIBEA, NativeArray<int> MNANLKHJCEI)
	{
		return default(LPNGLGAEBGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5066F40", Offset = "0x5065F40", VA = "0x185066F40", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x50670D0", Offset = "0x50660D0", VA = "0x1850670D0")]
	private bool NJABGMEIOON(int CCELBNKPBGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5066F10", Offset = "0x5065F10", VA = "0x185066F10")]
	private void EOKGAMMEFLH(NativeArray<int> JIOCKAOOGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5066EB0", Offset = "0x5065EB0", VA = "0x185066EB0")]
	private int EKALPLAEEBD(int EODEEDCNDLL, int POAFNLEGHMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5066DE0", Offset = "0x5065DE0", VA = "0x185066DE0")]
	private void BFCFLBLNEAI(NativeArray<int> JIOCKAOOGEK, int JHMGJHFONNB, int AOPJFEBAIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5066BD0", Offset = "0x5065BD0", VA = "0x185066BD0")]
	private void AGFMONBOGFE(NativeArray<int> JIOCKAOOGEK, int HPMHLJPFMKM, int FOKBGCGDPCM, int ADFKDLENEPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class PCJCMFOEHBF : AFIFABMNPKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly float AAOKPDICEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly int MPPJPKFMNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float ECMFDJAFJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly float[] OIIJPOKPFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private int HANDGHOPFJP;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5068DE0", Offset = "0x5067DE0", VA = "0x185068DE0")]
	public PCJCMFOEHBF(Behaviour AEOEKGNDHFM, float GCIMLGKJMGP, int MPPJPKFMNMK, [Optional] Action OPELIJALDAP, float ECMFDJAFJLL = 0f, [Optional] EDKLOBCPLML MNMAOHAMKAN, [Optional] LCGHPFLLBAN KAOIELLKBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x98E270", Offset = "0x98D270", VA = "0x18098E270", Slot = "9")]
	protected override bool JMFAHEBMMIP(Action OKCPFPFJOFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5068B20", Offset = "0x5067B20", VA = "0x185068B20", Slot = "10")]
	protected override bool GCJCOMFPDPH(Action OKCPFPFJOFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5068D50", Offset = "0x5067D50", VA = "0x185068D50")]
	private void MNOCMLONPCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public abstract class APMMOODNNOG : EDKLOBCPLML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly GDMGDOKLFNJ GINAJLPIJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	protected readonly LCGHPFLLBAN KAOIELLKBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly MMHOEKAKNPG CDOAANHCMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private LGIIEGBDAMM[] HACKKABOGGE;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static EDKLOBCPLML HIEJPGCOIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x504FA70", Offset = "0x504EA70", VA = "0x18504FA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool IHDFKNGPKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x85F430", Offset = "0x85E430", VA = "0x18085F430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public GNLBOPKOGJP.CIAOIIPEFHB BJPJGHIGKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(GNLBOPKOGJP.CIAOIIPEFHB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x91AF80", Offset = "0x919F80", VA = "0x18091AF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public LCGHPFLLBAN OCDDHAEFNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x504F380", Offset = "0x504E380", VA = "0x18504F380")]
	public static HKMCLDHFALI CPPBLHKFNJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5050150", Offset = "0x504F150", VA = "0x185050150")]
	[Preserve]
	protected APMMOODNNOG([JFLEHDEIONF(null)] GDMGDOKLFNJ GINAJLPIJLK, [JFLEHDEIONF(null)] LCGHPFLLBAN KAOIELLKBLL, [JFLEHDEIONF(null)] MMHOEKAKNPG CDOAANHCMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5050140", Offset = "0x504F140", VA = "0x185050140", Slot = "6")]
	public HKMCLDHFALI PLLHAMBOEGA(IEnumerator<OJAHJFHMFIA> ABFECGKDJEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x504FF10", Offset = "0x504EF10", VA = "0x18504FF10", Slot = "7")]
	public HKMCLDHFALI PLLHAMBOEGA(Behaviour AEOEKGNDHFM, IEnumerator<OJAHJFHMFIA> ABFECGKDJEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract HKMCLDHFALI BAKFLNBCLPO(GCMGPIABEJC AEOEKGNDHFM, IEnumerator<OJAHJFHMFIA> ABFECGKDJEN);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x504FB40", Offset = "0x504EB40", VA = "0x18504FB40", Slot = "13")]
	public virtual void NJJHHEGPENJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x504F790", Offset = "0x504E790", VA = "0x18504F790", Slot = "9")]
	public void GCHIBHJJAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1A613F0", Offset = "0x1A603F0", VA = "0x181A613F0", Slot = "14")]
	protected virtual void MCCBAFPODDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x504FAC0", Offset = "0x504EAC0", VA = "0x18504FAC0")]
	private void IOEBCMMABOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x504FB00", Offset = "0x504EB00", VA = "0x18504FB00")]
	private void KONPHCJJGIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x504FAE0", Offset = "0x504EAE0", VA = "0x18504FAE0")]
	private void KMECDBNKAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x504FD20", Offset = "0x504ED20", VA = "0x18504FD20")]
	private void OEDCAGJCGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x504F7F0", Offset = "0x504E7F0", VA = "0x18504F7F0")]
	private void HCCMGOJLJGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x504FA50", Offset = "0x504EA50", VA = "0x18504FA50")]
	private void IKFBECAICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x504FB20", Offset = "0x504EB20", VA = "0x18504FB20")]
	private void LGKKOEHNLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x504F810", Offset = "0x504E810", VA = "0x18504F810", Slot = "15")]
	public virtual void HOAHPJJHFFG(GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x504FD40", Offset = "0x504ED40", VA = "0x18504FD40")]
	private void PANHNKKNEOE(LGIIEGBDAMM JEDLGHILHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x504F340", Offset = "0x504E340", VA = "0x18504F340")]
	private LGIIEGBDAMM ANDAFAAGBDF(GNLBOPKOGJP.CIAOIIPEFHB DPPJBLOOGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract CMEEELBPIEJ KMICAIMFABB(IEnumerator<OJAHJFHMFIA> ABFECGKDJEN, Behaviour KNPEDAOHAGF, BKIFKIBMENE FJAIHAKLGGF);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract LGIIEGBDAMM HDEAIBLIPKH(GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x504F410", Offset = "0x504E410", VA = "0x18504F410", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class CMJBEHOFKGH : APMMOODNNOG, EDKLOBCPLML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private GJLIOEMNEIF[] EOLIFBGCDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private FMCJFCEJFMH GMCKBJLIAKG;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5053C20", Offset = "0x5052C20", VA = "0x185053C20")]
	[FBCFLFBFGIL(LAFFCBAHJKM.None)]
	private static void HEBPGFNGBNI(CNALHHIKJDD DBGHBAHCJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x50544F0", Offset = "0x50534F0", VA = "0x1850544F0")]
	[Preserve]
	public CMJBEHOFKGH([JFLEHDEIONF(null)] GDMGDOKLFNJ GINAJLPIJLK, [JFLEHDEIONF(null)] LCGHPFLLBAN KAOIELLKBLL, [JFLEHDEIONF(null)] MMHOEKAKNPG CDOAANHCMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x50539F0", Offset = "0x50529F0", VA = "0x1850539F0", Slot = "12")]
	public override HKMCLDHFALI BAKFLNBCLPO(GCMGPIABEJC AEOEKGNDHFM, IEnumerator<OJAHJFHMFIA> ABFECGKDJEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x50540F0", Offset = "0x50530F0", VA = "0x1850540F0", Slot = "13")]
	public override void NJJHHEGPENJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5053CD0", Offset = "0x5052CD0", VA = "0x185053CD0", Slot = "15")]
	public override void HOAHPJJHFFG(GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5054010", Offset = "0x5053010", VA = "0x185054010", Slot = "14")]
	protected override void MCCBAFPODDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5053C90", Offset = "0x5052C90", VA = "0x185053C90")]
	private GJLIOEMNEIF HJEMBPODFPD(GNLBOPKOGJP.CIAOIIPEFHB DPPJBLOOGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5053EA0", Offset = "0x5052EA0", VA = "0x185053EA0", Slot = "16")]
	internal override CMEEELBPIEJ KMICAIMFABB(IEnumerator<OJAHJFHMFIA> ABFECGKDJEN, Behaviour AEOEKGNDHFM, BKIFKIBMENE LNFEMDDJPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5053BB0", Offset = "0x5052BB0", VA = "0x185053BB0", Slot = "17")]
	internal override LGIIEGBDAMM HDEAIBLIPKH(GNLBOPKOGJP.CIAOIIPEFHB IHPFMGDPJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x50543D0", Offset = "0x50533D0", VA = "0x1850543D0")]
	private void OFGFEONDPFE(GJLIOEMNEIF JEDLGHILHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5053B40", Offset = "0x5052B40", VA = "0x185053B40", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class HAENFHANPKM
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class LJJLANKKNNN : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private OJAHJFHMFIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public GNLBOPKOGJP.CIAOIIPEFHB queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
		[DebuggerHidden]
		public LJJLANKKNNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5066900", Offset = "0x5065900", VA = "0x185066900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x50669B0", Offset = "0x50659B0", VA = "0x1850669B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5060B20", Offset = "0x505FB20", VA = "0x185060B20")]
	[IteratorStateMachine(typeof(LJJLANKKNNN))]
	private static IEnumerator<OJAHJFHMFIA> JFBGMJBCNOB(GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI, Func<bool> LIPFOCEGIHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5060BA0", Offset = "0x505FBA0", VA = "0x185060BA0")]
	public static HKMCLDHFALI KCPHJHFIEDN(this MonoBehaviour KNPEDAOHAGF, Func<bool> LIPFOCEGIHI, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI = GNLBOPKOGJP.CIAOIIPEFHB.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class CMEEELBPIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly BKIFKIBMENE LNFEMDDJPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly DONPIDFEOGC AEOEKGNDHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly bool GJLKJBDOANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private string OALFIBFPPAC;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public IEnumerator<OJAHJFHMFIA> AGCMPEKCPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9132F0", Offset = "0x9122F0", VA = "0x1809132F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public OJAHJFHMFIA IIMOLHCCPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9132E0", Offset = "0x9122E0", VA = "0x1809132E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool OMJABJLBCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5053500", Offset = "0x5052500", VA = "0x185053500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool CLHBGBHNGED
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xC7B250", Offset = "0xC7A250", VA = "0x180C7B250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xF9A560", Offset = "0xF99560", VA = "0x180F9A560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string CJABCEFOIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5053680", Offset = "0x5052680", VA = "0x185053680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float JOKGBFINCKD
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x10B4E30", Offset = "0x10B3E30", VA = "0x1810B4E30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x13154B0", Offset = "0x13144B0", VA = "0x1813154B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x50538E0", Offset = "0x50528E0", VA = "0x1850538E0")]
	public CMEEELBPIEJ(IEnumerator<OJAHJFHMFIA> HDPJJBJGDFC, DONPIDFEOGC AEOEKGNDHFM, BKIFKIBMENE LNFEMDDJPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5053270", Offset = "0x5052270", VA = "0x185053270")]
	public OJAHJFHMFIA EMOKKELPDCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5053600", Offset = "0x5052600", VA = "0x185053600")]
	public bool NOCKNEBLFEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5053580", Offset = "0x5052580", VA = "0x185053580")]
	public void HKHNCGFKDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5053800", Offset = "0x5052800", VA = "0x185053800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x11189B0", Offset = "0x11179B0", VA = "0x1811189B0")]
	[CompilerGenerated]
	private void OKAMCCFOFAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class EAENCOBLAJE
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class PMCANDDBJIN : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private OJAHJFHMFIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public FAMPCAPNPKO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public GNLBOPKOGJP.CIAOIIPEFHB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
		[DebuggerHidden]
		public PMCANDDBJIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x50691A0", Offset = "0x50681A0", VA = "0x1850691A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5069240", Offset = "0x5068240", VA = "0x185069240", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5059E20", Offset = "0x5058E20", VA = "0x185059E20")]
	public static HKMCLDHFALI CMFLNHKPOEB(float KILAFDPOMCI, Action<float> IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI, bool OCINHGHPEFF = true, [Optional] EDKLOBCPLML MNMAOHAMKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5059F20", Offset = "0x5058F20", VA = "0x185059F20")]
	public static HKMCLDHFALI CMFLNHKPOEB(MonoBehaviour KNPEDAOHAGF, float KILAFDPOMCI, Action<float> IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI, bool OCINHGHPEFF = true, [Optional] EDKLOBCPLML MNMAOHAMKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x505A1F0", Offset = "0x50591F0", VA = "0x18505A1F0")]
	public static HKMCLDHFALI MKLDKOOMOEG(MonoBehaviour KNPEDAOHAGF, float KILAFDPOMCI, Action<float> IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI, bool OCINHGHPEFF = true, [Optional] EDKLOBCPLML MNMAOHAMKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x505A030", Offset = "0x5059030", VA = "0x18505A030")]
	public static HKMCLDHFALI EEFOCIHABAB(GCMGPIABEJC AEOEKGNDHFM, float KILAFDPOMCI, Action<float> IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI, bool OCINHGHPEFF = true, [Optional] EDKLOBCPLML MNMAOHAMKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x505A310", Offset = "0x5059310", VA = "0x18505A310")]
	private static IEnumerator<OJAHJFHMFIA> OGKLFGOCBCH(LCGHPFLLBAN KAOIELLKBLL, float KILAFDPOMCI, GNLBOPKOGJP.CIAOIIPEFHB IHPFMGDPJNE, Action<float> IEEMKMNHPKK, bool OCINHGHPEFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5059DC0", Offset = "0x5058DC0", VA = "0x185059DC0")]
	private static IEnumerator<OJAHJFHMFIA> CKDAFFIDFBO(LCGHPFLLBAN KAOIELLKBLL, float KILAFDPOMCI, GNLBOPKOGJP.CIAOIIPEFHB IHPFMGDPJNE, Action<float> IEEMKMNHPKK, bool OCINHGHPEFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x505A140", Offset = "0x5059140", VA = "0x18505A140")]
	[IteratorStateMachine(typeof(PMCANDDBJIN))]
	private static IEnumerator<OJAHJFHMFIA> JNGAKBCANEI(FAMPCAPNPKO KJLLCCDFLAJ, float KILAFDPOMCI, GNLBOPKOGJP.CIAOIIPEFHB IHPFMGDPJNE, Action<float> IEEMKMNHPKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface EGENNBCDMIG
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool CGNECMHCMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GKOBCIFBBNF;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool APIPFIDEBKB(bool HNGHLFFJCGK = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool APIPFIDEBKB(Action OKCPFPFJOFL, bool HNGHLFFJCGK = false);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class ELHIKBIKNEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static readonly ELHIKBIKNEF OINHJLGKBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Action ODDADKHJNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private bool NBJIGGJMNPH;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0xA1F9D0", Offset = "0xA1E9D0", VA = "0x180A1F9D0")]
	public ELHIKBIKNEF(Action ODDADKHJNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x505A890", Offset = "0x5059890", VA = "0x18505A890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface MLGLNOOCNGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T FNCIDNAOCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PAFCHNOEJEM(UnityEngine.Object AEOEKGNDHFM, Action<T> ILHMIOGJGAL);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface OBFGCNGJFKC<T> : MLGLNOOCNGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T FNCIDNAOCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class IBLFHKDKILK<T> : OBFGCNGJFKC<T>, MLGLNOOCNGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class IEOCDFDJOCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public IBLFHKDKILK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public CKLNBAMINBE<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public IEOCDFDJOCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1584CB0", Offset = "0x1583CB0", VA = "0x181584CB0")]
		internal void JPKJOKKMGCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static GameObject GAGIKODKICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly List<CKLNBAMINBE<UnityEngine.Object, Action<T>>> HNHCNJDENCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private T ICNNPBMEDBA;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T FNCIDNAOCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xAB1470", Offset = "0xAB0470", VA = "0x180AB1470", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1573AA0", Offset = "0x1572AA0", VA = "0x181573AA0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x1573B00", Offset = "0x1572B00", VA = "0x181573B00")]
	private static bool MKMLLEMHMIK(T LFEMLKHNBHE, T CNOAFMMFDKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x1574630", Offset = "0x1573630", VA = "0x181574630")]
	public IBLFHKDKILK(T HPOBAMMIEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x1573D30", Offset = "0x1572D30", VA = "0x181573D30", Slot = "6")]
	public IDisposable PAFCHNOEJEM(UnityEngine.Object AEOEKGNDHFM, Action<T> ILHMIOGJGAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x1573EA0", Offset = "0x1572EA0", VA = "0x181573EA0")]
	private void PPEGKOEDFGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface FMCJFCEJFMH
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKCLAMNHJNI(string OALFIBFPPAC);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EDOMHMEEAEO();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class FABIJAJLODJ : FMCJFCEJFMH
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "4")]
	public void AKCLAMNHJNI(string OALFIBFPPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
	public void EDOMHMEEAEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public FABIJAJLODJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class CPOIPAIKGNC : AFIFABMNPKO
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class JMJFHJEBDDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public CPOIPAIKGNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public JMJFHJEBDDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x50587F0", Offset = "0x50577F0", VA = "0x1850587F0")]
		internal void FEAPHFHDEPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class DGLHMAPPJNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public CPOIPAIKGNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public DGLHMAPPJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x50587F0", Offset = "0x50577F0", VA = "0x1850587F0")]
		internal void KNOJBPDDPEF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly float BJJFACLHEGN;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x50547C0", Offset = "0x50537C0", VA = "0x1850547C0")]
	public CPOIPAIKGNC(Behaviour AEOEKGNDHFM, float BJJFACLHEGN, [Optional] Action OPELIJALDAP, [Optional] EDKLOBCPLML MNMAOHAMKAN, [Optional] LCGHPFLLBAN KAOIELLKBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x50546C0", Offset = "0x50536C0", VA = "0x1850546C0", Slot = "9")]
	protected override bool JMFAHEBMMIP(Action OKCPFPFJOFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x50545C0", Offset = "0x50535C0", VA = "0x1850545C0", Slot = "10")]
	protected override bool GCJCOMFPDPH(Action OKCPFPFJOFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class BKKAJAIGOBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class FLOJPOIDGHC : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private OJAHJFHMFIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public BKKAJAIGOBI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
		[DebuggerHidden]
		public FLOJPOIDGHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x505C010", Offset = "0x505B010", VA = "0x18505C010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x505C0B0", Offset = "0x505B0B0", VA = "0x18505C0B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private HKMCLDHFALI OFAIICMMHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private GCMGPIABEJC AEOEKGNDHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private Action<float> FPHBDJMPDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private float MIIIHGIGKKA;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5052500", Offset = "0x5051500", VA = "0x185052500")]
	public BKKAJAIGOBI(GCMGPIABEJC AEOEKGNDHFM, float KILAFDPOMCI, Action<float> IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5052100", Offset = "0x5051100", VA = "0x185052100")]
	private void KIKGAMNGMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5051F80", Offset = "0x5050F80", VA = "0x185051F80")]
	private void ILPMCNJFPCI(string AOLOOCNDGPL, Action DEBDOBLOION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5052470", Offset = "0x5051470", VA = "0x185052470")]
	[IteratorStateMachine(typeof(FLOJPOIDGHC))]
	private IEnumerator<OJAHJFHMFIA> LNCGNCJBIPI(Action DEBDOBLOION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5051F20", Offset = "0x5050F20", VA = "0x185051F20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x50522B0", Offset = "0x50512B0", VA = "0x1850522B0")]
	[CompilerGenerated]
	private void LLKKLPBMOBB(string PJPDEBBCODN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class GJLIOEMNEIF
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct PFGGBOGELED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public DMAGBNLMNEH ECDNIEHDBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public GCMGPIABEJC DAPALCHBCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public BKIFKIBMENE PMGOCGJKJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IEnumerator<OJAHJFHMFIA> AGCMPEKCPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public OJAHJFHMFIA IIMOLHCCPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public OFDPOADFAJM HEFOPALPHMM;
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct NJEMBGEBGKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public GNLBOPKOGJP.CIAOIIPEFHB EBNAPHHFILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public List<PFGGBOGELED> JFNFOIAILOP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class IEMNPENDPFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public BKIFKIBMENE promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public GJLIOEMNEIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public GCMGPIABEJC context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public DMAGBNLMNEH routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public OFDPOADFAJM coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public OJAHJFHMFIA currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public IEnumerator<OJAHJFHMFIA> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IEMNPENDPFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5063A10", Offset = "0x5062A10", VA = "0x185063A10")]
		internal void LKLIGJOBNDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class NLEMMMIFNOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public DMAGBNLMNEH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public GJLIOEMNEIF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NLEMMMIFNOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5068850", Offset = "0x5067850", VA = "0x185068850")]
		internal void AFGDPFJEFFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class IFKDJIOGNMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public DMAGBNLMNEH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public GJLIOEMNEIF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IFKDJIOGNMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5064310", Offset = "0x5063310", VA = "0x185064310")]
		internal void OPFDGMPEDDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class POCLDPJFNBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public DMAGBNLMNEH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public GJLIOEMNEIF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public POCLDPJFNBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5069280", Offset = "0x5068280", VA = "0x185069280")]
		internal void CDFKEPMLLPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const OFDPOADFAJM APHFCJBPBDL = OFDPOADFAJM.Cancelled | OFDPOADFAJM.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private bool[] KGJIJAEGDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<OFDPOADFAJM> EPDGCADKHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<float> LLOAFBECAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> IJHMIHIFPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> PHDCCIOAABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> CJIEEBBPBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> FCMNNCBIJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> POCFNNELEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private DMAGBNLMNEH[] DGJFOKPBJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private BKIFKIBMENE[] DJEFGAHMCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private GCMGPIABEJC[] CFGJHELDDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private IEnumerator<OJAHJFHMFIA>[] FJLACFKOIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private OJAHJFHMFIA[] GFCCKEBPLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int PFBNGAEFJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int OENKBEGLEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly int GOFDJFEHHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float DALMNIIPEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private LPNGLGAEBGC KCCEJANNELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JobHandle IJMBNNNCJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<DMAGBNLMNEH> NIHDPCJIKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool HECOPIBNDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> EDENGDKIILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private List<Action> ODKMIBEPNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private bool BDMLEJNALCE;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public NJEMBGEBGKG[] KDBMLNJOCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1014670", Offset = "0x1013670", VA = "0x181014670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x505F070", Offset = "0x505E070", VA = "0x18505F070")]
	private static int LBFEFGAOFLK(GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x505FF80", Offset = "0x505EF80", VA = "0x18505FF80")]
	public GJLIOEMNEIF(GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x505F9E0", Offset = "0x505E9E0", VA = "0x18505F9E0")]
	private void MKHJAGHMEIL(ref int HAFHNKCKCEN, int PHNOCPKDIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x505F0A0", Offset = "0x505E0A0", VA = "0x18505F0A0")]
	public void MABONGGBAFO(GCMGPIABEJC AEOEKGNDHFM, OJAHJFHMFIA KKFCEDOADIA, IEnumerator<OJAHJFHMFIA> HDPJJBJGDFC, BKIFKIBMENE LNFEMDDJPIK, [Optional] DMAGBNLMNEH HDLODFPOFPO, OFDPOADFAJM DMDOABBODBB = OFDPOADFAJM.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x505E540", Offset = "0x505D540", VA = "0x18505E540")]
	public void FLPIEKKCHOC(IEnumerable<PFGGBOGELED> BPMBOPHNAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x505E720", Offset = "0x505D720", VA = "0x18505E720")]
	private PFGGBOGELED GIEDNGJILDI(int MCFKHMAGIFA)
	{
		return default(PFGGBOGELED);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x505DD10", Offset = "0x505CD10", VA = "0x18505DD10")]
	private void AKFGDMGDODI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1B7E620", Offset = "0x1B7D620", VA = "0x181B7E620")]
	private static void ALBEHKIDLCP<T>(int MCFKHMAGIFA, T[] AEKKJHIJLCM, int BKMCHKCIDOC, [Optional] T HCGAFKFLDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x1B7E600", Offset = "0x1B7D600", VA = "0x181B7E600")]
	private static void ALBEHKIDLCP<T>(int MCFKHMAGIFA, NativeArray<T> AEKKJHIJLCM, int BKMCHKCIDOC, [Optional] T HCGAFKFLDCK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x505E140", Offset = "0x505D140", VA = "0x18505E140")]
	private void EOIGDPJDNDN(IEnumerable<PFGGBOGELED> BPMBOPHNAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x505FBD0", Offset = "0x505EBD0", VA = "0x18505FBD0")]
	private void NCLAFAAGPCI(PFGGBOGELED CMCGHACKFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x505EDB0", Offset = "0x505DDB0", VA = "0x18505EDB0")]
	private INNCOJBPNOP ICNDAPKIKDG(int JDDNHBDIEGC)
	{
		return default(INNCOJBPNOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x505FDA0", Offset = "0x505EDA0", VA = "0x18505FDA0")]
	public void ONNONMMDGCA(float NCNKEPCFEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x505F960", Offset = "0x505E960", VA = "0x18505F960")]
	private void MHDHFLEDKIO(Action LFEMLKHNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x505E0C0", Offset = "0x505D0C0", VA = "0x18505E0C0")]
	private void DPBJNLOHBIL(Action LFEMLKHNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x505F220", Offset = "0x505E220", VA = "0x18505F220")]
	public void MGOKCOLDPKH(float NCNKEPCFEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x505FCA0", Offset = "0x505ECA0", VA = "0x18505FCA0")]
	public void OJEHGLDDBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x505EC80", Offset = "0x505DC80", VA = "0x18505EC80")]
	public void HKHNCGFKDLF(DMAGBNLMNEH KJLLCCDFLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x505DBE0", Offset = "0x505CBE0", VA = "0x18505DBE0")]
	public void AIBFNNGIPLJ(DMAGBNLMNEH KJLLCCDFLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x505E410", Offset = "0x505D410", VA = "0x18505E410")]
	public void FJNIEGGMDHE(DMAGBNLMNEH KJLLCCDFLAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class GJEAOEDEOIB : EGENNBCDMIG, IEnumerable<EGENNBCDMIG>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly List<EGENNBCDMIG> MPGFIGIBKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool JNPEKLNHACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private Action OPELIJALDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private bool EINALIEOFGI;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CGNECMHCMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x505D7C0", Offset = "0x505C7C0", VA = "0x18505D7C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GKOBCIFBBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x505D900", Offset = "0x505C900", VA = "0x18505D900", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x505DA20", Offset = "0x505CA20", VA = "0x18505DA20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x505DB40", Offset = "0x505CB40", VA = "0x18505DB40")]
	public GJEAOEDEOIB([Optional] Action OPELIJALDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x505D3A0", Offset = "0x505C3A0", VA = "0x18505D3A0")]
	public void AMLBOIMHPGF(EGENNBCDMIG PONJGAIPEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x505D240", Offset = "0x505C240", VA = "0x18505D240")]
	private void AGOEFFMPLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x505D4C0", Offset = "0x505C4C0", VA = "0x18505D4C0", Slot = "7")]
	public bool APIPFIDEBKB(bool HNGHLFFJCGK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x505D4E0", Offset = "0x505C4E0", VA = "0x18505D4E0", Slot = "8")]
	public bool APIPFIDEBKB(Action OKCPFPFJOFL, bool HNGHLFFJCGK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x505D9A0", Offset = "0x505C9A0", VA = "0x18505D9A0", Slot = "9")]
	public IEnumerator<EGENNBCDMIG> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x505DAC0", Offset = "0x505CAC0", VA = "0x18505DAC0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class AFIFABMNPKO : EGENNBCDMIG
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class HKJEABDBHMB : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private OJAHJFHMFIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public AFIFABMNPKO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
		[DebuggerHidden]
		public HKJEABDBHMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5061AA0", Offset = "0x5060AA0", VA = "0x185061AA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5061B70", Offset = "0x5060B70", VA = "0x185061B70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly Behaviour AEOEKGNDHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly Action OPELIJALDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private BEKPINHCBFC EMMAPPFGDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly EDKLOBCPLML MNMAOHAMKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	protected readonly LCGHPFLLBAN KAOIELLKBLL;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool CGNECMHCMOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA23E80", Offset = "0xA22E80", VA = "0x180A23E80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GKOBCIFBBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x504E940", Offset = "0x504D940", VA = "0x18504E940", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x504EA60", Offset = "0x504DA60", VA = "0x18504EA60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x504EDA0", Offset = "0x504DDA0", VA = "0x18504EDA0")]
	protected AFIFABMNPKO(Behaviour AEOEKGNDHFM, [Optional] Action OPELIJALDAP, [Optional] EDKLOBCPLML MNMAOHAMKAN, [Optional] LCGHPFLLBAN KAOIELLKBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x504E8A0", Offset = "0x504D8A0", VA = "0x18504E8A0", Slot = "7")]
	public bool APIPFIDEBKB(bool HNGHLFFJCGK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x504E850", Offset = "0x504D850", VA = "0x18504E850", Slot = "8")]
	public bool APIPFIDEBKB(Action OKCPFPFJOFL, bool HNGHLFFJCGK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool JMFAHEBMMIP(Action OKCPFPFJOFL);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool GCJCOMFPDPH(Action OKCPFPFJOFL);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x504EB80", Offset = "0x504DB80", VA = "0x18504EB80")]
	protected void OHAEHFJNJAD(Action OKCPFPFJOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x504EBA0", Offset = "0x504DBA0", VA = "0x18504EBA0")]
	protected GAEMIFNLIHB PBAIKNEAPMD(float PNCIGIECCCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x504E9E0", Offset = "0x504D9E0", VA = "0x18504E9E0")]
	private void ILPJAPJDNDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x504EB00", Offset = "0x504DB00", VA = "0x18504EB00")]
	[IteratorStateMachine(typeof(HKJEABDBHMB))]
	private IEnumerator<OJAHJFHMFIA> KIADBJEMGHC(float PNCIGIECCCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x504E900", Offset = "0x504D900", VA = "0x18504E900")]
	[CompilerGenerated]
	private void DOLAJJKDKFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Flags]
internal enum OFDPOADFAJM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal class DMAGBNLMNEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public GJLIOEMNEIF CPDHCFPAHEJ;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int EODOJNLPHFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x91AF80", Offset = "0x919F80", VA = "0x18091AF80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5059500", Offset = "0x5058500", VA = "0x185059500")]
	public static OJAHJFHMFIA EMOKKELPDCL(IEnumerator<OJAHJFHMFIA> HDPJJBJGDFC, BKIFKIBMENE LNFEMDDJPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5059420", Offset = "0x5058420", VA = "0x185059420")]
	public OJAHJFHMFIA EMOKKELPDCL(BKIFKIBMENE[] DJEFGAHMCJP, IEnumerator<OJAHJFHMFIA>[] OGKNPKFDIHE, OJAHJFHMFIA[] EHOFMJOILJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x50596B0", Offset = "0x50586B0", VA = "0x1850596B0")]
	public void GDMDNIGEBGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5059820", Offset = "0x5058820", VA = "0x185059820")]
	public void LOFAEOJNJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x50596E0", Offset = "0x50586E0", VA = "0x1850596E0")]
	public void KFKEBIIMJME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x50596B0", Offset = "0x50586B0", VA = "0x1850596B0")]
	public void HKHNCGFKDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public DMAGBNLMNEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class NJLKAHNLJIE : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class KGCNPFAKANB : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private OJAHJFHMFIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public NJLKAHNLJIE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
		[DebuggerHidden]
		public KGCNPFAKANB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5064850", Offset = "0x5063850", VA = "0x185064850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5064930", Offset = "0x5063930", VA = "0x185064930", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Action KKMKGKFJCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private bool JHBFNCKBGOP;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool OLALHFPGCFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xB87BE0", Offset = "0xB86BE0", VA = "0x180B87BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5068750", Offset = "0x5067750", VA = "0x185068750")]
	public NJLKAHNLJIE(GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5068660", Offset = "0x5067660", VA = "0x185068660")]
	[IteratorStateMachine(typeof(KGCNPFAKANB))]
	private IEnumerator<OJAHJFHMFIA> DEPBEPPLKJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x50686D0", Offset = "0x50676D0", VA = "0x1850686D0", Slot = "4")]
	public void OnCompleted(Action DJKOECBIKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public void AOLMMDHAAMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class OEBFPHLCCEB
{
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5068890", Offset = "0x5067890", VA = "0x185068890")]
	public static NJLKAHNLJIE KCKHOOIGOBL(this GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal class LDCKHPFGCAJ : FAPDJEIOFHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly EDKLOBCPLML MNMAOHAMKAN;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5064E10", Offset = "0x5063E10", VA = "0x185064E10")]
	[FBCFLFBFGIL(LAFFCBAHJKM.None)]
	private static void HEBPGFNGBNI(CNALHHIKJDD DBGHBAHCJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x919D70", Offset = "0x918D70", VA = "0x180919D70")]
	[Preserve]
	internal LDCKHPFGCAJ([JFLEHDEIONF(null)] EDKLOBCPLML MNMAOHAMKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5064E80", Offset = "0x5063E80", VA = "0x185064E80", Slot = "4")]
	public IDisposable KDHIGMFPANF(float KILAFDPOMCI, Action<float> ELHFOIEJAFO, bool OCINHGHPEFF = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal enum INNCOJBPNOP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class LGIIEGBDAMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public enum GEKKCFBCBMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct JHGGADPHPBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public GNLBOPKOGJP.CIAOIIPEFHB EBNAPHHFILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public GEKKCFBCBMN AEJPHGENGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public List<CMEEELBPIEJ> ADKOIPMKMIP;
	}

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private static readonly GEKKCFBCBMN[] ENGLDEEKPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private bool CICGPKCOLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly CMEEELBPIEJ[] HFEDKIDBHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly List<CMEEELBPIEJ> DMNPBNMCHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Stack<int> LLECBABPJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly List<CMEEELBPIEJ> OBDIDENMPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Stack<int> AHHFEIDLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly FMCJFCEJFMH BPFJPBOGHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private bool BDMLEJNALCE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public JHGGADPHPBL[,] DLGPEPGPLML
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x97E5E0", Offset = "0x97D5E0", VA = "0x18097E5E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5066430", Offset = "0x5065430", VA = "0x185066430")]
	public LGIIEGBDAMM(GNLBOPKOGJP.CIAOIIPEFHB IHPFMGDPJNE, FMCJFCEJFMH BPFJPBOGHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x50650C0", Offset = "0x50640C0", VA = "0x1850650C0")]
	public void CLJEBDPEALJ(CMEEELBPIEJ HDPJJBJGDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x50651E0", Offset = "0x50641E0", VA = "0x1850651E0")]
	public void DIAHGEEMMEL(IList<CMEEELBPIEJ> OGKNPKFDIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5065990", Offset = "0x5064990", VA = "0x185065990")]
	public void HKEEOPAIBAN(IList<CMEEELBPIEJ> OGKNPKFDIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5065FA0", Offset = "0x5064FA0", VA = "0x185065FA0")]
	private void KFIAHCIKOMJ(CMEEELBPIEJ HDPJJBJGDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x50655F0", Offset = "0x50645F0", VA = "0x1850655F0")]
	private void FBCKHPNNCHB(IList<CMEEELBPIEJ> OGKNPKFDIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5064F60", Offset = "0x5063F60", VA = "0x185064F60")]
	private INNCOJBPNOP BILCLMHAMGH(CMEEELBPIEJ HDPJJBJGDFC)
	{
		return default(INNCOJBPNOP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x50660A0", Offset = "0x50650A0", VA = "0x1850660A0")]
	public void MCCBAFPODDI(float NCNKEPCFEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5065780", Offset = "0x5064780", VA = "0x185065780")]
	public void GCHIBHJJAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5065C60", Offset = "0x5064C60", VA = "0x185065C60")]
	private void IMIIKHCBLBL(List<CMEEELBPIEJ> OGKNPKFDIHE, Stack<int> CKAKNDLEJPP, bool MGMFLNELADC, float DDHDCNPPPKP = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x50654B0", Offset = "0x50644B0", VA = "0x1850654B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x50661F0", Offset = "0x50651F0", VA = "0x1850661F0")]
	private void NLLNNLBOPIP(List<CMEEELBPIEJ> OGKNPKFDIHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class IKDJJDLGLLE : DONPIDFEOGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly Behaviour KNPEDAOHAGF;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string CJABCEFOIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x50643D0", Offset = "0x50633D0", VA = "0x1850643D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool DFBOGFJEIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5064350", Offset = "0x5063350", VA = "0x185064350", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool EPJGFGNBMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x50643B0", Offset = "0x50633B0", VA = "0x1850643B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x919D70", Offset = "0x918D70", VA = "0x180919D70")]
	public IKDJJDLGLLE(Behaviour KNPEDAOHAGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class LGEOANNIOCL : AFIFABMNPKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly float BJJFACLHEGN;

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x50547C0", Offset = "0x50537C0", VA = "0x1850547C0")]
	public LGEOANNIOCL(Behaviour AEOEKGNDHFM, float BJJFACLHEGN, [Optional] Action OPELIJALDAP, [Optional] EDKLOBCPLML MNMAOHAMKAN, [Optional] LCGHPFLLBAN KAOIELLKBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x98E270", Offset = "0x98D270", VA = "0x18098E270", Slot = "9")]
	protected override bool JMFAHEBMMIP(Action OKCPFPFJOFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5064F20", Offset = "0x5063F20", VA = "0x185064F20", Slot = "10")]
	protected override bool GCJCOMFPDPH(Action OKCPFPFJOFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class LCCBIJALABF
{
	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5064C90", Offset = "0x5063C90", VA = "0x185064C90")]
	public static IDisposable AHOHBIIPEME(this GCMGPIABEJC AEOEKGNDHFM, float KILAFDPOMCI, Action<float> IEEMKMNHPKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5064D90", Offset = "0x5063D90", VA = "0x185064D90")]
	public static IDisposable MJBPHOLGEAL(this GCMGPIABEJC AEOEKGNDHFM, Action<float> IEEMKMNHPKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5064D10", Offset = "0x5063D10", VA = "0x185064D10")]
	public static IDisposable KNDBKALGEIN(this GCMGPIABEJC AEOEKGNDHFM, Action<float> IEEMKMNHPKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class GMCMLOPHJAI
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class KCAEKOKCKHB : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private OJAHJFHMFIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public GNLBOPKOGJP.CIAOIIPEFHB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private ALLENCDMILF <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
		[DebuggerHidden]
		public KCAEKOKCKHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5064620", Offset = "0x5063620", VA = "0x185064620", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x50646F0", Offset = "0x50636F0", VA = "0x1850646F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class IPBEHDMGLEK : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private OJAHJFHMFIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public GNLBOPKOGJP.CIAOIIPEFHB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private ALLENCDMILF <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
		[DebuggerHidden]
		public IPBEHDMGLEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5064460", Offset = "0x5063460", VA = "0x185064460", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5064550", Offset = "0x5063550", VA = "0x185064550", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x50606A0", Offset = "0x505F6A0", VA = "0x1850606A0")]
	public static HKMCLDHFALI CMFLNHKPOEB(Action IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5060750", Offset = "0x505F750", VA = "0x185060750")]
	public static HKMCLDHFALI CMFLNHKPOEB(Behaviour AEOEKGNDHFM, Action IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5060590", Offset = "0x505F590", VA = "0x185060590")]
	public static HKMCLDHFALI CMFLNHKPOEB(Behaviour AEOEKGNDHFM, Action<float> IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5060890", Offset = "0x505F890", VA = "0x185060890")]
	[IteratorStateMachine(typeof(KCAEKOKCKHB))]
	private static IEnumerator<OJAHJFHMFIA> OGKLFGOCBCH(GNLBOPKOGJP.CIAOIIPEFHB IHPFMGDPJNE, Action IEEMKMNHPKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x5060810", Offset = "0x505F810", VA = "0x185060810")]
	[IteratorStateMachine(typeof(IPBEHDMGLEK))]
	private static IEnumerator<OJAHJFHMFIA> OGKLFGOCBCH(GNLBOPKOGJP.CIAOIIPEFHB IHPFMGDPJNE, Action<float> IEEMKMNHPKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class FOOMJKIPOGO
{
	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x505C620", Offset = "0x505B620", VA = "0x18505C620")]
	public static IDisposable CMFLNHKPOEB(this MonoBehaviour KNPEDAOHAGF, Action IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x505C5A0", Offset = "0x505B5A0", VA = "0x18505C5A0")]
	public static IDisposable CMFLNHKPOEB(this MonoBehaviour KNPEDAOHAGF, Action<float> IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x505CC40", Offset = "0x505BC40", VA = "0x18505CC40")]
	public static IDisposable MCCBAFPODDI(this MonoBehaviour KNPEDAOHAGF, Action IEEMKMNHPKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x505CA90", Offset = "0x505BA90", VA = "0x18505CA90")]
	public static IDisposable KMECDBNKAGA(this MonoBehaviour KNPEDAOHAGF, Action IEEMKMNHPKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x505CCB0", Offset = "0x505BCB0", VA = "0x18505CCB0")]
	public static IDisposable OEDCAGJCGKO(this MonoBehaviour KNPEDAOHAGF, Action IEEMKMNHPKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x505C850", Offset = "0x505B850", VA = "0x18505C850")]
	public static IDisposable HEOMIMCIMNL(this MonoBehaviour KNPEDAOHAGF, Action IEEMKMNHPKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x505C970", Offset = "0x505B970", VA = "0x18505C970")]
	public static IDisposable JKLDGMKNLHL(this MonoBehaviour KNPEDAOHAGF, Action IEEMKMNHPKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x505CB10", Offset = "0x505BB10", VA = "0x18505CB10")]
	public static IDisposable LEIJJNPNOJA(this MonoBehaviour KNPEDAOHAGF, float KILAFDPOMCI, Action<float> IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI, bool OCINHGHPEFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x505C360", Offset = "0x505B360", VA = "0x18505C360")]
	public static IDisposable AEFANNAHGJB(this MonoBehaviour KNPEDAOHAGF, float KILAFDPOMCI, Action<float> IEEMKMNHPKK, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI, bool OCINHGHPEFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x505C9F0", Offset = "0x505B9F0", VA = "0x18505C9F0")]
	public static IDisposable KDHIGMFPANF(this MonoBehaviour KNPEDAOHAGF, float KILAFDPOMCI, Action<float> IEEMKMNHPKK, bool OCINHGHPEFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x505C480", Offset = "0x505B480", VA = "0x18505C480")]
	public static IDisposable AKNDGKNCAEK(this MonoBehaviour KNPEDAOHAGF, Action<float> IEEMKMNHPKK, bool OCINHGHPEFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x505C730", Offset = "0x505B730", VA = "0x18505C730")]
	public static IDisposable FBLACABHFKE(this MonoBehaviour KNPEDAOHAGF, Action<float> IEEMKMNHPKK, bool OCINHGHPEFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x505C6A0", Offset = "0x505B6A0", VA = "0x18505C6A0")]
	public static IDisposable EJOHCNBFIPH(this MonoBehaviour KNPEDAOHAGF, Action<float> IEEMKMNHPKK, bool OCINHGHPEFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x505CD30", Offset = "0x505BD30", VA = "0x18505CD30")]
	public static IDisposable OJNPAKKMNBP(this MonoBehaviour KNPEDAOHAGF, Action<float> IEEMKMNHPKK, bool OCINHGHPEFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x505C7C0", Offset = "0x505B7C0", VA = "0x18505C7C0")]
	public static IDisposable GCGOFHNDFFI(this MonoBehaviour KNPEDAOHAGF, Action<float> IEEMKMNHPKK, bool OCINHGHPEFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x505C510", Offset = "0x505B510", VA = "0x18505C510")]
	public static IDisposable AOEELFBNDPJ(this MonoBehaviour KNPEDAOHAGF, Action<float> IEEMKMNHPKK, bool OCINHGHPEFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x505CBB0", Offset = "0x505BBB0", VA = "0x18505CBB0")]
	public static IDisposable LFCHBNJFOCG(this MonoBehaviour KNPEDAOHAGF, Action<float> IEEMKMNHPKK, bool OCINHGHPEFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x505C8D0", Offset = "0x505B8D0", VA = "0x18505C8D0")]
	public static IDisposable IAAKFMGMKEE(this MonoBehaviour KNPEDAOHAGF, float KILAFDPOMCI, Action<float> IEEMKMNHPKK, bool OCINHGHPEFF = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class BKIFKIBMENE : HHBNBDMPFEC, HKMCLDHFALI, BEKPINHCBFC, GAEMIFNLIHB, IEnumerator, OJAHJFHMFIA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private GNLBOPKOGJP.CIAOIIPEFHB OKKMNFKBHEL;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private GNLBOPKOGJP.CIAOIIPEFHB ENGIJJGBAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x34808C0", Offset = "0x347F8C0", VA = "0x1834808C0", Slot = "23")]
		get
		{
			return default(GNLBOPKOGJP.CIAOIIPEFHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public GNLBOPKOGJP.CIAOIIPEFHB CPDHCFPAHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xC13350", Offset = "0xC12350", VA = "0x180C13350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private float MGIJBLNCOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xFAEBD0", Offset = "0xFADBD0", VA = "0x180FAEBD0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool EDEMAFBJMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5051EA0", Offset = "0x5050EA0", VA = "0x185051EA0", Slot = "24")]
	private bool HLKHPPBFDBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5051E90", Offset = "0x5050E90", VA = "0x185051E90", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5051EC0", Offset = "0x5050EC0", VA = "0x185051EC0")]
	public BKIFKIBMENE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal interface DONPIDFEOGC
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string CJABCEFOIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DFBOGFJEIOP
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool EPJGFGNBMBI
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class HBBLNFODNOL
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class BKACONDOKKJ : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private OJAHJFHMFIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public GNLBOPKOGJP.CIAOIIPEFHB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
		[DebuggerHidden]
		public BKACONDOKKJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5050790", Offset = "0x504F790", VA = "0x185050790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5050850", Offset = "0x504F850", VA = "0x185050850", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class KEHGELCJDKC : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private OJAHJFHMFIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public GNLBOPKOGJP.CIAOIIPEFHB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private OJAHJFHMFIA <wait>5__1;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
		[DebuggerHidden]
		public KEHGELCJDKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5064730", Offset = "0x5063730", VA = "0x185064730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5064810", Offset = "0x5063810", VA = "0x185064810", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5060DB0", Offset = "0x505FDB0", VA = "0x185060DB0")]
	[IteratorStateMachine(typeof(BKACONDOKKJ))]
	private static IEnumerator<OJAHJFHMFIA> DEPBEPPLKJL(float DKNLAFMNLEI, GNLBOPKOGJP.CIAOIIPEFHB IHPFMGDPJNE, Action KMHHEENKEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5061520", Offset = "0x5060520", VA = "0x185061520")]
	[IteratorStateMachine(typeof(KEHGELCJDKC))]
	private static IEnumerator<OJAHJFHMFIA> MGBDMAEPCOB(float DKNLAFMNLEI, GNLBOPKOGJP.CIAOIIPEFHB IHPFMGDPJNE, Action KMHHEENKEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5061070", Offset = "0x5060070", VA = "0x185061070")]
	public static IDisposable FKCBFNHKLOK(this MonoBehaviour KNPEDAOHAGF, float DKNLAFMNLEI, Action KMHHEENKEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5061340", Offset = "0x5060340", VA = "0x185061340")]
	public static HKMCLDHFALI IBJLNNNIPCB(this MonoBehaviour KNPEDAOHAGF, float DKNLAFMNLEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5060F40", Offset = "0x505FF40", VA = "0x185060F40")]
	public static HKMCLDHFALI FKCBFNHKLOK(this MonoBehaviour KNPEDAOHAGF, float DKNLAFMNLEI, GNLBOPKOGJP.CIAOIIPEFHB IHPFMGDPJNE, Action KMHHEENKEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5061400", Offset = "0x5060400", VA = "0x185061400")]
	public static HKMCLDHFALI IGCMOAOOKBK(this MonoBehaviour KNPEDAOHAGF, Action KMHHEENKEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5060E40", Offset = "0x505FE40", VA = "0x185060E40")]
	public static HKMCLDHFALI EGBBNACIGEN(this MonoBehaviour KNPEDAOHAGF, Action KMHHEENKEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5061260", Offset = "0x5060260", VA = "0x185061260")]
	public static HKMCLDHFALI HHALBACJGFI(this MonoBehaviour KNPEDAOHAGF, Action KMHHEENKEHH, [Optional] EDKLOBCPLML MNMAOHAMKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x50615B0", Offset = "0x50605B0", VA = "0x1850615B0")]
	public static HKMCLDHFALI NPLIGFPEKPO(this MonoBehaviour KNPEDAOHAGF, Action KMHHEENKEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5060D80", Offset = "0x505FD80", VA = "0x185060D80")]
	public static HKMCLDHFALI DBBCDEHCIDC(this MonoBehaviour KNPEDAOHAGF, Action KMHHEENKEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x50614F0", Offset = "0x50604F0", VA = "0x1850614F0")]
	public static HKMCLDHFALI LIJKLBKLFPK(this MonoBehaviour KNPEDAOHAGF, Action KMHHEENKEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5061420", Offset = "0x5060420", VA = "0x185061420")]
	private static HKMCLDHFALI IOPBCJMJBCF(MonoBehaviour KNPEDAOHAGF, GNLBOPKOGJP.CIAOIIPEFHB OBFDHOJBHJI, Action KMHHEENKEHH, [Optional] EDKLOBCPLML MNMAOHAMKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x50615E0", Offset = "0x50605E0", VA = "0x1850615E0")]
	public static HKMCLDHFALI PJIJHKBNLBA(this MonoBehaviour KNPEDAOHAGF, float LOACCANEHLD, Action KMHHEENKEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5060E70", Offset = "0x505FE70", VA = "0x185060E70")]
	public static HKMCLDHFALI FCOCENECPCA(this MonoBehaviour KNPEDAOHAGF, float LOACCANEHLD, Action KMHHEENKEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5060CB0", Offset = "0x505FCB0", VA = "0x185060CB0")]
	public static HKMCLDHFALI AAGOCDCIFMC(this MonoBehaviour KNPEDAOHAGF, float LOACCANEHLD, Action KMHHEENKEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5061190", Offset = "0x5060190", VA = "0x185061190")]
	public static HKMCLDHFALI HGNIJGKMIDO(this MonoBehaviour KNPEDAOHAGF, float LOACCANEHLD, Action KMHHEENKEHH)
	{
		return null;
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

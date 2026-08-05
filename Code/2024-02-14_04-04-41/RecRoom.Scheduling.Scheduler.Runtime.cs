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
public class BOFEHLDLNAG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority AICMMKPAHFB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66083A0", Offset = "0x66077A0", VA = "0x1866083A0")]
	public BOFEHLDLNAG(ThreadPriority GDGIBBJCIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6608390", Offset = "0x6607790", VA = "0x186608390", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> JBOJBANNMDJ(List<PlayerLoopSystem> MICBLLHGEEB, int HKCKKICJFNI);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct FEBPCGEODPP
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct OHDJPGBAPFN
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static KKEEGFAPLDK NKIDDEPBNAJ;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x661DF20", Offset = "0x661D320", VA = "0x18661DF20")]
				public static PlayerLoopSystem KLLLGGOLLKM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct KDALCDOKLAB
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static KKEEGFAPLDK IEFDEEEHDNP;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x66175A0", Offset = "0x66169A0", VA = "0x1866175A0")]
				public static PlayerLoopSystem KLLLGGOLLKM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct HGOBIPFKGEA
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static KKEEGFAPLDK CCGBENBCALH;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x6614B80", Offset = "0x6613F80", VA = "0x186614B80")]
				public static PlayerLoopSystem KLLLGGOLLKM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct GHJBGIKDNCG
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static KKEEGFAPLDK ALLHAPIBBPA;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static KKEEGFAPLDK IGNCALBPHBC;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static KKEEGFAPLDK PHPNMNCPHKK;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static KKEEGFAPLDK NKFIKEFEAKM;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x6614650", Offset = "0x6613A50", VA = "0x186614650")]
				public static PlayerLoopSystem KLLLGGOLLKM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct IDJANCJCIGI
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static KKEEGFAPLDK BHLNCMINJIO;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x6615160", Offset = "0x6614560", VA = "0x186615160")]
				public static PlayerLoopSystem KLLLGGOLLKM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct GDJFJGCOPGD
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static KKEEGFAPLDK ALLHAPIBBPA;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static KKEEGFAPLDK IGNCALBPHBC;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static KKEEGFAPLDK PHPNMNCPHKK;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static KKEEGFAPLDK NKFIKEFEAKM;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x66128C0", Offset = "0x6611CC0", VA = "0x1866128C0")]
				public static PlayerLoopSystem KLLLGGOLLKM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct EMFICMDDLMG
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static KKEEGFAPLDK BDKFPKCIBBH;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x660F310", Offset = "0x660E710", VA = "0x18660F310")]
				public static PlayerLoopSystem KLLLGGOLLKM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct OCANMCALPNO
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static KKEEGFAPLDK EADCJEDCIPF;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x661DAD0", Offset = "0x661CED0", VA = "0x18661DAD0")]
				public static PlayerLoopSystem KLLLGGOLLKM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct HJFFNJOBFJJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static KKEEGFAPLDK FAEGCEIOANH;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6614DE0", Offset = "0x66141E0", VA = "0x186614DE0")]
				public static PlayerLoopSystem KLLLGGOLLKM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct BOLOGPAKMPL
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static KKEEGFAPLDK CKCFMPOFNCK;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x66083E0", Offset = "0x66077E0", VA = "0x1866083E0")]
				public static PlayerLoopSystem KLLLGGOLLKM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct OGHBEGLABCA
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static KKEEGFAPLDK FGFNHFIOEHF;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x661DD20", Offset = "0x661D120", VA = "0x18661DD20")]
				public static PlayerLoopSystem KLLLGGOLLKM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct DLGMJPAGNFI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static KKEEGFAPLDK HHPDPDFJIMJ;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x660E400", Offset = "0x660D800", VA = "0x18660E400")]
				public static PlayerLoopSystem KLLLGGOLLKM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum NKJBGADCILE : byte
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
			public struct HDEEIKNJAFJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class PGGOLPHGEFM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public NKJBGADCILE updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
					public PGGOLPHGEFM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x661FC90", Offset = "0x661F090", VA = "0x18661FC90")]
					internal void PHBCFPLKFNA()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static PFEKNBHDJHH<NKJBGADCILE> APMCPFCJBFA;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6614940", Offset = "0x6613D40", VA = "0x186614940")]
				public static PlayerLoopSystem KLLLGGOLLKM(NKJBGADCILE KKNHJHEJGBC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct AMPFLJBLCJI
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class KLPCFMNNPHG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public KNGOKFOKDCJ.POILCKPKGNE key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
					public KLPCFMNNPHG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6619150", Offset = "0x6618550", VA = "0x186619150")]
					internal void BMHAJCHNJJD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable FLPBMNOMAPF;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x6606AE0", Offset = "0x6605EE0", VA = "0x186606AE0")]
				public static PlayerLoopSystem CLDMEKFLGEP(KNGOKFOKDCJ.POILCKPKGNE KCGLPAPOILB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct FPGEPLEKFLA
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class BALPAGCIGDE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public KNGOKFOKDCJ.POILCKPKGNE key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
					public BALPAGCIGDE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x6607400", Offset = "0x6606800", VA = "0x186607400")]
					internal void BMHAJCHNJJD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x6612020", Offset = "0x6611420", VA = "0x186612020")]
				public static PlayerLoopSystem CLDMEKFLGEP(KNGOKFOKDCJ.POILCKPKGNE KCGLPAPOILB)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class FPCBFNADCDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public FPCBFNADCDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6611F00", Offset = "0x6611300", VA = "0x186611F00")]
			internal List<PlayerLoopSystem> MJOMNOKMEJI(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool PAEDODAHFPC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool DOGFEOJGGKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6608D70", Offset = "0x6608170", VA = "0x186608D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6609C20", Offset = "0x6609020", VA = "0x186609C20")]
		private static void JFIFFEEILBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6608DB0", Offset = "0x66081B0", VA = "0x186608DB0")]
		private static void FBDAGDGMAHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6608B40", Offset = "0x6607F40", VA = "0x186608B40")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6609680", Offset = "0x6608A80", VA = "0x186609680")]
		private static void FBEDKNGMKEO(KNGOKFOKDCJ.POILCKPKGNE KCGLPAPOILB, PlayerLoopSystem ILNJPBLHBPP, Type LIDHKKEFFIK, Type HBIIGBPICEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6609840", Offset = "0x6608C40", VA = "0x186609840")]
		private static void HKCEEGCLDFN(PlayerLoopSystem ILNJPBLHBPP, Type LIDHKKEFFIK, Type HBIIGBPICEJ, JBOJBANNMDJ MLLOBPABEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x660C550", Offset = "0x660B950", VA = "0x18660C550")]
		private static void PBAMOJHKFGB(PlayerLoopSystem ILNJPBLHBPP, Type LIDHKKEFFIK, Type HBIIGBPICEJ, PlayerLoopSystem? LJJILFBAIMM, PlayerLoopSystem? KPDFNBFPEDG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KNGOKFOKDCJ
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum POILCKPKGNE
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
	public class AIGJCFECELI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly POILCKPKGNE EIFKOFFEBKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly NPMFMMODMKC KBLCFDGEBHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long DKDPBEJKPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long KICEOOLHBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long OFDECAGHHFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int MABFHICKOEG;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6605C60", Offset = "0x6605060", VA = "0x186605C60")]
		public AIGJCFECELI(POILCKPKGNE HLLHGJLACLE, int BGBDPOKCFCM = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x66059C0", Offset = "0x6604DC0", VA = "0x1866059C0")]
		public void CIIMPNMONBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6605A30", Offset = "0x6604E30", VA = "0x186605A30")]
		public void GGIGLMBINHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6605A80", Offset = "0x6604E80", VA = "0x186605A80")]
		public void HIAHNABLCLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static POILCKPKGNE[] MOLOIFGLANE;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static AIGJCFECELI[] NELOJEALGJE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6619430", Offset = "0x6618830", VA = "0x186619430")]
	public static AIGJCFECELI KPOAGHFJGFE(POILCKPKGNE KCGLPAPOILB, int BGBDPOKCFCM = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6619610", Offset = "0x6618A10", VA = "0x186619610")]
	public static AIGJCFECELI NDNFHBFOJDN(POILCKPKGNE KCGLPAPOILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6619390", Offset = "0x6618790", VA = "0x186619390")]
	public static void CHOIPKNJDLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NPMFMMODMKC : DCDEGEBPMJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int KNKOEKKLHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> LKFBLIMMNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double GKNDKBGCHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double OGPILMIPJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double HNKGDMEPPEK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double CDNHGFHLBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x661D830", Offset = "0x661CC30", VA = "0x18661D830", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double KCCLJGCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1765680", Offset = "0x1764A80", VA = "0x181765680", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double BBIBAANHCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1D168B0", Offset = "0x1D15CB0", VA = "0x181D168B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x661DA20", Offset = "0x661CE20", VA = "0x18661DA20")]
	public NPMFMMODMKC(int FFPJHIEILCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x661D890", Offset = "0x661CC90", VA = "0x18661D890", Slot = "7")]
	public void BAMIJHPGHBK(double HHFKHHNHDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x661D9B0", Offset = "0x661CDB0", VA = "0x18661D9B0", Slot = "8")]
	public void KECAPFPCLAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class ONGFKDJONPP : DCDEGEBPMJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long DPBEIPGOMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double GFOPKFHCLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double DDIMCCHOHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double CCIECNFLCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double MPFGOLDMOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double GKNDKBGCHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double OGPILMIPJDC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double KCCLJGCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x555A210", Offset = "0x5559610", VA = "0x18555A210", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double BBIBAANHCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x555A1F0", Offset = "0x55595F0", VA = "0x18555A1F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double MBHPHHGJHII
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x555A1E0", Offset = "0x55595E0", VA = "0x18555A1E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double CDNHGFHLBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x21C6F40", Offset = "0x21C6340", VA = "0x1821C6F40", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x661EA30", Offset = "0x661DE30", VA = "0x18661EA30", Slot = "7")]
	public virtual void BAMIJHPGHBK(double HHFKHHNHDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x661EB50", Offset = "0x661DF50", VA = "0x18661EB50", Slot = "8")]
	public virtual void KECAPFPCLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6608810", Offset = "0x6607C10", VA = "0x186608810")]
	public ONGFKDJONPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class CLJALMBMEBM : ONGFKDJONPP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double LAACBOABDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x555A230", Offset = "0x5559630", VA = "0x18555A230")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x555A280", Offset = "0x5559680", VA = "0x18555A280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x66086A0", Offset = "0x6607AA0", VA = "0x1866086A0", Slot = "7")]
	public override void BAMIJHPGHBK(double HHFKHHNHDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x66087D0", Offset = "0x6607BD0", VA = "0x1866087D0", Slot = "8")]
	public override void KECAPFPCLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6608810", Offset = "0x6607C10", VA = "0x186608810")]
	public CLJALMBMEBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface DCDEGEBPMJF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double CDNHGFHLBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double KCCLJGCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double BBIBAANHCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class MDPIHONJIIF
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface KAAKGOJBBEF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool OPJFHELDCAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LAAAOIHLIFJ();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class LMKHEAOICFN<TPromise, TMainThreadPromise> : KAAKGOJBBEF where TPromise : BCACLFKFPHI where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise KAOFPHMICPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise PCKIHGLOHAK;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise IGJKPIKLMBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x3B6F2E0", Offset = "0x3B6E6E0", VA = "0x183B6F2E0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OPJFHELDCAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3B6F340", Offset = "0x3B6E740", VA = "0x183B6F340", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7A6130", Offset = "0x7A5530", VA = "0x1807A6130")]
		protected LMKHEAOICFN(TPromise KAOFPHMICPN, TMainThreadPromise JIIPKKGMNAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3B6F390", Offset = "0x3B6E790", VA = "0x183B6F390", Slot = "5")]
		public void LAAAOIHLIFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void GNOKDEBNCLD(TPromise KAOFPHMICPN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class EFPIPMBMFFP<T> : LMKHEAOICFN<JMGBCNAMNAH<T>, FPEMLHHDDKL<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x31E0EE0", Offset = "0x31E02E0", VA = "0x1831E0EE0")]
		public EFPIPMBMFFP(JMGBCNAMNAH<T> KAOFPHMICPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x31E0CD0", Offset = "0x31E00D0", VA = "0x1831E0CD0", Slot = "6")]
		protected override void GNOKDEBNCLD(JMGBCNAMNAH<T> KAOFPHMICPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x31E0C70", Offset = "0x31E0070", VA = "0x1831E0C70")]
		[CompilerGenerated]
		private void EKCLFHDPIML(T MNKBHKEBOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x31E0CA0", Offset = "0x31E00A0", VA = "0x1831E0CA0")]
		[CompilerGenerated]
		private void FGHJHKGDKKI(string JKDHCOHJJFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class LECJFNDNFIB : KAAKGOJBBEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action MCLCEMNNOFC;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OPJFHELDCAE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7B8240", Offset = "0x7B7640", VA = "0x1807B8240", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
		public LECJFNDNFIB(Action MCLCEMNNOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB8EA80", Offset = "0xB8DE80", VA = "0x180B8EA80", Slot = "5")]
		public void LAAAOIHLIFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<KAAKGOJBBEF> HPKAGDHPLKH;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2704C60", Offset = "0x2704060", VA = "0x182704C60")]
	public static JMGBCNAMNAH<T> KAAPPLMKNGB<T>(this JMGBCNAMNAH<T> KAOFPHMICPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x661CEA0", Offset = "0x661C2A0", VA = "0x18661CEA0")]
	public static void KAAPPLMKNGB(Action MCLCEMNNOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2704BA0", Offset = "0x2703FA0", VA = "0x182704BA0")]
	private static JMGBCNAMNAH<T> ENDOGGANMAF<T>(JMGBCNAMNAH<T> KAOFPHMICPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x661CC90", Offset = "0x661C090", VA = "0x18661CC90")]
	private static void JJDCMFIHHJC(KAAKGOJBBEF NKEDMHLLGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x661CF40", Offset = "0x661C340", VA = "0x18661CF40")]
	private static void NDOKLFJOKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x661CAB0", Offset = "0x661BEB0", VA = "0x18661CAB0")]
	private static void CCMHJIOGOEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x661CBB0", Offset = "0x661BFB0", VA = "0x18661CBB0")]
	private static void FBFIMDJADME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class DABEOCDKLDB
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct BBMJFEPKEAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> IPNIEDCLALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string DNOMIJHONBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode LFGFANLKJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool OAOJJHJJHNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6607670", Offset = "0x6606A70", VA = "0x186607670")]
		public BBMJFEPKEAL(TaskCompletionSource<Scene> EEDJEJGKNFJ, string DNOMIJHONBC, LoadSceneMode LFGFANLKJDP, bool OAOJJHJJHNM, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct OLALDNAHNLO : IAsyncStateMachine
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
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private NKOLFLIKMKN<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x661E120", Offset = "0x661D520", VA = "0x18661E120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x661E9C0", Offset = "0x661DDC0", VA = "0x18661E9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct BOBDMMMLKNP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6608010", Offset = "0x6607410", VA = "0x186608010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6608330", Offset = "0x6607730", VA = "0x186608330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct LDGBDCIIKMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private BBMJFEPKEAL <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6619C40", Offset = "0x6619040", VA = "0x186619C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6619FF0", Offset = "0x66193F0", VA = "0x186619FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class HIJOCALEAMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FPEMLHHDDKL<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public HIJOCALEAMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6614D80", Offset = "0x6614180", VA = "0x186614D80")]
		internal void OFAPMGJGMKJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct JGJHAGANFME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

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
		private HIJOCALEAMF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x66158B0", Offset = "0x6614CB0", VA = "0x1866158B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6616450", Offset = "0x6615850", VA = "0x186616450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct NKLIICJHGKM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x661D2B0", Offset = "0x661C6B0", VA = "0x18661D2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x661D7C0", Offset = "0x661CBC0", VA = "0x18661D7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct MBEDJCCEPLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x661BEF0", Offset = "0x661B2F0", VA = "0x18661BEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x661CA40", Offset = "0x661BE40", VA = "0x18661CA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class JGLFJDJHAGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public JGLFJDJHAGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6617060", Offset = "0x6616460", VA = "0x186617060")]
		internal bool HDIJPGNHLIF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class DCKBBMPIPGL : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private FLFEOAPLLLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LCADBCNGFBM onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public DCKBBMPIPGL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x660E370", Offset = "0x660D770", VA = "0x18660E370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x660DFE0", Offset = "0x660D3E0", VA = "0x18660DFE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x660DF90", Offset = "0x660D390", VA = "0x18660DF90")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x660E320", Offset = "0x660D720", VA = "0x18660E320", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class CMGBEGOBHCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public FPEMLHHDDKL<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public CMGBEGOBHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6608AC0", Offset = "0x6607EC0", VA = "0x186608AC0")]
		internal bool JBNOCOHPFOG(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6608840", Offset = "0x6607C40", VA = "0x186608840")]
		internal void DFKNBFAAAHP(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class LONIGOKHALP : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private FLFEOAPLLLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public FPEMLHHDDKL<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private CMGBEGOBHCD <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public LONIGOKHALP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x661B790", Offset = "0x661AB90", VA = "0x18661B790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x661BEA0", Offset = "0x661B2A0", VA = "0x18661BEA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> KKMJFNENCPA;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static BCACLFKFPHI KFGHBIOJKBP;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation ICBCIBAKMCK;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BCACLFKFPHI DJKICBDNGLM;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string IJFGDJHCKMK;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority GJMDFHPODDC;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task IDEGDJHHICE;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> JBPLICOPJNA;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<BBMJFEPKEAL> AIBPGECGPGB;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task FLFMDFPIOJN;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool KGDCGPMFIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x660C9E0", Offset = "0x660BDE0", VA = "0x18660C9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool CPMHMGMAJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x660DC10", Offset = "0x660D010", VA = "0x18660DC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool GIKHCMDBMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x660D780", Offset = "0x660CB80", VA = "0x18660D780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool MIJLPFKLFIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x660D020", Offset = "0x660C420", VA = "0x18660D020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> BALGHEPEICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x660D160", Offset = "0x660C560", VA = "0x18660D160")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x660CC00", Offset = "0x660C000", VA = "0x18660CC00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x660D550", Offset = "0x660C950", VA = "0x18660D550")]
	[LHNJPKEFJFF(KMDAJMKLPFP.EnteredEditModeNextFrame, 0)]
	private static void KBIDHAMCLMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x660C680", Offset = "0x660BA80", VA = "0x18660C680")]
	[AsyncStateMachine(typeof(OLALDNAHNLO))]
	public static Task<Scene> AIGPJKDEJCN(string DNOMIJHONBC, LoadSceneMode LFGFANLKJDP = LoadSceneMode.Single, bool OAOJJHJJHNM = false, [Optional] NKOLFLIKMKN<string>.JNCJJIKLGBC JGLNEJEEDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x660D0B0", Offset = "0x660C4B0", VA = "0x18660D0B0")]
	[AsyncStateMachine(typeof(BOBDMMMLKNP))]
	private static Task HEDOANBIIGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x660CE20", Offset = "0x660C220", VA = "0x18660CE20")]
	[AsyncStateMachine(typeof(LDGBDCIIKMM))]
	private static Task EEPPFJIKHFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x660C890", Offset = "0x660BC90", VA = "0x18660C890")]
	[AsyncStateMachine(typeof(JGJHAGANFME))]
	private static Task<Scene> BHCHLJINEGH(string DNOMIJHONBC, LoadSceneMode LFGFANLKJDP, bool OAOJJHJJHNM, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x660D3F0", Offset = "0x660C7F0", VA = "0x18660D3F0")]
	private static void JOJDCOBNHOL(SceneInstance CONPDDCOPOE, LoadSceneMode LFGFANLKJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x660C7D0", Offset = "0x660BBD0", VA = "0x18660C7D0")]
	private static void AJMFOICKMDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x660DAF0", Offset = "0x660CEF0", VA = "0x18660DAF0")]
	[AsyncStateMachine(typeof(NKLIICJHGKM))]
	private static Task<Scene> MOEKCJAOFEE(string DNOMIJHONBC, LoadSceneMode LFGFANLKJDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x660DCB0", Offset = "0x660D0B0", VA = "0x18660DCB0")]
	private static bool NEGBPOAPJNF(string DNOMIJHONBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x660CD10", Offset = "0x660C110", VA = "0x18660CD10")]
	[AsyncStateMachine(typeof(MBEDJCCEPLE))]
	private static Task<Scene> CKOJJAEDICA(NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x660D270", Offset = "0x660C670", VA = "0x18660D270")]
	public static JMGBCNAMNAH<Scene> JEJFNNPEINA(string DNOMIJHONBC, LoadSceneMode LFGFANLKJDP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x660D820", Offset = "0x660CC20", VA = "0x18660D820")]
	public static BCACLFKFPHI MKFLNBBCFIB(string DNOMIJHONBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x660CF90", Offset = "0x660C390", VA = "0x18660CF90")]
	[IteratorStateMachine(typeof(DCKBBMPIPGL))]
	private static IEnumerator<FLFEOAPLLLI> GJKIOLNNJMN(string DNOMIJHONBC, LCADBCNGFBM HPAGJEKMNAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x660CEF0", Offset = "0x660C2F0", VA = "0x18660CEF0")]
	[IteratorStateMachine(typeof(LONIGOKHALP))]
	private static IEnumerator<FLFEOAPLLLI> EKOADIFLBAL(string DNOMIJHONBC, LoadSceneMode LFGFANLKJDP, FPEMLHHDDKL<Scene> HPAGJEKMNAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x660D650", Offset = "0x660CA50", VA = "0x18660D650")]
	public static bool LHEAABCCPLJ([Out] string NFEJFAJGLMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BFJNENALNBA
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6607F00", Offset = "0x6607300", VA = "0x186607F00")]
	public static IDisposable GCHDHJJCFIP(this KBFCHONAOBJ PEHINKLIDNC, float JAPHMJICBGD, Action<float> NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6607F90", Offset = "0x6607390", VA = "0x186607F90")]
	public static IDisposable OOPDHCBNABO(this KBFCHONAOBJ PEHINKLIDNC, Action<float> NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6607E80", Offset = "0x6607280", VA = "0x186607E80")]
	public static IDisposable COKKBJNCMBH(this KBFCHONAOBJ PEHINKLIDNC, Action<float> NCPFGEDHINI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class JGKPAKDCHHJ
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6616E70", Offset = "0x6616270", VA = "0x186616E70")]
	public static IDisposable NJMCPDKGNBN(this MonoBehaviour HBOAILJIBKK, Action NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6616DE0", Offset = "0x66161E0", VA = "0x186616DE0")]
	public static IDisposable NJMCPDKGNBN(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6616C20", Offset = "0x6616020", VA = "0x186616C20")]
	public static IDisposable JPBFJKJIHMJ(this MonoBehaviour HBOAILJIBKK, Action NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6616A00", Offset = "0x6615E00", VA = "0x186616A00")]
	public static IDisposable GOMIOHKPIIK(this MonoBehaviour HBOAILJIBKK, Action NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6616980", Offset = "0x6615D80", VA = "0x186616980")]
	public static IDisposable GOMIOHKPIIK(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6616600", Offset = "0x6615A00", VA = "0x186616600")]
	public static IDisposable EFDEIJJMCBD(this MonoBehaviour HBOAILJIBKK, Action NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6616A80", Offset = "0x6615E80", VA = "0x186616A80")]
	public static IDisposable GPIEBECHJEB(this MonoBehaviour HBOAILJIBKK, Action NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6616BA0", Offset = "0x6615FA0", VA = "0x186616BA0")]
	public static IDisposable JJAHLLFJLLJ(this MonoBehaviour HBOAILJIBKK, Action NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6616FB0", Offset = "0x66163B0", VA = "0x186616FB0")]
	public static IDisposable OJNMPIBKGLL(this MonoBehaviour HBOAILJIBKK, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6616720", Offset = "0x6615B20", VA = "0x186616720")]
	public static IDisposable GJDAOLDIJIB(this MonoBehaviour HBOAILJIBKK, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6616680", Offset = "0x6615A80", VA = "0x186616680")]
	public static IDisposable FBGKBIMLMDO(this MonoBehaviour HBOAILJIBKK, float JAPHMJICBGD, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6616D40", Offset = "0x6616140", VA = "0x186616D40")]
	public static IDisposable NJICMAGDOEA(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x66164C0", Offset = "0x66158C0", VA = "0x1866164C0")]
	public static IDisposable BBPBHFFMGLM(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6616CA0", Offset = "0x66160A0", VA = "0x186616CA0")]
	public static IDisposable NCDNGLNGOKH(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6616840", Offset = "0x6615C40", VA = "0x186616840")]
	public static IDisposable GKBHIKEHANK(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6616560", Offset = "0x6615960", VA = "0x186616560")]
	public static IDisposable BOIFPJJBLFE(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x66168E0", Offset = "0x6615CE0", VA = "0x1866168E0")]
	public static IDisposable GKILAEBEDCN(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6616B00", Offset = "0x6615F00", VA = "0x186616B00")]
	public static IDisposable JCABOANHBHM(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6616F00", Offset = "0x6616300", VA = "0x186616F00")]
	public static IDisposable OENENMGMOEM(this MonoBehaviour HBOAILJIBKK, float JAPHMJICBGD, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class IFMGJOLCDJE
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class KFFPBOLANOB : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private FLFEOAPLLLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public JAAKDEGMLAI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private BGCLEJAPICO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public KFFPBOLANOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x66177A0", Offset = "0x6616BA0", VA = "0x1866177A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6617880", Offset = "0x6616C80", VA = "0x186617880", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class ANKKENNODFM : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private FLFEOAPLLLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public JAAKDEGMLAI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private BGCLEJAPICO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public ANKKENNODFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x66072C0", Offset = "0x66066C0", VA = "0x1866072C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x66073B0", Offset = "0x66067B0", VA = "0x1866073B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6615480", Offset = "0x6614880", VA = "0x186615480")]
	public static DHBMNMGGJAH NJMCPDKGNBN(Action NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6615530", Offset = "0x6614930", VA = "0x186615530")]
	public static DHBMNMGGJAH NJMCPDKGNBN(Behaviour PEHINKLIDNC, Action NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x66155F0", Offset = "0x66149F0", VA = "0x1866155F0")]
	public static DHBMNMGGJAH NJMCPDKGNBN(Behaviour PEHINKLIDNC, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x66153F0", Offset = "0x66147F0", VA = "0x1866153F0")]
	[IteratorStateMachine(typeof(KFFPBOLANOB))]
	private static IEnumerator<FLFEOAPLLLI> AHIDEIBCGJN(JAAKDEGMLAI INJDPFHNFNL, Action NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6615360", Offset = "0x6614760", VA = "0x186615360")]
	[IteratorStateMachine(typeof(ANKKENNODFM))]
	private static IEnumerator<FLFEOAPLLLI> AHIDEIBCGJN(JAAKDEGMLAI INJDPFHNFNL, Action<float> NCPFGEDHINI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class LKBGKHBPHNK : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class LDMEHFMBEFC : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private FLFEOAPLLLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public LKBGKHBPHNK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public LDMEHFMBEFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x661A050", Offset = "0x6619450", VA = "0x18661A050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x661A0E0", Offset = "0x66194E0", VA = "0x18661A0E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly JAAKDEGMLAI EGDEBJAGPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action NAMBCMLCHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool OIHBBHJHEOF;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool MEINDBODKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x79F210", Offset = "0x79E610", VA = "0x18079F210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x661B680", Offset = "0x661AA80", VA = "0x18661B680")]
	public LKBGKHBPHNK(JAAKDEGMLAI EGDEBJAGPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x661B560", Offset = "0x661A960", VA = "0x18661B560")]
	[IteratorStateMachine(typeof(LDMEHFMBEFC))]
	private IEnumerator<FLFEOAPLLLI> BGCCPJHEMNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x661B5E0", Offset = "0x661A9E0", VA = "0x18661B5E0", Slot = "4")]
	public void OnCompleted(Action AOPCEFBGAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
	public void HIJKCFDBHNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class IBEDIEIKCGH
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6615020", Offset = "0x6614420", VA = "0x186615020")]
	public static LKBGKHBPHNK LPPDDHLPDIP(this JAAKDEGMLAI EGDEBJAGPAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class KINEGOBBBNH
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class EBKKBBKLDFL : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private FLFEOAPLLLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public MPJHMBCBFAO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public EBKKBBKLDFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x660EF50", Offset = "0x660E350", VA = "0x18660EF50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x660EFD0", Offset = "0x660E3D0", VA = "0x18660EFD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6617BC0", Offset = "0x6616FC0", VA = "0x186617BC0")]
	public static DHBMNMGGJAH NJMCPDKGNBN(float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6617AB0", Offset = "0x6616EB0", VA = "0x186617AB0")]
	public static DHBMNMGGJAH NJMCPDKGNBN(MonoBehaviour HBOAILJIBKK, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x66178D0", Offset = "0x6616CD0", VA = "0x1866178D0")]
	public static DHBMNMGGJAH AEBCLFFOPDN(MonoBehaviour HBOAILJIBKK, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6617CC0", Offset = "0x66170C0", VA = "0x186617CC0")]
	public static DHBMNMGGJAH OOJCFOHOKIP(KBFCHONAOBJ PEHINKLIDNC, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x66179F0", Offset = "0x6616DF0", VA = "0x1866179F0")]
	private static IEnumerator<FLFEOAPLLLI> AHIDEIBCGJN(MADGOMEGEEG NNGFOJMJBAK, float JAPHMJICBGD, JAAKDEGMLAI INJDPFHNFNL, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6617E60", Offset = "0x6617260", VA = "0x186617E60")]
	private static IEnumerator<FLFEOAPLLLI> POONHOPDFPD(MADGOMEGEEG NNGFOJMJBAK, float JAPHMJICBGD, JAAKDEGMLAI INJDPFHNFNL, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6617DD0", Offset = "0x66171D0", VA = "0x186617DD0")]
	[IteratorStateMachine(typeof(EBKKBBKLDFL))]
	private static IEnumerator<FLFEOAPLLLI> PHPBLPOOKKP(MPJHMBCBFAO JMMKJLDLGAG, float JAPHMJICBGD, JAAKDEGMLAI INJDPFHNFNL, Action<float> NCPFGEDHINI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class OOEIHPMANHO
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class AFNPPLNBGAP : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private FLFEOAPLLLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public JAAKDEGMLAI queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public AFNPPLNBGAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x66058B0", Offset = "0x6604CB0", VA = "0x1866058B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6605970", Offset = "0x6604D70", VA = "0x186605970", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x661ECB0", Offset = "0x661E0B0", VA = "0x18661ECB0")]
	[IteratorStateMachine(typeof(AFNPPLNBGAP))]
	private static IEnumerator<FLFEOAPLLLI> PLNEMPFONPA(JAAKDEGMLAI EGDEBJAGPAI, Func<bool> BMPNDHLKPNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x661EB90", Offset = "0x661DF90", VA = "0x18661EB90")]
	public static DHBMNMGGJAH NGPIKJMCBKJ(this MonoBehaviour HBOAILJIBKK, Func<bool> BMPNDHLKPNC, JAAKDEGMLAI EGDEBJAGPAI = JAAKDEGMLAI.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class PECDBGPNCFK
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class ECNKEMGGBIA : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private FLFEOAPLLLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public JAAKDEGMLAI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public ECNKEMGGBIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x660F020", Offset = "0x660E420", VA = "0x18660F020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x660F090", Offset = "0x660E490", VA = "0x18660F090", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class GFFKHECJKIG : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private FLFEOAPLLLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public JAAKDEGMLAI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private FLFEOAPLLLI <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public GFFKHECJKIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6614570", Offset = "0x6613970", VA = "0x186614570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6614600", Offset = "0x6613A00", VA = "0x186614600", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x661F440", Offset = "0x661E840", VA = "0x18661F440")]
	[IteratorStateMachine(typeof(ECNKEMGGBIA))]
	private static IEnumerator<FLFEOAPLLLI> BGCCPJHEMNN(float EDBFKNKJGAL, JAAKDEGMLAI INJDPFHNFNL, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x661FBF0", Offset = "0x661EFF0", VA = "0x18661FBF0")]
	[IteratorStateMachine(typeof(GFFKHECJKIG))]
	private static IEnumerator<FLFEOAPLLLI> PKGFGDNAKIK(float EDBFKNKJGAL, JAAKDEGMLAI INJDPFHNFNL, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x661F8D0", Offset = "0x661ECD0", VA = "0x18661F8D0")]
	public static IDisposable KNNDCGAJGJB(this MonoBehaviour HBOAILJIBKK, float EDBFKNKJGAL, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x661F9F0", Offset = "0x661EDF0", VA = "0x18661F9F0")]
	public static DHBMNMGGJAH MGGAHCOAHCN(this MonoBehaviour HBOAILJIBKK, float EDBFKNKJGAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x661F7A0", Offset = "0x661EBA0", VA = "0x18661F7A0")]
	public static DHBMNMGGJAH KNNDCGAJGJB(this MonoBehaviour HBOAILJIBKK, float EDBFKNKJGAL, JAAKDEGMLAI INJDPFHNFNL, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x661F780", Offset = "0x661EB80", VA = "0x18661F780")]
	public static DHBMNMGGJAH KIHMNKIKGPO(this MonoBehaviour HBOAILJIBKK, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x661F750", Offset = "0x661EB50", VA = "0x18661F750")]
	public static DHBMNMGGJAH IMEKHOAECDM(this MonoBehaviour HBOAILJIBKK, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x661FAB0", Offset = "0x661EEB0", VA = "0x18661FAB0")]
	public static DHBMNMGGJAH OCELLGDMCBD(this MonoBehaviour HBOAILJIBKK, Action BINBFFLGBGL, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x661FB90", Offset = "0x661EF90", VA = "0x18661FB90")]
	public static DHBMNMGGJAH ONFANNGENML(this MonoBehaviour HBOAILJIBKK, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x661FBC0", Offset = "0x661EFC0", VA = "0x18661FBC0")]
	public static DHBMNMGGJAH PEPJINMJDAA(this MonoBehaviour HBOAILJIBKK, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x661F680", Offset = "0x661EA80", VA = "0x18661F680")]
	private static DHBMNMGGJAH ENMHAFBIFGG(MonoBehaviour HBOAILJIBKK, JAAKDEGMLAI EGDEBJAGPAI, Action BINBFFLGBGL, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x661F370", Offset = "0x661E770", VA = "0x18661F370")]
	public static DHBMNMGGJAH APNADLHCCFC(this MonoBehaviour HBOAILJIBKK, float BADOEALKKEF, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x661F4E0", Offset = "0x661E8E0", VA = "0x18661F4E0")]
	public static DHBMNMGGJAH CPHNMCJDNBO(this MonoBehaviour HBOAILJIBKK, float BADOEALKKEF, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x661F5B0", Offset = "0x661E9B0", VA = "0x18661F5B0")]
	public static DHBMNMGGJAH EIJIEJGJCLD(this MonoBehaviour HBOAILJIBKK, float BADOEALKKEF, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x661F2A0", Offset = "0x661E6A0", VA = "0x18661F2A0")]
	public static DHBMNMGGJAH ALHFNBNDHID(this MonoBehaviour HBOAILJIBKK, float BADOEALKKEF, Action BINBFFLGBGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class DLOKFEDAFJO : GNMIFLHNNDO, IEnumerable<GNMIFLHNNDO>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<GNMIFLHNNDO> EJHHGLOBANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool MCPIFGDFGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action CIMMOFGCHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool HFDFFCDFFOC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool GEBLCGNNCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x660E600", Offset = "0x660DA00", VA = "0x18660E600", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BIJFIAFCNIC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x660EE10", Offset = "0x660E210", VA = "0x18660EE10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x660ED70", Offset = "0x660E170", VA = "0x18660ED70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x660EEB0", Offset = "0x660E2B0", VA = "0x18660EEB0")]
	public DLOKFEDAFJO([Optional] Action CIMMOFGCHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x660E740", Offset = "0x660DB40", VA = "0x18660E740")]
	public void FLOHBAGDPJC(GNMIFLHNNDO OKNALOCEHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x660E8F0", Offset = "0x660DCF0", VA = "0x18660E8F0")]
	private void IBBBFPFOBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x660EA50", Offset = "0x660DE50", VA = "0x18660EA50", Slot = "7")]
	public bool NHOOEDMOMNO(bool DBCFABNBIEE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x660EA60", Offset = "0x660DE60", VA = "0x18660EA60", Slot = "8")]
	public bool NHOOEDMOMNO(Action MCLCEMNNOFC, bool DBCFABNBIEE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x660E870", Offset = "0x660DC70", VA = "0x18660E870", Slot = "9")]
	public IEnumerator<GNMIFLHNNDO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x660E870", Offset = "0x660DC70", VA = "0x18660E870", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class AFDANOMBAJD : ANGAKDGHCNK
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class LHDNCOLMKOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public AFDANOMBAJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public LHDNCOLMKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6614B50", Offset = "0x6613F50", VA = "0x186614B50")]
		internal void IAKFCHDIILJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class HEGCHEHJDME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public AFDANOMBAJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public HEGCHEHJDME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6614B50", Offset = "0x6613F50", VA = "0x186614B50")]
		internal void MGALHLFNEEB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float GEHIKLNKEEA;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x66057B0", Offset = "0x6604BB0", VA = "0x1866057B0")]
	public AFDANOMBAJD(Behaviour PEHINKLIDNC, float GEHIKLNKEEA, [Optional] Action CIMMOFGCHIL, [Optional] PIEDMAMFPDI KHBNDDBJHNK, [Optional] MADGOMEGEEG NNGFOJMJBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x66056A0", Offset = "0x6604AA0", VA = "0x1866056A0", Slot = "9")]
	protected override bool LIGHEHLPLHN(Action MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6605590", Offset = "0x6604990", VA = "0x186605590", Slot = "10")]
	protected override bool LFFOEIAEMMF(Action MCLCEMNNOFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface GNMIFLHNNDO
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool GEBLCGNNCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action BIJFIAFCNIC;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NHOOEDMOMNO(bool DBCFABNBIEE = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NHOOEDMOMNO(Action MCLCEMNNOFC, bool DBCFABNBIEE = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class ANGAKDGHCNK : GNMIFLHNNDO
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class PJAFJMGJAJP : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private FLFEOAPLLLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public ANGAKDGHCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public PJAFJMGJAJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x661FD10", Offset = "0x661F110", VA = "0x18661FD10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x661FDE0", Offset = "0x661F1E0", VA = "0x18661FDE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour PEHINKLIDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action CIMMOFGCHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private JJNFBJKAOML PHLBEPKBJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly PIEDMAMFPDI KHBNDDBJHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly MADGOMEGEEG NNGFOJMJBAK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool GEBLCGNNCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xF13F60", Offset = "0xF13360", VA = "0x180F13F60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BIJFIAFCNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6607120", Offset = "0x6606520", VA = "0x186607120", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6607080", Offset = "0x6606480", VA = "0x186607080", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x66071C0", Offset = "0x66065C0", VA = "0x1866071C0")]
	protected ANGAKDGHCNK(Behaviour PEHINKLIDNC, [Optional] Action CIMMOFGCHIL, [Optional] PIEDMAMFPDI KHBNDDBJHNK, [Optional] MADGOMEGEEG NNGFOJMJBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6607020", Offset = "0x6606420", VA = "0x186607020", Slot = "7")]
	public bool NHOOEDMOMNO(bool DBCFABNBIEE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6606FC0", Offset = "0x66063C0", VA = "0x186606FC0", Slot = "8")]
	public bool NHOOEDMOMNO(Action MCLCEMNNOFC, bool DBCFABNBIEE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool LIGHEHLPLHN(Action MCLCEMNNOFC);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool LFFOEIAEMMF(Action MCLCEMNNOFC);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6606CE0", Offset = "0x66060E0", VA = "0x186606CE0")]
	protected void INLKFIJHPMD(Action MCLCEMNNOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6606D00", Offset = "0x6606100", VA = "0x186606D00")]
	protected BCACLFKFPHI LEPEHGJMHAI(float DAMPBKHPLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6606F40", Offset = "0x6606340", VA = "0x186606F40")]
	private void NFLEEJLHLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6606C50", Offset = "0x6606050", VA = "0x186606C50")]
	[IteratorStateMachine(typeof(PJAFJMGJAJP))]
	private IEnumerator<FLFEOAPLLLI> FHAFBFIMLPB(float DAMPBKHPLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6606C10", Offset = "0x6606010", VA = "0x186606C10")]
	[CompilerGenerated]
	private void ACBCCNIFEBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class KPCEBCHJAOJ : ANGAKDGHCNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float EADNINCLJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int NAFFAELHMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float JIFPBDINPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] ECLFBEFDPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int KCEDPOPABAC;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6619AA0", Offset = "0x6618EA0", VA = "0x186619AA0")]
	public KPCEBCHJAOJ(Behaviour PEHINKLIDNC, float LDENLCNIOFF, int NAFFAELHMJA, [Optional] Action CIMMOFGCHIL, float JIFPBDINPNL = 0f, [Optional] PIEDMAMFPDI KHBNDDBJHNK, [Optional] MADGOMEGEEG NNGFOJMJBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "9")]
	protected override bool LIGHEHLPLHN(Action MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6619820", Offset = "0x6618C20", VA = "0x186619820", Slot = "10")]
	protected override bool LFFOEIAEMMF(Action MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6619A20", Offset = "0x6618E20", VA = "0x186619A20")]
	private void OKBFPDKIKPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class IAAHAIFFJKK : ANGAKDGHCNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float GEHIKLNKEEA;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x66057B0", Offset = "0x6604BB0", VA = "0x1866057B0")]
	public IAAHAIFFJKK(Behaviour PEHINKLIDNC, float GEHIKLNKEEA, [Optional] Action CIMMOFGCHIL, [Optional] PIEDMAMFPDI KHBNDDBJHNK, [Optional] MADGOMEGEEG NNGFOJMJBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "9")]
	protected override bool LIGHEHLPLHN(Action MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6614FE0", Offset = "0x66143E0", VA = "0x186614FE0", Slot = "10")]
	protected override bool LFFOEIAEMMF(Action MCLCEMNNOFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class GCJHGLLABCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class OFGBBGLOKAM : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private FLFEOAPLLLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public OFGBBGLOKAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x66085E0", Offset = "0x66079E0", VA = "0x1866085E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x661DCD0", Offset = "0x661D0D0", VA = "0x18661DCD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private DHBMNMGGJAH CEHBMIADGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private KBFCHONAOBJ PEHINKLIDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> CNDJNLPMDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private JAAKDEGMLAI EGDEBJAGPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float KIGFBLOCPCI;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x66126E0", Offset = "0x6611AE0", VA = "0x1866126E0")]
	public GCJHGLLABCD(KBFCHONAOBJ PEHINKLIDNC, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6612360", Offset = "0x6611760", VA = "0x186612360")]
	private void FOCGGNDJFBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6612500", Offset = "0x6611900", VA = "0x186612500")]
	private void MAKINGIJNED(string JKDHCOHJJFE, Action MKHDPFOONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6612660", Offset = "0x6611A60", VA = "0x186612660")]
	[IteratorStateMachine(typeof(OFGBBGLOKAM))]
	private IEnumerator<FLFEOAPLLLI> PMFHLJMJFII(Action MKHDPFOONKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6612300", Offset = "0x6611700", VA = "0x186612300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6612150", Offset = "0x6611550", VA = "0x186612150")]
	[CompilerGenerated]
	private void BHIGINNGKDI(string KMJIPKGNLDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class KKGALODEKMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class CJGMMNMCJKB : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private FLFEOAPLLLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public CJGMMNMCJKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x66085E0", Offset = "0x66079E0", VA = "0x1866085E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6608650", Offset = "0x6607A50", VA = "0x186608650", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private DHBMNMGGJAH CEHBMIADGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour HBOAILJIBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action NCPFGEDHINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> CNDJNLPMDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private JAAKDEGMLAI EGDEBJAGPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float KIGFBLOCPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool ICNDMMFENED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly PIEDMAMFPDI KHBNDDBJHNK;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6618AD0", Offset = "0x6617ED0", VA = "0x186618AD0")]
	public KKGALODEKMA(MonoBehaviour HBOAILJIBKK, Action NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6618CC0", Offset = "0x66180C0", VA = "0x186618CC0")]
	public KKGALODEKMA(MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6618F00", Offset = "0x6618300", VA = "0x186618F00")]
	public KKGALODEKMA(MonoBehaviour HBOAILJIBKK, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x18E92A0", Offset = "0x18E86A0", VA = "0x1818E92A0")]
	private KKGALODEKMA(PIEDMAMFPDI KHBNDDBJHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6617F50", Offset = "0x6617350", VA = "0x186617F50")]
	internal static KKGALODEKMA COEMMPGLGFF(MonoBehaviour HBOAILJIBKK, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6618850", Offset = "0x6617C50", VA = "0x186618850")]
	private void NJMCPDKGNBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6618450", Offset = "0x6617850", VA = "0x186618450")]
	private void JIMENIFIFDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x66182A0", Offset = "0x66176A0", VA = "0x1866182A0")]
	private void FOCGGNDJFBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6618080", Offset = "0x6617480", VA = "0x186618080")]
	private void DFOJLAFAKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6618690", Offset = "0x6617A90", VA = "0x186618690")]
	private void MAKINGIJNED(string JKDHCOHJJFE, Action MKHDPFOONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6618A50", Offset = "0x6617E50", VA = "0x186618A50")]
	[IteratorStateMachine(typeof(CJGMMNMCJKB))]
	private IEnumerator<FLFEOAPLLLI> PMFHLJMJFII(Action MKHDPFOONKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6618240", Offset = "0x6617640", VA = "0x186618240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x66187C0", Offset = "0x6617BC0", VA = "0x1866187C0")]
	[CompilerGenerated]
	private void MPIHFPCLPLN(string KMJIPKGNLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x66189C0", Offset = "0x6617DC0", VA = "0x1866189C0")]
	[CompilerGenerated]
	private void OEDJMGFOCPJ(string KMJIPKGNLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6617EC0", Offset = "0x66172C0", VA = "0x186617EC0")]
	[CompilerGenerated]
	private void ACMCNFHJMIH(string KMJIPKGNLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6618600", Offset = "0x6617A00", VA = "0x186618600")]
	[CompilerGenerated]
	private void LCPECGAPOFI(string KMJIPKGNLDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum FFLPGPJCNNM : byte
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
internal sealed class IMNMFMEOJGK : MADGOMEGEEG
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float PMANHGKMGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6615790", Offset = "0x6614B90", VA = "0x186615790", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float EKJJKNJAKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6615710", Offset = "0x6614B10", VA = "0x186615710", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double OAMPGJAMHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x66157A0", Offset = "0x6614BA0", VA = "0x1866157A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6615720", Offset = "0x6614B20", VA = "0x186615720")]
	[NEHHKLCIMGL(OJLOCLENGNC.None)]
	private static void EKLFLINKKJI(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	[Preserve]
	internal IMNMFMEOJGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface GJCNFHEDFCN
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHBEGKMADDL(string OMHHPMIDNAN);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIMOKJPEELO();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface EEEMNJCOABC
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool MANBOABLAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool PMBPGIOGIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class JLPKKIGBDOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public EPGMPCNGNJJ KLGCHJFMJLL;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int MEJJBNBBHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x79C180", Offset = "0x79B580", VA = "0x18079C180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCF0", Offset = "0x7AB0F0", VA = "0x1807ABCF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6617380", Offset = "0x6616780", VA = "0x186617380")]
	public static FLFEOAPLLLI OLFILPFAIHE(IEnumerator<FLFEOAPLLLI> EECJCDGPHNK, AJNLPKEJBFG LBNBPFBOKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x66174E0", Offset = "0x66168E0", VA = "0x1866174E0")]
	public FLFEOAPLLLI OLFILPFAIHE(AJNLPKEJBFG[] DNPOMLJGMIN, IEnumerator<FLFEOAPLLLI>[] PCFOEENOGBI, FLFEOAPLLLI[] FBBFPFINPMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6617210", Offset = "0x6616610", VA = "0x186617210")]
	public void EPGBOBHHKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x66170D0", Offset = "0x66164D0", VA = "0x1866170D0")]
	public void BGMOLCKEKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6617240", Offset = "0x6616640", VA = "0x186617240")]
	public void JDNGNEMENJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6617210", Offset = "0x6616610", VA = "0x186617210")]
	public void GFHNNFNCFKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public JLPKKIGBDOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class EPGMPCNGNJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct JJKCOBOKOGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public JLPKKIGBDOF DJNFLEJGKCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public KBFCHONAOBJ LOBONAHPJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public AJNLPKEJBFG NGBICJALJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<FLFEOAPLLLI> LNMEBCFHPJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public FLFEOAPLLLI FINPMLEONLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public FFLPGPJCNNM AKNOIEADDPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct JKEJENHHKAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public JAAKDEGMLAI NLIGGEDIOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<JJKCOBOKOGJ> ANLKMOBBMDK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class BCHHDINLHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AJNLPKEJBFG promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public EPGMPCNGNJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public KBFCHONAOBJ context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public JLPKKIGBDOF routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public FFLPGPJCNNM coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public FLFEOAPLLLI currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<FLFEOAPLLLI> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public BCHHDINLHHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x66076D0", Offset = "0x6606AD0", VA = "0x1866076D0")]
		internal void BCCDPGDDPOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class HDFNLKAMPNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public JLPKKIGBDOF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public EPGMPCNGNJJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public HDFNLKAMPNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6614B10", Offset = "0x6613F10", VA = "0x186614B10")]
		internal void IBCJAKKKLIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class JLCNIALHDBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public JLPKKIGBDOF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public EPGMPCNGNJJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public JLCNIALHDBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6617090", Offset = "0x6616490", VA = "0x186617090")]
		internal void DLLCAGGEHNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class FBHDGDOJFBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public JLPKKIGBDOF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public EPGMPCNGNJJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public FBHDGDOJFBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6611EC0", Offset = "0x66112C0", VA = "0x186611EC0")]
		internal void IODAAJEACFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const FFLPGPJCNNM JFCLLIIMJBN = FFLPGPJCNNM.Cancelled | FFLPGPJCNNM.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly JAAKDEGMLAI EGDEBJAGPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] PHNMKHKLNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<FFLPGPJCNNM> DINJLANCOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> EHANELDPOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> MODEIHHOIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> DNLMMNGAOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> BHMAFPKIEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> GJLPLBLBJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> IBFKBFJMHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private JLPKKIGBDOF[] KEGINKMNNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private AJNLPKEJBFG[] DNPOMLJGMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private KBFCHONAOBJ[] OPGIMFJCDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<FLFEOAPLLLI>[] MJNEHOGGDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private FLFEOAPLLLI[] HGEMABOFCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int NDIBIJALMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int NOOJMJOLDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int GJODBLAILPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float LBIKMLOFMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private OPLIBHGPFMI FOMLILCHCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle EEFLFKKDIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<JLPKKIGBDOF> BOHJNPGALPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool DALIIDPFBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> CLPPJGMDKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> ICIJGHJCKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool DPEKFEGDLJG;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public JKEJENHHKAP[] DEJDCFJNMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x90A130", Offset = "0x909530", VA = "0x18090A130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6610600", Offset = "0x660FA00", VA = "0x186610600")]
	private static int GCLMFAJMPAA(JAAKDEGMLAI EGDEBJAGPAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6611870", Offset = "0x6610C70", VA = "0x186611870")]
	public EPGMPCNGNJJ(JAAKDEGMLAI EGDEBJAGPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x66100B0", Offset = "0x660F4B0", VA = "0x1866100B0")]
	private void ENCGCNOGILL(int NKIOOGDFCFG, int KFJGLCHFKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x660FAA0", Offset = "0x660EEA0", VA = "0x18660FAA0")]
	public void BAMDELHOMAK(KBFCHONAOBJ PEHINKLIDNC, FLFEOAPLLLI IPAMDAPHCPI, IEnumerator<FLFEOAPLLLI> EECJCDGPHNK, AJNLPKEJBFG LBNBPFBOKOC, [Optional] JLPKKIGBDOF CFPNCHGIMAL, FFLPGPJCNNM HFKFBFLPKHP = FFLPGPJCNNM.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6610F30", Offset = "0x6610330", VA = "0x186610F30")]
	public void MJCHOKMCNEG(IEnumerable<JJKCOBOKOGJ> NJFIDJNHNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x660F5D0", Offset = "0x660E9D0", VA = "0x18660F5D0")]
	private JJKCOBOKOGJ ANGKECELOGF(int GOGPMIGNNJO)
	{
		return default(JJKCOBOKOGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6610290", Offset = "0x660F690", VA = "0x186610290")]
	private void FPECCFPHHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2510A10", Offset = "0x250FE10", VA = "0x182510A10")]
	private static void NOHLFNLJEGE<T>(int GOGPMIGNNJO, T[] CEOJJFFEJEJ, int BFFGCOIILMK, [Optional] T FPEFCBHJANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2510A60", Offset = "0x250FE60", VA = "0x182510A60")]
	private static void NOHLFNLJEGE<T>(int GOGPMIGNNJO, NativeArray<T> CEOJJFFEJEJ, int BFFGCOIILMK, [Optional] T FPEFCBHJANN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6610990", Offset = "0x660FD90", VA = "0x186610990")]
	private void MBKJKNKDLCB(IEnumerable<JJKCOBOKOGJ> NJFIDJNHNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x660F510", Offset = "0x660E910", VA = "0x18660F510")]
	private void AFNEGHEHOKK(JJKCOBOKOGJ DLBJCDPBKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x660FC20", Offset = "0x660F020", VA = "0x18660FC20")]
	private ADFLEALPBDI BCLBINLIKFP(int EBFGGENHCLB)
	{
		return default(ADFLEALPBDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6610D30", Offset = "0x6610130", VA = "0x186610D30")]
	public void MEGHJAJMPGP(float DNHAFMNPMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6610890", Offset = "0x660FC90", VA = "0x186610890")]
	private void GNDFHPENLLC(Action MAGGDEMNFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6610910", Offset = "0x660FD10", VA = "0x186610910")]
	private void JFOJLHMKIDJ(Action MAGGDEMNFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6611170", Offset = "0x6610570", VA = "0x186611170")]
	public void PCIKFEJODPO(float DNHAFMNPMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x660FE80", Offset = "0x660F280", VA = "0x18660FE80")]
	public void CHHCLLKKAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6610630", Offset = "0x660FA30", VA = "0x186610630")]
	public void GFHNNFNCFKG(JLPKKIGBDOF JMMKJLDLGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x660FF80", Offset = "0x660F380", VA = "0x18660FF80")]
	public void CPHIPFMNBCB(JLPKKIGBDOF JMMKJLDLGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6610760", Offset = "0x660FB60", VA = "0x186610760")]
	public void GICBAMPJINC(JLPKKIGBDOF JMMKJLDLGAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class EIBLEBIKNMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly EIBLEBIKNMN FEAMHHDKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action NJNIBIJAKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool APMGFBPMLGF;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	public EIBLEBIKNMN(Action NJNIBIJAKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1E60", Offset = "0x5FF1260", VA = "0x185FF1E60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface FHHKNIJLLHO<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T NAJOFLHMBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PGGAJFOPGNC(UnityEngine.Object PEHINKLIDNC, Action<T> BKMLCGFGCLC);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface FOFJHDBDGMD<T> : FHHKNIJLLHO<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T NAJOFLHMBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class KNINKFALEBP<T> : FOFJHDBDGMD<T>, FHHKNIJLLHO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class CDEMFONCFDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public KNINKFALEBP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public IFEOPNGOGPP<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public CDEMFONCFDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4870630", Offset = "0x486FA30", VA = "0x184870630")]
		internal void OBNAFMAGBEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject KACJHCPEBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<IFEOPNGOGPP<UnityEngine.Object, Action<T>>> ANHJLDDJJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T LJGEFFJMDPF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T NAJOFLHMBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x80D7C0", Offset = "0x80CBC0", VA = "0x18080D7C0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3A9B630", Offset = "0x3A9AA30", VA = "0x183A9B630", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B4E0", Offset = "0x3A9A8E0", VA = "0x183A9B4E0")]
	private static bool LFFDJLGACMI(T MAGGDEMNFDG, T LFCFPOEDJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B9D0", Offset = "0x3A9ADD0", VA = "0x183A9B9D0")]
	public KNINKFALEBP(T MFBCPDOOPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B6B0", Offset = "0x3A9AAB0", VA = "0x183A9B6B0", Slot = "6")]
	public IDisposable PGGAJFOPGNC(UnityEngine.Object PEHINKLIDNC, Action<T> BKMLCGFGCLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A9AE50", Offset = "0x3A9A250", VA = "0x183A9AE50")]
	private void ENIBIFCEHKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class ECOHOGFEKJN : AMCJKLNPAKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly PIEDMAMFPDI KHBNDDBJHNK;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x660F0E0", Offset = "0x660E4E0", VA = "0x18660F0E0")]
	[NEHHKLCIMGL(OJLOCLENGNC.None)]
	private static void EKLFLINKKJI(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	[Preserve]
	internal ECOHOGFEKJN([CNGDHLLDFHE(null)] PIEDMAMFPDI KHBNDDBJHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x660F150", Offset = "0x660E550", VA = "0x18660F150", Slot = "4")]
	public IDisposable FBGKBIMLMDO(float JAPHMJICBGD, Action<float> DBIEPHLOFKD, bool ICNDMMFENED = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class AMAKEDNGPIE : LJIHGBAMIMD, PIEDMAMFPDI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private EPGMPCNGNJJ[] MGPGGGCCMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private GJCNFHEDFCN JNFCOKDFKCA;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6606080", Offset = "0x6605480", VA = "0x186606080")]
	[NEHHKLCIMGL(OJLOCLENGNC.None)]
	private static void EKLFLINKKJI(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6606A20", Offset = "0x6605E20", VA = "0x186606A20")]
	[Preserve]
	public AMAKEDNGPIE([CNGDHLLDFHE(null)] NHFHGODLONK BENCDGNGKKH, [CNGDHLLDFHE(null)] MADGOMEGEEG NNGFOJMJBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x66063A0", Offset = "0x66057A0", VA = "0x1866063A0", Slot = "16")]
	public override DHBMNMGGJAH HPADGCLPGEG(KBFCHONAOBJ PEHINKLIDNC, IEnumerator<FLFEOAPLLLI> DOIMDGEJOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6606760", Offset = "0x6605B60", VA = "0x186606760", Slot = "17")]
	public override void KECAPFPCLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6605DF0", Offset = "0x66051F0", VA = "0x186605DF0", Slot = "19")]
	public override void DACHGFOODGD(JAAKDEGMLAI EGDEBJAGPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x66065F0", Offset = "0x66059F0", VA = "0x1866065F0", Slot = "18")]
	protected override void JPBFJKJIHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x66069F0", Offset = "0x6605DF0", VA = "0x1866069F0")]
	private EPGMPCNGNJJ NLMNJIDKAOL(JAAKDEGMLAI ADAMDPHPFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x66060F0", Offset = "0x66054F0", VA = "0x1866060F0", Slot = "20")]
	internal override ADJEEMLDENB FJOOJOGFNFE(IEnumerator<FLFEOAPLLLI> DOIMDGEJOJE, Behaviour PEHINKLIDNC, AJNLPKEJBFG LBNBPFBOKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6606320", Offset = "0x6605720", VA = "0x186606320", Slot = "21")]
	internal override GFALIBHBCAI GFBNMDIKDCE(JAAKDEGMLAI INJDPFHNFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x66064D0", Offset = "0x66058D0", VA = "0x1866064D0")]
	private void JJFHIANLILL(EPGMPCNGNJJ BMCMGEEPMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6606020", Offset = "0x6605420", VA = "0x186606020", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct OPLIBHGPFMI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float EADDNKPBDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int HLOHFEBGIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> OOPGOFPKGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> LEPLCMCKCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> MOMBJOPPGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<FFLPGPJCNNM> GKIABLMGIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> HLBHNBLBJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> BHMAFPKIEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> MODEIHHOIHN;

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x661F210", Offset = "0x661E610", VA = "0x18661F210")]
	public static OPLIBHGPFMI NDFPICIGPEG(int BDOGNHJHDIJ, float DNHAFMNPMOH, NativeArray<FFLPGPJCNNM> HNBGAHELEPB, NativeArray<float> DFINEACEKEB, NativeArray<int> BDJAKHOHKOF, NativeArray<int> AKKODBENNPM, NativeArray<int> IGFLHEOAHLM, NativeArray<int> LEPLCMCKCJE, NativeArray<int> MOMBJOPPGKH)
	{
		return default(OPLIBHGPFMI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x661F0F0", Offset = "0x661E4F0", VA = "0x18661F0F0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x661F1D0", Offset = "0x661E5D0", VA = "0x18661F1D0")]
	private bool HIMMLKGPFLG(int OJANCMLFDOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x661F270", Offset = "0x661E670", VA = "0x18661F270")]
	private void OLNJBJAKMBG(NativeArray<int> LDHKIFPGEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x661ED40", Offset = "0x661E140", VA = "0x18661ED40")]
	private int BIJGCAALGBF(int DJGEFFODPCM, int PAMFPLOLMDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x661EDE0", Offset = "0x661E1E0", VA = "0x18661EDE0")]
	private void CDEPLCBLNGO(NativeArray<int> LDHKIFPGEBO, int BHOICFNKGLF, int FEDGKNJBNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x661EEB0", Offset = "0x661E2B0", VA = "0x18661EEB0")]
	private void DEOJPIJLDKG(NativeArray<int> LDHKIFPGEBO, int LPHDBOOKLAD, int JAFPIBKADOM, int PJCHNGMBPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class LJIHGBAMIMD : PIEDMAMFPDI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly NHFHGODLONK BENCDGNGKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly MADGOMEGEEG NNGFOJMJBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private GFALIBHBCAI[] FDOPLMBLAFK;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static PIEDMAMFPDI MEGHANKAOBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x661AB20", Offset = "0x6619F20", VA = "0x18661AB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool FEJBNDKBHDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B8240", Offset = "0x7B7640", VA = "0x1807B8240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public JAAKDEGMLAI MFLABAGBJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x79C180", Offset = "0x79B580", VA = "0x18079C180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JAAKDEGMLAI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCF0", Offset = "0x7AB0F0", VA = "0x1807ABCF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MADGOMEGEEG MEPNGHMNBGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public FLFEOAPLLLI LDCPGDFGDHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x661A370", Offset = "0x6619770", VA = "0x18661A370")]
	public static DHBMNMGGJAH AHIAMNLJLIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x661B070", Offset = "0x661A470", VA = "0x18661B070")]
	[Preserve]
	protected LJIHGBAMIMD([CNGDHLLDFHE(null)] NHFHGODLONK BENCDGNGKKH, [CNGDHLLDFHE(null)] MADGOMEGEEG NNGFOJMJBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x661AE60", Offset = "0x661A260", VA = "0x18661AE60", Slot = "6")]
	public DHBMNMGGJAH OLPPMELFJKG(IEnumerator<FLFEOAPLLLI> DOIMDGEJOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x661AE70", Offset = "0x661A270", VA = "0x18661AE70", Slot = "7")]
	public DHBMNMGGJAH OLPPMELFJKG(Behaviour PEHINKLIDNC, IEnumerator<FLFEOAPLLLI> DOIMDGEJOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract DHBMNMGGJAH HPADGCLPGEG(KBFCHONAOBJ PEHINKLIDNC, IEnumerator<FLFEOAPLLLI> DOIMDGEJOJE);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x661AC30", Offset = "0x661A030", VA = "0x18661AC30", Slot = "17")]
	public virtual void KECAPFPCLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x661A130", Offset = "0x6619530", VA = "0x18661A130", Slot = "9")]
	public void AHFEEIEDIPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x661AC10", Offset = "0x661A010", VA = "0x18661AC10", Slot = "18")]
	protected virtual void JPBFJKJIHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x661ABF0", Offset = "0x6619FF0", VA = "0x18661ABF0")]
	private void IEFDEEEHDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x661A650", Offset = "0x6619A50", VA = "0x18661A650")]
	private void CCGBENBCALH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x661ABD0", Offset = "0x6619FD0", VA = "0x18661ABD0")]
	private void GOMIOHKPIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x661AB00", Offset = "0x6619F00", VA = "0x18661AB00")]
	private void EFDEIJJMCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x661A5D0", Offset = "0x66199D0", VA = "0x18661A5D0")]
	private void BDKFPKCIBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x661AAE0", Offset = "0x6619EE0", VA = "0x18661AAE0")]
	private void EADCJEDCIPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x661A700", Offset = "0x6619B00", VA = "0x18661A700")]
	private void DCJFFLDDHMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x661A670", Offset = "0x6619A70", VA = "0x18661A670", Slot = "19")]
	public virtual void DACHGFOODGD(JAAKDEGMLAI EGDEBJAGPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x661A400", Offset = "0x6619800", VA = "0x18661A400")]
	private void AKPBAALLIFM(GFALIBHBCAI BMCMGEEPMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1C75F20", Offset = "0x1C75320", VA = "0x181C75F20")]
	private GFALIBHBCAI NFBLIJBCNNM(JAAKDEGMLAI ADAMDPHPFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract ADJEEMLDENB FJOOJOGFNFE(IEnumerator<FLFEOAPLLLI> DOIMDGEJOJE, Behaviour HBOAILJIBKK, AJNLPKEJBFG JPPMKLCEANC);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract GFALIBHBCAI GFBNMDIKDCE(JAAKDEGMLAI EGDEBJAGPAI);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x661A720", Offset = "0x6619B20", VA = "0x18661A720", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x661A5F0", Offset = "0x66199F0", VA = "0x18661A5F0", Slot = "12")]
	public FLFEOAPLLLI BFMCNOEOKJE(JAAKDEGMLAI INJDPFHNFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x661ADD0", Offset = "0x661A1D0", VA = "0x18661ADD0", Slot = "13")]
	public FLFEOAPLLLI MGHKGOFFNHB(float EDBFKNKJGAL, JAAKDEGMLAI INJDPFHNFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x661AB70", Offset = "0x6619F70", VA = "0x18661AB70", Slot = "14")]
	public FLFEOAPLLLI GMPHONBNBNJ(Func<bool> BMPNDHLKPNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class ADJEEMLDENB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly AJNLPKEJBFG LBNBPFBOKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly EEEMNJCOABC PEHINKLIDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool MGECHLFKPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string OMHHPMIDNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private StackTrace HJNILDEJBFE;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<FLFEOAPLLLI> LNMEBCFHPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x79F440", Offset = "0x79E840", VA = "0x18079F440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public FLFEOAPLLLI FINPMLEONLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x79F1B0", Offset = "0x79E5B0", VA = "0x18079F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool LJAGEFOFDEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6604DB0", Offset = "0x66041B0", VA = "0x186604DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool FCKGDPHFIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x80B900", Offset = "0x80AD00", VA = "0x18080B900")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x80B910", Offset = "0x80AD10", VA = "0x18080B910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6604E30", Offset = "0x6604230", VA = "0x186604E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float MJCOCGGLIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1073FF0", Offset = "0x10733F0", VA = "0x181073FF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5559D10", Offset = "0x5559110", VA = "0x185559D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x66053D0", Offset = "0x66047D0", VA = "0x1866053D0")]
	public ADJEEMLDENB(IEnumerator<FLFEOAPLLLI> EECJCDGPHNK, EEEMNJCOABC PEHINKLIDNC, AJNLPKEJBFG LBNBPFBOKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6604FE0", Offset = "0x66043E0", VA = "0x186604FE0")]
	public FLFEOAPLLLI OLFILPFAIHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6604CF0", Offset = "0x66040F0", VA = "0x186604CF0")]
	public bool FCLNFPHNKHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6604D60", Offset = "0x6604160", VA = "0x186604D60")]
	public void GFHNNFNCFKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x66052F0", Offset = "0x66046F0", VA = "0x1866052F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8890D0", Offset = "0x8884D0", VA = "0x1808890D0")]
	[CompilerGenerated]
	private void NKFKHOFKCPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class AJNLPKEJBFG : FCOLFLNDFAG, DHBMNMGGJAH, JJNFBJKAOML, BCACLFKFPHI, IEnumerator, FLFEOAPLLLI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private JAAKDEGMLAI KJOIPAPKLKG;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private JAAKDEGMLAI EFIOPGEDLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xDF4A30", Offset = "0xDF3E30", VA = "0x180DF4A30", Slot = "23")]
		get
		{
			return default(JAAKDEGMLAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public JAAKDEGMLAI KLGCHJFMJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x12D5C10", Offset = "0x12D5010", VA = "0x1812D5C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float EHGOCHDMNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7EBDC0", Offset = "0x7EB1C0", VA = "0x1807EBDC0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool NFPEJAFOCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6605D70", Offset = "0x6605170", VA = "0x186605D70", Slot = "24")]
	private bool CNGEPFHLCED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6605D90", Offset = "0x6605190", VA = "0x186605D90", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6605DA0", Offset = "0x66051A0", VA = "0x186605DA0")]
	public AJNLPKEJBFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum ADFLEALPBDI : byte
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
internal sealed class GFALIBHBCAI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum CKDJFIBMFKB
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct PHJGOPAHNDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public JAAKDEGMLAI NLIGGEDIOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CKDJFIBMFKB ANBBECPLBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public List<ADJEEMLDENB> PKKBFHGMCPL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly CKDJFIBMFKB[] MGBIOBIIGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly JAAKDEGMLAI EGDEBJAGPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private bool HHPBMDCEOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly ADJEEMLDENB[] EPNKOILEDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<ADJEEMLDENB> LEPCKCBACDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> DFFHLKKABAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<ADJEEMLDENB> GIIJKGCMCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<int> COIFKFLOIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly GJCNFHEDFCN LEOIJELJIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private bool DPEKFEGDLJG;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public PHJGOPAHNDG[,] NLJABAFGNCO
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x79F220", Offset = "0x79E620", VA = "0x18079F220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x66140D0", Offset = "0x66134D0", VA = "0x1866140D0")]
	public GFALIBHBCAI(JAAKDEGMLAI INJDPFHNFNL, GJCNFHEDFCN LEOIJELJIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6613E90", Offset = "0x6613290", VA = "0x186613E90")]
	public void PJFBCOCDENH(ADJEEMLDENB EECJCDGPHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6613300", Offset = "0x6612700", VA = "0x186613300")]
	public void FKJOAEPKCCO(IList<ADJEEMLDENB> PCFOEENOGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6613B80", Offset = "0x6612F80", VA = "0x186613B80")]
	public void PEJFLFNFKDP(IList<ADJEEMLDENB> PCFOEENOGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6613900", Offset = "0x6612D00", VA = "0x186613900")]
	private void LAGEJMBLADC(ADJEEMLDENB EECJCDGPHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x66139F0", Offset = "0x6612DF0", VA = "0x1866139F0")]
	private void NHPJNBHKKMJ(IList<ADJEEMLDENB> PCFOEENOGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6613610", Offset = "0x6612A10", VA = "0x186613610")]
	private ADFLEALPBDI HDFOJNGLKKG(ADJEEMLDENB EECJCDGPHNK)
	{
		return default(ADFLEALPBDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6613790", Offset = "0x6612B90", VA = "0x186613790")]
	public void JPBFJKJIHMJ(float DNHAFMNPMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6612BB0", Offset = "0x6611FB0", VA = "0x186612BB0")]
	public void AHFEEIEDIPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6612DA0", Offset = "0x66121A0", VA = "0x186612DA0")]
	private void AIPPNJGHOMN(List<ADJEEMLDENB> PCFOEENOGBI, Stack<int> GABODENMPHM, bool BHNDELGLPII, float LOGAEAMPDON = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x66130A0", Offset = "0x66124A0", VA = "0x1866130A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x66131C0", Offset = "0x66125C0", VA = "0x1866131C0")]
	private void FGHBKGDIGKB(List<ADJEEMLDENB> PCFOEENOGBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class AFCJDHLOLNI : GJCNFHEDFCN
{
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "4")]
	public void HHBEGKMADDL(string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
	public void GIMOKJPEELO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public AFCJDHLOLNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class JDJNMFOAFHF : EEEMNJCOABC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Behaviour HBOAILJIBKK;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6615830", Offset = "0x6614C30", VA = "0x186615830", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool MANBOABLAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x66157C0", Offset = "0x6614BC0", VA = "0x1866157C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool PMBPGIOGIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6615810", Offset = "0x6614C10", VA = "0x186615810", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	public JDJNMFOAFHF(Behaviour HBOAILJIBKK)
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
